//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cloudmersivepdf
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CloudmersivepdfActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivepdf")]
        public IBodyWorkflowAction<string> EditPdfAddAnnotations(Expression<Func<PdfAnnotation[]>> requestannotationsToAdd = null, Expression<Func<string>> requestinputFileBytes = null)
        {
            var __workflow_requestannotationsToAdd = WorkflowExpression.Compile(requestannotationsToAdd, nameof(requestannotationsToAdd), required: false);
            var __workflow_requestinputFileBytes = WorkflowExpression.Compile(requestinputFileBytes, nameof(requestinputFileBytes), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/convert/edit/pdf/annotations/add-item";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (__workflow_requestannotationsToAdd != null)
                {
                    request["AnnotationsToAdd"] = ExpressionConverter.ConvertO(__workflow_requestannotationsToAdd);
                    requestpropCount++;
                }

                if (__workflow_requestinputFileBytes != null)
                {
                    request["InputFileBytes"] = ExpressionConverter.ConvertO(__workflow_requestinputFileBytes);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivepdf")]
        public IBodyWorkflowAction<GetPdfAnnotationsResult> EditPdfGetAnnotations(Expression<Func<object>> inputFile)
        {
            var __workflow_inputFile = WorkflowExpression.Compile(inputFile, nameof(inputFile), required: true);
            return new DeferredBodyAction<GetPdfAnnotationsResult>(() =>
            {
                var apiCallPath = "/convert/edit/pdf/annotations/list";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetPdfAnnotationsResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivepdf")]
        public IBodyWorkflowAction<string> EditPdfRemoveAllAnnotations(Expression<Func<object>> inputFile)
        {
            var __workflow_inputFile = WorkflowExpression.Compile(inputFile, nameof(inputFile), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/convert/edit/pdf/annotations/remove-all";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivepdf")]
        public IBodyWorkflowAction<string> EditPdfRemoveAnnotationItem(Expression<Func<object>> inputFile, Expression<Func<int>> annotationIndex)
        {
            var __workflow_inputFile = WorkflowExpression.Compile(inputFile, nameof(inputFile), required: true);
            var __workflow_annotationIndex = WorkflowExpression.Compile(annotationIndex, nameof(annotationIndex), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/convert/edit/pdf/annotations/remove-item";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["annotationIndex"] = ExpressionConverter.Convert(__workflow_annotationIndex);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivepdf")]
        public IBodyWorkflowAction<string> EditPdfDecrypt(Expression<Func<string>> password, Expression<Func<object>> inputFile)
        {
            var __workflow_password = WorkflowExpression.Compile(password, nameof(password), required: true);
            var __workflow_inputFile = WorkflowExpression.Compile(inputFile, nameof(inputFile), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/convert/edit/pdf/decrypt";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["password"] = ExpressionConverter.Convert(__workflow_password);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivepdf")]
        public IBodyWorkflowAction<string> EditPdfEncrypt(Expression<Func<object>> inputFile, Expression<Func<string>> userPassword = null, Expression<Func<string>> ownerPassword = null, Expression<Func<string>> encryptionKeyLength = null)
        {
            var __workflow_inputFile = WorkflowExpression.Compile(inputFile, nameof(inputFile), required: true);
            var __workflow_userPassword = WorkflowExpression.Compile(userPassword, nameof(userPassword), required: false);
            var __workflow_ownerPassword = WorkflowExpression.Compile(ownerPassword, nameof(ownerPassword), required: false);
            var __workflow_encryptionKeyLength = WorkflowExpression.Compile(encryptionKeyLength, nameof(encryptionKeyLength), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/convert/edit/pdf/encrypt";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_userPassword != null)
                    callPayload.Headers["userPassword"] = ExpressionConverter.Convert(__workflow_userPassword);
                if (__workflow_ownerPassword != null)
                    callPayload.Headers["ownerPassword"] = ExpressionConverter.Convert(__workflow_ownerPassword);
                if (__workflow_encryptionKeyLength != null)
                    callPayload.Headers["encryptionKeyLength"] = ExpressionConverter.Convert(__workflow_encryptionKeyLength);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivepdf")]
        public IBodyWorkflowAction<string> EditPdfSetPermissions(Expression<Func<string>> ownerPassword, Expression<Func<string>> userPassword, Expression<Func<object>> inputFile, Expression<Func<string>> encryptionKeyLength = null, Expression<Func<bool>> allowPrinting = null, Expression<Func<bool>> allowDocumentAssembly = null, Expression<Func<bool>> allowContentExtraction = null, Expression<Func<bool>> allowFormFilling = null, Expression<Func<bool>> allowEditing = null, Expression<Func<bool>> allowAnnotations = null, Expression<Func<bool>> allowDegradedPrinting = null)
        {
            var __workflow_ownerPassword = WorkflowExpression.Compile(ownerPassword, nameof(ownerPassword), required: true);
            var __workflow_userPassword = WorkflowExpression.Compile(userPassword, nameof(userPassword), required: true);
            var __workflow_inputFile = WorkflowExpression.Compile(inputFile, nameof(inputFile), required: true);
            var __workflow_encryptionKeyLength = WorkflowExpression.Compile(encryptionKeyLength, nameof(encryptionKeyLength), required: false);
            var __workflow_allowPrinting = WorkflowExpression.Compile(allowPrinting, nameof(allowPrinting), required: false);
            var __workflow_allowDocumentAssembly = WorkflowExpression.Compile(allowDocumentAssembly, nameof(allowDocumentAssembly), required: false);
            var __workflow_allowContentExtraction = WorkflowExpression.Compile(allowContentExtraction, nameof(allowContentExtraction), required: false);
            var __workflow_allowFormFilling = WorkflowExpression.Compile(allowFormFilling, nameof(allowFormFilling), required: false);
            var __workflow_allowEditing = WorkflowExpression.Compile(allowEditing, nameof(allowEditing), required: false);
            var __workflow_allowAnnotations = WorkflowExpression.Compile(allowAnnotations, nameof(allowAnnotations), required: false);
            var __workflow_allowDegradedPrinting = WorkflowExpression.Compile(allowDegradedPrinting, nameof(allowDegradedPrinting), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/convert/edit/pdf/encrypt/set-permissions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["ownerPassword"] = ExpressionConverter.Convert(__workflow_ownerPassword);
                callPayload.Headers["userPassword"] = ExpressionConverter.Convert(__workflow_userPassword);
                if (__workflow_encryptionKeyLength != null)
                    callPayload.Headers["encryptionKeyLength"] = ExpressionConverter.Convert(__workflow_encryptionKeyLength);
                if (__workflow_allowPrinting != null)
                    callPayload.Headers["allowPrinting"] = ExpressionConverter.Convert(__workflow_allowPrinting);
                if (__workflow_allowDocumentAssembly != null)
                    callPayload.Headers["allowDocumentAssembly"] = ExpressionConverter.Convert(__workflow_allowDocumentAssembly);
                if (__workflow_allowContentExtraction != null)
                    callPayload.Headers["allowContentExtraction"] = ExpressionConverter.Convert(__workflow_allowContentExtraction);
                if (__workflow_allowFormFilling != null)
                    callPayload.Headers["allowFormFilling"] = ExpressionConverter.Convert(__workflow_allowFormFilling);
                if (__workflow_allowEditing != null)
                    callPayload.Headers["allowEditing"] = ExpressionConverter.Convert(__workflow_allowEditing);
                if (__workflow_allowAnnotations != null)
                    callPayload.Headers["allowAnnotations"] = ExpressionConverter.Convert(__workflow_allowAnnotations);
                if (__workflow_allowDegradedPrinting != null)
                    callPayload.Headers["allowDegradedPrinting"] = ExpressionConverter.Convert(__workflow_allowDegradedPrinting);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivepdf")]
        public IBodyWorkflowAction<PdfFormFields> EditPdfGetFormFields(Expression<Func<object>> inputFile)
        {
            var __workflow_inputFile = WorkflowExpression.Compile(inputFile, nameof(inputFile), required: true);
            return new DeferredBodyAction<PdfFormFields>(() =>
            {
                var apiCallPath = "/convert/edit/pdf/form/get-fields";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<PdfFormFields>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivepdf")]
        public IBodyWorkflowAction<string> EditPdfSetFormFields(Expression<Func<SetFormFieldValue[]>> fieldValuesfieldValues = null, Expression<Func<string>> fieldValuesinputFileBytes = null)
        {
            var __workflow_fieldValuesfieldValues = WorkflowExpression.Compile(fieldValuesfieldValues, nameof(fieldValuesfieldValues), required: false);
            var __workflow_fieldValuesinputFileBytes = WorkflowExpression.Compile(fieldValuesinputFileBytes, nameof(fieldValuesinputFileBytes), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/convert/edit/pdf/form/set-fields";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var fieldValues = new JObject();
                var fieldValuespropCount = 0;
                if (__workflow_fieldValuesfieldValues != null)
                {
                    fieldValues["FieldValues"] = ExpressionConverter.ConvertO(__workflow_fieldValuesfieldValues);
                    fieldValuespropCount++;
                }

                if (__workflow_fieldValuesinputFileBytes != null)
                {
                    fieldValues["InputFileBytes"] = ExpressionConverter.ConvertO(__workflow_fieldValuesinputFileBytes);
                    fieldValuespropCount++;
                }

                if (fieldValuespropCount > 0)
                {
                    callPayload.Body = fieldValues;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivepdf")]
        public IBodyWorkflowAction<PdfMetadata> EditPdfGetMetadata(Expression<Func<object>> inputFile)
        {
            var __workflow_inputFile = WorkflowExpression.Compile(inputFile, nameof(inputFile), required: true);
            return new DeferredBodyAction<PdfMetadata>(() =>
            {
                var apiCallPath = "/convert/edit/pdf/get-metadata";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<PdfMetadata>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivepdf")]
        public IBodyWorkflowAction<string> EditPdfDeletePages(Expression<Func<object>> inputFile, Expression<Func<int>> pageStart, Expression<Func<int>> pageEnd)
        {
            var __workflow_inputFile = WorkflowExpression.Compile(inputFile, nameof(inputFile), required: true);
            var __workflow_pageStart = WorkflowExpression.Compile(pageStart, nameof(pageStart), required: true);
            var __workflow_pageEnd = WorkflowExpression.Compile(pageEnd, nameof(pageEnd), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/convert/edit/pdf/pages/delete";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["pageStart"] = ExpressionConverter.Convert(__workflow_pageStart);
                callPayload.Headers["pageEnd"] = ExpressionConverter.Convert(__workflow_pageEnd);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivepdf")]
        public IBodyWorkflowAction<PdfTextByPageResult> EditPdfGetPdfTextByPages(Expression<Func<object>> inputFile)
        {
            var __workflow_inputFile = WorkflowExpression.Compile(inputFile, nameof(inputFile), required: true);
            return new DeferredBodyAction<PdfTextByPageResult>(() =>
            {
                var apiCallPath = "/convert/edit/pdf/pages/get-text";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<PdfTextByPageResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivepdf")]
        public IBodyWorkflowAction<string> EditPdfInsertPages(Expression<Func<object>> sourceFile, Expression<Func<object>> destinationFile, Expression<Func<int>> pageStartSource, Expression<Func<int>> pageEndSource, Expression<Func<int>> pageInsertBeforeDesitnation)
        {
            var __workflow_sourceFile = WorkflowExpression.Compile(sourceFile, nameof(sourceFile), required: true);
            var __workflow_destinationFile = WorkflowExpression.Compile(destinationFile, nameof(destinationFile), required: true);
            var __workflow_pageStartSource = WorkflowExpression.Compile(pageStartSource, nameof(pageStartSource), required: true);
            var __workflow_pageEndSource = WorkflowExpression.Compile(pageEndSource, nameof(pageEndSource), required: true);
            var __workflow_pageInsertBeforeDesitnation = WorkflowExpression.Compile(pageInsertBeforeDesitnation, nameof(pageInsertBeforeDesitnation), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/convert/edit/pdf/pages/insert";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["pageStartSource"] = ExpressionConverter.Convert(__workflow_pageStartSource);
                callPayload.Headers["pageEndSource"] = ExpressionConverter.Convert(__workflow_pageEndSource);
                callPayload.Headers["pageInsertBeforeDesitnation"] = ExpressionConverter.Convert(__workflow_pageInsertBeforeDesitnation);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivepdf")]
        public IBodyWorkflowAction<string> EditPdfRotateAllPages(Expression<Func<object>> inputFile, Expression<Func<int>> rotationAngle)
        {
            var __workflow_inputFile = WorkflowExpression.Compile(inputFile, nameof(inputFile), required: true);
            var __workflow_rotationAngle = WorkflowExpression.Compile(rotationAngle, nameof(rotationAngle), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/convert/edit/pdf/pages/rotate/all";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["rotationAngle"] = ExpressionConverter.Convert(__workflow_rotationAngle);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivepdf")]
        public IBodyWorkflowAction<string> EditPdfRotatePageRange(Expression<Func<object>> inputFile, Expression<Func<int>> rotationAngle, Expression<Func<int>> pageStart, Expression<Func<int>> pageEnd)
        {
            var __workflow_inputFile = WorkflowExpression.Compile(inputFile, nameof(inputFile), required: true);
            var __workflow_rotationAngle = WorkflowExpression.Compile(rotationAngle, nameof(rotationAngle), required: true);
            var __workflow_pageStart = WorkflowExpression.Compile(pageStart, nameof(pageStart), required: true);
            var __workflow_pageEnd = WorkflowExpression.Compile(pageEnd, nameof(pageEnd), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/convert/edit/pdf/pages/rotate/page-range";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["rotationAngle"] = ExpressionConverter.Convert(__workflow_rotationAngle);
                callPayload.Headers["pageStart"] = ExpressionConverter.Convert(__workflow_pageStart);
                callPayload.Headers["pageEnd"] = ExpressionConverter.Convert(__workflow_pageEnd);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivepdf")]
        public IBodyWorkflowAction<string> EditPdfRasterize(Expression<Func<object>> inputFile)
        {
            var __workflow_inputFile = WorkflowExpression.Compile(inputFile, nameof(inputFile), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/convert/edit/pdf/rasterize";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivepdf")]
        public IBodyWorkflowAction<string> EditPdfSetMetadata(Expression<Func<string>> requestinputFileBytes = null, Expression<Func<string>> requestmetadataToSetauthor = null, Expression<Func<string>> requestmetadataToSetcreator = null, Expression<Func<string>> requestmetadataToSetdateCreated = null, Expression<Func<string>> requestmetadataToSetdateModified = null, Expression<Func<string>> requestmetadataToSetkeywords = null, Expression<Func<int>> requestmetadataToSetpageCount = null, Expression<Func<string>> requestmetadataToSetsubject = null, Expression<Func<bool>> requestmetadataToSetsuccessful = null, Expression<Func<string>> requestmetadataToSettitle = null)
        {
            var __workflow_requestinputFileBytes = WorkflowExpression.Compile(requestinputFileBytes, nameof(requestinputFileBytes), required: false);
            var __workflow_requestmetadataToSetauthor = WorkflowExpression.Compile(requestmetadataToSetauthor, nameof(requestmetadataToSetauthor), required: false);
            var __workflow_requestmetadataToSetcreator = WorkflowExpression.Compile(requestmetadataToSetcreator, nameof(requestmetadataToSetcreator), required: false);
            var __workflow_requestmetadataToSetdateCreated = WorkflowExpression.Compile(requestmetadataToSetdateCreated, nameof(requestmetadataToSetdateCreated), required: false);
            var __workflow_requestmetadataToSetdateModified = WorkflowExpression.Compile(requestmetadataToSetdateModified, nameof(requestmetadataToSetdateModified), required: false);
            var __workflow_requestmetadataToSetkeywords = WorkflowExpression.Compile(requestmetadataToSetkeywords, nameof(requestmetadataToSetkeywords), required: false);
            var __workflow_requestmetadataToSetpageCount = WorkflowExpression.Compile(requestmetadataToSetpageCount, nameof(requestmetadataToSetpageCount), required: false);
            var __workflow_requestmetadataToSetsubject = WorkflowExpression.Compile(requestmetadataToSetsubject, nameof(requestmetadataToSetsubject), required: false);
            var __workflow_requestmetadataToSetsuccessful = WorkflowExpression.Compile(requestmetadataToSetsuccessful, nameof(requestmetadataToSetsuccessful), required: false);
            var __workflow_requestmetadataToSettitle = WorkflowExpression.Compile(requestmetadataToSettitle, nameof(requestmetadataToSettitle), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/convert/edit/pdf/set-metadata";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (__workflow_requestinputFileBytes != null)
                {
                    request["InputFileBytes"] = ExpressionConverter.ConvertO(__workflow_requestinputFileBytes);
                    requestpropCount++;
                }

                var metadataToSetObject = new JObject();
                var metadataToSetObjectpropCount = 0;
                if (__workflow_requestmetadataToSetauthor != null)
                {
                    metadataToSetObject["Author"] = ExpressionConverter.ConvertO(__workflow_requestmetadataToSetauthor);
                    metadataToSetObjectpropCount++;
                }

                if (__workflow_requestmetadataToSetcreator != null)
                {
                    metadataToSetObject["Creator"] = ExpressionConverter.ConvertO(__workflow_requestmetadataToSetcreator);
                    metadataToSetObjectpropCount++;
                }

                if (__workflow_requestmetadataToSetdateCreated != null)
                {
                    metadataToSetObject["DateCreated"] = ExpressionConverter.ConvertO(__workflow_requestmetadataToSetdateCreated);
                    metadataToSetObjectpropCount++;
                }

                if (__workflow_requestmetadataToSetdateModified != null)
                {
                    metadataToSetObject["DateModified"] = ExpressionConverter.ConvertO(__workflow_requestmetadataToSetdateModified);
                    metadataToSetObjectpropCount++;
                }

                if (__workflow_requestmetadataToSetkeywords != null)
                {
                    metadataToSetObject["Keywords"] = ExpressionConverter.ConvertO(__workflow_requestmetadataToSetkeywords);
                    metadataToSetObjectpropCount++;
                }

                if (__workflow_requestmetadataToSetpageCount != null)
                {
                    metadataToSetObject["PageCount"] = ExpressionConverter.ConvertO(__workflow_requestmetadataToSetpageCount);
                    metadataToSetObjectpropCount++;
                }

                if (__workflow_requestmetadataToSetsubject != null)
                {
                    metadataToSetObject["Subject"] = ExpressionConverter.ConvertO(__workflow_requestmetadataToSetsubject);
                    metadataToSetObjectpropCount++;
                }

                if (__workflow_requestmetadataToSetsuccessful != null)
                {
                    metadataToSetObject["Successful"] = ExpressionConverter.ConvertO(__workflow_requestmetadataToSetsuccessful);
                    metadataToSetObjectpropCount++;
                }

                if (__workflow_requestmetadataToSettitle != null)
                {
                    metadataToSetObject["Title"] = ExpressionConverter.ConvertO(__workflow_requestmetadataToSettitle);
                    metadataToSetObjectpropCount++;
                }

                if (metadataToSetObjectpropCount > 0)
                {
                    request["MetadataToSet"] = metadataToSetObject;
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivepdf")]
        public IBodyWorkflowAction<string> EditPdfWatermarkText(Expression<Func<string>> watermarkText, Expression<Func<object>> inputFile, Expression<Func<string>> fontName = null, Expression<Func<double>> fontSize = null, Expression<Func<string>> fontColor = null, Expression<Func<double>> fontTransparency = null)
        {
            var __workflow_watermarkText = WorkflowExpression.Compile(watermarkText, nameof(watermarkText), required: true);
            var __workflow_inputFile = WorkflowExpression.Compile(inputFile, nameof(inputFile), required: true);
            var __workflow_fontName = WorkflowExpression.Compile(fontName, nameof(fontName), required: false);
            var __workflow_fontSize = WorkflowExpression.Compile(fontSize, nameof(fontSize), required: false);
            var __workflow_fontColor = WorkflowExpression.Compile(fontColor, nameof(fontColor), required: false);
            var __workflow_fontTransparency = WorkflowExpression.Compile(fontTransparency, nameof(fontTransparency), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/convert/edit/pdf/watermark/text";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["watermarkText"] = ExpressionConverter.Convert(__workflow_watermarkText);
                if (__workflow_fontName != null)
                    callPayload.Headers["fontName"] = ExpressionConverter.Convert(__workflow_fontName);
                if (__workflow_fontSize != null)
                    callPayload.Headers["fontSize"] = ExpressionConverter.Convert(__workflow_fontSize);
                if (__workflow_fontColor != null)
                    callPayload.Headers["fontColor"] = ExpressionConverter.Convert(__workflow_fontColor);
                if (__workflow_fontTransparency != null)
                    callPayload.Headers["fontTransparency"] = ExpressionConverter.Convert(__workflow_fontTransparency);
                return new ApiConnectionAction<string>(callPayload);
            });
        }
    }

    public class CloudmersivepdfTriggers([ConnectionName] string connectionId)
    {
    }

    public class PdfAnnotation
    {
        public int AnnotationIndex { get; set; }
        public string AnnotationType { get; set; }
        public string CreationDate { get; set; }
        public double Height { get; set; }
        public double LeftX { get; set; }
        public string ModifiedDate { get; set; }
        public int PageNumber { get; set; }
        public string Subject { get; set; }
        public string TextContents { get; set; }
        public string Title { get; set; }
        public double TopY { get; set; }
        public double Width { get; set; }
    }

    public class GetPdfAnnotationsResult
    {
        public PdfAnnotation[] Annotations { get; set; }
        public bool Successful { get; set; }
    }

    public class PdfFormFields
    {
        public PdfFormField[] FormFields { get; set; }
        public bool Successful { get; set; }
    }

    public class PdfFormField
    {
        public int FieldComboBoxSelectedIndex { get; set; }
        public string FieldName { get; set; }
        public string FieldType { get; set; }
        public string FieldValue { get; set; }
    }

    public class SetFormFieldValue
    {
        public bool CheckboxValue { get; set; }
        public int ComboBoxSelectedIndex { get; set; }
        public string FieldName { get; set; }
        public string TextValue { get; set; }
    }

    public class PdfMetadata
    {
        public string Author { get; set; }
        public string Creator { get; set; }
        public string DateCreated { get; set; }
        public string DateModified { get; set; }
        public string Keywords { get; set; }
        public int PageCount { get; set; }
        public string Subject { get; set; }
        public bool Successful { get; set; }
        public string Title { get; set; }
    }

    public class PdfTextByPageResult
    {
        public PdfPageText[] Pages { get; set; }
        public bool Successful { get; set; }
    }

    public class PdfPageText
    {
        public int PageNumber { get; set; }
        public string PageText { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Cloudmersivepdf;

    public partial class WorkflowManagedActions
    {
        public CloudmersivepdfActions Cloudmersivepdf(string connectionId) => new CloudmersivepdfActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CloudmersivepdfTriggers Cloudmersivepdf(string connectionId) => new CloudmersivepdfTriggers(connectionId);
    }
}
