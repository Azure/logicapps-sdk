//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Act
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ActActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "act")]
        public IBodyWorkflowAction<ActWebApiModelsContact, ApiConnectionActionConfiguration> CreateContact(Expression<Func<string>> contactfullName = null, Expression<Func<string>> contactemailAddress = null, Expression<Func<string>> contactcompany = null, Expression<Func<string>> contactidStatus = null, Expression<Func<string>> contactreferredBy = null, Expression<Func<string>> contactjobTitle = null, Expression<Func<string>> contactbusinessPhoneNumber = null, Expression<Func<string>> contactmobilePhoneNumber = null)
        {
            var __workflow_contactfullName = WorkflowExpression.Compile(contactfullName, nameof(contactfullName), required: false);
            var __workflow_contactemailAddress = WorkflowExpression.Compile(contactemailAddress, nameof(contactemailAddress), required: false);
            var __workflow_contactcompany = WorkflowExpression.Compile(contactcompany, nameof(contactcompany), required: false);
            var __workflow_contactidStatus = WorkflowExpression.Compile(contactidStatus, nameof(contactidStatus), required: false);
            var __workflow_contactreferredBy = WorkflowExpression.Compile(contactreferredBy, nameof(contactreferredBy), required: false);
            var __workflow_contactjobTitle = WorkflowExpression.Compile(contactjobTitle, nameof(contactjobTitle), required: false);
            var __workflow_contactbusinessPhoneNumber = WorkflowExpression.Compile(contactbusinessPhoneNumber, nameof(contactbusinessPhoneNumber), required: false);
            var __workflow_contactmobilePhoneNumber = WorkflowExpression.Compile(contactmobilePhoneNumber, nameof(contactmobilePhoneNumber), required: false);
            return new DeferredBodyAction<ActWebApiModelsContact, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<ActWebApiModelsContact, ApiConnectionActionConfiguration> GetContact(Expression<Func<string>> contactid)
        {
            var __workflow_contactid = WorkflowExpression.Compile(contactid, nameof(contactid), required: true);
            return new DeferredBodyAction<ActWebApiModelsContact, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/Contacts/{0}", __workflow_contactid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ActWebApiModelsContact>(callPayload);
            });
        }
    }

    public class ActTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ActWebApiModelsContact[], ApiConnectionTriggerConfiguration> TrigNewContact(FlowRecurrence recurrence = null)
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
