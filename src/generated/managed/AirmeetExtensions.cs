//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Airmeet
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AirmeetActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airmeet")]
        public IBodyWorkflowAction<GetAirmeetsResponse, ApiConnectionActionConfiguration> GetAirmeets()
        {
            return new DeferredBodyAction<GetAirmeetsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/airmeets";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["allAirmeets"] = Convert.ToString(true);
                callPayload.Queries["crmName"] = Convert.ToString("MICROSOFT_DYNAMICS");
                return new ApiConnectionAction<GetAirmeetsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airmeet")]
        public IBodyWorkflowAction<CreateAirmeetResponse, ApiConnectionActionConfiguration> CreateAirmeet(Expression<Func<string>> bodyhostEmail, Expression<Func<string>> bodyeventName, Expression<Func<string>> bodyshortDesc, Expression<Func<string>> bodyeventImage = null, Expression<Func<string>> bodylongDesc = null, Expression<Func<bodyaccessInput>> bodyaccess = null, Expression<Func<int>> bodytimingstartTime = null, Expression<Func<int>> bodytimingendTime = null, Expression<Func<string>> bodytimingtimezone = null, Expression<Func<bool>> bodyconfignetworking = null, Expression<Func<int>> bodyconfigtableCount = null)
        {
            var __workflow_bodyhostEmail = WorkflowExpression.Compile(bodyhostEmail, nameof(bodyhostEmail), required: true);
            var __workflow_bodyeventName = WorkflowExpression.Compile(bodyeventName, nameof(bodyeventName), required: true);
            var __workflow_bodyshortDesc = WorkflowExpression.Compile(bodyshortDesc, nameof(bodyshortDesc), required: true);
            var __workflow_bodyeventImage = WorkflowExpression.Compile(bodyeventImage, nameof(bodyeventImage), required: false);
            var __workflow_bodylongDesc = WorkflowExpression.Compile(bodylongDesc, nameof(bodylongDesc), required: false);
            var __workflow_bodyaccess = WorkflowExpression.Compile(bodyaccess, nameof(bodyaccess), required: false);
            var __workflow_bodytimingstartTime = WorkflowExpression.Compile(bodytimingstartTime, nameof(bodytimingstartTime), required: false);
            var __workflow_bodytimingendTime = WorkflowExpression.Compile(bodytimingendTime, nameof(bodytimingendTime), required: false);
            var __workflow_bodytimingtimezone = WorkflowExpression.Compile(bodytimingtimezone, nameof(bodytimingtimezone), required: false);
            var __workflow_bodyconfignetworking = WorkflowExpression.Compile(bodyconfignetworking, nameof(bodyconfignetworking), required: false);
            var __workflow_bodyconfigtableCount = WorkflowExpression.Compile(bodyconfigtableCount, nameof(bodyconfigtableCount), required: false);
            return new DeferredBodyAction<CreateAirmeetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/airmeet";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["hostEmail"] = ExpressionConverter.ConvertO(__workflow_bodyhostEmail);
                bodypropCount++;
                body["eventName"] = ExpressionConverter.ConvertO(__workflow_bodyeventName);
                bodypropCount++;
                body["shortDesc"] = ExpressionConverter.ConvertO(__workflow_bodyshortDesc);
                if (__workflow_bodyeventImage != null)
                {
                    body["eventImage"] = ExpressionConverter.ConvertO(__workflow_bodyeventImage);
                    bodypropCount++;
                }

                if (__workflow_bodylongDesc != null)
                {
                    body["longDesc"] = ExpressionConverter.ConvertO(__workflow_bodylongDesc);
                    bodypropCount++;
                }

                if (__workflow_bodyaccess != null)
                {
                    if (__workflow_bodyaccess != null)
                    {
                        body["access"] = ExpressionConverter.ConvertO(__workflow_bodyaccess);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["access"] = "INVITED_ONLY";
                    bodypropCount++;
                }

                body["eventType"] = "MEETUP";
                bodypropCount++;
                var timingObject = new JObject();
                var timingObjectpropCount = 0;
                if (__workflow_bodytimingstartTime != null)
                {
                    timingObject["startTime"] = ExpressionConverter.ConvertO(__workflow_bodytimingstartTime);
                    timingObjectpropCount++;
                }

                if (__workflow_bodytimingendTime != null)
                {
                    timingObject["endTime"] = ExpressionConverter.ConvertO(__workflow_bodytimingendTime);
                    timingObjectpropCount++;
                }

                if (__workflow_bodytimingtimezone != null)
                {
                    if (__workflow_bodytimingtimezone != null)
                    {
                        timingObject["timezone"] = ExpressionConverter.ConvertO(__workflow_bodytimingtimezone);
                        timingObjectpropCount++;
                    }

                    timingObjectpropCount++;
                }
                else
                {
                    timingObject["timezone"] = "Asia/Kolkata";
                    timingObjectpropCount++;
                }

                if (timingObjectpropCount > 0)
                {
                    body["timing"] = timingObject;
                    bodypropCount++;
                }

                var configObject = new JObject();
                var configObjectpropCount = 0;
                if (__workflow_bodyconfignetworking != null)
                {
                    if (__workflow_bodyconfignetworking != null)
                    {
                        configObject["networking"] = ExpressionConverter.ConvertO(__workflow_bodyconfignetworking);
                        configObjectpropCount++;
                    }

                    configObjectpropCount++;
                }
                else
                {
                    configObject["networking"] = true;
                    configObjectpropCount++;
                }

                if (__workflow_bodyconfigtableCount != null)
                {
                    if (__workflow_bodyconfigtableCount != null)
                    {
                        configObject["tableCount"] = ExpressionConverter.ConvertO(__workflow_bodyconfigtableCount);
                        configObjectpropCount++;
                    }

                    configObjectpropCount++;
                }
                else
                {
                    configObject["tableCount"] = 12;
                    configObjectpropCount++;
                }

                if (configObjectpropCount > 0)
                {
                    body["config"] = configObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateAirmeetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airmeet")]
        public IBodyWorkflowAction<CreateSpeakerResponse, ApiConnectionActionConfiguration> CreateSpeaker(Expression<Func<string>> airmeetId, Expression<Func<string>> bodyname, Expression<Func<string>> bodyemail, Expression<Func<string>> bodyorganisation = null, Expression<Func<string>> bodydesignation = null, Expression<Func<string>> bodyimageUrl = null, Expression<Func<string>> bodybio = null, Expression<Func<string>> bodycity = null, Expression<Func<string>> bodycountry = null)
        {
            var __workflow_airmeetId = WorkflowExpression.Compile(airmeetId, nameof(airmeetId), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: true);
            var __workflow_bodyorganisation = WorkflowExpression.Compile(bodyorganisation, nameof(bodyorganisation), required: false);
            var __workflow_bodydesignation = WorkflowExpression.Compile(bodydesignation, nameof(bodydesignation), required: false);
            var __workflow_bodyimageUrl = WorkflowExpression.Compile(bodyimageUrl, nameof(bodyimageUrl), required: false);
            var __workflow_bodybio = WorkflowExpression.Compile(bodybio, nameof(bodybio), required: false);
            var __workflow_bodycity = WorkflowExpression.Compile(bodycity, nameof(bodycity), required: false);
            var __workflow_bodycountry = WorkflowExpression.Compile(bodycountry, nameof(bodycountry), required: false);
            return new DeferredBodyAction<CreateSpeakerResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/airmeet/{0}/speaker", __workflow_airmeetId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                bodypropCount++;
                body["email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                if (__workflow_bodyorganisation != null)
                {
                    body["organisation"] = ExpressionConverter.ConvertO(__workflow_bodyorganisation);
                    bodypropCount++;
                }

                if (__workflow_bodydesignation != null)
                {
                    body["designation"] = ExpressionConverter.ConvertO(__workflow_bodydesignation);
                    bodypropCount++;
                }

                if (__workflow_bodyimageUrl != null)
                {
                    body["imageUrl"] = ExpressionConverter.ConvertO(__workflow_bodyimageUrl);
                    bodypropCount++;
                }

                if (__workflow_bodybio != null)
                {
                    body["bio"] = ExpressionConverter.ConvertO(__workflow_bodybio);
                    bodypropCount++;
                }

                if (__workflow_bodycity != null)
                {
                    body["city"] = ExpressionConverter.ConvertO(__workflow_bodycity);
                    bodypropCount++;
                }

                if (__workflow_bodycountry != null)
                {
                    body["country"] = ExpressionConverter.ConvertO(__workflow_bodycountry);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateSpeakerResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airmeet")]
        public IBodyWorkflowAction<AirmeetSessionsResponse, ApiConnectionActionConfiguration> AirmeetSessions(Expression<Func<string>> airmeetId)
        {
            var __workflow_airmeetId = WorkflowExpression.Compile(airmeetId, nameof(airmeetId), required: true);
            return new DeferredBodyAction<AirmeetSessionsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/airmeet/{0}/info", __workflow_airmeetId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<AirmeetSessionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airmeet")]
        public IBodyWorkflowAction<StartAndEndAirmeetResponse, ApiConnectionActionConfiguration> StartAndEndAirmeet(Expression<Func<string>> airmeetId, Expression<Func<bodystatusInput>> bodystatus)
        {
            var __workflow_airmeetId = WorkflowExpression.Compile(airmeetId, nameof(airmeetId), required: true);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: true);
            return new DeferredBodyAction<StartAndEndAirmeetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/airmeet/{0}/status", __workflow_airmeetId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<StartAndEndAirmeetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airmeet")]
        public IBodyWorkflowAction<AirmeetRegistrationsResponse, ApiConnectionActionConfiguration> AirmeetRegistrations(Expression<Func<string>> airmeetId, Expression<Func<int>> size, Expression<Func<int>> after = null, Expression<Func<int>> before = null)
        {
            var __workflow_airmeetId = WorkflowExpression.Compile(airmeetId, nameof(airmeetId), required: true);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: true);
            var __workflow_after = WorkflowExpression.Compile(after, nameof(after), required: false);
            var __workflow_before = WorkflowExpression.Compile(before, nameof(before), required: false);
            return new DeferredBodyAction<AirmeetRegistrationsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/airmeet/{0}/registrations", __workflow_airmeetId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(__workflow_after);
                if (__workflow_before != null)
                    callPayload.Queries["before"] = ExpressionConverter.Convert(__workflow_before);
                callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                return new ApiConnectionAction<AirmeetRegistrationsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airmeet")]
        public IBodyWorkflowAction<AirmeetParticipantsResponse, ApiConnectionActionConfiguration> AirmeetParticipants(Expression<Func<string>> airmeetId, Expression<Func<int>> resultSize = null, Expression<Func<int>> pageNumber = null, Expression<Func<sortingKeyInput>> sortingKey = null, Expression<Func<sortingDirectionInput>> sortingDirection = null)
        {
            var __workflow_airmeetId = WorkflowExpression.Compile(airmeetId, nameof(airmeetId), required: true);
            var __workflow_resultSize = WorkflowExpression.Compile(resultSize, nameof(resultSize), required: false);
            var __workflow_pageNumber = WorkflowExpression.Compile(pageNumber, nameof(pageNumber), required: false);
            var __workflow_sortingKey = WorkflowExpression.Compile(sortingKey, nameof(sortingKey), required: false);
            var __workflow_sortingDirection = WorkflowExpression.Compile(sortingDirection, nameof(sortingDirection), required: false);
            return new DeferredBodyAction<AirmeetParticipantsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/airmeet/{0}/participants", __workflow_airmeetId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_resultSize != null)
                    callPayload.Queries["resultSize"] = ExpressionConverter.Convert(__workflow_resultSize);
                if (__workflow_pageNumber != null)
                    callPayload.Queries["pageNumber"] = ExpressionConverter.Convert(__workflow_pageNumber);
                callPayload.Queries["sortingKey"] = Convert.ToString("registrationDate");
                if (__workflow_sortingKey != null)
                    callPayload.Queries["sortingKey"] = ExpressionConverter.Convert(__workflow_sortingKey);
                if (__workflow_sortingDirection != null)
                    callPayload.Queries["sortingDirection"] = ExpressionConverter.Convert(__workflow_sortingDirection);
                return new ApiConnectionAction<AirmeetParticipantsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airmeet")]
        public IBodyWorkflowAction<CustomRegistrationFieldsResponse, ApiConnectionActionConfiguration> CustomRegistrationFields(Expression<Func<string>> airmeetId)
        {
            var __workflow_airmeetId = WorkflowExpression.Compile(airmeetId, nameof(airmeetId), required: true);
            return new DeferredBodyAction<CustomRegistrationFieldsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/airmeet/{0}/custom-fields", __workflow_airmeetId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CustomRegistrationFieldsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airmeet")]
        public IBodyWorkflowAction<RemoveAttendeeResponse, ApiConnectionActionConfiguration> RemoveAttendee(Expression<Func<string>> airmeetId, Expression<Func<string>> urlEncodedAttendeeEmail)
        {
            var __workflow_airmeetId = WorkflowExpression.Compile(airmeetId, nameof(airmeetId), required: true);
            var __workflow_urlEncodedAttendeeEmail = WorkflowExpression.Compile(urlEncodedAttendeeEmail, nameof(urlEncodedAttendeeEmail), required: true);
            return new DeferredBodyAction<RemoveAttendeeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/airmeet/{0}/attendee/{1}", __workflow_airmeetId.WithUrlEncoding(1), __workflow_urlEncodedAttendeeEmail.WithUrlEncoding(2)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<RemoveAttendeeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airmeet")]
        public IBodyWorkflowAction<FetchEventTracksResponse, ApiConnectionActionConfiguration> FetchEventTracks(Expression<Func<string>> airmeetId)
        {
            var __workflow_airmeetId = WorkflowExpression.Compile(airmeetId, nameof(airmeetId), required: true);
            return new DeferredBodyAction<FetchEventTracksResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/airmeet/{0}/tracks", __workflow_airmeetId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<FetchEventTracksResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airmeet")]
        public IBodyWorkflowAction<FetchAirmeetBoothsResponse, ApiConnectionActionConfiguration> FetchAirmeetBooths(Expression<Func<string>> airmeetId)
        {
            var __workflow_airmeetId = WorkflowExpression.Compile(airmeetId, nameof(airmeetId), required: true);
            return new DeferredBodyAction<FetchAirmeetBoothsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/airmeet/{0}/booths", __workflow_airmeetId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<FetchAirmeetBoothsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airmeet")]
        public IBodyWorkflowAction<CreateBoothResponse, ApiConnectionActionConfiguration> CreateBooth(Expression<Func<string>> airmeetId, Expression<Func<string>> bodyname, Expression<Func<bodyexhibitorInfoInputItem[]>> bodyexhibitorInfo, Expression<Func<string[]>> bodytags = null, Expression<Func<bool>> bodymetaDatachatEnabled = null, Expression<Func<bool>> bodymetaDataloungeEnabled = null, Expression<Func<bool>> bodymetaDatabroadcastEnabled = null, Expression<Func<int>> bodymetaDatatableCount = null)
        {
            var __workflow_airmeetId = WorkflowExpression.Compile(airmeetId, nameof(airmeetId), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodyexhibitorInfo = WorkflowExpression.Compile(bodyexhibitorInfo, nameof(bodyexhibitorInfo), required: true);
            var __workflow_bodytags = WorkflowExpression.Compile(bodytags, nameof(bodytags), required: false);
            var __workflow_bodymetaDatachatEnabled = WorkflowExpression.Compile(bodymetaDatachatEnabled, nameof(bodymetaDatachatEnabled), required: false);
            var __workflow_bodymetaDataloungeEnabled = WorkflowExpression.Compile(bodymetaDataloungeEnabled, nameof(bodymetaDataloungeEnabled), required: false);
            var __workflow_bodymetaDatabroadcastEnabled = WorkflowExpression.Compile(bodymetaDatabroadcastEnabled, nameof(bodymetaDatabroadcastEnabled), required: false);
            var __workflow_bodymetaDatatableCount = WorkflowExpression.Compile(bodymetaDatatableCount, nameof(bodymetaDatatableCount), required: false);
            return new DeferredBodyAction<CreateBoothResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/airmeet/{0}/booths", __workflow_airmeetId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                bodypropCount++;
                body["exhibitorInfo"] = ExpressionConverter.ConvertO(__workflow_bodyexhibitorInfo);
                if (__workflow_bodytags != null)
                {
                    body["tags"] = ExpressionConverter.ConvertO(__workflow_bodytags);
                    bodypropCount++;
                }

                var metaDataObject = new JObject();
                var metaDataObjectpropCount = 0;
                if (__workflow_bodymetaDatachatEnabled != null)
                {
                    if (__workflow_bodymetaDatachatEnabled != null)
                    {
                        metaDataObject["chatEnabled"] = ExpressionConverter.ConvertO(__workflow_bodymetaDatachatEnabled);
                        metaDataObjectpropCount++;
                    }

                    metaDataObjectpropCount++;
                }
                else
                {
                    metaDataObject["chatEnabled"] = false;
                    metaDataObjectpropCount++;
                }

                if (__workflow_bodymetaDataloungeEnabled != null)
                {
                    if (__workflow_bodymetaDataloungeEnabled != null)
                    {
                        metaDataObject["loungeEnabled"] = ExpressionConverter.ConvertO(__workflow_bodymetaDataloungeEnabled);
                        metaDataObjectpropCount++;
                    }

                    metaDataObjectpropCount++;
                }
                else
                {
                    metaDataObject["loungeEnabled"] = false;
                    metaDataObjectpropCount++;
                }

                if (__workflow_bodymetaDatabroadcastEnabled != null)
                {
                    if (__workflow_bodymetaDatabroadcastEnabled != null)
                    {
                        metaDataObject["broadcastEnabled"] = ExpressionConverter.ConvertO(__workflow_bodymetaDatabroadcastEnabled);
                        metaDataObjectpropCount++;
                    }

                    metaDataObjectpropCount++;
                }
                else
                {
                    metaDataObject["broadcastEnabled"] = false;
                    metaDataObjectpropCount++;
                }

                if (__workflow_bodymetaDatatableCount != null)
                {
                    if (__workflow_bodymetaDatatableCount != null)
                    {
                        metaDataObject["tableCount"] = ExpressionConverter.ConvertO(__workflow_bodymetaDatatableCount);
                        metaDataObjectpropCount++;
                    }

                    metaDataObjectpropCount++;
                }
                else
                {
                    metaDataObject["tableCount"] = 6;
                    metaDataObjectpropCount++;
                }

                if (metaDataObjectpropCount > 0)
                {
                    body["metaData"] = metaDataObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateBoothResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airmeet")]
        public IBodyWorkflowAction<AddAuthorizedAttendeeResponse, ApiConnectionActionConfiguration> AddAuthorizedAttendee(Expression<Func<string>> airmeetId, Expression<Func<string>> bodyemail, Expression<Func<string>> bodyfirstName, Expression<Func<string>> bodylastName, Expression<Func<bool>> bodyregisterAttendee, Expression<Func<bool>> bodysendEmailInvite, Expression<Func<bodyattendanceTypeInput>> bodyattendanceType = null, Expression<Func<string>> bodycity = null, Expression<Func<string>> bodycountry = null, Expression<Func<string>> bodydesignation = null, Expression<Func<string>> bodyorganisation = null, Expression<Func<bodycustomFieldMappingInputItem[]>> bodycustomFieldMapping = null)
        {
            var __workflow_airmeetId = WorkflowExpression.Compile(airmeetId, nameof(airmeetId), required: true);
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: true);
            var __workflow_bodyfirstName = WorkflowExpression.Compile(bodyfirstName, nameof(bodyfirstName), required: true);
            var __workflow_bodylastName = WorkflowExpression.Compile(bodylastName, nameof(bodylastName), required: true);
            var __workflow_bodyregisterAttendee = WorkflowExpression.Compile(bodyregisterAttendee, nameof(bodyregisterAttendee), required: true);
            var __workflow_bodysendEmailInvite = WorkflowExpression.Compile(bodysendEmailInvite, nameof(bodysendEmailInvite), required: true);
            var __workflow_bodyattendanceType = WorkflowExpression.Compile(bodyattendanceType, nameof(bodyattendanceType), required: false);
            var __workflow_bodycity = WorkflowExpression.Compile(bodycity, nameof(bodycity), required: false);
            var __workflow_bodycountry = WorkflowExpression.Compile(bodycountry, nameof(bodycountry), required: false);
            var __workflow_bodydesignation = WorkflowExpression.Compile(bodydesignation, nameof(bodydesignation), required: false);
            var __workflow_bodyorganisation = WorkflowExpression.Compile(bodyorganisation, nameof(bodyorganisation), required: false);
            var __workflow_bodycustomFieldMapping = WorkflowExpression.Compile(bodycustomFieldMapping, nameof(bodycustomFieldMapping), required: false);
            return new DeferredBodyAction<AddAuthorizedAttendeeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/airmeet/{0}/attendee", __workflow_airmeetId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                bodypropCount++;
                body["firstName"] = ExpressionConverter.ConvertO(__workflow_bodyfirstName);
                bodypropCount++;
                body["lastName"] = ExpressionConverter.ConvertO(__workflow_bodylastName);
                if (__workflow_bodyattendanceType != null)
                {
                    if (__workflow_bodyattendanceType != null)
                    {
                        body["attendance_type"] = ExpressionConverter.ConvertO(__workflow_bodyattendanceType);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["attendance_type"] = "IN-PERSON";
                    bodypropCount++;
                }

                if (__workflow_bodycity != null)
                {
                    body["city"] = ExpressionConverter.ConvertO(__workflow_bodycity);
                    bodypropCount++;
                }

                if (__workflow_bodycountry != null)
                {
                    body["country"] = ExpressionConverter.ConvertO(__workflow_bodycountry);
                    bodypropCount++;
                }

                if (__workflow_bodydesignation != null)
                {
                    body["designation"] = ExpressionConverter.ConvertO(__workflow_bodydesignation);
                    bodypropCount++;
                }

                if (__workflow_bodyorganisation != null)
                {
                    body["organisation"] = ExpressionConverter.ConvertO(__workflow_bodyorganisation);
                    bodypropCount++;
                }

                bodypropCount++;
                body["registerAttendee"] = ExpressionConverter.ConvertO(__workflow_bodyregisterAttendee);
                bodypropCount++;
                body["sendEmailInvite"] = ExpressionConverter.ConvertO(__workflow_bodysendEmailInvite);
                if (__workflow_bodycustomFieldMapping != null)
                {
                    body["customFieldMapping"] = ExpressionConverter.ConvertO(__workflow_bodycustomFieldMapping);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<AddAuthorizedAttendeeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airmeet")]
        public IBodyWorkflowAction<CreateSessionResponse, ApiConnectionActionConfiguration> CreateSession(Expression<Func<string>> airmeetId, Expression<Func<int>> bodysessionStartTime, Expression<Func<string>> bodyhostEmail, Expression<Func<string>> bodysessionTitle = null, Expression<Func<int>> bodysessionDuration = null, Expression<Func<string>> bodysessionSummary = null, Expression<Func<string[]>> bodyspeakerEmails = null, Expression<Func<string[]>> bodycohostEmails = null, Expression<Func<bodytypeInput>> bodytype = null, Expression<Func<string[]>> bodytracks = null, Expression<Func<string[]>> bodytags = null, Expression<Func<string>> bodyboothId = null, Expression<Func<int>> bodyspeedNetworkingDataconversationTime = null, Expression<Func<int>> bodyspeedNetworkingDataextendNetworkingTime = null, Expression<Func<bool>> bodysessionMetahideHost = null)
        {
            var __workflow_airmeetId = WorkflowExpression.Compile(airmeetId, nameof(airmeetId), required: true);
            var __workflow_bodysessionStartTime = WorkflowExpression.Compile(bodysessionStartTime, nameof(bodysessionStartTime), required: true);
            var __workflow_bodyhostEmail = WorkflowExpression.Compile(bodyhostEmail, nameof(bodyhostEmail), required: true);
            var __workflow_bodysessionTitle = WorkflowExpression.Compile(bodysessionTitle, nameof(bodysessionTitle), required: false);
            var __workflow_bodysessionDuration = WorkflowExpression.Compile(bodysessionDuration, nameof(bodysessionDuration), required: false);
            var __workflow_bodysessionSummary = WorkflowExpression.Compile(bodysessionSummary, nameof(bodysessionSummary), required: false);
            var __workflow_bodyspeakerEmails = WorkflowExpression.Compile(bodyspeakerEmails, nameof(bodyspeakerEmails), required: false);
            var __workflow_bodycohostEmails = WorkflowExpression.Compile(bodycohostEmails, nameof(bodycohostEmails), required: false);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: false);
            var __workflow_bodytracks = WorkflowExpression.Compile(bodytracks, nameof(bodytracks), required: false);
            var __workflow_bodytags = WorkflowExpression.Compile(bodytags, nameof(bodytags), required: false);
            var __workflow_bodyboothId = WorkflowExpression.Compile(bodyboothId, nameof(bodyboothId), required: false);
            var __workflow_bodyspeedNetworkingDataconversationTime = WorkflowExpression.Compile(bodyspeedNetworkingDataconversationTime, nameof(bodyspeedNetworkingDataconversationTime), required: false);
            var __workflow_bodyspeedNetworkingDataextendNetworkingTime = WorkflowExpression.Compile(bodyspeedNetworkingDataextendNetworkingTime, nameof(bodyspeedNetworkingDataextendNetworkingTime), required: false);
            var __workflow_bodysessionMetahideHost = WorkflowExpression.Compile(bodysessionMetahideHost, nameof(bodysessionMetahideHost), required: false);
            return new DeferredBodyAction<CreateSessionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/airmeet/{0}/session", __workflow_airmeetId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodysessionTitle != null)
                {
                    body["sessionTitle"] = ExpressionConverter.ConvertO(__workflow_bodysessionTitle);
                    bodypropCount++;
                }

                bodypropCount++;
                body["sessionStartTime"] = ExpressionConverter.ConvertO(__workflow_bodysessionStartTime);
                if (__workflow_bodysessionDuration != null)
                {
                    if (__workflow_bodysessionDuration != null)
                    {
                        body["sessionDuration"] = ExpressionConverter.ConvertO(__workflow_bodysessionDuration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["sessionDuration"] = 30;
                    bodypropCount++;
                }

                if (__workflow_bodysessionSummary != null)
                {
                    body["sessionSummary"] = ExpressionConverter.ConvertO(__workflow_bodysessionSummary);
                    bodypropCount++;
                }

                bodypropCount++;
                body["hostEmail"] = ExpressionConverter.ConvertO(__workflow_bodyhostEmail);
                if (__workflow_bodyspeakerEmails != null)
                {
                    body["speakerEmails"] = ExpressionConverter.ConvertO(__workflow_bodyspeakerEmails);
                    bodypropCount++;
                }

                if (__workflow_bodycohostEmails != null)
                {
                    body["cohostEmails"] = ExpressionConverter.ConvertO(__workflow_bodycohostEmails);
                    bodypropCount++;
                }

                if (__workflow_bodytype != null)
                {
                    if (__workflow_bodytype != null)
                    {
                        body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["type"] = "HOSTING";
                    bodypropCount++;
                }

                if (__workflow_bodytracks != null)
                {
                    body["tracks"] = ExpressionConverter.ConvertO(__workflow_bodytracks);
                    bodypropCount++;
                }

                if (__workflow_bodytags != null)
                {
                    body["tags"] = ExpressionConverter.ConvertO(__workflow_bodytags);
                    bodypropCount++;
                }

                if (__workflow_bodyboothId != null)
                {
                    body["boothId"] = ExpressionConverter.ConvertO(__workflow_bodyboothId);
                    bodypropCount++;
                }

                var speedNetworkingDataObject = new JObject();
                var speedNetworkingDataObjectpropCount = 0;
                if (__workflow_bodyspeedNetworkingDataconversationTime != null)
                {
                    speedNetworkingDataObject["conversationTime"] = ExpressionConverter.ConvertO(__workflow_bodyspeedNetworkingDataconversationTime);
                    speedNetworkingDataObjectpropCount++;
                }

                if (__workflow_bodyspeedNetworkingDataextendNetworkingTime != null)
                {
                    speedNetworkingDataObject["extendNetworkingTime"] = ExpressionConverter.ConvertO(__workflow_bodyspeedNetworkingDataextendNetworkingTime);
                    speedNetworkingDataObjectpropCount++;
                }

                if (speedNetworkingDataObjectpropCount > 0)
                {
                    body["speedNetworkingData"] = speedNetworkingDataObject;
                    bodypropCount++;
                }

                var sessionMetaObject = new JObject();
                var sessionMetaObjectpropCount = 0;
                if (__workflow_bodysessionMetahideHost != null)
                {
                    sessionMetaObject["hideHost"] = ExpressionConverter.ConvertO(__workflow_bodysessionMetahideHost);
                    sessionMetaObjectpropCount++;
                }

                if (sessionMetaObjectpropCount > 0)
                {
                    body["sessionMeta"] = sessionMetaObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateSessionResponse>(callPayload);
            });
        }
    }

    public class AirmeetTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<AirmeetTriggersResponse, ApiConnectionTriggerConfiguration> AirmeetTriggersOperation(Expression<Func<bodytriggerMetaInfoIdInput>> bodytriggerMetaInfoId, Expression<Func<string>> airmeetId = null, Expression<Func<string>> sessionId = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodytriggerMetaInfoId = WorkflowExpression.Compile(bodytriggerMetaInfoId, nameof(bodytriggerMetaInfoId), required: true);
            var __workflow_airmeetId = WorkflowExpression.Compile(airmeetId, nameof(airmeetId), required: false);
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: false);
            return new DeferredBodyTrigger<AirmeetTriggersResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/platform-integration/v1/webhook-register";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_airmeetId != null)
                    callPayload.Queries["airmeetId"] = ExpressionConverter.Convert(__workflow_airmeetId);
                if (__workflow_sessionId != null)
                    callPayload.Queries["sessionId"] = ExpressionConverter.Convert(__workflow_sessionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["triggerMetaInfoId"] = ExpressionConverter.ConvertO(__workflow_bodytriggerMetaInfoId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<AirmeetTriggersResponse>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class GetAirmeetsResponse
    {
        [JsonProperty("data")]
        public GetAirmeetsResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("cursors")]
        public GetAirmeetsResponseCursorsType Cursors { get; set; }
    }

    public class GetAirmeetsResponseDataTypeItem
    {
        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("startTime")]
        public string StartTime { get; set; }

        [JsonProperty("endTime")]
        public string EndTime { get; set; }
    }

    public class GetAirmeetsResponseCursorsType
    {
        [JsonProperty("after")]
        public int After { get; set; }

        [JsonProperty("before")]
        public int Before { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }
    }

    public class CreateAirmeetResponse
    {
        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyaccessInput
    {
        [EnumMember(Value = "INVITED_ONLY")]
        INVITEDONLY,
        [EnumMember(Value = "WITH_VERIFIED_EMAIL")]
        WITHVERIFIEDEMAIL,
        [EnumMember(Value = "WITHOUT_VERIFIED_EMAIL")]
        WITHOUTVERIFIEDEMAIL
    }

    public class CreateSpeakerResponse
    {
        [JsonProperty("speakerEmail")]
        public string SpeakerEmail { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class AirmeetSessionsResponse
    {
        [JsonProperty("sessions")]
        public AirmeetSessionsResponseSessionsTypeItem[] Sessions { get; set; }
    }

    public class AirmeetSessionsResponseSessionsTypeItem
    {
        [JsonProperty("sessionid")]
        public string Sessionid { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("start_time")]
        public string StartTime { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("host_id")]
        public string[] HostId { get; set; }

        [JsonProperty("cohost_ids")]
        public JToken[] CohostIds { get; set; }

        [JsonProperty("speaker_id")]
        public JToken[] SpeakerId { get; set; }

        [JsonProperty("speakerList")]
        public JToken[] SpeakerList { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class StartAndEndAirmeetResponse
    {
        [JsonProperty("statusUpdated")]
        public bool StatusUpdated { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodystatusInput
    {
        ONGOING,
        FINISHED
    }

    public class AirmeetRegistrationsResponse
    {
        [JsonProperty("data")]
        public AirmeetRegistrationsResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("cursors")]
        public AirmeetRegistrationsResponseCursorsType Cursors { get; set; }
    }

    public class AirmeetRegistrationsResponseDataTypeItem
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("organisation")]
        public string Organisation { get; set; }
        public string Designation { get; set; }

        [JsonProperty("registrationDate")]
        public string RegistrationDate { get; set; }
    }

    public class AirmeetRegistrationsResponseCursorsType
    {
        [JsonProperty("before")]
        public int Before { get; set; }

        [JsonProperty("after")]
        public int After { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }
    }

    public class AirmeetParticipantsResponse
    {
        [JsonProperty("paticipants")]
        public AirmeetParticipantsResponsePaticipantsTypeItem[] Paticipants { get; set; }

        [JsonProperty("userCount")]
        public int UserCount { get; set; }

        [JsonProperty("totalUserCount")]
        public int TotalUserCount { get; set; }
    }

    public class AirmeetParticipantsResponsePaticipantsTypeItem
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("organisation")]
        public string Organisation { get; set; }
        public string Designation { get; set; }

        [JsonProperty("registrationDate")]
        public string RegistrationDate { get; set; }

        [JsonProperty("profile_url")]
        public string ProfileUrl { get; set; }

        [JsonProperty("user_type")]
        public string UserType { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("invite_sent")]
        public bool InviteSent { get; set; }

        [JsonProperty("user_profile")]
        public AirmeetParticipantsResponsePaticipantsTypeItemUserProfileTypeItem[] UserProfile { get; set; }
    }

    public class AirmeetParticipantsResponsePaticipantsTypeItemUserProfileTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("fieldId")]
        public string FieldId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum sortingKeyInput
    {
        [EnumMember(Value = "name")]
        Name,
        [EnumMember(Value = "email")]
        Email,
        [EnumMember(Value = "registrationDate")]
        RegistrationDate
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum sortingDirectionInput
    {
        ASC,
        DESC
    }

    public class CustomRegistrationFieldsResponse
    {
        [JsonProperty("customFields")]
        public CustomRegistrationFieldsResponseCustomFieldsTypeItem[] CustomFields { get; set; }
    }

    public class CustomRegistrationFieldsResponseCustomFieldsTypeItem
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("fieldId")]
        public string FieldId { get; set; }

        [JsonProperty("options")]
        public CustomRegistrationFieldsResponseCustomFieldsTypeItemOptionsTypeItem[] Options { get; set; }

        [JsonProperty("isRequired")]
        public bool IsRequired { get; set; }

        [JsonProperty("type")]
        public CustomRegistrationFieldsResponseCustomFieldsTypeItemTypeType Type { get; set; }
    }

    public class CustomRegistrationFieldsResponseCustomFieldsTypeItemOptionsTypeItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("displayValue")]
        public string DisplayValue { get; set; }
    }

    public class CustomRegistrationFieldsResponseCustomFieldsTypeItemTypeType
    {
        [JsonProperty("fieldType")]
        public string FieldType { get; set; }

        [JsonProperty("inputType")]
        public string InputType { get; set; }

        [JsonProperty("mappedFrom")]
        public string MappedFrom { get; set; }
    }

    public class RemoveAttendeeResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class FetchEventTracksResponse
    {
        [JsonProperty("tracks")]
        public FetchEventTracksResponseTracksTypeItem[] Tracks { get; set; }
    }

    public class FetchEventTracksResponseTracksTypeItem
    {
        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("track_order")]
        public string TrackOrder { get; set; }

        [JsonProperty("metaData")]
        public FetchEventTracksResponseTracksTypeItemMetaDataType MetaData { get; set; }

        [JsonProperty("sessions")]
        public string[] Sessions { get; set; }
    }

    public class FetchEventTracksResponseTracksTypeItemMetaDataType
    {
        [JsonProperty("colorCode")]
        public string ColorCode { get; set; }
    }

    public class FetchAirmeetBoothsResponse
    {
        [JsonProperty("booths")]
        public FetchAirmeetBoothsResponseBoothsTypeItem[] Booths { get; set; }
    }

    public class FetchAirmeetBoothsResponseBoothsTypeItem
    {
        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("exhibitors")]
        public string[] Exhibitors { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("airmeet_id")]
        public string AirmeetId { get; set; }

        [JsonProperty("logo_url")]
        public string LogoUrl { get; set; }

        [JsonProperty("video")]
        public string Video { get; set; }

        [JsonProperty("faqs")]
        public string Faqs { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("resources")]
        public string Resources { get; set; }

        [JsonProperty("layoutType")]
        public string LayoutType { get; set; }

        [JsonProperty("layoutData")]
        public string LayoutData { get; set; }

        [JsonProperty("boothExhibitor")]
        public bool BoothExhibitor { get; set; }

        [JsonProperty("social_media_links")]
        public string SocialMediaLinks { get; set; }

        [JsonProperty("short_description")]
        public string ShortDescription { get; set; }

        [JsonProperty("long_description")]
        public string LongDescription { get; set; }

        [JsonProperty("banner_url")]
        public string BannerUrl { get; set; }

        [JsonProperty("register_interest_details")]
        public string RegisterInterestDetails { get; set; }

        [JsonProperty("offer_details")]
        public string OfferDetails { get; set; }

        [JsonProperty("doc_url")]
        public string DocUrl { get; set; }

        [JsonProperty("doc_name")]
        public string DocName { get; set; }

        [JsonProperty("booth_space_id")]
        public string BoothSpaceId { get; set; }
    }

    public class CreateBoothResponse
    {
        [JsonProperty("uuid")]
        public string Uuid { get; set; }
    }

    public class bodyexhibitorInfoInputItem
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("exhibitorAttendanceType")]
        public bodyexhibitorInfoInputItemExhibitorAttendanceTypeType ExhibitorAttendanceType { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyexhibitorInfoInputItemExhibitorAttendanceTypeType
    {
        [EnumMember(Value = "HYBRID")]
        HYBRId,
        ONLINE
    }

    public class AddAuthorizedAttendeeResponse
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("entryLink")]
        public string EntryLink { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyattendanceTypeInput
    {
        VIRTUAL,
        [EnumMember(Value = "IN-PERSON")]
        INPERSON
    }

    public class bodycustomFieldMappingInputItem
    {
        [JsonProperty("fieldId")]
        public string FieldId { get; set; }

        [JsonProperty("value")]
        public string[] Value { get; set; }
    }

    public class CreateSessionResponse
    {
        [JsonProperty("uuid")]
        public string Uuid { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodytypeInput
    {
        HOSTING,
        [EnumMember(Value = "FLUID_LOUNGE")]
        FLUIdLOUNGE,
        BOOTH,
        BREAK,
        [EnumMember(Value = "LARGE_CALL")]
        LARGECALL,
        [EnumMember(Value = "SPEED_NETWORKING")]
        SPEEDNETWORKING,
        STREAMING
    }

    public class AirmeetTriggersResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("triggerMetaInfoId")]
        public string TriggerMetaInfoId { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodytriggerMetaInfoIdInput
    {
        [EnumMember(Value = "trigger.airmeet.created")]
        TriggerAirmeetCreated,
        [EnumMember(Value = "trigger.airmeet.attendee.added")]
        TriggerAirmeetAttendeeAdded,
        [EnumMember(Value = "trigger.airmeet.started")]
        TriggerAirmeetStarted,
        [EnumMember(Value = "trigger.airmeet.finished")]
        TriggerAirmeetFinished,
        [EnumMember(Value = "trigger.airmeet.reminder")]
        TriggerAirmeetReminder,
        [EnumMember(Value = "trigger.airmeet.recording.available")]
        TriggerAirmeetRecordingAvailable,
        [EnumMember(Value = "trigger.airmeet.registrant.added")]
        TriggerAirmeetRegistrantAdded,
        [EnumMember(Value = "trigger.airmeet.attendee.joined")]
        TriggerAirmeetAttendeeJoined,
        [EnumMember(Value = "trigger.session.attendee.joined")]
        TriggerSessionAttendeeJoined,
        [EnumMember(Value = "trigger.airmeet.polls")]
        TriggerAirmeetPolls,
        [EnumMember(Value = "trigger.airmeet.questions")]
        TriggerAirmeetQuestions,
        [EnumMember(Value = "trigger.attendee.booth.joined")]
        TriggerAttendeeBoothJoined
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Airmeet;

    public partial class WorkflowManagedActions
    {
        public AirmeetActions Airmeet(string connectionId) => new AirmeetActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AirmeetTriggers Airmeet(string connectionId) => new AirmeetTriggers(connectionId);
    }
}