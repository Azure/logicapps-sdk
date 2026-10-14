//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Blackbaudevents
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class BlackbaudeventsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        public IBodyWorkflowAction<EventApiApiCollectionOfEventListEntry> ListEvents(Expression<Func<string>> category = null, Expression<Func<string>> lookupId = null, Expression<Func<string>> startDateFrom = null, Expression<Func<string>> startDateTo = null, Expression<Func<bool>> includeInactive = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<string>> eventId = null, Expression<Func<string>> name = null, Expression<Func<string>> dateAdded = null, Expression<Func<string>> lastModified = null)
        {
            var __workflow_category = category == null ? null : WorkflowExpression.Compile(category);
            WorkflowExpression.Validate(__workflow_category, nameof(category), required: false);
            var __workflow_lookupId = lookupId == null ? null : WorkflowExpression.Compile(lookupId);
            WorkflowExpression.Validate(__workflow_lookupId, nameof(lookupId), required: false);
            var __workflow_startDateFrom = startDateFrom == null ? null : WorkflowExpression.Compile(startDateFrom);
            WorkflowExpression.Validate(__workflow_startDateFrom, nameof(startDateFrom), required: false);
            var __workflow_startDateTo = startDateTo == null ? null : WorkflowExpression.Compile(startDateTo);
            WorkflowExpression.Validate(__workflow_startDateTo, nameof(startDateTo), required: false);
            var __workflow_includeInactive = includeInactive == null ? null : WorkflowExpression.Compile(includeInactive);
            WorkflowExpression.Validate(__workflow_includeInactive, nameof(includeInactive), required: false);
            var __workflow_limit = limit == null ? null : WorkflowExpression.Compile(limit);
            WorkflowExpression.Validate(__workflow_limit, nameof(limit), required: false);
            var __workflow_offset = offset == null ? null : WorkflowExpression.Compile(offset);
            WorkflowExpression.Validate(__workflow_offset, nameof(offset), required: false);
            var __workflow_eventId = eventId == null ? null : WorkflowExpression.Compile(eventId);
            WorkflowExpression.Validate(__workflow_eventId, nameof(eventId), required: false);
            var __workflow_name = name == null ? null : WorkflowExpression.Compile(name);
            WorkflowExpression.Validate(__workflow_name, nameof(name), required: false);
            var __workflow_dateAdded = dateAdded == null ? null : WorkflowExpression.Compile(dateAdded);
            WorkflowExpression.Validate(__workflow_dateAdded, nameof(dateAdded), required: false);
            var __workflow_lastModified = lastModified == null ? null : WorkflowExpression.Compile(lastModified);
            WorkflowExpression.Validate(__workflow_lastModified, nameof(lastModified), required: false);
            return new DeferredBodyAction<EventApiApiCollectionOfEventListEntry>(() =>
            {
                var apiCallPath = "/event/v1/eventlist";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_category != null)
                    callPayload.Queries["category"] = ExpressionConverter.Convert(__workflow_category);
                if (__workflow_lookupId != null)
                    callPayload.Queries["lookup_id"] = ExpressionConverter.Convert(__workflow_lookupId);
                if (__workflow_startDateFrom != null)
                    callPayload.Queries["start_date_from"] = ExpressionConverter.Convert(__workflow_startDateFrom);
                if (__workflow_startDateTo != null)
                    callPayload.Queries["start_date_to"] = ExpressionConverter.Convert(__workflow_startDateTo);
                if (__workflow_includeInactive != null)
                    callPayload.Queries["include_inactive"] = ExpressionConverter.Convert(__workflow_includeInactive);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_eventId != null)
                    callPayload.Queries["event_id"] = ExpressionConverter.Convert(__workflow_eventId);
                if (__workflow_name != null)
                    callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                if (__workflow_dateAdded != null)
                    callPayload.Queries["date_added"] = ExpressionConverter.Convert(__workflow_dateAdded);
                if (__workflow_lastModified != null)
                    callPayload.Queries["last_modified"] = ExpressionConverter.Convert(__workflow_lastModified);
                return new ApiConnectionAction<EventApiApiCollectionOfEventListEntry>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        public IBodyWorkflowAction<EventApiCreatedEvent> CreateEvent(Expression<Func<string>> bodyeventName, Expression<Func<string>> bodycategorycategory, Expression<Func<string>> bodystartDate, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodystartTime = null, Expression<Func<string>> bodyendDate = null, Expression<Func<string>> bodyendTime = null, Expression<Func<string>> bodylookupID = null, Expression<Func<int>> bodycapacity = null, Expression<Func<double>> bodygoal = null, Expression<Func<string>> bodycampaignID = null, Expression<Func<string>> bodyfundID = null, Expression<Func<bool>> bodyinactive = null)
        {
            var __workflow_bodyeventName = bodyeventName == null ? null : WorkflowExpression.Compile(bodyeventName);
            WorkflowExpression.Validate(__workflow_bodyeventName, nameof(bodyeventName), required: true);
            var __workflow_bodycategorycategory = bodycategorycategory == null ? null : WorkflowExpression.Compile(bodycategorycategory);
            WorkflowExpression.Validate(__workflow_bodycategorycategory, nameof(bodycategorycategory), required: true);
            var __workflow_bodystartDate = bodystartDate == null ? null : WorkflowExpression.Compile(bodystartDate);
            WorkflowExpression.Validate(__workflow_bodystartDate, nameof(bodystartDate), required: true);
            var __workflow_bodydescription = bodydescription == null ? null : WorkflowExpression.Compile(bodydescription);
            WorkflowExpression.Validate(__workflow_bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodystartTime = bodystartTime == null ? null : WorkflowExpression.Compile(bodystartTime);
            WorkflowExpression.Validate(__workflow_bodystartTime, nameof(bodystartTime), required: false);
            var __workflow_bodyendDate = bodyendDate == null ? null : WorkflowExpression.Compile(bodyendDate);
            WorkflowExpression.Validate(__workflow_bodyendDate, nameof(bodyendDate), required: false);
            var __workflow_bodyendTime = bodyendTime == null ? null : WorkflowExpression.Compile(bodyendTime);
            WorkflowExpression.Validate(__workflow_bodyendTime, nameof(bodyendTime), required: false);
            var __workflow_bodylookupID = bodylookupID == null ? null : WorkflowExpression.Compile(bodylookupID);
            WorkflowExpression.Validate(__workflow_bodylookupID, nameof(bodylookupID), required: false);
            var __workflow_bodycapacity = bodycapacity == null ? null : WorkflowExpression.Compile(bodycapacity);
            WorkflowExpression.Validate(__workflow_bodycapacity, nameof(bodycapacity), required: false);
            var __workflow_bodygoal = bodygoal == null ? null : WorkflowExpression.Compile(bodygoal);
            WorkflowExpression.Validate(__workflow_bodygoal, nameof(bodygoal), required: false);
            var __workflow_bodycampaignID = bodycampaignID == null ? null : WorkflowExpression.Compile(bodycampaignID);
            WorkflowExpression.Validate(__workflow_bodycampaignID, nameof(bodycampaignID), required: false);
            var __workflow_bodyfundID = bodyfundID == null ? null : WorkflowExpression.Compile(bodyfundID);
            WorkflowExpression.Validate(__workflow_bodyfundID, nameof(bodyfundID), required: false);
            var __workflow_bodyinactive = bodyinactive == null ? null : WorkflowExpression.Compile(bodyinactive);
            WorkflowExpression.Validate(__workflow_bodyinactive, nameof(bodyinactive), required: false);
            return new DeferredBodyAction<EventApiCreatedEvent>(() =>
            {
                var apiCallPath = "/event/v1/events";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyeventName);
                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                var categoryObject = new JObject();
                var categoryObjectpropCount = 0;
                categoryObjectpropCount++;
                categoryObject["name"] = ExpressionConverter.ConvertO(__workflow_bodycategorycategory);
                if (categoryObjectpropCount > 0)
                {
                    body["category"] = categoryObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["start_date"] = ExpressionConverter.ConvertO(__workflow_bodystartDate);
                if (__workflow_bodystartTime != null)
                {
                    body["start_time"] = ExpressionConverter.ConvertO(__workflow_bodystartTime);
                    bodypropCount++;
                }

                if (__workflow_bodyendDate != null)
                {
                    body["end_date"] = ExpressionConverter.ConvertO(__workflow_bodyendDate);
                    bodypropCount++;
                }

                if (__workflow_bodyendTime != null)
                {
                    body["end_time"] = ExpressionConverter.ConvertO(__workflow_bodyendTime);
                    bodypropCount++;
                }

                if (__workflow_bodylookupID != null)
                {
                    body["lookup_id"] = ExpressionConverter.ConvertO(__workflow_bodylookupID);
                    bodypropCount++;
                }

                if (__workflow_bodycapacity != null)
                {
                    body["capacity"] = ExpressionConverter.ConvertO(__workflow_bodycapacity);
                    bodypropCount++;
                }

                if (__workflow_bodygoal != null)
                {
                    body["goal"] = ExpressionConverter.ConvertO(__workflow_bodygoal);
                    bodypropCount++;
                }

                if (__workflow_bodycampaignID != null)
                {
                    body["campaign_id"] = ExpressionConverter.ConvertO(__workflow_bodycampaignID);
                    bodypropCount++;
                }

                if (__workflow_bodyfundID != null)
                {
                    body["fund_id"] = ExpressionConverter.ConvertO(__workflow_bodyfundID);
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

                return new ApiConnectionAction<EventApiCreatedEvent>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        public IBodyWorkflowAction<EventApiEvent> GetEvent(Expression<Func<string>> eventId)
        {
            var __workflow_eventId = eventId == null ? null : WorkflowExpression.Compile(eventId);
            WorkflowExpression.Validate(__workflow_eventId, nameof(eventId), required: true);
            return new DeferredBodyAction<EventApiEvent>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/event/v1/events/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_eventId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EventApiEvent>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        public IWorkflowAction EditEvent(Expression<Func<string>> eventId, Expression<Func<string>> bodycategorycategory, Expression<Func<string>> bodyeventName = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodystartTime = null, Expression<Func<string>> bodyendDate = null, Expression<Func<string>> bodyendTime = null, Expression<Func<string>> bodylookupID = null, Expression<Func<int>> bodycapacity = null, Expression<Func<double>> bodygoal = null, Expression<Func<string>> bodycampaignID = null, Expression<Func<string>> bodyfundID = null, Expression<Func<bool>> bodyinactive = null)
        {
            var __workflow_eventId = eventId == null ? null : WorkflowExpression.Compile(eventId);
            WorkflowExpression.Validate(__workflow_eventId, nameof(eventId), required: true);
            var __workflow_bodycategorycategory = bodycategorycategory == null ? null : WorkflowExpression.Compile(bodycategorycategory);
            WorkflowExpression.Validate(__workflow_bodycategorycategory, nameof(bodycategorycategory), required: true);
            var __workflow_bodyeventName = bodyeventName == null ? null : WorkflowExpression.Compile(bodyeventName);
            WorkflowExpression.Validate(__workflow_bodyeventName, nameof(bodyeventName), required: false);
            var __workflow_bodydescription = bodydescription == null ? null : WorkflowExpression.Compile(bodydescription);
            WorkflowExpression.Validate(__workflow_bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodystartDate = bodystartDate == null ? null : WorkflowExpression.Compile(bodystartDate);
            WorkflowExpression.Validate(__workflow_bodystartDate, nameof(bodystartDate), required: false);
            var __workflow_bodystartTime = bodystartTime == null ? null : WorkflowExpression.Compile(bodystartTime);
            WorkflowExpression.Validate(__workflow_bodystartTime, nameof(bodystartTime), required: false);
            var __workflow_bodyendDate = bodyendDate == null ? null : WorkflowExpression.Compile(bodyendDate);
            WorkflowExpression.Validate(__workflow_bodyendDate, nameof(bodyendDate), required: false);
            var __workflow_bodyendTime = bodyendTime == null ? null : WorkflowExpression.Compile(bodyendTime);
            WorkflowExpression.Validate(__workflow_bodyendTime, nameof(bodyendTime), required: false);
            var __workflow_bodylookupID = bodylookupID == null ? null : WorkflowExpression.Compile(bodylookupID);
            WorkflowExpression.Validate(__workflow_bodylookupID, nameof(bodylookupID), required: false);
            var __workflow_bodycapacity = bodycapacity == null ? null : WorkflowExpression.Compile(bodycapacity);
            WorkflowExpression.Validate(__workflow_bodycapacity, nameof(bodycapacity), required: false);
            var __workflow_bodygoal = bodygoal == null ? null : WorkflowExpression.Compile(bodygoal);
            WorkflowExpression.Validate(__workflow_bodygoal, nameof(bodygoal), required: false);
            var __workflow_bodycampaignID = bodycampaignID == null ? null : WorkflowExpression.Compile(bodycampaignID);
            WorkflowExpression.Validate(__workflow_bodycampaignID, nameof(bodycampaignID), required: false);
            var __workflow_bodyfundID = bodyfundID == null ? null : WorkflowExpression.Compile(bodyfundID);
            WorkflowExpression.Validate(__workflow_bodyfundID, nameof(bodyfundID), required: false);
            var __workflow_bodyinactive = bodyinactive == null ? null : WorkflowExpression.Compile(bodyinactive);
            WorkflowExpression.Validate(__workflow_bodyinactive, nameof(bodyinactive), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/event/v1/events/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_eventId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyeventName != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyeventName);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                var categoryObject = new JObject();
                var categoryObjectpropCount = 0;
                categoryObjectpropCount++;
                categoryObject["name"] = ExpressionConverter.ConvertO(__workflow_bodycategorycategory);
                if (categoryObjectpropCount > 0)
                {
                    body["category"] = categoryObject;
                    bodypropCount++;
                }

                if (__workflow_bodystartDate != null)
                {
                    body["start_date"] = ExpressionConverter.ConvertO(__workflow_bodystartDate);
                    bodypropCount++;
                }

                if (__workflow_bodystartTime != null)
                {
                    body["start_time"] = ExpressionConverter.ConvertO(__workflow_bodystartTime);
                    bodypropCount++;
                }

                if (__workflow_bodyendDate != null)
                {
                    body["end_date"] = ExpressionConverter.ConvertO(__workflow_bodyendDate);
                    bodypropCount++;
                }

                if (__workflow_bodyendTime != null)
                {
                    body["end_time"] = ExpressionConverter.ConvertO(__workflow_bodyendTime);
                    bodypropCount++;
                }

                if (__workflow_bodylookupID != null)
                {
                    body["lookup_id"] = ExpressionConverter.ConvertO(__workflow_bodylookupID);
                    bodypropCount++;
                }

                if (__workflow_bodycapacity != null)
                {
                    body["capacity"] = ExpressionConverter.ConvertO(__workflow_bodycapacity);
                    bodypropCount++;
                }

                if (__workflow_bodygoal != null)
                {
                    body["goal"] = ExpressionConverter.ConvertO(__workflow_bodygoal);
                    bodypropCount++;
                }

                if (__workflow_bodycampaignID != null)
                {
                    body["campaign_id"] = ExpressionConverter.ConvertO(__workflow_bodycampaignID);
                    bodypropCount++;
                }

                if (__workflow_bodyfundID != null)
                {
                    body["fund_id"] = ExpressionConverter.ConvertO(__workflow_bodyfundID);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        public IBodyWorkflowAction<EventApiEventAttachmentCollection> ListEventAttachments(Expression<Func<string>> eventId)
        {
            var __workflow_eventId = eventId == null ? null : WorkflowExpression.Compile(eventId);
            WorkflowExpression.Validate(__workflow_eventId, nameof(eventId), required: true);
            return new DeferredBodyAction<EventApiEventAttachmentCollection>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/event/v1/events/{0}/attachments", ExpressionConverter.ConvertWithUrlEncoding(__workflow_eventId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EventApiEventAttachmentCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        public IBodyWorkflowAction<EventApiCreatedEventAttachment> CreateEventAttachment(Expression<Func<string>> eventId, Expression<Func<bodytypeInput>> bodytype, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodyuRL = null, Expression<Func<string>> bodyfileName = null, Expression<Func<string>> bodyfileID = null, Expression<Func<string>> bodythumbnailID = null, Expression<Func<string[]>> bodytags = null)
        {
            var __workflow_eventId = eventId == null ? null : WorkflowExpression.Compile(eventId);
            WorkflowExpression.Validate(__workflow_eventId, nameof(eventId), required: true);
            var __workflow_bodytype = bodytype == null ? null : WorkflowExpression.Compile(bodytype);
            WorkflowExpression.Validate(__workflow_bodytype, nameof(bodytype), required: true);
            var __workflow_bodyname = bodyname == null ? null : WorkflowExpression.Compile(bodyname);
            WorkflowExpression.Validate(__workflow_bodyname, nameof(bodyname), required: false);
            var __workflow_bodydate = bodydate == null ? null : WorkflowExpression.Compile(bodydate);
            WorkflowExpression.Validate(__workflow_bodydate, nameof(bodydate), required: false);
            var __workflow_bodyuRL = bodyuRL == null ? null : WorkflowExpression.Compile(bodyuRL);
            WorkflowExpression.Validate(__workflow_bodyuRL, nameof(bodyuRL), required: false);
            var __workflow_bodyfileName = bodyfileName == null ? null : WorkflowExpression.Compile(bodyfileName);
            WorkflowExpression.Validate(__workflow_bodyfileName, nameof(bodyfileName), required: false);
            var __workflow_bodyfileID = bodyfileID == null ? null : WorkflowExpression.Compile(bodyfileID);
            WorkflowExpression.Validate(__workflow_bodyfileID, nameof(bodyfileID), required: false);
            var __workflow_bodythumbnailID = bodythumbnailID == null ? null : WorkflowExpression.Compile(bodythumbnailID);
            WorkflowExpression.Validate(__workflow_bodythumbnailID, nameof(bodythumbnailID), required: false);
            var __workflow_bodytags = bodytags == null ? null : WorkflowExpression.Compile(bodytags);
            WorkflowExpression.Validate(__workflow_bodytags, nameof(bodytags), required: false);
            return new DeferredBodyAction<EventApiCreatedEventAttachment>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/event/v1/events/{0}/attachments", ExpressionConverter.ConvertWithUrlEncoding(__workflow_eventId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
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

                if (__workflow_bodyfileID != null)
                {
                    body["file_id"] = ExpressionConverter.ConvertO(__workflow_bodyfileID);
                    bodypropCount++;
                }

                if (__workflow_bodythumbnailID != null)
                {
                    body["thumbnail_id"] = ExpressionConverter.ConvertO(__workflow_bodythumbnailID);
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

                return new ApiConnectionAction<EventApiCreatedEventAttachment>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        public IWorkflowAction EditEventAttachment(Expression<Func<string>> eventId, Expression<Func<string>> attachmentId, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodyuRL = null, Expression<Func<string[]>> bodytags = null)
        {
            var __workflow_eventId = eventId == null ? null : WorkflowExpression.Compile(eventId);
            WorkflowExpression.Validate(__workflow_eventId, nameof(eventId), required: true);
            var __workflow_attachmentId = attachmentId == null ? null : WorkflowExpression.Compile(attachmentId);
            WorkflowExpression.Validate(__workflow_attachmentId, nameof(attachmentId), required: true);
            var __workflow_bodyname = bodyname == null ? null : WorkflowExpression.Compile(bodyname);
            WorkflowExpression.Validate(__workflow_bodyname, nameof(bodyname), required: false);
            var __workflow_bodydate = bodydate == null ? null : WorkflowExpression.Compile(bodydate);
            WorkflowExpression.Validate(__workflow_bodydate, nameof(bodydate), required: false);
            var __workflow_bodyuRL = bodyuRL == null ? null : WorkflowExpression.Compile(bodyuRL);
            WorkflowExpression.Validate(__workflow_bodyuRL, nameof(bodyuRL), required: false);
            var __workflow_bodytags = bodytags == null ? null : WorkflowExpression.Compile(bodytags);
            WorkflowExpression.Validate(__workflow_bodytags, nameof(bodytags), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/event/v1/events/{0}/attachments/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_eventId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_attachmentId, 1));
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        public IBodyWorkflowAction<EventApiApiCollectionOfEventFee> ListEventFees(Expression<Func<string>> eventId)
        {
            var __workflow_eventId = eventId == null ? null : WorkflowExpression.Compile(eventId);
            WorkflowExpression.Validate(__workflow_eventId, nameof(eventId), required: true);
            return new DeferredBodyAction<EventApiApiCollectionOfEventFee>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/event/v1/events/{0}/eventfees", ExpressionConverter.ConvertWithUrlEncoding(__workflow_eventId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EventApiApiCollectionOfEventFee>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        public IBodyWorkflowAction<EventApiCreatedEventFee> CreateEventFee(Expression<Func<string>> eventId, Expression<Func<string>> bodyname, Expression<Func<double>> bodyfeeAmount, Expression<Func<double>> bodycontributionAmount)
        {
            var __workflow_eventId = eventId == null ? null : WorkflowExpression.Compile(eventId);
            WorkflowExpression.Validate(__workflow_eventId, nameof(eventId), required: true);
            var __workflow_bodyname = bodyname == null ? null : WorkflowExpression.Compile(bodyname);
            WorkflowExpression.Validate(__workflow_bodyname, nameof(bodyname), required: true);
            var __workflow_bodyfeeAmount = bodyfeeAmount == null ? null : WorkflowExpression.Compile(bodyfeeAmount);
            WorkflowExpression.Validate(__workflow_bodyfeeAmount, nameof(bodyfeeAmount), required: true);
            var __workflow_bodycontributionAmount = bodycontributionAmount == null ? null : WorkflowExpression.Compile(bodycontributionAmount);
            WorkflowExpression.Validate(__workflow_bodycontributionAmount, nameof(bodycontributionAmount), required: true);
            return new DeferredBodyAction<EventApiCreatedEventFee>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/event/v1/events/{0}/eventfees", ExpressionConverter.ConvertWithUrlEncoding(__workflow_eventId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                bodypropCount++;
                body["cost"] = ExpressionConverter.ConvertO(__workflow_bodyfeeAmount);
                bodypropCount++;
                body["contribution_amount"] = ExpressionConverter.ConvertO(__workflow_bodycontributionAmount);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<EventApiCreatedEventFee>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        public IBodyWorkflowAction<EventApiApiCollectionOfEventParticipantOption> ListEventParticipantOptions(Expression<Func<string>> eventId)
        {
            var __workflow_eventId = eventId == null ? null : WorkflowExpression.Compile(eventId);
            WorkflowExpression.Validate(__workflow_eventId, nameof(eventId), required: true);
            return new DeferredBodyAction<EventApiApiCollectionOfEventParticipantOption>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/event/v1/events/{0}/eventparticipantoptions", ExpressionConverter.ConvertWithUrlEncoding(__workflow_eventId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EventApiApiCollectionOfEventParticipantOption>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        public IBodyWorkflowAction<EventApiCreatedEventParticipantOption> CreateEventParticipantOption(Expression<Func<string>> eventId, Expression<Func<string>> bodyname, Expression<Func<bodyinputTypeInput>> bodyinputType, Expression<Func<bool>> bodyallowMultiSelect = null, Expression<Func<EventApiCreateParticipantOptionListOption[]>> bodylistOptions = null)
        {
            var __workflow_eventId = eventId == null ? null : WorkflowExpression.Compile(eventId);
            WorkflowExpression.Validate(__workflow_eventId, nameof(eventId), required: true);
            var __workflow_bodyname = bodyname == null ? null : WorkflowExpression.Compile(bodyname);
            WorkflowExpression.Validate(__workflow_bodyname, nameof(bodyname), required: true);
            var __workflow_bodyinputType = bodyinputType == null ? null : WorkflowExpression.Compile(bodyinputType);
            WorkflowExpression.Validate(__workflow_bodyinputType, nameof(bodyinputType), required: true);
            var __workflow_bodyallowMultiSelect = bodyallowMultiSelect == null ? null : WorkflowExpression.Compile(bodyallowMultiSelect);
            WorkflowExpression.Validate(__workflow_bodyallowMultiSelect, nameof(bodyallowMultiSelect), required: false);
            var __workflow_bodylistOptions = bodylistOptions == null ? null : WorkflowExpression.Compile(bodylistOptions);
            WorkflowExpression.Validate(__workflow_bodylistOptions, nameof(bodylistOptions), required: false);
            return new DeferredBodyAction<EventApiCreatedEventParticipantOption>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/event/v1/events/{0}/eventparticipantoptions", ExpressionConverter.ConvertWithUrlEncoding(__workflow_eventId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                bodypropCount++;
                body["input_type"] = ExpressionConverter.ConvertO(__workflow_bodyinputType);
                if (__workflow_bodyallowMultiSelect != null)
                {
                    body["multi_select"] = ExpressionConverter.ConvertO(__workflow_bodyallowMultiSelect);
                    bodypropCount++;
                }

                if (__workflow_bodylistOptions != null)
                {
                    body["list_options"] = ExpressionConverter.ConvertO(__workflow_bodylistOptions);
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
        public IBodyWorkflowAction<EventApiApiCollectionOfParticipantListEntry> ListEventParticipants(Expression<Func<string>> eventId, Expression<Func<rsvpStatusInput>> rsvpStatus = null, Expression<Func<invitationStatusInput>> invitationStatus = null, Expression<Func<string>> participationLevel = null, Expression<Func<bool>> attendedFilter = null, Expression<Func<bool>> feesPaidFilter = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<bool>> isConstituentFilter = null, Expression<Func<bool>> emailEligibleFilter = null, Expression<Func<bool>> phoneCallEligibleFilter = null, Expression<Func<string>> name = null, Expression<Func<string>> dateAdded = null, Expression<Func<string>> lastModified = null)
        {
            var __workflow_eventId = eventId == null ? null : WorkflowExpression.Compile(eventId);
            WorkflowExpression.Validate(__workflow_eventId, nameof(eventId), required: true);
            var __workflow_rsvpStatus = rsvpStatus == null ? null : WorkflowExpression.Compile(rsvpStatus);
            WorkflowExpression.Validate(__workflow_rsvpStatus, nameof(rsvpStatus), required: false);
            var __workflow_invitationStatus = invitationStatus == null ? null : WorkflowExpression.Compile(invitationStatus);
            WorkflowExpression.Validate(__workflow_invitationStatus, nameof(invitationStatus), required: false);
            var __workflow_participationLevel = participationLevel == null ? null : WorkflowExpression.Compile(participationLevel);
            WorkflowExpression.Validate(__workflow_participationLevel, nameof(participationLevel), required: false);
            var __workflow_attendedFilter = attendedFilter == null ? null : WorkflowExpression.Compile(attendedFilter);
            WorkflowExpression.Validate(__workflow_attendedFilter, nameof(attendedFilter), required: false);
            var __workflow_feesPaidFilter = feesPaidFilter == null ? null : WorkflowExpression.Compile(feesPaidFilter);
            WorkflowExpression.Validate(__workflow_feesPaidFilter, nameof(feesPaidFilter), required: false);
            var __workflow_limit = limit == null ? null : WorkflowExpression.Compile(limit);
            WorkflowExpression.Validate(__workflow_limit, nameof(limit), required: false);
            var __workflow_offset = offset == null ? null : WorkflowExpression.Compile(offset);
            WorkflowExpression.Validate(__workflow_offset, nameof(offset), required: false);
            var __workflow_isConstituentFilter = isConstituentFilter == null ? null : WorkflowExpression.Compile(isConstituentFilter);
            WorkflowExpression.Validate(__workflow_isConstituentFilter, nameof(isConstituentFilter), required: false);
            var __workflow_emailEligibleFilter = emailEligibleFilter == null ? null : WorkflowExpression.Compile(emailEligibleFilter);
            WorkflowExpression.Validate(__workflow_emailEligibleFilter, nameof(emailEligibleFilter), required: false);
            var __workflow_phoneCallEligibleFilter = phoneCallEligibleFilter == null ? null : WorkflowExpression.Compile(phoneCallEligibleFilter);
            WorkflowExpression.Validate(__workflow_phoneCallEligibleFilter, nameof(phoneCallEligibleFilter), required: false);
            var __workflow_name = name == null ? null : WorkflowExpression.Compile(name);
            WorkflowExpression.Validate(__workflow_name, nameof(name), required: false);
            var __workflow_dateAdded = dateAdded == null ? null : WorkflowExpression.Compile(dateAdded);
            WorkflowExpression.Validate(__workflow_dateAdded, nameof(dateAdded), required: false);
            var __workflow_lastModified = lastModified == null ? null : WorkflowExpression.Compile(lastModified);
            WorkflowExpression.Validate(__workflow_lastModified, nameof(lastModified), required: false);
            return new DeferredBodyAction<EventApiApiCollectionOfParticipantListEntry>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/event/v1/events/{0}/participants", ExpressionConverter.ConvertWithUrlEncoding(__workflow_eventId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_rsvpStatus != null)
                    callPayload.Queries["rsvp_status"] = ExpressionConverter.Convert(__workflow_rsvpStatus);
                if (__workflow_invitationStatus != null)
                    callPayload.Queries["invitation_status"] = ExpressionConverter.Convert(__workflow_invitationStatus);
                if (__workflow_participationLevel != null)
                    callPayload.Queries["participation_level"] = ExpressionConverter.Convert(__workflow_participationLevel);
                if (__workflow_attendedFilter != null)
                    callPayload.Queries["attended_filter"] = ExpressionConverter.Convert(__workflow_attendedFilter);
                if (__workflow_feesPaidFilter != null)
                    callPayload.Queries["fees_paid_filter"] = ExpressionConverter.Convert(__workflow_feesPaidFilter);
                callPayload.Queries["limit"] = Convert.ToString(500);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_isConstituentFilter != null)
                    callPayload.Queries["is_constituent_filter"] = ExpressionConverter.Convert(__workflow_isConstituentFilter);
                if (__workflow_emailEligibleFilter != null)
                    callPayload.Queries["email_eligible_filter"] = ExpressionConverter.Convert(__workflow_emailEligibleFilter);
                if (__workflow_phoneCallEligibleFilter != null)
                    callPayload.Queries["phone_call_eligible_filter"] = ExpressionConverter.Convert(__workflow_phoneCallEligibleFilter);
                if (__workflow_name != null)
                    callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                if (__workflow_dateAdded != null)
                    callPayload.Queries["date_added"] = ExpressionConverter.Convert(__workflow_dateAdded);
                if (__workflow_lastModified != null)
                    callPayload.Queries["last_modified"] = ExpressionConverter.Convert(__workflow_lastModified);
                return new ApiConnectionAction<EventApiApiCollectionOfParticipantListEntry>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        public IBodyWorkflowAction<EventApiCreatedParticipant> CreateParticipant(Expression<Func<string>> eventId, Expression<Func<string>> bodyconstituentID, Expression<Func<string>> bodyparticipationLevelparticipationLevel, Expression<Func<string>> bodyhostID = null, Expression<Func<bodyrSVPStatusInput>> bodyrSVPStatus = null, Expression<Func<bool>> bodyattended = null, Expression<Func<bodyinvitationStatusInput>> bodyinvitationStatus = null, Expression<Func<int>> bodyrSVPDateday = null, Expression<Func<int>> bodyrSVPDatemonth = null, Expression<Func<int>> bodyrSVPDateyear = null, Expression<Func<int>> bodyinvitationDateday = null, Expression<Func<int>> bodyinvitationDatemonth = null, Expression<Func<int>> bodyinvitationDateyear = null, Expression<Func<string>> bodysummaryNote = null)
        {
            var __workflow_eventId = eventId == null ? null : WorkflowExpression.Compile(eventId);
            WorkflowExpression.Validate(__workflow_eventId, nameof(eventId), required: true);
            var __workflow_bodyconstituentID = bodyconstituentID == null ? null : WorkflowExpression.Compile(bodyconstituentID);
            WorkflowExpression.Validate(__workflow_bodyconstituentID, nameof(bodyconstituentID), required: true);
            var __workflow_bodyparticipationLevelparticipationLevel = bodyparticipationLevelparticipationLevel == null ? null : WorkflowExpression.Compile(bodyparticipationLevelparticipationLevel);
            WorkflowExpression.Validate(__workflow_bodyparticipationLevelparticipationLevel, nameof(bodyparticipationLevelparticipationLevel), required: true);
            var __workflow_bodyhostID = bodyhostID == null ? null : WorkflowExpression.Compile(bodyhostID);
            WorkflowExpression.Validate(__workflow_bodyhostID, nameof(bodyhostID), required: false);
            var __workflow_bodyrSVPStatus = bodyrSVPStatus == null ? null : WorkflowExpression.Compile(bodyrSVPStatus);
            WorkflowExpression.Validate(__workflow_bodyrSVPStatus, nameof(bodyrSVPStatus), required: false);
            var __workflow_bodyattended = bodyattended == null ? null : WorkflowExpression.Compile(bodyattended);
            WorkflowExpression.Validate(__workflow_bodyattended, nameof(bodyattended), required: false);
            var __workflow_bodyinvitationStatus = bodyinvitationStatus == null ? null : WorkflowExpression.Compile(bodyinvitationStatus);
            WorkflowExpression.Validate(__workflow_bodyinvitationStatus, nameof(bodyinvitationStatus), required: false);
            var __workflow_bodyrSVPDateday = bodyrSVPDateday == null ? null : WorkflowExpression.Compile(bodyrSVPDateday);
            WorkflowExpression.Validate(__workflow_bodyrSVPDateday, nameof(bodyrSVPDateday), required: false);
            var __workflow_bodyrSVPDatemonth = bodyrSVPDatemonth == null ? null : WorkflowExpression.Compile(bodyrSVPDatemonth);
            WorkflowExpression.Validate(__workflow_bodyrSVPDatemonth, nameof(bodyrSVPDatemonth), required: false);
            var __workflow_bodyrSVPDateyear = bodyrSVPDateyear == null ? null : WorkflowExpression.Compile(bodyrSVPDateyear);
            WorkflowExpression.Validate(__workflow_bodyrSVPDateyear, nameof(bodyrSVPDateyear), required: false);
            var __workflow_bodyinvitationDateday = bodyinvitationDateday == null ? null : WorkflowExpression.Compile(bodyinvitationDateday);
            WorkflowExpression.Validate(__workflow_bodyinvitationDateday, nameof(bodyinvitationDateday), required: false);
            var __workflow_bodyinvitationDatemonth = bodyinvitationDatemonth == null ? null : WorkflowExpression.Compile(bodyinvitationDatemonth);
            WorkflowExpression.Validate(__workflow_bodyinvitationDatemonth, nameof(bodyinvitationDatemonth), required: false);
            var __workflow_bodyinvitationDateyear = bodyinvitationDateyear == null ? null : WorkflowExpression.Compile(bodyinvitationDateyear);
            WorkflowExpression.Validate(__workflow_bodyinvitationDateyear, nameof(bodyinvitationDateyear), required: false);
            var __workflow_bodysummaryNote = bodysummaryNote == null ? null : WorkflowExpression.Compile(bodysummaryNote);
            WorkflowExpression.Validate(__workflow_bodysummaryNote, nameof(bodysummaryNote), required: false);
            return new DeferredBodyAction<EventApiCreatedParticipant>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/event/v1/events/{0}/participants", ExpressionConverter.ConvertWithUrlEncoding(__workflow_eventId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = ExpressionConverter.ConvertO(__workflow_bodyconstituentID);
                if (__workflow_bodyhostID != null)
                {
                    body["host_id"] = ExpressionConverter.ConvertO(__workflow_bodyhostID);
                    bodypropCount++;
                }

                if (__workflow_bodyrSVPStatus != null)
                {
                    body["rsvp_status"] = ExpressionConverter.ConvertO(__workflow_bodyrSVPStatus);
                    bodypropCount++;
                }

                if (__workflow_bodyattended != null)
                {
                    body["attended"] = ExpressionConverter.ConvertO(__workflow_bodyattended);
                    bodypropCount++;
                }

                if (__workflow_bodyinvitationStatus != null)
                {
                    body["invitation_status"] = ExpressionConverter.ConvertO(__workflow_bodyinvitationStatus);
                    bodypropCount++;
                }

                var rsvpDateObject = new JObject();
                var rsvpDateObjectpropCount = 0;
                if (__workflow_bodyrSVPDateday != null)
                {
                    rsvpDateObject["d"] = ExpressionConverter.ConvertO(__workflow_bodyrSVPDateday);
                    rsvpDateObjectpropCount++;
                }

                if (__workflow_bodyrSVPDatemonth != null)
                {
                    rsvpDateObject["m"] = ExpressionConverter.ConvertO(__workflow_bodyrSVPDatemonth);
                    rsvpDateObjectpropCount++;
                }

                if (__workflow_bodyrSVPDateyear != null)
                {
                    rsvpDateObject["y"] = ExpressionConverter.ConvertO(__workflow_bodyrSVPDateyear);
                    rsvpDateObjectpropCount++;
                }

                if (rsvpDateObjectpropCount > 0)
                {
                    body["rsvp_date"] = rsvpDateObject;
                    bodypropCount++;
                }

                var invitationDateObject = new JObject();
                var invitationDateObjectpropCount = 0;
                if (__workflow_bodyinvitationDateday != null)
                {
                    invitationDateObject["d"] = ExpressionConverter.ConvertO(__workflow_bodyinvitationDateday);
                    invitationDateObjectpropCount++;
                }

                if (__workflow_bodyinvitationDatemonth != null)
                {
                    invitationDateObject["m"] = ExpressionConverter.ConvertO(__workflow_bodyinvitationDatemonth);
                    invitationDateObjectpropCount++;
                }

                if (__workflow_bodyinvitationDateyear != null)
                {
                    invitationDateObject["y"] = ExpressionConverter.ConvertO(__workflow_bodyinvitationDateyear);
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
                participationLevelObject["name"] = ExpressionConverter.ConvertO(__workflow_bodyparticipationLevelparticipationLevel);
                if (participationLevelObjectpropCount > 0)
                {
                    body["participation_level"] = participationLevelObject;
                    bodypropCount++;
                }

                if (__workflow_bodysummaryNote != null)
                {
                    body["summary_note"] = ExpressionConverter.ConvertO(__workflow_bodysummaryNote);
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
        public IWorkflowAction EditParticipantOption(Expression<Func<string>> optionId, Expression<Func<string>> bodyvalue)
        {
            var __workflow_optionId = optionId == null ? null : WorkflowExpression.Compile(optionId);
            WorkflowExpression.Validate(__workflow_optionId, nameof(optionId), required: true);
            var __workflow_bodyvalue = bodyvalue == null ? null : WorkflowExpression.Compile(bodyvalue);
            WorkflowExpression.Validate(__workflow_bodyvalue, nameof(bodyvalue), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/event/v1/participantoptions/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_optionId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["option_value"] = ExpressionConverter.ConvertO(__workflow_bodyvalue);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        public IBodyWorkflowAction<EventApiParticipant> GetParticipant(Expression<Func<string>> participantId)
        {
            var __workflow_participantId = participantId == null ? null : WorkflowExpression.Compile(participantId);
            WorkflowExpression.Validate(__workflow_participantId, nameof(participantId), required: true);
            return new DeferredBodyAction<EventApiParticipant>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/event/v1/participants/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_participantId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EventApiParticipant>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        public IWorkflowAction EditParticipant(Expression<Func<string>> participantId, Expression<Func<string>> bodyparticipationLevelparticipationLevel, Expression<Func<string>> bodyconstituentID = null, Expression<Func<string>> bodyhostID = null, Expression<Func<bodyrSVPStatusInput>> bodyrSVPStatus = null, Expression<Func<bool>> bodyattended = null, Expression<Func<bodyinvitationStatusInput>> bodyinvitationStatus = null, Expression<Func<int>> bodyrSVPDateday = null, Expression<Func<int>> bodyrSVPDatemonth = null, Expression<Func<int>> bodyrSVPDateyear = null, Expression<Func<int>> bodyinvitationDateday = null, Expression<Func<int>> bodyinvitationDatemonth = null, Expression<Func<int>> bodyinvitationDateyear = null, Expression<Func<string>> bodysummaryNote = null)
        {
            var __workflow_participantId = participantId == null ? null : WorkflowExpression.Compile(participantId);
            WorkflowExpression.Validate(__workflow_participantId, nameof(participantId), required: true);
            var __workflow_bodyparticipationLevelparticipationLevel = bodyparticipationLevelparticipationLevel == null ? null : WorkflowExpression.Compile(bodyparticipationLevelparticipationLevel);
            WorkflowExpression.Validate(__workflow_bodyparticipationLevelparticipationLevel, nameof(bodyparticipationLevelparticipationLevel), required: true);
            var __workflow_bodyconstituentID = bodyconstituentID == null ? null : WorkflowExpression.Compile(bodyconstituentID);
            WorkflowExpression.Validate(__workflow_bodyconstituentID, nameof(bodyconstituentID), required: false);
            var __workflow_bodyhostID = bodyhostID == null ? null : WorkflowExpression.Compile(bodyhostID);
            WorkflowExpression.Validate(__workflow_bodyhostID, nameof(bodyhostID), required: false);
            var __workflow_bodyrSVPStatus = bodyrSVPStatus == null ? null : WorkflowExpression.Compile(bodyrSVPStatus);
            WorkflowExpression.Validate(__workflow_bodyrSVPStatus, nameof(bodyrSVPStatus), required: false);
            var __workflow_bodyattended = bodyattended == null ? null : WorkflowExpression.Compile(bodyattended);
            WorkflowExpression.Validate(__workflow_bodyattended, nameof(bodyattended), required: false);
            var __workflow_bodyinvitationStatus = bodyinvitationStatus == null ? null : WorkflowExpression.Compile(bodyinvitationStatus);
            WorkflowExpression.Validate(__workflow_bodyinvitationStatus, nameof(bodyinvitationStatus), required: false);
            var __workflow_bodyrSVPDateday = bodyrSVPDateday == null ? null : WorkflowExpression.Compile(bodyrSVPDateday);
            WorkflowExpression.Validate(__workflow_bodyrSVPDateday, nameof(bodyrSVPDateday), required: false);
            var __workflow_bodyrSVPDatemonth = bodyrSVPDatemonth == null ? null : WorkflowExpression.Compile(bodyrSVPDatemonth);
            WorkflowExpression.Validate(__workflow_bodyrSVPDatemonth, nameof(bodyrSVPDatemonth), required: false);
            var __workflow_bodyrSVPDateyear = bodyrSVPDateyear == null ? null : WorkflowExpression.Compile(bodyrSVPDateyear);
            WorkflowExpression.Validate(__workflow_bodyrSVPDateyear, nameof(bodyrSVPDateyear), required: false);
            var __workflow_bodyinvitationDateday = bodyinvitationDateday == null ? null : WorkflowExpression.Compile(bodyinvitationDateday);
            WorkflowExpression.Validate(__workflow_bodyinvitationDateday, nameof(bodyinvitationDateday), required: false);
            var __workflow_bodyinvitationDatemonth = bodyinvitationDatemonth == null ? null : WorkflowExpression.Compile(bodyinvitationDatemonth);
            WorkflowExpression.Validate(__workflow_bodyinvitationDatemonth, nameof(bodyinvitationDatemonth), required: false);
            var __workflow_bodyinvitationDateyear = bodyinvitationDateyear == null ? null : WorkflowExpression.Compile(bodyinvitationDateyear);
            WorkflowExpression.Validate(__workflow_bodyinvitationDateyear, nameof(bodyinvitationDateyear), required: false);
            var __workflow_bodysummaryNote = bodysummaryNote == null ? null : WorkflowExpression.Compile(bodysummaryNote);
            WorkflowExpression.Validate(__workflow_bodysummaryNote, nameof(bodysummaryNote), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/event/v1/participants/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_participantId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyconstituentID != null)
                {
                    body["constituent_id"] = ExpressionConverter.ConvertO(__workflow_bodyconstituentID);
                    bodypropCount++;
                }

                if (__workflow_bodyhostID != null)
                {
                    body["host_id"] = ExpressionConverter.ConvertO(__workflow_bodyhostID);
                    bodypropCount++;
                }

                if (__workflow_bodyrSVPStatus != null)
                {
                    body["rsvp_status"] = ExpressionConverter.ConvertO(__workflow_bodyrSVPStatus);
                    bodypropCount++;
                }

                if (__workflow_bodyattended != null)
                {
                    body["attended"] = ExpressionConverter.ConvertO(__workflow_bodyattended);
                    bodypropCount++;
                }

                if (__workflow_bodyinvitationStatus != null)
                {
                    body["invitation_status"] = ExpressionConverter.ConvertO(__workflow_bodyinvitationStatus);
                    bodypropCount++;
                }

                var rsvpDateObject = new JObject();
                var rsvpDateObjectpropCount = 0;
                if (__workflow_bodyrSVPDateday != null)
                {
                    rsvpDateObject["d"] = ExpressionConverter.ConvertO(__workflow_bodyrSVPDateday);
                    rsvpDateObjectpropCount++;
                }

                if (__workflow_bodyrSVPDatemonth != null)
                {
                    rsvpDateObject["m"] = ExpressionConverter.ConvertO(__workflow_bodyrSVPDatemonth);
                    rsvpDateObjectpropCount++;
                }

                if (__workflow_bodyrSVPDateyear != null)
                {
                    rsvpDateObject["y"] = ExpressionConverter.ConvertO(__workflow_bodyrSVPDateyear);
                    rsvpDateObjectpropCount++;
                }

                if (rsvpDateObjectpropCount > 0)
                {
                    body["rsvp_date"] = rsvpDateObject;
                    bodypropCount++;
                }

                var invitationDateObject = new JObject();
                var invitationDateObjectpropCount = 0;
                if (__workflow_bodyinvitationDateday != null)
                {
                    invitationDateObject["d"] = ExpressionConverter.ConvertO(__workflow_bodyinvitationDateday);
                    invitationDateObjectpropCount++;
                }

                if (__workflow_bodyinvitationDatemonth != null)
                {
                    invitationDateObject["m"] = ExpressionConverter.ConvertO(__workflow_bodyinvitationDatemonth);
                    invitationDateObjectpropCount++;
                }

                if (__workflow_bodyinvitationDateyear != null)
                {
                    invitationDateObject["y"] = ExpressionConverter.ConvertO(__workflow_bodyinvitationDateyear);
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
                participationLevelObject["name"] = ExpressionConverter.ConvertO(__workflow_bodyparticipationLevelparticipationLevel);
                if (participationLevelObjectpropCount > 0)
                {
                    body["participation_level"] = participationLevelObject;
                    bodypropCount++;
                }

                if (__workflow_bodysummaryNote != null)
                {
                    body["summary_note"] = ExpressionConverter.ConvertO(__workflow_bodysummaryNote);
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
        public IBodyWorkflowAction<EventApiApiCollectionOfParticipantDonation> ListParticipantDonations(Expression<Func<string>> participantId, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_participantId = participantId == null ? null : WorkflowExpression.Compile(participantId);
            WorkflowExpression.Validate(__workflow_participantId, nameof(participantId), required: true);
            var __workflow_limit = limit == null ? null : WorkflowExpression.Compile(limit);
            WorkflowExpression.Validate(__workflow_limit, nameof(limit), required: false);
            var __workflow_offset = offset == null ? null : WorkflowExpression.Compile(offset);
            WorkflowExpression.Validate(__workflow_offset, nameof(offset), required: false);
            return new DeferredBodyAction<EventApiApiCollectionOfParticipantDonation>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/event/v1/participants/{0}/donations", ExpressionConverter.ConvertWithUrlEncoding(__workflow_participantId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = Convert.ToString(500);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<EventApiApiCollectionOfParticipantDonation>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        public IBodyWorkflowAction<EventApiCreatedParticipantDonation> CreateParticipantDonation(Expression<Func<string>> participantId, Expression<Func<string>> bodygiftID)
        {
            var __workflow_participantId = participantId == null ? null : WorkflowExpression.Compile(participantId);
            WorkflowExpression.Validate(__workflow_participantId, nameof(participantId), required: true);
            var __workflow_bodygiftID = bodygiftID == null ? null : WorkflowExpression.Compile(bodygiftID);
            WorkflowExpression.Validate(__workflow_bodygiftID, nameof(bodygiftID), required: true);
            return new DeferredBodyAction<EventApiCreatedParticipantDonation>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/event/v1/participants/{0}/donations", ExpressionConverter.ConvertWithUrlEncoding(__workflow_participantId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["gift_id"] = ExpressionConverter.ConvertO(__workflow_bodygiftID);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<EventApiCreatedParticipantDonation>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        public IBodyWorkflowAction<EventApiApiCollectionOfParticipantFeePayment> ListParticipantFeePayments(Expression<Func<string>> participantId, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_participantId = participantId == null ? null : WorkflowExpression.Compile(participantId);
            WorkflowExpression.Validate(__workflow_participantId, nameof(participantId), required: true);
            var __workflow_limit = limit == null ? null : WorkflowExpression.Compile(limit);
            WorkflowExpression.Validate(__workflow_limit, nameof(limit), required: false);
            var __workflow_offset = offset == null ? null : WorkflowExpression.Compile(offset);
            WorkflowExpression.Validate(__workflow_offset, nameof(offset), required: false);
            return new DeferredBodyAction<EventApiApiCollectionOfParticipantFeePayment>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/event/v1/participants/{0}/feepayments", ExpressionConverter.ConvertWithUrlEncoding(__workflow_participantId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = Convert.ToString(500);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<EventApiApiCollectionOfParticipantFeePayment>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        public IBodyWorkflowAction<EventApiCreatedParticipantFeePayment> CreateParticipantFeePayment(Expression<Func<string>> participantId, Expression<Func<string>> bodygiftID, Expression<Func<double>> bodyappliedAmount)
        {
            var __workflow_participantId = participantId == null ? null : WorkflowExpression.Compile(participantId);
            WorkflowExpression.Validate(__workflow_participantId, nameof(participantId), required: true);
            var __workflow_bodygiftID = bodygiftID == null ? null : WorkflowExpression.Compile(bodygiftID);
            WorkflowExpression.Validate(__workflow_bodygiftID, nameof(bodygiftID), required: true);
            var __workflow_bodyappliedAmount = bodyappliedAmount == null ? null : WorkflowExpression.Compile(bodyappliedAmount);
            WorkflowExpression.Validate(__workflow_bodyappliedAmount, nameof(bodyappliedAmount), required: true);
            return new DeferredBodyAction<EventApiCreatedParticipantFeePayment>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/event/v1/participants/{0}/feepayments", ExpressionConverter.ConvertWithUrlEncoding(__workflow_participantId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["gift_id"] = ExpressionConverter.ConvertO(__workflow_bodygiftID);
                bodypropCount++;
                body["applied_amount"] = ExpressionConverter.ConvertO(__workflow_bodyappliedAmount);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<EventApiCreatedParticipantFeePayment>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        public IBodyWorkflowAction<EventApiApiCollectionOfParticipantFee> ListParticipantFees(Expression<Func<string>> participantId, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_participantId = participantId == null ? null : WorkflowExpression.Compile(participantId);
            WorkflowExpression.Validate(__workflow_participantId, nameof(participantId), required: true);
            var __workflow_limit = limit == null ? null : WorkflowExpression.Compile(limit);
            WorkflowExpression.Validate(__workflow_limit, nameof(limit), required: false);
            var __workflow_offset = offset == null ? null : WorkflowExpression.Compile(offset);
            WorkflowExpression.Validate(__workflow_offset, nameof(offset), required: false);
            return new DeferredBodyAction<EventApiApiCollectionOfParticipantFee>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/event/v1/participants/{0}/fees", ExpressionConverter.ConvertWithUrlEncoding(__workflow_participantId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = Convert.ToString(500);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<EventApiApiCollectionOfParticipantFee>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        public IBodyWorkflowAction<EventApiCreatedParticipantFee> CreateParticipantFee(Expression<Func<string>> participantId, Expression<Func<string>> bodyeventID, Expression<Func<string>> bodyfee, Expression<Func<int>> bodyquantity, Expression<Func<double>> bodyfeeAmount, Expression<Func<double>> bodycontributionAmount, Expression<Func<int>> bodydateday = null, Expression<Func<int>> bodydatemonth = null, Expression<Func<int>> bodydateyear = null)
        {
            var __workflow_participantId = participantId == null ? null : WorkflowExpression.Compile(participantId);
            WorkflowExpression.Validate(__workflow_participantId, nameof(participantId), required: true);
            var __workflow_bodyeventID = bodyeventID == null ? null : WorkflowExpression.Compile(bodyeventID);
            WorkflowExpression.Validate(__workflow_bodyeventID, nameof(bodyeventID), required: true);
            var __workflow_bodyfee = bodyfee == null ? null : WorkflowExpression.Compile(bodyfee);
            WorkflowExpression.Validate(__workflow_bodyfee, nameof(bodyfee), required: true);
            var __workflow_bodyquantity = bodyquantity == null ? null : WorkflowExpression.Compile(bodyquantity);
            WorkflowExpression.Validate(__workflow_bodyquantity, nameof(bodyquantity), required: true);
            var __workflow_bodyfeeAmount = bodyfeeAmount == null ? null : WorkflowExpression.Compile(bodyfeeAmount);
            WorkflowExpression.Validate(__workflow_bodyfeeAmount, nameof(bodyfeeAmount), required: true);
            var __workflow_bodycontributionAmount = bodycontributionAmount == null ? null : WorkflowExpression.Compile(bodycontributionAmount);
            WorkflowExpression.Validate(__workflow_bodycontributionAmount, nameof(bodycontributionAmount), required: true);
            var __workflow_bodydateday = bodydateday == null ? null : WorkflowExpression.Compile(bodydateday);
            WorkflowExpression.Validate(__workflow_bodydateday, nameof(bodydateday), required: false);
            var __workflow_bodydatemonth = bodydatemonth == null ? null : WorkflowExpression.Compile(bodydatemonth);
            WorkflowExpression.Validate(__workflow_bodydatemonth, nameof(bodydatemonth), required: false);
            var __workflow_bodydateyear = bodydateyear == null ? null : WorkflowExpression.Compile(bodydateyear);
            WorkflowExpression.Validate(__workflow_bodydateyear, nameof(bodydateyear), required: false);
            return new DeferredBodyAction<EventApiCreatedParticipantFee>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/event/v1/participants/{0}/fees", ExpressionConverter.ConvertWithUrlEncoding(__workflow_participantId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["event_id"] = ExpressionConverter.ConvertO(__workflow_bodyeventID);
                bodypropCount++;
                body["event_fee_id"] = ExpressionConverter.ConvertO(__workflow_bodyfee);
                bodypropCount++;
                body["quantity"] = ExpressionConverter.ConvertO(__workflow_bodyquantity);
                bodypropCount++;
                body["fee_amount"] = ExpressionConverter.ConvertO(__workflow_bodyfeeAmount);
                bodypropCount++;
                body["contribution_amount"] = ExpressionConverter.ConvertO(__workflow_bodycontributionAmount);
                var dateObject = new JObject();
                var dateObjectpropCount = 0;
                if (__workflow_bodydateday != null)
                {
                    dateObject["d"] = ExpressionConverter.ConvertO(__workflow_bodydateday);
                    dateObjectpropCount++;
                }

                if (__workflow_bodydatemonth != null)
                {
                    dateObject["m"] = ExpressionConverter.ConvertO(__workflow_bodydatemonth);
                    dateObjectpropCount++;
                }

                if (__workflow_bodydateyear != null)
                {
                    dateObject["y"] = ExpressionConverter.ConvertO(__workflow_bodydateyear);
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
        public IBodyWorkflowAction<EventApiApiCollectionOfParticipantOption> ListParticipantOptions(Expression<Func<string>> participantId)
        {
            var __workflow_participantId = participantId == null ? null : WorkflowExpression.Compile(participantId);
            WorkflowExpression.Validate(__workflow_participantId, nameof(participantId), required: true);
            return new DeferredBodyAction<EventApiApiCollectionOfParticipantOption>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/event/v1/participants/{0}/participantoptions", ExpressionConverter.ConvertWithUrlEncoding(__workflow_participantId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EventApiApiCollectionOfParticipantOption>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudevents")]
        public IBodyWorkflowAction<EventApiCreatedParticipantOption> CreateParticipantOption(Expression<Func<string>> participantId, Expression<Func<string>> bodyeventID, Expression<Func<string>> bodyoption, Expression<Func<object>> bodyoptionValue)
        {
            var __workflow_participantId = participantId == null ? null : WorkflowExpression.Compile(participantId);
            WorkflowExpression.Validate(__workflow_participantId, nameof(participantId), required: true);
            var __workflow_bodyeventID = bodyeventID == null ? null : WorkflowExpression.Compile(bodyeventID);
            WorkflowExpression.Validate(__workflow_bodyeventID, nameof(bodyeventID), required: true);
            var __workflow_bodyoption = bodyoption == null ? null : WorkflowExpression.Compile(bodyoption);
            WorkflowExpression.Validate(__workflow_bodyoption, nameof(bodyoption), required: true);
            var __workflow_bodyoptionValue = bodyoptionValue == null ? null : WorkflowExpression.Compile(bodyoptionValue);
            WorkflowExpression.Validate(__workflow_bodyoptionValue, nameof(bodyoptionValue), required: true);
            return new DeferredBodyAction<EventApiCreatedParticipantOption>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/event/v1/participants/{0}/participantoptions", ExpressionConverter.ConvertWithUrlEncoding(__workflow_participantId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["event_id"] = ExpressionConverter.ConvertO(__workflow_bodyeventID);
                bodypropCount++;
                body["event_participant_option_id"] = ExpressionConverter.ConvertO(__workflow_bodyoption);
                bodypropCount++;
                body["option_value"] = ExpressionConverter.ConvertO(__workflow_bodyoptionValue);
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
