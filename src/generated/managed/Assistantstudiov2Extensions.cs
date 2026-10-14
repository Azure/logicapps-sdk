//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Assistantstudiov2
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class Assistantstudiov2Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "assistantstudiov2")]
        public IWorkflowAction CreateActionCard(Expression<Func<string>> organization, Expression<Func<string>> bodycardname, Expression<Func<string>> bodytitle, Expression<Func<string>> bodydescription, Expression<Func<object>> bodydynamicproperties, Expression<Func<string>> actiontype, Expression<Func<string>> secondaryactiontype = null, Expression<Func<string>> regardingobjecttype = null, Expression<Func<string>> regardingobjectid = null, Expression<Func<string>> ownerid = null, Expression<Func<string>> startdate = null, Expression<Func<string>> expirydate = null)
        {
            var __workflow_organization = organization == null ? null : WorkflowExpression.Compile(organization);
            WorkflowExpression.Validate(__workflow_organization, nameof(organization), required: true);
            var __workflow_bodycardname = bodycardname == null ? null : WorkflowExpression.Compile(bodycardname);
            WorkflowExpression.Validate(__workflow_bodycardname, nameof(bodycardname), required: true);
            var __workflow_bodytitle = bodytitle == null ? null : WorkflowExpression.Compile(bodytitle);
            WorkflowExpression.Validate(__workflow_bodytitle, nameof(bodytitle), required: true);
            var __workflow_bodydescription = bodydescription == null ? null : WorkflowExpression.Compile(bodydescription);
            WorkflowExpression.Validate(__workflow_bodydescription, nameof(bodydescription), required: true);
            var __workflow_bodydynamicproperties = bodydynamicproperties == null ? null : WorkflowExpression.Compile(bodydynamicproperties);
            WorkflowExpression.Validate(__workflow_bodydynamicproperties, nameof(bodydynamicproperties), required: true);
            var __workflow_actiontype = actiontype == null ? null : WorkflowExpression.Compile(actiontype);
            WorkflowExpression.Validate(__workflow_actiontype, nameof(actiontype), required: true);
            var __workflow_secondaryactiontype = secondaryactiontype == null ? null : WorkflowExpression.Compile(secondaryactiontype);
            WorkflowExpression.Validate(__workflow_secondaryactiontype, nameof(secondaryactiontype), required: false);
            var __workflow_regardingobjecttype = regardingobjecttype == null ? null : WorkflowExpression.Compile(regardingobjecttype);
            WorkflowExpression.Validate(__workflow_regardingobjecttype, nameof(regardingobjecttype), required: false);
            var __workflow_regardingobjectid = regardingobjectid == null ? null : WorkflowExpression.Compile(regardingobjectid);
            WorkflowExpression.Validate(__workflow_regardingobjectid, nameof(regardingobjectid), required: false);
            var __workflow_ownerid = ownerid == null ? null : WorkflowExpression.Compile(ownerid);
            WorkflowExpression.Validate(__workflow_ownerid, nameof(ownerid), required: false);
            var __workflow_startdate = startdate == null ? null : WorkflowExpression.Compile(startdate);
            WorkflowExpression.Validate(__workflow_startdate, nameof(startdate), required: false);
            var __workflow_expirydate = expirydate == null ? null : WorkflowExpression.Compile(expirydate);
            WorkflowExpression.Validate(__workflow_expirydate, nameof(expirydate), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IBodyWorkflowAction<string> CreateCustomActionDefinition(Expression<Func<string>> organization, Expression<Func<string>> entityname, Expression<Func<string>> customaction, Expression<Func<object>> body = null)
        {
            var __workflow_organization = organization == null ? null : WorkflowExpression.Compile(organization);
            WorkflowExpression.Validate(__workflow_organization, nameof(organization), required: true);
            var __workflow_entityname = entityname == null ? null : WorkflowExpression.Compile(entityname);
            WorkflowExpression.Validate(__workflow_entityname, nameof(entityname), required: true);
            var __workflow_customaction = customaction == null ? null : WorkflowExpression.Compile(customaction);
            WorkflowExpression.Validate(__workflow_customaction, nameof(customaction), required: true);
            var __workflow_body = body == null ? null : WorkflowExpression.Compile(body);
            WorkflowExpression.Validate(__workflow_body, nameof(body), required: false);
            return new DeferredBodyAction<string>(() =>
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
