//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Profisee
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ProfiseeActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "profisee")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetRecordsByEntityName(Expression<Func<string>> entityName, Expression<Func<string>> attributes = null, Expression<Func<bool>> countsOnly = null, Expression<Func<string>> filter = null, Expression<Func<string>> orderBy = null, Expression<Func<int>> pageNumber = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> recordCodes = null)
        {
            var __workflow_entityName = WorkflowExpression.Compile(entityName, nameof(entityName), required: true);
            var __workflow_attributes = WorkflowExpression.Compile(attributes, nameof(attributes), required: false);
            var __workflow_countsOnly = WorkflowExpression.Compile(countsOnly, nameof(countsOnly), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderBy = WorkflowExpression.Compile(orderBy, nameof(orderBy), required: false);
            var __workflow_pageNumber = WorkflowExpression.Compile(pageNumber, nameof(pageNumber), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_recordCodes = WorkflowExpression.Compile(recordCodes, nameof(recordCodes), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Records/{0}", __workflow_entityName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_attributes != null)
                    callPayload.Queries["Attributes"] = ExpressionConverter.Convert(__workflow_attributes);
                if (__workflow_countsOnly != null)
                    callPayload.Queries["CountsOnly"] = ExpressionConverter.Convert(__workflow_countsOnly);
                if (__workflow_filter != null)
                    callPayload.Queries["Filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_orderBy != null)
                    callPayload.Queries["OrderBy"] = ExpressionConverter.Convert(__workflow_orderBy);
                if (__workflow_pageNumber != null)
                    callPayload.Queries["PageNumber"] = ExpressionConverter.Convert(__workflow_pageNumber);
                if (__workflow_pageSize != null)
                    callPayload.Queries["PageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_recordCodes != null)
                    callPayload.Queries["RecordCodes"] = ExpressionConverter.Convert(__workflow_recordCodes);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "profisee")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CreateRecordsByEntityName(Expression<Func<string>> entityName, Expression<Func<bodyInputItem[]>> body)
        {
            var __workflow_entityName = WorkflowExpression.Compile(entityName, nameof(entityName), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Records/{0}", __workflow_entityName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "profisee")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateRecordsByEntityName(Expression<Func<string>> entityName, Expression<Func<bodyInputItem[]>> body = null)
        {
            var __workflow_entityName = WorkflowExpression.Compile(entityName, nameof(entityName), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Records/{0}", __workflow_entityName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "profisee")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteRecordByEntityNameAndRecordCode(Expression<Func<string>> entityName, Expression<Func<string>> recordCode)
        {
            var __workflow_entityName = WorkflowExpression.Compile(entityName, nameof(entityName), required: true);
            var __workflow_recordCode = WorkflowExpression.Compile(recordCode, nameof(recordCode), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Records/{0}/{1}", __workflow_entityName.WithUrlEncoding(1), __workflow_recordCode.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "profisee")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CreateEntity(Expression<Func<bodyInputItem2[]>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Entities";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "profisee")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CreateAttribute(Expression<Func<bodyInputItem22[]>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Attributes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "profisee")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetEntityMetadata(Expression<Func<string>> entityName)
        {
            var __workflow_entityName = WorkflowExpression.Compile(entityName, nameof(entityName), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Entities/{0}", __workflow_entityName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "profisee")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetAttributesMetadata(Expression<Func<string>> entityName)
        {
            var __workflow_entityName = WorkflowExpression.Compile(entityName, nameof(entityName), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Entities/{0}/attributes", __workflow_entityName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "profisee")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateTheme(Expression<Func<string>> name, Expression<Func<UpdateThemeInput>> body = null)
        {
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Themes/{0}", __workflow_name.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "profisee")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetDataQualityIssuesByEntityName(Expression<Func<string>> entityName, Expression<Func<int>> pageNumber = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> recordCodes = null)
        {
            var __workflow_entityName = WorkflowExpression.Compile(entityName, nameof(entityName), required: true);
            var __workflow_pageNumber = WorkflowExpression.Compile(pageNumber, nameof(pageNumber), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_recordCodes = WorkflowExpression.Compile(recordCodes, nameof(recordCodes), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/DataQualityIssues/{0}", __workflow_entityName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_pageNumber != null)
                    callPayload.Queries["PageNumber"] = ExpressionConverter.Convert(__workflow_pageNumber);
                if (__workflow_pageSize != null)
                    callPayload.Queries["PageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_recordCodes != null)
                    callPayload.Queries["RecordCodes"] = ExpressionConverter.Convert(__workflow_recordCodes);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }
    }

    public class ProfiseeTriggers([ConnectionName] string connectionId)
    {
    }

    public class bodyInputItem
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Attribute1 { get; set; }
        public string Attribute2 { get; set; }
    }

    public class bodyInputItem2
    {
        [JsonProperty("identifier")]
        public bodyInputItemIdentifierType Identifier { get; set; }

        [JsonProperty("longDescription")]
        public string LongDescription { get; set; }

        [JsonProperty("iconName")]
        public string IconName { get; set; }

        [JsonProperty("isCodeGenerationEnabled")]
        public bool IsCodeGenerationEnabled { get; set; }

        [JsonProperty("codeGenerationSeed")]
        public int CodeGenerationSeed { get; set; }

        [JsonProperty("fileCategories")]
        public bodyInputItemFileCategoriesTypeItem[] FileCategories { get; set; }
    }

    public class bodyInputItemIdentifierType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class bodyInputItemFileCategoriesTypeItem
    {
        [JsonProperty("identifier")]
        public bodyInputItemFileCategoriesTypeItemIdentifierType Identifier { get; set; }

        [JsonProperty("extensions")]
        public string Extensions { get; set; }
    }

    public class bodyInputItemFileCategoriesTypeItemIdentifierType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class bodyInputItem22
    {
        public bodyInputItemIdentifierType2 Identifier { get; set; }
        public bodyInputItemAttributeTypeType AttributeType { get; set; }
        public bodyInputItemDataTypeType DataType { get; set; }
        public int DataTypeInformation { get; set; }
        public bool IsUnique { get; set; }
        public bool IsRestricted { get; set; }
        public bool IsIndexed { get; set; }
        public int DisplayWidth { get; set; }
        public string LongDescription { get; set; }
        public bool HasDefault { get; set; }
        public string DefaultValue { get; set; }
        public bool IsCascadeDeleteEnabled { get; set; }
        public bodyInputItemDomainEntityIdType DomainEntityId { get; set; }
    }

    public class bodyInputItemIdentifierType2
    {
        public string Name { get; set; }
        public bodyInputItemIdentifierTypeEntityIdType EntityId { get; set; }
    }

    public class bodyInputItemIdentifierTypeEntityIdType
    {
        public string Name { get; set; }
    }

    public enum bodyInputItemAttributeTypeType
    {
        _1 = 1,
        _2 = 2
    }

    public enum bodyInputItemDataTypeType
    {
        _1 = 1,
        _2 = 2,
        _3 = 3,
        _4 = 4,
        _6 = 6
    }

    public class bodyInputItemDomainEntityIdType
    {
        public string Name { get; set; }
    }

    public class UpdateThemeInput
    {
        [JsonProperty("bannerPrimary")]
        public string BannerPrimary { get; set; }

        [JsonProperty("bannerFi")]
        public string BannerFi { get; set; }

        [JsonProperty("bannerSecondary")]
        public string BannerSecondary { get; set; }

        [JsonProperty("contentPrimaryBg")]
        public string ContentPrimaryBg { get; set; }

        [JsonProperty("contentPrimaryFi")]
        public string ContentPrimaryFi { get; set; }

        [JsonProperty("contentSecondaryBg")]
        public string ContentSecondaryBg { get; set; }

        [JsonProperty("contentSecondaryFi")]
        public string ContentSecondaryFi { get; set; }

        [JsonProperty("accentBg")]
        public string AccentBg { get; set; }

        [JsonProperty("accentFi")]
        public string AccentFi { get; set; }

        [JsonProperty("selectedBg")]
        public string SelectedBg { get; set; }

        [JsonProperty("hyperlink")]
        public string Hyperlink { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Profisee;

    public partial class WorkflowManagedActions
    {
        public ProfiseeActions Profisee(string connectionId) => new ProfiseeActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ProfiseeTriggers Profisee(string connectionId) => new ProfiseeTriggers(connectionId);
    }
}