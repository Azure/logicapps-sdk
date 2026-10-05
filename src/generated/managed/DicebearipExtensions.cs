//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Dicebearip
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DicebearipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dicebearip")]
        [WorkflowExpressionFactory(nameof(__BuildAvatarGet))]
        public IBodyWorkflowAction<AvatarGetResponse> AvatarGet([WorkflowExpression] Func<versionInput> version, [WorkflowExpression] Func<styleNameInput> styleName, [WorkflowExpression] Func<fileFormatInput> fileFormat, [WorkflowExpression] Func<string> seed = null, [WorkflowExpression] Func<string> hair = null, [WorkflowExpression] Func<bool> flip = null, [WorkflowExpression] Func<int> rotate = null, [WorkflowExpression] Func<int> scale = null, [WorkflowExpression] Func<int> radius = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<string> backgroundColor = null, [WorkflowExpression] Func<backgroundTypeInput> backgroundType = null, [WorkflowExpression] Func<int> backgroundRotations = null, [WorkflowExpression] Func<int> translateX = null, [WorkflowExpression] Func<int> translateY = null, [WorkflowExpression] Func<bool> clip = null, [WorkflowExpression] Func<string> @base = null, [WorkflowExpression] Func<string> earrings = null, [WorkflowExpression] Func<int> earringsProbabilty = null, [WorkflowExpression] Func<string> eyebrows = null, [WorkflowExpression] Func<string> eyes = null, [WorkflowExpression] Func<string> features = null, [WorkflowExpression] Func<int> featuresProbability = null, [WorkflowExpression] Func<string> glasses = null, [WorkflowExpression] Func<int> glassesProbability = null, [WorkflowExpression] Func<string> hairColor = null, [WorkflowExpression] Func<int> hairProbability = null, [WorkflowExpression] Func<string> mouth = null, [WorkflowExpression] Func<string> skinColor = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AvatarGetResponse> __BuildAvatarGet(WorkflowValue<versionInput> version, WorkflowValue<styleNameInput> styleName, WorkflowValue<fileFormatInput> fileFormat, WorkflowValue<string> seed = null, WorkflowValue<string> hair = null, WorkflowValue<bool> flip = null, WorkflowValue<int> rotate = null, WorkflowValue<int> scale = null, WorkflowValue<int> radius = null, WorkflowValue<int> size = null, WorkflowValue<string> backgroundColor = null, WorkflowValue<backgroundTypeInput> backgroundType = null, WorkflowValue<int> backgroundRotations = null, WorkflowValue<int> translateX = null, WorkflowValue<int> translateY = null, WorkflowValue<bool> clip = null, WorkflowValue<string> @base = null, WorkflowValue<string> earrings = null, WorkflowValue<int> earringsProbabilty = null, WorkflowValue<string> eyebrows = null, WorkflowValue<string> eyes = null, WorkflowValue<string> features = null, WorkflowValue<int> featuresProbability = null, WorkflowValue<string> glasses = null, WorkflowValue<int> glassesProbability = null, WorkflowValue<string> hairColor = null, WorkflowValue<int> hairProbability = null, WorkflowValue<string> mouth = null, WorkflowValue<string> skinColor = null)
        {
            WorkflowValue.Validate(version, nameof(version), required: true);
            WorkflowValue.Validate(styleName, nameof(styleName), required: true);
            WorkflowValue.Validate(fileFormat, nameof(fileFormat), required: true);
            WorkflowValue.Validate(seed, nameof(seed), required: false);
            WorkflowValue.Validate(hair, nameof(hair), required: false);
            WorkflowValue.Validate(flip, nameof(flip), required: false);
            WorkflowValue.Validate(rotate, nameof(rotate), required: false);
            WorkflowValue.Validate(scale, nameof(scale), required: false);
            WorkflowValue.Validate(radius, nameof(radius), required: false);
            WorkflowValue.Validate(size, nameof(size), required: false);
            WorkflowValue.Validate(backgroundColor, nameof(backgroundColor), required: false);
            WorkflowValue.Validate(backgroundType, nameof(backgroundType), required: false);
            WorkflowValue.Validate(backgroundRotations, nameof(backgroundRotations), required: false);
            WorkflowValue.Validate(translateX, nameof(translateX), required: false);
            WorkflowValue.Validate(translateY, nameof(translateY), required: false);
            WorkflowValue.Validate(clip, nameof(clip), required: false);
            WorkflowValue.Validate(@base, nameof(@base), required: false);
            WorkflowValue.Validate(earrings, nameof(earrings), required: false);
            WorkflowValue.Validate(earringsProbabilty, nameof(earringsProbabilty), required: false);
            WorkflowValue.Validate(eyebrows, nameof(eyebrows), required: false);
            WorkflowValue.Validate(eyes, nameof(eyes), required: false);
            WorkflowValue.Validate(features, nameof(features), required: false);
            WorkflowValue.Validate(featuresProbability, nameof(featuresProbability), required: false);
            WorkflowValue.Validate(glasses, nameof(glasses), required: false);
            WorkflowValue.Validate(glassesProbability, nameof(glassesProbability), required: false);
            WorkflowValue.Validate(hairColor, nameof(hairColor), required: false);
            WorkflowValue.Validate(hairProbability, nameof(hairProbability), required: false);
            WorkflowValue.Validate(mouth, nameof(mouth), required: false);
            WorkflowValue.Validate(skinColor, nameof(skinColor), required: false);
            return new DeferredBodyAction<AvatarGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/{1}/{2}", ExpressionConverter.ConvertWithUrlEncoding(version, 1), ExpressionConverter.ConvertWithUrlEncoding(styleName, 1), ExpressionConverter.ConvertWithUrlEncoding(fileFormat, 1));
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
