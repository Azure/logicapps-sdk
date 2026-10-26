//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Vantage365imaging
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Vantage365imagingActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vantage365imaging")]
        public IBodyWorkflowAction<GenerateBarCodeResponse, ApiConnectionActionConfiguration> GenerateBarCode(Expression<Func<typeofcodeInput>> typeofcode, Expression<Func<string>> texttoencode, Expression<Func<int>> height = null, Expression<Func<int>> width = null)
        {
            var __workflow_typeofcode = WorkflowExpression.Compile(typeofcode, nameof(typeofcode), required: true);
            var __workflow_texttoencode = WorkflowExpression.Compile(texttoencode, nameof(texttoencode), required: true);
            var __workflow_height = WorkflowExpression.Compile(height, nameof(height), required: false);
            var __workflow_width = WorkflowExpression.Compile(width, nameof(width), required: false);
            return new DeferredBodyAction<GenerateBarCodeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/5884ce85663b4aba83128a0098112024/triggers/manual/paths/invoke";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2016-10-01");
                callPayload.Queries["sp"] = Convert.ToString("/triggers/manual/run");
                callPayload.Queries["sv"] = Convert.ToString("1.0");
                callPayload.Queries["sig"] = Convert.ToString("cFQmyp6LsHfQTy18hqygjAVLuXSHR-FMtcRg_CxLIkA");
                callPayload.Queries["height"] = Convert.ToString(100);
                if (__workflow_height != null)
                    callPayload.Queries["height"] = ExpressionConverter.Convert(__workflow_height);
                callPayload.Queries["width"] = Convert.ToString(100);
                if (__workflow_width != null)
                    callPayload.Queries["width"] = ExpressionConverter.Convert(__workflow_width);
                callPayload.Queries["typeofcode"] = ExpressionConverter.Convert(__workflow_typeofcode);
                callPayload.Queries["texttoencode"] = ExpressionConverter.Convert(__workflow_texttoencode);
                return new ApiConnectionAction<GenerateBarCodeResponse>(callPayload);
            });
        }
    }

    public class Vantage365imagingTriggers([ConnectionName] string connectionId)
    {
    }

    public class GenerateBarCodeResponse
    {
        [JsonProperty("barcodegraphic")]
        public string Barcodegraphic { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum typeofcodeInput
    {
        Aztec,
        [EnumMember(Value = "Code 39")]
        Code39,
        [EnumMember(Value = "Code 93")]
        Code93,
        [EnumMember(Value = "Code 128")]
        Code128,
        Codabar,
        Datamatrix,
        [EnumMember(Value = "EAN-8")]
        EAN8,
        [EnumMember(Value = "EAN-13")]
        EAN13,
        ITF,
        [EnumMember(Value = "MSI Plessey")]
        MSIPlessey,
        PDF417,
        [EnumMember(Value = "QR Code")]
        QRCode,
        [EnumMember(Value = "UPC-A")]
        UPCA,
        [EnumMember(Value = "UPC-E")]
        UPCE
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Vantage365imaging;

    public partial class WorkflowManagedActions
    {
        public Vantage365imagingActions Vantage365imaging(string connectionId) => new Vantage365imagingActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Vantage365imagingTriggers Vantage365imaging(string connectionId) => new Vantage365imagingTriggers(connectionId);
    }
}