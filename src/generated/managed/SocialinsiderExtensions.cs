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
        [WorkflowExpressionFactory(nameof(__BuildProfileTimeBasedMetrics))]
        public IWorkflowAction ProfileTimeBasedMetrics([WorkflowExpression] Func<string> bodykey = null, [WorkflowExpression] Func<string> bodyprojectname = null, [WorkflowExpression] Func<string> bodyplatform = null, [WorkflowExpression] Func<string[]> bodyprofile = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "socialinsider")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildProfileTimeBasedMetrics(WorkflowExpression<string> bodykey = null, WorkflowExpression<string> bodyprojectname = null, WorkflowExpression<string> bodyplatform = null, WorkflowExpression<string[]> bodyprofile = null)
        {
            WorkflowExpression.Validate(bodykey, nameof(bodykey), required: false);
            WorkflowExpression.Validate(bodyprojectname, nameof(bodyprojectname), required: false);
            WorkflowExpression.Validate(bodyplatform, nameof(bodyplatform), required: false);
            WorkflowExpression.Validate(bodyprofile, nameof(bodyprofile), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "socialinsider")]
        [WorkflowExpressionFactory(nameof(__BuildProfileAggregatedMetrics))]
        public IWorkflowAction ProfileAggregatedMetrics([WorkflowExpression] Func<string> bodykey = null, [WorkflowExpression] Func<string> bodyprojectname = null, [WorkflowExpression] Func<string> bodyplatform = null, [WorkflowExpression] Func<string[]> bodyprofiles = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "socialinsider")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildProfileAggregatedMetrics(WorkflowExpression<string> bodykey = null, WorkflowExpression<string> bodyprojectname = null, WorkflowExpression<string> bodyplatform = null, WorkflowExpression<string[]> bodyprofiles = null)
        {
            WorkflowExpression.Validate(bodykey, nameof(bodykey), required: false);
            WorkflowExpression.Validate(bodyprojectname, nameof(bodyprojectname), required: false);
            WorkflowExpression.Validate(bodyplatform, nameof(bodyplatform), required: false);
            WorkflowExpression.Validate(bodyprofiles, nameof(bodyprofiles), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "socialinsider")]
        [WorkflowExpressionFactory(nameof(__BuildPosts))]
        public IWorkflowAction Posts([WorkflowExpression] Func<string> bodykey = null, [WorkflowExpression] Func<string> bodyprojectname = null, [WorkflowExpression] Func<string> bodyplatform = null, [WorkflowExpression] Func<string[]> bodyprofiles = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "socialinsider")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildPosts(WorkflowExpression<string> bodykey = null, WorkflowExpression<string> bodyprojectname = null, WorkflowExpression<string> bodyplatform = null, WorkflowExpression<string[]> bodyprofiles = null)
        {
            WorkflowExpression.Validate(bodykey, nameof(bodykey), required: false);
            WorkflowExpression.Validate(bodyprojectname, nameof(bodyprojectname), required: false);
            WorkflowExpression.Validate(bodyplatform, nameof(bodyplatform), required: false);
            WorkflowExpression.Validate(bodyprofiles, nameof(bodyprofiles), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "socialinsider")]
        [WorkflowExpressionFactory(nameof(__BuildStories))]
        public IWorkflowAction Stories([WorkflowExpression] Func<string> bodykey = null, [WorkflowExpression] Func<string> bodyprojectname = null, [WorkflowExpression] Func<string[]> bodyprofiles = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "socialinsider")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildStories(WorkflowExpression<string> bodykey = null, WorkflowExpression<string> bodyprojectname = null, WorkflowExpression<string[]> bodyprofiles = null)
        {
            WorkflowExpression.Validate(bodykey, nameof(bodykey), required: false);
            WorkflowExpression.Validate(bodyprojectname, nameof(bodyprojectname), required: false);
            WorkflowExpression.Validate(bodyprofiles, nameof(bodyprofiles), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
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