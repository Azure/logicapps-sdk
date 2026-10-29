//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Blackbaudprospects
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BlackbaudprospectsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudprospects")]
        public IBodyWorkflowAction<ConstituentApiProspectStatusRead, ApiConnectionActionConfiguration> GetConstituentProspectStatus(Expression<Func<string>> constituentId)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<ConstituentApiProspectStatusRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/constituents/{0}/prospectstatus", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConstituentApiProspectStatusRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudprospects")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfRatingRead, ApiConnectionActionConfiguration> ListConstituentRatings(Expression<Func<string>> constituentId, Expression<Func<bool>> includeInactive = null, Expression<Func<bool>> mostRecentOnly = null)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            var __workflow_includeInactive = WorkflowExpression.Compile(includeInactive, nameof(includeInactive), required: false);
            var __workflow_mostRecentOnly = WorkflowExpression.Compile(mostRecentOnly, nameof(mostRecentOnly), required: false);
            return new DeferredBodyAction<ConstituentApiApiCollectionOfRatingRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/constituents/{0}/ratings", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_includeInactive != null)
                    callPayload.Queries["include_inactive"] = ExpressionConverter.Convert(__workflow_includeInactive);
                if (__workflow_mostRecentOnly != null)
                    callPayload.Queries["most_recent_only"] = ExpressionConverter.Convert(__workflow_mostRecentOnly);
                return new ApiConnectionAction<ConstituentApiApiCollectionOfRatingRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudprospects")]
        public IBodyWorkflowAction<ConstituentApiCreatedConstituentRating, ApiConnectionActionConfiguration> CreateConstituentRating(Expression<Func<string>> bodyconstituentId, Expression<Func<string>> bodysource, Expression<Func<string>> bodycategory, Expression<Func<string>> bodydate, Expression<Func<object>> bodyvalue = null, Expression<Func<string>> bodycomments = null)
        {
            var __workflow_bodyconstituentId = WorkflowExpression.Compile(bodyconstituentId, nameof(bodyconstituentId), required: true);
            var __workflow_bodysource = WorkflowExpression.Compile(bodysource, nameof(bodysource), required: true);
            var __workflow_bodycategory = WorkflowExpression.Compile(bodycategory, nameof(bodycategory), required: true);
            var __workflow_bodydate = WorkflowExpression.Compile(bodydate, nameof(bodydate), required: true);
            var __workflow_bodyvalue = WorkflowExpression.Compile(bodyvalue, nameof(bodyvalue), required: false);
            var __workflow_bodycomments = WorkflowExpression.Compile(bodycomments, nameof(bodycomments), required: false);
            return new DeferredBodyAction<ConstituentApiCreatedConstituentRating, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/constituent/v1/ratings";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = ExpressionConverter.ConvertO(__workflow_bodyconstituentId);
                bodypropCount++;
                body["source"] = ExpressionConverter.ConvertO(__workflow_bodysource);
                bodypropCount++;
                body["category"] = ExpressionConverter.ConvertO(__workflow_bodycategory);
                bodypropCount++;
                body["date"] = ExpressionConverter.ConvertO(__workflow_bodydate);
                if (__workflow_bodyvalue != null)
                {
                    body["value"] = ExpressionConverter.ConvertO(__workflow_bodyvalue);
                    bodypropCount++;
                }

                if (__workflow_bodycomments != null)
                {
                    body["comment"] = ExpressionConverter.ConvertO(__workflow_bodycomments);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ConstituentApiCreatedConstituentRating>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudprospects")]
        public IBodyWorkflowAction<OpportunityApiApiCollectionOfOpportunityRead, ApiConnectionActionConfiguration> ListOpportunities(Expression<Func<string>> listId = null, Expression<Func<string>> constituentId = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<bool>> includeInactive = null, Expression<Func<string>> dateAdded = null, Expression<Func<string>> lastModified = null)
        {
            var __workflow_listId = WorkflowExpression.Compile(listId, nameof(listId), required: false);
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_includeInactive = WorkflowExpression.Compile(includeInactive, nameof(includeInactive), required: false);
            var __workflow_dateAdded = WorkflowExpression.Compile(dateAdded, nameof(dateAdded), required: false);
            var __workflow_lastModified = WorkflowExpression.Compile(lastModified, nameof(lastModified), required: false);
            return new DeferredBodyAction<OpportunityApiApiCollectionOfOpportunityRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/opportunity/v1/opportunities";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_listId != null)
                    callPayload.Queries["list_id"] = ExpressionConverter.Convert(__workflow_listId);
                if (__workflow_constituentId != null)
                    callPayload.Queries["constituent_id"] = ExpressionConverter.Convert(__workflow_constituentId);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_includeInactive != null)
                    callPayload.Queries["include_inactive"] = ExpressionConverter.Convert(__workflow_includeInactive);
                if (__workflow_dateAdded != null)
                    callPayload.Queries["date_added"] = ExpressionConverter.Convert(__workflow_dateAdded);
                if (__workflow_lastModified != null)
                    callPayload.Queries["last_modified"] = ExpressionConverter.Convert(__workflow_lastModified);
                return new ApiConnectionAction<OpportunityApiApiCollectionOfOpportunityRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudprospects")]
        public IBodyWorkflowAction<OpportunityApiCreatedOpportunity, ApiConnectionActionConfiguration> CreateOpportunity(Expression<Func<string>> bodyconstituentId, Expression<Func<string>> bodypurpose, Expression<Func<string>> bodyname, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodydeadline = null, Expression<Func<string>> bodyaskDate = null, Expression<Func<double>> bodyaskAmountvalue = null, Expression<Func<string>> bodyexpectedDate = null, Expression<Func<double>> bodyexpectedAmountvalue = null, Expression<Func<string>> bodyfundedDate = null, Expression<Func<double>> bodyfundedAmountvalue = null, Expression<Func<string>> bodycampaignId = null, Expression<Func<string>> bodyfundId = null, Expression<Func<OpportunityApiFundraiser[]>> bodyfundraiserS = null, Expression<Func<bool>> bodyinactive = null)
        {
            var __workflow_bodyconstituentId = WorkflowExpression.Compile(bodyconstituentId, nameof(bodyconstituentId), required: true);
            var __workflow_bodypurpose = WorkflowExpression.Compile(bodypurpose, nameof(bodypurpose), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodydeadline = WorkflowExpression.Compile(bodydeadline, nameof(bodydeadline), required: false);
            var __workflow_bodyaskDate = WorkflowExpression.Compile(bodyaskDate, nameof(bodyaskDate), required: false);
            var __workflow_bodyaskAmountvalue = WorkflowExpression.Compile(bodyaskAmountvalue, nameof(bodyaskAmountvalue), required: false);
            var __workflow_bodyexpectedDate = WorkflowExpression.Compile(bodyexpectedDate, nameof(bodyexpectedDate), required: false);
            var __workflow_bodyexpectedAmountvalue = WorkflowExpression.Compile(bodyexpectedAmountvalue, nameof(bodyexpectedAmountvalue), required: false);
            var __workflow_bodyfundedDate = WorkflowExpression.Compile(bodyfundedDate, nameof(bodyfundedDate), required: false);
            var __workflow_bodyfundedAmountvalue = WorkflowExpression.Compile(bodyfundedAmountvalue, nameof(bodyfundedAmountvalue), required: false);
            var __workflow_bodycampaignId = WorkflowExpression.Compile(bodycampaignId, nameof(bodycampaignId), required: false);
            var __workflow_bodyfundId = WorkflowExpression.Compile(bodyfundId, nameof(bodyfundId), required: false);
            var __workflow_bodyfundraiserS = WorkflowExpression.Compile(bodyfundraiserS, nameof(bodyfundraiserS), required: false);
            var __workflow_bodyinactive = WorkflowExpression.Compile(bodyinactive, nameof(bodyinactive), required: false);
            return new DeferredBodyAction<OpportunityApiCreatedOpportunity, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/opportunity/v1/opportunities";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = ExpressionConverter.ConvertO(__workflow_bodyconstituentId);
                bodypropCount++;
                body["purpose"] = ExpressionConverter.ConvertO(__workflow_bodypurpose);
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodydeadline != null)
                {
                    body["deadline"] = ExpressionConverter.ConvertO(__workflow_bodydeadline);
                    bodypropCount++;
                }

                if (__workflow_bodyaskDate != null)
                {
                    body["ask_date"] = ExpressionConverter.ConvertO(__workflow_bodyaskDate);
                    bodypropCount++;
                }

                var askAmountObject = new JObject();
                var askAmountObjectpropCount = 0;
                if (__workflow_bodyaskAmountvalue != null)
                {
                    askAmountObject["value"] = ExpressionConverter.ConvertO(__workflow_bodyaskAmountvalue);
                    askAmountObjectpropCount++;
                }

                if (askAmountObjectpropCount > 0)
                {
                    body["ask_amount"] = askAmountObject;
                    bodypropCount++;
                }

                if (__workflow_bodyexpectedDate != null)
                {
                    body["expected_date"] = ExpressionConverter.ConvertO(__workflow_bodyexpectedDate);
                    bodypropCount++;
                }

                var expectedAmountObject = new JObject();
                var expectedAmountObjectpropCount = 0;
                if (__workflow_bodyexpectedAmountvalue != null)
                {
                    expectedAmountObject["value"] = ExpressionConverter.ConvertO(__workflow_bodyexpectedAmountvalue);
                    expectedAmountObjectpropCount++;
                }

                if (expectedAmountObjectpropCount > 0)
                {
                    body["expected_amount"] = expectedAmountObject;
                    bodypropCount++;
                }

                if (__workflow_bodyfundedDate != null)
                {
                    body["funded_date"] = ExpressionConverter.ConvertO(__workflow_bodyfundedDate);
                    bodypropCount++;
                }

                var fundedAmountObject = new JObject();
                var fundedAmountObjectpropCount = 0;
                if (__workflow_bodyfundedAmountvalue != null)
                {
                    fundedAmountObject["value"] = ExpressionConverter.ConvertO(__workflow_bodyfundedAmountvalue);
                    fundedAmountObjectpropCount++;
                }

                if (fundedAmountObjectpropCount > 0)
                {
                    body["funded_amount"] = fundedAmountObject;
                    bodypropCount++;
                }

                if (__workflow_bodycampaignId != null)
                {
                    body["campaign_id"] = ExpressionConverter.ConvertO(__workflow_bodycampaignId);
                    bodypropCount++;
                }

                if (__workflow_bodyfundId != null)
                {
                    body["fund_id"] = ExpressionConverter.ConvertO(__workflow_bodyfundId);
                    bodypropCount++;
                }

                if (__workflow_bodyfundraiserS != null)
                {
                    body["fundraisers"] = ExpressionConverter.ConvertO(__workflow_bodyfundraiserS);
                    bodypropCount++;
                }

                if (__workflow_bodyinactive != null)
                {
                    body["inactive"] = ExpressionConverter.ConvertO(__workflow_bodyinactive);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<OpportunityApiCreatedOpportunity>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudprospects")]
        public IBodyWorkflowAction<OpportunityApiOpportunityRead, ApiConnectionActionConfiguration> GetOpportunity(Expression<Func<string>> opportunityId)
        {
            var __workflow_opportunityId = WorkflowExpression.Compile(opportunityId, nameof(opportunityId), required: true);
            return new DeferredBodyAction<OpportunityApiOpportunityRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/opportunity/v1/opportunities/{0}", __workflow_opportunityId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<OpportunityApiOpportunityRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudprospects")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditOpportunity(Expression<Func<string>> opportunityId, Expression<Func<string>> bodypurpose = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodydeadline = null, Expression<Func<string>> bodyaskDate = null, Expression<Func<double>> bodyaskAmountvalue = null, Expression<Func<string>> bodyexpectedDate = null, Expression<Func<double>> bodyexpectedAmountvalue = null, Expression<Func<string>> bodyfundedDate = null, Expression<Func<double>> bodyfundedAmountvalue = null, Expression<Func<string>> bodycampaignId = null, Expression<Func<string>> bodyfundId = null, Expression<Func<OpportunityApiFundraiser[]>> bodyfundraiserS = null, Expression<Func<bool>> bodyinactive = null)
        {
            var __workflow_opportunityId = WorkflowExpression.Compile(opportunityId, nameof(opportunityId), required: true);
            var __workflow_bodypurpose = WorkflowExpression.Compile(bodypurpose, nameof(bodypurpose), required: false);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodydeadline = WorkflowExpression.Compile(bodydeadline, nameof(bodydeadline), required: false);
            var __workflow_bodyaskDate = WorkflowExpression.Compile(bodyaskDate, nameof(bodyaskDate), required: false);
            var __workflow_bodyaskAmountvalue = WorkflowExpression.Compile(bodyaskAmountvalue, nameof(bodyaskAmountvalue), required: false);
            var __workflow_bodyexpectedDate = WorkflowExpression.Compile(bodyexpectedDate, nameof(bodyexpectedDate), required: false);
            var __workflow_bodyexpectedAmountvalue = WorkflowExpression.Compile(bodyexpectedAmountvalue, nameof(bodyexpectedAmountvalue), required: false);
            var __workflow_bodyfundedDate = WorkflowExpression.Compile(bodyfundedDate, nameof(bodyfundedDate), required: false);
            var __workflow_bodyfundedAmountvalue = WorkflowExpression.Compile(bodyfundedAmountvalue, nameof(bodyfundedAmountvalue), required: false);
            var __workflow_bodycampaignId = WorkflowExpression.Compile(bodycampaignId, nameof(bodycampaignId), required: false);
            var __workflow_bodyfundId = WorkflowExpression.Compile(bodyfundId, nameof(bodyfundId), required: false);
            var __workflow_bodyfundraiserS = WorkflowExpression.Compile(bodyfundraiserS, nameof(bodyfundraiserS), required: false);
            var __workflow_bodyinactive = WorkflowExpression.Compile(bodyinactive, nameof(bodyinactive), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/opportunity/v1/opportunities/{0}", __workflow_opportunityId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodypurpose != null)
                {
                    body["purpose"] = ExpressionConverter.ConvertO(__workflow_bodypurpose);
                    bodypropCount++;
                }

                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodydeadline != null)
                {
                    body["deadline"] = ExpressionConverter.ConvertO(__workflow_bodydeadline);
                    bodypropCount++;
                }

                if (__workflow_bodyaskDate != null)
                {
                    body["ask_date"] = ExpressionConverter.ConvertO(__workflow_bodyaskDate);
                    bodypropCount++;
                }

                var askAmountObject = new JObject();
                var askAmountObjectpropCount = 0;
                if (__workflow_bodyaskAmountvalue != null)
                {
                    askAmountObject["value"] = ExpressionConverter.ConvertO(__workflow_bodyaskAmountvalue);
                    askAmountObjectpropCount++;
                }

                if (askAmountObjectpropCount > 0)
                {
                    body["ask_amount"] = askAmountObject;
                    bodypropCount++;
                }

                if (__workflow_bodyexpectedDate != null)
                {
                    body["expected_date"] = ExpressionConverter.ConvertO(__workflow_bodyexpectedDate);
                    bodypropCount++;
                }

                var expectedAmountObject = new JObject();
                var expectedAmountObjectpropCount = 0;
                if (__workflow_bodyexpectedAmountvalue != null)
                {
                    expectedAmountObject["value"] = ExpressionConverter.ConvertO(__workflow_bodyexpectedAmountvalue);
                    expectedAmountObjectpropCount++;
                }

                if (expectedAmountObjectpropCount > 0)
                {
                    body["expected_amount"] = expectedAmountObject;
                    bodypropCount++;
                }

                if (__workflow_bodyfundedDate != null)
                {
                    body["funded_date"] = ExpressionConverter.ConvertO(__workflow_bodyfundedDate);
                    bodypropCount++;
                }

                var fundedAmountObject = new JObject();
                var fundedAmountObjectpropCount = 0;
                if (__workflow_bodyfundedAmountvalue != null)
                {
                    fundedAmountObject["value"] = ExpressionConverter.ConvertO(__workflow_bodyfundedAmountvalue);
                    fundedAmountObjectpropCount++;
                }

                if (fundedAmountObjectpropCount > 0)
                {
                    body["funded_amount"] = fundedAmountObject;
                    bodypropCount++;
                }

                if (__workflow_bodycampaignId != null)
                {
                    body["campaign_id"] = ExpressionConverter.ConvertO(__workflow_bodycampaignId);
                    bodypropCount++;
                }

                if (__workflow_bodyfundId != null)
                {
                    body["fund_id"] = ExpressionConverter.ConvertO(__workflow_bodyfundId);
                    bodypropCount++;
                }

                if (__workflow_bodyfundraiserS != null)
                {
                    body["fundraisers"] = ExpressionConverter.ConvertO(__workflow_bodyfundraiserS);
                    bodypropCount++;
                }

                if (__workflow_bodyinactive != null)
                {
                    body["inactive"] = ExpressionConverter.ConvertO(__workflow_bodyinactive);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudprospects")]
        public IBodyWorkflowAction<OpportunityApiApiCollectionOfOpportunityAttachmentRead, ApiConnectionActionConfiguration> ListOpportunityAttachments(Expression<Func<string>> opportunityId)
        {
            var __workflow_opportunityId = WorkflowExpression.Compile(opportunityId, nameof(opportunityId), required: true);
            return new DeferredBodyAction<OpportunityApiApiCollectionOfOpportunityAttachmentRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/opportunity/v1/opportunities/{0}/attachments", __workflow_opportunityId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<OpportunityApiApiCollectionOfOpportunityAttachmentRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudprospects")]
        public IBodyWorkflowAction<OpportunityApiApiCollectionOfOpportunityCustomFieldRead, ApiConnectionActionConfiguration> ListOpportunityCustomFields(Expression<Func<string>> opportunityId)
        {
            var __workflow_opportunityId = WorkflowExpression.Compile(opportunityId, nameof(opportunityId), required: true);
            return new DeferredBodyAction<OpportunityApiApiCollectionOfOpportunityCustomFieldRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/opportunity/v1/opportunities/{0}/customfields", __workflow_opportunityId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<OpportunityApiApiCollectionOfOpportunityCustomFieldRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudprospects")]
        public IBodyWorkflowAction<OpportunityApiCreatedOpportunityAttachment, ApiConnectionActionConfiguration> CreateOpportunityAttachment(Expression<Func<string>> bodyopportunityId, Expression<Func<bodytypeInput>> bodytype, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodyuRL = null, Expression<Func<string>> bodyfileName = null, Expression<Func<string>> bodyfileId = null, Expression<Func<string>> bodythumbnailId = null, Expression<Func<string[]>> bodytags = null)
        {
            var __workflow_bodyopportunityId = WorkflowExpression.Compile(bodyopportunityId, nameof(bodyopportunityId), required: true);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodydate = WorkflowExpression.Compile(bodydate, nameof(bodydate), required: false);
            var __workflow_bodyuRL = WorkflowExpression.Compile(bodyuRL, nameof(bodyuRL), required: false);
            var __workflow_bodyfileName = WorkflowExpression.Compile(bodyfileName, nameof(bodyfileName), required: false);
            var __workflow_bodyfileId = WorkflowExpression.Compile(bodyfileId, nameof(bodyfileId), required: false);
            var __workflow_bodythumbnailId = WorkflowExpression.Compile(bodythumbnailId, nameof(bodythumbnailId), required: false);
            var __workflow_bodytags = WorkflowExpression.Compile(bodytags, nameof(bodytags), required: false);
            return new DeferredBodyAction<OpportunityApiCreatedOpportunityAttachment, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/opportunity/v1/opportunities/attachments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["parent_id"] = ExpressionConverter.ConvertO(__workflow_bodyopportunityId);
                bodypropCount++;
                body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodydate != null)
                {
                    body["date"] = ExpressionConverter.ConvertO(__workflow_bodydate);
                    bodypropCount++;
                }

                if (__workflow_bodyuRL != null)
                {
                    body["url"] = ExpressionConverter.ConvertO(__workflow_bodyuRL);
                    bodypropCount++;
                }

                if (__workflow_bodyfileName != null)
                {
                    body["file_name"] = ExpressionConverter.ConvertO(__workflow_bodyfileName);
                    bodypropCount++;
                }

                if (__workflow_bodyfileId != null)
                {
                    body["file_id"] = ExpressionConverter.ConvertO(__workflow_bodyfileId);
                    bodypropCount++;
                }

                if (__workflow_bodythumbnailId != null)
                {
                    body["thumbnail_id"] = ExpressionConverter.ConvertO(__workflow_bodythumbnailId);
                    bodypropCount++;
                }

                if (__workflow_bodytags != null)
                {
                    body["tags"] = ExpressionConverter.ConvertO(__workflow_bodytags);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<OpportunityApiCreatedOpportunityAttachment>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudprospects")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditOpportunityAttachment(Expression<Func<string>> attachmentId, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodyuRL = null, Expression<Func<string[]>> bodytags = null)
        {
            var __workflow_attachmentId = WorkflowExpression.Compile(attachmentId, nameof(attachmentId), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodydate = WorkflowExpression.Compile(bodydate, nameof(bodydate), required: false);
            var __workflow_bodyuRL = WorkflowExpression.Compile(bodyuRL, nameof(bodyuRL), required: false);
            var __workflow_bodytags = WorkflowExpression.Compile(bodytags, nameof(bodytags), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/opportunity/v1/opportunities/attachments/{0}", __workflow_attachmentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodydate != null)
                {
                    body["date"] = ExpressionConverter.ConvertO(__workflow_bodydate);
                    bodypropCount++;
                }

                if (__workflow_bodyuRL != null)
                {
                    body["url"] = ExpressionConverter.ConvertO(__workflow_bodyuRL);
                    bodypropCount++;
                }

                if (__workflow_bodytags != null)
                {
                    body["tags"] = ExpressionConverter.ConvertO(__workflow_bodytags);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudprospects")]
        public IBodyWorkflowAction<OpportunityApiCreatedOpportunityCustomField, ApiConnectionActionConfiguration> CreateOpportunityCustomField(Expression<Func<string>> bodyopportunityId, Expression<Func<string>> bodycategory, Expression<Func<object>> bodyvalue = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodycomment = null)
        {
            var __workflow_bodyopportunityId = WorkflowExpression.Compile(bodyopportunityId, nameof(bodyopportunityId), required: true);
            var __workflow_bodycategory = WorkflowExpression.Compile(bodycategory, nameof(bodycategory), required: true);
            var __workflow_bodyvalue = WorkflowExpression.Compile(bodyvalue, nameof(bodyvalue), required: false);
            var __workflow_bodydate = WorkflowExpression.Compile(bodydate, nameof(bodydate), required: false);
            var __workflow_bodycomment = WorkflowExpression.Compile(bodycomment, nameof(bodycomment), required: false);
            return new DeferredBodyAction<OpportunityApiCreatedOpportunityCustomField, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/opportunity/v1/opportunities/customfields";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["parent_id"] = ExpressionConverter.ConvertO(__workflow_bodyopportunityId);
                bodypropCount++;
                body["category"] = ExpressionConverter.ConvertO(__workflow_bodycategory);
                if (__workflow_bodyvalue != null)
                {
                    body["value"] = ExpressionConverter.ConvertO(__workflow_bodyvalue);
                    bodypropCount++;
                }

                if (__workflow_bodydate != null)
                {
                    body["date"] = ExpressionConverter.ConvertO(__workflow_bodydate);
                    bodypropCount++;
                }

                if (__workflow_bodycomment != null)
                {
                    body["comment"] = ExpressionConverter.ConvertO(__workflow_bodycomment);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<OpportunityApiCreatedOpportunityCustomField>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudprospects")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditOpportunityCustomField(Expression<Func<string>> customFieldId, Expression<Func<string>> bodycategory = null, Expression<Func<object>> bodyvalue = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodycomment = null)
        {
            var __workflow_customFieldId = WorkflowExpression.Compile(customFieldId, nameof(customFieldId), required: true);
            var __workflow_bodycategory = WorkflowExpression.Compile(bodycategory, nameof(bodycategory), required: false);
            var __workflow_bodyvalue = WorkflowExpression.Compile(bodyvalue, nameof(bodyvalue), required: false);
            var __workflow_bodydate = WorkflowExpression.Compile(bodydate, nameof(bodydate), required: false);
            var __workflow_bodycomment = WorkflowExpression.Compile(bodycomment, nameof(bodycomment), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/opportunity/v1/opportunities/customfields/{0}", __workflow_customFieldId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodycategory != null)
                {
                    body["category"] = ExpressionConverter.ConvertO(__workflow_bodycategory);
                    bodypropCount++;
                }

                if (__workflow_bodyvalue != null)
                {
                    body["value"] = ExpressionConverter.ConvertO(__workflow_bodyvalue);
                    bodypropCount++;
                }

                if (__workflow_bodydate != null)
                {
                    body["date"] = ExpressionConverter.ConvertO(__workflow_bodydate);
                    bodypropCount++;
                }

                if (__workflow_bodycomment != null)
                {
                    body["comment"] = ExpressionConverter.ConvertO(__workflow_bodycomment);
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

    public class BlackbaudprospectsTriggers([ConnectionName] string connectionId)
    {
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
        public string Id { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentId { get; set; }

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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    public class ConstituentApiCreatedConstituentRating
    {
        [JsonProperty("id")]
        public string Id { get; set; }
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
        public string Id { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentId { get; set; }

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
        public string CampaignId { get; set; }

        [JsonProperty("fund_id")]
        public string FundId { get; set; }

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
        public string ConstituentId { get; set; }

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
        public string Id { get; set; }
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
        public string Id { get; set; }

        [JsonProperty("parent_id")]
        public string OpportunityId { get; set; }

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
        public string FileId { get; set; }

        [JsonProperty("thumbnail_id")]
        public string ThumbnailId { get; set; }

        [JsonProperty("thumbnail_url")]
        public string ThumbnailURL { get; set; }

        [JsonProperty("content_type")]
        public string ContentType { get; set; }

        [JsonProperty("file_size")]
        public int FileSize { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
        public string Id { get; set; }

        [JsonProperty("parent_id")]
        public string OpportunityId { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("type")]
        public OpportunityApiOpportunityCustomFieldReadTypeType Type { get; set; }

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
        public string ConstituentIdValue { get; set; }

        [JsonProperty("fuzzydate_value")]
        public OpportunityApiOpportunityCustomFieldReadFuzzyDateValueType FuzzyDateValue { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    public class OpportunityApiOpportunityCustomFieldReadFuzzyDateValueType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class OpportunityApiCreatedOpportunityAttachment
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodytypeInput
    {
        Link,
        Physical
    }

    public class OpportunityApiCreatedOpportunityCustomField
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Blackbaudprospects;

    public partial class WorkflowManagedActions
    {
        public BlackbaudprospectsActions Blackbaudprospects(string connectionId) => new BlackbaudprospectsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public BlackbaudprospectsTriggers Blackbaudprospects(string connectionId) => new BlackbaudprospectsTriggers(connectionId);
    }
}