//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Blackbaudprospects
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BlackbaudprospectsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudprospects")]
        public IBodyWorkflowAction<ConstituentApiProspectStatusRead> GetConstituentProspectStatus([WorkflowExpression] Func<string> constituentId)
        {
            SourceExpression.Validate(constituentId, nameof(constituentId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/constituent/v1/constituents/{0}/prospectstatus", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiProspectStatusRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudprospects")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfRatingRead> ListConstituentRatings([WorkflowExpression] Func<string> constituentId, [WorkflowExpression] Func<bool> includeInactive = null, [WorkflowExpression] Func<bool> mostRecentOnly = null)
        {
            SourceExpression.Validate(constituentId, nameof(constituentId), required: true);
            SourceExpression.Validate(includeInactive, nameof(includeInactive), required: false);
            SourceExpression.Validate(mostRecentOnly, nameof(mostRecentOnly), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/constituent/v1/constituents/{0}/ratings", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (includeInactive != null)
                    callPayload.Queries["include_inactive"] = SourceExpressionConverter.ConvertO(includeInactive);
                if (mostRecentOnly != null)
                    callPayload.Queries["most_recent_only"] = SourceExpressionConverter.ConvertO(mostRecentOnly);
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiApiCollectionOfRatingRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudprospects")]
        public IBodyWorkflowAction<ConstituentApiCreatedConstituentRating> CreateConstituentRating([WorkflowExpression] Func<string> bodyconstituentID, [WorkflowExpression] Func<string> bodysource, [WorkflowExpression] Func<string> bodycategory, [WorkflowExpression] Func<string> bodydate, [WorkflowExpression] Func<object> bodyvalue = null, [WorkflowExpression] Func<string> bodycomments = null)
        {
            SourceExpression.Validate(bodyconstituentID, nameof(bodyconstituentID), required: true);
            SourceExpression.Validate(bodysource, nameof(bodysource), required: true);
            SourceExpression.Validate(bodycategory, nameof(bodycategory), required: true);
            SourceExpression.Validate(bodydate, nameof(bodydate), required: true);
            SourceExpression.Validate(bodyvalue, nameof(bodyvalue), required: false);
            SourceExpression.Validate(bodycomments, nameof(bodycomments), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/constituent/v1/ratings";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = SourceExpressionConverter.ConvertToken(bodyconstituentID);
                bodypropCount++;
                body["source"] = SourceExpressionConverter.ConvertToken(bodysource);
                bodypropCount++;
                body["category"] = SourceExpressionConverter.ConvertToken(bodycategory);
                bodypropCount++;
                body["date"] = SourceExpressionConverter.ConvertToken(bodydate);
                if (bodyvalue != null)
                {
                    body["value"] = SourceExpressionConverter.ConvertToken(bodyvalue);
                    bodypropCount++;
                }

                if (bodycomments != null)
                {
                    body["comment"] = SourceExpressionConverter.ConvertToken(bodycomments);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiCreatedConstituentRating>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudprospects")]
        public IBodyWorkflowAction<OpportunityApiApiCollectionOfOpportunityRead> ListOpportunities([WorkflowExpression] Func<string> listId = null, [WorkflowExpression] Func<string> constituentId = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<bool> includeInactive = null, [WorkflowExpression] Func<string> dateAdded = null, [WorkflowExpression] Func<string> lastModified = null)
        {
            SourceExpression.Validate(listId, nameof(listId), required: false);
            SourceExpression.Validate(constituentId, nameof(constituentId), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(offset, nameof(offset), required: false);
            SourceExpression.Validate(includeInactive, nameof(includeInactive), required: false);
            SourceExpression.Validate(dateAdded, nameof(dateAdded), required: false);
            SourceExpression.Validate(lastModified, nameof(lastModified), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/opportunity/v1/opportunities";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (listId != null)
                    callPayload.Queries["list_id"] = SourceExpressionConverter.ConvertO(listId);
                if (constituentId != null)
                    callPayload.Queries["constituent_id"] = SourceExpressionConverter.ConvertO(constituentId);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                if (includeInactive != null)
                    callPayload.Queries["include_inactive"] = SourceExpressionConverter.ConvertO(includeInactive);
                if (dateAdded != null)
                    callPayload.Queries["date_added"] = SourceExpressionConverter.ConvertO(dateAdded);
                if (lastModified != null)
                    callPayload.Queries["last_modified"] = SourceExpressionConverter.ConvertO(lastModified);
                return callPayload;
            }

            return new ApiConnectionAction<OpportunityApiApiCollectionOfOpportunityRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudprospects")]
        public IBodyWorkflowAction<OpportunityApiCreatedOpportunity> CreateOpportunity([WorkflowExpression] Func<string> bodyconstituentID, [WorkflowExpression] Func<string> bodypurpose, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<string> bodydeadline = null, [WorkflowExpression] Func<string> bodyaskDate = null, [WorkflowExpression] Func<double> bodyaskAmountvalue = null, [WorkflowExpression] Func<string> bodyexpectedDate = null, [WorkflowExpression] Func<double> bodyexpectedAmountvalue = null, [WorkflowExpression] Func<string> bodyfundedDate = null, [WorkflowExpression] Func<double> bodyfundedAmountvalue = null, [WorkflowExpression] Func<string> bodycampaignID = null, [WorkflowExpression] Func<string> bodyfundID = null, [WorkflowExpression] Func<OpportunityApiFundraiser[]> bodyfundraiserS = null, [WorkflowExpression] Func<bool> bodyinactive = null)
        {
            SourceExpression.Validate(bodyconstituentID, nameof(bodyconstituentID), required: true);
            SourceExpression.Validate(bodypurpose, nameof(bodypurpose), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            SourceExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            SourceExpression.Validate(bodydeadline, nameof(bodydeadline), required: false);
            SourceExpression.Validate(bodyaskDate, nameof(bodyaskDate), required: false);
            SourceExpression.Validate(bodyaskAmountvalue, nameof(bodyaskAmountvalue), required: false);
            SourceExpression.Validate(bodyexpectedDate, nameof(bodyexpectedDate), required: false);
            SourceExpression.Validate(bodyexpectedAmountvalue, nameof(bodyexpectedAmountvalue), required: false);
            SourceExpression.Validate(bodyfundedDate, nameof(bodyfundedDate), required: false);
            SourceExpression.Validate(bodyfundedAmountvalue, nameof(bodyfundedAmountvalue), required: false);
            SourceExpression.Validate(bodycampaignID, nameof(bodycampaignID), required: false);
            SourceExpression.Validate(bodyfundID, nameof(bodyfundID), required: false);
            SourceExpression.Validate(bodyfundraiserS, nameof(bodyfundraiserS), required: false);
            SourceExpression.Validate(bodyinactive, nameof(bodyinactive), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/opportunity/v1/opportunities";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = SourceExpressionConverter.ConvertToken(bodyconstituentID);
                bodypropCount++;
                body["purpose"] = SourceExpressionConverter.ConvertToken(bodypurpose);
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                if (bodydeadline != null)
                {
                    body["deadline"] = SourceExpressionConverter.ConvertToken(bodydeadline);
                    bodypropCount++;
                }

                if (bodyaskDate != null)
                {
                    body["ask_date"] = SourceExpressionConverter.ConvertToken(bodyaskDate);
                    bodypropCount++;
                }

                var askAmountObject = new JObject();
                var askAmountObjectpropCount = 0;
                if (bodyaskAmountvalue != null)
                {
                    askAmountObject["value"] = SourceExpressionConverter.ConvertToken(bodyaskAmountvalue);
                    askAmountObjectpropCount++;
                }

                if (askAmountObjectpropCount > 0)
                {
                    body["ask_amount"] = askAmountObject;
                    bodypropCount++;
                }

                if (bodyexpectedDate != null)
                {
                    body["expected_date"] = SourceExpressionConverter.ConvertToken(bodyexpectedDate);
                    bodypropCount++;
                }

                var expectedAmountObject = new JObject();
                var expectedAmountObjectpropCount = 0;
                if (bodyexpectedAmountvalue != null)
                {
                    expectedAmountObject["value"] = SourceExpressionConverter.ConvertToken(bodyexpectedAmountvalue);
                    expectedAmountObjectpropCount++;
                }

                if (expectedAmountObjectpropCount > 0)
                {
                    body["expected_amount"] = expectedAmountObject;
                    bodypropCount++;
                }

                if (bodyfundedDate != null)
                {
                    body["funded_date"] = SourceExpressionConverter.ConvertToken(bodyfundedDate);
                    bodypropCount++;
                }

                var fundedAmountObject = new JObject();
                var fundedAmountObjectpropCount = 0;
                if (bodyfundedAmountvalue != null)
                {
                    fundedAmountObject["value"] = SourceExpressionConverter.ConvertToken(bodyfundedAmountvalue);
                    fundedAmountObjectpropCount++;
                }

                if (fundedAmountObjectpropCount > 0)
                {
                    body["funded_amount"] = fundedAmountObject;
                    bodypropCount++;
                }

                if (bodycampaignID != null)
                {
                    body["campaign_id"] = SourceExpressionConverter.ConvertToken(bodycampaignID);
                    bodypropCount++;
                }

                if (bodyfundID != null)
                {
                    body["fund_id"] = SourceExpressionConverter.ConvertToken(bodyfundID);
                    bodypropCount++;
                }

                if (bodyfundraiserS != null)
                {
                    body["fundraisers"] = SourceExpressionConverter.ConvertToken(bodyfundraiserS);
                    bodypropCount++;
                }

                if (bodyinactive != null)
                {
                    body["inactive"] = SourceExpressionConverter.ConvertToken(bodyinactive);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<OpportunityApiCreatedOpportunity>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudprospects")]
        public IBodyWorkflowAction<OpportunityApiOpportunityRead> GetOpportunity([WorkflowExpression] Func<string> opportunityId)
        {
            SourceExpression.Validate(opportunityId, nameof(opportunityId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/opportunity/v1/opportunities/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(opportunityId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<OpportunityApiOpportunityRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudprospects")]
        public IWorkflowAction EditOpportunity([WorkflowExpression] Func<string> opportunityId, [WorkflowExpression] Func<string> bodypurpose = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<string> bodydeadline = null, [WorkflowExpression] Func<string> bodyaskDate = null, [WorkflowExpression] Func<double> bodyaskAmountvalue = null, [WorkflowExpression] Func<string> bodyexpectedDate = null, [WorkflowExpression] Func<double> bodyexpectedAmountvalue = null, [WorkflowExpression] Func<string> bodyfundedDate = null, [WorkflowExpression] Func<double> bodyfundedAmountvalue = null, [WorkflowExpression] Func<string> bodycampaignID = null, [WorkflowExpression] Func<string> bodyfundID = null, [WorkflowExpression] Func<OpportunityApiFundraiser[]> bodyfundraiserS = null, [WorkflowExpression] Func<bool> bodyinactive = null)
        {
            SourceExpression.Validate(opportunityId, nameof(opportunityId), required: true);
            SourceExpression.Validate(bodypurpose, nameof(bodypurpose), required: false);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            SourceExpression.Validate(bodydeadline, nameof(bodydeadline), required: false);
            SourceExpression.Validate(bodyaskDate, nameof(bodyaskDate), required: false);
            SourceExpression.Validate(bodyaskAmountvalue, nameof(bodyaskAmountvalue), required: false);
            SourceExpression.Validate(bodyexpectedDate, nameof(bodyexpectedDate), required: false);
            SourceExpression.Validate(bodyexpectedAmountvalue, nameof(bodyexpectedAmountvalue), required: false);
            SourceExpression.Validate(bodyfundedDate, nameof(bodyfundedDate), required: false);
            SourceExpression.Validate(bodyfundedAmountvalue, nameof(bodyfundedAmountvalue), required: false);
            SourceExpression.Validate(bodycampaignID, nameof(bodycampaignID), required: false);
            SourceExpression.Validate(bodyfundID, nameof(bodyfundID), required: false);
            SourceExpression.Validate(bodyfundraiserS, nameof(bodyfundraiserS), required: false);
            SourceExpression.Validate(bodyinactive, nameof(bodyinactive), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/opportunity/v1/opportunities/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(opportunityId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypurpose != null)
                {
                    body["purpose"] = SourceExpressionConverter.ConvertToken(bodypurpose);
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                if (bodydeadline != null)
                {
                    body["deadline"] = SourceExpressionConverter.ConvertToken(bodydeadline);
                    bodypropCount++;
                }

                if (bodyaskDate != null)
                {
                    body["ask_date"] = SourceExpressionConverter.ConvertToken(bodyaskDate);
                    bodypropCount++;
                }

                var askAmountObject = new JObject();
                var askAmountObjectpropCount = 0;
                if (bodyaskAmountvalue != null)
                {
                    askAmountObject["value"] = SourceExpressionConverter.ConvertToken(bodyaskAmountvalue);
                    askAmountObjectpropCount++;
                }

                if (askAmountObjectpropCount > 0)
                {
                    body["ask_amount"] = askAmountObject;
                    bodypropCount++;
                }

                if (bodyexpectedDate != null)
                {
                    body["expected_date"] = SourceExpressionConverter.ConvertToken(bodyexpectedDate);
                    bodypropCount++;
                }

                var expectedAmountObject = new JObject();
                var expectedAmountObjectpropCount = 0;
                if (bodyexpectedAmountvalue != null)
                {
                    expectedAmountObject["value"] = SourceExpressionConverter.ConvertToken(bodyexpectedAmountvalue);
                    expectedAmountObjectpropCount++;
                }

                if (expectedAmountObjectpropCount > 0)
                {
                    body["expected_amount"] = expectedAmountObject;
                    bodypropCount++;
                }

                if (bodyfundedDate != null)
                {
                    body["funded_date"] = SourceExpressionConverter.ConvertToken(bodyfundedDate);
                    bodypropCount++;
                }

                var fundedAmountObject = new JObject();
                var fundedAmountObjectpropCount = 0;
                if (bodyfundedAmountvalue != null)
                {
                    fundedAmountObject["value"] = SourceExpressionConverter.ConvertToken(bodyfundedAmountvalue);
                    fundedAmountObjectpropCount++;
                }

                if (fundedAmountObjectpropCount > 0)
                {
                    body["funded_amount"] = fundedAmountObject;
                    bodypropCount++;
                }

                if (bodycampaignID != null)
                {
                    body["campaign_id"] = SourceExpressionConverter.ConvertToken(bodycampaignID);
                    bodypropCount++;
                }

                if (bodyfundID != null)
                {
                    body["fund_id"] = SourceExpressionConverter.ConvertToken(bodyfundID);
                    bodypropCount++;
                }

                if (bodyfundraiserS != null)
                {
                    body["fundraisers"] = SourceExpressionConverter.ConvertToken(bodyfundraiserS);
                    bodypropCount++;
                }

                if (bodyinactive != null)
                {
                    body["inactive"] = SourceExpressionConverter.ConvertToken(bodyinactive);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudprospects")]
        public IBodyWorkflowAction<OpportunityApiApiCollectionOfOpportunityAttachmentRead> ListOpportunityAttachments([WorkflowExpression] Func<string> opportunityId)
        {
            SourceExpression.Validate(opportunityId, nameof(opportunityId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/opportunity/v1/opportunities/{0}/attachments", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(opportunityId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<OpportunityApiApiCollectionOfOpportunityAttachmentRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudprospects")]
        public IBodyWorkflowAction<OpportunityApiApiCollectionOfOpportunityCustomFieldRead> ListOpportunityCustomFields([WorkflowExpression] Func<string> opportunityId)
        {
            SourceExpression.Validate(opportunityId, nameof(opportunityId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/opportunity/v1/opportunities/{0}/customfields", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(opportunityId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<OpportunityApiApiCollectionOfOpportunityCustomFieldRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudprospects")]
        public IBodyWorkflowAction<OpportunityApiCreatedOpportunityAttachment> CreateOpportunityAttachment([WorkflowExpression] Func<string> bodyopportunityID, [WorkflowExpression] Func<bodytypeInput> bodytype, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<string> bodyuRL = null, [WorkflowExpression] Func<string> bodyfileName = null, [WorkflowExpression] Func<string> bodyfileID = null, [WorkflowExpression] Func<string> bodythumbnailID = null, [WorkflowExpression] Func<string[]> bodytags = null)
        {
            SourceExpression.Validate(bodyopportunityID, nameof(bodyopportunityID), required: true);
            SourceExpression.Validate(bodytype, nameof(bodytype), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodydate, nameof(bodydate), required: false);
            SourceExpression.Validate(bodyuRL, nameof(bodyuRL), required: false);
            SourceExpression.Validate(bodyfileName, nameof(bodyfileName), required: false);
            SourceExpression.Validate(bodyfileID, nameof(bodyfileID), required: false);
            SourceExpression.Validate(bodythumbnailID, nameof(bodythumbnailID), required: false);
            SourceExpression.Validate(bodytags, nameof(bodytags), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/opportunity/v1/opportunities/attachments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["parent_id"] = SourceExpressionConverter.ConvertToken(bodyopportunityID);
                bodypropCount++;
                body["type"] = SourceExpressionConverter.Convert(bodytype);
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodydate != null)
                {
                    body["date"] = SourceExpressionConverter.ConvertToken(bodydate);
                    bodypropCount++;
                }

                if (bodyuRL != null)
                {
                    body["url"] = SourceExpressionConverter.ConvertToken(bodyuRL);
                    bodypropCount++;
                }

                if (bodyfileName != null)
                {
                    body["file_name"] = SourceExpressionConverter.ConvertToken(bodyfileName);
                    bodypropCount++;
                }

                if (bodyfileID != null)
                {
                    body["file_id"] = SourceExpressionConverter.ConvertToken(bodyfileID);
                    bodypropCount++;
                }

                if (bodythumbnailID != null)
                {
                    body["thumbnail_id"] = SourceExpressionConverter.ConvertToken(bodythumbnailID);
                    bodypropCount++;
                }

                if (bodytags != null)
                {
                    body["tags"] = SourceExpressionConverter.ConvertToken(bodytags);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<OpportunityApiCreatedOpportunityAttachment>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudprospects")]
        public IWorkflowAction EditOpportunityAttachment([WorkflowExpression] Func<string> attachmentId, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<string> bodyuRL = null, [WorkflowExpression] Func<string[]> bodytags = null)
        {
            SourceExpression.Validate(attachmentId, nameof(attachmentId), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodydate, nameof(bodydate), required: false);
            SourceExpression.Validate(bodyuRL, nameof(bodyuRL), required: false);
            SourceExpression.Validate(bodytags, nameof(bodytags), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/opportunity/v1/opportunities/attachments/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(attachmentId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodydate != null)
                {
                    body["date"] = SourceExpressionConverter.ConvertToken(bodydate);
                    bodypropCount++;
                }

                if (bodyuRL != null)
                {
                    body["url"] = SourceExpressionConverter.ConvertToken(bodyuRL);
                    bodypropCount++;
                }

                if (bodytags != null)
                {
                    body["tags"] = SourceExpressionConverter.ConvertToken(bodytags);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudprospects")]
        public IBodyWorkflowAction<OpportunityApiCreatedOpportunityCustomField> CreateOpportunityCustomField([WorkflowExpression] Func<string> bodyopportunityID, [WorkflowExpression] Func<string> bodycategory, [WorkflowExpression] Func<object> bodyvalue = null, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<string> bodycomment = null)
        {
            SourceExpression.Validate(bodyopportunityID, nameof(bodyopportunityID), required: true);
            SourceExpression.Validate(bodycategory, nameof(bodycategory), required: true);
            SourceExpression.Validate(bodyvalue, nameof(bodyvalue), required: false);
            SourceExpression.Validate(bodydate, nameof(bodydate), required: false);
            SourceExpression.Validate(bodycomment, nameof(bodycomment), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/opportunity/v1/opportunities/customfields";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["parent_id"] = SourceExpressionConverter.ConvertToken(bodyopportunityID);
                bodypropCount++;
                body["category"] = SourceExpressionConverter.ConvertToken(bodycategory);
                if (bodyvalue != null)
                {
                    body["value"] = SourceExpressionConverter.ConvertToken(bodyvalue);
                    bodypropCount++;
                }

                if (bodydate != null)
                {
                    body["date"] = SourceExpressionConverter.ConvertToken(bodydate);
                    bodypropCount++;
                }

                if (bodycomment != null)
                {
                    body["comment"] = SourceExpressionConverter.ConvertToken(bodycomment);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<OpportunityApiCreatedOpportunityCustomField>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudprospects")]
        public IWorkflowAction EditOpportunityCustomField([WorkflowExpression] Func<string> customFieldId, [WorkflowExpression] Func<string> bodycategory = null, [WorkflowExpression] Func<object> bodyvalue = null, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<string> bodycomment = null)
        {
            SourceExpression.Validate(customFieldId, nameof(customFieldId), required: true);
            SourceExpression.Validate(bodycategory, nameof(bodycategory), required: false);
            SourceExpression.Validate(bodyvalue, nameof(bodyvalue), required: false);
            SourceExpression.Validate(bodydate, nameof(bodydate), required: false);
            SourceExpression.Validate(bodycomment, nameof(bodycomment), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/opportunity/v1/opportunities/customfields/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(customFieldId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycategory != null)
                {
                    body["category"] = SourceExpressionConverter.ConvertToken(bodycategory);
                    bodypropCount++;
                }

                if (bodyvalue != null)
                {
                    body["value"] = SourceExpressionConverter.ConvertToken(bodyvalue);
                    bodypropCount++;
                }

                if (bodydate != null)
                {
                    body["date"] = SourceExpressionConverter.ConvertToken(bodydate);
                    bodypropCount++;
                }

                if (bodycomment != null)
                {
                    body["comment"] = SourceExpressionConverter.ConvertToken(bodycomment);
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