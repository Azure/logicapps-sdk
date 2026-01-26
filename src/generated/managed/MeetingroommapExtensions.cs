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
        public IWorkflowAction GetCustomLocations(Expression<Func<string[]>> bodycategories = null)
        {
            var apiCallPath = "/api/CustomLocations/GetCustomLocations";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodycategories != null)
            {
                body["categories"] = ExpressionConverter.ConvertO(bodycategories);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meetingroommap")]
        public IBodyWorkflowAction<GetCustomLocationsByImageNameResponse> GetCustomLocationsByImageName(Expression<Func<string>> bodyimageName, Expression<Func<string[]>> bodycategories = null)
        {
            var apiCallPath = "/api/CustomLocations/GetCustomLocationsByImageName";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["imageName"] = ExpressionConverter.ConvertO(bodyimageName);
            if (bodycategories != null)
            {
                body["categories"] = ExpressionConverter.ConvertO(bodycategories);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<GetCustomLocationsByImageNameResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meetingroommap")]
        public IBodyWorkflowAction<string[]> GetCategories()
        {
            var apiCallPath = "/api/CustomLocations/categories";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meetingroommap")]
        public IWorkflowAction LocationDetails(Expression<Func<string>> locationId)
        {
            var apiCallPath = String.Format("/api/CustomLocations/{0}", ExpressionConverter.ConvertWithUrlEncoding(locationId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meetingroommap")]
        public IBodyWorkflowAction<SearchLocationsResponseItem[]> SearchLocations(Expression<Func<string>> locationName, Expression<Func<string>> category = null)
        {
            var apiCallPath = String.Format("/api/CustomLocations/findbyname/{0}", ExpressionConverter.ConvertWithUrlEncoding(locationName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (category != null)
                callPayload.Queries["Category"] = ExpressionConverter.Convert(category);
            return new ApiConnectionAction<SearchLocationsResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meetingroommap")]
        public IBodyWorkflowAction<string> GetCustomLocationImage(Expression<Func<string>> locationId, Expression<Func<bool>> large = null)
        {
            var apiCallPath = String.Format("/api/CustomLocations/createimage/{0}", ExpressionConverter.ConvertWithUrlEncoding(locationId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (large != null)
                callPayload.Queries["Large"] = ExpressionConverter.Convert(large);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meetingroommap")]
        public IBodyWorkflowAction<ImagesResponseItem[]> Images()
        {
            var apiCallPath = "/api/MapImage/thumbnails";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ImagesResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meetingroommap")]
        public IBodyWorkflowAction<string> GetMeetingRoomImage(Expression<Func<string>> roomName, Expression<Func<bool>> large = null)
        {
            var apiCallPath = String.Format("/api/MapImage/create/{0}", ExpressionConverter.ConvertWithUrlEncoding(roomName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (large != null)
                callPayload.Queries["Large"] = ExpressionConverter.Convert(large);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meetingroommap")]
        public IWorkflowAction NextMeetings(Expression<Func<int>> meetingCount)
        {
            var apiCallPath = String.Format("/api/MapImage/meetings/{0}/roomdetails", ExpressionConverter.ConvertWithUrlEncoding(meetingCount, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meetingroommap")]
        public IWorkflowAction GetMeetingRoomDetails(Expression<Func<string>> roomName)
        {
            var apiCallPath = String.Format("/api/MapImage/roomdetails_v2/{0}", ExpressionConverter.ConvertWithUrlEncoding(roomName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meetingroommap")]
        public IWorkflowAction GetOfficeLocations()
        {
            var apiCallPath = "/api/officelocations";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meetingroommap")]
        public IBodyWorkflowAction<SearchCoworkersResponseItem[]> SearchCoworkers(Expression<Func<string>> personSearch)
        {
            var apiCallPath = String.Format("/api/officelocations/searchCoworkers/{0}", ExpressionConverter.ConvertWithUrlEncoding(personSearch, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<SearchCoworkersResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meetingroommap")]
        public IBodyWorkflowAction<GetOfficeLocationsByImageResponse> GetOfficeLocationsByImage(Expression<Func<string>> imageName)
        {
            var apiCallPath = String.Format("/api/officelocations/bymapimage/{0}", ExpressionConverter.ConvertWithUrlEncoding(imageName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetOfficeLocationsByImageResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meetingroommap")]
        public IBodyWorkflowAction<GetRoomWithPersonsDetailsResponse> GetRoomWithPersonsDetails(Expression<Func<string>> officeLocationName, Expression<Func<bool>> inludeUserInfo = null)
        {
            var apiCallPath = String.Format("/api/officelocations/mapimagewithpersoninfo/{0}", ExpressionConverter.ConvertWithUrlEncoding(officeLocationName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["InludeUserInfo"] = Convert.ToString(true);
            if (inludeUserInfo != null)
                callPayload.Queries["InludeUserInfo"] = ExpressionConverter.Convert(inludeUserInfo);
            return new ApiConnectionAction<GetRoomWithPersonsDetailsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meetingroommap")]
        public IBodyWorkflowAction<string> GetOfficeLocationImage(Expression<Func<string>> officeLocationName, Expression<Func<bool>> large = null)
        {
            var apiCallPath = String.Format("/api/officelocationimage/create/{0}", ExpressionConverter.ConvertWithUrlEncoding(officeLocationName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (large != null)
                callPayload.Queries["Large"] = ExpressionConverter.Convert(large);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meetingroommap")]
        public IBodyWorkflowAction<AADMeetingRoomCollection> GetRooms()
        {
            var apiCallPath = "/api/rooms";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<AADMeetingRoomCollection>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meetingroommap")]
        public IBodyWorkflowAction<AADMeetingRoomCollection> SearchMeetingRooms(Expression<Func<string>> name)
        {
            var apiCallPath = String.Format("/api/rooms/findbyname/{0}", ExpressionConverter.ConvertWithUrlEncoding(name, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<AADMeetingRoomCollection>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meetingroommap")]
        public IBodyWorkflowAction<AADMeetingRoomCollection> RoomLists()
        {
            var apiCallPath = "/api/rooms/lists";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<AADMeetingRoomCollection>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meetingroommap")]
        public IBodyWorkflowAction<AADMeetingRoomCollection> RoomsByListAddress(Expression<Func<string>> meetingRoomListAddress)
        {
            var apiCallPath = String.Format("/api/rooms/{0}", ExpressionConverter.ConvertWithUrlEncoding(meetingRoomListAddress, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<AADMeetingRoomCollection>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meetingroommap")]
        public IBodyWorkflowAction<GetRoomsByImageNameResponse> GetRoomsByImageName(Expression<Func<string>> imageName)
        {
            var apiCallPath = String.Format("/api/rooms/GetRoomsByImageName/{0}", ExpressionConverter.ConvertWithUrlEncoding(imageName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetRoomsByImageNameResponse>(callPayload);
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