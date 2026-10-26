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
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> EditPdfAddAnnotations(Expression<Func<PdfAnnotation[]>> requestannotationsToAdd = null, Expression<Func<string>> requestinputFileBytes = null)
        {
            var __workflow_requestannotationsToAdd = WorkflowExpression.Compile(requestannotationsToAdd, nameof(requestannotationsToAdd), required: false);
            var __workflow_requestinputFileBytes = WorkflowExpression.Compile(requestinputFileBytes, nameof(requestinputFileBytes), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> EditPdfSetFormFields(Expression<Func<SetFormFieldValue[]>> fieldValuesfieldValues = null, Expression<Func<string>> fieldValuesinputFileBytes = null)
        {
            var __workflow_fieldValuesfieldValues = WorkflowExpression.Compile(fieldValuesfieldValues, nameof(fieldValuesfieldValues), required: false);
            var __workflow_fieldValuesinputFileBytes = WorkflowExpression.Compile(fieldValuesinputFileBytes, nameof(fieldValuesinputFileBytes), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> EditPdfSetMetadata(Expression<Func<string>> requestinputFileBytes = null, Expression<Func<string>> requestmetadataToSetauthor = null, Expression<Func<string>> requestmetadataToSetcreator = null, Expression<Func<string>> requestmetadataToSetdateCreated = null, Expression<Func<string>> requestmetadataToSetdateModified = null, Expression<Func<string>> requestmetadataToSetkeywords = null, Expression<Func<int>> requestmetadataToSetpageCount = null, Expression<Func<string>> requestmetadataToSetsubject = null, Expression<Func<bool>> requestmetadataToSetsuccessful = null, Expression<Func<string>> requestmetadataToSettitle = null)
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
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
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