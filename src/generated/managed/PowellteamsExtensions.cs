//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Powellteams
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PowellteamsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powellteams")]
        public IBodyWorkflowAction<PowellTeamsCommonCoreOperationResultSystemCollectionsGenericListPowellTeamsAPIModelsApprovalApiApprovalModel> GetBetaApprovalsPending()
        {
            var apiCallPath = "/beta/approvals/pending";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<PowellTeamsCommonCoreOperationResultSystemCollectionsGenericListPowellTeamsAPIModelsApprovalApiApprovalModel>(callPayload);
        }
    }

    public class PowellteamsTriggers([ConnectionName] string connectionId)
    {
    }

    public class PowellTeamsCommonCoreOperationResultSystemCollectionsGenericListPowellTeamsAPIModelsApprovalApiApprovalModel
    {
        public string CorrelationId { get; set; }
        public int ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
        public bool IsSucceed { get; set; }
        public PowellTeamsAPIModelsApprovalApiApprovalModel[] Result { get; set; }
    }

    public class PowellTeamsAPIModelsApprovalApiApprovalModel
    {
        public string Id { get; set; }
        public PowellTeamsAPIModelsApprovalApiApprovalHistoryModel[] Histories { get; set; }
        public PowellTeamsAPIModelsTeamApiTeamExtendModel Team { get; set; }
        public string TenantId { get; set; }
        public string Created { get; set; }
        public string[] Approvers { get; set; }
    }

    public class PowellTeamsAPIModelsApprovalApiApprovalHistoryModel
    {
        public string Id { get; set; }
        public int Status { get; set; }
        public string Comment { get; set; }
        public PowellTeamsAPIModelsUserApiUserModel Creator { get; set; }
        public string Created { get; set; }
    }

    public class PowellTeamsAPIModelsUserApiUserModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string AzureADId { get; set; }
        public string Email { get; set; }
        public int Role { get; set; }
        public string Language { get; set; }
        public string TenantId { get; set; }
    }

    public class PowellTeamsAPIModelsTeamApiTeamExtendModel
    {
        public string Id { get; set; }
        public string OfficeGroupId { get; set; }
        public string TenantId { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public string OriginalTitle { get; set; }
        public int OriginalIncrementOfNamingRule { get; set; }
        public string TeamTemplateId { get; set; }
        public string Photo { get; set; }
        public PowellTeamsAPIModelsTagApiTagSettingModel[] TagSettings { get; set; }
        public PowellTeamsAPIModelsTeamApiTeamExtendModelVisibilityType Visibility { get; set; }
        public string[] AdditionalMembers { get; set; }
        public string[] AdditionalGroupOwners { get; set; }
        public string[] AdditionalGroupMembers { get; set; }
        public string[] AdditionalOwners { get; set; }
        public bool IsArchived { get; set; }
        public string Classification { get; set; }
        public bool CurrentUserIsOwner { get; set; }
        public string Created { get; set; }
        public string ExpirationStart { get; set; }
        public string ExpirationDate { get; set; }
        public bool IsFavorite { get; set; }
        public string WebUrl { get; set; }
    }

    public class PowellTeamsAPIModelsTagApiTagSettingModel
    {
        public string Id { get; set; }
        public string DefaultValue { get; set; }
        public string ChoiceValue { get; set; }
        public string Type { get; set; }
        public string TagId { get; set; }
        public bool IsMandatory { get; set; }
        public bool IsShownToUsers { get; set; }
        public string ChoiceText { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public bool IsMultiValueChoice { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PowellTeamsAPIModelsTeamApiTeamExtendModelVisibilityType
    {
        UserChoice,
        Private,
        Public,
        HiddenMembership
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Powellteams;

    public partial class WorkflowManagedActions
    {
        public PowellteamsActions Powellteams(string connectionId) => new PowellteamsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PowellteamsTriggers Powellteams(string connectionId) => new PowellteamsTriggers(connectionId);
    }
}