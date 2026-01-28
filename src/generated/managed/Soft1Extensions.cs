//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Soft1
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Soft1Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IWorkflowAction Microservice(Expression<Func<string>> bodybody, Expression<Func<string>> bodyendpoint)
        {
            var apiCallPath = "/custom";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["op"] = Convert.ToString("microservice");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["body"] = ExpressionConverter.ConvertO(bodybody);
            bodypropCount++;
            body["endpoint"] = ExpressionConverter.ConvertO(bodyendpoint);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<GetContactResponse> GetContact(Expression<Func<string>> bodykEY, Expression<Func<string>> bodylOCATEINFO, Expression<Func<string>> bodyfORM = null)
        {
            var apiCallPath = "/getContact";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["op"] = Convert.ToString("s1service");
            var body = new JObject();
            var bodypropCount = 0;
            body["APPID"] = 702;
            bodypropCount++;
            if (bodyfORM != null)
            {
                body["FORM"] = ExpressionConverter.ConvertO(bodyfORM);
                bodypropCount++;
            }

            bodypropCount++;
            body["KEY"] = ExpressionConverter.ConvertO(bodykEY);
            bodypropCount++;
            body["LOCATEINFO"] = ExpressionConverter.ConvertO(bodylOCATEINFO);
            body["MODE"] = "1";
            bodypropCount++;
            body["OBJECT"] = "PRSNOUT";
            bodypropCount++;
            body["SERVICE"] = "getData";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<GetContactResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<GetProjectResponse> GetProject(Expression<Func<string>> bodykEY, Expression<Func<string>> bodylOCATEINFO, Expression<Func<string>> bodyfORM = null)
        {
            var apiCallPath = "/getProject";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["op"] = Convert.ToString("s1service");
            var body = new JObject();
            var bodypropCount = 0;
            body["APPID"] = 702;
            bodypropCount++;
            if (bodyfORM != null)
            {
                body["FORM"] = ExpressionConverter.ConvertO(bodyfORM);
                bodypropCount++;
            }

            bodypropCount++;
            body["KEY"] = ExpressionConverter.ConvertO(bodykEY);
            bodypropCount++;
            body["LOCATEINFO"] = ExpressionConverter.ConvertO(bodylOCATEINFO);
            body["MODE"] = "1";
            bodypropCount++;
            body["OBJECT"] = "PRJC";
            bodypropCount++;
            body["SERVICE"] = "getData";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<GetProjectResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<GetSystemParamsResponse> GetSystemParams()
        {
            var apiCallPath = "/getSystemParams";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["op"] = Convert.ToString("s1service");
            var body = new JObject();
            var bodypropCount = 0;
            body["appId"] = "702";
            bodypropCount++;
            body["service"] = "getSystemParams";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<GetSystemParamsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<SetData200response> SetMeeting(Expression<Func<string>> bodydATAsOACTIONsERIES, Expression<Func<string>> bodydATAsOACTIONoperator = null, Expression<Func<string>> bodydATAsOACTIONoperatorContact = null, Expression<Func<bodydATAsOACTIONaCTSTATUSInput>> bodydATAsOACTIONaCTSTATUS = null, Expression<Func<string>> bodydATAsOACTIONcOMMENTS = null, Expression<Func<string>> bodydATAsOACTIONfINALDATE = null, Expression<Func<string>> bodydATAsOACTIONfROMDATE = null, Expression<Func<string>> bodydATAsOACTIONorderedBy = null, Expression<Func<string>> bodydATAsOACTIONorderedByContact = null, Expression<Func<string>> bodydATAsOACTIONpriority = null, Expression<Func<string>> bodydATAsOACTIONproject = null, Expression<Func<string>> bodydATAsOACTIONrEMARKS = null, Expression<Func<string>> bodydATAsOACTIONtRDR = null, Expression<Func<string>> bodydATAsOACTIONtRNDATE = null, Expression<Func<bodydATAxTRDOCDATAInputItem[]>> bodydATAxTRDOCDATA = null, Expression<Func<string>> bodyfORM = null, Expression<Func<string>> bodykEY = null)
        {
            var apiCallPath = "/setSomeeting";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["op"] = Convert.ToString("s1service");
            var body = new JObject();
            var bodypropCount = 0;
            body["APPID"] = 702;
            bodypropCount++;
            var dATAObject = new JObject();
            var dATAObjectpropCount = 0;
            var sOACTIONObject = new JObject();
            var sOACTIONObjectpropCount = 0;
            if (bodydATAsOACTIONoperator != null)
            {
                sOACTIONObject["ACTOR"] = ExpressionConverter.ConvertO(bodydATAsOACTIONoperator);
                sOACTIONObjectpropCount++;
            }

            if (bodydATAsOACTIONoperatorContact != null)
            {
                sOACTIONObject["ACTPRSN"] = ExpressionConverter.ConvertO(bodydATAsOACTIONoperatorContact);
                sOACTIONObjectpropCount++;
            }

            if (bodydATAsOACTIONaCTSTATUS != null)
            {
                sOACTIONObject["ACTSTATUS"] = ExpressionConverter.ConvertO(bodydATAsOACTIONaCTSTATUS);
                sOACTIONObjectpropCount++;
            }

            if (bodydATAsOACTIONcOMMENTS != null)
            {
                sOACTIONObject["COMMENTS"] = ExpressionConverter.ConvertO(bodydATAsOACTIONcOMMENTS);
                sOACTIONObjectpropCount++;
            }

            if (bodydATAsOACTIONfINALDATE != null)
            {
                sOACTIONObject["FINALDATE"] = ExpressionConverter.ConvertO(bodydATAsOACTIONfINALDATE);
                sOACTIONObjectpropCount++;
            }

            if (bodydATAsOACTIONfROMDATE != null)
            {
                sOACTIONObject["FROMDATE"] = ExpressionConverter.ConvertO(bodydATAsOACTIONfROMDATE);
                sOACTIONObjectpropCount++;
            }

            if (bodydATAsOACTIONorderedBy != null)
            {
                sOACTIONObject["ORDEREDBY"] = ExpressionConverter.ConvertO(bodydATAsOACTIONorderedBy);
                sOACTIONObjectpropCount++;
            }

            if (bodydATAsOACTIONorderedByContact != null)
            {
                sOACTIONObject["ORDPRSN"] = ExpressionConverter.ConvertO(bodydATAsOACTIONorderedByContact);
                sOACTIONObjectpropCount++;
            }

            if (bodydATAsOACTIONpriority != null)
            {
                sOACTIONObject["PRIORITY"] = ExpressionConverter.ConvertO(bodydATAsOACTIONpriority);
                sOACTIONObjectpropCount++;
            }

            if (bodydATAsOACTIONproject != null)
            {
                sOACTIONObject["PRJC"] = ExpressionConverter.ConvertO(bodydATAsOACTIONproject);
                sOACTIONObjectpropCount++;
            }

            if (bodydATAsOACTIONrEMARKS != null)
            {
                sOACTIONObject["REMARKS"] = ExpressionConverter.ConvertO(bodydATAsOACTIONrEMARKS);
                sOACTIONObjectpropCount++;
            }

            sOACTIONObjectpropCount++;
            sOACTIONObject["SERIES"] = ExpressionConverter.ConvertO(bodydATAsOACTIONsERIES);
            if (bodydATAsOACTIONtRDR != null)
            {
                sOACTIONObject["TRDR"] = ExpressionConverter.ConvertO(bodydATAsOACTIONtRDR);
                sOACTIONObjectpropCount++;
            }

            if (bodydATAsOACTIONtRNDATE != null)
            {
                sOACTIONObject["TRNDATE"] = ExpressionConverter.ConvertO(bodydATAsOACTIONtRNDATE);
                sOACTIONObjectpropCount++;
            }

            if (sOACTIONObjectpropCount > 0)
            {
                dATAObject["SOACTION"] = sOACTIONObject;
                dATAObjectpropCount++;
            }

            if (bodydATAxTRDOCDATA != null)
            {
                dATAObject["XTRDOCDATA"] = ExpressionConverter.ConvertO(bodydATAxTRDOCDATA);
                dATAObjectpropCount++;
            }

            if (dATAObjectpropCount > 0)
            {
                body["DATA"] = dATAObject;
                bodypropCount++;
            }

            if (bodyfORM != null)
            {
                body["FORM"] = ExpressionConverter.ConvertO(bodyfORM);
                bodypropCount++;
            }

            if (bodykEY != null)
            {
                body["KEY"] = ExpressionConverter.ConvertO(bodykEY);
                bodypropCount++;
            }

            body["MODE"] = "1";
            bodypropCount++;
            body["OBJECT"] = "SOMEETING";
            bodypropCount++;
            body["SERVICE"] = "setData";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SetData200response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<SetData200response> SetSOTASK(Expression<Func<string>> bodydATAsOACTIONsERIES, Expression<Func<string>> bodydATAsOACTIONoperator = null, Expression<Func<string>> bodydATAsOACTIONoperatorContact = null, Expression<Func<bodydATAsOACTIONaCTSTATUSInput>> bodydATAsOACTIONaCTSTATUS = null, Expression<Func<string>> bodydATAsOACTIONcOMMENTS = null, Expression<Func<string>> bodydATAsOACTIONfINALDATE = null, Expression<Func<string>> bodydATAsOACTIONfROMDATE = null, Expression<Func<string>> bodydATAsOACTIONorderedBy = null, Expression<Func<string>> bodydATAsOACTIONorderedByContact = null, Expression<Func<string>> bodydATAsOACTIONpriority = null, Expression<Func<string>> bodydATAsOACTIONproject = null, Expression<Func<string>> bodydATAsOACTIONrEMARKS = null, Expression<Func<string>> bodydATAsOACTIONtRDR = null, Expression<Func<string>> bodydATAsOACTIONtRNDATE = null, Expression<Func<bodydATAxTRDOCDATAInputItem[]>> bodydATAxTRDOCDATA = null, Expression<Func<string>> bodyfORM = null, Expression<Func<string>> bodykEY = null)
        {
            var apiCallPath = "/setSotask";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["op"] = Convert.ToString("s1service");
            var body = new JObject();
            var bodypropCount = 0;
            body["APPID"] = 702;
            bodypropCount++;
            var dATAObject = new JObject();
            var dATAObjectpropCount = 0;
            var sOACTIONObject = new JObject();
            var sOACTIONObjectpropCount = 0;
            if (bodydATAsOACTIONoperator != null)
            {
                sOACTIONObject["ACTOR"] = ExpressionConverter.ConvertO(bodydATAsOACTIONoperator);
                sOACTIONObjectpropCount++;
            }

            if (bodydATAsOACTIONoperatorContact != null)
            {
                sOACTIONObject["ACTPRSN"] = ExpressionConverter.ConvertO(bodydATAsOACTIONoperatorContact);
                sOACTIONObjectpropCount++;
            }

            if (bodydATAsOACTIONaCTSTATUS != null)
            {
                sOACTIONObject["ACTSTATUS"] = ExpressionConverter.ConvertO(bodydATAsOACTIONaCTSTATUS);
                sOACTIONObjectpropCount++;
            }

            if (bodydATAsOACTIONcOMMENTS != null)
            {
                sOACTIONObject["COMMENTS"] = ExpressionConverter.ConvertO(bodydATAsOACTIONcOMMENTS);
                sOACTIONObjectpropCount++;
            }

            if (bodydATAsOACTIONfINALDATE != null)
            {
                sOACTIONObject["FINALDATE"] = ExpressionConverter.ConvertO(bodydATAsOACTIONfINALDATE);
                sOACTIONObjectpropCount++;
            }

            if (bodydATAsOACTIONfROMDATE != null)
            {
                sOACTIONObject["FROMDATE"] = ExpressionConverter.ConvertO(bodydATAsOACTIONfROMDATE);
                sOACTIONObjectpropCount++;
            }

            if (bodydATAsOACTIONorderedBy != null)
            {
                sOACTIONObject["ORDEREDBY"] = ExpressionConverter.ConvertO(bodydATAsOACTIONorderedBy);
                sOACTIONObjectpropCount++;
            }

            if (bodydATAsOACTIONorderedByContact != null)
            {
                sOACTIONObject["ORDPRSN"] = ExpressionConverter.ConvertO(bodydATAsOACTIONorderedByContact);
                sOACTIONObjectpropCount++;
            }

            if (bodydATAsOACTIONpriority != null)
            {
                sOACTIONObject["PRIORITY"] = ExpressionConverter.ConvertO(bodydATAsOACTIONpriority);
                sOACTIONObjectpropCount++;
            }

            if (bodydATAsOACTIONproject != null)
            {
                sOACTIONObject["PRJC"] = ExpressionConverter.ConvertO(bodydATAsOACTIONproject);
                sOACTIONObjectpropCount++;
            }

            if (bodydATAsOACTIONrEMARKS != null)
            {
                sOACTIONObject["REMARKS"] = ExpressionConverter.ConvertO(bodydATAsOACTIONrEMARKS);
                sOACTIONObjectpropCount++;
            }

            sOACTIONObjectpropCount++;
            sOACTIONObject["SERIES"] = ExpressionConverter.ConvertO(bodydATAsOACTIONsERIES);
            if (bodydATAsOACTIONtRDR != null)
            {
                sOACTIONObject["TRDR"] = ExpressionConverter.ConvertO(bodydATAsOACTIONtRDR);
                sOACTIONObjectpropCount++;
            }

            if (bodydATAsOACTIONtRNDATE != null)
            {
                sOACTIONObject["TRNDATE"] = ExpressionConverter.ConvertO(bodydATAsOACTIONtRNDATE);
                sOACTIONObjectpropCount++;
            }

            if (sOACTIONObjectpropCount > 0)
            {
                dATAObject["SOACTION"] = sOACTIONObject;
                dATAObjectpropCount++;
            }

            if (bodydATAxTRDOCDATA != null)
            {
                dATAObject["XTRDOCDATA"] = ExpressionConverter.ConvertO(bodydATAxTRDOCDATA);
                dATAObjectpropCount++;
            }

            if (dATAObjectpropCount > 0)
            {
                body["DATA"] = dATAObject;
                bodypropCount++;
            }

            if (bodyfORM != null)
            {
                body["FORM"] = ExpressionConverter.ConvertO(bodyfORM);
                bodypropCount++;
            }

            if (bodykEY != null)
            {
                body["KEY"] = ExpressionConverter.ConvertO(bodykEY);
                bodypropCount++;
            }

            body["MODE"] = "1";
            bodypropCount++;
            body["OBJECT"] = "SOTASK";
            bodypropCount++;
            body["SERVICE"] = "setData";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SetData200response>(callPayload);
        }
    }

    public class Soft1Triggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger Webhook(Expression<Func<bodyObjectInput>> bodyObject, Expression<Func<string>> bodycondition = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/webhook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["op"] = Convert.ToString("create");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodycondition != null)
            {
                body["condition"] = ExpressionConverter.ConvertO(bodycondition);
                bodypropCount++;
            }

            var configObject = new JObject();
            var configObjectpropCount = 0;
            configObject["url"] = "@listCallbackUrl()";
            configObjectpropCount++;
            if (configObjectpropCount > 0)
            {
                body["config"] = configObject;
                bodypropCount++;
            }

            body["event"] = "ONPOST";
            bodypropCount++;
            bodypropCount++;
            body["object"] = ExpressionConverter.ConvertO(bodyObject);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger WebhookOnDelete(Expression<Func<bodyObjectInput>> bodyObject, Expression<Func<string>> bodycondition = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/webhook/onDelete";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["op"] = Convert.ToString("create");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodycondition != null)
            {
                body["condition"] = ExpressionConverter.ConvertO(bodycondition);
                bodypropCount++;
            }

            var configObject = new JObject();
            var configObjectpropCount = 0;
            configObject["url"] = "@listCallbackUrl()";
            configObjectpropCount++;
            if (configObjectpropCount > 0)
            {
                body["config"] = configObject;
                bodypropCount++;
            }

            body["event"] = "ONDELETE";
            bodypropCount++;
            bodypropCount++;
            body["object"] = ExpressionConverter.ConvertO(bodyObject);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger WebhookOnInsert(Expression<Func<bodyObjectInput>> bodyObject, Expression<Func<string>> bodycondition = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/webhook/onInsert";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["op"] = Convert.ToString("create");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodycondition != null)
            {
                body["condition"] = ExpressionConverter.ConvertO(bodycondition);
                bodypropCount++;
            }

            var configObject = new JObject();
            var configObjectpropCount = 0;
            configObject["url"] = "@listCallbackUrl()";
            configObjectpropCount++;
            if (configObjectpropCount > 0)
            {
                body["config"] = configObject;
                bodypropCount++;
            }

            body["event"] = "ONINSERT";
            bodypropCount++;
            bodypropCount++;
            body["object"] = ExpressionConverter.ConvertO(bodyObject);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger WebhookOnUpdate(Expression<Func<bodyObjectInput>> bodyObject, Expression<Func<string>> bodycondition = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/webhook/onUpdate";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["op"] = Convert.ToString("create");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodycondition != null)
            {
                body["condition"] = ExpressionConverter.ConvertO(bodycondition);
                bodypropCount++;
            }

            var configObject = new JObject();
            var configObjectpropCount = 0;
            configObject["url"] = "@listCallbackUrl()";
            configObjectpropCount++;
            if (configObjectpropCount > 0)
            {
                body["config"] = configObject;
                bodypropCount++;
            }

            body["event"] = "ONUPDATE";
            bodypropCount++;
            bodypropCount++;
            body["object"] = ExpressionConverter.ConvertO(bodyObject);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }
    }

    public class GetContactResponse
    {
        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("remoteKey")]
        public string RemoteKey { get; set; }

        [JsonProperty("data")]
        public GetContactResponseDataType Data { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("errorcode")]
        public int ErrorCode { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class GetContactResponseDataType
    {
        [JsonProperty("PRSNOUT")]
        public GetContactResponseDataTypeContactType Contact { get; set; }
        public GetContactResponseDataTypeXTRDOCDATATypeItem[] XTRDOCDATA { get; set; }
    }

    public class GetContactResponseDataTypeContactType
    {
        [JsonProperty("ADDRESS")]
        public string Address { get; set; }

        [JsonProperty("AFM")]
        public string TRNo { get; set; }

        [JsonProperty("AREAS")]
        public string GeographicalArea { get; set; }

        [JsonProperty("BIRTHDATE")]
        public string DateOfBirth { get; set; }

        [JsonProperty("BRANCH")]
        public string Branch { get; set; }

        [JsonProperty("CITY")]
        public string City { get; set; }

        [JsonProperty("CODE")]
        public string Code { get; set; }

        [JsonProperty("COUNTRY")]
        public string Country { get; set; }

        [JsonProperty("DISTRICT")]
        public string District { get; set; }

        [JsonProperty("EMAIL")]
        public string FirstEmail { get; set; }

        [JsonProperty("EMAIL1")]
        public string SecondEmail { get; set; }

        [JsonProperty("FAX")]
        public string Fax { get; set; }

        [JsonProperty("IDENTITYNUM")]
        public string IDCardNo { get; set; }

        [JsonProperty("IRSDATA")]
        public string TaxOffice { get; set; }

        [JsonProperty("ISACTIVE")]
        public string Active { get; set; }

        [JsonProperty("MOBILEPHONE")]
        public string MobileTelephone { get; set; }

        [JsonProperty("NAME")]
        public string Name { get; set; }

        [JsonProperty("NAME2")]
        public string Surname { get; set; }

        [JsonProperty("NATIONALITY")]
        public string Nationality { get; set; }

        [JsonProperty("PHONE1")]
        public string Tel1 { get; set; }

        [JsonProperty("PHONE2")]
        public string Tel2 { get; set; }

        [JsonProperty("PHONEEXT")]
        public string InternalTelephone { get; set; }

        [JsonProperty("PHONELOCAL")]
        public string PersonalTelephone { get; set; }

        [JsonProperty("REMARKS")]
        public string Comments { get; set; }

        [JsonProperty("SOSEX")]
        public string Gender { get; set; }

        [JsonProperty("WEBPAGE")]
        public string WebPage { get; set; }

        [JsonProperty("ZIP")]
        public string Zip { get; set; }
    }

    public class GetContactResponseDataTypeXTRDOCDATATypeItem
    {
        public string LINENUM { get; set; }
        public string NAME { get; set; }
        public string SOFNAME { get; set; }
    }

    public class GetProjectResponse
    {
        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("data")]
        public GetProjectResponseDataType Data { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("errorcode")]
        public int ErrorCode { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class GetProjectResponseDataType
    {
        [JsonProperty("PRJC")]
        public GetProjectResponseDataTypeProjectType Project { get; set; }
        public GetProjectResponseDataTypeXTRDOCDATATypeItem[] XTRDOCDATA { get; set; }
    }

    public class GetProjectResponseDataTypeProjectType
    {
        public string ACTSTATUS { get; set; }

        [JsonProperty("CODE")]
        public string Code { get; set; }
        public string FINALDATE { get; set; }
        public string FROMDATE { get; set; }

        [JsonProperty("ISACTIVE")]
        public string Active { get; set; }

        [JsonProperty("PRJC")]
        public string Name { get; set; }
        public string PRJCRM { get; set; }

        [JsonProperty("REMARKS")]
        public string Comments { get; set; }
    }

    public class GetProjectResponseDataTypeXTRDOCDATATypeItem
    {
        public string LINENUM { get; set; }
        public string NAME { get; set; }
        public string SOFNAME { get; set; }
    }

    public class GetSystemParamsResponse
    {
        [JsonProperty("companyinfo")]
        public GetSystemParamsResponseCompanyType Company { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("errorcode")]
        public int ErrorCode { get; set; }

        [JsonProperty("serialnumber")]
        public string SerialNumber { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class GetSystemParamsResponseCompanyType
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("afm")]
        public string TRNo { get; set; }

        [JsonProperty("branch")]
        public GetSystemParamsResponseCompanyTypeBranchType Branch { get; set; }

        [JsonProperty("district")]
        public string LocationArea { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("image")]
        public string Logo { get; set; }

        [JsonProperty("irsdata")]
        public string TaxOffice { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("phone")]
        public string TelephoneNumber { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }
    }

    public class GetSystemParamsResponseCompanyTypeBranchType
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("district")]
        public string LocationArea { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }
    }

    public class SetData200response
    {
        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("errorcode")]
        public int ErrorCode { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public enum bodydATAsOACTIONaCTSTATUSInput
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "3")]
        _3,
        [EnumMember(Value = "4")]
        _4,
        [EnumMember(Value = "5")]
        _5,
        [EnumMember(Value = "6")]
        _6
    }

    public class bodydATAxTRDOCDATAInputItem
    {
        [JsonProperty("LINENUM")]
        public string LineNo { get; set; }

        [JsonProperty("NAME")]
        public string Name { get; set; }

        [JsonProperty("SOFNAME")]
        public string Url { get; set; }
    }

    public enum bodyObjectInput
    {
        Cheque,
        [EnumMember(Value = "Collections document")]
        CollectionsDocument,
        Contacts,
        Customer,
        [EnumMember(Value = "Draft entry")]
        DraftEntry,
        Email,
        Expenses,
        [EnumMember(Value = "Expenses document")]
        ExpensesDocument,
        Meeting,
        Item,
        [EnumMember(Value = "Payments document")]
        PaymentsDocument,
        Projects,
        [EnumMember(Value = "Purchases document")]
        PurchasesDocument,
        [EnumMember(Value = "Sales document")]
        SalesDocument,
        Services,
        [EnumMember(Value = "Stock document")]
        StockDocument,
        Supplier,
        [EnumMember(Value = "Task")]
        TaskObject
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Soft1;

    public partial class WorkflowManagedActions
    {
        public Soft1Actions Soft1(string connectionId) => new Soft1Actions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Soft1Triggers Soft1(string connectionId) => new Soft1Triggers(connectionId);
    }
}