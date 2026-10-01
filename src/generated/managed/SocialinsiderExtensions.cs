//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Socialinsider
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SocialinsiderActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "socialinsider")]
        public IWorkflowAction ProfileTimeBasedMetrics([WorkflowExpression] Func<string> bodykey = null, [WorkflowExpression] Func<string> bodyprojectname = null, [WorkflowExpression] Func<string> bodyplatform = null, [WorkflowExpression] Func<string[]> bodyprofile = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/profile_time_based_metrics";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodykey != null)
                {
                    body["key"] = SourceExpressionConverter.ConvertToken(bodykey);
                    bodypropCount++;
                }

                if (bodyprojectname != null)
                {
                    body["projectname"] = SourceExpressionConverter.ConvertToken(bodyprojectname);
                    bodypropCount++;
                }

                if (bodyplatform != null)
                {
                    body["platform"] = SourceExpressionConverter.ConvertToken(bodyplatform);
                    bodypropCount++;
                }

                if (bodyprofile != null)
                {
                    body["profile"] = SourceExpressionConverter.ConvertToken(bodyprofile);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "socialinsider")]
        public IWorkflowAction ProfileAggregatedMetrics([WorkflowExpression] Func<string> bodykey = null, [WorkflowExpression] Func<string> bodyprojectname = null, [WorkflowExpression] Func<string> bodyplatform = null, [WorkflowExpression] Func<string[]> bodyprofiles = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/profiles_aggregated_metrics";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodykey != null)
                {
                    body["key"] = SourceExpressionConverter.ConvertToken(bodykey);
                    bodypropCount++;
                }

                if (bodyprojectname != null)
                {
                    body["projectname"] = SourceExpressionConverter.ConvertToken(bodyprojectname);
                    bodypropCount++;
                }

                if (bodyplatform != null)
                {
                    body["platform"] = SourceExpressionConverter.ConvertToken(bodyplatform);
                    bodypropCount++;
                }

                if (bodyprofiles != null)
                {
                    body["profiles"] = SourceExpressionConverter.ConvertToken(bodyprofiles);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "socialinsider")]
        public IWorkflowAction Posts([WorkflowExpression] Func<string> bodykey = null, [WorkflowExpression] Func<string> bodyprojectname = null, [WorkflowExpression] Func<string> bodyplatform = null, [WorkflowExpression] Func<string[]> bodyprofiles = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/posts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodykey != null)
                {
                    body["key"] = SourceExpressionConverter.ConvertToken(bodykey);
                    bodypropCount++;
                }

                if (bodyprojectname != null)
                {
                    body["projectname"] = SourceExpressionConverter.ConvertToken(bodyprojectname);
                    bodypropCount++;
                }

                if (bodyplatform != null)
                {
                    body["platform"] = SourceExpressionConverter.ConvertToken(bodyplatform);
                    bodypropCount++;
                }

                if (bodyprofiles != null)
                {
                    body["profiles"] = SourceExpressionConverter.ConvertToken(bodyprofiles);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "socialinsider")]
        public IWorkflowAction Stories([WorkflowExpression] Func<string> bodykey = null, [WorkflowExpression] Func<string> bodyprojectname = null, [WorkflowExpression] Func<string[]> bodyprofiles = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/stories";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodykey != null)
                {
                    body["key"] = SourceExpressionConverter.ConvertToken(bodykey);
                    bodypropCount++;
                }

                if (bodyprojectname != null)
                {
                    body["projectname"] = SourceExpressionConverter.ConvertToken(bodyprojectname);
                    bodypropCount++;
                }

                if (bodyprofiles != null)
                {
                    body["profiles"] = SourceExpressionConverter.ConvertToken(bodyprofiles);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
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