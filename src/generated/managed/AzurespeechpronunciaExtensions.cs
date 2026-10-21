//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Azurespeechpronuncia
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AzurespeechpronunciaActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurespeechpronuncia")]
        public IWorkflowAction SpeechRecognitionConversationCognitiveServices(Expression<Func<string>> referenceText, Expression<Func<string>> language, Expression<Func<string>> audioContent = null, Expression<Func<gradingSystemInput>> gradingSystem = null, Expression<Func<granularityInput>> granularity = null, Expression<Func<dimensionInput>> dimension = null, Expression<Func<bool>> enableMiscue = null, Expression<Func<string>> scenarioId = null)
        {
            var __workflow_referenceText = WorkflowExpression.Compile(referenceText, nameof(referenceText), required: true);
            var __workflow_language = WorkflowExpression.Compile(language, nameof(language), required: true);
            var __workflow_audioContent = WorkflowExpression.Compile(audioContent, nameof(audioContent), required: false);
            var __workflow_gradingSystem = WorkflowExpression.Compile(gradingSystem, nameof(gradingSystem), required: false);
            var __workflow_granularity = WorkflowExpression.Compile(granularity, nameof(granularity), required: false);
            var __workflow_dimension = WorkflowExpression.Compile(dimension, nameof(dimension), required: false);
            var __workflow_enableMiscue = WorkflowExpression.Compile(enableMiscue, nameof(enableMiscue), required: false);
            var __workflow_scenarioId = WorkflowExpression.Compile(scenarioId, nameof(scenarioId), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/conversation/cognitiveservices/v1";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["language"] = ExpressionConverter.Convert(__workflow_language);
                callPayload.Headers["ReferenceText"] = ExpressionConverter.Convert(__workflow_referenceText);
                if (__workflow_gradingSystem != null)
                    callPayload.Headers["GradingSystem"] = ExpressionConverter.Convert(__workflow_gradingSystem);
                if (__workflow_granularity != null)
                    callPayload.Headers["Granularity"] = ExpressionConverter.Convert(__workflow_granularity);
                if (__workflow_dimension != null)
                    callPayload.Headers["Dimension"] = ExpressionConverter.Convert(__workflow_dimension);
                if (__workflow_enableMiscue != null)
                    callPayload.Headers["EnableMiscue"] = ExpressionConverter.Convert(__workflow_enableMiscue);
                if (__workflow_scenarioId != null)
                    callPayload.Headers["ScenarioId"] = ExpressionConverter.Convert(__workflow_scenarioId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_audioContent);
                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }
    }

    public class AzurespeechpronunciaTriggers([ConnectionName] string connectionId)
    {
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum gradingSystemInput
    {
        FivePoint,
        HundredMark
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum granularityInput
    {
        Phoneme,
        Word,
        FullText
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum dimensionInput
    {
        Basic,
        Comprehensive
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Azurespeechpronuncia;

    public partial class WorkflowManagedActions
    {
        public AzurespeechpronunciaActions Azurespeechpronuncia(string connectionId) => new AzurespeechpronunciaActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AzurespeechpronunciaTriggers Azurespeechpronuncia(string connectionId) => new AzurespeechpronunciaTriggers(connectionId);
    }
}
