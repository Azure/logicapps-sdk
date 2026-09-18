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
        public IBodyWorkflowAction<Contact> GetContact([WorkflowExpression] Func<string> contactListId, [WorkflowExpression] Func<string> contactId)
        {
            SourceExpression.Validate(contactListId, nameof(contactListId), required: true);
            SourceExpression.Validate(contactId, nameof(contactId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/contacts/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(contactListId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(contactId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Contact>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contactspro")]
        public IWorkflowAction DeleteContact([WorkflowExpression] Func<string> contactListId, [WorkflowExpression] Func<string> contactId)
        {
            SourceExpression.Validate(contactListId, nameof(contactListId), required: true);
            SourceExpression.Validate(contactId, nameof(contactId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/contacts/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(contactListId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(contactId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contactspro")]
        public IBodyWorkflowAction<Contact> UpdateContact([WorkflowExpression] Func<string> contactListId, [WorkflowExpression] Func<string> contactId, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodygroupId = null, [WorkflowExpression] Func<string> bodyjobTitle = null, [WorkflowExpression] Func<string> bodycompany = null, [WorkflowExpression] Func<string> bodydepartment = null, [WorkflowExpression] Func<string> bodyinternetemail = null, [WorkflowExpression] Func<string> bodyinternetwebsite = null, [WorkflowExpression] Func<string> bodyinternetlinkedin = null, [WorkflowExpression] Func<string> bodyinternetfacebook = null, [WorkflowExpression] Func<string> bodyinternettwitter = null, [WorkflowExpression] Func<string> bodyphonesbusinessPhone = null, [WorkflowExpression] Func<string> bodyphonesmobile = null, [WorkflowExpression] Func<string> bodyphoneshome = null, [WorkflowExpression] Func<string> bodyphonesbusinessFax = null, [WorkflowExpression] Func<Address[]> bodyaddresses = null, [WorkflowExpression] Func<string> bodynotes = null)
        {
            SourceExpression.Validate(contactListId, nameof(contactListId), required: true);
            SourceExpression.Validate(contactId, nameof(contactId), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            SourceExpression.Validate(bodygroupId, nameof(bodygroupId), required: false);
            SourceExpression.Validate(bodyjobTitle, nameof(bodyjobTitle), required: false);
            SourceExpression.Validate(bodycompany, nameof(bodycompany), required: false);
            SourceExpression.Validate(bodydepartment, nameof(bodydepartment), required: false);
            SourceExpression.Validate(bodyinternetemail, nameof(bodyinternetemail), required: false);
            SourceExpression.Validate(bodyinternetwebsite, nameof(bodyinternetwebsite), required: false);
            SourceExpression.Validate(bodyinternetlinkedin, nameof(bodyinternetlinkedin), required: false);
            SourceExpression.Validate(bodyinternetfacebook, nameof(bodyinternetfacebook), required: false);
            SourceExpression.Validate(bodyinternettwitter, nameof(bodyinternettwitter), required: false);
            SourceExpression.Validate(bodyphonesbusinessPhone, nameof(bodyphonesbusinessPhone), required: false);
            SourceExpression.Validate(bodyphonesmobile, nameof(bodyphonesmobile), required: false);
            SourceExpression.Validate(bodyphoneshome, nameof(bodyphoneshome), required: false);
            SourceExpression.Validate(bodyphonesbusinessFax, nameof(bodyphonesbusinessFax), required: false);
            SourceExpression.Validate(bodyaddresses, nameof(bodyaddresses), required: false);
            SourceExpression.Validate(bodynotes, nameof(bodynotes), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/contacts/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(contactListId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(contactId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                if (bodygroupId != null)
                {
                    body["groupId"] = SourceExpressionConverter.ConvertToken(bodygroupId);
                    bodypropCount++;
                }

                if (bodyjobTitle != null)
                {
                    body["jobTitle"] = SourceExpressionConverter.ConvertToken(bodyjobTitle);
                    bodypropCount++;
                }

                if (bodycompany != null)
                {
                    body["company"] = SourceExpressionConverter.ConvertToken(bodycompany);
                    bodypropCount++;
                }

                if (bodydepartment != null)
                {
                    body["department"] = SourceExpressionConverter.ConvertToken(bodydepartment);
                    bodypropCount++;
                }

                var internetObject = new JObject();
                var internetObjectpropCount = 0;
                if (bodyinternetemail != null)
                {
                    internetObject["email"] = SourceExpressionConverter.ConvertToken(bodyinternetemail);
                    internetObjectpropCount++;
                }

                if (bodyinternetwebsite != null)
                {
                    internetObject["website"] = SourceExpressionConverter.ConvertToken(bodyinternetwebsite);
                    internetObjectpropCount++;
                }

                if (bodyinternetlinkedin != null)
                {
                    internetObject["linkedin"] = SourceExpressionConverter.ConvertToken(bodyinternetlinkedin);
                    internetObjectpropCount++;
                }

                if (bodyinternetfacebook != null)
                {
                    internetObject["facebook"] = SourceExpressionConverter.ConvertToken(bodyinternetfacebook);
                    internetObjectpropCount++;
                }

                if (bodyinternettwitter != null)
                {
                    internetObject["twitter"] = SourceExpressionConverter.ConvertToken(bodyinternettwitter);
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
                    phonesObject["businessPhone"] = SourceExpressionConverter.ConvertToken(bodyphonesbusinessPhone);
                    phonesObjectpropCount++;
                }

                if (bodyphonesmobile != null)
                {
                    phonesObject["mobile"] = SourceExpressionConverter.ConvertToken(bodyphonesmobile);
                    phonesObjectpropCount++;
                }

                if (bodyphoneshome != null)
                {
                    phonesObject["home"] = SourceExpressionConverter.ConvertToken(bodyphoneshome);
                    phonesObjectpropCount++;
                }

                if (bodyphonesbusinessFax != null)
                {
                    phonesObject["businessFax"] = SourceExpressionConverter.ConvertToken(bodyphonesbusinessFax);
                    phonesObjectpropCount++;
                }

                if (phonesObjectpropCount > 0)
                {
                    body["phones"] = phonesObject;
                    bodypropCount++;
                }

                if (bodyaddresses != null)
                {
                    body["addresses"] = SourceExpressionConverter.ConvertToken(bodyaddresses);
                    bodypropCount++;
                }

                if (bodynotes != null)
                {
                    body["notes"] = SourceExpressionConverter.ConvertToken(bodynotes);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Contact>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contactspro")]
        public IBodyWorkflowAction<Contact[]> GetAllContacts([WorkflowExpression] Func<string> contactListId)
        {
            SourceExpression.Validate(contactListId, nameof(contactListId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/contacts", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(contactListId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Contact[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contactspro")]
        public IBodyWorkflowAction<Contact> CreateContact([WorkflowExpression] Func<string> contactListId, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodygroupId = null, [WorkflowExpression] Func<string> bodyjobTitle = null, [WorkflowExpression] Func<string> bodycompany = null, [WorkflowExpression] Func<string> bodydepartment = null, [WorkflowExpression] Func<string> bodyinternetemail = null, [WorkflowExpression] Func<string> bodyinternetwebsite = null, [WorkflowExpression] Func<string> bodyinternetlinkedin = null, [WorkflowExpression] Func<string> bodyinternetfacebook = null, [WorkflowExpression] Func<string> bodyinternettwitter = null, [WorkflowExpression] Func<string> bodyphonesbusinessPhone = null, [WorkflowExpression] Func<string> bodyphonesmobile = null, [WorkflowExpression] Func<string> bodyphoneshome = null, [WorkflowExpression] Func<string> bodyphonesbusinessFax = null, [WorkflowExpression] Func<Address[]> bodyaddresses = null, [WorkflowExpression] Func<string> bodynotes = null)
        {
            SourceExpression.Validate(contactListId, nameof(contactListId), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            SourceExpression.Validate(bodygroupId, nameof(bodygroupId), required: false);
            SourceExpression.Validate(bodyjobTitle, nameof(bodyjobTitle), required: false);
            SourceExpression.Validate(bodycompany, nameof(bodycompany), required: false);
            SourceExpression.Validate(bodydepartment, nameof(bodydepartment), required: false);
            SourceExpression.Validate(bodyinternetemail, nameof(bodyinternetemail), required: false);
            SourceExpression.Validate(bodyinternetwebsite, nameof(bodyinternetwebsite), required: false);
            SourceExpression.Validate(bodyinternetlinkedin, nameof(bodyinternetlinkedin), required: false);
            SourceExpression.Validate(bodyinternetfacebook, nameof(bodyinternetfacebook), required: false);
            SourceExpression.Validate(bodyinternettwitter, nameof(bodyinternettwitter), required: false);
            SourceExpression.Validate(bodyphonesbusinessPhone, nameof(bodyphonesbusinessPhone), required: false);
            SourceExpression.Validate(bodyphonesmobile, nameof(bodyphonesmobile), required: false);
            SourceExpression.Validate(bodyphoneshome, nameof(bodyphoneshome), required: false);
            SourceExpression.Validate(bodyphonesbusinessFax, nameof(bodyphonesbusinessFax), required: false);
            SourceExpression.Validate(bodyaddresses, nameof(bodyaddresses), required: false);
            SourceExpression.Validate(bodynotes, nameof(bodynotes), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/contacts", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(contactListId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                if (bodygroupId != null)
                {
                    body["groupId"] = SourceExpressionConverter.ConvertToken(bodygroupId);
                    bodypropCount++;
                }

                if (bodyjobTitle != null)
                {
                    body["jobTitle"] = SourceExpressionConverter.ConvertToken(bodyjobTitle);
                    bodypropCount++;
                }

                if (bodycompany != null)
                {
                    body["company"] = SourceExpressionConverter.ConvertToken(bodycompany);
                    bodypropCount++;
                }

                if (bodydepartment != null)
                {
                    body["department"] = SourceExpressionConverter.ConvertToken(bodydepartment);
                    bodypropCount++;
                }

                var internetObject = new JObject();
                var internetObjectpropCount = 0;
                if (bodyinternetemail != null)
                {
                    internetObject["email"] = SourceExpressionConverter.ConvertToken(bodyinternetemail);
                    internetObjectpropCount++;
                }

                if (bodyinternetwebsite != null)
                {
                    internetObject["website"] = SourceExpressionConverter.ConvertToken(bodyinternetwebsite);
                    internetObjectpropCount++;
                }

                if (bodyinternetlinkedin != null)
                {
                    internetObject["linkedin"] = SourceExpressionConverter.ConvertToken(bodyinternetlinkedin);
                    internetObjectpropCount++;
                }

                if (bodyinternetfacebook != null)
                {
                    internetObject["facebook"] = SourceExpressionConverter.ConvertToken(bodyinternetfacebook);
                    internetObjectpropCount++;
                }

                if (bodyinternettwitter != null)
                {
                    internetObject["twitter"] = SourceExpressionConverter.ConvertToken(bodyinternettwitter);
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
                    phonesObject["businessPhone"] = SourceExpressionConverter.ConvertToken(bodyphonesbusinessPhone);
                    phonesObjectpropCount++;
                }

                if (bodyphonesmobile != null)
                {
                    phonesObject["mobile"] = SourceExpressionConverter.ConvertToken(bodyphonesmobile);
                    phonesObjectpropCount++;
                }

                if (bodyphoneshome != null)
                {
                    phonesObject["home"] = SourceExpressionConverter.ConvertToken(bodyphoneshome);
                    phonesObjectpropCount++;
                }

                if (bodyphonesbusinessFax != null)
                {
                    phonesObject["businessFax"] = SourceExpressionConverter.ConvertToken(bodyphonesbusinessFax);
                    phonesObjectpropCount++;
                }

                if (phonesObjectpropCount > 0)
                {
                    body["phones"] = phonesObject;
                    bodypropCount++;
                }

                if (bodyaddresses != null)
                {
                    body["addresses"] = SourceExpressionConverter.ConvertToken(bodyaddresses);
                    bodypropCount++;
                }

                if (bodynotes != null)
                {
                    body["notes"] = SourceExpressionConverter.ConvertToken(bodynotes);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Contact>(BuildSourceInput);
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