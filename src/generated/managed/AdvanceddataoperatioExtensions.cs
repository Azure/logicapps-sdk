//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Advanceddataoperatio
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
            body["expression"] = ExpressionConverter.ConvertO(bodyexpression);
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
            body["data"] = ExpressionConverter.ConvertO(bodydata);
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
            body["data"] = ExpressionConverter.ConvertO(bodydata);
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
            body["data"] = ExpressionConverter.ConvertO(bodydata);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<LevenshteinDistanceResponse> LevenshteinDistance(Expression<Func<string>> bodybaseValue, Expression<Func<string[]>> bodycomparisonValues, Expression<Func<double>> bodySettingsratioThreshold = null, Expression<Func<bodySettingsapplyRatioThresholdToInput>> bodySettingsapplyRatioThresholdTo = null, Expression<Func<bodySettingsratioSelectionTypeInput>> bodySettingsratioSelectionType = null, Expression<Func<bodySettingstokenSortTypeInput>> bodySettingstokenSortType = null, Expression<Func<bool>> bodySettingscaseSensitive = null, Expression<Func<bool>> bodySettingsremoveWhitespace = null, Expression<Func<bool>> bodySettingsremoveSpecialCharacters = null)
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
            var SettingsObject = new JObject();
            var SettingsObjectpropCount = 0;
            if (bodySettingsratioThreshold != null)
            {
                SettingsObject["ratioThreshold"] = ExpressionConverter.ConvertO(bodySettingsratioThreshold);
                SettingsObjectpropCount++;
            }

            if (bodySettingsapplyRatioThresholdTo != null)
            {
                SettingsObject["applyRatioThresholdTo"] = ExpressionConverter.ConvertO(bodySettingsapplyRatioThresholdTo);
                SettingsObjectpropCount++;
            }

            if (bodySettingsratioSelectionType != null)
            {
                SettingsObject["ratioSelectionType"] = ExpressionConverter.ConvertO(bodySettingsratioSelectionType);
                SettingsObjectpropCount++;
            }

            if (bodySettingstokenSortType != null)
            {
                SettingsObject["tokenSortType"] = ExpressionConverter.ConvertO(bodySettingstokenSortType);
                SettingsObjectpropCount++;
            }

            if (bodySettingscaseSensitive != null)
            {
                SettingsObject["caseSensitive"] = ExpressionConverter.ConvertO(bodySettingscaseSensitive);
                SettingsObjectpropCount++;
            }

            if (bodySettingsremoveWhitespace != null)
            {
                SettingsObject["removeWhitespace"] = ExpressionConverter.ConvertO(bodySettingsremoveWhitespace);
                SettingsObjectpropCount++;
            }

            if (bodySettingsremoveSpecialCharacters != null)
            {
                SettingsObject["removeSpecialCharacters"] = ExpressionConverter.ConvertO(bodySettingsremoveSpecialCharacters);
                SettingsObjectpropCount++;
            }

            if (SettingsObjectpropCount > 0)
            {
                body["Settings"] = SettingsObject;
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
                body["data"] = ExpressionConverter.ConvertO(bodydata);
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

    public enum bodySettingsapplyRatioThresholdToInput
    {
        Max,
        Avg
    }

    public enum bodySettingsratioSelectionTypeInput
    {
        All,
        Standard,
        Partial
    }

    public enum bodySettingstokenSortTypeInput
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
    using Microsoft.Azure.Workflows.Sdk.Advanceddataoperatio;

    public partial class WorkflowManagedActions
    {
        public AdvanceddataoperatioActions Advanceddataoperatio(string connectionId) => new AdvanceddataoperatioActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AdvanceddataoperatioTriggers Advanceddataoperatio(string connectionId) => new AdvanceddataoperatioTriggers(connectionId);
    }
}