//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Meetingroommap
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MeetingroommapActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meetingroommap")]
        public IWorkflowAction GetCustomLocations([WorkflowExpression] Func<string[]> bodycategories = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/CustomLocations/GetCustomLocations";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycategories != null)
                {
                    body["categories"] = SourceExpressionConverter.ConvertToken(bodycategories);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meetingroommap")]
        public IBodyWorkflowAction<GetCustomLocationsByImageNameResponse> GetCustomLocationsByImageName([WorkflowExpression] Func<string> bodyimageName, [WorkflowExpression] Func<string[]> bodycategories = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/CustomLocations/GetCustomLocationsByImageName";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["imageName"] = SourceExpressionConverter.ConvertToken(bodyimageName);
                if (bodycategories != null)
                {
                    body["categories"] = SourceExpressionConverter.ConvertToken(bodycategories);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GetCustomLocationsByImageNameResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meetingroommap")]
        public IBodyWorkflowAction<string[]> GetCategories()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/CustomLocations/categories";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meetingroommap")]
        public IWorkflowAction LocationDetails([WorkflowExpression] Func<string> locationId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/CustomLocations/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(locationId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meetingroommap")]
        public IBodyWorkflowAction<SearchLocationsResponseItem[]> SearchLocations([WorkflowExpression] Func<string> locationName, [WorkflowExpression] Func<string> category = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/CustomLocations/findbyname/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(locationName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (category != null)
                    callPayload.Queries["Category"] = SourceExpressionConverter.ConvertO(category);
                return callPayload;
            }

            return new ApiConnectionAction<SearchLocationsResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meetingroommap")]
        public IBodyWorkflowAction<string> GetCustomLocationImage([WorkflowExpression] Func<string> locationId, [WorkflowExpression] Func<bool> large = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/CustomLocations/createimage/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(locationId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (large != null)
                    callPayload.Queries["Large"] = SourceExpressionConverter.ConvertO(large);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meetingroommap")]
        public IBodyWorkflowAction<ImagesResponseItem[]> Images()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/MapImage/thumbnails";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ImagesResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meetingroommap")]
        public IBodyWorkflowAction<string> GetMeetingRoomImage([WorkflowExpression] Func<string> roomName, [WorkflowExpression] Func<bool> large = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/MapImage/create/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(roomName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (large != null)
                    callPayload.Queries["Large"] = SourceExpressionConverter.ConvertO(large);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meetingroommap")]
        public IWorkflowAction NextMeetings([WorkflowExpression] Func<int> meetingCount)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/MapImage/meetings/{0}/roomdetails", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(meetingCount, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meetingroommap")]
        public IWorkflowAction GetMeetingRoomDetails([WorkflowExpression] Func<string> roomName)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/MapImage/roomdetails_v2/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(roomName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meetingroommap")]
        public IWorkflowAction GetOfficeLocations()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/officelocations";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meetingroommap")]
        public IBodyWorkflowAction<SearchCoworkersResponseItem[]> SearchCoworkers([WorkflowExpression] Func<string> personSearch)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/officelocations/searchCoworkers/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(personSearch, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<SearchCoworkersResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meetingroommap")]
        public IBodyWorkflowAction<GetOfficeLocationsByImageResponse> GetOfficeLocationsByImage([WorkflowExpression] Func<string> imageName)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/officelocations/bymapimage/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(imageName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetOfficeLocationsByImageResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meetingroommap")]
        public IBodyWorkflowAction<GetRoomWithPersonsDetailsResponse> GetRoomWithPersonsDetails([WorkflowExpression] Func<string> officeLocationName, [WorkflowExpression] Func<bool> inludeUserInfo = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/officelocations/mapimagewithpersoninfo/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(officeLocationName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["InludeUserInfo"] = Convert.ToString(true);
                if (inludeUserInfo != null)
                    callPayload.Queries["InludeUserInfo"] = SourceExpressionConverter.ConvertO(inludeUserInfo);
                return callPayload;
            }

            return new ApiConnectionAction<GetRoomWithPersonsDetailsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meetingroommap")]
        public IBodyWorkflowAction<string> GetOfficeLocationImage([WorkflowExpression] Func<string> officeLocationName, [WorkflowExpression] Func<bool> large = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/officelocationimage/create/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(officeLocationName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (large != null)
                    callPayload.Queries["Large"] = SourceExpressionConverter.ConvertO(large);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meetingroommap")]
        public IBodyWorkflowAction<AADMeetingRoomCollection> GetRooms()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/rooms";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<AADMeetingRoomCollection>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meetingroommap")]
        public IBodyWorkflowAction<AADMeetingRoomCollection> SearchMeetingRooms([WorkflowExpression] Func<string> name)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/rooms/findbyname/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(name, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<AADMeetingRoomCollection>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meetingroommap")]
        public IBodyWorkflowAction<AADMeetingRoomCollection> RoomLists()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/rooms/lists";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<AADMeetingRoomCollection>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meetingroommap")]
        public IBodyWorkflowAction<AADMeetingRoomCollection> RoomsByListAddress([WorkflowExpression] Func<string> meetingRoomListAddress)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/rooms/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(meetingRoomListAddress, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<AADMeetingRoomCollection>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meetingroommap")]
        public IBodyWorkflowAction<GetRoomsByImageNameResponse> GetRoomsByImageName([WorkflowExpression] Func<string> imageName)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/rooms/GetRoomsByImageName/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(imageName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetRoomsByImageNameResponse>(BuildSourceInput);
        }
    }

    public class MeetingroommapTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetCustomLocationsByImageNameResponse
    {
        [JsonProperty("customLocationCollection")]
        public GetCustomLocationsByImageNameResponseCustomLocationCollectionTypeItem[] CustomLocationCollection { get; set; }

        [JsonProperty("mapImage")]
        public GetCustomLocationsByImageNameResponseMapImageType MapImage { get; set; }
    }

    public class GetCustomLocationsByImageNameResponseCustomLocationCollectionTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("location")]
        public GetCustomLocationsByImageNameResponseCustomLocationCollectionTypeItemLocationType Location { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("tenantId")]
        public string TenantId { get; set; }
    }

    public class GetCustomLocationsByImageNameResponseCustomLocationCollectionTypeItemLocationType
    {
        [JsonProperty("image")]
        public GetCustomLocationsByImageNameResponseCustomLocationCollectionTypeItemLocationTypeImageType Image { get; set; }

        [JsonProperty("relativeLocation")]
        public GetCustomLocationsByImageNameResponseCustomLocationCollectionTypeItemLocationTypeRelativeLocationType RelativeLocation { get; set; }
    }

    public class GetCustomLocationsByImageNameResponseCustomLocationCollectionTypeItemLocationTypeImageType
    {
        [JsonProperty("imageName")]
        public string ImageName { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("originalUrl")]
        public string OriginalUrl { get; set; }

        [JsonProperty("thumbnailUrl")]
        public string ThumbnailUrl { get; set; }
    }

    public class GetCustomLocationsByImageNameResponseCustomLocationCollectionTypeItemLocationTypeRelativeLocationType
    {
        [JsonProperty("x")]
        public int X { get; set; }

        [JsonProperty("y")]
        public int Y { get; set; }
    }

    public class GetCustomLocationsByImageNameResponseMapImageType
    {
        [JsonProperty("imageName")]
        public string ImageName { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("thumbnailUrl")]
        public string ThumbnailUrl { get; set; }

        [JsonProperty("originalUrl")]
        public string OriginalUrl { get; set; }
    }

    public class SearchLocationsResponseItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("location")]
        public SearchLocationsResponseItemLocationType Location { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("tenantId")]
        public string TenantId { get; set; }
    }

    public class SearchLocationsResponseItemLocationType
    {
        [JsonProperty("image")]
        public SearchLocationsResponseItemLocationTypeImageType Image { get; set; }

        [JsonProperty("relativeLocation")]
        public SearchLocationsResponseItemLocationTypeRelativeLocationType RelativeLocation { get; set; }
    }

    public class SearchLocationsResponseItemLocationTypeImageType
    {
        [JsonProperty("imageName")]
        public string ImageName { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("originalUrl")]
        public string OriginalUrl { get; set; }

        [JsonProperty("thumbnailUrl")]
        public string ThumbnailUrl { get; set; }
    }

    public class SearchLocationsResponseItemLocationTypeRelativeLocationType
    {
        [JsonProperty("x")]
        public int X { get; set; }

        [JsonProperty("y")]
        public int Y { get; set; }
    }

    public class ImagesResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("tenantId")]
        public string TenantId { get; set; }

        [JsonProperty("originalUrl")]
        public string OriginalUrl { get; set; }

        [JsonProperty("thumbnailUrl")]
        public string ThumbnailUrl { get; set; }
    }

    public class SearchCoworkersResponseItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("officeLocation")]
        public string OfficeLocation { get; set; }

        [JsonProperty("businessPhones")]
        public string BusinessPhones { get; set; }

        [JsonProperty("mobilePhone")]
        public string MobilePhone { get; set; }
    }

    public class GetOfficeLocationsByImageResponse
    {
        [JsonProperty("image")]
        public GetOfficeLocationsByImageResponseImageType Image { get; set; }

        [JsonProperty("attachedOfficeLocations")]
        public GetOfficeLocationsByImageResponseAttachedOfficeLocationsTypeItem[] AttachedOfficeLocations { get; set; }
    }

    public class GetOfficeLocationsByImageResponseImageType
    {
        [JsonProperty("imageName")]
        public string ImageName { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("tenantId")]
        public string TenantId { get; set; }

        [JsonProperty("originalUrl")]
        public string OriginalUrl { get; set; }

        [JsonProperty("thumbnailUrl")]
        public string ThumbnailUrl { get; set; }
    }

    public class GetOfficeLocationsByImageResponseAttachedOfficeLocationsTypeItem
    {
        [JsonProperty("personsInOfficeLocation")]
        public string PersonsInOfficeLocation { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("location")]
        public GetOfficeLocationsByImageResponseAttachedOfficeLocationsTypeItemLocationType Location { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("tenantId")]
        public string TenantId { get; set; }
    }

    public class GetOfficeLocationsByImageResponseAttachedOfficeLocationsTypeItemLocationType
    {
        [JsonProperty("image")]
        public GetOfficeLocationsByImageResponseAttachedOfficeLocationsTypeItemLocationTypeImageType Image { get; set; }

        [JsonProperty("relativeLocation")]
        public GetOfficeLocationsByImageResponseAttachedOfficeLocationsTypeItemLocationTypeRelativeLocationType RelativeLocation { get; set; }
    }

    public class GetOfficeLocationsByImageResponseAttachedOfficeLocationsTypeItemLocationTypeImageType
    {
        [JsonProperty("imageName")]
        public string ImageName { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("originalUrl")]
        public string OriginalUrl { get; set; }

        [JsonProperty("thumbnailUrl")]
        public string ThumbnailUrl { get; set; }
    }

    public class GetOfficeLocationsByImageResponseAttachedOfficeLocationsTypeItemLocationTypeRelativeLocationType
    {
        [JsonProperty("x")]
        public int X { get; set; }

        [JsonProperty("y")]
        public int Y { get; set; }
    }

    public class GetRoomWithPersonsDetailsResponse
    {
        [JsonProperty("officeLocationMap")]
        public GetRoomWithPersonsDetailsResponseOfficeLocationMapType OfficeLocationMap { get; set; }

        [JsonProperty("mapImage")]
        public GetRoomWithPersonsDetailsResponseMapImageType MapImage { get; set; }
    }

    public class GetRoomWithPersonsDetailsResponseOfficeLocationMapType
    {
        [JsonProperty("n")]
        public string N { get; set; }

        [JsonProperty("in")]
        public string In { get; set; }

        [JsonProperty("iu")]
        public string Iu { get; set; }

        [JsonProperty("tu")]
        public string Tu { get; set; }

        [JsonProperty("it")]
        public string It { get; set; }

        [JsonProperty("p")]
        public GetRoomWithPersonsDetailsResponseOfficeLocationMapTypePTypeItem[] P { get; set; }

        [JsonProperty("l")]
        public GetRoomWithPersonsDetailsResponseOfficeLocationMapTypeLType L { get; set; }
    }

    public class GetRoomWithPersonsDetailsResponseOfficeLocationMapTypePTypeItem
    {
        [JsonProperty("d")]
        public string D { get; set; }

        [JsonProperty("m")]
        public string M { get; set; }

        [JsonProperty("businessPhone")]
        public string BusinessPhone { get; set; }

        [JsonProperty("mobilePhone")]
        public string MobilePhone { get; set; }
    }

    public class GetRoomWithPersonsDetailsResponseOfficeLocationMapTypeLType
    {
        [JsonProperty("x")]
        public int X { get; set; }

        [JsonProperty("y")]
        public int Y { get; set; }
    }

    public class GetRoomWithPersonsDetailsResponseMapImageType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("ownerId")]
        public string OwnerId { get; set; }

        [JsonProperty("tenantId")]
        public string TenantId { get; set; }

        [JsonProperty("originalUrl")]
        public string OriginalUrl { get; set; }

        [JsonProperty("thumbnailUrl")]
        public string ThumbnailUrl { get; set; }
    }

    public class AADMeetingRoomCollection
    {
        [JsonProperty("rooms")]
        public AADMeetingRoom[] Rooms { get; set; }
    }

    public class AADMeetingRoom
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }
    }

    public class GetRoomsByImageNameResponse
    {
        [JsonProperty("meetingRoomCollection")]
        public GetRoomsByImageNameResponseMeetingRoomCollectionType MeetingRoomCollection { get; set; }

        [JsonProperty("mapImage")]
        public GetRoomsByImageNameResponseMapImageType MapImage { get; set; }
    }

    public class GetRoomsByImageNameResponseMeetingRoomCollectionType
    {
        [JsonProperty("rooms")]
        public GetRoomsByImageNameResponseMeetingRoomCollectionTypeRoomsTypeItem[] Rooms { get; set; }
    }

    public class GetRoomsByImageNameResponseMeetingRoomCollectionTypeRoomsTypeItem
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("location")]
        public GetRoomsByImageNameResponseMeetingRoomCollectionTypeRoomsTypeItemLocationType Location { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("tenantId")]
        public string TenantId { get; set; }
    }

    public class GetRoomsByImageNameResponseMeetingRoomCollectionTypeRoomsTypeItemLocationType
    {
        [JsonProperty("image")]
        public GetRoomsByImageNameResponseMeetingRoomCollectionTypeRoomsTypeItemLocationTypeImageType Image { get; set; }

        [JsonProperty("relativeLocation")]
        public GetRoomsByImageNameResponseMeetingRoomCollectionTypeRoomsTypeItemLocationTypeRelativeLocationType RelativeLocation { get; set; }
    }

    public class GetRoomsByImageNameResponseMeetingRoomCollectionTypeRoomsTypeItemLocationTypeImageType
    {
        [JsonProperty("imageName")]
        public string ImageName { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("originalUrl")]
        public string OriginalUrl { get; set; }

        [JsonProperty("thumbnailUrl")]
        public string ThumbnailUrl { get; set; }
    }

    public class GetRoomsByImageNameResponseMeetingRoomCollectionTypeRoomsTypeItemLocationTypeRelativeLocationType
    {
        [JsonProperty("x")]
        public int X { get; set; }

        [JsonProperty("y")]
        public int Y { get; set; }
    }

    public class GetRoomsByImageNameResponseMapImageType
    {
        [JsonProperty("imageName")]
        public string ImageName { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("thumbnailUrl")]
        public string ThumbnailUrl { get; set; }

        [JsonProperty("originalUrl")]
        public string OriginalUrl { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Meetingroommap;

    public partial class WorkflowManagedActions
    {
        public MeetingroommapActions Meetingroommap(string connectionId) => new MeetingroommapActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MeetingroommapTriggers Meetingroommap(string connectionId) => new MeetingroommapTriggers(connectionId);
    }
}