//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Emfluencemp
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EmfluencempActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "emfluencemp")]
        public IBodyWorkflowAction<ContactsSearchSimpleResponse> ContactsSearchSimple(Expression<Func<string>> email = null, Expression<Func<int>> groupID = null, Expression<Func<bool>> suppressed = null, Expression<Func<bool>> held = null, Expression<Func<int>> page = null, Expression<Func<sortFieldInput>> sortField = null, Expression<Func<sortDirectionInput>> sortDirection = null)
        {
            var apiCallPath = "/contacts/search";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (email != null)
                callPayload.Queries["email"] = CSharpExpressionConverter.ConvertO(email);
            if (groupID != null)
                callPayload.Queries["groupID"] = CSharpExpressionConverter.ConvertO(groupID);
            if (suppressed != null)
                callPayload.Queries["suppressed"] = CSharpExpressionConverter.ConvertO(suppressed);
            if (held != null)
                callPayload.Queries["held"] = CSharpExpressionConverter.ConvertO(held);
            if (page != null)
                callPayload.Queries["page"] = CSharpExpressionConverter.ConvertO(page);
            if (sortField != null)
                callPayload.Queries["sortField"] = CSharpExpressionConverter.Convert(sortField);
            if (sortDirection != null)
                callPayload.Queries["sortDirection"] = CSharpExpressionConverter.Convert(sortDirection);
            return new ApiConnectionAction<ContactsSearchSimpleResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "emfluencemp")]
        public IBodyWorkflowAction<ContactsSearchResponse> ContactsSearch(Expression<Func<int>> bodygroupID = null, Expression<Func<bool>> bodysuppressed = null, Expression<Func<bool>> bodyheld = null, Expression<Func<JToken[]>> bodycontactIDs = null, Expression<Func<string>> bodyemail = null, Expression<Func<int>> bodyuserID = null, Expression<Func<string>> bodycustomerID = null, Expression<Func<string>> bodycompany = null, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodyphone = null, Expression<Func<string>> bodyfax = null, Expression<Func<string>> bodycity = null, Expression<Func<string>> bodystate = null, Expression<Func<string>> bodyzipCode = null, Expression<Func<string>> bodycountry = null, Expression<Func<string>> bodypurl = null, Expression<Func<string>> bodyfields = null, Expression<Func<int>> bodypage = null, Expression<Func<int>> bodyrpp = null, Expression<Func<bodysortFieldInput>> bodysortField = null, Expression<Func<bodysortDirectionInput>> bodysortDirection = null)
        {
            var apiCallPath = "/contacts/search";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodygroupID != null)
            {
                body["groupID"] = CSharpExpressionConverter.ConvertToken(bodygroupID);
                bodypropCount++;
            }

            if (bodysuppressed != null)
            {
                body["suppressed"] = CSharpExpressionConverter.ConvertToken(bodysuppressed);
                bodypropCount++;
            }

            if (bodyheld != null)
            {
                body["held"] = CSharpExpressionConverter.ConvertToken(bodyheld);
                bodypropCount++;
            }

            if (bodycontactIDs != null)
            {
                body["contactIDs"] = CSharpExpressionConverter.ConvertToken(bodycontactIDs);
                bodypropCount++;
            }

            if (bodyemail != null)
            {
                body["email"] = CSharpExpressionConverter.ConvertToken(bodyemail);
                bodypropCount++;
            }

            if (bodyuserID != null)
            {
                body["userID"] = CSharpExpressionConverter.ConvertToken(bodyuserID);
                bodypropCount++;
            }

            if (bodycustomerID != null)
            {
                body["customerID"] = CSharpExpressionConverter.ConvertToken(bodycustomerID);
                bodypropCount++;
            }

            if (bodycompany != null)
            {
                body["company"] = CSharpExpressionConverter.ConvertToken(bodycompany);
                bodypropCount++;
            }

            if (bodytitle != null)
            {
                body["title"] = CSharpExpressionConverter.ConvertToken(bodytitle);
                bodypropCount++;
            }

            if (bodyphone != null)
            {
                body["phone"] = CSharpExpressionConverter.ConvertToken(bodyphone);
                bodypropCount++;
            }

            if (bodyfax != null)
            {
                body["fax"] = CSharpExpressionConverter.ConvertToken(bodyfax);
                bodypropCount++;
            }

            if (bodycity != null)
            {
                body["city"] = CSharpExpressionConverter.ConvertToken(bodycity);
                bodypropCount++;
            }

            if (bodystate != null)
            {
                body["state"] = CSharpExpressionConverter.ConvertToken(bodystate);
                bodypropCount++;
            }

            if (bodyzipCode != null)
            {
                body["zipCode"] = CSharpExpressionConverter.ConvertToken(bodyzipCode);
                bodypropCount++;
            }

            if (bodycountry != null)
            {
                body["country"] = CSharpExpressionConverter.ConvertToken(bodycountry);
                bodypropCount++;
            }

            if (bodypurl != null)
            {
                body["purl"] = CSharpExpressionConverter.ConvertToken(bodypurl);
                bodypropCount++;
            }

            if (bodyfields != null)
            {
                body["fields"] = CSharpExpressionConverter.ConvertToken(bodyfields);
                bodypropCount++;
            }

            if (bodypage != null)
            {
                if (bodypage != null)
                {
                    body["page"] = CSharpExpressionConverter.ConvertToken(bodypage);
                    bodypropCount++;
                }

                bodypropCount++;
            }
            else
            {
                body["page"] = 1;
                bodypropCount++;
            }

            if (bodyrpp != null)
            {
                body["rpp"] = CSharpExpressionConverter.ConvertToken(bodyrpp);
                bodypropCount++;
            }

            if (bodysortField != null)
            {
                body["sortField"] = CSharpExpressionConverter.Convert(bodysortField);
                bodypropCount++;
            }

            if (bodysortDirection != null)
            {
                body["sortDirection"] = CSharpExpressionConverter.Convert(bodysortDirection);
                bodypropCount++;
            }

            body["_internal"] = true;
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ContactsSearchResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "emfluencemp")]
        public IBodyWorkflowAction<ContactsLookupResponse> ContactsLookup(Expression<Func<string>> email)
        {
            var apiCallPath = "/contacts/lookup";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["email"] = CSharpExpressionConverter.ConvertO(email);
            return new ApiConnectionAction<ContactsLookupResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "emfluencemp")]
        public IBodyWorkflowAction<ContactsSaveResponse> ContactsSave(Expression<Func<int>> bodycontactID = null, Expression<Func<string>> bodyemail = null, Expression<Func<int>> bodyuserID = null, Expression<Func<string>> bodycustomerID = null, Expression<Func<bool>> bodysuppressed = null, Expression<Func<bool>> bodyheld = null, Expression<Func<string>> bodyoriginalSource = null, Expression<Func<string>> bodyfirstName = null, Expression<Func<string>> bodylastName = null, Expression<Func<string>> bodycompany = null, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodyphone = null, Expression<Func<string>> bodyfax = null, Expression<Func<string>> bodyaddress1 = null, Expression<Func<string>> bodyaddress2 = null, Expression<Func<string>> bodycity = null, Expression<Func<string>> bodystate = null, Expression<Func<string>> bodyzipCode = null, Expression<Func<string>> bodycountry = null, Expression<Func<string>> bodypurl = null, Expression<Func<string>> bodydateOfBirth = null, Expression<Func<string>> bodynotes = null, Expression<Func<string>> bodymemo = null, Expression<Func<int[]>> bodygroupIDs = null, Expression<Func<int[]>> bodyremoveGroupIDs = null)
        {
            var apiCallPath = "/contacts/save";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodycontactID != null)
            {
                body["contactID"] = CSharpExpressionConverter.ConvertToken(bodycontactID);
                bodypropCount++;
            }

            if (bodyemail != null)
            {
                body["email"] = CSharpExpressionConverter.ConvertToken(bodyemail);
                bodypropCount++;
            }

            if (bodyuserID != null)
            {
                body["userID"] = CSharpExpressionConverter.ConvertToken(bodyuserID);
                bodypropCount++;
            }

            if (bodycustomerID != null)
            {
                body["customerID"] = CSharpExpressionConverter.ConvertToken(bodycustomerID);
                bodypropCount++;
            }

            if (bodysuppressed != null)
            {
                body["suppressed"] = CSharpExpressionConverter.ConvertToken(bodysuppressed);
                bodypropCount++;
            }

            if (bodyheld != null)
            {
                body["held"] = CSharpExpressionConverter.ConvertToken(bodyheld);
                bodypropCount++;
            }

            if (bodyoriginalSource != null)
            {
                body["originalSource"] = CSharpExpressionConverter.ConvertToken(bodyoriginalSource);
                bodypropCount++;
            }

            if (bodyfirstName != null)
            {
                body["firstName"] = CSharpExpressionConverter.ConvertToken(bodyfirstName);
                bodypropCount++;
            }

            if (bodylastName != null)
            {
                body["lastName"] = CSharpExpressionConverter.ConvertToken(bodylastName);
                bodypropCount++;
            }

            if (bodycompany != null)
            {
                body["company"] = CSharpExpressionConverter.ConvertToken(bodycompany);
                bodypropCount++;
            }

            if (bodytitle != null)
            {
                body["title"] = CSharpExpressionConverter.ConvertToken(bodytitle);
                bodypropCount++;
            }

            if (bodyphone != null)
            {
                body["phone"] = CSharpExpressionConverter.ConvertToken(bodyphone);
                bodypropCount++;
            }

            if (bodyfax != null)
            {
                body["fax"] = CSharpExpressionConverter.ConvertToken(bodyfax);
                bodypropCount++;
            }

            if (bodyaddress1 != null)
            {
                body["address1"] = CSharpExpressionConverter.ConvertToken(bodyaddress1);
                bodypropCount++;
            }

            if (bodyaddress2 != null)
            {
                body["address2"] = CSharpExpressionConverter.ConvertToken(bodyaddress2);
                bodypropCount++;
            }

            if (bodycity != null)
            {
                body["city"] = CSharpExpressionConverter.ConvertToken(bodycity);
                bodypropCount++;
            }

            if (bodystate != null)
            {
                body["state"] = CSharpExpressionConverter.ConvertToken(bodystate);
                bodypropCount++;
            }

            if (bodyzipCode != null)
            {
                body["zipCode"] = CSharpExpressionConverter.ConvertToken(bodyzipCode);
                bodypropCount++;
            }

            if (bodycountry != null)
            {
                body["country"] = CSharpExpressionConverter.ConvertToken(bodycountry);
                bodypropCount++;
            }

            if (bodypurl != null)
            {
                body["purl"] = CSharpExpressionConverter.ConvertToken(bodypurl);
                bodypropCount++;
            }

            if (bodydateOfBirth != null)
            {
                body["dateOfBirth"] = CSharpExpressionConverter.ConvertToken(bodydateOfBirth);
                bodypropCount++;
            }

            if (bodynotes != null)
            {
                body["notes"] = CSharpExpressionConverter.ConvertToken(bodynotes);
                bodypropCount++;
            }

            if (bodymemo != null)
            {
                body["memo"] = CSharpExpressionConverter.ConvertToken(bodymemo);
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

            if (bodygroupIDs != null)
            {
                body["groupIDs"] = CSharpExpressionConverter.ConvertToken(bodygroupIDs);
                bodypropCount++;
            }

            if (bodyremoveGroupIDs != null)
            {
                body["removeGroupIDs"] = CSharpExpressionConverter.ConvertToken(bodyremoveGroupIDs);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ContactsSaveResponse>(callPayload);
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