//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Integrablepdf
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class IntegrablepdfActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "integrablepdf")]
        public IBodyWorkflowAction<string> LockPdf([WorkflowExpression] Func<string> lockPdfInputfileContent, [WorkflowExpression] Func<string> lockPdfInputpermissionsPassword, [WorkflowExpression] Func<bool> lockPdfInputallowAccessibility = null, [WorkflowExpression] Func<bool> lockPdfInputallowCopy = null, [WorkflowExpression] Func<bool> lockPdfInputallowDocumentAssembly = null, [WorkflowExpression] Func<bool> lockPdfInputallowEdit = null, [WorkflowExpression] Func<bool> lockPdfInputallowFormFilling = null, [WorkflowExpression] Func<bool> lockPdfInputallowPrint = null, [WorkflowExpression] Func<bool> lockPdfInputallowUpdateAnnotationsAndFields = null, [WorkflowExpression] Func<string> lockPdfInputdocumentOpenPassword = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/pdf/lock";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/octet-stream");
                var lockPdfInput = new JObject();
                var lockPdfInputpropCount = 0;
                if (lockPdfInputallowAccessibility != null)
                {
                    lockPdfInput["allowAccessibility"] = SourceExpressionConverter.ConvertToken(lockPdfInputallowAccessibility);
                    lockPdfInputpropCount++;
                }

                if (lockPdfInputallowCopy != null)
                {
                    lockPdfInput["allowCopy"] = SourceExpressionConverter.ConvertToken(lockPdfInputallowCopy);
                    lockPdfInputpropCount++;
                }

                if (lockPdfInputallowDocumentAssembly != null)
                {
                    lockPdfInput["allowDocumentAssembly"] = SourceExpressionConverter.ConvertToken(lockPdfInputallowDocumentAssembly);
                    lockPdfInputpropCount++;
                }

                if (lockPdfInputallowEdit != null)
                {
                    lockPdfInput["allowEdit"] = SourceExpressionConverter.ConvertToken(lockPdfInputallowEdit);
                    lockPdfInputpropCount++;
                }

                if (lockPdfInputallowFormFilling != null)
                {
                    lockPdfInput["allowFormFilling"] = SourceExpressionConverter.ConvertToken(lockPdfInputallowFormFilling);
                    lockPdfInputpropCount++;
                }

                if (lockPdfInputallowPrint != null)
                {
                    lockPdfInput["allowPrint"] = SourceExpressionConverter.ConvertToken(lockPdfInputallowPrint);
                    lockPdfInputpropCount++;
                }

                if (lockPdfInputallowUpdateAnnotationsAndFields != null)
                {
                    lockPdfInput["allowUpdateAnnotationsAndFields"] = SourceExpressionConverter.ConvertToken(lockPdfInputallowUpdateAnnotationsAndFields);
                    lockPdfInputpropCount++;
                }

                if (lockPdfInputdocumentOpenPassword != null)
                {
                    lockPdfInput["documentOpenPassword"] = SourceExpressionConverter.ConvertToken(lockPdfInputdocumentOpenPassword);
                    lockPdfInputpropCount++;
                }

                lockPdfInputpropCount++;
                lockPdfInput["fileContent"] = SourceExpressionConverter.ConvertToken(lockPdfInputfileContent);
                lockPdfInputpropCount++;
                lockPdfInput["permissionsPassword"] = SourceExpressionConverter.ConvertToken(lockPdfInputpermissionsPassword);
                if (lockPdfInputpropCount > 0)
                {
                    callPayload.Body = lockPdfInput;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "integrablepdf")]
        public IBodyWorkflowAction<string> MergePdf([WorkflowExpression] Func<string> mergePdfInput1stFileContent, [WorkflowExpression] Func<string> mergePdfInput2ndFileContent, [WorkflowExpression] Func<string> mergePdfInput3rdFileContent = null, [WorkflowExpression] Func<string> mergePdfInput4thFileContent = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/pdf/merge";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/octet-stream");
                var mergePdfInput = new JObject();
                var mergePdfInputpropCount = 0;
                mergePdfInputpropCount++;
                mergePdfInput["fileContent1"] = SourceExpressionConverter.ConvertToken(mergePdfInput1stFileContent);
                mergePdfInputpropCount++;
                mergePdfInput["fileContent2"] = SourceExpressionConverter.ConvertToken(mergePdfInput2ndFileContent);
                if (mergePdfInput3rdFileContent != null)
                {
                    mergePdfInput["fileContent3"] = SourceExpressionConverter.ConvertToken(mergePdfInput3rdFileContent);
                    mergePdfInputpropCount++;
                }

                if (mergePdfInput4thFileContent != null)
                {
                    mergePdfInput["fileContent4"] = SourceExpressionConverter.ConvertToken(mergePdfInput4thFileContent);
                    mergePdfInputpropCount++;
                }

                if (mergePdfInputpropCount > 0)
                {
                    callPayload.Body = mergePdfInput;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "integrablepdf")]
        public IBodyWorkflowAction<string> PasswordProtectPdf([WorkflowExpression] Func<string> passwordProtectPdfInputfileContent, [WorkflowExpression] Func<string> passwordProtectPdfInputpassword)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/pdf/password_protect";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/octet-stream");
                var passwordProtectPdfInput = new JObject();
                var passwordProtectPdfInputpropCount = 0;
                passwordProtectPdfInputpropCount++;
                passwordProtectPdfInput["fileContent"] = SourceExpressionConverter.ConvertToken(passwordProtectPdfInputfileContent);
                passwordProtectPdfInputpropCount++;
                passwordProtectPdfInput["password"] = SourceExpressionConverter.ConvertToken(passwordProtectPdfInputpassword);
                if (passwordProtectPdfInputpropCount > 0)
                {
                    callPayload.Body = passwordProtectPdfInput;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "integrablepdf")]
        public IBodyWorkflowAction<string> SplitPdf([WorkflowExpression] Func<string> splitPdfInputfileContent, [WorkflowExpression] Func<int> splitPdfInputfirstPage = null, [WorkflowExpression] Func<int> splitPdfInputlastPage = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/pdf/split";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/octet-stream");
                var splitPdfInput = new JObject();
                var splitPdfInputpropCount = 0;
                splitPdfInputpropCount++;
                splitPdfInput["fileContent"] = SourceExpressionConverter.ConvertToken(splitPdfInputfileContent);
                if (splitPdfInputfirstPage != null)
                {
                    splitPdfInput["firstPage"] = SourceExpressionConverter.ConvertToken(splitPdfInputfirstPage);
                    splitPdfInputpropCount++;
                }

                if (splitPdfInputlastPage != null)
                {
                    splitPdfInput["lastPage"] = SourceExpressionConverter.ConvertToken(splitPdfInputlastPage);
                    splitPdfInputpropCount++;
                }

                if (splitPdfInputpropCount > 0)
                {
                    callPayload.Body = splitPdfInput;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "integrablepdf")]
        public IBodyWorkflowAction<string> UnlockPdf([WorkflowExpression] Func<string> unlockPdfInputfileContent, [WorkflowExpression] Func<string> unlockPdfInputpassword)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/pdf/unlock";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/octet-stream");
                var unlockPdfInput = new JObject();
                var unlockPdfInputpropCount = 0;
                unlockPdfInputpropCount++;
                unlockPdfInput["fileContent"] = SourceExpressionConverter.ConvertToken(unlockPdfInputfileContent);
                unlockPdfInputpropCount++;
                unlockPdfInput["password"] = SourceExpressionConverter.ConvertToken(unlockPdfInputpassword);
                if (unlockPdfInputpropCount > 0)
                {
                    callPayload.Body = unlockPdfInput;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "integrablepdf")]
        public IBodyWorkflowAction<string> WatermarkPdfBackground([WorkflowExpression] Func<string> watermarkPdfBackgroundInputfileContent, [WorkflowExpression] Func<string> watermarkPdfBackgroundInput1stLine, [WorkflowExpression] Func<watermarkPdfBackgroundInputcolorInput> watermarkPdfBackgroundInputcolor = null, [WorkflowExpression] Func<string> watermarkPdfBackgroundInput2ndLine = null, [WorkflowExpression] Func<string> watermarkPdfBackgroundInput3rdLine = null, [WorkflowExpression] Func<double> watermarkPdfBackgroundInputmargin = null, [WorkflowExpression] Func<watermarkPdfBackgroundInputorientationInput> watermarkPdfBackgroundInputorientation = null, [WorkflowExpression] Func<watermarkPdfBackgroundInputstyleInput> watermarkPdfBackgroundInputstyle = null, [WorkflowExpression] Func<double> watermarkPdfBackgroundInputtransparency = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/pdf/watermark/background";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/octet-stream");
                var watermarkPdfBackgroundInput = new JObject();
                var watermarkPdfBackgroundInputpropCount = 0;
                if (watermarkPdfBackgroundInputcolor != null)
                {
                    watermarkPdfBackgroundInput["color"] = SourceExpressionConverter.Convert(watermarkPdfBackgroundInputcolor);
                    watermarkPdfBackgroundInputpropCount++;
                }

                watermarkPdfBackgroundInputpropCount++;
                watermarkPdfBackgroundInput["fileContent"] = SourceExpressionConverter.ConvertToken(watermarkPdfBackgroundInputfileContent);
                watermarkPdfBackgroundInputpropCount++;
                watermarkPdfBackgroundInput["line1"] = SourceExpressionConverter.ConvertToken(watermarkPdfBackgroundInput1stLine);
                if (watermarkPdfBackgroundInput2ndLine != null)
                {
                    watermarkPdfBackgroundInput["line2"] = SourceExpressionConverter.ConvertToken(watermarkPdfBackgroundInput2ndLine);
                    watermarkPdfBackgroundInputpropCount++;
                }

                if (watermarkPdfBackgroundInput3rdLine != null)
                {
                    watermarkPdfBackgroundInput["line3"] = SourceExpressionConverter.ConvertToken(watermarkPdfBackgroundInput3rdLine);
                    watermarkPdfBackgroundInputpropCount++;
                }

                if (watermarkPdfBackgroundInputmargin != null)
                {
                    watermarkPdfBackgroundInput["margin"] = SourceExpressionConverter.ConvertToken(watermarkPdfBackgroundInputmargin);
                    watermarkPdfBackgroundInputpropCount++;
                }

                if (watermarkPdfBackgroundInputorientation != null)
                {
                    watermarkPdfBackgroundInput["orientation"] = SourceExpressionConverter.Convert(watermarkPdfBackgroundInputorientation);
                    watermarkPdfBackgroundInputpropCount++;
                }

                if (watermarkPdfBackgroundInputstyle != null)
                {
                    watermarkPdfBackgroundInput["style"] = SourceExpressionConverter.Convert(watermarkPdfBackgroundInputstyle);
                    watermarkPdfBackgroundInputpropCount++;
                }

                if (watermarkPdfBackgroundInputtransparency != null)
                {
                    watermarkPdfBackgroundInput["transparency"] = SourceExpressionConverter.ConvertToken(watermarkPdfBackgroundInputtransparency);
                    watermarkPdfBackgroundInputpropCount++;
                }

                if (watermarkPdfBackgroundInputpropCount > 0)
                {
                    callPayload.Body = watermarkPdfBackgroundInput;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "integrablepdf")]
        public IBodyWorkflowAction<string> WatermarkPdfCustom([WorkflowExpression] Func<string> watermarkPdfCustomInputfileContent, [WorkflowExpression] Func<string> watermarkPdfCustomInputtemplateId, [WorkflowExpression] Func<string> watermarkPdfCustomInput1stLine = null, [WorkflowExpression] Func<string> watermarkPdfCustomInput2ndLine = null, [WorkflowExpression] Func<string> watermarkPdfCustomInput3rdLine = null, [WorkflowExpression] Func<string> watermarkPdfCustomInput4thLine = null, [WorkflowExpression] Func<string> watermarkPdfCustomInput5thLine = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/pdf/watermark/custom";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/octet-stream");
                var watermarkPdfCustomInput = new JObject();
                var watermarkPdfCustomInputpropCount = 0;
                watermarkPdfCustomInputpropCount++;
                watermarkPdfCustomInput["fileContent"] = SourceExpressionConverter.ConvertToken(watermarkPdfCustomInputfileContent);
                if (watermarkPdfCustomInput1stLine != null)
                {
                    watermarkPdfCustomInput["line1"] = SourceExpressionConverter.ConvertToken(watermarkPdfCustomInput1stLine);
                    watermarkPdfCustomInputpropCount++;
                }

                if (watermarkPdfCustomInput2ndLine != null)
                {
                    watermarkPdfCustomInput["line2"] = SourceExpressionConverter.ConvertToken(watermarkPdfCustomInput2ndLine);
                    watermarkPdfCustomInputpropCount++;
                }

                if (watermarkPdfCustomInput3rdLine != null)
                {
                    watermarkPdfCustomInput["line3"] = SourceExpressionConverter.ConvertToken(watermarkPdfCustomInput3rdLine);
                    watermarkPdfCustomInputpropCount++;
                }

                if (watermarkPdfCustomInput4thLine != null)
                {
                    watermarkPdfCustomInput["line4"] = SourceExpressionConverter.ConvertToken(watermarkPdfCustomInput4thLine);
                    watermarkPdfCustomInputpropCount++;
                }

                if (watermarkPdfCustomInput5thLine != null)
                {
                    watermarkPdfCustomInput["line5"] = SourceExpressionConverter.ConvertToken(watermarkPdfCustomInput5thLine);
                    watermarkPdfCustomInputpropCount++;
                }

                watermarkPdfCustomInputpropCount++;
                watermarkPdfCustomInput["templateId"] = SourceExpressionConverter.ConvertToken(watermarkPdfCustomInputtemplateId);
                if (watermarkPdfCustomInputpropCount > 0)
                {
                    callPayload.Body = watermarkPdfCustomInput;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "integrablepdf")]
        public IBodyWorkflowAction<string> WatermarkPdfOverlay([WorkflowExpression] Func<string> watermarkPdfOverlayInputfileContent, [WorkflowExpression] Func<string> watermarkPdfOverlayInput1stLine, [WorkflowExpression] Func<watermarkPdfOverlayInputcolorInput> watermarkPdfOverlayInputcolor = null, [WorkflowExpression] Func<string> watermarkPdfOverlayInput2ndLine = null, [WorkflowExpression] Func<string> watermarkPdfOverlayInput3rdLine = null, [WorkflowExpression] Func<double> watermarkPdfOverlayInputmargin = null, [WorkflowExpression] Func<watermarkPdfOverlayInputorientationInput> watermarkPdfOverlayInputorientation = null, [WorkflowExpression] Func<watermarkPdfOverlayInputstyleInput> watermarkPdfOverlayInputstyle = null, [WorkflowExpression] Func<double> watermarkPdfOverlayInputtransparency = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/pdf/watermark/overlay";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/octet-stream");
                var watermarkPdfOverlayInput = new JObject();
                var watermarkPdfOverlayInputpropCount = 0;
                if (watermarkPdfOverlayInputcolor != null)
                {
                    watermarkPdfOverlayInput["color"] = SourceExpressionConverter.Convert(watermarkPdfOverlayInputcolor);
                    watermarkPdfOverlayInputpropCount++;
                }

                watermarkPdfOverlayInputpropCount++;
                watermarkPdfOverlayInput["fileContent"] = SourceExpressionConverter.ConvertToken(watermarkPdfOverlayInputfileContent);
                watermarkPdfOverlayInputpropCount++;
                watermarkPdfOverlayInput["line1"] = SourceExpressionConverter.ConvertToken(watermarkPdfOverlayInput1stLine);
                if (watermarkPdfOverlayInput2ndLine != null)
                {
                    watermarkPdfOverlayInput["line2"] = SourceExpressionConverter.ConvertToken(watermarkPdfOverlayInput2ndLine);
                    watermarkPdfOverlayInputpropCount++;
                }

                if (watermarkPdfOverlayInput3rdLine != null)
                {
                    watermarkPdfOverlayInput["line3"] = SourceExpressionConverter.ConvertToken(watermarkPdfOverlayInput3rdLine);
                    watermarkPdfOverlayInputpropCount++;
                }

                if (watermarkPdfOverlayInputmargin != null)
                {
                    watermarkPdfOverlayInput["margin"] = SourceExpressionConverter.ConvertToken(watermarkPdfOverlayInputmargin);
                    watermarkPdfOverlayInputpropCount++;
                }

                if (watermarkPdfOverlayInputorientation != null)
                {
                    watermarkPdfOverlayInput["orientation"] = SourceExpressionConverter.Convert(watermarkPdfOverlayInputorientation);
                    watermarkPdfOverlayInputpropCount++;
                }

                if (watermarkPdfOverlayInputstyle != null)
                {
                    watermarkPdfOverlayInput["style"] = SourceExpressionConverter.Convert(watermarkPdfOverlayInputstyle);
                    watermarkPdfOverlayInputpropCount++;
                }

                if (watermarkPdfOverlayInputtransparency != null)
                {
                    watermarkPdfOverlayInput["transparency"] = SourceExpressionConverter.ConvertToken(watermarkPdfOverlayInputtransparency);
                    watermarkPdfOverlayInputpropCount++;
                }

                if (watermarkPdfOverlayInputpropCount > 0)
                {
                    callPayload.Body = watermarkPdfOverlayInput;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }
    }

    public class IntegrablepdfTriggers([ConnectionName] string connectionId)
    {
    }

    public enum watermarkPdfBackgroundInputcolorInput
    {
        Gray,
        Red,
        Blue
    }

    public enum watermarkPdfBackgroundInputorientationInput
    {
        Upward,
        Downward
    }

    public enum watermarkPdfBackgroundInputstyleInput
    {
        Solid,
        Outline
    }

    public enum watermarkPdfOverlayInputcolorInput
    {
        Gray,
        Red,
        Blue
    }

    public enum watermarkPdfOverlayInputorientationInput
    {
        Upward,
        Downward
    }

    public enum watermarkPdfOverlayInputstyleInput
    {
        Solid,
        Outline
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Integrablepdf;

    public partial class WorkflowManagedActions
    {
        public IntegrablepdfActions Integrablepdf(string connectionId) => new IntegrablepdfActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public IntegrablepdfTriggers Integrablepdf(string connectionId) => new IntegrablepdfTriggers(connectionId);
    }
}