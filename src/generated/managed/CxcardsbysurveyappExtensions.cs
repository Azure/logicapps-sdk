//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cxcardsbysurveyapp
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CxcardsbysurveyappActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cxcardsbysurveyapp")]
        [WorkflowExpressionFactory(nameof(__BuildSendSurvey))]
        public IBodyWorkflowAction<SendSurveyResponse> SendSurvey([WorkflowExpression] Func<string> bodyapiKey, [WorkflowExpression] Func<string> bodyemail = null, [WorkflowExpression] Func<string> bodymobile = null, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodysalutation = null, [WorkflowExpression] Func<string> bodyfirstName = null, [WorkflowExpression] Func<string> bodylastName = null, [WorkflowExpression] Func<string> bodylanguage = null, [WorkflowExpression] Func<string> bodylocale = null, [WorkflowExpression] Func<string> bodyRef = null, [WorkflowExpression] Func<string> bodysubject = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodyrecordType = null, [WorkflowExpression] Func<string> bodyrecordId = null, [WorkflowExpression] Func<string> bodyversionNumber = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cxcardsbysurveyapp")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendSurveyResponse> __BuildSendSurvey(WorkflowExpression<string> bodyapiKey, WorkflowExpression<string> bodyemail = null, WorkflowExpression<string> bodymobile = null, WorkflowExpression<string> bodytitle = null, WorkflowExpression<string> bodysalutation = null, WorkflowExpression<string> bodyfirstName = null, WorkflowExpression<string> bodylastName = null, WorkflowExpression<string> bodylanguage = null, WorkflowExpression<string> bodylocale = null, WorkflowExpression<string> bodyRef = null, WorkflowExpression<string> bodysubject = null, WorkflowExpression<string> bodydescription = null, WorkflowExpression<string> bodyrecordType = null, WorkflowExpression<string> bodyrecordId = null, WorkflowExpression<string> bodyversionNumber = null)
        {
            WorkflowExpression.Validate(bodyapiKey, nameof(bodyapiKey), required: true);
            WorkflowExpression.Validate(bodyemail, nameof(bodyemail), required: false);
            WorkflowExpression.Validate(bodymobile, nameof(bodymobile), required: false);
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            WorkflowExpression.Validate(bodysalutation, nameof(bodysalutation), required: false);
            WorkflowExpression.Validate(bodyfirstName, nameof(bodyfirstName), required: false);
            WorkflowExpression.Validate(bodylastName, nameof(bodylastName), required: false);
            WorkflowExpression.Validate(bodylanguage, nameof(bodylanguage), required: false);
            WorkflowExpression.Validate(bodylocale, nameof(bodylocale), required: false);
            WorkflowExpression.Validate(bodyRef, nameof(bodyRef), required: false);
            WorkflowExpression.Validate(bodysubject, nameof(bodysubject), required: false);
            WorkflowExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            WorkflowExpression.Validate(bodyrecordType, nameof(bodyrecordType), required: false);
            WorkflowExpression.Validate(bodyrecordId, nameof(bodyrecordId), required: false);
            WorkflowExpression.Validate(bodyversionNumber, nameof(bodyversionNumber), required: false);
            return new DeferredBodyAction<SendSurveyResponse>(() =>
            {
                var apiCallPath = "/v1/email-surveys/send";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["api_key"] = ExpressionConverter.ConvertO(bodyapiKey);
                if (bodyemail != null)
                {
                    body["email"] = ExpressionConverter.ConvertO(bodyemail);
                    bodypropCount++;
                }

                if (bodymobile != null)
                {
                    body["mobile"] = ExpressionConverter.ConvertO(bodymobile);
                    bodypropCount++;
                }

                if (bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(bodytitle);
                    bodypropCount++;
                }

                if (bodysalutation != null)
                {
                    body["salutation"] = ExpressionConverter.ConvertO(bodysalutation);
                    bodypropCount++;
                }

                if (bodyfirstName != null)
                {
                    body["first_name"] = ExpressionConverter.ConvertO(bodyfirstName);
                    bodypropCount++;
                }

                if (bodylastName != null)
                {
                    body["last_name"] = ExpressionConverter.ConvertO(bodylastName);
                    bodypropCount++;
                }

                if (bodylanguage != null)
                {
                    body["language"] = ExpressionConverter.ConvertO(bodylanguage);
                    bodypropCount++;
                }

                if (bodylocale != null)
                {
                    body["locale"] = ExpressionConverter.ConvertO(bodylocale);
                    bodypropCount++;
                }

                if (bodyRef != null)
                {
                    body["ref"] = ExpressionConverter.ConvertO(bodyRef);
                    bodypropCount++;
                }

                if (bodysubject != null)
                {
                    body["subject"] = ExpressionConverter.ConvertO(bodysubject);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(bodydescription);
                    bodypropCount++;
                }

                if (bodyrecordType != null)
                {
                    body["record_type"] = ExpressionConverter.ConvertO(bodyrecordType);
                    bodypropCount++;
                }

                if (bodyrecordId != null)
                {
                    body["record_id"] = ExpressionConverter.ConvertO(bodyrecordId);
                    bodypropCount++;
                }

                if (bodyversionNumber != null)
                {
                    body["version_number"] = ExpressionConverter.ConvertO(bodyversionNumber);
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