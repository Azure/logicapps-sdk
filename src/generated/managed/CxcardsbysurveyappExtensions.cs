//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cxcardsbysurveyapp
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CxcardsbysurveyappActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cxcardsbysurveyapp")]
        public IBodyWorkflowAction<SendSurveyResponse, ApiConnectionActionConfiguration> SendSurvey(Expression<Func<string>> bodyapiKey, Expression<Func<string>> bodyemail = null, Expression<Func<string>> bodymobile = null, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodysalutation = null, Expression<Func<string>> bodyfirstName = null, Expression<Func<string>> bodylastName = null, Expression<Func<string>> bodylanguage = null, Expression<Func<string>> bodylocale = null, Expression<Func<string>> bodyRef = null, Expression<Func<string>> bodysubject = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodyrecordType = null, Expression<Func<string>> bodyrecordId = null, Expression<Func<string>> bodyversionNumber = null)
        {
            var __workflow_bodyapiKey = WorkflowExpression.Compile(bodyapiKey, nameof(bodyapiKey), required: true);
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: false);
            var __workflow_bodymobile = WorkflowExpression.Compile(bodymobile, nameof(bodymobile), required: false);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: false);
            var __workflow_bodysalutation = WorkflowExpression.Compile(bodysalutation, nameof(bodysalutation), required: false);
            var __workflow_bodyfirstName = WorkflowExpression.Compile(bodyfirstName, nameof(bodyfirstName), required: false);
            var __workflow_bodylastName = WorkflowExpression.Compile(bodylastName, nameof(bodylastName), required: false);
            var __workflow_bodylanguage = WorkflowExpression.Compile(bodylanguage, nameof(bodylanguage), required: false);
            var __workflow_bodylocale = WorkflowExpression.Compile(bodylocale, nameof(bodylocale), required: false);
            var __workflow_bodyRef = WorkflowExpression.Compile(bodyRef, nameof(bodyRef), required: false);
            var __workflow_bodysubject = WorkflowExpression.Compile(bodysubject, nameof(bodysubject), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodyrecordType = WorkflowExpression.Compile(bodyrecordType, nameof(bodyrecordType), required: false);
            var __workflow_bodyrecordId = WorkflowExpression.Compile(bodyrecordId, nameof(bodyrecordId), required: false);
            var __workflow_bodyversionNumber = WorkflowExpression.Compile(bodyversionNumber, nameof(bodyversionNumber), required: false);
            return new DeferredBodyAction<SendSurveyResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/email-surveys/send";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["api_key"] = ExpressionConverter.ConvertO(__workflow_bodyapiKey);
                if (__workflow_bodyemail != null)
                {
                    body["email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                    bodypropCount++;
                }

                if (__workflow_bodymobile != null)
                {
                    body["mobile"] = ExpressionConverter.ConvertO(__workflow_bodymobile);
                    bodypropCount++;
                }

                if (__workflow_bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (__workflow_bodysalutation != null)
                {
                    body["salutation"] = ExpressionConverter.ConvertO(__workflow_bodysalutation);
                    bodypropCount++;
                }

                if (__workflow_bodyfirstName != null)
                {
                    body["first_name"] = ExpressionConverter.ConvertO(__workflow_bodyfirstName);
                    bodypropCount++;
                }

                if (__workflow_bodylastName != null)
                {
                    body["last_name"] = ExpressionConverter.ConvertO(__workflow_bodylastName);
                    bodypropCount++;
                }

                if (__workflow_bodylanguage != null)
                {
                    body["language"] = ExpressionConverter.ConvertO(__workflow_bodylanguage);
                    bodypropCount++;
                }

                if (__workflow_bodylocale != null)
                {
                    body["locale"] = ExpressionConverter.ConvertO(__workflow_bodylocale);
                    bodypropCount++;
                }

                if (__workflow_bodyRef != null)
                {
                    body["ref"] = ExpressionConverter.ConvertO(__workflow_bodyRef);
                    bodypropCount++;
                }

                if (__workflow_bodysubject != null)
                {
                    body["subject"] = ExpressionConverter.ConvertO(__workflow_bodysubject);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodyrecordType != null)
                {
                    body["record_type"] = ExpressionConverter.ConvertO(__workflow_bodyrecordType);
                    bodypropCount++;
                }

                if (__workflow_bodyrecordId != null)
                {
                    body["record_id"] = ExpressionConverter.ConvertO(__workflow_bodyrecordId);
                    bodypropCount++;
                }

                if (__workflow_bodyversionNumber != null)
                {
                    body["version_number"] = ExpressionConverter.ConvertO(__workflow_bodyversionNumber);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SendSurveyResponse>(callPayload);
            });
        }
    }

    public class CxcardsbysurveyappTriggers([ConnectionName] string connectionId)
    {
    }

    public class SendSurveyResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Cxcardsbysurveyapp;

    public partial class WorkflowManagedActions
    {
        public CxcardsbysurveyappActions Cxcardsbysurveyapp(string connectionId) => new CxcardsbysurveyappActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CxcardsbysurveyappTriggers Cxcardsbysurveyapp(string connectionId) => new CxcardsbysurveyappTriggers(connectionId);
    }
}
