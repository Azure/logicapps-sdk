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
        public IBodyWorkflowAction<ArraySortResponse> ArraySort(Expression<Func<JToken[]>> bodyarray)
        {
            var __workflow_bodyarray = WorkflowExpression.Compile(bodyarray, nameof(bodyarray), required: true);
            return new DeferredBodyAction<ArraySortResponse>(() =>
            {
                var apiCallPath = "/array/sort";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["array"] = ExpressionConverter.ConvertO(__workflow_bodyarray);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ArraySortResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<ArrayReverseResponse> ArrayReverse(Expression<Func<JToken[]>> bodyarray)
        {
            var __workflow_bodyarray = WorkflowExpression.Compile(bodyarray, nameof(bodyarray), required: true);
            return new DeferredBodyAction<ArrayReverseResponse>(() =>
            {
                var apiCallPath = "/array/reverse";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["array"] = ExpressionConverter.ConvertO(__workflow_bodyarray);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ArrayReverseResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<ArraySortByPropertyResponse> ArraySortByProperty(Expression<Func<JToken[]>> bodyarray, Expression<Func<string>> bodypropertyName, Expression<Func<bool>> bodydescending)
        {
            var __workflow_bodyarray = WorkflowExpression.Compile(bodyarray, nameof(bodyarray), required: true);
            var __workflow_bodypropertyName = WorkflowExpression.Compile(bodypropertyName, nameof(bodypropertyName), required: true);
            var __workflow_bodydescending = WorkflowExpression.Compile(bodydescending, nameof(bodydescending), required: true);
            return new DeferredBodyAction<ArraySortByPropertyResponse>(() =>
            {
                var apiCallPath = "/array/sortByProperty";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["array"] = ExpressionConverter.ConvertO(__workflow_bodyarray);
                bodypropCount++;
                body["propertyName"] = ExpressionConverter.ConvertO(__workflow_bodypropertyName);
                bodypropCount++;
                body["descending"] = ExpressionConverter.ConvertO(__workflow_bodydescending);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ArraySortByPropertyResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<ArrayFilterResponse> ArrayFilter(Expression<Func<JToken[]>> bodyarray, Expression<Func<string>> bodypropertyName, Expression<Func<bodycomparisonInput>> bodycomparison, Expression<Func<object>> bodyvalue = null, Expression<Func<bodyvalueTypeInput>> bodyvalueType = null)
        {
            var __workflow_bodyarray = WorkflowExpression.Compile(bodyarray, nameof(bodyarray), required: true);
            var __workflow_bodypropertyName = WorkflowExpression.Compile(bodypropertyName, nameof(bodypropertyName), required: true);
            var __workflow_bodycomparison = WorkflowExpression.Compile(bodycomparison, nameof(bodycomparison), required: true);
            var __workflow_bodyvalue = WorkflowExpression.Compile(bodyvalue, nameof(bodyvalue), required: false);
            var __workflow_bodyvalueType = WorkflowExpression.Compile(bodyvalueType, nameof(bodyvalueType), required: false);
            return new DeferredBodyAction<ArrayFilterResponse>(() =>
            {
                var apiCallPath = "/array/filter";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["array"] = ExpressionConverter.ConvertO(__workflow_bodyarray);
                bodypropCount++;
                body["propertyName"] = ExpressionConverter.ConvertO(__workflow_bodypropertyName);
                bodypropCount++;
                body["comparison"] = ExpressionConverter.ConvertO(__workflow_bodycomparison);
                if (__workflow_bodyvalue != null)
                {
                    body["value"] = ExpressionConverter.ConvertO(__workflow_bodyvalue);
                    bodypropCount++;
                }

                if (__workflow_bodyvalueType != null)
                {
                    if (__workflow_bodyvalueType != null)
                    {
                        body["valueType"] = ExpressionConverter.ConvertO(__workflow_bodyvalueType);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["valueType"] = "String";
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ArrayFilterResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<ArrayPrependResponse> ArrayPrepend(Expression<Func<JToken[]>> bodyarray, Expression<Func<object>> bodyvalue, Expression<Func<bodyvalueTypeInput>> bodyvalueType = null)
        {
            var __workflow_bodyarray = WorkflowExpression.Compile(bodyarray, nameof(bodyarray), required: true);
            var __workflow_bodyvalue = WorkflowExpression.Compile(bodyvalue, nameof(bodyvalue), required: true);
            var __workflow_bodyvalueType = WorkflowExpression.Compile(bodyvalueType, nameof(bodyvalueType), required: false);
            return new DeferredBodyAction<ArrayPrependResponse>(() =>
            {
                var apiCallPath = "/array/prepend";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["array"] = ExpressionConverter.ConvertO(__workflow_bodyarray);
                bodypropCount++;
                body["value"] = ExpressionConverter.ConvertO(__workflow_bodyvalue);
                if (__workflow_bodyvalueType != null)
                {
                    if (__workflow_bodyvalueType != null)
                    {
                        body["valueType"] = ExpressionConverter.ConvertO(__workflow_bodyvalueType);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["valueType"] = "String";
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ArrayPrependResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<ArrayAnyResponse> ArrayAny(Expression<Func<JToken[]>> bodyarray, Expression<Func<string>> bodypropertyName, Expression<Func<bodycomparisonInput>> bodycomparison, Expression<Func<object>> bodyvalue = null, Expression<Func<bodyvalueTypeInput>> bodyvalueType = null)
        {
            var __workflow_bodyarray = WorkflowExpression.Compile(bodyarray, nameof(bodyarray), required: true);
            var __workflow_bodypropertyName = WorkflowExpression.Compile(bodypropertyName, nameof(bodypropertyName), required: true);
            var __workflow_bodycomparison = WorkflowExpression.Compile(bodycomparison, nameof(bodycomparison), required: true);
            var __workflow_bodyvalue = WorkflowExpression.Compile(bodyvalue, nameof(bodyvalue), required: false);
            var __workflow_bodyvalueType = WorkflowExpression.Compile(bodyvalueType, nameof(bodyvalueType), required: false);
            return new DeferredBodyAction<ArrayAnyResponse>(() =>
            {
                var apiCallPath = "/array/any";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["array"] = ExpressionConverter.ConvertO(__workflow_bodyarray);
                bodypropCount++;
                body["propertyName"] = ExpressionConverter.ConvertO(__workflow_bodypropertyName);
                bodypropCount++;
                body["comparison"] = ExpressionConverter.ConvertO(__workflow_bodycomparison);
                if (__workflow_bodyvalue != null)
                {
                    body["value"] = ExpressionConverter.ConvertO(__workflow_bodyvalue);
                    bodypropCount++;
                }

                if (__workflow_bodyvalueType != null)
                {
                    if (__workflow_bodyvalueType != null)
                    {
                        body["valueType"] = ExpressionConverter.ConvertO(__workflow_bodyvalueType);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["valueType"] = "String";
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ArrayAnyResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<ArrayEveryResponse> ArrayEvery(Expression<Func<JToken[]>> bodyarray, Expression<Func<string>> bodypropertyName, Expression<Func<bodycomparisonInput>> bodycomparison, Expression<Func<object>> bodyvalue = null, Expression<Func<bodyvalueTypeInput>> bodyvalueType = null)
        {
            var __workflow_bodyarray = WorkflowExpression.Compile(bodyarray, nameof(bodyarray), required: true);
            var __workflow_bodypropertyName = WorkflowExpression.Compile(bodypropertyName, nameof(bodypropertyName), required: true);
            var __workflow_bodycomparison = WorkflowExpression.Compile(bodycomparison, nameof(bodycomparison), required: true);
            var __workflow_bodyvalue = WorkflowExpression.Compile(bodyvalue, nameof(bodyvalue), required: false);
            var __workflow_bodyvalueType = WorkflowExpression.Compile(bodyvalueType, nameof(bodyvalueType), required: false);
            return new DeferredBodyAction<ArrayEveryResponse>(() =>
            {
                var apiCallPath = "/array/every";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["array"] = ExpressionConverter.ConvertO(__workflow_bodyarray);
                bodypropCount++;
                body["propertyName"] = ExpressionConverter.ConvertO(__workflow_bodypropertyName);
                bodypropCount++;
                body["comparison"] = ExpressionConverter.ConvertO(__workflow_bodycomparison);
                if (__workflow_bodyvalue != null)
                {
                    body["value"] = ExpressionConverter.ConvertO(__workflow_bodyvalue);
                    bodypropCount++;
                }

                if (__workflow_bodyvalueType != null)
                {
                    if (__workflow_bodyvalueType != null)
                    {
                        body["valueType"] = ExpressionConverter.ConvertO(__workflow_bodyvalueType);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["valueType"] = "String";
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ArrayEveryResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<ArrayRemoveFirstResponse> ArrayRemoveFirst(Expression<Func<JToken[]>> bodyarray, Expression<Func<string>> bodypropertyName, Expression<Func<bodycomparisonInput>> bodycomparison, Expression<Func<object>> bodyvalue = null, Expression<Func<bodyvalueTypeInput>> bodyvalueType = null)
        {
            var __workflow_bodyarray = WorkflowExpression.Compile(bodyarray, nameof(bodyarray), required: true);
            var __workflow_bodypropertyName = WorkflowExpression.Compile(bodypropertyName, nameof(bodypropertyName), required: true);
            var __workflow_bodycomparison = WorkflowExpression.Compile(bodycomparison, nameof(bodycomparison), required: true);
            var __workflow_bodyvalue = WorkflowExpression.Compile(bodyvalue, nameof(bodyvalue), required: false);
            var __workflow_bodyvalueType = WorkflowExpression.Compile(bodyvalueType, nameof(bodyvalueType), required: false);
            return new DeferredBodyAction<ArrayRemoveFirstResponse>(() =>
            {
                var apiCallPath = "/array/removeFirst";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["array"] = ExpressionConverter.ConvertO(__workflow_bodyarray);
                bodypropCount++;
                body["propertyName"] = ExpressionConverter.ConvertO(__workflow_bodypropertyName);
                bodypropCount++;
                body["comparison"] = ExpressionConverter.ConvertO(__workflow_bodycomparison);
                if (__workflow_bodyvalue != null)
                {
                    body["value"] = ExpressionConverter.ConvertO(__workflow_bodyvalue);
                    bodypropCount++;
                }

                if (__workflow_bodyvalueType != null)
                {
                    if (__workflow_bodyvalueType != null)
                    {
                        body["valueType"] = ExpressionConverter.ConvertO(__workflow_bodyvalueType);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["valueType"] = "String";
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ArrayRemoveFirstResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<ArrayGroupByResponse> ArrayGroupBy(Expression<Func<JToken[]>> bodyarray, Expression<Func<string>> bodypropertyName = null)
        {
            var __workflow_bodyarray = WorkflowExpression.Compile(bodyarray, nameof(bodyarray), required: true);
            var __workflow_bodypropertyName = WorkflowExpression.Compile(bodypropertyName, nameof(bodypropertyName), required: false);
            return new DeferredBodyAction<ArrayGroupByResponse>(() =>
            {
                var apiCallPath = "/array/groupBy";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["array"] = ExpressionConverter.ConvertO(__workflow_bodyarray);
                if (__workflow_bodypropertyName != null)
                {
                    body["propertyName"] = ExpressionConverter.ConvertO(__workflow_bodypropertyName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ArrayGroupByResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<ArrayFindFirstResponse> ArrayFindFirst(Expression<Func<JToken[]>> bodyarray, Expression<Func<string>> bodypropertyName, Expression<Func<bodycomparisonInput>> bodycomparison, Expression<Func<object>> bodyvalue = null, Expression<Func<bodyvalueTypeInput>> bodyvalueType = null)
        {
            var __workflow_bodyarray = WorkflowExpression.Compile(bodyarray, nameof(bodyarray), required: true);
            var __workflow_bodypropertyName = WorkflowExpression.Compile(bodypropertyName, nameof(bodypropertyName), required: true);
            var __workflow_bodycomparison = WorkflowExpression.Compile(bodycomparison, nameof(bodycomparison), required: true);
            var __workflow_bodyvalue = WorkflowExpression.Compile(bodyvalue, nameof(bodyvalue), required: false);
            var __workflow_bodyvalueType = WorkflowExpression.Compile(bodyvalueType, nameof(bodyvalueType), required: false);
            return new DeferredBodyAction<ArrayFindFirstResponse>(() =>
            {
                var apiCallPath = "/array/findFirst";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["array"] = ExpressionConverter.ConvertO(__workflow_bodyarray);
                bodypropCount++;
                body["propertyName"] = ExpressionConverter.ConvertO(__workflow_bodypropertyName);
                bodypropCount++;
                body["comparison"] = ExpressionConverter.ConvertO(__workflow_bodycomparison);
                if (__workflow_bodyvalue != null)
                {
                    body["value"] = ExpressionConverter.ConvertO(__workflow_bodyvalue);
                    bodypropCount++;
                }

                if (__workflow_bodyvalueType != null)
                {
                    if (__workflow_bodyvalueType != null)
                    {
                        body["valueType"] = ExpressionConverter.ConvertO(__workflow_bodyvalueType);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["valueType"] = "String";
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ArrayFindFirstResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<RoundResponse> Round(Expression<Func<double>> bodynumber)
        {
            var __workflow_bodynumber = WorkflowExpression.Compile(bodynumber, nameof(bodynumber), required: true);
            return new DeferredBodyAction<RoundResponse>(() =>
            {
                var apiCallPath = "/math/round";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["number"] = ExpressionConverter.ConvertO(__workflow_bodynumber);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<RoundResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<MathCeilResponse> MathCeil(Expression<Func<double>> bodynumber)
        {
            var __workflow_bodynumber = WorkflowExpression.Compile(bodynumber, nameof(bodynumber), required: true);
            return new DeferredBodyAction<MathCeilResponse>(() =>
            {
                var apiCallPath = "/math/ceil";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["number"] = ExpressionConverter.ConvertO(__workflow_bodynumber);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<MathCeilResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<MathFloorResponse> MathFloor(Expression<Func<double>> bodynumber)
        {
            var __workflow_bodynumber = WorkflowExpression.Compile(bodynumber, nameof(bodynumber), required: true);
            return new DeferredBodyAction<MathFloorResponse>(() =>
            {
                var apiCallPath = "/math/floor";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["number"] = ExpressionConverter.ConvertO(__workflow_bodynumber);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<MathFloorResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<MathAverageResponse> MathAverage(Expression<Func<double[]>> bodynumbers)
        {
            var __workflow_bodynumbers = WorkflowExpression.Compile(bodynumbers, nameof(bodynumbers), required: true);
            return new DeferredBodyAction<MathAverageResponse>(() =>
            {
                var apiCallPath = "/math/average";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["numbers"] = ExpressionConverter.ConvertO(__workflow_bodynumbers);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<MathAverageResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<MathMedianResponse> MathMedian(Expression<Func<JToken[]>> bodynumbers)
        {
            var __workflow_bodynumbers = WorkflowExpression.Compile(bodynumbers, nameof(bodynumbers), required: true);
            return new DeferredBodyAction<MathMedianResponse>(() =>
            {
                var apiCallPath = "/math/median";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["numbers"] = ExpressionConverter.ConvertO(__workflow_bodynumbers);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<MathMedianResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<MathModeResponse> MathMode(Expression<Func<JToken[]>> bodynumbers)
        {
            var __workflow_bodynumbers = WorkflowExpression.Compile(bodynumbers, nameof(bodynumbers), required: true);
            return new DeferredBodyAction<MathModeResponse>(() =>
            {
                var apiCallPath = "/math/mode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["numbers"] = ExpressionConverter.ConvertO(__workflow_bodynumbers);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<MathModeResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<MathRandomResponse> MathRandom(Expression<Func<int>> bodymaximum)
        {
            var __workflow_bodymaximum = WorkflowExpression.Compile(bodymaximum, nameof(bodymaximum), required: true);
            return new DeferredBodyAction<MathRandomResponse>(() =>
            {
                var apiCallPath = "/math/random";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["maximum"] = ExpressionConverter.ConvertO(__workflow_bodymaximum);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<MathRandomResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<StringReplaceAllResponse> StringReplaceAll(Expression<Func<string>> bodysourceString, Expression<Func<string>> bodysearchValue, Expression<Func<string>> bodyreplaceValue)
        {
            var __workflow_bodysourceString = WorkflowExpression.Compile(bodysourceString, nameof(bodysourceString), required: true);
            var __workflow_bodysearchValue = WorkflowExpression.Compile(bodysearchValue, nameof(bodysearchValue), required: true);
            var __workflow_bodyreplaceValue = WorkflowExpression.Compile(bodyreplaceValue, nameof(bodyreplaceValue), required: true);
            return new DeferredBodyAction<StringReplaceAllResponse>(() =>
            {
                var apiCallPath = "/string/replaceAll";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["sourceString"] = ExpressionConverter.ConvertO(__workflow_bodysourceString);
                bodypropCount++;
                body["searchValue"] = ExpressionConverter.ConvertO(__workflow_bodysearchValue);
                bodypropCount++;
                body["replaceValue"] = ExpressionConverter.ConvertO(__workflow_bodyreplaceValue);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<StringReplaceAllResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<StringRegexReplaceResponse> StringRegexReplace(Expression<Func<string>> bodysourceString, Expression<Func<string>> bodypattern, Expression<Func<string>> bodyreplaceValue)
        {
            var __workflow_bodysourceString = WorkflowExpression.Compile(bodysourceString, nameof(bodysourceString), required: true);
            var __workflow_bodypattern = WorkflowExpression.Compile(bodypattern, nameof(bodypattern), required: true);
            var __workflow_bodyreplaceValue = WorkflowExpression.Compile(bodyreplaceValue, nameof(bodyreplaceValue), required: true);
            return new DeferredBodyAction<StringRegexReplaceResponse>(() =>
            {
                var apiCallPath = "/string/regexReplace";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["sourceString"] = ExpressionConverter.ConvertO(__workflow_bodysourceString);
                bodypropCount++;
                body["pattern"] = ExpressionConverter.ConvertO(__workflow_bodypattern);
                bodypropCount++;
                body["replaceValue"] = ExpressionConverter.ConvertO(__workflow_bodyreplaceValue);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<StringRegexReplaceResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<StringCapitalizeResponse> StringCapitalize(Expression<Func<string>> bodystring)
        {
            var __workflow_bodystring = WorkflowExpression.Compile(bodystring, nameof(bodystring), required: true);
            return new DeferredBodyAction<StringCapitalizeResponse>(() =>
            {
                var apiCallPath = "/string/capitalize";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["string"] = ExpressionConverter.ConvertO(__workflow_bodystring);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<StringCapitalizeResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<StringTrimResponse> StringTrim(Expression<Func<string>> bodystring, Expression<Func<string>> bodycharacters = null)
        {
            var __workflow_bodystring = WorkflowExpression.Compile(bodystring, nameof(bodystring), required: true);
            var __workflow_bodycharacters = WorkflowExpression.Compile(bodycharacters, nameof(bodycharacters), required: false);
            return new DeferredBodyAction<StringTrimResponse>(() =>
            {
                var apiCallPath = "/string/trim";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["string"] = ExpressionConverter.ConvertO(__workflow_bodystring);
                if (__workflow_bodycharacters != null)
                {
                    body["characters"] = ExpressionConverter.ConvertO(__workflow_bodycharacters);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<StringTrimResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<StringTrimStartResponse> StringTrimStart(Expression<Func<string>> bodystring, Expression<Func<string>> bodycharacters = null)
        {
            var __workflow_bodystring = WorkflowExpression.Compile(bodystring, nameof(bodystring), required: true);
            var __workflow_bodycharacters = WorkflowExpression.Compile(bodycharacters, nameof(bodycharacters), required: false);
            return new DeferredBodyAction<StringTrimStartResponse>(() =>
            {
                var apiCallPath = "/string/trimStart";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["string"] = ExpressionConverter.ConvertO(__workflow_bodystring);
                if (__workflow_bodycharacters != null)
                {
                    body["characters"] = ExpressionConverter.ConvertO(__workflow_bodycharacters);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<StringTrimStartResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<StringTrimEndResponse> StringTrimEnd(Expression<Func<string>> bodystring, Expression<Func<string>> bodycharacters = null)
        {
            var __workflow_bodystring = WorkflowExpression.Compile(bodystring, nameof(bodystring), required: true);
            var __workflow_bodycharacters = WorkflowExpression.Compile(bodycharacters, nameof(bodycharacters), required: false);
            return new DeferredBodyAction<StringTrimEndResponse>(() =>
            {
                var apiCallPath = "/string/trimEnd";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["string"] = ExpressionConverter.ConvertO(__workflow_bodystring);
                if (__workflow_bodycharacters != null)
                {
                    body["characters"] = ExpressionConverter.ConvertO(__workflow_bodycharacters);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<StringTrimEndResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<StringSlugifyResponse> StringSlugify(Expression<Func<string>> bodystring)
        {
            var __workflow_bodystring = WorkflowExpression.Compile(bodystring, nameof(bodystring), required: true);
            return new DeferredBodyAction<StringSlugifyResponse>(() =>
            {
                var apiCallPath = "/string/slugify";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["string"] = ExpressionConverter.ConvertO(__workflow_bodystring);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<StringSlugifyResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<StringWordsResponse> StringWords(Expression<Func<string>> bodystring, Expression<Func<string>> bodydelimiter = null)
        {
            var __workflow_bodystring = WorkflowExpression.Compile(bodystring, nameof(bodystring), required: true);
            var __workflow_bodydelimiter = WorkflowExpression.Compile(bodydelimiter, nameof(bodydelimiter), required: false);
            return new DeferredBodyAction<StringWordsResponse>(() =>
            {
                var apiCallPath = "/string/words";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["string"] = ExpressionConverter.ConvertO(__workflow_bodystring);
                if (__workflow_bodydelimiter != null)
                {
                    body["delimiter"] = ExpressionConverter.ConvertO(__workflow_bodydelimiter);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<StringWordsResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<StringWordCountResponse> StringWordCount(Expression<Func<string>> bodystring, Expression<Func<string>> bodydelimiter = null)
        {
            var __workflow_bodystring = WorkflowExpression.Compile(bodystring, nameof(bodystring), required: true);
            var __workflow_bodydelimiter = WorkflowExpression.Compile(bodydelimiter, nameof(bodydelimiter), required: false);
            return new DeferredBodyAction<StringWordCountResponse>(() =>
            {
                var apiCallPath = "/string/wordCount";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["string"] = ExpressionConverter.ConvertO(__workflow_bodystring);
                if (__workflow_bodydelimiter != null)
                {
                    body["delimiter"] = ExpressionConverter.ConvertO(__workflow_bodydelimiter);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<StringWordCountResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<StringStripHtmlResponse> StringStripHtml(Expression<Func<string>> bodystring)
        {
            var __workflow_bodystring = WorkflowExpression.Compile(bodystring, nameof(bodystring), required: true);
            return new DeferredBodyAction<StringStripHtmlResponse>(() =>
            {
                var apiCallPath = "/string/stripHtml";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["string"] = ExpressionConverter.ConvertO(__workflow_bodystring);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<StringStripHtmlResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<StringCleanResponse> StringClean(Expression<Func<string>> bodystring)
        {
            var __workflow_bodystring = WorkflowExpression.Compile(bodystring, nameof(bodystring), required: true);
            return new DeferredBodyAction<StringCleanResponse>(() =>
            {
                var apiCallPath = "/string/clean";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["string"] = ExpressionConverter.ConvertO(__workflow_bodystring);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<StringCleanResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<StringCleanDiacriticsResponse> StringCleanDiacritics(Expression<Func<string>> bodystring)
        {
            var __workflow_bodystring = WorkflowExpression.Compile(bodystring, nameof(bodystring), required: true);
            return new DeferredBodyAction<StringCleanDiacriticsResponse>(() =>
            {
                var apiCallPath = "/string/cleanDiacritics";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["string"] = ExpressionConverter.ConvertO(__workflow_bodystring);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<StringCleanDiacriticsResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<StringEscapeHtmlResponse> StringEscapeHtml(Expression<Func<string>> bodystring)
        {
            var __workflow_bodystring = WorkflowExpression.Compile(bodystring, nameof(bodystring), required: true);
            return new DeferredBodyAction<StringEscapeHtmlResponse>(() =>
            {
                var apiCallPath = "/string/escapeHtml";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["string"] = ExpressionConverter.ConvertO(__workflow_bodystring);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<StringEscapeHtmlResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<StringUnescapeHtmlResponse> StringUnescapeHtml(Expression<Func<string>> bodystring)
        {
            var __workflow_bodystring = WorkflowExpression.Compile(bodystring, nameof(bodystring), required: true);
            return new DeferredBodyAction<StringUnescapeHtmlResponse>(() =>
            {
                var apiCallPath = "/string/unescapeHtml";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["string"] = ExpressionConverter.ConvertO(__workflow_bodystring);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<StringUnescapeHtmlResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<StringCountInstancesResponse> StringCountInstances(Expression<Func<string>> bodystring, Expression<Func<string>> bodysubstring, Expression<Func<bool>> bodyignoreCase = null)
        {
            var __workflow_bodystring = WorkflowExpression.Compile(bodystring, nameof(bodystring), required: true);
            var __workflow_bodysubstring = WorkflowExpression.Compile(bodysubstring, nameof(bodysubstring), required: true);
            var __workflow_bodyignoreCase = WorkflowExpression.Compile(bodyignoreCase, nameof(bodyignoreCase), required: false);
            return new DeferredBodyAction<StringCountInstancesResponse>(() =>
            {
                var apiCallPath = "/string/countInstances";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["string"] = ExpressionConverter.ConvertO(__workflow_bodystring);
                bodypropCount++;
                body["substring"] = ExpressionConverter.ConvertO(__workflow_bodysubstring);
                if (__workflow_bodyignoreCase != null)
                {
                    if (__workflow_bodyignoreCase != null)
                    {
                        body["ignoreCase"] = ExpressionConverter.ConvertO(__workflow_bodyignoreCase);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["ignoreCase"] = false;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<StringCountInstancesResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<StringChopResponse> StringChop(Expression<Func<string>> bodystring, Expression<Func<int>> bodyinterval)
        {
            var __workflow_bodystring = WorkflowExpression.Compile(bodystring, nameof(bodystring), required: true);
            var __workflow_bodyinterval = WorkflowExpression.Compile(bodyinterval, nameof(bodyinterval), required: true);
            return new DeferredBodyAction<StringChopResponse>(() =>
            {
                var apiCallPath = "/string/chop";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["string"] = ExpressionConverter.ConvertO(__workflow_bodystring);
                bodypropCount++;
                body["interval"] = ExpressionConverter.ConvertO(__workflow_bodyinterval);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<StringChopResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<TypesIsStringResponse> TypesIsString(Expression<Func<object>> bodyvalue)
        {
            var __workflow_bodyvalue = WorkflowExpression.Compile(bodyvalue, nameof(bodyvalue), required: true);
            return new DeferredBodyAction<TypesIsStringResponse>(() =>
            {
                var apiCallPath = "/types/isString";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["value"] = ExpressionConverter.ConvertO(__workflow_bodyvalue);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<TypesIsStringResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<TypesIsNumberResponse> TypesIsNumber(Expression<Func<object>> bodyvalue, Expression<Func<bool>> bodyincludeNumbersInStrings)
        {
            var __workflow_bodyvalue = WorkflowExpression.Compile(bodyvalue, nameof(bodyvalue), required: true);
            var __workflow_bodyincludeNumbersInStrings = WorkflowExpression.Compile(bodyincludeNumbersInStrings, nameof(bodyincludeNumbersInStrings), required: true);
            return new DeferredBodyAction<TypesIsNumberResponse>(() =>
            {
                var apiCallPath = "/types/isNumber";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["value"] = ExpressionConverter.ConvertO(__workflow_bodyvalue);
                bodypropCount++;
                body["includeNumbersInStrings"] = ExpressionConverter.ConvertO(__workflow_bodyincludeNumbersInStrings);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<TypesIsNumberResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<TypesIsNullOrEmptyResponse> TypesIsNullOrEmpty(Expression<Func<object>> bodyvalue)
        {
            var __workflow_bodyvalue = WorkflowExpression.Compile(bodyvalue, nameof(bodyvalue), required: true);
            return new DeferredBodyAction<TypesIsNullOrEmptyResponse>(() =>
            {
                var apiCallPath = "/types/isNullOrEmpty";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["value"] = ExpressionConverter.ConvertO(__workflow_bodyvalue);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<TypesIsNullOrEmptyResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<TypesIsArrayResponse> TypesIsArray(Expression<Func<object>> bodyvalue)
        {
            var __workflow_bodyvalue = WorkflowExpression.Compile(bodyvalue, nameof(bodyvalue), required: true);
            return new DeferredBodyAction<TypesIsArrayResponse>(() =>
            {
                var apiCallPath = "/types/isArray";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["value"] = ExpressionConverter.ConvertO(__workflow_bodyvalue);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<TypesIsArrayResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<TypesIsObjectResponse> TypesIsObject(Expression<Func<object>> bodyvalue)
        {
            var __workflow_bodyvalue = WorkflowExpression.Compile(bodyvalue, nameof(bodyvalue), required: true);
            return new DeferredBodyAction<TypesIsObjectResponse>(() =>
            {
                var apiCallPath = "/types/isObject";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["value"] = ExpressionConverter.ConvertO(__workflow_bodyvalue);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<TypesIsObjectResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<ValidateEmailResponse> ValidateEmail(Expression<Func<string>> bodyemail)
        {
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: true);
            return new DeferredBodyAction<ValidateEmailResponse>(() =>
            {
                var apiCallPath = "/validate/email";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ValidateEmailResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<ValidateRegexResponse> ValidateRegex(Expression<Func<string>> bodystring, Expression<Func<string>> bodypattern)
        {
            var __workflow_bodystring = WorkflowExpression.Compile(bodystring, nameof(bodystring), required: true);
            var __workflow_bodypattern = WorkflowExpression.Compile(bodypattern, nameof(bodypattern), required: true);
            return new DeferredBodyAction<ValidateRegexResponse>(() =>
            {
                var apiCallPath = "/validate/regex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["string"] = ExpressionConverter.ConvertO(__workflow_bodystring);
                bodypropCount++;
                body["pattern"] = ExpressionConverter.ConvertO(__workflow_bodypattern);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ValidateRegexResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
