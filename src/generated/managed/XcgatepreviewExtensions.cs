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
        public IBodyWorkflowAction<LoginAuthResponse, ApiConnectionActionConfiguration> LoginAuth(Expression<Func<string>> host = null, Expression<Func<LoginAuthBodyInput>> body = null)
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
        public IBodyWorkflowAction<ActionFindResponse, ApiConnectionActionConfiguration> ActionFind(Expression<Func<string>> host = null, Expression<Func<ActionFindBodyInput>> body = null)
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
        public IBodyWorkflowAction<ActionGetResponse, ApiConnectionActionConfiguration> ActionGet(Expression<Func<string>> host = null, Expression<Func<ActionGetBodyInput>> body = null)
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

    public class LoginAuthBodyInput
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
        [JsonProperty("DATA1")]
        public ActionFindResponseActionListTypeItemFieldMapTypeData1Type Data1 { get; set; }

        [JsonProperty("DATA2")]
        public ActionFindResponseActionListTypeItemFieldMapTypeData2Type Data2 { get; set; }

        [JsonProperty("DATA3")]
        public ActionFindResponseActionListTypeItemFieldMapTypeData3Type Data3 { get; set; }

        [JsonProperty("DATA4")]
        public ActionFindResponseActionListTypeItemFieldMapTypeData4Type Data4 { get; set; }

        [JsonProperty("DATA5")]
        public ActionFindResponseActionListTypeItemFieldMapTypeData5Type Data5 { get; set; }

        [JsonProperty("DATA6")]
        public ActionFindResponseActionListTypeItemFieldMapTypeData6Type Data6 { get; set; }

        [JsonProperty("DATA7")]
        public ActionFindResponseActionListTypeItemFieldMapTypeData7Type Data7 { get; set; }

        [JsonProperty("DATA8")]
        public ActionFindResponseActionListTypeItemFieldMapTypeData8Type Data8 { get; set; }

        [JsonProperty("DATA9")]
        public ActionFindResponseActionListTypeItemFieldMapTypeData9Type Data9 { get; set; }

        [JsonProperty("DATA10")]
        public ActionFindResponseActionListTypeItemFieldMapTypeData10Type Data10 { get; set; }

        [JsonProperty("DATA11")]
        public ActionFindResponseActionListTypeItemFieldMapTypeData11Type Data11 { get; set; }

        [JsonProperty("DATA12")]
        public ActionFindResponseActionListTypeItemFieldMapTypeData12Type Data12 { get; set; }

        [JsonProperty("DATA13")]
        public ActionFindResponseActionListTypeItemFieldMapTypeData13Type Data13 { get; set; }

        [JsonProperty("DATA14")]
        public ActionFindResponseActionListTypeItemFieldMapTypeData14Type Data14 { get; set; }

        [JsonProperty("DATA15")]
        public ActionFindResponseActionListTypeItemFieldMapTypeData15Type Data15 { get; set; }

        [JsonProperty("DATA16")]
        public ActionFindResponseActionListTypeItemFieldMapTypeData16Type Data16 { get; set; }

        [JsonProperty("DATA17")]
        public ActionFindResponseActionListTypeItemFieldMapTypeData17Type Data17 { get; set; }

        [JsonProperty("DATA18")]
        public ActionFindResponseActionListTypeItemFieldMapTypeData18Type Data18 { get; set; }

        [JsonProperty("DATA19")]
        public ActionFindResponseActionListTypeItemFieldMapTypeData19Type Data19 { get; set; }

        [JsonProperty("DATA20")]
        public ActionFindResponseActionListTypeItemFieldMapTypeData20Type Data20 { get; set; }
    }

    public class ActionFindResponseActionListTypeItemFieldMapTypeData1Type
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
        public string ContentUrl { get; set; }

        [JsonProperty("updateTimestamp")]
        public string UpdateTimestamp { get; set; }

        [JsonProperty("updateUserCd")]
        public string UpdateUserCd { get; set; }

        [JsonProperty("updateUserName")]
        public string UpdateUserName { get; set; }
    }

    public class ActionFindResponseActionListTypeItemFieldMapTypeData2Type
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
        public string ContentUrl { get; set; }

        [JsonProperty("updateTimestamp")]
        public string UpdateTimestamp { get; set; }

        [JsonProperty("updateUserCd")]
        public string UpdateUserCd { get; set; }

        [JsonProperty("updateUserName")]
        public string UpdateUserName { get; set; }
    }

    public class ActionFindResponseActionListTypeItemFieldMapTypeData3Type
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
        public string ContentUrl { get; set; }

        [JsonProperty("updateTimestamp")]
        public string UpdateTimestamp { get; set; }

        [JsonProperty("updateUserCd")]
        public string UpdateUserCd { get; set; }

        [JsonProperty("updateUserName")]
        public string UpdateUserName { get; set; }
    }

    public class ActionFindResponseActionListTypeItemFieldMapTypeData4Type
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
        public string ContentUrl { get; set; }

        [JsonProperty("updateTimestamp")]
        public string UpdateTimestamp { get; set; }

        [JsonProperty("updateUserCd")]
        public string UpdateUserCd { get; set; }

        [JsonProperty("updateUserName")]
        public string UpdateUserName { get; set; }
    }

    public class ActionFindResponseActionListTypeItemFieldMapTypeData5Type
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
        public string ContentUrl { get; set; }

        [JsonProperty("updateTimestamp")]
        public string UpdateTimestamp { get; set; }

        [JsonProperty("updateUserCd")]
        public string UpdateUserCd { get; set; }

        [JsonProperty("updateUserName")]
        public string UpdateUserName { get; set; }
    }

    public class ActionFindResponseActionListTypeItemFieldMapTypeData6Type
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
        public string ContentUrl { get; set; }

        [JsonProperty("updateTimestamp")]
        public string UpdateTimestamp { get; set; }

        [JsonProperty("updateUserCd")]
        public string UpdateUserCd { get; set; }

        [JsonProperty("updateUserName")]
        public string UpdateUserName { get; set; }
    }

    public class ActionFindResponseActionListTypeItemFieldMapTypeData7Type
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
        public string ContentUrl { get; set; }

        [JsonProperty("updateTimestamp")]
        public string UpdateTimestamp { get; set; }

        [JsonProperty("updateUserCd")]
        public string UpdateUserCd { get; set; }

        [JsonProperty("updateUserName")]
        public string UpdateUserName { get; set; }
    }

    public class ActionFindResponseActionListTypeItemFieldMapTypeData8Type
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
        public string ContentUrl { get; set; }

        [JsonProperty("updateTimestamp")]
        public string UpdateTimestamp { get; set; }

        [JsonProperty("updateUserCd")]
        public string UpdateUserCd { get; set; }

        [JsonProperty("updateUserName")]
        public string UpdateUserName { get; set; }
    }

    public class ActionFindResponseActionListTypeItemFieldMapTypeData9Type
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
        public string ContentUrl { get; set; }

        [JsonProperty("updateTimestamp")]
        public string UpdateTimestamp { get; set; }

        [JsonProperty("updateUserCd")]
        public string UpdateUserCd { get; set; }

        [JsonProperty("updateUserName")]
        public string UpdateUserName { get; set; }
    }

    public class ActionFindResponseActionListTypeItemFieldMapTypeData10Type
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
        public string ContentUrl { get; set; }

        [JsonProperty("updateTimestamp")]
        public string UpdateTimestamp { get; set; }

        [JsonProperty("updateUserCd")]
        public string UpdateUserCd { get; set; }

        [JsonProperty("updateUserName")]
        public string UpdateUserName { get; set; }
    }

    public class ActionFindResponseActionListTypeItemFieldMapTypeData11Type
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
        public string ContentUrl { get; set; }

        [JsonProperty("updateTimestamp")]
        public string UpdateTimestamp { get; set; }

        [JsonProperty("updateUserCd")]
        public string UpdateUserCd { get; set; }

        [JsonProperty("updateUserName")]
        public string UpdateUserName { get; set; }
    }

    public class ActionFindResponseActionListTypeItemFieldMapTypeData12Type
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
        public string ContentUrl { get; set; }

        [JsonProperty("updateTimestamp")]
        public string UpdateTimestamp { get; set; }

        [JsonProperty("updateUserCd")]
        public string UpdateUserCd { get; set; }

        [JsonProperty("updateUserName")]
        public string UpdateUserName { get; set; }
    }

    public class ActionFindResponseActionListTypeItemFieldMapTypeData13Type
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
        public string ContentUrl { get; set; }

        [JsonProperty("updateTimestamp")]
        public string UpdateTimestamp { get; set; }

        [JsonProperty("updateUserCd")]
        public string UpdateUserCd { get; set; }

        [JsonProperty("updateUserName")]
        public string UpdateUserName { get; set; }
    }

    public class ActionFindResponseActionListTypeItemFieldMapTypeData14Type
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
        public string ContentUrl { get; set; }

        [JsonProperty("updateTimestamp")]
        public string UpdateTimestamp { get; set; }

        [JsonProperty("updateUserCd")]
        public string UpdateUserCd { get; set; }

        [JsonProperty("updateUserName")]
        public string UpdateUserName { get; set; }
    }

    public class ActionFindResponseActionListTypeItemFieldMapTypeData15Type
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
        public string ContentUrl { get; set; }

        [JsonProperty("updateTimestamp")]
        public string UpdateTimestamp { get; set; }

        [JsonProperty("updateUserCd")]
        public string UpdateUserCd { get; set; }

        [JsonProperty("updateUserName")]
        public string UpdateUserName { get; set; }
    }

    public class ActionFindResponseActionListTypeItemFieldMapTypeData16Type
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
        public string ContentUrl { get; set; }

        [JsonProperty("updateTimestamp")]
        public string UpdateTimestamp { get; set; }

        [JsonProperty("updateUserCd")]
        public string UpdateUserCd { get; set; }

        [JsonProperty("updateUserName")]
        public string UpdateUserName { get; set; }
    }

    public class ActionFindResponseActionListTypeItemFieldMapTypeData17Type
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
        public string ContentUrl { get; set; }

        [JsonProperty("updateTimestamp")]
        public string UpdateTimestamp { get; set; }

        [JsonProperty("updateUserCd")]
        public string UpdateUserCd { get; set; }

        [JsonProperty("updateUserName")]
        public string UpdateUserName { get; set; }
    }

    public class ActionFindResponseActionListTypeItemFieldMapTypeData18Type
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
        public string ContentUrl { get; set; }

        [JsonProperty("updateTimestamp")]
        public string UpdateTimestamp { get; set; }

        [JsonProperty("updateUserCd")]
        public string UpdateUserCd { get; set; }

        [JsonProperty("updateUserName")]
        public string UpdateUserName { get; set; }
    }

    public class ActionFindResponseActionListTypeItemFieldMapTypeData19Type
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
        public string ContentUrl { get; set; }

        [JsonProperty("updateTimestamp")]
        public string UpdateTimestamp { get; set; }

        [JsonProperty("updateUserCd")]
        public string UpdateUserCd { get; set; }

        [JsonProperty("updateUserName")]
        public string UpdateUserName { get; set; }
    }

    public class ActionFindResponseActionListTypeItemFieldMapTypeData20Type
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
        public string ContentUrl { get; set; }

        [JsonProperty("updateTimestamp")]
        public string UpdateTimestamp { get; set; }

        [JsonProperty("updateUserCd")]
        public string UpdateUserCd { get; set; }

        [JsonProperty("updateUserName")]
        public string UpdateUserName { get; set; }
    }

    public class ActionFindBodyInput
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
        public BodyInputFindType Find { get; set; }

        [JsonProperty("sortList")]
        public BodyInputSortListTypeItem[] SortList { get; set; }

        [JsonProperty("pageSize")]
        public string PageSize { get; set; }

        [JsonProperty("pageNo")]
        public string PageNo { get; set; }

        [JsonProperty("requestList")]
        public BodyInputRequestListTypeItem[] RequestList { get; set; }

        [JsonProperty("enableEpoch")]
        public string EnableEpoch { get; set; }
    }

    public class BodyInputFindType
    {
        [JsonProperty("statement")]
        public string Statement { get; set; }

        [JsonProperty("statementList")]
        public BodyInputFindTypeStatementListTypeItem[] StatementList { get; set; }
    }

    public class BodyInputFindTypeStatementListTypeItem
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("operator")]
        public string Operator { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class BodyInputSortListTypeItem
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class BodyInputRequestListTypeItem
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
        public string ContentUrl { get; set; }

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
        public string ContentUrl { get; set; }
    }

    public class ActionGetBodyInput
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