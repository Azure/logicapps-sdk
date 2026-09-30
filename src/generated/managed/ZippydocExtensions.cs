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
        public IWorkflowAction Execute([WorkflowExpression] Func<string> name)
        {
            SourceExpression.Validate(name, nameof(name), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/document/power-automate/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(name, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zippydoc")]
        public IBodyWorkflowAction<int> UploadTable([WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<JToken[]> bodycontent = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodydocumentName = null, [WorkflowExpression] Func<bool> bodyreplace = null, [WorkflowExpression] Func<JToken[]> bodytags = null)
        {
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodycontent, nameof(bodycontent), required: false);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            SourceExpression.Validate(bodydocumentName, nameof(bodydocumentName), required: false);
            SourceExpression.Validate(bodyreplace, nameof(bodyreplace), required: false);
            SourceExpression.Validate(bodytags, nameof(bodytags), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/excel/table/power-automate/upload";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodycontent != null)
                {
                    body["content"] = SourceExpressionConverter.ConvertToken(bodycontent);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodydocumentName != null)
                {
                    body["documentName"] = SourceExpressionConverter.ConvertToken(bodydocumentName);
                    bodypropCount++;
                }

                if (bodyreplace != null)
                {
                    body["replace"] = SourceExpressionConverter.ConvertToken(bodyreplace);
                    bodypropCount++;
                }

                if (bodytags != null)
                {
                    body["tags"] = SourceExpressionConverter.ConvertToken(bodytags);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<int>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zippydoc")]
        public IBodyWorkflowAction<JToken[]> GetTableById([WorkflowExpression] Func<int> tableId)
        {
            SourceExpression.Validate(tableId, nameof(tableId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/excel/table/power-automate/id/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(tableId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zippydoc")]
        public IBodyWorkflowAction<JToken[]> GetTableByName([WorkflowExpression] Func<string> name)
        {
            SourceExpression.Validate(name, nameof(name), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/excel/table/power-automate/name/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(name, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken[]>(BuildSourceInput);
        }
    }

    public class ZippydocTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger OnTableChange([WorkflowExpression] Func<bodytypeInput> bodytype = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodytype, nameof(bodytype), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/power-automate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["x-ms-notification-url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodytype != null)
                {
                    body["type"] = SourceExpressionConverter.Convert(bodytype);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
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