//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Cognitoforms
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CognitoformsActions([ConnectionName] string connectionId)
    {
    }

    public class CognitoformsTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger NewEntry(Expression<Func<string>> publisher)
        {
            var apiCallPath = "/integration/oauth/subscribenewentry";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["module"] = Convert.ToString("forms");
            callPayload.Queries["publisher"] = ExpressionConverter.Convert(publisher);
            var endpoint = new JObject();
            var endpointpropCount = 0;
            endpoint["notificationUrl"] = "@listcallbackurl()";
            endpointpropCount++;
            if (endpointpropCount > 0)
            {
                callPayload.Body = endpoint;
            }

            return new ApiConnectionTrigger(callPayload);
        }

        public IWorkflowTrigger UpdateEntry(Expression<Func<string>> publisher)
        {
            var apiCallPath = "/integration/oauth/subscribeupdateentry";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["module"] = Convert.ToString("forms");
            callPayload.Queries["publisher"] = ExpressionConverter.Convert(publisher);
            var endpoint = new JObject();
            var endpointpropCount = 0;
            endpoint["notificationUrl"] = "@listcallbackurl()";
            endpointpropCount++;
            if (endpointpropCount > 0)
            {
                callPayload.Body = endpoint;
            }

            return new ApiConnectionTrigger(callPayload);
        }

        public IWorkflowTrigger EntryDeleted(Expression<Func<string>> publisher)
        {
            var apiCallPath = "/integration/oauth/subscribeentrydeleted";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["module"] = Convert.ToString("forms");
            callPayload.Queries["publisher"] = ExpressionConverter.Convert(publisher);
            var endpoint = new JObject();
            var endpointpropCount = 0;
            endpoint["notificationUrl"] = "@listcallbackurl()";
            endpointpropCount++;
            if (endpointpropCount > 0)
            {
                callPayload.Body = endpoint;
            }

            return new ApiConnectionTrigger(callPayload);
        }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Cognitoforms;

    public partial class WorkflowManagedActions
    {
        public CognitoformsActions Cognitoforms(string connectionId) => new CognitoformsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CognitoformsTriggers Cognitoforms(string connectionId) => new CognitoformsTriggers(connectionId);
    }
}