//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Assistantstudiov2
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Assistantstudiov2Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "assistantstudiov2")]
        public IWorkflowAction CreateActionCard([WorkflowExpression] Func<string> organization, [WorkflowExpression] Func<string> bodycardname, [WorkflowExpression] Func<string> bodytitle, [WorkflowExpression] Func<string> bodydescription, [WorkflowExpression] Func<object> bodydynamicproperties, [WorkflowExpression] Func<string> actiontype, [WorkflowExpression] Func<string> secondaryactiontype = null, [WorkflowExpression] Func<string> regardingobjecttype = null, [WorkflowExpression] Func<string> regardingobjectid = null, [WorkflowExpression] Func<string> ownerid = null, [WorkflowExpression] Func<string> startdate = null, [WorkflowExpression] Func<string> expirydate = null)
        {
            var apiCallPath = "/api/data/v9.0/msdyn_ActionCardCreate";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["organization"] = ExpressionConverter.Convert(organization);
            callPayload.Headers["actiontype"] = ExpressionConverter.Convert(actiontype);
            if (secondaryactiontype != null)
                callPayload.Headers["secondaryactiontype"] = ExpressionConverter.Convert(secondaryactiontype);
            if (regardingobjecttype != null)
                callPayload.Headers["regardingobjecttype"] = ExpressionConverter.Convert(regardingobjecttype);
            if (regardingobjectid != null)
                callPayload.Headers["regardingobjectid"] = ExpressionConverter.Convert(regardingobjectid);
            if (ownerid != null)
                callPayload.Headers["ownerid"] = ExpressionConverter.Convert(ownerid);
            if (startdate != null)
                callPayload.Headers["startdate"] = ExpressionConverter.Convert(startdate);
            if (expirydate != null)
                callPayload.Headers["expirydate"] = ExpressionConverter.Convert(expirydate);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["cardname"] = ExpressionConverter.ConvertO(bodycardname);
            bodypropCount++;
            body["title"] = ExpressionConverter.ConvertO(bodytitle);
            bodypropCount++;
            body["description"] = ExpressionConverter.ConvertO(bodydescription);
            bodypropCount++;
            body["dynamicproperties"] = ExpressionConverter.ConvertO(bodydynamicproperties);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "assistantstudiov2")]
        public IBodyWorkflowAction<string> CreateCustomActionDefinition([WorkflowExpression] Func<string> organization, [WorkflowExpression] Func<string> entityname, [WorkflowExpression] Func<string> customaction, [WorkflowExpression] Func<object> body = null)
        {
            var apiCallPath = "/api/data/v9.0/msdyn_CreateCustomActionDefinition";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["organization"] = ExpressionConverter.Convert(organization);
            callPayload.Headers["entityname"] = ExpressionConverter.Convert(entityname);
            callPayload.Headers["customaction"] = ExpressionConverter.Convert(customaction);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<string>(callPayload);
        }
    }

    public class Assistantstudiov2Triggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Assistantstudiov2;

    public partial class WorkflowManagedActions
    {
        public Assistantstudiov2Actions Assistantstudiov2(string connectionId) => new Assistantstudiov2Actions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Assistantstudiov2Triggers Assistantstudiov2(string connectionId) => new Assistantstudiov2Triggers(connectionId);
    }
}