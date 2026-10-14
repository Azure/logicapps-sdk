//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Activityinfo
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class ActivityinfoActions([ConnectionName] string connectionId)
    {
    }

    public class ActivityinfoTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<JToken> AddRecordTrigger(Expression<Func<string>> formId, Expression<Func<string>> bodylabel, FlowRecurrence recurrence = null)
        {
            var __workflow_formId = formId == null ? null : WorkflowExpression.Compile(formId);
            WorkflowExpression.Validate(__workflow_formId, nameof(formId), required: true);
            var __workflow_bodylabel = bodylabel == null ? null : WorkflowExpression.Compile(bodylabel);
            WorkflowExpression.Validate(__workflow_bodylabel, nameof(bodylabel), required: true);
            return new DeferredBodyTrigger<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/resources/powerautomate/v1/forms/{0}/automation/add", ExpressionConverter.ConvertWithUrlEncoding(__workflow_formId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["label"] = ExpressionConverter.ConvertO(__workflow_bodylabel);
                var actionObject = new JObject();
                var actionObjectpropCount = 0;
                actionObject["type"] = "WEBHOOK";
                actionObjectpropCount++;
                actionObject["url"] = "#{listCallbackUrl()}";
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

                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<JToken> EditRecordTrigger(Expression<Func<string>> formId, Expression<Func<string>> bodylabel, FlowRecurrence recurrence = null)
        {
            var __workflow_formId = formId == null ? null : WorkflowExpression.Compile(formId);
            WorkflowExpression.Validate(__workflow_formId, nameof(formId), required: true);
            var __workflow_bodylabel = bodylabel == null ? null : WorkflowExpression.Compile(bodylabel);
            WorkflowExpression.Validate(__workflow_bodylabel, nameof(bodylabel), required: true);
            return new DeferredBodyTrigger<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/resources/powerautomate/v1/forms/{0}/automation/edit", ExpressionConverter.ConvertWithUrlEncoding(__workflow_formId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["label"] = ExpressionConverter.ConvertO(__workflow_bodylabel);
                var actionObject = new JObject();
                var actionObjectpropCount = 0;
                actionObject["type"] = "WEBHOOK";
                actionObjectpropCount++;
                actionObject["url"] = "#{listCallbackUrl()}";
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

                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<JToken> DeleteRecordTrigger(Expression<Func<string>> formId, Expression<Func<string>> bodylabel, FlowRecurrence recurrence = null)
        {
            var __workflow_formId = formId == null ? null : WorkflowExpression.Compile(formId);
            WorkflowExpression.Validate(__workflow_formId, nameof(formId), required: true);
            var __workflow_bodylabel = bodylabel == null ? null : WorkflowExpression.Compile(bodylabel);
            WorkflowExpression.Validate(__workflow_bodylabel, nameof(bodylabel), required: true);
            return new DeferredBodyTrigger<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/resources/powerautomate/v1/forms/{0}/automation/delete", ExpressionConverter.ConvertWithUrlEncoding(__workflow_formId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["label"] = ExpressionConverter.ConvertO(__workflow_bodylabel);
                var actionObject = new JObject();
                var actionObjectpropCount = 0;
                actionObject["type"] = "WEBHOOK";
                actionObjectpropCount++;
                actionObject["url"] = "#{listCallbackUrl()}";
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

                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
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
