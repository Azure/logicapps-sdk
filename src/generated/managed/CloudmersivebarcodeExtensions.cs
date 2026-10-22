//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cloudmersivebarcode
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CloudmersivebarcodeActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivebarcode")]
        public IBodyWorkflowAction<BarcodeLookupResponse, ApiConnectionActionConfiguration> BarcodeLookupEanLookup(Expression<Func<string>> value = null)
        {
            var __workflow_value = WorkflowExpression.Compile(value, nameof(value), required: false);
            return new DeferredBodyAction<BarcodeLookupResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/barcode/lookup/ean";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_value);
                return new ApiConnectionAction<BarcodeLookupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivebarcode")]
        public IBodyWorkflowAction<BarcodeScanResult, ApiConnectionActionConfiguration> BarcodeScanImage(Expression<Func<object>> imageFile)
        {
            var __workflow_imageFile = WorkflowExpression.Compile(imageFile, nameof(imageFile), required: true);
            return new DeferredBodyAction<BarcodeScanResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/barcode/scan/image";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<BarcodeScanResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivebarcode")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> GenerateBarcodeQRCode(Expression<Func<string>> value = null)
        {
            var __workflow_value = WorkflowExpression.Compile(value, nameof(value), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/barcode/generate/qrcode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_value);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivebarcode")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> GenerateBarcodeUPCA(Expression<Func<string>> value = null)
        {
            var __workflow_value = WorkflowExpression.Compile(value, nameof(value), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/barcode/generate/upc-a";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_value);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivebarcode")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> GenerateBarcodeUPCE(Expression<Func<string>> value = null)
        {
            var __workflow_value = WorkflowExpression.Compile(value, nameof(value), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/barcode/generate/upc-e";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_value);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivebarcode")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> GenerateBarcodeEAN13(Expression<Func<string>> value = null)
        {
            var __workflow_value = WorkflowExpression.Compile(value, nameof(value), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/barcode/generate/ean-13";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_value);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivebarcode")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> GenerateBarcodeEAN8(Expression<Func<string>> value = null)
        {
            var __workflow_value = WorkflowExpression.Compile(value, nameof(value), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/barcode/generate/ean-8";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_value);
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
