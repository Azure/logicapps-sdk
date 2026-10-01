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
        public IBodyWorkflowAction<AvatarGetResponse> AvatarGet([WorkflowExpression] Func<versionInput> version, [WorkflowExpression] Func<styleNameInput> styleName, [WorkflowExpression] Func<fileFormatInput> fileFormat, [WorkflowExpression] Func<string> seed = null, [WorkflowExpression] Func<string> hair = null, [WorkflowExpression] Func<bool> flip = null, [WorkflowExpression] Func<int> rotate = null, [WorkflowExpression] Func<int> scale = null, [WorkflowExpression] Func<int> radius = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<string> backgroundColor = null, [WorkflowExpression] Func<backgroundTypeInput> backgroundType = null, [WorkflowExpression] Func<int> backgroundRotations = null, [WorkflowExpression] Func<int> translateX = null, [WorkflowExpression] Func<int> translateY = null, [WorkflowExpression] Func<bool> clip = null, [WorkflowExpression] Func<string> @base = null, [WorkflowExpression] Func<string> earrings = null, [WorkflowExpression] Func<int> earringsProbabilty = null, [WorkflowExpression] Func<string> eyebrows = null, [WorkflowExpression] Func<string> eyes = null, [WorkflowExpression] Func<string> features = null, [WorkflowExpression] Func<int> featuresProbability = null, [WorkflowExpression] Func<string> glasses = null, [WorkflowExpression] Func<int> glassesProbability = null, [WorkflowExpression] Func<string> hairColor = null, [WorkflowExpression] Func<int> hairProbability = null, [WorkflowExpression] Func<string> mouth = null, [WorkflowExpression] Func<string> skinColor = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/{1}/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(version, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(styleName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fileFormat, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (seed != null)
                    callPayload.Queries["seed"] = SourceExpressionConverter.ConvertO(seed);
                if (hair != null)
                    callPayload.Queries["hair"] = SourceExpressionConverter.ConvertO(hair);
                if (flip != null)
                    callPayload.Queries["flip"] = SourceExpressionConverter.ConvertO(flip);
                if (rotate != null)
                    callPayload.Queries["rotate"] = SourceExpressionConverter.ConvertO(rotate);
                if (scale != null)
                    callPayload.Queries["scale"] = SourceExpressionConverter.ConvertO(scale);
                if (radius != null)
                    callPayload.Queries["radius"] = SourceExpressionConverter.ConvertO(radius);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                if (backgroundColor != null)
                    callPayload.Queries["backgroundColor"] = SourceExpressionConverter.ConvertO(backgroundColor);
                if (backgroundType != null)
                    callPayload.Queries["backgroundType"] = SourceExpressionConverter.Convert(backgroundType);
                if (backgroundRotations != null)
                    callPayload.Queries["backgroundRotations"] = SourceExpressionConverter.ConvertO(backgroundRotations);
                if (translateX != null)
                    callPayload.Queries["translateX"] = SourceExpressionConverter.ConvertO(translateX);
                if (translateY != null)
                    callPayload.Queries["translateY"] = SourceExpressionConverter.ConvertO(translateY);
                if (clip != null)
                    callPayload.Queries["clip"] = SourceExpressionConverter.ConvertO(clip);
                if (@base != null)
                    callPayload.Queries["base"] = SourceExpressionConverter.ConvertO(@base);
                if (earrings != null)
                    callPayload.Queries["earrings"] = SourceExpressionConverter.ConvertO(earrings);
                if (earringsProbabilty != null)
                    callPayload.Queries["earringsProbabilty"] = SourceExpressionConverter.ConvertO(earringsProbabilty);
                if (eyebrows != null)
                    callPayload.Queries["eyebrows"] = SourceExpressionConverter.ConvertO(eyebrows);
                if (eyes != null)
                    callPayload.Queries["eyes"] = SourceExpressionConverter.ConvertO(eyes);
                if (features != null)
                    callPayload.Queries["features"] = SourceExpressionConverter.ConvertO(features);
                if (featuresProbability != null)
                    callPayload.Queries["featuresProbability"] = SourceExpressionConverter.ConvertO(featuresProbability);
                if (glasses != null)
                    callPayload.Queries["glasses"] = SourceExpressionConverter.ConvertO(glasses);
                if (glassesProbability != null)
                    callPayload.Queries["glassesProbability"] = SourceExpressionConverter.ConvertO(glassesProbability);
                if (hairColor != null)
                    callPayload.Queries["hairColor"] = SourceExpressionConverter.ConvertO(hairColor);
                if (hairProbability != null)
                    callPayload.Queries["hairProbability"] = SourceExpressionConverter.ConvertO(hairProbability);
                if (mouth != null)
                    callPayload.Queries["mouth"] = SourceExpressionConverter.ConvertO(mouth);
                if (skinColor != null)
                    callPayload.Queries["skinColor"] = SourceExpressionConverter.ConvertO(skinColor);
                return callPayload;
            }

            return new ApiConnectionAction<AvatarGetResponse>(BuildSourceInput);
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