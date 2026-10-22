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
        public IBodyWorkflowAction<GetServiceAssignmentsDispatcherResponse, ApiConnectionActionConfiguration> GetServiceAssignmentsDispatcher(Expression<Func<int>> bodyskip, Expression<Func<string>> bodysearch = null, Expression<Func<int>> bodyorderColumns = null, Expression<Func<bool>> bodyorderByAsc = null, Expression<Func<bool>> bodytakeAll = null, Expression<Func<string>> bodyadditionalSearchDatadateTimeFrom = null, Expression<Func<string>> bodyadditionalSearchDatadateTimeTo = null, Expression<Func<double>> bodyadditionalSearchDataquantityFrom = null, Expression<Func<double>> bodyadditionalSearchDataquantityTo = null, Expression<Func<int[]>> bodyadditionalSearchDatauserIds = null, Expression<Func<string[]>> bodyadditionalSearchDataserviceArticles = null, Expression<Func<int>> bodyadditionalSearchDataassignmentStatusId = null, Expression<Func<bool>> bodyadditionalSearchDataisInvoice = null)
        {
            var __workflow_bodyskip = WorkflowExpression.Compile(bodyskip, nameof(bodyskip), required: true);
            var __workflow_bodysearch = WorkflowExpression.Compile(bodysearch, nameof(bodysearch), required: false);
            var __workflow_bodyorderColumns = WorkflowExpression.Compile(bodyorderColumns, nameof(bodyorderColumns), required: false);
            var __workflow_bodyorderByAsc = WorkflowExpression.Compile(bodyorderByAsc, nameof(bodyorderByAsc), required: false);
            var __workflow_bodytakeAll = WorkflowExpression.Compile(bodytakeAll, nameof(bodytakeAll), required: false);
            var __workflow_bodyadditionalSearchDatadateTimeFrom = WorkflowExpression.Compile(bodyadditionalSearchDatadateTimeFrom, nameof(bodyadditionalSearchDatadateTimeFrom), required: false);
            var __workflow_bodyadditionalSearchDatadateTimeTo = WorkflowExpression.Compile(bodyadditionalSearchDatadateTimeTo, nameof(bodyadditionalSearchDatadateTimeTo), required: false);
            var __workflow_bodyadditionalSearchDataquantityFrom = WorkflowExpression.Compile(bodyadditionalSearchDataquantityFrom, nameof(bodyadditionalSearchDataquantityFrom), required: false);
            var __workflow_bodyadditionalSearchDataquantityTo = WorkflowExpression.Compile(bodyadditionalSearchDataquantityTo, nameof(bodyadditionalSearchDataquantityTo), required: false);
            var __workflow_bodyadditionalSearchDatauserIds = WorkflowExpression.Compile(bodyadditionalSearchDatauserIds, nameof(bodyadditionalSearchDatauserIds), required: false);
            var __workflow_bodyadditionalSearchDataserviceArticles = WorkflowExpression.Compile(bodyadditionalSearchDataserviceArticles, nameof(bodyadditionalSearchDataserviceArticles), required: false);
            var __workflow_bodyadditionalSearchDataassignmentStatusId = WorkflowExpression.Compile(bodyadditionalSearchDataassignmentStatusId, nameof(bodyadditionalSearchDataassignmentStatusId), required: false);
            var __workflow_bodyadditionalSearchDataisInvoice = WorkflowExpression.Compile(bodyadditionalSearchDataisInvoice, nameof(bodyadditionalSearchDataisInvoice), required: false);
            return new DeferredBodyAction<GetServiceAssignmentsDispatcherResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/GetServiceAssignmentsDispatcher";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Skip"] = ExpressionConverter.ConvertO(__workflow_bodyskip);
                body["PageSize"] = 25;
                bodypropCount++;
                if (__workflow_bodysearch != null)
                {
                    body["Search"] = ExpressionConverter.ConvertO(__workflow_bodysearch);
                    bodypropCount++;
                }

                if (__workflow_bodyorderColumns != null)
                {
                    body["OrderColumns"] = ExpressionConverter.ConvertO(__workflow_bodyorderColumns);
                    bodypropCount++;
                }

                if (__workflow_bodyorderByAsc != null)
                {
                    if (__workflow_bodyorderByAsc != null)
                    {
                        body["OrderByAsc"] = ExpressionConverter.ConvertO(__workflow_bodyorderByAsc);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["OrderByAsc"] = false;
                    bodypropCount++;
                }

                if (__workflow_bodytakeAll != null)
                {
                    if (__workflow_bodytakeAll != null)
                    {
                        body["TakeAll"] = ExpressionConverter.ConvertO(__workflow_bodytakeAll);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["TakeAll"] = false;
                    bodypropCount++;
                }

                var additionalSearchDataObject = new JObject();
                var additionalSearchDataObjectpropCount = 0;
                if (__workflow_bodyadditionalSearchDatadateTimeFrom != null)
                {
                    additionalSearchDataObject["DateTimeFrom"] = ExpressionConverter.ConvertO(__workflow_bodyadditionalSearchDatadateTimeFrom);
                    additionalSearchDataObjectpropCount++;
                }

                if (__workflow_bodyadditionalSearchDatadateTimeTo != null)
                {
                    additionalSearchDataObject["DateTimeTo"] = ExpressionConverter.ConvertO(__workflow_bodyadditionalSearchDatadateTimeTo);
                    additionalSearchDataObjectpropCount++;
                }

                if (__workflow_bodyadditionalSearchDataquantityFrom != null)
                {
                    additionalSearchDataObject["QuantityFrom"] = ExpressionConverter.ConvertO(__workflow_bodyadditionalSearchDataquantityFrom);
                    additionalSearchDataObjectpropCount++;
                }

                if (__workflow_bodyadditionalSearchDataquantityTo != null)
                {
                    additionalSearchDataObject["QuantityTo"] = ExpressionConverter.ConvertO(__workflow_bodyadditionalSearchDataquantityTo);
                    additionalSearchDataObjectpropCount++;
                }

                if (__workflow_bodyadditionalSearchDatauserIds != null)
                {
                    additionalSearchDataObject["UserIds"] = ExpressionConverter.ConvertO(__workflow_bodyadditionalSearchDatauserIds);
                    additionalSearchDataObjectpropCount++;
                }

                if (__workflow_bodyadditionalSearchDataserviceArticles != null)
                {
                    additionalSearchDataObject["ServiceArticles"] = ExpressionConverter.ConvertO(__workflow_bodyadditionalSearchDataserviceArticles);
                    additionalSearchDataObjectpropCount++;
                }

                if (__workflow_bodyadditionalSearchDataassignmentStatusId != null)
                {
                    additionalSearchDataObject["AssignmentStatusId"] = ExpressionConverter.ConvertO(__workflow_bodyadditionalSearchDataassignmentStatusId);
                    additionalSearchDataObjectpropCount++;
                }

                if (__workflow_bodyadditionalSearchDataisInvoice != null)
                {
                    additionalSearchDataObject["IsInvoice"] = ExpressionConverter.ConvertO(__workflow_bodyadditionalSearchDataisInvoice);
                    additionalSearchDataObjectpropCount++;
                }

                if (additionalSearchDataObjectpropCount > 0)
                {
                    body["AdditionalSearchData"] = additionalSearchDataObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GetServiceAssignmentsDispatcherResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseroninvoice")]
        public IBodyWorkflowAction<CreateActivityRecordingResponse, ApiConnectionActionConfiguration> CreateActivityRecording(Expression<Func<string>> bodydateFrom, Expression<Func<string>> bodyquantity = null, Expression<Func<string>> bodydateTo = null, Expression<Func<string>> bodybookText = null, Expression<Func<string>> bodynoteText = null, Expression<Func<int>> bodyprojectId = null, Expression<Func<int>> bodyprojectPhaseId = null, Expression<Func<int>> bodyticketid = null)
        {
            var __workflow_bodydateFrom = WorkflowExpression.Compile(bodydateFrom, nameof(bodydateFrom), required: true);
            var __workflow_bodyquantity = WorkflowExpression.Compile(bodyquantity, nameof(bodyquantity), required: false);
            var __workflow_bodydateTo = WorkflowExpression.Compile(bodydateTo, nameof(bodydateTo), required: false);
            var __workflow_bodybookText = WorkflowExpression.Compile(bodybookText, nameof(bodybookText), required: false);
            var __workflow_bodynoteText = WorkflowExpression.Compile(bodynoteText, nameof(bodynoteText), required: false);
            var __workflow_bodyprojectId = WorkflowExpression.Compile(bodyprojectId, nameof(bodyprojectId), required: false);
            var __workflow_bodyprojectPhaseId = WorkflowExpression.Compile(bodyprojectPhaseId, nameof(bodyprojectPhaseId), required: false);
            var __workflow_bodyticketid = WorkflowExpression.Compile(bodyticketid, nameof(bodyticketid), required: false);
            return new DeferredBodyAction<CreateActivityRecordingResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/CreateActivityRecording";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["dateFrom"] = ExpressionConverter.ConvertO(__workflow_bodydateFrom);
                if (__workflow_bodyquantity != null)
                {
                    body["quantity"] = ExpressionConverter.ConvertO(__workflow_bodyquantity);
                    bodypropCount++;
                }

                if (__workflow_bodydateTo != null)
                {
                    body["dateTo"] = ExpressionConverter.ConvertO(__workflow_bodydateTo);
                    bodypropCount++;
                }

                if (__workflow_bodybookText != null)
                {
                    body["bookText"] = ExpressionConverter.ConvertO(__workflow_bodybookText);
                    bodypropCount++;
                }

                if (__workflow_bodynoteText != null)
                {
                    body["noteText"] = ExpressionConverter.ConvertO(__workflow_bodynoteText);
                    bodypropCount++;
                }

                if (__workflow_bodyprojectId != null)
                {
                    body["projectId"] = ExpressionConverter.ConvertO(__workflow_bodyprojectId);
                    bodypropCount++;
                }

                if (__workflow_bodyprojectPhaseId != null)
                {
                    body["projectPhaseId"] = ExpressionConverter.ConvertO(__workflow_bodyprojectPhaseId);
                    bodypropCount++;
                }

                if (__workflow_bodyticketid != null)
                {
                    body["ticketid"] = ExpressionConverter.ConvertO(__workflow_bodyticketid);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateActivityRecordingResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseroninvoice")]
        public IBodyWorkflowAction<CreateInvoicePositionNoteResponse, ApiConnectionActionConfiguration> CreateInvoicePositionNote(Expression<Func<string>> bodydateFrom, Expression<Func<string>> bodydateTo, Expression<Func<int>> bodypause = null, Expression<Func<bool>> bodynoInvoice = null, Expression<Func<bool>> bodyextraCharge = null, Expression<Func<string>> bodyhint = null, Expression<Func<string>> bodyserviceContractId = null, Expression<Func<string>> bodyuserName = null)
        {
            var __workflow_bodydateFrom = WorkflowExpression.Compile(bodydateFrom, nameof(bodydateFrom), required: true);
            var __workflow_bodydateTo = WorkflowExpression.Compile(bodydateTo, nameof(bodydateTo), required: true);
            var __workflow_bodypause = WorkflowExpression.Compile(bodypause, nameof(bodypause), required: false);
            var __workflow_bodynoInvoice = WorkflowExpression.Compile(bodynoInvoice, nameof(bodynoInvoice), required: false);
            var __workflow_bodyextraCharge = WorkflowExpression.Compile(bodyextraCharge, nameof(bodyextraCharge), required: false);
            var __workflow_bodyhint = WorkflowExpression.Compile(bodyhint, nameof(bodyhint), required: false);
            var __workflow_bodyserviceContractId = WorkflowExpression.Compile(bodyserviceContractId, nameof(bodyserviceContractId), required: false);
            var __workflow_bodyuserName = WorkflowExpression.Compile(bodyuserName, nameof(bodyuserName), required: false);
            return new DeferredBodyAction<CreateInvoicePositionNoteResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/CreateInvoicePositionNote";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["dateFrom"] = ExpressionConverter.ConvertO(__workflow_bodydateFrom);
                bodypropCount++;
                body["dateTo"] = ExpressionConverter.ConvertO(__workflow_bodydateTo);
                if (__workflow_bodypause != null)
                {
                    body["pause"] = ExpressionConverter.ConvertO(__workflow_bodypause);
                    bodypropCount++;
                }

                if (__workflow_bodynoInvoice != null)
                {
                    if (__workflow_bodynoInvoice != null)
                    {
                        body["noInvoice"] = ExpressionConverter.ConvertO(__workflow_bodynoInvoice);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["noInvoice"] = false;
                    bodypropCount++;
                }

                if (__workflow_bodyextraCharge != null)
                {
                    if (__workflow_bodyextraCharge != null)
                    {
                        body["extraCharge"] = ExpressionConverter.ConvertO(__workflow_bodyextraCharge);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["extraCharge"] = true;
                    bodypropCount++;
                }

                if (__workflow_bodyhint != null)
                {
                    body["hint"] = ExpressionConverter.ConvertO(__workflow_bodyhint);
                    bodypropCount++;
                }

                if (__workflow_bodyserviceContractId != null)
                {
                    body["serviceContractId"] = ExpressionConverter.ConvertO(__workflow_bodyserviceContractId);
                    bodypropCount++;
                }

                if (__workflow_bodyuserName != null)
                {
                    body["userName"] = ExpressionConverter.ConvertO(__workflow_bodyuserName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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
        public string ServiceContractID { get; set; }
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

    public class CreateActivityRecordingResponse
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public string ActivityRecordingId { get; set; }
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
