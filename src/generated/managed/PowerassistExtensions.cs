//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Powerassist
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PowerassistActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<ArraySortResponse, ApiConnectionActionConfiguration> ArraySort(Expression<Func<ArraySortInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ArraySortResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/array/sort";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ArraySortResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<ArrayReverseResponse, ApiConnectionActionConfiguration> ArrayReverse(Expression<Func<ArrayReverseInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ArrayReverseResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/array/reverse";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ArrayReverseResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<ArraySortByPropertyResponse, ApiConnectionActionConfiguration> ArraySortByProperty(Expression<Func<ArraySortByPropertyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ArraySortByPropertyResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/array/sortByProperty";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ArraySortByPropertyResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<ArrayFilterResponse, ApiConnectionActionConfiguration> ArrayFilter(Expression<Func<ArrayFilterInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ArrayFilterResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/array/filter";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ArrayFilterResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<ArrayPrependResponse, ApiConnectionActionConfiguration> ArrayPrepend(Expression<Func<ArrayPrependInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ArrayPrependResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/array/prepend";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ArrayPrependResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<ArrayAnyResponse, ApiConnectionActionConfiguration> ArrayAny(Expression<Func<ArrayAnyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ArrayAnyResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/array/any";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ArrayAnyResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<ArrayEveryResponse, ApiConnectionActionConfiguration> ArrayEvery(Expression<Func<ArrayEveryInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ArrayEveryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/array/every";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ArrayEveryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<ArrayRemoveFirstResponse, ApiConnectionActionConfiguration> ArrayRemoveFirst(Expression<Func<ArrayRemoveFirstInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ArrayRemoveFirstResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/array/removeFirst";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ArrayRemoveFirstResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<ArrayGroupByResponse, ApiConnectionActionConfiguration> ArrayGroupBy(Expression<Func<ArrayGroupByInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ArrayGroupByResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/array/groupBy";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ArrayGroupByResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<ArrayFindFirstResponse, ApiConnectionActionConfiguration> ArrayFindFirst(Expression<Func<ArrayFindFirstInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ArrayFindFirstResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/array/findFirst";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ArrayFindFirstResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<RoundResponse, ApiConnectionActionConfiguration> Round(Expression<Func<RoundInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<RoundResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/math/round";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<RoundResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<MathCeilResponse, ApiConnectionActionConfiguration> MathCeil(Expression<Func<MathCeilInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<MathCeilResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/math/ceil";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MathCeilResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<MathFloorResponse, ApiConnectionActionConfiguration> MathFloor(Expression<Func<MathFloorInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<MathFloorResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/math/floor";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MathFloorResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<MathAverageResponse, ApiConnectionActionConfiguration> MathAverage(Expression<Func<MathAverageInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<MathAverageResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/math/average";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MathAverageResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<MathMedianResponse, ApiConnectionActionConfiguration> MathMedian(Expression<Func<MathMedianInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<MathMedianResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/math/median";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MathMedianResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<MathModeResponse, ApiConnectionActionConfiguration> MathMode(Expression<Func<MathModeInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<MathModeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/math/mode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MathModeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<MathRandomResponse, ApiConnectionActionConfiguration> MathRandom(Expression<Func<MathRandomInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<MathRandomResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/math/random";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MathRandomResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<StringReplaceAllResponse, ApiConnectionActionConfiguration> StringReplaceAll(Expression<Func<StringReplaceAllInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<StringReplaceAllResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/string/replaceAll";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<StringReplaceAllResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<StringRegexReplaceResponse, ApiConnectionActionConfiguration> StringRegexReplace(Expression<Func<StringRegexReplaceInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<StringRegexReplaceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/string/regexReplace";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<StringRegexReplaceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<StringCapitalizeResponse, ApiConnectionActionConfiguration> StringCapitalize(Expression<Func<StringCapitalizeInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<StringCapitalizeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/string/capitalize";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<StringCapitalizeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<StringTrimResponse, ApiConnectionActionConfiguration> StringTrim(Expression<Func<StringTrimInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<StringTrimResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/string/trim";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<StringTrimResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<StringTrimStartResponse, ApiConnectionActionConfiguration> StringTrimStart(Expression<Func<StringTrimStartInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<StringTrimStartResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/string/trimStart";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<StringTrimStartResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<StringTrimEndResponse, ApiConnectionActionConfiguration> StringTrimEnd(Expression<Func<StringTrimEndInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<StringTrimEndResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/string/trimEnd";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<StringTrimEndResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<StringSlugifyResponse, ApiConnectionActionConfiguration> StringSlugify(Expression<Func<StringSlugifyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<StringSlugifyResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/string/slugify";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<StringSlugifyResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<StringWordsResponse, ApiConnectionActionConfiguration> StringWords(Expression<Func<StringWordsInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<StringWordsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/string/words";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<StringWordsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<StringWordCountResponse, ApiConnectionActionConfiguration> StringWordCount(Expression<Func<StringWordCountInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<StringWordCountResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/string/wordCount";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<StringWordCountResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<StringStripHtmlResponse, ApiConnectionActionConfiguration> StringStripHtml(Expression<Func<StringStripHtmlInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<StringStripHtmlResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/string/stripHtml";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<StringStripHtmlResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<StringCleanResponse, ApiConnectionActionConfiguration> StringClean(Expression<Func<StringCleanInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<StringCleanResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/string/clean";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<StringCleanResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<StringCleanDiacriticsResponse, ApiConnectionActionConfiguration> StringCleanDiacritics(Expression<Func<StringCleanDiacriticsInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<StringCleanDiacriticsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/string/cleanDiacritics";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<StringCleanDiacriticsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<StringEscapeHtmlResponse, ApiConnectionActionConfiguration> StringEscapeHtml(Expression<Func<StringEscapeHtmlInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<StringEscapeHtmlResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/string/escapeHtml";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<StringEscapeHtmlResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<StringUnescapeHtmlResponse, ApiConnectionActionConfiguration> StringUnescapeHtml(Expression<Func<StringUnescapeHtmlInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<StringUnescapeHtmlResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/string/unescapeHtml";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<StringUnescapeHtmlResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<StringCountInstancesResponse, ApiConnectionActionConfiguration> StringCountInstances(Expression<Func<StringCountInstancesInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<StringCountInstancesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/string/countInstances";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<StringCountInstancesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<StringChopResponse, ApiConnectionActionConfiguration> StringChop(Expression<Func<StringChopInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<StringChopResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/string/chop";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<StringChopResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<TypesIsStringResponse, ApiConnectionActionConfiguration> TypesIsString(Expression<Func<TypesIsStringInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<TypesIsStringResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/types/isString";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<TypesIsStringResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<TypesIsNumberResponse, ApiConnectionActionConfiguration> TypesIsNumber(Expression<Func<TypesIsNumberInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<TypesIsNumberResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/types/isNumber";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<TypesIsNumberResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<TypesIsNullOrEmptyResponse, ApiConnectionActionConfiguration> TypesIsNullOrEmpty(Expression<Func<TypesIsNullOrEmptyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<TypesIsNullOrEmptyResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/types/isNullOrEmpty";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<TypesIsNullOrEmptyResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<TypesIsArrayResponse, ApiConnectionActionConfiguration> TypesIsArray(Expression<Func<TypesIsArrayInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<TypesIsArrayResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/types/isArray";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<TypesIsArrayResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<TypesIsObjectResponse, ApiConnectionActionConfiguration> TypesIsObject(Expression<Func<TypesIsObjectInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<TypesIsObjectResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/types/isObject";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<TypesIsObjectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<ValidateEmailResponse, ApiConnectionActionConfiguration> ValidateEmail(Expression<Func<ValidateEmailInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ValidateEmailResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/validate/email";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ValidateEmailResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<ValidateRegexResponse, ApiConnectionActionConfiguration> ValidateRegex(Expression<Func<ValidateRegexInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ValidateRegexResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/validate/regex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ValidateRegexResponse>(callPayload);
            });
        }
    }

    public class PowerassistTriggers([ConnectionName] string connectionId)
    {
    }

    public class ArraySortResponse
    {
        public JToken[] Result { get; set; }
    }

    public class ArraySortInput
    {
        [JsonProperty("array", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken[] Array { get; set; }
    }

    public class ArrayReverseResponse
    {
        public JToken[] Result { get; set; }
    }

    public class ArrayReverseInput
    {
        [JsonProperty("array", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken[] Array { get; set; }
    }

    public class ArraySortByPropertyResponse
    {
        public JToken[] Result { get; set; }
    }

    public class ArraySortByPropertyInput
    {
        [JsonProperty("array", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken[] Array { get; set; }

        [JsonProperty("propertyName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PropertyName { get; set; }

        [JsonProperty("descending", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool Descending { get; set; }
    }

    public class ArrayFilterResponse
    {
        public JToken[] Result { get; set; }
    }

    public class ArrayFilterInput
    {
        [JsonProperty("array", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken[] Array { get; set; }

        [JsonProperty("propertyName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PropertyName { get; set; }

        [JsonProperty("comparison", DefaultValueHandling = DefaultValueHandling.Include)]
        public ArrayFilterInputComparisonType Comparison { get; set; } = ArrayFilterInputComparisonType.Equals;

        [JsonProperty("value")]
        public JToken Value { get; set; }

        [JsonProperty("valueType", DefaultValueHandling = DefaultValueHandling.Include)]
        public ArrayFilterInputValueTypeType? ValueType { get; set; } = ArrayFilterInputValueTypeType.String;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ArrayFilterInputComparisonType
    {
        [EnumMember(Value = "equals")]
        Equals,
        [EnumMember(Value = "does not equal")]
        DoesNotEqual,
        [EnumMember(Value = "is greater than")]
        IsGreaterThan,
        [EnumMember(Value = "is greater than or equal to")]
        IsGreaterThanOrEqualTo,
        [EnumMember(Value = "is less than")]
        IsLessThan,
        [EnumMember(Value = "is less than or equal to")]
        IsLessThanOrEqualTo,
        [EnumMember(Value = "is null or undefined")]
        IsNullOrUndefined,
        [EnumMember(Value = "is not null or undefined")]
        IsNotNullOrUndefined
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ArrayFilterInputValueTypeType
    {
        String,
        Boolean,
        Integer,
        Float
    }

    public class ArrayPrependResponse
    {
        public JToken[] Result { get; set; }
    }

    public class ArrayPrependInput
    {
        [JsonProperty("array", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken[] Array { get; set; }

        [JsonProperty("value", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Value { get; set; }

        [JsonProperty("valueType", DefaultValueHandling = DefaultValueHandling.Include)]
        public ArrayPrependInputValueTypeType? ValueType { get; set; } = ArrayPrependInputValueTypeType.String;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ArrayPrependInputValueTypeType
    {
        String,
        Boolean,
        Integer,
        Float,
        Array,
        [EnumMember(Value = "Object")]
        ObjectEntity
    }

    public class ArrayAnyResponse
    {
        public bool Result { get; set; }
    }

    public class ArrayAnyInput
    {
        [JsonProperty("array", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken[] Array { get; set; }

        [JsonProperty("propertyName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PropertyName { get; set; }

        [JsonProperty("comparison", DefaultValueHandling = DefaultValueHandling.Include)]
        public ArrayAnyInputComparisonType Comparison { get; set; } = ArrayAnyInputComparisonType.Equals;

        [JsonProperty("value")]
        public JToken Value { get; set; }

        [JsonProperty("valueType", DefaultValueHandling = DefaultValueHandling.Include)]
        public ArrayAnyInputValueTypeType? ValueType { get; set; } = ArrayAnyInputValueTypeType.String;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ArrayAnyInputComparisonType
    {
        [EnumMember(Value = "equals")]
        Equals,
        [EnumMember(Value = "does not equal")]
        DoesNotEqual,
        [EnumMember(Value = "is greater than")]
        IsGreaterThan,
        [EnumMember(Value = "is greater than or equal to")]
        IsGreaterThanOrEqualTo,
        [EnumMember(Value = "is less than")]
        IsLessThan,
        [EnumMember(Value = "is less than or equal to")]
        IsLessThanOrEqualTo,
        [EnumMember(Value = "is null or undefined")]
        IsNullOrUndefined,
        [EnumMember(Value = "is not null or undefined")]
        IsNotNullOrUndefined
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ArrayAnyInputValueTypeType
    {
        String,
        Boolean,
        Integer,
        Float
    }

    public class ArrayEveryResponse
    {
        public bool Result { get; set; }
    }

    public class ArrayEveryInput
    {
        [JsonProperty("array", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken[] Array { get; set; }

        [JsonProperty("propertyName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PropertyName { get; set; }

        [JsonProperty("comparison", DefaultValueHandling = DefaultValueHandling.Include)]
        public ArrayEveryInputComparisonType Comparison { get; set; } = ArrayEveryInputComparisonType.Equals;

        [JsonProperty("value")]
        public JToken Value { get; set; }

        [JsonProperty("valueType", DefaultValueHandling = DefaultValueHandling.Include)]
        public ArrayEveryInputValueTypeType? ValueType { get; set; } = ArrayEveryInputValueTypeType.String;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ArrayEveryInputComparisonType
    {
        [EnumMember(Value = "equals")]
        Equals,
        [EnumMember(Value = "does not equal")]
        DoesNotEqual,
        [EnumMember(Value = "is greater than")]
        IsGreaterThan,
        [EnumMember(Value = "is greater than or equal to")]
        IsGreaterThanOrEqualTo,
        [EnumMember(Value = "is less than")]
        IsLessThan,
        [EnumMember(Value = "is less than or equal to")]
        IsLessThanOrEqualTo,
        [EnumMember(Value = "is null or undefined")]
        IsNullOrUndefined,
        [EnumMember(Value = "is not null or undefined")]
        IsNotNullOrUndefined
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ArrayEveryInputValueTypeType
    {
        String,
        Boolean,
        Integer,
        Float
    }

    public class ArrayRemoveFirstResponse
    {
        public JToken[] Result { get; set; }
    }

    public class ArrayRemoveFirstInput
    {
        [JsonProperty("array", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken[] Array { get; set; }

        [JsonProperty("propertyName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PropertyName { get; set; }

        [JsonProperty("comparison", DefaultValueHandling = DefaultValueHandling.Include)]
        public ArrayRemoveFirstInputComparisonType Comparison { get; set; } = ArrayRemoveFirstInputComparisonType.Equals;

        [JsonProperty("value")]
        public JToken Value { get; set; }

        [JsonProperty("valueType", DefaultValueHandling = DefaultValueHandling.Include)]
        public ArrayRemoveFirstInputValueTypeType? ValueType { get; set; } = ArrayRemoveFirstInputValueTypeType.String;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ArrayRemoveFirstInputComparisonType
    {
        [EnumMember(Value = "equals")]
        Equals,
        [EnumMember(Value = "does not equal")]
        DoesNotEqual,
        [EnumMember(Value = "is greater than")]
        IsGreaterThan,
        [EnumMember(Value = "is greater than or equal to")]
        IsGreaterThanOrEqualTo,
        [EnumMember(Value = "is less than")]
        IsLessThan,
        [EnumMember(Value = "is less than or equal to")]
        IsLessThanOrEqualTo,
        [EnumMember(Value = "is null or undefined")]
        IsNullOrUndefined,
        [EnumMember(Value = "is not null or undefined")]
        IsNotNullOrUndefined
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ArrayRemoveFirstInputValueTypeType
    {
        String,
        Boolean,
        Integer,
        Float
    }

    public class ArrayGroupByResponse
    {
        public JToken Result { get; set; }
    }

    public class ArrayGroupByInput
    {
        [JsonProperty("array", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken[] Array { get; set; }

        [JsonProperty("propertyName")]
        public string PropertyName { get; set; }
    }

    public class ArrayFindFirstResponse
    {
        public JToken Result { get; set; }
    }

    public class ArrayFindFirstInput
    {
        [JsonProperty("array", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken[] Array { get; set; }

        [JsonProperty("propertyName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PropertyName { get; set; }

        [JsonProperty("comparison", DefaultValueHandling = DefaultValueHandling.Include)]
        public ArrayFindFirstInputComparisonType Comparison { get; set; } = ArrayFindFirstInputComparisonType.Equals;

        [JsonProperty("value")]
        public JToken Value { get; set; }

        [JsonProperty("valueType", DefaultValueHandling = DefaultValueHandling.Include)]
        public ArrayFindFirstInputValueTypeType? ValueType { get; set; } = ArrayFindFirstInputValueTypeType.String;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ArrayFindFirstInputComparisonType
    {
        [EnumMember(Value = "equals")]
        Equals,
        [EnumMember(Value = "does not equal")]
        DoesNotEqual,
        [EnumMember(Value = "is greater than")]
        IsGreaterThan,
        [EnumMember(Value = "is greater than or equal to")]
        IsGreaterThanOrEqualTo,
        [EnumMember(Value = "is less than")]
        IsLessThan,
        [EnumMember(Value = "is less than or equal to")]
        IsLessThanOrEqualTo,
        [EnumMember(Value = "is null or undefined")]
        IsNullOrUndefined,
        [EnumMember(Value = "is not null or undefined")]
        IsNotNullOrUndefined
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ArrayFindFirstInputValueTypeType
    {
        String,
        Boolean,
        Integer,
        Float
    }

    public class RoundResponse
    {
        public int Result { get; set; }
    }

    public class RoundInput
    {
        [JsonProperty("number", DefaultValueHandling = DefaultValueHandling.Include)]
        public double Number { get; set; }
    }

    public class MathCeilResponse
    {
        public int Result { get; set; }
    }

    public class MathCeilInput
    {
        [JsonProperty("number", DefaultValueHandling = DefaultValueHandling.Include)]
        public double Number { get; set; }
    }

    public class MathFloorResponse
    {
        public int Result { get; set; }
    }

    public class MathFloorInput
    {
        [JsonProperty("number", DefaultValueHandling = DefaultValueHandling.Include)]
        public double Number { get; set; }
    }

    public class MathAverageResponse
    {
        public double Result { get; set; }
    }

    public class MathAverageInput
    {
        [JsonProperty("numbers", DefaultValueHandling = DefaultValueHandling.Include)]
        public double[] Numbers { get; set; }
    }

    public class MathMedianResponse
    {
        public double Result { get; set; }
    }

    public class MathMedianInput
    {
        [JsonProperty("numbers", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken[] Numbers { get; set; }
    }

    public class MathModeResponse
    {
        public double Result { get; set; }
    }

    public class MathModeInput
    {
        [JsonProperty("numbers", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken[] Numbers { get; set; }
    }

    public class MathRandomResponse
    {
        public double Result { get; set; }
    }

    public class MathRandomInput
    {
        [JsonProperty("maximum", DefaultValueHandling = DefaultValueHandling.Include)]
        public int Maximum { get; set; }
    }

    public class StringReplaceAllResponse
    {
        public string Result { get; set; }
    }

    public class StringReplaceAllInput
    {
        [JsonProperty("sourceString", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceString { get; set; }

        [JsonProperty("searchValue", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchValue { get; set; }

        [JsonProperty("replaceValue", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ReplaceValue { get; set; }
    }

    public class StringRegexReplaceResponse
    {
        public string Result { get; set; }
    }

    public class StringRegexReplaceInput
    {
        [JsonProperty("sourceString", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceString { get; set; }

        [JsonProperty("pattern", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Pattern { get; set; }

        [JsonProperty("replaceValue", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ReplaceValue { get; set; }
    }

    public class StringCapitalizeResponse
    {
        public string Result { get; set; }
    }

    public class StringCapitalizeInput
    {
        [JsonProperty("string", DefaultValueHandling = DefaultValueHandling.Include)]
        public string String { get; set; }
    }

    public class StringTrimResponse
    {
        public string Result { get; set; }
    }

    public class StringTrimInput
    {
        [JsonProperty("string", DefaultValueHandling = DefaultValueHandling.Include)]
        public string String { get; set; }

        [JsonProperty("characters")]
        public string Characters { get; set; }
    }

    public class StringTrimStartResponse
    {
        public string Result { get; set; }
    }

    public class StringTrimStartInput
    {
        [JsonProperty("string", DefaultValueHandling = DefaultValueHandling.Include)]
        public string String { get; set; }

        [JsonProperty("characters")]
        public string Characters { get; set; }
    }

    public class StringTrimEndResponse
    {
        public string Result { get; set; }
    }

    public class StringTrimEndInput
    {
        [JsonProperty("string", DefaultValueHandling = DefaultValueHandling.Include)]
        public string String { get; set; }

        [JsonProperty("characters")]
        public string Characters { get; set; }
    }

    public class StringSlugifyResponse
    {
        public string Result { get; set; }
    }

    public class StringSlugifyInput
    {
        [JsonProperty("string", DefaultValueHandling = DefaultValueHandling.Include)]
        public string String { get; set; }
    }

    public class StringWordsResponse
    {
        public JToken[] Result { get; set; }
    }

    public class StringWordsInput
    {
        [JsonProperty("string", DefaultValueHandling = DefaultValueHandling.Include)]
        public string String { get; set; }

        [JsonProperty("delimiter")]
        public string Delimiter { get; set; }
    }

    public class StringWordCountResponse
    {
        public int Result { get; set; }
    }

    public class StringWordCountInput
    {
        [JsonProperty("string", DefaultValueHandling = DefaultValueHandling.Include)]
        public string String { get; set; }

        [JsonProperty("delimiter")]
        public string Delimiter { get; set; }
    }

    public class StringStripHtmlResponse
    {
        public string Result { get; set; }
    }

    public class StringStripHtmlInput
    {
        [JsonProperty("string", DefaultValueHandling = DefaultValueHandling.Include)]
        public string String { get; set; }
    }

    public class StringCleanResponse
    {
        public string Result { get; set; }
    }

    public class StringCleanInput
    {
        [JsonProperty("string", DefaultValueHandling = DefaultValueHandling.Include)]
        public string String { get; set; }
    }

    public class StringCleanDiacriticsResponse
    {
        public string Result { get; set; }
    }

    public class StringCleanDiacriticsInput
    {
        [JsonProperty("string", DefaultValueHandling = DefaultValueHandling.Include)]
        public string String { get; set; }
    }

    public class StringEscapeHtmlResponse
    {
        public string Result { get; set; }
    }

    public class StringEscapeHtmlInput
    {
        [JsonProperty("string", DefaultValueHandling = DefaultValueHandling.Include)]
        public string String { get; set; }
    }

    public class StringUnescapeHtmlResponse
    {
        public string Result { get; set; }
    }

    public class StringUnescapeHtmlInput
    {
        [JsonProperty("string", DefaultValueHandling = DefaultValueHandling.Include)]
        public string String { get; set; }
    }

    public class StringCountInstancesResponse
    {
        public int Result { get; set; }
    }

    public class StringCountInstancesInput
    {
        [JsonProperty("string", DefaultValueHandling = DefaultValueHandling.Include)]
        public string String { get; set; }

        [JsonProperty("substring", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Substring { get; set; }

        [JsonProperty("ignoreCase", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IgnoreCase { get; set; } = false;
    }

    public class StringChopResponse
    {
        public JToken[] Result { get; set; }
    }

    public class StringChopInput
    {
        [JsonProperty("string", DefaultValueHandling = DefaultValueHandling.Include)]
        public string String { get; set; }

        [JsonProperty("interval", DefaultValueHandling = DefaultValueHandling.Include)]
        public int Interval { get; set; }
    }

    public class TypesIsStringResponse
    {
        public bool Result { get; set; }
    }

    public class TypesIsStringInput
    {
        [JsonProperty("value", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Value { get; set; }
    }

    public class TypesIsNumberResponse
    {
        public bool Result { get; set; }
    }

    public class TypesIsNumberInput
    {
        [JsonProperty("value", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Value { get; set; }

        [JsonProperty("includeNumbersInStrings", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool IncludeNumbersInStrings { get; set; }
    }

    public class TypesIsNullOrEmptyResponse
    {
        public bool Result { get; set; }
    }

    public class TypesIsNullOrEmptyInput
    {
        [JsonProperty("value", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Value { get; set; }
    }

    public class TypesIsArrayResponse
    {
        public bool Result { get; set; }
    }

    public class TypesIsArrayInput
    {
        [JsonProperty("value", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Value { get; set; }
    }

    public class TypesIsObjectResponse
    {
        public bool Result { get; set; }
    }

    public class TypesIsObjectInput
    {
        [JsonProperty("value", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Value { get; set; }
    }

    public class ValidateEmailResponse
    {
        public bool Result { get; set; }
    }

    public class ValidateEmailInput
    {
        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Email { get; set; }
    }

    public class ValidateRegexResponse
    {
        public bool Result { get; set; }
    }

    public class ValidateRegexInput
    {
        [JsonProperty("string", DefaultValueHandling = DefaultValueHandling.Include)]
        public string String { get; set; }

        [JsonProperty("pattern", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Pattern { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Powerassist;

    public partial class WorkflowManagedActions
    {
        public PowerassistActions Powerassist(string connectionId) => new PowerassistActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PowerassistTriggers Powerassist(string connectionId) => new PowerassistTriggers(connectionId);
    }
}