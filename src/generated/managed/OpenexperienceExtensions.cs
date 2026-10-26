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
        public IBodyWorkflowAction<CreateNewProjectResponse, ApiConnectionActionConfiguration> CreateNewProject(Expression<Func<string>> projectSettingscustomerId, Expression<Func<string>> projectSettingsid, Expression<Func<string>> projectSettingsname, Expression<Func<int>> projectSettingscontactPhone, Expression<Func<string>> projectSettingscontactEmail, Expression<Func<string>> projectSettingsresponsible, Expression<Func<string[]>> projectSettingsservices, Expression<Func<string>> projectSettingsaddress = null, Expression<Func<bool>> projectSettingssettingsprojectAdminMembersAccess = null)
        {
            var __workflow_projectSettingscustomerId = WorkflowExpression.Compile(projectSettingscustomerId, nameof(projectSettingscustomerId), required: true);
            var __workflow_projectSettingsid = WorkflowExpression.Compile(projectSettingsid, nameof(projectSettingsid), required: true);
            var __workflow_projectSettingsname = WorkflowExpression.Compile(projectSettingsname, nameof(projectSettingsname), required: true);
            var __workflow_projectSettingscontactPhone = WorkflowExpression.Compile(projectSettingscontactPhone, nameof(projectSettingscontactPhone), required: true);
            var __workflow_projectSettingscontactEmail = WorkflowExpression.Compile(projectSettingscontactEmail, nameof(projectSettingscontactEmail), required: true);
            var __workflow_projectSettingsresponsible = WorkflowExpression.Compile(projectSettingsresponsible, nameof(projectSettingsresponsible), required: true);
            var __workflow_projectSettingsservices = WorkflowExpression.Compile(projectSettingsservices, nameof(projectSettingsservices), required: true);
            var __workflow_projectSettingsaddress = WorkflowExpression.Compile(projectSettingsaddress, nameof(projectSettingsaddress), required: false);
            var __workflow_projectSettingssettingsprojectAdminMembersAccess = WorkflowExpression.Compile(projectSettingssettingsprojectAdminMembersAccess, nameof(projectSettingssettingsprojectAdminMembersAccess), required: false);
            return new DeferredBodyAction<CreateNewProjectResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/connector/createProject";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var projectSettings = new JObject();
                var projectSettingspropCount = 0;
                projectSettingspropCount++;
                projectSettings["customerId"] = ExpressionConverter.ConvertO(__workflow_projectSettingscustomerId);
                projectSettingspropCount++;
                projectSettings["id"] = ExpressionConverter.ConvertO(__workflow_projectSettingsid);
                projectSettingspropCount++;
                projectSettings["name"] = ExpressionConverter.ConvertO(__workflow_projectSettingsname);
                if (__workflow_projectSettingsaddress != null)
                {
                    projectSettings["address"] = ExpressionConverter.ConvertO(__workflow_projectSettingsaddress);
                    projectSettingspropCount++;
                }

                projectSettingspropCount++;
                projectSettings["contactPhone"] = ExpressionConverter.ConvertO(__workflow_projectSettingscontactPhone);
                projectSettingspropCount++;
                projectSettings["contactEmail"] = ExpressionConverter.ConvertO(__workflow_projectSettingscontactEmail);
                projectSettingspropCount++;
                projectSettings["responsible"] = ExpressionConverter.ConvertO(__workflow_projectSettingsresponsible);
                projectSettingspropCount++;
                projectSettings["services"] = ExpressionConverter.ConvertO(__workflow_projectSettingsservices);
                var settingsObject = new JObject();
                var settingsObjectpropCount = 0;
                if (__workflow_projectSettingssettingsprojectAdminMembersAccess != null)
                {
                    if (__workflow_projectSettingssettingsprojectAdminMembersAccess != null)
                    {
                        settingsObject["projectAdminMembersAccess"] = ExpressionConverter.ConvertO(__workflow_projectSettingssettingsprojectAdminMembersAccess);
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