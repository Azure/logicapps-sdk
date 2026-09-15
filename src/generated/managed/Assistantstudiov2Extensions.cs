//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Assistantstudiov2
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Assistantstudiov2Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "assistantstudiov2")]
        public IWorkflowAction CreateActionCard(Expression<Func<string>> organization, Expression<Func<string>> bodycardname, Expression<Func<string>> bodytitle, Expression<Func<string>> bodydescription, Expression<Func<object>> bodydynamicproperties, Expression<Func<string>> actiontype, Expression<Func<string>> secondaryactiontype = null, Expression<Func<string>> regardingobjecttype = null, Expression<Func<string>> regardingobjectid = null, Expression<Func<string>> ownerid = null, Expression<Func<string>> startdate = null, Expression<Func<string>> expirydate = null)
        {
            var apiCallPath = "/api/data/v9.0/msdyn_ActionCardCreate";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["organization"] = CSharpExpressionConverter.ConvertO(organization);
            callPayload.Headers["actiontype"] = CSharpExpressionConverter.ConvertO(actiontype);
            if (secondaryactiontype != null)
                callPayload.Headers["secondaryactiontype"] = CSharpExpressionConverter.ConvertO(secondaryactiontype);
            if (regardingobjecttype != null)
                callPayload.Headers["regardingobjecttype"] = CSharpExpressionConverter.ConvertO(regardingobjecttype);
            if (regardingobjectid != null)
                callPayload.Headers["regardingobjectid"] = CSharpExpressionConverter.ConvertO(regardingobjectid);
            if (ownerid != null)
                callPayload.Headers["ownerid"] = CSharpExpressionConverter.ConvertO(ownerid);
            if (startdate != null)
                callPayload.Headers["startdate"] = CSharpExpressionConverter.ConvertO(startdate);
            if (expirydate != null)
                callPayload.Headers["expirydate"] = CSharpExpressionConverter.ConvertO(expirydate);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["cardname"] = CSharpExpressionConverter.ConvertToken(bodycardname);
            bodypropCount++;
            body["title"] = CSharpExpressionConverter.ConvertToken(bodytitle);
            bodypropCount++;
            body["description"] = CSharpExpressionConverter.ConvertToken(bodydescription);
            bodypropCount++;
            body["dynamicproperties"] = CSharpExpressionConverter.ConvertToken(bodydynamicproperties);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "assistantstudiov2")]
        public IBodyWorkflowAction<string> CreateCustomActionDefinition(Expression<Func<string>> organization, Expression<Func<string>> entityname, Expression<Func<string>> customaction, Expression<Func<object>> body = null)
        {
            var apiCallPath = "/api/data/v9.0/msdyn_CreateCustomActionDefinition";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["organization"] = CSharpExpressionConverter.ConvertO(organization);
            callPayload.Headers["entityname"] = CSharpExpressionConverter.ConvertO(entityname);
            callPayload.Headers["customaction"] = CSharpExpressionConverter.ConvertO(customaction);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(body);
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