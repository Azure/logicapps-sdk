//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Advanceddataoperatio
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AdvanceddataoperatioActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<JToken[]> Aggregate([WorkflowExpression] Func<bodyaggregationTypeInput> bodyaggregationType, [WorkflowExpression] Func<string[]> bodyaggregateBy, [WorkflowExpression] Func<string[]> bodyaggregateOn, [WorkflowExpression] Func<string> bodyfilter = null, [WorkflowExpression] Func<string> bodyadvancedOptionscultureName = null, [WorkflowExpression] Func<string[]> bodyadvancedOptionsisBoolean = null, [WorkflowExpression] Func<JToken[]> bodydata = null)
        {
            SourceExpression.Validate(bodyaggregationType, nameof(bodyaggregationType), required: true);
            SourceExpression.Validate(bodyaggregateBy, nameof(bodyaggregateBy), required: true);
            SourceExpression.Validate(bodyaggregateOn, nameof(bodyaggregateOn), required: true);
            SourceExpression.Validate(bodyfilter, nameof(bodyfilter), required: false);
            SourceExpression.Validate(bodyadvancedOptionscultureName, nameof(bodyadvancedOptionscultureName), required: false);
            SourceExpression.Validate(bodyadvancedOptionsisBoolean, nameof(bodyadvancedOptionsisBoolean), required: false);
            SourceExpression.Validate(bodydata, nameof(bodydata), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Aggregate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["aggregationType"] = SourceExpressionConverter.Convert(bodyaggregationType);
                bodypropCount++;
                body["aggregateBy"] = SourceExpressionConverter.ConvertToken(bodyaggregateBy);
                bodypropCount++;
                body["aggregateOn"] = SourceExpressionConverter.ConvertToken(bodyaggregateOn);
                if (bodyfilter != null)
                {
                    body["filter"] = SourceExpressionConverter.ConvertToken(bodyfilter);
                    bodypropCount++;
                }

                var sortOrderObject = new JObject();
                var sortOrderObjectpropCount = 0;
                if (sortOrderObjectpropCount > 0)
                {
                    body["sortOrder"] = sortOrderObject;
                    bodypropCount++;
                }

                var schemaObject = new JObject();
                var schemaObjectpropCount = 0;
                if (schemaObjectpropCount > 0)
                {
                    body["schema"] = schemaObject;
                    bodypropCount++;
                }

                var advancedOptionsObject = new JObject();
                var advancedOptionsObjectpropCount = 0;
                if (bodyadvancedOptionscultureName != null)
                {
                    advancedOptionsObject["cultureName"] = SourceExpressionConverter.ConvertToken(bodyadvancedOptionscultureName);
                    advancedOptionsObjectpropCount++;
                }

                if (bodyadvancedOptionsisBoolean != null)
                {
                    advancedOptionsObject["isBoolean"] = SourceExpressionConverter.ConvertToken(bodyadvancedOptionsisBoolean);
                    advancedOptionsObjectpropCount++;
                }

                if (advancedOptionsObjectpropCount > 0)
                {
                    body["advancedOptions"] = advancedOptionsObject;
                    bodypropCount++;
                }

                if (bodydata != null)
                {
                    body["data"] = SourceExpressionConverter.ConvertToken(bodydata);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<JToken[]> CartesianJoin([WorkflowExpression] Func<string> bodyfilter = null, [WorkflowExpression] Func<string> bodyadvancedOptionscultureName = null, [WorkflowExpression] Func<string[]> bodyadvancedOptionsisBoolean = null)
        {
            SourceExpression.Validate(bodyfilter, nameof(bodyfilter), required: false);
            SourceExpression.Validate(bodyadvancedOptionscultureName, nameof(bodyadvancedOptionscultureName), required: false);
            SourceExpression.Validate(bodyadvancedOptionsisBoolean, nameof(bodyadvancedOptionsisBoolean), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/CartesianJoin";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfilter != null)
                {
                    body["filter"] = SourceExpressionConverter.ConvertToken(bodyfilter);
                    bodypropCount++;
                }

                var sortOrderObject = new JObject();
                var sortOrderObjectpropCount = 0;
                if (sortOrderObjectpropCount > 0)
                {
                    body["sortOrder"] = sortOrderObject;
                    bodypropCount++;
                }

                var schemaObject = new JObject();
                var schemaObjectpropCount = 0;
                if (schemaObjectpropCount > 0)
                {
                    body["schema"] = schemaObject;
                    bodypropCount++;
                }

                var advancedOptionsObject = new JObject();
                var advancedOptionsObjectpropCount = 0;
                if (bodyadvancedOptionscultureName != null)
                {
                    advancedOptionsObject["cultureName"] = SourceExpressionConverter.ConvertToken(bodyadvancedOptionscultureName);
                    advancedOptionsObjectpropCount++;
                }

                if (bodyadvancedOptionsisBoolean != null)
                {
                    advancedOptionsObject["isBoolean"] = SourceExpressionConverter.ConvertToken(bodyadvancedOptionsisBoolean);
                    advancedOptionsObjectpropCount++;
                }

                if (advancedOptionsObjectpropCount > 0)
                {
                    body["advancedOptions"] = advancedOptionsObject;
                    bodypropCount++;
                }

                var dataObject = new JObject();
                var dataObjectpropCount = 0;
                if (dataObjectpropCount > 0)
                {
                    body["data"] = dataObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<string> Concatenate([WorkflowExpression] Func<string> bodyfield, [WorkflowExpression] Func<string> bodyseparator = null, [WorkflowExpression] Func<bool> bodyignoreEmpty = null, [WorkflowExpression] Func<string> bodyfilter = null, [WorkflowExpression] Func<string> bodyadvancedOptionscultureName = null, [WorkflowExpression] Func<string[]> bodyadvancedOptionsisBoolean = null, [WorkflowExpression] Func<JToken[]> bodydata = null)
        {
            SourceExpression.Validate(bodyfield, nameof(bodyfield), required: true);
            SourceExpression.Validate(bodyseparator, nameof(bodyseparator), required: false);
            SourceExpression.Validate(bodyignoreEmpty, nameof(bodyignoreEmpty), required: false);
            SourceExpression.Validate(bodyfilter, nameof(bodyfilter), required: false);
            SourceExpression.Validate(bodyadvancedOptionscultureName, nameof(bodyadvancedOptionscultureName), required: false);
            SourceExpression.Validate(bodyadvancedOptionsisBoolean, nameof(bodyadvancedOptionsisBoolean), required: false);
            SourceExpression.Validate(bodydata, nameof(bodydata), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Concatenate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["field"] = SourceExpressionConverter.ConvertToken(bodyfield);
                if (bodyseparator != null)
                {
                    body["separator"] = SourceExpressionConverter.ConvertToken(bodyseparator);
                    bodypropCount++;
                }

                if (bodyignoreEmpty != null)
                {
                    body["ignoreEmpty"] = SourceExpressionConverter.ConvertToken(bodyignoreEmpty);
                    bodypropCount++;
                }

                if (bodyfilter != null)
                {
                    body["filter"] = SourceExpressionConverter.ConvertToken(bodyfilter);
                    bodypropCount++;
                }

                var sortOrderObject = new JObject();
                var sortOrderObjectpropCount = 0;
                if (sortOrderObjectpropCount > 0)
                {
                    body["sortOrder"] = sortOrderObject;
                    bodypropCount++;
                }

                var schemaObject = new JObject();
                var schemaObjectpropCount = 0;
                if (schemaObjectpropCount > 0)
                {
                    body["schema"] = schemaObject;
                    bodypropCount++;
                }

                var advancedOptionsObject = new JObject();
                var advancedOptionsObjectpropCount = 0;
                if (bodyadvancedOptionscultureName != null)
                {
                    advancedOptionsObject["cultureName"] = SourceExpressionConverter.ConvertToken(bodyadvancedOptionscultureName);
                    advancedOptionsObjectpropCount++;
                }

                if (bodyadvancedOptionsisBoolean != null)
                {
                    advancedOptionsObject["isBoolean"] = SourceExpressionConverter.ConvertToken(bodyadvancedOptionsisBoolean);
                    advancedOptionsObjectpropCount++;
                }

                if (advancedOptionsObjectpropCount > 0)
                {
                    body["advancedOptions"] = advancedOptionsObject;
                    bodypropCount++;
                }

                if (bodydata != null)
                {
                    body["data"] = SourceExpressionConverter.ConvertToken(bodydata);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<JToken> CSharpEvaluate([WorkflowExpression] Func<string> bodyexpression)
        {
            SourceExpression.Validate(bodyexpression, nameof(bodyexpression), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/CSharpEvaluate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["expression"] = SourceExpressionConverter.ConvertToken(bodyexpression);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<JToken> CSharpScriptExecute([WorkflowExpression] Func<string> bodyscript, [WorkflowExpression] Func<string[]> bodyclassDefinitions = null)
        {
            SourceExpression.Validate(bodyscript, nameof(bodyscript), required: true);
            SourceExpression.Validate(bodyclassDefinitions, nameof(bodyclassDefinitions), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/CSharpScriptExecute";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["script"] = SourceExpressionConverter.ConvertToken(bodyscript);
                if (bodyclassDefinitions != null)
                {
                    body["classDefinitions"] = SourceExpressionConverter.ConvertToken(bodyclassDefinitions);
                    bodypropCount++;
                }

                var parametersObject = new JObject();
                var parametersObjectpropCount = 0;
                if (parametersObjectpropCount > 0)
                {
                    body["parameters"] = parametersObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<JToken[]> CsvToJson([WorkflowExpression] Func<string> bodydata, [WorkflowExpression] Func<bool> bodyheaderRow = null, [WorkflowExpression] Func<string> bodyrowSeparator = null, [WorkflowExpression] Func<string> bodydelimiter = null, [WorkflowExpression] Func<string> bodyescapeCharacter = null, [WorkflowExpression] Func<bodyencodingInput> bodyencoding = null, [WorkflowExpression] Func<string> bodyfilter = null, [WorkflowExpression] Func<string> bodyadvancedOptionscultureName = null, [WorkflowExpression] Func<string[]> bodyadvancedOptionsisBoolean = null)
        {
            SourceExpression.Validate(bodydata, nameof(bodydata), required: true);
            SourceExpression.Validate(bodyheaderRow, nameof(bodyheaderRow), required: false);
            SourceExpression.Validate(bodyrowSeparator, nameof(bodyrowSeparator), required: false);
            SourceExpression.Validate(bodydelimiter, nameof(bodydelimiter), required: false);
            SourceExpression.Validate(bodyescapeCharacter, nameof(bodyescapeCharacter), required: false);
            SourceExpression.Validate(bodyencoding, nameof(bodyencoding), required: false);
            SourceExpression.Validate(bodyfilter, nameof(bodyfilter), required: false);
            SourceExpression.Validate(bodyadvancedOptionscultureName, nameof(bodyadvancedOptionscultureName), required: false);
            SourceExpression.Validate(bodyadvancedOptionsisBoolean, nameof(bodyadvancedOptionsisBoolean), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/CsvToJson";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyheaderRow != null)
                {
                    body["headerRow"] = SourceExpressionConverter.ConvertToken(bodyheaderRow);
                    bodypropCount++;
                }

                if (bodyrowSeparator != null)
                {
                    body["rowSeparator"] = SourceExpressionConverter.ConvertToken(bodyrowSeparator);
                    bodypropCount++;
                }

                if (bodydelimiter != null)
                {
                    body["delimiter"] = SourceExpressionConverter.ConvertToken(bodydelimiter);
                    bodypropCount++;
                }

                if (bodyescapeCharacter != null)
                {
                    body["escapeCharacter"] = SourceExpressionConverter.ConvertToken(bodyescapeCharacter);
                    bodypropCount++;
                }

                if (bodyencoding != null)
                {
                    body["encoding"] = SourceExpressionConverter.Convert(bodyencoding);
                    bodypropCount++;
                }

                if (bodyfilter != null)
                {
                    body["filter"] = SourceExpressionConverter.ConvertToken(bodyfilter);
                    bodypropCount++;
                }

                var sortOrderObject = new JObject();
                var sortOrderObjectpropCount = 0;
                if (sortOrderObjectpropCount > 0)
                {
                    body["sortOrder"] = sortOrderObject;
                    bodypropCount++;
                }

                var schemaObject = new JObject();
                var schemaObjectpropCount = 0;
                if (schemaObjectpropCount > 0)
                {
                    body["schema"] = schemaObject;
                    bodypropCount++;
                }

                var advancedOptionsObject = new JObject();
                var advancedOptionsObjectpropCount = 0;
                if (bodyadvancedOptionscultureName != null)
                {
                    advancedOptionsObject["cultureName"] = SourceExpressionConverter.ConvertToken(bodyadvancedOptionscultureName);
                    advancedOptionsObjectpropCount++;
                }

                if (bodyadvancedOptionsisBoolean != null)
                {
                    advancedOptionsObject["isBoolean"] = SourceExpressionConverter.ConvertToken(bodyadvancedOptionsisBoolean);
                    advancedOptionsObjectpropCount++;
                }

                if (advancedOptionsObjectpropCount > 0)
                {
                    body["advancedOptions"] = advancedOptionsObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["data"] = SourceExpressionConverter.ConvertToken(bodydata);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IWorkflowAction Distinct([WorkflowExpression] Func<string[]> bodyfields, [WorkflowExpression] Func<string> bodyfilter = null, [WorkflowExpression] Func<string> bodyadvancedOptionscultureName = null, [WorkflowExpression] Func<string[]> bodyadvancedOptionsisBoolean = null, [WorkflowExpression] Func<JToken[]> bodydata = null)
        {
            SourceExpression.Validate(bodyfields, nameof(bodyfields), required: true);
            SourceExpression.Validate(bodyfilter, nameof(bodyfilter), required: false);
            SourceExpression.Validate(bodyadvancedOptionscultureName, nameof(bodyadvancedOptionscultureName), required: false);
            SourceExpression.Validate(bodyadvancedOptionsisBoolean, nameof(bodyadvancedOptionsisBoolean), required: false);
            SourceExpression.Validate(bodydata, nameof(bodydata), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Distinct";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["fields"] = SourceExpressionConverter.ConvertToken(bodyfields);
                if (bodyfilter != null)
                {
                    body["filter"] = SourceExpressionConverter.ConvertToken(bodyfilter);
                    bodypropCount++;
                }

                var sortOrderObject = new JObject();
                var sortOrderObjectpropCount = 0;
                if (sortOrderObjectpropCount > 0)
                {
                    body["sortOrder"] = sortOrderObject;
                    bodypropCount++;
                }

                var schemaObject = new JObject();
                var schemaObjectpropCount = 0;
                if (schemaObjectpropCount > 0)
                {
                    body["schema"] = schemaObject;
                    bodypropCount++;
                }

                var advancedOptionsObject = new JObject();
                var advancedOptionsObjectpropCount = 0;
                if (bodyadvancedOptionscultureName != null)
                {
                    advancedOptionsObject["cultureName"] = SourceExpressionConverter.ConvertToken(bodyadvancedOptionscultureName);
                    advancedOptionsObjectpropCount++;
                }

                if (bodyadvancedOptionsisBoolean != null)
                {
                    advancedOptionsObject["isBoolean"] = SourceExpressionConverter.ConvertToken(bodyadvancedOptionsisBoolean);
                    advancedOptionsObjectpropCount++;
                }

                if (advancedOptionsObjectpropCount > 0)
                {
                    body["advancedOptions"] = advancedOptionsObject;
                    bodypropCount++;
                }

                if (bodydata != null)
                {
                    body["data"] = SourceExpressionConverter.ConvertToken(bodydata);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<JToken[]> Expert([WorkflowExpression] Func<string> bodyquery, [WorkflowExpression] Func<string> bodyadvancedOptionscultureName = null, [WorkflowExpression] Func<string[]> bodyadvancedOptionsisBoolean = null)
        {
            SourceExpression.Validate(bodyquery, nameof(bodyquery), required: true);
            SourceExpression.Validate(bodyadvancedOptionscultureName, nameof(bodyadvancedOptionscultureName), required: false);
            SourceExpression.Validate(bodyadvancedOptionsisBoolean, nameof(bodyadvancedOptionsisBoolean), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Expert";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["query"] = SourceExpressionConverter.ConvertToken(bodyquery);
                var schemaObject = new JObject();
                var schemaObjectpropCount = 0;
                if (schemaObjectpropCount > 0)
                {
                    body["schema"] = schemaObject;
                    bodypropCount++;
                }

                var advancedOptionsObject = new JObject();
                var advancedOptionsObjectpropCount = 0;
                if (bodyadvancedOptionscultureName != null)
                {
                    advancedOptionsObject["cultureName"] = SourceExpressionConverter.ConvertToken(bodyadvancedOptionscultureName);
                    advancedOptionsObjectpropCount++;
                }

                if (bodyadvancedOptionsisBoolean != null)
                {
                    advancedOptionsObject["isBoolean"] = SourceExpressionConverter.ConvertToken(bodyadvancedOptionsisBoolean);
                    advancedOptionsObjectpropCount++;
                }

                if (advancedOptionsObjectpropCount > 0)
                {
                    body["advancedOptions"] = advancedOptionsObject;
                    bodypropCount++;
                }

                var dataObject = new JObject();
                var dataObjectpropCount = 0;
                if (dataObjectpropCount > 0)
                {
                    body["data"] = dataObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<JToken[]> FilterObjectArray([WorkflowExpression] Func<string> bodyfilter, [WorkflowExpression] Func<JToken[]> bodydata = null)
        {
            SourceExpression.Validate(bodyfilter, nameof(bodyfilter), required: true);
            SourceExpression.Validate(bodydata, nameof(bodydata), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/FilterObjectArray";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["filter"] = SourceExpressionConverter.ConvertToken(bodyfilter);
                if (bodydata != null)
                {
                    body["data"] = SourceExpressionConverter.ConvertToken(bodydata);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<JToken[]> FlattenObjectArray([WorkflowExpression] Func<string> bodydelimiter, [WorkflowExpression] Func<bool> bodybalancedOutput, [WorkflowExpression] Func<string> bodyfilter = null, [WorkflowExpression] Func<string> bodyadvancedOptionscultureName = null, [WorkflowExpression] Func<string[]> bodyadvancedOptionsisBoolean = null, [WorkflowExpression] Func<JToken[]> bodydata = null)
        {
            SourceExpression.Validate(bodydelimiter, nameof(bodydelimiter), required: true);
            SourceExpression.Validate(bodybalancedOutput, nameof(bodybalancedOutput), required: true);
            SourceExpression.Validate(bodyfilter, nameof(bodyfilter), required: false);
            SourceExpression.Validate(bodyadvancedOptionscultureName, nameof(bodyadvancedOptionscultureName), required: false);
            SourceExpression.Validate(bodyadvancedOptionsisBoolean, nameof(bodyadvancedOptionsisBoolean), required: false);
            SourceExpression.Validate(bodydata, nameof(bodydata), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/FlattenObjectArray";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["delimiter"] = SourceExpressionConverter.ConvertToken(bodydelimiter);
                bodypropCount++;
                body["balancedOutput"] = SourceExpressionConverter.ConvertToken(bodybalancedOutput);
                if (bodyfilter != null)
                {
                    body["filter"] = SourceExpressionConverter.ConvertToken(bodyfilter);
                    bodypropCount++;
                }

                var sortOrderObject = new JObject();
                var sortOrderObjectpropCount = 0;
                if (sortOrderObjectpropCount > 0)
                {
                    body["sortOrder"] = sortOrderObject;
                    bodypropCount++;
                }

                var schemaObject = new JObject();
                var schemaObjectpropCount = 0;
                if (schemaObjectpropCount > 0)
                {
                    body["schema"] = schemaObject;
                    bodypropCount++;
                }

                var advancedOptionsObject = new JObject();
                var advancedOptionsObjectpropCount = 0;
                if (bodyadvancedOptionscultureName != null)
                {
                    advancedOptionsObject["cultureName"] = SourceExpressionConverter.ConvertToken(bodyadvancedOptionscultureName);
                    advancedOptionsObjectpropCount++;
                }

                if (bodyadvancedOptionsisBoolean != null)
                {
                    advancedOptionsObject["isBoolean"] = SourceExpressionConverter.ConvertToken(bodyadvancedOptionsisBoolean);
                    advancedOptionsObjectpropCount++;
                }

                if (advancedOptionsObjectpropCount > 0)
                {
                    body["advancedOptions"] = advancedOptionsObject;
                    bodypropCount++;
                }

                if (bodydata != null)
                {
                    body["data"] = SourceExpressionConverter.ConvertToken(bodydata);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<JToken[]> GetDataSchema([WorkflowExpression] Func<string> bodyfilter = null, [WorkflowExpression] Func<string> bodyadvancedOptionscultureName = null, [WorkflowExpression] Func<string[]> bodyadvancedOptionsisBoolean = null, [WorkflowExpression] Func<JToken[]> bodydata = null)
        {
            SourceExpression.Validate(bodyfilter, nameof(bodyfilter), required: false);
            SourceExpression.Validate(bodyadvancedOptionscultureName, nameof(bodyadvancedOptionscultureName), required: false);
            SourceExpression.Validate(bodyadvancedOptionsisBoolean, nameof(bodyadvancedOptionsisBoolean), required: false);
            SourceExpression.Validate(bodydata, nameof(bodydata), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/GetDataSchema";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfilter != null)
                {
                    body["filter"] = SourceExpressionConverter.ConvertToken(bodyfilter);
                    bodypropCount++;
                }

                var sortOrderObject = new JObject();
                var sortOrderObjectpropCount = 0;
                if (sortOrderObjectpropCount > 0)
                {
                    body["sortOrder"] = sortOrderObject;
                    bodypropCount++;
                }

                var schemaObject = new JObject();
                var schemaObjectpropCount = 0;
                if (schemaObjectpropCount > 0)
                {
                    body["schema"] = schemaObject;
                    bodypropCount++;
                }

                var advancedOptionsObject = new JObject();
                var advancedOptionsObjectpropCount = 0;
                if (bodyadvancedOptionscultureName != null)
                {
                    advancedOptionsObject["cultureName"] = SourceExpressionConverter.ConvertToken(bodyadvancedOptionscultureName);
                    advancedOptionsObjectpropCount++;
                }

                if (bodyadvancedOptionsisBoolean != null)
                {
                    advancedOptionsObject["isBoolean"] = SourceExpressionConverter.ConvertToken(bodyadvancedOptionsisBoolean);
                    advancedOptionsObjectpropCount++;
                }

                if (advancedOptionsObjectpropCount > 0)
                {
                    body["advancedOptions"] = advancedOptionsObject;
                    bodypropCount++;
                }

                if (bodydata != null)
                {
                    body["data"] = SourceExpressionConverter.ConvertToken(bodydata);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<string> GZipCompress([WorkflowExpression] Func<string> bodydata)
        {
            SourceExpression.Validate(bodydata, nameof(bodydata), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/GZipCompress";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["data"] = SourceExpressionConverter.ConvertToken(bodydata);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<string> GZipDecompress([WorkflowExpression] Func<string> bodydata)
        {
            SourceExpression.Validate(bodydata, nameof(bodydata), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/GZipDecompress";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["data"] = SourceExpressionConverter.ConvertToken(bodydata);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<JToken[]> Join([WorkflowExpression] Func<bodyjoinTypeInput> bodyjoinType, [WorkflowExpression] Func<string[]> bodyjoinFields, [WorkflowExpression] Func<string[]> bodyfields, [WorkflowExpression] Func<bool> bodyforceFullyQualifiedFieldNames = null, [WorkflowExpression] Func<string> bodyfilter = null, [WorkflowExpression] Func<string> bodyadvancedOptionscultureName = null, [WorkflowExpression] Func<string[]> bodyadvancedOptionsisBoolean = null)
        {
            SourceExpression.Validate(bodyjoinType, nameof(bodyjoinType), required: true);
            SourceExpression.Validate(bodyjoinFields, nameof(bodyjoinFields), required: true);
            SourceExpression.Validate(bodyfields, nameof(bodyfields), required: true);
            SourceExpression.Validate(bodyforceFullyQualifiedFieldNames, nameof(bodyforceFullyQualifiedFieldNames), required: false);
            SourceExpression.Validate(bodyfilter, nameof(bodyfilter), required: false);
            SourceExpression.Validate(bodyadvancedOptionscultureName, nameof(bodyadvancedOptionscultureName), required: false);
            SourceExpression.Validate(bodyadvancedOptionsisBoolean, nameof(bodyadvancedOptionsisBoolean), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Join";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["joinType"] = SourceExpressionConverter.Convert(bodyjoinType);
                bodypropCount++;
                body["joinFields"] = SourceExpressionConverter.ConvertToken(bodyjoinFields);
                bodypropCount++;
                body["fields"] = SourceExpressionConverter.ConvertToken(bodyfields);
                if (bodyforceFullyQualifiedFieldNames != null)
                {
                    body["forceFullyQualifiedFieldNames"] = SourceExpressionConverter.ConvertToken(bodyforceFullyQualifiedFieldNames);
                    bodypropCount++;
                }

                if (bodyfilter != null)
                {
                    body["filter"] = SourceExpressionConverter.ConvertToken(bodyfilter);
                    bodypropCount++;
                }

                var sortOrderObject = new JObject();
                var sortOrderObjectpropCount = 0;
                if (sortOrderObjectpropCount > 0)
                {
                    body["sortOrder"] = sortOrderObject;
                    bodypropCount++;
                }

                var schemaObject = new JObject();
                var schemaObjectpropCount = 0;
                if (schemaObjectpropCount > 0)
                {
                    body["schema"] = schemaObject;
                    bodypropCount++;
                }

                var advancedOptionsObject = new JObject();
                var advancedOptionsObjectpropCount = 0;
                if (bodyadvancedOptionscultureName != null)
                {
                    advancedOptionsObject["cultureName"] = SourceExpressionConverter.ConvertToken(bodyadvancedOptionscultureName);
                    advancedOptionsObjectpropCount++;
                }

                if (bodyadvancedOptionsisBoolean != null)
                {
                    advancedOptionsObject["isBoolean"] = SourceExpressionConverter.ConvertToken(bodyadvancedOptionsisBoolean);
                    advancedOptionsObjectpropCount++;
                }

                if (advancedOptionsObjectpropCount > 0)
                {
                    body["advancedOptions"] = advancedOptionsObject;
                    bodypropCount++;
                }

                var dataObject = new JObject();
                var dataObjectpropCount = 0;
                if (dataObjectpropCount > 0)
                {
                    body["data"] = dataObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<string[]> JsonSchemaValidate()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/JsonSchemaValidate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var schemaObject = new JObject();
                var schemaObjectpropCount = 0;
                if (schemaObjectpropCount > 0)
                {
                    body["schema"] = schemaObject;
                    bodypropCount++;
                }

                var dataObject = new JObject();
                var dataObjectpropCount = 0;
                if (dataObjectpropCount > 0)
                {
                    body["data"] = dataObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<JToken[]> JsonToTable([WorkflowExpression] Func<string> bodypath = null, [WorkflowExpression] Func<bool> bodybalancedOutput = null, [WorkflowExpression] Func<string> bodyfilter = null, [WorkflowExpression] Func<string> bodyadvancedOptionscultureName = null, [WorkflowExpression] Func<string[]> bodyadvancedOptionsisBoolean = null)
        {
            SourceExpression.Validate(bodypath, nameof(bodypath), required: false);
            SourceExpression.Validate(bodybalancedOutput, nameof(bodybalancedOutput), required: false);
            SourceExpression.Validate(bodyfilter, nameof(bodyfilter), required: false);
            SourceExpression.Validate(bodyadvancedOptionscultureName, nameof(bodyadvancedOptionscultureName), required: false);
            SourceExpression.Validate(bodyadvancedOptionsisBoolean, nameof(bodyadvancedOptionsisBoolean), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/JsonToTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypath != null)
                {
                    body["path"] = SourceExpressionConverter.ConvertToken(bodypath);
                    bodypropCount++;
                }

                if (bodybalancedOutput != null)
                {
                    body["balancedOutput"] = SourceExpressionConverter.ConvertToken(bodybalancedOutput);
                    bodypropCount++;
                }

                if (bodyfilter != null)
                {
                    body["filter"] = SourceExpressionConverter.ConvertToken(bodyfilter);
                    bodypropCount++;
                }

                var sortOrderObject = new JObject();
                var sortOrderObjectpropCount = 0;
                if (sortOrderObjectpropCount > 0)
                {
                    body["sortOrder"] = sortOrderObject;
                    bodypropCount++;
                }

                var schemaObject = new JObject();
                var schemaObjectpropCount = 0;
                if (schemaObjectpropCount > 0)
                {
                    body["schema"] = schemaObject;
                    bodypropCount++;
                }

                var advancedOptionsObject = new JObject();
                var advancedOptionsObjectpropCount = 0;
                if (bodyadvancedOptionscultureName != null)
                {
                    advancedOptionsObject["cultureName"] = SourceExpressionConverter.ConvertToken(bodyadvancedOptionscultureName);
                    advancedOptionsObjectpropCount++;
                }

                if (bodyadvancedOptionsisBoolean != null)
                {
                    advancedOptionsObject["isBoolean"] = SourceExpressionConverter.ConvertToken(bodyadvancedOptionsisBoolean);
                    advancedOptionsObjectpropCount++;
                }

                if (advancedOptionsObjectpropCount > 0)
                {
                    body["advancedOptions"] = advancedOptionsObject;
                    bodypropCount++;
                }

                var dataObject = new JObject();
                var dataObjectpropCount = 0;
                if (dataObjectpropCount > 0)
                {
                    body["data"] = dataObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<string> JsonToText([WorkflowExpression] Func<bool> bodyheaderRow = null, [WorkflowExpression] Func<string> bodyrowSeparator = null, [WorkflowExpression] Func<string> bodyfilter = null, [WorkflowExpression] Func<string> bodyadvancedOptionscultureName = null, [WorkflowExpression] Func<string[]> bodyadvancedOptionsisBoolean = null, [WorkflowExpression] Func<JToken[]> bodydata = null)
        {
            SourceExpression.Validate(bodyheaderRow, nameof(bodyheaderRow), required: false);
            SourceExpression.Validate(bodyrowSeparator, nameof(bodyrowSeparator), required: false);
            SourceExpression.Validate(bodyfilter, nameof(bodyfilter), required: false);
            SourceExpression.Validate(bodyadvancedOptionscultureName, nameof(bodyadvancedOptionscultureName), required: false);
            SourceExpression.Validate(bodyadvancedOptionsisBoolean, nameof(bodyadvancedOptionsisBoolean), required: false);
            SourceExpression.Validate(bodydata, nameof(bodydata), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/JsonToText";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyheaderRow != null)
                {
                    body["headerRow"] = SourceExpressionConverter.ConvertToken(bodyheaderRow);
                    bodypropCount++;
                }

                if (bodyrowSeparator != null)
                {
                    body["rowSeparator"] = SourceExpressionConverter.ConvertToken(bodyrowSeparator);
                    bodypropCount++;
                }

                if (bodyfilter != null)
                {
                    body["filter"] = SourceExpressionConverter.ConvertToken(bodyfilter);
                    bodypropCount++;
                }

                var sortOrderObject = new JObject();
                var sortOrderObjectpropCount = 0;
                if (sortOrderObjectpropCount > 0)
                {
                    body["sortOrder"] = sortOrderObject;
                    bodypropCount++;
                }

                var schemaObject = new JObject();
                var schemaObjectpropCount = 0;
                if (schemaObjectpropCount > 0)
                {
                    body["schema"] = schemaObject;
                    bodypropCount++;
                }

                var advancedOptionsObject = new JObject();
                var advancedOptionsObjectpropCount = 0;
                if (bodyadvancedOptionscultureName != null)
                {
                    advancedOptionsObject["cultureName"] = SourceExpressionConverter.ConvertToken(bodyadvancedOptionscultureName);
                    advancedOptionsObjectpropCount++;
                }

                if (bodyadvancedOptionsisBoolean != null)
                {
                    advancedOptionsObject["isBoolean"] = SourceExpressionConverter.ConvertToken(bodyadvancedOptionsisBoolean);
                    advancedOptionsObjectpropCount++;
                }

                if (advancedOptionsObjectpropCount > 0)
                {
                    body["advancedOptions"] = advancedOptionsObject;
                    bodypropCount++;
                }

                if (bodydata != null)
                {
                    body["data"] = SourceExpressionConverter.ConvertToken(bodydata);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<string> JsonToCsv([WorkflowExpression] Func<bool> bodyheaderRow = null, [WorkflowExpression] Func<string> bodyrowSeparator = null, [WorkflowExpression] Func<string> bodyescapeCharacter = null, [WorkflowExpression] Func<string> bodyfilter = null, [WorkflowExpression] Func<string> bodyadvancedOptionscultureName = null, [WorkflowExpression] Func<string[]> bodyadvancedOptionsisBoolean = null, [WorkflowExpression] Func<JToken[]> bodydata = null)
        {
            SourceExpression.Validate(bodyheaderRow, nameof(bodyheaderRow), required: false);
            SourceExpression.Validate(bodyrowSeparator, nameof(bodyrowSeparator), required: false);
            SourceExpression.Validate(bodyescapeCharacter, nameof(bodyescapeCharacter), required: false);
            SourceExpression.Validate(bodyfilter, nameof(bodyfilter), required: false);
            SourceExpression.Validate(bodyadvancedOptionscultureName, nameof(bodyadvancedOptionscultureName), required: false);
            SourceExpression.Validate(bodyadvancedOptionsisBoolean, nameof(bodyadvancedOptionsisBoolean), required: false);
            SourceExpression.Validate(bodydata, nameof(bodydata), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/JsonToCsv";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyheaderRow != null)
                {
                    body["headerRow"] = SourceExpressionConverter.ConvertToken(bodyheaderRow);
                    bodypropCount++;
                }

                if (bodyrowSeparator != null)
                {
                    body["rowSeparator"] = SourceExpressionConverter.ConvertToken(bodyrowSeparator);
                    bodypropCount++;
                }

                if (bodyescapeCharacter != null)
                {
                    body["escapeCharacter"] = SourceExpressionConverter.ConvertToken(bodyescapeCharacter);
                    bodypropCount++;
                }

                if (bodyfilter != null)
                {
                    body["filter"] = SourceExpressionConverter.ConvertToken(bodyfilter);
                    bodypropCount++;
                }

                var sortOrderObject = new JObject();
                var sortOrderObjectpropCount = 0;
                if (sortOrderObjectpropCount > 0)
                {
                    body["sortOrder"] = sortOrderObject;
                    bodypropCount++;
                }

                var schemaObject = new JObject();
                var schemaObjectpropCount = 0;
                if (schemaObjectpropCount > 0)
                {
                    body["schema"] = schemaObject;
                    bodypropCount++;
                }

                var advancedOptionsObject = new JObject();
                var advancedOptionsObjectpropCount = 0;
                if (bodyadvancedOptionscultureName != null)
                {
                    advancedOptionsObject["cultureName"] = SourceExpressionConverter.ConvertToken(bodyadvancedOptionscultureName);
                    advancedOptionsObjectpropCount++;
                }

                if (bodyadvancedOptionsisBoolean != null)
                {
                    advancedOptionsObject["isBoolean"] = SourceExpressionConverter.ConvertToken(bodyadvancedOptionsisBoolean);
                    advancedOptionsObjectpropCount++;
                }

                if (advancedOptionsObjectpropCount > 0)
                {
                    body["advancedOptions"] = advancedOptionsObject;
                    bodypropCount++;
                }

                if (bodydata != null)
                {
                    body["data"] = SourceExpressionConverter.ConvertToken(bodydata);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IWorkflowAction JsonPropertiesToNameValuePairArray([WorkflowExpression] Func<object> bodydata)
        {
            SourceExpression.Validate(bodydata, nameof(bodydata), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/JsonPropertiesToNameValuePairArray";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["data"] = SourceExpressionConverter.ConvertToken(bodydata);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<LevenshteinDistanceResponse> LevenshteinDistance([WorkflowExpression] Func<string> bodybaseValue, [WorkflowExpression] Func<string[]> bodycomparisonValues, [WorkflowExpression] Func<double> bodysettingsratioThreshold = null, [WorkflowExpression] Func<bodysettingsapplyRatioThresholdToInput> bodysettingsapplyRatioThresholdTo = null, [WorkflowExpression] Func<bodysettingsratioSelectionTypeInput> bodysettingsratioSelectionType = null, [WorkflowExpression] Func<bodysettingstokenSortTypeInput> bodysettingstokenSortType = null, [WorkflowExpression] Func<bool> bodysettingscaseSensitive = null, [WorkflowExpression] Func<bool> bodysettingsremoveWhitespace = null, [WorkflowExpression] Func<bool> bodysettingsremoveSpecialCharacters = null)
        {
            SourceExpression.Validate(bodybaseValue, nameof(bodybaseValue), required: true);
            SourceExpression.Validate(bodycomparisonValues, nameof(bodycomparisonValues), required: true);
            SourceExpression.Validate(bodysettingsratioThreshold, nameof(bodysettingsratioThreshold), required: false);
            SourceExpression.Validate(bodysettingsapplyRatioThresholdTo, nameof(bodysettingsapplyRatioThresholdTo), required: false);
            SourceExpression.Validate(bodysettingsratioSelectionType, nameof(bodysettingsratioSelectionType), required: false);
            SourceExpression.Validate(bodysettingstokenSortType, nameof(bodysettingstokenSortType), required: false);
            SourceExpression.Validate(bodysettingscaseSensitive, nameof(bodysettingscaseSensitive), required: false);
            SourceExpression.Validate(bodysettingsremoveWhitespace, nameof(bodysettingsremoveWhitespace), required: false);
            SourceExpression.Validate(bodysettingsremoveSpecialCharacters, nameof(bodysettingsremoveSpecialCharacters), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/LevenshteinDistance";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["baseValue"] = SourceExpressionConverter.ConvertToken(bodybaseValue);
                bodypropCount++;
                body["comparisonValues"] = SourceExpressionConverter.ConvertToken(bodycomparisonValues);
                var settingsObject = new JObject();
                var settingsObjectpropCount = 0;
                if (bodysettingsratioThreshold != null)
                {
                    settingsObject["ratioThreshold"] = SourceExpressionConverter.ConvertToken(bodysettingsratioThreshold);
                    settingsObjectpropCount++;
                }

                if (bodysettingsapplyRatioThresholdTo != null)
                {
                    settingsObject["applyRatioThresholdTo"] = SourceExpressionConverter.Convert(bodysettingsapplyRatioThresholdTo);
                    settingsObjectpropCount++;
                }

                if (bodysettingsratioSelectionType != null)
                {
                    settingsObject["ratioSelectionType"] = SourceExpressionConverter.Convert(bodysettingsratioSelectionType);
                    settingsObjectpropCount++;
                }

                if (bodysettingstokenSortType != null)
                {
                    settingsObject["tokenSortType"] = SourceExpressionConverter.Convert(bodysettingstokenSortType);
                    settingsObjectpropCount++;
                }

                if (bodysettingscaseSensitive != null)
                {
                    settingsObject["caseSensitive"] = SourceExpressionConverter.ConvertToken(bodysettingscaseSensitive);
                    settingsObjectpropCount++;
                }

                if (bodysettingsremoveWhitespace != null)
                {
                    settingsObject["removeWhitespace"] = SourceExpressionConverter.ConvertToken(bodysettingsremoveWhitespace);
                    settingsObjectpropCount++;
                }

                if (bodysettingsremoveSpecialCharacters != null)
                {
                    settingsObject["removeSpecialCharacters"] = SourceExpressionConverter.ConvertToken(bodysettingsremoveSpecialCharacters);
                    settingsObjectpropCount++;
                }

                if (settingsObjectpropCount > 0)
                {
                    body["Settings"] = settingsObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<LevenshteinDistanceResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<JToken[]> ParquetToJson([WorkflowExpression] Func<string> bodydata, [WorkflowExpression] Func<bool> bodyvalidateOnly = null, [WorkflowExpression] Func<int> bodyskip = null, [WorkflowExpression] Func<int> bodytake = null, [WorkflowExpression] Func<string> bodyfilter = null, [WorkflowExpression] Func<string> bodyadvancedOptionscultureName = null, [WorkflowExpression] Func<string[]> bodyadvancedOptionsisBoolean = null)
        {
            SourceExpression.Validate(bodydata, nameof(bodydata), required: true);
            SourceExpression.Validate(bodyvalidateOnly, nameof(bodyvalidateOnly), required: false);
            SourceExpression.Validate(bodyskip, nameof(bodyskip), required: false);
            SourceExpression.Validate(bodytake, nameof(bodytake), required: false);
            SourceExpression.Validate(bodyfilter, nameof(bodyfilter), required: false);
            SourceExpression.Validate(bodyadvancedOptionscultureName, nameof(bodyadvancedOptionscultureName), required: false);
            SourceExpression.Validate(bodyadvancedOptionsisBoolean, nameof(bodyadvancedOptionsisBoolean), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/ParquetToJson";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyvalidateOnly != null)
                {
                    body["validateOnly"] = SourceExpressionConverter.ConvertToken(bodyvalidateOnly);
                    bodypropCount++;
                }

                if (bodyskip != null)
                {
                    body["skip"] = SourceExpressionConverter.ConvertToken(bodyskip);
                    bodypropCount++;
                }

                if (bodytake != null)
                {
                    body["take"] = SourceExpressionConverter.ConvertToken(bodytake);
                    bodypropCount++;
                }

                if (bodyfilter != null)
                {
                    body["filter"] = SourceExpressionConverter.ConvertToken(bodyfilter);
                    bodypropCount++;
                }

                var sortOrderObject = new JObject();
                var sortOrderObjectpropCount = 0;
                if (sortOrderObjectpropCount > 0)
                {
                    body["sortOrder"] = sortOrderObject;
                    bodypropCount++;
                }

                var schemaObject = new JObject();
                var schemaObjectpropCount = 0;
                if (schemaObjectpropCount > 0)
                {
                    body["schema"] = schemaObject;
                    bodypropCount++;
                }

                var advancedOptionsObject = new JObject();
                var advancedOptionsObjectpropCount = 0;
                if (bodyadvancedOptionscultureName != null)
                {
                    advancedOptionsObject["cultureName"] = SourceExpressionConverter.ConvertToken(bodyadvancedOptionscultureName);
                    advancedOptionsObjectpropCount++;
                }

                if (bodyadvancedOptionsisBoolean != null)
                {
                    advancedOptionsObject["isBoolean"] = SourceExpressionConverter.ConvertToken(bodyadvancedOptionsisBoolean);
                    advancedOptionsObjectpropCount++;
                }

                if (advancedOptionsObjectpropCount > 0)
                {
                    body["advancedOptions"] = advancedOptionsObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["data"] = SourceExpressionConverter.ConvertToken(bodydata);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<string[]> RegexMatches([WorkflowExpression] Func<string> bodypattern, [WorkflowExpression] Func<string> bodydata, [WorkflowExpression] Func<string> bodyfilter = null, [WorkflowExpression] Func<string> bodyadvancedOptionscultureName = null, [WorkflowExpression] Func<string[]> bodyadvancedOptionsisBoolean = null)
        {
            SourceExpression.Validate(bodypattern, nameof(bodypattern), required: true);
            SourceExpression.Validate(bodydata, nameof(bodydata), required: true);
            SourceExpression.Validate(bodyfilter, nameof(bodyfilter), required: false);
            SourceExpression.Validate(bodyadvancedOptionscultureName, nameof(bodyadvancedOptionscultureName), required: false);
            SourceExpression.Validate(bodyadvancedOptionsisBoolean, nameof(bodyadvancedOptionsisBoolean), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/RegexMatches";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["pattern"] = SourceExpressionConverter.ConvertToken(bodypattern);
                if (bodyfilter != null)
                {
                    body["filter"] = SourceExpressionConverter.ConvertToken(bodyfilter);
                    bodypropCount++;
                }

                var sortOrderObject = new JObject();
                var sortOrderObjectpropCount = 0;
                if (sortOrderObjectpropCount > 0)
                {
                    body["sortOrder"] = sortOrderObject;
                    bodypropCount++;
                }

                var schemaObject = new JObject();
                var schemaObjectpropCount = 0;
                if (schemaObjectpropCount > 0)
                {
                    body["schema"] = schemaObject;
                    bodypropCount++;
                }

                var advancedOptionsObject = new JObject();
                var advancedOptionsObjectpropCount = 0;
                if (bodyadvancedOptionscultureName != null)
                {
                    advancedOptionsObject["cultureName"] = SourceExpressionConverter.ConvertToken(bodyadvancedOptionscultureName);
                    advancedOptionsObjectpropCount++;
                }

                if (bodyadvancedOptionsisBoolean != null)
                {
                    advancedOptionsObject["isBoolean"] = SourceExpressionConverter.ConvertToken(bodyadvancedOptionsisBoolean);
                    advancedOptionsObjectpropCount++;
                }

                if (advancedOptionsObjectpropCount > 0)
                {
                    body["advancedOptions"] = advancedOptionsObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["data"] = SourceExpressionConverter.ConvertToken(bodydata);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<string> SimpleConcatenate([WorkflowExpression] Func<string[]> bodydata, [WorkflowExpression] Func<string> bodyseparator = null, [WorkflowExpression] Func<bool> bodyignoreEmpty = null, [WorkflowExpression] Func<string> bodyfilter = null, [WorkflowExpression] Func<bodysortOrderInput> bodysortOrder = null, [WorkflowExpression] Func<string> bodyadvancedOptionscultureName = null, [WorkflowExpression] Func<string[]> bodyadvancedOptionsisBoolean = null)
        {
            SourceExpression.Validate(bodydata, nameof(bodydata), required: true);
            SourceExpression.Validate(bodyseparator, nameof(bodyseparator), required: false);
            SourceExpression.Validate(bodyignoreEmpty, nameof(bodyignoreEmpty), required: false);
            SourceExpression.Validate(bodyfilter, nameof(bodyfilter), required: false);
            SourceExpression.Validate(bodysortOrder, nameof(bodysortOrder), required: false);
            SourceExpression.Validate(bodyadvancedOptionscultureName, nameof(bodyadvancedOptionscultureName), required: false);
            SourceExpression.Validate(bodyadvancedOptionsisBoolean, nameof(bodyadvancedOptionsisBoolean), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SimpleConcatenate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyseparator != null)
                {
                    body["separator"] = SourceExpressionConverter.ConvertToken(bodyseparator);
                    bodypropCount++;
                }

                if (bodyignoreEmpty != null)
                {
                    body["ignoreEmpty"] = SourceExpressionConverter.ConvertToken(bodyignoreEmpty);
                    bodypropCount++;
                }

                if (bodyfilter != null)
                {
                    body["filter"] = SourceExpressionConverter.ConvertToken(bodyfilter);
                    bodypropCount++;
                }

                if (bodysortOrder != null)
                {
                    body["sortOrder"] = SourceExpressionConverter.Convert(bodysortOrder);
                    bodypropCount++;
                }

                var schemaObject = new JObject();
                var schemaObjectpropCount = 0;
                if (schemaObjectpropCount > 0)
                {
                    body["schema"] = schemaObject;
                    bodypropCount++;
                }

                var advancedOptionsObject = new JObject();
                var advancedOptionsObjectpropCount = 0;
                if (bodyadvancedOptionscultureName != null)
                {
                    advancedOptionsObject["cultureName"] = SourceExpressionConverter.ConvertToken(bodyadvancedOptionscultureName);
                    advancedOptionsObjectpropCount++;
                }

                if (bodyadvancedOptionsisBoolean != null)
                {
                    advancedOptionsObject["isBoolean"] = SourceExpressionConverter.ConvertToken(bodyadvancedOptionsisBoolean);
                    advancedOptionsObjectpropCount++;
                }

                if (advancedOptionsObjectpropCount > 0)
                {
                    body["advancedOptions"] = advancedOptionsObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["data"] = SourceExpressionConverter.ConvertToken(bodydata);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IWorkflowAction SimpleDistinct([WorkflowExpression] Func<string> bodyfield, [WorkflowExpression] Func<string> bodyfilter = null, [WorkflowExpression] Func<bodysortOrderInput> bodysortOrder = null, [WorkflowExpression] Func<string> bodyadvancedOptionscultureName = null, [WorkflowExpression] Func<string[]> bodyadvancedOptionsisBoolean = null, [WorkflowExpression] Func<JToken[]> bodydata = null)
        {
            SourceExpression.Validate(bodyfield, nameof(bodyfield), required: true);
            SourceExpression.Validate(bodyfilter, nameof(bodyfilter), required: false);
            SourceExpression.Validate(bodysortOrder, nameof(bodysortOrder), required: false);
            SourceExpression.Validate(bodyadvancedOptionscultureName, nameof(bodyadvancedOptionscultureName), required: false);
            SourceExpression.Validate(bodyadvancedOptionsisBoolean, nameof(bodyadvancedOptionsisBoolean), required: false);
            SourceExpression.Validate(bodydata, nameof(bodydata), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SimpleDistinct";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["field"] = SourceExpressionConverter.ConvertToken(bodyfield);
                if (bodyfilter != null)
                {
                    body["filter"] = SourceExpressionConverter.ConvertToken(bodyfilter);
                    bodypropCount++;
                }

                if (bodysortOrder != null)
                {
                    body["sortOrder"] = SourceExpressionConverter.Convert(bodysortOrder);
                    bodypropCount++;
                }

                var schemaObject = new JObject();
                var schemaObjectpropCount = 0;
                if (schemaObjectpropCount > 0)
                {
                    body["schema"] = schemaObject;
                    bodypropCount++;
                }

                var advancedOptionsObject = new JObject();
                var advancedOptionsObjectpropCount = 0;
                if (bodyadvancedOptionscultureName != null)
                {
                    advancedOptionsObject["cultureName"] = SourceExpressionConverter.ConvertToken(bodyadvancedOptionscultureName);
                    advancedOptionsObjectpropCount++;
                }

                if (bodyadvancedOptionsisBoolean != null)
                {
                    advancedOptionsObject["isBoolean"] = SourceExpressionConverter.ConvertToken(bodyadvancedOptionsisBoolean);
                    advancedOptionsObjectpropCount++;
                }

                if (advancedOptionsObjectpropCount > 0)
                {
                    body["advancedOptions"] = advancedOptionsObject;
                    bodypropCount++;
                }

                if (bodydata != null)
                {
                    body["data"] = SourceExpressionConverter.ConvertToken(bodydata);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<JToken[]> SortObjectArray([WorkflowExpression] Func<JToken[]> bodydata = null)
        {
            SourceExpression.Validate(bodydata, nameof(bodydata), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SortObjectArray";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var sortOrderObject = new JObject();
                var sortOrderObjectpropCount = 0;
                if (sortOrderObjectpropCount > 0)
                {
                    body["sortOrder"] = sortOrderObject;
                    bodypropCount++;
                }

                if (bodydata != null)
                {
                    body["data"] = SourceExpressionConverter.ConvertToken(bodydata);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<JToken[]> Split([WorkflowExpression] Func<JToken[]> bodysplits, [WorkflowExpression] Func<string> bodyfilter = null, [WorkflowExpression] Func<string> bodyadvancedOptionscultureName = null, [WorkflowExpression] Func<string[]> bodyadvancedOptionsisBoolean = null, [WorkflowExpression] Func<JToken[]> bodydata = null)
        {
            SourceExpression.Validate(bodysplits, nameof(bodysplits), required: true);
            SourceExpression.Validate(bodyfilter, nameof(bodyfilter), required: false);
            SourceExpression.Validate(bodyadvancedOptionscultureName, nameof(bodyadvancedOptionscultureName), required: false);
            SourceExpression.Validate(bodyadvancedOptionsisBoolean, nameof(bodyadvancedOptionsisBoolean), required: false);
            SourceExpression.Validate(bodydata, nameof(bodydata), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Split";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["splits"] = SourceExpressionConverter.ConvertToken(bodysplits);
                if (bodyfilter != null)
                {
                    body["filter"] = SourceExpressionConverter.ConvertToken(bodyfilter);
                    bodypropCount++;
                }

                var sortOrderObject = new JObject();
                var sortOrderObjectpropCount = 0;
                if (sortOrderObjectpropCount > 0)
                {
                    body["sortOrder"] = sortOrderObject;
                    bodypropCount++;
                }

                var schemaObject = new JObject();
                var schemaObjectpropCount = 0;
                if (schemaObjectpropCount > 0)
                {
                    body["schema"] = schemaObject;
                    bodypropCount++;
                }

                var advancedOptionsObject = new JObject();
                var advancedOptionsObjectpropCount = 0;
                if (bodyadvancedOptionscultureName != null)
                {
                    advancedOptionsObject["cultureName"] = SourceExpressionConverter.ConvertToken(bodyadvancedOptionscultureName);
                    advancedOptionsObjectpropCount++;
                }

                if (bodyadvancedOptionsisBoolean != null)
                {
                    advancedOptionsObject["isBoolean"] = SourceExpressionConverter.ConvertToken(bodyadvancedOptionsisBoolean);
                    advancedOptionsObjectpropCount++;
                }

                if (advancedOptionsObjectpropCount > 0)
                {
                    body["advancedOptions"] = advancedOptionsObject;
                    bodypropCount++;
                }

                if (bodydata != null)
                {
                    body["data"] = SourceExpressionConverter.ConvertToken(bodydata);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<JToken[]> TextToJson([WorkflowExpression] Func<string> bodydata, [WorkflowExpression] Func<bool> bodyheaderRow = null, [WorkflowExpression] Func<string> bodyrowSeparator = null, [WorkflowExpression] Func<string> bodydelimiter = null, [WorkflowExpression] Func<bodyencodingInput> bodyencoding = null, [WorkflowExpression] Func<string> bodyfilter = null, [WorkflowExpression] Func<string> bodyadvancedOptionscultureName = null, [WorkflowExpression] Func<string[]> bodyadvancedOptionsisBoolean = null)
        {
            SourceExpression.Validate(bodydata, nameof(bodydata), required: true);
            SourceExpression.Validate(bodyheaderRow, nameof(bodyheaderRow), required: false);
            SourceExpression.Validate(bodyrowSeparator, nameof(bodyrowSeparator), required: false);
            SourceExpression.Validate(bodydelimiter, nameof(bodydelimiter), required: false);
            SourceExpression.Validate(bodyencoding, nameof(bodyencoding), required: false);
            SourceExpression.Validate(bodyfilter, nameof(bodyfilter), required: false);
            SourceExpression.Validate(bodyadvancedOptionscultureName, nameof(bodyadvancedOptionscultureName), required: false);
            SourceExpression.Validate(bodyadvancedOptionsisBoolean, nameof(bodyadvancedOptionsisBoolean), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/TextToJson";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyheaderRow != null)
                {
                    body["headerRow"] = SourceExpressionConverter.ConvertToken(bodyheaderRow);
                    bodypropCount++;
                }

                if (bodyrowSeparator != null)
                {
                    body["rowSeparator"] = SourceExpressionConverter.ConvertToken(bodyrowSeparator);
                    bodypropCount++;
                }

                if (bodydelimiter != null)
                {
                    body["delimiter"] = SourceExpressionConverter.ConvertToken(bodydelimiter);
                    bodypropCount++;
                }

                if (bodyencoding != null)
                {
                    body["encoding"] = SourceExpressionConverter.Convert(bodyencoding);
                    bodypropCount++;
                }

                if (bodyfilter != null)
                {
                    body["filter"] = SourceExpressionConverter.ConvertToken(bodyfilter);
                    bodypropCount++;
                }

                var sortOrderObject = new JObject();
                var sortOrderObjectpropCount = 0;
                if (sortOrderObjectpropCount > 0)
                {
                    body["sortOrder"] = sortOrderObject;
                    bodypropCount++;
                }

                var schemaObject = new JObject();
                var schemaObjectpropCount = 0;
                if (schemaObjectpropCount > 0)
                {
                    body["schema"] = schemaObject;
                    bodypropCount++;
                }

                var advancedOptionsObject = new JObject();
                var advancedOptionsObjectpropCount = 0;
                if (bodyadvancedOptionscultureName != null)
                {
                    advancedOptionsObject["cultureName"] = SourceExpressionConverter.ConvertToken(bodyadvancedOptionscultureName);
                    advancedOptionsObjectpropCount++;
                }

                if (bodyadvancedOptionsisBoolean != null)
                {
                    advancedOptionsObject["isBoolean"] = SourceExpressionConverter.ConvertToken(bodyadvancedOptionsisBoolean);
                    advancedOptionsObjectpropCount++;
                }

                if (advancedOptionsObjectpropCount > 0)
                {
                    body["advancedOptions"] = advancedOptionsObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["data"] = SourceExpressionConverter.ConvertToken(bodydata);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<JToken[]> Transform([WorkflowExpression] Func<bool> bodypreserveAllProperties = null, [WorkflowExpression] Func<string> bodyfilter = null, [WorkflowExpression] Func<string> bodyadvancedOptionscultureName = null, [WorkflowExpression] Func<string[]> bodyadvancedOptionsisBoolean = null, [WorkflowExpression] Func<JToken[]> bodydata = null)
        {
            SourceExpression.Validate(bodypreserveAllProperties, nameof(bodypreserveAllProperties), required: false);
            SourceExpression.Validate(bodyfilter, nameof(bodyfilter), required: false);
            SourceExpression.Validate(bodyadvancedOptionscultureName, nameof(bodyadvancedOptionscultureName), required: false);
            SourceExpression.Validate(bodyadvancedOptionsisBoolean, nameof(bodyadvancedOptionsisBoolean), required: false);
            SourceExpression.Validate(bodydata, nameof(bodydata), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Transform";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var transformationsObject = new JObject();
                var transformationsObjectpropCount = 0;
                if (transformationsObjectpropCount > 0)
                {
                    body["transformations"] = transformationsObject;
                    bodypropCount++;
                }

                if (bodypreserveAllProperties != null)
                {
                    body["preserveAllProperties"] = SourceExpressionConverter.ConvertToken(bodypreserveAllProperties);
                    bodypropCount++;
                }

                if (bodyfilter != null)
                {
                    body["filter"] = SourceExpressionConverter.ConvertToken(bodyfilter);
                    bodypropCount++;
                }

                var sortOrderObject = new JObject();
                var sortOrderObjectpropCount = 0;
                if (sortOrderObjectpropCount > 0)
                {
                    body["sortOrder"] = sortOrderObject;
                    bodypropCount++;
                }

                var schemaObject = new JObject();
                var schemaObjectpropCount = 0;
                if (schemaObjectpropCount > 0)
                {
                    body["schema"] = schemaObject;
                    bodypropCount++;
                }

                var advancedOptionsObject = new JObject();
                var advancedOptionsObjectpropCount = 0;
                if (bodyadvancedOptionscultureName != null)
                {
                    advancedOptionsObject["cultureName"] = SourceExpressionConverter.ConvertToken(bodyadvancedOptionscultureName);
                    advancedOptionsObjectpropCount++;
                }

                if (bodyadvancedOptionsisBoolean != null)
                {
                    advancedOptionsObject["isBoolean"] = SourceExpressionConverter.ConvertToken(bodyadvancedOptionsisBoolean);
                    advancedOptionsObjectpropCount++;
                }

                if (advancedOptionsObjectpropCount > 0)
                {
                    body["advancedOptions"] = advancedOptionsObject;
                    bodypropCount++;
                }

                if (bodydata != null)
                {
                    body["data"] = SourceExpressionConverter.ConvertToken(bodydata);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<JToken[]> XmlToJson([WorkflowExpression] Func<string> bodydata, [WorkflowExpression] Func<string> bodyprimaryLoopAtElement = null, [WorkflowExpression] Func<bodysubLoopAtElementsInputItem[]> bodysubLoopAtElements = null)
        {
            SourceExpression.Validate(bodydata, nameof(bodydata), required: true);
            SourceExpression.Validate(bodyprimaryLoopAtElement, nameof(bodyprimaryLoopAtElement), required: false);
            SourceExpression.Validate(bodysubLoopAtElements, nameof(bodysubLoopAtElements), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/XmlToJson";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyprimaryLoopAtElement != null)
                {
                    body["primaryLoopAtElement"] = SourceExpressionConverter.ConvertToken(bodyprimaryLoopAtElement);
                    bodypropCount++;
                }

                var mapObject = new JObject();
                var mapObjectpropCount = 0;
                if (mapObjectpropCount > 0)
                {
                    body["map"] = mapObject;
                    bodypropCount++;
                }

                if (bodysubLoopAtElements != null)
                {
                    body["subLoopAtElements"] = SourceExpressionConverter.ConvertToken(bodysubLoopAtElements);
                    bodypropCount++;
                }

                bodypropCount++;
                body["data"] = SourceExpressionConverter.ConvertToken(bodydata);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<ZipArchiveDecompressResponseItem[]> ZipArchiveDecompress([WorkflowExpression] Func<string> bodydata, [WorkflowExpression] Func<bool> bodygetFileContents, [WorkflowExpression] Func<string> bodyfilter = null)
        {
            SourceExpression.Validate(bodydata, nameof(bodydata), required: true);
            SourceExpression.Validate(bodygetFileContents, nameof(bodygetFileContents), required: true);
            SourceExpression.Validate(bodyfilter, nameof(bodyfilter), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/ZipArchiveDecompress";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["data"] = SourceExpressionConverter.ConvertToken(bodydata);
                bodypropCount++;
                body["getFileContents"] = SourceExpressionConverter.ConvertToken(bodygetFileContents);
                if (bodyfilter != null)
                {
                    body["filter"] = SourceExpressionConverter.ConvertToken(bodyfilter);
                    bodypropCount++;
                }

                var sortOrderObject = new JObject();
                var sortOrderObjectpropCount = 0;
                if (sortOrderObjectpropCount > 0)
                {
                    body["sortOrder"] = sortOrderObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ZipArchiveDecompressResponseItem[]>(BuildSourceInput);
        }
    }

    public class AdvanceddataoperatioTriggers([ConnectionName] string connectionId)
    {
    }

    public enum bodyaggregationTypeInput
    {
        AVG,
        SUM,
        COUNT,
        MAX,
        MIN
    }

    public enum bodyencodingInput
    {
        ASCII,
        UTF8,
        UTF16LittleEndian,
        UTF16BigEndian,
        [EnumMember(Value = "ISO-8859-1")]
        ISO88591
    }

    public enum bodyjoinTypeInput
    {
        Left,
        Inner
    }

    public class LevenshteinDistanceResponse
    {
        public LevenshteinDistanceResponseBaseValueType BaseValue { get; set; }
        public LevenshteinDistanceResponseComparisonSettingsType ComparisonSettings { get; set; }
        public LevenshteinDistanceResponseComparisonsTypeItem[] Comparisons { get; set; }
    }

    public class LevenshteinDistanceResponseBaseValueType
    {
        public string Supplied { get; set; }
        public string Actual { get; set; }
    }

    public class LevenshteinDistanceResponseComparisonSettingsType
    {
        public double RatioThreshold { get; set; }
        public string ApplyRatioThresholdTo { get; set; }
        public bool CaseSensitive { get; set; }
        public bool RemoveWhitespace { get; set; }
        public bool RemoveSpecialCharacters { get; set; }
        public string RatioSelectionType { get; set; }
        public string TokenSortType { get; set; }
    }

    public class LevenshteinDistanceResponseComparisonsTypeItem
    {
        public LevenshteinDistanceResponseComparisonsTypeItemComparisonType Comparison { get; set; }
        public LevenshteinDistanceResponseComparisonsTypeItemResultsType Results { get; set; }
    }

    public class LevenshteinDistanceResponseComparisonsTypeItemComparisonType
    {
        public string Supplied { get; set; }
        public string Actual { get; set; }
    }

    public class LevenshteinDistanceResponseComparisonsTypeItemResultsType
    {
        public double Ratio { get; set; }
        public double PartialRatio { get; set; }
        public double SortedRatio { get; set; }
        public double SortedPartialRatio { get; set; }
        public double MaxRatio { get; set; }
        public double AvgRatio { get; set; }
    }

    public enum bodysettingsapplyRatioThresholdToInput
    {
        Max,
        Avg
    }

    public enum bodysettingsratioSelectionTypeInput
    {
        All,
        Standard,
        Partial
    }

    public enum bodysettingstokenSortTypeInput
    {
        All,
        [EnumMember(Value = "Not Sorted")]
        NotSorted,
        Sorted
    }

    public enum bodysortOrderInput
    {
        ASC,
        DESC
    }

    public class bodysubLoopAtElementsInputItem
    {
        [JsonProperty("mapName")]
        public string MapName { get; set; }

        [JsonProperty("xPathQuery")]
        public string XPathQuery { get; set; }

        [JsonProperty("map")]
        public JToken Map { get; set; }
    }

    public class ZipArchiveDecompressResponseItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("compressedSize")]
        public double CompressedSize { get; set; }

        [JsonProperty("uncompressedSize")]
        public double UncompressedSize { get; set; }

        [JsonProperty("fileContent")]
        public string FileContent { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Advanceddataoperatio;

    public partial class WorkflowManagedActions
    {
        public AdvanceddataoperatioActions Advanceddataoperatio(string connectionId) => new AdvanceddataoperatioActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AdvanceddataoperatioTriggers Advanceddataoperatio(string connectionId) => new AdvanceddataoperatioTriggers(connectionId);
    }
}