//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Requestor
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RequestorActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "requestor")]
        public IWorkflowAction CreateTicket(Expression<Func<int>> bodyType, Expression<Func<int>> bodyServiceId, Expression<Func<string>> bodySubject, Expression<Func<string>> bodyMessage, Expression<Func<string>> bodySubmitterEmail, Expression<Func<string>> bodySolverUserProviderKey = null)
        {
            var apiCallPath = "/api/Tickets/NewTicket";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["Type"] = ExpressionConverter.ConvertO(bodyType);
            bodypropCount++;
            body["ServiceId"] = ExpressionConverter.ConvertO(bodyServiceId);
            bodypropCount++;
            body["Subject"] = ExpressionConverter.ConvertO(bodySubject);
            bodypropCount++;
            body["Message"] = ExpressionConverter.ConvertO(bodyMessage);
            bodypropCount++;
            body["SubmitterEmail"] = ExpressionConverter.ConvertO(bodySubmitterEmail);
            if (bodySolverUserProviderKey != null)
            {
                body["SolverUserProviderKey"] = ExpressionConverter.ConvertO(bodySolverUserProviderKey);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "requestor")]
        public IWorkflowAction CreateUser(Expression<Func<string>> bodyUserName, Expression<Func<bool>> bodyChangePasswordAfterLogging, Expression<Func<string>> bodyEmail = null, Expression<Func<string>> bodyPassword = null, Expression<Func<bool>> bodyRoleEndUser = null, Expression<Func<bool>> bodyRoleSmartUser = null, Expression<Func<bool>> bodyRoleOperator = null, Expression<Func<bool>> bodyRoleSuperOperator = null, Expression<Func<bool>> bodyRoleAdministrator = null, Expression<Func<string>> bodyFirstName = null, Expression<Func<string>> bodyLastName = null, Expression<Func<string>> bodyMiddleName = null, Expression<Func<string>> bodyDisplayName = null, Expression<Func<string>> bodyPhone = null, Expression<Func<string>> bodyAdminNote = null, Expression<Func<string>> bodyAdditionalInformation = null, Expression<Func<string[]>> bodyCustomerNames = null)
        {
            var apiCallPath = "/api/Account/CreateRequestorUser";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["UserName"] = ExpressionConverter.ConvertO(bodyUserName);
            if (bodyEmail != null)
            {
                body["Email"] = ExpressionConverter.ConvertO(bodyEmail);
                bodypropCount++;
            }

            if (bodyPassword != null)
            {
                body["Password"] = ExpressionConverter.ConvertO(bodyPassword);
                bodypropCount++;
            }

            if (bodyRoleEndUser != null)
            {
                body["RoleEndUser"] = ExpressionConverter.ConvertO(bodyRoleEndUser);
                bodypropCount++;
            }

            if (bodyRoleSmartUser != null)
            {
                body["RoleSmartUser"] = ExpressionConverter.ConvertO(bodyRoleSmartUser);
                bodypropCount++;
            }

            if (bodyRoleOperator != null)
            {
                body["RoleOperator"] = ExpressionConverter.ConvertO(bodyRoleOperator);
                bodypropCount++;
            }

            if (bodyRoleSuperOperator != null)
            {
                body["RoleSuperOperator"] = ExpressionConverter.ConvertO(bodyRoleSuperOperator);
                bodypropCount++;
            }

            if (bodyRoleAdministrator != null)
            {
                body["RoleAdministrator"] = ExpressionConverter.ConvertO(bodyRoleAdministrator);
                bodypropCount++;
            }

            if (bodyFirstName != null)
            {
                body["FirstName"] = ExpressionConverter.ConvertO(bodyFirstName);
                bodypropCount++;
            }

            if (bodyLastName != null)
            {
                body["LastName"] = ExpressionConverter.ConvertO(bodyLastName);
                bodypropCount++;
            }

            if (bodyMiddleName != null)
            {
                body["MiddleName"] = ExpressionConverter.ConvertO(bodyMiddleName);
                bodypropCount++;
            }

            if (bodyDisplayName != null)
            {
                body["DisplayName"] = ExpressionConverter.ConvertO(bodyDisplayName);
                bodypropCount++;
            }

            if (bodyPhone != null)
            {
                body["Phone"] = ExpressionConverter.ConvertO(bodyPhone);
                bodypropCount++;
            }

            bodypropCount++;
            body["ChangePasswordAfterLogging"] = ExpressionConverter.ConvertO(bodyChangePasswordAfterLogging);
            if (bodyAdminNote != null)
            {
                body["AdminNote"] = ExpressionConverter.ConvertO(bodyAdminNote);
                bodypropCount++;
            }

            if (bodyAdditionalInformation != null)
            {
                body["AdditionalInformation"] = ExpressionConverter.ConvertO(bodyAdditionalInformation);
                bodypropCount++;
            }

            if (bodyCustomerNames != null)
            {
                body["CustomerNames"] = ExpressionConverter.ConvertO(bodyCustomerNames);
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
        public IWorkflowTrigger TicketCreated()
        {
            var apiCallPath = "/api/PowerAutomate/CreateTicketCreatedTrigger";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["CallbackUrl"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload);
        }

        public IWorkflowTrigger UserCreated()
        {
            var apiCallPath = "/api/PowerAutomate/CreateUserCreatedTrigger";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["CallbackUrl"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload);
        }

        public IWorkflowTrigger TicketMonitoring()
        {
            var apiCallPath = "/api/PowerAutomate/CreateTicketMonitoringTrigger";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["CallbackUrl"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload);
        }

        public IWorkflowTrigger TicketStateChange()
        {
            var apiCallPath = "/api/PowerAutomate/CreateTicketStateChangeTrigger";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["CallbackUrl"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload);
        }

        public IWorkflowTrigger TicketCategoryChange()
        {
            var apiCallPath = "/api/PowerAutomate/CreateTicketCategoryChangeTrigger";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["CallbackUrl"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload);
        }

        public IWorkflowTrigger TicketCustomFormChange()
        {
            var apiCallPath = "/api/PowerAutomate/CreateTicketCustomFormChangeTrigger";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["CallbackUrl"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload);
        }

        public IWorkflowTrigger UserUpdated()
        {
            var apiCallPath = "/api/PowerAutomate/CreateUserUpdatedTrigger";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["CallbackUrl"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload);
        }

        public IWorkflowTrigger UserDeleted()
        {
            var apiCallPath = "/api/PowerAutomate/CreateUserDeletedTrigger";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["CallbackUrl"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload);
        }

        public IWorkflowTrigger CompanyCreated()
        {
            var apiCallPath = "/api/PowerAutomate/CreateCompanyCreatedTrigger";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["CallbackUrl"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload);
        }

        public IWorkflowTrigger CompanyUpdated()
        {
            var apiCallPath = "/api/PowerAutomate/CreateCompanyUpdatedTrigger";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["CallbackUrl"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload);
        }

        public IWorkflowTrigger CompanyDeleted()
        {
            var apiCallPath = "/api/PowerAutomate/CreateCompanyDeletedTrigger";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["CallbackUrl"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload);
        }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Requestor;

    public partial class WorkflowManagedActions
    {
        public RequestorActions Requestor(string connectionId) => new RequestorActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public RequestorTriggers Requestor(string connectionId) => new RequestorTriggers(connectionId);
    }
}