//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Benchmarkemail
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BenchmarkemailActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "benchmarkemail")]
        public IBodyWorkflowAction<string> CreateContactList([WorkflowExpression] Func<string> listName)
        {
            SourceExpression.Validate(listName, nameof(listName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/listCreate/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["listName"] = SourceExpressionConverter.ConvertO(listName);
                callPayload.Queries["output"] = Convert.ToString("json");
                callPayload.Queries["method"] = Convert.ToString("listCreate");
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "benchmarkemail")]
        public IBodyWorkflowAction<int> CreateContact([WorkflowExpression] Func<string> listID, [WorkflowExpression] Func<string> email, [WorkflowExpression] Func<string> firstName = null, [WorkflowExpression] Func<string> middleName = null, [WorkflowExpression] Func<string> lastName = null, [WorkflowExpression] Func<string> jobTitle = null, [WorkflowExpression] Func<string> phone = null, [WorkflowExpression] Func<string> notes = null)
        {
            SourceExpression.Validate(listID, nameof(listID), required: true);
            SourceExpression.Validate(email, nameof(email), required: true);
            SourceExpression.Validate(firstName, nameof(firstName), required: false);
            SourceExpression.Validate(middleName, nameof(middleName), required: false);
            SourceExpression.Validate(lastName, nameof(lastName), required: false);
            SourceExpression.Validate(jobTitle, nameof(jobTitle), required: false);
            SourceExpression.Validate(phone, nameof(phone), required: false);
            SourceExpression.Validate(notes, nameof(notes), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/listAddContacts/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["output"] = Convert.ToString("json");
                callPayload.Queries["method"] = Convert.ToString("listAddContacts");
                callPayload.Queries["listID"] = SourceExpressionConverter.ConvertO(listID);
                callPayload.Queries["Email"] = SourceExpressionConverter.ConvertO(email);
                if (firstName != null)
                    callPayload.Queries["FirstName"] = SourceExpressionConverter.ConvertO(firstName);
                if (middleName != null)
                    callPayload.Queries["MiddleName"] = SourceExpressionConverter.ConvertO(middleName);
                if (lastName != null)
                    callPayload.Queries["LastName"] = SourceExpressionConverter.ConvertO(lastName);
                if (jobTitle != null)
                    callPayload.Queries["JobTitle"] = SourceExpressionConverter.ConvertO(jobTitle);
                if (phone != null)
                    callPayload.Queries["Phone"] = SourceExpressionConverter.ConvertO(phone);
                if (notes != null)
                    callPayload.Queries["Notes"] = SourceExpressionConverter.ConvertO(notes);
                return callPayload;
            }

            return new ApiConnectionAction<int>(BuildSourceInput);
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