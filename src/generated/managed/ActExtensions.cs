//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Act
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class ActActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "act")]
        public IBodyWorkflowAction<ActWebApiModelsContact> CreateContact(Expression<Func<string>> contactfullName = null, Expression<Func<string>> contactemailAddress = null, Expression<Func<string>> contactcompany = null, Expression<Func<string>> contactidStatus = null, Expression<Func<string>> contactreferredBy = null, Expression<Func<string>> contactjobTitle = null, Expression<Func<string>> contactbusinessPhoneNumber = null, Expression<Func<string>> contactmobilePhoneNumber = null)
        {
            var __workflow_contactfullName = contactfullName == null ? null : WorkflowExpression.Compile(contactfullName);
            WorkflowExpression.Validate(__workflow_contactfullName, nameof(contactfullName), required: false);
            var __workflow_contactemailAddress = contactemailAddress == null ? null : WorkflowExpression.Compile(contactemailAddress);
            WorkflowExpression.Validate(__workflow_contactemailAddress, nameof(contactemailAddress), required: false);
            var __workflow_contactcompany = contactcompany == null ? null : WorkflowExpression.Compile(contactcompany);
            WorkflowExpression.Validate(__workflow_contactcompany, nameof(contactcompany), required: false);
            var __workflow_contactidStatus = contactidStatus == null ? null : WorkflowExpression.Compile(contactidStatus);
            WorkflowExpression.Validate(__workflow_contactidStatus, nameof(contactidStatus), required: false);
            var __workflow_contactreferredBy = contactreferredBy == null ? null : WorkflowExpression.Compile(contactreferredBy);
            WorkflowExpression.Validate(__workflow_contactreferredBy, nameof(contactreferredBy), required: false);
            var __workflow_contactjobTitle = contactjobTitle == null ? null : WorkflowExpression.Compile(contactjobTitle);
            WorkflowExpression.Validate(__workflow_contactjobTitle, nameof(contactjobTitle), required: false);
            var __workflow_contactbusinessPhoneNumber = contactbusinessPhoneNumber == null ? null : WorkflowExpression.Compile(contactbusinessPhoneNumber);
            WorkflowExpression.Validate(__workflow_contactbusinessPhoneNumber, nameof(contactbusinessPhoneNumber), required: false);
            var __workflow_contactmobilePhoneNumber = contactmobilePhoneNumber == null ? null : WorkflowExpression.Compile(contactmobilePhoneNumber);
            WorkflowExpression.Validate(__workflow_contactmobilePhoneNumber, nameof(contactmobilePhoneNumber), required: false);
            return new DeferredBodyAction<ActWebApiModelsContact>(() =>
            {
                var apiCallPath = "/api/Contacts/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var contact = new JObject();
                var contactpropCount = 0;
                if (__workflow_contactfullName != null)
                {
                    contact["fullName"] = ExpressionConverter.ConvertO(__workflow_contactfullName);
                    contactpropCount++;
                }

                if (__workflow_contactemailAddress != null)
                {
                    contact["emailAddress"] = ExpressionConverter.ConvertO(__workflow_contactemailAddress);
                    contactpropCount++;
                }

                if (__workflow_contactcompany != null)
                {
                    contact["company"] = ExpressionConverter.ConvertO(__workflow_contactcompany);
                    contactpropCount++;
                }

                if (__workflow_contactidStatus != null)
                {
                    contact["idStatus"] = ExpressionConverter.ConvertO(__workflow_contactidStatus);
                    contactpropCount++;
                }

                if (__workflow_contactreferredBy != null)
                {
                    contact["referredBy"] = ExpressionConverter.ConvertO(__workflow_contactreferredBy);
                    contactpropCount++;
                }

                if (__workflow_contactjobTitle != null)
                {
                    contact["jobTitle"] = ExpressionConverter.ConvertO(__workflow_contactjobTitle);
                    contactpropCount++;
                }

                if (__workflow_contactbusinessPhoneNumber != null)
                {
                    contact["businessPhone"] = ExpressionConverter.ConvertO(__workflow_contactbusinessPhoneNumber);
                    contactpropCount++;
                }

                if (__workflow_contactmobilePhoneNumber != null)
                {
                    contact["mobilePhone"] = ExpressionConverter.ConvertO(__workflow_contactmobilePhoneNumber);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "act")]
        public IBodyWorkflowAction<ActWebApiModelsContact> GetContact(Expression<Func<string>> contactid)
        {
            var __workflow_contactid = contactid == null ? null : WorkflowExpression.Compile(contactid);
            WorkflowExpression.Validate(__workflow_contactid, nameof(contactid), required: true);
            return new DeferredBodyAction<ActWebApiModelsContact>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/Contacts/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_contactid, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ActWebApiModelsContact>(callPayload);
            });
        }
    }

    public class ActTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ActWebApiModelsContact[]> TrigNewContact(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/api/Contacts/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<ActWebApiModelsContact[]>(callPayload, recurrence: recurrence);
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
