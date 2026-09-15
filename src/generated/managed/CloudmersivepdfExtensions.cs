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
        public IBodyWorkflowAction<string> EditPdfAddAnnotations(Expression<Func<PdfAnnotation[]>> requestannotationsToAdd = null, Expression<Func<string>> requestinputFileBytes = null)
        {
            var apiCallPath = "/convert/edit/pdf/annotations/add-item";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            if (requestannotationsToAdd != null)
            {
                request["AnnotationsToAdd"] = CSharpExpressionConverter.ConvertToken(requestannotationsToAdd);
                requestpropCount++;
            }

            if (requestinputFileBytes != null)
            {
                request["InputFileBytes"] = CSharpExpressionConverter.ConvertToken(requestinputFileBytes);
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
            callPayload.Headers["annotationIndex"] = CSharpExpressionConverter.ConvertO(annotationIndex);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivepdf")]
        public IBodyWorkflowAction<string> EditPdfDecrypt(Expression<Func<string>> password, Expression<Func<object>> inputFile)
        {
            var apiCallPath = "/convert/edit/pdf/decrypt";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["password"] = CSharpExpressionConverter.ConvertO(password);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivepdf")]
        public IBodyWorkflowAction<string> EditPdfEncrypt(Expression<Func<object>> inputFile, Expression<Func<string>> userPassword = null, Expression<Func<string>> ownerPassword = null, Expression<Func<string>> encryptionKeyLength = null)
        {
            var apiCallPath = "/convert/edit/pdf/encrypt";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (userPassword != null)
                callPayload.Headers["userPassword"] = CSharpExpressionConverter.ConvertO(userPassword);
            if (ownerPassword != null)
                callPayload.Headers["ownerPassword"] = CSharpExpressionConverter.ConvertO(ownerPassword);
            if (encryptionKeyLength != null)
                callPayload.Headers["encryptionKeyLength"] = CSharpExpressionConverter.ConvertO(encryptionKeyLength);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivepdf")]
        public IBodyWorkflowAction<string> EditPdfSetPermissions(Expression<Func<string>> ownerPassword, Expression<Func<string>> userPassword, Expression<Func<object>> inputFile, Expression<Func<string>> encryptionKeyLength = null, Expression<Func<bool>> allowPrinting = null, Expression<Func<bool>> allowDocumentAssembly = null, Expression<Func<bool>> allowContentExtraction = null, Expression<Func<bool>> allowFormFilling = null, Expression<Func<bool>> allowEditing = null, Expression<Func<bool>> allowAnnotations = null, Expression<Func<bool>> allowDegradedPrinting = null)
        {
            var apiCallPath = "/convert/edit/pdf/encrypt/set-permissions";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["ownerPassword"] = CSharpExpressionConverter.ConvertO(ownerPassword);
            callPayload.Headers["userPassword"] = CSharpExpressionConverter.ConvertO(userPassword);
            if (encryptionKeyLength != null)
                callPayload.Headers["encryptionKeyLength"] = CSharpExpressionConverter.ConvertO(encryptionKeyLength);
            if (allowPrinting != null)
                callPayload.Headers["allowPrinting"] = CSharpExpressionConverter.ConvertO(allowPrinting);
            if (allowDocumentAssembly != null)
                callPayload.Headers["allowDocumentAssembly"] = CSharpExpressionConverter.ConvertO(allowDocumentAssembly);
            if (allowContentExtraction != null)
                callPayload.Headers["allowContentExtraction"] = CSharpExpressionConverter.ConvertO(allowContentExtraction);
            if (allowFormFilling != null)
                callPayload.Headers["allowFormFilling"] = CSharpExpressionConverter.ConvertO(allowFormFilling);
            if (allowEditing != null)
                callPayload.Headers["allowEditing"] = CSharpExpressionConverter.ConvertO(allowEditing);
            if (allowAnnotations != null)
                callPayload.Headers["allowAnnotations"] = CSharpExpressionConverter.ConvertO(allowAnnotations);
            if (allowDegradedPrinting != null)
                callPayload.Headers["allowDegradedPrinting"] = CSharpExpressionConverter.ConvertO(allowDegradedPrinting);
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
        public IBodyWorkflowAction<string> EditPdfSetFormFields(Expression<Func<SetFormFieldValue[]>> fieldValuesfieldValues = null, Expression<Func<string>> fieldValuesinputFileBytes = null)
        {
            var apiCallPath = "/convert/edit/pdf/form/set-fields";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var fieldValues = new JObject();
            var fieldValuespropCount = 0;
            if (fieldValuesfieldValues != null)
            {
                fieldValues["FieldValues"] = CSharpExpressionConverter.ConvertToken(fieldValuesfieldValues);
                fieldValuespropCount++;
            }

            if (fieldValuesinputFileBytes != null)
            {
                fieldValues["InputFileBytes"] = CSharpExpressionConverter.ConvertToken(fieldValuesinputFileBytes);
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
            callPayload.Headers["pageStart"] = CSharpExpressionConverter.ConvertO(pageStart);
            callPayload.Headers["pageEnd"] = CSharpExpressionConverter.ConvertO(pageEnd);
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
            callPayload.Headers["pageStartSource"] = CSharpExpressionConverter.ConvertO(pageStartSource);
            callPayload.Headers["pageEndSource"] = CSharpExpressionConverter.ConvertO(pageEndSource);
            callPayload.Headers["pageInsertBeforeDesitnation"] = CSharpExpressionConverter.ConvertO(pageInsertBeforeDesitnation);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivepdf")]
        public IBodyWorkflowAction<string> EditPdfRotateAllPages(Expression<Func<object>> inputFile, Expression<Func<int>> rotationAngle)
        {
            var apiCallPath = "/convert/edit/pdf/pages/rotate/all";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["rotationAngle"] = CSharpExpressionConverter.ConvertO(rotationAngle);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivepdf")]
        public IBodyWorkflowAction<string> EditPdfRotatePageRange(Expression<Func<object>> inputFile, Expression<Func<int>> rotationAngle, Expression<Func<int>> pageStart, Expression<Func<int>> pageEnd)
        {
            var apiCallPath = "/convert/edit/pdf/pages/rotate/page-range";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["rotationAngle"] = CSharpExpressionConverter.ConvertO(rotationAngle);
            callPayload.Headers["pageStart"] = CSharpExpressionConverter.ConvertO(pageStart);
            callPayload.Headers["pageEnd"] = CSharpExpressionConverter.ConvertO(pageEnd);
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
        public IBodyWorkflowAction<string> EditPdfSetMetadata(Expression<Func<string>> requestinputFileBytes = null, Expression<Func<string>> requestmetadataToSetauthor = null, Expression<Func<string>> requestmetadataToSetcreator = null, Expression<Func<string>> requestmetadataToSetdateCreated = null, Expression<Func<string>> requestmetadataToSetdateModified = null, Expression<Func<string>> requestmetadataToSetkeywords = null, Expression<Func<int>> requestmetadataToSetpageCount = null, Expression<Func<string>> requestmetadataToSetsubject = null, Expression<Func<bool>> requestmetadataToSetsuccessful = null, Expression<Func<string>> requestmetadataToSettitle = null)
        {
            var apiCallPath = "/convert/edit/pdf/set-metadata";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            if (requestinputFileBytes != null)
            {
                request["InputFileBytes"] = CSharpExpressionConverter.ConvertToken(requestinputFileBytes);
                requestpropCount++;
            }

            var metadataToSetObject = new JObject();
            var metadataToSetObjectpropCount = 0;
            if (requestmetadataToSetauthor != null)
            {
                metadataToSetObject["Author"] = CSharpExpressionConverter.ConvertToken(requestmetadataToSetauthor);
                metadataToSetObjectpropCount++;
            }

            if (requestmetadataToSetcreator != null)
            {
                metadataToSetObject["Creator"] = CSharpExpressionConverter.ConvertToken(requestmetadataToSetcreator);
                metadataToSetObjectpropCount++;
            }

            if (requestmetadataToSetdateCreated != null)
            {
                metadataToSetObject["DateCreated"] = CSharpExpressionConverter.ConvertToken(requestmetadataToSetdateCreated);
                metadataToSetObjectpropCount++;
            }

            if (requestmetadataToSetdateModified != null)
            {
                metadataToSetObject["DateModified"] = CSharpExpressionConverter.ConvertToken(requestmetadataToSetdateModified);
                metadataToSetObjectpropCount++;
            }

            if (requestmetadataToSetkeywords != null)
            {
                metadataToSetObject["Keywords"] = CSharpExpressionConverter.ConvertToken(requestmetadataToSetkeywords);
                metadataToSetObjectpropCount++;
            }

            if (requestmetadataToSetpageCount != null)
            {
                metadataToSetObject["PageCount"] = CSharpExpressionConverter.ConvertToken(requestmetadataToSetpageCount);
                metadataToSetObjectpropCount++;
            }

            if (requestmetadataToSetsubject != null)
            {
                metadataToSetObject["Subject"] = CSharpExpressionConverter.ConvertToken(requestmetadataToSetsubject);
                metadataToSetObjectpropCount++;
            }

            if (requestmetadataToSetsuccessful != null)
            {
                metadataToSetObject["Successful"] = CSharpExpressionConverter.ConvertToken(requestmetadataToSetsuccessful);
                metadataToSetObjectpropCount++;
            }

            if (requestmetadataToSettitle != null)
            {
                metadataToSetObject["Title"] = CSharpExpressionConverter.ConvertToken(requestmetadataToSettitle);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivepdf")]
        public IBodyWorkflowAction<string> EditPdfWatermarkText(Expression<Func<string>> watermarkText, Expression<Func<object>> inputFile, Expression<Func<string>> fontName = null, Expression<Func<double>> fontSize = null, Expression<Func<string>> fontColor = null, Expression<Func<double>> fontTransparency = null)
        {
            var apiCallPath = "/convert/edit/pdf/watermark/text";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["watermarkText"] = CSharpExpressionConverter.ConvertO(watermarkText);
            if (fontName != null)
                callPayload.Headers["fontName"] = CSharpExpressionConverter.ConvertO(fontName);
            if (fontSize != null)
                callPayload.Headers["fontSize"] = CSharpExpressionConverter.ConvertO(fontSize);
            if (fontColor != null)
                callPayload.Headers["fontColor"] = CSharpExpressionConverter.ConvertO(fontColor);
            if (fontTransparency != null)
                callPayload.Headers["fontTransparency"] = CSharpExpressionConverter.ConvertO(fontTransparency);
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