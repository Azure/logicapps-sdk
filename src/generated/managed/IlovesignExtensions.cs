//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ilovesign
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class IlovesignActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovesign")]
        public IBodyWorkflowAction<SignResponse> Sign(Expression<Func<bodyfileSourceInput>> bodyfileSource, Expression<Func<string>> bodyfileName, Expression<Func<string>> bodyfile = null, Expression<Func<string>> bodyfileUrl = null, Expression<Func<string>> bodysigners = null, Expression<Func<string>> bodysignersEmails = null, Expression<Func<string>> bodysignsPositions = null, Expression<Func<bodysignTypeInput>> bodysignType = null, Expression<Func<string>> bodyexpirationDays = null, Expression<Func<bodysignerRemindersInput>> bodysignerReminders = null, Expression<Func<string>> bodysignerReminderDaysCycle = null, Expression<Func<string>> bodypages = null, Expression<Func<string>> bodysize = null)
        {
            var apiCallPath = "/sign";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["file_source"] = CSharpExpressionConverter.Convert(bodyfileSource);
            bodypropCount++;
            body["file_name"] = CSharpExpressionConverter.ConvertToken(bodyfileName);
            if (bodyfile != null)
            {
                body["file"] = CSharpExpressionConverter.ConvertToken(bodyfile);
                bodypropCount++;
            }

            if (bodyfileUrl != null)
            {
                body["file_url"] = CSharpExpressionConverter.ConvertToken(bodyfileUrl);
                bodypropCount++;
            }

            if (bodysigners != null)
            {
                body["signers"] = CSharpExpressionConverter.ConvertToken(bodysigners);
                bodypropCount++;
            }

            if (bodysignersEmails != null)
            {
                body["signers_emails"] = CSharpExpressionConverter.ConvertToken(bodysignersEmails);
                bodypropCount++;
            }

            if (bodysignsPositions != null)
            {
                body["signs_positions"] = CSharpExpressionConverter.ConvertToken(bodysignsPositions);
                bodypropCount++;
            }

            if (bodysignType != null)
            {
                body["sign_type"] = CSharpExpressionConverter.Convert(bodysignType);
                bodypropCount++;
            }

            if (bodyexpirationDays != null)
            {
                body["expiration_days"] = CSharpExpressionConverter.ConvertToken(bodyexpirationDays);
                bodypropCount++;
            }

            if (bodysignerReminders != null)
            {
                body["signer_reminders"] = CSharpExpressionConverter.Convert(bodysignerReminders);
                bodypropCount++;
            }

            if (bodysignerReminderDaysCycle != null)
            {
                body["signer_reminder_days_cycle"] = CSharpExpressionConverter.ConvertToken(bodysignerReminderDaysCycle);
                bodypropCount++;
            }

            if (bodypages != null)
            {
                body["pages"] = CSharpExpressionConverter.ConvertToken(bodypages);
                bodypropCount++;
            }

            if (bodysize != null)
            {
                body["size"] = CSharpExpressionConverter.ConvertToken(bodysize);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SignResponse>(callPayload);
        }
    }

    public class IlovesignTriggers([ConnectionName] string connectionId)
    {
    }

    public class SignResponse
    {
        [JsonProperty("task_id")]
        public string TaskId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public enum bodyfileSourceInput
    {
        [EnumMember(Value = "binary")]
        Binary,
        [EnumMember(Value = "url")]
        Url
    }

    public enum bodysignTypeInput
    {
        [EnumMember(Value = "signer")]
        Signer,
        [EnumMember(Value = "validator")]
        Validator,
        [EnumMember(Value = "viewer")]
        Viewer
    }

    public enum bodysignerRemindersInput
    {
        [EnumMember(Value = "true")]
        True,
        [EnumMember(Value = "false")]
        False
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Ilovesign;

    public partial class WorkflowManagedActions
    {
        public IlovesignActions Ilovesign(string connectionId) => new IlovesignActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public IlovesignTriggers Ilovesign(string connectionId) => new IlovesignTriggers(connectionId);
    }
}