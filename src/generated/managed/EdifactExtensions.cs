//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Edifact
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EdifactActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "edifact")]
        public IBodyWorkflowAction<UpdateControlNumberResult[]> AddOrUpdateControlNumbers([WorkflowExpression] Func<ReplicableControlNumberContent[]> controlNumberContents = null)
        {
            SourceExpression.Validate(controlNumberContents, nameof(controlNumberContents), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/controlnumbers";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(controlNumberContents);
                return callPayload;
            }

            return new ApiConnectionAction<UpdateControlNumberResult[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "edifact")]
        public IBodyWorkflowAction<EdiDecodeResponseEdifactDecodeResponseEdifactAcknowledgement> Decode([WorkflowExpression] Func<int> componentSeparator = null, [WorkflowExpression] Func<int> dataElementSeparator = null, [WorkflowExpression] Func<int> releaseIndicator = null, [WorkflowExpression] Func<int> repetitionSeparator = null, [WorkflowExpression] Func<int> segmentTerminator = null, [WorkflowExpression] Func<segmentTerminatorSuffixInput> segmentTerminatorSuffix = null, [WorkflowExpression] Func<decimalIndicatorInput> decimalIndicator = null, [WorkflowExpression] Func<payloadCharacterSetInput> payloadCharacterSet = null, [WorkflowExpression] Func<bool> preserveInterchange = null, [WorkflowExpression] Func<bool> suspendInterchangeOnError = null, [WorkflowExpression] Func<string> body = null)
        {
            SourceExpression.Validate(componentSeparator, nameof(componentSeparator), required: false);
            SourceExpression.Validate(dataElementSeparator, nameof(dataElementSeparator), required: false);
            SourceExpression.Validate(releaseIndicator, nameof(releaseIndicator), required: false);
            SourceExpression.Validate(repetitionSeparator, nameof(repetitionSeparator), required: false);
            SourceExpression.Validate(segmentTerminator, nameof(segmentTerminator), required: false);
            SourceExpression.Validate(segmentTerminatorSuffix, nameof(segmentTerminatorSuffix), required: false);
            SourceExpression.Validate(decimalIndicator, nameof(decimalIndicator), required: false);
            SourceExpression.Validate(payloadCharacterSet, nameof(payloadCharacterSet), required: false);
            SourceExpression.Validate(preserveInterchange, nameof(preserveInterchange), required: false);
            SourceExpression.Validate(suspendInterchangeOnError, nameof(suspendInterchangeOnError), required: false);
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/decode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["componentSeparator"] = Convert.ToString(58);
                if (componentSeparator != null)
                    callPayload.Queries["componentSeparator"] = SourceExpressionConverter.ConvertO(componentSeparator);
                callPayload.Queries["dataElementSeparator"] = Convert.ToString(43);
                if (dataElementSeparator != null)
                    callPayload.Queries["dataElementSeparator"] = SourceExpressionConverter.ConvertO(dataElementSeparator);
                callPayload.Queries["releaseIndicator"] = Convert.ToString(63);
                if (releaseIndicator != null)
                    callPayload.Queries["releaseIndicator"] = SourceExpressionConverter.ConvertO(releaseIndicator);
                callPayload.Queries["repetitionSeparator"] = Convert.ToString(42);
                if (repetitionSeparator != null)
                    callPayload.Queries["repetitionSeparator"] = SourceExpressionConverter.ConvertO(repetitionSeparator);
                callPayload.Queries["segmentTerminator"] = Convert.ToString(39);
                if (segmentTerminator != null)
                    callPayload.Queries["segmentTerminator"] = SourceExpressionConverter.ConvertO(segmentTerminator);
                callPayload.Queries["segmentTerminatorSuffix"] = Convert.ToString("None");
                if (segmentTerminatorSuffix != null)
                    callPayload.Queries["segmentTerminatorSuffix"] = SourceExpressionConverter.Convert(segmentTerminatorSuffix);
                callPayload.Queries["decimalIndicator"] = Convert.ToString("Comma");
                if (decimalIndicator != null)
                    callPayload.Queries["decimalIndicator"] = SourceExpressionConverter.Convert(decimalIndicator);
                callPayload.Queries["payloadCharacterSet"] = Convert.ToString("Legacy");
                if (payloadCharacterSet != null)
                    callPayload.Queries["payloadCharacterSet"] = SourceExpressionConverter.Convert(payloadCharacterSet);
                if (preserveInterchange != null)
                    callPayload.Queries["preserveInterchange"] = SourceExpressionConverter.ConvertO(preserveInterchange);
                if (suspendInterchangeOnError != null)
                    callPayload.Queries["suspendInterchangeOnError"] = SourceExpressionConverter.ConvertO(suspendInterchangeOnError);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<EdiDecodeResponseEdifactDecodeResponseEdifactAcknowledgement>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "edifact")]
        public IBodyWorkflowAction<EdiAgreementProperties> ResolveAgreement([WorkflowExpression] Func<int> componentSeparator = null, [WorkflowExpression] Func<int> dataElementSeparator = null, [WorkflowExpression] Func<int> releaseIndicator = null, [WorkflowExpression] Func<int> repetitionSeparator = null, [WorkflowExpression] Func<int> segmentTerminator = null, [WorkflowExpression] Func<segmentTerminatorSuffixInput> segmentTerminatorSuffix = null, [WorkflowExpression] Func<decimalIndicatorInput> decimalIndicator = null, [WorkflowExpression] Func<string> body = null)
        {
            SourceExpression.Validate(componentSeparator, nameof(componentSeparator), required: false);
            SourceExpression.Validate(dataElementSeparator, nameof(dataElementSeparator), required: false);
            SourceExpression.Validate(releaseIndicator, nameof(releaseIndicator), required: false);
            SourceExpression.Validate(repetitionSeparator, nameof(repetitionSeparator), required: false);
            SourceExpression.Validate(segmentTerminator, nameof(segmentTerminator), required: false);
            SourceExpression.Validate(segmentTerminatorSuffix, nameof(segmentTerminatorSuffix), required: false);
            SourceExpression.Validate(decimalIndicator, nameof(decimalIndicator), required: false);
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/resolveAgreement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["componentSeparator"] = Convert.ToString(58);
                if (componentSeparator != null)
                    callPayload.Queries["componentSeparator"] = SourceExpressionConverter.ConvertO(componentSeparator);
                callPayload.Queries["dataElementSeparator"] = Convert.ToString(43);
                if (dataElementSeparator != null)
                    callPayload.Queries["dataElementSeparator"] = SourceExpressionConverter.ConvertO(dataElementSeparator);
                callPayload.Queries["releaseIndicator"] = Convert.ToString(63);
                if (releaseIndicator != null)
                    callPayload.Queries["releaseIndicator"] = SourceExpressionConverter.ConvertO(releaseIndicator);
                callPayload.Queries["repetitionSeparator"] = Convert.ToString(42);
                if (repetitionSeparator != null)
                    callPayload.Queries["repetitionSeparator"] = SourceExpressionConverter.ConvertO(repetitionSeparator);
                callPayload.Queries["segmentTerminator"] = Convert.ToString(39);
                if (segmentTerminator != null)
                    callPayload.Queries["segmentTerminator"] = SourceExpressionConverter.ConvertO(segmentTerminator);
                callPayload.Queries["segmentTerminatorSuffix"] = Convert.ToString("None");
                if (segmentTerminatorSuffix != null)
                    callPayload.Queries["segmentTerminatorSuffix"] = SourceExpressionConverter.Convert(segmentTerminatorSuffix);
                callPayload.Queries["decimalIndicator"] = Convert.ToString("Comma");
                if (decimalIndicator != null)
                    callPayload.Queries["decimalIndicator"] = SourceExpressionConverter.Convert(decimalIndicator);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<EdiAgreementProperties>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "edifact")]
        public IBodyWorkflowAction<EdifactEncodeResponse> EncodeResolveByAgreementName([WorkflowExpression] Func<string> agreementName, [WorkflowExpression] Func<int> dataElementSeparator = null, [WorkflowExpression] Func<int> releaseIndicator = null, [WorkflowExpression] Func<int> componentSeparator = null, [WorkflowExpression] Func<int> repetitionSeparator = null, [WorkflowExpression] Func<int> segmentTerminator = null, [WorkflowExpression] Func<segmentTerminatorSuffixInput> segmentTerminatorSuffix = null, [WorkflowExpression] Func<decimalIndicatorInput> decimalIndicator = null, [WorkflowExpression] Func<string> body = null)
        {
            SourceExpression.Validate(agreementName, nameof(agreementName), required: true);
            SourceExpression.Validate(dataElementSeparator, nameof(dataElementSeparator), required: false);
            SourceExpression.Validate(releaseIndicator, nameof(releaseIndicator), required: false);
            SourceExpression.Validate(componentSeparator, nameof(componentSeparator), required: false);
            SourceExpression.Validate(repetitionSeparator, nameof(repetitionSeparator), required: false);
            SourceExpression.Validate(segmentTerminator, nameof(segmentTerminator), required: false);
            SourceExpression.Validate(segmentTerminatorSuffix, nameof(segmentTerminatorSuffix), required: false);
            SourceExpression.Validate(decimalIndicator, nameof(decimalIndicator), required: false);
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/encode/resolvebyname";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["agreementName"] = SourceExpressionConverter.ConvertO(agreementName);
                if (dataElementSeparator != null)
                    callPayload.Queries["dataElementSeparator"] = SourceExpressionConverter.ConvertO(dataElementSeparator);
                if (releaseIndicator != null)
                    callPayload.Queries["releaseIndicator"] = SourceExpressionConverter.ConvertO(releaseIndicator);
                if (componentSeparator != null)
                    callPayload.Queries["componentSeparator"] = SourceExpressionConverter.ConvertO(componentSeparator);
                if (repetitionSeparator != null)
                    callPayload.Queries["repetitionSeparator"] = SourceExpressionConverter.ConvertO(repetitionSeparator);
                if (segmentTerminator != null)
                    callPayload.Queries["segmentTerminator"] = SourceExpressionConverter.ConvertO(segmentTerminator);
                if (segmentTerminatorSuffix != null)
                    callPayload.Queries["segmentTerminatorSuffix"] = SourceExpressionConverter.Convert(segmentTerminatorSuffix);
                if (decimalIndicator != null)
                    callPayload.Queries["decimalIndicator"] = SourceExpressionConverter.Convert(decimalIndicator);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<EdifactEncodeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "edifact")]
        public IBodyWorkflowAction<EdifactEncodeV2Response> EncodeV2ResolveByAgreementName([WorkflowExpression] Func<string> agreementName, [WorkflowExpression] Func<int> dataElementSeparator = null, [WorkflowExpression] Func<int> releaseIndicator = null, [WorkflowExpression] Func<int> componentSeparator = null, [WorkflowExpression] Func<int> repetitionSeparator = null, [WorkflowExpression] Func<int> segmentTerminator = null, [WorkflowExpression] Func<segmentTerminatorSuffixInput> segmentTerminatorSuffix = null, [WorkflowExpression] Func<decimalIndicatorInput> decimalIndicator = null, [WorkflowExpression] Func<string> body = null)
        {
            SourceExpression.Validate(agreementName, nameof(agreementName), required: true);
            SourceExpression.Validate(dataElementSeparator, nameof(dataElementSeparator), required: false);
            SourceExpression.Validate(releaseIndicator, nameof(releaseIndicator), required: false);
            SourceExpression.Validate(componentSeparator, nameof(componentSeparator), required: false);
            SourceExpression.Validate(repetitionSeparator, nameof(repetitionSeparator), required: false);
            SourceExpression.Validate(segmentTerminator, nameof(segmentTerminator), required: false);
            SourceExpression.Validate(segmentTerminatorSuffix, nameof(segmentTerminatorSuffix), required: false);
            SourceExpression.Validate(decimalIndicator, nameof(decimalIndicator), required: false);
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/EncodeV2/ResolveByName";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["agreementName"] = SourceExpressionConverter.ConvertO(agreementName);
                if (dataElementSeparator != null)
                    callPayload.Queries["dataElementSeparator"] = SourceExpressionConverter.ConvertO(dataElementSeparator);
                if (releaseIndicator != null)
                    callPayload.Queries["releaseIndicator"] = SourceExpressionConverter.ConvertO(releaseIndicator);
                if (componentSeparator != null)
                    callPayload.Queries["componentSeparator"] = SourceExpressionConverter.ConvertO(componentSeparator);
                if (repetitionSeparator != null)
                    callPayload.Queries["repetitionSeparator"] = SourceExpressionConverter.ConvertO(repetitionSeparator);
                if (segmentTerminator != null)
                    callPayload.Queries["segmentTerminator"] = SourceExpressionConverter.ConvertO(segmentTerminator);
                if (segmentTerminatorSuffix != null)
                    callPayload.Queries["segmentTerminatorSuffix"] = SourceExpressionConverter.Convert(segmentTerminatorSuffix);
                if (decimalIndicator != null)
                    callPayload.Queries["decimalIndicator"] = SourceExpressionConverter.Convert(decimalIndicator);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<EdifactEncodeV2Response>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "edifact")]
        public IBodyWorkflowAction<EdifactBatchEncodeResponse> BatchEncodeResolveByAgreementName([WorkflowExpression] Func<string> agreementName, [WorkflowExpression] Func<string> messagesToBatchbatchName = null, [WorkflowExpression] Func<string> messagesToBatchpartitionName = null, [WorkflowExpression] Func<BatchItem[]> messagesToBatchitems = null, [WorkflowExpression] Func<int> dataElementSeparator = null, [WorkflowExpression] Func<int> releaseIndicator = null, [WorkflowExpression] Func<int> componentSeparator = null, [WorkflowExpression] Func<int> repetitionSeparator = null, [WorkflowExpression] Func<int> segmentTerminator = null, [WorkflowExpression] Func<segmentTerminatorSuffixInput> segmentTerminatorSuffix = null, [WorkflowExpression] Func<decimalIndicatorInput> decimalIndicator = null)
        {
            SourceExpression.Validate(agreementName, nameof(agreementName), required: true);
            SourceExpression.Validate(messagesToBatchbatchName, nameof(messagesToBatchbatchName), required: false);
            SourceExpression.Validate(messagesToBatchpartitionName, nameof(messagesToBatchpartitionName), required: false);
            SourceExpression.Validate(messagesToBatchitems, nameof(messagesToBatchitems), required: false);
            SourceExpression.Validate(dataElementSeparator, nameof(dataElementSeparator), required: false);
            SourceExpression.Validate(releaseIndicator, nameof(releaseIndicator), required: false);
            SourceExpression.Validate(componentSeparator, nameof(componentSeparator), required: false);
            SourceExpression.Validate(repetitionSeparator, nameof(repetitionSeparator), required: false);
            SourceExpression.Validate(segmentTerminator, nameof(segmentTerminator), required: false);
            SourceExpression.Validate(segmentTerminatorSuffix, nameof(segmentTerminatorSuffix), required: false);
            SourceExpression.Validate(decimalIndicator, nameof(decimalIndicator), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Encode/Batch/ResolveByName";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["agreementName"] = SourceExpressionConverter.ConvertO(agreementName);
                if (dataElementSeparator != null)
                    callPayload.Queries["dataElementSeparator"] = SourceExpressionConverter.ConvertO(dataElementSeparator);
                if (releaseIndicator != null)
                    callPayload.Queries["releaseIndicator"] = SourceExpressionConverter.ConvertO(releaseIndicator);
                if (componentSeparator != null)
                    callPayload.Queries["componentSeparator"] = SourceExpressionConverter.ConvertO(componentSeparator);
                if (repetitionSeparator != null)
                    callPayload.Queries["repetitionSeparator"] = SourceExpressionConverter.ConvertO(repetitionSeparator);
                if (segmentTerminator != null)
                    callPayload.Queries["segmentTerminator"] = SourceExpressionConverter.ConvertO(segmentTerminator);
                if (segmentTerminatorSuffix != null)
                    callPayload.Queries["segmentTerminatorSuffix"] = SourceExpressionConverter.Convert(segmentTerminatorSuffix);
                if (decimalIndicator != null)
                    callPayload.Queries["decimalIndicator"] = SourceExpressionConverter.Convert(decimalIndicator);
                var messagesToBatch = new JObject();
                var messagesToBatchpropCount = 0;
                if (messagesToBatchbatchName != null)
                {
                    messagesToBatch["BatchName"] = SourceExpressionConverter.ConvertToken(messagesToBatchbatchName);
                    messagesToBatchpropCount++;
                }

                if (messagesToBatchpartitionName != null)
                {
                    messagesToBatch["PartitionName"] = SourceExpressionConverter.ConvertToken(messagesToBatchpartitionName);
                    messagesToBatchpropCount++;
                }

                if (messagesToBatchitems != null)
                {
                    messagesToBatch["Items"] = SourceExpressionConverter.ConvertToken(messagesToBatchitems);
                    messagesToBatchpropCount++;
                }

                if (messagesToBatchpropCount > 0)
                {
                    callPayload.Body = messagesToBatch;
                }
                return callPayload;
            }

            return new ApiConnectionAction<EdifactBatchEncodeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "edifact")]
        public IBodyWorkflowAction<EdifactBatchEncodeResponse> BatchEncodeResolveByPartnerIdentities([WorkflowExpression] Func<string> senderIdentifier, [WorkflowExpression] Func<string> senderQualifier, [WorkflowExpression] Func<string> receiverIdentifier, [WorkflowExpression] Func<string> receiverQualifier, [WorkflowExpression] Func<string> messagesToBatchbatchName = null, [WorkflowExpression] Func<string> messagesToBatchpartitionName = null, [WorkflowExpression] Func<BatchItem[]> messagesToBatchitems = null, [WorkflowExpression] Func<int> dataElementSeparator = null, [WorkflowExpression] Func<int> releaseIndicator = null, [WorkflowExpression] Func<int> componentSeparator = null, [WorkflowExpression] Func<int> repetitionSeparator = null, [WorkflowExpression] Func<int> segmentTerminator = null, [WorkflowExpression] Func<segmentTerminatorSuffixInput> segmentTerminatorSuffix = null, [WorkflowExpression] Func<decimalIndicatorInput> decimalIndicator = null)
        {
            SourceExpression.Validate(senderIdentifier, nameof(senderIdentifier), required: true);
            SourceExpression.Validate(senderQualifier, nameof(senderQualifier), required: true);
            SourceExpression.Validate(receiverIdentifier, nameof(receiverIdentifier), required: true);
            SourceExpression.Validate(receiverQualifier, nameof(receiverQualifier), required: true);
            SourceExpression.Validate(messagesToBatchbatchName, nameof(messagesToBatchbatchName), required: false);
            SourceExpression.Validate(messagesToBatchpartitionName, nameof(messagesToBatchpartitionName), required: false);
            SourceExpression.Validate(messagesToBatchitems, nameof(messagesToBatchitems), required: false);
            SourceExpression.Validate(dataElementSeparator, nameof(dataElementSeparator), required: false);
            SourceExpression.Validate(releaseIndicator, nameof(releaseIndicator), required: false);
            SourceExpression.Validate(componentSeparator, nameof(componentSeparator), required: false);
            SourceExpression.Validate(repetitionSeparator, nameof(repetitionSeparator), required: false);
            SourceExpression.Validate(segmentTerminator, nameof(segmentTerminator), required: false);
            SourceExpression.Validate(segmentTerminatorSuffix, nameof(segmentTerminatorSuffix), required: false);
            SourceExpression.Validate(decimalIndicator, nameof(decimalIndicator), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Encode/Batch/ResolveByIdentities";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["senderIdentifier"] = SourceExpressionConverter.ConvertO(senderIdentifier);
                callPayload.Queries["senderQualifier"] = SourceExpressionConverter.ConvertO(senderQualifier);
                callPayload.Queries["receiverIdentifier"] = SourceExpressionConverter.ConvertO(receiverIdentifier);
                callPayload.Queries["receiverQualifier"] = SourceExpressionConverter.ConvertO(receiverQualifier);
                if (dataElementSeparator != null)
                    callPayload.Queries["dataElementSeparator"] = SourceExpressionConverter.ConvertO(dataElementSeparator);
                if (releaseIndicator != null)
                    callPayload.Queries["releaseIndicator"] = SourceExpressionConverter.ConvertO(releaseIndicator);
                if (componentSeparator != null)
                    callPayload.Queries["componentSeparator"] = SourceExpressionConverter.ConvertO(componentSeparator);
                if (repetitionSeparator != null)
                    callPayload.Queries["repetitionSeparator"] = SourceExpressionConverter.ConvertO(repetitionSeparator);
                if (segmentTerminator != null)
                    callPayload.Queries["segmentTerminator"] = SourceExpressionConverter.ConvertO(segmentTerminator);
                if (segmentTerminatorSuffix != null)
                    callPayload.Queries["segmentTerminatorSuffix"] = SourceExpressionConverter.Convert(segmentTerminatorSuffix);
                if (decimalIndicator != null)
                    callPayload.Queries["decimalIndicator"] = SourceExpressionConverter.Convert(decimalIndicator);
                var messagesToBatch = new JObject();
                var messagesToBatchpropCount = 0;
                if (messagesToBatchbatchName != null)
                {
                    messagesToBatch["BatchName"] = SourceExpressionConverter.ConvertToken(messagesToBatchbatchName);
                    messagesToBatchpropCount++;
                }

                if (messagesToBatchpartitionName != null)
                {
                    messagesToBatch["PartitionName"] = SourceExpressionConverter.ConvertToken(messagesToBatchpartitionName);
                    messagesToBatchpropCount++;
                }

                if (messagesToBatchitems != null)
                {
                    messagesToBatch["Items"] = SourceExpressionConverter.ConvertToken(messagesToBatchitems);
                    messagesToBatchpropCount++;
                }

                if (messagesToBatchpropCount > 0)
                {
                    callPayload.Body = messagesToBatch;
                }
                return callPayload;
            }

            return new ApiConnectionAction<EdifactBatchEncodeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "edifact")]
        public IBodyWorkflowAction<EdifactEncodeResponse> EncodeResolveByPartnerIdentities([WorkflowExpression] Func<string> senderIdentifier, [WorkflowExpression] Func<string> receiverIdentifier, [WorkflowExpression] Func<string> senderQualifier = null, [WorkflowExpression] Func<string> receiverQualifier = null, [WorkflowExpression] Func<int> dataElementSeparator = null, [WorkflowExpression] Func<int> releaseIndicator = null, [WorkflowExpression] Func<int> componentSeparator = null, [WorkflowExpression] Func<int> repetitionSeparator = null, [WorkflowExpression] Func<int> segmentTerminator = null, [WorkflowExpression] Func<segmentTerminatorSuffixInput> segmentTerminatorSuffix = null, [WorkflowExpression] Func<decimalIndicatorInput> decimalIndicator = null, [WorkflowExpression] Func<string> body = null)
        {
            SourceExpression.Validate(senderIdentifier, nameof(senderIdentifier), required: true);
            SourceExpression.Validate(receiverIdentifier, nameof(receiverIdentifier), required: true);
            SourceExpression.Validate(senderQualifier, nameof(senderQualifier), required: false);
            SourceExpression.Validate(receiverQualifier, nameof(receiverQualifier), required: false);
            SourceExpression.Validate(dataElementSeparator, nameof(dataElementSeparator), required: false);
            SourceExpression.Validate(releaseIndicator, nameof(releaseIndicator), required: false);
            SourceExpression.Validate(componentSeparator, nameof(componentSeparator), required: false);
            SourceExpression.Validate(repetitionSeparator, nameof(repetitionSeparator), required: false);
            SourceExpression.Validate(segmentTerminator, nameof(segmentTerminator), required: false);
            SourceExpression.Validate(segmentTerminatorSuffix, nameof(segmentTerminatorSuffix), required: false);
            SourceExpression.Validate(decimalIndicator, nameof(decimalIndicator), required: false);
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/encode/resolvebyidentities";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["senderIdentifier"] = SourceExpressionConverter.ConvertO(senderIdentifier);
                callPayload.Queries["receiverIdentifier"] = SourceExpressionConverter.ConvertO(receiverIdentifier);
                if (senderQualifier != null)
                    callPayload.Queries["senderQualifier"] = SourceExpressionConverter.ConvertO(senderQualifier);
                if (receiverQualifier != null)
                    callPayload.Queries["receiverQualifier"] = SourceExpressionConverter.ConvertO(receiverQualifier);
                if (dataElementSeparator != null)
                    callPayload.Queries["dataElementSeparator"] = SourceExpressionConverter.ConvertO(dataElementSeparator);
                if (releaseIndicator != null)
                    callPayload.Queries["releaseIndicator"] = SourceExpressionConverter.ConvertO(releaseIndicator);
                if (componentSeparator != null)
                    callPayload.Queries["componentSeparator"] = SourceExpressionConverter.ConvertO(componentSeparator);
                if (repetitionSeparator != null)
                    callPayload.Queries["repetitionSeparator"] = SourceExpressionConverter.ConvertO(repetitionSeparator);
                if (segmentTerminator != null)
                    callPayload.Queries["segmentTerminator"] = SourceExpressionConverter.ConvertO(segmentTerminator);
                if (segmentTerminatorSuffix != null)
                    callPayload.Queries["segmentTerminatorSuffix"] = SourceExpressionConverter.Convert(segmentTerminatorSuffix);
                if (decimalIndicator != null)
                    callPayload.Queries["decimalIndicator"] = SourceExpressionConverter.Convert(decimalIndicator);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<EdifactEncodeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "edifact")]
        public IBodyWorkflowAction<EdifactEncodeV2Response> EncodeV2ResolveByPartnerIdentities([WorkflowExpression] Func<string> senderIdentifier, [WorkflowExpression] Func<string> receiverIdentifier, [WorkflowExpression] Func<string> senderQualifier = null, [WorkflowExpression] Func<string> receiverQualifier = null, [WorkflowExpression] Func<int> dataElementSeparator = null, [WorkflowExpression] Func<int> releaseIndicator = null, [WorkflowExpression] Func<int> componentSeparator = null, [WorkflowExpression] Func<int> repetitionSeparator = null, [WorkflowExpression] Func<int> segmentTerminator = null, [WorkflowExpression] Func<segmentTerminatorSuffixInput> segmentTerminatorSuffix = null, [WorkflowExpression] Func<decimalIndicatorInput> decimalIndicator = null, [WorkflowExpression] Func<string> body = null)
        {
            SourceExpression.Validate(senderIdentifier, nameof(senderIdentifier), required: true);
            SourceExpression.Validate(receiverIdentifier, nameof(receiverIdentifier), required: true);
            SourceExpression.Validate(senderQualifier, nameof(senderQualifier), required: false);
            SourceExpression.Validate(receiverQualifier, nameof(receiverQualifier), required: false);
            SourceExpression.Validate(dataElementSeparator, nameof(dataElementSeparator), required: false);
            SourceExpression.Validate(releaseIndicator, nameof(releaseIndicator), required: false);
            SourceExpression.Validate(componentSeparator, nameof(componentSeparator), required: false);
            SourceExpression.Validate(repetitionSeparator, nameof(repetitionSeparator), required: false);
            SourceExpression.Validate(segmentTerminator, nameof(segmentTerminator), required: false);
            SourceExpression.Validate(segmentTerminatorSuffix, nameof(segmentTerminatorSuffix), required: false);
            SourceExpression.Validate(decimalIndicator, nameof(decimalIndicator), required: false);
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/EncodeV2/ResolveByIdentities";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["senderIdentifier"] = SourceExpressionConverter.ConvertO(senderIdentifier);
                callPayload.Queries["receiverIdentifier"] = SourceExpressionConverter.ConvertO(receiverIdentifier);
                if (senderQualifier != null)
                    callPayload.Queries["senderQualifier"] = SourceExpressionConverter.ConvertO(senderQualifier);
                if (receiverQualifier != null)
                    callPayload.Queries["receiverQualifier"] = SourceExpressionConverter.ConvertO(receiverQualifier);
                if (dataElementSeparator != null)
                    callPayload.Queries["dataElementSeparator"] = SourceExpressionConverter.ConvertO(dataElementSeparator);
                if (releaseIndicator != null)
                    callPayload.Queries["releaseIndicator"] = SourceExpressionConverter.ConvertO(releaseIndicator);
                if (componentSeparator != null)
                    callPayload.Queries["componentSeparator"] = SourceExpressionConverter.ConvertO(componentSeparator);
                if (repetitionSeparator != null)
                    callPayload.Queries["repetitionSeparator"] = SourceExpressionConverter.ConvertO(repetitionSeparator);
                if (segmentTerminator != null)
                    callPayload.Queries["segmentTerminator"] = SourceExpressionConverter.ConvertO(segmentTerminator);
                if (segmentTerminatorSuffix != null)
                    callPayload.Queries["segmentTerminatorSuffix"] = SourceExpressionConverter.Convert(segmentTerminatorSuffix);
                if (decimalIndicator != null)
                    callPayload.Queries["decimalIndicator"] = SourceExpressionConverter.Convert(decimalIndicator);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<EdifactEncodeV2Response>(BuildSourceInput);
        }
    }

    public class EdifactTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ReplicableControlNumberContent[]> OnModifiedControlNumber([WorkflowExpression] Func<string> startSyncTime = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(startSyncTime, nameof(startSyncTime), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/triggers/onmodifiedcontrolnumber";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (startSyncTime != null)
                    callPayload.Queries["startSyncTime"] = SourceExpressionConverter.ConvertO(startSyncTime);
                return callPayload;
            }

            return new ApiConnectionTrigger<ReplicableControlNumberContent[]>(BuildSourceInput, triggerName, recurrence);
        }
    }

    public class UpdateControlNumberResult
    {
        [JsonProperty("UpdateControlNumberStatus")]
        public UpdateControlNumberResultStatusOfTheUpdateControlNumberActionType StatusOfTheUpdateControlNumberAction { get; set; }
        public ControlNumberContent OldControlNumberContent { get; set; }
        public EipErrorResponseBody ErrorDetails { get; set; }
    }

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

    public enum ReplicableControlNumberContentControlNumberTypeType
    {
        Icn,
        Gcn,
        Tscn
    }

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

    public enum segmentTerminatorSuffixInput
    {
        NotSpecified,
        None,
        CR,
        LF,
        CRLF
    }

    public enum decimalIndicatorInput
    {
        NotSpecified,
        Comma,
        Decimal
    }

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