//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Powerassist
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PowerassistActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<ArraySortResponse> ArraySort(Expression<Func<JToken[]>> bodyarray)
        {
            var apiCallPath = "/array/sort";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["array"] = ExpressionConverter.ConvertO(bodyarray);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ArraySortResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<ArrayReverseResponse> ArrayReverse(Expression<Func<JToken[]>> bodyarray)
        {
            var apiCallPath = "/array/reverse";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["array"] = ExpressionConverter.ConvertO(bodyarray);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ArrayReverseResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<ArraySortByPropertyResponse> ArraySortByProperty(Expression<Func<JToken[]>> bodyarray, Expression<Func<string>> bodypropertyName, Expression<Func<bool>> bodydescending)
        {
            var apiCallPath = "/array/sortByProperty";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["array"] = ExpressionConverter.ConvertO(bodyarray);
            bodypropCount++;
            body["propertyName"] = ExpressionConverter.ConvertO(bodypropertyName);
            bodypropCount++;
            body["descending"] = ExpressionConverter.ConvertO(bodydescending);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ArraySortByPropertyResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<ArrayFilterResponse> ArrayFilter(Expression<Func<JToken[]>> bodyarray, Expression<Func<string>> bodypropertyName, Expression<Func<bodycomparisonInput>> bodycomparison, Expression<Func<object>> bodyvalue = null, Expression<Func<bodyvalueTypeInput>> bodyvalueType = null)
        {
            var apiCallPath = "/array/filter";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["array"] = ExpressionConverter.ConvertO(bodyarray);
            bodypropCount++;
            body["propertyName"] = ExpressionConverter.ConvertO(bodypropertyName);
            bodypropCount++;
            body["comparison"] = ExpressionConverter.ConvertO(bodycomparison);
            if (bodyvalue != null)
            {
                body["value"] = ExpressionConverter.ConvertO(bodyvalue);
                bodypropCount++;
            }

            if (bodyvalueType != null)
            {
                body["valueType"] = ExpressionConverter.ConvertO(bodyvalueType);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ArrayFilterResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<ArrayPrependResponse> ArrayPrepend(Expression<Func<JToken[]>> bodyarray, Expression<Func<object>> bodyvalue, Expression<Func<bodyvalueTypeInput>> bodyvalueType = null)
        {
            var apiCallPath = "/array/prepend";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["array"] = ExpressionConverter.ConvertO(bodyarray);
            bodypropCount++;
            body["value"] = ExpressionConverter.ConvertO(bodyvalue);
            if (bodyvalueType != null)
            {
                body["valueType"] = ExpressionConverter.ConvertO(bodyvalueType);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ArrayPrependResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<ArrayAnyResponse> ArrayAny(Expression<Func<JToken[]>> bodyarray, Expression<Func<string>> bodypropertyName, Expression<Func<bodycomparisonInput>> bodycomparison, Expression<Func<object>> bodyvalue = null, Expression<Func<bodyvalueTypeInput>> bodyvalueType = null)
        {
            var apiCallPath = "/array/any";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["array"] = ExpressionConverter.ConvertO(bodyarray);
            bodypropCount++;
            body["propertyName"] = ExpressionConverter.ConvertO(bodypropertyName);
            bodypropCount++;
            body["comparison"] = ExpressionConverter.ConvertO(bodycomparison);
            if (bodyvalue != null)
            {
                body["value"] = ExpressionConverter.ConvertO(bodyvalue);
                bodypropCount++;
            }

            if (bodyvalueType != null)
            {
                body["valueType"] = ExpressionConverter.ConvertO(bodyvalueType);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ArrayAnyResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<ArrayEveryResponse> ArrayEvery(Expression<Func<JToken[]>> bodyarray, Expression<Func<string>> bodypropertyName, Expression<Func<bodycomparisonInput>> bodycomparison, Expression<Func<object>> bodyvalue = null, Expression<Func<bodyvalueTypeInput>> bodyvalueType = null)
        {
            var apiCallPath = "/array/every";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["array"] = ExpressionConverter.ConvertO(bodyarray);
            bodypropCount++;
            body["propertyName"] = ExpressionConverter.ConvertO(bodypropertyName);
            bodypropCount++;
            body["comparison"] = ExpressionConverter.ConvertO(bodycomparison);
            if (bodyvalue != null)
            {
                body["value"] = ExpressionConverter.ConvertO(bodyvalue);
                bodypropCount++;
            }

            if (bodyvalueType != null)
            {
                body["valueType"] = ExpressionConverter.ConvertO(bodyvalueType);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ArrayEveryResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<ArrayRemoveFirstResponse> ArrayRemoveFirst(Expression<Func<JToken[]>> bodyarray, Expression<Func<string>> bodypropertyName, Expression<Func<bodycomparisonInput>> bodycomparison, Expression<Func<object>> bodyvalue = null, Expression<Func<bodyvalueTypeInput>> bodyvalueType = null)
        {
            var apiCallPath = "/array/removeFirst";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["array"] = ExpressionConverter.ConvertO(bodyarray);
            bodypropCount++;
            body["propertyName"] = ExpressionConverter.ConvertO(bodypropertyName);
            bodypropCount++;
            body["comparison"] = ExpressionConverter.ConvertO(bodycomparison);
            if (bodyvalue != null)
            {
                body["value"] = ExpressionConverter.ConvertO(bodyvalue);
                bodypropCount++;
            }

            if (bodyvalueType != null)
            {
                body["valueType"] = ExpressionConverter.ConvertO(bodyvalueType);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ArrayRemoveFirstResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<ArrayGroupByResponse> ArrayGroupBy(Expression<Func<JToken[]>> bodyarray, Expression<Func<string>> bodypropertyName = null)
        {
            var apiCallPath = "/array/groupBy";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["array"] = ExpressionConverter.ConvertO(bodyarray);
            if (bodypropertyName != null)
            {
                body["propertyName"] = ExpressionConverter.ConvertO(bodypropertyName);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ArrayGroupByResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<ArrayFindFirstResponse> ArrayFindFirst(Expression<Func<JToken[]>> bodyarray, Expression<Func<string>> bodypropertyName, Expression<Func<bodycomparisonInput>> bodycomparison, Expression<Func<object>> bodyvalue = null, Expression<Func<bodyvalueTypeInput>> bodyvalueType = null)
        {
            var apiCallPath = "/array/findFirst";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["array"] = ExpressionConverter.ConvertO(bodyarray);
            bodypropCount++;
            body["propertyName"] = ExpressionConverter.ConvertO(bodypropertyName);
            bodypropCount++;
            body["comparison"] = ExpressionConverter.ConvertO(bodycomparison);
            if (bodyvalue != null)
            {
                body["value"] = ExpressionConverter.ConvertO(bodyvalue);
                bodypropCount++;
            }

            if (bodyvalueType != null)
            {
                body["valueType"] = ExpressionConverter.ConvertO(bodyvalueType);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ArrayFindFirstResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<RoundResponse> Round(Expression<Func<double>> bodynumber)
        {
            var apiCallPath = "/math/round";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["number"] = ExpressionConverter.ConvertO(bodynumber);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<RoundResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<MathCeilResponse> MathCeil(Expression<Func<double>> bodynumber)
        {
            var apiCallPath = "/math/ceil";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["number"] = ExpressionConverter.ConvertO(bodynumber);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<MathCeilResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<MathFloorResponse> MathFloor(Expression<Func<double>> bodynumber)
        {
            var apiCallPath = "/math/floor";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["number"] = ExpressionConverter.ConvertO(bodynumber);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<MathFloorResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<MathAverageResponse> MathAverage(Expression<Func<double[]>> bodynumbers)
        {
            var apiCallPath = "/math/average";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["numbers"] = ExpressionConverter.ConvertO(bodynumbers);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<MathAverageResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<MathMedianResponse> MathMedian(Expression<Func<JToken[]>> bodynumbers)
        {
            var apiCallPath = "/math/median";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["numbers"] = ExpressionConverter.ConvertO(bodynumbers);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<MathMedianResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<MathModeResponse> MathMode(Expression<Func<JToken[]>> bodynumbers)
        {
            var apiCallPath = "/math/mode";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["numbers"] = ExpressionConverter.ConvertO(bodynumbers);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<MathModeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<MathRandomResponse> MathRandom(Expression<Func<int>> bodymaximum)
        {
            var apiCallPath = "/math/random";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["maximum"] = ExpressionConverter.ConvertO(bodymaximum);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<MathRandomResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<StringReplaceAllResponse> StringReplaceAll(Expression<Func<string>> bodysourceString, Expression<Func<string>> bodysearchValue, Expression<Func<string>> bodyreplaceValue)
        {
            var apiCallPath = "/string/replaceAll";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["sourceString"] = ExpressionConverter.ConvertO(bodysourceString);
            bodypropCount++;
            body["searchValue"] = ExpressionConverter.ConvertO(bodysearchValue);
            bodypropCount++;
            body["replaceValue"] = ExpressionConverter.ConvertO(bodyreplaceValue);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<StringReplaceAllResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<StringRegexReplaceResponse> StringRegexReplace(Expression<Func<string>> bodysourceString, Expression<Func<string>> bodypattern, Expression<Func<string>> bodyreplaceValue)
        {
            var apiCallPath = "/string/regexReplace";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["sourceString"] = ExpressionConverter.ConvertO(bodysourceString);
            bodypropCount++;
            body["pattern"] = ExpressionConverter.ConvertO(bodypattern);
            bodypropCount++;
            body["replaceValue"] = ExpressionConverter.ConvertO(bodyreplaceValue);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<StringRegexReplaceResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<StringCapitalizeResponse> StringCapitalize(Expression<Func<string>> bodystring)
        {
            var apiCallPath = "/string/capitalize";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["string"] = ExpressionConverter.ConvertO(bodystring);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<StringCapitalizeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<StringTrimResponse> StringTrim(Expression<Func<string>> bodystring, Expression<Func<string>> bodycharacters = null)
        {
            var apiCallPath = "/string/trim";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["string"] = ExpressionConverter.ConvertO(bodystring);
            if (bodycharacters != null)
            {
                body["characters"] = ExpressionConverter.ConvertO(bodycharacters);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<StringTrimResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<StringTrimStartResponse> StringTrimStart(Expression<Func<string>> bodystring, Expression<Func<string>> bodycharacters = null)
        {
            var apiCallPath = "/string/trimStart";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["string"] = ExpressionConverter.ConvertO(bodystring);
            if (bodycharacters != null)
            {
                body["characters"] = ExpressionConverter.ConvertO(bodycharacters);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<StringTrimStartResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<StringTrimEndResponse> StringTrimEnd(Expression<Func<string>> bodystring, Expression<Func<string>> bodycharacters = null)
        {
            var apiCallPath = "/string/trimEnd";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["string"] = ExpressionConverter.ConvertO(bodystring);
            if (bodycharacters != null)
            {
                body["characters"] = ExpressionConverter.ConvertO(bodycharacters);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<StringTrimEndResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<StringSlugifyResponse> StringSlugify(Expression<Func<string>> bodystring)
        {
            var apiCallPath = "/string/slugify";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["string"] = ExpressionConverter.ConvertO(bodystring);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<StringSlugifyResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<StringWordsResponse> StringWords(Expression<Func<string>> bodystring, Expression<Func<string>> bodydelimiter = null)
        {
            var apiCallPath = "/string/words";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["string"] = ExpressionConverter.ConvertO(bodystring);
            if (bodydelimiter != null)
            {
                body["delimiter"] = ExpressionConverter.ConvertO(bodydelimiter);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<StringWordsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<StringWordCountResponse> StringWordCount(Expression<Func<string>> bodystring, Expression<Func<string>> bodydelimiter = null)
        {
            var apiCallPath = "/string/wordCount";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["string"] = ExpressionConverter.ConvertO(bodystring);
            if (bodydelimiter != null)
            {
                body["delimiter"] = ExpressionConverter.ConvertO(bodydelimiter);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<StringWordCountResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<StringStripHtmlResponse> StringStripHtml(Expression<Func<string>> bodystring)
        {
            var apiCallPath = "/string/stripHtml";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["string"] = ExpressionConverter.ConvertO(bodystring);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<StringStripHtmlResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<StringCleanResponse> StringClean(Expression<Func<string>> bodystring)
        {
            var apiCallPath = "/string/clean";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["string"] = ExpressionConverter.ConvertO(bodystring);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<StringCleanResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<StringCleanDiacriticsResponse> StringCleanDiacritics(Expression<Func<string>> bodystring)
        {
            var apiCallPath = "/string/cleanDiacritics";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["string"] = ExpressionConverter.ConvertO(bodystring);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<StringCleanDiacriticsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<StringEscapeHtmlResponse> StringEscapeHtml(Expression<Func<string>> bodystring)
        {
            var apiCallPath = "/string/escapeHtml";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["string"] = ExpressionConverter.ConvertO(bodystring);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<StringEscapeHtmlResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<StringUnescapeHtmlResponse> StringUnescapeHtml(Expression<Func<string>> bodystring)
        {
            var apiCallPath = "/string/unescapeHtml";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["string"] = ExpressionConverter.ConvertO(bodystring);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<StringUnescapeHtmlResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<StringCountInstancesResponse> StringCountInstances(Expression<Func<string>> bodystring, Expression<Func<string>> bodysubstring, Expression<Func<bool>> bodyignoreCase = null)
        {
            var apiCallPath = "/string/countInstances";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["string"] = ExpressionConverter.ConvertO(bodystring);
            bodypropCount++;
            body["substring"] = ExpressionConverter.ConvertO(bodysubstring);
            if (bodyignoreCase != null)
            {
                body["ignoreCase"] = ExpressionConverter.ConvertO(bodyignoreCase);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<StringCountInstancesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<StringChopResponse> StringChop(Expression<Func<string>> bodystring, Expression<Func<int>> bodyinterval)
        {
            var apiCallPath = "/string/chop";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["string"] = ExpressionConverter.ConvertO(bodystring);
            bodypropCount++;
            body["interval"] = ExpressionConverter.ConvertO(bodyinterval);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<StringChopResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<TypesIsStringResponse> TypesIsString(Expression<Func<object>> bodyvalue)
        {
            var apiCallPath = "/types/isString";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["value"] = ExpressionConverter.ConvertO(bodyvalue);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<TypesIsStringResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<TypesIsNumberResponse> TypesIsNumber(Expression<Func<object>> bodyvalue, Expression<Func<bool>> bodyincludeNumbersInStrings)
        {
            var apiCallPath = "/types/isNumber";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["value"] = ExpressionConverter.ConvertO(bodyvalue);
            bodypropCount++;
            body["includeNumbersInStrings"] = ExpressionConverter.ConvertO(bodyincludeNumbersInStrings);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<TypesIsNumberResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<TypesIsNullOrEmptyResponse> TypesIsNullOrEmpty(Expression<Func<object>> bodyvalue)
        {
            var apiCallPath = "/types/isNullOrEmpty";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["value"] = ExpressionConverter.ConvertO(bodyvalue);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<TypesIsNullOrEmptyResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<TypesIsArrayResponse> TypesIsArray(Expression<Func<object>> bodyvalue)
        {
            var apiCallPath = "/types/isArray";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["value"] = ExpressionConverter.ConvertO(bodyvalue);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<TypesIsArrayResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<TypesIsObjectResponse> TypesIsObject(Expression<Func<object>> bodyvalue)
        {
            var apiCallPath = "/types/isObject";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["value"] = ExpressionConverter.ConvertO(bodyvalue);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<TypesIsObjectResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<ValidateEmailResponse> ValidateEmail(Expression<Func<string>> bodyemail)
        {
            var apiCallPath = "/validate/email";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["email"] = ExpressionConverter.ConvertO(bodyemail);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ValidateEmailResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<ValidateRegexResponse> ValidateRegex(Expression<Func<string>> bodystring, Expression<Func<string>> bodypattern)
        {
            var apiCallPath = "/validate/regex";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["string"] = ExpressionConverter.ConvertO(bodystring);
            bodypropCount++;
            body["pattern"] = ExpressionConverter.ConvertO(bodypattern);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ValidateRegexResponse>(callPayload);
        }
    }

    public class PowerassistTriggers([ConnectionName] string connectionId)
    {
    }

    public class ArraySortResponse
    {
        public JToken[] Result { get; set; }
    }

    public class ArrayReverseResponse
    {
        public JToken[] Result { get; set; }
    }

    public class ArraySortByPropertyResponse
    {
        public JToken[] Result { get; set; }
    }

    public class ArrayFilterResponse
    {
        public JToken[] Result { get; set; }
    }

    public enum bodycomparisonInput
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

    public enum bodyvalueTypeInput
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

    public class ArrayAnyResponse
    {
        public bool Result { get; set; }
    }

    public class ArrayEveryResponse
    {
        public bool Result { get; set; }
    }

    public class ArrayRemoveFirstResponse
    {
        public JToken[] Result { get; set; }
    }

    public class ArrayGroupByResponse
    {
        public JToken Result { get; set; }
    }

    public class ArrayFindFirstResponse
    {
        public JToken Result { get; set; }
    }

    public class RoundResponse
    {
        public int Result { get; set; }
    }

    public class MathCeilResponse
    {
        public int Result { get; set; }
    }

    public class MathFloorResponse
    {
        public int Result { get; set; }
    }

    public class MathAverageResponse
    {
        public double Result { get; set; }
    }

    public class MathMedianResponse
    {
        public double Result { get; set; }
    }

    public class MathModeResponse
    {
        public double Result { get; set; }
    }

    public class MathRandomResponse
    {
        public double Result { get; set; }
    }

    public class StringReplaceAllResponse
    {
        public string Result { get; set; }
    }

    public class StringRegexReplaceResponse
    {
        public string Result { get; set; }
    }

    public class StringCapitalizeResponse
    {
        public string Result { get; set; }
    }

    public class StringTrimResponse
    {
        public string Result { get; set; }
    }

    public class StringTrimStartResponse
    {
        public string Result { get; set; }
    }

    public class StringTrimEndResponse
    {
        public string Result { get; set; }
    }

    public class StringSlugifyResponse
    {
        public string Result { get; set; }
    }

    public class StringWordsResponse
    {
        public JToken[] Result { get; set; }
    }

    public class StringWordCountResponse
    {
        public int Result { get; set; }
    }

    public class StringStripHtmlResponse
    {
        public string Result { get; set; }
    }

    public class StringCleanResponse
    {
        public string Result { get; set; }
    }

    public class StringCleanDiacriticsResponse
    {
        public string Result { get; set; }
    }

    public class StringEscapeHtmlResponse
    {
        public string Result { get; set; }
    }

    public class StringUnescapeHtmlResponse
    {
        public string Result { get; set; }
    }

    public class StringCountInstancesResponse
    {
        public int Result { get; set; }
    }

    public class StringChopResponse
    {
        public JToken[] Result { get; set; }
    }

    public class TypesIsStringResponse
    {
        public bool Result { get; set; }
    }

    public class TypesIsNumberResponse
    {
        public bool Result { get; set; }
    }

    public class TypesIsNullOrEmptyResponse
    {
        public bool Result { get; set; }
    }

    public class TypesIsArrayResponse
    {
        public bool Result { get; set; }
    }

    public class TypesIsObjectResponse
    {
        public bool Result { get; set; }
    }

    public class ValidateEmailResponse
    {
        public bool Result { get; set; }
    }

    public class ValidateRegexResponse
    {
        public bool Result { get; set; }
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