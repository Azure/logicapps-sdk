//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Survey123
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Survey123Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survey123")]
        public IWorkflowAction GetOwnedSurveyList()
        {
            var apiCallPath = "/api/survey/query";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["isPublished"] = Convert.ToString(true);
            callPayload.Queries["isQueryAll"] = Convert.ToString(true);
            callPayload.Queries["portalUrl"] = Convert.ToString("https://www.arcgis.com");
            return new ApiConnectionAction(callPayload);
        }
    }

    public class Survey123Triggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Survey123;

    public partial class WorkflowManagedActions
    {
        public Survey123Actions Survey123(string connectionId) => new Survey123Actions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Survey123Triggers Survey123(string connectionId) => new Survey123Triggers(connectionId);
    }
}