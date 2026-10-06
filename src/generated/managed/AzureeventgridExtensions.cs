//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Azureeventgrid
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AzureeventgridActions([ConnectionName] string connectionId)
    {
    }

    public class AzureeventgridTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger CreateSubscription([WorkflowExpression] Func<string> subscriptionId, [WorkflowExpression] Func<string> resourceType, [WorkflowExpression] Func<string> subscriptionName = null, [WorkflowExpression] Func<string> bodypropertiesresourceName = null, [WorkflowExpression] Func<string> bodypropertiesfilterprefixFilter = null, [WorkflowExpression] Func<string> bodypropertiesfiltersuffixFilter = null, [WorkflowExpression] Func<string[]> bodypropertiesfiltereventType = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/providers/{1}/resource/eventSubscriptions", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(subscriptionId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(resourceType, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2017-09-15-preview");
                if (subscriptionName != null)
                    callPayload.Queries["subscriptionName"] = SourceExpressionConverter.ConvertO(subscriptionName);
                var body = new JObject();
                var bodypropCount = 0;
                var propertiesObject = new JObject();
                var propertiesObjectpropCount = 0;
                if (bodypropertiesresourceName != null)
                {
                    propertiesObject["topic"] = SourceExpressionConverter.ConvertToken(bodypropertiesresourceName);
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
                if (bodypropertiesfilterprefixFilter != null)
                {
                    filterObject["subjectBeginsWith"] = SourceExpressionConverter.ConvertToken(bodypropertiesfilterprefixFilter);
                    filterObjectpropCount++;
                }

                if (bodypropertiesfiltersuffixFilter != null)
                {
                    filterObject["subjectEndsWith"] = SourceExpressionConverter.ConvertToken(bodypropertiesfiltersuffixFilter);
                    filterObjectpropCount++;
                }

                if (bodypropertiesfiltereventType != null)
                {
                    filterObject["includedEventTypes"] = SourceExpressionConverter.ConvertToken(bodypropertiesfiltereventType);
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
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
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