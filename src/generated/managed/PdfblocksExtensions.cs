//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pdfblocks
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PdfblocksActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfblocks")]
        [WorkflowExpressionFactory(nameof(__BuildAddPassword))]
        public IBodyWorkflowAction<string> AddPassword([WorkflowExpression] Func<string> file, [WorkflowExpression] Func<string> password)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfblocks")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildAddPassword(WorkflowExpression<string> file, WorkflowExpression<string> password)
        {
            WorkflowExpression.Validate(file, nameof(file), required: true);
            WorkflowExpression.Validate(password, nameof(password), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/add_password";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfblocks")]
        [WorkflowExpressionFactory(nameof(__BuildAddRestrictions))]
        public IBodyWorkflowAction<string> AddRestrictions([WorkflowExpression] Func<string> file, [WorkflowExpression] Func<string> ownerPassword, [WorkflowExpression] Func<string> userPassword = null, [WorkflowExpression] Func<bool> allowCopyContent = null, [WorkflowExpression] Func<bool> allowChangeContent = null, [WorkflowExpression] Func<bool> allowPrint = null, [WorkflowExpression] Func<bool> allowPrintHighResolution = null, [WorkflowExpression] Func<bool> allowCommentAndFillForm = null, [WorkflowExpression] Func<bool> allowFillForm = null, [WorkflowExpression] Func<bool> allowAssembleDocument = null, [WorkflowExpression] Func<bool> allowAccessibility = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfblocks")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildAddRestrictions(WorkflowExpression<string> file, WorkflowExpression<string> ownerPassword, WorkflowExpression<string> userPassword = null, WorkflowExpression<bool> allowCopyContent = null, WorkflowExpression<bool> allowChangeContent = null, WorkflowExpression<bool> allowPrint = null, WorkflowExpression<bool> allowPrintHighResolution = null, WorkflowExpression<bool> allowCommentAndFillForm = null, WorkflowExpression<bool> allowFillForm = null, WorkflowExpression<bool> allowAssembleDocument = null, WorkflowExpression<bool> allowAccessibility = null)
        {
            WorkflowExpression.Validate(file, nameof(file), required: true);
            WorkflowExpression.Validate(ownerPassword, nameof(ownerPassword), required: true);
            WorkflowExpression.Validate(userPassword, nameof(userPassword), required: false);
            WorkflowExpression.Validate(allowCopyContent, nameof(allowCopyContent), required: false);
            WorkflowExpression.Validate(allowChangeContent, nameof(allowChangeContent), required: false);
            WorkflowExpression.Validate(allowPrint, nameof(allowPrint), required: false);
            WorkflowExpression.Validate(allowPrintHighResolution, nameof(allowPrintHighResolution), required: false);
            WorkflowExpression.Validate(allowCommentAndFillForm, nameof(allowCommentAndFillForm), required: false);
            WorkflowExpression.Validate(allowFillForm, nameof(allowFillForm), required: false);
            WorkflowExpression.Validate(allowAssembleDocument, nameof(allowAssembleDocument), required: false);
            WorkflowExpression.Validate(allowAccessibility, nameof(allowAccessibility), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/add_restrictions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfblocks")]
        [WorkflowExpressionFactory(nameof(__BuildAddWatermark))]
        public IBodyWorkflowAction<string> AddWatermark([WorkflowExpression] Func<string> file, [WorkflowExpression] Func<string> line1 = null, [WorkflowExpression] Func<string> line2 = null, [WorkflowExpression] Func<string> line3 = null, [WorkflowExpression] Func<int> template = null, [WorkflowExpression] Func<colorInput> color = null, [WorkflowExpression] Func<int> transparency = null, [WorkflowExpression] Func<double> margin = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfblocks")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildAddWatermark(WorkflowExpression<string> file, WorkflowExpression<string> line1 = null, WorkflowExpression<string> line2 = null, WorkflowExpression<string> line3 = null, WorkflowExpression<int> template = null, WorkflowExpression<colorInput> color = null, WorkflowExpression<int> transparency = null, WorkflowExpression<double> margin = null)
        {
            WorkflowExpression.Validate(file, nameof(file), required: true);
            WorkflowExpression.Validate(line1, nameof(line1), required: false);
            WorkflowExpression.Validate(line2, nameof(line2), required: false);
            WorkflowExpression.Validate(line3, nameof(line3), required: false);
            WorkflowExpression.Validate(template, nameof(template), required: false);
            WorkflowExpression.Validate(color, nameof(color), required: false);
            WorkflowExpression.Validate(transparency, nameof(transparency), required: false);
            WorkflowExpression.Validate(margin, nameof(margin), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/add_watermark";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfblocks")]
        [WorkflowExpressionFactory(nameof(__BuildAddImageWatermark))]
        public IBodyWorkflowAction<string> AddImageWatermark([WorkflowExpression] Func<string> file, [WorkflowExpression] Func<string> image, [WorkflowExpression] Func<int> transparency = null, [WorkflowExpression] Func<double> margin = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfblocks")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildAddImageWatermark(WorkflowExpression<string> file, WorkflowExpression<string> image, WorkflowExpression<int> transparency = null, WorkflowExpression<double> margin = null)
        {
            WorkflowExpression.Validate(file, nameof(file), required: true);
            WorkflowExpression.Validate(image, nameof(image), required: true);
            WorkflowExpression.Validate(transparency, nameof(transparency), required: false);
            WorkflowExpression.Validate(margin, nameof(margin), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/add_watermark/image";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfblocks")]
        [WorkflowExpressionFactory(nameof(__BuildExtractPages))]
        public IBodyWorkflowAction<string> ExtractPages([WorkflowExpression] Func<string> file, [WorkflowExpression] Func<int> firstPage = null, [WorkflowExpression] Func<int> lastPage = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfblocks")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildExtractPages(WorkflowExpression<string> file, WorkflowExpression<int> firstPage = null, WorkflowExpression<int> lastPage = null)
        {
            WorkflowExpression.Validate(file, nameof(file), required: true);
            WorkflowExpression.Validate(firstPage, nameof(firstPage), required: false);
            WorkflowExpression.Validate(lastPage, nameof(lastPage), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/extract_pages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfblocks")]
        [WorkflowExpressionFactory(nameof(__BuildMergeDocuments))]
        public IBodyWorkflowAction<string> MergeDocuments([WorkflowExpression] Func<string> file1 = null, [WorkflowExpression] Func<string> file2 = null, [WorkflowExpression] Func<string> file3 = null, [WorkflowExpression] Func<string> file4 = null, [WorkflowExpression] Func<string> file5 = null, [WorkflowExpression] Func<string> file6 = null, [WorkflowExpression] Func<string> file7 = null, [WorkflowExpression] Func<string> file8 = null, [WorkflowExpression] Func<string> file9 = null, [WorkflowExpression] Func<string> file10 = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfblocks")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildMergeDocuments(WorkflowExpression<string> file1 = null, WorkflowExpression<string> file2 = null, WorkflowExpression<string> file3 = null, WorkflowExpression<string> file4 = null, WorkflowExpression<string> file5 = null, WorkflowExpression<string> file6 = null, WorkflowExpression<string> file7 = null, WorkflowExpression<string> file8 = null, WorkflowExpression<string> file9 = null, WorkflowExpression<string> file10 = null)
        {
            WorkflowExpression.Validate(file1, nameof(file1), required: false);
            WorkflowExpression.Validate(file2, nameof(file2), required: false);
            WorkflowExpression.Validate(file3, nameof(file3), required: false);
            WorkflowExpression.Validate(file4, nameof(file4), required: false);
            WorkflowExpression.Validate(file5, nameof(file5), required: false);
            WorkflowExpression.Validate(file6, nameof(file6), required: false);
            WorkflowExpression.Validate(file7, nameof(file7), required: false);
            WorkflowExpression.Validate(file8, nameof(file8), required: false);
            WorkflowExpression.Validate(file9, nameof(file9), required: false);
            WorkflowExpression.Validate(file10, nameof(file10), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/merge_documents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfblocks")]
        [WorkflowExpressionFactory(nameof(__BuildRemovePages))]
        public IBodyWorkflowAction<string> RemovePages([WorkflowExpression] Func<string> file, [WorkflowExpression] Func<int> firstPage = null, [WorkflowExpression] Func<int> lastPage = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfblocks")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildRemovePages(WorkflowExpression<string> file, WorkflowExpression<int> firstPage = null, WorkflowExpression<int> lastPage = null)
        {
            WorkflowExpression.Validate(file, nameof(file), required: true);
            WorkflowExpression.Validate(firstPage, nameof(firstPage), required: false);
            WorkflowExpression.Validate(lastPage, nameof(lastPage), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/remove_pages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfblocks")]
        [WorkflowExpressionFactory(nameof(__BuildRemovePassword))]
        public IBodyWorkflowAction<string> RemovePassword([WorkflowExpression] Func<string> file, [WorkflowExpression] Func<string> password)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfblocks")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildRemovePassword(WorkflowExpression<string> file, WorkflowExpression<string> password)
        {
            WorkflowExpression.Validate(file, nameof(file), required: true);
            WorkflowExpression.Validate(password, nameof(password), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/remove_password";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfblocks")]
        [WorkflowExpressionFactory(nameof(__BuildRemoveRestrictions))]
        public IBodyWorkflowAction<string> RemoveRestrictions([WorkflowExpression] Func<string> file)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfblocks")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildRemoveRestrictions(WorkflowExpression<string> file)
        {
            WorkflowExpression.Validate(file, nameof(file), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/remove_restrictions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfblocks")]
        [WorkflowExpressionFactory(nameof(__BuildRemoveSignatures))]
        public IBodyWorkflowAction<string> RemoveSignatures([WorkflowExpression] Func<string> file)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfblocks")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildRemoveSignatures(WorkflowExpression<string> file)
        {
            WorkflowExpression.Validate(file, nameof(file), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/remove_signatures";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfblocks")]
        [WorkflowExpressionFactory(nameof(__BuildReversePages))]
        public IBodyWorkflowAction<string> ReversePages([WorkflowExpression] Func<string> file)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfblocks")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildReversePages(WorkflowExpression<string> file)
        {
            WorkflowExpression.Validate(file, nameof(file), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/reverse_pages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfblocks")]
        [WorkflowExpressionFactory(nameof(__BuildRotatePages))]
        public IBodyWorkflowAction<string> RotatePages([WorkflowExpression] Func<string> file, [WorkflowExpression] Func<angleInput> angle, [WorkflowExpression] Func<int> firstPage = null, [WorkflowExpression] Func<int> lastPage = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfblocks")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildRotatePages(WorkflowExpression<string> file, WorkflowExpression<angleInput> angle, WorkflowExpression<int> firstPage = null, WorkflowExpression<int> lastPage = null)
        {
            WorkflowExpression.Validate(file, nameof(file), required: true);
            WorkflowExpression.Validate(angle, nameof(angle), required: true);
            WorkflowExpression.Validate(firstPage, nameof(firstPage), required: false);
            WorkflowExpression.Validate(lastPage, nameof(lastPage), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/rotate_pages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }
    }

    public class PdfblocksTriggers([ConnectionName] string connectionId)
    {
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum colorInput
    {
        Red,
        Blue,
        Gray,
        Black
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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