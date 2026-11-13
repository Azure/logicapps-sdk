//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Qrstuff
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class QrstuffActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "qrstuff")]
        public IBodyWorkflowAction<GetUserProfileResponse, ApiConnectionActionConfiguration> GetUserProfile()
        {
            return new DeferredBodyAction<GetUserProfileResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/profile";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetUserProfileResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "qrstuff")]
        public IBodyWorkflowAction<GetSubscriptionDetailResponse, ApiConnectionActionConfiguration> GetSubscriptionDetail()
        {
            return new DeferredBodyAction<GetSubscriptionDetailResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/subscriptions/detail";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetSubscriptionDetailResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "qrstuff")]
        public IBodyWorkflowAction<ListProjectsResponse, ApiConnectionActionConfiguration> ListProjects(Expression<Func<int>> page = null, Expression<Func<int>> perPage = null, Expression<Func<SortByInput>> sortBy = null, Expression<Func<SortOrderInput>> sortOrder = null, Expression<Func<int>> deleted = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            var __workflow_sortBy = WorkflowExpression.Compile(sortBy, nameof(sortBy), required: false);
            var __workflow_sortOrder = WorkflowExpression.Compile(sortOrder, nameof(sortOrder), required: false);
            var __workflow_deleted = WorkflowExpression.Compile(deleted, nameof(deleted), required: false);
            return new DeferredBodyAction<ListProjectsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/projects";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                callPayload.Queries["per_page"] = Convert.ToString(10);
                if (__workflow_perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(__workflow_perPage);
                callPayload.Queries["sort_by"] = Convert.ToString("idproject");
                if (__workflow_sortBy != null)
                    callPayload.Queries["sort_by"] = ExpressionConverter.Convert(__workflow_sortBy);
                callPayload.Queries["sort_order"] = Convert.ToString("desc");
                if (__workflow_sortOrder != null)
                    callPayload.Queries["sort_order"] = ExpressionConverter.Convert(__workflow_sortOrder);
                callPayload.Queries["deleted"] = Convert.ToString(0);
                if (__workflow_deleted != null)
                    callPayload.Queries["deleted"] = ExpressionConverter.Convert(__workflow_deleted);
                return new ApiConnectionAction<ListProjectsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "qrstuff")]
        public IBodyWorkflowAction<CreateProjectResponse, ApiConnectionActionConfiguration> CreateProject(Expression<Func<CreateProjectBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateProjectResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/projects";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateProjectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "qrstuff")]
        public IBodyWorkflowAction<RestoreDeletedProjectResponse, ApiConnectionActionConfiguration> RestoreDeletedProject(Expression<Func<RestoreDeletedProjectBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<RestoreDeletedProjectResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/projects/restore";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<RestoreDeletedProjectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "qrstuff")]
        public IBodyWorkflowAction<ListProjectQRCodesResponse, ApiConnectionActionConfiguration> ListProjectQRCodes(Expression<Func<int>> idproject, Expression<Func<int>> page = null, Expression<Func<int>> perPage = null)
        {
            var __workflow_idproject = WorkflowExpression.Compile(idproject, nameof(idproject), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<ListProjectQRCodesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/projects/{0}/qr-codes", __workflow_idproject.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                callPayload.Queries["per_page"] = Convert.ToString(25);
                if (__workflow_perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(__workflow_perPage);
                return new ApiConnectionAction<ListProjectQRCodesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "qrstuff")]
        public IBodyWorkflowAction<GetProjectScansResponse, ApiConnectionActionConfiguration> GetProjectScans(Expression<Func<int>> idproject, Expression<Func<GetProjectScansBodyInput>> body)
        {
            var __workflow_idproject = WorkflowExpression.Compile(idproject, nameof(idproject), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GetProjectScansResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/projects/{0}/scans/", __workflow_idproject.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GetProjectScansResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "qrstuff")]
        public IBodyWorkflowAction<GenerateQRCodeResponse, ApiConnectionActionConfiguration> GenerateQRCode(Expression<Func<GenerateQRCodeBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GenerateQRCodeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/generate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GenerateQRCodeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "qrstuff")]
        public IBodyWorkflowAction<ListQRCodesResponse, ApiConnectionActionConfiguration> ListQRCodes(Expression<Func<int>> page = null, Expression<Func<int>> perPage = null, Expression<Func<string>> q = null, Expression<Func<SortOrderInput>> sortOrder = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_sortOrder = WorkflowExpression.Compile(sortOrder, nameof(sortOrder), required: false);
            return new DeferredBodyAction<ListQRCodesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/qrcodes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                callPayload.Queries["per_page"] = Convert.ToString(25);
                if (__workflow_perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(__workflow_perPage);
                if (__workflow_q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                callPayload.Queries["sort_order"] = Convert.ToString("desc");
                if (__workflow_sortOrder != null)
                    callPayload.Queries["sort_order"] = ExpressionConverter.Convert(__workflow_sortOrder);
                return new ApiConnectionAction<ListQRCodesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "qrstuff")]
        public IBodyWorkflowAction<RestoreDeletedQRCodeResponse, ApiConnectionActionConfiguration> RestoreDeletedQRCode(Expression<Func<RestoreDeletedQRCodeBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<RestoreDeletedQRCodeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/qrcodes/restore";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<RestoreDeletedQRCodeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "qrstuff")]
        public IBodyWorkflowAction<TransferQRCodeResponse, ApiConnectionActionConfiguration> TransferQRCode(Expression<Func<TransferQRCodeBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<TransferQRCodeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/qrcodes/anonymous-transfer";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<TransferQRCodeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "qrstuff")]
        public IBodyWorkflowAction<MoveQRCodeToProjectResponse, ApiConnectionActionConfiguration> MoveQRCodeToProject(Expression<Func<int>> idproject, Expression<Func<MoveQRCodeToProjectBodyInput>> body)
        {
            var __workflow_idproject = WorkflowExpression.Compile(idproject, nameof(idproject), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<MoveQRCodeToProjectResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/qrcodes/move-to-project/{0}", __workflow_idproject.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MoveQRCodeToProjectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "qrstuff")]
        public IBodyWorkflowAction<GetTopScannerResponse, ApiConnectionActionConfiguration> GetTopScanner(Expression<Func<GetTopScannerBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GetTopScannerResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/qrcodes/top-scanner";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GetTopScannerResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "qrstuff")]
        public IBodyWorkflowAction<GetQRCodeByIdResponse, ApiConnectionActionConfiguration> GetQRCodeById(Expression<Func<int>> idqrcode)
        {
            var __workflow_idqrcode = WorkflowExpression.Compile(idqrcode, nameof(idqrcode), required: true);
            return new DeferredBodyAction<GetQRCodeByIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/qrcodes/{0}", __workflow_idqrcode.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetQRCodeByIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "qrstuff")]
        public IBodyWorkflowAction<UpdateQRCodeResponse, ApiConnectionActionConfiguration> UpdateQRCode(Expression<Func<int>> idqrcode, Expression<Func<UpdateQRCodeBodyInput>> body)
        {
            var __workflow_idqrcode = WorkflowExpression.Compile(idqrcode, nameof(idqrcode), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UpdateQRCodeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/qrcodes/{0}", __workflow_idqrcode.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateQRCodeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "qrstuff")]
        public IBodyWorkflowAction<GetQRCodeHistoryResponse, ApiConnectionActionConfiguration> GetQRCodeHistory(Expression<Func<int>> idqrcode)
        {
            var __workflow_idqrcode = WorkflowExpression.Compile(idqrcode, nameof(idqrcode), required: true);
            return new DeferredBodyAction<GetQRCodeHistoryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/qrcodes/{0}/history", __workflow_idqrcode.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetQRCodeHistoryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "qrstuff")]
        public IBodyWorkflowAction<GetQRCodeScansResponse, ApiConnectionActionConfiguration> GetQRCodeScans(Expression<Func<int>> idqrcode, Expression<Func<GetProjectScansBodyInput>> body)
        {
            var __workflow_idqrcode = WorkflowExpression.Compile(idqrcode, nameof(idqrcode), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GetQRCodeScansResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/qrcodes/{0}/scans/", __workflow_idqrcode.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GetQRCodeScansResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "qrstuff")]
        public IBodyWorkflowAction<GetAccountOverviewResponse, ApiConnectionActionConfiguration> GetAccountOverview()
        {
            return new DeferredBodyAction<GetAccountOverviewResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/analytics";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetAccountOverviewResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "qrstuff")]
        public IBodyWorkflowAction<GetAccountActivityResponse, ApiConnectionActionConfiguration> GetAccountActivity()
        {
            return new DeferredBodyAction<GetAccountActivityResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/analytics/account-activity";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetAccountActivityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "qrstuff")]
        public IBodyWorkflowAction<GetTotalScansResponse, ApiConnectionActionConfiguration> GetTotalScans(Expression<Func<GetTopPerformingDateBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GetTotalScansResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/analytics/total-scans";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GetTotalScansResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "qrstuff")]
        public IBodyWorkflowAction<GetUniqueUsersResponse, ApiConnectionActionConfiguration> GetUniqueUsers(Expression<Func<GetTopPerformingDateBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GetUniqueUsersResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/analytics/unique-users";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GetUniqueUsersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "qrstuff")]
        public IBodyWorkflowAction<GetTopPerformingDateResponse, ApiConnectionActionConfiguration> GetTopPerformingDate(Expression<Func<GetTopPerformingDateBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GetTopPerformingDateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/analytics/top-performing-date";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GetTopPerformingDateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "qrstuff")]
        public IBodyWorkflowAction<GetTopPerformingLocationResponse, ApiConnectionActionConfiguration> GetTopPerformingLocation(Expression<Func<GetTopPerformingDateBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GetTopPerformingLocationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/analytics/top-performing-location";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GetTopPerformingLocationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "qrstuff")]
        public IBodyWorkflowAction<GetAccountScansResponse, ApiConnectionActionConfiguration> GetAccountScans(Expression<Func<GetAccountScansBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GetAccountScansResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/account/scans";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GetAccountScansResponse>(callPayload);
            });
        }
    }

    public class QrstuffTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetUserProfileResponse
    {
        [JsonProperty("idclient")]
        public int ClientId { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("business_name")]
        public string BusinessName { get; set; }

        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }
    }

    public class GetSubscriptionDetailResponse
    {
        [JsonProperty("plan")]
        public string Plan { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("next_billing_at")]
        public string NextBillingDate { get; set; }

        [JsonProperty("currency_code")]
        public string Currency { get; set; }
    }

    public class ListProjectsResponse
    {
        [JsonProperty("data")]
        public ListProjectsResponseProjectsTypeItem[] Projects { get; set; }

        [JsonProperty("meta")]
        public ListProjectsResponsePaginationType Pagination { get; set; }
    }

    public class ListProjectsResponseProjectsTypeItem
    {
        [JsonProperty("idproject")]
        public int ProjectId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("num_codes")]
        public int QRCodeCount { get; set; }
    }

    public class ListProjectsResponsePaginationType
    {
        [JsonProperty("current_page")]
        public int CurrentPage { get; set; }

        [JsonProperty("last_page")]
        public int LastPage { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SortByInput
    {
        [EnumMember(Value = "name")]
        Name,
        [EnumMember(Value = "idproject")]
        Idproject
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SortOrderInput
    {
        [EnumMember(Value = "asc")]
        Asc,
        [EnumMember(Value = "desc")]
        Desc
    }

    public class CreateProjectResponse
    {
        [JsonProperty("idproject")]
        public int ProjectId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CreateProjectBodyInput
    {
        public CreateProjectBodyInput(string projectName)
        {
            this.ProjectName = projectName;
        }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ProjectName { get; set; }
    }

    public class RestoreDeletedProjectResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class RestoreDeletedProjectBodyInput
    {
        public RestoreDeletedProjectBodyInput(int[] projectIDs)
        {
            this.ProjectIDs = projectIDs;
        }

        [JsonProperty("project_ids", DefaultValueHandling = DefaultValueHandling.Include)]
        public int[] ProjectIDs { get; set; }
    }

    public class ListProjectQRCodesResponse
    {
        [JsonProperty("data")]
        public ListProjectQRCodesResponseQRCodesTypeItem[] QRCodes { get; set; }
    }

    public class ListProjectQRCodesResponseQRCodesTypeItem
    {
        [JsonProperty("idqrcode")]
        public int QRCodeId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("output_type")]
        public string Type { get; set; }

        [JsonProperty("preview_url")]
        public string PreviewURL { get; set; }

        [JsonProperty("hits")]
        public int TotalScans { get; set; }
    }

    public class GetProjectScansResponse
    {
        [JsonProperty("data")]
        public JToken[] Scans { get; set; }

        [JsonProperty("meta")]
        public JToken Pagination { get; set; }
    }

    public class GetProjectScansBodyInput
    {
        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("group_by", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputGroupByType? GroupBy { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Qrstuff.BodyInputGroupByType.Scan;

        [JsonProperty("page", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Page { get; set; } = 1;

        [JsonProperty("per_page", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? PerPage { get; set; } = 10;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputGroupByType
    {
        [EnumMember(Value = "scan")]
        Scan,
        [EnumMember(Value = "date")]
        Date,
        [EnumMember(Value = "country")]
        Country,
        [EnumMember(Value = "region")]
        Region,
        [EnumMember(Value = "device")]
        Device
    }

    public class GenerateQRCodeResponse
    {
        [JsonProperty("idqrcode")]
        public int QRCodeId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("preview_url")]
        public string PreviewURL { get; set; }

        [JsonProperty("shorturl")]
        public string ShortURL { get; set; }
    }

    public class GenerateQRCodeBodyInput
    {
        public GenerateQRCodeBodyInput(string name, GenerateQRCodeBodyInputTypeType type, int projectId)
        {
            this.Name = name;
            this.Type = type;
            this.ProjectId = projectId;
        }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("output_type", DefaultValueHandling = DefaultValueHandling.Include)]
        public GenerateQRCodeBodyInputTypeType Type { get; set; }

        [JsonProperty("idproject", DefaultValueHandling = DefaultValueHandling.Include)]
        public int ProjectId { get; set; }

        [JsonProperty("data")]
        public string DataContent { get; set; }

        [JsonProperty("frame_name")]
        public string FrameName { get; set; }

        [JsonProperty("qr_code_logo_image")]
        public string LogoImageId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GenerateQRCodeBodyInputTypeType
    {
        URL,
        TEXT,
        MAILTO,
        TEL,
        SMSTO,
        WIFI,
        VCARD,
        GEO
    }

    public class ListQRCodesResponse
    {
        [JsonProperty("data")]
        public ListQRCodesResponseQRCodesTypeItem[] QRCodes { get; set; }

        [JsonProperty("meta")]
        public ListQRCodesResponsePaginationType Pagination { get; set; }
    }

    public class ListQRCodesResponseQRCodesTypeItem
    {
        [JsonProperty("idqrcode")]
        public int QRCodeId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("output_type")]
        public string Type { get; set; }

        [JsonProperty("idproject")]
        public int ProjectId { get; set; }

        [JsonProperty("shorturl")]
        public string ShortURL { get; set; }

        [JsonProperty("preview_url")]
        public string PreviewURL { get; set; }
    }

    public class ListQRCodesResponsePaginationType
    {
        [JsonProperty("current_page")]
        public int CurrentPage { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class RestoreDeletedQRCodeResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class RestoreDeletedQRCodeBodyInput
    {
        [JsonProperty("qrcode_ids")]
        public int[] QRCodeIDs { get; set; }

        [JsonProperty("shorturl_keys")]
        public string[] ShortURLKeys { get; set; }
    }

    public class TransferQRCodeResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class TransferQRCodeBodyInput
    {
        [JsonProperty("idproject")]
        public int? ProjectId { get; set; }

        [JsonProperty("qrcode_ids")]
        public int[] QRCodeIDs { get; set; }

        [JsonProperty("shorturl_keys")]
        public string[] ShortURLKeys { get; set; }
    }

    public class MoveQRCodeToProjectResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class MoveQRCodeToProjectBodyInput
    {
        public MoveQRCodeToProjectBodyInput(int[] qRCodeIDs)
        {
            this.QRCodeIDs = qRCodeIDs;
        }

        [JsonProperty("qrcodes", DefaultValueHandling = DefaultValueHandling.Include)]
        public int[] QRCodeIDs { get; set; }
    }

    public class GetTopScannerResponse
    {
        [JsonProperty("idqrcode")]
        public int QRCodeId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("scans")]
        public int Scans { get; set; }
    }

    public class GetTopScannerBodyInput
    {
        public GetTopScannerBodyInput(string startDate, string endDate)
        {
            this.StartDate = startDate;
            this.EndDate = endDate;
        }

        [JsonProperty("scope", DefaultValueHandling = DefaultValueHandling.Include)]
        public GetTopScannerBodyInputScopeType Scope { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Qrstuff.GetTopScannerBodyInputScopeType.Account;

        [JsonProperty("start_date", DefaultValueHandling = DefaultValueHandling.Include)]
        public string StartDate { get; set; }

        [JsonProperty("end_date", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EndDate { get; set; }

        [JsonProperty("idproject")]
        public int? ProjectId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetTopScannerBodyInputScopeType
    {
        [EnumMember(Value = "account")]
        Account,
        [EnumMember(Value = "project")]
        Project
    }

    public class GetQRCodeByIdResponse
    {
        [JsonProperty("idqrcode")]
        public int QRCodeId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("output_type")]
        public string Type { get; set; }

        [JsonProperty("idproject")]
        public int ProjectId { get; set; }

        [JsonProperty("shorturl")]
        public string ShortURL { get; set; }

        [JsonProperty("preview_url")]
        public string PreviewURL { get; set; }

        [JsonProperty("download_url")]
        public string DownloadURL { get; set; }

        [JsonProperty("hits")]
        public int TotalScans { get; set; }
    }

    public class UpdateQRCodeResponse
    {
        [JsonProperty("idqrcode")]
        public int QRCodeId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class UpdateQRCodeBodyInput
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("data")]
        public string DataURL { get; set; }

        [JsonProperty("type")]
        public UpdateQRCodeBodyInputTypeType? Type { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateQRCodeBodyInputTypeType
    {
        URL,
        TEXT,
        MAILTO,
        TEL,
        SMSTO
    }

    public class GetQRCodeHistoryResponse
    {
        [JsonProperty("data")]
        public GetQRCodeHistoryResponseHistoryTypeItem[] History { get; set; }
    }

    public class GetQRCodeHistoryResponseHistoryTypeItem
    {
        [JsonProperty("event")]
        public string Event { get; set; }

        [JsonProperty("created_at")]
        public string Date { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }
    }

    public class GetQRCodeScansResponse
    {
        [JsonProperty("data")]
        public JToken[] Scans { get; set; }

        [JsonProperty("meta")]
        public JToken Pagination { get; set; }
    }

    public class GetAccountOverviewResponse
    {
        [JsonProperty("total_projects")]
        public int TotalProjects { get; set; }

        [JsonProperty("total_qrcodes")]
        public int TotalQRCodes { get; set; }

        [JsonProperty("total_scans")]
        public int TotalScans { get; set; }

        [JsonProperty("total_unique_users")]
        public int UniqueUsers { get; set; }
    }

    public class GetAccountActivityResponse
    {
        [JsonProperty("dynamic_qrcodes_used")]
        public int DynamicQRCodesUsed { get; set; }

        [JsonProperty("dynamic_qrcodes_limit")]
        public int DynamicQRCodesLimit { get; set; }

        [JsonProperty("scans_this_month")]
        public int ScansThisMonth { get; set; }

        [JsonProperty("scans_limit")]
        public int ScansLimit { get; set; }
    }

    public class GetTotalScansResponse
    {
        [JsonProperty("total")]
        public int TotalScans { get; set; }
    }

    public class GetTopPerformingDateBodyInput
    {
        public GetTopPerformingDateBodyInput(string startDate, string endDate)
        {
            this.StartDate = startDate;
            this.EndDate = endDate;
        }

        [JsonProperty("scope", DefaultValueHandling = DefaultValueHandling.Include)]
        public GetTopPerformingDateBodyInputScopeType Scope { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Qrstuff.GetTopPerformingDateBodyInputScopeType.Account;

        [JsonProperty("start_date", DefaultValueHandling = DefaultValueHandling.Include)]
        public string StartDate { get; set; }

        [JsonProperty("end_date", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EndDate { get; set; }

        [JsonProperty("idproject")]
        public int? ProjectId { get; set; }

        [JsonProperty("idqrcode")]
        public int? QRCodeId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetTopPerformingDateBodyInputScopeType
    {
        [EnumMember(Value = "account")]
        Account,
        [EnumMember(Value = "project")]
        Project,
        [EnumMember(Value = "qrcode")]
        Qrcode
    }

    public class GetUniqueUsersResponse
    {
        [JsonProperty("unique_users")]
        public int UniqueUsers { get; set; }
    }

    public class GetTopPerformingDateResponse
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("scans")]
        public int Scans { get; set; }
    }

    public class GetTopPerformingLocationResponse
    {
        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("scans")]
        public int Scans { get; set; }
    }

    public class GetAccountScansResponse
    {
        [JsonProperty("data")]
        public JToken[] Scans { get; set; }

        [JsonProperty("meta")]
        public JToken Pagination { get; set; }
    }

    public class GetAccountScansBodyInput
    {
        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("group_by", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputGroupByType? GroupBy { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Qrstuff.BodyInputGroupByType.Scan;

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("page", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Page { get; set; } = 1;

        [JsonProperty("per_page", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? PerPage { get; set; } = 10;
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Qrstuff;

    public partial class WorkflowManagedActions
    {
        public QrstuffActions Qrstuff(string connectionId) => new QrstuffActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public QrstuffTriggers Qrstuff(string connectionId) => new QrstuffTriggers(connectionId);
    }
}