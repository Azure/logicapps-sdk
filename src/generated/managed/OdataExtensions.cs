//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Odata
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OdataActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "odata")]
        public IBodyWorkflowAction<JToken[]> GetEntityData([WorkflowExpression] Func<string> odataUri, [WorkflowExpression] Func<string> entity, [WorkflowExpression] Func<double> top = null, [WorkflowExpression] Func<double> skip = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> expand = null)
        {
            SourceExpression.Validate(odataUri, nameof(odataUri), required: true);
            SourceExpression.Validate(entity, nameof(entity), required: true);
            SourceExpression.Validate(top, nameof(top), required: false);
            SourceExpression.Validate(skip, nameof(skip), required: false);
            SourceExpression.Validate(select, nameof(select), required: false);
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(expand, nameof(expand), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/getentitydata";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["odataUri"] = SourceExpressionConverter.ConvertO(odataUri);
                callPayload.Queries["entity"] = SourceExpressionConverter.ConvertO(entity);
                if (top != null)
                    callPayload.Queries["top"] = SourceExpressionConverter.ConvertO(top);
                if (skip != null)
                    callPayload.Queries["skip"] = SourceExpressionConverter.ConvertO(skip);
                if (select != null)
                    callPayload.Queries["select"] = SourceExpressionConverter.ConvertO(select);
                if (filter != null)
                    callPayload.Queries["filter"] = SourceExpressionConverter.ConvertO(filter);
                if (expand != null)
                    callPayload.Queries["expand"] = SourceExpressionConverter.ConvertO(expand);
                return callPayload;
            }

            return new ApiConnectionAction<JToken[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "odata")]
        public IBodyWorkflowAction<JToken> GetSchema([WorkflowExpression] Func<string> odataUri, [WorkflowExpression] Func<string> entity)
        {
            SourceExpression.Validate(odataUri, nameof(odataUri), required: true);
            SourceExpression.Validate(entity, nameof(entity), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/getschema";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["odataUri"] = SourceExpressionConverter.ConvertO(odataUri);
                callPayload.Queries["entity"] = SourceExpressionConverter.ConvertO(entity);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "odata")]
        public IBodyWorkflowAction<JToken> GetSingleSchema([WorkflowExpression] Func<string> odataUri, [WorkflowExpression] Func<string> entity, [WorkflowExpression] Func<int> option = null)
        {
            SourceExpression.Validate(odataUri, nameof(odataUri), required: true);
            SourceExpression.Validate(entity, nameof(entity), required: true);
            SourceExpression.Validate(option, nameof(option), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/getsingleschema";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["odataUri"] = SourceExpressionConverter.ConvertO(odataUri);
                callPayload.Queries["entity"] = SourceExpressionConverter.ConvertO(entity);
                if (option != null)
                    callPayload.Queries["option"] = SourceExpressionConverter.ConvertO(option);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "odata")]
        public IBodyWorkflowAction<JToken> GetEntry([WorkflowExpression] Func<string> odataUri, [WorkflowExpression] Func<string> entity, [WorkflowExpression] Func<object> entryInput = null)
        {
            SourceExpression.Validate(odataUri, nameof(odataUri), required: true);
            SourceExpression.Validate(entity, nameof(entity), required: true);
            SourceExpression.Validate(entryInput, nameof(entryInput), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/getentry";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["odataUri"] = SourceExpressionConverter.ConvertO(odataUri);
                callPayload.Queries["entity"] = SourceExpressionConverter.ConvertO(entity);
                callPayload.Body = SourceExpressionConverter.ConvertToken(entryInput);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "odata")]
        public IBodyWorkflowAction<JToken> CreateEntry([WorkflowExpression] Func<string> odataUri, [WorkflowExpression] Func<string> entity, [WorkflowExpression] Func<object> entryInput = null)
        {
            SourceExpression.Validate(odataUri, nameof(odataUri), required: true);
            SourceExpression.Validate(entity, nameof(entity), required: true);
            SourceExpression.Validate(entryInput, nameof(entryInput), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/createentry";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["odataUri"] = SourceExpressionConverter.ConvertO(odataUri);
                callPayload.Queries["entity"] = SourceExpressionConverter.ConvertO(entity);
                callPayload.Body = SourceExpressionConverter.ConvertToken(entryInput);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "odata")]
        public IBodyWorkflowAction<JToken> UpdateEntry([WorkflowExpression] Func<string> odataUri, [WorkflowExpression] Func<string> entity, [WorkflowExpression] Func<object> entryInput = null)
        {
            SourceExpression.Validate(odataUri, nameof(odataUri), required: true);
            SourceExpression.Validate(entity, nameof(entity), required: true);
            SourceExpression.Validate(entryInput, nameof(entryInput), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/updateentry";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["odataUri"] = SourceExpressionConverter.ConvertO(odataUri);
                callPayload.Queries["entity"] = SourceExpressionConverter.ConvertO(entity);
                callPayload.Body = SourceExpressionConverter.ConvertToken(entryInput);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "odata")]
        public IBodyWorkflowAction<JToken> DeleteEntry([WorkflowExpression] Func<string> odataUri, [WorkflowExpression] Func<string> entity, [WorkflowExpression] Func<object> entryInput = null)
        {
            SourceExpression.Validate(odataUri, nameof(odataUri), required: true);
            SourceExpression.Validate(entity, nameof(entity), required: true);
            SourceExpression.Validate(entryInput, nameof(entryInput), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/deleteentry";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["odataUri"] = SourceExpressionConverter.ConvertO(odataUri);
                callPayload.Queries["entity"] = SourceExpressionConverter.ConvertO(entity);
                callPayload.Body = SourceExpressionConverter.ConvertToken(entryInput);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }
    }

    public class OdataTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Odata;

    public partial class WorkflowManagedActions
    {
        public OdataActions Odata(string connectionId) => new OdataActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public OdataTriggers Odata(string connectionId) => new OdataTriggers(connectionId);
    }
}