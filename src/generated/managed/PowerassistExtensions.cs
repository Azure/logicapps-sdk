//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Powerassist
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PowerassistActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        [WorkflowExpressionFactory(nameof(__BuildArraySort))]
        public IBodyWorkflowAction<ArraySortResponse> ArraySort([WorkflowExpression] Func<JToken[]> bodyarray)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ArraySortResponse> __BuildArraySort(WorkflowExpression<JToken[]> bodyarray)
        {
            WorkflowExpression.Validate(bodyarray, nameof(bodyarray), required: true);
            return new DeferredBodyAction<ArraySortResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        [WorkflowExpressionFactory(nameof(__BuildArrayReverse))]
        public IBodyWorkflowAction<ArrayReverseResponse> ArrayReverse([WorkflowExpression] Func<JToken[]> bodyarray)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ArrayReverseResponse> __BuildArrayReverse(WorkflowExpression<JToken[]> bodyarray)
        {
            WorkflowExpression.Validate(bodyarray, nameof(bodyarray), required: true);
            return new DeferredBodyAction<ArrayReverseResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        [WorkflowExpressionFactory(nameof(__BuildArraySortByProperty))]
        public IBodyWorkflowAction<ArraySortByPropertyResponse> ArraySortByProperty([WorkflowExpression] Func<JToken[]> bodyarray, [WorkflowExpression] Func<string> bodypropertyName, [WorkflowExpression] Func<bool> bodydescending)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ArraySortByPropertyResponse> __BuildArraySortByProperty(WorkflowExpression<JToken[]> bodyarray, WorkflowExpression<string> bodypropertyName, WorkflowExpression<bool> bodydescending)
        {
            WorkflowExpression.Validate(bodyarray, nameof(bodyarray), required: true);
            WorkflowExpression.Validate(bodypropertyName, nameof(bodypropertyName), required: true);
            WorkflowExpression.Validate(bodydescending, nameof(bodydescending), required: true);
            return new DeferredBodyAction<ArraySortByPropertyResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        [WorkflowExpressionFactory(nameof(__BuildArrayFilter))]
        public IBodyWorkflowAction<ArrayFilterResponse> ArrayFilter([WorkflowExpression] Func<JToken[]> bodyarray, [WorkflowExpression] Func<string> bodypropertyName, [WorkflowExpression] Func<bodycomparisonInput> bodycomparison, [WorkflowExpression] Func<object> bodyvalue = null, [WorkflowExpression] Func<bodyvalueTypeInput> bodyvalueType = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ArrayFilterResponse> __BuildArrayFilter(WorkflowExpression<JToken[]> bodyarray, WorkflowExpression<string> bodypropertyName, WorkflowExpression<bodycomparisonInput> bodycomparison, WorkflowExpression<object> bodyvalue = null, WorkflowExpression<bodyvalueTypeInput> bodyvalueType = null)
        {
            WorkflowExpression.Validate(bodyarray, nameof(bodyarray), required: true);
            WorkflowExpression.Validate(bodypropertyName, nameof(bodypropertyName), required: true);
            WorkflowExpression.Validate(bodycomparison, nameof(bodycomparison), required: true);
            WorkflowExpression.Validate(bodyvalue, nameof(bodyvalue), required: false);
            WorkflowExpression.Validate(bodyvalueType, nameof(bodyvalueType), required: false);
            return new DeferredBodyAction<ArrayFilterResponse>(() =>
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
                    if (bodyvalueType != null)
                    {
                        body["valueType"] = ExpressionConverter.ConvertO(bodyvalueType);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        [WorkflowExpressionFactory(nameof(__BuildArrayPrepend))]
        public IBodyWorkflowAction<ArrayPrependResponse> ArrayPrepend([WorkflowExpression] Func<JToken[]> bodyarray, [WorkflowExpression] Func<object> bodyvalue, [WorkflowExpression] Func<bodyvalueTypeInput> bodyvalueType = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ArrayPrependResponse> __BuildArrayPrepend(WorkflowExpression<JToken[]> bodyarray, WorkflowExpression<object> bodyvalue, WorkflowExpression<bodyvalueTypeInput> bodyvalueType = null)
        {
            WorkflowExpression.Validate(bodyarray, nameof(bodyarray), required: true);
            WorkflowExpression.Validate(bodyvalue, nameof(bodyvalue), required: true);
            WorkflowExpression.Validate(bodyvalueType, nameof(bodyvalueType), required: false);
            return new DeferredBodyAction<ArrayPrependResponse>(() =>
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
                    if (bodyvalueType != null)
                    {
                        body["valueType"] = ExpressionConverter.ConvertO(bodyvalueType);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        [WorkflowExpressionFactory(nameof(__BuildArrayAny))]
        public IBodyWorkflowAction<ArrayAnyResponse> ArrayAny([WorkflowExpression] Func<JToken[]> bodyarray, [WorkflowExpression] Func<string> bodypropertyName, [WorkflowExpression] Func<bodycomparisonInput> bodycomparison, [WorkflowExpression] Func<object> bodyvalue = null, [WorkflowExpression] Func<bodyvalueTypeInput> bodyvalueType = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ArrayAnyResponse> __BuildArrayAny(WorkflowExpression<JToken[]> bodyarray, WorkflowExpression<string> bodypropertyName, WorkflowExpression<bodycomparisonInput> bodycomparison, WorkflowExpression<object> bodyvalue = null, WorkflowExpression<bodyvalueTypeInput> bodyvalueType = null)
        {
            WorkflowExpression.Validate(bodyarray, nameof(bodyarray), required: true);
            WorkflowExpression.Validate(bodypropertyName, nameof(bodypropertyName), required: true);
            WorkflowExpression.Validate(bodycomparison, nameof(bodycomparison), required: true);
            WorkflowExpression.Validate(bodyvalue, nameof(bodyvalue), required: false);
            WorkflowExpression.Validate(bodyvalueType, nameof(bodyvalueType), required: false);
            return new DeferredBodyAction<ArrayAnyResponse>(() =>
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
                    if (bodyvalueType != null)
                    {
                        body["valueType"] = ExpressionConverter.ConvertO(bodyvalueType);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        [WorkflowExpressionFactory(nameof(__BuildArrayEvery))]
        public IBodyWorkflowAction<ArrayEveryResponse> ArrayEvery([WorkflowExpression] Func<JToken[]> bodyarray, [WorkflowExpression] Func<string> bodypropertyName, [WorkflowExpression] Func<bodycomparisonInput> bodycomparison, [WorkflowExpression] Func<object> bodyvalue = null, [WorkflowExpression] Func<bodyvalueTypeInput> bodyvalueType = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ArrayEveryResponse> __BuildArrayEvery(WorkflowExpression<JToken[]> bodyarray, WorkflowExpression<string> bodypropertyName, WorkflowExpression<bodycomparisonInput> bodycomparison, WorkflowExpression<object> bodyvalue = null, WorkflowExpression<bodyvalueTypeInput> bodyvalueType = null)
        {
            WorkflowExpression.Validate(bodyarray, nameof(bodyarray), required: true);
            WorkflowExpression.Validate(bodypropertyName, nameof(bodypropertyName), required: true);
            WorkflowExpression.Validate(bodycomparison, nameof(bodycomparison), required: true);
            WorkflowExpression.Validate(bodyvalue, nameof(bodyvalue), required: false);
            WorkflowExpression.Validate(bodyvalueType, nameof(bodyvalueType), required: false);
            return new DeferredBodyAction<ArrayEveryResponse>(() =>
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
                    if (bodyvalueType != null)
                    {
                        body["valueType"] = ExpressionConverter.ConvertO(bodyvalueType);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        [WorkflowExpressionFactory(nameof(__BuildArrayRemoveFirst))]
        public IBodyWorkflowAction<ArrayRemoveFirstResponse> ArrayRemoveFirst([WorkflowExpression] Func<JToken[]> bodyarray, [WorkflowExpression] Func<string> bodypropertyName, [WorkflowExpression] Func<bodycomparisonInput> bodycomparison, [WorkflowExpression] Func<object> bodyvalue = null, [WorkflowExpression] Func<bodyvalueTypeInput> bodyvalueType = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ArrayRemoveFirstResponse> __BuildArrayRemoveFirst(WorkflowExpression<JToken[]> bodyarray, WorkflowExpression<string> bodypropertyName, WorkflowExpression<bodycomparisonInput> bodycomparison, WorkflowExpression<object> bodyvalue = null, WorkflowExpression<bodyvalueTypeInput> bodyvalueType = null)
        {
            WorkflowExpression.Validate(bodyarray, nameof(bodyarray), required: true);
            WorkflowExpression.Validate(bodypropertyName, nameof(bodypropertyName), required: true);
            WorkflowExpression.Validate(bodycomparison, nameof(bodycomparison), required: true);
            WorkflowExpression.Validate(bodyvalue, nameof(bodyvalue), required: false);
            WorkflowExpression.Validate(bodyvalueType, nameof(bodyvalueType), required: false);
            return new DeferredBodyAction<ArrayRemoveFirstResponse>(() =>
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
                    if (bodyvalueType != null)
                    {
                        body["valueType"] = ExpressionConverter.ConvertO(bodyvalueType);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        [WorkflowExpressionFactory(nameof(__BuildArrayGroupBy))]
        public IBodyWorkflowAction<ArrayGroupByResponse> ArrayGroupBy([WorkflowExpression] Func<JToken[]> bodyarray, [WorkflowExpression] Func<string> bodypropertyName = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ArrayGroupByResponse> __BuildArrayGroupBy(WorkflowExpression<JToken[]> bodyarray, WorkflowExpression<string> bodypropertyName = null)
        {
            WorkflowExpression.Validate(bodyarray, nameof(bodyarray), required: true);
            WorkflowExpression.Validate(bodypropertyName, nameof(bodypropertyName), required: false);
            return new DeferredBodyAction<ArrayGroupByResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        [WorkflowExpressionFactory(nameof(__BuildArrayFindFirst))]
        public IBodyWorkflowAction<ArrayFindFirstResponse> ArrayFindFirst([WorkflowExpression] Func<JToken[]> bodyarray, [WorkflowExpression] Func<string> bodypropertyName, [WorkflowExpression] Func<bodycomparisonInput> bodycomparison, [WorkflowExpression] Func<object> bodyvalue = null, [WorkflowExpression] Func<bodyvalueTypeInput> bodyvalueType = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ArrayFindFirstResponse> __BuildArrayFindFirst(WorkflowExpression<JToken[]> bodyarray, WorkflowExpression<string> bodypropertyName, WorkflowExpression<bodycomparisonInput> bodycomparison, WorkflowExpression<object> bodyvalue = null, WorkflowExpression<bodyvalueTypeInput> bodyvalueType = null)
        {
            WorkflowExpression.Validate(bodyarray, nameof(bodyarray), required: true);
            WorkflowExpression.Validate(bodypropertyName, nameof(bodypropertyName), required: true);
            WorkflowExpression.Validate(bodycomparison, nameof(bodycomparison), required: true);
            WorkflowExpression.Validate(bodyvalue, nameof(bodyvalue), required: false);
            WorkflowExpression.Validate(bodyvalueType, nameof(bodyvalueType), required: false);
            return new DeferredBodyAction<ArrayFindFirstResponse>(() =>
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
                    if (bodyvalueType != null)
                    {
                        body["valueType"] = ExpressionConverter.ConvertO(bodyvalueType);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        [WorkflowExpressionFactory(nameof(__BuildRound))]
        public IBodyWorkflowAction<RoundResponse> Round([WorkflowExpression] Func<double> bodynumber)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RoundResponse> __BuildRound(WorkflowExpression<double> bodynumber)
        {
            WorkflowExpression.Validate(bodynumber, nameof(bodynumber), required: true);
            return new DeferredBodyAction<RoundResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        [WorkflowExpressionFactory(nameof(__BuildMathCeil))]
        public IBodyWorkflowAction<MathCeilResponse> MathCeil([WorkflowExpression] Func<double> bodynumber)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MathCeilResponse> __BuildMathCeil(WorkflowExpression<double> bodynumber)
        {
            WorkflowExpression.Validate(bodynumber, nameof(bodynumber), required: true);
            return new DeferredBodyAction<MathCeilResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        [WorkflowExpressionFactory(nameof(__BuildMathFloor))]
        public IBodyWorkflowAction<MathFloorResponse> MathFloor([WorkflowExpression] Func<double> bodynumber)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MathFloorResponse> __BuildMathFloor(WorkflowExpression<double> bodynumber)
        {
            WorkflowExpression.Validate(bodynumber, nameof(bodynumber), required: true);
            return new DeferredBodyAction<MathFloorResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        [WorkflowExpressionFactory(nameof(__BuildMathAverage))]
        public IBodyWorkflowAction<MathAverageResponse> MathAverage([WorkflowExpression] Func<double[]> bodynumbers)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MathAverageResponse> __BuildMathAverage(WorkflowExpression<double[]> bodynumbers)
        {
            WorkflowExpression.Validate(bodynumbers, nameof(bodynumbers), required: true);
            return new DeferredBodyAction<MathAverageResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        [WorkflowExpressionFactory(nameof(__BuildMathMedian))]
        public IBodyWorkflowAction<MathMedianResponse> MathMedian([WorkflowExpression] Func<JToken[]> bodynumbers)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MathMedianResponse> __BuildMathMedian(WorkflowExpression<JToken[]> bodynumbers)
        {
            WorkflowExpression.Validate(bodynumbers, nameof(bodynumbers), required: true);
            return new DeferredBodyAction<MathMedianResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        [WorkflowExpressionFactory(nameof(__BuildMathMode))]
        public IBodyWorkflowAction<MathModeResponse> MathMode([WorkflowExpression] Func<JToken[]> bodynumbers)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MathModeResponse> __BuildMathMode(WorkflowExpression<JToken[]> bodynumbers)
        {
            WorkflowExpression.Validate(bodynumbers, nameof(bodynumbers), required: true);
            return new DeferredBodyAction<MathModeResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        [WorkflowExpressionFactory(nameof(__BuildMathRandom))]
        public IBodyWorkflowAction<MathRandomResponse> MathRandom([WorkflowExpression] Func<int> bodymaximum)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MathRandomResponse> __BuildMathRandom(WorkflowExpression<int> bodymaximum)
        {
            WorkflowExpression.Validate(bodymaximum, nameof(bodymaximum), required: true);
            return new DeferredBodyAction<MathRandomResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        [WorkflowExpressionFactory(nameof(__BuildStringReplaceAll))]
        public IBodyWorkflowAction<StringReplaceAllResponse> StringReplaceAll([WorkflowExpression] Func<string> bodysourceString, [WorkflowExpression] Func<string> bodysearchValue, [WorkflowExpression] Func<string> bodyreplaceValue)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<StringReplaceAllResponse> __BuildStringReplaceAll(WorkflowExpression<string> bodysourceString, WorkflowExpression<string> bodysearchValue, WorkflowExpression<string> bodyreplaceValue)
        {
            WorkflowExpression.Validate(bodysourceString, nameof(bodysourceString), required: true);
            WorkflowExpression.Validate(bodysearchValue, nameof(bodysearchValue), required: true);
            WorkflowExpression.Validate(bodyreplaceValue, nameof(bodyreplaceValue), required: true);
            return new DeferredBodyAction<StringReplaceAllResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        [WorkflowExpressionFactory(nameof(__BuildStringRegexReplace))]
        public IBodyWorkflowAction<StringRegexReplaceResponse> StringRegexReplace([WorkflowExpression] Func<string> bodysourceString, [WorkflowExpression] Func<string> bodypattern, [WorkflowExpression] Func<string> bodyreplaceValue)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<StringRegexReplaceResponse> __BuildStringRegexReplace(WorkflowExpression<string> bodysourceString, WorkflowExpression<string> bodypattern, WorkflowExpression<string> bodyreplaceValue)
        {
            WorkflowExpression.Validate(bodysourceString, nameof(bodysourceString), required: true);
            WorkflowExpression.Validate(bodypattern, nameof(bodypattern), required: true);
            WorkflowExpression.Validate(bodyreplaceValue, nameof(bodyreplaceValue), required: true);
            return new DeferredBodyAction<StringRegexReplaceResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        [WorkflowExpressionFactory(nameof(__BuildStringCapitalize))]
        public IBodyWorkflowAction<StringCapitalizeResponse> StringCapitalize([WorkflowExpression] Func<string> bodystring)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<StringCapitalizeResponse> __BuildStringCapitalize(WorkflowExpression<string> bodystring)
        {
            WorkflowExpression.Validate(bodystring, nameof(bodystring), required: true);
            return new DeferredBodyAction<StringCapitalizeResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        [WorkflowExpressionFactory(nameof(__BuildStringTrim))]
        public IBodyWorkflowAction<StringTrimResponse> StringTrim([WorkflowExpression] Func<string> bodystring, [WorkflowExpression] Func<string> bodycharacters = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<StringTrimResponse> __BuildStringTrim(WorkflowExpression<string> bodystring, WorkflowExpression<string> bodycharacters = null)
        {
            WorkflowExpression.Validate(bodystring, nameof(bodystring), required: true);
            WorkflowExpression.Validate(bodycharacters, nameof(bodycharacters), required: false);
            return new DeferredBodyAction<StringTrimResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        [WorkflowExpressionFactory(nameof(__BuildStringTrimStart))]
        public IBodyWorkflowAction<StringTrimStartResponse> StringTrimStart([WorkflowExpression] Func<string> bodystring, [WorkflowExpression] Func<string> bodycharacters = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<StringTrimStartResponse> __BuildStringTrimStart(WorkflowExpression<string> bodystring, WorkflowExpression<string> bodycharacters = null)
        {
            WorkflowExpression.Validate(bodystring, nameof(bodystring), required: true);
            WorkflowExpression.Validate(bodycharacters, nameof(bodycharacters), required: false);
            return new DeferredBodyAction<StringTrimStartResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        [WorkflowExpressionFactory(nameof(__BuildStringTrimEnd))]
        public IBodyWorkflowAction<StringTrimEndResponse> StringTrimEnd([WorkflowExpression] Func<string> bodystring, [WorkflowExpression] Func<string> bodycharacters = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<StringTrimEndResponse> __BuildStringTrimEnd(WorkflowExpression<string> bodystring, WorkflowExpression<string> bodycharacters = null)
        {
            WorkflowExpression.Validate(bodystring, nameof(bodystring), required: true);
            WorkflowExpression.Validate(bodycharacters, nameof(bodycharacters), required: false);
            return new DeferredBodyAction<StringTrimEndResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        [WorkflowExpressionFactory(nameof(__BuildStringSlugify))]
        public IBodyWorkflowAction<StringSlugifyResponse> StringSlugify([WorkflowExpression] Func<string> bodystring)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<StringSlugifyResponse> __BuildStringSlugify(WorkflowExpression<string> bodystring)
        {
            WorkflowExpression.Validate(bodystring, nameof(bodystring), required: true);
            return new DeferredBodyAction<StringSlugifyResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        [WorkflowExpressionFactory(nameof(__BuildStringWords))]
        public IBodyWorkflowAction<StringWordsResponse> StringWords([WorkflowExpression] Func<string> bodystring, [WorkflowExpression] Func<string> bodydelimiter = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<StringWordsResponse> __BuildStringWords(WorkflowExpression<string> bodystring, WorkflowExpression<string> bodydelimiter = null)
        {
            WorkflowExpression.Validate(bodystring, nameof(bodystring), required: true);
            WorkflowExpression.Validate(bodydelimiter, nameof(bodydelimiter), required: false);
            return new DeferredBodyAction<StringWordsResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        [WorkflowExpressionFactory(nameof(__BuildStringWordCount))]
        public IBodyWorkflowAction<StringWordCountResponse> StringWordCount([WorkflowExpression] Func<string> bodystring, [WorkflowExpression] Func<string> bodydelimiter = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<StringWordCountResponse> __BuildStringWordCount(WorkflowExpression<string> bodystring, WorkflowExpression<string> bodydelimiter = null)
        {
            WorkflowExpression.Validate(bodystring, nameof(bodystring), required: true);
            WorkflowExpression.Validate(bodydelimiter, nameof(bodydelimiter), required: false);
            return new DeferredBodyAction<StringWordCountResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        [WorkflowExpressionFactory(nameof(__BuildStringStripHtml))]
        public IBodyWorkflowAction<StringStripHtmlResponse> StringStripHtml([WorkflowExpression] Func<string> bodystring)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<StringStripHtmlResponse> __BuildStringStripHtml(WorkflowExpression<string> bodystring)
        {
            WorkflowExpression.Validate(bodystring, nameof(bodystring), required: true);
            return new DeferredBodyAction<StringStripHtmlResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        [WorkflowExpressionFactory(nameof(__BuildStringClean))]
        public IBodyWorkflowAction<StringCleanResponse> StringClean([WorkflowExpression] Func<string> bodystring)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<StringCleanResponse> __BuildStringClean(WorkflowExpression<string> bodystring)
        {
            WorkflowExpression.Validate(bodystring, nameof(bodystring), required: true);
            return new DeferredBodyAction<StringCleanResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        [WorkflowExpressionFactory(nameof(__BuildStringCleanDiacritics))]
        public IBodyWorkflowAction<StringCleanDiacriticsResponse> StringCleanDiacritics([WorkflowExpression] Func<string> bodystring)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<StringCleanDiacriticsResponse> __BuildStringCleanDiacritics(WorkflowExpression<string> bodystring)
        {
            WorkflowExpression.Validate(bodystring, nameof(bodystring), required: true);
            return new DeferredBodyAction<StringCleanDiacriticsResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        [WorkflowExpressionFactory(nameof(__BuildStringEscapeHtml))]
        public IBodyWorkflowAction<StringEscapeHtmlResponse> StringEscapeHtml([WorkflowExpression] Func<string> bodystring)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<StringEscapeHtmlResponse> __BuildStringEscapeHtml(WorkflowExpression<string> bodystring)
        {
            WorkflowExpression.Validate(bodystring, nameof(bodystring), required: true);
            return new DeferredBodyAction<StringEscapeHtmlResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        [WorkflowExpressionFactory(nameof(__BuildStringUnescapeHtml))]
        public IBodyWorkflowAction<StringUnescapeHtmlResponse> StringUnescapeHtml([WorkflowExpression] Func<string> bodystring)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<StringUnescapeHtmlResponse> __BuildStringUnescapeHtml(WorkflowExpression<string> bodystring)
        {
            WorkflowExpression.Validate(bodystring, nameof(bodystring), required: true);
            return new DeferredBodyAction<StringUnescapeHtmlResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        [WorkflowExpressionFactory(nameof(__BuildStringCountInstances))]
        public IBodyWorkflowAction<StringCountInstancesResponse> StringCountInstances([WorkflowExpression] Func<string> bodystring, [WorkflowExpression] Func<string> bodysubstring, [WorkflowExpression] Func<bool> bodyignoreCase = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<StringCountInstancesResponse> __BuildStringCountInstances(WorkflowExpression<string> bodystring, WorkflowExpression<string> bodysubstring, WorkflowExpression<bool> bodyignoreCase = null)
        {
            WorkflowExpression.Validate(bodystring, nameof(bodystring), required: true);
            WorkflowExpression.Validate(bodysubstring, nameof(bodysubstring), required: true);
            WorkflowExpression.Validate(bodyignoreCase, nameof(bodyignoreCase), required: false);
            return new DeferredBodyAction<StringCountInstancesResponse>(() =>
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
                    if (bodyignoreCase != null)
                    {
                        body["ignoreCase"] = ExpressionConverter.ConvertO(bodyignoreCase);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        [WorkflowExpressionFactory(nameof(__BuildStringChop))]
        public IBodyWorkflowAction<StringChopResponse> StringChop([WorkflowExpression] Func<string> bodystring, [WorkflowExpression] Func<int> bodyinterval)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<StringChopResponse> __BuildStringChop(WorkflowExpression<string> bodystring, WorkflowExpression<int> bodyinterval)
        {
            WorkflowExpression.Validate(bodystring, nameof(bodystring), required: true);
            WorkflowExpression.Validate(bodyinterval, nameof(bodyinterval), required: true);
            return new DeferredBodyAction<StringChopResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        [WorkflowExpressionFactory(nameof(__BuildTypesIsString))]
        public IBodyWorkflowAction<TypesIsStringResponse> TypesIsString([WorkflowExpression] Func<object> bodyvalue)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TypesIsStringResponse> __BuildTypesIsString(WorkflowExpression<object> bodyvalue)
        {
            WorkflowExpression.Validate(bodyvalue, nameof(bodyvalue), required: true);
            return new DeferredBodyAction<TypesIsStringResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        [WorkflowExpressionFactory(nameof(__BuildTypesIsNumber))]
        public IBodyWorkflowAction<TypesIsNumberResponse> TypesIsNumber([WorkflowExpression] Func<object> bodyvalue, [WorkflowExpression] Func<bool> bodyincludeNumbersInStrings)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TypesIsNumberResponse> __BuildTypesIsNumber(WorkflowExpression<object> bodyvalue, WorkflowExpression<bool> bodyincludeNumbersInStrings)
        {
            WorkflowExpression.Validate(bodyvalue, nameof(bodyvalue), required: true);
            WorkflowExpression.Validate(bodyincludeNumbersInStrings, nameof(bodyincludeNumbersInStrings), required: true);
            return new DeferredBodyAction<TypesIsNumberResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        [WorkflowExpressionFactory(nameof(__BuildTypesIsNullOrEmpty))]
        public IBodyWorkflowAction<TypesIsNullOrEmptyResponse> TypesIsNullOrEmpty([WorkflowExpression] Func<object> bodyvalue)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TypesIsNullOrEmptyResponse> __BuildTypesIsNullOrEmpty(WorkflowExpression<object> bodyvalue)
        {
            WorkflowExpression.Validate(bodyvalue, nameof(bodyvalue), required: true);
            return new DeferredBodyAction<TypesIsNullOrEmptyResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        [WorkflowExpressionFactory(nameof(__BuildTypesIsArray))]
        public IBodyWorkflowAction<TypesIsArrayResponse> TypesIsArray([WorkflowExpression] Func<object> bodyvalue)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TypesIsArrayResponse> __BuildTypesIsArray(WorkflowExpression<object> bodyvalue)
        {
            WorkflowExpression.Validate(bodyvalue, nameof(bodyvalue), required: true);
            return new DeferredBodyAction<TypesIsArrayResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        [WorkflowExpressionFactory(nameof(__BuildTypesIsObject))]
        public IBodyWorkflowAction<TypesIsObjectResponse> TypesIsObject([WorkflowExpression] Func<object> bodyvalue)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TypesIsObjectResponse> __BuildTypesIsObject(WorkflowExpression<object> bodyvalue)
        {
            WorkflowExpression.Validate(bodyvalue, nameof(bodyvalue), required: true);
            return new DeferredBodyAction<TypesIsObjectResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        [WorkflowExpressionFactory(nameof(__BuildValidateEmail))]
        public IBodyWorkflowAction<ValidateEmailResponse> ValidateEmail([WorkflowExpression] Func<string> bodyemail)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ValidateEmailResponse> __BuildValidateEmail(WorkflowExpression<string> bodyemail)
        {
            WorkflowExpression.Validate(bodyemail, nameof(bodyemail), required: true);
            return new DeferredBodyAction<ValidateEmailResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        [WorkflowExpressionFactory(nameof(__BuildValidateRegex))]
        public IBodyWorkflowAction<ValidateRegexResponse> ValidateRegex([WorkflowExpression] Func<string> bodystring, [WorkflowExpression] Func<string> bodypattern)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ValidateRegexResponse> __BuildValidateRegex(WorkflowExpression<string> bodystring, WorkflowExpression<string> bodypattern)
        {
            WorkflowExpression.Validate(bodystring, nameof(bodystring), required: true);
            WorkflowExpression.Validate(bodypattern, nameof(bodypattern), required: true);
            return new DeferredBodyAction<ValidateRegexResponse>(() =>
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