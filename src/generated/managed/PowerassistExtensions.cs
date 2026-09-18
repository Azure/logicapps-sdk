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
        public IBodyWorkflowAction<ArraySortResponse> ArraySort([WorkflowExpression] Func<JToken[]> bodyarray)
        {
            SourceExpression.Validate(bodyarray, nameof(bodyarray), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/array/sort";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["array"] = SourceExpressionConverter.ConvertToken(bodyarray);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ArraySortResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<ArrayReverseResponse> ArrayReverse([WorkflowExpression] Func<JToken[]> bodyarray)
        {
            SourceExpression.Validate(bodyarray, nameof(bodyarray), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/array/reverse";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["array"] = SourceExpressionConverter.ConvertToken(bodyarray);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ArrayReverseResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<ArraySortByPropertyResponse> ArraySortByProperty([WorkflowExpression] Func<JToken[]> bodyarray, [WorkflowExpression] Func<string> bodypropertyName, [WorkflowExpression] Func<bool> bodydescending)
        {
            SourceExpression.Validate(bodyarray, nameof(bodyarray), required: true);
            SourceExpression.Validate(bodypropertyName, nameof(bodypropertyName), required: true);
            SourceExpression.Validate(bodydescending, nameof(bodydescending), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/array/sortByProperty";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["array"] = SourceExpressionConverter.ConvertToken(bodyarray);
                bodypropCount++;
                body["propertyName"] = SourceExpressionConverter.ConvertToken(bodypropertyName);
                bodypropCount++;
                body["descending"] = SourceExpressionConverter.ConvertToken(bodydescending);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ArraySortByPropertyResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<ArrayFilterResponse> ArrayFilter([WorkflowExpression] Func<JToken[]> bodyarray, [WorkflowExpression] Func<string> bodypropertyName, [WorkflowExpression] Func<bodycomparisonInput> bodycomparison, [WorkflowExpression] Func<object> bodyvalue = null, [WorkflowExpression] Func<bodyvalueTypeInput> bodyvalueType = null)
        {
            SourceExpression.Validate(bodyarray, nameof(bodyarray), required: true);
            SourceExpression.Validate(bodypropertyName, nameof(bodypropertyName), required: true);
            SourceExpression.Validate(bodycomparison, nameof(bodycomparison), required: true);
            SourceExpression.Validate(bodyvalue, nameof(bodyvalue), required: false);
            SourceExpression.Validate(bodyvalueType, nameof(bodyvalueType), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/array/filter";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["array"] = SourceExpressionConverter.ConvertToken(bodyarray);
                bodypropCount++;
                body["propertyName"] = SourceExpressionConverter.ConvertToken(bodypropertyName);
                bodypropCount++;
                body["comparison"] = SourceExpressionConverter.Convert(bodycomparison);
                if (bodyvalue != null)
                {
                    body["value"] = SourceExpressionConverter.ConvertToken(bodyvalue);
                    bodypropCount++;
                }

                if (bodyvalueType != null)
                {
                    if (bodyvalueType != null)
                    {
                        body["valueType"] = SourceExpressionConverter.Convert(bodyvalueType);
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
                return callPayload;
            }

            return new ApiConnectionAction<ArrayFilterResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<ArrayPrependResponse> ArrayPrepend([WorkflowExpression] Func<JToken[]> bodyarray, [WorkflowExpression] Func<object> bodyvalue, [WorkflowExpression] Func<bodyvalueTypeInput> bodyvalueType = null)
        {
            SourceExpression.Validate(bodyarray, nameof(bodyarray), required: true);
            SourceExpression.Validate(bodyvalue, nameof(bodyvalue), required: true);
            SourceExpression.Validate(bodyvalueType, nameof(bodyvalueType), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/array/prepend";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["array"] = SourceExpressionConverter.ConvertToken(bodyarray);
                bodypropCount++;
                body["value"] = SourceExpressionConverter.ConvertToken(bodyvalue);
                if (bodyvalueType != null)
                {
                    if (bodyvalueType != null)
                    {
                        body["valueType"] = SourceExpressionConverter.Convert(bodyvalueType);
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
                return callPayload;
            }

            return new ApiConnectionAction<ArrayPrependResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<ArrayAnyResponse> ArrayAny([WorkflowExpression] Func<JToken[]> bodyarray, [WorkflowExpression] Func<string> bodypropertyName, [WorkflowExpression] Func<bodycomparisonInput> bodycomparison, [WorkflowExpression] Func<object> bodyvalue = null, [WorkflowExpression] Func<bodyvalueTypeInput> bodyvalueType = null)
        {
            SourceExpression.Validate(bodyarray, nameof(bodyarray), required: true);
            SourceExpression.Validate(bodypropertyName, nameof(bodypropertyName), required: true);
            SourceExpression.Validate(bodycomparison, nameof(bodycomparison), required: true);
            SourceExpression.Validate(bodyvalue, nameof(bodyvalue), required: false);
            SourceExpression.Validate(bodyvalueType, nameof(bodyvalueType), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/array/any";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["array"] = SourceExpressionConverter.ConvertToken(bodyarray);
                bodypropCount++;
                body["propertyName"] = SourceExpressionConverter.ConvertToken(bodypropertyName);
                bodypropCount++;
                body["comparison"] = SourceExpressionConverter.Convert(bodycomparison);
                if (bodyvalue != null)
                {
                    body["value"] = SourceExpressionConverter.ConvertToken(bodyvalue);
                    bodypropCount++;
                }

                if (bodyvalueType != null)
                {
                    if (bodyvalueType != null)
                    {
                        body["valueType"] = SourceExpressionConverter.Convert(bodyvalueType);
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
                return callPayload;
            }

            return new ApiConnectionAction<ArrayAnyResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<ArrayEveryResponse> ArrayEvery([WorkflowExpression] Func<JToken[]> bodyarray, [WorkflowExpression] Func<string> bodypropertyName, [WorkflowExpression] Func<bodycomparisonInput> bodycomparison, [WorkflowExpression] Func<object> bodyvalue = null, [WorkflowExpression] Func<bodyvalueTypeInput> bodyvalueType = null)
        {
            SourceExpression.Validate(bodyarray, nameof(bodyarray), required: true);
            SourceExpression.Validate(bodypropertyName, nameof(bodypropertyName), required: true);
            SourceExpression.Validate(bodycomparison, nameof(bodycomparison), required: true);
            SourceExpression.Validate(bodyvalue, nameof(bodyvalue), required: false);
            SourceExpression.Validate(bodyvalueType, nameof(bodyvalueType), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/array/every";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["array"] = SourceExpressionConverter.ConvertToken(bodyarray);
                bodypropCount++;
                body["propertyName"] = SourceExpressionConverter.ConvertToken(bodypropertyName);
                bodypropCount++;
                body["comparison"] = SourceExpressionConverter.Convert(bodycomparison);
                if (bodyvalue != null)
                {
                    body["value"] = SourceExpressionConverter.ConvertToken(bodyvalue);
                    bodypropCount++;
                }

                if (bodyvalueType != null)
                {
                    if (bodyvalueType != null)
                    {
                        body["valueType"] = SourceExpressionConverter.Convert(bodyvalueType);
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
                return callPayload;
            }

            return new ApiConnectionAction<ArrayEveryResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<ArrayRemoveFirstResponse> ArrayRemoveFirst([WorkflowExpression] Func<JToken[]> bodyarray, [WorkflowExpression] Func<string> bodypropertyName, [WorkflowExpression] Func<bodycomparisonInput> bodycomparison, [WorkflowExpression] Func<object> bodyvalue = null, [WorkflowExpression] Func<bodyvalueTypeInput> bodyvalueType = null)
        {
            SourceExpression.Validate(bodyarray, nameof(bodyarray), required: true);
            SourceExpression.Validate(bodypropertyName, nameof(bodypropertyName), required: true);
            SourceExpression.Validate(bodycomparison, nameof(bodycomparison), required: true);
            SourceExpression.Validate(bodyvalue, nameof(bodyvalue), required: false);
            SourceExpression.Validate(bodyvalueType, nameof(bodyvalueType), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/array/removeFirst";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["array"] = SourceExpressionConverter.ConvertToken(bodyarray);
                bodypropCount++;
                body["propertyName"] = SourceExpressionConverter.ConvertToken(bodypropertyName);
                bodypropCount++;
                body["comparison"] = SourceExpressionConverter.Convert(bodycomparison);
                if (bodyvalue != null)
                {
                    body["value"] = SourceExpressionConverter.ConvertToken(bodyvalue);
                    bodypropCount++;
                }

                if (bodyvalueType != null)
                {
                    if (bodyvalueType != null)
                    {
                        body["valueType"] = SourceExpressionConverter.Convert(bodyvalueType);
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
                return callPayload;
            }

            return new ApiConnectionAction<ArrayRemoveFirstResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<ArrayGroupByResponse> ArrayGroupBy([WorkflowExpression] Func<JToken[]> bodyarray, [WorkflowExpression] Func<string> bodypropertyName = null)
        {
            SourceExpression.Validate(bodyarray, nameof(bodyarray), required: true);
            SourceExpression.Validate(bodypropertyName, nameof(bodypropertyName), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/array/groupBy";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["array"] = SourceExpressionConverter.ConvertToken(bodyarray);
                if (bodypropertyName != null)
                {
                    body["propertyName"] = SourceExpressionConverter.ConvertToken(bodypropertyName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ArrayGroupByResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<ArrayFindFirstResponse> ArrayFindFirst([WorkflowExpression] Func<JToken[]> bodyarray, [WorkflowExpression] Func<string> bodypropertyName, [WorkflowExpression] Func<bodycomparisonInput> bodycomparison, [WorkflowExpression] Func<object> bodyvalue = null, [WorkflowExpression] Func<bodyvalueTypeInput> bodyvalueType = null)
        {
            SourceExpression.Validate(bodyarray, nameof(bodyarray), required: true);
            SourceExpression.Validate(bodypropertyName, nameof(bodypropertyName), required: true);
            SourceExpression.Validate(bodycomparison, nameof(bodycomparison), required: true);
            SourceExpression.Validate(bodyvalue, nameof(bodyvalue), required: false);
            SourceExpression.Validate(bodyvalueType, nameof(bodyvalueType), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/array/findFirst";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["array"] = SourceExpressionConverter.ConvertToken(bodyarray);
                bodypropCount++;
                body["propertyName"] = SourceExpressionConverter.ConvertToken(bodypropertyName);
                bodypropCount++;
                body["comparison"] = SourceExpressionConverter.Convert(bodycomparison);
                if (bodyvalue != null)
                {
                    body["value"] = SourceExpressionConverter.ConvertToken(bodyvalue);
                    bodypropCount++;
                }

                if (bodyvalueType != null)
                {
                    if (bodyvalueType != null)
                    {
                        body["valueType"] = SourceExpressionConverter.Convert(bodyvalueType);
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
                return callPayload;
            }

            return new ApiConnectionAction<ArrayFindFirstResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<RoundResponse> Round([WorkflowExpression] Func<double> bodynumber)
        {
            SourceExpression.Validate(bodynumber, nameof(bodynumber), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/math/round";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["number"] = SourceExpressionConverter.ConvertToken(bodynumber);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<RoundResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<MathCeilResponse> MathCeil([WorkflowExpression] Func<double> bodynumber)
        {
            SourceExpression.Validate(bodynumber, nameof(bodynumber), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/math/ceil";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["number"] = SourceExpressionConverter.ConvertToken(bodynumber);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MathCeilResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<MathFloorResponse> MathFloor([WorkflowExpression] Func<double> bodynumber)
        {
            SourceExpression.Validate(bodynumber, nameof(bodynumber), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/math/floor";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["number"] = SourceExpressionConverter.ConvertToken(bodynumber);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MathFloorResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<MathAverageResponse> MathAverage([WorkflowExpression] Func<double[]> bodynumbers)
        {
            SourceExpression.Validate(bodynumbers, nameof(bodynumbers), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/math/average";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["numbers"] = SourceExpressionConverter.ConvertToken(bodynumbers);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MathAverageResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<MathMedianResponse> MathMedian([WorkflowExpression] Func<JToken[]> bodynumbers)
        {
            SourceExpression.Validate(bodynumbers, nameof(bodynumbers), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/math/median";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["numbers"] = SourceExpressionConverter.ConvertToken(bodynumbers);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MathMedianResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<MathModeResponse> MathMode([WorkflowExpression] Func<JToken[]> bodynumbers)
        {
            SourceExpression.Validate(bodynumbers, nameof(bodynumbers), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/math/mode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["numbers"] = SourceExpressionConverter.ConvertToken(bodynumbers);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MathModeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<MathRandomResponse> MathRandom([WorkflowExpression] Func<int> bodymaximum)
        {
            SourceExpression.Validate(bodymaximum, nameof(bodymaximum), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/math/random";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["maximum"] = SourceExpressionConverter.ConvertToken(bodymaximum);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MathRandomResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<StringReplaceAllResponse> StringReplaceAll([WorkflowExpression] Func<string> bodysourceString, [WorkflowExpression] Func<string> bodysearchValue, [WorkflowExpression] Func<string> bodyreplaceValue)
        {
            SourceExpression.Validate(bodysourceString, nameof(bodysourceString), required: true);
            SourceExpression.Validate(bodysearchValue, nameof(bodysearchValue), required: true);
            SourceExpression.Validate(bodyreplaceValue, nameof(bodyreplaceValue), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/string/replaceAll";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["sourceString"] = SourceExpressionConverter.ConvertToken(bodysourceString);
                bodypropCount++;
                body["searchValue"] = SourceExpressionConverter.ConvertToken(bodysearchValue);
                bodypropCount++;
                body["replaceValue"] = SourceExpressionConverter.ConvertToken(bodyreplaceValue);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<StringReplaceAllResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<StringRegexReplaceResponse> StringRegexReplace([WorkflowExpression] Func<string> bodysourceString, [WorkflowExpression] Func<string> bodypattern, [WorkflowExpression] Func<string> bodyreplaceValue)
        {
            SourceExpression.Validate(bodysourceString, nameof(bodysourceString), required: true);
            SourceExpression.Validate(bodypattern, nameof(bodypattern), required: true);
            SourceExpression.Validate(bodyreplaceValue, nameof(bodyreplaceValue), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/string/regexReplace";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["sourceString"] = SourceExpressionConverter.ConvertToken(bodysourceString);
                bodypropCount++;
                body["pattern"] = SourceExpressionConverter.ConvertToken(bodypattern);
                bodypropCount++;
                body["replaceValue"] = SourceExpressionConverter.ConvertToken(bodyreplaceValue);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<StringRegexReplaceResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<StringCapitalizeResponse> StringCapitalize([WorkflowExpression] Func<string> bodystring)
        {
            SourceExpression.Validate(bodystring, nameof(bodystring), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/string/capitalize";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["string"] = SourceExpressionConverter.ConvertToken(bodystring);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<StringCapitalizeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<StringTrimResponse> StringTrim([WorkflowExpression] Func<string> bodystring, [WorkflowExpression] Func<string> bodycharacters = null)
        {
            SourceExpression.Validate(bodystring, nameof(bodystring), required: true);
            SourceExpression.Validate(bodycharacters, nameof(bodycharacters), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/string/trim";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["string"] = SourceExpressionConverter.ConvertToken(bodystring);
                if (bodycharacters != null)
                {
                    body["characters"] = SourceExpressionConverter.ConvertToken(bodycharacters);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<StringTrimResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<StringTrimStartResponse> StringTrimStart([WorkflowExpression] Func<string> bodystring, [WorkflowExpression] Func<string> bodycharacters = null)
        {
            SourceExpression.Validate(bodystring, nameof(bodystring), required: true);
            SourceExpression.Validate(bodycharacters, nameof(bodycharacters), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/string/trimStart";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["string"] = SourceExpressionConverter.ConvertToken(bodystring);
                if (bodycharacters != null)
                {
                    body["characters"] = SourceExpressionConverter.ConvertToken(bodycharacters);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<StringTrimStartResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<StringTrimEndResponse> StringTrimEnd([WorkflowExpression] Func<string> bodystring, [WorkflowExpression] Func<string> bodycharacters = null)
        {
            SourceExpression.Validate(bodystring, nameof(bodystring), required: true);
            SourceExpression.Validate(bodycharacters, nameof(bodycharacters), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/string/trimEnd";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["string"] = SourceExpressionConverter.ConvertToken(bodystring);
                if (bodycharacters != null)
                {
                    body["characters"] = SourceExpressionConverter.ConvertToken(bodycharacters);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<StringTrimEndResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<StringSlugifyResponse> StringSlugify([WorkflowExpression] Func<string> bodystring)
        {
            SourceExpression.Validate(bodystring, nameof(bodystring), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/string/slugify";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["string"] = SourceExpressionConverter.ConvertToken(bodystring);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<StringSlugifyResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<StringWordsResponse> StringWords([WorkflowExpression] Func<string> bodystring, [WorkflowExpression] Func<string> bodydelimiter = null)
        {
            SourceExpression.Validate(bodystring, nameof(bodystring), required: true);
            SourceExpression.Validate(bodydelimiter, nameof(bodydelimiter), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/string/words";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["string"] = SourceExpressionConverter.ConvertToken(bodystring);
                if (bodydelimiter != null)
                {
                    body["delimiter"] = SourceExpressionConverter.ConvertToken(bodydelimiter);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<StringWordsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<StringWordCountResponse> StringWordCount([WorkflowExpression] Func<string> bodystring, [WorkflowExpression] Func<string> bodydelimiter = null)
        {
            SourceExpression.Validate(bodystring, nameof(bodystring), required: true);
            SourceExpression.Validate(bodydelimiter, nameof(bodydelimiter), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/string/wordCount";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["string"] = SourceExpressionConverter.ConvertToken(bodystring);
                if (bodydelimiter != null)
                {
                    body["delimiter"] = SourceExpressionConverter.ConvertToken(bodydelimiter);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<StringWordCountResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<StringStripHtmlResponse> StringStripHtml([WorkflowExpression] Func<string> bodystring)
        {
            SourceExpression.Validate(bodystring, nameof(bodystring), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/string/stripHtml";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["string"] = SourceExpressionConverter.ConvertToken(bodystring);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<StringStripHtmlResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<StringCleanResponse> StringClean([WorkflowExpression] Func<string> bodystring)
        {
            SourceExpression.Validate(bodystring, nameof(bodystring), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/string/clean";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["string"] = SourceExpressionConverter.ConvertToken(bodystring);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<StringCleanResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<StringCleanDiacriticsResponse> StringCleanDiacritics([WorkflowExpression] Func<string> bodystring)
        {
            SourceExpression.Validate(bodystring, nameof(bodystring), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/string/cleanDiacritics";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["string"] = SourceExpressionConverter.ConvertToken(bodystring);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<StringCleanDiacriticsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<StringEscapeHtmlResponse> StringEscapeHtml([WorkflowExpression] Func<string> bodystring)
        {
            SourceExpression.Validate(bodystring, nameof(bodystring), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/string/escapeHtml";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["string"] = SourceExpressionConverter.ConvertToken(bodystring);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<StringEscapeHtmlResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<StringUnescapeHtmlResponse> StringUnescapeHtml([WorkflowExpression] Func<string> bodystring)
        {
            SourceExpression.Validate(bodystring, nameof(bodystring), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/string/unescapeHtml";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["string"] = SourceExpressionConverter.ConvertToken(bodystring);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<StringUnescapeHtmlResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<StringCountInstancesResponse> StringCountInstances([WorkflowExpression] Func<string> bodystring, [WorkflowExpression] Func<string> bodysubstring, [WorkflowExpression] Func<bool> bodyignoreCase = null)
        {
            SourceExpression.Validate(bodystring, nameof(bodystring), required: true);
            SourceExpression.Validate(bodysubstring, nameof(bodysubstring), required: true);
            SourceExpression.Validate(bodyignoreCase, nameof(bodyignoreCase), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/string/countInstances";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["string"] = SourceExpressionConverter.ConvertToken(bodystring);
                bodypropCount++;
                body["substring"] = SourceExpressionConverter.ConvertToken(bodysubstring);
                if (bodyignoreCase != null)
                {
                    if (bodyignoreCase != null)
                    {
                        body["ignoreCase"] = SourceExpressionConverter.ConvertToken(bodyignoreCase);
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
                return callPayload;
            }

            return new ApiConnectionAction<StringCountInstancesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<StringChopResponse> StringChop([WorkflowExpression] Func<string> bodystring, [WorkflowExpression] Func<int> bodyinterval)
        {
            SourceExpression.Validate(bodystring, nameof(bodystring), required: true);
            SourceExpression.Validate(bodyinterval, nameof(bodyinterval), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/string/chop";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["string"] = SourceExpressionConverter.ConvertToken(bodystring);
                bodypropCount++;
                body["interval"] = SourceExpressionConverter.ConvertToken(bodyinterval);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<StringChopResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<TypesIsStringResponse> TypesIsString([WorkflowExpression] Func<object> bodyvalue)
        {
            SourceExpression.Validate(bodyvalue, nameof(bodyvalue), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/types/isString";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["value"] = SourceExpressionConverter.ConvertToken(bodyvalue);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<TypesIsStringResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<TypesIsNumberResponse> TypesIsNumber([WorkflowExpression] Func<object> bodyvalue, [WorkflowExpression] Func<bool> bodyincludeNumbersInStrings)
        {
            SourceExpression.Validate(bodyvalue, nameof(bodyvalue), required: true);
            SourceExpression.Validate(bodyincludeNumbersInStrings, nameof(bodyincludeNumbersInStrings), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/types/isNumber";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["value"] = SourceExpressionConverter.ConvertToken(bodyvalue);
                bodypropCount++;
                body["includeNumbersInStrings"] = SourceExpressionConverter.ConvertToken(bodyincludeNumbersInStrings);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<TypesIsNumberResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<TypesIsNullOrEmptyResponse> TypesIsNullOrEmpty([WorkflowExpression] Func<object> bodyvalue)
        {
            SourceExpression.Validate(bodyvalue, nameof(bodyvalue), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/types/isNullOrEmpty";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["value"] = SourceExpressionConverter.ConvertToken(bodyvalue);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<TypesIsNullOrEmptyResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<TypesIsArrayResponse> TypesIsArray([WorkflowExpression] Func<object> bodyvalue)
        {
            SourceExpression.Validate(bodyvalue, nameof(bodyvalue), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/types/isArray";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["value"] = SourceExpressionConverter.ConvertToken(bodyvalue);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<TypesIsArrayResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<TypesIsObjectResponse> TypesIsObject([WorkflowExpression] Func<object> bodyvalue)
        {
            SourceExpression.Validate(bodyvalue, nameof(bodyvalue), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/types/isObject";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["value"] = SourceExpressionConverter.ConvertToken(bodyvalue);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<TypesIsObjectResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<ValidateEmailResponse> ValidateEmail([WorkflowExpression] Func<string> bodyemail)
        {
            SourceExpression.Validate(bodyemail, nameof(bodyemail), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/validate/email";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ValidateEmailResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerassist")]
        public IBodyWorkflowAction<ValidateRegexResponse> ValidateRegex([WorkflowExpression] Func<string> bodystring, [WorkflowExpression] Func<string> bodypattern)
        {
            SourceExpression.Validate(bodystring, nameof(bodystring), required: true);
            SourceExpression.Validate(bodypattern, nameof(bodypattern), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/validate/regex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["string"] = SourceExpressionConverter.ConvertToken(bodystring);
                bodypropCount++;
                body["pattern"] = SourceExpressionConverter.ConvertToken(bodypattern);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ValidateRegexResponse>(BuildSourceInput);
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