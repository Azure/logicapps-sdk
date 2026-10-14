//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Integrablepdf
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class IntegrablepdfActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "integrablepdf")]
        public IBodyWorkflowAction<string> LockPdf(Expression<Func<string>> lockPdfInputfileContent, Expression<Func<string>> lockPdfInputpermissionsPassword, Expression<Func<bool>> lockPdfInputallowAccessibility = null, Expression<Func<bool>> lockPdfInputallowCopy = null, Expression<Func<bool>> lockPdfInputallowDocumentAssembly = null, Expression<Func<bool>> lockPdfInputallowEdit = null, Expression<Func<bool>> lockPdfInputallowFormFilling = null, Expression<Func<bool>> lockPdfInputallowPrint = null, Expression<Func<bool>> lockPdfInputallowUpdateAnnotationsAndFields = null, Expression<Func<string>> lockPdfInputdocumentOpenPassword = null)
        {
            var __workflow_lockPdfInputfileContent = lockPdfInputfileContent == null ? null : WorkflowExpression.Compile(lockPdfInputfileContent);
            WorkflowExpression.Validate(__workflow_lockPdfInputfileContent, nameof(lockPdfInputfileContent), required: true);
            var __workflow_lockPdfInputpermissionsPassword = lockPdfInputpermissionsPassword == null ? null : WorkflowExpression.Compile(lockPdfInputpermissionsPassword);
            WorkflowExpression.Validate(__workflow_lockPdfInputpermissionsPassword, nameof(lockPdfInputpermissionsPassword), required: true);
            var __workflow_lockPdfInputallowAccessibility = lockPdfInputallowAccessibility == null ? null : WorkflowExpression.Compile(lockPdfInputallowAccessibility);
            WorkflowExpression.Validate(__workflow_lockPdfInputallowAccessibility, nameof(lockPdfInputallowAccessibility), required: false);
            var __workflow_lockPdfInputallowCopy = lockPdfInputallowCopy == null ? null : WorkflowExpression.Compile(lockPdfInputallowCopy);
            WorkflowExpression.Validate(__workflow_lockPdfInputallowCopy, nameof(lockPdfInputallowCopy), required: false);
            var __workflow_lockPdfInputallowDocumentAssembly = lockPdfInputallowDocumentAssembly == null ? null : WorkflowExpression.Compile(lockPdfInputallowDocumentAssembly);
            WorkflowExpression.Validate(__workflow_lockPdfInputallowDocumentAssembly, nameof(lockPdfInputallowDocumentAssembly), required: false);
            var __workflow_lockPdfInputallowEdit = lockPdfInputallowEdit == null ? null : WorkflowExpression.Compile(lockPdfInputallowEdit);
            WorkflowExpression.Validate(__workflow_lockPdfInputallowEdit, nameof(lockPdfInputallowEdit), required: false);
            var __workflow_lockPdfInputallowFormFilling = lockPdfInputallowFormFilling == null ? null : WorkflowExpression.Compile(lockPdfInputallowFormFilling);
            WorkflowExpression.Validate(__workflow_lockPdfInputallowFormFilling, nameof(lockPdfInputallowFormFilling), required: false);
            var __workflow_lockPdfInputallowPrint = lockPdfInputallowPrint == null ? null : WorkflowExpression.Compile(lockPdfInputallowPrint);
            WorkflowExpression.Validate(__workflow_lockPdfInputallowPrint, nameof(lockPdfInputallowPrint), required: false);
            var __workflow_lockPdfInputallowUpdateAnnotationsAndFields = lockPdfInputallowUpdateAnnotationsAndFields == null ? null : WorkflowExpression.Compile(lockPdfInputallowUpdateAnnotationsAndFields);
            WorkflowExpression.Validate(__workflow_lockPdfInputallowUpdateAnnotationsAndFields, nameof(lockPdfInputallowUpdateAnnotationsAndFields), required: false);
            var __workflow_lockPdfInputdocumentOpenPassword = lockPdfInputdocumentOpenPassword == null ? null : WorkflowExpression.Compile(lockPdfInputdocumentOpenPassword);
            WorkflowExpression.Validate(__workflow_lockPdfInputdocumentOpenPassword, nameof(lockPdfInputdocumentOpenPassword), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/pdf/lock";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/octet-stream");
                var lockPdfInput = new JObject();
                var lockPdfInputpropCount = 0;
                if (__workflow_lockPdfInputallowAccessibility != null)
                {
                    lockPdfInput["allowAccessibility"] = ExpressionConverter.ConvertO(__workflow_lockPdfInputallowAccessibility);
                    lockPdfInputpropCount++;
                }

                if (__workflow_lockPdfInputallowCopy != null)
                {
                    lockPdfInput["allowCopy"] = ExpressionConverter.ConvertO(__workflow_lockPdfInputallowCopy);
                    lockPdfInputpropCount++;
                }

                if (__workflow_lockPdfInputallowDocumentAssembly != null)
                {
                    lockPdfInput["allowDocumentAssembly"] = ExpressionConverter.ConvertO(__workflow_lockPdfInputallowDocumentAssembly);
                    lockPdfInputpropCount++;
                }

                if (__workflow_lockPdfInputallowEdit != null)
                {
                    lockPdfInput["allowEdit"] = ExpressionConverter.ConvertO(__workflow_lockPdfInputallowEdit);
                    lockPdfInputpropCount++;
                }

                if (__workflow_lockPdfInputallowFormFilling != null)
                {
                    lockPdfInput["allowFormFilling"] = ExpressionConverter.ConvertO(__workflow_lockPdfInputallowFormFilling);
                    lockPdfInputpropCount++;
                }

                if (__workflow_lockPdfInputallowPrint != null)
                {
                    lockPdfInput["allowPrint"] = ExpressionConverter.ConvertO(__workflow_lockPdfInputallowPrint);
                    lockPdfInputpropCount++;
                }

                if (__workflow_lockPdfInputallowUpdateAnnotationsAndFields != null)
                {
                    lockPdfInput["allowUpdateAnnotationsAndFields"] = ExpressionConverter.ConvertO(__workflow_lockPdfInputallowUpdateAnnotationsAndFields);
                    lockPdfInputpropCount++;
                }

                if (__workflow_lockPdfInputdocumentOpenPassword != null)
                {
                    lockPdfInput["documentOpenPassword"] = ExpressionConverter.ConvertO(__workflow_lockPdfInputdocumentOpenPassword);
                    lockPdfInputpropCount++;
                }

                lockPdfInputpropCount++;
                lockPdfInput["fileContent"] = ExpressionConverter.ConvertO(__workflow_lockPdfInputfileContent);
                lockPdfInputpropCount++;
                lockPdfInput["permissionsPassword"] = ExpressionConverter.ConvertO(__workflow_lockPdfInputpermissionsPassword);
                if (lockPdfInputpropCount > 0)
                {
                    callPayload.Body = lockPdfInput;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "integrablepdf")]
        public IBodyWorkflowAction<string> MergePdf(Expression<Func<string>> mergePdfInput1stFileContent, Expression<Func<string>> mergePdfInput2ndFileContent, Expression<Func<string>> mergePdfInput3rdFileContent = null, Expression<Func<string>> mergePdfInput4thFileContent = null)
        {
            var __workflow_mergePdfInput1stFileContent = mergePdfInput1stFileContent == null ? null : WorkflowExpression.Compile(mergePdfInput1stFileContent);
            WorkflowExpression.Validate(__workflow_mergePdfInput1stFileContent, nameof(mergePdfInput1stFileContent), required: true);
            var __workflow_mergePdfInput2ndFileContent = mergePdfInput2ndFileContent == null ? null : WorkflowExpression.Compile(mergePdfInput2ndFileContent);
            WorkflowExpression.Validate(__workflow_mergePdfInput2ndFileContent, nameof(mergePdfInput2ndFileContent), required: true);
            var __workflow_mergePdfInput3rdFileContent = mergePdfInput3rdFileContent == null ? null : WorkflowExpression.Compile(mergePdfInput3rdFileContent);
            WorkflowExpression.Validate(__workflow_mergePdfInput3rdFileContent, nameof(mergePdfInput3rdFileContent), required: false);
            var __workflow_mergePdfInput4thFileContent = mergePdfInput4thFileContent == null ? null : WorkflowExpression.Compile(mergePdfInput4thFileContent);
            WorkflowExpression.Validate(__workflow_mergePdfInput4thFileContent, nameof(mergePdfInput4thFileContent), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/pdf/merge";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/octet-stream");
                var mergePdfInput = new JObject();
                var mergePdfInputpropCount = 0;
                mergePdfInputpropCount++;
                mergePdfInput["fileContent1"] = ExpressionConverter.ConvertO(__workflow_mergePdfInput1stFileContent);
                mergePdfInputpropCount++;
                mergePdfInput["fileContent2"] = ExpressionConverter.ConvertO(__workflow_mergePdfInput2ndFileContent);
                if (__workflow_mergePdfInput3rdFileContent != null)
                {
                    mergePdfInput["fileContent3"] = ExpressionConverter.ConvertO(__workflow_mergePdfInput3rdFileContent);
                    mergePdfInputpropCount++;
                }

                if (__workflow_mergePdfInput4thFileContent != null)
                {
                    mergePdfInput["fileContent4"] = ExpressionConverter.ConvertO(__workflow_mergePdfInput4thFileContent);
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
        public IBodyWorkflowAction<string> PasswordProtectPdf(Expression<Func<string>> passwordProtectPdfInputfileContent, Expression<Func<string>> passwordProtectPdfInputpassword)
        {
            var __workflow_passwordProtectPdfInputfileContent = passwordProtectPdfInputfileContent == null ? null : WorkflowExpression.Compile(passwordProtectPdfInputfileContent);
            WorkflowExpression.Validate(__workflow_passwordProtectPdfInputfileContent, nameof(passwordProtectPdfInputfileContent), required: true);
            var __workflow_passwordProtectPdfInputpassword = passwordProtectPdfInputpassword == null ? null : WorkflowExpression.Compile(passwordProtectPdfInputpassword);
            WorkflowExpression.Validate(__workflow_passwordProtectPdfInputpassword, nameof(passwordProtectPdfInputpassword), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/pdf/password_protect";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/octet-stream");
                var passwordProtectPdfInput = new JObject();
                var passwordProtectPdfInputpropCount = 0;
                passwordProtectPdfInputpropCount++;
                passwordProtectPdfInput["fileContent"] = ExpressionConverter.ConvertO(__workflow_passwordProtectPdfInputfileContent);
                passwordProtectPdfInputpropCount++;
                passwordProtectPdfInput["password"] = ExpressionConverter.ConvertO(__workflow_passwordProtectPdfInputpassword);
                if (passwordProtectPdfInputpropCount > 0)
                {
                    callPayload.Body = passwordProtectPdfInput;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "integrablepdf")]
        public IBodyWorkflowAction<string> SplitPdf(Expression<Func<string>> splitPdfInputfileContent, Expression<Func<int>> splitPdfInputfirstPage = null, Expression<Func<int>> splitPdfInputlastPage = null)
        {
            var __workflow_splitPdfInputfileContent = splitPdfInputfileContent == null ? null : WorkflowExpression.Compile(splitPdfInputfileContent);
            WorkflowExpression.Validate(__workflow_splitPdfInputfileContent, nameof(splitPdfInputfileContent), required: true);
            var __workflow_splitPdfInputfirstPage = splitPdfInputfirstPage == null ? null : WorkflowExpression.Compile(splitPdfInputfirstPage);
            WorkflowExpression.Validate(__workflow_splitPdfInputfirstPage, nameof(splitPdfInputfirstPage), required: false);
            var __workflow_splitPdfInputlastPage = splitPdfInputlastPage == null ? null : WorkflowExpression.Compile(splitPdfInputlastPage);
            WorkflowExpression.Validate(__workflow_splitPdfInputlastPage, nameof(splitPdfInputlastPage), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/pdf/split";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/octet-stream");
                var splitPdfInput = new JObject();
                var splitPdfInputpropCount = 0;
                splitPdfInputpropCount++;
                splitPdfInput["fileContent"] = ExpressionConverter.ConvertO(__workflow_splitPdfInputfileContent);
                if (__workflow_splitPdfInputfirstPage != null)
                {
                    splitPdfInput["firstPage"] = ExpressionConverter.ConvertO(__workflow_splitPdfInputfirstPage);
                    splitPdfInputpropCount++;
                }

                if (__workflow_splitPdfInputlastPage != null)
                {
                    splitPdfInput["lastPage"] = ExpressionConverter.ConvertO(__workflow_splitPdfInputlastPage);
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
        public IBodyWorkflowAction<string> UnlockPdf(Expression<Func<string>> unlockPdfInputfileContent, Expression<Func<string>> unlockPdfInputpassword)
        {
            var __workflow_unlockPdfInputfileContent = unlockPdfInputfileContent == null ? null : WorkflowExpression.Compile(unlockPdfInputfileContent);
            WorkflowExpression.Validate(__workflow_unlockPdfInputfileContent, nameof(unlockPdfInputfileContent), required: true);
            var __workflow_unlockPdfInputpassword = unlockPdfInputpassword == null ? null : WorkflowExpression.Compile(unlockPdfInputpassword);
            WorkflowExpression.Validate(__workflow_unlockPdfInputpassword, nameof(unlockPdfInputpassword), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/pdf/unlock";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/octet-stream");
                var unlockPdfInput = new JObject();
                var unlockPdfInputpropCount = 0;
                unlockPdfInputpropCount++;
                unlockPdfInput["fileContent"] = ExpressionConverter.ConvertO(__workflow_unlockPdfInputfileContent);
                unlockPdfInputpropCount++;
                unlockPdfInput["password"] = ExpressionConverter.ConvertO(__workflow_unlockPdfInputpassword);
                if (unlockPdfInputpropCount > 0)
                {
                    callPayload.Body = unlockPdfInput;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "integrablepdf")]
        public IBodyWorkflowAction<string> WatermarkPdfBackground(Expression<Func<string>> watermarkPdfBackgroundInputfileContent, Expression<Func<string>> watermarkPdfBackgroundInput1stLine, Expression<Func<watermarkPdfBackgroundInputcolorInput>> watermarkPdfBackgroundInputcolor = null, Expression<Func<string>> watermarkPdfBackgroundInput2ndLine = null, Expression<Func<string>> watermarkPdfBackgroundInput3rdLine = null, Expression<Func<double>> watermarkPdfBackgroundInputmargin = null, Expression<Func<watermarkPdfBackgroundInputorientationInput>> watermarkPdfBackgroundInputorientation = null, Expression<Func<watermarkPdfBackgroundInputstyleInput>> watermarkPdfBackgroundInputstyle = null, Expression<Func<double>> watermarkPdfBackgroundInputtransparency = null)
        {
            var __workflow_watermarkPdfBackgroundInputfileContent = watermarkPdfBackgroundInputfileContent == null ? null : WorkflowExpression.Compile(watermarkPdfBackgroundInputfileContent);
            WorkflowExpression.Validate(__workflow_watermarkPdfBackgroundInputfileContent, nameof(watermarkPdfBackgroundInputfileContent), required: true);
            var __workflow_watermarkPdfBackgroundInput1stLine = watermarkPdfBackgroundInput1stLine == null ? null : WorkflowExpression.Compile(watermarkPdfBackgroundInput1stLine);
            WorkflowExpression.Validate(__workflow_watermarkPdfBackgroundInput1stLine, nameof(watermarkPdfBackgroundInput1stLine), required: true);
            var __workflow_watermarkPdfBackgroundInputcolor = watermarkPdfBackgroundInputcolor == null ? null : WorkflowExpression.Compile(watermarkPdfBackgroundInputcolor);
            WorkflowExpression.Validate(__workflow_watermarkPdfBackgroundInputcolor, nameof(watermarkPdfBackgroundInputcolor), required: false);
            var __workflow_watermarkPdfBackgroundInput2ndLine = watermarkPdfBackgroundInput2ndLine == null ? null : WorkflowExpression.Compile(watermarkPdfBackgroundInput2ndLine);
            WorkflowExpression.Validate(__workflow_watermarkPdfBackgroundInput2ndLine, nameof(watermarkPdfBackgroundInput2ndLine), required: false);
            var __workflow_watermarkPdfBackgroundInput3rdLine = watermarkPdfBackgroundInput3rdLine == null ? null : WorkflowExpression.Compile(watermarkPdfBackgroundInput3rdLine);
            WorkflowExpression.Validate(__workflow_watermarkPdfBackgroundInput3rdLine, nameof(watermarkPdfBackgroundInput3rdLine), required: false);
            var __workflow_watermarkPdfBackgroundInputmargin = watermarkPdfBackgroundInputmargin == null ? null : WorkflowExpression.Compile(watermarkPdfBackgroundInputmargin);
            WorkflowExpression.Validate(__workflow_watermarkPdfBackgroundInputmargin, nameof(watermarkPdfBackgroundInputmargin), required: false);
            var __workflow_watermarkPdfBackgroundInputorientation = watermarkPdfBackgroundInputorientation == null ? null : WorkflowExpression.Compile(watermarkPdfBackgroundInputorientation);
            WorkflowExpression.Validate(__workflow_watermarkPdfBackgroundInputorientation, nameof(watermarkPdfBackgroundInputorientation), required: false);
            var __workflow_watermarkPdfBackgroundInputstyle = watermarkPdfBackgroundInputstyle == null ? null : WorkflowExpression.Compile(watermarkPdfBackgroundInputstyle);
            WorkflowExpression.Validate(__workflow_watermarkPdfBackgroundInputstyle, nameof(watermarkPdfBackgroundInputstyle), required: false);
            var __workflow_watermarkPdfBackgroundInputtransparency = watermarkPdfBackgroundInputtransparency == null ? null : WorkflowExpression.Compile(watermarkPdfBackgroundInputtransparency);
            WorkflowExpression.Validate(__workflow_watermarkPdfBackgroundInputtransparency, nameof(watermarkPdfBackgroundInputtransparency), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/pdf/watermark/background";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/octet-stream");
                var watermarkPdfBackgroundInput = new JObject();
                var watermarkPdfBackgroundInputpropCount = 0;
                if (__workflow_watermarkPdfBackgroundInputcolor != null)
                {
                    watermarkPdfBackgroundInput["color"] = ExpressionConverter.ConvertO(__workflow_watermarkPdfBackgroundInputcolor);
                    watermarkPdfBackgroundInputpropCount++;
                }

                watermarkPdfBackgroundInputpropCount++;
                watermarkPdfBackgroundInput["fileContent"] = ExpressionConverter.ConvertO(__workflow_watermarkPdfBackgroundInputfileContent);
                watermarkPdfBackgroundInputpropCount++;
                watermarkPdfBackgroundInput["line1"] = ExpressionConverter.ConvertO(__workflow_watermarkPdfBackgroundInput1stLine);
                if (__workflow_watermarkPdfBackgroundInput2ndLine != null)
                {
                    watermarkPdfBackgroundInput["line2"] = ExpressionConverter.ConvertO(__workflow_watermarkPdfBackgroundInput2ndLine);
                    watermarkPdfBackgroundInputpropCount++;
                }

                if (__workflow_watermarkPdfBackgroundInput3rdLine != null)
                {
                    watermarkPdfBackgroundInput["line3"] = ExpressionConverter.ConvertO(__workflow_watermarkPdfBackgroundInput3rdLine);
                    watermarkPdfBackgroundInputpropCount++;
                }

                if (__workflow_watermarkPdfBackgroundInputmargin != null)
                {
                    watermarkPdfBackgroundInput["margin"] = ExpressionConverter.ConvertO(__workflow_watermarkPdfBackgroundInputmargin);
                    watermarkPdfBackgroundInputpropCount++;
                }

                if (__workflow_watermarkPdfBackgroundInputorientation != null)
                {
                    watermarkPdfBackgroundInput["orientation"] = ExpressionConverter.ConvertO(__workflow_watermarkPdfBackgroundInputorientation);
                    watermarkPdfBackgroundInputpropCount++;
                }

                if (__workflow_watermarkPdfBackgroundInputstyle != null)
                {
                    watermarkPdfBackgroundInput["style"] = ExpressionConverter.ConvertO(__workflow_watermarkPdfBackgroundInputstyle);
                    watermarkPdfBackgroundInputpropCount++;
                }

                if (__workflow_watermarkPdfBackgroundInputtransparency != null)
                {
                    watermarkPdfBackgroundInput["transparency"] = ExpressionConverter.ConvertO(__workflow_watermarkPdfBackgroundInputtransparency);
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
        public IBodyWorkflowAction<string> WatermarkPdfCustom(Expression<Func<string>> watermarkPdfCustomInputfileContent, Expression<Func<string>> watermarkPdfCustomInputtemplateId, Expression<Func<string>> watermarkPdfCustomInput1stLine = null, Expression<Func<string>> watermarkPdfCustomInput2ndLine = null, Expression<Func<string>> watermarkPdfCustomInput3rdLine = null, Expression<Func<string>> watermarkPdfCustomInput4thLine = null, Expression<Func<string>> watermarkPdfCustomInput5thLine = null)
        {
            var __workflow_watermarkPdfCustomInputfileContent = watermarkPdfCustomInputfileContent == null ? null : WorkflowExpression.Compile(watermarkPdfCustomInputfileContent);
            WorkflowExpression.Validate(__workflow_watermarkPdfCustomInputfileContent, nameof(watermarkPdfCustomInputfileContent), required: true);
            var __workflow_watermarkPdfCustomInputtemplateId = watermarkPdfCustomInputtemplateId == null ? null : WorkflowExpression.Compile(watermarkPdfCustomInputtemplateId);
            WorkflowExpression.Validate(__workflow_watermarkPdfCustomInputtemplateId, nameof(watermarkPdfCustomInputtemplateId), required: true);
            var __workflow_watermarkPdfCustomInput1stLine = watermarkPdfCustomInput1stLine == null ? null : WorkflowExpression.Compile(watermarkPdfCustomInput1stLine);
            WorkflowExpression.Validate(__workflow_watermarkPdfCustomInput1stLine, nameof(watermarkPdfCustomInput1stLine), required: false);
            var __workflow_watermarkPdfCustomInput2ndLine = watermarkPdfCustomInput2ndLine == null ? null : WorkflowExpression.Compile(watermarkPdfCustomInput2ndLine);
            WorkflowExpression.Validate(__workflow_watermarkPdfCustomInput2ndLine, nameof(watermarkPdfCustomInput2ndLine), required: false);
            var __workflow_watermarkPdfCustomInput3rdLine = watermarkPdfCustomInput3rdLine == null ? null : WorkflowExpression.Compile(watermarkPdfCustomInput3rdLine);
            WorkflowExpression.Validate(__workflow_watermarkPdfCustomInput3rdLine, nameof(watermarkPdfCustomInput3rdLine), required: false);
            var __workflow_watermarkPdfCustomInput4thLine = watermarkPdfCustomInput4thLine == null ? null : WorkflowExpression.Compile(watermarkPdfCustomInput4thLine);
            WorkflowExpression.Validate(__workflow_watermarkPdfCustomInput4thLine, nameof(watermarkPdfCustomInput4thLine), required: false);
            var __workflow_watermarkPdfCustomInput5thLine = watermarkPdfCustomInput5thLine == null ? null : WorkflowExpression.Compile(watermarkPdfCustomInput5thLine);
            WorkflowExpression.Validate(__workflow_watermarkPdfCustomInput5thLine, nameof(watermarkPdfCustomInput5thLine), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/pdf/watermark/custom";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/octet-stream");
                var watermarkPdfCustomInput = new JObject();
                var watermarkPdfCustomInputpropCount = 0;
                watermarkPdfCustomInputpropCount++;
                watermarkPdfCustomInput["fileContent"] = ExpressionConverter.ConvertO(__workflow_watermarkPdfCustomInputfileContent);
                if (__workflow_watermarkPdfCustomInput1stLine != null)
                {
                    watermarkPdfCustomInput["line1"] = ExpressionConverter.ConvertO(__workflow_watermarkPdfCustomInput1stLine);
                    watermarkPdfCustomInputpropCount++;
                }

                if (__workflow_watermarkPdfCustomInput2ndLine != null)
                {
                    watermarkPdfCustomInput["line2"] = ExpressionConverter.ConvertO(__workflow_watermarkPdfCustomInput2ndLine);
                    watermarkPdfCustomInputpropCount++;
                }

                if (__workflow_watermarkPdfCustomInput3rdLine != null)
                {
                    watermarkPdfCustomInput["line3"] = ExpressionConverter.ConvertO(__workflow_watermarkPdfCustomInput3rdLine);
                    watermarkPdfCustomInputpropCount++;
                }

                if (__workflow_watermarkPdfCustomInput4thLine != null)
                {
                    watermarkPdfCustomInput["line4"] = ExpressionConverter.ConvertO(__workflow_watermarkPdfCustomInput4thLine);
                    watermarkPdfCustomInputpropCount++;
                }

                if (__workflow_watermarkPdfCustomInput5thLine != null)
                {
                    watermarkPdfCustomInput["line5"] = ExpressionConverter.ConvertO(__workflow_watermarkPdfCustomInput5thLine);
                    watermarkPdfCustomInputpropCount++;
                }

                watermarkPdfCustomInputpropCount++;
                watermarkPdfCustomInput["templateId"] = ExpressionConverter.ConvertO(__workflow_watermarkPdfCustomInputtemplateId);
                if (watermarkPdfCustomInputpropCount > 0)
                {
                    callPayload.Body = watermarkPdfCustomInput;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "integrablepdf")]
        public IBodyWorkflowAction<string> WatermarkPdfOverlay(Expression<Func<string>> watermarkPdfOverlayInputfileContent, Expression<Func<string>> watermarkPdfOverlayInput1stLine, Expression<Func<watermarkPdfOverlayInputcolorInput>> watermarkPdfOverlayInputcolor = null, Expression<Func<string>> watermarkPdfOverlayInput2ndLine = null, Expression<Func<string>> watermarkPdfOverlayInput3rdLine = null, Expression<Func<double>> watermarkPdfOverlayInputmargin = null, Expression<Func<watermarkPdfOverlayInputorientationInput>> watermarkPdfOverlayInputorientation = null, Expression<Func<watermarkPdfOverlayInputstyleInput>> watermarkPdfOverlayInputstyle = null, Expression<Func<double>> watermarkPdfOverlayInputtransparency = null)
        {
            var __workflow_watermarkPdfOverlayInputfileContent = watermarkPdfOverlayInputfileContent == null ? null : WorkflowExpression.Compile(watermarkPdfOverlayInputfileContent);
            WorkflowExpression.Validate(__workflow_watermarkPdfOverlayInputfileContent, nameof(watermarkPdfOverlayInputfileContent), required: true);
            var __workflow_watermarkPdfOverlayInput1stLine = watermarkPdfOverlayInput1stLine == null ? null : WorkflowExpression.Compile(watermarkPdfOverlayInput1stLine);
            WorkflowExpression.Validate(__workflow_watermarkPdfOverlayInput1stLine, nameof(watermarkPdfOverlayInput1stLine), required: true);
            var __workflow_watermarkPdfOverlayInputcolor = watermarkPdfOverlayInputcolor == null ? null : WorkflowExpression.Compile(watermarkPdfOverlayInputcolor);
            WorkflowExpression.Validate(__workflow_watermarkPdfOverlayInputcolor, nameof(watermarkPdfOverlayInputcolor), required: false);
            var __workflow_watermarkPdfOverlayInput2ndLine = watermarkPdfOverlayInput2ndLine == null ? null : WorkflowExpression.Compile(watermarkPdfOverlayInput2ndLine);
            WorkflowExpression.Validate(__workflow_watermarkPdfOverlayInput2ndLine, nameof(watermarkPdfOverlayInput2ndLine), required: false);
            var __workflow_watermarkPdfOverlayInput3rdLine = watermarkPdfOverlayInput3rdLine == null ? null : WorkflowExpression.Compile(watermarkPdfOverlayInput3rdLine);
            WorkflowExpression.Validate(__workflow_watermarkPdfOverlayInput3rdLine, nameof(watermarkPdfOverlayInput3rdLine), required: false);
            var __workflow_watermarkPdfOverlayInputmargin = watermarkPdfOverlayInputmargin == null ? null : WorkflowExpression.Compile(watermarkPdfOverlayInputmargin);
            WorkflowExpression.Validate(__workflow_watermarkPdfOverlayInputmargin, nameof(watermarkPdfOverlayInputmargin), required: false);
            var __workflow_watermarkPdfOverlayInputorientation = watermarkPdfOverlayInputorientation == null ? null : WorkflowExpression.Compile(watermarkPdfOverlayInputorientation);
            WorkflowExpression.Validate(__workflow_watermarkPdfOverlayInputorientation, nameof(watermarkPdfOverlayInputorientation), required: false);
            var __workflow_watermarkPdfOverlayInputstyle = watermarkPdfOverlayInputstyle == null ? null : WorkflowExpression.Compile(watermarkPdfOverlayInputstyle);
            WorkflowExpression.Validate(__workflow_watermarkPdfOverlayInputstyle, nameof(watermarkPdfOverlayInputstyle), required: false);
            var __workflow_watermarkPdfOverlayInputtransparency = watermarkPdfOverlayInputtransparency == null ? null : WorkflowExpression.Compile(watermarkPdfOverlayInputtransparency);
            WorkflowExpression.Validate(__workflow_watermarkPdfOverlayInputtransparency, nameof(watermarkPdfOverlayInputtransparency), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/pdf/watermark/overlay";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/octet-stream");
                var watermarkPdfOverlayInput = new JObject();
                var watermarkPdfOverlayInputpropCount = 0;
                if (__workflow_watermarkPdfOverlayInputcolor != null)
                {
                    watermarkPdfOverlayInput["color"] = ExpressionConverter.ConvertO(__workflow_watermarkPdfOverlayInputcolor);
                    watermarkPdfOverlayInputpropCount++;
                }

                watermarkPdfOverlayInputpropCount++;
                watermarkPdfOverlayInput["fileContent"] = ExpressionConverter.ConvertO(__workflow_watermarkPdfOverlayInputfileContent);
                watermarkPdfOverlayInputpropCount++;
                watermarkPdfOverlayInput["line1"] = ExpressionConverter.ConvertO(__workflow_watermarkPdfOverlayInput1stLine);
                if (__workflow_watermarkPdfOverlayInput2ndLine != null)
                {
                    watermarkPdfOverlayInput["line2"] = ExpressionConverter.ConvertO(__workflow_watermarkPdfOverlayInput2ndLine);
                    watermarkPdfOverlayInputpropCount++;
                }

                if (__workflow_watermarkPdfOverlayInput3rdLine != null)
                {
                    watermarkPdfOverlayInput["line3"] = ExpressionConverter.ConvertO(__workflow_watermarkPdfOverlayInput3rdLine);
                    watermarkPdfOverlayInputpropCount++;
                }

                if (__workflow_watermarkPdfOverlayInputmargin != null)
                {
                    watermarkPdfOverlayInput["margin"] = ExpressionConverter.ConvertO(__workflow_watermarkPdfOverlayInputmargin);
                    watermarkPdfOverlayInputpropCount++;
                }

                if (__workflow_watermarkPdfOverlayInputorientation != null)
                {
                    watermarkPdfOverlayInput["orientation"] = ExpressionConverter.ConvertO(__workflow_watermarkPdfOverlayInputorientation);
                    watermarkPdfOverlayInputpropCount++;
                }

                if (__workflow_watermarkPdfOverlayInputstyle != null)
                {
                    watermarkPdfOverlayInput["style"] = ExpressionConverter.ConvertO(__workflow_watermarkPdfOverlayInputstyle);
                    watermarkPdfOverlayInputpropCount++;
                }

                if (__workflow_watermarkPdfOverlayInputtransparency != null)
                {
                    watermarkPdfOverlayInput["transparency"] = ExpressionConverter.ConvertO(__workflow_watermarkPdfOverlayInputtransparency);
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
