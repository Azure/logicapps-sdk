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
        public IBodyWorkflowAction<SignResponse> Sign([WorkflowExpression] Func<bodyfileSourceInput> bodyfileSource, [WorkflowExpression] Func<string> bodyfileName, [WorkflowExpression] Func<string> bodyfile = null, [WorkflowExpression] Func<string> bodyfileUrl = null, [WorkflowExpression] Func<string> bodysigners = null, [WorkflowExpression] Func<string> bodysignersEmails = null, [WorkflowExpression] Func<string> bodysignsPositions = null, [WorkflowExpression] Func<bodysignTypeInput> bodysignType = null, [WorkflowExpression] Func<string> bodyexpirationDays = null, [WorkflowExpression] Func<bodysignerRemindersInput> bodysignerReminders = null, [WorkflowExpression] Func<string> bodysignerReminderDaysCycle = null, [WorkflowExpression] Func<string> bodypages = null, [WorkflowExpression] Func<string> bodysize = null)
        {
            SourceExpression.Validate(bodyfileSource, nameof(bodyfileSource), required: true);
            SourceExpression.Validate(bodyfileName, nameof(bodyfileName), required: true);
            SourceExpression.Validate(bodyfile, nameof(bodyfile), required: false);
            SourceExpression.Validate(bodyfileUrl, nameof(bodyfileUrl), required: false);
            SourceExpression.Validate(bodysigners, nameof(bodysigners), required: false);
            SourceExpression.Validate(bodysignersEmails, nameof(bodysignersEmails), required: false);
            SourceExpression.Validate(bodysignsPositions, nameof(bodysignsPositions), required: false);
            SourceExpression.Validate(bodysignType, nameof(bodysignType), required: false);
            SourceExpression.Validate(bodyexpirationDays, nameof(bodyexpirationDays), required: false);
            SourceExpression.Validate(bodysignerReminders, nameof(bodysignerReminders), required: false);
            SourceExpression.Validate(bodysignerReminderDaysCycle, nameof(bodysignerReminderDaysCycle), required: false);
            SourceExpression.Validate(bodypages, nameof(bodypages), required: false);
            SourceExpression.Validate(bodysize, nameof(bodysize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/sign";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["file_source"] = SourceExpressionConverter.Convert(bodyfileSource);
                bodypropCount++;
                body["file_name"] = SourceExpressionConverter.ConvertToken(bodyfileName);
                if (bodyfile != null)
                {
                    body["file"] = SourceExpressionConverter.ConvertToken(bodyfile);
                    bodypropCount++;
                }

                if (bodyfileUrl != null)
                {
                    body["file_url"] = SourceExpressionConverter.ConvertToken(bodyfileUrl);
                    bodypropCount++;
                }

                if (bodysigners != null)
                {
                    body["signers"] = SourceExpressionConverter.ConvertToken(bodysigners);
                    bodypropCount++;
                }

                if (bodysignersEmails != null)
                {
                    body["signers_emails"] = SourceExpressionConverter.ConvertToken(bodysignersEmails);
                    bodypropCount++;
                }

                if (bodysignsPositions != null)
                {
                    body["signs_positions"] = SourceExpressionConverter.ConvertToken(bodysignsPositions);
                    bodypropCount++;
                }

                if (bodysignType != null)
                {
                    body["sign_type"] = SourceExpressionConverter.Convert(bodysignType);
                    bodypropCount++;
                }

                if (bodyexpirationDays != null)
                {
                    body["expiration_days"] = SourceExpressionConverter.ConvertToken(bodyexpirationDays);
                    bodypropCount++;
                }

                if (bodysignerReminders != null)
                {
                    body["signer_reminders"] = SourceExpressionConverter.Convert(bodysignerReminders);
                    bodypropCount++;
                }

                if (bodysignerReminderDaysCycle != null)
                {
                    body["signer_reminder_days_cycle"] = SourceExpressionConverter.ConvertToken(bodysignerReminderDaysCycle);
                    bodypropCount++;
                }

                if (bodypages != null)
                {
                    body["pages"] = SourceExpressionConverter.ConvertToken(bodypages);
                    bodypropCount++;
                }

                if (bodysize != null)
                {
                    body["size"] = SourceExpressionConverter.ConvertToken(bodysize);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SignResponse>(BuildSourceInput);
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