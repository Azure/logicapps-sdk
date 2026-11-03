//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Meetingroommap
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MeetingroommapActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meetingroommap")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetCustomLocations(Expression<Func<string[]>> bodycategories = null)
        {
            var __workflow_bodycategories = WorkflowExpression.Compile(bodycategories, nameof(bodycategories), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/CustomLocations/GetCustomLocations";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodycategories != null)
                {
                    body["categories"] = ExpressionConverter.ConvertO(__workflow_bodycategories);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meetingroommap")]
        public IBodyWorkflowAction<GetCustomLocationsByImageNameResponse, ApiConnectionActionConfiguration> GetCustomLocationsByImageName(Expression<Func<string>> bodyimageName, Expression<Func<string[]>> bodycategories = null)
        {
            var __workflow_bodyimageName = WorkflowExpression.Compile(bodyimageName, nameof(bodyimageName), required: true);
            var __workflow_bodycategories = WorkflowExpression.Compile(bodycategories, nameof(bodycategories), required: false);
            return new DeferredBodyAction<GetCustomLocationsByImageNameResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/CustomLocations/GetCustomLocationsByImageName";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["imageName"] = ExpressionConverter.ConvertO(__workflow_bodyimageName);
                if (__workflow_bodycategories != null)
                {
                    body["categories"] = ExpressionConverter.ConvertO(__workflow_bodycategories);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GetCustomLocationsByImageNameResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meetingroommap")]
        public IBodyWorkflowAction<string[], ApiConnectionActionConfiguration> GetCategories()
        {
            return new DeferredBodyAction<string[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/CustomLocations/categories";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meetingroommap")]
        public IWorkflowAction<ApiConnectionActionConfiguration> LocationDetails(Expression<Func<string>> locationId)
        {
            var __workflow_locationId = WorkflowExpression.Compile(locationId, nameof(locationId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/CustomLocations/{0}", __workflow_locationId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meetingroommap")]
        public IBodyWorkflowAction<SearchLocationsResponseItem[], ApiConnectionActionConfiguration> SearchLocations(Expression<Func<string>> locationName, Expression<Func<string>> category = null)
        {
            var __workflow_locationName = WorkflowExpression.Compile(locationName, nameof(locationName), required: true);
            var __workflow_category = WorkflowExpression.Compile(category, nameof(category), required: false);
            return new DeferredBodyAction<SearchLocationsResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/CustomLocations/findbyname/{0}", __workflow_locationName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_category != null)
                    callPayload.Queries["Category"] = ExpressionConverter.Convert(__workflow_category);
                return new ApiConnectionAction<SearchLocationsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meetingroommap")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> GetCustomLocationImage(Expression<Func<string>> locationId, Expression<Func<bool>> large = null)
        {
            var __workflow_locationId = WorkflowExpression.Compile(locationId, nameof(locationId), required: true);
            var __workflow_large = WorkflowExpression.Compile(large, nameof(large), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/CustomLocations/createimage/{0}", __workflow_locationId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_large != null)
                    callPayload.Queries["Large"] = ExpressionConverter.Convert(__workflow_large);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meetingroommap")]
        public IBodyWorkflowAction<ImagesResponseItem[], ApiConnectionActionConfiguration> Images()
        {
            return new DeferredBodyAction<ImagesResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/MapImage/thumbnails";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ImagesResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meetingroommap")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> GetMeetingRoomImage(Expression<Func<string>> roomName, Expression<Func<bool>> large = null)
        {
            var __workflow_roomName = WorkflowExpression.Compile(roomName, nameof(roomName), required: true);
            var __workflow_large = WorkflowExpression.Compile(large, nameof(large), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/MapImage/create/{0}", __workflow_roomName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_large != null)
                    callPayload.Queries["Large"] = ExpressionConverter.Convert(__workflow_large);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meetingroommap")]
        public IWorkflowAction<ApiConnectionActionConfiguration> NextMeetings(Expression<Func<int>> meetingCount)
        {
            var __workflow_meetingCount = WorkflowExpression.Compile(meetingCount, nameof(meetingCount), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/MapImage/meetings/{0}/roomdetails", __workflow_meetingCount.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meetingroommap")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetMeetingRoomDetails(Expression<Func<string>> roomName)
        {
            var __workflow_roomName = WorkflowExpression.Compile(roomName, nameof(roomName), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/MapImage/roomdetails_v2/{0}", __workflow_roomName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meetingroommap")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetOfficeLocations()
        {
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/officelocations";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meetingroommap")]
        public IBodyWorkflowAction<SearchCoworkersResponseItem[], ApiConnectionActionConfiguration> SearchCoworkers(Expression<Func<string>> personSearch)
        {
            var __workflow_personSearch = WorkflowExpression.Compile(personSearch, nameof(personSearch), required: true);
            return new DeferredBodyAction<SearchCoworkersResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/officelocations/searchCoworkers/{0}", __workflow_personSearch.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SearchCoworkersResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meetingroommap")]
        public IBodyWorkflowAction<GetOfficeLocationsByImageResponse, ApiConnectionActionConfiguration> GetOfficeLocationsByImage(Expression<Func<string>> imageName)
        {
            var __workflow_imageName = WorkflowExpression.Compile(imageName, nameof(imageName), required: true);
            return new DeferredBodyAction<GetOfficeLocationsByImageResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/officelocations/bymapimage/{0}", __workflow_imageName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetOfficeLocationsByImageResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meetingroommap")]
        public IBodyWorkflowAction<GetRoomWithPersonsDetailsResponse, ApiConnectionActionConfiguration> GetRoomWithPersonsDetails(Expression<Func<string>> officeLocationName, Expression<Func<bool>> inludeUserInfo = null)
        {
            var __workflow_officeLocationName = WorkflowExpression.Compile(officeLocationName, nameof(officeLocationName), required: true);
            var __workflow_inludeUserInfo = WorkflowExpression.Compile(inludeUserInfo, nameof(inludeUserInfo), required: false);
            return new DeferredBodyAction<GetRoomWithPersonsDetailsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/officelocations/mapimagewithpersoninfo/{0}", __workflow_officeLocationName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["InludeUserInfo"] = Convert.ToString(true);
                if (__workflow_inludeUserInfo != null)
                    callPayload.Queries["InludeUserInfo"] = ExpressionConverter.Convert(__workflow_inludeUserInfo);
                return new ApiConnectionAction<GetRoomWithPersonsDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meetingroommap")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> GetOfficeLocationImage(Expression<Func<string>> officeLocationName, Expression<Func<bool>> large = null)
        {
            var __workflow_officeLocationName = WorkflowExpression.Compile(officeLocationName, nameof(officeLocationName), required: true);
            var __workflow_large = WorkflowExpression.Compile(large, nameof(large), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/officelocationimage/create/{0}", __workflow_officeLocationName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_large != null)
                    callPayload.Queries["Large"] = ExpressionConverter.Convert(__workflow_large);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meetingroommap")]
        public IBodyWorkflowAction<AADMeetingRoomCollection, ApiConnectionActionConfiguration> GetRooms()
        {
            return new DeferredBodyAction<AADMeetingRoomCollection, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/rooms";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<AADMeetingRoomCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meetingroommap")]
        public IBodyWorkflowAction<AADMeetingRoomCollection, ApiConnectionActionConfiguration> SearchMeetingRooms(Expression<Func<string>> name)
        {
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: true);
            return new DeferredBodyAction<AADMeetingRoomCollection, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/rooms/findbyname/{0}", __workflow_name.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<AADMeetingRoomCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meetingroommap")]
        public IBodyWorkflowAction<AADMeetingRoomCollection, ApiConnectionActionConfiguration> RoomLists()
        {
            return new DeferredBodyAction<AADMeetingRoomCollection, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/rooms/lists";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<AADMeetingRoomCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meetingroommap")]
        public IBodyWorkflowAction<AADMeetingRoomCollection, ApiConnectionActionConfiguration> RoomsByListAddress(Expression<Func<string>> meetingRoomListAddress)
        {
            var __workflow_meetingRoomListAddress = WorkflowExpression.Compile(meetingRoomListAddress, nameof(meetingRoomListAddress), required: true);
            return new DeferredBodyAction<AADMeetingRoomCollection, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/rooms/{0}", __workflow_meetingRoomListAddress.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<AADMeetingRoomCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meetingroommap")]
        public IBodyWorkflowAction<GetRoomsByImageNameResponse, ApiConnectionActionConfiguration> GetRoomsByImageName(Expression<Func<string>> imageName)
        {
            var __workflow_imageName = WorkflowExpression.Compile(imageName, nameof(imageName), required: true);
            return new DeferredBodyAction<GetRoomsByImageNameResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/rooms/GetRoomsByImageName/{0}", __workflow_imageName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetRoomsByImageNameResponse>(callPayload);
            });
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