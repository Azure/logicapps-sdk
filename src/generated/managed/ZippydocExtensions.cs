//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Zippydoc
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ZippydocActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zippydoc")]
        public IWorkflowAction Execute(Expression<Func<string>> name)
        {
            var apiCallPath = String.Format("/document/power-automate/{0}", ExpressionConverter.ConvertWithUrlEncoding(name, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zippydoc")]
        public IBodyWorkflowAction<int> UploadTable(Expression<Func<string>> bodyname = null, Expression<Func<JToken[]>> bodycontent = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodydocumentName = null, Expression<Func<bool>> bodyreplace = null, Expression<Func<JToken[]>> bodytags = null)
        {
            var apiCallPath = "/excel/table/power-automate/upload";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodycontent != null)
            {
                body["content"] = ExpressionConverter.ConvertO(bodycontent);
                bodypropCount++;
            }

            if (bodydescription != null)
            {
                body["description"] = ExpressionConverter.ConvertO(bodydescription);
                bodypropCount++;
            }

            if (bodydocumentName != null)
            {
                body["documentName"] = ExpressionConverter.ConvertO(bodydocumentName);
                bodypropCount++;
            }

            if (bodyreplace != null)
            {
                body["replace"] = ExpressionConverter.ConvertO(bodyreplace);
                bodypropCount++;
            }

            if (bodytags != null)
            {
                body["tags"] = ExpressionConverter.ConvertO(bodytags);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<int>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zippydoc")]
        public IBodyWorkflowAction<JToken[]> GetTableByID(Expression<Func<int>> tableId)
        {
            var apiCallPath = String.Format("/excel/table/power-automate/id/{0}", ExpressionConverter.ConvertWithUrlEncoding(tableId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zippydoc")]
        public IBodyWorkflowAction<JToken[]> GetTableByName(Expression<Func<string>> name)
        {
            var apiCallPath = String.Format("/excel/table/power-automate/name/{0}", ExpressionConverter.ConvertWithUrlEncoding(name, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken[]>(callPayload);
        }
    }

    public class ZippydocTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger OnTableChange(Expression<Func<bodytypeInput>> bodytype = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/power-automate";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["x-ms-notification-url"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodytype != null)
            {
                body["type"] = ExpressionConverter.ConvertO(bodytype);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }
    }

    public enum bodytypeInput
    {
        [EnumMember(Value = "ON_TABLE_CHANGE")]
        ONTABLECHANGE
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Zippydoc;

    public partial class WorkflowManagedActions
    {
        public ZippydocActions Zippydoc(string connectionId) => new ZippydocActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ZippydocTriggers Zippydoc(string connectionId) => new ZippydocTriggers(connectionId);
    }
}