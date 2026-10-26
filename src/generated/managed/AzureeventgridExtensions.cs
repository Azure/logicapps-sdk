//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Azureeventgrid
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AzureeventgridActions([ConnectionName] string connectionId)
    {
    }

    public class AzureeventgridTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> CreateSubscription(Expression<Func<string>> subscriptionId, Expression<Func<string>> resourceType, Expression<Func<string>> subscriptionName = null, Expression<Func<string>> bodypropertiesresourceName = null, Expression<Func<string>> bodypropertiesfilterprefixFilter = null, Expression<Func<string>> bodypropertiesfiltersuffixFilter = null, Expression<Func<string[]>> bodypropertiesfiltereventType = null, FlowRecurrence recurrence = null)
        {
            var __workflow_subscriptionId = WorkflowExpression.Compile(subscriptionId, nameof(subscriptionId), required: true);
            var __workflow_resourceType = WorkflowExpression.Compile(resourceType, nameof(resourceType), required: true);
            var __workflow_subscriptionName = WorkflowExpression.Compile(subscriptionName, nameof(subscriptionName), required: false);
            var __workflow_bodypropertiesresourceName = WorkflowExpression.Compile(bodypropertiesresourceName, nameof(bodypropertiesresourceName), required: false);
            var __workflow_bodypropertiesfilterprefixFilter = WorkflowExpression.Compile(bodypropertiesfilterprefixFilter, nameof(bodypropertiesfilterprefixFilter), required: false);
            var __workflow_bodypropertiesfiltersuffixFilter = WorkflowExpression.Compile(bodypropertiesfiltersuffixFilter, nameof(bodypropertiesfiltersuffixFilter), required: false);
            var __workflow_bodypropertiesfiltereventType = WorkflowExpression.Compile(bodypropertiesfiltereventType, nameof(bodypropertiesfiltereventType), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/subscriptions/{0}/providers/{1}/resource/eventSubscriptions", __workflow_subscriptionId.WithUrlEncoding(1), __workflow_resourceType.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2017-09-15-preview");
                if (__workflow_subscriptionName != null)
                    callPayload.Queries["subscriptionName"] = ExpressionConverter.Convert(__workflow_subscriptionName);
                var body = new JObject();
                var bodypropCount = 0;
                var propertiesObject = new JObject();
                var propertiesObjectpropCount = 0;
                if (__workflow_bodypropertiesresourceName != null)
                {
                    propertiesObject["topic"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesresourceName);
                    propertiesObjectpropCount++;
                }

                var destinationObject = new JObject();
                var destinationObjectpropCount = 0;
                destinationObject["endpointType"] = "webhook";
                destinationObjectpropCount++;
                var propertiesObject2 = new JObject();
                var propertiesObject2propCount = 0;
                propertiesObject2["endpointUrl"] = "#{listCallbackUrl()}";
                propertiesObject2propCount++;
                if (propertiesObject2propCount > 0)
                {
                    destinationObject["properties"] = propertiesObject2;
                    destinationObjectpropCount++;
                }

                if (destinationObjectpropCount > 0)
                {
                    propertiesObject["destination"] = destinationObject;
                    propertiesObjectpropCount++;
                }

                var filterObject = new JObject();
                var filterObjectpropCount = 0;
                if (__workflow_bodypropertiesfilterprefixFilter != null)
                {
                    filterObject["subjectBeginsWith"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesfilterprefixFilter);
                    filterObjectpropCount++;
                }

                if (__workflow_bodypropertiesfiltersuffixFilter != null)
                {
                    filterObject["subjectEndsWith"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesfiltersuffixFilter);
                    filterObjectpropCount++;
                }

                if (__workflow_bodypropertiesfiltereventType != null)
                {
                    filterObject["includedEventTypes"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesfiltereventType);
                    filterObjectpropCount++;
                }

                if (filterObjectpropCount > 0)
                {
                    propertiesObject["filter"] = filterObject;
                    propertiesObjectpropCount++;
                }

                if (propertiesObjectpropCount > 0)
                {
                    body["properties"] = propertiesObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Azureeventgrid;

    public partial class WorkflowManagedActions
    {
        public AzureeventgridActions Azureeventgrid(string connectionId) => new AzureeventgridActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AzureeventgridTriggers Azureeventgrid(string connectionId) => new AzureeventgridTriggers(connectionId);
    }
}