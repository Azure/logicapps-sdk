//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Maintenancerequestox
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MaintenancerequestoxActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "maintenancerequestox")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MaintenanceRequestOxmaint(Expression<Func<MaintenanceRequestOxmaintInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/workflows/81fb7bc062f3419a8c0ba8ac0132d631/triggers/manual/paths/invoke";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2016-06-01");
                callPayload.Queries["sp"] = Convert.ToString("/triggers/manual/run");
                callPayload.Queries["sv"] = Convert.ToString("1.0");
                callPayload.Queries["sig"] = Convert.ToString("7zabIRU45x3Syx725dxQyiiSUSNX3iIF0Jr-2wKcxY0");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class MaintenancerequestoxTriggers([ConnectionName] string connectionId)
    {
    }

    public class MaintenanceRequestOxmaintInput
    {
        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Title { get; set; }

        [JsonProperty("description", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Description { get; set; }

        [JsonProperty("priority", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Priority { get; set; }

        [JsonProperty("requested_by", DefaultValueHandling = DefaultValueHandling.Include)]
        public string RequestedBy { get; set; }

        [JsonProperty("date", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Date { get; set; }

        [JsonProperty("master_email", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MasterEmail { get; set; }

        [JsonProperty("api_key", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ApiKey { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Maintenancerequestox;

    public partial class WorkflowManagedActions
    {
        public MaintenancerequestoxActions Maintenancerequestox(string connectionId) => new MaintenancerequestoxActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MaintenancerequestoxTriggers Maintenancerequestox(string connectionId) => new MaintenancerequestoxTriggers(connectionId);
    }
}