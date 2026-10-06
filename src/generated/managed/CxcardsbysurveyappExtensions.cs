//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cxcardsbysurveyapp
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CxcardsbysurveyappActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cxcardsbysurveyapp")]
        public IBodyWorkflowAction<SendSurveyResponse> SendSurvey([WorkflowExpression] Func<string> bodyapiKey, [WorkflowExpression] Func<string> bodyemail = null, [WorkflowExpression] Func<string> bodymobile = null, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodysalutation = null, [WorkflowExpression] Func<string> bodyfirstName = null, [WorkflowExpression] Func<string> bodylastName = null, [WorkflowExpression] Func<string> bodylanguage = null, [WorkflowExpression] Func<string> bodylocale = null, [WorkflowExpression] Func<string> bodyRef = null, [WorkflowExpression] Func<string> bodysubject = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodyrecordType = null, [WorkflowExpression] Func<string> bodyrecordId = null, [WorkflowExpression] Func<string> bodyversionNumber = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/email-surveys/send";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["api_key"] = SourceExpressionConverter.ConvertToken(bodyapiKey);
                if (bodyemail != null)
                {
                    body["email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                    bodypropCount++;
                }

                if (bodymobile != null)
                {
                    body["mobile"] = SourceExpressionConverter.ConvertToken(bodymobile);
                    bodypropCount++;
                }

                if (bodytitle != null)
                {
                    body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodysalutation != null)
                {
                    body["salutation"] = SourceExpressionConverter.ConvertToken(bodysalutation);
                    bodypropCount++;
                }

                if (bodyfirstName != null)
                {
                    body["first_name"] = SourceExpressionConverter.ConvertToken(bodyfirstName);
                    bodypropCount++;
                }

                if (bodylastName != null)
                {
                    body["last_name"] = SourceExpressionConverter.ConvertToken(bodylastName);
                    bodypropCount++;
                }

                if (bodylanguage != null)
                {
                    body["language"] = SourceExpressionConverter.ConvertToken(bodylanguage);
                    bodypropCount++;
                }

                if (bodylocale != null)
                {
                    body["locale"] = SourceExpressionConverter.ConvertToken(bodylocale);
                    bodypropCount++;
                }

                if (bodyRef != null)
                {
                    body["ref"] = SourceExpressionConverter.ConvertToken(bodyRef);
                    bodypropCount++;
                }

                if (bodysubject != null)
                {
                    body["subject"] = SourceExpressionConverter.ConvertToken(bodysubject);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodyrecordType != null)
                {
                    body["record_type"] = SourceExpressionConverter.ConvertToken(bodyrecordType);
                    bodypropCount++;
                }

                if (bodyrecordId != null)
                {
                    body["record_id"] = SourceExpressionConverter.ConvertToken(bodyrecordId);
                    bodypropCount++;
                }

                if (bodyversionNumber != null)
                {
                    body["version_number"] = SourceExpressionConverter.ConvertToken(bodyversionNumber);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SendSurveyResponse>(BuildSourceInput);
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