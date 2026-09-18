//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Medallia
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MedalliaActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "medallia")]
        public IWorkflowAction TriggerInvitation([WorkflowExpression] Func<string> service, [WorkflowExpression] Func<string> instanceURL)
        {
            SourceExpression.Validate(service, nameof(service), required: true);
            SourceExpression.Validate(instanceURL, nameof(instanceURL), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(service, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Instance-URL"] = SourceExpressionConverter.ConvertO(instanceURL);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "medallia")]
        public IWorkflowAction SendExperienceSignals([WorkflowExpression] Func<string> service, [WorkflowExpression] Func<string> instanceURL)
        {
            SourceExpression.Validate(service, nameof(service), required: true);
            SourceExpression.Validate(instanceURL, nameof(instanceURL), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/inbound/v1/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(service, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Instance-URL"] = SourceExpressionConverter.ConvertO(instanceURL);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }
    }

    public class MedalliaTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Medallia;

    public partial class WorkflowManagedActions
    {
        public MedalliaActions Medallia(string connectionId) => new MedalliaActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MedalliaTriggers Medallia(string connectionId) => new MedalliaTriggers(connectionId);
    }
}