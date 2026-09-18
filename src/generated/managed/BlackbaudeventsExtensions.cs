//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Blackbaudevents
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BlackbaudeventsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        public IBodyWorkflowAction<EventApiApiCollectionOfEventListEntry> ListEvents([WorkflowExpression] Func<string> category = null, [WorkflowExpression] Func<string> lookupId = null, [WorkflowExpression] Func<string> startDateFrom = null, [WorkflowExpression] Func<string> startDateTo = null, [WorkflowExpression] Func<bool> includeInactive = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<string> eventId = null, [WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<string> dateAdded = null, [WorkflowExpression] Func<string> lastModified = null)
        {
            SourceExpression.Validate(category, nameof(category), required: false);
            SourceExpression.Validate(lookupId, nameof(lookupId), required: false);
            SourceExpression.Validate(startDateFrom, nameof(startDateFrom), required: false);
            SourceExpression.Validate(startDateTo, nameof(startDateTo), required: false);
            SourceExpression.Validate(includeInactive, nameof(includeInactive), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(offset, nameof(offset), required: false);
            SourceExpression.Validate(eventId, nameof(eventId), required: false);
            SourceExpression.Validate(name, nameof(name), required: false);
            SourceExpression.Validate(dateAdded, nameof(dateAdded), required: false);
            SourceExpression.Validate(lastModified, nameof(lastModified), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/event/v1/eventlist";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (category != null)
                    callPayload.Queries["category"] = SourceExpressionConverter.ConvertO(category);
                if (lookupId != null)
                    callPayload.Queries["lookup_id"] = SourceExpressionConverter.ConvertO(lookupId);
                if (startDateFrom != null)
                    callPayload.Queries["start_date_from"] = SourceExpressionConverter.ConvertO(startDateFrom);
                if (startDateTo != null)
                    callPayload.Queries["start_date_to"] = SourceExpressionConverter.ConvertO(startDateTo);
                if (includeInactive != null)
                    callPayload.Queries["include_inactive"] = SourceExpressionConverter.ConvertO(includeInactive);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                if (eventId != null)
                    callPayload.Queries["event_id"] = SourceExpressionConverter.ConvertO(eventId);
                if (name != null)
                    callPayload.Queries["name"] = SourceExpressionConverter.ConvertO(name);
                if (dateAdded != null)
                    callPayload.Queries["date_added"] = SourceExpressionConverter.ConvertO(dateAdded);
                if (lastModified != null)
                    callPayload.Queries["last_modified"] = SourceExpressionConverter.ConvertO(lastModified);
                return callPayload;
            }

            return new ApiConnectionAction<EventApiApiCollectionOfEventListEntry>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        public IBodyWorkflowAction<EventApiCreatedEvent> CreateEvent([WorkflowExpression] Func<string> bodyeventName, [WorkflowExpression] Func<string> bodycategorycategory, [WorkflowExpression] Func<string> bodystartDate, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodystartTime = null, [WorkflowExpression] Func<string> bodyendDate = null, [WorkflowExpression] Func<string> bodyendTime = null, [WorkflowExpression] Func<string> bodylookupID = null, [WorkflowExpression] Func<int> bodycapacity = null, [WorkflowExpression] Func<double> bodygoal = null, [WorkflowExpression] Func<string> bodycampaignID = null, [WorkflowExpression] Func<string> bodyfundID = null, [WorkflowExpression] Func<bool> bodyinactive = null)
        {
            SourceExpression.Validate(bodyeventName, nameof(bodyeventName), required: true);
            SourceExpression.Validate(bodycategorycategory, nameof(bodycategorycategory), required: true);
            SourceExpression.Validate(bodystartDate, nameof(bodystartDate), required: true);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            SourceExpression.Validate(bodystartTime, nameof(bodystartTime), required: false);
            SourceExpression.Validate(bodyendDate, nameof(bodyendDate), required: false);
            SourceExpression.Validate(bodyendTime, nameof(bodyendTime), required: false);
            SourceExpression.Validate(bodylookupID, nameof(bodylookupID), required: false);
            SourceExpression.Validate(bodycapacity, nameof(bodycapacity), required: false);
            SourceExpression.Validate(bodygoal, nameof(bodygoal), required: false);
            SourceExpression.Validate(bodycampaignID, nameof(bodycampaignID), required: false);
            SourceExpression.Validate(bodyfundID, nameof(bodyfundID), required: false);
            SourceExpression.Validate(bodyinactive, nameof(bodyinactive), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/event/v1/events";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyeventName);
                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                var categoryObject = new JObject();
                var categoryObjectpropCount = 0;
                categoryObjectpropCount++;
                categoryObject["name"] = SourceExpressionConverter.ConvertToken(bodycategorycategory);
                if (categoryObjectpropCount > 0)
                {
                    body["category"] = categoryObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["start_date"] = SourceExpressionConverter.ConvertToken(bodystartDate);
                if (bodystartTime != null)
                {
                    body["start_time"] = SourceExpressionConverter.ConvertToken(bodystartTime);
                    bodypropCount++;
                }

                if (bodyendDate != null)
                {
                    body["end_date"] = SourceExpressionConverter.ConvertToken(bodyendDate);
                    bodypropCount++;
                }

                if (bodyendTime != null)
                {
                    body["end_time"] = SourceExpressionConverter.ConvertToken(bodyendTime);
                    bodypropCount++;
                }

                if (bodylookupID != null)
                {
                    body["lookup_id"] = SourceExpressionConverter.ConvertToken(bodylookupID);
                    bodypropCount++;
                }

                if (bodycapacity != null)
                {
                    body["capacity"] = SourceExpressionConverter.ConvertToken(bodycapacity);
                    bodypropCount++;
                }

                if (bodygoal != null)
                {
                    body["goal"] = SourceExpressionConverter.ConvertToken(bodygoal);
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

            return new ApiConnectionAction<EventApiCreatedEvent>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        public IBodyWorkflowAction<EventApiEvent> GetEvent([WorkflowExpression] Func<string> eventId)
        {
            SourceExpression.Validate(eventId, nameof(eventId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/event/v1/events/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(eventId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<EventApiEvent>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        public IWorkflowAction EditEvent([WorkflowExpression] Func<string> eventId, [WorkflowExpression] Func<string> bodycategorycategory, [WorkflowExpression] Func<string> bodyeventName = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodystartTime = null, [WorkflowExpression] Func<string> bodyendDate = null, [WorkflowExpression] Func<string> bodyendTime = null, [WorkflowExpression] Func<string> bodylookupID = null, [WorkflowExpression] Func<int> bodycapacity = null, [WorkflowExpression] Func<double> bodygoal = null, [WorkflowExpression] Func<string> bodycampaignID = null, [WorkflowExpression] Func<string> bodyfundID = null, [WorkflowExpression] Func<bool> bodyinactive = null)
        {
            SourceExpression.Validate(eventId, nameof(eventId), required: true);
            SourceExpression.Validate(bodycategorycategory, nameof(bodycategorycategory), required: true);
            SourceExpression.Validate(bodyeventName, nameof(bodyeventName), required: false);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            SourceExpression.Validate(bodystartDate, nameof(bodystartDate), required: false);
            SourceExpression.Validate(bodystartTime, nameof(bodystartTime), required: false);
            SourceExpression.Validate(bodyendDate, nameof(bodyendDate), required: false);
            SourceExpression.Validate(bodyendTime, nameof(bodyendTime), required: false);
            SourceExpression.Validate(bodylookupID, nameof(bodylookupID), required: false);
            SourceExpression.Validate(bodycapacity, nameof(bodycapacity), required: false);
            SourceExpression.Validate(bodygoal, nameof(bodygoal), required: false);
            SourceExpression.Validate(bodycampaignID, nameof(bodycampaignID), required: false);
            SourceExpression.Validate(bodyfundID, nameof(bodyfundID), required: false);
            SourceExpression.Validate(bodyinactive, nameof(bodyinactive), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/event/v1/events/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(eventId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyeventName != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyeventName);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                var categoryObject = new JObject();
                var categoryObjectpropCount = 0;
                categoryObjectpropCount++;
                categoryObject["name"] = SourceExpressionConverter.ConvertToken(bodycategorycategory);
                if (categoryObjectpropCount > 0)
                {
                    body["category"] = categoryObject;
                    bodypropCount++;
                }

                if (bodystartDate != null)
                {
                    body["start_date"] = SourceExpressionConverter.ConvertToken(bodystartDate);
                    bodypropCount++;
                }

                if (bodystartTime != null)
                {
                    body["start_time"] = SourceExpressionConverter.ConvertToken(bodystartTime);
                    bodypropCount++;
                }

                if (bodyendDate != null)
                {
                    body["end_date"] = SourceExpressionConverter.ConvertToken(bodyendDate);
                    bodypropCount++;
                }

                if (bodyendTime != null)
                {
                    body["end_time"] = SourceExpressionConverter.ConvertToken(bodyendTime);
                    bodypropCount++;
                }

                if (bodylookupID != null)
                {
                    body["lookup_id"] = SourceExpressionConverter.ConvertToken(bodylookupID);
                    bodypropCount++;
                }

                if (bodycapacity != null)
                {
                    body["capacity"] = SourceExpressionConverter.ConvertToken(bodycapacity);
                    bodypropCount++;
                }

                if (bodygoal != null)
                {
                    body["goal"] = SourceExpressionConverter.ConvertToken(bodygoal);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        public IBodyWorkflowAction<EventApiEventAttachmentCollection> ListEventAttachments([WorkflowExpression] Func<string> eventId)
        {
            SourceExpression.Validate(eventId, nameof(eventId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/event/v1/events/{0}/attachments", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(eventId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<EventApiEventAttachmentCollection>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        public IBodyWorkflowAction<EventApiCreatedEventAttachment> CreateEventAttachment([WorkflowExpression] Func<string> eventId, [WorkflowExpression] Func<bodytypeInput> bodytype, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<string> bodyuRL = null, [WorkflowExpression] Func<string> bodyfileName = null, [WorkflowExpression] Func<string> bodyfileID = null, [WorkflowExpression] Func<string> bodythumbnailID = null, [WorkflowExpression] Func<string[]> bodytags = null)
        {
            SourceExpression.Validate(eventId, nameof(eventId), required: true);
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
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/event/v1/events/{0}/attachments", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(eventId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
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

            return new ApiConnectionAction<EventApiCreatedEventAttachment>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        public IWorkflowAction EditEventAttachment([WorkflowExpression] Func<string> eventId, [WorkflowExpression] Func<string> attachmentId, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<string> bodyuRL = null, [WorkflowExpression] Func<string[]> bodytags = null)
        {
            SourceExpression.Validate(eventId, nameof(eventId), required: true);
            SourceExpression.Validate(attachmentId, nameof(attachmentId), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodydate, nameof(bodydate), required: false);
            SourceExpression.Validate(bodyuRL, nameof(bodyuRL), required: false);
            SourceExpression.Validate(bodytags, nameof(bodytags), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/event/v1/events/{0}/attachments/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(eventId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(attachmentId, 1));
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        public IBodyWorkflowAction<EventApiApiCollectionOfEventFee> ListEventFees([WorkflowExpression] Func<string> eventId)
        {
            SourceExpression.Validate(eventId, nameof(eventId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/event/v1/events/{0}/eventfees", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(eventId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<EventApiApiCollectionOfEventFee>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        public IBodyWorkflowAction<EventApiCreatedEventFee> CreateEventFee([WorkflowExpression] Func<string> eventId, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<double> bodyfeeAmount, [WorkflowExpression] Func<double> bodycontributionAmount)
        {
            SourceExpression.Validate(eventId, nameof(eventId), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            SourceExpression.Validate(bodyfeeAmount, nameof(bodyfeeAmount), required: true);
            SourceExpression.Validate(bodycontributionAmount, nameof(bodycontributionAmount), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/event/v1/events/{0}/eventfees", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(eventId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
                body["cost"] = SourceExpressionConverter.ConvertToken(bodyfeeAmount);
                bodypropCount++;
                body["contribution_amount"] = SourceExpressionConverter.ConvertToken(bodycontributionAmount);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<EventApiCreatedEventFee>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        public IBodyWorkflowAction<EventApiApiCollectionOfEventParticipantOption> ListEventParticipantOptions([WorkflowExpression] Func<string> eventId)
        {
            SourceExpression.Validate(eventId, nameof(eventId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/event/v1/events/{0}/eventparticipantoptions", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(eventId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<EventApiApiCollectionOfEventParticipantOption>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        public IBodyWorkflowAction<EventApiCreatedEventParticipantOption> CreateEventParticipantOption([WorkflowExpression] Func<string> eventId, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<bodyinputTypeInput> bodyinputType, [WorkflowExpression] Func<bool> bodyallowMultiSelect = null, [WorkflowExpression] Func<EventApiCreateParticipantOptionListOption[]> bodylistOptions = null)
        {
            SourceExpression.Validate(eventId, nameof(eventId), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            SourceExpression.Validate(bodyinputType, nameof(bodyinputType), required: true);
            SourceExpression.Validate(bodyallowMultiSelect, nameof(bodyallowMultiSelect), required: false);
            SourceExpression.Validate(bodylistOptions, nameof(bodylistOptions), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/event/v1/events/{0}/eventparticipantoptions", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(eventId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
                body["input_type"] = SourceExpressionConverter.Convert(bodyinputType);
                if (bodyallowMultiSelect != null)
                {
                    body["multi_select"] = SourceExpressionConverter.ConvertToken(bodyallowMultiSelect);
                    bodypropCount++;
                }

                if (bodylistOptions != null)
                {
                    body["list_options"] = SourceExpressionConverter.ConvertToken(bodylistOptions);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<EventApiCreatedEventParticipantOption>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        public IBodyWorkflowAction<EventApiApiCollectionOfParticipantListEntry> ListEventParticipants([WorkflowExpression] Func<string> eventId, [WorkflowExpression] Func<rsvpStatusInput> rsvpStatus = null, [WorkflowExpression] Func<invitationStatusInput> invitationStatus = null, [WorkflowExpression] Func<string> participationLevel = null, [WorkflowExpression] Func<bool> attendedFilter = null, [WorkflowExpression] Func<bool> feesPaidFilter = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<bool> isConstituentFilter = null, [WorkflowExpression] Func<bool> emailEligibleFilter = null, [WorkflowExpression] Func<bool> phoneCallEligibleFilter = null, [WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<string> dateAdded = null, [WorkflowExpression] Func<string> lastModified = null)
        {
            SourceExpression.Validate(eventId, nameof(eventId), required: true);
            SourceExpression.Validate(rsvpStatus, nameof(rsvpStatus), required: false);
            SourceExpression.Validate(invitationStatus, nameof(invitationStatus), required: false);
            SourceExpression.Validate(participationLevel, nameof(participationLevel), required: false);
            SourceExpression.Validate(attendedFilter, nameof(attendedFilter), required: false);
            SourceExpression.Validate(feesPaidFilter, nameof(feesPaidFilter), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(offset, nameof(offset), required: false);
            SourceExpression.Validate(isConstituentFilter, nameof(isConstituentFilter), required: false);
            SourceExpression.Validate(emailEligibleFilter, nameof(emailEligibleFilter), required: false);
            SourceExpression.Validate(phoneCallEligibleFilter, nameof(phoneCallEligibleFilter), required: false);
            SourceExpression.Validate(name, nameof(name), required: false);
            SourceExpression.Validate(dateAdded, nameof(dateAdded), required: false);
            SourceExpression.Validate(lastModified, nameof(lastModified), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/event/v1/events/{0}/participants", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(eventId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (rsvpStatus != null)
                    callPayload.Queries["rsvp_status"] = SourceExpressionConverter.Convert(rsvpStatus);
                if (invitationStatus != null)
                    callPayload.Queries["invitation_status"] = SourceExpressionConverter.Convert(invitationStatus);
                if (participationLevel != null)
                    callPayload.Queries["participation_level"] = SourceExpressionConverter.ConvertO(participationLevel);
                if (attendedFilter != null)
                    callPayload.Queries["attended_filter"] = SourceExpressionConverter.ConvertO(attendedFilter);
                if (feesPaidFilter != null)
                    callPayload.Queries["fees_paid_filter"] = SourceExpressionConverter.ConvertO(feesPaidFilter);
                callPayload.Queries["limit"] = Convert.ToString(500);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                if (isConstituentFilter != null)
                    callPayload.Queries["is_constituent_filter"] = SourceExpressionConverter.ConvertO(isConstituentFilter);
                if (emailEligibleFilter != null)
                    callPayload.Queries["email_eligible_filter"] = SourceExpressionConverter.ConvertO(emailEligibleFilter);
                if (phoneCallEligibleFilter != null)
                    callPayload.Queries["phone_call_eligible_filter"] = SourceExpressionConverter.ConvertO(phoneCallEligibleFilter);
                if (name != null)
                    callPayload.Queries["name"] = SourceExpressionConverter.ConvertO(name);
                if (dateAdded != null)
                    callPayload.Queries["date_added"] = SourceExpressionConverter.ConvertO(dateAdded);
                if (lastModified != null)
                    callPayload.Queries["last_modified"] = SourceExpressionConverter.ConvertO(lastModified);
                return callPayload;
            }

            return new ApiConnectionAction<EventApiApiCollectionOfParticipantListEntry>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        public IBodyWorkflowAction<EventApiCreatedParticipant> CreateParticipant([WorkflowExpression] Func<string> eventId, [WorkflowExpression] Func<string> bodyconstituentID, [WorkflowExpression] Func<string> bodyparticipationLevelparticipationLevel, [WorkflowExpression] Func<string> bodyhostID = null, [WorkflowExpression] Func<bodyrSVPStatusInput> bodyrSVPStatus = null, [WorkflowExpression] Func<bool> bodyattended = null, [WorkflowExpression] Func<bodyinvitationStatusInput> bodyinvitationStatus = null, [WorkflowExpression] Func<int> bodyrSVPDateday = null, [WorkflowExpression] Func<int> bodyrSVPDatemonth = null, [WorkflowExpression] Func<int> bodyrSVPDateyear = null, [WorkflowExpression] Func<int> bodyinvitationDateday = null, [WorkflowExpression] Func<int> bodyinvitationDatemonth = null, [WorkflowExpression] Func<int> bodyinvitationDateyear = null, [WorkflowExpression] Func<string> bodysummaryNote = null)
        {
            SourceExpression.Validate(eventId, nameof(eventId), required: true);
            SourceExpression.Validate(bodyconstituentID, nameof(bodyconstituentID), required: true);
            SourceExpression.Validate(bodyparticipationLevelparticipationLevel, nameof(bodyparticipationLevelparticipationLevel), required: true);
            SourceExpression.Validate(bodyhostID, nameof(bodyhostID), required: false);
            SourceExpression.Validate(bodyrSVPStatus, nameof(bodyrSVPStatus), required: false);
            SourceExpression.Validate(bodyattended, nameof(bodyattended), required: false);
            SourceExpression.Validate(bodyinvitationStatus, nameof(bodyinvitationStatus), required: false);
            SourceExpression.Validate(bodyrSVPDateday, nameof(bodyrSVPDateday), required: false);
            SourceExpression.Validate(bodyrSVPDatemonth, nameof(bodyrSVPDatemonth), required: false);
            SourceExpression.Validate(bodyrSVPDateyear, nameof(bodyrSVPDateyear), required: false);
            SourceExpression.Validate(bodyinvitationDateday, nameof(bodyinvitationDateday), required: false);
            SourceExpression.Validate(bodyinvitationDatemonth, nameof(bodyinvitationDatemonth), required: false);
            SourceExpression.Validate(bodyinvitationDateyear, nameof(bodyinvitationDateyear), required: false);
            SourceExpression.Validate(bodysummaryNote, nameof(bodysummaryNote), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/event/v1/events/{0}/participants", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(eventId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = SourceExpressionConverter.ConvertToken(bodyconstituentID);
                if (bodyhostID != null)
                {
                    body["host_id"] = SourceExpressionConverter.ConvertToken(bodyhostID);
                    bodypropCount++;
                }

                if (bodyrSVPStatus != null)
                {
                    body["rsvp_status"] = SourceExpressionConverter.Convert(bodyrSVPStatus);
                    bodypropCount++;
                }

                if (bodyattended != null)
                {
                    body["attended"] = SourceExpressionConverter.ConvertToken(bodyattended);
                    bodypropCount++;
                }

                if (bodyinvitationStatus != null)
                {
                    body["invitation_status"] = SourceExpressionConverter.Convert(bodyinvitationStatus);
                    bodypropCount++;
                }

                var rsvpDateObject = new JObject();
                var rsvpDateObjectpropCount = 0;
                if (bodyrSVPDateday != null)
                {
                    rsvpDateObject["d"] = SourceExpressionConverter.ConvertToken(bodyrSVPDateday);
                    rsvpDateObjectpropCount++;
                }

                if (bodyrSVPDatemonth != null)
                {
                    rsvpDateObject["m"] = SourceExpressionConverter.ConvertToken(bodyrSVPDatemonth);
                    rsvpDateObjectpropCount++;
                }

                if (bodyrSVPDateyear != null)
                {
                    rsvpDateObject["y"] = SourceExpressionConverter.ConvertToken(bodyrSVPDateyear);
                    rsvpDateObjectpropCount++;
                }

                if (rsvpDateObjectpropCount > 0)
                {
                    body["rsvp_date"] = rsvpDateObject;
                    bodypropCount++;
                }

                var invitationDateObject = new JObject();
                var invitationDateObjectpropCount = 0;
                if (bodyinvitationDateday != null)
                {
                    invitationDateObject["d"] = SourceExpressionConverter.ConvertToken(bodyinvitationDateday);
                    invitationDateObjectpropCount++;
                }

                if (bodyinvitationDatemonth != null)
                {
                    invitationDateObject["m"] = SourceExpressionConverter.ConvertToken(bodyinvitationDatemonth);
                    invitationDateObjectpropCount++;
                }

                if (bodyinvitationDateyear != null)
                {
                    invitationDateObject["y"] = SourceExpressionConverter.ConvertToken(bodyinvitationDateyear);
                    invitationDateObjectpropCount++;
                }

                if (invitationDateObjectpropCount > 0)
                {
                    body["invitation_date"] = invitationDateObject;
                    bodypropCount++;
                }

                var participationLevelObject = new JObject();
                var participationLevelObjectpropCount = 0;
                participationLevelObjectpropCount++;
                participationLevelObject["name"] = SourceExpressionConverter.ConvertToken(bodyparticipationLevelparticipationLevel);
                if (participationLevelObjectpropCount > 0)
                {
                    body["participation_level"] = participationLevelObject;
                    bodypropCount++;
                }

                if (bodysummaryNote != null)
                {
                    body["summary_note"] = SourceExpressionConverter.ConvertToken(bodysummaryNote);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<EventApiCreatedParticipant>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        public IWorkflowAction EditParticipantOption([WorkflowExpression] Func<string> optionId, [WorkflowExpression] Func<string> bodyvalue)
        {
            SourceExpression.Validate(optionId, nameof(optionId), required: true);
            SourceExpression.Validate(bodyvalue, nameof(bodyvalue), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/event/v1/participantoptions/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(optionId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["option_value"] = SourceExpressionConverter.ConvertToken(bodyvalue);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        public IBodyWorkflowAction<EventApiParticipant> GetParticipant([WorkflowExpression] Func<string> participantId)
        {
            SourceExpression.Validate(participantId, nameof(participantId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/event/v1/participants/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(participantId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<EventApiParticipant>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        public IWorkflowAction EditParticipant([WorkflowExpression] Func<string> participantId, [WorkflowExpression] Func<string> bodyparticipationLevelparticipationLevel, [WorkflowExpression] Func<string> bodyconstituentID = null, [WorkflowExpression] Func<string> bodyhostID = null, [WorkflowExpression] Func<bodyrSVPStatusInput> bodyrSVPStatus = null, [WorkflowExpression] Func<bool> bodyattended = null, [WorkflowExpression] Func<bodyinvitationStatusInput> bodyinvitationStatus = null, [WorkflowExpression] Func<int> bodyrSVPDateday = null, [WorkflowExpression] Func<int> bodyrSVPDatemonth = null, [WorkflowExpression] Func<int> bodyrSVPDateyear = null, [WorkflowExpression] Func<int> bodyinvitationDateday = null, [WorkflowExpression] Func<int> bodyinvitationDatemonth = null, [WorkflowExpression] Func<int> bodyinvitationDateyear = null, [WorkflowExpression] Func<string> bodysummaryNote = null)
        {
            SourceExpression.Validate(participantId, nameof(participantId), required: true);
            SourceExpression.Validate(bodyparticipationLevelparticipationLevel, nameof(bodyparticipationLevelparticipationLevel), required: true);
            SourceExpression.Validate(bodyconstituentID, nameof(bodyconstituentID), required: false);
            SourceExpression.Validate(bodyhostID, nameof(bodyhostID), required: false);
            SourceExpression.Validate(bodyrSVPStatus, nameof(bodyrSVPStatus), required: false);
            SourceExpression.Validate(bodyattended, nameof(bodyattended), required: false);
            SourceExpression.Validate(bodyinvitationStatus, nameof(bodyinvitationStatus), required: false);
            SourceExpression.Validate(bodyrSVPDateday, nameof(bodyrSVPDateday), required: false);
            SourceExpression.Validate(bodyrSVPDatemonth, nameof(bodyrSVPDatemonth), required: false);
            SourceExpression.Validate(bodyrSVPDateyear, nameof(bodyrSVPDateyear), required: false);
            SourceExpression.Validate(bodyinvitationDateday, nameof(bodyinvitationDateday), required: false);
            SourceExpression.Validate(bodyinvitationDatemonth, nameof(bodyinvitationDatemonth), required: false);
            SourceExpression.Validate(bodyinvitationDateyear, nameof(bodyinvitationDateyear), required: false);
            SourceExpression.Validate(bodysummaryNote, nameof(bodysummaryNote), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/event/v1/participants/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(participantId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyconstituentID != null)
                {
                    body["constituent_id"] = SourceExpressionConverter.ConvertToken(bodyconstituentID);
                    bodypropCount++;
                }

                if (bodyhostID != null)
                {
                    body["host_id"] = SourceExpressionConverter.ConvertToken(bodyhostID);
                    bodypropCount++;
                }

                if (bodyrSVPStatus != null)
                {
                    body["rsvp_status"] = SourceExpressionConverter.Convert(bodyrSVPStatus);
                    bodypropCount++;
                }

                if (bodyattended != null)
                {
                    body["attended"] = SourceExpressionConverter.ConvertToken(bodyattended);
                    bodypropCount++;
                }

                if (bodyinvitationStatus != null)
                {
                    body["invitation_status"] = SourceExpressionConverter.Convert(bodyinvitationStatus);
                    bodypropCount++;
                }

                var rsvpDateObject = new JObject();
                var rsvpDateObjectpropCount = 0;
                if (bodyrSVPDateday != null)
                {
                    rsvpDateObject["d"] = SourceExpressionConverter.ConvertToken(bodyrSVPDateday);
                    rsvpDateObjectpropCount++;
                }

                if (bodyrSVPDatemonth != null)
                {
                    rsvpDateObject["m"] = SourceExpressionConverter.ConvertToken(bodyrSVPDatemonth);
                    rsvpDateObjectpropCount++;
                }

                if (bodyrSVPDateyear != null)
                {
                    rsvpDateObject["y"] = SourceExpressionConverter.ConvertToken(bodyrSVPDateyear);
                    rsvpDateObjectpropCount++;
                }

                if (rsvpDateObjectpropCount > 0)
                {
                    body["rsvp_date"] = rsvpDateObject;
                    bodypropCount++;
                }

                var invitationDateObject = new JObject();
                var invitationDateObjectpropCount = 0;
                if (bodyinvitationDateday != null)
                {
                    invitationDateObject["d"] = SourceExpressionConverter.ConvertToken(bodyinvitationDateday);
                    invitationDateObjectpropCount++;
                }

                if (bodyinvitationDatemonth != null)
                {
                    invitationDateObject["m"] = SourceExpressionConverter.ConvertToken(bodyinvitationDatemonth);
                    invitationDateObjectpropCount++;
                }

                if (bodyinvitationDateyear != null)
                {
                    invitationDateObject["y"] = SourceExpressionConverter.ConvertToken(bodyinvitationDateyear);
                    invitationDateObjectpropCount++;
                }

                if (invitationDateObjectpropCount > 0)
                {
                    body["invitation_date"] = invitationDateObject;
                    bodypropCount++;
                }

                var participationLevelObject = new JObject();
                var participationLevelObjectpropCount = 0;
                participationLevelObjectpropCount++;
                participationLevelObject["name"] = SourceExpressionConverter.ConvertToken(bodyparticipationLevelparticipationLevel);
                if (participationLevelObjectpropCount > 0)
                {
                    body["participation_level"] = participationLevelObject;
                    bodypropCount++;
                }

                if (bodysummaryNote != null)
                {
                    body["summary_note"] = SourceExpressionConverter.ConvertToken(bodysummaryNote);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        public IBodyWorkflowAction<EventApiApiCollectionOfParticipantDonation> ListParticipantDonations([WorkflowExpression] Func<string> participantId, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            SourceExpression.Validate(participantId, nameof(participantId), required: true);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(offset, nameof(offset), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/event/v1/participants/{0}/donations", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(participantId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = Convert.ToString(500);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<EventApiApiCollectionOfParticipantDonation>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        public IBodyWorkflowAction<EventApiCreatedParticipantDonation> CreateParticipantDonation([WorkflowExpression] Func<string> participantId, [WorkflowExpression] Func<string> bodygiftID)
        {
            SourceExpression.Validate(participantId, nameof(participantId), required: true);
            SourceExpression.Validate(bodygiftID, nameof(bodygiftID), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/event/v1/participants/{0}/donations", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(participantId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["gift_id"] = SourceExpressionConverter.ConvertToken(bodygiftID);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<EventApiCreatedParticipantDonation>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        public IBodyWorkflowAction<EventApiApiCollectionOfParticipantFeePayment> ListParticipantFeePayments([WorkflowExpression] Func<string> participantId, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            SourceExpression.Validate(participantId, nameof(participantId), required: true);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(offset, nameof(offset), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/event/v1/participants/{0}/feepayments", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(participantId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = Convert.ToString(500);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<EventApiApiCollectionOfParticipantFeePayment>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        public IBodyWorkflowAction<EventApiCreatedParticipantFeePayment> CreateParticipantFeePayment([WorkflowExpression] Func<string> participantId, [WorkflowExpression] Func<string> bodygiftID, [WorkflowExpression] Func<double> bodyappliedAmount)
        {
            SourceExpression.Validate(participantId, nameof(participantId), required: true);
            SourceExpression.Validate(bodygiftID, nameof(bodygiftID), required: true);
            SourceExpression.Validate(bodyappliedAmount, nameof(bodyappliedAmount), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/event/v1/participants/{0}/feepayments", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(participantId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["gift_id"] = SourceExpressionConverter.ConvertToken(bodygiftID);
                bodypropCount++;
                body["applied_amount"] = SourceExpressionConverter.ConvertToken(bodyappliedAmount);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<EventApiCreatedParticipantFeePayment>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        public IBodyWorkflowAction<EventApiApiCollectionOfParticipantFee> ListParticipantFees([WorkflowExpression] Func<string> participantId, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            SourceExpression.Validate(participantId, nameof(participantId), required: true);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(offset, nameof(offset), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/event/v1/participants/{0}/fees", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(participantId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = Convert.ToString(500);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<EventApiApiCollectionOfParticipantFee>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        public IBodyWorkflowAction<EventApiCreatedParticipantFee> CreateParticipantFee([WorkflowExpression] Func<string> participantId, [WorkflowExpression] Func<string> bodyeventID, [WorkflowExpression] Func<string> bodyfee, [WorkflowExpression] Func<int> bodyquantity, [WorkflowExpression] Func<double> bodyfeeAmount, [WorkflowExpression] Func<double> bodycontributionAmount, [WorkflowExpression] Func<int> bodydateday = null, [WorkflowExpression] Func<int> bodydatemonth = null, [WorkflowExpression] Func<int> bodydateyear = null)
        {
            SourceExpression.Validate(participantId, nameof(participantId), required: true);
            SourceExpression.Validate(bodyeventID, nameof(bodyeventID), required: true);
            SourceExpression.Validate(bodyfee, nameof(bodyfee), required: true);
            SourceExpression.Validate(bodyquantity, nameof(bodyquantity), required: true);
            SourceExpression.Validate(bodyfeeAmount, nameof(bodyfeeAmount), required: true);
            SourceExpression.Validate(bodycontributionAmount, nameof(bodycontributionAmount), required: true);
            SourceExpression.Validate(bodydateday, nameof(bodydateday), required: false);
            SourceExpression.Validate(bodydatemonth, nameof(bodydatemonth), required: false);
            SourceExpression.Validate(bodydateyear, nameof(bodydateyear), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/event/v1/participants/{0}/fees", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(participantId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["event_id"] = SourceExpressionConverter.ConvertToken(bodyeventID);
                bodypropCount++;
                body["event_fee_id"] = SourceExpressionConverter.ConvertToken(bodyfee);
                bodypropCount++;
                body["quantity"] = SourceExpressionConverter.ConvertToken(bodyquantity);
                bodypropCount++;
                body["fee_amount"] = SourceExpressionConverter.ConvertToken(bodyfeeAmount);
                bodypropCount++;
                body["contribution_amount"] = SourceExpressionConverter.ConvertToken(bodycontributionAmount);
                var dateObject = new JObject();
                var dateObjectpropCount = 0;
                if (bodydateday != null)
                {
                    dateObject["d"] = SourceExpressionConverter.ConvertToken(bodydateday);
                    dateObjectpropCount++;
                }

                if (bodydatemonth != null)
                {
                    dateObject["m"] = SourceExpressionConverter.ConvertToken(bodydatemonth);
                    dateObjectpropCount++;
                }

                if (bodydateyear != null)
                {
                    dateObject["y"] = SourceExpressionConverter.ConvertToken(bodydateyear);
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
                return callPayload;
            }

            return new ApiConnectionAction<EventApiCreatedParticipantFee>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        public IBodyWorkflowAction<EventApiApiCollectionOfParticipantOption> ListParticipantOptions([WorkflowExpression] Func<string> participantId)
        {
            SourceExpression.Validate(participantId, nameof(participantId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/event/v1/participants/{0}/participantoptions", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(participantId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<EventApiApiCollectionOfParticipantOption>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        public IBodyWorkflowAction<EventApiCreatedParticipantOption> CreateParticipantOption([WorkflowExpression] Func<string> participantId, [WorkflowExpression] Func<string> bodyeventID, [WorkflowExpression] Func<string> bodyoption, [WorkflowExpression] Func<object> bodyoptionValue)
        {
            SourceExpression.Validate(participantId, nameof(participantId), required: true);
            SourceExpression.Validate(bodyeventID, nameof(bodyeventID), required: true);
            SourceExpression.Validate(bodyoption, nameof(bodyoption), required: true);
            SourceExpression.Validate(bodyoptionValue, nameof(bodyoptionValue), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/event/v1/participants/{0}/participantoptions", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(participantId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["event_id"] = SourceExpressionConverter.ConvertToken(bodyeventID);
                bodypropCount++;
                body["event_participant_option_id"] = SourceExpressionConverter.ConvertToken(bodyoption);
                bodypropCount++;
                body["option_value"] = SourceExpressionConverter.ConvertToken(bodyoptionValue);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<EventApiCreatedParticipantOption>(BuildSourceInput);
        }
    }

    public class BlackbaudeventsTriggers([ConnectionName] string connectionId)
    {
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

    public class EventApiEventAttachmentCollection
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public EventApiEventAttachment[] Value { get; set; }
    }

    public class EventApiEventAttachment
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("parent_id")]
        public string EventID { get; set; }

        [JsonProperty("type")]
        public EventApiEventAttachmentTypeType Type { get; set; }

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

    public enum EventApiEventAttachmentTypeType
    {
        Link,
        Physical
    }

    public class EventApiCreatedEventAttachment
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public enum bodytypeInput
    {
        Link,
        Physical
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

        [JsonProperty("donations")]
        public double Donations { get; set; }

        [JsonProperty("revenue")]
        public double Revenue { get; set; }

        [JsonProperty("seat")]
        public string Seat { get; set; }

        [JsonProperty("name_tag")]
        public string NameTag { get; set; }

        [JsonProperty("summary_note")]
        public string SummaryNote { get; set; }

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

        [JsonProperty("summary_note")]
        public string SummaryNote { get; set; }

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
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Blackbaudevents;

    public partial class WorkflowManagedActions
    {
        public BlackbaudeventsActions Blackbaudevents(string connectionId) => new BlackbaudeventsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public BlackbaudeventsTriggers Blackbaudevents(string connectionId) => new BlackbaudeventsTriggers(connectionId);
    }
}