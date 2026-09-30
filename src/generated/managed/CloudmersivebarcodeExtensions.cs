//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cloudmersivebarcode
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CloudmersivebarcodeActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivebarcode")]
        public IBodyWorkflowAction<BarcodeLookupResponse> BarcodeLookupEanLookup([WorkflowExpression] Func<string> value = null)
        {
            SourceExpression.Validate(value, nameof(value), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/barcode/lookup/ean";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(value);
                return callPayload;
            }

            return new ApiConnectionAction<BarcodeLookupResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivebarcode")]
        public IBodyWorkflowAction<string> GenerateBarcodeQRCode([WorkflowExpression] Func<string> value = null)
        {
            SourceExpression.Validate(value, nameof(value), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/barcode/generate/qrcode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(value);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivebarcode")]
        public IBodyWorkflowAction<string> GenerateBarcodeUPCA([WorkflowExpression] Func<string> value = null)
        {
            SourceExpression.Validate(value, nameof(value), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/barcode/generate/upc-a";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(value);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivebarcode")]
        public IBodyWorkflowAction<string> GenerateBarcodeUPCE([WorkflowExpression] Func<string> value = null)
        {
            SourceExpression.Validate(value, nameof(value), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/barcode/generate/upc-e";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(value);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivebarcode")]
        public IBodyWorkflowAction<string> GenerateBarcodeEAN13([WorkflowExpression] Func<string> value = null)
        {
            SourceExpression.Validate(value, nameof(value), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/barcode/generate/ean-13";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(value);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivebarcode")]
        public IBodyWorkflowAction<string> GenerateBarcodeEAN8([WorkflowExpression] Func<string> value = null)
        {
            SourceExpression.Validate(value, nameof(value), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/barcode/generate/ean-8";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(value);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }
    }

    public class CloudmersivebarcodeTriggers([ConnectionName] string connectionId)
    {
    }

    public class BarcodeLookupResponse
    {
        public bool Successful { get; set; }
        public ProductMatch[] Matches { get; set; }
    }

    public class ProductMatch
    {
        public string EAN { get; set; }
        public string Title { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Cloudmersivebarcode;

    public partial class WorkflowManagedActions
    {
        public CloudmersivebarcodeActions Cloudmersivebarcode(string connectionId) => new CloudmersivebarcodeActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CloudmersivebarcodeTriggers Cloudmersivebarcode(string connectionId) => new CloudmersivebarcodeTriggers(connectionId);
    }
}