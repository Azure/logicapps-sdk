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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken[]> __BuildAggregate(WorkflowExpression<bodyaggregationTypeInput> bodyaggregationType, WorkflowExpression<string[]> bodyaggregateBy, WorkflowExpression<string[]> bodyaggregateOn, WorkflowExpression<string> bodyfilter = null, WorkflowExpression<string> bodyadvancedOptionscultureName = null, WorkflowExpression<string[]> bodyadvancedOptionsisBoolean = null, WorkflowExpression<JToken[]> bodydata = null)
        {
            WorkflowExpression.Validate(bodyaggregationType, nameof(bodyaggregationType), required: true);
            WorkflowExpression.Validate(bodyaggregateBy, nameof(bodyaggregateBy), required: true);
            WorkflowExpression.Validate(bodyaggregateOn, nameof(bodyaggregateOn), required: true);
            WorkflowExpression.Validate(bodyfilter, nameof(bodyfilter), required: false);
            WorkflowExpression.Validate(bodyadvancedOptionscultureName, nameof(bodyadvancedOptionscultureName), required: false);
            WorkflowExpression.Validate(bodyadvancedOptionsisBoolean, nameof(bodyadvancedOptionsisBoolean), required: false);
            WorkflowExpression.Validate(bodydata, nameof(bodydata), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken[]> __BuildCartesianJoin(WorkflowExpression<string> bodyfilter = null, WorkflowExpression<string> bodyadvancedOptionscultureName = null, WorkflowExpression<string[]> bodyadvancedOptionsisBoolean = null)
        {
            WorkflowExpression.Validate(bodyfilter, nameof(bodyfilter), required: false);
            WorkflowExpression.Validate(bodyadvancedOptionscultureName, nameof(bodyadvancedOptionscultureName), required: false);
            WorkflowExpression.Validate(bodyadvancedOptionsisBoolean, nameof(bodyadvancedOptionsisBoolean), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildConcatenate(WorkflowExpression<string> bodyfield, WorkflowExpression<string> bodyseparator = null, WorkflowExpression<bool> bodyignoreEmpty = null, WorkflowExpression<string> bodyfilter = null, WorkflowExpression<string> bodyadvancedOptionscultureName = null, WorkflowExpression<string[]> bodyadvancedOptionsisBoolean = null, WorkflowExpression<JToken[]> bodydata = null)
        {
            WorkflowExpression.Validate(bodyfield, nameof(bodyfield), required: true);
            WorkflowExpression.Validate(bodyseparator, nameof(bodyseparator), required: false);
            WorkflowExpression.Validate(bodyignoreEmpty, nameof(bodyignoreEmpty), required: false);
            WorkflowExpression.Validate(bodyfilter, nameof(bodyfilter), required: false);
            WorkflowExpression.Validate(bodyadvancedOptionscultureName, nameof(bodyadvancedOptionscultureName), required: false);
            WorkflowExpression.Validate(bodyadvancedOptionsisBoolean, nameof(bodyadvancedOptionsisBoolean), required: false);
            WorkflowExpression.Validate(bodydata, nameof(bodydata), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildCSharpEvaluate(WorkflowExpression<string> bodyexpression)
        {
            WorkflowExpression.Validate(bodyexpression, nameof(bodyexpression), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildCSharpScriptExecute(WorkflowExpression<string> bodyscript, WorkflowExpression<string[]> bodyclassDefinitions = null)
        {
            WorkflowExpression.Validate(bodyscript, nameof(bodyscript), required: true);
            WorkflowExpression.Validate(bodyclassDefinitions, nameof(bodyclassDefinitions), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken[]> __BuildCsvToJson(WorkflowExpression<string> bodydata, WorkflowExpression<bool> bodyheaderRow = null, WorkflowExpression<string> bodyrowSeparator = null, WorkflowExpression<string> bodydelimiter = null, WorkflowExpression<string> bodyescapeCharacter = null, WorkflowExpression<bodyencodingInput> bodyencoding = null, WorkflowExpression<string> bodyfilter = null, WorkflowExpression<string> bodyadvancedOptionscultureName = null, WorkflowExpression<string[]> bodyadvancedOptionsisBoolean = null)
        {
            WorkflowExpression.Validate(bodydata, nameof(bodydata), required: true);
            WorkflowExpression.Validate(bodyheaderRow, nameof(bodyheaderRow), required: false);
            WorkflowExpression.Validate(bodyrowSeparator, nameof(bodyrowSeparator), required: false);
            WorkflowExpression.Validate(bodydelimiter, nameof(bodydelimiter), required: false);
            WorkflowExpression.Validate(bodyescapeCharacter, nameof(bodyescapeCharacter), required: false);
            WorkflowExpression.Validate(bodyencoding, nameof(bodyencoding), required: false);
            WorkflowExpression.Validate(bodyfilter, nameof(bodyfilter), required: false);
            WorkflowExpression.Validate(bodyadvancedOptionscultureName, nameof(bodyadvancedOptionscultureName), required: false);
            WorkflowExpression.Validate(bodyadvancedOptionsisBoolean, nameof(bodyadvancedOptionsisBoolean), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDistinct(WorkflowExpression<string[]> bodyfields, WorkflowExpression<string> bodyfilter = null, WorkflowExpression<string> bodyadvancedOptionscultureName = null, WorkflowExpression<string[]> bodyadvancedOptionsisBoolean = null, WorkflowExpression<JToken[]> bodydata = null)
        {
            WorkflowExpression.Validate(bodyfields, nameof(bodyfields), required: true);
            WorkflowExpression.Validate(bodyfilter, nameof(bodyfilter), required: false);
            WorkflowExpression.Validate(bodyadvancedOptionscultureName, nameof(bodyadvancedOptionscultureName), required: false);
            WorkflowExpression.Validate(bodyadvancedOptionsisBoolean, nameof(bodyadvancedOptionsisBoolean), required: false);
            WorkflowExpression.Validate(bodydata, nameof(bodydata), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken[]> __BuildExpert(WorkflowExpression<string> bodyquery, WorkflowExpression<string> bodyadvancedOptionscultureName = null, WorkflowExpression<string[]> bodyadvancedOptionsisBoolean = null)
        {
            WorkflowExpression.Validate(bodyquery, nameof(bodyquery), required: true);
            WorkflowExpression.Validate(bodyadvancedOptionscultureName, nameof(bodyadvancedOptionscultureName), required: false);
            WorkflowExpression.Validate(bodyadvancedOptionsisBoolean, nameof(bodyadvancedOptionsisBoolean), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken[]> __BuildFilterObjectArray(WorkflowExpression<string> bodyfilter, WorkflowExpression<JToken[]> bodydata = null)
        {
            WorkflowExpression.Validate(bodyfilter, nameof(bodyfilter), required: true);
            WorkflowExpression.Validate(bodydata, nameof(bodydata), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken[]> __BuildFlattenObjectArray(WorkflowExpression<string> bodydelimiter, WorkflowExpression<bool> bodybalancedOutput, WorkflowExpression<string> bodyfilter = null, WorkflowExpression<string> bodyadvancedOptionscultureName = null, WorkflowExpression<string[]> bodyadvancedOptionsisBoolean = null, WorkflowExpression<JToken[]> bodydata = null)
        {
            WorkflowExpression.Validate(bodydelimiter, nameof(bodydelimiter), required: true);
            WorkflowExpression.Validate(bodybalancedOutput, nameof(bodybalancedOutput), required: true);
            WorkflowExpression.Validate(bodyfilter, nameof(bodyfilter), required: false);
            WorkflowExpression.Validate(bodyadvancedOptionscultureName, nameof(bodyadvancedOptionscultureName), required: false);
            WorkflowExpression.Validate(bodyadvancedOptionsisBoolean, nameof(bodyadvancedOptionsisBoolean), required: false);
            WorkflowExpression.Validate(bodydata, nameof(bodydata), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken[]> __BuildGetDataSchema(WorkflowExpression<string> bodyfilter = null, WorkflowExpression<string> bodyadvancedOptionscultureName = null, WorkflowExpression<string[]> bodyadvancedOptionsisBoolean = null, WorkflowExpression<JToken[]> bodydata = null)
        {
            WorkflowExpression.Validate(bodyfilter, nameof(bodyfilter), required: false);
            WorkflowExpression.Validate(bodyadvancedOptionscultureName, nameof(bodyadvancedOptionscultureName), required: false);
            WorkflowExpression.Validate(bodyadvancedOptionsisBoolean, nameof(bodyadvancedOptionsisBoolean), required: false);
            WorkflowExpression.Validate(bodydata, nameof(bodydata), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildGZipCompress(WorkflowExpression<string> bodydata)
        {
            WorkflowExpression.Validate(bodydata, nameof(bodydata), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildGZipDecompress(WorkflowExpression<string> bodydata)
        {
            WorkflowExpression.Validate(bodydata, nameof(bodydata), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken[]> __BuildJoin(WorkflowExpression<bodyjoinTypeInput> bodyjoinType, WorkflowExpression<string[]> bodyjoinFields, WorkflowExpression<string[]> bodyfields, WorkflowExpression<bool> bodyforceFullyQualifiedFieldNames = null, WorkflowExpression<string> bodyfilter = null, WorkflowExpression<string> bodyadvancedOptionscultureName = null, WorkflowExpression<string[]> bodyadvancedOptionsisBoolean = null)
        {
            WorkflowExpression.Validate(bodyjoinType, nameof(bodyjoinType), required: true);
            WorkflowExpression.Validate(bodyjoinFields, nameof(bodyjoinFields), required: true);
            WorkflowExpression.Validate(bodyfields, nameof(bodyfields), required: true);
            WorkflowExpression.Validate(bodyforceFullyQualifiedFieldNames, nameof(bodyforceFullyQualifiedFieldNames), required: false);
            WorkflowExpression.Validate(bodyfilter, nameof(bodyfilter), required: false);
            WorkflowExpression.Validate(bodyadvancedOptionscultureName, nameof(bodyadvancedOptionscultureName), required: false);
            WorkflowExpression.Validate(bodyadvancedOptionsisBoolean, nameof(bodyadvancedOptionsisBoolean), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken[]> __BuildJsonToTable(WorkflowExpression<string> bodypath = null, WorkflowExpression<bool> bodybalancedOutput = null, WorkflowExpression<string> bodyfilter = null, WorkflowExpression<string> bodyadvancedOptionscultureName = null, WorkflowExpression<string[]> bodyadvancedOptionsisBoolean = null)
        {
            WorkflowExpression.Validate(bodypath, nameof(bodypath), required: false);
            WorkflowExpression.Validate(bodybalancedOutput, nameof(bodybalancedOutput), required: false);
            WorkflowExpression.Validate(bodyfilter, nameof(bodyfilter), required: false);
            WorkflowExpression.Validate(bodyadvancedOptionscultureName, nameof(bodyadvancedOptionscultureName), required: false);
            WorkflowExpression.Validate(bodyadvancedOptionsisBoolean, nameof(bodyadvancedOptionsisBoolean), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildJsonToText(WorkflowExpression<bool> bodyheaderRow = null, WorkflowExpression<string> bodyrowSeparator = null, WorkflowExpression<string> bodyfilter = null, WorkflowExpression<string> bodyadvancedOptionscultureName = null, WorkflowExpression<string[]> bodyadvancedOptionsisBoolean = null, WorkflowExpression<JToken[]> bodydata = null)
        {
            WorkflowExpression.Validate(bodyheaderRow, nameof(bodyheaderRow), required: false);
            WorkflowExpression.Validate(bodyrowSeparator, nameof(bodyrowSeparator), required: false);
            WorkflowExpression.Validate(bodyfilter, nameof(bodyfilter), required: false);
            WorkflowExpression.Validate(bodyadvancedOptionscultureName, nameof(bodyadvancedOptionscultureName), required: false);
            WorkflowExpression.Validate(bodyadvancedOptionsisBoolean, nameof(bodyadvancedOptionsisBoolean), required: false);
            WorkflowExpression.Validate(bodydata, nameof(bodydata), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildJsonToCsv(WorkflowExpression<bool> bodyheaderRow = null, WorkflowExpression<string> bodyrowSeparator = null, WorkflowExpression<string> bodyescapeCharacter = null, WorkflowExpression<string> bodyfilter = null, WorkflowExpression<string> bodyadvancedOptionscultureName = null, WorkflowExpression<string[]> bodyadvancedOptionsisBoolean = null, WorkflowExpression<JToken[]> bodydata = null)
        {
            WorkflowExpression.Validate(bodyheaderRow, nameof(bodyheaderRow), required: false);
            WorkflowExpression.Validate(bodyrowSeparator, nameof(bodyrowSeparator), required: false);
            WorkflowExpression.Validate(bodyescapeCharacter, nameof(bodyescapeCharacter), required: false);
            WorkflowExpression.Validate(bodyfilter, nameof(bodyfilter), required: false);
            WorkflowExpression.Validate(bodyadvancedOptionscultureName, nameof(bodyadvancedOptionscultureName), required: false);
            WorkflowExpression.Validate(bodyadvancedOptionsisBoolean, nameof(bodyadvancedOptionsisBoolean), required: false);
            WorkflowExpression.Validate(bodydata, nameof(bodydata), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildJsonPropertiesToNameValuePairArray(WorkflowExpression<object> bodydata)
        {
            WorkflowExpression.Validate(bodydata, nameof(bodydata), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<LevenshteinDistanceResponse> __BuildLevenshteinDistance(WorkflowExpression<string> bodybaseValue, WorkflowExpression<string[]> bodycomparisonValues, WorkflowExpression<double> bodysettingsratioThreshold = null, WorkflowExpression<bodysettingsapplyRatioThresholdToInput> bodysettingsapplyRatioThresholdTo = null, WorkflowExpression<bodysettingsratioSelectionTypeInput> bodysettingsratioSelectionType = null, WorkflowExpression<bodysettingstokenSortTypeInput> bodysettingstokenSortType = null, WorkflowExpression<bool> bodysettingscaseSensitive = null, WorkflowExpression<bool> bodysettingsremoveWhitespace = null, WorkflowExpression<bool> bodysettingsremoveSpecialCharacters = null)
        {
            WorkflowExpression.Validate(bodybaseValue, nameof(bodybaseValue), required: true);
            WorkflowExpression.Validate(bodycomparisonValues, nameof(bodycomparisonValues), required: true);
            WorkflowExpression.Validate(bodysettingsratioThreshold, nameof(bodysettingsratioThreshold), required: false);
            WorkflowExpression.Validate(bodysettingsapplyRatioThresholdTo, nameof(bodysettingsapplyRatioThresholdTo), required: false);
            WorkflowExpression.Validate(bodysettingsratioSelectionType, nameof(bodysettingsratioSelectionType), required: false);
            WorkflowExpression.Validate(bodysettingstokenSortType, nameof(bodysettingstokenSortType), required: false);
            WorkflowExpression.Validate(bodysettingscaseSensitive, nameof(bodysettingscaseSensitive), required: false);
            WorkflowExpression.Validate(bodysettingsremoveWhitespace, nameof(bodysettingsremoveWhitespace), required: false);
            WorkflowExpression.Validate(bodysettingsremoveSpecialCharacters, nameof(bodysettingsremoveSpecialCharacters), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken[]> __BuildParquetToJson(WorkflowExpression<string> bodydata, WorkflowExpression<bool> bodyvalidateOnly = null, WorkflowExpression<int> bodyskip = null, WorkflowExpression<int> bodytake = null, WorkflowExpression<string> bodyfilter = null, WorkflowExpression<string> bodyadvancedOptionscultureName = null, WorkflowExpression<string[]> bodyadvancedOptionsisBoolean = null)
        {
            WorkflowExpression.Validate(bodydata, nameof(bodydata), required: true);
            WorkflowExpression.Validate(bodyvalidateOnly, nameof(bodyvalidateOnly), required: false);
            WorkflowExpression.Validate(bodyskip, nameof(bodyskip), required: false);
            WorkflowExpression.Validate(bodytake, nameof(bodytake), required: false);
            WorkflowExpression.Validate(bodyfilter, nameof(bodyfilter), required: false);
            WorkflowExpression.Validate(bodyadvancedOptionscultureName, nameof(bodyadvancedOptionscultureName), required: false);
            WorkflowExpression.Validate(bodyadvancedOptionsisBoolean, nameof(bodyadvancedOptionsisBoolean), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string[]> __BuildRegexMatches(WorkflowExpression<string> bodypattern, WorkflowExpression<string> bodydata, WorkflowExpression<string> bodyfilter = null, WorkflowExpression<string> bodyadvancedOptionscultureName = null, WorkflowExpression<string[]> bodyadvancedOptionsisBoolean = null)
        {
            WorkflowExpression.Validate(bodypattern, nameof(bodypattern), required: true);
            WorkflowExpression.Validate(bodydata, nameof(bodydata), required: true);
            WorkflowExpression.Validate(bodyfilter, nameof(bodyfilter), required: false);
            WorkflowExpression.Validate(bodyadvancedOptionscultureName, nameof(bodyadvancedOptionscultureName), required: false);
            WorkflowExpression.Validate(bodyadvancedOptionsisBoolean, nameof(bodyadvancedOptionsisBoolean), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildSimpleConcatenate(WorkflowExpression<string[]> bodydata, WorkflowExpression<string> bodyseparator = null, WorkflowExpression<bool> bodyignoreEmpty = null, WorkflowExpression<string> bodyfilter = null, WorkflowExpression<bodysortOrderInput> bodysortOrder = null, WorkflowExpression<string> bodyadvancedOptionscultureName = null, WorkflowExpression<string[]> bodyadvancedOptionsisBoolean = null)
        {
            WorkflowExpression.Validate(bodydata, nameof(bodydata), required: true);
            WorkflowExpression.Validate(bodyseparator, nameof(bodyseparator), required: false);
            WorkflowExpression.Validate(bodyignoreEmpty, nameof(bodyignoreEmpty), required: false);
            WorkflowExpression.Validate(bodyfilter, nameof(bodyfilter), required: false);
            WorkflowExpression.Validate(bodysortOrder, nameof(bodysortOrder), required: false);
            WorkflowExpression.Validate(bodyadvancedOptionscultureName, nameof(bodyadvancedOptionscultureName), required: false);
            WorkflowExpression.Validate(bodyadvancedOptionsisBoolean, nameof(bodyadvancedOptionsisBoolean), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSimpleDistinct(WorkflowExpression<string> bodyfield, WorkflowExpression<string> bodyfilter = null, WorkflowExpression<bodysortOrderInput> bodysortOrder = null, WorkflowExpression<string> bodyadvancedOptionscultureName = null, WorkflowExpression<string[]> bodyadvancedOptionsisBoolean = null, WorkflowExpression<JToken[]> bodydata = null)
        {
            WorkflowExpression.Validate(bodyfield, nameof(bodyfield), required: true);
            WorkflowExpression.Validate(bodyfilter, nameof(bodyfilter), required: false);
            WorkflowExpression.Validate(bodysortOrder, nameof(bodysortOrder), required: false);
            WorkflowExpression.Validate(bodyadvancedOptionscultureName, nameof(bodyadvancedOptionscultureName), required: false);
            WorkflowExpression.Validate(bodyadvancedOptionsisBoolean, nameof(bodyadvancedOptionsisBoolean), required: false);
            WorkflowExpression.Validate(bodydata, nameof(bodydata), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken[]> __BuildSortObjectArray(WorkflowExpression<JToken[]> bodydata = null)
        {
            WorkflowExpression.Validate(bodydata, nameof(bodydata), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken[]> __BuildSplit(WorkflowExpression<JToken[]> bodysplits, WorkflowExpression<string> bodyfilter = null, WorkflowExpression<string> bodyadvancedOptionscultureName = null, WorkflowExpression<string[]> bodyadvancedOptionsisBoolean = null, WorkflowExpression<JToken[]> bodydata = null)
        {
            WorkflowExpression.Validate(bodysplits, nameof(bodysplits), required: true);
            WorkflowExpression.Validate(bodyfilter, nameof(bodyfilter), required: false);
            WorkflowExpression.Validate(bodyadvancedOptionscultureName, nameof(bodyadvancedOptionscultureName), required: false);
            WorkflowExpression.Validate(bodyadvancedOptionsisBoolean, nameof(bodyadvancedOptionsisBoolean), required: false);
            WorkflowExpression.Validate(bodydata, nameof(bodydata), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken[]> __BuildTextToJson(WorkflowExpression<string> bodydata, WorkflowExpression<bool> bodyheaderRow = null, WorkflowExpression<string> bodyrowSeparator = null, WorkflowExpression<string> bodydelimiter = null, WorkflowExpression<bodyencodingInput> bodyencoding = null, WorkflowExpression<string> bodyfilter = null, WorkflowExpression<string> bodyadvancedOptionscultureName = null, WorkflowExpression<string[]> bodyadvancedOptionsisBoolean = null)
        {
            WorkflowExpression.Validate(bodydata, nameof(bodydata), required: true);
            WorkflowExpression.Validate(bodyheaderRow, nameof(bodyheaderRow), required: false);
            WorkflowExpression.Validate(bodyrowSeparator, nameof(bodyrowSeparator), required: false);
            WorkflowExpression.Validate(bodydelimiter, nameof(bodydelimiter), required: false);
            WorkflowExpression.Validate(bodyencoding, nameof(bodyencoding), required: false);
            WorkflowExpression.Validate(bodyfilter, nameof(bodyfilter), required: false);
            WorkflowExpression.Validate(bodyadvancedOptionscultureName, nameof(bodyadvancedOptionscultureName), required: false);
            WorkflowExpression.Validate(bodyadvancedOptionsisBoolean, nameof(bodyadvancedOptionsisBoolean), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken[]> __BuildTransform(WorkflowExpression<bool> bodypreserveAllProperties = null, WorkflowExpression<string> bodyfilter = null, WorkflowExpression<string> bodyadvancedOptionscultureName = null, WorkflowExpression<string[]> bodyadvancedOptionsisBoolean = null, WorkflowExpression<JToken[]> bodydata = null)
        {
            WorkflowExpression.Validate(bodypreserveAllProperties, nameof(bodypreserveAllProperties), required: false);
            WorkflowExpression.Validate(bodyfilter, nameof(bodyfilter), required: false);
            WorkflowExpression.Validate(bodyadvancedOptionscultureName, nameof(bodyadvancedOptionscultureName), required: false);
            WorkflowExpression.Validate(bodyadvancedOptionsisBoolean, nameof(bodyadvancedOptionsisBoolean), required: false);
            WorkflowExpression.Validate(bodydata, nameof(bodydata), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken[]> __BuildXmlToJson(WorkflowExpression<string> bodydata, WorkflowExpression<string> bodyprimaryLoopAtElement = null, WorkflowExpression<bodysubLoopAtElementsInputItem[]> bodysubLoopAtElements = null)
        {
            WorkflowExpression.Validate(bodydata, nameof(bodydata), required: true);
            WorkflowExpression.Validate(bodyprimaryLoopAtElement, nameof(bodyprimaryLoopAtElement), required: false);
            WorkflowExpression.Validate(bodysubLoopAtElements, nameof(bodysubLoopAtElements), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ZipArchiveDecompressResponseItem[]> __BuildZipArchiveDecompress(WorkflowExpression<string> bodydata, WorkflowExpression<bool> bodygetFileContents, WorkflowExpression<string> bodyfilter = null)
        {
            WorkflowExpression.Validate(bodydata, nameof(bodydata), required: true);
            WorkflowExpression.Validate(bodygetFileContents, nameof(bodygetFileContents), required: true);
            WorkflowExpression.Validate(bodyfilter, nameof(bodyfilter), required: false);
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyaggregationTypeInput
    {
        AVG,
        SUM,
        COUNT,
        MAX,
        MIN
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyencodingInput
    {
        ASCII,
        UTF8,
        UTF16LittleEndian,
        UTF16BigEndian,
        [EnumMember(Value = "ISO-8859-1")]
        ISO88591
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodysettingsapplyRatioThresholdToInput
    {
        Max,
        Avg
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodysettingsratioSelectionTypeInput
    {
        All,
        Standard,
        Partial
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodysettingstokenSortTypeInput
    {
        All,
        [EnumMember(Value = "Not Sorted")]
        NotSorted,
        Sorted
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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