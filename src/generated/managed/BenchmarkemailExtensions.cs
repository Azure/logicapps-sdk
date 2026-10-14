//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Benchmarkemail
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class BenchmarkemailActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "benchmarkemail")]
        public IBodyWorkflowAction<string> CreateContactList(Expression<Func<string>> listName)
        {
            var __workflow_listName = listName == null ? null : WorkflowExpression.Compile(listName);
            WorkflowExpression.Validate(__workflow_listName, nameof(listName), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/listCreate/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["listName"] = ExpressionConverter.Convert(__workflow_listName);
                callPayload.Queries["output"] = Convert.ToString("json");
                callPayload.Queries["method"] = Convert.ToString("listCreate");
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "benchmarkemail")]
        public IBodyWorkflowAction<int> CreateContact(Expression<Func<string>> listID, Expression<Func<string>> email, Expression<Func<string>> firstName = null, Expression<Func<string>> middleName = null, Expression<Func<string>> lastName = null, Expression<Func<string>> jobTitle = null, Expression<Func<string>> phone = null, Expression<Func<string>> notes = null)
        {
            var __workflow_listID = listID == null ? null : WorkflowExpression.Compile(listID);
            WorkflowExpression.Validate(__workflow_listID, nameof(listID), required: true);
            var __workflow_email = email == null ? null : WorkflowExpression.Compile(email);
            WorkflowExpression.Validate(__workflow_email, nameof(email), required: true);
            var __workflow_firstName = firstName == null ? null : WorkflowExpression.Compile(firstName);
            WorkflowExpression.Validate(__workflow_firstName, nameof(firstName), required: false);
            var __workflow_middleName = middleName == null ? null : WorkflowExpression.Compile(middleName);
            WorkflowExpression.Validate(__workflow_middleName, nameof(middleName), required: false);
            var __workflow_lastName = lastName == null ? null : WorkflowExpression.Compile(lastName);
            WorkflowExpression.Validate(__workflow_lastName, nameof(lastName), required: false);
            var __workflow_jobTitle = jobTitle == null ? null : WorkflowExpression.Compile(jobTitle);
            WorkflowExpression.Validate(__workflow_jobTitle, nameof(jobTitle), required: false);
            var __workflow_phone = phone == null ? null : WorkflowExpression.Compile(phone);
            WorkflowExpression.Validate(__workflow_phone, nameof(phone), required: false);
            var __workflow_notes = notes == null ? null : WorkflowExpression.Compile(notes);
            WorkflowExpression.Validate(__workflow_notes, nameof(notes), required: false);
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
            });
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
