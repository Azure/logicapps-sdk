//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Blackbaudevents
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BlackbaudeventsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        [WorkflowExpressionFactory(nameof(__BuildListEvents))]
        public IBodyWorkflowAction<EventApiApiCollectionOfEventListEntry> ListEvents([WorkflowExpression] Func<string> category = null, [WorkflowExpression] Func<string> lookupId = null, [WorkflowExpression] Func<string> startDateFrom = null, [WorkflowExpression] Func<string> startDateTo = null, [WorkflowExpression] Func<bool> includeInactive = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<string> eventId = null, [WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<string> dateAdded = null, [WorkflowExpression] Func<string> lastModified = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<EventApiApiCollectionOfEventListEntry> __BuildListEvents(WorkflowValue<string> category = null, WorkflowValue<string> lookupId = null, WorkflowValue<string> startDateFrom = null, WorkflowValue<string> startDateTo = null, WorkflowValue<bool> includeInactive = null, WorkflowValue<int> limit = null, WorkflowValue<int> offset = null, WorkflowValue<string> eventId = null, WorkflowValue<string> name = null, WorkflowValue<string> dateAdded = null, WorkflowValue<string> lastModified = null)
        {
            WorkflowValue.Validate(category, nameof(category), required: false);
            WorkflowValue.Validate(lookupId, nameof(lookupId), required: false);
            WorkflowValue.Validate(startDateFrom, nameof(startDateFrom), required: false);
            WorkflowValue.Validate(startDateTo, nameof(startDateTo), required: false);
            WorkflowValue.Validate(includeInactive, nameof(includeInactive), required: false);
            WorkflowValue.Validate(limit, nameof(limit), required: false);
            WorkflowValue.Validate(offset, nameof(offset), required: false);
            WorkflowValue.Validate(eventId, nameof(eventId), required: false);
            WorkflowValue.Validate(name, nameof(name), required: false);
            WorkflowValue.Validate(dateAdded, nameof(dateAdded), required: false);
            WorkflowValue.Validate(lastModified, nameof(lastModified), required: false);
            return new DeferredBodyAction<EventApiApiCollectionOfEventListEntry>(() =>
            {
                var apiCallPath = "/event/v1/eventlist";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (category != null)
                    callPayload.Queries["category"] = ExpressionConverter.Convert(category);
                if (lookupId != null)
                    callPayload.Queries["lookup_id"] = ExpressionConverter.Convert(lookupId);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        [WorkflowExpressionFactory(nameof(__BuildCreateEvent))]
        public IBodyWorkflowAction<EventApiCreatedEvent> CreateEvent([WorkflowExpression] Func<string> bodyeventName, [WorkflowExpression] Func<string> bodycategorycategory, [WorkflowExpression] Func<string> bodystartDate, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodystartTime = null, [WorkflowExpression] Func<string> bodyendDate = null, [WorkflowExpression] Func<string> bodyendTime = null, [WorkflowExpression] Func<string> bodylookupID = null, [WorkflowExpression] Func<int> bodycapacity = null, [WorkflowExpression] Func<double> bodygoal = null, [WorkflowExpression] Func<string> bodycampaignID = null, [WorkflowExpression] Func<string> bodyfundID = null, [WorkflowExpression] Func<bool> bodyinactive = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<EventApiCreatedEvent> __BuildCreateEvent(WorkflowValue<string> bodyeventName, WorkflowValue<string> bodycategorycategory, WorkflowValue<string> bodystartDate, WorkflowValue<string> bodydescription = null, WorkflowValue<string> bodystartTime = null, WorkflowValue<string> bodyendDate = null, WorkflowValue<string> bodyendTime = null, WorkflowValue<string> bodylookupID = null, WorkflowValue<int> bodycapacity = null, WorkflowValue<double> bodygoal = null, WorkflowValue<string> bodycampaignID = null, WorkflowValue<string> bodyfundID = null, WorkflowValue<bool> bodyinactive = null)
        {
            WorkflowValue.Validate(bodyeventName, nameof(bodyeventName), required: true);
            WorkflowValue.Validate(bodycategorycategory, nameof(bodycategorycategory), required: true);
            WorkflowValue.Validate(bodystartDate, nameof(bodystartDate), required: true);
            WorkflowValue.Validate(bodydescription, nameof(bodydescription), required: false);
            WorkflowValue.Validate(bodystartTime, nameof(bodystartTime), required: false);
            WorkflowValue.Validate(bodyendDate, nameof(bodyendDate), required: false);
            WorkflowValue.Validate(bodyendTime, nameof(bodyendTime), required: false);
            WorkflowValue.Validate(bodylookupID, nameof(bodylookupID), required: false);
            WorkflowValue.Validate(bodycapacity, nameof(bodycapacity), required: false);
            WorkflowValue.Validate(bodygoal, nameof(bodygoal), required: false);
            WorkflowValue.Validate(bodycampaignID, nameof(bodycampaignID), required: false);
            WorkflowValue.Validate(bodyfundID, nameof(bodyfundID), required: false);
            WorkflowValue.Validate(bodyinactive, nameof(bodyinactive), required: false);
            return new DeferredBodyAction<EventApiCreatedEvent>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        [WorkflowExpressionFactory(nameof(__BuildGetEvent))]
        public IBodyWorkflowAction<EventApiEvent> GetEvent([WorkflowExpression] Func<string> eventId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<EventApiEvent> __BuildGetEvent(WorkflowValue<string> eventId)
        {
            WorkflowValue.Validate(eventId, nameof(eventId), required: true);
            return new DeferredBodyAction<EventApiEvent>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/event/v1/events/{0}", ExpressionConverter.ConvertWithUrlEncoding(eventId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EventApiEvent>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        [WorkflowExpressionFactory(nameof(__BuildEditEvent))]
        public IWorkflowAction EditEvent([WorkflowExpression] Func<string> eventId, [WorkflowExpression] Func<string> bodycategorycategory, [WorkflowExpression] Func<string> bodyeventName = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodystartTime = null, [WorkflowExpression] Func<string> bodyendDate = null, [WorkflowExpression] Func<string> bodyendTime = null, [WorkflowExpression] Func<string> bodylookupID = null, [WorkflowExpression] Func<int> bodycapacity = null, [WorkflowExpression] Func<double> bodygoal = null, [WorkflowExpression] Func<string> bodycampaignID = null, [WorkflowExpression] Func<string> bodyfundID = null, [WorkflowExpression] Func<bool> bodyinactive = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildEditEvent(WorkflowValue<string> eventId, WorkflowValue<string> bodycategorycategory, WorkflowValue<string> bodyeventName = null, WorkflowValue<string> bodydescription = null, WorkflowValue<string> bodystartDate = null, WorkflowValue<string> bodystartTime = null, WorkflowValue<string> bodyendDate = null, WorkflowValue<string> bodyendTime = null, WorkflowValue<string> bodylookupID = null, WorkflowValue<int> bodycapacity = null, WorkflowValue<double> bodygoal = null, WorkflowValue<string> bodycampaignID = null, WorkflowValue<string> bodyfundID = null, WorkflowValue<bool> bodyinactive = null)
        {
            WorkflowValue.Validate(eventId, nameof(eventId), required: true);
            WorkflowValue.Validate(bodycategorycategory, nameof(bodycategorycategory), required: true);
            WorkflowValue.Validate(bodyeventName, nameof(bodyeventName), required: false);
            WorkflowValue.Validate(bodydescription, nameof(bodydescription), required: false);
            WorkflowValue.Validate(bodystartDate, nameof(bodystartDate), required: false);
            WorkflowValue.Validate(bodystartTime, nameof(bodystartTime), required: false);
            WorkflowValue.Validate(bodyendDate, nameof(bodyendDate), required: false);
            WorkflowValue.Validate(bodyendTime, nameof(bodyendTime), required: false);
            WorkflowValue.Validate(bodylookupID, nameof(bodylookupID), required: false);
            WorkflowValue.Validate(bodycapacity, nameof(bodycapacity), required: false);
            WorkflowValue.Validate(bodygoal, nameof(bodygoal), required: false);
            WorkflowValue.Validate(bodycampaignID, nameof(bodycampaignID), required: false);
            WorkflowValue.Validate(bodyfundID, nameof(bodyfundID), required: false);
            WorkflowValue.Validate(bodyinactive, nameof(bodyinactive), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/event/v1/events/{0}", ExpressionConverter.ConvertWithUrlEncoding(eventId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        [WorkflowExpressionFactory(nameof(__BuildListEventAttachments))]
        public IBodyWorkflowAction<EventApiEventAttachmentCollection> ListEventAttachments([WorkflowExpression] Func<string> eventId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<EventApiEventAttachmentCollection> __BuildListEventAttachments(WorkflowValue<string> eventId)
        {
            WorkflowValue.Validate(eventId, nameof(eventId), required: true);
            return new DeferredBodyAction<EventApiEventAttachmentCollection>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/event/v1/events/{0}/attachments", ExpressionConverter.ConvertWithUrlEncoding(eventId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EventApiEventAttachmentCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        [WorkflowExpressionFactory(nameof(__BuildCreateEventAttachment))]
        public IBodyWorkflowAction<EventApiCreatedEventAttachment> CreateEventAttachment([WorkflowExpression] Func<string> eventId, [WorkflowExpression] Func<bodytypeInput> bodytype, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<string> bodyuRL = null, [WorkflowExpression] Func<string> bodyfileName = null, [WorkflowExpression] Func<string> bodyfileID = null, [WorkflowExpression] Func<string> bodythumbnailID = null, [WorkflowExpression] Func<string[]> bodytags = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<EventApiCreatedEventAttachment> __BuildCreateEventAttachment(WorkflowValue<string> eventId, WorkflowValue<bodytypeInput> bodytype, WorkflowValue<string> bodyname = null, WorkflowValue<string> bodydate = null, WorkflowValue<string> bodyuRL = null, WorkflowValue<string> bodyfileName = null, WorkflowValue<string> bodyfileID = null, WorkflowValue<string> bodythumbnailID = null, WorkflowValue<string[]> bodytags = null)
        {
            WorkflowValue.Validate(eventId, nameof(eventId), required: true);
            WorkflowValue.Validate(bodytype, nameof(bodytype), required: true);
            WorkflowValue.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowValue.Validate(bodydate, nameof(bodydate), required: false);
            WorkflowValue.Validate(bodyuRL, nameof(bodyuRL), required: false);
            WorkflowValue.Validate(bodyfileName, nameof(bodyfileName), required: false);
            WorkflowValue.Validate(bodyfileID, nameof(bodyfileID), required: false);
            WorkflowValue.Validate(bodythumbnailID, nameof(bodythumbnailID), required: false);
            WorkflowValue.Validate(bodytags, nameof(bodytags), required: false);
            return new DeferredBodyAction<EventApiCreatedEventAttachment>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/event/v1/events/{0}/attachments", ExpressionConverter.ConvertWithUrlEncoding(eventId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
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

                return new ApiConnectionAction<EventApiCreatedEventAttachment>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        [WorkflowExpressionFactory(nameof(__BuildEditEventAttachment))]
        public IWorkflowAction EditEventAttachment([WorkflowExpression] Func<string> eventId, [WorkflowExpression] Func<string> attachmentId, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<string> bodyuRL = null, [WorkflowExpression] Func<string[]> bodytags = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildEditEventAttachment(WorkflowValue<string> eventId, WorkflowValue<string> attachmentId, WorkflowValue<string> bodyname = null, WorkflowValue<string> bodydate = null, WorkflowValue<string> bodyuRL = null, WorkflowValue<string[]> bodytags = null)
        {
            WorkflowValue.Validate(eventId, nameof(eventId), required: true);
            WorkflowValue.Validate(attachmentId, nameof(attachmentId), required: true);
            WorkflowValue.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowValue.Validate(bodydate, nameof(bodydate), required: false);
            WorkflowValue.Validate(bodyuRL, nameof(bodyuRL), required: false);
            WorkflowValue.Validate(bodytags, nameof(bodytags), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/event/v1/events/{0}/attachments/{1}", ExpressionConverter.ConvertWithUrlEncoding(eventId, 1), ExpressionConverter.ConvertWithUrlEncoding(attachmentId, 1));
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        [WorkflowExpressionFactory(nameof(__BuildListEventFees))]
        public IBodyWorkflowAction<EventApiApiCollectionOfEventFee> ListEventFees([WorkflowExpression] Func<string> eventId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<EventApiApiCollectionOfEventFee> __BuildListEventFees(WorkflowValue<string> eventId)
        {
            WorkflowValue.Validate(eventId, nameof(eventId), required: true);
            return new DeferredBodyAction<EventApiApiCollectionOfEventFee>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/event/v1/events/{0}/eventfees", ExpressionConverter.ConvertWithUrlEncoding(eventId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EventApiApiCollectionOfEventFee>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        [WorkflowExpressionFactory(nameof(__BuildCreateEventFee))]
        public IBodyWorkflowAction<EventApiCreatedEventFee> CreateEventFee([WorkflowExpression] Func<string> eventId, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<double> bodyfeeAmount, [WorkflowExpression] Func<double> bodycontributionAmount)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<EventApiCreatedEventFee> __BuildCreateEventFee(WorkflowValue<string> eventId, WorkflowValue<string> bodyname, WorkflowValue<double> bodyfeeAmount, WorkflowValue<double> bodycontributionAmount)
        {
            WorkflowValue.Validate(eventId, nameof(eventId), required: true);
            WorkflowValue.Validate(bodyname, nameof(bodyname), required: true);
            WorkflowValue.Validate(bodyfeeAmount, nameof(bodyfeeAmount), required: true);
            WorkflowValue.Validate(bodycontributionAmount, nameof(bodycontributionAmount), required: true);
            return new DeferredBodyAction<EventApiCreatedEventFee>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/event/v1/events/{0}/eventfees", ExpressionConverter.ConvertWithUrlEncoding(eventId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        [WorkflowExpressionFactory(nameof(__BuildListEventParticipantOptions))]
        public IBodyWorkflowAction<EventApiApiCollectionOfEventParticipantOption> ListEventParticipantOptions([WorkflowExpression] Func<string> eventId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<EventApiApiCollectionOfEventParticipantOption> __BuildListEventParticipantOptions(WorkflowValue<string> eventId)
        {
            WorkflowValue.Validate(eventId, nameof(eventId), required: true);
            return new DeferredBodyAction<EventApiApiCollectionOfEventParticipantOption>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/event/v1/events/{0}/eventparticipantoptions", ExpressionConverter.ConvertWithUrlEncoding(eventId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EventApiApiCollectionOfEventParticipantOption>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        [WorkflowExpressionFactory(nameof(__BuildCreateEventParticipantOption))]
        public IBodyWorkflowAction<EventApiCreatedEventParticipantOption> CreateEventParticipantOption([WorkflowExpression] Func<string> eventId, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<bodyinputTypeInput> bodyinputType, [WorkflowExpression] Func<bool> bodyallowMultiSelect = null, [WorkflowExpression] Func<EventApiCreateParticipantOptionListOption[]> bodylistOptions = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<EventApiCreatedEventParticipantOption> __BuildCreateEventParticipantOption(WorkflowValue<string> eventId, WorkflowValue<string> bodyname, WorkflowValue<bodyinputTypeInput> bodyinputType, WorkflowValue<bool> bodyallowMultiSelect = null, WorkflowValue<EventApiCreateParticipantOptionListOption[]> bodylistOptions = null)
        {
            WorkflowValue.Validate(eventId, nameof(eventId), required: true);
            WorkflowValue.Validate(bodyname, nameof(bodyname), required: true);
            WorkflowValue.Validate(bodyinputType, nameof(bodyinputType), required: true);
            WorkflowValue.Validate(bodyallowMultiSelect, nameof(bodyallowMultiSelect), required: false);
            WorkflowValue.Validate(bodylistOptions, nameof(bodylistOptions), required: false);
            return new DeferredBodyAction<EventApiCreatedEventParticipantOption>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/event/v1/events/{0}/eventparticipantoptions", ExpressionConverter.ConvertWithUrlEncoding(eventId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        [WorkflowExpressionFactory(nameof(__BuildListEventParticipants))]
        public IBodyWorkflowAction<EventApiApiCollectionOfParticipantListEntry> ListEventParticipants([WorkflowExpression] Func<string> eventId, [WorkflowExpression] Func<rsvpStatusInput> rsvpStatus = null, [WorkflowExpression] Func<invitationStatusInput> invitationStatus = null, [WorkflowExpression] Func<string> participationLevel = null, [WorkflowExpression] Func<bool> attendedFilter = null, [WorkflowExpression] Func<bool> feesPaidFilter = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<bool> isConstituentFilter = null, [WorkflowExpression] Func<bool> emailEligibleFilter = null, [WorkflowExpression] Func<bool> phoneCallEligibleFilter = null, [WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<string> dateAdded = null, [WorkflowExpression] Func<string> lastModified = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<EventApiApiCollectionOfParticipantListEntry> __BuildListEventParticipants(WorkflowValue<string> eventId, WorkflowValue<rsvpStatusInput> rsvpStatus = null, WorkflowValue<invitationStatusInput> invitationStatus = null, WorkflowValue<string> participationLevel = null, WorkflowValue<bool> attendedFilter = null, WorkflowValue<bool> feesPaidFilter = null, WorkflowValue<int> limit = null, WorkflowValue<int> offset = null, WorkflowValue<bool> isConstituentFilter = null, WorkflowValue<bool> emailEligibleFilter = null, WorkflowValue<bool> phoneCallEligibleFilter = null, WorkflowValue<string> name = null, WorkflowValue<string> dateAdded = null, WorkflowValue<string> lastModified = null)
        {
            WorkflowValue.Validate(eventId, nameof(eventId), required: true);
            WorkflowValue.Validate(rsvpStatus, nameof(rsvpStatus), required: false);
            WorkflowValue.Validate(invitationStatus, nameof(invitationStatus), required: false);
            WorkflowValue.Validate(participationLevel, nameof(participationLevel), required: false);
            WorkflowValue.Validate(attendedFilter, nameof(attendedFilter), required: false);
            WorkflowValue.Validate(feesPaidFilter, nameof(feesPaidFilter), required: false);
            WorkflowValue.Validate(limit, nameof(limit), required: false);
            WorkflowValue.Validate(offset, nameof(offset), required: false);
            WorkflowValue.Validate(isConstituentFilter, nameof(isConstituentFilter), required: false);
            WorkflowValue.Validate(emailEligibleFilter, nameof(emailEligibleFilter), required: false);
            WorkflowValue.Validate(phoneCallEligibleFilter, nameof(phoneCallEligibleFilter), required: false);
            WorkflowValue.Validate(name, nameof(name), required: false);
            WorkflowValue.Validate(dateAdded, nameof(dateAdded), required: false);
            WorkflowValue.Validate(lastModified, nameof(lastModified), required: false);
            return new DeferredBodyAction<EventApiApiCollectionOfParticipantListEntry>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/event/v1/events/{0}/participants", ExpressionConverter.ConvertWithUrlEncoding(eventId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        [WorkflowExpressionFactory(nameof(__BuildCreateParticipant))]
        public IBodyWorkflowAction<EventApiCreatedParticipant> CreateParticipant([WorkflowExpression] Func<string> eventId, [WorkflowExpression] Func<string> bodyconstituentID, [WorkflowExpression] Func<string> bodyparticipationLevelparticipationLevel, [WorkflowExpression] Func<string> bodyhostID = null, [WorkflowExpression] Func<bodyrSVPStatusInput> bodyrSVPStatus = null, [WorkflowExpression] Func<bool> bodyattended = null, [WorkflowExpression] Func<bodyinvitationStatusInput> bodyinvitationStatus = null, [WorkflowExpression] Func<int> bodyrSVPDateday = null, [WorkflowExpression] Func<int> bodyrSVPDatemonth = null, [WorkflowExpression] Func<int> bodyrSVPDateyear = null, [WorkflowExpression] Func<int> bodyinvitationDateday = null, [WorkflowExpression] Func<int> bodyinvitationDatemonth = null, [WorkflowExpression] Func<int> bodyinvitationDateyear = null, [WorkflowExpression] Func<string> bodysummaryNote = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<EventApiCreatedParticipant> __BuildCreateParticipant(WorkflowValue<string> eventId, WorkflowValue<string> bodyconstituentID, WorkflowValue<string> bodyparticipationLevelparticipationLevel, WorkflowValue<string> bodyhostID = null, WorkflowValue<bodyrSVPStatusInput> bodyrSVPStatus = null, WorkflowValue<bool> bodyattended = null, WorkflowValue<bodyinvitationStatusInput> bodyinvitationStatus = null, WorkflowValue<int> bodyrSVPDateday = null, WorkflowValue<int> bodyrSVPDatemonth = null, WorkflowValue<int> bodyrSVPDateyear = null, WorkflowValue<int> bodyinvitationDateday = null, WorkflowValue<int> bodyinvitationDatemonth = null, WorkflowValue<int> bodyinvitationDateyear = null, WorkflowValue<string> bodysummaryNote = null)
        {
            WorkflowValue.Validate(eventId, nameof(eventId), required: true);
            WorkflowValue.Validate(bodyconstituentID, nameof(bodyconstituentID), required: true);
            WorkflowValue.Validate(bodyparticipationLevelparticipationLevel, nameof(bodyparticipationLevelparticipationLevel), required: true);
            WorkflowValue.Validate(bodyhostID, nameof(bodyhostID), required: false);
            WorkflowValue.Validate(bodyrSVPStatus, nameof(bodyrSVPStatus), required: false);
            WorkflowValue.Validate(bodyattended, nameof(bodyattended), required: false);
            WorkflowValue.Validate(bodyinvitationStatus, nameof(bodyinvitationStatus), required: false);
            WorkflowValue.Validate(bodyrSVPDateday, nameof(bodyrSVPDateday), required: false);
            WorkflowValue.Validate(bodyrSVPDatemonth, nameof(bodyrSVPDatemonth), required: false);
            WorkflowValue.Validate(bodyrSVPDateyear, nameof(bodyrSVPDateyear), required: false);
            WorkflowValue.Validate(bodyinvitationDateday, nameof(bodyinvitationDateday), required: false);
            WorkflowValue.Validate(bodyinvitationDatemonth, nameof(bodyinvitationDatemonth), required: false);
            WorkflowValue.Validate(bodyinvitationDateyear, nameof(bodyinvitationDateyear), required: false);
            WorkflowValue.Validate(bodysummaryNote, nameof(bodysummaryNote), required: false);
            return new DeferredBodyAction<EventApiCreatedParticipant>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/event/v1/events/{0}/participants", ExpressionConverter.ConvertWithUrlEncoding(eventId, 1));
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

                var rsvpDateObject = new JObject();
                var rsvpDateObjectpropCount = 0;
                if (bodyrSVPDateday != null)
                {
                    rsvpDateObject["d"] = ExpressionConverter.ConvertO(bodyrSVPDateday);
                    rsvpDateObjectpropCount++;
                }

                if (bodyrSVPDatemonth != null)
                {
                    rsvpDateObject["m"] = ExpressionConverter.ConvertO(bodyrSVPDatemonth);
                    rsvpDateObjectpropCount++;
                }

                if (bodyrSVPDateyear != null)
                {
                    rsvpDateObject["y"] = ExpressionConverter.ConvertO(bodyrSVPDateyear);
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
                    invitationDateObject["d"] = ExpressionConverter.ConvertO(bodyinvitationDateday);
                    invitationDateObjectpropCount++;
                }

                if (bodyinvitationDatemonth != null)
                {
                    invitationDateObject["m"] = ExpressionConverter.ConvertO(bodyinvitationDatemonth);
                    invitationDateObjectpropCount++;
                }

                if (bodyinvitationDateyear != null)
                {
                    invitationDateObject["y"] = ExpressionConverter.ConvertO(bodyinvitationDateyear);
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
                participationLevelObject["name"] = ExpressionConverter.ConvertO(bodyparticipationLevelparticipationLevel);
                if (participationLevelObjectpropCount > 0)
                {
                    body["participation_level"] = participationLevelObject;
                    bodypropCount++;
                }

                if (bodysummaryNote != null)
                {
                    body["summary_note"] = ExpressionConverter.ConvertO(bodysummaryNote);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<EventApiCreatedParticipant>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        [WorkflowExpressionFactory(nameof(__BuildEditParticipantOption))]
        public IWorkflowAction EditParticipantOption([WorkflowExpression] Func<string> optionId, [WorkflowExpression] Func<string> bodyvalue)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildEditParticipantOption(WorkflowValue<string> optionId, WorkflowValue<string> bodyvalue)
        {
            WorkflowValue.Validate(optionId, nameof(optionId), required: true);
            WorkflowValue.Validate(bodyvalue, nameof(bodyvalue), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/event/v1/participantoptions/{0}", ExpressionConverter.ConvertWithUrlEncoding(optionId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        [WorkflowExpressionFactory(nameof(__BuildGetParticipant))]
        public IBodyWorkflowAction<EventApiParticipant> GetParticipant([WorkflowExpression] Func<string> participantId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<EventApiParticipant> __BuildGetParticipant(WorkflowValue<string> participantId)
        {
            WorkflowValue.Validate(participantId, nameof(participantId), required: true);
            return new DeferredBodyAction<EventApiParticipant>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/event/v1/participants/{0}", ExpressionConverter.ConvertWithUrlEncoding(participantId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EventApiParticipant>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        [WorkflowExpressionFactory(nameof(__BuildEditParticipant))]
        public IWorkflowAction EditParticipant([WorkflowExpression] Func<string> participantId, [WorkflowExpression] Func<string> bodyparticipationLevelparticipationLevel, [WorkflowExpression] Func<string> bodyconstituentID = null, [WorkflowExpression] Func<string> bodyhostID = null, [WorkflowExpression] Func<bodyrSVPStatusInput> bodyrSVPStatus = null, [WorkflowExpression] Func<bool> bodyattended = null, [WorkflowExpression] Func<bodyinvitationStatusInput> bodyinvitationStatus = null, [WorkflowExpression] Func<int> bodyrSVPDateday = null, [WorkflowExpression] Func<int> bodyrSVPDatemonth = null, [WorkflowExpression] Func<int> bodyrSVPDateyear = null, [WorkflowExpression] Func<int> bodyinvitationDateday = null, [WorkflowExpression] Func<int> bodyinvitationDatemonth = null, [WorkflowExpression] Func<int> bodyinvitationDateyear = null, [WorkflowExpression] Func<string> bodysummaryNote = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildEditParticipant(WorkflowValue<string> participantId, WorkflowValue<string> bodyparticipationLevelparticipationLevel, WorkflowValue<string> bodyconstituentID = null, WorkflowValue<string> bodyhostID = null, WorkflowValue<bodyrSVPStatusInput> bodyrSVPStatus = null, WorkflowValue<bool> bodyattended = null, WorkflowValue<bodyinvitationStatusInput> bodyinvitationStatus = null, WorkflowValue<int> bodyrSVPDateday = null, WorkflowValue<int> bodyrSVPDatemonth = null, WorkflowValue<int> bodyrSVPDateyear = null, WorkflowValue<int> bodyinvitationDateday = null, WorkflowValue<int> bodyinvitationDatemonth = null, WorkflowValue<int> bodyinvitationDateyear = null, WorkflowValue<string> bodysummaryNote = null)
        {
            WorkflowValue.Validate(participantId, nameof(participantId), required: true);
            WorkflowValue.Validate(bodyparticipationLevelparticipationLevel, nameof(bodyparticipationLevelparticipationLevel), required: true);
            WorkflowValue.Validate(bodyconstituentID, nameof(bodyconstituentID), required: false);
            WorkflowValue.Validate(bodyhostID, nameof(bodyhostID), required: false);
            WorkflowValue.Validate(bodyrSVPStatus, nameof(bodyrSVPStatus), required: false);
            WorkflowValue.Validate(bodyattended, nameof(bodyattended), required: false);
            WorkflowValue.Validate(bodyinvitationStatus, nameof(bodyinvitationStatus), required: false);
            WorkflowValue.Validate(bodyrSVPDateday, nameof(bodyrSVPDateday), required: false);
            WorkflowValue.Validate(bodyrSVPDatemonth, nameof(bodyrSVPDatemonth), required: false);
            WorkflowValue.Validate(bodyrSVPDateyear, nameof(bodyrSVPDateyear), required: false);
            WorkflowValue.Validate(bodyinvitationDateday, nameof(bodyinvitationDateday), required: false);
            WorkflowValue.Validate(bodyinvitationDatemonth, nameof(bodyinvitationDatemonth), required: false);
            WorkflowValue.Validate(bodyinvitationDateyear, nameof(bodyinvitationDateyear), required: false);
            WorkflowValue.Validate(bodysummaryNote, nameof(bodysummaryNote), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/event/v1/participants/{0}", ExpressionConverter.ConvertWithUrlEncoding(participantId, 1));
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

                var rsvpDateObject = new JObject();
                var rsvpDateObjectpropCount = 0;
                if (bodyrSVPDateday != null)
                {
                    rsvpDateObject["d"] = ExpressionConverter.ConvertO(bodyrSVPDateday);
                    rsvpDateObjectpropCount++;
                }

                if (bodyrSVPDatemonth != null)
                {
                    rsvpDateObject["m"] = ExpressionConverter.ConvertO(bodyrSVPDatemonth);
                    rsvpDateObjectpropCount++;
                }

                if (bodyrSVPDateyear != null)
                {
                    rsvpDateObject["y"] = ExpressionConverter.ConvertO(bodyrSVPDateyear);
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
                    invitationDateObject["d"] = ExpressionConverter.ConvertO(bodyinvitationDateday);
                    invitationDateObjectpropCount++;
                }

                if (bodyinvitationDatemonth != null)
                {
                    invitationDateObject["m"] = ExpressionConverter.ConvertO(bodyinvitationDatemonth);
                    invitationDateObjectpropCount++;
                }

                if (bodyinvitationDateyear != null)
                {
                    invitationDateObject["y"] = ExpressionConverter.ConvertO(bodyinvitationDateyear);
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
                participationLevelObject["name"] = ExpressionConverter.ConvertO(bodyparticipationLevelparticipationLevel);
                if (participationLevelObjectpropCount > 0)
                {
                    body["participation_level"] = participationLevelObject;
                    bodypropCount++;
                }

                if (bodysummaryNote != null)
                {
                    body["summary_note"] = ExpressionConverter.ConvertO(bodysummaryNote);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        [WorkflowExpressionFactory(nameof(__BuildListParticipantDonations))]
        public IBodyWorkflowAction<EventApiApiCollectionOfParticipantDonation> ListParticipantDonations([WorkflowExpression] Func<string> participantId, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<EventApiApiCollectionOfParticipantDonation> __BuildListParticipantDonations(WorkflowValue<string> participantId, WorkflowValue<int> limit = null, WorkflowValue<int> offset = null)
        {
            WorkflowValue.Validate(participantId, nameof(participantId), required: true);
            WorkflowValue.Validate(limit, nameof(limit), required: false);
            WorkflowValue.Validate(offset, nameof(offset), required: false);
            return new DeferredBodyAction<EventApiApiCollectionOfParticipantDonation>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/event/v1/participants/{0}/donations", ExpressionConverter.ConvertWithUrlEncoding(participantId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = Convert.ToString(500);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                return new ApiConnectionAction<EventApiApiCollectionOfParticipantDonation>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        [WorkflowExpressionFactory(nameof(__BuildCreateParticipantDonation))]
        public IBodyWorkflowAction<EventApiCreatedParticipantDonation> CreateParticipantDonation([WorkflowExpression] Func<string> participantId, [WorkflowExpression] Func<string> bodygiftID)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<EventApiCreatedParticipantDonation> __BuildCreateParticipantDonation(WorkflowValue<string> participantId, WorkflowValue<string> bodygiftID)
        {
            WorkflowValue.Validate(participantId, nameof(participantId), required: true);
            WorkflowValue.Validate(bodygiftID, nameof(bodygiftID), required: true);
            return new DeferredBodyAction<EventApiCreatedParticipantDonation>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/event/v1/participants/{0}/donations", ExpressionConverter.ConvertWithUrlEncoding(participantId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        [WorkflowExpressionFactory(nameof(__BuildListParticipantFeePayments))]
        public IBodyWorkflowAction<EventApiApiCollectionOfParticipantFeePayment> ListParticipantFeePayments([WorkflowExpression] Func<string> participantId, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<EventApiApiCollectionOfParticipantFeePayment> __BuildListParticipantFeePayments(WorkflowValue<string> participantId, WorkflowValue<int> limit = null, WorkflowValue<int> offset = null)
        {
            WorkflowValue.Validate(participantId, nameof(participantId), required: true);
            WorkflowValue.Validate(limit, nameof(limit), required: false);
            WorkflowValue.Validate(offset, nameof(offset), required: false);
            return new DeferredBodyAction<EventApiApiCollectionOfParticipantFeePayment>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/event/v1/participants/{0}/feepayments", ExpressionConverter.ConvertWithUrlEncoding(participantId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = Convert.ToString(500);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                return new ApiConnectionAction<EventApiApiCollectionOfParticipantFeePayment>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        [WorkflowExpressionFactory(nameof(__BuildCreateParticipantFeePayment))]
        public IBodyWorkflowAction<EventApiCreatedParticipantFeePayment> CreateParticipantFeePayment([WorkflowExpression] Func<string> participantId, [WorkflowExpression] Func<string> bodygiftID, [WorkflowExpression] Func<double> bodyappliedAmount)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<EventApiCreatedParticipantFeePayment> __BuildCreateParticipantFeePayment(WorkflowValue<string> participantId, WorkflowValue<string> bodygiftID, WorkflowValue<double> bodyappliedAmount)
        {
            WorkflowValue.Validate(participantId, nameof(participantId), required: true);
            WorkflowValue.Validate(bodygiftID, nameof(bodygiftID), required: true);
            WorkflowValue.Validate(bodyappliedAmount, nameof(bodyappliedAmount), required: true);
            return new DeferredBodyAction<EventApiCreatedParticipantFeePayment>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/event/v1/participants/{0}/feepayments", ExpressionConverter.ConvertWithUrlEncoding(participantId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        [WorkflowExpressionFactory(nameof(__BuildListParticipantFees))]
        public IBodyWorkflowAction<EventApiApiCollectionOfParticipantFee> ListParticipantFees([WorkflowExpression] Func<string> participantId, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<EventApiApiCollectionOfParticipantFee> __BuildListParticipantFees(WorkflowValue<string> participantId, WorkflowValue<int> limit = null, WorkflowValue<int> offset = null)
        {
            WorkflowValue.Validate(participantId, nameof(participantId), required: true);
            WorkflowValue.Validate(limit, nameof(limit), required: false);
            WorkflowValue.Validate(offset, nameof(offset), required: false);
            return new DeferredBodyAction<EventApiApiCollectionOfParticipantFee>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/event/v1/participants/{0}/fees", ExpressionConverter.ConvertWithUrlEncoding(participantId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = Convert.ToString(500);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                return new ApiConnectionAction<EventApiApiCollectionOfParticipantFee>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        [WorkflowExpressionFactory(nameof(__BuildCreateParticipantFee))]
        public IBodyWorkflowAction<EventApiCreatedParticipantFee> CreateParticipantFee([WorkflowExpression] Func<string> participantId, [WorkflowExpression] Func<string> bodyeventID, [WorkflowExpression] Func<string> bodyfee, [WorkflowExpression] Func<int> bodyquantity, [WorkflowExpression] Func<double> bodyfeeAmount, [WorkflowExpression] Func<double> bodycontributionAmount, [WorkflowExpression] Func<int> bodydateday = null, [WorkflowExpression] Func<int> bodydatemonth = null, [WorkflowExpression] Func<int> bodydateyear = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<EventApiCreatedParticipantFee> __BuildCreateParticipantFee(WorkflowValue<string> participantId, WorkflowValue<string> bodyeventID, WorkflowValue<string> bodyfee, WorkflowValue<int> bodyquantity, WorkflowValue<double> bodyfeeAmount, WorkflowValue<double> bodycontributionAmount, WorkflowValue<int> bodydateday = null, WorkflowValue<int> bodydatemonth = null, WorkflowValue<int> bodydateyear = null)
        {
            WorkflowValue.Validate(participantId, nameof(participantId), required: true);
            WorkflowValue.Validate(bodyeventID, nameof(bodyeventID), required: true);
            WorkflowValue.Validate(bodyfee, nameof(bodyfee), required: true);
            WorkflowValue.Validate(bodyquantity, nameof(bodyquantity), required: true);
            WorkflowValue.Validate(bodyfeeAmount, nameof(bodyfeeAmount), required: true);
            WorkflowValue.Validate(bodycontributionAmount, nameof(bodycontributionAmount), required: true);
            WorkflowValue.Validate(bodydateday, nameof(bodydateday), required: false);
            WorkflowValue.Validate(bodydatemonth, nameof(bodydatemonth), required: false);
            WorkflowValue.Validate(bodydateyear, nameof(bodydateyear), required: false);
            return new DeferredBodyAction<EventApiCreatedParticipantFee>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/event/v1/participants/{0}/fees", ExpressionConverter.ConvertWithUrlEncoding(participantId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        [WorkflowExpressionFactory(nameof(__BuildListParticipantOptions))]
        public IBodyWorkflowAction<EventApiApiCollectionOfParticipantOption> ListParticipantOptions([WorkflowExpression] Func<string> participantId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<EventApiApiCollectionOfParticipantOption> __BuildListParticipantOptions(WorkflowValue<string> participantId)
        {
            WorkflowValue.Validate(participantId, nameof(participantId), required: true);
            return new DeferredBodyAction<EventApiApiCollectionOfParticipantOption>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/event/v1/participants/{0}/participantoptions", ExpressionConverter.ConvertWithUrlEncoding(participantId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EventApiApiCollectionOfParticipantOption>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        [WorkflowExpressionFactory(nameof(__BuildCreateParticipantOption))]
        public IBodyWorkflowAction<EventApiCreatedParticipantOption> CreateParticipantOption([WorkflowExpression] Func<string> participantId, [WorkflowExpression] Func<string> bodyeventID, [WorkflowExpression] Func<string> bodyoption, [WorkflowExpression] Func<object> bodyoptionValue)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<EventApiCreatedParticipantOption> __BuildCreateParticipantOption(WorkflowValue<string> participantId, WorkflowValue<string> bodyeventID, WorkflowValue<string> bodyoption, WorkflowValue<object> bodyoptionValue)
        {
            WorkflowValue.Validate(participantId, nameof(participantId), required: true);
            WorkflowValue.Validate(bodyeventID, nameof(bodyeventID), required: true);
            WorkflowValue.Validate(bodyoption, nameof(bodyoption), required: true);
            WorkflowValue.Validate(bodyoptionValue, nameof(bodyoptionValue), required: true);
            return new DeferredBodyAction<EventApiCreatedParticipantOption>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/event/v1/participants/{0}/participantoptions", ExpressionConverter.ConvertWithUrlEncoding(participantId, 1));
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
            });
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
