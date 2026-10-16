//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Imprezian
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
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
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: true);
            var __workflow_bodyexpires = WorkflowExpression.Compile(bodyexpires, nameof(bodyexpires), required: true);
            var __workflow_bodybudget = WorkflowExpression.Compile(bodybudget, nameof(bodybudget), required: true);
            var __workflow_bodystartdate = WorkflowExpression.Compile(bodystartdate, nameof(bodystartdate), required: false);
            var __workflow_bodypromotype = WorkflowExpression.Compile(bodypromotype, nameof(bodypromotype), required: false);
            var __workflow_bodymanager = WorkflowExpression.Compile(bodymanager, nameof(bodymanager), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/api/Campaign";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                if (__workflow_bodystartdate != null)
                {
                    body["startdate"] = ExpressionConverter.ConvertO(__workflow_bodystartdate);
                    bodypropCount++;
                }

                bodypropCount++;
                body["expires"] = ExpressionConverter.ConvertO(__workflow_bodyexpires);
                bodypropCount++;
                body["budget"] = ExpressionConverter.ConvertO(__workflow_bodybudget);
                if (__workflow_bodypromotype != null)
                {
                    body["promotype"] = ExpressionConverter.ConvertO(__workflow_bodypromotype);
                    bodypropCount++;
                }

                if (__workflow_bodymanager != null)
                {
                    body["manager"] = ExpressionConverter.ConvertO(__workflow_bodymanager);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<CampaignGetValueResponse> CampaignGetValue(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<CampaignGetValueResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/Campaign/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CampaignGetValueResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<JToken> CampaignPutValue(Expression<Func<string>> id, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodystartdate = null, Expression<Func<string>> bodyexpires = null, Expression<Func<double>> bodybudget = null, Expression<Func<string>> bodymanager = null, Expression<Func<bool>> bodyhistory = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodystartdate = WorkflowExpression.Compile(bodystartdate, nameof(bodystartdate), required: false);
            var __workflow_bodyexpires = WorkflowExpression.Compile(bodyexpires, nameof(bodyexpires), required: false);
            var __workflow_bodybudget = WorkflowExpression.Compile(bodybudget, nameof(bodybudget), required: false);
            var __workflow_bodymanager = WorkflowExpression.Compile(bodymanager, nameof(bodymanager), required: false);
            var __workflow_bodyhistory = WorkflowExpression.Compile(bodyhistory, nameof(bodyhistory), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/Campaign/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodystartdate != null)
                {
                    body["startdate"] = ExpressionConverter.ConvertO(__workflow_bodystartdate);
                    bodypropCount++;
                }

                if (__workflow_bodyexpires != null)
                {
                    body["expires"] = ExpressionConverter.ConvertO(__workflow_bodyexpires);
                    bodypropCount++;
                }

                if (__workflow_bodybudget != null)
                {
                    body["budget"] = ExpressionConverter.ConvertO(__workflow_bodybudget);
                    bodypropCount++;
                }

                if (__workflow_bodymanager != null)
                {
                    body["manager"] = ExpressionConverter.ConvertO(__workflow_bodymanager);
                    bodypropCount++;
                }

                if (__workflow_bodyhistory != null)
                {
                    body["history"] = ExpressionConverter.ConvertO(__workflow_bodyhistory);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
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
            var __workflow_bodycontactid = WorkflowExpression.Compile(bodycontactid, nameof(bodycontactid), required: false);
            var __workflow_bodyleadid = WorkflowExpression.Compile(bodyleadid, nameof(bodyleadid), required: false);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: false);
            var __workflow_bodysubject = WorkflowExpression.Compile(bodysubject, nameof(bodysubject), required: false);
            var __workflow_bodybody = WorkflowExpression.Compile(bodybody, nameof(bodybody), required: false);
            var __workflow_bodyemployee = WorkflowExpression.Compile(bodyemployee, nameof(bodyemployee), required: false);
            var __workflow_bodystarttime = WorkflowExpression.Compile(bodystarttime, nameof(bodystarttime), required: false);
            var __workflow_bodyendtime = WorkflowExpression.Compile(bodyendtime, nameof(bodyendtime), required: false);
            var __workflow_bodyworkorder = WorkflowExpression.Compile(bodyworkorder, nameof(bodyworkorder), required: false);
            var __workflow_bodyproject = WorkflowExpression.Compile(bodyproject, nameof(bodyproject), required: false);
            var __workflow_bodycampaign = WorkflowExpression.Compile(bodycampaign, nameof(bodycampaign), required: false);
            var __workflow_bodylength = WorkflowExpression.Compile(bodylength, nameof(bodylength), required: false);
            var __workflow_bodybilled = WorkflowExpression.Compile(bodybilled, nameof(bodybilled), required: false);
            var __workflow_bodyinbound = WorkflowExpression.Compile(bodyinbound, nameof(bodyinbound), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/api/ComLog";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodycontactid != null)
                {
                    body["contactid"] = ExpressionConverter.ConvertO(__workflow_bodycontactid);
                    bodypropCount++;
                }

                if (__workflow_bodyleadid != null)
                {
                    body["leadid"] = ExpressionConverter.ConvertO(__workflow_bodyleadid);
                    bodypropCount++;
                }

                if (__workflow_bodytype != null)
                {
                    body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                    bodypropCount++;
                }

                if (__workflow_bodysubject != null)
                {
                    body["subject"] = ExpressionConverter.ConvertO(__workflow_bodysubject);
                    bodypropCount++;
                }

                if (__workflow_bodybody != null)
                {
                    body["body"] = ExpressionConverter.ConvertO(__workflow_bodybody);
                    bodypropCount++;
                }

                if (__workflow_bodyemployee != null)
                {
                    body["employee"] = ExpressionConverter.ConvertO(__workflow_bodyemployee);
                    bodypropCount++;
                }

                if (__workflow_bodystarttime != null)
                {
                    body["starttime"] = ExpressionConverter.ConvertO(__workflow_bodystarttime);
                    bodypropCount++;
                }

                if (__workflow_bodyendtime != null)
                {
                    body["endtime"] = ExpressionConverter.ConvertO(__workflow_bodyendtime);
                    bodypropCount++;
                }

                if (__workflow_bodyworkorder != null)
                {
                    body["workorder"] = ExpressionConverter.ConvertO(__workflow_bodyworkorder);
                    bodypropCount++;
                }

                if (__workflow_bodyproject != null)
                {
                    body["project"] = ExpressionConverter.ConvertO(__workflow_bodyproject);
                    bodypropCount++;
                }

                if (__workflow_bodycampaign != null)
                {
                    body["campaign"] = ExpressionConverter.ConvertO(__workflow_bodycampaign);
                    bodypropCount++;
                }

                if (__workflow_bodylength != null)
                {
                    body["length"] = ExpressionConverter.ConvertO(__workflow_bodylength);
                    bodypropCount++;
                }

                if (__workflow_bodybilled != null)
                {
                    body["billed"] = ExpressionConverter.ConvertO(__workflow_bodybilled);
                    bodypropCount++;
                }

                if (__workflow_bodyinbound != null)
                {
                    body["inbound"] = ExpressionConverter.ConvertO(__workflow_bodyinbound);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<ComLogGetValueResponse> ComLogGetValue(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ComLogGetValueResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/ComLog/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ComLogGetValueResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IWorkflowAction ComLogPutValue(Expression<Func<string>> id, Expression<Func<bodytypeInput>> bodytype = null, Expression<Func<string>> bodysubject = null, Expression<Func<string>> bodybody = null, Expression<Func<string>> bodyemployee = null, Expression<Func<string>> bodystarttime = null, Expression<Func<string>> bodyendtime = null, Expression<Func<string>> bodyworkorder = null, Expression<Func<string>> bodyproject = null, Expression<Func<string>> bodycampaign = null, Expression<Func<double>> bodylength = null, Expression<Func<bool>> bodybilled = null, Expression<Func<bool>> bodyinbound = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: false);
            var __workflow_bodysubject = WorkflowExpression.Compile(bodysubject, nameof(bodysubject), required: false);
            var __workflow_bodybody = WorkflowExpression.Compile(bodybody, nameof(bodybody), required: false);
            var __workflow_bodyemployee = WorkflowExpression.Compile(bodyemployee, nameof(bodyemployee), required: false);
            var __workflow_bodystarttime = WorkflowExpression.Compile(bodystarttime, nameof(bodystarttime), required: false);
            var __workflow_bodyendtime = WorkflowExpression.Compile(bodyendtime, nameof(bodyendtime), required: false);
            var __workflow_bodyworkorder = WorkflowExpression.Compile(bodyworkorder, nameof(bodyworkorder), required: false);
            var __workflow_bodyproject = WorkflowExpression.Compile(bodyproject, nameof(bodyproject), required: false);
            var __workflow_bodycampaign = WorkflowExpression.Compile(bodycampaign, nameof(bodycampaign), required: false);
            var __workflow_bodylength = WorkflowExpression.Compile(bodylength, nameof(bodylength), required: false);
            var __workflow_bodybilled = WorkflowExpression.Compile(bodybilled, nameof(bodybilled), required: false);
            var __workflow_bodyinbound = WorkflowExpression.Compile(bodyinbound, nameof(bodyinbound), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/ComLog/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytype != null)
                {
                    body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                    bodypropCount++;
                }

                if (__workflow_bodysubject != null)
                {
                    body["subject"] = ExpressionConverter.ConvertO(__workflow_bodysubject);
                    bodypropCount++;
                }

                if (__workflow_bodybody != null)
                {
                    body["body"] = ExpressionConverter.ConvertO(__workflow_bodybody);
                    bodypropCount++;
                }

                if (__workflow_bodyemployee != null)
                {
                    body["employee"] = ExpressionConverter.ConvertO(__workflow_bodyemployee);
                    bodypropCount++;
                }

                if (__workflow_bodystarttime != null)
                {
                    body["starttime"] = ExpressionConverter.ConvertO(__workflow_bodystarttime);
                    bodypropCount++;
                }

                if (__workflow_bodyendtime != null)
                {
                    body["endtime"] = ExpressionConverter.ConvertO(__workflow_bodyendtime);
                    bodypropCount++;
                }

                if (__workflow_bodyworkorder != null)
                {
                    body["workorder"] = ExpressionConverter.ConvertO(__workflow_bodyworkorder);
                    bodypropCount++;
                }

                if (__workflow_bodyproject != null)
                {
                    body["project"] = ExpressionConverter.ConvertO(__workflow_bodyproject);
                    bodypropCount++;
                }

                if (__workflow_bodycampaign != null)
                {
                    body["campaign"] = ExpressionConverter.ConvertO(__workflow_bodycampaign);
                    bodypropCount++;
                }

                if (__workflow_bodylength != null)
                {
                    body["length"] = ExpressionConverter.ConvertO(__workflow_bodylength);
                    bodypropCount++;
                }

                if (__workflow_bodybilled != null)
                {
                    body["billed"] = ExpressionConverter.ConvertO(__workflow_bodybilled);
                    bodypropCount++;
                }

                if (__workflow_bodyinbound != null)
                {
                    body["inbound"] = ExpressionConverter.ConvertO(__workflow_bodyinbound);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
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
            var __workflow_bodyaccount = WorkflowExpression.Compile(bodyaccount, nameof(bodyaccount), required: false);
            var __workflow_bodysal = WorkflowExpression.Compile(bodysal, nameof(bodysal), required: false);
            var __workflow_bodyfirstname = WorkflowExpression.Compile(bodyfirstname, nameof(bodyfirstname), required: false);
            var __workflow_bodymiddlename = WorkflowExpression.Compile(bodymiddlename, nameof(bodymiddlename), required: false);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: false);
            var __workflow_bodylastname = WorkflowExpression.Compile(bodylastname, nameof(bodylastname), required: false);
            var __workflow_bodycompany = WorkflowExpression.Compile(bodycompany, nameof(bodycompany), required: false);
            var __workflow_bodyaddr1 = WorkflowExpression.Compile(bodyaddr1, nameof(bodyaddr1), required: false);
            var __workflow_bodyaddr2 = WorkflowExpression.Compile(bodyaddr2, nameof(bodyaddr2), required: false);
            var __workflow_bodycity = WorkflowExpression.Compile(bodycity, nameof(bodycity), required: false);
            var __workflow_bodystate = WorkflowExpression.Compile(bodystate, nameof(bodystate), required: false);
            var __workflow_bodypostal = WorkflowExpression.Compile(bodypostal, nameof(bodypostal), required: false);
            var __workflow_bodyemail1 = WorkflowExpression.Compile(bodyemail1, nameof(bodyemail1), required: false);
            var __workflow_bodyemail2 = WorkflowExpression.Compile(bodyemail2, nameof(bodyemail2), required: false);
            var __workflow_bodyemail3 = WorkflowExpression.Compile(bodyemail3, nameof(bodyemail3), required: false);
            var __workflow_bodyemail4 = WorkflowExpression.Compile(bodyemail4, nameof(bodyemail4), required: false);
            var __workflow_bodyphonetype1 = WorkflowExpression.Compile(bodyphonetype1, nameof(bodyphonetype1), required: false);
            var __workflow_bodyphone1 = WorkflowExpression.Compile(bodyphone1, nameof(bodyphone1), required: false);
            var __workflow_bodyphonetype2 = WorkflowExpression.Compile(bodyphonetype2, nameof(bodyphonetype2), required: false);
            var __workflow_bodyphone2 = WorkflowExpression.Compile(bodyphone2, nameof(bodyphone2), required: false);
            var __workflow_bodyphonetype3 = WorkflowExpression.Compile(bodyphonetype3, nameof(bodyphonetype3), required: false);
            var __workflow_bodyphone3 = WorkflowExpression.Compile(bodyphone3, nameof(bodyphone3), required: false);
            var __workflow_bodyphonetype4 = WorkflowExpression.Compile(bodyphonetype4, nameof(bodyphonetype4), required: false);
            var __workflow_bodyphone4 = WorkflowExpression.Compile(bodyphone4, nameof(bodyphone4), required: false);
            var __workflow_bodyremark = WorkflowExpression.Compile(bodyremark, nameof(bodyremark), required: false);
            var __workflow_bodynotes = WorkflowExpression.Compile(bodynotes, nameof(bodynotes), required: false);
            var __workflow_bodycampaign = WorkflowExpression.Compile(bodycampaign, nameof(bodycampaign), required: false);
            var __workflow_bodycategory = WorkflowExpression.Compile(bodycategory, nameof(bodycategory), required: false);
            var __workflow_bodymarket = WorkflowExpression.Compile(bodymarket, nameof(bodymarket), required: false);
            var __workflow_bodyterritory = WorkflowExpression.Compile(bodyterritory, nameof(bodyterritory), required: false);
            var __workflow_bodysalesrep = WorkflowExpression.Compile(bodysalesrep, nameof(bodysalesrep), required: false);
            var __workflow_bodylastcontact = WorkflowExpression.Compile(bodylastcontact, nameof(bodylastcontact), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/api/Contact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyaccount != null)
                {
                    body["account"] = ExpressionConverter.ConvertO(__workflow_bodyaccount);
                    bodypropCount++;
                }

                if (__workflow_bodysal != null)
                {
                    body["sal"] = ExpressionConverter.ConvertO(__workflow_bodysal);
                    bodypropCount++;
                }

                if (__workflow_bodyfirstname != null)
                {
                    body["firstname"] = ExpressionConverter.ConvertO(__workflow_bodyfirstname);
                    bodypropCount++;
                }

                if (__workflow_bodymiddlename != null)
                {
                    body["middlename"] = ExpressionConverter.ConvertO(__workflow_bodymiddlename);
                    bodypropCount++;
                }

                if (__workflow_bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (__workflow_bodylastname != null)
                {
                    body["lastname"] = ExpressionConverter.ConvertO(__workflow_bodylastname);
                    bodypropCount++;
                }

                if (__workflow_bodycompany != null)
                {
                    body["company"] = ExpressionConverter.ConvertO(__workflow_bodycompany);
                    bodypropCount++;
                }

                if (__workflow_bodyaddr1 != null)
                {
                    body["addr1"] = ExpressionConverter.ConvertO(__workflow_bodyaddr1);
                    bodypropCount++;
                }

                if (__workflow_bodyaddr2 != null)
                {
                    body["addr2"] = ExpressionConverter.ConvertO(__workflow_bodyaddr2);
                    bodypropCount++;
                }

                if (__workflow_bodycity != null)
                {
                    body["city"] = ExpressionConverter.ConvertO(__workflow_bodycity);
                    bodypropCount++;
                }

                if (__workflow_bodystate != null)
                {
                    body["state"] = ExpressionConverter.ConvertO(__workflow_bodystate);
                    bodypropCount++;
                }

                if (__workflow_bodypostal != null)
                {
                    body["postal"] = ExpressionConverter.ConvertO(__workflow_bodypostal);
                    bodypropCount++;
                }

                if (__workflow_bodyemail1 != null)
                {
                    body["email1"] = ExpressionConverter.ConvertO(__workflow_bodyemail1);
                    bodypropCount++;
                }

                if (__workflow_bodyemail2 != null)
                {
                    body["email2"] = ExpressionConverter.ConvertO(__workflow_bodyemail2);
                    bodypropCount++;
                }

                if (__workflow_bodyemail3 != null)
                {
                    body["email3"] = ExpressionConverter.ConvertO(__workflow_bodyemail3);
                    bodypropCount++;
                }

                if (__workflow_bodyemail4 != null)
                {
                    body["email4"] = ExpressionConverter.ConvertO(__workflow_bodyemail4);
                    bodypropCount++;
                }

                if (__workflow_bodyphonetype1 != null)
                {
                    body["phonetype1"] = ExpressionConverter.ConvertO(__workflow_bodyphonetype1);
                    bodypropCount++;
                }

                if (__workflow_bodyphone1 != null)
                {
                    body["phone1"] = ExpressionConverter.ConvertO(__workflow_bodyphone1);
                    bodypropCount++;
                }

                if (__workflow_bodyphonetype2 != null)
                {
                    body["phonetype2"] = ExpressionConverter.ConvertO(__workflow_bodyphonetype2);
                    bodypropCount++;
                }

                if (__workflow_bodyphone2 != null)
                {
                    body["phone2"] = ExpressionConverter.ConvertO(__workflow_bodyphone2);
                    bodypropCount++;
                }

                if (__workflow_bodyphonetype3 != null)
                {
                    body["phonetype3"] = ExpressionConverter.ConvertO(__workflow_bodyphonetype3);
                    bodypropCount++;
                }

                if (__workflow_bodyphone3 != null)
                {
                    body["phone3"] = ExpressionConverter.ConvertO(__workflow_bodyphone3);
                    bodypropCount++;
                }

                if (__workflow_bodyphonetype4 != null)
                {
                    body["phonetype4"] = ExpressionConverter.ConvertO(__workflow_bodyphonetype4);
                    bodypropCount++;
                }

                if (__workflow_bodyphone4 != null)
                {
                    body["phone4"] = ExpressionConverter.ConvertO(__workflow_bodyphone4);
                    bodypropCount++;
                }

                if (__workflow_bodyremark != null)
                {
                    body["remark"] = ExpressionConverter.ConvertO(__workflow_bodyremark);
                    bodypropCount++;
                }

                if (__workflow_bodynotes != null)
                {
                    body["notes"] = ExpressionConverter.ConvertO(__workflow_bodynotes);
                    bodypropCount++;
                }

                if (__workflow_bodycampaign != null)
                {
                    body["campaign"] = ExpressionConverter.ConvertO(__workflow_bodycampaign);
                    bodypropCount++;
                }

                if (__workflow_bodycategory != null)
                {
                    body["category"] = ExpressionConverter.ConvertO(__workflow_bodycategory);
                    bodypropCount++;
                }

                if (__workflow_bodymarket != null)
                {
                    body["market"] = ExpressionConverter.ConvertO(__workflow_bodymarket);
                    bodypropCount++;
                }

                if (__workflow_bodyterritory != null)
                {
                    body["territory"] = ExpressionConverter.ConvertO(__workflow_bodyterritory);
                    bodypropCount++;
                }

                if (__workflow_bodysalesrep != null)
                {
                    body["salesrep"] = ExpressionConverter.ConvertO(__workflow_bodysalesrep);
                    bodypropCount++;
                }

                if (__workflow_bodylastcontact != null)
                {
                    body["lastcontact"] = ExpressionConverter.ConvertO(__workflow_bodylastcontact);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<JToken> ContactGetValue(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/Contact/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<JToken> ContactPutValue(Expression<Func<string>> id, Expression<Func<string>> bodysal = null, Expression<Func<string>> bodyfirstname = null, Expression<Func<string>> bodymiddlename = null, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodylastname = null, Expression<Func<string>> bodycompany = null, Expression<Func<string>> bodyaddr1 = null, Expression<Func<string>> bodyaddr2 = null, Expression<Func<string>> bodycity = null, Expression<Func<string>> bodystate = null, Expression<Func<string>> bodypostal = null, Expression<Func<string>> bodyemail1 = null, Expression<Func<string>> bodyemail2 = null, Expression<Func<string>> bodyemail3 = null, Expression<Func<string>> bodyemail4 = null, Expression<Func<string>> bodyphonetype1 = null, Expression<Func<string>> bodyphone1 = null, Expression<Func<string>> bodyphonetype2 = null, Expression<Func<string>> bodyphone2 = null, Expression<Func<string>> bodyphonetype3 = null, Expression<Func<string>> bodyphone3 = null, Expression<Func<string>> bodyphonetype4 = null, Expression<Func<string>> bodyphone4 = null, Expression<Func<string>> bodyremark = null, Expression<Func<string>> bodynotes = null, Expression<Func<string>> bodycampaign = null, Expression<Func<string>> bodycategory = null, Expression<Func<string>> bodymarket = null, Expression<Func<string>> bodyterritory = null, Expression<Func<string>> bodysalesrep = null, Expression<Func<string>> bodylastcontact = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodysal = WorkflowExpression.Compile(bodysal, nameof(bodysal), required: false);
            var __workflow_bodyfirstname = WorkflowExpression.Compile(bodyfirstname, nameof(bodyfirstname), required: false);
            var __workflow_bodymiddlename = WorkflowExpression.Compile(bodymiddlename, nameof(bodymiddlename), required: false);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: false);
            var __workflow_bodylastname = WorkflowExpression.Compile(bodylastname, nameof(bodylastname), required: false);
            var __workflow_bodycompany = WorkflowExpression.Compile(bodycompany, nameof(bodycompany), required: false);
            var __workflow_bodyaddr1 = WorkflowExpression.Compile(bodyaddr1, nameof(bodyaddr1), required: false);
            var __workflow_bodyaddr2 = WorkflowExpression.Compile(bodyaddr2, nameof(bodyaddr2), required: false);
            var __workflow_bodycity = WorkflowExpression.Compile(bodycity, nameof(bodycity), required: false);
            var __workflow_bodystate = WorkflowExpression.Compile(bodystate, nameof(bodystate), required: false);
            var __workflow_bodypostal = WorkflowExpression.Compile(bodypostal, nameof(bodypostal), required: false);
            var __workflow_bodyemail1 = WorkflowExpression.Compile(bodyemail1, nameof(bodyemail1), required: false);
            var __workflow_bodyemail2 = WorkflowExpression.Compile(bodyemail2, nameof(bodyemail2), required: false);
            var __workflow_bodyemail3 = WorkflowExpression.Compile(bodyemail3, nameof(bodyemail3), required: false);
            var __workflow_bodyemail4 = WorkflowExpression.Compile(bodyemail4, nameof(bodyemail4), required: false);
            var __workflow_bodyphonetype1 = WorkflowExpression.Compile(bodyphonetype1, nameof(bodyphonetype1), required: false);
            var __workflow_bodyphone1 = WorkflowExpression.Compile(bodyphone1, nameof(bodyphone1), required: false);
            var __workflow_bodyphonetype2 = WorkflowExpression.Compile(bodyphonetype2, nameof(bodyphonetype2), required: false);
            var __workflow_bodyphone2 = WorkflowExpression.Compile(bodyphone2, nameof(bodyphone2), required: false);
            var __workflow_bodyphonetype3 = WorkflowExpression.Compile(bodyphonetype3, nameof(bodyphonetype3), required: false);
            var __workflow_bodyphone3 = WorkflowExpression.Compile(bodyphone3, nameof(bodyphone3), required: false);
            var __workflow_bodyphonetype4 = WorkflowExpression.Compile(bodyphonetype4, nameof(bodyphonetype4), required: false);
            var __workflow_bodyphone4 = WorkflowExpression.Compile(bodyphone4, nameof(bodyphone4), required: false);
            var __workflow_bodyremark = WorkflowExpression.Compile(bodyremark, nameof(bodyremark), required: false);
            var __workflow_bodynotes = WorkflowExpression.Compile(bodynotes, nameof(bodynotes), required: false);
            var __workflow_bodycampaign = WorkflowExpression.Compile(bodycampaign, nameof(bodycampaign), required: false);
            var __workflow_bodycategory = WorkflowExpression.Compile(bodycategory, nameof(bodycategory), required: false);
            var __workflow_bodymarket = WorkflowExpression.Compile(bodymarket, nameof(bodymarket), required: false);
            var __workflow_bodyterritory = WorkflowExpression.Compile(bodyterritory, nameof(bodyterritory), required: false);
            var __workflow_bodysalesrep = WorkflowExpression.Compile(bodysalesrep, nameof(bodysalesrep), required: false);
            var __workflow_bodylastcontact = WorkflowExpression.Compile(bodylastcontact, nameof(bodylastcontact), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/Contact/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodysal != null)
                {
                    body["sal"] = ExpressionConverter.ConvertO(__workflow_bodysal);
                    bodypropCount++;
                }

                if (__workflow_bodyfirstname != null)
                {
                    body["firstname"] = ExpressionConverter.ConvertO(__workflow_bodyfirstname);
                    bodypropCount++;
                }

                if (__workflow_bodymiddlename != null)
                {
                    body["middlename"] = ExpressionConverter.ConvertO(__workflow_bodymiddlename);
                    bodypropCount++;
                }

                if (__workflow_bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (__workflow_bodylastname != null)
                {
                    body["lastname"] = ExpressionConverter.ConvertO(__workflow_bodylastname);
                    bodypropCount++;
                }

                if (__workflow_bodycompany != null)
                {
                    body["company"] = ExpressionConverter.ConvertO(__workflow_bodycompany);
                    bodypropCount++;
                }

                if (__workflow_bodyaddr1 != null)
                {
                    body["addr1"] = ExpressionConverter.ConvertO(__workflow_bodyaddr1);
                    bodypropCount++;
                }

                if (__workflow_bodyaddr2 != null)
                {
                    body["addr2"] = ExpressionConverter.ConvertO(__workflow_bodyaddr2);
                    bodypropCount++;
                }

                if (__workflow_bodycity != null)
                {
                    body["city"] = ExpressionConverter.ConvertO(__workflow_bodycity);
                    bodypropCount++;
                }

                if (__workflow_bodystate != null)
                {
                    body["state"] = ExpressionConverter.ConvertO(__workflow_bodystate);
                    bodypropCount++;
                }

                if (__workflow_bodypostal != null)
                {
                    body["postal"] = ExpressionConverter.ConvertO(__workflow_bodypostal);
                    bodypropCount++;
                }

                if (__workflow_bodyemail1 != null)
                {
                    body["email1"] = ExpressionConverter.ConvertO(__workflow_bodyemail1);
                    bodypropCount++;
                }

                if (__workflow_bodyemail2 != null)
                {
                    body["email2"] = ExpressionConverter.ConvertO(__workflow_bodyemail2);
                    bodypropCount++;
                }

                if (__workflow_bodyemail3 != null)
                {
                    body["email3"] = ExpressionConverter.ConvertO(__workflow_bodyemail3);
                    bodypropCount++;
                }

                if (__workflow_bodyemail4 != null)
                {
                    body["email4"] = ExpressionConverter.ConvertO(__workflow_bodyemail4);
                    bodypropCount++;
                }

                if (__workflow_bodyphonetype1 != null)
                {
                    body["phonetype1"] = ExpressionConverter.ConvertO(__workflow_bodyphonetype1);
                    bodypropCount++;
                }

                if (__workflow_bodyphone1 != null)
                {
                    body["phone1"] = ExpressionConverter.ConvertO(__workflow_bodyphone1);
                    bodypropCount++;
                }

                if (__workflow_bodyphonetype2 != null)
                {
                    body["phonetype2"] = ExpressionConverter.ConvertO(__workflow_bodyphonetype2);
                    bodypropCount++;
                }

                if (__workflow_bodyphone2 != null)
                {
                    body["phone2"] = ExpressionConverter.ConvertO(__workflow_bodyphone2);
                    bodypropCount++;
                }

                if (__workflow_bodyphonetype3 != null)
                {
                    body["phonetype3"] = ExpressionConverter.ConvertO(__workflow_bodyphonetype3);
                    bodypropCount++;
                }

                if (__workflow_bodyphone3 != null)
                {
                    body["phone3"] = ExpressionConverter.ConvertO(__workflow_bodyphone3);
                    bodypropCount++;
                }

                if (__workflow_bodyphonetype4 != null)
                {
                    body["phonetype4"] = ExpressionConverter.ConvertO(__workflow_bodyphonetype4);
                    bodypropCount++;
                }

                if (__workflow_bodyphone4 != null)
                {
                    body["phone4"] = ExpressionConverter.ConvertO(__workflow_bodyphone4);
                    bodypropCount++;
                }

                if (__workflow_bodyremark != null)
                {
                    body["remark"] = ExpressionConverter.ConvertO(__workflow_bodyremark);
                    bodypropCount++;
                }

                if (__workflow_bodynotes != null)
                {
                    body["notes"] = ExpressionConverter.ConvertO(__workflow_bodynotes);
                    bodypropCount++;
                }

                if (__workflow_bodycampaign != null)
                {
                    body["campaign"] = ExpressionConverter.ConvertO(__workflow_bodycampaign);
                    bodypropCount++;
                }

                if (__workflow_bodycategory != null)
                {
                    body["category"] = ExpressionConverter.ConvertO(__workflow_bodycategory);
                    bodypropCount++;
                }

                if (__workflow_bodymarket != null)
                {
                    body["market"] = ExpressionConverter.ConvertO(__workflow_bodymarket);
                    bodypropCount++;
                }

                if (__workflow_bodyterritory != null)
                {
                    body["territory"] = ExpressionConverter.ConvertO(__workflow_bodyterritory);
                    bodypropCount++;
                }

                if (__workflow_bodysalesrep != null)
                {
                    body["salesrep"] = ExpressionConverter.ConvertO(__workflow_bodysalesrep);
                    bodypropCount++;
                }

                if (__workflow_bodylastcontact != null)
                {
                    body["lastcontact"] = ExpressionConverter.ConvertO(__workflow_bodylastcontact);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
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
            var __workflow_bodycontactid = WorkflowExpression.Compile(bodycontactid, nameof(bodycontactid), required: false);
            var __workflow_bodyleadid = WorkflowExpression.Compile(bodyleadid, nameof(bodyleadid), required: false);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: false);
            var __workflow_bodycomments = WorkflowExpression.Compile(bodycomments, nameof(bodycomments), required: false);
            var __workflow_bodyassignedto = WorkflowExpression.Compile(bodyassignedto, nameof(bodyassignedto), required: false);
            var __workflow_bodysetby = WorkflowExpression.Compile(bodysetby, nameof(bodysetby), required: false);
            var __workflow_bodyduedate = WorkflowExpression.Compile(bodyduedate, nameof(bodyduedate), required: false);
            var __workflow_bodyurgent = WorkflowExpression.Compile(bodyurgent, nameof(bodyurgent), required: false);
            var __workflow_bodyreminderminutes = WorkflowExpression.Compile(bodyreminderminutes, nameof(bodyreminderminutes), required: false);
            var __workflow_bodycleared = WorkflowExpression.Compile(bodycleared, nameof(bodycleared), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/api/FollowUp";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodycontactid != null)
                {
                    body["contactid"] = ExpressionConverter.ConvertO(__workflow_bodycontactid);
                    bodypropCount++;
                }

                if (__workflow_bodyleadid != null)
                {
                    body["leadid"] = ExpressionConverter.ConvertO(__workflow_bodyleadid);
                    bodypropCount++;
                }

                if (__workflow_bodytype != null)
                {
                    body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                    bodypropCount++;
                }

                if (__workflow_bodycomments != null)
                {
                    body["comments"] = ExpressionConverter.ConvertO(__workflow_bodycomments);
                    bodypropCount++;
                }

                if (__workflow_bodyassignedto != null)
                {
                    body["assignedto"] = ExpressionConverter.ConvertO(__workflow_bodyassignedto);
                    bodypropCount++;
                }

                if (__workflow_bodysetby != null)
                {
                    body["setby"] = ExpressionConverter.ConvertO(__workflow_bodysetby);
                    bodypropCount++;
                }

                if (__workflow_bodyduedate != null)
                {
                    body["duedate"] = ExpressionConverter.ConvertO(__workflow_bodyduedate);
                    bodypropCount++;
                }

                if (__workflow_bodyurgent != null)
                {
                    body["urgent"] = ExpressionConverter.ConvertO(__workflow_bodyurgent);
                    bodypropCount++;
                }

                if (__workflow_bodyreminderminutes != null)
                {
                    body["reminderminutes"] = ExpressionConverter.ConvertO(__workflow_bodyreminderminutes);
                    bodypropCount++;
                }

                if (__workflow_bodycleared != null)
                {
                    body["cleared"] = ExpressionConverter.ConvertO(__workflow_bodycleared);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<FollowUpGetValueResponse> FollowUpGetValue(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<FollowUpGetValueResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/FollowUp/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<FollowUpGetValueResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IWorkflowAction FollowUpPutValue(Expression<Func<string>> id, Expression<Func<string>> bodytype = null, Expression<Func<string>> bodycomments = null, Expression<Func<string>> bodyassignedto = null, Expression<Func<string>> bodysetby = null, Expression<Func<string>> bodyduedate = null, Expression<Func<string>> bodyurgent = null, Expression<Func<double>> bodyreminderminutes = null, Expression<Func<bool>> bodycleared = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: false);
            var __workflow_bodycomments = WorkflowExpression.Compile(bodycomments, nameof(bodycomments), required: false);
            var __workflow_bodyassignedto = WorkflowExpression.Compile(bodyassignedto, nameof(bodyassignedto), required: false);
            var __workflow_bodysetby = WorkflowExpression.Compile(bodysetby, nameof(bodysetby), required: false);
            var __workflow_bodyduedate = WorkflowExpression.Compile(bodyduedate, nameof(bodyduedate), required: false);
            var __workflow_bodyurgent = WorkflowExpression.Compile(bodyurgent, nameof(bodyurgent), required: false);
            var __workflow_bodyreminderminutes = WorkflowExpression.Compile(bodyreminderminutes, nameof(bodyreminderminutes), required: false);
            var __workflow_bodycleared = WorkflowExpression.Compile(bodycleared, nameof(bodycleared), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/FollowUp/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytype != null)
                {
                    body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                    bodypropCount++;
                }

                if (__workflow_bodycomments != null)
                {
                    body["comments"] = ExpressionConverter.ConvertO(__workflow_bodycomments);
                    bodypropCount++;
                }

                if (__workflow_bodyassignedto != null)
                {
                    body["assignedto"] = ExpressionConverter.ConvertO(__workflow_bodyassignedto);
                    bodypropCount++;
                }

                if (__workflow_bodysetby != null)
                {
                    body["setby"] = ExpressionConverter.ConvertO(__workflow_bodysetby);
                    bodypropCount++;
                }

                if (__workflow_bodyduedate != null)
                {
                    body["duedate"] = ExpressionConverter.ConvertO(__workflow_bodyduedate);
                    bodypropCount++;
                }

                if (__workflow_bodyurgent != null)
                {
                    body["urgent"] = ExpressionConverter.ConvertO(__workflow_bodyurgent);
                    bodypropCount++;
                }

                if (__workflow_bodyreminderminutes != null)
                {
                    body["reminderminutes"] = ExpressionConverter.ConvertO(__workflow_bodyreminderminutes);
                    bodypropCount++;
                }

                if (__workflow_bodycleared != null)
                {
                    body["cleared"] = ExpressionConverter.ConvertO(__workflow_bodycleared);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
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
            var __workflow_bodymodelno = WorkflowExpression.Compile(bodymodelno, nameof(bodymodelno), required: false);
            var __workflow_bodydescrip = WorkflowExpression.Compile(bodydescrip, nameof(bodydescrip), required: false);
            var __workflow_bodyitemtype = WorkflowExpression.Compile(bodyitemtype, nameof(bodyitemtype), required: false);
            var __workflow_bodyprice = WorkflowExpression.Compile(bodyprice, nameof(bodyprice), required: false);
            var __workflow_bodycost = WorkflowExpression.Compile(bodycost, nameof(bodycost), required: false);
            var __workflow_bodyvendor = WorkflowExpression.Compile(bodyvendor, nameof(bodyvendor), required: false);
            return new DeferredBodyAction<ItemListPostValueResponse>(() =>
            {
                var apiCallPath = "/api/ItemList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodymodelno != null)
                {
                    body["modelno"] = ExpressionConverter.ConvertO(__workflow_bodymodelno);
                    bodypropCount++;
                }

                if (__workflow_bodydescrip != null)
                {
                    body["descrip"] = ExpressionConverter.ConvertO(__workflow_bodydescrip);
                    bodypropCount++;
                }

                if (__workflow_bodyitemtype != null)
                {
                    body["itemtype"] = ExpressionConverter.ConvertO(__workflow_bodyitemtype);
                    bodypropCount++;
                }

                if (__workflow_bodyprice != null)
                {
                    body["price"] = ExpressionConverter.ConvertO(__workflow_bodyprice);
                    bodypropCount++;
                }

                if (__workflow_bodycost != null)
                {
                    body["cost"] = ExpressionConverter.ConvertO(__workflow_bodycost);
                    bodypropCount++;
                }

                if (__workflow_bodyvendor != null)
                {
                    body["vendor"] = ExpressionConverter.ConvertO(__workflow_bodyvendor);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ItemListPostValueResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<ItemListGetValueResponse> ItemListGetValue(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ItemListGetValueResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/ItemList/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ItemListGetValueResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IWorkflowAction ItemListPutValue(Expression<Func<string>> id, Expression<Func<string>> bodydescrip = null, Expression<Func<double>> bodyprice = null, Expression<Func<double>> bodycost = null, Expression<Func<string>> bodyvendor = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodydescrip = WorkflowExpression.Compile(bodydescrip, nameof(bodydescrip), required: false);
            var __workflow_bodyprice = WorkflowExpression.Compile(bodyprice, nameof(bodyprice), required: false);
            var __workflow_bodycost = WorkflowExpression.Compile(bodycost, nameof(bodycost), required: false);
            var __workflow_bodyvendor = WorkflowExpression.Compile(bodyvendor, nameof(bodyvendor), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/ItemList/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodydescrip != null)
                {
                    body["descrip"] = ExpressionConverter.ConvertO(__workflow_bodydescrip);
                    bodypropCount++;
                }

                if (__workflow_bodyprice != null)
                {
                    body["price"] = ExpressionConverter.ConvertO(__workflow_bodyprice);
                    bodypropCount++;
                }

                if (__workflow_bodycost != null)
                {
                    body["cost"] = ExpressionConverter.ConvertO(__workflow_bodycost);
                    bodypropCount++;
                }

                if (__workflow_bodyvendor != null)
                {
                    body["vendor"] = ExpressionConverter.ConvertO(__workflow_bodyvendor);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
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
            var __workflow_bodysal = WorkflowExpression.Compile(bodysal, nameof(bodysal), required: false);
            var __workflow_bodyfirstname = WorkflowExpression.Compile(bodyfirstname, nameof(bodyfirstname), required: false);
            var __workflow_bodymiddlename = WorkflowExpression.Compile(bodymiddlename, nameof(bodymiddlename), required: false);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: false);
            var __workflow_bodylastname = WorkflowExpression.Compile(bodylastname, nameof(bodylastname), required: false);
            var __workflow_bodycompany = WorkflowExpression.Compile(bodycompany, nameof(bodycompany), required: false);
            var __workflow_bodyaddr1 = WorkflowExpression.Compile(bodyaddr1, nameof(bodyaddr1), required: false);
            var __workflow_bodyaddr2 = WorkflowExpression.Compile(bodyaddr2, nameof(bodyaddr2), required: false);
            var __workflow_bodycity = WorkflowExpression.Compile(bodycity, nameof(bodycity), required: false);
            var __workflow_bodystate = WorkflowExpression.Compile(bodystate, nameof(bodystate), required: false);
            var __workflow_bodypostal = WorkflowExpression.Compile(bodypostal, nameof(bodypostal), required: false);
            var __workflow_bodyemail1 = WorkflowExpression.Compile(bodyemail1, nameof(bodyemail1), required: false);
            var __workflow_bodyemail2 = WorkflowExpression.Compile(bodyemail2, nameof(bodyemail2), required: false);
            var __workflow_bodyemail3 = WorkflowExpression.Compile(bodyemail3, nameof(bodyemail3), required: false);
            var __workflow_bodyemail4 = WorkflowExpression.Compile(bodyemail4, nameof(bodyemail4), required: false);
            var __workflow_bodyphonetype1 = WorkflowExpression.Compile(bodyphonetype1, nameof(bodyphonetype1), required: false);
            var __workflow_bodyphone1 = WorkflowExpression.Compile(bodyphone1, nameof(bodyphone1), required: false);
            var __workflow_bodyphonetype2 = WorkflowExpression.Compile(bodyphonetype2, nameof(bodyphonetype2), required: false);
            var __workflow_bodyphone2 = WorkflowExpression.Compile(bodyphone2, nameof(bodyphone2), required: false);
            var __workflow_bodyphonetype3 = WorkflowExpression.Compile(bodyphonetype3, nameof(bodyphonetype3), required: false);
            var __workflow_bodyphone3 = WorkflowExpression.Compile(bodyphone3, nameof(bodyphone3), required: false);
            var __workflow_bodyphonetype4 = WorkflowExpression.Compile(bodyphonetype4, nameof(bodyphonetype4), required: false);
            var __workflow_bodyphone4 = WorkflowExpression.Compile(bodyphone4, nameof(bodyphone4), required: false);
            var __workflow_bodyremark = WorkflowExpression.Compile(bodyremark, nameof(bodyremark), required: false);
            var __workflow_bodynotes = WorkflowExpression.Compile(bodynotes, nameof(bodynotes), required: false);
            var __workflow_bodycampaign = WorkflowExpression.Compile(bodycampaign, nameof(bodycampaign), required: false);
            var __workflow_bodycategory = WorkflowExpression.Compile(bodycategory, nameof(bodycategory), required: false);
            var __workflow_bodyrole = WorkflowExpression.Compile(bodyrole, nameof(bodyrole), required: false);
            var __workflow_bodymarket = WorkflowExpression.Compile(bodymarket, nameof(bodymarket), required: false);
            var __workflow_bodyterritory = WorkflowExpression.Compile(bodyterritory, nameof(bodyterritory), required: false);
            var __workflow_bodysalesrep = WorkflowExpression.Compile(bodysalesrep, nameof(bodysalesrep), required: false);
            var __workflow_bodylastcontact = WorkflowExpression.Compile(bodylastcontact, nameof(bodylastcontact), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/api/Lead";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodysal != null)
                {
                    body["sal"] = ExpressionConverter.ConvertO(__workflow_bodysal);
                    bodypropCount++;
                }

                if (__workflow_bodyfirstname != null)
                {
                    body["firstname"] = ExpressionConverter.ConvertO(__workflow_bodyfirstname);
                    bodypropCount++;
                }

                if (__workflow_bodymiddlename != null)
                {
                    body["middlename"] = ExpressionConverter.ConvertO(__workflow_bodymiddlename);
                    bodypropCount++;
                }

                if (__workflow_bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (__workflow_bodylastname != null)
                {
                    body["lastname"] = ExpressionConverter.ConvertO(__workflow_bodylastname);
                    bodypropCount++;
                }

                if (__workflow_bodycompany != null)
                {
                    body["company"] = ExpressionConverter.ConvertO(__workflow_bodycompany);
                    bodypropCount++;
                }

                if (__workflow_bodyaddr1 != null)
                {
                    body["addr1"] = ExpressionConverter.ConvertO(__workflow_bodyaddr1);
                    bodypropCount++;
                }

                if (__workflow_bodyaddr2 != null)
                {
                    body["addr2"] = ExpressionConverter.ConvertO(__workflow_bodyaddr2);
                    bodypropCount++;
                }

                if (__workflow_bodycity != null)
                {
                    body["city"] = ExpressionConverter.ConvertO(__workflow_bodycity);
                    bodypropCount++;
                }

                if (__workflow_bodystate != null)
                {
                    body["state"] = ExpressionConverter.ConvertO(__workflow_bodystate);
                    bodypropCount++;
                }

                if (__workflow_bodypostal != null)
                {
                    body["postal"] = ExpressionConverter.ConvertO(__workflow_bodypostal);
                    bodypropCount++;
                }

                if (__workflow_bodyemail1 != null)
                {
                    body["email1"] = ExpressionConverter.ConvertO(__workflow_bodyemail1);
                    bodypropCount++;
                }

                if (__workflow_bodyemail2 != null)
                {
                    body["email2"] = ExpressionConverter.ConvertO(__workflow_bodyemail2);
                    bodypropCount++;
                }

                if (__workflow_bodyemail3 != null)
                {
                    body["email3"] = ExpressionConverter.ConvertO(__workflow_bodyemail3);
                    bodypropCount++;
                }

                if (__workflow_bodyemail4 != null)
                {
                    body["email4"] = ExpressionConverter.ConvertO(__workflow_bodyemail4);
                    bodypropCount++;
                }

                if (__workflow_bodyphonetype1 != null)
                {
                    body["phonetype1"] = ExpressionConverter.ConvertO(__workflow_bodyphonetype1);
                    bodypropCount++;
                }

                if (__workflow_bodyphone1 != null)
                {
                    body["phone1"] = ExpressionConverter.ConvertO(__workflow_bodyphone1);
                    bodypropCount++;
                }

                if (__workflow_bodyphonetype2 != null)
                {
                    body["phonetype2"] = ExpressionConverter.ConvertO(__workflow_bodyphonetype2);
                    bodypropCount++;
                }

                if (__workflow_bodyphone2 != null)
                {
                    body["phone2"] = ExpressionConverter.ConvertO(__workflow_bodyphone2);
                    bodypropCount++;
                }

                if (__workflow_bodyphonetype3 != null)
                {
                    body["phonetype3"] = ExpressionConverter.ConvertO(__workflow_bodyphonetype3);
                    bodypropCount++;
                }

                if (__workflow_bodyphone3 != null)
                {
                    body["phone3"] = ExpressionConverter.ConvertO(__workflow_bodyphone3);
                    bodypropCount++;
                }

                if (__workflow_bodyphonetype4 != null)
                {
                    body["phonetype4"] = ExpressionConverter.ConvertO(__workflow_bodyphonetype4);
                    bodypropCount++;
                }

                if (__workflow_bodyphone4 != null)
                {
                    body["phone4"] = ExpressionConverter.ConvertO(__workflow_bodyphone4);
                    bodypropCount++;
                }

                if (__workflow_bodyremark != null)
                {
                    body["remark"] = ExpressionConverter.ConvertO(__workflow_bodyremark);
                    bodypropCount++;
                }

                if (__workflow_bodynotes != null)
                {
                    body["notes"] = ExpressionConverter.ConvertO(__workflow_bodynotes);
                    bodypropCount++;
                }

                if (__workflow_bodycampaign != null)
                {
                    body["campaign"] = ExpressionConverter.ConvertO(__workflow_bodycampaign);
                    bodypropCount++;
                }

                if (__workflow_bodycategory != null)
                {
                    body["category"] = ExpressionConverter.ConvertO(__workflow_bodycategory);
                    bodypropCount++;
                }

                if (__workflow_bodyrole != null)
                {
                    body["role"] = ExpressionConverter.ConvertO(__workflow_bodyrole);
                    bodypropCount++;
                }

                if (__workflow_bodymarket != null)
                {
                    body["market"] = ExpressionConverter.ConvertO(__workflow_bodymarket);
                    bodypropCount++;
                }

                if (__workflow_bodyterritory != null)
                {
                    body["territory"] = ExpressionConverter.ConvertO(__workflow_bodyterritory);
                    bodypropCount++;
                }

                if (__workflow_bodysalesrep != null)
                {
                    body["salesrep"] = ExpressionConverter.ConvertO(__workflow_bodysalesrep);
                    bodypropCount++;
                }

                if (__workflow_bodylastcontact != null)
                {
                    body["lastcontact"] = ExpressionConverter.ConvertO(__workflow_bodylastcontact);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<LeadGetValueResponse> LeadGetValue(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<LeadGetValueResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/Lead/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<LeadGetValueResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<JToken> LeadPutValue(Expression<Func<string>> id, Expression<Func<string>> bodysal = null, Expression<Func<string>> bodyfirstname = null, Expression<Func<string>> bodymiddlename = null, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodylastname = null, Expression<Func<string>> bodycompany = null, Expression<Func<string>> bodyaddr1 = null, Expression<Func<string>> bodyaddr2 = null, Expression<Func<string>> bodycity = null, Expression<Func<string>> bodystate = null, Expression<Func<string>> bodypostal = null, Expression<Func<string>> bodyemail1 = null, Expression<Func<string>> bodyemail2 = null, Expression<Func<string>> bodyemail3 = null, Expression<Func<string>> bodyemail4 = null, Expression<Func<string>> bodyphonetype1 = null, Expression<Func<string>> bodyphone1 = null, Expression<Func<string>> bodyphonetype2 = null, Expression<Func<string>> bodyphone2 = null, Expression<Func<string>> bodyphonetype3 = null, Expression<Func<string>> bodyphone3 = null, Expression<Func<string>> bodyphonetype4 = null, Expression<Func<string>> bodyphone4 = null, Expression<Func<string>> bodyremark = null, Expression<Func<string>> bodynotes = null, Expression<Func<string>> bodycampaign = null, Expression<Func<string>> bodycategory = null, Expression<Func<string>> bodyrole = null, Expression<Func<string>> bodymarket = null, Expression<Func<string>> bodyterritory = null, Expression<Func<string>> bodysalesrep = null, Expression<Func<string>> bodylastcontact = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodysal = WorkflowExpression.Compile(bodysal, nameof(bodysal), required: false);
            var __workflow_bodyfirstname = WorkflowExpression.Compile(bodyfirstname, nameof(bodyfirstname), required: false);
            var __workflow_bodymiddlename = WorkflowExpression.Compile(bodymiddlename, nameof(bodymiddlename), required: false);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: false);
            var __workflow_bodylastname = WorkflowExpression.Compile(bodylastname, nameof(bodylastname), required: false);
            var __workflow_bodycompany = WorkflowExpression.Compile(bodycompany, nameof(bodycompany), required: false);
            var __workflow_bodyaddr1 = WorkflowExpression.Compile(bodyaddr1, nameof(bodyaddr1), required: false);
            var __workflow_bodyaddr2 = WorkflowExpression.Compile(bodyaddr2, nameof(bodyaddr2), required: false);
            var __workflow_bodycity = WorkflowExpression.Compile(bodycity, nameof(bodycity), required: false);
            var __workflow_bodystate = WorkflowExpression.Compile(bodystate, nameof(bodystate), required: false);
            var __workflow_bodypostal = WorkflowExpression.Compile(bodypostal, nameof(bodypostal), required: false);
            var __workflow_bodyemail1 = WorkflowExpression.Compile(bodyemail1, nameof(bodyemail1), required: false);
            var __workflow_bodyemail2 = WorkflowExpression.Compile(bodyemail2, nameof(bodyemail2), required: false);
            var __workflow_bodyemail3 = WorkflowExpression.Compile(bodyemail3, nameof(bodyemail3), required: false);
            var __workflow_bodyemail4 = WorkflowExpression.Compile(bodyemail4, nameof(bodyemail4), required: false);
            var __workflow_bodyphonetype1 = WorkflowExpression.Compile(bodyphonetype1, nameof(bodyphonetype1), required: false);
            var __workflow_bodyphone1 = WorkflowExpression.Compile(bodyphone1, nameof(bodyphone1), required: false);
            var __workflow_bodyphonetype2 = WorkflowExpression.Compile(bodyphonetype2, nameof(bodyphonetype2), required: false);
            var __workflow_bodyphone2 = WorkflowExpression.Compile(bodyphone2, nameof(bodyphone2), required: false);
            var __workflow_bodyphonetype3 = WorkflowExpression.Compile(bodyphonetype3, nameof(bodyphonetype3), required: false);
            var __workflow_bodyphone3 = WorkflowExpression.Compile(bodyphone3, nameof(bodyphone3), required: false);
            var __workflow_bodyphonetype4 = WorkflowExpression.Compile(bodyphonetype4, nameof(bodyphonetype4), required: false);
            var __workflow_bodyphone4 = WorkflowExpression.Compile(bodyphone4, nameof(bodyphone4), required: false);
            var __workflow_bodyremark = WorkflowExpression.Compile(bodyremark, nameof(bodyremark), required: false);
            var __workflow_bodynotes = WorkflowExpression.Compile(bodynotes, nameof(bodynotes), required: false);
            var __workflow_bodycampaign = WorkflowExpression.Compile(bodycampaign, nameof(bodycampaign), required: false);
            var __workflow_bodycategory = WorkflowExpression.Compile(bodycategory, nameof(bodycategory), required: false);
            var __workflow_bodyrole = WorkflowExpression.Compile(bodyrole, nameof(bodyrole), required: false);
            var __workflow_bodymarket = WorkflowExpression.Compile(bodymarket, nameof(bodymarket), required: false);
            var __workflow_bodyterritory = WorkflowExpression.Compile(bodyterritory, nameof(bodyterritory), required: false);
            var __workflow_bodysalesrep = WorkflowExpression.Compile(bodysalesrep, nameof(bodysalesrep), required: false);
            var __workflow_bodylastcontact = WorkflowExpression.Compile(bodylastcontact, nameof(bodylastcontact), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/Lead/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodysal != null)
                {
                    body["sal"] = ExpressionConverter.ConvertO(__workflow_bodysal);
                    bodypropCount++;
                }

                if (__workflow_bodyfirstname != null)
                {
                    body["firstname"] = ExpressionConverter.ConvertO(__workflow_bodyfirstname);
                    bodypropCount++;
                }

                if (__workflow_bodymiddlename != null)
                {
                    body["middlename"] = ExpressionConverter.ConvertO(__workflow_bodymiddlename);
                    bodypropCount++;
                }

                if (__workflow_bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (__workflow_bodylastname != null)
                {
                    body["lastname"] = ExpressionConverter.ConvertO(__workflow_bodylastname);
                    bodypropCount++;
                }

                if (__workflow_bodycompany != null)
                {
                    body["company"] = ExpressionConverter.ConvertO(__workflow_bodycompany);
                    bodypropCount++;
                }

                if (__workflow_bodyaddr1 != null)
                {
                    body["addr1"] = ExpressionConverter.ConvertO(__workflow_bodyaddr1);
                    bodypropCount++;
                }

                if (__workflow_bodyaddr2 != null)
                {
                    body["addr2"] = ExpressionConverter.ConvertO(__workflow_bodyaddr2);
                    bodypropCount++;
                }

                if (__workflow_bodycity != null)
                {
                    body["city"] = ExpressionConverter.ConvertO(__workflow_bodycity);
                    bodypropCount++;
                }

                if (__workflow_bodystate != null)
                {
                    body["state"] = ExpressionConverter.ConvertO(__workflow_bodystate);
                    bodypropCount++;
                }

                if (__workflow_bodypostal != null)
                {
                    body["postal"] = ExpressionConverter.ConvertO(__workflow_bodypostal);
                    bodypropCount++;
                }

                if (__workflow_bodyemail1 != null)
                {
                    body["email1"] = ExpressionConverter.ConvertO(__workflow_bodyemail1);
                    bodypropCount++;
                }

                if (__workflow_bodyemail2 != null)
                {
                    body["email2"] = ExpressionConverter.ConvertO(__workflow_bodyemail2);
                    bodypropCount++;
                }

                if (__workflow_bodyemail3 != null)
                {
                    body["email3"] = ExpressionConverter.ConvertO(__workflow_bodyemail3);
                    bodypropCount++;
                }

                if (__workflow_bodyemail4 != null)
                {
                    body["email4"] = ExpressionConverter.ConvertO(__workflow_bodyemail4);
                    bodypropCount++;
                }

                if (__workflow_bodyphonetype1 != null)
                {
                    body["phonetype1"] = ExpressionConverter.ConvertO(__workflow_bodyphonetype1);
                    bodypropCount++;
                }

                if (__workflow_bodyphone1 != null)
                {
                    body["phone1"] = ExpressionConverter.ConvertO(__workflow_bodyphone1);
                    bodypropCount++;
                }

                if (__workflow_bodyphonetype2 != null)
                {
                    body["phonetype2"] = ExpressionConverter.ConvertO(__workflow_bodyphonetype2);
                    bodypropCount++;
                }

                if (__workflow_bodyphone2 != null)
                {
                    body["phone2"] = ExpressionConverter.ConvertO(__workflow_bodyphone2);
                    bodypropCount++;
                }

                if (__workflow_bodyphonetype3 != null)
                {
                    body["phonetype3"] = ExpressionConverter.ConvertO(__workflow_bodyphonetype3);
                    bodypropCount++;
                }

                if (__workflow_bodyphone3 != null)
                {
                    body["phone3"] = ExpressionConverter.ConvertO(__workflow_bodyphone3);
                    bodypropCount++;
                }

                if (__workflow_bodyphonetype4 != null)
                {
                    body["phonetype4"] = ExpressionConverter.ConvertO(__workflow_bodyphonetype4);
                    bodypropCount++;
                }

                if (__workflow_bodyphone4 != null)
                {
                    body["phone4"] = ExpressionConverter.ConvertO(__workflow_bodyphone4);
                    bodypropCount++;
                }

                if (__workflow_bodyremark != null)
                {
                    body["remark"] = ExpressionConverter.ConvertO(__workflow_bodyremark);
                    bodypropCount++;
                }

                if (__workflow_bodynotes != null)
                {
                    body["notes"] = ExpressionConverter.ConvertO(__workflow_bodynotes);
                    bodypropCount++;
                }

                if (__workflow_bodycampaign != null)
                {
                    body["campaign"] = ExpressionConverter.ConvertO(__workflow_bodycampaign);
                    bodypropCount++;
                }

                if (__workflow_bodycategory != null)
                {
                    body["category"] = ExpressionConverter.ConvertO(__workflow_bodycategory);
                    bodypropCount++;
                }

                if (__workflow_bodyrole != null)
                {
                    body["role"] = ExpressionConverter.ConvertO(__workflow_bodyrole);
                    bodypropCount++;
                }

                if (__workflow_bodymarket != null)
                {
                    body["market"] = ExpressionConverter.ConvertO(__workflow_bodymarket);
                    bodypropCount++;
                }

                if (__workflow_bodyterritory != null)
                {
                    body["territory"] = ExpressionConverter.ConvertO(__workflow_bodyterritory);
                    bodypropCount++;
                }

                if (__workflow_bodysalesrep != null)
                {
                    body["salesrep"] = ExpressionConverter.ConvertO(__workflow_bodysalesrep);
                    bodypropCount++;
                }

                if (__workflow_bodylastcontact != null)
                {
                    body["lastcontact"] = ExpressionConverter.ConvertO(__workflow_bodylastcontact);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<string[]> MembersGetValues(Expression<Func<typeInput>> type)
        {
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: true);
            return new DeferredBodyAction<string[]>(() =>
            {
                var apiCallPath = "/api/Members";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["type"] = ExpressionConverter.Convert(__workflow_type);
                return new ApiConnectionAction<string[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<JToken> MembersPostValue(Expression<Func<string>> bodypromoid = null, Expression<Func<bodyrecordtypeInput>> bodyrecordtype = null, Expression<Func<string>> bodyrecordid = null)
        {
            var __workflow_bodypromoid = WorkflowExpression.Compile(bodypromoid, nameof(bodypromoid), required: false);
            var __workflow_bodyrecordtype = WorkflowExpression.Compile(bodyrecordtype, nameof(bodyrecordtype), required: false);
            var __workflow_bodyrecordid = WorkflowExpression.Compile(bodyrecordid, nameof(bodyrecordid), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/api/Members";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodypromoid != null)
                {
                    body["promoid"] = ExpressionConverter.ConvertO(__workflow_bodypromoid);
                    bodypropCount++;
                }

                if (__workflow_bodyrecordtype != null)
                {
                    body["recordtype"] = ExpressionConverter.ConvertO(__workflow_bodyrecordtype);
                    bodypropCount++;
                }

                if (__workflow_bodyrecordid != null)
                {
                    body["recordid"] = ExpressionConverter.ConvertO(__workflow_bodyrecordid);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<MembersGetValueResponse> MembersGetValue(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<MembersGetValueResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/Members/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<MembersGetValueResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<JToken> MembersPutValue(Expression<Func<string>> id, Expression<Func<bodyoperationInput>> bodyoperation = null, Expression<Func<bodyrecordtypeInput>> bodyrecordtype = null, Expression<Func<string>> bodypromoid = null, Expression<Func<string>> bodyrecordid = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodyoperation = WorkflowExpression.Compile(bodyoperation, nameof(bodyoperation), required: false);
            var __workflow_bodyrecordtype = WorkflowExpression.Compile(bodyrecordtype, nameof(bodyrecordtype), required: false);
            var __workflow_bodypromoid = WorkflowExpression.Compile(bodypromoid, nameof(bodypromoid), required: false);
            var __workflow_bodyrecordid = WorkflowExpression.Compile(bodyrecordid, nameof(bodyrecordid), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/Members/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyoperation != null)
                {
                    body["operation"] = ExpressionConverter.ConvertO(__workflow_bodyoperation);
                    bodypropCount++;
                }

                if (__workflow_bodyrecordtype != null)
                {
                    body["recordtype"] = ExpressionConverter.ConvertO(__workflow_bodyrecordtype);
                    bodypropCount++;
                }

                if (__workflow_bodypromoid != null)
                {
                    body["promoid"] = ExpressionConverter.ConvertO(__workflow_bodypromoid);
                    bodypropCount++;
                }

                if (__workflow_bodyrecordid != null)
                {
                    body["recordid"] = ExpressionConverter.ConvertO(__workflow_bodyrecordid);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
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
            var __workflow_bodyorderid = WorkflowExpression.Compile(bodyorderid, nameof(bodyorderid), required: false);
            var __workflow_bodyshipdate = WorkflowExpression.Compile(bodyshipdate, nameof(bodyshipdate), required: false);
            var __workflow_bodycarrier = WorkflowExpression.Compile(bodycarrier, nameof(bodycarrier), required: false);
            var __workflow_bodymethod = WorkflowExpression.Compile(bodymethod, nameof(bodymethod), required: false);
            var __workflow_bodyweight = WorkflowExpression.Compile(bodyweight, nameof(bodyweight), required: false);
            var __workflow_bodypackagetype = WorkflowExpression.Compile(bodypackagetype, nameof(bodypackagetype), required: false);
            var __workflow_bodyreference1 = WorkflowExpression.Compile(bodyreference1, nameof(bodyreference1), required: false);
            var __workflow_bodyreference2 = WorkflowExpression.Compile(bodyreference2, nameof(bodyreference2), required: false);
            var __workflow_bodytrackingnumber = WorkflowExpression.Compile(bodytrackingnumber, nameof(bodytrackingnumber), required: false);
            var __workflow_bodytrackingurl = WorkflowExpression.Compile(bodytrackingurl, nameof(bodytrackingurl), required: false);
            var __workflow_bodyshippingcost = WorkflowExpression.Compile(bodyshippingcost, nameof(bodyshippingcost), required: false);
            var __workflow_bodytohistory = WorkflowExpression.Compile(bodytohistory, nameof(bodytohistory), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/api/Shipping";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyorderid != null)
                {
                    body["orderid"] = ExpressionConverter.ConvertO(__workflow_bodyorderid);
                    bodypropCount++;
                }

                if (__workflow_bodyshipdate != null)
                {
                    body["shipdate"] = ExpressionConverter.ConvertO(__workflow_bodyshipdate);
                    bodypropCount++;
                }

                if (__workflow_bodycarrier != null)
                {
                    body["carrier"] = ExpressionConverter.ConvertO(__workflow_bodycarrier);
                    bodypropCount++;
                }

                if (__workflow_bodymethod != null)
                {
                    body["method"] = ExpressionConverter.ConvertO(__workflow_bodymethod);
                    bodypropCount++;
                }

                if (__workflow_bodyweight != null)
                {
                    body["weight"] = ExpressionConverter.ConvertO(__workflow_bodyweight);
                    bodypropCount++;
                }

                if (__workflow_bodypackagetype != null)
                {
                    body["packagetype"] = ExpressionConverter.ConvertO(__workflow_bodypackagetype);
                    bodypropCount++;
                }

                if (__workflow_bodyreference1 != null)
                {
                    body["reference1"] = ExpressionConverter.ConvertO(__workflow_bodyreference1);
                    bodypropCount++;
                }

                if (__workflow_bodyreference2 != null)
                {
                    body["reference2"] = ExpressionConverter.ConvertO(__workflow_bodyreference2);
                    bodypropCount++;
                }

                if (__workflow_bodytrackingnumber != null)
                {
                    body["trackingnumber"] = ExpressionConverter.ConvertO(__workflow_bodytrackingnumber);
                    bodypropCount++;
                }

                if (__workflow_bodytrackingurl != null)
                {
                    body["trackingurl"] = ExpressionConverter.ConvertO(__workflow_bodytrackingurl);
                    bodypropCount++;
                }

                if (__workflow_bodyshippingcost != null)
                {
                    body["shippingcost"] = ExpressionConverter.ConvertO(__workflow_bodyshippingcost);
                    bodypropCount++;
                }

                if (__workflow_bodytohistory != null)
                {
                    body["tohistory"] = ExpressionConverter.ConvertO(__workflow_bodytohistory);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<ShippingGetValueResponse> ShippingGetValue(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ShippingGetValueResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/Shipping/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ShippingGetValueResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IWorkflowAction ShippingPutValue(Expression<Func<string>> id, Expression<Func<string>> bodyshipdate = null, Expression<Func<string>> bodycarrier = null, Expression<Func<string>> bodymethod = null, Expression<Func<double>> bodyweight = null, Expression<Func<string>> bodypackagetype = null, Expression<Func<string>> bodyreference1 = null, Expression<Func<string>> bodyreference2 = null, Expression<Func<string>> bodytrackingnumber = null, Expression<Func<string>> bodytrackingurl = null, Expression<Func<double>> bodyshippingcost = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodyshipdate = WorkflowExpression.Compile(bodyshipdate, nameof(bodyshipdate), required: false);
            var __workflow_bodycarrier = WorkflowExpression.Compile(bodycarrier, nameof(bodycarrier), required: false);
            var __workflow_bodymethod = WorkflowExpression.Compile(bodymethod, nameof(bodymethod), required: false);
            var __workflow_bodyweight = WorkflowExpression.Compile(bodyweight, nameof(bodyweight), required: false);
            var __workflow_bodypackagetype = WorkflowExpression.Compile(bodypackagetype, nameof(bodypackagetype), required: false);
            var __workflow_bodyreference1 = WorkflowExpression.Compile(bodyreference1, nameof(bodyreference1), required: false);
            var __workflow_bodyreference2 = WorkflowExpression.Compile(bodyreference2, nameof(bodyreference2), required: false);
            var __workflow_bodytrackingnumber = WorkflowExpression.Compile(bodytrackingnumber, nameof(bodytrackingnumber), required: false);
            var __workflow_bodytrackingurl = WorkflowExpression.Compile(bodytrackingurl, nameof(bodytrackingurl), required: false);
            var __workflow_bodyshippingcost = WorkflowExpression.Compile(bodyshippingcost, nameof(bodyshippingcost), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/Shipping/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyshipdate != null)
                {
                    body["shipdate"] = ExpressionConverter.ConvertO(__workflow_bodyshipdate);
                    bodypropCount++;
                }

                if (__workflow_bodycarrier != null)
                {
                    body["carrier"] = ExpressionConverter.ConvertO(__workflow_bodycarrier);
                    bodypropCount++;
                }

                if (__workflow_bodymethod != null)
                {
                    body["method"] = ExpressionConverter.ConvertO(__workflow_bodymethod);
                    bodypropCount++;
                }

                if (__workflow_bodyweight != null)
                {
                    body["weight"] = ExpressionConverter.ConvertO(__workflow_bodyweight);
                    bodypropCount++;
                }

                if (__workflow_bodypackagetype != null)
                {
                    body["packagetype"] = ExpressionConverter.ConvertO(__workflow_bodypackagetype);
                    bodypropCount++;
                }

                if (__workflow_bodyreference1 != null)
                {
                    body["reference1"] = ExpressionConverter.ConvertO(__workflow_bodyreference1);
                    bodypropCount++;
                }

                if (__workflow_bodyreference2 != null)
                {
                    body["reference2"] = ExpressionConverter.ConvertO(__workflow_bodyreference2);
                    bodypropCount++;
                }

                if (__workflow_bodytrackingnumber != null)
                {
                    body["trackingnumber"] = ExpressionConverter.ConvertO(__workflow_bodytrackingnumber);
                    bodypropCount++;
                }

                if (__workflow_bodytrackingurl != null)
                {
                    body["trackingurl"] = ExpressionConverter.ConvertO(__workflow_bodytrackingurl);
                    bodypropCount++;
                }

                if (__workflow_bodyshippingcost != null)
                {
                    body["shippingcost"] = ExpressionConverter.ConvertO(__workflow_bodyshippingcost);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
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
            var __workflow_bodyorderid = WorkflowExpression.Compile(bodyorderid, nameof(bodyorderid), required: false);
            var __workflow_bodyorderdate = WorkflowExpression.Compile(bodyorderdate, nameof(bodyorderdate), required: false);
            var __workflow_bodyorderdescription = WorkflowExpression.Compile(bodyorderdescription, nameof(bodyorderdescription), required: false);
            var __workflow_bodyaccount = WorkflowExpression.Compile(bodyaccount, nameof(bodyaccount), required: false);
            var __workflow_bodyaccountname = WorkflowExpression.Compile(bodyaccountname, nameof(bodyaccountname), required: false);
            var __workflow_bodysalesrep = WorkflowExpression.Compile(bodysalesrep, nameof(bodysalesrep), required: false);
            var __workflow_bodyfirstname = WorkflowExpression.Compile(bodyfirstname, nameof(bodyfirstname), required: false);
            var __workflow_bodylastname = WorkflowExpression.Compile(bodylastname, nameof(bodylastname), required: false);
            var __workflow_bodybillemail = WorkflowExpression.Compile(bodybillemail, nameof(bodybillemail), required: false);
            var __workflow_bodybilladdr1 = WorkflowExpression.Compile(bodybilladdr1, nameof(bodybilladdr1), required: false);
            var __workflow_bodybilladdr2 = WorkflowExpression.Compile(bodybilladdr2, nameof(bodybilladdr2), required: false);
            var __workflow_bodybillcity = WorkflowExpression.Compile(bodybillcity, nameof(bodybillcity), required: false);
            var __workflow_bodybillstate = WorkflowExpression.Compile(bodybillstate, nameof(bodybillstate), required: false);
            var __workflow_bodybillzipcode = WorkflowExpression.Compile(bodybillzipcode, nameof(bodybillzipcode), required: false);
            var __workflow_bodybillcountry = WorkflowExpression.Compile(bodybillcountry, nameof(bodybillcountry), required: false);
            var __workflow_bodybillphone = WorkflowExpression.Compile(bodybillphone, nameof(bodybillphone), required: false);
            var __workflow_bodybillfax = WorkflowExpression.Compile(bodybillfax, nameof(bodybillfax), required: false);
            var __workflow_bodyshipcompany = WorkflowExpression.Compile(bodyshipcompany, nameof(bodyshipcompany), required: false);
            var __workflow_bodyshipcontact = WorkflowExpression.Compile(bodyshipcontact, nameof(bodyshipcontact), required: false);
            var __workflow_bodyshipaddr1 = WorkflowExpression.Compile(bodyshipaddr1, nameof(bodyshipaddr1), required: false);
            var __workflow_bodyshipaddr2 = WorkflowExpression.Compile(bodyshipaddr2, nameof(bodyshipaddr2), required: false);
            var __workflow_bodyshipcity = WorkflowExpression.Compile(bodyshipcity, nameof(bodyshipcity), required: false);
            var __workflow_bodyshipstate = WorkflowExpression.Compile(bodyshipstate, nameof(bodyshipstate), required: false);
            var __workflow_bodyshipzipcode = WorkflowExpression.Compile(bodyshipzipcode, nameof(bodyshipzipcode), required: false);
            var __workflow_bodyshipcountry = WorkflowExpression.Compile(bodyshipcountry, nameof(bodyshipcountry), required: false);
            var __workflow_bodyshipphone = WorkflowExpression.Compile(bodyshipphone, nameof(bodyshipphone), required: false);
            var __workflow_bodyshipemail = WorkflowExpression.Compile(bodyshipemail, nameof(bodyshipemail), required: false);
            var __workflow_bodyorderstatus = WorkflowExpression.Compile(bodyorderstatus, nameof(bodyorderstatus), required: false);
            var __workflow_bodycustomstatus = WorkflowExpression.Compile(bodycustomstatus, nameof(bodycustomstatus), required: false);
            var __workflow_bodytaxdistrict = WorkflowExpression.Compile(bodytaxdistrict, nameof(bodytaxdistrict), required: false);
            var __workflow_bodytaxrate = WorkflowExpression.Compile(bodytaxrate, nameof(bodytaxrate), required: false);
            var __workflow_bodycampaign = WorkflowExpression.Compile(bodycampaign, nameof(bodycampaign), required: false);
            var __workflow_bodyordertax = WorkflowExpression.Compile(bodyordertax, nameof(bodyordertax), required: false);
            var __workflow_bodyshippingcost = WorkflowExpression.Compile(bodyshippingcost, nameof(bodyshippingcost), required: false);
            var __workflow_bodyshippingmethod = WorkflowExpression.Compile(bodyshippingmethod, nameof(bodyshippingmethod), required: false);
            var __workflow_bodycouponamount = WorkflowExpression.Compile(bodycouponamount, nameof(bodycouponamount), required: false);
            var __workflow_bodycouponcode = WorkflowExpression.Compile(bodycouponcode, nameof(bodycouponcode), required: false);
            var __workflow_bodypaymentmethod = WorkflowExpression.Compile(bodypaymentmethod, nameof(bodypaymentmethod), required: false);
            var __workflow_bodycomments = WorkflowExpression.Compile(bodycomments, nameof(bodycomments), required: false);
            var __workflow_bodylinedata = WorkflowExpression.Compile(bodylinedata, nameof(bodylinedata), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/api/SO";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyorderid != null)
                {
                    body["orderid"] = ExpressionConverter.ConvertO(__workflow_bodyorderid);
                    bodypropCount++;
                }

                if (__workflow_bodyorderdate != null)
                {
                    body["orderdate"] = ExpressionConverter.ConvertO(__workflow_bodyorderdate);
                    bodypropCount++;
                }

                if (__workflow_bodyorderdescription != null)
                {
                    body["orderdescription"] = ExpressionConverter.ConvertO(__workflow_bodyorderdescription);
                    bodypropCount++;
                }

                if (__workflow_bodyaccount != null)
                {
                    body["account"] = ExpressionConverter.ConvertO(__workflow_bodyaccount);
                    bodypropCount++;
                }

                if (__workflow_bodyaccountname != null)
                {
                    body["accountname"] = ExpressionConverter.ConvertO(__workflow_bodyaccountname);
                    bodypropCount++;
                }

                if (__workflow_bodysalesrep != null)
                {
                    body["salesrep"] = ExpressionConverter.ConvertO(__workflow_bodysalesrep);
                    bodypropCount++;
                }

                if (__workflow_bodyfirstname != null)
                {
                    body["firstname"] = ExpressionConverter.ConvertO(__workflow_bodyfirstname);
                    bodypropCount++;
                }

                if (__workflow_bodylastname != null)
                {
                    body["lastname"] = ExpressionConverter.ConvertO(__workflow_bodylastname);
                    bodypropCount++;
                }

                if (__workflow_bodybillemail != null)
                {
                    body["billemail"] = ExpressionConverter.ConvertO(__workflow_bodybillemail);
                    bodypropCount++;
                }

                if (__workflow_bodybilladdr1 != null)
                {
                    body["billaddr1"] = ExpressionConverter.ConvertO(__workflow_bodybilladdr1);
                    bodypropCount++;
                }

                if (__workflow_bodybilladdr2 != null)
                {
                    body["billaddr2"] = ExpressionConverter.ConvertO(__workflow_bodybilladdr2);
                    bodypropCount++;
                }

                if (__workflow_bodybillcity != null)
                {
                    body["billcity"] = ExpressionConverter.ConvertO(__workflow_bodybillcity);
                    bodypropCount++;
                }

                if (__workflow_bodybillstate != null)
                {
                    body["billstate"] = ExpressionConverter.ConvertO(__workflow_bodybillstate);
                    bodypropCount++;
                }

                if (__workflow_bodybillzipcode != null)
                {
                    body["billzipcode"] = ExpressionConverter.ConvertO(__workflow_bodybillzipcode);
                    bodypropCount++;
                }

                if (__workflow_bodybillcountry != null)
                {
                    body["billcountry"] = ExpressionConverter.ConvertO(__workflow_bodybillcountry);
                    bodypropCount++;
                }

                if (__workflow_bodybillphone != null)
                {
                    body["billphone"] = ExpressionConverter.ConvertO(__workflow_bodybillphone);
                    bodypropCount++;
                }

                if (__workflow_bodybillfax != null)
                {
                    body["billfax"] = ExpressionConverter.ConvertO(__workflow_bodybillfax);
                    bodypropCount++;
                }

                if (__workflow_bodyshipcompany != null)
                {
                    body["shipcompany"] = ExpressionConverter.ConvertO(__workflow_bodyshipcompany);
                    bodypropCount++;
                }

                if (__workflow_bodyshipcontact != null)
                {
                    body["shipcontact"] = ExpressionConverter.ConvertO(__workflow_bodyshipcontact);
                    bodypropCount++;
                }

                if (__workflow_bodyshipaddr1 != null)
                {
                    body["shipaddr1"] = ExpressionConverter.ConvertO(__workflow_bodyshipaddr1);
                    bodypropCount++;
                }

                if (__workflow_bodyshipaddr2 != null)
                {
                    body["shipaddr2"] = ExpressionConverter.ConvertO(__workflow_bodyshipaddr2);
                    bodypropCount++;
                }

                if (__workflow_bodyshipcity != null)
                {
                    body["shipcity"] = ExpressionConverter.ConvertO(__workflow_bodyshipcity);
                    bodypropCount++;
                }

                if (__workflow_bodyshipstate != null)
                {
                    body["shipstate"] = ExpressionConverter.ConvertO(__workflow_bodyshipstate);
                    bodypropCount++;
                }

                if (__workflow_bodyshipzipcode != null)
                {
                    body["shipzipcode"] = ExpressionConverter.ConvertO(__workflow_bodyshipzipcode);
                    bodypropCount++;
                }

                if (__workflow_bodyshipcountry != null)
                {
                    body["shipcountry"] = ExpressionConverter.ConvertO(__workflow_bodyshipcountry);
                    bodypropCount++;
                }

                if (__workflow_bodyshipphone != null)
                {
                    body["shipphone"] = ExpressionConverter.ConvertO(__workflow_bodyshipphone);
                    bodypropCount++;
                }

                if (__workflow_bodyshipemail != null)
                {
                    body["shipemail"] = ExpressionConverter.ConvertO(__workflow_bodyshipemail);
                    bodypropCount++;
                }

                if (__workflow_bodyorderstatus != null)
                {
                    body["orderstatus"] = ExpressionConverter.ConvertO(__workflow_bodyorderstatus);
                    bodypropCount++;
                }

                if (__workflow_bodycustomstatus != null)
                {
                    body["customstatus"] = ExpressionConverter.ConvertO(__workflow_bodycustomstatus);
                    bodypropCount++;
                }

                if (__workflow_bodytaxdistrict != null)
                {
                    body["taxdistrict"] = ExpressionConverter.ConvertO(__workflow_bodytaxdistrict);
                    bodypropCount++;
                }

                if (__workflow_bodytaxrate != null)
                {
                    body["taxrate"] = ExpressionConverter.ConvertO(__workflow_bodytaxrate);
                    bodypropCount++;
                }

                if (__workflow_bodycampaign != null)
                {
                    body["campaign"] = ExpressionConverter.ConvertO(__workflow_bodycampaign);
                    bodypropCount++;
                }

                if (__workflow_bodyordertax != null)
                {
                    body["ordertax"] = ExpressionConverter.ConvertO(__workflow_bodyordertax);
                    bodypropCount++;
                }

                if (__workflow_bodyshippingcost != null)
                {
                    body["shippingcost"] = ExpressionConverter.ConvertO(__workflow_bodyshippingcost);
                    bodypropCount++;
                }

                if (__workflow_bodyshippingmethod != null)
                {
                    body["shippingmethod"] = ExpressionConverter.ConvertO(__workflow_bodyshippingmethod);
                    bodypropCount++;
                }

                if (__workflow_bodycouponamount != null)
                {
                    body["couponamount"] = ExpressionConverter.ConvertO(__workflow_bodycouponamount);
                    bodypropCount++;
                }

                if (__workflow_bodycouponcode != null)
                {
                    body["couponcode"] = ExpressionConverter.ConvertO(__workflow_bodycouponcode);
                    bodypropCount++;
                }

                if (__workflow_bodypaymentmethod != null)
                {
                    body["paymentmethod"] = ExpressionConverter.ConvertO(__workflow_bodypaymentmethod);
                    bodypropCount++;
                }

                if (__workflow_bodycomments != null)
                {
                    body["comments"] = ExpressionConverter.ConvertO(__workflow_bodycomments);
                    bodypropCount++;
                }

                if (__workflow_bodylinedata != null)
                {
                    body["linedata"] = ExpressionConverter.ConvertO(__workflow_bodylinedata);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<SOGetValueResponse> SOGetValue(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<SOGetValueResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/SO/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SOGetValueResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IWorkflowAction SOPutValue(Expression<Func<string>> id, Expression<Func<string>> bodycomments = null, Expression<Func<string>> bodycustomstatus = null, Expression<Func<bodyorderstatusInput>> bodyorderstatus = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodycomments = WorkflowExpression.Compile(bodycomments, nameof(bodycomments), required: false);
            var __workflow_bodycustomstatus = WorkflowExpression.Compile(bodycustomstatus, nameof(bodycustomstatus), required: false);
            var __workflow_bodyorderstatus = WorkflowExpression.Compile(bodyorderstatus, nameof(bodyorderstatus), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/SO/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodycomments != null)
                {
                    body["comments"] = ExpressionConverter.ConvertO(__workflow_bodycomments);
                    bodypropCount++;
                }

                if (__workflow_bodycustomstatus != null)
                {
                    body["customstatus"] = ExpressionConverter.ConvertO(__workflow_bodycustomstatus);
                    bodypropCount++;
                }

                if (__workflow_bodyorderstatus != null)
                {
                    body["orderstatus"] = ExpressionConverter.ConvertO(__workflow_bodyorderstatus);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
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
            var __workflow_bodyfromaddress = WorkflowExpression.Compile(bodyfromaddress, nameof(bodyfromaddress), required: false);
            var __workflow_bodyfirstname = WorkflowExpression.Compile(bodyfirstname, nameof(bodyfirstname), required: false);
            var __workflow_bodylastname = WorkflowExpression.Compile(bodylastname, nameof(bodylastname), required: false);
            var __workflow_bodycompanyname = WorkflowExpression.Compile(bodycompanyname, nameof(bodycompanyname), required: false);
            var __workflow_bodybilladdr1 = WorkflowExpression.Compile(bodybilladdr1, nameof(bodybilladdr1), required: false);
            var __workflow_bodybilladdr2 = WorkflowExpression.Compile(bodybilladdr2, nameof(bodybilladdr2), required: false);
            var __workflow_bodybillcity = WorkflowExpression.Compile(bodybillcity, nameof(bodybillcity), required: false);
            var __workflow_bodybillstate = WorkflowExpression.Compile(bodybillstate, nameof(bodybillstate), required: false);
            var __workflow_bodybillzipcode = WorkflowExpression.Compile(bodybillzipcode, nameof(bodybillzipcode), required: false);
            var __workflow_bodybillcountry = WorkflowExpression.Compile(bodybillcountry, nameof(bodybillcountry), required: false);
            var __workflow_bodybillphone = WorkflowExpression.Compile(bodybillphone, nameof(bodybillphone), required: false);
            var __workflow_bodybillfax = WorkflowExpression.Compile(bodybillfax, nameof(bodybillfax), required: false);
            var __workflow_bodyserviceaddr1 = WorkflowExpression.Compile(bodyserviceaddr1, nameof(bodyserviceaddr1), required: false);
            var __workflow_bodyserviceaddr2 = WorkflowExpression.Compile(bodyserviceaddr2, nameof(bodyserviceaddr2), required: false);
            var __workflow_bodyservicecity = WorkflowExpression.Compile(bodyservicecity, nameof(bodyservicecity), required: false);
            var __workflow_bodyservicestate = WorkflowExpression.Compile(bodyservicestate, nameof(bodyservicestate), required: false);
            var __workflow_bodyservicezipcode = WorkflowExpression.Compile(bodyservicezipcode, nameof(bodyservicezipcode), required: false);
            var __workflow_bodyservicecountry = WorkflowExpression.Compile(bodyservicecountry, nameof(bodyservicecountry), required: false);
            var __workflow_bodyservicephone = WorkflowExpression.Compile(bodyservicephone, nameof(bodyservicephone), required: false);
            var __workflow_bodyreceiveddate = WorkflowExpression.Compile(bodyreceiveddate, nameof(bodyreceiveddate), required: false);
            var __workflow_bodyponumber = WorkflowExpression.Compile(bodyponumber, nameof(bodyponumber), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodyreasoncode = WorkflowExpression.Compile(bodyreasoncode, nameof(bodyreasoncode), required: false);
            var __workflow_bodysource = WorkflowExpression.Compile(bodysource, nameof(bodysource), required: false);
            var __workflow_bodyassignedto = WorkflowExpression.Compile(bodyassignedto, nameof(bodyassignedto), required: false);
            var __workflow_bodybackup = WorkflowExpression.Compile(bodybackup, nameof(bodybackup), required: false);
            var __workflow_bodypriority = WorkflowExpression.Compile(bodypriority, nameof(bodypriority), required: false);
            var __workflow_bodyduedate = WorkflowExpression.Compile(bodyduedate, nameof(bodyduedate), required: false);
            var __workflow_bodysubject = WorkflowExpression.Compile(bodysubject, nameof(bodysubject), required: false);
            var __workflow_bodybody = WorkflowExpression.Compile(bodybody, nameof(bodybody), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/api/WorkOrder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfromaddress != null)
                {
                    body["fromaddress"] = ExpressionConverter.ConvertO(__workflow_bodyfromaddress);
                    bodypropCount++;
                }

                if (__workflow_bodyfirstname != null)
                {
                    body["firstname"] = ExpressionConverter.ConvertO(__workflow_bodyfirstname);
                    bodypropCount++;
                }

                if (__workflow_bodylastname != null)
                {
                    body["lastname"] = ExpressionConverter.ConvertO(__workflow_bodylastname);
                    bodypropCount++;
                }

                if (__workflow_bodycompanyname != null)
                {
                    body["companyname"] = ExpressionConverter.ConvertO(__workflow_bodycompanyname);
                    bodypropCount++;
                }

                if (__workflow_bodybilladdr1 != null)
                {
                    body["billaddr1"] = ExpressionConverter.ConvertO(__workflow_bodybilladdr1);
                    bodypropCount++;
                }

                if (__workflow_bodybilladdr2 != null)
                {
                    body["billaddr2"] = ExpressionConverter.ConvertO(__workflow_bodybilladdr2);
                    bodypropCount++;
                }

                if (__workflow_bodybillcity != null)
                {
                    body["billcity"] = ExpressionConverter.ConvertO(__workflow_bodybillcity);
                    bodypropCount++;
                }

                if (__workflow_bodybillstate != null)
                {
                    body["billstate"] = ExpressionConverter.ConvertO(__workflow_bodybillstate);
                    bodypropCount++;
                }

                if (__workflow_bodybillzipcode != null)
                {
                    body["billzipcode"] = ExpressionConverter.ConvertO(__workflow_bodybillzipcode);
                    bodypropCount++;
                }

                if (__workflow_bodybillcountry != null)
                {
                    body["billcountry"] = ExpressionConverter.ConvertO(__workflow_bodybillcountry);
                    bodypropCount++;
                }

                if (__workflow_bodybillphone != null)
                {
                    body["billphone"] = ExpressionConverter.ConvertO(__workflow_bodybillphone);
                    bodypropCount++;
                }

                if (__workflow_bodybillfax != null)
                {
                    body["billfax"] = ExpressionConverter.ConvertO(__workflow_bodybillfax);
                    bodypropCount++;
                }

                if (__workflow_bodyserviceaddr1 != null)
                {
                    body["serviceaddr1"] = ExpressionConverter.ConvertO(__workflow_bodyserviceaddr1);
                    bodypropCount++;
                }

                if (__workflow_bodyserviceaddr2 != null)
                {
                    body["serviceaddr2"] = ExpressionConverter.ConvertO(__workflow_bodyserviceaddr2);
                    bodypropCount++;
                }

                if (__workflow_bodyservicecity != null)
                {
                    body["servicecity"] = ExpressionConverter.ConvertO(__workflow_bodyservicecity);
                    bodypropCount++;
                }

                if (__workflow_bodyservicestate != null)
                {
                    body["servicestate"] = ExpressionConverter.ConvertO(__workflow_bodyservicestate);
                    bodypropCount++;
                }

                if (__workflow_bodyservicezipcode != null)
                {
                    body["servicezipcode"] = ExpressionConverter.ConvertO(__workflow_bodyservicezipcode);
                    bodypropCount++;
                }

                if (__workflow_bodyservicecountry != null)
                {
                    body["servicecountry"] = ExpressionConverter.ConvertO(__workflow_bodyservicecountry);
                    bodypropCount++;
                }

                if (__workflow_bodyservicephone != null)
                {
                    body["servicephone"] = ExpressionConverter.ConvertO(__workflow_bodyservicephone);
                    bodypropCount++;
                }

                if (__workflow_bodyreceiveddate != null)
                {
                    body["receiveddate"] = ExpressionConverter.ConvertO(__workflow_bodyreceiveddate);
                    bodypropCount++;
                }

                if (__workflow_bodyponumber != null)
                {
                    body["ponumber"] = ExpressionConverter.ConvertO(__workflow_bodyponumber);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodyreasoncode != null)
                {
                    body["reasoncode"] = ExpressionConverter.ConvertO(__workflow_bodyreasoncode);
                    bodypropCount++;
                }

                if (__workflow_bodysource != null)
                {
                    body["source"] = ExpressionConverter.ConvertO(__workflow_bodysource);
                    bodypropCount++;
                }

                if (__workflow_bodyassignedto != null)
                {
                    body["assignedto"] = ExpressionConverter.ConvertO(__workflow_bodyassignedto);
                    bodypropCount++;
                }

                if (__workflow_bodybackup != null)
                {
                    body["backup"] = ExpressionConverter.ConvertO(__workflow_bodybackup);
                    bodypropCount++;
                }

                if (__workflow_bodypriority != null)
                {
                    body["priority"] = ExpressionConverter.ConvertO(__workflow_bodypriority);
                    bodypropCount++;
                }

                if (__workflow_bodyduedate != null)
                {
                    body["duedate"] = ExpressionConverter.ConvertO(__workflow_bodyduedate);
                    bodypropCount++;
                }

                if (__workflow_bodysubject != null)
                {
                    body["subject"] = ExpressionConverter.ConvertO(__workflow_bodysubject);
                    bodypropCount++;
                }

                if (__workflow_bodybody != null)
                {
                    body["body"] = ExpressionConverter.ConvertO(__workflow_bodybody);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<WorkOrderGetValueResponse> WorkOrderGetValue(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<WorkOrderGetValueResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/WorkOrder/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<WorkOrderGetValueResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IWorkflowAction WorkOrderPutValue(Expression<Func<string>> id, Expression<Func<string>> bodyponumber = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodyreasoncode = null, Expression<Func<string>> bodysource = null, Expression<Func<string>> bodyassignedto = null, Expression<Func<string>> bodybackup = null, Expression<Func<bodypriorityInput>> bodypriority = null, Expression<Func<string>> bodyduedate = null, Expression<Func<string>> bodysubject = null, Expression<Func<string>> bodybody = null, Expression<Func<bool>> bodyhistory = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodyponumber = WorkflowExpression.Compile(bodyponumber, nameof(bodyponumber), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodyreasoncode = WorkflowExpression.Compile(bodyreasoncode, nameof(bodyreasoncode), required: false);
            var __workflow_bodysource = WorkflowExpression.Compile(bodysource, nameof(bodysource), required: false);
            var __workflow_bodyassignedto = WorkflowExpression.Compile(bodyassignedto, nameof(bodyassignedto), required: false);
            var __workflow_bodybackup = WorkflowExpression.Compile(bodybackup, nameof(bodybackup), required: false);
            var __workflow_bodypriority = WorkflowExpression.Compile(bodypriority, nameof(bodypriority), required: false);
            var __workflow_bodyduedate = WorkflowExpression.Compile(bodyduedate, nameof(bodyduedate), required: false);
            var __workflow_bodysubject = WorkflowExpression.Compile(bodysubject, nameof(bodysubject), required: false);
            var __workflow_bodybody = WorkflowExpression.Compile(bodybody, nameof(bodybody), required: false);
            var __workflow_bodyhistory = WorkflowExpression.Compile(bodyhistory, nameof(bodyhistory), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/WorkOrder/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyponumber != null)
                {
                    body["ponumber"] = ExpressionConverter.ConvertO(__workflow_bodyponumber);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodyreasoncode != null)
                {
                    body["reasoncode"] = ExpressionConverter.ConvertO(__workflow_bodyreasoncode);
                    bodypropCount++;
                }

                if (__workflow_bodysource != null)
                {
                    body["source"] = ExpressionConverter.ConvertO(__workflow_bodysource);
                    bodypropCount++;
                }

                if (__workflow_bodyassignedto != null)
                {
                    body["assignedto"] = ExpressionConverter.ConvertO(__workflow_bodyassignedto);
                    bodypropCount++;
                }

                if (__workflow_bodybackup != null)
                {
                    body["backup"] = ExpressionConverter.ConvertO(__workflow_bodybackup);
                    bodypropCount++;
                }

                if (__workflow_bodypriority != null)
                {
                    body["priority"] = ExpressionConverter.ConvertO(__workflow_bodypriority);
                    bodypropCount++;
                }

                if (__workflow_bodyduedate != null)
                {
                    body["duedate"] = ExpressionConverter.ConvertO(__workflow_bodyduedate);
                    bodypropCount++;
                }

                if (__workflow_bodysubject != null)
                {
                    body["subject"] = ExpressionConverter.ConvertO(__workflow_bodysubject);
                    bodypropCount++;
                }

                if (__workflow_bodybody != null)
                {
                    body["body"] = ExpressionConverter.ConvertO(__workflow_bodybody);
                    bodypropCount++;
                }

                if (__workflow_bodyhistory != null)
                {
                    body["history"] = ExpressionConverter.ConvertO(__workflow_bodyhistory);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class ImprezianTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<NewSalesLeadResponseItem[]> NewSalesLead(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/api/new_lead";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<NewSalesLeadResponseItem[]>(callPayload, recurrence: recurrence);
        }

        public IBodyWorkflowTrigger<NewMarketingCampaignResponseItem[]> NewMarketingCampaign(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/api/new_campaign";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<NewMarketingCampaignResponseItem[]>(callPayload, recurrence: recurrence);
        }

        public IBodyWorkflowTrigger<NewMembersLeadsResponseItem[]> NewMembersLeads(Expression<Func<int>> promotionID, FlowRecurrence recurrence = null)
        {
            var __workflow_promotionID = WorkflowExpression.Compile(promotionID, nameof(promotionID), required: true);
            return new DeferredBodyTrigger<NewMembersLeadsResponseItem[]>(() =>
            {
                var apiCallPath = "/trigger/api/new_members_leads";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["PromotionID"] = ExpressionConverter.Convert(__workflow_promotionID);
                return new ApiConnectionTrigger<NewMembersLeadsResponseItem[]>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<NewSalesOrderResponseItem[]> NewSalesOrder(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/api/new_orders";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<NewSalesOrderResponseItem[]>(callPayload, recurrence: recurrence);
        }

        public IBodyWorkflowTrigger<NewProposalCreatedResponseItem[]> NewProposalCreated(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/api/new_quotes";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<NewProposalCreatedResponseItem[]>(callPayload, recurrence: recurrence);
        }

        public IBodyWorkflowTrigger<OrderStatusChangedResponseItem[]> OrderStatusChanged(Expression<Func<string>> status, FlowRecurrence recurrence = null)
        {
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: true);
            return new DeferredBodyTrigger<OrderStatusChangedResponseItem[]>(() =>
            {
                var apiCallPath = "/trigger/api/order_status";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Status"] = ExpressionConverter.Convert(__workflow_status);
                return new ApiConnectionTrigger<OrderStatusChangedResponseItem[]>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<OrderInHistoryResponseItem[]> OrderInHistory(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/api/orders_final";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<OrderInHistoryResponseItem[]>(callPayload, recurrence: recurrence);
        }

        public IBodyWorkflowTrigger<OrderInProcessingResponseItem[]> OrderInProcessing(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/api/orders_processing";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<OrderInProcessingResponseItem[]>(callPayload, recurrence: recurrence);
        }

        public IBodyWorkflowTrigger<OrderIsShippingResponseItem[]> OrderIsShipping(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/api/orders_shipping";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<OrderIsShippingResponseItem[]>(callPayload, recurrence: recurrence);
        }

        public IBodyWorkflowTrigger<ProposalNeedsApprovalResponseItem[]> ProposalNeedsApproval(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/api/quotes_approval";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<ProposalNeedsApprovalResponseItem[]>(callPayload, recurrence: recurrence);
        }

        public IBodyWorkflowTrigger<WorkOrderClosedResponseItem[]> WorkOrderClosed(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/api/wo_closed";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<WorkOrderClosedResponseItem[]>(callPayload, recurrence: recurrence);
        }

        public IBodyWorkflowTrigger<WorkOrderCreatedResponseItem[]> WorkOrderCreated(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/api/wo_opened";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<WorkOrderCreatedResponseItem[]>(callPayload, recurrence: recurrence);
        }

        public IBodyWorkflowTrigger<WorkOrderPastDueResponseItem[]> WorkOrderPastDue(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/api/wo_pastdue";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<WorkOrderPastDueResponseItem[]>(callPayload, recurrence: recurrence);
        }

        public IBodyWorkflowTrigger<WorkOrderStatusChangedResponseItem[]> WorkOrderStatusChanged(Expression<Func<string>> status, FlowRecurrence recurrence = null)
        {
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: true);
            return new DeferredBodyTrigger<WorkOrderStatusChangedResponseItem[]>(() =>
            {
                var apiCallPath = "/trigger/api/wo_status";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Status"] = ExpressionConverter.Convert(__workflow_status);
                return new ApiConnectionTrigger<WorkOrderStatusChangedResponseItem[]>(callPayload, recurrence: recurrence);
            });
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum typeInput
    {
        C,
        L,
        B
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
