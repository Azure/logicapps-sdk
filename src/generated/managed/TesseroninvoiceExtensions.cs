//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Tesseroninvoice
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TesseroninvoiceActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseroninvoice")]
        public IBodyWorkflowAction<GetServiceAssignmentsDispatcherResponse, ApiConnectionActionConfiguration> GetServiceAssignmentsDispatcher(Expression<Func<GetServiceAssignmentsDispatcherInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GetServiceAssignmentsDispatcherResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/GetServiceAssignmentsDispatcher";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GetServiceAssignmentsDispatcherResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseroninvoice")]
        public IBodyWorkflowAction<CreateActivityRecordingResponse, ApiConnectionActionConfiguration> CreateActivityRecording(Expression<Func<CreateActivityRecordingInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateActivityRecordingResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/CreateActivityRecording";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateActivityRecordingResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseroninvoice")]
        public IBodyWorkflowAction<CreateInvoicePositionNoteResponse, ApiConnectionActionConfiguration> CreateInvoicePositionNote(Expression<Func<CreateInvoicePositionNoteInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateInvoicePositionNoteResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/CreateInvoicePositionNote";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateInvoicePositionNoteResponse>(callPayload);
            });
        }
    }

    public class TesseroninvoiceTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetServiceAssignmentsDispatcherResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("result")]
        public GetServiceAssignmentsDispatcherResponseResultType Result { get; set; }
    }

    public class GetServiceAssignmentsDispatcherResponseResultType
    {
        public GetServiceAssignmentsDispatcherResponseResultTypeResultsTypeItem[] Results { get; set; }
        public int Count { get; set; }
        public int Filtered { get; set; }
        public int OwnHours { get; set; }
        public int TotalHours { get; set; }
    }

    public class GetServiceAssignmentsDispatcherResponseResultTypeResultsTypeItem
    {
        public string AssignmentId { get; set; }
        public string AssignmentNumber { get; set; }
        public string AssignmentText { get; set; }
        public string AssignmentPositionText { get; set; }
        public string MinAssignmentTime { get; set; }
        public string MaxAssignmentTime { get; set; }
        public GetServiceAssignmentsDispatcherResponseResultTypeResultsTypeItemPositionsUnitsType PositionsUnits { get; set; }
        public GetServiceAssignmentsDispatcherResponseResultTypeResultsTypeItemUserInfoType UserInfo { get; set; }
        public string CreationDate { get; set; }
        public string AlterationDate { get; set; }
        public string ServiceDate { get; set; }
        public string AssignmentTypeName { get; set; }
        public int Status { get; set; }
        public GetServiceAssignmentsDispatcherResponseResultTypeResultsTypeItemTicketInfoType TicketInfo { get; set; }
        public string Project { get; set; }
        public GetServiceAssignmentsDispatcherResponseResultTypeResultsTypeItemServiceContractType ServiceContract { get; set; }
        public bool NoInvoice { get; set; }
        public string NoInvoiceReason { get; set; }
        public GetServiceAssignmentsDispatcherResponseResultTypeResultsTypeItemArticleInfoType ArticleInfo { get; set; }
    }

    public class GetServiceAssignmentsDispatcherResponseResultTypeResultsTypeItemPositionsUnitsType
    {
        public int Minutes { get; set; }
        public double Quantity { get; set; }
        public int MinutesNoInvoice { get; set; }
        public int QuantityNoInvoice { get; set; }
        public int Pause { get; set; }
    }

    public class GetServiceAssignmentsDispatcherResponseResultTypeResultsTypeItemUserInfoType
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public int EngineerId { get; set; }
    }

    public class GetServiceAssignmentsDispatcherResponseResultTypeResultsTypeItemTicketInfoType
    {
        public int TicketId { get; set; }
        public string TicketNumber { get; set; }
        public string TicketHead { get; set; }
        public int EnterpriseId { get; set; }
        public string EnterpriseName { get; set; }
        public int AreaId { get; set; }

        [JsonProperty("ServiceContractID")]
        public string ServiceContractId { get; set; }
        public string ClosedDate { get; set; }
    }

    public class GetServiceAssignmentsDispatcherResponseResultTypeResultsTypeItemServiceContractType
    {
        public int ServiceContractId { get; set; }
        public string ServiceContractName { get; set; }
    }

    public class GetServiceAssignmentsDispatcherResponseResultTypeResultsTypeItemArticleInfoType
    {
        public int InvoiceArticleId { get; set; }
        public string ArticleNumber { get; set; }
        public string ArticleName { get; set; }
    }

    public class GetServiceAssignmentsDispatcherInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int Skip { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal int PageSize { get; set; } = 25;
        public string Search { get; set; }
        public int? OrderColumns { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OrderByAsc { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? TakeAll { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public GetServiceAssignmentsDispatcherInputAdditionalSearchDataType AdditionalSearchData { get; set; }
    }

    public class GetServiceAssignmentsDispatcherInputAdditionalSearchDataType
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string DateTimeFrom { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string DateTimeTo { get; set; }
        public double? QuantityFrom { get; set; }
        public double? QuantityTo { get; set; }
        public int[] UserIds { get; set; }
        public string[] ServiceArticles { get; set; }
        public int? AssignmentStatusId { get; set; }
        public bool? IsInvoice { get; set; }
    }

    public class CreateActivityRecordingResponse
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public string ActivityRecordingId { get; set; }
    }

    public class CreateActivityRecordingInput
    {
        [JsonProperty("dateFrom", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DateFrom { get; set; }

        [JsonProperty("quantity")]
        public string Quantity { get; set; }

        [JsonProperty("dateTo")]
        public string DateTo { get; set; }

        [JsonProperty("bookText")]
        public string BookText { get; set; }

        [JsonProperty("noteText")]
        public string NoteText { get; set; }

        [JsonProperty("projectId")]
        public int? ProjectId { get; set; }

        [JsonProperty("projectPhaseId")]
        public int? ProjectPhaseId { get; set; }

        [JsonProperty("ticketid")]
        public int? Ticketid { get; set; }
    }

    public class CreateInvoicePositionNoteResponse
    {
        [JsonProperty("invoiceNoteId")]
        public string InvoiceNoteId { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class CreateInvoicePositionNoteInput
    {
        [JsonProperty("dateFrom", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DateFrom { get; set; }

        [JsonProperty("dateTo", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DateTo { get; set; }

        [JsonProperty("pause")]
        public int? Pause { get; set; }

        [JsonProperty("noInvoice", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? NoInvoice { get; set; } = false;

        [JsonProperty("extraCharge", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ExtraCharge { get; set; } = true;

        [JsonProperty("hint")]
        public string Hint { get; set; }

        [JsonProperty("serviceContractId")]
        public string ServiceContractId { get; set; }

        [JsonProperty("userName")]
        public string UserName { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Tesseroninvoice;

    public partial class WorkflowManagedActions
    {
        public TesseroninvoiceActions Tesseroninvoice(string connectionId) => new TesseroninvoiceActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TesseroninvoiceTriggers Tesseroninvoice(string connectionId) => new TesseroninvoiceTriggers(connectionId);
    }
}