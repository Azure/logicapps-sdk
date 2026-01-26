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
        public IBodyWorkflowAction<string> AddPassword(Expression<Func<string>> file, Expression<Func<string>> password)
        {
            var apiCallPath = "/add_password";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfblocks")]
        public IBodyWorkflowAction<string> AddRestrictions(Expression<Func<string>> file, Expression<Func<string>> ownerPassword, Expression<Func<string>> userPassword = null, Expression<Func<bool>> allowCopyContent = null, Expression<Func<bool>> allowChangeContent = null, Expression<Func<bool>> allowPrint = null, Expression<Func<bool>> allowPrintHighResolution = null, Expression<Func<bool>> allowCommentAndFillForm = null, Expression<Func<bool>> allowFillForm = null, Expression<Func<bool>> allowAssembleDocument = null, Expression<Func<bool>> allowAccessibility = null)
        {
            var apiCallPath = "/add_restrictions";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfblocks")]
        public IBodyWorkflowAction<string> AddWatermark(Expression<Func<string>> file, Expression<Func<string>> line1 = null, Expression<Func<string>> line2 = null, Expression<Func<string>> line3 = null, Expression<Func<int>> template = null, Expression<Func<colorInput>> color = null, Expression<Func<int>> transparency = null, Expression<Func<double>> margin = null)
        {
            var apiCallPath = "/add_watermark";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfblocks")]
        public IBodyWorkflowAction<string> AddImageWatermark(Expression<Func<string>> file, Expression<Func<string>> image, Expression<Func<int>> transparency = null, Expression<Func<double>> margin = null)
        {
            var apiCallPath = "/add_watermark/image";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfblocks")]
        public IBodyWorkflowAction<string> ExtractPages(Expression<Func<string>> file, Expression<Func<int>> firstPage = null, Expression<Func<int>> lastPage = null)
        {
            var apiCallPath = "/extract_pages";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfblocks")]
        public IBodyWorkflowAction<string> MergeDocuments(Expression<Func<string>> file1 = null, Expression<Func<string>> file2 = null, Expression<Func<string>> file3 = null, Expression<Func<string>> file4 = null, Expression<Func<string>> file5 = null, Expression<Func<string>> file6 = null, Expression<Func<string>> file7 = null, Expression<Func<string>> file8 = null, Expression<Func<string>> file9 = null, Expression<Func<string>> file10 = null)
        {
            var apiCallPath = "/merge_documents";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfblocks")]
        public IBodyWorkflowAction<string> RemovePages(Expression<Func<string>> file, Expression<Func<int>> firstPage = null, Expression<Func<int>> lastPage = null)
        {
            var apiCallPath = "/remove_pages";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfblocks")]
        public IBodyWorkflowAction<string> RemovePassword(Expression<Func<string>> file, Expression<Func<string>> password)
        {
            var apiCallPath = "/remove_password";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfblocks")]
        public IBodyWorkflowAction<string> RemoveRestrictions(Expression<Func<string>> file)
        {
            var apiCallPath = "/remove_restrictions";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfblocks")]
        public IBodyWorkflowAction<string> RemoveSignatures(Expression<Func<string>> file)
        {
            var apiCallPath = "/remove_signatures";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfblocks")]
        public IBodyWorkflowAction<string> ReversePages(Expression<Func<string>> file)
        {
            var apiCallPath = "/reverse_pages";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfblocks")]
        public IBodyWorkflowAction<string> RotatePages(Expression<Func<string>> file, Expression<Func<angleInput>> angle, Expression<Func<int>> firstPage = null, Expression<Func<int>> lastPage = null)
        {
            var apiCallPath = "/rotate_pages";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
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
        _-90,
        [EnumMember(Value = "-180")]
        _-180,
        [EnumMember(Value = "-270")]
        _-270
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