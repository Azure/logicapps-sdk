//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Dicebearip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DicebearipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dicebearip")]
        public IBodyWorkflowAction<AvatarGetResponse> AvatarGet(Expression<Func<versionInput>> version, Expression<Func<styleNameInput>> styleName, Expression<Func<fileFormatInput>> fileFormat, Expression<Func<string>> seed = null, Expression<Func<string>> hair = null, Expression<Func<bool>> flip = null, Expression<Func<int>> rotate = null, Expression<Func<int>> scale = null, Expression<Func<int>> radius = null, Expression<Func<int>> size = null, Expression<Func<string>> backgroundColor = null, Expression<Func<backgroundTypeInput>> backgroundType = null, Expression<Func<int>> backgroundRotations = null, Expression<Func<int>> translateX = null, Expression<Func<int>> translateY = null, Expression<Func<bool>> clip = null, Expression<Func<string>> @base = null, Expression<Func<string>> earrings = null, Expression<Func<int>> earringsProbabilty = null, Expression<Func<string>> eyebrows = null, Expression<Func<string>> eyes = null, Expression<Func<string>> features = null, Expression<Func<int>> featuresProbability = null, Expression<Func<string>> glasses = null, Expression<Func<int>> glassesProbability = null, Expression<Func<string>> hairColor = null, Expression<Func<int>> hairProbability = null, Expression<Func<string>> mouth = null, Expression<Func<string>> skinColor = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/{1}/{2}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(version, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(styleName, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(fileFormat, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (seed != null)
                callPayload.Queries["seed"] = CSharpExpressionConverter.ConvertO(seed);
            if (hair != null)
                callPayload.Queries["hair"] = CSharpExpressionConverter.ConvertO(hair);
            if (flip != null)
                callPayload.Queries["flip"] = CSharpExpressionConverter.ConvertO(flip);
            if (rotate != null)
                callPayload.Queries["rotate"] = CSharpExpressionConverter.ConvertO(rotate);
            if (scale != null)
                callPayload.Queries["scale"] = CSharpExpressionConverter.ConvertO(scale);
            if (radius != null)
                callPayload.Queries["radius"] = CSharpExpressionConverter.ConvertO(radius);
            if (size != null)
                callPayload.Queries["size"] = CSharpExpressionConverter.ConvertO(size);
            if (backgroundColor != null)
                callPayload.Queries["backgroundColor"] = CSharpExpressionConverter.ConvertO(backgroundColor);
            if (backgroundType != null)
                callPayload.Queries["backgroundType"] = CSharpExpressionConverter.Convert(backgroundType);
            if (backgroundRotations != null)
                callPayload.Queries["backgroundRotations"] = CSharpExpressionConverter.ConvertO(backgroundRotations);
            if (translateX != null)
                callPayload.Queries["translateX"] = CSharpExpressionConverter.ConvertO(translateX);
            if (translateY != null)
                callPayload.Queries["translateY"] = CSharpExpressionConverter.ConvertO(translateY);
            if (clip != null)
                callPayload.Queries["clip"] = CSharpExpressionConverter.ConvertO(clip);
            if (@base != null)
                callPayload.Queries["base"] = CSharpExpressionConverter.ConvertO(@base);
            if (earrings != null)
                callPayload.Queries["earrings"] = CSharpExpressionConverter.ConvertO(earrings);
            if (earringsProbabilty != null)
                callPayload.Queries["earringsProbabilty"] = CSharpExpressionConverter.ConvertO(earringsProbabilty);
            if (eyebrows != null)
                callPayload.Queries["eyebrows"] = CSharpExpressionConverter.ConvertO(eyebrows);
            if (eyes != null)
                callPayload.Queries["eyes"] = CSharpExpressionConverter.ConvertO(eyes);
            if (features != null)
                callPayload.Queries["features"] = CSharpExpressionConverter.ConvertO(features);
            if (featuresProbability != null)
                callPayload.Queries["featuresProbability"] = CSharpExpressionConverter.ConvertO(featuresProbability);
            if (glasses != null)
                callPayload.Queries["glasses"] = CSharpExpressionConverter.ConvertO(glasses);
            if (glassesProbability != null)
                callPayload.Queries["glassesProbability"] = CSharpExpressionConverter.ConvertO(glassesProbability);
            if (hairColor != null)
                callPayload.Queries["hairColor"] = CSharpExpressionConverter.ConvertO(hairColor);
            if (hairProbability != null)
                callPayload.Queries["hairProbability"] = CSharpExpressionConverter.ConvertO(hairProbability);
            if (mouth != null)
                callPayload.Queries["mouth"] = CSharpExpressionConverter.ConvertO(mouth);
            if (skinColor != null)
                callPayload.Queries["skinColor"] = CSharpExpressionConverter.ConvertO(skinColor);
            return new ApiConnectionAction<AvatarGetResponse>(callPayload);
        }
    }

    public class DicebearipTriggers([ConnectionName] string connectionId)
    {
    }

    public class AvatarGetResponse
    {
        [JsonProperty("$content-type")]
        public string ContentType { get; set; }

        [JsonProperty("$content")]
        public string Content { get; set; }
    }

    public enum versionInput
    {
        [EnumMember(Value = "5.x")]
        _5X,
        [EnumMember(Value = "5.1")]
        _51,
        [EnumMember(Value = "5")]
        _5,
        [EnumMember(Value = "4.x")]
        _4X,
        [EnumMember(Value = "4.1")]
        _41,
        [EnumMember(Value = "4.9")]
        _49,
        [EnumMember(Value = "4.8")]
        _48,
        [EnumMember(Value = "4.7")]
        _47,
        [EnumMember(Value = "4.6")]
        _46,
        [EnumMember(Value = "4.5")]
        _45,
        [EnumMember(Value = "4.4")]
        _44
    }

    public enum styleNameInput
    {
        [EnumMember(Value = "adventurer")]
        Adventurer,
        [EnumMember(Value = "adventurer-neutral")]
        AdventurerNeutral,
        [EnumMember(Value = "avataaars")]
        Avataaars,
        [EnumMember(Value = "avataaars-neutral")]
        AvataaarsNeutral,
        [EnumMember(Value = "big-ears")]
        BigEars,
        [EnumMember(Value = "big-ears-neutral")]
        BigEarsNeutral,
        [EnumMember(Value = "big-smile")]
        BigSmile,
        [EnumMember(Value = "bottts")]
        Bottts,
        [EnumMember(Value = "bottts-neutral")]
        BotttsNeutral,
        [EnumMember(Value = "croodles")]
        Croodles,
        [EnumMember(Value = "croodles-neutral")]
        CroodlesNeutral,
        [EnumMember(Value = "fun-emoji")]
        FunEmoji,
        [EnumMember(Value = "icons")]
        Icons,
        [EnumMember(Value = "identicon")]
        Identicon,
        [EnumMember(Value = "initials")]
        Initials,
        [EnumMember(Value = "lorelei")]
        Lorelei,
        [EnumMember(Value = "lorelei-neutral")]
        LoreleiNeutral,
        [EnumMember(Value = "micah")]
        Micah,
        [EnumMember(Value = "miniavs")]
        Miniavs,
        [EnumMember(Value = "open-peeps")]
        OpenPeeps,
        [EnumMember(Value = "personas")]
        Personas,
        [EnumMember(Value = "pixel-art")]
        PixelArt,
        [EnumMember(Value = "pixel-art-neutral")]
        PixelArtNeutral
    }

    public enum fileFormatInput
    {
        [EnumMember(Value = "png")]
        Png,
        [EnumMember(Value = "jpg")]
        Jpg
    }

    public enum backgroundTypeInput
    {
        [EnumMember(Value = "gradientLinear")]
        GradientLinear,
        [EnumMember(Value = "solid")]
        Solid
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Dicebearip;

    public partial class WorkflowManagedActions
    {
        public DicebearipActions Dicebearip(string connectionId) => new DicebearipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DicebearipTriggers Dicebearip(string connectionId) => new DicebearipTriggers(connectionId);
    }
}