//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.X12
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class X12Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "x12")]
        public IBodyWorkflowAction<UpdateControlNumberResult[]> AddOrUpdateControlNumbers([WorkflowExpression] Func<ReplicableControlNumberContent[]> controlNumberContents = null)
        {
            SourceExpression.Validate(controlNumberContents, nameof(controlNumberContents), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/controlNumbers";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(controlNumberContents);
                return callPayload;
            }

            return new ApiConnectionAction<UpdateControlNumberResult[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "x12")]
        public IBodyWorkflowAction<EdiDecodeResponseX12DecodeResponseX12AcknowledgementResponse> Decode([WorkflowExpression] Func<bool> preserveInterchange = null, [WorkflowExpression] Func<bool> suspendInterchangeOnError = null, [WorkflowExpression] Func<string> body = null)
        {
            SourceExpression.Validate(preserveInterchange, nameof(preserveInterchange), required: false);
            SourceExpression.Validate(suspendInterchangeOnError, nameof(suspendInterchangeOnError), required: false);
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/decode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (preserveInterchange != null)
                    callPayload.Queries["preserveInterchange"] = SourceExpressionConverter.ConvertO(preserveInterchange);
                if (suspendInterchangeOnError != null)
                    callPayload.Queries["suspendInterchangeOnError"] = SourceExpressionConverter.ConvertO(suspendInterchangeOnError);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<EdiDecodeResponseX12DecodeResponseX12AcknowledgementResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "x12")]
        public IBodyWorkflowAction<EdiAgreementProperties> ResolveAgreement([WorkflowExpression] Func<string> body = null)
        {
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/resolveAgreement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<EdiAgreementProperties>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "x12")]
        public IBodyWorkflowAction<X12BatchEncodeResponse> BatchEncodeResolveByAgreementName([WorkflowExpression] Func<string> agreementName, [WorkflowExpression] Func<string> messagesToBatchbatchName = null, [WorkflowExpression] Func<string> messagesToBatchpartitionName = null, [WorkflowExpression] Func<BatchItem[]> messagesToBatchitems = null, [WorkflowExpression] Func<int> dataElementSeparator = null, [WorkflowExpression] Func<int> componentSeparator = null, [WorkflowExpression] Func<int> replacementCharacter = null, [WorkflowExpression] Func<int> segmentTerminator = null, [WorkflowExpression] Func<segmentTerminatorSuffixInput> segmentTerminatorSuffix = null)
        {
            SourceExpression.Validate(agreementName, nameof(agreementName), required: true);
            SourceExpression.Validate(messagesToBatchbatchName, nameof(messagesToBatchbatchName), required: false);
            SourceExpression.Validate(messagesToBatchpartitionName, nameof(messagesToBatchpartitionName), required: false);
            SourceExpression.Validate(messagesToBatchitems, nameof(messagesToBatchitems), required: false);
            SourceExpression.Validate(dataElementSeparator, nameof(dataElementSeparator), required: false);
            SourceExpression.Validate(componentSeparator, nameof(componentSeparator), required: false);
            SourceExpression.Validate(replacementCharacter, nameof(replacementCharacter), required: false);
            SourceExpression.Validate(segmentTerminator, nameof(segmentTerminator), required: false);
            SourceExpression.Validate(segmentTerminatorSuffix, nameof(segmentTerminatorSuffix), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Encode/Batch/ResolveByName";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["agreementName"] = SourceExpressionConverter.ConvertO(agreementName);
                if (dataElementSeparator != null)
                    callPayload.Queries["dataElementSeparator"] = SourceExpressionConverter.ConvertO(dataElementSeparator);
                if (componentSeparator != null)
                    callPayload.Queries["componentSeparator"] = SourceExpressionConverter.ConvertO(componentSeparator);
                if (replacementCharacter != null)
                    callPayload.Queries["replacementCharacter"] = SourceExpressionConverter.ConvertO(replacementCharacter);
                if (segmentTerminator != null)
                    callPayload.Queries["segmentTerminator"] = SourceExpressionConverter.ConvertO(segmentTerminator);
                if (segmentTerminatorSuffix != null)
                    callPayload.Queries["segmentTerminatorSuffix"] = SourceExpressionConverter.Convert(segmentTerminatorSuffix);
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

            return new ApiConnectionAction<X12BatchEncodeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "x12")]
        public IBodyWorkflowAction<EdiEncodeResponse> EncodeResolveByAgreementName([WorkflowExpression] Func<string> agreementName, [WorkflowExpression] Func<int> dataElementSeparator = null, [WorkflowExpression] Func<int> componentSeparator = null, [WorkflowExpression] Func<int> replacementCharacter = null, [WorkflowExpression] Func<int> segmentTerminator = null, [WorkflowExpression] Func<segmentTerminatorSuffixInput> segmentTerminatorSuffix = null, [WorkflowExpression] Func<string> body = null, [WorkflowExpression] Func<string> iSA12 = null, [WorkflowExpression] Func<string> gS02 = null, [WorkflowExpression] Func<string> gS03 = null)
        {
            SourceExpression.Validate(agreementName, nameof(agreementName), required: true);
            SourceExpression.Validate(dataElementSeparator, nameof(dataElementSeparator), required: false);
            SourceExpression.Validate(componentSeparator, nameof(componentSeparator), required: false);
            SourceExpression.Validate(replacementCharacter, nameof(replacementCharacter), required: false);
            SourceExpression.Validate(segmentTerminator, nameof(segmentTerminator), required: false);
            SourceExpression.Validate(segmentTerminatorSuffix, nameof(segmentTerminatorSuffix), required: false);
            SourceExpression.Validate(body, nameof(body), required: false);
            SourceExpression.Validate(iSA12, nameof(iSA12), required: false);
            SourceExpression.Validate(gS02, nameof(gS02), required: false);
            SourceExpression.Validate(gS03, nameof(gS03), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/encode/resolvebyname";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["agreementName"] = SourceExpressionConverter.ConvertO(agreementName);
                if (dataElementSeparator != null)
                    callPayload.Queries["dataElementSeparator"] = SourceExpressionConverter.ConvertO(dataElementSeparator);
                if (componentSeparator != null)
                    callPayload.Queries["componentSeparator"] = SourceExpressionConverter.ConvertO(componentSeparator);
                if (replacementCharacter != null)
                    callPayload.Queries["replacementCharacter"] = SourceExpressionConverter.ConvertO(replacementCharacter);
                if (segmentTerminator != null)
                    callPayload.Queries["segmentTerminator"] = SourceExpressionConverter.ConvertO(segmentTerminator);
                if (segmentTerminatorSuffix != null)
                    callPayload.Queries["segmentTerminatorSuffix"] = SourceExpressionConverter.Convert(segmentTerminatorSuffix);
                if (iSA12 != null)
                    callPayload.Headers["ISA12"] = SourceExpressionConverter.ConvertO(iSA12);
                if (gS02 != null)
                    callPayload.Headers["GS02"] = SourceExpressionConverter.ConvertO(gS02);
                if (gS03 != null)
                    callPayload.Headers["GS03"] = SourceExpressionConverter.ConvertO(gS03);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<EdiEncodeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "x12")]
        public IBodyWorkflowAction<X12EncodeV2Response> EncodeV2ResolveByAgreementName([WorkflowExpression] Func<string> agreementName, [WorkflowExpression] Func<int> dataElementSeparator = null, [WorkflowExpression] Func<int> componentSeparator = null, [WorkflowExpression] Func<int> replacementCharacter = null, [WorkflowExpression] Func<int> segmentTerminator = null, [WorkflowExpression] Func<segmentTerminatorSuffixInput> segmentTerminatorSuffix = null, [WorkflowExpression] Func<string> body = null, [WorkflowExpression] Func<string> gS02 = null, [WorkflowExpression] Func<string> gS03 = null)
        {
            SourceExpression.Validate(agreementName, nameof(agreementName), required: true);
            SourceExpression.Validate(dataElementSeparator, nameof(dataElementSeparator), required: false);
            SourceExpression.Validate(componentSeparator, nameof(componentSeparator), required: false);
            SourceExpression.Validate(replacementCharacter, nameof(replacementCharacter), required: false);
            SourceExpression.Validate(segmentTerminator, nameof(segmentTerminator), required: false);
            SourceExpression.Validate(segmentTerminatorSuffix, nameof(segmentTerminatorSuffix), required: false);
            SourceExpression.Validate(body, nameof(body), required: false);
            SourceExpression.Validate(gS02, nameof(gS02), required: false);
            SourceExpression.Validate(gS03, nameof(gS03), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/EncodeV2/ResolveByName";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["agreementName"] = SourceExpressionConverter.ConvertO(agreementName);
                if (dataElementSeparator != null)
                    callPayload.Queries["dataElementSeparator"] = SourceExpressionConverter.ConvertO(dataElementSeparator);
                if (componentSeparator != null)
                    callPayload.Queries["componentSeparator"] = SourceExpressionConverter.ConvertO(componentSeparator);
                if (replacementCharacter != null)
                    callPayload.Queries["replacementCharacter"] = SourceExpressionConverter.ConvertO(replacementCharacter);
                if (segmentTerminator != null)
                    callPayload.Queries["segmentTerminator"] = SourceExpressionConverter.ConvertO(segmentTerminator);
                if (segmentTerminatorSuffix != null)
                    callPayload.Queries["segmentTerminatorSuffix"] = SourceExpressionConverter.Convert(segmentTerminatorSuffix);
                if (gS02 != null)
                    callPayload.Headers["GS02"] = SourceExpressionConverter.ConvertO(gS02);
                if (gS03 != null)
                    callPayload.Headers["GS03"] = SourceExpressionConverter.ConvertO(gS03);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<X12EncodeV2Response>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "x12")]
        public IBodyWorkflowAction<X12BatchEncodeResponse> BatchEncodeResolveByPartnerIdentities([WorkflowExpression] Func<string> senderIdentifier, [WorkflowExpression] Func<string> senderQualifier, [WorkflowExpression] Func<string> receiverIdentifier, [WorkflowExpression] Func<string> receiverQualifier, [WorkflowExpression] Func<string> messagesToBatchbatchName = null, [WorkflowExpression] Func<string> messagesToBatchpartitionName = null, [WorkflowExpression] Func<BatchItem[]> messagesToBatchitems = null, [WorkflowExpression] Func<int> dataElementSeparator = null, [WorkflowExpression] Func<int> componentSeparator = null, [WorkflowExpression] Func<int> replacementCharacter = null, [WorkflowExpression] Func<int> segmentTerminator = null, [WorkflowExpression] Func<segmentTerminatorSuffixInput> segmentTerminatorSuffix = null)
        {
            SourceExpression.Validate(senderIdentifier, nameof(senderIdentifier), required: true);
            SourceExpression.Validate(senderQualifier, nameof(senderQualifier), required: true);
            SourceExpression.Validate(receiverIdentifier, nameof(receiverIdentifier), required: true);
            SourceExpression.Validate(receiverQualifier, nameof(receiverQualifier), required: true);
            SourceExpression.Validate(messagesToBatchbatchName, nameof(messagesToBatchbatchName), required: false);
            SourceExpression.Validate(messagesToBatchpartitionName, nameof(messagesToBatchpartitionName), required: false);
            SourceExpression.Validate(messagesToBatchitems, nameof(messagesToBatchitems), required: false);
            SourceExpression.Validate(dataElementSeparator, nameof(dataElementSeparator), required: false);
            SourceExpression.Validate(componentSeparator, nameof(componentSeparator), required: false);
            SourceExpression.Validate(replacementCharacter, nameof(replacementCharacter), required: false);
            SourceExpression.Validate(segmentTerminator, nameof(segmentTerminator), required: false);
            SourceExpression.Validate(segmentTerminatorSuffix, nameof(segmentTerminatorSuffix), required: false);
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
                if (componentSeparator != null)
                    callPayload.Queries["componentSeparator"] = SourceExpressionConverter.ConvertO(componentSeparator);
                if (replacementCharacter != null)
                    callPayload.Queries["replacementCharacter"] = SourceExpressionConverter.ConvertO(replacementCharacter);
                if (segmentTerminator != null)
                    callPayload.Queries["segmentTerminator"] = SourceExpressionConverter.ConvertO(segmentTerminator);
                if (segmentTerminatorSuffix != null)
                    callPayload.Queries["segmentTerminatorSuffix"] = SourceExpressionConverter.Convert(segmentTerminatorSuffix);
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

            return new ApiConnectionAction<X12BatchEncodeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "x12")]
        public IBodyWorkflowAction<EdiEncodeResponse> EncodeResolveByPartnerIdentities([WorkflowExpression] Func<string> senderIdentifier, [WorkflowExpression] Func<string> senderQualifier, [WorkflowExpression] Func<string> receiverIdentifier, [WorkflowExpression] Func<string> receiverQualifier, [WorkflowExpression] Func<int> dataElementSeparator = null, [WorkflowExpression] Func<int> componentSeparator = null, [WorkflowExpression] Func<int> replacementCharacter = null, [WorkflowExpression] Func<int> segmentTerminator = null, [WorkflowExpression] Func<segmentTerminatorSuffixInput> segmentTerminatorSuffix = null, [WorkflowExpression] Func<string> body = null, [WorkflowExpression] Func<string> gS02 = null, [WorkflowExpression] Func<string> gS03 = null)
        {
            SourceExpression.Validate(senderIdentifier, nameof(senderIdentifier), required: true);
            SourceExpression.Validate(senderQualifier, nameof(senderQualifier), required: true);
            SourceExpression.Validate(receiverIdentifier, nameof(receiverIdentifier), required: true);
            SourceExpression.Validate(receiverQualifier, nameof(receiverQualifier), required: true);
            SourceExpression.Validate(dataElementSeparator, nameof(dataElementSeparator), required: false);
            SourceExpression.Validate(componentSeparator, nameof(componentSeparator), required: false);
            SourceExpression.Validate(replacementCharacter, nameof(replacementCharacter), required: false);
            SourceExpression.Validate(segmentTerminator, nameof(segmentTerminator), required: false);
            SourceExpression.Validate(segmentTerminatorSuffix, nameof(segmentTerminatorSuffix), required: false);
            SourceExpression.Validate(body, nameof(body), required: false);
            SourceExpression.Validate(gS02, nameof(gS02), required: false);
            SourceExpression.Validate(gS03, nameof(gS03), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/encode/resolvebyidentities";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["senderIdentifier"] = SourceExpressionConverter.ConvertO(senderIdentifier);
                callPayload.Queries["senderQualifier"] = SourceExpressionConverter.ConvertO(senderQualifier);
                callPayload.Queries["receiverIdentifier"] = SourceExpressionConverter.ConvertO(receiverIdentifier);
                callPayload.Queries["receiverQualifier"] = SourceExpressionConverter.ConvertO(receiverQualifier);
                if (dataElementSeparator != null)
                    callPayload.Queries["dataElementSeparator"] = SourceExpressionConverter.ConvertO(dataElementSeparator);
                if (componentSeparator != null)
                    callPayload.Queries["componentSeparator"] = SourceExpressionConverter.ConvertO(componentSeparator);
                if (replacementCharacter != null)
                    callPayload.Queries["replacementCharacter"] = SourceExpressionConverter.ConvertO(replacementCharacter);
                if (segmentTerminator != null)
                    callPayload.Queries["segmentTerminator"] = SourceExpressionConverter.ConvertO(segmentTerminator);
                if (segmentTerminatorSuffix != null)
                    callPayload.Queries["segmentTerminatorSuffix"] = SourceExpressionConverter.Convert(segmentTerminatorSuffix);
                if (gS02 != null)
                    callPayload.Headers["GS02"] = SourceExpressionConverter.ConvertO(gS02);
                if (gS03 != null)
                    callPayload.Headers["GS03"] = SourceExpressionConverter.ConvertO(gS03);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<EdiEncodeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "x12")]
        public IBodyWorkflowAction<X12EncodeV2Response> EncodeV2ResolveByPartnerIdentities([WorkflowExpression] Func<string> senderIdentifier, [WorkflowExpression] Func<string> senderQualifier, [WorkflowExpression] Func<string> receiverIdentifier, [WorkflowExpression] Func<string> receiverQualifier, [WorkflowExpression] Func<int> dataElementSeparator = null, [WorkflowExpression] Func<int> componentSeparator = null, [WorkflowExpression] Func<int> replacementCharacter = null, [WorkflowExpression] Func<int> segmentTerminator = null, [WorkflowExpression] Func<segmentTerminatorSuffixInput> segmentTerminatorSuffix = null, [WorkflowExpression] Func<string> body = null, [WorkflowExpression] Func<string> gS02 = null, [WorkflowExpression] Func<string> gS03 = null)
        {
            SourceExpression.Validate(senderIdentifier, nameof(senderIdentifier), required: true);
            SourceExpression.Validate(senderQualifier, nameof(senderQualifier), required: true);
            SourceExpression.Validate(receiverIdentifier, nameof(receiverIdentifier), required: true);
            SourceExpression.Validate(receiverQualifier, nameof(receiverQualifier), required: true);
            SourceExpression.Validate(dataElementSeparator, nameof(dataElementSeparator), required: false);
            SourceExpression.Validate(componentSeparator, nameof(componentSeparator), required: false);
            SourceExpression.Validate(replacementCharacter, nameof(replacementCharacter), required: false);
            SourceExpression.Validate(segmentTerminator, nameof(segmentTerminator), required: false);
            SourceExpression.Validate(segmentTerminatorSuffix, nameof(segmentTerminatorSuffix), required: false);
            SourceExpression.Validate(body, nameof(body), required: false);
            SourceExpression.Validate(gS02, nameof(gS02), required: false);
            SourceExpression.Validate(gS03, nameof(gS03), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/EncodeV2/ResolveByIdentities";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["senderIdentifier"] = SourceExpressionConverter.ConvertO(senderIdentifier);
                callPayload.Queries["senderQualifier"] = SourceExpressionConverter.ConvertO(senderQualifier);
                callPayload.Queries["receiverIdentifier"] = SourceExpressionConverter.ConvertO(receiverIdentifier);
                callPayload.Queries["receiverQualifier"] = SourceExpressionConverter.ConvertO(receiverQualifier);
                if (dataElementSeparator != null)
                    callPayload.Queries["dataElementSeparator"] = SourceExpressionConverter.ConvertO(dataElementSeparator);
                if (componentSeparator != null)
                    callPayload.Queries["componentSeparator"] = SourceExpressionConverter.ConvertO(componentSeparator);
                if (replacementCharacter != null)
                    callPayload.Queries["replacementCharacter"] = SourceExpressionConverter.ConvertO(replacementCharacter);
                if (segmentTerminator != null)
                    callPayload.Queries["segmentTerminator"] = SourceExpressionConverter.ConvertO(segmentTerminator);
                if (segmentTerminatorSuffix != null)
                    callPayload.Queries["segmentTerminatorSuffix"] = SourceExpressionConverter.Convert(segmentTerminatorSuffix);
                if (gS02 != null)
                    callPayload.Headers["GS02"] = SourceExpressionConverter.ConvertO(gS02);
                if (gS03 != null)
                    callPayload.Headers["GS03"] = SourceExpressionConverter.ConvertO(gS03);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<X12EncodeV2Response>(BuildSourceInput);
        }
    }

    public class X12Triggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ReplicableControlNumberContent[]> OnModifiedControlNumber([WorkflowExpression] Func<string> startSyncTime = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(startSyncTime, nameof(startSyncTime), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/triggers/onModifiedControlNumber";
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

    public class EdiDecodeResponseX12DecodeResponseX12AcknowledgementResponse
    {
        public string InterchangeControlNumber { get; set; }
        public string[] GroupControlNumbers { get; set; }
        public X12DecodeResponse[] GoodMessages { get; set; }
        public X12DecodeResponse[] BadMessages { get; set; }
        public X12AcknowledgementResponse[] GeneratedAcks { get; set; }
        public X12AcknowledgementResponse[] ReceivedAcks { get; set; }
        public string AgreementName { get; set; }
        public string GuestPartnerName { get; set; }
        public string HostPartnerName { get; set; }
        public string ReceiverIdentifier { get; set; }
        public string ReceiverQualifier { get; set; }
        public string SenderIdentifier { get; set; }
        public string SenderQualifier { get; set; }
    }

    public class X12DecodeResponse
    {
        public InterchangeEnvelope InterchangeEnvelope { get; set; }
        public X12FunctionalGroupEnvelope FunctionalGroupEnvelope { get; set; }
        public TransactionSet TransactionSet { get; set; }
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

    public class InterchangeEnvelope
    {
        [JsonProperty("ISA_Segment")]
        public string ISASegment { get; set; }
        public string ISA05 { get; set; }
        public string ISA06 { get; set; }
        public string ISA07 { get; set; }
        public string ISA08 { get; set; }
        public string ISA09 { get; set; }
        public string ISA10 { get; set; }
        public string ISA11 { get; set; }
        public string ISA12 { get; set; }
        public string ISA13 { get; set; }
        public string ISA14 { get; set; }
        public string ISA15 { get; set; }
        public string IEA01 { get; set; }
        public string IEA02 { get; set; }
    }

    public class X12FunctionalGroupEnvelope
    {
        [JsonProperty("GS_Segment")]
        public string GSSegment { get; set; }
        public string GS01 { get; set; }
        public string GS02 { get; set; }
        public string GS03 { get; set; }
        public string GS04 { get; set; }
        public string GS05 { get; set; }
        public string GS06 { get; set; }
        public string GS07 { get; set; }
        public string GS08 { get; set; }
        public string GE01 { get; set; }
        public string GE02 { get; set; }
    }

    public class TransactionSet
    {
        public string ST01 { get; set; }
        public string ST02 { get; set; }
        public string ST03 { get; set; }
        public string SE01 { get; set; }
        public string SE02 { get; set; }
        public string SE03 { get; set; }
    }

    public class X12AcknowledgementResponse
    {
        public X12FunctionalAcknowledgement FunctionalAcknowledgement { get; set; }
        public X12TechnicalAcknowledgement TechnicalAcknowledgement { get; set; }
        public string AckPayload { get; set; }
        public bool IsFunctionalAck { get; set; }
        public bool IsTechnicalAck { get; set; }
        public bool TechnicalAckExpected { get; set; }
        public bool FunctionalAckExpected { get; set; }
        public string MessageType { get; set; }
    }

    public class X12FunctionalAcknowledgement
    {
        public AK1FunctionalGroupResponseHeader Header { get; set; }
        public AK2Loop[] AK2Loop { get; set; }
        public AK9FunctionalGroupResponseTrailer Trailer { get; set; }
    }

    public class AK1FunctionalGroupResponseHeader
    {
        public string AK101 { get; set; }
        public string AK102 { get; set; }
    }

    public class AK2Loop
    {
        public string AK201 { get; set; }
        public string AK202 { get; set; }
        public string AK203 { get; set; }
        public DataSegmentNote[] AK3Loop { get; set; }
        public AK2LoopAK501Type AK501 { get; set; }
        public AK2LoopAK502Type AK502 { get; set; }
        public AK2LoopAK503Type AK503 { get; set; }
        public AK2LoopAK504Type AK504 { get; set; }
        public AK2LoopAK505Type AK505 { get; set; }
        public AK2LoopAK506Type AK506 { get; set; }
    }

    public class DataSegmentNote
    {
        public string AK301 { get; set; }
        public string AK302 { get; set; }
        public string AK303 { get; set; }
        public DataSegmentNoteAK304Type AK304 { get; set; }
        public DataElementNote[] AK4DataElementNote { get; set; }
    }

    public enum DataSegmentNoteAK304Type
    {
        UnrecognizedSegmentId,
        UnexpectedSegment,
        MandatorySegmentMissing,
        LoopOccursOverMaximumTimes,
        SegmentExceedsMaximumUse,
        SegmentNotInDefinedTS,
        SegmentNotInProperSequence,
        SegmentHasDataElementErrors
    }

    public class DataElementNote
    {
        public CompositeDataElement AK401 { get; set; }
        public string AK402 { get; set; }
        public DataElementNoteAK403Type AK403 { get; set; }
        public string AK404 { get; set; }
    }

    public class CompositeDataElement
    {
        [JsonProperty("AK41.1")]
        public string AK411 { get; set; }

        [JsonProperty("AK41.2")]
        public string AK412 { get; set; }

        [JsonProperty("AK41.3")]
        public string AK413 { get; set; }
    }

    public enum DataElementNoteAK403Type
    {
        MandatoryDataElementMissing,
        ConditionalRequiredDataElementMissing,
        TooManyDataElementsCode,
        DataElementTooShortCode,
        DataElementTooLongCode,
        InvalidCharacterInDataElementCode,
        InvalidCodeValueCode,
        InvalidDateCode,
        InvalidTimeCode,
        ExclusionConditionViolatedCode
    }

    public enum AK2LoopAK501Type
    {
        A,
        E,
        M,
        P,
        R,
        W,
        X
    }

    public enum AK2LoopAK502Type
    {
        NotSupported,
        TrailerMissing,
        ControlNumberMismatch,
        SegmentCountMismatch,
        OneOrMoreSegmentsInError,
        MissingOrInvalidIdentifier,
        MissingOrInvalidControlNumber
    }

    public enum AK2LoopAK503Type
    {
        NotSupported,
        TrailerMissing,
        ControlNumberMismatch,
        SegmentCountMismatch,
        OneOrMoreSegmentsInError,
        MissingOrInvalidIdentifier,
        MissingOrInvalidControlNumber
    }

    public enum AK2LoopAK504Type
    {
        NotSupported,
        TrailerMissing,
        ControlNumberMismatch,
        SegmentCountMismatch,
        OneOrMoreSegmentsInError,
        MissingOrInvalidIdentifier,
        MissingOrInvalidControlNumber
    }

    public enum AK2LoopAK505Type
    {
        NotSupported,
        TrailerMissing,
        ControlNumberMismatch,
        SegmentCountMismatch,
        OneOrMoreSegmentsInError,
        MissingOrInvalidIdentifier,
        MissingOrInvalidControlNumber
    }

    public enum AK2LoopAK506Type
    {
        NotSupported,
        TrailerMissing,
        ControlNumberMismatch,
        SegmentCountMismatch,
        OneOrMoreSegmentsInError,
        MissingOrInvalidIdentifier,
        MissingOrInvalidControlNumber
    }

    public class AK9FunctionalGroupResponseTrailer
    {
        public AK9FunctionalGroupResponseTrailerAK901Type AK901 { get; set; }
        public string AK902 { get; set; }
        public string AK903 { get; set; }
        public string AK904 { get; set; }
        public AK9FunctionalGroupResponseTrailerAK905Type AK905 { get; set; }
        public AK9FunctionalGroupResponseTrailerAK906Type AK906 { get; set; }
        public AK9FunctionalGroupResponseTrailerAK907Type AK907 { get; set; }
        public AK9FunctionalGroupResponseTrailerAK908Type AK908 { get; set; }
        public AK9FunctionalGroupResponseTrailerAK909Type AK909 { get; set; }
    }

    public enum AK9FunctionalGroupResponseTrailerAK901Type
    {
        A,
        E,
        M,
        P,
        R,
        W,
        X
    }

    public enum AK9FunctionalGroupResponseTrailerAK905Type
    {
        NotSupported,
        GroupVersionNotSupported,
        ControlNumberMismatch,
        NumberOfTransactionSetMismatch,
        DuplicateGroupControlNumber
    }

    public enum AK9FunctionalGroupResponseTrailerAK906Type
    {
        NotSupported,
        GroupVersionNotSupported,
        ControlNumberMismatch,
        NumberOfTransactionSetMismatch,
        DuplicateGroupControlNumber
    }

    public enum AK9FunctionalGroupResponseTrailerAK907Type
    {
        NotSupported,
        GroupVersionNotSupported,
        ControlNumberMismatch,
        NumberOfTransactionSetMismatch,
        DuplicateGroupControlNumber
    }

    public enum AK9FunctionalGroupResponseTrailerAK908Type
    {
        NotSupported,
        GroupVersionNotSupported,
        ControlNumberMismatch,
        NumberOfTransactionSetMismatch,
        DuplicateGroupControlNumber
    }

    public enum AK9FunctionalGroupResponseTrailerAK909Type
    {
        NotSupported,
        GroupVersionNotSupported,
        ControlNumberMismatch,
        NumberOfTransactionSetMismatch,
        DuplicateGroupControlNumber
    }

    public class X12TechnicalAcknowledgement
    {
        public string TA101 { get; set; }
        public string TA102 { get; set; }
        public string TA103 { get; set; }
        public X12TechnicalAcknowledgementTA104Type TA104 { get; set; }
        public string TA105 { get; set; }
    }

    public enum X12TechnicalAcknowledgementTA104Type
    {
        A,
        E,
        M,
        P,
        R,
        W,
        X
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

    public class X12BatchEncodeResponse
    {
        public InterchangeBatchEnvelope Interchange { get; set; }
        public string BatchName { get; set; }
        public string PartitionName { get; set; }
        public JToken Content { get; set; }
        public BatchItemError[] BadMessages { get; set; }
        public EdiAgreementProperties AgreementProperties { get; set; }
        public Delimiters Delimiters { get; set; }
    }

    public class InterchangeBatchEnvelope
    {
        public string InterchangeControlNumber { get; set; }
        public X12FunctionalGroupBatchEnvelope[] FunctionalGroups { get; set; }

        [JsonProperty("ISA_Segment")]
        public string ISASegment { get; set; }
        public string ISA05 { get; set; }
        public string ISA06 { get; set; }
        public string ISA07 { get; set; }
        public string ISA08 { get; set; }
        public string ISA09 { get; set; }
        public string ISA10 { get; set; }
        public string ISA11 { get; set; }
        public string ISA12 { get; set; }
        public string ISA13 { get; set; }
        public string ISA14 { get; set; }
        public string ISA15 { get; set; }
        public string IEA01 { get; set; }
        public string IEA02 { get; set; }
    }

    public class X12FunctionalGroupBatchEnvelope
    {
        public string GroupControlNumber { get; set; }
        public TransactionSetBatchEnvelope[] TransactionSets { get; set; }

        [JsonProperty("GS_Segment")]
        public string GSSegment { get; set; }
        public string GS01 { get; set; }
        public string GS02 { get; set; }
        public string GS03 { get; set; }
        public string GS04 { get; set; }
        public string GS05 { get; set; }
        public string GS06 { get; set; }
        public string GS07 { get; set; }
        public string GS08 { get; set; }
        public string GE01 { get; set; }
        public string GE02 { get; set; }
    }

    public class TransactionSetBatchEnvelope
    {
        public string TransactionSetControlNumber { get; set; }
        public string MessageId { get; set; }
        public string ST01 { get; set; }
        public string ST02 { get; set; }
        public string ST03 { get; set; }
        public string SE01 { get; set; }
        public string SE02 { get; set; }
        public string SE03 { get; set; }
    }

    public class BatchItemError
    {
        public string MessageId { get; set; }
        public string Error { get; set; }
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

    public class BatchItem
    {
        public string MessageId { get; set; }
        public JToken Content { get; set; }
    }

    public enum segmentTerminatorSuffixInput
    {
        NotSpecified,
        None,
        CR,
        LF,
        CRLF
    }

    public class EdiEncodeResponse
    {
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

    public class X12EncodeV2Response
    {
        public InterchangeBatchEnvelope Interchange { get; set; }
        public JToken Content { get; set; }
        public EdiAgreementProperties AgreementProperties { get; set; }
        public Delimiters Delimiters { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.X12;

    public partial class WorkflowManagedActions
    {
        public X12Actions X12(string connectionId) => new X12Actions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public X12Triggers X12(string connectionId) => new X12Triggers(connectionId);
    }
}