//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Infusionsoft
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class InfusionsoftActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infusionsoft")]
        public IBodyWorkflowAction<TaskResponse> CreateTask(Expression<Func<string>> bodytitle, Expression<Func<string>> bodydescription = null, Expression<Func<bodytypeInput>> bodytype = null, Expression<Func<int>> bodypriority = null, Expression<Func<string>> bodydueDateFormatYYYYMMDdThhMmSsFffZ = null)
        {
            var apiCallPath = "/crm/rest/v1/tasks/";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString(" application/json");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["title"] = ExpressionConverter.ConvertO(bodytitle);
            if (bodydescription != null)
            {
                body["description"] = ExpressionConverter.ConvertO(bodydescription);
                bodypropCount++;
            }

            if (bodytype != null)
            {
                body["type"] = ExpressionConverter.ConvertO(bodytype);
                bodypropCount++;
            }

            if (bodypriority != null)
            {
                body["priority"] = ExpressionConverter.ConvertO(bodypriority);
                bodypropCount++;
            }

            if (bodydueDateFormatYYYYMMDdThhMmSsFffZ != null)
            {
                body["due_date"] = ExpressionConverter.ConvertO(bodydueDateFormatYYYYMMDdThhMmSsFffZ);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<TaskResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infusionsoft")]
        public IBodyWorkflowAction<TaskResponse> UpdateTask(Expression<Func<int>> id, Expression<Func<string>> bodytitle, Expression<Func<string>> bodydescription = null, Expression<Func<bodytypeInput>> bodytype = null, Expression<Func<int>> bodypriority = null, Expression<Func<string>> bodydueDateFormatYYYYMMDdThhMmSsFffZ = null)
        {
            var apiCallPath = String.Format("/crm/rest/v1/tasks/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString(" application/json");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["title"] = ExpressionConverter.ConvertO(bodytitle);
            if (bodydescription != null)
            {
                body["description"] = ExpressionConverter.ConvertO(bodydescription);
                bodypropCount++;
            }

            if (bodytype != null)
            {
                body["type"] = ExpressionConverter.ConvertO(bodytype);
                bodypropCount++;
            }

            if (bodypriority != null)
            {
                body["priority"] = ExpressionConverter.ConvertO(bodypriority);
                bodypropCount++;
            }

            if (bodydueDateFormatYYYYMMDdThhMmSsFffZ != null)
            {
                body["due_date"] = ExpressionConverter.ConvertO(bodydueDateFormatYYYYMMDdThhMmSsFffZ);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<TaskResponse>(callPayload);
        }
    }

    public class InfusionsoftTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<TaskResponse[]> OnNewTask(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/crm/rest/v1/tasks/search";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["order"] = Convert.ToString("-due_date");
            return new ApiConnectionTrigger<TaskResponse[]>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ListOrdersResponseItem[]> OnNewOrder(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/crm/rest/v1/orders";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<ListOrdersResponseItem[]>(callPayload, triggerName, recurrence);
        }
    }

    public class TaskResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("priority")]
        public int Priority { get; set; }

        [JsonProperty("completed")]
        public bool Completed { get; set; }

        [JsonProperty("url")]
        public string URL { get; set; }

        [JsonProperty("due_date")]
        public string DueDate { get; set; }
    }

    public enum bodytypeInput
    {
        Call,
        Email,
        Appointment,
        Fax,
        Letter,
        Other
    }

    public class ListOrdersResponseItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("total")]
        public double Total { get; set; }

        [JsonProperty("shipping_information")]
        public ListOrdersResponseItemShippingType Shipping { get; set; }

        [JsonProperty("contact")]
        public ListOrdersResponseItemContactType Contact { get; set; }

        [JsonProperty("creation_date")]
        public string CreationDate { get; set; }

        [JsonProperty("order_date")]
        public string OrderDate { get; set; }

        [JsonProperty("total_paid")]
        public double TotalPaid { get; set; }

        [JsonProperty("total_due")]
        public double TotalDue { get; set; }
    }

    public class ListOrdersResponseItemShippingType
    {
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("middle_name")]
        public string MiddleName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("phone")]
        public string PhoneNumber { get; set; }

        [JsonProperty("street1")]
        public string StreetLine1 { get; set; }

        [JsonProperty("street2")]
        public string StreetLine2 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }

    public class ListOrdersResponseItemContactType
    {
        [JsonProperty("email")]
        public string EmailAddress { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("company_name")]
        public string Company { get; set; }

        [JsonProperty("job_title")]
        public string JobTitle { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Infusionsoft;

    public partial class WorkflowManagedActions
    {
        public InfusionsoftActions Infusionsoft(string connectionId) => new InfusionsoftActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public InfusionsoftTriggers Infusionsoft(string connectionId) => new InfusionsoftTriggers(connectionId);
    }
}