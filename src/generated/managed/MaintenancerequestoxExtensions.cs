//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Maintenancerequestox
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MaintenancerequestoxActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "maintenancerequestox")]
        public IWorkflowAction MaintenanceRequestOxmaint(Expression<Func<string>> bodytitle, Expression<Func<string>> bodydescription, Expression<Func<string>> bodypriority, Expression<Func<string>> bodyrequestedBy, Expression<Func<string>> bodydate, Expression<Func<string>> bodymasterEmail, Expression<Func<string>> bodyapiKey)
        {
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: true);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: true);
            var __workflow_bodypriority = WorkflowExpression.Compile(bodypriority, nameof(bodypriority), required: true);
            var __workflow_bodyrequestedBy = WorkflowExpression.Compile(bodyrequestedBy, nameof(bodyrequestedBy), required: true);
            var __workflow_bodydate = WorkflowExpression.Compile(bodydate, nameof(bodydate), required: true);
            var __workflow_bodymasterEmail = WorkflowExpression.Compile(bodymasterEmail, nameof(bodymasterEmail), required: true);
            var __workflow_bodyapiKey = WorkflowExpression.Compile(bodyapiKey, nameof(bodyapiKey), required: true);
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
                body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                bodypropCount++;
                body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                bodypropCount++;
                body["priority"] = ExpressionConverter.ConvertO(__workflow_bodypriority);
                bodypropCount++;
                body["requested_by"] = ExpressionConverter.ConvertO(__workflow_bodyrequestedBy);
                bodypropCount++;
                body["date"] = ExpressionConverter.ConvertO(__workflow_bodydate);
                bodypropCount++;
                body["master_email"] = ExpressionConverter.ConvertO(__workflow_bodymasterEmail);
                bodypropCount++;
                body["api_key"] = ExpressionConverter.ConvertO(__workflow_bodyapiKey);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
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
