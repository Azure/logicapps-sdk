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
        public IWorkflowAction ProfileTimeBasedMetrics(Expression<Func<string>> bodykey = null, Expression<Func<string>> bodyprojectname = null, Expression<Func<string>> bodyplatform = null, Expression<Func<string[]>> bodyprofile = null)
        {
            var apiCallPath = "/profile_time_based_metrics";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodykey != null)
            {
                body["key"] = CSharpExpressionConverter.ConvertToken(bodykey);
                bodypropCount++;
            }

            if (bodyprojectname != null)
            {
                body["projectname"] = CSharpExpressionConverter.ConvertToken(bodyprojectname);
                bodypropCount++;
            }

            if (bodyplatform != null)
            {
                body["platform"] = CSharpExpressionConverter.ConvertToken(bodyplatform);
                bodypropCount++;
            }

            if (bodyprofile != null)
            {
                body["profile"] = CSharpExpressionConverter.ConvertToken(bodyprofile);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "socialinsider")]
        public IWorkflowAction ProfileAggregatedMetrics(Expression<Func<string>> bodykey = null, Expression<Func<string>> bodyprojectname = null, Expression<Func<string>> bodyplatform = null, Expression<Func<string[]>> bodyprofiles = null)
        {
            var apiCallPath = "/profiles_aggregated_metrics";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodykey != null)
            {
                body["key"] = CSharpExpressionConverter.ConvertToken(bodykey);
                bodypropCount++;
            }

            if (bodyprojectname != null)
            {
                body["projectname"] = CSharpExpressionConverter.ConvertToken(bodyprojectname);
                bodypropCount++;
            }

            if (bodyplatform != null)
            {
                body["platform"] = CSharpExpressionConverter.ConvertToken(bodyplatform);
                bodypropCount++;
            }

            if (bodyprofiles != null)
            {
                body["profiles"] = CSharpExpressionConverter.ConvertToken(bodyprofiles);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "socialinsider")]
        public IWorkflowAction Posts(Expression<Func<string>> bodykey = null, Expression<Func<string>> bodyprojectname = null, Expression<Func<string>> bodyplatform = null, Expression<Func<string[]>> bodyprofiles = null)
        {
            var apiCallPath = "/posts";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodykey != null)
            {
                body["key"] = CSharpExpressionConverter.ConvertToken(bodykey);
                bodypropCount++;
            }

            if (bodyprojectname != null)
            {
                body["projectname"] = CSharpExpressionConverter.ConvertToken(bodyprojectname);
                bodypropCount++;
            }

            if (bodyplatform != null)
            {
                body["platform"] = CSharpExpressionConverter.ConvertToken(bodyplatform);
                bodypropCount++;
            }

            if (bodyprofiles != null)
            {
                body["profiles"] = CSharpExpressionConverter.ConvertToken(bodyprofiles);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "socialinsider")]
        public IWorkflowAction Stories(Expression<Func<string>> bodykey = null, Expression<Func<string>> bodyprojectname = null, Expression<Func<string[]>> bodyprofiles = null)
        {
            var apiCallPath = "/stories";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodykey != null)
            {
                body["key"] = CSharpExpressionConverter.ConvertToken(bodykey);
                bodypropCount++;
            }

            if (bodyprojectname != null)
            {
                body["projectname"] = CSharpExpressionConverter.ConvertToken(bodyprojectname);
                bodypropCount++;
            }

            if (bodyprofiles != null)
            {
                body["profiles"] = CSharpExpressionConverter.ConvertToken(bodyprofiles);
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