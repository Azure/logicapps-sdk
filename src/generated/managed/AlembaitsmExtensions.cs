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
        public IBodyWorkflowAction<JToken> SearchResource([WorkflowExpression] Func<string> categoryId, [WorkflowExpression] Func<string> resource, [WorkflowExpression] Func<string> partition, [WorkflowExpression] Func<string> select, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<string> skip = null, [WorkflowExpression] Func<int> leftjoin = null, [WorkflowExpression] Func<int> innerjoin = null, [WorkflowExpression] Func<bool> inlinecount = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/execute/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(resource, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["categoryId"] = SourceExpressionConverter.ConvertO(categoryId);
                callPayload.Queries["$partition"] = SourceExpressionConverter.ConvertO(partition);
                callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (orderby != null)
                    callPayload.Queries["$orderby"] = SourceExpressionConverter.ConvertO(orderby);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                if (skip != null)
                    callPayload.Queries["$skip"] = SourceExpressionConverter.ConvertO(skip);
                if (leftjoin != null)
                    callPayload.Queries["$leftjoin"] = SourceExpressionConverter.ConvertO(leftjoin);
                if (innerjoin != null)
                    callPayload.Queries["$innerjoin"] = SourceExpressionConverter.ConvertO(innerjoin);
                if (inlinecount != null)
                    callPayload.Queries["$inlinecount"] = SourceExpressionConverter.ConvertO(inlinecount);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "alembaitsm")]
        public IBodyWorkflowAction<JToken> CreateResource([WorkflowExpression] Func<string> categoryId, [WorkflowExpression] Func<string> resource, [WorkflowExpression] Func<object> body = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/execute/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(resource, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["categoryId"] = SourceExpressionConverter.ConvertO(categoryId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "alembaitsm")]
        public IBodyWorkflowAction<JToken> UpdateResource([WorkflowExpression] Func<string> categoryId, [WorkflowExpression] Func<string> resource, [WorkflowExpression] Func<int> id, [WorkflowExpression] Func<object> body = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/execute/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(resource, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["categoryId"] = SourceExpressionConverter.ConvertO(categoryId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "alembaitsm")]
        public IBodyWorkflowAction<JToken> ResourceInteractions([WorkflowExpression] Func<string> categoryId, [WorkflowExpression] Func<string> resource, [WorkflowExpression] Func<string> interaction, [WorkflowExpression] Func<int> id, [WorkflowExpression] Func<object> body = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/execute/{0}/{1}/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(resource, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(interaction, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["categoryId"] = SourceExpressionConverter.ConvertO(categoryId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }
    }

    public class AlembaitsmTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger WebhookTrigger([WorkflowExpression] Func<string> bodyeventHandling, [WorkflowExpression] Func<int> bodyentity, [WorkflowExpression] Func<string> bodypayloadColumns, [WorkflowExpression] Func<string> bodytriggerSecret = null, [WorkflowExpression] Func<string> bodytriggerFilter = null, [WorkflowExpression] Func<string[]> bodyindividualTrigger = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/webhook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["PayloadUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["Events"] = SourceExpressionConverter.ConvertToken(bodyeventHandling);
                body["Active"] = true;
                bodypropCount++;
                bodypropCount++;
                body["EntityType"] = SourceExpressionConverter.ConvertToken(bodyentity);
                bodypropCount++;
                body["PayloadSelect"] = SourceExpressionConverter.ConvertToken(bodypayloadColumns);
                if (bodytriggerSecret != null)
                {
                    body["Secret"] = SourceExpressionConverter.ConvertToken(bodytriggerSecret);
                    bodypropCount++;
                }

                if (bodytriggerFilter != null)
                {
                    body["PayloadFilter"] = SourceExpressionConverter.ConvertToken(bodytriggerFilter);
                    bodypropCount++;
                }

                if (bodyindividualTrigger != null)
                {
                    body["IndividualTriggers"] = SourceExpressionConverter.ConvertToken(bodyindividualTrigger);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
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