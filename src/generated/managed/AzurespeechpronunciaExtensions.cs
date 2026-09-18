//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Azurespeechpronuncia
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AzurespeechpronunciaActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurespeechpronuncia")]
        public IWorkflowAction SpeechRecognitionConversationCognitiveServices([WorkflowExpression] Func<string> referenceText, [WorkflowExpression] Func<string> language, [WorkflowExpression] Func<string> audioContent = null, [WorkflowExpression] Func<gradingSystemInput> gradingSystem = null, [WorkflowExpression] Func<granularityInput> granularity = null, [WorkflowExpression] Func<dimensionInput> dimension = null, [WorkflowExpression] Func<bool> enableMiscue = null, [WorkflowExpression] Func<string> scenarioId = null)
        {
            SourceExpression.Validate(referenceText, nameof(referenceText), required: true);
            SourceExpression.Validate(language, nameof(language), required: true);
            SourceExpression.Validate(audioContent, nameof(audioContent), required: false);
            SourceExpression.Validate(gradingSystem, nameof(gradingSystem), required: false);
            SourceExpression.Validate(granularity, nameof(granularity), required: false);
            SourceExpression.Validate(dimension, nameof(dimension), required: false);
            SourceExpression.Validate(enableMiscue, nameof(enableMiscue), required: false);
            SourceExpression.Validate(scenarioId, nameof(scenarioId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/conversation/cognitiveservices/v1";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["language"] = SourceExpressionConverter.ConvertO(language);
                callPayload.Headers["ReferenceText"] = SourceExpressionConverter.ConvertO(referenceText);
                if (gradingSystem != null)
                    callPayload.Headers["GradingSystem"] = SourceExpressionConverter.Convert(gradingSystem);
                if (granularity != null)
                    callPayload.Headers["Granularity"] = SourceExpressionConverter.Convert(granularity);
                if (dimension != null)
                    callPayload.Headers["Dimension"] = SourceExpressionConverter.Convert(dimension);
                if (enableMiscue != null)
                    callPayload.Headers["EnableMiscue"] = SourceExpressionConverter.ConvertO(enableMiscue);
                if (scenarioId != null)
                    callPayload.Headers["ScenarioId"] = SourceExpressionConverter.ConvertO(scenarioId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(audioContent);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }
    }

    public class AzurespeechpronunciaTriggers([ConnectionName] string connectionId)
    {
    }

    public enum gradingSystemInput
    {
        FivePoint,
        HundredMark
    }

    public enum granularityInput
    {
        Phoneme,
        Word,
        FullText
    }

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