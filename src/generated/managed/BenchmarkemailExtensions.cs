//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Benchmarkemail
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BenchmarkemailActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "benchmarkemail")]
        [WorkflowExpressionFactory(nameof(__BuildCreateContactList))]
        public IBodyWorkflowAction<string> CreateContactList([WorkflowExpression] Func<string> listName)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "benchmarkemail")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildCreateContactList(WorkflowExpression<string> listName)
        {
            WorkflowExpression.Validate(listName, nameof(listName), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/listCreate/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["listName"] = ExpressionConverter.Convert(listName);
                callPayload.Queries["output"] = Convert.ToString("json");
                callPayload.Queries["method"] = Convert.ToString("listCreate");
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "benchmarkemail")]
        [WorkflowExpressionFactory(nameof(__BuildCreateContact))]
        public IBodyWorkflowAction<int> CreateContact([WorkflowExpression] Func<string> listID, [WorkflowExpression] Func<string> email, [WorkflowExpression] Func<string> firstName = null, [WorkflowExpression] Func<string> middleName = null, [WorkflowExpression] Func<string> lastName = null, [WorkflowExpression] Func<string> jobTitle = null, [WorkflowExpression] Func<string> phone = null, [WorkflowExpression] Func<string> notes = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "benchmarkemail")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<int> __BuildCreateContact(WorkflowExpression<string> listID, WorkflowExpression<string> email, WorkflowExpression<string> firstName = null, WorkflowExpression<string> middleName = null, WorkflowExpression<string> lastName = null, WorkflowExpression<string> jobTitle = null, WorkflowExpression<string> phone = null, WorkflowExpression<string> notes = null)
        {
            WorkflowExpression.Validate(listID, nameof(listID), required: true);
            WorkflowExpression.Validate(email, nameof(email), required: true);
            WorkflowExpression.Validate(firstName, nameof(firstName), required: false);
            WorkflowExpression.Validate(middleName, nameof(middleName), required: false);
            WorkflowExpression.Validate(lastName, nameof(lastName), required: false);
            WorkflowExpression.Validate(jobTitle, nameof(jobTitle), required: false);
            WorkflowExpression.Validate(phone, nameof(phone), required: false);
            WorkflowExpression.Validate(notes, nameof(notes), required: false);
            return new DeferredBodyAction<int>(() =>
            {
                var apiCallPath = "/listAddContacts/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["output"] = Convert.ToString("json");
                callPayload.Queries["method"] = Convert.ToString("listAddContacts");
                callPayload.Queries["listID"] = ExpressionConverter.Convert(listID);
                callPayload.Queries["Email"] = ExpressionConverter.Convert(email);
                if (firstName != null)
                    callPayload.Queries["FirstName"] = ExpressionConverter.Convert(firstName);
                if (middleName != null)
                    callPayload.Queries["MiddleName"] = ExpressionConverter.Convert(middleName);
                if (lastName != null)
                    callPayload.Queries["LastName"] = ExpressionConverter.Convert(lastName);
                if (jobTitle != null)
                    callPayload.Queries["JobTitle"] = ExpressionConverter.Convert(jobTitle);
                if (phone != null)
                    callPayload.Queries["Phone"] = ExpressionConverter.Convert(phone);
                if (notes != null)
                    callPayload.Queries["Notes"] = ExpressionConverter.Convert(notes);
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