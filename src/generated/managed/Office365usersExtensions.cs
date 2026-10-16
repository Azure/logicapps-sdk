//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Office365users
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Office365usersActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365users")]
        public IWorkflowAction UpdateMyProfile(Expression<Func<string>> bodyaboutMe = null, Expression<Func<string>> bodybirthday = null, Expression<Func<string[]>> bodyinterests = null, Expression<Func<string>> bodymySite = null, Expression<Func<string[]>> bodypastProjects = null, Expression<Func<string[]>> bodyschools = null, Expression<Func<string[]>> bodyskills = null)
        {
            var __workflow_bodyaboutMe = WorkflowExpression.Compile(bodyaboutMe, nameof(bodyaboutMe), required: false);
            var __workflow_bodybirthday = WorkflowExpression.Compile(bodybirthday, nameof(bodybirthday), required: false);
            var __workflow_bodyinterests = WorkflowExpression.Compile(bodyinterests, nameof(bodyinterests), required: false);
            var __workflow_bodymySite = WorkflowExpression.Compile(bodymySite, nameof(bodymySite), required: false);
            var __workflow_bodypastProjects = WorkflowExpression.Compile(bodypastProjects, nameof(bodypastProjects), required: false);
            var __workflow_bodyschools = WorkflowExpression.Compile(bodyschools, nameof(bodyschools), required: false);
            var __workflow_bodyskills = WorkflowExpression.Compile(bodyskills, nameof(bodyskills), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/codeless/v1.0/me";
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyaboutMe != null)
                {
                    body["aboutMe"] = ExpressionConverter.ConvertO(__workflow_bodyaboutMe);
                    bodypropCount++;
                }

                if (__workflow_bodybirthday != null)
                {
                    body["birthday"] = ExpressionConverter.ConvertO(__workflow_bodybirthday);
                    bodypropCount++;
                }

                if (__workflow_bodyinterests != null)
                {
                    body["interests"] = ExpressionConverter.ConvertO(__workflow_bodyinterests);
                    bodypropCount++;
                }

                if (__workflow_bodymySite != null)
                {
                    body["mySite"] = ExpressionConverter.ConvertO(__workflow_bodymySite);
                    bodypropCount++;
                }

                if (__workflow_bodypastProjects != null)
                {
                    body["pastProjects"] = ExpressionConverter.ConvertO(__workflow_bodypastProjects);
                    bodypropCount++;
                }

                if (__workflow_bodyschools != null)
                {
                    body["schools"] = ExpressionConverter.ConvertO(__workflow_bodyschools);
                    bodypropCount++;
                }

                if (__workflow_bodyskills != null)
                {
                    body["skills"] = ExpressionConverter.ConvertO(__workflow_bodyskills);
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
        public IWorkflowAction UpdateMyPhoto(Expression<Func<string>> contentType, Expression<Func<string>> body = null)
        {
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/codeless/v1.0/me/photo/$value";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365users")]
        public IBodyWorkflowAction<MyTrendingDocumentsResponse> MyTrendingDocuments(Expression<Func<string>> filter = null, Expression<Func<bool>> extractSensitivityLabel = null, Expression<Func<bool>> fetchSensitivityLabelMetadata = null)
        {
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_extractSensitivityLabel = WorkflowExpression.Compile(extractSensitivityLabel, nameof(extractSensitivityLabel), required: false);
            var __workflow_fetchSensitivityLabelMetadata = WorkflowExpression.Compile(fetchSensitivityLabelMetadata, nameof(fetchSensitivityLabelMetadata), required: false);
            return new DeferredBodyAction<MyTrendingDocumentsResponse>(() =>
            {
                var apiCallPath = "/codeless/beta/me/insights/trending";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_extractSensitivityLabel != null)
                    callPayload.Queries["extractSensitivityLabel"] = ExpressionConverter.Convert(__workflow_extractSensitivityLabel);
                if (__workflow_fetchSensitivityLabelMetadata != null)
                    callPayload.Queries["fetchSensitivityLabelMetadata"] = ExpressionConverter.Convert(__workflow_fetchSensitivityLabelMetadata);
                return new ApiConnectionAction<MyTrendingDocumentsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365users")]
        public IBodyWorkflowAction<LinklessEntityListResponseListPerson> RelevantPeople(Expression<Func<string>> userId)
        {
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: true);
            return new DeferredBodyAction<LinklessEntityListResponseListPerson>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/users/{0}/relevantpeople", ExpressionConverter.ConvertWithUrlEncoding(__workflow_userId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<LinklessEntityListResponseListPerson>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365users")]
        public IBodyWorkflowAction<ClientPhotoMetadata> UserPhotoMetadata(Expression<Func<string>> userId)
        {
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: true);
            return new DeferredBodyAction<ClientPhotoMetadata>(() =>
            {
                var apiCallPath = "/users/photo";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["userId"] = ExpressionConverter.Convert(__workflow_userId);
                return new ApiConnectionAction<ClientPhotoMetadata>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365users")]
        public IBodyWorkflowAction<TrendingDocumentsResponse> TrendingDocuments(Expression<Func<string>> id, Expression<Func<string>> filter = null, Expression<Func<bool>> extractSensitivityLabel = null, Expression<Func<bool>> fetchSensitivityLabelMetadata = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_extractSensitivityLabel = WorkflowExpression.Compile(extractSensitivityLabel, nameof(extractSensitivityLabel), required: false);
            var __workflow_fetchSensitivityLabelMetadata = WorkflowExpression.Compile(fetchSensitivityLabelMetadata, nameof(fetchSensitivityLabelMetadata), required: false);
            return new DeferredBodyAction<TrendingDocumentsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/codeless/beta/users/{0}/insights/trending", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_extractSensitivityLabel != null)
                    callPayload.Queries["extractSensitivityLabel"] = ExpressionConverter.Convert(__workflow_extractSensitivityLabel);
                if (__workflow_fetchSensitivityLabelMetadata != null)
                    callPayload.Queries["fetchSensitivityLabelMetadata"] = ExpressionConverter.Convert(__workflow_fetchSensitivityLabelMetadata);
                return new ApiConnectionAction<TrendingDocumentsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365users")]
        public IBodyWorkflowAction<JToken> HttpRequest(Expression<Func<string>> uri, Expression<Func<methodInput>> method, Expression<Func<string>> body = null, Expression<Func<string>> contentType = null, Expression<Func<string>> customHeader1 = null, Expression<Func<string>> customHeader2 = null, Expression<Func<string>> customHeader3 = null, Expression<Func<string>> customHeader4 = null, Expression<Func<string>> customHeader5 = null)
        {
            var __workflow_uri = WorkflowExpression.Compile(uri, nameof(uri), required: true);
            var __workflow_method = WorkflowExpression.Compile(method, nameof(method), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: false);
            var __workflow_customHeader1 = WorkflowExpression.Compile(customHeader1, nameof(customHeader1), required: false);
            var __workflow_customHeader2 = WorkflowExpression.Compile(customHeader2, nameof(customHeader2), required: false);
            var __workflow_customHeader3 = WorkflowExpression.Compile(customHeader3, nameof(customHeader3), required: false);
            var __workflow_customHeader4 = WorkflowExpression.Compile(customHeader4, nameof(customHeader4), required: false);
            var __workflow_customHeader5 = WorkflowExpression.Compile(customHeader5, nameof(customHeader5), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/codeless/httprequest";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Uri"] = ExpressionConverter.Convert(__workflow_uri);
                callPayload.Headers["Method"] = ExpressionConverter.Convert(__workflow_method);
                callPayload.Headers["ContentType"] = Convert.ToString("application/json");
                if (__workflow_contentType != null)
                    callPayload.Headers["ContentType"] = ExpressionConverter.Convert(__workflow_contentType);
                if (__workflow_customHeader1 != null)
                    callPayload.Headers["CustomHeader1"] = ExpressionConverter.Convert(__workflow_customHeader1);
                if (__workflow_customHeader2 != null)
                    callPayload.Headers["CustomHeader2"] = ExpressionConverter.Convert(__workflow_customHeader2);
                if (__workflow_customHeader3 != null)
                    callPayload.Headers["CustomHeader3"] = ExpressionConverter.Convert(__workflow_customHeader3);
                if (__workflow_customHeader4 != null)
                    callPayload.Headers["CustomHeader4"] = ExpressionConverter.Convert(__workflow_customHeader4);
                if (__workflow_customHeader5 != null)
                    callPayload.Headers["CustomHeader5"] = ExpressionConverter.Convert(__workflow_customHeader5);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365users")]
        public IBodyWorkflowAction<DirectReportsV2Response> DirectReports(Expression<Func<string>> id, Expression<Func<string>> select = null, Expression<Func<int>> top = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            return new DeferredBodyAction<DirectReportsV2Response>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/codeless/v1.0/users/{0}/directReports", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                return new ApiConnectionAction<DirectReportsV2Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365users")]
        public IBodyWorkflowAction<GraphUserV1> Manager(Expression<Func<string>> id, Expression<Func<string>> select = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            return new DeferredBodyAction<GraphUserV1>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/codeless/v1.0/users/{0}/manager", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                return new ApiConnectionAction<GraphUserV1>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365users")]
        public IBodyWorkflowAction<GraphUserV1> MyProfile(Expression<Func<string>> select = null)
        {
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            return new DeferredBodyAction<GraphUserV1>(() =>
            {
                var apiCallPath = "/codeless/v1.0/me";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                return new ApiConnectionAction<GraphUserV1>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365users")]
        public IBodyWorkflowAction<EntityListResponseIReadOnlyListUser> SearchUser(Expression<Func<string>> searchTerm = null, Expression<Func<int>> top = null, Expression<Func<bool>> isSearchTermRequired = null)
        {
            var __workflow_searchTerm = WorkflowExpression.Compile(searchTerm, nameof(searchTerm), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_isSearchTermRequired = WorkflowExpression.Compile(isSearchTermRequired, nameof(isSearchTermRequired), required: false);
            return new DeferredBodyAction<EntityListResponseIReadOnlyListUser>(() =>
            {
                var apiCallPath = "/v2/users";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_searchTerm != null)
                    callPayload.Queries["searchTerm"] = ExpressionConverter.Convert(__workflow_searchTerm);
                if (__workflow_top != null)
                    callPayload.Queries["top"] = ExpressionConverter.Convert(__workflow_top);
                callPayload.Queries["isSearchTermRequired"] = Convert.ToString(true);
                if (__workflow_isSearchTermRequired != null)
                    callPayload.Queries["isSearchTermRequired"] = ExpressionConverter.Convert(__workflow_isSearchTermRequired);
                return new ApiConnectionAction<EntityListResponseIReadOnlyListUser>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365users")]
        public IBodyWorkflowAction<string> UserPhoto(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/codeless/v1.0/users/{0}/photo/$value", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365users")]
        public IBodyWorkflowAction<GraphUserV1> UserProfile(Expression<Func<string>> id, Expression<Func<string>> select = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            return new DeferredBodyAction<GraphUserV1>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/codeless/v1.0/users/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
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
