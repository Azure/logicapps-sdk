//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Infusionsoft
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class InfusionsoftActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infusionsoft")]
        public IBodyWorkflowAction<TaskResponse, ApiConnectionActionConfiguration> CreateTask(Expression<Func<CreateTaskInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<TaskResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/rest/v1/tasks/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString(" application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<TaskResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infusionsoft")]
        public IBodyWorkflowAction<TaskResponse, ApiConnectionActionConfiguration> UpdateTask(Expression<Func<int>> id, Expression<Func<UpdateTaskInput>> body)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<TaskResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/rest/v1/tasks/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString(" application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<TaskResponse>(callPayload);
            });
        }
    }

    public class InfusionsoftTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<TaskResponse[], ApiConnectionTriggerConfiguration> OnNewTask(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<TaskResponse[], ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger/crm/rest/v1/tasks/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["order"] = Convert.ToString("-due_date");
                return new ApiConnectionTrigger<TaskResponse[]>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<ListOrdersResponseItem[], ApiConnectionTriggerConfiguration> OnNewOrder(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<ListOrdersResponseItem[], ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger/crm/rest/v1/orders";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<ListOrdersResponseItem[]>(callPayload, recurrence: recurrence);
            });
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

    public class CreateTaskInput
    {
        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("type")]
        public CreateTaskInputTypeType? Type { get; set; }

        [JsonProperty("priority")]
        public int? Priority { get; set; }

        [JsonProperty("due_date")]
        public string DueDateFormatYYYYMMDdThhMmSsFffZ { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateTaskInputTypeType
    {
        Call,
        Email,
        Appointment,
        Fax,
        Letter,
        Other
    }

    public class UpdateTaskInput
    {
        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("type")]
        public UpdateTaskInputTypeType? Type { get; set; }

        [JsonProperty("priority")]
        public int? Priority { get; set; }

        [JsonProperty("due_date")]
        public string DueDateFormatYYYYMMDdThhMmSsFffZ { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateTaskInputTypeType
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