//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Assistantstudiov2
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Assistantstudiov2Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "assistantstudiov2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CreateActionCard(Expression<Func<string>> organization, Expression<Func<string>> bodycardname, Expression<Func<string>> bodytitle, Expression<Func<string>> bodydescription, Expression<Func<object>> bodydynamicproperties, Expression<Func<string>> actiontype, Expression<Func<string>> secondaryactiontype = null, Expression<Func<string>> regardingobjecttype = null, Expression<Func<string>> regardingobjectid = null, Expression<Func<string>> ownerid = null, Expression<Func<string>> startdate = null, Expression<Func<string>> expirydate = null)
        {
            var __workflow_organization = WorkflowExpression.Compile(organization, nameof(organization), required: true);
            var __workflow_bodycardname = WorkflowExpression.Compile(bodycardname, nameof(bodycardname), required: true);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: true);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: true);
            var __workflow_bodydynamicproperties = WorkflowExpression.Compile(bodydynamicproperties, nameof(bodydynamicproperties), required: true);
            var __workflow_actiontype = WorkflowExpression.Compile(actiontype, nameof(actiontype), required: true);
            var __workflow_secondaryactiontype = WorkflowExpression.Compile(secondaryactiontype, nameof(secondaryactiontype), required: false);
            var __workflow_regardingobjecttype = WorkflowExpression.Compile(regardingobjecttype, nameof(regardingobjecttype), required: false);
            var __workflow_regardingobjectid = WorkflowExpression.Compile(regardingobjectid, nameof(regardingobjectid), required: false);
            var __workflow_ownerid = WorkflowExpression.Compile(ownerid, nameof(ownerid), required: false);
            var __workflow_startdate = WorkflowExpression.Compile(startdate, nameof(startdate), required: false);
            var __workflow_expirydate = WorkflowExpression.Compile(expirydate, nameof(expirydate), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/data/v9.0/msdyn_ActionCardCreate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["organization"] = ExpressionConverter.Convert(__workflow_organization);
                callPayload.Headers["actiontype"] = ExpressionConverter.Convert(__workflow_actiontype);
                if (__workflow_secondaryactiontype != null)
                    callPayload.Headers["secondaryactiontype"] = ExpressionConverter.Convert(__workflow_secondaryactiontype);
                if (__workflow_regardingobjecttype != null)
                    callPayload.Headers["regardingobjecttype"] = ExpressionConverter.Convert(__workflow_regardingobjecttype);
                if (__workflow_regardingobjectid != null)
                    callPayload.Headers["regardingobjectid"] = ExpressionConverter.Convert(__workflow_regardingobjectid);
                if (__workflow_ownerid != null)
                    callPayload.Headers["ownerid"] = ExpressionConverter.Convert(__workflow_ownerid);
                if (__workflow_startdate != null)
                    callPayload.Headers["startdate"] = ExpressionConverter.Convert(__workflow_startdate);
                if (__workflow_expirydate != null)
                    callPayload.Headers["expirydate"] = ExpressionConverter.Convert(__workflow_expirydate);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["cardname"] = ExpressionConverter.ConvertO(__workflow_bodycardname);
                bodypropCount++;
                body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                bodypropCount++;
                body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                bodypropCount++;
                body["dynamicproperties"] = ExpressionConverter.ConvertO(__workflow_bodydynamicproperties);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "assistantstudiov2")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> CreateCustomActionDefinition(Expression<Func<string>> organization, Expression<Func<string>> entityname, Expression<Func<string>> customaction, Expression<Func<object>> body = null)
        {
            var __workflow_organization = WorkflowExpression.Compile(organization, nameof(organization), required: true);
            var __workflow_entityname = WorkflowExpression.Compile(entityname, nameof(entityname), required: true);
            var __workflow_customaction = WorkflowExpression.Compile(customaction, nameof(customaction), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/data/v9.0/msdyn_CreateCustomActionDefinition";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["organization"] = ExpressionConverter.Convert(__workflow_organization);
                callPayload.Headers["entityname"] = ExpressionConverter.Convert(__workflow_entityname);
                callPayload.Headers["customaction"] = ExpressionConverter.Convert(__workflow_customaction);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
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
