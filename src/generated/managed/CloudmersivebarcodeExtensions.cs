//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cloudmersivebarcode
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CloudmersivebarcodeActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivebarcode")]
        [WorkflowExpressionFactory(nameof(__BuildBarcodeLookupEanLookup))]
        public IBodyWorkflowAction<BarcodeLookupResponse> BarcodeLookupEanLookup([WorkflowExpression] Func<string> value = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BarcodeLookupResponse> __BuildBarcodeLookupEanLookup(WorkflowValue<string> value = null)
        {
            WorkflowValue.Validate(value, nameof(value), required: false);
            return new DeferredBodyAction<BarcodeLookupResponse>(() =>
            {
                var apiCallPath = "/barcode/lookup/ean";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(value);
                return new ApiConnectionAction<BarcodeLookupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivebarcode")]
        [WorkflowExpressionFactory(nameof(__BuildBarcodeScanImage))]
        public IBodyWorkflowAction<BarcodeScanResult> BarcodeScanImage([WorkflowExpression] Func<object> imageFile)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BarcodeScanResult> __BuildBarcodeScanImage(WorkflowValue<object> imageFile)
        {
            WorkflowValue.Validate(imageFile, nameof(imageFile), required: true);
            return new DeferredBodyAction<BarcodeScanResult>(() =>
            {
                var apiCallPath = "/barcode/scan/image";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<BarcodeScanResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivebarcode")]
        [WorkflowExpressionFactory(nameof(__BuildGenerateBarcodeQRCode))]
        public IBodyWorkflowAction<string> GenerateBarcodeQRCode([WorkflowExpression] Func<string> value = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildGenerateBarcodeQRCode(WorkflowValue<string> value = null)
        {
            WorkflowValue.Validate(value, nameof(value), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/barcode/generate/qrcode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(value);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivebarcode")]
        [WorkflowExpressionFactory(nameof(__BuildGenerateBarcodeUPCA))]
        public IBodyWorkflowAction<string> GenerateBarcodeUPCA([WorkflowExpression] Func<string> value = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildGenerateBarcodeUPCA(WorkflowValue<string> value = null)
        {
            WorkflowValue.Validate(value, nameof(value), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/barcode/generate/upc-a";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(value);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivebarcode")]
        [WorkflowExpressionFactory(nameof(__BuildGenerateBarcodeUPCE))]
        public IBodyWorkflowAction<string> GenerateBarcodeUPCE([WorkflowExpression] Func<string> value = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildGenerateBarcodeUPCE(WorkflowValue<string> value = null)
        {
            WorkflowValue.Validate(value, nameof(value), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/barcode/generate/upc-e";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(value);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivebarcode")]
        [WorkflowExpressionFactory(nameof(__BuildGenerateBarcodeEAN13))]
        public IBodyWorkflowAction<string> GenerateBarcodeEAN13([WorkflowExpression] Func<string> value = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildGenerateBarcodeEAN13(WorkflowValue<string> value = null)
        {
            WorkflowValue.Validate(value, nameof(value), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/barcode/generate/ean-13";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(value);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivebarcode")]
        [WorkflowExpressionFactory(nameof(__BuildGenerateBarcodeEAN8))]
        public IBodyWorkflowAction<string> GenerateBarcodeEAN8([WorkflowExpression] Func<string> value = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildGenerateBarcodeEAN8(WorkflowValue<string> value = null)
        {
            WorkflowValue.Validate(value, nameof(value), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/barcode/generate/ean-8";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(value);
                return new ApiConnectionAction<string>(callPayload);
            });
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

    public class BarcodeScanResult
    {
        public bool Successful { get; set; }
        public string BarcodeType { get; set; }
        public string RawText { get; set; }
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
