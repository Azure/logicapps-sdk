//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Socialinsider
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SocialinsiderActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "socialinsider")]
        public IWorkflowAction ProfileTimeBasedMetrics(Expression<Func<string>> bodykey = null, Expression<Func<string>> bodyprojectname = null, Expression<Func<string>> bodyplatform = null, Expression<Func<string[]>> bodyprofile = null)
        {
            var __workflow_bodykey = WorkflowExpression.Compile(bodykey, nameof(bodykey), required: false);
            var __workflow_bodyprojectname = WorkflowExpression.Compile(bodyprojectname, nameof(bodyprojectname), required: false);
            var __workflow_bodyplatform = WorkflowExpression.Compile(bodyplatform, nameof(bodyplatform), required: false);
            var __workflow_bodyprofile = WorkflowExpression.Compile(bodyprofile, nameof(bodyprofile), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/profile_time_based_metrics";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodykey != null)
                {
                    body["key"] = ExpressionConverter.ConvertO(__workflow_bodykey);
                    bodypropCount++;
                }

                if (__workflow_bodyprojectname != null)
                {
                    body["projectname"] = ExpressionConverter.ConvertO(__workflow_bodyprojectname);
                    bodypropCount++;
                }

                if (__workflow_bodyplatform != null)
                {
                    body["platform"] = ExpressionConverter.ConvertO(__workflow_bodyplatform);
                    bodypropCount++;
                }

                if (__workflow_bodyprofile != null)
                {
                    body["profile"] = ExpressionConverter.ConvertO(__workflow_bodyprofile);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "socialinsider")]
        public IWorkflowAction ProfileAggregatedMetrics(Expression<Func<string>> bodykey = null, Expression<Func<string>> bodyprojectname = null, Expression<Func<string>> bodyplatform = null, Expression<Func<string[]>> bodyprofiles = null)
        {
            var __workflow_bodykey = WorkflowExpression.Compile(bodykey, nameof(bodykey), required: false);
            var __workflow_bodyprojectname = WorkflowExpression.Compile(bodyprojectname, nameof(bodyprojectname), required: false);
            var __workflow_bodyplatform = WorkflowExpression.Compile(bodyplatform, nameof(bodyplatform), required: false);
            var __workflow_bodyprofiles = WorkflowExpression.Compile(bodyprofiles, nameof(bodyprofiles), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/profiles_aggregated_metrics";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodykey != null)
                {
                    body["key"] = ExpressionConverter.ConvertO(__workflow_bodykey);
                    bodypropCount++;
                }

                if (__workflow_bodyprojectname != null)
                {
                    body["projectname"] = ExpressionConverter.ConvertO(__workflow_bodyprojectname);
                    bodypropCount++;
                }

                if (__workflow_bodyplatform != null)
                {
                    body["platform"] = ExpressionConverter.ConvertO(__workflow_bodyplatform);
                    bodypropCount++;
                }

                if (__workflow_bodyprofiles != null)
                {
                    body["profiles"] = ExpressionConverter.ConvertO(__workflow_bodyprofiles);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "socialinsider")]
        public IWorkflowAction Posts(Expression<Func<string>> bodykey = null, Expression<Func<string>> bodyprojectname = null, Expression<Func<string>> bodyplatform = null, Expression<Func<string[]>> bodyprofiles = null)
        {
            var __workflow_bodykey = WorkflowExpression.Compile(bodykey, nameof(bodykey), required: false);
            var __workflow_bodyprojectname = WorkflowExpression.Compile(bodyprojectname, nameof(bodyprojectname), required: false);
            var __workflow_bodyplatform = WorkflowExpression.Compile(bodyplatform, nameof(bodyplatform), required: false);
            var __workflow_bodyprofiles = WorkflowExpression.Compile(bodyprofiles, nameof(bodyprofiles), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/posts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodykey != null)
                {
                    body["key"] = ExpressionConverter.ConvertO(__workflow_bodykey);
                    bodypropCount++;
                }

                if (__workflow_bodyprojectname != null)
                {
                    body["projectname"] = ExpressionConverter.ConvertO(__workflow_bodyprojectname);
                    bodypropCount++;
                }

                if (__workflow_bodyplatform != null)
                {
                    body["platform"] = ExpressionConverter.ConvertO(__workflow_bodyplatform);
                    bodypropCount++;
                }

                if (__workflow_bodyprofiles != null)
                {
                    body["profiles"] = ExpressionConverter.ConvertO(__workflow_bodyprofiles);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "socialinsider")]
        public IWorkflowAction Stories(Expression<Func<string>> bodykey = null, Expression<Func<string>> bodyprojectname = null, Expression<Func<string[]>> bodyprofiles = null)
        {
            var __workflow_bodykey = WorkflowExpression.Compile(bodykey, nameof(bodykey), required: false);
            var __workflow_bodyprojectname = WorkflowExpression.Compile(bodyprojectname, nameof(bodyprojectname), required: false);
            var __workflow_bodyprofiles = WorkflowExpression.Compile(bodyprofiles, nameof(bodyprofiles), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/stories";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodykey != null)
                {
                    body["key"] = ExpressionConverter.ConvertO(__workflow_bodykey);
                    bodypropCount++;
                }

                if (__workflow_bodyprojectname != null)
                {
                    body["projectname"] = ExpressionConverter.ConvertO(__workflow_bodyprojectname);
                    bodypropCount++;
                }

                if (__workflow_bodyprofiles != null)
                {
                    body["profiles"] = ExpressionConverter.ConvertO(__workflow_bodyprofiles);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
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
