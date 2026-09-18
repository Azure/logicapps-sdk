//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cloudmersivepdf
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CloudmersivepdfActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivepdf")]
        public IBodyWorkflowAction<string> EditPdfAddAnnotations([WorkflowExpression] Func<PdfAnnotation[]> requestannotationsToAdd = null, [WorkflowExpression] Func<string> requestinputFileBytes = null)
        {
            SourceExpression.Validate(requestannotationsToAdd, nameof(requestannotationsToAdd), required: false);
            SourceExpression.Validate(requestinputFileBytes, nameof(requestinputFileBytes), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/edit/pdf/annotations/add-item";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (requestannotationsToAdd != null)
                {
                    request["AnnotationsToAdd"] = SourceExpressionConverter.ConvertToken(requestannotationsToAdd);
                    requestpropCount++;
                }

                if (requestinputFileBytes != null)
                {
                    request["InputFileBytes"] = SourceExpressionConverter.ConvertToken(requestinputFileBytes);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivepdf")]
        public IBodyWorkflowAction<GetPdfAnnotationsResult> EditPdfGetAnnotations([WorkflowExpression] Func<object> inputFile)
        {
            SourceExpression.Validate(inputFile, nameof(inputFile), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/edit/pdf/annotations/list";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetPdfAnnotationsResult>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivepdf")]
        public IBodyWorkflowAction<string> EditPdfRemoveAllAnnotations([WorkflowExpression] Func<object> inputFile)
        {
            SourceExpression.Validate(inputFile, nameof(inputFile), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/edit/pdf/annotations/remove-all";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivepdf")]
        public IBodyWorkflowAction<string> EditPdfRemoveAnnotationItem([WorkflowExpression] Func<object> inputFile, [WorkflowExpression] Func<int> annotationIndex)
        {
            SourceExpression.Validate(inputFile, nameof(inputFile), required: true);
            SourceExpression.Validate(annotationIndex, nameof(annotationIndex), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/edit/pdf/annotations/remove-item";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["annotationIndex"] = SourceExpressionConverter.ConvertO(annotationIndex);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivepdf")]
        public IBodyWorkflowAction<string> EditPdfDecrypt([WorkflowExpression] Func<string> password, [WorkflowExpression] Func<object> inputFile)
        {
            SourceExpression.Validate(password, nameof(password), required: true);
            SourceExpression.Validate(inputFile, nameof(inputFile), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/edit/pdf/decrypt";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["password"] = SourceExpressionConverter.ConvertO(password);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivepdf")]
        public IBodyWorkflowAction<string> EditPdfEncrypt([WorkflowExpression] Func<object> inputFile, [WorkflowExpression] Func<string> userPassword = null, [WorkflowExpression] Func<string> ownerPassword = null, [WorkflowExpression] Func<string> encryptionKeyLength = null)
        {
            SourceExpression.Validate(inputFile, nameof(inputFile), required: true);
            SourceExpression.Validate(userPassword, nameof(userPassword), required: false);
            SourceExpression.Validate(ownerPassword, nameof(ownerPassword), required: false);
            SourceExpression.Validate(encryptionKeyLength, nameof(encryptionKeyLength), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/edit/pdf/encrypt";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (userPassword != null)
                    callPayload.Headers["userPassword"] = SourceExpressionConverter.ConvertO(userPassword);
                if (ownerPassword != null)
                    callPayload.Headers["ownerPassword"] = SourceExpressionConverter.ConvertO(ownerPassword);
                if (encryptionKeyLength != null)
                    callPayload.Headers["encryptionKeyLength"] = SourceExpressionConverter.ConvertO(encryptionKeyLength);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivepdf")]
        public IBodyWorkflowAction<string> EditPdfSetPermissions([WorkflowExpression] Func<string> ownerPassword, [WorkflowExpression] Func<string> userPassword, [WorkflowExpression] Func<object> inputFile, [WorkflowExpression] Func<string> encryptionKeyLength = null, [WorkflowExpression] Func<bool> allowPrinting = null, [WorkflowExpression] Func<bool> allowDocumentAssembly = null, [WorkflowExpression] Func<bool> allowContentExtraction = null, [WorkflowExpression] Func<bool> allowFormFilling = null, [WorkflowExpression] Func<bool> allowEditing = null, [WorkflowExpression] Func<bool> allowAnnotations = null, [WorkflowExpression] Func<bool> allowDegradedPrinting = null)
        {
            SourceExpression.Validate(ownerPassword, nameof(ownerPassword), required: true);
            SourceExpression.Validate(userPassword, nameof(userPassword), required: true);
            SourceExpression.Validate(inputFile, nameof(inputFile), required: true);
            SourceExpression.Validate(encryptionKeyLength, nameof(encryptionKeyLength), required: false);
            SourceExpression.Validate(allowPrinting, nameof(allowPrinting), required: false);
            SourceExpression.Validate(allowDocumentAssembly, nameof(allowDocumentAssembly), required: false);
            SourceExpression.Validate(allowContentExtraction, nameof(allowContentExtraction), required: false);
            SourceExpression.Validate(allowFormFilling, nameof(allowFormFilling), required: false);
            SourceExpression.Validate(allowEditing, nameof(allowEditing), required: false);
            SourceExpression.Validate(allowAnnotations, nameof(allowAnnotations), required: false);
            SourceExpression.Validate(allowDegradedPrinting, nameof(allowDegradedPrinting), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/edit/pdf/encrypt/set-permissions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["ownerPassword"] = SourceExpressionConverter.ConvertO(ownerPassword);
                callPayload.Headers["userPassword"] = SourceExpressionConverter.ConvertO(userPassword);
                if (encryptionKeyLength != null)
                    callPayload.Headers["encryptionKeyLength"] = SourceExpressionConverter.ConvertO(encryptionKeyLength);
                if (allowPrinting != null)
                    callPayload.Headers["allowPrinting"] = SourceExpressionConverter.ConvertO(allowPrinting);
                if (allowDocumentAssembly != null)
                    callPayload.Headers["allowDocumentAssembly"] = SourceExpressionConverter.ConvertO(allowDocumentAssembly);
                if (allowContentExtraction != null)
                    callPayload.Headers["allowContentExtraction"] = SourceExpressionConverter.ConvertO(allowContentExtraction);
                if (allowFormFilling != null)
                    callPayload.Headers["allowFormFilling"] = SourceExpressionConverter.ConvertO(allowFormFilling);
                if (allowEditing != null)
                    callPayload.Headers["allowEditing"] = SourceExpressionConverter.ConvertO(allowEditing);
                if (allowAnnotations != null)
                    callPayload.Headers["allowAnnotations"] = SourceExpressionConverter.ConvertO(allowAnnotations);
                if (allowDegradedPrinting != null)
                    callPayload.Headers["allowDegradedPrinting"] = SourceExpressionConverter.ConvertO(allowDegradedPrinting);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivepdf")]
        public IBodyWorkflowAction<PdfFormFields> EditPdfGetFormFields([WorkflowExpression] Func<object> inputFile)
        {
            SourceExpression.Validate(inputFile, nameof(inputFile), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/edit/pdf/form/get-fields";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<PdfFormFields>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivepdf")]
        public IBodyWorkflowAction<string> EditPdfSetFormFields([WorkflowExpression] Func<SetFormFieldValue[]> fieldValuesfieldValues = null, [WorkflowExpression] Func<string> fieldValuesinputFileBytes = null)
        {
            SourceExpression.Validate(fieldValuesfieldValues, nameof(fieldValuesfieldValues), required: false);
            SourceExpression.Validate(fieldValuesinputFileBytes, nameof(fieldValuesinputFileBytes), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/edit/pdf/form/set-fields";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var fieldValues = new JObject();
                var fieldValuespropCount = 0;
                if (fieldValuesfieldValues != null)
                {
                    fieldValues["FieldValues"] = SourceExpressionConverter.ConvertToken(fieldValuesfieldValues);
                    fieldValuespropCount++;
                }

                if (fieldValuesinputFileBytes != null)
                {
                    fieldValues["InputFileBytes"] = SourceExpressionConverter.ConvertToken(fieldValuesinputFileBytes);
                    fieldValuespropCount++;
                }

                if (fieldValuespropCount > 0)
                {
                    callPayload.Body = fieldValues;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivepdf")]
        public IBodyWorkflowAction<PdfMetadata> EditPdfGetMetadata([WorkflowExpression] Func<object> inputFile)
        {
            SourceExpression.Validate(inputFile, nameof(inputFile), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/edit/pdf/get-metadata";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<PdfMetadata>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivepdf")]
        public IBodyWorkflowAction<string> EditPdfDeletePages([WorkflowExpression] Func<object> inputFile, [WorkflowExpression] Func<int> pageStart, [WorkflowExpression] Func<int> pageEnd)
        {
            SourceExpression.Validate(inputFile, nameof(inputFile), required: true);
            SourceExpression.Validate(pageStart, nameof(pageStart), required: true);
            SourceExpression.Validate(pageEnd, nameof(pageEnd), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/edit/pdf/pages/delete";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["pageStart"] = SourceExpressionConverter.ConvertO(pageStart);
                callPayload.Headers["pageEnd"] = SourceExpressionConverter.ConvertO(pageEnd);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivepdf")]
        public IBodyWorkflowAction<PdfTextByPageResult> EditPdfGetPdfTextByPages([WorkflowExpression] Func<object> inputFile)
        {
            SourceExpression.Validate(inputFile, nameof(inputFile), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/edit/pdf/pages/get-text";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<PdfTextByPageResult>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivepdf")]
        public IBodyWorkflowAction<string> EditPdfInsertPages([WorkflowExpression] Func<object> sourceFile, [WorkflowExpression] Func<object> destinationFile, [WorkflowExpression] Func<int> pageStartSource, [WorkflowExpression] Func<int> pageEndSource, [WorkflowExpression] Func<int> pageInsertBeforeDesitnation)
        {
            SourceExpression.Validate(sourceFile, nameof(sourceFile), required: true);
            SourceExpression.Validate(destinationFile, nameof(destinationFile), required: true);
            SourceExpression.Validate(pageStartSource, nameof(pageStartSource), required: true);
            SourceExpression.Validate(pageEndSource, nameof(pageEndSource), required: true);
            SourceExpression.Validate(pageInsertBeforeDesitnation, nameof(pageInsertBeforeDesitnation), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/edit/pdf/pages/insert";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["pageStartSource"] = SourceExpressionConverter.ConvertO(pageStartSource);
                callPayload.Headers["pageEndSource"] = SourceExpressionConverter.ConvertO(pageEndSource);
                callPayload.Headers["pageInsertBeforeDesitnation"] = SourceExpressionConverter.ConvertO(pageInsertBeforeDesitnation);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivepdf")]
        public IBodyWorkflowAction<string> EditPdfRotateAllPages([WorkflowExpression] Func<object> inputFile, [WorkflowExpression] Func<int> rotationAngle)
        {
            SourceExpression.Validate(inputFile, nameof(inputFile), required: true);
            SourceExpression.Validate(rotationAngle, nameof(rotationAngle), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/edit/pdf/pages/rotate/all";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["rotationAngle"] = SourceExpressionConverter.ConvertO(rotationAngle);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivepdf")]
        public IBodyWorkflowAction<string> EditPdfRotatePageRange([WorkflowExpression] Func<object> inputFile, [WorkflowExpression] Func<int> rotationAngle, [WorkflowExpression] Func<int> pageStart, [WorkflowExpression] Func<int> pageEnd)
        {
            SourceExpression.Validate(inputFile, nameof(inputFile), required: true);
            SourceExpression.Validate(rotationAngle, nameof(rotationAngle), required: true);
            SourceExpression.Validate(pageStart, nameof(pageStart), required: true);
            SourceExpression.Validate(pageEnd, nameof(pageEnd), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/edit/pdf/pages/rotate/page-range";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["rotationAngle"] = SourceExpressionConverter.ConvertO(rotationAngle);
                callPayload.Headers["pageStart"] = SourceExpressionConverter.ConvertO(pageStart);
                callPayload.Headers["pageEnd"] = SourceExpressionConverter.ConvertO(pageEnd);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivepdf")]
        public IBodyWorkflowAction<string> EditPdfRasterize([WorkflowExpression] Func<object> inputFile)
        {
            SourceExpression.Validate(inputFile, nameof(inputFile), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/edit/pdf/rasterize";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivepdf")]
        public IBodyWorkflowAction<string> EditPdfSetMetadata([WorkflowExpression] Func<string> requestinputFileBytes = null, [WorkflowExpression] Func<string> requestmetadataToSetauthor = null, [WorkflowExpression] Func<string> requestmetadataToSetcreator = null, [WorkflowExpression] Func<string> requestmetadataToSetdateCreated = null, [WorkflowExpression] Func<string> requestmetadataToSetdateModified = null, [WorkflowExpression] Func<string> requestmetadataToSetkeywords = null, [WorkflowExpression] Func<int> requestmetadataToSetpageCount = null, [WorkflowExpression] Func<string> requestmetadataToSetsubject = null, [WorkflowExpression] Func<bool> requestmetadataToSetsuccessful = null, [WorkflowExpression] Func<string> requestmetadataToSettitle = null)
        {
            SourceExpression.Validate(requestinputFileBytes, nameof(requestinputFileBytes), required: false);
            SourceExpression.Validate(requestmetadataToSetauthor, nameof(requestmetadataToSetauthor), required: false);
            SourceExpression.Validate(requestmetadataToSetcreator, nameof(requestmetadataToSetcreator), required: false);
            SourceExpression.Validate(requestmetadataToSetdateCreated, nameof(requestmetadataToSetdateCreated), required: false);
            SourceExpression.Validate(requestmetadataToSetdateModified, nameof(requestmetadataToSetdateModified), required: false);
            SourceExpression.Validate(requestmetadataToSetkeywords, nameof(requestmetadataToSetkeywords), required: false);
            SourceExpression.Validate(requestmetadataToSetpageCount, nameof(requestmetadataToSetpageCount), required: false);
            SourceExpression.Validate(requestmetadataToSetsubject, nameof(requestmetadataToSetsubject), required: false);
            SourceExpression.Validate(requestmetadataToSetsuccessful, nameof(requestmetadataToSetsuccessful), required: false);
            SourceExpression.Validate(requestmetadataToSettitle, nameof(requestmetadataToSettitle), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/edit/pdf/set-metadata";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (requestinputFileBytes != null)
                {
                    request["InputFileBytes"] = SourceExpressionConverter.ConvertToken(requestinputFileBytes);
                    requestpropCount++;
                }

                var metadataToSetObject = new JObject();
                var metadataToSetObjectpropCount = 0;
                if (requestmetadataToSetauthor != null)
                {
                    metadataToSetObject["Author"] = SourceExpressionConverter.ConvertToken(requestmetadataToSetauthor);
                    metadataToSetObjectpropCount++;
                }

                if (requestmetadataToSetcreator != null)
                {
                    metadataToSetObject["Creator"] = SourceExpressionConverter.ConvertToken(requestmetadataToSetcreator);
                    metadataToSetObjectpropCount++;
                }

                if (requestmetadataToSetdateCreated != null)
                {
                    metadataToSetObject["DateCreated"] = SourceExpressionConverter.ConvertToken(requestmetadataToSetdateCreated);
                    metadataToSetObjectpropCount++;
                }

                if (requestmetadataToSetdateModified != null)
                {
                    metadataToSetObject["DateModified"] = SourceExpressionConverter.ConvertToken(requestmetadataToSetdateModified);
                    metadataToSetObjectpropCount++;
                }

                if (requestmetadataToSetkeywords != null)
                {
                    metadataToSetObject["Keywords"] = SourceExpressionConverter.ConvertToken(requestmetadataToSetkeywords);
                    metadataToSetObjectpropCount++;
                }

                if (requestmetadataToSetpageCount != null)
                {
                    metadataToSetObject["PageCount"] = SourceExpressionConverter.ConvertToken(requestmetadataToSetpageCount);
                    metadataToSetObjectpropCount++;
                }

                if (requestmetadataToSetsubject != null)
                {
                    metadataToSetObject["Subject"] = SourceExpressionConverter.ConvertToken(requestmetadataToSetsubject);
                    metadataToSetObjectpropCount++;
                }

                if (requestmetadataToSetsuccessful != null)
                {
                    metadataToSetObject["Successful"] = SourceExpressionConverter.ConvertToken(requestmetadataToSetsuccessful);
                    metadataToSetObjectpropCount++;
                }

                if (requestmetadataToSettitle != null)
                {
                    metadataToSetObject["Title"] = SourceExpressionConverter.ConvertToken(requestmetadataToSettitle);
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
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivepdf")]
        public IBodyWorkflowAction<string> EditPdfWatermarkText([WorkflowExpression] Func<string> watermarkText, [WorkflowExpression] Func<object> inputFile, [WorkflowExpression] Func<string> fontName = null, [WorkflowExpression] Func<double> fontSize = null, [WorkflowExpression] Func<string> fontColor = null, [WorkflowExpression] Func<double> fontTransparency = null)
        {
            SourceExpression.Validate(watermarkText, nameof(watermarkText), required: true);
            SourceExpression.Validate(inputFile, nameof(inputFile), required: true);
            SourceExpression.Validate(fontName, nameof(fontName), required: false);
            SourceExpression.Validate(fontSize, nameof(fontSize), required: false);
            SourceExpression.Validate(fontColor, nameof(fontColor), required: false);
            SourceExpression.Validate(fontTransparency, nameof(fontTransparency), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/edit/pdf/watermark/text";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["watermarkText"] = SourceExpressionConverter.ConvertO(watermarkText);
                if (fontName != null)
                    callPayload.Headers["fontName"] = SourceExpressionConverter.ConvertO(fontName);
                if (fontSize != null)
                    callPayload.Headers["fontSize"] = SourceExpressionConverter.ConvertO(fontSize);
                if (fontColor != null)
                    callPayload.Headers["fontColor"] = SourceExpressionConverter.ConvertO(fontColor);
                if (fontTransparency != null)
                    callPayload.Headers["fontTransparency"] = SourceExpressionConverter.ConvertO(fontTransparency);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
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