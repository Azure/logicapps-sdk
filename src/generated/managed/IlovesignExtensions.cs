//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ilovesign
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class IlovesignActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovesign")]
        [WorkflowExpressionFactory(nameof(__BuildSign))]
        public IBodyWorkflowAction<SignResponse> Sign([WorkflowExpression] Func<bodyfileSourceInput> bodyfileSource, [WorkflowExpression] Func<string> bodyfileName, [WorkflowExpression] Func<string> bodyfile = null, [WorkflowExpression] Func<string> bodyfileUrl = null, [WorkflowExpression] Func<string> bodysigners = null, [WorkflowExpression] Func<string> bodysignersEmails = null, [WorkflowExpression] Func<string> bodysignsPositions = null, [WorkflowExpression] Func<bodysignTypeInput> bodysignType = null, [WorkflowExpression] Func<string> bodyexpirationDays = null, [WorkflowExpression] Func<bodysignerRemindersInput> bodysignerReminders = null, [WorkflowExpression] Func<string> bodysignerReminderDaysCycle = null, [WorkflowExpression] Func<string> bodypages = null, [WorkflowExpression] Func<string> bodysize = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SignResponse> __BuildSign(WorkflowValue<bodyfileSourceInput> bodyfileSource, WorkflowValue<string> bodyfileName, WorkflowValue<string> bodyfile = null, WorkflowValue<string> bodyfileUrl = null, WorkflowValue<string> bodysigners = null, WorkflowValue<string> bodysignersEmails = null, WorkflowValue<string> bodysignsPositions = null, WorkflowValue<bodysignTypeInput> bodysignType = null, WorkflowValue<string> bodyexpirationDays = null, WorkflowValue<bodysignerRemindersInput> bodysignerReminders = null, WorkflowValue<string> bodysignerReminderDaysCycle = null, WorkflowValue<string> bodypages = null, WorkflowValue<string> bodysize = null)
        {
            WorkflowValue.Validate(bodyfileSource, nameof(bodyfileSource), required: true);
            WorkflowValue.Validate(bodyfileName, nameof(bodyfileName), required: true);
            WorkflowValue.Validate(bodyfile, nameof(bodyfile), required: false);
            WorkflowValue.Validate(bodyfileUrl, nameof(bodyfileUrl), required: false);
            WorkflowValue.Validate(bodysigners, nameof(bodysigners), required: false);
            WorkflowValue.Validate(bodysignersEmails, nameof(bodysignersEmails), required: false);
            WorkflowValue.Validate(bodysignsPositions, nameof(bodysignsPositions), required: false);
            WorkflowValue.Validate(bodysignType, nameof(bodysignType), required: false);
            WorkflowValue.Validate(bodyexpirationDays, nameof(bodyexpirationDays), required: false);
            WorkflowValue.Validate(bodysignerReminders, nameof(bodysignerReminders), required: false);
            WorkflowValue.Validate(bodysignerReminderDaysCycle, nameof(bodysignerReminderDaysCycle), required: false);
            WorkflowValue.Validate(bodypages, nameof(bodypages), required: false);
            WorkflowValue.Validate(bodysize, nameof(bodysize), required: false);
            return new DeferredBodyAction<SignResponse>(() =>
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
            });
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
