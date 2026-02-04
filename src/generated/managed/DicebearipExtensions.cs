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
            var apiCallPath = String.Format("/{0}/{1}/{2}", ExpressionConverter.ConvertWithUrlEncoding(version, 1), ExpressionConverter.ConvertWithUrlEncoding(styleName, 1), ExpressionConverter.ConvertWithUrlEncoding(fileFormat, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (seed != null)
                callPayload.Queries["seed"] = ExpressionConverter.Convert(seed);
            if (hair != null)
                callPayload.Queries["hair"] = ExpressionConverter.Convert(hair);
            if (flip != null)
                callPayload.Queries["flip"] = ExpressionConverter.Convert(flip);
            if (rotate != null)
                callPayload.Queries["rotate"] = ExpressionConverter.Convert(rotate);
            if (scale != null)
                callPayload.Queries["scale"] = ExpressionConverter.Convert(scale);
            if (radius != null)
                callPayload.Queries["radius"] = ExpressionConverter.Convert(radius);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            if (backgroundColor != null)
                callPayload.Queries["backgroundColor"] = ExpressionConverter.Convert(backgroundColor);
            if (backgroundType != null)
                callPayload.Queries["backgroundType"] = ExpressionConverter.Convert(backgroundType);
            if (backgroundRotations != null)
                callPayload.Queries["backgroundRotations"] = ExpressionConverter.Convert(backgroundRotations);
            if (translateX != null)
                callPayload.Queries["translateX"] = ExpressionConverter.Convert(translateX);
            if (translateY != null)
                callPayload.Queries["translateY"] = ExpressionConverter.Convert(translateY);
            if (clip != null)
                callPayload.Queries["clip"] = ExpressionConverter.Convert(clip);
            if (@base != null)
                callPayload.Queries["base"] = ExpressionConverter.Convert(@base);
            if (earrings != null)
                callPayload.Queries["earrings"] = ExpressionConverter.Convert(earrings);
            if (earringsProbabilty != null)
                callPayload.Queries["earringsProbabilty"] = ExpressionConverter.Convert(earringsProbabilty);
            if (eyebrows != null)
                callPayload.Queries["eyebrows"] = ExpressionConverter.Convert(eyebrows);
            if (eyes != null)
                callPayload.Queries["eyes"] = ExpressionConverter.Convert(eyes);
            if (features != null)
                callPayload.Queries["features"] = ExpressionConverter.Convert(features);
            if (featuresProbability != null)
                callPayload.Queries["featuresProbability"] = ExpressionConverter.Convert(featuresProbability);
            if (glasses != null)
                callPayload.Queries["glasses"] = ExpressionConverter.Convert(glasses);
            if (glassesProbability != null)
                callPayload.Queries["glassesProbability"] = ExpressionConverter.Convert(glassesProbability);
            if (hairColor != null)
                callPayload.Queries["hairColor"] = ExpressionConverter.Convert(hairColor);
            if (hairProbability != null)
                callPayload.Queries["hairProbability"] = ExpressionConverter.Convert(hairProbability);
            if (mouth != null)
                callPayload.Queries["mouth"] = ExpressionConverter.Convert(mouth);
            if (skinColor != null)
                callPayload.Queries["skinColor"] = ExpressionConverter.Convert(skinColor);
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