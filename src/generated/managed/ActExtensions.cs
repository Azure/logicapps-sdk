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
        public IBodyWorkflowAction<ActWebApiModelsContact> CreateContact([WorkflowExpression] Func<string> contactfullName = null, [WorkflowExpression] Func<string> contactemailAddress = null, [WorkflowExpression] Func<string> contactcompany = null, [WorkflowExpression] Func<string> contactidStatus = null, [WorkflowExpression] Func<string> contactreferredBy = null, [WorkflowExpression] Func<string> contactjobTitle = null, [WorkflowExpression] Func<string> contactbusinessPhoneNumber = null, [WorkflowExpression] Func<string> contactmobilePhoneNumber = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Contacts/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var contact = new JObject();
                var contactpropCount = 0;
                if (contactfullName != null)
                {
                    contact["fullName"] = SourceExpressionConverter.ConvertToken(contactfullName);
                    contactpropCount++;
                }

                if (contactemailAddress != null)
                {
                    contact["emailAddress"] = SourceExpressionConverter.ConvertToken(contactemailAddress);
                    contactpropCount++;
                }

                if (contactcompany != null)
                {
                    contact["company"] = SourceExpressionConverter.ConvertToken(contactcompany);
                    contactpropCount++;
                }

                if (contactidStatus != null)
                {
                    contact["idStatus"] = SourceExpressionConverter.ConvertToken(contactidStatus);
                    contactpropCount++;
                }

                if (contactreferredBy != null)
                {
                    contact["referredBy"] = SourceExpressionConverter.ConvertToken(contactreferredBy);
                    contactpropCount++;
                }

                if (contactjobTitle != null)
                {
                    contact["jobTitle"] = SourceExpressionConverter.ConvertToken(contactjobTitle);
                    contactpropCount++;
                }

                if (contactbusinessPhoneNumber != null)
                {
                    contact["businessPhone"] = SourceExpressionConverter.ConvertToken(contactbusinessPhoneNumber);
                    contactpropCount++;
                }

                if (contactmobilePhoneNumber != null)
                {
                    contact["mobilePhone"] = SourceExpressionConverter.ConvertToken(contactmobilePhoneNumber);
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
                return callPayload;
            }

            return new ApiConnectionAction<ActWebApiModelsContact>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "act")]
        public IBodyWorkflowAction<ActWebApiModelsContact> GetContact([WorkflowExpression] Func<string> contactid)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/Contacts/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(contactid, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ActWebApiModelsContact>(BuildSourceInput);
        }
    }

    public class ActTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ActWebApiModelsContact[]> TrigNewContact(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/trigger/api/Contacts/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<ActWebApiModelsContact[]>(BuildSourceInput, triggerName, recurrence);
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