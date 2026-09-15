//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Faceapi
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FaceapiActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "faceapi")]
        public IBodyWorkflowAction<GetFaceListResponse> GetFaceList(Expression<Func<string>> faceListId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/face/v1.0/facelists/{0}/", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(faceListId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetFaceListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "faceapi")]
        public IWorkflowAction CreateFaceList(Expression<Func<string>> faceListId, Expression<Func<string>> bodyfaceListName, Expression<Func<string>> bodyuserData = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/face/v1.0/facelists/{0}/", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(faceListId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["name"] = CSharpExpressionConverter.ConvertToken(bodyfaceListName);
            if (bodyuserData != null)
            {
                body["userData"] = CSharpExpressionConverter.ConvertToken(bodyuserData);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "faceapi")]
        public IBodyWorkflowAction<DetectResponseItem[]> Detect(Expression<Func<string>> bodyimageUrl)
        {
            var apiCallPath = "/face/v1.0/detect";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["returnFaceId"] = Convert.ToString("true");
            callPayload.Queries["returnFaceAttributes"] = Convert.ToString("headPose,glasses");
            callPayload.Queries["returnFaceLandmarks"] = Convert.ToString("true");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["url"] = CSharpExpressionConverter.ConvertToken(bodyimageUrl);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<DetectResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "faceapi")]
        public IBodyWorkflowAction<AddPersonFaceResponse> AddPersonFace(Expression<Func<string>> personGroupId, Expression<Func<string>> personId, Expression<Func<string>> bodyimageUrl, Expression<Func<string>> targetFace = null, Expression<Func<string>> userData = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/face/v1.0/persongroups/{0}/persons/{1}/persistedFaces", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(personGroupId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(personId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (targetFace != null)
                callPayload.Queries["targetFace"] = CSharpExpressionConverter.ConvertO(targetFace);
            if (userData != null)
                callPayload.Queries["userData"] = CSharpExpressionConverter.ConvertO(userData);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["url"] = CSharpExpressionConverter.ConvertToken(bodyimageUrl);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<AddPersonFaceResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "faceapi")]
        public IBodyWorkflowAction<AddPersonFaceResponse> AddFaceToFaceList(Expression<Func<string>> faceListId, Expression<Func<string>> bodyimageUrl = null, Expression<Func<string>> targetFace = null, Expression<Func<string>> userData = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/face/v1.0/facelists/{0}/persistedFaces", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(faceListId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (targetFace != null)
                callPayload.Queries["targetFace"] = CSharpExpressionConverter.ConvertO(targetFace);
            if (userData != null)
                callPayload.Queries["userData"] = CSharpExpressionConverter.ConvertO(userData);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyimageUrl != null)
            {
                body["url"] = CSharpExpressionConverter.ConvertToken(bodyimageUrl);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<AddPersonFaceResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "faceapi")]
        public IBodyWorkflowAction<GetPersonGroupResponse> GetPersonGroup(Expression<Func<string>> personGroupId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/face/v1.0/persongroups/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(personGroupId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetPersonGroupResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "faceapi")]
        public IWorkflowAction CreatePersonGroup(Expression<Func<string>> personGroupId, Expression<Func<string>> bodyname, Expression<Func<string>> bodyuserData = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/face/v1.0/persongroups/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(personGroupId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["name"] = CSharpExpressionConverter.ConvertToken(bodyname);
            if (bodyuserData != null)
            {
                body["userData"] = CSharpExpressionConverter.ConvertToken(bodyuserData);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "faceapi")]
        public IBodyWorkflowAction<VerifyResponse> Verify(Expression<Func<string>> bodyfaceId, Expression<Func<string>> bodypersonGroupId, Expression<Func<string>> bodypersonId)
        {
            var apiCallPath = "/face/v1.0/verify";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["faceId"] = CSharpExpressionConverter.ConvertToken(bodyfaceId);
            bodypropCount++;
            body["personGroupId"] = CSharpExpressionConverter.ConvertToken(bodypersonGroupId);
            bodypropCount++;
            body["personId"] = CSharpExpressionConverter.ConvertToken(bodypersonId);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<VerifyResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "faceapi")]
        public IBodyWorkflowAction<GetPersonFaceResponse> GetPersonFace(Expression<Func<string>> personGroupId, Expression<Func<string>> personId, Expression<Func<string>> persistedFaceId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/face/v1.0/persongroups/{0}/persons/{1}/persistedFaces/{2}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(personGroupId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(personId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(persistedFaceId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetPersonFaceResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "faceapi")]
        public IBodyWorkflowAction<CreatePersonResponse> CreatePerson(Expression<Func<string>> personGroupId, Expression<Func<string>> bodyname, Expression<Func<string>> bodyuserData = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/face/v1.0/persongroups/{0}/persons", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(personGroupId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["name"] = CSharpExpressionConverter.ConvertToken(bodyname);
            if (bodyuserData != null)
            {
                body["userData"] = CSharpExpressionConverter.ConvertToken(bodyuserData);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreatePersonResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "faceapi")]
        public IBodyWorkflowAction<GetPersonResponse> GetPerson(Expression<Func<string>> personGroupId, Expression<Func<string>> personId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/face/v1.0/persongroups/{0}/persons/{1}/", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(personGroupId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(personId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetPersonResponse>(callPayload);
        }
    }

    public class FaceapiTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetFaceListResponse
    {
        [JsonProperty("persistedFaces")]
        public GetFaceListResponsePersistedFacesTypeItem[] PersistedFaces { get; set; }

        [JsonProperty("faceListId")]
        public string FaceListId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("userData")]
        public string UserData { get; set; }
    }

    public class GetFaceListResponsePersistedFacesTypeItem
    {
        [JsonProperty("persistedFaceId")]
        public string PersistedFaceId { get; set; }

        [JsonProperty("userData")]
        public string UserData { get; set; }
    }

    public class DetectResponseItem
    {
        [JsonProperty("faceId")]
        public string FaceId { get; set; }

        [JsonProperty("faceRectangle")]
        public DetectResponseItemFaceRectangleType FaceRectangle { get; set; }

        [JsonProperty("faceLandmarks")]
        public DetectResponseItemFaceLandmarksType FaceLandmarks { get; set; }

        [JsonProperty("faceAttributes")]
        public DetectResponseItemFaceAttributesType FaceAttributes { get; set; }
    }

    public class DetectResponseItemFaceRectangleType
    {
        [JsonProperty("top")]
        public int Top { get; set; }

        [JsonProperty("left")]
        public int Left { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }
    }

    public class DetectResponseItemFaceLandmarksType
    {
        [JsonProperty("pupilLeft")]
        public DetectResponseItemFaceLandmarksTypePupilLeftType PupilLeft { get; set; }

        [JsonProperty("pupilRight")]
        public DetectResponseItemFaceLandmarksTypePupilRightType PupilRight { get; set; }

        [JsonProperty("noseTip")]
        public DetectResponseItemFaceLandmarksTypeNoseTipType NoseTip { get; set; }

        [JsonProperty("mouthLeft")]
        public DetectResponseItemFaceLandmarksTypeMouthLeftType MouthLeft { get; set; }

        [JsonProperty("mouthRight")]
        public DetectResponseItemFaceLandmarksTypeMouthRightType MouthRight { get; set; }

        [JsonProperty("eyebrowLeftOuter")]
        public DetectResponseItemFaceLandmarksTypeEyebrowLeftOuterType EyebrowLeftOuter { get; set; }

        [JsonProperty("eyebrowLeftInner")]
        public DetectResponseItemFaceLandmarksTypeEyebrowLeftInnerType EyebrowLeftInner { get; set; }

        [JsonProperty("eyeLeftOuter")]
        public DetectResponseItemFaceLandmarksTypeEyeLeftOuterType EyeLeftOuter { get; set; }

        [JsonProperty("eyeLeftTop")]
        public DetectResponseItemFaceLandmarksTypeEyeLeftTopType EyeLeftTop { get; set; }

        [JsonProperty("eyeLeftBottom")]
        public DetectResponseItemFaceLandmarksTypeEyeLeftBottomType EyeLeftBottom { get; set; }

        [JsonProperty("eyeLeftInner")]
        public DetectResponseItemFaceLandmarksTypeEyeLeftInnerType EyeLeftInner { get; set; }

        [JsonProperty("eyebrowRightInner")]
        public DetectResponseItemFaceLandmarksTypeEyebrowRightInnerType EyebrowRightInner { get; set; }

        [JsonProperty("eyebrowRightOuter")]
        public DetectResponseItemFaceLandmarksTypeEyebrowRightOuterType EyebrowRightOuter { get; set; }

        [JsonProperty("eyeRightInner")]
        public DetectResponseItemFaceLandmarksTypeEyeRightInnerType EyeRightInner { get; set; }

        [JsonProperty("eyeRightTop")]
        public DetectResponseItemFaceLandmarksTypeEyeRightTopType EyeRightTop { get; set; }

        [JsonProperty("eyeRightBottom")]
        public DetectResponseItemFaceLandmarksTypeEyeRightBottomType EyeRightBottom { get; set; }

        [JsonProperty("eyeRightOuter")]
        public DetectResponseItemFaceLandmarksTypeEyeRightOuterType EyeRightOuter { get; set; }

        [JsonProperty("noseRootLeft")]
        public DetectResponseItemFaceLandmarksTypeNoseRootLeftType NoseRootLeft { get; set; }

        [JsonProperty("noseRootRight")]
        public DetectResponseItemFaceLandmarksTypeNoseRootRightType NoseRootRight { get; set; }

        [JsonProperty("noseLeftAlarTop")]
        public DetectResponseItemFaceLandmarksTypeNoseLeftAlarTopType NoseLeftAlarTop { get; set; }

        [JsonProperty("noseRightAlarTop")]
        public DetectResponseItemFaceLandmarksTypeNoseRightAlarTopType NoseRightAlarTop { get; set; }

        [JsonProperty("noseLeftAlarOutTip")]
        public DetectResponseItemFaceLandmarksTypeNoseLeftAlarOutTipType NoseLeftAlarOutTip { get; set; }

        [JsonProperty("noseRightAlarOutTip")]
        public DetectResponseItemFaceLandmarksTypeNoseRightAlarOutTipType NoseRightAlarOutTip { get; set; }

        [JsonProperty("upperLipTop")]
        public DetectResponseItemFaceLandmarksTypeUpperLipTopType UpperLipTop { get; set; }

        [JsonProperty("upperLipBottom")]
        public DetectResponseItemFaceLandmarksTypeUpperLipBottomType UpperLipBottom { get; set; }

        [JsonProperty("underLipTop")]
        public DetectResponseItemFaceLandmarksTypeUnderLipTopType UnderLipTop { get; set; }

        [JsonProperty("underLipBottom")]
        public DetectResponseItemFaceLandmarksTypeUnderLipBottomType UnderLipBottom { get; set; }
    }

    public class DetectResponseItemFaceLandmarksTypePupilLeftType
    {
        [JsonProperty("x")]
        public double LeftPupilX { get; set; }

        [JsonProperty("y")]
        public double LeftPupilY { get; set; }
    }

    public class DetectResponseItemFaceLandmarksTypePupilRightType
    {
        [JsonProperty("x")]
        public double RightPupilX { get; set; }

        [JsonProperty("y")]
        public double RightPupilY { get; set; }
    }

    public class DetectResponseItemFaceLandmarksTypeNoseTipType
    {
        [JsonProperty("x")]
        public double NoseTipX { get; set; }

        [JsonProperty("y")]
        public double NoseTipY { get; set; }
    }

    public class DetectResponseItemFaceLandmarksTypeMouthLeftType
    {
        [JsonProperty("x")]
        public double MouthLeftX { get; set; }

        [JsonProperty("y")]
        public double MouthLeftY { get; set; }
    }

    public class DetectResponseItemFaceLandmarksTypeMouthRightType
    {
        [JsonProperty("x")]
        public double MouthRightX { get; set; }

        [JsonProperty("y")]
        public double MouthRightY { get; set; }
    }

    public class DetectResponseItemFaceLandmarksTypeEyebrowLeftOuterType
    {
        [JsonProperty("x")]
        public double OuterLeftEyebrowX { get; set; }

        [JsonProperty("y")]
        public double OuterLeftEyebrowY { get; set; }
    }

    public class DetectResponseItemFaceLandmarksTypeEyebrowLeftInnerType
    {
        [JsonProperty("x")]
        public double InnerLeftEybrowX { get; set; }

        [JsonProperty("y")]
        public double InnerLeftEyebrowY { get; set; }
    }

    public class DetectResponseItemFaceLandmarksTypeEyeLeftOuterType
    {
        [JsonProperty("x")]
        public double OuterLeftEyeX { get; set; }

        [JsonProperty("y")]
        public double OuterLeftEyeY { get; set; }
    }

    public class DetectResponseItemFaceLandmarksTypeEyeLeftTopType
    {
        [JsonProperty("x")]
        public double TopOfLeftEyeX { get; set; }

        [JsonProperty("y")]
        public double TopOfLeftEyeY { get; set; }
    }

    public class DetectResponseItemFaceLandmarksTypeEyeLeftBottomType
    {
        [JsonProperty("x")]
        public double BottomOfLeftEyeX { get; set; }

        [JsonProperty("y")]
        public double BottomOfLeftEyeY { get; set; }
    }

    public class DetectResponseItemFaceLandmarksTypeEyeLeftInnerType
    {
        [JsonProperty("x")]
        public double InnerLeftEyeX { get; set; }

        [JsonProperty("y")]
        public double InnerLeftEyeY { get; set; }
    }

    public class DetectResponseItemFaceLandmarksTypeEyebrowRightInnerType
    {
        [JsonProperty("x")]
        public double InnerRightEybrowX { get; set; }

        [JsonProperty("y")]
        public double InnerRightEyebrowY { get; set; }
    }

    public class DetectResponseItemFaceLandmarksTypeEyebrowRightOuterType
    {
        [JsonProperty("x")]
        public double OuterRightEyebrowX { get; set; }

        [JsonProperty("y")]
        public double OuterRightEyebrowY { get; set; }
    }

    public class DetectResponseItemFaceLandmarksTypeEyeRightInnerType
    {
        [JsonProperty("x")]
        public double InnerRightEyeX { get; set; }

        [JsonProperty("y")]
        public double InnerRightEyeY { get; set; }
    }

    public class DetectResponseItemFaceLandmarksTypeEyeRightTopType
    {
        [JsonProperty("x")]
        public double TopOfRightEyeX { get; set; }

        [JsonProperty("y")]
        public double TopOfRightEyeY { get; set; }
    }

    public class DetectResponseItemFaceLandmarksTypeEyeRightBottomType
    {
        [JsonProperty("x")]
        public double BottomOfRightEyeX { get; set; }

        [JsonProperty("y")]
        public double BottomOfRightEyeY { get; set; }
    }

    public class DetectResponseItemFaceLandmarksTypeEyeRightOuterType
    {
        [JsonProperty("x")]
        public double OuterRightEyeX { get; set; }

        [JsonProperty("y")]
        public double OuterRightEyeY { get; set; }
    }

    public class DetectResponseItemFaceLandmarksTypeNoseRootLeftType
    {
        [JsonProperty("x")]
        public double LeftNoseRootX { get; set; }

        [JsonProperty("y")]
        public double LeftNoseRootY { get; set; }
    }

    public class DetectResponseItemFaceLandmarksTypeNoseRootRightType
    {
        [JsonProperty("x")]
        public double RightNoseRootX { get; set; }

        [JsonProperty("y")]
        public double RightNoseRootY { get; set; }
    }

    public class DetectResponseItemFaceLandmarksTypeNoseLeftAlarTopType
    {
        [JsonProperty("x")]
        public double TopOfLeftNoseAltarX { get; set; }

        [JsonProperty("y")]
        public double TopOfLeftNoseAltarY { get; set; }
    }

    public class DetectResponseItemFaceLandmarksTypeNoseRightAlarTopType
    {
        [JsonProperty("x")]
        public double TopOfRightNoseAltarX { get; set; }

        [JsonProperty("y")]
        public double TopOfRightNoseAltarY { get; set; }
    }

    public class DetectResponseItemFaceLandmarksTypeNoseLeftAlarOutTipType
    {
        [JsonProperty("x")]
        public double TipOfLeftNoseAltarOutX { get; set; }

        [JsonProperty("y")]
        public double TipOfLeftNoseAltarOutY { get; set; }
    }

    public class DetectResponseItemFaceLandmarksTypeNoseRightAlarOutTipType
    {
        [JsonProperty("x")]
        public double TipOfRightNoseAltarOutX { get; set; }

        [JsonProperty("y")]
        public double TipOfRightNoseAltarOutY { get; set; }
    }

    public class DetectResponseItemFaceLandmarksTypeUpperLipTopType
    {
        [JsonProperty("x")]
        public double TopOfUpperLipX { get; set; }

        [JsonProperty("y")]
        public double TopOfUpperLipY { get; set; }
    }

    public class DetectResponseItemFaceLandmarksTypeUpperLipBottomType
    {
        [JsonProperty("x")]
        public double BottomOfUpperLipX { get; set; }

        [JsonProperty("y")]
        public double BottomOfUpperLipY { get; set; }
    }

    public class DetectResponseItemFaceLandmarksTypeUnderLipTopType
    {
        [JsonProperty("x")]
        public double TopOfUnderLipX { get; set; }

        [JsonProperty("y")]
        public double TopOfUnderLipY { get; set; }
    }

    public class DetectResponseItemFaceLandmarksTypeUnderLipBottomType
    {
        [JsonProperty("x")]
        public double BottomOfUnderLipX { get; set; }

        [JsonProperty("y")]
        public double BottomOfUnderLipY { get; set; }
    }

    public class DetectResponseItemFaceAttributesType
    {
        [JsonProperty("headPose")]
        public DetectResponseItemFaceAttributesTypeHeadPoseType HeadPose { get; set; }

        [JsonProperty("glasses")]
        public string Glasses { get; set; }
    }

    public class DetectResponseItemFaceAttributesTypeHeadPoseType
    {
        [JsonProperty("pitch")]
        public double HeadPosePitch { get; set; }

        [JsonProperty("roll")]
        public double HeadPoseRoll { get; set; }

        [JsonProperty("yaw")]
        public double HeadPoseYaw { get; set; }
    }

    public class AddPersonFaceResponse
    {
        [JsonProperty("persistedFaceId")]
        public string PersistedFaceId { get; set; }
    }

    public class GetPersonGroupResponse
    {
        [JsonProperty("personGroupId")]
        public string PersonGroupId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("userData")]
        public string UserData { get; set; }
    }

    public class VerifyResponse
    {
        [JsonProperty("isIdentical")]
        public bool IsIdentical { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class GetPersonFaceResponse
    {
        [JsonProperty("persistedFaceId")]
        public string PersistedFaceId { get; set; }

        [JsonProperty("userData")]
        public string UserData { get; set; }
    }

    public class CreatePersonResponse
    {
        [JsonProperty("personId")]
        public string PersonId { get; set; }
    }

    public class GetPersonResponse
    {
        [JsonProperty("personId")]
        public string PersonId { get; set; }

        [JsonProperty("persistedFaceIds")]
        public GetPersonResponsePersistedFaceIdsTypeItem[] PersistedFaceIds { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("userData")]
        public string UserData { get; set; }
    }

    public class GetPersonResponsePersistedFaceIdsTypeItem
    {
        [JsonProperty("persistedFaceId")]
        public string PersistedFaceId { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Faceapi;

    public partial class WorkflowManagedActions
    {
        public FaceapiActions Faceapi(string connectionId) => new FaceapiActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public FaceapiTriggers Faceapi(string connectionId) => new FaceapiTriggers(connectionId);
    }
}