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
        public IBodyWorkflowAction<GetServiceAssignmentsDispatcherResponse> GetServiceAssignmentsDispatcher([WorkflowExpression] Func<int> bodyskip, [WorkflowExpression] Func<string> bodysearch = null, [WorkflowExpression] Func<int> bodyorderColumns = null, [WorkflowExpression] Func<bool> bodyorderByAsc = null, [WorkflowExpression] Func<bool> bodytakeAll = null, [WorkflowExpression] Func<string> bodyadditionalSearchDatadateTimeFrom = null, [WorkflowExpression] Func<string> bodyadditionalSearchDatadateTimeTo = null, [WorkflowExpression] Func<double> bodyadditionalSearchDataquantityFrom = null, [WorkflowExpression] Func<double> bodyadditionalSearchDataquantityTo = null, [WorkflowExpression] Func<int[]> bodyadditionalSearchDatauserIds = null, [WorkflowExpression] Func<string[]> bodyadditionalSearchDataserviceArticles = null, [WorkflowExpression] Func<int> bodyadditionalSearchDataassignmentStatusId = null, [WorkflowExpression] Func<bool> bodyadditionalSearchDataisInvoice = null)
        {
            SourceExpression.Validate(bodyskip, nameof(bodyskip), required: true);
            SourceExpression.Validate(bodysearch, nameof(bodysearch), required: false);
            SourceExpression.Validate(bodyorderColumns, nameof(bodyorderColumns), required: false);
            SourceExpression.Validate(bodyorderByAsc, nameof(bodyorderByAsc), required: false);
            SourceExpression.Validate(bodytakeAll, nameof(bodytakeAll), required: false);
            SourceExpression.Validate(bodyadditionalSearchDatadateTimeFrom, nameof(bodyadditionalSearchDatadateTimeFrom), required: false);
            SourceExpression.Validate(bodyadditionalSearchDatadateTimeTo, nameof(bodyadditionalSearchDatadateTimeTo), required: false);
            SourceExpression.Validate(bodyadditionalSearchDataquantityFrom, nameof(bodyadditionalSearchDataquantityFrom), required: false);
            SourceExpression.Validate(bodyadditionalSearchDataquantityTo, nameof(bodyadditionalSearchDataquantityTo), required: false);
            SourceExpression.Validate(bodyadditionalSearchDatauserIds, nameof(bodyadditionalSearchDatauserIds), required: false);
            SourceExpression.Validate(bodyadditionalSearchDataserviceArticles, nameof(bodyadditionalSearchDataserviceArticles), required: false);
            SourceExpression.Validate(bodyadditionalSearchDataassignmentStatusId, nameof(bodyadditionalSearchDataassignmentStatusId), required: false);
            SourceExpression.Validate(bodyadditionalSearchDataisInvoice, nameof(bodyadditionalSearchDataisInvoice), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/GetServiceAssignmentsDispatcher";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Skip"] = SourceExpressionConverter.ConvertToken(bodyskip);
                body["PageSize"] = 25;
                bodypropCount++;
                if (bodysearch != null)
                {
                    body["Search"] = SourceExpressionConverter.ConvertToken(bodysearch);
                    bodypropCount++;
                }

                if (bodyorderColumns != null)
                {
                    body["OrderColumns"] = SourceExpressionConverter.ConvertToken(bodyorderColumns);
                    bodypropCount++;
                }

                if (bodyorderByAsc != null)
                {
                    if (bodyorderByAsc != null)
                    {
                        body["OrderByAsc"] = SourceExpressionConverter.ConvertToken(bodyorderByAsc);
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
                        body["TakeAll"] = SourceExpressionConverter.ConvertToken(bodytakeAll);
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
                    additionalSearchDataObject["DateTimeFrom"] = SourceExpressionConverter.ConvertToken(bodyadditionalSearchDatadateTimeFrom);
                    additionalSearchDataObjectpropCount++;
                }

                if (bodyadditionalSearchDatadateTimeTo != null)
                {
                    additionalSearchDataObject["DateTimeTo"] = SourceExpressionConverter.ConvertToken(bodyadditionalSearchDatadateTimeTo);
                    additionalSearchDataObjectpropCount++;
                }

                if (bodyadditionalSearchDataquantityFrom != null)
                {
                    additionalSearchDataObject["QuantityFrom"] = SourceExpressionConverter.ConvertToken(bodyadditionalSearchDataquantityFrom);
                    additionalSearchDataObjectpropCount++;
                }

                if (bodyadditionalSearchDataquantityTo != null)
                {
                    additionalSearchDataObject["QuantityTo"] = SourceExpressionConverter.ConvertToken(bodyadditionalSearchDataquantityTo);
                    additionalSearchDataObjectpropCount++;
                }

                if (bodyadditionalSearchDatauserIds != null)
                {
                    additionalSearchDataObject["UserIds"] = SourceExpressionConverter.ConvertToken(bodyadditionalSearchDatauserIds);
                    additionalSearchDataObjectpropCount++;
                }

                if (bodyadditionalSearchDataserviceArticles != null)
                {
                    additionalSearchDataObject["ServiceArticles"] = SourceExpressionConverter.ConvertToken(bodyadditionalSearchDataserviceArticles);
                    additionalSearchDataObjectpropCount++;
                }

                if (bodyadditionalSearchDataassignmentStatusId != null)
                {
                    additionalSearchDataObject["AssignmentStatusId"] = SourceExpressionConverter.ConvertToken(bodyadditionalSearchDataassignmentStatusId);
                    additionalSearchDataObjectpropCount++;
                }

                if (bodyadditionalSearchDataisInvoice != null)
                {
                    additionalSearchDataObject["IsInvoice"] = SourceExpressionConverter.ConvertToken(bodyadditionalSearchDataisInvoice);
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
                return callPayload;
            }

            return new ApiConnectionAction<GetServiceAssignmentsDispatcherResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseroninvoice")]
        public IBodyWorkflowAction<CreateActivityRecordingResponse> CreateActivityRecording([WorkflowExpression] Func<string> bodydateFrom, [WorkflowExpression] Func<string> bodyquantity = null, [WorkflowExpression] Func<string> bodydateTo = null, [WorkflowExpression] Func<string> bodybookText = null, [WorkflowExpression] Func<string> bodynoteText = null, [WorkflowExpression] Func<int> bodyprojectId = null, [WorkflowExpression] Func<int> bodyprojectPhaseId = null, [WorkflowExpression] Func<int> bodyticketid = null)
        {
            SourceExpression.Validate(bodydateFrom, nameof(bodydateFrom), required: true);
            SourceExpression.Validate(bodyquantity, nameof(bodyquantity), required: false);
            SourceExpression.Validate(bodydateTo, nameof(bodydateTo), required: false);
            SourceExpression.Validate(bodybookText, nameof(bodybookText), required: false);
            SourceExpression.Validate(bodynoteText, nameof(bodynoteText), required: false);
            SourceExpression.Validate(bodyprojectId, nameof(bodyprojectId), required: false);
            SourceExpression.Validate(bodyprojectPhaseId, nameof(bodyprojectPhaseId), required: false);
            SourceExpression.Validate(bodyticketid, nameof(bodyticketid), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/CreateActivityRecording";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["dateFrom"] = SourceExpressionConverter.ConvertToken(bodydateFrom);
                if (bodyquantity != null)
                {
                    body["quantity"] = SourceExpressionConverter.ConvertToken(bodyquantity);
                    bodypropCount++;
                }

                if (bodydateTo != null)
                {
                    body["dateTo"] = SourceExpressionConverter.ConvertToken(bodydateTo);
                    bodypropCount++;
                }

                if (bodybookText != null)
                {
                    body["bookText"] = SourceExpressionConverter.ConvertToken(bodybookText);
                    bodypropCount++;
                }

                if (bodynoteText != null)
                {
                    body["noteText"] = SourceExpressionConverter.ConvertToken(bodynoteText);
                    bodypropCount++;
                }

                if (bodyprojectId != null)
                {
                    body["projectId"] = SourceExpressionConverter.ConvertToken(bodyprojectId);
                    bodypropCount++;
                }

                if (bodyprojectPhaseId != null)
                {
                    body["projectPhaseId"] = SourceExpressionConverter.ConvertToken(bodyprojectPhaseId);
                    bodypropCount++;
                }

                if (bodyticketid != null)
                {
                    body["ticketid"] = SourceExpressionConverter.ConvertToken(bodyticketid);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateActivityRecordingResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseroninvoice")]
        public IBodyWorkflowAction<CreateInvoicePositionNoteResponse> CreateInvoicePositionNote([WorkflowExpression] Func<string> bodydateFrom, [WorkflowExpression] Func<string> bodydateTo, [WorkflowExpression] Func<int> bodypause = null, [WorkflowExpression] Func<bool> bodynoInvoice = null, [WorkflowExpression] Func<bool> bodyextraCharge = null, [WorkflowExpression] Func<string> bodyhint = null, [WorkflowExpression] Func<string> bodyserviceContractId = null, [WorkflowExpression] Func<string> bodyuserName = null)
        {
            SourceExpression.Validate(bodydateFrom, nameof(bodydateFrom), required: true);
            SourceExpression.Validate(bodydateTo, nameof(bodydateTo), required: true);
            SourceExpression.Validate(bodypause, nameof(bodypause), required: false);
            SourceExpression.Validate(bodynoInvoice, nameof(bodynoInvoice), required: false);
            SourceExpression.Validate(bodyextraCharge, nameof(bodyextraCharge), required: false);
            SourceExpression.Validate(bodyhint, nameof(bodyhint), required: false);
            SourceExpression.Validate(bodyserviceContractId, nameof(bodyserviceContractId), required: false);
            SourceExpression.Validate(bodyuserName, nameof(bodyuserName), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/CreateInvoicePositionNote";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["dateFrom"] = SourceExpressionConverter.ConvertToken(bodydateFrom);
                bodypropCount++;
                body["dateTo"] = SourceExpressionConverter.ConvertToken(bodydateTo);
                if (bodypause != null)
                {
                    body["pause"] = SourceExpressionConverter.ConvertToken(bodypause);
                    bodypropCount++;
                }

                if (bodynoInvoice != null)
                {
                    if (bodynoInvoice != null)
                    {
                        body["noInvoice"] = SourceExpressionConverter.ConvertToken(bodynoInvoice);
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
                        body["extraCharge"] = SourceExpressionConverter.ConvertToken(bodyextraCharge);
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
                    body["hint"] = SourceExpressionConverter.ConvertToken(bodyhint);
                    bodypropCount++;
                }

                if (bodyserviceContractId != null)
                {
                    body["serviceContractId"] = SourceExpressionConverter.ConvertToken(bodyserviceContractId);
                    bodypropCount++;
                }

                if (bodyuserName != null)
                {
                    body["userName"] = SourceExpressionConverter.ConvertToken(bodyuserName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateInvoicePositionNoteResponse>(BuildSourceInput);
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