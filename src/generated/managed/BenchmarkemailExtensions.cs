//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Benchmarkemail
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BenchmarkemailActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "benchmarkemail")]
        public IBodyWorkflowAction<string> CreateContactList(Expression<Func<string>> listName)
        {
            var __workflow_listName = WorkflowExpression.Compile(listName, nameof(listName), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/listCreate/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["listName"] = ExpressionConverter.Convert(__workflow_listName);
                callPayload.Queries["output"] = Convert.ToString("json");
                callPayload.Queries["method"] = Convert.ToString("listCreate");
                return new ApiConnectionAction<string>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "benchmarkemail")]
        public IBodyWorkflowAction<int> CreateContact(Expression<Func<string>> listID, Expression<Func<string>> email, Expression<Func<string>> firstName = null, Expression<Func<string>> middleName = null, Expression<Func<string>> lastName = null, Expression<Func<string>> jobTitle = null, Expression<Func<string>> phone = null, Expression<Func<string>> notes = null)
        {
            var __workflow_listID = WorkflowExpression.Compile(listID, nameof(listID), required: true);
            var __workflow_email = WorkflowExpression.Compile(email, nameof(email), required: true);
            var __workflow_firstName = WorkflowExpression.Compile(firstName, nameof(firstName), required: false);
            var __workflow_middleName = WorkflowExpression.Compile(middleName, nameof(middleName), required: false);
            var __workflow_lastName = WorkflowExpression.Compile(lastName, nameof(lastName), required: false);
            var __workflow_jobTitle = WorkflowExpression.Compile(jobTitle, nameof(jobTitle), required: false);
            var __workflow_phone = WorkflowExpression.Compile(phone, nameof(phone), required: false);
            var __workflow_notes = WorkflowExpression.Compile(notes, nameof(notes), required: false);
            return new DeferredBodyAction<int>(() =>
            {
                var apiCallPath = "/listAddContacts/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["output"] = Convert.ToString("json");
                callPayload.Queries["method"] = Convert.ToString("listAddContacts");
                callPayload.Queries["listID"] = ExpressionConverter.Convert(__workflow_listID);
                callPayload.Queries["Email"] = ExpressionConverter.Convert(__workflow_email);
                if (__workflow_firstName != null)
                    callPayload.Queries["FirstName"] = ExpressionConverter.Convert(__workflow_firstName);
                if (__workflow_middleName != null)
                    callPayload.Queries["MiddleName"] = ExpressionConverter.Convert(__workflow_middleName);
                if (__workflow_lastName != null)
                    callPayload.Queries["LastName"] = ExpressionConverter.Convert(__workflow_lastName);
                if (__workflow_jobTitle != null)
                    callPayload.Queries["JobTitle"] = ExpressionConverter.Convert(__workflow_jobTitle);
                if (__workflow_phone != null)
                    callPayload.Queries["Phone"] = ExpressionConverter.Convert(__workflow_phone);
                if (__workflow_notes != null)
                    callPayload.Queries["Notes"] = ExpressionConverter.Convert(__workflow_notes);
                return new ApiConnectionAction<int>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }
    }

    public class BenchmarkemailTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Benchmarkemail;

    public partial class WorkflowManagedActions
    {
        public BenchmarkemailActions Benchmarkemail(string connectionId) => new BenchmarkemailActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public BenchmarkemailTriggers Benchmarkemail(string connectionId) => new BenchmarkemailTriggers(connectionId);
    }
}
