//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ilovepdfsign
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class IlovepdfsignActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfsign")]
        [WorkflowExpressionFactory(nameof(__BuildSign))]
        public IBodyWorkflowAction<SignResponse> Sign([WorkflowExpression] Func<bodyfileSourceInput> bodyfileSource, [WorkflowExpression] Func<string> bodyfileName, [WorkflowExpression] Func<string> bodyfile = null, [WorkflowExpression] Func<string> bodyfileUrl = null, [WorkflowExpression] Func<string> bodysigners = null, [WorkflowExpression] Func<string> bodysignersEmails = null, [WorkflowExpression] Func<string> bodysignsPositions = null, [WorkflowExpression] Func<bodysignTypeInput> bodysignType = null, [WorkflowExpression] Func<string> bodyexpirationDays = null, [WorkflowExpression] Func<bodysignerRemindersInput> bodysignerReminders = null, [WorkflowExpression] Func<string> bodysignerReminderDaysCycle = null, [WorkflowExpression] Func<string> bodypages = null, [WorkflowExpression] Func<string> bodysize = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfsign")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SignResponse> __BuildSign(WorkflowExpression<bodyfileSourceInput> bodyfileSource, WorkflowExpression<string> bodyfileName, WorkflowExpression<string> bodyfile = null, WorkflowExpression<string> bodyfileUrl = null, WorkflowExpression<string> bodysigners = null, WorkflowExpression<string> bodysignersEmails = null, WorkflowExpression<string> bodysignsPositions = null, WorkflowExpression<bodysignTypeInput> bodysignType = null, WorkflowExpression<string> bodyexpirationDays = null, WorkflowExpression<bodysignerRemindersInput> bodysignerReminders = null, WorkflowExpression<string> bodysignerReminderDaysCycle = null, WorkflowExpression<string> bodypages = null, WorkflowExpression<string> bodysize = null)
        {
            WorkflowExpression.Validate(bodyfileSource, nameof(bodyfileSource), required: true);
            WorkflowExpression.Validate(bodyfileName, nameof(bodyfileName), required: true);
            WorkflowExpression.Validate(bodyfile, nameof(bodyfile), required: false);
            WorkflowExpression.Validate(bodyfileUrl, nameof(bodyfileUrl), required: false);
            WorkflowExpression.Validate(bodysigners, nameof(bodysigners), required: false);
            WorkflowExpression.Validate(bodysignersEmails, nameof(bodysignersEmails), required: false);
            WorkflowExpression.Validate(bodysignsPositions, nameof(bodysignsPositions), required: false);
            WorkflowExpression.Validate(bodysignType, nameof(bodysignType), required: false);
            WorkflowExpression.Validate(bodyexpirationDays, nameof(bodyexpirationDays), required: false);
            WorkflowExpression.Validate(bodysignerReminders, nameof(bodysignerReminders), required: false);
            WorkflowExpression.Validate(bodysignerReminderDaysCycle, nameof(bodysignerReminderDaysCycle), required: false);
            WorkflowExpression.Validate(bodypages, nameof(bodypages), required: false);
            WorkflowExpression.Validate(bodysize, nameof(bodysize), required: false);
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyfileSourceInput
    {
        [EnumMember(Value = "binary")]
        Binary,
        [EnumMember(Value = "url")]
        Url
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodysignTypeInput
    {
        [EnumMember(Value = "signer")]
        Signer,
        [EnumMember(Value = "validator")]
        Validator,
        [EnumMember(Value = "viewer")]
        Viewer
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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