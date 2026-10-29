//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Dicebearip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DicebearipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dicebearip")]
        public IBodyWorkflowAction<AvatarGetResponse, ApiConnectionActionConfiguration> AvatarGet(Expression<Func<versionInput>> version, Expression<Func<styleNameInput>> styleName, Expression<Func<fileFormatInput>> fileFormat, Expression<Func<string>> seed = null, Expression<Func<string>> hair = null, Expression<Func<bool>> flip = null, Expression<Func<int>> rotate = null, Expression<Func<int>> scale = null, Expression<Func<int>> radius = null, Expression<Func<int>> size = null, Expression<Func<string>> backgroundColor = null, Expression<Func<backgroundTypeInput>> backgroundType = null, Expression<Func<int>> backgroundRotations = null, Expression<Func<int>> translateX = null, Expression<Func<int>> translateY = null, Expression<Func<bool>> clip = null, Expression<Func<string>> @base = null, Expression<Func<string>> earrings = null, Expression<Func<int>> earringsProbabilty = null, Expression<Func<string>> eyebrows = null, Expression<Func<string>> eyes = null, Expression<Func<string>> features = null, Expression<Func<int>> featuresProbability = null, Expression<Func<string>> glasses = null, Expression<Func<int>> glassesProbability = null, Expression<Func<string>> hairColor = null, Expression<Func<int>> hairProbability = null, Expression<Func<string>> mouth = null, Expression<Func<string>> skinColor = null)
        {
            var __workflow_version = WorkflowExpression.Compile(version, nameof(version), required: true);
            var __workflow_styleName = WorkflowExpression.Compile(styleName, nameof(styleName), required: true);
            var __workflow_fileFormat = WorkflowExpression.Compile(fileFormat, nameof(fileFormat), required: true);
            var __workflow_seed = WorkflowExpression.Compile(seed, nameof(seed), required: false);
            var __workflow_hair = WorkflowExpression.Compile(hair, nameof(hair), required: false);
            var __workflow_flip = WorkflowExpression.Compile(flip, nameof(flip), required: false);
            var __workflow_rotate = WorkflowExpression.Compile(rotate, nameof(rotate), required: false);
            var __workflow_scale = WorkflowExpression.Compile(scale, nameof(scale), required: false);
            var __workflow_radius = WorkflowExpression.Compile(radius, nameof(radius), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_backgroundColor = WorkflowExpression.Compile(backgroundColor, nameof(backgroundColor), required: false);
            var __workflow_backgroundType = WorkflowExpression.Compile(backgroundType, nameof(backgroundType), required: false);
            var __workflow_backgroundRotations = WorkflowExpression.Compile(backgroundRotations, nameof(backgroundRotations), required: false);
            var __workflow_translateX = WorkflowExpression.Compile(translateX, nameof(translateX), required: false);
            var __workflow_translateY = WorkflowExpression.Compile(translateY, nameof(translateY), required: false);
            var __workflow_clip = WorkflowExpression.Compile(clip, nameof(clip), required: false);
            var __workflow_base = WorkflowExpression.Compile(@base, nameof(@base), required: false);
            var __workflow_earrings = WorkflowExpression.Compile(earrings, nameof(earrings), required: false);
            var __workflow_earringsProbabilty = WorkflowExpression.Compile(earringsProbabilty, nameof(earringsProbabilty), required: false);
            var __workflow_eyebrows = WorkflowExpression.Compile(eyebrows, nameof(eyebrows), required: false);
            var __workflow_eyes = WorkflowExpression.Compile(eyes, nameof(eyes), required: false);
            var __workflow_features = WorkflowExpression.Compile(features, nameof(features), required: false);
            var __workflow_featuresProbability = WorkflowExpression.Compile(featuresProbability, nameof(featuresProbability), required: false);
            var __workflow_glasses = WorkflowExpression.Compile(glasses, nameof(glasses), required: false);
            var __workflow_glassesProbability = WorkflowExpression.Compile(glassesProbability, nameof(glassesProbability), required: false);
            var __workflow_hairColor = WorkflowExpression.Compile(hairColor, nameof(hairColor), required: false);
            var __workflow_hairProbability = WorkflowExpression.Compile(hairProbability, nameof(hairProbability), required: false);
            var __workflow_mouth = WorkflowExpression.Compile(mouth, nameof(mouth), required: false);
            var __workflow_skinColor = WorkflowExpression.Compile(skinColor, nameof(skinColor), required: false);
            return new DeferredBodyAction<AvatarGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/{1}/{2}", __workflow_version.WithUrlEncoding(1), __workflow_styleName.WithUrlEncoding(1), __workflow_fileFormat.WithUrlEncoding(1)));
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