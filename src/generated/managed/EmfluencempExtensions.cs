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
        public IBodyWorkflowAction<ContactsSearchSimpleResponse> ContactsSearchSimple([WorkflowExpression] Func<string> email = null, [WorkflowExpression] Func<int> groupID = null, [WorkflowExpression] Func<bool> suppressed = null, [WorkflowExpression] Func<bool> held = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<sortFieldInput> sortField = null, [WorkflowExpression] Func<sortDirectionInput> sortDirection = null)
        {
            SourceExpression.Validate(email, nameof(email), required: false);
            SourceExpression.Validate(groupID, nameof(groupID), required: false);
            SourceExpression.Validate(suppressed, nameof(suppressed), required: false);
            SourceExpression.Validate(held, nameof(held), required: false);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(sortField, nameof(sortField), required: false);
            SourceExpression.Validate(sortDirection, nameof(sortDirection), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/contacts/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (email != null)
                    callPayload.Queries["email"] = SourceExpressionConverter.ConvertO(email);
                if (groupID != null)
                    callPayload.Queries["groupID"] = SourceExpressionConverter.ConvertO(groupID);
                if (suppressed != null)
                    callPayload.Queries["suppressed"] = SourceExpressionConverter.ConvertO(suppressed);
                if (held != null)
                    callPayload.Queries["held"] = SourceExpressionConverter.ConvertO(held);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (sortField != null)
                    callPayload.Queries["sortField"] = SourceExpressionConverter.Convert(sortField);
                if (sortDirection != null)
                    callPayload.Queries["sortDirection"] = SourceExpressionConverter.Convert(sortDirection);
                return callPayload;
            }

            return new ApiConnectionAction<ContactsSearchSimpleResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "emfluencemp")]
        public IBodyWorkflowAction<ContactsSearchResponse> ContactsSearch([WorkflowExpression] Func<int> bodygroupID = null, [WorkflowExpression] Func<bool> bodysuppressed = null, [WorkflowExpression] Func<bool> bodyheld = null, [WorkflowExpression] Func<JToken[]> bodycontactIDs = null, [WorkflowExpression] Func<string> bodyemail = null, [WorkflowExpression] Func<int> bodyuserID = null, [WorkflowExpression] Func<string> bodycustomerID = null, [WorkflowExpression] Func<string> bodycompany = null, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodyphone = null, [WorkflowExpression] Func<string> bodyfax = null, [WorkflowExpression] Func<string> bodycity = null, [WorkflowExpression] Func<string> bodystate = null, [WorkflowExpression] Func<string> bodyzipCode = null, [WorkflowExpression] Func<string> bodycountry = null, [WorkflowExpression] Func<string> bodypurl = null, [WorkflowExpression] Func<string> bodyfields = null, [WorkflowExpression] Func<int> bodypage = null, [WorkflowExpression] Func<int> bodyrpp = null, [WorkflowExpression] Func<bodysortFieldInput> bodysortField = null, [WorkflowExpression] Func<bodysortDirectionInput> bodysortDirection = null)
        {
            SourceExpression.Validate(bodygroupID, nameof(bodygroupID), required: false);
            SourceExpression.Validate(bodysuppressed, nameof(bodysuppressed), required: false);
            SourceExpression.Validate(bodyheld, nameof(bodyheld), required: false);
            SourceExpression.Validate(bodycontactIDs, nameof(bodycontactIDs), required: false);
            SourceExpression.Validate(bodyemail, nameof(bodyemail), required: false);
            SourceExpression.Validate(bodyuserID, nameof(bodyuserID), required: false);
            SourceExpression.Validate(bodycustomerID, nameof(bodycustomerID), required: false);
            SourceExpression.Validate(bodycompany, nameof(bodycompany), required: false);
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            SourceExpression.Validate(bodyphone, nameof(bodyphone), required: false);
            SourceExpression.Validate(bodyfax, nameof(bodyfax), required: false);
            SourceExpression.Validate(bodycity, nameof(bodycity), required: false);
            SourceExpression.Validate(bodystate, nameof(bodystate), required: false);
            SourceExpression.Validate(bodyzipCode, nameof(bodyzipCode), required: false);
            SourceExpression.Validate(bodycountry, nameof(bodycountry), required: false);
            SourceExpression.Validate(bodypurl, nameof(bodypurl), required: false);
            SourceExpression.Validate(bodyfields, nameof(bodyfields), required: false);
            SourceExpression.Validate(bodypage, nameof(bodypage), required: false);
            SourceExpression.Validate(bodyrpp, nameof(bodyrpp), required: false);
            SourceExpression.Validate(bodysortField, nameof(bodysortField), required: false);
            SourceExpression.Validate(bodysortDirection, nameof(bodysortDirection), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/contacts/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodygroupID != null)
                {
                    body["groupID"] = SourceExpressionConverter.ConvertToken(bodygroupID);
                    bodypropCount++;
                }

                if (bodysuppressed != null)
                {
                    body["suppressed"] = SourceExpressionConverter.ConvertToken(bodysuppressed);
                    bodypropCount++;
                }

                if (bodyheld != null)
                {
                    body["held"] = SourceExpressionConverter.ConvertToken(bodyheld);
                    bodypropCount++;
                }

                if (bodycontactIDs != null)
                {
                    body["contactIDs"] = SourceExpressionConverter.ConvertToken(bodycontactIDs);
                    bodypropCount++;
                }

                if (bodyemail != null)
                {
                    body["email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                    bodypropCount++;
                }

                if (bodyuserID != null)
                {
                    body["userID"] = SourceExpressionConverter.ConvertToken(bodyuserID);
                    bodypropCount++;
                }

                if (bodycustomerID != null)
                {
                    body["customerID"] = SourceExpressionConverter.ConvertToken(bodycustomerID);
                    bodypropCount++;
                }

                if (bodycompany != null)
                {
                    body["company"] = SourceExpressionConverter.ConvertToken(bodycompany);
                    bodypropCount++;
                }

                if (bodytitle != null)
                {
                    body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodyphone != null)
                {
                    body["phone"] = SourceExpressionConverter.ConvertToken(bodyphone);
                    bodypropCount++;
                }

                if (bodyfax != null)
                {
                    body["fax"] = SourceExpressionConverter.ConvertToken(bodyfax);
                    bodypropCount++;
                }

                if (bodycity != null)
                {
                    body["city"] = SourceExpressionConverter.ConvertToken(bodycity);
                    bodypropCount++;
                }

                if (bodystate != null)
                {
                    body["state"] = SourceExpressionConverter.ConvertToken(bodystate);
                    bodypropCount++;
                }

                if (bodyzipCode != null)
                {
                    body["zipCode"] = SourceExpressionConverter.ConvertToken(bodyzipCode);
                    bodypropCount++;
                }

                if (bodycountry != null)
                {
                    body["country"] = SourceExpressionConverter.ConvertToken(bodycountry);
                    bodypropCount++;
                }

                if (bodypurl != null)
                {
                    body["purl"] = SourceExpressionConverter.ConvertToken(bodypurl);
                    bodypropCount++;
                }

                if (bodyfields != null)
                {
                    body["fields"] = SourceExpressionConverter.ConvertToken(bodyfields);
                    bodypropCount++;
                }

                if (bodypage != null)
                {
                    if (bodypage != null)
                    {
                        body["page"] = SourceExpressionConverter.ConvertToken(bodypage);
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
                    body["rpp"] = SourceExpressionConverter.ConvertToken(bodyrpp);
                    bodypropCount++;
                }

                if (bodysortField != null)
                {
                    body["sortField"] = SourceExpressionConverter.Convert(bodysortField);
                    bodypropCount++;
                }

                if (bodysortDirection != null)
                {
                    body["sortDirection"] = SourceExpressionConverter.Convert(bodysortDirection);
                    bodypropCount++;
                }

                body["_internal"] = true;
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ContactsSearchResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "emfluencemp")]
        public IBodyWorkflowAction<ContactsLookupResponse> ContactsLookup([WorkflowExpression] Func<string> email)
        {
            SourceExpression.Validate(email, nameof(email), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/contacts/lookup";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["email"] = SourceExpressionConverter.ConvertO(email);
                return callPayload;
            }

            return new ApiConnectionAction<ContactsLookupResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "emfluencemp")]
        public IBodyWorkflowAction<ContactsSaveResponse> ContactsSave([WorkflowExpression] Func<int> bodycontactID = null, [WorkflowExpression] Func<string> bodyemail = null, [WorkflowExpression] Func<int> bodyuserID = null, [WorkflowExpression] Func<string> bodycustomerID = null, [WorkflowExpression] Func<bool> bodysuppressed = null, [WorkflowExpression] Func<bool> bodyheld = null, [WorkflowExpression] Func<string> bodyoriginalSource = null, [WorkflowExpression] Func<string> bodyfirstName = null, [WorkflowExpression] Func<string> bodylastName = null, [WorkflowExpression] Func<string> bodycompany = null, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodyphone = null, [WorkflowExpression] Func<string> bodyfax = null, [WorkflowExpression] Func<string> bodyaddress1 = null, [WorkflowExpression] Func<string> bodyaddress2 = null, [WorkflowExpression] Func<string> bodycity = null, [WorkflowExpression] Func<string> bodystate = null, [WorkflowExpression] Func<string> bodyzipCode = null, [WorkflowExpression] Func<string> bodycountry = null, [WorkflowExpression] Func<string> bodypurl = null, [WorkflowExpression] Func<string> bodydateOfBirth = null, [WorkflowExpression] Func<string> bodynotes = null, [WorkflowExpression] Func<string> bodymemo = null, [WorkflowExpression] Func<int[]> bodygroupIDs = null, [WorkflowExpression] Func<int[]> bodyremoveGroupIDs = null)
        {
            SourceExpression.Validate(bodycontactID, nameof(bodycontactID), required: false);
            SourceExpression.Validate(bodyemail, nameof(bodyemail), required: false);
            SourceExpression.Validate(bodyuserID, nameof(bodyuserID), required: false);
            SourceExpression.Validate(bodycustomerID, nameof(bodycustomerID), required: false);
            SourceExpression.Validate(bodysuppressed, nameof(bodysuppressed), required: false);
            SourceExpression.Validate(bodyheld, nameof(bodyheld), required: false);
            SourceExpression.Validate(bodyoriginalSource, nameof(bodyoriginalSource), required: false);
            SourceExpression.Validate(bodyfirstName, nameof(bodyfirstName), required: false);
            SourceExpression.Validate(bodylastName, nameof(bodylastName), required: false);
            SourceExpression.Validate(bodycompany, nameof(bodycompany), required: false);
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            SourceExpression.Validate(bodyphone, nameof(bodyphone), required: false);
            SourceExpression.Validate(bodyfax, nameof(bodyfax), required: false);
            SourceExpression.Validate(bodyaddress1, nameof(bodyaddress1), required: false);
            SourceExpression.Validate(bodyaddress2, nameof(bodyaddress2), required: false);
            SourceExpression.Validate(bodycity, nameof(bodycity), required: false);
            SourceExpression.Validate(bodystate, nameof(bodystate), required: false);
            SourceExpression.Validate(bodyzipCode, nameof(bodyzipCode), required: false);
            SourceExpression.Validate(bodycountry, nameof(bodycountry), required: false);
            SourceExpression.Validate(bodypurl, nameof(bodypurl), required: false);
            SourceExpression.Validate(bodydateOfBirth, nameof(bodydateOfBirth), required: false);
            SourceExpression.Validate(bodynotes, nameof(bodynotes), required: false);
            SourceExpression.Validate(bodymemo, nameof(bodymemo), required: false);
            SourceExpression.Validate(bodygroupIDs, nameof(bodygroupIDs), required: false);
            SourceExpression.Validate(bodyremoveGroupIDs, nameof(bodyremoveGroupIDs), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/contacts/save";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycontactID != null)
                {
                    body["contactID"] = SourceExpressionConverter.ConvertToken(bodycontactID);
                    bodypropCount++;
                }

                if (bodyemail != null)
                {
                    body["email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                    bodypropCount++;
                }

                if (bodyuserID != null)
                {
                    body["userID"] = SourceExpressionConverter.ConvertToken(bodyuserID);
                    bodypropCount++;
                }

                if (bodycustomerID != null)
                {
                    body["customerID"] = SourceExpressionConverter.ConvertToken(bodycustomerID);
                    bodypropCount++;
                }

                if (bodysuppressed != null)
                {
                    body["suppressed"] = SourceExpressionConverter.ConvertToken(bodysuppressed);
                    bodypropCount++;
                }

                if (bodyheld != null)
                {
                    body["held"] = SourceExpressionConverter.ConvertToken(bodyheld);
                    bodypropCount++;
                }

                if (bodyoriginalSource != null)
                {
                    body["originalSource"] = SourceExpressionConverter.ConvertToken(bodyoriginalSource);
                    bodypropCount++;
                }

                if (bodyfirstName != null)
                {
                    body["firstName"] = SourceExpressionConverter.ConvertToken(bodyfirstName);
                    bodypropCount++;
                }

                if (bodylastName != null)
                {
                    body["lastName"] = SourceExpressionConverter.ConvertToken(bodylastName);
                    bodypropCount++;
                }

                if (bodycompany != null)
                {
                    body["company"] = SourceExpressionConverter.ConvertToken(bodycompany);
                    bodypropCount++;
                }

                if (bodytitle != null)
                {
                    body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodyphone != null)
                {
                    body["phone"] = SourceExpressionConverter.ConvertToken(bodyphone);
                    bodypropCount++;
                }

                if (bodyfax != null)
                {
                    body["fax"] = SourceExpressionConverter.ConvertToken(bodyfax);
                    bodypropCount++;
                }

                if (bodyaddress1 != null)
                {
                    body["address1"] = SourceExpressionConverter.ConvertToken(bodyaddress1);
                    bodypropCount++;
                }

                if (bodyaddress2 != null)
                {
                    body["address2"] = SourceExpressionConverter.ConvertToken(bodyaddress2);
                    bodypropCount++;
                }

                if (bodycity != null)
                {
                    body["city"] = SourceExpressionConverter.ConvertToken(bodycity);
                    bodypropCount++;
                }

                if (bodystate != null)
                {
                    body["state"] = SourceExpressionConverter.ConvertToken(bodystate);
                    bodypropCount++;
                }

                if (bodyzipCode != null)
                {
                    body["zipCode"] = SourceExpressionConverter.ConvertToken(bodyzipCode);
                    bodypropCount++;
                }

                if (bodycountry != null)
                {
                    body["country"] = SourceExpressionConverter.ConvertToken(bodycountry);
                    bodypropCount++;
                }

                if (bodypurl != null)
                {
                    body["purl"] = SourceExpressionConverter.ConvertToken(bodypurl);
                    bodypropCount++;
                }

                if (bodydateOfBirth != null)
                {
                    body["dateOfBirth"] = SourceExpressionConverter.ConvertToken(bodydateOfBirth);
                    bodypropCount++;
                }

                if (bodynotes != null)
                {
                    body["notes"] = SourceExpressionConverter.ConvertToken(bodynotes);
                    bodypropCount++;
                }

                if (bodymemo != null)
                {
                    body["memo"] = SourceExpressionConverter.ConvertToken(bodymemo);
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
                    body["groupIDs"] = SourceExpressionConverter.ConvertToken(bodygroupIDs);
                    bodypropCount++;
                }

                if (bodyremoveGroupIDs != null)
                {
                    body["removeGroupIDs"] = SourceExpressionConverter.ConvertToken(bodyremoveGroupIDs);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ContactsSaveResponse>(BuildSourceInput);
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