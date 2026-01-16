//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Blackbaudraisersedge
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BlackbaudraisersedgeActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<CommPrefApiCreatedConstituentConsent> CreateConstituentConsent(Expression<Func<string>> bodyconstituentID, Expression<Func<string>> bodychannel, Expression<Func<bodyresponseInput>> bodyresponse, Expression<Func<string>> bodydate, Expression<Func<string>> bodycategory = null, Expression<Func<string>> bodysource = null, Expression<Func<string>> bodyconsentStatement = null, Expression<Func<string>> bodyprivacyNotice = null)
        {
            var apiCallPath = "/commpref/v1/consent/consents";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["constituent_id"] = ExpressionConverter.ConvertO(bodyconstituentID);
            bodypropCount++;
            body["channel"] = ExpressionConverter.ConvertO(bodychannel);
            if (bodycategory != null)
            {
                body["category"] = ExpressionConverter.ConvertO(bodycategory);
                bodypropCount++;
            }

            if (bodysource != null)
            {
                body["source"] = ExpressionConverter.ConvertO(bodysource);
                bodypropCount++;
            }

            bodypropCount++;
            body["constituent_consent_response"] = ExpressionConverter.ConvertO(bodyresponse);
            bodypropCount++;
            body["consent_date"] = ExpressionConverter.ConvertO(bodydate);
            if (bodyconsentStatement != null)
            {
                body["consent_statement"] = ExpressionConverter.ConvertO(bodyconsentStatement);
                bodypropCount++;
            }

            if (bodyprivacyNotice != null)
            {
                body["privacy_notice"] = ExpressionConverter.ConvertO(bodyprivacyNotice);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CommPrefApiCreatedConstituentConsent>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<CommPrefApiConstituentConsentReadCollection> ListConstituentConsents(Expression<Func<string>> constituentId, Expression<Func<bool>> mostRecentOnly = null)
        {
            var apiCallPath = String.Format("/commpref/v1/constituents/{0}/consents", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (mostRecentOnly != null)
                callPayload.Queries["most_recent_only"] = ExpressionConverter.Convert(mostRecentOnly);
            return new ApiConnectionAction<CommPrefApiConstituentConsentReadCollection>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<CommPrefApiConstituentSolicitCodeReadCollection> ListConstituentSolicitCodes(Expression<Func<string>> constituentId)
        {
            var apiCallPath = String.Format("/commpref/v1/constituents/{0}/constituentsolicitcodes", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<CommPrefApiConstituentSolicitCodeReadCollection>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<CommPrefApiCreatedConstituentSolicitCode> CreateConstituentSolicitCode(Expression<Func<string>> bodyconstituentID, Expression<Func<string>> bodysolicitCode, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodyendDate = null)
        {
            var apiCallPath = "/commpref/v1/constituentsolicitcodes";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["constituent_id"] = ExpressionConverter.ConvertO(bodyconstituentID);
            bodypropCount++;
            body["solicit_code"] = ExpressionConverter.ConvertO(bodysolicitCode);
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

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CommPrefApiCreatedConstituentSolicitCode>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction EditConstituentSolicitCode(Expression<Func<string>> constituentSolicitCodeId, Expression<Func<string>> bodysolicitCode = null, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodyendDate = null)
        {
            var apiCallPath = String.Format("/commpref/v1/constituentsolicitcodes/{0}", ExpressionConverter.ConvertWithUrlEncoding(constituentSolicitCodeId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodysolicitCode != null)
            {
                body["solicit_code"] = ExpressionConverter.ConvertO(bodysolicitCode);
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

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfActionRead> ListActions(Expression<Func<string>> listId = null, Expression<Func<string>> computedStatus = null, Expression<Func<string>> statusCode = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<string>> dateAdded = null, Expression<Func<string>> lastModified = null)
        {
            var apiCallPath = "/constituent/v1/actions";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (listId != null)
                callPayload.Queries["list_id"] = ExpressionConverter.Convert(listId);
            if (computedStatus != null)
                callPayload.Queries["computed_status"] = ExpressionConverter.Convert(computedStatus);
            if (statusCode != null)
                callPayload.Queries["status_code"] = ExpressionConverter.Convert(statusCode);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            if (dateAdded != null)
                callPayload.Queries["date_added"] = ExpressionConverter.Convert(dateAdded);
            if (lastModified != null)
                callPayload.Queries["last_modified"] = ExpressionConverter.Convert(lastModified);
            return new ApiConnectionAction<ConstituentApiApiCollectionOfActionRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiCreatedAction> CreateAction(Expression<Func<string>> bodyconstituentID, Expression<Func<bodycategoryInput>> bodycategory, Expression<Func<string>> bodydate, Expression<Func<bool>> bodycompleted = null, Expression<Func<string>> bodycompletedOn = null, Expression<Func<string>> bodynote = null, Expression<Func<bodydirectionInput>> bodydirection = null, Expression<Func<string[]>> bodyfundraiserS = null, Expression<Func<string>> bodylocation = null, Expression<Func<string>> bodyopportunityID = null, Expression<Func<bodyoutcomeInput>> bodyoutcome = null, Expression<Func<bodypriorityInput>> bodypriority = null, Expression<Func<string>> bodystartTime = null, Expression<Func<string>> bodyendTime = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodysummary = null, Expression<Func<string>> bodytype = null)
        {
            var apiCallPath = "/constituent/v1/actions";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["constituent_id"] = ExpressionConverter.ConvertO(bodyconstituentID);
            bodypropCount++;
            body["category"] = ExpressionConverter.ConvertO(bodycategory);
            if (bodycompleted != null)
            {
                body["completed"] = ExpressionConverter.ConvertO(bodycompleted);
                bodypropCount++;
            }

            if (bodycompletedOn != null)
            {
                body["completed_date"] = ExpressionConverter.ConvertO(bodycompletedOn);
                bodypropCount++;
            }

            bodypropCount++;
            body["date"] = ExpressionConverter.ConvertO(bodydate);
            if (bodynote != null)
            {
                body["description"] = ExpressionConverter.ConvertO(bodynote);
                bodypropCount++;
            }

            if (bodydirection != null)
            {
                body["direction"] = ExpressionConverter.ConvertO(bodydirection);
                bodypropCount++;
            }

            if (bodyfundraiserS != null)
            {
                body["fundraisers"] = ExpressionConverter.ConvertO(bodyfundraiserS);
                bodypropCount++;
            }

            if (bodylocation != null)
            {
                body["location"] = ExpressionConverter.ConvertO(bodylocation);
                bodypropCount++;
            }

            if (bodyopportunityID != null)
            {
                body["opportunity_id"] = ExpressionConverter.ConvertO(bodyopportunityID);
                bodypropCount++;
            }

            if (bodyoutcome != null)
            {
                body["outcome"] = ExpressionConverter.ConvertO(bodyoutcome);
                bodypropCount++;
            }

            if (bodypriority != null)
            {
                body["priority"] = ExpressionConverter.ConvertO(bodypriority);
                bodypropCount++;
            }

            if (bodystartTime != null)
            {
                body["start_time"] = ExpressionConverter.ConvertO(bodystartTime);
                bodypropCount++;
            }

            if (bodyendTime != null)
            {
                body["end_time"] = ExpressionConverter.ConvertO(bodyendTime);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["status"] = ExpressionConverter.ConvertO(bodystatus);
                bodypropCount++;
            }

            if (bodysummary != null)
            {
                body["summary"] = ExpressionConverter.ConvertO(bodysummary);
                bodypropCount++;
            }

            if (bodytype != null)
            {
                body["type"] = ExpressionConverter.ConvertO(bodytype);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ConstituentApiCreatedAction>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiActionRead> GetAction(Expression<Func<string>> actionId)
        {
            var apiCallPath = String.Format("/constituent/v1/actions/{0}", ExpressionConverter.ConvertWithUrlEncoding(actionId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ConstituentApiActionRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction EditAction(Expression<Func<string>> actionId, Expression<Func<bodycategoryInput>> bodycategory = null, Expression<Func<bool>> bodycompleted = null, Expression<Func<string>> bodycompletedOn = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodynote = null, Expression<Func<bodydirectionInput>> bodydirection = null, Expression<Func<string[]>> bodyfundraiserS = null, Expression<Func<string>> bodylocation = null, Expression<Func<string>> bodyopportunityID = null, Expression<Func<bodyoutcomeInput>> bodyoutcome = null, Expression<Func<bodypriorityInput>> bodypriority = null, Expression<Func<string>> bodystartTime = null, Expression<Func<string>> bodyendTime = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodysummary = null, Expression<Func<string>> bodytype = null)
        {
            var apiCallPath = String.Format("/constituent/v1/actions/{0}", ExpressionConverter.ConvertWithUrlEncoding(actionId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodycategory != null)
            {
                body["category"] = ExpressionConverter.ConvertO(bodycategory);
                bodypropCount++;
            }

            if (bodycompleted != null)
            {
                body["completed"] = ExpressionConverter.ConvertO(bodycompleted);
                bodypropCount++;
            }

            if (bodycompletedOn != null)
            {
                body["completed_date"] = ExpressionConverter.ConvertO(bodycompletedOn);
                bodypropCount++;
            }

            if (bodydate != null)
            {
                body["date"] = ExpressionConverter.ConvertO(bodydate);
                bodypropCount++;
            }

            if (bodynote != null)
            {
                body["description"] = ExpressionConverter.ConvertO(bodynote);
                bodypropCount++;
            }

            if (bodydirection != null)
            {
                body["direction"] = ExpressionConverter.ConvertO(bodydirection);
                bodypropCount++;
            }

            if (bodyfundraiserS != null)
            {
                body["fundraisers"] = ExpressionConverter.ConvertO(bodyfundraiserS);
                bodypropCount++;
            }

            if (bodylocation != null)
            {
                body["location"] = ExpressionConverter.ConvertO(bodylocation);
                bodypropCount++;
            }

            if (bodyopportunityID != null)
            {
                body["opportunity_id"] = ExpressionConverter.ConvertO(bodyopportunityID);
                bodypropCount++;
            }

            if (bodyoutcome != null)
            {
                body["outcome"] = ExpressionConverter.ConvertO(bodyoutcome);
                bodypropCount++;
            }

            if (bodypriority != null)
            {
                body["priority"] = ExpressionConverter.ConvertO(bodypriority);
                bodypropCount++;
            }

            if (bodystartTime != null)
            {
                body["start_time"] = ExpressionConverter.ConvertO(bodystartTime);
                bodypropCount++;
            }

            if (bodyendTime != null)
            {
                body["end_time"] = ExpressionConverter.ConvertO(bodyendTime);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["status"] = ExpressionConverter.ConvertO(bodystatus);
                bodypropCount++;
            }

            if (bodysummary != null)
            {
                body["summary"] = ExpressionConverter.ConvertO(bodysummary);
                bodypropCount++;
            }

            if (bodytype != null)
            {
                body["type"] = ExpressionConverter.ConvertO(bodytype);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfActionAttachmentRead> ListActionAttachments(Expression<Func<string>> actionId)
        {
            var apiCallPath = String.Format("/constituent/v1/actions/{0}/attachments", ExpressionConverter.ConvertWithUrlEncoding(actionId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ConstituentApiApiCollectionOfActionAttachmentRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfActionCustomFieldRead> ListActionCustomFields(Expression<Func<string>> actionId)
        {
            var apiCallPath = String.Format("/constituent/v1/actions/{0}/customfields", ExpressionConverter.ConvertWithUrlEncoding(actionId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ConstituentApiApiCollectionOfActionCustomFieldRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiCreatedActionAttachment> CreateActionAttachment(Expression<Func<string>> bodyactionID, Expression<Func<bodytypeInput>> bodytype, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodyuRL = null, Expression<Func<string>> bodyfileName = null, Expression<Func<string>> bodyfileID = null, Expression<Func<string>> bodythumbnailID = null)
        {
            var apiCallPath = "/constituent/v1/actions/attachments";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["parent_id"] = ExpressionConverter.ConvertO(bodyactionID);
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

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ConstituentApiCreatedActionAttachment>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction EditActionAttachment(Expression<Func<string>> attachmentId, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodyuRL = null)
        {
            var apiCallPath = String.Format("/constituent/v1/actions/attachments/{0}", ExpressionConverter.ConvertWithUrlEncoding(attachmentId, 1));
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

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiCreatedActionCustomField> CreateActionCustomField(Expression<Func<string>> bodyactionID, Expression<Func<string>> bodycategory, Expression<Func<object>> bodyvalue = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodycomment = null)
        {
            var apiCallPath = "/constituent/v1/actions/customfields";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["parent_id"] = ExpressionConverter.ConvertO(bodyactionID);
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

            return new ApiConnectionAction<ConstituentApiCreatedActionCustomField>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction EditActionCustomField(Expression<Func<string>> customFieldId, Expression<Func<string>> bodycategory = null, Expression<Func<object>> bodyvalue = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodycomment = null)
        {
            var apiCallPath = String.Format("/constituent/v1/actions/customfields/{0}", ExpressionConverter.ConvertWithUrlEncoding(customFieldId, 1));
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiCreatedConstituentAddress> CreateConstituentAddress(Expression<Func<string>> bodyconstituentID, Expression<Func<string>> bodyaddressType, Expression<Func<string>> bodycountry = null, Expression<Func<string>> bodyaddressLines = null, Expression<Func<string>> bodycity = null, Expression<Func<string>> bodystate = null, Expression<Func<string>> bodypostalCode = null, Expression<Func<string>> bodysuburb = null, Expression<Func<string>> bodycounty = null, Expression<Func<string>> bodyinformationSource = null, Expression<Func<string>> bodyregion = null, Expression<Func<string>> bodycART = null, Expression<Func<string>> bodylOT = null, Expression<Func<string>> bodydPC = null, Expression<Func<string>> bodyvalidFrom = null, Expression<Func<string>> bodyvalidTo = null, Expression<Func<bool>> bodyprimary = null, Expression<Func<bool>> bodydoNotMail = null, Expression<Func<int>> bodyseasonalStartday = null, Expression<Func<int>> bodyseasonalStartmonth = null, Expression<Func<int>> bodyseasonalStartyear = null, Expression<Func<int>> bodyseasonalEndday = null, Expression<Func<int>> bodyseasonalEndmonth = null, Expression<Func<int>> bodyseasonalEndyear = null)
        {
            var apiCallPath = "/constituent/v1/addresses";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["constituent_id"] = ExpressionConverter.ConvertO(bodyconstituentID);
            bodypropCount++;
            body["type"] = ExpressionConverter.ConvertO(bodyaddressType);
            if (bodycountry != null)
            {
                body["country"] = ExpressionConverter.ConvertO(bodycountry);
                bodypropCount++;
            }

            if (bodyaddressLines != null)
            {
                body["address_lines"] = ExpressionConverter.ConvertO(bodyaddressLines);
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

            if (bodypostalCode != null)
            {
                body["postal_code"] = ExpressionConverter.ConvertO(bodypostalCode);
                bodypropCount++;
            }

            if (bodysuburb != null)
            {
                body["suburb"] = ExpressionConverter.ConvertO(bodysuburb);
                bodypropCount++;
            }

            if (bodycounty != null)
            {
                body["county"] = ExpressionConverter.ConvertO(bodycounty);
                bodypropCount++;
            }

            if (bodyinformationSource != null)
            {
                body["information_source"] = ExpressionConverter.ConvertO(bodyinformationSource);
                bodypropCount++;
            }

            if (bodyregion != null)
            {
                body["region"] = ExpressionConverter.ConvertO(bodyregion);
                bodypropCount++;
            }

            if (bodycART != null)
            {
                body["cart"] = ExpressionConverter.ConvertO(bodycART);
                bodypropCount++;
            }

            if (bodylOT != null)
            {
                body["lot"] = ExpressionConverter.ConvertO(bodylOT);
                bodypropCount++;
            }

            if (bodydPC != null)
            {
                body["dpc"] = ExpressionConverter.ConvertO(bodydPC);
                bodypropCount++;
            }

            if (bodyvalidFrom != null)
            {
                body["start"] = ExpressionConverter.ConvertO(bodyvalidFrom);
                bodypropCount++;
            }

            if (bodyvalidTo != null)
            {
                body["end"] = ExpressionConverter.ConvertO(bodyvalidTo);
                bodypropCount++;
            }

            if (bodyprimary != null)
            {
                body["preferred"] = ExpressionConverter.ConvertO(bodyprimary);
                bodypropCount++;
            }

            if (bodydoNotMail != null)
            {
                body["do_not_mail"] = ExpressionConverter.ConvertO(bodydoNotMail);
                bodypropCount++;
            }

            var seasonal_startObject = new JObject();
            var seasonal_startObjectpropCount = 0;
            if (bodyseasonalStartday != null)
            {
                seasonal_startObject["d"] = ExpressionConverter.ConvertO(bodyseasonalStartday);
                seasonal_startObjectpropCount++;
            }

            if (bodyseasonalStartmonth != null)
            {
                seasonal_startObject["m"] = ExpressionConverter.ConvertO(bodyseasonalStartmonth);
                seasonal_startObjectpropCount++;
            }

            if (bodyseasonalStartyear != null)
            {
                seasonal_startObject["y"] = ExpressionConverter.ConvertO(bodyseasonalStartyear);
                seasonal_startObjectpropCount++;
            }

            if (seasonal_startObjectpropCount > 0)
            {
                body["seasonal_start"] = seasonal_startObject;
                bodypropCount++;
            }

            var seasonal_endObject = new JObject();
            var seasonal_endObjectpropCount = 0;
            if (bodyseasonalEndday != null)
            {
                seasonal_endObject["d"] = ExpressionConverter.ConvertO(bodyseasonalEndday);
                seasonal_endObjectpropCount++;
            }

            if (bodyseasonalEndmonth != null)
            {
                seasonal_endObject["m"] = ExpressionConverter.ConvertO(bodyseasonalEndmonth);
                seasonal_endObjectpropCount++;
            }

            if (bodyseasonalEndyear != null)
            {
                seasonal_endObject["y"] = ExpressionConverter.ConvertO(bodyseasonalEndyear);
                seasonal_endObjectpropCount++;
            }

            if (seasonal_endObjectpropCount > 0)
            {
                body["seasonal_end"] = seasonal_endObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ConstituentApiCreatedConstituentAddress>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction EditConstituentAddress(Expression<Func<string>> addressId, Expression<Func<string>> bodyaddressType = null, Expression<Func<string>> bodycountry = null, Expression<Func<string>> bodyaddressLines = null, Expression<Func<string>> bodycity = null, Expression<Func<string>> bodystate = null, Expression<Func<string>> bodypostalCode = null, Expression<Func<string>> bodysuburb = null, Expression<Func<string>> bodycounty = null, Expression<Func<string>> bodyinformationSource = null, Expression<Func<string>> bodyregion = null, Expression<Func<string>> bodycART = null, Expression<Func<string>> bodylOT = null, Expression<Func<string>> bodydPC = null, Expression<Func<string>> bodyvalidFrom = null, Expression<Func<string>> bodyvalidTo = null, Expression<Func<bool>> bodyprimary = null, Expression<Func<bool>> bodydoNotMail = null, Expression<Func<int>> bodyseasonalStartday = null, Expression<Func<int>> bodyseasonalStartmonth = null, Expression<Func<int>> bodyseasonalStartyear = null, Expression<Func<int>> bodyseasonalEndday = null, Expression<Func<int>> bodyseasonalEndmonth = null, Expression<Func<int>> bodyseasonalEndyear = null)
        {
            var apiCallPath = String.Format("/constituent/v1/addresses/{0}", ExpressionConverter.ConvertWithUrlEncoding(addressId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyaddressType != null)
            {
                body["type"] = ExpressionConverter.ConvertO(bodyaddressType);
                bodypropCount++;
            }

            if (bodycountry != null)
            {
                body["country"] = ExpressionConverter.ConvertO(bodycountry);
                bodypropCount++;
            }

            if (bodyaddressLines != null)
            {
                body["address_lines"] = ExpressionConverter.ConvertO(bodyaddressLines);
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

            if (bodypostalCode != null)
            {
                body["postal_code"] = ExpressionConverter.ConvertO(bodypostalCode);
                bodypropCount++;
            }

            if (bodysuburb != null)
            {
                body["suburb"] = ExpressionConverter.ConvertO(bodysuburb);
                bodypropCount++;
            }

            if (bodycounty != null)
            {
                body["county"] = ExpressionConverter.ConvertO(bodycounty);
                bodypropCount++;
            }

            if (bodyinformationSource != null)
            {
                body["information_source"] = ExpressionConverter.ConvertO(bodyinformationSource);
                bodypropCount++;
            }

            if (bodyregion != null)
            {
                body["region"] = ExpressionConverter.ConvertO(bodyregion);
                bodypropCount++;
            }

            if (bodycART != null)
            {
                body["cart"] = ExpressionConverter.ConvertO(bodycART);
                bodypropCount++;
            }

            if (bodylOT != null)
            {
                body["lot"] = ExpressionConverter.ConvertO(bodylOT);
                bodypropCount++;
            }

            if (bodydPC != null)
            {
                body["dpc"] = ExpressionConverter.ConvertO(bodydPC);
                bodypropCount++;
            }

            if (bodyvalidFrom != null)
            {
                body["start"] = ExpressionConverter.ConvertO(bodyvalidFrom);
                bodypropCount++;
            }

            if (bodyvalidTo != null)
            {
                body["end"] = ExpressionConverter.ConvertO(bodyvalidTo);
                bodypropCount++;
            }

            if (bodyprimary != null)
            {
                body["preferred"] = ExpressionConverter.ConvertO(bodyprimary);
                bodypropCount++;
            }

            if (bodydoNotMail != null)
            {
                body["do_not_mail"] = ExpressionConverter.ConvertO(bodydoNotMail);
                bodypropCount++;
            }

            var seasonal_startObject = new JObject();
            var seasonal_startObjectpropCount = 0;
            if (bodyseasonalStartday != null)
            {
                seasonal_startObject["d"] = ExpressionConverter.ConvertO(bodyseasonalStartday);
                seasonal_startObjectpropCount++;
            }

            if (bodyseasonalStartmonth != null)
            {
                seasonal_startObject["m"] = ExpressionConverter.ConvertO(bodyseasonalStartmonth);
                seasonal_startObjectpropCount++;
            }

            if (bodyseasonalStartyear != null)
            {
                seasonal_startObject["y"] = ExpressionConverter.ConvertO(bodyseasonalStartyear);
                seasonal_startObjectpropCount++;
            }

            if (seasonal_startObjectpropCount > 0)
            {
                body["seasonal_start"] = seasonal_startObject;
                bodypropCount++;
            }

            var seasonal_endObject = new JObject();
            var seasonal_endObjectpropCount = 0;
            if (bodyseasonalEndday != null)
            {
                seasonal_endObject["d"] = ExpressionConverter.ConvertO(bodyseasonalEndday);
                seasonal_endObjectpropCount++;
            }

            if (bodyseasonalEndmonth != null)
            {
                seasonal_endObject["m"] = ExpressionConverter.ConvertO(bodyseasonalEndmonth);
                seasonal_endObjectpropCount++;
            }

            if (bodyseasonalEndyear != null)
            {
                seasonal_endObject["y"] = ExpressionConverter.ConvertO(bodyseasonalEndyear);
                seasonal_endObjectpropCount++;
            }

            if (seasonal_endObjectpropCount > 0)
            {
                body["seasonal_end"] = seasonal_endObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiCreatedConstituentAlias> CreateConstituentAlias(Expression<Func<string>> bodyconstituentID, Expression<Func<string>> bodyalias, Expression<Func<string>> bodytype = null)
        {
            var apiCallPath = "/constituent/v1/aliases";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["constituent_id"] = ExpressionConverter.ConvertO(bodyconstituentID);
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyalias);
            if (bodytype != null)
            {
                body["type"] = ExpressionConverter.ConvertO(bodytype);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ConstituentApiCreatedConstituentAlias>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction EditConstituentAlias(Expression<Func<string>> aliasId, Expression<Func<string>> bodyalias = null, Expression<Func<string>> bodytype = null)
        {
            var apiCallPath = String.Format("/constituent/v1/aliases/{0}", ExpressionConverter.ConvertWithUrlEncoding(aliasId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyalias != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyalias);
                bodypropCount++;
            }

            if (bodytype != null)
            {
                body["type"] = ExpressionConverter.ConvertO(bodytype);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiCreatedConstituentCode> CreateConstituentCode(Expression<Func<string>> bodyconstituentID, Expression<Func<string>> bodyconstituentCode, Expression<Func<int>> bodystartday = null, Expression<Func<int>> bodystartmonth = null, Expression<Func<int>> bodystartyear = null, Expression<Func<int>> bodyendday = null, Expression<Func<int>> bodyendmonth = null, Expression<Func<int>> bodyendyear = null, Expression<Func<int>> bodysequence = null)
        {
            var apiCallPath = "/constituent/v1/constituentcodes";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["constituent_id"] = ExpressionConverter.ConvertO(bodyconstituentID);
            bodypropCount++;
            body["description"] = ExpressionConverter.ConvertO(bodyconstituentCode);
            var startObject = new JObject();
            var startObjectpropCount = 0;
            if (bodystartday != null)
            {
                startObject["d"] = ExpressionConverter.ConvertO(bodystartday);
                startObjectpropCount++;
            }

            if (bodystartmonth != null)
            {
                startObject["m"] = ExpressionConverter.ConvertO(bodystartmonth);
                startObjectpropCount++;
            }

            if (bodystartyear != null)
            {
                startObject["y"] = ExpressionConverter.ConvertO(bodystartyear);
                startObjectpropCount++;
            }

            if (startObjectpropCount > 0)
            {
                body["start"] = startObject;
                bodypropCount++;
            }

            var endObject = new JObject();
            var endObjectpropCount = 0;
            if (bodyendday != null)
            {
                endObject["d"] = ExpressionConverter.ConvertO(bodyendday);
                endObjectpropCount++;
            }

            if (bodyendmonth != null)
            {
                endObject["m"] = ExpressionConverter.ConvertO(bodyendmonth);
                endObjectpropCount++;
            }

            if (bodyendyear != null)
            {
                endObject["y"] = ExpressionConverter.ConvertO(bodyendyear);
                endObjectpropCount++;
            }

            if (endObjectpropCount > 0)
            {
                body["end"] = endObject;
                bodypropCount++;
            }

            if (bodysequence != null)
            {
                body["sequence"] = ExpressionConverter.ConvertO(bodysequence);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ConstituentApiCreatedConstituentCode>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction DeleteConstituentCode(Expression<Func<string>> constituentCodeId)
        {
            var apiCallPath = String.Format("/constituent/v1/constituentcodes/{0}", ExpressionConverter.ConvertWithUrlEncoding(constituentCodeId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction EditConstituentCode(Expression<Func<string>> constituentCodeId, Expression<Func<int>> bodystartday = null, Expression<Func<int>> bodystartmonth = null, Expression<Func<int>> bodystartyear = null, Expression<Func<int>> bodyendday = null, Expression<Func<int>> bodyendmonth = null, Expression<Func<int>> bodyendyear = null, Expression<Func<int>> bodysequence = null)
        {
            var apiCallPath = String.Format("/constituent/v1/constituentcodes/{0}", ExpressionConverter.ConvertWithUrlEncoding(constituentCodeId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            var startObject = new JObject();
            var startObjectpropCount = 0;
            if (bodystartday != null)
            {
                startObject["d"] = ExpressionConverter.ConvertO(bodystartday);
                startObjectpropCount++;
            }

            if (bodystartmonth != null)
            {
                startObject["m"] = ExpressionConverter.ConvertO(bodystartmonth);
                startObjectpropCount++;
            }

            if (bodystartyear != null)
            {
                startObject["y"] = ExpressionConverter.ConvertO(bodystartyear);
                startObjectpropCount++;
            }

            if (startObjectpropCount > 0)
            {
                body["start"] = startObject;
                bodypropCount++;
            }

            var endObject = new JObject();
            var endObjectpropCount = 0;
            if (bodyendday != null)
            {
                endObject["d"] = ExpressionConverter.ConvertO(bodyendday);
                endObjectpropCount++;
            }

            if (bodyendmonth != null)
            {
                endObject["m"] = ExpressionConverter.ConvertO(bodyendmonth);
                endObjectpropCount++;
            }

            if (bodyendyear != null)
            {
                endObject["y"] = ExpressionConverter.ConvertO(bodyendyear);
                endObjectpropCount++;
            }

            if (endObjectpropCount > 0)
            {
                body["end"] = endObject;
                bodypropCount++;
            }

            if (bodysequence != null)
            {
                body["sequence"] = ExpressionConverter.ConvertO(bodysequence);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfConstituentRead> ListConstituents(Expression<Func<string>> listId = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<string>> constituentCode = null, Expression<Func<string>> constituentId = null, Expression<Func<string>> customFieldCategory = null, Expression<Func<string>> fundraiserStatus = null, Expression<Func<bool>> includeDeceased = null, Expression<Func<bool>> includeInactive = null, Expression<Func<string>> postalCode = null, Expression<Func<string>> dateAdded = null, Expression<Func<string>> lastModified = null, Expression<Func<string>> sort = null)
        {
            var apiCallPath = "/constituent/v1/constituents";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (listId != null)
                callPayload.Queries["list_id"] = ExpressionConverter.Convert(listId);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            if (constituentCode != null)
                callPayload.Queries["constituent_code"] = ExpressionConverter.Convert(constituentCode);
            if (constituentId != null)
                callPayload.Queries["constituent_id"] = ExpressionConverter.Convert(constituentId);
            if (customFieldCategory != null)
                callPayload.Queries["custom_field_category"] = ExpressionConverter.Convert(customFieldCategory);
            if (fundraiserStatus != null)
                callPayload.Queries["fundraiser_status"] = ExpressionConverter.Convert(fundraiserStatus);
            if (includeDeceased != null)
                callPayload.Queries["include_deceased"] = ExpressionConverter.Convert(includeDeceased);
            if (includeInactive != null)
                callPayload.Queries["include_inactive"] = ExpressionConverter.Convert(includeInactive);
            if (postalCode != null)
                callPayload.Queries["postal_code"] = ExpressionConverter.Convert(postalCode);
            if (dateAdded != null)
                callPayload.Queries["date_added"] = ExpressionConverter.Convert(dateAdded);
            if (lastModified != null)
                callPayload.Queries["last_modified"] = ExpressionConverter.Convert(lastModified);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            return new ApiConnectionAction<ConstituentApiApiCollectionOfConstituentRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiConstituentRead> GetConstituent(Expression<Func<string>> constituentId)
        {
            var apiCallPath = String.Format("/constituent/v1/constituents/{0}", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ConstituentApiConstituentRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction EditConstituent(Expression<Func<string>> constituentId, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodyfirstName = null, Expression<Func<string>> bodylastName = null, Expression<Func<string>> bodyorganizationName = null, Expression<Func<string>> bodysuffix = null, Expression<Func<string>> bodypreferredName = null, Expression<Func<string>> bodylookupID = null, Expression<Func<string>> bodygender = null, Expression<Func<string>> bodymiddleName = null, Expression<Func<string>> bodyformerName = null, Expression<Func<string>> bodytitle2 = null, Expression<Func<string>> bodysuffix2 = null, Expression<Func<string>> bodymaritalStatus = null, Expression<Func<bool>> bodygivesAnonymously = null, Expression<Func<bool>> bodyinactive = null, Expression<Func<int>> bodybirthdateday = null, Expression<Func<int>> bodybirthdatemonth = null, Expression<Func<int>> bodybirthdateyear = null, Expression<Func<string>> bodybirthplace = null, Expression<Func<string>> bodyethnicity = null, Expression<Func<string>> bodyincome = null, Expression<Func<string>> bodyreligion = null, Expression<Func<string>> bodyindustry = null, Expression<Func<int>> bodynumberOfEmployees = null, Expression<Func<bool>> bodymatchesGifts = null, Expression<Func<double>> bodymatchingGiftFactor = null, Expression<Func<double>> bodymatchingGiftPerGiftMinminMatchPerGift = null, Expression<Func<double>> bodymatchingGiftPerGiftMaxmaxMatchPerGift = null, Expression<Func<double>> bodymatchingGiftTotalMinminMatchPerConstit = null, Expression<Func<double>> bodymatchingGiftTotalMaxmaxMatchPerConstit = null, Expression<Func<string>> bodymatchingGiftNotes = null, Expression<Func<bool>> bodydeceased = null, Expression<Func<int>> bodydeceasedDateday = null, Expression<Func<int>> bodydeceasedDatemonth = null, Expression<Func<int>> bodydeceasedDateyear = null)
        {
            var apiCallPath = String.Format("/constituent/v1/constituents/{0}", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytitle != null)
            {
                body["title"] = ExpressionConverter.ConvertO(bodytitle);
                bodypropCount++;
            }

            if (bodyfirstName != null)
            {
                body["first"] = ExpressionConverter.ConvertO(bodyfirstName);
                bodypropCount++;
            }

            if (bodylastName != null)
            {
                body["last"] = ExpressionConverter.ConvertO(bodylastName);
                bodypropCount++;
            }

            if (bodyorganizationName != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyorganizationName);
                bodypropCount++;
            }

            if (bodysuffix != null)
            {
                body["suffix"] = ExpressionConverter.ConvertO(bodysuffix);
                bodypropCount++;
            }

            if (bodypreferredName != null)
            {
                body["preferred_name"] = ExpressionConverter.ConvertO(bodypreferredName);
                bodypropCount++;
            }

            if (bodylookupID != null)
            {
                body["lookup_id"] = ExpressionConverter.ConvertO(bodylookupID);
                bodypropCount++;
            }

            if (bodygender != null)
            {
                body["gender"] = ExpressionConverter.ConvertO(bodygender);
                bodypropCount++;
            }

            if (bodymiddleName != null)
            {
                body["middle"] = ExpressionConverter.ConvertO(bodymiddleName);
                bodypropCount++;
            }

            if (bodyformerName != null)
            {
                body["former_name"] = ExpressionConverter.ConvertO(bodyformerName);
                bodypropCount++;
            }

            if (bodytitle2 != null)
            {
                body["title_2"] = ExpressionConverter.ConvertO(bodytitle2);
                bodypropCount++;
            }

            if (bodysuffix2 != null)
            {
                body["suffix_2"] = ExpressionConverter.ConvertO(bodysuffix2);
                bodypropCount++;
            }

            if (bodymaritalStatus != null)
            {
                body["marital_status"] = ExpressionConverter.ConvertO(bodymaritalStatus);
                bodypropCount++;
            }

            if (bodygivesAnonymously != null)
            {
                body["gives_anonymously"] = ExpressionConverter.ConvertO(bodygivesAnonymously);
                bodypropCount++;
            }

            if (bodyinactive != null)
            {
                body["inactive"] = ExpressionConverter.ConvertO(bodyinactive);
                bodypropCount++;
            }

            var birthdateObject = new JObject();
            var birthdateObjectpropCount = 0;
            if (bodybirthdateday != null)
            {
                birthdateObject["d"] = ExpressionConverter.ConvertO(bodybirthdateday);
                birthdateObjectpropCount++;
            }

            if (bodybirthdatemonth != null)
            {
                birthdateObject["m"] = ExpressionConverter.ConvertO(bodybirthdatemonth);
                birthdateObjectpropCount++;
            }

            if (bodybirthdateyear != null)
            {
                birthdateObject["y"] = ExpressionConverter.ConvertO(bodybirthdateyear);
                birthdateObjectpropCount++;
            }

            if (birthdateObjectpropCount > 0)
            {
                body["birthdate"] = birthdateObject;
                bodypropCount++;
            }

            if (bodybirthplace != null)
            {
                body["birthplace"] = ExpressionConverter.ConvertO(bodybirthplace);
                bodypropCount++;
            }

            if (bodyethnicity != null)
            {
                body["ethnicity"] = ExpressionConverter.ConvertO(bodyethnicity);
                bodypropCount++;
            }

            if (bodyincome != null)
            {
                body["income"] = ExpressionConverter.ConvertO(bodyincome);
                bodypropCount++;
            }

            if (bodyreligion != null)
            {
                body["religion"] = ExpressionConverter.ConvertO(bodyreligion);
                bodypropCount++;
            }

            if (bodyindustry != null)
            {
                body["industry"] = ExpressionConverter.ConvertO(bodyindustry);
                bodypropCount++;
            }

            if (bodynumberOfEmployees != null)
            {
                body["num_employees"] = ExpressionConverter.ConvertO(bodynumberOfEmployees);
                bodypropCount++;
            }

            if (bodymatchesGifts != null)
            {
                body["matches_gifts"] = ExpressionConverter.ConvertO(bodymatchesGifts);
                bodypropCount++;
            }

            if (bodymatchingGiftFactor != null)
            {
                body["matching_gift_factor"] = ExpressionConverter.ConvertO(bodymatchingGiftFactor);
                bodypropCount++;
            }

            var matching_gift_per_gift_minObject = new JObject();
            var matching_gift_per_gift_minObjectpropCount = 0;
            if (bodymatchingGiftPerGiftMinminMatchPerGift != null)
            {
                matching_gift_per_gift_minObject["value"] = ExpressionConverter.ConvertO(bodymatchingGiftPerGiftMinminMatchPerGift);
                matching_gift_per_gift_minObjectpropCount++;
            }

            if (matching_gift_per_gift_minObjectpropCount > 0)
            {
                body["matching_gift_per_gift_min"] = matching_gift_per_gift_minObject;
                bodypropCount++;
            }

            var matching_gift_per_gift_maxObject = new JObject();
            var matching_gift_per_gift_maxObjectpropCount = 0;
            if (bodymatchingGiftPerGiftMaxmaxMatchPerGift != null)
            {
                matching_gift_per_gift_maxObject["value"] = ExpressionConverter.ConvertO(bodymatchingGiftPerGiftMaxmaxMatchPerGift);
                matching_gift_per_gift_maxObjectpropCount++;
            }

            if (matching_gift_per_gift_maxObjectpropCount > 0)
            {
                body["matching_gift_per_gift_max"] = matching_gift_per_gift_maxObject;
                bodypropCount++;
            }

            var matching_gift_total_minObject = new JObject();
            var matching_gift_total_minObjectpropCount = 0;
            if (bodymatchingGiftTotalMinminMatchPerConstit != null)
            {
                matching_gift_total_minObject["value"] = ExpressionConverter.ConvertO(bodymatchingGiftTotalMinminMatchPerConstit);
                matching_gift_total_minObjectpropCount++;
            }

            if (matching_gift_total_minObjectpropCount > 0)
            {
                body["matching_gift_total_min"] = matching_gift_total_minObject;
                bodypropCount++;
            }

            var matching_gift_total_maxObject = new JObject();
            var matching_gift_total_maxObjectpropCount = 0;
            if (bodymatchingGiftTotalMaxmaxMatchPerConstit != null)
            {
                matching_gift_total_maxObject["value"] = ExpressionConverter.ConvertO(bodymatchingGiftTotalMaxmaxMatchPerConstit);
                matching_gift_total_maxObjectpropCount++;
            }

            if (matching_gift_total_maxObjectpropCount > 0)
            {
                body["matching_gift_total_max"] = matching_gift_total_maxObject;
                bodypropCount++;
            }

            if (bodymatchingGiftNotes != null)
            {
                body["matching_gift_notes"] = ExpressionConverter.ConvertO(bodymatchingGiftNotes);
                bodypropCount++;
            }

            if (bodydeceased != null)
            {
                body["deceased"] = ExpressionConverter.ConvertO(bodydeceased);
                bodypropCount++;
            }

            var deceased_dateObject = new JObject();
            var deceased_dateObjectpropCount = 0;
            if (bodydeceasedDateday != null)
            {
                deceased_dateObject["d"] = ExpressionConverter.ConvertO(bodydeceasedDateday);
                deceased_dateObjectpropCount++;
            }

            if (bodydeceasedDatemonth != null)
            {
                deceased_dateObject["m"] = ExpressionConverter.ConvertO(bodydeceasedDatemonth);
                deceased_dateObjectpropCount++;
            }

            if (bodydeceasedDateyear != null)
            {
                deceased_dateObject["y"] = ExpressionConverter.ConvertO(bodydeceasedDateyear);
                deceased_dateObjectpropCount++;
            }

            if (deceased_dateObjectpropCount > 0)
            {
                body["deceased_date"] = deceased_dateObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfActionRead> ListConstituentActions(Expression<Func<string>> constituentId)
        {
            var apiCallPath = String.Format("/constituent/v1/constituents/{0}/actions", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ConstituentApiApiCollectionOfActionRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfAddressRead> ListConstituentAddresses(Expression<Func<string>> constituentId, Expression<Func<bool>> includeInactive = null)
        {
            var apiCallPath = String.Format("/constituent/v1/constituents/{0}/addresses", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (includeInactive != null)
                callPayload.Queries["include_inactive"] = ExpressionConverter.Convert(includeInactive);
            return new ApiConnectionAction<ConstituentApiApiCollectionOfAddressRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfAliasRead> ListConstituentAliases(Expression<Func<string>> constituentId)
        {
            var apiCallPath = String.Format("/constituent/v1/constituents/{0}/aliases", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ConstituentApiApiCollectionOfAliasRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfConstituentAttachmentRead> ListConstituentAttachments(Expression<Func<string>> constituentId)
        {
            var apiCallPath = String.Format("/constituent/v1/constituents/{0}/attachments", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ConstituentApiApiCollectionOfConstituentAttachmentRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfConstituentCodeRead> ListConstituentCodes(Expression<Func<string>> constituentId)
        {
            var apiCallPath = String.Format("/constituent/v1/constituents/{0}/constituentcodes", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ConstituentApiApiCollectionOfConstituentCodeRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfConstituentCustomFieldRead> ListConstituentCustomFields(Expression<Func<string>> constituentId)
        {
            var apiCallPath = String.Format("/constituent/v1/constituents/{0}/customfields", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ConstituentApiApiCollectionOfConstituentCustomFieldRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfEducationRead> ListConstituentEducations(Expression<Func<string>> constituentId)
        {
            var apiCallPath = String.Format("/constituent/v1/constituents/{0}/educations", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ConstituentApiApiCollectionOfEducationRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfEmailAddressRead> ListConstituentEmailAddresses(Expression<Func<string>> constituentId, Expression<Func<bool>> includeInactive = null)
        {
            var apiCallPath = String.Format("/constituent/v1/constituents/{0}/emailaddresses", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (includeInactive != null)
                callPayload.Queries["include_inactive"] = ExpressionConverter.Convert(includeInactive);
            return new ApiConnectionAction<ConstituentApiApiCollectionOfEmailAddressRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfFundraiserAssignmentRead> ListConstituentFundraiserAssignments(Expression<Func<string>> constituentId, Expression<Func<bool>> includeInactive = null)
        {
            var apiCallPath = String.Format("/constituent/v1/constituents/{0}/fundraiserassignments", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (includeInactive != null)
                callPayload.Queries["include_inactive"] = ExpressionConverter.Convert(includeInactive);
            return new ApiConnectionAction<ConstituentApiApiCollectionOfFundraiserAssignmentRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiGivingSummaryRead> GetConstituentFirstGift(Expression<Func<string>> constituentId)
        {
            var apiCallPath = String.Format("/constituent/v1/constituents/{0}/givingsummary/first", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ConstituentApiGivingSummaryRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiGivingSummaryRead> GetConstituentGreatestGift(Expression<Func<string>> constituentId)
        {
            var apiCallPath = String.Format("/constituent/v1/constituents/{0}/givingsummary/greatest", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ConstituentApiGivingSummaryRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiGivingSummaryRead> GetConstituentLatestGift(Expression<Func<string>> constituentId)
        {
            var apiCallPath = String.Format("/constituent/v1/constituents/{0}/givingsummary/latest", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ConstituentApiGivingSummaryRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiLifetimeGivingRead> GetConstituentLifetimeGiving(Expression<Func<string>> constituentId)
        {
            var apiCallPath = String.Format("/constituent/v1/constituents/{0}/givingsummary/lifetimegiving", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ConstituentApiLifetimeGivingRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfNoteRead> ListConstituentNotes(Expression<Func<string>> constituentId)
        {
            var apiCallPath = String.Format("/constituent/v1/constituents/{0}/notes", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ConstituentApiApiCollectionOfNoteRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfOnlinePresenceRead> ListConstituentOnlinePresences(Expression<Func<string>> constituentId, Expression<Func<bool>> includeInactive = null)
        {
            var apiCallPath = String.Format("/constituent/v1/constituents/{0}/onlinepresences", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (includeInactive != null)
                callPayload.Queries["include_inactive"] = ExpressionConverter.Convert(includeInactive);
            return new ApiConnectionAction<ConstituentApiApiCollectionOfOnlinePresenceRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfPhoneRead> ListConstituentPhones(Expression<Func<string>> constituentId, Expression<Func<bool>> includeInactive = null)
        {
            var apiCallPath = String.Format("/constituent/v1/constituents/{0}/phones", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (includeInactive != null)
                callPayload.Queries["include_inactive"] = ExpressionConverter.Convert(includeInactive);
            return new ApiConnectionAction<ConstituentApiApiCollectionOfPhoneRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiProfilePictureRead> GetConstituentProfilePicture(Expression<Func<string>> constituentId)
        {
            var apiCallPath = String.Format("/constituent/v1/constituents/{0}/profilepicture", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ConstituentApiProfilePictureRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction EditConstituentProfilePicture(Expression<Func<string>> constituentId, Expression<Func<string>> bodyfileName, Expression<Func<string>> bodydocumentID, Expression<Func<string>> bodythumbnailID)
        {
            var apiCallPath = String.Format("/constituent/v1/constituents/{0}/profilepicture", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["file_name"] = ExpressionConverter.ConvertO(bodyfileName);
            bodypropCount++;
            body["document_id"] = ExpressionConverter.ConvertO(bodydocumentID);
            bodypropCount++;
            body["thumbnail_id"] = ExpressionConverter.ConvertO(bodythumbnailID);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiProspectStatusRead> GetConstituentProspectStatus(Expression<Func<string>> constituentId)
        {
            var apiCallPath = String.Format("/constituent/v1/constituents/{0}/prospectstatus", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ConstituentApiProspectStatusRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfRatingRead> ListConstituentRatings(Expression<Func<string>> constituentId, Expression<Func<bool>> includeInactive = null, Expression<Func<bool>> mostRecentOnly = null)
        {
            var apiCallPath = String.Format("/constituent/v1/constituents/{0}/ratings", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (includeInactive != null)
                callPayload.Queries["include_inactive"] = ExpressionConverter.Convert(includeInactive);
            if (mostRecentOnly != null)
                callPayload.Queries["most_recent_only"] = ExpressionConverter.Convert(mostRecentOnly);
            return new ApiConnectionAction<ConstituentApiApiCollectionOfRatingRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfRelationshipRead> ListConstituentRelationships(Expression<Func<string>> constituentId, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var apiCallPath = String.Format("/constituent/v1/constituents/{0}/relationships", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<ConstituentApiApiCollectionOfRelationshipRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiCreatedConstituentAttachment> CreateConstituentAttachment(Expression<Func<string>> bodyconstituentID, Expression<Func<bodytypeInput>> bodytype, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodyuRL = null, Expression<Func<string>> bodyfileName = null, Expression<Func<string>> bodyfileID = null, Expression<Func<string>> bodythumbnailID = null)
        {
            var apiCallPath = "/constituent/v1/constituents/attachments";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["parent_id"] = ExpressionConverter.ConvertO(bodyconstituentID);
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

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ConstituentApiCreatedConstituentAttachment>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction EditConstituentAttachment(Expression<Func<string>> attachmentId, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodyuRL = null)
        {
            var apiCallPath = String.Format("/constituent/v1/constituents/attachments/{0}", ExpressionConverter.ConvertWithUrlEncoding(attachmentId, 1));
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

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiCreatedConstituentCustomField> CreateConstituentCustomField(Expression<Func<string>> bodyconstituentID, Expression<Func<string>> bodycategory, Expression<Func<object>> bodyvalue = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodycomment = null)
        {
            var apiCallPath = "/constituent/v1/constituents/customfields";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["parent_id"] = ExpressionConverter.ConvertO(bodyconstituentID);
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

            return new ApiConnectionAction<ConstituentApiCreatedConstituentCustomField>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction EditConstituentCustomField(Expression<Func<string>> customFieldId, Expression<Func<string>> bodycategory = null, Expression<Func<object>> bodyvalue = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodycomment = null)
        {
            var apiCallPath = String.Format("/constituent/v1/constituents/customfields/{0}", ExpressionConverter.ConvertWithUrlEncoding(customFieldId, 1));
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfSearchResultRead> SearchConstituent(Expression<Func<string>> searchText, Expression<Func<string>> fundraiserStatus = null, Expression<Func<bool>> includeInactive = null, Expression<Func<searchFieldInput>> searchField = null, Expression<Func<bool>> strictSearch = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var apiCallPath = "/constituent/v1/constituents/search";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["search_text"] = ExpressionConverter.Convert(searchText);
            if (fundraiserStatus != null)
                callPayload.Queries["fundraiser_status"] = ExpressionConverter.Convert(fundraiserStatus);
            if (includeInactive != null)
                callPayload.Queries["include_inactive"] = ExpressionConverter.Convert(includeInactive);
            if (searchField != null)
                callPayload.Queries["search_field"] = ExpressionConverter.Convert(searchField);
            if (strictSearch != null)
                callPayload.Queries["strict_search"] = ExpressionConverter.Convert(strictSearch);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<ConstituentApiApiCollectionOfSearchResultRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiFileDefinition> CreateDocument(Expression<Func<string>> bodyfileName = null, Expression<Func<bool>> bodyincludeThumbnail = null)
        {
            var apiCallPath = "/constituent/v1/documents";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyfileName != null)
            {
                body["file_name"] = ExpressionConverter.ConvertO(bodyfileName);
                bodypropCount++;
            }

            if (bodyincludeThumbnail != null)
            {
                body["upload_thumbnail"] = ExpressionConverter.ConvertO(bodyincludeThumbnail);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ConstituentApiFileDefinition>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiCreatedConstituentEducation> CreateConstituentEducation(Expression<Func<string>> bodyconstituentID, Expression<Func<string>> bodyschool, Expression<Func<string>> bodytype = null, Expression<Func<string>> bodyclassOf = null, Expression<Func<string>> bodystatus = null, Expression<Func<int>> bodydateEnteredday = null, Expression<Func<int>> bodydateEnteredmonth = null, Expression<Func<int>> bodydateEnteredyear = null, Expression<Func<int>> bodydateLeftday = null, Expression<Func<int>> bodydateLeftmonth = null, Expression<Func<int>> bodydateLeftyear = null, Expression<Func<int>> bodydateGraduatedday = null, Expression<Func<int>> bodydateGraduatedmonth = null, Expression<Func<int>> bodydateGraduatedyear = null, Expression<Func<string>> bodydegree = null, Expression<Func<double>> bodygPA = null, Expression<Func<string>> bodysubjectOfStudy = null, Expression<Func<bool>> bodyprimary = null, Expression<Func<string[]>> bodymajors = null, Expression<Func<string[]>> bodyminors = null, Expression<Func<string>> bodycampus = null, Expression<Func<string>> bodysocialOrganization = null, Expression<Func<string>> bodyknownName = null, Expression<Func<string>> bodyclassOfDegree = null, Expression<Func<string>> bodydepartment = null, Expression<Func<string>> bodyfaculty = null, Expression<Func<string>> bodyregistrationNumber = null)
        {
            var apiCallPath = "/constituent/v1/educations";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["constituent_id"] = ExpressionConverter.ConvertO(bodyconstituentID);
            bodypropCount++;
            body["school"] = ExpressionConverter.ConvertO(bodyschool);
            if (bodytype != null)
            {
                body["type"] = ExpressionConverter.ConvertO(bodytype);
                bodypropCount++;
            }

            if (bodyclassOf != null)
            {
                body["class_of"] = ExpressionConverter.ConvertO(bodyclassOf);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["status"] = ExpressionConverter.ConvertO(bodystatus);
                bodypropCount++;
            }

            var date_enteredObject = new JObject();
            var date_enteredObjectpropCount = 0;
            if (bodydateEnteredday != null)
            {
                date_enteredObject["d"] = ExpressionConverter.ConvertO(bodydateEnteredday);
                date_enteredObjectpropCount++;
            }

            if (bodydateEnteredmonth != null)
            {
                date_enteredObject["m"] = ExpressionConverter.ConvertO(bodydateEnteredmonth);
                date_enteredObjectpropCount++;
            }

            if (bodydateEnteredyear != null)
            {
                date_enteredObject["y"] = ExpressionConverter.ConvertO(bodydateEnteredyear);
                date_enteredObjectpropCount++;
            }

            if (date_enteredObjectpropCount > 0)
            {
                body["date_entered"] = date_enteredObject;
                bodypropCount++;
            }

            var date_leftObject = new JObject();
            var date_leftObjectpropCount = 0;
            if (bodydateLeftday != null)
            {
                date_leftObject["d"] = ExpressionConverter.ConvertO(bodydateLeftday);
                date_leftObjectpropCount++;
            }

            if (bodydateLeftmonth != null)
            {
                date_leftObject["m"] = ExpressionConverter.ConvertO(bodydateLeftmonth);
                date_leftObjectpropCount++;
            }

            if (bodydateLeftyear != null)
            {
                date_leftObject["y"] = ExpressionConverter.ConvertO(bodydateLeftyear);
                date_leftObjectpropCount++;
            }

            if (date_leftObjectpropCount > 0)
            {
                body["date_left"] = date_leftObject;
                bodypropCount++;
            }

            var date_graduatedObject = new JObject();
            var date_graduatedObjectpropCount = 0;
            if (bodydateGraduatedday != null)
            {
                date_graduatedObject["d"] = ExpressionConverter.ConvertO(bodydateGraduatedday);
                date_graduatedObjectpropCount++;
            }

            if (bodydateGraduatedmonth != null)
            {
                date_graduatedObject["m"] = ExpressionConverter.ConvertO(bodydateGraduatedmonth);
                date_graduatedObjectpropCount++;
            }

            if (bodydateGraduatedyear != null)
            {
                date_graduatedObject["y"] = ExpressionConverter.ConvertO(bodydateGraduatedyear);
                date_graduatedObjectpropCount++;
            }

            if (date_graduatedObjectpropCount > 0)
            {
                body["date_graduated"] = date_graduatedObject;
                bodypropCount++;
            }

            if (bodydegree != null)
            {
                body["degree"] = ExpressionConverter.ConvertO(bodydegree);
                bodypropCount++;
            }

            if (bodygPA != null)
            {
                body["gpa"] = ExpressionConverter.ConvertO(bodygPA);
                bodypropCount++;
            }

            if (bodysubjectOfStudy != null)
            {
                body["subject_of_study"] = ExpressionConverter.ConvertO(bodysubjectOfStudy);
                bodypropCount++;
            }

            if (bodyprimary != null)
            {
                body["primary"] = ExpressionConverter.ConvertO(bodyprimary);
                bodypropCount++;
            }

            if (bodymajors != null)
            {
                body["majors"] = ExpressionConverter.ConvertO(bodymajors);
                bodypropCount++;
            }

            if (bodyminors != null)
            {
                body["minors"] = ExpressionConverter.ConvertO(bodyminors);
                bodypropCount++;
            }

            if (bodycampus != null)
            {
                body["campus"] = ExpressionConverter.ConvertO(bodycampus);
                bodypropCount++;
            }

            if (bodysocialOrganization != null)
            {
                body["social_organization"] = ExpressionConverter.ConvertO(bodysocialOrganization);
                bodypropCount++;
            }

            if (bodyknownName != null)
            {
                body["known_name"] = ExpressionConverter.ConvertO(bodyknownName);
                bodypropCount++;
            }

            if (bodyclassOfDegree != null)
            {
                body["class_of_degree"] = ExpressionConverter.ConvertO(bodyclassOfDegree);
                bodypropCount++;
            }

            if (bodydepartment != null)
            {
                body["department"] = ExpressionConverter.ConvertO(bodydepartment);
                bodypropCount++;
            }

            if (bodyfaculty != null)
            {
                body["faculty"] = ExpressionConverter.ConvertO(bodyfaculty);
                bodypropCount++;
            }

            if (bodyregistrationNumber != null)
            {
                body["registration_number"] = ExpressionConverter.ConvertO(bodyregistrationNumber);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ConstituentApiCreatedConstituentEducation>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction EditConstituentEducation(Expression<Func<string>> educationId, Expression<Func<string>> bodyschool = null, Expression<Func<string>> bodytype = null, Expression<Func<string>> bodyclassOf = null, Expression<Func<string>> bodystatus = null, Expression<Func<int>> bodydateEnteredday = null, Expression<Func<int>> bodydateEnteredmonth = null, Expression<Func<int>> bodydateEnteredyear = null, Expression<Func<int>> bodydateLeftday = null, Expression<Func<int>> bodydateLeftmonth = null, Expression<Func<int>> bodydateLeftyear = null, Expression<Func<int>> bodydateGraduatedday = null, Expression<Func<int>> bodydateGraduatedmonth = null, Expression<Func<int>> bodydateGraduatedyear = null, Expression<Func<string>> bodydegree = null, Expression<Func<double>> bodygPA = null, Expression<Func<string>> bodysubjectOfStudy = null, Expression<Func<bool>> bodyprimary = null, Expression<Func<string[]>> bodymajors = null, Expression<Func<string[]>> bodyminors = null, Expression<Func<string>> bodycampus = null, Expression<Func<string>> bodysocialOrganization = null, Expression<Func<string>> bodyknownName = null, Expression<Func<string>> bodyclassOfDegree = null, Expression<Func<string>> bodydepartment = null, Expression<Func<string>> bodyfaculty = null, Expression<Func<string>> bodyregistrationNumber = null)
        {
            var apiCallPath = String.Format("/constituent/v1/educations/{0}", ExpressionConverter.ConvertWithUrlEncoding(educationId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyschool != null)
            {
                body["school"] = ExpressionConverter.ConvertO(bodyschool);
                bodypropCount++;
            }

            if (bodytype != null)
            {
                body["type"] = ExpressionConverter.ConvertO(bodytype);
                bodypropCount++;
            }

            if (bodyclassOf != null)
            {
                body["class_of"] = ExpressionConverter.ConvertO(bodyclassOf);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["status"] = ExpressionConverter.ConvertO(bodystatus);
                bodypropCount++;
            }

            var date_enteredObject = new JObject();
            var date_enteredObjectpropCount = 0;
            if (bodydateEnteredday != null)
            {
                date_enteredObject["d"] = ExpressionConverter.ConvertO(bodydateEnteredday);
                date_enteredObjectpropCount++;
            }

            if (bodydateEnteredmonth != null)
            {
                date_enteredObject["m"] = ExpressionConverter.ConvertO(bodydateEnteredmonth);
                date_enteredObjectpropCount++;
            }

            if (bodydateEnteredyear != null)
            {
                date_enteredObject["y"] = ExpressionConverter.ConvertO(bodydateEnteredyear);
                date_enteredObjectpropCount++;
            }

            if (date_enteredObjectpropCount > 0)
            {
                body["date_entered"] = date_enteredObject;
                bodypropCount++;
            }

            var date_leftObject = new JObject();
            var date_leftObjectpropCount = 0;
            if (bodydateLeftday != null)
            {
                date_leftObject["d"] = ExpressionConverter.ConvertO(bodydateLeftday);
                date_leftObjectpropCount++;
            }

            if (bodydateLeftmonth != null)
            {
                date_leftObject["m"] = ExpressionConverter.ConvertO(bodydateLeftmonth);
                date_leftObjectpropCount++;
            }

            if (bodydateLeftyear != null)
            {
                date_leftObject["y"] = ExpressionConverter.ConvertO(bodydateLeftyear);
                date_leftObjectpropCount++;
            }

            if (date_leftObjectpropCount > 0)
            {
                body["date_left"] = date_leftObject;
                bodypropCount++;
            }

            var date_graduatedObject = new JObject();
            var date_graduatedObjectpropCount = 0;
            if (bodydateGraduatedday != null)
            {
                date_graduatedObject["d"] = ExpressionConverter.ConvertO(bodydateGraduatedday);
                date_graduatedObjectpropCount++;
            }

            if (bodydateGraduatedmonth != null)
            {
                date_graduatedObject["m"] = ExpressionConverter.ConvertO(bodydateGraduatedmonth);
                date_graduatedObjectpropCount++;
            }

            if (bodydateGraduatedyear != null)
            {
                date_graduatedObject["y"] = ExpressionConverter.ConvertO(bodydateGraduatedyear);
                date_graduatedObjectpropCount++;
            }

            if (date_graduatedObjectpropCount > 0)
            {
                body["date_graduated"] = date_graduatedObject;
                bodypropCount++;
            }

            if (bodydegree != null)
            {
                body["degree"] = ExpressionConverter.ConvertO(bodydegree);
                bodypropCount++;
            }

            if (bodygPA != null)
            {
                body["gpa"] = ExpressionConverter.ConvertO(bodygPA);
                bodypropCount++;
            }

            if (bodysubjectOfStudy != null)
            {
                body["subject_of_study"] = ExpressionConverter.ConvertO(bodysubjectOfStudy);
                bodypropCount++;
            }

            if (bodyprimary != null)
            {
                body["primary"] = ExpressionConverter.ConvertO(bodyprimary);
                bodypropCount++;
            }

            if (bodymajors != null)
            {
                body["majors"] = ExpressionConverter.ConvertO(bodymajors);
                bodypropCount++;
            }

            if (bodyminors != null)
            {
                body["minors"] = ExpressionConverter.ConvertO(bodyminors);
                bodypropCount++;
            }

            if (bodycampus != null)
            {
                body["campus"] = ExpressionConverter.ConvertO(bodycampus);
                bodypropCount++;
            }

            if (bodysocialOrganization != null)
            {
                body["social_organization"] = ExpressionConverter.ConvertO(bodysocialOrganization);
                bodypropCount++;
            }

            if (bodyknownName != null)
            {
                body["known_name"] = ExpressionConverter.ConvertO(bodyknownName);
                bodypropCount++;
            }

            if (bodyclassOfDegree != null)
            {
                body["class_of_degree"] = ExpressionConverter.ConvertO(bodyclassOfDegree);
                bodypropCount++;
            }

            if (bodydepartment != null)
            {
                body["department"] = ExpressionConverter.ConvertO(bodydepartment);
                bodypropCount++;
            }

            if (bodyfaculty != null)
            {
                body["faculty"] = ExpressionConverter.ConvertO(bodyfaculty);
                bodypropCount++;
            }

            if (bodyregistrationNumber != null)
            {
                body["registration_number"] = ExpressionConverter.ConvertO(bodyregistrationNumber);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiCreatedConstituentEmailAddress> CreateConstituentEmailAddress(Expression<Func<string>> bodyconstituentID, Expression<Func<string>> bodyemailType, Expression<Func<string>> bodyemailAddress, Expression<Func<bool>> bodyprimary = null, Expression<Func<bool>> bodydoNotEmail = null, Expression<Func<bool>> bodyinactive = null)
        {
            var apiCallPath = "/constituent/v1/emailaddresses";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["constituent_id"] = ExpressionConverter.ConvertO(bodyconstituentID);
            bodypropCount++;
            body["type"] = ExpressionConverter.ConvertO(bodyemailType);
            bodypropCount++;
            body["address"] = ExpressionConverter.ConvertO(bodyemailAddress);
            if (bodyprimary != null)
            {
                body["primary"] = ExpressionConverter.ConvertO(bodyprimary);
                bodypropCount++;
            }

            if (bodydoNotEmail != null)
            {
                body["do_not_email"] = ExpressionConverter.ConvertO(bodydoNotEmail);
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

            return new ApiConnectionAction<ConstituentApiCreatedConstituentEmailAddress>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction EditConstituentEmailAddress(Expression<Func<string>> emailAddressId, Expression<Func<string>> bodyemailType = null, Expression<Func<string>> bodyemailAddress = null, Expression<Func<bool>> bodyprimary = null, Expression<Func<bool>> bodydoNotEmail = null, Expression<Func<bool>> bodyinactive = null)
        {
            var apiCallPath = String.Format("/constituent/v1/emailaddresses/{0}", ExpressionConverter.ConvertWithUrlEncoding(emailAddressId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyemailType != null)
            {
                body["type"] = ExpressionConverter.ConvertO(bodyemailType);
                bodypropCount++;
            }

            if (bodyemailAddress != null)
            {
                body["address"] = ExpressionConverter.ConvertO(bodyemailAddress);
                bodypropCount++;
            }

            if (bodyprimary != null)
            {
                body["primary"] = ExpressionConverter.ConvertO(bodyprimary);
                bodypropCount++;
            }

            if (bodydoNotEmail != null)
            {
                body["do_not_email"] = ExpressionConverter.ConvertO(bodydoNotEmail);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction EditConstituentNote(Expression<Func<string>> noteId, Expression<Func<string>> bodytype = null, Expression<Func<int>> bodydateday = null, Expression<Func<int>> bodydatemonth = null, Expression<Func<int>> bodydateyear = null, Expression<Func<string>> bodysummary = null, Expression<Func<string>> bodynote = null)
        {
            var apiCallPath = String.Format("/constituent/v1/notes/{0}", ExpressionConverter.ConvertWithUrlEncoding(noteId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytype != null)
            {
                body["type"] = ExpressionConverter.ConvertO(bodytype);
                bodypropCount++;
            }

            var dateObject = new JObject();
            var dateObjectpropCount = 0;
            if (bodydateday != null)
            {
                dateObject["d"] = ExpressionConverter.ConvertO(bodydateday);
                dateObjectpropCount++;
            }

            if (bodydatemonth != null)
            {
                dateObject["m"] = ExpressionConverter.ConvertO(bodydatemonth);
                dateObjectpropCount++;
            }

            if (bodydateyear != null)
            {
                dateObject["y"] = ExpressionConverter.ConvertO(bodydateyear);
                dateObjectpropCount++;
            }

            if (dateObjectpropCount > 0)
            {
                body["date"] = dateObject;
                bodypropCount++;
            }

            if (bodysummary != null)
            {
                body["summary"] = ExpressionConverter.ConvertO(bodysummary);
                bodypropCount++;
            }

            if (bodynote != null)
            {
                body["text"] = ExpressionConverter.ConvertO(bodynote);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiCreatedConstituentOnlinePresence> CreateConstituentOnlinePresence(Expression<Func<string>> bodyconstituentID, Expression<Func<string>> bodytype, Expression<Func<string>> bodylink, Expression<Func<bool>> bodyprimary = null, Expression<Func<bool>> bodyinactive = null)
        {
            var apiCallPath = "/constituent/v1/onlinepresences";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["constituent_id"] = ExpressionConverter.ConvertO(bodyconstituentID);
            bodypropCount++;
            body["type"] = ExpressionConverter.ConvertO(bodytype);
            bodypropCount++;
            body["address"] = ExpressionConverter.ConvertO(bodylink);
            if (bodyprimary != null)
            {
                body["primary"] = ExpressionConverter.ConvertO(bodyprimary);
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

            return new ApiConnectionAction<ConstituentApiCreatedConstituentOnlinePresence>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction EditConstituentOnlinePresence(Expression<Func<string>> onlinePresenceId, Expression<Func<string>> bodytype = null, Expression<Func<string>> bodylink = null, Expression<Func<bool>> bodyprimary = null, Expression<Func<bool>> bodyinactive = null)
        {
            var apiCallPath = String.Format("/constituent/v1/onlinepresences/{0}", ExpressionConverter.ConvertWithUrlEncoding(onlinePresenceId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytype != null)
            {
                body["type"] = ExpressionConverter.ConvertO(bodytype);
                bodypropCount++;
            }

            if (bodylink != null)
            {
                body["address"] = ExpressionConverter.ConvertO(bodylink);
                bodypropCount++;
            }

            if (bodyprimary != null)
            {
                body["primary"] = ExpressionConverter.ConvertO(bodyprimary);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiCreatedConstituentPhone> CreateConstituentPhone(Expression<Func<string>> bodyconstituentID, Expression<Func<string>> bodytype, Expression<Func<string>> bodynumber, Expression<Func<bool>> bodyprimary = null, Expression<Func<bool>> bodydoNotCall = null, Expression<Func<bool>> bodyinactive = null)
        {
            var apiCallPath = "/constituent/v1/phones";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["constituent_id"] = ExpressionConverter.ConvertO(bodyconstituentID);
            bodypropCount++;
            body["type"] = ExpressionConverter.ConvertO(bodytype);
            bodypropCount++;
            body["number"] = ExpressionConverter.ConvertO(bodynumber);
            if (bodyprimary != null)
            {
                body["primary"] = ExpressionConverter.ConvertO(bodyprimary);
                bodypropCount++;
            }

            if (bodydoNotCall != null)
            {
                body["do_not_call"] = ExpressionConverter.ConvertO(bodydoNotCall);
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

            return new ApiConnectionAction<ConstituentApiCreatedConstituentPhone>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction EditConstituentPhone(Expression<Func<string>> phoneId, Expression<Func<string>> bodytype = null, Expression<Func<string>> bodynumber = null, Expression<Func<bool>> bodyprimary = null, Expression<Func<bool>> bodydoNotCall = null, Expression<Func<bool>> bodyinactive = null)
        {
            var apiCallPath = String.Format("/constituent/v1/phones/{0}", ExpressionConverter.ConvertWithUrlEncoding(phoneId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytype != null)
            {
                body["type"] = ExpressionConverter.ConvertO(bodytype);
                bodypropCount++;
            }

            if (bodynumber != null)
            {
                body["number"] = ExpressionConverter.ConvertO(bodynumber);
                bodypropCount++;
            }

            if (bodyprimary != null)
            {
                body["primary"] = ExpressionConverter.ConvertO(bodyprimary);
                bodypropCount++;
            }

            if (bodydoNotCall != null)
            {
                body["do_not_call"] = ExpressionConverter.ConvertO(bodydoNotCall);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiCreatedConstituentRating> CreateConstituentRating(Expression<Func<string>> bodyconstituentID, Expression<Func<string>> bodysource, Expression<Func<string>> bodycategory, Expression<Func<string>> bodydate, Expression<Func<object>> bodyvalue = null, Expression<Func<string>> bodycomments = null)
        {
            var apiCallPath = "/constituent/v1/ratings";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["constituent_id"] = ExpressionConverter.ConvertO(bodyconstituentID);
            bodypropCount++;
            body["source"] = ExpressionConverter.ConvertO(bodysource);
            bodypropCount++;
            body["category"] = ExpressionConverter.ConvertO(bodycategory);
            bodypropCount++;
            body["date"] = ExpressionConverter.ConvertO(bodydate);
            if (bodyvalue != null)
            {
                body["value"] = ExpressionConverter.ConvertO(bodyvalue);
                bodypropCount++;
            }

            if (bodycomments != null)
            {
                body["comment"] = ExpressionConverter.ConvertO(bodycomments);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ConstituentApiCreatedConstituentRating>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction EditConstituentRelationship(Expression<Func<string>> relationshipId, Expression<Func<string>> bodytype = null, Expression<Func<string>> bodyreciprocalType = null, Expression<Func<int>> bodystartday = null, Expression<Func<int>> bodystartmonth = null, Expression<Func<int>> bodystartyear = null, Expression<Func<int>> bodyendday = null, Expression<Func<int>> bodyendmonth = null, Expression<Func<int>> bodyendyear = null, Expression<Func<bool>> bodyisSpouse = null, Expression<Func<bool>> bodyisConstituentHeadOfHousehold = null, Expression<Func<bool>> bodyisSpouseHeadOfHousehold = null, Expression<Func<string>> bodynotes = null, Expression<Func<bool>> bodyisContact = null, Expression<Func<bool>> bodyisPrimaryBusiness = null, Expression<Func<string>> bodycontactType = null, Expression<Func<string>> bodyposition = null)
        {
            var apiCallPath = String.Format("/constituent/v1/relationships/{0}", ExpressionConverter.ConvertWithUrlEncoding(relationshipId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytype != null)
            {
                body["type"] = ExpressionConverter.ConvertO(bodytype);
                bodypropCount++;
            }

            if (bodyreciprocalType != null)
            {
                body["reciprocal_type"] = ExpressionConverter.ConvertO(bodyreciprocalType);
                bodypropCount++;
            }

            var startObject = new JObject();
            var startObjectpropCount = 0;
            if (bodystartday != null)
            {
                startObject["d"] = ExpressionConverter.ConvertO(bodystartday);
                startObjectpropCount++;
            }

            if (bodystartmonth != null)
            {
                startObject["m"] = ExpressionConverter.ConvertO(bodystartmonth);
                startObjectpropCount++;
            }

            if (bodystartyear != null)
            {
                startObject["y"] = ExpressionConverter.ConvertO(bodystartyear);
                startObjectpropCount++;
            }

            if (startObjectpropCount > 0)
            {
                body["start"] = startObject;
                bodypropCount++;
            }

            var endObject = new JObject();
            var endObjectpropCount = 0;
            if (bodyendday != null)
            {
                endObject["d"] = ExpressionConverter.ConvertO(bodyendday);
                endObjectpropCount++;
            }

            if (bodyendmonth != null)
            {
                endObject["m"] = ExpressionConverter.ConvertO(bodyendmonth);
                endObjectpropCount++;
            }

            if (bodyendyear != null)
            {
                endObject["y"] = ExpressionConverter.ConvertO(bodyendyear);
                endObjectpropCount++;
            }

            if (endObjectpropCount > 0)
            {
                body["end"] = endObject;
                bodypropCount++;
            }

            if (bodyisSpouse != null)
            {
                body["is_spouse"] = ExpressionConverter.ConvertO(bodyisSpouse);
                bodypropCount++;
            }

            if (bodyisConstituentHeadOfHousehold != null)
            {
                body["is_constituent_head_of_household"] = ExpressionConverter.ConvertO(bodyisConstituentHeadOfHousehold);
                bodypropCount++;
            }

            if (bodyisSpouseHeadOfHousehold != null)
            {
                body["is_spouse_head_of_household"] = ExpressionConverter.ConvertO(bodyisSpouseHeadOfHousehold);
                bodypropCount++;
            }

            if (bodynotes != null)
            {
                body["comment"] = ExpressionConverter.ConvertO(bodynotes);
                bodypropCount++;
            }

            if (bodyisContact != null)
            {
                body["is_organization_contact"] = ExpressionConverter.ConvertO(bodyisContact);
                bodypropCount++;
            }

            if (bodyisPrimaryBusiness != null)
            {
                body["is_primary_business"] = ExpressionConverter.ConvertO(bodyisPrimaryBusiness);
                bodypropCount++;
            }

            if (bodycontactType != null)
            {
                body["organization_contact_type"] = ExpressionConverter.ConvertO(bodycontactType);
                bodypropCount++;
            }

            if (bodyposition != null)
            {
                body["position"] = ExpressionConverter.ConvertO(bodyposition);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiCreatedIndividualConstituent> CreateIndividualConstituent(Expression<Func<string>> bodylastName, Expression<Func<string>> bodyaddresstype, Expression<Func<string>> bodyphonetype, Expression<Func<string>> bodyphonenumber, Expression<Func<string>> bodyemailtype, Expression<Func<string>> bodyemailaddress, Expression<Func<string>> bodyonlinePresencetype, Expression<Func<string>> bodyonlinePresenceaddress, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodyfirstName = null, Expression<Func<string>> bodysuffix = null, Expression<Func<string>> bodylookupID = null, Expression<Func<string>> bodyaddresscountry = null, Expression<Func<string>> bodyaddresslines = null, Expression<Func<string>> bodyaddresscity = null, Expression<Func<string>> bodyaddressstate = null, Expression<Func<string>> bodyaddresspostalCode = null, Expression<Func<string>> bodyaddresssuburb = null, Expression<Func<string>> bodyaddresscounty = null, Expression<Func<string>> bodyaddressstart = null, Expression<Func<string>> bodyaddressend = null, Expression<Func<bool>> bodyphoneisPrimary = null, Expression<Func<bool>> bodyemailisPrimary = null, Expression<Func<bool>> bodyonlinePresenceisPrimary = null, Expression<Func<string>> bodypreferredName = null, Expression<Func<string>> bodymiddleName = null, Expression<Func<string>> bodyformerName = null, Expression<Func<string>> bodytitle2 = null, Expression<Func<string>> bodysuffix2 = null, Expression<Func<string>> bodygender = null, Expression<Func<string>> bodymaritalStatus = null, Expression<Func<bool>> bodygivesAnonymously = null, Expression<Func<int>> bodybirthdateday = null, Expression<Func<int>> bodybirthdatemonth = null, Expression<Func<int>> bodybirthdateyear = null, Expression<Func<string>> bodybirthplace = null, Expression<Func<string>> bodyethnicity = null, Expression<Func<string>> bodyincome = null, Expression<Func<string>> bodyreligion = null, Expression<Func<bool>> bodyprimaryAddresseecustomAddressee = null, Expression<Func<string>> bodyprimaryAddresseeaddresseeFormat = null, Expression<Func<string>> bodyprimaryAddresseeaddresseeCustomName = null, Expression<Func<bool>> bodyprimarySalutationcustomSalutation = null, Expression<Func<string>> bodyprimarySalutationsalutationFormat = null, Expression<Func<string>> bodyprimarySalutationsalutationCustomName = null)
        {
            var apiCallPath = "/constituent/v1/virtual/individuals";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["type"] = "Individual";
            bodypropCount++;
            if (bodytitle != null)
            {
                body["title"] = ExpressionConverter.ConvertO(bodytitle);
                bodypropCount++;
            }

            if (bodyfirstName != null)
            {
                body["first"] = ExpressionConverter.ConvertO(bodyfirstName);
                bodypropCount++;
            }

            bodypropCount++;
            body["last"] = ExpressionConverter.ConvertO(bodylastName);
            if (bodysuffix != null)
            {
                body["suffix"] = ExpressionConverter.ConvertO(bodysuffix);
                bodypropCount++;
            }

            if (bodylookupID != null)
            {
                body["lookup_id"] = ExpressionConverter.ConvertO(bodylookupID);
                bodypropCount++;
            }

            var addressObject = new JObject();
            var addressObjectpropCount = 0;
            addressObjectpropCount++;
            addressObject["type"] = ExpressionConverter.ConvertO(bodyaddresstype);
            if (bodyaddresscountry != null)
            {
                addressObject["country"] = ExpressionConverter.ConvertO(bodyaddresscountry);
                addressObjectpropCount++;
            }

            if (bodyaddresslines != null)
            {
                addressObject["address_lines"] = ExpressionConverter.ConvertO(bodyaddresslines);
                addressObjectpropCount++;
            }

            if (bodyaddresscity != null)
            {
                addressObject["city"] = ExpressionConverter.ConvertO(bodyaddresscity);
                addressObjectpropCount++;
            }

            if (bodyaddressstate != null)
            {
                addressObject["state"] = ExpressionConverter.ConvertO(bodyaddressstate);
                addressObjectpropCount++;
            }

            if (bodyaddresspostalCode != null)
            {
                addressObject["postal_code"] = ExpressionConverter.ConvertO(bodyaddresspostalCode);
                addressObjectpropCount++;
            }

            if (bodyaddresssuburb != null)
            {
                addressObject["suburb"] = ExpressionConverter.ConvertO(bodyaddresssuburb);
                addressObjectpropCount++;
            }

            if (bodyaddresscounty != null)
            {
                addressObject["county"] = ExpressionConverter.ConvertO(bodyaddresscounty);
                addressObjectpropCount++;
            }

            if (bodyaddressstart != null)
            {
                addressObject["start"] = ExpressionConverter.ConvertO(bodyaddressstart);
                addressObjectpropCount++;
            }

            if (bodyaddressend != null)
            {
                addressObject["end"] = ExpressionConverter.ConvertO(bodyaddressend);
                addressObjectpropCount++;
            }

            if (addressObjectpropCount > 0)
            {
                body["address"] = addressObject;
                bodypropCount++;
            }

            var phoneObject = new JObject();
            var phoneObjectpropCount = 0;
            phoneObjectpropCount++;
            phoneObject["type"] = ExpressionConverter.ConvertO(bodyphonetype);
            phoneObjectpropCount++;
            phoneObject["number"] = ExpressionConverter.ConvertO(bodyphonenumber);
            if (bodyphoneisPrimary != null)
            {
                phoneObject["primary"] = ExpressionConverter.ConvertO(bodyphoneisPrimary);
                phoneObjectpropCount++;
            }

            if (phoneObjectpropCount > 0)
            {
                body["phone"] = phoneObject;
                bodypropCount++;
            }

            var emailObject = new JObject();
            var emailObjectpropCount = 0;
            emailObjectpropCount++;
            emailObject["type"] = ExpressionConverter.ConvertO(bodyemailtype);
            emailObjectpropCount++;
            emailObject["address"] = ExpressionConverter.ConvertO(bodyemailaddress);
            if (bodyemailisPrimary != null)
            {
                emailObject["primary"] = ExpressionConverter.ConvertO(bodyemailisPrimary);
                emailObjectpropCount++;
            }

            if (emailObjectpropCount > 0)
            {
                body["email"] = emailObject;
                bodypropCount++;
            }

            var online_presenceObject = new JObject();
            var online_presenceObjectpropCount = 0;
            online_presenceObjectpropCount++;
            online_presenceObject["type"] = ExpressionConverter.ConvertO(bodyonlinePresencetype);
            online_presenceObjectpropCount++;
            online_presenceObject["address"] = ExpressionConverter.ConvertO(bodyonlinePresenceaddress);
            if (bodyonlinePresenceisPrimary != null)
            {
                online_presenceObject["primary"] = ExpressionConverter.ConvertO(bodyonlinePresenceisPrimary);
                online_presenceObjectpropCount++;
            }

            if (online_presenceObjectpropCount > 0)
            {
                body["online_presence"] = online_presenceObject;
                bodypropCount++;
            }

            if (bodypreferredName != null)
            {
                body["preferred_name"] = ExpressionConverter.ConvertO(bodypreferredName);
                bodypropCount++;
            }

            if (bodymiddleName != null)
            {
                body["middle"] = ExpressionConverter.ConvertO(bodymiddleName);
                bodypropCount++;
            }

            if (bodyformerName != null)
            {
                body["former_name"] = ExpressionConverter.ConvertO(bodyformerName);
                bodypropCount++;
            }

            if (bodytitle2 != null)
            {
                body["title_2"] = ExpressionConverter.ConvertO(bodytitle2);
                bodypropCount++;
            }

            if (bodysuffix2 != null)
            {
                body["suffix_2"] = ExpressionConverter.ConvertO(bodysuffix2);
                bodypropCount++;
            }

            if (bodygender != null)
            {
                body["gender"] = ExpressionConverter.ConvertO(bodygender);
                bodypropCount++;
            }

            if (bodymaritalStatus != null)
            {
                body["marital_status"] = ExpressionConverter.ConvertO(bodymaritalStatus);
                bodypropCount++;
            }

            if (bodygivesAnonymously != null)
            {
                body["gives_anonymously"] = ExpressionConverter.ConvertO(bodygivesAnonymously);
                bodypropCount++;
            }

            var birthdateObject = new JObject();
            var birthdateObjectpropCount = 0;
            if (bodybirthdateday != null)
            {
                birthdateObject["d"] = ExpressionConverter.ConvertO(bodybirthdateday);
                birthdateObjectpropCount++;
            }

            if (bodybirthdatemonth != null)
            {
                birthdateObject["m"] = ExpressionConverter.ConvertO(bodybirthdatemonth);
                birthdateObjectpropCount++;
            }

            if (bodybirthdateyear != null)
            {
                birthdateObject["y"] = ExpressionConverter.ConvertO(bodybirthdateyear);
                birthdateObjectpropCount++;
            }

            if (birthdateObjectpropCount > 0)
            {
                body["birthdate"] = birthdateObject;
                bodypropCount++;
            }

            if (bodybirthplace != null)
            {
                body["birthplace"] = ExpressionConverter.ConvertO(bodybirthplace);
                bodypropCount++;
            }

            if (bodyethnicity != null)
            {
                body["ethnicity"] = ExpressionConverter.ConvertO(bodyethnicity);
                bodypropCount++;
            }

            if (bodyincome != null)
            {
                body["income"] = ExpressionConverter.ConvertO(bodyincome);
                bodypropCount++;
            }

            if (bodyreligion != null)
            {
                body["religion"] = ExpressionConverter.ConvertO(bodyreligion);
                bodypropCount++;
            }

            var primary_addresseeObject = new JObject();
            var primary_addresseeObjectpropCount = 0;
            if (bodyprimaryAddresseecustomAddressee != null)
            {
                primary_addresseeObject["custom_format"] = ExpressionConverter.ConvertO(bodyprimaryAddresseecustomAddressee);
                primary_addresseeObjectpropCount++;
            }

            if (bodyprimaryAddresseeaddresseeFormat != null)
            {
                primary_addresseeObject["configuration_id"] = ExpressionConverter.ConvertO(bodyprimaryAddresseeaddresseeFormat);
                primary_addresseeObjectpropCount++;
            }

            if (bodyprimaryAddresseeaddresseeCustomName != null)
            {
                primary_addresseeObject["formatted_name"] = ExpressionConverter.ConvertO(bodyprimaryAddresseeaddresseeCustomName);
                primary_addresseeObjectpropCount++;
            }

            if (primary_addresseeObjectpropCount > 0)
            {
                body["primary_addressee"] = primary_addresseeObject;
                bodypropCount++;
            }

            var primary_salutationObject = new JObject();
            var primary_salutationObjectpropCount = 0;
            if (bodyprimarySalutationcustomSalutation != null)
            {
                primary_salutationObject["custom_format"] = ExpressionConverter.ConvertO(bodyprimarySalutationcustomSalutation);
                primary_salutationObjectpropCount++;
            }

            if (bodyprimarySalutationsalutationFormat != null)
            {
                primary_salutationObject["configuration_id"] = ExpressionConverter.ConvertO(bodyprimarySalutationsalutationFormat);
                primary_salutationObjectpropCount++;
            }

            if (bodyprimarySalutationsalutationCustomName != null)
            {
                primary_salutationObject["formatted_name"] = ExpressionConverter.ConvertO(bodyprimarySalutationsalutationCustomName);
                primary_salutationObjectpropCount++;
            }

            if (primary_salutationObjectpropCount > 0)
            {
                body["primary_salutation"] = primary_salutationObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ConstituentApiCreatedIndividualConstituent>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiCreatedIndividualRelationship> CreateIndividualRelationship(Expression<Func<string>> bodyconstituentID, Expression<Func<string>> bodyrelationID, Expression<Func<string>> bodytype = null, Expression<Func<string>> bodyreciprocalType = null, Expression<Func<int>> bodystartday = null, Expression<Func<int>> bodystartmonth = null, Expression<Func<int>> bodystartyear = null, Expression<Func<int>> bodyendday = null, Expression<Func<int>> bodyendmonth = null, Expression<Func<int>> bodyendyear = null, Expression<Func<bool>> bodyisSpouse = null, Expression<Func<bool>> bodyisConstituentHeadOfHousehold = null, Expression<Func<bool>> bodyisSpouseHeadOfHousehold = null, Expression<Func<string>> bodynotes = null)
        {
            var apiCallPath = "/constituent/v1/virtual/individualrelationships";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["constituent_id"] = ExpressionConverter.ConvertO(bodyconstituentID);
            bodypropCount++;
            body["relation_id"] = ExpressionConverter.ConvertO(bodyrelationID);
            if (bodytype != null)
            {
                body["type"] = ExpressionConverter.ConvertO(bodytype);
                bodypropCount++;
            }

            if (bodyreciprocalType != null)
            {
                body["reciprocal_type"] = ExpressionConverter.ConvertO(bodyreciprocalType);
                bodypropCount++;
            }

            var startObject = new JObject();
            var startObjectpropCount = 0;
            if (bodystartday != null)
            {
                startObject["d"] = ExpressionConverter.ConvertO(bodystartday);
                startObjectpropCount++;
            }

            if (bodystartmonth != null)
            {
                startObject["m"] = ExpressionConverter.ConvertO(bodystartmonth);
                startObjectpropCount++;
            }

            if (bodystartyear != null)
            {
                startObject["y"] = ExpressionConverter.ConvertO(bodystartyear);
                startObjectpropCount++;
            }

            if (startObjectpropCount > 0)
            {
                body["start"] = startObject;
                bodypropCount++;
            }

            var endObject = new JObject();
            var endObjectpropCount = 0;
            if (bodyendday != null)
            {
                endObject["d"] = ExpressionConverter.ConvertO(bodyendday);
                endObjectpropCount++;
            }

            if (bodyendmonth != null)
            {
                endObject["m"] = ExpressionConverter.ConvertO(bodyendmonth);
                endObjectpropCount++;
            }

            if (bodyendyear != null)
            {
                endObject["y"] = ExpressionConverter.ConvertO(bodyendyear);
                endObjectpropCount++;
            }

            if (endObjectpropCount > 0)
            {
                body["end"] = endObject;
                bodypropCount++;
            }

            if (bodyisSpouse != null)
            {
                body["is_spouse"] = ExpressionConverter.ConvertO(bodyisSpouse);
                bodypropCount++;
            }

            if (bodyisConstituentHeadOfHousehold != null)
            {
                body["is_constituent_head_of_household"] = ExpressionConverter.ConvertO(bodyisConstituentHeadOfHousehold);
                bodypropCount++;
            }

            if (bodyisSpouseHeadOfHousehold != null)
            {
                body["is_spouse_head_of_household"] = ExpressionConverter.ConvertO(bodyisSpouseHeadOfHousehold);
                bodypropCount++;
            }

            if (bodynotes != null)
            {
                body["comment"] = ExpressionConverter.ConvertO(bodynotes);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ConstituentApiCreatedIndividualRelationship>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiCreatedOrganizationConstituent> CreateOrganizationConstituent(Expression<Func<string>> bodyname, Expression<Func<string>> bodyaddresstype, Expression<Func<string>> bodyphonetype, Expression<Func<string>> bodyphonenumber, Expression<Func<string>> bodyemailtype, Expression<Func<string>> bodyemailaddress, Expression<Func<string>> bodyonlinePresencetype, Expression<Func<string>> bodyonlinePresenceaddress, Expression<Func<string>> bodylookupID = null, Expression<Func<string>> bodyaddresscountry = null, Expression<Func<string>> bodyaddresslines = null, Expression<Func<string>> bodyaddresscity = null, Expression<Func<string>> bodyaddressstate = null, Expression<Func<string>> bodyaddresspostalCode = null, Expression<Func<string>> bodyaddresssuburb = null, Expression<Func<string>> bodyaddresscounty = null, Expression<Func<string>> bodyaddressstart = null, Expression<Func<string>> bodyaddressend = null, Expression<Func<bool>> bodyphoneisPrimary = null, Expression<Func<bool>> bodyemailisPrimary = null, Expression<Func<bool>> bodyonlinePresenceisPrimary = null, Expression<Func<bool>> bodygivesAnonymously = null, Expression<Func<string>> bodyindustry = null, Expression<Func<int>> bodynumberOfEmployees = null, Expression<Func<bool>> bodymatchesGifts = null, Expression<Func<double>> bodymatchingGiftFactor = null, Expression<Func<double>> bodymatchingGiftPerGiftMinminMatchPerGift = null, Expression<Func<double>> bodymatchingGiftPerGiftMaxmaxMatchPerGift = null, Expression<Func<double>> bodymatchingGiftTotalMinminMatchPerConstit = null, Expression<Func<double>> bodymatchingGiftTotalMaxmaxMatchPerConstit = null, Expression<Func<string>> bodymatchingGiftNotes = null)
        {
            var apiCallPath = "/constituent/v1/virtual/organizations";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["type"] = "Organization";
            bodypropCount++;
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            if (bodylookupID != null)
            {
                body["lookup_id"] = ExpressionConverter.ConvertO(bodylookupID);
                bodypropCount++;
            }

            var addressObject = new JObject();
            var addressObjectpropCount = 0;
            addressObjectpropCount++;
            addressObject["type"] = ExpressionConverter.ConvertO(bodyaddresstype);
            if (bodyaddresscountry != null)
            {
                addressObject["country"] = ExpressionConverter.ConvertO(bodyaddresscountry);
                addressObjectpropCount++;
            }

            if (bodyaddresslines != null)
            {
                addressObject["address_lines"] = ExpressionConverter.ConvertO(bodyaddresslines);
                addressObjectpropCount++;
            }

            if (bodyaddresscity != null)
            {
                addressObject["city"] = ExpressionConverter.ConvertO(bodyaddresscity);
                addressObjectpropCount++;
            }

            if (bodyaddressstate != null)
            {
                addressObject["state"] = ExpressionConverter.ConvertO(bodyaddressstate);
                addressObjectpropCount++;
            }

            if (bodyaddresspostalCode != null)
            {
                addressObject["postal_code"] = ExpressionConverter.ConvertO(bodyaddresspostalCode);
                addressObjectpropCount++;
            }

            if (bodyaddresssuburb != null)
            {
                addressObject["suburb"] = ExpressionConverter.ConvertO(bodyaddresssuburb);
                addressObjectpropCount++;
            }

            if (bodyaddresscounty != null)
            {
                addressObject["county"] = ExpressionConverter.ConvertO(bodyaddresscounty);
                addressObjectpropCount++;
            }

            if (bodyaddressstart != null)
            {
                addressObject["start"] = ExpressionConverter.ConvertO(bodyaddressstart);
                addressObjectpropCount++;
            }

            if (bodyaddressend != null)
            {
                addressObject["end"] = ExpressionConverter.ConvertO(bodyaddressend);
                addressObjectpropCount++;
            }

            if (addressObjectpropCount > 0)
            {
                body["address"] = addressObject;
                bodypropCount++;
            }

            var phoneObject = new JObject();
            var phoneObjectpropCount = 0;
            phoneObjectpropCount++;
            phoneObject["type"] = ExpressionConverter.ConvertO(bodyphonetype);
            phoneObjectpropCount++;
            phoneObject["number"] = ExpressionConverter.ConvertO(bodyphonenumber);
            if (bodyphoneisPrimary != null)
            {
                phoneObject["primary"] = ExpressionConverter.ConvertO(bodyphoneisPrimary);
                phoneObjectpropCount++;
            }

            if (phoneObjectpropCount > 0)
            {
                body["phone"] = phoneObject;
                bodypropCount++;
            }

            var emailObject = new JObject();
            var emailObjectpropCount = 0;
            emailObjectpropCount++;
            emailObject["type"] = ExpressionConverter.ConvertO(bodyemailtype);
            emailObjectpropCount++;
            emailObject["address"] = ExpressionConverter.ConvertO(bodyemailaddress);
            if (bodyemailisPrimary != null)
            {
                emailObject["primary"] = ExpressionConverter.ConvertO(bodyemailisPrimary);
                emailObjectpropCount++;
            }

            if (emailObjectpropCount > 0)
            {
                body["email"] = emailObject;
                bodypropCount++;
            }

            var online_presenceObject = new JObject();
            var online_presenceObjectpropCount = 0;
            online_presenceObjectpropCount++;
            online_presenceObject["type"] = ExpressionConverter.ConvertO(bodyonlinePresencetype);
            online_presenceObjectpropCount++;
            online_presenceObject["address"] = ExpressionConverter.ConvertO(bodyonlinePresenceaddress);
            if (bodyonlinePresenceisPrimary != null)
            {
                online_presenceObject["primary"] = ExpressionConverter.ConvertO(bodyonlinePresenceisPrimary);
                online_presenceObjectpropCount++;
            }

            if (online_presenceObjectpropCount > 0)
            {
                body["online_presence"] = online_presenceObject;
                bodypropCount++;
            }

            if (bodygivesAnonymously != null)
            {
                body["gives_anonymously"] = ExpressionConverter.ConvertO(bodygivesAnonymously);
                bodypropCount++;
            }

            if (bodyindustry != null)
            {
                body["industry"] = ExpressionConverter.ConvertO(bodyindustry);
                bodypropCount++;
            }

            if (bodynumberOfEmployees != null)
            {
                body["num_employees"] = ExpressionConverter.ConvertO(bodynumberOfEmployees);
                bodypropCount++;
            }

            if (bodymatchesGifts != null)
            {
                body["matches_gifts"] = ExpressionConverter.ConvertO(bodymatchesGifts);
                bodypropCount++;
            }

            if (bodymatchingGiftFactor != null)
            {
                body["matching_gift_factor"] = ExpressionConverter.ConvertO(bodymatchingGiftFactor);
                bodypropCount++;
            }

            var matching_gift_per_gift_minObject = new JObject();
            var matching_gift_per_gift_minObjectpropCount = 0;
            if (bodymatchingGiftPerGiftMinminMatchPerGift != null)
            {
                matching_gift_per_gift_minObject["value"] = ExpressionConverter.ConvertO(bodymatchingGiftPerGiftMinminMatchPerGift);
                matching_gift_per_gift_minObjectpropCount++;
            }

            if (matching_gift_per_gift_minObjectpropCount > 0)
            {
                body["matching_gift_per_gift_min"] = matching_gift_per_gift_minObject;
                bodypropCount++;
            }

            var matching_gift_per_gift_maxObject = new JObject();
            var matching_gift_per_gift_maxObjectpropCount = 0;
            if (bodymatchingGiftPerGiftMaxmaxMatchPerGift != null)
            {
                matching_gift_per_gift_maxObject["value"] = ExpressionConverter.ConvertO(bodymatchingGiftPerGiftMaxmaxMatchPerGift);
                matching_gift_per_gift_maxObjectpropCount++;
            }

            if (matching_gift_per_gift_maxObjectpropCount > 0)
            {
                body["matching_gift_per_gift_max"] = matching_gift_per_gift_maxObject;
                bodypropCount++;
            }

            var matching_gift_total_minObject = new JObject();
            var matching_gift_total_minObjectpropCount = 0;
            if (bodymatchingGiftTotalMinminMatchPerConstit != null)
            {
                matching_gift_total_minObject["value"] = ExpressionConverter.ConvertO(bodymatchingGiftTotalMinminMatchPerConstit);
                matching_gift_total_minObjectpropCount++;
            }

            if (matching_gift_total_minObjectpropCount > 0)
            {
                body["matching_gift_total_min"] = matching_gift_total_minObject;
                bodypropCount++;
            }

            var matching_gift_total_maxObject = new JObject();
            var matching_gift_total_maxObjectpropCount = 0;
            if (bodymatchingGiftTotalMaxmaxMatchPerConstit != null)
            {
                matching_gift_total_maxObject["value"] = ExpressionConverter.ConvertO(bodymatchingGiftTotalMaxmaxMatchPerConstit);
                matching_gift_total_maxObjectpropCount++;
            }

            if (matching_gift_total_maxObjectpropCount > 0)
            {
                body["matching_gift_total_max"] = matching_gift_total_maxObject;
                bodypropCount++;
            }

            if (bodymatchingGiftNotes != null)
            {
                body["matching_gift_notes"] = ExpressionConverter.ConvertO(bodymatchingGiftNotes);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ConstituentApiCreatedOrganizationConstituent>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiCreatedOrganizationRelationship> CreateOrganizationRelationship(Expression<Func<string>> bodyconstituentID, Expression<Func<string>> bodyrelationID, Expression<Func<string>> bodytype = null, Expression<Func<string>> bodyreciprocalType = null, Expression<Func<int>> bodystartday = null, Expression<Func<int>> bodystartmonth = null, Expression<Func<int>> bodystartyear = null, Expression<Func<int>> bodyendday = null, Expression<Func<int>> bodyendmonth = null, Expression<Func<int>> bodyendyear = null, Expression<Func<bool>> bodyisContact = null, Expression<Func<string>> bodycontactType = null, Expression<Func<string>> bodyposition = null, Expression<Func<bool>> bodyisPrimaryBusiness = null, Expression<Func<string>> bodynotes = null)
        {
            var apiCallPath = "/constituent/v1/virtual/organizationrelationships";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["constituent_id"] = ExpressionConverter.ConvertO(bodyconstituentID);
            bodypropCount++;
            body["relation_id"] = ExpressionConverter.ConvertO(bodyrelationID);
            if (bodytype != null)
            {
                body["type"] = ExpressionConverter.ConvertO(bodytype);
                bodypropCount++;
            }

            if (bodyreciprocalType != null)
            {
                body["reciprocal_type"] = ExpressionConverter.ConvertO(bodyreciprocalType);
                bodypropCount++;
            }

            var startObject = new JObject();
            var startObjectpropCount = 0;
            if (bodystartday != null)
            {
                startObject["d"] = ExpressionConverter.ConvertO(bodystartday);
                startObjectpropCount++;
            }

            if (bodystartmonth != null)
            {
                startObject["m"] = ExpressionConverter.ConvertO(bodystartmonth);
                startObjectpropCount++;
            }

            if (bodystartyear != null)
            {
                startObject["y"] = ExpressionConverter.ConvertO(bodystartyear);
                startObjectpropCount++;
            }

            if (startObjectpropCount > 0)
            {
                body["start"] = startObject;
                bodypropCount++;
            }

            var endObject = new JObject();
            var endObjectpropCount = 0;
            if (bodyendday != null)
            {
                endObject["d"] = ExpressionConverter.ConvertO(bodyendday);
                endObjectpropCount++;
            }

            if (bodyendmonth != null)
            {
                endObject["m"] = ExpressionConverter.ConvertO(bodyendmonth);
                endObjectpropCount++;
            }

            if (bodyendyear != null)
            {
                endObject["y"] = ExpressionConverter.ConvertO(bodyendyear);
                endObjectpropCount++;
            }

            if (endObjectpropCount > 0)
            {
                body["end"] = endObject;
                bodypropCount++;
            }

            if (bodyisContact != null)
            {
                body["is_organization_contact"] = ExpressionConverter.ConvertO(bodyisContact);
                bodypropCount++;
            }

            if (bodycontactType != null)
            {
                body["organization_contact_type"] = ExpressionConverter.ConvertO(bodycontactType);
                bodypropCount++;
            }

            if (bodyposition != null)
            {
                body["position"] = ExpressionConverter.ConvertO(bodyposition);
                bodypropCount++;
            }

            if (bodyisPrimaryBusiness != null)
            {
                body["is_primary_business"] = ExpressionConverter.ConvertO(bodyisPrimaryBusiness);
                bodypropCount++;
            }

            if (bodynotes != null)
            {
                body["comment"] = ExpressionConverter.ConvertO(bodynotes);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ConstituentApiCreatedOrganizationRelationship>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<EventApiApiCollectionOfEventListEntry> ListEvents(Expression<Func<string>> category = null, Expression<Func<string>> startDateFrom = null, Expression<Func<string>> startDateTo = null, Expression<Func<bool>> includeInactive = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<string>> eventId = null, Expression<Func<string>> name = null, Expression<Func<string>> dateAdded = null, Expression<Func<string>> lastModified = null)
        {
            var apiCallPath = "/event/v1/eventlist";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (category != null)
                callPayload.Queries["category"] = ExpressionConverter.Convert(category);
            if (startDateFrom != null)
                callPayload.Queries["start_date_from"] = ExpressionConverter.Convert(startDateFrom);
            if (startDateTo != null)
                callPayload.Queries["start_date_to"] = ExpressionConverter.Convert(startDateTo);
            if (includeInactive != null)
                callPayload.Queries["include_inactive"] = ExpressionConverter.Convert(includeInactive);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            if (eventId != null)
                callPayload.Queries["event_id"] = ExpressionConverter.Convert(eventId);
            if (name != null)
                callPayload.Queries["name"] = ExpressionConverter.Convert(name);
            if (dateAdded != null)
                callPayload.Queries["date_added"] = ExpressionConverter.Convert(dateAdded);
            if (lastModified != null)
                callPayload.Queries["last_modified"] = ExpressionConverter.Convert(lastModified);
            return new ApiConnectionAction<EventApiApiCollectionOfEventListEntry>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<EventApiCreatedEvent> CreateEvent(Expression<Func<string>> bodyeventName, Expression<Func<string>> bodycategorycategory, Expression<Func<string>> bodystartDate, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodystartTime = null, Expression<Func<string>> bodyendDate = null, Expression<Func<string>> bodyendTime = null, Expression<Func<string>> bodylookupID = null, Expression<Func<int>> bodycapacity = null, Expression<Func<double>> bodygoal = null, Expression<Func<string>> bodycampaignID = null, Expression<Func<string>> bodyfundID = null, Expression<Func<bool>> bodyinactive = null)
        {
            var apiCallPath = "/event/v1/events";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyeventName);
            if (bodydescription != null)
            {
                body["description"] = ExpressionConverter.ConvertO(bodydescription);
                bodypropCount++;
            }

            var categoryObject = new JObject();
            var categoryObjectpropCount = 0;
            categoryObjectpropCount++;
            categoryObject["name"] = ExpressionConverter.ConvertO(bodycategorycategory);
            if (categoryObjectpropCount > 0)
            {
                body["category"] = categoryObject;
                bodypropCount++;
            }

            bodypropCount++;
            body["start_date"] = ExpressionConverter.ConvertO(bodystartDate);
            if (bodystartTime != null)
            {
                body["start_time"] = ExpressionConverter.ConvertO(bodystartTime);
                bodypropCount++;
            }

            if (bodyendDate != null)
            {
                body["end_date"] = ExpressionConverter.ConvertO(bodyendDate);
                bodypropCount++;
            }

            if (bodyendTime != null)
            {
                body["end_time"] = ExpressionConverter.ConvertO(bodyendTime);
                bodypropCount++;
            }

            if (bodylookupID != null)
            {
                body["lookup_id"] = ExpressionConverter.ConvertO(bodylookupID);
                bodypropCount++;
            }

            if (bodycapacity != null)
            {
                body["capacity"] = ExpressionConverter.ConvertO(bodycapacity);
                bodypropCount++;
            }

            if (bodygoal != null)
            {
                body["goal"] = ExpressionConverter.ConvertO(bodygoal);
                bodypropCount++;
            }

            if (bodycampaignID != null)
            {
                body["campaign_id"] = ExpressionConverter.ConvertO(bodycampaignID);
                bodypropCount++;
            }

            if (bodyfundID != null)
            {
                body["fund_id"] = ExpressionConverter.ConvertO(bodyfundID);
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

            return new ApiConnectionAction<EventApiCreatedEvent>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<EventApiEvent> GetEvent(Expression<Func<string>> eventId)
        {
            var apiCallPath = String.Format("/event/v1/events/{0}", ExpressionConverter.ConvertWithUrlEncoding(eventId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EventApiEvent>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction EditEvent(Expression<Func<string>> eventId, Expression<Func<string>> bodycategorycategory, Expression<Func<string>> bodyeventName = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodystartTime = null, Expression<Func<string>> bodyendDate = null, Expression<Func<string>> bodyendTime = null, Expression<Func<string>> bodylookupID = null, Expression<Func<int>> bodycapacity = null, Expression<Func<double>> bodygoal = null, Expression<Func<string>> bodycampaignID = null, Expression<Func<string>> bodyfundID = null, Expression<Func<bool>> bodyinactive = null)
        {
            var apiCallPath = String.Format("/event/v1/events/{0}", ExpressionConverter.ConvertWithUrlEncoding(eventId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyeventName != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyeventName);
                bodypropCount++;
            }

            if (bodydescription != null)
            {
                body["description"] = ExpressionConverter.ConvertO(bodydescription);
                bodypropCount++;
            }

            var categoryObject = new JObject();
            var categoryObjectpropCount = 0;
            categoryObjectpropCount++;
            categoryObject["name"] = ExpressionConverter.ConvertO(bodycategorycategory);
            if (categoryObjectpropCount > 0)
            {
                body["category"] = categoryObject;
                bodypropCount++;
            }

            if (bodystartDate != null)
            {
                body["start_date"] = ExpressionConverter.ConvertO(bodystartDate);
                bodypropCount++;
            }

            if (bodystartTime != null)
            {
                body["start_time"] = ExpressionConverter.ConvertO(bodystartTime);
                bodypropCount++;
            }

            if (bodyendDate != null)
            {
                body["end_date"] = ExpressionConverter.ConvertO(bodyendDate);
                bodypropCount++;
            }

            if (bodyendTime != null)
            {
                body["end_time"] = ExpressionConverter.ConvertO(bodyendTime);
                bodypropCount++;
            }

            if (bodylookupID != null)
            {
                body["lookup_id"] = ExpressionConverter.ConvertO(bodylookupID);
                bodypropCount++;
            }

            if (bodycapacity != null)
            {
                body["capacity"] = ExpressionConverter.ConvertO(bodycapacity);
                bodypropCount++;
            }

            if (bodygoal != null)
            {
                body["goal"] = ExpressionConverter.ConvertO(bodygoal);
                bodypropCount++;
            }

            if (bodycampaignID != null)
            {
                body["campaign_id"] = ExpressionConverter.ConvertO(bodycampaignID);
                bodypropCount++;
            }

            if (bodyfundID != null)
            {
                body["fund_id"] = ExpressionConverter.ConvertO(bodyfundID);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<EventApiApiCollectionOfEventFee> ListEventFees(Expression<Func<string>> eventId)
        {
            var apiCallPath = String.Format("/event/v1/events/{0}/eventfees", ExpressionConverter.ConvertWithUrlEncoding(eventId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EventApiApiCollectionOfEventFee>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<EventApiCreatedEventFee> CreateEventFee(Expression<Func<string>> eventId, Expression<Func<string>> bodyname, Expression<Func<double>> bodyfeeAmount, Expression<Func<double>> bodycontributionAmount)
        {
            var apiCallPath = String.Format("/event/v1/events/{0}/eventfees", ExpressionConverter.ConvertWithUrlEncoding(eventId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            bodypropCount++;
            body["cost"] = ExpressionConverter.ConvertO(bodyfeeAmount);
            bodypropCount++;
            body["contribution_amount"] = ExpressionConverter.ConvertO(bodycontributionAmount);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<EventApiCreatedEventFee>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<EventApiApiCollectionOfEventParticipantOption> ListEventParticipantOptions(Expression<Func<string>> eventId)
        {
            var apiCallPath = String.Format("/event/v1/events/{0}/eventparticipantoptions", ExpressionConverter.ConvertWithUrlEncoding(eventId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EventApiApiCollectionOfEventParticipantOption>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<EventApiCreatedEventParticipantOption> CreateEventParticipantOption(Expression<Func<string>> eventId, Expression<Func<string>> bodyname, Expression<Func<bodyinputTypeInput>> bodyinputType, Expression<Func<bool>> bodyallowMultiSelect = null, Expression<Func<EventApiCreateParticipantOptionListOption[]>> bodylistOptions = null)
        {
            var apiCallPath = String.Format("/event/v1/events/{0}/eventparticipantoptions", ExpressionConverter.ConvertWithUrlEncoding(eventId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            bodypropCount++;
            body["input_type"] = ExpressionConverter.ConvertO(bodyinputType);
            if (bodyallowMultiSelect != null)
            {
                body["multi_select"] = ExpressionConverter.ConvertO(bodyallowMultiSelect);
                bodypropCount++;
            }

            if (bodylistOptions != null)
            {
                body["list_options"] = ExpressionConverter.ConvertO(bodylistOptions);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<EventApiCreatedEventParticipantOption>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<EventApiApiCollectionOfParticipantListEntry> ListEventParticipants(Expression<Func<string>> eventId, Expression<Func<rsvpStatusInput>> rsvpStatus = null, Expression<Func<invitationStatusInput>> invitationStatus = null, Expression<Func<string>> participationLevel = null, Expression<Func<bool>> attendedFilter = null, Expression<Func<bool>> feesPaidFilter = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<bool>> isConstituentFilter = null, Expression<Func<bool>> emailEligibleFilter = null, Expression<Func<bool>> phoneCallEligibleFilter = null, Expression<Func<string>> name = null, Expression<Func<string>> dateAdded = null, Expression<Func<string>> lastModified = null)
        {
            var apiCallPath = String.Format("/event/v1/events/{0}/participants", ExpressionConverter.ConvertWithUrlEncoding(eventId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (rsvpStatus != null)
                callPayload.Queries["rsvp_status"] = ExpressionConverter.Convert(rsvpStatus);
            if (invitationStatus != null)
                callPayload.Queries["invitation_status"] = ExpressionConverter.Convert(invitationStatus);
            if (participationLevel != null)
                callPayload.Queries["participation_level"] = ExpressionConverter.Convert(participationLevel);
            if (attendedFilter != null)
                callPayload.Queries["attended_filter"] = ExpressionConverter.Convert(attendedFilter);
            if (feesPaidFilter != null)
                callPayload.Queries["fees_paid_filter"] = ExpressionConverter.Convert(feesPaidFilter);
            callPayload.Queries["limit"] = Convert.ToString(500);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            if (isConstituentFilter != null)
                callPayload.Queries["is_constituent_filter"] = ExpressionConverter.Convert(isConstituentFilter);
            if (emailEligibleFilter != null)
                callPayload.Queries["email_eligible_filter"] = ExpressionConverter.Convert(emailEligibleFilter);
            if (phoneCallEligibleFilter != null)
                callPayload.Queries["phone_call_eligible_filter"] = ExpressionConverter.Convert(phoneCallEligibleFilter);
            if (name != null)
                callPayload.Queries["name"] = ExpressionConverter.Convert(name);
            if (dateAdded != null)
                callPayload.Queries["date_added"] = ExpressionConverter.Convert(dateAdded);
            if (lastModified != null)
                callPayload.Queries["last_modified"] = ExpressionConverter.Convert(lastModified);
            return new ApiConnectionAction<EventApiApiCollectionOfParticipantListEntry>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<EventApiCreatedParticipant> CreateParticipant(Expression<Func<string>> eventId, Expression<Func<string>> bodyconstituentID, Expression<Func<string>> bodyparticipationLevelparticipationLevel, Expression<Func<string>> bodyhostID = null, Expression<Func<bodyrSVPStatusInput>> bodyrSVPStatus = null, Expression<Func<bool>> bodyattended = null, Expression<Func<bodyinvitationStatusInput>> bodyinvitationStatus = null, Expression<Func<int>> bodyrSVPDateday = null, Expression<Func<int>> bodyrSVPDatemonth = null, Expression<Func<int>> bodyrSVPDateyear = null, Expression<Func<int>> bodyinvitationDateday = null, Expression<Func<int>> bodyinvitationDatemonth = null, Expression<Func<int>> bodyinvitationDateyear = null)
        {
            var apiCallPath = String.Format("/event/v1/events/{0}/participants", ExpressionConverter.ConvertWithUrlEncoding(eventId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["constituent_id"] = ExpressionConverter.ConvertO(bodyconstituentID);
            if (bodyhostID != null)
            {
                body["host_id"] = ExpressionConverter.ConvertO(bodyhostID);
                bodypropCount++;
            }

            if (bodyrSVPStatus != null)
            {
                body["rsvp_status"] = ExpressionConverter.ConvertO(bodyrSVPStatus);
                bodypropCount++;
            }

            if (bodyattended != null)
            {
                body["attended"] = ExpressionConverter.ConvertO(bodyattended);
                bodypropCount++;
            }

            if (bodyinvitationStatus != null)
            {
                body["invitation_status"] = ExpressionConverter.ConvertO(bodyinvitationStatus);
                bodypropCount++;
            }

            var rsvp_dateObject = new JObject();
            var rsvp_dateObjectpropCount = 0;
            if (bodyrSVPDateday != null)
            {
                rsvp_dateObject["d"] = ExpressionConverter.ConvertO(bodyrSVPDateday);
                rsvp_dateObjectpropCount++;
            }

            if (bodyrSVPDatemonth != null)
            {
                rsvp_dateObject["m"] = ExpressionConverter.ConvertO(bodyrSVPDatemonth);
                rsvp_dateObjectpropCount++;
            }

            if (bodyrSVPDateyear != null)
            {
                rsvp_dateObject["y"] = ExpressionConverter.ConvertO(bodyrSVPDateyear);
                rsvp_dateObjectpropCount++;
            }

            if (rsvp_dateObjectpropCount > 0)
            {
                body["rsvp_date"] = rsvp_dateObject;
                bodypropCount++;
            }

            var invitation_dateObject = new JObject();
            var invitation_dateObjectpropCount = 0;
            if (bodyinvitationDateday != null)
            {
                invitation_dateObject["d"] = ExpressionConverter.ConvertO(bodyinvitationDateday);
                invitation_dateObjectpropCount++;
            }

            if (bodyinvitationDatemonth != null)
            {
                invitation_dateObject["m"] = ExpressionConverter.ConvertO(bodyinvitationDatemonth);
                invitation_dateObjectpropCount++;
            }

            if (bodyinvitationDateyear != null)
            {
                invitation_dateObject["y"] = ExpressionConverter.ConvertO(bodyinvitationDateyear);
                invitation_dateObjectpropCount++;
            }

            if (invitation_dateObjectpropCount > 0)
            {
                body["invitation_date"] = invitation_dateObject;
                bodypropCount++;
            }

            var participation_levelObject = new JObject();
            var participation_levelObjectpropCount = 0;
            participation_levelObjectpropCount++;
            participation_levelObject["name"] = ExpressionConverter.ConvertO(bodyparticipationLevelparticipationLevel);
            if (participation_levelObjectpropCount > 0)
            {
                body["participation_level"] = participation_levelObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<EventApiCreatedParticipant>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction EditParticipantOption(Expression<Func<string>> optionId, Expression<Func<string>> bodyvalue)
        {
            var apiCallPath = String.Format("/event/v1/participantoptions/{0}", ExpressionConverter.ConvertWithUrlEncoding(optionId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["option_value"] = ExpressionConverter.ConvertO(bodyvalue);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<EventApiParticipant> GetParticipant(Expression<Func<string>> participantId)
        {
            var apiCallPath = String.Format("/event/v1/participants/{0}", ExpressionConverter.ConvertWithUrlEncoding(participantId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EventApiParticipant>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction EditParticipant(Expression<Func<string>> participantId, Expression<Func<string>> bodyparticipationLevelparticipationLevel, Expression<Func<string>> bodyconstituentID = null, Expression<Func<string>> bodyhostID = null, Expression<Func<bodyrSVPStatusInput>> bodyrSVPStatus = null, Expression<Func<bool>> bodyattended = null, Expression<Func<bodyinvitationStatusInput>> bodyinvitationStatus = null, Expression<Func<int>> bodyrSVPDateday = null, Expression<Func<int>> bodyrSVPDatemonth = null, Expression<Func<int>> bodyrSVPDateyear = null, Expression<Func<int>> bodyinvitationDateday = null, Expression<Func<int>> bodyinvitationDatemonth = null, Expression<Func<int>> bodyinvitationDateyear = null)
        {
            var apiCallPath = String.Format("/event/v1/participants/{0}", ExpressionConverter.ConvertWithUrlEncoding(participantId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyconstituentID != null)
            {
                body["constituent_id"] = ExpressionConverter.ConvertO(bodyconstituentID);
                bodypropCount++;
            }

            if (bodyhostID != null)
            {
                body["host_id"] = ExpressionConverter.ConvertO(bodyhostID);
                bodypropCount++;
            }

            if (bodyrSVPStatus != null)
            {
                body["rsvp_status"] = ExpressionConverter.ConvertO(bodyrSVPStatus);
                bodypropCount++;
            }

            if (bodyattended != null)
            {
                body["attended"] = ExpressionConverter.ConvertO(bodyattended);
                bodypropCount++;
            }

            if (bodyinvitationStatus != null)
            {
                body["invitation_status"] = ExpressionConverter.ConvertO(bodyinvitationStatus);
                bodypropCount++;
            }

            var rsvp_dateObject = new JObject();
            var rsvp_dateObjectpropCount = 0;
            if (bodyrSVPDateday != null)
            {
                rsvp_dateObject["d"] = ExpressionConverter.ConvertO(bodyrSVPDateday);
                rsvp_dateObjectpropCount++;
            }

            if (bodyrSVPDatemonth != null)
            {
                rsvp_dateObject["m"] = ExpressionConverter.ConvertO(bodyrSVPDatemonth);
                rsvp_dateObjectpropCount++;
            }

            if (bodyrSVPDateyear != null)
            {
                rsvp_dateObject["y"] = ExpressionConverter.ConvertO(bodyrSVPDateyear);
                rsvp_dateObjectpropCount++;
            }

            if (rsvp_dateObjectpropCount > 0)
            {
                body["rsvp_date"] = rsvp_dateObject;
                bodypropCount++;
            }

            var invitation_dateObject = new JObject();
            var invitation_dateObjectpropCount = 0;
            if (bodyinvitationDateday != null)
            {
                invitation_dateObject["d"] = ExpressionConverter.ConvertO(bodyinvitationDateday);
                invitation_dateObjectpropCount++;
            }

            if (bodyinvitationDatemonth != null)
            {
                invitation_dateObject["m"] = ExpressionConverter.ConvertO(bodyinvitationDatemonth);
                invitation_dateObjectpropCount++;
            }

            if (bodyinvitationDateyear != null)
            {
                invitation_dateObject["y"] = ExpressionConverter.ConvertO(bodyinvitationDateyear);
                invitation_dateObjectpropCount++;
            }

            if (invitation_dateObjectpropCount > 0)
            {
                body["invitation_date"] = invitation_dateObject;
                bodypropCount++;
            }

            var participation_levelObject = new JObject();
            var participation_levelObjectpropCount = 0;
            participation_levelObjectpropCount++;
            participation_levelObject["name"] = ExpressionConverter.ConvertO(bodyparticipationLevelparticipationLevel);
            if (participation_levelObjectpropCount > 0)
            {
                body["participation_level"] = participation_levelObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<EventApiApiCollectionOfParticipantDonation> ListParticipantDonations(Expression<Func<string>> participantId, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var apiCallPath = String.Format("/event/v1/participants/{0}/donations", ExpressionConverter.ConvertWithUrlEncoding(participantId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["limit"] = Convert.ToString(500);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<EventApiApiCollectionOfParticipantDonation>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<EventApiCreatedParticipantDonation> CreateParticipantDonation(Expression<Func<string>> participantId, Expression<Func<string>> bodygiftID)
        {
            var apiCallPath = String.Format("/event/v1/participants/{0}/donations", ExpressionConverter.ConvertWithUrlEncoding(participantId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["gift_id"] = ExpressionConverter.ConvertO(bodygiftID);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<EventApiCreatedParticipantDonation>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<EventApiApiCollectionOfParticipantFeePayment> ListParticipantFeePayments(Expression<Func<string>> participantId, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var apiCallPath = String.Format("/event/v1/participants/{0}/feepayments", ExpressionConverter.ConvertWithUrlEncoding(participantId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["limit"] = Convert.ToString(500);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<EventApiApiCollectionOfParticipantFeePayment>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<EventApiCreatedParticipantFeePayment> CreateParticipantFeePayment(Expression<Func<string>> participantId, Expression<Func<string>> bodygiftID, Expression<Func<double>> bodyappliedAmount)
        {
            var apiCallPath = String.Format("/event/v1/participants/{0}/feepayments", ExpressionConverter.ConvertWithUrlEncoding(participantId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["gift_id"] = ExpressionConverter.ConvertO(bodygiftID);
            bodypropCount++;
            body["applied_amount"] = ExpressionConverter.ConvertO(bodyappliedAmount);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<EventApiCreatedParticipantFeePayment>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<EventApiApiCollectionOfParticipantFee> ListParticipantFees(Expression<Func<string>> participantId, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var apiCallPath = String.Format("/event/v1/participants/{0}/fees", ExpressionConverter.ConvertWithUrlEncoding(participantId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["limit"] = Convert.ToString(500);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<EventApiApiCollectionOfParticipantFee>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<EventApiCreatedParticipantFee> CreateParticipantFee(Expression<Func<string>> participantId, Expression<Func<string>> bodyeventID, Expression<Func<string>> bodyfee, Expression<Func<int>> bodyquantity, Expression<Func<double>> bodyfeeAmount, Expression<Func<double>> bodycontributionAmount, Expression<Func<int>> bodydateday = null, Expression<Func<int>> bodydatemonth = null, Expression<Func<int>> bodydateyear = null)
        {
            var apiCallPath = String.Format("/event/v1/participants/{0}/fees", ExpressionConverter.ConvertWithUrlEncoding(participantId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["event_id"] = ExpressionConverter.ConvertO(bodyeventID);
            bodypropCount++;
            body["event_fee_id"] = ExpressionConverter.ConvertO(bodyfee);
            bodypropCount++;
            body["quantity"] = ExpressionConverter.ConvertO(bodyquantity);
            bodypropCount++;
            body["fee_amount"] = ExpressionConverter.ConvertO(bodyfeeAmount);
            bodypropCount++;
            body["contribution_amount"] = ExpressionConverter.ConvertO(bodycontributionAmount);
            var dateObject = new JObject();
            var dateObjectpropCount = 0;
            if (bodydateday != null)
            {
                dateObject["d"] = ExpressionConverter.ConvertO(bodydateday);
                dateObjectpropCount++;
            }

            if (bodydatemonth != null)
            {
                dateObject["m"] = ExpressionConverter.ConvertO(bodydatemonth);
                dateObjectpropCount++;
            }

            if (bodydateyear != null)
            {
                dateObject["y"] = ExpressionConverter.ConvertO(bodydateyear);
                dateObjectpropCount++;
            }

            if (dateObjectpropCount > 0)
            {
                body["date"] = dateObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<EventApiCreatedParticipantFee>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<EventApiApiCollectionOfParticipantOption> ListParticipantOptions(Expression<Func<string>> participantId)
        {
            var apiCallPath = String.Format("/event/v1/participants/{0}/participantoptions", ExpressionConverter.ConvertWithUrlEncoding(participantId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EventApiApiCollectionOfParticipantOption>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<EventApiCreatedParticipantOption> CreateParticipantOption(Expression<Func<string>> participantId, Expression<Func<string>> bodyeventID, Expression<Func<string>> bodyoption, Expression<Func<object>> bodyoptionValue)
        {
            var apiCallPath = String.Format("/event/v1/participants/{0}/participantoptions", ExpressionConverter.ConvertWithUrlEncoding(participantId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["event_id"] = ExpressionConverter.ConvertO(bodyeventID);
            bodypropCount++;
            body["event_participant_option_id"] = ExpressionConverter.ConvertO(bodyoption);
            bodypropCount++;
            body["option_value"] = ExpressionConverter.ConvertO(bodyoptionValue);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<EventApiCreatedParticipantOption>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<FundraisingApiAppealRead> GetAppeal(Expression<Func<string>> appealId)
        {
            var apiCallPath = String.Format("/fundraising/v1/appeals/{0}", ExpressionConverter.ConvertWithUrlEncoding(appealId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<FundraisingApiAppealRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<FundraisingApiApiCollectionOfAppealAttachmentRead> ListAppealAttachments(Expression<Func<string>> appealId)
        {
            var apiCallPath = String.Format("/fundraising/v1/appeals/{0}/attachments", ExpressionConverter.ConvertWithUrlEncoding(appealId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<FundraisingApiApiCollectionOfAppealAttachmentRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<FundraisingApiApiCollectionOfAppealCustomFieldRead> ListAppealCustomFields(Expression<Func<string>> appealId)
        {
            var apiCallPath = String.Format("/fundraising/v1/appeals/{0}/customfields", ExpressionConverter.ConvertWithUrlEncoding(appealId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<FundraisingApiApiCollectionOfAppealCustomFieldRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<FundraisingApiCreatedAppealAttachment> CreateAppealAttachment(Expression<Func<string>> bodyappealID, Expression<Func<bodytypeInput>> bodytype, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodyuRL = null, Expression<Func<string>> bodyfileName = null, Expression<Func<string>> bodyfileID = null, Expression<Func<string>> bodythumbnailID = null)
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

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<FundraisingApiCreatedAppealAttachment>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction EditAppealAttachment(Expression<Func<string>> attachmentId, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodyuRL = null)
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

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<FundraisingApiCampaignRead> GetCampaign(Expression<Func<string>> campaignId)
        {
            var apiCallPath = String.Format("/fundraising/v1/campaigns/{0}", ExpressionConverter.ConvertWithUrlEncoding(campaignId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<FundraisingApiCampaignRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<FundraisingApiApiCollectionOfCampaignAttachmentRead> ListCampaignAttachments(Expression<Func<string>> campaignId)
        {
            var apiCallPath = String.Format("/fundraising/v1/campaigns/{0}/attachments", ExpressionConverter.ConvertWithUrlEncoding(campaignId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<FundraisingApiApiCollectionOfCampaignAttachmentRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<FundraisingApiApiCollectionOfCampaignCustomFieldRead> ListCampaignCustomFields(Expression<Func<string>> campaignId)
        {
            var apiCallPath = String.Format("/fundraising/v1/campaigns/{0}/customfields", ExpressionConverter.ConvertWithUrlEncoding(campaignId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<FundraisingApiApiCollectionOfCampaignCustomFieldRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<FundraisingApiCreatedCampaignAttachment> CreateCampaignAttachment(Expression<Func<string>> bodycampaignID, Expression<Func<bodytypeInput>> bodytype, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodyuRL = null, Expression<Func<string>> bodyfileName = null, Expression<Func<string>> bodyfileID = null, Expression<Func<string>> bodythumbnailID = null)
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

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<FundraisingApiCreatedCampaignAttachment>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction EditCampaignAttachment(Expression<Func<string>> attachmentId, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodyuRL = null)
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

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<FundraisingApiCreatedFundraiserAssignment> CreateFundraiserAssignment(Expression<Func<string>> bodyfundraiserID, Expression<Func<string>> bodyconstituentID, Expression<Func<double>> bodyamountamount, Expression<Func<string>> bodytype = null, Expression<Func<string>> bodyassignmentStarts = null, Expression<Func<string>> bodyassignmentEnds = null, Expression<Func<string>> bodycampaignID = null, Expression<Func<string>> bodyfundID = null, Expression<Func<string>> bodyappealID = null)
        {
            var apiCallPath = "/fundraising/v1/fundraisers/assignments";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["fundraiser_id"] = ExpressionConverter.ConvertO(bodyfundraiserID);
            bodypropCount++;
            body["constituent_id"] = ExpressionConverter.ConvertO(bodyconstituentID);
            if (bodytype != null)
            {
                body["type"] = ExpressionConverter.ConvertO(bodytype);
                bodypropCount++;
            }

            if (bodyassignmentStarts != null)
            {
                body["start"] = ExpressionConverter.ConvertO(bodyassignmentStarts);
                bodypropCount++;
            }

            if (bodyassignmentEnds != null)
            {
                body["end"] = ExpressionConverter.ConvertO(bodyassignmentEnds);
                bodypropCount++;
            }

            var amountObject = new JObject();
            var amountObjectpropCount = 0;
            amountObjectpropCount++;
            amountObject["value"] = ExpressionConverter.ConvertO(bodyamountamount);
            if (amountObjectpropCount > 0)
            {
                body["amount"] = amountObject;
                bodypropCount++;
            }

            if (bodycampaignID != null)
            {
                body["campaign_id"] = ExpressionConverter.ConvertO(bodycampaignID);
                bodypropCount++;
            }

            if (bodyfundID != null)
            {
                body["fund_id"] = ExpressionConverter.ConvertO(bodyfundID);
                bodypropCount++;
            }

            if (bodyappealID != null)
            {
                body["appeal_id"] = ExpressionConverter.ConvertO(bodyappealID);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<FundraisingApiCreatedFundraiserAssignment>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<FundraisingApiApiCollectionOfFundraiserAssignmentRead> ListFundraiserAssignments(Expression<Func<string>> fundraiserId, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var apiCallPath = String.Format("/fundraising/v1/fundraisers/{0}/assignments", ExpressionConverter.ConvertWithUrlEncoding(fundraiserId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<FundraisingApiApiCollectionOfFundraiserAssignmentRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<FundraisingApiFundRead> GetFund(Expression<Func<string>> fundId)
        {
            var apiCallPath = String.Format("/fundraising/v1/funds/{0}", ExpressionConverter.ConvertWithUrlEncoding(fundId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<FundraisingApiFundRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<FundraisingApiApiCollectionOfFundAttachmentRead> ListFundAttachments(Expression<Func<string>> fundId)
        {
            var apiCallPath = String.Format("/fundraising/v1/funds/{0}/attachments", ExpressionConverter.ConvertWithUrlEncoding(fundId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<FundraisingApiApiCollectionOfFundAttachmentRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<FundraisingApiApiCollectionOfFundCustomFieldRead> ListFundCustomFields(Expression<Func<string>> fundId)
        {
            var apiCallPath = String.Format("/fundraising/v1/funds/{0}/customfields", ExpressionConverter.ConvertWithUrlEncoding(fundId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<FundraisingApiApiCollectionOfFundCustomFieldRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<FundraisingApiCreatedFundAttachment> CreateFundAttachment(Expression<Func<string>> bodyfundID, Expression<Func<bodytypeInput>> bodytype, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodyuRL = null, Expression<Func<string>> bodyfileName = null, Expression<Func<string>> bodyfileID = null, Expression<Func<string>> bodythumbnailID = null)
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

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<FundraisingApiCreatedFundAttachment>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction EditFundAttachment(Expression<Func<string>> attachmentId, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodyuRL = null)
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

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<FundraisingApiPackageRead> GetPackage(Expression<Func<string>> packageId)
        {
            var apiCallPath = String.Format("/fundraising/v1/packages/{0}", ExpressionConverter.ConvertWithUrlEncoding(packageId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<FundraisingApiPackageRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction EditGiftAcknowledgement(Expression<Func<string>> acknowledgementId, Expression<Func<bodystatusInput>> bodystatus = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodyletter = null)
        {
            var apiCallPath = String.Format("/gift/v1/giftacknowledgements/{0}", ExpressionConverter.ConvertWithUrlEncoding(acknowledgementId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodystatus != null)
            {
                body["status"] = ExpressionConverter.ConvertO(bodystatus);
                bodypropCount++;
            }

            if (bodydate != null)
            {
                body["date"] = ExpressionConverter.ConvertO(bodydate);
                bodypropCount++;
            }

            if (bodyletter != null)
            {
                body["letter"] = ExpressionConverter.ConvertO(bodyletter);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction EditGiftReceipt(Expression<Func<string>> receiptId, Expression<Func<bodystatusInput>> bodystatus = null, Expression<Func<double>> bodyamountvalue = null, Expression<Func<string>> bodydate = null, Expression<Func<int>> bodynumber = null)
        {
            var apiCallPath = String.Format("/gift/v1/giftreceipts/{0}", ExpressionConverter.ConvertWithUrlEncoding(receiptId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodystatus != null)
            {
                body["status"] = ExpressionConverter.ConvertO(bodystatus);
                bodypropCount++;
            }

            var amountObject = new JObject();
            var amountObjectpropCount = 0;
            if (bodyamountvalue != null)
            {
                amountObject["value"] = ExpressionConverter.ConvertO(bodyamountvalue);
                amountObjectpropCount++;
            }

            if (amountObjectpropCount > 0)
            {
                body["amount"] = amountObject;
                bodypropCount++;
            }

            if (bodydate != null)
            {
                body["date"] = ExpressionConverter.ConvertO(bodydate);
                bodypropCount++;
            }

            if (bodynumber != null)
            {
                body["number"] = ExpressionConverter.ConvertO(bodynumber);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<GiftApiApiCollectionOfGiftRead> ListGifts(Expression<Func<string>> listId = null, Expression<Func<string>> giftType = null, Expression<Func<string>> constituentId = null, Expression<Func<string>> campaignId = null, Expression<Func<string>> fundId = null, Expression<Func<string>> appealId = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<string>> startGiftDate = null, Expression<Func<string>> endGiftDate = null, Expression<Func<double>> startGiftAmount = null, Expression<Func<double>> endGiftAmount = null, Expression<Func<string>> postStatus = null, Expression<Func<string>> receiptStatus = null, Expression<Func<string>> acknowledgementStatus = null, Expression<Func<string>> dateAdded = null, Expression<Func<string>> lastModified = null)
        {
            var apiCallPath = "/gift/v1/gifts";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (listId != null)
                callPayload.Queries["list_id"] = ExpressionConverter.Convert(listId);
            if (giftType != null)
                callPayload.Queries["gift_type"] = ExpressionConverter.Convert(giftType);
            if (constituentId != null)
                callPayload.Queries["constituent_id"] = ExpressionConverter.Convert(constituentId);
            if (campaignId != null)
                callPayload.Queries["campaign_id"] = ExpressionConverter.Convert(campaignId);
            if (fundId != null)
                callPayload.Queries["fund_id"] = ExpressionConverter.Convert(fundId);
            if (appealId != null)
                callPayload.Queries["appeal_id"] = ExpressionConverter.Convert(appealId);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            if (startGiftDate != null)
                callPayload.Queries["start_gift_date"] = ExpressionConverter.Convert(startGiftDate);
            if (endGiftDate != null)
                callPayload.Queries["end_gift_date"] = ExpressionConverter.Convert(endGiftDate);
            if (startGiftAmount != null)
                callPayload.Queries["start_gift_amount"] = ExpressionConverter.Convert(startGiftAmount);
            if (endGiftAmount != null)
                callPayload.Queries["end_gift_amount"] = ExpressionConverter.Convert(endGiftAmount);
            if (postStatus != null)
                callPayload.Queries["post_status"] = ExpressionConverter.Convert(postStatus);
            if (receiptStatus != null)
                callPayload.Queries["receipt_status"] = ExpressionConverter.Convert(receiptStatus);
            if (acknowledgementStatus != null)
                callPayload.Queries["acknowledgement_status"] = ExpressionConverter.Convert(acknowledgementStatus);
            if (dateAdded != null)
                callPayload.Queries["date_added"] = ExpressionConverter.Convert(dateAdded);
            if (lastModified != null)
                callPayload.Queries["last_modified"] = ExpressionConverter.Convert(lastModified);
            return new ApiConnectionAction<GiftApiApiCollectionOfGiftRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<GiftApiGiftRead> GetGift(Expression<Func<string>> giftId)
        {
            var apiCallPath = String.Format("/gift/v1/gifts/{0}", ExpressionConverter.ConvertWithUrlEncoding(giftId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GiftApiGiftRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<GiftApiApiCollectionOfGiftAttachmentRead> ListGiftAttachments(Expression<Func<string>> giftId)
        {
            var apiCallPath = String.Format("/gift/v1/gifts/{0}/attachments", ExpressionConverter.ConvertWithUrlEncoding(giftId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GiftApiApiCollectionOfGiftAttachmentRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<GiftApiApiCollectionOfGiftCustomFieldRead> ListGiftCustomFields(Expression<Func<string>> giftId)
        {
            var apiCallPath = String.Format("/gift/v1/gifts/{0}/customfields", ExpressionConverter.ConvertWithUrlEncoding(giftId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GiftApiApiCollectionOfGiftCustomFieldRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<GiftApiCreatedGiftAttachment> CreateGiftAttachment(Expression<Func<string>> bodygiftID, Expression<Func<bodytypeInput>> bodytype, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodyuRL = null, Expression<Func<string>> bodyfileName = null, Expression<Func<string>> bodyfileID = null, Expression<Func<string>> bodythumbnailID = null)
        {
            var apiCallPath = "/gift/v1/gifts/attachments";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["parent_id"] = ExpressionConverter.ConvertO(bodygiftID);
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

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<GiftApiCreatedGiftAttachment>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction EditGiftAttachment(Expression<Func<string>> attachmentId, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodyuRL = null)
        {
            var apiCallPath = String.Format("/gift/v1/gifts/attachments/{0}", ExpressionConverter.ConvertWithUrlEncoding(attachmentId, 1));
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

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<GiftApiCreatedGiftCustomField> CreateGiftCustomField(Expression<Func<string>> bodygiftID, Expression<Func<string>> bodycategory, Expression<Func<object>> bodyvalue = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodycomment = null)
        {
            var apiCallPath = "/gift/v1/gifts/customfields";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["parent_id"] = ExpressionConverter.ConvertO(bodygiftID);
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

            return new ApiConnectionAction<GiftApiCreatedGiftCustomField>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction EditGiftCustomField(Expression<Func<string>> customFieldId, Expression<Func<string>> bodycategory = null, Expression<Func<object>> bodyvalue = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodycomment = null)
        {
            var apiCallPath = String.Format("/gift/v1/gifts/customfields/{0}", ExpressionConverter.ConvertWithUrlEncoding(customFieldId, 1));
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<GiftBatchApiApiCollectionOfGiftBatch> ListGiftBatches(Expression<Func<string>> batchNumber = null, Expression<Func<bool>> approved = null, Expression<Func<bool>> hasExceptions = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<string>> searchText = null, Expression<Func<string>> createdBy = null)
        {
            var apiCallPath = "/gift-batch/v1/giftbatches";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (batchNumber != null)
                callPayload.Queries["batch_number"] = ExpressionConverter.Convert(batchNumber);
            if (approved != null)
                callPayload.Queries["approved"] = ExpressionConverter.Convert(approved);
            if (hasExceptions != null)
                callPayload.Queries["has_exceptions"] = ExpressionConverter.Convert(hasExceptions);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            if (searchText != null)
                callPayload.Queries["search_text"] = ExpressionConverter.Convert(searchText);
            if (createdBy != null)
                callPayload.Queries["created_by"] = ExpressionConverter.Convert(createdBy);
            return new ApiConnectionAction<GiftBatchApiApiCollectionOfGiftBatch>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<GiftBatchApiCreatedBatch> CreateGiftBatch(Expression<Func<string>> bodydescription = null, Expression<Func<int>> bodyexpectedNumber = null, Expression<Func<double>> bodyexpectedTotal = null, Expression<Func<string>> bodybatchNumber = null)
        {
            var apiCallPath = "/gift-batch/v1/giftbatches";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodydescription != null)
            {
                body["batch_description"] = ExpressionConverter.ConvertO(bodydescription);
                bodypropCount++;
            }

            if (bodyexpectedNumber != null)
            {
                body["expected_number"] = ExpressionConverter.ConvertO(bodyexpectedNumber);
                bodypropCount++;
            }

            if (bodyexpectedTotal != null)
            {
                body["expected_batch_total"] = ExpressionConverter.ConvertO(bodyexpectedTotal);
                bodypropCount++;
            }

            if (bodybatchNumber != null)
            {
                body["batch_number"] = ExpressionConverter.ConvertO(bodybatchNumber);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<GiftBatchApiCreatedBatch>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction AppendIDsToList(Expression<Func<bodylistTypeInput>> bodylistType, Expression<Func<string>> bodylist, Expression<Func<string[]>> bodyiDS)
        {
            var apiCallPath = "/list/v1/appendidstolist";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["list_type"] = ExpressionConverter.ConvertO(bodylistType);
            bodypropCount++;
            body["list_id"] = ExpressionConverter.ConvertO(bodylist);
            bodypropCount++;
            body["ids"] = ExpressionConverter.ConvertO(bodyiDS);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ListApiCreatedList> CreateListFromIDs(Expression<Func<string>> bodyname, Expression<Func<string>> bodydescription, Expression<Func<bodylistTypeInput>> bodylistType, Expression<Func<bodypermissionsInput>> bodypermissions, Expression<Func<string[]>> bodyiDS)
        {
            var apiCallPath = "/list/v1/createlistfromids";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            bodypropCount++;
            body["description"] = ExpressionConverter.ConvertO(bodydescription);
            bodypropCount++;
            body["list_type"] = ExpressionConverter.ConvertO(bodylistType);
            bodypropCount++;
            body["list_permissions"] = ExpressionConverter.ConvertO(bodypermissions);
            bodypropCount++;
            body["ids"] = ExpressionConverter.ConvertO(bodyiDS);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ListApiCreatedList>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<OpportunityApiApiCollectionOfOpportunityRead> ListOpportunities(Expression<Func<string>> listId = null, Expression<Func<string>> constituentId = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<bool>> includeInactive = null, Expression<Func<string>> dateAdded = null, Expression<Func<string>> lastModified = null)
        {
            var apiCallPath = "/opportunity/v1/opportunities";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (listId != null)
                callPayload.Queries["list_id"] = ExpressionConverter.Convert(listId);
            if (constituentId != null)
                callPayload.Queries["constituent_id"] = ExpressionConverter.Convert(constituentId);
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
            return new ApiConnectionAction<OpportunityApiApiCollectionOfOpportunityRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<OpportunityApiCreatedOpportunity> CreateOpportunity(Expression<Func<string>> bodyconstituentID, Expression<Func<string>> bodypurpose, Expression<Func<string>> bodyname, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodydeadline = null, Expression<Func<string>> bodyaskDate = null, Expression<Func<double>> bodyaskAmountvalue = null, Expression<Func<string>> bodyexpectedDate = null, Expression<Func<double>> bodyexpectedAmountvalue = null, Expression<Func<string>> bodyfundedDate = null, Expression<Func<double>> bodyfundedAmountvalue = null, Expression<Func<string>> bodycampaignID = null, Expression<Func<string>> bodyfundID = null, Expression<Func<OpportunityApiFundraiser[]>> bodyfundraiserS = null, Expression<Func<bool>> bodyinactive = null)
        {
            var apiCallPath = "/opportunity/v1/opportunities";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["constituent_id"] = ExpressionConverter.ConvertO(bodyconstituentID);
            bodypropCount++;
            body["purpose"] = ExpressionConverter.ConvertO(bodypurpose);
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            if (bodystatus != null)
            {
                body["status"] = ExpressionConverter.ConvertO(bodystatus);
                bodypropCount++;
            }

            if (bodydeadline != null)
            {
                body["deadline"] = ExpressionConverter.ConvertO(bodydeadline);
                bodypropCount++;
            }

            if (bodyaskDate != null)
            {
                body["ask_date"] = ExpressionConverter.ConvertO(bodyaskDate);
                bodypropCount++;
            }

            var ask_amountObject = new JObject();
            var ask_amountObjectpropCount = 0;
            if (bodyaskAmountvalue != null)
            {
                ask_amountObject["value"] = ExpressionConverter.ConvertO(bodyaskAmountvalue);
                ask_amountObjectpropCount++;
            }

            if (ask_amountObjectpropCount > 0)
            {
                body["ask_amount"] = ask_amountObject;
                bodypropCount++;
            }

            if (bodyexpectedDate != null)
            {
                body["expected_date"] = ExpressionConverter.ConvertO(bodyexpectedDate);
                bodypropCount++;
            }

            var expected_amountObject = new JObject();
            var expected_amountObjectpropCount = 0;
            if (bodyexpectedAmountvalue != null)
            {
                expected_amountObject["value"] = ExpressionConverter.ConvertO(bodyexpectedAmountvalue);
                expected_amountObjectpropCount++;
            }

            if (expected_amountObjectpropCount > 0)
            {
                body["expected_amount"] = expected_amountObject;
                bodypropCount++;
            }

            if (bodyfundedDate != null)
            {
                body["funded_date"] = ExpressionConverter.ConvertO(bodyfundedDate);
                bodypropCount++;
            }

            var funded_amountObject = new JObject();
            var funded_amountObjectpropCount = 0;
            if (bodyfundedAmountvalue != null)
            {
                funded_amountObject["value"] = ExpressionConverter.ConvertO(bodyfundedAmountvalue);
                funded_amountObjectpropCount++;
            }

            if (funded_amountObjectpropCount > 0)
            {
                body["funded_amount"] = funded_amountObject;
                bodypropCount++;
            }

            if (bodycampaignID != null)
            {
                body["campaign_id"] = ExpressionConverter.ConvertO(bodycampaignID);
                bodypropCount++;
            }

            if (bodyfundID != null)
            {
                body["fund_id"] = ExpressionConverter.ConvertO(bodyfundID);
                bodypropCount++;
            }

            if (bodyfundraiserS != null)
            {
                body["fundraisers"] = ExpressionConverter.ConvertO(bodyfundraiserS);
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

            return new ApiConnectionAction<OpportunityApiCreatedOpportunity>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<OpportunityApiOpportunityRead> GetOpportunity(Expression<Func<string>> opportunityId)
        {
            var apiCallPath = String.Format("/opportunity/v1/opportunities/{0}", ExpressionConverter.ConvertWithUrlEncoding(opportunityId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<OpportunityApiOpportunityRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction EditOpportunity(Expression<Func<string>> opportunityId, Expression<Func<string>> bodypurpose = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodydeadline = null, Expression<Func<string>> bodyaskDate = null, Expression<Func<double>> bodyaskAmountvalue = null, Expression<Func<string>> bodyexpectedDate = null, Expression<Func<double>> bodyexpectedAmountvalue = null, Expression<Func<string>> bodyfundedDate = null, Expression<Func<double>> bodyfundedAmountvalue = null, Expression<Func<string>> bodycampaignID = null, Expression<Func<string>> bodyfundID = null, Expression<Func<OpportunityApiFundraiser[]>> bodyfundraiserS = null, Expression<Func<bool>> bodyinactive = null)
        {
            var apiCallPath = String.Format("/opportunity/v1/opportunities/{0}", ExpressionConverter.ConvertWithUrlEncoding(opportunityId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodypurpose != null)
            {
                body["purpose"] = ExpressionConverter.ConvertO(bodypurpose);
                bodypropCount++;
            }

            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["status"] = ExpressionConverter.ConvertO(bodystatus);
                bodypropCount++;
            }

            if (bodydeadline != null)
            {
                body["deadline"] = ExpressionConverter.ConvertO(bodydeadline);
                bodypropCount++;
            }

            if (bodyaskDate != null)
            {
                body["ask_date"] = ExpressionConverter.ConvertO(bodyaskDate);
                bodypropCount++;
            }

            var ask_amountObject = new JObject();
            var ask_amountObjectpropCount = 0;
            if (bodyaskAmountvalue != null)
            {
                ask_amountObject["value"] = ExpressionConverter.ConvertO(bodyaskAmountvalue);
                ask_amountObjectpropCount++;
            }

            if (ask_amountObjectpropCount > 0)
            {
                body["ask_amount"] = ask_amountObject;
                bodypropCount++;
            }

            if (bodyexpectedDate != null)
            {
                body["expected_date"] = ExpressionConverter.ConvertO(bodyexpectedDate);
                bodypropCount++;
            }

            var expected_amountObject = new JObject();
            var expected_amountObjectpropCount = 0;
            if (bodyexpectedAmountvalue != null)
            {
                expected_amountObject["value"] = ExpressionConverter.ConvertO(bodyexpectedAmountvalue);
                expected_amountObjectpropCount++;
            }

            if (expected_amountObjectpropCount > 0)
            {
                body["expected_amount"] = expected_amountObject;
                bodypropCount++;
            }

            if (bodyfundedDate != null)
            {
                body["funded_date"] = ExpressionConverter.ConvertO(bodyfundedDate);
                bodypropCount++;
            }

            var funded_amountObject = new JObject();
            var funded_amountObjectpropCount = 0;
            if (bodyfundedAmountvalue != null)
            {
                funded_amountObject["value"] = ExpressionConverter.ConvertO(bodyfundedAmountvalue);
                funded_amountObjectpropCount++;
            }

            if (funded_amountObjectpropCount > 0)
            {
                body["funded_amount"] = funded_amountObject;
                bodypropCount++;
            }

            if (bodycampaignID != null)
            {
                body["campaign_id"] = ExpressionConverter.ConvertO(bodycampaignID);
                bodypropCount++;
            }

            if (bodyfundID != null)
            {
                body["fund_id"] = ExpressionConverter.ConvertO(bodyfundID);
                bodypropCount++;
            }

            if (bodyfundraiserS != null)
            {
                body["fundraisers"] = ExpressionConverter.ConvertO(bodyfundraiserS);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<OpportunityApiApiCollectionOfOpportunityAttachmentRead> ListOpportunityAttachments(Expression<Func<string>> opportunityId)
        {
            var apiCallPath = String.Format("/opportunity/v1/opportunities/{0}/attachments", ExpressionConverter.ConvertWithUrlEncoding(opportunityId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<OpportunityApiApiCollectionOfOpportunityAttachmentRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<OpportunityApiApiCollectionOfOpportunityCustomFieldRead> ListOpportunityCustomFields(Expression<Func<string>> opportunityId)
        {
            var apiCallPath = String.Format("/opportunity/v1/opportunities/{0}/customfields", ExpressionConverter.ConvertWithUrlEncoding(opportunityId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<OpportunityApiApiCollectionOfOpportunityCustomFieldRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<OpportunityApiCreatedOpportunityAttachment> CreateOpportunityAttachment(Expression<Func<string>> bodyopportunityID, Expression<Func<bodytypeInput>> bodytype, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodyuRL = null, Expression<Func<string>> bodyfileName = null, Expression<Func<string>> bodyfileID = null, Expression<Func<string>> bodythumbnailID = null)
        {
            var apiCallPath = "/opportunity/v1/opportunities/attachments";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["parent_id"] = ExpressionConverter.ConvertO(bodyopportunityID);
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

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<OpportunityApiCreatedOpportunityAttachment>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction EditOpportunityAttachment(Expression<Func<string>> attachmentId, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodyuRL = null)
        {
            var apiCallPath = String.Format("/opportunity/v1/opportunities/attachments/{0}", ExpressionConverter.ConvertWithUrlEncoding(attachmentId, 1));
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

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<OpportunityApiCreatedOpportunityCustomField> CreateOpportunityCustomField(Expression<Func<string>> bodyopportunityID, Expression<Func<string>> bodycategory, Expression<Func<object>> bodyvalue = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodycomment = null)
        {
            var apiCallPath = "/opportunity/v1/opportunities/customfields";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["parent_id"] = ExpressionConverter.ConvertO(bodyopportunityID);
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

            return new ApiConnectionAction<OpportunityApiCreatedOpportunityCustomField>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction EditOpportunityCustomField(Expression<Func<string>> customFieldId, Expression<Func<string>> bodycategory = null, Expression<Func<object>> bodyvalue = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodycomment = null)
        {
            var apiCallPath = String.Format("/opportunity/v1/opportunities/customfields/{0}", ExpressionConverter.ConvertWithUrlEncoding(customFieldId, 1));
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
    }

    public class BlackbaudraisersedgeTriggers([ConnectionName] string connectionId)
    {
    }

    public class CommPrefApiCreatedConstituentConsent
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public enum bodyresponseInput
    {
        OptIn,
        OptOut,
        NoResponse
    }

    public class CommPrefApiConstituentConsentReadCollection
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public CommPrefApiConstituentConsentRead[] Value { get; set; }
    }

    public class CommPrefApiConstituentConsentRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("channel")]
        public string Channel { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("constituent_consent_response")]
        public CommPrefApiConstituentConsentReadResponseType Response { get; set; }

        [JsonProperty("consent_date")]
        public string Date { get; set; }

        [JsonProperty("consent_statement")]
        public string ConsentStatement { get; set; }

        [JsonProperty("privacy_notice")]
        public string PrivacyNotice { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("user_name")]
        public string AddedBy { get; set; }
    }

    public enum CommPrefApiConstituentConsentReadResponseType
    {
        OptIn,
        OptOut,
        NoResponse
    }

    public class CommPrefApiConstituentSolicitCodeReadCollection
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public CommPrefApiConstituentSolicitCodeRead[] Value { get; set; }
    }

    public class CommPrefApiConstituentSolicitCodeRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("solicit_code")]
        public string SolicitCode { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }
    }

    public class CommPrefApiCreatedConstituentSolicitCode
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class ConstituentApiApiCollectionOfActionRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiActionRead[] Value { get; set; }
    }

    public class ConstituentApiActionRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentID { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("completed")]
        public bool Completed { get; set; }

        [JsonProperty("completed_date")]
        public string CompletedOn { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("description")]
        public string Note { get; set; }

        [JsonProperty("direction")]
        public ConstituentApiActionReadDirectionType Direction { get; set; }

        [JsonProperty("fundraisers")]
        public string[] FundraiserS { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("opportunity_id")]
        public string OpportunityID { get; set; }

        [JsonProperty("outcome")]
        public ConstituentApiActionReadOutcomeType Outcome { get; set; }

        [JsonProperty("priority")]
        public ConstituentApiActionReadPriorityType Priority { get; set; }

        [JsonProperty("start_time")]
        public string StartTime { get; set; }

        [JsonProperty("end_time")]
        public string EndTime { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("status_code")]
        public string StatusCode { get; set; }

        [JsonProperty("computed_status")]
        public ConstituentApiActionReadComputedStatusType ComputedStatus { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public enum ConstituentApiActionReadDirectionType
    {
        Inbound,
        Outbound
    }

    public enum ConstituentApiActionReadOutcomeType
    {
        Successful,
        Unsuccessful
    }

    public enum ConstituentApiActionReadPriorityType
    {
        Normal,
        High,
        Low
    }

    public enum ConstituentApiActionReadComputedStatusType
    {
        Open,
        Completed,
        PastDue
    }

    public class ConstituentApiCreatedAction
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public enum bodycategoryInput
    {
        [EnumMember(Value = "Phone Call")]
        PhoneCall,
        Meeting,
        Mailing,
        Email,
        [EnumMember(Value = "Task/Other")]
        TaskOther
    }

    public enum bodydirectionInput
    {
        Inbound,
        Outbound
    }

    public enum bodyoutcomeInput
    {
        Successful,
        Unsuccessful
    }

    public enum bodypriorityInput
    {
        Normal,
        High,
        Low
    }

    public class ConstituentApiApiCollectionOfActionAttachmentRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiActionAttachmentRead[] Value { get; set; }
    }

    public class ConstituentApiActionAttachmentRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("parent_id")]
        public string ActionID { get; set; }

        [JsonProperty("type")]
        public ConstituentApiActionAttachmentReadTypeType Type { get; set; }

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
    }

    public enum ConstituentApiActionAttachmentReadTypeType
    {
        Link,
        Physical
    }

    public class ConstituentApiApiCollectionOfActionCustomFieldRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiActionCustomFieldRead[] Value { get; set; }
    }

    public class ConstituentApiActionCustomFieldRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("parent_id")]
        public string ActionID { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("type")]
        public ConstituentApiActionCustomFieldReadTypeType Type { get; set; }

        [JsonProperty("value")]
        public JToken Value { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public enum ConstituentApiActionCustomFieldReadTypeType
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

    public class ConstituentApiCreatedActionAttachment
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public enum bodytypeInput
    {
        Link,
        Physical
    }

    public class ConstituentApiCreatedActionCustomField
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class ConstituentApiCreatedConstituentAddress
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class ConstituentApiCreatedConstituentAlias
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class ConstituentApiCreatedConstituentCode
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class ConstituentApiApiCollectionOfConstituentRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiConstituentRead[] Value { get; set; }
    }

    public class ConstituentApiConstituentRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("type")]
        public ConstituentApiConstituentReadTypeType Type { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("first")]
        public string FirstName { get; set; }

        [JsonProperty("last")]
        public string LastName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("preferred_name")]
        public string PreferredName { get; set; }

        [JsonProperty("suffix")]
        public string Suffix { get; set; }

        [JsonProperty("lookup_id")]
        public string LookupID { get; set; }

        [JsonProperty("email")]
        public ConstituentApiConstituentReadPrimaryEmailType PrimaryEmail { get; set; }

        [JsonProperty("phone")]
        public ConstituentApiConstituentReadPrimaryPhoneType PrimaryPhone { get; set; }

        [JsonProperty("online_presence")]
        public ConstituentApiConstituentReadPrimaryOnlinePresenceType PrimaryOnlinePresence { get; set; }

        [JsonProperty("address")]
        public ConstituentApiConstituentReadPreferredAddressType PreferredAddress { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("middle")]
        public string MiddleName { get; set; }

        [JsonProperty("former_name")]
        public string FormerName { get; set; }

        [JsonProperty("title_2")]
        public string Title2 { get; set; }

        [JsonProperty("suffix_2")]
        public string Suffix2 { get; set; }

        [JsonProperty("marital_status")]
        public string MaritalStaus { get; set; }

        [JsonProperty("gives_anonymously")]
        public bool GivesAnonymously { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("birthdate")]
        public ConstituentApiConstituentReadBirthdateType Birthdate { get; set; }

        [JsonProperty("birthplace")]
        public string Birthplace { get; set; }

        [JsonProperty("ethnicity")]
        public string Ethnicity { get; set; }

        [JsonProperty("income")]
        public string Income { get; set; }

        [JsonProperty("religion")]
        public string Religion { get; set; }

        [JsonProperty("industry")]
        public string Industry { get; set; }

        [JsonProperty("num_employees")]
        public int NumberOfEmployees { get; set; }

        [JsonProperty("matches_gifts")]
        public bool MatchesGifts { get; set; }

        [JsonProperty("matching_gift_factor")]
        public double MatchingGiftFactor { get; set; }

        [JsonProperty("matching_gift_per_gift_min")]
        public ConstituentApiConstituentReadMatchingGiftPerGiftMinType MatchingGiftPerGiftMin { get; set; }

        [JsonProperty("matching_gift_per_gift_max")]
        public ConstituentApiConstituentReadMatchingGiftPerGiftMaxType MatchingGiftPerGiftMax { get; set; }

        [JsonProperty("matching_gift_total_min")]
        public ConstituentApiConstituentReadMatchingGiftTotalMinType MatchingGiftTotalMin { get; set; }

        [JsonProperty("matching_gift_total_max")]
        public ConstituentApiConstituentReadMatchingGiftTotalMaxType MatchingGiftTotalMax { get; set; }

        [JsonProperty("matching_gift_notes")]
        public string MatchingGiftNotes { get; set; }

        [JsonProperty("age")]
        public int Age { get; set; }

        [JsonProperty("deceased")]
        public bool Deceased { get; set; }

        [JsonProperty("deceased_date")]
        public ConstituentApiConstituentReadDeceasedDateType DeceasedDate { get; set; }

        [JsonProperty("fundraiser_status")]
        public ConstituentApiConstituentReadFundraiserStatusType FundraiserStatus { get; set; }

        [JsonProperty("spouse")]
        public ConstituentApiConstituentReadSpouseType Spouse { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public enum ConstituentApiConstituentReadTypeType
    {
        Individual,
        Organization
    }

    public class ConstituentApiConstituentReadPrimaryEmailType
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("do_not_email")]
        public bool DoNotEmail { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class ConstituentApiConstituentReadPrimaryPhoneType
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("do_not_call")]
        public bool DoNotCall { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class ConstituentApiConstituentReadPrimaryOnlinePresenceType
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("address")]
        public string Link { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class ConstituentApiConstituentReadPreferredAddressType
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("address_lines")]
        public string Lines { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("suburb")]
        public string Suburb { get; set; }

        [JsonProperty("county")]
        public string County { get; set; }

        [JsonProperty("formatted_address")]
        public string Formatted { get; set; }

        [JsonProperty("start")]
        public string ValidFrom { get; set; }

        [JsonProperty("end")]
        public string ValidTo { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("do_not_mail")]
        public bool DoNotMail { get; set; }

        [JsonProperty("seasonal_start")]
        public ConstituentApiConstituentReadPreferredAddressTypeSeasonalStartType SeasonalStart { get; set; }

        [JsonProperty("seasonal_end")]
        public ConstituentApiConstituentReadPreferredAddressTypeSeasonalEndType SeasonalEnd { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class ConstituentApiConstituentReadPreferredAddressTypeSeasonalStartType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class ConstituentApiConstituentReadPreferredAddressTypeSeasonalEndType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class ConstituentApiConstituentReadBirthdateType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class ConstituentApiConstituentReadMatchingGiftPerGiftMinType
    {
        [JsonProperty("value")]
        public double MinMatchPerGift { get; set; }
    }

    public class ConstituentApiConstituentReadMatchingGiftPerGiftMaxType
    {
        [JsonProperty("value")]
        public double MaxMatchPerGift { get; set; }
    }

    public class ConstituentApiConstituentReadMatchingGiftTotalMinType
    {
        [JsonProperty("value")]
        public double MinMatchPerConstit { get; set; }
    }

    public class ConstituentApiConstituentReadMatchingGiftTotalMaxType
    {
        [JsonProperty("value")]
        public double MaxMatchPerConstit { get; set; }
    }

    public class ConstituentApiConstituentReadDeceasedDateType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public enum ConstituentApiConstituentReadFundraiserStatusType
    {
        Active,
        Inactive,
        None
    }

    public class ConstituentApiConstituentReadSpouseType
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("first")]
        public string FirstName { get; set; }

        [JsonProperty("last")]
        public string LastName { get; set; }

        [JsonProperty("is_head_of_household")]
        public bool IsHeadOfHousehold { get; set; }
    }

    public class ConstituentApiApiCollectionOfAddressRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiAddressRead[] Value { get; set; }
    }

    public class ConstituentApiAddressRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("address_lines")]
        public string AddressLines { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("suburb")]
        public string Suburb { get; set; }

        [JsonProperty("county")]
        public string County { get; set; }

        [JsonProperty("formatted_address")]
        public string FormattedAddress { get; set; }

        [JsonProperty("information_source")]
        public string InformationSource { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("cart")]
        public string CART { get; set; }

        [JsonProperty("lot")]
        public string LOT { get; set; }

        [JsonProperty("dpc")]
        public string DPC { get; set; }

        [JsonProperty("start")]
        public string ValidFrom { get; set; }

        [JsonProperty("end")]
        public string ValidTo { get; set; }

        [JsonProperty("preferred")]
        public bool Primary { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("do_not_mail")]
        public bool DoNotMail { get; set; }

        [JsonProperty("seasonal_start")]
        public ConstituentApiAddressReadSeasonalStartType SeasonalStart { get; set; }

        [JsonProperty("seasonal_end")]
        public ConstituentApiAddressReadSeasonalEndType SeasonalEnd { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class ConstituentApiAddressReadSeasonalStartType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class ConstituentApiAddressReadSeasonalEndType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class ConstituentApiApiCollectionOfAliasRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiAliasRead[] Value { get; set; }
    }

    public class ConstituentApiAliasRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("name")]
        public string Alias { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ConstituentApiApiCollectionOfConstituentAttachmentRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiConstituentAttachmentRead[] Value { get; set; }
    }

    public class ConstituentApiConstituentAttachmentRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("parent_id")]
        public string ConstituentID { get; set; }

        [JsonProperty("type")]
        public ConstituentApiConstituentAttachmentReadTypeType Type { get; set; }

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
    }

    public enum ConstituentApiConstituentAttachmentReadTypeType
    {
        Link,
        Physical
    }

    public class ConstituentApiApiCollectionOfConstituentCodeRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiConstituentCodeRead[] Value { get; set; }
    }

    public class ConstituentApiConstituentCodeRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentID { get; set; }

        [JsonProperty("description")]
        public string ConstituentCode { get; set; }

        [JsonProperty("start")]
        public ConstituentApiConstituentCodeReadStartType Start { get; set; }

        [JsonProperty("end")]
        public ConstituentApiConstituentCodeReadEndType End { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("sequence")]
        public int Sequence { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class ConstituentApiConstituentCodeReadStartType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class ConstituentApiConstituentCodeReadEndType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class ConstituentApiApiCollectionOfConstituentCustomFieldRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiConstituentCustomFieldRead[] Value { get; set; }
    }

    public class ConstituentApiConstituentCustomFieldRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("parent_id")]
        public string ConstituentID { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("type")]
        public ConstituentApiConstituentCustomFieldReadTypeType Type { get; set; }

        [JsonProperty("value")]
        public JToken Value { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public enum ConstituentApiConstituentCustomFieldReadTypeType
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

    public class ConstituentApiApiCollectionOfEducationRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiEducationRead[] Value { get; set; }
    }

    public class ConstituentApiEducationRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentID { get; set; }

        [JsonProperty("school")]
        public string School { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("class_of")]
        public string ClassOf { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("date_entered")]
        public ConstituentApiEducationReadDateEnteredType DateEntered { get; set; }

        [JsonProperty("date_left")]
        public ConstituentApiEducationReadDateLeftType DateLeft { get; set; }

        [JsonProperty("date_graduated")]
        public ConstituentApiEducationReadDateGraduatedType DateGraduated { get; set; }

        [JsonProperty("degree")]
        public string Degree { get; set; }

        [JsonProperty("gpa")]
        public double GPA { get; set; }

        [JsonProperty("majors")]
        public string[] Majors { get; set; }

        [JsonProperty("minors")]
        public string[] Minors { get; set; }

        [JsonProperty("primary")]
        public bool IsPrimaryEducation { get; set; }

        [JsonProperty("campus")]
        public string Campus { get; set; }

        [JsonProperty("social_organization")]
        public string SocialOrganization { get; set; }

        [JsonProperty("known_name")]
        public string KnownName { get; set; }

        [JsonProperty("class_of_degree")]
        public string ClassOfDegree { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("faculty")]
        public string Faculty { get; set; }

        [JsonProperty("registration_number")]
        public string RegistrationNumber { get; set; }

        [JsonProperty("subject_of_study")]
        public string SubjectOfStudy { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class ConstituentApiEducationReadDateEnteredType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class ConstituentApiEducationReadDateLeftType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class ConstituentApiEducationReadDateGraduatedType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class ConstituentApiApiCollectionOfEmailAddressRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiEmailAddressRead[] Value { get; set; }
    }

    public class ConstituentApiEmailAddressRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentID { get; set; }

        [JsonProperty("type")]
        public string EmailType { get; set; }

        [JsonProperty("address")]
        public string EmailAddress { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("do_not_email")]
        public bool DoNotEmail { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class ConstituentApiApiCollectionOfFundraiserAssignmentRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiFundraiserAssignmentRead[] Value { get; set; }
    }

    public class ConstituentApiFundraiserAssignmentRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentID { get; set; }

        [JsonProperty("fundraiser_id")]
        public string FundraiserID { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("amount")]
        public ConstituentApiFundraiserAssignmentReadAmountType Amount { get; set; }

        [JsonProperty("campaign_id")]
        public string CampaignID { get; set; }

        [JsonProperty("fund_id")]
        public string FundID { get; set; }

        [JsonProperty("appeal_id")]
        public string AppealID { get; set; }

        [JsonProperty("start")]
        public string StartDate { get; set; }

        [JsonProperty("end")]
        public string EndDate { get; set; }
    }

    public class ConstituentApiFundraiserAssignmentReadAmountType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class ConstituentApiGivingSummaryRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("amount")]
        public ConstituentApiGivingSummaryReadAmountType Amount { get; set; }

        [JsonProperty("appeals")]
        public ConstituentApiAppealRead[] Appeal { get; set; }

        [JsonProperty("campaigns")]
        public ConstituentApiCampaignRead[] Campaign { get; set; }

        [JsonProperty("funds")]
        public ConstituentApiFundRead[] Fund { get; set; }
    }

    public class ConstituentApiGivingSummaryReadAmountType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class ConstituentApiAppealRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class ConstituentApiCampaignRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class ConstituentApiFundRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class ConstituentApiLifetimeGivingRead
    {
        [JsonProperty("consecutive_years_given")]
        public int ConsecutiveYearsGiven { get; set; }

        [JsonProperty("total_years_given")]
        public int TotalYearsGiven { get; set; }

        [JsonProperty("total_giving")]
        public ConstituentApiLifetimeGivingReadTotalGivingType TotalGiving { get; set; }

        [JsonProperty("total_pledge_balance")]
        public ConstituentApiLifetimeGivingReadTotalPledgeBalanceType TotalPledgeBalance { get; set; }

        [JsonProperty("total_received_giving")]
        public ConstituentApiLifetimeGivingReadTotalReceivedGivingType TotalReceivedGiving { get; set; }

        [JsonProperty("total_committed_matching_gifts")]
        public ConstituentApiLifetimeGivingReadTotalCommittedMatchingGiftsType TotalCommittedMatchingGifts { get; set; }

        [JsonProperty("total_received_matching_gifts")]
        public ConstituentApiLifetimeGivingReadTotalReceivedMatchingGiftsType TotalReceivedMatchingGifts { get; set; }

        [JsonProperty("total_soft_credits")]
        public ConstituentApiLifetimeGivingReadTotalSoftCreditsType TotalSoftCredits { get; set; }
    }

    public class ConstituentApiLifetimeGivingReadTotalGivingType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class ConstituentApiLifetimeGivingReadTotalPledgeBalanceType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class ConstituentApiLifetimeGivingReadTotalReceivedGivingType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class ConstituentApiLifetimeGivingReadTotalCommittedMatchingGiftsType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class ConstituentApiLifetimeGivingReadTotalReceivedMatchingGiftsType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class ConstituentApiLifetimeGivingReadTotalSoftCreditsType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class ConstituentApiApiCollectionOfNoteRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiNoteRead[] Value { get; set; }
    }

    public class ConstituentApiNoteRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentID { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("date")]
        public ConstituentApiNoteReadDateType Date { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("text")]
        public string Note { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class ConstituentApiNoteReadDateType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class ConstituentApiApiCollectionOfOnlinePresenceRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiOnlinePresenceRead[] Value { get; set; }
    }

    public class ConstituentApiOnlinePresenceRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentID { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("address")]
        public string Link { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class ConstituentApiApiCollectionOfPhoneRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiPhoneRead[] Value { get; set; }
    }

    public class ConstituentApiPhoneRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentID { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("do_not_call")]
        public bool DoNotCall { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class ConstituentApiProfilePictureRead
    {
        [JsonProperty("constituent_id")]
        public string ConstituentID { get; set; }

        [JsonProperty("url")]
        public string URL { get; set; }

        [JsonProperty("thumbnail_url")]
        public string ThumbnailURL { get; set; }
    }

    public class ConstituentApiProspectStatusRead
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("days_elapsed")]
        public int DaysElapsed { get; set; }

        [JsonProperty("start")]
        public string StartDate { get; set; }

        [JsonProperty("comments")]
        public string Comments { get; set; }
    }

    public class ConstituentApiApiCollectionOfRatingRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiRatingRead[] Value { get; set; }
    }

    public class ConstituentApiRatingRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentID { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("value")]
        public JToken Description { get; set; }

        [JsonProperty("comment")]
        public string Comments { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("type")]
        public ConstituentApiRatingReadTypeType Type { get; set; }
    }

    public enum ConstituentApiRatingReadTypeType
    {
        Text,
        Number,
        DateTime,
        Currency,
        Boolean,
        CodeTable,
        Unknown
    }

    public class ConstituentApiApiCollectionOfRelationshipRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiRelationshipRead[] Value { get; set; }
    }

    public class ConstituentApiRelationshipRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentID { get; set; }

        [JsonProperty("relation_id")]
        public string RelationID { get; set; }

        [JsonProperty("reciprocal_relationship_id")]
        public string ReciprocalRelationshipID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("reciprocal_type")]
        public string ReciprocalType { get; set; }

        [JsonProperty("start")]
        public ConstituentApiRelationshipReadStartType Start { get; set; }

        [JsonProperty("end")]
        public ConstituentApiRelationshipReadEndType End { get; set; }

        [JsonProperty("is_spouse")]
        public bool IsSpouse { get; set; }

        [JsonProperty("is_constituent_head_of_household")]
        public bool IsConstituentHeadOfHousehold { get; set; }

        [JsonProperty("is_spouse_head_of_household")]
        public bool IsSpouseHeadOfHousehold { get; set; }

        [JsonProperty("comment")]
        public string Notes { get; set; }

        [JsonProperty("is_organization_contact")]
        public bool IsContact { get; set; }

        [JsonProperty("is_primary_business")]
        public bool IsPrimaryBusiness { get; set; }

        [JsonProperty("organization_contact_type")]
        public string ContactType { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class ConstituentApiRelationshipReadStartType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class ConstituentApiRelationshipReadEndType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class ConstituentApiCreatedConstituentAttachment
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class ConstituentApiCreatedConstituentCustomField
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class ConstituentApiApiCollectionOfSearchResultRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiSearchResultRead[] Value { get; set; }
    }

    public class ConstituentApiSearchResultRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("deceased")]
        public bool Deceased { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("fundraiser_status")]
        public string FundraiserStatus { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("lookup_id")]
        public string LookupID { get; set; }
    }

    public enum searchFieldInput
    {
        [EnumMember(Value = "lookup_id")]
        LookupId
    }

    public class ConstituentApiFileDefinition
    {
        [JsonProperty("file_id")]
        public string FileID { get; set; }

        [JsonProperty("file_upload_request")]
        public ConstituentApiFileDefinitionFileUploadType FileUpload { get; set; }

        [JsonProperty("thumbnail_id")]
        public string ThumbnailID { get; set; }

        [JsonProperty("thumbnail_upload_request")]
        public ConstituentApiFileDefinitionThumbnailUploadType ThumbnailUpload { get; set; }
    }

    public class ConstituentApiFileDefinitionFileUploadType
    {
        [JsonProperty("url")]
        public string URL { get; set; }

        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("headers")]
        public ConstituentApiHeader[] Headers { get; set; }
    }

    public class ConstituentApiHeader
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class ConstituentApiFileDefinitionThumbnailUploadType
    {
        [JsonProperty("url")]
        public string URL { get; set; }

        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("headers")]
        public ConstituentApiHeader[] Headers { get; set; }
    }

    public class ConstituentApiCreatedConstituentEducation
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class ConstituentApiCreatedConstituentEmailAddress
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class ConstituentApiCreatedConstituentOnlinePresence
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class ConstituentApiCreatedConstituentPhone
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class ConstituentApiCreatedConstituentRating
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class ConstituentApiCreatedIndividualConstituent
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class ConstituentApiCreatedIndividualRelationship
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class ConstituentApiCreatedOrganizationConstituent
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class ConstituentApiCreatedOrganizationRelationship
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class EventApiApiCollectionOfEventListEntry
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public EventApiEventListEntry[] Value { get; set; }
    }

    public class EventApiEventListEntry
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("start_time")]
        public string StartTime { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("end_time")]
        public string EndTime { get; set; }

        [JsonProperty("category")]
        public EventApiEventCategory Category { get; set; }

        [JsonProperty("lookup_id")]
        public string LookupID { get; set; }

        [JsonProperty("capacity")]
        public int Capacity { get; set; }

        [JsonProperty("attending_count")]
        public int Attending { get; set; }

        [JsonProperty("attended_count")]
        public int Attended { get; set; }

        [JsonProperty("invited_count")]
        public int Invited { get; set; }

        [JsonProperty("revenue")]
        public double Revenue { get; set; }

        [JsonProperty("goal")]
        public double Goal { get; set; }

        [JsonProperty("percent_of_goal")]
        public int PercentOfGoal { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class EventApiEventCategory
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }
    }

    public class EventApiCreatedEvent
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class EventApiEvent
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("start_time")]
        public string StartTime { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("end_time")]
        public string EndTime { get; set; }

        [JsonProperty("category")]
        public EventApiEventCategory Category { get; set; }

        [JsonProperty("lookup_id")]
        public string LookupID { get; set; }

        [JsonProperty("location")]
        public EventApiLocation Location { get; set; }

        [JsonProperty("capacity")]
        public int Capacity { get; set; }

        [JsonProperty("goal")]
        public double Goal { get; set; }

        [JsonProperty("campaign_id")]
        public string CampaignID { get; set; }

        [JsonProperty("fund_id")]
        public string FundID { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class EventApiLocation
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("address_lines")]
        public string AddressLines { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("locality")]
        public EventApiLocality Locality { get; set; }

        [JsonProperty("administrative_area")]
        public EventApiAdministrativeArea AdministrativeArea { get; set; }

        [JsonProperty("sub_administrative_area")]
        public EventApiSubAdministrativeArea SubAdministrativeArea { get; set; }

        [JsonProperty("country")]
        public EventApiCountry Country { get; set; }

        [JsonProperty("formatted_address")]
        public string FormattedAddress { get; set; }
    }

    public class EventApiLocality
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class EventApiAdministrativeArea
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("short_description")]
        public string ShortDescription { get; set; }
    }

    public class EventApiSubAdministrativeArea
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class EventApiCountry
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("iso_alpha2_code")]
        public string ISOCode { get; set; }
    }

    public class EventApiApiCollectionOfEventFee
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public EventApiEventFee[] Value { get; set; }
    }

    public class EventApiEventFee
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("cost")]
        public double Amount { get; set; }

        [JsonProperty("contribution_amount")]
        public double ContributionAmount { get; set; }

        [JsonProperty("number_sold")]
        public int NumberSold { get; set; }
    }

    public class EventApiCreatedEventFee
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class EventApiApiCollectionOfEventParticipantOption
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public EventApiEventParticipantOption[] Value { get; set; }
    }

    public class EventApiEventParticipantOption
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("input_type")]
        public EventApiEventParticipantOptionInputTypeType InputType { get; set; }

        [JsonProperty("multi_select")]
        public bool AllowMultiSelect { get; set; }

        [JsonProperty("list_options")]
        public EventApiEventParticipantOptionListOption[] ListOptions { get; set; }

        [JsonProperty("added_by_user")]
        public string AddedByUser { get; set; }

        [JsonProperty("updated_by_user")]
        public string ModifiedByUser { get; set; }

        [JsonProperty("added_by_service")]
        public string AddedByService { get; set; }

        [JsonProperty("updated_by_service")]
        public string ModifiedByService { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_updated")]
        public string DateModified { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }
    }

    public enum EventApiEventParticipantOptionInputTypeType
    {
        Boolean,
        String,
        List
    }

    public class EventApiEventParticipantOptionListOption
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("sequence")]
        public int Sequence { get; set; }
    }

    public class EventApiCreatedEventParticipantOption
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public enum bodyinputTypeInput
    {
        Boolean,
        String,
        List
    }

    public class EventApiCreateParticipantOptionListOption
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("sequence")]
        public int Sequence { get; set; }
    }

    public class EventApiApiCollectionOfParticipantListEntry
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public EventApiParticipantListEntry[] Value { get; set; }
    }

    public class EventApiParticipantListEntry
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("contact_id")]
        public string ContactID { get; set; }

        [JsonProperty("rsvp_status")]
        public EventApiParticipantListEntryRSVPStatusType RSVPStatus { get; set; }

        [JsonProperty("attended")]
        public bool Attended { get; set; }

        [JsonProperty("invitation_status")]
        public EventApiParticipantListEntryInvitationStatusType InvitationStatus { get; set; }

        [JsonProperty("rsvp_date")]
        public EventApiParticipantListEntryRSVPDateType RSVPDate { get; set; }

        [JsonProperty("participation_level")]
        public EventApiParticipationLevel ParticipationLevel { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("preferred_name")]
        public string PreferredName { get; set; }

        [JsonProperty("suffix")]
        public string Suffix { get; set; }

        [JsonProperty("lookup_id")]
        public string LookupID { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("do_not_email")]
        public bool DoNotEmail { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("do_not_call")]
        public bool DoNotCall { get; set; }

        [JsonProperty("middle_name")]
        public string MiddleName { get; set; }

        [JsonProperty("former_name")]
        public string FormerName { get; set; }

        [JsonProperty("is_constituent")]
        public bool IsAConstituent { get; set; }

        [JsonProperty("class_of")]
        public string ClassOf { get; set; }

        [JsonProperty("total_registration_fees")]
        public double TotalRegistrationFees { get; set; }

        [JsonProperty("total_paid")]
        public double TotalPaid { get; set; }

        [JsonProperty("seat")]
        public string Seat { get; set; }

        [JsonProperty("name_tag")]
        public string NameTag { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }

        [JsonProperty("host")]
        public EventApiParticipantListEntryHostType Host { get; set; }

        [JsonProperty("guests")]
        public EventApiParticipantListParticipantSummary[] Guests { get; set; }

        [JsonProperty("memberships")]
        public EventApiMembership[] Memberships { get; set; }
    }

    public enum EventApiParticipantListEntryRSVPStatusType
    {
        NoResponse,
        Attending,
        Declined,
        Interested,
        Canceled,
        Waitlisted,
        NotApplicable
    }

    public enum EventApiParticipantListEntryInvitationStatusType
    {
        NotApplicable,
        NotInvited,
        Invited
    }

    public class EventApiParticipantListEntryRSVPDateType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class EventApiParticipationLevel
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("is_inactive")]
        public bool Inactive { get; set; }
    }

    public class EventApiParticipantListEntryHostType
    {
        [JsonProperty("contact_id")]
        public string ContactID { get; set; }

        [JsonProperty("participant_id")]
        public string ParticipantID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class EventApiParticipantListParticipantSummary
    {
        [JsonProperty("contact_id")]
        public string ContactID { get; set; }

        [JsonProperty("participant_id")]
        public string ParticipantID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class EventApiMembership
    {
        [JsonProperty("category")]
        public EventApiMembershipCategory Category { get; set; }
    }

    public class EventApiMembershipCategory
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public enum rsvpStatusInput
    {
        NoResponse,
        Attending,
        Declined,
        Interested,
        Canceled,
        Waitlisted,
        NotApplicable
    }

    public enum invitationStatusInput
    {
        NotApplicable,
        NotInvited,
        Invited
    }

    public class EventApiCreatedParticipant
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public enum bodyrSVPStatusInput
    {
        NoResponse,
        Attending,
        Declined,
        Interested,
        Canceled,
        Waitlisted,
        NotApplicable
    }

    public enum bodyinvitationStatusInput
    {
        NotApplicable,
        NotInvited,
        Invited
    }

    public class EventApiParticipant
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentID { get; set; }

        [JsonProperty("event_id")]
        public string EventID { get; set; }

        [JsonProperty("host_id")]
        public string HostID { get; set; }

        [JsonProperty("rsvp_status")]
        public EventApiParticipantRSVPStatusType RSVPStatus { get; set; }

        [JsonProperty("attended")]
        public bool Attended { get; set; }

        [JsonProperty("invitation_status")]
        public EventApiParticipantInvitationStatusType InvitationStatus { get; set; }

        [JsonProperty("rsvp_date")]
        public EventApiParticipantRSVPDateType RSVPDate { get; set; }

        [JsonProperty("invitation_date")]
        public EventApiParticipantInvitationDateType InvitationDate { get; set; }

        [JsonProperty("participation_level")]
        public EventApiParticipationLevel ParticipationLevel { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public enum EventApiParticipantRSVPStatusType
    {
        NoResponse,
        Attending,
        Declined,
        Interested,
        Canceled,
        Waitlisted,
        NotApplicable
    }

    public enum EventApiParticipantInvitationStatusType
    {
        NotApplicable,
        NotInvited,
        Invited
    }

    public class EventApiParticipantRSVPDateType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class EventApiParticipantInvitationDateType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class EventApiApiCollectionOfParticipantDonation
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public EventApiParticipantDonation[] Value { get; set; }
    }

    public class EventApiParticipantDonation
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("gift_id")]
        public string GiftID { get; set; }
    }

    public class EventApiCreatedParticipantDonation
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class EventApiApiCollectionOfParticipantFeePayment
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public EventApiParticipantFeePayment[] Value { get; set; }
    }

    public class EventApiParticipantFeePayment
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("participant_id")]
        public string ParticipantID { get; set; }

        [JsonProperty("gift_id")]
        public string GiftID { get; set; }

        [JsonProperty("applied_amount")]
        public double AppliedAmount { get; set; }
    }

    public class EventApiCreatedParticipantFeePayment
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class EventApiApiCollectionOfParticipantFee
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public EventApiParticipantFee[] Value { get; set; }
    }

    public class EventApiParticipantFee
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("participant_id")]
        public string ParticipantID { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("fee_amount")]
        public double FeeAmount { get; set; }

        [JsonProperty("tax_receiptable_amount")]
        public double ContributionAmount { get; set; }

        [JsonProperty("date")]
        public EventApiParticipantFeeDateType Date { get; set; }

        [JsonProperty("event_fee")]
        public EventApiEventFee EventFee { get; set; }
    }

    public class EventApiParticipantFeeDateType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class EventApiCreatedParticipantFee
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class EventApiApiCollectionOfParticipantOption
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public EventApiParticipantOption[] Value { get; set; }
    }

    public class EventApiParticipantOption
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("participant_id")]
        public string ParticipantID { get; set; }

        [JsonProperty("event_id")]
        public string EventID { get; set; }

        [JsonProperty("event_participant_option_id")]
        public string EventParticipantOptionID { get; set; }

        [JsonProperty("option_value")]
        public string Value { get; set; }

        [JsonProperty("added_by_user")]
        public string AddedByUser { get; set; }

        [JsonProperty("updated_by_user")]
        public string ModifiedByUser { get; set; }

        [JsonProperty("added_by_service")]
        public string AddedByService { get; set; }

        [JsonProperty("updated_by_service")]
        public string ModifiedByService { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_updated")]
        public string DateModified { get; set; }
    }

    public class EventApiCreatedParticipantOption
    {
        [JsonProperty("id")]
        public string ID { get; set; }
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

    public class FundraisingApiCreatedAppealAttachment
    {
        [JsonProperty("id")]
        public string ID { get; set; }
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

    public class FundraisingApiCreatedFundraiserAssignment
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class FundraisingApiApiCollectionOfFundraiserAssignmentRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public FundraisingApiFundraiserAssignmentRead[] Value { get; set; }
    }

    public class FundraisingApiFundraiserAssignmentRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentID { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("start")]
        public string AssignmentStarts { get; set; }

        [JsonProperty("end")]
        public string AssignmentEnds { get; set; }

        [JsonProperty("amount")]
        public FundraisingApiFundraiserAssignmentReadAmountType Amount { get; set; }

        [JsonProperty("campaign_id")]
        public string CampaignID { get; set; }

        [JsonProperty("fund_id")]
        public string FundID { get; set; }

        [JsonProperty("appeal_id")]
        public string AppealID { get; set; }
    }

    public class FundraisingApiFundraiserAssignmentReadAmountType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
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

    public enum bodystatusInput
    {
        Receipted,
        NeedsReceipt,
        DoNotReceipt
    }

    public class GiftApiApiCollectionOfGiftRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public GiftApiGiftRead[] Value { get; set; }
    }

    public class GiftApiGiftRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentID { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("subtype")]
        public string Subtype { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("amount")]
        public GiftApiGiftReadAmountType Amount { get; set; }

        [JsonProperty("balance")]
        public GiftApiGiftReadBalanceType Balance { get; set; }

        [JsonProperty("batch_number")]
        public string BatchNumber { get; set; }

        [JsonProperty("gift_status")]
        public string Status { get; set; }

        [JsonProperty("is_anonymous")]
        public bool Anonymous { get; set; }

        [JsonProperty("constituency")]
        public string Constituency { get; set; }

        [JsonProperty("lookup_id")]
        public string LookupID { get; set; }

        [JsonProperty("origin")]
        public string Origin { get; set; }

        [JsonProperty("post_status")]
        public string PostStatus { get; set; }

        [JsonProperty("post_date")]
        public string PostDate { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("recurring_gift_status_date")]
        public GiftApiGiftReadRecurringGiftDateType RecurringGiftDate { get; set; }

        [JsonProperty("recurring_gift_schedule")]
        public GiftApiGiftReadRecurringGiftScheduleType RecurringGiftSchedule { get; set; }

        [JsonProperty("gift_aid_amount")]
        public GiftApiGiftReadGiftAidAmountType GiftAidAmount { get; set; }

        [JsonProperty("gift_aid_qualification_status")]
        public string GiftAidQualificationStatus { get; set; }

        [JsonProperty("gift_code")]
        public string GiftCode { get; set; }

        [JsonProperty("gift_splits")]
        public GiftApiGiftSplitRead[] GiftSplits { get; set; }

        [JsonProperty("fundraisers")]
        public GiftApiGiftFundraiserRead[] Fundraisers { get; set; }

        [JsonProperty("soft_credits")]
        public GiftApiSoftCreditRead[] SoftCredits { get; set; }

        [JsonProperty("receipts")]
        public GiftApiReceiptRead[] Receipts { get; set; }

        [JsonProperty("acknowledgements")]
        public GiftApiAcknowledgementRead[] Acknowledgements { get; set; }

        [JsonProperty("payments")]
        public GiftApiPaymentRead[] Payments { get; set; }

        [JsonProperty("linked_gifts")]
        public string[] LinkedGifts { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class GiftApiGiftReadAmountType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class GiftApiGiftReadBalanceType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class GiftApiGiftReadRecurringGiftDateType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class GiftApiGiftReadRecurringGiftScheduleType
    {
        [JsonProperty("frequency")]
        public string Frequency { get; set; }

        [JsonProperty("start_date")]
        public string Start { get; set; }

        [JsonProperty("end_date")]
        public string End { get; set; }
    }

    public class GiftApiGiftReadGiftAidAmountType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class GiftApiGiftSplitRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("amount")]
        public GiftApiGiftSplitReadAmountType Amount { get; set; }

        [JsonProperty("appeal_id")]
        public string AppealID { get; set; }

        [JsonProperty("campaign_id")]
        public string CampaignID { get; set; }

        [JsonProperty("fund_id")]
        public string FundID { get; set; }

        [JsonProperty("gift_aid_amount")]
        public GiftApiGiftSplitReadGiftAidAmountType GiftAidAmount { get; set; }

        [JsonProperty("gift_aid_qualification_status")]
        public string GiftAidQualificationStatus { get; set; }

        [JsonProperty("package_id")]
        public string PackageID { get; set; }
    }

    public class GiftApiGiftSplitReadAmountType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class GiftApiGiftSplitReadGiftAidAmountType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class GiftApiGiftFundraiserRead
    {
        [JsonProperty("amount")]
        public GiftApiGiftFundraiserReadAmountType Amount { get; set; }

        [JsonProperty("constituent_id")]
        public string FundraiserID { get; set; }
    }

    public class GiftApiGiftFundraiserReadAmountType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class GiftApiSoftCreditRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("amount")]
        public GiftApiSoftCreditReadAmountType Amount { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentID { get; set; }

        [JsonProperty("gift_id")]
        public string GiftID { get; set; }
    }

    public class GiftApiSoftCreditReadAmountType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class GiftApiReceiptRead
    {
        [JsonProperty("amount")]
        public GiftApiReceiptReadAmountType Amount { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class GiftApiReceiptReadAmountType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class GiftApiAcknowledgementRead
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("letter")]
        public string Letter { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class GiftApiPaymentRead
    {
        [JsonProperty("account_token")]
        public string AccountToken { get; set; }

        [JsonProperty("bbps_configuration_id")]
        public string BBPSConfigurationID { get; set; }

        [JsonProperty("bbps_transaction_id")]
        public string BBPSTransactionID { get; set; }

        [JsonProperty("check_date")]
        public GiftApiPaymentReadCheckDateType CheckDate { get; set; }

        [JsonProperty("check_number")]
        public string CheckNumber { get; set; }

        [JsonProperty("checkout_transaction_id")]
        public string CheckoutTransactionID { get; set; }

        [JsonProperty("payment_method")]
        public string PaymentMethod { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("reference_date")]
        public GiftApiPaymentReadReferenceDateType ReferenceDate { get; set; }
    }

    public class GiftApiPaymentReadCheckDateType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class GiftApiPaymentReadReferenceDateType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class GiftApiApiCollectionOfGiftAttachmentRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public GiftApiGiftAttachmentRead[] Value { get; set; }
    }

    public class GiftApiGiftAttachmentRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("parent_id")]
        public string GiftID { get; set; }

        [JsonProperty("type")]
        public GiftApiGiftAttachmentReadTypeType Type { get; set; }

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
    }

    public enum GiftApiGiftAttachmentReadTypeType
    {
        Link,
        Physical
    }

    public class GiftApiApiCollectionOfGiftCustomFieldRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public GiftApiGiftCustomFieldRead[] Value { get; set; }
    }

    public class GiftApiGiftCustomFieldRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("parent_id")]
        public string GiftID { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("type")]
        public GiftApiGiftCustomFieldReadTypeType Type { get; set; }

        [JsonProperty("value")]
        public JToken Value { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public enum GiftApiGiftCustomFieldReadTypeType
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

    public class GiftApiCreatedGiftAttachment
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class GiftApiCreatedGiftCustomField
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class GiftBatchApiApiCollectionOfGiftBatch
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public GiftBatchApiGiftBatch[] Value { get; set; }
    }

    public class GiftBatchApiGiftBatch
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("batch_description")]
        public string Description { get; set; }

        [JsonProperty("batch_number")]
        public string BatchNumber { get; set; }

        [JsonProperty("projected_number_of_gifts")]
        public int ProjectedNumber { get; set; }

        [JsonProperty("number_of_gifts")]
        public int ActualNumber { get; set; }

        [JsonProperty("projected_amount")]
        public double ProjectedAmount { get; set; }

        [JsonProperty("actual_amount")]
        public double ActualAmount { get; set; }

        [JsonProperty("has_exceptions")]
        public bool HasExceptions { get; set; }

        [JsonProperty("is_approved")]
        public bool Approved { get; set; }

        [JsonProperty("created_by")]
        public string CreatedBy { get; set; }

        [JsonProperty("created_on")]
        public string CreatedOn { get; set; }
    }

    public class GiftBatchApiCreatedBatch
    {
        [JsonProperty("batch_id")]
        public string ID { get; set; }
    }

    public enum bodylistTypeInput
    {
        Constituent,
        Gift,
        Action,
        Opportunity
    }

    public class ListApiCreatedList
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public enum bodypermissionsInput
    {
        OnlyOwnerCanAccess,
        OthersCanView,
        OthersCanViewAndEdit
    }

    public class OpportunityApiApiCollectionOfOpportunityRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public OpportunityApiOpportunityRead[] Value { get; set; }
    }

    public class OpportunityApiOpportunityRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentID { get; set; }

        [JsonProperty("purpose")]
        public string Purpose { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("deadline")]
        public string Deadline { get; set; }

        [JsonProperty("ask_date")]
        public string AskDate { get; set; }

        [JsonProperty("ask_amount")]
        public OpportunityApiOpportunityReadAskAmountType AskAmount { get; set; }

        [JsonProperty("expected_date")]
        public string ExpectedDate { get; set; }

        [JsonProperty("expected_amount")]
        public OpportunityApiOpportunityReadExpectedAmountType ExpectedAmount { get; set; }

        [JsonProperty("funded_date")]
        public string FundedDate { get; set; }

        [JsonProperty("funded_amount")]
        public OpportunityApiOpportunityReadFundedAmountType FundedAmount { get; set; }

        [JsonProperty("campaign_id")]
        public string CampaignID { get; set; }

        [JsonProperty("fund_id")]
        public string FundID { get; set; }

        [JsonProperty("fundraisers")]
        public OpportunityApiFundraiser[] FundraiserS { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("linked_gifts")]
        public string[] LinkedGifts { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class OpportunityApiOpportunityReadAskAmountType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class OpportunityApiOpportunityReadExpectedAmountType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class OpportunityApiOpportunityReadFundedAmountType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class OpportunityApiFundraiser
    {
        [JsonProperty("constituent_id")]
        public string ConstituentID { get; set; }

        [JsonProperty("credit_amount")]
        public OpportunityApiFundraiserCreditAmountType CreditAmount { get; set; }
    }

    public class OpportunityApiFundraiserCreditAmountType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class OpportunityApiCreatedOpportunity
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class OpportunityApiApiCollectionOfOpportunityAttachmentRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public OpportunityApiOpportunityAttachmentRead[] Value { get; set; }
    }

    public class OpportunityApiOpportunityAttachmentRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("parent_id")]
        public string OpportunityID { get; set; }

        [JsonProperty("type")]
        public OpportunityApiOpportunityAttachmentReadTypeType Type { get; set; }

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
    }

    public enum OpportunityApiOpportunityAttachmentReadTypeType
    {
        Link,
        Physical
    }

    public class OpportunityApiApiCollectionOfOpportunityCustomFieldRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public OpportunityApiOpportunityCustomFieldRead[] Value { get; set; }
    }

    public class OpportunityApiOpportunityCustomFieldRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("parent_id")]
        public string OpportunityID { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("type")]
        public OpportunityApiOpportunityCustomFieldReadTypeType Type { get; set; }

        [JsonProperty("value")]
        public JToken Value { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public enum OpportunityApiOpportunityCustomFieldReadTypeType
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

    public class OpportunityApiCreatedOpportunityAttachment
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class OpportunityApiCreatedOpportunityCustomField
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Blackbaudraisersedge;

    public partial class WorkflowManagedActions
    {
        public BlackbaudraisersedgeActions Blackbaudraisersedge(string connectionId) => new BlackbaudraisersedgeActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public BlackbaudraisersedgeTriggers Blackbaudraisersedge(string connectionId) => new BlackbaudraisersedgeTriggers(connectionId);
    }
}