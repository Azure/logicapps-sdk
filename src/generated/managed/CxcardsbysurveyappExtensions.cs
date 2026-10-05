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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendSurveyResponse> __BuildSendSurvey(WorkflowValue<string> bodyapiKey, WorkflowValue<string> bodyemail = null, WorkflowValue<string> bodymobile = null, WorkflowValue<string> bodytitle = null, WorkflowValue<string> bodysalutation = null, WorkflowValue<string> bodyfirstName = null, WorkflowValue<string> bodylastName = null, WorkflowValue<string> bodylanguage = null, WorkflowValue<string> bodylocale = null, WorkflowValue<string> bodyRef = null, WorkflowValue<string> bodysubject = null, WorkflowValue<string> bodydescription = null, WorkflowValue<string> bodyrecordType = null, WorkflowValue<string> bodyrecordId = null, WorkflowValue<string> bodyversionNumber = null)
        {
            WorkflowValue.Validate(bodyapiKey, nameof(bodyapiKey), required: true);
            WorkflowValue.Validate(bodyemail, nameof(bodyemail), required: false);
            WorkflowValue.Validate(bodymobile, nameof(bodymobile), required: false);
            WorkflowValue.Validate(bodytitle, nameof(bodytitle), required: false);
            WorkflowValue.Validate(bodysalutation, nameof(bodysalutation), required: false);
            WorkflowValue.Validate(bodyfirstName, nameof(bodyfirstName), required: false);
            WorkflowValue.Validate(bodylastName, nameof(bodylastName), required: false);
            WorkflowValue.Validate(bodylanguage, nameof(bodylanguage), required: false);
            WorkflowValue.Validate(bodylocale, nameof(bodylocale), required: false);
            WorkflowValue.Validate(bodyRef, nameof(bodyRef), required: false);
            WorkflowValue.Validate(bodysubject, nameof(bodysubject), required: false);
            WorkflowValue.Validate(bodydescription, nameof(bodydescription), required: false);
            WorkflowValue.Validate(bodyrecordType, nameof(bodyrecordType), required: false);
            WorkflowValue.Validate(bodyrecordId, nameof(bodyrecordId), required: false);
            WorkflowValue.Validate(bodyversionNumber, nameof(bodyversionNumber), required: false);
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
