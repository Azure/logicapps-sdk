//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Vantage365imaging
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Vantage365imagingActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vantage365imaging")]
        public IBodyWorkflowAction<GenerateBarCodeResponse> GenerateBarCode([WorkflowExpression] Func<typeofcodeInput> typeofcode, [WorkflowExpression] Func<string> texttoencode, [WorkflowExpression] Func<int> height = null, [WorkflowExpression] Func<int> width = null)
        {
            SourceExpression.Validate(typeofcode, nameof(typeofcode), required: true);
            SourceExpression.Validate(texttoencode, nameof(texttoencode), required: true);
            SourceExpression.Validate(height, nameof(height), required: false);
            SourceExpression.Validate(width, nameof(width), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/5884ce85663b4aba83128a0098112024/triggers/manual/paths/invoke";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2016-10-01");
                callPayload.Queries["sp"] = Convert.ToString("/triggers/manual/run");
                callPayload.Queries["sv"] = Convert.ToString("1.0");
                callPayload.Queries["sig"] = Convert.ToString("cFQmyp6LsHfQTy18hqygjAVLuXSHR-FMtcRg_CxLIkA");
                callPayload.Queries["height"] = Convert.ToString(100);
                if (height != null)
                    callPayload.Queries["height"] = SourceExpressionConverter.ConvertO(height);
                callPayload.Queries["width"] = Convert.ToString(100);
                if (width != null)
                    callPayload.Queries["width"] = SourceExpressionConverter.ConvertO(width);
                callPayload.Queries["typeofcode"] = SourceExpressionConverter.Convert(typeofcode);
                callPayload.Queries["texttoencode"] = SourceExpressionConverter.ConvertO(texttoencode);
                return callPayload;
            }

            return new ApiConnectionAction<GenerateBarCodeResponse>(BuildSourceInput);
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