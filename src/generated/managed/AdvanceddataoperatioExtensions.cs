//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Advanceddataoperatio
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AdvanceddataoperatioActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        [WorkflowExpressionFactory(nameof(__BuildAggregate))]
        public IBodyWorkflowAction<JToken[]> Aggregate([WorkflowExpression] Func<bodyaggregationTypeInput> bodyaggregationType, [WorkflowExpression] Func<string[]> bodyaggregateBy, [WorkflowExpression] Func<string[]> bodyaggregateOn, [WorkflowExpression] Func<string> bodyfilter = null, [WorkflowExpression] Func<string> bodyadvancedOptionscultureName = null, [WorkflowExpression] Func<string[]> bodyadvancedOptionsisBoolean = null, [WorkflowExpression] Func<JToken[]> bodydata = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken[]> __BuildAggregate(WorkflowValue<bodyaggregationTypeInput> bodyaggregationType, WorkflowValue<string[]> bodyaggregateBy, WorkflowValue<string[]> bodyaggregateOn, WorkflowValue<string> bodyfilter = null, WorkflowValue<string> bodyadvancedOptionscultureName = null, WorkflowValue<string[]> bodyadvancedOptionsisBoolean = null, WorkflowValue<JToken[]> bodydata = null)
        {
            WorkflowValue.Validate(bodyaggregationType, nameof(bodyaggregationType), required: true);
            WorkflowValue.Validate(bodyaggregateBy, nameof(bodyaggregateBy), required: true);
            WorkflowValue.Validate(bodyaggregateOn, nameof(bodyaggregateOn), required: true);
            WorkflowValue.Validate(bodyfilter, nameof(bodyfilter), required: false);
            WorkflowValue.Validate(bodyadvancedOptionscultureName, nameof(bodyadvancedOptionscultureName), required: false);
            WorkflowValue.Validate(bodyadvancedOptionsisBoolean, nameof(bodyadvancedOptionsisBoolean), required: false);
            WorkflowValue.Validate(bodydata, nameof(bodydata), required: false);
            return new DeferredBodyAction<JToken[]>(() =>
            {
                var apiCallPath = "/Aggregate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["aggregationType"] = ExpressionConverter.ConvertO(bodyaggregationType);
                bodypropCount++;
                body["aggregateBy"] = ExpressionConverter.ConvertO(bodyaggregateBy);
                bodypropCount++;
                body["aggregateOn"] = ExpressionConverter.ConvertO(bodyaggregateOn);
                if (bodyfilter != null)
                {
                    body["filter"] = ExpressionConverter.ConvertO(bodyfilter);
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
                    advancedOptionsObject["cultureName"] = ExpressionConverter.ConvertO(bodyadvancedOptionscultureName);
                    advancedOptionsObjectpropCount++;
                }

                if (bodyadvancedOptionsisBoolean != null)
                {
                    advancedOptionsObject["isBoolean"] = ExpressionConverter.ConvertO(bodyadvancedOptionsisBoolean);
                    advancedOptionsObjectpropCount++;
                }

                if (advancedOptionsObjectpropCount > 0)
                {
                    body["advancedOptions"] = advancedOptionsObject;
                    bodypropCount++;
                }

                if (bodydata != null)
                {
                    body["data"] = ExpressionConverter.ConvertO(bodydata);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        [WorkflowExpressionFactory(nameof(__BuildCartesianJoin))]
        public IBodyWorkflowAction<JToken[]> CartesianJoin([WorkflowExpression] Func<string> bodyfilter = null, [WorkflowExpression] Func<string> bodyadvancedOptionscultureName = null, [WorkflowExpression] Func<string[]> bodyadvancedOptionsisBoolean = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken[]> __BuildCartesianJoin(WorkflowValue<string> bodyfilter = null, WorkflowValue<string> bodyadvancedOptionscultureName = null, WorkflowValue<string[]> bodyadvancedOptionsisBoolean = null)
        {
            WorkflowValue.Validate(bodyfilter, nameof(bodyfilter), required: false);
            WorkflowValue.Validate(bodyadvancedOptionscultureName, nameof(bodyadvancedOptionscultureName), required: false);
            WorkflowValue.Validate(bodyadvancedOptionsisBoolean, nameof(bodyadvancedOptionsisBoolean), required: false);
            return new DeferredBodyAction<JToken[]>(() =>
            {
                var apiCallPath = "/CartesianJoin";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfilter != null)
                {
                    body["filter"] = ExpressionConverter.ConvertO(bodyfilter);
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
                    advancedOptionsObject["cultureName"] = ExpressionConverter.ConvertO(bodyadvancedOptionscultureName);
                    advancedOptionsObjectpropCount++;
                }

                if (bodyadvancedOptionsisBoolean != null)
                {
                    advancedOptionsObject["isBoolean"] = ExpressionConverter.ConvertO(bodyadvancedOptionsisBoolean);
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

                return new ApiConnectionAction<JToken[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        [WorkflowExpressionFactory(nameof(__BuildConcatenate))]
        public IBodyWorkflowAction<string> Concatenate([WorkflowExpression] Func<string> bodyfield, [WorkflowExpression] Func<string> bodyseparator = null, [WorkflowExpression] Func<bool> bodyignoreEmpty = null, [WorkflowExpression] Func<string> bodyfilter = null, [WorkflowExpression] Func<string> bodyadvancedOptionscultureName = null, [WorkflowExpression] Func<string[]> bodyadvancedOptionsisBoolean = null, [WorkflowExpression] Func<JToken[]> bodydata = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildConcatenate(WorkflowValue<string> bodyfield, WorkflowValue<string> bodyseparator = null, WorkflowValue<bool> bodyignoreEmpty = null, WorkflowValue<string> bodyfilter = null, WorkflowValue<string> bodyadvancedOptionscultureName = null, WorkflowValue<string[]> bodyadvancedOptionsisBoolean = null, WorkflowValue<JToken[]> bodydata = null)
        {
            WorkflowValue.Validate(bodyfield, nameof(bodyfield), required: true);
            WorkflowValue.Validate(bodyseparator, nameof(bodyseparator), required: false);
            WorkflowValue.Validate(bodyignoreEmpty, nameof(bodyignoreEmpty), required: false);
            WorkflowValue.Validate(bodyfilter, nameof(bodyfilter), required: false);
            WorkflowValue.Validate(bodyadvancedOptionscultureName, nameof(bodyadvancedOptionscultureName), required: false);
            WorkflowValue.Validate(bodyadvancedOptionsisBoolean, nameof(bodyadvancedOptionsisBoolean), required: false);
            WorkflowValue.Validate(bodydata, nameof(bodydata), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/Concatenate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["field"] = ExpressionConverter.ConvertO(bodyfield);
                if (bodyseparator != null)
                {
                    body["separator"] = ExpressionConverter.ConvertO(bodyseparator);
                    bodypropCount++;
                }

                if (bodyignoreEmpty != null)
                {
                    body["ignoreEmpty"] = ExpressionConverter.ConvertO(bodyignoreEmpty);
                    bodypropCount++;
                }

                if (bodyfilter != null)
                {
                    body["filter"] = ExpressionConverter.ConvertO(bodyfilter);
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
                    advancedOptionsObject["cultureName"] = ExpressionConverter.ConvertO(bodyadvancedOptionscultureName);
                    advancedOptionsObjectpropCount++;
                }

                if (bodyadvancedOptionsisBoolean != null)
                {
                    advancedOptionsObject["isBoolean"] = ExpressionConverter.ConvertO(bodyadvancedOptionsisBoolean);
                    advancedOptionsObjectpropCount++;
                }

                if (advancedOptionsObjectpropCount > 0)
                {
                    body["advancedOptions"] = advancedOptionsObject;
                    bodypropCount++;
                }

                if (bodydata != null)
                {
                    body["data"] = ExpressionConverter.ConvertO(bodydata);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        [WorkflowExpressionFactory(nameof(__BuildCSharpEvaluate))]
        public IBodyWorkflowAction<JToken> CSharpEvaluate([WorkflowExpression] Func<string> bodyexpression)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildCSharpEvaluate(WorkflowValue<string> bodyexpression)
        {
            WorkflowValue.Validate(bodyexpression, nameof(bodyexpression), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/CSharpEvaluate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["expression"] = ExpressionConverter.ConvertO(bodyexpression);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        [WorkflowExpressionFactory(nameof(__BuildCSharpScriptExecute))]
        public IBodyWorkflowAction<JToken> CSharpScriptExecute([WorkflowExpression] Func<string> bodyscript, [WorkflowExpression] Func<string[]> bodyclassDefinitions = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildCSharpScriptExecute(WorkflowValue<string> bodyscript, WorkflowValue<string[]> bodyclassDefinitions = null)
        {
            WorkflowValue.Validate(bodyscript, nameof(bodyscript), required: true);
            WorkflowValue.Validate(bodyclassDefinitions, nameof(bodyclassDefinitions), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/CSharpScriptExecute";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["script"] = ExpressionConverter.ConvertO(bodyscript);
                if (bodyclassDefinitions != null)
                {
                    body["classDefinitions"] = ExpressionConverter.ConvertO(bodyclassDefinitions);
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

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        [WorkflowExpressionFactory(nameof(__BuildCsvToJson))]
        public IBodyWorkflowAction<JToken[]> CsvToJson([WorkflowExpression] Func<string> bodydata, [WorkflowExpression] Func<bool> bodyheaderRow = null, [WorkflowExpression] Func<string> bodyrowSeparator = null, [WorkflowExpression] Func<string> bodydelimiter = null, [WorkflowExpression] Func<string> bodyescapeCharacter = null, [WorkflowExpression] Func<bodyencodingInput> bodyencoding = null, [WorkflowExpression] Func<string> bodyfilter = null, [WorkflowExpression] Func<string> bodyadvancedOptionscultureName = null, [WorkflowExpression] Func<string[]> bodyadvancedOptionsisBoolean = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken[]> __BuildCsvToJson(WorkflowValue<string> bodydata, WorkflowValue<bool> bodyheaderRow = null, WorkflowValue<string> bodyrowSeparator = null, WorkflowValue<string> bodydelimiter = null, WorkflowValue<string> bodyescapeCharacter = null, WorkflowValue<bodyencodingInput> bodyencoding = null, WorkflowValue<string> bodyfilter = null, WorkflowValue<string> bodyadvancedOptionscultureName = null, WorkflowValue<string[]> bodyadvancedOptionsisBoolean = null)
        {
            WorkflowValue.Validate(bodydata, nameof(bodydata), required: true);
            WorkflowValue.Validate(bodyheaderRow, nameof(bodyheaderRow), required: false);
            WorkflowValue.Validate(bodyrowSeparator, nameof(bodyrowSeparator), required: false);
            WorkflowValue.Validate(bodydelimiter, nameof(bodydelimiter), required: false);
            WorkflowValue.Validate(bodyescapeCharacter, nameof(bodyescapeCharacter), required: false);
            WorkflowValue.Validate(bodyencoding, nameof(bodyencoding), required: false);
            WorkflowValue.Validate(bodyfilter, nameof(bodyfilter), required: false);
            WorkflowValue.Validate(bodyadvancedOptionscultureName, nameof(bodyadvancedOptionscultureName), required: false);
            WorkflowValue.Validate(bodyadvancedOptionsisBoolean, nameof(bodyadvancedOptionsisBoolean), required: false);
            return new DeferredBodyAction<JToken[]>(() =>
            {
                var apiCallPath = "/CsvToJson";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyheaderRow != null)
                {
                    body["headerRow"] = ExpressionConverter.ConvertO(bodyheaderRow);
                    bodypropCount++;
                }

                if (bodyrowSeparator != null)
                {
                    body["rowSeparator"] = ExpressionConverter.ConvertO(bodyrowSeparator);
                    bodypropCount++;
                }

                if (bodydelimiter != null)
                {
                    body["delimiter"] = ExpressionConverter.ConvertO(bodydelimiter);
                    bodypropCount++;
                }

                if (bodyescapeCharacter != null)
                {
                    body["escapeCharacter"] = ExpressionConverter.ConvertO(bodyescapeCharacter);
                    bodypropCount++;
                }

                if (bodyencoding != null)
                {
                    body["encoding"] = ExpressionConverter.ConvertO(bodyencoding);
                    bodypropCount++;
                }

                if (bodyfilter != null)
                {
                    body["filter"] = ExpressionConverter.ConvertO(bodyfilter);
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
                    advancedOptionsObject["cultureName"] = ExpressionConverter.ConvertO(bodyadvancedOptionscultureName);
                    advancedOptionsObjectpropCount++;
                }

                if (bodyadvancedOptionsisBoolean != null)
                {
                    advancedOptionsObject["isBoolean"] = ExpressionConverter.ConvertO(bodyadvancedOptionsisBoolean);
                    advancedOptionsObjectpropCount++;
                }

                if (advancedOptionsObjectpropCount > 0)
                {
                    body["advancedOptions"] = advancedOptionsObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["data"] = ExpressionConverter.ConvertO(bodydata);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        [WorkflowExpressionFactory(nameof(__BuildDistinct))]
        public IWorkflowAction Distinct([WorkflowExpression] Func<string[]> bodyfields, [WorkflowExpression] Func<string> bodyfilter = null, [WorkflowExpression] Func<string> bodyadvancedOptionscultureName = null, [WorkflowExpression] Func<string[]> bodyadvancedOptionsisBoolean = null, [WorkflowExpression] Func<JToken[]> bodydata = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDistinct(WorkflowValue<string[]> bodyfields, WorkflowValue<string> bodyfilter = null, WorkflowValue<string> bodyadvancedOptionscultureName = null, WorkflowValue<string[]> bodyadvancedOptionsisBoolean = null, WorkflowValue<JToken[]> bodydata = null)
        {
            WorkflowValue.Validate(bodyfields, nameof(bodyfields), required: true);
            WorkflowValue.Validate(bodyfilter, nameof(bodyfilter), required: false);
            WorkflowValue.Validate(bodyadvancedOptionscultureName, nameof(bodyadvancedOptionscultureName), required: false);
            WorkflowValue.Validate(bodyadvancedOptionsisBoolean, nameof(bodyadvancedOptionsisBoolean), required: false);
            WorkflowValue.Validate(bodydata, nameof(bodydata), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Distinct";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["fields"] = ExpressionConverter.ConvertO(bodyfields);
                if (bodyfilter != null)
                {
                    body["filter"] = ExpressionConverter.ConvertO(bodyfilter);
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
                    advancedOptionsObject["cultureName"] = ExpressionConverter.ConvertO(bodyadvancedOptionscultureName);
                    advancedOptionsObjectpropCount++;
                }

                if (bodyadvancedOptionsisBoolean != null)
                {
                    advancedOptionsObject["isBoolean"] = ExpressionConverter.ConvertO(bodyadvancedOptionsisBoolean);
                    advancedOptionsObjectpropCount++;
                }

                if (advancedOptionsObjectpropCount > 0)
                {
                    body["advancedOptions"] = advancedOptionsObject;
                    bodypropCount++;
                }

                if (bodydata != null)
                {
                    body["data"] = ExpressionConverter.ConvertO(bodydata);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        [WorkflowExpressionFactory(nameof(__BuildExpert))]
        public IBodyWorkflowAction<JToken[]> Expert([WorkflowExpression] Func<string> bodyquery, [WorkflowExpression] Func<string> bodyadvancedOptionscultureName = null, [WorkflowExpression] Func<string[]> bodyadvancedOptionsisBoolean = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken[]> __BuildExpert(WorkflowValue<string> bodyquery, WorkflowValue<string> bodyadvancedOptionscultureName = null, WorkflowValue<string[]> bodyadvancedOptionsisBoolean = null)
        {
            WorkflowValue.Validate(bodyquery, nameof(bodyquery), required: true);
            WorkflowValue.Validate(bodyadvancedOptionscultureName, nameof(bodyadvancedOptionscultureName), required: false);
            WorkflowValue.Validate(bodyadvancedOptionsisBoolean, nameof(bodyadvancedOptionsisBoolean), required: false);
            return new DeferredBodyAction<JToken[]>(() =>
            {
                var apiCallPath = "/Expert";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["query"] = ExpressionConverter.ConvertO(bodyquery);
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
                    advancedOptionsObject["cultureName"] = ExpressionConverter.ConvertO(bodyadvancedOptionscultureName);
                    advancedOptionsObjectpropCount++;
                }

                if (bodyadvancedOptionsisBoolean != null)
                {
                    advancedOptionsObject["isBoolean"] = ExpressionConverter.ConvertO(bodyadvancedOptionsisBoolean);
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

                return new ApiConnectionAction<JToken[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        [WorkflowExpressionFactory(nameof(__BuildFilterObjectArray))]
        public IBodyWorkflowAction<JToken[]> FilterObjectArray([WorkflowExpression] Func<string> bodyfilter, [WorkflowExpression] Func<JToken[]> bodydata = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken[]> __BuildFilterObjectArray(WorkflowValue<string> bodyfilter, WorkflowValue<JToken[]> bodydata = null)
        {
            WorkflowValue.Validate(bodyfilter, nameof(bodyfilter), required: true);
            WorkflowValue.Validate(bodydata, nameof(bodydata), required: false);
            return new DeferredBodyAction<JToken[]>(() =>
            {
                var apiCallPath = "/FilterObjectArray";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["filter"] = ExpressionConverter.ConvertO(bodyfilter);
                if (bodydata != null)
                {
                    body["data"] = ExpressionConverter.ConvertO(bodydata);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        [WorkflowExpressionFactory(nameof(__BuildFlattenObjectArray))]
        public IBodyWorkflowAction<JToken[]> FlattenObjectArray([WorkflowExpression] Func<string> bodydelimiter, [WorkflowExpression] Func<bool> bodybalancedOutput, [WorkflowExpression] Func<string> bodyfilter = null, [WorkflowExpression] Func<string> bodyadvancedOptionscultureName = null, [WorkflowExpression] Func<string[]> bodyadvancedOptionsisBoolean = null, [WorkflowExpression] Func<JToken[]> bodydata = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken[]> __BuildFlattenObjectArray(WorkflowValue<string> bodydelimiter, WorkflowValue<bool> bodybalancedOutput, WorkflowValue<string> bodyfilter = null, WorkflowValue<string> bodyadvancedOptionscultureName = null, WorkflowValue<string[]> bodyadvancedOptionsisBoolean = null, WorkflowValue<JToken[]> bodydata = null)
        {
            WorkflowValue.Validate(bodydelimiter, nameof(bodydelimiter), required: true);
            WorkflowValue.Validate(bodybalancedOutput, nameof(bodybalancedOutput), required: true);
            WorkflowValue.Validate(bodyfilter, nameof(bodyfilter), required: false);
            WorkflowValue.Validate(bodyadvancedOptionscultureName, nameof(bodyadvancedOptionscultureName), required: false);
            WorkflowValue.Validate(bodyadvancedOptionsisBoolean, nameof(bodyadvancedOptionsisBoolean), required: false);
            WorkflowValue.Validate(bodydata, nameof(bodydata), required: false);
            return new DeferredBodyAction<JToken[]>(() =>
            {
                var apiCallPath = "/FlattenObjectArray";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["delimiter"] = ExpressionConverter.ConvertO(bodydelimiter);
                bodypropCount++;
                body["balancedOutput"] = ExpressionConverter.ConvertO(bodybalancedOutput);
                if (bodyfilter != null)
                {
                    body["filter"] = ExpressionConverter.ConvertO(bodyfilter);
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
                    advancedOptionsObject["cultureName"] = ExpressionConverter.ConvertO(bodyadvancedOptionscultureName);
                    advancedOptionsObjectpropCount++;
                }

                if (bodyadvancedOptionsisBoolean != null)
                {
                    advancedOptionsObject["isBoolean"] = ExpressionConverter.ConvertO(bodyadvancedOptionsisBoolean);
                    advancedOptionsObjectpropCount++;
                }

                if (advancedOptionsObjectpropCount > 0)
                {
                    body["advancedOptions"] = advancedOptionsObject;
                    bodypropCount++;
                }

                if (bodydata != null)
                {
                    body["data"] = ExpressionConverter.ConvertO(bodydata);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        [WorkflowExpressionFactory(nameof(__BuildGetDataSchema))]
        public IBodyWorkflowAction<JToken[]> GetDataSchema([WorkflowExpression] Func<string> bodyfilter = null, [WorkflowExpression] Func<string> bodyadvancedOptionscultureName = null, [WorkflowExpression] Func<string[]> bodyadvancedOptionsisBoolean = null, [WorkflowExpression] Func<JToken[]> bodydata = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken[]> __BuildGetDataSchema(WorkflowValue<string> bodyfilter = null, WorkflowValue<string> bodyadvancedOptionscultureName = null, WorkflowValue<string[]> bodyadvancedOptionsisBoolean = null, WorkflowValue<JToken[]> bodydata = null)
        {
            WorkflowValue.Validate(bodyfilter, nameof(bodyfilter), required: false);
            WorkflowValue.Validate(bodyadvancedOptionscultureName, nameof(bodyadvancedOptionscultureName), required: false);
            WorkflowValue.Validate(bodyadvancedOptionsisBoolean, nameof(bodyadvancedOptionsisBoolean), required: false);
            WorkflowValue.Validate(bodydata, nameof(bodydata), required: false);
            return new DeferredBodyAction<JToken[]>(() =>
            {
                var apiCallPath = "/GetDataSchema";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfilter != null)
                {
                    body["filter"] = ExpressionConverter.ConvertO(bodyfilter);
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
                    advancedOptionsObject["cultureName"] = ExpressionConverter.ConvertO(bodyadvancedOptionscultureName);
                    advancedOptionsObjectpropCount++;
                }

                if (bodyadvancedOptionsisBoolean != null)
                {
                    advancedOptionsObject["isBoolean"] = ExpressionConverter.ConvertO(bodyadvancedOptionsisBoolean);
                    advancedOptionsObjectpropCount++;
                }

                if (advancedOptionsObjectpropCount > 0)
                {
                    body["advancedOptions"] = advancedOptionsObject;
                    bodypropCount++;
                }

                if (bodydata != null)
                {
                    body["data"] = ExpressionConverter.ConvertO(bodydata);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        [WorkflowExpressionFactory(nameof(__BuildGZipCompress))]
        public IBodyWorkflowAction<string> GZipCompress([WorkflowExpression] Func<string> bodydata)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildGZipCompress(WorkflowValue<string> bodydata)
        {
            WorkflowValue.Validate(bodydata, nameof(bodydata), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/GZipCompress";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["data"] = ExpressionConverter.ConvertO(bodydata);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        [WorkflowExpressionFactory(nameof(__BuildGZipDecompress))]
        public IBodyWorkflowAction<string> GZipDecompress([WorkflowExpression] Func<string> bodydata)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildGZipDecompress(WorkflowValue<string> bodydata)
        {
            WorkflowValue.Validate(bodydata, nameof(bodydata), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/GZipDecompress";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["data"] = ExpressionConverter.ConvertO(bodydata);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        [WorkflowExpressionFactory(nameof(__BuildJoin))]
        public IBodyWorkflowAction<JToken[]> Join([WorkflowExpression] Func<bodyjoinTypeInput> bodyjoinType, [WorkflowExpression] Func<string[]> bodyjoinFields, [WorkflowExpression] Func<string[]> bodyfields, [WorkflowExpression] Func<bool> bodyforceFullyQualifiedFieldNames = null, [WorkflowExpression] Func<string> bodyfilter = null, [WorkflowExpression] Func<string> bodyadvancedOptionscultureName = null, [WorkflowExpression] Func<string[]> bodyadvancedOptionsisBoolean = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken[]> __BuildJoin(WorkflowValue<bodyjoinTypeInput> bodyjoinType, WorkflowValue<string[]> bodyjoinFields, WorkflowValue<string[]> bodyfields, WorkflowValue<bool> bodyforceFullyQualifiedFieldNames = null, WorkflowValue<string> bodyfilter = null, WorkflowValue<string> bodyadvancedOptionscultureName = null, WorkflowValue<string[]> bodyadvancedOptionsisBoolean = null)
        {
            WorkflowValue.Validate(bodyjoinType, nameof(bodyjoinType), required: true);
            WorkflowValue.Validate(bodyjoinFields, nameof(bodyjoinFields), required: true);
            WorkflowValue.Validate(bodyfields, nameof(bodyfields), required: true);
            WorkflowValue.Validate(bodyforceFullyQualifiedFieldNames, nameof(bodyforceFullyQualifiedFieldNames), required: false);
            WorkflowValue.Validate(bodyfilter, nameof(bodyfilter), required: false);
            WorkflowValue.Validate(bodyadvancedOptionscultureName, nameof(bodyadvancedOptionscultureName), required: false);
            WorkflowValue.Validate(bodyadvancedOptionsisBoolean, nameof(bodyadvancedOptionsisBoolean), required: false);
            return new DeferredBodyAction<JToken[]>(() =>
            {
                var apiCallPath = "/Join";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["joinType"] = ExpressionConverter.ConvertO(bodyjoinType);
                bodypropCount++;
                body["joinFields"] = ExpressionConverter.ConvertO(bodyjoinFields);
                bodypropCount++;
                body["fields"] = ExpressionConverter.ConvertO(bodyfields);
                if (bodyforceFullyQualifiedFieldNames != null)
                {
                    body["forceFullyQualifiedFieldNames"] = ExpressionConverter.ConvertO(bodyforceFullyQualifiedFieldNames);
                    bodypropCount++;
                }

                if (bodyfilter != null)
                {
                    body["filter"] = ExpressionConverter.ConvertO(bodyfilter);
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
                    advancedOptionsObject["cultureName"] = ExpressionConverter.ConvertO(bodyadvancedOptionscultureName);
                    advancedOptionsObjectpropCount++;
                }

                if (bodyadvancedOptionsisBoolean != null)
                {
                    advancedOptionsObject["isBoolean"] = ExpressionConverter.ConvertO(bodyadvancedOptionsisBoolean);
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

                return new ApiConnectionAction<JToken[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<string[]> JsonSchemaValidate()
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

            return new ApiConnectionAction<string[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        [WorkflowExpressionFactory(nameof(__BuildJsonToTable))]
        public IBodyWorkflowAction<JToken[]> JsonToTable([WorkflowExpression] Func<string> bodypath = null, [WorkflowExpression] Func<bool> bodybalancedOutput = null, [WorkflowExpression] Func<string> bodyfilter = null, [WorkflowExpression] Func<string> bodyadvancedOptionscultureName = null, [WorkflowExpression] Func<string[]> bodyadvancedOptionsisBoolean = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken[]> __BuildJsonToTable(WorkflowValue<string> bodypath = null, WorkflowValue<bool> bodybalancedOutput = null, WorkflowValue<string> bodyfilter = null, WorkflowValue<string> bodyadvancedOptionscultureName = null, WorkflowValue<string[]> bodyadvancedOptionsisBoolean = null)
        {
            WorkflowValue.Validate(bodypath, nameof(bodypath), required: false);
            WorkflowValue.Validate(bodybalancedOutput, nameof(bodybalancedOutput), required: false);
            WorkflowValue.Validate(bodyfilter, nameof(bodyfilter), required: false);
            WorkflowValue.Validate(bodyadvancedOptionscultureName, nameof(bodyadvancedOptionscultureName), required: false);
            WorkflowValue.Validate(bodyadvancedOptionsisBoolean, nameof(bodyadvancedOptionsisBoolean), required: false);
            return new DeferredBodyAction<JToken[]>(() =>
            {
                var apiCallPath = "/JsonToTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypath != null)
                {
                    body["path"] = ExpressionConverter.ConvertO(bodypath);
                    bodypropCount++;
                }

                if (bodybalancedOutput != null)
                {
                    body["balancedOutput"] = ExpressionConverter.ConvertO(bodybalancedOutput);
                    bodypropCount++;
                }

                if (bodyfilter != null)
                {
                    body["filter"] = ExpressionConverter.ConvertO(bodyfilter);
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
                    advancedOptionsObject["cultureName"] = ExpressionConverter.ConvertO(bodyadvancedOptionscultureName);
                    advancedOptionsObjectpropCount++;
                }

                if (bodyadvancedOptionsisBoolean != null)
                {
                    advancedOptionsObject["isBoolean"] = ExpressionConverter.ConvertO(bodyadvancedOptionsisBoolean);
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

                return new ApiConnectionAction<JToken[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        [WorkflowExpressionFactory(nameof(__BuildJsonToText))]
        public IBodyWorkflowAction<string> JsonToText([WorkflowExpression] Func<bool> bodyheaderRow = null, [WorkflowExpression] Func<string> bodyrowSeparator = null, [WorkflowExpression] Func<string> bodyfilter = null, [WorkflowExpression] Func<string> bodyadvancedOptionscultureName = null, [WorkflowExpression] Func<string[]> bodyadvancedOptionsisBoolean = null, [WorkflowExpression] Func<JToken[]> bodydata = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildJsonToText(WorkflowValue<bool> bodyheaderRow = null, WorkflowValue<string> bodyrowSeparator = null, WorkflowValue<string> bodyfilter = null, WorkflowValue<string> bodyadvancedOptionscultureName = null, WorkflowValue<string[]> bodyadvancedOptionsisBoolean = null, WorkflowValue<JToken[]> bodydata = null)
        {
            WorkflowValue.Validate(bodyheaderRow, nameof(bodyheaderRow), required: false);
            WorkflowValue.Validate(bodyrowSeparator, nameof(bodyrowSeparator), required: false);
            WorkflowValue.Validate(bodyfilter, nameof(bodyfilter), required: false);
            WorkflowValue.Validate(bodyadvancedOptionscultureName, nameof(bodyadvancedOptionscultureName), required: false);
            WorkflowValue.Validate(bodyadvancedOptionsisBoolean, nameof(bodyadvancedOptionsisBoolean), required: false);
            WorkflowValue.Validate(bodydata, nameof(bodydata), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/JsonToText";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyheaderRow != null)
                {
                    body["headerRow"] = ExpressionConverter.ConvertO(bodyheaderRow);
                    bodypropCount++;
                }

                if (bodyrowSeparator != null)
                {
                    body["rowSeparator"] = ExpressionConverter.ConvertO(bodyrowSeparator);
                    bodypropCount++;
                }

                if (bodyfilter != null)
                {
                    body["filter"] = ExpressionConverter.ConvertO(bodyfilter);
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
                    advancedOptionsObject["cultureName"] = ExpressionConverter.ConvertO(bodyadvancedOptionscultureName);
                    advancedOptionsObjectpropCount++;
                }

                if (bodyadvancedOptionsisBoolean != null)
                {
                    advancedOptionsObject["isBoolean"] = ExpressionConverter.ConvertO(bodyadvancedOptionsisBoolean);
                    advancedOptionsObjectpropCount++;
                }

                if (advancedOptionsObjectpropCount > 0)
                {
                    body["advancedOptions"] = advancedOptionsObject;
                    bodypropCount++;
                }

                if (bodydata != null)
                {
                    body["data"] = ExpressionConverter.ConvertO(bodydata);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        [WorkflowExpressionFactory(nameof(__BuildJsonToCsv))]
        public IBodyWorkflowAction<string> JsonToCsv([WorkflowExpression] Func<bool> bodyheaderRow = null, [WorkflowExpression] Func<string> bodyrowSeparator = null, [WorkflowExpression] Func<string> bodyescapeCharacter = null, [WorkflowExpression] Func<string> bodyfilter = null, [WorkflowExpression] Func<string> bodyadvancedOptionscultureName = null, [WorkflowExpression] Func<string[]> bodyadvancedOptionsisBoolean = null, [WorkflowExpression] Func<JToken[]> bodydata = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildJsonToCsv(WorkflowValue<bool> bodyheaderRow = null, WorkflowValue<string> bodyrowSeparator = null, WorkflowValue<string> bodyescapeCharacter = null, WorkflowValue<string> bodyfilter = null, WorkflowValue<string> bodyadvancedOptionscultureName = null, WorkflowValue<string[]> bodyadvancedOptionsisBoolean = null, WorkflowValue<JToken[]> bodydata = null)
        {
            WorkflowValue.Validate(bodyheaderRow, nameof(bodyheaderRow), required: false);
            WorkflowValue.Validate(bodyrowSeparator, nameof(bodyrowSeparator), required: false);
            WorkflowValue.Validate(bodyescapeCharacter, nameof(bodyescapeCharacter), required: false);
            WorkflowValue.Validate(bodyfilter, nameof(bodyfilter), required: false);
            WorkflowValue.Validate(bodyadvancedOptionscultureName, nameof(bodyadvancedOptionscultureName), required: false);
            WorkflowValue.Validate(bodyadvancedOptionsisBoolean, nameof(bodyadvancedOptionsisBoolean), required: false);
            WorkflowValue.Validate(bodydata, nameof(bodydata), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/JsonToCsv";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyheaderRow != null)
                {
                    body["headerRow"] = ExpressionConverter.ConvertO(bodyheaderRow);
                    bodypropCount++;
                }

                if (bodyrowSeparator != null)
                {
                    body["rowSeparator"] = ExpressionConverter.ConvertO(bodyrowSeparator);
                    bodypropCount++;
                }

                if (bodyescapeCharacter != null)
                {
                    body["escapeCharacter"] = ExpressionConverter.ConvertO(bodyescapeCharacter);
                    bodypropCount++;
                }

                if (bodyfilter != null)
                {
                    body["filter"] = ExpressionConverter.ConvertO(bodyfilter);
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
                    advancedOptionsObject["cultureName"] = ExpressionConverter.ConvertO(bodyadvancedOptionscultureName);
                    advancedOptionsObjectpropCount++;
                }

                if (bodyadvancedOptionsisBoolean != null)
                {
                    advancedOptionsObject["isBoolean"] = ExpressionConverter.ConvertO(bodyadvancedOptionsisBoolean);
                    advancedOptionsObjectpropCount++;
                }

                if (advancedOptionsObjectpropCount > 0)
                {
                    body["advancedOptions"] = advancedOptionsObject;
                    bodypropCount++;
                }

                if (bodydata != null)
                {
                    body["data"] = ExpressionConverter.ConvertO(bodydata);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        [WorkflowExpressionFactory(nameof(__BuildJsonPropertiesToNameValuePairArray))]
        public IWorkflowAction JsonPropertiesToNameValuePairArray([WorkflowExpression] Func<object> bodydata)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildJsonPropertiesToNameValuePairArray(WorkflowValue<object> bodydata)
        {
            WorkflowValue.Validate(bodydata, nameof(bodydata), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/JsonPropertiesToNameValuePairArray";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["data"] = ExpressionConverter.ConvertO(bodydata);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        [WorkflowExpressionFactory(nameof(__BuildLevenshteinDistance))]
        public IBodyWorkflowAction<LevenshteinDistanceResponse> LevenshteinDistance([WorkflowExpression] Func<string> bodybaseValue, [WorkflowExpression] Func<string[]> bodycomparisonValues, [WorkflowExpression] Func<double> bodysettingsratioThreshold = null, [WorkflowExpression] Func<bodysettingsapplyRatioThresholdToInput> bodysettingsapplyRatioThresholdTo = null, [WorkflowExpression] Func<bodysettingsratioSelectionTypeInput> bodysettingsratioSelectionType = null, [WorkflowExpression] Func<bodysettingstokenSortTypeInput> bodysettingstokenSortType = null, [WorkflowExpression] Func<bool> bodysettingscaseSensitive = null, [WorkflowExpression] Func<bool> bodysettingsremoveWhitespace = null, [WorkflowExpression] Func<bool> bodysettingsremoveSpecialCharacters = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<LevenshteinDistanceResponse> __BuildLevenshteinDistance(WorkflowValue<string> bodybaseValue, WorkflowValue<string[]> bodycomparisonValues, WorkflowValue<double> bodysettingsratioThreshold = null, WorkflowValue<bodysettingsapplyRatioThresholdToInput> bodysettingsapplyRatioThresholdTo = null, WorkflowValue<bodysettingsratioSelectionTypeInput> bodysettingsratioSelectionType = null, WorkflowValue<bodysettingstokenSortTypeInput> bodysettingstokenSortType = null, WorkflowValue<bool> bodysettingscaseSensitive = null, WorkflowValue<bool> bodysettingsremoveWhitespace = null, WorkflowValue<bool> bodysettingsremoveSpecialCharacters = null)
        {
            WorkflowValue.Validate(bodybaseValue, nameof(bodybaseValue), required: true);
            WorkflowValue.Validate(bodycomparisonValues, nameof(bodycomparisonValues), required: true);
            WorkflowValue.Validate(bodysettingsratioThreshold, nameof(bodysettingsratioThreshold), required: false);
            WorkflowValue.Validate(bodysettingsapplyRatioThresholdTo, nameof(bodysettingsapplyRatioThresholdTo), required: false);
            WorkflowValue.Validate(bodysettingsratioSelectionType, nameof(bodysettingsratioSelectionType), required: false);
            WorkflowValue.Validate(bodysettingstokenSortType, nameof(bodysettingstokenSortType), required: false);
            WorkflowValue.Validate(bodysettingscaseSensitive, nameof(bodysettingscaseSensitive), required: false);
            WorkflowValue.Validate(bodysettingsremoveWhitespace, nameof(bodysettingsremoveWhitespace), required: false);
            WorkflowValue.Validate(bodysettingsremoveSpecialCharacters, nameof(bodysettingsremoveSpecialCharacters), required: false);
            return new DeferredBodyAction<LevenshteinDistanceResponse>(() =>
            {
                var apiCallPath = "/LevenshteinDistance";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["baseValue"] = ExpressionConverter.ConvertO(bodybaseValue);
                bodypropCount++;
                body["comparisonValues"] = ExpressionConverter.ConvertO(bodycomparisonValues);
                var settingsObject = new JObject();
                var settingsObjectpropCount = 0;
                if (bodysettingsratioThreshold != null)
                {
                    settingsObject["ratioThreshold"] = ExpressionConverter.ConvertO(bodysettingsratioThreshold);
                    settingsObjectpropCount++;
                }

                if (bodysettingsapplyRatioThresholdTo != null)
                {
                    settingsObject["applyRatioThresholdTo"] = ExpressionConverter.ConvertO(bodysettingsapplyRatioThresholdTo);
                    settingsObjectpropCount++;
                }

                if (bodysettingsratioSelectionType != null)
                {
                    settingsObject["ratioSelectionType"] = ExpressionConverter.ConvertO(bodysettingsratioSelectionType);
                    settingsObjectpropCount++;
                }

                if (bodysettingstokenSortType != null)
                {
                    settingsObject["tokenSortType"] = ExpressionConverter.ConvertO(bodysettingstokenSortType);
                    settingsObjectpropCount++;
                }

                if (bodysettingscaseSensitive != null)
                {
                    settingsObject["caseSensitive"] = ExpressionConverter.ConvertO(bodysettingscaseSensitive);
                    settingsObjectpropCount++;
                }

                if (bodysettingsremoveWhitespace != null)
                {
                    settingsObject["removeWhitespace"] = ExpressionConverter.ConvertO(bodysettingsremoveWhitespace);
                    settingsObjectpropCount++;
                }

                if (bodysettingsremoveSpecialCharacters != null)
                {
                    settingsObject["removeSpecialCharacters"] = ExpressionConverter.ConvertO(bodysettingsremoveSpecialCharacters);
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

                return new ApiConnectionAction<LevenshteinDistanceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        [WorkflowExpressionFactory(nameof(__BuildParquetToJson))]
        public IBodyWorkflowAction<JToken[]> ParquetToJson([WorkflowExpression] Func<string> bodydata, [WorkflowExpression] Func<bool> bodyvalidateOnly = null, [WorkflowExpression] Func<int> bodyskip = null, [WorkflowExpression] Func<int> bodytake = null, [WorkflowExpression] Func<string> bodyfilter = null, [WorkflowExpression] Func<string> bodyadvancedOptionscultureName = null, [WorkflowExpression] Func<string[]> bodyadvancedOptionsisBoolean = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken[]> __BuildParquetToJson(WorkflowValue<string> bodydata, WorkflowValue<bool> bodyvalidateOnly = null, WorkflowValue<int> bodyskip = null, WorkflowValue<int> bodytake = null, WorkflowValue<string> bodyfilter = null, WorkflowValue<string> bodyadvancedOptionscultureName = null, WorkflowValue<string[]> bodyadvancedOptionsisBoolean = null)
        {
            WorkflowValue.Validate(bodydata, nameof(bodydata), required: true);
            WorkflowValue.Validate(bodyvalidateOnly, nameof(bodyvalidateOnly), required: false);
            WorkflowValue.Validate(bodyskip, nameof(bodyskip), required: false);
            WorkflowValue.Validate(bodytake, nameof(bodytake), required: false);
            WorkflowValue.Validate(bodyfilter, nameof(bodyfilter), required: false);
            WorkflowValue.Validate(bodyadvancedOptionscultureName, nameof(bodyadvancedOptionscultureName), required: false);
            WorkflowValue.Validate(bodyadvancedOptionsisBoolean, nameof(bodyadvancedOptionsisBoolean), required: false);
            return new DeferredBodyAction<JToken[]>(() =>
            {
                var apiCallPath = "/ParquetToJson";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyvalidateOnly != null)
                {
                    body["validateOnly"] = ExpressionConverter.ConvertO(bodyvalidateOnly);
                    bodypropCount++;
                }

                if (bodyskip != null)
                {
                    body["skip"] = ExpressionConverter.ConvertO(bodyskip);
                    bodypropCount++;
                }

                if (bodytake != null)
                {
                    body["take"] = ExpressionConverter.ConvertO(bodytake);
                    bodypropCount++;
                }

                if (bodyfilter != null)
                {
                    body["filter"] = ExpressionConverter.ConvertO(bodyfilter);
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
                    advancedOptionsObject["cultureName"] = ExpressionConverter.ConvertO(bodyadvancedOptionscultureName);
                    advancedOptionsObjectpropCount++;
                }

                if (bodyadvancedOptionsisBoolean != null)
                {
                    advancedOptionsObject["isBoolean"] = ExpressionConverter.ConvertO(bodyadvancedOptionsisBoolean);
                    advancedOptionsObjectpropCount++;
                }

                if (advancedOptionsObjectpropCount > 0)
                {
                    body["advancedOptions"] = advancedOptionsObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["data"] = ExpressionConverter.ConvertO(bodydata);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        [WorkflowExpressionFactory(nameof(__BuildRegexMatches))]
        public IBodyWorkflowAction<string[]> RegexMatches([WorkflowExpression] Func<string> bodypattern, [WorkflowExpression] Func<string> bodydata, [WorkflowExpression] Func<string> bodyfilter = null, [WorkflowExpression] Func<string> bodyadvancedOptionscultureName = null, [WorkflowExpression] Func<string[]> bodyadvancedOptionsisBoolean = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string[]> __BuildRegexMatches(WorkflowValue<string> bodypattern, WorkflowValue<string> bodydata, WorkflowValue<string> bodyfilter = null, WorkflowValue<string> bodyadvancedOptionscultureName = null, WorkflowValue<string[]> bodyadvancedOptionsisBoolean = null)
        {
            WorkflowValue.Validate(bodypattern, nameof(bodypattern), required: true);
            WorkflowValue.Validate(bodydata, nameof(bodydata), required: true);
            WorkflowValue.Validate(bodyfilter, nameof(bodyfilter), required: false);
            WorkflowValue.Validate(bodyadvancedOptionscultureName, nameof(bodyadvancedOptionscultureName), required: false);
            WorkflowValue.Validate(bodyadvancedOptionsisBoolean, nameof(bodyadvancedOptionsisBoolean), required: false);
            return new DeferredBodyAction<string[]>(() =>
            {
                var apiCallPath = "/RegexMatches";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["pattern"] = ExpressionConverter.ConvertO(bodypattern);
                if (bodyfilter != null)
                {
                    body["filter"] = ExpressionConverter.ConvertO(bodyfilter);
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
                    advancedOptionsObject["cultureName"] = ExpressionConverter.ConvertO(bodyadvancedOptionscultureName);
                    advancedOptionsObjectpropCount++;
                }

                if (bodyadvancedOptionsisBoolean != null)
                {
                    advancedOptionsObject["isBoolean"] = ExpressionConverter.ConvertO(bodyadvancedOptionsisBoolean);
                    advancedOptionsObjectpropCount++;
                }

                if (advancedOptionsObjectpropCount > 0)
                {
                    body["advancedOptions"] = advancedOptionsObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["data"] = ExpressionConverter.ConvertO(bodydata);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        [WorkflowExpressionFactory(nameof(__BuildSimpleConcatenate))]
        public IBodyWorkflowAction<string> SimpleConcatenate([WorkflowExpression] Func<string[]> bodydata, [WorkflowExpression] Func<string> bodyseparator = null, [WorkflowExpression] Func<bool> bodyignoreEmpty = null, [WorkflowExpression] Func<string> bodyfilter = null, [WorkflowExpression] Func<bodysortOrderInput> bodysortOrder = null, [WorkflowExpression] Func<string> bodyadvancedOptionscultureName = null, [WorkflowExpression] Func<string[]> bodyadvancedOptionsisBoolean = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildSimpleConcatenate(WorkflowValue<string[]> bodydata, WorkflowValue<string> bodyseparator = null, WorkflowValue<bool> bodyignoreEmpty = null, WorkflowValue<string> bodyfilter = null, WorkflowValue<bodysortOrderInput> bodysortOrder = null, WorkflowValue<string> bodyadvancedOptionscultureName = null, WorkflowValue<string[]> bodyadvancedOptionsisBoolean = null)
        {
            WorkflowValue.Validate(bodydata, nameof(bodydata), required: true);
            WorkflowValue.Validate(bodyseparator, nameof(bodyseparator), required: false);
            WorkflowValue.Validate(bodyignoreEmpty, nameof(bodyignoreEmpty), required: false);
            WorkflowValue.Validate(bodyfilter, nameof(bodyfilter), required: false);
            WorkflowValue.Validate(bodysortOrder, nameof(bodysortOrder), required: false);
            WorkflowValue.Validate(bodyadvancedOptionscultureName, nameof(bodyadvancedOptionscultureName), required: false);
            WorkflowValue.Validate(bodyadvancedOptionsisBoolean, nameof(bodyadvancedOptionsisBoolean), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/SimpleConcatenate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyseparator != null)
                {
                    body["separator"] = ExpressionConverter.ConvertO(bodyseparator);
                    bodypropCount++;
                }

                if (bodyignoreEmpty != null)
                {
                    body["ignoreEmpty"] = ExpressionConverter.ConvertO(bodyignoreEmpty);
                    bodypropCount++;
                }

                if (bodyfilter != null)
                {
                    body["filter"] = ExpressionConverter.ConvertO(bodyfilter);
                    bodypropCount++;
                }

                if (bodysortOrder != null)
                {
                    body["sortOrder"] = ExpressionConverter.ConvertO(bodysortOrder);
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
                    advancedOptionsObject["cultureName"] = ExpressionConverter.ConvertO(bodyadvancedOptionscultureName);
                    advancedOptionsObjectpropCount++;
                }

                if (bodyadvancedOptionsisBoolean != null)
                {
                    advancedOptionsObject["isBoolean"] = ExpressionConverter.ConvertO(bodyadvancedOptionsisBoolean);
                    advancedOptionsObjectpropCount++;
                }

                if (advancedOptionsObjectpropCount > 0)
                {
                    body["advancedOptions"] = advancedOptionsObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["data"] = ExpressionConverter.ConvertO(bodydata);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        [WorkflowExpressionFactory(nameof(__BuildSimpleDistinct))]
        public IWorkflowAction SimpleDistinct([WorkflowExpression] Func<string> bodyfield, [WorkflowExpression] Func<string> bodyfilter = null, [WorkflowExpression] Func<bodysortOrderInput> bodysortOrder = null, [WorkflowExpression] Func<string> bodyadvancedOptionscultureName = null, [WorkflowExpression] Func<string[]> bodyadvancedOptionsisBoolean = null, [WorkflowExpression] Func<JToken[]> bodydata = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSimpleDistinct(WorkflowValue<string> bodyfield, WorkflowValue<string> bodyfilter = null, WorkflowValue<bodysortOrderInput> bodysortOrder = null, WorkflowValue<string> bodyadvancedOptionscultureName = null, WorkflowValue<string[]> bodyadvancedOptionsisBoolean = null, WorkflowValue<JToken[]> bodydata = null)
        {
            WorkflowValue.Validate(bodyfield, nameof(bodyfield), required: true);
            WorkflowValue.Validate(bodyfilter, nameof(bodyfilter), required: false);
            WorkflowValue.Validate(bodysortOrder, nameof(bodysortOrder), required: false);
            WorkflowValue.Validate(bodyadvancedOptionscultureName, nameof(bodyadvancedOptionscultureName), required: false);
            WorkflowValue.Validate(bodyadvancedOptionsisBoolean, nameof(bodyadvancedOptionsisBoolean), required: false);
            WorkflowValue.Validate(bodydata, nameof(bodydata), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/SimpleDistinct";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["field"] = ExpressionConverter.ConvertO(bodyfield);
                if (bodyfilter != null)
                {
                    body["filter"] = ExpressionConverter.ConvertO(bodyfilter);
                    bodypropCount++;
                }

                if (bodysortOrder != null)
                {
                    body["sortOrder"] = ExpressionConverter.ConvertO(bodysortOrder);
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
                    advancedOptionsObject["cultureName"] = ExpressionConverter.ConvertO(bodyadvancedOptionscultureName);
                    advancedOptionsObjectpropCount++;
                }

                if (bodyadvancedOptionsisBoolean != null)
                {
                    advancedOptionsObject["isBoolean"] = ExpressionConverter.ConvertO(bodyadvancedOptionsisBoolean);
                    advancedOptionsObjectpropCount++;
                }

                if (advancedOptionsObjectpropCount > 0)
                {
                    body["advancedOptions"] = advancedOptionsObject;
                    bodypropCount++;
                }

                if (bodydata != null)
                {
                    body["data"] = ExpressionConverter.ConvertO(bodydata);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        [WorkflowExpressionFactory(nameof(__BuildSortObjectArray))]
        public IBodyWorkflowAction<JToken[]> SortObjectArray([WorkflowExpression] Func<JToken[]> bodydata = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken[]> __BuildSortObjectArray(WorkflowValue<JToken[]> bodydata = null)
        {
            WorkflowValue.Validate(bodydata, nameof(bodydata), required: false);
            return new DeferredBodyAction<JToken[]>(() =>
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
                    body["data"] = ExpressionConverter.ConvertO(bodydata);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        [WorkflowExpressionFactory(nameof(__BuildSplit))]
        public IBodyWorkflowAction<JToken[]> Split([WorkflowExpression] Func<JToken[]> bodysplits, [WorkflowExpression] Func<string> bodyfilter = null, [WorkflowExpression] Func<string> bodyadvancedOptionscultureName = null, [WorkflowExpression] Func<string[]> bodyadvancedOptionsisBoolean = null, [WorkflowExpression] Func<JToken[]> bodydata = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken[]> __BuildSplit(WorkflowValue<JToken[]> bodysplits, WorkflowValue<string> bodyfilter = null, WorkflowValue<string> bodyadvancedOptionscultureName = null, WorkflowValue<string[]> bodyadvancedOptionsisBoolean = null, WorkflowValue<JToken[]> bodydata = null)
        {
            WorkflowValue.Validate(bodysplits, nameof(bodysplits), required: true);
            WorkflowValue.Validate(bodyfilter, nameof(bodyfilter), required: false);
            WorkflowValue.Validate(bodyadvancedOptionscultureName, nameof(bodyadvancedOptionscultureName), required: false);
            WorkflowValue.Validate(bodyadvancedOptionsisBoolean, nameof(bodyadvancedOptionsisBoolean), required: false);
            WorkflowValue.Validate(bodydata, nameof(bodydata), required: false);
            return new DeferredBodyAction<JToken[]>(() =>
            {
                var apiCallPath = "/Split";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["splits"] = ExpressionConverter.ConvertO(bodysplits);
                if (bodyfilter != null)
                {
                    body["filter"] = ExpressionConverter.ConvertO(bodyfilter);
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
                    advancedOptionsObject["cultureName"] = ExpressionConverter.ConvertO(bodyadvancedOptionscultureName);
                    advancedOptionsObjectpropCount++;
                }

                if (bodyadvancedOptionsisBoolean != null)
                {
                    advancedOptionsObject["isBoolean"] = ExpressionConverter.ConvertO(bodyadvancedOptionsisBoolean);
                    advancedOptionsObjectpropCount++;
                }

                if (advancedOptionsObjectpropCount > 0)
                {
                    body["advancedOptions"] = advancedOptionsObject;
                    bodypropCount++;
                }

                if (bodydata != null)
                {
                    body["data"] = ExpressionConverter.ConvertO(bodydata);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        [WorkflowExpressionFactory(nameof(__BuildTextToJson))]
        public IBodyWorkflowAction<JToken[]> TextToJson([WorkflowExpression] Func<string> bodydata, [WorkflowExpression] Func<bool> bodyheaderRow = null, [WorkflowExpression] Func<string> bodyrowSeparator = null, [WorkflowExpression] Func<string> bodydelimiter = null, [WorkflowExpression] Func<bodyencodingInput> bodyencoding = null, [WorkflowExpression] Func<string> bodyfilter = null, [WorkflowExpression] Func<string> bodyadvancedOptionscultureName = null, [WorkflowExpression] Func<string[]> bodyadvancedOptionsisBoolean = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken[]> __BuildTextToJson(WorkflowValue<string> bodydata, WorkflowValue<bool> bodyheaderRow = null, WorkflowValue<string> bodyrowSeparator = null, WorkflowValue<string> bodydelimiter = null, WorkflowValue<bodyencodingInput> bodyencoding = null, WorkflowValue<string> bodyfilter = null, WorkflowValue<string> bodyadvancedOptionscultureName = null, WorkflowValue<string[]> bodyadvancedOptionsisBoolean = null)
        {
            WorkflowValue.Validate(bodydata, nameof(bodydata), required: true);
            WorkflowValue.Validate(bodyheaderRow, nameof(bodyheaderRow), required: false);
            WorkflowValue.Validate(bodyrowSeparator, nameof(bodyrowSeparator), required: false);
            WorkflowValue.Validate(bodydelimiter, nameof(bodydelimiter), required: false);
            WorkflowValue.Validate(bodyencoding, nameof(bodyencoding), required: false);
            WorkflowValue.Validate(bodyfilter, nameof(bodyfilter), required: false);
            WorkflowValue.Validate(bodyadvancedOptionscultureName, nameof(bodyadvancedOptionscultureName), required: false);
            WorkflowValue.Validate(bodyadvancedOptionsisBoolean, nameof(bodyadvancedOptionsisBoolean), required: false);
            return new DeferredBodyAction<JToken[]>(() =>
            {
                var apiCallPath = "/TextToJson";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyheaderRow != null)
                {
                    body["headerRow"] = ExpressionConverter.ConvertO(bodyheaderRow);
                    bodypropCount++;
                }

                if (bodyrowSeparator != null)
                {
                    body["rowSeparator"] = ExpressionConverter.ConvertO(bodyrowSeparator);
                    bodypropCount++;
                }

                if (bodydelimiter != null)
                {
                    body["delimiter"] = ExpressionConverter.ConvertO(bodydelimiter);
                    bodypropCount++;
                }

                if (bodyencoding != null)
                {
                    body["encoding"] = ExpressionConverter.ConvertO(bodyencoding);
                    bodypropCount++;
                }

                if (bodyfilter != null)
                {
                    body["filter"] = ExpressionConverter.ConvertO(bodyfilter);
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
                    advancedOptionsObject["cultureName"] = ExpressionConverter.ConvertO(bodyadvancedOptionscultureName);
                    advancedOptionsObjectpropCount++;
                }

                if (bodyadvancedOptionsisBoolean != null)
                {
                    advancedOptionsObject["isBoolean"] = ExpressionConverter.ConvertO(bodyadvancedOptionsisBoolean);
                    advancedOptionsObjectpropCount++;
                }

                if (advancedOptionsObjectpropCount > 0)
                {
                    body["advancedOptions"] = advancedOptionsObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["data"] = ExpressionConverter.ConvertO(bodydata);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        [WorkflowExpressionFactory(nameof(__BuildTransform))]
        public IBodyWorkflowAction<JToken[]> Transform([WorkflowExpression] Func<bool> bodypreserveAllProperties = null, [WorkflowExpression] Func<string> bodyfilter = null, [WorkflowExpression] Func<string> bodyadvancedOptionscultureName = null, [WorkflowExpression] Func<string[]> bodyadvancedOptionsisBoolean = null, [WorkflowExpression] Func<JToken[]> bodydata = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken[]> __BuildTransform(WorkflowValue<bool> bodypreserveAllProperties = null, WorkflowValue<string> bodyfilter = null, WorkflowValue<string> bodyadvancedOptionscultureName = null, WorkflowValue<string[]> bodyadvancedOptionsisBoolean = null, WorkflowValue<JToken[]> bodydata = null)
        {
            WorkflowValue.Validate(bodypreserveAllProperties, nameof(bodypreserveAllProperties), required: false);
            WorkflowValue.Validate(bodyfilter, nameof(bodyfilter), required: false);
            WorkflowValue.Validate(bodyadvancedOptionscultureName, nameof(bodyadvancedOptionscultureName), required: false);
            WorkflowValue.Validate(bodyadvancedOptionsisBoolean, nameof(bodyadvancedOptionsisBoolean), required: false);
            WorkflowValue.Validate(bodydata, nameof(bodydata), required: false);
            return new DeferredBodyAction<JToken[]>(() =>
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
                    body["preserveAllProperties"] = ExpressionConverter.ConvertO(bodypreserveAllProperties);
                    bodypropCount++;
                }

                if (bodyfilter != null)
                {
                    body["filter"] = ExpressionConverter.ConvertO(bodyfilter);
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
                    advancedOptionsObject["cultureName"] = ExpressionConverter.ConvertO(bodyadvancedOptionscultureName);
                    advancedOptionsObjectpropCount++;
                }

                if (bodyadvancedOptionsisBoolean != null)
                {
                    advancedOptionsObject["isBoolean"] = ExpressionConverter.ConvertO(bodyadvancedOptionsisBoolean);
                    advancedOptionsObjectpropCount++;
                }

                if (advancedOptionsObjectpropCount > 0)
                {
                    body["advancedOptions"] = advancedOptionsObject;
                    bodypropCount++;
                }

                if (bodydata != null)
                {
                    body["data"] = ExpressionConverter.ConvertO(bodydata);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        [WorkflowExpressionFactory(nameof(__BuildXmlToJson))]
        public IBodyWorkflowAction<JToken[]> XmlToJson([WorkflowExpression] Func<string> bodydata, [WorkflowExpression] Func<string> bodyprimaryLoopAtElement = null, [WorkflowExpression] Func<bodysubLoopAtElementsInputItem[]> bodysubLoopAtElements = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken[]> __BuildXmlToJson(WorkflowValue<string> bodydata, WorkflowValue<string> bodyprimaryLoopAtElement = null, WorkflowValue<bodysubLoopAtElementsInputItem[]> bodysubLoopAtElements = null)
        {
            WorkflowValue.Validate(bodydata, nameof(bodydata), required: true);
            WorkflowValue.Validate(bodyprimaryLoopAtElement, nameof(bodyprimaryLoopAtElement), required: false);
            WorkflowValue.Validate(bodysubLoopAtElements, nameof(bodysubLoopAtElements), required: false);
            return new DeferredBodyAction<JToken[]>(() =>
            {
                var apiCallPath = "/XmlToJson";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyprimaryLoopAtElement != null)
                {
                    body["primaryLoopAtElement"] = ExpressionConverter.ConvertO(bodyprimaryLoopAtElement);
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
                    body["subLoopAtElements"] = ExpressionConverter.ConvertO(bodysubLoopAtElements);
                    bodypropCount++;
                }

                bodypropCount++;
                body["data"] = ExpressionConverter.ConvertO(bodydata);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        [WorkflowExpressionFactory(nameof(__BuildZipArchiveDecompress))]
        public IBodyWorkflowAction<ZipArchiveDecompressResponseItem[]> ZipArchiveDecompress([WorkflowExpression] Func<string> bodydata, [WorkflowExpression] Func<bool> bodygetFileContents, [WorkflowExpression] Func<string> bodyfilter = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ZipArchiveDecompressResponseItem[]> __BuildZipArchiveDecompress(WorkflowValue<string> bodydata, WorkflowValue<bool> bodygetFileContents, WorkflowValue<string> bodyfilter = null)
        {
            WorkflowValue.Validate(bodydata, nameof(bodydata), required: true);
            WorkflowValue.Validate(bodygetFileContents, nameof(bodygetFileContents), required: true);
            WorkflowValue.Validate(bodyfilter, nameof(bodyfilter), required: false);
            return new DeferredBodyAction<ZipArchiveDecompressResponseItem[]>(() =>
            {
                var apiCallPath = "/ZipArchiveDecompress";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["data"] = ExpressionConverter.ConvertO(bodydata);
                bodypropCount++;
                body["getFileContents"] = ExpressionConverter.ConvertO(bodygetFileContents);
                if (bodyfilter != null)
                {
                    body["filter"] = ExpressionConverter.ConvertO(bodyfilter);
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

                return new ApiConnectionAction<ZipArchiveDecompressResponseItem[]>(callPayload);
            });
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
