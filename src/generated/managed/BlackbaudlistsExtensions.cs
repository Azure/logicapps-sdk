//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Blackbaudlists
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BlackbaudlistsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudlists")]
        public IWorkflowAction AppendIDsToList([WorkflowExpression] Func<bodylistTypeInput> bodylistType, [WorkflowExpression] Func<string> bodylist, [WorkflowExpression] Func<string[]> bodyiDS)
        {
            SourceExpression.Validate(bodylistType, nameof(bodylistType), required: true);
            SourceExpression.Validate(bodylist, nameof(bodylist), required: true);
            SourceExpression.Validate(bodyiDS, nameof(bodyiDS), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/list/v1/appendidstolist";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["list_type"] = SourceExpressionConverter.Convert(bodylistType);
                bodypropCount++;
                body["list_id"] = SourceExpressionConverter.ConvertToken(bodylist);
                bodypropCount++;
                body["ids"] = SourceExpressionConverter.ConvertToken(bodyiDS);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudlists")]
        public IBodyWorkflowAction<ListApiCreatedList> CreateListFromIDs([WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodydescription, [WorkflowExpression] Func<bodylistTypeInput> bodylistType, [WorkflowExpression] Func<bodypermissionsInput> bodypermissions, [WorkflowExpression] Func<string[]> bodyiDS)
        {
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: true);
            SourceExpression.Validate(bodylistType, nameof(bodylistType), required: true);
            SourceExpression.Validate(bodypermissions, nameof(bodypermissions), required: true);
            SourceExpression.Validate(bodyiDS, nameof(bodyiDS), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/list/v1/createlistfromids";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
                body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                bodypropCount++;
                body["list_type"] = SourceExpressionConverter.Convert(bodylistType);
                bodypropCount++;
                body["list_permissions"] = SourceExpressionConverter.Convert(bodypermissions);
                bodypropCount++;
                body["ids"] = SourceExpressionConverter.ConvertToken(bodyiDS);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ListApiCreatedList>(BuildSourceInput);
        }
    }

    public class BlackbaudlistsTriggers([ConnectionName] string connectionId)
    {
    }

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