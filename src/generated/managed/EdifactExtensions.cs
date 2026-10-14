//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Edifact
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class EdifactActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "edifact")]
        public IBodyWorkflowAction<UpdateControlNumberResult[]> AddOrUpdateControlNumbers(Expression<Func<ReplicableControlNumberContent[]>> controlNumberContents = null)
        {
            var __workflow_controlNumberContents = controlNumberContents == null ? null : WorkflowExpression.Compile(controlNumberContents);
            WorkflowExpression.Validate(__workflow_controlNumberContents, nameof(controlNumberContents), required: false);
            return new DeferredBodyAction<UpdateControlNumberResult[]>(() =>
            {
                var apiCallPath = "/controlnumbers";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_controlNumberContents);
                return new ApiConnectionAction<UpdateControlNumberResult[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "edifact")]
        public IBodyWorkflowAction<EdiDecodeResponseEdifactDecodeResponseEdifactAcknowledgement> Decode(Expression<Func<int>> componentSeparator = null, Expression<Func<int>> dataElementSeparator = null, Expression<Func<int>> releaseIndicator = null, Expression<Func<int>> repetitionSeparator = null, Expression<Func<int>> segmentTerminator = null, Expression<Func<segmentTerminatorSuffixInput>> segmentTerminatorSuffix = null, Expression<Func<decimalIndicatorInput>> decimalIndicator = null, Expression<Func<payloadCharacterSetInput>> payloadCharacterSet = null, Expression<Func<bool>> preserveInterchange = null, Expression<Func<bool>> suspendInterchangeOnError = null, Expression<Func<string>> body = null)
        {
            var __workflow_componentSeparator = componentSeparator == null ? null : WorkflowExpression.Compile(componentSeparator);
            WorkflowExpression.Validate(__workflow_componentSeparator, nameof(componentSeparator), required: false);
            var __workflow_dataElementSeparator = dataElementSeparator == null ? null : WorkflowExpression.Compile(dataElementSeparator);
            WorkflowExpression.Validate(__workflow_dataElementSeparator, nameof(dataElementSeparator), required: false);
            var __workflow_releaseIndicator = releaseIndicator == null ? null : WorkflowExpression.Compile(releaseIndicator);
            WorkflowExpression.Validate(__workflow_releaseIndicator, nameof(releaseIndicator), required: false);
            var __workflow_repetitionSeparator = repetitionSeparator == null ? null : WorkflowExpression.Compile(repetitionSeparator);
            WorkflowExpression.Validate(__workflow_repetitionSeparator, nameof(repetitionSeparator), required: false);
            var __workflow_segmentTerminator = segmentTerminator == null ? null : WorkflowExpression.Compile(segmentTerminator);
            WorkflowExpression.Validate(__workflow_segmentTerminator, nameof(segmentTerminator), required: false);
            var __workflow_segmentTerminatorSuffix = segmentTerminatorSuffix == null ? null : WorkflowExpression.Compile(segmentTerminatorSuffix);
            WorkflowExpression.Validate(__workflow_segmentTerminatorSuffix, nameof(segmentTerminatorSuffix), required: false);
            var __workflow_decimalIndicator = decimalIndicator == null ? null : WorkflowExpression.Compile(decimalIndicator);
            WorkflowExpression.Validate(__workflow_decimalIndicator, nameof(decimalIndicator), required: false);
            var __workflow_payloadCharacterSet = payloadCharacterSet == null ? null : WorkflowExpression.Compile(payloadCharacterSet);
            WorkflowExpression.Validate(__workflow_payloadCharacterSet, nameof(payloadCharacterSet), required: false);
            var __workflow_preserveInterchange = preserveInterchange == null ? null : WorkflowExpression.Compile(preserveInterchange);
            WorkflowExpression.Validate(__workflow_preserveInterchange, nameof(preserveInterchange), required: false);
            var __workflow_suspendInterchangeOnError = suspendInterchangeOnError == null ? null : WorkflowExpression.Compile(suspendInterchangeOnError);
            WorkflowExpression.Validate(__workflow_suspendInterchangeOnError, nameof(suspendInterchangeOnError), required: false);
            var __workflow_body = body == null ? null : WorkflowExpression.Compile(body);
            WorkflowExpression.Validate(__workflow_body, nameof(body), required: false);
            return new DeferredBodyAction<EdiDecodeResponseEdifactDecodeResponseEdifactAcknowledgement>(() =>
            {
                var apiCallPath = "/decode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["componentSeparator"] = Convert.ToString(58);
                if (__workflow_componentSeparator != null)
                    callPayload.Queries["componentSeparator"] = ExpressionConverter.Convert(__workflow_componentSeparator);
                callPayload.Queries["dataElementSeparator"] = Convert.ToString(43);
                if (__workflow_dataElementSeparator != null)
                    callPayload.Queries["dataElementSeparator"] = ExpressionConverter.Convert(__workflow_dataElementSeparator);
                callPayload.Queries["releaseIndicator"] = Convert.ToString(63);
                if (__workflow_releaseIndicator != null)
                    callPayload.Queries["releaseIndicator"] = ExpressionConverter.Convert(__workflow_releaseIndicator);
                callPayload.Queries["repetitionSeparator"] = Convert.ToString(42);
                if (__workflow_repetitionSeparator != null)
                    callPayload.Queries["repetitionSeparator"] = ExpressionConverter.Convert(__workflow_repetitionSeparator);
                callPayload.Queries["segmentTerminator"] = Convert.ToString(39);
                if (__workflow_segmentTerminator != null)
                    callPayload.Queries["segmentTerminator"] = ExpressionConverter.Convert(__workflow_segmentTerminator);
                callPayload.Queries["segmentTerminatorSuffix"] = Convert.ToString("None");
                if (__workflow_segmentTerminatorSuffix != null)
                    callPayload.Queries["segmentTerminatorSuffix"] = ExpressionConverter.Convert(__workflow_segmentTerminatorSuffix);
                callPayload.Queries["decimalIndicator"] = Convert.ToString("Comma");
                if (__workflow_decimalIndicator != null)
                    callPayload.Queries["decimalIndicator"] = ExpressionConverter.Convert(__workflow_decimalIndicator);
                callPayload.Queries["payloadCharacterSet"] = Convert.ToString("Legacy");
                if (__workflow_payloadCharacterSet != null)
                    callPayload.Queries["payloadCharacterSet"] = ExpressionConverter.Convert(__workflow_payloadCharacterSet);
                if (__workflow_preserveInterchange != null)
                    callPayload.Queries["preserveInterchange"] = ExpressionConverter.Convert(__workflow_preserveInterchange);
                if (__workflow_suspendInterchangeOnError != null)
                    callPayload.Queries["suspendInterchangeOnError"] = ExpressionConverter.Convert(__workflow_suspendInterchangeOnError);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<EdiDecodeResponseEdifactDecodeResponseEdifactAcknowledgement>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "edifact")]
        public IBodyWorkflowAction<EdiAgreementProperties> ResolveAgreement(Expression<Func<int>> componentSeparator = null, Expression<Func<int>> dataElementSeparator = null, Expression<Func<int>> releaseIndicator = null, Expression<Func<int>> repetitionSeparator = null, Expression<Func<int>> segmentTerminator = null, Expression<Func<segmentTerminatorSuffixInput>> segmentTerminatorSuffix = null, Expression<Func<decimalIndicatorInput>> decimalIndicator = null, Expression<Func<string>> body = null)
        {
            var __workflow_componentSeparator = componentSeparator == null ? null : WorkflowExpression.Compile(componentSeparator);
            WorkflowExpression.Validate(__workflow_componentSeparator, nameof(componentSeparator), required: false);
            var __workflow_dataElementSeparator = dataElementSeparator == null ? null : WorkflowExpression.Compile(dataElementSeparator);
            WorkflowExpression.Validate(__workflow_dataElementSeparator, nameof(dataElementSeparator), required: false);
            var __workflow_releaseIndicator = releaseIndicator == null ? null : WorkflowExpression.Compile(releaseIndicator);
            WorkflowExpression.Validate(__workflow_releaseIndicator, nameof(releaseIndicator), required: false);
            var __workflow_repetitionSeparator = repetitionSeparator == null ? null : WorkflowExpression.Compile(repetitionSeparator);
            WorkflowExpression.Validate(__workflow_repetitionSeparator, nameof(repetitionSeparator), required: false);
            var __workflow_segmentTerminator = segmentTerminator == null ? null : WorkflowExpression.Compile(segmentTerminator);
            WorkflowExpression.Validate(__workflow_segmentTerminator, nameof(segmentTerminator), required: false);
            var __workflow_segmentTerminatorSuffix = segmentTerminatorSuffix == null ? null : WorkflowExpression.Compile(segmentTerminatorSuffix);
            WorkflowExpression.Validate(__workflow_segmentTerminatorSuffix, nameof(segmentTerminatorSuffix), required: false);
            var __workflow_decimalIndicator = decimalIndicator == null ? null : WorkflowExpression.Compile(decimalIndicator);
            WorkflowExpression.Validate(__workflow_decimalIndicator, nameof(decimalIndicator), required: false);
            var __workflow_body = body == null ? null : WorkflowExpression.Compile(body);
            WorkflowExpression.Validate(__workflow_body, nameof(body), required: false);
            return new DeferredBodyAction<EdiAgreementProperties>(() =>
            {
                var apiCallPath = "/resolveAgreement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["componentSeparator"] = Convert.ToString(58);
                if (__workflow_componentSeparator != null)
                    callPayload.Queries["componentSeparator"] = ExpressionConverter.Convert(__workflow_componentSeparator);
                callPayload.Queries["dataElementSeparator"] = Convert.ToString(43);
                if (__workflow_dataElementSeparator != null)
                    callPayload.Queries["dataElementSeparator"] = ExpressionConverter.Convert(__workflow_dataElementSeparator);
                callPayload.Queries["releaseIndicator"] = Convert.ToString(63);
                if (__workflow_releaseIndicator != null)
                    callPayload.Queries["releaseIndicator"] = ExpressionConverter.Convert(__workflow_releaseIndicator);
                callPayload.Queries["repetitionSeparator"] = Convert.ToString(42);
                if (__workflow_repetitionSeparator != null)
                    callPayload.Queries["repetitionSeparator"] = ExpressionConverter.Convert(__workflow_repetitionSeparator);
                callPayload.Queries["segmentTerminator"] = Convert.ToString(39);
                if (__workflow_segmentTerminator != null)
                    callPayload.Queries["segmentTerminator"] = ExpressionConverter.Convert(__workflow_segmentTerminator);
                callPayload.Queries["segmentTerminatorSuffix"] = Convert.ToString("None");
                if (__workflow_segmentTerminatorSuffix != null)
                    callPayload.Queries["segmentTerminatorSuffix"] = ExpressionConverter.Convert(__workflow_segmentTerminatorSuffix);
                callPayload.Queries["decimalIndicator"] = Convert.ToString("Comma");
                if (__workflow_decimalIndicator != null)
                    callPayload.Queries["decimalIndicator"] = ExpressionConverter.Convert(__workflow_decimalIndicator);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<EdiAgreementProperties>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "edifact")]
        public IBodyWorkflowAction<EdifactEncodeResponse> EncodeResolveByAgreementName(Expression<Func<string>> agreementName, Expression<Func<int>> dataElementSeparator = null, Expression<Func<int>> releaseIndicator = null, Expression<Func<int>> componentSeparator = null, Expression<Func<int>> repetitionSeparator = null, Expression<Func<int>> segmentTerminator = null, Expression<Func<segmentTerminatorSuffixInput>> segmentTerminatorSuffix = null, Expression<Func<decimalIndicatorInput>> decimalIndicator = null, Expression<Func<string>> body = null)
        {
            var __workflow_agreementName = agreementName == null ? null : WorkflowExpression.Compile(agreementName);
            WorkflowExpression.Validate(__workflow_agreementName, nameof(agreementName), required: true);
            var __workflow_dataElementSeparator = dataElementSeparator == null ? null : WorkflowExpression.Compile(dataElementSeparator);
            WorkflowExpression.Validate(__workflow_dataElementSeparator, nameof(dataElementSeparator), required: false);
            var __workflow_releaseIndicator = releaseIndicator == null ? null : WorkflowExpression.Compile(releaseIndicator);
            WorkflowExpression.Validate(__workflow_releaseIndicator, nameof(releaseIndicator), required: false);
            var __workflow_componentSeparator = componentSeparator == null ? null : WorkflowExpression.Compile(componentSeparator);
            WorkflowExpression.Validate(__workflow_componentSeparator, nameof(componentSeparator), required: false);
            var __workflow_repetitionSeparator = repetitionSeparator == null ? null : WorkflowExpression.Compile(repetitionSeparator);
            WorkflowExpression.Validate(__workflow_repetitionSeparator, nameof(repetitionSeparator), required: false);
            var __workflow_segmentTerminator = segmentTerminator == null ? null : WorkflowExpression.Compile(segmentTerminator);
            WorkflowExpression.Validate(__workflow_segmentTerminator, nameof(segmentTerminator), required: false);
            var __workflow_segmentTerminatorSuffix = segmentTerminatorSuffix == null ? null : WorkflowExpression.Compile(segmentTerminatorSuffix);
            WorkflowExpression.Validate(__workflow_segmentTerminatorSuffix, nameof(segmentTerminatorSuffix), required: false);
            var __workflow_decimalIndicator = decimalIndicator == null ? null : WorkflowExpression.Compile(decimalIndicator);
            WorkflowExpression.Validate(__workflow_decimalIndicator, nameof(decimalIndicator), required: false);
            var __workflow_body = body == null ? null : WorkflowExpression.Compile(body);
            WorkflowExpression.Validate(__workflow_body, nameof(body), required: false);
            return new DeferredBodyAction<EdifactEncodeResponse>(() =>
            {
                var apiCallPath = "/encode/resolvebyname";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["agreementName"] = ExpressionConverter.Convert(__workflow_agreementName);
                if (__workflow_dataElementSeparator != null)
                    callPayload.Queries["dataElementSeparator"] = ExpressionConverter.Convert(__workflow_dataElementSeparator);
                if (__workflow_releaseIndicator != null)
                    callPayload.Queries["releaseIndicator"] = ExpressionConverter.Convert(__workflow_releaseIndicator);
                if (__workflow_componentSeparator != null)
                    callPayload.Queries["componentSeparator"] = ExpressionConverter.Convert(__workflow_componentSeparator);
                if (__workflow_repetitionSeparator != null)
                    callPayload.Queries["repetitionSeparator"] = ExpressionConverter.Convert(__workflow_repetitionSeparator);
                if (__workflow_segmentTerminator != null)
                    callPayload.Queries["segmentTerminator"] = ExpressionConverter.Convert(__workflow_segmentTerminator);
                if (__workflow_segmentTerminatorSuffix != null)
                    callPayload.Queries["segmentTerminatorSuffix"] = ExpressionConverter.Convert(__workflow_segmentTerminatorSuffix);
                if (__workflow_decimalIndicator != null)
                    callPayload.Queries["decimalIndicator"] = ExpressionConverter.Convert(__workflow_decimalIndicator);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<EdifactEncodeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "edifact")]
        public IBodyWorkflowAction<EdifactEncodeV2Response> EncodeV2ResolveByAgreementName(Expression<Func<string>> agreementName, Expression<Func<int>> dataElementSeparator = null, Expression<Func<int>> releaseIndicator = null, Expression<Func<int>> componentSeparator = null, Expression<Func<int>> repetitionSeparator = null, Expression<Func<int>> segmentTerminator = null, Expression<Func<segmentTerminatorSuffixInput>> segmentTerminatorSuffix = null, Expression<Func<decimalIndicatorInput>> decimalIndicator = null, Expression<Func<string>> body = null)
        {
            var __workflow_agreementName = agreementName == null ? null : WorkflowExpression.Compile(agreementName);
            WorkflowExpression.Validate(__workflow_agreementName, nameof(agreementName), required: true);
            var __workflow_dataElementSeparator = dataElementSeparator == null ? null : WorkflowExpression.Compile(dataElementSeparator);
            WorkflowExpression.Validate(__workflow_dataElementSeparator, nameof(dataElementSeparator), required: false);
            var __workflow_releaseIndicator = releaseIndicator == null ? null : WorkflowExpression.Compile(releaseIndicator);
            WorkflowExpression.Validate(__workflow_releaseIndicator, nameof(releaseIndicator), required: false);
            var __workflow_componentSeparator = componentSeparator == null ? null : WorkflowExpression.Compile(componentSeparator);
            WorkflowExpression.Validate(__workflow_componentSeparator, nameof(componentSeparator), required: false);
            var __workflow_repetitionSeparator = repetitionSeparator == null ? null : WorkflowExpression.Compile(repetitionSeparator);
            WorkflowExpression.Validate(__workflow_repetitionSeparator, nameof(repetitionSeparator), required: false);
            var __workflow_segmentTerminator = segmentTerminator == null ? null : WorkflowExpression.Compile(segmentTerminator);
            WorkflowExpression.Validate(__workflow_segmentTerminator, nameof(segmentTerminator), required: false);
            var __workflow_segmentTerminatorSuffix = segmentTerminatorSuffix == null ? null : WorkflowExpression.Compile(segmentTerminatorSuffix);
            WorkflowExpression.Validate(__workflow_segmentTerminatorSuffix, nameof(segmentTerminatorSuffix), required: false);
            var __workflow_decimalIndicator = decimalIndicator == null ? null : WorkflowExpression.Compile(decimalIndicator);
            WorkflowExpression.Validate(__workflow_decimalIndicator, nameof(decimalIndicator), required: false);
            var __workflow_body = body == null ? null : WorkflowExpression.Compile(body);
            WorkflowExpression.Validate(__workflow_body, nameof(body), required: false);
            return new DeferredBodyAction<EdifactEncodeV2Response>(() =>
            {
                var apiCallPath = "/EncodeV2/ResolveByName";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["agreementName"] = ExpressionConverter.Convert(__workflow_agreementName);
                if (__workflow_dataElementSeparator != null)
                    callPayload.Queries["dataElementSeparator"] = ExpressionConverter.Convert(__workflow_dataElementSeparator);
                if (__workflow_releaseIndicator != null)
                    callPayload.Queries["releaseIndicator"] = ExpressionConverter.Convert(__workflow_releaseIndicator);
                if (__workflow_componentSeparator != null)
                    callPayload.Queries["componentSeparator"] = ExpressionConverter.Convert(__workflow_componentSeparator);
                if (__workflow_repetitionSeparator != null)
                    callPayload.Queries["repetitionSeparator"] = ExpressionConverter.Convert(__workflow_repetitionSeparator);
                if (__workflow_segmentTerminator != null)
                    callPayload.Queries["segmentTerminator"] = ExpressionConverter.Convert(__workflow_segmentTerminator);
                if (__workflow_segmentTerminatorSuffix != null)
                    callPayload.Queries["segmentTerminatorSuffix"] = ExpressionConverter.Convert(__workflow_segmentTerminatorSuffix);
                if (__workflow_decimalIndicator != null)
                    callPayload.Queries["decimalIndicator"] = ExpressionConverter.Convert(__workflow_decimalIndicator);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<EdifactEncodeV2Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "edifact")]
        public IBodyWorkflowAction<EdifactBatchEncodeResponse> BatchEncodeResolveByAgreementName(Expression<Func<string>> agreementName, Expression<Func<string>> messagesToBatchbatchName = null, Expression<Func<string>> messagesToBatchpartitionName = null, Expression<Func<BatchItem[]>> messagesToBatchitems = null, Expression<Func<int>> dataElementSeparator = null, Expression<Func<int>> releaseIndicator = null, Expression<Func<int>> componentSeparator = null, Expression<Func<int>> repetitionSeparator = null, Expression<Func<int>> segmentTerminator = null, Expression<Func<segmentTerminatorSuffixInput>> segmentTerminatorSuffix = null, Expression<Func<decimalIndicatorInput>> decimalIndicator = null)
        {
            var __workflow_agreementName = agreementName == null ? null : WorkflowExpression.Compile(agreementName);
            WorkflowExpression.Validate(__workflow_agreementName, nameof(agreementName), required: true);
            var __workflow_messagesToBatchbatchName = messagesToBatchbatchName == null ? null : WorkflowExpression.Compile(messagesToBatchbatchName);
            WorkflowExpression.Validate(__workflow_messagesToBatchbatchName, nameof(messagesToBatchbatchName), required: false);
            var __workflow_messagesToBatchpartitionName = messagesToBatchpartitionName == null ? null : WorkflowExpression.Compile(messagesToBatchpartitionName);
            WorkflowExpression.Validate(__workflow_messagesToBatchpartitionName, nameof(messagesToBatchpartitionName), required: false);
            var __workflow_messagesToBatchitems = messagesToBatchitems == null ? null : WorkflowExpression.Compile(messagesToBatchitems);
            WorkflowExpression.Validate(__workflow_messagesToBatchitems, nameof(messagesToBatchitems), required: false);
            var __workflow_dataElementSeparator = dataElementSeparator == null ? null : WorkflowExpression.Compile(dataElementSeparator);
            WorkflowExpression.Validate(__workflow_dataElementSeparator, nameof(dataElementSeparator), required: false);
            var __workflow_releaseIndicator = releaseIndicator == null ? null : WorkflowExpression.Compile(releaseIndicator);
            WorkflowExpression.Validate(__workflow_releaseIndicator, nameof(releaseIndicator), required: false);
            var __workflow_componentSeparator = componentSeparator == null ? null : WorkflowExpression.Compile(componentSeparator);
            WorkflowExpression.Validate(__workflow_componentSeparator, nameof(componentSeparator), required: false);
            var __workflow_repetitionSeparator = repetitionSeparator == null ? null : WorkflowExpression.Compile(repetitionSeparator);
            WorkflowExpression.Validate(__workflow_repetitionSeparator, nameof(repetitionSeparator), required: false);
            var __workflow_segmentTerminator = segmentTerminator == null ? null : WorkflowExpression.Compile(segmentTerminator);
            WorkflowExpression.Validate(__workflow_segmentTerminator, nameof(segmentTerminator), required: false);
            var __workflow_segmentTerminatorSuffix = segmentTerminatorSuffix == null ? null : WorkflowExpression.Compile(segmentTerminatorSuffix);
            WorkflowExpression.Validate(__workflow_segmentTerminatorSuffix, nameof(segmentTerminatorSuffix), required: false);
            var __workflow_decimalIndicator = decimalIndicator == null ? null : WorkflowExpression.Compile(decimalIndicator);
            WorkflowExpression.Validate(__workflow_decimalIndicator, nameof(decimalIndicator), required: false);
            return new DeferredBodyAction<EdifactBatchEncodeResponse>(() =>
            {
                var apiCallPath = "/Encode/Batch/ResolveByName";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["agreementName"] = ExpressionConverter.Convert(__workflow_agreementName);
                if (__workflow_dataElementSeparator != null)
                    callPayload.Queries["dataElementSeparator"] = ExpressionConverter.Convert(__workflow_dataElementSeparator);
                if (__workflow_releaseIndicator != null)
                    callPayload.Queries["releaseIndicator"] = ExpressionConverter.Convert(__workflow_releaseIndicator);
                if (__workflow_componentSeparator != null)
                    callPayload.Queries["componentSeparator"] = ExpressionConverter.Convert(__workflow_componentSeparator);
                if (__workflow_repetitionSeparator != null)
                    callPayload.Queries["repetitionSeparator"] = ExpressionConverter.Convert(__workflow_repetitionSeparator);
                if (__workflow_segmentTerminator != null)
                    callPayload.Queries["segmentTerminator"] = ExpressionConverter.Convert(__workflow_segmentTerminator);
                if (__workflow_segmentTerminatorSuffix != null)
                    callPayload.Queries["segmentTerminatorSuffix"] = ExpressionConverter.Convert(__workflow_segmentTerminatorSuffix);
                if (__workflow_decimalIndicator != null)
                    callPayload.Queries["decimalIndicator"] = ExpressionConverter.Convert(__workflow_decimalIndicator);
                var messagesToBatch = new JObject();
                var messagesToBatchpropCount = 0;
                if (__workflow_messagesToBatchbatchName != null)
                {
                    messagesToBatch["BatchName"] = ExpressionConverter.ConvertO(__workflow_messagesToBatchbatchName);
                    messagesToBatchpropCount++;
                }

                if (__workflow_messagesToBatchpartitionName != null)
                {
                    messagesToBatch["PartitionName"] = ExpressionConverter.ConvertO(__workflow_messagesToBatchpartitionName);
                    messagesToBatchpropCount++;
                }

                if (__workflow_messagesToBatchitems != null)
                {
                    messagesToBatch["Items"] = ExpressionConverter.ConvertO(__workflow_messagesToBatchitems);
                    messagesToBatchpropCount++;
                }

                if (messagesToBatchpropCount > 0)
                {
                    callPayload.Body = messagesToBatch;
                }

                return new ApiConnectionAction<EdifactBatchEncodeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "edifact")]
        public IBodyWorkflowAction<EdifactBatchEncodeResponse> BatchEncodeResolveByPartnerIdentities(Expression<Func<string>> senderIdentifier, Expression<Func<string>> senderQualifier, Expression<Func<string>> receiverIdentifier, Expression<Func<string>> receiverQualifier, Expression<Func<string>> messagesToBatchbatchName = null, Expression<Func<string>> messagesToBatchpartitionName = null, Expression<Func<BatchItem[]>> messagesToBatchitems = null, Expression<Func<int>> dataElementSeparator = null, Expression<Func<int>> releaseIndicator = null, Expression<Func<int>> componentSeparator = null, Expression<Func<int>> repetitionSeparator = null, Expression<Func<int>> segmentTerminator = null, Expression<Func<segmentTerminatorSuffixInput>> segmentTerminatorSuffix = null, Expression<Func<decimalIndicatorInput>> decimalIndicator = null)
        {
            var __workflow_senderIdentifier = senderIdentifier == null ? null : WorkflowExpression.Compile(senderIdentifier);
            WorkflowExpression.Validate(__workflow_senderIdentifier, nameof(senderIdentifier), required: true);
            var __workflow_senderQualifier = senderQualifier == null ? null : WorkflowExpression.Compile(senderQualifier);
            WorkflowExpression.Validate(__workflow_senderQualifier, nameof(senderQualifier), required: true);
            var __workflow_receiverIdentifier = receiverIdentifier == null ? null : WorkflowExpression.Compile(receiverIdentifier);
            WorkflowExpression.Validate(__workflow_receiverIdentifier, nameof(receiverIdentifier), required: true);
            var __workflow_receiverQualifier = receiverQualifier == null ? null : WorkflowExpression.Compile(receiverQualifier);
            WorkflowExpression.Validate(__workflow_receiverQualifier, nameof(receiverQualifier), required: true);
            var __workflow_messagesToBatchbatchName = messagesToBatchbatchName == null ? null : WorkflowExpression.Compile(messagesToBatchbatchName);
            WorkflowExpression.Validate(__workflow_messagesToBatchbatchName, nameof(messagesToBatchbatchName), required: false);
            var __workflow_messagesToBatchpartitionName = messagesToBatchpartitionName == null ? null : WorkflowExpression.Compile(messagesToBatchpartitionName);
            WorkflowExpression.Validate(__workflow_messagesToBatchpartitionName, nameof(messagesToBatchpartitionName), required: false);
            var __workflow_messagesToBatchitems = messagesToBatchitems == null ? null : WorkflowExpression.Compile(messagesToBatchitems);
            WorkflowExpression.Validate(__workflow_messagesToBatchitems, nameof(messagesToBatchitems), required: false);
            var __workflow_dataElementSeparator = dataElementSeparator == null ? null : WorkflowExpression.Compile(dataElementSeparator);
            WorkflowExpression.Validate(__workflow_dataElementSeparator, nameof(dataElementSeparator), required: false);
            var __workflow_releaseIndicator = releaseIndicator == null ? null : WorkflowExpression.Compile(releaseIndicator);
            WorkflowExpression.Validate(__workflow_releaseIndicator, nameof(releaseIndicator), required: false);
            var __workflow_componentSeparator = componentSeparator == null ? null : WorkflowExpression.Compile(componentSeparator);
            WorkflowExpression.Validate(__workflow_componentSeparator, nameof(componentSeparator), required: false);
            var __workflow_repetitionSeparator = repetitionSeparator == null ? null : WorkflowExpression.Compile(repetitionSeparator);
            WorkflowExpression.Validate(__workflow_repetitionSeparator, nameof(repetitionSeparator), required: false);
            var __workflow_segmentTerminator = segmentTerminator == null ? null : WorkflowExpression.Compile(segmentTerminator);
            WorkflowExpression.Validate(__workflow_segmentTerminator, nameof(segmentTerminator), required: false);
            var __workflow_segmentTerminatorSuffix = segmentTerminatorSuffix == null ? null : WorkflowExpression.Compile(segmentTerminatorSuffix);
            WorkflowExpression.Validate(__workflow_segmentTerminatorSuffix, nameof(segmentTerminatorSuffix), required: false);
            var __workflow_decimalIndicator = decimalIndicator == null ? null : WorkflowExpression.Compile(decimalIndicator);
            WorkflowExpression.Validate(__workflow_decimalIndicator, nameof(decimalIndicator), required: false);
            return new DeferredBodyAction<EdifactBatchEncodeResponse>(() =>
            {
                var apiCallPath = "/Encode/Batch/ResolveByIdentities";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["senderIdentifier"] = ExpressionConverter.Convert(__workflow_senderIdentifier);
                callPayload.Queries["senderQualifier"] = ExpressionConverter.Convert(__workflow_senderQualifier);
                callPayload.Queries["receiverIdentifier"] = ExpressionConverter.Convert(__workflow_receiverIdentifier);
                callPayload.Queries["receiverQualifier"] = ExpressionConverter.Convert(__workflow_receiverQualifier);
                if (__workflow_dataElementSeparator != null)
                    callPayload.Queries["dataElementSeparator"] = ExpressionConverter.Convert(__workflow_dataElementSeparator);
                if (__workflow_releaseIndicator != null)
                    callPayload.Queries["releaseIndicator"] = ExpressionConverter.Convert(__workflow_releaseIndicator);
                if (__workflow_componentSeparator != null)
                    callPayload.Queries["componentSeparator"] = ExpressionConverter.Convert(__workflow_componentSeparator);
                if (__workflow_repetitionSeparator != null)
                    callPayload.Queries["repetitionSeparator"] = ExpressionConverter.Convert(__workflow_repetitionSeparator);
                if (__workflow_segmentTerminator != null)
                    callPayload.Queries["segmentTerminator"] = ExpressionConverter.Convert(__workflow_segmentTerminator);
                if (__workflow_segmentTerminatorSuffix != null)
                    callPayload.Queries["segmentTerminatorSuffix"] = ExpressionConverter.Convert(__workflow_segmentTerminatorSuffix);
                if (__workflow_decimalIndicator != null)
                    callPayload.Queries["decimalIndicator"] = ExpressionConverter.Convert(__workflow_decimalIndicator);
                var messagesToBatch = new JObject();
                var messagesToBatchpropCount = 0;
                if (__workflow_messagesToBatchbatchName != null)
                {
                    messagesToBatch["BatchName"] = ExpressionConverter.ConvertO(__workflow_messagesToBatchbatchName);
                    messagesToBatchpropCount++;
                }

                if (__workflow_messagesToBatchpartitionName != null)
                {
                    messagesToBatch["PartitionName"] = ExpressionConverter.ConvertO(__workflow_messagesToBatchpartitionName);
                    messagesToBatchpropCount++;
                }

                if (__workflow_messagesToBatchitems != null)
                {
                    messagesToBatch["Items"] = ExpressionConverter.ConvertO(__workflow_messagesToBatchitems);
                    messagesToBatchpropCount++;
                }

                if (messagesToBatchpropCount > 0)
                {
                    callPayload.Body = messagesToBatch;
                }

                return new ApiConnectionAction<EdifactBatchEncodeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "edifact")]
        public IBodyWorkflowAction<EdifactEncodeResponse> EncodeResolveByPartnerIdentities(Expression<Func<string>> senderIdentifier, Expression<Func<string>> receiverIdentifier, Expression<Func<string>> senderQualifier = null, Expression<Func<string>> receiverQualifier = null, Expression<Func<int>> dataElementSeparator = null, Expression<Func<int>> releaseIndicator = null, Expression<Func<int>> componentSeparator = null, Expression<Func<int>> repetitionSeparator = null, Expression<Func<int>> segmentTerminator = null, Expression<Func<segmentTerminatorSuffixInput>> segmentTerminatorSuffix = null, Expression<Func<decimalIndicatorInput>> decimalIndicator = null, Expression<Func<string>> body = null)
        {
            var __workflow_senderIdentifier = senderIdentifier == null ? null : WorkflowExpression.Compile(senderIdentifier);
            WorkflowExpression.Validate(__workflow_senderIdentifier, nameof(senderIdentifier), required: true);
            var __workflow_receiverIdentifier = receiverIdentifier == null ? null : WorkflowExpression.Compile(receiverIdentifier);
            WorkflowExpression.Validate(__workflow_receiverIdentifier, nameof(receiverIdentifier), required: true);
            var __workflow_senderQualifier = senderQualifier == null ? null : WorkflowExpression.Compile(senderQualifier);
            WorkflowExpression.Validate(__workflow_senderQualifier, nameof(senderQualifier), required: false);
            var __workflow_receiverQualifier = receiverQualifier == null ? null : WorkflowExpression.Compile(receiverQualifier);
            WorkflowExpression.Validate(__workflow_receiverQualifier, nameof(receiverQualifier), required: false);
            var __workflow_dataElementSeparator = dataElementSeparator == null ? null : WorkflowExpression.Compile(dataElementSeparator);
            WorkflowExpression.Validate(__workflow_dataElementSeparator, nameof(dataElementSeparator), required: false);
            var __workflow_releaseIndicator = releaseIndicator == null ? null : WorkflowExpression.Compile(releaseIndicator);
            WorkflowExpression.Validate(__workflow_releaseIndicator, nameof(releaseIndicator), required: false);
            var __workflow_componentSeparator = componentSeparator == null ? null : WorkflowExpression.Compile(componentSeparator);
            WorkflowExpression.Validate(__workflow_componentSeparator, nameof(componentSeparator), required: false);
            var __workflow_repetitionSeparator = repetitionSeparator == null ? null : WorkflowExpression.Compile(repetitionSeparator);
            WorkflowExpression.Validate(__workflow_repetitionSeparator, nameof(repetitionSeparator), required: false);
            var __workflow_segmentTerminator = segmentTerminator == null ? null : WorkflowExpression.Compile(segmentTerminator);
            WorkflowExpression.Validate(__workflow_segmentTerminator, nameof(segmentTerminator), required: false);
            var __workflow_segmentTerminatorSuffix = segmentTerminatorSuffix == null ? null : WorkflowExpression.Compile(segmentTerminatorSuffix);
            WorkflowExpression.Validate(__workflow_segmentTerminatorSuffix, nameof(segmentTerminatorSuffix), required: false);
            var __workflow_decimalIndicator = decimalIndicator == null ? null : WorkflowExpression.Compile(decimalIndicator);
            WorkflowExpression.Validate(__workflow_decimalIndicator, nameof(decimalIndicator), required: false);
            var __workflow_body = body == null ? null : WorkflowExpression.Compile(body);
            WorkflowExpression.Validate(__workflow_body, nameof(body), required: false);
            return new DeferredBodyAction<EdifactEncodeResponse>(() =>
            {
                var apiCallPath = "/encode/resolvebyidentities";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["senderIdentifier"] = ExpressionConverter.Convert(__workflow_senderIdentifier);
                callPayload.Queries["receiverIdentifier"] = ExpressionConverter.Convert(__workflow_receiverIdentifier);
                if (__workflow_senderQualifier != null)
                    callPayload.Queries["senderQualifier"] = ExpressionConverter.Convert(__workflow_senderQualifier);
                if (__workflow_receiverQualifier != null)
                    callPayload.Queries["receiverQualifier"] = ExpressionConverter.Convert(__workflow_receiverQualifier);
                if (__workflow_dataElementSeparator != null)
                    callPayload.Queries["dataElementSeparator"] = ExpressionConverter.Convert(__workflow_dataElementSeparator);
                if (__workflow_releaseIndicator != null)
                    callPayload.Queries["releaseIndicator"] = ExpressionConverter.Convert(__workflow_releaseIndicator);
                if (__workflow_componentSeparator != null)
                    callPayload.Queries["componentSeparator"] = ExpressionConverter.Convert(__workflow_componentSeparator);
                if (__workflow_repetitionSeparator != null)
                    callPayload.Queries["repetitionSeparator"] = ExpressionConverter.Convert(__workflow_repetitionSeparator);
                if (__workflow_segmentTerminator != null)
                    callPayload.Queries["segmentTerminator"] = ExpressionConverter.Convert(__workflow_segmentTerminator);
                if (__workflow_segmentTerminatorSuffix != null)
                    callPayload.Queries["segmentTerminatorSuffix"] = ExpressionConverter.Convert(__workflow_segmentTerminatorSuffix);
                if (__workflow_decimalIndicator != null)
                    callPayload.Queries["decimalIndicator"] = ExpressionConverter.Convert(__workflow_decimalIndicator);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<EdifactEncodeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "edifact")]
        public IBodyWorkflowAction<EdifactEncodeV2Response> EncodeV2ResolveByPartnerIdentities(Expression<Func<string>> senderIdentifier, Expression<Func<string>> receiverIdentifier, Expression<Func<string>> senderQualifier = null, Expression<Func<string>> receiverQualifier = null, Expression<Func<int>> dataElementSeparator = null, Expression<Func<int>> releaseIndicator = null, Expression<Func<int>> componentSeparator = null, Expression<Func<int>> repetitionSeparator = null, Expression<Func<int>> segmentTerminator = null, Expression<Func<segmentTerminatorSuffixInput>> segmentTerminatorSuffix = null, Expression<Func<decimalIndicatorInput>> decimalIndicator = null, Expression<Func<string>> body = null)
        {
            var __workflow_senderIdentifier = senderIdentifier == null ? null : WorkflowExpression.Compile(senderIdentifier);
            WorkflowExpression.Validate(__workflow_senderIdentifier, nameof(senderIdentifier), required: true);
            var __workflow_receiverIdentifier = receiverIdentifier == null ? null : WorkflowExpression.Compile(receiverIdentifier);
            WorkflowExpression.Validate(__workflow_receiverIdentifier, nameof(receiverIdentifier), required: true);
            var __workflow_senderQualifier = senderQualifier == null ? null : WorkflowExpression.Compile(senderQualifier);
            WorkflowExpression.Validate(__workflow_senderQualifier, nameof(senderQualifier), required: false);
            var __workflow_receiverQualifier = receiverQualifier == null ? null : WorkflowExpression.Compile(receiverQualifier);
            WorkflowExpression.Validate(__workflow_receiverQualifier, nameof(receiverQualifier), required: false);
            var __workflow_dataElementSeparator = dataElementSeparator == null ? null : WorkflowExpression.Compile(dataElementSeparator);
            WorkflowExpression.Validate(__workflow_dataElementSeparator, nameof(dataElementSeparator), required: false);
            var __workflow_releaseIndicator = releaseIndicator == null ? null : WorkflowExpression.Compile(releaseIndicator);
            WorkflowExpression.Validate(__workflow_releaseIndicator, nameof(releaseIndicator), required: false);
            var __workflow_componentSeparator = componentSeparator == null ? null : WorkflowExpression.Compile(componentSeparator);
            WorkflowExpression.Validate(__workflow_componentSeparator, nameof(componentSeparator), required: false);
            var __workflow_repetitionSeparator = repetitionSeparator == null ? null : WorkflowExpression.Compile(repetitionSeparator);
            WorkflowExpression.Validate(__workflow_repetitionSeparator, nameof(repetitionSeparator), required: false);
            var __workflow_segmentTerminator = segmentTerminator == null ? null : WorkflowExpression.Compile(segmentTerminator);
            WorkflowExpression.Validate(__workflow_segmentTerminator, nameof(segmentTerminator), required: false);
            var __workflow_segmentTerminatorSuffix = segmentTerminatorSuffix == null ? null : WorkflowExpression.Compile(segmentTerminatorSuffix);
            WorkflowExpression.Validate(__workflow_segmentTerminatorSuffix, nameof(segmentTerminatorSuffix), required: false);
            var __workflow_decimalIndicator = decimalIndicator == null ? null : WorkflowExpression.Compile(decimalIndicator);
            WorkflowExpression.Validate(__workflow_decimalIndicator, nameof(decimalIndicator), required: false);
            var __workflow_body = body == null ? null : WorkflowExpression.Compile(body);
            WorkflowExpression.Validate(__workflow_body, nameof(body), required: false);
            return new DeferredBodyAction<EdifactEncodeV2Response>(() =>
            {
                var apiCallPath = "/EncodeV2/ResolveByIdentities";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["senderIdentifier"] = ExpressionConverter.Convert(__workflow_senderIdentifier);
                callPayload.Queries["receiverIdentifier"] = ExpressionConverter.Convert(__workflow_receiverIdentifier);
                if (__workflow_senderQualifier != null)
                    callPayload.Queries["senderQualifier"] = ExpressionConverter.Convert(__workflow_senderQualifier);
                if (__workflow_receiverQualifier != null)
                    callPayload.Queries["receiverQualifier"] = ExpressionConverter.Convert(__workflow_receiverQualifier);
                if (__workflow_dataElementSeparator != null)
                    callPayload.Queries["dataElementSeparator"] = ExpressionConverter.Convert(__workflow_dataElementSeparator);
                if (__workflow_releaseIndicator != null)
                    callPayload.Queries["releaseIndicator"] = ExpressionConverter.Convert(__workflow_releaseIndicator);
                if (__workflow_componentSeparator != null)
                    callPayload.Queries["componentSeparator"] = ExpressionConverter.Convert(__workflow_componentSeparator);
                if (__workflow_repetitionSeparator != null)
                    callPayload.Queries["repetitionSeparator"] = ExpressionConverter.Convert(__workflow_repetitionSeparator);
                if (__workflow_segmentTerminator != null)
                    callPayload.Queries["segmentTerminator"] = ExpressionConverter.Convert(__workflow_segmentTerminator);
                if (__workflow_segmentTerminatorSuffix != null)
                    callPayload.Queries["segmentTerminatorSuffix"] = ExpressionConverter.Convert(__workflow_segmentTerminatorSuffix);
                if (__workflow_decimalIndicator != null)
                    callPayload.Queries["decimalIndicator"] = ExpressionConverter.Convert(__workflow_decimalIndicator);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<EdifactEncodeV2Response>(callPayload);
            });
        }
    }

    public class EdifactTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ReplicableControlNumberContent[]> OnModifiedControlNumber(Expression<Func<string>> startSyncTime = null, FlowRecurrence recurrence = null)
        {
            var __workflow_startSyncTime = startSyncTime == null ? null : WorkflowExpression.Compile(startSyncTime);
            WorkflowExpression.Validate(__workflow_startSyncTime, nameof(startSyncTime), required: false);
            return new DeferredBodyTrigger<ReplicableControlNumberContent[]>(() =>
            {
                var apiCallPath = "/triggers/onmodifiedcontrolnumber";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_startSyncTime != null)
                    callPayload.Queries["startSyncTime"] = ExpressionConverter.Convert(__workflow_startSyncTime);
                return new ApiConnectionTrigger<ReplicableControlNumberContent[]>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class UpdateControlNumberResult
    {
        [JsonProperty("UpdateControlNumberStatus")]
        public UpdateControlNumberResultStatusOfTheUpdateControlNumberActionType StatusOfTheUpdateControlNumberAction { get; set; }
        public ControlNumberContent OldControlNumberContent { get; set; }
        public EipErrorResponseBody ErrorDetails { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateControlNumberResultStatusOfTheUpdateControlNumberActionType
    {
        ControlNumberSuccessfullyUpdated,
        ControlNumberContentNotChanged,
        ControlNumberWithGreaterTimestampExists,
        ControlNumberUpdateFailed
    }

    public class ControlNumberContent
    {
        public string ControlNumber { get; set; }
        public string ControlNumberChangedTime { get; set; }
        public bool IsMessageProcessingFailed { get; set; }
        public string MessageType { get; set; }
    }

    public class EipErrorResponseBody
    {
        public EipErrorResponseBodyStatusCodeType StatusCode { get; set; }
        public string ErrorMessage { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("errors")]
        public string[] Errors { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EipErrorResponseBodyStatusCodeType
    {
        Continue,
        SwitchingProtocols,
        OK,
        Created,
        Accepted,
        NonAuthoritativeInformation,
        NoContent,
        ResetContent,
        PartialContent,
        MultipleChoices,
        Ambiguous,
        MovedPermanently,
        Moved,
        Found,
        Redirect,
        SeeOther,
        RedirectMethod,
        NotModified,
        UseProxy,
        Unused,
        TemporaryRedirect,
        RedirectKeepVerb,
        BadRequest,
        Unauthorized,
        PaymentRequired,
        Forbidden,
        NotFound,
        MethodNotAllowed,
        NotAcceptable,
        ProxyAuthenticationRequired,
        RequestTimeout,
        Conflict,
        Gone,
        LengthRequired,
        PreconditionFailed,
        RequestEntityTooLarge,
        RequestUriTooLong,
        UnsupportedMediaType,
        RequestedRangeNotSatisfiable,
        ExpectationFailed,
        UpgradeRequired,
        InternalServerError,
        NotImplemented,
        BadGateway,
        ServiceUnavailable,
        GatewayTimeout,
        HttpVersionNotSupported
    }

    public class ReplicableControlNumberContent
    {
        public string AgreementName { get; set; }
        public ReplicableControlNumberContentControlNumberTypeType ControlNumberType { get; set; }
        public string ControlNumber { get; set; }
        public string ControlNumberChangedTime { get; set; }
        public ReplicableControlNumberContentMessageDirectionType MessageDirection { get; set; }
        public bool IsAcknowledgement { get; set; }
        public bool IsMessageProcessingFailed { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ReplicableControlNumberContentControlNumberTypeType
    {
        Icn,
        Gcn,
        Tscn
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ReplicableControlNumberContentMessageDirectionType
    {
        Receive,
        Send
    }

    public class EdiDecodeResponseEdifactDecodeResponseEdifactAcknowledgement
    {
        public string InterchangeControlNumber { get; set; }
        public string[] GroupControlNumbers { get; set; }
        public EdifactDecodeResponse[] GoodMessages { get; set; }
        public EdifactDecodeResponse[] BadMessages { get; set; }
        public EdifactAcknowledgement[] GeneratedAcks { get; set; }
        public EdifactAcknowledgement[] ReceivedAcks { get; set; }
        public string AgreementName { get; set; }
        public string GuestPartnerName { get; set; }
        public string HostPartnerName { get; set; }
        public string ReceiverIdentifier { get; set; }
        public string ReceiverQualifier { get; set; }
        public string SenderIdentifier { get; set; }
        public string SenderQualifier { get; set; }
    }

    public class EdifactDecodeResponse
    {
        [JsonProperty("UNA_Segment")]
        public string UNASegment { get; set; }
        public EdifactInterchangeHeaders UNB { get; set; }
        public EdifactGroupHeaders UNG { get; set; }
        public EdifactMessageHeaders UNH { get; set; }
        public int DecimalPointIndicator { get; set; }
        public int RepetitionSeparator { get; set; }
        public int EscapeCharacter { get; set; }
        public bool TechnicalAckExpected { get; set; }
        public bool FunctionalAckExpected { get; set; }
        public string Exception { get; set; }
        public int ComponentSeparator { get; set; }
        public int DataElementSeparator { get; set; }
        public string GroupControlNumber { get; set; }
        public string InterchangeControlNumber { get; set; }
        public string MessageType { get; set; }
        public string Payload { get; set; }
        public int ReplacementCharacter { get; set; }
        public int SegmentTerminator { get; set; }
        public string SegmentTerminatorSuffix { get; set; }
        public string TransactionSetControlNumber { get; set; }
        public string AgreementName { get; set; }
        public string GuestPartnerName { get; set; }
        public string HostPartnerName { get; set; }
        public string ReceiverIdentifier { get; set; }
        public string ReceiverQualifier { get; set; }
        public string SenderIdentifier { get; set; }
        public string SenderQualifier { get; set; }
    }

    public class EdifactInterchangeHeaders
    {
        [JsonProperty("UNB_Segment")]
        public string UNBSegment { get; set; }

        [JsonProperty("UNB2.1")]
        public string UNB21 { get; set; }

        [JsonProperty("UNB2.2")]
        public string UNB22 { get; set; }

        [JsonProperty("UNB2.3")]
        public string UNB23 { get; set; }

        [JsonProperty("UNB2.4")]
        public string UNB24 { get; set; }

        [JsonProperty("UNB3.1")]
        public string UNB31 { get; set; }

        [JsonProperty("UNB3.2")]
        public string UNB32 { get; set; }

        [JsonProperty("UNB3.3")]
        public string UNB33 { get; set; }

        [JsonProperty("UNB3.4")]
        public string UNB34 { get; set; }
        public string UNB11 { get; set; }
    }

    public class EdifactGroupHeaders
    {
        [JsonProperty("UNG_Segment")]
        public string UNGSegment { get; set; }
        public string UNG1 { get; set; }

        [JsonProperty("UNG2.1")]
        public string UNG21 { get; set; }

        [JsonProperty("UNG2.2")]
        public string UNG22 { get; set; }

        [JsonProperty("UNG3.1")]
        public string UNG31 { get; set; }

        [JsonProperty("UNG3.2")]
        public string UNG32 { get; set; }

        [JsonProperty("UNG4.1")]
        public string UNG41 { get; set; }

        [JsonProperty("UNG4.2")]
        public string UNG42 { get; set; }
        public string UNG5 { get; set; }
        public string UNG6 { get; set; }

        [JsonProperty("UNG7.1")]
        public string UNG71 { get; set; }

        [JsonProperty("UNG7.2")]
        public string UNG72 { get; set; }

        [JsonProperty("UNG7.3")]
        public string UNG73 { get; set; }
    }

    public class EdifactMessageHeaders
    {
        public string UNH1 { get; set; }

        [JsonProperty("UNH2.1")]
        public string UNH21 { get; set; }

        [JsonProperty("UNH2.2")]
        public string UNH22 { get; set; }

        [JsonProperty("UNH2.3")]
        public string UNH23 { get; set; }

        [JsonProperty("UNH2.4")]
        public string UNH24 { get; set; }

        [JsonProperty("UNH2.5")]
        public string UNH25 { get; set; }

        [JsonProperty("UNH2.6")]
        public string UNH26 { get; set; }

        [JsonProperty("UNH2.7")]
        public string UNH27 { get; set; }
    }

    public class EdifactAcknowledgement
    {
        public EdifactFunctionalAcknowledgement Acknowledgement { get; set; }
        public string AckPayload { get; set; }
        public bool IsFunctionalAck { get; set; }
        public bool IsTechnicalAck { get; set; }
        public bool TechnicalAckExpected { get; set; }
        public bool FunctionalAckExpected { get; set; }
        public string MessageType { get; set; }
    }

    public class EdifactFunctionalAcknowledgement
    {
        public SG1Loop SG1Loop { get; set; }
        public SG3Loop[] SG3Loop { get; set; }
        public string UNH1 { get; set; }

        [JsonProperty("UNH2.1")]
        public string UNH21 { get; set; }

        [JsonProperty("UNH2.2")]
        public string UNH22 { get; set; }

        [JsonProperty("UNH2.3")]
        public string UNH23 { get; set; }

        [JsonProperty("UNH2.4")]
        public string UNH24 { get; set; }
        public UCISegment UCI { get; set; }
        public string UNT1 { get; set; }
        public string UNT2 { get; set; }
    }

    public class SG1Loop
    {
        public string UCM1 { get; set; }
        public EdifactMessageIdentification UCM2 { get; set; }
        public string UCM3 { get; set; }
        public string UCM4 { get; set; }
        public string UCM5 { get; set; }
        public EdifactDataElementIdentification UCM6 { get; set; }
        public EdifactTransactionSetErrorDetails[] SG2Loop { get; set; }
    }

    public class EdifactMessageIdentification
    {
        [JsonProperty("UCM2.1")]
        public string UCM21 { get; set; }

        [JsonProperty("UCM2.2")]
        public string UCM22 { get; set; }

        [JsonProperty("UCM2.3")]
        public string UCM23 { get; set; }

        [JsonProperty("UCM2.4")]
        public string UCM24 { get; set; }
    }

    public class EdifactDataElementIdentification
    {
        public int DataElementPosition { get; set; }
        public int ComponentElementPosition { get; set; }
        public int DataElementOccurrence { get; set; }
    }

    public class EdifactTransactionSetErrorDetails
    {
        public string UCS1 { get; set; }
        public string UCS2 { get; set; }
        public string UCD1 { get; set; }
        public EdifactDataElementIdentification UCD2 { get; set; }
    }

    public class SG3Loop
    {
        public string UCF1 { get; set; }
        public EdifactApplicationIdentification UCF2 { get; set; }
        public EdifactApplicationIdentification UCF3 { get; set; }
        public int UCF4 { get; set; }
        public string UCF5 { get; set; }
        public string UCF6 { get; set; }
        public EdifactDataElementIdentification UCF7 { get; set; }
        public SG4Loop[] SG4Loop { get; set; }
    }

    public class EdifactApplicationIdentification
    {
        public string Id { get; set; }
        public string Qualifier { get; set; }
    }

    public class SG4Loop
    {
        public string UCM1 { get; set; }
        public EdifactMessageIdentification UCM2 { get; set; }
        public int UCM3 { get; set; }
        public string UCM4 { get; set; }
        public string UCM5 { get; set; }
        public EdifactDataElementIdentification UCM6 { get; set; }
        public EdifactTransactionSetErrorDetails[] SG5Loop { get; set; }
    }

    public class UCISegment
    {
        public string UCI1 { get; set; }

        [JsonProperty("UCI2.1")]
        public string UCI21 { get; set; }

        [JsonProperty("UCI2.2")]
        public string UCI22 { get; set; }

        [JsonProperty("UCI2.3")]
        public string UCI23 { get; set; }

        [JsonProperty("UCI3.1")]
        public string UCI31 { get; set; }

        [JsonProperty("UCI3.2")]
        public string UCI32 { get; set; }
        public string UCI4 { get; set; }
        public string UCI5 { get; set; }
        public string UCI6 { get; set; }
        public EdifactDataElementIdentification UCI7 { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum segmentTerminatorSuffixInput
    {
        NotSpecified,
        None,
        CR,
        LF,
        CRLF
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum decimalIndicatorInput
    {
        NotSpecified,
        Comma,
        Decimal
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum payloadCharacterSetInput
    {
        Legacy,
        UTF8,
        Spec
    }

    public class EdiAgreementProperties
    {
        public string AgreementName { get; set; }
        public string GuestPartnerName { get; set; }
        public string HostPartnerName { get; set; }
        public string ReceiverIdentifier { get; set; }
        public string ReceiverQualifier { get; set; }
        public string SenderIdentifier { get; set; }
        public string SenderQualifier { get; set; }
    }

    public class EdifactEncodeResponse
    {
        public EdifactTechnicalAcknowledgement Acknowledgement { get; set; }
        public EdifactInterchangeHeaders UNB { get; set; }
        public EdifactGroupHeaders UNG { get; set; }
        public EdifactMessageHeaders UNH { get; set; }
        public int DecimalPointIndicator { get; set; }
        public bool IsFunctionalAck { get; set; }
        public bool IsTechnicalAck { get; set; }
        public bool TechnicalAckExpected { get; set; }
        public bool FunctionalAckExpected { get; set; }
        public int ComponentSeparator { get; set; }
        public int DataElementSeparator { get; set; }
        public string GroupControlNumber { get; set; }
        public string InterchangeControlNumber { get; set; }
        public string MessageType { get; set; }
        public string Payload { get; set; }
        public int ReplacementCharacter { get; set; }
        public int SegmentTerminator { get; set; }
        public string SegmentTerminatorSuffix { get; set; }
        public string TransactionSetControlNumber { get; set; }
        public string AgreementName { get; set; }
        public string GuestPartnerName { get; set; }
        public string HostPartnerName { get; set; }
        public string ReceiverIdentifier { get; set; }
        public string ReceiverQualifier { get; set; }
        public string SenderIdentifier { get; set; }
        public string SenderQualifier { get; set; }
    }

    public class EdifactTechnicalAcknowledgement
    {
        public string UNH1 { get; set; }

        [JsonProperty("UNH2.1")]
        public string UNH21 { get; set; }

        [JsonProperty("UNH2.2")]
        public string UNH22 { get; set; }

        [JsonProperty("UNH2.3")]
        public string UNH23 { get; set; }

        [JsonProperty("UNH2.4")]
        public string UNH24 { get; set; }
        public UCISegment UCI { get; set; }
        public string UNT1 { get; set; }
        public string UNT2 { get; set; }
    }

    public class EdifactEncodeV2Response
    {
        public EdifactInterchangeBatchEnvelope Interchange { get; set; }
        public JToken Content { get; set; }
        public EdiAgreementProperties AgreementProperties { get; set; }
        public Delimiters Delimiters { get; set; }
    }

    public class EdifactInterchangeBatchEnvelope
    {
        public string InterchangeControlNumber { get; set; }
        public EdifactFunctionalGroupBatchEnvelope[] FunctionalGroups { get; set; }
        public EdifactTransactionSetBatchEnvelope[] TransactionSets { get; set; }

        [JsonProperty("UNB_Segment")]
        public string UNBSegment { get; set; }

        [JsonProperty("UNB2_1")]
        public string UNB21 { get; set; }

        [JsonProperty("UNB2_2")]
        public string UNB22 { get; set; }

        [JsonProperty("UNB2_3")]
        public string UNB23 { get; set; }

        [JsonProperty("UNB2_4")]
        public string UNB24 { get; set; }

        [JsonProperty("UNB3_1")]
        public string UNB31 { get; set; }

        [JsonProperty("UNB3_2")]
        public string UNB32 { get; set; }

        [JsonProperty("UNB3_3")]
        public string UNB33 { get; set; }

        [JsonProperty("UNB3_4")]
        public string UNB34 { get; set; }
        public string UNB11 { get; set; }
    }

    public class EdifactFunctionalGroupBatchEnvelope
    {
        public string GroupControlNumber { get; set; }
        public EdifactTransactionSetBatchEnvelope[] TransactionSets { get; set; }

        [JsonProperty("UNG_Segment")]
        public string UNGSegment { get; set; }
        public string UNG1 { get; set; }

        [JsonProperty("UNG2_1")]
        public string UNG21 { get; set; }

        [JsonProperty("UNG2_2")]
        public string UNG22 { get; set; }

        [JsonProperty("UNG3_1")]
        public string UNG31 { get; set; }

        [JsonProperty("UNG3_2")]
        public string UNG32 { get; set; }

        [JsonProperty("UNG4_1")]
        public string UNG41 { get; set; }

        [JsonProperty("UNG4_2")]
        public string UNG42 { get; set; }
        public string UNG5 { get; set; }
        public string UNG6 { get; set; }

        [JsonProperty("UNG7_1")]
        public string UNG71 { get; set; }

        [JsonProperty("UNG7_2")]
        public string UNG72 { get; set; }

        [JsonProperty("UNG7_3")]
        public string UNG73 { get; set; }
    }

    public class EdifactTransactionSetBatchEnvelope
    {
        public string TransactionSetControlNumber { get; set; }
        public string MessageId { get; set; }
        public string UNH1 { get; set; }

        [JsonProperty("UNH2_1")]
        public string UNH21 { get; set; }

        [JsonProperty("UNH2_2")]
        public string UNH22 { get; set; }

        [JsonProperty("UNH2_3")]
        public string UNH23 { get; set; }

        [JsonProperty("UNH2_4")]
        public string UNH24 { get; set; }

        [JsonProperty("UNH2_5")]
        public string UNH25 { get; set; }

        [JsonProperty("UNH2_6")]
        public string UNH26 { get; set; }

        [JsonProperty("UNH2_7")]
        public string UNH27 { get; set; }
    }

    public class Delimiters
    {
        public int ComponentSeparator { get; set; }
        public int DataElementSeparator { get; set; }
        public int ReplacementCharacter { get; set; }
        public int ReleaseIndicator { get; set; }
        public int RepetitionSeparator { get; set; }
        public int SegmentTerminator { get; set; }
        public string SegmentTerminatorSuffix { get; set; }
        public int DecimalIndicator { get; set; }
    }

    public class EdifactBatchEncodeResponse
    {
        public EdifactInterchangeBatchEnvelope Interchange { get; set; }
        public string BatchName { get; set; }
        public string PartitionName { get; set; }
        public JToken Content { get; set; }
        public BatchItemError[] BadMessages { get; set; }
        public EdiAgreementProperties AgreementProperties { get; set; }
        public Delimiters Delimiters { get; set; }
    }

    public class BatchItemError
    {
        public string MessageId { get; set; }
        public string Error { get; set; }
    }

    public class BatchItem
    {
        public string MessageId { get; set; }
        public JToken Content { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Edifact;

    public partial class WorkflowManagedActions
    {
        public EdifactActions Edifact(string connectionId) => new EdifactActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public EdifactTriggers Edifact(string connectionId) => new EdifactTriggers(connectionId);
    }
}
