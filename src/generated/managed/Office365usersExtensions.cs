//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Office365users
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Office365usersActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365users")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateMyProfile))]
        public IWorkflowAction UpdateMyProfile([WorkflowExpression] Func<string> bodyaboutMe = null, [WorkflowExpression] Func<string> bodybirthday = null, [WorkflowExpression] Func<string[]> bodyinterests = null, [WorkflowExpression] Func<string> bodymySite = null, [WorkflowExpression] Func<string[]> bodypastProjects = null, [WorkflowExpression] Func<string[]> bodyschools = null, [WorkflowExpression] Func<string[]> bodyskills = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365users")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildUpdateMyProfile(WorkflowExpression<string> bodyaboutMe = null, WorkflowExpression<string> bodybirthday = null, WorkflowExpression<string[]> bodyinterests = null, WorkflowExpression<string> bodymySite = null, WorkflowExpression<string[]> bodypastProjects = null, WorkflowExpression<string[]> bodyschools = null, WorkflowExpression<string[]> bodyskills = null)
        {
            WorkflowExpression.Validate(bodyaboutMe, nameof(bodyaboutMe), required: false);
            WorkflowExpression.Validate(bodybirthday, nameof(bodybirthday), required: false);
            WorkflowExpression.Validate(bodyinterests, nameof(bodyinterests), required: false);
            WorkflowExpression.Validate(bodymySite, nameof(bodymySite), required: false);
            WorkflowExpression.Validate(bodypastProjects, nameof(bodypastProjects), required: false);
            WorkflowExpression.Validate(bodyschools, nameof(bodyschools), required: false);
            WorkflowExpression.Validate(bodyskills, nameof(bodyskills), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/codeless/v1.0/me";
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyaboutMe != null)
                {
                    body["aboutMe"] = ExpressionConverter.ConvertO(bodyaboutMe);
                    bodypropCount++;
                }

                if (bodybirthday != null)
                {
                    body["birthday"] = ExpressionConverter.ConvertO(bodybirthday);
                    bodypropCount++;
                }

                if (bodyinterests != null)
                {
                    body["interests"] = ExpressionConverter.ConvertO(bodyinterests);
                    bodypropCount++;
                }

                if (bodymySite != null)
                {
                    body["mySite"] = ExpressionConverter.ConvertO(bodymySite);
                    bodypropCount++;
                }

                if (bodypastProjects != null)
                {
                    body["pastProjects"] = ExpressionConverter.ConvertO(bodypastProjects);
                    bodypropCount++;
                }

                if (bodyschools != null)
                {
                    body["schools"] = ExpressionConverter.ConvertO(bodyschools);
                    bodypropCount++;
                }

                if (bodyskills != null)
                {
                    body["skills"] = ExpressionConverter.ConvertO(bodyskills);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365users")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateMyPhoto))]
        public IWorkflowAction UpdateMyPhoto([WorkflowExpression] Func<string> contentType, [WorkflowExpression] Func<string> body = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365users")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildUpdateMyPhoto(WorkflowExpression<string> contentType, WorkflowExpression<string> body = null)
        {
            WorkflowExpression.Validate(contentType, nameof(contentType), required: true);
            WorkflowExpression.Validate(body, nameof(body), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/codeless/v1.0/me/photo/$value";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365users")]
        [WorkflowExpressionFactory(nameof(__BuildMyTrendingDocuments))]
        public IBodyWorkflowAction<MyTrendingDocumentsResponse> MyTrendingDocuments([WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<bool> extractSensitivityLabel = null, [WorkflowExpression] Func<bool> fetchSensitivityLabelMetadata = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365users")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MyTrendingDocumentsResponse> __BuildMyTrendingDocuments(WorkflowExpression<string> filter = null, WorkflowExpression<bool> extractSensitivityLabel = null, WorkflowExpression<bool> fetchSensitivityLabelMetadata = null)
        {
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(extractSensitivityLabel, nameof(extractSensitivityLabel), required: false);
            WorkflowExpression.Validate(fetchSensitivityLabelMetadata, nameof(fetchSensitivityLabelMetadata), required: false);
            return new DeferredBodyAction<MyTrendingDocumentsResponse>(() =>
            {
                var apiCallPath = "/codeless/beta/me/insights/trending";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
                if (extractSensitivityLabel != null)
                    callPayload.Queries["extractSensitivityLabel"] = ExpressionConverter.Convert(extractSensitivityLabel);
                if (fetchSensitivityLabelMetadata != null)
                    callPayload.Queries["fetchSensitivityLabelMetadata"] = ExpressionConverter.Convert(fetchSensitivityLabelMetadata);
                return new ApiConnectionAction<MyTrendingDocumentsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365users")]
        [WorkflowExpressionFactory(nameof(__BuildRelevantPeople))]
        public IBodyWorkflowAction<LinklessEntityListResponseListPerson> RelevantPeople([WorkflowExpression] Func<string> userId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365users")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<LinklessEntityListResponseListPerson> __BuildRelevantPeople(WorkflowExpression<string> userId)
        {
            WorkflowExpression.Validate(userId, nameof(userId), required: true);
            return new DeferredBodyAction<LinklessEntityListResponseListPerson>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/users/{0}/relevantpeople", ExpressionConverter.ConvertWithUrlEncoding(userId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<LinklessEntityListResponseListPerson>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365users")]
        [WorkflowExpressionFactory(nameof(__BuildUserPhotoMetadata))]
        public IBodyWorkflowAction<ClientPhotoMetadata> UserPhotoMetadata([WorkflowExpression] Func<string> userId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365users")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ClientPhotoMetadata> __BuildUserPhotoMetadata(WorkflowExpression<string> userId)
        {
            WorkflowExpression.Validate(userId, nameof(userId), required: true);
            return new DeferredBodyAction<ClientPhotoMetadata>(() =>
            {
                var apiCallPath = "/users/photo";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["userId"] = ExpressionConverter.Convert(userId);
                return new ApiConnectionAction<ClientPhotoMetadata>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365users")]
        [WorkflowExpressionFactory(nameof(__BuildTrendingDocuments))]
        public IBodyWorkflowAction<TrendingDocumentsResponse> TrendingDocuments([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<bool> extractSensitivityLabel = null, [WorkflowExpression] Func<bool> fetchSensitivityLabelMetadata = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365users")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TrendingDocumentsResponse> __BuildTrendingDocuments(WorkflowExpression<string> id, WorkflowExpression<string> filter = null, WorkflowExpression<bool> extractSensitivityLabel = null, WorkflowExpression<bool> fetchSensitivityLabelMetadata = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(extractSensitivityLabel, nameof(extractSensitivityLabel), required: false);
            WorkflowExpression.Validate(fetchSensitivityLabelMetadata, nameof(fetchSensitivityLabelMetadata), required: false);
            return new DeferredBodyAction<TrendingDocumentsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/codeless/beta/users/{0}/insights/trending", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
                if (extractSensitivityLabel != null)
                    callPayload.Queries["extractSensitivityLabel"] = ExpressionConverter.Convert(extractSensitivityLabel);
                if (fetchSensitivityLabelMetadata != null)
                    callPayload.Queries["fetchSensitivityLabelMetadata"] = ExpressionConverter.Convert(fetchSensitivityLabelMetadata);
                return new ApiConnectionAction<TrendingDocumentsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365users")]
        [WorkflowExpressionFactory(nameof(__BuildHttpRequest))]
        public IBodyWorkflowAction<JToken> HttpRequest([WorkflowExpression] Func<string> uri, [WorkflowExpression] Func<methodInput> method, [WorkflowExpression] Func<string> body = null, [WorkflowExpression] Func<string> contentType = null, [WorkflowExpression] Func<string> customHeader1 = null, [WorkflowExpression] Func<string> customHeader2 = null, [WorkflowExpression] Func<string> customHeader3 = null, [WorkflowExpression] Func<string> customHeader4 = null, [WorkflowExpression] Func<string> customHeader5 = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365users")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildHttpRequest(WorkflowExpression<string> uri, WorkflowExpression<methodInput> method, WorkflowExpression<string> body = null, WorkflowExpression<string> contentType = null, WorkflowExpression<string> customHeader1 = null, WorkflowExpression<string> customHeader2 = null, WorkflowExpression<string> customHeader3 = null, WorkflowExpression<string> customHeader4 = null, WorkflowExpression<string> customHeader5 = null)
        {
            WorkflowExpression.Validate(uri, nameof(uri), required: true);
            WorkflowExpression.Validate(method, nameof(method), required: true);
            WorkflowExpression.Validate(body, nameof(body), required: false);
            WorkflowExpression.Validate(contentType, nameof(contentType), required: false);
            WorkflowExpression.Validate(customHeader1, nameof(customHeader1), required: false);
            WorkflowExpression.Validate(customHeader2, nameof(customHeader2), required: false);
            WorkflowExpression.Validate(customHeader3, nameof(customHeader3), required: false);
            WorkflowExpression.Validate(customHeader4, nameof(customHeader4), required: false);
            WorkflowExpression.Validate(customHeader5, nameof(customHeader5), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/codeless/httprequest";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Uri"] = ExpressionConverter.Convert(uri);
                callPayload.Headers["Method"] = ExpressionConverter.Convert(method);
                callPayload.Headers["ContentType"] = Convert.ToString("application/json");
                if (contentType != null)
                    callPayload.Headers["ContentType"] = ExpressionConverter.Convert(contentType);
                if (customHeader1 != null)
                    callPayload.Headers["CustomHeader1"] = ExpressionConverter.Convert(customHeader1);
                if (customHeader2 != null)
                    callPayload.Headers["CustomHeader2"] = ExpressionConverter.Convert(customHeader2);
                if (customHeader3 != null)
                    callPayload.Headers["CustomHeader3"] = ExpressionConverter.Convert(customHeader3);
                if (customHeader4 != null)
                    callPayload.Headers["CustomHeader4"] = ExpressionConverter.Convert(customHeader4);
                if (customHeader5 != null)
                    callPayload.Headers["CustomHeader5"] = ExpressionConverter.Convert(customHeader5);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365users")]
        [WorkflowExpressionFactory(nameof(__BuildDirectReports))]
        public IBodyWorkflowAction<DirectReportsV2Response> DirectReports([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<int> top = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365users")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DirectReportsV2Response> __BuildDirectReports(WorkflowExpression<string> id, WorkflowExpression<string> select = null, WorkflowExpression<int> top = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            WorkflowExpression.Validate(top, nameof(top), required: false);
            return new DeferredBodyAction<DirectReportsV2Response>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/codeless/v1.0/users/{0}/directReports", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
                if (top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
                return new ApiConnectionAction<DirectReportsV2Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365users")]
        [WorkflowExpressionFactory(nameof(__BuildManager))]
        public IBodyWorkflowAction<GraphUserV1> Manager([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> select = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365users")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GraphUserV1> __BuildManager(WorkflowExpression<string> id, WorkflowExpression<string> select = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            return new DeferredBodyAction<GraphUserV1>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/codeless/v1.0/users/{0}/manager", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
                return new ApiConnectionAction<GraphUserV1>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365users")]
        [WorkflowExpressionFactory(nameof(__BuildMyProfile))]
        public IBodyWorkflowAction<GraphUserV1> MyProfile([WorkflowExpression] Func<string> select = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365users")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GraphUserV1> __BuildMyProfile(WorkflowExpression<string> select = null)
        {
            WorkflowExpression.Validate(select, nameof(select), required: false);
            return new DeferredBodyAction<GraphUserV1>(() =>
            {
                var apiCallPath = "/codeless/v1.0/me";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
                return new ApiConnectionAction<GraphUserV1>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365users")]
        [WorkflowExpressionFactory(nameof(__BuildSearchUser))]
        public IBodyWorkflowAction<EntityListResponseIReadOnlyListUser> SearchUser([WorkflowExpression] Func<string> searchTerm = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<bool> isSearchTermRequired = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365users")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<EntityListResponseIReadOnlyListUser> __BuildSearchUser(WorkflowExpression<string> searchTerm = null, WorkflowExpression<int> top = null, WorkflowExpression<bool> isSearchTermRequired = null)
        {
            WorkflowExpression.Validate(searchTerm, nameof(searchTerm), required: false);
            WorkflowExpression.Validate(top, nameof(top), required: false);
            WorkflowExpression.Validate(isSearchTermRequired, nameof(isSearchTermRequired), required: false);
            return new DeferredBodyAction<EntityListResponseIReadOnlyListUser>(() =>
            {
                var apiCallPath = "/v2/users";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (searchTerm != null)
                    callPayload.Queries["searchTerm"] = ExpressionConverter.Convert(searchTerm);
                if (top != null)
                    callPayload.Queries["top"] = ExpressionConverter.Convert(top);
                callPayload.Queries["isSearchTermRequired"] = Convert.ToString(true);
                if (isSearchTermRequired != null)
                    callPayload.Queries["isSearchTermRequired"] = ExpressionConverter.Convert(isSearchTermRequired);
                return new ApiConnectionAction<EntityListResponseIReadOnlyListUser>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365users")]
        [WorkflowExpressionFactory(nameof(__BuildUserPhoto))]
        public IBodyWorkflowAction<string> UserPhoto([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365users")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildUserPhoto(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/codeless/v1.0/users/{0}/photo/$value", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365users")]
        [WorkflowExpressionFactory(nameof(__BuildUserProfile))]
        public IBodyWorkflowAction<GraphUserV1> UserProfile([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> select = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365users")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GraphUserV1> __BuildUserProfile(WorkflowExpression<string> id, WorkflowExpression<string> select = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            return new DeferredBodyAction<GraphUserV1>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/codeless/v1.0/users/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
                return new ApiConnectionAction<GraphUserV1>(callPayload);
            });
        }
    }

    public class Office365usersTriggers([ConnectionName] string connectionId)
    {
    }

    public class MyTrendingDocumentsResponse
    {
        [JsonProperty("value")]
        public GraphTrending[] Value { get; set; }
    }

    public class GraphTrending
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("weight")]
        public double Weight { get; set; }

        [JsonProperty("resourceVisualization")]
        public ResourceVisualization ResourceVisualization { get; set; }

        [JsonProperty("sensitivityLabelInfo")]
        public SensitivityLabelMetadata[] SensitivityLabelInfo { get; set; }
    }

    public class ResourceVisualization
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("mediaType")]
        public string MediaType { get; set; }

        [JsonProperty("previewImageUrl")]
        public string PreviewImageURL { get; set; }

        [JsonProperty("previewText")]
        public string PreviewText { get; set; }

        [JsonProperty("containerWebUrl")]
        public string ContainerWebURL { get; set; }

        [JsonProperty("containerDisplayName")]
        public string ContainerDisplayName { get; set; }

        [JsonProperty("containerType")]
        public string ContainerType { get; set; }
    }

    public class SensitivityLabelMetadata
    {
        [JsonProperty("sensitivityLabelId")]
        public string SensitivityLabelId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("displayName")]
        public string SensitivityLabelDisplayNameInfo { get; set; }

        [JsonProperty("tooltip")]
        public string TooltipInfo { get; set; }

        [JsonProperty("priority")]
        public int PriorityOfSensitivityLabel { get; set; }

        [JsonProperty("color")]
        public string ColorToBeDisplayedForSensitivityLabel { get; set; }

        [JsonProperty("isEncrypted")]
        public bool IsEncryptedStatusOfSensitivityLabel { get; set; }

        [JsonProperty("isEnabled")]
        public bool WhetherSensitivityLabelIsEnabled { get; set; }

        [JsonProperty("isParent")]
        public bool WhetherSensitivityLabelIsParent { get; set; }

        [JsonProperty("parentSensitivityLabelId")]
        public string ParentSensitivityLabelId { get; set; }
    }

    public class LinklessEntityListResponseListPerson
    {
        [JsonProperty("value")]
        public Person[] Value { get; set; }
    }

    public class Person
    {
        [JsonProperty("id")]
        public string PersonId { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("givenName")]
        public string GivenName { get; set; }

        [JsonProperty("surname")]
        public string Surname { get; set; }

        [JsonProperty("birthday")]
        public string Birthday { get; set; }

        [JsonProperty("personNotes")]
        public string PersonNotes { get; set; }

        [JsonProperty("isFavorite")]
        public bool IsFavorite { get; set; }

        [JsonProperty("jobTitle")]
        public string JobTitle { get; set; }

        [JsonProperty("companyName")]
        public string CompanyName { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("officeLocation")]
        public string OfficeLocation { get; set; }

        [JsonProperty("profession")]
        public string Profession { get; set; }

        [JsonProperty("userPrincipalName")]
        public string UserPrincipalNameUPN { get; set; }

        [JsonProperty("imAddress")]
        public string IMAddress { get; set; }

        [JsonProperty("scoredEmailAddresses")]
        public ScoredEmailAddress[] ScoredEmailAddresses { get; set; }

        [JsonProperty("phones")]
        public Phone[] Phones { get; set; }
    }

    public class ScoredEmailAddress
    {
        [JsonProperty("address")]
        public string EmailAddress { get; set; }

        [JsonProperty("relevanceScore")]
        public double RelevanceScore { get; set; }
    }

    public class Phone
    {
        [JsonProperty("number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("type")]
        public string PhoneType { get; set; }
    }

    public class ClientPhotoMetadata
    {
        public bool HasPhoto { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public string ContentType { get; set; }
        public string ImageFileExtension { get; set; }
    }

    public class TrendingDocumentsResponse
    {
        [JsonProperty("value")]
        public GraphTrending[] Value { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum methodInput
    {
        GET,
        POST,
        PUT,
        PATCH,
        DELETE
    }

    public class DirectReportsV2Response
    {
        [JsonProperty("value")]
        public GraphUserV1[] Value { get; set; }
    }

    public class GraphUserV1
    {
        [JsonProperty("aboutMe")]
        public string AboutMe { get; set; }

        [JsonProperty("accountEnabled")]
        public bool AccountEnabled { get; set; }

        [JsonProperty("birthday")]
        public string Birthday { get; set; }

        [JsonProperty("businessPhones")]
        public string[] BusinessPhones { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("companyName")]
        public string CompanyName { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("givenName")]
        public string GivenName { get; set; }

        [JsonProperty("hireDate")]
        public string HireDate { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("interests")]
        public string[] Interests { get; set; }

        [JsonProperty("jobTitle")]
        public string JobTitle { get; set; }

        [JsonProperty("mail")]
        public string Mail { get; set; }

        [JsonProperty("mailNickname")]
        public string Nickname { get; set; }

        [JsonProperty("mobilePhone")]
        public string MobilePhone { get; set; }

        [JsonProperty("mySite")]
        public string MySite { get; set; }

        [JsonProperty("officeLocation")]
        public string OfficeLocation { get; set; }

        [JsonProperty("pastProjects")]
        public string[] PastProjects { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("preferredLanguage")]
        public string PreferredLanguage { get; set; }

        [JsonProperty("preferredName")]
        public string PreferredName { get; set; }

        [JsonProperty("responsibilities")]
        public string[] Responsibilities { get; set; }

        [JsonProperty("schools")]
        public string[] Schools { get; set; }

        [JsonProperty("skills")]
        public string[] Skills { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("streetAddress")]
        public string StreetAddress { get; set; }

        [JsonProperty("surname")]
        public string Surname { get; set; }

        [JsonProperty("userPrincipalName")]
        public string UserPrincipalName { get; set; }

        [JsonProperty("userType")]
        public string UserType { get; set; }
    }

    public class EntityListResponseIReadOnlyListUser
    {
        [JsonProperty("value")]
        public User[] Value { get; set; }

        [JsonProperty("@odata.nextLink")]
        public string NextLink { get; set; }
    }

    public class User
    {
        [JsonProperty("Id")]
        public string UserId { get; set; }
        public bool AccountEnabled { get; set; }
        public string[] BusinessPhones { get; set; }
        public string City { get; set; }
        public string CompanyName { get; set; }
        public string Country { get; set; }
        public string Department { get; set; }
        public string DisplayName { get; set; }
        public string GivenName { get; set; }
        public string JobTitle { get; set; }

        [JsonProperty("Mail")]
        public string Email { get; set; }

        [JsonProperty("MailNickname")]
        public string Nickname { get; set; }

        [JsonProperty("mobilePhone")]
        public string MobilePhone { get; set; }
        public string OfficeLocation { get; set; }
        public string PostalCode { get; set; }
        public string Surname { get; set; }
        public string TelephoneNumber { get; set; }

        [JsonProperty("UserPrincipalName")]
        public string UserPrincipalNameUPN { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Office365users;

    public partial class WorkflowManagedActions
    {
        public Office365usersActions Office365users(string connectionId) => new Office365usersActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Office365usersTriggers Office365users(string connectionId) => new Office365usersTriggers(connectionId);
    }
}