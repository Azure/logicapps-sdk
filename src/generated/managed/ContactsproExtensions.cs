//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Contactspro
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class ContactsproActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contactspro")]
        public IBodyWorkflowAction<Contact> GetContact(Expression<Func<string>> contactListId, Expression<Func<string>> contactId)
        {
            var __workflow_contactListId = WorkflowExpression.Compile(contactListId, nameof(contactListId), required: true);
            var __workflow_contactId = WorkflowExpression.Compile(contactId, nameof(contactId), required: true);
            return new DeferredBodyAction<Contact>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/contacts/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_contactListId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_contactId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Contact>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contactspro")]
        public IWorkflowAction DeleteContact(Expression<Func<string>> contactListId, Expression<Func<string>> contactId)
        {
            var __workflow_contactListId = WorkflowExpression.Compile(contactListId, nameof(contactListId), required: true);
            var __workflow_contactId = WorkflowExpression.Compile(contactId, nameof(contactId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/contacts/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_contactListId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_contactId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contactspro")]
        public IBodyWorkflowAction<Contact> UpdateContact(Expression<Func<string>> contactListId, Expression<Func<string>> contactId, Expression<Func<string>> bodyname, Expression<Func<string>> bodygroupId = null, Expression<Func<string>> bodyjobTitle = null, Expression<Func<string>> bodycompany = null, Expression<Func<string>> bodydepartment = null, Expression<Func<string>> bodyinternetemail = null, Expression<Func<string>> bodyinternetwebsite = null, Expression<Func<string>> bodyinternetlinkedin = null, Expression<Func<string>> bodyinternetfacebook = null, Expression<Func<string>> bodyinternettwitter = null, Expression<Func<string>> bodyphonesbusinessPhone = null, Expression<Func<string>> bodyphonesmobile = null, Expression<Func<string>> bodyphoneshome = null, Expression<Func<string>> bodyphonesbusinessFax = null, Expression<Func<Address[]>> bodyaddresses = null, Expression<Func<string>> bodynotes = null)
        {
            var __workflow_contactListId = WorkflowExpression.Compile(contactListId, nameof(contactListId), required: true);
            var __workflow_contactId = WorkflowExpression.Compile(contactId, nameof(contactId), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodygroupId = WorkflowExpression.Compile(bodygroupId, nameof(bodygroupId), required: false);
            var __workflow_bodyjobTitle = WorkflowExpression.Compile(bodyjobTitle, nameof(bodyjobTitle), required: false);
            var __workflow_bodycompany = WorkflowExpression.Compile(bodycompany, nameof(bodycompany), required: false);
            var __workflow_bodydepartment = WorkflowExpression.Compile(bodydepartment, nameof(bodydepartment), required: false);
            var __workflow_bodyinternetemail = WorkflowExpression.Compile(bodyinternetemail, nameof(bodyinternetemail), required: false);
            var __workflow_bodyinternetwebsite = WorkflowExpression.Compile(bodyinternetwebsite, nameof(bodyinternetwebsite), required: false);
            var __workflow_bodyinternetlinkedin = WorkflowExpression.Compile(bodyinternetlinkedin, nameof(bodyinternetlinkedin), required: false);
            var __workflow_bodyinternetfacebook = WorkflowExpression.Compile(bodyinternetfacebook, nameof(bodyinternetfacebook), required: false);
            var __workflow_bodyinternettwitter = WorkflowExpression.Compile(bodyinternettwitter, nameof(bodyinternettwitter), required: false);
            var __workflow_bodyphonesbusinessPhone = WorkflowExpression.Compile(bodyphonesbusinessPhone, nameof(bodyphonesbusinessPhone), required: false);
            var __workflow_bodyphonesmobile = WorkflowExpression.Compile(bodyphonesmobile, nameof(bodyphonesmobile), required: false);
            var __workflow_bodyphoneshome = WorkflowExpression.Compile(bodyphoneshome, nameof(bodyphoneshome), required: false);
            var __workflow_bodyphonesbusinessFax = WorkflowExpression.Compile(bodyphonesbusinessFax, nameof(bodyphonesbusinessFax), required: false);
            var __workflow_bodyaddresses = WorkflowExpression.Compile(bodyaddresses, nameof(bodyaddresses), required: false);
            var __workflow_bodynotes = WorkflowExpression.Compile(bodynotes, nameof(bodynotes), required: false);
            return new DeferredBodyAction<Contact>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/contacts/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_contactListId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_contactId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                if (__workflow_bodygroupId != null)
                {
                    body["groupId"] = ExpressionConverter.ConvertO(__workflow_bodygroupId);
                    bodypropCount++;
                }

                if (__workflow_bodyjobTitle != null)
                {
                    body["jobTitle"] = ExpressionConverter.ConvertO(__workflow_bodyjobTitle);
                    bodypropCount++;
                }

                if (__workflow_bodycompany != null)
                {
                    body["company"] = ExpressionConverter.ConvertO(__workflow_bodycompany);
                    bodypropCount++;
                }

                if (__workflow_bodydepartment != null)
                {
                    body["department"] = ExpressionConverter.ConvertO(__workflow_bodydepartment);
                    bodypropCount++;
                }

                var internetObject = new JObject();
                var internetObjectpropCount = 0;
                if (__workflow_bodyinternetemail != null)
                {
                    internetObject["email"] = ExpressionConverter.ConvertO(__workflow_bodyinternetemail);
                    internetObjectpropCount++;
                }

                if (__workflow_bodyinternetwebsite != null)
                {
                    internetObject["website"] = ExpressionConverter.ConvertO(__workflow_bodyinternetwebsite);
                    internetObjectpropCount++;
                }

                if (__workflow_bodyinternetlinkedin != null)
                {
                    internetObject["linkedin"] = ExpressionConverter.ConvertO(__workflow_bodyinternetlinkedin);
                    internetObjectpropCount++;
                }

                if (__workflow_bodyinternetfacebook != null)
                {
                    internetObject["facebook"] = ExpressionConverter.ConvertO(__workflow_bodyinternetfacebook);
                    internetObjectpropCount++;
                }

                if (__workflow_bodyinternettwitter != null)
                {
                    internetObject["twitter"] = ExpressionConverter.ConvertO(__workflow_bodyinternettwitter);
                    internetObjectpropCount++;
                }

                if (internetObjectpropCount > 0)
                {
                    body["internet"] = internetObject;
                    bodypropCount++;
                }

                var phonesObject = new JObject();
                var phonesObjectpropCount = 0;
                if (__workflow_bodyphonesbusinessPhone != null)
                {
                    phonesObject["businessPhone"] = ExpressionConverter.ConvertO(__workflow_bodyphonesbusinessPhone);
                    phonesObjectpropCount++;
                }

                if (__workflow_bodyphonesmobile != null)
                {
                    phonesObject["mobile"] = ExpressionConverter.ConvertO(__workflow_bodyphonesmobile);
                    phonesObjectpropCount++;
                }

                if (__workflow_bodyphoneshome != null)
                {
                    phonesObject["home"] = ExpressionConverter.ConvertO(__workflow_bodyphoneshome);
                    phonesObjectpropCount++;
                }

                if (__workflow_bodyphonesbusinessFax != null)
                {
                    phonesObject["businessFax"] = ExpressionConverter.ConvertO(__workflow_bodyphonesbusinessFax);
                    phonesObjectpropCount++;
                }

                if (phonesObjectpropCount > 0)
                {
                    body["phones"] = phonesObject;
                    bodypropCount++;
                }

                if (__workflow_bodyaddresses != null)
                {
                    body["addresses"] = ExpressionConverter.ConvertO(__workflow_bodyaddresses);
                    bodypropCount++;
                }

                if (__workflow_bodynotes != null)
                {
                    body["notes"] = ExpressionConverter.ConvertO(__workflow_bodynotes);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Contact>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contactspro")]
        public IBodyWorkflowAction<Contact[]> GetAllContacts(Expression<Func<string>> contactListId)
        {
            var __workflow_contactListId = WorkflowExpression.Compile(contactListId, nameof(contactListId), required: true);
            return new DeferredBodyAction<Contact[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/contacts", ExpressionConverter.ConvertWithUrlEncoding(__workflow_contactListId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Contact[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contactspro")]
        public IBodyWorkflowAction<Contact> CreateContact(Expression<Func<string>> contactListId, Expression<Func<string>> bodyname, Expression<Func<string>> bodygroupId = null, Expression<Func<string>> bodyjobTitle = null, Expression<Func<string>> bodycompany = null, Expression<Func<string>> bodydepartment = null, Expression<Func<string>> bodyinternetemail = null, Expression<Func<string>> bodyinternetwebsite = null, Expression<Func<string>> bodyinternetlinkedin = null, Expression<Func<string>> bodyinternetfacebook = null, Expression<Func<string>> bodyinternettwitter = null, Expression<Func<string>> bodyphonesbusinessPhone = null, Expression<Func<string>> bodyphonesmobile = null, Expression<Func<string>> bodyphoneshome = null, Expression<Func<string>> bodyphonesbusinessFax = null, Expression<Func<Address[]>> bodyaddresses = null, Expression<Func<string>> bodynotes = null)
        {
            var __workflow_contactListId = WorkflowExpression.Compile(contactListId, nameof(contactListId), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodygroupId = WorkflowExpression.Compile(bodygroupId, nameof(bodygroupId), required: false);
            var __workflow_bodyjobTitle = WorkflowExpression.Compile(bodyjobTitle, nameof(bodyjobTitle), required: false);
            var __workflow_bodycompany = WorkflowExpression.Compile(bodycompany, nameof(bodycompany), required: false);
            var __workflow_bodydepartment = WorkflowExpression.Compile(bodydepartment, nameof(bodydepartment), required: false);
            var __workflow_bodyinternetemail = WorkflowExpression.Compile(bodyinternetemail, nameof(bodyinternetemail), required: false);
            var __workflow_bodyinternetwebsite = WorkflowExpression.Compile(bodyinternetwebsite, nameof(bodyinternetwebsite), required: false);
            var __workflow_bodyinternetlinkedin = WorkflowExpression.Compile(bodyinternetlinkedin, nameof(bodyinternetlinkedin), required: false);
            var __workflow_bodyinternetfacebook = WorkflowExpression.Compile(bodyinternetfacebook, nameof(bodyinternetfacebook), required: false);
            var __workflow_bodyinternettwitter = WorkflowExpression.Compile(bodyinternettwitter, nameof(bodyinternettwitter), required: false);
            var __workflow_bodyphonesbusinessPhone = WorkflowExpression.Compile(bodyphonesbusinessPhone, nameof(bodyphonesbusinessPhone), required: false);
            var __workflow_bodyphonesmobile = WorkflowExpression.Compile(bodyphonesmobile, nameof(bodyphonesmobile), required: false);
            var __workflow_bodyphoneshome = WorkflowExpression.Compile(bodyphoneshome, nameof(bodyphoneshome), required: false);
            var __workflow_bodyphonesbusinessFax = WorkflowExpression.Compile(bodyphonesbusinessFax, nameof(bodyphonesbusinessFax), required: false);
            var __workflow_bodyaddresses = WorkflowExpression.Compile(bodyaddresses, nameof(bodyaddresses), required: false);
            var __workflow_bodynotes = WorkflowExpression.Compile(bodynotes, nameof(bodynotes), required: false);
            return new DeferredBodyAction<Contact>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/contacts", ExpressionConverter.ConvertWithUrlEncoding(__workflow_contactListId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                if (__workflow_bodygroupId != null)
                {
                    body["groupId"] = ExpressionConverter.ConvertO(__workflow_bodygroupId);
                    bodypropCount++;
                }

                if (__workflow_bodyjobTitle != null)
                {
                    body["jobTitle"] = ExpressionConverter.ConvertO(__workflow_bodyjobTitle);
                    bodypropCount++;
                }

                if (__workflow_bodycompany != null)
                {
                    body["company"] = ExpressionConverter.ConvertO(__workflow_bodycompany);
                    bodypropCount++;
                }

                if (__workflow_bodydepartment != null)
                {
                    body["department"] = ExpressionConverter.ConvertO(__workflow_bodydepartment);
                    bodypropCount++;
                }

                var internetObject = new JObject();
                var internetObjectpropCount = 0;
                if (__workflow_bodyinternetemail != null)
                {
                    internetObject["email"] = ExpressionConverter.ConvertO(__workflow_bodyinternetemail);
                    internetObjectpropCount++;
                }

                if (__workflow_bodyinternetwebsite != null)
                {
                    internetObject["website"] = ExpressionConverter.ConvertO(__workflow_bodyinternetwebsite);
                    internetObjectpropCount++;
                }

                if (__workflow_bodyinternetlinkedin != null)
                {
                    internetObject["linkedin"] = ExpressionConverter.ConvertO(__workflow_bodyinternetlinkedin);
                    internetObjectpropCount++;
                }

                if (__workflow_bodyinternetfacebook != null)
                {
                    internetObject["facebook"] = ExpressionConverter.ConvertO(__workflow_bodyinternetfacebook);
                    internetObjectpropCount++;
                }

                if (__workflow_bodyinternettwitter != null)
                {
                    internetObject["twitter"] = ExpressionConverter.ConvertO(__workflow_bodyinternettwitter);
                    internetObjectpropCount++;
                }

                if (internetObjectpropCount > 0)
                {
                    body["internet"] = internetObject;
                    bodypropCount++;
                }

                var phonesObject = new JObject();
                var phonesObjectpropCount = 0;
                if (__workflow_bodyphonesbusinessPhone != null)
                {
                    phonesObject["businessPhone"] = ExpressionConverter.ConvertO(__workflow_bodyphonesbusinessPhone);
                    phonesObjectpropCount++;
                }

                if (__workflow_bodyphonesmobile != null)
                {
                    phonesObject["mobile"] = ExpressionConverter.ConvertO(__workflow_bodyphonesmobile);
                    phonesObjectpropCount++;
                }

                if (__workflow_bodyphoneshome != null)
                {
                    phonesObject["home"] = ExpressionConverter.ConvertO(__workflow_bodyphoneshome);
                    phonesObjectpropCount++;
                }

                if (__workflow_bodyphonesbusinessFax != null)
                {
                    phonesObject["businessFax"] = ExpressionConverter.ConvertO(__workflow_bodyphonesbusinessFax);
                    phonesObjectpropCount++;
                }

                if (phonesObjectpropCount > 0)
                {
                    body["phones"] = phonesObject;
                    bodypropCount++;
                }

                if (__workflow_bodyaddresses != null)
                {
                    body["addresses"] = ExpressionConverter.ConvertO(__workflow_bodyaddresses);
                    bodypropCount++;
                }

                if (__workflow_bodynotes != null)
                {
                    body["notes"] = ExpressionConverter.ConvertO(__workflow_bodynotes);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Contact>(callPayload);
            });
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
