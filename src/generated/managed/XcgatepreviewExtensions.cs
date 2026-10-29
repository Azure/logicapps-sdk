//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Xcgatepreview
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class XcgatepreviewActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "xcgatepreview")]
        public IBodyWorkflowAction<LoginAuthResponse, ApiConnectionActionConfiguration> LoginAuth(Expression<Func<string>> host = null, Expression<Func<LoginAuthInput>> body = null)
        {
            var __workflow_host = WorkflowExpression.Compile(host, nameof(host), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<LoginAuthResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/webapi/login/auth";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_host != null)
                    callPayload.Queries["host"] = ExpressionConverter.Convert(__workflow_host);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<LoginAuthResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "xcgatepreview")]
        public IBodyWorkflowAction<ActionFindResponse, ApiConnectionActionConfiguration> ActionFind(Expression<Func<string>> host = null, Expression<Func<ActionFindInput>> body = null)
        {
            var __workflow_host = WorkflowExpression.Compile(host, nameof(host), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ActionFindResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/webapi/action/find";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_host != null)
                    callPayload.Queries["host"] = ExpressionConverter.Convert(__workflow_host);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ActionFindResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "xcgatepreview")]
        public IBodyWorkflowAction<ActionGetResponse, ApiConnectionActionConfiguration> ActionGet(Expression<Func<string>> host = null, Expression<Func<ActionGetInput>> body = null)
        {
            var __workflow_host = WorkflowExpression.Compile(host, nameof(host), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ActionGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/webapi/action/get";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_host != null)
                    callPayload.Queries["host"] = ExpressionConverter.Convert(__workflow_host);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ActionGetResponse>(callPayload);
            });
        }
    }

    public class XcgatepreviewTriggers([ConnectionName] string connectionId)
    {
    }

    public class LoginAuthResponse
    {
        [JsonProperty("result")]
        public LoginAuthResponseResultType Result { get; set; }

        [JsonProperty("userUCd")]
        public string UserUCd { get; set; }

        [JsonProperty("authKey")]
        public string AuthKey { get; set; }
    }

    public class LoginAuthResponseResultType
    {
        [JsonProperty("cd")]
        public string Cd { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }
    }

    public class LoginAuthInput
    {
        [JsonProperty("companyCd")]
        public string CompanyCd { get; set; }

        [JsonProperty("userCd")]
        public string UserCd { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }
    }

    public class ActionFindResponse
    {
        [JsonProperty("result")]
        public ActionFindResponseResultType Result { get; set; }

        [JsonProperty("totalCount")]
        public string TotalCount { get; set; }

        [JsonProperty("count")]
        public string Count { get; set; }

        [JsonProperty("actionList")]
        public ActionFindResponseActionListTypeItem[] ActionList { get; set; }

        [JsonProperty("enableEpoch")]
        public string EnableEpoch { get; set; }
    }

    public class ActionFindResponseResultType
    {
        [JsonProperty("cd")]
        public string Cd { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }
    }

    public class ActionFindResponseActionListTypeItem
    {
        [JsonProperty("reportCd")]
        public string ReportCd { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("trxCd")]
        public string TrxCd { get; set; }

        [JsonProperty("updateTimestamp")]
        public string UpdateTimestamp { get; set; }

        [JsonProperty("updateUserCd")]
        public string UpdateUserCd { get; set; }

        [JsonProperty("updateUserName")]
        public string UpdateUserName { get; set; }

        [JsonProperty("attribute")]
        public ActionFindResponseActionListTypeItemAttributeType Attribute { get; set; }

        [JsonProperty("fieldMap")]
        public ActionFindResponseActionListTypeItemFieldMapType FieldMap { get; set; }
    }

    public class ActionFindResponseActionListTypeItemAttributeType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("lock")]
        public string Lock { get; set; }
    }

    public class ActionFindResponseActionListTypeItemFieldMapType
    {
        public ActionFindResponseActionListTypeItemFieldMapTypeDATA1Type DATA1 { get; set; }
        public ActionFindResponseActionListTypeItemFieldMapTypeDATA2Type DATA2 { get; set; }
        public ActionFindResponseActionListTypeItemFieldMapTypeDATA3Type DATA3 { get; set; }
        public ActionFindResponseActionListTypeItemFieldMapTypeDATA4Type DATA4 { get; set; }
        public ActionFindResponseActionListTypeItemFieldMapTypeDATA5Type DATA5 { get; set; }
        public ActionFindResponseActionListTypeItemFieldMapTypeDATA6Type DATA6 { get; set; }
        public ActionFindResponseActionListTypeItemFieldMapTypeDATA7Type DATA7 { get; set; }
        public ActionFindResponseActionListTypeItemFieldMapTypeDATA8Type DATA8 { get; set; }
        public ActionFindResponseActionListTypeItemFieldMapTypeDATA9Type DATA9 { get; set; }
        public ActionFindResponseActionListTypeItemFieldMapTypeDATA10Type DATA10 { get; set; }
        public ActionFindResponseActionListTypeItemFieldMapTypeDATA11Type DATA11 { get; set; }
        public ActionFindResponseActionListTypeItemFieldMapTypeDATA12Type DATA12 { get; set; }
        public ActionFindResponseActionListTypeItemFieldMapTypeDATA13Type DATA13 { get; set; }
        public ActionFindResponseActionListTypeItemFieldMapTypeDATA14Type DATA14 { get; set; }
        public ActionFindResponseActionListTypeItemFieldMapTypeDATA15Type DATA15 { get; set; }
        public ActionFindResponseActionListTypeItemFieldMapTypeDATA16Type DATA16 { get; set; }
        public ActionFindResponseActionListTypeItemFieldMapTypeDATA17Type DATA17 { get; set; }
        public ActionFindResponseActionListTypeItemFieldMapTypeDATA18Type DATA18 { get; set; }
        public ActionFindResponseActionListTypeItemFieldMapTypeDATA19Type DATA19 { get; set; }
        public ActionFindResponseActionListTypeItemFieldMapTypeDATA20Type DATA20 { get; set; }
    }

    public class ActionFindResponseActionListTypeItemFieldMapTypeDATA1Type
    {
        [JsonProperty("fieldUCd")]
        public string FieldUCd { get; set; }

        [JsonProperty("fieldNo")]
        public string FieldNo { get; set; }

        [JsonProperty("fieldName")]
        public string FieldName { get; set; }

        [JsonProperty("fieldType")]
        public string FieldType { get; set; }

        [JsonProperty("fieldValue")]
        public string FieldValue { get; set; }

        [JsonProperty("contentURL")]
        public string ContentURL { get; set; }

        [JsonProperty("updateTimestamp")]
        public string UpdateTimestamp { get; set; }

        [JsonProperty("updateUserCd")]
        public string UpdateUserCd { get; set; }

        [JsonProperty("updateUserName")]
        public string UpdateUserName { get; set; }
    }

    public class ActionFindResponseActionListTypeItemFieldMapTypeDATA2Type
    {
        [JsonProperty("fieldUCd")]
        public string FieldUCd { get; set; }

        [JsonProperty("fieldNo")]
        public string FieldNo { get; set; }

        [JsonProperty("fieldName")]
        public string FieldName { get; set; }

        [JsonProperty("fieldType")]
        public string FieldType { get; set; }

        [JsonProperty("fieldValue")]
        public string FieldValue { get; set; }

        [JsonProperty("contentURL")]
        public string ContentURL { get; set; }

        [JsonProperty("updateTimestamp")]
        public string UpdateTimestamp { get; set; }

        [JsonProperty("updateUserCd")]
        public string UpdateUserCd { get; set; }

        [JsonProperty("updateUserName")]
        public string UpdateUserName { get; set; }
    }

    public class ActionFindResponseActionListTypeItemFieldMapTypeDATA3Type
    {
        [JsonProperty("fieldUCd")]
        public string FieldUCd { get; set; }

        [JsonProperty("fieldNo")]
        public string FieldNo { get; set; }

        [JsonProperty("fieldName")]
        public string FieldName { get; set; }

        [JsonProperty("fieldType")]
        public string FieldType { get; set; }

        [JsonProperty("fieldValue")]
        public string FieldValue { get; set; }

        [JsonProperty("contentURL")]
        public string ContentURL { get; set; }

        [JsonProperty("updateTimestamp")]
        public string UpdateTimestamp { get; set; }

        [JsonProperty("updateUserCd")]
        public string UpdateUserCd { get; set; }

        [JsonProperty("updateUserName")]
        public string UpdateUserName { get; set; }
    }

    public class ActionFindResponseActionListTypeItemFieldMapTypeDATA4Type
    {
        [JsonProperty("fieldUCd")]
        public string FieldUCd { get; set; }

        [JsonProperty("fieldNo")]
        public string FieldNo { get; set; }

        [JsonProperty("fieldName")]
        public string FieldName { get; set; }

        [JsonProperty("fieldType")]
        public string FieldType { get; set; }

        [JsonProperty("fieldValue")]
        public string FieldValue { get; set; }

        [JsonProperty("contentURL")]
        public string ContentURL { get; set; }

        [JsonProperty("updateTimestamp")]
        public string UpdateTimestamp { get; set; }

        [JsonProperty("updateUserCd")]
        public string UpdateUserCd { get; set; }

        [JsonProperty("updateUserName")]
        public string UpdateUserName { get; set; }
    }

    public class ActionFindResponseActionListTypeItemFieldMapTypeDATA5Type
    {
        [JsonProperty("fieldUCd")]
        public string FieldUCd { get; set; }

        [JsonProperty("fieldNo")]
        public string FieldNo { get; set; }

        [JsonProperty("fieldName")]
        public string FieldName { get; set; }

        [JsonProperty("fieldType")]
        public string FieldType { get; set; }

        [JsonProperty("fieldValue")]
        public string FieldValue { get; set; }

        [JsonProperty("contentURL")]
        public string ContentURL { get; set; }

        [JsonProperty("updateTimestamp")]
        public string UpdateTimestamp { get; set; }

        [JsonProperty("updateUserCd")]
        public string UpdateUserCd { get; set; }

        [JsonProperty("updateUserName")]
        public string UpdateUserName { get; set; }
    }

    public class ActionFindResponseActionListTypeItemFieldMapTypeDATA6Type
    {
        [JsonProperty("fieldUCd")]
        public string FieldUCd { get; set; }

        [JsonProperty("fieldNo")]
        public string FieldNo { get; set; }

        [JsonProperty("fieldName")]
        public string FieldName { get; set; }

        [JsonProperty("fieldType")]
        public string FieldType { get; set; }

        [JsonProperty("fieldValue")]
        public string FieldValue { get; set; }

        [JsonProperty("contentURL")]
        public string ContentURL { get; set; }

        [JsonProperty("updateTimestamp")]
        public string UpdateTimestamp { get; set; }

        [JsonProperty("updateUserCd")]
        public string UpdateUserCd { get; set; }

        [JsonProperty("updateUserName")]
        public string UpdateUserName { get; set; }
    }

    public class ActionFindResponseActionListTypeItemFieldMapTypeDATA7Type
    {
        [JsonProperty("fieldUCd")]
        public string FieldUCd { get; set; }

        [JsonProperty("fieldNo")]
        public string FieldNo { get; set; }

        [JsonProperty("fieldName")]
        public string FieldName { get; set; }

        [JsonProperty("fieldType")]
        public string FieldType { get; set; }

        [JsonProperty("fieldValue")]
        public string FieldValue { get; set; }

        [JsonProperty("contentURL")]
        public string ContentURL { get; set; }

        [JsonProperty("updateTimestamp")]
        public string UpdateTimestamp { get; set; }

        [JsonProperty("updateUserCd")]
        public string UpdateUserCd { get; set; }

        [JsonProperty("updateUserName")]
        public string UpdateUserName { get; set; }
    }

    public class ActionFindResponseActionListTypeItemFieldMapTypeDATA8Type
    {
        [JsonProperty("fieldUCd")]
        public string FieldUCd { get; set; }

        [JsonProperty("fieldNo")]
        public string FieldNo { get; set; }

        [JsonProperty("fieldName")]
        public string FieldName { get; set; }

        [JsonProperty("fieldType")]
        public string FieldType { get; set; }

        [JsonProperty("fieldValue")]
        public string FieldValue { get; set; }

        [JsonProperty("contentURL")]
        public string ContentURL { get; set; }

        [JsonProperty("updateTimestamp")]
        public string UpdateTimestamp { get; set; }

        [JsonProperty("updateUserCd")]
        public string UpdateUserCd { get; set; }

        [JsonProperty("updateUserName")]
        public string UpdateUserName { get; set; }
    }

    public class ActionFindResponseActionListTypeItemFieldMapTypeDATA9Type
    {
        [JsonProperty("fieldUCd")]
        public string FieldUCd { get; set; }

        [JsonProperty("fieldNo")]
        public string FieldNo { get; set; }

        [JsonProperty("fieldName")]
        public string FieldName { get; set; }

        [JsonProperty("fieldType")]
        public string FieldType { get; set; }

        [JsonProperty("fieldValue")]
        public string FieldValue { get; set; }

        [JsonProperty("contentURL")]
        public string ContentURL { get; set; }

        [JsonProperty("updateTimestamp")]
        public string UpdateTimestamp { get; set; }

        [JsonProperty("updateUserCd")]
        public string UpdateUserCd { get; set; }

        [JsonProperty("updateUserName")]
        public string UpdateUserName { get; set; }
    }

    public class ActionFindResponseActionListTypeItemFieldMapTypeDATA10Type
    {
        [JsonProperty("fieldUCd")]
        public string FieldUCd { get; set; }

        [JsonProperty("fieldNo")]
        public string FieldNo { get; set; }

        [JsonProperty("fieldName")]
        public string FieldName { get; set; }

        [JsonProperty("fieldType")]
        public string FieldType { get; set; }

        [JsonProperty("fieldValue")]
        public string FieldValue { get; set; }

        [JsonProperty("contentURL")]
        public string ContentURL { get; set; }

        [JsonProperty("updateTimestamp")]
        public string UpdateTimestamp { get; set; }

        [JsonProperty("updateUserCd")]
        public string UpdateUserCd { get; set; }

        [JsonProperty("updateUserName")]
        public string UpdateUserName { get; set; }
    }

    public class ActionFindResponseActionListTypeItemFieldMapTypeDATA11Type
    {
        [JsonProperty("fieldUCd")]
        public string FieldUCd { get; set; }

        [JsonProperty("fieldNo")]
        public string FieldNo { get; set; }

        [JsonProperty("fieldName")]
        public string FieldName { get; set; }

        [JsonProperty("fieldType")]
        public string FieldType { get; set; }

        [JsonProperty("fieldValue")]
        public string FieldValue { get; set; }

        [JsonProperty("contentURL")]
        public string ContentURL { get; set; }

        [JsonProperty("updateTimestamp")]
        public string UpdateTimestamp { get; set; }

        [JsonProperty("updateUserCd")]
        public string UpdateUserCd { get; set; }

        [JsonProperty("updateUserName")]
        public string UpdateUserName { get; set; }
    }

    public class ActionFindResponseActionListTypeItemFieldMapTypeDATA12Type
    {
        [JsonProperty("fieldUCd")]
        public string FieldUCd { get; set; }

        [JsonProperty("fieldNo")]
        public string FieldNo { get; set; }

        [JsonProperty("fieldName")]
        public string FieldName { get; set; }

        [JsonProperty("fieldType")]
        public string FieldType { get; set; }

        [JsonProperty("fieldValue")]
        public string FieldValue { get; set; }

        [JsonProperty("contentURL")]
        public string ContentURL { get; set; }

        [JsonProperty("updateTimestamp")]
        public string UpdateTimestamp { get; set; }

        [JsonProperty("updateUserCd")]
        public string UpdateUserCd { get; set; }

        [JsonProperty("updateUserName")]
        public string UpdateUserName { get; set; }
    }

    public class ActionFindResponseActionListTypeItemFieldMapTypeDATA13Type
    {
        [JsonProperty("fieldUCd")]
        public string FieldUCd { get; set; }

        [JsonProperty("fieldNo")]
        public string FieldNo { get; set; }

        [JsonProperty("fieldName")]
        public string FieldName { get; set; }

        [JsonProperty("fieldType")]
        public string FieldType { get; set; }

        [JsonProperty("fieldValue")]
        public string FieldValue { get; set; }

        [JsonProperty("contentURL")]
        public string ContentURL { get; set; }

        [JsonProperty("updateTimestamp")]
        public string UpdateTimestamp { get; set; }

        [JsonProperty("updateUserCd")]
        public string UpdateUserCd { get; set; }

        [JsonProperty("updateUserName")]
        public string UpdateUserName { get; set; }
    }

    public class ActionFindResponseActionListTypeItemFieldMapTypeDATA14Type
    {
        [JsonProperty("fieldUCd")]
        public string FieldUCd { get; set; }

        [JsonProperty("fieldNo")]
        public string FieldNo { get; set; }

        [JsonProperty("fieldName")]
        public string FieldName { get; set; }

        [JsonProperty("fieldType")]
        public string FieldType { get; set; }

        [JsonProperty("fieldValue")]
        public string FieldValue { get; set; }

        [JsonProperty("contentURL")]
        public string ContentURL { get; set; }

        [JsonProperty("updateTimestamp")]
        public string UpdateTimestamp { get; set; }

        [JsonProperty("updateUserCd")]
        public string UpdateUserCd { get; set; }

        [JsonProperty("updateUserName")]
        public string UpdateUserName { get; set; }
    }

    public class ActionFindResponseActionListTypeItemFieldMapTypeDATA15Type
    {
        [JsonProperty("fieldUCd")]
        public string FieldUCd { get; set; }

        [JsonProperty("fieldNo")]
        public string FieldNo { get; set; }

        [JsonProperty("fieldName")]
        public string FieldName { get; set; }

        [JsonProperty("fieldType")]
        public string FieldType { get; set; }

        [JsonProperty("fieldValue")]
        public string FieldValue { get; set; }

        [JsonProperty("contentURL")]
        public string ContentURL { get; set; }

        [JsonProperty("updateTimestamp")]
        public string UpdateTimestamp { get; set; }

        [JsonProperty("updateUserCd")]
        public string UpdateUserCd { get; set; }

        [JsonProperty("updateUserName")]
        public string UpdateUserName { get; set; }
    }

    public class ActionFindResponseActionListTypeItemFieldMapTypeDATA16Type
    {
        [JsonProperty("fieldUCd")]
        public string FieldUCd { get; set; }

        [JsonProperty("fieldNo")]
        public string FieldNo { get; set; }

        [JsonProperty("fieldName")]
        public string FieldName { get; set; }

        [JsonProperty("fieldType")]
        public string FieldType { get; set; }

        [JsonProperty("fieldValue")]
        public string FieldValue { get; set; }

        [JsonProperty("contentURL")]
        public string ContentURL { get; set; }

        [JsonProperty("updateTimestamp")]
        public string UpdateTimestamp { get; set; }

        [JsonProperty("updateUserCd")]
        public string UpdateUserCd { get; set; }

        [JsonProperty("updateUserName")]
        public string UpdateUserName { get; set; }
    }

    public class ActionFindResponseActionListTypeItemFieldMapTypeDATA17Type
    {
        [JsonProperty("fieldUCd")]
        public string FieldUCd { get; set; }

        [JsonProperty("fieldNo")]
        public string FieldNo { get; set; }

        [JsonProperty("fieldName")]
        public string FieldName { get; set; }

        [JsonProperty("fieldType")]
        public string FieldType { get; set; }

        [JsonProperty("fieldValue")]
        public string FieldValue { get; set; }

        [JsonProperty("contentURL")]
        public string ContentURL { get; set; }

        [JsonProperty("updateTimestamp")]
        public string UpdateTimestamp { get; set; }

        [JsonProperty("updateUserCd")]
        public string UpdateUserCd { get; set; }

        [JsonProperty("updateUserName")]
        public string UpdateUserName { get; set; }
    }

    public class ActionFindResponseActionListTypeItemFieldMapTypeDATA18Type
    {
        [JsonProperty("fieldUCd")]
        public string FieldUCd { get; set; }

        [JsonProperty("fieldNo")]
        public string FieldNo { get; set; }

        [JsonProperty("fieldName")]
        public string FieldName { get; set; }

        [JsonProperty("fieldType")]
        public string FieldType { get; set; }

        [JsonProperty("fieldValue")]
        public string FieldValue { get; set; }

        [JsonProperty("contentURL")]
        public string ContentURL { get; set; }

        [JsonProperty("updateTimestamp")]
        public string UpdateTimestamp { get; set; }

        [JsonProperty("updateUserCd")]
        public string UpdateUserCd { get; set; }

        [JsonProperty("updateUserName")]
        public string UpdateUserName { get; set; }
    }

    public class ActionFindResponseActionListTypeItemFieldMapTypeDATA19Type
    {
        [JsonProperty("fieldUCd")]
        public string FieldUCd { get; set; }

        [JsonProperty("fieldNo")]
        public string FieldNo { get; set; }

        [JsonProperty("fieldName")]
        public string FieldName { get; set; }

        [JsonProperty("fieldType")]
        public string FieldType { get; set; }

        [JsonProperty("fieldValue")]
        public string FieldValue { get; set; }

        [JsonProperty("contentURL")]
        public string ContentURL { get; set; }

        [JsonProperty("updateTimestamp")]
        public string UpdateTimestamp { get; set; }

        [JsonProperty("updateUserCd")]
        public string UpdateUserCd { get; set; }

        [JsonProperty("updateUserName")]
        public string UpdateUserName { get; set; }
    }

    public class ActionFindResponseActionListTypeItemFieldMapTypeDATA20Type
    {
        [JsonProperty("fieldUCd")]
        public string FieldUCd { get; set; }

        [JsonProperty("fieldNo")]
        public string FieldNo { get; set; }

        [JsonProperty("fieldName")]
        public string FieldName { get; set; }

        [JsonProperty("fieldType")]
        public string FieldType { get; set; }

        [JsonProperty("fieldValue")]
        public string FieldValue { get; set; }

        [JsonProperty("contentURL")]
        public string ContentURL { get; set; }

        [JsonProperty("updateTimestamp")]
        public string UpdateTimestamp { get; set; }

        [JsonProperty("updateUserCd")]
        public string UpdateUserCd { get; set; }

        [JsonProperty("updateUserName")]
        public string UpdateUserName { get; set; }
    }

    public class ActionFindInput
    {
        [JsonProperty("companyCd")]
        public string CompanyCd { get; set; }

        [JsonProperty("userUCd")]
        public string UserUCd { get; set; }

        [JsonProperty("authKey")]
        public string AuthKey { get; set; }

        [JsonProperty("reportCdList")]
        public string[] ReportCdList { get; set; }

        [JsonProperty("find")]
        public ActionFindInputFindType Find { get; set; }

        [JsonProperty("sortList")]
        public ActionFindInputSortListTypeItem[] SortList { get; set; }

        [JsonProperty("pageSize")]
        public string PageSize { get; set; }

        [JsonProperty("pageNo")]
        public string PageNo { get; set; }

        [JsonProperty("requestList")]
        public ActionFindInputRequestListTypeItem[] RequestList { get; set; }

        [JsonProperty("enableEpoch")]
        public string EnableEpoch { get; set; }
    }

    public class ActionFindInputFindType
    {
        [JsonProperty("statement")]
        public string Statement { get; set; }

        [JsonProperty("statementList")]
        public ActionFindInputFindTypeStatementListTypeItem[] StatementList { get; set; }
    }

    public class ActionFindInputFindTypeStatementListTypeItem
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("operator")]
        public string Operator { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class ActionFindInputSortListTypeItem
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class ActionFindInputRequestListTypeItem
    {
        [JsonProperty("fieldName")]
        public string FieldName { get; set; }

        [JsonProperty("returnName")]
        public string ReturnName { get; set; }
    }

    public class ActionGetResponse
    {
        [JsonProperty("result")]
        public ActionGetResponseResultType Result { get; set; }

        [JsonProperty("action")]
        public ActionGetResponseActionType Action { get; set; }

        [JsonProperty("enableEpoch")]
        public string EnableEpoch { get; set; }
    }

    public class ActionGetResponseResultType
    {
        [JsonProperty("cd")]
        public string Cd { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }
    }

    public class ActionGetResponseActionType
    {
        [JsonProperty("reportCd")]
        public string ReportCd { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("trxCd")]
        public string TrxCd { get; set; }

        [JsonProperty("updateTimestamp")]
        public string UpdateTimestamp { get; set; }

        [JsonProperty("updateUserCd")]
        public string UpdateUserCd { get; set; }

        [JsonProperty("updateUserName")]
        public string UpdateUserName { get; set; }

        [JsonProperty("attribute")]
        public ActionGetResponseActionTypeAttributeType Attribute { get; set; }

        [JsonProperty("trxData")]
        public ActionGetResponseActionTypeTrxDataType TrxData { get; set; }
    }

    public class ActionGetResponseActionTypeAttributeType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("lock")]
        public string Lock { get; set; }
    }

    public class ActionGetResponseActionTypeTrxDataType
    {
        [JsonProperty("sheetList")]
        public ActionGetResponseActionTypeTrxDataTypeSheetListTypeItem[] SheetList { get; set; }
    }

    public class ActionGetResponseActionTypeTrxDataTypeSheetListTypeItem
    {
        [JsonProperty("sheetUCd")]
        public string SheetUCd { get; set; }

        [JsonProperty("sheetNo")]
        public string SheetNo { get; set; }

        [JsonProperty("sheetName")]
        public string SheetName { get; set; }

        [JsonProperty("fieldList")]
        public ActionGetResponseActionTypeTrxDataTypeSheetListTypeItemFieldListTypeItem[] FieldList { get; set; }

        [JsonProperty("photoList")]
        public ActionGetResponseActionTypeTrxDataTypeSheetListTypeItemPhotoListTypeItem[] PhotoList { get; set; }
    }

    public class ActionGetResponseActionTypeTrxDataTypeSheetListTypeItemFieldListTypeItem
    {
        [JsonProperty("fieldUCd")]
        public string FieldUCd { get; set; }

        [JsonProperty("fieldNo")]
        public string FieldNo { get; set; }

        [JsonProperty("fieldName")]
        public string FieldName { get; set; }

        [JsonProperty("fieldType")]
        public string FieldType { get; set; }

        [JsonProperty("fieldValue")]
        public string FieldValue { get; set; }

        [JsonProperty("contentURL")]
        public string ContentURL { get; set; }

        [JsonProperty("updateTimestamp")]
        public string UpdateTimestamp { get; set; }

        [JsonProperty("updateUserCd")]
        public string UpdateUserCd { get; set; }

        [JsonProperty("updateUserName")]
        public string UpdateUserName { get; set; }
    }

    public class ActionGetResponseActionTypeTrxDataTypeSheetListTypeItemPhotoListTypeItem
    {
        [JsonProperty("contentURL")]
        public string ContentURL { get; set; }
    }

    public class ActionGetInput
    {
        [JsonProperty("companyCd")]
        public string CompanyCd { get; set; }

        [JsonProperty("userUCd")]
        public string UserUCd { get; set; }

        [JsonProperty("authKey")]
        public string AuthKey { get; set; }

        [JsonProperty("reportCd")]
        public string ReportCd { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("trxCdx")]
        public string TrxCdx { get; set; }

        [JsonProperty("enableEpoch")]
        public string EnableEpoch { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Xcgatepreview;

    public partial class WorkflowManagedActions
    {
        public XcgatepreviewActions Xcgatepreview(string connectionId) => new XcgatepreviewActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public XcgatepreviewTriggers Xcgatepreview(string connectionId) => new XcgatepreviewTriggers(connectionId);
    }
}