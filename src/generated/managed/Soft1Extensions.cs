//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Soft1
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Soft1Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IWorkflowAction<ApiConnectionActionConfiguration> Microservice(Expression<Func<MicroserviceBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/custom";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("microservice");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<GetCfncusdocResponse, ApiConnectionActionConfiguration> GetCfncusdoc(Expression<Func<GetCfncusdocBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GetCfncusdocResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/getCFNCUSDOC";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GetCfncusdocResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<GetCfnsupdocResponse, ApiConnectionActionConfiguration> GetCfnsupdoc(Expression<Func<GetCfnsupdocBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GetCfnsupdocResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/getCfnsupdoc";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GetCfnsupdocResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<GetChequeResponse, ApiConnectionActionConfiguration> GetCheque(Expression<Func<GetChequeBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GetChequeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/getCheque";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GetChequeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<GetContactResponse, ApiConnectionActionConfiguration> GetContact(Expression<Func<GetContactBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GetContactResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/getContact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GetContactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<GetCustomerResponse, ApiConnectionActionConfiguration> GetCustomer(Expression<Func<GetCustomerBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GetCustomerResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/getCustomer";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GetCustomerResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<GetDraftEntryResponse, ApiConnectionActionConfiguration> GetDraftEntry(Expression<Func<GetDraftEntryBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GetDraftEntryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/getDraftEntry";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GetDraftEntryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<GetExpenseResponse, ApiConnectionActionConfiguration> GetExpense(Expression<Func<GetExpenseBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GetExpenseResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/getExpense";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GetExpenseResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<GetExpensesDocResponse, ApiConnectionActionConfiguration> GetExpensesDoc(Expression<Func<GetExpensesDocBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GetExpensesDocResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/getExpensesDoc";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GetExpensesDocResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<GetItedocResponse, ApiConnectionActionConfiguration> GetItedoc(Expression<Func<GetItedocBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GetItedocResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/getItedoc";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GetItedocResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<GetItemResponse, ApiConnectionActionConfiguration> GetItem(Expression<Func<GetItemBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GetItemResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/getItem";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GetItemResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<GetProjectResponse, ApiConnectionActionConfiguration> GetProject(Expression<Func<GetProjectBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GetProjectResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/getProject";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GetProjectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<GetPurdocResponse, ApiConnectionActionConfiguration> GetPurdoc(Expression<Func<GetPurdocBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GetPurdocResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/getPurdoc";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GetPurdocResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<GetSaldocResponse, ApiConnectionActionConfiguration> GetSaldoc(Expression<Func<GetSaldocBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GetSaldocResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/getSaldoc";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GetSaldocResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<GetServiceResponse, ApiConnectionActionConfiguration> GetService(Expression<Func<GetServiceBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GetServiceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/getService";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GetServiceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<GetSoemailResponse, ApiConnectionActionConfiguration> GetSoemail(Expression<Func<GetSoemailBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GetSoemailResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/getSoemail";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GetSoemailResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<GetMeetingResponse, ApiConnectionActionConfiguration> GetMeeting(Expression<Func<GetMeetingBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GetMeetingResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/getSomeeting";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GetMeetingResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<GetSotaskResponse, ApiConnectionActionConfiguration> GetSotask(Expression<Func<GetSotaskBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GetSotaskResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/getSotask";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GetSotaskResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<GetSupplierResponse, ApiConnectionActionConfiguration> GetSupplier(Expression<Func<GetSupplierBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GetSupplierResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/getSupplier";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GetSupplierResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<GetSystemParamsResponse, ApiConnectionActionConfiguration> GetSystemParams()
        {
            return new DeferredBodyAction<GetSystemParamsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/getSystemParams";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                callPayload.Body = new GetSystemParamsBodyInput().ToJToken();
                return new ApiConnectionAction<GetSystemParamsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<SetData200response, ApiConnectionActionConfiguration> SetCfncusdoc(Expression<Func<SetCfncusdocBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SetData200response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/setCfncusdoc";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SetData200response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<SetData200response, ApiConnectionActionConfiguration> SetCfnsupdoc(Expression<Func<SetCfnsupdocBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SetData200response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/setCfnsupdoc";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SetData200response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<SetData200response, ApiConnectionActionConfiguration> SetCheque(Expression<Func<SetChequeBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SetData200response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/setCheque";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SetData200response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<SetData200response, ApiConnectionActionConfiguration> SetContact(Expression<Func<SetContactBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SetData200response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/setContact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SetData200response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<SetData200response, ApiConnectionActionConfiguration> SetCustomer(Expression<Func<SetCustomerBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SetData200response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/setCustomer";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SetData200response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<SetData200response, ApiConnectionActionConfiguration> SetDraftEntry(Expression<Func<SetDraftEntryBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SetData200response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/setDraftEntry";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SetData200response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<SetData200response, ApiConnectionActionConfiguration> SetExpense(Expression<Func<SetExpenseBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SetData200response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/setExpense";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SetData200response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<SetData200response, ApiConnectionActionConfiguration> SetExpensesDoc(Expression<Func<SetExpensesDocBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SetData200response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/setExpensesDoc";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SetData200response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<SetData200response, ApiConnectionActionConfiguration> SetItedoc(Expression<Func<SetItedocBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SetData200response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/setItedoc";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SetData200response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<SetData200response, ApiConnectionActionConfiguration> SetItem(Expression<Func<SetItemBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SetData200response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/setItem";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SetData200response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<SetData200response, ApiConnectionActionConfiguration> SetProject(Expression<Func<SetProjectBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SetData200response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/setProject";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SetData200response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<SetData200response, ApiConnectionActionConfiguration> SetPurdoc(Expression<Func<SetPurdocBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SetData200response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/setPurdoc";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SetData200response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<SetData200response, ApiConnectionActionConfiguration> SetSaldoc(Expression<Func<SetSaldocBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SetData200response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/setSaldoc";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SetData200response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<SetData200response, ApiConnectionActionConfiguration> SetService(Expression<Func<SetServiceBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SetData200response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/setService";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SetData200response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<SetData200response, ApiConnectionActionConfiguration> SetSoemail(Expression<Func<SetSoemailBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SetData200response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/setSomail";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SetData200response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<SetData200response, ApiConnectionActionConfiguration> SetMeeting(Expression<Func<SetMeetingBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SetData200response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/setSomeeting";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SetData200response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<SetData200response, ApiConnectionActionConfiguration> SetSotask(Expression<Func<SetSotaskBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SetData200response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/setSotask";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SetData200response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<SetData200response, ApiConnectionActionConfiguration> SetSupplier(Expression<Func<SetSupplierBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SetData200response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/setSupplier";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SetData200response>(callPayload);
            });
        }
    }

    public class Soft1Triggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> Webhook(Expression<Func<WebhookBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("create");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> WebhookOnDelete(Expression<Func<WebhookOnDeleteBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhook/onDelete";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("create");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> WebhookOnInsert(Expression<Func<WebhookOnInsertBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhook/onInsert";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("create");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> WebhookOnUpdate(Expression<Func<WebhookOnUpdateBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhook/onUpdate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("create");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }
    }

    public class MicroserviceBodyInput
    {
        public MicroserviceBodyInput(string body, string endpoint)
        {
            this.Body = body;
            this.Endpoint = endpoint;
        }

        [JsonProperty("body", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Body { get; set; }

        [JsonProperty("endpoint", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Endpoint { get; set; }
    }

    public class GetCfncusdocResponse
    {
        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("remoteKey")]
        public string RemoteKey { get; set; }

        [JsonProperty("data")]
        public GetCfncusdocResponseValueType Value { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("errorcode")]
        public int ErrorCode { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class GetCfncusdocResponseValueType
    {
        [JsonProperty("CARDLINES")]
        public GetCfncusdocResponseValueTypeCardlinesTypeItem[] Cardlines { get; set; }

        [JsonProperty("CASHLINES")]
        public GetCfncusdocResponseValueTypeCashlinesTypeItem[] Cashlines { get; set; }

        [JsonProperty("CFNCUSDOC")]
        public GetCfncusdocResponseValueTypeCollectionsDocumentType CollectionsDocument { get; set; }

        [JsonProperty("CHEQUELINES")]
        public GetCfncusdocResponseValueTypeChequelinesTypeItem[] Chequelines { get; set; }
    }

    public class GetCfncusdocResponseValueTypeCardlinesTypeItem
    {
        [JsonProperty("CRDCARDNUM")]
        public string Crdcardnum { get; set; }

        [JsonProperty("CREDITCARDS")]
        public string Creditcards { get; set; }

        [JsonProperty("LINENUM")]
        public string Linenum { get; set; }

        [JsonProperty("LINEVAL")]
        public string Lineval { get; set; }
    }

    public class GetCfncusdocResponseValueTypeCashlinesTypeItem
    {
        [JsonProperty("LINENUM")]
        public string Linenum { get; set; }

        [JsonProperty("LINEVAL")]
        public string Lineval { get; set; }

        [JsonProperty("SOCURRENCY")]
        public string Socurrency { get; set; }
    }

    public class GetCfncusdocResponseValueTypeCollectionsDocumentType
    {
        [JsonProperty("COLLECTOR")]
        public string Collector { get; set; }

        [JsonProperty("COLLECTOR_PRSNIN_NAME2")]
        public string CollectorPrsninName2 { get; set; }

        [JsonProperty("COMPANY")]
        public string Company { get; set; }

        [JsonProperty("FINCODE")]
        public string Fincode { get; set; }

        [JsonProperty("PRJC")]
        public string Prjc { get; set; }

        [JsonProperty("PRJC_PRJC_NAME")]
        public string PrjcPrjcName { get; set; }

        [JsonProperty("REMARKS")]
        public string Remarks { get; set; }

        [JsonProperty("SALESMAN")]
        public string Salesman { get; set; }

        [JsonProperty("SALESMAN_PRSNIN_NAME2")]
        public string SalesmanPrsninName2 { get; set; }

        [JsonProperty("SERIES")]
        public string Series { get; set; }

        [JsonProperty("SUMAMNT")]
        public string Sumamnt { get; set; }

        [JsonProperty("TRDR")]
        public string Trdr { get; set; }

        [JsonProperty("TRDR_TRDR_CODE")]
        public string TrdrTrdrCode { get; set; }

        [JsonProperty("TRDR_TRDR_NAME")]
        public string TrdrTrdrName { get; set; }

        [JsonProperty("TRNDATE")]
        public string Trndate { get; set; }
    }

    public class GetCfncusdocResponseValueTypeChequelinesTypeItem
    {
        [JsonProperty("CFINALDATE")]
        public string Cfinaldate { get; set; }

        [JsonProperty("CODE")]
        public string Code { get; set; }

        [JsonProperty("CSERIES")]
        public string Cseries { get; set; }

        [JsonProperty("LINENUM")]
        public string Linenum { get; set; }

        [JsonProperty("LINEVAL")]
        public string Lineval { get; set; }

        [JsonProperty("TPRMS")]
        public string Tprms { get; set; }
    }

    public class GetCfncusdocBodyInput
    {
        public GetCfncusdocBodyInput(string key)
        {
            this.Key = key;
        }

        [JsonProperty("FORM")]
        public string Form { get; set; }

        [JsonProperty("KEY", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Key { get; set; }

        [JsonProperty("LOCATEINFO", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Locateinfo { get; set; } = "CARDLINES:CRDCARDNUM,CREDITCARDS,LINENUM,LINEVAL;CASHLINES:LINENUM,LINEVAL,LRATE,SOCURRENCY;CFNCUSDOC:ACNMSK,APPRV,BUSUNITS,COLLECTOR,COLLECTOR_PRSNIN_CODE,COLLECTOR_PRSNIN_NAME2,COMMENTS,COMMENTS1,COMPANY,EXPN,FINCODEG,FINCODE,FINSTATES,FOLDER,INST,INST_INST_CODE,INST_INST_NAME,ISCANCEL,ISPRINT,ORIGIN,PNAMEG,PRJC,PRJC_PRJC_CODE,PRJC_PRJC_NAME,REMARKS,SALESMAN,SALESMAN_PRSNIN_CODE,SALESMAN_PRSNIN_NAME2,SERIES,SHIPDATEG,SUMAMNT,SUMLAMNT,SUMTAMNT,TRDBRANCH,TRDBRANCH_TRDBRANCH_CODE,TRDBRANCH_TRDBRANCH_NAME,TRDR,TRDR_TRDR_AFM,TRDR_TRDR_CODE,TRDR_TRDR_NAME,TRDRS,TRDRS_TRDR_CODE,TRDRS_TRDR_NAME,TRNDATE,TRNDATEG;CHEQUELINES:CCHEQUENUMBER,CFINALDATE,CODE,CSERIES,LINENUM,LINEVAL,TPRMS;VCAPTION:CURRBAL;VOUCHERLINES:LINENUM,LINEVAL,VOUCHER,VOUCHER_VOUCHER_CODE,VOUCHER_VOUCHER_FINALDATE,VOUCHER_VOUCHER_NAME,VOUCHER_VOUCHER_VOUCHERVAL";

        [JsonProperty("MODE", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Mode { get; set; } = "1";

        [JsonProperty("OBJECT", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ObjectEntity { get; set; } = "CFNCUSDOC";

        [JsonProperty("appId", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string AppId { get; set; } = "702";

        [JsonProperty("service", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Service { get; set; } = "getData";
    }

    public class GetCfnsupdocResponse
    {
        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("remoteKey")]
        public string RemoteKey { get; set; }

        [JsonProperty("data")]
        public GetCfnsupdocResponseValueType Value { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("errorcode")]
        public int ErrorCode { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class GetCfnsupdocResponseValueType
    {
        [JsonProperty("CARDLINES")]
        public GetCfnsupdocResponseValueTypeCardlinesTypeItem[] Cardlines { get; set; }

        [JsonProperty("CASHLINES")]
        public GetCfnsupdocResponseValueTypeCashlinesTypeItem[] Cashlines { get; set; }

        [JsonProperty("CFNSUPDOC")]
        public GetCfnsupdocResponseValueTypePaymentsDocumentType PaymentsDocument { get; set; }

        [JsonProperty("CHEQUELINES")]
        public GetCfnsupdocResponseValueTypeChequelinesTypeItem[] Chequelines { get; set; }
    }

    public class GetCfnsupdocResponseValueTypeCardlinesTypeItem
    {
        [JsonProperty("CRDCARDNUM")]
        public string Crdcardnum { get; set; }

        [JsonProperty("CREDITCARDS")]
        public string Creditcards { get; set; }

        [JsonProperty("LINENUM")]
        public string Linenum { get; set; }

        [JsonProperty("LINEVAL")]
        public string Lineval { get; set; }
    }

    public class GetCfnsupdocResponseValueTypeCashlinesTypeItem
    {
        [JsonProperty("LINENUM")]
        public string Linenum { get; set; }

        [JsonProperty("LINEVAL")]
        public string Lineval { get; set; }

        [JsonProperty("SOCURRENCY")]
        public string Socurrency { get; set; }
    }

    public class GetCfnsupdocResponseValueTypePaymentsDocumentType
    {
        [JsonProperty("COMMENTS")]
        public string Reason { get; set; }

        [JsonProperty("COMPANY")]
        public string Company { get; set; }

        [JsonProperty("FINCODE")]
        public string Fincode { get; set; }

        [JsonProperty("PRJC")]
        public string Prjc { get; set; }

        [JsonProperty("PRJC_PRJC_NAME")]
        public string PrjcPrjcName { get; set; }

        [JsonProperty("SERIES")]
        public string Series { get; set; }

        [JsonProperty("SUMAMNT")]
        public string Sumamnt { get; set; }

        [JsonProperty("TRDR")]
        public string Trdr { get; set; }

        [JsonProperty("TRDR_TRDR_ADDRESS")]
        public string TrdrTrdrAddress { get; set; }

        [JsonProperty("TRDR_TRDR_AFM")]
        public string TrdrTrdrAfm { get; set; }

        [JsonProperty("TRDR_TRDR_CODE")]
        public string TrdrTrdrCode { get; set; }

        [JsonProperty("TRDR_TRDR_IRSDATA")]
        public string TrdrTrdrIrsdata { get; set; }

        [JsonProperty("TRDR_TRDR_NAME")]
        public string TrdrTrdrName { get; set; }

        [JsonProperty("TRNDATE")]
        public string Trndate { get; set; }
    }

    public class GetCfnsupdocResponseValueTypeChequelinesTypeItem
    {
        [JsonProperty("CFINALDATE")]
        public string Cfinaldate { get; set; }

        [JsonProperty("CODE")]
        public string Code { get; set; }

        [JsonProperty("CSERIES")]
        public string Cseries { get; set; }

        [JsonProperty("LINENUM")]
        public string Linenum { get; set; }

        [JsonProperty("LINEVAL")]
        public string Lineval { get; set; }

        [JsonProperty("TPRMS")]
        public string Tprms { get; set; }
    }

    public class GetCfnsupdocBodyInput
    {
        public GetCfnsupdocBodyInput(string key)
        {
            this.Key = key;
        }

        [JsonProperty("FORM")]
        public string Form { get; set; }

        [JsonProperty("KEY", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Key { get; set; }

        [JsonProperty("LOCATEINFO", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Locateinfo { get; set; } = "CARDLINES:CRDCARDNUM,CREDITCARDS,LINENUM,LINEVAL;CASHLINES:LINENUM,LINEVAL,LRATE,SOCURRENCY;CFNSUPDOC:ACNMSK,APPRV,BRANCH,BUSUNITS,CMPFINCODE,FINCODE,CMPSERIESNUM,COMMENTS,COMMENTS1,COMPANY,EXPN,FINSTATES,FOLDER,FPRMS,INPAYVAT,INST,INST_INST_CODE,INST_INST_NAME,ISCANCEL,ISPRINT,LRATE,PRJC,PRJC_PRJC_CODE,PRJC_PRJC_NAME,REMARKS,SERIES,SOCASH,SOCURRENCY,SUMAMNT,SUMLAMNT,SUMTAMNT,TFPRMS,TRDBRANCH,TRDBRANCH_TRDBRANCH_CODE,TRDBRANCH_TRDBRANCH_NAME,TRDR,TRDR_TRDR_AFM,TRDR_TRDR_CODE,TRDR_TRDR_NAME,TRDR_TRDR_ADDRESS,TRDR_TRDR_IRSDATA,TRDRRATE,TRDRS,TRDRS_TRDR_CODE,TRDRS_TRDR_NAME,TRNDATE;CHEQUELINES:CCHEQUENUMBER,CFINALDATE,CODE,CSERIES,LINENUM,LINEVAL,TPRMS;";

        [JsonProperty("MODE", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Mode { get; set; } = "1";

        [JsonProperty("OBJECT", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ObjectEntity { get; set; } = "CFNSUPDOC";

        [JsonProperty("appId", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string AppId { get; set; } = "702";

        [JsonProperty("service", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Service { get; set; } = "getData";
    }

    public class GetChequeResponse
    {
        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("remoteKey")]
        public string RemoteKey { get; set; }

        [JsonProperty("data")]
        public GetChequeResponseValueType Value { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("errorcode")]
        public int ErrorCode { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class GetChequeResponseValueType
    {
        [JsonProperty("CHEQUE")]
        public GetChequeResponseValueTypeChequeType Cheque { get; set; }
    }

    public class GetChequeResponseValueTypeChequeType
    {
        [JsonProperty("BANK")]
        public string Bank { get; set; }

        [JsonProperty("BANK_BANK_CODE")]
        public string BankCode { get; set; }

        [JsonProperty("BANK_BANK_NAME")]
        public string BankName { get; set; }

        [JsonProperty("CHEQUEBAL")]
        public string Balance { get; set; }

        [JsonProperty("CHEQUENUMBER")]
        public string Number { get; set; }

        [JsonProperty("CHEQUESTATES")]
        public string State { get; set; }

        [JsonProperty("CHEQUEVAL")]
        public string Value { get; set; }

        [JsonProperty("COMPANY")]
        public string Company { get; set; }

        [JsonProperty("CREATORADDR")]
        public string IssuerAddress { get; set; }

        [JsonProperty("CREATORNAME")]
        public string IssuerName { get; set; }

        [JsonProperty("CREATORPHONE")]
        public string Creatorphone { get; set; }

        [JsonProperty("CRTDATE")]
        public string ReceiptDate { get; set; }

        [JsonProperty("DATEOFS")]
        public string IssueDate { get; set; }

        [JsonProperty("FINALDATE")]
        public string DueDate { get; set; }

        [JsonProperty("HOLDERADDR")]
        public string HolderAddress { get; set; }

        [JsonProperty("HOLDERNAME")]
        public string HolderName { get; set; }

        [JsonProperty("PUBLISHERAFM")]
        public string IssuerTRNo { get; set; }

        [JsonProperty("REMARKS")]
        public string Comments { get; set; }

        [JsonProperty("SERIES")]
        public string Series { get; set; }

        [JsonProperty("SOCURRENCY")]
        public string Currency { get; set; }

        [JsonProperty("TRDRPOSSESSOR_TRDR_CODE")]
        public string HolderCode { get; set; }

        [JsonProperty("TRDRPUBLISHER_TRDR_CODE")]
        public string IssuerCode { get; set; }
    }

    public class GetChequeBodyInput
    {
        public GetChequeBodyInput(string key)
        {
            this.Key = key;
        }

        [JsonProperty("FORM")]
        public string Form { get; set; }

        [JsonProperty("KEY", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Key { get; set; }

        [JsonProperty("LOCATEINFO", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Locateinfo { get; set; } = "CHEQUE:BANK,BANK_BANK_CODE,BANK_BANK_NAME,CHEQUEBAL,CHEQUENUMBER,CHEQUERATE,CHEQUESTATES,CHEQUEVAL,CMPCODE,CMPSERIESNUM,COMPANY,CREATORADDR,CREATORNAME,CREATORPHONE,CRTDATE,DATEOFS,FINALDATE,HOLDERADDR,HOLDERNAME,LCHEQUEBAL,LCHEQUEVAL,OSMODE,PUBLISHERAFM,REMARKS,SERIES,SOCURRENCY,SODTYPEPOSSESSOR,SODTYPEPUBLISHER,TRDRPOSSESSOR,TRDRPOSSESSOR_TRDR_CODE,TRDRPOSSESSOR_TRDR_NAME,TRDRPUBLISHER,TRDRPUBLISHER_TRDR_CODE,TRDRPUBLISHER_TRDR_NAME";

        [JsonProperty("MODE", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Mode { get; set; } = "1";

        [JsonProperty("OBJECT", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ObjectEntity { get; set; } = "CHEQUE";

        [JsonProperty("appId", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string AppId { get; set; } = "702";

        [JsonProperty("service", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Service { get; set; } = "getData";
    }

    public class GetContactResponse
    {
        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("remoteKey")]
        public string RemoteKey { get; set; }

        [JsonProperty("data")]
        public GetContactResponseDataType Data { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("errorcode")]
        public int ErrorCode { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class GetContactResponseDataType
    {
        [JsonProperty("PRSNOUT")]
        public GetContactResponseDataTypeContactType Contact { get; set; }

        [JsonProperty("XTRDOCDATA")]
        public GetContactResponseDataTypeXtrdocdataTypeItem[] Xtrdocdata { get; set; }
    }

    public class GetContactResponseDataTypeContactType
    {
        [JsonProperty("ADDRESS")]
        public string Address { get; set; }

        [JsonProperty("AFM")]
        public string TRNo { get; set; }

        [JsonProperty("AREAS")]
        public string GeographicalArea { get; set; }

        [JsonProperty("BIRTHDATE")]
        public string DateOfBirth { get; set; }

        [JsonProperty("BRANCH")]
        public string Branch { get; set; }

        [JsonProperty("CITY")]
        public string City { get; set; }

        [JsonProperty("CODE")]
        public string Code { get; set; }

        [JsonProperty("COUNTRY")]
        public string Country { get; set; }

        [JsonProperty("DISTRICT")]
        public string District { get; set; }

        [JsonProperty("EMAIL")]
        public string FirstEmail { get; set; }

        [JsonProperty("EMAIL1")]
        public string SecondEmail { get; set; }

        [JsonProperty("FAX")]
        public string Fax { get; set; }

        [JsonProperty("IDENTITYNUM")]
        public string IdCardNo { get; set; }

        [JsonProperty("IRSDATA")]
        public string TaxOffice { get; set; }

        [JsonProperty("ISACTIVE")]
        public string Active { get; set; }

        [JsonProperty("MOBILEPHONE")]
        public string MobileTelephone { get; set; }

        [JsonProperty("NAME")]
        public string Name { get; set; }

        [JsonProperty("NAME2")]
        public string Surname { get; set; }

        [JsonProperty("NATIONALITY")]
        public string Nationality { get; set; }

        [JsonProperty("PHONE1")]
        public string Tel1 { get; set; }

        [JsonProperty("PHONE2")]
        public string Tel2 { get; set; }

        [JsonProperty("PHONEEXT")]
        public string InternalTelephone { get; set; }

        [JsonProperty("PHONELOCAL")]
        public string PersonalTelephone { get; set; }

        [JsonProperty("REMARKS")]
        public string Comments { get; set; }

        [JsonProperty("SOSEX")]
        public string Gender { get; set; }

        [JsonProperty("WEBPAGE")]
        public string WebPage { get; set; }

        [JsonProperty("ZIP")]
        public string Zip { get; set; }
    }

    public class GetContactResponseDataTypeXtrdocdataTypeItem
    {
        [JsonProperty("LINENUM")]
        public string Linenum { get; set; }

        [JsonProperty("NAME")]
        public string Name { get; set; }

        [JsonProperty("SOFNAME")]
        public string Sofname { get; set; }
    }

    public class GetContactBodyInput
    {
        public GetContactBodyInput(string key)
        {
            this.Key = key;
        }

        [JsonProperty("APPID", DefaultValueHandling = DefaultValueHandling.Include)]
        internal int Appid { get; set; } = 702;

        [JsonProperty("FORM")]
        public string Form { get; set; }

        [JsonProperty("KEY", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Key { get; set; }

        [JsonProperty("LOCATEINFO", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Locateinfo { get; set; } = "PRSNOUT:ADDRESS,AFM,AREAS,BIRTHDATE,BRANCH,CITY,CODE,CONSENT,COUNTRY,DISTRICT,DISTRICT1,EMAIL,EMAIL1,FAX,IDENTITYNUM,IRSDATA,ISACTIVE,MOBILEPHONE,NAME,NAME2,NATIONALITY,NOCONSENT,PHONE1,PHONE2,PHONEEXT,PHONELOCAL,PRSNID_PRSNOUT_CODE,REMARKS,SOSEX,SOTITLE,WEBPAGE,ZIP;PRSREL:PRSN1,PRSN1_PRSN_BIRTHDATE,PRSN1_PRSN_CODE,PRSN1_PRSN_MOBILEPHONE,PRSN1_PRSN_NAME,PRSN1_PRSN_NAME2,PRSN1_PRSN_PHONE1,RELPRSN;XTRDOCDATA:LINENUM,SOFNAME";

        [JsonProperty("MODE", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Mode { get; set; } = "1";

        [JsonProperty("OBJECT", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ObjectEntity { get; set; } = "PRSNOUT";

        [JsonProperty("SERVICE", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Service { get; set; } = "getData";
    }

    public class GetCustomerResponse
    {
        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("remoteKey")]
        public string RemoteKey { get; set; }

        [JsonProperty("data")]
        public GetCustomerResponseValueType Value { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("errorcode")]
        public int ErrorCode { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class GetCustomerResponseValueType
    {
        [JsonProperty("CUSTOMER")]
        public GetCustomerResponseValueTypeCustomerType Customer { get; set; }
    }

    public class GetCustomerResponseValueTypeCustomerType
    {
        [JsonProperty("ADDRESS")]
        public string PrimaryAddress { get; set; }

        [JsonProperty("AFM")]
        public string TRNo { get; set; }

        [JsonProperty("AREAS")]
        public string GeographicalArea { get; set; }

        [JsonProperty("CITY")]
        public string City { get; set; }

        [JsonProperty("CODE")]
        public string Code { get; set; }

        [JsonProperty("DISCOUNT")]
        public string Discount { get; set; }

        [JsonProperty("DISTRICT")]
        public string LocationArea { get; set; }

        [JsonProperty("EMAIL")]
        public string EMail { get; set; }

        [JsonProperty("FAX")]
        public string Fax { get; set; }

        [JsonProperty("IRSDATA")]
        public string TaxOffice { get; set; }

        [JsonProperty("ISACTIVE")]
        public string Active { get; set; }

        [JsonProperty("JOBTYPETRD")]
        public string Profession { get; set; }

        [JsonProperty("NAME")]
        public string Name { get; set; }

        [JsonProperty("PHONE01")]
        public string PrimaryTelephone { get; set; }

        [JsonProperty("REMARKS")]
        public string Comments { get; set; }

        [JsonProperty("VATSTS")]
        public string TaxCategory { get; set; }

        [JsonProperty("ZIP")]
        public string Zip { get; set; }
    }

    public class GetCustomerBodyInput
    {
        public GetCustomerBodyInput(string key)
        {
            this.Key = key;
        }

        [JsonProperty("FORM")]
        public string Form { get; set; }

        [JsonProperty("KEY", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Key { get; set; }

        [JsonProperty("LOCATEINFO", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Locateinfo { get; set; } = "CUSTOMER:ADDRESS,AFM,AREAS,CITY,CODE,DISCOUNT,DISTRICT,EMAIL,FAX,IRSDATA,ISACTIVE,JOBTYPETRD,NAME,PHONE01,REMARKS,VATSTS,ZIP";

        [JsonProperty("MODE", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Mode { get; set; } = "1";

        [JsonProperty("OBJECT", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ObjectEntity { get; set; } = "CUSTOMER";

        [JsonProperty("appId", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string AppId { get; set; } = "702";

        [JsonProperty("service", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Service { get; set; } = "getData";
    }

    public class GetDraftEntryResponse
    {
        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("remoteKey")]
        public string RemoteKey { get; set; }

        [JsonProperty("data")]
        public GetDraftEntryResponseValueType Value { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("errorcode")]
        public int ErrorCode { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class GetDraftEntryResponseValueType
    {
        [JsonProperty("SODRAFT")]
        public GetDraftEntryResponseValueTypeSodraftType Sodraft { get; set; }

        [JsonProperty("SODRAFTLNK")]
        public GetDraftEntryResponseValueTypeSodraftlnkType Sodraftlnk { get; set; }
    }

    public class GetDraftEntryResponseValueTypeSodraftType
    {
        [JsonProperty("ADDRESS")]
        public string Address { get; set; }

        [JsonProperty("AFM")]
        public string TRNo { get; set; }

        [JsonProperty("CITY")]
        public string City { get; set; }

        [JsonProperty("CODE")]
        public string Code { get; set; }

        [JsonProperty("COUNTRY")]
        public string Country { get; set; }

        [JsonProperty("DISTRICT")]
        public string Area { get; set; }

        [JsonProperty("DISTRICT1")]
        public string Prefecture { get; set; }

        [JsonProperty("DRAFTTYPE")]
        public string Category { get; set; }

        [JsonProperty("EMAIL")]
        public string CompanyEmail { get; set; }

        [JsonProperty("EMAIL1")]
        public string BusinessEmail { get; set; }

        [JsonProperty("EMAIL2")]
        public string PersonalEmail { get; set; }

        [JsonProperty("IDENTITYNUM")]
        public string IdCardNo { get; set; }

        [JsonProperty("JOBTYPETRD")]
        public string Activity { get; set; }

        [JsonProperty("MOBILEPHONE")]
        public string MobileTelephone { get; set; }

        [JsonProperty("NAMEC")]
        public string NameTitle { get; set; }

        [JsonProperty("NAMEF")]
        public string FirstName { get; set; }

        [JsonProperty("NAMEL")]
        public string Surname { get; set; }

        [JsonProperty("NUMCG")]
        public string Zip { get; set; }

        [JsonProperty("PHONE1")]
        public string BusinessTelephone { get; set; }

        [JsonProperty("PHONEEXT")]
        public string InternalTelephone { get; set; }

        [JsonProperty("PHONELOCAL")]
        public string PersonalTelephone { get; set; }

        [JsonProperty("REMARKS")]
        public string Comments { get; set; }

        [JsonProperty("SOTITLENAME")]
        public string Title { get; set; }

        [JsonProperty("WEBPAGE")]
        public string WebPage { get; set; }

        [JsonProperty("ZIP")]
        public string Zip2 { get; set; }
    }

    public class GetDraftEntryResponseValueTypeSodraftlnkType
    {
        [JsonProperty("BRANCH")]
        public string Branch { get; set; }

        [JsonProperty("BUSUNITS")]
        public string BusinessUnit { get; set; }

        [JsonProperty("DEPART")]
        public string Department { get; set; }

        [JsonProperty("PRJC")]
        public string Project { get; set; }

        [JsonProperty("PRJCLEAD")]
        public string Source { get; set; }
    }

    public class GetDraftEntryBodyInput
    {
        public GetDraftEntryBodyInput(string key)
        {
            this.Key = key;
        }

        [JsonProperty("APPID", DefaultValueHandling = DefaultValueHandling.Include)]
        internal int Appid { get; set; } = 702;

        [JsonProperty("FORM")]
        public string Form { get; set; }

        [JsonProperty("KEY", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Key { get; set; }

        [JsonProperty("LOCATEINFO", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Locateinfo { get; set; } = "SODRAFT:ADDRESS,AFM,CITY,CODE,CONSENT,COUNTRY,DISTRICT,DISTRICT1,DRAFTTYPE,EMAIL,EMAIL1,EMAIL2,FAX,IDENTITYNUM,INSDATE,JOBTYPETRD,MOBILEPHONE,NAME,NAMEC,NAMEF,NAMEL,NOCONSENT,NUMCG,PHONE1,PHONE2,PHONEEXT,PHONELOCAL,REMARKS,SOTITLENAME,WEBPAGE,ZIP;SODRAFTLNK:BRANCH,BUSUNITS,DEPART,PRJC,PRJC_PRJC_CODE,PRJC_PRJC_NAME,PRJCLEAD,PRSNIN,PRSNIN_PRSNIN_CODE,PRSNIN_PRSNIN_NAME2,PRSNOUT,PRSNOUT_PRSNOUT_CODE,PRSNOUT_PRSNOUT_NAME2,TRDR,TRDR_TRDR_CODE,TRDR_TRDR_NAME";

        [JsonProperty("MODE", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Mode { get; set; } = "1";

        [JsonProperty("OBJECT", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ObjectEntity { get; set; } = "SODRAFT";

        [JsonProperty("SERVICE", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Service { get; set; } = "getData";
    }

    public class GetExpenseResponse
    {
        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("remoteKey")]
        public string RemoteKey { get; set; }

        [JsonProperty("data")]
        public GetExpenseResponseValueType Value { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("errorcode")]
        public int ErrorCode { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class GetExpenseResponseValueType
    {
        [JsonProperty("LINEITEM")]
        public GetExpenseResponseValueTypeExpenseType Expense { get; set; }
    }

    public class GetExpenseResponseValueTypeExpenseType
    {
        [JsonProperty("CODE")]
        public string Code { get; set; }

        [JsonProperty("ISACTIVE")]
        public string Active { get; set; }

        [JsonProperty("LISOURCETYPE")]
        public string InvoicingCategory { get; set; }

        [JsonProperty("MTRCATEGORY")]
        public string CommercialCategory { get; set; }

        [JsonProperty("MTRTYPE")]
        public string Type { get; set; }

        [JsonProperty("NAME")]
        public string Description { get; set; }

        [JsonProperty("REMARKS")]
        public string Comments { get; set; }

        [JsonProperty("SOPAYVALUE")]
        public string FeeValue { get; set; }

        [JsonProperty("VAT")]
        public string VatGroup { get; set; }
    }

    public class GetExpenseBodyInput
    {
        public GetExpenseBodyInput(string key)
        {
            this.Key = key;
        }

        [JsonProperty("FORM")]
        public string Form { get; set; }

        [JsonProperty("KEY", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Key { get; set; }

        [JsonProperty("LOCATEINFO", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Locateinfo { get; set; } = "LINEITEM:CODE,ISACTIVE,LISOURCETYPE,MTRCATEGORY,MTRTYPE,NAME,REMARKS,SOPAYVALUE,VAT";

        [JsonProperty("MODE", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Mode { get; set; } = "1";

        [JsonProperty("OBJECT", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ObjectEntity { get; set; } = "LINEITEM";

        [JsonProperty("appId", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string AppId { get; set; } = "702";

        [JsonProperty("service", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Service { get; set; } = "getData";
    }

    public class GetExpensesDocResponse
    {
        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("remoteKey")]
        public string RemoteKey { get; set; }

        [JsonProperty("data")]
        public GetExpensesDocResponseValueType Value { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("errorcode")]
        public int ErrorCode { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class GetExpensesDocResponseValueType
    {
        [JsonProperty("LINLINES")]
        public GetExpensesDocResponseValueTypeLinlinesTypeItem[] Linlines { get; set; }

        [JsonProperty("LINSUPDOC")]
        public GetExpensesDocResponseValueTypeExpensesDocumentType ExpensesDocument { get; set; }
    }

    public class GetExpensesDocResponseValueTypeLinlinesTypeItem
    {
        [JsonProperty("LINENUM")]
        public string LineNumber { get; set; }

        [JsonProperty("LINEVAL")]
        public string LineValue { get; set; }

        [JsonProperty("MTRL")]
        public string Mtrl { get; set; }

        [JsonProperty("MTRL_ITEM_CODE")]
        public string Code { get; set; }

        [JsonProperty("MTRL_ITEM_NAME")]
        public string ItemName { get; set; }

        [JsonProperty("VAT")]
        public string VatId { get; set; }

        [JsonProperty("VATAMNT")]
        public string VatAmount { get; set; }
    }

    public class GetExpensesDocResponseValueTypeExpensesDocumentType
    {
        [JsonProperty("COMPANY")]
        public string Company { get; set; }

        [JsonProperty("FINCODE")]
        public string Fincode { get; set; }

        [JsonProperty("PAYMENT")]
        public string Payment { get; set; }

        [JsonProperty("SERIES")]
        public string Series { get; set; }

        [JsonProperty("SOCURRENCY")]
        public string Currency { get; set; }

        [JsonProperty("SUMAMNT")]
        public string SumAmount { get; set; }

        [JsonProperty("TRDR")]
        public string SupplierId { get; set; }

        [JsonProperty("TRDR_SUPPLIER_AFM")]
        public string SupplierTRNo { get; set; }

        [JsonProperty("TRDR_SUPPLIER_NAME")]
        public string SupplierName { get; set; }

        [JsonProperty("TRNDATE")]
        public string Date { get; set; }

        [JsonProperty("VATAMNT")]
        public string VatAmount { get; set; }
    }

    public class GetExpensesDocBodyInput
    {
        public GetExpensesDocBodyInput(string key)
        {
            this.Key = key;
        }

        [JsonProperty("APPID", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Appid { get; set; } = "702";

        [JsonProperty("FORM")]
        public string Form { get; set; }

        [JsonProperty("KEY", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Key { get; set; }

        [JsonProperty("LOCATEINFO", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Locateinfo { get; set; } = "LINLINES:LINENUM,LINEVAL,MTRL,MTRL_LINEITEM_CODE,MTRL_LINEITEM_NAME,VAT,VATAMNT;LINSUPDOC:COMPANY,ACNMSK,APPRV,BRANCH,BUSUNITS,CASHDEVICE,CBANK,CBANKBRANCH,CMPFINCODE,FINCODE,CMPSERIESNUM,COMMENTS,COMMENTS1,CRCONTROL,EXPN,FINSTATES,FPRMS,GSISFLG,GSISMD,GSISNET,GSISPACKAGES,GSISQTY,GSISVAT,INPAYVAT,INST,INST_INST_CODE,INST_INST_NAME,INTDATE,INTEXPN,INTFDOCTYPE,INTRATE,INTSHIPMENT,INTVAL,INTVAT,ISCANCEL,ISPRINT,ISTRIG,KEPYOHANDMD,KEPYOMD,KEPYOQT,LEXPN,LKEPYOVAL,LNETAMNT,LRATE,LVATAMNT,NETAMNT,NOINTRASTAT,PAYMENT,PRJC,PRJC_PRJC_CODE,PRJC_PRJC_NAME,REMARKS,RSRC,RSRC_RSRC_CODE,RSRC_RSRC_NAME,SALESMAN,SALESMAN_PRSNIN_CODE,SALESMAN_PRSNIN_NAME2,SERIES,SHIPKIND,SHIPMENT,SOCURRENCY,SOPAYCODE,SUMAMNT,SUMLAMNT,SUMTAMNT,TEXPN,TNETAMNT,TRDBRANCH,TRDBRANCH_TRDBRANCH_CODE,TRDBRANCH_TRDBRANCH_NAME,TRDBRANCHS,TRDBRANCHS_TRDBRANCH_CODE,TRDBRANCHS_TRDBRANCH_NAME,TRDR,TRDR_SUPPLIER_AFM,TRDR_SUPPLIER_CHKAFM,TRDR_SUPPLIER_CODE,TRDR_SUPPLIER_NAME,TRDRRATE,TRDRS,TRDRS_TRDR_CODE,TRDRS_TRDR_NAME,TRNDATE,TVATAMNT,VATAMNT,VATPROVISIONS,VATSTS;MTRDOC:RECEIPTCARD,TRUCKS,TRUCKSNO;SUPPLIER:BANK";

        [JsonProperty("MODE", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Mode { get; set; } = "1";

        [JsonProperty("OBJECT", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ObjectEntity { get; set; } = "LINSUPDOC";

        [JsonProperty("SERVICE", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Service { get; set; } = "getData";
    }

    public class GetItedocResponse
    {
        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("remoteKey")]
        public string RemoteKey { get; set; }

        [JsonProperty("data")]
        public GetItedocResponseValueType Value { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("errorcode")]
        public int ErrorCode { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class GetItedocResponseValueType
    {
        [JsonProperty("ITEDOC")]
        public GetItedocResponseValueTypeItedocType Itedoc { get; set; }

        [JsonProperty("ITELINES")]
        public GetItedocResponseValueTypeItelinesTypeItem[] Itelines { get; set; }

        [JsonProperty("MTRDOC")]
        public GetItedocResponseValueTypeMtrdocType Mtrdoc { get; set; }
    }

    public class GetItedocResponseValueTypeItedocType
    {
        [JsonProperty("COMMENTS")]
        public string Reason { get; set; }

        [JsonProperty("COMPANY")]
        public string Company { get; set; }

        [JsonProperty("FINCODE")]
        public string Fincode { get; set; }

        [JsonProperty("REMARKS")]
        public string Comments { get; set; }

        [JsonProperty("SERIES")]
        public string Series { get; set; }

        [JsonProperty("TRNDATE")]
        public string Date { get; set; }
    }

    public class GetItedocResponseValueTypeItelinesTypeItem
    {
        [JsonProperty("DISC1PRC")]
        public string Disc1Prc { get; set; }

        [JsonProperty("LINENUM")]
        public string LineNumber { get; set; }

        [JsonProperty("LINEVAL")]
        public string LineValue { get; set; }

        [JsonProperty("MTRL")]
        public string Mtrl { get; set; }

        [JsonProperty("MTRL_ITEM_CODE")]
        public string Code { get; set; }

        [JsonProperty("MTRL_ITEM_NAME")]
        public string ItemName { get; set; }

        [JsonProperty("PRICE")]
        public string Price { get; set; }

        [JsonProperty("QTY")]
        public string Qty { get; set; }
    }

    public class GetItedocResponseValueTypeMtrdocType
    {
        [JsonProperty("COMPANY")]
        public string Company { get; set; }

        [JsonProperty("DELIVDATE")]
        public string DeliveryDate { get; set; }

        [JsonProperty("SHIPPINGADDR")]
        public string ShippingAddress { get; set; }

        [JsonProperty("WHOUSE")]
        public string Warehouse { get; set; }
    }

    public class GetItedocBodyInput
    {
        public GetItedocBodyInput(string key)
        {
            this.Key = key;
        }

        [JsonProperty("FORM")]
        public string Form { get; set; }

        [JsonProperty("KEY", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Key { get; set; }

        [JsonProperty("LOCATEINFO", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Locateinfo { get; set; } = "ITEDOC:CMPFINCODE,FINCODE,COMMENTS,COMPANY,SERIES,TRNDATE,REMARKS;ITELINES:DISC1PRC,LINENUM,LINEVAL,MTRL,MTRL_ITEM_CODE,MTRL_ITEM_CODE1,MTRL_ITEM_CODE2,MTRL_ITEM_NAME,MTRL_ITEM_NAME1,PRICE,QTY1,QTY;MTRDOC:COMPANY,WHOUSE,SHIPPINGADDR,DELIVDATE";

        [JsonProperty("MODE", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Mode { get; set; } = "1";

        [JsonProperty("OBJECT", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ObjectEntity { get; set; } = "ITEDOC";

        [JsonProperty("appId", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string AppId { get; set; } = "702";

        [JsonProperty("service", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Service { get; set; } = "getData";
    }

    public class GetItemResponse
    {
        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("remoteKey")]
        public string RemoteKey { get; set; }

        [JsonProperty("data")]
        public GetItemResponseValueType Value { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("errorcode")]
        public int ErrorCode { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class GetItemResponseValueType
    {
        [JsonProperty("ITEM")]
        public GetItemResponseValueTypeItemType Item { get; set; }
    }

    public class GetItemResponseValueTypeItemType
    {
        [JsonProperty("CODE")]
        public string Code { get; set; }

        [JsonProperty("ISACTIVE")]
        public string Active { get; set; }

        [JsonProperty("MTRCATEGORY")]
        public string CommercialCategory { get; set; }

        [JsonProperty("MTRGROUP")]
        public string ItemGroup { get; set; }

        [JsonProperty("MTRUNIT1")]
        public string BaseUnitOfMeasure { get; set; }

        [JsonProperty("NAME")]
        public string Description { get; set; }

        [JsonProperty("PRICER")]
        public string RetailPrice { get; set; }

        [JsonProperty("PRICEW")]
        public string WholesalePrice { get; set; }

        [JsonProperty("REMARKS")]
        public string Comments { get; set; }

        [JsonProperty("SODISCOUNT")]
        public string Sodiscount { get; set; }

        [JsonProperty("VAT")]
        public string VatGroup { get; set; }
    }

    public class GetItemBodyInput
    {
        public GetItemBodyInput(string key)
        {
            this.Key = key;
        }

        [JsonProperty("FORM")]
        public string Form { get; set; }

        [JsonProperty("KEY", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Key { get; set; }

        [JsonProperty("LOCATEINFO", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Locateinfo { get; set; } = "ITEM:CODE,ISACTIVE,MTRCATEGORY,MTRGROUP,MTRUNIT1,NAME,PRICER,PRICEW,REMARKS,SODISCOUNT,VAT";

        [JsonProperty("MODE", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Mode { get; set; } = "1";

        [JsonProperty("OBJECT", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ObjectEntity { get; set; } = "ITEM";

        [JsonProperty("appId", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string AppId { get; set; } = "702";

        [JsonProperty("service", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Service { get; set; } = "getData";
    }

    public class GetProjectResponse
    {
        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("data")]
        public GetProjectResponseDataType Data { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("errorcode")]
        public int ErrorCode { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class GetProjectResponseDataType
    {
        [JsonProperty("PRJC")]
        public GetProjectResponseDataTypeProjectType Project { get; set; }

        [JsonProperty("XTRDOCDATA")]
        public GetProjectResponseDataTypeXtrdocdataTypeItem[] Xtrdocdata { get; set; }
    }

    public class GetProjectResponseDataTypeProjectType
    {
        [JsonProperty("ACTSTATUS")]
        public string Actstatus { get; set; }

        [JsonProperty("CODE")]
        public string Code { get; set; }

        [JsonProperty("FINALDATE")]
        public string Finaldate { get; set; }

        [JsonProperty("FROMDATE")]
        public string Fromdate { get; set; }

        [JsonProperty("ISACTIVE")]
        public string Active { get; set; }

        [JsonProperty("NAME")]
        public string Name { get; set; }

        [JsonProperty("PRJC")]
        public string Name2 { get; set; }

        [JsonProperty("PRJCRM")]
        public string Prjcrm { get; set; }

        [JsonProperty("REMARKS")]
        public string Comments { get; set; }
    }

    public class GetProjectResponseDataTypeXtrdocdataTypeItem
    {
        [JsonProperty("LINENUM")]
        public string Linenum { get; set; }

        [JsonProperty("NAME")]
        public string Name { get; set; }

        [JsonProperty("SOFNAME")]
        public string Sofname { get; set; }
    }

    public class GetProjectBodyInput
    {
        public GetProjectBodyInput(string key)
        {
            this.Key = key;
        }

        [JsonProperty("APPID", DefaultValueHandling = DefaultValueHandling.Include)]
        internal int Appid { get; set; } = 702;

        [JsonProperty("FORM")]
        public string Form { get; set; }

        [JsonProperty("KEY", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Key { get; set; }

        [JsonProperty("LOCATEINFO", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Locateinfo { get; set; } = "PRJC:ACTSTATUS,CODE,FINALDATE,FROMDATE,ISACTIVE,NAME,PRJC,PRJCRM,REMARKS;XTRDOCDATA:LINENUM,SOFNAME,NAME";

        [JsonProperty("MODE", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Mode { get; set; } = "1";

        [JsonProperty("OBJECT", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ObjectEntity { get; set; } = "PRJC";

        [JsonProperty("SERVICE", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Service { get; set; } = "getData";
    }

    public class GetPurdocResponse
    {
        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("remoteKey")]
        public string RemoteKey { get; set; }

        [JsonProperty("data")]
        public GetPurdocResponseValueType Value { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("errorcode")]
        public int ErrorCode { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class GetPurdocResponseValueType
    {
        [JsonProperty("ITELINES")]
        public GetPurdocResponseValueTypeItelinesTypeItem[] Itelines { get; set; }

        [JsonProperty("MTRDOC")]
        public GetPurdocResponseValueTypeMtrdocType Mtrdoc { get; set; }

        [JsonProperty("PURDOC")]
        public GetPurdocResponseValueTypePurchasesDocumentType PurchasesDocument { get; set; }

        [JsonProperty("SRVLINES")]
        public GetPurdocResponseValueTypeSrvlinesTypeItem[] Srvlines { get; set; }

        [JsonProperty("VATANAL")]
        public GetPurdocResponseValueTypeVatanalTypeItem[] Vatanal { get; set; }
    }

    public class GetPurdocResponseValueTypeItelinesTypeItem
    {
        [JsonProperty("DISC1PRC")]
        public string Disc1Prc { get; set; }

        [JsonProperty("LINENUM")]
        public string Linenum { get; set; }

        [JsonProperty("LINEVAL")]
        public string Lineval { get; set; }

        [JsonProperty("MTRL")]
        public string Mtrl { get; set; }

        [JsonProperty("MTRL_ITEM_CODE")]
        public string MtrlItemCode { get; set; }

        [JsonProperty("MTRL_ITEM_NAME")]
        public string MtrlItemName { get; set; }

        [JsonProperty("PRICE")]
        public string Price { get; set; }

        [JsonProperty("QTY")]
        public string Qty { get; set; }
    }

    public class GetPurdocResponseValueTypeMtrdocType
    {
        [JsonProperty("COMPANY")]
        public string Company { get; set; }

        [JsonProperty("DELIVDATE")]
        public string DeliveryDate { get; set; }

        [JsonProperty("SHIPPINGADDR")]
        public string ShippingAddress { get; set; }

        [JsonProperty("WHOUSE")]
        public string Warehouse { get; set; }
    }

    public class GetPurdocResponseValueTypePurchasesDocumentType
    {
        [JsonProperty("COMPANY")]
        public string Company { get; set; }

        [JsonProperty("DISC1PRC")]
        public string Disc1Prc { get; set; }

        [JsonProperty("DISC1VAL")]
        public string DiscountValue { get; set; }

        [JsonProperty("EXPN")]
        public string Expenses { get; set; }

        [JsonProperty("FINCODE")]
        public string Fincode { get; set; }

        [JsonProperty("FPRMS")]
        public string Type { get; set; }

        [JsonProperty("NETAMNT")]
        public string NetAmount { get; set; }

        [JsonProperty("PAYMENT")]
        public string Payment { get; set; }

        [JsonProperty("PRJC")]
        public string Prjc { get; set; }

        [JsonProperty("PRJC_PRJC_CODE")]
        public string PrjcPrjcCode { get; set; }

        [JsonProperty("PRJC_PRJC_NAME")]
        public string PrjcPrjcName { get; set; }

        [JsonProperty("REMARKS")]
        public string Comments { get; set; }

        [JsonProperty("SERIES")]
        public string Series { get; set; }

        [JsonProperty("SHIPKIND")]
        public string PurposeOfDelivery { get; set; }

        [JsonProperty("SOCURRENCY")]
        public string Socurrency { get; set; }

        [JsonProperty("SUMAMNT")]
        public string Sumamnt { get; set; }

        [JsonProperty("TRDR")]
        public string Trdr { get; set; }

        [JsonProperty("TRDR_SUPPLIER_ADDRESS")]
        public string SupplierAddress { get; set; }

        [JsonProperty("TRDR_SUPPLIER_AFM")]
        public string TrdrSupplierAfm { get; set; }

        [JsonProperty("TRDR_SUPPLIER_CODE")]
        public string TrdrSupplierCode { get; set; }

        [JsonProperty("TRDR_SUPPLIER_IRSDATA")]
        public string SupplierTaxOffice { get; set; }

        [JsonProperty("TRDR_SUPPLIER_JOBTYPETRD")]
        public string SupplierProfession { get; set; }

        [JsonProperty("TRDR_SUPPLIER_NAME")]
        public string TrdrSupplierName { get; set; }

        [JsonProperty("TRDR_SUPPLIER_PHONE01")]
        public string SupplierPhone { get; set; }

        [JsonProperty("TRNDATE")]
        public string Trndate { get; set; }

        [JsonProperty("VATAMNT")]
        public string Vatamnt { get; set; }
    }

    public class GetPurdocResponseValueTypeSrvlinesTypeItem
    {
        [JsonProperty("DISC1PRC")]
        public string Disc1Prc { get; set; }

        [JsonProperty("LINENUM")]
        public string Linenum { get; set; }

        [JsonProperty("LINEVAL")]
        public string Lineval { get; set; }

        [JsonProperty("MTRL")]
        public string Mtrl { get; set; }

        [JsonProperty("MTRL_SERVICE_CODE")]
        public string MtrlServiceCode { get; set; }

        [JsonProperty("MTRL_SERVICE_NAME")]
        public string MtrlServiceName { get; set; }

        [JsonProperty("PRICE")]
        public string Price { get; set; }

        [JsonProperty("QTY")]
        public string Qty { get; set; }
    }

    public class GetPurdocResponseValueTypeVatanalTypeItem
    {
        [JsonProperty("SUBVAL")]
        public string ValueSubjectToVat { get; set; }

        [JsonProperty("VAT")]
        public string IdAndCategory { get; set; }

        [JsonProperty("VATVAL")]
        public string Value { get; set; }

        [JsonProperty("VAT_VAT_PERCNT")]
        public string Percent { get; set; }
    }

    public class GetPurdocBodyInput
    {
        public GetPurdocBodyInput(string key)
        {
            this.Key = key;
        }

        [JsonProperty("APPID", DefaultValueHandling = DefaultValueHandling.Include)]
        internal int Appid { get; set; } = 702;

        [JsonProperty("FORM")]
        public string Form { get; set; }

        [JsonProperty("KEY", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Key { get; set; }

        [JsonProperty("LOCATEINFO", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Locateinfo { get; set; } = "ITELINES:DISC1PRC,LINENUM,LINEVAL,MTRL,MTRL_ITEM_CODE,MTRL_ITEM_NAME,PRICE,QTY;MTRDOC:WHOUSE,COMPANY,DELIVDATE,SHIPPINGADDR;PURDOC:FINCODE,DISC1PRC,PAYMENT,PRJC,PRJC_PRJC_CODE,PRJC_PRJC_NAME,SERIES,SOCURRENCY,SUMAMNT,TRDR,TRDR_SUPPLIER_AFM,TRDR_SUPPLIER_NAME,TRDR_SUPPLIER_JOBTYPETRD,TRDR_SUPPLIER_ADDRESS,TRDR_SUPPLIER_IRSDATA,TRDR_SUPPLIER_PHONE01,TRNDATE,VATAMNT,DISC1VAL,EXPN,REMARKS,NETAMNT,COMPANY,FPRMS,SHIPKIND;SRVLINES:DISC1PRC,LINENUM,LINEVAL,MTRL,MTRL_SERVICE_CODE,MTRL_SERVICE_NAME,PRICE,QTY;VATANAL:VAT,VATVAL,SUBVAL,VAT_VAT_PERCNT";

        [JsonProperty("MODE", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Mode { get; set; } = "1";

        [JsonProperty("OBJECT", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ObjectEntity { get; set; } = "PURDOC";

        [JsonProperty("SERVICE", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Service { get; set; } = "getData";
    }

    public class GetSaldocResponse
    {
        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("remoteKey")]
        public string RemoteKey { get; set; }

        [JsonProperty("data")]
        public GetSaldocResponseValueType Value { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("errorcode")]
        public int ErrorCode { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class GetSaldocResponseValueType
    {
        [JsonProperty("ITELINES")]
        public GetSaldocResponseValueTypeItelinesTypeItem[] Itelines { get; set; }

        [JsonProperty("MTRDOC")]
        public GetSaldocResponseValueTypeMtrdocType Mtrdoc { get; set; }

        [JsonProperty("SALDOC")]
        public GetSaldocResponseValueTypeSaldocType Saldoc { get; set; }

        [JsonProperty("SRVLINES")]
        public GetSaldocResponseValueTypeSrvlinesTypeItem[] Srvlines { get; set; }

        [JsonProperty("VATANAL")]
        public GetSaldocResponseValueTypeVatanalTypeItem[] Vatanal { get; set; }
    }

    public class GetSaldocResponseValueTypeItelinesTypeItem
    {
        [JsonProperty("DISC1PRC")]
        public string Disc1Prc { get; set; }

        [JsonProperty("LINENUM")]
        public string LineNumber { get; set; }

        [JsonProperty("LINEVAL")]
        public string LineValue { get; set; }

        [JsonProperty("MTRL")]
        public string Mtrl { get; set; }

        [JsonProperty("MTRL_ITEM_CODE")]
        public string Code { get; set; }

        [JsonProperty("MTRL_ITEM_NAME")]
        public string ItemName { get; set; }

        [JsonProperty("PRICE")]
        public string Price { get; set; }

        [JsonProperty("QTY")]
        public string Qty { get; set; }
    }

    public class GetSaldocResponseValueTypeMtrdocType
    {
        [JsonProperty("COMPANY")]
        public string Company { get; set; }

        [JsonProperty("DELIVDATE")]
        public string DeliveryDate { get; set; }

        [JsonProperty("SHIPPINGADDR")]
        public string ShippingAddress { get; set; }

        [JsonProperty("WHOUSE")]
        public string Warehouse { get; set; }
    }

    public class GetSaldocResponseValueTypeSaldocType
    {
        [JsonProperty("COMPANY")]
        public string Company { get; set; }

        [JsonProperty("DISC1PRC")]
        public string Disc1prc { get; set; }

        [JsonProperty("DISC1VAL")]
        public string DiscountValue { get; set; }

        [JsonProperty("EXPN")]
        public string Expenses { get; set; }

        [JsonProperty("FINCODE")]
        public string Fincode { get; set; }

        [JsonProperty("FPRMS")]
        public string Type { get; set; }

        [JsonProperty("NETAMNT")]
        public string NetAmount { get; set; }

        [JsonProperty("PAYMENT")]
        public string Payment { get; set; }

        [JsonProperty("REMARKS")]
        public string Comments { get; set; }

        [JsonProperty("SERIES")]
        public string Series { get; set; }

        [JsonProperty("SHIPKIND")]
        public string PurposeOfDelivery { get; set; }

        [JsonProperty("SOCURRENCY")]
        public string Currency { get; set; }

        [JsonProperty("SUMAMNT")]
        public string SumAmount { get; set; }

        [JsonProperty("TRDR")]
        public string CustomerId { get; set; }

        [JsonProperty("TRDR_CUSTOMER_ADDRESS")]
        public string CustomerAddress { get; set; }

        [JsonProperty("TRDR_CUSTOMER_AFM")]
        public string CustomerTRNo { get; set; }

        [JsonProperty("TRDR_CUSTOMER_CODE")]
        public string CustomerCode { get; set; }

        [JsonProperty("TRDR_CUSTOMER_IRSDATA")]
        public string CustomerTaxOffice { get; set; }

        [JsonProperty("TRDR_CUSTOMER_JOBTYPETRD")]
        public string CustomerProfession { get; set; }

        [JsonProperty("TRDR_CUSTOMER_NAME")]
        public string CustomerName { get; set; }

        [JsonProperty("TRDR_CUSTOMER_PHONE01")]
        public string CustomerPhone { get; set; }

        [JsonProperty("TRNDATE")]
        public string Date { get; set; }

        [JsonProperty("VATAMNT")]
        public string VatAmount { get; set; }
    }

    public class GetSaldocResponseValueTypeSrvlinesTypeItem
    {
        [JsonProperty("DISC1PRC")]
        public string Disc1Prc { get; set; }

        [JsonProperty("LINENUM")]
        public string Linenum { get; set; }

        [JsonProperty("LINEVAL")]
        public string Lineval { get; set; }

        [JsonProperty("MTRL")]
        public string Mtrl { get; set; }

        [JsonProperty("MTRL_SERVICE_CODE")]
        public string MtrlServiceCode { get; set; }

        [JsonProperty("MTRL_SERVICE_NAME")]
        public string MtrlServiceName { get; set; }

        [JsonProperty("PRICE")]
        public string Price { get; set; }

        [JsonProperty("QTY")]
        public string Qty { get; set; }
    }

    public class GetSaldocResponseValueTypeVatanalTypeItem
    {
        [JsonProperty("SUBVAL")]
        public string ValueSubjectToVat { get; set; }

        [JsonProperty("VAT")]
        public string IdAndCategory { get; set; }

        [JsonProperty("VATVAL")]
        public string Value { get; set; }

        [JsonProperty("VAT_VAT_PERCNT")]
        public string Percent { get; set; }
    }

    public class GetSaldocBodyInput
    {
        public GetSaldocBodyInput(string key)
        {
            this.Key = key;
        }

        [JsonProperty("FORM")]
        public string Form { get; set; }

        [JsonProperty("KEY", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Key { get; set; }

        [JsonProperty("LOCATEINFO", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Locateinfo { get; set; } = "ITELINES:DISC1PRC,LINENUM,LINEVAL,MTRL,MTRL_ITEM_CODE,MTRL_ITEM_NAME,PRICE,QTY;MTRDOC:SHIPPINGADDR,WHOUSE;SALDOC:COMPANY,DISC1VAL,SHIPKIND,REMARKS,EXPN,FPRMS,FINCODE,DISC1PRC,NETAMNT,PAYMENT,PRJC,PRJC_PRJC_CODE,PRJC_PRJC_NAME,REMARKS,SERIES,SOCURRENCY,SUMAMNT,TRDR,TRDR_CUSTOMER_AFM,TRDR_CUSTOMER_CODE,TRDR_CUSTOMER_NAME,TRDR_CUSTOMER_PHONE01,TRDR_CUSTOMER_IRSDATA,TRDR_CUSTOMER_ADDRESS,TRDR_CUSTOMER_JOBTYPETRD,TRNDATE,VATAMNT;SRVLINES:DISC1PRC,LINENUM,LINEVAL,MTRL,MTRL_SERVICE_CODE,MTRL_SERVICE_NAME,PRICE,QTY,QTY1;VATANAL:VAT,VATVAL,SUBVAL,VAT_VAT_PERCNT";

        [JsonProperty("MODE", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Mode { get; set; } = "1";

        [JsonProperty("OBJECT", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ObjectEntity { get; set; } = "SALDOC";

        [JsonProperty("appId", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string AppId { get; set; } = "702";

        [JsonProperty("service", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Service { get; set; } = "getData";
    }

    public class GetServiceResponse
    {
        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("remoteKey")]
        public string RemoteKey { get; set; }

        [JsonProperty("data")]
        public GetServiceResponseValueType Value { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("errorcode")]
        public int ErrorCode { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class GetServiceResponseValueType
    {
        [JsonProperty("SERVICE")]
        public GetServiceResponseValueTypeServiceType Service { get; set; }
    }

    public class GetServiceResponseValueTypeServiceType
    {
        [JsonProperty("CODE")]
        public string Code { get; set; }

        [JsonProperty("ISACTIVE")]
        public string Active { get; set; }

        [JsonProperty("MTRCATEGORY")]
        public string CommercialCategory { get; set; }

        [JsonProperty("MTRGROUP")]
        public string ServiceGroup { get; set; }

        [JsonProperty("MTRUNIT1")]
        public string BaseUnitOfMeasure { get; set; }

        [JsonProperty("NAME")]
        public string Description { get; set; }

        [JsonProperty("PRICER")]
        public string RetailPrice { get; set; }

        [JsonProperty("PRICEW")]
        public string WholesalePrice { get; set; }

        [JsonProperty("REMARKS")]
        public string Comments { get; set; }

        [JsonProperty("SODISCOUNT")]
        public string Sodiscount { get; set; }

        [JsonProperty("VAT")]
        public string VatGroup { get; set; }
    }

    public class GetServiceBodyInput
    {
        public GetServiceBodyInput(string key)
        {
            this.Key = key;
        }

        [JsonProperty("FORM")]
        public string Form { get; set; }

        [JsonProperty("KEY", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Key { get; set; }

        [JsonProperty("LOCATEINFO", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Locateinfo { get; set; } = "SERVICE:CODE,ISACTIVE,MTRCATEGORY,MTRGROUP,MTRUNIT1,NAME,PRICER,PRICEW,REMARKS,SODISCOUNT,VAT";

        [JsonProperty("MODE", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Mode { get; set; } = "1";

        [JsonProperty("OBJECT", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ObjectEntity { get; set; } = "SERVICE";

        [JsonProperty("appId", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string AppId { get; set; } = "702";

        [JsonProperty("service", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Service { get; set; } = "getData";
    }

    public class GetSoemailResponse
    {
        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("remoteKey")]
        public string RemoteKey { get; set; }

        [JsonProperty("data")]
        public GetSoemailResponseValueType Value { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("errorcode")]
        public int ErrorCode { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class GetSoemailResponseValueType
    {
        [JsonProperty("SOACTION")]
        public GetSoemailResponseValueTypeEmailTaskType EmailTask { get; set; }

        [JsonProperty("SOMAIL")]
        public GetSoemailResponseValueTypeSomailType Somail { get; set; }

        [JsonProperty("XTRDOCDATA")]
        public GetSoemailResponseValueTypeXtrdocdataTypeItem[] Xtrdocdata { get; set; }
    }

    public class GetSoemailResponseValueTypeEmailTaskType
    {
        [JsonProperty("ACTOR")]
        public string Actor { get; set; }

        [JsonProperty("ACTPRSN")]
        public string OperatorContact { get; set; }

        [JsonProperty("ACTSTATUS")]
        public string Actstatus { get; set; }

        [JsonProperty("COMMENTS")]
        public string Comments { get; set; }

        [JsonProperty("FINALDATE")]
        public string Finaldate { get; set; }

        [JsonProperty("FROMDATE")]
        public string Fromdate { get; set; }

        [JsonProperty("ORDEREDBY")]
        public string Orderedby { get; set; }

        [JsonProperty("ORDPRSN")]
        public string OrderedByContact { get; set; }

        [JsonProperty("PRIORITY")]
        public string Priority { get; set; }

        [JsonProperty("PRJC")]
        public string Project { get; set; }

        [JsonProperty("REMARKS")]
        public string Remarks { get; set; }

        [JsonProperty("SERIES")]
        public string Series { get; set; }

        [JsonProperty("TASKCOMPLETE")]
        public string Taskcomplete { get; set; }

        [JsonProperty("TRDR")]
        public string Trdr { get; set; }

        [JsonProperty("TRDR_GENTRDR_NAME")]
        public string TrdrGentrdrName { get; set; }

        [JsonProperty("TRNDATE")]
        public string Trndate { get; set; }
    }

    public class GetSoemailResponseValueTypeSomailType
    {
        [JsonProperty("FROMADDRESS")]
        public string Fromaddress { get; set; }

        [JsonProperty("FROMNAME")]
        public string Fromname { get; set; }

        [JsonProperty("MAILDATE")]
        public string Maildate { get; set; }

        [JsonProperty("SOBCC")]
        public string Sobcc { get; set; }

        [JsonProperty("SOBODY")]
        public string Sobody { get; set; }

        [JsonProperty("SOCC")]
        public string Socc { get; set; }

        [JsonProperty("SOTO")]
        public string Soto { get; set; }
    }

    public class GetSoemailResponseValueTypeXtrdocdataTypeItem
    {
        [JsonProperty("LINENUM")]
        public string Linenum { get; set; }

        [JsonProperty("NAME")]
        public string Name { get; set; }

        [JsonProperty("SOFNAME")]
        public string Sofname { get; set; }
    }

    public class GetSoemailBodyInput
    {
        public GetSoemailBodyInput(string key)
        {
            this.Key = key;
        }

        [JsonProperty("FORM")]
        public string Form { get; set; }

        [JsonProperty("KEY", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Key { get; set; }

        [JsonProperty("LOCATEINFO", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Locateinfo { get; set; } = "SOACTION:ACCLEVEL,ACTOR,ACTPRSN,ACTPRSN_PRSN_CODE,ACTPRSN_PRSN_NAME,ACTPRSN_PRSN_NAME2,ACTSTATES,ACTSTATUS,ACTTYPE,BOOL01,BOOL02,BOOL03,BOOL04,BRANCH,CMPCODE,CMPSERIESNUM,CNTR,CNTR_CNTR_CODE,CNTR_CNTR_NAME,COMMENTS,INSDATE,DATE01,DATE02,DATE03,DATE04,DATE05,DURATION,FINALDATE,FROMDATE,GQTY,INST,INST_INST_CODE,INST_INST_NAME,ISLEAD,ISRESPONSE,MSODTYPE,MTRL,MTRL_MTRL_CODE,MTRL_MTRL_NAME,NUM01,NUM02,NUM03,NUM04,NUM05,ORDEREDBY,ORDPRSN,ORDPRSN_PRSNIN_CODE,ORDPRSN_PRSNIN_NAME,ORDPRSN_PRSNIN_NAME2,PRIORITY,PRJC,PRJC_PRJC_CODE,PRJC_PRJC_NAME,PRJLINES,PRJLINES_PRJLINES_LINENUM,PRJLINES_PRJLINES_NAME,RSRC,RSRC_RSRC_CODE,RSRC_RSRC_NAME,SERIES,TASKCOMPLETE,TRDBRANCH,TRDBRANCH_TRDBRANCH_CODE,TRDBRANCH_TRDBRANCH_NAME,TRDPRSN,TRDPRSN_PRSN_CODE,TRDPRSN_PRSN_NAME2,TRDR,TRDR_GENTRDR_CODE,TRDR_GENTRDR_NAME,TRNDATE,TSODTYPE,UTBL01,UTBL02,UTBL03,UTBL04,UTBL05,VARCHAR01,VARCHAR02,VARCHAR03,VARCHAR04,VARCHAR05;SOMAIL:FROMADDRESS,FROMNAME,ISNOTDELIV,ISSEND,MAILDATE,NOTDELIVADDR,SOBCC,SOBODY,SOCC,SOTO;XTRDOCDATA:LINENUM,SOFNAME";

        [JsonProperty("MODE", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Mode { get; set; } = "1";

        [JsonProperty("OBJECT", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ObjectEntity { get; set; } = "SOEMAIL";

        [JsonProperty("appId", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string AppId { get; set; } = "702";

        [JsonProperty("service", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Service { get; set; } = "getData";
    }

    public class GetMeetingResponse
    {
        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("remoteKey")]
        public string RemoteKey { get; set; }

        [JsonProperty("data")]
        public GetMeetingResponseValueType Value { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("errorcode")]
        public int ErrorCode { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class GetMeetingResponseValueType
    {
        [JsonProperty("SOACTION")]
        public GetMeetingResponseValueTypeMeetingType Meeting { get; set; }
    }

    public class GetMeetingResponseValueTypeMeetingType
    {
        [JsonProperty("ACTOR")]
        public string Actor { get; set; }

        [JsonProperty("ACTPRSN")]
        public string OperatorContact { get; set; }

        [JsonProperty("ACTSTATUS")]
        public string Actstatus { get; set; }

        [JsonProperty("COMMENTS")]
        public string Comments { get; set; }

        [JsonProperty("FINALDATE")]
        public string Finaldate { get; set; }

        [JsonProperty("FROMDATE")]
        public string Fromdate { get; set; }

        [JsonProperty("ORDEREDBY")]
        public string Orderedby { get; set; }

        [JsonProperty("ORDPRSN")]
        public string OrderedByContact { get; set; }

        [JsonProperty("PRIORITY")]
        public string Priority { get; set; }

        [JsonProperty("PRJC")]
        public string Project { get; set; }

        [JsonProperty("REMARKS")]
        public string Remarks { get; set; }

        [JsonProperty("SERIES")]
        public string Series { get; set; }

        [JsonProperty("TASKCOMPLETE")]
        public string Taskcomplete { get; set; }

        [JsonProperty("TRDR")]
        public string Trdr { get; set; }

        [JsonProperty("TRDR_GENTRDR_NAME")]
        public string TrdrGentrdrName { get; set; }

        [JsonProperty("TRNDATE")]
        public string Trndate { get; set; }
    }

    public class GetMeetingBodyInput
    {
        public GetMeetingBodyInput(string key)
        {
            this.Key = key;
        }

        [JsonProperty("FORM")]
        public string Form { get; set; }

        [JsonProperty("KEY", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Key { get; set; }

        [JsonProperty("LOCATEINFO", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Locateinfo { get; set; } = "ACTLINES:CNTR,CNTR_CNTR_NAME,LINENUM,MTRL,MTRL_MTRL_CODE,MTRL_MTRL_NAME,QTY1,SODTYPE,SRVDEBITTYPE,VALUE;SOACTION:ACCLEVEL,ACTOR,ACTPRSN,ACTPRSN_PRSN_CODE,ACTPRSN_PRSN_NAME,ACTPRSN_PRSN_NAME2,ACTSTATES,ACTSTATUS,ACTTYPE,BOOL01,BOOL02,BOOL03,BOOL04,BRANCH,CMPCODE,CMPSERIESNUM,CNTR,CNTR_CNTR_CODE,CNTR_CNTR_NAME,COMMENTS,DATE01,DATE02,DATE03,DATE04,DATE05,DURATION,FINALDATE,FINDOC,FINDOC_SRVCARD_FINCODE,FROMDATE,GQTY,GVAL,INST,INST_INST_CODE,INST_INST_NAME,ISLEAD,ISRESPONSE,MSODTYPE,MTRL,MTRL_MTRL_CODE,MTRL_MTRL_NAME,NUM01,NUM02,NUM03,NUM04,NUM05,ORDEREDBY,ORDPRSN,ORDPRSN_PRSNIN_CODE,ORDPRSN_PRSNIN_NAME,ORDPRSN_PRSNIN_NAME2,PRIORITY,PRJC,PRJC_PRJC_CODE,PRJC_PRJC_NAME,PRJLINES,PRJLINES_PRJLINES_LINENUM,PRJLINES_PRJLINES_NAME,REMARKS,RSRC,RSRC_RSRC_CODE,RSRC_RSRC_NAME,SERIES,SNCODE,SRVDEBITTYPE,TASKCOMPLETE,TRDBRANCH,TRDBRANCH_TRDBRANCH_CODE,TRDBRANCH_TRDBRANCH_NAME,TRDBRANCHS,TRDBRANCHS_TRDBRANCH_CODE,TRDBRANCHS_TRDBRANCH_NAME,TRDPRSN,TRDPRSN_PRSNOUT_CODE,TRDPRSN_PRSNOUT_NAME2,TRDPRSNS,TRDPRSNS_PRSNOUT_CODE,TRDPRSNS_PRSNOUT_NAME2,TRDR,TRDR_GENTRDR_CODE,TRDR_GENTRDR_NAME,TRDRS,TRDRS_GENTRDR_CODE,TRDRS_GENTRDR_NAME,TRNDATE,TSODTYPE,TSSODTYPE,UTBL01,UTBL02,UTBL03,UTBL04,UTBL05,VARCHAR01,VARCHAR02,VARCHAR03,VARCHAR04,VARCHAR05;VACTRMND:HASREMIND,RMBEFORE,RMDATE;VMTPRSN:PRSN,PRSN_PRSN_CODE,PRSN_PRSN_NAME2,RSRC,RSRC_RSRC_CODE,RSRC_RSRC_NAME,SODTYPE,USERS;XTRDOCDATA:LINENUM,SOFNAME";

        [JsonProperty("MODE", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Mode { get; set; } = "1";

        [JsonProperty("OBJECT", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ObjectEntity { get; set; } = "SOMEETING";

        [JsonProperty("appId", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string AppId { get; set; } = "702";

        [JsonProperty("service", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Service { get; set; } = "getData";
    }

    public class GetSotaskResponse
    {
        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("remoteKey")]
        public string RemoteKey { get; set; }

        [JsonProperty("data")]
        public GetSotaskResponseValueType Value { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("errorcode")]
        public int ErrorCode { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class GetSotaskResponseValueType
    {
        [JsonProperty("SOACTION")]
        public GetSotaskResponseValueTypeTaskObjectType TaskObject { get; set; }
    }

    public class GetSotaskResponseValueTypeTaskObjectType
    {
        [JsonProperty("ACTOR")]
        public string Actor { get; set; }

        [JsonProperty("ACTPRSN")]
        public string OperatorContact { get; set; }

        [JsonProperty("ACTSTATUS")]
        public string Actstatus { get; set; }

        [JsonProperty("COMMENTS")]
        public string Comments { get; set; }

        [JsonProperty("FINALDATE")]
        public string Finaldate { get; set; }

        [JsonProperty("FROMDATE")]
        public string Fromdate { get; set; }

        [JsonProperty("ORDEREDBY")]
        public string Orderedby { get; set; }

        [JsonProperty("ORDPRSN")]
        public string OrderedByContact { get; set; }

        [JsonProperty("PRIORITY")]
        public string Priority { get; set; }

        [JsonProperty("PRJC")]
        public string Project { get; set; }

        [JsonProperty("REMARKS")]
        public string Remarks { get; set; }

        [JsonProperty("SERIES")]
        public string Series { get; set; }

        [JsonProperty("TASKCOMPLETE")]
        public string Taskcomplete { get; set; }

        [JsonProperty("TRDR")]
        public string Trdr { get; set; }

        [JsonProperty("TRDR_GENTRDR_NAME")]
        public string TrdrGentrdrName { get; set; }

        [JsonProperty("TRNDATE")]
        public string Trndate { get; set; }
    }

    public class GetSotaskBodyInput
    {
        public GetSotaskBodyInput(string key)
        {
            this.Key = key;
        }

        [JsonProperty("FORM")]
        public string Form { get; set; }

        [JsonProperty("KEY", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Key { get; set; }

        [JsonProperty("LOCATEINFO", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Locateinfo { get; set; } = "ACTLINES:CNTR,CNTR_CNTR_NAME,LINENUM,MTRL,MTRL_MTRL_CODE,MTRL_MTRL_NAME,QTY1,SODTYPE,SRVDEBITTYPE,VALUE;SOACTION:ACCLEVEL,ACTOR,ACTPRSN,ACTPRSN_PRSN_CODE,ACTPRSN_PRSN_NAME,ACTPRSN_PRSN_NAME2,ACTSTATES,ACTSTATUS,ACTTYPE,BOOL01,BOOL02,BOOL03,BOOL04,BRANCH,CMPCODE,CMPSERIESNUM,CNTR,CNTR_CNTR_CODE,CNTR_CNTR_NAME,COMMENT,COMMENTS,DATE01,DATE02,DATE03,DATE04,DATE05,DURATION,FINALDATE,INSDATE,FINDOC,FINDOC_SRVCARD_FINCODE,FROMDATE,GQTY,GVAL,INST,INST_INST_CODE,INST_INST_NAME,ISLEAD,ISRESPONSE,LIKE,MSODTYPE,MTRL,MTRL_MTRL_CODE,MTRL_MTRL_NAME,NUM01,NUM02,NUM03,NUM04,NUM05,ORDEREDBY,ORDPRSN,ORDPRSN_PRSNIN_CODE,ORDPRSN_PRSNIN_NAME,ORDPRSN_PRSNIN_NAME2,PRIORITY,PRJC,PRJC_PRJC_CODE,PRJC_PRJC_NAME,PRJLINES,PRJLINES_PRJLINES_LINENUM,PRJLINES_PRJLINES_NAME,REMARKS,RSRC,RSRC_RSRC_CODE,RSRC_RSRC_NAME,SERIES,SHARE,SNCODE,SRVDEBITTYPE,TASKCOMPLETE,TRDBRANCH,TRDBRANCH_TRDBRANCH_CODE,TRDBRANCH_TRDBRANCH_NAME,TRDBRANCHS,TRDBRANCHS_TRDBRANCH_CODE,TRDBRANCHS_TRDBRANCH_NAME,TRDPRSN,TRDPRSN_PRSNOUT_CODE,TRDPRSN_PRSNOUT_NAME2,TRDPRSNS,TRDPRSNS_PRSNOUT_CODE,TRDPRSNS_PRSNOUT_NAME2,TRDR,TRDR_GENTRDR_CODE,TRDR_GENTRDR_NAME,TRDRS,TRDRS_GENTRDR_CODE,TRDRS_GENTRDR_NAME,TRNDATE,TSODTYPE,TSSODTYPE,UTBL01,UTBL02,UTBL03,UTBL04,UTBL05,VARCHAR01,VARCHAR02,VARCHAR03,VARCHAR04,VARCHAR05;VACTRMND:HASREMIND,RMBEFORE,RMDATE;VMTPRSN:PRSN,PRSN_PRSN_CODE,PRSN_PRSN_NAME2,RSRC,RSRC_RSRC_CODE,RSRC_RSRC_NAME,SODTYPE,USERS;XTRDOCDATA:LINENUM,SOFNAME";

        [JsonProperty("MODE", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Mode { get; set; } = "1";

        [JsonProperty("OBJECT", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ObjectEntity { get; set; } = "SOTASK";

        [JsonProperty("appId", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string AppId { get; set; } = "702";

        [JsonProperty("service", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Service { get; set; } = "getData";
    }

    public class GetSupplierResponse
    {
        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("remoteKey")]
        public string RemoteKey { get; set; }

        [JsonProperty("data")]
        public GetSupplierResponseValueType Value { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("errorcode")]
        public int ErrorCode { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class GetSupplierResponseValueType
    {
        [JsonProperty("SUPBANKACC")]
        public GetSupplierResponseValueTypeSupbankaccTypeItem[] Supbankacc { get; set; }

        [JsonProperty("SUPPLIER")]
        public GetSupplierResponseValueTypeSupplierType Supplier { get; set; }
    }

    public class GetSupplierResponseValueTypeSupbankaccTypeItem
    {
        [JsonProperty("BANK")]
        public string Bank { get; set; }

        [JsonProperty("BANK_BANK_CODE")]
        public string BankBankCode { get; set; }

        [JsonProperty("IBAN")]
        public string Iban { get; set; }

        [JsonProperty("LINENUM")]
        public string Linenum { get; set; }

        [JsonProperty("REMARKS")]
        public string Remarks { get; set; }
    }

    public class GetSupplierResponseValueTypeSupplierType
    {
        [JsonProperty("ADDRESS")]
        public string Address { get; set; }

        [JsonProperty("AFM")]
        public string Afm { get; set; }

        [JsonProperty("CITY")]
        public string City { get; set; }

        [JsonProperty("CODE")]
        public string Code { get; set; }

        [JsonProperty("DISTRICT")]
        public string District { get; set; }

        [JsonProperty("EMAIL")]
        public string Email { get; set; }

        [JsonProperty("FAX")]
        public string Fax { get; set; }

        [JsonProperty("IRSDATA")]
        public string Irsdata { get; set; }

        [JsonProperty("ISACTIVE")]
        public string Active { get; set; }

        [JsonProperty("JOBTYPETRD")]
        public string Jobtypetrd { get; set; }

        [JsonProperty("NAME")]
        public string Name { get; set; }

        [JsonProperty("PHONE01")]
        public string Phone01 { get; set; }

        [JsonProperty("REMARKS")]
        public string Remarks { get; set; }

        [JsonProperty("VATSTS")]
        public string Vatsts { get; set; }

        [JsonProperty("ZIP")]
        public string Zip { get; set; }
    }

    public class GetSupplierBodyInput
    {
        public GetSupplierBodyInput(string key)
        {
            this.Key = key;
        }

        [JsonProperty("APPID", DefaultValueHandling = DefaultValueHandling.Include)]
        internal int Appid { get; set; } = 702;

        [JsonProperty("FORM")]
        public string Form { get; set; }

        [JsonProperty("KEY", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Key { get; set; }

        [JsonProperty("LOCATEINFO", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Locateinfo { get; set; } = "SUPBANKACC:BANK,BANK_BANK_CODE,BANK_BANK_NAME,IBAN,LINENUM,REMARKS;SUPPLIER:ADDRESS,AFM,CITY,CODE,DISTRICT,EMAIL,FAX,IRSDATA,ISACTIVE,JOBTYPETRD,NAME,PHONE01,REMARKS,VATSTS,ZIP";

        [JsonProperty("MODE", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Mode { get; set; } = "1";

        [JsonProperty("OBJECT", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ObjectEntity { get; set; } = "SUPPLIER";

        [JsonProperty("SERVICE", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Service { get; set; } = "getData";
    }

    public class GetSystemParamsResponse
    {
        [JsonProperty("companyinfo")]
        public GetSystemParamsResponseCompanyType Company { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("errorcode")]
        public int ErrorCode { get; set; }

        [JsonProperty("serialnumber")]
        public string SerialNumber { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class GetSystemParamsResponseCompanyType
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("afm")]
        public string TRNo { get; set; }

        [JsonProperty("branch")]
        public GetSystemParamsResponseCompanyTypeBranchType Branch { get; set; }

        [JsonProperty("district")]
        public string LocationArea { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("image")]
        public string Logo { get; set; }

        [JsonProperty("irsdata")]
        public string TaxOffice { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("phone")]
        public string TelephoneNumber { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }
    }

    public class GetSystemParamsResponseCompanyTypeBranchType
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("district")]
        public string LocationArea { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }
    }

    public class GetSystemParamsBodyInput
    {
        [JsonProperty("appId", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string AppId { get; set; } = "702";

        [JsonProperty("service", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Service { get; set; } = "getSystemParams";
    }

    public class SetData200response
    {
        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("errorcode")]
        public int ErrorCode { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class SetCfncusdocBodyInput
    {
        public SetCfncusdocBodyInput(SetCfncusdocBodyInputValueType value)
        {
            this.Value = value;
        }

        [JsonProperty("APPID", DefaultValueHandling = DefaultValueHandling.Include)]
        internal int Appid { get; set; } = 702;

        [JsonProperty("DATA", DefaultValueHandling = DefaultValueHandling.Include)]
        public SetCfncusdocBodyInputValueType Value { get; set; }

        [JsonProperty("FORM")]
        public string Form { get; set; }

        [JsonProperty("KEY")]
        public string Key { get; set; }

        [JsonProperty("MODE", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Mode { get; set; } = "1";

        [JsonProperty("OBJECT", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ObjectEntity { get; set; } = "CFNCUSDOC";

        [JsonProperty("SERVICE", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Service { get; set; } = "setData";
    }

    public class SetCfncusdocBodyInputValueType
    {
        public SetCfncusdocBodyInputValueType(BodyInputValueTypeCfncusdocType cfncusdoc)
        {
            this.Cfncusdoc = cfncusdoc;
        }

        [JsonProperty("CARDLINES")]
        public BodyInputValueTypeCardlinesTypeItem[] Cardlines { get; set; }

        [JsonProperty("CASHLINES")]
        public SetCfncusdocBodyInputValueTypeCashlinesTypeItem[] Cashlines { get; set; }

        [JsonProperty("CFNCUSDOC", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputValueTypeCfncusdocType Cfncusdoc { get; set; }

        [JsonProperty("CHEQUELINES")]
        public BodyInputValueTypeChequelinesTypeItem[] Chequelines { get; set; }
    }

    public class BodyInputValueTypeCardlinesTypeItem
    {
        [JsonProperty("CRDCARDNUM")]
        public string Crdcardnum { get; set; }

        [JsonProperty("CREDITCARDS")]
        public int? Creditcards { get; set; }

        [JsonProperty("LINENUM")]
        public int? Linenum { get; set; }

        [JsonProperty("LINEVAL")]
        public int? Lineval { get; set; }
    }

    public class SetCfncusdocBodyInputValueTypeCashlinesTypeItem
    {
        [JsonProperty("LINENUM")]
        public int? Linenum { get; set; }

        [JsonProperty("LINEVAL")]
        public int? Lineval { get; set; }
    }

    public class BodyInputValueTypeCfncusdocType
    {
        public BodyInputValueTypeCfncusdocType(string series, string trdr)
        {
            this.Series = series;
            this.Trdr = trdr;
        }

        [JsonProperty("COLLECTOR")]
        public string Collector { get; set; }

        [JsonProperty("COMMENTS")]
        public string Comments { get; set; }

        [JsonProperty("PRJC")]
        public string Project { get; set; }

        [JsonProperty("SALESMAN")]
        public string Salesman { get; set; }

        [JsonProperty("SERIES", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Series { get; set; }

        [JsonProperty("TRDR", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Trdr { get; set; }

        [JsonProperty("TRNDATE")]
        public string Trndate { get; set; }
    }

    public class BodyInputValueTypeChequelinesTypeItem
    {
        [JsonProperty("CCHEQUENUMBER")]
        public string Cchequenumber { get; set; }

        [JsonProperty("CFINALDATE")]
        public string Cfinaldate { get; set; }

        [JsonProperty("CODE")]
        public string Code { get; set; }

        [JsonProperty("CSERIES")]
        public int? Cseries { get; set; }

        [JsonProperty("LINENUM")]
        public int? ChequeLineNumber { get; set; }

        [JsonProperty("LINEVAL")]
        public int? Lineval { get; set; }

        [JsonProperty("TPRMS")]
        public int? ChequeTransactionType { get; set; }
    }

    public class SetCfnsupdocBodyInput
    {
        public SetCfnsupdocBodyInput(SetCfnsupdocBodyInputValueType value)
        {
            this.Value = value;
        }

        [JsonProperty("APPID", DefaultValueHandling = DefaultValueHandling.Include)]
        internal int Appid { get; set; } = 702;

        [JsonProperty("DATA", DefaultValueHandling = DefaultValueHandling.Include)]
        public SetCfnsupdocBodyInputValueType Value { get; set; }

        [JsonProperty("FORM")]
        public string Form { get; set; }

        [JsonProperty("KEY")]
        public string Key { get; set; }

        [JsonProperty("MODE", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Mode { get; set; } = "1";

        [JsonProperty("OBJECT", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ObjectEntity { get; set; } = "CFNSUPDOC";

        [JsonProperty("SERVICE", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Service { get; set; } = "setData";
    }

    public class SetCfnsupdocBodyInputValueType
    {
        public SetCfnsupdocBodyInputValueType(BodyInputValueTypeCfnsupdocType cfnsupdoc)
        {
            this.Cfnsupdoc = cfnsupdoc;
        }

        [JsonProperty("CARDLINES")]
        public BodyInputValueTypeCardlinesTypeItem[] Cardlines { get; set; }

        [JsonProperty("CASHLINES")]
        public SetCfnsupdocBodyInputValueTypeCashlinesTypeItem[] Cashlines { get; set; }

        [JsonProperty("CFNSUPDOC", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputValueTypeCfnsupdocType Cfnsupdoc { get; set; }

        [JsonProperty("CHEQUELINES")]
        public BodyInputValueTypeChequelinesTypeItem[] Chequelines { get; set; }
    }

    public class SetCfnsupdocBodyInputValueTypeCashlinesTypeItem
    {
        [JsonProperty("LINENUM")]
        public int? CashLineNo { get; set; }

        [JsonProperty("LINEVAL")]
        public int? CashLineValue { get; set; }
    }

    public class BodyInputValueTypeCfnsupdocType
    {
        public BodyInputValueTypeCfnsupdocType(string series, string trdr)
        {
            this.Series = series;
            this.Trdr = trdr;
        }

        [JsonProperty("PRJC")]
        public string Prjc { get; set; }

        [JsonProperty("REMARKS")]
        public string Remarks { get; set; }

        [JsonProperty("SERIES", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Series { get; set; }

        [JsonProperty("TRDR", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Trdr { get; set; }

        [JsonProperty("TRNDATE")]
        public string Trndate { get; set; }
    }

    public class SetChequeBodyInput
    {
        public SetChequeBodyInput(SetChequeBodyInputValueType value)
        {
            this.Value = value;
        }

        [JsonProperty("FORM")]
        public string Form { get; set; }

        [JsonProperty("KEY")]
        public string Key { get; set; }

        [JsonProperty("MODE", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Mode { get; set; } = "1";

        [JsonProperty("OBJECT", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ObjectEntity { get; set; } = "CHEQUE";

        [JsonProperty("appId", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string AppId { get; set; } = "702";

        [JsonProperty("data", DefaultValueHandling = DefaultValueHandling.Include)]
        public SetChequeBodyInputValueType Value { get; set; }

        [JsonProperty("service", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Service { get; set; } = "setData";
    }

    public class SetChequeBodyInputValueType
    {
        public SetChequeBodyInputValueType(BodyInputValueTypeChequeType cheque)
        {
            this.Cheque = cheque;
        }

        [JsonProperty("CHEQUE", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputValueTypeChequeType Cheque { get; set; }
    }

    public class BodyInputValueTypeChequeType
    {
        public BodyInputValueTypeChequeType(string balance, string chequeNumber, string status, string value, string issueDate, string dueDate, string series)
        {
            this.Balance = balance;
            this.ChequeNumber = chequeNumber;
            this.Status = status;
            this.Value = value;
            this.IssueDate = issueDate;
            this.DueDate = dueDate;
            this.Series = series;
        }

        [JsonProperty("BANK")]
        public string Bank { get; set; }

        [JsonProperty("CHEQUEBAL", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Balance { get; set; }

        [JsonProperty("CHEQUENUMBER", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ChequeNumber { get; set; }

        [JsonProperty("CHEQUESTATES", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Status { get; set; }

        [JsonProperty("CHEQUEVAL", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Value { get; set; }

        [JsonProperty("CREATORADDR")]
        public string IssuerAddress { get; set; }

        [JsonProperty("CREATORNAME")]
        public string IssuerName { get; set; }

        [JsonProperty("CREATORPHONE")]
        public string IssuerTelephone { get; set; }

        [JsonProperty("CRTDATE")]
        public string ReceiptDate { get; set; }

        [JsonProperty("DATEOFS", DefaultValueHandling = DefaultValueHandling.Include)]
        public string IssueDate { get; set; }

        [JsonProperty("FINALDATE", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DueDate { get; set; }

        [JsonProperty("HOLDERADDR")]
        public string HolderAddress { get; set; }

        [JsonProperty("HOLDERNAME")]
        public string HolderName { get; set; }

        [JsonProperty("PUBLISHERAFM")]
        public string IssuerTRNo { get; set; }

        [JsonProperty("REMARKS")]
        public string Comments { get; set; }

        [JsonProperty("SERIES", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Series { get; set; }
    }

    public class SetContactBodyInput
    {
        public SetContactBodyInput(SetContactBodyInputValueType value)
        {
            this.Value = value;
        }

        [JsonProperty("FORM")]
        public string Form { get; set; }

        [JsonProperty("KEY")]
        public string Key { get; set; }

        [JsonProperty("MODE", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Mode { get; set; } = "1";

        [JsonProperty("OBJECT", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ObjectEntity { get; set; } = "PRSNOUT";

        [JsonProperty("appId", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string AppId { get; set; } = "702";

        [JsonProperty("data", DefaultValueHandling = DefaultValueHandling.Include)]
        public SetContactBodyInputValueType Value { get; set; }

        [JsonProperty("service", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Service { get; set; } = "setData";
    }

    public class SetContactBodyInputValueType
    {
        public SetContactBodyInputValueType(BodyInputValueTypePrsnoutType prsnout)
        {
            this.Prsnout = prsnout;
        }

        [JsonProperty("PRSNOUT", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputValueTypePrsnoutType Prsnout { get; set; }

        [JsonProperty("XTRDOCDATA")]
        public BodyInputValueTypeXtrdocdataTypeItem[] Xtrdocdata { get; set; }
    }

    public class BodyInputValueTypePrsnoutType
    {
        public BodyInputValueTypePrsnoutType(string code, string name)
        {
            this.Code = code;
            this.Name = name;
        }

        [JsonProperty("ADDRESS")]
        public string Address { get; set; }

        [JsonProperty("AFM")]
        public string TRNo { get; set; }

        [JsonProperty("AREAS")]
        public string GeographicalAreas { get; set; }

        [JsonProperty("BIRTHDATE")]
        public string Birthdate { get; set; }

        [JsonProperty("CITY")]
        public string City { get; set; }

        [JsonProperty("CODE", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Code { get; set; }

        [JsonProperty("COUNTRY")]
        public string Country { get; set; }

        [JsonProperty("DISTRICT")]
        public string Area { get; set; }

        [JsonProperty("DISTRICT1")]
        public string Prefecture { get; set; }

        [JsonProperty("EDUCAT")]
        public string EducationLevel { get; set; }

        [JsonProperty("EMAIL")]
        public string Email { get; set; }

        [JsonProperty("EMAIL1")]
        public string Email2 { get; set; }

        [JsonProperty("FAX")]
        public string Fax { get; set; }

        [JsonProperty("IDENTITYNUM")]
        public string IdCardNo { get; set; }

        [JsonProperty("IRSDATA")]
        public string TaxOffice { get; set; }

        [JsonProperty("MOBILEPHONE")]
        public string MobileTelephone { get; set; }

        [JsonProperty("NAME", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("NAME2")]
        public string Surname { get; set; }

        [JsonProperty("NAME3")]
        public string FatherName { get; set; }

        [JsonProperty("NAME4")]
        public string MotherName { get; set; }

        [JsonProperty("NAME5")]
        public string NameOfSpouse { get; set; }

        [JsonProperty("NATIONALITY")]
        public string Nationality { get; set; }

        [JsonProperty("PHONE1")]
        public string Tel1 { get; set; }

        [JsonProperty("PHONE2")]
        public string Tel2 { get; set; }

        [JsonProperty("PHONEEXT")]
        public string InternalTelephone { get; set; }

        [JsonProperty("PHONELOCAL")]
        public string PersonalTelephone { get; set; }

        [JsonProperty("REMARKS")]
        public string Comments { get; set; }

        [JsonProperty("SOSEX")]
        public BodyInputValueTypePrsnoutTypeGenderType? Gender { get; set; }

        [JsonProperty("WEBPAGE")]
        public string WebPage { get; set; }

        [JsonProperty("ZIP")]
        public string Zip { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputValueTypePrsnoutTypeGenderType
    {
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2
    }

    public class BodyInputValueTypeXtrdocdataTypeItem
    {
        [JsonProperty("LINENUM")]
        public string LineNo { get; set; }

        [JsonProperty("NAME")]
        public string Name { get; set; }

        [JsonProperty("SOFNAME")]
        public string Url { get; set; }
    }

    public class SetCustomerBodyInput
    {
        public SetCustomerBodyInput(SetCustomerBodyInputValueType value)
        {
            this.Value = value;
        }

        [JsonProperty("FORM")]
        public string Form { get; set; }

        [JsonProperty("KEY")]
        public string Key { get; set; }

        [JsonProperty("MODE", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Mode { get; set; } = "1";

        [JsonProperty("OBJECT", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ObjectEntity { get; set; } = "CUSTOMER";

        [JsonProperty("appId", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string AppId { get; set; } = "702";

        [JsonProperty("data", DefaultValueHandling = DefaultValueHandling.Include)]
        public SetCustomerBodyInputValueType Value { get; set; }

        [JsonProperty("service", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Service { get; set; } = "setData";
    }

    public class SetCustomerBodyInputValueType
    {
        public SetCustomerBodyInputValueType(BodyInputValueTypeCustomerType customer)
        {
            this.Customer = customer;
        }

        [JsonProperty("CUSTOMER", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputValueTypeCustomerType Customer { get; set; }
    }

    public class BodyInputValueTypeCustomerType
    {
        public BodyInputValueTypeCustomerType(string code, string name)
        {
            this.Code = code;
            this.Name = name;
        }

        [JsonProperty("ADDRESS")]
        public string PrimaryAddress { get; set; }

        [JsonProperty("AFM")]
        public string TRNo { get; set; }

        [JsonProperty("AREAS")]
        public string GeographicalAreas { get; set; }

        [JsonProperty("CITY")]
        public string City { get; set; }

        [JsonProperty("CODE", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Code { get; set; }

        [JsonProperty("DISCOUNT")]
        public int? Discount { get; set; }

        [JsonProperty("DISTRICT")]
        public string LocationArea { get; set; }

        [JsonProperty("EMAIL")]
        public string EMail { get; set; }

        [JsonProperty("FAX")]
        public string Fax { get; set; }

        [JsonProperty("IRSDATA")]
        public string TaxOffice { get; set; }

        [JsonProperty("JOBTYPETRD")]
        public string Profession { get; set; }

        [JsonProperty("NAME", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("PHONE01")]
        public string PrimaryTelephone { get; set; }

        [JsonProperty("REMARKS")]
        public string Comments { get; set; }

        [JsonProperty("VATSTS")]
        public BodyInputValueTypeCustomerTypeTaxCategoryType? TaxCategory { get; set; }

        [JsonProperty("ZIP")]
        public string Zip { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputValueTypeCustomerTypeTaxCategoryType
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2
    }

    public class SetDraftEntryBodyInput
    {
        public SetDraftEntryBodyInput(SetDraftEntryBodyInputValueType value)
        {
            this.Value = value;
        }

        [JsonProperty("FORM")]
        public string Form { get; set; }

        [JsonProperty("KEY")]
        public string Key { get; set; }

        [JsonProperty("MODE", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Mode { get; set; } = "1";

        [JsonProperty("OBJECT", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ObjectEntity { get; set; } = "SODRAFT";

        [JsonProperty("appId", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string AppId { get; set; } = "702";

        [JsonProperty("data", DefaultValueHandling = DefaultValueHandling.Include)]
        public SetDraftEntryBodyInputValueType Value { get; set; }

        [JsonProperty("service", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Service { get; set; } = "setData";
    }

    public class SetDraftEntryBodyInputValueType
    {
        public SetDraftEntryBodyInputValueType(BodyInputValueTypeSodraftType sodraft)
        {
            this.Sodraft = sodraft;
        }

        [JsonProperty("SODRAFT", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputValueTypeSodraftType Sodraft { get; set; }

        [JsonProperty("SODRAFTLNK")]
        public BodyInputValueTypeSodraftlnkType Sodraftlnk { get; set; }
    }

    public class BodyInputValueTypeSodraftType
    {
        public BodyInputValueTypeSodraftType(string code)
        {
            this.Code = code;
        }

        [JsonProperty("ADDRESS")]
        public string Address { get; set; }

        [JsonProperty("AFM")]
        public string TRNo { get; set; }

        [JsonProperty("CITY")]
        public string City { get; set; }

        [JsonProperty("CODE", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Code { get; set; }

        [JsonProperty("COUNTRY")]
        public string Country { get; set; }

        [JsonProperty("DISTRICT")]
        public string Area { get; set; }

        [JsonProperty("DISTRICT1")]
        public string Prefecture { get; set; }

        [JsonProperty("DRAFTTYPE")]
        public string Category { get; set; }

        [JsonProperty("EMAIL")]
        public string CompanyEmail { get; set; }

        [JsonProperty("EMAIL1")]
        public string BusinessEmail { get; set; }

        [JsonProperty("EMAIL2")]
        public string PersonalEmail { get; set; }

        [JsonProperty("IDENTITYNUM")]
        public string IdCardNo { get; set; }

        [JsonProperty("JOBTYPETRD")]
        public string Activity { get; set; }

        [JsonProperty("MOBILEPHONE")]
        public string MobileTelephone { get; set; }

        [JsonProperty("NAMEC")]
        public string NameTitle { get; set; }

        [JsonProperty("NAMEF")]
        public string FirstName { get; set; }

        [JsonProperty("NAMEL")]
        public string Surname { get; set; }

        [JsonProperty("NUMCG")]
        public string Zip { get; set; }

        [JsonProperty("PHONE1")]
        public string BusinessTelephone { get; set; }

        [JsonProperty("PHONEEXT")]
        public string InternalTelephone { get; set; }

        [JsonProperty("PHONELOCAL")]
        public string PersonalTelephone { get; set; }

        [JsonProperty("REMARKS")]
        public string Comments { get; set; }

        [JsonProperty("SOTITLENAME")]
        public string Title { get; set; }

        [JsonProperty("WEBPAGE")]
        public string WebPage { get; set; }

        [JsonProperty("ZIP")]
        public string Zip2 { get; set; }
    }

    public class BodyInputValueTypeSodraftlnkType
    {
        [JsonProperty("BRANCH")]
        public string Branch { get; set; }

        [JsonProperty("BUSUNITS")]
        public string BusinessUnit { get; set; }

        [JsonProperty("DEPART")]
        public string Department { get; set; }

        [JsonProperty("PRJC")]
        public string Project { get; set; }

        [JsonProperty("PRJCLEAD")]
        public string Source { get; set; }
    }

    public class SetExpenseBodyInput
    {
        public SetExpenseBodyInput(SetExpenseBodyInputValueType value)
        {
            this.Value = value;
        }

        [JsonProperty("FORM")]
        public string Form { get; set; }

        [JsonProperty("KEY")]
        public string Key { get; set; }

        [JsonProperty("MODE", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Mode { get; set; } = "1";

        [JsonProperty("OBJECT", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ObjectEntity { get; set; } = "LINEITEM";

        [JsonProperty("appId", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string AppId { get; set; } = "702";

        [JsonProperty("data", DefaultValueHandling = DefaultValueHandling.Include)]
        public SetExpenseBodyInputValueType Value { get; set; }

        [JsonProperty("service", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Service { get; set; } = "setData";
    }

    public class SetExpenseBodyInputValueType
    {
        public SetExpenseBodyInputValueType(BodyInputValueTypeLineitemType lineitem)
        {
            this.Lineitem = lineitem;
        }

        [JsonProperty("LINEITEM", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputValueTypeLineitemType Lineitem { get; set; }
    }

    public class BodyInputValueTypeLineitemType
    {
        public BodyInputValueTypeLineitemType(string code, BodyInputValueTypeLineitemTypeInvoicingCategoryType invoicingCategory, string name, string vatGroup)
        {
            this.Code = code;
            this.InvoicingCategory = invoicingCategory;
            this.Name = name;
            this.VatGroup = vatGroup;
        }

        [JsonProperty("CODE", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Code { get; set; }

        [JsonProperty("LISOURCETYPE", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputValueTypeLineitemTypeInvoicingCategoryType InvoicingCategory { get; set; }

        [JsonProperty("MTRCATEGORY")]
        public string CommercialCategory { get; set; }

        [JsonProperty("MTRTYPE")]
        public BodyInputValueTypeLineitemTypeTypeType? Type { get; set; }

        [JsonProperty("NAME", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("REMARKS")]
        public string Comments { get; set; }

        [JsonProperty("SOPAYVALUE")]
        public BodyInputValueTypeLineitemTypeFeeValueType? FeeValue { get; set; }

        [JsonProperty("VAT", DefaultValueHandling = DefaultValueHandling.Include)]
        public string VatGroup { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputValueTypeLineitemTypeInvoicingCategoryType
    {
        [EnumMember(Value = "12")]
        _12,
        [EnumMember(Value = "13")]
        _13,
        [EnumMember(Value = "14")]
        _14,
        [EnumMember(Value = "15")]
        _15,
        [EnumMember(Value = "16")]
        _16
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputValueTypeLineitemTypeTypeType
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputValueTypeLineitemTypeFeeValueType
    {
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "3")]
        _3,
        [EnumMember(Value = "4")]
        _4,
        [EnumMember(Value = "5")]
        _5
    }

    public class SetExpensesDocBodyInput
    {
        public SetExpensesDocBodyInput(SetExpensesDocBodyInputValueType value)
        {
            this.Value = value;
        }

        [JsonProperty("APPID", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string AppId { get; set; } = "702";

        [JsonProperty("DATA", DefaultValueHandling = DefaultValueHandling.Include)]
        public SetExpensesDocBodyInputValueType Value { get; set; }

        [JsonProperty("FORM")]
        public string Form { get; set; }

        [JsonProperty("KEY")]
        public string Key { get; set; }

        [JsonProperty("MODE", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Mode { get; set; } = "1";

        [JsonProperty("OBJECT", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ObjectEntity { get; set; } = "LINSUPDOC";

        [JsonProperty("SERVICE", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Service { get; set; } = "setData";
    }

    public class SetExpensesDocBodyInputValueType
    {
        public SetExpensesDocBodyInputValueType(BodyInputValueTypeLinsupdocType linsupdoc)
        {
            this.Linsupdoc = linsupdoc;
        }

        [JsonProperty("LINLINES")]
        public BodyInputValueTypeUnnamedTypeItem[] Unnamed { get; set; }

        [JsonProperty("LINSUPDOC", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputValueTypeLinsupdocType Linsupdoc { get; set; }
    }

    public class BodyInputValueTypeUnnamedTypeItem
    {
        [JsonProperty("LINENUM")]
        public string LineNo { get; set; }

        [JsonProperty("LINEVAL")]
        public string LineValue { get; set; }

        [JsonProperty("MTRL")]
        public string Expense { get; set; }

        [JsonProperty("VAT")]
        public string Item { get; set; }
    }

    public class BodyInputValueTypeLinsupdocType
    {
        public BodyInputValueTypeLinsupdocType(string series, string supplier)
        {
            this.Series = series;
            this.Supplier = supplier;
        }

        [JsonProperty("PRJC")]
        public string Project { get; set; }

        [JsonProperty("REMARKS")]
        public string Comments { get; set; }

        [JsonProperty("SERIES", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Series { get; set; }

        [JsonProperty("TRDR", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Supplier { get; set; }

        [JsonProperty("TRNDATE")]
        public string Trndate { get; set; }
    }

    public class SetItedocBodyInput
    {
        public SetItedocBodyInput(SetItedocBodyInputValueType value)
        {
            this.Value = value;
        }

        [JsonProperty("FORM")]
        public string Form { get; set; }

        [JsonProperty("KEY")]
        public string Key { get; set; }

        [JsonProperty("MODE", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Mode { get; set; } = "1";

        [JsonProperty("OBJECT", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ObjectEntity { get; set; } = "ITEDOC";

        [JsonProperty("appId", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string AppId { get; set; } = "702";

        [JsonProperty("data", DefaultValueHandling = DefaultValueHandling.Include)]
        public SetItedocBodyInputValueType Value { get; set; }

        [JsonProperty("service", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Service { get; set; } = "setData";
    }

    public class SetItedocBodyInputValueType
    {
        public SetItedocBodyInputValueType(BodyInputValueTypeItedocType itedoc, BodyInputValueTypeMtrdocType mtrdoc)
        {
            this.Itedoc = itedoc;
            this.Mtrdoc = mtrdoc;
        }

        [JsonProperty("ITEDOC", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputValueTypeItedocType Itedoc { get; set; }

        [JsonProperty("ITELINES")]
        public SetItedocBodyInputValueTypeItelinesTypeItem[] Itelines { get; set; }

        [JsonProperty("MTRDOC", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputValueTypeMtrdocType Mtrdoc { get; set; }
    }

    public class BodyInputValueTypeItedocType
    {
        public BodyInputValueTypeItedocType(string series)
        {
            this.Series = series;
        }

        [JsonProperty("COMMENTS")]
        public string Reason { get; set; }

        [JsonProperty("REMARKS")]
        public string Remarks { get; set; }

        [JsonProperty("SERIES", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Series { get; set; }

        [JsonProperty("TRNDATE")]
        public string Trndate { get; set; }
    }

    public class SetItedocBodyInputValueTypeItelinesTypeItem
    {
        [JsonProperty("DISC1PRC")]
        public string Discount { get; set; }

        [JsonProperty("LINENUM")]
        public string LineNo { get; set; }

        [JsonProperty("LINEVAL")]
        public string LineValue { get; set; }

        [JsonProperty("MTRL")]
        public string Item { get; set; }

        [JsonProperty("PRICE")]
        public string Price { get; set; }

        [JsonProperty("QTY")]
        public string Quantity { get; set; }
    }

    public class BodyInputValueTypeMtrdocType
    {
        public BodyInputValueTypeMtrdocType(string warehouse)
        {
            this.Warehouse = warehouse;
        }

        [JsonProperty("WHOUSE", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Warehouse { get; set; }
    }

    public class SetItemBodyInput
    {
        public SetItemBodyInput(SetItemBodyInputValueType value)
        {
            this.Value = value;
        }

        [JsonProperty("FORM")]
        public string Form { get; set; }

        [JsonProperty("KEY")]
        public string Key { get; set; }

        [JsonProperty("MODE", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Mode { get; set; } = "1";

        [JsonProperty("OBJECT", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ObjectEntity { get; set; } = "ITEM";

        [JsonProperty("appId", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string AppId { get; set; } = "702";

        [JsonProperty("data", DefaultValueHandling = DefaultValueHandling.Include)]
        public SetItemBodyInputValueType Value { get; set; }

        [JsonProperty("service", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Service { get; set; } = "setData";
    }

    public class SetItemBodyInputValueType
    {
        public SetItemBodyInputValueType(BodyInputValueTypeItemType item)
        {
            this.Item = item;
        }

        [JsonProperty("ITEM", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputValueTypeItemType Item { get; set; }
    }

    public class BodyInputValueTypeItemType
    {
        public BodyInputValueTypeItemType(string code, string baseUnitOfMeasure, string name, string vatGroup)
        {
            this.Code = code;
            this.BaseUnitOfMeasure = baseUnitOfMeasure;
            this.Name = name;
            this.VatGroup = vatGroup;
        }

        [JsonProperty("CODE", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Code { get; set; }

        [JsonProperty("MTRCATEGORY")]
        public string CommercialCategory { get; set; }

        [JsonProperty("MTRGROUP")]
        public string ItemGroup { get; set; }

        [JsonProperty("MTRUNIT1", DefaultValueHandling = DefaultValueHandling.Include)]
        public string BaseUnitOfMeasure { get; set; }

        [JsonProperty("NAME", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("PRICER")]
        public string RetailPrice { get; set; }

        [JsonProperty("PRICEW")]
        public string WholesalePrice { get; set; }

        [JsonProperty("REMARKS")]
        public string Comments { get; set; }

        [JsonProperty("SODISCOUNT")]
        public string Discount1 { get; set; }

        [JsonProperty("VAT", DefaultValueHandling = DefaultValueHandling.Include)]
        public string VatGroup { get; set; }
    }

    public class SetProjectBodyInput
    {
        public SetProjectBodyInput(SetProjectBodyInputValueType value)
        {
            this.Value = value;
        }

        [JsonProperty("FORM")]
        public string Form { get; set; }

        [JsonProperty("KEY")]
        public string Key { get; set; }

        [JsonProperty("MODE", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Mode { get; set; } = "1";

        [JsonProperty("OBJECT", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ObjectEntity { get; set; } = "PRJC";

        [JsonProperty("appId", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string AppId { get; set; } = "702";

        [JsonProperty("data", DefaultValueHandling = DefaultValueHandling.Include)]
        public SetProjectBodyInputValueType Value { get; set; }

        [JsonProperty("service", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Service { get; set; } = "setData";
    }

    public class SetProjectBodyInputValueType
    {
        public SetProjectBodyInputValueType(BodyInputValueTypePrjcType prjc)
        {
            this.Prjc = prjc;
        }

        [JsonProperty("PRJC", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputValueTypePrjcType Prjc { get; set; }

        [JsonProperty("XTRDOCDATA")]
        public BodyInputValueTypeXtrdocdataTypeItem[] Xtrdocdata { get; set; }
    }

    public class BodyInputValueTypePrjcType
    {
        public BodyInputValueTypePrjcType(string code, string name)
        {
            this.Code = code;
            this.Name = name;
        }

        [JsonProperty("ACTSTATUS")]
        public BodyInputValueTypePrjcTypeActstatusType? Actstatus { get; set; }

        [JsonProperty("CODE", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Code { get; set; }

        [JsonProperty("FINALDATE")]
        public string Finaldate { get; set; }

        [JsonProperty("FROMDATE")]
        public string Fromdate { get; set; }

        [JsonProperty("NAME", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("PRJCRM")]
        public BodyInputValueTypePrjcTypePrjcrmType? Prjcrm { get; set; }

        [JsonProperty("REMARKS")]
        public string Comments { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputValueTypePrjcTypeActstatusType
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
        _4,
        [EnumMember(Value = "5")]
        _5,
        [EnumMember(Value = "6")]
        _6
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputValueTypePrjcTypePrjcrmType
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2
    }

    public class SetPurdocBodyInput
    {
        public SetPurdocBodyInput(SetPurdocBodyInputValueType value)
        {
            this.Value = value;
        }

        [JsonProperty("APPID", DefaultValueHandling = DefaultValueHandling.Include)]
        internal int Appid { get; set; } = 702;

        [JsonProperty("DATA", DefaultValueHandling = DefaultValueHandling.Include)]
        public SetPurdocBodyInputValueType Value { get; set; }

        [JsonProperty("FORM")]
        public string Form { get; set; }

        [JsonProperty("KEY")]
        public string Key { get; set; }

        [JsonProperty("MODE", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Mode { get; set; } = "1";

        [JsonProperty("OBJECT", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ObjectEntity { get; set; } = "PURDOC";

        [JsonProperty("SERVICE", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Service { get; set; } = "setData";
    }

    public class SetPurdocBodyInputValueType
    {
        public SetPurdocBodyInputValueType(BodyInputValueTypeMtrdocType mtrdoc, BodyInputValueTypePurdocType purdoc)
        {
            this.Mtrdoc = mtrdoc;
            this.Purdoc = purdoc;
        }

        [JsonProperty("ITELINES")]
        public SetPurdocBodyInputValueTypeItelinesTypeItem[] Itelines { get; set; }

        [JsonProperty("MTRDOC", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputValueTypeMtrdocType Mtrdoc { get; set; }

        [JsonProperty("PURDOC", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputValueTypePurdocType Purdoc { get; set; }

        [JsonProperty("SRVLINES")]
        public BodyInputValueTypeSrvlinesTypeItem[] Srvlines { get; set; }
    }

    public class SetPurdocBodyInputValueTypeItelinesTypeItem
    {
        [JsonProperty("DISC1PRC")]
        public int? Disc1Prc { get; set; }

        [JsonProperty("LINENUM")]
        public string LineNo { get; set; }

        [JsonProperty("LINEVAL")]
        public string LineValue { get; set; }

        [JsonProperty("MTRL")]
        public string Mtrl { get; set; }

        [JsonProperty("PRICE")]
        public string Price { get; set; }

        [JsonProperty("QTY")]
        public int? Qty { get; set; }
    }

    public class BodyInputValueTypePurdocType
    {
        public BodyInputValueTypePurdocType(string series, string socurrency, string trdr)
        {
            this.Series = series;
            this.Socurrency = socurrency;
            this.Trdr = trdr;
        }

        [JsonProperty("DISC1PRC")]
        public string Disc1Prc { get; set; }

        [JsonProperty("PAYMENT")]
        public string Payment { get; set; }

        [JsonProperty("PRJC")]
        public string Prjc { get; set; }

        [JsonProperty("REMARKS")]
        public string Remarks { get; set; }

        [JsonProperty("SERIES", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Series { get; set; }

        [JsonProperty("SOCURRENCY", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Socurrency { get; set; }

        [JsonProperty("SUMAMNT")]
        public string Sumamnt { get; set; }

        [JsonProperty("TRDR", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Trdr { get; set; }

        [JsonProperty("TRNDATE")]
        public string Trndate { get; set; }
    }

    public class BodyInputValueTypeSrvlinesTypeItem
    {
        [JsonProperty("DISC1PRC")]
        public int? Disc1Prc { get; set; }

        [JsonProperty("LINENUM")]
        public string LineNo { get; set; }

        [JsonProperty("LINEVAL")]
        public string LineValue { get; set; }

        [JsonProperty("MTRL")]
        public string Mtrl { get; set; }

        [JsonProperty("PRICE")]
        public string Price { get; set; }

        [JsonProperty("QTY")]
        public int? Qty { get; set; }
    }

    public class SetSaldocBodyInput
    {
        public SetSaldocBodyInput(SetSaldocBodyInputValueType value)
        {
            this.Value = value;
        }

        [JsonProperty("FORM")]
        public string Form { get; set; }

        [JsonProperty("KEY")]
        public string Key { get; set; }

        [JsonProperty("MODE", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Mode { get; set; } = "1";

        [JsonProperty("OBJECT", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ObjectEntity { get; set; } = "SALDOC";

        [JsonProperty("appId", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string AppId { get; set; } = "702";

        [JsonProperty("data", DefaultValueHandling = DefaultValueHandling.Include)]
        public SetSaldocBodyInputValueType Value { get; set; }

        [JsonProperty("service", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Service { get; set; } = "setData";
    }

    public class SetSaldocBodyInputValueType
    {
        public SetSaldocBodyInputValueType(BodyInputValueTypeMtrdocType mtrdoc, BodyInputValueTypeSaldocType saldoc)
        {
            this.Mtrdoc = mtrdoc;
            this.Saldoc = saldoc;
        }

        [JsonProperty("ITELINES")]
        public SetItedocBodyInputValueTypeItelinesTypeItem[] Itelines { get; set; }

        [JsonProperty("MTRDOC", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputValueTypeMtrdocType Mtrdoc { get; set; }

        [JsonProperty("SALDOC", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputValueTypeSaldocType Saldoc { get; set; }

        [JsonProperty("SRVLINES")]
        public BodyInputValueTypeSrvlinesTypeItem[] Srvlines { get; set; }
    }

    public class BodyInputValueTypeSaldocType
    {
        public BodyInputValueTypeSaldocType(string payment, string series, string currency, string customer)
        {
            this.Payment = payment;
            this.Series = series;
            this.Currency = currency;
            this.Customer = customer;
        }

        [JsonProperty("DISC1PRC")]
        public string Discount { get; set; }

        [JsonProperty("DISC1VAL")]
        public string DiscountValue { get; set; }

        [JsonProperty("NETAMNT")]
        public string NetAmount { get; set; }

        [JsonProperty("PAYMENT", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Payment { get; set; }

        [JsonProperty("PRJC")]
        public string Project { get; set; }

        [JsonProperty("REMARKS")]
        public string Comments { get; set; }

        [JsonProperty("SERIES", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Series { get; set; }

        [JsonProperty("SOCURRENCY", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Currency { get; set; }

        [JsonProperty("SUMAMNT")]
        public string Total { get; set; }

        [JsonProperty("TRDR", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Customer { get; set; }

        [JsonProperty("TRNDATE")]
        public string Trndate { get; set; }

        [JsonProperty("VATAMNT")]
        public string Vat { get; set; }
    }

    public class SetServiceBodyInput
    {
        public SetServiceBodyInput(SetServiceBodyInputValueType value)
        {
            this.Value = value;
        }

        [JsonProperty("FORM")]
        public string Form { get; set; }

        [JsonProperty("KEY")]
        public string Key { get; set; }

        [JsonProperty("MODE", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Mode { get; set; } = "1";

        [JsonProperty("OBJECT", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ObjectEntity { get; set; } = "SERVICE";

        [JsonProperty("appId", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string AppId { get; set; } = "702";

        [JsonProperty("data", DefaultValueHandling = DefaultValueHandling.Include)]
        public SetServiceBodyInputValueType Value { get; set; }

        [JsonProperty("service", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Service { get; set; } = "setData";
    }

    public class SetServiceBodyInputValueType
    {
        public SetServiceBodyInputValueType(BodyInputValueTypeServiceType service)
        {
            this.Service = service;
        }

        [JsonProperty("SERVICE", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputValueTypeServiceType Service { get; set; }
    }

    public class BodyInputValueTypeServiceType
    {
        public BodyInputValueTypeServiceType(string code, string baseUnitOfMeasure, string name, string vatGroup)
        {
            this.Code = code;
            this.BaseUnitOfMeasure = baseUnitOfMeasure;
            this.Name = name;
            this.VatGroup = vatGroup;
        }

        [JsonProperty("CODE", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Code { get; set; }

        [JsonProperty("MTRCATEGORY")]
        public string CommercialCategory { get; set; }

        [JsonProperty("MTRGROUP")]
        public string ServiceGroup { get; set; }

        [JsonProperty("MTRUNIT1", DefaultValueHandling = DefaultValueHandling.Include)]
        public string BaseUnitOfMeasure { get; set; }

        [JsonProperty("NAME", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("PRICER")]
        public string RetailPrice { get; set; }

        [JsonProperty("PRICEW")]
        public string WholesalePrice { get; set; }

        [JsonProperty("REMARKS")]
        public string Comments { get; set; }

        [JsonProperty("SODISCOUNT")]
        public string Discount1 { get; set; }

        [JsonProperty("VAT", DefaultValueHandling = DefaultValueHandling.Include)]
        public string VatGroup { get; set; }
    }

    public class SetSoemailBodyInput
    {
        public SetSoemailBodyInput(SetSoemailBodyInputValueType value)
        {
            this.Value = value;
        }

        [JsonProperty("APPID", DefaultValueHandling = DefaultValueHandling.Include)]
        internal int Appid { get; set; } = 702;

        [JsonProperty("DATA", DefaultValueHandling = DefaultValueHandling.Include)]
        public SetSoemailBodyInputValueType Value { get; set; }

        [JsonProperty("FORM")]
        public string Form { get; set; }

        [JsonProperty("KEY")]
        public string Key { get; set; }

        [JsonProperty("MODE", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Mode { get; set; } = "1";

        [JsonProperty("OBJECT", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ObjectEntity { get; set; } = "SOEMAIL";

        [JsonProperty("SERVICE", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Service { get; set; } = "setData";
    }

    public class SetSoemailBodyInputValueType
    {
        public SetSoemailBodyInputValueType(BodyInputValueTypeSoactionType soaction)
        {
            this.Soaction = soaction;
        }

        [JsonProperty("SOACTION", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputValueTypeSoactionType Soaction { get; set; }

        [JsonProperty("SOMAIL")]
        public BodyInputValueTypeSomailType Somail { get; set; }

        [JsonProperty("XTRDOCDATA")]
        public BodyInputValueTypeXtrdocdataTypeItem[] Xtrdocdata { get; set; }
    }

    public class BodyInputValueTypeSoactionType
    {
        public BodyInputValueTypeSoactionType(string series)
        {
            this.Series = series;
        }

        [JsonProperty("ACTSTATUS")]
        public BodyInputValueTypeSoactionTypeActstatusType? Actstatus { get; set; }

        [JsonProperty("COMMENTS")]
        public string Comments { get; set; }

        [JsonProperty("SERIES", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Series { get; set; }

        [JsonProperty("TRNDATE")]
        public string Trndate { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputValueTypeSoactionTypeActstatusType
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
        _4,
        [EnumMember(Value = "5")]
        _5,
        [EnumMember(Value = "6")]
        _6
    }

    public class BodyInputValueTypeSomailType
    {
        [JsonProperty("FROMADDRESS")]
        public string Fromaddress { get; set; }

        [JsonProperty("FROMNAME")]
        public string Fromname { get; set; }

        [JsonProperty("SOBCC")]
        public string Sobcc { get; set; }

        [JsonProperty("SOBODY")]
        public string Sobody { get; set; }

        [JsonProperty("SOCC")]
        public string Socc { get; set; }

        [JsonProperty("SOTO")]
        public string Soto { get; set; }
    }

    public class SetMeetingBodyInput
    {
        public SetMeetingBodyInput(BodyInputDataType data)
        {
            this.Data = data;
        }

        [JsonProperty("APPID", DefaultValueHandling = DefaultValueHandling.Include)]
        internal int Appid { get; set; } = 702;

        [JsonProperty("DATA", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputDataType Data { get; set; }

        [JsonProperty("FORM")]
        public string Form { get; set; }

        [JsonProperty("KEY")]
        public string Key { get; set; }

        [JsonProperty("MODE", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Mode { get; set; } = "1";

        [JsonProperty("OBJECT", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ObjectEntity { get; set; } = "SOMEETING";

        [JsonProperty("SERVICE", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Service { get; set; } = "setData";
    }

    public class BodyInputDataType
    {
        public BodyInputDataType(BodyInputDataTypeSoactionType soaction)
        {
            this.Soaction = soaction;
        }

        [JsonProperty("SOACTION", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputDataTypeSoactionType Soaction { get; set; }

        [JsonProperty("XTRDOCDATA")]
        public BodyInputDataTypeXtrdocdataTypeItem[] Xtrdocdata { get; set; }
    }

    public class BodyInputDataTypeSoactionType
    {
        public BodyInputDataTypeSoactionType(string series)
        {
            this.Series = series;
        }

        [JsonProperty("ACTOR")]
        public string Operator { get; set; }

        [JsonProperty("ACTPRSN")]
        public string OperatorContact { get; set; }

        [JsonProperty("ACTSTATUS")]
        public BodyInputDataTypeSoactionTypeActstatusType? Actstatus { get; set; }

        [JsonProperty("COMMENTS")]
        public string Comments { get; set; }

        [JsonProperty("FINALDATE")]
        public string Finaldate { get; set; }

        [JsonProperty("FROMDATE")]
        public string Fromdate { get; set; }

        [JsonProperty("ORDEREDBY")]
        public string OrderedBy { get; set; }

        [JsonProperty("ORDPRSN")]
        public string OrderedByContact { get; set; }

        [JsonProperty("PRIORITY")]
        public string Priority { get; set; }

        [JsonProperty("PRJC")]
        public string Project { get; set; }

        [JsonProperty("REMARKS")]
        public string Remarks { get; set; }

        [JsonProperty("SERIES", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Series { get; set; }

        [JsonProperty("TRDR")]
        public string Trdr { get; set; }

        [JsonProperty("TRNDATE")]
        public string Trndate { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputDataTypeSoactionTypeActstatusType
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
        _4,
        [EnumMember(Value = "5")]
        _5,
        [EnumMember(Value = "6")]
        _6
    }

    public class BodyInputDataTypeXtrdocdataTypeItem
    {
        [JsonProperty("LINENUM")]
        public string LineNo { get; set; }

        [JsonProperty("NAME")]
        public string Name { get; set; }

        [JsonProperty("SOFNAME")]
        public string Url { get; set; }
    }

    public class SetSotaskBodyInput
    {
        public SetSotaskBodyInput(BodyInputDataType data)
        {
            this.Data = data;
        }

        [JsonProperty("APPID", DefaultValueHandling = DefaultValueHandling.Include)]
        internal int Appid { get; set; } = 702;

        [JsonProperty("DATA", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputDataType Data { get; set; }

        [JsonProperty("FORM")]
        public string Form { get; set; }

        [JsonProperty("KEY")]
        public string Key { get; set; }

        [JsonProperty("MODE", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Mode { get; set; } = "1";

        [JsonProperty("OBJECT", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ObjectEntity { get; set; } = "SOTASK";

        [JsonProperty("SERVICE", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Service { get; set; } = "setData";
    }

    public class SetSupplierBodyInput
    {
        public SetSupplierBodyInput(SetSupplierBodyInputValueType value)
        {
            this.Value = value;
        }

        [JsonProperty("APPID", DefaultValueHandling = DefaultValueHandling.Include)]
        internal int Appid { get; set; } = 702;

        [JsonProperty("DATA", DefaultValueHandling = DefaultValueHandling.Include)]
        public SetSupplierBodyInputValueType Value { get; set; }

        [JsonProperty("FORM")]
        public string Form { get; set; }

        [JsonProperty("KEY")]
        public string Key { get; set; }

        [JsonProperty("MODE", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Mode { get; set; } = "1";

        [JsonProperty("OBJECT", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ObjectEntity { get; set; } = "SUPPLIER";

        [JsonProperty("SERVICE", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Service { get; set; } = "setData";
    }

    public class SetSupplierBodyInputValueType
    {
        public SetSupplierBodyInputValueType(BodyInputValueTypeSupplierType supplier)
        {
            this.Supplier = supplier;
        }

        [JsonProperty("SUPBANKACC")]
        public BodyInputValueTypeSupbankaccTypeItem[] Supbankacc { get; set; }

        [JsonProperty("SUPPLIER", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputValueTypeSupplierType Supplier { get; set; }
    }

    public class BodyInputValueTypeSupbankaccTypeItem
    {
        [JsonProperty("BANK")]
        public string Bank { get; set; }

        [JsonProperty("IBAN")]
        public string Iban { get; set; }

        [JsonProperty("REMARKS")]
        public string Remarks { get; set; }
    }

    public class BodyInputValueTypeSupplierType
    {
        public BodyInputValueTypeSupplierType(string code, string name)
        {
            this.Code = code;
            this.Name = name;
        }

        [JsonProperty("ADDRESS")]
        public string Address { get; set; }

        [JsonProperty("AFM")]
        public string Afm { get; set; }

        [JsonProperty("CITY")]
        public string City { get; set; }

        [JsonProperty("CODE", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Code { get; set; }

        [JsonProperty("DISTRICT")]
        public string District { get; set; }

        [JsonProperty("EMAIL")]
        public string Email { get; set; }

        [JsonProperty("FAX")]
        public string Fax { get; set; }

        [JsonProperty("IRSDATA")]
        public string Irsdata { get; set; }

        [JsonProperty("JOBTYPETRD")]
        public string Jobtypetrd { get; set; }

        [JsonProperty("NAME", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("PHONE01")]
        public string Phone01 { get; set; }

        [JsonProperty("REMARKS")]
        public string Remarks { get; set; }

        [JsonProperty("ZIP")]
        public string Zip { get; set; }
    }

    public class WebhookBodyInput
    {
        public WebhookBodyInput(BodyInputObjectEntityType objectEntity)
        {
            this.ObjectEntity = objectEntity;
        }

        [JsonProperty("condition")]
        public string Condition { get; set; }

        [JsonProperty("config", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputConfigType Config { get; set; } = new BodyInputConfigType();

        [JsonProperty("event", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Event { get; set; } = "ONPOST";

        [JsonProperty("object", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputObjectEntityType ObjectEntity { get; set; }
    }

    public class BodyInputConfigType
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputObjectEntityType
    {
        Cheque,
        [EnumMember(Value = "Collections document")]
        CollectionsDocument,
        Contacts,
        Customer,
        [EnumMember(Value = "Draft entry")]
        DraftEntry,
        Email,
        Expenses,
        [EnumMember(Value = "Expenses document")]
        ExpensesDocument,
        Meeting,
        Item,
        [EnumMember(Value = "Payments document")]
        PaymentsDocument,
        Projects,
        [EnumMember(Value = "Purchases document")]
        PurchasesDocument,
        [EnumMember(Value = "Sales document")]
        SalesDocument,
        Services,
        [EnumMember(Value = "Stock document")]
        StockDocument,
        Supplier,
        [EnumMember(Value = "Task")]
        TaskObject
    }

    public class WebhookOnDeleteBodyInput
    {
        public WebhookOnDeleteBodyInput(BodyInputObjectEntityType objectEntity)
        {
            this.ObjectEntity = objectEntity;
        }

        [JsonProperty("condition")]
        public string Condition { get; set; }

        [JsonProperty("config", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputConfigType Config { get; set; } = new BodyInputConfigType();

        [JsonProperty("event", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Event { get; set; } = "ONDELETE";

        [JsonProperty("object", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputObjectEntityType ObjectEntity { get; set; }
    }

    public class WebhookOnInsertBodyInput
    {
        public WebhookOnInsertBodyInput(BodyInputObjectEntityType objectEntity)
        {
            this.ObjectEntity = objectEntity;
        }

        [JsonProperty("condition")]
        public string Condition { get; set; }

        [JsonProperty("config", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputConfigType Config { get; set; } = new BodyInputConfigType();

        [JsonProperty("event", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Event { get; set; } = "ONINSERT";

        [JsonProperty("object", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputObjectEntityType ObjectEntity { get; set; }
    }

    public class WebhookOnUpdateBodyInput
    {
        public WebhookOnUpdateBodyInput(BodyInputObjectEntityType objectEntity)
        {
            this.ObjectEntity = objectEntity;
        }

        [JsonProperty("condition")]
        public string Condition { get; set; }

        [JsonProperty("config", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputConfigType Config { get; set; } = new BodyInputConfigType();

        [JsonProperty("event", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Event { get; set; } = "ONUPDATE";

        [JsonProperty("object", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputObjectEntityType ObjectEntity { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Soft1;

    public partial class WorkflowManagedActions
    {
        public Soft1Actions Soft1(string connectionId) => new Soft1Actions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Soft1Triggers Soft1(string connectionId) => new Soft1Triggers(connectionId);
    }
}