//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// The type of the flow operation.
    /// </summary>
    /// <remarks>
    /// DO NOT CHANGE THE ORDER of these enums! Add new OperationTypes to the bottom of the enum.
    /// </remarks>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FlowTemplateOperationType
    {
        /// <summary>
        /// The flow operation type was not specified.
        /// </summary>
        NotSpecified,

        /// <summary>
        /// The HTTP operation type.
        /// </summary>
        Http,

        /// <summary>
        /// The <c>ApiApp</c> operation type.
        /// </summary>
        ApiApp,

        /// <summary>
        /// The recurrence operation type.
        /// </summary>
        Recurrence,

        /// <summary>
        /// The workflow operation type.
        /// </summary>
        Workflow,

        /// <summary>
        /// The flow operation type.
        /// </summary>
        Flow,

        /// <summary>
        /// The wait operation type.
        /// </summary>
        Wait,

        /// <summary>
        /// The <c>ApiConnection</c> operation type.
        /// </summary>
        ApiConnection,

        /// <summary>
        /// The <c>OpenApiConnection</c> operation type.
        /// </summary>
        OpenApiConnection,

        /// <summary>
        /// The manual operation type.
        /// </summary>
        Manual,

        /// <summary>
        /// The <c>ApiConnectionWebhook</c> operation type.
        /// </summary>
        ApiConnectionWebhook,

        /// <summary>
        /// The <c>OpenApiConnectionWebhook</c> operation type.
        /// </summary>
        OpenApiConnectionWebhook,

        /// <summary>
        /// The <c>Response</c> operation type.
        /// </summary>
        Response,

        /// <summary>
        /// The <c>HttpWebhook</c> operation type.
        /// </summary>
        HttpWebhook,

        /// <summary>
        /// The Compose operation type.
        /// </summary>
        Compose,

        /// <summary>
        /// The Query operation type.
        /// </summary>
        Query,

        /// <summary>
        /// The Function operation type.
        /// </summary>
        Function,

        /// <summary>
        /// The API Management operation type.
        /// </summary>
        ApiManagement,

        /// <summary>
        /// The XML Validation operation type.
        /// </summary>
        XmlValidation,

        /// <summary>
        /// The Flat File Encoding operation type.
        /// </summary>
        FlatFileEncoding,

        /// <summary>
        /// The scope operation type.
        /// </summary>
        Scope,

        /// <summary>
        /// The <c>Request</c> operation type.
        /// </summary>
        Request,

        /// <summary>
        /// The if operation type.
        /// </summary>
        If,

        /// <summary>
        /// The foreach scope operation type.
        /// </summary>
        Foreach,

        /// <summary>
        /// The until scope operation type.
        /// </summary>
        Until,

        /// <summary>
        /// The XSLT (Extensible Style sheet Language Transformations) operation type.
        /// </summary>
        Xslt,

        /// <summary>
        /// The Flat File decoding to XML operation type.
        /// </summary>
        FlatFileDecoding,

        /// <summary>
        /// The terminate operation type.
        /// </summary>
        Terminate,

        /// <summary>
        /// The Integration Account Artifact Lookup operation type.
        /// </summary>
        IntegrationAccountArtifactLookup,

        /// <summary>
        /// The switch operation type.
        /// </summary>
        Switch,

        /// <summary>
        /// The Parse JSON operation type.
        /// </summary>
        ParseJson,

        /// <summary>
        /// The Table operation type.
        /// </summary>
        Table,

        /// <summary>
        /// The Join operation type.
        /// </summary>
        Join,

        /// <summary>
        /// The Select operation type.
        /// </summary>
        Select,

        /// <summary>
        /// The initialize variable operation type.
        /// </summary>
        InitializeVariable,

        /// <summary>
        /// The increment variable operation type.
        /// </summary>
        IncrementVariable,

        /// <summary>
        /// The decrement variable operation type.
        /// </summary>
        DecrementVariable,

        /// <summary>
        /// The set variable operation type.
        /// </summary>
        SetVariable,

        /// <summary>
        /// The append to array variable operation type.
        /// </summary>
        AppendToArrayVariable,

        /// <summary>
        /// The append to string variable operation type.
        /// </summary>
        AppendToStringVariable,

        /// <summary>
        /// The batch operation type.
        /// </summary>
        Batch,

        /// <summary>
        /// The send to batch operation type.
        /// </summary>
        SendToBatch,

        /// <summary>
        /// The sliding window operation type.
        /// </summary>
        SlidingWindow,

        /// <summary>
        /// The expression operation type.
        /// </summary>
        Expression,

        /// <summary>
        /// The liquid operation type.
        /// </summary>
        Liquid,

        /// <summary>
        /// The inline javascript code operation type.
        /// </summary>
        JavaScriptCode,

        /// <summary>
        /// The AS2 Decoding operation type.
        /// </summary>
        As2Decode,

        /// <summary>
        /// The AS2 Encoding operation type.
        /// </summary>
        As2Encode,

        /// <summary>
        /// The RosettaNet Encoding operation type.
        /// </summary>
        RosettaNetEncode,

        /// <summary>
        /// The RosettaNet Decoding operation type.
        /// </summary>
        RosettaNetDecode,

        /// <summary>
        /// The RosettaNet Wait for response operation type.
        /// </summary>
        RosettaNetWaitForResponse,

        /// <summary>
        /// The <c>ApiConnection</c> operation type.
        /// </summary>
        ApiConnectionNotification,

        /// <summary>
        /// The <c>OpenApiConnectionNotification</c> operation type.
        /// </summary>
        OpenApiConnectionNotification,

        /// <summary>
        /// The changeset scope operation type.
        /// </summary>
        Changeset,

        /// <summary>
        /// The SWIFT encoding operation type.
        /// </summary>
        SwiftEncode,

        /// <summary>
        /// The SWIFT decoding operation type.
        /// </summary>
        SwiftDecode,

        /// <summary>
        /// The Archive ZIP operation type
        /// </summary>
        ArchiveZip,

        /// <summary>
        /// The service provider operation type
        /// </summary>
        ServiceProvider,

        /// <summary>
        /// The v2 invoke function operation type.
        /// </summary>
        InvokeFunction,

        /// <summary>
        /// The SWIFT MT encoding operation type.
        /// </summary>
        SwiftMTEncode,

        /// <summary>
        /// The SWIFT MT decoding operation type.
        /// </summary>
        SwiftMTDecode,

        /// <summary>
        /// The X12 decoding operation type.
        /// </summary>
        X12Decode,

        /// <summary>
        /// The X12 encode operation type.
        /// </summary>
        X12Encode,

        /// <summary>
        /// The x12 batch encode operation type.
        /// </summary>
        X12BatchEncode,

        /// <summary>
        /// The EDIFACT encode operation type.
        /// </summary>
        EdifactEncode,

        /// <summary>
        /// The EDIFACT batch encode operation type.
        /// </summary>
        EdifactBatchEncode,

        /// <summary>
        /// The EDIFACT decode operation type.
        /// </summary>
        EdifactDecode,

        /// <summary>
        /// The inline powershell code operation type.
        /// </summary>
        PowershellCode,

        /// <summary>
        /// The inline csharp script code operation type.
        /// </summary>
        CSharpScriptCode,

        /// <summary>
        /// The Parse document operation type.
        /// </summary>
        ParseDocument,

        /// <summary>
        /// The Chunk text operation type.
        /// </summary>
        ChunkText,

        /// <summary>
        /// The compose XML operation type.
        /// </summary>
        XmlCompose,

        /// <summary>
        /// The parse XML operation type.
        /// </summary>
        XmlParse,

        /// <summary>
        /// The parse document with metadata operation type.
        /// </summary>
        ParseDocumentWithMetadata,

        /// <summary>
        /// The Chunk text with metadata operation type.
        /// </summary>
        ChunkTextWithMetadata,

        /// <summary>
        /// The agent operation type.
        /// </summary>
        Agent,
    }
}
