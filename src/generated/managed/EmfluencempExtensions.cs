//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Emfluencemp
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EmfluencempActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "emfluencemp")]
        [WorkflowExpressionFactory(nameof(__BuildContactsSearchSimple))]
        public IBodyWorkflowAction<ContactsSearchSimpleResponse> ContactsSearchSimple([WorkflowExpression] Func<string> email = null, [WorkflowExpression] Func<int> groupID = null, [WorkflowExpression] Func<bool> suppressed = null, [WorkflowExpression] Func<bool> held = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<sortFieldInput> sortField = null, [WorkflowExpression] Func<sortDirectionInput> sortDirection = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "emfluencemp")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ContactsSearchSimpleResponse> __BuildContactsSearchSimple(WorkflowExpression<string> email = null, WorkflowExpression<int> groupID = null, WorkflowExpression<bool> suppressed = null, WorkflowExpression<bool> held = null, WorkflowExpression<int> page = null, WorkflowExpression<sortFieldInput> sortField = null, WorkflowExpression<sortDirectionInput> sortDirection = null)
        {
            WorkflowExpression.Validate(email, nameof(email), required: false);
            WorkflowExpression.Validate(groupID, nameof(groupID), required: false);
            WorkflowExpression.Validate(suppressed, nameof(suppressed), required: false);
            WorkflowExpression.Validate(held, nameof(held), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(sortField, nameof(sortField), required: false);
            WorkflowExpression.Validate(sortDirection, nameof(sortDirection), required: false);
            return new DeferredBodyAction<ContactsSearchSimpleResponse>(() =>
            {
                var apiCallPath = "/contacts/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (email != null)
                    callPayload.Queries["email"] = ExpressionConverter.Convert(email);
                if (groupID != null)
                    callPayload.Queries["groupID"] = ExpressionConverter.Convert(groupID);
                if (suppressed != null)
                    callPayload.Queries["suppressed"] = ExpressionConverter.Convert(suppressed);
                if (held != null)
                    callPayload.Queries["held"] = ExpressionConverter.Convert(held);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (sortField != null)
                    callPayload.Queries["sortField"] = ExpressionConverter.Convert(sortField);
                if (sortDirection != null)
                    callPayload.Queries["sortDirection"] = ExpressionConverter.Convert(sortDirection);
                return new ApiConnectionAction<ContactsSearchSimpleResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "emfluencemp")]
        [WorkflowExpressionFactory(nameof(__BuildContactsSearch))]
        public IBodyWorkflowAction<ContactsSearchResponse> ContactsSearch([WorkflowExpression] Func<int> bodygroupID = null, [WorkflowExpression] Func<bool> bodysuppressed = null, [WorkflowExpression] Func<bool> bodyheld = null, [WorkflowExpression] Func<JToken[]> bodycontactIDs = null, [WorkflowExpression] Func<string> bodyemail = null, [WorkflowExpression] Func<int> bodyuserID = null, [WorkflowExpression] Func<string> bodycustomerID = null, [WorkflowExpression] Func<string> bodycompany = null, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodyphone = null, [WorkflowExpression] Func<string> bodyfax = null, [WorkflowExpression] Func<string> bodycity = null, [WorkflowExpression] Func<string> bodystate = null, [WorkflowExpression] Func<string> bodyzipCode = null, [WorkflowExpression] Func<string> bodycountry = null, [WorkflowExpression] Func<string> bodypurl = null, [WorkflowExpression] Func<string> bodyfields = null, [WorkflowExpression] Func<int> bodypage = null, [WorkflowExpression] Func<int> bodyrpp = null, [WorkflowExpression] Func<bodysortFieldInput> bodysortField = null, [WorkflowExpression] Func<bodysortDirectionInput> bodysortDirection = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "emfluencemp")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ContactsSearchResponse> __BuildContactsSearch(WorkflowExpression<int> bodygroupID = null, WorkflowExpression<bool> bodysuppressed = null, WorkflowExpression<bool> bodyheld = null, WorkflowExpression<JToken[]> bodycontactIDs = null, WorkflowExpression<string> bodyemail = null, WorkflowExpression<int> bodyuserID = null, WorkflowExpression<string> bodycustomerID = null, WorkflowExpression<string> bodycompany = null, WorkflowExpression<string> bodytitle = null, WorkflowExpression<string> bodyphone = null, WorkflowExpression<string> bodyfax = null, WorkflowExpression<string> bodycity = null, WorkflowExpression<string> bodystate = null, WorkflowExpression<string> bodyzipCode = null, WorkflowExpression<string> bodycountry = null, WorkflowExpression<string> bodypurl = null, WorkflowExpression<string> bodyfields = null, WorkflowExpression<int> bodypage = null, WorkflowExpression<int> bodyrpp = null, WorkflowExpression<bodysortFieldInput> bodysortField = null, WorkflowExpression<bodysortDirectionInput> bodysortDirection = null)
        {
            WorkflowExpression.Validate(bodygroupID, nameof(bodygroupID), required: false);
            WorkflowExpression.Validate(bodysuppressed, nameof(bodysuppressed), required: false);
            WorkflowExpression.Validate(bodyheld, nameof(bodyheld), required: false);
            WorkflowExpression.Validate(bodycontactIDs, nameof(bodycontactIDs), required: false);
            WorkflowExpression.Validate(bodyemail, nameof(bodyemail), required: false);
            WorkflowExpression.Validate(bodyuserID, nameof(bodyuserID), required: false);
            WorkflowExpression.Validate(bodycustomerID, nameof(bodycustomerID), required: false);
            WorkflowExpression.Validate(bodycompany, nameof(bodycompany), required: false);
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            WorkflowExpression.Validate(bodyphone, nameof(bodyphone), required: false);
            WorkflowExpression.Validate(bodyfax, nameof(bodyfax), required: false);
            WorkflowExpression.Validate(bodycity, nameof(bodycity), required: false);
            WorkflowExpression.Validate(bodystate, nameof(bodystate), required: false);
            WorkflowExpression.Validate(bodyzipCode, nameof(bodyzipCode), required: false);
            WorkflowExpression.Validate(bodycountry, nameof(bodycountry), required: false);
            WorkflowExpression.Validate(bodypurl, nameof(bodypurl), required: false);
            WorkflowExpression.Validate(bodyfields, nameof(bodyfields), required: false);
            WorkflowExpression.Validate(bodypage, nameof(bodypage), required: false);
            WorkflowExpression.Validate(bodyrpp, nameof(bodyrpp), required: false);
            WorkflowExpression.Validate(bodysortField, nameof(bodysortField), required: false);
            WorkflowExpression.Validate(bodysortDirection, nameof(bodysortDirection), required: false);
            return new DeferredBodyAction<ContactsSearchResponse>(() =>
            {
                var apiCallPath = "/contacts/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodygroupID != null)
                {
                    body["groupID"] = ExpressionConverter.ConvertO(bodygroupID);
                    bodypropCount++;
                }

                if (bodysuppressed != null)
                {
                    body["suppressed"] = ExpressionConverter.ConvertO(bodysuppressed);
                    bodypropCount++;
                }

                if (bodyheld != null)
                {
                    body["held"] = ExpressionConverter.ConvertO(bodyheld);
                    bodypropCount++;
                }

                if (bodycontactIDs != null)
                {
                    body["contactIDs"] = ExpressionConverter.ConvertO(bodycontactIDs);
                    bodypropCount++;
                }

                if (bodyemail != null)
                {
                    body["email"] = ExpressionConverter.ConvertO(bodyemail);
                    bodypropCount++;
                }

                if (bodyuserID != null)
                {
                    body["userID"] = ExpressionConverter.ConvertO(bodyuserID);
                    bodypropCount++;
                }

                if (bodycustomerID != null)
                {
                    body["customerID"] = ExpressionConverter.ConvertO(bodycustomerID);
                    bodypropCount++;
                }

                if (bodycompany != null)
                {
                    body["company"] = ExpressionConverter.ConvertO(bodycompany);
                    bodypropCount++;
                }

                if (bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(bodytitle);
                    bodypropCount++;
                }

                if (bodyphone != null)
                {
                    body["phone"] = ExpressionConverter.ConvertO(bodyphone);
                    bodypropCount++;
                }

                if (bodyfax != null)
                {
                    body["fax"] = ExpressionConverter.ConvertO(bodyfax);
                    bodypropCount++;
                }

                if (bodycity != null)
                {
                    body["city"] = ExpressionConverter.ConvertO(bodycity);
                    bodypropCount++;
                }

                if (bodystate != null)
                {
                    body["state"] = ExpressionConverter.ConvertO(bodystate);
                    bodypropCount++;
                }

                if (bodyzipCode != null)
                {
                    body["zipCode"] = ExpressionConverter.ConvertO(bodyzipCode);
                    bodypropCount++;
                }

                if (bodycountry != null)
                {
                    body["country"] = ExpressionConverter.ConvertO(bodycountry);
                    bodypropCount++;
                }

                if (bodypurl != null)
                {
                    body["purl"] = ExpressionConverter.ConvertO(bodypurl);
                    bodypropCount++;
                }

                if (bodyfields != null)
                {
                    body["fields"] = ExpressionConverter.ConvertO(bodyfields);
                    bodypropCount++;
                }

                if (bodypage != null)
                {
                    if (bodypage != null)
                    {
                        body["page"] = ExpressionConverter.ConvertO(bodypage);
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
                    body["rpp"] = ExpressionConverter.ConvertO(bodyrpp);
                    bodypropCount++;
                }

                if (bodysortField != null)
                {
                    body["sortField"] = ExpressionConverter.ConvertO(bodysortField);
                    bodypropCount++;
                }

                if (bodysortDirection != null)
                {
                    body["sortDirection"] = ExpressionConverter.ConvertO(bodysortDirection);
                    bodypropCount++;
                }

                body["_internal"] = true;
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ContactsSearchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "emfluencemp")]
        [WorkflowExpressionFactory(nameof(__BuildContactsLookup))]
        public IBodyWorkflowAction<ContactsLookupResponse> ContactsLookup([WorkflowExpression] Func<string> email)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "emfluencemp")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ContactsLookupResponse> __BuildContactsLookup(WorkflowExpression<string> email)
        {
            WorkflowExpression.Validate(email, nameof(email), required: true);
            return new DeferredBodyAction<ContactsLookupResponse>(() =>
            {
                var apiCallPath = "/contacts/lookup";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["email"] = ExpressionConverter.Convert(email);
                return new ApiConnectionAction<ContactsLookupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "emfluencemp")]
        [WorkflowExpressionFactory(nameof(__BuildContactsSave))]
        public IBodyWorkflowAction<ContactsSaveResponse> ContactsSave([WorkflowExpression] Func<int> bodycontactID = null, [WorkflowExpression] Func<string> bodyemail = null, [WorkflowExpression] Func<int> bodyuserID = null, [WorkflowExpression] Func<string> bodycustomerID = null, [WorkflowExpression] Func<bool> bodysuppressed = null, [WorkflowExpression] Func<bool> bodyheld = null, [WorkflowExpression] Func<string> bodyoriginalSource = null, [WorkflowExpression] Func<string> bodyfirstName = null, [WorkflowExpression] Func<string> bodylastName = null, [WorkflowExpression] Func<string> bodycompany = null, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodyphone = null, [WorkflowExpression] Func<string> bodyfax = null, [WorkflowExpression] Func<string> bodyaddress1 = null, [WorkflowExpression] Func<string> bodyaddress2 = null, [WorkflowExpression] Func<string> bodycity = null, [WorkflowExpression] Func<string> bodystate = null, [WorkflowExpression] Func<string> bodyzipCode = null, [WorkflowExpression] Func<string> bodycountry = null, [WorkflowExpression] Func<string> bodypurl = null, [WorkflowExpression] Func<string> bodydateOfBirth = null, [WorkflowExpression] Func<string> bodynotes = null, [WorkflowExpression] Func<string> bodymemo = null, [WorkflowExpression] Func<int[]> bodygroupIDs = null, [WorkflowExpression] Func<int[]> bodyremoveGroupIDs = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "emfluencemp")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ContactsSaveResponse> __BuildContactsSave(WorkflowExpression<int> bodycontactID = null, WorkflowExpression<string> bodyemail = null, WorkflowExpression<int> bodyuserID = null, WorkflowExpression<string> bodycustomerID = null, WorkflowExpression<bool> bodysuppressed = null, WorkflowExpression<bool> bodyheld = null, WorkflowExpression<string> bodyoriginalSource = null, WorkflowExpression<string> bodyfirstName = null, WorkflowExpression<string> bodylastName = null, WorkflowExpression<string> bodycompany = null, WorkflowExpression<string> bodytitle = null, WorkflowExpression<string> bodyphone = null, WorkflowExpression<string> bodyfax = null, WorkflowExpression<string> bodyaddress1 = null, WorkflowExpression<string> bodyaddress2 = null, WorkflowExpression<string> bodycity = null, WorkflowExpression<string> bodystate = null, WorkflowExpression<string> bodyzipCode = null, WorkflowExpression<string> bodycountry = null, WorkflowExpression<string> bodypurl = null, WorkflowExpression<string> bodydateOfBirth = null, WorkflowExpression<string> bodynotes = null, WorkflowExpression<string> bodymemo = null, WorkflowExpression<int[]> bodygroupIDs = null, WorkflowExpression<int[]> bodyremoveGroupIDs = null)
        {
            WorkflowExpression.Validate(bodycontactID, nameof(bodycontactID), required: false);
            WorkflowExpression.Validate(bodyemail, nameof(bodyemail), required: false);
            WorkflowExpression.Validate(bodyuserID, nameof(bodyuserID), required: false);
            WorkflowExpression.Validate(bodycustomerID, nameof(bodycustomerID), required: false);
            WorkflowExpression.Validate(bodysuppressed, nameof(bodysuppressed), required: false);
            WorkflowExpression.Validate(bodyheld, nameof(bodyheld), required: false);
            WorkflowExpression.Validate(bodyoriginalSource, nameof(bodyoriginalSource), required: false);
            WorkflowExpression.Validate(bodyfirstName, nameof(bodyfirstName), required: false);
            WorkflowExpression.Validate(bodylastName, nameof(bodylastName), required: false);
            WorkflowExpression.Validate(bodycompany, nameof(bodycompany), required: false);
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            WorkflowExpression.Validate(bodyphone, nameof(bodyphone), required: false);
            WorkflowExpression.Validate(bodyfax, nameof(bodyfax), required: false);
            WorkflowExpression.Validate(bodyaddress1, nameof(bodyaddress1), required: false);
            WorkflowExpression.Validate(bodyaddress2, nameof(bodyaddress2), required: false);
            WorkflowExpression.Validate(bodycity, nameof(bodycity), required: false);
            WorkflowExpression.Validate(bodystate, nameof(bodystate), required: false);
            WorkflowExpression.Validate(bodyzipCode, nameof(bodyzipCode), required: false);
            WorkflowExpression.Validate(bodycountry, nameof(bodycountry), required: false);
            WorkflowExpression.Validate(bodypurl, nameof(bodypurl), required: false);
            WorkflowExpression.Validate(bodydateOfBirth, nameof(bodydateOfBirth), required: false);
            WorkflowExpression.Validate(bodynotes, nameof(bodynotes), required: false);
            WorkflowExpression.Validate(bodymemo, nameof(bodymemo), required: false);
            WorkflowExpression.Validate(bodygroupIDs, nameof(bodygroupIDs), required: false);
            WorkflowExpression.Validate(bodyremoveGroupIDs, nameof(bodyremoveGroupIDs), required: false);
            return new DeferredBodyAction<ContactsSaveResponse>(() =>
            {
                var apiCallPath = "/contacts/save";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycontactID != null)
                {
                    body["contactID"] = ExpressionConverter.ConvertO(bodycontactID);
                    bodypropCount++;
                }

                if (bodyemail != null)
                {
                    body["email"] = ExpressionConverter.ConvertO(bodyemail);
                    bodypropCount++;
                }

                if (bodyuserID != null)
                {
                    body["userID"] = ExpressionConverter.ConvertO(bodyuserID);
                    bodypropCount++;
                }

                if (bodycustomerID != null)
                {
                    body["customerID"] = ExpressionConverter.ConvertO(bodycustomerID);
                    bodypropCount++;
                }

                if (bodysuppressed != null)
                {
                    body["suppressed"] = ExpressionConverter.ConvertO(bodysuppressed);
                    bodypropCount++;
                }

                if (bodyheld != null)
                {
                    body["held"] = ExpressionConverter.ConvertO(bodyheld);
                    bodypropCount++;
                }

                if (bodyoriginalSource != null)
                {
                    body["originalSource"] = ExpressionConverter.ConvertO(bodyoriginalSource);
                    bodypropCount++;
                }

                if (bodyfirstName != null)
                {
                    body["firstName"] = ExpressionConverter.ConvertO(bodyfirstName);
                    bodypropCount++;
                }

                if (bodylastName != null)
                {
                    body["lastName"] = ExpressionConverter.ConvertO(bodylastName);
                    bodypropCount++;
                }

                if (bodycompany != null)
                {
                    body["company"] = ExpressionConverter.ConvertO(bodycompany);
                    bodypropCount++;
                }

                if (bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(bodytitle);
                    bodypropCount++;
                }

                if (bodyphone != null)
                {
                    body["phone"] = ExpressionConverter.ConvertO(bodyphone);
                    bodypropCount++;
                }

                if (bodyfax != null)
                {
                    body["fax"] = ExpressionConverter.ConvertO(bodyfax);
                    bodypropCount++;
                }

                if (bodyaddress1 != null)
                {
                    body["address1"] = ExpressionConverter.ConvertO(bodyaddress1);
                    bodypropCount++;
                }

                if (bodyaddress2 != null)
                {
                    body["address2"] = ExpressionConverter.ConvertO(bodyaddress2);
                    bodypropCount++;
                }

                if (bodycity != null)
                {
                    body["city"] = ExpressionConverter.ConvertO(bodycity);
                    bodypropCount++;
                }

                if (bodystate != null)
                {
                    body["state"] = ExpressionConverter.ConvertO(bodystate);
                    bodypropCount++;
                }

                if (bodyzipCode != null)
                {
                    body["zipCode"] = ExpressionConverter.ConvertO(bodyzipCode);
                    bodypropCount++;
                }

                if (bodycountry != null)
                {
                    body["country"] = ExpressionConverter.ConvertO(bodycountry);
                    bodypropCount++;
                }

                if (bodypurl != null)
                {
                    body["purl"] = ExpressionConverter.ConvertO(bodypurl);
                    bodypropCount++;
                }

                if (bodydateOfBirth != null)
                {
                    body["dateOfBirth"] = ExpressionConverter.ConvertO(bodydateOfBirth);
                    bodypropCount++;
                }

                if (bodynotes != null)
                {
                    body["notes"] = ExpressionConverter.ConvertO(bodynotes);
                    bodypropCount++;
                }

                if (bodymemo != null)
                {
                    body["memo"] = ExpressionConverter.ConvertO(bodymemo);
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
                    body["groupIDs"] = ExpressionConverter.ConvertO(bodygroupIDs);
                    bodypropCount++;
                }

                if (bodyremoveGroupIDs != null)
                {
                    body["removeGroupIDs"] = ExpressionConverter.ConvertO(bodyremoveGroupIDs);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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