//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Activityinfo
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ActivityinfoActions([ConnectionName] string connectionId)
    {
    }

    public class ActivityinfoTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<JToken> AddRecordTrigger(Expression<Func<string>> formId, Expression<Func<string>> bodylabel, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/resources/powerautomate/v1/forms/{0}/automation/add", ExpressionConverter.ConvertWithUrlEncoding(formId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-type"] = Convert.ToString("application/json");
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["label"] = ExpressionConverter.ConvertO(bodylabel);
            var actionObject = new JObject();
            var actionObjectpropCount = 0;
            actionObject["type"] = "WEBHOOK";
            actionObjectpropCount++;
            actionObject["url"] = "@listCallbackUrl()";
            actionObjectpropCount++;
            if (actionObjectpropCount > 0)
            {
                body["action"] = actionObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<JToken>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<JToken> EditRecordTrigger(Expression<Func<string>> formId, Expression<Func<string>> bodylabel, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/resources/powerautomate/v1/forms/{0}/automation/edit", ExpressionConverter.ConvertWithUrlEncoding(formId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-type"] = Convert.ToString("application/json");
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["label"] = ExpressionConverter.ConvertO(bodylabel);
            var actionObject = new JObject();
            var actionObjectpropCount = 0;
            actionObject["type"] = "WEBHOOK";
            actionObjectpropCount++;
            actionObject["url"] = "@listCallbackUrl()";
            actionObjectpropCount++;
            if (actionObjectpropCount > 0)
            {
                body["action"] = actionObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<JToken>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<JToken> DeleteRecordTrigger(Expression<Func<string>> formId, Expression<Func<string>> bodylabel, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/resources/powerautomate/v1/forms/{0}/automation/delete", ExpressionConverter.ConvertWithUrlEncoding(formId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-type"] = Convert.ToString("application/json");
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["label"] = ExpressionConverter.ConvertO(bodylabel);
            var actionObject = new JObject();
            var actionObjectpropCount = 0;
            actionObject["type"] = "WEBHOOK";
            actionObjectpropCount++;
            actionObject["url"] = "@listCallbackUrl()";
            actionObjectpropCount++;
            if (actionObjectpropCount > 0)
            {
                body["action"] = actionObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<JToken>(callPayload, triggerName, recurrence);
        }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Activityinfo;

    public partial class WorkflowManagedActions
    {
        public ActivityinfoActions Activityinfo(string connectionId) => new ActivityinfoActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ActivityinfoTriggers Activityinfo(string connectionId) => new ActivityinfoTriggers(connectionId);
    }
}