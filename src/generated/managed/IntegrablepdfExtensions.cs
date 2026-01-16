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
                lockPdfInput["allowAccessibility"] = ExpressionConverter.ConvertO(lockPdfInputallowAccessibility);
                lockPdfInputpropCount++;
            }

            if (lockPdfInputallowCopy != null)
            {
                lockPdfInput["allowCopy"] = ExpressionConverter.ConvertO(lockPdfInputallowCopy);
                lockPdfInputpropCount++;
            }

            if (lockPdfInputallowDocumentAssembly != null)
            {
                lockPdfInput["allowDocumentAssembly"] = ExpressionConverter.ConvertO(lockPdfInputallowDocumentAssembly);
                lockPdfInputpropCount++;
            }

            if (lockPdfInputallowEdit != null)
            {
                lockPdfInput["allowEdit"] = ExpressionConverter.ConvertO(lockPdfInputallowEdit);
                lockPdfInputpropCount++;
            }

            if (lockPdfInputallowFormFilling != null)
            {
                lockPdfInput["allowFormFilling"] = ExpressionConverter.ConvertO(lockPdfInputallowFormFilling);
                lockPdfInputpropCount++;
            }

            if (lockPdfInputallowPrint != null)
            {
                lockPdfInput["allowPrint"] = ExpressionConverter.ConvertO(lockPdfInputallowPrint);
                lockPdfInputpropCount++;
            }

            if (lockPdfInputallowUpdateAnnotationsAndFields != null)
            {
                lockPdfInput["allowUpdateAnnotationsAndFields"] = ExpressionConverter.ConvertO(lockPdfInputallowUpdateAnnotationsAndFields);
                lockPdfInputpropCount++;
            }

            if (lockPdfInputdocumentOpenPassword != null)
            {
                lockPdfInput["documentOpenPassword"] = ExpressionConverter.ConvertO(lockPdfInputdocumentOpenPassword);
                lockPdfInputpropCount++;
            }

            lockPdfInputpropCount++;
            lockPdfInput["fileContent"] = ExpressionConverter.ConvertO(lockPdfInputfileContent);
            lockPdfInputpropCount++;
            lockPdfInput["permissionsPassword"] = ExpressionConverter.ConvertO(lockPdfInputpermissionsPassword);
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
            mergePdfInput["fileContent1"] = ExpressionConverter.ConvertO(mergePdfInput1stFileContent);
            mergePdfInputpropCount++;
            mergePdfInput["fileContent2"] = ExpressionConverter.ConvertO(mergePdfInput2ndFileContent);
            if (mergePdfInput3rdFileContent != null)
            {
                mergePdfInput["fileContent3"] = ExpressionConverter.ConvertO(mergePdfInput3rdFileContent);
                mergePdfInputpropCount++;
            }

            if (mergePdfInput4thFileContent != null)
            {
                mergePdfInput["fileContent4"] = ExpressionConverter.ConvertO(mergePdfInput4thFileContent);
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
            passwordProtectPdfInput["fileContent"] = ExpressionConverter.ConvertO(passwordProtectPdfInputfileContent);
            passwordProtectPdfInputpropCount++;
            passwordProtectPdfInput["password"] = ExpressionConverter.ConvertO(passwordProtectPdfInputpassword);
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
            splitPdfInput["fileContent"] = ExpressionConverter.ConvertO(splitPdfInputfileContent);
            if (splitPdfInputfirstPage != null)
            {
                splitPdfInput["firstPage"] = ExpressionConverter.ConvertO(splitPdfInputfirstPage);
                splitPdfInputpropCount++;
            }

            if (splitPdfInputlastPage != null)
            {
                splitPdfInput["lastPage"] = ExpressionConverter.ConvertO(splitPdfInputlastPage);
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
            unlockPdfInput["fileContent"] = ExpressionConverter.ConvertO(unlockPdfInputfileContent);
            unlockPdfInputpropCount++;
            unlockPdfInput["password"] = ExpressionConverter.ConvertO(unlockPdfInputpassword);
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
                watermarkPdfBackgroundInput["color"] = ExpressionConverter.ConvertO(watermarkPdfBackgroundInputcolor);
                watermarkPdfBackgroundInputpropCount++;
            }

            watermarkPdfBackgroundInputpropCount++;
            watermarkPdfBackgroundInput["fileContent"] = ExpressionConverter.ConvertO(watermarkPdfBackgroundInputfileContent);
            watermarkPdfBackgroundInputpropCount++;
            watermarkPdfBackgroundInput["line1"] = ExpressionConverter.ConvertO(watermarkPdfBackgroundInput1stLine);
            if (watermarkPdfBackgroundInput2ndLine != null)
            {
                watermarkPdfBackgroundInput["line2"] = ExpressionConverter.ConvertO(watermarkPdfBackgroundInput2ndLine);
                watermarkPdfBackgroundInputpropCount++;
            }

            if (watermarkPdfBackgroundInput3rdLine != null)
            {
                watermarkPdfBackgroundInput["line3"] = ExpressionConverter.ConvertO(watermarkPdfBackgroundInput3rdLine);
                watermarkPdfBackgroundInputpropCount++;
            }

            if (watermarkPdfBackgroundInputmargin != null)
            {
                watermarkPdfBackgroundInput["margin"] = ExpressionConverter.ConvertO(watermarkPdfBackgroundInputmargin);
                watermarkPdfBackgroundInputpropCount++;
            }

            if (watermarkPdfBackgroundInputorientation != null)
            {
                watermarkPdfBackgroundInput["orientation"] = ExpressionConverter.ConvertO(watermarkPdfBackgroundInputorientation);
                watermarkPdfBackgroundInputpropCount++;
            }

            if (watermarkPdfBackgroundInputstyle != null)
            {
                watermarkPdfBackgroundInput["style"] = ExpressionConverter.ConvertO(watermarkPdfBackgroundInputstyle);
                watermarkPdfBackgroundInputpropCount++;
            }

            if (watermarkPdfBackgroundInputtransparency != null)
            {
                watermarkPdfBackgroundInput["transparency"] = ExpressionConverter.ConvertO(watermarkPdfBackgroundInputtransparency);
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
            watermarkPdfCustomInput["fileContent"] = ExpressionConverter.ConvertO(watermarkPdfCustomInputfileContent);
            if (watermarkPdfCustomInput1stLine != null)
            {
                watermarkPdfCustomInput["line1"] = ExpressionConverter.ConvertO(watermarkPdfCustomInput1stLine);
                watermarkPdfCustomInputpropCount++;
            }

            if (watermarkPdfCustomInput2ndLine != null)
            {
                watermarkPdfCustomInput["line2"] = ExpressionConverter.ConvertO(watermarkPdfCustomInput2ndLine);
                watermarkPdfCustomInputpropCount++;
            }

            if (watermarkPdfCustomInput3rdLine != null)
            {
                watermarkPdfCustomInput["line3"] = ExpressionConverter.ConvertO(watermarkPdfCustomInput3rdLine);
                watermarkPdfCustomInputpropCount++;
            }

            if (watermarkPdfCustomInput4thLine != null)
            {
                watermarkPdfCustomInput["line4"] = ExpressionConverter.ConvertO(watermarkPdfCustomInput4thLine);
                watermarkPdfCustomInputpropCount++;
            }

            if (watermarkPdfCustomInput5thLine != null)
            {
                watermarkPdfCustomInput["line5"] = ExpressionConverter.ConvertO(watermarkPdfCustomInput5thLine);
                watermarkPdfCustomInputpropCount++;
            }

            watermarkPdfCustomInputpropCount++;
            watermarkPdfCustomInput["templateId"] = ExpressionConverter.ConvertO(watermarkPdfCustomInputtemplateId);
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
                watermarkPdfOverlayInput["color"] = ExpressionConverter.ConvertO(watermarkPdfOverlayInputcolor);
                watermarkPdfOverlayInputpropCount++;
            }

            watermarkPdfOverlayInputpropCount++;
            watermarkPdfOverlayInput["fileContent"] = ExpressionConverter.ConvertO(watermarkPdfOverlayInputfileContent);
            watermarkPdfOverlayInputpropCount++;
            watermarkPdfOverlayInput["line1"] = ExpressionConverter.ConvertO(watermarkPdfOverlayInput1stLine);
            if (watermarkPdfOverlayInput2ndLine != null)
            {
                watermarkPdfOverlayInput["line2"] = ExpressionConverter.ConvertO(watermarkPdfOverlayInput2ndLine);
                watermarkPdfOverlayInputpropCount++;
            }

            if (watermarkPdfOverlayInput3rdLine != null)
            {
                watermarkPdfOverlayInput["line3"] = ExpressionConverter.ConvertO(watermarkPdfOverlayInput3rdLine);
                watermarkPdfOverlayInputpropCount++;
            }

            if (watermarkPdfOverlayInputmargin != null)
            {
                watermarkPdfOverlayInput["margin"] = ExpressionConverter.ConvertO(watermarkPdfOverlayInputmargin);
                watermarkPdfOverlayInputpropCount++;
            }

            if (watermarkPdfOverlayInputorientation != null)
            {
                watermarkPdfOverlayInput["orientation"] = ExpressionConverter.ConvertO(watermarkPdfOverlayInputorientation);
                watermarkPdfOverlayInputpropCount++;
            }

            if (watermarkPdfOverlayInputstyle != null)
            {
                watermarkPdfOverlayInput["style"] = ExpressionConverter.ConvertO(watermarkPdfOverlayInputstyle);
                watermarkPdfOverlayInputpropCount++;
            }

            if (watermarkPdfOverlayInputtransparency != null)
            {
                watermarkPdfOverlayInput["transparency"] = ExpressionConverter.ConvertO(watermarkPdfOverlayInputtransparency);
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

namespace Microsoft.Azure.Workflows.Sdk.Connectors
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