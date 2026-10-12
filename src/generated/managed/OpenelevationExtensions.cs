//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Openelevation
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OpenelevationActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openelevation")]
        [WorkflowExpressionFactory(nameof(__BuildLookup))]
        public IBodyWorkflowAction<LookupResponse> Lookup([WorkflowExpression] Func<string> locations)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<LookupResponse> __BuildLookup(WorkflowExpression<string> locations)
        {
            WorkflowExpression.Validate(locations, nameof(locations), required: true);
            return new DeferredBodyAction<LookupResponse>(() =>
            {
                var apiCallPath = "/api/v1/lookup";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["locations"] = ExpressionConverter.Convert(locations);
                return new ApiConnectionAction<LookupResponse>(callPayload);
            });
        }
    }

    public class OpenelevationTriggers([ConnectionName] string connectionId)
    {
    }

    public class LookupResponse
    {
        [JsonProperty("results")]
        public LookupResponseResultsTypeItem[] Results { get; set; }
    }

    public class LookupResponseResultsTypeItem
    {
        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("elevation")]
        public double Elevation { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Openelevation;

    public partial class WorkflowManagedActions
    {
        public OpenelevationActions Openelevation(string connectionId) => new OpenelevationActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public OpenelevationTriggers Openelevation(string connectionId) => new OpenelevationTriggers(connectionId);
    }
}