//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Requestor
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RequestorActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "requestor")]
        [WorkflowExpressionFactory(nameof(__BuildCreateTicket))]
        public IWorkflowAction CreateTicket([WorkflowExpression] Func<int> bodytype, [WorkflowExpression] Func<int> bodyserviceId, [WorkflowExpression] Func<string> bodysubject, [WorkflowExpression] Func<string> bodymessage, [WorkflowExpression] Func<string> bodysubmitterEmail, [WorkflowExpression] Func<string> bodysolverUserProviderKey = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "requestor")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCreateTicket(WorkflowExpression<int> bodytype, WorkflowExpression<int> bodyserviceId, WorkflowExpression<string> bodysubject, WorkflowExpression<string> bodymessage, WorkflowExpression<string> bodysubmitterEmail, WorkflowExpression<string> bodysolverUserProviderKey = null)
        {
            WorkflowExpression.Validate(bodytype, nameof(bodytype), required: true);
            WorkflowExpression.Validate(bodyserviceId, nameof(bodyserviceId), required: true);
            WorkflowExpression.Validate(bodysubject, nameof(bodysubject), required: true);
            WorkflowExpression.Validate(bodymessage, nameof(bodymessage), required: true);
            WorkflowExpression.Validate(bodysubmitterEmail, nameof(bodysubmitterEmail), required: true);
            WorkflowExpression.Validate(bodysolverUserProviderKey, nameof(bodysolverUserProviderKey), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "requestor")]
        [WorkflowExpressionFactory(nameof(__BuildCreateUser))]
        public IWorkflowAction CreateUser([WorkflowExpression] Func<string> bodyuserName, [WorkflowExpression] Func<bool> bodychangePasswordAfterLogging, [WorkflowExpression] Func<string> bodyemail = null, [WorkflowExpression] Func<string> bodypassword = null, [WorkflowExpression] Func<bool> bodyroleEndUser = null, [WorkflowExpression] Func<bool> bodyroleSmartUser = null, [WorkflowExpression] Func<bool> bodyroleOperator = null, [WorkflowExpression] Func<bool> bodyroleSuperOperator = null, [WorkflowExpression] Func<bool> bodyroleAdministrator = null, [WorkflowExpression] Func<string> bodyfirstName = null, [WorkflowExpression] Func<string> bodylastName = null, [WorkflowExpression] Func<string> bodymiddleName = null, [WorkflowExpression] Func<string> bodydisplayName = null, [WorkflowExpression] Func<string> bodyphone = null, [WorkflowExpression] Func<string> bodyadminNote = null, [WorkflowExpression] Func<string> bodyadditionalInformation = null, [WorkflowExpression] Func<string[]> bodycustomerNames = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "requestor")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCreateUser(WorkflowExpression<string> bodyuserName, WorkflowExpression<bool> bodychangePasswordAfterLogging, WorkflowExpression<string> bodyemail = null, WorkflowExpression<string> bodypassword = null, WorkflowExpression<bool> bodyroleEndUser = null, WorkflowExpression<bool> bodyroleSmartUser = null, WorkflowExpression<bool> bodyroleOperator = null, WorkflowExpression<bool> bodyroleSuperOperator = null, WorkflowExpression<bool> bodyroleAdministrator = null, WorkflowExpression<string> bodyfirstName = null, WorkflowExpression<string> bodylastName = null, WorkflowExpression<string> bodymiddleName = null, WorkflowExpression<string> bodydisplayName = null, WorkflowExpression<string> bodyphone = null, WorkflowExpression<string> bodyadminNote = null, WorkflowExpression<string> bodyadditionalInformation = null, WorkflowExpression<string[]> bodycustomerNames = null)
        {
            WorkflowExpression.Validate(bodyuserName, nameof(bodyuserName), required: true);
            WorkflowExpression.Validate(bodychangePasswordAfterLogging, nameof(bodychangePasswordAfterLogging), required: true);
            WorkflowExpression.Validate(bodyemail, nameof(bodyemail), required: false);
            WorkflowExpression.Validate(bodypassword, nameof(bodypassword), required: false);
            WorkflowExpression.Validate(bodyroleEndUser, nameof(bodyroleEndUser), required: false);
            WorkflowExpression.Validate(bodyroleSmartUser, nameof(bodyroleSmartUser), required: false);
            WorkflowExpression.Validate(bodyroleOperator, nameof(bodyroleOperator), required: false);
            WorkflowExpression.Validate(bodyroleSuperOperator, nameof(bodyroleSuperOperator), required: false);
            WorkflowExpression.Validate(bodyroleAdministrator, nameof(bodyroleAdministrator), required: false);
            WorkflowExpression.Validate(bodyfirstName, nameof(bodyfirstName), required: false);
            WorkflowExpression.Validate(bodylastName, nameof(bodylastName), required: false);
            WorkflowExpression.Validate(bodymiddleName, nameof(bodymiddleName), required: false);
            WorkflowExpression.Validate(bodydisplayName, nameof(bodydisplayName), required: false);
            WorkflowExpression.Validate(bodyphone, nameof(bodyphone), required: false);
            WorkflowExpression.Validate(bodyadminNote, nameof(bodyadminNote), required: false);
            WorkflowExpression.Validate(bodyadditionalInformation, nameof(bodyadditionalInformation), required: false);
            WorkflowExpression.Validate(bodycustomerNames, nameof(bodycustomerNames), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
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
            body["CallbackUrl"] = "#{listCallbackUrl()}";
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
            body["CallbackUrl"] = "#{listCallbackUrl()}";
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
            body["CallbackUrl"] = "#{listCallbackUrl()}";
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
            body["CallbackUrl"] = "#{listCallbackUrl()}";
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
            body["CallbackUrl"] = "#{listCallbackUrl()}";
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
            body["CallbackUrl"] = "#{listCallbackUrl()}";
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
            body["CallbackUrl"] = "#{listCallbackUrl()}";
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
            body["CallbackUrl"] = "#{listCallbackUrl()}";
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
            body["CallbackUrl"] = "#{listCallbackUrl()}";
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
            body["CallbackUrl"] = "#{listCallbackUrl()}";
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
            body["CallbackUrl"] = "#{listCallbackUrl()}";
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