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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildCreateContactList(WorkflowValue<string> listName)
        {
            WorkflowValue.Validate(listName, nameof(listName), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<int> __BuildCreateContact(WorkflowValue<string> listID, WorkflowValue<string> email, WorkflowValue<string> firstName = null, WorkflowValue<string> middleName = null, WorkflowValue<string> lastName = null, WorkflowValue<string> jobTitle = null, WorkflowValue<string> phone = null, WorkflowValue<string> notes = null)
        {
            WorkflowValue.Validate(listID, nameof(listID), required: true);
            WorkflowValue.Validate(email, nameof(email), required: true);
            WorkflowValue.Validate(firstName, nameof(firstName), required: false);
            WorkflowValue.Validate(middleName, nameof(middleName), required: false);
            WorkflowValue.Validate(lastName, nameof(lastName), required: false);
            WorkflowValue.Validate(jobTitle, nameof(jobTitle), required: false);
            WorkflowValue.Validate(phone, nameof(phone), required: false);
            WorkflowValue.Validate(notes, nameof(notes), required: false);
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
