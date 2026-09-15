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
            projectSettings["customerId"] = CSharpExpressionConverter.ConvertToken(projectSettingscustomerId);
            projectSettingspropCount++;
            projectSettings["id"] = CSharpExpressionConverter.ConvertToken(projectSettingsid);
            projectSettingspropCount++;
            projectSettings["name"] = CSharpExpressionConverter.ConvertToken(projectSettingsname);
            if (projectSettingsaddress != null)
            {
                projectSettings["address"] = CSharpExpressionConverter.ConvertToken(projectSettingsaddress);
                projectSettingspropCount++;
            }

            projectSettingspropCount++;
            projectSettings["contactPhone"] = CSharpExpressionConverter.ConvertToken(projectSettingscontactPhone);
            projectSettingspropCount++;
            projectSettings["contactEmail"] = CSharpExpressionConverter.ConvertToken(projectSettingscontactEmail);
            projectSettingspropCount++;
            projectSettings["responsible"] = CSharpExpressionConverter.ConvertToken(projectSettingsresponsible);
            projectSettingspropCount++;
            projectSettings["services"] = CSharpExpressionConverter.ConvertToken(projectSettingsservices);
            var settingsObject = new JObject();
            var settingsObjectpropCount = 0;
            if (projectSettingssettingsprojectAdminMembersAccess != null)
            {
                if (projectSettingssettingsprojectAdminMembersAccess != null)
                {
                    settingsObject["projectAdminMembersAccess"] = CSharpExpressionConverter.ConvertToken(projectSettingssettingsprojectAdminMembersAccess);
                    settingsObjectpropCount++;
                }

                settingsObjectpropCount++;
            }
            else
            {
                settingsObject["projectAdminMembersAccess"] = false;
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