//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ewaycrm
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EwaycrmActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesResponseBase, ApiConnectionActionConfiguration> DeleteCompany(Expression<Func<DeleteCompanyInput>> deleteCompanyWrapper)
        {
            var __workflow_deleteCompanyWrapper = WorkflowExpression.Compile(deleteCompanyWrapper, nameof(deleteCompanyWrapper), required: true);
            return new DeferredBodyAction<EWayWcfServiceResponsesResponseBase, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DeleteCompany";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_deleteCompanyWrapper);
                return new ApiConnectionAction<EWayWcfServiceResponsesResponseBase>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesResponseBase, ApiConnectionActionConfiguration> DeleteContact(Expression<Func<DeleteContactInput>> deleteContactWrapper)
        {
            var __workflow_deleteContactWrapper = WorkflowExpression.Compile(deleteContactWrapper, nameof(deleteContactWrapper), required: true);
            return new DeferredBodyAction<EWayWcfServiceResponsesResponseBase, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DeleteContact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_deleteContactWrapper);
                return new ApiConnectionAction<EWayWcfServiceResponsesResponseBase>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesResponseBase, ApiConnectionActionConfiguration> DeleteJournal(Expression<Func<DeleteJournalInput>> deleteJournalWrapper)
        {
            var __workflow_deleteJournalWrapper = WorkflowExpression.Compile(deleteJournalWrapper, nameof(deleteJournalWrapper), required: true);
            return new DeferredBodyAction<EWayWcfServiceResponsesResponseBase, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DeleteJournal";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_deleteJournalWrapper);
                return new ApiConnectionAction<EWayWcfServiceResponsesResponseBase>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesResponseBase, ApiConnectionActionConfiguration> DeleteLead(Expression<Func<DeleteLeadInput>> deleteLeadWrapper)
        {
            var __workflow_deleteLeadWrapper = WorkflowExpression.Compile(deleteLeadWrapper, nameof(deleteLeadWrapper), required: true);
            return new DeferredBodyAction<EWayWcfServiceResponsesResponseBase, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DeleteLead";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_deleteLeadWrapper);
                return new ApiConnectionAction<EWayWcfServiceResponsesResponseBase>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesResponseBase, ApiConnectionActionConfiguration> DeleteProject(Expression<Func<DeleteProjectInput>> deleteProjectWrapper)
        {
            var __workflow_deleteProjectWrapper = WorkflowExpression.Compile(deleteProjectWrapper, nameof(deleteProjectWrapper), required: true);
            return new DeferredBodyAction<EWayWcfServiceResponsesResponseBase, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DeleteProject";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_deleteProjectWrapper);
                return new ApiConnectionAction<EWayWcfServiceResponsesResponseBase>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesResponseBase, ApiConnectionActionConfiguration> DeleteTask(Expression<Func<DeleteTaskInput>> deleteTaskWrapper)
        {
            var __workflow_deleteTaskWrapper = WorkflowExpression.Compile(deleteTaskWrapper, nameof(deleteTaskWrapper), required: true);
            return new DeferredBodyAction<EWayWcfServiceResponsesResponseBase, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DeleteTask";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_deleteTaskWrapper);
                return new ApiConnectionAction<EWayWcfServiceResponsesResponseBase>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesSaveResponse, ApiConnectionActionConfiguration> SaveCompany(Expression<Func<SaveCompanyInput>> saveCompanyWrapper)
        {
            var __workflow_saveCompanyWrapper = WorkflowExpression.Compile(saveCompanyWrapper, nameof(saveCompanyWrapper), required: true);
            return new DeferredBodyAction<EWayWcfServiceResponsesSaveResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SaveCompany";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_saveCompanyWrapper);
                return new ApiConnectionAction<EWayWcfServiceResponsesSaveResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesSaveResponse, ApiConnectionActionConfiguration> SaveContact(Expression<Func<SaveContactInput>> saveContactWrapper)
        {
            var __workflow_saveContactWrapper = WorkflowExpression.Compile(saveContactWrapper, nameof(saveContactWrapper), required: true);
            return new DeferredBodyAction<EWayWcfServiceResponsesSaveResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SaveContact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_saveContactWrapper);
                return new ApiConnectionAction<EWayWcfServiceResponsesSaveResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesSaveResponse, ApiConnectionActionConfiguration> SaveJournal(Expression<Func<SaveJournalInput>> saveJournalWrapper)
        {
            var __workflow_saveJournalWrapper = WorkflowExpression.Compile(saveJournalWrapper, nameof(saveJournalWrapper), required: true);
            return new DeferredBodyAction<EWayWcfServiceResponsesSaveResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SaveJournal";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_saveJournalWrapper);
                return new ApiConnectionAction<EWayWcfServiceResponsesSaveResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesSaveResponse, ApiConnectionActionConfiguration> SaveLead(Expression<Func<SaveLeadInput>> saveLeadWrapper)
        {
            var __workflow_saveLeadWrapper = WorkflowExpression.Compile(saveLeadWrapper, nameof(saveLeadWrapper), required: true);
            return new DeferredBodyAction<EWayWcfServiceResponsesSaveResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SaveLead";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_saveLeadWrapper);
                return new ApiConnectionAction<EWayWcfServiceResponsesSaveResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesSaveResponse, ApiConnectionActionConfiguration> SaveProject(Expression<Func<SaveProjectInput>> saveProjectWrapper)
        {
            var __workflow_saveProjectWrapper = WorkflowExpression.Compile(saveProjectWrapper, nameof(saveProjectWrapper), required: true);
            return new DeferredBodyAction<EWayWcfServiceResponsesSaveResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SaveProject";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_saveProjectWrapper);
                return new ApiConnectionAction<EWayWcfServiceResponsesSaveResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesBooleanResponse, ApiConnectionActionConfiguration> SaveRelation(Expression<Func<SaveRelationInput>> saveRelationWrapper)
        {
            var __workflow_saveRelationWrapper = WorkflowExpression.Compile(saveRelationWrapper, nameof(saveRelationWrapper), required: true);
            return new DeferredBodyAction<EWayWcfServiceResponsesBooleanResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SaveRelation";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_saveRelationWrapper);
                return new ApiConnectionAction<EWayWcfServiceResponsesBooleanResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesSaveResponse, ApiConnectionActionConfiguration> SaveTask(Expression<Func<SaveTaskInput>> saveTaskWrapper)
        {
            var __workflow_saveTaskWrapper = WorkflowExpression.Compile(saveTaskWrapper, nameof(saveTaskWrapper), required: true);
            return new DeferredBodyAction<EWayWcfServiceResponsesSaveResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SaveTask";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_saveTaskWrapper);
                return new ApiConnectionAction<EWayWcfServiceResponsesSaveResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedCompany, ApiConnectionActionConfiguration> SearchCompanies(Expression<Func<SearchCompaniesInput>> searchCompaniesWrapper)
        {
            var __workflow_searchCompaniesWrapper = WorkflowExpression.Compile(searchCompaniesWrapper, nameof(searchCompaniesWrapper), required: true);
            return new DeferredBodyAction<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedCompany, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SearchCompanies";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_searchCompaniesWrapper);
                return new ApiConnectionAction<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedCompany>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedContact, ApiConnectionActionConfiguration> SearchContacts(Expression<Func<SearchContactsInput>> searchContactsWrapper)
        {
            var __workflow_searchContactsWrapper = WorkflowExpression.Compile(searchContactsWrapper, nameof(searchContactsWrapper), required: true);
            return new DeferredBodyAction<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedContact, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SearchContacts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_searchContactsWrapper);
                return new ApiConnectionAction<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedContact>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedJournal, ApiConnectionActionConfiguration> SearchJournals(Expression<Func<SearchJournalsInput>> searchJournalsWrapper)
        {
            var __workflow_searchJournalsWrapper = WorkflowExpression.Compile(searchJournalsWrapper, nameof(searchJournalsWrapper), required: true);
            return new DeferredBodyAction<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedJournal, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SearchJournals";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_searchJournalsWrapper);
                return new ApiConnectionAction<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedJournal>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedLead, ApiConnectionActionConfiguration> SearchLeads(Expression<Func<SearchLeadsInput>> searchLeadsWrapper)
        {
            var __workflow_searchLeadsWrapper = WorkflowExpression.Compile(searchLeadsWrapper, nameof(searchLeadsWrapper), required: true);
            return new DeferredBodyAction<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedLead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SearchLeads";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_searchLeadsWrapper);
                return new ApiConnectionAction<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedLead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedProject, ApiConnectionActionConfiguration> SearchProjects(Expression<Func<SearchProjectsInput>> searchProjectsWrapper)
        {
            var __workflow_searchProjectsWrapper = WorkflowExpression.Compile(searchProjectsWrapper, nameof(searchProjectsWrapper), required: true);
            return new DeferredBodyAction<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedProject, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SearchProjects";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_searchProjectsWrapper);
                return new ApiConnectionAction<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedProject>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedTask, ApiConnectionActionConfiguration> SearchTasks(Expression<Func<SearchTasksInput>> searchTasksWrapper)
        {
            var __workflow_searchTasksWrapper = WorkflowExpression.Compile(searchTasksWrapper, nameof(searchTasksWrapper), required: true);
            return new DeferredBodyAction<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedTask, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SearchTasks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_searchTasksWrapper);
                return new ApiConnectionAction<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedTask>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesDataResponse1SystemGuid, ApiConnectionActionConfiguration> UnlinkItems(Expression<Func<UnlinkItemsInput>> unlinkItemsWrapper)
        {
            var __workflow_unlinkItemsWrapper = WorkflowExpression.Compile(unlinkItemsWrapper, nameof(unlinkItemsWrapper), required: true);
            return new DeferredBodyAction<EWayWcfServiceResponsesDataResponse1SystemGuid, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UnlinkItems";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_unlinkItemsWrapper);
                return new ApiConnectionAction<EWayWcfServiceResponsesDataResponse1SystemGuid>(callPayload);
            });
        }
    }

    public class EwaycrmTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedJournal, ApiConnectionTriggerConfiguration> NewOrUpdatedJournal(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedJournal, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger/NewOrUpdatedJournal";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedJournal>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedCompany, ApiConnectionTriggerConfiguration> NewOrUpdatedCompanies(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedCompany, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger/NewOrUpdatedCompanies";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedCompany>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedContact, ApiConnectionTriggerConfiguration> NewOrUpdatedContacts(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedContact, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger/NewOrUpdatedContacts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedContact>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedLead, ApiConnectionTriggerConfiguration> NewOrUpdatedLeads(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedLead, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger/NewOrUpdatedLeads";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedLead>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedProject, ApiConnectionTriggerConfiguration> NewOrUpdatedProjects(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedProject, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger/NewOrUpdatedProjects";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedProject>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedTask, ApiConnectionTriggerConfiguration> NewOrUpdatedTasks(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedTask, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger/NewOrUpdatedTasks";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedTask>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class EWayWcfServiceResponsesResponseBase
    {
        public string ReturnCode { get; set; }
        public string Description { get; set; }
    }

    public class DeleteCompanyInput
    {
        [JsonProperty("itemGuid")]
        public string ItemGuid { get; set; }
    }

    public class DeleteContactInput
    {
        [JsonProperty("itemGuid")]
        public string ItemGuid { get; set; }
    }

    public class DeleteJournalInput
    {
        [JsonProperty("itemGuid")]
        public string ItemGuid { get; set; }
    }

    public class DeleteLeadInput
    {
        [JsonProperty("itemGuid")]
        public string ItemGuid { get; set; }
    }

    public class DeleteProjectInput
    {
        [JsonProperty("itemGuid")]
        public string ItemGuid { get; set; }
    }

    public class DeleteTaskInput
    {
        [JsonProperty("itemGuid")]
        public string ItemGuid { get; set; }
    }

    public class EWayWcfServiceResponsesSaveResponse
    {
        [JsonProperty("Guid")]
        public string Id { get; set; }
        public string UserMessage { get; set; }
        public bool IsUserMessageOptionalError { get; set; }
        public string ReturnCode { get; set; }
        public string Description { get; set; }
    }

    public class SaveCompanyInput
    {
        [JsonProperty("transmitObject")]
        public EWayWcfServiceItemTypesGeneratedCompanyTracked TransmitObject { get; set; }

        [JsonProperty("dieOnItemConflict")]
        public bool? DieOnItemConflict { get; set; }

        [JsonProperty("ignoredUserErrorMessages")]
        public string[] IgnoredUserErrorMessages { get; set; }
    }

    public class EWayWcfServiceItemTypesGeneratedCompanyTracked
    {
        public string AccountNumber { get; set; }
        public string Address1POBox { get; set; }
        public string Address1Street { get; set; }
        public string Address1City { get; set; }
        public string Address1State { get; set; }
        public string Address1CountryEn { get; set; }
        public string Address1PostalCode { get; set; }
        public string Address2POBox { get; set; }
        public string Address2Street { get; set; }
        public string Address2City { get; set; }
        public string Address2State { get; set; }
        public string Address2CountryEn { get; set; }
        public string Address2PostalCode { get; set; }
        public string Address3POBox { get; set; }
        public string Address3Street { get; set; }
        public string Address3City { get; set; }
        public string Address3State { get; set; }
        public string Address3CountryEn { get; set; }
        public string Address3PostalCode { get; set; }
        public string CompanyName { get; set; }
        public string Department { get; set; }
        public string Email { get; set; }
        public int EmployeesCount { get; set; }
        public string Fax { get; set; }
        public string FirstContactEn { get; set; }
        public string ICQ { get; set; }
        public string IdentificationNumber { get; set; }
        public string ImportanceEn { get; set; }
        public string LineOfBusiness { get; set; }
        public bool MailingListOther { get; set; }
        public string Mobile { get; set; }
        public string MobileNormalized { get; set; }
        public string MSN { get; set; }
        public string Note { get; set; }
        public string Phone { get; set; }
        public string PhoneNormalized { get; set; }
        public bool Purchaser { get; set; }
        public double Reversal { get; set; }
        public string Skype { get; set; }
        public bool Suppliers { get; set; }
        public string VATNumber { get; set; }
        public string WebPage { get; set; }
        public double AdditionalDiscount { get; set; }

        [JsonProperty("ID")]
        public int Id { get; set; }
        public bool Competitor { get; set; }
        public string SalePriceGuid { get; set; }
        public bool NotificationByEmail { get; set; }
        public string NotificationBy { get; set; }
        public string LastActivity { get; set; }
        public string NextStep { get; set; }
        public bool EmailOptOut { get; set; }
        public string TypeEn { get; set; }
        public string StateEn { get; set; }
        public string PrevStateEn { get; set; }
        public string Picture { get; set; }
        public int PictureWidth { get; set; }
        public int PictureHeight { get; set; }
        public bool IsPrivate { get; set; }
        public string ItemCreated { get; set; }
        public string ItemChanged { get; set; }
        public string FileAs { get; set; }
        public string OwnerGUID { get; set; }
        public string CreatedByGUID { get; set; }
        public string ModifiedByGUID { get; set; }
        public JToken AdditionalFields { get; set; }
        public string ItemGUID { get; set; }
        public int ItemVersion { get; set; }
    }

    public class SaveContactInput
    {
        [JsonProperty("transmitObject")]
        public EWayWcfServiceItemTypesGeneratedContactTracked TransmitObject { get; set; }

        [JsonProperty("dieOnItemConflict")]
        public bool? DieOnItemConflict { get; set; }

        [JsonProperty("ignoredUserErrorMessages")]
        public string[] IgnoredUserErrorMessages { get; set; }
    }

    public class EWayWcfServiceItemTypesGeneratedContactTracked
    {
        public string BusinessAddressStreet { get; set; }
        public string BusinessAddressCity { get; set; }
        public string BusinessAddressState { get; set; }
        public string BusinessAddressCountryEn { get; set; }
        public string BusinessAddressPOBox { get; set; }
        public string BusinessAddressPostalCode { get; set; }
        public string HomeAddressStreet { get; set; }
        public string HomeAddressCity { get; set; }
        public string HomeAddressState { get; set; }
        public string HomeAddressCountryEn { get; set; }
        public string HomeAddressPOBox { get; set; }
        public string HomeAddressPostalCode { get; set; }
        public string OtherAddressStreet { get; set; }
        public string OtherAddressCity { get; set; }
        public string OtherAddressState { get; set; }
        public string OtherAddressCountryEn { get; set; }
        public string OtherAddressPOBox { get; set; }
        public string OtherAddressPostalCode { get; set; }
        public string Company { get; set; }
        public string Email1Address { get; set; }
        public string Email2Address { get; set; }
        public string Email3Address { get; set; }
        public string FirstName { get; set; }
        public string ICQ { get; set; }
        public string ImportanceEn { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string MSN { get; set; }
        public string Note { get; set; }
        public string PrefixEn { get; set; }
        public string SuffixEn { get; set; }
        public string Skype { get; set; }
        public string TelephoneNumber1 { get; set; }
        public string TelephoneNumber2 { get; set; }
        public string TelephoneNumber3 { get; set; }
        public string TelephoneNumber4 { get; set; }
        public string TelephoneNumber5 { get; set; }
        public string TelephoneNumber6 { get; set; }
        public string TelephoneNumber1Normalized { get; set; }
        public string TelephoneNumber2Normalized { get; set; }
        public string TelephoneNumber3Normalized { get; set; }
        public string TelephoneNumber4Normalized { get; set; }
        public string TelephoneNumber5Normalized { get; set; }
        public string TelephoneNumber6Normalized { get; set; }
        public string Department { get; set; }
        public string Title { get; set; }
        public string WebPage { get; set; }
        public bool DoNotSendNewsletter { get; set; }
        public string ProfilePicture { get; set; }
        public int ProfilePictureWidth { get; set; }
        public int ProfilePictureHeight { get; set; }
        public string LastActivity { get; set; }
        public string NextStep { get; set; }
        public string TypeEn { get; set; }
        public string StateEn { get; set; }
        public string PrevStateEn { get; set; }

        [JsonProperty("Companies_CompanyGuid")]
        public string CompaniesCompanyGuid { get; set; }
        public bool IsPrivate { get; set; }
        public string ItemCreated { get; set; }
        public string ItemChanged { get; set; }
        public string FileAs { get; set; }
        public string OwnerGUID { get; set; }
        public string CreatedByGUID { get; set; }
        public string ModifiedByGUID { get; set; }
        public JToken AdditionalFields { get; set; }
        public string ItemGUID { get; set; }
        public int ItemVersion { get; set; }
    }

    public class SaveJournalInput
    {
        [JsonProperty("transmitObject")]
        public EWayWcfServiceItemTypesGeneratedJournalTracked TransmitObject { get; set; }

        [JsonProperty("dieOnItemConflict")]
        public bool? DieOnItemConflict { get; set; }

        [JsonProperty("ignoredUserErrorMessages")]
        public string[] IgnoredUserErrorMessages { get; set; }
    }

    public class EWayWcfServiceItemTypesGeneratedJournalTracked
    {
        [JsonProperty("CalendarEntryID")]
        public string CalendarEntryId { get; set; }

        [JsonProperty("Calendar_ORIGIN")]
        public string CalendarORIGIN { get; set; }
        public string ChangedField { get; set; }
        public string EventEnd { get; set; }
        public string EventStart { get; set; }
        public string FieldValue { get; set; }
        public string ImportanceEn { get; set; }
        public string Note { get; set; }
        public string PrevFieldValue { get; set; }
        public string TypeEn { get; set; }
        public bool IsSystem { get; set; }
        public string Phone { get; set; }
        public string PhoneNormalized { get; set; }
        public bool IsGdprRelevant { get; set; }
        public string Picture { get; set; }
        public int PictureWidth { get; set; }
        public int PictureHeight { get; set; }
        public string StateEn { get; set; }
        public string PrevStateEn { get; set; }

        [JsonProperty("Companies_CompanyGuid")]
        public string CompaniesCompanyGuid { get; set; }

        [JsonProperty("Contacts_ContactGuid")]
        public string ContactsContactGuid { get; set; }

        [JsonProperty("Leads_SuperiorItemGuid")]
        public string LeadsSuperiorItemGuid { get; set; }

        [JsonProperty("Projects_SuperiorItemGuid")]
        public string ProjectsSuperiorItemGuid { get; set; }

        [JsonProperty("Marketing_MarketingGuid")]
        public string MarketingMarketingGuid { get; set; }
        public bool IsPrivate { get; set; }
        public string ItemCreated { get; set; }
        public string ItemChanged { get; set; }
        public string FileAs { get; set; }
        public string OwnerGUID { get; set; }
        public string CreatedByGUID { get; set; }
        public string ModifiedByGUID { get; set; }
        public JToken AdditionalFields { get; set; }
        public string ItemGUID { get; set; }
        public int ItemVersion { get; set; }
    }

    public class SaveLeadInput
    {
        [JsonProperty("transmitObject")]
        public EWayWcfServiceItemTypesGeneratedLeadTracked TransmitObject { get; set; }

        [JsonProperty("dieOnItemConflict")]
        public bool? DieOnItemConflict { get; set; }

        [JsonProperty("ignoredUserErrorMessages")]
        public string[] IgnoredUserErrorMessages { get; set; }
    }

    public class EWayWcfServiceItemTypesGeneratedLeadTracked
    {
        public string City { get; set; }
        public string ContactPerson { get; set; }
        public string CurrencyEn { get; set; }
        public string Customer { get; set; }
        public string Email { get; set; }
        public string EstimatedEnd { get; set; }

        [JsonProperty("HID")]
        public int HId { get; set; }
        public string LeadOriginEn { get; set; }
        public string Note { get; set; }
        public string Phone { get; set; }
        public string PhoneNormalized { get; set; }
        public string PrevStateEn { get; set; }
        public double Price { get; set; }
        public string PriceChanged { get; set; }
        public double PriceDefaultCurrency { get; set; }
        public double Probability { get; set; }
        public string ReceiveDate { get; set; }
        public string StateEn { get; set; }
        public string Street { get; set; }
        public string TypeEn { get; set; }
        public string Zip { get; set; }
        public string LastActivity { get; set; }
        public string NextStep { get; set; }
        public double EstimatedValue { get; set; }
        public string CountryEn { get; set; }
        public string State { get; set; }
        public string POBox { get; set; }
        public bool EmailOptOut { get; set; }
        public string Picture { get; set; }
        public int PictureWidth { get; set; }
        public int PictureHeight { get; set; }

        [JsonProperty("Companies_CustomerGuid")]
        public string CompaniesCustomerGuid { get; set; }

        [JsonProperty("Contacts_ContactPersonGuid")]
        public string ContactsContactPersonGuid { get; set; }

        [JsonProperty("Marketing_MarketingGuid")]
        public string MarketingMarketingGuid { get; set; }
        public bool IsPrivate { get; set; }
        public string ItemCreated { get; set; }
        public string ItemChanged { get; set; }
        public string FileAs { get; set; }
        public string OwnerGUID { get; set; }
        public string CreatedByGUID { get; set; }
        public string ModifiedByGUID { get; set; }
        public JToken AdditionalFields { get; set; }
        public string ItemGUID { get; set; }
        public int ItemVersion { get; set; }
    }

    public class SaveProjectInput
    {
        [JsonProperty("transmitObject")]
        public EWayWcfServiceItemTypesGeneratedProjectTracked TransmitObject { get; set; }

        [JsonProperty("dieOnItemConflict")]
        public bool? DieOnItemConflict { get; set; }

        [JsonProperty("ignoredUserErrorMessages")]
        public string[] IgnoredUserErrorMessages { get; set; }
    }

    public class EWayWcfServiceItemTypesGeneratedProjectTracked
    {
        public string Note { get; set; }
        public double Price { get; set; }
        public string ProjectEnd { get; set; }
        public string ProjectName { get; set; }
        public string TypeEn { get; set; }
        public string StateEn { get; set; }
        public double PeopleExpenses { get; set; }
        public string ProjectRealEnd { get; set; }
        public double EstimatedPrice { get; set; }

        [JsonProperty("HID")]
        public int HId { get; set; }
        public string ProjectOriginEn { get; set; }
        public string PaymentTypeEn { get; set; }
        public double OtherExpenses { get; set; }
        public double Margin { get; set; }
        public double Profit { get; set; }
        public int PaymentMaturity { get; set; }
        public string InvoicePaymentDate { get; set; }
        public string InvoiceIssueDate { get; set; }
        public double EstimatedMargin { get; set; }
        public double EstimatedProfit { get; set; }
        public double EstimatedPeopleExpenses { get; set; }
        public double EstimatedOtherExpenses { get; set; }
        public int LicensesCount { get; set; }
        public double LicensePrice { get; set; }
        public string PrevStateEn { get; set; }
        public bool ShowInCaplan { get; set; }
        public string ProjectStart { get; set; }
        public int EstimatedWorkHours { get; set; }
        public double TotalWorkHours { get; set; }
        public double EstimatedPeopleExpensesDefaultCurrency { get; set; }
        public double EstimatedOtherExpensesDefaultCurrency { get; set; }
        public double EstimatedPriceDefaultCurrency { get; set; }
        public double PeopleExpensesDefaultCurrency { get; set; }
        public double OtherExpensesDefaultCurrency { get; set; }
        public double PriceDefaultCurrency { get; set; }
        public double ProfitDefaultCurrency { get; set; }
        public double EstimatedProfitDefaultCurrency { get; set; }
        public string CurrencyEn { get; set; }
        public string EstimatedPeopleExpensesChanged { get; set; }
        public string EstimatedOtherExpensesChanged { get; set; }
        public string OtherExpensesChanged { get; set; }
        public string EstimatedPriceChanged { get; set; }
        public string PriceChanged { get; set; }
        public string LicensePriceChanged { get; set; }
        public double LicensePriceDefaultCurrency { get; set; }
        public string LastActivity { get; set; }
        public string NextStep { get; set; }
        public string PeopleExpensesChanged { get; set; }
        public string Picture { get; set; }
        public int PictureWidth { get; set; }
        public int PictureHeight { get; set; }

        [JsonProperty("Companies_CustomerGuid")]
        public string CompaniesCustomerGuid { get; set; }

        [JsonProperty("Contacts_ContactPersonGuid")]
        public string ContactsContactPersonGuid { get; set; }

        [JsonProperty("Leads_Project_OriginGuid")]
        public string LeadsProjectOriginGuid { get; set; }

        [JsonProperty("Projects_SuperiorProjectGuid")]
        public string ProjectsSuperiorProjectGuid { get; set; }

        [JsonProperty("Users_SupervisorGuid")]
        public string UsersSupervisorGuid { get; set; }
        public bool IsPrivate { get; set; }
        public string ItemCreated { get; set; }
        public string ItemChanged { get; set; }
        public string FileAs { get; set; }
        public string OwnerGUID { get; set; }
        public string CreatedByGUID { get; set; }
        public string ModifiedByGUID { get; set; }
        public JToken AdditionalFields { get; set; }
        public string ItemGUID { get; set; }
        public int ItemVersion { get; set; }
    }

    public class EWayWcfServiceResponsesBooleanResponse
    {
        public bool Result { get; set; }
        public string ReturnCode { get; set; }
        public string Description { get; set; }
    }

    public class SaveRelationInput
    {
        [JsonProperty("transmitObject", DefaultValueHandling = DefaultValueHandling.Include)]
        public EWayWcfServiceItemTypesRelation TransmitObject { get; set; }
    }

    public class EWayWcfServiceItemTypesRelation
    {
        public string ItemGUID1 { get; set; }
        public string ItemGUID2 { get; set; }
        public EWayWcfServiceItemTypesRelationFolderName1Type FolderName1 { get; set; }
        public EWayWcfServiceItemTypesRelationFolderName2Type FolderName2 { get; set; }
        public string RelationType { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EWayWcfServiceItemTypesRelationFolderName1Type
    {
        Actions,
        AdditionalFields,
        Bonuses,
        Calendar,
        CapacityNotes,
        CapacityNoteTypes,
        Carts,
        ColumnPermissions,
        Companies,
        Contacts,
        CurrencyExchangeRates,
        Documents,
        Emails,
        EnumTypes,
        EnumValues,
        EnumValuesRelations,
        Features,
        Flows,
        GlobalSettings,
        Goals,
        Goods,
        GoodsInCart,
        GoodsInSet,
        Groups,
        History,
        Holidays,
        Children,
        IndividualDiscounts,
        InvoiceItems,
        Invoices,
        ItemCopyRelations,
        Journal,
        Knowledge,
        Layouts,
        LayoutsModels,
        Leads,
        Ledger,
        Mappings,
        Marketing,
        MarketingList,
        MarketingListSources,
        Models,
        ModulePermissions,
        ObjectTypesOptions,
        Payments,
        PriceListGroups,
        ProjectAssignments,
        ProjectAssignmentsPerUserProject,
        ProjectAssignmentsTotal,
        ProjectAssignmentsTotalUserProject,
        ProjectList,
        Projects,
        ProjectUsersInCaPlan,
        RelationData,
        Relations,
        Reports,
        RevisionsHistory,
        Salaries,
        SalePrices,
        Prices,
        SqlObjects,
        Tasks,
        RecurrencePatterns,
        TeamRoles,
        Templates,
        Training,
        UnifiedRelations,
        Users,
        UserSettings,
        Vacation,
        WebAccess2Options,
        WebAccessOptions,
        WorkCommitments,
        WorkflowHistory,
        WorkReports,
        WrongClientVersions,
        XsltTransformations
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EWayWcfServiceItemTypesRelationFolderName2Type
    {
        Actions,
        AdditionalFields,
        Bonuses,
        Calendar,
        CapacityNotes,
        CapacityNoteTypes,
        Carts,
        ColumnPermissions,
        Companies,
        Contacts,
        CurrencyExchangeRates,
        Documents,
        Emails,
        EnumTypes,
        EnumValues,
        EnumValuesRelations,
        Features,
        Flows,
        GlobalSettings,
        Goals,
        Goods,
        GoodsInCart,
        GoodsInSet,
        Groups,
        History,
        Holidays,
        Children,
        IndividualDiscounts,
        InvoiceItems,
        Invoices,
        ItemCopyRelations,
        Journal,
        Knowledge,
        Layouts,
        LayoutsModels,
        Leads,
        Ledger,
        Mappings,
        Marketing,
        MarketingList,
        MarketingListSources,
        Models,
        ModulePermissions,
        ObjectTypesOptions,
        Payments,
        PriceListGroups,
        ProjectAssignments,
        ProjectAssignmentsPerUserProject,
        ProjectAssignmentsTotal,
        ProjectAssignmentsTotalUserProject,
        ProjectList,
        Projects,
        ProjectUsersInCaPlan,
        RelationData,
        Relations,
        Reports,
        RevisionsHistory,
        Salaries,
        SalePrices,
        Prices,
        SqlObjects,
        Tasks,
        RecurrencePatterns,
        TeamRoles,
        Templates,
        Training,
        UnifiedRelations,
        Users,
        UserSettings,
        Vacation,
        WebAccess2Options,
        WebAccessOptions,
        WorkCommitments,
        WorkflowHistory,
        WorkReports,
        WrongClientVersions,
        XsltTransformations
    }

    public class SaveTaskInput
    {
        [JsonProperty("transmitObject")]
        public EWayWcfServiceItemTypesGeneratedTaskTracked TransmitObject { get; set; }

        [JsonProperty("dieOnItemConflict")]
        public bool? DieOnItemConflict { get; set; }

        [JsonProperty("ignoredUserErrorMessages")]
        public string[] IgnoredUserErrorMessages { get; set; }
    }

    public class EWayWcfServiceItemTypesGeneratedTaskTracked
    {
        public string Body { get; set; }
        public bool IsCompleted { get; set; }
        public string DueDate { get; set; }
        public double PercentCompleteDecimal { get; set; }
        public string PrevStateEn { get; set; }
        public string StartDate { get; set; }
        public string StateEn { get; set; }
        public string Subject { get; set; }
        public string TypeEn { get; set; }
        public int Level { get; set; }
        public string ImportanceEn { get; set; }
        public double ActualWorkHours { get; set; }
        public double EstimatedWorkHours { get; set; }
        public bool IsReminderSet { get; set; }
        public string ReminderDate { get; set; }
        public string CompletedDate { get; set; }
        public string Picture { get; set; }
        public int PictureWidth { get; set; }
        public int PictureHeight { get; set; }

        [JsonProperty("Leads_TaskParentGuid")]
        public string LeadsTaskParentGuid { get; set; }

        [JsonProperty("Projects_TaskParentGuid")]
        public string ProjectsTaskParentGuid { get; set; }

        [JsonProperty("Tasks_TaskParentGuid")]
        public string TasksTaskParentGuid { get; set; }

        [JsonProperty("Marketing_TaskParentGuid")]
        public string MarketingTaskParentGuid { get; set; }

        [JsonProperty("Companies_CompanyGuid")]
        public string CompaniesCompanyGuid { get; set; }

        [JsonProperty("Contacts_ContactGuid")]
        public string ContactsContactGuid { get; set; }

        [JsonProperty("Users_TaskDelegatorGuid")]
        public string UsersTaskDelegatorGuid { get; set; }

        [JsonProperty("Users_TaskSolverGuid")]
        public string UsersTaskSolverGuid { get; set; }

        [JsonProperty("Tasks_TaskOriginGuid")]
        public string TasksTaskOriginGuid { get; set; }
        public bool IsPrivate { get; set; }
        public string ItemCreated { get; set; }
        public string ItemChanged { get; set; }
        public string FileAs { get; set; }
        public string OwnerGUID { get; set; }
        public string CreatedByGUID { get; set; }
        public string ModifiedByGUID { get; set; }
        public JToken AdditionalFields { get; set; }
        public string ItemGUID { get; set; }
        public int ItemVersion { get; set; }
    }

    public class EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedCompany
    {
        public EWayWcfServiceItemTypesGeneratedCompany[] Data { get; set; }
        public string ReturnCode { get; set; }
        public string Description { get; set; }
    }

    public class EWayWcfServiceItemTypesGeneratedCompany
    {
        public string AccountNumber { get; set; }
        public string Address1POBox { get; set; }
        public string Address1Street { get; set; }
        public string Address1City { get; set; }
        public string Address1State { get; set; }
        public string Address1CountryEn { get; set; }
        public string Address1PostalCode { get; set; }
        public string Address2POBox { get; set; }
        public string Address2Street { get; set; }
        public string Address2City { get; set; }
        public string Address2State { get; set; }
        public string Address2CountryEn { get; set; }
        public string Address2PostalCode { get; set; }
        public string Address3POBox { get; set; }
        public string Address3Street { get; set; }
        public string Address3City { get; set; }
        public string Address3State { get; set; }
        public string Address3CountryEn { get; set; }
        public string Address3PostalCode { get; set; }
        public string CompanyName { get; set; }
        public string Department { get; set; }
        public string Email { get; set; }
        public int EmployeesCount { get; set; }
        public string Fax { get; set; }
        public string FirstContactEn { get; set; }
        public string ICQ { get; set; }
        public string IdentificationNumber { get; set; }
        public string ImportanceEn { get; set; }
        public string LineOfBusiness { get; set; }
        public bool MailingListOther { get; set; }
        public string Mobile { get; set; }
        public string MobileNormalized { get; set; }
        public string MSN { get; set; }
        public string Note { get; set; }
        public string Phone { get; set; }
        public string PhoneNormalized { get; set; }
        public bool Purchaser { get; set; }
        public double Reversal { get; set; }
        public string Skype { get; set; }
        public bool Suppliers { get; set; }
        public string VATNumber { get; set; }
        public string WebPage { get; set; }
        public double AdditionalDiscount { get; set; }

        [JsonProperty("ID")]
        public int Id { get; set; }
        public bool Competitor { get; set; }
        public string SalePriceGuid { get; set; }
        public bool NotificationByEmail { get; set; }
        public string NotificationBy { get; set; }
        public string LastActivity { get; set; }
        public string NextStep { get; set; }
        public bool EmailOptOut { get; set; }
        public string TypeEn { get; set; }
        public string StateEn { get; set; }
        public string PrevStateEn { get; set; }
        public string Picture { get; set; }
        public int PictureWidth { get; set; }
        public int PictureHeight { get; set; }
        public bool IsPrivate { get; set; }

        [JsonProperty("Server_ItemCreated")]
        public string ServerItemCreated { get; set; }

        [JsonProperty("Server_ItemChanged")]
        public string ServerItemChanged { get; set; }
        public string ItemCreated { get; set; }
        public string ItemChanged { get; set; }
        public string FileAs { get; set; }
        public string OwnerGUID { get; set; }
        public string CreatedByGUID { get; set; }
        public string ModifiedByGUID { get; set; }
        public JToken AdditionalFields { get; set; }
        public EWayWcfServiceItemTypesInnerTypesBoundRelation[] Relations { get; set; }
        public string ItemGUID { get; set; }
        public int ItemVersion { get; set; }
    }

    public class EWayWcfServiceItemTypesInnerTypesBoundRelation
    {
        public string ItemGUID { get; set; }
        public string RelationDataGUID { get; set; }
        public string RelationType { get; set; }
        public string ForeignFolderName { get; set; }
        public string ForeignItemGUID { get; set; }
        public bool DifferDirection { get; set; }
        public string OwnerGUID { get; set; }
        public string MainItemGUID { get; set; }
    }

    public class SearchCompaniesInput
    {
        [JsonProperty("transmitObject")]
        public EWayWcfServiceItemTypesGeneratedCompanyWithFKs TransmitObject { get; set; }

        [JsonProperty("includeRelations")]
        public bool? IncludeRelations { get; set; }

        [JsonProperty("relationsFilter")]
        public EWayWcfServiceItemTypesBoundRelationsFilter RelationsFilter { get; set; }

        [JsonProperty("binaryLogicalOperator")]
        public string BinaryLogicalOperator { get; set; }
    }

    public class EWayWcfServiceItemTypesGeneratedCompanyWithFKs
    {
        public string AccountNumber { get; set; }
        public string Address1POBox { get; set; }
        public string Address1Street { get; set; }
        public string Address1City { get; set; }
        public string Address1State { get; set; }
        public string Address1CountryEn { get; set; }
        public string Address1PostalCode { get; set; }
        public string Address2POBox { get; set; }
        public string Address2Street { get; set; }
        public string Address2City { get; set; }
        public string Address2State { get; set; }
        public string Address2CountryEn { get; set; }
        public string Address2PostalCode { get; set; }
        public string Address3POBox { get; set; }
        public string Address3Street { get; set; }
        public string Address3City { get; set; }
        public string Address3State { get; set; }
        public string Address3CountryEn { get; set; }
        public string Address3PostalCode { get; set; }
        public string CompanyName { get; set; }
        public string Department { get; set; }
        public string Email { get; set; }
        public int EmployeesCount { get; set; }
        public string Fax { get; set; }
        public string FirstContactEn { get; set; }
        public string ICQ { get; set; }
        public string IdentificationNumber { get; set; }
        public string ImportanceEn { get; set; }
        public string LineOfBusiness { get; set; }
        public bool MailingListOther { get; set; }
        public string Mobile { get; set; }
        public string MobileNormalized { get; set; }
        public string MSN { get; set; }
        public string Note { get; set; }
        public string Phone { get; set; }
        public string PhoneNormalized { get; set; }
        public bool Purchaser { get; set; }
        public double Reversal { get; set; }
        public string Skype { get; set; }
        public bool Suppliers { get; set; }
        public string VATNumber { get; set; }
        public string WebPage { get; set; }
        public double AdditionalDiscount { get; set; }

        [JsonProperty("ID")]
        public int Id { get; set; }
        public bool Competitor { get; set; }
        public string SalePriceGuid { get; set; }
        public bool NotificationByEmail { get; set; }
        public string NotificationBy { get; set; }
        public string LastActivity { get; set; }
        public string NextStep { get; set; }
        public bool EmailOptOut { get; set; }
        public string TypeEn { get; set; }
        public string StateEn { get; set; }
        public string PrevStateEn { get; set; }
        public string Picture { get; set; }
        public int PictureWidth { get; set; }
        public int PictureHeight { get; set; }
        public bool IsPrivate { get; set; }

        [JsonProperty("Server_ItemCreated")]
        public string ServerItemCreated { get; set; }

        [JsonProperty("Server_ItemChanged")]
        public string ServerItemChanged { get; set; }
        public string ItemCreated { get; set; }
        public string ItemChanged { get; set; }
        public string FileAs { get; set; }
        public string OwnerGUID { get; set; }
        public string CreatedByGUID { get; set; }
        public string ModifiedByGUID { get; set; }
        public JToken AdditionalFields { get; set; }
        public EWayWcfServiceItemTypesInnerTypesBoundRelation[] Relations { get; set; }
        public string ItemGUID { get; set; }
        public int ItemVersion { get; set; }
    }

    public class EWayWcfServiceItemTypesBoundRelationsFilter
    {
        public string RelationType { get; set; }
        public string ForeignFolderName { get; set; }
    }

    public class EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedContact
    {
        public EWayWcfServiceItemTypesGeneratedContact[] Data { get; set; }
        public string ReturnCode { get; set; }
        public string Description { get; set; }
    }

    public class EWayWcfServiceItemTypesGeneratedContact
    {
        public string BusinessAddressStreet { get; set; }
        public string BusinessAddressCity { get; set; }
        public string BusinessAddressState { get; set; }
        public string BusinessAddressCountryEn { get; set; }
        public string BusinessAddressPOBox { get; set; }
        public string BusinessAddressPostalCode { get; set; }
        public string HomeAddressStreet { get; set; }
        public string HomeAddressCity { get; set; }
        public string HomeAddressState { get; set; }
        public string HomeAddressCountryEn { get; set; }
        public string HomeAddressPOBox { get; set; }
        public string HomeAddressPostalCode { get; set; }
        public string OtherAddressStreet { get; set; }
        public string OtherAddressCity { get; set; }
        public string OtherAddressState { get; set; }
        public string OtherAddressCountryEn { get; set; }
        public string OtherAddressPOBox { get; set; }
        public string OtherAddressPostalCode { get; set; }
        public string Company { get; set; }
        public string Email1Address { get; set; }
        public string Email2Address { get; set; }
        public string Email3Address { get; set; }
        public string FirstName { get; set; }
        public string ICQ { get; set; }
        public string ImportanceEn { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string MSN { get; set; }
        public string Note { get; set; }
        public string PrefixEn { get; set; }
        public string SuffixEn { get; set; }
        public string Skype { get; set; }
        public string TelephoneNumber1 { get; set; }
        public string TelephoneNumber2 { get; set; }
        public string TelephoneNumber3 { get; set; }
        public string TelephoneNumber4 { get; set; }
        public string TelephoneNumber5 { get; set; }
        public string TelephoneNumber6 { get; set; }
        public string TelephoneNumber1Normalized { get; set; }
        public string TelephoneNumber2Normalized { get; set; }
        public string TelephoneNumber3Normalized { get; set; }
        public string TelephoneNumber4Normalized { get; set; }
        public string TelephoneNumber5Normalized { get; set; }
        public string TelephoneNumber6Normalized { get; set; }
        public string Department { get; set; }
        public string Title { get; set; }
        public string WebPage { get; set; }
        public bool DoNotSendNewsletter { get; set; }
        public string ProfilePicture { get; set; }
        public int ProfilePictureWidth { get; set; }
        public int ProfilePictureHeight { get; set; }
        public string LastActivity { get; set; }
        public string NextStep { get; set; }
        public string TypeEn { get; set; }
        public string StateEn { get; set; }
        public string PrevStateEn { get; set; }
        public bool IsPrivate { get; set; }

        [JsonProperty("Server_ItemCreated")]
        public string ServerItemCreated { get; set; }

        [JsonProperty("Server_ItemChanged")]
        public string ServerItemChanged { get; set; }
        public string ItemCreated { get; set; }
        public string ItemChanged { get; set; }
        public string FileAs { get; set; }
        public string OwnerGUID { get; set; }
        public string CreatedByGUID { get; set; }
        public string ModifiedByGUID { get; set; }
        public JToken AdditionalFields { get; set; }
        public EWayWcfServiceItemTypesInnerTypesBoundRelation[] Relations { get; set; }
        public string ItemGUID { get; set; }
        public int ItemVersion { get; set; }
    }

    public class SearchContactsInput
    {
        [JsonProperty("transmitObject")]
        public EWayWcfServiceItemTypesGeneratedContactWithFKs TransmitObject { get; set; }

        [JsonProperty("includeRelations")]
        public bool? IncludeRelations { get; set; }

        [JsonProperty("relationsFilter")]
        public EWayWcfServiceItemTypesBoundRelationsFilter RelationsFilter { get; set; }

        [JsonProperty("includeProfilePictures")]
        public bool? IncludeProfilePictures { get; set; }

        [JsonProperty("binaryLogicalOperator")]
        public string BinaryLogicalOperator { get; set; }
    }

    public class EWayWcfServiceItemTypesGeneratedContactWithFKs
    {
        [JsonProperty("Companies_CompanyGuid")]
        public string CompaniesCompanyGuid { get; set; }
        public string BusinessAddressStreet { get; set; }
        public string BusinessAddressCity { get; set; }
        public string BusinessAddressState { get; set; }
        public string BusinessAddressCountryEn { get; set; }
        public string BusinessAddressPOBox { get; set; }
        public string BusinessAddressPostalCode { get; set; }
        public string HomeAddressStreet { get; set; }
        public string HomeAddressCity { get; set; }
        public string HomeAddressState { get; set; }
        public string HomeAddressCountryEn { get; set; }
        public string HomeAddressPOBox { get; set; }
        public string HomeAddressPostalCode { get; set; }
        public string OtherAddressStreet { get; set; }
        public string OtherAddressCity { get; set; }
        public string OtherAddressState { get; set; }
        public string OtherAddressCountryEn { get; set; }
        public string OtherAddressPOBox { get; set; }
        public string OtherAddressPostalCode { get; set; }
        public string Company { get; set; }
        public string Email1Address { get; set; }
        public string Email2Address { get; set; }
        public string Email3Address { get; set; }
        public string FirstName { get; set; }
        public string ICQ { get; set; }
        public string ImportanceEn { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string MSN { get; set; }
        public string Note { get; set; }
        public string PrefixEn { get; set; }
        public string SuffixEn { get; set; }
        public string Skype { get; set; }
        public string TelephoneNumber1 { get; set; }
        public string TelephoneNumber2 { get; set; }
        public string TelephoneNumber3 { get; set; }
        public string TelephoneNumber4 { get; set; }
        public string TelephoneNumber5 { get; set; }
        public string TelephoneNumber6 { get; set; }
        public string TelephoneNumber1Normalized { get; set; }
        public string TelephoneNumber2Normalized { get; set; }
        public string TelephoneNumber3Normalized { get; set; }
        public string TelephoneNumber4Normalized { get; set; }
        public string TelephoneNumber5Normalized { get; set; }
        public string TelephoneNumber6Normalized { get; set; }
        public string Department { get; set; }
        public string Title { get; set; }
        public string WebPage { get; set; }
        public bool DoNotSendNewsletter { get; set; }
        public string ProfilePicture { get; set; }
        public int ProfilePictureWidth { get; set; }
        public int ProfilePictureHeight { get; set; }
        public string LastActivity { get; set; }
        public string NextStep { get; set; }
        public string TypeEn { get; set; }
        public string StateEn { get; set; }
        public string PrevStateEn { get; set; }
        public bool IsPrivate { get; set; }

        [JsonProperty("Server_ItemCreated")]
        public string ServerItemCreated { get; set; }

        [JsonProperty("Server_ItemChanged")]
        public string ServerItemChanged { get; set; }
        public string ItemCreated { get; set; }
        public string ItemChanged { get; set; }
        public string FileAs { get; set; }
        public string OwnerGUID { get; set; }
        public string CreatedByGUID { get; set; }
        public string ModifiedByGUID { get; set; }
        public JToken AdditionalFields { get; set; }
        public EWayWcfServiceItemTypesInnerTypesBoundRelation[] Relations { get; set; }
        public string ItemGUID { get; set; }
        public int ItemVersion { get; set; }
    }

    public class EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedJournal
    {
        public EWayWcfServiceItemTypesGeneratedJournal[] Data { get; set; }
        public string ReturnCode { get; set; }
        public string Description { get; set; }
    }

    public class EWayWcfServiceItemTypesGeneratedJournal
    {
        [JsonProperty("CalendarEntryID")]
        public string CalendarEntryId { get; set; }

        [JsonProperty("Calendar_ORIGIN")]
        public string CalendarORIGIN { get; set; }
        public string ChangedField { get; set; }
        public string EventEnd { get; set; }
        public string EventStart { get; set; }
        public string FieldValue { get; set; }
        public string ImportanceEn { get; set; }
        public string Note { get; set; }
        public string PrevFieldValue { get; set; }
        public string TypeEn { get; set; }
        public bool IsSystem { get; set; }
        public string Phone { get; set; }
        public string PhoneNormalized { get; set; }
        public bool IsGdprRelevant { get; set; }
        public string Picture { get; set; }
        public int PictureWidth { get; set; }
        public int PictureHeight { get; set; }
        public string StateEn { get; set; }
        public string PrevStateEn { get; set; }
        public bool IsPrivate { get; set; }

        [JsonProperty("Server_ItemCreated")]
        public string ServerItemCreated { get; set; }

        [JsonProperty("Server_ItemChanged")]
        public string ServerItemChanged { get; set; }
        public string ItemCreated { get; set; }
        public string ItemChanged { get; set; }
        public string FileAs { get; set; }
        public string OwnerGUID { get; set; }
        public string CreatedByGUID { get; set; }
        public string ModifiedByGUID { get; set; }
        public JToken AdditionalFields { get; set; }
        public EWayWcfServiceItemTypesInnerTypesBoundRelation[] Relations { get; set; }
        public string ItemGUID { get; set; }
        public int ItemVersion { get; set; }
    }

    public class SearchJournalsInput
    {
        [JsonProperty("transmitObject")]
        public EWayWcfServiceItemTypesGeneratedJournalWithFKs TransmitObject { get; set; }

        [JsonProperty("includeRelations")]
        public bool? IncludeRelations { get; set; }

        [JsonProperty("relationsFilter")]
        public EWayWcfServiceItemTypesBoundRelationsFilter RelationsFilter { get; set; }

        [JsonProperty("binaryLogicalOperator")]
        public string BinaryLogicalOperator { get; set; }
    }

    public class EWayWcfServiceItemTypesGeneratedJournalWithFKs
    {
        [JsonProperty("Marketing_SuperiorItemGuid")]
        public string MarketingSuperiorItemGuid { get; set; }

        [JsonProperty("Companies_CompanyGuid")]
        public string CompaniesCompanyGuid { get; set; }

        [JsonProperty("Contacts_ContactGuid")]
        public string ContactsContactGuid { get; set; }

        [JsonProperty("Leads_SuperiorItemGuid")]
        public string LeadsSuperiorItemGuid { get; set; }

        [JsonProperty("Projects_SuperiorItemGuid")]
        public string ProjectsSuperiorItemGuid { get; set; }

        [JsonProperty("Marketing_MarketingGuid")]
        public string MarketingMarketingGuid { get; set; }

        [JsonProperty("CalendarEntryID")]
        public string CalendarEntryId { get; set; }

        [JsonProperty("Calendar_ORIGIN")]
        public string CalendarORIGIN { get; set; }
        public string ChangedField { get; set; }
        public string EventEnd { get; set; }
        public string EventStart { get; set; }
        public string FieldValue { get; set; }
        public string ImportanceEn { get; set; }
        public string Note { get; set; }
        public string PrevFieldValue { get; set; }
        public string TypeEn { get; set; }
        public bool IsSystem { get; set; }
        public string Phone { get; set; }
        public string PhoneNormalized { get; set; }
        public bool IsGdprRelevant { get; set; }
        public string Picture { get; set; }
        public int PictureWidth { get; set; }
        public int PictureHeight { get; set; }
        public string StateEn { get; set; }
        public string PrevStateEn { get; set; }
        public bool IsPrivate { get; set; }

        [JsonProperty("Server_ItemCreated")]
        public string ServerItemCreated { get; set; }

        [JsonProperty("Server_ItemChanged")]
        public string ServerItemChanged { get; set; }
        public string ItemCreated { get; set; }
        public string ItemChanged { get; set; }
        public string FileAs { get; set; }
        public string OwnerGUID { get; set; }
        public string CreatedByGUID { get; set; }
        public string ModifiedByGUID { get; set; }
        public JToken AdditionalFields { get; set; }
        public EWayWcfServiceItemTypesInnerTypesBoundRelation[] Relations { get; set; }
        public string ItemGUID { get; set; }
        public int ItemVersion { get; set; }
    }

    public class EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedLead
    {
        public EWayWcfServiceItemTypesGeneratedLead[] Data { get; set; }
        public string ReturnCode { get; set; }
        public string Description { get; set; }
    }

    public class EWayWcfServiceItemTypesGeneratedLead
    {
        public string City { get; set; }
        public string ContactPerson { get; set; }
        public string CurrencyEn { get; set; }
        public string Customer { get; set; }
        public string Email { get; set; }
        public string EstimatedEnd { get; set; }

        [JsonProperty("HID")]
        public int HId { get; set; }
        public string LeadOriginEn { get; set; }
        public string Note { get; set; }
        public string Phone { get; set; }
        public string PhoneNormalized { get; set; }
        public string PrevStateEn { get; set; }
        public double Price { get; set; }
        public string PriceChanged { get; set; }
        public double PriceDefaultCurrency { get; set; }
        public double Probability { get; set; }
        public string ReceiveDate { get; set; }
        public string StateEn { get; set; }
        public string Street { get; set; }
        public string TypeEn { get; set; }
        public string Zip { get; set; }
        public string LastActivity { get; set; }
        public string NextStep { get; set; }
        public double EstimatedValue { get; set; }
        public bool IsCompleted { get; set; }
        public bool IsLost { get; set; }
        public string CountryEn { get; set; }
        public string State { get; set; }
        public string POBox { get; set; }
        public bool EmailOptOut { get; set; }
        public string Picture { get; set; }
        public int PictureWidth { get; set; }
        public int PictureHeight { get; set; }
        public string CompletedDate { get; set; }
        public string LostDate { get; set; }
        public bool IsPrivate { get; set; }

        [JsonProperty("Server_ItemCreated")]
        public string ServerItemCreated { get; set; }

        [JsonProperty("Server_ItemChanged")]
        public string ServerItemChanged { get; set; }
        public string ItemCreated { get; set; }
        public string ItemChanged { get; set; }
        public string FileAs { get; set; }
        public string OwnerGUID { get; set; }
        public string CreatedByGUID { get; set; }
        public string ModifiedByGUID { get; set; }
        public JToken AdditionalFields { get; set; }
        public EWayWcfServiceItemTypesInnerTypesBoundRelation[] Relations { get; set; }
        public string ItemGUID { get; set; }
        public int ItemVersion { get; set; }
    }

    public class SearchLeadsInput
    {
        [JsonProperty("transmitObject")]
        public EWayWcfServiceItemTypesGeneratedLeadWithFKs TransmitObject { get; set; }

        [JsonProperty("includeRelations")]
        public bool? IncludeRelations { get; set; }

        [JsonProperty("relationsFilter")]
        public EWayWcfServiceItemTypesBoundRelationsFilter RelationsFilter { get; set; }

        [JsonProperty("binaryLogicalOperator")]
        public string BinaryLogicalOperator { get; set; }
    }

    public class EWayWcfServiceItemTypesGeneratedLeadWithFKs
    {
        [JsonProperty("Companies_CustomerGuid")]
        public string CompaniesCustomerGuid { get; set; }

        [JsonProperty("Contacts_ContactPersonGuid")]
        public string ContactsContactPersonGuid { get; set; }

        [JsonProperty("Marketing_MarketingGuid")]
        public string MarketingMarketingGuid { get; set; }
        public string City { get; set; }
        public string ContactPerson { get; set; }
        public string CurrencyEn { get; set; }
        public string Customer { get; set; }
        public string Email { get; set; }
        public string EstimatedEnd { get; set; }

        [JsonProperty("HID")]
        public int HId { get; set; }
        public string LeadOriginEn { get; set; }
        public string Note { get; set; }
        public string Phone { get; set; }
        public string PhoneNormalized { get; set; }
        public string PrevStateEn { get; set; }
        public double Price { get; set; }
        public string PriceChanged { get; set; }
        public double PriceDefaultCurrency { get; set; }
        public double Probability { get; set; }
        public string ReceiveDate { get; set; }
        public string StateEn { get; set; }
        public string Street { get; set; }
        public string TypeEn { get; set; }
        public string Zip { get; set; }
        public string LastActivity { get; set; }
        public string NextStep { get; set; }
        public double EstimatedValue { get; set; }
        public bool IsCompleted { get; set; }
        public bool IsLost { get; set; }
        public string CountryEn { get; set; }
        public string State { get; set; }
        public string POBox { get; set; }
        public bool EmailOptOut { get; set; }
        public string Picture { get; set; }
        public int PictureWidth { get; set; }
        public int PictureHeight { get; set; }
        public string CompletedDate { get; set; }
        public string LostDate { get; set; }
        public bool IsPrivate { get; set; }

        [JsonProperty("Server_ItemCreated")]
        public string ServerItemCreated { get; set; }

        [JsonProperty("Server_ItemChanged")]
        public string ServerItemChanged { get; set; }
        public string ItemCreated { get; set; }
        public string ItemChanged { get; set; }
        public string FileAs { get; set; }
        public string OwnerGUID { get; set; }
        public string CreatedByGUID { get; set; }
        public string ModifiedByGUID { get; set; }
        public JToken AdditionalFields { get; set; }
        public EWayWcfServiceItemTypesInnerTypesBoundRelation[] Relations { get; set; }
        public string ItemGUID { get; set; }
        public int ItemVersion { get; set; }
    }

    public class EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedProject
    {
        public EWayWcfServiceItemTypesGeneratedProject[] Data { get; set; }
        public string ReturnCode { get; set; }
        public string Description { get; set; }
    }

    public class EWayWcfServiceItemTypesGeneratedProject
    {
        public string Note { get; set; }
        public double Price { get; set; }
        public string ProjectEnd { get; set; }
        public string ProjectName { get; set; }
        public string TypeEn { get; set; }
        public string StateEn { get; set; }
        public double PeopleExpenses { get; set; }
        public string ProjectRealEnd { get; set; }
        public double EstimatedPrice { get; set; }

        [JsonProperty("HID")]
        public int HId { get; set; }
        public string ProjectOriginEn { get; set; }
        public string PaymentTypeEn { get; set; }
        public double OtherExpenses { get; set; }
        public double Margin { get; set; }
        public double Profit { get; set; }
        public int PaymentMaturity { get; set; }
        public string InvoicePaymentDate { get; set; }
        public string InvoiceIssueDate { get; set; }
        public double EstimatedMargin { get; set; }
        public double EstimatedProfit { get; set; }
        public double EstimatedPeopleExpenses { get; set; }
        public double EstimatedOtherExpenses { get; set; }
        public int LicensesCount { get; set; }
        public double LicensePrice { get; set; }
        public string PrevStateEn { get; set; }
        public bool ShowInCaplan { get; set; }
        public string ProjectStart { get; set; }
        public int EstimatedWorkHours { get; set; }
        public double TotalWorkHours { get; set; }
        public double EstimatedPeopleExpensesDefaultCurrency { get; set; }
        public double EstimatedOtherExpensesDefaultCurrency { get; set; }
        public double EstimatedPriceDefaultCurrency { get; set; }
        public double PeopleExpensesDefaultCurrency { get; set; }
        public double OtherExpensesDefaultCurrency { get; set; }
        public double PriceDefaultCurrency { get; set; }
        public double ProfitDefaultCurrency { get; set; }
        public double EstimatedProfitDefaultCurrency { get; set; }
        public string CurrencyEn { get; set; }
        public string EstimatedPeopleExpensesChanged { get; set; }
        public string EstimatedOtherExpensesChanged { get; set; }
        public string OtherExpensesChanged { get; set; }
        public string EstimatedPriceChanged { get; set; }
        public string PriceChanged { get; set; }
        public string LicensePriceChanged { get; set; }
        public double LicensePriceDefaultCurrency { get; set; }
        public string LastActivity { get; set; }
        public string NextStep { get; set; }
        public string CompletedDate { get; set; }
        public bool IsCompleted { get; set; }
        public string LostDate { get; set; }
        public bool IsLost { get; set; }
        public string PeopleExpensesChanged { get; set; }
        public string Picture { get; set; }
        public int PictureWidth { get; set; }
        public int PictureHeight { get; set; }
        public bool IsPrivate { get; set; }

        [JsonProperty("Server_ItemCreated")]
        public string ServerItemCreated { get; set; }

        [JsonProperty("Server_ItemChanged")]
        public string ServerItemChanged { get; set; }
        public string ItemCreated { get; set; }
        public string ItemChanged { get; set; }
        public string FileAs { get; set; }
        public string OwnerGUID { get; set; }
        public string CreatedByGUID { get; set; }
        public string ModifiedByGUID { get; set; }
        public JToken AdditionalFields { get; set; }
        public EWayWcfServiceItemTypesInnerTypesBoundRelation[] Relations { get; set; }
        public string ItemGUID { get; set; }
        public int ItemVersion { get; set; }
    }

    public class SearchProjectsInput
    {
        [JsonProperty("transmitObject")]
        public EWayWcfServiceItemTypesGeneratedProjectWithFKs TransmitObject { get; set; }

        [JsonProperty("includeRelations")]
        public bool? IncludeRelations { get; set; }

        [JsonProperty("relationsFilter")]
        public EWayWcfServiceItemTypesBoundRelationsFilter RelationsFilter { get; set; }

        [JsonProperty("binaryLogicalOperator")]
        public string BinaryLogicalOperator { get; set; }
    }

    public class EWayWcfServiceItemTypesGeneratedProjectWithFKs
    {
        [JsonProperty("Companies_CustomerGuid")]
        public string CompaniesCustomerGuid { get; set; }

        [JsonProperty("Contacts_ContactPersonGuid")]
        public string ContactsContactPersonGuid { get; set; }

        [JsonProperty("Leads_Project_OriginGuid")]
        public string LeadsProjectOriginGuid { get; set; }

        [JsonProperty("Projects_SuperiorProjectGuid")]
        public string ProjectsSuperiorProjectGuid { get; set; }

        [JsonProperty("Users_SupervisorGuid")]
        public string UsersSupervisorGuid { get; set; }
        public string Note { get; set; }
        public double Price { get; set; }
        public string ProjectEnd { get; set; }
        public string ProjectName { get; set; }
        public string TypeEn { get; set; }
        public string StateEn { get; set; }
        public double PeopleExpenses { get; set; }
        public string ProjectRealEnd { get; set; }
        public double EstimatedPrice { get; set; }

        [JsonProperty("HID")]
        public int HId { get; set; }
        public string ProjectOriginEn { get; set; }
        public string PaymentTypeEn { get; set; }
        public double OtherExpenses { get; set; }
        public double Margin { get; set; }
        public double Profit { get; set; }
        public int PaymentMaturity { get; set; }
        public string InvoicePaymentDate { get; set; }
        public string InvoiceIssueDate { get; set; }
        public double EstimatedMargin { get; set; }
        public double EstimatedProfit { get; set; }
        public double EstimatedPeopleExpenses { get; set; }
        public double EstimatedOtherExpenses { get; set; }
        public int LicensesCount { get; set; }
        public double LicensePrice { get; set; }
        public string PrevStateEn { get; set; }
        public bool ShowInCaplan { get; set; }
        public string ProjectStart { get; set; }
        public int EstimatedWorkHours { get; set; }
        public double TotalWorkHours { get; set; }
        public double EstimatedPeopleExpensesDefaultCurrency { get; set; }
        public double EstimatedOtherExpensesDefaultCurrency { get; set; }
        public double EstimatedPriceDefaultCurrency { get; set; }
        public double PeopleExpensesDefaultCurrency { get; set; }
        public double OtherExpensesDefaultCurrency { get; set; }
        public double PriceDefaultCurrency { get; set; }
        public double ProfitDefaultCurrency { get; set; }
        public double EstimatedProfitDefaultCurrency { get; set; }
        public string CurrencyEn { get; set; }
        public string EstimatedPeopleExpensesChanged { get; set; }
        public string EstimatedOtherExpensesChanged { get; set; }
        public string OtherExpensesChanged { get; set; }
        public string EstimatedPriceChanged { get; set; }
        public string PriceChanged { get; set; }
        public string LicensePriceChanged { get; set; }
        public double LicensePriceDefaultCurrency { get; set; }
        public string LastActivity { get; set; }
        public string NextStep { get; set; }
        public string CompletedDate { get; set; }
        public bool IsCompleted { get; set; }
        public string LostDate { get; set; }
        public bool IsLost { get; set; }
        public string PeopleExpensesChanged { get; set; }
        public string Picture { get; set; }
        public int PictureWidth { get; set; }
        public int PictureHeight { get; set; }
        public bool IsPrivate { get; set; }

        [JsonProperty("Server_ItemCreated")]
        public string ServerItemCreated { get; set; }

        [JsonProperty("Server_ItemChanged")]
        public string ServerItemChanged { get; set; }
        public string ItemCreated { get; set; }
        public string ItemChanged { get; set; }
        public string FileAs { get; set; }
        public string OwnerGUID { get; set; }
        public string CreatedByGUID { get; set; }
        public string ModifiedByGUID { get; set; }
        public JToken AdditionalFields { get; set; }
        public EWayWcfServiceItemTypesInnerTypesBoundRelation[] Relations { get; set; }
        public string ItemGUID { get; set; }
        public int ItemVersion { get; set; }
    }

    public class EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedTask
    {
        public EWayWcfServiceItemTypesGeneratedTask[] Data { get; set; }
        public string ReturnCode { get; set; }
        public string Description { get; set; }
    }

    public class EWayWcfServiceItemTypesGeneratedTask
    {
        public string Body { get; set; }
        public bool IsCompleted { get; set; }
        public string DueDate { get; set; }
        public double PercentCompleteDecimal { get; set; }
        public string PrevStateEn { get; set; }
        public string StartDate { get; set; }
        public string StateEn { get; set; }
        public string Subject { get; set; }
        public string TypeEn { get; set; }
        public int Level { get; set; }
        public string ImportanceEn { get; set; }
        public double ActualWorkHours { get; set; }
        public double EstimatedWorkHours { get; set; }
        public bool IsReminderSet { get; set; }
        public string ReminderDate { get; set; }
        public string CompletedDate { get; set; }
        public string Picture { get; set; }
        public int PictureWidth { get; set; }
        public int PictureHeight { get; set; }
        public bool IsPrivate { get; set; }

        [JsonProperty("Server_ItemCreated")]
        public string ServerItemCreated { get; set; }

        [JsonProperty("Server_ItemChanged")]
        public string ServerItemChanged { get; set; }
        public string ItemCreated { get; set; }
        public string ItemChanged { get; set; }
        public string FileAs { get; set; }
        public string OwnerGUID { get; set; }
        public string CreatedByGUID { get; set; }
        public string ModifiedByGUID { get; set; }
        public JToken AdditionalFields { get; set; }
        public EWayWcfServiceItemTypesInnerTypesBoundRelation[] Relations { get; set; }
        public string ItemGUID { get; set; }
        public int ItemVersion { get; set; }
    }

    public class SearchTasksInput
    {
        [JsonProperty("transmitObject")]
        public EWayWcfServiceItemTypesGeneratedTaskWithFKs TransmitObject { get; set; }

        [JsonProperty("includeRelations")]
        public bool? IncludeRelations { get; set; }

        [JsonProperty("relationsFilter")]
        public EWayWcfServiceItemTypesBoundRelationsFilter RelationsFilter { get; set; }

        [JsonProperty("binaryLogicalOperator")]
        public string BinaryLogicalOperator { get; set; }
    }

    public class EWayWcfServiceItemTypesGeneratedTaskWithFKs
    {
        [JsonProperty("Leads_TopLevelProjectGuid")]
        public string LeadsTopLevelProjectGuid { get; set; }

        [JsonProperty("Leads_TaskParentGuid")]
        public string LeadsTaskParentGuid { get; set; }

        [JsonProperty("Projects_TopLevelProjectGuid")]
        public string ProjectsTopLevelProjectGuid { get; set; }

        [JsonProperty("Projects_TaskParentGuid")]
        public string ProjectsTaskParentGuid { get; set; }

        [JsonProperty("Tasks_TaskParentGuid")]
        public string TasksTaskParentGuid { get; set; }

        [JsonProperty("Marketing_TopLevelProjectGuid")]
        public string MarketingTopLevelProjectGuid { get; set; }

        [JsonProperty("Marketing_TaskParentGuid")]
        public string MarketingTaskParentGuid { get; set; }

        [JsonProperty("Companies_CompanyGuid")]
        public string CompaniesCompanyGuid { get; set; }

        [JsonProperty("Contacts_ContactGuid")]
        public string ContactsContactGuid { get; set; }

        [JsonProperty("Users_TaskDelegatorGuid")]
        public string UsersTaskDelegatorGuid { get; set; }

        [JsonProperty("Users_TaskSolverGuid")]
        public string UsersTaskSolverGuid { get; set; }

        [JsonProperty("Tasks_TaskOriginGuid")]
        public string TasksTaskOriginGuid { get; set; }
        public string Body { get; set; }
        public bool IsCompleted { get; set; }
        public string DueDate { get; set; }
        public double PercentCompleteDecimal { get; set; }
        public string PrevStateEn { get; set; }
        public string StartDate { get; set; }
        public string StateEn { get; set; }
        public string Subject { get; set; }
        public string TypeEn { get; set; }
        public int Level { get; set; }
        public string ImportanceEn { get; set; }
        public double ActualWorkHours { get; set; }
        public double EstimatedWorkHours { get; set; }
        public bool IsReminderSet { get; set; }
        public string ReminderDate { get; set; }
        public string CompletedDate { get; set; }
        public string Picture { get; set; }
        public int PictureWidth { get; set; }
        public int PictureHeight { get; set; }
        public bool IsPrivate { get; set; }

        [JsonProperty("Server_ItemCreated")]
        public string ServerItemCreated { get; set; }

        [JsonProperty("Server_ItemChanged")]
        public string ServerItemChanged { get; set; }
        public string ItemCreated { get; set; }
        public string ItemChanged { get; set; }
        public string FileAs { get; set; }
        public string OwnerGUID { get; set; }
        public string CreatedByGUID { get; set; }
        public string ModifiedByGUID { get; set; }
        public JToken AdditionalFields { get; set; }
        public EWayWcfServiceItemTypesInnerTypesBoundRelation[] Relations { get; set; }
        public string ItemGUID { get; set; }
        public int ItemVersion { get; set; }
    }

    public class EWayWcfServiceResponsesDataResponse1SystemGuid
    {
        public string[] Data { get; set; }
        public string ReturnCode { get; set; }
        public string Description { get; set; }
    }

    public class UnlinkItemsInput
    {
        [JsonProperty("itemGuid")]
        public string ItemGuid { get; set; }

        [JsonProperty("folderName")]
        public UnlinkItemsInputFolderNameType? FolderName { get; set; }

        [JsonProperty("relatedItemGuids")]
        public string[] RelatedItemGuids { get; set; }

        [JsonProperty("relatedFolderName")]
        public UnlinkItemsInputRelatedFolderNameType? RelatedFolderName { get; set; }

        [JsonProperty("skipUnlinkAvailabilityCheck")]
        public bool? SkipUnlinkAvailabilityCheck { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UnlinkItemsInputFolderNameType
    {
        Actions,
        AdditionalFields,
        Bonuses,
        Calendar,
        CapacityNotes,
        CapacityNoteTypes,
        Carts,
        ColumnPermissions,
        Companies,
        Contacts,
        CurrencyExchangeRates,
        Documents,
        Emails,
        EnumTypes,
        EnumValues,
        EnumValuesRelations,
        Features,
        Flows,
        GlobalSettings,
        Goals,
        Goods,
        GoodsInCart,
        GoodsInSet,
        Groups,
        History,
        Holidays,
        Children,
        IndividualDiscounts,
        InvoiceItems,
        Invoices,
        ItemCopyRelations,
        Journal,
        Knowledge,
        Layouts,
        LayoutsModels,
        Leads,
        Ledger,
        Mappings,
        Marketing,
        MarketingList,
        MarketingListSources,
        Models,
        ModulePermissions,
        ObjectTypesOptions,
        Payments,
        PriceListGroups,
        ProjectAssignments,
        ProjectAssignmentsPerUserProject,
        ProjectAssignmentsTotal,
        ProjectAssignmentsTotalUserProject,
        ProjectList,
        Projects,
        ProjectUsersInCaPlan,
        RelationData,
        Relations,
        Reports,
        RevisionsHistory,
        Salaries,
        SalePrices,
        Prices,
        SqlObjects,
        Tasks,
        RecurrencePatterns,
        TeamRoles,
        Templates,
        Training,
        UnifiedRelations,
        Users,
        UserSettings,
        Vacation,
        WebAccess2Options,
        WebAccessOptions,
        WorkCommitments,
        WorkflowHistory,
        WorkReports,
        WrongClientVersions,
        XsltTransformations
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UnlinkItemsInputRelatedFolderNameType
    {
        Actions,
        AdditionalFields,
        Bonuses,
        Calendar,
        CapacityNotes,
        CapacityNoteTypes,
        Carts,
        ColumnPermissions,
        Companies,
        Contacts,
        CurrencyExchangeRates,
        Documents,
        Emails,
        EnumTypes,
        EnumValues,
        EnumValuesRelations,
        Features,
        Flows,
        GlobalSettings,
        Goals,
        Goods,
        GoodsInCart,
        GoodsInSet,
        Groups,
        History,
        Holidays,
        Children,
        IndividualDiscounts,
        InvoiceItems,
        Invoices,
        ItemCopyRelations,
        Journal,
        Knowledge,
        Layouts,
        LayoutsModels,
        Leads,
        Ledger,
        Mappings,
        Marketing,
        MarketingList,
        MarketingListSources,
        Models,
        ModulePermissions,
        ObjectTypesOptions,
        Payments,
        PriceListGroups,
        ProjectAssignments,
        ProjectAssignmentsPerUserProject,
        ProjectAssignmentsTotal,
        ProjectAssignmentsTotalUserProject,
        ProjectList,
        Projects,
        ProjectUsersInCaPlan,
        RelationData,
        Relations,
        Reports,
        RevisionsHistory,
        Salaries,
        SalePrices,
        Prices,
        SqlObjects,
        Tasks,
        RecurrencePatterns,
        TeamRoles,
        Templates,
        Training,
        UnifiedRelations,
        Users,
        UserSettings,
        Vacation,
        WebAccess2Options,
        WebAccessOptions,
        WorkCommitments,
        WorkflowHistory,
        WorkReports,
        WrongClientVersions,
        XsltTransformations
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Ewaycrm;

    public partial class WorkflowManagedActions
    {
        public EwaycrmActions Ewaycrm(string connectionId) => new EwaycrmActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public EwaycrmTriggers Ewaycrm(string connectionId) => new EwaycrmTriggers(connectionId);
    }
}