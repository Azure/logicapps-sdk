//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Alembaitsm
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AlembaitsmActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "alembaitsm")]
        public IBodyWorkflowAction<JToken> SearchResource(Expression<Func<string>> categoryId, Expression<Func<string>> resource, Expression<Func<string>> partition, Expression<Func<string>> select, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<string>> skip = null, Expression<Func<int>> leftjoin = null, Expression<Func<int>> innerjoin = null, Expression<Func<bool>> inlinecount = null)
        {
            var apiCallPath = String.Format("/execute/{0}", ExpressionConverter.ConvertWithUrlEncoding(resource, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["categoryId"] = ExpressionConverter.Convert(categoryId);
            callPayload.Queries["$partition"] = ExpressionConverter.Convert(partition);
            callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            if (orderby != null)
                callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            if (skip != null)
                callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
            if (leftjoin != null)
                callPayload.Queries["$leftjoin"] = ExpressionConverter.Convert(leftjoin);
            if (innerjoin != null)
                callPayload.Queries["$innerjoin"] = ExpressionConverter.Convert(innerjoin);
            if (inlinecount != null)
                callPayload.Queries["$inlinecount"] = ExpressionConverter.Convert(inlinecount);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "alembaitsm")]
        public IBodyWorkflowAction<JToken> CreateResource(Expression<Func<string>> categoryId, Expression<Func<string>> resource, Expression<Func<object>> body = null)
        {
            var apiCallPath = String.Format("/execute/{0}", ExpressionConverter.ConvertWithUrlEncoding(resource, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["categoryId"] = ExpressionConverter.Convert(categoryId);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "alembaitsm")]
        public IBodyWorkflowAction<JToken> UpdateResource(Expression<Func<string>> categoryId, Expression<Func<string>> resource, Expression<Func<int>> id, Expression<Func<object>> body = null)
        {
            var apiCallPath = String.Format("/execute/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(resource, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["categoryId"] = ExpressionConverter.Convert(categoryId);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "alembaitsm")]
        public IBodyWorkflowAction<JToken> ResourceInteractions(Expression<Func<string>> categoryId, Expression<Func<string>> resource, Expression<Func<string>> interaction, Expression<Func<int>> id, Expression<Func<object>> body = null)
        {
            var apiCallPath = String.Format("/execute/{0}/{1}/{2}", ExpressionConverter.ConvertWithUrlEncoding(resource, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1), ExpressionConverter.ConvertWithUrlEncoding(interaction, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["categoryId"] = ExpressionConverter.Convert(categoryId);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<JToken>(callPayload);
        }
    }

    public class AlembaitsmTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger WebhookTrigger(Expression<Func<string>> bodyeventHandling, Expression<Func<int>> bodyentity, Expression<Func<string>> bodypayloadColumns, Expression<Func<string>> bodytriggerSecret = null, Expression<Func<string>> bodytriggerFilter = null, Expression<Func<string[]>> bodyindividualTrigger = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/webhook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["PayloadUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            bodypropCount++;
            body["Events"] = ExpressionConverter.ConvertO(bodyeventHandling);
            body["Active"] = true;
            bodypropCount++;
            bodypropCount++;
            body["EntityType"] = ExpressionConverter.ConvertO(bodyentity);
            bodypropCount++;
            body["PayloadSelect"] = ExpressionConverter.ConvertO(bodypayloadColumns);
            if (bodytriggerSecret != null)
            {
                body["Secret"] = ExpressionConverter.ConvertO(bodytriggerSecret);
                bodypropCount++;
            }

            if (bodytriggerFilter != null)
            {
                body["PayloadFilter"] = ExpressionConverter.ConvertO(bodytriggerFilter);
                bodypropCount++;
            }

            if (bodyindividualTrigger != null)
            {
                body["IndividualTriggers"] = ExpressionConverter.ConvertO(bodyindividualTrigger);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Alembaitsm;

    public partial class WorkflowManagedActions
    {
        public AlembaitsmActions Alembaitsm(string connectionId) => new AlembaitsmActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AlembaitsmTriggers Alembaitsm(string connectionId) => new AlembaitsmTriggers(connectionId);
    }
}