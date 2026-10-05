//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Dynamicsignal
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DynamicsignalActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicsignal")]
        [WorkflowExpressionFactory(nameof(__BuildGetUserByEmail))]
        public IBodyWorkflowAction<UserRequestResponse> GetUserByEmail([WorkflowExpression] Func<string> bodyemail, [WorkflowExpression] Func<string[]> bodyinclude = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UserRequestResponse> __BuildGetUserByEmail(WorkflowValue<string> bodyemail, WorkflowValue<string[]> bodyinclude = null)
        {
            WorkflowValue.Validate(bodyemail, nameof(bodyemail), required: true);
            WorkflowValue.Validate(bodyinclude, nameof(bodyinclude), required: false);
            return new DeferredBodyAction<UserRequestResponse>(() =>
            {
                var apiCallPath = "/user/email";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["email"] = ExpressionConverter.ConvertO(bodyemail);
                if (bodyinclude != null)
                {
                    body["include"] = ExpressionConverter.ConvertO(bodyinclude);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UserRequestResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicsignal")]
        public IBodyWorkflowAction<ManageUserTagsResponse> GetUserTags()
        {
            var apiCallPath = "/manage/usertags";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ManageUserTagsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicsignal")]
        public IBodyWorkflowAction<DivisionsResponse> GetDivisions()
        {
            var apiCallPath = "/divisions";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<DivisionsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicsignal")]
        [WorkflowExpressionFactory(nameof(__BuildPutDocument))]
        public IBodyWorkflowAction<DocumentInfoResponse> PutDocument([WorkflowExpression] Func<string> fileName, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> contentType, [WorkflowExpression] Func<string> file = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DocumentInfoResponse> __BuildPutDocument(WorkflowValue<string> fileName, WorkflowValue<string> id, WorkflowValue<string> contentType, WorkflowValue<string> file = null)
        {
            WorkflowValue.Validate(fileName, nameof(fileName), required: true);
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(contentType, nameof(contentType), required: true);
            WorkflowValue.Validate(file, nameof(file), required: false);
            return new DeferredBodyAction<DocumentInfoResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/post/{0}/documents", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["fileName"] = ExpressionConverter.Convert(fileName);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
                callPayload.Body = ExpressionConverter.ConvertO(file);
                return new ApiConnectionAction<DocumentInfoResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicsignal")]
        [WorkflowExpressionFactory(nameof(__BuildPreregisterUser))]
        public IBodyWorkflowAction<UserRequestResponse> PreregisterUser([WorkflowExpression] Func<string> bodyemail = null, [WorkflowExpression] Func<string> bodyexternalSsoUserID = null, [WorkflowExpression] Func<string> bodyhandle = null, [WorkflowExpression] Func<string> bodyfirstName = null, [WorkflowExpression] Func<string> bodylastName = null, [WorkflowExpression] Func<int[]> bodydivisionIDs = null, [WorkflowExpression] Func<int[]> bodytargetIDs = null, [WorkflowExpression] Func<UserTagRequestResponse[]> bodytags = null, [WorkflowExpression] Func<bool> bodysendInvitationEmail = null, [WorkflowExpression] Func<string> bodyinvitationMessage = null, [WorkflowExpression] Func<bodynotificationsDefaultInput> bodynotificationsDefault = null, [WorkflowExpression] Func<bool> bodyvaluecanSharePosts = null, [WorkflowExpression] Func<bool> bodyvaluecanCommentPosts = null, [WorkflowExpression] Func<bool> bodyvaluecanSubmitPosts = null, [WorkflowExpression] Func<bool> bodyvaluecanManageOrganization = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UserRequestResponse> __BuildPreregisterUser(WorkflowValue<string> bodyemail = null, WorkflowValue<string> bodyexternalSsoUserID = null, WorkflowValue<string> bodyhandle = null, WorkflowValue<string> bodyfirstName = null, WorkflowValue<string> bodylastName = null, WorkflowValue<int[]> bodydivisionIDs = null, WorkflowValue<int[]> bodytargetIDs = null, WorkflowValue<UserTagRequestResponse[]> bodytags = null, WorkflowValue<bool> bodysendInvitationEmail = null, WorkflowValue<string> bodyinvitationMessage = null, WorkflowValue<bodynotificationsDefaultInput> bodynotificationsDefault = null, WorkflowValue<bool> bodyvaluecanSharePosts = null, WorkflowValue<bool> bodyvaluecanCommentPosts = null, WorkflowValue<bool> bodyvaluecanSubmitPosts = null, WorkflowValue<bool> bodyvaluecanManageOrganization = null)
        {
            WorkflowValue.Validate(bodyemail, nameof(bodyemail), required: false);
            WorkflowValue.Validate(bodyexternalSsoUserID, nameof(bodyexternalSsoUserID), required: false);
            WorkflowValue.Validate(bodyhandle, nameof(bodyhandle), required: false);
            WorkflowValue.Validate(bodyfirstName, nameof(bodyfirstName), required: false);
            WorkflowValue.Validate(bodylastName, nameof(bodylastName), required: false);
            WorkflowValue.Validate(bodydivisionIDs, nameof(bodydivisionIDs), required: false);
            WorkflowValue.Validate(bodytargetIDs, nameof(bodytargetIDs), required: false);
            WorkflowValue.Validate(bodytags, nameof(bodytags), required: false);
            WorkflowValue.Validate(bodysendInvitationEmail, nameof(bodysendInvitationEmail), required: false);
            WorkflowValue.Validate(bodyinvitationMessage, nameof(bodyinvitationMessage), required: false);
            WorkflowValue.Validate(bodynotificationsDefault, nameof(bodynotificationsDefault), required: false);
            WorkflowValue.Validate(bodyvaluecanSharePosts, nameof(bodyvaluecanSharePosts), required: false);
            WorkflowValue.Validate(bodyvaluecanCommentPosts, nameof(bodyvaluecanCommentPosts), required: false);
            WorkflowValue.Validate(bodyvaluecanSubmitPosts, nameof(bodyvaluecanSubmitPosts), required: false);
            WorkflowValue.Validate(bodyvaluecanManageOrganization, nameof(bodyvaluecanManageOrganization), required: false);
            return new DeferredBodyAction<UserRequestResponse>(() =>
            {
                var apiCallPath = "/manage/preregister";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyemail != null)
                {
                    body["email"] = ExpressionConverter.ConvertO(bodyemail);
                    bodypropCount++;
                }

                if (bodyexternalSsoUserID != null)
                {
                    body["externalSsoUserId"] = ExpressionConverter.ConvertO(bodyexternalSsoUserID);
                    bodypropCount++;
                }

                if (bodyhandle != null)
                {
                    body["handle"] = ExpressionConverter.ConvertO(bodyhandle);
                    bodypropCount++;
                }

                if (bodyfirstName != null)
                {
                    body["firstName"] = ExpressionConverter.ConvertO(bodyfirstName);
                    bodypropCount++;
                }

                if (bodylastName != null)
                {
                    body["lastName"] = ExpressionConverter.ConvertO(bodylastName);
                    bodypropCount++;
                }

                if (bodydivisionIDs != null)
                {
                    body["divisionIds"] = ExpressionConverter.ConvertO(bodydivisionIDs);
                    bodypropCount++;
                }

                if (bodytargetIDs != null)
                {
                    body["targetIds"] = ExpressionConverter.ConvertO(bodytargetIDs);
                    bodypropCount++;
                }

                if (bodytags != null)
                {
                    body["tags"] = ExpressionConverter.ConvertO(bodytags);
                    bodypropCount++;
                }

                if (bodysendInvitationEmail != null)
                {
                    body["sendInvitationEmail"] = ExpressionConverter.ConvertO(bodysendInvitationEmail);
                    bodypropCount++;
                }

                if (bodyinvitationMessage != null)
                {
                    body["invitationMessage"] = ExpressionConverter.ConvertO(bodyinvitationMessage);
                    bodypropCount++;
                }

                if (bodynotificationsDefault != null)
                {
                    body["notificationsDefault"] = ExpressionConverter.ConvertO(bodynotificationsDefault);
                    bodypropCount++;
                }

                var privilegesObject = new JObject();
                var privilegesObjectpropCount = 0;
                if (bodyvaluecanSharePosts != null)
                {
                    privilegesObject["canSharePosts"] = ExpressionConverter.ConvertO(bodyvaluecanSharePosts);
                    privilegesObjectpropCount++;
                }

                if (bodyvaluecanCommentPosts != null)
                {
                    privilegesObject["canCommentPosts"] = ExpressionConverter.ConvertO(bodyvaluecanCommentPosts);
                    privilegesObjectpropCount++;
                }

                if (bodyvaluecanSubmitPosts != null)
                {
                    privilegesObject["canSubmitPosts"] = ExpressionConverter.ConvertO(bodyvaluecanSubmitPosts);
                    privilegesObjectpropCount++;
                }

                if (bodyvaluecanManageOrganization != null)
                {
                    privilegesObject["canManageOrganization"] = ExpressionConverter.ConvertO(bodyvaluecanManageOrganization);
                    privilegesObjectpropCount++;
                }

                if (privilegesObjectpropCount > 0)
                {
                    body["privileges"] = privilegesObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UserRequestResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicsignal")]
        [WorkflowExpressionFactory(nameof(__BuildManageImage))]
        public IBodyWorkflowAction<UploadImageResponse> ManageImage([WorkflowExpression] Func<string> contentType, [WorkflowExpression] Func<string> file = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UploadImageResponse> __BuildManageImage(WorkflowValue<string> contentType, WorkflowValue<string> file = null)
        {
            WorkflowValue.Validate(contentType, nameof(contentType), required: true);
            WorkflowValue.Validate(file, nameof(file), required: false);
            return new DeferredBodyAction<UploadImageResponse>(() =>
            {
                var apiCallPath = "/manage/images";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
                callPayload.Body = ExpressionConverter.ConvertO(file);
                return new ApiConnectionAction<UploadImageResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicsignal")]
        [WorkflowExpressionFactory(nameof(__BuildGet))]
        public IBodyWorkflowAction<PostResponse> Get([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<int> userId = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PostResponse> __BuildGet(WorkflowValue<string> id, WorkflowValue<int> userId = null)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(userId, nameof(userId), required: false);
            return new DeferredBodyAction<PostResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/post/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (userId != null)
                    callPayload.Queries["userId"] = ExpressionConverter.Convert(userId);
                return new ApiConnectionAction<PostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicsignal")]
        [WorkflowExpressionFactory(nameof(__BuildCreate))]
        public IBodyWorkflowAction<PostResponse> Create([WorkflowExpression] Func<string> bodytitle, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodytagLine = null, [WorkflowExpression] Func<string> bodycontent = null, [WorkflowExpression] Func<string> bodycreatorComments = null, [WorkflowExpression] Func<string> bodypermaLink = null, [WorkflowExpression] Func<bool> bodyinternalDiscussionsEnabled = null, [WorkflowExpression] Func<string> bodymemberVideoUrl = null, [WorkflowExpression] Func<bodypostTypeInput> bodypostType = null, [WorkflowExpression] Func<bodyapprovalStateInput> bodyapprovalState = null, [WorkflowExpression] Func<bodydisplayModeInput> bodydisplayMode = null, [WorkflowExpression] Func<bool> bodysharable = null, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodyendDate = null, [WorkflowExpression] Func<string> bodysuggestedShareText = null, [WorkflowExpression] Func<string> bodyshortSuggestedShareText = null, [WorkflowExpression] Func<int> bodysharePoints = null, [WorkflowExpression] Func<int> bodyclickPoints = null, [WorkflowExpression] Func<bool> bodyshareWithImages = null, [WorkflowExpression] Func<bool> bodyshareImagesOnly = null, [WorkflowExpression] Func<PostTagRequestResponse[]> bodytags = null, [WorkflowExpression] Func<string> bodylanguage = null, [WorkflowExpression] Func<string[]> bodydocuments = null, [WorkflowExpression] Func<int> bodycreatorID = null, [WorkflowExpression] Func<bool> bodydisplayCreator = null, [WorkflowExpression] Func<int[]> bodycategoryIDs = null, [WorkflowExpression] Func<int[]> bodytargetIDs = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PostResponse> __BuildCreate(WorkflowValue<string> bodytitle, WorkflowValue<string> bodydescription = null, WorkflowValue<string> bodytagLine = null, WorkflowValue<string> bodycontent = null, WorkflowValue<string> bodycreatorComments = null, WorkflowValue<string> bodypermaLink = null, WorkflowValue<bool> bodyinternalDiscussionsEnabled = null, WorkflowValue<string> bodymemberVideoUrl = null, WorkflowValue<bodypostTypeInput> bodypostType = null, WorkflowValue<bodyapprovalStateInput> bodyapprovalState = null, WorkflowValue<bodydisplayModeInput> bodydisplayMode = null, WorkflowValue<bool> bodysharable = null, WorkflowValue<string> bodystartDate = null, WorkflowValue<string> bodyendDate = null, WorkflowValue<string> bodysuggestedShareText = null, WorkflowValue<string> bodyshortSuggestedShareText = null, WorkflowValue<int> bodysharePoints = null, WorkflowValue<int> bodyclickPoints = null, WorkflowValue<bool> bodyshareWithImages = null, WorkflowValue<bool> bodyshareImagesOnly = null, WorkflowValue<PostTagRequestResponse[]> bodytags = null, WorkflowValue<string> bodylanguage = null, WorkflowValue<string[]> bodydocuments = null, WorkflowValue<int> bodycreatorID = null, WorkflowValue<bool> bodydisplayCreator = null, WorkflowValue<int[]> bodycategoryIDs = null, WorkflowValue<int[]> bodytargetIDs = null)
        {
            WorkflowValue.Validate(bodytitle, nameof(bodytitle), required: true);
            WorkflowValue.Validate(bodydescription, nameof(bodydescription), required: false);
            WorkflowValue.Validate(bodytagLine, nameof(bodytagLine), required: false);
            WorkflowValue.Validate(bodycontent, nameof(bodycontent), required: false);
            WorkflowValue.Validate(bodycreatorComments, nameof(bodycreatorComments), required: false);
            WorkflowValue.Validate(bodypermaLink, nameof(bodypermaLink), required: false);
            WorkflowValue.Validate(bodyinternalDiscussionsEnabled, nameof(bodyinternalDiscussionsEnabled), required: false);
            WorkflowValue.Validate(bodymemberVideoUrl, nameof(bodymemberVideoUrl), required: false);
            WorkflowValue.Validate(bodypostType, nameof(bodypostType), required: false);
            WorkflowValue.Validate(bodyapprovalState, nameof(bodyapprovalState), required: false);
            WorkflowValue.Validate(bodydisplayMode, nameof(bodydisplayMode), required: false);
            WorkflowValue.Validate(bodysharable, nameof(bodysharable), required: false);
            WorkflowValue.Validate(bodystartDate, nameof(bodystartDate), required: false);
            WorkflowValue.Validate(bodyendDate, nameof(bodyendDate), required: false);
            WorkflowValue.Validate(bodysuggestedShareText, nameof(bodysuggestedShareText), required: false);
            WorkflowValue.Validate(bodyshortSuggestedShareText, nameof(bodyshortSuggestedShareText), required: false);
            WorkflowValue.Validate(bodysharePoints, nameof(bodysharePoints), required: false);
            WorkflowValue.Validate(bodyclickPoints, nameof(bodyclickPoints), required: false);
            WorkflowValue.Validate(bodyshareWithImages, nameof(bodyshareWithImages), required: false);
            WorkflowValue.Validate(bodyshareImagesOnly, nameof(bodyshareImagesOnly), required: false);
            WorkflowValue.Validate(bodytags, nameof(bodytags), required: false);
            WorkflowValue.Validate(bodylanguage, nameof(bodylanguage), required: false);
            WorkflowValue.Validate(bodydocuments, nameof(bodydocuments), required: false);
            WorkflowValue.Validate(bodycreatorID, nameof(bodycreatorID), required: false);
            WorkflowValue.Validate(bodydisplayCreator, nameof(bodydisplayCreator), required: false);
            WorkflowValue.Validate(bodycategoryIDs, nameof(bodycategoryIDs), required: false);
            WorkflowValue.Validate(bodytargetIDs, nameof(bodytargetIDs), required: false);
            return new DeferredBodyAction<PostResponse>(() =>
            {
                var apiCallPath = "/post";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(bodydescription);
                    bodypropCount++;
                }

                if (bodytagLine != null)
                {
                    body["tagLine"] = ExpressionConverter.ConvertO(bodytagLine);
                    bodypropCount++;
                }

                if (bodycontent != null)
                {
                    body["content"] = ExpressionConverter.ConvertO(bodycontent);
                    bodypropCount++;
                }

                if (bodycreatorComments != null)
                {
                    body["creatorComments"] = ExpressionConverter.ConvertO(bodycreatorComments);
                    bodypropCount++;
                }

                if (bodypermaLink != null)
                {
                    body["permaLink"] = ExpressionConverter.ConvertO(bodypermaLink);
                    bodypropCount++;
                }

                if (bodyinternalDiscussionsEnabled != null)
                {
                    body["internalDiscussionsEnabled"] = ExpressionConverter.ConvertO(bodyinternalDiscussionsEnabled);
                    bodypropCount++;
                }

                bodypropCount++;
                body["title"] = ExpressionConverter.ConvertO(bodytitle);
                if (bodymemberVideoUrl != null)
                {
                    body["memberVideoUrl"] = ExpressionConverter.ConvertO(bodymemberVideoUrl);
                    bodypropCount++;
                }

                if (bodypostType != null)
                {
                    body["postType"] = ExpressionConverter.ConvertO(bodypostType);
                    bodypropCount++;
                }

                if (bodyapprovalState != null)
                {
                    body["approvalState"] = ExpressionConverter.ConvertO(bodyapprovalState);
                    bodypropCount++;
                }

                if (bodydisplayMode != null)
                {
                    body["displayMode"] = ExpressionConverter.ConvertO(bodydisplayMode);
                    bodypropCount++;
                }

                if (bodysharable != null)
                {
                    body["sharable"] = ExpressionConverter.ConvertO(bodysharable);
                    bodypropCount++;
                }

                if (bodystartDate != null)
                {
                    body["startDate"] = ExpressionConverter.ConvertO(bodystartDate);
                    bodypropCount++;
                }

                if (bodyendDate != null)
                {
                    body["endDate"] = ExpressionConverter.ConvertO(bodyendDate);
                    bodypropCount++;
                }

                if (bodysuggestedShareText != null)
                {
                    body["suggestedShareText"] = ExpressionConverter.ConvertO(bodysuggestedShareText);
                    bodypropCount++;
                }

                if (bodyshortSuggestedShareText != null)
                {
                    body["shortSuggestedShareText"] = ExpressionConverter.ConvertO(bodyshortSuggestedShareText);
                    bodypropCount++;
                }

                if (bodysharePoints != null)
                {
                    body["sharePoints"] = ExpressionConverter.ConvertO(bodysharePoints);
                    bodypropCount++;
                }

                if (bodyclickPoints != null)
                {
                    body["clickPoints"] = ExpressionConverter.ConvertO(bodyclickPoints);
                    bodypropCount++;
                }

                if (bodyshareWithImages != null)
                {
                    body["shareWithImages"] = ExpressionConverter.ConvertO(bodyshareWithImages);
                    bodypropCount++;
                }

                if (bodyshareImagesOnly != null)
                {
                    body["shareImagesOnly"] = ExpressionConverter.ConvertO(bodyshareImagesOnly);
                    bodypropCount++;
                }

                if (bodytags != null)
                {
                    body["tags"] = ExpressionConverter.ConvertO(bodytags);
                    bodypropCount++;
                }

                if (bodylanguage != null)
                {
                    body["language"] = ExpressionConverter.ConvertO(bodylanguage);
                    bodypropCount++;
                }

                if (bodydocuments != null)
                {
                    body["documents"] = ExpressionConverter.ConvertO(bodydocuments);
                    bodypropCount++;
                }

                if (bodycreatorID != null)
                {
                    body["creatorId"] = ExpressionConverter.ConvertO(bodycreatorID);
                    bodypropCount++;
                }

                if (bodydisplayCreator != null)
                {
                    body["displayCreator"] = ExpressionConverter.ConvertO(bodydisplayCreator);
                    bodypropCount++;
                }

                if (bodycategoryIDs != null)
                {
                    body["categoryIds"] = ExpressionConverter.ConvertO(bodycategoryIDs);
                    bodypropCount++;
                }

                if (bodytargetIDs != null)
                {
                    body["targetIds"] = ExpressionConverter.ConvertO(bodytargetIDs);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicsignal")]
        [WorkflowExpressionFactory(nameof(__BuildPutImageTo))]
        public IBodyWorkflowAction<SuccessResponse> PutImageTo([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> contentType, [WorkflowExpression] Func<string> file = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SuccessResponse> __BuildPutImageTo(WorkflowValue<string> id, WorkflowValue<string> contentType, WorkflowValue<string> file = null)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(contentType, nameof(contentType), required: true);
            WorkflowValue.Validate(file, nameof(file), required: false);
            return new DeferredBodyAction<SuccessResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/post/{0}/image", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
                callPayload.Body = ExpressionConverter.ConvertO(file);
                return new ApiConnectionAction<SuccessResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicsignal")]
        [WorkflowExpressionFactory(nameof(__BuildAddImageTo))]
        public IBodyWorkflowAction<SuccessResponse> AddImageTo([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyurl)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SuccessResponse> __BuildAddImageTo(WorkflowValue<string> id, WorkflowValue<string> bodyurl)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(bodyurl, nameof(bodyurl), required: true);
            return new DeferredBodyAction<SuccessResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/post/{0}/imageurl", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = ExpressionConverter.ConvertO(bodyurl);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SuccessResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicsignal")]
        [WorkflowExpressionFactory(nameof(__BuildUpdate))]
        public IBodyWorkflowAction<PostResponse> Update([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodytagLine = null, [WorkflowExpression] Func<string> bodycontent = null, [WorkflowExpression] Func<string> bodycreatorComments = null, [WorkflowExpression] Func<string> bodypermaLink = null, [WorkflowExpression] Func<bool> bodyinternalDiscussionsEnabled = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PostResponse> __BuildUpdate(WorkflowValue<string> id, WorkflowValue<string> bodytitle = null, WorkflowValue<string> bodydescription = null, WorkflowValue<string> bodytagLine = null, WorkflowValue<string> bodycontent = null, WorkflowValue<string> bodycreatorComments = null, WorkflowValue<string> bodypermaLink = null, WorkflowValue<bool> bodyinternalDiscussionsEnabled = null)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(bodytitle, nameof(bodytitle), required: false);
            WorkflowValue.Validate(bodydescription, nameof(bodydescription), required: false);
            WorkflowValue.Validate(bodytagLine, nameof(bodytagLine), required: false);
            WorkflowValue.Validate(bodycontent, nameof(bodycontent), required: false);
            WorkflowValue.Validate(bodycreatorComments, nameof(bodycreatorComments), required: false);
            WorkflowValue.Validate(bodypermaLink, nameof(bodypermaLink), required: false);
            WorkflowValue.Validate(bodyinternalDiscussionsEnabled, nameof(bodyinternalDiscussionsEnabled), required: false);
            return new DeferredBodyAction<PostResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/manage/post/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(bodytitle);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(bodydescription);
                    bodypropCount++;
                }

                if (bodytagLine != null)
                {
                    body["tagLine"] = ExpressionConverter.ConvertO(bodytagLine);
                    bodypropCount++;
                }

                if (bodycontent != null)
                {
                    body["content"] = ExpressionConverter.ConvertO(bodycontent);
                    bodypropCount++;
                }

                if (bodycreatorComments != null)
                {
                    body["creatorComments"] = ExpressionConverter.ConvertO(bodycreatorComments);
                    bodypropCount++;
                }

                if (bodypermaLink != null)
                {
                    body["permaLink"] = ExpressionConverter.ConvertO(bodypermaLink);
                    bodypropCount++;
                }

                if (bodyinternalDiscussionsEnabled != null)
                {
                    body["internalDiscussionsEnabled"] = ExpressionConverter.ConvertO(bodyinternalDiscussionsEnabled);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicsignal")]
        public IBodyWorkflowAction<ManagePostTagsResponse> GetPostTags()
        {
            var apiCallPath = "/manage/posttags";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ManagePostTagsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicsignal")]
        public IBodyWorkflowAction<CategoriesResponse> GetCategories()
        {
            var apiCallPath = "/categories";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<CategoriesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicsignal")]
        public IBodyWorkflowAction<TargetDefinitionsInfoResponse> GetTargets()
        {
            var apiCallPath = "/targets";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TargetDefinitionsInfoResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicsignal")]
        [WorkflowExpressionFactory(nameof(__BuildManagePosts))]
        public IBodyWorkflowAction<SuccessResponse> ManagePosts([WorkflowExpression] Func<string[]> bodypostIDs, [WorkflowExpression] Func<string[]> bodytags = null, [WorkflowExpression] Func<int[]> bodydivisionIDs = null, [WorkflowExpression] Func<int[]> bodycategoryIDs = null, [WorkflowExpression] Func<int[]> bodytargetIDs = null, [WorkflowExpression] Func<bodyapprovalStateInput> bodyapprovalState = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SuccessResponse> __BuildManagePosts(WorkflowValue<string[]> bodypostIDs, WorkflowValue<string[]> bodytags = null, WorkflowValue<int[]> bodydivisionIDs = null, WorkflowValue<int[]> bodycategoryIDs = null, WorkflowValue<int[]> bodytargetIDs = null, WorkflowValue<bodyapprovalStateInput> bodyapprovalState = null)
        {
            WorkflowValue.Validate(bodypostIDs, nameof(bodypostIDs), required: true);
            WorkflowValue.Validate(bodytags, nameof(bodytags), required: false);
            WorkflowValue.Validate(bodydivisionIDs, nameof(bodydivisionIDs), required: false);
            WorkflowValue.Validate(bodycategoryIDs, nameof(bodycategoryIDs), required: false);
            WorkflowValue.Validate(bodytargetIDs, nameof(bodytargetIDs), required: false);
            WorkflowValue.Validate(bodyapprovalState, nameof(bodyapprovalState), required: false);
            return new DeferredBodyAction<SuccessResponse>(() =>
            {
                var apiCallPath = "/manage/posts";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["postIds"] = ExpressionConverter.ConvertO(bodypostIDs);
                if (bodytags != null)
                {
                    body["tags"] = ExpressionConverter.ConvertO(bodytags);
                    bodypropCount++;
                }

                if (bodydivisionIDs != null)
                {
                    body["divisionIds"] = ExpressionConverter.ConvertO(bodydivisionIDs);
                    bodypropCount++;
                }

                if (bodycategoryIDs != null)
                {
                    body["categoryIds"] = ExpressionConverter.ConvertO(bodycategoryIDs);
                    bodypropCount++;
                }

                if (bodytargetIDs != null)
                {
                    body["targetIds"] = ExpressionConverter.ConvertO(bodytargetIDs);
                    bodypropCount++;
                }

                if (bodyapprovalState != null)
                {
                    body["approvalState"] = ExpressionConverter.ConvertO(bodyapprovalState);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SuccessResponse>(callPayload);
            });
        }
    }

    public class DynamicsignalTriggers([ConnectionName] string connectionId)
    {
    }

    public class UserRequestResponse
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("handle")]
        public string Handle { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("displayNameFormat")]
        public UserRequestResponseDisplayNameFormatType DisplayNameFormat { get; set; }

        [JsonProperty("status")]
        public UserRequestResponseStatusType Status { get; set; }

        [JsonProperty("profileCompleted")]
        public bool ProfileCompleted { get; set; }

        [JsonProperty("lastActivityDate")]
        public string LastActivityDate { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("externalApiUserId")]
        public string ExternalApiUserID { get; set; }

        [JsonProperty("managerUserId")]
        public int ManagerUserID { get; set; }

        [JsonProperty("timeZone")]
        public string TimeZone { get; set; }

        [JsonProperty("selectedTimeZone")]
        public string SelectedTimeZone { get; set; }

        [JsonProperty("pointBalance")]
        public int PointBalance { get; set; }

        [JsonProperty("unredeemedPoints")]
        public int UnredeemedPoints { get; set; }

        [JsonProperty("redeemedPoints")]
        public int RedeemedPoints { get; set; }

        [JsonProperty("apiInfo")]
        public string ApiInfo { get; set; }

        [JsonProperty("hasPassword")]
        public bool HasPassword { get; set; }

        [JsonProperty("mustChangePassword")]
        public bool MustChangePassword { get; set; }

        [JsonProperty("isAccountVerified")]
        public bool IsAccountVerified { get; set; }

        [JsonProperty("statistics")]
        public PostStatisticsResponse Statistics { get; set; }

        [JsonProperty("tags")]
        public JToken Tags { get; set; }

        [JsonProperty("badges")]
        public JToken Badges { get; set; }

        [JsonProperty("affiliations")]
        public UserAffiliationResponse[] Affiliations { get; set; }

        [JsonProperty("divisions")]
        public DivisionResponse[] Divisions { get; set; }

        [JsonProperty("channels")]
        public UserChannelResponse[] Channels { get; set; }

        [JsonProperty("profilePictureImages")]
        public JToken ProfilePictureImages { get; set; }

        [JsonProperty("languages")]
        public string[] Languages { get; set; }

        [JsonProperty("primaryLanguage")]
        public string PrimaryLanguage { get; set; }

        [JsonProperty("scheduleSettings")]
        public UserScheduleSettingsResponse ScheduleSettings { get; set; }

        [JsonProperty("isSso")]
        public bool IsSso { get; set; }

        [JsonProperty("permissions")]
        public UserPermissionsResponse Permissions { get; set; }

        [JsonProperty("privileges")]
        public UserPrivilegesResponse Privileges { get; set; }

        [JsonProperty("identifiers")]
        public AllowlistIdentifiersResponse[] Identifiers { get; set; }

        [JsonProperty("targets")]
        public TargetOverviewResponse[] Targets { get; set; }

        [JsonProperty("defaults")]
        public UserDefaultsRequestResponse Defaults { get; set; }

        [JsonProperty("welcomeBannerDismissed")]
        public bool WelcomeBannerDismissed { get; set; }
    }

    public enum UserRequestResponseDisplayNameFormatType
    {
        Full,
        Short
    }

    public enum UserRequestResponseStatusType
    {
        New,
        Active,
        Archived,
        Suspended,
        Preregistered,
        PendingApproval,
        Rejected
    }

    public class PostStatisticsResponse
    {
        [JsonProperty("totalInAppShareCount")]
        public int TotalInAppShareCount { get; set; }

        [JsonProperty("trackingId")]
        public string TrackingID { get; set; }

        [JsonProperty("shareCount")]
        public int ShareCount { get; set; }

        [JsonProperty("reactionCount")]
        public int ReactionCount { get; set; }

        [JsonProperty("impressionCount")]
        public int ImpressionCount { get; set; }

        [JsonProperty("viewedCount")]
        public int ViewedCount { get; set; }

        [JsonProperty("clickCount")]
        public int ClickCount { get; set; }

        [JsonProperty("likeCount")]
        public int LikeCount { get; set; }

        [JsonProperty("commentCount")]
        public int CommentCount { get; set; }

        [JsonProperty("commentLikeCount")]
        public int CommentLikeCount { get; set; }
    }

    public class UserAffiliationResponse
    {
        [JsonProperty("question")]
        public AffiliationQuestionResponse Question { get; set; }

        [JsonProperty("answer")]
        public AffiliationAnswerResponse Answer { get; set; }
    }

    public class AffiliationQuestionResponse
    {
        [JsonProperty("questionId")]
        public int QuestionID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("scorePosition")]
        public int ScorePosition { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("questionType")]
        public AffiliationQuestionResponseQuestionTypeType QuestionType { get; set; }

        [JsonProperty("required")]
        public bool Required { get; set; }

        [JsonProperty("isPubliclyVisible")]
        public bool IsPubliclyVisible { get; set; }
    }

    public enum AffiliationQuestionResponseQuestionTypeType
    {
        SingleAnswer,
        MultipleAnswer,
        FreeText
    }

    public class AffiliationAnswerResponse
    {
        [JsonProperty("answerId")]
        public int AnswerID { get; set; }

        [JsonProperty("answer")]
        public string Answer { get; set; }

        [JsonProperty("score")]
        public double Score { get; set; }

        [JsonProperty("freeText")]
        public string FreeText { get; set; }

        [JsonProperty("declineToAnswer")]
        public bool DeclineToAnswer { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }
    }

    public class DivisionResponse
    {
        [JsonProperty("divisionId")]
        public int DivisionID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("parentDivisionId")]
        public int ParentDivisionID { get; set; }
    }

    public class UserChannelResponse
    {
        [JsonProperty("userChannelId")]
        public int UserChannelID { get; set; }

        [JsonProperty("userId")]
        public int UserID { get; set; }

        [JsonProperty("provider")]
        public UserChannelResponseProviderType Provider { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("providerUserId")]
        public string ProviderUserID { get; set; }

        [JsonProperty("status")]
        public UserChannelResponseStatusType Status { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("friends")]
        public int Friends { get; set; }

        [JsonProperty("followers")]
        public int Followers { get; set; }

        [JsonProperty("following")]
        public int Following { get; set; }

        [JsonProperty("posts")]
        public int Posts { get; set; }

        [JsonProperty("views")]
        public int Views { get; set; }

        [JsonProperty("pointBalance")]
        public int PointBalance { get; set; }

        [JsonProperty("sourceDisplayName")]
        public string SourceDisplayName { get; set; }

        [JsonProperty("reach")]
        public int Reach { get; set; }

        [JsonProperty("sharable")]
        public bool Sharable { get; set; }

        [JsonProperty("sharingDefault")]
        public bool SharingDefault { get; set; }

        [JsonProperty("authRequired")]
        public bool AuthRequired { get; set; }

        [JsonProperty("statistics")]
        public PostStatisticsResponse Statistics { get; set; }

        [JsonProperty("profilePictureImages")]
        public JToken ProfilePictureImages { get; set; }
    }

    public enum UserChannelResponseProviderType
    {
        None,
        Twitter,
        Blog,
        Facebook,
        Yelp,
        Flickr,
        Foursquare,
        SMS,
        WordPress,
        TypePad,
        LiveJournal,
        Blogger,
        FacebookPage,
        GenericUrl,
        YouTube,
        SyndicatedUrl,
        Email,
        Tumblr,
        GooglePlus,
        SquareSpace,
        LinkedIn,
        Posterous,
        Joomla,
        Drupal,
        MovableType,
        Reddit,
        VK,
        Picasa,
        Vimeo,
        Instagram,
        Sonico,
        Odnoklassniki,
        GetGlue,
        LastFM,
        BazaarVoice,
        LinkedInGroup,
        Chatter,
        Weibo,
        Tencent,
        Pinterest,
        LinkedInPage,
        CutAndPaste,
        Bitly,
        Jive,
        GoogleContact,
        Office365,
        JivePlace,
        Xing,
        SapJam,
        SalesforceSocialStudio,
        Slack,
        Yammer,
        SmartContent,
        CiscoSpark,
        FacebookWorkplace,
        InstagramBusiness,
        FacebookNative
    }

    public enum UserChannelResponseStatusType
    {
        Active,
        Archived,
        AuthRequired
    }

    public class UserScheduleSettingsResponse
    {
        [JsonProperty("days")]
        public UserScheduleSettingsResponseDaysType Days { get; set; }

        [JsonProperty("times")]
        public string[] Times { get; set; }
    }

    public enum UserScheduleSettingsResponseDaysType
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    public class UserPermissionsResponse
    {
        [JsonProperty("viewBroadcast")]
        public bool ViewBroadcast { get; set; }

        [JsonProperty("listBroadcast")]
        public bool ListBroadcast { get; set; }

        [JsonProperty("editBroadcast")]
        public bool EditBroadcast { get; set; }

        [JsonProperty("viewBroadcastStats")]
        public bool ViewBroadcastStats { get; set; }

        [JsonProperty("viewPost")]
        public bool ViewPost { get; set; }

        [JsonProperty("listPost")]
        public bool ListPost { get; set; }

        [JsonProperty("editPost")]
        public bool EditPost { get; set; }

        [JsonProperty("viewPostStats")]
        public bool ViewPostStats { get; set; }

        [JsonProperty("viewSurvey")]
        public bool ViewSurvey { get; set; }

        [JsonProperty("listSurvey")]
        public bool ListSurvey { get; set; }

        [JsonProperty("editSurvey")]
        public bool EditSurvey { get; set; }

        [JsonProperty("communitySettings")]
        public bool CommunitySettings { get; set; }
    }

    public class UserPrivilegesResponse
    {
        [JsonProperty("canSubmitPosts")]
        public bool CanSubmitPosts { get; set; }

        [JsonProperty("canSharePosts")]
        public bool CanSharePosts { get; set; }

        [JsonProperty("canCommentPosts")]
        public bool CanCommentPosts { get; set; }

        [JsonProperty("canManageCommunity")]
        public bool CanManageCommunity { get; set; }

        [JsonProperty("canManageOrganization")]
        public bool CanManageOrganization { get; set; }

        [JsonProperty("canSetPostShareable")]
        public bool CanSetPostShareable { get; set; }
    }

    public class AllowlistIdentifiersResponse
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class TargetOverviewResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("definitionId")]
        public int DefinitionID { get; set; }
    }

    public class UserDefaultsRequestResponse
    {
        [JsonProperty("defaultPostState")]
        public UserDefaultsRequestResponseDefaultPostStateType DefaultPostState { get; set; }

        [JsonProperty("defaultPostApprovalState")]
        public UserDefaultsRequestResponseDefaultPostApprovalStateType DefaultPostApprovalState { get; set; }

        [JsonProperty("defaultPostShowInternalDiscussions")]
        public bool DefaultPostShowInternalDiscussions { get; set; }

        [JsonProperty("defaultPostShowCreatorInfo")]
        public bool DefaultPostShowCreatorInfo { get; set; }
    }

    public enum UserDefaultsRequestResponseDefaultPostStateType
    {
        Shareable,
        NonShareable
    }

    public enum UserDefaultsRequestResponseDefaultPostApprovalStateType
    {
        Pending,
        Published,
        Excluded
    }

    public class ManageUserTagsResponse
    {
        [JsonProperty("tags")]
        public ManageUserTagResponse[] Tags { get; set; }
    }

    public class ManageUserTagResponse
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public ManageUserTagResponseTypeType Type { get; set; }

        [JsonProperty("acceptedValues")]
        public string[] AcceptedValues { get; set; }
    }

    public enum ManageUserTagResponseTypeType
    {
        Tag,
        Attribute
    }

    public class DivisionsResponse
    {
        [JsonProperty("divisions")]
        public DivisionResponse[] Divisions { get; set; }

        [JsonProperty("prompt")]
        public string Prompt { get; set; }

        [JsonProperty("showUserDivisionSelection")]
        public bool ShowUserDivisionSelection { get; set; }

        [JsonProperty("showUserDivisionSelectionDuringOnboarding")]
        public bool ShowUserDivisionSelectionDuringOnboarding { get; set; }

        [JsonProperty("requireUserDivisionSelection")]
        public bool RequireUserDivisionSelection { get; set; }

        [JsonProperty("allowMultipleDivisions")]
        public bool AllowMultipleDivisions { get; set; }
    }

    public class DocumentInfoResponse
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("mimeType")]
        public string MimeType { get; set; }
    }

    public class UserTagRequestResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public enum bodynotificationsDefaultInput
    {
        Immediately,
        AfterFirstLogin
    }

    public class UploadImageResponse
    {
        [JsonProperty("imageIdentifier")]
        public string ImageIdentifier { get; set; }
    }

    public class PostResponse
    {
        [JsonProperty("postId")]
        public string PostID { get; set; }

        [JsonProperty("postSourceId")]
        public int PostSourceID { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("tagLine")]
        public string TagLine { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("rawContent")]
        public string RawContent { get; set; }

        [JsonProperty("creatorComments")]
        public string CreatorComments { get; set; }

        [JsonProperty("creatorInfo")]
        public UserOverviewResponse CreatorInfo { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("permaLink")]
        public string PermaLink { get; set; }

        [JsonProperty("cleanPermaLink")]
        public string CleanPermaLink { get; set; }

        [JsonProperty("postType")]
        public PostResponsePostTypeType PostType { get; set; }

        [JsonProperty("postSourceType")]
        public PostResponsePostSourceTypeType PostSourceType { get; set; }

        [JsonProperty("postBylineType")]
        public PostResponsePostBylineTypeType PostBylineType { get; set; }

        [JsonProperty("provider")]
        public string Provider { get; set; }

        [JsonProperty("approvalState")]
        public PostResponseApprovalStateType ApprovalState { get; set; }

        [JsonProperty("displayMode")]
        public PostResponseDisplayModeType DisplayMode { get; set; }

        [JsonProperty("status")]
        public PostResponseStatusType Status { get; set; }

        [JsonProperty("userEditable")]
        public bool UserEditable { get; set; }

        [JsonProperty("userShareable")]
        public bool UserShareable { get; set; }

        [JsonProperty("userCommentable")]
        public bool UserCommentable { get; set; }

        [JsonProperty("sharable")]
        public bool Sharable { get; set; }

        [JsonProperty("broadcasted")]
        public bool Broadcasted { get; set; }

        [JsonProperty("pinned")]
        public bool Pinned { get; set; }

        [JsonProperty("publishDate")]
        public string PublishDate { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("eventStartDate")]
        public string EventStartDate { get; set; }

        [JsonProperty("eventEndDate")]
        public string EventEndDate { get; set; }

        [JsonProperty("providerTimeStamp")]
        public string ProviderTimeStamp { get; set; }

        [JsonProperty("receivedPublishPoints")]
        public bool ReceivedPublishPoints { get; set; }

        [JsonProperty("suggestedShareText")]
        public string SuggestedShareText { get; set; }

        [JsonProperty("shortSuggestedShareText")]
        public string ShortSuggestedShareText { get; set; }

        [JsonProperty("suggestedShareTextList")]
        public string[] SuggestedShareTextList { get; set; }

        [JsonProperty("shortSuggestedShareTextList")]
        public string[] ShortSuggestedShareTextList { get; set; }

        [JsonProperty("sharePoints")]
        public int SharePoints { get; set; }

        [JsonProperty("clickPoints")]
        public int ClickPoints { get; set; }

        [JsonProperty("providerPostId")]
        public string ProviderPostID { get; set; }

        [JsonProperty("urlSlug")]
        public string UrlSlug { get; set; }

        [JsonProperty("classification")]
        public string Classification { get; set; }

        [JsonProperty("shareWithImages")]
        public bool ShareWithImages { get; set; }

        [JsonProperty("shareImagesOnly")]
        public bool ShareImagesOnly { get; set; }

        [JsonProperty("actions")]
        public string Actions { get; set; }

        [JsonProperty("mentions")]
        public string Mentions { get; set; }

        [JsonProperty("statistics")]
        public PostStatisticsResponse Statistics { get; set; }

        [JsonProperty("userShareInfo")]
        public PostUserShareInfoResponse UserShareInfo { get; set; }

        [JsonProperty("author")]
        public PostAuthorRequestResponse Author { get; set; }

        [JsonProperty("links")]
        public PostLinkRequestResponse[] Links { get; set; }

        [JsonProperty("tags")]
        public PostTagRequestResponse[] Tags { get; set; }

        [JsonProperty("media")]
        public PostMediaRequestResponse[] Media { get; set; }

        [JsonProperty("images")]
        public JToken Images { get; set; }

        [JsonProperty("candidateImages")]
        public PostCandidateImageResponse[] CandidateImages { get; set; }

        [JsonProperty("visible")]
        public bool Visible { get; set; }

        [JsonProperty("shareDisclosures")]
        public PostShareDisclosureResponse[] ShareDisclosures { get; set; }

        [JsonProperty("shareCommentRules")]
        public PostShareCommentRulesResponse[] ShareCommentRules { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("userHidden")]
        public bool UserHidden { get; set; }

        [JsonProperty("isViewedByUser")]
        public bool IsViewedByUser { get; set; }

        [JsonProperty("isDiscussionViewedByUser")]
        public bool IsDiscussionViewedByUser { get; set; }

        [JsonProperty("isLikedByUser")]
        public bool IsLikedByUser { get; set; }

        [JsonProperty("isCommentedByUser")]
        public bool IsCommentedByUser { get; set; }

        [JsonProperty("isSharedByUser")]
        public bool IsSharedByUser { get; set; }

        [JsonProperty("targets")]
        public TargetOverviewResponse[] Targets { get; set; }

        [JsonProperty("categories")]
        public CategoryOverviewResponse[] Categories { get; set; }

        [JsonProperty("currentTime")]
        public string CurrentTime { get; set; }
    }

    public class UserOverviewResponse
    {
        [JsonProperty("userId")]
        public int UserID { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("profilePictureImages")]
        public JToken ProfilePictureImages { get; set; }

        [JsonProperty("isActive")]
        public bool IsActive { get; set; }
    }

    public enum PostResponsePostTypeType
    {
        Text,
        Video
    }

    public enum PostResponsePostSourceTypeType
    {
        Member,
        Manager,
        Brand
    }

    public enum PostResponsePostBylineTypeType
    {
        Author,
        Source,
        Hidden
    }

    public enum PostResponseApprovalStateType
    {
        Pending,
        Published,
        Excluded
    }

    public enum PostResponseDisplayModeType
    {
        DisplayInApp,
        OpenExternally
    }

    public enum PostResponseStatusType
    {
        Active,
        Archived
    }

    public class PostUserShareInfoResponse
    {
        [JsonProperty("pointsEarned")]
        public int PointsEarned { get; set; }

        [JsonProperty("shareCount")]
        public int ShareCount { get; set; }

        [JsonProperty("mostRecentShareDate")]
        public string MostRecentShareDate { get; set; }
    }

    public class PostAuthorRequestResponse
    {
        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("profileImageUrl")]
        public string ProfileImageUrl { get; set; }

        [JsonProperty("providerUserId")]
        public string ProviderUserID { get; set; }

        [JsonProperty("providerUserName")]
        public string ProviderUserName { get; set; }

        [JsonProperty("profileUrl")]
        public string ProfileUrl { get; set; }

        [JsonProperty("postSourceName")]
        public string PostSourceName { get; set; }

        [JsonProperty("postSourceSite")]
        public string PostSourceSite { get; set; }
    }

    public class PostLinkRequestResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("expandedUrl")]
        public string ExpandedUrl { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("faviconUrl")]
        public string FaviconUrl { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("modifiedDate")]
        public string ModifiedDate { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }
    }

    public class PostTagRequestResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class PostMediaRequestResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("mimeType")]
        public string MimeType { get; set; }

        [JsonProperty("html")]
        public string Html { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("origin")]
        public string Origin { get; set; }

        [JsonProperty("provider")]
        public string Provider { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("hasVideoUrl")]
        public bool HasVideoUrl { get; set; }
    }

    public class PostCandidateImageResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("mimeType")]
        public string MimeType { get; set; }

        [JsonProperty("sslUrl")]
        public string SslUrl { get; set; }
    }

    public class PostShareDisclosureResponse
    {
        [JsonProperty("provider")]
        public PostShareDisclosureResponseProviderType Provider { get; set; }

        [JsonProperty("providerDisplayName")]
        public string ProviderDisplayName { get; set; }

        [JsonProperty("shareDisclosureText")]
        public string ShareDisclosureText { get; set; }
    }

    public enum PostShareDisclosureResponseProviderType
    {
        None,
        Twitter,
        Blog,
        Facebook,
        Yelp,
        Flickr,
        Foursquare,
        SMS,
        WordPress,
        TypePad,
        LiveJournal,
        Blogger,
        FacebookPage,
        GenericUrl,
        YouTube,
        SyndicatedUrl,
        Email,
        Tumblr,
        GooglePlus,
        SquareSpace,
        LinkedIn,
        Posterous,
        Joomla,
        Drupal,
        MovableType,
        Reddit,
        VK,
        Picasa,
        Vimeo,
        Instagram,
        Sonico,
        Odnoklassniki,
        GetGlue,
        LastFM,
        BazaarVoice,
        LinkedInGroup,
        Chatter,
        Weibo,
        Tencent,
        Pinterest,
        LinkedInPage,
        CutAndPaste,
        Bitly,
        Jive,
        GoogleContact,
        Office365,
        JivePlace,
        Xing,
        SapJam,
        SalesforceSocialStudio,
        Slack,
        Yammer,
        SmartContent,
        CiscoSpark,
        FacebookWorkplace,
        InstagramBusiness,
        FacebookNative
    }

    public class PostShareCommentRulesResponse
    {
        [JsonProperty("provider")]
        public PostShareCommentRulesResponseProviderType Provider { get; set; }

        [JsonProperty("shareMaxCharacterLimit")]
        public int ShareMaxCharacterLimit { get; set; }
    }

    public enum PostShareCommentRulesResponseProviderType
    {
        None,
        Twitter,
        Blog,
        Facebook,
        Yelp,
        Flickr,
        Foursquare,
        SMS,
        WordPress,
        TypePad,
        LiveJournal,
        Blogger,
        FacebookPage,
        GenericUrl,
        YouTube,
        SyndicatedUrl,
        Email,
        Tumblr,
        GooglePlus,
        SquareSpace,
        LinkedIn,
        Posterous,
        Joomla,
        Drupal,
        MovableType,
        Reddit,
        VK,
        Picasa,
        Vimeo,
        Instagram,
        Sonico,
        Odnoklassniki,
        GetGlue,
        LastFM,
        BazaarVoice,
        LinkedInGroup,
        Chatter,
        Weibo,
        Tencent,
        Pinterest,
        LinkedInPage,
        CutAndPaste,
        Bitly,
        Jive,
        GoogleContact,
        Office365,
        JivePlace,
        Xing,
        SapJam,
        SalesforceSocialStudio,
        Slack,
        Yammer,
        SmartContent,
        CiscoSpark,
        FacebookWorkplace,
        InstagramBusiness,
        FacebookNative
    }

    public class CategoryOverviewResponse
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("parentCategoryId")]
        public int ParentCategoryID { get; set; }
    }

    public enum bodypostTypeInput
    {
        Text,
        Video
    }

    public enum bodyapprovalStateInput
    {
        Pending,
        Published,
        Excluded
    }

    public enum bodydisplayModeInput
    {
        DisplayInApp,
        OpenExternally
    }

    public class SuccessResponse
    {
        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class ManagePostTagsResponse
    {
        [JsonProperty("tags")]
        public ManagePostTagResponse[] Tags { get; set; }
    }

    public class ManagePostTagResponse
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("isAvailableToMembers")]
        public bool IsAvailableToMembers { get; set; }
    }

    public class CategoriesResponse
    {
        [JsonProperty("categories")]
        public CategoryResponse[] Categories { get; set; }

        [JsonProperty("subscriptionPrompt")]
        public string SubscriptionPrompt { get; set; }

        [JsonProperty("enableCategorySubscription")]
        public bool EnableCategorySubscription { get; set; }

        [JsonProperty("requireSubscriptionSelection")]
        public bool RequireSubscriptionSelection { get; set; }

        [JsonProperty("landingPageDefaultCategory")]
        public int LandingPageDefaultCategory { get; set; }
    }

    public class CategoryResponse
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("displayOrder")]
        public int DisplayOrder { get; set; }

        [JsonProperty("isPinned")]
        public bool IsPinned { get; set; }

        [JsonProperty("isForced")]
        public bool IsForced { get; set; }

        [JsonProperty("isSubscribed")]
        public bool IsSubscribed { get; set; }

        [JsonProperty("isHidden")]
        public bool IsHidden { get; set; }

        [JsonProperty("isUserSelectable")]
        public bool IsUserSelectable { get; set; }

        [JsonProperty("parentCategoryId")]
        public int ParentCategoryID { get; set; }

        [JsonProperty("childCategories")]
        public CategoryResponse1[] ChildCategories { get; set; }
    }

    public class CategoryResponse1
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("displayOrder")]
        public int DisplayOrder { get; set; }

        [JsonProperty("isPinned")]
        public bool IsPinned { get; set; }

        [JsonProperty("isForced")]
        public bool IsForced { get; set; }

        [JsonProperty("isSubscribed")]
        public bool IsSubscribed { get; set; }

        [JsonProperty("isHidden")]
        public bool IsHidden { get; set; }

        [JsonProperty("isUserSelectable")]
        public bool IsUserSelectable { get; set; }

        [JsonProperty("parentCategoryId")]
        public int ParentCategoryID { get; set; }
    }

    public class TargetDefinitionsInfoResponse
    {
        [JsonProperty("definitions")]
        public TargetDefinitionInfoResponse[] Definitions { get; set; }
    }

    public class TargetDefinitionInfoResponse
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("getUserConfirmation")]
        public bool GetUserConfirmation { get; set; }

        [JsonProperty("allowMultipleSelections")]
        public bool AllowMultipleSelections { get; set; }

        [JsonProperty("selectionRequired")]
        public bool SelectionRequired { get; set; }

        [JsonProperty("targetSelectionPrompt")]
        public string TargetSelectionPrompt { get; set; }

        [JsonProperty("childTargets")]
        public TargetInfoResponse[] ChildTargets { get; set; }
    }

    public class TargetInfoResponse
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("definitionId")]
        public int DefinitionID { get; set; }

        [JsonProperty("parentId")]
        public int ParentID { get; set; }

        [JsonProperty("isSubscribed")]
        public bool IsSubscribed { get; set; }

        [JsonProperty("childTargets")]
        public TargetInfoResponse1[] ChildTargets { get; set; }
    }

    public class TargetInfoResponse1
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("definitionId")]
        public int DefinitionID { get; set; }

        [JsonProperty("parentId")]
        public int ParentID { get; set; }

        [JsonProperty("isSubscribed")]
        public bool IsSubscribed { get; set; }

        [JsonProperty("childTargets")]
        public TargetInfoResponse2[] ChildTargets { get; set; }
    }

    public class TargetInfoResponse2
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("definitionId")]
        public int DefinitionID { get; set; }

        [JsonProperty("parentId")]
        public int ParentID { get; set; }

        [JsonProperty("isSubscribed")]
        public bool IsSubscribed { get; set; }

        [JsonProperty("childTargets")]
        public TargetInfoResponse3[] ChildTargets { get; set; }
    }

    public class TargetInfoResponse3
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("definitionId")]
        public int DefinitionID { get; set; }

        [JsonProperty("parentId")]
        public int ParentID { get; set; }

        [JsonProperty("isSubscribed")]
        public bool IsSubscribed { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Dynamicsignal;

    public partial class WorkflowManagedActions
    {
        public DynamicsignalActions Dynamicsignal(string connectionId) => new DynamicsignalActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DynamicsignalTriggers Dynamicsignal(string connectionId) => new DynamicsignalTriggers(connectionId);
    }
}
