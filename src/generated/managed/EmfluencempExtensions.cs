//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Emfluencemp
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EmfluencempActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "emfluencemp")]
        public IBodyWorkflowAction<ContactsSearchSimpleResponse, ApiConnectionActionConfiguration> ContactsSearchSimple(Expression<Func<string>> email = null, Expression<Func<int>> groupId = null, Expression<Func<bool>> suppressed = null, Expression<Func<bool>> held = null, Expression<Func<int>> page = null, Expression<Func<sortFieldInput>> sortField = null, Expression<Func<sortDirectionInput>> sortDirection = null)
        {
            var __workflow_email = WorkflowExpression.Compile(email, nameof(email), required: false);
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: false);
            var __workflow_suppressed = WorkflowExpression.Compile(suppressed, nameof(suppressed), required: false);
            var __workflow_held = WorkflowExpression.Compile(held, nameof(held), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_sortField = WorkflowExpression.Compile(sortField, nameof(sortField), required: false);
            var __workflow_sortDirection = WorkflowExpression.Compile(sortDirection, nameof(sortDirection), required: false);
            return new DeferredBodyAction<ContactsSearchSimpleResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/contacts/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_email != null)
                    callPayload.Queries["email"] = ExpressionConverter.Convert(__workflow_email);
                if (__workflow_groupId != null)
                    callPayload.Queries["groupID"] = ExpressionConverter.Convert(__workflow_groupId);
                if (__workflow_suppressed != null)
                    callPayload.Queries["suppressed"] = ExpressionConverter.Convert(__workflow_suppressed);
                if (__workflow_held != null)
                    callPayload.Queries["held"] = ExpressionConverter.Convert(__workflow_held);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_sortField != null)
                    callPayload.Queries["sortField"] = ExpressionConverter.Convert(__workflow_sortField);
                if (__workflow_sortDirection != null)
                    callPayload.Queries["sortDirection"] = ExpressionConverter.Convert(__workflow_sortDirection);
                return new ApiConnectionAction<ContactsSearchSimpleResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "emfluencemp")]
        public IBodyWorkflowAction<ContactsSearchResponse, ApiConnectionActionConfiguration> ContactsSearch(Expression<Func<ContactsSearchInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ContactsSearchResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/contacts/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ContactsSearchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "emfluencemp")]
        public IBodyWorkflowAction<ContactsLookupResponse, ApiConnectionActionConfiguration> ContactsLookup(Expression<Func<string>> email)
        {
            var __workflow_email = WorkflowExpression.Compile(email, nameof(email), required: true);
            return new DeferredBodyAction<ContactsLookupResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/contacts/lookup";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["email"] = ExpressionConverter.Convert(__workflow_email);
                return new ApiConnectionAction<ContactsLookupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "emfluencemp")]
        public IBodyWorkflowAction<ContactsSaveResponse, ApiConnectionActionConfiguration> ContactsSave(Expression<Func<ContactsSaveInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ContactsSaveResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/contacts/save";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ContactsSaveResponse>(callPayload);
            });
        }
    }

    public class EmfluencempTriggers([ConnectionName] string connectionId)
    {
    }

    public class ContactsSearchSimpleResponse
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("success")]
        public int Success { get; set; }

        [JsonProperty("data")]
        public ContactsSearchSimpleResponseDataType Data { get; set; }
    }

    public class ContactsSearchSimpleResponseDataType
    {
        [JsonProperty("records")]
        public ContactsSearchSimpleResponseDataTypeRecordsTypeItem[] Records { get; set; }

        [JsonProperty("paging")]
        public ContactsSearchSimpleResponseDataTypePagingType Paging { get; set; }
    }

    public class ContactsSearchSimpleResponseDataTypeRecordsTypeItem
    {
        [JsonProperty("held")]
        public int Held { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("dateAdded")]
        public string DateAdded { get; set; }

        [JsonProperty("dateModified")]
        public string DateModified { get; set; }

        [JsonProperty("userID")]
        public int UserId { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("contactID")]
        public int ContactId { get; set; }

        [JsonProperty("suppressed")]
        public int Suppressed { get; set; }
    }

    public class ContactsSearchSimpleResponseDataTypePagingType
    {
        [JsonProperty("rpp")]
        public int Rpp { get; set; }

        [JsonProperty("totalPages")]
        public int TotalPages { get; set; }

        [JsonProperty("prev")]
        public string Prev { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("totalRecords")]
        public int TotalRecords { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum sortFieldInput
    {
        [EnumMember(Value = "contactID")]
        ContactId,
        [EnumMember(Value = "email")]
        Email,
        [EnumMember(Value = "dateModified")]
        DateModified,
        [EnumMember(Value = "contactScore")]
        ContactScore
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum sortDirectionInput
    {
        [EnumMember(Value = "asc")]
        Asc,
        [EnumMember(Value = "desc")]
        Desc
    }

    public class ContactsSearchResponse
    {
        [JsonProperty("success")]
        public int Success { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("data")]
        public ContactsSearchResponseDataType Data { get; set; }
    }

    public class ContactsSearchResponseDataType
    {
        [JsonProperty("paging")]
        public ContactsSearchResponseDataTypePagingType Paging { get; set; }

        [JsonProperty("records")]
        public ContactsSearchResponseDataTypeRecordsTypeItem[] Records { get; set; }
    }

    public class ContactsSearchResponseDataTypePagingType
    {
        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("rpp")]
        public int Rpp { get; set; }

        [JsonProperty("totalPages")]
        public int TotalPages { get; set; }

        [JsonProperty("totalRecords")]
        public int TotalRecords { get; set; }

        [JsonProperty("prev")]
        public string Prev { get; set; }
    }

    public class ContactsSearchResponseDataTypeRecordsTypeItem
    {
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("dateAdded")]
        public string DateAdded { get; set; }

        [JsonProperty("dateModified")]
        public string DateModified { get; set; }

        [JsonProperty("contactID")]
        public int ContactId { get; set; }

        [JsonProperty("suppressed")]
        public int Suppressed { get; set; }

        [JsonProperty("held")]
        public int Held { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("userID")]
        public int UserId { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }
    }

    public class ContactsSearchInput
    {
        [JsonProperty("groupID")]
        public int? GroupId { get; set; }

        [JsonProperty("suppressed")]
        public bool? Suppressed { get; set; }

        [JsonProperty("held")]
        public bool? Held { get; set; }

        [JsonProperty("contactIDs")]
        public JToken[] ContactIDs { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("userID")]
        public int? UserId { get; set; }

        [JsonProperty("customerID")]
        public string CustomerId { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("fax")]
        public string Fax { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zipCode")]
        public string ZipCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("purl")]
        public string Purl { get; set; }

        [JsonProperty("fields")]
        public string Fields { get; set; }

        [JsonProperty("page", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Page { get; set; } = 1;

        [JsonProperty("rpp")]
        public int? Rpp { get; set; }

        [JsonProperty("sortField")]
        public ContactsSearchInputSortFieldType? SortField { get; set; }

        [JsonProperty("sortDirection")]
        public ContactsSearchInputSortDirectionType? SortDirection { get; set; }

        [JsonProperty("_internal", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool Internal { get; set; } = true;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ContactsSearchInputSortFieldType
    {
        [EnumMember(Value = "contactID")]
        ContactId,
        [EnumMember(Value = "email")]
        Email,
        [EnumMember(Value = "dateModified")]
        DateModified,
        [EnumMember(Value = "contactScore")]
        ContactScore
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ContactsSearchInputSortDirectionType
    {
        [EnumMember(Value = "asc")]
        Asc,
        [EnumMember(Value = "desc")]
        Desc
    }

    public class ContactsLookupResponse
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("success")]
        public int Success { get; set; }

        [JsonProperty("data")]
        public ContactsLookupResponseDataType Data { get; set; }
    }

    public class ContactsLookupResponseDataType
    {
        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("ipAddress")]
        public string IpAddress { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("contactID")]
        public int ContactId { get; set; }

        [JsonProperty("groupIDs")]
        public JToken[] GroupIDs { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("customerID")]
        public string CustomerId { get; set; }

        [JsonProperty("dateSuppressed")]
        public string DateSuppressed { get; set; }

        [JsonProperty("held")]
        public int Held { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("userID")]
        public int UserId { get; set; }

        [JsonProperty("purl")]
        public string Purl { get; set; }

        [JsonProperty("address1")]
        public string Address1 { get; set; }

        [JsonProperty("memo")]
        public string Memo { get; set; }

        [JsonProperty("address2")]
        public string Address2 { get; set; }

        [JsonProperty("originalSource")]
        public string OriginalSource { get; set; }

        [JsonProperty("dateAdded")]
        public string DateAdded { get; set; }

        [JsonProperty("zipCode")]
        public string ZipCode { get; set; }

        [JsonProperty("dateHeld")]
        public string DateHeld { get; set; }

        [JsonProperty("suppressed")]
        public int Suppressed { get; set; }

        [JsonProperty("contactScore")]
        public ContactsLookupResponseDataTypeContactScoreType ContactScore { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("dateOfBirth")]
        public string DateOfBirth { get; set; }

        [JsonProperty("dateModified")]
        public string DateModified { get; set; }

        [JsonProperty("lastActivityDate")]
        public string LastActivityDate { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("fax")]
        public string Fax { get; set; }

        [JsonProperty("lastClickDate")]
        public string LastClickDate { get; set; }
    }

    public class ContactsLookupResponseDataTypeContactScoreType
    {
        [JsonProperty("dateModified")]
        public string DateModified { get; set; }

        [JsonProperty("percentile")]
        public string Percentile { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }
    }

    public class ContactsSaveResponse
    {
        [JsonProperty("success")]
        public int Success { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("data")]
        public ContactsSaveResponseDataType Data { get; set; }
    }

    public class ContactsSaveResponseDataType
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("contactID")]
        public int ContactId { get; set; }

        [JsonProperty("groupIDs")]
        public JToken[] GroupIDs { get; set; }
    }

    public class ContactsSaveInput
    {
        [JsonProperty("contactID")]
        public int? ContactId { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("userID")]
        public int? UserId { get; set; }

        [JsonProperty("customerID")]
        public string CustomerId { get; set; }

        [JsonProperty("suppressed")]
        public bool? Suppressed { get; set; }

        [JsonProperty("held")]
        public bool? Held { get; set; }

        [JsonProperty("originalSource")]
        public string OriginalSource { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("fax")]
        public string Fax { get; set; }

        [JsonProperty("address1")]
        public string Address1 { get; set; }

        [JsonProperty("address2")]
        public string Address2 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zipCode")]
        public string ZipCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("purl")]
        public string Purl { get; set; }

        [JsonProperty("dateOfBirth")]
        public string DateOfBirth { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("memo")]
        public string Memo { get; set; }

        [JsonProperty("customFields")]
        public JToken CustomFields { get; set; }

        [JsonProperty("contentVariables")]
        public JToken ContentVariables { get; set; }

        [JsonProperty("groupIDs")]
        public int[] GroupIDs { get; set; }

        [JsonProperty("removeGroupIDs")]
        public int[] RemoveGroupIDs { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Emfluencemp;

    public partial class WorkflowManagedActions
    {
        public EmfluencempActions Emfluencemp(string connectionId) => new EmfluencempActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public EmfluencempTriggers Emfluencemp(string connectionId) => new EmfluencempTriggers(connectionId);
    }
}