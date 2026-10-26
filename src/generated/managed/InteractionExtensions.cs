//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Interaction
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class InteractionActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "interaction")]
        public IBodyWorkflowAction<ReadListByIdResponse, ApiConnectionActionConfiguration> ReadListById(Expression<Func<ReadListByIdInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ReadListByIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/graphql/ReadListByID";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ReadListByIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "interaction")]
        public IBodyWorkflowAction<ReadListByNameResponse, ApiConnectionActionConfiguration> ReadListByName(Expression<Func<ReadListByNameInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ReadListByNameResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/graphql/ReadListByName";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ReadListByNameResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "interaction")]
        public IBodyWorkflowAction<ReadAdditionalFieldDefinitionsAndValuesResponse, ApiConnectionActionConfiguration> ReadAdditionalFieldDefinitionsAndValues(Expression<Func<ReadAdditionalFieldDefinitionsAndValuesInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ReadAdditionalFieldDefinitionsAndValuesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/graphql/ReadAdditionalFieldDefinitionsAndValues";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ReadAdditionalFieldDefinitionsAndValuesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "interaction")]
        public IBodyWorkflowAction<AddOrUpdateAdditionalFieldValuesResponse, ApiConnectionActionConfiguration> AddOrUpdateAdditionalFieldValues(Expression<Func<AddOrUpdateAdditionalFieldValuesInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<AddOrUpdateAdditionalFieldValuesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/graphql/UpdateAdditionalFieldValues";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<AddOrUpdateAdditionalFieldValuesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "interaction")]
        public IBodyWorkflowAction<ReadContactByIdResponse, ApiConnectionActionConfiguration> ReadContactById(Expression<Func<ReadContactByIdInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ReadContactByIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/graphql/ReadContactByID";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ReadContactByIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "interaction")]
        public IBodyWorkflowAction<CreateContactResponse, ApiConnectionActionConfiguration> CreateContact(Expression<Func<CreateContactInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateContactResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/graphql/CreateContact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateContactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "interaction")]
        public IBodyWorkflowAction<ListResponse, ApiConnectionActionConfiguration> ReadLists(Expression<Func<ReadListsInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/graphql/ReadLists";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "interaction")]
        public IBodyWorkflowAction<AddContactsToListsResponse, ApiConnectionActionConfiguration> AddContactsToLists(Expression<Func<AddContactsToListsInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<AddContactsToListsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/graphql/AddContactsToLists";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<AddContactsToListsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "interaction")]
        public IBodyWorkflowAction<RemoveContactsfromListResponse, ApiConnectionActionConfiguration> RemoveContactsfromList(Expression<Func<RemoveContactsfromListInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<RemoveContactsfromListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/graphql/RemoveContactsFromList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<RemoveContactsfromListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "interaction")]
        public IBodyWorkflowAction<UpdatePersonContactResponse, ApiConnectionActionConfiguration> UpdatePersonContact(Expression<Func<UpdatePersonContactInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UpdatePersonContactResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/graphql/UpdatePersonContact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdatePersonContactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "interaction")]
        public IBodyWorkflowAction<CreateActivityResponse, ApiConnectionActionConfiguration> CreateActivity(Expression<Func<CreateActivityInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateActivityResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/graphql/CreateActivity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateActivityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "interaction")]
        public IBodyWorkflowAction<SearchContactsResponse, ApiConnectionActionConfiguration> SearchContacts(Expression<Func<SearchContactsInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SearchContactsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/graphql/SearchContacts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SearchContactsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "interaction")]
        public IBodyWorkflowAction<UpdateActivityResponse, ApiConnectionActionConfiguration> UpdateActivity(Expression<Func<UpdateActivityInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UpdateActivityResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/graphql/UpdateActivity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateActivityResponse>(callPayload);
            });
        }
    }

    public class InteractionTriggers([ConnectionName] string connectionId)
    {
    }

    public class ReadListByIdResponse
    {
        [JsonProperty("data")]
        public ReadListByIdResponseDataType Data { get; set; }
    }

    public class ReadListByIdResponseDataType
    {
        [JsonProperty("list")]
        public ReadListByIdResponseDataTypeListType List { get; set; }
    }

    public class ReadListByIdResponseDataTypeListType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("listType")]
        public ReadListByIdResponseDataTypeListTypeListTypeType ListType { get; set; }

        [JsonProperty("allowedLinkInto")]
        public bool AllowedLinkInto { get; set; }

        [JsonProperty("allowedRemoveFrom")]
        public bool AllowedRemoveFrom { get; set; }

        [JsonProperty("addAllowed")]
        public bool AddAllowed { get; set; }

        [JsonProperty("deleteAllowed")]
        public bool DeleteAllowed { get; set; }

        [JsonProperty("addActivityAllowed")]
        public bool AddActivityAllowed { get; set; }

        [JsonProperty("addNoteAllowed")]
        public bool AddNoteAllowed { get; set; }

        [JsonProperty("ownerName")]
        public string OwnerName { get; set; }

        [JsonProperty("creatorName")]
        public string CreatorName { get; set; }

        [JsonProperty("allowedContactEntity")]
        public string AllowedContactEntity { get; set; }

        [JsonProperty("isAdministrator")]
        public bool IsAdministrator { get; set; }

        [JsonProperty("contacts")]
        public ReadListByIdResponseDataTypeListTypeContactsType Contacts { get; set; }
    }

    public class ReadListByIdResponseDataTypeListTypeListTypeType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("isActive")]
        public bool IsActive { get; set; }

        [JsonProperty("listClass")]
        public string ListClass { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ReadListByIdResponseDataTypeListTypeContactsType
    {
        [JsonProperty("totalModels")]
        public int TotalModels { get; set; }

        [JsonProperty("models")]
        public ReadListByIdResponseDataTypeListTypeContactsTypeModelsTypeItem[] Models { get; set; }
    }

    public class ReadListByIdResponseDataTypeListTypeContactsTypeModelsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }

        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("companyName")]
        public string CompanyName { get; set; }

        [JsonProperty("companyId")]
        public string CompanyId { get; set; }

        [JsonProperty("contactEntity")]
        public string ContactEntity { get; set; }

        [JsonProperty("sponsors")]
        public ReadListByIdResponseDataTypeListTypeContactsTypeModelsTypeItemSponsorsType Sponsors { get; set; }
    }

    public class ReadListByIdResponseDataTypeListTypeContactsTypeModelsTypeItemSponsorsType
    {
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("isPrimary")]
        public bool IsPrimary { get; set; }
    }

    public class ReadListByIdInput
    {
        [JsonProperty("query", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Query { get; set; } = "query list($id: ID!, $skip: Int, $limit: Int, $primarySponsorName: String) {     list(id: $id) {         id         name         description         listType {             id             isActive             listClass             name         }         allowedLinkInto         allowedRemoveFrom         addAllowed         deleteAllowed         addActivityAllowed         addNoteAllowed         ownerName         creatorName         allowedContactEntity         isAdministrator         contacts(             skip: $skip             limit: $limit,             filter: { primarySponsorUserName: $primarySponsorName, checkForStrictPrimarySponsor: true },             sort: { direction: \"Ascending\", field: \"displayName\" }         ) {             totalModels             models {                 id                 title                 phoneNumber                 emailAddress                 displayName                 companyName                 companyId                 contactEntity                 sponsors {                     displayName                     fullName                     id                     isPrimary                 }                 additionalFieldValues {                     totalModels                     models {                         contactId                         dataType                         fieldDisplayName                         fieldId                         format                         id                         listId                         valueItems {                             lastEditDate                             value                             valueId                         }                     }                 }             }         }     } }";

        [JsonProperty("variables", DefaultValueHandling = DefaultValueHandling.Include)]
        public ReadListByIdInputVariablesType Variables { get; set; }
    }

    public class ReadListByIdInputVariablesType
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("skip", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Skip { get; set; } = 0;

        [JsonProperty("limit", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Limit { get; set; } = 100;

        [JsonProperty("primarySponsorName")]
        public string PrimarySponsorName { get; set; }
    }

    public class ReadListByNameResponse
    {
        [JsonProperty("data")]
        public ReadListByNameResponseDataType Data { get; set; }
    }

    public class ReadListByNameResponseDataType
    {
        [JsonProperty("lists")]
        public ReadListByNameResponseDataTypeListsType Lists { get; set; }
    }

    public class ReadListByNameResponseDataTypeListsType
    {
        [JsonProperty("totalModels")]
        public int TotalModels { get; set; }

        [JsonProperty("models")]
        public ReadListByNameResponseDataTypeListsTypeModelsTypeItem[] Models { get; set; }
    }

    public class ReadListByNameResponseDataTypeListsTypeModelsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("listType")]
        public ReadListByNameResponseDataTypeListsTypeModelsTypeItemListTypeType ListType { get; set; }

        [JsonProperty("allowedLinkInto")]
        public bool AllowedLinkInto { get; set; }

        [JsonProperty("allowedRemoveFrom")]
        public bool AllowedRemoveFrom { get; set; }

        [JsonProperty("addAllowed")]
        public bool AddAllowed { get; set; }

        [JsonProperty("deleteAllowed")]
        public bool DeleteAllowed { get; set; }

        [JsonProperty("addActivityAllowed")]
        public bool AddActivityAllowed { get; set; }

        [JsonProperty("addNoteAllowed")]
        public bool AddNoteAllowed { get; set; }

        [JsonProperty("ownerName")]
        public string OwnerName { get; set; }

        [JsonProperty("creatorName")]
        public string CreatorName { get; set; }

        [JsonProperty("allowedContactEntity")]
        public string AllowedContactEntity { get; set; }

        [JsonProperty("isAdministrator")]
        public bool IsAdministrator { get; set; }

        [JsonProperty("contacts")]
        public ReadListByNameResponseDataTypeListsTypeModelsTypeItemContactsType Contacts { get; set; }
    }

    public class ReadListByNameResponseDataTypeListsTypeModelsTypeItemListTypeType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("isActive")]
        public bool IsActive { get; set; }

        [JsonProperty("listClass")]
        public string ListClass { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ReadListByNameResponseDataTypeListsTypeModelsTypeItemContactsType
    {
        [JsonProperty("totalModels")]
        public int TotalModels { get; set; }

        [JsonProperty("models")]
        public ReadListByNameResponseDataTypeListsTypeModelsTypeItemContactsTypeModelsTypeItem[] Models { get; set; }
    }

    public class ReadListByNameResponseDataTypeListsTypeModelsTypeItemContactsTypeModelsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }

        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("companyName")]
        public string CompanyName { get; set; }

        [JsonProperty("companyId")]
        public string CompanyId { get; set; }

        [JsonProperty("contactEntity")]
        public string ContactEntity { get; set; }

        [JsonProperty("sponsors")]
        public ReadListByNameResponseDataTypeListsTypeModelsTypeItemContactsTypeModelsTypeItemSponsorsType Sponsors { get; set; }
    }

    public class ReadListByNameResponseDataTypeListsTypeModelsTypeItemContactsTypeModelsTypeItemSponsorsType
    {
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("isPrimary")]
        public bool IsPrimary { get; set; }
    }

    public class ReadListByNameInput
    {
        [JsonProperty("query", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Query { get; set; } = "query MyQuery($filterByName: String, $skip: Int, $limit: Int) {       lists(filter: { field: name, value: $filterByName }) {           totalModels           models {               id               name               description               listType {                   id                   isActive                   listClass                   name               }               allowedLinkInto               allowedRemoveFrom               addAllowed               deleteAllowed               addActivityAllowed               addNoteAllowed               ownerName               creatorName               allowedContactEntity               isAdministrator               contacts(skip: $skip, limit: $limit,sort: {direction: \"Ascending\", field: \"displayName\"}) {                   totalModels                   models {                       id                       title                       phoneNumber                       emailAddress                       displayName                       companyName                       companyId                       contactEntity                       sponsors {                           displayName                           fullName                           id                           isPrimary                       }                   }               }           }       }   }";

        [JsonProperty("variables", DefaultValueHandling = DefaultValueHandling.Include)]
        public ReadListByNameInputVariablesType Variables { get; set; }
    }

    public class ReadListByNameInputVariablesType
    {
        [JsonProperty("filterByName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FilterByName { get; set; }

        [JsonProperty("skip", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Skip { get; set; } = 0;

        [JsonProperty("limit", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Limit { get; set; } = 100;
    }

    public class ReadAdditionalFieldDefinitionsAndValuesResponse
    {
        [JsonProperty("data")]
        public ReadAdditionalFieldDefinitionsAndValuesResponseDataType Data { get; set; }
    }

    public class ReadAdditionalFieldDefinitionsAndValuesResponseDataType
    {
        [JsonProperty("list")]
        public ReadAdditionalFieldDefinitionsAndValuesResponseDataTypeListType List { get; set; }
    }

    public class ReadAdditionalFieldDefinitionsAndValuesResponseDataTypeListType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("listType")]
        public ReadAdditionalFieldDefinitionsAndValuesResponseDataTypeListTypeListTypeType ListType { get; set; }

        [JsonProperty("additionalFieldDefinitions")]
        public ReadAdditionalFieldDefinitionsAndValuesResponseDataTypeListTypeAdditionalFieldDefinitionsType AdditionalFieldDefinitions { get; set; }

        [JsonProperty("contacts")]
        public ReadAdditionalFieldDefinitionsAndValuesResponseDataTypeListTypeContactsType Contacts { get; set; }
    }

    public class ReadAdditionalFieldDefinitionsAndValuesResponseDataTypeListTypeListTypeType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("isActive")]
        public bool IsActive { get; set; }

        [JsonProperty("listClass")]
        public string ListClass { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ReadAdditionalFieldDefinitionsAndValuesResponseDataTypeListTypeAdditionalFieldDefinitionsType
    {
        [JsonProperty("totalModels")]
        public int TotalModels { get; set; }

        [JsonProperty("models")]
        public ReadAdditionalFieldDefinitionsAndValuesResponseDataTypeListTypeAdditionalFieldDefinitionsTypeModelsTypeItem[] Models { get; set; }
    }

    public class ReadAdditionalFieldDefinitionsAndValuesResponseDataTypeListTypeAdditionalFieldDefinitionsTypeModelsTypeItem
    {
        [JsonProperty("userDataTypeUserProfessional")]
        public string UserDataTypeUserProfessional { get; set; }

        [JsonProperty("userDataTypeUserActive")]
        public string UserDataTypeUserActive { get; set; }

        [JsonProperty("stringDataTypeMultiLine")]
        public bool StringDataTypeMultiLine { get; set; }

        [JsonProperty("stringDataTypeMaxLength")]
        public int StringDataTypeMaxLength { get; set; }

        [JsonProperty("secondaryFieldName")]
        public string SecondaryFieldName { get; set; }

        [JsonProperty("numericDataTypeMinValue")]
        public string NumericDataTypeMinValue { get; set; }

        [JsonProperty("numericDataTypeMaxValue")]
        public string NumericDataTypeMaxValue { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("listDataType")]
        public ReadAdditionalFieldDefinitionsAndValuesResponseDataTypeListTypeAdditionalFieldDefinitionsTypeModelsTypeItemListDataTypeType ListDataType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("fieldDataType")]
        public string FieldDataType { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("decimalDataTypePrecision")]
        public int DecimalDataTypePrecision { get; set; }

        [JsonProperty("dataTypeDisplayName")]
        public string DataTypeDisplayName { get; set; }

        [JsonProperty("booleanDataTypeFalseValue")]
        public string BooleanDataTypeFalseValue { get; set; }

        [JsonProperty("booleanDataTypeTrueValue")]
        public string BooleanDataTypeTrueValue { get; set; }

        [JsonProperty("allowsSecondaryField")]
        public bool AllowsSecondaryField { get; set; }

        [JsonProperty("allowsMultipleValues")]
        public bool AllowsMultipleValues { get; set; }
    }

    public class ReadAdditionalFieldDefinitionsAndValuesResponseDataTypeListTypeAdditionalFieldDefinitionsTypeModelsTypeItemListDataTypeType
    {
        [JsonProperty("options")]
        public JToken[] Options { get; set; }
    }

    public class ReadAdditionalFieldDefinitionsAndValuesResponseDataTypeListTypeContactsType
    {
        [JsonProperty("totalModels")]
        public int TotalModels { get; set; }

        [JsonProperty("models")]
        public ReadAdditionalFieldDefinitionsAndValuesResponseDataTypeListTypeContactsTypeModelsTypeItem[] Models { get; set; }
    }

    public class ReadAdditionalFieldDefinitionsAndValuesResponseDataTypeListTypeContactsTypeModelsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }

        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("companyName")]
        public string CompanyName { get; set; }

        [JsonProperty("companyId")]
        public string CompanyId { get; set; }

        [JsonProperty("contactEntity")]
        public string ContactEntity { get; set; }

        [JsonProperty("sponsors")]
        public ReadAdditionalFieldDefinitionsAndValuesResponseDataTypeListTypeContactsTypeModelsTypeItemSponsorsType Sponsors { get; set; }

        [JsonProperty("additionalFieldValues")]
        public ReadAdditionalFieldDefinitionsAndValuesResponseDataTypeListTypeContactsTypeModelsTypeItemAdditionalFieldValuesType AdditionalFieldValues { get; set; }
    }

    public class ReadAdditionalFieldDefinitionsAndValuesResponseDataTypeListTypeContactsTypeModelsTypeItemSponsorsType
    {
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("isPrimary")]
        public bool IsPrimary { get; set; }
    }

    public class ReadAdditionalFieldDefinitionsAndValuesResponseDataTypeListTypeContactsTypeModelsTypeItemAdditionalFieldValuesType
    {
        [JsonProperty("totalModels")]
        public int TotalModels { get; set; }

        [JsonProperty("models")]
        public ReadAdditionalFieldDefinitionsAndValuesResponseDataTypeListTypeContactsTypeModelsTypeItemAdditionalFieldValuesTypeModelsTypeItem[] Models { get; set; }
    }

    public class ReadAdditionalFieldDefinitionsAndValuesResponseDataTypeListTypeContactsTypeModelsTypeItemAdditionalFieldValuesTypeModelsTypeItem
    {
        [JsonProperty("contactId")]
        public string ContactId { get; set; }

        [JsonProperty("dataType")]
        public string DataType { get; set; }

        [JsonProperty("fieldDisplayName")]
        public string FieldDisplayName { get; set; }

        [JsonProperty("fieldId")]
        public string FieldId { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("listId")]
        public string ListId { get; set; }

        [JsonProperty("separator")]
        public string Separator { get; set; }

        [JsonProperty("valueItems")]
        public ReadAdditionalFieldDefinitionsAndValuesResponseDataTypeListTypeContactsTypeModelsTypeItemAdditionalFieldValuesTypeModelsTypeItemValueItemsTypeItem[] ValueItems { get; set; }
    }

    public class ReadAdditionalFieldDefinitionsAndValuesResponseDataTypeListTypeContactsTypeModelsTypeItemAdditionalFieldValuesTypeModelsTypeItemValueItemsTypeItem
    {
        [JsonProperty("lastEditDate")]
        public string LastEditDate { get; set; }

        [JsonProperty("qualification")]
        public string Qualification { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("valueId")]
        public string ValueId { get; set; }
    }

    public class ReadAdditionalFieldDefinitionsAndValuesInput
    {
        [JsonProperty("query", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Query { get; set; } = "query listContactAdditionalFieldsViewDefinitionsAndValues(     $id: ID!     $skip: Int     $limit: Int ) {     list(id: $id) {         id         name         description         listType {             id             isActive             listClass             name         }         additionalFieldDefinitions {             totalModels             models {                 userDataTypeUserProfessional                 userDataTypeUserActive                 stringDataTypeMultiLine                 stringDataTypeMaxLength                 secondaryFieldName                 numericDataTypeMinValue                 numericDataTypeMaxValue                 name                 listDataType {                     options {                         id                         name                     }                 }                 id                 fieldDataType                 description                 decimalDataTypePrecision                 dataTypeDisplayName                 booleanDataTypeFalseValue                 booleanDataTypeTrueValue                 allowsSecondaryField                 allowsMultipleValues             }         }         contacts(             skip: $skip             limit: $limit             sort: { direction: \"Ascending\", field: \"displayName\" }         ) {             totalModels             models {                 id                 title                 phoneNumber                 emailAddress                 displayName                 companyName                 companyId                 contactEntity                 sponsors {                     displayName                     fullName                     id                     isPrimary                 }                 additionalFieldValues {                     totalModels                     models {                         contactId                         dataType                         fieldDisplayName                         fieldId                         format                         id                         listId                         separator                         valueItems {                             lastEditDate                             qualification                             value                             valueId                         }                     }                 }             }         }     } }";

        [JsonProperty("variables", DefaultValueHandling = DefaultValueHandling.Include)]
        public ReadAdditionalFieldDefinitionsAndValuesInputVariablesType Variables { get; set; }
    }

    public class ReadAdditionalFieldDefinitionsAndValuesInputVariablesType
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("skip", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Skip { get; set; } = 0;

        [JsonProperty("limit", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Limit { get; set; } = 100;
    }

    public class AddOrUpdateAdditionalFieldValuesResponse
    {
        [JsonProperty("data")]
        public AddOrUpdateAdditionalFieldValuesResponseDataType Data { get; set; }
    }

    public class AddOrUpdateAdditionalFieldValuesResponseDataType
    {
        [JsonProperty("updateListContactAdditionalFields")]
        public AddOrUpdateAdditionalFieldValuesResponseDataTypeUpdateListContactAdditionalFieldsType UpdateListContactAdditionalFields { get; set; }
    }

    public class AddOrUpdateAdditionalFieldValuesResponseDataTypeUpdateListContactAdditionalFieldsType
    {
        [JsonProperty("models")]
        public AddOrUpdateAdditionalFieldValuesResponseDataTypeUpdateListContactAdditionalFieldsTypeModelsTypeItem[] Models { get; set; }

        [JsonProperty("__typename")]
        public string Typename { get; set; }
    }

    public class AddOrUpdateAdditionalFieldValuesResponseDataTypeUpdateListContactAdditionalFieldsTypeModelsTypeItem
    {
        [JsonProperty("failureReason")]
        public string FailureReason { get; set; }

        [JsonProperty("fieldId")]
        public string FieldId { get; set; }

        [JsonProperty("isSuccessful")]
        public bool IsSuccessful { get; set; }

        [JsonProperty("valueId")]
        public string ValueId { get; set; }

        [JsonProperty("__typename")]
        public string Typename { get; set; }
    }

    public class AddOrUpdateAdditionalFieldValuesInput
    {
        [JsonProperty("query", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Query { get; set; } = "mutation updateAdditionalFields($input: UpdateListContactAdditionalFieldInput!) {   updateListContactAdditionalFields(input: $input) {     models {       failureReason       fieldId       isSuccessful       valueId       __typename     }     __typename   } }";

        [JsonProperty("variables", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddOrUpdateAdditionalFieldValuesInputVariablesType Variables { get; set; }
    }

    public class AddOrUpdateAdditionalFieldValuesInputVariablesType
    {
        [JsonProperty("input", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddOrUpdateAdditionalFieldValuesInputVariablesTypeInputType Input { get; set; }
    }

    public class AddOrUpdateAdditionalFieldValuesInputVariablesTypeInputType
    {
        [JsonProperty("contactId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ContactId { get; set; }

        [JsonProperty("additionalFields", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddOrUpdateAdditionalFieldValuesInputVariablesTypeInputTypeAdditionalFieldsTypeItem[] AdditionalFields { get; set; }
    }

    public class AddOrUpdateAdditionalFieldValuesInputVariablesTypeInputTypeAdditionalFieldsTypeItem
    {
        [JsonProperty("fieldId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FieldId { get; set; }

        [JsonProperty("value", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Value { get; set; }

        [JsonProperty("valueId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ValueId { get; set; } = "null";

        [JsonProperty("lastEditDate", DefaultValueHandling = DefaultValueHandling.Include)]
        public string LastEditDate { get; set; } = "null";

        [JsonProperty("fieldDataType", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FieldDataType { get; set; }
    }

    public class ReadContactByIdResponse
    {
        [JsonProperty("data")]
        public ReadContactByIdResponseDataType Data { get; set; }
    }

    public class ReadContactByIdResponseDataType
    {
        [JsonProperty("contact")]
        public ReadContactByIdResponseDataTypeContactType Contact { get; set; }
    }

    public class ReadContactByIdResponseDataTypeContactType
    {
        [JsonProperty("contactId")]
        public string ContactId { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("middleName")]
        public string MiddleName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("goesBy")]
        public string GoesBy { get; set; }

        [JsonProperty("contactEntity")]
        public string ContactEntity { get; set; }

        [JsonProperty("currentJobTitle")]
        public string CurrentJobTitle { get; set; }

        [JsonProperty("currentEmployer")]
        public ReadContactByIdResponseDataTypeContactTypeCurrentEmployerType CurrentEmployer { get; set; }

        [JsonProperty("additionalFieldValues")]
        public ReadContactByIdResponseDataTypeContactTypeAdditionalFieldValuesType AdditionalFieldValues { get; set; }

        [JsonProperty("addresses")]
        public ReadContactByIdResponseDataTypeContactTypeAddressesTypeItem[] Addresses { get; set; }

        [JsonProperty("visibility")]
        public string Visibility { get; set; }

        [JsonProperty("emailAddresses")]
        public ReadContactByIdResponseDataTypeContactTypeEmailAddressesTypeItem[] EmailAddresses { get; set; }

        [JsonProperty("phoneNumbers")]
        public ReadContactByIdResponseDataTypeContactTypePhoneNumbersTypeItem[] PhoneNumbers { get; set; }

        [JsonProperty("activities")]
        public ReadContactByIdResponseDataTypeContactTypeActivitiesType Activities { get; set; }

        [JsonProperty("notes")]
        public ReadContactByIdResponseDataTypeContactTypeNotesType Notes { get; set; }

        [JsonProperty("lists")]
        public ReadContactByIdResponseDataTypeContactTypeListsType Lists { get; set; }
    }

    public class ReadContactByIdResponseDataTypeContactTypeCurrentEmployerType
    {
        [JsonProperty("companyName")]
        public string CompanyName { get; set; }

        [JsonProperty("companyId")]
        public string CompanyId { get; set; }
    }

    public class ReadContactByIdResponseDataTypeContactTypeAdditionalFieldValuesType
    {
        [JsonProperty("totalModels")]
        public int TotalModels { get; set; }

        [JsonProperty("models")]
        public ReadContactByIdResponseDataTypeContactTypeAdditionalFieldValuesTypeModelsTypeItem[] Models { get; set; }
    }

    public class ReadContactByIdResponseDataTypeContactTypeAdditionalFieldValuesTypeModelsTypeItem
    {
        [JsonProperty("contactId")]
        public string ContactId { get; set; }

        [JsonProperty("dataType")]
        public string DataType { get; set; }

        [JsonProperty("fieldId")]
        public string FieldId { get; set; }

        [JsonProperty("fieldDisplayName")]
        public string FieldDisplayName { get; set; }

        [JsonProperty("additionalFieldValueId")]
        public string AdditionalFieldValueId { get; set; }

        [JsonProperty("listId")]
        public string ListId { get; set; }

        [JsonProperty("valueItems")]
        public ReadContactByIdResponseDataTypeContactTypeAdditionalFieldValuesTypeModelsTypeItemValueItemsTypeItem[] ValueItems { get; set; }
    }

    public class ReadContactByIdResponseDataTypeContactTypeAdditionalFieldValuesTypeModelsTypeItemValueItemsTypeItem
    {
        [JsonProperty("lastEditDate")]
        public string LastEditDate { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("valueId")]
        public string ValueId { get; set; }
    }

    public class ReadContactByIdResponseDataTypeContactTypeAddressesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("street")]
        public string Street { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("administrativeDivision")]
        public string AdministrativeDivision { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("usage")]
        public string Usage { get; set; }
    }

    public class ReadContactByIdResponseDataTypeContactTypeEmailAddressesTypeItem
    {
        [JsonProperty("emailId")]
        public string EmailId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("usage")]
        public string Usage { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("owningContactId")]
        public string OwningContactId { get; set; }

        [JsonProperty("isGlobal")]
        public bool IsGlobal { get; set; }
    }

    public class ReadContactByIdResponseDataTypeContactTypePhoneNumbersTypeItem
    {
        [JsonProperty("phoneId")]
        public string PhoneId { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("usage")]
        public string Usage { get; set; }

        [JsonProperty("owningContactId")]
        public string OwningContactId { get; set; }

        [JsonProperty("isGlobal")]
        public bool IsGlobal { get; set; }
    }

    public class ReadContactByIdResponseDataTypeContactTypeActivitiesType
    {
        [JsonProperty("skip")]
        public int Skip { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("totalModels")]
        public int TotalModels { get; set; }

        [JsonProperty("models")]
        public ReadContactByIdResponseDataTypeContactTypeActivitiesTypeModelsTypeItem[] Models { get; set; }
    }

    public class ReadContactByIdResponseDataTypeContactTypeActivitiesTypeModelsTypeItem
    {
        [JsonProperty("activityId")]
        public string ActivityId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("typeId")]
        public string TypeId { get; set; }

        [JsonProperty("activityClass")]
        public string ActivityClass { get; set; }

        [JsonProperty("typeGroup")]
        public string TypeGroup { get; set; }

        [JsonProperty("activityStartDate")]
        public string ActivityStartDate { get; set; }

        [JsonProperty("lastEditedDate")]
        public string LastEditedDate { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public class ReadContactByIdResponseDataTypeContactTypeNotesType
    {
        [JsonProperty("allNotes")]
        public ReadContactByIdResponseDataTypeContactTypeNotesTypeAllNotesType AllNotes { get; set; }
    }

    public class ReadContactByIdResponseDataTypeContactTypeNotesTypeAllNotesType
    {
        [JsonProperty("totalModels")]
        public int TotalModels { get; set; }

        [JsonProperty("models")]
        public ReadContactByIdResponseDataTypeContactTypeNotesTypeAllNotesTypeModelsTypeItem[] Models { get; set; }
    }

    public class ReadContactByIdResponseDataTypeContactTypeNotesTypeAllNotesTypeModelsTypeItem
    {
        [JsonProperty("changeDate")]
        public string ChangeDate { get; set; }

        [JsonProperty("folderId")]
        public string FolderId { get; set; }

        [JsonProperty("noteId")]
        public string NoteId { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }
    }

    public class ReadContactByIdResponseDataTypeContactTypeListsType
    {
        [JsonProperty("totalModels")]
        public int TotalModels { get; set; }

        [JsonProperty("models")]
        public ReadContactByIdResponseDataTypeContactTypeListsTypeModelsTypeItem[] Models { get; set; }
    }

    public class ReadContactByIdResponseDataTypeContactTypeListsTypeModelsTypeItem
    {
        [JsonProperty("listId")]
        public string ListId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("listClass")]
        public string ListClass { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("userIsSponsor")]
        public bool UserIsSponsor { get; set; }

        [JsonProperty("allowedLinkInto")]
        public bool AllowedLinkInto { get; set; }

        [JsonProperty("allowedRemoveFrom")]
        public bool AllowedRemoveFrom { get; set; }

        [JsonProperty("ownerName")]
        public string OwnerName { get; set; }

        [JsonProperty("creatorName")]
        public string CreatorName { get; set; }

        [JsonProperty("sponsors")]
        public ReadContactByIdResponseDataTypeContactTypeListsTypeModelsTypeItemSponsorsTypeItem[] Sponsors { get; set; }
    }

    public class ReadContactByIdResponseDataTypeContactTypeListsTypeModelsTypeItemSponsorsTypeItem
    {
        [JsonProperty("sponsorId")]
        public string SponsorId { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("isPrimary")]
        public bool IsPrimary { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }
    }

    public class ReadContactByIdInput
    {
        [JsonProperty("query", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Query { get; set; } = "query contact($contactid: ID!, $listid: ID!) {   contact(id: $contactid) {     contactId: id     displayName     contactEntity     ... on Person {       contactId: id       displayName       title       firstName       middleName       lastName       goesBy       currentJobTitle       currentEmployer {         companyName: name         companyId: id       }       additionalFieldValues(listId: $listid) {         totalModels         models {           contactId           dataType           fieldId           fieldDisplayName           additionalFieldValueId: id           listId           valueItems {             lastEditDate             value             valueId           }         }       }       addresses {         addressID: id         street         city         administrativeDivision         country         postalCode       type       usage}     }     ... on Company {       contactId: id       name       additionalFieldValues(listId: $listid) {         totalModels         models {           contactId           dataType           fieldId           fieldDisplayName           id           listId           valueItems {             lastEditDate             value             valueId           }         }       }     }     visibility     emailAddresses {       emailId: id       type       usage       address       label       owningContactId       isGlobal     }     phoneNumbers {       phoneId: id       number       label       type       usage       owningContactId       isGlobal     }     activities {       totalModels       models {         ...ActivityFragment       }     }     notes {       allNotes {         ...NoteResultsFragment       }     }     lists(sort: {field: \"name\", direction: \"Ascending\"}, listIds: [$listid]) {       totalModels       models {         listId: id         name         listClass         description         type         userIsSponsor         allowedLinkInto         allowedRemoveFrom         ownerName         creatorName         sponsors {           sponsorId: id           displayName           isPrimary           fullName         }       }     }   } }  fragment ActivityFragment on Activity {   activityId: id   type   typeId   activityClass   typeGroup   activityStartDate   lastEditedDate   subject   summary   location }  fragment NoteResultsFragment on NoteResults {   totalModels   models {     changeDate     folderId     noteId     notes   } }";

        [JsonProperty("variables", DefaultValueHandling = DefaultValueHandling.Include)]
        public ReadContactByIdInputVariablesType Variables { get; set; }
    }

    public class ReadContactByIdInputVariablesType
    {
        [JsonProperty("contactid", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Contactid { get; set; }

        [JsonProperty("listid", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Listid { get; set; } = "00000000-0000-0000-0000-000000000000";
    }

    public class CreateContactResponse
    {
        [JsonProperty("data")]
        public CreateContactResponseDataType Data { get; set; }
    }

    public class CreateContactResponseDataType
    {
        [JsonProperty("addPerson")]
        public CreateContactResponseDataTypeAddPersonType AddPerson { get; set; }
    }

    public class CreateContactResponseDataTypeAddPersonType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("item")]
        public CreateContactResponseDataTypeAddPersonTypeItemType Item { get; set; }

        [JsonProperty("validationErrors")]
        public JToken[] ValidationErrors { get; set; }
    }

    public class CreateContactResponseDataTypeAddPersonTypeItemType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("goesBy")]
        public string GoesBy { get; set; }

        [JsonProperty("currentJobTitle")]
        public string CurrentJobTitle { get; set; }

        [JsonProperty("phoneNumbers")]
        public CreateContactResponseDataTypeAddPersonTypeItemTypePhoneNumbersTypeItem[] PhoneNumbers { get; set; }

        [JsonProperty("emailAddresses")]
        public CreateContactResponseDataTypeAddPersonTypeItemTypeEmailAddressesTypeItem[] EmailAddresses { get; set; }
    }

    public class CreateContactResponseDataTypeAddPersonTypeItemTypePhoneNumbersTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("usage")]
        public string Usage { get; set; }
    }

    public class CreateContactResponseDataTypeAddPersonTypeItemTypeEmailAddressesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("usage")]
        public string Usage { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }
    }

    public class CreateContactInput
    {
        [JsonProperty("query", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Query { get; set; } = "mutation addPerson($input: AddPersonInput!) {   addPerson(input: $input) {     status     item {       id       firstName       lastName       goesBy       currentJobTitle       phoneNumbers {         id         number         label         type         usage       }       emailAddresses {         id         type         usage         address         label       }       middleName       title       currentEmployer {         name       }       addresses {         city         country         administrativeDivision         street         postalCode       }     }     validationErrors {       propertyName       message     }   } }";

        [JsonProperty("variables", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateContactInputVariablesType Variables { get; set; }
    }

    public class CreateContactInputVariablesType
    {
        [JsonProperty("input", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateContactInputVariablesTypeInputType Input { get; set; }
    }

    public class CreateContactInputVariablesTypeInputType
    {
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("middleName")]
        public string MiddleName { get; set; }

        [JsonProperty("lastName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string LastName { get; set; }

        [JsonProperty("goesBy")]
        public string GoesBy { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }

        [JsonProperty("companyName")]
        public string CompanyName { get; set; }

        [JsonProperty("jobTitle")]
        public string JobTitle { get; set; }

        [JsonProperty("primaryPhone")]
        public string PrimaryPhone { get; set; }

        [JsonProperty("businessAddress")]
        public CreateContactInputVariablesTypeInputTypeBusinessAddressType BusinessAddress { get; set; }
    }

    public class CreateContactInputVariablesTypeInputTypeBusinessAddressType
    {
        [JsonProperty("country")]
        public CreateContactInputVariablesTypeInputTypeBusinessAddressTypeCountryType? Country { get; set; }

        [JsonProperty("street")]
        public string Street { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("administrativeDivision")]
        public string AdministrativeDivision { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateContactInputVariablesTypeInputTypeBusinessAddressTypeCountryType
    {
        Afghanistan,
        [EnumMember(Value = "Aland Islands")]
        AlandIslands,
        Albania,
        Algeria,
        [EnumMember(Value = "American Samoa")]
        AmericanSamoa,
        Andorra,
        Angola,
        Anguilla,
        Antarctica,
        [EnumMember(Value = "Antigua and Barbuda")]
        AntiguaAndBarbuda,
        Argentina,
        Armenia,
        Aruba,
        Australia,
        Austria,
        Azerbaijan,
        Bahamas,
        Bahrain,
        Bangladesh,
        Barbados,
        Belarus,
        Belgium,
        Belize,
        Benin,
        Bermuda,
        Bhutan,
        [EnumMember(Value = "Bolivia, Plurinational State of")]
        BoliviaPlurinationalStateOf,
        [EnumMember(Value = "Bonaire, Sint Eustatius and Saba")]
        BonaireSintEustatiusAndSaba,
        [EnumMember(Value = "Bosnia and Herzegovina")]
        BosniaAndHerzegovina,
        Botswana,
        [EnumMember(Value = "Bouvet Island")]
        BouvetIsland,
        Brazil,
        [EnumMember(Value = "British Indian Ocean Territory")]
        BritishIndianOceanTerritory,
        [EnumMember(Value = "British Virgin Islands")]
        BritishVirginIslands,
        [EnumMember(Value = "Brunei Darussalam")]
        BruneiDarussalam,
        Bulgaria,
        [EnumMember(Value = "Burkina Faso")]
        BurkinaFaso,
        Burundi,
        Cambodia,
        Cameroon,
        Canada,
        [EnumMember(Value = "Cape Verde")]
        CapeVerde,
        [EnumMember(Value = "Cayman Islands")]
        CaymanIslands,
        [EnumMember(Value = "Central African Republic")]
        CentralAfricanRepublic,
        Chad,
        Chile,
        China,
        [EnumMember(Value = "Christmas Island")]
        ChristmasIsland,
        [EnumMember(Value = "Cocos (Keeling) Islands")]
        CocosKeelingIslands,
        Colombia,
        Comoros,
        Congo,
        [EnumMember(Value = "Cook Islands")]
        CookIslands,
        [EnumMember(Value = "Costa Rica")]
        CostaRica,
        [EnumMember(Value = "Côte d'Ivoire")]
        CôteDIvoire,
        Croatia,
        Cuba,
        Curaçao,
        Cyprus,
        [EnumMember(Value = "Czech Republic")]
        CzechRepublic,
        [EnumMember(Value = "Democratic Republic of Congo")]
        DemocraticRepublicOfCongo,
        Denmark,
        Djibouti,
        Dominica,
        [EnumMember(Value = "Dominican Republic")]
        DominicanRepublic,
        Ecuador,
        Egypt,
        [EnumMember(Value = "El Salvador")]
        ElSalvador,
        [EnumMember(Value = "Equatorial Guinea")]
        EquatorialGuinea,
        Eritrea,
        Estonia,
        Ethiopia,
        [EnumMember(Value = "Faeroe Islands")]
        FaeroeIslands,
        [EnumMember(Value = "Falkland Islands")]
        FalklandIslands,
        [EnumMember(Value = "Federal Republic of Somalia")]
        FederalRepublicOfSomalia,
        Fiji,
        Finland,
        France,
        [EnumMember(Value = "French Guiana")]
        FrenchGuiana,
        [EnumMember(Value = "French Polynesia")]
        FrenchPolynesia,
        [EnumMember(Value = "French Southern Territories")]
        FrenchSouthernTerritories,
        Gabon,
        Gambia,
        Georgia,
        Germany,
        Ghana,
        Gibraltar,
        Greece,
        Greenland,
        Grenada,
        Guadeloupe,
        Guam,
        Guatemala,
        Guernsey,
        Guinea,
        [EnumMember(Value = "Guinea-Bissau")]
        GuineaBissau,
        Guyana,
        Haiti,
        [EnumMember(Value = "Heard Island and McDonald Islands")]
        HeardIslandAndMcDonaldIslands,
        Honduras,
        [EnumMember(Value = "Hong Kong")]
        HongKong,
        Hungary,
        Iceland,
        India,
        Indonesia,
        Iran,
        Iraq,
        Ireland,
        [EnumMember(Value = "Isle of Man")]
        IsleOfMan,
        Israel,
        Italy,
        Jamaica,
        Japan,
        Jersey,
        Jordan,
        Kazakhstan,
        Kenya,
        Kiribati,
        Kuwait,
        Kyrgyzstan,
        Laos,
        Latvia,
        Lebanon,
        Lesotho,
        Liberia,
        Libya,
        Liechtenstein,
        Lithuania,
        Luxembourg,
        Macau,
        Macedonia,
        Madagascar,
        Malawi,
        Malaysia,
        Maldives,
        Mali,
        Malta,
        [EnumMember(Value = "Marshall Islands")]
        MarshallIslands,
        Martinique,
        Mauritania,
        Mauritius,
        Mayotte,
        Mexico,
        [EnumMember(Value = "Micronesia (Federated States of)")]
        MicronesiaFederatedStatesOf,
        Monaco,
        Mongolia,
        Montenegro,
        Montserrat,
        Morocco,
        Mozambique,
        Myanmar,
        Namibia,
        Nauru,
        Nepal,
        Netherlands,
        [EnumMember(Value = "New Caledonia")]
        NewCaledonia,
        [EnumMember(Value = "New Zealand")]
        NewZealand,
        Nicaragua,
        Niger,
        Nigeria,
        Niue,
        [EnumMember(Value = "Norfolk Island")]
        NorfolkIsland,
        [EnumMember(Value = "North Korea")]
        NorthKorea,
        [EnumMember(Value = "Northern Mariana Islands")]
        NorthernMarianaIslands,
        Norway,
        Oman,
        Pakistan,
        Palau,
        [EnumMember(Value = "Palestinian Territory, Occupied")]
        PalestinianTerritoryOccupied,
        Panama,
        [EnumMember(Value = "Papua New Guinea, Independent State of")]
        PapuaNewGuineaIndependentStateOf,
        Paraguay,
        Peru,
        Philippines,
        Pitcairn,
        Poland,
        Portugal,
        [EnumMember(Value = "Puerto Rico")]
        PuertoRico,
        Qatar,
        [EnumMember(Value = "Republic of Moldova")]
        RepublicOfMoldova,
        Réunion,
        Romania,
        Russia,
        Rwanda,
        [EnumMember(Value = "Saint Barthélemy")]
        SaintBarthélemy,
        [EnumMember(Value = "Saint Helena, Ascension and Tristan da Cunha")]
        SaintHelenaAscensionAndTristanDaCunha,
        [EnumMember(Value = "Saint Kitts and Nevis")]
        SaintKittsAndNevis,
        [EnumMember(Value = "Saint Martin (French Part)")]
        SaintMartinFrenchPart,
        [EnumMember(Value = "Saint Pierre and Miquelon")]
        SaintPierreAndMiquelon,
        [EnumMember(Value = "Saint Vincent and the Grenadines")]
        SaintVincentAndTheGrenadines,
        Samoa,
        [EnumMember(Value = "San Marino")]
        SanMarino,
        [EnumMember(Value = "Sao Tome and Principe")]
        SaoTomeAndPrincipe,
        [EnumMember(Value = "Saudi Arabia")]
        SaudiArabia,
        Senegal,
        Serbia,
        Seychelles,
        [EnumMember(Value = "Sierra Leone")]
        SierraLeone,
        Singapore,
        Slovakia,
        Slovenia,
        [EnumMember(Value = "Solomon Islands")]
        SolomonIslands,
        [EnumMember(Value = "South Africa")]
        SouthAfrica,
        [EnumMember(Value = "South Georgia and South Sandwich Islands")]
        SouthGeorgiaAndSouthSandwichIslands,
        [EnumMember(Value = "South Korea")]
        SouthKorea,
        [EnumMember(Value = "South Sudan")]
        SouthSudan,
        Spain,
        [EnumMember(Value = "Sri Lanka")]
        SriLanka,
        [EnumMember(Value = "St. Lucia")]
        StLucia,
        [EnumMember(Value = "St. Maarten (Dutch Part)")]
        StMaartenDutchPart,
        Sudan,
        Suriname,
        [EnumMember(Value = "Svalbard and Jan Mayen")]
        SvalbardAndJanMayen,
        Swaziland,
        Sweden,
        Switzerland,
        Syria,
        Taiwan,
        Tajikistan,
        Tanzania,
        Thailand,
        [EnumMember(Value = "Timor-Leste")]
        TimorLeste,
        Togo,
        Tokelau,
        Tonga,
        [EnumMember(Value = "Trinidad and Tobago")]
        TrinidadAndTobago,
        Tunisia,
        Turkey,
        Turkmenistan,
        [EnumMember(Value = "Turks and Caicos Islands")]
        TurksAndCaicosIslands,
        Tuvalu,
        [EnumMember(Value = "U.S. Virgin Islands")]
        USVirginIslands,
        Uganda,
        Ukraine,
        [EnumMember(Value = "United Arab Emirates")]
        UnitedArabEmirates,
        [EnumMember(Value = "United Kingdom")]
        UnitedKingdom,
        [EnumMember(Value = "United States Minor Outlying Islands")]
        UnitedStatesMinorOutlyingIslands,
        [EnumMember(Value = "United States of America")]
        UnitedStatesOfAmerica,
        Uruguay,
        Uzbekistan,
        Vanuatu,
        Vatican,
        [EnumMember(Value = "Venezuela, Bolivarian Republic of")]
        VenezuelaBolivarianRepublicOf,
        Vietnam,
        [EnumMember(Value = "Wallis and Futuna")]
        WallisAndFutuna,
        [EnumMember(Value = "Western Sahara")]
        WesternSahara,
        Yemen,
        Zambia,
        Zimbabwe
    }

    public class ListResponse
    {
        [JsonProperty("data")]
        public ListResponseDataType Data { get; set; }
    }

    public class ListResponseDataType
    {
        [JsonProperty("lists")]
        public ListResponseDataTypeListsType Lists { get; set; }
    }

    public class ListResponseDataTypeListsType
    {
        [JsonProperty("skip")]
        public int Skip { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("totalModels")]
        public int TotalModels { get; set; }

        [JsonProperty("models")]
        public ListResponseDataTypeListsTypeModelsTypeItem[] Models { get; set; }
    }

    public class ListResponseDataTypeListsTypeModelsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("listType")]
        public ListResponseDataTypeListsTypeModelsTypeItemListTypeType ListType { get; set; }

        [JsonProperty("allowedLinkInto")]
        public bool AllowedLinkInto { get; set; }

        [JsonProperty("allowedRemoveFrom")]
        public bool AllowedRemoveFrom { get; set; }

        [JsonProperty("addAllowed")]
        public bool AddAllowed { get; set; }

        [JsonProperty("deleteAllowed")]
        public bool DeleteAllowed { get; set; }

        [JsonProperty("addActivityAllowed")]
        public bool AddActivityAllowed { get; set; }

        [JsonProperty("addNoteAllowed")]
        public bool AddNoteAllowed { get; set; }

        [JsonProperty("ownerName")]
        public string OwnerName { get; set; }

        [JsonProperty("creatorName")]
        public string CreatorName { get; set; }

        [JsonProperty("allowedContactEntity")]
        public string AllowedContactEntity { get; set; }

        [JsonProperty("isAdministrator")]
        public bool IsAdministrator { get; set; }
    }

    public class ListResponseDataTypeListsTypeModelsTypeItemListTypeType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("isActive")]
        public bool IsActive { get; set; }

        [JsonProperty("listClass")]
        public string ListClass { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ReadListsInput
    {
        [JsonProperty("query", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Query { get; set; } = "query Lists($listClass: [ListClass], $skip: Int, $limit: Int, $filterByName: String) {   lists(listClass: $listClass, skip: $skip, limit: $limit,  filter: {field: name, value: $filterByName}) {     skip     limit     totalModels     models {       id       name       description       listType {         id         isActive         listClass         name       }       allowedLinkInto       allowedRemoveFrom       addAllowed       deleteAllowed       addActivityAllowed       addNoteAllowed       ownerName       creatorName       allowedContactEntity       isAdministrator     }   } }";

        [JsonProperty("variables")]
        public ReadListsInputVariablesType Variables { get; set; }
    }

    public class ReadListsInputVariablesType
    {
        [JsonProperty("listClass")]
        public ReadListsInputVariablesTypeListClassType? ListClass { get; set; }

        [JsonProperty("skip", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Skip { get; set; } = 0;

        [JsonProperty("limit", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Limit { get; set; } = 100;

        [JsonProperty("filterByName")]
        public string FilterByName { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ReadListsInputVariablesTypeListClassType
    {
        MarketingList,
        MarketingListWithSponsorship,
        WorkingList,
        AllLists,
        AllMarketingLists
    }

    public class AddContactsToListsResponse
    {
        [JsonProperty("data")]
        public AddContactsToListsResponseDataType Data { get; set; }
    }

    public class AddContactsToListsResponseDataType
    {
        [JsonProperty("addContactsToLists")]
        public AddContactsToListsResponseDataTypeAddContactsToListsType AddContactsToLists { get; set; }
    }

    public class AddContactsToListsResponseDataTypeAddContactsToListsType
    {
        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty("successCount")]
        public int SuccessCount { get; set; }

        [JsonProperty("resultText")]
        public string ResultText { get; set; }
    }

    public class AddContactsToListsInput
    {
        [JsonProperty("query", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Query { get; set; } = "mutation addContactsToLists(   $listIds: [ID!]!,   $contactIds: [ID!]! ) {   addContactsToLists(     listIds: $listIds,     contactIds: $contactIds   ) {     totalCount     successCount     resultText   } }";

        [JsonProperty("variables", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddContactsToListsInputVariablesType Variables { get; set; }
    }

    public class AddContactsToListsInputVariablesType
    {
        [JsonProperty("listIds", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] ListIds { get; set; }

        [JsonProperty("contactIds", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] ContactIds { get; set; }
    }

    public class RemoveContactsfromListResponse
    {
        [JsonProperty("data")]
        public RemoveContactsfromListResponseDataType Data { get; set; }
    }

    public class RemoveContactsfromListResponseDataType
    {
        [JsonProperty("removeContactsFromList")]
        public RemoveContactsfromListResponseDataTypeRemoveContactsFromListType RemoveContactsFromList { get; set; }
    }

    public class RemoveContactsfromListResponseDataTypeRemoveContactsFromListType
    {
        [JsonProperty("resultText")]
        public string ResultText { get; set; }

        [JsonProperty("pendingContactsEffected")]
        public int PendingContactsEffected { get; set; }

        [JsonProperty("contactsEffected")]
        public int ContactsEffected { get; set; }
    }

    public class RemoveContactsfromListInput
    {
        [JsonProperty("query", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Query { get; set; } = "mutation MyMutation ($contactIds : [ID!]!, $listId: ID!){   removeContactsFromList(contactIds: $contactIds, listId: $listId) {     resultText pendingContactsEffected     contactsEffected  } }";

        [JsonProperty("variables", DefaultValueHandling = DefaultValueHandling.Include)]
        public RemoveContactsfromListInputVariablesType Variables { get; set; }
    }

    public class RemoveContactsfromListInputVariablesType
    {
        [JsonProperty("contactIds", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] ContactIds { get; set; }

        [JsonProperty("listId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ListId { get; set; }
    }

    public class UpdatePersonContactResponse
    {
        [JsonProperty("data")]
        public UpdatePersonContactResponseDataType Data { get; set; }
    }

    public class UpdatePersonContactResponseDataType
    {
        [JsonProperty("updatePublicPerson")]
        public UpdatePersonContactResponseDataTypeUpdatePublicPersonType UpdatePublicPerson { get; set; }
    }

    public class UpdatePersonContactResponseDataTypeUpdatePublicPersonType
    {
        [JsonProperty("item")]
        public UpdatePersonContactResponseDataTypeUpdatePublicPersonTypeItemType Item { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("validationErrors")]
        public JToken[] ValidationErrors { get; set; }
    }

    public class UpdatePersonContactResponseDataTypeUpdatePublicPersonTypeItemType
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UpdatePersonContactInput
    {
        [JsonProperty("query", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Query { get; set; } = "mutation updatePublicPerson($input: UpdatePublicPersonInput!) {   updatePublicPerson(input: $input) {     item {       id      }     status     validationErrors {       propertyName       message           }   } }";

        [JsonProperty("variables", DefaultValueHandling = DefaultValueHandling.Include)]
        public UpdatePersonContactInputVariablesType Variables { get; set; }
    }

    public class UpdatePersonContactInputVariablesType
    {
        [JsonProperty("input", DefaultValueHandling = DefaultValueHandling.Include)]
        public UpdatePersonContactInputVariablesTypeInputType Input { get; set; }
    }

    public class UpdatePersonContactInputVariablesTypeInputType
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("middleName")]
        public string MiddleName { get; set; }

        [JsonProperty("lastName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string LastName { get; set; }

        [JsonProperty("goesBy")]
        public string GoesBy { get; set; }

        [JsonProperty("jobTitle")]
        public string JobTitle { get; set; }

        [JsonProperty("address")]
        public UpdatePersonContactInputVariablesTypeInputTypeAddressType Address { get; set; }

        [JsonProperty("email")]
        public UpdatePersonContactInputVariablesTypeInputTypeEmailType Email { get; set; }

        [JsonProperty("primaryPhone")]
        public UpdatePersonContactInputVariablesTypeInputTypePrimaryPhoneType PrimaryPhone { get; set; }

        [JsonProperty("companyName")]
        public string CompanyName { get; set; }
    }

    public class UpdatePersonContactInputVariablesTypeInputTypeAddressType
    {
        [JsonProperty("street")]
        public string Street { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("administrativeDivision")]
        public string AdministrativeDivision { get; set; }

        [JsonProperty("country")]
        public UpdatePersonContactInputVariablesTypeInputTypeAddressTypeCountryType? Country { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdatePersonContactInputVariablesTypeInputTypeAddressTypeCountryType
    {
        Afghanistan,
        [EnumMember(Value = "Aland Islands")]
        AlandIslands,
        Albania,
        Algeria,
        [EnumMember(Value = "American Samoa")]
        AmericanSamoa,
        Andorra,
        Angola,
        Anguilla,
        Antarctica,
        [EnumMember(Value = "Antigua and Barbuda")]
        AntiguaAndBarbuda,
        Argentina,
        Armenia,
        Aruba,
        Australia,
        Austria,
        Azerbaijan,
        Bahamas,
        Bahrain,
        Bangladesh,
        Barbados,
        Belarus,
        Belgium,
        Belize,
        Benin,
        Bermuda,
        Bhutan,
        [EnumMember(Value = "Bolivia, Plurinational State of")]
        BoliviaPlurinationalStateOf,
        [EnumMember(Value = "Bonaire, Sint Eustatius and Saba")]
        BonaireSintEustatiusAndSaba,
        [EnumMember(Value = "Bosnia and Herzegovina")]
        BosniaAndHerzegovina,
        Botswana,
        [EnumMember(Value = "Bouvet Island")]
        BouvetIsland,
        Brazil,
        [EnumMember(Value = "British Indian Ocean Territory")]
        BritishIndianOceanTerritory,
        [EnumMember(Value = "British Virgin Islands")]
        BritishVirginIslands,
        [EnumMember(Value = "Brunei Darussalam")]
        BruneiDarussalam,
        Bulgaria,
        [EnumMember(Value = "Burkina Faso")]
        BurkinaFaso,
        Burundi,
        Cambodia,
        Cameroon,
        Canada,
        [EnumMember(Value = "Cape Verde")]
        CapeVerde,
        [EnumMember(Value = "Cayman Islands")]
        CaymanIslands,
        [EnumMember(Value = "Central African Republic")]
        CentralAfricanRepublic,
        Chad,
        Chile,
        China,
        [EnumMember(Value = "Christmas Island")]
        ChristmasIsland,
        [EnumMember(Value = "Cocos (Keeling) Islands")]
        CocosKeelingIslands,
        Colombia,
        Comoros,
        Congo,
        [EnumMember(Value = "Cook Islands")]
        CookIslands,
        [EnumMember(Value = "Costa Rica")]
        CostaRica,
        [EnumMember(Value = "Côte d'Ivoire")]
        CôteDIvoire,
        Croatia,
        Cuba,
        Curaçao,
        Cyprus,
        [EnumMember(Value = "Czech Republic")]
        CzechRepublic,
        [EnumMember(Value = "Democratic Republic of Congo")]
        DemocraticRepublicOfCongo,
        Denmark,
        Djibouti,
        Dominica,
        [EnumMember(Value = "Dominican Republic")]
        DominicanRepublic,
        Ecuador,
        Egypt,
        [EnumMember(Value = "El Salvador")]
        ElSalvador,
        [EnumMember(Value = "Equatorial Guinea")]
        EquatorialGuinea,
        Eritrea,
        Estonia,
        Ethiopia,
        [EnumMember(Value = "Faeroe Islands")]
        FaeroeIslands,
        [EnumMember(Value = "Falkland Islands")]
        FalklandIslands,
        [EnumMember(Value = "Federal Republic of Somalia")]
        FederalRepublicOfSomalia,
        Fiji,
        Finland,
        France,
        [EnumMember(Value = "French Guiana")]
        FrenchGuiana,
        [EnumMember(Value = "French Polynesia")]
        FrenchPolynesia,
        [EnumMember(Value = "French Southern Territories")]
        FrenchSouthernTerritories,
        Gabon,
        Gambia,
        Georgia,
        Germany,
        Ghana,
        Gibraltar,
        Greece,
        Greenland,
        Grenada,
        Guadeloupe,
        Guam,
        Guatemala,
        Guernsey,
        Guinea,
        [EnumMember(Value = "Guinea-Bissau")]
        GuineaBissau,
        Guyana,
        Haiti,
        [EnumMember(Value = "Heard Island and McDonald Islands")]
        HeardIslandAndMcDonaldIslands,
        Honduras,
        [EnumMember(Value = "Hong Kong")]
        HongKong,
        Hungary,
        Iceland,
        India,
        Indonesia,
        Iran,
        Iraq,
        Ireland,
        [EnumMember(Value = "Isle of Man")]
        IsleOfMan,
        Israel,
        Italy,
        Jamaica,
        Japan,
        Jersey,
        Jordan,
        Kazakhstan,
        Kenya,
        Kiribati,
        Kuwait,
        Kyrgyzstan,
        Laos,
        Latvia,
        Lebanon,
        Lesotho,
        Liberia,
        Libya,
        Liechtenstein,
        Lithuania,
        Luxembourg,
        Macau,
        Macedonia,
        Madagascar,
        Malawi,
        Malaysia,
        Maldives,
        Mali,
        Malta,
        [EnumMember(Value = "Marshall Islands")]
        MarshallIslands,
        Martinique,
        Mauritania,
        Mauritius,
        Mayotte,
        Mexico,
        [EnumMember(Value = "Micronesia (Federated States of)")]
        MicronesiaFederatedStatesOf,
        Monaco,
        Mongolia,
        Montenegro,
        Montserrat,
        Morocco,
        Mozambique,
        Myanmar,
        Namibia,
        Nauru,
        Nepal,
        Netherlands,
        [EnumMember(Value = "New Caledonia")]
        NewCaledonia,
        [EnumMember(Value = "New Zealand")]
        NewZealand,
        Nicaragua,
        Niger,
        Nigeria,
        Niue,
        [EnumMember(Value = "Norfolk Island")]
        NorfolkIsland,
        [EnumMember(Value = "North Korea")]
        NorthKorea,
        [EnumMember(Value = "Northern Mariana Islands")]
        NorthernMarianaIslands,
        Norway,
        Oman,
        Pakistan,
        Palau,
        [EnumMember(Value = "Palestinian Territory, Occupied")]
        PalestinianTerritoryOccupied,
        Panama,
        [EnumMember(Value = "Papua New Guinea, Independent State of")]
        PapuaNewGuineaIndependentStateOf,
        Paraguay,
        Peru,
        Philippines,
        Pitcairn,
        Poland,
        Portugal,
        [EnumMember(Value = "Puerto Rico")]
        PuertoRico,
        Qatar,
        [EnumMember(Value = "Republic of Moldova")]
        RepublicOfMoldova,
        Réunion,
        Romania,
        Russia,
        Rwanda,
        [EnumMember(Value = "Saint Barthélemy")]
        SaintBarthélemy,
        [EnumMember(Value = "Saint Helena, Ascension and Tristan da Cunha")]
        SaintHelenaAscensionAndTristanDaCunha,
        [EnumMember(Value = "Saint Kitts and Nevis")]
        SaintKittsAndNevis,
        [EnumMember(Value = "Saint Martin (French Part)")]
        SaintMartinFrenchPart,
        [EnumMember(Value = "Saint Pierre and Miquelon")]
        SaintPierreAndMiquelon,
        [EnumMember(Value = "Saint Vincent and the Grenadines")]
        SaintVincentAndTheGrenadines,
        Samoa,
        [EnumMember(Value = "San Marino")]
        SanMarino,
        [EnumMember(Value = "Sao Tome and Principe")]
        SaoTomeAndPrincipe,
        [EnumMember(Value = "Saudi Arabia")]
        SaudiArabia,
        Senegal,
        Serbia,
        Seychelles,
        [EnumMember(Value = "Sierra Leone")]
        SierraLeone,
        Singapore,
        Slovakia,
        Slovenia,
        [EnumMember(Value = "Solomon Islands")]
        SolomonIslands,
        [EnumMember(Value = "South Africa")]
        SouthAfrica,
        [EnumMember(Value = "South Georgia and South Sandwich Islands")]
        SouthGeorgiaAndSouthSandwichIslands,
        [EnumMember(Value = "South Korea")]
        SouthKorea,
        [EnumMember(Value = "South Sudan")]
        SouthSudan,
        Spain,
        [EnumMember(Value = "Sri Lanka")]
        SriLanka,
        [EnumMember(Value = "St. Lucia")]
        StLucia,
        [EnumMember(Value = "St. Maarten (Dutch Part)")]
        StMaartenDutchPart,
        Sudan,
        Suriname,
        [EnumMember(Value = "Svalbard and Jan Mayen")]
        SvalbardAndJanMayen,
        Swaziland,
        Sweden,
        Switzerland,
        Syria,
        Taiwan,
        Tajikistan,
        Tanzania,
        Thailand,
        [EnumMember(Value = "Timor-Leste")]
        TimorLeste,
        Togo,
        Tokelau,
        Tonga,
        [EnumMember(Value = "Trinidad and Tobago")]
        TrinidadAndTobago,
        Tunisia,
        Turkey,
        Turkmenistan,
        [EnumMember(Value = "Turks and Caicos Islands")]
        TurksAndCaicosIslands,
        Tuvalu,
        [EnumMember(Value = "U.S. Virgin Islands")]
        USVirginIslands,
        Uganda,
        Ukraine,
        [EnumMember(Value = "United Arab Emirates")]
        UnitedArabEmirates,
        [EnumMember(Value = "United Kingdom")]
        UnitedKingdom,
        [EnumMember(Value = "United States Minor Outlying Islands")]
        UnitedStatesMinorOutlyingIslands,
        [EnumMember(Value = "United States of America")]
        UnitedStatesOfAmerica,
        Uruguay,
        Uzbekistan,
        Vanuatu,
        Vatican,
        [EnumMember(Value = "Venezuela, Bolivarian Republic of")]
        VenezuelaBolivarianRepublicOf,
        Vietnam,
        [EnumMember(Value = "Wallis and Futuna")]
        WallisAndFutuna,
        [EnumMember(Value = "Western Sahara")]
        WesternSahara,
        Yemen,
        Zambia,
        Zimbabwe
    }

    public class UpdatePersonContactInputVariablesTypeInputTypeEmailType
    {
        [JsonProperty("electronicAddress")]
        public string ElectronicAddress { get; set; }
    }

    public class UpdatePersonContactInputVariablesTypeInputTypePrimaryPhoneType
    {
        [JsonProperty("number")]
        public string Number { get; set; }
    }

    public class CreateActivityResponse
    {
        [JsonProperty("data")]
        public CreateActivityResponseDataType Data { get; set; }
    }

    public class CreateActivityResponseDataType
    {
        [JsonProperty("addActivity")]
        public CreateActivityResponseDataTypeAddActivityType AddActivity { get; set; }
    }

    public class CreateActivityResponseDataTypeAddActivityType
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateActivityInput
    {
        [JsonProperty("query", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Query { get; set; } = "mutation addActivity($input: AddActivityInput!) {   addActivity(input: $input) {     id   } }";

        [JsonProperty("variables", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateActivityInputVariablesType Variables { get; set; }
    }

    public class CreateActivityInputVariablesType
    {
        [JsonProperty("input", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateActivityInputVariablesTypeInputType Input { get; set; }
    }

    public class CreateActivityInputVariablesTypeInputType
    {
        [JsonProperty("typeId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TypeId { get; set; }

        [JsonProperty("activityDate", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ActivityDate { get; set; }

        [JsonProperty("subject", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Subject { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("linkedEntityIds", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] LinkedEntityIds { get; set; }
    }

    public class SearchContactsResponse
    {
        [JsonProperty("data")]
        public SearchContactsResponseDataType Data { get; set; }
    }

    public class SearchContactsResponseDataType
    {
        [JsonProperty("searchFirmContacts")]
        public SearchContactsResponseDataTypeSearchFirmContactsType SearchFirmContacts { get; set; }
    }

    public class SearchContactsResponseDataTypeSearchFirmContactsType
    {
        [JsonProperty("totalModels")]
        public int TotalModels { get; set; }

        [JsonProperty("models")]
        public SearchContactsResponseDataTypeSearchFirmContactsTypeModelsTypeItem[] Models { get; set; }
    }

    public class SearchContactsResponseDataTypeSearchFirmContactsTypeModelsTypeItem
    {
        [JsonProperty("contactId")]
        public string ContactId { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("contactEntity")]
        public string ContactEntity { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("middleName")]
        public string MiddleName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("currentJobTitle")]
        public string CurrentJobTitle { get; set; }

        [JsonProperty("currentEmployer")]
        public SearchContactsResponseDataTypeSearchFirmContactsTypeModelsTypeItemCurrentEmployerType CurrentEmployer { get; set; }

        [JsonProperty("addresses")]
        public SearchContactsResponseDataTypeSearchFirmContactsTypeModelsTypeItemAddressesTypeItem[] Addresses { get; set; }

        [JsonProperty("visibility")]
        public string Visibility { get; set; }

        [JsonProperty("emailAddresses")]
        public SearchContactsResponseDataTypeSearchFirmContactsTypeModelsTypeItemEmailAddressesTypeItem[] EmailAddresses { get; set; }

        [JsonProperty("phoneNumbers")]
        public SearchContactsResponseDataTypeSearchFirmContactsTypeModelsTypeItemPhoneNumbersTypeItem[] PhoneNumbers { get; set; }

        [JsonProperty("activities")]
        public SearchContactsResponseDataTypeSearchFirmContactsTypeModelsTypeItemActivitiesType Activities { get; set; }

        [JsonProperty("notes")]
        public SearchContactsResponseDataTypeSearchFirmContactsTypeModelsTypeItemNotesType Notes { get; set; }

        [JsonProperty("lists")]
        public SearchContactsResponseDataTypeSearchFirmContactsTypeModelsTypeItemListsType Lists { get; set; }
    }

    public class SearchContactsResponseDataTypeSearchFirmContactsTypeModelsTypeItemCurrentEmployerType
    {
        [JsonProperty("companyName")]
        public string CompanyName { get; set; }

        [JsonProperty("companyId")]
        public string CompanyId { get; set; }
    }

    public class SearchContactsResponseDataTypeSearchFirmContactsTypeModelsTypeItemAddressesTypeItem
    {
        [JsonProperty("addressID")]
        public string AddressId { get; set; }

        [JsonProperty("street")]
        public string Street { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("administrativeDivision")]
        public string AdministrativeDivision { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("usage")]
        public string Usage { get; set; }
    }

    public class SearchContactsResponseDataTypeSearchFirmContactsTypeModelsTypeItemEmailAddressesTypeItem
    {
        [JsonProperty("emailId")]
        public string EmailId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("usage")]
        public string Usage { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("owningContactId")]
        public string OwningContactId { get; set; }

        [JsonProperty("isGlobal")]
        public bool IsGlobal { get; set; }
    }

    public class SearchContactsResponseDataTypeSearchFirmContactsTypeModelsTypeItemPhoneNumbersTypeItem
    {
        [JsonProperty("phoneId")]
        public string PhoneId { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("usage")]
        public string Usage { get; set; }

        [JsonProperty("owningContactId")]
        public string OwningContactId { get; set; }

        [JsonProperty("isGlobal")]
        public bool IsGlobal { get; set; }
    }

    public class SearchContactsResponseDataTypeSearchFirmContactsTypeModelsTypeItemActivitiesType
    {
        [JsonProperty("skip")]
        public int Skip { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("totalModels")]
        public int TotalModels { get; set; }

        [JsonProperty("models")]
        public SearchContactsResponseDataTypeSearchFirmContactsTypeModelsTypeItemActivitiesTypeModelsTypeItem[] Models { get; set; }
    }

    public class SearchContactsResponseDataTypeSearchFirmContactsTypeModelsTypeItemActivitiesTypeModelsTypeItem
    {
        [JsonProperty("activityId")]
        public string ActivityId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("typeId")]
        public string TypeId { get; set; }

        [JsonProperty("activityClass")]
        public string ActivityClass { get; set; }

        [JsonProperty("typeGroup")]
        public string TypeGroup { get; set; }

        [JsonProperty("activityStartDate")]
        public string ActivityStartDate { get; set; }

        [JsonProperty("lastEditedDate")]
        public string LastEditedDate { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public class SearchContactsResponseDataTypeSearchFirmContactsTypeModelsTypeItemNotesType
    {
        [JsonProperty("allNotes")]
        public SearchContactsResponseDataTypeSearchFirmContactsTypeModelsTypeItemNotesTypeAllNotesType AllNotes { get; set; }
    }

    public class SearchContactsResponseDataTypeSearchFirmContactsTypeModelsTypeItemNotesTypeAllNotesType
    {
        [JsonProperty("totalModels")]
        public int TotalModels { get; set; }

        [JsonProperty("models")]
        public JToken[] Models { get; set; }
    }

    public class SearchContactsResponseDataTypeSearchFirmContactsTypeModelsTypeItemListsType
    {
        [JsonProperty("totalModels")]
        public int TotalModels { get; set; }

        [JsonProperty("models")]
        public SearchContactsResponseDataTypeSearchFirmContactsTypeModelsTypeItemListsTypeModelsTypeItem[] Models { get; set; }
    }

    public class SearchContactsResponseDataTypeSearchFirmContactsTypeModelsTypeItemListsTypeModelsTypeItem
    {
        [JsonProperty("listId")]
        public string ListId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("listClass")]
        public string ListClass { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("userIsSponsor")]
        public bool UserIsSponsor { get; set; }

        [JsonProperty("allowedLinkInto")]
        public bool AllowedLinkInto { get; set; }

        [JsonProperty("allowedRemoveFrom")]
        public bool AllowedRemoveFrom { get; set; }

        [JsonProperty("ownerName")]
        public string OwnerName { get; set; }

        [JsonProperty("creatorName")]
        public string CreatorName { get; set; }

        [JsonProperty("sponsors")]
        public SearchContactsResponseDataTypeSearchFirmContactsTypeModelsTypeItemListsTypeModelsTypeItemSponsorsTypeItem[] Sponsors { get; set; }
    }

    public class SearchContactsResponseDataTypeSearchFirmContactsTypeModelsTypeItemListsTypeModelsTypeItemSponsorsTypeItem
    {
        [JsonProperty("sponsorId")]
        public string SponsorId { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("isPrimary")]
        public bool IsPrimary { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }
    }

    public class SearchContactsInput
    {
        [JsonProperty("query", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Query { get; set; } = "query MyQuery($filterField: ContactFilterField, $filterValue: String) {   searchFirmContacts(filter: {field: $filterField, value: $filterValue}) {     totalModels     models {       contactId: id       displayName       contactEntity       ... on Person {         contactId: id         displayName         title         firstName         middleName         lastName         currentJobTitle         currentEmployer {           companyName: name           companyId: id         }         addresses {           addressID: id           street           city           administrativeDivision           country           postalCode           type           usage         }       }       ... on Company {         contactId: id         name       }       visibility       emailAddresses {         emailId: id         type         usage         address         label         owningContactId         isGlobal       }       phoneNumbers {         phoneId: id         number         label         type         usage         owningContactId         isGlobal       }       activities {         totalModels         models {           activityId: id           type           typeId           activityClass           typeGroup           activityStartDate           lastEditedDate           subject           summary           location         }       }       notes {         allNotes {           totalModels           models {             changeDate             folderId             noteId             notes           }         }       }       lists(sort: {field: \"name\", direction: \"Ascending\"}) {         totalModels         models {           listId: id           name           listClass           description           type           userIsSponsor           allowedLinkInto           allowedRemoveFrom           ownerName           creatorName           sponsors {             sponsorId: id             displayName             isPrimary             fullName           }         }       }     }   } }";

        [JsonProperty("variables", DefaultValueHandling = DefaultValueHandling.Include)]
        public SearchContactsInputVariablesType Variables { get; set; }
    }

    public class SearchContactsInputVariablesType
    {
        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }
    }

    public class UpdateActivityResponse
    {
        [JsonProperty("data")]
        public UpdateActivityResponseDataType Data { get; set; }
    }

    public class UpdateActivityResponseDataType
    {
        [JsonProperty("updateActivity")]
        public UpdateActivityResponseDataTypeUpdateActivityType UpdateActivity { get; set; }
    }

    public class UpdateActivityResponseDataTypeUpdateActivityType
    {
        [JsonProperty("validationErrors")]
        public JToken[] ValidationErrors { get; set; }

        [JsonProperty("item")]
        public UpdateActivityResponseDataTypeUpdateActivityTypeItemType Item { get; set; }
    }

    public class UpdateActivityResponseDataTypeUpdateActivityTypeItemType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("typeId")]
        public string TypeId { get; set; }

        [JsonProperty("activityClass")]
        public string ActivityClass { get; set; }

        [JsonProperty("typeGroup")]
        public string TypeGroup { get; set; }

        [JsonProperty("activityStartDate")]
        public string ActivityStartDate { get; set; }

        [JsonProperty("lastEditedDate")]
        public string LastEditedDate { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("regarding")]
        public string Regarding { get; set; }
    }

    public class UpdateActivityInput
    {
        [JsonProperty("query", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Query { get; set; } = "mutation updateActivity($input: UpdateActivityInput!) {   updateActivity(input: $input) {     validationErrors {       propertyName       message     }     item {       id       type       typeId       activityClass       typeGroup       activityStartDate       lastEditedDate       subject       summary       location         regarding         }   } }";

        [JsonProperty("variables", DefaultValueHandling = DefaultValueHandling.Include)]
        public UpdateActivityInputVariablesType Variables { get; set; }
    }

    public class UpdateActivityInputVariablesType
    {
        [JsonProperty("input", DefaultValueHandling = DefaultValueHandling.Include)]
        public UpdateActivityInputVariablesTypeInputType Input { get; set; }
    }

    public class UpdateActivityInputVariablesTypeInputType
    {
        [JsonProperty("activityId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ActivityId { get; set; }

        [JsonProperty("typeId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TypeId { get; set; }

        [JsonProperty("activityDate")]
        public string ActivityDate { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("linkedEntityIds", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] LinkedEntityIds { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Interaction;

    public partial class WorkflowManagedActions
    {
        public InteractionActions Interaction(string connectionId) => new InteractionActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public InteractionTriggers Interaction(string connectionId) => new InteractionTriggers(connectionId);
    }
}