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
        public IWorkflowAction MaintenanceRequestOxmaint(Expression<Func<string>> bodytitle, Expression<Func<string>> bodydescription, Expression<Func<string>> bodypriority, Expression<Func<string>> bodyrequestedBy, Expression<Func<string>> bodydate, Expression<Func<string>> bodymasterEmail, Expression<Func<string>> bodyapiKey)
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
            body["title"] = CSharpExpressionConverter.ConvertToken(bodytitle);
            bodypropCount++;
            body["description"] = CSharpExpressionConverter.ConvertToken(bodydescription);
            bodypropCount++;
            body["priority"] = CSharpExpressionConverter.ConvertToken(bodypriority);
            bodypropCount++;
            body["requested_by"] = CSharpExpressionConverter.ConvertToken(bodyrequestedBy);
            bodypropCount++;
            body["date"] = CSharpExpressionConverter.ConvertToken(bodydate);
            bodypropCount++;
            body["master_email"] = CSharpExpressionConverter.ConvertToken(bodymasterEmail);
            bodypropCount++;
            body["api_key"] = CSharpExpressionConverter.ConvertToken(bodyapiKey);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
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