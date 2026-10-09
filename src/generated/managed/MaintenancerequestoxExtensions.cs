//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Maintenancerequestox
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MaintenancerequestoxActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "maintenancerequestox")]
        [WorkflowExpressionFactory(nameof(__BuildMaintenanceRequestOxmaint))]
        public IWorkflowAction MaintenanceRequestOxmaint([WorkflowExpression] Func<string> bodytitle, [WorkflowExpression] Func<string> bodydescription, [WorkflowExpression] Func<string> bodypriority, [WorkflowExpression] Func<string> bodyrequestedBy, [WorkflowExpression] Func<string> bodydate, [WorkflowExpression] Func<string> bodymasterEmail, [WorkflowExpression] Func<string> bodyapiKey)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMaintenanceRequestOxmaint(WorkflowExpression<string> bodytitle, WorkflowExpression<string> bodydescription, WorkflowExpression<string> bodypriority, WorkflowExpression<string> bodyrequestedBy, WorkflowExpression<string> bodydate, WorkflowExpression<string> bodymasterEmail, WorkflowExpression<string> bodyapiKey)
        {
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            WorkflowExpression.Validate(bodydescription, nameof(bodydescription), required: true);
            WorkflowExpression.Validate(bodypriority, nameof(bodypriority), required: true);
            WorkflowExpression.Validate(bodyrequestedBy, nameof(bodyrequestedBy), required: true);
            WorkflowExpression.Validate(bodydate, nameof(bodydate), required: true);
            WorkflowExpression.Validate(bodymasterEmail, nameof(bodymasterEmail), required: true);
            WorkflowExpression.Validate(bodyapiKey, nameof(bodyapiKey), required: true);
            return new DeferredWorkflowAction(() =>
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
                body["title"] = ExpressionConverter.ConvertO(bodytitle);
                bodypropCount++;
                body["description"] = ExpressionConverter.ConvertO(bodydescription);
                bodypropCount++;
                body["priority"] = ExpressionConverter.ConvertO(bodypriority);
                bodypropCount++;
                body["requested_by"] = ExpressionConverter.ConvertO(bodyrequestedBy);
                bodypropCount++;
                body["date"] = ExpressionConverter.ConvertO(bodydate);
                bodypropCount++;
                body["master_email"] = ExpressionConverter.ConvertO(bodymasterEmail);
                bodypropCount++;
                body["api_key"] = ExpressionConverter.ConvertO(bodyapiKey);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
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