//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Blackbaudfundraising
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BlackbaudfundraisingActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfundraising")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfConstituentAppealRead> ListConstituentAppeals(Expression<Func<string>> constituentId)
        {
            var apiCallPath = String.Format("/constituent/v1/constituents/{0}/appeals", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ConstituentApiApiCollectionOfConstituentAppealRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfundraising")]
        public IBodyWorkflowAction<FundraisingApiApiCollectionOfAppealRead> ListAppeals(Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<bool>> includeInactive = null, Expression<Func<string>> dateAdded = null, Expression<Func<string>> lastModified = null)
        {
            var apiCallPath = "/fundraising/v1/appeals";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            if (includeInactive != null)
                callPayload.Queries["include_inactive"] = ExpressionConverter.Convert(includeInactive);
            if (dateAdded != null)
                callPayload.Queries["date_added"] = ExpressionConverter.Convert(dateAdded);
            if (lastModified != null)
                callPayload.Queries["last_modified"] = ExpressionConverter.Convert(lastModified);
            return new ApiConnectionAction<FundraisingApiApiCollectionOfAppealRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfundraising")]
        public IBodyWorkflowAction<FundraisingApiAppealRead> GetAppeal(Expression<Func<string>> appealId)
        {
            var apiCallPath = String.Format("/fundraising/v1/appeals/{0}", ExpressionConverter.ConvertWithUrlEncoding(appealId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<FundraisingApiAppealRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfundraising")]
        public IBodyWorkflowAction<FundraisingApiApiCollectionOfAppealAttachmentRead> ListAppealAttachments(Expression<Func<string>> appealId)
        {
            var apiCallPath = String.Format("/fundraising/v1/appeals/{0}/attachments", ExpressionConverter.ConvertWithUrlEncoding(appealId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<FundraisingApiApiCollectionOfAppealAttachmentRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfundraising")]
        public IBodyWorkflowAction<FundraisingApiApiCollectionOfAppealCustomFieldRead> ListAppealCustomFields(Expression<Func<string>> appealId)
        {
            var apiCallPath = String.Format("/fundraising/v1/appeals/{0}/customfields", ExpressionConverter.ConvertWithUrlEncoding(appealId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<FundraisingApiApiCollectionOfAppealCustomFieldRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfundraising")]
        public IBodyWorkflowAction<FundraisingApiCreatedAppealAttachment> CreateAppealAttachment(Expression<Func<string>> bodyappealID, Expression<Func<bodytypeInput>> bodytype, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodyuRL = null, Expression<Func<string>> bodyfileName = null, Expression<Func<string>> bodyfileID = null, Expression<Func<string>> bodythumbnailID = null, Expression<Func<string[]>> bodytags = null)
        {
            var apiCallPath = "/fundraising/v1/appeals/attachments";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["parent_id"] = ExpressionConverter.ConvertO(bodyappealID);
            bodypropCount++;
            body["type"] = ExpressionConverter.ConvertO(bodytype);
            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodydate != null)
            {
                body["date"] = ExpressionConverter.ConvertO(bodydate);
                bodypropCount++;
            }

            if (bodyuRL != null)
            {
                body["url"] = ExpressionConverter.ConvertO(bodyuRL);
                bodypropCount++;
            }

            if (bodyfileName != null)
            {
                body["file_name"] = ExpressionConverter.ConvertO(bodyfileName);
                bodypropCount++;
            }

            if (bodyfileID != null)
            {
                body["file_id"] = ExpressionConverter.ConvertO(bodyfileID);
                bodypropCount++;
            }

            if (bodythumbnailID != null)
            {
                body["thumbnail_id"] = ExpressionConverter.ConvertO(bodythumbnailID);
                bodypropCount++;
            }

            if (bodytags != null)
            {
                body["tags"] = ExpressionConverter.ConvertO(bodytags);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<FundraisingApiCreatedAppealAttachment>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfundraising")]
        public IWorkflowAction EditAppealAttachment(Expression<Func<string>> attachmentId, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodyuRL = null, Expression<Func<string[]>> bodytags = null)
        {
            var apiCallPath = String.Format("/fundraising/v1/appeals/attachments/{0}", ExpressionConverter.ConvertWithUrlEncoding(attachmentId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodydate != null)
            {
                body["date"] = ExpressionConverter.ConvertO(bodydate);
                bodypropCount++;
            }

            if (bodyuRL != null)
            {
                body["url"] = ExpressionConverter.ConvertO(bodyuRL);
                bodypropCount++;
            }

            if (bodytags != null)
            {
                body["tags"] = ExpressionConverter.ConvertO(bodytags);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfundraising")]
        public IBodyWorkflowAction<FundraisingApiCreatedAppealCustomField> CreateAppealCustomField(Expression<Func<string>> bodyappealID, Expression<Func<string>> bodycategory, Expression<Func<object>> bodyvalue = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodycomment = null)
        {
            var apiCallPath = "/fundraising/v1/appeals/customfields";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["parent_id"] = ExpressionConverter.ConvertO(bodyappealID);
            bodypropCount++;
            body["category"] = ExpressionConverter.ConvertO(bodycategory);
            if (bodyvalue != null)
            {
                body["value"] = ExpressionConverter.ConvertO(bodyvalue);
                bodypropCount++;
            }

            if (bodydate != null)
            {
                body["date"] = ExpressionConverter.ConvertO(bodydate);
                bodypropCount++;
            }

            if (bodycomment != null)
            {
                body["comment"] = ExpressionConverter.ConvertO(bodycomment);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<FundraisingApiCreatedAppealCustomField>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfundraising")]
        public IWorkflowAction EditAppealCustomField(Expression<Func<string>> customFieldId, Expression<Func<string>> bodycategory = null, Expression<Func<object>> bodyvalue = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodycomment = null)
        {
            var apiCallPath = String.Format("/fundraising/v1/appeals/customfields/{0}", ExpressionConverter.ConvertWithUrlEncoding(customFieldId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodycategory != null)
            {
                body["category"] = ExpressionConverter.ConvertO(bodycategory);
                bodypropCount++;
            }

            if (bodyvalue != null)
            {
                body["value"] = ExpressionConverter.ConvertO(bodyvalue);
                bodypropCount++;
            }

            if (bodydate != null)
            {
                body["date"] = ExpressionConverter.ConvertO(bodydate);
                bodypropCount++;
            }

            if (bodycomment != null)
            {
                body["comment"] = ExpressionConverter.ConvertO(bodycomment);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfundraising")]
        public IBodyWorkflowAction<FundraisingApiApiCollectionOfCampaignRead> ListCampaigns(Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<bool>> includeInactive = null, Expression<Func<string>> dateAdded = null, Expression<Func<string>> lastModified = null)
        {
            var apiCallPath = "/fundraising/v1/campaigns";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            if (includeInactive != null)
                callPayload.Queries["include_inactive"] = ExpressionConverter.Convert(includeInactive);
            if (dateAdded != null)
                callPayload.Queries["date_added"] = ExpressionConverter.Convert(dateAdded);
            if (lastModified != null)
                callPayload.Queries["last_modified"] = ExpressionConverter.Convert(lastModified);
            return new ApiConnectionAction<FundraisingApiApiCollectionOfCampaignRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfundraising")]
        public IBodyWorkflowAction<FundraisingApiCampaignRead> GetCampaign(Expression<Func<string>> campaignId)
        {
            var apiCallPath = String.Format("/fundraising/v1/campaigns/{0}", ExpressionConverter.ConvertWithUrlEncoding(campaignId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<FundraisingApiCampaignRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfundraising")]
        public IBodyWorkflowAction<FundraisingApiApiCollectionOfCampaignAttachmentRead> ListCampaignAttachments(Expression<Func<string>> campaignId)
        {
            var apiCallPath = String.Format("/fundraising/v1/campaigns/{0}/attachments", ExpressionConverter.ConvertWithUrlEncoding(campaignId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<FundraisingApiApiCollectionOfCampaignAttachmentRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfundraising")]
        public IBodyWorkflowAction<FundraisingApiApiCollectionOfCampaignCustomFieldRead> ListCampaignCustomFields(Expression<Func<string>> campaignId)
        {
            var apiCallPath = String.Format("/fundraising/v1/campaigns/{0}/customfields", ExpressionConverter.ConvertWithUrlEncoding(campaignId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<FundraisingApiApiCollectionOfCampaignCustomFieldRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfundraising")]
        public IBodyWorkflowAction<FundraisingApiCreatedCampaignAttachment> CreateCampaignAttachment(Expression<Func<string>> bodycampaignID, Expression<Func<bodytypeInput>> bodytype, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodyuRL = null, Expression<Func<string>> bodyfileName = null, Expression<Func<string>> bodyfileID = null, Expression<Func<string>> bodythumbnailID = null, Expression<Func<string[]>> bodytags = null)
        {
            var apiCallPath = "/fundraising/v1/campaigns/attachments";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["parent_id"] = ExpressionConverter.ConvertO(bodycampaignID);
            bodypropCount++;
            body["type"] = ExpressionConverter.ConvertO(bodytype);
            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodydate != null)
            {
                body["date"] = ExpressionConverter.ConvertO(bodydate);
                bodypropCount++;
            }

            if (bodyuRL != null)
            {
                body["url"] = ExpressionConverter.ConvertO(bodyuRL);
                bodypropCount++;
            }

            if (bodyfileName != null)
            {
                body["file_name"] = ExpressionConverter.ConvertO(bodyfileName);
                bodypropCount++;
            }

            if (bodyfileID != null)
            {
                body["file_id"] = ExpressionConverter.ConvertO(bodyfileID);
                bodypropCount++;
            }

            if (bodythumbnailID != null)
            {
                body["thumbnail_id"] = ExpressionConverter.ConvertO(bodythumbnailID);
                bodypropCount++;
            }

            if (bodytags != null)
            {
                body["tags"] = ExpressionConverter.ConvertO(bodytags);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<FundraisingApiCreatedCampaignAttachment>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfundraising")]
        public IWorkflowAction EditCampaignAttachment(Expression<Func<string>> attachmentId, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodyuRL = null, Expression<Func<string[]>> bodytags = null)
        {
            var apiCallPath = String.Format("/fundraising/v1/campaigns/attachments/{0}", ExpressionConverter.ConvertWithUrlEncoding(attachmentId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodydate != null)
            {
                body["date"] = ExpressionConverter.ConvertO(bodydate);
                bodypropCount++;
            }

            if (bodyuRL != null)
            {
                body["url"] = ExpressionConverter.ConvertO(bodyuRL);
                bodypropCount++;
            }

            if (bodytags != null)
            {
                body["tags"] = ExpressionConverter.ConvertO(bodytags);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfundraising")]
        public IBodyWorkflowAction<FundraisingApiCreatedCampaignCustomField> CreateCampaignCustomField(Expression<Func<string>> bodycampaignID, Expression<Func<string>> bodycategory, Expression<Func<object>> bodyvalue = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodycomment = null)
        {
            var apiCallPath = "/fundraising/v1/campaigns/customfields";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["parent_id"] = ExpressionConverter.ConvertO(bodycampaignID);
            bodypropCount++;
            body["category"] = ExpressionConverter.ConvertO(bodycategory);
            if (bodyvalue != null)
            {
                body["value"] = ExpressionConverter.ConvertO(bodyvalue);
                bodypropCount++;
            }

            if (bodydate != null)
            {
                body["date"] = ExpressionConverter.ConvertO(bodydate);
                bodypropCount++;
            }

            if (bodycomment != null)
            {
                body["comment"] = ExpressionConverter.ConvertO(bodycomment);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<FundraisingApiCreatedCampaignCustomField>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfundraising")]
        public IWorkflowAction EditCampaignCustomField(Expression<Func<string>> customFieldId, Expression<Func<string>> bodycategory = null, Expression<Func<object>> bodyvalue = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodycomment = null)
        {
            var apiCallPath = String.Format("/fundraising/v1/campaigns/customfields/{0}", ExpressionConverter.ConvertWithUrlEncoding(customFieldId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodycategory != null)
            {
                body["category"] = ExpressionConverter.ConvertO(bodycategory);
                bodypropCount++;
            }

            if (bodyvalue != null)
            {
                body["value"] = ExpressionConverter.ConvertO(bodyvalue);
                bodypropCount++;
            }

            if (bodydate != null)
            {
                body["date"] = ExpressionConverter.ConvertO(bodydate);
                bodypropCount++;
            }

            if (bodycomment != null)
            {
                body["comment"] = ExpressionConverter.ConvertO(bodycomment);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfundraising")]
        public IBodyWorkflowAction<FundraisingApiApiCollectionOfFundRead> ListFunds(Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<bool>> includeInactive = null, Expression<Func<string>> dateAdded = null, Expression<Func<string>> lastModified = null)
        {
            var apiCallPath = "/fundraising/v1/funds";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            if (includeInactive != null)
                callPayload.Queries["include_inactive"] = ExpressionConverter.Convert(includeInactive);
            if (dateAdded != null)
                callPayload.Queries["date_added"] = ExpressionConverter.Convert(dateAdded);
            if (lastModified != null)
                callPayload.Queries["last_modified"] = ExpressionConverter.Convert(lastModified);
            return new ApiConnectionAction<FundraisingApiApiCollectionOfFundRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfundraising")]
        public IBodyWorkflowAction<FundraisingApiFundRead> GetFund(Expression<Func<string>> fundId)
        {
            var apiCallPath = String.Format("/fundraising/v1/funds/{0}", ExpressionConverter.ConvertWithUrlEncoding(fundId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<FundraisingApiFundRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfundraising")]
        public IBodyWorkflowAction<FundraisingApiApiCollectionOfFundAttachmentRead> ListFundAttachments(Expression<Func<string>> fundId)
        {
            var apiCallPath = String.Format("/fundraising/v1/funds/{0}/attachments", ExpressionConverter.ConvertWithUrlEncoding(fundId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<FundraisingApiApiCollectionOfFundAttachmentRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfundraising")]
        public IBodyWorkflowAction<FundraisingApiApiCollectionOfFundCustomFieldRead> ListFundCustomFields(Expression<Func<string>> fundId)
        {
            var apiCallPath = String.Format("/fundraising/v1/funds/{0}/customfields", ExpressionConverter.ConvertWithUrlEncoding(fundId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<FundraisingApiApiCollectionOfFundCustomFieldRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfundraising")]
        public IBodyWorkflowAction<FundraisingApiCreatedFundAttachment> CreateFundAttachment(Expression<Func<string>> bodyfundID, Expression<Func<bodytypeInput>> bodytype, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodyuRL = null, Expression<Func<string>> bodyfileName = null, Expression<Func<string>> bodyfileID = null, Expression<Func<string>> bodythumbnailID = null, Expression<Func<string[]>> bodytags = null)
        {
            var apiCallPath = "/fundraising/v1/funds/attachments";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["parent_id"] = ExpressionConverter.ConvertO(bodyfundID);
            bodypropCount++;
            body["type"] = ExpressionConverter.ConvertO(bodytype);
            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodydate != null)
            {
                body["date"] = ExpressionConverter.ConvertO(bodydate);
                bodypropCount++;
            }

            if (bodyuRL != null)
            {
                body["url"] = ExpressionConverter.ConvertO(bodyuRL);
                bodypropCount++;
            }

            if (bodyfileName != null)
            {
                body["file_name"] = ExpressionConverter.ConvertO(bodyfileName);
                bodypropCount++;
            }

            if (bodyfileID != null)
            {
                body["file_id"] = ExpressionConverter.ConvertO(bodyfileID);
                bodypropCount++;
            }

            if (bodythumbnailID != null)
            {
                body["thumbnail_id"] = ExpressionConverter.ConvertO(bodythumbnailID);
                bodypropCount++;
            }

            if (bodytags != null)
            {
                body["tags"] = ExpressionConverter.ConvertO(bodytags);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<FundraisingApiCreatedFundAttachment>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfundraising")]
        public IWorkflowAction EditFundAttachment(Expression<Func<string>> attachmentId, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodyuRL = null, Expression<Func<string[]>> bodytags = null)
        {
            var apiCallPath = String.Format("/fundraising/v1/funds/attachments/{0}", ExpressionConverter.ConvertWithUrlEncoding(attachmentId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodydate != null)
            {
                body["date"] = ExpressionConverter.ConvertO(bodydate);
                bodypropCount++;
            }

            if (bodyuRL != null)
            {
                body["url"] = ExpressionConverter.ConvertO(bodyuRL);
                bodypropCount++;
            }

            if (bodytags != null)
            {
                body["tags"] = ExpressionConverter.ConvertO(bodytags);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfundraising")]
        public IBodyWorkflowAction<FundraisingApiCreatedFundCustomField> CreateFundCustomField(Expression<Func<string>> bodyfundID, Expression<Func<string>> bodycategory, Expression<Func<object>> bodyvalue = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodycomment = null)
        {
            var apiCallPath = "/fundraising/v1/funds/customfields";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["parent_id"] = ExpressionConverter.ConvertO(bodyfundID);
            bodypropCount++;
            body["category"] = ExpressionConverter.ConvertO(bodycategory);
            if (bodyvalue != null)
            {
                body["value"] = ExpressionConverter.ConvertO(bodyvalue);
                bodypropCount++;
            }

            if (bodydate != null)
            {
                body["date"] = ExpressionConverter.ConvertO(bodydate);
                bodypropCount++;
            }

            if (bodycomment != null)
            {
                body["comment"] = ExpressionConverter.ConvertO(bodycomment);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<FundraisingApiCreatedFundCustomField>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfundraising")]
        public IWorkflowAction EditFundCustomField(Expression<Func<string>> customFieldId, Expression<Func<string>> bodycategory = null, Expression<Func<object>> bodyvalue = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodycomment = null)
        {
            var apiCallPath = String.Format("/fundraising/v1/funds/customfields/{0}", ExpressionConverter.ConvertWithUrlEncoding(customFieldId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodycategory != null)
            {
                body["category"] = ExpressionConverter.ConvertO(bodycategory);
                bodypropCount++;
            }

            if (bodyvalue != null)
            {
                body["value"] = ExpressionConverter.ConvertO(bodyvalue);
                bodypropCount++;
            }

            if (bodydate != null)
            {
                body["date"] = ExpressionConverter.ConvertO(bodydate);
                bodypropCount++;
            }

            if (bodycomment != null)
            {
                body["comment"] = ExpressionConverter.ConvertO(bodycomment);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfundraising")]
        public IBodyWorkflowAction<FundraisingApiApiCollectionOfPackageRead> ListPackages(Expression<Func<string>> appealId = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<bool>> includeInactive = null, Expression<Func<string>> dateAdded = null, Expression<Func<string>> lastModified = null)
        {
            var apiCallPath = "/fundraising/v1/packages";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (appealId != null)
                callPayload.Queries["appeal_id"] = ExpressionConverter.Convert(appealId);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            if (includeInactive != null)
                callPayload.Queries["include_inactive"] = ExpressionConverter.Convert(includeInactive);
            if (dateAdded != null)
                callPayload.Queries["date_added"] = ExpressionConverter.Convert(dateAdded);
            if (lastModified != null)
                callPayload.Queries["last_modified"] = ExpressionConverter.Convert(lastModified);
            return new ApiConnectionAction<FundraisingApiApiCollectionOfPackageRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfundraising")]
        public IBodyWorkflowAction<FundraisingApiPackageRead> GetPackage(Expression<Func<string>> packageId)
        {
            var apiCallPath = String.Format("/fundraising/v1/packages/{0}", ExpressionConverter.ConvertWithUrlEncoding(packageId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<FundraisingApiPackageRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfundraising")]
        public IBodyWorkflowAction<NXTDataIntegrationApiCreatedAppeal> CreateAppeal(Expression<Func<string>> bodylookupID, Expression<Func<string>> bodydescription, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodyendDate = null, Expression<Func<int>> bodycategory = null, Expression<Func<double>> bodygoal = null, Expression<Func<double>> bodydefaultGiftAmount = null, Expression<Func<int>> bodynumberSolicited = null, Expression<Func<string>> bodynotes = null, Expression<Func<int>> bodydefaultCampaignID = null, Expression<Func<int>> bodydefaultFundID = null, Expression<Func<bool>> bodyinactive = null)
        {
            var apiCallPath = "/nxt-data-integration/v1/re/appeals";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["appeal_id"] = ExpressionConverter.ConvertO(bodylookupID);
            bodypropCount++;
            body["description"] = ExpressionConverter.ConvertO(bodydescription);
            if (bodystartDate != null)
            {
                body["start_date"] = ExpressionConverter.ConvertO(bodystartDate);
                bodypropCount++;
            }

            if (bodyendDate != null)
            {
                body["end_date"] = ExpressionConverter.ConvertO(bodyendDate);
                bodypropCount++;
            }

            if (bodycategory != null)
            {
                body["appeal_category_id"] = ExpressionConverter.ConvertO(bodycategory);
                bodypropCount++;
            }

            if (bodygoal != null)
            {
                body["goal"] = ExpressionConverter.ConvertO(bodygoal);
                bodypropCount++;
            }

            if (bodydefaultGiftAmount != null)
            {
                body["default_gift_amount"] = ExpressionConverter.ConvertO(bodydefaultGiftAmount);
                bodypropCount++;
            }

            if (bodynumberSolicited != null)
            {
                body["number_solicited"] = ExpressionConverter.ConvertO(bodynumberSolicited);
                bodypropCount++;
            }

            if (bodynotes != null)
            {
                body["notes"] = ExpressionConverter.ConvertO(bodynotes);
                bodypropCount++;
            }

            if (bodydefaultCampaignID != null)
            {
                body["campaign_id"] = ExpressionConverter.ConvertO(bodydefaultCampaignID);
                bodypropCount++;
            }

            if (bodydefaultFundID != null)
            {
                body["default_fund_id"] = ExpressionConverter.ConvertO(bodydefaultFundID);
                bodypropCount++;
            }

            if (bodyinactive != null)
            {
                body["inactive"] = ExpressionConverter.ConvertO(bodyinactive);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<NXTDataIntegrationApiCreatedAppeal>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfundraising")]
        public IWorkflowAction EditAppeal(Expression<Func<int>> id, Expression<Func<string>> bodylookupID = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodyendDate = null, Expression<Func<int>> bodycategory = null, Expression<Func<double>> bodygoal = null, Expression<Func<double>> bodydefaultGiftAmount = null, Expression<Func<int>> bodynumberSolicited = null, Expression<Func<string>> bodynotes = null, Expression<Func<int>> bodydefaultCampaignID = null, Expression<Func<int>> bodydefaultFundID = null, Expression<Func<bool>> bodyinactive = null)
        {
            var apiCallPath = String.Format("/nxt-data-integration/v1/re/appeals/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodylookupID != null)
            {
                body["appeal_id"] = ExpressionConverter.ConvertO(bodylookupID);
                bodypropCount++;
            }

            if (bodydescription != null)
            {
                body["description"] = ExpressionConverter.ConvertO(bodydescription);
                bodypropCount++;
            }

            if (bodystartDate != null)
            {
                body["start_date"] = ExpressionConverter.ConvertO(bodystartDate);
                bodypropCount++;
            }

            if (bodyendDate != null)
            {
                body["end_date"] = ExpressionConverter.ConvertO(bodyendDate);
                bodypropCount++;
            }

            if (bodycategory != null)
            {
                body["appeal_category_id"] = ExpressionConverter.ConvertO(bodycategory);
                bodypropCount++;
            }

            if (bodygoal != null)
            {
                body["goal"] = ExpressionConverter.ConvertO(bodygoal);
                bodypropCount++;
            }

            if (bodydefaultGiftAmount != null)
            {
                body["default_gift_amount"] = ExpressionConverter.ConvertO(bodydefaultGiftAmount);
                bodypropCount++;
            }

            if (bodynumberSolicited != null)
            {
                body["number_solicited"] = ExpressionConverter.ConvertO(bodynumberSolicited);
                bodypropCount++;
            }

            if (bodynotes != null)
            {
                body["notes"] = ExpressionConverter.ConvertO(bodynotes);
                bodypropCount++;
            }

            if (bodydefaultCampaignID != null)
            {
                body["campaign_id"] = ExpressionConverter.ConvertO(bodydefaultCampaignID);
                bodypropCount++;
            }

            if (bodydefaultFundID != null)
            {
                body["default_fund_id"] = ExpressionConverter.ConvertO(bodydefaultFundID);
                bodypropCount++;
            }

            if (bodyinactive != null)
            {
                body["inactive"] = ExpressionConverter.ConvertO(bodyinactive);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfundraising")]
        public IBodyWorkflowAction<NXTDataIntegrationApiCreatedCampaign> CreateCampaign(Expression<Func<string>> bodylookupID, Expression<Func<string>> bodydescription, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodyendDate = null, Expression<Func<int>> bodycategory = null, Expression<Func<double>> bodygoal = null, Expression<Func<string>> bodynotes = null, Expression<Func<bool>> bodyinactive = null, Expression<Func<int>> bodydefaultFundID = null)
        {
            var apiCallPath = "/nxt-data-integration/v1/re/campaigns";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["campaign_id"] = ExpressionConverter.ConvertO(bodylookupID);
            bodypropCount++;
            body["description"] = ExpressionConverter.ConvertO(bodydescription);
            if (bodystartDate != null)
            {
                body["start_date"] = ExpressionConverter.ConvertO(bodystartDate);
                bodypropCount++;
            }

            if (bodyendDate != null)
            {
                body["end_date"] = ExpressionConverter.ConvertO(bodyendDate);
                bodypropCount++;
            }

            if (bodycategory != null)
            {
                body["campaign_category_id"] = ExpressionConverter.ConvertO(bodycategory);
                bodypropCount++;
            }

            if (bodygoal != null)
            {
                body["goal"] = ExpressionConverter.ConvertO(bodygoal);
                bodypropCount++;
            }

            if (bodynotes != null)
            {
                body["notes"] = ExpressionConverter.ConvertO(bodynotes);
                bodypropCount++;
            }

            if (bodyinactive != null)
            {
                body["inactive"] = ExpressionConverter.ConvertO(bodyinactive);
                bodypropCount++;
            }

            if (bodydefaultFundID != null)
            {
                body["default_fund_id"] = ExpressionConverter.ConvertO(bodydefaultFundID);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<NXTDataIntegrationApiCreatedCampaign>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfundraising")]
        public IWorkflowAction EditCampaign(Expression<Func<int>> id, Expression<Func<string>> bodylookupID = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodyendDate = null, Expression<Func<int>> bodycategory = null, Expression<Func<double>> bodygoal = null, Expression<Func<string>> bodynotes = null, Expression<Func<bool>> bodyinactive = null, Expression<Func<int>> bodydefaultFundID = null)
        {
            var apiCallPath = String.Format("/nxt-data-integration/v1/re/campaigns/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodylookupID != null)
            {
                body["campaign_id"] = ExpressionConverter.ConvertO(bodylookupID);
                bodypropCount++;
            }

            if (bodydescription != null)
            {
                body["description"] = ExpressionConverter.ConvertO(bodydescription);
                bodypropCount++;
            }

            if (bodystartDate != null)
            {
                body["start_date"] = ExpressionConverter.ConvertO(bodystartDate);
                bodypropCount++;
            }

            if (bodyendDate != null)
            {
                body["end_date"] = ExpressionConverter.ConvertO(bodyendDate);
                bodypropCount++;
            }

            if (bodycategory != null)
            {
                body["campaign_category_id"] = ExpressionConverter.ConvertO(bodycategory);
                bodypropCount++;
            }

            if (bodygoal != null)
            {
                body["goal"] = ExpressionConverter.ConvertO(bodygoal);
                bodypropCount++;
            }

            if (bodynotes != null)
            {
                body["notes"] = ExpressionConverter.ConvertO(bodynotes);
                bodypropCount++;
            }

            if (bodyinactive != null)
            {
                body["inactive"] = ExpressionConverter.ConvertO(bodyinactive);
                bodypropCount++;
            }

            if (bodydefaultFundID != null)
            {
                body["default_fund_id"] = ExpressionConverter.ConvertO(bodydefaultFundID);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfundraising")]
        public IBodyWorkflowAction<NXTDataIntegrationApiCreatedConstituentAppeal> CreateConstituentAppeal(Expression<Func<int>> bodyconstituentID, Expression<Func<string>> bodyappealDescription, Expression<Func<string>> bodypackageDescription = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodyresponse = null, Expression<Func<string>> bodymarketingSegment = null, Expression<Func<string>> bodymarketingSourceCode = null, Expression<Func<int>> bodymailingID = null, Expression<Func<string>> bodyfinderNumber = null, Expression<Func<string>> bodycomments = null, Expression<Func<string>> bodyimportID = null)
        {
            var apiCallPath = "/nxt-data-integration/v1/re/constitappeals";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["constituent_id"] = ExpressionConverter.ConvertO(bodyconstituentID);
            bodypropCount++;
            body["appeal_description"] = ExpressionConverter.ConvertO(bodyappealDescription);
            if (bodypackageDescription != null)
            {
                body["package_description"] = ExpressionConverter.ConvertO(bodypackageDescription);
                bodypropCount++;
            }

            if (bodydate != null)
            {
                body["appeal_date"] = ExpressionConverter.ConvertO(bodydate);
                bodypropCount++;
            }

            if (bodyresponse != null)
            {
                body["response_description"] = ExpressionConverter.ConvertO(bodyresponse);
                bodypropCount++;
            }

            if (bodymarketingSegment != null)
            {
                body["marketing_segment"] = ExpressionConverter.ConvertO(bodymarketingSegment);
                bodypropCount++;
            }

            if (bodymarketingSourceCode != null)
            {
                body["marketing_source_code"] = ExpressionConverter.ConvertO(bodymarketingSourceCode);
                bodypropCount++;
            }

            if (bodymailingID != null)
            {
                body["mailing_id"] = ExpressionConverter.ConvertO(bodymailingID);
                bodypropCount++;
            }

            if (bodyfinderNumber != null)
            {
                body["market_finder_number"] = ExpressionConverter.ConvertO(bodyfinderNumber);
                bodypropCount++;
            }

            if (bodycomments != null)
            {
                body["comments"] = ExpressionConverter.ConvertO(bodycomments);
                bodypropCount++;
            }

            if (bodyimportID != null)
            {
                body["import_id"] = ExpressionConverter.ConvertO(bodyimportID);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<NXTDataIntegrationApiCreatedConstituentAppeal>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfundraising")]
        public IWorkflowAction EditConstituentAppeal(Expression<Func<int>> id, Expression<Func<string>> bodyappealDescription = null, Expression<Func<string>> bodypackageDescription = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodyresponse = null, Expression<Func<string>> bodymarketingSegment = null, Expression<Func<string>> bodymarketingSourceCode = null, Expression<Func<int>> bodymailingID = null, Expression<Func<string>> bodyfinderNumber = null, Expression<Func<string>> bodycomments = null)
        {
            var apiCallPath = String.Format("/nxt-data-integration/v1/re/constitappeals/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyappealDescription != null)
            {
                body["appeal_description"] = ExpressionConverter.ConvertO(bodyappealDescription);
                bodypropCount++;
            }

            if (bodypackageDescription != null)
            {
                body["package_description"] = ExpressionConverter.ConvertO(bodypackageDescription);
                bodypropCount++;
            }

            if (bodydate != null)
            {
                body["appeal_date"] = ExpressionConverter.ConvertO(bodydate);
                bodypropCount++;
            }

            if (bodyresponse != null)
            {
                body["response_description"] = ExpressionConverter.ConvertO(bodyresponse);
                bodypropCount++;
            }

            if (bodymarketingSegment != null)
            {
                body["marketing_segment"] = ExpressionConverter.ConvertO(bodymarketingSegment);
                bodypropCount++;
            }

            if (bodymarketingSourceCode != null)
            {
                body["marketing_source_code"] = ExpressionConverter.ConvertO(bodymarketingSourceCode);
                bodypropCount++;
            }

            if (bodymailingID != null)
            {
                body["mailing_id"] = ExpressionConverter.ConvertO(bodymailingID);
                bodypropCount++;
            }

            if (bodyfinderNumber != null)
            {
                body["market_finder_number"] = ExpressionConverter.ConvertO(bodyfinderNumber);
                bodypropCount++;
            }

            if (bodycomments != null)
            {
                body["comments"] = ExpressionConverter.ConvertO(bodycomments);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfundraising")]
        public IBodyWorkflowAction<NXTDataIntegrationApiCreatedFund> CreateFund(Expression<Func<string>> bodylookupID, Expression<Func<string>> bodydescription, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodyendDate = null, Expression<Func<int>> bodycategory = null, Expression<Func<int>> bodytype = null, Expression<Func<double>> bodygoal = null, Expression<Func<string>> bodynotes = null, Expression<Func<bool>> bodyrestricted = null, Expression<Func<bool>> bodyinactive = null, Expression<Func<int>> bodycampaignID = null, Expression<Func<int>> bodydefaultAppealID = null)
        {
            var apiCallPath = "/nxt-data-integration/v1/re/funds";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["fund_id"] = ExpressionConverter.ConvertO(bodylookupID);
            bodypropCount++;
            body["description"] = ExpressionConverter.ConvertO(bodydescription);
            if (bodystartDate != null)
            {
                body["start_date"] = ExpressionConverter.ConvertO(bodystartDate);
                bodypropCount++;
            }

            if (bodyendDate != null)
            {
                body["end_date"] = ExpressionConverter.ConvertO(bodyendDate);
                bodypropCount++;
            }

            if (bodycategory != null)
            {
                body["fund_category_id"] = ExpressionConverter.ConvertO(bodycategory);
                bodypropCount++;
            }

            if (bodytype != null)
            {
                body["fund_type_id"] = ExpressionConverter.ConvertO(bodytype);
                bodypropCount++;
            }

            if (bodygoal != null)
            {
                body["goal"] = ExpressionConverter.ConvertO(bodygoal);
                bodypropCount++;
            }

            if (bodynotes != null)
            {
                body["notes"] = ExpressionConverter.ConvertO(bodynotes);
                bodypropCount++;
            }

            if (bodyrestricted != null)
            {
                body["restricted"] = ExpressionConverter.ConvertO(bodyrestricted);
                bodypropCount++;
            }

            if (bodyinactive != null)
            {
                body["inactive"] = ExpressionConverter.ConvertO(bodyinactive);
                bodypropCount++;
            }

            if (bodycampaignID != null)
            {
                body["campaign_id"] = ExpressionConverter.ConvertO(bodycampaignID);
                bodypropCount++;
            }

            if (bodydefaultAppealID != null)
            {
                body["default_appeal_id"] = ExpressionConverter.ConvertO(bodydefaultAppealID);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<NXTDataIntegrationApiCreatedFund>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfundraising")]
        public IWorkflowAction EditFund(Expression<Func<int>> id, Expression<Func<string>> bodylookupID = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodyendDate = null, Expression<Func<int>> bodycategory = null, Expression<Func<int>> bodytype = null, Expression<Func<double>> bodygoal = null, Expression<Func<string>> bodynotes = null, Expression<Func<bool>> bodyrestricted = null, Expression<Func<bool>> bodyinactive = null, Expression<Func<int>> bodycampaignID = null, Expression<Func<int>> bodydefaultAppealID = null)
        {
            var apiCallPath = String.Format("/nxt-data-integration/v1/re/funds/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodylookupID != null)
            {
                body["fund_id"] = ExpressionConverter.ConvertO(bodylookupID);
                bodypropCount++;
            }

            if (bodydescription != null)
            {
                body["description"] = ExpressionConverter.ConvertO(bodydescription);
                bodypropCount++;
            }

            if (bodystartDate != null)
            {
                body["start_date"] = ExpressionConverter.ConvertO(bodystartDate);
                bodypropCount++;
            }

            if (bodyendDate != null)
            {
                body["end_date"] = ExpressionConverter.ConvertO(bodyendDate);
                bodypropCount++;
            }

            if (bodycategory != null)
            {
                body["fund_category_id"] = ExpressionConverter.ConvertO(bodycategory);
                bodypropCount++;
            }

            if (bodytype != null)
            {
                body["fund_type_id"] = ExpressionConverter.ConvertO(bodytype);
                bodypropCount++;
            }

            if (bodygoal != null)
            {
                body["goal"] = ExpressionConverter.ConvertO(bodygoal);
                bodypropCount++;
            }

            if (bodynotes != null)
            {
                body["notes"] = ExpressionConverter.ConvertO(bodynotes);
                bodypropCount++;
            }

            if (bodyrestricted != null)
            {
                body["restricted"] = ExpressionConverter.ConvertO(bodyrestricted);
                bodypropCount++;
            }

            if (bodyinactive != null)
            {
                body["inactive"] = ExpressionConverter.ConvertO(bodyinactive);
                bodypropCount++;
            }

            if (bodycampaignID != null)
            {
                body["campaign_id"] = ExpressionConverter.ConvertO(bodycampaignID);
                bodypropCount++;
            }

            if (bodydefaultAppealID != null)
            {
                body["default_appeal_id"] = ExpressionConverter.ConvertO(bodydefaultAppealID);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfundraising")]
        public IBodyWorkflowAction<NXTDataIntegrationApiConstituentRelationshipCollection> ListFundConstituentRelationships(Expression<Func<int>> fundId, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var apiCallPath = String.Format("/nxt-data-integration/v1/re/relationships/constituents/fund/{0}", ExpressionConverter.ConvertWithUrlEncoding(fundId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<NXTDataIntegrationApiConstituentRelationshipCollection>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfundraising")]
        public IBodyWorkflowAction<NXTDataIntegrationApiFundRelationshipCollection> ListConstituentFundRelationships(Expression<Func<int>> constituentId, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var apiCallPath = String.Format("/nxt-data-integration/v1/re/relationships/funds/constituent/{0}", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<NXTDataIntegrationApiFundRelationshipCollection>(callPayload);
        }
    }

    public class BlackbaudfundraisingTriggers([ConnectionName] string connectionId)
    {
    }

    public class ConstituentApiApiCollectionOfConstituentAppealRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiConstituentAppealRead[] Value { get; set; }
    }

    public class ConstituentApiConstituentAppealRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("appeal")]
        public ConstituentApiConstituentAppealReadAppealType Appeal { get; set; }

        [JsonProperty("package")]
        public ConstituentApiConstituentAppealReadPackageType Package { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("response")]
        public string Response { get; set; }

        [JsonProperty("marketing_segment")]
        public string MarketingSegment { get; set; }

        [JsonProperty("marketing_source_code")]
        public string MarketingSourceCode { get; set; }

        [JsonProperty("mailing_id")]
        public string MailingID { get; set; }

        [JsonProperty("finder_number")]
        public string FinderNumber { get; set; }

        [JsonProperty("comments")]
        public string Comments { get; set; }
    }

    public class ConstituentApiConstituentAppealReadAppealType
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class ConstituentApiConstituentAppealReadPackageType
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class FundraisingApiApiCollectionOfAppealRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public FundraisingApiAppealRead[] Value { get; set; }
    }

    public class FundraisingApiAppealRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("goal")]
        public FundraisingApiAppealReadGoalType Goal { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("lookup_id")]
        public string LookupID { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }
    }

    public class FundraisingApiAppealReadGoalType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class FundraisingApiApiCollectionOfAppealAttachmentRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public FundraisingApiAppealAttachmentRead[] Value { get; set; }
    }

    public class FundraisingApiAppealAttachmentRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("parent_id")]
        public string AppealID { get; set; }

        [JsonProperty("type")]
        public FundraisingApiAppealAttachmentReadTypeType Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("url")]
        public string URL { get; set; }

        [JsonProperty("file_name")]
        public string FileName { get; set; }

        [JsonProperty("file_id")]
        public string FileID { get; set; }

        [JsonProperty("thumbnail_id")]
        public string ThumbnailID { get; set; }

        [JsonProperty("thumbnail_url")]
        public string ThumbnailURL { get; set; }

        [JsonProperty("content_type")]
        public string ContentType { get; set; }

        [JsonProperty("file_size")]
        public int FileSize { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }
    }

    public enum FundraisingApiAppealAttachmentReadTypeType
    {
        Link,
        Physical
    }

    public class FundraisingApiApiCollectionOfAppealCustomFieldRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public FundraisingApiAppealCustomFieldRead[] Value { get; set; }
    }

    public class FundraisingApiAppealCustomFieldRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("parent_id")]
        public string AppealID { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("type")]
        public FundraisingApiAppealCustomFieldReadTypeType Type { get; set; }

        [JsonProperty("value")]
        public JToken Value { get; set; }

        [JsonProperty("text_value")]
        public string TextValue { get; set; }

        [JsonProperty("number_value")]
        public int NumberValue { get; set; }

        [JsonProperty("date_value")]
        public string DateValue { get; set; }

        [JsonProperty("currency_value")]
        public double CurrencyValue { get; set; }

        [JsonProperty("boolean_value")]
        public bool BooleanValue { get; set; }

        [JsonProperty("codetableentry_value")]
        public string TableEntryValue { get; set; }

        [JsonProperty("constituentid_value")]
        public string ConstituentIDValue { get; set; }

        [JsonProperty("fuzzydate_value")]
        public FundraisingApiAppealCustomFieldReadFuzzyDateValueType FuzzyDateValue { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public enum FundraisingApiAppealCustomFieldReadTypeType
    {
        Text,
        Number,
        Date,
        Currency,
        Boolean,
        CodeTableEntry,
        ConstituentId,
        FuzzyDate
    }

    public class FundraisingApiAppealCustomFieldReadFuzzyDateValueType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class FundraisingApiCreatedAppealAttachment
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public enum bodytypeInput
    {
        Link,
        Physical
    }

    public class FundraisingApiCreatedAppealCustomField
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class FundraisingApiApiCollectionOfCampaignRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public FundraisingApiCampaignRead[] Value { get; set; }
    }

    public class FundraisingApiCampaignRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("goal")]
        public FundraisingApiCampaignReadGoalType Goal { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("lookup_id")]
        public string LookupID { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }
    }

    public class FundraisingApiCampaignReadGoalType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class FundraisingApiApiCollectionOfCampaignAttachmentRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public FundraisingApiCampaignAttachmentRead[] Value { get; set; }
    }

    public class FundraisingApiCampaignAttachmentRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("parent_id")]
        public string CampaignID { get; set; }

        [JsonProperty("type")]
        public FundraisingApiCampaignAttachmentReadTypeType Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("url")]
        public string URL { get; set; }

        [JsonProperty("file_name")]
        public string FileName { get; set; }

        [JsonProperty("file_id")]
        public string FileID { get; set; }

        [JsonProperty("thumbnail_id")]
        public string ThumbnailID { get; set; }

        [JsonProperty("thumbnail_url")]
        public string ThumbnailURL { get; set; }

        [JsonProperty("content_type")]
        public string ContentType { get; set; }

        [JsonProperty("file_size")]
        public int FileSize { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }
    }

    public enum FundraisingApiCampaignAttachmentReadTypeType
    {
        Link,
        Physical
    }

    public class FundraisingApiApiCollectionOfCampaignCustomFieldRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public FundraisingApiCampaignCustomFieldRead[] Value { get; set; }
    }

    public class FundraisingApiCampaignCustomFieldRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("parent_id")]
        public string CampaignID { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("type")]
        public FundraisingApiCampaignCustomFieldReadTypeType Type { get; set; }

        [JsonProperty("value")]
        public JToken Value { get; set; }

        [JsonProperty("text_value")]
        public string TextValue { get; set; }

        [JsonProperty("number_value")]
        public int NumberValue { get; set; }

        [JsonProperty("date_value")]
        public string DateValue { get; set; }

        [JsonProperty("currency_value")]
        public double CurrencyValue { get; set; }

        [JsonProperty("boolean_value")]
        public bool BooleanValue { get; set; }

        [JsonProperty("codetableentry_value")]
        public string TableEntryValue { get; set; }

        [JsonProperty("constituentid_value")]
        public string ConstituentIDValue { get; set; }

        [JsonProperty("fuzzydate_value")]
        public FundraisingApiCampaignCustomFieldReadFuzzyDateValueType FuzzyDateValue { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public enum FundraisingApiCampaignCustomFieldReadTypeType
    {
        Text,
        Number,
        Date,
        Currency,
        Boolean,
        CodeTableEntry,
        ConstituentId,
        FuzzyDate
    }

    public class FundraisingApiCampaignCustomFieldReadFuzzyDateValueType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class FundraisingApiCreatedCampaignAttachment
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class FundraisingApiCreatedCampaignCustomField
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class FundraisingApiApiCollectionOfFundRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public FundraisingApiFundRead[] Value { get; set; }
    }

    public class FundraisingApiFundRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("goal")]
        public FundraisingApiFundReadGoalType Goal { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("lookup_id")]
        public string LookupID { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class FundraisingApiFundReadGoalType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class FundraisingApiApiCollectionOfFundAttachmentRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public FundraisingApiFundAttachmentRead[] Value { get; set; }
    }

    public class FundraisingApiFundAttachmentRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("parent_id")]
        public string FundID { get; set; }

        [JsonProperty("type")]
        public FundraisingApiFundAttachmentReadTypeType Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("url")]
        public string URL { get; set; }

        [JsonProperty("file_name")]
        public string FileName { get; set; }

        [JsonProperty("file_id")]
        public string FileID { get; set; }

        [JsonProperty("thumbnail_id")]
        public string ThumbnailID { get; set; }

        [JsonProperty("thumbnail_url")]
        public string ThumbnailURL { get; set; }

        [JsonProperty("content_type")]
        public string ContentType { get; set; }

        [JsonProperty("file_size")]
        public int FileSize { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }
    }

    public enum FundraisingApiFundAttachmentReadTypeType
    {
        Link,
        Physical
    }

    public class FundraisingApiApiCollectionOfFundCustomFieldRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public FundraisingApiFundCustomFieldRead[] Value { get; set; }
    }

    public class FundraisingApiFundCustomFieldRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("parent_id")]
        public string FundID { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("type")]
        public FundraisingApiFundCustomFieldReadTypeType Type { get; set; }

        [JsonProperty("value")]
        public JToken Value { get; set; }

        [JsonProperty("text_value")]
        public string TextValue { get; set; }

        [JsonProperty("number_value")]
        public int NumberValue { get; set; }

        [JsonProperty("date_value")]
        public string DateValue { get; set; }

        [JsonProperty("currency_value")]
        public double CurrencyValue { get; set; }

        [JsonProperty("boolean_value")]
        public bool BooleanValue { get; set; }

        [JsonProperty("codetableentry_value")]
        public string TableEntryValue { get; set; }

        [JsonProperty("constituentid_value")]
        public string ConstituentIDValue { get; set; }

        [JsonProperty("fuzzydate_value")]
        public FundraisingApiFundCustomFieldReadFuzzyDateValueType FuzzyDateValue { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public enum FundraisingApiFundCustomFieldReadTypeType
    {
        Text,
        Number,
        Date,
        Currency,
        Boolean,
        CodeTableEntry,
        ConstituentId,
        FuzzyDate
    }

    public class FundraisingApiFundCustomFieldReadFuzzyDateValueType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class FundraisingApiCreatedFundAttachment
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class FundraisingApiCreatedFundCustomField
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class FundraisingApiApiCollectionOfPackageRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public FundraisingApiPackageRead[] Value { get; set; }
    }

    public class FundraisingApiPackageRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("appeal_id")]
        public string AppealID { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }

        [JsonProperty("default_gift_amount")]
        public FundraisingApiPackageReadDefaultGiftAmountType DefaultGiftAmount { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("end")]
        public string EndDate { get; set; }

        [JsonProperty("goal")]
        public FundraisingApiPackageReadGoalType Goal { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("lookup_id")]
        public string LookupID { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("recipient_count")]
        public int RecipientCount { get; set; }

        [JsonProperty("start")]
        public string StartDate { get; set; }
    }

    public class FundraisingApiPackageReadDefaultGiftAmountType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class FundraisingApiPackageReadGoalType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class NXTDataIntegrationApiCreatedAppeal
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class NXTDataIntegrationApiCreatedCampaign
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class NXTDataIntegrationApiCreatedConstituentAppeal
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class NXTDataIntegrationApiCreatedFund
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class NXTDataIntegrationApiConstituentRelationshipCollection
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public NXTDataIntegrationApiConstituentRelationship[] Value { get; set; }
    }

    public class NXTDataIntegrationApiConstituentRelationship
    {
        [JsonProperty("relation_id")]
        public int ConstituentID { get; set; }

        [JsonProperty("relation_description")]
        public string RelationDescription { get; set; }

        [JsonProperty("relationship_type")]
        public string RelationshipType { get; set; }

        [JsonProperty("reciprocal_relationship_type")]
        public string ReciprocalRelationshipType { get; set; }

        [JsonProperty("date_from")]
        public string DateFrom { get; set; }

        [JsonProperty("date_to")]
        public string DateTo { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }
    }

    public class NXTDataIntegrationApiFundRelationshipCollection
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public NXTDataIntegrationApiFundRelationship[] Value { get; set; }
    }

    public class NXTDataIntegrationApiFundRelationship
    {
        [JsonProperty("relation_id")]
        public int FundID { get; set; }

        [JsonProperty("relation_description")]
        public string RelationDescription { get; set; }

        [JsonProperty("relationship_type")]
        public string RelationshipType { get; set; }

        [JsonProperty("reciprocal_relationship_type")]
        public string ReciprocalRelationshipType { get; set; }

        [JsonProperty("date_from")]
        public string DateFrom { get; set; }

        [JsonProperty("date_to")]
        public string DateTo { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Blackbaudfundraising;

    public partial class WorkflowManagedActions
    {
        public BlackbaudfundraisingActions Blackbaudfundraising(string connectionId) => new BlackbaudfundraisingActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public BlackbaudfundraisingTriggers Blackbaudfundraising(string connectionId) => new BlackbaudfundraisingTriggers(connectionId);
    }
}