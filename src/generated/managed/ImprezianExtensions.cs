//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Imprezian
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ImprezianActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<string[], ApiConnectionActionConfiguration> CampaignGetValues()
        {
            return new DeferredBodyAction<string[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Campaign";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> CampaignPostValue(Expression<Func<CampaignPostValueInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Campaign";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<CampaignGetValueResponse, ApiConnectionActionConfiguration> CampaignGetValue(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<CampaignGetValueResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/Campaign/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CampaignGetValueResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> CampaignPutValue(Expression<Func<string>> id, Expression<Func<CampaignPutValueInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/Campaign/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<string[], ApiConnectionActionConfiguration> ComLogGetValues()
        {
            return new DeferredBodyAction<string[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/ComLog";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> ComLogPostValue(Expression<Func<ComLogPostValueInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/ComLog";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<ComLogGetValueResponse, ApiConnectionActionConfiguration> ComLogGetValue(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ComLogGetValueResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ComLog/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ComLogGetValueResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ComLogPutValue(Expression<Func<string>> id, Expression<Func<ComLogPutValueInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ComLog/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<string[], ApiConnectionActionConfiguration> ContactGetValues()
        {
            return new DeferredBodyAction<string[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Contact";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> ContactPostValue(Expression<Func<ContactPostValueInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Contact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> ContactGetValue(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/Contact/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> ContactPutValue(Expression<Func<string>> id, Expression<Func<ContactPutValueInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/Contact/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<string[], ApiConnectionActionConfiguration> FollowUpGetValues()
        {
            return new DeferredBodyAction<string[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/FollowUp";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> FollowUpPostValue(Expression<Func<FollowUpPostValueInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/FollowUp";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<FollowUpGetValueResponse, ApiConnectionActionConfiguration> FollowUpGetValue(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<FollowUpGetValueResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/FollowUp/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<FollowUpGetValueResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IWorkflowAction<ApiConnectionActionConfiguration> FollowUpPutValue(Expression<Func<string>> id, Expression<Func<FollowUpPutValueInput>> body)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/FollowUp/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<string[], ApiConnectionActionConfiguration> ItemListGetValues()
        {
            return new DeferredBodyAction<string[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/ItemList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<ItemListPostValueResponse, ApiConnectionActionConfiguration> ItemListPostValue(Expression<Func<ItemListPostValueInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ItemListPostValueResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/ItemList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ItemListPostValueResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<ItemListGetValueResponse, ApiConnectionActionConfiguration> ItemListGetValue(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ItemListGetValueResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ItemList/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ItemListGetValueResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ItemListPutValue(Expression<Func<string>> id, Expression<Func<ItemListPutValueInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ItemList/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<string[], ApiConnectionActionConfiguration> LeadGetValues()
        {
            return new DeferredBodyAction<string[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Lead";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> LeadPostValue(Expression<Func<LeadPostValueInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Lead";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<LeadGetValueResponse, ApiConnectionActionConfiguration> LeadGetValue(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<LeadGetValueResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/Lead/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<LeadGetValueResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> LeadPutValue(Expression<Func<string>> id, Expression<Func<LeadPutValueInput>> body)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/Lead/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<string[], ApiConnectionActionConfiguration> MembersGetValues(Expression<Func<typeInput>> type)
        {
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: true);
            return new DeferredBodyAction<string[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Members";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["type"] = ExpressionConverter.Convert(__workflow_type);
                return new ApiConnectionAction<string[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> MembersPostValue(Expression<Func<MembersPostValueInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Members";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<MembersGetValueResponse, ApiConnectionActionConfiguration> MembersGetValue(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<MembersGetValueResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/Members/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<MembersGetValueResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> MembersPutValue(Expression<Func<string>> id, Expression<Func<MembersPutValueInput>> body)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/Members/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<string[], ApiConnectionActionConfiguration> ShippingGetValues()
        {
            return new DeferredBodyAction<string[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Shipping";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> ShippingPostValue(Expression<Func<ShippingPostValueInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Shipping";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<ShippingGetValueResponse, ApiConnectionActionConfiguration> ShippingGetValue(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ShippingGetValueResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/Shipping/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ShippingGetValueResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ShippingPutValue(Expression<Func<string>> id, Expression<Func<ShippingPutValueInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/Shipping/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<string[], ApiConnectionActionConfiguration> SOGetValues()
        {
            return new DeferredBodyAction<string[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/SO";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> SOPostValue(Expression<Func<SOPostValueInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/SO";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<SOGetValueResponse, ApiConnectionActionConfiguration> SOGetValue(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<SOGetValueResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/SO/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SOGetValueResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SOPutValue(Expression<Func<string>> id, Expression<Func<SOPutValueInput>> body)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/SO/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<string[], ApiConnectionActionConfiguration> WorkOrderGetValues()
        {
            return new DeferredBodyAction<string[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/WorkOrder";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> WorkOrderPostValue(Expression<Func<WorkOrderPostValueInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/WorkOrder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IBodyWorkflowAction<WorkOrderGetValueResponse, ApiConnectionActionConfiguration> WorkOrderGetValue(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<WorkOrderGetValueResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/WorkOrder/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<WorkOrderGetValueResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imprezian")]
        public IWorkflowAction<ApiConnectionActionConfiguration> WorkOrderPutValue(Expression<Func<string>> id, Expression<Func<WorkOrderPutValueInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/WorkOrder/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class ImprezianTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<NewSalesLeadResponseItem[], ApiConnectionTriggerConfiguration> NewSalesLead(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<NewSalesLeadResponseItem[], ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger/api/new_lead";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<NewSalesLeadResponseItem[]>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<NewMarketingCampaignResponseItem[], ApiConnectionTriggerConfiguration> NewMarketingCampaign(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<NewMarketingCampaignResponseItem[], ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger/api/new_campaign";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<NewMarketingCampaignResponseItem[]>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<NewMembersLeadsResponseItem[], ApiConnectionTriggerConfiguration> NewMembersLeads(Expression<Func<int>> promotionId, FlowRecurrence recurrence = null)
        {
            var __workflow_promotionId = WorkflowExpression.Compile(promotionId, nameof(promotionId), required: true);
            return new DeferredBodyTrigger<NewMembersLeadsResponseItem[], ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger/api/new_members_leads";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["PromotionID"] = ExpressionConverter.Convert(__workflow_promotionId);
                return new ApiConnectionTrigger<NewMembersLeadsResponseItem[]>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<NewSalesOrderResponseItem[], ApiConnectionTriggerConfiguration> NewSalesOrder(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<NewSalesOrderResponseItem[], ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger/api/new_orders";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<NewSalesOrderResponseItem[]>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<NewProposalCreatedResponseItem[], ApiConnectionTriggerConfiguration> NewProposalCreated(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<NewProposalCreatedResponseItem[], ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger/api/new_quotes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<NewProposalCreatedResponseItem[]>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<OrderStatusChangedResponseItem[], ApiConnectionTriggerConfiguration> OrderStatusChanged(Expression<Func<string>> status, FlowRecurrence recurrence = null)
        {
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: true);
            return new DeferredBodyTrigger<OrderStatusChangedResponseItem[], ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger/api/order_status";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Status"] = ExpressionConverter.Convert(__workflow_status);
                return new ApiConnectionTrigger<OrderStatusChangedResponseItem[]>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<OrderInHistoryResponseItem[], ApiConnectionTriggerConfiguration> OrderInHistory(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<OrderInHistoryResponseItem[], ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger/api/orders_final";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<OrderInHistoryResponseItem[]>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<OrderInProcessingResponseItem[], ApiConnectionTriggerConfiguration> OrderInProcessing(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<OrderInProcessingResponseItem[], ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger/api/orders_processing";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<OrderInProcessingResponseItem[]>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<OrderIsShippingResponseItem[], ApiConnectionTriggerConfiguration> OrderIsShipping(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<OrderIsShippingResponseItem[], ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger/api/orders_shipping";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<OrderIsShippingResponseItem[]>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<ProposalNeedsApprovalResponseItem[], ApiConnectionTriggerConfiguration> ProposalNeedsApproval(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<ProposalNeedsApprovalResponseItem[], ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger/api/quotes_approval";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<ProposalNeedsApprovalResponseItem[]>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<WorkOrderClosedResponseItem[], ApiConnectionTriggerConfiguration> WorkOrderClosed(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<WorkOrderClosedResponseItem[], ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger/api/wo_closed";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<WorkOrderClosedResponseItem[]>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<WorkOrderCreatedResponseItem[], ApiConnectionTriggerConfiguration> WorkOrderCreated(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<WorkOrderCreatedResponseItem[], ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger/api/wo_opened";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<WorkOrderCreatedResponseItem[]>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<WorkOrderPastDueResponseItem[], ApiConnectionTriggerConfiguration> WorkOrderPastDue(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<WorkOrderPastDueResponseItem[], ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger/api/wo_pastdue";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<WorkOrderPastDueResponseItem[]>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<WorkOrderStatusChangedResponseItem[], ApiConnectionTriggerConfiguration> WorkOrderStatusChanged(Expression<Func<string>> status, FlowRecurrence recurrence = null)
        {
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: true);
            return new DeferredBodyTrigger<WorkOrderStatusChangedResponseItem[], ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger/api/wo_status";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Status"] = ExpressionConverter.Convert(__workflow_status);
                return new ApiConnectionTrigger<WorkOrderStatusChangedResponseItem[]>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class CampaignPostValueInput
    {
        [JsonProperty("description", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Description { get; set; }

        [JsonProperty("startdate")]
        public string Startdate { get; set; }

        [JsonProperty("expires", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Expires { get; set; }

        [JsonProperty("budget", DefaultValueHandling = DefaultValueHandling.Include)]
        public double Budget { get; set; } = 0;

        [JsonProperty("promotype")]
        public string Promotype { get; set; }

        [JsonProperty("manager")]
        public string Manager { get; set; }
    }

    public class CampaignGetValueResponse
    {
        [JsonProperty("PromoID")]
        public string PromoId { get; set; }

        [JsonProperty("Campaign Manager")]
        public string CampaignManager { get; set; }

        [JsonProperty("IS INACTIVE")]
        public string ISINACTIVE { get; set; }

        [JsonProperty("IN HISTORY")]
        public string INHISTORY { get; set; }

        [JsonProperty("Used For Discounting")]
        public string UsedForDiscounting { get; set; }

        [JsonProperty("Used For Mail Broadcasting")]
        public string UsedForMailBroadcasting { get; set; }

        [JsonProperty("budget")]
        public string Budget { get; set; }

        [JsonProperty("Promotion Type")]
        public string PromotionType { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("Employee Name")]
        public string EmployeeName { get; set; }

        [JsonProperty("Start Date")]
        public string StartDate { get; set; }

        [JsonProperty("Expiration Date")]
        public string ExpirationDate { get; set; }
        public string Revenue { get; set; }
    }

    public class CampaignPutValueInput
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("startdate")]
        public string Startdate { get; set; }

        [JsonProperty("expires")]
        public string Expires { get; set; }

        [JsonProperty("budget")]
        public double? Budget { get; set; }

        [JsonProperty("manager")]
        public string Manager { get; set; }

        [JsonProperty("history")]
        public bool? History { get; set; }
    }

    public class ComLogPostValueInput
    {
        [JsonProperty("contactid")]
        public string Contactid { get; set; }

        [JsonProperty("leadid")]
        public string Leadid { get; set; }

        [JsonProperty("type")]
        public ComLogPostValueInputTypeType? Type { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("employee")]
        public string Employee { get; set; }

        [JsonProperty("starttime")]
        public string Starttime { get; set; }

        [JsonProperty("endtime")]
        public string Endtime { get; set; }

        [JsonProperty("workorder")]
        public string Workorder { get; set; }

        [JsonProperty("project")]
        public string Project { get; set; }

        [JsonProperty("campaign")]
        public string Campaign { get; set; }

        [JsonProperty("length")]
        public double? Length { get; set; }

        [JsonProperty("billed")]
        public bool? Billed { get; set; }

        [JsonProperty("inbound")]
        public bool? Inbound { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ComLogPostValueInputTypeType
    {
        [EnumMember(Value = "E-mail")]
        EMail,
        [EnumMember(Value = "Phone-Call")]
        PhoneCall,
        Fax,
        Tweet,
        Facebook,
        Other
    }

    public class ComLogGetValueResponse
    {
        public string Direction { get; set; }

        [JsonProperty("account")]
        public string Account { get; set; }

        [JsonProperty("Account Name")]
        public string AccountName { get; set; }

        [JsonProperty("Contact Name")]
        public string ContactName { get; set; }

        [JsonProperty("Start Date")]
        public string StartDate { get; set; }

        [JsonProperty("End Date")]
        public string EndDate { get; set; }

        [JsonProperty("Employee Name")]
        public string EmployeeName { get; set; }
        public string Type { get; set; }
        public string Length { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public string Billed { get; set; }

        [JsonProperty("Work Order")]
        public string WorkOrder { get; set; }

        [JsonProperty("Sales Order")]
        public string SalesOrder { get; set; }

        [JsonProperty("Sales Lead")]
        public string SalesLead { get; set; }

        [JsonProperty("Project ID")]
        public string ProjectId { get; set; }
        public string Recipient { get; set; }

        [JsonProperty("cc")]
        public string Cc { get; set; }
        public string Bcc { get; set; }
        public string CallNumber { get; set; }

        [JsonProperty("RecordID")]
        public string RecordId { get; set; }

        [JsonProperty("Company Name")]
        public string CompanyName { get; set; }
    }

    public class ComLogPutValueInput
    {
        [JsonProperty("type")]
        public ComLogPutValueInputTypeType? Type { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("employee")]
        public string Employee { get; set; }

        [JsonProperty("starttime")]
        public string Starttime { get; set; }

        [JsonProperty("endtime")]
        public string Endtime { get; set; }

        [JsonProperty("workorder")]
        public string Workorder { get; set; }

        [JsonProperty("project")]
        public string Project { get; set; }

        [JsonProperty("campaign")]
        public string Campaign { get; set; }

        [JsonProperty("length")]
        public double? Length { get; set; }

        [JsonProperty("billed")]
        public bool? Billed { get; set; }

        [JsonProperty("inbound")]
        public bool? Inbound { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ComLogPutValueInputTypeType
    {
        [EnumMember(Value = "E-mail")]
        EMail,
        [EnumMember(Value = "Phone-Call")]
        PhoneCall,
        Fax,
        Tweet,
        Facebook,
        Other
    }

    public class ContactPostValueInput
    {
        [JsonProperty("account")]
        public string Account { get; set; }

        [JsonProperty("sal")]
        public string Sal { get; set; }

        [JsonProperty("firstname")]
        public string Firstname { get; set; }

        [JsonProperty("middlename")]
        public string Middlename { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("lastname")]
        public string Lastname { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("addr1")]
        public string Addr1 { get; set; }

        [JsonProperty("addr2")]
        public string Addr2 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postal")]
        public string Postal { get; set; }

        [JsonProperty("email1")]
        public string Email1 { get; set; }

        [JsonProperty("email2")]
        public string Email2 { get; set; }

        [JsonProperty("email3")]
        public string Email3 { get; set; }

        [JsonProperty("email4")]
        public string Email4 { get; set; }

        [JsonProperty("phonetype1")]
        public string Phonetype1 { get; set; }

        [JsonProperty("phone1")]
        public string Phone1 { get; set; }

        [JsonProperty("phonetype2")]
        public string Phonetype2 { get; set; }

        [JsonProperty("phone2")]
        public string Phone2 { get; set; }

        [JsonProperty("phonetype3")]
        public string Phonetype3 { get; set; }

        [JsonProperty("phone3")]
        public string Phone3 { get; set; }

        [JsonProperty("phonetype4")]
        public string Phonetype4 { get; set; }

        [JsonProperty("phone4")]
        public string Phone4 { get; set; }

        [JsonProperty("remark")]
        public string Remark { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("campaign")]
        public string Campaign { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("market")]
        public string Market { get; set; }

        [JsonProperty("territory")]
        public string Territory { get; set; }

        [JsonProperty("salesrep")]
        public string Salesrep { get; set; }

        [JsonProperty("lastcontact")]
        public string Lastcontact { get; set; }
    }

    public class ContactPutValueInput
    {
        [JsonProperty("sal")]
        public string Sal { get; set; }

        [JsonProperty("firstname")]
        public string Firstname { get; set; }

        [JsonProperty("middlename")]
        public string Middlename { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("lastname")]
        public string Lastname { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("addr1")]
        public string Addr1 { get; set; }

        [JsonProperty("addr2")]
        public string Addr2 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postal")]
        public string Postal { get; set; }

        [JsonProperty("email1")]
        public string Email1 { get; set; }

        [JsonProperty("email2")]
        public string Email2 { get; set; }

        [JsonProperty("email3")]
        public string Email3 { get; set; }

        [JsonProperty("email4")]
        public string Email4 { get; set; }

        [JsonProperty("phonetype1")]
        public string Phonetype1 { get; set; }

        [JsonProperty("phone1")]
        public string Phone1 { get; set; }

        [JsonProperty("phonetype2")]
        public string Phonetype2 { get; set; }

        [JsonProperty("phone2")]
        public string Phone2 { get; set; }

        [JsonProperty("phonetype3")]
        public string Phonetype3 { get; set; }

        [JsonProperty("phone3")]
        public string Phone3 { get; set; }

        [JsonProperty("phonetype4")]
        public string Phonetype4 { get; set; }

        [JsonProperty("phone4")]
        public string Phone4 { get; set; }

        [JsonProperty("remark")]
        public string Remark { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("campaign")]
        public string Campaign { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("market")]
        public string Market { get; set; }

        [JsonProperty("territory")]
        public string Territory { get; set; }

        [JsonProperty("salesrep")]
        public string Salesrep { get; set; }

        [JsonProperty("lastcontact")]
        public string Lastcontact { get; set; }
    }

    public class FollowUpPostValueInput
    {
        [JsonProperty("contactid")]
        public string Contactid { get; set; }

        [JsonProperty("leadid")]
        public string Leadid { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("comments")]
        public string Comments { get; set; }

        [JsonProperty("assignedto")]
        public string Assignedto { get; set; }

        [JsonProperty("setby")]
        public string Setby { get; set; }

        [JsonProperty("duedate")]
        public string Duedate { get; set; }

        [JsonProperty("urgent")]
        public bool? Urgent { get; set; }

        [JsonProperty("reminderminutes")]
        public double? Reminderminutes { get; set; }

        [JsonProperty("cleared")]
        public bool? Cleared { get; set; }
    }

    public class FollowUpGetValueResponse
    {
        [JsonProperty("account")]
        public string Account { get; set; }

        [JsonProperty("RecallID")]
        public string RecallId { get; set; }

        [JsonProperty("Employee Name")]
        public string EmployeeName { get; set; }

        [JsonProperty("SET FOR")]
        public string SETFOR { get; set; }

        [JsonProperty("SET BY")]
        public string SETBY { get; set; }

        [JsonProperty("SET ON")]
        public string SETON { get; set; }

        [JsonProperty("IS CLEARED")]
        public string ISCLEARED { get; set; }

        [JsonProperty("Cleared By")]
        public string ClearedBy { get; set; }

        [JsonProperty("Cleared On")]
        public string ClearedOn { get; set; }

        [JsonProperty("ACCOUNT TYPE")]
        public string ACCOUNTTYPE { get; set; }
        public string Priority { get; set; }
        public string TYPE { get; set; }
        public string Details { get; set; }

        [JsonProperty("Account Name")]
        public string AccountName { get; set; }

        [JsonProperty("First Name")]
        public string FirstName { get; set; }

        [JsonProperty("Last Name")]
        public string LastName { get; set; }

        [JsonProperty("Company Name")]
        public string CompanyName { get; set; }

        [JsonProperty("FollowUp Date")]
        public string FollowUpDate { get; set; }

        [JsonProperty("Reminder Time")]
        public string ReminderTime { get; set; }

        [JsonProperty("WORK ORDER")]
        public string WORKORDER { get; set; }

        [JsonProperty("Sales Lead")]
        public string SalesLead { get; set; }

        [JsonProperty("Project ID")]
        public string ProjectId { get; set; }
    }

    public class FollowUpPutValueInput
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("comments")]
        public string Comments { get; set; }

        [JsonProperty("assignedto")]
        public string Assignedto { get; set; }

        [JsonProperty("setby")]
        public string Setby { get; set; }

        [JsonProperty("duedate")]
        public string Duedate { get; set; }

        [JsonProperty("urgent")]
        public string Urgent { get; set; }

        [JsonProperty("reminderminutes")]
        public double? Reminderminutes { get; set; }

        [JsonProperty("cleared")]
        public bool? Cleared { get; set; }
    }

    public class ItemListPostValueResponse
    {
        [JsonProperty("id")]
        public string NewCodeId { get; set; }
    }

    public class ItemListPostValueInput
    {
        [JsonProperty("modelno")]
        public string Modelno { get; set; }

        [JsonProperty("descrip")]
        public string Descrip { get; set; }

        [JsonProperty("itemtype")]
        public ItemListPostValueInputItemtypeType? Itemtype { get; set; }

        [JsonProperty("price")]
        public double? Price { get; set; }

        [JsonProperty("cost")]
        public double? Cost { get; set; }

        [JsonProperty("vendor")]
        public string Vendor { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ItemListPostValueInputItemtypeType
    {
        I,
        N,
        M,
        D,
        S
    }

    public class ItemListGetValueResponse
    {
        public string Code { get; set; }

        [JsonProperty("Model Number")]
        public string ModelNumber { get; set; }
        public string Description { get; set; }

        [JsonProperty("Sales Description")]
        public string SalesDescription { get; set; }

        [JsonProperty("Purchase Description")]
        public string PurchaseDescription { get; set; }

        [JsonProperty("Item Type")]
        public string ItemType { get; set; }

        [JsonProperty("Base Price")]
        public string BasePrice { get; set; }

        [JsonProperty("Avg Cost")]
        public string AvgCost { get; set; }

        [JsonProperty("Primary Category")]
        public string PrimaryCategory { get; set; }
        public string Category2 { get; set; }
        public string Category3 { get; set; }
        public string Category4 { get; set; }
        public string Category5 { get; set; }

        [JsonProperty("Base UOM")]
        public string BaseUOM { get; set; }

        [JsonProperty("Sell UOM")]
        public string SellUOM { get; set; }

        [JsonProperty("Buy UOM")]
        public string BuyUOM { get; set; }

        [JsonProperty("Base Warehouse")]
        public string BaseWarehouse { get; set; }

        [JsonProperty("On Hand")]
        public string OnHand { get; set; }

        [JsonProperty("On SO")]
        public string OnSO { get; set; }
        public string Bad { get; set; }

        [JsonProperty("On WO")]
        public string OnWO { get; set; }

        [JsonProperty("On PO")]
        public string OnPO { get; set; }
        public string Available { get; set; }
        public string Taxable { get; set; }

        [JsonProperty("Tax 2")]
        public string Tax2 { get; set; }

        [JsonProperty("Pays Commission")]
        public string PaysCommission { get; set; }

        [JsonProperty("Fixed Price")]
        public string FixedPrice { get; set; }

        [JsonProperty("Discounting Prohibited")]
        public string DiscountingProhibited { get; set; }

        [JsonProperty("Call For Price")]
        public string CallForPrice { get; set; }

        [JsonProperty("Call For Cost")]
        public string CallForCost { get; set; }

        [JsonProperty("Gratis Item")]
        public string GratisItem { get; set; }

        [JsonProperty("Hidden on Printouts")]
        public string HiddenOnPrintouts { get; set; }

        [JsonProperty("Exclude From Margin")]
        public string ExcludeFromMargin { get; set; }

        [JsonProperty("Track Serial Numbers")]
        public string TrackSerialNumbers { get; set; }

        [JsonProperty("Serialization Mode")]
        public string SerializationMode { get; set; }

        [JsonProperty("Serial Number Required")]
        public string SerialNumberRequired { get; set; }

        [JsonProperty("Prohibit Duplicate Serial Numbers")]
        public string ProhibitDuplicateSerialNumbers { get; set; }

        [JsonProperty("Expiration Date Applies")]
        public string ExpirationDateApplies { get; set; }

        [JsonProperty("Shipping Charges Apply")]
        public string ShippingChargesApply { get; set; }

        [JsonProperty("Item must ship seperately")]
        public string ItemMustShipSeperately { get; set; }

        [JsonProperty("Group Ship Items")]
        public string GroupShipItems { get; set; }

        [JsonProperty("Drop-Ship From Vendor")]
        public string DropShipFromVendor { get; set; }
        public string Height { get; set; }
        public string Width { get; set; }
        public string Depth { get; set; }
        public string Weight { get; set; }

        [JsonProperty("Box Limit")]
        public string BoxLimit { get; set; }

        [JsonProperty("Lead Time")]
        public string LeadTime { get; set; }

        [JsonProperty("Last Cost")]
        public string LastCost { get; set; }

        [JsonProperty("Reorder Point")]
        public string ReorderPoint { get; set; }

        [JsonProperty("Item Message")]
        public string ItemMessage { get; set; }

        [JsonProperty("ON SALE")]
        public string ONSALE { get; set; }

        [JsonProperty("IS ASSEMBLY")]
        public string ISASSEMBLY { get; set; }

        [JsonProperty("Manufacturer Part Number")]
        public string ManufacturerPartNumber { get; set; }
        public string OEM { get; set; }

        [JsonProperty("BIN Location")]
        public string BINLocation { get; set; }

        [JsonProperty("Primary Vendor")]
        public string PrimaryVendor { get; set; }

        [JsonProperty("Vendor 1 Part #")]
        public string Vendor1Part { get; set; }

        [JsonProperty("Vendor 1 Descrip")]
        public string Vendor1Descrip { get; set; }

        [JsonProperty("Vendor 1 Cost")]
        public string Vendor1Cost { get; set; }

        [JsonProperty("Vendor 1 Date Cost Verified")]
        public string Vendor1DateCostVerified { get; set; }

        [JsonProperty("Vendor 2")]
        public string Vendor2 { get; set; }

        [JsonProperty("Vendor 2 Part #")]
        public string Vendor2Part { get; set; }

        [JsonProperty("Vendor 2 Descrip")]
        public string Vendor2Descrip { get; set; }

        [JsonProperty("Vendor 2 Cost")]
        public string Vendor2Cost { get; set; }

        [JsonProperty("Vendor 2 Date Cost Verified")]
        public string Vendor2DateCostVerified { get; set; }

        [JsonProperty("Vendor 3")]
        public string Vendor3 { get; set; }

        [JsonProperty("Vendor 3 Part #")]
        public string Vendor3Part { get; set; }

        [JsonProperty("Vendor 3 Descrip")]
        public string Vendor3Descrip { get; set; }

        [JsonProperty("Vendor 3 Cost")]
        public string Vendor3Cost { get; set; }

        [JsonProperty("Vendor 3 Date Cost Verified")]
        public string Vendor3DateCostVerified { get; set; }

        [JsonProperty("Vendor 4")]
        public string Vendor4 { get; set; }

        [JsonProperty("Vendor 4 Part #")]
        public string Vendor4Part { get; set; }

        [JsonProperty("Vendor 4 Descrip")]
        public string Vendor4Descrip { get; set; }

        [JsonProperty("Vendor 4 Cost")]
        public string Vendor4Cost { get; set; }

        [JsonProperty("Vendor 4 Date Cost Verified")]
        public string Vendor4DateCostVerified { get; set; }

        [JsonProperty("Vendor 5")]
        public string Vendor5 { get; set; }

        [JsonProperty("Vendor 5 Part #")]
        public string Vendor5Part { get; set; }

        [JsonProperty("Vendor 5 Descrip")]
        public string Vendor5Descrip { get; set; }

        [JsonProperty("Vendor 5 Cost")]
        public string Vendor5Cost { get; set; }

        [JsonProperty("Vendor 5 Date Cost Verified")]
        public string Vendor5DateCostVerified { get; set; }

        [JsonProperty("Price Level Mode")]
        public string PriceLevelMode { get; set; }

        [JsonProperty("Price Level 2")]
        public string PriceLevel2 { get; set; }

        [JsonProperty("Price Level 3")]
        public string PriceLevel3 { get; set; }

        [JsonProperty("Price Level 4")]
        public string PriceLevel4 { get; set; }

        [JsonProperty("Price Level 5")]
        public string PriceLevel5 { get; set; }

        [JsonProperty("Price Level 6")]
        public string PriceLevel6 { get; set; }

        [JsonProperty("Price Level 7")]
        public string PriceLevel7 { get; set; }

        [JsonProperty("Price Level 8")]
        public string PriceLevel8 { get; set; }

        [JsonProperty("Price Level 9")]
        public string PriceLevel9 { get; set; }

        [JsonProperty("Price Level 10")]
        public string PriceLevel10 { get; set; }

        [JsonProperty("Price Level 11")]
        public string PriceLevel11 { get; set; }

        [JsonProperty("Price Level 12")]
        public string PriceLevel12 { get; set; }

        [JsonProperty("Price Level 13")]
        public string PriceLevel13 { get; set; }

        [JsonProperty("Price Level 14")]
        public string PriceLevel14 { get; set; }

        [JsonProperty("Price Level 15")]
        public string PriceLevel15 { get; set; }

        [JsonProperty("Price Level 16")]
        public string PriceLevel16 { get; set; }

        [JsonProperty("Price Level 17")]
        public string PriceLevel17 { get; set; }

        [JsonProperty("Price Level 18")]
        public string PriceLevel18 { get; set; }

        [JsonProperty("Price Level 19")]
        public string PriceLevel19 { get; set; }

        [JsonProperty("Price Level 20")]
        public string PriceLevel20 { get; set; }

        [JsonProperty("Quantity Level 1")]
        public string QuantityLevel1 { get; set; }

        [JsonProperty("Quantity Price 1")]
        public string QuantityPrice1 { get; set; }

        [JsonProperty("Quantity Price Level 1")]
        public string QuantityPriceLevel1 { get; set; }

        [JsonProperty("Quantity Level 2")]
        public string QuantityLevel2 { get; set; }

        [JsonProperty("Quantity Price 2")]
        public string QuantityPrice2 { get; set; }

        [JsonProperty("Quantity Price Level 2")]
        public string QuantityPriceLevel2 { get; set; }

        [JsonProperty("Quantity Level 3")]
        public string QuantityLevel3 { get; set; }

        [JsonProperty("Quantity Price 3")]
        public string QuantityPrice3 { get; set; }

        [JsonProperty("Quantity Price Level 3")]
        public string QuantityPriceLevel3 { get; set; }

        [JsonProperty("Quantity Level 4")]
        public string QuantityLevel4 { get; set; }

        [JsonProperty("Quantity Price 4")]
        public string QuantityPrice4 { get; set; }

        [JsonProperty("Quantity Price Level 4")]
        public string QuantityPriceLevel4 { get; set; }

        [JsonProperty("Quantity Level 5")]
        public string QuantityLevel5 { get; set; }

        [JsonProperty("Quantity Price 5")]
        public string QuantityPrice5 { get; set; }

        [JsonProperty("Quantity Price Level 5")]
        public string QuantityPriceLevel5 { get; set; }

        [JsonProperty("Quantity Level 6")]
        public string QuantityLevel6 { get; set; }

        [JsonProperty("Quantity Price 6")]
        public string QuantityPrice6 { get; set; }

        [JsonProperty("Quantity Price Level 6")]
        public string QuantityPriceLevel6 { get; set; }

        [JsonProperty("Quantity Level 7")]
        public string QuantityLevel7 { get; set; }

        [JsonProperty("Quantity Price 7")]
        public string QuantityPrice7 { get; set; }

        [JsonProperty("Quantity Price Level 7")]
        public string QuantityPriceLevel7 { get; set; }

        [JsonProperty("Quantity Level 8")]
        public string QuantityLevel8 { get; set; }

        [JsonProperty("Quantity Price 8")]
        public string QuantityPrice8 { get; set; }

        [JsonProperty("Quantity Price Level 8")]
        public string QuantityPriceLevel8 { get; set; }

        [JsonProperty("Quantity Level 9")]
        public string QuantityLevel9 { get; set; }

        [JsonProperty("Quantity Price 9")]
        public string QuantityPrice9 { get; set; }

        [JsonProperty("Quantity Price Level 9")]
        public string QuantityPriceLevel9 { get; set; }

        [JsonProperty("Quantity Level 10")]
        public string QuantityLevel10 { get; set; }

        [JsonProperty("Quantity Price 10")]
        public string QuantityPrice10 { get; set; }

        [JsonProperty("Quantity Price Level 10")]
        public string QuantityPriceLevel10 { get; set; }
    }

    public class ItemListPutValueInput
    {
        [JsonProperty("descrip")]
        public string Descrip { get; set; }

        [JsonProperty("price")]
        public double? Price { get; set; }

        [JsonProperty("cost")]
        public double? Cost { get; set; }

        [JsonProperty("vendor")]
        public string Vendor { get; set; }
    }

    public class LeadPostValueInput
    {
        [JsonProperty("sal")]
        public string Sal { get; set; }

        [JsonProperty("firstname")]
        public string Firstname { get; set; }

        [JsonProperty("middlename")]
        public string Middlename { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("lastname")]
        public string Lastname { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("addr1")]
        public string Addr1 { get; set; }

        [JsonProperty("addr2")]
        public string Addr2 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postal")]
        public string Postal { get; set; }

        [JsonProperty("email1")]
        public string Email1 { get; set; }

        [JsonProperty("email2")]
        public string Email2 { get; set; }

        [JsonProperty("email3")]
        public string Email3 { get; set; }

        [JsonProperty("email4")]
        public string Email4 { get; set; }

        [JsonProperty("phonetype1")]
        public string Phonetype1 { get; set; }

        [JsonProperty("phone1")]
        public string Phone1 { get; set; }

        [JsonProperty("phonetype2")]
        public string Phonetype2 { get; set; }

        [JsonProperty("phone2")]
        public string Phone2 { get; set; }

        [JsonProperty("phonetype3")]
        public string Phonetype3 { get; set; }

        [JsonProperty("phone3")]
        public string Phone3 { get; set; }

        [JsonProperty("phonetype4")]
        public string Phonetype4 { get; set; }

        [JsonProperty("phone4")]
        public string Phone4 { get; set; }

        [JsonProperty("remark")]
        public string Remark { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("campaign")]
        public string Campaign { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("market")]
        public string Market { get; set; }

        [JsonProperty("territory")]
        public string Territory { get; set; }

        [JsonProperty("salesrep")]
        public string Salesrep { get; set; }

        [JsonProperty("lastcontact")]
        public string Lastcontact { get; set; }
    }

    public class LeadGetValueResponse
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("leadid")]
        public string Leadid { get; set; }
        public string Category { get; set; }

        [JsonProperty("recordid")]
        public string Recordid { get; set; }

        [JsonProperty("Company Name")]
        public string CompanyName { get; set; }
        public string Salutation { get; set; }

        [JsonProperty("First Name")]
        public string FirstName { get; set; }

        [JsonProperty("Last Name")]
        public string LastName { get; set; }

        [JsonProperty("Address Line 1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("Address Line 2")]
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        [JsonProperty("Postal Code")]
        public string PostalCode { get; set; }
        public string Country { get; set; }

        [JsonProperty("Time-Zone")]
        public string TimeZone { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string Title { get; set; }

        [JsonProperty("Contact Type")]
        public string ContactType { get; set; }

        [JsonProperty("Sales Rep")]
        public string SalesRep { get; set; }

        [JsonProperty("Phone Extension")]
        public string PhoneExtension { get; set; }

        [JsonProperty("Last Contact Date")]
        public string LastContactDate { get; set; }

        [JsonProperty("Contact Notes")]
        public string ContactNotes { get; set; }

        [JsonProperty("Quick Remark")]
        public string QuickRemark { get; set; }

        [JsonProperty("Created Date")]
        public string CreatedDate { get; set; }
        public string Market { get; set; }

        [JsonProperty("Sales Territory")]
        public string SalesTerritory { get; set; }

        [JsonProperty("Primary Email")]
        public string PrimaryEmail { get; set; }

        [JsonProperty("EMail 2")]
        public string EMail2 { get; set; }

        [JsonProperty("Email 3")]
        public string Email3 { get; set; }

        [JsonProperty("Email 4")]
        public string Email4 { get; set; }
        public string OPTOUT { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Phone3 { get; set; }
        public string Phone4 { get; set; }

        [JsonProperty("Promotion Memberships")]
        public string PromotionMemberships { get; set; }
        public string Source { get; set; }

        [JsonProperty("Source Notes")]
        public string SourceNotes { get; set; }
        public string Website { get; set; }
        public string Twitter { get; set; }
        public string Facebook { get; set; }
        public string LinkedIn { get; set; }

        [JsonProperty("Product Interest")]
        public string ProductInterest { get; set; }

        [JsonProperty("Assigned To Rep")]
        public string AssignedToRep { get; set; }
    }

    public class LeadPutValueInput
    {
        [JsonProperty("sal")]
        public string Sal { get; set; }

        [JsonProperty("firstname")]
        public string Firstname { get; set; }

        [JsonProperty("middlename")]
        public string Middlename { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("lastname")]
        public string Lastname { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("addr1")]
        public string Addr1 { get; set; }

        [JsonProperty("addr2")]
        public string Addr2 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postal")]
        public string Postal { get; set; }

        [JsonProperty("email1")]
        public string Email1 { get; set; }

        [JsonProperty("email2")]
        public string Email2 { get; set; }

        [JsonProperty("email3")]
        public string Email3 { get; set; }

        [JsonProperty("email4")]
        public string Email4 { get; set; }

        [JsonProperty("phonetype1")]
        public string Phonetype1 { get; set; }

        [JsonProperty("phone1")]
        public string Phone1 { get; set; }

        [JsonProperty("phonetype2")]
        public string Phonetype2 { get; set; }

        [JsonProperty("phone2")]
        public string Phone2 { get; set; }

        [JsonProperty("phonetype3")]
        public string Phonetype3 { get; set; }

        [JsonProperty("phone3")]
        public string Phone3 { get; set; }

        [JsonProperty("phonetype4")]
        public string Phonetype4 { get; set; }

        [JsonProperty("phone4")]
        public string Phone4 { get; set; }

        [JsonProperty("remark")]
        public string Remark { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("campaign")]
        public string Campaign { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("market")]
        public string Market { get; set; }

        [JsonProperty("territory")]
        public string Territory { get; set; }

        [JsonProperty("salesrep")]
        public string Salesrep { get; set; }

        [JsonProperty("lastcontact")]
        public string Lastcontact { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum typeInput
    {
        C,
        L,
        B
    }

    public class MembersPostValueInput
    {
        [JsonProperty("promoid")]
        public string Promoid { get; set; }

        [JsonProperty("recordtype")]
        public MembersPostValueInputRecordtypeType? Recordtype { get; set; }

        [JsonProperty("recordid")]
        public string Recordid { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MembersPostValueInputRecordtypeType
    {
        C,
        L
    }

    public class MembersGetValueResponse
    {
        [JsonProperty("recordid")]
        public string Recordid { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("fname")]
        public string Fname { get; set; }

        [JsonProperty("lname")]
        public string Lname { get; set; }

        [JsonProperty("addr1")]
        public string Addr1 { get; set; }

        [JsonProperty("addr2")]
        public string Addr2 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zipcode")]
        public string Zipcode { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("email2")]
        public string Email2 { get; set; }

        [JsonProperty("email3")]
        public string Email3 { get; set; }

        [JsonProperty("email4")]
        public string Email4 { get; set; }

        [JsonProperty("phone1")]
        public string Phone1 { get; set; }

        [JsonProperty("phone2")]
        public string Phone2 { get; set; }

        [JsonProperty("phone3")]
        public string Phone3 { get; set; }

        [JsonProperty("phone4")]
        public string Phone4 { get; set; }
    }

    public class MembersPutValueInput
    {
        [JsonProperty("operation")]
        public MembersPutValueInputOperationType? Operation { get; set; }

        [JsonProperty("recordtype")]
        public MembersPutValueInputRecordtypeType? Recordtype { get; set; }

        [JsonProperty("promoid")]
        public string Promoid { get; set; }

        [JsonProperty("recordid")]
        public string Recordid { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MembersPutValueInputOperationType
    {
        [EnumMember(Value = "remove")]
        Remove
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MembersPutValueInputRecordtypeType
    {
        L,
        C
    }

    public class ShippingPostValueInput
    {
        [JsonProperty("orderid")]
        public string Orderid { get; set; }

        [JsonProperty("shipdate")]
        public string Shipdate { get; set; }

        [JsonProperty("carrier")]
        public string Carrier { get; set; }

        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("weight")]
        public double? Weight { get; set; }

        [JsonProperty("packagetype")]
        public string Packagetype { get; set; }

        [JsonProperty("reference1")]
        public string Reference1 { get; set; }

        [JsonProperty("reference2")]
        public string Reference2 { get; set; }

        [JsonProperty("trackingnumber")]
        public string Trackingnumber { get; set; }

        [JsonProperty("trackingurl")]
        public string Trackingurl { get; set; }

        [JsonProperty("shippingcost")]
        public double? Shippingcost { get; set; }

        [JsonProperty("tohistory")]
        public bool? Tohistory { get; set; }
    }

    public class ShippingGetValueResponse
    {
        public string Customer { get; set; }

        [JsonProperty("Order ID")]
        public string OrderId { get; set; }

        [JsonProperty("Model Number")]
        public string ModelNumber { get; set; }
        public string Descrip { get; set; }

        [JsonProperty("Shipped Qty")]
        public string ShippedQty { get; set; }

        [JsonProperty("BoxID")]
        public string BoxId { get; set; }
        public string Tracking { get; set; }

        [JsonProperty("Ship Date")]
        public string ShipDate { get; set; }

        [JsonProperty("Shipped By")]
        public string ShippedBy { get; set; }
        public string SerialData { get; set; }

        [JsonProperty("Ship_Company")]
        public string ShipCompany { get; set; }

        [JsonProperty("Ship_Contact")]
        public string ShipContact { get; set; }

        [JsonProperty("Ship_Addr1")]
        public string ShipAddr1 { get; set; }

        [JsonProperty("Ship_Addr2")]
        public string ShipAddr2 { get; set; }

        [JsonProperty("Ship_City")]
        public string ShipCity { get; set; }

        [JsonProperty("Ship_State")]
        public string ShipState { get; set; }

        [JsonProperty("Ship_ZipCode")]
        public string ShipZipCode { get; set; }

        [JsonProperty("Ship_Phone")]
        public string ShipPhone { get; set; }
        public string Carrier { get; set; }

        [JsonProperty("ShipmentID")]
        public string ShipmentId { get; set; }

        [JsonProperty("ItemID")]
        public string ItemId { get; set; }
    }

    public class ShippingPutValueInput
    {
        [JsonProperty("shipdate")]
        public string Shipdate { get; set; }

        [JsonProperty("carrier")]
        public string Carrier { get; set; }

        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("weight")]
        public double? Weight { get; set; }

        [JsonProperty("packagetype")]
        public string Packagetype { get; set; }

        [JsonProperty("reference1")]
        public string Reference1 { get; set; }

        [JsonProperty("reference2")]
        public string Reference2 { get; set; }

        [JsonProperty("trackingnumber")]
        public string Trackingnumber { get; set; }

        [JsonProperty("trackingurl")]
        public string Trackingurl { get; set; }

        [JsonProperty("shippingcost")]
        public double? Shippingcost { get; set; }
    }

    public class SOPostValueInput
    {
        [JsonProperty("orderid")]
        public string Orderid { get; set; }

        [JsonProperty("orderdate")]
        public string Orderdate { get; set; }

        [JsonProperty("orderdescription")]
        public string Orderdescription { get; set; }

        [JsonProperty("account")]
        public string Account { get; set; }

        [JsonProperty("accountname")]
        public string Accountname { get; set; }

        [JsonProperty("salesrep")]
        public string Salesrep { get; set; }

        [JsonProperty("firstname")]
        public string Firstname { get; set; }

        [JsonProperty("lastname")]
        public string Lastname { get; set; }

        [JsonProperty("billemail")]
        public string Billemail { get; set; }

        [JsonProperty("billaddr1")]
        public string Billaddr1 { get; set; }

        [JsonProperty("billaddr2")]
        public string Billaddr2 { get; set; }

        [JsonProperty("billcity")]
        public string Billcity { get; set; }

        [JsonProperty("billstate")]
        public string Billstate { get; set; }

        [JsonProperty("billzipcode")]
        public string Billzipcode { get; set; }

        [JsonProperty("billcountry")]
        public string Billcountry { get; set; }

        [JsonProperty("billphone")]
        public string Billphone { get; set; }

        [JsonProperty("billfax")]
        public string Billfax { get; set; }

        [JsonProperty("shipcompany")]
        public string Shipcompany { get; set; }

        [JsonProperty("shipcontact")]
        public string Shipcontact { get; set; }

        [JsonProperty("shipaddr1")]
        public string Shipaddr1 { get; set; }

        [JsonProperty("shipaddr2")]
        public string Shipaddr2 { get; set; }

        [JsonProperty("shipcity")]
        public string Shipcity { get; set; }

        [JsonProperty("shipstate")]
        public string Shipstate { get; set; }

        [JsonProperty("shipzipcode")]
        public string Shipzipcode { get; set; }

        [JsonProperty("shipcountry")]
        public string Shipcountry { get; set; }

        [JsonProperty("shipphone")]
        public string Shipphone { get; set; }

        [JsonProperty("shipemail")]
        public string Shipemail { get; set; }

        [JsonProperty("orderstatus")]
        public SOPostValueInputOrderstatusType? Orderstatus { get; set; }

        [JsonProperty("customstatus")]
        public string Customstatus { get; set; }

        [JsonProperty("taxdistrict")]
        public string Taxdistrict { get; set; }

        [JsonProperty("taxrate")]
        public double? Taxrate { get; set; }

        [JsonProperty("campaign")]
        public string Campaign { get; set; }

        [JsonProperty("ordertax")]
        public string Ordertax { get; set; }

        [JsonProperty("shippingcost")]
        public string Shippingcost { get; set; }

        [JsonProperty("shippingmethod")]
        public string Shippingmethod { get; set; }

        [JsonProperty("couponamount")]
        public double? Couponamount { get; set; }

        [JsonProperty("couponcode")]
        public string Couponcode { get; set; }

        [JsonProperty("paymentmethod")]
        public string Paymentmethod { get; set; }

        [JsonProperty("comments")]
        public string Comments { get; set; }

        [JsonProperty("linedata")]
        public SOPostValueInputLinedataTypeItem[] Linedata { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SOPostValueInputOrderstatusType
    {
        [EnumMember(Value = "quote")]
        Quote,
        [EnumMember(Value = "confirmed")]
        Confirmed,
        [EnumMember(Value = "shipping")]
        Shipping,
        [EnumMember(Value = "history")]
        History
    }

    public class SOPostValueInputLinedataTypeItem
    {
        [JsonProperty("qty")]
        public double? Qty { get; set; }

        [JsonProperty("modelno")]
        public string Modelno { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("comments")]
        public string Comments { get; set; }

        [JsonProperty("price")]
        public double? Price { get; set; }

        [JsonProperty("discount")]
        public string Discount { get; set; }
    }

    public class SOGetValueResponse
    {
        [JsonProperty("Order ID")]
        public string OrderId { get; set; }

        [JsonProperty("PROCESSING PHASE")]
        public string PROCESSINGPHASE { get; set; }
        public string Account { get; set; }

        [JsonProperty("Account Name")]
        public string AccountName { get; set; }

        [JsonProperty("Sales Rep")]
        public string SalesRep { get; set; }

        [JsonProperty("Custom Status")]
        public string CustomStatus { get; set; }
        public string Description { get; set; }

        [JsonProperty("Quotation Date")]
        public string QuotationDate { get; set; }

        [JsonProperty("Close Date")]
        public string CloseDate { get; set; }

        [JsonProperty("Ship Date")]
        public string ShipDate { get; set; }

        [JsonProperty("Expiration Date")]
        public string ExpirationDate { get; set; }
        public string Terms { get; set; }

        [JsonProperty("Marketing Campaign")]
        public string MarketingCampaign { get; set; }

        [JsonProperty("Shipping Warehouse")]
        public string ShippingWarehouse { get; set; }
        public string FOB { get; set; }

        [JsonProperty("Deposit Required")]
        public string DepositRequired { get; set; }

        [JsonProperty("Total Weight")]
        public string TotalWeight { get; set; }

        [JsonProperty("Quote Amount")]
        public string QuoteAmount { get; set; }

        [JsonProperty("Partial Shipments OK")]
        public string PartialShipmentsOK { get; set; }

        [JsonProperty("Invoice Shipping")]
        public string InvoiceShipping { get; set; }

        [JsonProperty("IN HISTORY")]
        public string INHISTORY { get; set; }

        [JsonProperty("IS INACTIVE")]
        public string ISINACTIVE { get; set; }

        [JsonProperty("In-Pipeline")]
        public string InPipeline { get; set; }

        [JsonProperty("Tax 1")]
        public string Tax1 { get; set; }

        [JsonProperty("Tax 2")]
        public string Tax2 { get; set; }

        [JsonProperty("Is Template")]
        public string IsTemplate { get; set; }

        [JsonProperty("Template Name")]
        public string TemplateName { get; set; }

        [JsonProperty("Customer PO")]
        public string CustomerPO { get; set; }

        [JsonProperty("Ship To Company")]
        public string ShipToCompany { get; set; }

        [JsonProperty("Ship To Contact")]
        public string ShipToContact { get; set; }

        [JsonProperty("Ship To Addr 1")]
        public string ShipToAddr1 { get; set; }

        [JsonProperty("Ship To Addr 2")]
        public string ShipToAddr2 { get; set; }

        [JsonProperty("Ship To State")]
        public string ShipToState { get; set; }

        [JsonProperty("Ship To Postal Code")]
        public string ShipToPostalCode { get; set; }

        [JsonProperty("Ship To Country")]
        public string ShipToCountry { get; set; }

        [JsonProperty("Ship To Phone")]
        public string ShipToPhone { get; set; }

        [JsonProperty("Ship To EMail")]
        public string ShipToEMail { get; set; }
        public string Residential { get; set; }

        [JsonProperty("Formatted Ship To")]
        public string FormattedShipTo { get; set; }

        [JsonProperty("Paid Amount")]
        public string PaidAmount { get; set; }

        [JsonProperty("Balance Due")]
        public string BalanceDue { get; set; }

        [JsonProperty("QB Invoice Number")]
        public string QBInvoiceNumber { get; set; }

        [JsonProperty("Confirmed Order")]
        public string ConfirmedOrder { get; set; }
        public string Commission { get; set; }
        public string TotalCost { get; set; }
        public string Margin { get; set; }

        [JsonProperty("Project ID")]
        public string ProjectId { get; set; }

        [JsonProperty("Next Appointment")]
        public string NextAppointment { get; set; }

        [JsonProperty("Appointment With")]
        public string AppointmentWith { get; set; }

        [JsonProperty("linedata:")]
        public SOGetValueResponseLinedataTypeItem[] Linedata { get; set; }
    }

    public class SOGetValueResponseLinedataTypeItem
    {
        [JsonProperty("itemid")]
        public string Itemid { get; set; }

        [JsonProperty("orderqty")]
        public string Orderqty { get; set; }

        [JsonProperty("uom")]
        public string Uom { get; set; }

        [JsonProperty("modelno")]
        public string Modelno { get; set; }

        [JsonProperty("descrip")]
        public string Descrip { get; set; }

        [JsonProperty("comments")]
        public string Comments { get; set; }

        [JsonProperty("shippedqty")]
        public string Shippedqty { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("subttl")]
        public string Subttl { get; set; }

        [JsonProperty("total")]
        public string Total { get; set; }
    }

    public class SOPutValueInput
    {
        [JsonProperty("comments")]
        public string Comments { get; set; }

        [JsonProperty("customstatus")]
        public string Customstatus { get; set; }

        [JsonProperty("orderstatus")]
        public SOPutValueInputOrderstatusType? Orderstatus { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SOPutValueInputOrderstatusType
    {
        [EnumMember(Value = "quote")]
        Quote,
        [EnumMember(Value = "confirmed")]
        Confirmed,
        [EnumMember(Value = "shipping")]
        Shipping,
        [EnumMember(Value = "history")]
        History
    }

    public class WorkOrderPostValueInput
    {
        [JsonProperty("fromaddress")]
        public string Fromaddress { get; set; }

        [JsonProperty("firstname")]
        public string Firstname { get; set; }

        [JsonProperty("lastname")]
        public string Lastname { get; set; }

        [JsonProperty("companyname")]
        public string Companyname { get; set; }

        [JsonProperty("billaddr1")]
        public string Billaddr1 { get; set; }

        [JsonProperty("billaddr2")]
        public string Billaddr2 { get; set; }

        [JsonProperty("billcity")]
        public string Billcity { get; set; }

        [JsonProperty("billstate")]
        public string Billstate { get; set; }

        [JsonProperty("billzipcode")]
        public string Billzipcode { get; set; }

        [JsonProperty("billcountry")]
        public string Billcountry { get; set; }

        [JsonProperty("billphone")]
        public string Billphone { get; set; }

        [JsonProperty("billfax")]
        public string Billfax { get; set; }

        [JsonProperty("serviceaddr1")]
        public string Serviceaddr1 { get; set; }

        [JsonProperty("serviceaddr2")]
        public string Serviceaddr2 { get; set; }

        [JsonProperty("servicecity")]
        public string Servicecity { get; set; }

        [JsonProperty("servicestate")]
        public string Servicestate { get; set; }

        [JsonProperty("servicezipcode")]
        public string Servicezipcode { get; set; }

        [JsonProperty("servicecountry")]
        public string Servicecountry { get; set; }

        [JsonProperty("servicephone")]
        public string Servicephone { get; set; }

        [JsonProperty("receiveddate")]
        public string Receiveddate { get; set; }

        [JsonProperty("ponumber")]
        public string Ponumber { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("reasoncode")]
        public string Reasoncode { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("assignedto")]
        public string Assignedto { get; set; }

        [JsonProperty("backup")]
        public string Backup { get; set; }

        [JsonProperty("priority")]
        public WorkOrderPostValueInputPriorityType? Priority { get; set; }

        [JsonProperty("duedate")]
        public string Duedate { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum WorkOrderPostValueInputPriorityType
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "3")]
        _3,
        [EnumMember(Value = "4")]
        _4
    }

    public class WorkOrderGetValueResponse
    {
        [JsonProperty("Work Order Number")]
        public string WorkOrderNumber { get; set; }

        [JsonProperty("IN HISTORY")]
        public string INHISTORY { get; set; }
        public string INACTIVE { get; set; }
        public string Priority { get; set; }

        [JsonProperty("account")]
        public string Account { get; set; }

        [JsonProperty("Customer Name")]
        public string CustomerName { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }
        public string Content { get; set; }

        [JsonProperty("Assigned To")]
        public string AssignedTo { get; set; }

        [JsonProperty("Backup Assignment")]
        public string BackupAssignment { get; set; }

        [JsonProperty("Received Date")]
        public string ReceivedDate { get; set; }

        [JsonProperty("Due By")]
        public string DueBy { get; set; }

        [JsonProperty("Opened-By")]
        public string OpenedBy { get; set; }

        [JsonProperty("CONTRACT ID")]
        public string CONTRACTId { get; set; }
        public string Source { get; set; }

        [JsonProperty("Custom Status")]
        public string CustomStatus { get; set; }

        [JsonProperty("Reason Code")]
        public string ReasonCode { get; set; }

        [JsonProperty("Customer Reference Number")]
        public string CustomerReferenceNumber { get; set; }

        [JsonProperty("Service-To Company")]
        public string ServiceToCompany { get; set; }

        [JsonProperty("Service-To Contact")]
        public string ServiceToContact { get; set; }

        [JsonProperty("Service-To Address Line 1")]
        public string ServiceToAddressLine1 { get; set; }

        [JsonProperty("Service-To Address Line 2")]
        public string ServiceToAddressLine2 { get; set; }

        [JsonProperty("Service-To City")]
        public string ServiceToCity { get; set; }

        [JsonProperty("Service-To State")]
        public string ServiceToState { get; set; }

        [JsonProperty("Service-To Postal Code")]
        public string ServiceToPostalCode { get; set; }

        [JsonProperty("Service-To Phone")]
        public string ServiceToPhone { get; set; }

        [JsonProperty("Service-To Country")]
        public string ServiceToCountry { get; set; }

        [JsonProperty("Service-To County")]
        public string ServiceToCounty { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }

        [JsonProperty("Time-Zone")]
        public string TimeZone { get; set; }

        [JsonProperty("Formatted Service Address")]
        public string FormattedServiceAddress { get; set; }

        [JsonProperty("Created Date")]
        public string CreatedDate { get; set; }

        [JsonProperty("Customer Email")]
        public string CustomerEmail { get; set; }

        [JsonProperty("Customer PO")]
        public string CustomerPO { get; set; }

        [JsonProperty("Service Appointment")]
        public string ServiceAppointment { get; set; }

        [JsonProperty("Project ID")]
        public string ProjectId { get; set; }

        [JsonProperty("Total Charge")]
        public string TotalCharge { get; set; }

        [JsonProperty("Time Spent")]
        public string TimeSpent { get; set; }
    }

    public class WorkOrderPutValueInput
    {
        [JsonProperty("ponumber")]
        public string Ponumber { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("reasoncode")]
        public string Reasoncode { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("assignedto")]
        public string Assignedto { get; set; }

        [JsonProperty("backup")]
        public string Backup { get; set; }

        [JsonProperty("priority")]
        public WorkOrderPutValueInputPriorityType? Priority { get; set; }

        [JsonProperty("duedate")]
        public string Duedate { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("history")]
        public bool? History { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum WorkOrderPutValueInputPriorityType
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "3")]
        _3,
        [EnumMember(Value = "4")]
        _4
    }

    public class NewSalesLeadResponseItem
    {
        [JsonProperty("lead id")]
        public string LeadId { get; set; }
    }

    public class NewMarketingCampaignResponseItem
    {
        [JsonProperty("promoid")]
        public string Promoid { get; set; }
    }

    public class NewMembersLeadsResponseItem
    {
        [JsonProperty("lead id")]
        public string LeadId { get; set; }
    }

    public class NewSalesOrderResponseItem
    {
        [JsonProperty("Order ID")]
        public string OrderId { get; set; }
    }

    public class NewProposalCreatedResponseItem
    {
        [JsonProperty("Quote ID")]
        public string QuoteId { get; set; }
    }

    public class OrderStatusChangedResponseItem
    {
        [JsonProperty("Order ID")]
        public string OrderId { get; set; }
    }

    public class OrderInHistoryResponseItem
    {
        [JsonProperty("Order ID")]
        public string OrderId { get; set; }
    }

    public class OrderInProcessingResponseItem
    {
        [JsonProperty("Order ID")]
        public string OrderId { get; set; }
    }

    public class OrderIsShippingResponseItem
    {
        [JsonProperty("Order ID")]
        public string OrderId { get; set; }
    }

    public class ProposalNeedsApprovalResponseItem
    {
        [JsonProperty("Quote ID")]
        public string QuoteId { get; set; }
    }

    public class WorkOrderClosedResponseItem
    {
        [JsonProperty("Work Order Number")]
        public string WorkOrderNumber { get; set; }
    }

    public class WorkOrderCreatedResponseItem
    {
        [JsonProperty("Work Order Number")]
        public string WorkOrderNumber { get; set; }
    }

    public class WorkOrderPastDueResponseItem
    {
        [JsonProperty("Work Order Number")]
        public string WorkOrderNumber { get; set; }
    }

    public class WorkOrderStatusChangedResponseItem
    {
        [JsonProperty("Work Order Number")]
        public string WorkOrderNumber { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Imprezian;

    public partial class WorkflowManagedActions
    {
        public ImprezianActions Imprezian(string connectionId) => new ImprezianActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ImprezianTriggers Imprezian(string connectionId) => new ImprezianTriggers(connectionId);
    }
}