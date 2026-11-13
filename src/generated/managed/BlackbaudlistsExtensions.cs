//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Blackbaudlists
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BlackbaudlistsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudlists")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AppendIDsToList(Expression<Func<AppendIDsToListBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/list/v1/appendidstolist";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudlists")]
        public IBodyWorkflowAction<ListApiCreatedList, ApiConnectionActionConfiguration> CreateListFromIDs(Expression<Func<CreateListFromIDsBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ListApiCreatedList, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/list/v1/createlistfromids";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ListApiCreatedList>(callPayload);
            });
        }
    }

    public class BlackbaudlistsTriggers([ConnectionName] string connectionId)
    {
    }

    public class AppendIDsToListBodyInput
    {
        public AppendIDsToListBodyInput(BodyInputListTypeType listType, string list, string[] idS)
        {
            this.ListType = listType;
            this.List = list;
            this.IdS = idS;
        }

        [JsonProperty("list_type", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputListTypeType ListType { get; set; }

        [JsonProperty("list_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string List { get; set; }

        [JsonProperty("ids", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] IdS { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputListTypeType
    {
        Constituent,
        Gift,
        Action,
        Opportunity
    }

    public class ListApiCreatedList
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateListFromIDsBodyInput
    {
        public CreateListFromIDsBodyInput(string name, string description, BodyInputListTypeType listType, BodyInputPermissionsType permissions, string[] idS)
        {
            this.Name = name;
            this.Description = description;
            this.ListType = listType;
            this.Permissions = permissions;
            this.IdS = idS;
        }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("description", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Description { get; set; }

        [JsonProperty("list_type", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputListTypeType ListType { get; set; }

        [JsonProperty("list_permissions", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputPermissionsType Permissions { get; set; }

        [JsonProperty("ids", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] IdS { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputPermissionsType
    {
        OnlyOwnerCanAccess,
        OthersCanView,
        OthersCanViewAndEdit
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Blackbaudlists;

    public partial class WorkflowManagedActions
    {
        public BlackbaudlistsActions Blackbaudlists(string connectionId) => new BlackbaudlistsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public BlackbaudlistsTriggers Blackbaudlists(string connectionId) => new BlackbaudlistsTriggers(connectionId);
    }
}