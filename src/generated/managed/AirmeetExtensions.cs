//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Airmeet
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AirmeetActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airmeet")]
        public IBodyWorkflowAction<GetAirmeetsResponse> GetAirmeets()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/airmeets";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["allAirmeets"] = Convert.ToString(true);
                callPayload.Queries["crmName"] = Convert.ToString("MICROSOFT_DYNAMICS");
                return callPayload;
            }

            return new ApiConnectionAction<GetAirmeetsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airmeet")]
        public IBodyWorkflowAction<CreateAirmeetResponse> CreateAirmeet([WorkflowExpression] Func<string> bodyhostEmail, [WorkflowExpression] Func<string> bodyeventName, [WorkflowExpression] Func<string> bodyshortDesc, [WorkflowExpression] Func<string> bodyeventImage = null, [WorkflowExpression] Func<string> bodylongDesc = null, [WorkflowExpression] Func<bodyaccessInput> bodyaccess = null, [WorkflowExpression] Func<int> bodytimingstartTime = null, [WorkflowExpression] Func<int> bodytimingendTime = null, [WorkflowExpression] Func<string> bodytimingtimezone = null, [WorkflowExpression] Func<bool> bodyconfignetworking = null, [WorkflowExpression] Func<int> bodyconfigtableCount = null)
        {
            SourceExpression.Validate(bodyhostEmail, nameof(bodyhostEmail), required: true);
            SourceExpression.Validate(bodyeventName, nameof(bodyeventName), required: true);
            SourceExpression.Validate(bodyshortDesc, nameof(bodyshortDesc), required: true);
            SourceExpression.Validate(bodyeventImage, nameof(bodyeventImage), required: false);
            SourceExpression.Validate(bodylongDesc, nameof(bodylongDesc), required: false);
            SourceExpression.Validate(bodyaccess, nameof(bodyaccess), required: false);
            SourceExpression.Validate(bodytimingstartTime, nameof(bodytimingstartTime), required: false);
            SourceExpression.Validate(bodytimingendTime, nameof(bodytimingendTime), required: false);
            SourceExpression.Validate(bodytimingtimezone, nameof(bodytimingtimezone), required: false);
            SourceExpression.Validate(bodyconfignetworking, nameof(bodyconfignetworking), required: false);
            SourceExpression.Validate(bodyconfigtableCount, nameof(bodyconfigtableCount), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/airmeet";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["hostEmail"] = SourceExpressionConverter.ConvertToken(bodyhostEmail);
                bodypropCount++;
                body["eventName"] = SourceExpressionConverter.ConvertToken(bodyeventName);
                bodypropCount++;
                body["shortDesc"] = SourceExpressionConverter.ConvertToken(bodyshortDesc);
                if (bodyeventImage != null)
                {
                    body["eventImage"] = SourceExpressionConverter.ConvertToken(bodyeventImage);
                    bodypropCount++;
                }

                if (bodylongDesc != null)
                {
                    body["longDesc"] = SourceExpressionConverter.ConvertToken(bodylongDesc);
                    bodypropCount++;
                }

                if (bodyaccess != null)
                {
                    if (bodyaccess != null)
                    {
                        body["access"] = SourceExpressionConverter.Convert(bodyaccess);
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
                if (bodytimingstartTime != null)
                {
                    timingObject["startTime"] = SourceExpressionConverter.ConvertToken(bodytimingstartTime);
                    timingObjectpropCount++;
                }

                if (bodytimingendTime != null)
                {
                    timingObject["endTime"] = SourceExpressionConverter.ConvertToken(bodytimingendTime);
                    timingObjectpropCount++;
                }

                if (bodytimingtimezone != null)
                {
                    if (bodytimingtimezone != null)
                    {
                        timingObject["timezone"] = SourceExpressionConverter.ConvertToken(bodytimingtimezone);
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
                if (bodyconfignetworking != null)
                {
                    if (bodyconfignetworking != null)
                    {
                        configObject["networking"] = SourceExpressionConverter.ConvertToken(bodyconfignetworking);
                        configObjectpropCount++;
                    }

                    configObjectpropCount++;
                }
                else
                {
                    configObject["networking"] = true;
                    configObjectpropCount++;
                }

                if (bodyconfigtableCount != null)
                {
                    if (bodyconfigtableCount != null)
                    {
                        configObject["tableCount"] = SourceExpressionConverter.ConvertToken(bodyconfigtableCount);
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
                return callPayload;
            }

            return new ApiConnectionAction<CreateAirmeetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airmeet")]
        public IBodyWorkflowAction<CreateSpeakerResponse> CreateSpeaker([WorkflowExpression] Func<string> airmeetId, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodyemail, [WorkflowExpression] Func<string> bodyorganisation = null, [WorkflowExpression] Func<string> bodydesignation = null, [WorkflowExpression] Func<string> bodyimageUrl = null, [WorkflowExpression] Func<string> bodybio = null, [WorkflowExpression] Func<string> bodycity = null, [WorkflowExpression] Func<string> bodycountry = null)
        {
            SourceExpression.Validate(airmeetId, nameof(airmeetId), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            SourceExpression.Validate(bodyemail, nameof(bodyemail), required: true);
            SourceExpression.Validate(bodyorganisation, nameof(bodyorganisation), required: false);
            SourceExpression.Validate(bodydesignation, nameof(bodydesignation), required: false);
            SourceExpression.Validate(bodyimageUrl, nameof(bodyimageUrl), required: false);
            SourceExpression.Validate(bodybio, nameof(bodybio), required: false);
            SourceExpression.Validate(bodycity, nameof(bodycity), required: false);
            SourceExpression.Validate(bodycountry, nameof(bodycountry), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/airmeet/{0}/speaker", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(airmeetId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
                body["email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                if (bodyorganisation != null)
                {
                    body["organisation"] = SourceExpressionConverter.ConvertToken(bodyorganisation);
                    bodypropCount++;
                }

                if (bodydesignation != null)
                {
                    body["designation"] = SourceExpressionConverter.ConvertToken(bodydesignation);
                    bodypropCount++;
                }

                if (bodyimageUrl != null)
                {
                    body["imageUrl"] = SourceExpressionConverter.ConvertToken(bodyimageUrl);
                    bodypropCount++;
                }

                if (bodybio != null)
                {
                    body["bio"] = SourceExpressionConverter.ConvertToken(bodybio);
                    bodypropCount++;
                }

                if (bodycity != null)
                {
                    body["city"] = SourceExpressionConverter.ConvertToken(bodycity);
                    bodypropCount++;
                }

                if (bodycountry != null)
                {
                    body["country"] = SourceExpressionConverter.ConvertToken(bodycountry);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateSpeakerResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airmeet")]
        public IBodyWorkflowAction<AirmeetSessionsResponse> AirmeetSessions([WorkflowExpression] Func<string> airmeetId)
        {
            SourceExpression.Validate(airmeetId, nameof(airmeetId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/airmeet/{0}/info", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(airmeetId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<AirmeetSessionsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airmeet")]
        public IBodyWorkflowAction<StartAndEndAirmeetResponse> StartAndEndAirmeet([WorkflowExpression] Func<string> airmeetId, [WorkflowExpression] Func<bodystatusInput> bodystatus)
        {
            SourceExpression.Validate(airmeetId, nameof(airmeetId), required: true);
            SourceExpression.Validate(bodystatus, nameof(bodystatus), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/airmeet/{0}/status", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(airmeetId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["status"] = SourceExpressionConverter.Convert(bodystatus);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<StartAndEndAirmeetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airmeet")]
        public IBodyWorkflowAction<AirmeetRegistrationsResponse> AirmeetRegistrations([WorkflowExpression] Func<string> airmeetId, [WorkflowExpression] Func<int> size, [WorkflowExpression] Func<int> after = null, [WorkflowExpression] Func<int> before = null)
        {
            SourceExpression.Validate(airmeetId, nameof(airmeetId), required: true);
            SourceExpression.Validate(size, nameof(size), required: true);
            SourceExpression.Validate(after, nameof(after), required: false);
            SourceExpression.Validate(before, nameof(before), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/airmeet/{0}/registrations", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(airmeetId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (after != null)
                    callPayload.Queries["after"] = SourceExpressionConverter.ConvertO(after);
                if (before != null)
                    callPayload.Queries["before"] = SourceExpressionConverter.ConvertO(before);
                callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                return callPayload;
            }

            return new ApiConnectionAction<AirmeetRegistrationsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airmeet")]
        public IBodyWorkflowAction<AirmeetParticipantsResponse> AirmeetParticipants([WorkflowExpression] Func<string> airmeetId, [WorkflowExpression] Func<int> resultSize = null, [WorkflowExpression] Func<int> pageNumber = null, [WorkflowExpression] Func<sortingKeyInput> sortingKey = null, [WorkflowExpression] Func<sortingDirectionInput> sortingDirection = null)
        {
            SourceExpression.Validate(airmeetId, nameof(airmeetId), required: true);
            SourceExpression.Validate(resultSize, nameof(resultSize), required: false);
            SourceExpression.Validate(pageNumber, nameof(pageNumber), required: false);
            SourceExpression.Validate(sortingKey, nameof(sortingKey), required: false);
            SourceExpression.Validate(sortingDirection, nameof(sortingDirection), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/airmeet/{0}/participants", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(airmeetId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (resultSize != null)
                    callPayload.Queries["resultSize"] = SourceExpressionConverter.ConvertO(resultSize);
                if (pageNumber != null)
                    callPayload.Queries["pageNumber"] = SourceExpressionConverter.ConvertO(pageNumber);
                callPayload.Queries["sortingKey"] = Convert.ToString("registrationDate");
                if (sortingKey != null)
                    callPayload.Queries["sortingKey"] = SourceExpressionConverter.Convert(sortingKey);
                if (sortingDirection != null)
                    callPayload.Queries["sortingDirection"] = SourceExpressionConverter.Convert(sortingDirection);
                return callPayload;
            }

            return new ApiConnectionAction<AirmeetParticipantsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airmeet")]
        public IBodyWorkflowAction<CustomRegistrationFieldsResponse> CustomRegistrationFields([WorkflowExpression] Func<string> airmeetId)
        {
            SourceExpression.Validate(airmeetId, nameof(airmeetId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/airmeet/{0}/custom-fields", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(airmeetId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<CustomRegistrationFieldsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airmeet")]
        public IBodyWorkflowAction<RemoveAttendeeResponse> RemoveAttendee([WorkflowExpression] Func<string> airmeetId, [WorkflowExpression] Func<string> urlEncodedAttendeeEmail)
        {
            SourceExpression.Validate(airmeetId, nameof(airmeetId), required: true);
            SourceExpression.Validate(urlEncodedAttendeeEmail, nameof(urlEncodedAttendeeEmail), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/airmeet/{0}/attendee/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(airmeetId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(urlEncodedAttendeeEmail, 2));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<RemoveAttendeeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airmeet")]
        public IBodyWorkflowAction<FetchEventTracksResponse> FetchEventTracks([WorkflowExpression] Func<string> airmeetId)
        {
            SourceExpression.Validate(airmeetId, nameof(airmeetId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/airmeet/{0}/tracks", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(airmeetId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<FetchEventTracksResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airmeet")]
        public IBodyWorkflowAction<FetchAirmeetBoothsResponse> FetchAirmeetBooths([WorkflowExpression] Func<string> airmeetId)
        {
            SourceExpression.Validate(airmeetId, nameof(airmeetId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/airmeet/{0}/booths", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(airmeetId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<FetchAirmeetBoothsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airmeet")]
        public IBodyWorkflowAction<CreateBoothResponse> CreateBooth([WorkflowExpression] Func<string> airmeetId, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<bodyexhibitorInfoInputItem[]> bodyexhibitorInfo, [WorkflowExpression] Func<string[]> bodytags = null, [WorkflowExpression] Func<bool> bodymetaDatachatEnabled = null, [WorkflowExpression] Func<bool> bodymetaDataloungeEnabled = null, [WorkflowExpression] Func<bool> bodymetaDatabroadcastEnabled = null, [WorkflowExpression] Func<int> bodymetaDatatableCount = null)
        {
            SourceExpression.Validate(airmeetId, nameof(airmeetId), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            SourceExpression.Validate(bodyexhibitorInfo, nameof(bodyexhibitorInfo), required: true);
            SourceExpression.Validate(bodytags, nameof(bodytags), required: false);
            SourceExpression.Validate(bodymetaDatachatEnabled, nameof(bodymetaDatachatEnabled), required: false);
            SourceExpression.Validate(bodymetaDataloungeEnabled, nameof(bodymetaDataloungeEnabled), required: false);
            SourceExpression.Validate(bodymetaDatabroadcastEnabled, nameof(bodymetaDatabroadcastEnabled), required: false);
            SourceExpression.Validate(bodymetaDatatableCount, nameof(bodymetaDatatableCount), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/airmeet/{0}/booths", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(airmeetId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
                body["exhibitorInfo"] = SourceExpressionConverter.ConvertToken(bodyexhibitorInfo);
                if (bodytags != null)
                {
                    body["tags"] = SourceExpressionConverter.ConvertToken(bodytags);
                    bodypropCount++;
                }

                var metaDataObject = new JObject();
                var metaDataObjectpropCount = 0;
                if (bodymetaDatachatEnabled != null)
                {
                    if (bodymetaDatachatEnabled != null)
                    {
                        metaDataObject["chatEnabled"] = SourceExpressionConverter.ConvertToken(bodymetaDatachatEnabled);
                        metaDataObjectpropCount++;
                    }

                    metaDataObjectpropCount++;
                }
                else
                {
                    metaDataObject["chatEnabled"] = false;
                    metaDataObjectpropCount++;
                }

                if (bodymetaDataloungeEnabled != null)
                {
                    if (bodymetaDataloungeEnabled != null)
                    {
                        metaDataObject["loungeEnabled"] = SourceExpressionConverter.ConvertToken(bodymetaDataloungeEnabled);
                        metaDataObjectpropCount++;
                    }

                    metaDataObjectpropCount++;
                }
                else
                {
                    metaDataObject["loungeEnabled"] = false;
                    metaDataObjectpropCount++;
                }

                if (bodymetaDatabroadcastEnabled != null)
                {
                    if (bodymetaDatabroadcastEnabled != null)
                    {
                        metaDataObject["broadcastEnabled"] = SourceExpressionConverter.ConvertToken(bodymetaDatabroadcastEnabled);
                        metaDataObjectpropCount++;
                    }

                    metaDataObjectpropCount++;
                }
                else
                {
                    metaDataObject["broadcastEnabled"] = false;
                    metaDataObjectpropCount++;
                }

                if (bodymetaDatatableCount != null)
                {
                    if (bodymetaDatatableCount != null)
                    {
                        metaDataObject["tableCount"] = SourceExpressionConverter.ConvertToken(bodymetaDatatableCount);
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
                return callPayload;
            }

            return new ApiConnectionAction<CreateBoothResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airmeet")]
        public IBodyWorkflowAction<AddAuthorizedAttendeeResponse> AddAuthorizedAttendee([WorkflowExpression] Func<string> airmeetId, [WorkflowExpression] Func<string> bodyemail, [WorkflowExpression] Func<string> bodyfirstName, [WorkflowExpression] Func<string> bodylastName, [WorkflowExpression] Func<bool> bodyregisterAttendee, [WorkflowExpression] Func<bool> bodysendEmailInvite, [WorkflowExpression] Func<bodyattendanceTypeInput> bodyattendanceType = null, [WorkflowExpression] Func<string> bodycity = null, [WorkflowExpression] Func<string> bodycountry = null, [WorkflowExpression] Func<string> bodydesignation = null, [WorkflowExpression] Func<string> bodyorganisation = null, [WorkflowExpression] Func<bodycustomFieldMappingInputItem[]> bodycustomFieldMapping = null)
        {
            SourceExpression.Validate(airmeetId, nameof(airmeetId), required: true);
            SourceExpression.Validate(bodyemail, nameof(bodyemail), required: true);
            SourceExpression.Validate(bodyfirstName, nameof(bodyfirstName), required: true);
            SourceExpression.Validate(bodylastName, nameof(bodylastName), required: true);
            SourceExpression.Validate(bodyregisterAttendee, nameof(bodyregisterAttendee), required: true);
            SourceExpression.Validate(bodysendEmailInvite, nameof(bodysendEmailInvite), required: true);
            SourceExpression.Validate(bodyattendanceType, nameof(bodyattendanceType), required: false);
            SourceExpression.Validate(bodycity, nameof(bodycity), required: false);
            SourceExpression.Validate(bodycountry, nameof(bodycountry), required: false);
            SourceExpression.Validate(bodydesignation, nameof(bodydesignation), required: false);
            SourceExpression.Validate(bodyorganisation, nameof(bodyorganisation), required: false);
            SourceExpression.Validate(bodycustomFieldMapping, nameof(bodycustomFieldMapping), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/airmeet/{0}/attendee", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(airmeetId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                bodypropCount++;
                body["firstName"] = SourceExpressionConverter.ConvertToken(bodyfirstName);
                bodypropCount++;
                body["lastName"] = SourceExpressionConverter.ConvertToken(bodylastName);
                if (bodyattendanceType != null)
                {
                    if (bodyattendanceType != null)
                    {
                        body["attendance_type"] = SourceExpressionConverter.Convert(bodyattendanceType);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["attendance_type"] = "IN-PERSON";
                    bodypropCount++;
                }

                if (bodycity != null)
                {
                    body["city"] = SourceExpressionConverter.ConvertToken(bodycity);
                    bodypropCount++;
                }

                if (bodycountry != null)
                {
                    body["country"] = SourceExpressionConverter.ConvertToken(bodycountry);
                    bodypropCount++;
                }

                if (bodydesignation != null)
                {
                    body["designation"] = SourceExpressionConverter.ConvertToken(bodydesignation);
                    bodypropCount++;
                }

                if (bodyorganisation != null)
                {
                    body["organisation"] = SourceExpressionConverter.ConvertToken(bodyorganisation);
                    bodypropCount++;
                }

                bodypropCount++;
                body["registerAttendee"] = SourceExpressionConverter.ConvertToken(bodyregisterAttendee);
                bodypropCount++;
                body["sendEmailInvite"] = SourceExpressionConverter.ConvertToken(bodysendEmailInvite);
                if (bodycustomFieldMapping != null)
                {
                    body["customFieldMapping"] = SourceExpressionConverter.ConvertToken(bodycustomFieldMapping);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AddAuthorizedAttendeeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airmeet")]
        public IBodyWorkflowAction<CreateSessionResponse> CreateSession([WorkflowExpression] Func<string> airmeetId, [WorkflowExpression] Func<int> bodysessionStartTime, [WorkflowExpression] Func<string> bodyhostEmail, [WorkflowExpression] Func<string> bodysessionTitle = null, [WorkflowExpression] Func<int> bodysessionDuration = null, [WorkflowExpression] Func<string> bodysessionSummary = null, [WorkflowExpression] Func<string[]> bodyspeakerEmails = null, [WorkflowExpression] Func<string[]> bodycohostEmails = null, [WorkflowExpression] Func<bodytypeInput> bodytype = null, [WorkflowExpression] Func<string[]> bodytracks = null, [WorkflowExpression] Func<string[]> bodytags = null, [WorkflowExpression] Func<string> bodyboothId = null, [WorkflowExpression] Func<int> bodyspeedNetworkingDataconversationTime = null, [WorkflowExpression] Func<int> bodyspeedNetworkingDataextendNetworkingTime = null, [WorkflowExpression] Func<bool> bodysessionMetahideHost = null)
        {
            SourceExpression.Validate(airmeetId, nameof(airmeetId), required: true);
            SourceExpression.Validate(bodysessionStartTime, nameof(bodysessionStartTime), required: true);
            SourceExpression.Validate(bodyhostEmail, nameof(bodyhostEmail), required: true);
            SourceExpression.Validate(bodysessionTitle, nameof(bodysessionTitle), required: false);
            SourceExpression.Validate(bodysessionDuration, nameof(bodysessionDuration), required: false);
            SourceExpression.Validate(bodysessionSummary, nameof(bodysessionSummary), required: false);
            SourceExpression.Validate(bodyspeakerEmails, nameof(bodyspeakerEmails), required: false);
            SourceExpression.Validate(bodycohostEmails, nameof(bodycohostEmails), required: false);
            SourceExpression.Validate(bodytype, nameof(bodytype), required: false);
            SourceExpression.Validate(bodytracks, nameof(bodytracks), required: false);
            SourceExpression.Validate(bodytags, nameof(bodytags), required: false);
            SourceExpression.Validate(bodyboothId, nameof(bodyboothId), required: false);
            SourceExpression.Validate(bodyspeedNetworkingDataconversationTime, nameof(bodyspeedNetworkingDataconversationTime), required: false);
            SourceExpression.Validate(bodyspeedNetworkingDataextendNetworkingTime, nameof(bodyspeedNetworkingDataextendNetworkingTime), required: false);
            SourceExpression.Validate(bodysessionMetahideHost, nameof(bodysessionMetahideHost), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/airmeet/{0}/session", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(airmeetId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodysessionTitle != null)
                {
                    body["sessionTitle"] = SourceExpressionConverter.ConvertToken(bodysessionTitle);
                    bodypropCount++;
                }

                bodypropCount++;
                body["sessionStartTime"] = SourceExpressionConverter.ConvertToken(bodysessionStartTime);
                if (bodysessionDuration != null)
                {
                    if (bodysessionDuration != null)
                    {
                        body["sessionDuration"] = SourceExpressionConverter.ConvertToken(bodysessionDuration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["sessionDuration"] = 30;
                    bodypropCount++;
                }

                if (bodysessionSummary != null)
                {
                    body["sessionSummary"] = SourceExpressionConverter.ConvertToken(bodysessionSummary);
                    bodypropCount++;
                }

                bodypropCount++;
                body["hostEmail"] = SourceExpressionConverter.ConvertToken(bodyhostEmail);
                if (bodyspeakerEmails != null)
                {
                    body["speakerEmails"] = SourceExpressionConverter.ConvertToken(bodyspeakerEmails);
                    bodypropCount++;
                }

                if (bodycohostEmails != null)
                {
                    body["cohostEmails"] = SourceExpressionConverter.ConvertToken(bodycohostEmails);
                    bodypropCount++;
                }

                if (bodytype != null)
                {
                    if (bodytype != null)
                    {
                        body["type"] = SourceExpressionConverter.Convert(bodytype);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["type"] = "HOSTING";
                    bodypropCount++;
                }

                if (bodytracks != null)
                {
                    body["tracks"] = SourceExpressionConverter.ConvertToken(bodytracks);
                    bodypropCount++;
                }

                if (bodytags != null)
                {
                    body["tags"] = SourceExpressionConverter.ConvertToken(bodytags);
                    bodypropCount++;
                }

                if (bodyboothId != null)
                {
                    body["boothId"] = SourceExpressionConverter.ConvertToken(bodyboothId);
                    bodypropCount++;
                }

                var speedNetworkingDataObject = new JObject();
                var speedNetworkingDataObjectpropCount = 0;
                if (bodyspeedNetworkingDataconversationTime != null)
                {
                    speedNetworkingDataObject["conversationTime"] = SourceExpressionConverter.ConvertToken(bodyspeedNetworkingDataconversationTime);
                    speedNetworkingDataObjectpropCount++;
                }

                if (bodyspeedNetworkingDataextendNetworkingTime != null)
                {
                    speedNetworkingDataObject["extendNetworkingTime"] = SourceExpressionConverter.ConvertToken(bodyspeedNetworkingDataextendNetworkingTime);
                    speedNetworkingDataObjectpropCount++;
                }

                if (speedNetworkingDataObjectpropCount > 0)
                {
                    body["speedNetworkingData"] = speedNetworkingDataObject;
                    bodypropCount++;
                }

                var sessionMetaObject = new JObject();
                var sessionMetaObjectpropCount = 0;
                if (bodysessionMetahideHost != null)
                {
                    sessionMetaObject["hideHost"] = SourceExpressionConverter.ConvertToken(bodysessionMetahideHost);
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
                return callPayload;
            }

            return new ApiConnectionAction<CreateSessionResponse>(BuildSourceInput);
        }
    }

    public class AirmeetTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<AirmeetTriggersResponse> AirmeetTriggers2([WorkflowExpression] Func<bodytriggerMetaInfoIdInput> bodytriggerMetaInfoId, [WorkflowExpression] Func<string> airmeetId = null, [WorkflowExpression] Func<string> sessionId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodytriggerMetaInfoId, nameof(bodytriggerMetaInfoId), required: true);
            SourceExpression.Validate(airmeetId, nameof(airmeetId), required: false);
            SourceExpression.Validate(sessionId, nameof(sessionId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/platform-integration/v1/webhook-register";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (airmeetId != null)
                    callPayload.Queries["airmeetId"] = SourceExpressionConverter.ConvertO(airmeetId);
                if (sessionId != null)
                    callPayload.Queries["sessionId"] = SourceExpressionConverter.ConvertO(sessionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["triggerMetaInfoId"] = SourceExpressionConverter.Convert(bodytriggerMetaInfoId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<AirmeetTriggersResponse>(BuildSourceInput, triggerName, recurrence);
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

    public enum sortingKeyInput
    {
        [EnumMember(Value = "name")]
        Name,
        [EnumMember(Value = "email")]
        Email,
        [EnumMember(Value = "registrationDate")]
        RegistrationDate
    }

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