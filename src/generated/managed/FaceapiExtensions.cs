//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Faceapi
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FaceapiActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "faceapi")]
        [WorkflowExpressionFactory(nameof(__BuildGetFaceList))]
        public IBodyWorkflowAction<GetFaceListResponse> GetFaceList([WorkflowExpression] Func<string> faceListId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetFaceListResponse> __BuildGetFaceList(WorkflowExpression<string> faceListId)
        {
            WorkflowExpression.Validate(faceListId, nameof(faceListId), required: true);
            return new DeferredBodyAction<GetFaceListResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/face/v1.0/facelists/{0}/", ExpressionConverter.ConvertWithUrlEncoding(faceListId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetFaceListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "faceapi")]
        [WorkflowExpressionFactory(nameof(__BuildCreateFaceList))]
        public IWorkflowAction CreateFaceList([WorkflowExpression] Func<string> faceListId, [WorkflowExpression] Func<string> bodyfaceListName, [WorkflowExpression] Func<string> bodyuserData = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCreateFaceList(WorkflowExpression<string> faceListId, WorkflowExpression<string> bodyfaceListName, WorkflowExpression<string> bodyuserData = null)
        {
            WorkflowExpression.Validate(faceListId, nameof(faceListId), required: true);
            WorkflowExpression.Validate(bodyfaceListName, nameof(bodyfaceListName), required: true);
            WorkflowExpression.Validate(bodyuserData, nameof(bodyuserData), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/face/v1.0/facelists/{0}/", ExpressionConverter.ConvertWithUrlEncoding(faceListId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(bodyfaceListName);
                if (bodyuserData != null)
                {
                    body["userData"] = ExpressionConverter.ConvertO(bodyuserData);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "faceapi")]
        [WorkflowExpressionFactory(nameof(__BuildDetect))]
        public IBodyWorkflowAction<DetectResponseItem[]> Detect([WorkflowExpression] Func<string> bodyimageUrl)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DetectResponseItem[]> __BuildDetect(WorkflowExpression<string> bodyimageUrl)
        {
            WorkflowExpression.Validate(bodyimageUrl, nameof(bodyimageUrl), required: true);
            return new DeferredBodyAction<DetectResponseItem[]>(() =>
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
                body["url"] = ExpressionConverter.ConvertO(bodyimageUrl);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<DetectResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "faceapi")]
        [WorkflowExpressionFactory(nameof(__BuildAddPersonFace))]
        public IBodyWorkflowAction<AddPersonFaceResponse> AddPersonFace([WorkflowExpression] Func<string> personGroupId, [WorkflowExpression] Func<string> personId, [WorkflowExpression] Func<string> bodyimageUrl, [WorkflowExpression] Func<string> targetFace = null, [WorkflowExpression] Func<string> userData = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AddPersonFaceResponse> __BuildAddPersonFace(WorkflowExpression<string> personGroupId, WorkflowExpression<string> personId, WorkflowExpression<string> bodyimageUrl, WorkflowExpression<string> targetFace = null, WorkflowExpression<string> userData = null)
        {
            WorkflowExpression.Validate(personGroupId, nameof(personGroupId), required: true);
            WorkflowExpression.Validate(personId, nameof(personId), required: true);
            WorkflowExpression.Validate(bodyimageUrl, nameof(bodyimageUrl), required: true);
            WorkflowExpression.Validate(targetFace, nameof(targetFace), required: false);
            WorkflowExpression.Validate(userData, nameof(userData), required: false);
            return new DeferredBodyAction<AddPersonFaceResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/face/v1.0/persongroups/{0}/persons/{1}/persistedFaces", ExpressionConverter.ConvertWithUrlEncoding(personGroupId, 1), ExpressionConverter.ConvertWithUrlEncoding(personId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (targetFace != null)
                    callPayload.Queries["targetFace"] = ExpressionConverter.Convert(targetFace);
                if (userData != null)
                    callPayload.Queries["userData"] = ExpressionConverter.Convert(userData);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = ExpressionConverter.ConvertO(bodyimageUrl);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<AddPersonFaceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "faceapi")]
        [WorkflowExpressionFactory(nameof(__BuildAddFaceToFaceList))]
        public IBodyWorkflowAction<AddPersonFaceResponse> AddFaceToFaceList([WorkflowExpression] Func<string> faceListId, [WorkflowExpression] Func<string> bodyimageUrl = null, [WorkflowExpression] Func<string> targetFace = null, [WorkflowExpression] Func<string> userData = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AddPersonFaceResponse> __BuildAddFaceToFaceList(WorkflowExpression<string> faceListId, WorkflowExpression<string> bodyimageUrl = null, WorkflowExpression<string> targetFace = null, WorkflowExpression<string> userData = null)
        {
            WorkflowExpression.Validate(faceListId, nameof(faceListId), required: true);
            WorkflowExpression.Validate(bodyimageUrl, nameof(bodyimageUrl), required: false);
            WorkflowExpression.Validate(targetFace, nameof(targetFace), required: false);
            WorkflowExpression.Validate(userData, nameof(userData), required: false);
            return new DeferredBodyAction<AddPersonFaceResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/face/v1.0/facelists/{0}/persistedFaces", ExpressionConverter.ConvertWithUrlEncoding(faceListId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (targetFace != null)
                    callPayload.Queries["targetFace"] = ExpressionConverter.Convert(targetFace);
                if (userData != null)
                    callPayload.Queries["userData"] = ExpressionConverter.Convert(userData);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyimageUrl != null)
                {
                    body["url"] = ExpressionConverter.ConvertO(bodyimageUrl);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<AddPersonFaceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "faceapi")]
        [WorkflowExpressionFactory(nameof(__BuildGetPersonGroup))]
        public IBodyWorkflowAction<GetPersonGroupResponse> GetPersonGroup([WorkflowExpression] Func<string> personGroupId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetPersonGroupResponse> __BuildGetPersonGroup(WorkflowExpression<string> personGroupId)
        {
            WorkflowExpression.Validate(personGroupId, nameof(personGroupId), required: true);
            return new DeferredBodyAction<GetPersonGroupResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/face/v1.0/persongroups/{0}", ExpressionConverter.ConvertWithUrlEncoding(personGroupId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetPersonGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "faceapi")]
        [WorkflowExpressionFactory(nameof(__BuildCreatePersonGroup))]
        public IWorkflowAction CreatePersonGroup([WorkflowExpression] Func<string> personGroupId, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodyuserData = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCreatePersonGroup(WorkflowExpression<string> personGroupId, WorkflowExpression<string> bodyname, WorkflowExpression<string> bodyuserData = null)
        {
            WorkflowExpression.Validate(personGroupId, nameof(personGroupId), required: true);
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: true);
            WorkflowExpression.Validate(bodyuserData, nameof(bodyuserData), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/face/v1.0/persongroups/{0}", ExpressionConverter.ConvertWithUrlEncoding(personGroupId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                if (bodyuserData != null)
                {
                    body["userData"] = ExpressionConverter.ConvertO(bodyuserData);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "faceapi")]
        [WorkflowExpressionFactory(nameof(__BuildVerify))]
        public IBodyWorkflowAction<VerifyResponse> Verify([WorkflowExpression] Func<string> bodyfaceId, [WorkflowExpression] Func<string> bodypersonGroupId, [WorkflowExpression] Func<string> bodypersonId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<VerifyResponse> __BuildVerify(WorkflowExpression<string> bodyfaceId, WorkflowExpression<string> bodypersonGroupId, WorkflowExpression<string> bodypersonId)
        {
            WorkflowExpression.Validate(bodyfaceId, nameof(bodyfaceId), required: true);
            WorkflowExpression.Validate(bodypersonGroupId, nameof(bodypersonGroupId), required: true);
            WorkflowExpression.Validate(bodypersonId, nameof(bodypersonId), required: true);
            return new DeferredBodyAction<VerifyResponse>(() =>
            {
                var apiCallPath = "/face/v1.0/verify";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["faceId"] = ExpressionConverter.ConvertO(bodyfaceId);
                bodypropCount++;
                body["personGroupId"] = ExpressionConverter.ConvertO(bodypersonGroupId);
                bodypropCount++;
                body["personId"] = ExpressionConverter.ConvertO(bodypersonId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<VerifyResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "faceapi")]
        [WorkflowExpressionFactory(nameof(__BuildGetPersonFace))]
        public IBodyWorkflowAction<GetPersonFaceResponse> GetPersonFace([WorkflowExpression] Func<string> personGroupId, [WorkflowExpression] Func<string> personId, [WorkflowExpression] Func<string> persistedFaceId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetPersonFaceResponse> __BuildGetPersonFace(WorkflowExpression<string> personGroupId, WorkflowExpression<string> personId, WorkflowExpression<string> persistedFaceId)
        {
            WorkflowExpression.Validate(personGroupId, nameof(personGroupId), required: true);
            WorkflowExpression.Validate(personId, nameof(personId), required: true);
            WorkflowExpression.Validate(persistedFaceId, nameof(persistedFaceId), required: true);
            return new DeferredBodyAction<GetPersonFaceResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/face/v1.0/persongroups/{0}/persons/{1}/persistedFaces/{2}", ExpressionConverter.ConvertWithUrlEncoding(personGroupId, 1), ExpressionConverter.ConvertWithUrlEncoding(personId, 1), ExpressionConverter.ConvertWithUrlEncoding(persistedFaceId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetPersonFaceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "faceapi")]
        [WorkflowExpressionFactory(nameof(__BuildCreatePerson))]
        public IBodyWorkflowAction<CreatePersonResponse> CreatePerson([WorkflowExpression] Func<string> personGroupId, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodyuserData = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreatePersonResponse> __BuildCreatePerson(WorkflowExpression<string> personGroupId, WorkflowExpression<string> bodyname, WorkflowExpression<string> bodyuserData = null)
        {
            WorkflowExpression.Validate(personGroupId, nameof(personGroupId), required: true);
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: true);
            WorkflowExpression.Validate(bodyuserData, nameof(bodyuserData), required: false);
            return new DeferredBodyAction<CreatePersonResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/face/v1.0/persongroups/{0}/persons", ExpressionConverter.ConvertWithUrlEncoding(personGroupId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                if (bodyuserData != null)
                {
                    body["userData"] = ExpressionConverter.ConvertO(bodyuserData);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreatePersonResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "faceapi")]
        [WorkflowExpressionFactory(nameof(__BuildGetPerson))]
        public IBodyWorkflowAction<GetPersonResponse> GetPerson([WorkflowExpression] Func<string> personGroupId, [WorkflowExpression] Func<string> personId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetPersonResponse> __BuildGetPerson(WorkflowExpression<string> personGroupId, WorkflowExpression<string> personId)
        {
            WorkflowExpression.Validate(personGroupId, nameof(personGroupId), required: true);
            WorkflowExpression.Validate(personId, nameof(personId), required: true);
            return new DeferredBodyAction<GetPersonResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/face/v1.0/persongroups/{0}/persons/{1}/", ExpressionConverter.ConvertWithUrlEncoding(personGroupId, 1), ExpressionConverter.ConvertWithUrlEncoding(personId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetPersonResponse>(callPayload);
            });
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