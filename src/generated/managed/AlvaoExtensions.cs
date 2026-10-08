//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Alvao
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AlvaoActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "alvao")]
        [WorkflowExpressionFactory(nameof(__BuildGetObjects))]
        public IBodyWorkflowAction<AMObjectsExpandedApiResponse> GetObjects([WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> orderBy = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AMObjectsExpandedApiResponse> __BuildGetObjects(WorkflowExpression<int> top = null, WorkflowExpression<string> search = null, WorkflowExpression<string> filter = null, WorkflowExpression<string> orderBy = null)
        {
            WorkflowExpression.Validate(top, nameof(top), required: false);
            WorkflowExpression.Validate(search, nameof(search), required: false);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(orderBy, nameof(orderBy), required: false);
            return new DeferredBodyAction<AMObjectsExpandedApiResponse>(() =>
            {
                var apiCallPath = "/v1/objects";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
                if (search != null)
                    callPayload.Queries["$search"] = ExpressionConverter.Convert(search);
                if (filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
                if (orderBy != null)
                    callPayload.Queries["$orderBy"] = ExpressionConverter.Convert(orderBy);
                callPayload.Queries["$expand"] = Convert.ToString("properties");
                return new ApiConnectionAction<AMObjectsExpandedApiResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "alvao")]
        [WorkflowExpressionFactory(nameof(__BuildGetUsers))]
        public IBodyWorkflowAction<CommonUsersApiResponse> GetUsers([WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> orderBy = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CommonUsersApiResponse> __BuildGetUsers(WorkflowExpression<int> top = null, WorkflowExpression<string> search = null, WorkflowExpression<string> filter = null, WorkflowExpression<string> orderBy = null)
        {
            WorkflowExpression.Validate(top, nameof(top), required: false);
            WorkflowExpression.Validate(search, nameof(search), required: false);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(orderBy, nameof(orderBy), required: false);
            return new DeferredBodyAction<CommonUsersApiResponse>(() =>
            {
                var apiCallPath = "/v1/users";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
                if (search != null)
                    callPayload.Queries["$search"] = ExpressionConverter.Convert(search);
                if (filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
                if (orderBy != null)
                    callPayload.Queries["$orderBy"] = ExpressionConverter.Convert(orderBy);
                return new ApiConnectionAction<CommonUsersApiResponse>(callPayload);
            });
        }
    }

    public class AlvaoTriggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildTicketTransitionsToStatus))]
        public IBodyWorkflowTrigger<WebhookCreatedResponse> TicketTransitionsToStatus([WorkflowExpression] Func<string> bodyprocessName,[WorkflowExpression] Func<string> bodyticketStatusName,[WorkflowExpression] Func<string> bodyserviceName = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<WebhookCreatedResponse> __BuildTicketTransitionsToStatus(WorkflowExpression<string> bodyprocessName,WorkflowExpression<string> bodyticketStatusName,WorkflowExpression<string> bodyserviceName = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodyprocessName, nameof(bodyprocessName), required: true);
            WorkflowExpression.Validate(bodyticketStatusName, nameof(bodyticketStatusName), required: true);
            WorkflowExpression.Validate(bodyserviceName, nameof(bodyserviceName), required: false);
            return new DeferredBodyTrigger<WebhookCreatedResponse>(() =>
            {
                var apiCallPath = "/webhooks/tickettransitionstostatus";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["webhookUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["process"] = ExpressionConverter.ConvertO(bodyprocessName);
                bodypropCount++;
                body["status"] = ExpressionConverter.ConvertO(bodyticketStatusName);
                if (bodyserviceName != null)
                {
                    body["service"] = ExpressionConverter.ConvertO(bodyserviceName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<WebhookCreatedResponse>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class AMObjectsExpandedApiResponse
    {
        [JsonProperty("value")]
        public AMObjectExpanded[] Value { get; set; }
    }

    public class AMObjectExpanded
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("kindId")]
        public int KindID { get; set; }

        [JsonProperty("kindName")]
        public string KindName { get; set; }

        [JsonProperty("hidden")]
        public bool Hidden { get; set; }

        [JsonProperty("parentObjectId")]
        public int ParentObjectID { get; set; }

        [JsonProperty("properties")]
        public AMObjectExpandedPropertiesTypeItem[] Properties { get; set; }
    }

    public class AMObjectExpandedPropertiesTypeItem
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("nameOrder")]
        public int NameOrder { get; set; }
    }

    public class CommonUsersApiResponse
    {
        [JsonProperty("value")]
        public CommonPerson[] Value { get; set; }
    }

    public class CommonPerson
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string EMail { get; set; }

        [JsonProperty("email2")]
        public string EMail2 { get; set; }

        [JsonProperty("phone")]
        public string WorkPhone { get; set; }

        [JsonProperty("phone2")]
        public string WorkPhone2 { get; set; }

        [JsonProperty("mobilePhone")]
        public string MobilePhone { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("office")]
        public string Office { get; set; }

        [JsonProperty("workPosition")]
        public string Position { get; set; }

        [JsonProperty("organization")]
        public string Organization { get; set; }

        [JsonProperty("otherContacts")]
        public string OtherContacts { get; set; }

        [JsonProperty("id")]
        public int UserID { get; set; }

        [JsonProperty("sAMAccountName")]
        public string UsernameForOlderSystems { get; set; }

        [JsonProperty("login")]
        public string Username { get; set; }

        [JsonProperty("createdDate")]
        public string Created { get; set; }

        [JsonProperty("isSystem")]
        public bool IsSystem { get; set; }

        [JsonProperty("isHidden")]
        public bool IsHidden { get; set; }

        [JsonProperty("isShared")]
        public bool IsShared { get; set; }

        [JsonProperty("isDisabled")]
        public bool IsDisabled { get; set; }

        [JsonProperty("isGuest")]
        public bool IsGuest { get; set; }

        [JsonProperty("isApp")]
        public bool IsApp { get; set; }

        [JsonProperty("removedDate")]
        public string Removed { get; set; }

        [JsonProperty("managerId")]
        public int ManagerID { get; set; }

        [JsonProperty("substituteId")]
        public int SubstituteID { get; set; }

        [JsonProperty("personalNumber")]
        public string PersonalNumber { get; set; }

        [JsonProperty("localeId")]
        public int PreferredLanguageID { get; set; }

        [JsonProperty("timezone")]
        public string TimeZone { get; set; }

        [JsonProperty("customItems")]
        public JToken CustomItems { get; set; }

        [JsonProperty("adGuid")]
        public string ADGUID { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("sid")]
        public string SID { get; set; }

        [JsonProperty("adPath")]
        public string ADPath { get; set; }

        [JsonProperty("azureAdObjectId")]
        public string AzureID { get; set; }
    }

    public class WebhookCreatedResponse
    {
        [JsonProperty("id")]
        public int ID { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Alvao;

    public partial class WorkflowManagedActions
    {
        public AlvaoActions Alvao(string connectionId) => new AlvaoActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AlvaoTriggers Alvao(string connectionId) => new AlvaoTriggers(connectionId);
    }
}