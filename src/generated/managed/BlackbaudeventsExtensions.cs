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
        public IBodyWorkflowAction<EventApiApiCollectionOfEventListEntry> ListEvents(Expression<Func<string>> category = null, Expression<Func<string>> lookupId = null, Expression<Func<string>> startDateFrom = null, Expression<Func<string>> startDateTo = null, Expression<Func<bool>> includeInactive = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<string>> eventId = null, Expression<Func<string>> name = null, Expression<Func<string>> dateAdded = null, Expression<Func<string>> lastModified = null)
        {
            var apiCallPath = "/event/v1/eventlist";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (category != null)
                callPayload.Queries["category"] = CSharpExpressionConverter.ConvertO(category);
            if (lookupId != null)
                callPayload.Queries["lookup_id"] = CSharpExpressionConverter.ConvertO(lookupId);
            if (startDateFrom != null)
                callPayload.Queries["start_date_from"] = CSharpExpressionConverter.ConvertO(startDateFrom);
            if (startDateTo != null)
                callPayload.Queries["start_date_to"] = CSharpExpressionConverter.ConvertO(startDateTo);
            if (includeInactive != null)
                callPayload.Queries["include_inactive"] = CSharpExpressionConverter.ConvertO(includeInactive);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            if (offset != null)
                callPayload.Queries["offset"] = CSharpExpressionConverter.ConvertO(offset);
            if (eventId != null)
                callPayload.Queries["event_id"] = CSharpExpressionConverter.ConvertO(eventId);
            if (name != null)
                callPayload.Queries["name"] = CSharpExpressionConverter.ConvertO(name);
            if (dateAdded != null)
                callPayload.Queries["date_added"] = CSharpExpressionConverter.ConvertO(dateAdded);
            if (lastModified != null)
                callPayload.Queries["last_modified"] = CSharpExpressionConverter.ConvertO(lastModified);
            return new ApiConnectionAction<EventApiApiCollectionOfEventListEntry>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        public IBodyWorkflowAction<EventApiCreatedEvent> CreateEvent(Expression<Func<string>> bodyeventName, Expression<Func<string>> bodycategorycategory, Expression<Func<string>> bodystartDate, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodystartTime = null, Expression<Func<string>> bodyendDate = null, Expression<Func<string>> bodyendTime = null, Expression<Func<string>> bodylookupID = null, Expression<Func<int>> bodycapacity = null, Expression<Func<double>> bodygoal = null, Expression<Func<string>> bodycampaignID = null, Expression<Func<string>> bodyfundID = null, Expression<Func<bool>> bodyinactive = null)
        {
            var apiCallPath = "/event/v1/events";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["name"] = CSharpExpressionConverter.ConvertToken(bodyeventName);
            if (bodydescription != null)
            {
                body["description"] = CSharpExpressionConverter.ConvertToken(bodydescription);
                bodypropCount++;
            }

            var categoryObject = new JObject();
            var categoryObjectpropCount = 0;
            categoryObjectpropCount++;
            categoryObject["name"] = CSharpExpressionConverter.ConvertToken(bodycategorycategory);
            if (categoryObjectpropCount > 0)
            {
                body["category"] = categoryObject;
                bodypropCount++;
            }

            bodypropCount++;
            body["start_date"] = CSharpExpressionConverter.ConvertToken(bodystartDate);
            if (bodystartTime != null)
            {
                body["start_time"] = CSharpExpressionConverter.ConvertToken(bodystartTime);
                bodypropCount++;
            }

            if (bodyendDate != null)
            {
                body["end_date"] = CSharpExpressionConverter.ConvertToken(bodyendDate);
                bodypropCount++;
            }

            if (bodyendTime != null)
            {
                body["end_time"] = CSharpExpressionConverter.ConvertToken(bodyendTime);
                bodypropCount++;
            }

            if (bodylookupID != null)
            {
                body["lookup_id"] = CSharpExpressionConverter.ConvertToken(bodylookupID);
                bodypropCount++;
            }

            if (bodycapacity != null)
            {
                body["capacity"] = CSharpExpressionConverter.ConvertToken(bodycapacity);
                bodypropCount++;
            }

            if (bodygoal != null)
            {
                body["goal"] = CSharpExpressionConverter.ConvertToken(bodygoal);
                bodypropCount++;
            }

            if (bodycampaignID != null)
            {
                body["campaign_id"] = CSharpExpressionConverter.ConvertToken(bodycampaignID);
                bodypropCount++;
            }

            if (bodyfundID != null)
            {
                body["fund_id"] = CSharpExpressionConverter.ConvertToken(bodyfundID);
                bodypropCount++;
            }

            if (bodyinactive != null)
            {
                body["inactive"] = CSharpExpressionConverter.ConvertToken(bodyinactive);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<EventApiCreatedEvent>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        public IBodyWorkflowAction<EventApiEvent> GetEvent(Expression<Func<string>> eventId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/event/v1/events/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(eventId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EventApiEvent>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        public IWorkflowAction EditEvent(Expression<Func<string>> eventId, Expression<Func<string>> bodycategorycategory, Expression<Func<string>> bodyeventName = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodystartTime = null, Expression<Func<string>> bodyendDate = null, Expression<Func<string>> bodyendTime = null, Expression<Func<string>> bodylookupID = null, Expression<Func<int>> bodycapacity = null, Expression<Func<double>> bodygoal = null, Expression<Func<string>> bodycampaignID = null, Expression<Func<string>> bodyfundID = null, Expression<Func<bool>> bodyinactive = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/event/v1/events/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(eventId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyeventName != null)
            {
                body["name"] = CSharpExpressionConverter.ConvertToken(bodyeventName);
                bodypropCount++;
            }

            if (bodydescription != null)
            {
                body["description"] = CSharpExpressionConverter.ConvertToken(bodydescription);
                bodypropCount++;
            }

            var categoryObject = new JObject();
            var categoryObjectpropCount = 0;
            categoryObjectpropCount++;
            categoryObject["name"] = CSharpExpressionConverter.ConvertToken(bodycategorycategory);
            if (categoryObjectpropCount > 0)
            {
                body["category"] = categoryObject;
                bodypropCount++;
            }

            if (bodystartDate != null)
            {
                body["start_date"] = CSharpExpressionConverter.ConvertToken(bodystartDate);
                bodypropCount++;
            }

            if (bodystartTime != null)
            {
                body["start_time"] = CSharpExpressionConverter.ConvertToken(bodystartTime);
                bodypropCount++;
            }

            if (bodyendDate != null)
            {
                body["end_date"] = CSharpExpressionConverter.ConvertToken(bodyendDate);
                bodypropCount++;
            }

            if (bodyendTime != null)
            {
                body["end_time"] = CSharpExpressionConverter.ConvertToken(bodyendTime);
                bodypropCount++;
            }

            if (bodylookupID != null)
            {
                body["lookup_id"] = CSharpExpressionConverter.ConvertToken(bodylookupID);
                bodypropCount++;
            }

            if (bodycapacity != null)
            {
                body["capacity"] = CSharpExpressionConverter.ConvertToken(bodycapacity);
                bodypropCount++;
            }

            if (bodygoal != null)
            {
                body["goal"] = CSharpExpressionConverter.ConvertToken(bodygoal);
                bodypropCount++;
            }

            if (bodycampaignID != null)
            {
                body["campaign_id"] = CSharpExpressionConverter.ConvertToken(bodycampaignID);
                bodypropCount++;
            }

            if (bodyfundID != null)
            {
                body["fund_id"] = CSharpExpressionConverter.ConvertToken(bodyfundID);
                bodypropCount++;
            }

            if (bodyinactive != null)
            {
                body["inactive"] = CSharpExpressionConverter.ConvertToken(bodyinactive);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        public IBodyWorkflowAction<EventApiEventAttachmentCollection> ListEventAttachments(Expression<Func<string>> eventId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/event/v1/events/{0}/attachments", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(eventId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EventApiEventAttachmentCollection>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        public IBodyWorkflowAction<EventApiCreatedEventAttachment> CreateEventAttachment(Expression<Func<string>> eventId, Expression<Func<bodytypeInput>> bodytype, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodyuRL = null, Expression<Func<string>> bodyfileName = null, Expression<Func<string>> bodyfileID = null, Expression<Func<string>> bodythumbnailID = null, Expression<Func<string[]>> bodytags = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/event/v1/events/{0}/attachments", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(eventId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["type"] = CSharpExpressionConverter.Convert(bodytype);
            if (bodyname != null)
            {
                body["name"] = CSharpExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
            }

            if (bodydate != null)
            {
                body["date"] = CSharpExpressionConverter.ConvertToken(bodydate);
                bodypropCount++;
            }

            if (bodyuRL != null)
            {
                body["url"] = CSharpExpressionConverter.ConvertToken(bodyuRL);
                bodypropCount++;
            }

            if (bodyfileName != null)
            {
                body["file_name"] = CSharpExpressionConverter.ConvertToken(bodyfileName);
                bodypropCount++;
            }

            if (bodyfileID != null)
            {
                body["file_id"] = CSharpExpressionConverter.ConvertToken(bodyfileID);
                bodypropCount++;
            }

            if (bodythumbnailID != null)
            {
                body["thumbnail_id"] = CSharpExpressionConverter.ConvertToken(bodythumbnailID);
                bodypropCount++;
            }

            if (bodytags != null)
            {
                body["tags"] = CSharpExpressionConverter.ConvertToken(bodytags);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<EventApiCreatedEventAttachment>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        public IWorkflowAction EditEventAttachment(Expression<Func<string>> eventId, Expression<Func<string>> attachmentId, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodyuRL = null, Expression<Func<string[]>> bodytags = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/event/v1/events/{0}/attachments/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(eventId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(attachmentId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyname != null)
            {
                body["name"] = CSharpExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
            }

            if (bodydate != null)
            {
                body["date"] = CSharpExpressionConverter.ConvertToken(bodydate);
                bodypropCount++;
            }

            if (bodyuRL != null)
            {
                body["url"] = CSharpExpressionConverter.ConvertToken(bodyuRL);
                bodypropCount++;
            }

            if (bodytags != null)
            {
                body["tags"] = CSharpExpressionConverter.ConvertToken(bodytags);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        public IBodyWorkflowAction<EventApiApiCollectionOfEventFee> ListEventFees(Expression<Func<string>> eventId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/event/v1/events/{0}/eventfees", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(eventId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EventApiApiCollectionOfEventFee>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        public IBodyWorkflowAction<EventApiCreatedEventFee> CreateEventFee(Expression<Func<string>> eventId, Expression<Func<string>> bodyname, Expression<Func<double>> bodyfeeAmount, Expression<Func<double>> bodycontributionAmount)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/event/v1/events/{0}/eventfees", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(eventId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["name"] = CSharpExpressionConverter.ConvertToken(bodyname);
            bodypropCount++;
            body["cost"] = CSharpExpressionConverter.ConvertToken(bodyfeeAmount);
            bodypropCount++;
            body["contribution_amount"] = CSharpExpressionConverter.ConvertToken(bodycontributionAmount);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<EventApiCreatedEventFee>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        public IBodyWorkflowAction<EventApiApiCollectionOfEventParticipantOption> ListEventParticipantOptions(Expression<Func<string>> eventId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/event/v1/events/{0}/eventparticipantoptions", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(eventId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EventApiApiCollectionOfEventParticipantOption>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        public IBodyWorkflowAction<EventApiCreatedEventParticipantOption> CreateEventParticipantOption(Expression<Func<string>> eventId, Expression<Func<string>> bodyname, Expression<Func<bodyinputTypeInput>> bodyinputType, Expression<Func<bool>> bodyallowMultiSelect = null, Expression<Func<EventApiCreateParticipantOptionListOption[]>> bodylistOptions = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/event/v1/events/{0}/eventparticipantoptions", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(eventId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["name"] = CSharpExpressionConverter.ConvertToken(bodyname);
            bodypropCount++;
            body["input_type"] = CSharpExpressionConverter.Convert(bodyinputType);
            if (bodyallowMultiSelect != null)
            {
                body["multi_select"] = CSharpExpressionConverter.ConvertToken(bodyallowMultiSelect);
                bodypropCount++;
            }

            if (bodylistOptions != null)
            {
                body["list_options"] = CSharpExpressionConverter.ConvertToken(bodylistOptions);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<EventApiCreatedEventParticipantOption>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        public IBodyWorkflowAction<EventApiApiCollectionOfParticipantListEntry> ListEventParticipants(Expression<Func<string>> eventId, Expression<Func<rsvpStatusInput>> rsvpStatus = null, Expression<Func<invitationStatusInput>> invitationStatus = null, Expression<Func<string>> participationLevel = null, Expression<Func<bool>> attendedFilter = null, Expression<Func<bool>> feesPaidFilter = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<bool>> isConstituentFilter = null, Expression<Func<bool>> emailEligibleFilter = null, Expression<Func<bool>> phoneCallEligibleFilter = null, Expression<Func<string>> name = null, Expression<Func<string>> dateAdded = null, Expression<Func<string>> lastModified = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/event/v1/events/{0}/participants", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(eventId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (rsvpStatus != null)
                callPayload.Queries["rsvp_status"] = CSharpExpressionConverter.Convert(rsvpStatus);
            if (invitationStatus != null)
                callPayload.Queries["invitation_status"] = CSharpExpressionConverter.Convert(invitationStatus);
            if (participationLevel != null)
                callPayload.Queries["participation_level"] = CSharpExpressionConverter.ConvertO(participationLevel);
            if (attendedFilter != null)
                callPayload.Queries["attended_filter"] = CSharpExpressionConverter.ConvertO(attendedFilter);
            if (feesPaidFilter != null)
                callPayload.Queries["fees_paid_filter"] = CSharpExpressionConverter.ConvertO(feesPaidFilter);
            callPayload.Queries["limit"] = Convert.ToString(500);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            if (offset != null)
                callPayload.Queries["offset"] = CSharpExpressionConverter.ConvertO(offset);
            if (isConstituentFilter != null)
                callPayload.Queries["is_constituent_filter"] = CSharpExpressionConverter.ConvertO(isConstituentFilter);
            if (emailEligibleFilter != null)
                callPayload.Queries["email_eligible_filter"] = CSharpExpressionConverter.ConvertO(emailEligibleFilter);
            if (phoneCallEligibleFilter != null)
                callPayload.Queries["phone_call_eligible_filter"] = CSharpExpressionConverter.ConvertO(phoneCallEligibleFilter);
            if (name != null)
                callPayload.Queries["name"] = CSharpExpressionConverter.ConvertO(name);
            if (dateAdded != null)
                callPayload.Queries["date_added"] = CSharpExpressionConverter.ConvertO(dateAdded);
            if (lastModified != null)
                callPayload.Queries["last_modified"] = CSharpExpressionConverter.ConvertO(lastModified);
            return new ApiConnectionAction<EventApiApiCollectionOfParticipantListEntry>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        public IBodyWorkflowAction<EventApiCreatedParticipant> CreateParticipant(Expression<Func<string>> eventId, Expression<Func<string>> bodyconstituentID, Expression<Func<string>> bodyparticipationLevelparticipationLevel, Expression<Func<string>> bodyhostID = null, Expression<Func<bodyrSVPStatusInput>> bodyrSVPStatus = null, Expression<Func<bool>> bodyattended = null, Expression<Func<bodyinvitationStatusInput>> bodyinvitationStatus = null, Expression<Func<int>> bodyrSVPDateday = null, Expression<Func<int>> bodyrSVPDatemonth = null, Expression<Func<int>> bodyrSVPDateyear = null, Expression<Func<int>> bodyinvitationDateday = null, Expression<Func<int>> bodyinvitationDatemonth = null, Expression<Func<int>> bodyinvitationDateyear = null, Expression<Func<string>> bodysummaryNote = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/event/v1/events/{0}/participants", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(eventId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["constituent_id"] = CSharpExpressionConverter.ConvertToken(bodyconstituentID);
            if (bodyhostID != null)
            {
                body["host_id"] = CSharpExpressionConverter.ConvertToken(bodyhostID);
                bodypropCount++;
            }

            if (bodyrSVPStatus != null)
            {
                body["rsvp_status"] = CSharpExpressionConverter.Convert(bodyrSVPStatus);
                bodypropCount++;
            }

            if (bodyattended != null)
            {
                body["attended"] = CSharpExpressionConverter.ConvertToken(bodyattended);
                bodypropCount++;
            }

            if (bodyinvitationStatus != null)
            {
                body["invitation_status"] = CSharpExpressionConverter.Convert(bodyinvitationStatus);
                bodypropCount++;
            }

            var rsvpDateObject = new JObject();
            var rsvpDateObjectpropCount = 0;
            if (bodyrSVPDateday != null)
            {
                rsvpDateObject["d"] = CSharpExpressionConverter.ConvertToken(bodyrSVPDateday);
                rsvpDateObjectpropCount++;
            }

            if (bodyrSVPDatemonth != null)
            {
                rsvpDateObject["m"] = CSharpExpressionConverter.ConvertToken(bodyrSVPDatemonth);
                rsvpDateObjectpropCount++;
            }

            if (bodyrSVPDateyear != null)
            {
                rsvpDateObject["y"] = CSharpExpressionConverter.ConvertToken(bodyrSVPDateyear);
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
                invitationDateObject["d"] = CSharpExpressionConverter.ConvertToken(bodyinvitationDateday);
                invitationDateObjectpropCount++;
            }

            if (bodyinvitationDatemonth != null)
            {
                invitationDateObject["m"] = CSharpExpressionConverter.ConvertToken(bodyinvitationDatemonth);
                invitationDateObjectpropCount++;
            }

            if (bodyinvitationDateyear != null)
            {
                invitationDateObject["y"] = CSharpExpressionConverter.ConvertToken(bodyinvitationDateyear);
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
            participationLevelObject["name"] = CSharpExpressionConverter.ConvertToken(bodyparticipationLevelparticipationLevel);
            if (participationLevelObjectpropCount > 0)
            {
                body["participation_level"] = participationLevelObject;
                bodypropCount++;
            }

            if (bodysummaryNote != null)
            {
                body["summary_note"] = CSharpExpressionConverter.ConvertToken(bodysummaryNote);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<EventApiCreatedParticipant>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        public IWorkflowAction EditParticipantOption(Expression<Func<string>> optionId, Expression<Func<string>> bodyvalue)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/event/v1/participantoptions/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(optionId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["option_value"] = CSharpExpressionConverter.ConvertToken(bodyvalue);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        public IBodyWorkflowAction<EventApiParticipant> GetParticipant(Expression<Func<string>> participantId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/event/v1/participants/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(participantId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EventApiParticipant>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        public IWorkflowAction EditParticipant(Expression<Func<string>> participantId, Expression<Func<string>> bodyparticipationLevelparticipationLevel, Expression<Func<string>> bodyconstituentID = null, Expression<Func<string>> bodyhostID = null, Expression<Func<bodyrSVPStatusInput>> bodyrSVPStatus = null, Expression<Func<bool>> bodyattended = null, Expression<Func<bodyinvitationStatusInput>> bodyinvitationStatus = null, Expression<Func<int>> bodyrSVPDateday = null, Expression<Func<int>> bodyrSVPDatemonth = null, Expression<Func<int>> bodyrSVPDateyear = null, Expression<Func<int>> bodyinvitationDateday = null, Expression<Func<int>> bodyinvitationDatemonth = null, Expression<Func<int>> bodyinvitationDateyear = null, Expression<Func<string>> bodysummaryNote = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/event/v1/participants/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(participantId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyconstituentID != null)
            {
                body["constituent_id"] = CSharpExpressionConverter.ConvertToken(bodyconstituentID);
                bodypropCount++;
            }

            if (bodyhostID != null)
            {
                body["host_id"] = CSharpExpressionConverter.ConvertToken(bodyhostID);
                bodypropCount++;
            }

            if (bodyrSVPStatus != null)
            {
                body["rsvp_status"] = CSharpExpressionConverter.Convert(bodyrSVPStatus);
                bodypropCount++;
            }

            if (bodyattended != null)
            {
                body["attended"] = CSharpExpressionConverter.ConvertToken(bodyattended);
                bodypropCount++;
            }

            if (bodyinvitationStatus != null)
            {
                body["invitation_status"] = CSharpExpressionConverter.Convert(bodyinvitationStatus);
                bodypropCount++;
            }

            var rsvpDateObject = new JObject();
            var rsvpDateObjectpropCount = 0;
            if (bodyrSVPDateday != null)
            {
                rsvpDateObject["d"] = CSharpExpressionConverter.ConvertToken(bodyrSVPDateday);
                rsvpDateObjectpropCount++;
            }

            if (bodyrSVPDatemonth != null)
            {
                rsvpDateObject["m"] = CSharpExpressionConverter.ConvertToken(bodyrSVPDatemonth);
                rsvpDateObjectpropCount++;
            }

            if (bodyrSVPDateyear != null)
            {
                rsvpDateObject["y"] = CSharpExpressionConverter.ConvertToken(bodyrSVPDateyear);
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
                invitationDateObject["d"] = CSharpExpressionConverter.ConvertToken(bodyinvitationDateday);
                invitationDateObjectpropCount++;
            }

            if (bodyinvitationDatemonth != null)
            {
                invitationDateObject["m"] = CSharpExpressionConverter.ConvertToken(bodyinvitationDatemonth);
                invitationDateObjectpropCount++;
            }

            if (bodyinvitationDateyear != null)
            {
                invitationDateObject["y"] = CSharpExpressionConverter.ConvertToken(bodyinvitationDateyear);
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
            participationLevelObject["name"] = CSharpExpressionConverter.ConvertToken(bodyparticipationLevelparticipationLevel);
            if (participationLevelObjectpropCount > 0)
            {
                body["participation_level"] = participationLevelObject;
                bodypropCount++;
            }

            if (bodysummaryNote != null)
            {
                body["summary_note"] = CSharpExpressionConverter.ConvertToken(bodysummaryNote);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        public IBodyWorkflowAction<EventApiApiCollectionOfParticipantDonation> ListParticipantDonations(Expression<Func<string>> participantId, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/event/v1/participants/{0}/donations", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(participantId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["limit"] = Convert.ToString(500);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            if (offset != null)
                callPayload.Queries["offset"] = CSharpExpressionConverter.ConvertO(offset);
            return new ApiConnectionAction<EventApiApiCollectionOfParticipantDonation>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        public IBodyWorkflowAction<EventApiCreatedParticipantDonation> CreateParticipantDonation(Expression<Func<string>> participantId, Expression<Func<string>> bodygiftID)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/event/v1/participants/{0}/donations", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(participantId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["gift_id"] = CSharpExpressionConverter.ConvertToken(bodygiftID);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<EventApiCreatedParticipantDonation>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        public IBodyWorkflowAction<EventApiApiCollectionOfParticipantFeePayment> ListParticipantFeePayments(Expression<Func<string>> participantId, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/event/v1/participants/{0}/feepayments", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(participantId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["limit"] = Convert.ToString(500);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            if (offset != null)
                callPayload.Queries["offset"] = CSharpExpressionConverter.ConvertO(offset);
            return new ApiConnectionAction<EventApiApiCollectionOfParticipantFeePayment>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        public IBodyWorkflowAction<EventApiCreatedParticipantFeePayment> CreateParticipantFeePayment(Expression<Func<string>> participantId, Expression<Func<string>> bodygiftID, Expression<Func<double>> bodyappliedAmount)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/event/v1/participants/{0}/feepayments", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(participantId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["gift_id"] = CSharpExpressionConverter.ConvertToken(bodygiftID);
            bodypropCount++;
            body["applied_amount"] = CSharpExpressionConverter.ConvertToken(bodyappliedAmount);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<EventApiCreatedParticipantFeePayment>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        public IBodyWorkflowAction<EventApiApiCollectionOfParticipantFee> ListParticipantFees(Expression<Func<string>> participantId, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/event/v1/participants/{0}/fees", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(participantId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["limit"] = Convert.ToString(500);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            if (offset != null)
                callPayload.Queries["offset"] = CSharpExpressionConverter.ConvertO(offset);
            return new ApiConnectionAction<EventApiApiCollectionOfParticipantFee>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        public IBodyWorkflowAction<EventApiCreatedParticipantFee> CreateParticipantFee(Expression<Func<string>> participantId, Expression<Func<string>> bodyeventID, Expression<Func<string>> bodyfee, Expression<Func<int>> bodyquantity, Expression<Func<double>> bodyfeeAmount, Expression<Func<double>> bodycontributionAmount, Expression<Func<int>> bodydateday = null, Expression<Func<int>> bodydatemonth = null, Expression<Func<int>> bodydateyear = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/event/v1/participants/{0}/fees", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(participantId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["event_id"] = CSharpExpressionConverter.ConvertToken(bodyeventID);
            bodypropCount++;
            body["event_fee_id"] = CSharpExpressionConverter.ConvertToken(bodyfee);
            bodypropCount++;
            body["quantity"] = CSharpExpressionConverter.ConvertToken(bodyquantity);
            bodypropCount++;
            body["fee_amount"] = CSharpExpressionConverter.ConvertToken(bodyfeeAmount);
            bodypropCount++;
            body["contribution_amount"] = CSharpExpressionConverter.ConvertToken(bodycontributionAmount);
            var dateObject = new JObject();
            var dateObjectpropCount = 0;
            if (bodydateday != null)
            {
                dateObject["d"] = CSharpExpressionConverter.ConvertToken(bodydateday);
                dateObjectpropCount++;
            }

            if (bodydatemonth != null)
            {
                dateObject["m"] = CSharpExpressionConverter.ConvertToken(bodydatemonth);
                dateObjectpropCount++;
            }

            if (bodydateyear != null)
            {
                dateObject["y"] = CSharpExpressionConverter.ConvertToken(bodydateyear);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        public IBodyWorkflowAction<EventApiApiCollectionOfParticipantOption> ListParticipantOptions(Expression<Func<string>> participantId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/event/v1/participants/{0}/participantoptions", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(participantId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EventApiApiCollectionOfParticipantOption>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        public IBodyWorkflowAction<EventApiCreatedParticipantOption> CreateParticipantOption(Expression<Func<string>> participantId, Expression<Func<string>> bodyeventID, Expression<Func<string>> bodyoption, Expression<Func<object>> bodyoptionValue)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/event/v1/participants/{0}/participantoptions", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(participantId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["event_id"] = CSharpExpressionConverter.ConvertToken(bodyeventID);
            bodypropCount++;
            body["event_participant_option_id"] = CSharpExpressionConverter.ConvertToken(bodyoption);
            bodypropCount++;
            body["option_value"] = CSharpExpressionConverter.ConvertToken(bodyoptionValue);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<EventApiCreatedParticipantOption>(callPayload);
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