//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Emojihubip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EmojihubipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "emojihubip")]
        public IBodyWorkflowAction<AllResponseItem[]> All()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/all";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<AllResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "emojihubip")]
        public IBodyWorkflowAction<AllCategoryResponseItem[]> AllCategory([WorkflowExpression] Func<categoryNameInput> categoryName)
        {
            SourceExpression.Validate(categoryName, nameof(categoryName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/all/category_{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(categoryName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<AllCategoryResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "emojihubip")]
        public IBodyWorkflowAction<AllGroupResponseItem[]> AllGroup([WorkflowExpression] Func<groupNameInput> groupName)
        {
            SourceExpression.Validate(groupName, nameof(groupName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/all/group_{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<AllGroupResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "emojihubip")]
        public IBodyWorkflowAction<RandomResponse> Random()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/random";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<RandomResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "emojihubip")]
        public IBodyWorkflowAction<RandomCategoryResponse> RandomCategory([WorkflowExpression] Func<categoryNameInput> categoryName)
        {
            SourceExpression.Validate(categoryName, nameof(categoryName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/random/category_{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(categoryName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<RandomCategoryResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "emojihubip")]
        public IBodyWorkflowAction<RandomGroupResponse> RandomGroup([WorkflowExpression] Func<groupNameInput> groupName)
        {
            SourceExpression.Validate(groupName, nameof(groupName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/random/group_{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<RandomGroupResponse>(BuildSourceInput);
        }
    }

    public class EmojihubipTriggers([ConnectionName] string connectionId)
    {
    }

    public class AllResponseItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("group")]
        public string Group { get; set; }

        [JsonProperty("htmlCode")]
        public string[] HtmlCode { get; set; }

        [JsonProperty("unicode")]
        public string[] Unicode { get; set; }
    }

    public class AllCategoryResponseItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("group")]
        public string Group { get; set; }

        [JsonProperty("htmlCode")]
        public string[] HtmlCode { get; set; }

        [JsonProperty("unicode")]
        public string[] Unicode { get; set; }
    }

    public enum categoryNameInput
    {
        [EnumMember(Value = "smileys_and_people")]
        SmileysAndPeople,
        [EnumMember(Value = "animals_and_nature")]
        AnimalsAndNature,
        [EnumMember(Value = "food_and_drink")]
        FoodAndDrink,
        [EnumMember(Value = "travel_and_places")]
        TravelAndPlaces,
        [EnumMember(Value = "activities")]
        Activities,
        [EnumMember(Value = "objects")]
        Objects,
        [EnumMember(Value = "symbols")]
        Symbols,
        [EnumMember(Value = "flags")]
        Flags
    }

    public class AllGroupResponseItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("group")]
        public string Group { get; set; }

        [JsonProperty("htmlCode")]
        public string[] HtmlCode { get; set; }

        [JsonProperty("unicode")]
        public string[] Unicode { get; set; }
    }

    public enum groupNameInput
    {
        [EnumMember(Value = "body")]
        Body,
        [EnumMember(Value = "cat_face")]
        CatFace,
        [EnumMember(Value = "clothing")]
        Clothing,
        [EnumMember(Value = "creature_face")]
        CreatureFace,
        [EnumMember(Value = "emotion")]
        Emotion,
        [EnumMember(Value = "face_negative")]
        FaceNegative,
        [EnumMember(Value = "face_neutral")]
        FaceNeutral,
        [EnumMember(Value = "face_positive")]
        FacePositive,
        [EnumMember(Value = "face_role")]
        FaceRole,
        [EnumMember(Value = "face_sick")]
        FaceSick,
        [EnumMember(Value = "family")]
        Family,
        [EnumMember(Value = "monkey_face")]
        MonkeyFace,
        [EnumMember(Value = "person")]
        Person,
        [EnumMember(Value = "person_activity")]
        PersonActivity,
        [EnumMember(Value = "person_gesture")]
        PersonGesture,
        [EnumMember(Value = "person_role")]
        PersonRole,
        [EnumMember(Value = "skin_tone")]
        SkinTone,
        [EnumMember(Value = "animal_amphibian")]
        AnimalAmphibian,
        [EnumMember(Value = "animal_bird")]
        AnimalBird,
        [EnumMember(Value = "animal_bug")]
        AnimalBug,
        [EnumMember(Value = "animal_mammal")]
        AnimalMammal,
        [EnumMember(Value = "animal_marine")]
        AnimalMarine,
        [EnumMember(Value = "animal_reptile")]
        AnimalReptile,
        [EnumMember(Value = "plant_flower")]
        PlantFlower,
        [EnumMember(Value = "plant_other")]
        PlantOther,
        [EnumMember(Value = "dishware")]
        Dishware,
        [EnumMember(Value = "drink")]
        Drink,
        [EnumMember(Value = "food_asian")]
        FoodAsian,
        [EnumMember(Value = "food_fruit")]
        FoodFruit,
        [EnumMember(Value = "food_prepared")]
        FoodPrepared,
        [EnumMember(Value = "food_sweat")]
        FoodSweat,
        [EnumMember(Value = "food_vegetable")]
        FoodVegetable,
        [EnumMember(Value = "travel_and_places")]
        TravelAndPlaces,
        [EnumMember(Value = "activities")]
        Activities,
        [EnumMember(Value = "objects")]
        Objects,
        [EnumMember(Value = "symbols")]
        Symbols,
        [EnumMember(Value = "flags")]
        Flags
    }

    public class RandomResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("group")]
        public string Group { get; set; }

        [JsonProperty("htmlCode")]
        public string[] HtmlCode { get; set; }

        [JsonProperty("unicode")]
        public string[] Unicode { get; set; }
    }

    public class RandomCategoryResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("group")]
        public string Group { get; set; }

        [JsonProperty("htmlCode")]
        public string[] HtmlCode { get; set; }

        [JsonProperty("unicode")]
        public string[] Unicode { get; set; }
    }

    public class RandomGroupResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("group")]
        public string Group { get; set; }

        [JsonProperty("htmlCode")]
        public string[] HtmlCode { get; set; }

        [JsonProperty("unicode")]
        public string[] Unicode { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Emojihubip;

    public partial class WorkflowManagedActions
    {
        public EmojihubipActions Emojihubip(string connectionId) => new EmojihubipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public EmojihubipTriggers Emojihubip(string connectionId) => new EmojihubipTriggers(connectionId);
    }
}