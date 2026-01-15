//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Contactspro
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
            var apiCallPath = String.Format("/{0}/contacts/{1}", ExpressionConverter.ConvertWithUrlEncoding(contactListId, 1), ExpressionConverter.ConvertWithUrlEncoding(contactId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Contact>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contactspro")]
        public IWorkflowAction DeleteContact(Expression<Func<string>> contactListId, Expression<Func<string>> contactId)
        {
            var apiCallPath = String.Format("/{0}/contacts/{1}", ExpressionConverter.ConvertWithUrlEncoding(contactListId, 1), ExpressionConverter.ConvertWithUrlEncoding(contactId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contactspro")]
        public IBodyWorkflowAction<Contact> UpdateContact(Expression<Func<string>> contactListId, Expression<Func<string>> contactId, Expression<Func<string>> bodyname, Expression<Func<string>> bodygroupId = null, Expression<Func<string>> bodyjobTitle = null, Expression<Func<string>> bodycompany = null, Expression<Func<string>> bodydepartment = null, Expression<Func<string>> bodyinternetemail = null, Expression<Func<string>> bodyinternetwebsite = null, Expression<Func<string>> bodyinternetlinkedin = null, Expression<Func<string>> bodyinternetfacebook = null, Expression<Func<string>> bodyinternettwitter = null, Expression<Func<string>> bodyphonesbusinessPhone = null, Expression<Func<string>> bodyphonesmobile = null, Expression<Func<string>> bodyphoneshome = null, Expression<Func<string>> bodyphonesbusinessFax = null, Expression<Func<Address[]>> bodyaddresses = null, Expression<Func<string>> bodynotes = null)
        {
            var apiCallPath = String.Format("/{0}/contacts/{1}", ExpressionConverter.ConvertWithUrlEncoding(contactListId, 1), ExpressionConverter.ConvertWithUrlEncoding(contactId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            if (bodygroupId != null)
            {
                body["groupId"] = ExpressionConverter.ConvertO(bodygroupId);
                bodypropCount++;
            }

            if (bodyjobTitle != null)
            {
                body["jobTitle"] = ExpressionConverter.ConvertO(bodyjobTitle);
                bodypropCount++;
            }

            if (bodycompany != null)
            {
                body["company"] = ExpressionConverter.ConvertO(bodycompany);
                bodypropCount++;
            }

            if (bodydepartment != null)
            {
                body["department"] = ExpressionConverter.ConvertO(bodydepartment);
                bodypropCount++;
            }

            var internetObject = new JObject();
            var internetObjectpropCount = 0;
            if (bodyinternetemail != null)
            {
                internetObject["email"] = ExpressionConverter.ConvertO(bodyinternetemail);
                internetObjectpropCount++;
            }

            if (bodyinternetwebsite != null)
            {
                internetObject["website"] = ExpressionConverter.ConvertO(bodyinternetwebsite);
                internetObjectpropCount++;
            }

            if (bodyinternetlinkedin != null)
            {
                internetObject["linkedin"] = ExpressionConverter.ConvertO(bodyinternetlinkedin);
                internetObjectpropCount++;
            }

            if (bodyinternetfacebook != null)
            {
                internetObject["facebook"] = ExpressionConverter.ConvertO(bodyinternetfacebook);
                internetObjectpropCount++;
            }

            if (bodyinternettwitter != null)
            {
                internetObject["twitter"] = ExpressionConverter.ConvertO(bodyinternettwitter);
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
                phonesObject["businessPhone"] = ExpressionConverter.ConvertO(bodyphonesbusinessPhone);
                phonesObjectpropCount++;
            }

            if (bodyphonesmobile != null)
            {
                phonesObject["mobile"] = ExpressionConverter.ConvertO(bodyphonesmobile);
                phonesObjectpropCount++;
            }

            if (bodyphoneshome != null)
            {
                phonesObject["home"] = ExpressionConverter.ConvertO(bodyphoneshome);
                phonesObjectpropCount++;
            }

            if (bodyphonesbusinessFax != null)
            {
                phonesObject["businessFax"] = ExpressionConverter.ConvertO(bodyphonesbusinessFax);
                phonesObjectpropCount++;
            }

            if (phonesObjectpropCount > 0)
            {
                body["phones"] = phonesObject;
                bodypropCount++;
            }

            if (bodyaddresses != null)
            {
                body["addresses"] = ExpressionConverter.ConvertO(bodyaddresses);
                bodypropCount++;
            }

            if (bodynotes != null)
            {
                body["notes"] = ExpressionConverter.ConvertO(bodynotes);
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
            var apiCallPath = String.Format("/{0}/contacts", ExpressionConverter.ConvertWithUrlEncoding(contactListId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Contact[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contactspro")]
        public IBodyWorkflowAction<Contact> CreateContact(Expression<Func<string>> contactListId, Expression<Func<string>> bodyname, Expression<Func<string>> bodygroupId = null, Expression<Func<string>> bodyjobTitle = null, Expression<Func<string>> bodycompany = null, Expression<Func<string>> bodydepartment = null, Expression<Func<string>> bodyinternetemail = null, Expression<Func<string>> bodyinternetwebsite = null, Expression<Func<string>> bodyinternetlinkedin = null, Expression<Func<string>> bodyinternetfacebook = null, Expression<Func<string>> bodyinternettwitter = null, Expression<Func<string>> bodyphonesbusinessPhone = null, Expression<Func<string>> bodyphonesmobile = null, Expression<Func<string>> bodyphoneshome = null, Expression<Func<string>> bodyphonesbusinessFax = null, Expression<Func<Address[]>> bodyaddresses = null, Expression<Func<string>> bodynotes = null)
        {
            var apiCallPath = String.Format("/{0}/contacts", ExpressionConverter.ConvertWithUrlEncoding(contactListId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            if (bodygroupId != null)
            {
                body["groupId"] = ExpressionConverter.ConvertO(bodygroupId);
                bodypropCount++;
            }

            if (bodyjobTitle != null)
            {
                body["jobTitle"] = ExpressionConverter.ConvertO(bodyjobTitle);
                bodypropCount++;
            }

            if (bodycompany != null)
            {
                body["company"] = ExpressionConverter.ConvertO(bodycompany);
                bodypropCount++;
            }

            if (bodydepartment != null)
            {
                body["department"] = ExpressionConverter.ConvertO(bodydepartment);
                bodypropCount++;
            }

            var internetObject = new JObject();
            var internetObjectpropCount = 0;
            if (bodyinternetemail != null)
            {
                internetObject["email"] = ExpressionConverter.ConvertO(bodyinternetemail);
                internetObjectpropCount++;
            }

            if (bodyinternetwebsite != null)
            {
                internetObject["website"] = ExpressionConverter.ConvertO(bodyinternetwebsite);
                internetObjectpropCount++;
            }

            if (bodyinternetlinkedin != null)
            {
                internetObject["linkedin"] = ExpressionConverter.ConvertO(bodyinternetlinkedin);
                internetObjectpropCount++;
            }

            if (bodyinternetfacebook != null)
            {
                internetObject["facebook"] = ExpressionConverter.ConvertO(bodyinternetfacebook);
                internetObjectpropCount++;
            }

            if (bodyinternettwitter != null)
            {
                internetObject["twitter"] = ExpressionConverter.ConvertO(bodyinternettwitter);
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
                phonesObject["businessPhone"] = ExpressionConverter.ConvertO(bodyphonesbusinessPhone);
                phonesObjectpropCount++;
            }

            if (bodyphonesmobile != null)
            {
                phonesObject["mobile"] = ExpressionConverter.ConvertO(bodyphonesmobile);
                phonesObjectpropCount++;
            }

            if (bodyphoneshome != null)
            {
                phonesObject["home"] = ExpressionConverter.ConvertO(bodyphoneshome);
                phonesObjectpropCount++;
            }

            if (bodyphonesbusinessFax != null)
            {
                phonesObject["businessFax"] = ExpressionConverter.ConvertO(bodyphonesbusinessFax);
                phonesObjectpropCount++;
            }

            if (phonesObjectpropCount > 0)
            {
                body["phones"] = phonesObject;
                bodypropCount++;
            }

            if (bodyaddresses != null)
            {
                body["addresses"] = ExpressionConverter.ConvertO(bodyaddresses);
                bodypropCount++;
            }

            if (bodynotes != null)
            {
                body["notes"] = ExpressionConverter.ConvertO(bodynotes);
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
    using Microsoft.Azure.Workflows.Sdk.Contactspro;

    public partial class WorkflowManagedActions
    {
        public ContactsproActions Contactspro(string connectionId) => new ContactsproActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ContactsproTriggers Contactspro(string connectionId) => new ContactsproTriggers(connectionId);
    }
}