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

    public class SetFormFieldValue
    {
        public bool CheckboxValue { get; set; }
        public int ComboBoxSelectedIndex { get; set; }
        public string FieldName { get; set; }
        public string TextValue { get; set; }
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