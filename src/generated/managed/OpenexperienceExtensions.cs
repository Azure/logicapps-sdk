//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Openexperience
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OpenexperienceActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openexperience")]
        public IBodyWorkflowAction<CreateNewProjectResponse> CreateNewProject(Expression<Func<string>> projectSettingscustomerId, Expression<Func<string>> projectSettingsid, Expression<Func<string>> projectSettingsname, Expression<Func<int>> projectSettingscontactPhone, Expression<Func<string>> projectSettingscontactEmail, Expression<Func<string>> projectSettingsresponsible, Expression<Func<string[]>> projectSettingsservices, Expression<Func<string>> projectSettingsaddress = null, Expression<Func<bool>> projectSettingssettingsprojectAdminMembersAccess = null)
        {
            var apiCallPath = "/connector/createProject";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var projectSettings = new JObject();
            var projectSettingspropCount = 0;
            projectSettingspropCount++;
            projectSettings["customerId"] = ExpressionConverter.ConvertO(projectSettingscustomerId);
            projectSettingspropCount++;
            projectSettings["id"] = ExpressionConverter.ConvertO(projectSettingsid);
            projectSettingspropCount++;
            projectSettings["name"] = ExpressionConverter.ConvertO(projectSettingsname);
            if (projectSettingsaddress != null)
            {
                projectSettings["address"] = ExpressionConverter.ConvertO(projectSettingsaddress);
                projectSettingspropCount++;
            }

            projectSettingspropCount++;
            projectSettings["contactPhone"] = ExpressionConverter.ConvertO(projectSettingscontactPhone);
            projectSettingspropCount++;
            projectSettings["contactEmail"] = ExpressionConverter.ConvertO(projectSettingscontactEmail);
            projectSettingspropCount++;
            projectSettings["responsible"] = ExpressionConverter.ConvertO(projectSettingsresponsible);
            projectSettingspropCount++;
            projectSettings["services"] = ExpressionConverter.ConvertO(projectSettingsservices);
            var settingsObject = new JObject();
            var settingsObjectpropCount = 0;
            if (projectSettingssettingsprojectAdminMembersAccess != null)
            {
                settingsObject["projectAdminMembersAccess"] = ExpressionConverter.ConvertO(projectSettingssettingsprojectAdminMembersAccess);
                settingsObjectpropCount++;
            }

            if (settingsObjectpropCount > 0)
            {
                projectSettings["settings"] = settingsObject;
                projectSettingspropCount++;
            }

            if (projectSettingspropCount > 0)
            {
                callPayload.Body = projectSettings;
            }

            return new ApiConnectionAction<CreateNewProjectResponse>(callPayload);
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