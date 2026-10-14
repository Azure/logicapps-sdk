//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pdfblocks
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class PdfblocksActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfblocks")]
        public IBodyWorkflowAction<string> AddPassword(Expression<Func<string>> file, Expression<Func<string>> password)
        {
            var __workflow_file = file == null ? null : WorkflowExpression.Compile(file);
            WorkflowExpression.Validate(__workflow_file, nameof(file), required: true);
            var __workflow_password = password == null ? null : WorkflowExpression.Compile(password);
            WorkflowExpression.Validate(__workflow_password, nameof(password), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/add_password";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfblocks")]
        public IBodyWorkflowAction<string> AddRestrictions(Expression<Func<string>> file, Expression<Func<string>> ownerPassword, Expression<Func<string>> userPassword = null, Expression<Func<bool>> allowCopyContent = null, Expression<Func<bool>> allowChangeContent = null, Expression<Func<bool>> allowPrint = null, Expression<Func<bool>> allowPrintHighResolution = null, Expression<Func<bool>> allowCommentAndFillForm = null, Expression<Func<bool>> allowFillForm = null, Expression<Func<bool>> allowAssembleDocument = null, Expression<Func<bool>> allowAccessibility = null)
        {
            var __workflow_file = file == null ? null : WorkflowExpression.Compile(file);
            WorkflowExpression.Validate(__workflow_file, nameof(file), required: true);
            var __workflow_ownerPassword = ownerPassword == null ? null : WorkflowExpression.Compile(ownerPassword);
            WorkflowExpression.Validate(__workflow_ownerPassword, nameof(ownerPassword), required: true);
            var __workflow_userPassword = userPassword == null ? null : WorkflowExpression.Compile(userPassword);
            WorkflowExpression.Validate(__workflow_userPassword, nameof(userPassword), required: false);
            var __workflow_allowCopyContent = allowCopyContent == null ? null : WorkflowExpression.Compile(allowCopyContent);
            WorkflowExpression.Validate(__workflow_allowCopyContent, nameof(allowCopyContent), required: false);
            var __workflow_allowChangeContent = allowChangeContent == null ? null : WorkflowExpression.Compile(allowChangeContent);
            WorkflowExpression.Validate(__workflow_allowChangeContent, nameof(allowChangeContent), required: false);
            var __workflow_allowPrint = allowPrint == null ? null : WorkflowExpression.Compile(allowPrint);
            WorkflowExpression.Validate(__workflow_allowPrint, nameof(allowPrint), required: false);
            var __workflow_allowPrintHighResolution = allowPrintHighResolution == null ? null : WorkflowExpression.Compile(allowPrintHighResolution);
            WorkflowExpression.Validate(__workflow_allowPrintHighResolution, nameof(allowPrintHighResolution), required: false);
            var __workflow_allowCommentAndFillForm = allowCommentAndFillForm == null ? null : WorkflowExpression.Compile(allowCommentAndFillForm);
            WorkflowExpression.Validate(__workflow_allowCommentAndFillForm, nameof(allowCommentAndFillForm), required: false);
            var __workflow_allowFillForm = allowFillForm == null ? null : WorkflowExpression.Compile(allowFillForm);
            WorkflowExpression.Validate(__workflow_allowFillForm, nameof(allowFillForm), required: false);
            var __workflow_allowAssembleDocument = allowAssembleDocument == null ? null : WorkflowExpression.Compile(allowAssembleDocument);
            WorkflowExpression.Validate(__workflow_allowAssembleDocument, nameof(allowAssembleDocument), required: false);
            var __workflow_allowAccessibility = allowAccessibility == null ? null : WorkflowExpression.Compile(allowAccessibility);
            WorkflowExpression.Validate(__workflow_allowAccessibility, nameof(allowAccessibility), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/add_restrictions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfblocks")]
        public IBodyWorkflowAction<string> AddWatermark(Expression<Func<string>> file, Expression<Func<string>> line1 = null, Expression<Func<string>> line2 = null, Expression<Func<string>> line3 = null, Expression<Func<int>> template = null, Expression<Func<colorInput>> color = null, Expression<Func<int>> transparency = null, Expression<Func<double>> margin = null)
        {
            var __workflow_file = file == null ? null : WorkflowExpression.Compile(file);
            WorkflowExpression.Validate(__workflow_file, nameof(file), required: true);
            var __workflow_line1 = line1 == null ? null : WorkflowExpression.Compile(line1);
            WorkflowExpression.Validate(__workflow_line1, nameof(line1), required: false);
            var __workflow_line2 = line2 == null ? null : WorkflowExpression.Compile(line2);
            WorkflowExpression.Validate(__workflow_line2, nameof(line2), required: false);
            var __workflow_line3 = line3 == null ? null : WorkflowExpression.Compile(line3);
            WorkflowExpression.Validate(__workflow_line3, nameof(line3), required: false);
            var __workflow_template = template == null ? null : WorkflowExpression.Compile(template);
            WorkflowExpression.Validate(__workflow_template, nameof(template), required: false);
            var __workflow_color = color == null ? null : WorkflowExpression.Compile(color);
            WorkflowExpression.Validate(__workflow_color, nameof(color), required: false);
            var __workflow_transparency = transparency == null ? null : WorkflowExpression.Compile(transparency);
            WorkflowExpression.Validate(__workflow_transparency, nameof(transparency), required: false);
            var __workflow_margin = margin == null ? null : WorkflowExpression.Compile(margin);
            WorkflowExpression.Validate(__workflow_margin, nameof(margin), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/add_watermark";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfblocks")]
        public IBodyWorkflowAction<string> AddImageWatermark(Expression<Func<string>> file, Expression<Func<string>> image, Expression<Func<int>> transparency = null, Expression<Func<double>> margin = null)
        {
            var __workflow_file = file == null ? null : WorkflowExpression.Compile(file);
            WorkflowExpression.Validate(__workflow_file, nameof(file), required: true);
            var __workflow_image = image == null ? null : WorkflowExpression.Compile(image);
            WorkflowExpression.Validate(__workflow_image, nameof(image), required: true);
            var __workflow_transparency = transparency == null ? null : WorkflowExpression.Compile(transparency);
            WorkflowExpression.Validate(__workflow_transparency, nameof(transparency), required: false);
            var __workflow_margin = margin == null ? null : WorkflowExpression.Compile(margin);
            WorkflowExpression.Validate(__workflow_margin, nameof(margin), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/add_watermark/image";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfblocks")]
        public IBodyWorkflowAction<string> ExtractPages(Expression<Func<string>> file, Expression<Func<int>> firstPage = null, Expression<Func<int>> lastPage = null)
        {
            var __workflow_file = file == null ? null : WorkflowExpression.Compile(file);
            WorkflowExpression.Validate(__workflow_file, nameof(file), required: true);
            var __workflow_firstPage = firstPage == null ? null : WorkflowExpression.Compile(firstPage);
            WorkflowExpression.Validate(__workflow_firstPage, nameof(firstPage), required: false);
            var __workflow_lastPage = lastPage == null ? null : WorkflowExpression.Compile(lastPage);
            WorkflowExpression.Validate(__workflow_lastPage, nameof(lastPage), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/extract_pages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfblocks")]
        public IBodyWorkflowAction<string> MergeDocuments(Expression<Func<string>> file1 = null, Expression<Func<string>> file2 = null, Expression<Func<string>> file3 = null, Expression<Func<string>> file4 = null, Expression<Func<string>> file5 = null, Expression<Func<string>> file6 = null, Expression<Func<string>> file7 = null, Expression<Func<string>> file8 = null, Expression<Func<string>> file9 = null, Expression<Func<string>> file10 = null)
        {
            var __workflow_file1 = file1 == null ? null : WorkflowExpression.Compile(file1);
            WorkflowExpression.Validate(__workflow_file1, nameof(file1), required: false);
            var __workflow_file2 = file2 == null ? null : WorkflowExpression.Compile(file2);
            WorkflowExpression.Validate(__workflow_file2, nameof(file2), required: false);
            var __workflow_file3 = file3 == null ? null : WorkflowExpression.Compile(file3);
            WorkflowExpression.Validate(__workflow_file3, nameof(file3), required: false);
            var __workflow_file4 = file4 == null ? null : WorkflowExpression.Compile(file4);
            WorkflowExpression.Validate(__workflow_file4, nameof(file4), required: false);
            var __workflow_file5 = file5 == null ? null : WorkflowExpression.Compile(file5);
            WorkflowExpression.Validate(__workflow_file5, nameof(file5), required: false);
            var __workflow_file6 = file6 == null ? null : WorkflowExpression.Compile(file6);
            WorkflowExpression.Validate(__workflow_file6, nameof(file6), required: false);
            var __workflow_file7 = file7 == null ? null : WorkflowExpression.Compile(file7);
            WorkflowExpression.Validate(__workflow_file7, nameof(file7), required: false);
            var __workflow_file8 = file8 == null ? null : WorkflowExpression.Compile(file8);
            WorkflowExpression.Validate(__workflow_file8, nameof(file8), required: false);
            var __workflow_file9 = file9 == null ? null : WorkflowExpression.Compile(file9);
            WorkflowExpression.Validate(__workflow_file9, nameof(file9), required: false);
            var __workflow_file10 = file10 == null ? null : WorkflowExpression.Compile(file10);
            WorkflowExpression.Validate(__workflow_file10, nameof(file10), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/merge_documents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfblocks")]
        public IBodyWorkflowAction<string> RemovePages(Expression<Func<string>> file, Expression<Func<int>> firstPage = null, Expression<Func<int>> lastPage = null)
        {
            var __workflow_file = file == null ? null : WorkflowExpression.Compile(file);
            WorkflowExpression.Validate(__workflow_file, nameof(file), required: true);
            var __workflow_firstPage = firstPage == null ? null : WorkflowExpression.Compile(firstPage);
            WorkflowExpression.Validate(__workflow_firstPage, nameof(firstPage), required: false);
            var __workflow_lastPage = lastPage == null ? null : WorkflowExpression.Compile(lastPage);
            WorkflowExpression.Validate(__workflow_lastPage, nameof(lastPage), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/remove_pages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfblocks")]
        public IBodyWorkflowAction<string> RemovePassword(Expression<Func<string>> file, Expression<Func<string>> password)
        {
            var __workflow_file = file == null ? null : WorkflowExpression.Compile(file);
            WorkflowExpression.Validate(__workflow_file, nameof(file), required: true);
            var __workflow_password = password == null ? null : WorkflowExpression.Compile(password);
            WorkflowExpression.Validate(__workflow_password, nameof(password), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/remove_password";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfblocks")]
        public IBodyWorkflowAction<string> RemoveRestrictions(Expression<Func<string>> file)
        {
            var __workflow_file = file == null ? null : WorkflowExpression.Compile(file);
            WorkflowExpression.Validate(__workflow_file, nameof(file), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/remove_restrictions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfblocks")]
        public IBodyWorkflowAction<string> RemoveSignatures(Expression<Func<string>> file)
        {
            var __workflow_file = file == null ? null : WorkflowExpression.Compile(file);
            WorkflowExpression.Validate(__workflow_file, nameof(file), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/remove_signatures";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfblocks")]
        public IBodyWorkflowAction<string> ReversePages(Expression<Func<string>> file)
        {
            var __workflow_file = file == null ? null : WorkflowExpression.Compile(file);
            WorkflowExpression.Validate(__workflow_file, nameof(file), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/reverse_pages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfblocks")]
        public IBodyWorkflowAction<string> RotatePages(Expression<Func<string>> file, Expression<Func<angleInput>> angle, Expression<Func<int>> firstPage = null, Expression<Func<int>> lastPage = null)
        {
            var __workflow_file = file == null ? null : WorkflowExpression.Compile(file);
            WorkflowExpression.Validate(__workflow_file, nameof(file), required: true);
            var __workflow_angle = angle == null ? null : WorkflowExpression.Compile(angle);
            WorkflowExpression.Validate(__workflow_angle, nameof(angle), required: true);
            var __workflow_firstPage = firstPage == null ? null : WorkflowExpression.Compile(firstPage);
            WorkflowExpression.Validate(__workflow_firstPage, nameof(firstPage), required: false);
            var __workflow_lastPage = lastPage == null ? null : WorkflowExpression.Compile(lastPage);
            WorkflowExpression.Validate(__workflow_lastPage, nameof(lastPage), required: false);
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
