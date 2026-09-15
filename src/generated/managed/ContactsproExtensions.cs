//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Contactspro
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ContactsproActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contactspro")]
        public IBodyWorkflowAction<Contact> GetContact(Expression<Func<string>> contactListId, Expression<Func<string>> contactId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/contacts/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(contactListId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(contactId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Contact>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contactspro")]
        public IWorkflowAction DeleteContact(Expression<Func<string>> contactListId, Expression<Func<string>> contactId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/contacts/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(contactListId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(contactId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contactspro")]
        public IBodyWorkflowAction<Contact> UpdateContact(Expression<Func<string>> contactListId, Expression<Func<string>> contactId, Expression<Func<string>> bodyname, Expression<Func<string>> bodygroupId = null, Expression<Func<string>> bodyjobTitle = null, Expression<Func<string>> bodycompany = null, Expression<Func<string>> bodydepartment = null, Expression<Func<string>> bodyinternetemail = null, Expression<Func<string>> bodyinternetwebsite = null, Expression<Func<string>> bodyinternetlinkedin = null, Expression<Func<string>> bodyinternetfacebook = null, Expression<Func<string>> bodyinternettwitter = null, Expression<Func<string>> bodyphonesbusinessPhone = null, Expression<Func<string>> bodyphonesmobile = null, Expression<Func<string>> bodyphoneshome = null, Expression<Func<string>> bodyphonesbusinessFax = null, Expression<Func<Address[]>> bodyaddresses = null, Expression<Func<string>> bodynotes = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/contacts/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(contactListId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(contactId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["name"] = CSharpExpressionConverter.ConvertToken(bodyname);
            if (bodygroupId != null)
            {
                body["groupId"] = CSharpExpressionConverter.ConvertToken(bodygroupId);
                bodypropCount++;
            }

            if (bodyjobTitle != null)
            {
                body["jobTitle"] = CSharpExpressionConverter.ConvertToken(bodyjobTitle);
                bodypropCount++;
            }

            if (bodycompany != null)
            {
                body["company"] = CSharpExpressionConverter.ConvertToken(bodycompany);
                bodypropCount++;
            }

            if (bodydepartment != null)
            {
                body["department"] = CSharpExpressionConverter.ConvertToken(bodydepartment);
                bodypropCount++;
            }

            var internetObject = new JObject();
            var internetObjectpropCount = 0;
            if (bodyinternetemail != null)
            {
                internetObject["email"] = CSharpExpressionConverter.ConvertToken(bodyinternetemail);
                internetObjectpropCount++;
            }

            if (bodyinternetwebsite != null)
            {
                internetObject["website"] = CSharpExpressionConverter.ConvertToken(bodyinternetwebsite);
                internetObjectpropCount++;
            }

            if (bodyinternetlinkedin != null)
            {
                internetObject["linkedin"] = CSharpExpressionConverter.ConvertToken(bodyinternetlinkedin);
                internetObjectpropCount++;
            }

            if (bodyinternetfacebook != null)
            {
                internetObject["facebook"] = CSharpExpressionConverter.ConvertToken(bodyinternetfacebook);
                internetObjectpropCount++;
            }

            if (bodyinternettwitter != null)
            {
                internetObject["twitter"] = CSharpExpressionConverter.ConvertToken(bodyinternettwitter);
                internetObjectpropCount++;
            }

            if (internetObjectpropCount > 0)
            {
                body["internet"] = internetObject;
                bodypropCount++;
            }

            var phonesObject = new JObject();
            var phonesObjectpropCount = 0;
            if (bodyphonesbusinessPhone != null)
            {
                phonesObject["businessPhone"] = CSharpExpressionConverter.ConvertToken(bodyphonesbusinessPhone);
                phonesObjectpropCount++;
            }

            if (bodyphonesmobile != null)
            {
                phonesObject["mobile"] = CSharpExpressionConverter.ConvertToken(bodyphonesmobile);
                phonesObjectpropCount++;
            }

            if (bodyphoneshome != null)
            {
                phonesObject["home"] = CSharpExpressionConverter.ConvertToken(bodyphoneshome);
                phonesObjectpropCount++;
            }

            if (bodyphonesbusinessFax != null)
            {
                phonesObject["businessFax"] = CSharpExpressionConverter.ConvertToken(bodyphonesbusinessFax);
                phonesObjectpropCount++;
            }

            if (phonesObjectpropCount > 0)
            {
                body["phones"] = phonesObject;
                bodypropCount++;
            }

            if (bodyaddresses != null)
            {
                body["addresses"] = CSharpExpressionConverter.ConvertToken(bodyaddresses);
                bodypropCount++;
            }

            if (bodynotes != null)
            {
                body["notes"] = CSharpExpressionConverter.ConvertToken(bodynotes);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<Contact>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contactspro")]
        public IBodyWorkflowAction<Contact[]> GetAllContacts(Expression<Func<string>> contactListId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/contacts", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(contactListId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Contact[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contactspro")]
        public IBodyWorkflowAction<Contact> CreateContact(Expression<Func<string>> contactListId, Expression<Func<string>> bodyname, Expression<Func<string>> bodygroupId = null, Expression<Func<string>> bodyjobTitle = null, Expression<Func<string>> bodycompany = null, Expression<Func<string>> bodydepartment = null, Expression<Func<string>> bodyinternetemail = null, Expression<Func<string>> bodyinternetwebsite = null, Expression<Func<string>> bodyinternetlinkedin = null, Expression<Func<string>> bodyinternetfacebook = null, Expression<Func<string>> bodyinternettwitter = null, Expression<Func<string>> bodyphonesbusinessPhone = null, Expression<Func<string>> bodyphonesmobile = null, Expression<Func<string>> bodyphoneshome = null, Expression<Func<string>> bodyphonesbusinessFax = null, Expression<Func<Address[]>> bodyaddresses = null, Expression<Func<string>> bodynotes = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/contacts", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(contactListId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["name"] = CSharpExpressionConverter.ConvertToken(bodyname);
            if (bodygroupId != null)
            {
                body["groupId"] = CSharpExpressionConverter.ConvertToken(bodygroupId);
                bodypropCount++;
            }

            if (bodyjobTitle != null)
            {
                body["jobTitle"] = CSharpExpressionConverter.ConvertToken(bodyjobTitle);
                bodypropCount++;
            }

            if (bodycompany != null)
            {
                body["company"] = CSharpExpressionConverter.ConvertToken(bodycompany);
                bodypropCount++;
            }

            if (bodydepartment != null)
            {
                body["department"] = CSharpExpressionConverter.ConvertToken(bodydepartment);
                bodypropCount++;
            }

            var internetObject = new JObject();
            var internetObjectpropCount = 0;
            if (bodyinternetemail != null)
            {
                internetObject["email"] = CSharpExpressionConverter.ConvertToken(bodyinternetemail);
                internetObjectpropCount++;
            }

            if (bodyinternetwebsite != null)
            {
                internetObject["website"] = CSharpExpressionConverter.ConvertToken(bodyinternetwebsite);
                internetObjectpropCount++;
            }

            if (bodyinternetlinkedin != null)
            {
                internetObject["linkedin"] = CSharpExpressionConverter.ConvertToken(bodyinternetlinkedin);
                internetObjectpropCount++;
            }

            if (bodyinternetfacebook != null)
            {
                internetObject["facebook"] = CSharpExpressionConverter.ConvertToken(bodyinternetfacebook);
                internetObjectpropCount++;
            }

            if (bodyinternettwitter != null)
            {
                internetObject["twitter"] = CSharpExpressionConverter.ConvertToken(bodyinternettwitter);
                internetObjectpropCount++;
            }

            if (internetObjectpropCount > 0)
            {
                body["internet"] = internetObject;
                bodypropCount++;
            }

            var phonesObject = new JObject();
            var phonesObjectpropCount = 0;
            if (bodyphonesbusinessPhone != null)
            {
                phonesObject["businessPhone"] = CSharpExpressionConverter.ConvertToken(bodyphonesbusinessPhone);
                phonesObjectpropCount++;
            }

            if (bodyphonesmobile != null)
            {
                phonesObject["mobile"] = CSharpExpressionConverter.ConvertToken(bodyphonesmobile);
                phonesObjectpropCount++;
            }

            if (bodyphoneshome != null)
            {
                phonesObject["home"] = CSharpExpressionConverter.ConvertToken(bodyphoneshome);
                phonesObjectpropCount++;
            }

            if (bodyphonesbusinessFax != null)
            {
                phonesObject["businessFax"] = CSharpExpressionConverter.ConvertToken(bodyphonesbusinessFax);
                phonesObjectpropCount++;
            }

            if (phonesObjectpropCount > 0)
            {
                body["phones"] = phonesObject;
                bodypropCount++;
            }

            if (bodyaddresses != null)
            {
                body["addresses"] = CSharpExpressionConverter.ConvertToken(bodyaddresses);
                bodypropCount++;
            }

            if (bodynotes != null)
            {
                body["notes"] = CSharpExpressionConverter.ConvertToken(bodynotes);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<Contact>(callPayload);
        }
    }

    public class ContactsproTriggers([ConnectionName] string connectionId)
    {
    }

    public class Contact
    {
        [JsonProperty("contactListId")]
        public string ContactListId { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("groupId")]
        public string GroupId { get; set; }

        [JsonProperty("jobTitle")]
        public string JobTitle { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("internet")]
        public Internet Internet { get; set; }

        [JsonProperty("phones")]
        public PhoneNumber Phones { get; set; }

        [JsonProperty("addresses")]
        public Address[] Addresses { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }
    }

    public class Internet
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("linkedin")]
        public string Linkedin { get; set; }

        [JsonProperty("facebook")]
        public string Facebook { get; set; }

        [JsonProperty("twitter")]
        public string Twitter { get; set; }
    }

    public class PhoneNumber
    {
        [JsonProperty("businessPhone")]
        public string BusinessPhone { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("home")]
        public string Home { get; set; }

        [JsonProperty("businessFax")]
        public string BusinessFax { get; set; }
    }

    public class Address
    {
        [JsonProperty("fullAddress")]
        public string FullAddress { get; set; }

        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lng")]
        public double Lng { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Contactspro;

    public partial class WorkflowManagedActions
    {
        public ContactsproActions Contactspro(string connectionId) => new ContactsproActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ContactsproTriggers Contactspro(string connectionId) => new ContactsproTriggers(connectionId);
    }
}