//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ilovepdfsign
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class IlovepdfsignActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfsign")]
        public IBodyWorkflowAction<SignResponse> Sign(Expression<Func<bodyfileSourceInput>> bodyfileSource, Expression<Func<string>> bodyfileName, Expression<Func<string>> bodyfile = null, Expression<Func<string>> bodyfileUrl = null, Expression<Func<string>> bodysigners = null, Expression<Func<string>> bodysignersEmails = null, Expression<Func<string>> bodysignsPositions = null, Expression<Func<bodysignTypeInput>> bodysignType = null, Expression<Func<string>> bodyexpirationDays = null, Expression<Func<bodysignerRemindersInput>> bodysignerReminders = null, Expression<Func<string>> bodysignerReminderDaysCycle = null, Expression<Func<string>> bodypages = null, Expression<Func<string>> bodysize = null)
        {
            var apiCallPath = "/sign";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["file_source"] = ExpressionConverter.ConvertO(bodyfileSource);
            bodypropCount++;
            body["file_name"] = ExpressionConverter.ConvertO(bodyfileName);
            if (bodyfile != null)
            {
                body["file"] = ExpressionConverter.ConvertO(bodyfile);
                bodypropCount++;
            }

            if (bodyfileUrl != null)
            {
                body["file_url"] = ExpressionConverter.ConvertO(bodyfileUrl);
                bodypropCount++;
            }

            if (bodysigners != null)
            {
                body["signers"] = ExpressionConverter.ConvertO(bodysigners);
                bodypropCount++;
            }

            if (bodysignersEmails != null)
            {
                body["signers_emails"] = ExpressionConverter.ConvertO(bodysignersEmails);
                bodypropCount++;
            }

            if (bodysignsPositions != null)
            {
                body["signs_positions"] = ExpressionConverter.ConvertO(bodysignsPositions);
                bodypropCount++;
            }

            if (bodysignType != null)
            {
                body["sign_type"] = ExpressionConverter.ConvertO(bodysignType);
                bodypropCount++;
            }

            if (bodyexpirationDays != null)
            {
                body["expiration_days"] = ExpressionConverter.ConvertO(bodyexpirationDays);
                bodypropCount++;
            }

            if (bodysignerReminders != null)
            {
                body["signer_reminders"] = ExpressionConverter.ConvertO(bodysignerReminders);
                bodypropCount++;
            }

            if (bodysignerReminderDaysCycle != null)
            {
                body["signer_reminder_days_cycle"] = ExpressionConverter.ConvertO(bodysignerReminderDaysCycle);
                bodypropCount++;
            }

            if (bodypages != null)
            {
                body["pages"] = ExpressionConverter.ConvertO(bodypages);
                bodypropCount++;
            }

            if (bodysize != null)
            {
                body["size"] = ExpressionConverter.ConvertO(bodysize);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SignResponse>(callPayload);
        }
    }

    public class IlovepdfsignTriggers([ConnectionName] string connectionId)
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

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Ilovepdfsign;

    public partial class WorkflowManagedActions
    {
        public IlovepdfsignActions Ilovepdfsign(string connectionId) => new IlovepdfsignActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public IlovepdfsignTriggers Ilovepdfsign(string connectionId) => new IlovepdfsignTriggers(connectionId);
    }
}