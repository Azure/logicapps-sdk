//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.XmlOperations
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class XmlOperationsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "xmlOperations")]
        public IBodyWorkflowAction<JToken> XmlTransform(Expression<Func<string>> content, Expression<Func<XmlTransformMapType>> map, Expression<Func<object>> xsltParameters = null, Expression<Func<object>> xmlExtensionObject = null, Expression<Func<string>> transformOptions = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["content"] = ExpressionConverter.ConvertO(content);
            serviceProviderParameters["map"] = ExpressionConverter.ConvertO(map);
            if (xsltParameters != null)
            {
                serviceProviderParameters["xsltParameters"] = ExpressionConverter.ConvertO(xsltParameters);
            }

            if (xmlExtensionObject != null)
            {
                serviceProviderParameters["xmlExtensionObject"] = ExpressionConverter.ConvertO(xmlExtensionObject);
            }

            if (transformOptions != null)
            {
                serviceProviderParameters["transformOptions"] = ExpressionConverter.ConvertO(transformOptions);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "connectionProviders/xmlOperations", operationId: "xmlTransform", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<JToken>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "xmlOperations")]
        public IBodyWorkflowAction<JToken> XmlValidation(Expression<Func<string>> content, Expression<Func<XmlValidationSchemaType>> schema)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["content"] = ExpressionConverter.ConvertO(content);
            serviceProviderParameters["schema"] = ExpressionConverter.ConvertO(schema);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "connectionProviders/xmlOperations", operationId: "xmlValidation", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<JToken>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "xmlOperations")]
        public IBodyWorkflowAction<XmlComposeOutput> XmlCompose(Expression<Func<XmlComposeSchemaType>> schema, Expression<Func<object>> content, Expression<Func<string>> rootNodeQualifiedName = null, Expression<Func<string>> dateTimeFormat = null, Expression<Func<XmlComposeXmlWriterSettingsType>> xmlWriterSettings = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["schema"] = ExpressionConverter.ConvertO(schema);
            if (rootNodeQualifiedName != null)
            {
                serviceProviderParameters["rootNodeQualifiedName"] = ExpressionConverter.ConvertO(rootNodeQualifiedName);
            }

            if (dateTimeFormat != null)
            {
                serviceProviderParameters["dateTimeFormat"] = ExpressionConverter.ConvertO(dateTimeFormat);
            }

            serviceProviderParameters["content"] = ExpressionConverter.ConvertO(content);
            if (xmlWriterSettings != null)
            {
                serviceProviderParameters["xmlWriterSettings"] = ExpressionConverter.ConvertO(xmlWriterSettings);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "connectionProviders/xmlOperations", operationId: "XmlCompose", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<XmlComposeOutput>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "xmlOperations")]
        public IBodyWorkflowAction<XmlParseOutput> XmlParse(Expression<Func<object>> content, Expression<Func<XmlParseSchemaType>> schema, Expression<Func<XmlParseXmlReaderSettingsType>> xmlReaderSettings = null, Expression<Func<XmlParseJsonWriterSettingsType>> jsonWriterSettings = null, Expression<Func<string>> rootNodeQualifiedName = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["content"] = ExpressionConverter.ConvertO(content);
            serviceProviderParameters["schema"] = ExpressionConverter.ConvertO(schema);
            if (xmlReaderSettings != null)
            {
                serviceProviderParameters["xmlReaderSettings"] = ExpressionConverter.ConvertO(xmlReaderSettings);
            }

            if (jsonWriterSettings != null)
            {
                serviceProviderParameters["jsonWriterSettings"] = ExpressionConverter.ConvertO(jsonWriterSettings);
            }

            if (rootNodeQualifiedName != null)
            {
                serviceProviderParameters["rootNodeQualifiedName"] = ExpressionConverter.ConvertO(rootNodeQualifiedName);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "connectionProviders/xmlOperations", operationId: "XmlParse", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<XmlParseOutput>(serviceProviderInput);
        }
    }

    public class XmlOperationsTriggers([ConnectionName] string connectionId)
    {
    }

    public class XmlTransformMapType
    {
        [JsonProperty("source")]
        public XmlTransformMapTypeSourceType Source { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public enum XmlTransformMapTypeSourceType
    {
        IntegrationAccount,
        LogicApp
    }

    public class XmlValidationSchemaType
    {
        [JsonProperty("source")]
        public XmlValidationSchemaTypeSourceType Source { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public enum XmlValidationSchemaTypeSourceType
    {
        IntegrationAccount,
        LogicApp
    }

    public class XmlComposeOutput
    {
        [JsonProperty("xml")]
        public JToken Xml { get; set; }

        [JsonProperty("validationEvents")]
        public XmlComposeOutputValidationEventsTypeItem[] ValidationEvents { get; set; }
    }

    public class XmlComposeOutputValidationEventsTypeItem
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("severity")]
        public XmlComposeOutputValidationEventsTypeItemSeverityType Severity { get; set; }

        [JsonProperty("exception")]
        public XmlComposeOutputValidationEventsTypeItemExceptionType Exception { get; set; }
    }

    public enum XmlComposeOutputValidationEventsTypeItemSeverityType
    {
        Error,
        Warning
    }

    public class XmlComposeOutputValidationEventsTypeItemExceptionType
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("lineNumber")]
        public int LineNumber { get; set; }

        [JsonProperty("linePosition")]
        public int LinePosition { get; set; }
    }

    public class XmlComposeSchemaType
    {
        [JsonProperty("source")]
        public XmlComposeSchemaTypeSourceType Source { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public enum XmlComposeSchemaTypeSourceType
    {
        IntegrationAccount,
        LogicApp
    }

    public class XmlComposeXmlWriterSettingsType
    {
        [JsonProperty("omitXmlDeclaration")]
        public bool OmitXmlDeclaration { get; set; }

        [JsonProperty("newLineOnAttributes")]
        public bool NewLineOnAttributes { get; set; }

        [JsonProperty("newLineHandling")]
        public XmlComposeXmlWriterSettingsTypeNewLineHandlingType NewLineHandling { get; set; }

        [JsonProperty("newLineChars")]
        public string NewLineChars { get; set; }

        [JsonProperty("indentChars")]
        public string IndentChars { get; set; }

        [JsonProperty("indent")]
        public bool Indent { get; set; }

        [JsonProperty("encoding")]
        public XmlComposeXmlWriterSettingsTypeEncodingType Encoding { get; set; }

        [JsonProperty("doNotEscapeUriAttributes")]
        public bool DoNotEscapeUriAttributes { get; set; }

        [JsonProperty("conformanceLevel")]
        public XmlComposeXmlWriterSettingsTypeConformanceLevelType ConformanceLevel { get; set; }

        [JsonProperty("checkCharacters")]
        public bool CheckCharacters { get; set; }
    }

    public enum XmlComposeXmlWriterSettingsTypeNewLineHandlingType
    {
        Replace,
        Entitize,
        None
    }

    public enum XmlComposeXmlWriterSettingsTypeEncodingType
    {
        [EnumMember(Value = "utf-8")]
        Utf8,
        [EnumMember(Value = "utf-16")]
        Utf16,
        [EnumMember(Value = "utf-16BE")]
        Utf16BE,
        [EnumMember(Value = "utf-32")]
        Utf32,
        [EnumMember(Value = "utf-32BE")]
        Utf32BE,
        [EnumMember(Value = "ascii")]
        Ascii,
        [EnumMember(Value = "iso-8859-1")]
        Iso88591,
        [EnumMember(Value = "iso-8859-2")]
        Iso88592,
        [EnumMember(Value = "iso-8859-3")]
        Iso88593,
        [EnumMember(Value = "iso-8859-4")]
        Iso88594,
        [EnumMember(Value = "iso-8859-5")]
        Iso88595,
        [EnumMember(Value = "iso-8859-6")]
        Iso88596,
        [EnumMember(Value = "iso-8859-7")]
        Iso88597,
        [EnumMember(Value = "iso-8859-8")]
        Iso88598,
        [EnumMember(Value = "iso-8859-9")]
        Iso88599,
        [EnumMember(Value = "iso-8859-13")]
        Iso885913,
        [EnumMember(Value = "iso-8859-15")]
        Iso885915,
        [EnumMember(Value = "windows-1250")]
        Windows1250,
        [EnumMember(Value = "windows-1251")]
        Windows1251,
        [EnumMember(Value = "windows-1252")]
        Windows1252,
        [EnumMember(Value = "windows-1253")]
        Windows1253,
        [EnumMember(Value = "windows-1254")]
        Windows1254,
        [EnumMember(Value = "windows-1255")]
        Windows1255,
        [EnumMember(Value = "windows-1256")]
        Windows1256,
        [EnumMember(Value = "windows-1257")]
        Windows1257,
        [EnumMember(Value = "windows-1258")]
        Windows1258,
        [EnumMember(Value = "koi8-r")]
        Koi8R,
        [EnumMember(Value = "koi8-u")]
        Koi8U,
        [EnumMember(Value = "big5")]
        Big5,
        [EnumMember(Value = "gb2312")]
        Gb2312,
        [EnumMember(Value = "gbk")]
        Gbk,
        [EnumMember(Value = "gb18030")]
        Gb18030,
        [EnumMember(Value = "shift_jis")]
        ShiftJis,
        [EnumMember(Value = "euc-jp")]
        EucJp,
        [EnumMember(Value = "euc-kr")]
        EucKr,
        [EnumMember(Value = "iso-2022-jp")]
        Iso2022Jp
    }

    public enum XmlComposeXmlWriterSettingsTypeConformanceLevelType
    {
        Auto,
        Fragment,
        Document
    }

    public class XmlParseOutput
    {
        [JsonProperty("json")]
        public JToken Json { get; set; }
    }

    public class XmlParseSchemaType
    {
        [JsonProperty("source")]
        public XmlParseSchemaTypeSourceType Source { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public enum XmlParseSchemaTypeSourceType
    {
        IntegrationAccount,
        LogicApp
    }

    public class XmlParseXmlReaderSettingsType
    {
        [JsonProperty("dtdProcessing")]
        public XmlParseXmlReaderSettingsTypeDtdProcessingType DtdProcessing { get; set; }

        [JsonProperty("xmlNormalization")]
        public bool XmlNormalization { get; set; }

        [JsonProperty("ignoreWhitespace")]
        public bool IgnoreWhitespace { get; set; }

        [JsonProperty("ignoreProcessingInstructions")]
        public bool IgnoreProcessingInstructions { get; set; }
    }

    public enum XmlParseXmlReaderSettingsTypeDtdProcessingType
    {
        Prohibit,
        Ignore,
        Parse
    }

    public class XmlParseJsonWriterSettingsType
    {
        [JsonProperty("ignoreAttributes")]
        public bool IgnoreAttributes { get; set; }

        [JsonProperty("useFullyQualifiedNames")]
        public bool UseFullyQualifiedNames { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.ServiceProviders.XmlOperations;

    public partial class WorkflowServiceProviderActions
    {
        public XmlOperationsActions XmlOperations(string connectionId) => new XmlOperationsActions(connectionId);
    }

    public partial class WorkflowServiceProviderTriggers
    {
        public XmlOperationsTriggers XmlOperations(string connectionId) => new XmlOperationsTriggers(connectionId);
    }
}