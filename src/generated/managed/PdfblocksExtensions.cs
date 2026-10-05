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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildAddPassword(WorkflowValue<string> file, WorkflowValue<string> password)
        {
            WorkflowValue.Validate(file, nameof(file), required: true);
            WorkflowValue.Validate(password, nameof(password), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildAddRestrictions(WorkflowValue<string> file, WorkflowValue<string> ownerPassword, WorkflowValue<string> userPassword = null, WorkflowValue<bool> allowCopyContent = null, WorkflowValue<bool> allowChangeContent = null, WorkflowValue<bool> allowPrint = null, WorkflowValue<bool> allowPrintHighResolution = null, WorkflowValue<bool> allowCommentAndFillForm = null, WorkflowValue<bool> allowFillForm = null, WorkflowValue<bool> allowAssembleDocument = null, WorkflowValue<bool> allowAccessibility = null)
        {
            WorkflowValue.Validate(file, nameof(file), required: true);
            WorkflowValue.Validate(ownerPassword, nameof(ownerPassword), required: true);
            WorkflowValue.Validate(userPassword, nameof(userPassword), required: false);
            WorkflowValue.Validate(allowCopyContent, nameof(allowCopyContent), required: false);
            WorkflowValue.Validate(allowChangeContent, nameof(allowChangeContent), required: false);
            WorkflowValue.Validate(allowPrint, nameof(allowPrint), required: false);
            WorkflowValue.Validate(allowPrintHighResolution, nameof(allowPrintHighResolution), required: false);
            WorkflowValue.Validate(allowCommentAndFillForm, nameof(allowCommentAndFillForm), required: false);
            WorkflowValue.Validate(allowFillForm, nameof(allowFillForm), required: false);
            WorkflowValue.Validate(allowAssembleDocument, nameof(allowAssembleDocument), required: false);
            WorkflowValue.Validate(allowAccessibility, nameof(allowAccessibility), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildAddWatermark(WorkflowValue<string> file, WorkflowValue<string> line1 = null, WorkflowValue<string> line2 = null, WorkflowValue<string> line3 = null, WorkflowValue<int> template = null, WorkflowValue<colorInput> color = null, WorkflowValue<int> transparency = null, WorkflowValue<double> margin = null)
        {
            WorkflowValue.Validate(file, nameof(file), required: true);
            WorkflowValue.Validate(line1, nameof(line1), required: false);
            WorkflowValue.Validate(line2, nameof(line2), required: false);
            WorkflowValue.Validate(line3, nameof(line3), required: false);
            WorkflowValue.Validate(template, nameof(template), required: false);
            WorkflowValue.Validate(color, nameof(color), required: false);
            WorkflowValue.Validate(transparency, nameof(transparency), required: false);
            WorkflowValue.Validate(margin, nameof(margin), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildAddImageWatermark(WorkflowValue<string> file, WorkflowValue<string> image, WorkflowValue<int> transparency = null, WorkflowValue<double> margin = null)
        {
            WorkflowValue.Validate(file, nameof(file), required: true);
            WorkflowValue.Validate(image, nameof(image), required: true);
            WorkflowValue.Validate(transparency, nameof(transparency), required: false);
            WorkflowValue.Validate(margin, nameof(margin), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildExtractPages(WorkflowValue<string> file, WorkflowValue<int> firstPage = null, WorkflowValue<int> lastPage = null)
        {
            WorkflowValue.Validate(file, nameof(file), required: true);
            WorkflowValue.Validate(firstPage, nameof(firstPage), required: false);
            WorkflowValue.Validate(lastPage, nameof(lastPage), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildMergeDocuments(WorkflowValue<string> file1 = null, WorkflowValue<string> file2 = null, WorkflowValue<string> file3 = null, WorkflowValue<string> file4 = null, WorkflowValue<string> file5 = null, WorkflowValue<string> file6 = null, WorkflowValue<string> file7 = null, WorkflowValue<string> file8 = null, WorkflowValue<string> file9 = null, WorkflowValue<string> file10 = null)
        {
            WorkflowValue.Validate(file1, nameof(file1), required: false);
            WorkflowValue.Validate(file2, nameof(file2), required: false);
            WorkflowValue.Validate(file3, nameof(file3), required: false);
            WorkflowValue.Validate(file4, nameof(file4), required: false);
            WorkflowValue.Validate(file5, nameof(file5), required: false);
            WorkflowValue.Validate(file6, nameof(file6), required: false);
            WorkflowValue.Validate(file7, nameof(file7), required: false);
            WorkflowValue.Validate(file8, nameof(file8), required: false);
            WorkflowValue.Validate(file9, nameof(file9), required: false);
            WorkflowValue.Validate(file10, nameof(file10), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildRemovePages(WorkflowValue<string> file, WorkflowValue<int> firstPage = null, WorkflowValue<int> lastPage = null)
        {
            WorkflowValue.Validate(file, nameof(file), required: true);
            WorkflowValue.Validate(firstPage, nameof(firstPage), required: false);
            WorkflowValue.Validate(lastPage, nameof(lastPage), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildRemovePassword(WorkflowValue<string> file, WorkflowValue<string> password)
        {
            WorkflowValue.Validate(file, nameof(file), required: true);
            WorkflowValue.Validate(password, nameof(password), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildRemoveRestrictions(WorkflowValue<string> file)
        {
            WorkflowValue.Validate(file, nameof(file), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildRemoveSignatures(WorkflowValue<string> file)
        {
            WorkflowValue.Validate(file, nameof(file), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildReversePages(WorkflowValue<string> file)
        {
            WorkflowValue.Validate(file, nameof(file), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildRotatePages(WorkflowValue<string> file, WorkflowValue<angleInput> angle, WorkflowValue<int> firstPage = null, WorkflowValue<int> lastPage = null)
        {
            WorkflowValue.Validate(file, nameof(file), required: true);
            WorkflowValue.Validate(angle, nameof(angle), required: true);
            WorkflowValue.Validate(firstPage, nameof(firstPage), required: false);
            WorkflowValue.Validate(lastPage, nameof(lastPage), required: false);
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
