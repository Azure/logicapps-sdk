//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Advanceddataoperatio
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AdvanceddataoperatioActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<JToken[]> Aggregate(Expression<Func<bodyaggregationTypeInput>> bodyaggregationType, Expression<Func<string[]>> bodyaggregateBy, Expression<Func<string[]>> bodyaggregateOn, Expression<Func<string>> bodyfilter = null, Expression<Func<string>> bodyadvancedOptionscultureName = null, Expression<Func<string[]>> bodyadvancedOptionsisBoolean = null, Expression<Func<JToken[]>> bodydata = null)
        {
            var __workflow_bodyaggregationType = WorkflowExpression.Compile(bodyaggregationType, nameof(bodyaggregationType), required: true);
            var __workflow_bodyaggregateBy = WorkflowExpression.Compile(bodyaggregateBy, nameof(bodyaggregateBy), required: true);
            var __workflow_bodyaggregateOn = WorkflowExpression.Compile(bodyaggregateOn, nameof(bodyaggregateOn), required: true);
            var __workflow_bodyfilter = WorkflowExpression.Compile(bodyfilter, nameof(bodyfilter), required: false);
            var __workflow_bodyadvancedOptionscultureName = WorkflowExpression.Compile(bodyadvancedOptionscultureName, nameof(bodyadvancedOptionscultureName), required: false);
            var __workflow_bodyadvancedOptionsisBoolean = WorkflowExpression.Compile(bodyadvancedOptionsisBoolean, nameof(bodyadvancedOptionsisBoolean), required: false);
            var __workflow_bodydata = WorkflowExpression.Compile(bodydata, nameof(bodydata), required: false);
            return new DeferredBodyAction<JToken[]>(() =>
            {
                var apiCallPath = "/Aggregate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["aggregationType"] = ExpressionConverter.ConvertO(__workflow_bodyaggregationType);
                bodypropCount++;
                body["aggregateBy"] = ExpressionConverter.ConvertO(__workflow_bodyaggregateBy);
                bodypropCount++;
                body["aggregateOn"] = ExpressionConverter.ConvertO(__workflow_bodyaggregateOn);
                if (__workflow_bodyfilter != null)
                {
                    body["filter"] = ExpressionConverter.ConvertO(__workflow_bodyfilter);
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
                if (__workflow_bodyadvancedOptionscultureName != null)
                {
                    advancedOptionsObject["cultureName"] = ExpressionConverter.ConvertO(__workflow_bodyadvancedOptionscultureName);
                    advancedOptionsObjectpropCount++;
                }

                if (__workflow_bodyadvancedOptionsisBoolean != null)
                {
                    advancedOptionsObject["isBoolean"] = ExpressionConverter.ConvertO(__workflow_bodyadvancedOptionsisBoolean);
                    advancedOptionsObjectpropCount++;
                }

                if (advancedOptionsObjectpropCount > 0)
                {
                    body["advancedOptions"] = advancedOptionsObject;
                    bodypropCount++;
                }

                if (__workflow_bodydata != null)
                {
                    body["data"] = ExpressionConverter.ConvertO(__workflow_bodydata);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken[]>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<JToken[]> CartesianJoin(Expression<Func<string>> bodyfilter = null, Expression<Func<string>> bodyadvancedOptionscultureName = null, Expression<Func<string[]>> bodyadvancedOptionsisBoolean = null)
        {
            var __workflow_bodyfilter = WorkflowExpression.Compile(bodyfilter, nameof(bodyfilter), required: false);
            var __workflow_bodyadvancedOptionscultureName = WorkflowExpression.Compile(bodyadvancedOptionscultureName, nameof(bodyadvancedOptionscultureName), required: false);
            var __workflow_bodyadvancedOptionsisBoolean = WorkflowExpression.Compile(bodyadvancedOptionsisBoolean, nameof(bodyadvancedOptionsisBoolean), required: false);
            return new DeferredBodyAction<JToken[]>(() =>
            {
                var apiCallPath = "/CartesianJoin";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfilter != null)
                {
                    body["filter"] = ExpressionConverter.ConvertO(__workflow_bodyfilter);
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
                if (__workflow_bodyadvancedOptionscultureName != null)
                {
                    advancedOptionsObject["cultureName"] = ExpressionConverter.ConvertO(__workflow_bodyadvancedOptionscultureName);
                    advancedOptionsObjectpropCount++;
                }

                if (__workflow_bodyadvancedOptionsisBoolean != null)
                {
                    advancedOptionsObject["isBoolean"] = ExpressionConverter.ConvertO(__workflow_bodyadvancedOptionsisBoolean);
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
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<string> Concatenate(Expression<Func<string>> bodyfield, Expression<Func<string>> bodyseparator = null, Expression<Func<bool>> bodyignoreEmpty = null, Expression<Func<string>> bodyfilter = null, Expression<Func<string>> bodyadvancedOptionscultureName = null, Expression<Func<string[]>> bodyadvancedOptionsisBoolean = null, Expression<Func<JToken[]>> bodydata = null)
        {
            var __workflow_bodyfield = WorkflowExpression.Compile(bodyfield, nameof(bodyfield), required: true);
            var __workflow_bodyseparator = WorkflowExpression.Compile(bodyseparator, nameof(bodyseparator), required: false);
            var __workflow_bodyignoreEmpty = WorkflowExpression.Compile(bodyignoreEmpty, nameof(bodyignoreEmpty), required: false);
            var __workflow_bodyfilter = WorkflowExpression.Compile(bodyfilter, nameof(bodyfilter), required: false);
            var __workflow_bodyadvancedOptionscultureName = WorkflowExpression.Compile(bodyadvancedOptionscultureName, nameof(bodyadvancedOptionscultureName), required: false);
            var __workflow_bodyadvancedOptionsisBoolean = WorkflowExpression.Compile(bodyadvancedOptionsisBoolean, nameof(bodyadvancedOptionsisBoolean), required: false);
            var __workflow_bodydata = WorkflowExpression.Compile(bodydata, nameof(bodydata), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/Concatenate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["field"] = ExpressionConverter.ConvertO(__workflow_bodyfield);
                if (__workflow_bodyseparator != null)
                {
                    body["separator"] = ExpressionConverter.ConvertO(__workflow_bodyseparator);
                    bodypropCount++;
                }

                if (__workflow_bodyignoreEmpty != null)
                {
                    body["ignoreEmpty"] = ExpressionConverter.ConvertO(__workflow_bodyignoreEmpty);
                    bodypropCount++;
                }

                if (__workflow_bodyfilter != null)
                {
                    body["filter"] = ExpressionConverter.ConvertO(__workflow_bodyfilter);
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
                if (__workflow_bodyadvancedOptionscultureName != null)
                {
                    advancedOptionsObject["cultureName"] = ExpressionConverter.ConvertO(__workflow_bodyadvancedOptionscultureName);
                    advancedOptionsObjectpropCount++;
                }

                if (__workflow_bodyadvancedOptionsisBoolean != null)
                {
                    advancedOptionsObject["isBoolean"] = ExpressionConverter.ConvertO(__workflow_bodyadvancedOptionsisBoolean);
                    advancedOptionsObjectpropCount++;
                }

                if (advancedOptionsObjectpropCount > 0)
                {
                    body["advancedOptions"] = advancedOptionsObject;
                    bodypropCount++;
                }

                if (__workflow_bodydata != null)
                {
                    body["data"] = ExpressionConverter.ConvertO(__workflow_bodydata);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<JToken> CSharpEvaluate(Expression<Func<string>> bodyexpression)
        {
            var __workflow_bodyexpression = WorkflowExpression.Compile(bodyexpression, nameof(bodyexpression), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/CSharpEvaluate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["expression"] = ExpressionConverter.ConvertO(__workflow_bodyexpression);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<JToken> CSharpScriptExecute(Expression<Func<string>> bodyscript, Expression<Func<string[]>> bodyclassDefinitions = null)
        {
            var __workflow_bodyscript = WorkflowExpression.Compile(bodyscript, nameof(bodyscript), required: true);
            var __workflow_bodyclassDefinitions = WorkflowExpression.Compile(bodyclassDefinitions, nameof(bodyclassDefinitions), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/CSharpScriptExecute";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["script"] = ExpressionConverter.ConvertO(__workflow_bodyscript);
                if (__workflow_bodyclassDefinitions != null)
                {
                    body["classDefinitions"] = ExpressionConverter.ConvertO(__workflow_bodyclassDefinitions);
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
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<JToken[]> CsvToJson(Expression<Func<string>> bodydata, Expression<Func<bool>> bodyheaderRow = null, Expression<Func<string>> bodyrowSeparator = null, Expression<Func<string>> bodydelimiter = null, Expression<Func<string>> bodyescapeCharacter = null, Expression<Func<bodyencodingInput>> bodyencoding = null, Expression<Func<string>> bodyfilter = null, Expression<Func<string>> bodyadvancedOptionscultureName = null, Expression<Func<string[]>> bodyadvancedOptionsisBoolean = null)
        {
            var __workflow_bodydata = WorkflowExpression.Compile(bodydata, nameof(bodydata), required: true);
            var __workflow_bodyheaderRow = WorkflowExpression.Compile(bodyheaderRow, nameof(bodyheaderRow), required: false);
            var __workflow_bodyrowSeparator = WorkflowExpression.Compile(bodyrowSeparator, nameof(bodyrowSeparator), required: false);
            var __workflow_bodydelimiter = WorkflowExpression.Compile(bodydelimiter, nameof(bodydelimiter), required: false);
            var __workflow_bodyescapeCharacter = WorkflowExpression.Compile(bodyescapeCharacter, nameof(bodyescapeCharacter), required: false);
            var __workflow_bodyencoding = WorkflowExpression.Compile(bodyencoding, nameof(bodyencoding), required: false);
            var __workflow_bodyfilter = WorkflowExpression.Compile(bodyfilter, nameof(bodyfilter), required: false);
            var __workflow_bodyadvancedOptionscultureName = WorkflowExpression.Compile(bodyadvancedOptionscultureName, nameof(bodyadvancedOptionscultureName), required: false);
            var __workflow_bodyadvancedOptionsisBoolean = WorkflowExpression.Compile(bodyadvancedOptionsisBoolean, nameof(bodyadvancedOptionsisBoolean), required: false);
            return new DeferredBodyAction<JToken[]>(() =>
            {
                var apiCallPath = "/CsvToJson";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyheaderRow != null)
                {
                    body["headerRow"] = ExpressionConverter.ConvertO(__workflow_bodyheaderRow);
                    bodypropCount++;
                }

                if (__workflow_bodyrowSeparator != null)
                {
                    body["rowSeparator"] = ExpressionConverter.ConvertO(__workflow_bodyrowSeparator);
                    bodypropCount++;
                }

                if (__workflow_bodydelimiter != null)
                {
                    body["delimiter"] = ExpressionConverter.ConvertO(__workflow_bodydelimiter);
                    bodypropCount++;
                }

                if (__workflow_bodyescapeCharacter != null)
                {
                    body["escapeCharacter"] = ExpressionConverter.ConvertO(__workflow_bodyescapeCharacter);
                    bodypropCount++;
                }

                if (__workflow_bodyencoding != null)
                {
                    body["encoding"] = ExpressionConverter.ConvertO(__workflow_bodyencoding);
                    bodypropCount++;
                }

                if (__workflow_bodyfilter != null)
                {
                    body["filter"] = ExpressionConverter.ConvertO(__workflow_bodyfilter);
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
                if (__workflow_bodyadvancedOptionscultureName != null)
                {
                    advancedOptionsObject["cultureName"] = ExpressionConverter.ConvertO(__workflow_bodyadvancedOptionscultureName);
                    advancedOptionsObjectpropCount++;
                }

                if (__workflow_bodyadvancedOptionsisBoolean != null)
                {
                    advancedOptionsObject["isBoolean"] = ExpressionConverter.ConvertO(__workflow_bodyadvancedOptionsisBoolean);
                    advancedOptionsObjectpropCount++;
                }

                if (advancedOptionsObjectpropCount > 0)
                {
                    body["advancedOptions"] = advancedOptionsObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["data"] = ExpressionConverter.ConvertO(__workflow_bodydata);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken[]>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IWorkflowAction Distinct(Expression<Func<string[]>> bodyfields, Expression<Func<string>> bodyfilter = null, Expression<Func<string>> bodyadvancedOptionscultureName = null, Expression<Func<string[]>> bodyadvancedOptionsisBoolean = null, Expression<Func<JToken[]>> bodydata = null)
        {
            var __workflow_bodyfields = WorkflowExpression.Compile(bodyfields, nameof(bodyfields), required: true);
            var __workflow_bodyfilter = WorkflowExpression.Compile(bodyfilter, nameof(bodyfilter), required: false);
            var __workflow_bodyadvancedOptionscultureName = WorkflowExpression.Compile(bodyadvancedOptionscultureName, nameof(bodyadvancedOptionscultureName), required: false);
            var __workflow_bodyadvancedOptionsisBoolean = WorkflowExpression.Compile(bodyadvancedOptionsisBoolean, nameof(bodyadvancedOptionsisBoolean), required: false);
            var __workflow_bodydata = WorkflowExpression.Compile(bodydata, nameof(bodydata), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Distinct";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["fields"] = ExpressionConverter.ConvertO(__workflow_bodyfields);
                if (__workflow_bodyfilter != null)
                {
                    body["filter"] = ExpressionConverter.ConvertO(__workflow_bodyfilter);
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
                if (__workflow_bodyadvancedOptionscultureName != null)
                {
                    advancedOptionsObject["cultureName"] = ExpressionConverter.ConvertO(__workflow_bodyadvancedOptionscultureName);
                    advancedOptionsObjectpropCount++;
                }

                if (__workflow_bodyadvancedOptionsisBoolean != null)
                {
                    advancedOptionsObject["isBoolean"] = ExpressionConverter.ConvertO(__workflow_bodyadvancedOptionsisBoolean);
                    advancedOptionsObjectpropCount++;
                }

                if (advancedOptionsObjectpropCount > 0)
                {
                    body["advancedOptions"] = advancedOptionsObject;
                    bodypropCount++;
                }

                if (__workflow_bodydata != null)
                {
                    body["data"] = ExpressionConverter.ConvertO(__workflow_bodydata);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<JToken[]> Expert(Expression<Func<string>> bodyquery, Expression<Func<string>> bodyadvancedOptionscultureName = null, Expression<Func<string[]>> bodyadvancedOptionsisBoolean = null)
        {
            var __workflow_bodyquery = WorkflowExpression.Compile(bodyquery, nameof(bodyquery), required: true);
            var __workflow_bodyadvancedOptionscultureName = WorkflowExpression.Compile(bodyadvancedOptionscultureName, nameof(bodyadvancedOptionscultureName), required: false);
            var __workflow_bodyadvancedOptionsisBoolean = WorkflowExpression.Compile(bodyadvancedOptionsisBoolean, nameof(bodyadvancedOptionsisBoolean), required: false);
            return new DeferredBodyAction<JToken[]>(() =>
            {
                var apiCallPath = "/Expert";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["query"] = ExpressionConverter.ConvertO(__workflow_bodyquery);
                var schemaObject = new JObject();
                var schemaObjectpropCount = 0;
                if (schemaObjectpropCount > 0)
                {
                    body["schema"] = schemaObject;
                    bodypropCount++;
                }

                var advancedOptionsObject = new JObject();
                var advancedOptionsObjectpropCount = 0;
                if (__workflow_bodyadvancedOptionscultureName != null)
                {
                    advancedOptionsObject["cultureName"] = ExpressionConverter.ConvertO(__workflow_bodyadvancedOptionscultureName);
                    advancedOptionsObjectpropCount++;
                }

                if (__workflow_bodyadvancedOptionsisBoolean != null)
                {
                    advancedOptionsObject["isBoolean"] = ExpressionConverter.ConvertO(__workflow_bodyadvancedOptionsisBoolean);
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
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<JToken[]> FilterObjectArray(Expression<Func<string>> bodyfilter, Expression<Func<JToken[]>> bodydata = null)
        {
            var __workflow_bodyfilter = WorkflowExpression.Compile(bodyfilter, nameof(bodyfilter), required: true);
            var __workflow_bodydata = WorkflowExpression.Compile(bodydata, nameof(bodydata), required: false);
            return new DeferredBodyAction<JToken[]>(() =>
            {
                var apiCallPath = "/FilterObjectArray";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["filter"] = ExpressionConverter.ConvertO(__workflow_bodyfilter);
                if (__workflow_bodydata != null)
                {
                    body["data"] = ExpressionConverter.ConvertO(__workflow_bodydata);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken[]>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<JToken[]> FlattenObjectArray(Expression<Func<string>> bodydelimiter, Expression<Func<bool>> bodybalancedOutput, Expression<Func<string>> bodyfilter = null, Expression<Func<string>> bodyadvancedOptionscultureName = null, Expression<Func<string[]>> bodyadvancedOptionsisBoolean = null, Expression<Func<JToken[]>> bodydata = null)
        {
            var __workflow_bodydelimiter = WorkflowExpression.Compile(bodydelimiter, nameof(bodydelimiter), required: true);
            var __workflow_bodybalancedOutput = WorkflowExpression.Compile(bodybalancedOutput, nameof(bodybalancedOutput), required: true);
            var __workflow_bodyfilter = WorkflowExpression.Compile(bodyfilter, nameof(bodyfilter), required: false);
            var __workflow_bodyadvancedOptionscultureName = WorkflowExpression.Compile(bodyadvancedOptionscultureName, nameof(bodyadvancedOptionscultureName), required: false);
            var __workflow_bodyadvancedOptionsisBoolean = WorkflowExpression.Compile(bodyadvancedOptionsisBoolean, nameof(bodyadvancedOptionsisBoolean), required: false);
            var __workflow_bodydata = WorkflowExpression.Compile(bodydata, nameof(bodydata), required: false);
            return new DeferredBodyAction<JToken[]>(() =>
            {
                var apiCallPath = "/FlattenObjectArray";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["delimiter"] = ExpressionConverter.ConvertO(__workflow_bodydelimiter);
                bodypropCount++;
                body["balancedOutput"] = ExpressionConverter.ConvertO(__workflow_bodybalancedOutput);
                if (__workflow_bodyfilter != null)
                {
                    body["filter"] = ExpressionConverter.ConvertO(__workflow_bodyfilter);
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
                if (__workflow_bodyadvancedOptionscultureName != null)
                {
                    advancedOptionsObject["cultureName"] = ExpressionConverter.ConvertO(__workflow_bodyadvancedOptionscultureName);
                    advancedOptionsObjectpropCount++;
                }

                if (__workflow_bodyadvancedOptionsisBoolean != null)
                {
                    advancedOptionsObject["isBoolean"] = ExpressionConverter.ConvertO(__workflow_bodyadvancedOptionsisBoolean);
                    advancedOptionsObjectpropCount++;
                }

                if (advancedOptionsObjectpropCount > 0)
                {
                    body["advancedOptions"] = advancedOptionsObject;
                    bodypropCount++;
                }

                if (__workflow_bodydata != null)
                {
                    body["data"] = ExpressionConverter.ConvertO(__workflow_bodydata);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken[]>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<JToken[]> GetDataSchema(Expression<Func<string>> bodyfilter = null, Expression<Func<string>> bodyadvancedOptionscultureName = null, Expression<Func<string[]>> bodyadvancedOptionsisBoolean = null, Expression<Func<JToken[]>> bodydata = null)
        {
            var __workflow_bodyfilter = WorkflowExpression.Compile(bodyfilter, nameof(bodyfilter), required: false);
            var __workflow_bodyadvancedOptionscultureName = WorkflowExpression.Compile(bodyadvancedOptionscultureName, nameof(bodyadvancedOptionscultureName), required: false);
            var __workflow_bodyadvancedOptionsisBoolean = WorkflowExpression.Compile(bodyadvancedOptionsisBoolean, nameof(bodyadvancedOptionsisBoolean), required: false);
            var __workflow_bodydata = WorkflowExpression.Compile(bodydata, nameof(bodydata), required: false);
            return new DeferredBodyAction<JToken[]>(() =>
            {
                var apiCallPath = "/GetDataSchema";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfilter != null)
                {
                    body["filter"] = ExpressionConverter.ConvertO(__workflow_bodyfilter);
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
                if (__workflow_bodyadvancedOptionscultureName != null)
                {
                    advancedOptionsObject["cultureName"] = ExpressionConverter.ConvertO(__workflow_bodyadvancedOptionscultureName);
                    advancedOptionsObjectpropCount++;
                }

                if (__workflow_bodyadvancedOptionsisBoolean != null)
                {
                    advancedOptionsObject["isBoolean"] = ExpressionConverter.ConvertO(__workflow_bodyadvancedOptionsisBoolean);
                    advancedOptionsObjectpropCount++;
                }

                if (advancedOptionsObjectpropCount > 0)
                {
                    body["advancedOptions"] = advancedOptionsObject;
                    bodypropCount++;
                }

                if (__workflow_bodydata != null)
                {
                    body["data"] = ExpressionConverter.ConvertO(__workflow_bodydata);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken[]>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<string> GZipCompress(Expression<Func<string>> bodydata)
        {
            var __workflow_bodydata = WorkflowExpression.Compile(bodydata, nameof(bodydata), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/GZipCompress";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["data"] = ExpressionConverter.ConvertO(__workflow_bodydata);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<string> GZipDecompress(Expression<Func<string>> bodydata)
        {
            var __workflow_bodydata = WorkflowExpression.Compile(bodydata, nameof(bodydata), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/GZipDecompress";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["data"] = ExpressionConverter.ConvertO(__workflow_bodydata);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<JToken[]> Join(Expression<Func<bodyjoinTypeInput>> bodyjoinType, Expression<Func<string[]>> bodyjoinFields, Expression<Func<string[]>> bodyfields, Expression<Func<bool>> bodyforceFullyQualifiedFieldNames = null, Expression<Func<string>> bodyfilter = null, Expression<Func<string>> bodyadvancedOptionscultureName = null, Expression<Func<string[]>> bodyadvancedOptionsisBoolean = null)
        {
            var __workflow_bodyjoinType = WorkflowExpression.Compile(bodyjoinType, nameof(bodyjoinType), required: true);
            var __workflow_bodyjoinFields = WorkflowExpression.Compile(bodyjoinFields, nameof(bodyjoinFields), required: true);
            var __workflow_bodyfields = WorkflowExpression.Compile(bodyfields, nameof(bodyfields), required: true);
            var __workflow_bodyforceFullyQualifiedFieldNames = WorkflowExpression.Compile(bodyforceFullyQualifiedFieldNames, nameof(bodyforceFullyQualifiedFieldNames), required: false);
            var __workflow_bodyfilter = WorkflowExpression.Compile(bodyfilter, nameof(bodyfilter), required: false);
            var __workflow_bodyadvancedOptionscultureName = WorkflowExpression.Compile(bodyadvancedOptionscultureName, nameof(bodyadvancedOptionscultureName), required: false);
            var __workflow_bodyadvancedOptionsisBoolean = WorkflowExpression.Compile(bodyadvancedOptionsisBoolean, nameof(bodyadvancedOptionsisBoolean), required: false);
            return new DeferredBodyAction<JToken[]>(() =>
            {
                var apiCallPath = "/Join";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["joinType"] = ExpressionConverter.ConvertO(__workflow_bodyjoinType);
                bodypropCount++;
                body["joinFields"] = ExpressionConverter.ConvertO(__workflow_bodyjoinFields);
                bodypropCount++;
                body["fields"] = ExpressionConverter.ConvertO(__workflow_bodyfields);
                if (__workflow_bodyforceFullyQualifiedFieldNames != null)
                {
                    body["forceFullyQualifiedFieldNames"] = ExpressionConverter.ConvertO(__workflow_bodyforceFullyQualifiedFieldNames);
                    bodypropCount++;
                }

                if (__workflow_bodyfilter != null)
                {
                    body["filter"] = ExpressionConverter.ConvertO(__workflow_bodyfilter);
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
                if (__workflow_bodyadvancedOptionscultureName != null)
                {
                    advancedOptionsObject["cultureName"] = ExpressionConverter.ConvertO(__workflow_bodyadvancedOptionscultureName);
                    advancedOptionsObjectpropCount++;
                }

                if (__workflow_bodyadvancedOptionsisBoolean != null)
                {
                    advancedOptionsObject["isBoolean"] = ExpressionConverter.ConvertO(__workflow_bodyadvancedOptionsisBoolean);
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
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
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
        public IBodyWorkflowAction<JToken[]> JsonToTable(Expression<Func<string>> bodypath = null, Expression<Func<bool>> bodybalancedOutput = null, Expression<Func<string>> bodyfilter = null, Expression<Func<string>> bodyadvancedOptionscultureName = null, Expression<Func<string[]>> bodyadvancedOptionsisBoolean = null)
        {
            var __workflow_bodypath = WorkflowExpression.Compile(bodypath, nameof(bodypath), required: false);
            var __workflow_bodybalancedOutput = WorkflowExpression.Compile(bodybalancedOutput, nameof(bodybalancedOutput), required: false);
            var __workflow_bodyfilter = WorkflowExpression.Compile(bodyfilter, nameof(bodyfilter), required: false);
            var __workflow_bodyadvancedOptionscultureName = WorkflowExpression.Compile(bodyadvancedOptionscultureName, nameof(bodyadvancedOptionscultureName), required: false);
            var __workflow_bodyadvancedOptionsisBoolean = WorkflowExpression.Compile(bodyadvancedOptionsisBoolean, nameof(bodyadvancedOptionsisBoolean), required: false);
            return new DeferredBodyAction<JToken[]>(() =>
            {
                var apiCallPath = "/JsonToTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodypath != null)
                {
                    body["path"] = ExpressionConverter.ConvertO(__workflow_bodypath);
                    bodypropCount++;
                }

                if (__workflow_bodybalancedOutput != null)
                {
                    body["balancedOutput"] = ExpressionConverter.ConvertO(__workflow_bodybalancedOutput);
                    bodypropCount++;
                }

                if (__workflow_bodyfilter != null)
                {
                    body["filter"] = ExpressionConverter.ConvertO(__workflow_bodyfilter);
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
                if (__workflow_bodyadvancedOptionscultureName != null)
                {
                    advancedOptionsObject["cultureName"] = ExpressionConverter.ConvertO(__workflow_bodyadvancedOptionscultureName);
                    advancedOptionsObjectpropCount++;
                }

                if (__workflow_bodyadvancedOptionsisBoolean != null)
                {
                    advancedOptionsObject["isBoolean"] = ExpressionConverter.ConvertO(__workflow_bodyadvancedOptionsisBoolean);
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
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<string> JsonToText(Expression<Func<bool>> bodyheaderRow = null, Expression<Func<string>> bodyrowSeparator = null, Expression<Func<string>> bodyfilter = null, Expression<Func<string>> bodyadvancedOptionscultureName = null, Expression<Func<string[]>> bodyadvancedOptionsisBoolean = null, Expression<Func<JToken[]>> bodydata = null)
        {
            var __workflow_bodyheaderRow = WorkflowExpression.Compile(bodyheaderRow, nameof(bodyheaderRow), required: false);
            var __workflow_bodyrowSeparator = WorkflowExpression.Compile(bodyrowSeparator, nameof(bodyrowSeparator), required: false);
            var __workflow_bodyfilter = WorkflowExpression.Compile(bodyfilter, nameof(bodyfilter), required: false);
            var __workflow_bodyadvancedOptionscultureName = WorkflowExpression.Compile(bodyadvancedOptionscultureName, nameof(bodyadvancedOptionscultureName), required: false);
            var __workflow_bodyadvancedOptionsisBoolean = WorkflowExpression.Compile(bodyadvancedOptionsisBoolean, nameof(bodyadvancedOptionsisBoolean), required: false);
            var __workflow_bodydata = WorkflowExpression.Compile(bodydata, nameof(bodydata), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/JsonToText";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyheaderRow != null)
                {
                    body["headerRow"] = ExpressionConverter.ConvertO(__workflow_bodyheaderRow);
                    bodypropCount++;
                }

                if (__workflow_bodyrowSeparator != null)
                {
                    body["rowSeparator"] = ExpressionConverter.ConvertO(__workflow_bodyrowSeparator);
                    bodypropCount++;
                }

                if (__workflow_bodyfilter != null)
                {
                    body["filter"] = ExpressionConverter.ConvertO(__workflow_bodyfilter);
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
                if (__workflow_bodyadvancedOptionscultureName != null)
                {
                    advancedOptionsObject["cultureName"] = ExpressionConverter.ConvertO(__workflow_bodyadvancedOptionscultureName);
                    advancedOptionsObjectpropCount++;
                }

                if (__workflow_bodyadvancedOptionsisBoolean != null)
                {
                    advancedOptionsObject["isBoolean"] = ExpressionConverter.ConvertO(__workflow_bodyadvancedOptionsisBoolean);
                    advancedOptionsObjectpropCount++;
                }

                if (advancedOptionsObjectpropCount > 0)
                {
                    body["advancedOptions"] = advancedOptionsObject;
                    bodypropCount++;
                }

                if (__workflow_bodydata != null)
                {
                    body["data"] = ExpressionConverter.ConvertO(__workflow_bodydata);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<string> JsonToCsv(Expression<Func<bool>> bodyheaderRow = null, Expression<Func<string>> bodyrowSeparator = null, Expression<Func<string>> bodyescapeCharacter = null, Expression<Func<string>> bodyfilter = null, Expression<Func<string>> bodyadvancedOptionscultureName = null, Expression<Func<string[]>> bodyadvancedOptionsisBoolean = null, Expression<Func<JToken[]>> bodydata = null)
        {
            var __workflow_bodyheaderRow = WorkflowExpression.Compile(bodyheaderRow, nameof(bodyheaderRow), required: false);
            var __workflow_bodyrowSeparator = WorkflowExpression.Compile(bodyrowSeparator, nameof(bodyrowSeparator), required: false);
            var __workflow_bodyescapeCharacter = WorkflowExpression.Compile(bodyescapeCharacter, nameof(bodyescapeCharacter), required: false);
            var __workflow_bodyfilter = WorkflowExpression.Compile(bodyfilter, nameof(bodyfilter), required: false);
            var __workflow_bodyadvancedOptionscultureName = WorkflowExpression.Compile(bodyadvancedOptionscultureName, nameof(bodyadvancedOptionscultureName), required: false);
            var __workflow_bodyadvancedOptionsisBoolean = WorkflowExpression.Compile(bodyadvancedOptionsisBoolean, nameof(bodyadvancedOptionsisBoolean), required: false);
            var __workflow_bodydata = WorkflowExpression.Compile(bodydata, nameof(bodydata), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/JsonToCsv";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyheaderRow != null)
                {
                    body["headerRow"] = ExpressionConverter.ConvertO(__workflow_bodyheaderRow);
                    bodypropCount++;
                }

                if (__workflow_bodyrowSeparator != null)
                {
                    body["rowSeparator"] = ExpressionConverter.ConvertO(__workflow_bodyrowSeparator);
                    bodypropCount++;
                }

                if (__workflow_bodyescapeCharacter != null)
                {
                    body["escapeCharacter"] = ExpressionConverter.ConvertO(__workflow_bodyescapeCharacter);
                    bodypropCount++;
                }

                if (__workflow_bodyfilter != null)
                {
                    body["filter"] = ExpressionConverter.ConvertO(__workflow_bodyfilter);
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
                if (__workflow_bodyadvancedOptionscultureName != null)
                {
                    advancedOptionsObject["cultureName"] = ExpressionConverter.ConvertO(__workflow_bodyadvancedOptionscultureName);
                    advancedOptionsObjectpropCount++;
                }

                if (__workflow_bodyadvancedOptionsisBoolean != null)
                {
                    advancedOptionsObject["isBoolean"] = ExpressionConverter.ConvertO(__workflow_bodyadvancedOptionsisBoolean);
                    advancedOptionsObjectpropCount++;
                }

                if (advancedOptionsObjectpropCount > 0)
                {
                    body["advancedOptions"] = advancedOptionsObject;
                    bodypropCount++;
                }

                if (__workflow_bodydata != null)
                {
                    body["data"] = ExpressionConverter.ConvertO(__workflow_bodydata);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IWorkflowAction JsonPropertiesToNameValuePairArray(Expression<Func<object>> bodydata)
        {
            var __workflow_bodydata = WorkflowExpression.Compile(bodydata, nameof(bodydata), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/JsonPropertiesToNameValuePairArray";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["data"] = ExpressionConverter.ConvertO(__workflow_bodydata);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<LevenshteinDistanceResponse> LevenshteinDistance(Expression<Func<string>> bodybaseValue, Expression<Func<string[]>> bodycomparisonValues, Expression<Func<double>> bodysettingsratioThreshold = null, Expression<Func<bodysettingsapplyRatioThresholdToInput>> bodysettingsapplyRatioThresholdTo = null, Expression<Func<bodysettingsratioSelectionTypeInput>> bodysettingsratioSelectionType = null, Expression<Func<bodysettingstokenSortTypeInput>> bodysettingstokenSortType = null, Expression<Func<bool>> bodysettingscaseSensitive = null, Expression<Func<bool>> bodysettingsremoveWhitespace = null, Expression<Func<bool>> bodysettingsremoveSpecialCharacters = null)
        {
            var __workflow_bodybaseValue = WorkflowExpression.Compile(bodybaseValue, nameof(bodybaseValue), required: true);
            var __workflow_bodycomparisonValues = WorkflowExpression.Compile(bodycomparisonValues, nameof(bodycomparisonValues), required: true);
            var __workflow_bodysettingsratioThreshold = WorkflowExpression.Compile(bodysettingsratioThreshold, nameof(bodysettingsratioThreshold), required: false);
            var __workflow_bodysettingsapplyRatioThresholdTo = WorkflowExpression.Compile(bodysettingsapplyRatioThresholdTo, nameof(bodysettingsapplyRatioThresholdTo), required: false);
            var __workflow_bodysettingsratioSelectionType = WorkflowExpression.Compile(bodysettingsratioSelectionType, nameof(bodysettingsratioSelectionType), required: false);
            var __workflow_bodysettingstokenSortType = WorkflowExpression.Compile(bodysettingstokenSortType, nameof(bodysettingstokenSortType), required: false);
            var __workflow_bodysettingscaseSensitive = WorkflowExpression.Compile(bodysettingscaseSensitive, nameof(bodysettingscaseSensitive), required: false);
            var __workflow_bodysettingsremoveWhitespace = WorkflowExpression.Compile(bodysettingsremoveWhitespace, nameof(bodysettingsremoveWhitespace), required: false);
            var __workflow_bodysettingsremoveSpecialCharacters = WorkflowExpression.Compile(bodysettingsremoveSpecialCharacters, nameof(bodysettingsremoveSpecialCharacters), required: false);
            return new DeferredBodyAction<LevenshteinDistanceResponse>(() =>
            {
                var apiCallPath = "/LevenshteinDistance";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["baseValue"] = ExpressionConverter.ConvertO(__workflow_bodybaseValue);
                bodypropCount++;
                body["comparisonValues"] = ExpressionConverter.ConvertO(__workflow_bodycomparisonValues);
                var settingsObject = new JObject();
                var settingsObjectpropCount = 0;
                if (__workflow_bodysettingsratioThreshold != null)
                {
                    settingsObject["ratioThreshold"] = ExpressionConverter.ConvertO(__workflow_bodysettingsratioThreshold);
                    settingsObjectpropCount++;
                }

                if (__workflow_bodysettingsapplyRatioThresholdTo != null)
                {
                    settingsObject["applyRatioThresholdTo"] = ExpressionConverter.ConvertO(__workflow_bodysettingsapplyRatioThresholdTo);
                    settingsObjectpropCount++;
                }

                if (__workflow_bodysettingsratioSelectionType != null)
                {
                    settingsObject["ratioSelectionType"] = ExpressionConverter.ConvertO(__workflow_bodysettingsratioSelectionType);
                    settingsObjectpropCount++;
                }

                if (__workflow_bodysettingstokenSortType != null)
                {
                    settingsObject["tokenSortType"] = ExpressionConverter.ConvertO(__workflow_bodysettingstokenSortType);
                    settingsObjectpropCount++;
                }

                if (__workflow_bodysettingscaseSensitive != null)
                {
                    settingsObject["caseSensitive"] = ExpressionConverter.ConvertO(__workflow_bodysettingscaseSensitive);
                    settingsObjectpropCount++;
                }

                if (__workflow_bodysettingsremoveWhitespace != null)
                {
                    settingsObject["removeWhitespace"] = ExpressionConverter.ConvertO(__workflow_bodysettingsremoveWhitespace);
                    settingsObjectpropCount++;
                }

                if (__workflow_bodysettingsremoveSpecialCharacters != null)
                {
                    settingsObject["removeSpecialCharacters"] = ExpressionConverter.ConvertO(__workflow_bodysettingsremoveSpecialCharacters);
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
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<JToken[]> ParquetToJson(Expression<Func<string>> bodydata, Expression<Func<bool>> bodyvalidateOnly = null, Expression<Func<int>> bodyskip = null, Expression<Func<int>> bodytake = null, Expression<Func<string>> bodyfilter = null, Expression<Func<string>> bodyadvancedOptionscultureName = null, Expression<Func<string[]>> bodyadvancedOptionsisBoolean = null)
        {
            var __workflow_bodydata = WorkflowExpression.Compile(bodydata, nameof(bodydata), required: true);
            var __workflow_bodyvalidateOnly = WorkflowExpression.Compile(bodyvalidateOnly, nameof(bodyvalidateOnly), required: false);
            var __workflow_bodyskip = WorkflowExpression.Compile(bodyskip, nameof(bodyskip), required: false);
            var __workflow_bodytake = WorkflowExpression.Compile(bodytake, nameof(bodytake), required: false);
            var __workflow_bodyfilter = WorkflowExpression.Compile(bodyfilter, nameof(bodyfilter), required: false);
            var __workflow_bodyadvancedOptionscultureName = WorkflowExpression.Compile(bodyadvancedOptionscultureName, nameof(bodyadvancedOptionscultureName), required: false);
            var __workflow_bodyadvancedOptionsisBoolean = WorkflowExpression.Compile(bodyadvancedOptionsisBoolean, nameof(bodyadvancedOptionsisBoolean), required: false);
            return new DeferredBodyAction<JToken[]>(() =>
            {
                var apiCallPath = "/ParquetToJson";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyvalidateOnly != null)
                {
                    body["validateOnly"] = ExpressionConverter.ConvertO(__workflow_bodyvalidateOnly);
                    bodypropCount++;
                }

                if (__workflow_bodyskip != null)
                {
                    body["skip"] = ExpressionConverter.ConvertO(__workflow_bodyskip);
                    bodypropCount++;
                }

                if (__workflow_bodytake != null)
                {
                    body["take"] = ExpressionConverter.ConvertO(__workflow_bodytake);
                    bodypropCount++;
                }

                if (__workflow_bodyfilter != null)
                {
                    body["filter"] = ExpressionConverter.ConvertO(__workflow_bodyfilter);
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
                if (__workflow_bodyadvancedOptionscultureName != null)
                {
                    advancedOptionsObject["cultureName"] = ExpressionConverter.ConvertO(__workflow_bodyadvancedOptionscultureName);
                    advancedOptionsObjectpropCount++;
                }

                if (__workflow_bodyadvancedOptionsisBoolean != null)
                {
                    advancedOptionsObject["isBoolean"] = ExpressionConverter.ConvertO(__workflow_bodyadvancedOptionsisBoolean);
                    advancedOptionsObjectpropCount++;
                }

                if (advancedOptionsObjectpropCount > 0)
                {
                    body["advancedOptions"] = advancedOptionsObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["data"] = ExpressionConverter.ConvertO(__workflow_bodydata);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken[]>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<string[]> RegexMatches(Expression<Func<string>> bodypattern, Expression<Func<string>> bodydata, Expression<Func<string>> bodyfilter = null, Expression<Func<string>> bodyadvancedOptionscultureName = null, Expression<Func<string[]>> bodyadvancedOptionsisBoolean = null)
        {
            var __workflow_bodypattern = WorkflowExpression.Compile(bodypattern, nameof(bodypattern), required: true);
            var __workflow_bodydata = WorkflowExpression.Compile(bodydata, nameof(bodydata), required: true);
            var __workflow_bodyfilter = WorkflowExpression.Compile(bodyfilter, nameof(bodyfilter), required: false);
            var __workflow_bodyadvancedOptionscultureName = WorkflowExpression.Compile(bodyadvancedOptionscultureName, nameof(bodyadvancedOptionscultureName), required: false);
            var __workflow_bodyadvancedOptionsisBoolean = WorkflowExpression.Compile(bodyadvancedOptionsisBoolean, nameof(bodyadvancedOptionsisBoolean), required: false);
            return new DeferredBodyAction<string[]>(() =>
            {
                var apiCallPath = "/RegexMatches";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["pattern"] = ExpressionConverter.ConvertO(__workflow_bodypattern);
                if (__workflow_bodyfilter != null)
                {
                    body["filter"] = ExpressionConverter.ConvertO(__workflow_bodyfilter);
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
                if (__workflow_bodyadvancedOptionscultureName != null)
                {
                    advancedOptionsObject["cultureName"] = ExpressionConverter.ConvertO(__workflow_bodyadvancedOptionscultureName);
                    advancedOptionsObjectpropCount++;
                }

                if (__workflow_bodyadvancedOptionsisBoolean != null)
                {
                    advancedOptionsObject["isBoolean"] = ExpressionConverter.ConvertO(__workflow_bodyadvancedOptionsisBoolean);
                    advancedOptionsObjectpropCount++;
                }

                if (advancedOptionsObjectpropCount > 0)
                {
                    body["advancedOptions"] = advancedOptionsObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["data"] = ExpressionConverter.ConvertO(__workflow_bodydata);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string[]>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<string> SimpleConcatenate(Expression<Func<string[]>> bodydata, Expression<Func<string>> bodyseparator = null, Expression<Func<bool>> bodyignoreEmpty = null, Expression<Func<string>> bodyfilter = null, Expression<Func<bodysortOrderInput>> bodysortOrder = null, Expression<Func<string>> bodyadvancedOptionscultureName = null, Expression<Func<string[]>> bodyadvancedOptionsisBoolean = null)
        {
            var __workflow_bodydata = WorkflowExpression.Compile(bodydata, nameof(bodydata), required: true);
            var __workflow_bodyseparator = WorkflowExpression.Compile(bodyseparator, nameof(bodyseparator), required: false);
            var __workflow_bodyignoreEmpty = WorkflowExpression.Compile(bodyignoreEmpty, nameof(bodyignoreEmpty), required: false);
            var __workflow_bodyfilter = WorkflowExpression.Compile(bodyfilter, nameof(bodyfilter), required: false);
            var __workflow_bodysortOrder = WorkflowExpression.Compile(bodysortOrder, nameof(bodysortOrder), required: false);
            var __workflow_bodyadvancedOptionscultureName = WorkflowExpression.Compile(bodyadvancedOptionscultureName, nameof(bodyadvancedOptionscultureName), required: false);
            var __workflow_bodyadvancedOptionsisBoolean = WorkflowExpression.Compile(bodyadvancedOptionsisBoolean, nameof(bodyadvancedOptionsisBoolean), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/SimpleConcatenate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyseparator != null)
                {
                    body["separator"] = ExpressionConverter.ConvertO(__workflow_bodyseparator);
                    bodypropCount++;
                }

                if (__workflow_bodyignoreEmpty != null)
                {
                    body["ignoreEmpty"] = ExpressionConverter.ConvertO(__workflow_bodyignoreEmpty);
                    bodypropCount++;
                }

                if (__workflow_bodyfilter != null)
                {
                    body["filter"] = ExpressionConverter.ConvertO(__workflow_bodyfilter);
                    bodypropCount++;
                }

                if (__workflow_bodysortOrder != null)
                {
                    body["sortOrder"] = ExpressionConverter.ConvertO(__workflow_bodysortOrder);
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
                if (__workflow_bodyadvancedOptionscultureName != null)
                {
                    advancedOptionsObject["cultureName"] = ExpressionConverter.ConvertO(__workflow_bodyadvancedOptionscultureName);
                    advancedOptionsObjectpropCount++;
                }

                if (__workflow_bodyadvancedOptionsisBoolean != null)
                {
                    advancedOptionsObject["isBoolean"] = ExpressionConverter.ConvertO(__workflow_bodyadvancedOptionsisBoolean);
                    advancedOptionsObjectpropCount++;
                }

                if (advancedOptionsObjectpropCount > 0)
                {
                    body["advancedOptions"] = advancedOptionsObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["data"] = ExpressionConverter.ConvertO(__workflow_bodydata);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IWorkflowAction SimpleDistinct(Expression<Func<string>> bodyfield, Expression<Func<string>> bodyfilter = null, Expression<Func<bodysortOrderInput>> bodysortOrder = null, Expression<Func<string>> bodyadvancedOptionscultureName = null, Expression<Func<string[]>> bodyadvancedOptionsisBoolean = null, Expression<Func<JToken[]>> bodydata = null)
        {
            var __workflow_bodyfield = WorkflowExpression.Compile(bodyfield, nameof(bodyfield), required: true);
            var __workflow_bodyfilter = WorkflowExpression.Compile(bodyfilter, nameof(bodyfilter), required: false);
            var __workflow_bodysortOrder = WorkflowExpression.Compile(bodysortOrder, nameof(bodysortOrder), required: false);
            var __workflow_bodyadvancedOptionscultureName = WorkflowExpression.Compile(bodyadvancedOptionscultureName, nameof(bodyadvancedOptionscultureName), required: false);
            var __workflow_bodyadvancedOptionsisBoolean = WorkflowExpression.Compile(bodyadvancedOptionsisBoolean, nameof(bodyadvancedOptionsisBoolean), required: false);
            var __workflow_bodydata = WorkflowExpression.Compile(bodydata, nameof(bodydata), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/SimpleDistinct";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["field"] = ExpressionConverter.ConvertO(__workflow_bodyfield);
                if (__workflow_bodyfilter != null)
                {
                    body["filter"] = ExpressionConverter.ConvertO(__workflow_bodyfilter);
                    bodypropCount++;
                }

                if (__workflow_bodysortOrder != null)
                {
                    body["sortOrder"] = ExpressionConverter.ConvertO(__workflow_bodysortOrder);
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
                if (__workflow_bodyadvancedOptionscultureName != null)
                {
                    advancedOptionsObject["cultureName"] = ExpressionConverter.ConvertO(__workflow_bodyadvancedOptionscultureName);
                    advancedOptionsObjectpropCount++;
                }

                if (__workflow_bodyadvancedOptionsisBoolean != null)
                {
                    advancedOptionsObject["isBoolean"] = ExpressionConverter.ConvertO(__workflow_bodyadvancedOptionsisBoolean);
                    advancedOptionsObjectpropCount++;
                }

                if (advancedOptionsObjectpropCount > 0)
                {
                    body["advancedOptions"] = advancedOptionsObject;
                    bodypropCount++;
                }

                if (__workflow_bodydata != null)
                {
                    body["data"] = ExpressionConverter.ConvertO(__workflow_bodydata);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<JToken[]> SortObjectArray(Expression<Func<JToken[]>> bodydata = null)
        {
            var __workflow_bodydata = WorkflowExpression.Compile(bodydata, nameof(bodydata), required: false);
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

                if (__workflow_bodydata != null)
                {
                    body["data"] = ExpressionConverter.ConvertO(__workflow_bodydata);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken[]>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<JToken[]> Split(Expression<Func<JToken[]>> bodysplits, Expression<Func<string>> bodyfilter = null, Expression<Func<string>> bodyadvancedOptionscultureName = null, Expression<Func<string[]>> bodyadvancedOptionsisBoolean = null, Expression<Func<JToken[]>> bodydata = null)
        {
            var __workflow_bodysplits = WorkflowExpression.Compile(bodysplits, nameof(bodysplits), required: true);
            var __workflow_bodyfilter = WorkflowExpression.Compile(bodyfilter, nameof(bodyfilter), required: false);
            var __workflow_bodyadvancedOptionscultureName = WorkflowExpression.Compile(bodyadvancedOptionscultureName, nameof(bodyadvancedOptionscultureName), required: false);
            var __workflow_bodyadvancedOptionsisBoolean = WorkflowExpression.Compile(bodyadvancedOptionsisBoolean, nameof(bodyadvancedOptionsisBoolean), required: false);
            var __workflow_bodydata = WorkflowExpression.Compile(bodydata, nameof(bodydata), required: false);
            return new DeferredBodyAction<JToken[]>(() =>
            {
                var apiCallPath = "/Split";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["splits"] = ExpressionConverter.ConvertO(__workflow_bodysplits);
                if (__workflow_bodyfilter != null)
                {
                    body["filter"] = ExpressionConverter.ConvertO(__workflow_bodyfilter);
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
                if (__workflow_bodyadvancedOptionscultureName != null)
                {
                    advancedOptionsObject["cultureName"] = ExpressionConverter.ConvertO(__workflow_bodyadvancedOptionscultureName);
                    advancedOptionsObjectpropCount++;
                }

                if (__workflow_bodyadvancedOptionsisBoolean != null)
                {
                    advancedOptionsObject["isBoolean"] = ExpressionConverter.ConvertO(__workflow_bodyadvancedOptionsisBoolean);
                    advancedOptionsObjectpropCount++;
                }

                if (advancedOptionsObjectpropCount > 0)
                {
                    body["advancedOptions"] = advancedOptionsObject;
                    bodypropCount++;
                }

                if (__workflow_bodydata != null)
                {
                    body["data"] = ExpressionConverter.ConvertO(__workflow_bodydata);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken[]>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<JToken[]> TextToJson(Expression<Func<string>> bodydata, Expression<Func<bool>> bodyheaderRow = null, Expression<Func<string>> bodyrowSeparator = null, Expression<Func<string>> bodydelimiter = null, Expression<Func<bodyencodingInput>> bodyencoding = null, Expression<Func<string>> bodyfilter = null, Expression<Func<string>> bodyadvancedOptionscultureName = null, Expression<Func<string[]>> bodyadvancedOptionsisBoolean = null)
        {
            var __workflow_bodydata = WorkflowExpression.Compile(bodydata, nameof(bodydata), required: true);
            var __workflow_bodyheaderRow = WorkflowExpression.Compile(bodyheaderRow, nameof(bodyheaderRow), required: false);
            var __workflow_bodyrowSeparator = WorkflowExpression.Compile(bodyrowSeparator, nameof(bodyrowSeparator), required: false);
            var __workflow_bodydelimiter = WorkflowExpression.Compile(bodydelimiter, nameof(bodydelimiter), required: false);
            var __workflow_bodyencoding = WorkflowExpression.Compile(bodyencoding, nameof(bodyencoding), required: false);
            var __workflow_bodyfilter = WorkflowExpression.Compile(bodyfilter, nameof(bodyfilter), required: false);
            var __workflow_bodyadvancedOptionscultureName = WorkflowExpression.Compile(bodyadvancedOptionscultureName, nameof(bodyadvancedOptionscultureName), required: false);
            var __workflow_bodyadvancedOptionsisBoolean = WorkflowExpression.Compile(bodyadvancedOptionsisBoolean, nameof(bodyadvancedOptionsisBoolean), required: false);
            return new DeferredBodyAction<JToken[]>(() =>
            {
                var apiCallPath = "/TextToJson";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyheaderRow != null)
                {
                    body["headerRow"] = ExpressionConverter.ConvertO(__workflow_bodyheaderRow);
                    bodypropCount++;
                }

                if (__workflow_bodyrowSeparator != null)
                {
                    body["rowSeparator"] = ExpressionConverter.ConvertO(__workflow_bodyrowSeparator);
                    bodypropCount++;
                }

                if (__workflow_bodydelimiter != null)
                {
                    body["delimiter"] = ExpressionConverter.ConvertO(__workflow_bodydelimiter);
                    bodypropCount++;
                }

                if (__workflow_bodyencoding != null)
                {
                    body["encoding"] = ExpressionConverter.ConvertO(__workflow_bodyencoding);
                    bodypropCount++;
                }

                if (__workflow_bodyfilter != null)
                {
                    body["filter"] = ExpressionConverter.ConvertO(__workflow_bodyfilter);
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
                if (__workflow_bodyadvancedOptionscultureName != null)
                {
                    advancedOptionsObject["cultureName"] = ExpressionConverter.ConvertO(__workflow_bodyadvancedOptionscultureName);
                    advancedOptionsObjectpropCount++;
                }

                if (__workflow_bodyadvancedOptionsisBoolean != null)
                {
                    advancedOptionsObject["isBoolean"] = ExpressionConverter.ConvertO(__workflow_bodyadvancedOptionsisBoolean);
                    advancedOptionsObjectpropCount++;
                }

                if (advancedOptionsObjectpropCount > 0)
                {
                    body["advancedOptions"] = advancedOptionsObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["data"] = ExpressionConverter.ConvertO(__workflow_bodydata);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken[]>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<JToken[]> Transform(Expression<Func<bool>> bodypreserveAllProperties = null, Expression<Func<string>> bodyfilter = null, Expression<Func<string>> bodyadvancedOptionscultureName = null, Expression<Func<string[]>> bodyadvancedOptionsisBoolean = null, Expression<Func<JToken[]>> bodydata = null)
        {
            var __workflow_bodypreserveAllProperties = WorkflowExpression.Compile(bodypreserveAllProperties, nameof(bodypreserveAllProperties), required: false);
            var __workflow_bodyfilter = WorkflowExpression.Compile(bodyfilter, nameof(bodyfilter), required: false);
            var __workflow_bodyadvancedOptionscultureName = WorkflowExpression.Compile(bodyadvancedOptionscultureName, nameof(bodyadvancedOptionscultureName), required: false);
            var __workflow_bodyadvancedOptionsisBoolean = WorkflowExpression.Compile(bodyadvancedOptionsisBoolean, nameof(bodyadvancedOptionsisBoolean), required: false);
            var __workflow_bodydata = WorkflowExpression.Compile(bodydata, nameof(bodydata), required: false);
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

                if (__workflow_bodypreserveAllProperties != null)
                {
                    body["preserveAllProperties"] = ExpressionConverter.ConvertO(__workflow_bodypreserveAllProperties);
                    bodypropCount++;
                }

                if (__workflow_bodyfilter != null)
                {
                    body["filter"] = ExpressionConverter.ConvertO(__workflow_bodyfilter);
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
                if (__workflow_bodyadvancedOptionscultureName != null)
                {
                    advancedOptionsObject["cultureName"] = ExpressionConverter.ConvertO(__workflow_bodyadvancedOptionscultureName);
                    advancedOptionsObjectpropCount++;
                }

                if (__workflow_bodyadvancedOptionsisBoolean != null)
                {
                    advancedOptionsObject["isBoolean"] = ExpressionConverter.ConvertO(__workflow_bodyadvancedOptionsisBoolean);
                    advancedOptionsObjectpropCount++;
                }

                if (advancedOptionsObjectpropCount > 0)
                {
                    body["advancedOptions"] = advancedOptionsObject;
                    bodypropCount++;
                }

                if (__workflow_bodydata != null)
                {
                    body["data"] = ExpressionConverter.ConvertO(__workflow_bodydata);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken[]>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<JToken[]> XmlToJson(Expression<Func<string>> bodydata, Expression<Func<string>> bodyprimaryLoopAtElement = null, Expression<Func<bodysubLoopAtElementsInputItem[]>> bodysubLoopAtElements = null)
        {
            var __workflow_bodydata = WorkflowExpression.Compile(bodydata, nameof(bodydata), required: true);
            var __workflow_bodyprimaryLoopAtElement = WorkflowExpression.Compile(bodyprimaryLoopAtElement, nameof(bodyprimaryLoopAtElement), required: false);
            var __workflow_bodysubLoopAtElements = WorkflowExpression.Compile(bodysubLoopAtElements, nameof(bodysubLoopAtElements), required: false);
            return new DeferredBodyAction<JToken[]>(() =>
            {
                var apiCallPath = "/XmlToJson";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyprimaryLoopAtElement != null)
                {
                    body["primaryLoopAtElement"] = ExpressionConverter.ConvertO(__workflow_bodyprimaryLoopAtElement);
                    bodypropCount++;
                }

                var mapObject = new JObject();
                var mapObjectpropCount = 0;
                if (mapObjectpropCount > 0)
                {
                    body["map"] = mapObject;
                    bodypropCount++;
                }

                if (__workflow_bodysubLoopAtElements != null)
                {
                    body["subLoopAtElements"] = ExpressionConverter.ConvertO(__workflow_bodysubLoopAtElements);
                    bodypropCount++;
                }

                bodypropCount++;
                body["data"] = ExpressionConverter.ConvertO(__workflow_bodydata);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken[]>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<ZipArchiveDecompressResponseItem[]> ZipArchiveDecompress(Expression<Func<string>> bodydata, Expression<Func<bool>> bodygetFileContents, Expression<Func<string>> bodyfilter = null)
        {
            var __workflow_bodydata = WorkflowExpression.Compile(bodydata, nameof(bodydata), required: true);
            var __workflow_bodygetFileContents = WorkflowExpression.Compile(bodygetFileContents, nameof(bodygetFileContents), required: true);
            var __workflow_bodyfilter = WorkflowExpression.Compile(bodyfilter, nameof(bodyfilter), required: false);
            return new DeferredBodyAction<ZipArchiveDecompressResponseItem[]>(() =>
            {
                var apiCallPath = "/ZipArchiveDecompress";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["data"] = ExpressionConverter.ConvertO(__workflow_bodydata);
                bodypropCount++;
                body["getFileContents"] = ExpressionConverter.ConvertO(__workflow_bodygetFileContents);
                if (__workflow_bodyfilter != null)
                {
                    body["filter"] = ExpressionConverter.ConvertO(__workflow_bodyfilter);
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
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
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
