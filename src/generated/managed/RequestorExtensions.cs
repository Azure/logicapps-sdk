//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Requestor
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RequestorActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "requestor")]
        public IWorkflowAction CreateTicket(Expression<Func<int>> bodytype, Expression<Func<int>> bodyserviceId, Expression<Func<string>> bodysubject, Expression<Func<string>> bodymessage, Expression<Func<string>> bodysubmitterEmail, Expression<Func<string>> bodysolverUserProviderKey = null)
        {
            var apiCallPath = "/api/Tickets/NewTicket";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["Type"] = ExpressionConverter.ConvertO(bodytype);
            bodypropCount++;
            body["ServiceId"] = ExpressionConverter.ConvertO(bodyserviceId);
            bodypropCount++;
            body["Subject"] = ExpressionConverter.ConvertO(bodysubject);
            bodypropCount++;
            body["Message"] = ExpressionConverter.ConvertO(bodymessage);
            bodypropCount++;
            body["SubmitterEmail"] = ExpressionConverter.ConvertO(bodysubmitterEmail);
            if (bodysolverUserProviderKey != null)
            {
                body["SolverUserProviderKey"] = ExpressionConverter.ConvertO(bodysolverUserProviderKey);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "requestor")]
        public IWorkflowAction CreateUser(Expression<Func<string>> bodyuserName, Expression<Func<bool>> bodychangePasswordAfterLogging, Expression<Func<string>> bodyemail = null, Expression<Func<string>> bodypassword = null, Expression<Func<bool>> bodyroleEndUser = null, Expression<Func<bool>> bodyroleSmartUser = null, Expression<Func<bool>> bodyroleOperator = null, Expression<Func<bool>> bodyroleSuperOperator = null, Expression<Func<bool>> bodyroleAdministrator = null, Expression<Func<string>> bodyfirstName = null, Expression<Func<string>> bodylastName = null, Expression<Func<string>> bodymiddleName = null, Expression<Func<string>> bodydisplayName = null, Expression<Func<string>> bodyphone = null, Expression<Func<string>> bodyadminNote = null, Expression<Func<string>> bodyadditionalInformation = null, Expression<Func<string[]>> bodycustomerNames = null)
        {
            var apiCallPath = "/api/Account/CreateRequestorUser";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["UserName"] = ExpressionConverter.ConvertO(bodyuserName);
            if (bodyemail != null)
            {
                body["Email"] = ExpressionConverter.ConvertO(bodyemail);
                bodypropCount++;
            }

            if (bodypassword != null)
            {
                body["Password"] = ExpressionConverter.ConvertO(bodypassword);
                bodypropCount++;
            }

            if (bodyroleEndUser != null)
            {
                body["RoleEndUser"] = ExpressionConverter.ConvertO(bodyroleEndUser);
                bodypropCount++;
            }

            if (bodyroleSmartUser != null)
            {
                body["RoleSmartUser"] = ExpressionConverter.ConvertO(bodyroleSmartUser);
                bodypropCount++;
            }

            if (bodyroleOperator != null)
            {
                body["RoleOperator"] = ExpressionConverter.ConvertO(bodyroleOperator);
                bodypropCount++;
            }

            if (bodyroleSuperOperator != null)
            {
                body["RoleSuperOperator"] = ExpressionConverter.ConvertO(bodyroleSuperOperator);
                bodypropCount++;
            }

            if (bodyroleAdministrator != null)
            {
                body["RoleAdministrator"] = ExpressionConverter.ConvertO(bodyroleAdministrator);
                bodypropCount++;
            }

            if (bodyfirstName != null)
            {
                body["FirstName"] = ExpressionConverter.ConvertO(bodyfirstName);
                bodypropCount++;
            }

            if (bodylastName != null)
            {
                body["LastName"] = ExpressionConverter.ConvertO(bodylastName);
                bodypropCount++;
            }

            if (bodymiddleName != null)
            {
                body["MiddleName"] = ExpressionConverter.ConvertO(bodymiddleName);
                bodypropCount++;
            }

            if (bodydisplayName != null)
            {
                body["DisplayName"] = ExpressionConverter.ConvertO(bodydisplayName);
                bodypropCount++;
            }

            if (bodyphone != null)
            {
                body["Phone"] = ExpressionConverter.ConvertO(bodyphone);
                bodypropCount++;
            }

            bodypropCount++;
            body["ChangePasswordAfterLogging"] = ExpressionConverter.ConvertO(bodychangePasswordAfterLogging);
            if (bodyadminNote != null)
            {
                body["AdminNote"] = ExpressionConverter.ConvertO(bodyadminNote);
                bodypropCount++;
            }

            if (bodyadditionalInformation != null)
            {
                body["AdditionalInformation"] = ExpressionConverter.ConvertO(bodyadditionalInformation);
                bodypropCount++;
            }

            if (bodycustomerNames != null)
            {
                body["CustomerNames"] = ExpressionConverter.ConvertO(bodycustomerNames);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }
    }

    public class RequestorTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger TicketCreated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/api/PowerAutomate/CreateTicketCreatedTrigger";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["CallbackUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger UserCreated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/api/PowerAutomate/CreateUserCreatedTrigger";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["CallbackUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger TicketMonitoring(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/api/PowerAutomate/CreateTicketMonitoringTrigger";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["CallbackUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger TicketStateChange(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/api/PowerAutomate/CreateTicketStateChangeTrigger";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["CallbackUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger TicketCategoryChange(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/api/PowerAutomate/CreateTicketCategoryChangeTrigger";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["CallbackUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger TicketCustomFormChange(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/api/PowerAutomate/CreateTicketCustomFormChangeTrigger";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["CallbackUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger UserUpdated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/api/PowerAutomate/CreateUserUpdatedTrigger";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["CallbackUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger UserDeleted(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/api/PowerAutomate/CreateUserDeletedTrigger";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["CallbackUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger CompanyCreated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/api/PowerAutomate/CreateCompanyCreatedTrigger";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["CallbackUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger CompanyUpdated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/api/PowerAutomate/CreateCompanyUpdatedTrigger";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["CallbackUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger CompanyDeleted(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/api/PowerAutomate/CreateCompanyDeletedTrigger";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["CallbackUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Requestor;

    public partial class WorkflowManagedActions
    {
        public RequestorActions Requestor(string connectionId) => new RequestorActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public RequestorTriggers Requestor(string connectionId) => new RequestorTriggers(connectionId);
    }
}