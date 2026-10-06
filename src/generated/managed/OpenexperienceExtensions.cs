//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Openexperience
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OpenexperienceActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openexperience")]
        [WorkflowExpressionFactory(nameof(__BuildCreateNewProject))]
        public IBodyWorkflowAction<CreateNewProjectResponse> CreateNewProject([WorkflowExpression] Func<string> projectSettingscustomerId, [WorkflowExpression] Func<string> projectSettingsid, [WorkflowExpression] Func<string> projectSettingsname, [WorkflowExpression] Func<int> projectSettingscontactPhone, [WorkflowExpression] Func<string> projectSettingscontactEmail, [WorkflowExpression] Func<string> projectSettingsresponsible, [WorkflowExpression] Func<string[]> projectSettingsservices, [WorkflowExpression] Func<string> projectSettingsaddress = null, [WorkflowExpression] Func<bool> projectSettingssettingsprojectAdminMembersAccess = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openexperience")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateNewProjectResponse> __BuildCreateNewProject(WorkflowExpression<string> projectSettingscustomerId, WorkflowExpression<string> projectSettingsid, WorkflowExpression<string> projectSettingsname, WorkflowExpression<int> projectSettingscontactPhone, WorkflowExpression<string> projectSettingscontactEmail, WorkflowExpression<string> projectSettingsresponsible, WorkflowExpression<string[]> projectSettingsservices, WorkflowExpression<string> projectSettingsaddress = null, WorkflowExpression<bool> projectSettingssettingsprojectAdminMembersAccess = null)
        {
            WorkflowExpression.Validate(projectSettingscustomerId, nameof(projectSettingscustomerId), required: true);
            WorkflowExpression.Validate(projectSettingsid, nameof(projectSettingsid), required: true);
            WorkflowExpression.Validate(projectSettingsname, nameof(projectSettingsname), required: true);
            WorkflowExpression.Validate(projectSettingscontactPhone, nameof(projectSettingscontactPhone), required: true);
            WorkflowExpression.Validate(projectSettingscontactEmail, nameof(projectSettingscontactEmail), required: true);
            WorkflowExpression.Validate(projectSettingsresponsible, nameof(projectSettingsresponsible), required: true);
            WorkflowExpression.Validate(projectSettingsservices, nameof(projectSettingsservices), required: true);
            WorkflowExpression.Validate(projectSettingsaddress, nameof(projectSettingsaddress), required: false);
            WorkflowExpression.Validate(projectSettingssettingsprojectAdminMembersAccess, nameof(projectSettingssettingsprojectAdminMembersAccess), required: false);
            return new DeferredBodyAction<CreateNewProjectResponse>(() =>
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
                    if (projectSettingssettingsprojectAdminMembersAccess != null)
                    {
                        settingsObject["projectAdminMembersAccess"] = ExpressionConverter.ConvertO(projectSettingssettingsprojectAdminMembersAccess);
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