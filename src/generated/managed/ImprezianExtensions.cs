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
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Campaign";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<JToken> CampaignPostValue([WorkflowExpression] Func<string> bodydescription, [WorkflowExpression] Func<string> bodyexpires, [WorkflowExpression] Func<double> bodybudget, [WorkflowExpression] Func<string> bodystartdate = null, [WorkflowExpression] Func<string> bodypromotype = null, [WorkflowExpression] Func<string> bodymanager = null)
        {
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: true);
            SourceExpression.Validate(bodyexpires, nameof(bodyexpires), required: true);
            SourceExpression.Validate(bodybudget, nameof(bodybudget), required: true);
            SourceExpression.Validate(bodystartdate, nameof(bodystartdate), required: false);
            SourceExpression.Validate(bodypromotype, nameof(bodypromotype), required: false);
            SourceExpression.Validate(bodymanager, nameof(bodymanager), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Campaign";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                if (bodystartdate != null)
                {
                    body["startdate"] = SourceExpressionConverter.ConvertToken(bodystartdate);
                    bodypropCount++;
                }

                bodypropCount++;
                body["expires"] = SourceExpressionConverter.ConvertToken(bodyexpires);
                bodypropCount++;
                body["budget"] = SourceExpressionConverter.ConvertToken(bodybudget);
                if (bodypromotype != null)
                {
                    body["promotype"] = SourceExpressionConverter.ConvertToken(bodypromotype);
                    bodypropCount++;
                }

                if (bodymanager != null)
                {
                    body["manager"] = SourceExpressionConverter.ConvertToken(bodymanager);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<CampaignGetValueResponse> CampaignGetValue([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/Campaign/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<CampaignGetValueResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<JToken> CampaignPutValue([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodystartdate = null, [WorkflowExpression] Func<string> bodyexpires = null, [WorkflowExpression] Func<double> bodybudget = null, [WorkflowExpression] Func<string> bodymanager = null, [WorkflowExpression] Func<bool> bodyhistory = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            SourceExpression.Validate(bodystartdate, nameof(bodystartdate), required: false);
            SourceExpression.Validate(bodyexpires, nameof(bodyexpires), required: false);
            SourceExpression.Validate(bodybudget, nameof(bodybudget), required: false);
            SourceExpression.Validate(bodymanager, nameof(bodymanager), required: false);
            SourceExpression.Validate(bodyhistory, nameof(bodyhistory), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/Campaign/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodystartdate != null)
                {
                    body["startdate"] = SourceExpressionConverter.ConvertToken(bodystartdate);
                    bodypropCount++;
                }

                if (bodyexpires != null)
                {
                    body["expires"] = SourceExpressionConverter.ConvertToken(bodyexpires);
                    bodypropCount++;
                }

                if (bodybudget != null)
                {
                    body["budget"] = SourceExpressionConverter.ConvertToken(bodybudget);
                    bodypropCount++;
                }

                if (bodymanager != null)
                {
                    body["manager"] = SourceExpressionConverter.ConvertToken(bodymanager);
                    bodypropCount++;
                }

                if (bodyhistory != null)
                {
                    body["history"] = SourceExpressionConverter.ConvertToken(bodyhistory);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<string[]> ComLogGetValues()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/ComLog";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<JToken> ComLogPostValue([WorkflowExpression] Func<string> bodycontactid = null, [WorkflowExpression] Func<string> bodyleadid = null, [WorkflowExpression] Func<bodytypeInput> bodytype = null, [WorkflowExpression] Func<string> bodysubject = null, [WorkflowExpression] Func<string> bodybody = null, [WorkflowExpression] Func<string> bodyemployee = null, [WorkflowExpression] Func<string> bodystarttime = null, [WorkflowExpression] Func<string> bodyendtime = null, [WorkflowExpression] Func<string> bodyworkorder = null, [WorkflowExpression] Func<string> bodyproject = null, [WorkflowExpression] Func<string> bodycampaign = null, [WorkflowExpression] Func<double> bodylength = null, [WorkflowExpression] Func<bool> bodybilled = null, [WorkflowExpression] Func<bool> bodyinbound = null)
        {
            SourceExpression.Validate(bodycontactid, nameof(bodycontactid), required: false);
            SourceExpression.Validate(bodyleadid, nameof(bodyleadid), required: false);
            SourceExpression.Validate(bodytype, nameof(bodytype), required: false);
            SourceExpression.Validate(bodysubject, nameof(bodysubject), required: false);
            SourceExpression.Validate(bodybody, nameof(bodybody), required: false);
            SourceExpression.Validate(bodyemployee, nameof(bodyemployee), required: false);
            SourceExpression.Validate(bodystarttime, nameof(bodystarttime), required: false);
            SourceExpression.Validate(bodyendtime, nameof(bodyendtime), required: false);
            SourceExpression.Validate(bodyworkorder, nameof(bodyworkorder), required: false);
            SourceExpression.Validate(bodyproject, nameof(bodyproject), required: false);
            SourceExpression.Validate(bodycampaign, nameof(bodycampaign), required: false);
            SourceExpression.Validate(bodylength, nameof(bodylength), required: false);
            SourceExpression.Validate(bodybilled, nameof(bodybilled), required: false);
            SourceExpression.Validate(bodyinbound, nameof(bodyinbound), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/ComLog";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycontactid != null)
                {
                    body["contactid"] = SourceExpressionConverter.ConvertToken(bodycontactid);
                    bodypropCount++;
                }

                if (bodyleadid != null)
                {
                    body["leadid"] = SourceExpressionConverter.ConvertToken(bodyleadid);
                    bodypropCount++;
                }

                if (bodytype != null)
                {
                    body["type"] = SourceExpressionConverter.Convert(bodytype);
                    bodypropCount++;
                }

                if (bodysubject != null)
                {
                    body["subject"] = SourceExpressionConverter.ConvertToken(bodysubject);
                    bodypropCount++;
                }

                if (bodybody != null)
                {
                    body["body"] = SourceExpressionConverter.ConvertToken(bodybody);
                    bodypropCount++;
                }

                if (bodyemployee != null)
                {
                    body["employee"] = SourceExpressionConverter.ConvertToken(bodyemployee);
                    bodypropCount++;
                }

                if (bodystarttime != null)
                {
                    body["starttime"] = SourceExpressionConverter.ConvertToken(bodystarttime);
                    bodypropCount++;
                }

                if (bodyendtime != null)
                {
                    body["endtime"] = SourceExpressionConverter.ConvertToken(bodyendtime);
                    bodypropCount++;
                }

                if (bodyworkorder != null)
                {
                    body["workorder"] = SourceExpressionConverter.ConvertToken(bodyworkorder);
                    bodypropCount++;
                }

                if (bodyproject != null)
                {
                    body["project"] = SourceExpressionConverter.ConvertToken(bodyproject);
                    bodypropCount++;
                }

                if (bodycampaign != null)
                {
                    body["campaign"] = SourceExpressionConverter.ConvertToken(bodycampaign);
                    bodypropCount++;
                }

                if (bodylength != null)
                {
                    body["length"] = SourceExpressionConverter.ConvertToken(bodylength);
                    bodypropCount++;
                }

                if (bodybilled != null)
                {
                    body["billed"] = SourceExpressionConverter.ConvertToken(bodybilled);
                    bodypropCount++;
                }

                if (bodyinbound != null)
                {
                    body["inbound"] = SourceExpressionConverter.ConvertToken(bodyinbound);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<ComLogGetValueResponse> ComLogGetValue([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/ComLog/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ComLogGetValueResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IWorkflowAction ComLogPutValue([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<bodytypeInput> bodytype = null, [WorkflowExpression] Func<string> bodysubject = null, [WorkflowExpression] Func<string> bodybody = null, [WorkflowExpression] Func<string> bodyemployee = null, [WorkflowExpression] Func<string> bodystarttime = null, [WorkflowExpression] Func<string> bodyendtime = null, [WorkflowExpression] Func<string> bodyworkorder = null, [WorkflowExpression] Func<string> bodyproject = null, [WorkflowExpression] Func<string> bodycampaign = null, [WorkflowExpression] Func<double> bodylength = null, [WorkflowExpression] Func<bool> bodybilled = null, [WorkflowExpression] Func<bool> bodyinbound = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodytype, nameof(bodytype), required: false);
            SourceExpression.Validate(bodysubject, nameof(bodysubject), required: false);
            SourceExpression.Validate(bodybody, nameof(bodybody), required: false);
            SourceExpression.Validate(bodyemployee, nameof(bodyemployee), required: false);
            SourceExpression.Validate(bodystarttime, nameof(bodystarttime), required: false);
            SourceExpression.Validate(bodyendtime, nameof(bodyendtime), required: false);
            SourceExpression.Validate(bodyworkorder, nameof(bodyworkorder), required: false);
            SourceExpression.Validate(bodyproject, nameof(bodyproject), required: false);
            SourceExpression.Validate(bodycampaign, nameof(bodycampaign), required: false);
            SourceExpression.Validate(bodylength, nameof(bodylength), required: false);
            SourceExpression.Validate(bodybilled, nameof(bodybilled), required: false);
            SourceExpression.Validate(bodyinbound, nameof(bodyinbound), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/ComLog/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytype != null)
                {
                    body["type"] = SourceExpressionConverter.Convert(bodytype);
                    bodypropCount++;
                }

                if (bodysubject != null)
                {
                    body["subject"] = SourceExpressionConverter.ConvertToken(bodysubject);
                    bodypropCount++;
                }

                if (bodybody != null)
                {
                    body["body"] = SourceExpressionConverter.ConvertToken(bodybody);
                    bodypropCount++;
                }

                if (bodyemployee != null)
                {
                    body["employee"] = SourceExpressionConverter.ConvertToken(bodyemployee);
                    bodypropCount++;
                }

                if (bodystarttime != null)
                {
                    body["starttime"] = SourceExpressionConverter.ConvertToken(bodystarttime);
                    bodypropCount++;
                }

                if (bodyendtime != null)
                {
                    body["endtime"] = SourceExpressionConverter.ConvertToken(bodyendtime);
                    bodypropCount++;
                }

                if (bodyworkorder != null)
                {
                    body["workorder"] = SourceExpressionConverter.ConvertToken(bodyworkorder);
                    bodypropCount++;
                }

                if (bodyproject != null)
                {
                    body["project"] = SourceExpressionConverter.ConvertToken(bodyproject);
                    bodypropCount++;
                }

                if (bodycampaign != null)
                {
                    body["campaign"] = SourceExpressionConverter.ConvertToken(bodycampaign);
                    bodypropCount++;
                }

                if (bodylength != null)
                {
                    body["length"] = SourceExpressionConverter.ConvertToken(bodylength);
                    bodypropCount++;
                }

                if (bodybilled != null)
                {
                    body["billed"] = SourceExpressionConverter.ConvertToken(bodybilled);
                    bodypropCount++;
                }

                if (bodyinbound != null)
                {
                    body["inbound"] = SourceExpressionConverter.ConvertToken(bodyinbound);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<string[]> ContactGetValues()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Contact";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<JToken> ContactPostValue([WorkflowExpression] Func<string> bodyaccount = null, [WorkflowExpression] Func<string> bodysal = null, [WorkflowExpression] Func<string> bodyfirstname = null, [WorkflowExpression] Func<string> bodymiddlename = null, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodylastname = null, [WorkflowExpression] Func<string> bodycompany = null, [WorkflowExpression] Func<string> bodyaddr1 = null, [WorkflowExpression] Func<string> bodyaddr2 = null, [WorkflowExpression] Func<string> bodycity = null, [WorkflowExpression] Func<string> bodystate = null, [WorkflowExpression] Func<string> bodypostal = null, [WorkflowExpression] Func<string> bodyemail1 = null, [WorkflowExpression] Func<string> bodyemail2 = null, [WorkflowExpression] Func<string> bodyemail3 = null, [WorkflowExpression] Func<string> bodyemail4 = null, [WorkflowExpression] Func<string> bodyphonetype1 = null, [WorkflowExpression] Func<string> bodyphone1 = null, [WorkflowExpression] Func<string> bodyphonetype2 = null, [WorkflowExpression] Func<string> bodyphone2 = null, [WorkflowExpression] Func<string> bodyphonetype3 = null, [WorkflowExpression] Func<string> bodyphone3 = null, [WorkflowExpression] Func<string> bodyphonetype4 = null, [WorkflowExpression] Func<string> bodyphone4 = null, [WorkflowExpression] Func<string> bodyremark = null, [WorkflowExpression] Func<string> bodynotes = null, [WorkflowExpression] Func<string> bodycampaign = null, [WorkflowExpression] Func<string> bodycategory = null, [WorkflowExpression] Func<string> bodymarket = null, [WorkflowExpression] Func<string> bodyterritory = null, [WorkflowExpression] Func<string> bodysalesrep = null, [WorkflowExpression] Func<string> bodylastcontact = null)
        {
            SourceExpression.Validate(bodyaccount, nameof(bodyaccount), required: false);
            SourceExpression.Validate(bodysal, nameof(bodysal), required: false);
            SourceExpression.Validate(bodyfirstname, nameof(bodyfirstname), required: false);
            SourceExpression.Validate(bodymiddlename, nameof(bodymiddlename), required: false);
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            SourceExpression.Validate(bodylastname, nameof(bodylastname), required: false);
            SourceExpression.Validate(bodycompany, nameof(bodycompany), required: false);
            SourceExpression.Validate(bodyaddr1, nameof(bodyaddr1), required: false);
            SourceExpression.Validate(bodyaddr2, nameof(bodyaddr2), required: false);
            SourceExpression.Validate(bodycity, nameof(bodycity), required: false);
            SourceExpression.Validate(bodystate, nameof(bodystate), required: false);
            SourceExpression.Validate(bodypostal, nameof(bodypostal), required: false);
            SourceExpression.Validate(bodyemail1, nameof(bodyemail1), required: false);
            SourceExpression.Validate(bodyemail2, nameof(bodyemail2), required: false);
            SourceExpression.Validate(bodyemail3, nameof(bodyemail3), required: false);
            SourceExpression.Validate(bodyemail4, nameof(bodyemail4), required: false);
            SourceExpression.Validate(bodyphonetype1, nameof(bodyphonetype1), required: false);
            SourceExpression.Validate(bodyphone1, nameof(bodyphone1), required: false);
            SourceExpression.Validate(bodyphonetype2, nameof(bodyphonetype2), required: false);
            SourceExpression.Validate(bodyphone2, nameof(bodyphone2), required: false);
            SourceExpression.Validate(bodyphonetype3, nameof(bodyphonetype3), required: false);
            SourceExpression.Validate(bodyphone3, nameof(bodyphone3), required: false);
            SourceExpression.Validate(bodyphonetype4, nameof(bodyphonetype4), required: false);
            SourceExpression.Validate(bodyphone4, nameof(bodyphone4), required: false);
            SourceExpression.Validate(bodyremark, nameof(bodyremark), required: false);
            SourceExpression.Validate(bodynotes, nameof(bodynotes), required: false);
            SourceExpression.Validate(bodycampaign, nameof(bodycampaign), required: false);
            SourceExpression.Validate(bodycategory, nameof(bodycategory), required: false);
            SourceExpression.Validate(bodymarket, nameof(bodymarket), required: false);
            SourceExpression.Validate(bodyterritory, nameof(bodyterritory), required: false);
            SourceExpression.Validate(bodysalesrep, nameof(bodysalesrep), required: false);
            SourceExpression.Validate(bodylastcontact, nameof(bodylastcontact), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Contact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyaccount != null)
                {
                    body["account"] = SourceExpressionConverter.ConvertToken(bodyaccount);
                    bodypropCount++;
                }

                if (bodysal != null)
                {
                    body["sal"] = SourceExpressionConverter.ConvertToken(bodysal);
                    bodypropCount++;
                }

                if (bodyfirstname != null)
                {
                    body["firstname"] = SourceExpressionConverter.ConvertToken(bodyfirstname);
                    bodypropCount++;
                }

                if (bodymiddlename != null)
                {
                    body["middlename"] = SourceExpressionConverter.ConvertToken(bodymiddlename);
                    bodypropCount++;
                }

                if (bodytitle != null)
                {
                    body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodylastname != null)
                {
                    body["lastname"] = SourceExpressionConverter.ConvertToken(bodylastname);
                    bodypropCount++;
                }

                if (bodycompany != null)
                {
                    body["company"] = SourceExpressionConverter.ConvertToken(bodycompany);
                    bodypropCount++;
                }

                if (bodyaddr1 != null)
                {
                    body["addr1"] = SourceExpressionConverter.ConvertToken(bodyaddr1);
                    bodypropCount++;
                }

                if (bodyaddr2 != null)
                {
                    body["addr2"] = SourceExpressionConverter.ConvertToken(bodyaddr2);
                    bodypropCount++;
                }

                if (bodycity != null)
                {
                    body["city"] = SourceExpressionConverter.ConvertToken(bodycity);
                    bodypropCount++;
                }

                if (bodystate != null)
                {
                    body["state"] = SourceExpressionConverter.ConvertToken(bodystate);
                    bodypropCount++;
                }

                if (bodypostal != null)
                {
                    body["postal"] = SourceExpressionConverter.ConvertToken(bodypostal);
                    bodypropCount++;
                }

                if (bodyemail1 != null)
                {
                    body["email1"] = SourceExpressionConverter.ConvertToken(bodyemail1);
                    bodypropCount++;
                }

                if (bodyemail2 != null)
                {
                    body["email2"] = SourceExpressionConverter.ConvertToken(bodyemail2);
                    bodypropCount++;
                }

                if (bodyemail3 != null)
                {
                    body["email3"] = SourceExpressionConverter.ConvertToken(bodyemail3);
                    bodypropCount++;
                }

                if (bodyemail4 != null)
                {
                    body["email4"] = SourceExpressionConverter.ConvertToken(bodyemail4);
                    bodypropCount++;
                }

                if (bodyphonetype1 != null)
                {
                    body["phonetype1"] = SourceExpressionConverter.ConvertToken(bodyphonetype1);
                    bodypropCount++;
                }

                if (bodyphone1 != null)
                {
                    body["phone1"] = SourceExpressionConverter.ConvertToken(bodyphone1);
                    bodypropCount++;
                }

                if (bodyphonetype2 != null)
                {
                    body["phonetype2"] = SourceExpressionConverter.ConvertToken(bodyphonetype2);
                    bodypropCount++;
                }

                if (bodyphone2 != null)
                {
                    body["phone2"] = SourceExpressionConverter.ConvertToken(bodyphone2);
                    bodypropCount++;
                }

                if (bodyphonetype3 != null)
                {
                    body["phonetype3"] = SourceExpressionConverter.ConvertToken(bodyphonetype3);
                    bodypropCount++;
                }

                if (bodyphone3 != null)
                {
                    body["phone3"] = SourceExpressionConverter.ConvertToken(bodyphone3);
                    bodypropCount++;
                }

                if (bodyphonetype4 != null)
                {
                    body["phonetype4"] = SourceExpressionConverter.ConvertToken(bodyphonetype4);
                    bodypropCount++;
                }

                if (bodyphone4 != null)
                {
                    body["phone4"] = SourceExpressionConverter.ConvertToken(bodyphone4);
                    bodypropCount++;
                }

                if (bodyremark != null)
                {
                    body["remark"] = SourceExpressionConverter.ConvertToken(bodyremark);
                    bodypropCount++;
                }

                if (bodynotes != null)
                {
                    body["notes"] = SourceExpressionConverter.ConvertToken(bodynotes);
                    bodypropCount++;
                }

                if (bodycampaign != null)
                {
                    body["campaign"] = SourceExpressionConverter.ConvertToken(bodycampaign);
                    bodypropCount++;
                }

                if (bodycategory != null)
                {
                    body["category"] = SourceExpressionConverter.ConvertToken(bodycategory);
                    bodypropCount++;
                }

                if (bodymarket != null)
                {
                    body["market"] = SourceExpressionConverter.ConvertToken(bodymarket);
                    bodypropCount++;
                }

                if (bodyterritory != null)
                {
                    body["territory"] = SourceExpressionConverter.ConvertToken(bodyterritory);
                    bodypropCount++;
                }

                if (bodysalesrep != null)
                {
                    body["salesrep"] = SourceExpressionConverter.ConvertToken(bodysalesrep);
                    bodypropCount++;
                }

                if (bodylastcontact != null)
                {
                    body["lastcontact"] = SourceExpressionConverter.ConvertToken(bodylastcontact);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<JToken> ContactGetValue([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/Contact/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<JToken> ContactPutValue([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodysal = null, [WorkflowExpression] Func<string> bodyfirstname = null, [WorkflowExpression] Func<string> bodymiddlename = null, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodylastname = null, [WorkflowExpression] Func<string> bodycompany = null, [WorkflowExpression] Func<string> bodyaddr1 = null, [WorkflowExpression] Func<string> bodyaddr2 = null, [WorkflowExpression] Func<string> bodycity = null, [WorkflowExpression] Func<string> bodystate = null, [WorkflowExpression] Func<string> bodypostal = null, [WorkflowExpression] Func<string> bodyemail1 = null, [WorkflowExpression] Func<string> bodyemail2 = null, [WorkflowExpression] Func<string> bodyemail3 = null, [WorkflowExpression] Func<string> bodyemail4 = null, [WorkflowExpression] Func<string> bodyphonetype1 = null, [WorkflowExpression] Func<string> bodyphone1 = null, [WorkflowExpression] Func<string> bodyphonetype2 = null, [WorkflowExpression] Func<string> bodyphone2 = null, [WorkflowExpression] Func<string> bodyphonetype3 = null, [WorkflowExpression] Func<string> bodyphone3 = null, [WorkflowExpression] Func<string> bodyphonetype4 = null, [WorkflowExpression] Func<string> bodyphone4 = null, [WorkflowExpression] Func<string> bodyremark = null, [WorkflowExpression] Func<string> bodynotes = null, [WorkflowExpression] Func<string> bodycampaign = null, [WorkflowExpression] Func<string> bodycategory = null, [WorkflowExpression] Func<string> bodymarket = null, [WorkflowExpression] Func<string> bodyterritory = null, [WorkflowExpression] Func<string> bodysalesrep = null, [WorkflowExpression] Func<string> bodylastcontact = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodysal, nameof(bodysal), required: false);
            SourceExpression.Validate(bodyfirstname, nameof(bodyfirstname), required: false);
            SourceExpression.Validate(bodymiddlename, nameof(bodymiddlename), required: false);
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            SourceExpression.Validate(bodylastname, nameof(bodylastname), required: false);
            SourceExpression.Validate(bodycompany, nameof(bodycompany), required: false);
            SourceExpression.Validate(bodyaddr1, nameof(bodyaddr1), required: false);
            SourceExpression.Validate(bodyaddr2, nameof(bodyaddr2), required: false);
            SourceExpression.Validate(bodycity, nameof(bodycity), required: false);
            SourceExpression.Validate(bodystate, nameof(bodystate), required: false);
            SourceExpression.Validate(bodypostal, nameof(bodypostal), required: false);
            SourceExpression.Validate(bodyemail1, nameof(bodyemail1), required: false);
            SourceExpression.Validate(bodyemail2, nameof(bodyemail2), required: false);
            SourceExpression.Validate(bodyemail3, nameof(bodyemail3), required: false);
            SourceExpression.Validate(bodyemail4, nameof(bodyemail4), required: false);
            SourceExpression.Validate(bodyphonetype1, nameof(bodyphonetype1), required: false);
            SourceExpression.Validate(bodyphone1, nameof(bodyphone1), required: false);
            SourceExpression.Validate(bodyphonetype2, nameof(bodyphonetype2), required: false);
            SourceExpression.Validate(bodyphone2, nameof(bodyphone2), required: false);
            SourceExpression.Validate(bodyphonetype3, nameof(bodyphonetype3), required: false);
            SourceExpression.Validate(bodyphone3, nameof(bodyphone3), required: false);
            SourceExpression.Validate(bodyphonetype4, nameof(bodyphonetype4), required: false);
            SourceExpression.Validate(bodyphone4, nameof(bodyphone4), required: false);
            SourceExpression.Validate(bodyremark, nameof(bodyremark), required: false);
            SourceExpression.Validate(bodynotes, nameof(bodynotes), required: false);
            SourceExpression.Validate(bodycampaign, nameof(bodycampaign), required: false);
            SourceExpression.Validate(bodycategory, nameof(bodycategory), required: false);
            SourceExpression.Validate(bodymarket, nameof(bodymarket), required: false);
            SourceExpression.Validate(bodyterritory, nameof(bodyterritory), required: false);
            SourceExpression.Validate(bodysalesrep, nameof(bodysalesrep), required: false);
            SourceExpression.Validate(bodylastcontact, nameof(bodylastcontact), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/Contact/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodysal != null)
                {
                    body["sal"] = SourceExpressionConverter.ConvertToken(bodysal);
                    bodypropCount++;
                }

                if (bodyfirstname != null)
                {
                    body["firstname"] = SourceExpressionConverter.ConvertToken(bodyfirstname);
                    bodypropCount++;
                }

                if (bodymiddlename != null)
                {
                    body["middlename"] = SourceExpressionConverter.ConvertToken(bodymiddlename);
                    bodypropCount++;
                }

                if (bodytitle != null)
                {
                    body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodylastname != null)
                {
                    body["lastname"] = SourceExpressionConverter.ConvertToken(bodylastname);
                    bodypropCount++;
                }

                if (bodycompany != null)
                {
                    body["company"] = SourceExpressionConverter.ConvertToken(bodycompany);
                    bodypropCount++;
                }

                if (bodyaddr1 != null)
                {
                    body["addr1"] = SourceExpressionConverter.ConvertToken(bodyaddr1);
                    bodypropCount++;
                }

                if (bodyaddr2 != null)
                {
                    body["addr2"] = SourceExpressionConverter.ConvertToken(bodyaddr2);
                    bodypropCount++;
                }

                if (bodycity != null)
                {
                    body["city"] = SourceExpressionConverter.ConvertToken(bodycity);
                    bodypropCount++;
                }

                if (bodystate != null)
                {
                    body["state"] = SourceExpressionConverter.ConvertToken(bodystate);
                    bodypropCount++;
                }

                if (bodypostal != null)
                {
                    body["postal"] = SourceExpressionConverter.ConvertToken(bodypostal);
                    bodypropCount++;
                }

                if (bodyemail1 != null)
                {
                    body["email1"] = SourceExpressionConverter.ConvertToken(bodyemail1);
                    bodypropCount++;
                }

                if (bodyemail2 != null)
                {
                    body["email2"] = SourceExpressionConverter.ConvertToken(bodyemail2);
                    bodypropCount++;
                }

                if (bodyemail3 != null)
                {
                    body["email3"] = SourceExpressionConverter.ConvertToken(bodyemail3);
                    bodypropCount++;
                }

                if (bodyemail4 != null)
                {
                    body["email4"] = SourceExpressionConverter.ConvertToken(bodyemail4);
                    bodypropCount++;
                }

                if (bodyphonetype1 != null)
                {
                    body["phonetype1"] = SourceExpressionConverter.ConvertToken(bodyphonetype1);
                    bodypropCount++;
                }

                if (bodyphone1 != null)
                {
                    body["phone1"] = SourceExpressionConverter.ConvertToken(bodyphone1);
                    bodypropCount++;
                }

                if (bodyphonetype2 != null)
                {
                    body["phonetype2"] = SourceExpressionConverter.ConvertToken(bodyphonetype2);
                    bodypropCount++;
                }

                if (bodyphone2 != null)
                {
                    body["phone2"] = SourceExpressionConverter.ConvertToken(bodyphone2);
                    bodypropCount++;
                }

                if (bodyphonetype3 != null)
                {
                    body["phonetype3"] = SourceExpressionConverter.ConvertToken(bodyphonetype3);
                    bodypropCount++;
                }

                if (bodyphone3 != null)
                {
                    body["phone3"] = SourceExpressionConverter.ConvertToken(bodyphone3);
                    bodypropCount++;
                }

                if (bodyphonetype4 != null)
                {
                    body["phonetype4"] = SourceExpressionConverter.ConvertToken(bodyphonetype4);
                    bodypropCount++;
                }

                if (bodyphone4 != null)
                {
                    body["phone4"] = SourceExpressionConverter.ConvertToken(bodyphone4);
                    bodypropCount++;
                }

                if (bodyremark != null)
                {
                    body["remark"] = SourceExpressionConverter.ConvertToken(bodyremark);
                    bodypropCount++;
                }

                if (bodynotes != null)
                {
                    body["notes"] = SourceExpressionConverter.ConvertToken(bodynotes);
                    bodypropCount++;
                }

                if (bodycampaign != null)
                {
                    body["campaign"] = SourceExpressionConverter.ConvertToken(bodycampaign);
                    bodypropCount++;
                }

                if (bodycategory != null)
                {
                    body["category"] = SourceExpressionConverter.ConvertToken(bodycategory);
                    bodypropCount++;
                }

                if (bodymarket != null)
                {
                    body["market"] = SourceExpressionConverter.ConvertToken(bodymarket);
                    bodypropCount++;
                }

                if (bodyterritory != null)
                {
                    body["territory"] = SourceExpressionConverter.ConvertToken(bodyterritory);
                    bodypropCount++;
                }

                if (bodysalesrep != null)
                {
                    body["salesrep"] = SourceExpressionConverter.ConvertToken(bodysalesrep);
                    bodypropCount++;
                }

                if (bodylastcontact != null)
                {
                    body["lastcontact"] = SourceExpressionConverter.ConvertToken(bodylastcontact);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<string[]> FollowUpGetValues()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/FollowUp";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<JToken> FollowUpPostValue([WorkflowExpression] Func<string> bodycontactid = null, [WorkflowExpression] Func<string> bodyleadid = null, [WorkflowExpression] Func<string> bodytype = null, [WorkflowExpression] Func<string> bodycomments = null, [WorkflowExpression] Func<string> bodyassignedto = null, [WorkflowExpression] Func<string> bodysetby = null, [WorkflowExpression] Func<string> bodyduedate = null, [WorkflowExpression] Func<bool> bodyurgent = null, [WorkflowExpression] Func<double> bodyreminderminutes = null, [WorkflowExpression] Func<bool> bodycleared = null)
        {
            SourceExpression.Validate(bodycontactid, nameof(bodycontactid), required: false);
            SourceExpression.Validate(bodyleadid, nameof(bodyleadid), required: false);
            SourceExpression.Validate(bodytype, nameof(bodytype), required: false);
            SourceExpression.Validate(bodycomments, nameof(bodycomments), required: false);
            SourceExpression.Validate(bodyassignedto, nameof(bodyassignedto), required: false);
            SourceExpression.Validate(bodysetby, nameof(bodysetby), required: false);
            SourceExpression.Validate(bodyduedate, nameof(bodyduedate), required: false);
            SourceExpression.Validate(bodyurgent, nameof(bodyurgent), required: false);
            SourceExpression.Validate(bodyreminderminutes, nameof(bodyreminderminutes), required: false);
            SourceExpression.Validate(bodycleared, nameof(bodycleared), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/FollowUp";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycontactid != null)
                {
                    body["contactid"] = SourceExpressionConverter.ConvertToken(bodycontactid);
                    bodypropCount++;
                }

                if (bodyleadid != null)
                {
                    body["leadid"] = SourceExpressionConverter.ConvertToken(bodyleadid);
                    bodypropCount++;
                }

                if (bodytype != null)
                {
                    body["type"] = SourceExpressionConverter.ConvertToken(bodytype);
                    bodypropCount++;
                }

                if (bodycomments != null)
                {
                    body["comments"] = SourceExpressionConverter.ConvertToken(bodycomments);
                    bodypropCount++;
                }

                if (bodyassignedto != null)
                {
                    body["assignedto"] = SourceExpressionConverter.ConvertToken(bodyassignedto);
                    bodypropCount++;
                }

                if (bodysetby != null)
                {
                    body["setby"] = SourceExpressionConverter.ConvertToken(bodysetby);
                    bodypropCount++;
                }

                if (bodyduedate != null)
                {
                    body["duedate"] = SourceExpressionConverter.ConvertToken(bodyduedate);
                    bodypropCount++;
                }

                if (bodyurgent != null)
                {
                    body["urgent"] = SourceExpressionConverter.ConvertToken(bodyurgent);
                    bodypropCount++;
                }

                if (bodyreminderminutes != null)
                {
                    body["reminderminutes"] = SourceExpressionConverter.ConvertToken(bodyreminderminutes);
                    bodypropCount++;
                }

                if (bodycleared != null)
                {
                    body["cleared"] = SourceExpressionConverter.ConvertToken(bodycleared);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<FollowUpGetValueResponse> FollowUpGetValue([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/FollowUp/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<FollowUpGetValueResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IWorkflowAction FollowUpPutValue([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodytype = null, [WorkflowExpression] Func<string> bodycomments = null, [WorkflowExpression] Func<string> bodyassignedto = null, [WorkflowExpression] Func<string> bodysetby = null, [WorkflowExpression] Func<string> bodyduedate = null, [WorkflowExpression] Func<string> bodyurgent = null, [WorkflowExpression] Func<double> bodyreminderminutes = null, [WorkflowExpression] Func<bool> bodycleared = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodytype, nameof(bodytype), required: false);
            SourceExpression.Validate(bodycomments, nameof(bodycomments), required: false);
            SourceExpression.Validate(bodyassignedto, nameof(bodyassignedto), required: false);
            SourceExpression.Validate(bodysetby, nameof(bodysetby), required: false);
            SourceExpression.Validate(bodyduedate, nameof(bodyduedate), required: false);
            SourceExpression.Validate(bodyurgent, nameof(bodyurgent), required: false);
            SourceExpression.Validate(bodyreminderminutes, nameof(bodyreminderminutes), required: false);
            SourceExpression.Validate(bodycleared, nameof(bodycleared), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/FollowUp/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytype != null)
                {
                    body["type"] = SourceExpressionConverter.ConvertToken(bodytype);
                    bodypropCount++;
                }

                if (bodycomments != null)
                {
                    body["comments"] = SourceExpressionConverter.ConvertToken(bodycomments);
                    bodypropCount++;
                }

                if (bodyassignedto != null)
                {
                    body["assignedto"] = SourceExpressionConverter.ConvertToken(bodyassignedto);
                    bodypropCount++;
                }

                if (bodysetby != null)
                {
                    body["setby"] = SourceExpressionConverter.ConvertToken(bodysetby);
                    bodypropCount++;
                }

                if (bodyduedate != null)
                {
                    body["duedate"] = SourceExpressionConverter.ConvertToken(bodyduedate);
                    bodypropCount++;
                }

                if (bodyurgent != null)
                {
                    body["urgent"] = SourceExpressionConverter.ConvertToken(bodyurgent);
                    bodypropCount++;
                }

                if (bodyreminderminutes != null)
                {
                    body["reminderminutes"] = SourceExpressionConverter.ConvertToken(bodyreminderminutes);
                    bodypropCount++;
                }

                if (bodycleared != null)
                {
                    body["cleared"] = SourceExpressionConverter.ConvertToken(bodycleared);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<string[]> ItemListGetValues()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/ItemList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<ItemListPostValueResponse> ItemListPostValue([WorkflowExpression] Func<string> bodymodelno = null, [WorkflowExpression] Func<string> bodydescrip = null, [WorkflowExpression] Func<bodyitemtypeInput> bodyitemtype = null, [WorkflowExpression] Func<double> bodyprice = null, [WorkflowExpression] Func<double> bodycost = null, [WorkflowExpression] Func<string> bodyvendor = null)
        {
            SourceExpression.Validate(bodymodelno, nameof(bodymodelno), required: false);
            SourceExpression.Validate(bodydescrip, nameof(bodydescrip), required: false);
            SourceExpression.Validate(bodyitemtype, nameof(bodyitemtype), required: false);
            SourceExpression.Validate(bodyprice, nameof(bodyprice), required: false);
            SourceExpression.Validate(bodycost, nameof(bodycost), required: false);
            SourceExpression.Validate(bodyvendor, nameof(bodyvendor), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/ItemList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodymodelno != null)
                {
                    body["modelno"] = SourceExpressionConverter.ConvertToken(bodymodelno);
                    bodypropCount++;
                }

                if (bodydescrip != null)
                {
                    body["descrip"] = SourceExpressionConverter.ConvertToken(bodydescrip);
                    bodypropCount++;
                }

                if (bodyitemtype != null)
                {
                    body["itemtype"] = SourceExpressionConverter.Convert(bodyitemtype);
                    bodypropCount++;
                }

                if (bodyprice != null)
                {
                    body["price"] = SourceExpressionConverter.ConvertToken(bodyprice);
                    bodypropCount++;
                }

                if (bodycost != null)
                {
                    body["cost"] = SourceExpressionConverter.ConvertToken(bodycost);
                    bodypropCount++;
                }

                if (bodyvendor != null)
                {
                    body["vendor"] = SourceExpressionConverter.ConvertToken(bodyvendor);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ItemListPostValueResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<ItemListGetValueResponse> ItemListGetValue([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/ItemList/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ItemListGetValueResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IWorkflowAction ItemListPutValue([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodydescrip = null, [WorkflowExpression] Func<double> bodyprice = null, [WorkflowExpression] Func<double> bodycost = null, [WorkflowExpression] Func<string> bodyvendor = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodydescrip, nameof(bodydescrip), required: false);
            SourceExpression.Validate(bodyprice, nameof(bodyprice), required: false);
            SourceExpression.Validate(bodycost, nameof(bodycost), required: false);
            SourceExpression.Validate(bodyvendor, nameof(bodyvendor), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/ItemList/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydescrip != null)
                {
                    body["descrip"] = SourceExpressionConverter.ConvertToken(bodydescrip);
                    bodypropCount++;
                }

                if (bodyprice != null)
                {
                    body["price"] = SourceExpressionConverter.ConvertToken(bodyprice);
                    bodypropCount++;
                }

                if (bodycost != null)
                {
                    body["cost"] = SourceExpressionConverter.ConvertToken(bodycost);
                    bodypropCount++;
                }

                if (bodyvendor != null)
                {
                    body["vendor"] = SourceExpressionConverter.ConvertToken(bodyvendor);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<string[]> LeadGetValues()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Lead";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<JToken> LeadPostValue([WorkflowExpression] Func<string> bodysal = null, [WorkflowExpression] Func<string> bodyfirstname = null, [WorkflowExpression] Func<string> bodymiddlename = null, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodylastname = null, [WorkflowExpression] Func<string> bodycompany = null, [WorkflowExpression] Func<string> bodyaddr1 = null, [WorkflowExpression] Func<string> bodyaddr2 = null, [WorkflowExpression] Func<string> bodycity = null, [WorkflowExpression] Func<string> bodystate = null, [WorkflowExpression] Func<string> bodypostal = null, [WorkflowExpression] Func<string> bodyemail1 = null, [WorkflowExpression] Func<string> bodyemail2 = null, [WorkflowExpression] Func<string> bodyemail3 = null, [WorkflowExpression] Func<string> bodyemail4 = null, [WorkflowExpression] Func<string> bodyphonetype1 = null, [WorkflowExpression] Func<string> bodyphone1 = null, [WorkflowExpression] Func<string> bodyphonetype2 = null, [WorkflowExpression] Func<string> bodyphone2 = null, [WorkflowExpression] Func<string> bodyphonetype3 = null, [WorkflowExpression] Func<string> bodyphone3 = null, [WorkflowExpression] Func<string> bodyphonetype4 = null, [WorkflowExpression] Func<string> bodyphone4 = null, [WorkflowExpression] Func<string> bodyremark = null, [WorkflowExpression] Func<string> bodynotes = null, [WorkflowExpression] Func<string> bodycampaign = null, [WorkflowExpression] Func<string> bodycategory = null, [WorkflowExpression] Func<string> bodyrole = null, [WorkflowExpression] Func<string> bodymarket = null, [WorkflowExpression] Func<string> bodyterritory = null, [WorkflowExpression] Func<string> bodysalesrep = null, [WorkflowExpression] Func<string> bodylastcontact = null)
        {
            SourceExpression.Validate(bodysal, nameof(bodysal), required: false);
            SourceExpression.Validate(bodyfirstname, nameof(bodyfirstname), required: false);
            SourceExpression.Validate(bodymiddlename, nameof(bodymiddlename), required: false);
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            SourceExpression.Validate(bodylastname, nameof(bodylastname), required: false);
            SourceExpression.Validate(bodycompany, nameof(bodycompany), required: false);
            SourceExpression.Validate(bodyaddr1, nameof(bodyaddr1), required: false);
            SourceExpression.Validate(bodyaddr2, nameof(bodyaddr2), required: false);
            SourceExpression.Validate(bodycity, nameof(bodycity), required: false);
            SourceExpression.Validate(bodystate, nameof(bodystate), required: false);
            SourceExpression.Validate(bodypostal, nameof(bodypostal), required: false);
            SourceExpression.Validate(bodyemail1, nameof(bodyemail1), required: false);
            SourceExpression.Validate(bodyemail2, nameof(bodyemail2), required: false);
            SourceExpression.Validate(bodyemail3, nameof(bodyemail3), required: false);
            SourceExpression.Validate(bodyemail4, nameof(bodyemail4), required: false);
            SourceExpression.Validate(bodyphonetype1, nameof(bodyphonetype1), required: false);
            SourceExpression.Validate(bodyphone1, nameof(bodyphone1), required: false);
            SourceExpression.Validate(bodyphonetype2, nameof(bodyphonetype2), required: false);
            SourceExpression.Validate(bodyphone2, nameof(bodyphone2), required: false);
            SourceExpression.Validate(bodyphonetype3, nameof(bodyphonetype3), required: false);
            SourceExpression.Validate(bodyphone3, nameof(bodyphone3), required: false);
            SourceExpression.Validate(bodyphonetype4, nameof(bodyphonetype4), required: false);
            SourceExpression.Validate(bodyphone4, nameof(bodyphone4), required: false);
            SourceExpression.Validate(bodyremark, nameof(bodyremark), required: false);
            SourceExpression.Validate(bodynotes, nameof(bodynotes), required: false);
            SourceExpression.Validate(bodycampaign, nameof(bodycampaign), required: false);
            SourceExpression.Validate(bodycategory, nameof(bodycategory), required: false);
            SourceExpression.Validate(bodyrole, nameof(bodyrole), required: false);
            SourceExpression.Validate(bodymarket, nameof(bodymarket), required: false);
            SourceExpression.Validate(bodyterritory, nameof(bodyterritory), required: false);
            SourceExpression.Validate(bodysalesrep, nameof(bodysalesrep), required: false);
            SourceExpression.Validate(bodylastcontact, nameof(bodylastcontact), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Lead";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodysal != null)
                {
                    body["sal"] = SourceExpressionConverter.ConvertToken(bodysal);
                    bodypropCount++;
                }

                if (bodyfirstname != null)
                {
                    body["firstname"] = SourceExpressionConverter.ConvertToken(bodyfirstname);
                    bodypropCount++;
                }

                if (bodymiddlename != null)
                {
                    body["middlename"] = SourceExpressionConverter.ConvertToken(bodymiddlename);
                    bodypropCount++;
                }

                if (bodytitle != null)
                {
                    body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodylastname != null)
                {
                    body["lastname"] = SourceExpressionConverter.ConvertToken(bodylastname);
                    bodypropCount++;
                }

                if (bodycompany != null)
                {
                    body["company"] = SourceExpressionConverter.ConvertToken(bodycompany);
                    bodypropCount++;
                }

                if (bodyaddr1 != null)
                {
                    body["addr1"] = SourceExpressionConverter.ConvertToken(bodyaddr1);
                    bodypropCount++;
                }

                if (bodyaddr2 != null)
                {
                    body["addr2"] = SourceExpressionConverter.ConvertToken(bodyaddr2);
                    bodypropCount++;
                }

                if (bodycity != null)
                {
                    body["city"] = SourceExpressionConverter.ConvertToken(bodycity);
                    bodypropCount++;
                }

                if (bodystate != null)
                {
                    body["state"] = SourceExpressionConverter.ConvertToken(bodystate);
                    bodypropCount++;
                }

                if (bodypostal != null)
                {
                    body["postal"] = SourceExpressionConverter.ConvertToken(bodypostal);
                    bodypropCount++;
                }

                if (bodyemail1 != null)
                {
                    body["email1"] = SourceExpressionConverter.ConvertToken(bodyemail1);
                    bodypropCount++;
                }

                if (bodyemail2 != null)
                {
                    body["email2"] = SourceExpressionConverter.ConvertToken(bodyemail2);
                    bodypropCount++;
                }

                if (bodyemail3 != null)
                {
                    body["email3"] = SourceExpressionConverter.ConvertToken(bodyemail3);
                    bodypropCount++;
                }

                if (bodyemail4 != null)
                {
                    body["email4"] = SourceExpressionConverter.ConvertToken(bodyemail4);
                    bodypropCount++;
                }

                if (bodyphonetype1 != null)
                {
                    body["phonetype1"] = SourceExpressionConverter.ConvertToken(bodyphonetype1);
                    bodypropCount++;
                }

                if (bodyphone1 != null)
                {
                    body["phone1"] = SourceExpressionConverter.ConvertToken(bodyphone1);
                    bodypropCount++;
                }

                if (bodyphonetype2 != null)
                {
                    body["phonetype2"] = SourceExpressionConverter.ConvertToken(bodyphonetype2);
                    bodypropCount++;
                }

                if (bodyphone2 != null)
                {
                    body["phone2"] = SourceExpressionConverter.ConvertToken(bodyphone2);
                    bodypropCount++;
                }

                if (bodyphonetype3 != null)
                {
                    body["phonetype3"] = SourceExpressionConverter.ConvertToken(bodyphonetype3);
                    bodypropCount++;
                }

                if (bodyphone3 != null)
                {
                    body["phone3"] = SourceExpressionConverter.ConvertToken(bodyphone3);
                    bodypropCount++;
                }

                if (bodyphonetype4 != null)
                {
                    body["phonetype4"] = SourceExpressionConverter.ConvertToken(bodyphonetype4);
                    bodypropCount++;
                }

                if (bodyphone4 != null)
                {
                    body["phone4"] = SourceExpressionConverter.ConvertToken(bodyphone4);
                    bodypropCount++;
                }

                if (bodyremark != null)
                {
                    body["remark"] = SourceExpressionConverter.ConvertToken(bodyremark);
                    bodypropCount++;
                }

                if (bodynotes != null)
                {
                    body["notes"] = SourceExpressionConverter.ConvertToken(bodynotes);
                    bodypropCount++;
                }

                if (bodycampaign != null)
                {
                    body["campaign"] = SourceExpressionConverter.ConvertToken(bodycampaign);
                    bodypropCount++;
                }

                if (bodycategory != null)
                {
                    body["category"] = SourceExpressionConverter.ConvertToken(bodycategory);
                    bodypropCount++;
                }

                if (bodyrole != null)
                {
                    body["role"] = SourceExpressionConverter.ConvertToken(bodyrole);
                    bodypropCount++;
                }

                if (bodymarket != null)
                {
                    body["market"] = SourceExpressionConverter.ConvertToken(bodymarket);
                    bodypropCount++;
                }

                if (bodyterritory != null)
                {
                    body["territory"] = SourceExpressionConverter.ConvertToken(bodyterritory);
                    bodypropCount++;
                }

                if (bodysalesrep != null)
                {
                    body["salesrep"] = SourceExpressionConverter.ConvertToken(bodysalesrep);
                    bodypropCount++;
                }

                if (bodylastcontact != null)
                {
                    body["lastcontact"] = SourceExpressionConverter.ConvertToken(bodylastcontact);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<LeadGetValueResponse> LeadGetValue([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/Lead/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<LeadGetValueResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<JToken> LeadPutValue([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodysal = null, [WorkflowExpression] Func<string> bodyfirstname = null, [WorkflowExpression] Func<string> bodymiddlename = null, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodylastname = null, [WorkflowExpression] Func<string> bodycompany = null, [WorkflowExpression] Func<string> bodyaddr1 = null, [WorkflowExpression] Func<string> bodyaddr2 = null, [WorkflowExpression] Func<string> bodycity = null, [WorkflowExpression] Func<string> bodystate = null, [WorkflowExpression] Func<string> bodypostal = null, [WorkflowExpression] Func<string> bodyemail1 = null, [WorkflowExpression] Func<string> bodyemail2 = null, [WorkflowExpression] Func<string> bodyemail3 = null, [WorkflowExpression] Func<string> bodyemail4 = null, [WorkflowExpression] Func<string> bodyphonetype1 = null, [WorkflowExpression] Func<string> bodyphone1 = null, [WorkflowExpression] Func<string> bodyphonetype2 = null, [WorkflowExpression] Func<string> bodyphone2 = null, [WorkflowExpression] Func<string> bodyphonetype3 = null, [WorkflowExpression] Func<string> bodyphone3 = null, [WorkflowExpression] Func<string> bodyphonetype4 = null, [WorkflowExpression] Func<string> bodyphone4 = null, [WorkflowExpression] Func<string> bodyremark = null, [WorkflowExpression] Func<string> bodynotes = null, [WorkflowExpression] Func<string> bodycampaign = null, [WorkflowExpression] Func<string> bodycategory = null, [WorkflowExpression] Func<string> bodyrole = null, [WorkflowExpression] Func<string> bodymarket = null, [WorkflowExpression] Func<string> bodyterritory = null, [WorkflowExpression] Func<string> bodysalesrep = null, [WorkflowExpression] Func<string> bodylastcontact = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodysal, nameof(bodysal), required: false);
            SourceExpression.Validate(bodyfirstname, nameof(bodyfirstname), required: false);
            SourceExpression.Validate(bodymiddlename, nameof(bodymiddlename), required: false);
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            SourceExpression.Validate(bodylastname, nameof(bodylastname), required: false);
            SourceExpression.Validate(bodycompany, nameof(bodycompany), required: false);
            SourceExpression.Validate(bodyaddr1, nameof(bodyaddr1), required: false);
            SourceExpression.Validate(bodyaddr2, nameof(bodyaddr2), required: false);
            SourceExpression.Validate(bodycity, nameof(bodycity), required: false);
            SourceExpression.Validate(bodystate, nameof(bodystate), required: false);
            SourceExpression.Validate(bodypostal, nameof(bodypostal), required: false);
            SourceExpression.Validate(bodyemail1, nameof(bodyemail1), required: false);
            SourceExpression.Validate(bodyemail2, nameof(bodyemail2), required: false);
            SourceExpression.Validate(bodyemail3, nameof(bodyemail3), required: false);
            SourceExpression.Validate(bodyemail4, nameof(bodyemail4), required: false);
            SourceExpression.Validate(bodyphonetype1, nameof(bodyphonetype1), required: false);
            SourceExpression.Validate(bodyphone1, nameof(bodyphone1), required: false);
            SourceExpression.Validate(bodyphonetype2, nameof(bodyphonetype2), required: false);
            SourceExpression.Validate(bodyphone2, nameof(bodyphone2), required: false);
            SourceExpression.Validate(bodyphonetype3, nameof(bodyphonetype3), required: false);
            SourceExpression.Validate(bodyphone3, nameof(bodyphone3), required: false);
            SourceExpression.Validate(bodyphonetype4, nameof(bodyphonetype4), required: false);
            SourceExpression.Validate(bodyphone4, nameof(bodyphone4), required: false);
            SourceExpression.Validate(bodyremark, nameof(bodyremark), required: false);
            SourceExpression.Validate(bodynotes, nameof(bodynotes), required: false);
            SourceExpression.Validate(bodycampaign, nameof(bodycampaign), required: false);
            SourceExpression.Validate(bodycategory, nameof(bodycategory), required: false);
            SourceExpression.Validate(bodyrole, nameof(bodyrole), required: false);
            SourceExpression.Validate(bodymarket, nameof(bodymarket), required: false);
            SourceExpression.Validate(bodyterritory, nameof(bodyterritory), required: false);
            SourceExpression.Validate(bodysalesrep, nameof(bodysalesrep), required: false);
            SourceExpression.Validate(bodylastcontact, nameof(bodylastcontact), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/Lead/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodysal != null)
                {
                    body["sal"] = SourceExpressionConverter.ConvertToken(bodysal);
                    bodypropCount++;
                }

                if (bodyfirstname != null)
                {
                    body["firstname"] = SourceExpressionConverter.ConvertToken(bodyfirstname);
                    bodypropCount++;
                }

                if (bodymiddlename != null)
                {
                    body["middlename"] = SourceExpressionConverter.ConvertToken(bodymiddlename);
                    bodypropCount++;
                }

                if (bodytitle != null)
                {
                    body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodylastname != null)
                {
                    body["lastname"] = SourceExpressionConverter.ConvertToken(bodylastname);
                    bodypropCount++;
                }

                if (bodycompany != null)
                {
                    body["company"] = SourceExpressionConverter.ConvertToken(bodycompany);
                    bodypropCount++;
                }

                if (bodyaddr1 != null)
                {
                    body["addr1"] = SourceExpressionConverter.ConvertToken(bodyaddr1);
                    bodypropCount++;
                }

                if (bodyaddr2 != null)
                {
                    body["addr2"] = SourceExpressionConverter.ConvertToken(bodyaddr2);
                    bodypropCount++;
                }

                if (bodycity != null)
                {
                    body["city"] = SourceExpressionConverter.ConvertToken(bodycity);
                    bodypropCount++;
                }

                if (bodystate != null)
                {
                    body["state"] = SourceExpressionConverter.ConvertToken(bodystate);
                    bodypropCount++;
                }

                if (bodypostal != null)
                {
                    body["postal"] = SourceExpressionConverter.ConvertToken(bodypostal);
                    bodypropCount++;
                }

                if (bodyemail1 != null)
                {
                    body["email1"] = SourceExpressionConverter.ConvertToken(bodyemail1);
                    bodypropCount++;
                }

                if (bodyemail2 != null)
                {
                    body["email2"] = SourceExpressionConverter.ConvertToken(bodyemail2);
                    bodypropCount++;
                }

                if (bodyemail3 != null)
                {
                    body["email3"] = SourceExpressionConverter.ConvertToken(bodyemail3);
                    bodypropCount++;
                }

                if (bodyemail4 != null)
                {
                    body["email4"] = SourceExpressionConverter.ConvertToken(bodyemail4);
                    bodypropCount++;
                }

                if (bodyphonetype1 != null)
                {
                    body["phonetype1"] = SourceExpressionConverter.ConvertToken(bodyphonetype1);
                    bodypropCount++;
                }

                if (bodyphone1 != null)
                {
                    body["phone1"] = SourceExpressionConverter.ConvertToken(bodyphone1);
                    bodypropCount++;
                }

                if (bodyphonetype2 != null)
                {
                    body["phonetype2"] = SourceExpressionConverter.ConvertToken(bodyphonetype2);
                    bodypropCount++;
                }

                if (bodyphone2 != null)
                {
                    body["phone2"] = SourceExpressionConverter.ConvertToken(bodyphone2);
                    bodypropCount++;
                }

                if (bodyphonetype3 != null)
                {
                    body["phonetype3"] = SourceExpressionConverter.ConvertToken(bodyphonetype3);
                    bodypropCount++;
                }

                if (bodyphone3 != null)
                {
                    body["phone3"] = SourceExpressionConverter.ConvertToken(bodyphone3);
                    bodypropCount++;
                }

                if (bodyphonetype4 != null)
                {
                    body["phonetype4"] = SourceExpressionConverter.ConvertToken(bodyphonetype4);
                    bodypropCount++;
                }

                if (bodyphone4 != null)
                {
                    body["phone4"] = SourceExpressionConverter.ConvertToken(bodyphone4);
                    bodypropCount++;
                }

                if (bodyremark != null)
                {
                    body["remark"] = SourceExpressionConverter.ConvertToken(bodyremark);
                    bodypropCount++;
                }

                if (bodynotes != null)
                {
                    body["notes"] = SourceExpressionConverter.ConvertToken(bodynotes);
                    bodypropCount++;
                }

                if (bodycampaign != null)
                {
                    body["campaign"] = SourceExpressionConverter.ConvertToken(bodycampaign);
                    bodypropCount++;
                }

                if (bodycategory != null)
                {
                    body["category"] = SourceExpressionConverter.ConvertToken(bodycategory);
                    bodypropCount++;
                }

                if (bodyrole != null)
                {
                    body["role"] = SourceExpressionConverter.ConvertToken(bodyrole);
                    bodypropCount++;
                }

                if (bodymarket != null)
                {
                    body["market"] = SourceExpressionConverter.ConvertToken(bodymarket);
                    bodypropCount++;
                }

                if (bodyterritory != null)
                {
                    body["territory"] = SourceExpressionConverter.ConvertToken(bodyterritory);
                    bodypropCount++;
                }

                if (bodysalesrep != null)
                {
                    body["salesrep"] = SourceExpressionConverter.ConvertToken(bodysalesrep);
                    bodypropCount++;
                }

                if (bodylastcontact != null)
                {
                    body["lastcontact"] = SourceExpressionConverter.ConvertToken(bodylastcontact);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<string[]> MembersGetValues([WorkflowExpression] Func<typeInput> type)
        {
            SourceExpression.Validate(type, nameof(type), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Members";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["type"] = SourceExpressionConverter.Convert(type);
                return callPayload;
            }

            return new ApiConnectionAction<string[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<JToken> MembersPostValue([WorkflowExpression] Func<string> bodypromoid = null, [WorkflowExpression] Func<bodyrecordtypeInput> bodyrecordtype = null, [WorkflowExpression] Func<string> bodyrecordid = null)
        {
            SourceExpression.Validate(bodypromoid, nameof(bodypromoid), required: false);
            SourceExpression.Validate(bodyrecordtype, nameof(bodyrecordtype), required: false);
            SourceExpression.Validate(bodyrecordid, nameof(bodyrecordid), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Members";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypromoid != null)
                {
                    body["promoid"] = SourceExpressionConverter.ConvertToken(bodypromoid);
                    bodypropCount++;
                }

                if (bodyrecordtype != null)
                {
                    body["recordtype"] = SourceExpressionConverter.Convert(bodyrecordtype);
                    bodypropCount++;
                }

                if (bodyrecordid != null)
                {
                    body["recordid"] = SourceExpressionConverter.ConvertToken(bodyrecordid);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<MembersGetValueResponse> MembersGetValue([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/Members/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<MembersGetValueResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<JToken> MembersPutValue([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<bodyoperationInput> bodyoperation = null, [WorkflowExpression] Func<bodyrecordtypeInput> bodyrecordtype = null, [WorkflowExpression] Func<string> bodypromoid = null, [WorkflowExpression] Func<string> bodyrecordid = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodyoperation, nameof(bodyoperation), required: false);
            SourceExpression.Validate(bodyrecordtype, nameof(bodyrecordtype), required: false);
            SourceExpression.Validate(bodypromoid, nameof(bodypromoid), required: false);
            SourceExpression.Validate(bodyrecordid, nameof(bodyrecordid), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/Members/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyoperation != null)
                {
                    body["operation"] = SourceExpressionConverter.Convert(bodyoperation);
                    bodypropCount++;
                }

                if (bodyrecordtype != null)
                {
                    body["recordtype"] = SourceExpressionConverter.Convert(bodyrecordtype);
                    bodypropCount++;
                }

                if (bodypromoid != null)
                {
                    body["promoid"] = SourceExpressionConverter.ConvertToken(bodypromoid);
                    bodypropCount++;
                }

                if (bodyrecordid != null)
                {
                    body["recordid"] = SourceExpressionConverter.ConvertToken(bodyrecordid);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<string[]> ShippingGetValues()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Shipping";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<JToken> ShippingPostValue([WorkflowExpression] Func<string> bodyorderid = null, [WorkflowExpression] Func<string> bodyshipdate = null, [WorkflowExpression] Func<string> bodycarrier = null, [WorkflowExpression] Func<string> bodymethod = null, [WorkflowExpression] Func<double> bodyweight = null, [WorkflowExpression] Func<string> bodypackagetype = null, [WorkflowExpression] Func<string> bodyreference1 = null, [WorkflowExpression] Func<string> bodyreference2 = null, [WorkflowExpression] Func<string> bodytrackingnumber = null, [WorkflowExpression] Func<string> bodytrackingurl = null, [WorkflowExpression] Func<double> bodyshippingcost = null, [WorkflowExpression] Func<bool> bodytohistory = null)
        {
            SourceExpression.Validate(bodyorderid, nameof(bodyorderid), required: false);
            SourceExpression.Validate(bodyshipdate, nameof(bodyshipdate), required: false);
            SourceExpression.Validate(bodycarrier, nameof(bodycarrier), required: false);
            SourceExpression.Validate(bodymethod, nameof(bodymethod), required: false);
            SourceExpression.Validate(bodyweight, nameof(bodyweight), required: false);
            SourceExpression.Validate(bodypackagetype, nameof(bodypackagetype), required: false);
            SourceExpression.Validate(bodyreference1, nameof(bodyreference1), required: false);
            SourceExpression.Validate(bodyreference2, nameof(bodyreference2), required: false);
            SourceExpression.Validate(bodytrackingnumber, nameof(bodytrackingnumber), required: false);
            SourceExpression.Validate(bodytrackingurl, nameof(bodytrackingurl), required: false);
            SourceExpression.Validate(bodyshippingcost, nameof(bodyshippingcost), required: false);
            SourceExpression.Validate(bodytohistory, nameof(bodytohistory), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Shipping";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyorderid != null)
                {
                    body["orderid"] = SourceExpressionConverter.ConvertToken(bodyorderid);
                    bodypropCount++;
                }

                if (bodyshipdate != null)
                {
                    body["shipdate"] = SourceExpressionConverter.ConvertToken(bodyshipdate);
                    bodypropCount++;
                }

                if (bodycarrier != null)
                {
                    body["carrier"] = SourceExpressionConverter.ConvertToken(bodycarrier);
                    bodypropCount++;
                }

                if (bodymethod != null)
                {
                    body["method"] = SourceExpressionConverter.ConvertToken(bodymethod);
                    bodypropCount++;
                }

                if (bodyweight != null)
                {
                    body["weight"] = SourceExpressionConverter.ConvertToken(bodyweight);
                    bodypropCount++;
                }

                if (bodypackagetype != null)
                {
                    body["packagetype"] = SourceExpressionConverter.ConvertToken(bodypackagetype);
                    bodypropCount++;
                }

                if (bodyreference1 != null)
                {
                    body["reference1"] = SourceExpressionConverter.ConvertToken(bodyreference1);
                    bodypropCount++;
                }

                if (bodyreference2 != null)
                {
                    body["reference2"] = SourceExpressionConverter.ConvertToken(bodyreference2);
                    bodypropCount++;
                }

                if (bodytrackingnumber != null)
                {
                    body["trackingnumber"] = SourceExpressionConverter.ConvertToken(bodytrackingnumber);
                    bodypropCount++;
                }

                if (bodytrackingurl != null)
                {
                    body["trackingurl"] = SourceExpressionConverter.ConvertToken(bodytrackingurl);
                    bodypropCount++;
                }

                if (bodyshippingcost != null)
                {
                    body["shippingcost"] = SourceExpressionConverter.ConvertToken(bodyshippingcost);
                    bodypropCount++;
                }

                if (bodytohistory != null)
                {
                    body["tohistory"] = SourceExpressionConverter.ConvertToken(bodytohistory);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<ShippingGetValueResponse> ShippingGetValue([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/Shipping/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ShippingGetValueResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IWorkflowAction ShippingPutValue([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyshipdate = null, [WorkflowExpression] Func<string> bodycarrier = null, [WorkflowExpression] Func<string> bodymethod = null, [WorkflowExpression] Func<double> bodyweight = null, [WorkflowExpression] Func<string> bodypackagetype = null, [WorkflowExpression] Func<string> bodyreference1 = null, [WorkflowExpression] Func<string> bodyreference2 = null, [WorkflowExpression] Func<string> bodytrackingnumber = null, [WorkflowExpression] Func<string> bodytrackingurl = null, [WorkflowExpression] Func<double> bodyshippingcost = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodyshipdate, nameof(bodyshipdate), required: false);
            SourceExpression.Validate(bodycarrier, nameof(bodycarrier), required: false);
            SourceExpression.Validate(bodymethod, nameof(bodymethod), required: false);
            SourceExpression.Validate(bodyweight, nameof(bodyweight), required: false);
            SourceExpression.Validate(bodypackagetype, nameof(bodypackagetype), required: false);
            SourceExpression.Validate(bodyreference1, nameof(bodyreference1), required: false);
            SourceExpression.Validate(bodyreference2, nameof(bodyreference2), required: false);
            SourceExpression.Validate(bodytrackingnumber, nameof(bodytrackingnumber), required: false);
            SourceExpression.Validate(bodytrackingurl, nameof(bodytrackingurl), required: false);
            SourceExpression.Validate(bodyshippingcost, nameof(bodyshippingcost), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/Shipping/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyshipdate != null)
                {
                    body["shipdate"] = SourceExpressionConverter.ConvertToken(bodyshipdate);
                    bodypropCount++;
                }

                if (bodycarrier != null)
                {
                    body["carrier"] = SourceExpressionConverter.ConvertToken(bodycarrier);
                    bodypropCount++;
                }

                if (bodymethod != null)
                {
                    body["method"] = SourceExpressionConverter.ConvertToken(bodymethod);
                    bodypropCount++;
                }

                if (bodyweight != null)
                {
                    body["weight"] = SourceExpressionConverter.ConvertToken(bodyweight);
                    bodypropCount++;
                }

                if (bodypackagetype != null)
                {
                    body["packagetype"] = SourceExpressionConverter.ConvertToken(bodypackagetype);
                    bodypropCount++;
                }

                if (bodyreference1 != null)
                {
                    body["reference1"] = SourceExpressionConverter.ConvertToken(bodyreference1);
                    bodypropCount++;
                }

                if (bodyreference2 != null)
                {
                    body["reference2"] = SourceExpressionConverter.ConvertToken(bodyreference2);
                    bodypropCount++;
                }

                if (bodytrackingnumber != null)
                {
                    body["trackingnumber"] = SourceExpressionConverter.ConvertToken(bodytrackingnumber);
                    bodypropCount++;
                }

                if (bodytrackingurl != null)
                {
                    body["trackingurl"] = SourceExpressionConverter.ConvertToken(bodytrackingurl);
                    bodypropCount++;
                }

                if (bodyshippingcost != null)
                {
                    body["shippingcost"] = SourceExpressionConverter.ConvertToken(bodyshippingcost);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<string[]> SOGetValues()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/SO";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<JToken> SOPostValue([WorkflowExpression] Func<string> bodyorderid = null, [WorkflowExpression] Func<string> bodyorderdate = null, [WorkflowExpression] Func<string> bodyorderdescription = null, [WorkflowExpression] Func<string> bodyaccount = null, [WorkflowExpression] Func<string> bodyaccountname = null, [WorkflowExpression] Func<string> bodysalesrep = null, [WorkflowExpression] Func<string> bodyfirstname = null, [WorkflowExpression] Func<string> bodylastname = null, [WorkflowExpression] Func<string> bodybillemail = null, [WorkflowExpression] Func<string> bodybilladdr1 = null, [WorkflowExpression] Func<string> bodybilladdr2 = null, [WorkflowExpression] Func<string> bodybillcity = null, [WorkflowExpression] Func<string> bodybillstate = null, [WorkflowExpression] Func<string> bodybillzipcode = null, [WorkflowExpression] Func<string> bodybillcountry = null, [WorkflowExpression] Func<string> bodybillphone = null, [WorkflowExpression] Func<string> bodybillfax = null, [WorkflowExpression] Func<string> bodyshipcompany = null, [WorkflowExpression] Func<string> bodyshipcontact = null, [WorkflowExpression] Func<string> bodyshipaddr1 = null, [WorkflowExpression] Func<string> bodyshipaddr2 = null, [WorkflowExpression] Func<string> bodyshipcity = null, [WorkflowExpression] Func<string> bodyshipstate = null, [WorkflowExpression] Func<string> bodyshipzipcode = null, [WorkflowExpression] Func<string> bodyshipcountry = null, [WorkflowExpression] Func<string> bodyshipphone = null, [WorkflowExpression] Func<string> bodyshipemail = null, [WorkflowExpression] Func<bodyorderstatusInput> bodyorderstatus = null, [WorkflowExpression] Func<string> bodycustomstatus = null, [WorkflowExpression] Func<string> bodytaxdistrict = null, [WorkflowExpression] Func<double> bodytaxrate = null, [WorkflowExpression] Func<string> bodycampaign = null, [WorkflowExpression] Func<string> bodyordertax = null, [WorkflowExpression] Func<string> bodyshippingcost = null, [WorkflowExpression] Func<string> bodyshippingmethod = null, [WorkflowExpression] Func<double> bodycouponamount = null, [WorkflowExpression] Func<string> bodycouponcode = null, [WorkflowExpression] Func<string> bodypaymentmethod = null, [WorkflowExpression] Func<string> bodycomments = null, [WorkflowExpression] Func<bodylinedataInputItem[]> bodylinedata = null)
        {
            SourceExpression.Validate(bodyorderid, nameof(bodyorderid), required: false);
            SourceExpression.Validate(bodyorderdate, nameof(bodyorderdate), required: false);
            SourceExpression.Validate(bodyorderdescription, nameof(bodyorderdescription), required: false);
            SourceExpression.Validate(bodyaccount, nameof(bodyaccount), required: false);
            SourceExpression.Validate(bodyaccountname, nameof(bodyaccountname), required: false);
            SourceExpression.Validate(bodysalesrep, nameof(bodysalesrep), required: false);
            SourceExpression.Validate(bodyfirstname, nameof(bodyfirstname), required: false);
            SourceExpression.Validate(bodylastname, nameof(bodylastname), required: false);
            SourceExpression.Validate(bodybillemail, nameof(bodybillemail), required: false);
            SourceExpression.Validate(bodybilladdr1, nameof(bodybilladdr1), required: false);
            SourceExpression.Validate(bodybilladdr2, nameof(bodybilladdr2), required: false);
            SourceExpression.Validate(bodybillcity, nameof(bodybillcity), required: false);
            SourceExpression.Validate(bodybillstate, nameof(bodybillstate), required: false);
            SourceExpression.Validate(bodybillzipcode, nameof(bodybillzipcode), required: false);
            SourceExpression.Validate(bodybillcountry, nameof(bodybillcountry), required: false);
            SourceExpression.Validate(bodybillphone, nameof(bodybillphone), required: false);
            SourceExpression.Validate(bodybillfax, nameof(bodybillfax), required: false);
            SourceExpression.Validate(bodyshipcompany, nameof(bodyshipcompany), required: false);
            SourceExpression.Validate(bodyshipcontact, nameof(bodyshipcontact), required: false);
            SourceExpression.Validate(bodyshipaddr1, nameof(bodyshipaddr1), required: false);
            SourceExpression.Validate(bodyshipaddr2, nameof(bodyshipaddr2), required: false);
            SourceExpression.Validate(bodyshipcity, nameof(bodyshipcity), required: false);
            SourceExpression.Validate(bodyshipstate, nameof(bodyshipstate), required: false);
            SourceExpression.Validate(bodyshipzipcode, nameof(bodyshipzipcode), required: false);
            SourceExpression.Validate(bodyshipcountry, nameof(bodyshipcountry), required: false);
            SourceExpression.Validate(bodyshipphone, nameof(bodyshipphone), required: false);
            SourceExpression.Validate(bodyshipemail, nameof(bodyshipemail), required: false);
            SourceExpression.Validate(bodyorderstatus, nameof(bodyorderstatus), required: false);
            SourceExpression.Validate(bodycustomstatus, nameof(bodycustomstatus), required: false);
            SourceExpression.Validate(bodytaxdistrict, nameof(bodytaxdistrict), required: false);
            SourceExpression.Validate(bodytaxrate, nameof(bodytaxrate), required: false);
            SourceExpression.Validate(bodycampaign, nameof(bodycampaign), required: false);
            SourceExpression.Validate(bodyordertax, nameof(bodyordertax), required: false);
            SourceExpression.Validate(bodyshippingcost, nameof(bodyshippingcost), required: false);
            SourceExpression.Validate(bodyshippingmethod, nameof(bodyshippingmethod), required: false);
            SourceExpression.Validate(bodycouponamount, nameof(bodycouponamount), required: false);
            SourceExpression.Validate(bodycouponcode, nameof(bodycouponcode), required: false);
            SourceExpression.Validate(bodypaymentmethod, nameof(bodypaymentmethod), required: false);
            SourceExpression.Validate(bodycomments, nameof(bodycomments), required: false);
            SourceExpression.Validate(bodylinedata, nameof(bodylinedata), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/SO";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyorderid != null)
                {
                    body["orderid"] = SourceExpressionConverter.ConvertToken(bodyorderid);
                    bodypropCount++;
                }

                if (bodyorderdate != null)
                {
                    body["orderdate"] = SourceExpressionConverter.ConvertToken(bodyorderdate);
                    bodypropCount++;
                }

                if (bodyorderdescription != null)
                {
                    body["orderdescription"] = SourceExpressionConverter.ConvertToken(bodyorderdescription);
                    bodypropCount++;
                }

                if (bodyaccount != null)
                {
                    body["account"] = SourceExpressionConverter.ConvertToken(bodyaccount);
                    bodypropCount++;
                }

                if (bodyaccountname != null)
                {
                    body["accountname"] = SourceExpressionConverter.ConvertToken(bodyaccountname);
                    bodypropCount++;
                }

                if (bodysalesrep != null)
                {
                    body["salesrep"] = SourceExpressionConverter.ConvertToken(bodysalesrep);
                    bodypropCount++;
                }

                if (bodyfirstname != null)
                {
                    body["firstname"] = SourceExpressionConverter.ConvertToken(bodyfirstname);
                    bodypropCount++;
                }

                if (bodylastname != null)
                {
                    body["lastname"] = SourceExpressionConverter.ConvertToken(bodylastname);
                    bodypropCount++;
                }

                if (bodybillemail != null)
                {
                    body["billemail"] = SourceExpressionConverter.ConvertToken(bodybillemail);
                    bodypropCount++;
                }

                if (bodybilladdr1 != null)
                {
                    body["billaddr1"] = SourceExpressionConverter.ConvertToken(bodybilladdr1);
                    bodypropCount++;
                }

                if (bodybilladdr2 != null)
                {
                    body["billaddr2"] = SourceExpressionConverter.ConvertToken(bodybilladdr2);
                    bodypropCount++;
                }

                if (bodybillcity != null)
                {
                    body["billcity"] = SourceExpressionConverter.ConvertToken(bodybillcity);
                    bodypropCount++;
                }

                if (bodybillstate != null)
                {
                    body["billstate"] = SourceExpressionConverter.ConvertToken(bodybillstate);
                    bodypropCount++;
                }

                if (bodybillzipcode != null)
                {
                    body["billzipcode"] = SourceExpressionConverter.ConvertToken(bodybillzipcode);
                    bodypropCount++;
                }

                if (bodybillcountry != null)
                {
                    body["billcountry"] = SourceExpressionConverter.ConvertToken(bodybillcountry);
                    bodypropCount++;
                }

                if (bodybillphone != null)
                {
                    body["billphone"] = SourceExpressionConverter.ConvertToken(bodybillphone);
                    bodypropCount++;
                }

                if (bodybillfax != null)
                {
                    body["billfax"] = SourceExpressionConverter.ConvertToken(bodybillfax);
                    bodypropCount++;
                }

                if (bodyshipcompany != null)
                {
                    body["shipcompany"] = SourceExpressionConverter.ConvertToken(bodyshipcompany);
                    bodypropCount++;
                }

                if (bodyshipcontact != null)
                {
                    body["shipcontact"] = SourceExpressionConverter.ConvertToken(bodyshipcontact);
                    bodypropCount++;
                }

                if (bodyshipaddr1 != null)
                {
                    body["shipaddr1"] = SourceExpressionConverter.ConvertToken(bodyshipaddr1);
                    bodypropCount++;
                }

                if (bodyshipaddr2 != null)
                {
                    body["shipaddr2"] = SourceExpressionConverter.ConvertToken(bodyshipaddr2);
                    bodypropCount++;
                }

                if (bodyshipcity != null)
                {
                    body["shipcity"] = SourceExpressionConverter.ConvertToken(bodyshipcity);
                    bodypropCount++;
                }

                if (bodyshipstate != null)
                {
                    body["shipstate"] = SourceExpressionConverter.ConvertToken(bodyshipstate);
                    bodypropCount++;
                }

                if (bodyshipzipcode != null)
                {
                    body["shipzipcode"] = SourceExpressionConverter.ConvertToken(bodyshipzipcode);
                    bodypropCount++;
                }

                if (bodyshipcountry != null)
                {
                    body["shipcountry"] = SourceExpressionConverter.ConvertToken(bodyshipcountry);
                    bodypropCount++;
                }

                if (bodyshipphone != null)
                {
                    body["shipphone"] = SourceExpressionConverter.ConvertToken(bodyshipphone);
                    bodypropCount++;
                }

                if (bodyshipemail != null)
                {
                    body["shipemail"] = SourceExpressionConverter.ConvertToken(bodyshipemail);
                    bodypropCount++;
                }

                if (bodyorderstatus != null)
                {
                    body["orderstatus"] = SourceExpressionConverter.Convert(bodyorderstatus);
                    bodypropCount++;
                }

                if (bodycustomstatus != null)
                {
                    body["customstatus"] = SourceExpressionConverter.ConvertToken(bodycustomstatus);
                    bodypropCount++;
                }

                if (bodytaxdistrict != null)
                {
                    body["taxdistrict"] = SourceExpressionConverter.ConvertToken(bodytaxdistrict);
                    bodypropCount++;
                }

                if (bodytaxrate != null)
                {
                    body["taxrate"] = SourceExpressionConverter.ConvertToken(bodytaxrate);
                    bodypropCount++;
                }

                if (bodycampaign != null)
                {
                    body["campaign"] = SourceExpressionConverter.ConvertToken(bodycampaign);
                    bodypropCount++;
                }

                if (bodyordertax != null)
                {
                    body["ordertax"] = SourceExpressionConverter.ConvertToken(bodyordertax);
                    bodypropCount++;
                }

                if (bodyshippingcost != null)
                {
                    body["shippingcost"] = SourceExpressionConverter.ConvertToken(bodyshippingcost);
                    bodypropCount++;
                }

                if (bodyshippingmethod != null)
                {
                    body["shippingmethod"] = SourceExpressionConverter.ConvertToken(bodyshippingmethod);
                    bodypropCount++;
                }

                if (bodycouponamount != null)
                {
                    body["couponamount"] = SourceExpressionConverter.ConvertToken(bodycouponamount);
                    bodypropCount++;
                }

                if (bodycouponcode != null)
                {
                    body["couponcode"] = SourceExpressionConverter.ConvertToken(bodycouponcode);
                    bodypropCount++;
                }

                if (bodypaymentmethod != null)
                {
                    body["paymentmethod"] = SourceExpressionConverter.ConvertToken(bodypaymentmethod);
                    bodypropCount++;
                }

                if (bodycomments != null)
                {
                    body["comments"] = SourceExpressionConverter.ConvertToken(bodycomments);
                    bodypropCount++;
                }

                if (bodylinedata != null)
                {
                    body["linedata"] = SourceExpressionConverter.ConvertToken(bodylinedata);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<SOGetValueResponse> SOGetValue([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/SO/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<SOGetValueResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IWorkflowAction SOPutValue([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodycomments = null, [WorkflowExpression] Func<string> bodycustomstatus = null, [WorkflowExpression] Func<bodyorderstatusInput> bodyorderstatus = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodycomments, nameof(bodycomments), required: false);
            SourceExpression.Validate(bodycustomstatus, nameof(bodycustomstatus), required: false);
            SourceExpression.Validate(bodyorderstatus, nameof(bodyorderstatus), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/SO/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycomments != null)
                {
                    body["comments"] = SourceExpressionConverter.ConvertToken(bodycomments);
                    bodypropCount++;
                }

                if (bodycustomstatus != null)
                {
                    body["customstatus"] = SourceExpressionConverter.ConvertToken(bodycustomstatus);
                    bodypropCount++;
                }

                if (bodyorderstatus != null)
                {
                    body["orderstatus"] = SourceExpressionConverter.Convert(bodyorderstatus);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<string[]> WorkOrderGetValues()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/WorkOrder";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<JToken> WorkOrderPostValue([WorkflowExpression] Func<string> bodyfromaddress = null, [WorkflowExpression] Func<string> bodyfirstname = null, [WorkflowExpression] Func<string> bodylastname = null, [WorkflowExpression] Func<string> bodycompanyname = null, [WorkflowExpression] Func<string> bodybilladdr1 = null, [WorkflowExpression] Func<string> bodybilladdr2 = null, [WorkflowExpression] Func<string> bodybillcity = null, [WorkflowExpression] Func<string> bodybillstate = null, [WorkflowExpression] Func<string> bodybillzipcode = null, [WorkflowExpression] Func<string> bodybillcountry = null, [WorkflowExpression] Func<string> bodybillphone = null, [WorkflowExpression] Func<string> bodybillfax = null, [WorkflowExpression] Func<string> bodyserviceaddr1 = null, [WorkflowExpression] Func<string> bodyserviceaddr2 = null, [WorkflowExpression] Func<string> bodyservicecity = null, [WorkflowExpression] Func<string> bodyservicestate = null, [WorkflowExpression] Func<string> bodyservicezipcode = null, [WorkflowExpression] Func<string> bodyservicecountry = null, [WorkflowExpression] Func<string> bodyservicephone = null, [WorkflowExpression] Func<string> bodyreceiveddate = null, [WorkflowExpression] Func<string> bodyponumber = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<string> bodyreasoncode = null, [WorkflowExpression] Func<string> bodysource = null, [WorkflowExpression] Func<string> bodyassignedto = null, [WorkflowExpression] Func<string> bodybackup = null, [WorkflowExpression] Func<bodypriorityInput> bodypriority = null, [WorkflowExpression] Func<string> bodyduedate = null, [WorkflowExpression] Func<string> bodysubject = null, [WorkflowExpression] Func<string> bodybody = null)
        {
            SourceExpression.Validate(bodyfromaddress, nameof(bodyfromaddress), required: false);
            SourceExpression.Validate(bodyfirstname, nameof(bodyfirstname), required: false);
            SourceExpression.Validate(bodylastname, nameof(bodylastname), required: false);
            SourceExpression.Validate(bodycompanyname, nameof(bodycompanyname), required: false);
            SourceExpression.Validate(bodybilladdr1, nameof(bodybilladdr1), required: false);
            SourceExpression.Validate(bodybilladdr2, nameof(bodybilladdr2), required: false);
            SourceExpression.Validate(bodybillcity, nameof(bodybillcity), required: false);
            SourceExpression.Validate(bodybillstate, nameof(bodybillstate), required: false);
            SourceExpression.Validate(bodybillzipcode, nameof(bodybillzipcode), required: false);
            SourceExpression.Validate(bodybillcountry, nameof(bodybillcountry), required: false);
            SourceExpression.Validate(bodybillphone, nameof(bodybillphone), required: false);
            SourceExpression.Validate(bodybillfax, nameof(bodybillfax), required: false);
            SourceExpression.Validate(bodyserviceaddr1, nameof(bodyserviceaddr1), required: false);
            SourceExpression.Validate(bodyserviceaddr2, nameof(bodyserviceaddr2), required: false);
            SourceExpression.Validate(bodyservicecity, nameof(bodyservicecity), required: false);
            SourceExpression.Validate(bodyservicestate, nameof(bodyservicestate), required: false);
            SourceExpression.Validate(bodyservicezipcode, nameof(bodyservicezipcode), required: false);
            SourceExpression.Validate(bodyservicecountry, nameof(bodyservicecountry), required: false);
            SourceExpression.Validate(bodyservicephone, nameof(bodyservicephone), required: false);
            SourceExpression.Validate(bodyreceiveddate, nameof(bodyreceiveddate), required: false);
            SourceExpression.Validate(bodyponumber, nameof(bodyponumber), required: false);
            SourceExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            SourceExpression.Validate(bodyreasoncode, nameof(bodyreasoncode), required: false);
            SourceExpression.Validate(bodysource, nameof(bodysource), required: false);
            SourceExpression.Validate(bodyassignedto, nameof(bodyassignedto), required: false);
            SourceExpression.Validate(bodybackup, nameof(bodybackup), required: false);
            SourceExpression.Validate(bodypriority, nameof(bodypriority), required: false);
            SourceExpression.Validate(bodyduedate, nameof(bodyduedate), required: false);
            SourceExpression.Validate(bodysubject, nameof(bodysubject), required: false);
            SourceExpression.Validate(bodybody, nameof(bodybody), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/WorkOrder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfromaddress != null)
                {
                    body["fromaddress"] = SourceExpressionConverter.ConvertToken(bodyfromaddress);
                    bodypropCount++;
                }

                if (bodyfirstname != null)
                {
                    body["firstname"] = SourceExpressionConverter.ConvertToken(bodyfirstname);
                    bodypropCount++;
                }

                if (bodylastname != null)
                {
                    body["lastname"] = SourceExpressionConverter.ConvertToken(bodylastname);
                    bodypropCount++;
                }

                if (bodycompanyname != null)
                {
                    body["companyname"] = SourceExpressionConverter.ConvertToken(bodycompanyname);
                    bodypropCount++;
                }

                if (bodybilladdr1 != null)
                {
                    body["billaddr1"] = SourceExpressionConverter.ConvertToken(bodybilladdr1);
                    bodypropCount++;
                }

                if (bodybilladdr2 != null)
                {
                    body["billaddr2"] = SourceExpressionConverter.ConvertToken(bodybilladdr2);
                    bodypropCount++;
                }

                if (bodybillcity != null)
                {
                    body["billcity"] = SourceExpressionConverter.ConvertToken(bodybillcity);
                    bodypropCount++;
                }

                if (bodybillstate != null)
                {
                    body["billstate"] = SourceExpressionConverter.ConvertToken(bodybillstate);
                    bodypropCount++;
                }

                if (bodybillzipcode != null)
                {
                    body["billzipcode"] = SourceExpressionConverter.ConvertToken(bodybillzipcode);
                    bodypropCount++;
                }

                if (bodybillcountry != null)
                {
                    body["billcountry"] = SourceExpressionConverter.ConvertToken(bodybillcountry);
                    bodypropCount++;
                }

                if (bodybillphone != null)
                {
                    body["billphone"] = SourceExpressionConverter.ConvertToken(bodybillphone);
                    bodypropCount++;
                }

                if (bodybillfax != null)
                {
                    body["billfax"] = SourceExpressionConverter.ConvertToken(bodybillfax);
                    bodypropCount++;
                }

                if (bodyserviceaddr1 != null)
                {
                    body["serviceaddr1"] = SourceExpressionConverter.ConvertToken(bodyserviceaddr1);
                    bodypropCount++;
                }

                if (bodyserviceaddr2 != null)
                {
                    body["serviceaddr2"] = SourceExpressionConverter.ConvertToken(bodyserviceaddr2);
                    bodypropCount++;
                }

                if (bodyservicecity != null)
                {
                    body["servicecity"] = SourceExpressionConverter.ConvertToken(bodyservicecity);
                    bodypropCount++;
                }

                if (bodyservicestate != null)
                {
                    body["servicestate"] = SourceExpressionConverter.ConvertToken(bodyservicestate);
                    bodypropCount++;
                }

                if (bodyservicezipcode != null)
                {
                    body["servicezipcode"] = SourceExpressionConverter.ConvertToken(bodyservicezipcode);
                    bodypropCount++;
                }

                if (bodyservicecountry != null)
                {
                    body["servicecountry"] = SourceExpressionConverter.ConvertToken(bodyservicecountry);
                    bodypropCount++;
                }

                if (bodyservicephone != null)
                {
                    body["servicephone"] = SourceExpressionConverter.ConvertToken(bodyservicephone);
                    bodypropCount++;
                }

                if (bodyreceiveddate != null)
                {
                    body["receiveddate"] = SourceExpressionConverter.ConvertToken(bodyreceiveddate);
                    bodypropCount++;
                }

                if (bodyponumber != null)
                {
                    body["ponumber"] = SourceExpressionConverter.ConvertToken(bodyponumber);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                if (bodyreasoncode != null)
                {
                    body["reasoncode"] = SourceExpressionConverter.ConvertToken(bodyreasoncode);
                    bodypropCount++;
                }

                if (bodysource != null)
                {
                    body["source"] = SourceExpressionConverter.ConvertToken(bodysource);
                    bodypropCount++;
                }

                if (bodyassignedto != null)
                {
                    body["assignedto"] = SourceExpressionConverter.ConvertToken(bodyassignedto);
                    bodypropCount++;
                }

                if (bodybackup != null)
                {
                    body["backup"] = SourceExpressionConverter.ConvertToken(bodybackup);
                    bodypropCount++;
                }

                if (bodypriority != null)
                {
                    body["priority"] = SourceExpressionConverter.Convert(bodypriority);
                    bodypropCount++;
                }

                if (bodyduedate != null)
                {
                    body["duedate"] = SourceExpressionConverter.ConvertToken(bodyduedate);
                    bodypropCount++;
                }

                if (bodysubject != null)
                {
                    body["subject"] = SourceExpressionConverter.ConvertToken(bodysubject);
                    bodypropCount++;
                }

                if (bodybody != null)
                {
                    body["body"] = SourceExpressionConverter.ConvertToken(bodybody);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<WorkOrderGetValueResponse> WorkOrderGetValue([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/WorkOrder/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<WorkOrderGetValueResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IWorkflowAction WorkOrderPutValue([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyponumber = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<string> bodyreasoncode = null, [WorkflowExpression] Func<string> bodysource = null, [WorkflowExpression] Func<string> bodyassignedto = null, [WorkflowExpression] Func<string> bodybackup = null, [WorkflowExpression] Func<bodypriorityInput> bodypriority = null, [WorkflowExpression] Func<string> bodyduedate = null, [WorkflowExpression] Func<string> bodysubject = null, [WorkflowExpression] Func<string> bodybody = null, [WorkflowExpression] Func<bool> bodyhistory = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodyponumber, nameof(bodyponumber), required: false);
            SourceExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            SourceExpression.Validate(bodyreasoncode, nameof(bodyreasoncode), required: false);
            SourceExpression.Validate(bodysource, nameof(bodysource), required: false);
            SourceExpression.Validate(bodyassignedto, nameof(bodyassignedto), required: false);
            SourceExpression.Validate(bodybackup, nameof(bodybackup), required: false);
            SourceExpression.Validate(bodypriority, nameof(bodypriority), required: false);
            SourceExpression.Validate(bodyduedate, nameof(bodyduedate), required: false);
            SourceExpression.Validate(bodysubject, nameof(bodysubject), required: false);
            SourceExpression.Validate(bodybody, nameof(bodybody), required: false);
            SourceExpression.Validate(bodyhistory, nameof(bodyhistory), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/WorkOrder/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyponumber != null)
                {
                    body["ponumber"] = SourceExpressionConverter.ConvertToken(bodyponumber);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                if (bodyreasoncode != null)
                {
                    body["reasoncode"] = SourceExpressionConverter.ConvertToken(bodyreasoncode);
                    bodypropCount++;
                }

                if (bodysource != null)
                {
                    body["source"] = SourceExpressionConverter.ConvertToken(bodysource);
                    bodypropCount++;
                }

                if (bodyassignedto != null)
                {
                    body["assignedto"] = SourceExpressionConverter.ConvertToken(bodyassignedto);
                    bodypropCount++;
                }

                if (bodybackup != null)
                {
                    body["backup"] = SourceExpressionConverter.ConvertToken(bodybackup);
                    bodypropCount++;
                }

                if (bodypriority != null)
                {
                    body["priority"] = SourceExpressionConverter.Convert(bodypriority);
                    bodypropCount++;
                }

                if (bodyduedate != null)
                {
                    body["duedate"] = SourceExpressionConverter.ConvertToken(bodyduedate);
                    bodypropCount++;
                }

                if (bodysubject != null)
                {
                    body["subject"] = SourceExpressionConverter.ConvertToken(bodysubject);
                    bodypropCount++;
                }

                if (bodybody != null)
                {
                    body["body"] = SourceExpressionConverter.ConvertToken(bodybody);
                    bodypropCount++;
                }

                if (bodyhistory != null)
                {
                    body["history"] = SourceExpressionConverter.ConvertToken(bodyhistory);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }
    }

    public class ImprezianTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<NewSalesLeadResponseItem[]> NewSalesLead(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/trigger/api/new_lead";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<NewSalesLeadResponseItem[]>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<NewMarketingCampaignResponseItem[]> NewMarketingCampaign(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/trigger/api/new_campaign";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<NewMarketingCampaignResponseItem[]>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<NewMembersLeadsResponseItem[]> NewMembersLeads([WorkflowExpression] Func<int> promotionID, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(promotionID, nameof(promotionID), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/trigger/api/new_members_leads";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["PromotionID"] = SourceExpressionConverter.ConvertO(promotionID);
                return callPayload;
            }

            return new ApiConnectionTrigger<NewMembersLeadsResponseItem[]>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<NewSalesOrderResponseItem[]> NewSalesOrder(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/trigger/api/new_orders";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<NewSalesOrderResponseItem[]>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<NewProposalCreatedResponseItem[]> NewProposalCreated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/trigger/api/new_quotes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<NewProposalCreatedResponseItem[]>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<OrderStatusChangedResponseItem[]> OrderStatusChanged([WorkflowExpression] Func<string> status, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(status, nameof(status), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/trigger/api/order_status";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Status"] = SourceExpressionConverter.ConvertO(status);
                return callPayload;
            }

            return new ApiConnectionTrigger<OrderStatusChangedResponseItem[]>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<OrderInHistoryResponseItem[]> OrderInHistory(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/trigger/api/orders_final";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<OrderInHistoryResponseItem[]>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<OrderInProcessingResponseItem[]> OrderInProcessing(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/trigger/api/orders_processing";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<OrderInProcessingResponseItem[]>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<OrderIsShippingResponseItem[]> OrderIsShipping(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/trigger/api/orders_shipping";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<OrderIsShippingResponseItem[]>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ProposalNeedsApprovalResponseItem[]> ProposalNeedsApproval(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/trigger/api/quotes_approval";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<ProposalNeedsApprovalResponseItem[]>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<WorkOrderClosedResponseItem[]> WorkOrderClosed(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/trigger/api/wo_closed";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<WorkOrderClosedResponseItem[]>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<WorkOrderCreatedResponseItem[]> WorkOrderCreated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/trigger/api/wo_opened";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<WorkOrderCreatedResponseItem[]>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<WorkOrderPastDueResponseItem[]> WorkOrderPastDue(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/trigger/api/wo_pastdue";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<WorkOrderPastDueResponseItem[]>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<WorkOrderStatusChangedResponseItem[]> WorkOrderStatusChanged([WorkflowExpression] Func<string> status, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(status, nameof(status), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/trigger/api/wo_status";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Status"] = SourceExpressionConverter.ConvertO(status);
                return callPayload;
            }

            return new ApiConnectionTrigger<WorkOrderStatusChangedResponseItem[]>(BuildSourceInput, triggerName, recurrence);
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