//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Blackbaudprospects
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BlackbaudprospectsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudprospects")]
        [WorkflowExpressionFactory(nameof(__BuildGetConstituentProspectStatus))]
        public IBodyWorkflowAction<ConstituentApiProspectStatusRead> GetConstituentProspectStatus([WorkflowExpression] Func<string> constituentId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ConstituentApiProspectStatusRead> __BuildGetConstituentProspectStatus(WorkflowValue<string> constituentId)
        {
            WorkflowValue.Validate(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<ConstituentApiProspectStatusRead>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/constituent/v1/constituents/{0}/prospectstatus", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConstituentApiProspectStatusRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudprospects")]
        [WorkflowExpressionFactory(nameof(__BuildListConstituentRatings))]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfRatingRead> ListConstituentRatings([WorkflowExpression] Func<string> constituentId, [WorkflowExpression] Func<bool> includeInactive = null, [WorkflowExpression] Func<bool> mostRecentOnly = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfRatingRead> __BuildListConstituentRatings(WorkflowValue<string> constituentId, WorkflowValue<bool> includeInactive = null, WorkflowValue<bool> mostRecentOnly = null)
        {
            WorkflowValue.Validate(constituentId, nameof(constituentId), required: true);
            WorkflowValue.Validate(includeInactive, nameof(includeInactive), required: false);
            WorkflowValue.Validate(mostRecentOnly, nameof(mostRecentOnly), required: false);
            return new DeferredBodyAction<ConstituentApiApiCollectionOfRatingRead>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/constituent/v1/constituents/{0}/ratings", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (includeInactive != null)
                    callPayload.Queries["include_inactive"] = ExpressionConverter.Convert(includeInactive);
                if (mostRecentOnly != null)
                    callPayload.Queries["most_recent_only"] = ExpressionConverter.Convert(mostRecentOnly);
                return new ApiConnectionAction<ConstituentApiApiCollectionOfRatingRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudprospects")]
        [WorkflowExpressionFactory(nameof(__BuildCreateConstituentRating))]
        public IBodyWorkflowAction<ConstituentApiCreatedConstituentRating> CreateConstituentRating([WorkflowExpression] Func<string> bodyconstituentID, [WorkflowExpression] Func<string> bodysource, [WorkflowExpression] Func<string> bodycategory, [WorkflowExpression] Func<string> bodydate, [WorkflowExpression] Func<object> bodyvalue = null, [WorkflowExpression] Func<string> bodycomments = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ConstituentApiCreatedConstituentRating> __BuildCreateConstituentRating(WorkflowValue<string> bodyconstituentID, WorkflowValue<string> bodysource, WorkflowValue<string> bodycategory, WorkflowValue<string> bodydate, WorkflowValue<object> bodyvalue = null, WorkflowValue<string> bodycomments = null)
        {
            WorkflowValue.Validate(bodyconstituentID, nameof(bodyconstituentID), required: true);
            WorkflowValue.Validate(bodysource, nameof(bodysource), required: true);
            WorkflowValue.Validate(bodycategory, nameof(bodycategory), required: true);
            WorkflowValue.Validate(bodydate, nameof(bodydate), required: true);
            WorkflowValue.Validate(bodyvalue, nameof(bodyvalue), required: false);
            WorkflowValue.Validate(bodycomments, nameof(bodycomments), required: false);
            return new DeferredBodyAction<ConstituentApiCreatedConstituentRating>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudprospects")]
        [WorkflowExpressionFactory(nameof(__BuildListOpportunities))]
        public IBodyWorkflowAction<OpportunityApiApiCollectionOfOpportunityRead> ListOpportunities([WorkflowExpression] Func<string> listId = null, [WorkflowExpression] Func<string> constituentId = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<bool> includeInactive = null, [WorkflowExpression] Func<string> dateAdded = null, [WorkflowExpression] Func<string> lastModified = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OpportunityApiApiCollectionOfOpportunityRead> __BuildListOpportunities(WorkflowValue<string> listId = null, WorkflowValue<string> constituentId = null, WorkflowValue<int> limit = null, WorkflowValue<int> offset = null, WorkflowValue<bool> includeInactive = null, WorkflowValue<string> dateAdded = null, WorkflowValue<string> lastModified = null)
        {
            WorkflowValue.Validate(listId, nameof(listId), required: false);
            WorkflowValue.Validate(constituentId, nameof(constituentId), required: false);
            WorkflowValue.Validate(limit, nameof(limit), required: false);
            WorkflowValue.Validate(offset, nameof(offset), required: false);
            WorkflowValue.Validate(includeInactive, nameof(includeInactive), required: false);
            WorkflowValue.Validate(dateAdded, nameof(dateAdded), required: false);
            WorkflowValue.Validate(lastModified, nameof(lastModified), required: false);
            return new DeferredBodyAction<OpportunityApiApiCollectionOfOpportunityRead>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudprospects")]
        [WorkflowExpressionFactory(nameof(__BuildCreateOpportunity))]
        public IBodyWorkflowAction<OpportunityApiCreatedOpportunity> CreateOpportunity([WorkflowExpression] Func<string> bodyconstituentID, [WorkflowExpression] Func<string> bodypurpose, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<string> bodydeadline = null, [WorkflowExpression] Func<string> bodyaskDate = null, [WorkflowExpression] Func<double> bodyaskAmountvalue = null, [WorkflowExpression] Func<string> bodyexpectedDate = null, [WorkflowExpression] Func<double> bodyexpectedAmountvalue = null, [WorkflowExpression] Func<string> bodyfundedDate = null, [WorkflowExpression] Func<double> bodyfundedAmountvalue = null, [WorkflowExpression] Func<string> bodycampaignID = null, [WorkflowExpression] Func<string> bodyfundID = null, [WorkflowExpression] Func<OpportunityApiFundraiser[]> bodyfundraiserS = null, [WorkflowExpression] Func<bool> bodyinactive = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OpportunityApiCreatedOpportunity> __BuildCreateOpportunity(WorkflowValue<string> bodyconstituentID, WorkflowValue<string> bodypurpose, WorkflowValue<string> bodyname, WorkflowValue<string> bodystatus = null, WorkflowValue<string> bodydeadline = null, WorkflowValue<string> bodyaskDate = null, WorkflowValue<double> bodyaskAmountvalue = null, WorkflowValue<string> bodyexpectedDate = null, WorkflowValue<double> bodyexpectedAmountvalue = null, WorkflowValue<string> bodyfundedDate = null, WorkflowValue<double> bodyfundedAmountvalue = null, WorkflowValue<string> bodycampaignID = null, WorkflowValue<string> bodyfundID = null, WorkflowValue<OpportunityApiFundraiser[]> bodyfundraiserS = null, WorkflowValue<bool> bodyinactive = null)
        {
            WorkflowValue.Validate(bodyconstituentID, nameof(bodyconstituentID), required: true);
            WorkflowValue.Validate(bodypurpose, nameof(bodypurpose), required: true);
            WorkflowValue.Validate(bodyname, nameof(bodyname), required: true);
            WorkflowValue.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowValue.Validate(bodydeadline, nameof(bodydeadline), required: false);
            WorkflowValue.Validate(bodyaskDate, nameof(bodyaskDate), required: false);
            WorkflowValue.Validate(bodyaskAmountvalue, nameof(bodyaskAmountvalue), required: false);
            WorkflowValue.Validate(bodyexpectedDate, nameof(bodyexpectedDate), required: false);
            WorkflowValue.Validate(bodyexpectedAmountvalue, nameof(bodyexpectedAmountvalue), required: false);
            WorkflowValue.Validate(bodyfundedDate, nameof(bodyfundedDate), required: false);
            WorkflowValue.Validate(bodyfundedAmountvalue, nameof(bodyfundedAmountvalue), required: false);
            WorkflowValue.Validate(bodycampaignID, nameof(bodycampaignID), required: false);
            WorkflowValue.Validate(bodyfundID, nameof(bodyfundID), required: false);
            WorkflowValue.Validate(bodyfundraiserS, nameof(bodyfundraiserS), required: false);
            WorkflowValue.Validate(bodyinactive, nameof(bodyinactive), required: false);
            return new DeferredBodyAction<OpportunityApiCreatedOpportunity>(() =>
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

                var askAmountObject = new JObject();
                var askAmountObjectpropCount = 0;
                if (bodyaskAmountvalue != null)
                {
                    askAmountObject["value"] = ExpressionConverter.ConvertO(bodyaskAmountvalue);
                    askAmountObjectpropCount++;
                }

                if (askAmountObjectpropCount > 0)
                {
                    body["ask_amount"] = askAmountObject;
                    bodypropCount++;
                }

                if (bodyexpectedDate != null)
                {
                    body["expected_date"] = ExpressionConverter.ConvertO(bodyexpectedDate);
                    bodypropCount++;
                }

                var expectedAmountObject = new JObject();
                var expectedAmountObjectpropCount = 0;
                if (bodyexpectedAmountvalue != null)
                {
                    expectedAmountObject["value"] = ExpressionConverter.ConvertO(bodyexpectedAmountvalue);
                    expectedAmountObjectpropCount++;
                }

                if (expectedAmountObjectpropCount > 0)
                {
                    body["expected_amount"] = expectedAmountObject;
                    bodypropCount++;
                }

                if (bodyfundedDate != null)
                {
                    body["funded_date"] = ExpressionConverter.ConvertO(bodyfundedDate);
                    bodypropCount++;
                }

                var fundedAmountObject = new JObject();
                var fundedAmountObjectpropCount = 0;
                if (bodyfundedAmountvalue != null)
                {
                    fundedAmountObject["value"] = ExpressionConverter.ConvertO(bodyfundedAmountvalue);
                    fundedAmountObjectpropCount++;
                }

                if (fundedAmountObjectpropCount > 0)
                {
                    body["funded_amount"] = fundedAmountObject;
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudprospects")]
        [WorkflowExpressionFactory(nameof(__BuildGetOpportunity))]
        public IBodyWorkflowAction<OpportunityApiOpportunityRead> GetOpportunity([WorkflowExpression] Func<string> opportunityId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OpportunityApiOpportunityRead> __BuildGetOpportunity(WorkflowValue<string> opportunityId)
        {
            WorkflowValue.Validate(opportunityId, nameof(opportunityId), required: true);
            return new DeferredBodyAction<OpportunityApiOpportunityRead>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/opportunity/v1/opportunities/{0}", ExpressionConverter.ConvertWithUrlEncoding(opportunityId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<OpportunityApiOpportunityRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudprospects")]
        [WorkflowExpressionFactory(nameof(__BuildEditOpportunity))]
        public IWorkflowAction EditOpportunity([WorkflowExpression] Func<string> opportunityId, [WorkflowExpression] Func<string> bodypurpose = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<string> bodydeadline = null, [WorkflowExpression] Func<string> bodyaskDate = null, [WorkflowExpression] Func<double> bodyaskAmountvalue = null, [WorkflowExpression] Func<string> bodyexpectedDate = null, [WorkflowExpression] Func<double> bodyexpectedAmountvalue = null, [WorkflowExpression] Func<string> bodyfundedDate = null, [WorkflowExpression] Func<double> bodyfundedAmountvalue = null, [WorkflowExpression] Func<string> bodycampaignID = null, [WorkflowExpression] Func<string> bodyfundID = null, [WorkflowExpression] Func<OpportunityApiFundraiser[]> bodyfundraiserS = null, [WorkflowExpression] Func<bool> bodyinactive = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildEditOpportunity(WorkflowValue<string> opportunityId, WorkflowValue<string> bodypurpose = null, WorkflowValue<string> bodyname = null, WorkflowValue<string> bodystatus = null, WorkflowValue<string> bodydeadline = null, WorkflowValue<string> bodyaskDate = null, WorkflowValue<double> bodyaskAmountvalue = null, WorkflowValue<string> bodyexpectedDate = null, WorkflowValue<double> bodyexpectedAmountvalue = null, WorkflowValue<string> bodyfundedDate = null, WorkflowValue<double> bodyfundedAmountvalue = null, WorkflowValue<string> bodycampaignID = null, WorkflowValue<string> bodyfundID = null, WorkflowValue<OpportunityApiFundraiser[]> bodyfundraiserS = null, WorkflowValue<bool> bodyinactive = null)
        {
            WorkflowValue.Validate(opportunityId, nameof(opportunityId), required: true);
            WorkflowValue.Validate(bodypurpose, nameof(bodypurpose), required: false);
            WorkflowValue.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowValue.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowValue.Validate(bodydeadline, nameof(bodydeadline), required: false);
            WorkflowValue.Validate(bodyaskDate, nameof(bodyaskDate), required: false);
            WorkflowValue.Validate(bodyaskAmountvalue, nameof(bodyaskAmountvalue), required: false);
            WorkflowValue.Validate(bodyexpectedDate, nameof(bodyexpectedDate), required: false);
            WorkflowValue.Validate(bodyexpectedAmountvalue, nameof(bodyexpectedAmountvalue), required: false);
            WorkflowValue.Validate(bodyfundedDate, nameof(bodyfundedDate), required: false);
            WorkflowValue.Validate(bodyfundedAmountvalue, nameof(bodyfundedAmountvalue), required: false);
            WorkflowValue.Validate(bodycampaignID, nameof(bodycampaignID), required: false);
            WorkflowValue.Validate(bodyfundID, nameof(bodyfundID), required: false);
            WorkflowValue.Validate(bodyfundraiserS, nameof(bodyfundraiserS), required: false);
            WorkflowValue.Validate(bodyinactive, nameof(bodyinactive), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/opportunity/v1/opportunities/{0}", ExpressionConverter.ConvertWithUrlEncoding(opportunityId, 1));
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

                var askAmountObject = new JObject();
                var askAmountObjectpropCount = 0;
                if (bodyaskAmountvalue != null)
                {
                    askAmountObject["value"] = ExpressionConverter.ConvertO(bodyaskAmountvalue);
                    askAmountObjectpropCount++;
                }

                if (askAmountObjectpropCount > 0)
                {
                    body["ask_amount"] = askAmountObject;
                    bodypropCount++;
                }

                if (bodyexpectedDate != null)
                {
                    body["expected_date"] = ExpressionConverter.ConvertO(bodyexpectedDate);
                    bodypropCount++;
                }

                var expectedAmountObject = new JObject();
                var expectedAmountObjectpropCount = 0;
                if (bodyexpectedAmountvalue != null)
                {
                    expectedAmountObject["value"] = ExpressionConverter.ConvertO(bodyexpectedAmountvalue);
                    expectedAmountObjectpropCount++;
                }

                if (expectedAmountObjectpropCount > 0)
                {
                    body["expected_amount"] = expectedAmountObject;
                    bodypropCount++;
                }

                if (bodyfundedDate != null)
                {
                    body["funded_date"] = ExpressionConverter.ConvertO(bodyfundedDate);
                    bodypropCount++;
                }

                var fundedAmountObject = new JObject();
                var fundedAmountObjectpropCount = 0;
                if (bodyfundedAmountvalue != null)
                {
                    fundedAmountObject["value"] = ExpressionConverter.ConvertO(bodyfundedAmountvalue);
                    fundedAmountObjectpropCount++;
                }

                if (fundedAmountObjectpropCount > 0)
                {
                    body["funded_amount"] = fundedAmountObject;
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudprospects")]
        [WorkflowExpressionFactory(nameof(__BuildListOpportunityAttachments))]
        public IBodyWorkflowAction<OpportunityApiApiCollectionOfOpportunityAttachmentRead> ListOpportunityAttachments([WorkflowExpression] Func<string> opportunityId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OpportunityApiApiCollectionOfOpportunityAttachmentRead> __BuildListOpportunityAttachments(WorkflowValue<string> opportunityId)
        {
            WorkflowValue.Validate(opportunityId, nameof(opportunityId), required: true);
            return new DeferredBodyAction<OpportunityApiApiCollectionOfOpportunityAttachmentRead>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/opportunity/v1/opportunities/{0}/attachments", ExpressionConverter.ConvertWithUrlEncoding(opportunityId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<OpportunityApiApiCollectionOfOpportunityAttachmentRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudprospects")]
        [WorkflowExpressionFactory(nameof(__BuildListOpportunityCustomFields))]
        public IBodyWorkflowAction<OpportunityApiApiCollectionOfOpportunityCustomFieldRead> ListOpportunityCustomFields([WorkflowExpression] Func<string> opportunityId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OpportunityApiApiCollectionOfOpportunityCustomFieldRead> __BuildListOpportunityCustomFields(WorkflowValue<string> opportunityId)
        {
            WorkflowValue.Validate(opportunityId, nameof(opportunityId), required: true);
            return new DeferredBodyAction<OpportunityApiApiCollectionOfOpportunityCustomFieldRead>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/opportunity/v1/opportunities/{0}/customfields", ExpressionConverter.ConvertWithUrlEncoding(opportunityId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<OpportunityApiApiCollectionOfOpportunityCustomFieldRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudprospects")]
        [WorkflowExpressionFactory(nameof(__BuildCreateOpportunityAttachment))]
        public IBodyWorkflowAction<OpportunityApiCreatedOpportunityAttachment> CreateOpportunityAttachment([WorkflowExpression] Func<string> bodyopportunityID, [WorkflowExpression] Func<bodytypeInput> bodytype, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<string> bodyuRL = null, [WorkflowExpression] Func<string> bodyfileName = null, [WorkflowExpression] Func<string> bodyfileID = null, [WorkflowExpression] Func<string> bodythumbnailID = null, [WorkflowExpression] Func<string[]> bodytags = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OpportunityApiCreatedOpportunityAttachment> __BuildCreateOpportunityAttachment(WorkflowValue<string> bodyopportunityID, WorkflowValue<bodytypeInput> bodytype, WorkflowValue<string> bodyname = null, WorkflowValue<string> bodydate = null, WorkflowValue<string> bodyuRL = null, WorkflowValue<string> bodyfileName = null, WorkflowValue<string> bodyfileID = null, WorkflowValue<string> bodythumbnailID = null, WorkflowValue<string[]> bodytags = null)
        {
            WorkflowValue.Validate(bodyopportunityID, nameof(bodyopportunityID), required: true);
            WorkflowValue.Validate(bodytype, nameof(bodytype), required: true);
            WorkflowValue.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowValue.Validate(bodydate, nameof(bodydate), required: false);
            WorkflowValue.Validate(bodyuRL, nameof(bodyuRL), required: false);
            WorkflowValue.Validate(bodyfileName, nameof(bodyfileName), required: false);
            WorkflowValue.Validate(bodyfileID, nameof(bodyfileID), required: false);
            WorkflowValue.Validate(bodythumbnailID, nameof(bodythumbnailID), required: false);
            WorkflowValue.Validate(bodytags, nameof(bodytags), required: false);
            return new DeferredBodyAction<OpportunityApiCreatedOpportunityAttachment>(() =>
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

                if (bodytags != null)
                {
                    body["tags"] = ExpressionConverter.ConvertO(bodytags);
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
        [WorkflowExpressionFactory(nameof(__BuildEditOpportunityAttachment))]
        public IWorkflowAction EditOpportunityAttachment([WorkflowExpression] Func<string> attachmentId, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<string> bodyuRL = null, [WorkflowExpression] Func<string[]> bodytags = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildEditOpportunityAttachment(WorkflowValue<string> attachmentId, WorkflowValue<string> bodyname = null, WorkflowValue<string> bodydate = null, WorkflowValue<string> bodyuRL = null, WorkflowValue<string[]> bodytags = null)
        {
            WorkflowValue.Validate(attachmentId, nameof(attachmentId), required: true);
            WorkflowValue.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowValue.Validate(bodydate, nameof(bodydate), required: false);
            WorkflowValue.Validate(bodyuRL, nameof(bodyuRL), required: false);
            WorkflowValue.Validate(bodytags, nameof(bodytags), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/opportunity/v1/opportunities/attachments/{0}", ExpressionConverter.ConvertWithUrlEncoding(attachmentId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudprospects")]
        [WorkflowExpressionFactory(nameof(__BuildCreateOpportunityCustomField))]
        public IBodyWorkflowAction<OpportunityApiCreatedOpportunityCustomField> CreateOpportunityCustomField([WorkflowExpression] Func<string> bodyopportunityID, [WorkflowExpression] Func<string> bodycategory, [WorkflowExpression] Func<object> bodyvalue = null, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<string> bodycomment = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OpportunityApiCreatedOpportunityCustomField> __BuildCreateOpportunityCustomField(WorkflowValue<string> bodyopportunityID, WorkflowValue<string> bodycategory, WorkflowValue<object> bodyvalue = null, WorkflowValue<string> bodydate = null, WorkflowValue<string> bodycomment = null)
        {
            WorkflowValue.Validate(bodyopportunityID, nameof(bodyopportunityID), required: true);
            WorkflowValue.Validate(bodycategory, nameof(bodycategory), required: true);
            WorkflowValue.Validate(bodyvalue, nameof(bodyvalue), required: false);
            WorkflowValue.Validate(bodydate, nameof(bodydate), required: false);
            WorkflowValue.Validate(bodycomment, nameof(bodycomment), required: false);
            return new DeferredBodyAction<OpportunityApiCreatedOpportunityCustomField>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudprospects")]
        [WorkflowExpressionFactory(nameof(__BuildEditOpportunityCustomField))]
        public IWorkflowAction EditOpportunityCustomField([WorkflowExpression] Func<string> customFieldId, [WorkflowExpression] Func<string> bodycategory = null, [WorkflowExpression] Func<object> bodyvalue = null, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<string> bodycomment = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildEditOpportunityCustomField(WorkflowValue<string> customFieldId, WorkflowValue<string> bodycategory = null, WorkflowValue<object> bodyvalue = null, WorkflowValue<string> bodydate = null, WorkflowValue<string> bodycomment = null)
        {
            WorkflowValue.Validate(customFieldId, nameof(customFieldId), required: true);
            WorkflowValue.Validate(bodycategory, nameof(bodycategory), required: false);
            WorkflowValue.Validate(bodyvalue, nameof(bodyvalue), required: false);
            WorkflowValue.Validate(bodydate, nameof(bodydate), required: false);
            WorkflowValue.Validate(bodycomment, nameof(bodycomment), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/opportunity/v1/opportunities/customfields/{0}", ExpressionConverter.ConvertWithUrlEncoding(customFieldId, 1));
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

    public class ConstituentApiCreatedConstituentRating
    {
        [JsonProperty("id")]
        public string ID { get; set; }
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

        [JsonProperty("tags")]
        public string[] Tags { get; set; }
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
        public string ID { get; set; }
    }

    public enum bodytypeInput
    {
        Link,
        Physical
    }

    public class OpportunityApiCreatedOpportunityCustomField
    {
        [JsonProperty("id")]
        public string ID { get; set; }
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
