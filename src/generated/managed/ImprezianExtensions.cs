//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Imprezian
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ImprezianActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<string[]> CampaignGetValues()
        {
            var apiCallPath = "/api/Campaign";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<JToken> CampaignPostValue(Expression<Func<string>> bodydescription, Expression<Func<string>> bodyexpires, Expression<Func<double>> bodybudget, Expression<Func<string>> bodystartdate = null, Expression<Func<string>> bodypromotype = null, Expression<Func<string>> bodymanager = null)
        {
            var apiCallPath = "/api/Campaign";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["description"] = CSharpExpressionConverter.ConvertToken(bodydescription);
            if (bodystartdate != null)
            {
                body["startdate"] = CSharpExpressionConverter.ConvertToken(bodystartdate);
                bodypropCount++;
            }

            bodypropCount++;
            body["expires"] = CSharpExpressionConverter.ConvertToken(bodyexpires);
            bodypropCount++;
            body["budget"] = CSharpExpressionConverter.ConvertToken(bodybudget);
            if (bodypromotype != null)
            {
                body["promotype"] = CSharpExpressionConverter.ConvertToken(bodypromotype);
                bodypropCount++;
            }

            if (bodymanager != null)
            {
                body["manager"] = CSharpExpressionConverter.ConvertToken(bodymanager);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<CampaignGetValueResponse> CampaignGetValue(Expression<Func<string>> id)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/Campaign/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<CampaignGetValueResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<JToken> CampaignPutValue(Expression<Func<string>> id, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodystartdate = null, Expression<Func<string>> bodyexpires = null, Expression<Func<double>> bodybudget = null, Expression<Func<string>> bodymanager = null, Expression<Func<bool>> bodyhistory = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/Campaign/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodydescription != null)
            {
                body["description"] = CSharpExpressionConverter.ConvertToken(bodydescription);
                bodypropCount++;
            }

            if (bodystartdate != null)
            {
                body["startdate"] = CSharpExpressionConverter.ConvertToken(bodystartdate);
                bodypropCount++;
            }

            if (bodyexpires != null)
            {
                body["expires"] = CSharpExpressionConverter.ConvertToken(bodyexpires);
                bodypropCount++;
            }

            if (bodybudget != null)
            {
                body["budget"] = CSharpExpressionConverter.ConvertToken(bodybudget);
                bodypropCount++;
            }

            if (bodymanager != null)
            {
                body["manager"] = CSharpExpressionConverter.ConvertToken(bodymanager);
                bodypropCount++;
            }

            if (bodyhistory != null)
            {
                body["history"] = CSharpExpressionConverter.ConvertToken(bodyhistory);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<string[]> ComLogGetValues()
        {
            var apiCallPath = "/api/ComLog";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<JToken> ComLogPostValue(Expression<Func<string>> bodycontactid = null, Expression<Func<string>> bodyleadid = null, Expression<Func<bodytypeInput>> bodytype = null, Expression<Func<string>> bodysubject = null, Expression<Func<string>> bodybody = null, Expression<Func<string>> bodyemployee = null, Expression<Func<string>> bodystarttime = null, Expression<Func<string>> bodyendtime = null, Expression<Func<string>> bodyworkorder = null, Expression<Func<string>> bodyproject = null, Expression<Func<string>> bodycampaign = null, Expression<Func<double>> bodylength = null, Expression<Func<bool>> bodybilled = null, Expression<Func<bool>> bodyinbound = null)
        {
            var apiCallPath = "/api/ComLog";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodycontactid != null)
            {
                body["contactid"] = CSharpExpressionConverter.ConvertToken(bodycontactid);
                bodypropCount++;
            }

            if (bodyleadid != null)
            {
                body["leadid"] = CSharpExpressionConverter.ConvertToken(bodyleadid);
                bodypropCount++;
            }

            if (bodytype != null)
            {
                body["type"] = CSharpExpressionConverter.Convert(bodytype);
                bodypropCount++;
            }

            if (bodysubject != null)
            {
                body["subject"] = CSharpExpressionConverter.ConvertToken(bodysubject);
                bodypropCount++;
            }

            if (bodybody != null)
            {
                body["body"] = CSharpExpressionConverter.ConvertToken(bodybody);
                bodypropCount++;
            }

            if (bodyemployee != null)
            {
                body["employee"] = CSharpExpressionConverter.ConvertToken(bodyemployee);
                bodypropCount++;
            }

            if (bodystarttime != null)
            {
                body["starttime"] = CSharpExpressionConverter.ConvertToken(bodystarttime);
                bodypropCount++;
            }

            if (bodyendtime != null)
            {
                body["endtime"] = CSharpExpressionConverter.ConvertToken(bodyendtime);
                bodypropCount++;
            }

            if (bodyworkorder != null)
            {
                body["workorder"] = CSharpExpressionConverter.ConvertToken(bodyworkorder);
                bodypropCount++;
            }

            if (bodyproject != null)
            {
                body["project"] = CSharpExpressionConverter.ConvertToken(bodyproject);
                bodypropCount++;
            }

            if (bodycampaign != null)
            {
                body["campaign"] = CSharpExpressionConverter.ConvertToken(bodycampaign);
                bodypropCount++;
            }

            if (bodylength != null)
            {
                body["length"] = CSharpExpressionConverter.ConvertToken(bodylength);
                bodypropCount++;
            }

            if (bodybilled != null)
            {
                body["billed"] = CSharpExpressionConverter.ConvertToken(bodybilled);
                bodypropCount++;
            }

            if (bodyinbound != null)
            {
                body["inbound"] = CSharpExpressionConverter.ConvertToken(bodyinbound);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<ComLogGetValueResponse> ComLogGetValue(Expression<Func<string>> id)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/ComLog/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ComLogGetValueResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IWorkflowAction ComLogPutValue(Expression<Func<string>> id, Expression<Func<bodytypeInput>> bodytype = null, Expression<Func<string>> bodysubject = null, Expression<Func<string>> bodybody = null, Expression<Func<string>> bodyemployee = null, Expression<Func<string>> bodystarttime = null, Expression<Func<string>> bodyendtime = null, Expression<Func<string>> bodyworkorder = null, Expression<Func<string>> bodyproject = null, Expression<Func<string>> bodycampaign = null, Expression<Func<double>> bodylength = null, Expression<Func<bool>> bodybilled = null, Expression<Func<bool>> bodyinbound = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/ComLog/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytype != null)
            {
                body["type"] = CSharpExpressionConverter.Convert(bodytype);
                bodypropCount++;
            }

            if (bodysubject != null)
            {
                body["subject"] = CSharpExpressionConverter.ConvertToken(bodysubject);
                bodypropCount++;
            }

            if (bodybody != null)
            {
                body["body"] = CSharpExpressionConverter.ConvertToken(bodybody);
                bodypropCount++;
            }

            if (bodyemployee != null)
            {
                body["employee"] = CSharpExpressionConverter.ConvertToken(bodyemployee);
                bodypropCount++;
            }

            if (bodystarttime != null)
            {
                body["starttime"] = CSharpExpressionConverter.ConvertToken(bodystarttime);
                bodypropCount++;
            }

            if (bodyendtime != null)
            {
                body["endtime"] = CSharpExpressionConverter.ConvertToken(bodyendtime);
                bodypropCount++;
            }

            if (bodyworkorder != null)
            {
                body["workorder"] = CSharpExpressionConverter.ConvertToken(bodyworkorder);
                bodypropCount++;
            }

            if (bodyproject != null)
            {
                body["project"] = CSharpExpressionConverter.ConvertToken(bodyproject);
                bodypropCount++;
            }

            if (bodycampaign != null)
            {
                body["campaign"] = CSharpExpressionConverter.ConvertToken(bodycampaign);
                bodypropCount++;
            }

            if (bodylength != null)
            {
                body["length"] = CSharpExpressionConverter.ConvertToken(bodylength);
                bodypropCount++;
            }

            if (bodybilled != null)
            {
                body["billed"] = CSharpExpressionConverter.ConvertToken(bodybilled);
                bodypropCount++;
            }

            if (bodyinbound != null)
            {
                body["inbound"] = CSharpExpressionConverter.ConvertToken(bodyinbound);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<string[]> ContactGetValues()
        {
            var apiCallPath = "/api/Contact";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<JToken> ContactPostValue(Expression<Func<string>> bodyaccount = null, Expression<Func<string>> bodysal = null, Expression<Func<string>> bodyfirstname = null, Expression<Func<string>> bodymiddlename = null, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodylastname = null, Expression<Func<string>> bodycompany = null, Expression<Func<string>> bodyaddr1 = null, Expression<Func<string>> bodyaddr2 = null, Expression<Func<string>> bodycity = null, Expression<Func<string>> bodystate = null, Expression<Func<string>> bodypostal = null, Expression<Func<string>> bodyemail1 = null, Expression<Func<string>> bodyemail2 = null, Expression<Func<string>> bodyemail3 = null, Expression<Func<string>> bodyemail4 = null, Expression<Func<string>> bodyphonetype1 = null, Expression<Func<string>> bodyphone1 = null, Expression<Func<string>> bodyphonetype2 = null, Expression<Func<string>> bodyphone2 = null, Expression<Func<string>> bodyphonetype3 = null, Expression<Func<string>> bodyphone3 = null, Expression<Func<string>> bodyphonetype4 = null, Expression<Func<string>> bodyphone4 = null, Expression<Func<string>> bodyremark = null, Expression<Func<string>> bodynotes = null, Expression<Func<string>> bodycampaign = null, Expression<Func<string>> bodycategory = null, Expression<Func<string>> bodymarket = null, Expression<Func<string>> bodyterritory = null, Expression<Func<string>> bodysalesrep = null, Expression<Func<string>> bodylastcontact = null)
        {
            var apiCallPath = "/api/Contact";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyaccount != null)
            {
                body["account"] = CSharpExpressionConverter.ConvertToken(bodyaccount);
                bodypropCount++;
            }

            if (bodysal != null)
            {
                body["sal"] = CSharpExpressionConverter.ConvertToken(bodysal);
                bodypropCount++;
            }

            if (bodyfirstname != null)
            {
                body["firstname"] = CSharpExpressionConverter.ConvertToken(bodyfirstname);
                bodypropCount++;
            }

            if (bodymiddlename != null)
            {
                body["middlename"] = CSharpExpressionConverter.ConvertToken(bodymiddlename);
                bodypropCount++;
            }

            if (bodytitle != null)
            {
                body["title"] = CSharpExpressionConverter.ConvertToken(bodytitle);
                bodypropCount++;
            }

            if (bodylastname != null)
            {
                body["lastname"] = CSharpExpressionConverter.ConvertToken(bodylastname);
                bodypropCount++;
            }

            if (bodycompany != null)
            {
                body["company"] = CSharpExpressionConverter.ConvertToken(bodycompany);
                bodypropCount++;
            }

            if (bodyaddr1 != null)
            {
                body["addr1"] = CSharpExpressionConverter.ConvertToken(bodyaddr1);
                bodypropCount++;
            }

            if (bodyaddr2 != null)
            {
                body["addr2"] = CSharpExpressionConverter.ConvertToken(bodyaddr2);
                bodypropCount++;
            }

            if (bodycity != null)
            {
                body["city"] = CSharpExpressionConverter.ConvertToken(bodycity);
                bodypropCount++;
            }

            if (bodystate != null)
            {
                body["state"] = CSharpExpressionConverter.ConvertToken(bodystate);
                bodypropCount++;
            }

            if (bodypostal != null)
            {
                body["postal"] = CSharpExpressionConverter.ConvertToken(bodypostal);
                bodypropCount++;
            }

            if (bodyemail1 != null)
            {
                body["email1"] = CSharpExpressionConverter.ConvertToken(bodyemail1);
                bodypropCount++;
            }

            if (bodyemail2 != null)
            {
                body["email2"] = CSharpExpressionConverter.ConvertToken(bodyemail2);
                bodypropCount++;
            }

            if (bodyemail3 != null)
            {
                body["email3"] = CSharpExpressionConverter.ConvertToken(bodyemail3);
                bodypropCount++;
            }

            if (bodyemail4 != null)
            {
                body["email4"] = CSharpExpressionConverter.ConvertToken(bodyemail4);
                bodypropCount++;
            }

            if (bodyphonetype1 != null)
            {
                body["phonetype1"] = CSharpExpressionConverter.ConvertToken(bodyphonetype1);
                bodypropCount++;
            }

            if (bodyphone1 != null)
            {
                body["phone1"] = CSharpExpressionConverter.ConvertToken(bodyphone1);
                bodypropCount++;
            }

            if (bodyphonetype2 != null)
            {
                body["phonetype2"] = CSharpExpressionConverter.ConvertToken(bodyphonetype2);
                bodypropCount++;
            }

            if (bodyphone2 != null)
            {
                body["phone2"] = CSharpExpressionConverter.ConvertToken(bodyphone2);
                bodypropCount++;
            }

            if (bodyphonetype3 != null)
            {
                body["phonetype3"] = CSharpExpressionConverter.ConvertToken(bodyphonetype3);
                bodypropCount++;
            }

            if (bodyphone3 != null)
            {
                body["phone3"] = CSharpExpressionConverter.ConvertToken(bodyphone3);
                bodypropCount++;
            }

            if (bodyphonetype4 != null)
            {
                body["phonetype4"] = CSharpExpressionConverter.ConvertToken(bodyphonetype4);
                bodypropCount++;
            }

            if (bodyphone4 != null)
            {
                body["phone4"] = CSharpExpressionConverter.ConvertToken(bodyphone4);
                bodypropCount++;
            }

            if (bodyremark != null)
            {
                body["remark"] = CSharpExpressionConverter.ConvertToken(bodyremark);
                bodypropCount++;
            }

            if (bodynotes != null)
            {
                body["notes"] = CSharpExpressionConverter.ConvertToken(bodynotes);
                bodypropCount++;
            }

            if (bodycampaign != null)
            {
                body["campaign"] = CSharpExpressionConverter.ConvertToken(bodycampaign);
                bodypropCount++;
            }

            if (bodycategory != null)
            {
                body["category"] = CSharpExpressionConverter.ConvertToken(bodycategory);
                bodypropCount++;
            }

            if (bodymarket != null)
            {
                body["market"] = CSharpExpressionConverter.ConvertToken(bodymarket);
                bodypropCount++;
            }

            if (bodyterritory != null)
            {
                body["territory"] = CSharpExpressionConverter.ConvertToken(bodyterritory);
                bodypropCount++;
            }

            if (bodysalesrep != null)
            {
                body["salesrep"] = CSharpExpressionConverter.ConvertToken(bodysalesrep);
                bodypropCount++;
            }

            if (bodylastcontact != null)
            {
                body["lastcontact"] = CSharpExpressionConverter.ConvertToken(bodylastcontact);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<JToken> ContactGetValue(Expression<Func<string>> id)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/Contact/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<JToken> ContactPutValue(Expression<Func<string>> id, Expression<Func<string>> bodysal = null, Expression<Func<string>> bodyfirstname = null, Expression<Func<string>> bodymiddlename = null, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodylastname = null, Expression<Func<string>> bodycompany = null, Expression<Func<string>> bodyaddr1 = null, Expression<Func<string>> bodyaddr2 = null, Expression<Func<string>> bodycity = null, Expression<Func<string>> bodystate = null, Expression<Func<string>> bodypostal = null, Expression<Func<string>> bodyemail1 = null, Expression<Func<string>> bodyemail2 = null, Expression<Func<string>> bodyemail3 = null, Expression<Func<string>> bodyemail4 = null, Expression<Func<string>> bodyphonetype1 = null, Expression<Func<string>> bodyphone1 = null, Expression<Func<string>> bodyphonetype2 = null, Expression<Func<string>> bodyphone2 = null, Expression<Func<string>> bodyphonetype3 = null, Expression<Func<string>> bodyphone3 = null, Expression<Func<string>> bodyphonetype4 = null, Expression<Func<string>> bodyphone4 = null, Expression<Func<string>> bodyremark = null, Expression<Func<string>> bodynotes = null, Expression<Func<string>> bodycampaign = null, Expression<Func<string>> bodycategory = null, Expression<Func<string>> bodymarket = null, Expression<Func<string>> bodyterritory = null, Expression<Func<string>> bodysalesrep = null, Expression<Func<string>> bodylastcontact = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/Contact/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodysal != null)
            {
                body["sal"] = CSharpExpressionConverter.ConvertToken(bodysal);
                bodypropCount++;
            }

            if (bodyfirstname != null)
            {
                body["firstname"] = CSharpExpressionConverter.ConvertToken(bodyfirstname);
                bodypropCount++;
            }

            if (bodymiddlename != null)
            {
                body["middlename"] = CSharpExpressionConverter.ConvertToken(bodymiddlename);
                bodypropCount++;
            }

            if (bodytitle != null)
            {
                body["title"] = CSharpExpressionConverter.ConvertToken(bodytitle);
                bodypropCount++;
            }

            if (bodylastname != null)
            {
                body["lastname"] = CSharpExpressionConverter.ConvertToken(bodylastname);
                bodypropCount++;
            }

            if (bodycompany != null)
            {
                body["company"] = CSharpExpressionConverter.ConvertToken(bodycompany);
                bodypropCount++;
            }

            if (bodyaddr1 != null)
            {
                body["addr1"] = CSharpExpressionConverter.ConvertToken(bodyaddr1);
                bodypropCount++;
            }

            if (bodyaddr2 != null)
            {
                body["addr2"] = CSharpExpressionConverter.ConvertToken(bodyaddr2);
                bodypropCount++;
            }

            if (bodycity != null)
            {
                body["city"] = CSharpExpressionConverter.ConvertToken(bodycity);
                bodypropCount++;
            }

            if (bodystate != null)
            {
                body["state"] = CSharpExpressionConverter.ConvertToken(bodystate);
                bodypropCount++;
            }

            if (bodypostal != null)
            {
                body["postal"] = CSharpExpressionConverter.ConvertToken(bodypostal);
                bodypropCount++;
            }

            if (bodyemail1 != null)
            {
                body["email1"] = CSharpExpressionConverter.ConvertToken(bodyemail1);
                bodypropCount++;
            }

            if (bodyemail2 != null)
            {
                body["email2"] = CSharpExpressionConverter.ConvertToken(bodyemail2);
                bodypropCount++;
            }

            if (bodyemail3 != null)
            {
                body["email3"] = CSharpExpressionConverter.ConvertToken(bodyemail3);
                bodypropCount++;
            }

            if (bodyemail4 != null)
            {
                body["email4"] = CSharpExpressionConverter.ConvertToken(bodyemail4);
                bodypropCount++;
            }

            if (bodyphonetype1 != null)
            {
                body["phonetype1"] = CSharpExpressionConverter.ConvertToken(bodyphonetype1);
                bodypropCount++;
            }

            if (bodyphone1 != null)
            {
                body["phone1"] = CSharpExpressionConverter.ConvertToken(bodyphone1);
                bodypropCount++;
            }

            if (bodyphonetype2 != null)
            {
                body["phonetype2"] = CSharpExpressionConverter.ConvertToken(bodyphonetype2);
                bodypropCount++;
            }

            if (bodyphone2 != null)
            {
                body["phone2"] = CSharpExpressionConverter.ConvertToken(bodyphone2);
                bodypropCount++;
            }

            if (bodyphonetype3 != null)
            {
                body["phonetype3"] = CSharpExpressionConverter.ConvertToken(bodyphonetype3);
                bodypropCount++;
            }

            if (bodyphone3 != null)
            {
                body["phone3"] = CSharpExpressionConverter.ConvertToken(bodyphone3);
                bodypropCount++;
            }

            if (bodyphonetype4 != null)
            {
                body["phonetype4"] = CSharpExpressionConverter.ConvertToken(bodyphonetype4);
                bodypropCount++;
            }

            if (bodyphone4 != null)
            {
                body["phone4"] = CSharpExpressionConverter.ConvertToken(bodyphone4);
                bodypropCount++;
            }

            if (bodyremark != null)
            {
                body["remark"] = CSharpExpressionConverter.ConvertToken(bodyremark);
                bodypropCount++;
            }

            if (bodynotes != null)
            {
                body["notes"] = CSharpExpressionConverter.ConvertToken(bodynotes);
                bodypropCount++;
            }

            if (bodycampaign != null)
            {
                body["campaign"] = CSharpExpressionConverter.ConvertToken(bodycampaign);
                bodypropCount++;
            }

            if (bodycategory != null)
            {
                body["category"] = CSharpExpressionConverter.ConvertToken(bodycategory);
                bodypropCount++;
            }

            if (bodymarket != null)
            {
                body["market"] = CSharpExpressionConverter.ConvertToken(bodymarket);
                bodypropCount++;
            }

            if (bodyterritory != null)
            {
                body["territory"] = CSharpExpressionConverter.ConvertToken(bodyterritory);
                bodypropCount++;
            }

            if (bodysalesrep != null)
            {
                body["salesrep"] = CSharpExpressionConverter.ConvertToken(bodysalesrep);
                bodypropCount++;
            }

            if (bodylastcontact != null)
            {
                body["lastcontact"] = CSharpExpressionConverter.ConvertToken(bodylastcontact);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<string[]> FollowUpGetValues()
        {
            var apiCallPath = "/api/FollowUp";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<JToken> FollowUpPostValue(Expression<Func<string>> bodycontactid = null, Expression<Func<string>> bodyleadid = null, Expression<Func<string>> bodytype = null, Expression<Func<string>> bodycomments = null, Expression<Func<string>> bodyassignedto = null, Expression<Func<string>> bodysetby = null, Expression<Func<string>> bodyduedate = null, Expression<Func<bool>> bodyurgent = null, Expression<Func<double>> bodyreminderminutes = null, Expression<Func<bool>> bodycleared = null)
        {
            var apiCallPath = "/api/FollowUp";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodycontactid != null)
            {
                body["contactid"] = CSharpExpressionConverter.ConvertToken(bodycontactid);
                bodypropCount++;
            }

            if (bodyleadid != null)
            {
                body["leadid"] = CSharpExpressionConverter.ConvertToken(bodyleadid);
                bodypropCount++;
            }

            if (bodytype != null)
            {
                body["type"] = CSharpExpressionConverter.ConvertToken(bodytype);
                bodypropCount++;
            }

            if (bodycomments != null)
            {
                body["comments"] = CSharpExpressionConverter.ConvertToken(bodycomments);
                bodypropCount++;
            }

            if (bodyassignedto != null)
            {
                body["assignedto"] = CSharpExpressionConverter.ConvertToken(bodyassignedto);
                bodypropCount++;
            }

            if (bodysetby != null)
            {
                body["setby"] = CSharpExpressionConverter.ConvertToken(bodysetby);
                bodypropCount++;
            }

            if (bodyduedate != null)
            {
                body["duedate"] = CSharpExpressionConverter.ConvertToken(bodyduedate);
                bodypropCount++;
            }

            if (bodyurgent != null)
            {
                body["urgent"] = CSharpExpressionConverter.ConvertToken(bodyurgent);
                bodypropCount++;
            }

            if (bodyreminderminutes != null)
            {
                body["reminderminutes"] = CSharpExpressionConverter.ConvertToken(bodyreminderminutes);
                bodypropCount++;
            }

            if (bodycleared != null)
            {
                body["cleared"] = CSharpExpressionConverter.ConvertToken(bodycleared);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<FollowUpGetValueResponse> FollowUpGetValue(Expression<Func<string>> id)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/FollowUp/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<FollowUpGetValueResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IWorkflowAction FollowUpPutValue(Expression<Func<string>> id, Expression<Func<string>> bodytype = null, Expression<Func<string>> bodycomments = null, Expression<Func<string>> bodyassignedto = null, Expression<Func<string>> bodysetby = null, Expression<Func<string>> bodyduedate = null, Expression<Func<string>> bodyurgent = null, Expression<Func<double>> bodyreminderminutes = null, Expression<Func<bool>> bodycleared = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/FollowUp/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytype != null)
            {
                body["type"] = CSharpExpressionConverter.ConvertToken(bodytype);
                bodypropCount++;
            }

            if (bodycomments != null)
            {
                body["comments"] = CSharpExpressionConverter.ConvertToken(bodycomments);
                bodypropCount++;
            }

            if (bodyassignedto != null)
            {
                body["assignedto"] = CSharpExpressionConverter.ConvertToken(bodyassignedto);
                bodypropCount++;
            }

            if (bodysetby != null)
            {
                body["setby"] = CSharpExpressionConverter.ConvertToken(bodysetby);
                bodypropCount++;
            }

            if (bodyduedate != null)
            {
                body["duedate"] = CSharpExpressionConverter.ConvertToken(bodyduedate);
                bodypropCount++;
            }

            if (bodyurgent != null)
            {
                body["urgent"] = CSharpExpressionConverter.ConvertToken(bodyurgent);
                bodypropCount++;
            }

            if (bodyreminderminutes != null)
            {
                body["reminderminutes"] = CSharpExpressionConverter.ConvertToken(bodyreminderminutes);
                bodypropCount++;
            }

            if (bodycleared != null)
            {
                body["cleared"] = CSharpExpressionConverter.ConvertToken(bodycleared);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<string[]> ItemListGetValues()
        {
            var apiCallPath = "/api/ItemList";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<ItemListPostValueResponse> ItemListPostValue(Expression<Func<string>> bodymodelno = null, Expression<Func<string>> bodydescrip = null, Expression<Func<bodyitemtypeInput>> bodyitemtype = null, Expression<Func<double>> bodyprice = null, Expression<Func<double>> bodycost = null, Expression<Func<string>> bodyvendor = null)
        {
            var apiCallPath = "/api/ItemList";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodymodelno != null)
            {
                body["modelno"] = CSharpExpressionConverter.ConvertToken(bodymodelno);
                bodypropCount++;
            }

            if (bodydescrip != null)
            {
                body["descrip"] = CSharpExpressionConverter.ConvertToken(bodydescrip);
                bodypropCount++;
            }

            if (bodyitemtype != null)
            {
                body["itemtype"] = CSharpExpressionConverter.Convert(bodyitemtype);
                bodypropCount++;
            }

            if (bodyprice != null)
            {
                body["price"] = CSharpExpressionConverter.ConvertToken(bodyprice);
                bodypropCount++;
            }

            if (bodycost != null)
            {
                body["cost"] = CSharpExpressionConverter.ConvertToken(bodycost);
                bodypropCount++;
            }

            if (bodyvendor != null)
            {
                body["vendor"] = CSharpExpressionConverter.ConvertToken(bodyvendor);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ItemListPostValueResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<ItemListGetValueResponse> ItemListGetValue(Expression<Func<string>> id)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/ItemList/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ItemListGetValueResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IWorkflowAction ItemListPutValue(Expression<Func<string>> id, Expression<Func<string>> bodydescrip = null, Expression<Func<double>> bodyprice = null, Expression<Func<double>> bodycost = null, Expression<Func<string>> bodyvendor = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/ItemList/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodydescrip != null)
            {
                body["descrip"] = CSharpExpressionConverter.ConvertToken(bodydescrip);
                bodypropCount++;
            }

            if (bodyprice != null)
            {
                body["price"] = CSharpExpressionConverter.ConvertToken(bodyprice);
                bodypropCount++;
            }

            if (bodycost != null)
            {
                body["cost"] = CSharpExpressionConverter.ConvertToken(bodycost);
                bodypropCount++;
            }

            if (bodyvendor != null)
            {
                body["vendor"] = CSharpExpressionConverter.ConvertToken(bodyvendor);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<string[]> LeadGetValues()
        {
            var apiCallPath = "/api/Lead";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<JToken> LeadPostValue(Expression<Func<string>> bodysal = null, Expression<Func<string>> bodyfirstname = null, Expression<Func<string>> bodymiddlename = null, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodylastname = null, Expression<Func<string>> bodycompany = null, Expression<Func<string>> bodyaddr1 = null, Expression<Func<string>> bodyaddr2 = null, Expression<Func<string>> bodycity = null, Expression<Func<string>> bodystate = null, Expression<Func<string>> bodypostal = null, Expression<Func<string>> bodyemail1 = null, Expression<Func<string>> bodyemail2 = null, Expression<Func<string>> bodyemail3 = null, Expression<Func<string>> bodyemail4 = null, Expression<Func<string>> bodyphonetype1 = null, Expression<Func<string>> bodyphone1 = null, Expression<Func<string>> bodyphonetype2 = null, Expression<Func<string>> bodyphone2 = null, Expression<Func<string>> bodyphonetype3 = null, Expression<Func<string>> bodyphone3 = null, Expression<Func<string>> bodyphonetype4 = null, Expression<Func<string>> bodyphone4 = null, Expression<Func<string>> bodyremark = null, Expression<Func<string>> bodynotes = null, Expression<Func<string>> bodycampaign = null, Expression<Func<string>> bodycategory = null, Expression<Func<string>> bodyrole = null, Expression<Func<string>> bodymarket = null, Expression<Func<string>> bodyterritory = null, Expression<Func<string>> bodysalesrep = null, Expression<Func<string>> bodylastcontact = null)
        {
            var apiCallPath = "/api/Lead";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodysal != null)
            {
                body["sal"] = CSharpExpressionConverter.ConvertToken(bodysal);
                bodypropCount++;
            }

            if (bodyfirstname != null)
            {
                body["firstname"] = CSharpExpressionConverter.ConvertToken(bodyfirstname);
                bodypropCount++;
            }

            if (bodymiddlename != null)
            {
                body["middlename"] = CSharpExpressionConverter.ConvertToken(bodymiddlename);
                bodypropCount++;
            }

            if (bodytitle != null)
            {
                body["title"] = CSharpExpressionConverter.ConvertToken(bodytitle);
                bodypropCount++;
            }

            if (bodylastname != null)
            {
                body["lastname"] = CSharpExpressionConverter.ConvertToken(bodylastname);
                bodypropCount++;
            }

            if (bodycompany != null)
            {
                body["company"] = CSharpExpressionConverter.ConvertToken(bodycompany);
                bodypropCount++;
            }

            if (bodyaddr1 != null)
            {
                body["addr1"] = CSharpExpressionConverter.ConvertToken(bodyaddr1);
                bodypropCount++;
            }

            if (bodyaddr2 != null)
            {
                body["addr2"] = CSharpExpressionConverter.ConvertToken(bodyaddr2);
                bodypropCount++;
            }

            if (bodycity != null)
            {
                body["city"] = CSharpExpressionConverter.ConvertToken(bodycity);
                bodypropCount++;
            }

            if (bodystate != null)
            {
                body["state"] = CSharpExpressionConverter.ConvertToken(bodystate);
                bodypropCount++;
            }

            if (bodypostal != null)
            {
                body["postal"] = CSharpExpressionConverter.ConvertToken(bodypostal);
                bodypropCount++;
            }

            if (bodyemail1 != null)
            {
                body["email1"] = CSharpExpressionConverter.ConvertToken(bodyemail1);
                bodypropCount++;
            }

            if (bodyemail2 != null)
            {
                body["email2"] = CSharpExpressionConverter.ConvertToken(bodyemail2);
                bodypropCount++;
            }

            if (bodyemail3 != null)
            {
                body["email3"] = CSharpExpressionConverter.ConvertToken(bodyemail3);
                bodypropCount++;
            }

            if (bodyemail4 != null)
            {
                body["email4"] = CSharpExpressionConverter.ConvertToken(bodyemail4);
                bodypropCount++;
            }

            if (bodyphonetype1 != null)
            {
                body["phonetype1"] = CSharpExpressionConverter.ConvertToken(bodyphonetype1);
                bodypropCount++;
            }

            if (bodyphone1 != null)
            {
                body["phone1"] = CSharpExpressionConverter.ConvertToken(bodyphone1);
                bodypropCount++;
            }

            if (bodyphonetype2 != null)
            {
                body["phonetype2"] = CSharpExpressionConverter.ConvertToken(bodyphonetype2);
                bodypropCount++;
            }

            if (bodyphone2 != null)
            {
                body["phone2"] = CSharpExpressionConverter.ConvertToken(bodyphone2);
                bodypropCount++;
            }

            if (bodyphonetype3 != null)
            {
                body["phonetype3"] = CSharpExpressionConverter.ConvertToken(bodyphonetype3);
                bodypropCount++;
            }

            if (bodyphone3 != null)
            {
                body["phone3"] = CSharpExpressionConverter.ConvertToken(bodyphone3);
                bodypropCount++;
            }

            if (bodyphonetype4 != null)
            {
                body["phonetype4"] = CSharpExpressionConverter.ConvertToken(bodyphonetype4);
                bodypropCount++;
            }

            if (bodyphone4 != null)
            {
                body["phone4"] = CSharpExpressionConverter.ConvertToken(bodyphone4);
                bodypropCount++;
            }

            if (bodyremark != null)
            {
                body["remark"] = CSharpExpressionConverter.ConvertToken(bodyremark);
                bodypropCount++;
            }

            if (bodynotes != null)
            {
                body["notes"] = CSharpExpressionConverter.ConvertToken(bodynotes);
                bodypropCount++;
            }

            if (bodycampaign != null)
            {
                body["campaign"] = CSharpExpressionConverter.ConvertToken(bodycampaign);
                bodypropCount++;
            }

            if (bodycategory != null)
            {
                body["category"] = CSharpExpressionConverter.ConvertToken(bodycategory);
                bodypropCount++;
            }

            if (bodyrole != null)
            {
                body["role"] = CSharpExpressionConverter.ConvertToken(bodyrole);
                bodypropCount++;
            }

            if (bodymarket != null)
            {
                body["market"] = CSharpExpressionConverter.ConvertToken(bodymarket);
                bodypropCount++;
            }

            if (bodyterritory != null)
            {
                body["territory"] = CSharpExpressionConverter.ConvertToken(bodyterritory);
                bodypropCount++;
            }

            if (bodysalesrep != null)
            {
                body["salesrep"] = CSharpExpressionConverter.ConvertToken(bodysalesrep);
                bodypropCount++;
            }

            if (bodylastcontact != null)
            {
                body["lastcontact"] = CSharpExpressionConverter.ConvertToken(bodylastcontact);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<LeadGetValueResponse> LeadGetValue(Expression<Func<string>> id)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/Lead/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<LeadGetValueResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<JToken> LeadPutValue(Expression<Func<string>> id, Expression<Func<string>> bodysal = null, Expression<Func<string>> bodyfirstname = null, Expression<Func<string>> bodymiddlename = null, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodylastname = null, Expression<Func<string>> bodycompany = null, Expression<Func<string>> bodyaddr1 = null, Expression<Func<string>> bodyaddr2 = null, Expression<Func<string>> bodycity = null, Expression<Func<string>> bodystate = null, Expression<Func<string>> bodypostal = null, Expression<Func<string>> bodyemail1 = null, Expression<Func<string>> bodyemail2 = null, Expression<Func<string>> bodyemail3 = null, Expression<Func<string>> bodyemail4 = null, Expression<Func<string>> bodyphonetype1 = null, Expression<Func<string>> bodyphone1 = null, Expression<Func<string>> bodyphonetype2 = null, Expression<Func<string>> bodyphone2 = null, Expression<Func<string>> bodyphonetype3 = null, Expression<Func<string>> bodyphone3 = null, Expression<Func<string>> bodyphonetype4 = null, Expression<Func<string>> bodyphone4 = null, Expression<Func<string>> bodyremark = null, Expression<Func<string>> bodynotes = null, Expression<Func<string>> bodycampaign = null, Expression<Func<string>> bodycategory = null, Expression<Func<string>> bodyrole = null, Expression<Func<string>> bodymarket = null, Expression<Func<string>> bodyterritory = null, Expression<Func<string>> bodysalesrep = null, Expression<Func<string>> bodylastcontact = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/Lead/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodysal != null)
            {
                body["sal"] = CSharpExpressionConverter.ConvertToken(bodysal);
                bodypropCount++;
            }

            if (bodyfirstname != null)
            {
                body["firstname"] = CSharpExpressionConverter.ConvertToken(bodyfirstname);
                bodypropCount++;
            }

            if (bodymiddlename != null)
            {
                body["middlename"] = CSharpExpressionConverter.ConvertToken(bodymiddlename);
                bodypropCount++;
            }

            if (bodytitle != null)
            {
                body["title"] = CSharpExpressionConverter.ConvertToken(bodytitle);
                bodypropCount++;
            }

            if (bodylastname != null)
            {
                body["lastname"] = CSharpExpressionConverter.ConvertToken(bodylastname);
                bodypropCount++;
            }

            if (bodycompany != null)
            {
                body["company"] = CSharpExpressionConverter.ConvertToken(bodycompany);
                bodypropCount++;
            }

            if (bodyaddr1 != null)
            {
                body["addr1"] = CSharpExpressionConverter.ConvertToken(bodyaddr1);
                bodypropCount++;
            }

            if (bodyaddr2 != null)
            {
                body["addr2"] = CSharpExpressionConverter.ConvertToken(bodyaddr2);
                bodypropCount++;
            }

            if (bodycity != null)
            {
                body["city"] = CSharpExpressionConverter.ConvertToken(bodycity);
                bodypropCount++;
            }

            if (bodystate != null)
            {
                body["state"] = CSharpExpressionConverter.ConvertToken(bodystate);
                bodypropCount++;
            }

            if (bodypostal != null)
            {
                body["postal"] = CSharpExpressionConverter.ConvertToken(bodypostal);
                bodypropCount++;
            }

            if (bodyemail1 != null)
            {
                body["email1"] = CSharpExpressionConverter.ConvertToken(bodyemail1);
                bodypropCount++;
            }

            if (bodyemail2 != null)
            {
                body["email2"] = CSharpExpressionConverter.ConvertToken(bodyemail2);
                bodypropCount++;
            }

            if (bodyemail3 != null)
            {
                body["email3"] = CSharpExpressionConverter.ConvertToken(bodyemail3);
                bodypropCount++;
            }

            if (bodyemail4 != null)
            {
                body["email4"] = CSharpExpressionConverter.ConvertToken(bodyemail4);
                bodypropCount++;
            }

            if (bodyphonetype1 != null)
            {
                body["phonetype1"] = CSharpExpressionConverter.ConvertToken(bodyphonetype1);
                bodypropCount++;
            }

            if (bodyphone1 != null)
            {
                body["phone1"] = CSharpExpressionConverter.ConvertToken(bodyphone1);
                bodypropCount++;
            }

            if (bodyphonetype2 != null)
            {
                body["phonetype2"] = CSharpExpressionConverter.ConvertToken(bodyphonetype2);
                bodypropCount++;
            }

            if (bodyphone2 != null)
            {
                body["phone2"] = CSharpExpressionConverter.ConvertToken(bodyphone2);
                bodypropCount++;
            }

            if (bodyphonetype3 != null)
            {
                body["phonetype3"] = CSharpExpressionConverter.ConvertToken(bodyphonetype3);
                bodypropCount++;
            }

            if (bodyphone3 != null)
            {
                body["phone3"] = CSharpExpressionConverter.ConvertToken(bodyphone3);
                bodypropCount++;
            }

            if (bodyphonetype4 != null)
            {
                body["phonetype4"] = CSharpExpressionConverter.ConvertToken(bodyphonetype4);
                bodypropCount++;
            }

            if (bodyphone4 != null)
            {
                body["phone4"] = CSharpExpressionConverter.ConvertToken(bodyphone4);
                bodypropCount++;
            }

            if (bodyremark != null)
            {
                body["remark"] = CSharpExpressionConverter.ConvertToken(bodyremark);
                bodypropCount++;
            }

            if (bodynotes != null)
            {
                body["notes"] = CSharpExpressionConverter.ConvertToken(bodynotes);
                bodypropCount++;
            }

            if (bodycampaign != null)
            {
                body["campaign"] = CSharpExpressionConverter.ConvertToken(bodycampaign);
                bodypropCount++;
            }

            if (bodycategory != null)
            {
                body["category"] = CSharpExpressionConverter.ConvertToken(bodycategory);
                bodypropCount++;
            }

            if (bodyrole != null)
            {
                body["role"] = CSharpExpressionConverter.ConvertToken(bodyrole);
                bodypropCount++;
            }

            if (bodymarket != null)
            {
                body["market"] = CSharpExpressionConverter.ConvertToken(bodymarket);
                bodypropCount++;
            }

            if (bodyterritory != null)
            {
                body["territory"] = CSharpExpressionConverter.ConvertToken(bodyterritory);
                bodypropCount++;
            }

            if (bodysalesrep != null)
            {
                body["salesrep"] = CSharpExpressionConverter.ConvertToken(bodysalesrep);
                bodypropCount++;
            }

            if (bodylastcontact != null)
            {
                body["lastcontact"] = CSharpExpressionConverter.ConvertToken(bodylastcontact);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<string[]> MembersGetValues(Expression<Func<typeInput>> type)
        {
            var apiCallPath = "/api/Members";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["type"] = CSharpExpressionConverter.Convert(type);
            return new ApiConnectionAction<string[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<JToken> MembersPostValue(Expression<Func<string>> bodypromoid = null, Expression<Func<bodyrecordtypeInput>> bodyrecordtype = null, Expression<Func<string>> bodyrecordid = null)
        {
            var apiCallPath = "/api/Members";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodypromoid != null)
            {
                body["promoid"] = CSharpExpressionConverter.ConvertToken(bodypromoid);
                bodypropCount++;
            }

            if (bodyrecordtype != null)
            {
                body["recordtype"] = CSharpExpressionConverter.Convert(bodyrecordtype);
                bodypropCount++;
            }

            if (bodyrecordid != null)
            {
                body["recordid"] = CSharpExpressionConverter.ConvertToken(bodyrecordid);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<MembersGetValueResponse> MembersGetValue(Expression<Func<string>> id)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/Members/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<MembersGetValueResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<JToken> MembersPutValue(Expression<Func<string>> id, Expression<Func<bodyoperationInput>> bodyoperation = null, Expression<Func<bodyrecordtypeInput>> bodyrecordtype = null, Expression<Func<string>> bodypromoid = null, Expression<Func<string>> bodyrecordid = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/Members/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyoperation != null)
            {
                body["operation"] = CSharpExpressionConverter.Convert(bodyoperation);
                bodypropCount++;
            }

            if (bodyrecordtype != null)
            {
                body["recordtype"] = CSharpExpressionConverter.Convert(bodyrecordtype);
                bodypropCount++;
            }

            if (bodypromoid != null)
            {
                body["promoid"] = CSharpExpressionConverter.ConvertToken(bodypromoid);
                bodypropCount++;
            }

            if (bodyrecordid != null)
            {
                body["recordid"] = CSharpExpressionConverter.ConvertToken(bodyrecordid);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<string[]> ShippingGetValues()
        {
            var apiCallPath = "/api/Shipping";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<JToken> ShippingPostValue(Expression<Func<string>> bodyorderid = null, Expression<Func<string>> bodyshipdate = null, Expression<Func<string>> bodycarrier = null, Expression<Func<string>> bodymethod = null, Expression<Func<double>> bodyweight = null, Expression<Func<string>> bodypackagetype = null, Expression<Func<string>> bodyreference1 = null, Expression<Func<string>> bodyreference2 = null, Expression<Func<string>> bodytrackingnumber = null, Expression<Func<string>> bodytrackingurl = null, Expression<Func<double>> bodyshippingcost = null, Expression<Func<bool>> bodytohistory = null)
        {
            var apiCallPath = "/api/Shipping";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyorderid != null)
            {
                body["orderid"] = CSharpExpressionConverter.ConvertToken(bodyorderid);
                bodypropCount++;
            }

            if (bodyshipdate != null)
            {
                body["shipdate"] = CSharpExpressionConverter.ConvertToken(bodyshipdate);
                bodypropCount++;
            }

            if (bodycarrier != null)
            {
                body["carrier"] = CSharpExpressionConverter.ConvertToken(bodycarrier);
                bodypropCount++;
            }

            if (bodymethod != null)
            {
                body["method"] = CSharpExpressionConverter.ConvertToken(bodymethod);
                bodypropCount++;
            }

            if (bodyweight != null)
            {
                body["weight"] = CSharpExpressionConverter.ConvertToken(bodyweight);
                bodypropCount++;
            }

            if (bodypackagetype != null)
            {
                body["packagetype"] = CSharpExpressionConverter.ConvertToken(bodypackagetype);
                bodypropCount++;
            }

            if (bodyreference1 != null)
            {
                body["reference1"] = CSharpExpressionConverter.ConvertToken(bodyreference1);
                bodypropCount++;
            }

            if (bodyreference2 != null)
            {
                body["reference2"] = CSharpExpressionConverter.ConvertToken(bodyreference2);
                bodypropCount++;
            }

            if (bodytrackingnumber != null)
            {
                body["trackingnumber"] = CSharpExpressionConverter.ConvertToken(bodytrackingnumber);
                bodypropCount++;
            }

            if (bodytrackingurl != null)
            {
                body["trackingurl"] = CSharpExpressionConverter.ConvertToken(bodytrackingurl);
                bodypropCount++;
            }

            if (bodyshippingcost != null)
            {
                body["shippingcost"] = CSharpExpressionConverter.ConvertToken(bodyshippingcost);
                bodypropCount++;
            }

            if (bodytohistory != null)
            {
                body["tohistory"] = CSharpExpressionConverter.ConvertToken(bodytohistory);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<ShippingGetValueResponse> ShippingGetValue(Expression<Func<string>> id)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/Shipping/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ShippingGetValueResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IWorkflowAction ShippingPutValue(Expression<Func<string>> id, Expression<Func<string>> bodyshipdate = null, Expression<Func<string>> bodycarrier = null, Expression<Func<string>> bodymethod = null, Expression<Func<double>> bodyweight = null, Expression<Func<string>> bodypackagetype = null, Expression<Func<string>> bodyreference1 = null, Expression<Func<string>> bodyreference2 = null, Expression<Func<string>> bodytrackingnumber = null, Expression<Func<string>> bodytrackingurl = null, Expression<Func<double>> bodyshippingcost = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/Shipping/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyshipdate != null)
            {
                body["shipdate"] = CSharpExpressionConverter.ConvertToken(bodyshipdate);
                bodypropCount++;
            }

            if (bodycarrier != null)
            {
                body["carrier"] = CSharpExpressionConverter.ConvertToken(bodycarrier);
                bodypropCount++;
            }

            if (bodymethod != null)
            {
                body["method"] = CSharpExpressionConverter.ConvertToken(bodymethod);
                bodypropCount++;
            }

            if (bodyweight != null)
            {
                body["weight"] = CSharpExpressionConverter.ConvertToken(bodyweight);
                bodypropCount++;
            }

            if (bodypackagetype != null)
            {
                body["packagetype"] = CSharpExpressionConverter.ConvertToken(bodypackagetype);
                bodypropCount++;
            }

            if (bodyreference1 != null)
            {
                body["reference1"] = CSharpExpressionConverter.ConvertToken(bodyreference1);
                bodypropCount++;
            }

            if (bodyreference2 != null)
            {
                body["reference2"] = CSharpExpressionConverter.ConvertToken(bodyreference2);
                bodypropCount++;
            }

            if (bodytrackingnumber != null)
            {
                body["trackingnumber"] = CSharpExpressionConverter.ConvertToken(bodytrackingnumber);
                bodypropCount++;
            }

            if (bodytrackingurl != null)
            {
                body["trackingurl"] = CSharpExpressionConverter.ConvertToken(bodytrackingurl);
                bodypropCount++;
            }

            if (bodyshippingcost != null)
            {
                body["shippingcost"] = CSharpExpressionConverter.ConvertToken(bodyshippingcost);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<string[]> SOGetValues()
        {
            var apiCallPath = "/api/SO";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<JToken> SOPostValue(Expression<Func<string>> bodyorderid = null, Expression<Func<string>> bodyorderdate = null, Expression<Func<string>> bodyorderdescription = null, Expression<Func<string>> bodyaccount = null, Expression<Func<string>> bodyaccountname = null, Expression<Func<string>> bodysalesrep = null, Expression<Func<string>> bodyfirstname = null, Expression<Func<string>> bodylastname = null, Expression<Func<string>> bodybillemail = null, Expression<Func<string>> bodybilladdr1 = null, Expression<Func<string>> bodybilladdr2 = null, Expression<Func<string>> bodybillcity = null, Expression<Func<string>> bodybillstate = null, Expression<Func<string>> bodybillzipcode = null, Expression<Func<string>> bodybillcountry = null, Expression<Func<string>> bodybillphone = null, Expression<Func<string>> bodybillfax = null, Expression<Func<string>> bodyshipcompany = null, Expression<Func<string>> bodyshipcontact = null, Expression<Func<string>> bodyshipaddr1 = null, Expression<Func<string>> bodyshipaddr2 = null, Expression<Func<string>> bodyshipcity = null, Expression<Func<string>> bodyshipstate = null, Expression<Func<string>> bodyshipzipcode = null, Expression<Func<string>> bodyshipcountry = null, Expression<Func<string>> bodyshipphone = null, Expression<Func<string>> bodyshipemail = null, Expression<Func<bodyorderstatusInput>> bodyorderstatus = null, Expression<Func<string>> bodycustomstatus = null, Expression<Func<string>> bodytaxdistrict = null, Expression<Func<double>> bodytaxrate = null, Expression<Func<string>> bodycampaign = null, Expression<Func<string>> bodyordertax = null, Expression<Func<string>> bodyshippingcost = null, Expression<Func<string>> bodyshippingmethod = null, Expression<Func<double>> bodycouponamount = null, Expression<Func<string>> bodycouponcode = null, Expression<Func<string>> bodypaymentmethod = null, Expression<Func<string>> bodycomments = null, Expression<Func<bodylinedataInputItem[]>> bodylinedata = null)
        {
            var apiCallPath = "/api/SO";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyorderid != null)
            {
                body["orderid"] = CSharpExpressionConverter.ConvertToken(bodyorderid);
                bodypropCount++;
            }

            if (bodyorderdate != null)
            {
                body["orderdate"] = CSharpExpressionConverter.ConvertToken(bodyorderdate);
                bodypropCount++;
            }

            if (bodyorderdescription != null)
            {
                body["orderdescription"] = CSharpExpressionConverter.ConvertToken(bodyorderdescription);
                bodypropCount++;
            }

            if (bodyaccount != null)
            {
                body["account"] = CSharpExpressionConverter.ConvertToken(bodyaccount);
                bodypropCount++;
            }

            if (bodyaccountname != null)
            {
                body["accountname"] = CSharpExpressionConverter.ConvertToken(bodyaccountname);
                bodypropCount++;
            }

            if (bodysalesrep != null)
            {
                body["salesrep"] = CSharpExpressionConverter.ConvertToken(bodysalesrep);
                bodypropCount++;
            }

            if (bodyfirstname != null)
            {
                body["firstname"] = CSharpExpressionConverter.ConvertToken(bodyfirstname);
                bodypropCount++;
            }

            if (bodylastname != null)
            {
                body["lastname"] = CSharpExpressionConverter.ConvertToken(bodylastname);
                bodypropCount++;
            }

            if (bodybillemail != null)
            {
                body["billemail"] = CSharpExpressionConverter.ConvertToken(bodybillemail);
                bodypropCount++;
            }

            if (bodybilladdr1 != null)
            {
                body["billaddr1"] = CSharpExpressionConverter.ConvertToken(bodybilladdr1);
                bodypropCount++;
            }

            if (bodybilladdr2 != null)
            {
                body["billaddr2"] = CSharpExpressionConverter.ConvertToken(bodybilladdr2);
                bodypropCount++;
            }

            if (bodybillcity != null)
            {
                body["billcity"] = CSharpExpressionConverter.ConvertToken(bodybillcity);
                bodypropCount++;
            }

            if (bodybillstate != null)
            {
                body["billstate"] = CSharpExpressionConverter.ConvertToken(bodybillstate);
                bodypropCount++;
            }

            if (bodybillzipcode != null)
            {
                body["billzipcode"] = CSharpExpressionConverter.ConvertToken(bodybillzipcode);
                bodypropCount++;
            }

            if (bodybillcountry != null)
            {
                body["billcountry"] = CSharpExpressionConverter.ConvertToken(bodybillcountry);
                bodypropCount++;
            }

            if (bodybillphone != null)
            {
                body["billphone"] = CSharpExpressionConverter.ConvertToken(bodybillphone);
                bodypropCount++;
            }

            if (bodybillfax != null)
            {
                body["billfax"] = CSharpExpressionConverter.ConvertToken(bodybillfax);
                bodypropCount++;
            }

            if (bodyshipcompany != null)
            {
                body["shipcompany"] = CSharpExpressionConverter.ConvertToken(bodyshipcompany);
                bodypropCount++;
            }

            if (bodyshipcontact != null)
            {
                body["shipcontact"] = CSharpExpressionConverter.ConvertToken(bodyshipcontact);
                bodypropCount++;
            }

            if (bodyshipaddr1 != null)
            {
                body["shipaddr1"] = CSharpExpressionConverter.ConvertToken(bodyshipaddr1);
                bodypropCount++;
            }

            if (bodyshipaddr2 != null)
            {
                body["shipaddr2"] = CSharpExpressionConverter.ConvertToken(bodyshipaddr2);
                bodypropCount++;
            }

            if (bodyshipcity != null)
            {
                body["shipcity"] = CSharpExpressionConverter.ConvertToken(bodyshipcity);
                bodypropCount++;
            }

            if (bodyshipstate != null)
            {
                body["shipstate"] = CSharpExpressionConverter.ConvertToken(bodyshipstate);
                bodypropCount++;
            }

            if (bodyshipzipcode != null)
            {
                body["shipzipcode"] = CSharpExpressionConverter.ConvertToken(bodyshipzipcode);
                bodypropCount++;
            }

            if (bodyshipcountry != null)
            {
                body["shipcountry"] = CSharpExpressionConverter.ConvertToken(bodyshipcountry);
                bodypropCount++;
            }

            if (bodyshipphone != null)
            {
                body["shipphone"] = CSharpExpressionConverter.ConvertToken(bodyshipphone);
                bodypropCount++;
            }

            if (bodyshipemail != null)
            {
                body["shipemail"] = CSharpExpressionConverter.ConvertToken(bodyshipemail);
                bodypropCount++;
            }

            if (bodyorderstatus != null)
            {
                body["orderstatus"] = CSharpExpressionConverter.Convert(bodyorderstatus);
                bodypropCount++;
            }

            if (bodycustomstatus != null)
            {
                body["customstatus"] = CSharpExpressionConverter.ConvertToken(bodycustomstatus);
                bodypropCount++;
            }

            if (bodytaxdistrict != null)
            {
                body["taxdistrict"] = CSharpExpressionConverter.ConvertToken(bodytaxdistrict);
                bodypropCount++;
            }

            if (bodytaxrate != null)
            {
                body["taxrate"] = CSharpExpressionConverter.ConvertToken(bodytaxrate);
                bodypropCount++;
            }

            if (bodycampaign != null)
            {
                body["campaign"] = CSharpExpressionConverter.ConvertToken(bodycampaign);
                bodypropCount++;
            }

            if (bodyordertax != null)
            {
                body["ordertax"] = CSharpExpressionConverter.ConvertToken(bodyordertax);
                bodypropCount++;
            }

            if (bodyshippingcost != null)
            {
                body["shippingcost"] = CSharpExpressionConverter.ConvertToken(bodyshippingcost);
                bodypropCount++;
            }

            if (bodyshippingmethod != null)
            {
                body["shippingmethod"] = CSharpExpressionConverter.ConvertToken(bodyshippingmethod);
                bodypropCount++;
            }

            if (bodycouponamount != null)
            {
                body["couponamount"] = CSharpExpressionConverter.ConvertToken(bodycouponamount);
                bodypropCount++;
            }

            if (bodycouponcode != null)
            {
                body["couponcode"] = CSharpExpressionConverter.ConvertToken(bodycouponcode);
                bodypropCount++;
            }

            if (bodypaymentmethod != null)
            {
                body["paymentmethod"] = CSharpExpressionConverter.ConvertToken(bodypaymentmethod);
                bodypropCount++;
            }

            if (bodycomments != null)
            {
                body["comments"] = CSharpExpressionConverter.ConvertToken(bodycomments);
                bodypropCount++;
            }

            if (bodylinedata != null)
            {
                body["linedata"] = CSharpExpressionConverter.ConvertToken(bodylinedata);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<SOGetValueResponse> SOGetValue(Expression<Func<string>> id)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/SO/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<SOGetValueResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IWorkflowAction SOPutValue(Expression<Func<string>> id, Expression<Func<string>> bodycomments = null, Expression<Func<string>> bodycustomstatus = null, Expression<Func<bodyorderstatusInput>> bodyorderstatus = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/SO/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodycomments != null)
            {
                body["comments"] = CSharpExpressionConverter.ConvertToken(bodycomments);
                bodypropCount++;
            }

            if (bodycustomstatus != null)
            {
                body["customstatus"] = CSharpExpressionConverter.ConvertToken(bodycustomstatus);
                bodypropCount++;
            }

            if (bodyorderstatus != null)
            {
                body["orderstatus"] = CSharpExpressionConverter.Convert(bodyorderstatus);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<string[]> WorkOrderGetValues()
        {
            var apiCallPath = "/api/WorkOrder";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<JToken> WorkOrderPostValue(Expression<Func<string>> bodyfromaddress = null, Expression<Func<string>> bodyfirstname = null, Expression<Func<string>> bodylastname = null, Expression<Func<string>> bodycompanyname = null, Expression<Func<string>> bodybilladdr1 = null, Expression<Func<string>> bodybilladdr2 = null, Expression<Func<string>> bodybillcity = null, Expression<Func<string>> bodybillstate = null, Expression<Func<string>> bodybillzipcode = null, Expression<Func<string>> bodybillcountry = null, Expression<Func<string>> bodybillphone = null, Expression<Func<string>> bodybillfax = null, Expression<Func<string>> bodyserviceaddr1 = null, Expression<Func<string>> bodyserviceaddr2 = null, Expression<Func<string>> bodyservicecity = null, Expression<Func<string>> bodyservicestate = null, Expression<Func<string>> bodyservicezipcode = null, Expression<Func<string>> bodyservicecountry = null, Expression<Func<string>> bodyservicephone = null, Expression<Func<string>> bodyreceiveddate = null, Expression<Func<string>> bodyponumber = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodyreasoncode = null, Expression<Func<string>> bodysource = null, Expression<Func<string>> bodyassignedto = null, Expression<Func<string>> bodybackup = null, Expression<Func<bodypriorityInput>> bodypriority = null, Expression<Func<string>> bodyduedate = null, Expression<Func<string>> bodysubject = null, Expression<Func<string>> bodybody = null)
        {
            var apiCallPath = "/api/WorkOrder";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyfromaddress != null)
            {
                body["fromaddress"] = CSharpExpressionConverter.ConvertToken(bodyfromaddress);
                bodypropCount++;
            }

            if (bodyfirstname != null)
            {
                body["firstname"] = CSharpExpressionConverter.ConvertToken(bodyfirstname);
                bodypropCount++;
            }

            if (bodylastname != null)
            {
                body["lastname"] = CSharpExpressionConverter.ConvertToken(bodylastname);
                bodypropCount++;
            }

            if (bodycompanyname != null)
            {
                body["companyname"] = CSharpExpressionConverter.ConvertToken(bodycompanyname);
                bodypropCount++;
            }

            if (bodybilladdr1 != null)
            {
                body["billaddr1"] = CSharpExpressionConverter.ConvertToken(bodybilladdr1);
                bodypropCount++;
            }

            if (bodybilladdr2 != null)
            {
                body["billaddr2"] = CSharpExpressionConverter.ConvertToken(bodybilladdr2);
                bodypropCount++;
            }

            if (bodybillcity != null)
            {
                body["billcity"] = CSharpExpressionConverter.ConvertToken(bodybillcity);
                bodypropCount++;
            }

            if (bodybillstate != null)
            {
                body["billstate"] = CSharpExpressionConverter.ConvertToken(bodybillstate);
                bodypropCount++;
            }

            if (bodybillzipcode != null)
            {
                body["billzipcode"] = CSharpExpressionConverter.ConvertToken(bodybillzipcode);
                bodypropCount++;
            }

            if (bodybillcountry != null)
            {
                body["billcountry"] = CSharpExpressionConverter.ConvertToken(bodybillcountry);
                bodypropCount++;
            }

            if (bodybillphone != null)
            {
                body["billphone"] = CSharpExpressionConverter.ConvertToken(bodybillphone);
                bodypropCount++;
            }

            if (bodybillfax != null)
            {
                body["billfax"] = CSharpExpressionConverter.ConvertToken(bodybillfax);
                bodypropCount++;
            }

            if (bodyserviceaddr1 != null)
            {
                body["serviceaddr1"] = CSharpExpressionConverter.ConvertToken(bodyserviceaddr1);
                bodypropCount++;
            }

            if (bodyserviceaddr2 != null)
            {
                body["serviceaddr2"] = CSharpExpressionConverter.ConvertToken(bodyserviceaddr2);
                bodypropCount++;
            }

            if (bodyservicecity != null)
            {
                body["servicecity"] = CSharpExpressionConverter.ConvertToken(bodyservicecity);
                bodypropCount++;
            }

            if (bodyservicestate != null)
            {
                body["servicestate"] = CSharpExpressionConverter.ConvertToken(bodyservicestate);
                bodypropCount++;
            }

            if (bodyservicezipcode != null)
            {
                body["servicezipcode"] = CSharpExpressionConverter.ConvertToken(bodyservicezipcode);
                bodypropCount++;
            }

            if (bodyservicecountry != null)
            {
                body["servicecountry"] = CSharpExpressionConverter.ConvertToken(bodyservicecountry);
                bodypropCount++;
            }

            if (bodyservicephone != null)
            {
                body["servicephone"] = CSharpExpressionConverter.ConvertToken(bodyservicephone);
                bodypropCount++;
            }

            if (bodyreceiveddate != null)
            {
                body["receiveddate"] = CSharpExpressionConverter.ConvertToken(bodyreceiveddate);
                bodypropCount++;
            }

            if (bodyponumber != null)
            {
                body["ponumber"] = CSharpExpressionConverter.ConvertToken(bodyponumber);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["status"] = CSharpExpressionConverter.ConvertToken(bodystatus);
                bodypropCount++;
            }

            if (bodyreasoncode != null)
            {
                body["reasoncode"] = CSharpExpressionConverter.ConvertToken(bodyreasoncode);
                bodypropCount++;
            }

            if (bodysource != null)
            {
                body["source"] = CSharpExpressionConverter.ConvertToken(bodysource);
                bodypropCount++;
            }

            if (bodyassignedto != null)
            {
                body["assignedto"] = CSharpExpressionConverter.ConvertToken(bodyassignedto);
                bodypropCount++;
            }

            if (bodybackup != null)
            {
                body["backup"] = CSharpExpressionConverter.ConvertToken(bodybackup);
                bodypropCount++;
            }

            if (bodypriority != null)
            {
                body["priority"] = CSharpExpressionConverter.Convert(bodypriority);
                bodypropCount++;
            }

            if (bodyduedate != null)
            {
                body["duedate"] = CSharpExpressionConverter.ConvertToken(bodyduedate);
                bodypropCount++;
            }

            if (bodysubject != null)
            {
                body["subject"] = CSharpExpressionConverter.ConvertToken(bodysubject);
                bodypropCount++;
            }

            if (bodybody != null)
            {
                body["body"] = CSharpExpressionConverter.ConvertToken(bodybody);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<WorkOrderGetValueResponse> WorkOrderGetValue(Expression<Func<string>> id)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/WorkOrder/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<WorkOrderGetValueResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IWorkflowAction WorkOrderPutValue(Expression<Func<string>> id, Expression<Func<string>> bodyponumber = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodyreasoncode = null, Expression<Func<string>> bodysource = null, Expression<Func<string>> bodyassignedto = null, Expression<Func<string>> bodybackup = null, Expression<Func<bodypriorityInput>> bodypriority = null, Expression<Func<string>> bodyduedate = null, Expression<Func<string>> bodysubject = null, Expression<Func<string>> bodybody = null, Expression<Func<bool>> bodyhistory = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/WorkOrder/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyponumber != null)
            {
                body["ponumber"] = CSharpExpressionConverter.ConvertToken(bodyponumber);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["status"] = CSharpExpressionConverter.ConvertToken(bodystatus);
                bodypropCount++;
            }

            if (bodyreasoncode != null)
            {
                body["reasoncode"] = CSharpExpressionConverter.ConvertToken(bodyreasoncode);
                bodypropCount++;
            }

            if (bodysource != null)
            {
                body["source"] = CSharpExpressionConverter.ConvertToken(bodysource);
                bodypropCount++;
            }

            if (bodyassignedto != null)
            {
                body["assignedto"] = CSharpExpressionConverter.ConvertToken(bodyassignedto);
                bodypropCount++;
            }

            if (bodybackup != null)
            {
                body["backup"] = CSharpExpressionConverter.ConvertToken(bodybackup);
                bodypropCount++;
            }

            if (bodypriority != null)
            {
                body["priority"] = CSharpExpressionConverter.Convert(bodypriority);
                bodypropCount++;
            }

            if (bodyduedate != null)
            {
                body["duedate"] = CSharpExpressionConverter.ConvertToken(bodyduedate);
                bodypropCount++;
            }

            if (bodysubject != null)
            {
                body["subject"] = CSharpExpressionConverter.ConvertToken(bodysubject);
                bodypropCount++;
            }

            if (bodybody != null)
            {
                body["body"] = CSharpExpressionConverter.ConvertToken(bodybody);
                bodypropCount++;
            }

            if (bodyhistory != null)
            {
                body["history"] = CSharpExpressionConverter.ConvertToken(bodyhistory);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }
    }

    public class ImprezianTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<NewSalesLeadResponseItem[]> NewSalesLead(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/api/new_lead";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<NewSalesLeadResponseItem[]>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<NewMarketingCampaignResponseItem[]> NewMarketingCampaign(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/api/new_campaign";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<NewMarketingCampaignResponseItem[]>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<NewMembersLeadsResponseItem[]> NewMembersLeads(Expression<Func<int>> promotionID, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/api/new_members_leads";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["PromotionID"] = CSharpExpressionConverter.ConvertO(promotionID);
            return new ApiConnectionTrigger<NewMembersLeadsResponseItem[]>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<NewSalesOrderResponseItem[]> NewSalesOrder(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/api/new_orders";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<NewSalesOrderResponseItem[]>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<NewProposalCreatedResponseItem[]> NewProposalCreated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/api/new_quotes";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<NewProposalCreatedResponseItem[]>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<OrderStatusChangedResponseItem[]> OrderStatusChanged(Expression<Func<string>> status, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/api/order_status";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Status"] = CSharpExpressionConverter.ConvertO(status);
            return new ApiConnectionTrigger<OrderStatusChangedResponseItem[]>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<OrderInHistoryResponseItem[]> OrderInHistory(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/api/orders_final";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<OrderInHistoryResponseItem[]>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<OrderInProcessingResponseItem[]> OrderInProcessing(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/api/orders_processing";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<OrderInProcessingResponseItem[]>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<OrderIsShippingResponseItem[]> OrderIsShipping(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/api/orders_shipping";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<OrderIsShippingResponseItem[]>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ProposalNeedsApprovalResponseItem[]> ProposalNeedsApproval(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/api/quotes_approval";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<ProposalNeedsApprovalResponseItem[]>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<WorkOrderClosedResponseItem[]> WorkOrderClosed(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/api/wo_closed";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<WorkOrderClosedResponseItem[]>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<WorkOrderCreatedResponseItem[]> WorkOrderCreated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/api/wo_opened";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<WorkOrderCreatedResponseItem[]>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<WorkOrderPastDueResponseItem[]> WorkOrderPastDue(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/api/wo_pastdue";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<WorkOrderPastDueResponseItem[]>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<WorkOrderStatusChangedResponseItem[]> WorkOrderStatusChanged(Expression<Func<string>> status, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/api/wo_status";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Status"] = CSharpExpressionConverter.ConvertO(status);
            return new ApiConnectionTrigger<WorkOrderStatusChangedResponseItem[]>(callPayload, triggerName, recurrence);
        }
    }

    public class CampaignGetValueResponse
    {
        public string PromoID { get; set; }

        [JsonProperty("Campaign Manager")]
        public string CampaignManager { get; set; }

        [JsonProperty("IS INACTIVE")]
        public string ISINACTIVE { get; set; }

        [JsonProperty("IN HISTORY")]
        public string INHISTORY { get; set; }

        [JsonProperty("Used For Discounting")]
        public string UsedForDiscounting { get; set; }

        [JsonProperty("Used For Mail Broadcasting")]
        public string UsedForMailBroadcasting { get; set; }

        [JsonProperty("budget")]
        public string Budget { get; set; }

        [JsonProperty("Promotion Type")]
        public string PromotionType { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("Employee Name")]
        public string EmployeeName { get; set; }

        [JsonProperty("Start Date")]
        public string StartDate { get; set; }

        [JsonProperty("Expiration Date")]
        public string ExpirationDate { get; set; }
        public string Revenue { get; set; }
    }

    public enum bodytypeInput
    {
        [EnumMember(Value = "E-mail")]
        EMail,
        [EnumMember(Value = "Phone-Call")]
        PhoneCall,
        Fax,
        Tweet,
        Facebook,
        Other
    }

    public class ComLogGetValueResponse
    {
        public string Direction { get; set; }

        [JsonProperty("account")]
        public string Account { get; set; }

        [JsonProperty("Account Name")]
        public string AccountName { get; set; }

        [JsonProperty("Contact Name")]
        public string ContactName { get; set; }

        [JsonProperty("Start Date")]
        public string StartDate { get; set; }

        [JsonProperty("End Date")]
        public string EndDate { get; set; }

        [JsonProperty("Employee Name")]
        public string EmployeeName { get; set; }
        public string Type { get; set; }
        public string Length { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public string Billed { get; set; }

        [JsonProperty("Work Order")]
        public string WorkOrder { get; set; }

        [JsonProperty("Sales Order")]
        public string SalesOrder { get; set; }

        [JsonProperty("Sales Lead")]
        public string SalesLead { get; set; }

        [JsonProperty("Project ID")]
        public string ProjectID { get; set; }
        public string Recipient { get; set; }

        [JsonProperty("cc")]
        public string Cc { get; set; }
        public string Bcc { get; set; }
        public string CallNumber { get; set; }
        public string RecordID { get; set; }

        [JsonProperty("Company Name")]
        public string CompanyName { get; set; }
    }

    public class FollowUpGetValueResponse
    {
        [JsonProperty("account")]
        public string Account { get; set; }
        public string RecallID { get; set; }

        [JsonProperty("Employee Name")]
        public string EmployeeName { get; set; }

        [JsonProperty("SET FOR")]
        public string SETFOR { get; set; }

        [JsonProperty("SET BY")]
        public string SETBY { get; set; }

        [JsonProperty("SET ON")]
        public string SETON { get; set; }

        [JsonProperty("IS CLEARED")]
        public string ISCLEARED { get; set; }

        [JsonProperty("Cleared By")]
        public string ClearedBy { get; set; }

        [JsonProperty("Cleared On")]
        public string ClearedOn { get; set; }

        [JsonProperty("ACCOUNT TYPE")]
        public string ACCOUNTTYPE { get; set; }
        public string Priority { get; set; }
        public string TYPE { get; set; }
        public string Details { get; set; }

        [JsonProperty("Account Name")]
        public string AccountName { get; set; }

        [JsonProperty("First Name")]
        public string FirstName { get; set; }

        [JsonProperty("Last Name")]
        public string LastName { get; set; }

        [JsonProperty("Company Name")]
        public string CompanyName { get; set; }

        [JsonProperty("FollowUp Date")]
        public string FollowUpDate { get; set; }

        [JsonProperty("Reminder Time")]
        public string ReminderTime { get; set; }

        [JsonProperty("WORK ORDER")]
        public string WORKORDER { get; set; }

        [JsonProperty("Sales Lead")]
        public string SalesLead { get; set; }

        [JsonProperty("Project ID")]
        public string ProjectID { get; set; }
    }

    public class ItemListPostValueResponse
    {
        [JsonProperty("id")]
        public string NewCodeID { get; set; }
    }

    public enum bodyitemtypeInput
    {
        I,
        N,
        M,
        D,
        S
    }

    public class ItemListGetValueResponse
    {
        public string Code { get; set; }

        [JsonProperty("Model Number")]
        public string ModelNumber { get; set; }
        public string Description { get; set; }

        [JsonProperty("Sales Description")]
        public string SalesDescription { get; set; }

        [JsonProperty("Purchase Description")]
        public string PurchaseDescription { get; set; }

        [JsonProperty("Item Type")]
        public string ItemType { get; set; }

        [JsonProperty("Base Price")]
        public string BasePrice { get; set; }

        [JsonProperty("Avg Cost")]
        public string AvgCost { get; set; }

        [JsonProperty("Primary Category")]
        public string PrimaryCategory { get; set; }
        public string Category2 { get; set; }
        public string Category3 { get; set; }
        public string Category4 { get; set; }
        public string Category5 { get; set; }

        [JsonProperty("Base UOM")]
        public string BaseUOM { get; set; }

        [JsonProperty("Sell UOM")]
        public string SellUOM { get; set; }

        [JsonProperty("Buy UOM")]
        public string BuyUOM { get; set; }

        [JsonProperty("Base Warehouse")]
        public string BaseWarehouse { get; set; }

        [JsonProperty("On Hand")]
        public string OnHand { get; set; }

        [JsonProperty("On SO")]
        public string OnSO { get; set; }
        public string Bad { get; set; }

        [JsonProperty("On WO")]
        public string OnWO { get; set; }

        [JsonProperty("On PO")]
        public string OnPO { get; set; }
        public string Available { get; set; }
        public string Taxable { get; set; }

        [JsonProperty("Tax 2")]
        public string Tax2 { get; set; }

        [JsonProperty("Pays Commission")]
        public string PaysCommission { get; set; }

        [JsonProperty("Fixed Price")]
        public string FixedPrice { get; set; }

        [JsonProperty("Discounting Prohibited")]
        public string DiscountingProhibited { get; set; }

        [JsonProperty("Call For Price")]
        public string CallForPrice { get; set; }

        [JsonProperty("Call For Cost")]
        public string CallForCost { get; set; }

        [JsonProperty("Gratis Item")]
        public string GratisItem { get; set; }

        [JsonProperty("Hidden on Printouts")]
        public string HiddenOnPrintouts { get; set; }

        [JsonProperty("Exclude From Margin")]
        public string ExcludeFromMargin { get; set; }

        [JsonProperty("Track Serial Numbers")]
        public string TrackSerialNumbers { get; set; }

        [JsonProperty("Serialization Mode")]
        public string SerializationMode { get; set; }

        [JsonProperty("Serial Number Required")]
        public string SerialNumberRequired { get; set; }

        [JsonProperty("Prohibit Duplicate Serial Numbers")]
        public string ProhibitDuplicateSerialNumbers { get; set; }

        [JsonProperty("Expiration Date Applies")]
        public string ExpirationDateApplies { get; set; }

        [JsonProperty("Shipping Charges Apply")]
        public string ShippingChargesApply { get; set; }

        [JsonProperty("Item must ship seperately")]
        public string ItemMustShipSeperately { get; set; }

        [JsonProperty("Group Ship Items")]
        public string GroupShipItems { get; set; }

        [JsonProperty("Drop-Ship From Vendor")]
        public string DropShipFromVendor { get; set; }
        public string Height { get; set; }
        public string Width { get; set; }
        public string Depth { get; set; }
        public string Weight { get; set; }

        [JsonProperty("Box Limit")]
        public string BoxLimit { get; set; }

        [JsonProperty("Lead Time")]
        public string LeadTime { get; set; }

        [JsonProperty("Last Cost")]
        public string LastCost { get; set; }

        [JsonProperty("Reorder Point")]
        public string ReorderPoint { get; set; }

        [JsonProperty("Item Message")]
        public string ItemMessage { get; set; }

        [JsonProperty("ON SALE")]
        public string ONSALE { get; set; }

        [JsonProperty("IS ASSEMBLY")]
        public string ISASSEMBLY { get; set; }

        [JsonProperty("Manufacturer Part Number")]
        public string ManufacturerPartNumber { get; set; }
        public string OEM { get; set; }

        [JsonProperty("BIN Location")]
        public string BINLocation { get; set; }

        [JsonProperty("Primary Vendor")]
        public string PrimaryVendor { get; set; }

        [JsonProperty("Vendor 1 Part #")]
        public string Vendor1Part { get; set; }

        [JsonProperty("Vendor 1 Descrip")]
        public string Vendor1Descrip { get; set; }

        [JsonProperty("Vendor 1 Cost")]
        public string Vendor1Cost { get; set; }

        [JsonProperty("Vendor 1 Date Cost Verified")]
        public string Vendor1DateCostVerified { get; set; }

        [JsonProperty("Vendor 2")]
        public string Vendor2 { get; set; }

        [JsonProperty("Vendor 2 Part #")]
        public string Vendor2Part { get; set; }

        [JsonProperty("Vendor 2 Descrip")]
        public string Vendor2Descrip { get; set; }

        [JsonProperty("Vendor 2 Cost")]
        public string Vendor2Cost { get; set; }

        [JsonProperty("Vendor 2 Date Cost Verified")]
        public string Vendor2DateCostVerified { get; set; }

        [JsonProperty("Vendor 3")]
        public string Vendor3 { get; set; }

        [JsonProperty("Vendor 3 Part #")]
        public string Vendor3Part { get; set; }

        [JsonProperty("Vendor 3 Descrip")]
        public string Vendor3Descrip { get; set; }

        [JsonProperty("Vendor 3 Cost")]
        public string Vendor3Cost { get; set; }

        [JsonProperty("Vendor 3 Date Cost Verified")]
        public string Vendor3DateCostVerified { get; set; }

        [JsonProperty("Vendor 4")]
        public string Vendor4 { get; set; }

        [JsonProperty("Vendor 4 Part #")]
        public string Vendor4Part { get; set; }

        [JsonProperty("Vendor 4 Descrip")]
        public string Vendor4Descrip { get; set; }

        [JsonProperty("Vendor 4 Cost")]
        public string Vendor4Cost { get; set; }

        [JsonProperty("Vendor 4 Date Cost Verified")]
        public string Vendor4DateCostVerified { get; set; }

        [JsonProperty("Vendor 5")]
        public string Vendor5 { get; set; }

        [JsonProperty("Vendor 5 Part #")]
        public string Vendor5Part { get; set; }

        [JsonProperty("Vendor 5 Descrip")]
        public string Vendor5Descrip { get; set; }

        [JsonProperty("Vendor 5 Cost")]
        public string Vendor5Cost { get; set; }

        [JsonProperty("Vendor 5 Date Cost Verified")]
        public string Vendor5DateCostVerified { get; set; }

        [JsonProperty("Price Level Mode")]
        public string PriceLevelMode { get; set; }

        [JsonProperty("Price Level 2")]
        public string PriceLevel2 { get; set; }

        [JsonProperty("Price Level 3")]
        public string PriceLevel3 { get; set; }

        [JsonProperty("Price Level 4")]
        public string PriceLevel4 { get; set; }

        [JsonProperty("Price Level 5")]
        public string PriceLevel5 { get; set; }

        [JsonProperty("Price Level 6")]
        public string PriceLevel6 { get; set; }

        [JsonProperty("Price Level 7")]
        public string PriceLevel7 { get; set; }

        [JsonProperty("Price Level 8")]
        public string PriceLevel8 { get; set; }

        [JsonProperty("Price Level 9")]
        public string PriceLevel9 { get; set; }

        [JsonProperty("Price Level 10")]
        public string PriceLevel10 { get; set; }

        [JsonProperty("Price Level 11")]
        public string PriceLevel11 { get; set; }

        [JsonProperty("Price Level 12")]
        public string PriceLevel12 { get; set; }

        [JsonProperty("Price Level 13")]
        public string PriceLevel13 { get; set; }

        [JsonProperty("Price Level 14")]
        public string PriceLevel14 { get; set; }

        [JsonProperty("Price Level 15")]
        public string PriceLevel15 { get; set; }

        [JsonProperty("Price Level 16")]
        public string PriceLevel16 { get; set; }

        [JsonProperty("Price Level 17")]
        public string PriceLevel17 { get; set; }

        [JsonProperty("Price Level 18")]
        public string PriceLevel18 { get; set; }

        [JsonProperty("Price Level 19")]
        public string PriceLevel19 { get; set; }

        [JsonProperty("Price Level 20")]
        public string PriceLevel20 { get; set; }

        [JsonProperty("Quantity Level 1")]
        public string QuantityLevel1 { get; set; }

        [JsonProperty("Quantity Price 1")]
        public string QuantityPrice1 { get; set; }

        [JsonProperty("Quantity Price Level 1")]
        public string QuantityPriceLevel1 { get; set; }

        [JsonProperty("Quantity Level 2")]
        public string QuantityLevel2 { get; set; }

        [JsonProperty("Quantity Price 2")]
        public string QuantityPrice2 { get; set; }

        [JsonProperty("Quantity Price Level 2")]
        public string QuantityPriceLevel2 { get; set; }

        [JsonProperty("Quantity Level 3")]
        public string QuantityLevel3 { get; set; }

        [JsonProperty("Quantity Price 3")]
        public string QuantityPrice3 { get; set; }

        [JsonProperty("Quantity Price Level 3")]
        public string QuantityPriceLevel3 { get; set; }

        [JsonProperty("Quantity Level 4")]
        public string QuantityLevel4 { get; set; }

        [JsonProperty("Quantity Price 4")]
        public string QuantityPrice4 { get; set; }

        [JsonProperty("Quantity Price Level 4")]
        public string QuantityPriceLevel4 { get; set; }

        [JsonProperty("Quantity Level 5")]
        public string QuantityLevel5 { get; set; }

        [JsonProperty("Quantity Price 5")]
        public string QuantityPrice5 { get; set; }

        [JsonProperty("Quantity Price Level 5")]
        public string QuantityPriceLevel5 { get; set; }

        [JsonProperty("Quantity Level 6")]
        public string QuantityLevel6 { get; set; }

        [JsonProperty("Quantity Price 6")]
        public string QuantityPrice6 { get; set; }

        [JsonProperty("Quantity Price Level 6")]
        public string QuantityPriceLevel6 { get; set; }

        [JsonProperty("Quantity Level 7")]
        public string QuantityLevel7 { get; set; }

        [JsonProperty("Quantity Price 7")]
        public string QuantityPrice7 { get; set; }

        [JsonProperty("Quantity Price Level 7")]
        public string QuantityPriceLevel7 { get; set; }

        [JsonProperty("Quantity Level 8")]
        public string QuantityLevel8 { get; set; }

        [JsonProperty("Quantity Price 8")]
        public string QuantityPrice8 { get; set; }

        [JsonProperty("Quantity Price Level 8")]
        public string QuantityPriceLevel8 { get; set; }

        [JsonProperty("Quantity Level 9")]
        public string QuantityLevel9 { get; set; }

        [JsonProperty("Quantity Price 9")]
        public string QuantityPrice9 { get; set; }

        [JsonProperty("Quantity Price Level 9")]
        public string QuantityPriceLevel9 { get; set; }

        [JsonProperty("Quantity Level 10")]
        public string QuantityLevel10 { get; set; }

        [JsonProperty("Quantity Price 10")]
        public string QuantityPrice10 { get; set; }

        [JsonProperty("Quantity Price Level 10")]
        public string QuantityPriceLevel10 { get; set; }
    }

    public class LeadGetValueResponse
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("leadid")]
        public string Leadid { get; set; }
        public string Category { get; set; }

        [JsonProperty("recordid")]
        public string Recordid { get; set; }

        [JsonProperty("Company Name")]
        public string CompanyName { get; set; }
        public string Salutation { get; set; }

        [JsonProperty("First Name")]
        public string FirstName { get; set; }

        [JsonProperty("Last Name")]
        public string LastName { get; set; }

        [JsonProperty("Address Line 1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("Address Line 2")]
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        [JsonProperty("Postal Code")]
        public string PostalCode { get; set; }
        public string Country { get; set; }

        [JsonProperty("Time-Zone")]
        public string TimeZone { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string Title { get; set; }

        [JsonProperty("Contact Type")]
        public string ContactType { get; set; }

        [JsonProperty("Sales Rep")]
        public string SalesRep { get; set; }

        [JsonProperty("Phone Extension")]
        public string PhoneExtension { get; set; }

        [JsonProperty("Last Contact Date")]
        public string LastContactDate { get; set; }

        [JsonProperty("Contact Notes")]
        public string ContactNotes { get; set; }

        [JsonProperty("Quick Remark")]
        public string QuickRemark { get; set; }

        [JsonProperty("Created Date")]
        public string CreatedDate { get; set; }
        public string Market { get; set; }

        [JsonProperty("Sales Territory")]
        public string SalesTerritory { get; set; }

        [JsonProperty("Primary Email")]
        public string PrimaryEmail { get; set; }

        [JsonProperty("EMail 2")]
        public string EMail2 { get; set; }

        [JsonProperty("Email 3")]
        public string Email3 { get; set; }

        [JsonProperty("Email 4")]
        public string Email4 { get; set; }
        public string OPTOUT { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Phone3 { get; set; }
        public string Phone4 { get; set; }

        [JsonProperty("Promotion Memberships")]
        public string PromotionMemberships { get; set; }
        public string Source { get; set; }

        [JsonProperty("Source Notes")]
        public string SourceNotes { get; set; }
        public string Website { get; set; }
        public string Twitter { get; set; }
        public string Facebook { get; set; }
        public string LinkedIn { get; set; }

        [JsonProperty("Product Interest")]
        public string ProductInterest { get; set; }

        [JsonProperty("Assigned To Rep")]
        public string AssignedToRep { get; set; }
    }

    public enum typeInput
    {
        C,
        L,
        B
    }

    public enum bodyrecordtypeInput
    {
        L,
        C
    }

    public class MembersGetValueResponse
    {
        [JsonProperty("recordid")]
        public string Recordid { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("fname")]
        public string Fname { get; set; }

        [JsonProperty("lname")]
        public string Lname { get; set; }

        [JsonProperty("addr1")]
        public string Addr1 { get; set; }

        [JsonProperty("addr2")]
        public string Addr2 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zipcode")]
        public string Zipcode { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("email2")]
        public string Email2 { get; set; }

        [JsonProperty("email3")]
        public string Email3 { get; set; }

        [JsonProperty("email4")]
        public string Email4 { get; set; }

        [JsonProperty("phone1")]
        public string Phone1 { get; set; }

        [JsonProperty("phone2")]
        public string Phone2 { get; set; }

        [JsonProperty("phone3")]
        public string Phone3 { get; set; }

        [JsonProperty("phone4")]
        public string Phone4 { get; set; }
    }

    public enum bodyoperationInput
    {
        [EnumMember(Value = "remove")]
        Remove
    }

    public class ShippingGetValueResponse
    {
        public string Customer { get; set; }

        [JsonProperty("Order ID")]
        public string OrderID { get; set; }

        [JsonProperty("Model Number")]
        public string ModelNumber { get; set; }
        public string Descrip { get; set; }

        [JsonProperty("Shipped Qty")]
        public string ShippedQty { get; set; }
        public string BoxID { get; set; }
        public string Tracking { get; set; }

        [JsonProperty("Ship Date")]
        public string ShipDate { get; set; }

        [JsonProperty("Shipped By")]
        public string ShippedBy { get; set; }
        public string SerialData { get; set; }

        [JsonProperty("Ship_Company")]
        public string ShipCompany { get; set; }

        [JsonProperty("Ship_Contact")]
        public string ShipContact { get; set; }

        [JsonProperty("Ship_Addr1")]
        public string ShipAddr1 { get; set; }

        [JsonProperty("Ship_Addr2")]
        public string ShipAddr2 { get; set; }

        [JsonProperty("Ship_City")]
        public string ShipCity { get; set; }

        [JsonProperty("Ship_State")]
        public string ShipState { get; set; }

        [JsonProperty("Ship_ZipCode")]
        public string ShipZipCode { get; set; }

        [JsonProperty("Ship_Phone")]
        public string ShipPhone { get; set; }
        public string Carrier { get; set; }
        public string ShipmentID { get; set; }
        public string ItemID { get; set; }
    }

    public enum bodyorderstatusInput
    {
        [EnumMember(Value = "quote")]
        Quote,
        [EnumMember(Value = "confirmed")]
        Confirmed,
        [EnumMember(Value = "shipping")]
        Shipping,
        [EnumMember(Value = "history")]
        History
    }

    public class bodylinedataInputItem
    {
        [JsonProperty("qty")]
        public double Qty { get; set; }

        [JsonProperty("modelno")]
        public string Modelno { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("comments")]
        public string Comments { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; }

        [JsonProperty("discount")]
        public string Discount { get; set; }
    }

    public class SOGetValueResponse
    {
        [JsonProperty("Order ID")]
        public string OrderID { get; set; }

        [JsonProperty("PROCESSING PHASE")]
        public string PROCESSINGPHASE { get; set; }
        public string Account { get; set; }

        [JsonProperty("Account Name")]
        public string AccountName { get; set; }

        [JsonProperty("Sales Rep")]
        public string SalesRep { get; set; }

        [JsonProperty("Custom Status")]
        public string CustomStatus { get; set; }
        public string Description { get; set; }

        [JsonProperty("Quotation Date")]
        public string QuotationDate { get; set; }

        [JsonProperty("Close Date")]
        public string CloseDate { get; set; }

        [JsonProperty("Ship Date")]
        public string ShipDate { get; set; }

        [JsonProperty("Expiration Date")]
        public string ExpirationDate { get; set; }
        public string Terms { get; set; }

        [JsonProperty("Marketing Campaign")]
        public string MarketingCampaign { get; set; }

        [JsonProperty("Shipping Warehouse")]
        public string ShippingWarehouse { get; set; }
        public string FOB { get; set; }

        [JsonProperty("Deposit Required")]
        public string DepositRequired { get; set; }

        [JsonProperty("Total Weight")]
        public string TotalWeight { get; set; }

        [JsonProperty("Quote Amount")]
        public string QuoteAmount { get; set; }

        [JsonProperty("Partial Shipments OK")]
        public string PartialShipmentsOK { get; set; }

        [JsonProperty("Invoice Shipping")]
        public string InvoiceShipping { get; set; }

        [JsonProperty("IN HISTORY")]
        public string INHISTORY { get; set; }

        [JsonProperty("IS INACTIVE")]
        public string ISINACTIVE { get; set; }

        [JsonProperty("In-Pipeline")]
        public string InPipeline { get; set; }

        [JsonProperty("Tax 1")]
        public string Tax1 { get; set; }

        [JsonProperty("Tax 2")]
        public string Tax2 { get; set; }

        [JsonProperty("Is Template")]
        public string IsTemplate { get; set; }

        [JsonProperty("Template Name")]
        public string TemplateName { get; set; }

        [JsonProperty("Customer PO")]
        public string CustomerPO { get; set; }

        [JsonProperty("Ship To Company")]
        public string ShipToCompany { get; set; }

        [JsonProperty("Ship To Contact")]
        public string ShipToContact { get; set; }

        [JsonProperty("Ship To Addr 1")]
        public string ShipToAddr1 { get; set; }

        [JsonProperty("Ship To Addr 2")]
        public string ShipToAddr2 { get; set; }

        [JsonProperty("Ship To State")]
        public string ShipToState { get; set; }

        [JsonProperty("Ship To Postal Code")]
        public string ShipToPostalCode { get; set; }

        [JsonProperty("Ship To Country")]
        public string ShipToCountry { get; set; }

        [JsonProperty("Ship To Phone")]
        public string ShipToPhone { get; set; }

        [JsonProperty("Ship To EMail")]
        public string ShipToEMail { get; set; }
        public string Residential { get; set; }

        [JsonProperty("Formatted Ship To")]
        public string FormattedShipTo { get; set; }

        [JsonProperty("Paid Amount")]
        public string PaidAmount { get; set; }

        [JsonProperty("Balance Due")]
        public string BalanceDue { get; set; }

        [JsonProperty("QB Invoice Number")]
        public string QBInvoiceNumber { get; set; }

        [JsonProperty("Confirmed Order")]
        public string ConfirmedOrder { get; set; }
        public string Commission { get; set; }
        public string TotalCost { get; set; }
        public string Margin { get; set; }

        [JsonProperty("Project ID")]
        public string ProjectID { get; set; }

        [JsonProperty("Next Appointment")]
        public string NextAppointment { get; set; }

        [JsonProperty("Appointment With")]
        public string AppointmentWith { get; set; }

        [JsonProperty("linedata:")]
        public SOGetValueResponseLinedataTypeItem[] Linedata { get; set; }
    }

    public class SOGetValueResponseLinedataTypeItem
    {
        [JsonProperty("itemid")]
        public string Itemid { get; set; }

        [JsonProperty("orderqty")]
        public string Orderqty { get; set; }

        [JsonProperty("uom")]
        public string Uom { get; set; }

        [JsonProperty("modelno")]
        public string Modelno { get; set; }

        [JsonProperty("descrip")]
        public string Descrip { get; set; }

        [JsonProperty("comments")]
        public string Comments { get; set; }

        [JsonProperty("shippedqty")]
        public string Shippedqty { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("subttl")]
        public string Subttl { get; set; }

        [JsonProperty("total")]
        public string Total { get; set; }
    }

    public enum bodypriorityInput
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
        _4
    }

    public class WorkOrderGetValueResponse
    {
        [JsonProperty("Work Order Number")]
        public string WorkOrderNumber { get; set; }

        [JsonProperty("IN HISTORY")]
        public string INHISTORY { get; set; }
        public string INACTIVE { get; set; }
        public string Priority { get; set; }

        [JsonProperty("account")]
        public string Account { get; set; }

        [JsonProperty("Customer Name")]
        public string CustomerName { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }
        public string Content { get; set; }

        [JsonProperty("Assigned To")]
        public string AssignedTo { get; set; }

        [JsonProperty("Backup Assignment")]
        public string BackupAssignment { get; set; }

        [JsonProperty("Received Date")]
        public string ReceivedDate { get; set; }

        [JsonProperty("Due By")]
        public string DueBy { get; set; }

        [JsonProperty("Opened-By")]
        public string OpenedBy { get; set; }

        [JsonProperty("CONTRACT ID")]
        public string CONTRACTID { get; set; }
        public string Source { get; set; }

        [JsonProperty("Custom Status")]
        public string CustomStatus { get; set; }

        [JsonProperty("Reason Code")]
        public string ReasonCode { get; set; }

        [JsonProperty("Customer Reference Number")]
        public string CustomerReferenceNumber { get; set; }

        [JsonProperty("Service-To Company")]
        public string ServiceToCompany { get; set; }

        [JsonProperty("Service-To Contact")]
        public string ServiceToContact { get; set; }

        [JsonProperty("Service-To Address Line 1")]
        public string ServiceToAddressLine1 { get; set; }

        [JsonProperty("Service-To Address Line 2")]
        public string ServiceToAddressLine2 { get; set; }

        [JsonProperty("Service-To City")]
        public string ServiceToCity { get; set; }

        [JsonProperty("Service-To State")]
        public string ServiceToState { get; set; }

        [JsonProperty("Service-To Postal Code")]
        public string ServiceToPostalCode { get; set; }

        [JsonProperty("Service-To Phone")]
        public string ServiceToPhone { get; set; }

        [JsonProperty("Service-To Country")]
        public string ServiceToCountry { get; set; }

        [JsonProperty("Service-To County")]
        public string ServiceToCounty { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }

        [JsonProperty("Time-Zone")]
        public string TimeZone { get; set; }

        [JsonProperty("Formatted Service Address")]
        public string FormattedServiceAddress { get; set; }

        [JsonProperty("Created Date")]
        public string CreatedDate { get; set; }

        [JsonProperty("Customer Email")]
        public string CustomerEmail { get; set; }

        [JsonProperty("Customer PO")]
        public string CustomerPO { get; set; }

        [JsonProperty("Service Appointment")]
        public string ServiceAppointment { get; set; }

        [JsonProperty("Project ID")]
        public string ProjectID { get; set; }

        [JsonProperty("Total Charge")]
        public string TotalCharge { get; set; }

        [JsonProperty("Time Spent")]
        public string TimeSpent { get; set; }
    }

    public class NewSalesLeadResponseItem
    {
        [JsonProperty("lead id")]
        public string LeadId { get; set; }
    }

    public class NewMarketingCampaignResponseItem
    {
        [JsonProperty("promoid")]
        public string Promoid { get; set; }
    }

    public class NewMembersLeadsResponseItem
    {
        [JsonProperty("lead id")]
        public string LeadId { get; set; }
    }

    public class NewSalesOrderResponseItem
    {
        [JsonProperty("Order ID")]
        public string OrderID { get; set; }
    }

    public class NewProposalCreatedResponseItem
    {
        [JsonProperty("Quote ID")]
        public string QuoteID { get; set; }
    }

    public class OrderStatusChangedResponseItem
    {
        [JsonProperty("Order ID")]
        public string OrderID { get; set; }
    }

    public class OrderInHistoryResponseItem
    {
        [JsonProperty("Order ID")]
        public string OrderID { get; set; }
    }

    public class OrderInProcessingResponseItem
    {
        [JsonProperty("Order ID")]
        public string OrderID { get; set; }
    }

    public class OrderIsShippingResponseItem
    {
        [JsonProperty("Order ID")]
        public string OrderID { get; set; }
    }

    public class ProposalNeedsApprovalResponseItem
    {
        [JsonProperty("Quote ID")]
        public string QuoteID { get; set; }
    }

    public class WorkOrderClosedResponseItem
    {
        [JsonProperty("Work Order Number")]
        public string WorkOrderNumber { get; set; }
    }

    public class WorkOrderCreatedResponseItem
    {
        [JsonProperty("Work Order Number")]
        public string WorkOrderNumber { get; set; }
    }

    public class WorkOrderPastDueResponseItem
    {
        [JsonProperty("Work Order Number")]
        public string WorkOrderNumber { get; set; }
    }

    public class WorkOrderStatusChangedResponseItem
    {
        [JsonProperty("Work Order Number")]
        public string WorkOrderNumber { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Imprezian;

    public partial class WorkflowManagedActions
    {
        public ImprezianActions Imprezian(string connectionId) => new ImprezianActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ImprezianTriggers Imprezian(string connectionId) => new ImprezianTriggers(connectionId);
    }
}