//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Act
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ActActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "act")]
        [WorkflowExpressionFactory(nameof(__BuildCreateContact))]
        public IBodyWorkflowAction<ActWebApiModelsContact> CreateContact([WorkflowExpression] Func<string> contactfullName = null, [WorkflowExpression] Func<string> contactemailAddress = null, [WorkflowExpression] Func<string> contactcompany = null, [WorkflowExpression] Func<string> contactidStatus = null, [WorkflowExpression] Func<string> contactreferredBy = null, [WorkflowExpression] Func<string> contactjobTitle = null, [WorkflowExpression] Func<string> contactbusinessPhoneNumber = null, [WorkflowExpression] Func<string> contactmobilePhoneNumber = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ActWebApiModelsContact> __BuildCreateContact(WorkflowValue<string> contactfullName = null, WorkflowValue<string> contactemailAddress = null, WorkflowValue<string> contactcompany = null, WorkflowValue<string> contactidStatus = null, WorkflowValue<string> contactreferredBy = null, WorkflowValue<string> contactjobTitle = null, WorkflowValue<string> contactbusinessPhoneNumber = null, WorkflowValue<string> contactmobilePhoneNumber = null)
        {
            WorkflowValue.Validate(contactfullName, nameof(contactfullName), required: false);
            WorkflowValue.Validate(contactemailAddress, nameof(contactemailAddress), required: false);
            WorkflowValue.Validate(contactcompany, nameof(contactcompany), required: false);
            WorkflowValue.Validate(contactidStatus, nameof(contactidStatus), required: false);
            WorkflowValue.Validate(contactreferredBy, nameof(contactreferredBy), required: false);
            WorkflowValue.Validate(contactjobTitle, nameof(contactjobTitle), required: false);
            WorkflowValue.Validate(contactbusinessPhoneNumber, nameof(contactbusinessPhoneNumber), required: false);
            WorkflowValue.Validate(contactmobilePhoneNumber, nameof(contactmobilePhoneNumber), required: false);
            return new DeferredBodyAction<ActWebApiModelsContact>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "act")]
        [WorkflowExpressionFactory(nameof(__BuildGetContact))]
        public IBodyWorkflowAction<ActWebApiModelsContact> GetContact([WorkflowExpression] Func<string> contactid)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ActWebApiModelsContact> __BuildGetContact(WorkflowValue<string> contactid)
        {
            WorkflowValue.Validate(contactid, nameof(contactid), required: true);
            return new DeferredBodyAction<ActWebApiModelsContact>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/Contacts/{0}", ExpressionConverter.ConvertWithUrlEncoding(contactid, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ActWebApiModelsContact>(callPayload);
            });
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
