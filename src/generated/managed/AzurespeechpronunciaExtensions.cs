//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Azurespeechpronuncia
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AzurespeechpronunciaActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurespeechpronuncia")]
        public IWorkflowAction SpeechRecognitionConversationCognitiveServices([WorkflowExpression] Func<string> referenceText, [WorkflowExpression] Func<string> language, [WorkflowExpression] Func<string> audioContent = null, [WorkflowExpression] Func<gradingSystemInput> gradingSystem = null, [WorkflowExpression] Func<granularityInput> granularity = null, [WorkflowExpression] Func<dimensionInput> dimension = null, [WorkflowExpression] Func<bool> enableMiscue = null, [WorkflowExpression] Func<string> scenarioId = null)
        {
            var apiCallPath = "/conversation/cognitiveservices/v1";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["language"] = ExpressionConverter.Convert(language);
            callPayload.Headers["ReferenceText"] = ExpressionConverter.Convert(referenceText);
            if (gradingSystem != null)
                callPayload.Headers["GradingSystem"] = ExpressionConverter.Convert(gradingSystem);
            if (granularity != null)
                callPayload.Headers["Granularity"] = ExpressionConverter.Convert(granularity);
            if (dimension != null)
                callPayload.Headers["Dimension"] = ExpressionConverter.Convert(dimension);
            if (enableMiscue != null)
                callPayload.Headers["EnableMiscue"] = ExpressionConverter.Convert(enableMiscue);
            if (scenarioId != null)
                callPayload.Headers["ScenarioId"] = ExpressionConverter.Convert(scenarioId);
            callPayload.Body = ExpressionConverter.ConvertO(audioContent);
            return new ApiConnectionAction(callPayload);
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