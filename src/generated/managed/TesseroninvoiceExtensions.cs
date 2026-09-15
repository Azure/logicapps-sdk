//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Tesseroninvoice
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TesseroninvoiceActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseroninvoice")]
        public IBodyWorkflowAction<GetServiceAssignmentsDispatcherResponse> GetServiceAssignmentsDispatcher(Expression<Func<int>> bodyskip, Expression<Func<string>> bodysearch = null, Expression<Func<int>> bodyorderColumns = null, Expression<Func<bool>> bodyorderByAsc = null, Expression<Func<bool>> bodytakeAll = null, Expression<Func<string>> bodyadditionalSearchDatadateTimeFrom = null, Expression<Func<string>> bodyadditionalSearchDatadateTimeTo = null, Expression<Func<double>> bodyadditionalSearchDataquantityFrom = null, Expression<Func<double>> bodyadditionalSearchDataquantityTo = null, Expression<Func<int[]>> bodyadditionalSearchDatauserIds = null, Expression<Func<string[]>> bodyadditionalSearchDataserviceArticles = null, Expression<Func<int>> bodyadditionalSearchDataassignmentStatusId = null, Expression<Func<bool>> bodyadditionalSearchDataisInvoice = null)
        {
            var apiCallPath = "/GetServiceAssignmentsDispatcher";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["Skip"] = CSharpExpressionConverter.ConvertToken(bodyskip);
            body["PageSize"] = 25;
            bodypropCount++;
            if (bodysearch != null)
            {
                body["Search"] = CSharpExpressionConverter.ConvertToken(bodysearch);
                bodypropCount++;
            }

            if (bodyorderColumns != null)
            {
                body["OrderColumns"] = CSharpExpressionConverter.ConvertToken(bodyorderColumns);
                bodypropCount++;
            }

            if (bodyorderByAsc != null)
            {
                if (bodyorderByAsc != null)
                {
                    body["OrderByAsc"] = CSharpExpressionConverter.ConvertToken(bodyorderByAsc);
                    bodypropCount++;
                }

                bodypropCount++;
            }
            else
            {
                body["OrderByAsc"] = false;
                bodypropCount++;
            }

            if (bodytakeAll != null)
            {
                if (bodytakeAll != null)
                {
                    body["TakeAll"] = CSharpExpressionConverter.ConvertToken(bodytakeAll);
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
            if (bodyadditionalSearchDatadateTimeFrom != null)
            {
                additionalSearchDataObject["DateTimeFrom"] = CSharpExpressionConverter.ConvertToken(bodyadditionalSearchDatadateTimeFrom);
                additionalSearchDataObjectpropCount++;
            }

            if (bodyadditionalSearchDatadateTimeTo != null)
            {
                additionalSearchDataObject["DateTimeTo"] = CSharpExpressionConverter.ConvertToken(bodyadditionalSearchDatadateTimeTo);
                additionalSearchDataObjectpropCount++;
            }

            if (bodyadditionalSearchDataquantityFrom != null)
            {
                additionalSearchDataObject["QuantityFrom"] = CSharpExpressionConverter.ConvertToken(bodyadditionalSearchDataquantityFrom);
                additionalSearchDataObjectpropCount++;
            }

            if (bodyadditionalSearchDataquantityTo != null)
            {
                additionalSearchDataObject["QuantityTo"] = CSharpExpressionConverter.ConvertToken(bodyadditionalSearchDataquantityTo);
                additionalSearchDataObjectpropCount++;
            }

            if (bodyadditionalSearchDatauserIds != null)
            {
                additionalSearchDataObject["UserIds"] = CSharpExpressionConverter.ConvertToken(bodyadditionalSearchDatauserIds);
                additionalSearchDataObjectpropCount++;
            }

            if (bodyadditionalSearchDataserviceArticles != null)
            {
                additionalSearchDataObject["ServiceArticles"] = CSharpExpressionConverter.ConvertToken(bodyadditionalSearchDataserviceArticles);
                additionalSearchDataObjectpropCount++;
            }

            if (bodyadditionalSearchDataassignmentStatusId != null)
            {
                additionalSearchDataObject["AssignmentStatusId"] = CSharpExpressionConverter.ConvertToken(bodyadditionalSearchDataassignmentStatusId);
                additionalSearchDataObjectpropCount++;
            }

            if (bodyadditionalSearchDataisInvoice != null)
            {
                additionalSearchDataObject["IsInvoice"] = CSharpExpressionConverter.ConvertToken(bodyadditionalSearchDataisInvoice);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseroninvoice")]
        public IBodyWorkflowAction<CreateActivityRecordingResponse> CreateActivityRecording(Expression<Func<string>> bodydateFrom, Expression<Func<string>> bodyquantity = null, Expression<Func<string>> bodydateTo = null, Expression<Func<string>> bodybookText = null, Expression<Func<string>> bodynoteText = null, Expression<Func<int>> bodyprojectId = null, Expression<Func<int>> bodyprojectPhaseId = null, Expression<Func<int>> bodyticketid = null)
        {
            var apiCallPath = "/CreateActivityRecording";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["dateFrom"] = CSharpExpressionConverter.ConvertToken(bodydateFrom);
            if (bodyquantity != null)
            {
                body["quantity"] = CSharpExpressionConverter.ConvertToken(bodyquantity);
                bodypropCount++;
            }

            if (bodydateTo != null)
            {
                body["dateTo"] = CSharpExpressionConverter.ConvertToken(bodydateTo);
                bodypropCount++;
            }

            if (bodybookText != null)
            {
                body["bookText"] = CSharpExpressionConverter.ConvertToken(bodybookText);
                bodypropCount++;
            }

            if (bodynoteText != null)
            {
                body["noteText"] = CSharpExpressionConverter.ConvertToken(bodynoteText);
                bodypropCount++;
            }

            if (bodyprojectId != null)
            {
                body["projectId"] = CSharpExpressionConverter.ConvertToken(bodyprojectId);
                bodypropCount++;
            }

            if (bodyprojectPhaseId != null)
            {
                body["projectPhaseId"] = CSharpExpressionConverter.ConvertToken(bodyprojectPhaseId);
                bodypropCount++;
            }

            if (bodyticketid != null)
            {
                body["ticketid"] = CSharpExpressionConverter.ConvertToken(bodyticketid);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateActivityRecordingResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseroninvoice")]
        public IBodyWorkflowAction<CreateInvoicePositionNoteResponse> CreateInvoicePositionNote(Expression<Func<string>> bodydateFrom, Expression<Func<string>> bodydateTo, Expression<Func<int>> bodypause = null, Expression<Func<bool>> bodynoInvoice = null, Expression<Func<bool>> bodyextraCharge = null, Expression<Func<string>> bodyhint = null, Expression<Func<string>> bodyserviceContractId = null, Expression<Func<string>> bodyuserName = null)
        {
            var apiCallPath = "/CreateInvoicePositionNote";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["dateFrom"] = CSharpExpressionConverter.ConvertToken(bodydateFrom);
            bodypropCount++;
            body["dateTo"] = CSharpExpressionConverter.ConvertToken(bodydateTo);
            if (bodypause != null)
            {
                body["pause"] = CSharpExpressionConverter.ConvertToken(bodypause);
                bodypropCount++;
            }

            if (bodynoInvoice != null)
            {
                if (bodynoInvoice != null)
                {
                    body["noInvoice"] = CSharpExpressionConverter.ConvertToken(bodynoInvoice);
                    bodypropCount++;
                }

                bodypropCount++;
            }
            else
            {
                body["noInvoice"] = false;
                bodypropCount++;
            }

            if (bodyextraCharge != null)
            {
                if (bodyextraCharge != null)
                {
                    body["extraCharge"] = CSharpExpressionConverter.ConvertToken(bodyextraCharge);
                    bodypropCount++;
                }

                bodypropCount++;
            }
            else
            {
                body["extraCharge"] = true;
                bodypropCount++;
            }

            if (bodyhint != null)
            {
                body["hint"] = CSharpExpressionConverter.ConvertToken(bodyhint);
                bodypropCount++;
            }

            if (bodyserviceContractId != null)
            {
                body["serviceContractId"] = CSharpExpressionConverter.ConvertToken(bodyserviceContractId);
                bodypropCount++;
            }

            if (bodyuserName != null)
            {
                body["userName"] = CSharpExpressionConverter.ConvertToken(bodyuserName);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateInvoicePositionNoteResponse>(callPayload);
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