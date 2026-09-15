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
        public IBodyWorkflowAction<string> LockPdf(Expression<Func<string>> lockPdfInputfileContent, Expression<Func<string>> lockPdfInputpermissionsPassword, Expression<Func<bool>> lockPdfInputallowAccessibility = null, Expression<Func<bool>> lockPdfInputallowCopy = null, Expression<Func<bool>> lockPdfInputallowDocumentAssembly = null, Expression<Func<bool>> lockPdfInputallowEdit = null, Expression<Func<bool>> lockPdfInputallowFormFilling = null, Expression<Func<bool>> lockPdfInputallowPrint = null, Expression<Func<bool>> lockPdfInputallowUpdateAnnotationsAndFields = null, Expression<Func<string>> lockPdfInputdocumentOpenPassword = null)
        {
            var apiCallPath = "/pdf/lock";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/octet-stream");
            var lockPdfInput = new JObject();
            var lockPdfInputpropCount = 0;
            if (lockPdfInputallowAccessibility != null)
            {
                lockPdfInput["allowAccessibility"] = CSharpExpressionConverter.ConvertToken(lockPdfInputallowAccessibility);
                lockPdfInputpropCount++;
            }

            if (lockPdfInputallowCopy != null)
            {
                lockPdfInput["allowCopy"] = CSharpExpressionConverter.ConvertToken(lockPdfInputallowCopy);
                lockPdfInputpropCount++;
            }

            if (lockPdfInputallowDocumentAssembly != null)
            {
                lockPdfInput["allowDocumentAssembly"] = CSharpExpressionConverter.ConvertToken(lockPdfInputallowDocumentAssembly);
                lockPdfInputpropCount++;
            }

            if (lockPdfInputallowEdit != null)
            {
                lockPdfInput["allowEdit"] = CSharpExpressionConverter.ConvertToken(lockPdfInputallowEdit);
                lockPdfInputpropCount++;
            }

            if (lockPdfInputallowFormFilling != null)
            {
                lockPdfInput["allowFormFilling"] = CSharpExpressionConverter.ConvertToken(lockPdfInputallowFormFilling);
                lockPdfInputpropCount++;
            }

            if (lockPdfInputallowPrint != null)
            {
                lockPdfInput["allowPrint"] = CSharpExpressionConverter.ConvertToken(lockPdfInputallowPrint);
                lockPdfInputpropCount++;
            }

            if (lockPdfInputallowUpdateAnnotationsAndFields != null)
            {
                lockPdfInput["allowUpdateAnnotationsAndFields"] = CSharpExpressionConverter.ConvertToken(lockPdfInputallowUpdateAnnotationsAndFields);
                lockPdfInputpropCount++;
            }

            if (lockPdfInputdocumentOpenPassword != null)
            {
                lockPdfInput["documentOpenPassword"] = CSharpExpressionConverter.ConvertToken(lockPdfInputdocumentOpenPassword);
                lockPdfInputpropCount++;
            }

            lockPdfInputpropCount++;
            lockPdfInput["fileContent"] = CSharpExpressionConverter.ConvertToken(lockPdfInputfileContent);
            lockPdfInputpropCount++;
            lockPdfInput["permissionsPassword"] = CSharpExpressionConverter.ConvertToken(lockPdfInputpermissionsPassword);
            if (lockPdfInputpropCount > 0)
            {
                callPayload.Body = lockPdfInput;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "integrablepdf")]
        public IBodyWorkflowAction<string> MergePdf(Expression<Func<string>> mergePdfInput1stFileContent, Expression<Func<string>> mergePdfInput2ndFileContent, Expression<Func<string>> mergePdfInput3rdFileContent = null, Expression<Func<string>> mergePdfInput4thFileContent = null)
        {
            var apiCallPath = "/pdf/merge";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/octet-stream");
            var mergePdfInput = new JObject();
            var mergePdfInputpropCount = 0;
            mergePdfInputpropCount++;
            mergePdfInput["fileContent1"] = CSharpExpressionConverter.ConvertToken(mergePdfInput1stFileContent);
            mergePdfInputpropCount++;
            mergePdfInput["fileContent2"] = CSharpExpressionConverter.ConvertToken(mergePdfInput2ndFileContent);
            if (mergePdfInput3rdFileContent != null)
            {
                mergePdfInput["fileContent3"] = CSharpExpressionConverter.ConvertToken(mergePdfInput3rdFileContent);
                mergePdfInputpropCount++;
            }

            if (mergePdfInput4thFileContent != null)
            {
                mergePdfInput["fileContent4"] = CSharpExpressionConverter.ConvertToken(mergePdfInput4thFileContent);
                mergePdfInputpropCount++;
            }

            if (mergePdfInputpropCount > 0)
            {
                callPayload.Body = mergePdfInput;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "integrablepdf")]
        public IBodyWorkflowAction<string> PasswordProtectPdf(Expression<Func<string>> passwordProtectPdfInputfileContent, Expression<Func<string>> passwordProtectPdfInputpassword)
        {
            var apiCallPath = "/pdf/password_protect";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/octet-stream");
            var passwordProtectPdfInput = new JObject();
            var passwordProtectPdfInputpropCount = 0;
            passwordProtectPdfInputpropCount++;
            passwordProtectPdfInput["fileContent"] = CSharpExpressionConverter.ConvertToken(passwordProtectPdfInputfileContent);
            passwordProtectPdfInputpropCount++;
            passwordProtectPdfInput["password"] = CSharpExpressionConverter.ConvertToken(passwordProtectPdfInputpassword);
            if (passwordProtectPdfInputpropCount > 0)
            {
                callPayload.Body = passwordProtectPdfInput;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "integrablepdf")]
        public IBodyWorkflowAction<string> SplitPdf(Expression<Func<string>> splitPdfInputfileContent, Expression<Func<int>> splitPdfInputfirstPage = null, Expression<Func<int>> splitPdfInputlastPage = null)
        {
            var apiCallPath = "/pdf/split";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/octet-stream");
            var splitPdfInput = new JObject();
            var splitPdfInputpropCount = 0;
            splitPdfInputpropCount++;
            splitPdfInput["fileContent"] = CSharpExpressionConverter.ConvertToken(splitPdfInputfileContent);
            if (splitPdfInputfirstPage != null)
            {
                splitPdfInput["firstPage"] = CSharpExpressionConverter.ConvertToken(splitPdfInputfirstPage);
                splitPdfInputpropCount++;
            }

            if (splitPdfInputlastPage != null)
            {
                splitPdfInput["lastPage"] = CSharpExpressionConverter.ConvertToken(splitPdfInputlastPage);
                splitPdfInputpropCount++;
            }

            if (splitPdfInputpropCount > 0)
            {
                callPayload.Body = splitPdfInput;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "integrablepdf")]
        public IBodyWorkflowAction<string> UnlockPdf(Expression<Func<string>> unlockPdfInputfileContent, Expression<Func<string>> unlockPdfInputpassword)
        {
            var apiCallPath = "/pdf/unlock";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/octet-stream");
            var unlockPdfInput = new JObject();
            var unlockPdfInputpropCount = 0;
            unlockPdfInputpropCount++;
            unlockPdfInput["fileContent"] = CSharpExpressionConverter.ConvertToken(unlockPdfInputfileContent);
            unlockPdfInputpropCount++;
            unlockPdfInput["password"] = CSharpExpressionConverter.ConvertToken(unlockPdfInputpassword);
            if (unlockPdfInputpropCount > 0)
            {
                callPayload.Body = unlockPdfInput;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "integrablepdf")]
        public IBodyWorkflowAction<string> WatermarkPdfBackground(Expression<Func<string>> watermarkPdfBackgroundInputfileContent, Expression<Func<string>> watermarkPdfBackgroundInput1stLine, Expression<Func<watermarkPdfBackgroundInputcolorInput>> watermarkPdfBackgroundInputcolor = null, Expression<Func<string>> watermarkPdfBackgroundInput2ndLine = null, Expression<Func<string>> watermarkPdfBackgroundInput3rdLine = null, Expression<Func<double>> watermarkPdfBackgroundInputmargin = null, Expression<Func<watermarkPdfBackgroundInputorientationInput>> watermarkPdfBackgroundInputorientation = null, Expression<Func<watermarkPdfBackgroundInputstyleInput>> watermarkPdfBackgroundInputstyle = null, Expression<Func<double>> watermarkPdfBackgroundInputtransparency = null)
        {
            var apiCallPath = "/pdf/watermark/background";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/octet-stream");
            var watermarkPdfBackgroundInput = new JObject();
            var watermarkPdfBackgroundInputpropCount = 0;
            if (watermarkPdfBackgroundInputcolor != null)
            {
                watermarkPdfBackgroundInput["color"] = CSharpExpressionConverter.Convert(watermarkPdfBackgroundInputcolor);
                watermarkPdfBackgroundInputpropCount++;
            }

            watermarkPdfBackgroundInputpropCount++;
            watermarkPdfBackgroundInput["fileContent"] = CSharpExpressionConverter.ConvertToken(watermarkPdfBackgroundInputfileContent);
            watermarkPdfBackgroundInputpropCount++;
            watermarkPdfBackgroundInput["line1"] = CSharpExpressionConverter.ConvertToken(watermarkPdfBackgroundInput1stLine);
            if (watermarkPdfBackgroundInput2ndLine != null)
            {
                watermarkPdfBackgroundInput["line2"] = CSharpExpressionConverter.ConvertToken(watermarkPdfBackgroundInput2ndLine);
                watermarkPdfBackgroundInputpropCount++;
            }

            if (watermarkPdfBackgroundInput3rdLine != null)
            {
                watermarkPdfBackgroundInput["line3"] = CSharpExpressionConverter.ConvertToken(watermarkPdfBackgroundInput3rdLine);
                watermarkPdfBackgroundInputpropCount++;
            }

            if (watermarkPdfBackgroundInputmargin != null)
            {
                watermarkPdfBackgroundInput["margin"] = CSharpExpressionConverter.ConvertToken(watermarkPdfBackgroundInputmargin);
                watermarkPdfBackgroundInputpropCount++;
            }

            if (watermarkPdfBackgroundInputorientation != null)
            {
                watermarkPdfBackgroundInput["orientation"] = CSharpExpressionConverter.Convert(watermarkPdfBackgroundInputorientation);
                watermarkPdfBackgroundInputpropCount++;
            }

            if (watermarkPdfBackgroundInputstyle != null)
            {
                watermarkPdfBackgroundInput["style"] = CSharpExpressionConverter.Convert(watermarkPdfBackgroundInputstyle);
                watermarkPdfBackgroundInputpropCount++;
            }

            if (watermarkPdfBackgroundInputtransparency != null)
            {
                watermarkPdfBackgroundInput["transparency"] = CSharpExpressionConverter.ConvertToken(watermarkPdfBackgroundInputtransparency);
                watermarkPdfBackgroundInputpropCount++;
            }

            if (watermarkPdfBackgroundInputpropCount > 0)
            {
                callPayload.Body = watermarkPdfBackgroundInput;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "integrablepdf")]
        public IBodyWorkflowAction<string> WatermarkPdfCustom(Expression<Func<string>> watermarkPdfCustomInputfileContent, Expression<Func<string>> watermarkPdfCustomInputtemplateId, Expression<Func<string>> watermarkPdfCustomInput1stLine = null, Expression<Func<string>> watermarkPdfCustomInput2ndLine = null, Expression<Func<string>> watermarkPdfCustomInput3rdLine = null, Expression<Func<string>> watermarkPdfCustomInput4thLine = null, Expression<Func<string>> watermarkPdfCustomInput5thLine = null)
        {
            var apiCallPath = "/pdf/watermark/custom";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/octet-stream");
            var watermarkPdfCustomInput = new JObject();
            var watermarkPdfCustomInputpropCount = 0;
            watermarkPdfCustomInputpropCount++;
            watermarkPdfCustomInput["fileContent"] = CSharpExpressionConverter.ConvertToken(watermarkPdfCustomInputfileContent);
            if (watermarkPdfCustomInput1stLine != null)
            {
                watermarkPdfCustomInput["line1"] = CSharpExpressionConverter.ConvertToken(watermarkPdfCustomInput1stLine);
                watermarkPdfCustomInputpropCount++;
            }

            if (watermarkPdfCustomInput2ndLine != null)
            {
                watermarkPdfCustomInput["line2"] = CSharpExpressionConverter.ConvertToken(watermarkPdfCustomInput2ndLine);
                watermarkPdfCustomInputpropCount++;
            }

            if (watermarkPdfCustomInput3rdLine != null)
            {
                watermarkPdfCustomInput["line3"] = CSharpExpressionConverter.ConvertToken(watermarkPdfCustomInput3rdLine);
                watermarkPdfCustomInputpropCount++;
            }

            if (watermarkPdfCustomInput4thLine != null)
            {
                watermarkPdfCustomInput["line4"] = CSharpExpressionConverter.ConvertToken(watermarkPdfCustomInput4thLine);
                watermarkPdfCustomInputpropCount++;
            }

            if (watermarkPdfCustomInput5thLine != null)
            {
                watermarkPdfCustomInput["line5"] = CSharpExpressionConverter.ConvertToken(watermarkPdfCustomInput5thLine);
                watermarkPdfCustomInputpropCount++;
            }

            watermarkPdfCustomInputpropCount++;
            watermarkPdfCustomInput["templateId"] = CSharpExpressionConverter.ConvertToken(watermarkPdfCustomInputtemplateId);
            if (watermarkPdfCustomInputpropCount > 0)
            {
                callPayload.Body = watermarkPdfCustomInput;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "integrablepdf")]
        public IBodyWorkflowAction<string> WatermarkPdfOverlay(Expression<Func<string>> watermarkPdfOverlayInputfileContent, Expression<Func<string>> watermarkPdfOverlayInput1stLine, Expression<Func<watermarkPdfOverlayInputcolorInput>> watermarkPdfOverlayInputcolor = null, Expression<Func<string>> watermarkPdfOverlayInput2ndLine = null, Expression<Func<string>> watermarkPdfOverlayInput3rdLine = null, Expression<Func<double>> watermarkPdfOverlayInputmargin = null, Expression<Func<watermarkPdfOverlayInputorientationInput>> watermarkPdfOverlayInputorientation = null, Expression<Func<watermarkPdfOverlayInputstyleInput>> watermarkPdfOverlayInputstyle = null, Expression<Func<double>> watermarkPdfOverlayInputtransparency = null)
        {
            var apiCallPath = "/pdf/watermark/overlay";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/octet-stream");
            var watermarkPdfOverlayInput = new JObject();
            var watermarkPdfOverlayInputpropCount = 0;
            if (watermarkPdfOverlayInputcolor != null)
            {
                watermarkPdfOverlayInput["color"] = CSharpExpressionConverter.Convert(watermarkPdfOverlayInputcolor);
                watermarkPdfOverlayInputpropCount++;
            }

            watermarkPdfOverlayInputpropCount++;
            watermarkPdfOverlayInput["fileContent"] = CSharpExpressionConverter.ConvertToken(watermarkPdfOverlayInputfileContent);
            watermarkPdfOverlayInputpropCount++;
            watermarkPdfOverlayInput["line1"] = CSharpExpressionConverter.ConvertToken(watermarkPdfOverlayInput1stLine);
            if (watermarkPdfOverlayInput2ndLine != null)
            {
                watermarkPdfOverlayInput["line2"] = CSharpExpressionConverter.ConvertToken(watermarkPdfOverlayInput2ndLine);
                watermarkPdfOverlayInputpropCount++;
            }

            if (watermarkPdfOverlayInput3rdLine != null)
            {
                watermarkPdfOverlayInput["line3"] = CSharpExpressionConverter.ConvertToken(watermarkPdfOverlayInput3rdLine);
                watermarkPdfOverlayInputpropCount++;
            }

            if (watermarkPdfOverlayInputmargin != null)
            {
                watermarkPdfOverlayInput["margin"] = CSharpExpressionConverter.ConvertToken(watermarkPdfOverlayInputmargin);
                watermarkPdfOverlayInputpropCount++;
            }

            if (watermarkPdfOverlayInputorientation != null)
            {
                watermarkPdfOverlayInput["orientation"] = CSharpExpressionConverter.Convert(watermarkPdfOverlayInputorientation);
                watermarkPdfOverlayInputpropCount++;
            }

            if (watermarkPdfOverlayInputstyle != null)
            {
                watermarkPdfOverlayInput["style"] = CSharpExpressionConverter.Convert(watermarkPdfOverlayInputstyle);
                watermarkPdfOverlayInputpropCount++;
            }

            if (watermarkPdfOverlayInputtransparency != null)
            {
                watermarkPdfOverlayInput["transparency"] = CSharpExpressionConverter.ConvertToken(watermarkPdfOverlayInputtransparency);
                watermarkPdfOverlayInputpropCount++;
            }

            if (watermarkPdfOverlayInputpropCount > 0)
            {
                callPayload.Body = watermarkPdfOverlayInput;
            }

            return new ApiConnectionAction<string>(callPayload);
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