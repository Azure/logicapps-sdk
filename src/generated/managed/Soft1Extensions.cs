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
        public IWorkflowAction<ApiConnectionActionConfiguration> Microservice(Expression<Func<MicroserviceInput>> body)
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
        public IBodyWorkflowAction<GetCFNCUSDOCResponse, ApiConnectionActionConfiguration> GetCFNCUSDOC(Expression<Func<GetCFNCUSDOCInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GetCFNCUSDOCResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/getCFNCUSDOC";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GetCFNCUSDOCResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<GetCfnsupdocResponse, ApiConnectionActionConfiguration> GetCfnsupdoc(Expression<Func<GetCfnsupdocInput>> body)
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
        public IBodyWorkflowAction<GetChequeResponse, ApiConnectionActionConfiguration> GetCheque(Expression<Func<GetChequeInput>> body)
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
        public IBodyWorkflowAction<GetContactResponse, ApiConnectionActionConfiguration> GetContact(Expression<Func<GetContactInput>> body)
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
        public IBodyWorkflowAction<GetCustomerResponse, ApiConnectionActionConfiguration> GetCustomer(Expression<Func<GetCustomerInput>> body)
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
        public IBodyWorkflowAction<GetDraftEntryResponse, ApiConnectionActionConfiguration> GetDraftEntry(Expression<Func<GetDraftEntryInput>> body)
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
        public IBodyWorkflowAction<GetExpenseResponse, ApiConnectionActionConfiguration> GetExpense(Expression<Func<GetExpenseInput>> body)
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
        public IBodyWorkflowAction<GetExpensesDocResponse, ApiConnectionActionConfiguration> GetExpensesDoc(Expression<Func<GetExpensesDocInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<GetExpensesDocResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/getExpensesDoc";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GetExpensesDocResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<GetItedocResponse, ApiConnectionActionConfiguration> GetItedoc(Expression<Func<GetItedocInput>> body)
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
        public IBodyWorkflowAction<GetItemResponse, ApiConnectionActionConfiguration> GetItem(Expression<Func<GetItemInput>> body)
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
        public IBodyWorkflowAction<GetProjectResponse, ApiConnectionActionConfiguration> GetProject(Expression<Func<GetProjectInput>> body)
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
        public IBodyWorkflowAction<GetPurdocResponse, ApiConnectionActionConfiguration> GetPurdoc(Expression<Func<GetPurdocInput>> body)
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
        public IBodyWorkflowAction<GetSaldocResponse, ApiConnectionActionConfiguration> GetSaldoc(Expression<Func<GetSaldocInput>> body)
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
        public IBodyWorkflowAction<GetServiceResponse, ApiConnectionActionConfiguration> GetService(Expression<Func<GetServiceInput>> body)
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
        public IBodyWorkflowAction<GetSOEMAILResponse, ApiConnectionActionConfiguration> GetSOEMAIL(Expression<Func<GetSOEMAILInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GetSOEMAILResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/getSoemail";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GetSOEMAILResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<GetMeetingResponse, ApiConnectionActionConfiguration> GetMeeting(Expression<Func<GetMeetingInput>> body)
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
        public IBodyWorkflowAction<GetSOTASKResponse, ApiConnectionActionConfiguration> GetSOTASK(Expression<Func<GetSOTASKInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GetSOTASKResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/getSotask";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GetSOTASKResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<GetSupplierResponse, ApiConnectionActionConfiguration> GetSupplier(Expression<Func<GetSupplierInput>> body)
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
        public IBodyWorkflowAction<GetSystemParamsResponse, ApiConnectionActionConfiguration> GetSystemParams(Expression<Func<GetSystemParamsInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<GetSystemParamsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/getSystemParams";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GetSystemParamsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<SetData200response, ApiConnectionActionConfiguration> SetCFNCUSDOC(Expression<Func<SetCFNCUSDOCInput>> body)
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
        public IBodyWorkflowAction<SetData200response, ApiConnectionActionConfiguration> SetCfnsupdoc(Expression<Func<SetCfnsupdocInput>> body)
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
        public IBodyWorkflowAction<SetData200response, ApiConnectionActionConfiguration> SetCheque(Expression<Func<SetChequeInput>> body)
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
        public IBodyWorkflowAction<SetData200response, ApiConnectionActionConfiguration> SetContact(Expression<Func<SetContactInput>> body)
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
        public IBodyWorkflowAction<SetData200response, ApiConnectionActionConfiguration> SetCustomer(Expression<Func<SetCustomerInput>> body)
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
        public IBodyWorkflowAction<SetData200response, ApiConnectionActionConfiguration> SetDraftEntry(Expression<Func<SetDraftEntryInput>> body)
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
        public IBodyWorkflowAction<SetData200response, ApiConnectionActionConfiguration> SetExpense(Expression<Func<SetExpenseInput>> body)
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
        public IBodyWorkflowAction<SetData200response, ApiConnectionActionConfiguration> SetExpensesDoc(Expression<Func<SetExpensesDocInput>> body)
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
        public IBodyWorkflowAction<SetData200response, ApiConnectionActionConfiguration> SetItedoc(Expression<Func<SetItedocInput>> body)
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
        public IBodyWorkflowAction<SetData200response, ApiConnectionActionConfiguration> SetItem(Expression<Func<SetItemInput>> body)
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
        public IBodyWorkflowAction<SetData200response, ApiConnectionActionConfiguration> SetProject(Expression<Func<SetProjectInput>> body)
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
        public IBodyWorkflowAction<SetData200response, ApiConnectionActionConfiguration> SetPurdoc(Expression<Func<SetPurdocInput>> body)
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
        public IBodyWorkflowAction<SetData200response, ApiConnectionActionConfiguration> SetSaldoc(Expression<Func<SetSaldocInput>> body)
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
        public IBodyWorkflowAction<SetData200response, ApiConnectionActionConfiguration> SetService(Expression<Func<SetServiceInput>> body)
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
        public IBodyWorkflowAction<SetData200response, ApiConnectionActionConfiguration> SetSOEMAIL(Expression<Func<SetSOEMAILInput>> body)
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
        public IBodyWorkflowAction<SetData200response, ApiConnectionActionConfiguration> SetMeeting(Expression<Func<SetMeetingInput>> body)
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
        public IBodyWorkflowAction<SetData200response, ApiConnectionActionConfiguration> SetSOTASK(Expression<Func<SetSOTASKInput>> body)
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
        public IBodyWorkflowAction<SetData200response, ApiConnectionActionConfiguration> SetSupplier(Expression<Func<SetSupplierInput>> body)
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
        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> Webhook(Expression<Func<WebhookInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("create");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> WebhookOnDelete(Expression<Func<WebhookOnDeleteInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhook/onDelete";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("create");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> WebhookOnInsert(Expression<Func<WebhookOnInsertInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhook/onInsert";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("create");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> WebhookOnUpdate(Expression<Func<WebhookOnUpdateInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhook/onUpdate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("create");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }
    }

    public class MicroserviceInput
    {
        [JsonProperty("body", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Body { get; set; }

        [JsonProperty("endpoint", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Endpoint { get; set; }
    }

    public class GetCFNCUSDOCResponse
    {
        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("remoteKey")]
        public string RemoteKey { get; set; }

        [JsonProperty("data")]
        public GetCFNCUSDOCResponseValueType Value { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("errorcode")]
        public int ErrorCode { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class GetCFNCUSDOCResponseValueType
    {
        public GetCFNCUSDOCResponseValueTypeCARDLINESTypeItem[] CARDLINES { get; set; }
        public GetCFNCUSDOCResponseValueTypeCASHLINESTypeItem[] CASHLINES { get; set; }

        [JsonProperty("CFNCUSDOC")]
        public GetCFNCUSDOCResponseValueTypeCollectionsDocumentType CollectionsDocument { get; set; }
        public GetCFNCUSDOCResponseValueTypeCHEQUELINESTypeItem[] CHEQUELINES { get; set; }
    }

    public class GetCFNCUSDOCResponseValueTypeCARDLINESTypeItem
    {
        public string CRDCARDNUM { get; set; }
        public string CREDITCARDS { get; set; }
        public string LINENUM { get; set; }
        public string LINEVAL { get; set; }
    }

    public class GetCFNCUSDOCResponseValueTypeCASHLINESTypeItem
    {
        public string LINENUM { get; set; }
        public string LINEVAL { get; set; }
        public string SOCURRENCY { get; set; }
    }

    public class GetCFNCUSDOCResponseValueTypeCollectionsDocumentType
    {
        public string COLLECTOR { get; set; }

        [JsonProperty("COLLECTOR_PRSNIN_NAME2")]
        public string COLLECTORPRSNINNAME2 { get; set; }
        public string COMPANY { get; set; }
        public string FINCODE { get; set; }
        public string PRJC { get; set; }

        [JsonProperty("PRJC_PRJC_NAME")]
        public string PRJCPRJCNAME { get; set; }
        public string REMARKS { get; set; }
        public string SALESMAN { get; set; }

        [JsonProperty("SALESMAN_PRSNIN_NAME2")]
        public string SALESMANPRSNINNAME2 { get; set; }
        public string SERIES { get; set; }
        public string SUMAMNT { get; set; }
        public string TRDR { get; set; }

        [JsonProperty("TRDR_TRDR_CODE")]
        public string TRDRTRDRCODE { get; set; }

        [JsonProperty("TRDR_TRDR_NAME")]
        public string TRDRTRDRNAME { get; set; }
        public string TRNDATE { get; set; }
    }

    public class GetCFNCUSDOCResponseValueTypeCHEQUELINESTypeItem
    {
        public string CFINALDATE { get; set; }
        public string CODE { get; set; }
        public string CSERIES { get; set; }
        public string LINENUM { get; set; }
        public string LINEVAL { get; set; }
        public string TPRMS { get; set; }
    }

    public class GetCFNCUSDOCInput
    {
        public string FORM { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string KEY { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string LOCATEINFO { get; set; } = "CARDLINES:CRDCARDNUM,CREDITCARDS,LINENUM,LINEVAL;CASHLINES:LINENUM,LINEVAL,LRATE,SOCURRENCY;CFNCUSDOC:ACNMSK,APPRV,BUSUNITS,COLLECTOR,COLLECTOR_PRSNIN_CODE,COLLECTOR_PRSNIN_NAME2,COMMENTS,COMMENTS1,COMPANY,EXPN,FINCODEG,FINCODE,FINSTATES,FOLDER,INST,INST_INST_CODE,INST_INST_NAME,ISCANCEL,ISPRINT,ORIGIN,PNAMEG,PRJC,PRJC_PRJC_CODE,PRJC_PRJC_NAME,REMARKS,SALESMAN,SALESMAN_PRSNIN_CODE,SALESMAN_PRSNIN_NAME2,SERIES,SHIPDATEG,SUMAMNT,SUMLAMNT,SUMTAMNT,TRDBRANCH,TRDBRANCH_TRDBRANCH_CODE,TRDBRANCH_TRDBRANCH_NAME,TRDR,TRDR_TRDR_AFM,TRDR_TRDR_CODE,TRDR_TRDR_NAME,TRDRS,TRDRS_TRDR_CODE,TRDRS_TRDR_NAME,TRNDATE,TRNDATEG;CHEQUELINES:CCHEQUENUMBER,CFINALDATE,CODE,CSERIES,LINENUM,LINEVAL,TPRMS;VCAPTION:CURRBAL;VOUCHERLINES:LINENUM,LINEVAL,VOUCHER,VOUCHER_VOUCHER_CODE,VOUCHER_VOUCHER_FINALDATE,VOUCHER_VOUCHER_NAME,VOUCHER_VOUCHER_VOUCHERVAL";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string MODE { get; set; } = "1";

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
        public GetCfnsupdocResponseValueTypeCARDLINESTypeItem[] CARDLINES { get; set; }
        public GetCfnsupdocResponseValueTypeCASHLINESTypeItem[] CASHLINES { get; set; }

        [JsonProperty("CFNSUPDOC")]
        public GetCfnsupdocResponseValueTypePaymentsDocumentType PaymentsDocument { get; set; }
        public GetCfnsupdocResponseValueTypeCHEQUELINESTypeItem[] CHEQUELINES { get; set; }
    }

    public class GetCfnsupdocResponseValueTypeCARDLINESTypeItem
    {
        public string CRDCARDNUM { get; set; }
        public string CREDITCARDS { get; set; }
        public string LINENUM { get; set; }
        public string LINEVAL { get; set; }
    }

    public class GetCfnsupdocResponseValueTypeCASHLINESTypeItem
    {
        public string LINENUM { get; set; }
        public string LINEVAL { get; set; }
        public string SOCURRENCY { get; set; }
    }

    public class GetCfnsupdocResponseValueTypePaymentsDocumentType
    {
        [JsonProperty("COMMENTS")]
        public string Reason { get; set; }
        public string COMPANY { get; set; }
        public string FINCODE { get; set; }
        public string PRJC { get; set; }

        [JsonProperty("PRJC_PRJC_NAME")]
        public string PRJCPRJCNAME { get; set; }
        public string SERIES { get; set; }
        public string SUMAMNT { get; set; }
        public string TRDR { get; set; }

        [JsonProperty("TRDR_TRDR_ADDRESS")]
        public string TRDRTRDRADDRESS { get; set; }

        [JsonProperty("TRDR_TRDR_AFM")]
        public string TRDRTRDRAFM { get; set; }

        [JsonProperty("TRDR_TRDR_CODE")]
        public string TRDRTRDRCODE { get; set; }

        [JsonProperty("TRDR_TRDR_IRSDATA")]
        public string TRDRTRDRIRSDATA { get; set; }

        [JsonProperty("TRDR_TRDR_NAME")]
        public string TRDRTRDRNAME { get; set; }
        public string TRNDATE { get; set; }
    }

    public class GetCfnsupdocResponseValueTypeCHEQUELINESTypeItem
    {
        public string CFINALDATE { get; set; }
        public string CODE { get; set; }
        public string CSERIES { get; set; }
        public string LINENUM { get; set; }
        public string LINEVAL { get; set; }
        public string TPRMS { get; set; }
    }

    public class GetCfnsupdocInput
    {
        public string FORM { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string KEY { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string LOCATEINFO { get; set; } = "CARDLINES:CRDCARDNUM,CREDITCARDS,LINENUM,LINEVAL;CASHLINES:LINENUM,LINEVAL,LRATE,SOCURRENCY;CFNSUPDOC:ACNMSK,APPRV,BRANCH,BUSUNITS,CMPFINCODE,FINCODE,CMPSERIESNUM,COMMENTS,COMMENTS1,COMPANY,EXPN,FINSTATES,FOLDER,FPRMS,INPAYVAT,INST,INST_INST_CODE,INST_INST_NAME,ISCANCEL,ISPRINT,LRATE,PRJC,PRJC_PRJC_CODE,PRJC_PRJC_NAME,REMARKS,SERIES,SOCASH,SOCURRENCY,SUMAMNT,SUMLAMNT,SUMTAMNT,TFPRMS,TRDBRANCH,TRDBRANCH_TRDBRANCH_CODE,TRDBRANCH_TRDBRANCH_NAME,TRDR,TRDR_TRDR_AFM,TRDR_TRDR_CODE,TRDR_TRDR_NAME,TRDR_TRDR_ADDRESS,TRDR_TRDR_IRSDATA,TRDRRATE,TRDRS,TRDRS_TRDR_CODE,TRDRS_TRDR_NAME,TRNDATE;CHEQUELINES:CCHEQUENUMBER,CFINALDATE,CODE,CSERIES,LINENUM,LINEVAL,TPRMS;";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string MODE { get; set; } = "1";

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
        public string CREATORPHONE { get; set; }

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

    public class GetChequeInput
    {
        public string FORM { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string KEY { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string LOCATEINFO { get; set; } = "CHEQUE:BANK,BANK_BANK_CODE,BANK_BANK_NAME,CHEQUEBAL,CHEQUENUMBER,CHEQUERATE,CHEQUESTATES,CHEQUEVAL,CMPCODE,CMPSERIESNUM,COMPANY,CREATORADDR,CREATORNAME,CREATORPHONE,CRTDATE,DATEOFS,FINALDATE,HOLDERADDR,HOLDERNAME,LCHEQUEBAL,LCHEQUEVAL,OSMODE,PUBLISHERAFM,REMARKS,SERIES,SOCURRENCY,SODTYPEPOSSESSOR,SODTYPEPUBLISHER,TRDRPOSSESSOR,TRDRPOSSESSOR_TRDR_CODE,TRDRPOSSESSOR_TRDR_NAME,TRDRPUBLISHER,TRDRPUBLISHER_TRDR_CODE,TRDRPUBLISHER_TRDR_NAME";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string MODE { get; set; } = "1";

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
        public GetContactResponseDataTypeXTRDOCDATATypeItem[] XTRDOCDATA { get; set; }
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

    public class GetContactResponseDataTypeXTRDOCDATATypeItem
    {
        public string LINENUM { get; set; }
        public string NAME { get; set; }
        public string SOFNAME { get; set; }
    }

    public class GetContactInput
    {
        [JsonProperty("APPID", DefaultValueHandling = DefaultValueHandling.Include)]
        internal int APPId { get; set; } = 702;
        public string FORM { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string KEY { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string LOCATEINFO { get; set; } = "PRSNOUT:ADDRESS,AFM,AREAS,BIRTHDATE,BRANCH,CITY,CODE,CONSENT,COUNTRY,DISTRICT,DISTRICT1,EMAIL,EMAIL1,FAX,IDENTITYNUM,IRSDATA,ISACTIVE,MOBILEPHONE,NAME,NAME2,NATIONALITY,NOCONSENT,PHONE1,PHONE2,PHONEEXT,PHONELOCAL,PRSNID_PRSNOUT_CODE,REMARKS,SOSEX,SOTITLE,WEBPAGE,ZIP;PRSREL:PRSN1,PRSN1_PRSN_BIRTHDATE,PRSN1_PRSN_CODE,PRSN1_PRSN_MOBILEPHONE,PRSN1_PRSN_NAME,PRSN1_PRSN_NAME2,PRSN1_PRSN_PHONE1,RELPRSN;XTRDOCDATA:LINENUM,SOFNAME";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string MODE { get; set; } = "1";

        [JsonProperty("OBJECT", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ObjectEntity { get; set; } = "PRSNOUT";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string SERVICE { get; set; } = "getData";
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

    public class GetCustomerInput
    {
        public string FORM { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string KEY { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string LOCATEINFO { get; set; } = "CUSTOMER:ADDRESS,AFM,AREAS,CITY,CODE,DISCOUNT,DISTRICT,EMAIL,FAX,IRSDATA,ISACTIVE,JOBTYPETRD,NAME,PHONE01,REMARKS,VATSTS,ZIP";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string MODE { get; set; } = "1";

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
        public GetDraftEntryResponseValueTypeSODRAFTType SODRAFT { get; set; }
        public GetDraftEntryResponseValueTypeSODRAFTLNKType SODRAFTLNK { get; set; }
    }

    public class GetDraftEntryResponseValueTypeSODRAFTType
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

        [JsonProperty("ZIP")]
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
    }

    public class GetDraftEntryResponseValueTypeSODRAFTLNKType
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

    public class GetDraftEntryInput
    {
        [JsonProperty("APPID", DefaultValueHandling = DefaultValueHandling.Include)]
        internal int APPId { get; set; } = 702;
        public string FORM { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string KEY { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string LOCATEINFO { get; set; } = "SODRAFT:ADDRESS,AFM,CITY,CODE,CONSENT,COUNTRY,DISTRICT,DISTRICT1,DRAFTTYPE,EMAIL,EMAIL1,EMAIL2,FAX,IDENTITYNUM,INSDATE,JOBTYPETRD,MOBILEPHONE,NAME,NAMEC,NAMEF,NAMEL,NOCONSENT,NUMCG,PHONE1,PHONE2,PHONEEXT,PHONELOCAL,REMARKS,SOTITLENAME,WEBPAGE,ZIP;SODRAFTLNK:BRANCH,BUSUNITS,DEPART,PRJC,PRJC_PRJC_CODE,PRJC_PRJC_NAME,PRJCLEAD,PRSNIN,PRSNIN_PRSNIN_CODE,PRSNIN_PRSNIN_NAME2,PRSNOUT,PRSNOUT_PRSNOUT_CODE,PRSNOUT_PRSNOUT_NAME2,TRDR,TRDR_TRDR_CODE,TRDR_TRDR_NAME";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string MODE { get; set; } = "1";

        [JsonProperty("OBJECT", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ObjectEntity { get; set; } = "SODRAFT";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string SERVICE { get; set; } = "getData";
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
        public string VATGroup { get; set; }
    }

    public class GetExpenseInput
    {
        public string FORM { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string KEY { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string LOCATEINFO { get; set; } = "LINEITEM:CODE,ISACTIVE,LISOURCETYPE,MTRCATEGORY,MTRTYPE,NAME,REMARKS,SOPAYVALUE,VAT";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string MODE { get; set; } = "1";

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
        public GetExpensesDocResponseValueTypeLINLINESTypeItem[] LINLINES { get; set; }

        [JsonProperty("LINSUPDOC")]
        public GetExpensesDocResponseValueTypeExpensesDocumentType ExpensesDocument { get; set; }
    }

    public class GetExpensesDocResponseValueTypeLINLINESTypeItem
    {
        [JsonProperty("LINENUM")]
        public string LineNumber { get; set; }

        [JsonProperty("LINEVAL")]
        public string LineValue { get; set; }
        public string MTRL { get; set; }

        [JsonProperty("MTRL_ITEM_CODE")]
        public string Code { get; set; }

        [JsonProperty("MTRL_ITEM_NAME")]
        public string ItemName { get; set; }

        [JsonProperty("VAT")]
        public string VATId { get; set; }

        [JsonProperty("VATAMNT")]
        public string VATAmount { get; set; }
    }

    public class GetExpensesDocResponseValueTypeExpensesDocumentType
    {
        [JsonProperty("COMPANY")]
        public string Company { get; set; }
        public string FINCODE { get; set; }

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
        public string VATAmount { get; set; }
    }

    public class GetExpensesDocInput
    {
        [JsonProperty("APPID", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string APPId { get; set; } = "702";
        public string FORM { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string KEY { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string LOCATEINFO { get; set; } = "LINLINES:LINENUM,LINEVAL,MTRL,MTRL_LINEITEM_CODE,MTRL_LINEITEM_NAME,VAT,VATAMNT;LINSUPDOC:COMPANY,ACNMSK,APPRV,BRANCH,BUSUNITS,CASHDEVICE,CBANK,CBANKBRANCH,CMPFINCODE,FINCODE,CMPSERIESNUM,COMMENTS,COMMENTS1,CRCONTROL,EXPN,FINSTATES,FPRMS,GSISFLG,GSISMD,GSISNET,GSISPACKAGES,GSISQTY,GSISVAT,INPAYVAT,INST,INST_INST_CODE,INST_INST_NAME,INTDATE,INTEXPN,INTFDOCTYPE,INTRATE,INTSHIPMENT,INTVAL,INTVAT,ISCANCEL,ISPRINT,ISTRIG,KEPYOHANDMD,KEPYOMD,KEPYOQT,LEXPN,LKEPYOVAL,LNETAMNT,LRATE,LVATAMNT,NETAMNT,NOINTRASTAT,PAYMENT,PRJC,PRJC_PRJC_CODE,PRJC_PRJC_NAME,REMARKS,RSRC,RSRC_RSRC_CODE,RSRC_RSRC_NAME,SALESMAN,SALESMAN_PRSNIN_CODE,SALESMAN_PRSNIN_NAME2,SERIES,SHIPKIND,SHIPMENT,SOCURRENCY,SOPAYCODE,SUMAMNT,SUMLAMNT,SUMTAMNT,TEXPN,TNETAMNT,TRDBRANCH,TRDBRANCH_TRDBRANCH_CODE,TRDBRANCH_TRDBRANCH_NAME,TRDBRANCHS,TRDBRANCHS_TRDBRANCH_CODE,TRDBRANCHS_TRDBRANCH_NAME,TRDR,TRDR_SUPPLIER_AFM,TRDR_SUPPLIER_CHKAFM,TRDR_SUPPLIER_CODE,TRDR_SUPPLIER_NAME,TRDRRATE,TRDRS,TRDRS_TRDR_CODE,TRDRS_TRDR_NAME,TRNDATE,TVATAMNT,VATAMNT,VATPROVISIONS,VATSTS;MTRDOC:RECEIPTCARD,TRUCKS,TRUCKSNO;SUPPLIER:BANK";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string MODE { get; set; } = "1";

        [JsonProperty("OBJECT", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ObjectEntity { get; set; } = "LINSUPDOC";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string SERVICE { get; set; } = "getData";
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
        public GetItedocResponseValueTypeITEDOCType ITEDOC { get; set; }
        public GetItedocResponseValueTypeITELINESTypeItem[] ITELINES { get; set; }
        public GetItedocResponseValueTypeMTRDOCType MTRDOC { get; set; }
    }

    public class GetItedocResponseValueTypeITEDOCType
    {
        [JsonProperty("COMMENTS")]
        public string Reason { get; set; }

        [JsonProperty("COMPANY")]
        public string Company { get; set; }
        public string FINCODE { get; set; }

        [JsonProperty("REMARKS")]
        public string Comments { get; set; }

        [JsonProperty("SERIES")]
        public string Series { get; set; }

        [JsonProperty("TRNDATE")]
        public string Date { get; set; }
    }

    public class GetItedocResponseValueTypeITELINESTypeItem
    {
        public string DISC1PRC { get; set; }

        [JsonProperty("LINENUM")]
        public string LineNumber { get; set; }

        [JsonProperty("LINEVAL")]
        public string LineValue { get; set; }
        public string MTRL { get; set; }

        [JsonProperty("MTRL_ITEM_CODE")]
        public string Code { get; set; }

        [JsonProperty("MTRL_ITEM_NAME")]
        public string ItemName { get; set; }

        [JsonProperty("PRICE")]
        public string Price { get; set; }
        public string QTY { get; set; }
    }

    public class GetItedocResponseValueTypeMTRDOCType
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

    public class GetItedocInput
    {
        public string FORM { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string KEY { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string LOCATEINFO { get; set; } = "ITEDOC:CMPFINCODE,FINCODE,COMMENTS,COMPANY,SERIES,TRNDATE,REMARKS;ITELINES:DISC1PRC,LINENUM,LINEVAL,MTRL,MTRL_ITEM_CODE,MTRL_ITEM_CODE1,MTRL_ITEM_CODE2,MTRL_ITEM_NAME,MTRL_ITEM_NAME1,PRICE,QTY1,QTY;MTRDOC:COMPANY,WHOUSE,SHIPPINGADDR,DELIVDATE";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string MODE { get; set; } = "1";

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
        public string SODISCOUNT { get; set; }

        [JsonProperty("VAT")]
        public string VATGroup { get; set; }
    }

    public class GetItemInput
    {
        public string FORM { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string KEY { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string LOCATEINFO { get; set; } = "ITEM:CODE,ISACTIVE,MTRCATEGORY,MTRGROUP,MTRUNIT1,NAME,PRICER,PRICEW,REMARKS,SODISCOUNT,VAT";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string MODE { get; set; } = "1";

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
        public GetProjectResponseDataTypeXTRDOCDATATypeItem[] XTRDOCDATA { get; set; }
    }

    public class GetProjectResponseDataTypeProjectType
    {
        public string ACTSTATUS { get; set; }

        [JsonProperty("CODE")]
        public string Code { get; set; }
        public string FINALDATE { get; set; }
        public string FROMDATE { get; set; }

        [JsonProperty("ISACTIVE")]
        public string Active { get; set; }

        [JsonProperty("PRJC")]
        public string Name { get; set; }
        public string PRJCRM { get; set; }

        [JsonProperty("REMARKS")]
        public string Comments { get; set; }
    }

    public class GetProjectResponseDataTypeXTRDOCDATATypeItem
    {
        public string LINENUM { get; set; }
        public string NAME { get; set; }
        public string SOFNAME { get; set; }
    }

    public class GetProjectInput
    {
        [JsonProperty("APPID", DefaultValueHandling = DefaultValueHandling.Include)]
        internal int APPId { get; set; } = 702;
        public string FORM { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string KEY { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string LOCATEINFO { get; set; } = "PRJC:ACTSTATUS,CODE,FINALDATE,FROMDATE,ISACTIVE,NAME,PRJC,PRJCRM,REMARKS;XTRDOCDATA:LINENUM,SOFNAME,NAME";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string MODE { get; set; } = "1";

        [JsonProperty("OBJECT", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ObjectEntity { get; set; } = "PRJC";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string SERVICE { get; set; } = "getData";
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
        public GetPurdocResponseValueTypeITELINESTypeItem[] ITELINES { get; set; }
        public GetPurdocResponseValueTypeMTRDOCType MTRDOC { get; set; }

        [JsonProperty("PURDOC")]
        public GetPurdocResponseValueTypePurchasesDocumentType PurchasesDocument { get; set; }
        public GetPurdocResponseValueTypeSRVLINESTypeItem[] SRVLINES { get; set; }
        public GetPurdocResponseValueTypeVATANALTypeItem[] VATANAL { get; set; }
    }

    public class GetPurdocResponseValueTypeITELINESTypeItem
    {
        public string DISC1PRC { get; set; }
        public string LINENUM { get; set; }
        public string LINEVAL { get; set; }
        public string MTRL { get; set; }

        [JsonProperty("MTRL_ITEM_CODE")]
        public string MTRLITEMCODE { get; set; }

        [JsonProperty("MTRL_ITEM_NAME")]
        public string MTRLITEMNAME { get; set; }
        public string PRICE { get; set; }
        public string QTY { get; set; }
    }

    public class GetPurdocResponseValueTypeMTRDOCType
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
        public string DISC1PRC { get; set; }

        [JsonProperty("DISC1VAL")]
        public string DiscountValue { get; set; }

        [JsonProperty("EXPN")]
        public string Expenses { get; set; }
        public string FINCODE { get; set; }

        [JsonProperty("FPRMS")]
        public string Type { get; set; }

        [JsonProperty("NETAMNT")]
        public string NetAmount { get; set; }
        public string PAYMENT { get; set; }
        public string PRJC { get; set; }

        [JsonProperty("PRJC_PRJC_CODE")]
        public string PRJCPRJCCODE { get; set; }

        [JsonProperty("PRJC_PRJC_NAME")]
        public string PRJCPRJCNAME { get; set; }

        [JsonProperty("REMARKS")]
        public string Comments { get; set; }
        public string SERIES { get; set; }

        [JsonProperty("SHIPKIND")]
        public string PurposeOfDelivery { get; set; }
        public string SOCURRENCY { get; set; }
        public string SUMAMNT { get; set; }
        public string TRDR { get; set; }

        [JsonProperty("TRDR_SUPPLIER_ADDRESS")]
        public string SupplierAddress { get; set; }

        [JsonProperty("TRDR_SUPPLIER_AFM")]
        public string TRDRSUPPLIERAFM { get; set; }

        [JsonProperty("TRDR_SUPPLIER_CODE")]
        public string TRDRSUPPLIERCODE { get; set; }

        [JsonProperty("TRDR_SUPPLIER_IRSDATA")]
        public string SupplierTaxOffice { get; set; }

        [JsonProperty("TRDR_SUPPLIER_JOBTYPETRD")]
        public string SupplierProfession { get; set; }

        [JsonProperty("TRDR_SUPPLIER_NAME")]
        public string TRDRSUPPLIERNAME { get; set; }

        [JsonProperty("TRDR_SUPPLIER_PHONE01")]
        public string SupplierPhone { get; set; }
        public string TRNDATE { get; set; }
        public string VATAMNT { get; set; }
    }

    public class GetPurdocResponseValueTypeSRVLINESTypeItem
    {
        public string DISC1PRC { get; set; }
        public string LINENUM { get; set; }
        public string LINEVAL { get; set; }
        public string MTRL { get; set; }

        [JsonProperty("MTRL_SERVICE_CODE")]
        public string MTRLSERVICECODE { get; set; }

        [JsonProperty("MTRL_SERVICE_NAME")]
        public string MTRLSERVICENAME { get; set; }
        public string PRICE { get; set; }
        public string QTY { get; set; }
    }

    public class GetPurdocResponseValueTypeVATANALTypeItem
    {
        [JsonProperty("SUBVAL")]
        public string ValueSubjectToVAT { get; set; }

        [JsonProperty("VAT")]
        public string IdAndCategory { get; set; }

        [JsonProperty("VATVAL")]
        public string Value { get; set; }

        [JsonProperty("VAT_VAT_PERCNT")]
        public string Percent { get; set; }
    }

    public class GetPurdocInput
    {
        [JsonProperty("APPID", DefaultValueHandling = DefaultValueHandling.Include)]
        internal int APPId { get; set; } = 702;
        public string FORM { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string KEY { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string LOCATEINFO { get; set; } = "ITELINES:DISC1PRC,LINENUM,LINEVAL,MTRL,MTRL_ITEM_CODE,MTRL_ITEM_NAME,PRICE,QTY;MTRDOC:WHOUSE,COMPANY,DELIVDATE,SHIPPINGADDR;PURDOC:FINCODE,DISC1PRC,PAYMENT,PRJC,PRJC_PRJC_CODE,PRJC_PRJC_NAME,SERIES,SOCURRENCY,SUMAMNT,TRDR,TRDR_SUPPLIER_AFM,TRDR_SUPPLIER_NAME,TRDR_SUPPLIER_JOBTYPETRD,TRDR_SUPPLIER_ADDRESS,TRDR_SUPPLIER_IRSDATA,TRDR_SUPPLIER_PHONE01,TRNDATE,VATAMNT,DISC1VAL,EXPN,REMARKS,NETAMNT,COMPANY,FPRMS,SHIPKIND;SRVLINES:DISC1PRC,LINENUM,LINEVAL,MTRL,MTRL_SERVICE_CODE,MTRL_SERVICE_NAME,PRICE,QTY;VATANAL:VAT,VATVAL,SUBVAL,VAT_VAT_PERCNT";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string MODE { get; set; } = "1";

        [JsonProperty("OBJECT", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ObjectEntity { get; set; } = "PURDOC";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string SERVICE { get; set; } = "getData";
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
        public GetSaldocResponseValueTypeITELINESTypeItem[] ITELINES { get; set; }
        public GetSaldocResponseValueTypeMTRDOCType MTRDOC { get; set; }
        public GetSaldocResponseValueTypeSALDOCType SALDOC { get; set; }
        public GetSaldocResponseValueTypeSRVLINESTypeItem[] SRVLINES { get; set; }
        public GetSaldocResponseValueTypeVATANALTypeItem[] VATANAL { get; set; }
    }

    public class GetSaldocResponseValueTypeITELINESTypeItem
    {
        public string DISC1PRC { get; set; }

        [JsonProperty("LINENUM")]
        public string LineNumber { get; set; }

        [JsonProperty("LINEVAL")]
        public string LineValue { get; set; }
        public string MTRL { get; set; }

        [JsonProperty("MTRL_ITEM_CODE")]
        public string Code { get; set; }

        [JsonProperty("MTRL_ITEM_NAME")]
        public string ItemName { get; set; }

        [JsonProperty("PRICE")]
        public string Price { get; set; }
        public string QTY { get; set; }
    }

    public class GetSaldocResponseValueTypeMTRDOCType
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

    public class GetSaldocResponseValueTypeSALDOCType
    {
        [JsonProperty("COMPANY")]
        public string Company { get; set; }

        [JsonProperty("DISC1PRC")]
        public string Disc1prc { get; set; }

        [JsonProperty("DISC1VAL")]
        public string DiscountValue { get; set; }

        [JsonProperty("EXPN")]
        public string Expenses { get; set; }
        public string FINCODE { get; set; }

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
        public string VATAmount { get; set; }
    }

    public class GetSaldocResponseValueTypeSRVLINESTypeItem
    {
        public string DISC1PRC { get; set; }
        public string LINENUM { get; set; }
        public string LINEVAL { get; set; }
        public string MTRL { get; set; }

        [JsonProperty("MTRL_SERVICE_CODE")]
        public string MTRLSERVICECODE { get; set; }

        [JsonProperty("MTRL_SERVICE_NAME")]
        public string MTRLSERVICENAME { get; set; }
        public string PRICE { get; set; }
        public string QTY { get; set; }
    }

    public class GetSaldocResponseValueTypeVATANALTypeItem
    {
        [JsonProperty("SUBVAL")]
        public string ValueSubjectToVAT { get; set; }

        [JsonProperty("VAT")]
        public string IdAndCategory { get; set; }

        [JsonProperty("VATVAL")]
        public string Value { get; set; }

        [JsonProperty("VAT_VAT_PERCNT")]
        public string Percent { get; set; }
    }

    public class GetSaldocInput
    {
        public string FORM { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string KEY { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string LOCATEINFO { get; set; } = "ITELINES:DISC1PRC,LINENUM,LINEVAL,MTRL,MTRL_ITEM_CODE,MTRL_ITEM_NAME,PRICE,QTY;MTRDOC:SHIPPINGADDR,WHOUSE;SALDOC:COMPANY,DISC1VAL,SHIPKIND,REMARKS,EXPN,FPRMS,FINCODE,DISC1PRC,NETAMNT,PAYMENT,PRJC,PRJC_PRJC_CODE,PRJC_PRJC_NAME,REMARKS,SERIES,SOCURRENCY,SUMAMNT,TRDR,TRDR_CUSTOMER_AFM,TRDR_CUSTOMER_CODE,TRDR_CUSTOMER_NAME,TRDR_CUSTOMER_PHONE01,TRDR_CUSTOMER_IRSDATA,TRDR_CUSTOMER_ADDRESS,TRDR_CUSTOMER_JOBTYPETRD,TRNDATE,VATAMNT;SRVLINES:DISC1PRC,LINENUM,LINEVAL,MTRL,MTRL_SERVICE_CODE,MTRL_SERVICE_NAME,PRICE,QTY,QTY1;VATANAL:VAT,VATVAL,SUBVAL,VAT_VAT_PERCNT";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string MODE { get; set; } = "1";

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
        public string SODISCOUNT { get; set; }

        [JsonProperty("VAT")]
        public string VATGroup { get; set; }
    }

    public class GetServiceInput
    {
        public string FORM { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string KEY { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string LOCATEINFO { get; set; } = "SERVICE:CODE,ISACTIVE,MTRCATEGORY,MTRGROUP,MTRUNIT1,NAME,PRICER,PRICEW,REMARKS,SODISCOUNT,VAT";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string MODE { get; set; } = "1";

        [JsonProperty("OBJECT", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ObjectEntity { get; set; } = "SERVICE";

        [JsonProperty("appId", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string AppId { get; set; } = "702";

        [JsonProperty("service", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Service { get; set; } = "getData";
    }

    public class GetSOEMAILResponse
    {
        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("remoteKey")]
        public string RemoteKey { get; set; }

        [JsonProperty("data")]
        public GetSOEMAILResponseValueType Value { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("errorcode")]
        public int ErrorCode { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class GetSOEMAILResponseValueType
    {
        [JsonProperty("SOACTION")]
        public GetSOEMAILResponseValueTypeEmailTaskType EmailTask { get; set; }
        public GetSOEMAILResponseValueTypeSOMAILType SOMAIL { get; set; }
        public GetSOEMAILResponseValueTypeXTRDOCDATATypeItem[] XTRDOCDATA { get; set; }
    }

    public class GetSOEMAILResponseValueTypeEmailTaskType
    {
        public string ACTOR { get; set; }

        [JsonProperty("ACTPRSN")]
        public string OperatorContact { get; set; }
        public string ACTSTATUS { get; set; }
        public string COMMENTS { get; set; }
        public string FINALDATE { get; set; }
        public string FROMDATE { get; set; }
        public string ORDEREDBY { get; set; }

        [JsonProperty("ORDPRSN")]
        public string OrderedByContact { get; set; }

        [JsonProperty("PRIORITY")]
        public string Priority { get; set; }

        [JsonProperty("PRJC")]
        public string Project { get; set; }
        public string REMARKS { get; set; }
        public string SERIES { get; set; }
        public string TASKCOMPLETE { get; set; }
        public string TRDR { get; set; }

        [JsonProperty("TRDR_GENTRDR_NAME")]
        public string TRDRGENTRDRNAME { get; set; }
        public string TRNDATE { get; set; }
    }

    public class GetSOEMAILResponseValueTypeSOMAILType
    {
        public string FROMADDRESS { get; set; }
        public string FROMNAME { get; set; }
        public string MAILDATE { get; set; }
        public string SOBCC { get; set; }
        public string SOBODY { get; set; }
        public string SOCC { get; set; }
        public string SOTO { get; set; }
    }

    public class GetSOEMAILResponseValueTypeXTRDOCDATATypeItem
    {
        public string LINENUM { get; set; }
        public string NAME { get; set; }
        public string SOFNAME { get; set; }
    }

    public class GetSOEMAILInput
    {
        public string FORM { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string KEY { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string LOCATEINFO { get; set; } = "SOACTION:ACCLEVEL,ACTOR,ACTPRSN,ACTPRSN_PRSN_CODE,ACTPRSN_PRSN_NAME,ACTPRSN_PRSN_NAME2,ACTSTATES,ACTSTATUS,ACTTYPE,BOOL01,BOOL02,BOOL03,BOOL04,BRANCH,CMPCODE,CMPSERIESNUM,CNTR,CNTR_CNTR_CODE,CNTR_CNTR_NAME,COMMENTS,INSDATE,DATE01,DATE02,DATE03,DATE04,DATE05,DURATION,FINALDATE,FROMDATE,GQTY,INST,INST_INST_CODE,INST_INST_NAME,ISLEAD,ISRESPONSE,MSODTYPE,MTRL,MTRL_MTRL_CODE,MTRL_MTRL_NAME,NUM01,NUM02,NUM03,NUM04,NUM05,ORDEREDBY,ORDPRSN,ORDPRSN_PRSNIN_CODE,ORDPRSN_PRSNIN_NAME,ORDPRSN_PRSNIN_NAME2,PRIORITY,PRJC,PRJC_PRJC_CODE,PRJC_PRJC_NAME,PRJLINES,PRJLINES_PRJLINES_LINENUM,PRJLINES_PRJLINES_NAME,RSRC,RSRC_RSRC_CODE,RSRC_RSRC_NAME,SERIES,TASKCOMPLETE,TRDBRANCH,TRDBRANCH_TRDBRANCH_CODE,TRDBRANCH_TRDBRANCH_NAME,TRDPRSN,TRDPRSN_PRSN_CODE,TRDPRSN_PRSN_NAME2,TRDR,TRDR_GENTRDR_CODE,TRDR_GENTRDR_NAME,TRNDATE,TSODTYPE,UTBL01,UTBL02,UTBL03,UTBL04,UTBL05,VARCHAR01,VARCHAR02,VARCHAR03,VARCHAR04,VARCHAR05;SOMAIL:FROMADDRESS,FROMNAME,ISNOTDELIV,ISSEND,MAILDATE,NOTDELIVADDR,SOBCC,SOBODY,SOCC,SOTO;XTRDOCDATA:LINENUM,SOFNAME";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string MODE { get; set; } = "1";

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
        public string ACTOR { get; set; }

        [JsonProperty("ACTPRSN")]
        public string OperatorContact { get; set; }
        public string ACTSTATUS { get; set; }
        public string COMMENTS { get; set; }
        public string FINALDATE { get; set; }
        public string FROMDATE { get; set; }
        public string ORDEREDBY { get; set; }

        [JsonProperty("ORDPRSN")]
        public string OrderedByContact { get; set; }

        [JsonProperty("PRIORITY")]
        public string Priority { get; set; }

        [JsonProperty("PRJC")]
        public string Project { get; set; }
        public string REMARKS { get; set; }
        public string SERIES { get; set; }
        public string TASKCOMPLETE { get; set; }
        public string TRDR { get; set; }

        [JsonProperty("TRDR_GENTRDR_NAME")]
        public string TRDRGENTRDRNAME { get; set; }
        public string TRNDATE { get; set; }
    }

    public class GetMeetingInput
    {
        public string FORM { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string KEY { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string LOCATEINFO { get; set; } = "ACTLINES:CNTR,CNTR_CNTR_NAME,LINENUM,MTRL,MTRL_MTRL_CODE,MTRL_MTRL_NAME,QTY1,SODTYPE,SRVDEBITTYPE,VALUE;SOACTION:ACCLEVEL,ACTOR,ACTPRSN,ACTPRSN_PRSN_CODE,ACTPRSN_PRSN_NAME,ACTPRSN_PRSN_NAME2,ACTSTATES,ACTSTATUS,ACTTYPE,BOOL01,BOOL02,BOOL03,BOOL04,BRANCH,CMPCODE,CMPSERIESNUM,CNTR,CNTR_CNTR_CODE,CNTR_CNTR_NAME,COMMENTS,DATE01,DATE02,DATE03,DATE04,DATE05,DURATION,FINALDATE,FINDOC,FINDOC_SRVCARD_FINCODE,FROMDATE,GQTY,GVAL,INST,INST_INST_CODE,INST_INST_NAME,ISLEAD,ISRESPONSE,MSODTYPE,MTRL,MTRL_MTRL_CODE,MTRL_MTRL_NAME,NUM01,NUM02,NUM03,NUM04,NUM05,ORDEREDBY,ORDPRSN,ORDPRSN_PRSNIN_CODE,ORDPRSN_PRSNIN_NAME,ORDPRSN_PRSNIN_NAME2,PRIORITY,PRJC,PRJC_PRJC_CODE,PRJC_PRJC_NAME,PRJLINES,PRJLINES_PRJLINES_LINENUM,PRJLINES_PRJLINES_NAME,REMARKS,RSRC,RSRC_RSRC_CODE,RSRC_RSRC_NAME,SERIES,SNCODE,SRVDEBITTYPE,TASKCOMPLETE,TRDBRANCH,TRDBRANCH_TRDBRANCH_CODE,TRDBRANCH_TRDBRANCH_NAME,TRDBRANCHS,TRDBRANCHS_TRDBRANCH_CODE,TRDBRANCHS_TRDBRANCH_NAME,TRDPRSN,TRDPRSN_PRSNOUT_CODE,TRDPRSN_PRSNOUT_NAME2,TRDPRSNS,TRDPRSNS_PRSNOUT_CODE,TRDPRSNS_PRSNOUT_NAME2,TRDR,TRDR_GENTRDR_CODE,TRDR_GENTRDR_NAME,TRDRS,TRDRS_GENTRDR_CODE,TRDRS_GENTRDR_NAME,TRNDATE,TSODTYPE,TSSODTYPE,UTBL01,UTBL02,UTBL03,UTBL04,UTBL05,VARCHAR01,VARCHAR02,VARCHAR03,VARCHAR04,VARCHAR05;VACTRMND:HASREMIND,RMBEFORE,RMDATE;VMTPRSN:PRSN,PRSN_PRSN_CODE,PRSN_PRSN_NAME2,RSRC,RSRC_RSRC_CODE,RSRC_RSRC_NAME,SODTYPE,USERS;XTRDOCDATA:LINENUM,SOFNAME";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string MODE { get; set; } = "1";

        [JsonProperty("OBJECT", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ObjectEntity { get; set; } = "SOMEETING";

        [JsonProperty("appId", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string AppId { get; set; } = "702";

        [JsonProperty("service", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Service { get; set; } = "getData";
    }

    public class GetSOTASKResponse
    {
        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("remoteKey")]
        public string RemoteKey { get; set; }

        [JsonProperty("data")]
        public GetSOTASKResponseValueType Value { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("errorcode")]
        public int ErrorCode { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class GetSOTASKResponseValueType
    {
        [JsonProperty("SOACTION")]
        public GetSOTASKResponseValueTypeTaskObjectType TaskObject { get; set; }
    }

    public class GetSOTASKResponseValueTypeTaskObjectType
    {
        public string ACTOR { get; set; }

        [JsonProperty("ACTPRSN")]
        public string OperatorContact { get; set; }
        public string ACTSTATUS { get; set; }
        public string COMMENTS { get; set; }
        public string FINALDATE { get; set; }
        public string FROMDATE { get; set; }
        public string ORDEREDBY { get; set; }

        [JsonProperty("ORDPRSN")]
        public string OrderedByContact { get; set; }

        [JsonProperty("PRIORITY")]
        public string Priority { get; set; }

        [JsonProperty("PRJC")]
        public string Project { get; set; }
        public string REMARKS { get; set; }
        public string SERIES { get; set; }
        public string TASKCOMPLETE { get; set; }
        public string TRDR { get; set; }

        [JsonProperty("TRDR_GENTRDR_NAME")]
        public string TRDRGENTRDRNAME { get; set; }
        public string TRNDATE { get; set; }
    }

    public class GetSOTASKInput
    {
        public string FORM { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string KEY { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string LOCATEINFO { get; set; } = "ACTLINES:CNTR,CNTR_CNTR_NAME,LINENUM,MTRL,MTRL_MTRL_CODE,MTRL_MTRL_NAME,QTY1,SODTYPE,SRVDEBITTYPE,VALUE;SOACTION:ACCLEVEL,ACTOR,ACTPRSN,ACTPRSN_PRSN_CODE,ACTPRSN_PRSN_NAME,ACTPRSN_PRSN_NAME2,ACTSTATES,ACTSTATUS,ACTTYPE,BOOL01,BOOL02,BOOL03,BOOL04,BRANCH,CMPCODE,CMPSERIESNUM,CNTR,CNTR_CNTR_CODE,CNTR_CNTR_NAME,COMMENT,COMMENTS,DATE01,DATE02,DATE03,DATE04,DATE05,DURATION,FINALDATE,INSDATE,FINDOC,FINDOC_SRVCARD_FINCODE,FROMDATE,GQTY,GVAL,INST,INST_INST_CODE,INST_INST_NAME,ISLEAD,ISRESPONSE,LIKE,MSODTYPE,MTRL,MTRL_MTRL_CODE,MTRL_MTRL_NAME,NUM01,NUM02,NUM03,NUM04,NUM05,ORDEREDBY,ORDPRSN,ORDPRSN_PRSNIN_CODE,ORDPRSN_PRSNIN_NAME,ORDPRSN_PRSNIN_NAME2,PRIORITY,PRJC,PRJC_PRJC_CODE,PRJC_PRJC_NAME,PRJLINES,PRJLINES_PRJLINES_LINENUM,PRJLINES_PRJLINES_NAME,REMARKS,RSRC,RSRC_RSRC_CODE,RSRC_RSRC_NAME,SERIES,SHARE,SNCODE,SRVDEBITTYPE,TASKCOMPLETE,TRDBRANCH,TRDBRANCH_TRDBRANCH_CODE,TRDBRANCH_TRDBRANCH_NAME,TRDBRANCHS,TRDBRANCHS_TRDBRANCH_CODE,TRDBRANCHS_TRDBRANCH_NAME,TRDPRSN,TRDPRSN_PRSNOUT_CODE,TRDPRSN_PRSNOUT_NAME2,TRDPRSNS,TRDPRSNS_PRSNOUT_CODE,TRDPRSNS_PRSNOUT_NAME2,TRDR,TRDR_GENTRDR_CODE,TRDR_GENTRDR_NAME,TRDRS,TRDRS_GENTRDR_CODE,TRDRS_GENTRDR_NAME,TRNDATE,TSODTYPE,TSSODTYPE,UTBL01,UTBL02,UTBL03,UTBL04,UTBL05,VARCHAR01,VARCHAR02,VARCHAR03,VARCHAR04,VARCHAR05;VACTRMND:HASREMIND,RMBEFORE,RMDATE;VMTPRSN:PRSN,PRSN_PRSN_CODE,PRSN_PRSN_NAME2,RSRC,RSRC_RSRC_CODE,RSRC_RSRC_NAME,SODTYPE,USERS;XTRDOCDATA:LINENUM,SOFNAME";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string MODE { get; set; } = "1";

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
        public GetSupplierResponseValueTypeSUPBANKACCTypeItem[] SUPBANKACC { get; set; }
        public GetSupplierResponseValueTypeSUPPLIERType SUPPLIER { get; set; }
    }

    public class GetSupplierResponseValueTypeSUPBANKACCTypeItem
    {
        public string BANK { get; set; }

        [JsonProperty("BANK_BANK_CODE")]
        public string BANKBANKCODE { get; set; }
        public string IBAN { get; set; }
        public string LINENUM { get; set; }
        public string REMARKS { get; set; }
    }

    public class GetSupplierResponseValueTypeSUPPLIERType
    {
        public string ADDRESS { get; set; }
        public string AFM { get; set; }
        public string CITY { get; set; }
        public string CODE { get; set; }
        public string DISTRICT { get; set; }
        public string EMAIL { get; set; }
        public string FAX { get; set; }
        public string IRSDATA { get; set; }

        [JsonProperty("ISACTIVE")]
        public string Active { get; set; }
        public string JOBTYPETRD { get; set; }
        public string NAME { get; set; }
        public string PHONE01 { get; set; }
        public string REMARKS { get; set; }
        public string VATSTS { get; set; }
        public string ZIP { get; set; }
    }

    public class GetSupplierInput
    {
        [JsonProperty("APPID", DefaultValueHandling = DefaultValueHandling.Include)]
        internal int APPId { get; set; } = 702;
        public string FORM { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string KEY { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string LOCATEINFO { get; set; } = "SUPBANKACC:BANK,BANK_BANK_CODE,BANK_BANK_NAME,IBAN,LINENUM,REMARKS;SUPPLIER:ADDRESS,AFM,CITY,CODE,DISTRICT,EMAIL,FAX,IRSDATA,ISACTIVE,JOBTYPETRD,NAME,PHONE01,REMARKS,VATSTS,ZIP";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string MODE { get; set; } = "1";

        [JsonProperty("OBJECT", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ObjectEntity { get; set; } = "SUPPLIER";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string SERVICE { get; set; } = "getData";
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

    public class GetSystemParamsInput
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

    public class SetCFNCUSDOCInput
    {
        [JsonProperty("APPID", DefaultValueHandling = DefaultValueHandling.Include)]
        internal int APPId { get; set; } = 702;

        [JsonProperty("DATA", DefaultValueHandling = DefaultValueHandling.Include)]
        public SetCFNCUSDOCInputValueType Value { get; set; }
        public string FORM { get; set; }
        public string KEY { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string MODE { get; set; } = "1";

        [JsonProperty("OBJECT", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ObjectEntity { get; set; } = "CFNCUSDOC";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string SERVICE { get; set; } = "setData";
    }

    public class SetCFNCUSDOCInputValueType
    {
        public SetCFNCUSDOCInputValueTypeCARDLINESTypeItem[] CARDLINES { get; set; }
        public SetCFNCUSDOCInputValueTypeCASHLINESTypeItem[] CASHLINES { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public SetCFNCUSDOCInputValueTypeCFNCUSDOCType CFNCUSDOC { get; set; }
        public SetCFNCUSDOCInputValueTypeCHEQUELINESTypeItem[] CHEQUELINES { get; set; }
    }

    public class SetCFNCUSDOCInputValueTypeCARDLINESTypeItem
    {
        public string CRDCARDNUM { get; set; }
        public int? CREDITCARDS { get; set; }
        public int? LINENUM { get; set; }
        public int? LINEVAL { get; set; }
    }

    public class SetCFNCUSDOCInputValueTypeCASHLINESTypeItem
    {
        public int? LINENUM { get; set; }
        public int? LINEVAL { get; set; }
    }

    public class SetCFNCUSDOCInputValueTypeCFNCUSDOCType
    {
        public string COLLECTOR { get; set; }
        public string COMMENTS { get; set; }

        [JsonProperty("PRJC")]
        public string Project { get; set; }
        public string SALESMAN { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SERIES { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string TRDR { get; set; }
        public string TRNDATE { get; set; }
    }

    public class SetCFNCUSDOCInputValueTypeCHEQUELINESTypeItem
    {
        public string CCHEQUENUMBER { get; set; }
        public string CFINALDATE { get; set; }
        public string CODE { get; set; }
        public int? CSERIES { get; set; }

        [JsonProperty("LINENUM")]
        public int? ChequeLineNumber { get; set; }
        public int? LINEVAL { get; set; }

        [JsonProperty("TPRMS")]
        public int? ChequeTransactionType { get; set; }
    }

    public class SetCfnsupdocInput
    {
        [JsonProperty("APPID", DefaultValueHandling = DefaultValueHandling.Include)]
        internal int APPId { get; set; } = 702;

        [JsonProperty("DATA", DefaultValueHandling = DefaultValueHandling.Include)]
        public SetCfnsupdocInputValueType Value { get; set; }
        public string FORM { get; set; }
        public string KEY { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string MODE { get; set; } = "1";

        [JsonProperty("OBJECT", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ObjectEntity { get; set; } = "CFNSUPDOC";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string SERVICE { get; set; } = "setData";
    }

    public class SetCfnsupdocInputValueType
    {
        public SetCfnsupdocInputValueTypeCARDLINESTypeItem[] CARDLINES { get; set; }
        public SetCfnsupdocInputValueTypeCASHLINESTypeItem[] CASHLINES { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public SetCfnsupdocInputValueTypeCFNSUPDOCType CFNSUPDOC { get; set; }
        public SetCfnsupdocInputValueTypeCHEQUELINESTypeItem[] CHEQUELINES { get; set; }
    }

    public class SetCfnsupdocInputValueTypeCARDLINESTypeItem
    {
        public string CRDCARDNUM { get; set; }
        public int? CREDITCARDS { get; set; }
        public int? LINENUM { get; set; }
        public int? LINEVAL { get; set; }
    }

    public class SetCfnsupdocInputValueTypeCASHLINESTypeItem
    {
        [JsonProperty("LINENUM")]
        public int? CashLineNo { get; set; }

        [JsonProperty("LINEVAL")]
        public int? CashLineValue { get; set; }
    }

    public class SetCfnsupdocInputValueTypeCFNSUPDOCType
    {
        public string PRJC { get; set; }
        public string REMARKS { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SERIES { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string TRDR { get; set; }
        public string TRNDATE { get; set; }
    }

    public class SetCfnsupdocInputValueTypeCHEQUELINESTypeItem
    {
        public string CCHEQUENUMBER { get; set; }
        public string CFINALDATE { get; set; }
        public string CODE { get; set; }
        public int? CSERIES { get; set; }

        [JsonProperty("LINENUM")]
        public int? ChequeLineNumber { get; set; }
        public int? LINEVAL { get; set; }

        [JsonProperty("TPRMS")]
        public int? ChequeTransactionType { get; set; }
    }

    public class SetChequeInput
    {
        public string FORM { get; set; }
        public string KEY { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string MODE { get; set; } = "1";

        [JsonProperty("OBJECT", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ObjectEntity { get; set; } = "CHEQUE";

        [JsonProperty("appId", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string AppId { get; set; } = "702";

        [JsonProperty("data", DefaultValueHandling = DefaultValueHandling.Include)]
        public SetChequeInputValueType Value { get; set; }

        [JsonProperty("service", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Service { get; set; } = "setData";
    }

    public class SetChequeInputValueType
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public SetChequeInputValueTypeCHEQUEType CHEQUE { get; set; }
    }

    public class SetChequeInputValueTypeCHEQUEType
    {
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

    public class SetContactInput
    {
        public string FORM { get; set; }
        public string KEY { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string MODE { get; set; } = "1";

        [JsonProperty("OBJECT", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ObjectEntity { get; set; } = "PRSNOUT";

        [JsonProperty("appId", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string AppId { get; set; } = "702";

        [JsonProperty("data", DefaultValueHandling = DefaultValueHandling.Include)]
        public SetContactInputValueType Value { get; set; }

        [JsonProperty("service", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Service { get; set; } = "setData";
    }

    public class SetContactInputValueType
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public SetContactInputValueTypePRSNOUTType PRSNOUT { get; set; }
        public SetContactInputValueTypeXTRDOCDATATypeItem[] XTRDOCDATA { get; set; }
    }

    public class SetContactInputValueTypePRSNOUTType
    {
        [JsonProperty("ADDRESS")]
        public string Address { get; set; }

        [JsonProperty("AFM")]
        public string TRNo { get; set; }

        [JsonProperty("AREAS")]
        public string GeographicalAreas { get; set; }
        public string BIRTHDATE { get; set; }

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
        public string FatherSName { get; set; }

        [JsonProperty("NAME4")]
        public string MotherSName { get; set; }

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
        public SetContactInputValueTypePRSNOUTTypeGenderType? Gender { get; set; }

        [JsonProperty("WEBPAGE")]
        public string WebPage { get; set; }

        [JsonProperty("ZIP")]
        public string Zip { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SetContactInputValueTypePRSNOUTTypeGenderType
    {
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2
    }

    public class SetContactInputValueTypeXTRDOCDATATypeItem
    {
        [JsonProperty("LINENUM")]
        public string LineNo { get; set; }

        [JsonProperty("NAME")]
        public string Name { get; set; }

        [JsonProperty("SOFNAME")]
        public string Url { get; set; }
    }

    public class SetCustomerInput
    {
        public string FORM { get; set; }
        public string KEY { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string MODE { get; set; } = "1";

        [JsonProperty("OBJECT", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ObjectEntity { get; set; } = "CUSTOMER";

        [JsonProperty("appId", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string AppId { get; set; } = "702";

        [JsonProperty("data", DefaultValueHandling = DefaultValueHandling.Include)]
        public SetCustomerInputValueType Value { get; set; }

        [JsonProperty("service", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Service { get; set; } = "setData";
    }

    public class SetCustomerInputValueType
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public SetCustomerInputValueTypeCUSTOMERType CUSTOMER { get; set; }
    }

    public class SetCustomerInputValueTypeCUSTOMERType
    {
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
        public SetCustomerInputValueTypeCUSTOMERTypeTaxCategoryType? TaxCategory { get; set; }

        [JsonProperty("ZIP")]
        public string Zip { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SetCustomerInputValueTypeCUSTOMERTypeTaxCategoryType
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2
    }

    public class SetDraftEntryInput
    {
        public string FORM { get; set; }
        public string KEY { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string MODE { get; set; } = "1";

        [JsonProperty("OBJECT", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ObjectEntity { get; set; } = "SODRAFT";

        [JsonProperty("appId", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string AppId { get; set; } = "702";

        [JsonProperty("data", DefaultValueHandling = DefaultValueHandling.Include)]
        public SetDraftEntryInputValueType Value { get; set; }

        [JsonProperty("service", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Service { get; set; } = "setData";
    }

    public class SetDraftEntryInputValueType
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public SetDraftEntryInputValueTypeSODRAFTType SODRAFT { get; set; }
        public SetDraftEntryInputValueTypeSODRAFTLNKType SODRAFTLNK { get; set; }
    }

    public class SetDraftEntryInputValueTypeSODRAFTType
    {
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

    public class SetDraftEntryInputValueTypeSODRAFTLNKType
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

    public class SetExpenseInput
    {
        public string FORM { get; set; }
        public string KEY { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string MODE { get; set; } = "1";

        [JsonProperty("OBJECT", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ObjectEntity { get; set; } = "LINEITEM";

        [JsonProperty("appId", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string AppId { get; set; } = "702";

        [JsonProperty("data", DefaultValueHandling = DefaultValueHandling.Include)]
        public SetExpenseInputValueType Value { get; set; }

        [JsonProperty("service", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Service { get; set; } = "setData";
    }

    public class SetExpenseInputValueType
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public SetExpenseInputValueTypeLINEITEMType LINEITEM { get; set; }
    }

    public class SetExpenseInputValueTypeLINEITEMType
    {
        [JsonProperty("CODE", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Code { get; set; }

        [JsonProperty("LISOURCETYPE", DefaultValueHandling = DefaultValueHandling.Include)]
        public SetExpenseInputValueTypeLINEITEMTypeInvoicingCategoryType InvoicingCategory { get; set; }

        [JsonProperty("MTRCATEGORY")]
        public string CommercialCategory { get; set; }

        [JsonProperty("MTRTYPE")]
        public SetExpenseInputValueTypeLINEITEMTypeTypeType? Type { get; set; }

        [JsonProperty("NAME", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("REMARKS")]
        public string Comments { get; set; }

        [JsonProperty("SOPAYVALUE")]
        public SetExpenseInputValueTypeLINEITEMTypeFeeValueType? FeeValue { get; set; }

        [JsonProperty("VAT", DefaultValueHandling = DefaultValueHandling.Include)]
        public string VatGroup { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SetExpenseInputValueTypeLINEITEMTypeInvoicingCategoryType
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
    public enum SetExpenseInputValueTypeLINEITEMTypeTypeType
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SetExpenseInputValueTypeLINEITEMTypeFeeValueType
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

    public class SetExpensesDocInput
    {
        [JsonProperty("APPID", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string AppId { get; set; } = "702";

        [JsonProperty("DATA", DefaultValueHandling = DefaultValueHandling.Include)]
        public SetExpensesDocInputValueType Value { get; set; }
        public string FORM { get; set; }
        public string KEY { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string MODE { get; set; } = "1";

        [JsonProperty("OBJECT", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ObjectEntity { get; set; } = "LINSUPDOC";

        [JsonProperty("SERVICE", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Service { get; set; } = "setData";
    }

    public class SetExpensesDocInputValueType
    {
        [JsonProperty("LINLINES")]
        public SetExpensesDocInputValueTypeUnnamedTypeItem[] Unnamed { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public SetExpensesDocInputValueTypeLINSUPDOCType LINSUPDOC { get; set; }
    }

    public class SetExpensesDocInputValueTypeUnnamedTypeItem
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

    public class SetExpensesDocInputValueTypeLINSUPDOCType
    {
        [JsonProperty("PRJC")]
        public string Project { get; set; }

        [JsonProperty("REMARKS")]
        public string Comments { get; set; }

        [JsonProperty("SERIES", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Series { get; set; }

        [JsonProperty("TRDR", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Supplier { get; set; }
        public string TRNDATE { get; set; }
    }

    public class SetItedocInput
    {
        public string FORM { get; set; }
        public string KEY { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string MODE { get; set; } = "1";

        [JsonProperty("OBJECT", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ObjectEntity { get; set; } = "ITEDOC";

        [JsonProperty("appId", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string AppId { get; set; } = "702";

        [JsonProperty("data", DefaultValueHandling = DefaultValueHandling.Include)]
        public SetItedocInputValueType Value { get; set; }

        [JsonProperty("service", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Service { get; set; } = "setData";
    }

    public class SetItedocInputValueType
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public SetItedocInputValueTypeITEDOCType ITEDOC { get; set; }
        public SetItedocInputValueTypeITELINESTypeItem[] ITELINES { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public SetItedocInputValueTypeMTRDOCType MTRDOC { get; set; }
    }

    public class SetItedocInputValueTypeITEDOCType
    {
        [JsonProperty("COMMENTS")]
        public string Reason { get; set; }
        public string REMARKS { get; set; }

        [JsonProperty("SERIES", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Series { get; set; }
        public string TRNDATE { get; set; }
    }

    public class SetItedocInputValueTypeITELINESTypeItem
    {
        [JsonProperty("DISC1PRC")]
        public string Discount { get; set; }

        [JsonProperty("LINENUM")]
        public string LineNo { get; set; }

        [JsonProperty("LINEVAL")]
        public string LineValue { get; set; }

        [JsonProperty("MTRL")]
        public string Item { get; set; }
        public string PRICE { get; set; }

        [JsonProperty("QTY")]
        public string Quantity { get; set; }
    }

    public class SetItedocInputValueTypeMTRDOCType
    {
        [JsonProperty("WHOUSE", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Warehouse { get; set; }
    }

    public class SetItemInput
    {
        public string FORM { get; set; }
        public string KEY { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string MODE { get; set; } = "1";

        [JsonProperty("OBJECT", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ObjectEntity { get; set; } = "ITEM";

        [JsonProperty("appId", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string AppId { get; set; } = "702";

        [JsonProperty("data", DefaultValueHandling = DefaultValueHandling.Include)]
        public SetItemInputValueType Value { get; set; }

        [JsonProperty("service", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Service { get; set; } = "setData";
    }

    public class SetItemInputValueType
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public SetItemInputValueTypeITEMType ITEM { get; set; }
    }

    public class SetItemInputValueTypeITEMType
    {
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

    public class SetProjectInput
    {
        public string FORM { get; set; }
        public string KEY { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string MODE { get; set; } = "1";

        [JsonProperty("OBJECT", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ObjectEntity { get; set; } = "PRJC";

        [JsonProperty("appId", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string AppId { get; set; } = "702";

        [JsonProperty("data", DefaultValueHandling = DefaultValueHandling.Include)]
        public SetProjectInputValueType Value { get; set; }

        [JsonProperty("service", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Service { get; set; } = "setData";
    }

    public class SetProjectInputValueType
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public SetProjectInputValueTypePRJCType PRJC { get; set; }
        public SetProjectInputValueTypeXTRDOCDATATypeItem[] XTRDOCDATA { get; set; }
    }

    public class SetProjectInputValueTypePRJCType
    {
        public SetProjectInputValueTypePRJCTypeACTSTATUSType? ACTSTATUS { get; set; }

        [JsonProperty("CODE", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Code { get; set; }
        public string FINALDATE { get; set; }
        public string FROMDATE { get; set; }

        [JsonProperty("NAME", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }
        public SetProjectInputValueTypePRJCTypePRJCRMType? PRJCRM { get; set; }

        [JsonProperty("REMARKS")]
        public string Comments { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SetProjectInputValueTypePRJCTypeACTSTATUSType
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
    public enum SetProjectInputValueTypePRJCTypePRJCRMType
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2
    }

    public class SetProjectInputValueTypeXTRDOCDATATypeItem
    {
        [JsonProperty("LINENUM")]
        public string LineNo { get; set; }

        [JsonProperty("NAME")]
        public string Name { get; set; }

        [JsonProperty("SOFNAME")]
        public string Url { get; set; }
    }

    public class SetPurdocInput
    {
        [JsonProperty("APPID", DefaultValueHandling = DefaultValueHandling.Include)]
        internal int APPId { get; set; } = 702;

        [JsonProperty("DATA", DefaultValueHandling = DefaultValueHandling.Include)]
        public SetPurdocInputValueType Value { get; set; }
        public string FORM { get; set; }
        public string KEY { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string MODE { get; set; } = "1";

        [JsonProperty("OBJECT", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ObjectEntity { get; set; } = "PURDOC";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string SERVICE { get; set; } = "setData";
    }

    public class SetPurdocInputValueType
    {
        public SetPurdocInputValueTypeITELINESTypeItem[] ITELINES { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public SetPurdocInputValueTypeMTRDOCType MTRDOC { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public SetPurdocInputValueTypePURDOCType PURDOC { get; set; }
        public SetPurdocInputValueTypeSRVLINESTypeItem[] SRVLINES { get; set; }
    }

    public class SetPurdocInputValueTypeITELINESTypeItem
    {
        public int? DISC1PRC { get; set; }

        [JsonProperty("LINENUM")]
        public string LineNo { get; set; }

        [JsonProperty("LINEVAL")]
        public string LineValue { get; set; }
        public string MTRL { get; set; }
        public string PRICE { get; set; }
        public int? QTY { get; set; }
    }

    public class SetPurdocInputValueTypeMTRDOCType
    {
        [JsonProperty("WHOUSE", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Warehouse { get; set; }
    }

    public class SetPurdocInputValueTypePURDOCType
    {
        public string DISC1PRC { get; set; }
        public string PAYMENT { get; set; }
        public string PRJC { get; set; }
        public string REMARKS { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SERIES { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SOCURRENCY { get; set; }
        public string SUMAMNT { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string TRDR { get; set; }
        public string TRNDATE { get; set; }
    }

    public class SetPurdocInputValueTypeSRVLINESTypeItem
    {
        public int? DISC1PRC { get; set; }

        [JsonProperty("LINENUM")]
        public string LineNo { get; set; }

        [JsonProperty("LINEVAL")]
        public string LineValue { get; set; }
        public string MTRL { get; set; }
        public string PRICE { get; set; }
        public int? QTY { get; set; }
    }

    public class SetSaldocInput
    {
        public string FORM { get; set; }
        public string KEY { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string MODE { get; set; } = "1";

        [JsonProperty("OBJECT", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ObjectEntity { get; set; } = "SALDOC";

        [JsonProperty("appId", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string AppId { get; set; } = "702";

        [JsonProperty("data", DefaultValueHandling = DefaultValueHandling.Include)]
        public SetSaldocInputValueType Value { get; set; }

        [JsonProperty("service", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Service { get; set; } = "setData";
    }

    public class SetSaldocInputValueType
    {
        public SetSaldocInputValueTypeITELINESTypeItem[] ITELINES { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public SetSaldocInputValueTypeMTRDOCType MTRDOC { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public SetSaldocInputValueTypeSALDOCType SALDOC { get; set; }
        public SetSaldocInputValueTypeSRVLINESTypeItem[] SRVLINES { get; set; }
    }

    public class SetSaldocInputValueTypeITELINESTypeItem
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

    public class SetSaldocInputValueTypeMTRDOCType
    {
        [JsonProperty("WHOUSE", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Warehouse { get; set; }
    }

    public class SetSaldocInputValueTypeSALDOCType
    {
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
        public string TRNDATE { get; set; }

        [JsonProperty("VATAMNT")]
        public string VAT { get; set; }
    }

    public class SetSaldocInputValueTypeSRVLINESTypeItem
    {
        public int? DISC1PRC { get; set; }

        [JsonProperty("LINENUM")]
        public string LineNo { get; set; }

        [JsonProperty("LINEVAL")]
        public string LineValue { get; set; }
        public string MTRL { get; set; }

        [JsonProperty("PRICE")]
        public string Price { get; set; }
        public int? QTY { get; set; }
    }

    public class SetServiceInput
    {
        public string FORM { get; set; }
        public string KEY { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string MODE { get; set; } = "1";

        [JsonProperty("OBJECT", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ObjectEntity { get; set; } = "SERVICE";

        [JsonProperty("appId", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string AppId { get; set; } = "702";

        [JsonProperty("data", DefaultValueHandling = DefaultValueHandling.Include)]
        public SetServiceInputValueType Value { get; set; }

        [JsonProperty("service", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Service { get; set; } = "setData";
    }

    public class SetServiceInputValueType
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public SetServiceInputValueTypeSERVICEType SERVICE { get; set; }
    }

    public class SetServiceInputValueTypeSERVICEType
    {
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

    public class SetSOEMAILInput
    {
        [JsonProperty("APPID", DefaultValueHandling = DefaultValueHandling.Include)]
        internal int APPId { get; set; } = 702;

        [JsonProperty("DATA", DefaultValueHandling = DefaultValueHandling.Include)]
        public SetSOEMAILInputValueType Value { get; set; }
        public string FORM { get; set; }
        public string KEY { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string MODE { get; set; } = "1";

        [JsonProperty("OBJECT", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ObjectEntity { get; set; } = "SOEMAIL";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string SERVICE { get; set; } = "setData";
    }

    public class SetSOEMAILInputValueType
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public SetSOEMAILInputValueTypeSOACTIONType SOACTION { get; set; }
        public SetSOEMAILInputValueTypeSOMAILType SOMAIL { get; set; }
        public SetSOEMAILInputValueTypeXTRDOCDATATypeItem[] XTRDOCDATA { get; set; }
    }

    public class SetSOEMAILInputValueTypeSOACTIONType
    {
        public SetSOEMAILInputValueTypeSOACTIONTypeACTSTATUSType? ACTSTATUS { get; set; }
        public string COMMENTS { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SERIES { get; set; }
        public string TRNDATE { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SetSOEMAILInputValueTypeSOACTIONTypeACTSTATUSType
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

    public class SetSOEMAILInputValueTypeSOMAILType
    {
        public string FROMADDRESS { get; set; }
        public string FROMNAME { get; set; }
        public string SOBCC { get; set; }
        public string SOBODY { get; set; }
        public string SOCC { get; set; }
        public string SOTO { get; set; }
    }

    public class SetSOEMAILInputValueTypeXTRDOCDATATypeItem
    {
        [JsonProperty("LINENUM")]
        public string LineNo { get; set; }

        [JsonProperty("NAME")]
        public string Name { get; set; }

        [JsonProperty("SOFNAME")]
        public string Url { get; set; }
    }

    public class SetMeetingInput
    {
        [JsonProperty("APPID", DefaultValueHandling = DefaultValueHandling.Include)]
        internal int APPId { get; set; } = 702;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public SetMeetingInputDATAType DATA { get; set; }
        public string FORM { get; set; }
        public string KEY { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string MODE { get; set; } = "1";

        [JsonProperty("OBJECT", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ObjectEntity { get; set; } = "SOMEETING";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string SERVICE { get; set; } = "setData";
    }

    public class SetMeetingInputDATAType
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public SetMeetingInputDATATypeSOACTIONType SOACTION { get; set; }
        public SetMeetingInputDATATypeXTRDOCDATATypeItem[] XTRDOCDATA { get; set; }
    }

    public class SetMeetingInputDATATypeSOACTIONType
    {
        [JsonProperty("ACTOR")]
        public string Operator { get; set; }

        [JsonProperty("ACTPRSN")]
        public string OperatorContact { get; set; }
        public SetMeetingInputDATATypeSOACTIONTypeACTSTATUSType? ACTSTATUS { get; set; }
        public string COMMENTS { get; set; }
        public string FINALDATE { get; set; }
        public string FROMDATE { get; set; }

        [JsonProperty("ORDEREDBY")]
        public string OrderedBy { get; set; }

        [JsonProperty("ORDPRSN")]
        public string OrderedByContact { get; set; }

        [JsonProperty("PRIORITY")]
        public string Priority { get; set; }

        [JsonProperty("PRJC")]
        public string Project { get; set; }
        public string REMARKS { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SERIES { get; set; }
        public string TRDR { get; set; }
        public string TRNDATE { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SetMeetingInputDATATypeSOACTIONTypeACTSTATUSType
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

    public class SetMeetingInputDATATypeXTRDOCDATATypeItem
    {
        [JsonProperty("LINENUM")]
        public string LineNo { get; set; }

        [JsonProperty("NAME")]
        public string Name { get; set; }

        [JsonProperty("SOFNAME")]
        public string Url { get; set; }
    }

    public class SetSOTASKInput
    {
        [JsonProperty("APPID", DefaultValueHandling = DefaultValueHandling.Include)]
        internal int APPId { get; set; } = 702;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public SetSOTASKInputDATAType DATA { get; set; }
        public string FORM { get; set; }
        public string KEY { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string MODE { get; set; } = "1";

        [JsonProperty("OBJECT", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ObjectEntity { get; set; } = "SOTASK";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string SERVICE { get; set; } = "setData";
    }

    public class SetSOTASKInputDATAType
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public SetSOTASKInputDATATypeSOACTIONType SOACTION { get; set; }
        public SetSOTASKInputDATATypeXTRDOCDATATypeItem[] XTRDOCDATA { get; set; }
    }

    public class SetSOTASKInputDATATypeSOACTIONType
    {
        [JsonProperty("ACTOR")]
        public string Operator { get; set; }

        [JsonProperty("ACTPRSN")]
        public string OperatorContact { get; set; }
        public SetSOTASKInputDATATypeSOACTIONTypeACTSTATUSType? ACTSTATUS { get; set; }
        public string COMMENTS { get; set; }
        public string FINALDATE { get; set; }
        public string FROMDATE { get; set; }

        [JsonProperty("ORDEREDBY")]
        public string OrderedBy { get; set; }

        [JsonProperty("ORDPRSN")]
        public string OrderedByContact { get; set; }

        [JsonProperty("PRIORITY")]
        public string Priority { get; set; }

        [JsonProperty("PRJC")]
        public string Project { get; set; }
        public string REMARKS { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SERIES { get; set; }
        public string TRDR { get; set; }
        public string TRNDATE { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SetSOTASKInputDATATypeSOACTIONTypeACTSTATUSType
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

    public class SetSOTASKInputDATATypeXTRDOCDATATypeItem
    {
        [JsonProperty("LINENUM")]
        public string LineNo { get; set; }

        [JsonProperty("NAME")]
        public string Name { get; set; }

        [JsonProperty("SOFNAME")]
        public string Url { get; set; }
    }

    public class SetSupplierInput
    {
        [JsonProperty("APPID", DefaultValueHandling = DefaultValueHandling.Include)]
        internal int APPId { get; set; } = 702;

        [JsonProperty("DATA", DefaultValueHandling = DefaultValueHandling.Include)]
        public SetSupplierInputValueType Value { get; set; }
        public string FORM { get; set; }
        public string KEY { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string MODE { get; set; } = "1";

        [JsonProperty("OBJECT", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ObjectEntity { get; set; } = "SUPPLIER";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string SERVICE { get; set; } = "setData";
    }

    public class SetSupplierInputValueType
    {
        public SetSupplierInputValueTypeSUPBANKACCTypeItem[] SUPBANKACC { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public SetSupplierInputValueTypeSUPPLIERType SUPPLIER { get; set; }
    }

    public class SetSupplierInputValueTypeSUPBANKACCTypeItem
    {
        public string BANK { get; set; }
        public string IBAN { get; set; }
        public string REMARKS { get; set; }
    }

    public class SetSupplierInputValueTypeSUPPLIERType
    {
        public string ADDRESS { get; set; }
        public string AFM { get; set; }
        public string CITY { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string CODE { get; set; }
        public string DISTRICT { get; set; }
        public string EMAIL { get; set; }
        public string FAX { get; set; }
        public string IRSDATA { get; set; }
        public string JOBTYPETRD { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string NAME { get; set; }
        public string PHONE01 { get; set; }
        public string REMARKS { get; set; }
        public string ZIP { get; set; }
    }

    public class WebhookInput
    {
        [JsonProperty("condition")]
        public string Condition { get; set; }

        [JsonProperty("config", DefaultValueHandling = DefaultValueHandling.Include)]
        public WebhookInputConfigType Config { get; set; }

        [JsonProperty("event", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Event { get; set; } = "ONPOST";

        [JsonProperty("object", DefaultValueHandling = DefaultValueHandling.Include)]
        public WebhookInputObjectEntityType ObjectEntity { get; set; }
    }

    public class WebhookInputConfigType
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum WebhookInputObjectEntityType
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

    public class WebhookOnDeleteInput
    {
        [JsonProperty("condition")]
        public string Condition { get; set; }

        [JsonProperty("config", DefaultValueHandling = DefaultValueHandling.Include)]
        public WebhookOnDeleteInputConfigType Config { get; set; }

        [JsonProperty("event", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Event { get; set; } = "ONDELETE";

        [JsonProperty("object", DefaultValueHandling = DefaultValueHandling.Include)]
        public WebhookOnDeleteInputObjectEntityType ObjectEntity { get; set; }
    }

    public class WebhookOnDeleteInputConfigType
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum WebhookOnDeleteInputObjectEntityType
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

    public class WebhookOnInsertInput
    {
        [JsonProperty("condition")]
        public string Condition { get; set; }

        [JsonProperty("config", DefaultValueHandling = DefaultValueHandling.Include)]
        public WebhookOnInsertInputConfigType Config { get; set; }

        [JsonProperty("event", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Event { get; set; } = "ONINSERT";

        [JsonProperty("object", DefaultValueHandling = DefaultValueHandling.Include)]
        public WebhookOnInsertInputObjectEntityType ObjectEntity { get; set; }
    }

    public class WebhookOnInsertInputConfigType
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum WebhookOnInsertInputObjectEntityType
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

    public class WebhookOnUpdateInput
    {
        [JsonProperty("condition")]
        public string Condition { get; set; }

        [JsonProperty("config", DefaultValueHandling = DefaultValueHandling.Include)]
        public WebhookOnUpdateInputConfigType Config { get; set; }

        [JsonProperty("event", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Event { get; set; } = "ONUPDATE";

        [JsonProperty("object", DefaultValueHandling = DefaultValueHandling.Include)]
        public WebhookOnUpdateInputObjectEntityType ObjectEntity { get; set; }
    }

    public class WebhookOnUpdateInputConfigType
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum WebhookOnUpdateInputObjectEntityType
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