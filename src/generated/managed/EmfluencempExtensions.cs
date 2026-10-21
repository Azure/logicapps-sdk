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
        public IBodyWorkflowAction<ContactsSearchSimpleResponse> ContactsSearchSimple(Expression<Func<string>> email = null, Expression<Func<int>> groupID = null, Expression<Func<bool>> suppressed = null, Expression<Func<bool>> held = null, Expression<Func<int>> page = null, Expression<Func<sortFieldInput>> sortField = null, Expression<Func<sortDirectionInput>> sortDirection = null)
        {
            var __workflow_email = WorkflowExpression.Compile(email, nameof(email), required: false);
            var __workflow_groupID = WorkflowExpression.Compile(groupID, nameof(groupID), required: false);
            var __workflow_suppressed = WorkflowExpression.Compile(suppressed, nameof(suppressed), required: false);
            var __workflow_held = WorkflowExpression.Compile(held, nameof(held), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_sortField = WorkflowExpression.Compile(sortField, nameof(sortField), required: false);
            var __workflow_sortDirection = WorkflowExpression.Compile(sortDirection, nameof(sortDirection), required: false);
            return new DeferredBodyAction<ContactsSearchSimpleResponse>(() =>
            {
                var apiCallPath = "/contacts/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_email != null)
                    callPayload.Queries["email"] = ExpressionConverter.Convert(__workflow_email);
                if (__workflow_groupID != null)
                    callPayload.Queries["groupID"] = ExpressionConverter.Convert(__workflow_groupID);
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
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "emfluencemp")]
        public IBodyWorkflowAction<ContactsSearchResponse> ContactsSearch(Expression<Func<int>> bodygroupID = null, Expression<Func<bool>> bodysuppressed = null, Expression<Func<bool>> bodyheld = null, Expression<Func<JToken[]>> bodycontactIDs = null, Expression<Func<string>> bodyemail = null, Expression<Func<int>> bodyuserID = null, Expression<Func<string>> bodycustomerID = null, Expression<Func<string>> bodycompany = null, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodyphone = null, Expression<Func<string>> bodyfax = null, Expression<Func<string>> bodycity = null, Expression<Func<string>> bodystate = null, Expression<Func<string>> bodyzipCode = null, Expression<Func<string>> bodycountry = null, Expression<Func<string>> bodypurl = null, Expression<Func<string>> bodyfields = null, Expression<Func<int>> bodypage = null, Expression<Func<int>> bodyrpp = null, Expression<Func<bodysortFieldInput>> bodysortField = null, Expression<Func<bodysortDirectionInput>> bodysortDirection = null)
        {
            var __workflow_bodygroupID = WorkflowExpression.Compile(bodygroupID, nameof(bodygroupID), required: false);
            var __workflow_bodysuppressed = WorkflowExpression.Compile(bodysuppressed, nameof(bodysuppressed), required: false);
            var __workflow_bodyheld = WorkflowExpression.Compile(bodyheld, nameof(bodyheld), required: false);
            var __workflow_bodycontactIDs = WorkflowExpression.Compile(bodycontactIDs, nameof(bodycontactIDs), required: false);
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: false);
            var __workflow_bodyuserID = WorkflowExpression.Compile(bodyuserID, nameof(bodyuserID), required: false);
            var __workflow_bodycustomerID = WorkflowExpression.Compile(bodycustomerID, nameof(bodycustomerID), required: false);
            var __workflow_bodycompany = WorkflowExpression.Compile(bodycompany, nameof(bodycompany), required: false);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: false);
            var __workflow_bodyphone = WorkflowExpression.Compile(bodyphone, nameof(bodyphone), required: false);
            var __workflow_bodyfax = WorkflowExpression.Compile(bodyfax, nameof(bodyfax), required: false);
            var __workflow_bodycity = WorkflowExpression.Compile(bodycity, nameof(bodycity), required: false);
            var __workflow_bodystate = WorkflowExpression.Compile(bodystate, nameof(bodystate), required: false);
            var __workflow_bodyzipCode = WorkflowExpression.Compile(bodyzipCode, nameof(bodyzipCode), required: false);
            var __workflow_bodycountry = WorkflowExpression.Compile(bodycountry, nameof(bodycountry), required: false);
            var __workflow_bodypurl = WorkflowExpression.Compile(bodypurl, nameof(bodypurl), required: false);
            var __workflow_bodyfields = WorkflowExpression.Compile(bodyfields, nameof(bodyfields), required: false);
            var __workflow_bodypage = WorkflowExpression.Compile(bodypage, nameof(bodypage), required: false);
            var __workflow_bodyrpp = WorkflowExpression.Compile(bodyrpp, nameof(bodyrpp), required: false);
            var __workflow_bodysortField = WorkflowExpression.Compile(bodysortField, nameof(bodysortField), required: false);
            var __workflow_bodysortDirection = WorkflowExpression.Compile(bodysortDirection, nameof(bodysortDirection), required: false);
            return new DeferredBodyAction<ContactsSearchResponse>(() =>
            {
                var apiCallPath = "/contacts/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodygroupID != null)
                {
                    body["groupID"] = ExpressionConverter.ConvertO(__workflow_bodygroupID);
                    bodypropCount++;
                }

                if (__workflow_bodysuppressed != null)
                {
                    body["suppressed"] = ExpressionConverter.ConvertO(__workflow_bodysuppressed);
                    bodypropCount++;
                }

                if (__workflow_bodyheld != null)
                {
                    body["held"] = ExpressionConverter.ConvertO(__workflow_bodyheld);
                    bodypropCount++;
                }

                if (__workflow_bodycontactIDs != null)
                {
                    body["contactIDs"] = ExpressionConverter.ConvertO(__workflow_bodycontactIDs);
                    bodypropCount++;
                }

                if (__workflow_bodyemail != null)
                {
                    body["email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                    bodypropCount++;
                }

                if (__workflow_bodyuserID != null)
                {
                    body["userID"] = ExpressionConverter.ConvertO(__workflow_bodyuserID);
                    bodypropCount++;
                }

                if (__workflow_bodycustomerID != null)
                {
                    body["customerID"] = ExpressionConverter.ConvertO(__workflow_bodycustomerID);
                    bodypropCount++;
                }

                if (__workflow_bodycompany != null)
                {
                    body["company"] = ExpressionConverter.ConvertO(__workflow_bodycompany);
                    bodypropCount++;
                }

                if (__workflow_bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (__workflow_bodyphone != null)
                {
                    body["phone"] = ExpressionConverter.ConvertO(__workflow_bodyphone);
                    bodypropCount++;
                }

                if (__workflow_bodyfax != null)
                {
                    body["fax"] = ExpressionConverter.ConvertO(__workflow_bodyfax);
                    bodypropCount++;
                }

                if (__workflow_bodycity != null)
                {
                    body["city"] = ExpressionConverter.ConvertO(__workflow_bodycity);
                    bodypropCount++;
                }

                if (__workflow_bodystate != null)
                {
                    body["state"] = ExpressionConverter.ConvertO(__workflow_bodystate);
                    bodypropCount++;
                }

                if (__workflow_bodyzipCode != null)
                {
                    body["zipCode"] = ExpressionConverter.ConvertO(__workflow_bodyzipCode);
                    bodypropCount++;
                }

                if (__workflow_bodycountry != null)
                {
                    body["country"] = ExpressionConverter.ConvertO(__workflow_bodycountry);
                    bodypropCount++;
                }

                if (__workflow_bodypurl != null)
                {
                    body["purl"] = ExpressionConverter.ConvertO(__workflow_bodypurl);
                    bodypropCount++;
                }

                if (__workflow_bodyfields != null)
                {
                    body["fields"] = ExpressionConverter.ConvertO(__workflow_bodyfields);
                    bodypropCount++;
                }

                if (__workflow_bodypage != null)
                {
                    if (__workflow_bodypage != null)
                    {
                        body["page"] = ExpressionConverter.ConvertO(__workflow_bodypage);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["page"] = 1;
                    bodypropCount++;
                }

                if (__workflow_bodyrpp != null)
                {
                    body["rpp"] = ExpressionConverter.ConvertO(__workflow_bodyrpp);
                    bodypropCount++;
                }

                if (__workflow_bodysortField != null)
                {
                    body["sortField"] = ExpressionConverter.ConvertO(__workflow_bodysortField);
                    bodypropCount++;
                }

                if (__workflow_bodysortDirection != null)
                {
                    body["sortDirection"] = ExpressionConverter.ConvertO(__workflow_bodysortDirection);
                    bodypropCount++;
                }

                body["_internal"] = true;
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ContactsSearchResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "emfluencemp")]
        public IBodyWorkflowAction<ContactsLookupResponse> ContactsLookup(Expression<Func<string>> email)
        {
            var __workflow_email = WorkflowExpression.Compile(email, nameof(email), required: true);
            return new DeferredBodyAction<ContactsLookupResponse>(() =>
            {
                var apiCallPath = "/contacts/lookup";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["email"] = ExpressionConverter.Convert(__workflow_email);
                return new ApiConnectionAction<ContactsLookupResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "emfluencemp")]
        public IBodyWorkflowAction<ContactsSaveResponse> ContactsSave(Expression<Func<int>> bodycontactID = null, Expression<Func<string>> bodyemail = null, Expression<Func<int>> bodyuserID = null, Expression<Func<string>> bodycustomerID = null, Expression<Func<bool>> bodysuppressed = null, Expression<Func<bool>> bodyheld = null, Expression<Func<string>> bodyoriginalSource = null, Expression<Func<string>> bodyfirstName = null, Expression<Func<string>> bodylastName = null, Expression<Func<string>> bodycompany = null, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodyphone = null, Expression<Func<string>> bodyfax = null, Expression<Func<string>> bodyaddress1 = null, Expression<Func<string>> bodyaddress2 = null, Expression<Func<string>> bodycity = null, Expression<Func<string>> bodystate = null, Expression<Func<string>> bodyzipCode = null, Expression<Func<string>> bodycountry = null, Expression<Func<string>> bodypurl = null, Expression<Func<string>> bodydateOfBirth = null, Expression<Func<string>> bodynotes = null, Expression<Func<string>> bodymemo = null, Expression<Func<int[]>> bodygroupIDs = null, Expression<Func<int[]>> bodyremoveGroupIDs = null)
        {
            var __workflow_bodycontactID = WorkflowExpression.Compile(bodycontactID, nameof(bodycontactID), required: false);
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: false);
            var __workflow_bodyuserID = WorkflowExpression.Compile(bodyuserID, nameof(bodyuserID), required: false);
            var __workflow_bodycustomerID = WorkflowExpression.Compile(bodycustomerID, nameof(bodycustomerID), required: false);
            var __workflow_bodysuppressed = WorkflowExpression.Compile(bodysuppressed, nameof(bodysuppressed), required: false);
            var __workflow_bodyheld = WorkflowExpression.Compile(bodyheld, nameof(bodyheld), required: false);
            var __workflow_bodyoriginalSource = WorkflowExpression.Compile(bodyoriginalSource, nameof(bodyoriginalSource), required: false);
            var __workflow_bodyfirstName = WorkflowExpression.Compile(bodyfirstName, nameof(bodyfirstName), required: false);
            var __workflow_bodylastName = WorkflowExpression.Compile(bodylastName, nameof(bodylastName), required: false);
            var __workflow_bodycompany = WorkflowExpression.Compile(bodycompany, nameof(bodycompany), required: false);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: false);
            var __workflow_bodyphone = WorkflowExpression.Compile(bodyphone, nameof(bodyphone), required: false);
            var __workflow_bodyfax = WorkflowExpression.Compile(bodyfax, nameof(bodyfax), required: false);
            var __workflow_bodyaddress1 = WorkflowExpression.Compile(bodyaddress1, nameof(bodyaddress1), required: false);
            var __workflow_bodyaddress2 = WorkflowExpression.Compile(bodyaddress2, nameof(bodyaddress2), required: false);
            var __workflow_bodycity = WorkflowExpression.Compile(bodycity, nameof(bodycity), required: false);
            var __workflow_bodystate = WorkflowExpression.Compile(bodystate, nameof(bodystate), required: false);
            var __workflow_bodyzipCode = WorkflowExpression.Compile(bodyzipCode, nameof(bodyzipCode), required: false);
            var __workflow_bodycountry = WorkflowExpression.Compile(bodycountry, nameof(bodycountry), required: false);
            var __workflow_bodypurl = WorkflowExpression.Compile(bodypurl, nameof(bodypurl), required: false);
            var __workflow_bodydateOfBirth = WorkflowExpression.Compile(bodydateOfBirth, nameof(bodydateOfBirth), required: false);
            var __workflow_bodynotes = WorkflowExpression.Compile(bodynotes, nameof(bodynotes), required: false);
            var __workflow_bodymemo = WorkflowExpression.Compile(bodymemo, nameof(bodymemo), required: false);
            var __workflow_bodygroupIDs = WorkflowExpression.Compile(bodygroupIDs, nameof(bodygroupIDs), required: false);
            var __workflow_bodyremoveGroupIDs = WorkflowExpression.Compile(bodyremoveGroupIDs, nameof(bodyremoveGroupIDs), required: false);
            return new DeferredBodyAction<ContactsSaveResponse>(() =>
            {
                var apiCallPath = "/contacts/save";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodycontactID != null)
                {
                    body["contactID"] = ExpressionConverter.ConvertO(__workflow_bodycontactID);
                    bodypropCount++;
                }

                if (__workflow_bodyemail != null)
                {
                    body["email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                    bodypropCount++;
                }

                if (__workflow_bodyuserID != null)
                {
                    body["userID"] = ExpressionConverter.ConvertO(__workflow_bodyuserID);
                    bodypropCount++;
                }

                if (__workflow_bodycustomerID != null)
                {
                    body["customerID"] = ExpressionConverter.ConvertO(__workflow_bodycustomerID);
                    bodypropCount++;
                }

                if (__workflow_bodysuppressed != null)
                {
                    body["suppressed"] = ExpressionConverter.ConvertO(__workflow_bodysuppressed);
                    bodypropCount++;
                }

                if (__workflow_bodyheld != null)
                {
                    body["held"] = ExpressionConverter.ConvertO(__workflow_bodyheld);
                    bodypropCount++;
                }

                if (__workflow_bodyoriginalSource != null)
                {
                    body["originalSource"] = ExpressionConverter.ConvertO(__workflow_bodyoriginalSource);
                    bodypropCount++;
                }

                if (__workflow_bodyfirstName != null)
                {
                    body["firstName"] = ExpressionConverter.ConvertO(__workflow_bodyfirstName);
                    bodypropCount++;
                }

                if (__workflow_bodylastName != null)
                {
                    body["lastName"] = ExpressionConverter.ConvertO(__workflow_bodylastName);
                    bodypropCount++;
                }

                if (__workflow_bodycompany != null)
                {
                    body["company"] = ExpressionConverter.ConvertO(__workflow_bodycompany);
                    bodypropCount++;
                }

                if (__workflow_bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (__workflow_bodyphone != null)
                {
                    body["phone"] = ExpressionConverter.ConvertO(__workflow_bodyphone);
                    bodypropCount++;
                }

                if (__workflow_bodyfax != null)
                {
                    body["fax"] = ExpressionConverter.ConvertO(__workflow_bodyfax);
                    bodypropCount++;
                }

                if (__workflow_bodyaddress1 != null)
                {
                    body["address1"] = ExpressionConverter.ConvertO(__workflow_bodyaddress1);
                    bodypropCount++;
                }

                if (__workflow_bodyaddress2 != null)
                {
                    body["address2"] = ExpressionConverter.ConvertO(__workflow_bodyaddress2);
                    bodypropCount++;
                }

                if (__workflow_bodycity != null)
                {
                    body["city"] = ExpressionConverter.ConvertO(__workflow_bodycity);
                    bodypropCount++;
                }

                if (__workflow_bodystate != null)
                {
                    body["state"] = ExpressionConverter.ConvertO(__workflow_bodystate);
                    bodypropCount++;
                }

                if (__workflow_bodyzipCode != null)
                {
                    body["zipCode"] = ExpressionConverter.ConvertO(__workflow_bodyzipCode);
                    bodypropCount++;
                }

                if (__workflow_bodycountry != null)
                {
                    body["country"] = ExpressionConverter.ConvertO(__workflow_bodycountry);
                    bodypropCount++;
                }

                if (__workflow_bodypurl != null)
                {
                    body["purl"] = ExpressionConverter.ConvertO(__workflow_bodypurl);
                    bodypropCount++;
                }

                if (__workflow_bodydateOfBirth != null)
                {
                    body["dateOfBirth"] = ExpressionConverter.ConvertO(__workflow_bodydateOfBirth);
                    bodypropCount++;
                }

                if (__workflow_bodynotes != null)
                {
                    body["notes"] = ExpressionConverter.ConvertO(__workflow_bodynotes);
                    bodypropCount++;
                }

                if (__workflow_bodymemo != null)
                {
                    body["memo"] = ExpressionConverter.ConvertO(__workflow_bodymemo);
                    bodypropCount++;
                }

                var customFieldsObject = new JObject();
                var customFieldsObjectpropCount = 0;
                if (customFieldsObjectpropCount > 0)
                {
                    body["customFields"] = customFieldsObject;
                    bodypropCount++;
                }

                var contentVariablesObject = new JObject();
                var contentVariablesObjectpropCount = 0;
                if (contentVariablesObjectpropCount > 0)
                {
                    body["contentVariables"] = contentVariablesObject;
                    bodypropCount++;
                }

                if (__workflow_bodygroupIDs != null)
                {
                    body["groupIDs"] = ExpressionConverter.ConvertO(__workflow_bodygroupIDs);
                    bodypropCount++;
                }

                if (__workflow_bodyremoveGroupIDs != null)
                {
                    body["removeGroupIDs"] = ExpressionConverter.ConvertO(__workflow_bodyremoveGroupIDs);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ContactsSaveResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
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
        public int UserID { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("contactID")]
        public int ContactID { get; set; }

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
        ContactID,
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
        public int ContactID { get; set; }

        [JsonProperty("suppressed")]
        public int Suppressed { get; set; }

        [JsonProperty("held")]
        public int Held { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("userID")]
        public int UserID { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodysortFieldInput
    {
        [EnumMember(Value = "contactID")]
        ContactID,
        [EnumMember(Value = "email")]
        Email,
        [EnumMember(Value = "dateModified")]
        DateModified,
        [EnumMember(Value = "contactScore")]
        ContactScore
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodysortDirectionInput
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
        public int ContactID { get; set; }

        [JsonProperty("groupIDs")]
        public JToken[] GroupIDs { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("customerID")]
        public string CustomerID { get; set; }

        [JsonProperty("dateSuppressed")]
        public string DateSuppressed { get; set; }

        [JsonProperty("held")]
        public int Held { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("userID")]
        public int UserID { get; set; }

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
        public int ContactID { get; set; }

        [JsonProperty("groupIDs")]
        public JToken[] GroupIDs { get; set; }
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
