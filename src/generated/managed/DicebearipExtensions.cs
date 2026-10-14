//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Dicebearip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class DicebearipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dicebearip")]
        public IBodyWorkflowAction<AvatarGetResponse> AvatarGet(Expression<Func<versionInput>> version, Expression<Func<styleNameInput>> styleName, Expression<Func<fileFormatInput>> fileFormat, Expression<Func<string>> seed = null, Expression<Func<string>> hair = null, Expression<Func<bool>> flip = null, Expression<Func<int>> rotate = null, Expression<Func<int>> scale = null, Expression<Func<int>> radius = null, Expression<Func<int>> size = null, Expression<Func<string>> backgroundColor = null, Expression<Func<backgroundTypeInput>> backgroundType = null, Expression<Func<int>> backgroundRotations = null, Expression<Func<int>> translateX = null, Expression<Func<int>> translateY = null, Expression<Func<bool>> clip = null, Expression<Func<string>> @base = null, Expression<Func<string>> earrings = null, Expression<Func<int>> earringsProbabilty = null, Expression<Func<string>> eyebrows = null, Expression<Func<string>> eyes = null, Expression<Func<string>> features = null, Expression<Func<int>> featuresProbability = null, Expression<Func<string>> glasses = null, Expression<Func<int>> glassesProbability = null, Expression<Func<string>> hairColor = null, Expression<Func<int>> hairProbability = null, Expression<Func<string>> mouth = null, Expression<Func<string>> skinColor = null)
        {
            var __workflow_version = version == null ? null : WorkflowExpression.Compile(version);
            WorkflowExpression.Validate(__workflow_version, nameof(version), required: true);
            var __workflow_styleName = styleName == null ? null : WorkflowExpression.Compile(styleName);
            WorkflowExpression.Validate(__workflow_styleName, nameof(styleName), required: true);
            var __workflow_fileFormat = fileFormat == null ? null : WorkflowExpression.Compile(fileFormat);
            WorkflowExpression.Validate(__workflow_fileFormat, nameof(fileFormat), required: true);
            var __workflow_seed = seed == null ? null : WorkflowExpression.Compile(seed);
            WorkflowExpression.Validate(__workflow_seed, nameof(seed), required: false);
            var __workflow_hair = hair == null ? null : WorkflowExpression.Compile(hair);
            WorkflowExpression.Validate(__workflow_hair, nameof(hair), required: false);
            var __workflow_flip = flip == null ? null : WorkflowExpression.Compile(flip);
            WorkflowExpression.Validate(__workflow_flip, nameof(flip), required: false);
            var __workflow_rotate = rotate == null ? null : WorkflowExpression.Compile(rotate);
            WorkflowExpression.Validate(__workflow_rotate, nameof(rotate), required: false);
            var __workflow_scale = scale == null ? null : WorkflowExpression.Compile(scale);
            WorkflowExpression.Validate(__workflow_scale, nameof(scale), required: false);
            var __workflow_radius = radius == null ? null : WorkflowExpression.Compile(radius);
            WorkflowExpression.Validate(__workflow_radius, nameof(radius), required: false);
            var __workflow_size = size == null ? null : WorkflowExpression.Compile(size);
            WorkflowExpression.Validate(__workflow_size, nameof(size), required: false);
            var __workflow_backgroundColor = backgroundColor == null ? null : WorkflowExpression.Compile(backgroundColor);
            WorkflowExpression.Validate(__workflow_backgroundColor, nameof(backgroundColor), required: false);
            var __workflow_backgroundType = backgroundType == null ? null : WorkflowExpression.Compile(backgroundType);
            WorkflowExpression.Validate(__workflow_backgroundType, nameof(backgroundType), required: false);
            var __workflow_backgroundRotations = backgroundRotations == null ? null : WorkflowExpression.Compile(backgroundRotations);
            WorkflowExpression.Validate(__workflow_backgroundRotations, nameof(backgroundRotations), required: false);
            var __workflow_translateX = translateX == null ? null : WorkflowExpression.Compile(translateX);
            WorkflowExpression.Validate(__workflow_translateX, nameof(translateX), required: false);
            var __workflow_translateY = translateY == null ? null : WorkflowExpression.Compile(translateY);
            WorkflowExpression.Validate(__workflow_translateY, nameof(translateY), required: false);
            var __workflow_clip = clip == null ? null : WorkflowExpression.Compile(clip);
            WorkflowExpression.Validate(__workflow_clip, nameof(clip), required: false);
            var __workflow_base = @base == null ? null : WorkflowExpression.Compile(@base);
            WorkflowExpression.Validate(__workflow_base, nameof(@base), required: false);
            var __workflow_earrings = earrings == null ? null : WorkflowExpression.Compile(earrings);
            WorkflowExpression.Validate(__workflow_earrings, nameof(earrings), required: false);
            var __workflow_earringsProbabilty = earringsProbabilty == null ? null : WorkflowExpression.Compile(earringsProbabilty);
            WorkflowExpression.Validate(__workflow_earringsProbabilty, nameof(earringsProbabilty), required: false);
            var __workflow_eyebrows = eyebrows == null ? null : WorkflowExpression.Compile(eyebrows);
            WorkflowExpression.Validate(__workflow_eyebrows, nameof(eyebrows), required: false);
            var __workflow_eyes = eyes == null ? null : WorkflowExpression.Compile(eyes);
            WorkflowExpression.Validate(__workflow_eyes, nameof(eyes), required: false);
            var __workflow_features = features == null ? null : WorkflowExpression.Compile(features);
            WorkflowExpression.Validate(__workflow_features, nameof(features), required: false);
            var __workflow_featuresProbability = featuresProbability == null ? null : WorkflowExpression.Compile(featuresProbability);
            WorkflowExpression.Validate(__workflow_featuresProbability, nameof(featuresProbability), required: false);
            var __workflow_glasses = glasses == null ? null : WorkflowExpression.Compile(glasses);
            WorkflowExpression.Validate(__workflow_glasses, nameof(glasses), required: false);
            var __workflow_glassesProbability = glassesProbability == null ? null : WorkflowExpression.Compile(glassesProbability);
            WorkflowExpression.Validate(__workflow_glassesProbability, nameof(glassesProbability), required: false);
            var __workflow_hairColor = hairColor == null ? null : WorkflowExpression.Compile(hairColor);
            WorkflowExpression.Validate(__workflow_hairColor, nameof(hairColor), required: false);
            var __workflow_hairProbability = hairProbability == null ? null : WorkflowExpression.Compile(hairProbability);
            WorkflowExpression.Validate(__workflow_hairProbability, nameof(hairProbability), required: false);
            var __workflow_mouth = mouth == null ? null : WorkflowExpression.Compile(mouth);
            WorkflowExpression.Validate(__workflow_mouth, nameof(mouth), required: false);
            var __workflow_skinColor = skinColor == null ? null : WorkflowExpression.Compile(skinColor);
            WorkflowExpression.Validate(__workflow_skinColor, nameof(skinColor), required: false);
            return new DeferredBodyAction<AvatarGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/{1}/{2}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_version, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_styleName, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_fileFormat, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_seed != null)
                    callPayload.Queries["seed"] = ExpressionConverter.Convert(__workflow_seed);
                if (__workflow_hair != null)
                    callPayload.Queries["hair"] = ExpressionConverter.Convert(__workflow_hair);
                if (__workflow_flip != null)
                    callPayload.Queries["flip"] = ExpressionConverter.Convert(__workflow_flip);
                if (__workflow_rotate != null)
                    callPayload.Queries["rotate"] = ExpressionConverter.Convert(__workflow_rotate);
                if (__workflow_scale != null)
                    callPayload.Queries["scale"] = ExpressionConverter.Convert(__workflow_scale);
                if (__workflow_radius != null)
                    callPayload.Queries["radius"] = ExpressionConverter.Convert(__workflow_radius);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                if (__workflow_backgroundColor != null)
                    callPayload.Queries["backgroundColor"] = ExpressionConverter.Convert(__workflow_backgroundColor);
                if (__workflow_backgroundType != null)
                    callPayload.Queries["backgroundType"] = ExpressionConverter.Convert(__workflow_backgroundType);
                if (__workflow_backgroundRotations != null)
                    callPayload.Queries["backgroundRotations"] = ExpressionConverter.Convert(__workflow_backgroundRotations);
                if (__workflow_translateX != null)
                    callPayload.Queries["translateX"] = ExpressionConverter.Convert(__workflow_translateX);
                if (__workflow_translateY != null)
                    callPayload.Queries["translateY"] = ExpressionConverter.Convert(__workflow_translateY);
                if (__workflow_clip != null)
                    callPayload.Queries["clip"] = ExpressionConverter.Convert(__workflow_clip);
                if (__workflow_base != null)
                    callPayload.Queries["base"] = ExpressionConverter.Convert(__workflow_base);
                if (__workflow_earrings != null)
                    callPayload.Queries["earrings"] = ExpressionConverter.Convert(__workflow_earrings);
                if (__workflow_earringsProbabilty != null)
                    callPayload.Queries["earringsProbabilty"] = ExpressionConverter.Convert(__workflow_earringsProbabilty);
                if (__workflow_eyebrows != null)
                    callPayload.Queries["eyebrows"] = ExpressionConverter.Convert(__workflow_eyebrows);
                if (__workflow_eyes != null)
                    callPayload.Queries["eyes"] = ExpressionConverter.Convert(__workflow_eyes);
                if (__workflow_features != null)
                    callPayload.Queries["features"] = ExpressionConverter.Convert(__workflow_features);
                if (__workflow_featuresProbability != null)
                    callPayload.Queries["featuresProbability"] = ExpressionConverter.Convert(__workflow_featuresProbability);
                if (__workflow_glasses != null)
                    callPayload.Queries["glasses"] = ExpressionConverter.Convert(__workflow_glasses);
                if (__workflow_glassesProbability != null)
                    callPayload.Queries["glassesProbability"] = ExpressionConverter.Convert(__workflow_glassesProbability);
                if (__workflow_hairColor != null)
                    callPayload.Queries["hairColor"] = ExpressionConverter.Convert(__workflow_hairColor);
                if (__workflow_hairProbability != null)
                    callPayload.Queries["hairProbability"] = ExpressionConverter.Convert(__workflow_hairProbability);
                if (__workflow_mouth != null)
                    callPayload.Queries["mouth"] = ExpressionConverter.Convert(__workflow_mouth);
                if (__workflow_skinColor != null)
                    callPayload.Queries["skinColor"] = ExpressionConverter.Convert(__workflow_skinColor);
                return new ApiConnectionAction<AvatarGetResponse>(callPayload);
            });
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum fileFormatInput
    {
        [EnumMember(Value = "png")]
        Png,
        [EnumMember(Value = "jpg")]
        Jpg
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
