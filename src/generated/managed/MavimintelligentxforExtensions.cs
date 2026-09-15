//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Mavimintelligentxfor
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MavimintelligentxforActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimintelligentxfor")]
        public IBodyWorkflowAction<AuditLog[]> GetTopicAuditTrailLogs(Expression<Func<string>> repositoryId, Expression<Func<string>> topicId, Expression<Func<int>> logId = null, Expression<Func<int>> range = null, Expression<Func<dataLanguageInput>> dataLanguage = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/insights/v2/activities/repositories/{0}/system-logs/topics/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(repositoryId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["logId"] = Convert.ToString(0);
            if (logId != null)
                callPayload.Queries["logId"] = CSharpExpressionConverter.ConvertO(logId);
            callPayload.Queries["range"] = Convert.ToString(0);
            if (range != null)
                callPayload.Queries["range"] = CSharpExpressionConverter.ConvertO(range);
            callPayload.Queries["dataLanguage"] = Convert.ToString("en");
            if (dataLanguage != null)
                callPayload.Queries["dataLanguage"] = CSharpExpressionConverter.Convert(dataLanguage);
            return new ApiConnectionAction<AuditLog[]>(callPayload);
        }
    }

    public class MavimintelligentxforTriggers([ConnectionName] string connectionId)
    {
    }

    public class AuditLog
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("topicId")]
        public string TopicId { get; set; }

        [JsonProperty("language")]
        public AuditLogLanguageType Language { get; set; }

        [JsonProperty("eventType")]
        public string EventType { get; set; }

        [JsonProperty("timeStamp")]
        public string TimeStamp { get; set; }

        [JsonProperty("changedBy")]
        public string ChangedBy { get; set; }

        [JsonProperty("details")]
        public string Details { get; set; }

        [JsonProperty("detailsExtra")]
        public string DetailsExtra { get; set; }

        [JsonProperty("objectType")]
        public string ObjectType { get; set; }

        [JsonProperty("oldValue")]
        public Changes OldValue { get; set; }

        [JsonProperty("newValue")]
        public Changes NewValue { get; set; }

        [JsonProperty("allFromLog")]
        public bool AllFromLog { get; set; }
    }

    public enum AuditLogLanguageType
    {
        Czech,
        Danish,
        German,
        Greek,
        English,
        Spanish,
        Finnish,
        French,
        Hungarian,
        Italian,
        Dutch,
        Norwegian,
        Polish,
        Russian,
        Swedish,
        Turkish,
        Slovenian,
        Portuguese,
        Maori
    }

    public class Changes
    {
        [JsonProperty("parent")]
        public Parent Parent { get; set; }

        [JsonProperty("relationshipDetails")]
        public RelationshipDetails RelationshipDetails { get; set; }

        [JsonProperty("topicName")]
        public string TopicName { get; set; }

        [JsonProperty("topicType")]
        public string TopicType { get; set; }

        [JsonProperty("topicIcon")]
        public string TopicIcon { get; set; }

        [JsonProperty("orderNumber")]
        public string OrderNumber { get; set; }

        [JsonProperty("details")]
        public string Details { get; set; }

        [JsonProperty("detailsExtra")]
        public string DetailsExtra { get; set; }

        [JsonProperty("values")]
        public string[] Values { get; set; }

        [JsonProperty("relationId")]
        public string RelationId { get; set; }

        [JsonProperty("fromTopicId")]
        public string FromTopicId { get; set; }

        [JsonProperty("fromTopicName")]
        public string FromTopicName { get; set; }

        [JsonProperty("toTopicId")]
        public string ToTopicId { get; set; }

        [JsonProperty("toTopicName")]
        public string ToTopicName { get; set; }

        [JsonProperty("relationType")]
        public string RelationType { get; set; }
    }

    public class Parent
    {
        [JsonProperty("topicId")]
        public string TopicId { get; set; }

        [JsonProperty("topicName")]
        public string TopicName { get; set; }
    }

    public class RelationshipDetails
    {
        [JsonProperty("topicId")]
        public string TopicId { get; set; }

        [JsonProperty("topicName")]
        public string TopicName { get; set; }

        [JsonProperty("topicType")]
        public string TopicType { get; set; }

        [JsonProperty("topicIcon")]
        public string TopicIcon { get; set; }

        [JsonProperty("orderNumber")]
        public string OrderNumber { get; set; }
    }

    public enum dataLanguageInput
    {
        [EnumMember(Value = "en")]
        En,
        [EnumMember(Value = "nl")]
        Nl,
        [EnumMember(Value = "de")]
        De,
        [EnumMember(Value = "es")]
        Es
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Mavimintelligentxfor;

    public partial class WorkflowManagedActions
    {
        public MavimintelligentxforActions Mavimintelligentxfor(string connectionId) => new MavimintelligentxforActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MavimintelligentxforTriggers Mavimintelligentxfor(string connectionId) => new MavimintelligentxforTriggers(connectionId);
    }
}