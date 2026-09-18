//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Socialinsider
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SocialinsiderActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "socialinsider")]
        public IWorkflowAction ProfileTimeBasedMetrics([WorkflowExpression] Func<string> bodykey = null, [WorkflowExpression] Func<string> bodyprojectname = null, [WorkflowExpression] Func<string> bodyplatform = null, [WorkflowExpression] Func<string[]> bodyprofile = null)
        {
            var apiCallPath = "/profile_time_based_metrics";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodykey != null)
            {
                body["key"] = ExpressionConverter.ConvertO(bodykey);
                bodypropCount++;
            }

            if (bodyprojectname != null)
            {
                body["projectname"] = ExpressionConverter.ConvertO(bodyprojectname);
                bodypropCount++;
            }

            if (bodyplatform != null)
            {
                body["platform"] = ExpressionConverter.ConvertO(bodyplatform);
                bodypropCount++;
            }

            if (bodyprofile != null)
            {
                body["profile"] = ExpressionConverter.ConvertO(bodyprofile);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "socialinsider")]
        public IWorkflowAction ProfileAggregatedMetrics([WorkflowExpression] Func<string> bodykey = null, [WorkflowExpression] Func<string> bodyprojectname = null, [WorkflowExpression] Func<string> bodyplatform = null, [WorkflowExpression] Func<string[]> bodyprofiles = null)
        {
            var apiCallPath = "/profiles_aggregated_metrics";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodykey != null)
            {
                body["key"] = ExpressionConverter.ConvertO(bodykey);
                bodypropCount++;
            }

            if (bodyprojectname != null)
            {
                body["projectname"] = ExpressionConverter.ConvertO(bodyprojectname);
                bodypropCount++;
            }

            if (bodyplatform != null)
            {
                body["platform"] = ExpressionConverter.ConvertO(bodyplatform);
                bodypropCount++;
            }

            if (bodyprofiles != null)
            {
                body["profiles"] = ExpressionConverter.ConvertO(bodyprofiles);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "socialinsider")]
        public IWorkflowAction Posts([WorkflowExpression] Func<string> bodykey = null, [WorkflowExpression] Func<string> bodyprojectname = null, [WorkflowExpression] Func<string> bodyplatform = null, [WorkflowExpression] Func<string[]> bodyprofiles = null)
        {
            var apiCallPath = "/posts";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodykey != null)
            {
                body["key"] = ExpressionConverter.ConvertO(bodykey);
                bodypropCount++;
            }

            if (bodyprojectname != null)
            {
                body["projectname"] = ExpressionConverter.ConvertO(bodyprojectname);
                bodypropCount++;
            }

            if (bodyplatform != null)
            {
                body["platform"] = ExpressionConverter.ConvertO(bodyplatform);
                bodypropCount++;
            }

            if (bodyprofiles != null)
            {
                body["profiles"] = ExpressionConverter.ConvertO(bodyprofiles);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "socialinsider")]
        public IWorkflowAction Stories([WorkflowExpression] Func<string> bodykey = null, [WorkflowExpression] Func<string> bodyprojectname = null, [WorkflowExpression] Func<string[]> bodyprofiles = null)
        {
            var apiCallPath = "/stories";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodykey != null)
            {
                body["key"] = ExpressionConverter.ConvertO(bodykey);
                bodypropCount++;
            }

            if (bodyprojectname != null)
            {
                body["projectname"] = ExpressionConverter.ConvertO(bodyprojectname);
                bodypropCount++;
            }

            if (bodyprofiles != null)
            {
                body["profiles"] = ExpressionConverter.ConvertO(bodyprofiles);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }
    }

    public class SocialinsiderTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Socialinsider;

    public partial class WorkflowManagedActions
    {
        public SocialinsiderActions Socialinsider(string connectionId) => new SocialinsiderActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SocialinsiderTriggers Socialinsider(string connectionId) => new SocialinsiderTriggers(connectionId);
    }
}