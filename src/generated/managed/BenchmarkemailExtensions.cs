//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Benchmarkemail
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BenchmarkemailActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "benchmarkemail")]
        public IBodyWorkflowAction<string> CreateContactList(Expression<Func<string>> listName)
        {
            var apiCallPath = "/listCreate/";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["listName"] = ExpressionConverter.Convert(listName);
            callPayload.Queries["output"] = Convert.ToString("json");
            callPayload.Queries["method"] = Convert.ToString("listCreate");
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "benchmarkemail")]
        public IBodyWorkflowAction<int> CreateContact(Expression<Func<string>> listID, Expression<Func<string>> email, Expression<Func<string>> firstName = null, Expression<Func<string>> middleName = null, Expression<Func<string>> lastName = null, Expression<Func<string>> jobTitle = null, Expression<Func<string>> phone = null, Expression<Func<string>> notes = null)
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
        }
    }

    public class BenchmarkemailTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Benchmarkemail;

    public partial class WorkflowManagedActions
    {
        public BenchmarkemailActions Benchmarkemail(string connectionId) => new BenchmarkemailActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public BenchmarkemailTriggers Benchmarkemail(string connectionId) => new BenchmarkemailTriggers(connectionId);
    }
}