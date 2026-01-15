//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Thecolorip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ThecoloripActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thecolorip")]
        public IBodyWorkflowAction<ColorGetResponse> ColorGet(Expression<Func<string>> hex = null, Expression<Func<string>> rgb = null, Expression<Func<string>> hsl = null, Expression<Func<string>> cmyk = null)
        {
            var apiCallPath = "/id";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (hex != null)
                callPayload.Queries["hex"] = ExpressionConverter.Convert(hex);
            if (rgb != null)
                callPayload.Queries["rgb"] = ExpressionConverter.Convert(rgb);
            if (hsl != null)
                callPayload.Queries["hsl"] = ExpressionConverter.Convert(hsl);
            if (cmyk != null)
                callPayload.Queries["cmyk"] = ExpressionConverter.Convert(cmyk);
            callPayload.Queries["format"] = Convert.ToString("json");
            return new ApiConnectionAction<ColorGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thecolorip")]
        public IBodyWorkflowAction<SchemeGetResponse> SchemeGet(Expression<Func<string>> hex = null, Expression<Func<string>> rgb = null, Expression<Func<string>> hsl = null, Expression<Func<string>> cmyk = null, Expression<Func<modeInput>> mode = null, Expression<Func<int>> count = null)
        {
            var apiCallPath = "/scheme";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (hex != null)
                callPayload.Queries["hex"] = ExpressionConverter.Convert(hex);
            if (rgb != null)
                callPayload.Queries["rgb"] = ExpressionConverter.Convert(rgb);
            if (hsl != null)
                callPayload.Queries["hsl"] = ExpressionConverter.Convert(hsl);
            if (cmyk != null)
                callPayload.Queries["cmyk"] = ExpressionConverter.Convert(cmyk);
            callPayload.Queries["format"] = Convert.ToString("json");
            callPayload.Queries["mode"] = Convert.ToString("monochrome");
            if (mode != null)
                callPayload.Queries["mode"] = ExpressionConverter.Convert(mode);
            callPayload.Queries["count"] = Convert.ToString(5);
            if (count != null)
                callPayload.Queries["count"] = ExpressionConverter.Convert(count);
            return new ApiConnectionAction<SchemeGetResponse>(callPayload);
        }
    }

    public class ThecoloripTriggers([ConnectionName] string connectionId)
    {
    }

    public class ColorGetResponse
    {
        [JsonProperty("hex")]
        public ColorGetResponseHexType Hex { get; set; }

        [JsonProperty("rgb")]
        public ColorGetResponseRgbType Rgb { get; set; }

        [JsonProperty("hsl")]
        public ColorGetResponseHslType Hsl { get; set; }

        [JsonProperty("hsv")]
        public ColorGetResponseHsvType Hsv { get; set; }

        [JsonProperty("name")]
        public ColorGetResponseNameType Name { get; set; }

        [JsonProperty("cmyk")]
        public ColorGetResponseCmykType Cmyk { get; set; }
        public ColorGetResponseXYZType XYZ { get; set; }

        [JsonProperty("image")]
        public ColorGetResponseImageType Image { get; set; }

        [JsonProperty("contrast")]
        public ColorGetResponseContrastType Contrast { get; set; }

        [JsonProperty("_links")]
        public ColorGetResponseLinksType Links { get; set; }
    }

    public class ColorGetResponseHexType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("clean")]
        public string Clean { get; set; }
    }

    public class ColorGetResponseRgbType
    {
        [JsonProperty("fraction")]
        public ColorGetResponseRgbTypeFractionType Fraction { get; set; }

        [JsonProperty("r")]
        public int R { get; set; }

        [JsonProperty("g")]
        public int G { get; set; }

        [JsonProperty("b")]
        public int B { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class ColorGetResponseRgbTypeFractionType
    {
        [JsonProperty("r")]
        public double R { get; set; }

        [JsonProperty("g")]
        public double G { get; set; }

        [JsonProperty("b")]
        public double B { get; set; }
    }

    public class ColorGetResponseHslType
    {
        [JsonProperty("fraction")]
        public ColorGetResponseHslTypeFractionType Fraction { get; set; }

        [JsonProperty("h")]
        public int H { get; set; }

        [JsonProperty("s")]
        public int S { get; set; }

        [JsonProperty("l")]
        public int L { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class ColorGetResponseHslTypeFractionType
    {
        [JsonProperty("h")]
        public double H { get; set; }

        [JsonProperty("s")]
        public double S { get; set; }

        [JsonProperty("l")]
        public double L { get; set; }
    }

    public class ColorGetResponseHsvType
    {
        [JsonProperty("fraction")]
        public ColorGetResponseHsvTypeFractionType Fraction { get; set; }

        [JsonProperty("h")]
        public int H { get; set; }

        [JsonProperty("s")]
        public int S { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("v")]
        public int V { get; set; }
    }

    public class ColorGetResponseHsvTypeFractionType
    {
        [JsonProperty("h")]
        public double H { get; set; }

        [JsonProperty("s")]
        public int S { get; set; }

        [JsonProperty("v")]
        public double V { get; set; }
    }

    public class ColorGetResponseNameType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("closest_named_hex")]
        public string ClosestNamedHex { get; set; }

        [JsonProperty("exact_match_name")]
        public bool ExactMatchName { get; set; }

        [JsonProperty("distance")]
        public int Distance { get; set; }
    }

    public class ColorGetResponseCmykType
    {
        [JsonProperty("fraction")]
        public ColorGetResponseCmykTypeFractionType Fraction { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("c")]
        public int C { get; set; }

        [JsonProperty("m")]
        public int M { get; set; }

        [JsonProperty("y")]
        public int Y { get; set; }

        [JsonProperty("k")]
        public int K { get; set; }
    }

    public class ColorGetResponseCmykTypeFractionType
    {
        [JsonProperty("c")]
        public double C { get; set; }

        [JsonProperty("m")]
        public double M { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }

        [JsonProperty("k")]
        public double K { get; set; }
    }

    public class ColorGetResponseXYZType
    {
        [JsonProperty("fraction")]
        public ColorGetResponseXYZTypeFractionType Fraction { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
    }

    public class ColorGetResponseXYZTypeFractionType
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
    }

    public class ColorGetResponseImageType
    {
        [JsonProperty("bare")]
        public string Bare { get; set; }

        [JsonProperty("named")]
        public string Named { get; set; }
    }

    public class ColorGetResponseContrastType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class ColorGetResponseLinksType
    {
        [JsonProperty("self")]
        public ColorGetResponseLinksTypeSelfType Self { get; set; }
    }

    public class ColorGetResponseLinksTypeSelfType
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class SchemeGetResponse
    {
        [JsonProperty("mode")]
        public string Mode { get; set; }

        [JsonProperty("count")]
        public string Count { get; set; }

        [JsonProperty("colors")]
        public SchemeGetResponseColorsTypeItem[] Colors { get; set; }

        [JsonProperty("seed")]
        public SchemeGetResponseSeedType Seed { get; set; }

        [JsonProperty("_links")]
        public SchemeGetResponseLinksType Links { get; set; }
    }

    public class SchemeGetResponseColorsTypeItem
    {
        [JsonProperty("hex")]
        public SchemeGetResponseColorsTypeItemHexType Hex { get; set; }

        [JsonProperty("rgb")]
        public SchemeGetResponseColorsTypeItemRgbType Rgb { get; set; }

        [JsonProperty("hsl")]
        public SchemeGetResponseColorsTypeItemHslType Hsl { get; set; }

        [JsonProperty("hsv")]
        public SchemeGetResponseColorsTypeItemHsvType Hsv { get; set; }

        [JsonProperty("name")]
        public SchemeGetResponseColorsTypeItemNameType Name { get; set; }

        [JsonProperty("cmyk")]
        public SchemeGetResponseColorsTypeItemCmykType Cmyk { get; set; }
        public SchemeGetResponseColorsTypeItemXYZType XYZ { get; set; }

        [JsonProperty("image")]
        public SchemeGetResponseColorsTypeItemImageType Image { get; set; }

        [JsonProperty("contrast")]
        public SchemeGetResponseColorsTypeItemContrastType Contrast { get; set; }

        [JsonProperty("_links")]
        public SchemeGetResponseColorsTypeItemLinksType Links { get; set; }
    }

    public class SchemeGetResponseColorsTypeItemHexType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("clean")]
        public string Clean { get; set; }
    }

    public class SchemeGetResponseColorsTypeItemRgbType
    {
        [JsonProperty("fraction")]
        public SchemeGetResponseColorsTypeItemRgbTypeFractionType Fraction { get; set; }

        [JsonProperty("r")]
        public int R { get; set; }

        [JsonProperty("g")]
        public int G { get; set; }

        [JsonProperty("b")]
        public int B { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class SchemeGetResponseColorsTypeItemRgbTypeFractionType
    {
        [JsonProperty("r")]
        public double R { get; set; }

        [JsonProperty("g")]
        public double G { get; set; }

        [JsonProperty("b")]
        public double B { get; set; }
    }

    public class SchemeGetResponseColorsTypeItemHslType
    {
        [JsonProperty("fraction")]
        public SchemeGetResponseColorsTypeItemHslTypeFractionType Fraction { get; set; }

        [JsonProperty("h")]
        public int H { get; set; }

        [JsonProperty("s")]
        public int S { get; set; }

        [JsonProperty("l")]
        public int L { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class SchemeGetResponseColorsTypeItemHslTypeFractionType
    {
        [JsonProperty("h")]
        public double H { get; set; }

        [JsonProperty("s")]
        public double S { get; set; }

        [JsonProperty("l")]
        public double L { get; set; }
    }

    public class SchemeGetResponseColorsTypeItemHsvType
    {
        [JsonProperty("fraction")]
        public SchemeGetResponseColorsTypeItemHsvTypeFractionType Fraction { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("h")]
        public int H { get; set; }

        [JsonProperty("s")]
        public int S { get; set; }

        [JsonProperty("v")]
        public int V { get; set; }
    }

    public class SchemeGetResponseColorsTypeItemHsvTypeFractionType
    {
        [JsonProperty("h")]
        public double H { get; set; }

        [JsonProperty("s")]
        public double S { get; set; }

        [JsonProperty("v")]
        public double V { get; set; }
    }

    public class SchemeGetResponseColorsTypeItemNameType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("closest_named_hex")]
        public string ClosestNamedHex { get; set; }

        [JsonProperty("exact_match_name")]
        public bool ExactMatchName { get; set; }

        [JsonProperty("distance")]
        public int Distance { get; set; }
    }

    public class SchemeGetResponseColorsTypeItemCmykType
    {
        [JsonProperty("fraction")]
        public SchemeGetResponseColorsTypeItemCmykTypeFractionType Fraction { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("c")]
        public int C { get; set; }

        [JsonProperty("m")]
        public int M { get; set; }

        [JsonProperty("y")]
        public int Y { get; set; }

        [JsonProperty("k")]
        public int K { get; set; }
    }

    public class SchemeGetResponseColorsTypeItemCmykTypeFractionType
    {
        [JsonProperty("c")]
        public double C { get; set; }

        [JsonProperty("m")]
        public double M { get; set; }

        [JsonProperty("y")]
        public int Y { get; set; }

        [JsonProperty("k")]
        public double K { get; set; }
    }

    public class SchemeGetResponseColorsTypeItemXYZType
    {
        [JsonProperty("fraction")]
        public SchemeGetResponseColorsTypeItemXYZTypeFractionType Fraction { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
    }

    public class SchemeGetResponseColorsTypeItemXYZTypeFractionType
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
    }

    public class SchemeGetResponseColorsTypeItemImageType
    {
        [JsonProperty("bare")]
        public string Bare { get; set; }

        [JsonProperty("named")]
        public string Named { get; set; }
    }

    public class SchemeGetResponseColorsTypeItemContrastType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class SchemeGetResponseColorsTypeItemLinksType
    {
        [JsonProperty("self")]
        public SchemeGetResponseColorsTypeItemLinksTypeSelfType Self { get; set; }
    }

    public class SchemeGetResponseColorsTypeItemLinksTypeSelfType
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class SchemeGetResponseSeedType
    {
        [JsonProperty("hex")]
        public SchemeGetResponseSeedTypeHexType Hex { get; set; }

        [JsonProperty("rgb")]
        public SchemeGetResponseSeedTypeRgbType Rgb { get; set; }

        [JsonProperty("hsl")]
        public SchemeGetResponseSeedTypeHslType Hsl { get; set; }

        [JsonProperty("hsv")]
        public SchemeGetResponseSeedTypeHsvType Hsv { get; set; }

        [JsonProperty("name")]
        public SchemeGetResponseSeedTypeNameType Name { get; set; }

        [JsonProperty("cmyk")]
        public SchemeGetResponseSeedTypeCmykType Cmyk { get; set; }
        public SchemeGetResponseSeedTypeXYZType XYZ { get; set; }

        [JsonProperty("image")]
        public SchemeGetResponseSeedTypeImageType Image { get; set; }

        [JsonProperty("contrast")]
        public SchemeGetResponseSeedTypeContrastType Contrast { get; set; }

        [JsonProperty("_links")]
        public SchemeGetResponseSeedTypeLinksType Links { get; set; }
    }

    public class SchemeGetResponseSeedTypeHexType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("clean")]
        public string Clean { get; set; }
    }

    public class SchemeGetResponseSeedTypeRgbType
    {
        [JsonProperty("fraction")]
        public SchemeGetResponseSeedTypeRgbTypeFractionType Fraction { get; set; }

        [JsonProperty("r")]
        public int R { get; set; }

        [JsonProperty("g")]
        public int G { get; set; }

        [JsonProperty("b")]
        public int B { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class SchemeGetResponseSeedTypeRgbTypeFractionType
    {
        [JsonProperty("r")]
        public int R { get; set; }

        [JsonProperty("g")]
        public double G { get; set; }

        [JsonProperty("b")]
        public double B { get; set; }
    }

    public class SchemeGetResponseSeedTypeHslType
    {
        [JsonProperty("fraction")]
        public SchemeGetResponseSeedTypeHslTypeFractionType Fraction { get; set; }

        [JsonProperty("h")]
        public int H { get; set; }

        [JsonProperty("s")]
        public int S { get; set; }

        [JsonProperty("l")]
        public int L { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class SchemeGetResponseSeedTypeHslTypeFractionType
    {
        [JsonProperty("h")]
        public double H { get; set; }

        [JsonProperty("s")]
        public int S { get; set; }

        [JsonProperty("l")]
        public double L { get; set; }
    }

    public class SchemeGetResponseSeedTypeHsvType
    {
        [JsonProperty("fraction")]
        public SchemeGetResponseSeedTypeHsvTypeFractionType Fraction { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("h")]
        public int H { get; set; }

        [JsonProperty("s")]
        public int S { get; set; }

        [JsonProperty("v")]
        public int V { get; set; }
    }

    public class SchemeGetResponseSeedTypeHsvTypeFractionType
    {
        [JsonProperty("h")]
        public double H { get; set; }

        [JsonProperty("s")]
        public int S { get; set; }

        [JsonProperty("v")]
        public double V { get; set; }
    }

    public class SchemeGetResponseSeedTypeNameType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("closest_named_hex")]
        public string ClosestNamedHex { get; set; }

        [JsonProperty("exact_match_name")]
        public bool ExactMatchName { get; set; }

        [JsonProperty("distance")]
        public int Distance { get; set; }
    }

    public class SchemeGetResponseSeedTypeCmykType
    {
        [JsonProperty("fraction")]
        public SchemeGetResponseSeedTypeCmykTypeFractionType Fraction { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("c")]
        public int C { get; set; }

        [JsonProperty("m")]
        public int M { get; set; }

        [JsonProperty("y")]
        public int Y { get; set; }

        [JsonProperty("k")]
        public int K { get; set; }
    }

    public class SchemeGetResponseSeedTypeCmykTypeFractionType
    {
        [JsonProperty("c")]
        public int C { get; set; }

        [JsonProperty("m")]
        public double M { get; set; }

        [JsonProperty("y")]
        public int Y { get; set; }

        [JsonProperty("k")]
        public double K { get; set; }
    }

    public class SchemeGetResponseSeedTypeXYZType
    {
        [JsonProperty("fraction")]
        public SchemeGetResponseSeedTypeXYZTypeFractionType Fraction { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
    }

    public class SchemeGetResponseSeedTypeXYZTypeFractionType
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
    }

    public class SchemeGetResponseSeedTypeImageType
    {
        [JsonProperty("bare")]
        public string Bare { get; set; }

        [JsonProperty("named")]
        public string Named { get; set; }
    }

    public class SchemeGetResponseSeedTypeContrastType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class SchemeGetResponseSeedTypeLinksType
    {
        [JsonProperty("self")]
        public SchemeGetResponseSeedTypeLinksTypeSelfType Self { get; set; }
    }

    public class SchemeGetResponseSeedTypeLinksTypeSelfType
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class SchemeGetResponseLinksType
    {
        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("schemes")]
        public SchemeGetResponseLinksTypeSchemesType Schemes { get; set; }
    }

    public class SchemeGetResponseLinksTypeSchemesType
    {
        [JsonProperty("monochrome")]
        public string Monochrome { get; set; }

        [JsonProperty("monochrome-dark")]
        public string MonochromeDark { get; set; }

        [JsonProperty("monochrome-light")]
        public string MonochromeLight { get; set; }

        [JsonProperty("analogic")]
        public string Analogic { get; set; }

        [JsonProperty("complement")]
        public string Complement { get; set; }

        [JsonProperty("analogic-complement")]
        public string AnalogicComplement { get; set; }

        [JsonProperty("triad")]
        public string Triad { get; set; }

        [JsonProperty("quad")]
        public string Quad { get; set; }
    }

    public enum modeInput
    {
        [EnumMember(Value = "monochrome")]
        Monochrome,
        [EnumMember(Value = "monochrome-dark")]
        MonochromeDark,
        [EnumMember(Value = "monochrome-light")]
        MonochromeLight,
        [EnumMember(Value = "analogic")]
        Analogic,
        [EnumMember(Value = "complement")]
        Complement,
        [EnumMember(Value = "analogic-complement")]
        AnalogicComplement,
        [EnumMember(Value = "triad")]
        Triad,
        [EnumMember(Value = "quad")]
        Quad
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Thecolorip;

    public partial class WorkflowManagedActions
    {
        public ThecoloripActions Thecolorip(string connectionId) => new ThecoloripActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ThecoloripTriggers Thecolorip(string connectionId) => new ThecoloripTriggers(connectionId);
    }
}