//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Integrablepdf
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class IntegrablepdfActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "integrablepdf")]
        [WorkflowExpressionFactory(nameof(__BuildLockPdf))]
        public IBodyWorkflowAction<string> LockPdf([WorkflowExpression] Func<string> lockPdfInputfileContent, [WorkflowExpression] Func<string> lockPdfInputpermissionsPassword, [WorkflowExpression] Func<bool> lockPdfInputallowAccessibility = null, [WorkflowExpression] Func<bool> lockPdfInputallowCopy = null, [WorkflowExpression] Func<bool> lockPdfInputallowDocumentAssembly = null, [WorkflowExpression] Func<bool> lockPdfInputallowEdit = null, [WorkflowExpression] Func<bool> lockPdfInputallowFormFilling = null, [WorkflowExpression] Func<bool> lockPdfInputallowPrint = null, [WorkflowExpression] Func<bool> lockPdfInputallowUpdateAnnotationsAndFields = null, [WorkflowExpression] Func<string> lockPdfInputdocumentOpenPassword = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildLockPdf(WorkflowExpression<string> lockPdfInputfileContent, WorkflowExpression<string> lockPdfInputpermissionsPassword, WorkflowExpression<bool> lockPdfInputallowAccessibility = null, WorkflowExpression<bool> lockPdfInputallowCopy = null, WorkflowExpression<bool> lockPdfInputallowDocumentAssembly = null, WorkflowExpression<bool> lockPdfInputallowEdit = null, WorkflowExpression<bool> lockPdfInputallowFormFilling = null, WorkflowExpression<bool> lockPdfInputallowPrint = null, WorkflowExpression<bool> lockPdfInputallowUpdateAnnotationsAndFields = null, WorkflowExpression<string> lockPdfInputdocumentOpenPassword = null)
        {
            WorkflowExpression.Validate(lockPdfInputfileContent, nameof(lockPdfInputfileContent), required: true);
            WorkflowExpression.Validate(lockPdfInputpermissionsPassword, nameof(lockPdfInputpermissionsPassword), required: true);
            WorkflowExpression.Validate(lockPdfInputallowAccessibility, nameof(lockPdfInputallowAccessibility), required: false);
            WorkflowExpression.Validate(lockPdfInputallowCopy, nameof(lockPdfInputallowCopy), required: false);
            WorkflowExpression.Validate(lockPdfInputallowDocumentAssembly, nameof(lockPdfInputallowDocumentAssembly), required: false);
            WorkflowExpression.Validate(lockPdfInputallowEdit, nameof(lockPdfInputallowEdit), required: false);
            WorkflowExpression.Validate(lockPdfInputallowFormFilling, nameof(lockPdfInputallowFormFilling), required: false);
            WorkflowExpression.Validate(lockPdfInputallowPrint, nameof(lockPdfInputallowPrint), required: false);
            WorkflowExpression.Validate(lockPdfInputallowUpdateAnnotationsAndFields, nameof(lockPdfInputallowUpdateAnnotationsAndFields), required: false);
            WorkflowExpression.Validate(lockPdfInputdocumentOpenPassword, nameof(lockPdfInputdocumentOpenPassword), required: false);
            return new DeferredBodyAction<string>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "integrablepdf")]
        [WorkflowExpressionFactory(nameof(__BuildMergePdf))]
        public IBodyWorkflowAction<string> MergePdf([WorkflowExpression] Func<string> mergePdfInput1stFileContent, [WorkflowExpression] Func<string> mergePdfInput2ndFileContent, [WorkflowExpression] Func<string> mergePdfInput3rdFileContent = null, [WorkflowExpression] Func<string> mergePdfInput4thFileContent = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildMergePdf(WorkflowExpression<string> mergePdfInput1stFileContent, WorkflowExpression<string> mergePdfInput2ndFileContent, WorkflowExpression<string> mergePdfInput3rdFileContent = null, WorkflowExpression<string> mergePdfInput4thFileContent = null)
        {
            WorkflowExpression.Validate(mergePdfInput1stFileContent, nameof(mergePdfInput1stFileContent), required: true);
            WorkflowExpression.Validate(mergePdfInput2ndFileContent, nameof(mergePdfInput2ndFileContent), required: true);
            WorkflowExpression.Validate(mergePdfInput3rdFileContent, nameof(mergePdfInput3rdFileContent), required: false);
            WorkflowExpression.Validate(mergePdfInput4thFileContent, nameof(mergePdfInput4thFileContent), required: false);
            return new DeferredBodyAction<string>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "integrablepdf")]
        [WorkflowExpressionFactory(nameof(__BuildPasswordProtectPdf))]
        public IBodyWorkflowAction<string> PasswordProtectPdf([WorkflowExpression] Func<string> passwordProtectPdfInputfileContent, [WorkflowExpression] Func<string> passwordProtectPdfInputpassword)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildPasswordProtectPdf(WorkflowExpression<string> passwordProtectPdfInputfileContent, WorkflowExpression<string> passwordProtectPdfInputpassword)
        {
            WorkflowExpression.Validate(passwordProtectPdfInputfileContent, nameof(passwordProtectPdfInputfileContent), required: true);
            WorkflowExpression.Validate(passwordProtectPdfInputpassword, nameof(passwordProtectPdfInputpassword), required: true);
            return new DeferredBodyAction<string>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "integrablepdf")]
        [WorkflowExpressionFactory(nameof(__BuildSplitPdf))]
        public IBodyWorkflowAction<string> SplitPdf([WorkflowExpression] Func<string> splitPdfInputfileContent, [WorkflowExpression] Func<int> splitPdfInputfirstPage = null, [WorkflowExpression] Func<int> splitPdfInputlastPage = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildSplitPdf(WorkflowExpression<string> splitPdfInputfileContent, WorkflowExpression<int> splitPdfInputfirstPage = null, WorkflowExpression<int> splitPdfInputlastPage = null)
        {
            WorkflowExpression.Validate(splitPdfInputfileContent, nameof(splitPdfInputfileContent), required: true);
            WorkflowExpression.Validate(splitPdfInputfirstPage, nameof(splitPdfInputfirstPage), required: false);
            WorkflowExpression.Validate(splitPdfInputlastPage, nameof(splitPdfInputlastPage), required: false);
            return new DeferredBodyAction<string>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "integrablepdf")]
        [WorkflowExpressionFactory(nameof(__BuildUnlockPdf))]
        public IBodyWorkflowAction<string> UnlockPdf([WorkflowExpression] Func<string> unlockPdfInputfileContent, [WorkflowExpression] Func<string> unlockPdfInputpassword)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildUnlockPdf(WorkflowExpression<string> unlockPdfInputfileContent, WorkflowExpression<string> unlockPdfInputpassword)
        {
            WorkflowExpression.Validate(unlockPdfInputfileContent, nameof(unlockPdfInputfileContent), required: true);
            WorkflowExpression.Validate(unlockPdfInputpassword, nameof(unlockPdfInputpassword), required: true);
            return new DeferredBodyAction<string>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "integrablepdf")]
        [WorkflowExpressionFactory(nameof(__BuildWatermarkPdfBackground))]
        public IBodyWorkflowAction<string> WatermarkPdfBackground([WorkflowExpression] Func<string> watermarkPdfBackgroundInputfileContent, [WorkflowExpression] Func<string> watermarkPdfBackgroundInput1stLine, [WorkflowExpression] Func<watermarkPdfBackgroundInputcolorInput> watermarkPdfBackgroundInputcolor = null, [WorkflowExpression] Func<string> watermarkPdfBackgroundInput2ndLine = null, [WorkflowExpression] Func<string> watermarkPdfBackgroundInput3rdLine = null, [WorkflowExpression] Func<double> watermarkPdfBackgroundInputmargin = null, [WorkflowExpression] Func<watermarkPdfBackgroundInputorientationInput> watermarkPdfBackgroundInputorientation = null, [WorkflowExpression] Func<watermarkPdfBackgroundInputstyleInput> watermarkPdfBackgroundInputstyle = null, [WorkflowExpression] Func<double> watermarkPdfBackgroundInputtransparency = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildWatermarkPdfBackground(WorkflowExpression<string> watermarkPdfBackgroundInputfileContent, WorkflowExpression<string> watermarkPdfBackgroundInput1stLine, WorkflowExpression<watermarkPdfBackgroundInputcolorInput> watermarkPdfBackgroundInputcolor = null, WorkflowExpression<string> watermarkPdfBackgroundInput2ndLine = null, WorkflowExpression<string> watermarkPdfBackgroundInput3rdLine = null, WorkflowExpression<double> watermarkPdfBackgroundInputmargin = null, WorkflowExpression<watermarkPdfBackgroundInputorientationInput> watermarkPdfBackgroundInputorientation = null, WorkflowExpression<watermarkPdfBackgroundInputstyleInput> watermarkPdfBackgroundInputstyle = null, WorkflowExpression<double> watermarkPdfBackgroundInputtransparency = null)
        {
            WorkflowExpression.Validate(watermarkPdfBackgroundInputfileContent, nameof(watermarkPdfBackgroundInputfileContent), required: true);
            WorkflowExpression.Validate(watermarkPdfBackgroundInput1stLine, nameof(watermarkPdfBackgroundInput1stLine), required: true);
            WorkflowExpression.Validate(watermarkPdfBackgroundInputcolor, nameof(watermarkPdfBackgroundInputcolor), required: false);
            WorkflowExpression.Validate(watermarkPdfBackgroundInput2ndLine, nameof(watermarkPdfBackgroundInput2ndLine), required: false);
            WorkflowExpression.Validate(watermarkPdfBackgroundInput3rdLine, nameof(watermarkPdfBackgroundInput3rdLine), required: false);
            WorkflowExpression.Validate(watermarkPdfBackgroundInputmargin, nameof(watermarkPdfBackgroundInputmargin), required: false);
            WorkflowExpression.Validate(watermarkPdfBackgroundInputorientation, nameof(watermarkPdfBackgroundInputorientation), required: false);
            WorkflowExpression.Validate(watermarkPdfBackgroundInputstyle, nameof(watermarkPdfBackgroundInputstyle), required: false);
            WorkflowExpression.Validate(watermarkPdfBackgroundInputtransparency, nameof(watermarkPdfBackgroundInputtransparency), required: false);
            return new DeferredBodyAction<string>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "integrablepdf")]
        [WorkflowExpressionFactory(nameof(__BuildWatermarkPdfCustom))]
        public IBodyWorkflowAction<string> WatermarkPdfCustom([WorkflowExpression] Func<string> watermarkPdfCustomInputfileContent, [WorkflowExpression] Func<string> watermarkPdfCustomInputtemplateId, [WorkflowExpression] Func<string> watermarkPdfCustomInput1stLine = null, [WorkflowExpression] Func<string> watermarkPdfCustomInput2ndLine = null, [WorkflowExpression] Func<string> watermarkPdfCustomInput3rdLine = null, [WorkflowExpression] Func<string> watermarkPdfCustomInput4thLine = null, [WorkflowExpression] Func<string> watermarkPdfCustomInput5thLine = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildWatermarkPdfCustom(WorkflowExpression<string> watermarkPdfCustomInputfileContent, WorkflowExpression<string> watermarkPdfCustomInputtemplateId, WorkflowExpression<string> watermarkPdfCustomInput1stLine = null, WorkflowExpression<string> watermarkPdfCustomInput2ndLine = null, WorkflowExpression<string> watermarkPdfCustomInput3rdLine = null, WorkflowExpression<string> watermarkPdfCustomInput4thLine = null, WorkflowExpression<string> watermarkPdfCustomInput5thLine = null)
        {
            WorkflowExpression.Validate(watermarkPdfCustomInputfileContent, nameof(watermarkPdfCustomInputfileContent), required: true);
            WorkflowExpression.Validate(watermarkPdfCustomInputtemplateId, nameof(watermarkPdfCustomInputtemplateId), required: true);
            WorkflowExpression.Validate(watermarkPdfCustomInput1stLine, nameof(watermarkPdfCustomInput1stLine), required: false);
            WorkflowExpression.Validate(watermarkPdfCustomInput2ndLine, nameof(watermarkPdfCustomInput2ndLine), required: false);
            WorkflowExpression.Validate(watermarkPdfCustomInput3rdLine, nameof(watermarkPdfCustomInput3rdLine), required: false);
            WorkflowExpression.Validate(watermarkPdfCustomInput4thLine, nameof(watermarkPdfCustomInput4thLine), required: false);
            WorkflowExpression.Validate(watermarkPdfCustomInput5thLine, nameof(watermarkPdfCustomInput5thLine), required: false);
            return new DeferredBodyAction<string>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "integrablepdf")]
        [WorkflowExpressionFactory(nameof(__BuildWatermarkPdfOverlay))]
        public IBodyWorkflowAction<string> WatermarkPdfOverlay([WorkflowExpression] Func<string> watermarkPdfOverlayInputfileContent, [WorkflowExpression] Func<string> watermarkPdfOverlayInput1stLine, [WorkflowExpression] Func<watermarkPdfOverlayInputcolorInput> watermarkPdfOverlayInputcolor = null, [WorkflowExpression] Func<string> watermarkPdfOverlayInput2ndLine = null, [WorkflowExpression] Func<string> watermarkPdfOverlayInput3rdLine = null, [WorkflowExpression] Func<double> watermarkPdfOverlayInputmargin = null, [WorkflowExpression] Func<watermarkPdfOverlayInputorientationInput> watermarkPdfOverlayInputorientation = null, [WorkflowExpression] Func<watermarkPdfOverlayInputstyleInput> watermarkPdfOverlayInputstyle = null, [WorkflowExpression] Func<double> watermarkPdfOverlayInputtransparency = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildWatermarkPdfOverlay(WorkflowExpression<string> watermarkPdfOverlayInputfileContent, WorkflowExpression<string> watermarkPdfOverlayInput1stLine, WorkflowExpression<watermarkPdfOverlayInputcolorInput> watermarkPdfOverlayInputcolor = null, WorkflowExpression<string> watermarkPdfOverlayInput2ndLine = null, WorkflowExpression<string> watermarkPdfOverlayInput3rdLine = null, WorkflowExpression<double> watermarkPdfOverlayInputmargin = null, WorkflowExpression<watermarkPdfOverlayInputorientationInput> watermarkPdfOverlayInputorientation = null, WorkflowExpression<watermarkPdfOverlayInputstyleInput> watermarkPdfOverlayInputstyle = null, WorkflowExpression<double> watermarkPdfOverlayInputtransparency = null)
        {
            WorkflowExpression.Validate(watermarkPdfOverlayInputfileContent, nameof(watermarkPdfOverlayInputfileContent), required: true);
            WorkflowExpression.Validate(watermarkPdfOverlayInput1stLine, nameof(watermarkPdfOverlayInput1stLine), required: true);
            WorkflowExpression.Validate(watermarkPdfOverlayInputcolor, nameof(watermarkPdfOverlayInputcolor), required: false);
            WorkflowExpression.Validate(watermarkPdfOverlayInput2ndLine, nameof(watermarkPdfOverlayInput2ndLine), required: false);
            WorkflowExpression.Validate(watermarkPdfOverlayInput3rdLine, nameof(watermarkPdfOverlayInput3rdLine), required: false);
            WorkflowExpression.Validate(watermarkPdfOverlayInputmargin, nameof(watermarkPdfOverlayInputmargin), required: false);
            WorkflowExpression.Validate(watermarkPdfOverlayInputorientation, nameof(watermarkPdfOverlayInputorientation), required: false);
            WorkflowExpression.Validate(watermarkPdfOverlayInputstyle, nameof(watermarkPdfOverlayInputstyle), required: false);
            WorkflowExpression.Validate(watermarkPdfOverlayInputtransparency, nameof(watermarkPdfOverlayInputtransparency), required: false);
            return new DeferredBodyAction<string>(() =>
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
            });
        }
    }

    public class IntegrablepdfTriggers([ConnectionName] string connectionId)
    {
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum watermarkPdfBackgroundInputcolorInput
    {
        Gray,
        Red,
        Blue
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum watermarkPdfBackgroundInputorientationInput
    {
        Upward,
        Downward
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum watermarkPdfBackgroundInputstyleInput
    {
        Solid,
        Outline
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum watermarkPdfOverlayInputcolorInput
    {
        Gray,
        Red,
        Blue
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum watermarkPdfOverlayInputorientationInput
    {
        Upward,
        Downward
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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