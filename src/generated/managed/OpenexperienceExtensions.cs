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
        public IBodyWorkflowAction<CreateNewProjectResponse> CreateNewProject([WorkflowExpression] Func<string> projectSettingscustomerId, [WorkflowExpression] Func<string> projectSettingsid, [WorkflowExpression] Func<string> projectSettingsname, [WorkflowExpression] Func<int> projectSettingscontactPhone, [WorkflowExpression] Func<string> projectSettingscontactEmail, [WorkflowExpression] Func<string> projectSettingsresponsible, [WorkflowExpression] Func<string[]> projectSettingsservices, [WorkflowExpression] Func<string> projectSettingsaddress = null, [WorkflowExpression] Func<bool> projectSettingssettingsprojectAdminMembersAccess = null)
        {
            SourceExpression.Validate(projectSettingscustomerId, nameof(projectSettingscustomerId), required: true);
            SourceExpression.Validate(projectSettingsid, nameof(projectSettingsid), required: true);
            SourceExpression.Validate(projectSettingsname, nameof(projectSettingsname), required: true);
            SourceExpression.Validate(projectSettingscontactPhone, nameof(projectSettingscontactPhone), required: true);
            SourceExpression.Validate(projectSettingscontactEmail, nameof(projectSettingscontactEmail), required: true);
            SourceExpression.Validate(projectSettingsresponsible, nameof(projectSettingsresponsible), required: true);
            SourceExpression.Validate(projectSettingsservices, nameof(projectSettingsservices), required: true);
            SourceExpression.Validate(projectSettingsaddress, nameof(projectSettingsaddress), required: false);
            SourceExpression.Validate(projectSettingssettingsprojectAdminMembersAccess, nameof(projectSettingssettingsprojectAdminMembersAccess), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/connector/createProject";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var projectSettings = new JObject();
                var projectSettingspropCount = 0;
                projectSettingspropCount++;
                projectSettings["customerId"] = SourceExpressionConverter.ConvertToken(projectSettingscustomerId);
                projectSettingspropCount++;
                projectSettings["id"] = SourceExpressionConverter.ConvertToken(projectSettingsid);
                projectSettingspropCount++;
                projectSettings["name"] = SourceExpressionConverter.ConvertToken(projectSettingsname);
                if (projectSettingsaddress != null)
                {
                    projectSettings["address"] = SourceExpressionConverter.ConvertToken(projectSettingsaddress);
                    projectSettingspropCount++;
                }

                projectSettingspropCount++;
                projectSettings["contactPhone"] = SourceExpressionConverter.ConvertToken(projectSettingscontactPhone);
                projectSettingspropCount++;
                projectSettings["contactEmail"] = SourceExpressionConverter.ConvertToken(projectSettingscontactEmail);
                projectSettingspropCount++;
                projectSettings["responsible"] = SourceExpressionConverter.ConvertToken(projectSettingsresponsible);
                projectSettingspropCount++;
                projectSettings["services"] = SourceExpressionConverter.ConvertToken(projectSettingsservices);
                var settingsObject = new JObject();
                var settingsObjectpropCount = 0;
                if (projectSettingssettingsprojectAdminMembersAccess != null)
                {
                    if (projectSettingssettingsprojectAdminMembersAccess != null)
                    {
                        settingsObject["projectAdminMembersAccess"] = SourceExpressionConverter.ConvertToken(projectSettingssettingsprojectAdminMembersAccess);
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
                return callPayload;
            }

            return new ApiConnectionAction<CreateNewProjectResponse>(BuildSourceInput);
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