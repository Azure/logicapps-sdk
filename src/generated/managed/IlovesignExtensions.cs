//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ilovesign
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class IlovesignActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovesign")]
        public IBodyWorkflowAction<SignResponse, ApiConnectionActionConfiguration> Sign(Expression<Func<bodyfileSourceInput>> bodyfileSource, Expression<Func<string>> bodyfileName, Expression<Func<string>> bodyfile = null, Expression<Func<string>> bodyfileUrl = null, Expression<Func<string>> bodysigners = null, Expression<Func<string>> bodysignersEmails = null, Expression<Func<string>> bodysignsPositions = null, Expression<Func<bodysignTypeInput>> bodysignType = null, Expression<Func<string>> bodyexpirationDays = null, Expression<Func<bodysignerRemindersInput>> bodysignerReminders = null, Expression<Func<string>> bodysignerReminderDaysCycle = null, Expression<Func<string>> bodypages = null, Expression<Func<string>> bodysize = null)
        {
            var __workflow_bodyfileSource = WorkflowExpression.Compile(bodyfileSource, nameof(bodyfileSource), required: true);
            var __workflow_bodyfileName = WorkflowExpression.Compile(bodyfileName, nameof(bodyfileName), required: true);
            var __workflow_bodyfile = WorkflowExpression.Compile(bodyfile, nameof(bodyfile), required: false);
            var __workflow_bodyfileUrl = WorkflowExpression.Compile(bodyfileUrl, nameof(bodyfileUrl), required: false);
            var __workflow_bodysigners = WorkflowExpression.Compile(bodysigners, nameof(bodysigners), required: false);
            var __workflow_bodysignersEmails = WorkflowExpression.Compile(bodysignersEmails, nameof(bodysignersEmails), required: false);
            var __workflow_bodysignsPositions = WorkflowExpression.Compile(bodysignsPositions, nameof(bodysignsPositions), required: false);
            var __workflow_bodysignType = WorkflowExpression.Compile(bodysignType, nameof(bodysignType), required: false);
            var __workflow_bodyexpirationDays = WorkflowExpression.Compile(bodyexpirationDays, nameof(bodyexpirationDays), required: false);
            var __workflow_bodysignerReminders = WorkflowExpression.Compile(bodysignerReminders, nameof(bodysignerReminders), required: false);
            var __workflow_bodysignerReminderDaysCycle = WorkflowExpression.Compile(bodysignerReminderDaysCycle, nameof(bodysignerReminderDaysCycle), required: false);
            var __workflow_bodypages = WorkflowExpression.Compile(bodypages, nameof(bodypages), required: false);
            var __workflow_bodysize = WorkflowExpression.Compile(bodysize, nameof(bodysize), required: false);
            return new DeferredBodyAction<SignResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/sign";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["file_source"] = ExpressionConverter.ConvertO(__workflow_bodyfileSource);
                bodypropCount++;
                body["file_name"] = ExpressionConverter.ConvertO(__workflow_bodyfileName);
                if (__workflow_bodyfile != null)
                {
                    body["file"] = ExpressionConverter.ConvertO(__workflow_bodyfile);
                    bodypropCount++;
                }

                if (__workflow_bodyfileUrl != null)
                {
                    body["file_url"] = ExpressionConverter.ConvertO(__workflow_bodyfileUrl);
                    bodypropCount++;
                }

                if (__workflow_bodysigners != null)
                {
                    body["signers"] = ExpressionConverter.ConvertO(__workflow_bodysigners);
                    bodypropCount++;
                }

                if (__workflow_bodysignersEmails != null)
                {
                    body["signers_emails"] = ExpressionConverter.ConvertO(__workflow_bodysignersEmails);
                    bodypropCount++;
                }

                if (__workflow_bodysignsPositions != null)
                {
                    body["signs_positions"] = ExpressionConverter.ConvertO(__workflow_bodysignsPositions);
                    bodypropCount++;
                }

                if (__workflow_bodysignType != null)
                {
                    body["sign_type"] = ExpressionConverter.ConvertO(__workflow_bodysignType);
                    bodypropCount++;
                }

                if (__workflow_bodyexpirationDays != null)
                {
                    body["expiration_days"] = ExpressionConverter.ConvertO(__workflow_bodyexpirationDays);
                    bodypropCount++;
                }

                if (__workflow_bodysignerReminders != null)
                {
                    body["signer_reminders"] = ExpressionConverter.ConvertO(__workflow_bodysignerReminders);
                    bodypropCount++;
                }

                if (__workflow_bodysignerReminderDaysCycle != null)
                {
                    body["signer_reminder_days_cycle"] = ExpressionConverter.ConvertO(__workflow_bodysignerReminderDaysCycle);
                    bodypropCount++;
                }

                if (__workflow_bodypages != null)
                {
                    body["pages"] = ExpressionConverter.ConvertO(__workflow_bodypages);
                    bodypropCount++;
                }

                if (__workflow_bodysize != null)
                {
                    body["size"] = ExpressionConverter.ConvertO(__workflow_bodysize);
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
