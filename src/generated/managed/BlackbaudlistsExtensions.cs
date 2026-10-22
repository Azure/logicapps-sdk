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
        public IWorkflowAction<ApiConnectionActionConfiguration> AppendIDsToList(Expression<Func<bodylistTypeInput>> bodylistType, Expression<Func<string>> bodylist, Expression<Func<string[]>> bodyiDS)
        {
            var __workflow_bodylistType = WorkflowExpression.Compile(bodylistType, nameof(bodylistType), required: true);
            var __workflow_bodylist = WorkflowExpression.Compile(bodylist, nameof(bodylist), required: true);
            var __workflow_bodyiDS = WorkflowExpression.Compile(bodyiDS, nameof(bodyiDS), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/list/v1/appendidstolist";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["list_type"] = ExpressionConverter.ConvertO(__workflow_bodylistType);
                bodypropCount++;
                body["list_id"] = ExpressionConverter.ConvertO(__workflow_bodylist);
                bodypropCount++;
                body["ids"] = ExpressionConverter.ConvertO(__workflow_bodyiDS);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudlists")]
        public IBodyWorkflowAction<ListApiCreatedList, ApiConnectionActionConfiguration> CreateListFromIDs(Expression<Func<string>> bodyname, Expression<Func<string>> bodydescription, Expression<Func<bodylistTypeInput>> bodylistType, Expression<Func<bodypermissionsInput>> bodypermissions, Expression<Func<string[]>> bodyiDS)
        {
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: true);
            var __workflow_bodylistType = WorkflowExpression.Compile(bodylistType, nameof(bodylistType), required: true);
            var __workflow_bodypermissions = WorkflowExpression.Compile(bodypermissions, nameof(bodypermissions), required: true);
            var __workflow_bodyiDS = WorkflowExpression.Compile(bodyiDS, nameof(bodyiDS), required: true);
            return new DeferredBodyAction<ListApiCreatedList, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/list/v1/createlistfromids";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                bodypropCount++;
                body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                bodypropCount++;
                body["list_type"] = ExpressionConverter.ConvertO(__workflow_bodylistType);
                bodypropCount++;
                body["list_permissions"] = ExpressionConverter.ConvertO(__workflow_bodypermissions);
                bodypropCount++;
                body["ids"] = ExpressionConverter.ConvertO(__workflow_bodyiDS);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ListApiCreatedList>(callPayload);
            });
        }
    }

    public class BlackbaudlistsTriggers([ConnectionName] string connectionId)
    {
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodylistTypeInput
    {
        Constituent,
        Gift,
        Action,
        Opportunity
    }

    public class ListApiCreatedList
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodypermissionsInput
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
