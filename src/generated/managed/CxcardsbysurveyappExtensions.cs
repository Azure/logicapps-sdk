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
        public IBodyWorkflowAction<SendSurveyResponse> SendSurvey(Expression<Func<string>> bodyapiKey, Expression<Func<string>> bodyemail = null, Expression<Func<string>> bodymobile = null, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodysalutation = null, Expression<Func<string>> bodyfirstName = null, Expression<Func<string>> bodylastName = null, Expression<Func<string>> bodylanguage = null, Expression<Func<string>> bodylocale = null, Expression<Func<string>> bodyRef = null, Expression<Func<string>> bodysubject = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodyrecordType = null, Expression<Func<string>> bodyrecordId = null, Expression<Func<string>> bodyversionNumber = null)
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