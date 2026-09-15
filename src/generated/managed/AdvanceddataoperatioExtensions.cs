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
        public IBodyWorkflowAction<JToken[]> Aggregate(Expression<Func<bodyaggregationTypeInput>> bodyaggregationType, Expression<Func<string[]>> bodyaggregateBy, Expression<Func<string[]>> bodyaggregateOn, Expression<Func<string>> bodyfilter = null, Expression<Func<string>> bodyadvancedOptionscultureName = null, Expression<Func<string[]>> bodyadvancedOptionsisBoolean = null, Expression<Func<JToken[]>> bodydata = null)
        {
            var apiCallPath = "/Aggregate";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["aggregationType"] = CSharpExpressionConverter.Convert(bodyaggregationType);
            bodypropCount++;
            body["aggregateBy"] = CSharpExpressionConverter.ConvertToken(bodyaggregateBy);
            bodypropCount++;
            body["aggregateOn"] = CSharpExpressionConverter.ConvertToken(bodyaggregateOn);
            if (bodyfilter != null)
            {
                body["filter"] = CSharpExpressionConverter.ConvertToken(bodyfilter);
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
                advancedOptionsObject["cultureName"] = CSharpExpressionConverter.ConvertToken(bodyadvancedOptionscultureName);
                advancedOptionsObjectpropCount++;
            }

            if (bodyadvancedOptionsisBoolean != null)
            {
                advancedOptionsObject["isBoolean"] = CSharpExpressionConverter.ConvertToken(bodyadvancedOptionsisBoolean);
                advancedOptionsObjectpropCount++;
            }

            if (advancedOptionsObjectpropCount > 0)
            {
                body["advancedOptions"] = advancedOptionsObject;
                bodypropCount++;
            }

            if (bodydata != null)
            {
                body["data"] = CSharpExpressionConverter.ConvertToken(bodydata);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<JToken[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<JToken[]> CartesianJoin(Expression<Func<string>> bodyfilter = null, Expression<Func<string>> bodyadvancedOptionscultureName = null, Expression<Func<string[]>> bodyadvancedOptionsisBoolean = null)
        {
            var apiCallPath = "/CartesianJoin";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyfilter != null)
            {
                body["filter"] = CSharpExpressionConverter.ConvertToken(bodyfilter);
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
                advancedOptionsObject["cultureName"] = CSharpExpressionConverter.ConvertToken(bodyadvancedOptionscultureName);
                advancedOptionsObjectpropCount++;
            }

            if (bodyadvancedOptionsisBoolean != null)
            {
                advancedOptionsObject["isBoolean"] = CSharpExpressionConverter.ConvertToken(bodyadvancedOptionsisBoolean);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<string> Concatenate(Expression<Func<string>> bodyfield, Expression<Func<string>> bodyseparator = null, Expression<Func<bool>> bodyignoreEmpty = null, Expression<Func<string>> bodyfilter = null, Expression<Func<string>> bodyadvancedOptionscultureName = null, Expression<Func<string[]>> bodyadvancedOptionsisBoolean = null, Expression<Func<JToken[]>> bodydata = null)
        {
            var apiCallPath = "/Concatenate";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["field"] = CSharpExpressionConverter.ConvertToken(bodyfield);
            if (bodyseparator != null)
            {
                body["separator"] = CSharpExpressionConverter.ConvertToken(bodyseparator);
                bodypropCount++;
            }

            if (bodyignoreEmpty != null)
            {
                body["ignoreEmpty"] = CSharpExpressionConverter.ConvertToken(bodyignoreEmpty);
                bodypropCount++;
            }

            if (bodyfilter != null)
            {
                body["filter"] = CSharpExpressionConverter.ConvertToken(bodyfilter);
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
                advancedOptionsObject["cultureName"] = CSharpExpressionConverter.ConvertToken(bodyadvancedOptionscultureName);
                advancedOptionsObjectpropCount++;
            }

            if (bodyadvancedOptionsisBoolean != null)
            {
                advancedOptionsObject["isBoolean"] = CSharpExpressionConverter.ConvertToken(bodyadvancedOptionsisBoolean);
                advancedOptionsObjectpropCount++;
            }

            if (advancedOptionsObjectpropCount > 0)
            {
                body["advancedOptions"] = advancedOptionsObject;
                bodypropCount++;
            }

            if (bodydata != null)
            {
                body["data"] = CSharpExpressionConverter.ConvertToken(bodydata);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<JToken> CSharpEvaluate(Expression<Func<string>> bodyexpression)
        {
            var apiCallPath = "/CSharpEvaluate";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["expression"] = CSharpExpressionConverter.ConvertToken(bodyexpression);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<JToken> CSharpScriptExecute(Expression<Func<string>> bodyscript, Expression<Func<string[]>> bodyclassDefinitions = null)
        {
            var apiCallPath = "/CSharpScriptExecute";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["script"] = CSharpExpressionConverter.ConvertToken(bodyscript);
            if (bodyclassDefinitions != null)
            {
                body["classDefinitions"] = CSharpExpressionConverter.ConvertToken(bodyclassDefinitions);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<JToken[]> CsvToJson(Expression<Func<string>> bodydata, Expression<Func<bool>> bodyheaderRow = null, Expression<Func<string>> bodyrowSeparator = null, Expression<Func<string>> bodydelimiter = null, Expression<Func<string>> bodyescapeCharacter = null, Expression<Func<bodyencodingInput>> bodyencoding = null, Expression<Func<string>> bodyfilter = null, Expression<Func<string>> bodyadvancedOptionscultureName = null, Expression<Func<string[]>> bodyadvancedOptionsisBoolean = null)
        {
            var apiCallPath = "/CsvToJson";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyheaderRow != null)
            {
                body["headerRow"] = CSharpExpressionConverter.ConvertToken(bodyheaderRow);
                bodypropCount++;
            }

            if (bodyrowSeparator != null)
            {
                body["rowSeparator"] = CSharpExpressionConverter.ConvertToken(bodyrowSeparator);
                bodypropCount++;
            }

            if (bodydelimiter != null)
            {
                body["delimiter"] = CSharpExpressionConverter.ConvertToken(bodydelimiter);
                bodypropCount++;
            }

            if (bodyescapeCharacter != null)
            {
                body["escapeCharacter"] = CSharpExpressionConverter.ConvertToken(bodyescapeCharacter);
                bodypropCount++;
            }

            if (bodyencoding != null)
            {
                body["encoding"] = CSharpExpressionConverter.Convert(bodyencoding);
                bodypropCount++;
            }

            if (bodyfilter != null)
            {
                body["filter"] = CSharpExpressionConverter.ConvertToken(bodyfilter);
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
                advancedOptionsObject["cultureName"] = CSharpExpressionConverter.ConvertToken(bodyadvancedOptionscultureName);
                advancedOptionsObjectpropCount++;
            }

            if (bodyadvancedOptionsisBoolean != null)
            {
                advancedOptionsObject["isBoolean"] = CSharpExpressionConverter.ConvertToken(bodyadvancedOptionsisBoolean);
                advancedOptionsObjectpropCount++;
            }

            if (advancedOptionsObjectpropCount > 0)
            {
                body["advancedOptions"] = advancedOptionsObject;
                bodypropCount++;
            }

            bodypropCount++;
            body["data"] = CSharpExpressionConverter.ConvertToken(bodydata);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<JToken[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IWorkflowAction Distinct(Expression<Func<string[]>> bodyfields, Expression<Func<string>> bodyfilter = null, Expression<Func<string>> bodyadvancedOptionscultureName = null, Expression<Func<string[]>> bodyadvancedOptionsisBoolean = null, Expression<Func<JToken[]>> bodydata = null)
        {
            var apiCallPath = "/Distinct";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["fields"] = CSharpExpressionConverter.ConvertToken(bodyfields);
            if (bodyfilter != null)
            {
                body["filter"] = CSharpExpressionConverter.ConvertToken(bodyfilter);
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
                advancedOptionsObject["cultureName"] = CSharpExpressionConverter.ConvertToken(bodyadvancedOptionscultureName);
                advancedOptionsObjectpropCount++;
            }

            if (bodyadvancedOptionsisBoolean != null)
            {
                advancedOptionsObject["isBoolean"] = CSharpExpressionConverter.ConvertToken(bodyadvancedOptionsisBoolean);
                advancedOptionsObjectpropCount++;
            }

            if (advancedOptionsObjectpropCount > 0)
            {
                body["advancedOptions"] = advancedOptionsObject;
                bodypropCount++;
            }

            if (bodydata != null)
            {
                body["data"] = CSharpExpressionConverter.ConvertToken(bodydata);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<JToken[]> Expert(Expression<Func<string>> bodyquery, Expression<Func<string>> bodyadvancedOptionscultureName = null, Expression<Func<string[]>> bodyadvancedOptionsisBoolean = null)
        {
            var apiCallPath = "/Expert";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["query"] = CSharpExpressionConverter.ConvertToken(bodyquery);
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
                advancedOptionsObject["cultureName"] = CSharpExpressionConverter.ConvertToken(bodyadvancedOptionscultureName);
                advancedOptionsObjectpropCount++;
            }

            if (bodyadvancedOptionsisBoolean != null)
            {
                advancedOptionsObject["isBoolean"] = CSharpExpressionConverter.ConvertToken(bodyadvancedOptionsisBoolean);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<JToken[]> FilterObjectArray(Expression<Func<string>> bodyfilter, Expression<Func<JToken[]>> bodydata = null)
        {
            var apiCallPath = "/FilterObjectArray";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["filter"] = CSharpExpressionConverter.ConvertToken(bodyfilter);
            if (bodydata != null)
            {
                body["data"] = CSharpExpressionConverter.ConvertToken(bodydata);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<JToken[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<JToken[]> FlattenObjectArray(Expression<Func<string>> bodydelimiter, Expression<Func<bool>> bodybalancedOutput, Expression<Func<string>> bodyfilter = null, Expression<Func<string>> bodyadvancedOptionscultureName = null, Expression<Func<string[]>> bodyadvancedOptionsisBoolean = null, Expression<Func<JToken[]>> bodydata = null)
        {
            var apiCallPath = "/FlattenObjectArray";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["delimiter"] = CSharpExpressionConverter.ConvertToken(bodydelimiter);
            bodypropCount++;
            body["balancedOutput"] = CSharpExpressionConverter.ConvertToken(bodybalancedOutput);
            if (bodyfilter != null)
            {
                body["filter"] = CSharpExpressionConverter.ConvertToken(bodyfilter);
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
                advancedOptionsObject["cultureName"] = CSharpExpressionConverter.ConvertToken(bodyadvancedOptionscultureName);
                advancedOptionsObjectpropCount++;
            }

            if (bodyadvancedOptionsisBoolean != null)
            {
                advancedOptionsObject["isBoolean"] = CSharpExpressionConverter.ConvertToken(bodyadvancedOptionsisBoolean);
                advancedOptionsObjectpropCount++;
            }

            if (advancedOptionsObjectpropCount > 0)
            {
                body["advancedOptions"] = advancedOptionsObject;
                bodypropCount++;
            }

            if (bodydata != null)
            {
                body["data"] = CSharpExpressionConverter.ConvertToken(bodydata);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<JToken[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<JToken[]> GetDataSchema(Expression<Func<string>> bodyfilter = null, Expression<Func<string>> bodyadvancedOptionscultureName = null, Expression<Func<string[]>> bodyadvancedOptionsisBoolean = null, Expression<Func<JToken[]>> bodydata = null)
        {
            var apiCallPath = "/GetDataSchema";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyfilter != null)
            {
                body["filter"] = CSharpExpressionConverter.ConvertToken(bodyfilter);
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
                advancedOptionsObject["cultureName"] = CSharpExpressionConverter.ConvertToken(bodyadvancedOptionscultureName);
                advancedOptionsObjectpropCount++;
            }

            if (bodyadvancedOptionsisBoolean != null)
            {
                advancedOptionsObject["isBoolean"] = CSharpExpressionConverter.ConvertToken(bodyadvancedOptionsisBoolean);
                advancedOptionsObjectpropCount++;
            }

            if (advancedOptionsObjectpropCount > 0)
            {
                body["advancedOptions"] = advancedOptionsObject;
                bodypropCount++;
            }

            if (bodydata != null)
            {
                body["data"] = CSharpExpressionConverter.ConvertToken(bodydata);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<JToken[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<string> GZipCompress(Expression<Func<string>> bodydata)
        {
            var apiCallPath = "/GZipCompress";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["data"] = CSharpExpressionConverter.ConvertToken(bodydata);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<string> GZipDecompress(Expression<Func<string>> bodydata)
        {
            var apiCallPath = "/GZipDecompress";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["data"] = CSharpExpressionConverter.ConvertToken(bodydata);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<JToken[]> Join(Expression<Func<bodyjoinTypeInput>> bodyjoinType, Expression<Func<string[]>> bodyjoinFields, Expression<Func<string[]>> bodyfields, Expression<Func<bool>> bodyforceFullyQualifiedFieldNames = null, Expression<Func<string>> bodyfilter = null, Expression<Func<string>> bodyadvancedOptionscultureName = null, Expression<Func<string[]>> bodyadvancedOptionsisBoolean = null)
        {
            var apiCallPath = "/Join";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["joinType"] = CSharpExpressionConverter.Convert(bodyjoinType);
            bodypropCount++;
            body["joinFields"] = CSharpExpressionConverter.ConvertToken(bodyjoinFields);
            bodypropCount++;
            body["fields"] = CSharpExpressionConverter.ConvertToken(bodyfields);
            if (bodyforceFullyQualifiedFieldNames != null)
            {
                body["forceFullyQualifiedFieldNames"] = CSharpExpressionConverter.ConvertToken(bodyforceFullyQualifiedFieldNames);
                bodypropCount++;
            }

            if (bodyfilter != null)
            {
                body["filter"] = CSharpExpressionConverter.ConvertToken(bodyfilter);
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
                advancedOptionsObject["cultureName"] = CSharpExpressionConverter.ConvertToken(bodyadvancedOptionscultureName);
                advancedOptionsObjectpropCount++;
            }

            if (bodyadvancedOptionsisBoolean != null)
            {
                advancedOptionsObject["isBoolean"] = CSharpExpressionConverter.ConvertToken(bodyadvancedOptionsisBoolean);
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
            var apiCallPath = "/JsonToTable";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodypath != null)
            {
                body["path"] = CSharpExpressionConverter.ConvertToken(bodypath);
                bodypropCount++;
            }

            if (bodybalancedOutput != null)
            {
                body["balancedOutput"] = CSharpExpressionConverter.ConvertToken(bodybalancedOutput);
                bodypropCount++;
            }

            if (bodyfilter != null)
            {
                body["filter"] = CSharpExpressionConverter.ConvertToken(bodyfilter);
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
                advancedOptionsObject["cultureName"] = CSharpExpressionConverter.ConvertToken(bodyadvancedOptionscultureName);
                advancedOptionsObjectpropCount++;
            }

            if (bodyadvancedOptionsisBoolean != null)
            {
                advancedOptionsObject["isBoolean"] = CSharpExpressionConverter.ConvertToken(bodyadvancedOptionsisBoolean);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<string> JsonToText(Expression<Func<bool>> bodyheaderRow = null, Expression<Func<string>> bodyrowSeparator = null, Expression<Func<string>> bodyfilter = null, Expression<Func<string>> bodyadvancedOptionscultureName = null, Expression<Func<string[]>> bodyadvancedOptionsisBoolean = null, Expression<Func<JToken[]>> bodydata = null)
        {
            var apiCallPath = "/JsonToText";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyheaderRow != null)
            {
                body["headerRow"] = CSharpExpressionConverter.ConvertToken(bodyheaderRow);
                bodypropCount++;
            }

            if (bodyrowSeparator != null)
            {
                body["rowSeparator"] = CSharpExpressionConverter.ConvertToken(bodyrowSeparator);
                bodypropCount++;
            }

            if (bodyfilter != null)
            {
                body["filter"] = CSharpExpressionConverter.ConvertToken(bodyfilter);
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
                advancedOptionsObject["cultureName"] = CSharpExpressionConverter.ConvertToken(bodyadvancedOptionscultureName);
                advancedOptionsObjectpropCount++;
            }

            if (bodyadvancedOptionsisBoolean != null)
            {
                advancedOptionsObject["isBoolean"] = CSharpExpressionConverter.ConvertToken(bodyadvancedOptionsisBoolean);
                advancedOptionsObjectpropCount++;
            }

            if (advancedOptionsObjectpropCount > 0)
            {
                body["advancedOptions"] = advancedOptionsObject;
                bodypropCount++;
            }

            if (bodydata != null)
            {
                body["data"] = CSharpExpressionConverter.ConvertToken(bodydata);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<string> JsonToCsv(Expression<Func<bool>> bodyheaderRow = null, Expression<Func<string>> bodyrowSeparator = null, Expression<Func<string>> bodyescapeCharacter = null, Expression<Func<string>> bodyfilter = null, Expression<Func<string>> bodyadvancedOptionscultureName = null, Expression<Func<string[]>> bodyadvancedOptionsisBoolean = null, Expression<Func<JToken[]>> bodydata = null)
        {
            var apiCallPath = "/JsonToCsv";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyheaderRow != null)
            {
                body["headerRow"] = CSharpExpressionConverter.ConvertToken(bodyheaderRow);
                bodypropCount++;
            }

            if (bodyrowSeparator != null)
            {
                body["rowSeparator"] = CSharpExpressionConverter.ConvertToken(bodyrowSeparator);
                bodypropCount++;
            }

            if (bodyescapeCharacter != null)
            {
                body["escapeCharacter"] = CSharpExpressionConverter.ConvertToken(bodyescapeCharacter);
                bodypropCount++;
            }

            if (bodyfilter != null)
            {
                body["filter"] = CSharpExpressionConverter.ConvertToken(bodyfilter);
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
                advancedOptionsObject["cultureName"] = CSharpExpressionConverter.ConvertToken(bodyadvancedOptionscultureName);
                advancedOptionsObjectpropCount++;
            }

            if (bodyadvancedOptionsisBoolean != null)
            {
                advancedOptionsObject["isBoolean"] = CSharpExpressionConverter.ConvertToken(bodyadvancedOptionsisBoolean);
                advancedOptionsObjectpropCount++;
            }

            if (advancedOptionsObjectpropCount > 0)
            {
                body["advancedOptions"] = advancedOptionsObject;
                bodypropCount++;
            }

            if (bodydata != null)
            {
                body["data"] = CSharpExpressionConverter.ConvertToken(bodydata);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IWorkflowAction JsonPropertiesToNameValuePairArray(Expression<Func<object>> bodydata)
        {
            var apiCallPath = "/JsonPropertiesToNameValuePairArray";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["data"] = CSharpExpressionConverter.ConvertToken(bodydata);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<LevenshteinDistanceResponse> LevenshteinDistance(Expression<Func<string>> bodybaseValue, Expression<Func<string[]>> bodycomparisonValues, Expression<Func<double>> bodysettingsratioThreshold = null, Expression<Func<bodysettingsapplyRatioThresholdToInput>> bodysettingsapplyRatioThresholdTo = null, Expression<Func<bodysettingsratioSelectionTypeInput>> bodysettingsratioSelectionType = null, Expression<Func<bodysettingstokenSortTypeInput>> bodysettingstokenSortType = null, Expression<Func<bool>> bodysettingscaseSensitive = null, Expression<Func<bool>> bodysettingsremoveWhitespace = null, Expression<Func<bool>> bodysettingsremoveSpecialCharacters = null)
        {
            var apiCallPath = "/LevenshteinDistance";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["baseValue"] = CSharpExpressionConverter.ConvertToken(bodybaseValue);
            bodypropCount++;
            body["comparisonValues"] = CSharpExpressionConverter.ConvertToken(bodycomparisonValues);
            var settingsObject = new JObject();
            var settingsObjectpropCount = 0;
            if (bodysettingsratioThreshold != null)
            {
                settingsObject["ratioThreshold"] = CSharpExpressionConverter.ConvertToken(bodysettingsratioThreshold);
                settingsObjectpropCount++;
            }

            if (bodysettingsapplyRatioThresholdTo != null)
            {
                settingsObject["applyRatioThresholdTo"] = CSharpExpressionConverter.Convert(bodysettingsapplyRatioThresholdTo);
                settingsObjectpropCount++;
            }

            if (bodysettingsratioSelectionType != null)
            {
                settingsObject["ratioSelectionType"] = CSharpExpressionConverter.Convert(bodysettingsratioSelectionType);
                settingsObjectpropCount++;
            }

            if (bodysettingstokenSortType != null)
            {
                settingsObject["tokenSortType"] = CSharpExpressionConverter.Convert(bodysettingstokenSortType);
                settingsObjectpropCount++;
            }

            if (bodysettingscaseSensitive != null)
            {
                settingsObject["caseSensitive"] = CSharpExpressionConverter.ConvertToken(bodysettingscaseSensitive);
                settingsObjectpropCount++;
            }

            if (bodysettingsremoveWhitespace != null)
            {
                settingsObject["removeWhitespace"] = CSharpExpressionConverter.ConvertToken(bodysettingsremoveWhitespace);
                settingsObjectpropCount++;
            }

            if (bodysettingsremoveSpecialCharacters != null)
            {
                settingsObject["removeSpecialCharacters"] = CSharpExpressionConverter.ConvertToken(bodysettingsremoveSpecialCharacters);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<JToken[]> ParquetToJson(Expression<Func<string>> bodydata, Expression<Func<bool>> bodyvalidateOnly = null, Expression<Func<int>> bodyskip = null, Expression<Func<int>> bodytake = null, Expression<Func<string>> bodyfilter = null, Expression<Func<string>> bodyadvancedOptionscultureName = null, Expression<Func<string[]>> bodyadvancedOptionsisBoolean = null)
        {
            var apiCallPath = "/ParquetToJson";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyvalidateOnly != null)
            {
                body["validateOnly"] = CSharpExpressionConverter.ConvertToken(bodyvalidateOnly);
                bodypropCount++;
            }

            if (bodyskip != null)
            {
                body["skip"] = CSharpExpressionConverter.ConvertToken(bodyskip);
                bodypropCount++;
            }

            if (bodytake != null)
            {
                body["take"] = CSharpExpressionConverter.ConvertToken(bodytake);
                bodypropCount++;
            }

            if (bodyfilter != null)
            {
                body["filter"] = CSharpExpressionConverter.ConvertToken(bodyfilter);
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
                advancedOptionsObject["cultureName"] = CSharpExpressionConverter.ConvertToken(bodyadvancedOptionscultureName);
                advancedOptionsObjectpropCount++;
            }

            if (bodyadvancedOptionsisBoolean != null)
            {
                advancedOptionsObject["isBoolean"] = CSharpExpressionConverter.ConvertToken(bodyadvancedOptionsisBoolean);
                advancedOptionsObjectpropCount++;
            }

            if (advancedOptionsObjectpropCount > 0)
            {
                body["advancedOptions"] = advancedOptionsObject;
                bodypropCount++;
            }

            bodypropCount++;
            body["data"] = CSharpExpressionConverter.ConvertToken(bodydata);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<JToken[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<string[]> RegexMatches(Expression<Func<string>> bodypattern, Expression<Func<string>> bodydata, Expression<Func<string>> bodyfilter = null, Expression<Func<string>> bodyadvancedOptionscultureName = null, Expression<Func<string[]>> bodyadvancedOptionsisBoolean = null)
        {
            var apiCallPath = "/RegexMatches";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["pattern"] = CSharpExpressionConverter.ConvertToken(bodypattern);
            if (bodyfilter != null)
            {
                body["filter"] = CSharpExpressionConverter.ConvertToken(bodyfilter);
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
                advancedOptionsObject["cultureName"] = CSharpExpressionConverter.ConvertToken(bodyadvancedOptionscultureName);
                advancedOptionsObjectpropCount++;
            }

            if (bodyadvancedOptionsisBoolean != null)
            {
                advancedOptionsObject["isBoolean"] = CSharpExpressionConverter.ConvertToken(bodyadvancedOptionsisBoolean);
                advancedOptionsObjectpropCount++;
            }

            if (advancedOptionsObjectpropCount > 0)
            {
                body["advancedOptions"] = advancedOptionsObject;
                bodypropCount++;
            }

            bodypropCount++;
            body["data"] = CSharpExpressionConverter.ConvertToken(bodydata);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<string> SimpleConcatenate(Expression<Func<string[]>> bodydata, Expression<Func<string>> bodyseparator = null, Expression<Func<bool>> bodyignoreEmpty = null, Expression<Func<string>> bodyfilter = null, Expression<Func<bodysortOrderInput>> bodysortOrder = null, Expression<Func<string>> bodyadvancedOptionscultureName = null, Expression<Func<string[]>> bodyadvancedOptionsisBoolean = null)
        {
            var apiCallPath = "/SimpleConcatenate";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyseparator != null)
            {
                body["separator"] = CSharpExpressionConverter.ConvertToken(bodyseparator);
                bodypropCount++;
            }

            if (bodyignoreEmpty != null)
            {
                body["ignoreEmpty"] = CSharpExpressionConverter.ConvertToken(bodyignoreEmpty);
                bodypropCount++;
            }

            if (bodyfilter != null)
            {
                body["filter"] = CSharpExpressionConverter.ConvertToken(bodyfilter);
                bodypropCount++;
            }

            if (bodysortOrder != null)
            {
                body["sortOrder"] = CSharpExpressionConverter.Convert(bodysortOrder);
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
                advancedOptionsObject["cultureName"] = CSharpExpressionConverter.ConvertToken(bodyadvancedOptionscultureName);
                advancedOptionsObjectpropCount++;
            }

            if (bodyadvancedOptionsisBoolean != null)
            {
                advancedOptionsObject["isBoolean"] = CSharpExpressionConverter.ConvertToken(bodyadvancedOptionsisBoolean);
                advancedOptionsObjectpropCount++;
            }

            if (advancedOptionsObjectpropCount > 0)
            {
                body["advancedOptions"] = advancedOptionsObject;
                bodypropCount++;
            }

            bodypropCount++;
            body["data"] = CSharpExpressionConverter.ConvertToken(bodydata);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IWorkflowAction SimpleDistinct(Expression<Func<string>> bodyfield, Expression<Func<string>> bodyfilter = null, Expression<Func<bodysortOrderInput>> bodysortOrder = null, Expression<Func<string>> bodyadvancedOptionscultureName = null, Expression<Func<string[]>> bodyadvancedOptionsisBoolean = null, Expression<Func<JToken[]>> bodydata = null)
        {
            var apiCallPath = "/SimpleDistinct";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["field"] = CSharpExpressionConverter.ConvertToken(bodyfield);
            if (bodyfilter != null)
            {
                body["filter"] = CSharpExpressionConverter.ConvertToken(bodyfilter);
                bodypropCount++;
            }

            if (bodysortOrder != null)
            {
                body["sortOrder"] = CSharpExpressionConverter.Convert(bodysortOrder);
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
                advancedOptionsObject["cultureName"] = CSharpExpressionConverter.ConvertToken(bodyadvancedOptionscultureName);
                advancedOptionsObjectpropCount++;
            }

            if (bodyadvancedOptionsisBoolean != null)
            {
                advancedOptionsObject["isBoolean"] = CSharpExpressionConverter.ConvertToken(bodyadvancedOptionsisBoolean);
                advancedOptionsObjectpropCount++;
            }

            if (advancedOptionsObjectpropCount > 0)
            {
                body["advancedOptions"] = advancedOptionsObject;
                bodypropCount++;
            }

            if (bodydata != null)
            {
                body["data"] = CSharpExpressionConverter.ConvertToken(bodydata);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<JToken[]> SortObjectArray(Expression<Func<JToken[]>> bodydata = null)
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
                body["data"] = CSharpExpressionConverter.ConvertToken(bodydata);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<JToken[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<JToken[]> Split(Expression<Func<JToken[]>> bodysplits, Expression<Func<string>> bodyfilter = null, Expression<Func<string>> bodyadvancedOptionscultureName = null, Expression<Func<string[]>> bodyadvancedOptionsisBoolean = null, Expression<Func<JToken[]>> bodydata = null)
        {
            var apiCallPath = "/Split";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["splits"] = CSharpExpressionConverter.ConvertToken(bodysplits);
            if (bodyfilter != null)
            {
                body["filter"] = CSharpExpressionConverter.ConvertToken(bodyfilter);
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
                advancedOptionsObject["cultureName"] = CSharpExpressionConverter.ConvertToken(bodyadvancedOptionscultureName);
                advancedOptionsObjectpropCount++;
            }

            if (bodyadvancedOptionsisBoolean != null)
            {
                advancedOptionsObject["isBoolean"] = CSharpExpressionConverter.ConvertToken(bodyadvancedOptionsisBoolean);
                advancedOptionsObjectpropCount++;
            }

            if (advancedOptionsObjectpropCount > 0)
            {
                body["advancedOptions"] = advancedOptionsObject;
                bodypropCount++;
            }

            if (bodydata != null)
            {
                body["data"] = CSharpExpressionConverter.ConvertToken(bodydata);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<JToken[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<JToken[]> TextToJson(Expression<Func<string>> bodydata, Expression<Func<bool>> bodyheaderRow = null, Expression<Func<string>> bodyrowSeparator = null, Expression<Func<string>> bodydelimiter = null, Expression<Func<bodyencodingInput>> bodyencoding = null, Expression<Func<string>> bodyfilter = null, Expression<Func<string>> bodyadvancedOptionscultureName = null, Expression<Func<string[]>> bodyadvancedOptionsisBoolean = null)
        {
            var apiCallPath = "/TextToJson";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyheaderRow != null)
            {
                body["headerRow"] = CSharpExpressionConverter.ConvertToken(bodyheaderRow);
                bodypropCount++;
            }

            if (bodyrowSeparator != null)
            {
                body["rowSeparator"] = CSharpExpressionConverter.ConvertToken(bodyrowSeparator);
                bodypropCount++;
            }

            if (bodydelimiter != null)
            {
                body["delimiter"] = CSharpExpressionConverter.ConvertToken(bodydelimiter);
                bodypropCount++;
            }

            if (bodyencoding != null)
            {
                body["encoding"] = CSharpExpressionConverter.Convert(bodyencoding);
                bodypropCount++;
            }

            if (bodyfilter != null)
            {
                body["filter"] = CSharpExpressionConverter.ConvertToken(bodyfilter);
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
                advancedOptionsObject["cultureName"] = CSharpExpressionConverter.ConvertToken(bodyadvancedOptionscultureName);
                advancedOptionsObjectpropCount++;
            }

            if (bodyadvancedOptionsisBoolean != null)
            {
                advancedOptionsObject["isBoolean"] = CSharpExpressionConverter.ConvertToken(bodyadvancedOptionsisBoolean);
                advancedOptionsObjectpropCount++;
            }

            if (advancedOptionsObjectpropCount > 0)
            {
                body["advancedOptions"] = advancedOptionsObject;
                bodypropCount++;
            }

            bodypropCount++;
            body["data"] = CSharpExpressionConverter.ConvertToken(bodydata);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<JToken[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<JToken[]> Transform(Expression<Func<bool>> bodypreserveAllProperties = null, Expression<Func<string>> bodyfilter = null, Expression<Func<string>> bodyadvancedOptionscultureName = null, Expression<Func<string[]>> bodyadvancedOptionsisBoolean = null, Expression<Func<JToken[]>> bodydata = null)
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
                body["preserveAllProperties"] = CSharpExpressionConverter.ConvertToken(bodypreserveAllProperties);
                bodypropCount++;
            }

            if (bodyfilter != null)
            {
                body["filter"] = CSharpExpressionConverter.ConvertToken(bodyfilter);
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
                advancedOptionsObject["cultureName"] = CSharpExpressionConverter.ConvertToken(bodyadvancedOptionscultureName);
                advancedOptionsObjectpropCount++;
            }

            if (bodyadvancedOptionsisBoolean != null)
            {
                advancedOptionsObject["isBoolean"] = CSharpExpressionConverter.ConvertToken(bodyadvancedOptionsisBoolean);
                advancedOptionsObjectpropCount++;
            }

            if (advancedOptionsObjectpropCount > 0)
            {
                body["advancedOptions"] = advancedOptionsObject;
                bodypropCount++;
            }

            if (bodydata != null)
            {
                body["data"] = CSharpExpressionConverter.ConvertToken(bodydata);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<JToken[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<JToken[]> XmlToJson(Expression<Func<string>> bodydata, Expression<Func<string>> bodyprimaryLoopAtElement = null, Expression<Func<bodysubLoopAtElementsInputItem[]>> bodysubLoopAtElements = null)
        {
            var apiCallPath = "/XmlToJson";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyprimaryLoopAtElement != null)
            {
                body["primaryLoopAtElement"] = CSharpExpressionConverter.ConvertToken(bodyprimaryLoopAtElement);
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
                body["subLoopAtElements"] = CSharpExpressionConverter.ConvertToken(bodysubLoopAtElements);
                bodypropCount++;
            }

            bodypropCount++;
            body["data"] = CSharpExpressionConverter.ConvertToken(bodydata);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<JToken[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<ZipArchiveDecompressResponseItem[]> ZipArchiveDecompress(Expression<Func<string>> bodydata, Expression<Func<bool>> bodygetFileContents, Expression<Func<string>> bodyfilter = null)
        {
            var apiCallPath = "/ZipArchiveDecompress";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["data"] = CSharpExpressionConverter.ConvertToken(bodydata);
            bodypropCount++;
            body["getFileContents"] = CSharpExpressionConverter.ConvertToken(bodygetFileContents);
            if (bodyfilter != null)
            {
                body["filter"] = CSharpExpressionConverter.ConvertToken(bodyfilter);
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