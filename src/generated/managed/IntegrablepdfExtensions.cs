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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildLockPdf(WorkflowValue<string> lockPdfInputfileContent, WorkflowValue<string> lockPdfInputpermissionsPassword, WorkflowValue<bool> lockPdfInputallowAccessibility = null, WorkflowValue<bool> lockPdfInputallowCopy = null, WorkflowValue<bool> lockPdfInputallowDocumentAssembly = null, WorkflowValue<bool> lockPdfInputallowEdit = null, WorkflowValue<bool> lockPdfInputallowFormFilling = null, WorkflowValue<bool> lockPdfInputallowPrint = null, WorkflowValue<bool> lockPdfInputallowUpdateAnnotationsAndFields = null, WorkflowValue<string> lockPdfInputdocumentOpenPassword = null)
        {
            WorkflowValue.Validate(lockPdfInputfileContent, nameof(lockPdfInputfileContent), required: true);
            WorkflowValue.Validate(lockPdfInputpermissionsPassword, nameof(lockPdfInputpermissionsPassword), required: true);
            WorkflowValue.Validate(lockPdfInputallowAccessibility, nameof(lockPdfInputallowAccessibility), required: false);
            WorkflowValue.Validate(lockPdfInputallowCopy, nameof(lockPdfInputallowCopy), required: false);
            WorkflowValue.Validate(lockPdfInputallowDocumentAssembly, nameof(lockPdfInputallowDocumentAssembly), required: false);
            WorkflowValue.Validate(lockPdfInputallowEdit, nameof(lockPdfInputallowEdit), required: false);
            WorkflowValue.Validate(lockPdfInputallowFormFilling, nameof(lockPdfInputallowFormFilling), required: false);
            WorkflowValue.Validate(lockPdfInputallowPrint, nameof(lockPdfInputallowPrint), required: false);
            WorkflowValue.Validate(lockPdfInputallowUpdateAnnotationsAndFields, nameof(lockPdfInputallowUpdateAnnotationsAndFields), required: false);
            WorkflowValue.Validate(lockPdfInputdocumentOpenPassword, nameof(lockPdfInputdocumentOpenPassword), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildMergePdf(WorkflowValue<string> mergePdfInput1stFileContent, WorkflowValue<string> mergePdfInput2ndFileContent, WorkflowValue<string> mergePdfInput3rdFileContent = null, WorkflowValue<string> mergePdfInput4thFileContent = null)
        {
            WorkflowValue.Validate(mergePdfInput1stFileContent, nameof(mergePdfInput1stFileContent), required: true);
            WorkflowValue.Validate(mergePdfInput2ndFileContent, nameof(mergePdfInput2ndFileContent), required: true);
            WorkflowValue.Validate(mergePdfInput3rdFileContent, nameof(mergePdfInput3rdFileContent), required: false);
            WorkflowValue.Validate(mergePdfInput4thFileContent, nameof(mergePdfInput4thFileContent), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildPasswordProtectPdf(WorkflowValue<string> passwordProtectPdfInputfileContent, WorkflowValue<string> passwordProtectPdfInputpassword)
        {
            WorkflowValue.Validate(passwordProtectPdfInputfileContent, nameof(passwordProtectPdfInputfileContent), required: true);
            WorkflowValue.Validate(passwordProtectPdfInputpassword, nameof(passwordProtectPdfInputpassword), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildSplitPdf(WorkflowValue<string> splitPdfInputfileContent, WorkflowValue<int> splitPdfInputfirstPage = null, WorkflowValue<int> splitPdfInputlastPage = null)
        {
            WorkflowValue.Validate(splitPdfInputfileContent, nameof(splitPdfInputfileContent), required: true);
            WorkflowValue.Validate(splitPdfInputfirstPage, nameof(splitPdfInputfirstPage), required: false);
            WorkflowValue.Validate(splitPdfInputlastPage, nameof(splitPdfInputlastPage), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildUnlockPdf(WorkflowValue<string> unlockPdfInputfileContent, WorkflowValue<string> unlockPdfInputpassword)
        {
            WorkflowValue.Validate(unlockPdfInputfileContent, nameof(unlockPdfInputfileContent), required: true);
            WorkflowValue.Validate(unlockPdfInputpassword, nameof(unlockPdfInputpassword), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildWatermarkPdfBackground(WorkflowValue<string> watermarkPdfBackgroundInputfileContent, WorkflowValue<string> watermarkPdfBackgroundInput1stLine, WorkflowValue<watermarkPdfBackgroundInputcolorInput> watermarkPdfBackgroundInputcolor = null, WorkflowValue<string> watermarkPdfBackgroundInput2ndLine = null, WorkflowValue<string> watermarkPdfBackgroundInput3rdLine = null, WorkflowValue<double> watermarkPdfBackgroundInputmargin = null, WorkflowValue<watermarkPdfBackgroundInputorientationInput> watermarkPdfBackgroundInputorientation = null, WorkflowValue<watermarkPdfBackgroundInputstyleInput> watermarkPdfBackgroundInputstyle = null, WorkflowValue<double> watermarkPdfBackgroundInputtransparency = null)
        {
            WorkflowValue.Validate(watermarkPdfBackgroundInputfileContent, nameof(watermarkPdfBackgroundInputfileContent), required: true);
            WorkflowValue.Validate(watermarkPdfBackgroundInput1stLine, nameof(watermarkPdfBackgroundInput1stLine), required: true);
            WorkflowValue.Validate(watermarkPdfBackgroundInputcolor, nameof(watermarkPdfBackgroundInputcolor), required: false);
            WorkflowValue.Validate(watermarkPdfBackgroundInput2ndLine, nameof(watermarkPdfBackgroundInput2ndLine), required: false);
            WorkflowValue.Validate(watermarkPdfBackgroundInput3rdLine, nameof(watermarkPdfBackgroundInput3rdLine), required: false);
            WorkflowValue.Validate(watermarkPdfBackgroundInputmargin, nameof(watermarkPdfBackgroundInputmargin), required: false);
            WorkflowValue.Validate(watermarkPdfBackgroundInputorientation, nameof(watermarkPdfBackgroundInputorientation), required: false);
            WorkflowValue.Validate(watermarkPdfBackgroundInputstyle, nameof(watermarkPdfBackgroundInputstyle), required: false);
            WorkflowValue.Validate(watermarkPdfBackgroundInputtransparency, nameof(watermarkPdfBackgroundInputtransparency), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildWatermarkPdfCustom(WorkflowValue<string> watermarkPdfCustomInputfileContent, WorkflowValue<string> watermarkPdfCustomInputtemplateId, WorkflowValue<string> watermarkPdfCustomInput1stLine = null, WorkflowValue<string> watermarkPdfCustomInput2ndLine = null, WorkflowValue<string> watermarkPdfCustomInput3rdLine = null, WorkflowValue<string> watermarkPdfCustomInput4thLine = null, WorkflowValue<string> watermarkPdfCustomInput5thLine = null)
        {
            WorkflowValue.Validate(watermarkPdfCustomInputfileContent, nameof(watermarkPdfCustomInputfileContent), required: true);
            WorkflowValue.Validate(watermarkPdfCustomInputtemplateId, nameof(watermarkPdfCustomInputtemplateId), required: true);
            WorkflowValue.Validate(watermarkPdfCustomInput1stLine, nameof(watermarkPdfCustomInput1stLine), required: false);
            WorkflowValue.Validate(watermarkPdfCustomInput2ndLine, nameof(watermarkPdfCustomInput2ndLine), required: false);
            WorkflowValue.Validate(watermarkPdfCustomInput3rdLine, nameof(watermarkPdfCustomInput3rdLine), required: false);
            WorkflowValue.Validate(watermarkPdfCustomInput4thLine, nameof(watermarkPdfCustomInput4thLine), required: false);
            WorkflowValue.Validate(watermarkPdfCustomInput5thLine, nameof(watermarkPdfCustomInput5thLine), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildWatermarkPdfOverlay(WorkflowValue<string> watermarkPdfOverlayInputfileContent, WorkflowValue<string> watermarkPdfOverlayInput1stLine, WorkflowValue<watermarkPdfOverlayInputcolorInput> watermarkPdfOverlayInputcolor = null, WorkflowValue<string> watermarkPdfOverlayInput2ndLine = null, WorkflowValue<string> watermarkPdfOverlayInput3rdLine = null, WorkflowValue<double> watermarkPdfOverlayInputmargin = null, WorkflowValue<watermarkPdfOverlayInputorientationInput> watermarkPdfOverlayInputorientation = null, WorkflowValue<watermarkPdfOverlayInputstyleInput> watermarkPdfOverlayInputstyle = null, WorkflowValue<double> watermarkPdfOverlayInputtransparency = null)
        {
            WorkflowValue.Validate(watermarkPdfOverlayInputfileContent, nameof(watermarkPdfOverlayInputfileContent), required: true);
            WorkflowValue.Validate(watermarkPdfOverlayInput1stLine, nameof(watermarkPdfOverlayInput1stLine), required: true);
            WorkflowValue.Validate(watermarkPdfOverlayInputcolor, nameof(watermarkPdfOverlayInputcolor), required: false);
            WorkflowValue.Validate(watermarkPdfOverlayInput2ndLine, nameof(watermarkPdfOverlayInput2ndLine), required: false);
            WorkflowValue.Validate(watermarkPdfOverlayInput3rdLine, nameof(watermarkPdfOverlayInput3rdLine), required: false);
            WorkflowValue.Validate(watermarkPdfOverlayInputmargin, nameof(watermarkPdfOverlayInputmargin), required: false);
            WorkflowValue.Validate(watermarkPdfOverlayInputorientation, nameof(watermarkPdfOverlayInputorientation), required: false);
            WorkflowValue.Validate(watermarkPdfOverlayInputstyle, nameof(watermarkPdfOverlayInputstyle), required: false);
            WorkflowValue.Validate(watermarkPdfOverlayInputtransparency, nameof(watermarkPdfOverlayInputtransparency), required: false);
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
