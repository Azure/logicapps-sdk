//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Act
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
                contact["fullName"] = CSharpExpressionConverter.ConvertToken(contactfullName);
                contactpropCount++;
            }

            if (contactemailAddress != null)
            {
                contact["emailAddress"] = CSharpExpressionConverter.ConvertToken(contactemailAddress);
                contactpropCount++;
            }

            if (contactcompany != null)
            {
                contact["company"] = CSharpExpressionConverter.ConvertToken(contactcompany);
                contactpropCount++;
            }

            if (contactidStatus != null)
            {
                contact["idStatus"] = CSharpExpressionConverter.ConvertToken(contactidStatus);
                contactpropCount++;
            }

            if (contactreferredBy != null)
            {
                contact["referredBy"] = CSharpExpressionConverter.ConvertToken(contactreferredBy);
                contactpropCount++;
            }

            if (contactjobTitle != null)
            {
                contact["jobTitle"] = CSharpExpressionConverter.ConvertToken(contactjobTitle);
                contactpropCount++;
            }

            if (contactbusinessPhoneNumber != null)
            {
                contact["businessPhone"] = CSharpExpressionConverter.ConvertToken(contactbusinessPhoneNumber);
                contactpropCount++;
            }

            if (contactmobilePhoneNumber != null)
            {
                contact["mobilePhone"] = CSharpExpressionConverter.ConvertToken(contactmobilePhoneNumber);
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
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/Contacts/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(contactid, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ActWebApiModelsContact>(callPayload);
        }
    }

    public class ActTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ActWebApiModelsContact[]> TrigNewContact(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/api/Contacts/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<ActWebApiModelsContact[]>(callPayload, triggerName, recurrence);
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
    using Microsoft.Azure.Workflows.Sdk.Connectors.Act;

    public partial class WorkflowManagedActions
    {
        public ActActions Act(string connectionId) => new ActActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ActTriggers Act(string connectionId) => new ActTriggers(connectionId);
    }
}