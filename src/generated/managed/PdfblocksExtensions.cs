//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pdfblocks
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PdfblocksActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfblocks")]
        public IBodyWorkflowAction<string> AddPassword([WorkflowExpression] Func<string> file, [WorkflowExpression] Func<string> password)
        {
            SourceExpression.Validate(file, nameof(file), required: true);
            SourceExpression.Validate(password, nameof(password), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/add_password";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfblocks")]
        public IBodyWorkflowAction<string> AddRestrictions([WorkflowExpression] Func<string> file, [WorkflowExpression] Func<string> ownerPassword, [WorkflowExpression] Func<string> userPassword = null, [WorkflowExpression] Func<bool> allowCopyContent = null, [WorkflowExpression] Func<bool> allowChangeContent = null, [WorkflowExpression] Func<bool> allowPrint = null, [WorkflowExpression] Func<bool> allowPrintHighResolution = null, [WorkflowExpression] Func<bool> allowCommentAndFillForm = null, [WorkflowExpression] Func<bool> allowFillForm = null, [WorkflowExpression] Func<bool> allowAssembleDocument = null, [WorkflowExpression] Func<bool> allowAccessibility = null)
        {
            SourceExpression.Validate(file, nameof(file), required: true);
            SourceExpression.Validate(ownerPassword, nameof(ownerPassword), required: true);
            SourceExpression.Validate(userPassword, nameof(userPassword), required: false);
            SourceExpression.Validate(allowCopyContent, nameof(allowCopyContent), required: false);
            SourceExpression.Validate(allowChangeContent, nameof(allowChangeContent), required: false);
            SourceExpression.Validate(allowPrint, nameof(allowPrint), required: false);
            SourceExpression.Validate(allowPrintHighResolution, nameof(allowPrintHighResolution), required: false);
            SourceExpression.Validate(allowCommentAndFillForm, nameof(allowCommentAndFillForm), required: false);
            SourceExpression.Validate(allowFillForm, nameof(allowFillForm), required: false);
            SourceExpression.Validate(allowAssembleDocument, nameof(allowAssembleDocument), required: false);
            SourceExpression.Validate(allowAccessibility, nameof(allowAccessibility), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/add_restrictions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfblocks")]
        public IBodyWorkflowAction<string> AddWatermark([WorkflowExpression] Func<string> file, [WorkflowExpression] Func<string> line1 = null, [WorkflowExpression] Func<string> line2 = null, [WorkflowExpression] Func<string> line3 = null, [WorkflowExpression] Func<int> template = null, [WorkflowExpression] Func<colorInput> color = null, [WorkflowExpression] Func<int> transparency = null, [WorkflowExpression] Func<double> margin = null)
        {
            SourceExpression.Validate(file, nameof(file), required: true);
            SourceExpression.Validate(line1, nameof(line1), required: false);
            SourceExpression.Validate(line2, nameof(line2), required: false);
            SourceExpression.Validate(line3, nameof(line3), required: false);
            SourceExpression.Validate(template, nameof(template), required: false);
            SourceExpression.Validate(color, nameof(color), required: false);
            SourceExpression.Validate(transparency, nameof(transparency), required: false);
            SourceExpression.Validate(margin, nameof(margin), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/add_watermark";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfblocks")]
        public IBodyWorkflowAction<string> AddImageWatermark([WorkflowExpression] Func<string> file, [WorkflowExpression] Func<string> image, [WorkflowExpression] Func<int> transparency = null, [WorkflowExpression] Func<double> margin = null)
        {
            SourceExpression.Validate(file, nameof(file), required: true);
            SourceExpression.Validate(image, nameof(image), required: true);
            SourceExpression.Validate(transparency, nameof(transparency), required: false);
            SourceExpression.Validate(margin, nameof(margin), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/add_watermark/image";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfblocks")]
        public IBodyWorkflowAction<string> ExtractPages([WorkflowExpression] Func<string> file, [WorkflowExpression] Func<int> firstPage = null, [WorkflowExpression] Func<int> lastPage = null)
        {
            SourceExpression.Validate(file, nameof(file), required: true);
            SourceExpression.Validate(firstPage, nameof(firstPage), required: false);
            SourceExpression.Validate(lastPage, nameof(lastPage), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/extract_pages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfblocks")]
        public IBodyWorkflowAction<string> MergeDocuments([WorkflowExpression] Func<string> file1 = null, [WorkflowExpression] Func<string> file2 = null, [WorkflowExpression] Func<string> file3 = null, [WorkflowExpression] Func<string> file4 = null, [WorkflowExpression] Func<string> file5 = null, [WorkflowExpression] Func<string> file6 = null, [WorkflowExpression] Func<string> file7 = null, [WorkflowExpression] Func<string> file8 = null, [WorkflowExpression] Func<string> file9 = null, [WorkflowExpression] Func<string> file10 = null)
        {
            SourceExpression.Validate(file1, nameof(file1), required: false);
            SourceExpression.Validate(file2, nameof(file2), required: false);
            SourceExpression.Validate(file3, nameof(file3), required: false);
            SourceExpression.Validate(file4, nameof(file4), required: false);
            SourceExpression.Validate(file5, nameof(file5), required: false);
            SourceExpression.Validate(file6, nameof(file6), required: false);
            SourceExpression.Validate(file7, nameof(file7), required: false);
            SourceExpression.Validate(file8, nameof(file8), required: false);
            SourceExpression.Validate(file9, nameof(file9), required: false);
            SourceExpression.Validate(file10, nameof(file10), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/merge_documents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfblocks")]
        public IBodyWorkflowAction<string> RemovePages([WorkflowExpression] Func<string> file, [WorkflowExpression] Func<int> firstPage = null, [WorkflowExpression] Func<int> lastPage = null)
        {
            SourceExpression.Validate(file, nameof(file), required: true);
            SourceExpression.Validate(firstPage, nameof(firstPage), required: false);
            SourceExpression.Validate(lastPage, nameof(lastPage), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/remove_pages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfblocks")]
        public IBodyWorkflowAction<string> RemovePassword([WorkflowExpression] Func<string> file, [WorkflowExpression] Func<string> password)
        {
            SourceExpression.Validate(file, nameof(file), required: true);
            SourceExpression.Validate(password, nameof(password), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/remove_password";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfblocks")]
        public IBodyWorkflowAction<string> RemoveRestrictions([WorkflowExpression] Func<string> file)
        {
            SourceExpression.Validate(file, nameof(file), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/remove_restrictions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfblocks")]
        public IBodyWorkflowAction<string> RemoveSignatures([WorkflowExpression] Func<string> file)
        {
            SourceExpression.Validate(file, nameof(file), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/remove_signatures";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfblocks")]
        public IBodyWorkflowAction<string> ReversePages([WorkflowExpression] Func<string> file)
        {
            SourceExpression.Validate(file, nameof(file), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/reverse_pages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfblocks")]
        public IBodyWorkflowAction<string> RotatePages([WorkflowExpression] Func<string> file, [WorkflowExpression] Func<angleInput> angle, [WorkflowExpression] Func<int> firstPage = null, [WorkflowExpression] Func<int> lastPage = null)
        {
            SourceExpression.Validate(file, nameof(file), required: true);
            SourceExpression.Validate(angle, nameof(angle), required: true);
            SourceExpression.Validate(firstPage, nameof(firstPage), required: false);
            SourceExpression.Validate(lastPage, nameof(lastPage), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/rotate_pages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }
    }

    public class PdfblocksTriggers([ConnectionName] string connectionId)
    {
    }

    public enum colorInput
    {
        Red,
        Blue,
        Gray,
        Black
    }

    public enum angleInput
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "90")]
        _90,
        [EnumMember(Value = "180")]
        _180,
        [EnumMember(Value = "270")]
        _270,
        [EnumMember(Value = "-90")]
        Negative90,
        [EnumMember(Value = "-180")]
        Negative180,
        [EnumMember(Value = "-270")]
        Negative270
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Pdfblocks;

    public partial class WorkflowManagedActions
    {
        public PdfblocksActions Pdfblocks(string connectionId) => new PdfblocksActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PdfblocksTriggers Pdfblocks(string connectionId) => new PdfblocksTriggers(connectionId);
    }
}