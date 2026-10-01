//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Maintenancerequestox
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MaintenancerequestoxActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "maintenancerequestox")]
        public IWorkflowAction MaintenanceRequestOxmaint([WorkflowExpression] Func<string> bodytitle, [WorkflowExpression] Func<string> bodydescription, [WorkflowExpression] Func<string> bodypriority, [WorkflowExpression] Func<string> bodyrequestedBy, [WorkflowExpression] Func<string> bodydate, [WorkflowExpression] Func<string> bodymasterEmail, [WorkflowExpression] Func<string> bodyapiKey)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/workflows/81fb7bc062f3419a8c0ba8ac0132d631/triggers/manual/paths/invoke";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2016-06-01");
                callPayload.Queries["sp"] = Convert.ToString("/triggers/manual/run");
                callPayload.Queries["sv"] = Convert.ToString("1.0");
                callPayload.Queries["sig"] = Convert.ToString("7zabIRU45x3Syx725dxQyiiSUSNX3iIF0Jr-2wKcxY0");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                bodypropCount++;
                body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                bodypropCount++;
                body["priority"] = SourceExpressionConverter.ConvertToken(bodypriority);
                bodypropCount++;
                body["requested_by"] = SourceExpressionConverter.ConvertToken(bodyrequestedBy);
                bodypropCount++;
                body["date"] = SourceExpressionConverter.ConvertToken(bodydate);
                bodypropCount++;
                body["master_email"] = SourceExpressionConverter.ConvertToken(bodymasterEmail);
                bodypropCount++;
                body["api_key"] = SourceExpressionConverter.ConvertToken(bodyapiKey);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }
    }

    public class MaintenancerequestoxTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Maintenancerequestox;

    public partial class WorkflowManagedActions
    {
        public MaintenancerequestoxActions Maintenancerequestox(string connectionId) => new MaintenancerequestoxActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MaintenancerequestoxTriggers Maintenancerequestox(string connectionId) => new MaintenancerequestoxTriggers(connectionId);
    }
}