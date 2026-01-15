//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Act
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ActActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "act")]
        public IBodyWorkflowAction<ActWebApiModelsContact> CreateContact(Expression<Func<string>> contactfullName = null, Expression<Func<string>> contactemailAddress = null, Expression<Func<string>> contactcompany = null, Expression<Func<string>> contactidStatus = null, Expression<Func<string>> contactreferredBy = null, Expression<Func<string>> contactjobTitle = null, Expression<Func<string>> contactbusinessPhoneNumber = null, Expression<Func<string>> contactmobilePhoneNumber = null)
        {
            var apiCallPath = "/api/Contacts/";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var contact = new JObject();
            var contactpropCount = 0;
            if (contactfullName != null)
            {
                contact["fullName"] = ExpressionConverter.ConvertO(contactfullName);
                contactpropCount++;
            }

            if (contactemailAddress != null)
            {
                contact["emailAddress"] = ExpressionConverter.ConvertO(contactemailAddress);
                contactpropCount++;
            }

            if (contactcompany != null)
            {
                contact["company"] = ExpressionConverter.ConvertO(contactcompany);
                contactpropCount++;
            }

            if (contactidStatus != null)
            {
                contact["idStatus"] = ExpressionConverter.ConvertO(contactidStatus);
                contactpropCount++;
            }

            if (contactreferredBy != null)
            {
                contact["referredBy"] = ExpressionConverter.ConvertO(contactreferredBy);
                contactpropCount++;
            }

            if (contactjobTitle != null)
            {
                contact["jobTitle"] = ExpressionConverter.ConvertO(contactjobTitle);
                contactpropCount++;
            }

            if (contactbusinessPhoneNumber != null)
            {
                contact["businessPhone"] = ExpressionConverter.ConvertO(contactbusinessPhoneNumber);
                contactpropCount++;
            }

            if (contactmobilePhoneNumber != null)
            {
                contact["mobilePhone"] = ExpressionConverter.ConvertO(contactmobilePhoneNumber);
                contactpropCount++;
            }

            var customFieldsObject = new JObject();
            var customFieldsObjectpropCount = 0;
            if (customFieldsObjectpropCount > 0)
            {
                contact["customFields"] = customFieldsObject;
                contactpropCount++;
            }

            if (contactpropCount > 0)
            {
                callPayload.Body = contact;
            }

            return new ApiConnectionAction<ActWebApiModelsContact>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "act")]
        public IBodyWorkflowAction<ActWebApiModelsContact> GetContact(Expression<Func<string>> contactid)
        {
            var apiCallPath = String.Format("/api/Contacts/{0}", ExpressionConverter.ConvertWithUrlEncoding(contactid, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ActWebApiModelsContact>(callPayload);
        }
    }

    public class ActTriggers([ConnectionName] string connectionId)
    {
        public IOutputWorkflowTrigger<ActWebApiModelsContact[]> TrigNewContact()
        {
            var apiCallPath = "/trigger/api/Contacts/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<ActWebApiModelsContact[]>(callPayload);
        }
    }

    public class ActWebApiModelsContact
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("idStatus")]
        public string IdStatus { get; set; }

        [JsonProperty("referredBy")]
        public string ReferredBy { get; set; }

        [JsonProperty("jobTitle")]
        public string JobTitle { get; set; }

        [JsonProperty("businessPhone")]
        public string BusinessPhoneNumber { get; set; }

        [JsonProperty("mobilePhone")]
        public string MobilePhoneNumber { get; set; }

        [JsonProperty("customFields")]
        public JToken CustomFields { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Act;

    public partial class WorkflowManagedActions
    {
        public ActActions Act(string connectionId) => new ActActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ActTriggers Act(string connectionId) => new ActTriggers(connectionId);
    }
}