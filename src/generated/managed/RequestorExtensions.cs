//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Requestor
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RequestorActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "requestor")]
        public IWorkflowAction CreateTicket(Expression<Func<int>> bodytype, Expression<Func<int>> bodyserviceId, Expression<Func<string>> bodysubject, Expression<Func<string>> bodymessage, Expression<Func<string>> bodysubmitterEmail, Expression<Func<string>> bodysolverUserProviderKey = null)
        {
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: true);
            var __workflow_bodyserviceId = WorkflowExpression.Compile(bodyserviceId, nameof(bodyserviceId), required: true);
            var __workflow_bodysubject = WorkflowExpression.Compile(bodysubject, nameof(bodysubject), required: true);
            var __workflow_bodymessage = WorkflowExpression.Compile(bodymessage, nameof(bodymessage), required: true);
            var __workflow_bodysubmitterEmail = WorkflowExpression.Compile(bodysubmitterEmail, nameof(bodysubmitterEmail), required: true);
            var __workflow_bodysolverUserProviderKey = WorkflowExpression.Compile(bodysolverUserProviderKey, nameof(bodysolverUserProviderKey), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/Tickets/NewTicket";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                bodypropCount++;
                body["ServiceId"] = ExpressionConverter.ConvertO(__workflow_bodyserviceId);
                bodypropCount++;
                body["Subject"] = ExpressionConverter.ConvertO(__workflow_bodysubject);
                bodypropCount++;
                body["Message"] = ExpressionConverter.ConvertO(__workflow_bodymessage);
                bodypropCount++;
                body["SubmitterEmail"] = ExpressionConverter.ConvertO(__workflow_bodysubmitterEmail);
                if (__workflow_bodysolverUserProviderKey != null)
                {
                    body["SolverUserProviderKey"] = ExpressionConverter.ConvertO(__workflow_bodysolverUserProviderKey);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "requestor")]
        public IWorkflowAction CreateUser(Expression<Func<string>> bodyuserName, Expression<Func<bool>> bodychangePasswordAfterLogging, Expression<Func<string>> bodyemail = null, Expression<Func<string>> bodypassword = null, Expression<Func<bool>> bodyroleEndUser = null, Expression<Func<bool>> bodyroleSmartUser = null, Expression<Func<bool>> bodyroleOperator = null, Expression<Func<bool>> bodyroleSuperOperator = null, Expression<Func<bool>> bodyroleAdministrator = null, Expression<Func<string>> bodyfirstName = null, Expression<Func<string>> bodylastName = null, Expression<Func<string>> bodymiddleName = null, Expression<Func<string>> bodydisplayName = null, Expression<Func<string>> bodyphone = null, Expression<Func<string>> bodyadminNote = null, Expression<Func<string>> bodyadditionalInformation = null, Expression<Func<string[]>> bodycustomerNames = null)
        {
            var __workflow_bodyuserName = WorkflowExpression.Compile(bodyuserName, nameof(bodyuserName), required: true);
            var __workflow_bodychangePasswordAfterLogging = WorkflowExpression.Compile(bodychangePasswordAfterLogging, nameof(bodychangePasswordAfterLogging), required: true);
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: false);
            var __workflow_bodypassword = WorkflowExpression.Compile(bodypassword, nameof(bodypassword), required: false);
            var __workflow_bodyroleEndUser = WorkflowExpression.Compile(bodyroleEndUser, nameof(bodyroleEndUser), required: false);
            var __workflow_bodyroleSmartUser = WorkflowExpression.Compile(bodyroleSmartUser, nameof(bodyroleSmartUser), required: false);
            var __workflow_bodyroleOperator = WorkflowExpression.Compile(bodyroleOperator, nameof(bodyroleOperator), required: false);
            var __workflow_bodyroleSuperOperator = WorkflowExpression.Compile(bodyroleSuperOperator, nameof(bodyroleSuperOperator), required: false);
            var __workflow_bodyroleAdministrator = WorkflowExpression.Compile(bodyroleAdministrator, nameof(bodyroleAdministrator), required: false);
            var __workflow_bodyfirstName = WorkflowExpression.Compile(bodyfirstName, nameof(bodyfirstName), required: false);
            var __workflow_bodylastName = WorkflowExpression.Compile(bodylastName, nameof(bodylastName), required: false);
            var __workflow_bodymiddleName = WorkflowExpression.Compile(bodymiddleName, nameof(bodymiddleName), required: false);
            var __workflow_bodydisplayName = WorkflowExpression.Compile(bodydisplayName, nameof(bodydisplayName), required: false);
            var __workflow_bodyphone = WorkflowExpression.Compile(bodyphone, nameof(bodyphone), required: false);
            var __workflow_bodyadminNote = WorkflowExpression.Compile(bodyadminNote, nameof(bodyadminNote), required: false);
            var __workflow_bodyadditionalInformation = WorkflowExpression.Compile(bodyadditionalInformation, nameof(bodyadditionalInformation), required: false);
            var __workflow_bodycustomerNames = WorkflowExpression.Compile(bodycustomerNames, nameof(bodycustomerNames), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/Account/CreateRequestorUser";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["UserName"] = ExpressionConverter.ConvertO(__workflow_bodyuserName);
                if (__workflow_bodyemail != null)
                {
                    body["Email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                    bodypropCount++;
                }

                if (__workflow_bodypassword != null)
                {
                    body["Password"] = ExpressionConverter.ConvertO(__workflow_bodypassword);
                    bodypropCount++;
                }

                if (__workflow_bodyroleEndUser != null)
                {
                    body["RoleEndUser"] = ExpressionConverter.ConvertO(__workflow_bodyroleEndUser);
                    bodypropCount++;
                }

                if (__workflow_bodyroleSmartUser != null)
                {
                    body["RoleSmartUser"] = ExpressionConverter.ConvertO(__workflow_bodyroleSmartUser);
                    bodypropCount++;
                }

                if (__workflow_bodyroleOperator != null)
                {
                    body["RoleOperator"] = ExpressionConverter.ConvertO(__workflow_bodyroleOperator);
                    bodypropCount++;
                }

                if (__workflow_bodyroleSuperOperator != null)
                {
                    body["RoleSuperOperator"] = ExpressionConverter.ConvertO(__workflow_bodyroleSuperOperator);
                    bodypropCount++;
                }

                if (__workflow_bodyroleAdministrator != null)
                {
                    body["RoleAdministrator"] = ExpressionConverter.ConvertO(__workflow_bodyroleAdministrator);
                    bodypropCount++;
                }

                if (__workflow_bodyfirstName != null)
                {
                    body["FirstName"] = ExpressionConverter.ConvertO(__workflow_bodyfirstName);
                    bodypropCount++;
                }

                if (__workflow_bodylastName != null)
                {
                    body["LastName"] = ExpressionConverter.ConvertO(__workflow_bodylastName);
                    bodypropCount++;
                }

                if (__workflow_bodymiddleName != null)
                {
                    body["MiddleName"] = ExpressionConverter.ConvertO(__workflow_bodymiddleName);
                    bodypropCount++;
                }

                if (__workflow_bodydisplayName != null)
                {
                    body["DisplayName"] = ExpressionConverter.ConvertO(__workflow_bodydisplayName);
                    bodypropCount++;
                }

                if (__workflow_bodyphone != null)
                {
                    body["Phone"] = ExpressionConverter.ConvertO(__workflow_bodyphone);
                    bodypropCount++;
                }

                bodypropCount++;
                body["ChangePasswordAfterLogging"] = ExpressionConverter.ConvertO(__workflow_bodychangePasswordAfterLogging);
                if (__workflow_bodyadminNote != null)
                {
                    body["AdminNote"] = ExpressionConverter.ConvertO(__workflow_bodyadminNote);
                    bodypropCount++;
                }

                if (__workflow_bodyadditionalInformation != null)
                {
                    body["AdditionalInformation"] = ExpressionConverter.ConvertO(__workflow_bodyadditionalInformation);
                    bodypropCount++;
                }

                if (__workflow_bodycustomerNames != null)
                {
                    body["CustomerNames"] = ExpressionConverter.ConvertO(__workflow_bodycustomerNames);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class RequestorTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger TicketCreated(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/api/PowerAutomate/CreateTicketCreatedTrigger";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["CallbackUrl"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
        }

        public IWorkflowTrigger UserCreated(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/api/PowerAutomate/CreateUserCreatedTrigger";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["CallbackUrl"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
        }

        public IWorkflowTrigger TicketMonitoring(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/api/PowerAutomate/CreateTicketMonitoringTrigger";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["CallbackUrl"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
        }

        public IWorkflowTrigger TicketStateChange(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/api/PowerAutomate/CreateTicketStateChangeTrigger";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["CallbackUrl"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
        }

        public IWorkflowTrigger TicketCategoryChange(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/api/PowerAutomate/CreateTicketCategoryChangeTrigger";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["CallbackUrl"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
        }

        public IWorkflowTrigger TicketCustomFormChange(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/api/PowerAutomate/CreateTicketCustomFormChangeTrigger";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["CallbackUrl"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
        }

        public IWorkflowTrigger UserUpdated(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/api/PowerAutomate/CreateUserUpdatedTrigger";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["CallbackUrl"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
        }

        public IWorkflowTrigger UserDeleted(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/api/PowerAutomate/CreateUserDeletedTrigger";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["CallbackUrl"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
        }

        public IWorkflowTrigger CompanyCreated(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/api/PowerAutomate/CreateCompanyCreatedTrigger";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["CallbackUrl"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
        }

        public IWorkflowTrigger CompanyUpdated(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/api/PowerAutomate/CreateCompanyUpdatedTrigger";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["CallbackUrl"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
        }

        public IWorkflowTrigger CompanyDeleted(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/api/PowerAutomate/CreateCompanyDeletedTrigger";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["CallbackUrl"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
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
