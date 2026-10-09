//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Imprezian
{
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
        [WorkflowExpressionFactory(nameof(__BuildCampaignPostValue))]
        public IBodyWorkflowAction<JToken> CampaignPostValue([WorkflowExpression] Func<string> bodydescription, [WorkflowExpression] Func<string> bodyexpires, [WorkflowExpression] Func<double> bodybudget, [WorkflowExpression] Func<string> bodystartdate = null, [WorkflowExpression] Func<string> bodypromotype = null, [WorkflowExpression] Func<string> bodymanager = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildCampaignPostValue(WorkflowExpression<string> bodydescription, WorkflowExpression<string> bodyexpires, WorkflowExpression<double> bodybudget, WorkflowExpression<string> bodystartdate = null, WorkflowExpression<string> bodypromotype = null, WorkflowExpression<string> bodymanager = null)
        {
            WorkflowExpression.Validate(bodydescription, nameof(bodydescription), required: true);
            WorkflowExpression.Validate(bodyexpires, nameof(bodyexpires), required: true);
            WorkflowExpression.Validate(bodybudget, nameof(bodybudget), required: true);
            WorkflowExpression.Validate(bodystartdate, nameof(bodystartdate), required: false);
            WorkflowExpression.Validate(bodypromotype, nameof(bodypromotype), required: false);
            WorkflowExpression.Validate(bodymanager, nameof(bodymanager), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/api/Campaign";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["description"] = ExpressionConverter.ConvertO(bodydescription);
                if (bodystartdate != null)
                {
                    body["startdate"] = ExpressionConverter.ConvertO(bodystartdate);
                    bodypropCount++;
                }

                bodypropCount++;
                body["expires"] = ExpressionConverter.ConvertO(bodyexpires);
                bodypropCount++;
                body["budget"] = ExpressionConverter.ConvertO(bodybudget);
                if (bodypromotype != null)
                {
                    body["promotype"] = ExpressionConverter.ConvertO(bodypromotype);
                    bodypropCount++;
                }

                if (bodymanager != null)
                {
                    body["manager"] = ExpressionConverter.ConvertO(bodymanager);
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
        [WorkflowExpressionFactory(nameof(__BuildCampaignGetValue))]
        public IBodyWorkflowAction<CampaignGetValueResponse> CampaignGetValue([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CampaignGetValueResponse> __BuildCampaignGetValue(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<CampaignGetValueResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/Campaign/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CampaignGetValueResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        [WorkflowExpressionFactory(nameof(__BuildCampaignPutValue))]
        public IBodyWorkflowAction<JToken> CampaignPutValue([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodystartdate = null, [WorkflowExpression] Func<string> bodyexpires = null, [WorkflowExpression] Func<double> bodybudget = null, [WorkflowExpression] Func<string> bodymanager = null, [WorkflowExpression] Func<bool> bodyhistory = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildCampaignPutValue(WorkflowExpression<string> id, WorkflowExpression<string> bodydescription = null, WorkflowExpression<string> bodystartdate = null, WorkflowExpression<string> bodyexpires = null, WorkflowExpression<double> bodybudget = null, WorkflowExpression<string> bodymanager = null, WorkflowExpression<bool> bodyhistory = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            WorkflowExpression.Validate(bodystartdate, nameof(bodystartdate), required: false);
            WorkflowExpression.Validate(bodyexpires, nameof(bodyexpires), required: false);
            WorkflowExpression.Validate(bodybudget, nameof(bodybudget), required: false);
            WorkflowExpression.Validate(bodymanager, nameof(bodymanager), required: false);
            WorkflowExpression.Validate(bodyhistory, nameof(bodyhistory), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/Campaign/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(bodydescription);
                    bodypropCount++;
                }

                if (bodystartdate != null)
                {
                    body["startdate"] = ExpressionConverter.ConvertO(bodystartdate);
                    bodypropCount++;
                }

                if (bodyexpires != null)
                {
                    body["expires"] = ExpressionConverter.ConvertO(bodyexpires);
                    bodypropCount++;
                }

                if (bodybudget != null)
                {
                    body["budget"] = ExpressionConverter.ConvertO(bodybudget);
                    bodypropCount++;
                }

                if (bodymanager != null)
                {
                    body["manager"] = ExpressionConverter.ConvertO(bodymanager);
                    bodypropCount++;
                }

                if (bodyhistory != null)
                {
                    body["history"] = ExpressionConverter.ConvertO(bodyhistory);
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
        [WorkflowExpressionFactory(nameof(__BuildComLogPostValue))]
        public IBodyWorkflowAction<JToken> ComLogPostValue([WorkflowExpression] Func<string> bodycontactid = null, [WorkflowExpression] Func<string> bodyleadid = null, [WorkflowExpression] Func<bodytypeInput> bodytype = null, [WorkflowExpression] Func<string> bodysubject = null, [WorkflowExpression] Func<string> bodybody = null, [WorkflowExpression] Func<string> bodyemployee = null, [WorkflowExpression] Func<string> bodystarttime = null, [WorkflowExpression] Func<string> bodyendtime = null, [WorkflowExpression] Func<string> bodyworkorder = null, [WorkflowExpression] Func<string> bodyproject = null, [WorkflowExpression] Func<string> bodycampaign = null, [WorkflowExpression] Func<double> bodylength = null, [WorkflowExpression] Func<bool> bodybilled = null, [WorkflowExpression] Func<bool> bodyinbound = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildComLogPostValue(WorkflowExpression<string> bodycontactid = null, WorkflowExpression<string> bodyleadid = null, WorkflowExpression<bodytypeInput> bodytype = null, WorkflowExpression<string> bodysubject = null, WorkflowExpression<string> bodybody = null, WorkflowExpression<string> bodyemployee = null, WorkflowExpression<string> bodystarttime = null, WorkflowExpression<string> bodyendtime = null, WorkflowExpression<string> bodyworkorder = null, WorkflowExpression<string> bodyproject = null, WorkflowExpression<string> bodycampaign = null, WorkflowExpression<double> bodylength = null, WorkflowExpression<bool> bodybilled = null, WorkflowExpression<bool> bodyinbound = null)
        {
            WorkflowExpression.Validate(bodycontactid, nameof(bodycontactid), required: false);
            WorkflowExpression.Validate(bodyleadid, nameof(bodyleadid), required: false);
            WorkflowExpression.Validate(bodytype, nameof(bodytype), required: false);
            WorkflowExpression.Validate(bodysubject, nameof(bodysubject), required: false);
            WorkflowExpression.Validate(bodybody, nameof(bodybody), required: false);
            WorkflowExpression.Validate(bodyemployee, nameof(bodyemployee), required: false);
            WorkflowExpression.Validate(bodystarttime, nameof(bodystarttime), required: false);
            WorkflowExpression.Validate(bodyendtime, nameof(bodyendtime), required: false);
            WorkflowExpression.Validate(bodyworkorder, nameof(bodyworkorder), required: false);
            WorkflowExpression.Validate(bodyproject, nameof(bodyproject), required: false);
            WorkflowExpression.Validate(bodycampaign, nameof(bodycampaign), required: false);
            WorkflowExpression.Validate(bodylength, nameof(bodylength), required: false);
            WorkflowExpression.Validate(bodybilled, nameof(bodybilled), required: false);
            WorkflowExpression.Validate(bodyinbound, nameof(bodyinbound), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/api/ComLog";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycontactid != null)
                {
                    body["contactid"] = ExpressionConverter.ConvertO(bodycontactid);
                    bodypropCount++;
                }

                if (bodyleadid != null)
                {
                    body["leadid"] = ExpressionConverter.ConvertO(bodyleadid);
                    bodypropCount++;
                }

                if (bodytype != null)
                {
                    body["type"] = ExpressionConverter.ConvertO(bodytype);
                    bodypropCount++;
                }

                if (bodysubject != null)
                {
                    body["subject"] = ExpressionConverter.ConvertO(bodysubject);
                    bodypropCount++;
                }

                if (bodybody != null)
                {
                    body["body"] = ExpressionConverter.ConvertO(bodybody);
                    bodypropCount++;
                }

                if (bodyemployee != null)
                {
                    body["employee"] = ExpressionConverter.ConvertO(bodyemployee);
                    bodypropCount++;
                }

                if (bodystarttime != null)
                {
                    body["starttime"] = ExpressionConverter.ConvertO(bodystarttime);
                    bodypropCount++;
                }

                if (bodyendtime != null)
                {
                    body["endtime"] = ExpressionConverter.ConvertO(bodyendtime);
                    bodypropCount++;
                }

                if (bodyworkorder != null)
                {
                    body["workorder"] = ExpressionConverter.ConvertO(bodyworkorder);
                    bodypropCount++;
                }

                if (bodyproject != null)
                {
                    body["project"] = ExpressionConverter.ConvertO(bodyproject);
                    bodypropCount++;
                }

                if (bodycampaign != null)
                {
                    body["campaign"] = ExpressionConverter.ConvertO(bodycampaign);
                    bodypropCount++;
                }

                if (bodylength != null)
                {
                    body["length"] = ExpressionConverter.ConvertO(bodylength);
                    bodypropCount++;
                }

                if (bodybilled != null)
                {
                    body["billed"] = ExpressionConverter.ConvertO(bodybilled);
                    bodypropCount++;
                }

                if (bodyinbound != null)
                {
                    body["inbound"] = ExpressionConverter.ConvertO(bodyinbound);
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
        [WorkflowExpressionFactory(nameof(__BuildComLogGetValue))]
        public IBodyWorkflowAction<ComLogGetValueResponse> ComLogGetValue([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ComLogGetValueResponse> __BuildComLogGetValue(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<ComLogGetValueResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/ComLog/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ComLogGetValueResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        [WorkflowExpressionFactory(nameof(__BuildComLogPutValue))]
        public IWorkflowAction ComLogPutValue([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<bodytypeInput> bodytype = null, [WorkflowExpression] Func<string> bodysubject = null, [WorkflowExpression] Func<string> bodybody = null, [WorkflowExpression] Func<string> bodyemployee = null, [WorkflowExpression] Func<string> bodystarttime = null, [WorkflowExpression] Func<string> bodyendtime = null, [WorkflowExpression] Func<string> bodyworkorder = null, [WorkflowExpression] Func<string> bodyproject = null, [WorkflowExpression] Func<string> bodycampaign = null, [WorkflowExpression] Func<double> bodylength = null, [WorkflowExpression] Func<bool> bodybilled = null, [WorkflowExpression] Func<bool> bodyinbound = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildComLogPutValue(WorkflowExpression<string> id, WorkflowExpression<bodytypeInput> bodytype = null, WorkflowExpression<string> bodysubject = null, WorkflowExpression<string> bodybody = null, WorkflowExpression<string> bodyemployee = null, WorkflowExpression<string> bodystarttime = null, WorkflowExpression<string> bodyendtime = null, WorkflowExpression<string> bodyworkorder = null, WorkflowExpression<string> bodyproject = null, WorkflowExpression<string> bodycampaign = null, WorkflowExpression<double> bodylength = null, WorkflowExpression<bool> bodybilled = null, WorkflowExpression<bool> bodyinbound = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodytype, nameof(bodytype), required: false);
            WorkflowExpression.Validate(bodysubject, nameof(bodysubject), required: false);
            WorkflowExpression.Validate(bodybody, nameof(bodybody), required: false);
            WorkflowExpression.Validate(bodyemployee, nameof(bodyemployee), required: false);
            WorkflowExpression.Validate(bodystarttime, nameof(bodystarttime), required: false);
            WorkflowExpression.Validate(bodyendtime, nameof(bodyendtime), required: false);
            WorkflowExpression.Validate(bodyworkorder, nameof(bodyworkorder), required: false);
            WorkflowExpression.Validate(bodyproject, nameof(bodyproject), required: false);
            WorkflowExpression.Validate(bodycampaign, nameof(bodycampaign), required: false);
            WorkflowExpression.Validate(bodylength, nameof(bodylength), required: false);
            WorkflowExpression.Validate(bodybilled, nameof(bodybilled), required: false);
            WorkflowExpression.Validate(bodyinbound, nameof(bodyinbound), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/ComLog/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytype != null)
                {
                    body["type"] = ExpressionConverter.ConvertO(bodytype);
                    bodypropCount++;
                }

                if (bodysubject != null)
                {
                    body["subject"] = ExpressionConverter.ConvertO(bodysubject);
                    bodypropCount++;
                }

                if (bodybody != null)
                {
                    body["body"] = ExpressionConverter.ConvertO(bodybody);
                    bodypropCount++;
                }

                if (bodyemployee != null)
                {
                    body["employee"] = ExpressionConverter.ConvertO(bodyemployee);
                    bodypropCount++;
                }

                if (bodystarttime != null)
                {
                    body["starttime"] = ExpressionConverter.ConvertO(bodystarttime);
                    bodypropCount++;
                }

                if (bodyendtime != null)
                {
                    body["endtime"] = ExpressionConverter.ConvertO(bodyendtime);
                    bodypropCount++;
                }

                if (bodyworkorder != null)
                {
                    body["workorder"] = ExpressionConverter.ConvertO(bodyworkorder);
                    bodypropCount++;
                }

                if (bodyproject != null)
                {
                    body["project"] = ExpressionConverter.ConvertO(bodyproject);
                    bodypropCount++;
                }

                if (bodycampaign != null)
                {
                    body["campaign"] = ExpressionConverter.ConvertO(bodycampaign);
                    bodypropCount++;
                }

                if (bodylength != null)
                {
                    body["length"] = ExpressionConverter.ConvertO(bodylength);
                    bodypropCount++;
                }

                if (bodybilled != null)
                {
                    body["billed"] = ExpressionConverter.ConvertO(bodybilled);
                    bodypropCount++;
                }

                if (bodyinbound != null)
                {
                    body["inbound"] = ExpressionConverter.ConvertO(bodyinbound);
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
        [WorkflowExpressionFactory(nameof(__BuildContactPostValue))]
        public IBodyWorkflowAction<JToken> ContactPostValue([WorkflowExpression] Func<string> bodyaccount = null, [WorkflowExpression] Func<string> bodysal = null, [WorkflowExpression] Func<string> bodyfirstname = null, [WorkflowExpression] Func<string> bodymiddlename = null, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodylastname = null, [WorkflowExpression] Func<string> bodycompany = null, [WorkflowExpression] Func<string> bodyaddr1 = null, [WorkflowExpression] Func<string> bodyaddr2 = null, [WorkflowExpression] Func<string> bodycity = null, [WorkflowExpression] Func<string> bodystate = null, [WorkflowExpression] Func<string> bodypostal = null, [WorkflowExpression] Func<string> bodyemail1 = null, [WorkflowExpression] Func<string> bodyemail2 = null, [WorkflowExpression] Func<string> bodyemail3 = null, [WorkflowExpression] Func<string> bodyemail4 = null, [WorkflowExpression] Func<string> bodyphonetype1 = null, [WorkflowExpression] Func<string> bodyphone1 = null, [WorkflowExpression] Func<string> bodyphonetype2 = null, [WorkflowExpression] Func<string> bodyphone2 = null, [WorkflowExpression] Func<string> bodyphonetype3 = null, [WorkflowExpression] Func<string> bodyphone3 = null, [WorkflowExpression] Func<string> bodyphonetype4 = null, [WorkflowExpression] Func<string> bodyphone4 = null, [WorkflowExpression] Func<string> bodyremark = null, [WorkflowExpression] Func<string> bodynotes = null, [WorkflowExpression] Func<string> bodycampaign = null, [WorkflowExpression] Func<string> bodycategory = null, [WorkflowExpression] Func<string> bodymarket = null, [WorkflowExpression] Func<string> bodyterritory = null, [WorkflowExpression] Func<string> bodysalesrep = null, [WorkflowExpression] Func<string> bodylastcontact = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildContactPostValue(WorkflowExpression<string> bodyaccount = null, WorkflowExpression<string> bodysal = null, WorkflowExpression<string> bodyfirstname = null, WorkflowExpression<string> bodymiddlename = null, WorkflowExpression<string> bodytitle = null, WorkflowExpression<string> bodylastname = null, WorkflowExpression<string> bodycompany = null, WorkflowExpression<string> bodyaddr1 = null, WorkflowExpression<string> bodyaddr2 = null, WorkflowExpression<string> bodycity = null, WorkflowExpression<string> bodystate = null, WorkflowExpression<string> bodypostal = null, WorkflowExpression<string> bodyemail1 = null, WorkflowExpression<string> bodyemail2 = null, WorkflowExpression<string> bodyemail3 = null, WorkflowExpression<string> bodyemail4 = null, WorkflowExpression<string> bodyphonetype1 = null, WorkflowExpression<string> bodyphone1 = null, WorkflowExpression<string> bodyphonetype2 = null, WorkflowExpression<string> bodyphone2 = null, WorkflowExpression<string> bodyphonetype3 = null, WorkflowExpression<string> bodyphone3 = null, WorkflowExpression<string> bodyphonetype4 = null, WorkflowExpression<string> bodyphone4 = null, WorkflowExpression<string> bodyremark = null, WorkflowExpression<string> bodynotes = null, WorkflowExpression<string> bodycampaign = null, WorkflowExpression<string> bodycategory = null, WorkflowExpression<string> bodymarket = null, WorkflowExpression<string> bodyterritory = null, WorkflowExpression<string> bodysalesrep = null, WorkflowExpression<string> bodylastcontact = null)
        {
            WorkflowExpression.Validate(bodyaccount, nameof(bodyaccount), required: false);
            WorkflowExpression.Validate(bodysal, nameof(bodysal), required: false);
            WorkflowExpression.Validate(bodyfirstname, nameof(bodyfirstname), required: false);
            WorkflowExpression.Validate(bodymiddlename, nameof(bodymiddlename), required: false);
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            WorkflowExpression.Validate(bodylastname, nameof(bodylastname), required: false);
            WorkflowExpression.Validate(bodycompany, nameof(bodycompany), required: false);
            WorkflowExpression.Validate(bodyaddr1, nameof(bodyaddr1), required: false);
            WorkflowExpression.Validate(bodyaddr2, nameof(bodyaddr2), required: false);
            WorkflowExpression.Validate(bodycity, nameof(bodycity), required: false);
            WorkflowExpression.Validate(bodystate, nameof(bodystate), required: false);
            WorkflowExpression.Validate(bodypostal, nameof(bodypostal), required: false);
            WorkflowExpression.Validate(bodyemail1, nameof(bodyemail1), required: false);
            WorkflowExpression.Validate(bodyemail2, nameof(bodyemail2), required: false);
            WorkflowExpression.Validate(bodyemail3, nameof(bodyemail3), required: false);
            WorkflowExpression.Validate(bodyemail4, nameof(bodyemail4), required: false);
            WorkflowExpression.Validate(bodyphonetype1, nameof(bodyphonetype1), required: false);
            WorkflowExpression.Validate(bodyphone1, nameof(bodyphone1), required: false);
            WorkflowExpression.Validate(bodyphonetype2, nameof(bodyphonetype2), required: false);
            WorkflowExpression.Validate(bodyphone2, nameof(bodyphone2), required: false);
            WorkflowExpression.Validate(bodyphonetype3, nameof(bodyphonetype3), required: false);
            WorkflowExpression.Validate(bodyphone3, nameof(bodyphone3), required: false);
            WorkflowExpression.Validate(bodyphonetype4, nameof(bodyphonetype4), required: false);
            WorkflowExpression.Validate(bodyphone4, nameof(bodyphone4), required: false);
            WorkflowExpression.Validate(bodyremark, nameof(bodyremark), required: false);
            WorkflowExpression.Validate(bodynotes, nameof(bodynotes), required: false);
            WorkflowExpression.Validate(bodycampaign, nameof(bodycampaign), required: false);
            WorkflowExpression.Validate(bodycategory, nameof(bodycategory), required: false);
            WorkflowExpression.Validate(bodymarket, nameof(bodymarket), required: false);
            WorkflowExpression.Validate(bodyterritory, nameof(bodyterritory), required: false);
            WorkflowExpression.Validate(bodysalesrep, nameof(bodysalesrep), required: false);
            WorkflowExpression.Validate(bodylastcontact, nameof(bodylastcontact), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/api/Contact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyaccount != null)
                {
                    body["account"] = ExpressionConverter.ConvertO(bodyaccount);
                    bodypropCount++;
                }

                if (bodysal != null)
                {
                    body["sal"] = ExpressionConverter.ConvertO(bodysal);
                    bodypropCount++;
                }

                if (bodyfirstname != null)
                {
                    body["firstname"] = ExpressionConverter.ConvertO(bodyfirstname);
                    bodypropCount++;
                }

                if (bodymiddlename != null)
                {
                    body["middlename"] = ExpressionConverter.ConvertO(bodymiddlename);
                    bodypropCount++;
                }

                if (bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(bodytitle);
                    bodypropCount++;
                }

                if (bodylastname != null)
                {
                    body["lastname"] = ExpressionConverter.ConvertO(bodylastname);
                    bodypropCount++;
                }

                if (bodycompany != null)
                {
                    body["company"] = ExpressionConverter.ConvertO(bodycompany);
                    bodypropCount++;
                }

                if (bodyaddr1 != null)
                {
                    body["addr1"] = ExpressionConverter.ConvertO(bodyaddr1);
                    bodypropCount++;
                }

                if (bodyaddr2 != null)
                {
                    body["addr2"] = ExpressionConverter.ConvertO(bodyaddr2);
                    bodypropCount++;
                }

                if (bodycity != null)
                {
                    body["city"] = ExpressionConverter.ConvertO(bodycity);
                    bodypropCount++;
                }

                if (bodystate != null)
                {
                    body["state"] = ExpressionConverter.ConvertO(bodystate);
                    bodypropCount++;
                }

                if (bodypostal != null)
                {
                    body["postal"] = ExpressionConverter.ConvertO(bodypostal);
                    bodypropCount++;
                }

                if (bodyemail1 != null)
                {
                    body["email1"] = ExpressionConverter.ConvertO(bodyemail1);
                    bodypropCount++;
                }

                if (bodyemail2 != null)
                {
                    body["email2"] = ExpressionConverter.ConvertO(bodyemail2);
                    bodypropCount++;
                }

                if (bodyemail3 != null)
                {
                    body["email3"] = ExpressionConverter.ConvertO(bodyemail3);
                    bodypropCount++;
                }

                if (bodyemail4 != null)
                {
                    body["email4"] = ExpressionConverter.ConvertO(bodyemail4);
                    bodypropCount++;
                }

                if (bodyphonetype1 != null)
                {
                    body["phonetype1"] = ExpressionConverter.ConvertO(bodyphonetype1);
                    bodypropCount++;
                }

                if (bodyphone1 != null)
                {
                    body["phone1"] = ExpressionConverter.ConvertO(bodyphone1);
                    bodypropCount++;
                }

                if (bodyphonetype2 != null)
                {
                    body["phonetype2"] = ExpressionConverter.ConvertO(bodyphonetype2);
                    bodypropCount++;
                }

                if (bodyphone2 != null)
                {
                    body["phone2"] = ExpressionConverter.ConvertO(bodyphone2);
                    bodypropCount++;
                }

                if (bodyphonetype3 != null)
                {
                    body["phonetype3"] = ExpressionConverter.ConvertO(bodyphonetype3);
                    bodypropCount++;
                }

                if (bodyphone3 != null)
                {
                    body["phone3"] = ExpressionConverter.ConvertO(bodyphone3);
                    bodypropCount++;
                }

                if (bodyphonetype4 != null)
                {
                    body["phonetype4"] = ExpressionConverter.ConvertO(bodyphonetype4);
                    bodypropCount++;
                }

                if (bodyphone4 != null)
                {
                    body["phone4"] = ExpressionConverter.ConvertO(bodyphone4);
                    bodypropCount++;
                }

                if (bodyremark != null)
                {
                    body["remark"] = ExpressionConverter.ConvertO(bodyremark);
                    bodypropCount++;
                }

                if (bodynotes != null)
                {
                    body["notes"] = ExpressionConverter.ConvertO(bodynotes);
                    bodypropCount++;
                }

                if (bodycampaign != null)
                {
                    body["campaign"] = ExpressionConverter.ConvertO(bodycampaign);
                    bodypropCount++;
                }

                if (bodycategory != null)
                {
                    body["category"] = ExpressionConverter.ConvertO(bodycategory);
                    bodypropCount++;
                }

                if (bodymarket != null)
                {
                    body["market"] = ExpressionConverter.ConvertO(bodymarket);
                    bodypropCount++;
                }

                if (bodyterritory != null)
                {
                    body["territory"] = ExpressionConverter.ConvertO(bodyterritory);
                    bodypropCount++;
                }

                if (bodysalesrep != null)
                {
                    body["salesrep"] = ExpressionConverter.ConvertO(bodysalesrep);
                    bodypropCount++;
                }

                if (bodylastcontact != null)
                {
                    body["lastcontact"] = ExpressionConverter.ConvertO(bodylastcontact);
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
        [WorkflowExpressionFactory(nameof(__BuildContactGetValue))]
        public IBodyWorkflowAction<JToken> ContactGetValue([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildContactGetValue(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/Contact/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        [WorkflowExpressionFactory(nameof(__BuildContactPutValue))]
        public IBodyWorkflowAction<JToken> ContactPutValue([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodysal = null, [WorkflowExpression] Func<string> bodyfirstname = null, [WorkflowExpression] Func<string> bodymiddlename = null, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodylastname = null, [WorkflowExpression] Func<string> bodycompany = null, [WorkflowExpression] Func<string> bodyaddr1 = null, [WorkflowExpression] Func<string> bodyaddr2 = null, [WorkflowExpression] Func<string> bodycity = null, [WorkflowExpression] Func<string> bodystate = null, [WorkflowExpression] Func<string> bodypostal = null, [WorkflowExpression] Func<string> bodyemail1 = null, [WorkflowExpression] Func<string> bodyemail2 = null, [WorkflowExpression] Func<string> bodyemail3 = null, [WorkflowExpression] Func<string> bodyemail4 = null, [WorkflowExpression] Func<string> bodyphonetype1 = null, [WorkflowExpression] Func<string> bodyphone1 = null, [WorkflowExpression] Func<string> bodyphonetype2 = null, [WorkflowExpression] Func<string> bodyphone2 = null, [WorkflowExpression] Func<string> bodyphonetype3 = null, [WorkflowExpression] Func<string> bodyphone3 = null, [WorkflowExpression] Func<string> bodyphonetype4 = null, [WorkflowExpression] Func<string> bodyphone4 = null, [WorkflowExpression] Func<string> bodyremark = null, [WorkflowExpression] Func<string> bodynotes = null, [WorkflowExpression] Func<string> bodycampaign = null, [WorkflowExpression] Func<string> bodycategory = null, [WorkflowExpression] Func<string> bodymarket = null, [WorkflowExpression] Func<string> bodyterritory = null, [WorkflowExpression] Func<string> bodysalesrep = null, [WorkflowExpression] Func<string> bodylastcontact = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildContactPutValue(WorkflowExpression<string> id, WorkflowExpression<string> bodysal = null, WorkflowExpression<string> bodyfirstname = null, WorkflowExpression<string> bodymiddlename = null, WorkflowExpression<string> bodytitle = null, WorkflowExpression<string> bodylastname = null, WorkflowExpression<string> bodycompany = null, WorkflowExpression<string> bodyaddr1 = null, WorkflowExpression<string> bodyaddr2 = null, WorkflowExpression<string> bodycity = null, WorkflowExpression<string> bodystate = null, WorkflowExpression<string> bodypostal = null, WorkflowExpression<string> bodyemail1 = null, WorkflowExpression<string> bodyemail2 = null, WorkflowExpression<string> bodyemail3 = null, WorkflowExpression<string> bodyemail4 = null, WorkflowExpression<string> bodyphonetype1 = null, WorkflowExpression<string> bodyphone1 = null, WorkflowExpression<string> bodyphonetype2 = null, WorkflowExpression<string> bodyphone2 = null, WorkflowExpression<string> bodyphonetype3 = null, WorkflowExpression<string> bodyphone3 = null, WorkflowExpression<string> bodyphonetype4 = null, WorkflowExpression<string> bodyphone4 = null, WorkflowExpression<string> bodyremark = null, WorkflowExpression<string> bodynotes = null, WorkflowExpression<string> bodycampaign = null, WorkflowExpression<string> bodycategory = null, WorkflowExpression<string> bodymarket = null, WorkflowExpression<string> bodyterritory = null, WorkflowExpression<string> bodysalesrep = null, WorkflowExpression<string> bodylastcontact = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodysal, nameof(bodysal), required: false);
            WorkflowExpression.Validate(bodyfirstname, nameof(bodyfirstname), required: false);
            WorkflowExpression.Validate(bodymiddlename, nameof(bodymiddlename), required: false);
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            WorkflowExpression.Validate(bodylastname, nameof(bodylastname), required: false);
            WorkflowExpression.Validate(bodycompany, nameof(bodycompany), required: false);
            WorkflowExpression.Validate(bodyaddr1, nameof(bodyaddr1), required: false);
            WorkflowExpression.Validate(bodyaddr2, nameof(bodyaddr2), required: false);
            WorkflowExpression.Validate(bodycity, nameof(bodycity), required: false);
            WorkflowExpression.Validate(bodystate, nameof(bodystate), required: false);
            WorkflowExpression.Validate(bodypostal, nameof(bodypostal), required: false);
            WorkflowExpression.Validate(bodyemail1, nameof(bodyemail1), required: false);
            WorkflowExpression.Validate(bodyemail2, nameof(bodyemail2), required: false);
            WorkflowExpression.Validate(bodyemail3, nameof(bodyemail3), required: false);
            WorkflowExpression.Validate(bodyemail4, nameof(bodyemail4), required: false);
            WorkflowExpression.Validate(bodyphonetype1, nameof(bodyphonetype1), required: false);
            WorkflowExpression.Validate(bodyphone1, nameof(bodyphone1), required: false);
            WorkflowExpression.Validate(bodyphonetype2, nameof(bodyphonetype2), required: false);
            WorkflowExpression.Validate(bodyphone2, nameof(bodyphone2), required: false);
            WorkflowExpression.Validate(bodyphonetype3, nameof(bodyphonetype3), required: false);
            WorkflowExpression.Validate(bodyphone3, nameof(bodyphone3), required: false);
            WorkflowExpression.Validate(bodyphonetype4, nameof(bodyphonetype4), required: false);
            WorkflowExpression.Validate(bodyphone4, nameof(bodyphone4), required: false);
            WorkflowExpression.Validate(bodyremark, nameof(bodyremark), required: false);
            WorkflowExpression.Validate(bodynotes, nameof(bodynotes), required: false);
            WorkflowExpression.Validate(bodycampaign, nameof(bodycampaign), required: false);
            WorkflowExpression.Validate(bodycategory, nameof(bodycategory), required: false);
            WorkflowExpression.Validate(bodymarket, nameof(bodymarket), required: false);
            WorkflowExpression.Validate(bodyterritory, nameof(bodyterritory), required: false);
            WorkflowExpression.Validate(bodysalesrep, nameof(bodysalesrep), required: false);
            WorkflowExpression.Validate(bodylastcontact, nameof(bodylastcontact), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/Contact/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodysal != null)
                {
                    body["sal"] = ExpressionConverter.ConvertO(bodysal);
                    bodypropCount++;
                }

                if (bodyfirstname != null)
                {
                    body["firstname"] = ExpressionConverter.ConvertO(bodyfirstname);
                    bodypropCount++;
                }

                if (bodymiddlename != null)
                {
                    body["middlename"] = ExpressionConverter.ConvertO(bodymiddlename);
                    bodypropCount++;
                }

                if (bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(bodytitle);
                    bodypropCount++;
                }

                if (bodylastname != null)
                {
                    body["lastname"] = ExpressionConverter.ConvertO(bodylastname);
                    bodypropCount++;
                }

                if (bodycompany != null)
                {
                    body["company"] = ExpressionConverter.ConvertO(bodycompany);
                    bodypropCount++;
                }

                if (bodyaddr1 != null)
                {
                    body["addr1"] = ExpressionConverter.ConvertO(bodyaddr1);
                    bodypropCount++;
                }

                if (bodyaddr2 != null)
                {
                    body["addr2"] = ExpressionConverter.ConvertO(bodyaddr2);
                    bodypropCount++;
                }

                if (bodycity != null)
                {
                    body["city"] = ExpressionConverter.ConvertO(bodycity);
                    bodypropCount++;
                }

                if (bodystate != null)
                {
                    body["state"] = ExpressionConverter.ConvertO(bodystate);
                    bodypropCount++;
                }

                if (bodypostal != null)
                {
                    body["postal"] = ExpressionConverter.ConvertO(bodypostal);
                    bodypropCount++;
                }

                if (bodyemail1 != null)
                {
                    body["email1"] = ExpressionConverter.ConvertO(bodyemail1);
                    bodypropCount++;
                }

                if (bodyemail2 != null)
                {
                    body["email2"] = ExpressionConverter.ConvertO(bodyemail2);
                    bodypropCount++;
                }

                if (bodyemail3 != null)
                {
                    body["email3"] = ExpressionConverter.ConvertO(bodyemail3);
                    bodypropCount++;
                }

                if (bodyemail4 != null)
                {
                    body["email4"] = ExpressionConverter.ConvertO(bodyemail4);
                    bodypropCount++;
                }

                if (bodyphonetype1 != null)
                {
                    body["phonetype1"] = ExpressionConverter.ConvertO(bodyphonetype1);
                    bodypropCount++;
                }

                if (bodyphone1 != null)
                {
                    body["phone1"] = ExpressionConverter.ConvertO(bodyphone1);
                    bodypropCount++;
                }

                if (bodyphonetype2 != null)
                {
                    body["phonetype2"] = ExpressionConverter.ConvertO(bodyphonetype2);
                    bodypropCount++;
                }

                if (bodyphone2 != null)
                {
                    body["phone2"] = ExpressionConverter.ConvertO(bodyphone2);
                    bodypropCount++;
                }

                if (bodyphonetype3 != null)
                {
                    body["phonetype3"] = ExpressionConverter.ConvertO(bodyphonetype3);
                    bodypropCount++;
                }

                if (bodyphone3 != null)
                {
                    body["phone3"] = ExpressionConverter.ConvertO(bodyphone3);
                    bodypropCount++;
                }

                if (bodyphonetype4 != null)
                {
                    body["phonetype4"] = ExpressionConverter.ConvertO(bodyphonetype4);
                    bodypropCount++;
                }

                if (bodyphone4 != null)
                {
                    body["phone4"] = ExpressionConverter.ConvertO(bodyphone4);
                    bodypropCount++;
                }

                if (bodyremark != null)
                {
                    body["remark"] = ExpressionConverter.ConvertO(bodyremark);
                    bodypropCount++;
                }

                if (bodynotes != null)
                {
                    body["notes"] = ExpressionConverter.ConvertO(bodynotes);
                    bodypropCount++;
                }

                if (bodycampaign != null)
                {
                    body["campaign"] = ExpressionConverter.ConvertO(bodycampaign);
                    bodypropCount++;
                }

                if (bodycategory != null)
                {
                    body["category"] = ExpressionConverter.ConvertO(bodycategory);
                    bodypropCount++;
                }

                if (bodymarket != null)
                {
                    body["market"] = ExpressionConverter.ConvertO(bodymarket);
                    bodypropCount++;
                }

                if (bodyterritory != null)
                {
                    body["territory"] = ExpressionConverter.ConvertO(bodyterritory);
                    bodypropCount++;
                }

                if (bodysalesrep != null)
                {
                    body["salesrep"] = ExpressionConverter.ConvertO(bodysalesrep);
                    bodypropCount++;
                }

                if (bodylastcontact != null)
                {
                    body["lastcontact"] = ExpressionConverter.ConvertO(bodylastcontact);
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
        [WorkflowExpressionFactory(nameof(__BuildFollowUpPostValue))]
        public IBodyWorkflowAction<JToken> FollowUpPostValue([WorkflowExpression] Func<string> bodycontactid = null, [WorkflowExpression] Func<string> bodyleadid = null, [WorkflowExpression] Func<string> bodytype = null, [WorkflowExpression] Func<string> bodycomments = null, [WorkflowExpression] Func<string> bodyassignedto = null, [WorkflowExpression] Func<string> bodysetby = null, [WorkflowExpression] Func<string> bodyduedate = null, [WorkflowExpression] Func<bool> bodyurgent = null, [WorkflowExpression] Func<double> bodyreminderminutes = null, [WorkflowExpression] Func<bool> bodycleared = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildFollowUpPostValue(WorkflowExpression<string> bodycontactid = null, WorkflowExpression<string> bodyleadid = null, WorkflowExpression<string> bodytype = null, WorkflowExpression<string> bodycomments = null, WorkflowExpression<string> bodyassignedto = null, WorkflowExpression<string> bodysetby = null, WorkflowExpression<string> bodyduedate = null, WorkflowExpression<bool> bodyurgent = null, WorkflowExpression<double> bodyreminderminutes = null, WorkflowExpression<bool> bodycleared = null)
        {
            WorkflowExpression.Validate(bodycontactid, nameof(bodycontactid), required: false);
            WorkflowExpression.Validate(bodyleadid, nameof(bodyleadid), required: false);
            WorkflowExpression.Validate(bodytype, nameof(bodytype), required: false);
            WorkflowExpression.Validate(bodycomments, nameof(bodycomments), required: false);
            WorkflowExpression.Validate(bodyassignedto, nameof(bodyassignedto), required: false);
            WorkflowExpression.Validate(bodysetby, nameof(bodysetby), required: false);
            WorkflowExpression.Validate(bodyduedate, nameof(bodyduedate), required: false);
            WorkflowExpression.Validate(bodyurgent, nameof(bodyurgent), required: false);
            WorkflowExpression.Validate(bodyreminderminutes, nameof(bodyreminderminutes), required: false);
            WorkflowExpression.Validate(bodycleared, nameof(bodycleared), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/api/FollowUp";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycontactid != null)
                {
                    body["contactid"] = ExpressionConverter.ConvertO(bodycontactid);
                    bodypropCount++;
                }

                if (bodyleadid != null)
                {
                    body["leadid"] = ExpressionConverter.ConvertO(bodyleadid);
                    bodypropCount++;
                }

                if (bodytype != null)
                {
                    body["type"] = ExpressionConverter.ConvertO(bodytype);
                    bodypropCount++;
                }

                if (bodycomments != null)
                {
                    body["comments"] = ExpressionConverter.ConvertO(bodycomments);
                    bodypropCount++;
                }

                if (bodyassignedto != null)
                {
                    body["assignedto"] = ExpressionConverter.ConvertO(bodyassignedto);
                    bodypropCount++;
                }

                if (bodysetby != null)
                {
                    body["setby"] = ExpressionConverter.ConvertO(bodysetby);
                    bodypropCount++;
                }

                if (bodyduedate != null)
                {
                    body["duedate"] = ExpressionConverter.ConvertO(bodyduedate);
                    bodypropCount++;
                }

                if (bodyurgent != null)
                {
                    body["urgent"] = ExpressionConverter.ConvertO(bodyurgent);
                    bodypropCount++;
                }

                if (bodyreminderminutes != null)
                {
                    body["reminderminutes"] = ExpressionConverter.ConvertO(bodyreminderminutes);
                    bodypropCount++;
                }

                if (bodycleared != null)
                {
                    body["cleared"] = ExpressionConverter.ConvertO(bodycleared);
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
        [WorkflowExpressionFactory(nameof(__BuildFollowUpGetValue))]
        public IBodyWorkflowAction<FollowUpGetValueResponse> FollowUpGetValue([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FollowUpGetValueResponse> __BuildFollowUpGetValue(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<FollowUpGetValueResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/FollowUp/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<FollowUpGetValueResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        [WorkflowExpressionFactory(nameof(__BuildFollowUpPutValue))]
        public IWorkflowAction FollowUpPutValue([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodytype = null, [WorkflowExpression] Func<string> bodycomments = null, [WorkflowExpression] Func<string> bodyassignedto = null, [WorkflowExpression] Func<string> bodysetby = null, [WorkflowExpression] Func<string> bodyduedate = null, [WorkflowExpression] Func<string> bodyurgent = null, [WorkflowExpression] Func<double> bodyreminderminutes = null, [WorkflowExpression] Func<bool> bodycleared = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildFollowUpPutValue(WorkflowExpression<string> id, WorkflowExpression<string> bodytype = null, WorkflowExpression<string> bodycomments = null, WorkflowExpression<string> bodyassignedto = null, WorkflowExpression<string> bodysetby = null, WorkflowExpression<string> bodyduedate = null, WorkflowExpression<string> bodyurgent = null, WorkflowExpression<double> bodyreminderminutes = null, WorkflowExpression<bool> bodycleared = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodytype, nameof(bodytype), required: false);
            WorkflowExpression.Validate(bodycomments, nameof(bodycomments), required: false);
            WorkflowExpression.Validate(bodyassignedto, nameof(bodyassignedto), required: false);
            WorkflowExpression.Validate(bodysetby, nameof(bodysetby), required: false);
            WorkflowExpression.Validate(bodyduedate, nameof(bodyduedate), required: false);
            WorkflowExpression.Validate(bodyurgent, nameof(bodyurgent), required: false);
            WorkflowExpression.Validate(bodyreminderminutes, nameof(bodyreminderminutes), required: false);
            WorkflowExpression.Validate(bodycleared, nameof(bodycleared), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/FollowUp/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytype != null)
                {
                    body["type"] = ExpressionConverter.ConvertO(bodytype);
                    bodypropCount++;
                }

                if (bodycomments != null)
                {
                    body["comments"] = ExpressionConverter.ConvertO(bodycomments);
                    bodypropCount++;
                }

                if (bodyassignedto != null)
                {
                    body["assignedto"] = ExpressionConverter.ConvertO(bodyassignedto);
                    bodypropCount++;
                }

                if (bodysetby != null)
                {
                    body["setby"] = ExpressionConverter.ConvertO(bodysetby);
                    bodypropCount++;
                }

                if (bodyduedate != null)
                {
                    body["duedate"] = ExpressionConverter.ConvertO(bodyduedate);
                    bodypropCount++;
                }

                if (bodyurgent != null)
                {
                    body["urgent"] = ExpressionConverter.ConvertO(bodyurgent);
                    bodypropCount++;
                }

                if (bodyreminderminutes != null)
                {
                    body["reminderminutes"] = ExpressionConverter.ConvertO(bodyreminderminutes);
                    bodypropCount++;
                }

                if (bodycleared != null)
                {
                    body["cleared"] = ExpressionConverter.ConvertO(bodycleared);
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
        [WorkflowExpressionFactory(nameof(__BuildItemListPostValue))]
        public IBodyWorkflowAction<ItemListPostValueResponse> ItemListPostValue([WorkflowExpression] Func<string> bodymodelno = null, [WorkflowExpression] Func<string> bodydescrip = null, [WorkflowExpression] Func<bodyitemtypeInput> bodyitemtype = null, [WorkflowExpression] Func<double> bodyprice = null, [WorkflowExpression] Func<double> bodycost = null, [WorkflowExpression] Func<string> bodyvendor = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ItemListPostValueResponse> __BuildItemListPostValue(WorkflowExpression<string> bodymodelno = null, WorkflowExpression<string> bodydescrip = null, WorkflowExpression<bodyitemtypeInput> bodyitemtype = null, WorkflowExpression<double> bodyprice = null, WorkflowExpression<double> bodycost = null, WorkflowExpression<string> bodyvendor = null)
        {
            WorkflowExpression.Validate(bodymodelno, nameof(bodymodelno), required: false);
            WorkflowExpression.Validate(bodydescrip, nameof(bodydescrip), required: false);
            WorkflowExpression.Validate(bodyitemtype, nameof(bodyitemtype), required: false);
            WorkflowExpression.Validate(bodyprice, nameof(bodyprice), required: false);
            WorkflowExpression.Validate(bodycost, nameof(bodycost), required: false);
            WorkflowExpression.Validate(bodyvendor, nameof(bodyvendor), required: false);
            return new DeferredBodyAction<ItemListPostValueResponse>(() =>
            {
                var apiCallPath = "/api/ItemList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodymodelno != null)
                {
                    body["modelno"] = ExpressionConverter.ConvertO(bodymodelno);
                    bodypropCount++;
                }

                if (bodydescrip != null)
                {
                    body["descrip"] = ExpressionConverter.ConvertO(bodydescrip);
                    bodypropCount++;
                }

                if (bodyitemtype != null)
                {
                    body["itemtype"] = ExpressionConverter.ConvertO(bodyitemtype);
                    bodypropCount++;
                }

                if (bodyprice != null)
                {
                    body["price"] = ExpressionConverter.ConvertO(bodyprice);
                    bodypropCount++;
                }

                if (bodycost != null)
                {
                    body["cost"] = ExpressionConverter.ConvertO(bodycost);
                    bodypropCount++;
                }

                if (bodyvendor != null)
                {
                    body["vendor"] = ExpressionConverter.ConvertO(bodyvendor);
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
        [WorkflowExpressionFactory(nameof(__BuildItemListGetValue))]
        public IBodyWorkflowAction<ItemListGetValueResponse> ItemListGetValue([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ItemListGetValueResponse> __BuildItemListGetValue(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<ItemListGetValueResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/ItemList/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ItemListGetValueResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        [WorkflowExpressionFactory(nameof(__BuildItemListPutValue))]
        public IWorkflowAction ItemListPutValue([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodydescrip = null, [WorkflowExpression] Func<double> bodyprice = null, [WorkflowExpression] Func<double> bodycost = null, [WorkflowExpression] Func<string> bodyvendor = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildItemListPutValue(WorkflowExpression<string> id, WorkflowExpression<string> bodydescrip = null, WorkflowExpression<double> bodyprice = null, WorkflowExpression<double> bodycost = null, WorkflowExpression<string> bodyvendor = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodydescrip, nameof(bodydescrip), required: false);
            WorkflowExpression.Validate(bodyprice, nameof(bodyprice), required: false);
            WorkflowExpression.Validate(bodycost, nameof(bodycost), required: false);
            WorkflowExpression.Validate(bodyvendor, nameof(bodyvendor), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/ItemList/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydescrip != null)
                {
                    body["descrip"] = ExpressionConverter.ConvertO(bodydescrip);
                    bodypropCount++;
                }

                if (bodyprice != null)
                {
                    body["price"] = ExpressionConverter.ConvertO(bodyprice);
                    bodypropCount++;
                }

                if (bodycost != null)
                {
                    body["cost"] = ExpressionConverter.ConvertO(bodycost);
                    bodypropCount++;
                }

                if (bodyvendor != null)
                {
                    body["vendor"] = ExpressionConverter.ConvertO(bodyvendor);
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
        [WorkflowExpressionFactory(nameof(__BuildLeadPostValue))]
        public IBodyWorkflowAction<JToken> LeadPostValue([WorkflowExpression] Func<string> bodysal = null, [WorkflowExpression] Func<string> bodyfirstname = null, [WorkflowExpression] Func<string> bodymiddlename = null, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodylastname = null, [WorkflowExpression] Func<string> bodycompany = null, [WorkflowExpression] Func<string> bodyaddr1 = null, [WorkflowExpression] Func<string> bodyaddr2 = null, [WorkflowExpression] Func<string> bodycity = null, [WorkflowExpression] Func<string> bodystate = null, [WorkflowExpression] Func<string> bodypostal = null, [WorkflowExpression] Func<string> bodyemail1 = null, [WorkflowExpression] Func<string> bodyemail2 = null, [WorkflowExpression] Func<string> bodyemail3 = null, [WorkflowExpression] Func<string> bodyemail4 = null, [WorkflowExpression] Func<string> bodyphonetype1 = null, [WorkflowExpression] Func<string> bodyphone1 = null, [WorkflowExpression] Func<string> bodyphonetype2 = null, [WorkflowExpression] Func<string> bodyphone2 = null, [WorkflowExpression] Func<string> bodyphonetype3 = null, [WorkflowExpression] Func<string> bodyphone3 = null, [WorkflowExpression] Func<string> bodyphonetype4 = null, [WorkflowExpression] Func<string> bodyphone4 = null, [WorkflowExpression] Func<string> bodyremark = null, [WorkflowExpression] Func<string> bodynotes = null, [WorkflowExpression] Func<string> bodycampaign = null, [WorkflowExpression] Func<string> bodycategory = null, [WorkflowExpression] Func<string> bodyrole = null, [WorkflowExpression] Func<string> bodymarket = null, [WorkflowExpression] Func<string> bodyterritory = null, [WorkflowExpression] Func<string> bodysalesrep = null, [WorkflowExpression] Func<string> bodylastcontact = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildLeadPostValue(WorkflowExpression<string> bodysal = null, WorkflowExpression<string> bodyfirstname = null, WorkflowExpression<string> bodymiddlename = null, WorkflowExpression<string> bodytitle = null, WorkflowExpression<string> bodylastname = null, WorkflowExpression<string> bodycompany = null, WorkflowExpression<string> bodyaddr1 = null, WorkflowExpression<string> bodyaddr2 = null, WorkflowExpression<string> bodycity = null, WorkflowExpression<string> bodystate = null, WorkflowExpression<string> bodypostal = null, WorkflowExpression<string> bodyemail1 = null, WorkflowExpression<string> bodyemail2 = null, WorkflowExpression<string> bodyemail3 = null, WorkflowExpression<string> bodyemail4 = null, WorkflowExpression<string> bodyphonetype1 = null, WorkflowExpression<string> bodyphone1 = null, WorkflowExpression<string> bodyphonetype2 = null, WorkflowExpression<string> bodyphone2 = null, WorkflowExpression<string> bodyphonetype3 = null, WorkflowExpression<string> bodyphone3 = null, WorkflowExpression<string> bodyphonetype4 = null, WorkflowExpression<string> bodyphone4 = null, WorkflowExpression<string> bodyremark = null, WorkflowExpression<string> bodynotes = null, WorkflowExpression<string> bodycampaign = null, WorkflowExpression<string> bodycategory = null, WorkflowExpression<string> bodyrole = null, WorkflowExpression<string> bodymarket = null, WorkflowExpression<string> bodyterritory = null, WorkflowExpression<string> bodysalesrep = null, WorkflowExpression<string> bodylastcontact = null)
        {
            WorkflowExpression.Validate(bodysal, nameof(bodysal), required: false);
            WorkflowExpression.Validate(bodyfirstname, nameof(bodyfirstname), required: false);
            WorkflowExpression.Validate(bodymiddlename, nameof(bodymiddlename), required: false);
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            WorkflowExpression.Validate(bodylastname, nameof(bodylastname), required: false);
            WorkflowExpression.Validate(bodycompany, nameof(bodycompany), required: false);
            WorkflowExpression.Validate(bodyaddr1, nameof(bodyaddr1), required: false);
            WorkflowExpression.Validate(bodyaddr2, nameof(bodyaddr2), required: false);
            WorkflowExpression.Validate(bodycity, nameof(bodycity), required: false);
            WorkflowExpression.Validate(bodystate, nameof(bodystate), required: false);
            WorkflowExpression.Validate(bodypostal, nameof(bodypostal), required: false);
            WorkflowExpression.Validate(bodyemail1, nameof(bodyemail1), required: false);
            WorkflowExpression.Validate(bodyemail2, nameof(bodyemail2), required: false);
            WorkflowExpression.Validate(bodyemail3, nameof(bodyemail3), required: false);
            WorkflowExpression.Validate(bodyemail4, nameof(bodyemail4), required: false);
            WorkflowExpression.Validate(bodyphonetype1, nameof(bodyphonetype1), required: false);
            WorkflowExpression.Validate(bodyphone1, nameof(bodyphone1), required: false);
            WorkflowExpression.Validate(bodyphonetype2, nameof(bodyphonetype2), required: false);
            WorkflowExpression.Validate(bodyphone2, nameof(bodyphone2), required: false);
            WorkflowExpression.Validate(bodyphonetype3, nameof(bodyphonetype3), required: false);
            WorkflowExpression.Validate(bodyphone3, nameof(bodyphone3), required: false);
            WorkflowExpression.Validate(bodyphonetype4, nameof(bodyphonetype4), required: false);
            WorkflowExpression.Validate(bodyphone4, nameof(bodyphone4), required: false);
            WorkflowExpression.Validate(bodyremark, nameof(bodyremark), required: false);
            WorkflowExpression.Validate(bodynotes, nameof(bodynotes), required: false);
            WorkflowExpression.Validate(bodycampaign, nameof(bodycampaign), required: false);
            WorkflowExpression.Validate(bodycategory, nameof(bodycategory), required: false);
            WorkflowExpression.Validate(bodyrole, nameof(bodyrole), required: false);
            WorkflowExpression.Validate(bodymarket, nameof(bodymarket), required: false);
            WorkflowExpression.Validate(bodyterritory, nameof(bodyterritory), required: false);
            WorkflowExpression.Validate(bodysalesrep, nameof(bodysalesrep), required: false);
            WorkflowExpression.Validate(bodylastcontact, nameof(bodylastcontact), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/api/Lead";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodysal != null)
                {
                    body["sal"] = ExpressionConverter.ConvertO(bodysal);
                    bodypropCount++;
                }

                if (bodyfirstname != null)
                {
                    body["firstname"] = ExpressionConverter.ConvertO(bodyfirstname);
                    bodypropCount++;
                }

                if (bodymiddlename != null)
                {
                    body["middlename"] = ExpressionConverter.ConvertO(bodymiddlename);
                    bodypropCount++;
                }

                if (bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(bodytitle);
                    bodypropCount++;
                }

                if (bodylastname != null)
                {
                    body["lastname"] = ExpressionConverter.ConvertO(bodylastname);
                    bodypropCount++;
                }

                if (bodycompany != null)
                {
                    body["company"] = ExpressionConverter.ConvertO(bodycompany);
                    bodypropCount++;
                }

                if (bodyaddr1 != null)
                {
                    body["addr1"] = ExpressionConverter.ConvertO(bodyaddr1);
                    bodypropCount++;
                }

                if (bodyaddr2 != null)
                {
                    body["addr2"] = ExpressionConverter.ConvertO(bodyaddr2);
                    bodypropCount++;
                }

                if (bodycity != null)
                {
                    body["city"] = ExpressionConverter.ConvertO(bodycity);
                    bodypropCount++;
                }

                if (bodystate != null)
                {
                    body["state"] = ExpressionConverter.ConvertO(bodystate);
                    bodypropCount++;
                }

                if (bodypostal != null)
                {
                    body["postal"] = ExpressionConverter.ConvertO(bodypostal);
                    bodypropCount++;
                }

                if (bodyemail1 != null)
                {
                    body["email1"] = ExpressionConverter.ConvertO(bodyemail1);
                    bodypropCount++;
                }

                if (bodyemail2 != null)
                {
                    body["email2"] = ExpressionConverter.ConvertO(bodyemail2);
                    bodypropCount++;
                }

                if (bodyemail3 != null)
                {
                    body["email3"] = ExpressionConverter.ConvertO(bodyemail3);
                    bodypropCount++;
                }

                if (bodyemail4 != null)
                {
                    body["email4"] = ExpressionConverter.ConvertO(bodyemail4);
                    bodypropCount++;
                }

                if (bodyphonetype1 != null)
                {
                    body["phonetype1"] = ExpressionConverter.ConvertO(bodyphonetype1);
                    bodypropCount++;
                }

                if (bodyphone1 != null)
                {
                    body["phone1"] = ExpressionConverter.ConvertO(bodyphone1);
                    bodypropCount++;
                }

                if (bodyphonetype2 != null)
                {
                    body["phonetype2"] = ExpressionConverter.ConvertO(bodyphonetype2);
                    bodypropCount++;
                }

                if (bodyphone2 != null)
                {
                    body["phone2"] = ExpressionConverter.ConvertO(bodyphone2);
                    bodypropCount++;
                }

                if (bodyphonetype3 != null)
                {
                    body["phonetype3"] = ExpressionConverter.ConvertO(bodyphonetype3);
                    bodypropCount++;
                }

                if (bodyphone3 != null)
                {
                    body["phone3"] = ExpressionConverter.ConvertO(bodyphone3);
                    bodypropCount++;
                }

                if (bodyphonetype4 != null)
                {
                    body["phonetype4"] = ExpressionConverter.ConvertO(bodyphonetype4);
                    bodypropCount++;
                }

                if (bodyphone4 != null)
                {
                    body["phone4"] = ExpressionConverter.ConvertO(bodyphone4);
                    bodypropCount++;
                }

                if (bodyremark != null)
                {
                    body["remark"] = ExpressionConverter.ConvertO(bodyremark);
                    bodypropCount++;
                }

                if (bodynotes != null)
                {
                    body["notes"] = ExpressionConverter.ConvertO(bodynotes);
                    bodypropCount++;
                }

                if (bodycampaign != null)
                {
                    body["campaign"] = ExpressionConverter.ConvertO(bodycampaign);
                    bodypropCount++;
                }

                if (bodycategory != null)
                {
                    body["category"] = ExpressionConverter.ConvertO(bodycategory);
                    bodypropCount++;
                }

                if (bodyrole != null)
                {
                    body["role"] = ExpressionConverter.ConvertO(bodyrole);
                    bodypropCount++;
                }

                if (bodymarket != null)
                {
                    body["market"] = ExpressionConverter.ConvertO(bodymarket);
                    bodypropCount++;
                }

                if (bodyterritory != null)
                {
                    body["territory"] = ExpressionConverter.ConvertO(bodyterritory);
                    bodypropCount++;
                }

                if (bodysalesrep != null)
                {
                    body["salesrep"] = ExpressionConverter.ConvertO(bodysalesrep);
                    bodypropCount++;
                }

                if (bodylastcontact != null)
                {
                    body["lastcontact"] = ExpressionConverter.ConvertO(bodylastcontact);
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
        [WorkflowExpressionFactory(nameof(__BuildLeadGetValue))]
        public IBodyWorkflowAction<LeadGetValueResponse> LeadGetValue([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<LeadGetValueResponse> __BuildLeadGetValue(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<LeadGetValueResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/Lead/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<LeadGetValueResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        [WorkflowExpressionFactory(nameof(__BuildLeadPutValue))]
        public IBodyWorkflowAction<JToken> LeadPutValue([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodysal = null, [WorkflowExpression] Func<string> bodyfirstname = null, [WorkflowExpression] Func<string> bodymiddlename = null, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodylastname = null, [WorkflowExpression] Func<string> bodycompany = null, [WorkflowExpression] Func<string> bodyaddr1 = null, [WorkflowExpression] Func<string> bodyaddr2 = null, [WorkflowExpression] Func<string> bodycity = null, [WorkflowExpression] Func<string> bodystate = null, [WorkflowExpression] Func<string> bodypostal = null, [WorkflowExpression] Func<string> bodyemail1 = null, [WorkflowExpression] Func<string> bodyemail2 = null, [WorkflowExpression] Func<string> bodyemail3 = null, [WorkflowExpression] Func<string> bodyemail4 = null, [WorkflowExpression] Func<string> bodyphonetype1 = null, [WorkflowExpression] Func<string> bodyphone1 = null, [WorkflowExpression] Func<string> bodyphonetype2 = null, [WorkflowExpression] Func<string> bodyphone2 = null, [WorkflowExpression] Func<string> bodyphonetype3 = null, [WorkflowExpression] Func<string> bodyphone3 = null, [WorkflowExpression] Func<string> bodyphonetype4 = null, [WorkflowExpression] Func<string> bodyphone4 = null, [WorkflowExpression] Func<string> bodyremark = null, [WorkflowExpression] Func<string> bodynotes = null, [WorkflowExpression] Func<string> bodycampaign = null, [WorkflowExpression] Func<string> bodycategory = null, [WorkflowExpression] Func<string> bodyrole = null, [WorkflowExpression] Func<string> bodymarket = null, [WorkflowExpression] Func<string> bodyterritory = null, [WorkflowExpression] Func<string> bodysalesrep = null, [WorkflowExpression] Func<string> bodylastcontact = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildLeadPutValue(WorkflowExpression<string> id, WorkflowExpression<string> bodysal = null, WorkflowExpression<string> bodyfirstname = null, WorkflowExpression<string> bodymiddlename = null, WorkflowExpression<string> bodytitle = null, WorkflowExpression<string> bodylastname = null, WorkflowExpression<string> bodycompany = null, WorkflowExpression<string> bodyaddr1 = null, WorkflowExpression<string> bodyaddr2 = null, WorkflowExpression<string> bodycity = null, WorkflowExpression<string> bodystate = null, WorkflowExpression<string> bodypostal = null, WorkflowExpression<string> bodyemail1 = null, WorkflowExpression<string> bodyemail2 = null, WorkflowExpression<string> bodyemail3 = null, WorkflowExpression<string> bodyemail4 = null, WorkflowExpression<string> bodyphonetype1 = null, WorkflowExpression<string> bodyphone1 = null, WorkflowExpression<string> bodyphonetype2 = null, WorkflowExpression<string> bodyphone2 = null, WorkflowExpression<string> bodyphonetype3 = null, WorkflowExpression<string> bodyphone3 = null, WorkflowExpression<string> bodyphonetype4 = null, WorkflowExpression<string> bodyphone4 = null, WorkflowExpression<string> bodyremark = null, WorkflowExpression<string> bodynotes = null, WorkflowExpression<string> bodycampaign = null, WorkflowExpression<string> bodycategory = null, WorkflowExpression<string> bodyrole = null, WorkflowExpression<string> bodymarket = null, WorkflowExpression<string> bodyterritory = null, WorkflowExpression<string> bodysalesrep = null, WorkflowExpression<string> bodylastcontact = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodysal, nameof(bodysal), required: false);
            WorkflowExpression.Validate(bodyfirstname, nameof(bodyfirstname), required: false);
            WorkflowExpression.Validate(bodymiddlename, nameof(bodymiddlename), required: false);
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            WorkflowExpression.Validate(bodylastname, nameof(bodylastname), required: false);
            WorkflowExpression.Validate(bodycompany, nameof(bodycompany), required: false);
            WorkflowExpression.Validate(bodyaddr1, nameof(bodyaddr1), required: false);
            WorkflowExpression.Validate(bodyaddr2, nameof(bodyaddr2), required: false);
            WorkflowExpression.Validate(bodycity, nameof(bodycity), required: false);
            WorkflowExpression.Validate(bodystate, nameof(bodystate), required: false);
            WorkflowExpression.Validate(bodypostal, nameof(bodypostal), required: false);
            WorkflowExpression.Validate(bodyemail1, nameof(bodyemail1), required: false);
            WorkflowExpression.Validate(bodyemail2, nameof(bodyemail2), required: false);
            WorkflowExpression.Validate(bodyemail3, nameof(bodyemail3), required: false);
            WorkflowExpression.Validate(bodyemail4, nameof(bodyemail4), required: false);
            WorkflowExpression.Validate(bodyphonetype1, nameof(bodyphonetype1), required: false);
            WorkflowExpression.Validate(bodyphone1, nameof(bodyphone1), required: false);
            WorkflowExpression.Validate(bodyphonetype2, nameof(bodyphonetype2), required: false);
            WorkflowExpression.Validate(bodyphone2, nameof(bodyphone2), required: false);
            WorkflowExpression.Validate(bodyphonetype3, nameof(bodyphonetype3), required: false);
            WorkflowExpression.Validate(bodyphone3, nameof(bodyphone3), required: false);
            WorkflowExpression.Validate(bodyphonetype4, nameof(bodyphonetype4), required: false);
            WorkflowExpression.Validate(bodyphone4, nameof(bodyphone4), required: false);
            WorkflowExpression.Validate(bodyremark, nameof(bodyremark), required: false);
            WorkflowExpression.Validate(bodynotes, nameof(bodynotes), required: false);
            WorkflowExpression.Validate(bodycampaign, nameof(bodycampaign), required: false);
            WorkflowExpression.Validate(bodycategory, nameof(bodycategory), required: false);
            WorkflowExpression.Validate(bodyrole, nameof(bodyrole), required: false);
            WorkflowExpression.Validate(bodymarket, nameof(bodymarket), required: false);
            WorkflowExpression.Validate(bodyterritory, nameof(bodyterritory), required: false);
            WorkflowExpression.Validate(bodysalesrep, nameof(bodysalesrep), required: false);
            WorkflowExpression.Validate(bodylastcontact, nameof(bodylastcontact), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/Lead/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodysal != null)
                {
                    body["sal"] = ExpressionConverter.ConvertO(bodysal);
                    bodypropCount++;
                }

                if (bodyfirstname != null)
                {
                    body["firstname"] = ExpressionConverter.ConvertO(bodyfirstname);
                    bodypropCount++;
                }

                if (bodymiddlename != null)
                {
                    body["middlename"] = ExpressionConverter.ConvertO(bodymiddlename);
                    bodypropCount++;
                }

                if (bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(bodytitle);
                    bodypropCount++;
                }

                if (bodylastname != null)
                {
                    body["lastname"] = ExpressionConverter.ConvertO(bodylastname);
                    bodypropCount++;
                }

                if (bodycompany != null)
                {
                    body["company"] = ExpressionConverter.ConvertO(bodycompany);
                    bodypropCount++;
                }

                if (bodyaddr1 != null)
                {
                    body["addr1"] = ExpressionConverter.ConvertO(bodyaddr1);
                    bodypropCount++;
                }

                if (bodyaddr2 != null)
                {
                    body["addr2"] = ExpressionConverter.ConvertO(bodyaddr2);
                    bodypropCount++;
                }

                if (bodycity != null)
                {
                    body["city"] = ExpressionConverter.ConvertO(bodycity);
                    bodypropCount++;
                }

                if (bodystate != null)
                {
                    body["state"] = ExpressionConverter.ConvertO(bodystate);
                    bodypropCount++;
                }

                if (bodypostal != null)
                {
                    body["postal"] = ExpressionConverter.ConvertO(bodypostal);
                    bodypropCount++;
                }

                if (bodyemail1 != null)
                {
                    body["email1"] = ExpressionConverter.ConvertO(bodyemail1);
                    bodypropCount++;
                }

                if (bodyemail2 != null)
                {
                    body["email2"] = ExpressionConverter.ConvertO(bodyemail2);
                    bodypropCount++;
                }

                if (bodyemail3 != null)
                {
                    body["email3"] = ExpressionConverter.ConvertO(bodyemail3);
                    bodypropCount++;
                }

                if (bodyemail4 != null)
                {
                    body["email4"] = ExpressionConverter.ConvertO(bodyemail4);
                    bodypropCount++;
                }

                if (bodyphonetype1 != null)
                {
                    body["phonetype1"] = ExpressionConverter.ConvertO(bodyphonetype1);
                    bodypropCount++;
                }

                if (bodyphone1 != null)
                {
                    body["phone1"] = ExpressionConverter.ConvertO(bodyphone1);
                    bodypropCount++;
                }

                if (bodyphonetype2 != null)
                {
                    body["phonetype2"] = ExpressionConverter.ConvertO(bodyphonetype2);
                    bodypropCount++;
                }

                if (bodyphone2 != null)
                {
                    body["phone2"] = ExpressionConverter.ConvertO(bodyphone2);
                    bodypropCount++;
                }

                if (bodyphonetype3 != null)
                {
                    body["phonetype3"] = ExpressionConverter.ConvertO(bodyphonetype3);
                    bodypropCount++;
                }

                if (bodyphone3 != null)
                {
                    body["phone3"] = ExpressionConverter.ConvertO(bodyphone3);
                    bodypropCount++;
                }

                if (bodyphonetype4 != null)
                {
                    body["phonetype4"] = ExpressionConverter.ConvertO(bodyphonetype4);
                    bodypropCount++;
                }

                if (bodyphone4 != null)
                {
                    body["phone4"] = ExpressionConverter.ConvertO(bodyphone4);
                    bodypropCount++;
                }

                if (bodyremark != null)
                {
                    body["remark"] = ExpressionConverter.ConvertO(bodyremark);
                    bodypropCount++;
                }

                if (bodynotes != null)
                {
                    body["notes"] = ExpressionConverter.ConvertO(bodynotes);
                    bodypropCount++;
                }

                if (bodycampaign != null)
                {
                    body["campaign"] = ExpressionConverter.ConvertO(bodycampaign);
                    bodypropCount++;
                }

                if (bodycategory != null)
                {
                    body["category"] = ExpressionConverter.ConvertO(bodycategory);
                    bodypropCount++;
                }

                if (bodyrole != null)
                {
                    body["role"] = ExpressionConverter.ConvertO(bodyrole);
                    bodypropCount++;
                }

                if (bodymarket != null)
                {
                    body["market"] = ExpressionConverter.ConvertO(bodymarket);
                    bodypropCount++;
                }

                if (bodyterritory != null)
                {
                    body["territory"] = ExpressionConverter.ConvertO(bodyterritory);
                    bodypropCount++;
                }

                if (bodysalesrep != null)
                {
                    body["salesrep"] = ExpressionConverter.ConvertO(bodysalesrep);
                    bodypropCount++;
                }

                if (bodylastcontact != null)
                {
                    body["lastcontact"] = ExpressionConverter.ConvertO(bodylastcontact);
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
        [WorkflowExpressionFactory(nameof(__BuildMembersGetValues))]
        public IBodyWorkflowAction<string[]> MembersGetValues([WorkflowExpression] Func<typeInput> type)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string[]> __BuildMembersGetValues(WorkflowExpression<typeInput> type)
        {
            WorkflowExpression.Validate(type, nameof(type), required: true);
            return new DeferredBodyAction<string[]>(() =>
            {
                var apiCallPath = "/api/Members";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["type"] = ExpressionConverter.Convert(type);
                return new ApiConnectionAction<string[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        [WorkflowExpressionFactory(nameof(__BuildMembersPostValue))]
        public IBodyWorkflowAction<JToken> MembersPostValue([WorkflowExpression] Func<string> bodypromoid = null, [WorkflowExpression] Func<bodyrecordtypeInput> bodyrecordtype = null, [WorkflowExpression] Func<string> bodyrecordid = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildMembersPostValue(WorkflowExpression<string> bodypromoid = null, WorkflowExpression<bodyrecordtypeInput> bodyrecordtype = null, WorkflowExpression<string> bodyrecordid = null)
        {
            WorkflowExpression.Validate(bodypromoid, nameof(bodypromoid), required: false);
            WorkflowExpression.Validate(bodyrecordtype, nameof(bodyrecordtype), required: false);
            WorkflowExpression.Validate(bodyrecordid, nameof(bodyrecordid), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/api/Members";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypromoid != null)
                {
                    body["promoid"] = ExpressionConverter.ConvertO(bodypromoid);
                    bodypropCount++;
                }

                if (bodyrecordtype != null)
                {
                    body["recordtype"] = ExpressionConverter.ConvertO(bodyrecordtype);
                    bodypropCount++;
                }

                if (bodyrecordid != null)
                {
                    body["recordid"] = ExpressionConverter.ConvertO(bodyrecordid);
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
        [WorkflowExpressionFactory(nameof(__BuildMembersGetValue))]
        public IBodyWorkflowAction<MembersGetValueResponse> MembersGetValue([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MembersGetValueResponse> __BuildMembersGetValue(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<MembersGetValueResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/Members/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<MembersGetValueResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        [WorkflowExpressionFactory(nameof(__BuildMembersPutValue))]
        public IBodyWorkflowAction<JToken> MembersPutValue([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<bodyoperationInput> bodyoperation = null, [WorkflowExpression] Func<bodyrecordtypeInput> bodyrecordtype = null, [WorkflowExpression] Func<string> bodypromoid = null, [WorkflowExpression] Func<string> bodyrecordid = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildMembersPutValue(WorkflowExpression<string> id, WorkflowExpression<bodyoperationInput> bodyoperation = null, WorkflowExpression<bodyrecordtypeInput> bodyrecordtype = null, WorkflowExpression<string> bodypromoid = null, WorkflowExpression<string> bodyrecordid = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodyoperation, nameof(bodyoperation), required: false);
            WorkflowExpression.Validate(bodyrecordtype, nameof(bodyrecordtype), required: false);
            WorkflowExpression.Validate(bodypromoid, nameof(bodypromoid), required: false);
            WorkflowExpression.Validate(bodyrecordid, nameof(bodyrecordid), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/Members/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyoperation != null)
                {
                    body["operation"] = ExpressionConverter.ConvertO(bodyoperation);
                    bodypropCount++;
                }

                if (bodyrecordtype != null)
                {
                    body["recordtype"] = ExpressionConverter.ConvertO(bodyrecordtype);
                    bodypropCount++;
                }

                if (bodypromoid != null)
                {
                    body["promoid"] = ExpressionConverter.ConvertO(bodypromoid);
                    bodypropCount++;
                }

                if (bodyrecordid != null)
                {
                    body["recordid"] = ExpressionConverter.ConvertO(bodyrecordid);
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
        [WorkflowExpressionFactory(nameof(__BuildShippingPostValue))]
        public IBodyWorkflowAction<JToken> ShippingPostValue([WorkflowExpression] Func<string> bodyorderid = null, [WorkflowExpression] Func<string> bodyshipdate = null, [WorkflowExpression] Func<string> bodycarrier = null, [WorkflowExpression] Func<string> bodymethod = null, [WorkflowExpression] Func<double> bodyweight = null, [WorkflowExpression] Func<string> bodypackagetype = null, [WorkflowExpression] Func<string> bodyreference1 = null, [WorkflowExpression] Func<string> bodyreference2 = null, [WorkflowExpression] Func<string> bodytrackingnumber = null, [WorkflowExpression] Func<string> bodytrackingurl = null, [WorkflowExpression] Func<double> bodyshippingcost = null, [WorkflowExpression] Func<bool> bodytohistory = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildShippingPostValue(WorkflowExpression<string> bodyorderid = null, WorkflowExpression<string> bodyshipdate = null, WorkflowExpression<string> bodycarrier = null, WorkflowExpression<string> bodymethod = null, WorkflowExpression<double> bodyweight = null, WorkflowExpression<string> bodypackagetype = null, WorkflowExpression<string> bodyreference1 = null, WorkflowExpression<string> bodyreference2 = null, WorkflowExpression<string> bodytrackingnumber = null, WorkflowExpression<string> bodytrackingurl = null, WorkflowExpression<double> bodyshippingcost = null, WorkflowExpression<bool> bodytohistory = null)
        {
            WorkflowExpression.Validate(bodyorderid, nameof(bodyorderid), required: false);
            WorkflowExpression.Validate(bodyshipdate, nameof(bodyshipdate), required: false);
            WorkflowExpression.Validate(bodycarrier, nameof(bodycarrier), required: false);
            WorkflowExpression.Validate(bodymethod, nameof(bodymethod), required: false);
            WorkflowExpression.Validate(bodyweight, nameof(bodyweight), required: false);
            WorkflowExpression.Validate(bodypackagetype, nameof(bodypackagetype), required: false);
            WorkflowExpression.Validate(bodyreference1, nameof(bodyreference1), required: false);
            WorkflowExpression.Validate(bodyreference2, nameof(bodyreference2), required: false);
            WorkflowExpression.Validate(bodytrackingnumber, nameof(bodytrackingnumber), required: false);
            WorkflowExpression.Validate(bodytrackingurl, nameof(bodytrackingurl), required: false);
            WorkflowExpression.Validate(bodyshippingcost, nameof(bodyshippingcost), required: false);
            WorkflowExpression.Validate(bodytohistory, nameof(bodytohistory), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/api/Shipping";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyorderid != null)
                {
                    body["orderid"] = ExpressionConverter.ConvertO(bodyorderid);
                    bodypropCount++;
                }

                if (bodyshipdate != null)
                {
                    body["shipdate"] = ExpressionConverter.ConvertO(bodyshipdate);
                    bodypropCount++;
                }

                if (bodycarrier != null)
                {
                    body["carrier"] = ExpressionConverter.ConvertO(bodycarrier);
                    bodypropCount++;
                }

                if (bodymethod != null)
                {
                    body["method"] = ExpressionConverter.ConvertO(bodymethod);
                    bodypropCount++;
                }

                if (bodyweight != null)
                {
                    body["weight"] = ExpressionConverter.ConvertO(bodyweight);
                    bodypropCount++;
                }

                if (bodypackagetype != null)
                {
                    body["packagetype"] = ExpressionConverter.ConvertO(bodypackagetype);
                    bodypropCount++;
                }

                if (bodyreference1 != null)
                {
                    body["reference1"] = ExpressionConverter.ConvertO(bodyreference1);
                    bodypropCount++;
                }

                if (bodyreference2 != null)
                {
                    body["reference2"] = ExpressionConverter.ConvertO(bodyreference2);
                    bodypropCount++;
                }

                if (bodytrackingnumber != null)
                {
                    body["trackingnumber"] = ExpressionConverter.ConvertO(bodytrackingnumber);
                    bodypropCount++;
                }

                if (bodytrackingurl != null)
                {
                    body["trackingurl"] = ExpressionConverter.ConvertO(bodytrackingurl);
                    bodypropCount++;
                }

                if (bodyshippingcost != null)
                {
                    body["shippingcost"] = ExpressionConverter.ConvertO(bodyshippingcost);
                    bodypropCount++;
                }

                if (bodytohistory != null)
                {
                    body["tohistory"] = ExpressionConverter.ConvertO(bodytohistory);
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
        [WorkflowExpressionFactory(nameof(__BuildShippingGetValue))]
        public IBodyWorkflowAction<ShippingGetValueResponse> ShippingGetValue([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ShippingGetValueResponse> __BuildShippingGetValue(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<ShippingGetValueResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/Shipping/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ShippingGetValueResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        [WorkflowExpressionFactory(nameof(__BuildShippingPutValue))]
        public IWorkflowAction ShippingPutValue([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyshipdate = null, [WorkflowExpression] Func<string> bodycarrier = null, [WorkflowExpression] Func<string> bodymethod = null, [WorkflowExpression] Func<double> bodyweight = null, [WorkflowExpression] Func<string> bodypackagetype = null, [WorkflowExpression] Func<string> bodyreference1 = null, [WorkflowExpression] Func<string> bodyreference2 = null, [WorkflowExpression] Func<string> bodytrackingnumber = null, [WorkflowExpression] Func<string> bodytrackingurl = null, [WorkflowExpression] Func<double> bodyshippingcost = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildShippingPutValue(WorkflowExpression<string> id, WorkflowExpression<string> bodyshipdate = null, WorkflowExpression<string> bodycarrier = null, WorkflowExpression<string> bodymethod = null, WorkflowExpression<double> bodyweight = null, WorkflowExpression<string> bodypackagetype = null, WorkflowExpression<string> bodyreference1 = null, WorkflowExpression<string> bodyreference2 = null, WorkflowExpression<string> bodytrackingnumber = null, WorkflowExpression<string> bodytrackingurl = null, WorkflowExpression<double> bodyshippingcost = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodyshipdate, nameof(bodyshipdate), required: false);
            WorkflowExpression.Validate(bodycarrier, nameof(bodycarrier), required: false);
            WorkflowExpression.Validate(bodymethod, nameof(bodymethod), required: false);
            WorkflowExpression.Validate(bodyweight, nameof(bodyweight), required: false);
            WorkflowExpression.Validate(bodypackagetype, nameof(bodypackagetype), required: false);
            WorkflowExpression.Validate(bodyreference1, nameof(bodyreference1), required: false);
            WorkflowExpression.Validate(bodyreference2, nameof(bodyreference2), required: false);
            WorkflowExpression.Validate(bodytrackingnumber, nameof(bodytrackingnumber), required: false);
            WorkflowExpression.Validate(bodytrackingurl, nameof(bodytrackingurl), required: false);
            WorkflowExpression.Validate(bodyshippingcost, nameof(bodyshippingcost), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/Shipping/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyshipdate != null)
                {
                    body["shipdate"] = ExpressionConverter.ConvertO(bodyshipdate);
                    bodypropCount++;
                }

                if (bodycarrier != null)
                {
                    body["carrier"] = ExpressionConverter.ConvertO(bodycarrier);
                    bodypropCount++;
                }

                if (bodymethod != null)
                {
                    body["method"] = ExpressionConverter.ConvertO(bodymethod);
                    bodypropCount++;
                }

                if (bodyweight != null)
                {
                    body["weight"] = ExpressionConverter.ConvertO(bodyweight);
                    bodypropCount++;
                }

                if (bodypackagetype != null)
                {
                    body["packagetype"] = ExpressionConverter.ConvertO(bodypackagetype);
                    bodypropCount++;
                }

                if (bodyreference1 != null)
                {
                    body["reference1"] = ExpressionConverter.ConvertO(bodyreference1);
                    bodypropCount++;
                }

                if (bodyreference2 != null)
                {
                    body["reference2"] = ExpressionConverter.ConvertO(bodyreference2);
                    bodypropCount++;
                }

                if (bodytrackingnumber != null)
                {
                    body["trackingnumber"] = ExpressionConverter.ConvertO(bodytrackingnumber);
                    bodypropCount++;
                }

                if (bodytrackingurl != null)
                {
                    body["trackingurl"] = ExpressionConverter.ConvertO(bodytrackingurl);
                    bodypropCount++;
                }

                if (bodyshippingcost != null)
                {
                    body["shippingcost"] = ExpressionConverter.ConvertO(bodyshippingcost);
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
        [WorkflowExpressionFactory(nameof(__BuildSOPostValue))]
        public IBodyWorkflowAction<JToken> SOPostValue([WorkflowExpression] Func<string> bodyorderid = null, [WorkflowExpression] Func<string> bodyorderdate = null, [WorkflowExpression] Func<string> bodyorderdescription = null, [WorkflowExpression] Func<string> bodyaccount = null, [WorkflowExpression] Func<string> bodyaccountname = null, [WorkflowExpression] Func<string> bodysalesrep = null, [WorkflowExpression] Func<string> bodyfirstname = null, [WorkflowExpression] Func<string> bodylastname = null, [WorkflowExpression] Func<string> bodybillemail = null, [WorkflowExpression] Func<string> bodybilladdr1 = null, [WorkflowExpression] Func<string> bodybilladdr2 = null, [WorkflowExpression] Func<string> bodybillcity = null, [WorkflowExpression] Func<string> bodybillstate = null, [WorkflowExpression] Func<string> bodybillzipcode = null, [WorkflowExpression] Func<string> bodybillcountry = null, [WorkflowExpression] Func<string> bodybillphone = null, [WorkflowExpression] Func<string> bodybillfax = null, [WorkflowExpression] Func<string> bodyshipcompany = null, [WorkflowExpression] Func<string> bodyshipcontact = null, [WorkflowExpression] Func<string> bodyshipaddr1 = null, [WorkflowExpression] Func<string> bodyshipaddr2 = null, [WorkflowExpression] Func<string> bodyshipcity = null, [WorkflowExpression] Func<string> bodyshipstate = null, [WorkflowExpression] Func<string> bodyshipzipcode = null, [WorkflowExpression] Func<string> bodyshipcountry = null, [WorkflowExpression] Func<string> bodyshipphone = null, [WorkflowExpression] Func<string> bodyshipemail = null, [WorkflowExpression] Func<bodyorderstatusInput> bodyorderstatus = null, [WorkflowExpression] Func<string> bodycustomstatus = null, [WorkflowExpression] Func<string> bodytaxdistrict = null, [WorkflowExpression] Func<double> bodytaxrate = null, [WorkflowExpression] Func<string> bodycampaign = null, [WorkflowExpression] Func<string> bodyordertax = null, [WorkflowExpression] Func<string> bodyshippingcost = null, [WorkflowExpression] Func<string> bodyshippingmethod = null, [WorkflowExpression] Func<double> bodycouponamount = null, [WorkflowExpression] Func<string> bodycouponcode = null, [WorkflowExpression] Func<string> bodypaymentmethod = null, [WorkflowExpression] Func<string> bodycomments = null, [WorkflowExpression] Func<bodylinedataInputItem[]> bodylinedata = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildSOPostValue(WorkflowExpression<string> bodyorderid = null, WorkflowExpression<string> bodyorderdate = null, WorkflowExpression<string> bodyorderdescription = null, WorkflowExpression<string> bodyaccount = null, WorkflowExpression<string> bodyaccountname = null, WorkflowExpression<string> bodysalesrep = null, WorkflowExpression<string> bodyfirstname = null, WorkflowExpression<string> bodylastname = null, WorkflowExpression<string> bodybillemail = null, WorkflowExpression<string> bodybilladdr1 = null, WorkflowExpression<string> bodybilladdr2 = null, WorkflowExpression<string> bodybillcity = null, WorkflowExpression<string> bodybillstate = null, WorkflowExpression<string> bodybillzipcode = null, WorkflowExpression<string> bodybillcountry = null, WorkflowExpression<string> bodybillphone = null, WorkflowExpression<string> bodybillfax = null, WorkflowExpression<string> bodyshipcompany = null, WorkflowExpression<string> bodyshipcontact = null, WorkflowExpression<string> bodyshipaddr1 = null, WorkflowExpression<string> bodyshipaddr2 = null, WorkflowExpression<string> bodyshipcity = null, WorkflowExpression<string> bodyshipstate = null, WorkflowExpression<string> bodyshipzipcode = null, WorkflowExpression<string> bodyshipcountry = null, WorkflowExpression<string> bodyshipphone = null, WorkflowExpression<string> bodyshipemail = null, WorkflowExpression<bodyorderstatusInput> bodyorderstatus = null, WorkflowExpression<string> bodycustomstatus = null, WorkflowExpression<string> bodytaxdistrict = null, WorkflowExpression<double> bodytaxrate = null, WorkflowExpression<string> bodycampaign = null, WorkflowExpression<string> bodyordertax = null, WorkflowExpression<string> bodyshippingcost = null, WorkflowExpression<string> bodyshippingmethod = null, WorkflowExpression<double> bodycouponamount = null, WorkflowExpression<string> bodycouponcode = null, WorkflowExpression<string> bodypaymentmethod = null, WorkflowExpression<string> bodycomments = null, WorkflowExpression<bodylinedataInputItem[]> bodylinedata = null)
        {
            WorkflowExpression.Validate(bodyorderid, nameof(bodyorderid), required: false);
            WorkflowExpression.Validate(bodyorderdate, nameof(bodyorderdate), required: false);
            WorkflowExpression.Validate(bodyorderdescription, nameof(bodyorderdescription), required: false);
            WorkflowExpression.Validate(bodyaccount, nameof(bodyaccount), required: false);
            WorkflowExpression.Validate(bodyaccountname, nameof(bodyaccountname), required: false);
            WorkflowExpression.Validate(bodysalesrep, nameof(bodysalesrep), required: false);
            WorkflowExpression.Validate(bodyfirstname, nameof(bodyfirstname), required: false);
            WorkflowExpression.Validate(bodylastname, nameof(bodylastname), required: false);
            WorkflowExpression.Validate(bodybillemail, nameof(bodybillemail), required: false);
            WorkflowExpression.Validate(bodybilladdr1, nameof(bodybilladdr1), required: false);
            WorkflowExpression.Validate(bodybilladdr2, nameof(bodybilladdr2), required: false);
            WorkflowExpression.Validate(bodybillcity, nameof(bodybillcity), required: false);
            WorkflowExpression.Validate(bodybillstate, nameof(bodybillstate), required: false);
            WorkflowExpression.Validate(bodybillzipcode, nameof(bodybillzipcode), required: false);
            WorkflowExpression.Validate(bodybillcountry, nameof(bodybillcountry), required: false);
            WorkflowExpression.Validate(bodybillphone, nameof(bodybillphone), required: false);
            WorkflowExpression.Validate(bodybillfax, nameof(bodybillfax), required: false);
            WorkflowExpression.Validate(bodyshipcompany, nameof(bodyshipcompany), required: false);
            WorkflowExpression.Validate(bodyshipcontact, nameof(bodyshipcontact), required: false);
            WorkflowExpression.Validate(bodyshipaddr1, nameof(bodyshipaddr1), required: false);
            WorkflowExpression.Validate(bodyshipaddr2, nameof(bodyshipaddr2), required: false);
            WorkflowExpression.Validate(bodyshipcity, nameof(bodyshipcity), required: false);
            WorkflowExpression.Validate(bodyshipstate, nameof(bodyshipstate), required: false);
            WorkflowExpression.Validate(bodyshipzipcode, nameof(bodyshipzipcode), required: false);
            WorkflowExpression.Validate(bodyshipcountry, nameof(bodyshipcountry), required: false);
            WorkflowExpression.Validate(bodyshipphone, nameof(bodyshipphone), required: false);
            WorkflowExpression.Validate(bodyshipemail, nameof(bodyshipemail), required: false);
            WorkflowExpression.Validate(bodyorderstatus, nameof(bodyorderstatus), required: false);
            WorkflowExpression.Validate(bodycustomstatus, nameof(bodycustomstatus), required: false);
            WorkflowExpression.Validate(bodytaxdistrict, nameof(bodytaxdistrict), required: false);
            WorkflowExpression.Validate(bodytaxrate, nameof(bodytaxrate), required: false);
            WorkflowExpression.Validate(bodycampaign, nameof(bodycampaign), required: false);
            WorkflowExpression.Validate(bodyordertax, nameof(bodyordertax), required: false);
            WorkflowExpression.Validate(bodyshippingcost, nameof(bodyshippingcost), required: false);
            WorkflowExpression.Validate(bodyshippingmethod, nameof(bodyshippingmethod), required: false);
            WorkflowExpression.Validate(bodycouponamount, nameof(bodycouponamount), required: false);
            WorkflowExpression.Validate(bodycouponcode, nameof(bodycouponcode), required: false);
            WorkflowExpression.Validate(bodypaymentmethod, nameof(bodypaymentmethod), required: false);
            WorkflowExpression.Validate(bodycomments, nameof(bodycomments), required: false);
            WorkflowExpression.Validate(bodylinedata, nameof(bodylinedata), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/api/SO";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyorderid != null)
                {
                    body["orderid"] = ExpressionConverter.ConvertO(bodyorderid);
                    bodypropCount++;
                }

                if (bodyorderdate != null)
                {
                    body["orderdate"] = ExpressionConverter.ConvertO(bodyorderdate);
                    bodypropCount++;
                }

                if (bodyorderdescription != null)
                {
                    body["orderdescription"] = ExpressionConverter.ConvertO(bodyorderdescription);
                    bodypropCount++;
                }

                if (bodyaccount != null)
                {
                    body["account"] = ExpressionConverter.ConvertO(bodyaccount);
                    bodypropCount++;
                }

                if (bodyaccountname != null)
                {
                    body["accountname"] = ExpressionConverter.ConvertO(bodyaccountname);
                    bodypropCount++;
                }

                if (bodysalesrep != null)
                {
                    body["salesrep"] = ExpressionConverter.ConvertO(bodysalesrep);
                    bodypropCount++;
                }

                if (bodyfirstname != null)
                {
                    body["firstname"] = ExpressionConverter.ConvertO(bodyfirstname);
                    bodypropCount++;
                }

                if (bodylastname != null)
                {
                    body["lastname"] = ExpressionConverter.ConvertO(bodylastname);
                    bodypropCount++;
                }

                if (bodybillemail != null)
                {
                    body["billemail"] = ExpressionConverter.ConvertO(bodybillemail);
                    bodypropCount++;
                }

                if (bodybilladdr1 != null)
                {
                    body["billaddr1"] = ExpressionConverter.ConvertO(bodybilladdr1);
                    bodypropCount++;
                }

                if (bodybilladdr2 != null)
                {
                    body["billaddr2"] = ExpressionConverter.ConvertO(bodybilladdr2);
                    bodypropCount++;
                }

                if (bodybillcity != null)
                {
                    body["billcity"] = ExpressionConverter.ConvertO(bodybillcity);
                    bodypropCount++;
                }

                if (bodybillstate != null)
                {
                    body["billstate"] = ExpressionConverter.ConvertO(bodybillstate);
                    bodypropCount++;
                }

                if (bodybillzipcode != null)
                {
                    body["billzipcode"] = ExpressionConverter.ConvertO(bodybillzipcode);
                    bodypropCount++;
                }

                if (bodybillcountry != null)
                {
                    body["billcountry"] = ExpressionConverter.ConvertO(bodybillcountry);
                    bodypropCount++;
                }

                if (bodybillphone != null)
                {
                    body["billphone"] = ExpressionConverter.ConvertO(bodybillphone);
                    bodypropCount++;
                }

                if (bodybillfax != null)
                {
                    body["billfax"] = ExpressionConverter.ConvertO(bodybillfax);
                    bodypropCount++;
                }

                if (bodyshipcompany != null)
                {
                    body["shipcompany"] = ExpressionConverter.ConvertO(bodyshipcompany);
                    bodypropCount++;
                }

                if (bodyshipcontact != null)
                {
                    body["shipcontact"] = ExpressionConverter.ConvertO(bodyshipcontact);
                    bodypropCount++;
                }

                if (bodyshipaddr1 != null)
                {
                    body["shipaddr1"] = ExpressionConverter.ConvertO(bodyshipaddr1);
                    bodypropCount++;
                }

                if (bodyshipaddr2 != null)
                {
                    body["shipaddr2"] = ExpressionConverter.ConvertO(bodyshipaddr2);
                    bodypropCount++;
                }

                if (bodyshipcity != null)
                {
                    body["shipcity"] = ExpressionConverter.ConvertO(bodyshipcity);
                    bodypropCount++;
                }

                if (bodyshipstate != null)
                {
                    body["shipstate"] = ExpressionConverter.ConvertO(bodyshipstate);
                    bodypropCount++;
                }

                if (bodyshipzipcode != null)
                {
                    body["shipzipcode"] = ExpressionConverter.ConvertO(bodyshipzipcode);
                    bodypropCount++;
                }

                if (bodyshipcountry != null)
                {
                    body["shipcountry"] = ExpressionConverter.ConvertO(bodyshipcountry);
                    bodypropCount++;
                }

                if (bodyshipphone != null)
                {
                    body["shipphone"] = ExpressionConverter.ConvertO(bodyshipphone);
                    bodypropCount++;
                }

                if (bodyshipemail != null)
                {
                    body["shipemail"] = ExpressionConverter.ConvertO(bodyshipemail);
                    bodypropCount++;
                }

                if (bodyorderstatus != null)
                {
                    body["orderstatus"] = ExpressionConverter.ConvertO(bodyorderstatus);
                    bodypropCount++;
                }

                if (bodycustomstatus != null)
                {
                    body["customstatus"] = ExpressionConverter.ConvertO(bodycustomstatus);
                    bodypropCount++;
                }

                if (bodytaxdistrict != null)
                {
                    body["taxdistrict"] = ExpressionConverter.ConvertO(bodytaxdistrict);
                    bodypropCount++;
                }

                if (bodytaxrate != null)
                {
                    body["taxrate"] = ExpressionConverter.ConvertO(bodytaxrate);
                    bodypropCount++;
                }

                if (bodycampaign != null)
                {
                    body["campaign"] = ExpressionConverter.ConvertO(bodycampaign);
                    bodypropCount++;
                }

                if (bodyordertax != null)
                {
                    body["ordertax"] = ExpressionConverter.ConvertO(bodyordertax);
                    bodypropCount++;
                }

                if (bodyshippingcost != null)
                {
                    body["shippingcost"] = ExpressionConverter.ConvertO(bodyshippingcost);
                    bodypropCount++;
                }

                if (bodyshippingmethod != null)
                {
                    body["shippingmethod"] = ExpressionConverter.ConvertO(bodyshippingmethod);
                    bodypropCount++;
                }

                if (bodycouponamount != null)
                {
                    body["couponamount"] = ExpressionConverter.ConvertO(bodycouponamount);
                    bodypropCount++;
                }

                if (bodycouponcode != null)
                {
                    body["couponcode"] = ExpressionConverter.ConvertO(bodycouponcode);
                    bodypropCount++;
                }

                if (bodypaymentmethod != null)
                {
                    body["paymentmethod"] = ExpressionConverter.ConvertO(bodypaymentmethod);
                    bodypropCount++;
                }

                if (bodycomments != null)
                {
                    body["comments"] = ExpressionConverter.ConvertO(bodycomments);
                    bodypropCount++;
                }

                if (bodylinedata != null)
                {
                    body["linedata"] = ExpressionConverter.ConvertO(bodylinedata);
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
        [WorkflowExpressionFactory(nameof(__BuildSOGetValue))]
        public IBodyWorkflowAction<SOGetValueResponse> SOGetValue([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SOGetValueResponse> __BuildSOGetValue(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<SOGetValueResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/SO/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SOGetValueResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        [WorkflowExpressionFactory(nameof(__BuildSOPutValue))]
        public IWorkflowAction SOPutValue([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodycomments = null, [WorkflowExpression] Func<string> bodycustomstatus = null, [WorkflowExpression] Func<bodyorderstatusInput> bodyorderstatus = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSOPutValue(WorkflowExpression<string> id, WorkflowExpression<string> bodycomments = null, WorkflowExpression<string> bodycustomstatus = null, WorkflowExpression<bodyorderstatusInput> bodyorderstatus = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodycomments, nameof(bodycomments), required: false);
            WorkflowExpression.Validate(bodycustomstatus, nameof(bodycustomstatus), required: false);
            WorkflowExpression.Validate(bodyorderstatus, nameof(bodyorderstatus), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/SO/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycomments != null)
                {
                    body["comments"] = ExpressionConverter.ConvertO(bodycomments);
                    bodypropCount++;
                }

                if (bodycustomstatus != null)
                {
                    body["customstatus"] = ExpressionConverter.ConvertO(bodycustomstatus);
                    bodypropCount++;
                }

                if (bodyorderstatus != null)
                {
                    body["orderstatus"] = ExpressionConverter.ConvertO(bodyorderstatus);
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
        [WorkflowExpressionFactory(nameof(__BuildWorkOrderPostValue))]
        public IBodyWorkflowAction<JToken> WorkOrderPostValue([WorkflowExpression] Func<string> bodyfromaddress = null, [WorkflowExpression] Func<string> bodyfirstname = null, [WorkflowExpression] Func<string> bodylastname = null, [WorkflowExpression] Func<string> bodycompanyname = null, [WorkflowExpression] Func<string> bodybilladdr1 = null, [WorkflowExpression] Func<string> bodybilladdr2 = null, [WorkflowExpression] Func<string> bodybillcity = null, [WorkflowExpression] Func<string> bodybillstate = null, [WorkflowExpression] Func<string> bodybillzipcode = null, [WorkflowExpression] Func<string> bodybillcountry = null, [WorkflowExpression] Func<string> bodybillphone = null, [WorkflowExpression] Func<string> bodybillfax = null, [WorkflowExpression] Func<string> bodyserviceaddr1 = null, [WorkflowExpression] Func<string> bodyserviceaddr2 = null, [WorkflowExpression] Func<string> bodyservicecity = null, [WorkflowExpression] Func<string> bodyservicestate = null, [WorkflowExpression] Func<string> bodyservicezipcode = null, [WorkflowExpression] Func<string> bodyservicecountry = null, [WorkflowExpression] Func<string> bodyservicephone = null, [WorkflowExpression] Func<string> bodyreceiveddate = null, [WorkflowExpression] Func<string> bodyponumber = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<string> bodyreasoncode = null, [WorkflowExpression] Func<string> bodysource = null, [WorkflowExpression] Func<string> bodyassignedto = null, [WorkflowExpression] Func<string> bodybackup = null, [WorkflowExpression] Func<bodypriorityInput> bodypriority = null, [WorkflowExpression] Func<string> bodyduedate = null, [WorkflowExpression] Func<string> bodysubject = null, [WorkflowExpression] Func<string> bodybody = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildWorkOrderPostValue(WorkflowExpression<string> bodyfromaddress = null, WorkflowExpression<string> bodyfirstname = null, WorkflowExpression<string> bodylastname = null, WorkflowExpression<string> bodycompanyname = null, WorkflowExpression<string> bodybilladdr1 = null, WorkflowExpression<string> bodybilladdr2 = null, WorkflowExpression<string> bodybillcity = null, WorkflowExpression<string> bodybillstate = null, WorkflowExpression<string> bodybillzipcode = null, WorkflowExpression<string> bodybillcountry = null, WorkflowExpression<string> bodybillphone = null, WorkflowExpression<string> bodybillfax = null, WorkflowExpression<string> bodyserviceaddr1 = null, WorkflowExpression<string> bodyserviceaddr2 = null, WorkflowExpression<string> bodyservicecity = null, WorkflowExpression<string> bodyservicestate = null, WorkflowExpression<string> bodyservicezipcode = null, WorkflowExpression<string> bodyservicecountry = null, WorkflowExpression<string> bodyservicephone = null, WorkflowExpression<string> bodyreceiveddate = null, WorkflowExpression<string> bodyponumber = null, WorkflowExpression<string> bodystatus = null, WorkflowExpression<string> bodyreasoncode = null, WorkflowExpression<string> bodysource = null, WorkflowExpression<string> bodyassignedto = null, WorkflowExpression<string> bodybackup = null, WorkflowExpression<bodypriorityInput> bodypriority = null, WorkflowExpression<string> bodyduedate = null, WorkflowExpression<string> bodysubject = null, WorkflowExpression<string> bodybody = null)
        {
            WorkflowExpression.Validate(bodyfromaddress, nameof(bodyfromaddress), required: false);
            WorkflowExpression.Validate(bodyfirstname, nameof(bodyfirstname), required: false);
            WorkflowExpression.Validate(bodylastname, nameof(bodylastname), required: false);
            WorkflowExpression.Validate(bodycompanyname, nameof(bodycompanyname), required: false);
            WorkflowExpression.Validate(bodybilladdr1, nameof(bodybilladdr1), required: false);
            WorkflowExpression.Validate(bodybilladdr2, nameof(bodybilladdr2), required: false);
            WorkflowExpression.Validate(bodybillcity, nameof(bodybillcity), required: false);
            WorkflowExpression.Validate(bodybillstate, nameof(bodybillstate), required: false);
            WorkflowExpression.Validate(bodybillzipcode, nameof(bodybillzipcode), required: false);
            WorkflowExpression.Validate(bodybillcountry, nameof(bodybillcountry), required: false);
            WorkflowExpression.Validate(bodybillphone, nameof(bodybillphone), required: false);
            WorkflowExpression.Validate(bodybillfax, nameof(bodybillfax), required: false);
            WorkflowExpression.Validate(bodyserviceaddr1, nameof(bodyserviceaddr1), required: false);
            WorkflowExpression.Validate(bodyserviceaddr2, nameof(bodyserviceaddr2), required: false);
            WorkflowExpression.Validate(bodyservicecity, nameof(bodyservicecity), required: false);
            WorkflowExpression.Validate(bodyservicestate, nameof(bodyservicestate), required: false);
            WorkflowExpression.Validate(bodyservicezipcode, nameof(bodyservicezipcode), required: false);
            WorkflowExpression.Validate(bodyservicecountry, nameof(bodyservicecountry), required: false);
            WorkflowExpression.Validate(bodyservicephone, nameof(bodyservicephone), required: false);
            WorkflowExpression.Validate(bodyreceiveddate, nameof(bodyreceiveddate), required: false);
            WorkflowExpression.Validate(bodyponumber, nameof(bodyponumber), required: false);
            WorkflowExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowExpression.Validate(bodyreasoncode, nameof(bodyreasoncode), required: false);
            WorkflowExpression.Validate(bodysource, nameof(bodysource), required: false);
            WorkflowExpression.Validate(bodyassignedto, nameof(bodyassignedto), required: false);
            WorkflowExpression.Validate(bodybackup, nameof(bodybackup), required: false);
            WorkflowExpression.Validate(bodypriority, nameof(bodypriority), required: false);
            WorkflowExpression.Validate(bodyduedate, nameof(bodyduedate), required: false);
            WorkflowExpression.Validate(bodysubject, nameof(bodysubject), required: false);
            WorkflowExpression.Validate(bodybody, nameof(bodybody), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/api/WorkOrder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfromaddress != null)
                {
                    body["fromaddress"] = ExpressionConverter.ConvertO(bodyfromaddress);
                    bodypropCount++;
                }

                if (bodyfirstname != null)
                {
                    body["firstname"] = ExpressionConverter.ConvertO(bodyfirstname);
                    bodypropCount++;
                }

                if (bodylastname != null)
                {
                    body["lastname"] = ExpressionConverter.ConvertO(bodylastname);
                    bodypropCount++;
                }

                if (bodycompanyname != null)
                {
                    body["companyname"] = ExpressionConverter.ConvertO(bodycompanyname);
                    bodypropCount++;
                }

                if (bodybilladdr1 != null)
                {
                    body["billaddr1"] = ExpressionConverter.ConvertO(bodybilladdr1);
                    bodypropCount++;
                }

                if (bodybilladdr2 != null)
                {
                    body["billaddr2"] = ExpressionConverter.ConvertO(bodybilladdr2);
                    bodypropCount++;
                }

                if (bodybillcity != null)
                {
                    body["billcity"] = ExpressionConverter.ConvertO(bodybillcity);
                    bodypropCount++;
                }

                if (bodybillstate != null)
                {
                    body["billstate"] = ExpressionConverter.ConvertO(bodybillstate);
                    bodypropCount++;
                }

                if (bodybillzipcode != null)
                {
                    body["billzipcode"] = ExpressionConverter.ConvertO(bodybillzipcode);
                    bodypropCount++;
                }

                if (bodybillcountry != null)
                {
                    body["billcountry"] = ExpressionConverter.ConvertO(bodybillcountry);
                    bodypropCount++;
                }

                if (bodybillphone != null)
                {
                    body["billphone"] = ExpressionConverter.ConvertO(bodybillphone);
                    bodypropCount++;
                }

                if (bodybillfax != null)
                {
                    body["billfax"] = ExpressionConverter.ConvertO(bodybillfax);
                    bodypropCount++;
                }

                if (bodyserviceaddr1 != null)
                {
                    body["serviceaddr1"] = ExpressionConverter.ConvertO(bodyserviceaddr1);
                    bodypropCount++;
                }

                if (bodyserviceaddr2 != null)
                {
                    body["serviceaddr2"] = ExpressionConverter.ConvertO(bodyserviceaddr2);
                    bodypropCount++;
                }

                if (bodyservicecity != null)
                {
                    body["servicecity"] = ExpressionConverter.ConvertO(bodyservicecity);
                    bodypropCount++;
                }

                if (bodyservicestate != null)
                {
                    body["servicestate"] = ExpressionConverter.ConvertO(bodyservicestate);
                    bodypropCount++;
                }

                if (bodyservicezipcode != null)
                {
                    body["servicezipcode"] = ExpressionConverter.ConvertO(bodyservicezipcode);
                    bodypropCount++;
                }

                if (bodyservicecountry != null)
                {
                    body["servicecountry"] = ExpressionConverter.ConvertO(bodyservicecountry);
                    bodypropCount++;
                }

                if (bodyservicephone != null)
                {
                    body["servicephone"] = ExpressionConverter.ConvertO(bodyservicephone);
                    bodypropCount++;
                }

                if (bodyreceiveddate != null)
                {
                    body["receiveddate"] = ExpressionConverter.ConvertO(bodyreceiveddate);
                    bodypropCount++;
                }

                if (bodyponumber != null)
                {
                    body["ponumber"] = ExpressionConverter.ConvertO(bodyponumber);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(bodystatus);
                    bodypropCount++;
                }

                if (bodyreasoncode != null)
                {
                    body["reasoncode"] = ExpressionConverter.ConvertO(bodyreasoncode);
                    bodypropCount++;
                }

                if (bodysource != null)
                {
                    body["source"] = ExpressionConverter.ConvertO(bodysource);
                    bodypropCount++;
                }

                if (bodyassignedto != null)
                {
                    body["assignedto"] = ExpressionConverter.ConvertO(bodyassignedto);
                    bodypropCount++;
                }

                if (bodybackup != null)
                {
                    body["backup"] = ExpressionConverter.ConvertO(bodybackup);
                    bodypropCount++;
                }

                if (bodypriority != null)
                {
                    body["priority"] = ExpressionConverter.ConvertO(bodypriority);
                    bodypropCount++;
                }

                if (bodyduedate != null)
                {
                    body["duedate"] = ExpressionConverter.ConvertO(bodyduedate);
                    bodypropCount++;
                }

                if (bodysubject != null)
                {
                    body["subject"] = ExpressionConverter.ConvertO(bodysubject);
                    bodypropCount++;
                }

                if (bodybody != null)
                {
                    body["body"] = ExpressionConverter.ConvertO(bodybody);
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
        [WorkflowExpressionFactory(nameof(__BuildWorkOrderGetValue))]
        public IBodyWorkflowAction<WorkOrderGetValueResponse> WorkOrderGetValue([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<WorkOrderGetValueResponse> __BuildWorkOrderGetValue(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<WorkOrderGetValueResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/WorkOrder/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<WorkOrderGetValueResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        [WorkflowExpressionFactory(nameof(__BuildWorkOrderPutValue))]
        public IWorkflowAction WorkOrderPutValue([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyponumber = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<string> bodyreasoncode = null, [WorkflowExpression] Func<string> bodysource = null, [WorkflowExpression] Func<string> bodyassignedto = null, [WorkflowExpression] Func<string> bodybackup = null, [WorkflowExpression] Func<bodypriorityInput> bodypriority = null, [WorkflowExpression] Func<string> bodyduedate = null, [WorkflowExpression] Func<string> bodysubject = null, [WorkflowExpression] Func<string> bodybody = null, [WorkflowExpression] Func<bool> bodyhistory = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildWorkOrderPutValue(WorkflowExpression<string> id, WorkflowExpression<string> bodyponumber = null, WorkflowExpression<string> bodystatus = null, WorkflowExpression<string> bodyreasoncode = null, WorkflowExpression<string> bodysource = null, WorkflowExpression<string> bodyassignedto = null, WorkflowExpression<string> bodybackup = null, WorkflowExpression<bodypriorityInput> bodypriority = null, WorkflowExpression<string> bodyduedate = null, WorkflowExpression<string> bodysubject = null, WorkflowExpression<string> bodybody = null, WorkflowExpression<bool> bodyhistory = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodyponumber, nameof(bodyponumber), required: false);
            WorkflowExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowExpression.Validate(bodyreasoncode, nameof(bodyreasoncode), required: false);
            WorkflowExpression.Validate(bodysource, nameof(bodysource), required: false);
            WorkflowExpression.Validate(bodyassignedto, nameof(bodyassignedto), required: false);
            WorkflowExpression.Validate(bodybackup, nameof(bodybackup), required: false);
            WorkflowExpression.Validate(bodypriority, nameof(bodypriority), required: false);
            WorkflowExpression.Validate(bodyduedate, nameof(bodyduedate), required: false);
            WorkflowExpression.Validate(bodysubject, nameof(bodysubject), required: false);
            WorkflowExpression.Validate(bodybody, nameof(bodybody), required: false);
            WorkflowExpression.Validate(bodyhistory, nameof(bodyhistory), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/WorkOrder/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyponumber != null)
                {
                    body["ponumber"] = ExpressionConverter.ConvertO(bodyponumber);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(bodystatus);
                    bodypropCount++;
                }

                if (bodyreasoncode != null)
                {
                    body["reasoncode"] = ExpressionConverter.ConvertO(bodyreasoncode);
                    bodypropCount++;
                }

                if (bodysource != null)
                {
                    body["source"] = ExpressionConverter.ConvertO(bodysource);
                    bodypropCount++;
                }

                if (bodyassignedto != null)
                {
                    body["assignedto"] = ExpressionConverter.ConvertO(bodyassignedto);
                    bodypropCount++;
                }

                if (bodybackup != null)
                {
                    body["backup"] = ExpressionConverter.ConvertO(bodybackup);
                    bodypropCount++;
                }

                if (bodypriority != null)
                {
                    body["priority"] = ExpressionConverter.ConvertO(bodypriority);
                    bodypropCount++;
                }

                if (bodyduedate != null)
                {
                    body["duedate"] = ExpressionConverter.ConvertO(bodyduedate);
                    bodypropCount++;
                }

                if (bodysubject != null)
                {
                    body["subject"] = ExpressionConverter.ConvertO(bodysubject);
                    bodypropCount++;
                }

                if (bodybody != null)
                {
                    body["body"] = ExpressionConverter.ConvertO(bodybody);
                    bodypropCount++;
                }

                if (bodyhistory != null)
                {
                    body["history"] = ExpressionConverter.ConvertO(bodyhistory);
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

        [WorkflowExpressionFactory(nameof(__BuildNewMembersLeads))]
        public IBodyWorkflowTrigger<NewMembersLeadsResponseItem[]> NewMembersLeads([WorkflowExpression] Func<int> promotionID,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<NewMembersLeadsResponseItem[]> __BuildNewMembersLeads(WorkflowExpression<int> promotionID,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(promotionID, nameof(promotionID), required: true);
            return new DeferredBodyTrigger<NewMembersLeadsResponseItem[]>(() =>
            {
                var apiCallPath = "/trigger/api/new_members_leads";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["PromotionID"] = ExpressionConverter.Convert(promotionID);
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

        [WorkflowExpressionFactory(nameof(__BuildOrderStatusChanged))]
        public IBodyWorkflowTrigger<OrderStatusChangedResponseItem[]> OrderStatusChanged([WorkflowExpression] Func<string> status,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<OrderStatusChangedResponseItem[]> __BuildOrderStatusChanged(WorkflowExpression<string> status,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(status, nameof(status), required: true);
            return new DeferredBodyTrigger<OrderStatusChangedResponseItem[]>(() =>
            {
                var apiCallPath = "/trigger/api/order_status";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Status"] = ExpressionConverter.Convert(status);
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

        [WorkflowExpressionFactory(nameof(__BuildWorkOrderStatusChanged))]
        public IBodyWorkflowTrigger<WorkOrderStatusChangedResponseItem[]> WorkOrderStatusChanged([WorkflowExpression] Func<string> status,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<WorkOrderStatusChangedResponseItem[]> __BuildWorkOrderStatusChanged(WorkflowExpression<string> status,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(status, nameof(status), required: true);
            return new DeferredBodyTrigger<WorkOrderStatusChangedResponseItem[]>(() =>
            {
                var apiCallPath = "/trigger/api/wo_status";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Status"] = ExpressionConverter.Convert(status);
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