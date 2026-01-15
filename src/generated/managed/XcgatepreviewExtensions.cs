//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Xcgatepreview
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class XcgatepreviewActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "xcgatepreview")]
        public IBodyWorkflowAction<LoginAuthResponse> LoginAuth(Expression<Func<string>> host = null, Expression<Func<string>> bodycompanyCd = null, Expression<Func<string>> bodyuserCd = null, Expression<Func<string>> bodypassword = null)
        {
            var apiCallPath = "/webapi/login/auth";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (host != null)
                callPayload.Queries["host"] = ExpressionConverter.Convert(host);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodycompanyCd != null)
            {
                body["companyCd"] = ExpressionConverter.ConvertO(bodycompanyCd);
                bodypropCount++;
            }

            if (bodyuserCd != null)
            {
                body["userCd"] = ExpressionConverter.ConvertO(bodyuserCd);
                bodypropCount++;
            }

            if (bodypassword != null)
            {
                body["password"] = ExpressionConverter.ConvertO(bodypassword);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<LoginAuthResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "xcgatepreview")]
        public IBodyWorkflowAction<ActionFindResponse> ActionFind(Expression<Func<string>> host = null, Expression<Func<string>> bodycompanyCd = null, Expression<Func<string>> bodyuserUCd = null, Expression<Func<string>> bodyauthKey = null, Expression<Func<string[]>> bodyreportCdList = null, Expression<Func<string>> bodyfindstatement = null, Expression<Func<bodyfindstatementListInputItem[]>> bodyfindstatementList = null, Expression<Func<bodysortListInputItem[]>> bodysortList = null, Expression<Func<string>> bodypageSize = null, Expression<Func<string>> bodypageNo = null, Expression<Func<bodyrequestListInputItem[]>> bodyrequestList = null, Expression<Func<string>> bodyenableEpoch = null)
        {
            var apiCallPath = "/webapi/action/find";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (host != null)
                callPayload.Queries["host"] = ExpressionConverter.Convert(host);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodycompanyCd != null)
            {
                body["companyCd"] = ExpressionConverter.ConvertO(bodycompanyCd);
                bodypropCount++;
            }

            if (bodyuserUCd != null)
            {
                body["userUCd"] = ExpressionConverter.ConvertO(bodyuserUCd);
                bodypropCount++;
            }

            if (bodyauthKey != null)
            {
                body["authKey"] = ExpressionConverter.ConvertO(bodyauthKey);
                bodypropCount++;
            }

            if (bodyreportCdList != null)
            {
                body["reportCdList"] = ExpressionConverter.ConvertO(bodyreportCdList);
                bodypropCount++;
            }

            var findObject = new JObject();
            var findObjectpropCount = 0;
            if (bodyfindstatement != null)
            {
                findObject["statement"] = ExpressionConverter.ConvertO(bodyfindstatement);
                findObjectpropCount++;
            }

            if (bodyfindstatementList != null)
            {
                findObject["statementList"] = ExpressionConverter.ConvertO(bodyfindstatementList);
                findObjectpropCount++;
            }

            if (findObjectpropCount > 0)
            {
                body["find"] = findObject;
                bodypropCount++;
            }

            if (bodysortList != null)
            {
                body["sortList"] = ExpressionConverter.ConvertO(bodysortList);
                bodypropCount++;
            }

            if (bodypageSize != null)
            {
                body["pageSize"] = ExpressionConverter.ConvertO(bodypageSize);
                bodypropCount++;
            }

            if (bodypageNo != null)
            {
                body["pageNo"] = ExpressionConverter.ConvertO(bodypageNo);
                bodypropCount++;
            }

            if (bodyrequestList != null)
            {
                body["requestList"] = ExpressionConverter.ConvertO(bodyrequestList);
                bodypropCount++;
            }

            if (bodyenableEpoch != null)
            {
                body["enableEpoch"] = ExpressionConverter.ConvertO(bodyenableEpoch);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ActionFindResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "xcgatepreview")]
        public IBodyWorkflowAction<ActionGetResponse> ActionGet(Expression<Func<string>> host = null, Expression<Func<string>> bodycompanyCd = null, Expression<Func<string>> bodyuserUCd = null, Expression<Func<string>> bodyauthKey = null, Expression<Func<string>> bodyreportCd = null, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodytrxCdx = null, Expression<Func<string>> bodyenableEpoch = null)
        {
            var apiCallPath = "/webapi/action/get";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (host != null)
                callPayload.Queries["host"] = ExpressionConverter.Convert(host);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodycompanyCd != null)
            {
                body["companyCd"] = ExpressionConverter.ConvertO(bodycompanyCd);
                bodypropCount++;
            }

            if (bodyuserUCd != null)
            {
                body["userUCd"] = ExpressionConverter.ConvertO(bodyuserUCd);
                bodypropCount++;
            }

            if (bodyauthKey != null)
            {
                body["authKey"] = ExpressionConverter.ConvertO(bodyauthKey);
                bodypropCount++;
            }

            if (bodyreportCd != null)
            {
                body["reportCd"] = ExpressionConverter.ConvertO(bodyreportCd);
                bodypropCount++;
            }

            if (bodytitle != null)
            {
                body["title"] = ExpressionConverter.ConvertO(bodytitle);
                bodypropCount++;
            }

            if (bodytrxCdx != null)
            {
                body["trxCdx"] = ExpressionConverter.ConvertO(bodytrxCdx);
                bodypropCount++;
            }

            if (bodyenableEpoch != null)
            {
                body["enableEpoch"] = ExpressionConverter.ConvertO(bodyenableEpoch);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ActionGetResponse>(callPayload);
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

    public class bodyfindstatementListInputItem
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("operator")]
        public string Operator { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class bodysortListInputItem
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class bodyrequestListInputItem
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
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Xcgatepreview;

    public partial class WorkflowManagedActions
    {
        public XcgatepreviewActions Xcgatepreview(string connectionId) => new XcgatepreviewActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public XcgatepreviewTriggers Xcgatepreview(string connectionId) => new XcgatepreviewTriggers(connectionId);
    }
}