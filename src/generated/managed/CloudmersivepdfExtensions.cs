//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Cloudmersivepdf
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CloudmersivepdfActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivepdf")]
        public IBodyWorkflowAction<string> EditPdfAddAnnotations(Expression<Func<PdfAnnotation[]>> requestAnnotationsToAdd = null, Expression<Func<string>> requestInputFileBytes = null)
        {
            var apiCallPath = "/convert/edit/pdf/annotations/add-item";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            if (requestAnnotationsToAdd != null)
            {
                request["AnnotationsToAdd"] = ExpressionConverter.ConvertO(requestAnnotationsToAdd);
                requestpropCount++;
            }

            if (requestInputFileBytes != null)
            {
                request["InputFileBytes"] = ExpressionConverter.ConvertO(requestInputFileBytes);
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivepdf")]
        public IBodyWorkflowAction<GetPdfAnnotationsResult> EditPdfGetAnnotations(Expression<Func<object>> inputFile)
        {
            var apiCallPath = "/convert/edit/pdf/annotations/list";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetPdfAnnotationsResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivepdf")]
        public IBodyWorkflowAction<string> EditPdfRemoveAllAnnotations(Expression<Func<object>> inputFile)
        {
            var apiCallPath = "/convert/edit/pdf/annotations/remove-all";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivepdf")]
        public IBodyWorkflowAction<string> EditPdfRemoveAnnotationItem(Expression<Func<object>> inputFile, Expression<Func<int>> annotationIndex)
        {
            var apiCallPath = "/convert/edit/pdf/annotations/remove-item";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["annotationIndex"] = ExpressionConverter.Convert(annotationIndex);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivepdf")]
        public IBodyWorkflowAction<string> EditPdfDecrypt(Expression<Func<string>> password, Expression<Func<object>> inputFile)
        {
            var apiCallPath = "/convert/edit/pdf/decrypt";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["password"] = ExpressionConverter.Convert(password);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivepdf")]
        public IBodyWorkflowAction<string> EditPdfEncrypt(Expression<Func<object>> inputFile, Expression<Func<string>> userPassword = null, Expression<Func<string>> ownerPassword = null, Expression<Func<string>> encryptionKeyLength = null)
        {
            var apiCallPath = "/convert/edit/pdf/encrypt";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (userPassword != null)
                callPayload.Headers["userPassword"] = ExpressionConverter.Convert(userPassword);
            if (ownerPassword != null)
                callPayload.Headers["ownerPassword"] = ExpressionConverter.Convert(ownerPassword);
            if (encryptionKeyLength != null)
                callPayload.Headers["encryptionKeyLength"] = ExpressionConverter.Convert(encryptionKeyLength);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivepdf")]
        public IBodyWorkflowAction<string> EditPdfSetPermissions(Expression<Func<string>> ownerPassword, Expression<Func<string>> userPassword, Expression<Func<object>> inputFile, Expression<Func<string>> encryptionKeyLength = null, Expression<Func<bool>> allowPrinting = null, Expression<Func<bool>> allowDocumentAssembly = null, Expression<Func<bool>> allowContentExtraction = null, Expression<Func<bool>> allowFormFilling = null, Expression<Func<bool>> allowEditing = null, Expression<Func<bool>> allowAnnotations = null, Expression<Func<bool>> allowDegradedPrinting = null)
        {
            var apiCallPath = "/convert/edit/pdf/encrypt/set-permissions";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["ownerPassword"] = ExpressionConverter.Convert(ownerPassword);
            callPayload.Headers["userPassword"] = ExpressionConverter.Convert(userPassword);
            if (encryptionKeyLength != null)
                callPayload.Headers["encryptionKeyLength"] = ExpressionConverter.Convert(encryptionKeyLength);
            if (allowPrinting != null)
                callPayload.Headers["allowPrinting"] = ExpressionConverter.Convert(allowPrinting);
            if (allowDocumentAssembly != null)
                callPayload.Headers["allowDocumentAssembly"] = ExpressionConverter.Convert(allowDocumentAssembly);
            if (allowContentExtraction != null)
                callPayload.Headers["allowContentExtraction"] = ExpressionConverter.Convert(allowContentExtraction);
            if (allowFormFilling != null)
                callPayload.Headers["allowFormFilling"] = ExpressionConverter.Convert(allowFormFilling);
            if (allowEditing != null)
                callPayload.Headers["allowEditing"] = ExpressionConverter.Convert(allowEditing);
            if (allowAnnotations != null)
                callPayload.Headers["allowAnnotations"] = ExpressionConverter.Convert(allowAnnotations);
            if (allowDegradedPrinting != null)
                callPayload.Headers["allowDegradedPrinting"] = ExpressionConverter.Convert(allowDegradedPrinting);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivepdf")]
        public IBodyWorkflowAction<PdfFormFields> EditPdfGetFormFields(Expression<Func<object>> inputFile)
        {
            var apiCallPath = "/convert/edit/pdf/form/get-fields";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<PdfFormFields>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivepdf")]
        public IBodyWorkflowAction<string> EditPdfSetFormFields(Expression<Func<SetFormFieldValue[]>> fieldValuesFieldValues = null, Expression<Func<string>> fieldValuesInputFileBytes = null)
        {
            var apiCallPath = "/convert/edit/pdf/form/set-fields";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var fieldValues = new JObject();
            var fieldValuespropCount = 0;
            if (fieldValuesFieldValues != null)
            {
                fieldValues["FieldValues"] = ExpressionConverter.ConvertO(fieldValuesFieldValues);
                fieldValuespropCount++;
            }

            if (fieldValuesInputFileBytes != null)
            {
                fieldValues["InputFileBytes"] = ExpressionConverter.ConvertO(fieldValuesInputFileBytes);
                fieldValuespropCount++;
            }

            if (fieldValuespropCount > 0)
            {
                callPayload.Body = fieldValues;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivepdf")]
        public IBodyWorkflowAction<PdfMetadata> EditPdfGetMetadata(Expression<Func<object>> inputFile)
        {
            var apiCallPath = "/convert/edit/pdf/get-metadata";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<PdfMetadata>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivepdf")]
        public IBodyWorkflowAction<string> EditPdfDeletePages(Expression<Func<object>> inputFile, Expression<Func<int>> pageStart, Expression<Func<int>> pageEnd)
        {
            var apiCallPath = "/convert/edit/pdf/pages/delete";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["pageStart"] = ExpressionConverter.Convert(pageStart);
            callPayload.Headers["pageEnd"] = ExpressionConverter.Convert(pageEnd);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivepdf")]
        public IBodyWorkflowAction<PdfTextByPageResult> EditPdfGetPdfTextByPages(Expression<Func<object>> inputFile)
        {
            var apiCallPath = "/convert/edit/pdf/pages/get-text";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<PdfTextByPageResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivepdf")]
        public IBodyWorkflowAction<string> EditPdfInsertPages(Expression<Func<object>> sourceFile, Expression<Func<object>> destinationFile, Expression<Func<int>> pageStartSource, Expression<Func<int>> pageEndSource, Expression<Func<int>> pageInsertBeforeDesitnation)
        {
            var apiCallPath = "/convert/edit/pdf/pages/insert";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["pageStartSource"] = ExpressionConverter.Convert(pageStartSource);
            callPayload.Headers["pageEndSource"] = ExpressionConverter.Convert(pageEndSource);
            callPayload.Headers["pageInsertBeforeDesitnation"] = ExpressionConverter.Convert(pageInsertBeforeDesitnation);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivepdf")]
        public IBodyWorkflowAction<string> EditPdfRotateAllPages(Expression<Func<object>> inputFile, Expression<Func<int>> rotationAngle)
        {
            var apiCallPath = "/convert/edit/pdf/pages/rotate/all";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["rotationAngle"] = ExpressionConverter.Convert(rotationAngle);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivepdf")]
        public IBodyWorkflowAction<string> EditPdfRotatePageRange(Expression<Func<object>> inputFile, Expression<Func<int>> rotationAngle, Expression<Func<int>> pageStart, Expression<Func<int>> pageEnd)
        {
            var apiCallPath = "/convert/edit/pdf/pages/rotate/page-range";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["rotationAngle"] = ExpressionConverter.Convert(rotationAngle);
            callPayload.Headers["pageStart"] = ExpressionConverter.Convert(pageStart);
            callPayload.Headers["pageEnd"] = ExpressionConverter.Convert(pageEnd);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivepdf")]
        public IBodyWorkflowAction<string> EditPdfRasterize(Expression<Func<object>> inputFile)
        {
            var apiCallPath = "/convert/edit/pdf/rasterize";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivepdf")]
        public IBodyWorkflowAction<string> EditPdfSetMetadata(Expression<Func<string>> requestInputFileBytes = null, Expression<Func<string>> requestMetadataToSetAuthor = null, Expression<Func<string>> requestMetadataToSetCreator = null, Expression<Func<string>> requestMetadataToSetDateCreated = null, Expression<Func<string>> requestMetadataToSetDateModified = null, Expression<Func<string>> requestMetadataToSetKeywords = null, Expression<Func<int>> requestMetadataToSetPageCount = null, Expression<Func<string>> requestMetadataToSetSubject = null, Expression<Func<bool>> requestMetadataToSetSuccessful = null, Expression<Func<string>> requestMetadataToSetTitle = null)
        {
            var apiCallPath = "/convert/edit/pdf/set-metadata";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            if (requestInputFileBytes != null)
            {
                request["InputFileBytes"] = ExpressionConverter.ConvertO(requestInputFileBytes);
                requestpropCount++;
            }

            var MetadataToSetObject = new JObject();
            var MetadataToSetObjectpropCount = 0;
            if (requestMetadataToSetAuthor != null)
            {
                MetadataToSetObject["Author"] = ExpressionConverter.ConvertO(requestMetadataToSetAuthor);
                MetadataToSetObjectpropCount++;
            }

            if (requestMetadataToSetCreator != null)
            {
                MetadataToSetObject["Creator"] = ExpressionConverter.ConvertO(requestMetadataToSetCreator);
                MetadataToSetObjectpropCount++;
            }

            if (requestMetadataToSetDateCreated != null)
            {
                MetadataToSetObject["DateCreated"] = ExpressionConverter.ConvertO(requestMetadataToSetDateCreated);
                MetadataToSetObjectpropCount++;
            }

            if (requestMetadataToSetDateModified != null)
            {
                MetadataToSetObject["DateModified"] = ExpressionConverter.ConvertO(requestMetadataToSetDateModified);
                MetadataToSetObjectpropCount++;
            }

            if (requestMetadataToSetKeywords != null)
            {
                MetadataToSetObject["Keywords"] = ExpressionConverter.ConvertO(requestMetadataToSetKeywords);
                MetadataToSetObjectpropCount++;
            }

            if (requestMetadataToSetPageCount != null)
            {
                MetadataToSetObject["PageCount"] = ExpressionConverter.ConvertO(requestMetadataToSetPageCount);
                MetadataToSetObjectpropCount++;
            }

            if (requestMetadataToSetSubject != null)
            {
                MetadataToSetObject["Subject"] = ExpressionConverter.ConvertO(requestMetadataToSetSubject);
                MetadataToSetObjectpropCount++;
            }

            if (requestMetadataToSetSuccessful != null)
            {
                MetadataToSetObject["Successful"] = ExpressionConverter.ConvertO(requestMetadataToSetSuccessful);
                MetadataToSetObjectpropCount++;
            }

            if (requestMetadataToSetTitle != null)
            {
                MetadataToSetObject["Title"] = ExpressionConverter.ConvertO(requestMetadataToSetTitle);
                MetadataToSetObjectpropCount++;
            }

            if (MetadataToSetObjectpropCount > 0)
            {
                request["MetadataToSet"] = MetadataToSetObject;
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivepdf")]
        public IBodyWorkflowAction<string> EditPdfWatermarkText(Expression<Func<string>> watermarkText, Expression<Func<object>> inputFile, Expression<Func<string>> fontName = null, Expression<Func<double>> fontSize = null, Expression<Func<string>> fontColor = null, Expression<Func<double>> fontTransparency = null)
        {
            var apiCallPath = "/convert/edit/pdf/watermark/text";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["watermarkText"] = ExpressionConverter.Convert(watermarkText);
            if (fontName != null)
                callPayload.Headers["fontName"] = ExpressionConverter.Convert(fontName);
            if (fontSize != null)
                callPayload.Headers["fontSize"] = ExpressionConverter.Convert(fontSize);
            if (fontColor != null)
                callPayload.Headers["fontColor"] = ExpressionConverter.Convert(fontColor);
            if (fontTransparency != null)
                callPayload.Headers["fontTransparency"] = ExpressionConverter.Convert(fontTransparency);
            return new ApiConnectionAction<string>(callPayload);
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
    using Microsoft.Azure.Workflows.Sdk.Cloudmersivepdf;

    public partial class WorkflowManagedActions
    {
        public CloudmersivepdfActions Cloudmersivepdf(string connectionId) => new CloudmersivepdfActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CloudmersivepdfTriggers Cloudmersivepdf(string connectionId) => new CloudmersivepdfTriggers(connectionId);
    }
}