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
        public IWorkflowAction CreateActionCard([WorkflowExpression] Func<string> organization, [WorkflowExpression] Func<string> bodycardname, [WorkflowExpression] Func<string> bodytitle, [WorkflowExpression] Func<string> bodydescription, [WorkflowExpression] Func<object> bodydynamicproperties, [WorkflowExpression] Func<string> actiontype, [WorkflowExpression] Func<string> secondaryactiontype = null, [WorkflowExpression] Func<string> regardingobjecttype = null, [WorkflowExpression] Func<string> regardingobjectid = null, [WorkflowExpression] Func<string> ownerid = null, [WorkflowExpression] Func<string> startdate = null, [WorkflowExpression] Func<string> expirydate = null)
        {
            SourceExpression.Validate(organization, nameof(organization), required: true);
            SourceExpression.Validate(bodycardname, nameof(bodycardname), required: true);
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: true);
            SourceExpression.Validate(bodydynamicproperties, nameof(bodydynamicproperties), required: true);
            SourceExpression.Validate(actiontype, nameof(actiontype), required: true);
            SourceExpression.Validate(secondaryactiontype, nameof(secondaryactiontype), required: false);
            SourceExpression.Validate(regardingobjecttype, nameof(regardingobjecttype), required: false);
            SourceExpression.Validate(regardingobjectid, nameof(regardingobjectid), required: false);
            SourceExpression.Validate(ownerid, nameof(ownerid), required: false);
            SourceExpression.Validate(startdate, nameof(startdate), required: false);
            SourceExpression.Validate(expirydate, nameof(expirydate), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/data/v9.0/msdyn_ActionCardCreate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["organization"] = SourceExpressionConverter.ConvertO(organization);
                callPayload.Headers["actiontype"] = SourceExpressionConverter.ConvertO(actiontype);
                if (secondaryactiontype != null)
                    callPayload.Headers["secondaryactiontype"] = SourceExpressionConverter.ConvertO(secondaryactiontype);
                if (regardingobjecttype != null)
                    callPayload.Headers["regardingobjecttype"] = SourceExpressionConverter.ConvertO(regardingobjecttype);
                if (regardingobjectid != null)
                    callPayload.Headers["regardingobjectid"] = SourceExpressionConverter.ConvertO(regardingobjectid);
                if (ownerid != null)
                    callPayload.Headers["ownerid"] = SourceExpressionConverter.ConvertO(ownerid);
                if (startdate != null)
                    callPayload.Headers["startdate"] = SourceExpressionConverter.ConvertO(startdate);
                if (expirydate != null)
                    callPayload.Headers["expirydate"] = SourceExpressionConverter.ConvertO(expirydate);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["cardname"] = SourceExpressionConverter.ConvertToken(bodycardname);
                bodypropCount++;
                body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                bodypropCount++;
                body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                bodypropCount++;
                body["dynamicproperties"] = SourceExpressionConverter.ConvertToken(bodydynamicproperties);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "assistantstudiov2")]
        public IBodyWorkflowAction<string> CreateCustomActionDefinition([WorkflowExpression] Func<string> organization, [WorkflowExpression] Func<string> entityname, [WorkflowExpression] Func<string> customaction, [WorkflowExpression] Func<object> body = null)
        {
            SourceExpression.Validate(organization, nameof(organization), required: true);
            SourceExpression.Validate(entityname, nameof(entityname), required: true);
            SourceExpression.Validate(customaction, nameof(customaction), required: true);
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/data/v9.0/msdyn_CreateCustomActionDefinition";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["organization"] = SourceExpressionConverter.ConvertO(organization);
                callPayload.Headers["entityname"] = SourceExpressionConverter.ConvertO(entityname);
                callPayload.Headers["customaction"] = SourceExpressionConverter.ConvertO(customaction);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
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