//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Requestor
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class RequestorActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "requestor")]
        public IWorkflowAction CreateTicket(Expression<Func<int>> bodytype, Expression<Func<int>> bodyserviceId, Expression<Func<string>> bodysubject, Expression<Func<string>> bodymessage, Expression<Func<string>> bodysubmitterEmail, Expression<Func<string>> bodysolverUserProviderKey = null)
        {
            var __workflow_bodytype = bodytype == null ? null : WorkflowExpression.Compile(bodytype);
            WorkflowExpression.Validate(__workflow_bodytype, nameof(bodytype), required: true);
            var __workflow_bodyserviceId = bodyserviceId == null ? null : WorkflowExpression.Compile(bodyserviceId);
            WorkflowExpression.Validate(__workflow_bodyserviceId, nameof(bodyserviceId), required: true);
            var __workflow_bodysubject = bodysubject == null ? null : WorkflowExpression.Compile(bodysubject);
            WorkflowExpression.Validate(__workflow_bodysubject, nameof(bodysubject), required: true);
            var __workflow_bodymessage = bodymessage == null ? null : WorkflowExpression.Compile(bodymessage);
            WorkflowExpression.Validate(__workflow_bodymessage, nameof(bodymessage), required: true);
            var __workflow_bodysubmitterEmail = bodysubmitterEmail == null ? null : WorkflowExpression.Compile(bodysubmitterEmail);
            WorkflowExpression.Validate(__workflow_bodysubmitterEmail, nameof(bodysubmitterEmail), required: true);
            var __workflow_bodysolverUserProviderKey = bodysolverUserProviderKey == null ? null : WorkflowExpression.Compile(bodysolverUserProviderKey);
            WorkflowExpression.Validate(__workflow_bodysolverUserProviderKey, nameof(bodysolverUserProviderKey), required: false);
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
            var __workflow_bodyuserName = bodyuserName == null ? null : WorkflowExpression.Compile(bodyuserName);
            WorkflowExpression.Validate(__workflow_bodyuserName, nameof(bodyuserName), required: true);
            var __workflow_bodychangePasswordAfterLogging = bodychangePasswordAfterLogging == null ? null : WorkflowExpression.Compile(bodychangePasswordAfterLogging);
            WorkflowExpression.Validate(__workflow_bodychangePasswordAfterLogging, nameof(bodychangePasswordAfterLogging), required: true);
            var __workflow_bodyemail = bodyemail == null ? null : WorkflowExpression.Compile(bodyemail);
            WorkflowExpression.Validate(__workflow_bodyemail, nameof(bodyemail), required: false);
            var __workflow_bodypassword = bodypassword == null ? null : WorkflowExpression.Compile(bodypassword);
            WorkflowExpression.Validate(__workflow_bodypassword, nameof(bodypassword), required: false);
            var __workflow_bodyroleEndUser = bodyroleEndUser == null ? null : WorkflowExpression.Compile(bodyroleEndUser);
            WorkflowExpression.Validate(__workflow_bodyroleEndUser, nameof(bodyroleEndUser), required: false);
            var __workflow_bodyroleSmartUser = bodyroleSmartUser == null ? null : WorkflowExpression.Compile(bodyroleSmartUser);
            WorkflowExpression.Validate(__workflow_bodyroleSmartUser, nameof(bodyroleSmartUser), required: false);
            var __workflow_bodyroleOperator = bodyroleOperator == null ? null : WorkflowExpression.Compile(bodyroleOperator);
            WorkflowExpression.Validate(__workflow_bodyroleOperator, nameof(bodyroleOperator), required: false);
            var __workflow_bodyroleSuperOperator = bodyroleSuperOperator == null ? null : WorkflowExpression.Compile(bodyroleSuperOperator);
            WorkflowExpression.Validate(__workflow_bodyroleSuperOperator, nameof(bodyroleSuperOperator), required: false);
            var __workflow_bodyroleAdministrator = bodyroleAdministrator == null ? null : WorkflowExpression.Compile(bodyroleAdministrator);
            WorkflowExpression.Validate(__workflow_bodyroleAdministrator, nameof(bodyroleAdministrator), required: false);
            var __workflow_bodyfirstName = bodyfirstName == null ? null : WorkflowExpression.Compile(bodyfirstName);
            WorkflowExpression.Validate(__workflow_bodyfirstName, nameof(bodyfirstName), required: false);
            var __workflow_bodylastName = bodylastName == null ? null : WorkflowExpression.Compile(bodylastName);
            WorkflowExpression.Validate(__workflow_bodylastName, nameof(bodylastName), required: false);
            var __workflow_bodymiddleName = bodymiddleName == null ? null : WorkflowExpression.Compile(bodymiddleName);
            WorkflowExpression.Validate(__workflow_bodymiddleName, nameof(bodymiddleName), required: false);
            var __workflow_bodydisplayName = bodydisplayName == null ? null : WorkflowExpression.Compile(bodydisplayName);
            WorkflowExpression.Validate(__workflow_bodydisplayName, nameof(bodydisplayName), required: false);
            var __workflow_bodyphone = bodyphone == null ? null : WorkflowExpression.Compile(bodyphone);
            WorkflowExpression.Validate(__workflow_bodyphone, nameof(bodyphone), required: false);
            var __workflow_bodyadminNote = bodyadminNote == null ? null : WorkflowExpression.Compile(bodyadminNote);
            WorkflowExpression.Validate(__workflow_bodyadminNote, nameof(bodyadminNote), required: false);
            var __workflow_bodyadditionalInformation = bodyadditionalInformation == null ? null : WorkflowExpression.Compile(bodyadditionalInformation);
            WorkflowExpression.Validate(__workflow_bodyadditionalInformation, nameof(bodyadditionalInformation), required: false);
            var __workflow_bodycustomerNames = bodycustomerNames == null ? null : WorkflowExpression.Compile(bodycustomerNames);
            WorkflowExpression.Validate(__workflow_bodycustomerNames, nameof(bodycustomerNames), required: false);
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
