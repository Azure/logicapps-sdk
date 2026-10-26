//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Openexperience
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OpenexperienceActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openexperience")]
        public IBodyWorkflowAction<CreateNewProjectResponse, ApiConnectionActionConfiguration> CreateNewProject(Expression<Func<CreateNewProjectInput>> projectSettings)
        {
            var __workflow_projectSettings = WorkflowExpression.Compile(projectSettings, nameof(projectSettings), required: true);
            return new DeferredBodyAction<CreateNewProjectResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/connector/createProject";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_projectSettings);
                return new ApiConnectionAction<CreateNewProjectResponse>(callPayload);
            });
        }
    }

    public class OpenexperienceTriggers([ConnectionName] string connectionId)
    {
    }

    public class CreateNewProjectResponse
    {
        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class CreateNewProjectInput
    {
        [JsonProperty("customerId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CustomerId { get; set; }

        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("contactPhone", DefaultValueHandling = DefaultValueHandling.Include)]
        public int ContactPhone { get; set; }

        [JsonProperty("contactEmail", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ContactEmail { get; set; }

        [JsonProperty("responsible", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Responsible { get; set; }

        [JsonProperty("services", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] Services { get; set; }

        [JsonProperty("settings", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateNewProjectInputSettingsType Settings { get; set; }
    }

    public class CreateNewProjectInputSettingsType
    {
        [JsonProperty("projectAdminMembersAccess", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool ProjectAdminMembersAccess { get; set; } = false;
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Openexperience;

    public partial class WorkflowManagedActions
    {
        public OpenexperienceActions Openexperience(string connectionId) => new OpenexperienceActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public OpenexperienceTriggers Openexperience(string connectionId) => new OpenexperienceTriggers(connectionId);
    }
}