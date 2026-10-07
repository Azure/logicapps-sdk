//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Mural
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MuralActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mural")]
        [WorkflowExpressionFactory(nameof(__BuildCreateNewMural))]
        public IBodyWorkflowAction<CreateNewMuralResponse> CreateNewMural([WorkflowExpression] Func<string> bodyworkspaceId, [WorkflowExpression] Func<int> bodyroomId, [WorkflowExpression] Func<string> bodytitle = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mural")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateNewMuralResponse> __BuildCreateNewMural(WorkflowExpression<string> bodyworkspaceId, WorkflowExpression<int> bodyroomId, WorkflowExpression<string> bodytitle = null)
        {
            WorkflowExpression.Validate(bodyworkspaceId, nameof(bodyworkspaceId), required: true);
            WorkflowExpression.Validate(bodyroomId, nameof(bodyroomId), required: true);
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            return new DeferredBodyAction<CreateNewMuralResponse>(() =>
            {
                var apiCallPath = "/api/public/v1/murals";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["workspaceId"] = ExpressionConverter.ConvertO(bodyworkspaceId);
                bodypropCount++;
                body["roomId"] = ExpressionConverter.ConvertO(bodyroomId);
                if (bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(bodytitle);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateNewMuralResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mural")]
        [WorkflowExpressionFactory(nameof(__BuildCreateNewStickyNote))]
        public IBodyWorkflowAction<CreateNewStickyNoteResponse> CreateNewStickyNote([WorkflowExpression] Func<string> workspaceId, [WorkflowExpression] Func<string> roomId, [WorkflowExpression] Func<string> muralId, [WorkflowExpression] Func<bodyshapeInput> bodyshape, [WorkflowExpression] Func<string> bodytext = null, [WorkflowExpression] Func<string> bodytitle = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mural")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateNewStickyNoteResponse> __BuildCreateNewStickyNote(WorkflowExpression<string> workspaceId, WorkflowExpression<string> roomId, WorkflowExpression<string> muralId, WorkflowExpression<bodyshapeInput> bodyshape, WorkflowExpression<string> bodytext = null, WorkflowExpression<string> bodytitle = null)
        {
            WorkflowExpression.Validate(workspaceId, nameof(workspaceId), required: true);
            WorkflowExpression.Validate(roomId, nameof(roomId), required: true);
            WorkflowExpression.Validate(muralId, nameof(muralId), required: true);
            WorkflowExpression.Validate(bodyshape, nameof(bodyshape), required: true);
            WorkflowExpression.Validate(bodytext, nameof(bodytext), required: false);
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            return new DeferredBodyAction<CreateNewStickyNoteResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/public/v1/murals/{0}/widgets/sticky-note", ExpressionConverter.ConvertWithUrlEncoding(muralId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workspaceId"] = ExpressionConverter.Convert(workspaceId);
                callPayload.Queries["roomId"] = ExpressionConverter.Convert(roomId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytext != null)
                {
                    body["text"] = ExpressionConverter.ConvertO(bodytext);
                    bodypropCount++;
                }

                if (bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(bodytitle);
                    bodypropCount++;
                }

                bodypropCount++;
                body["shape"] = ExpressionConverter.ConvertO(bodyshape);
                body["x"] = 150;
                bodypropCount++;
                body["y"] = 250;
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateNewStickyNoteResponse>(callPayload);
            });
        }
    }

    public class MuralTriggers([ConnectionName] string connectionId)
    {
    }

    public class CreateNewMuralResponse
    {
        [JsonProperty("value")]
        public CreateNewMuralResponseValueType Value { get; set; }
    }

    public class CreateNewMuralResponseValueType
    {
        [JsonProperty("backgroundColor")]
        public string BackgroundColor { get; set; }

        [JsonProperty("createdBy")]
        public CreateNewMuralResponseValueTypeCreatedByType CreatedBy { get; set; }

        [JsonProperty("createdOn")]
        public int CreatedOn { get; set; }

        [JsonProperty("embedLink")]
        public string EmbedLink { get; set; }

        [JsonProperty("favorite")]
        public bool Favorite { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("roomId")]
        public int RoomId { get; set; }

        [JsonProperty("sharingSettings")]
        public CreateNewMuralResponseValueTypeSharingSettingsType SharingSettings { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("thumbnailUrl")]
        public string ThumbnailUrl { get; set; }

        [JsonProperty("timerSoundTheme")]
        public string TimerSoundTheme { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("updatedBy")]
        public CreateNewMuralResponseValueTypeUpdatedByType UpdatedBy { get; set; }

        [JsonProperty("updatedOn")]
        public int UpdatedOn { get; set; }

        [JsonProperty("visitorAvatarTheme")]
        public string VisitorAvatarTheme { get; set; }

        [JsonProperty("visitorsSettings")]
        public CreateNewMuralResponseValueTypeVisitorsSettingsType VisitorsSettings { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("workspaceId")]
        public string WorkspaceId { get; set; }
    }

    public class CreateNewMuralResponseValueTypeCreatedByType
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class CreateNewMuralResponseValueTypeSharingSettingsType
    {
        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class CreateNewMuralResponseValueTypeUpdatedByType
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class CreateNewMuralResponseValueTypeVisitorsSettingsType
    {
        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("visitors")]
        public string Visitors { get; set; }

        [JsonProperty("workspaceMembers")]
        public string WorkspaceMembers { get; set; }
    }

    public class CreateNewStickyNoteResponse
    {
        [JsonProperty("value")]
        public CreateNewStickyNoteResponseValueType Value { get; set; }
    }

    public class CreateNewStickyNoteResponseValueType
    {
        [JsonProperty("contentEditedBy")]
        public CreateNewStickyNoteResponseValueTypeContentEditedByType ContentEditedBy { get; set; }

        [JsonProperty("contentEditedOn")]
        public int ContentEditedOn { get; set; }

        [JsonProperty("createdBy")]
        public CreateNewStickyNoteResponseValueTypeCreatedByType CreatedBy { get; set; }

        [JsonProperty("createdOn")]
        public int CreatedOn { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("hidden")]
        public bool Hidden { get; set; }

        [JsonProperty("hideEditor")]
        public bool HideEditor { get; set; }

        [JsonProperty("hideOwner")]
        public bool HideOwner { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("instruction")]
        public string Instruction { get; set; }

        [JsonProperty("locked")]
        public bool Locked { get; set; }

        [JsonProperty("lockedByFacilitator")]
        public bool LockedByFacilitator { get; set; }

        [JsonProperty("parentId")]
        public string ParentId { get; set; }

        [JsonProperty("presentationIndex")]
        public int PresentationIndex { get; set; }

        [JsonProperty("rotation")]
        public int Rotation { get; set; }

        [JsonProperty("stackingOrder")]
        public int StackingOrder { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("updatedBy")]
        public CreateNewStickyNoteResponseValueTypeUpdatedByType UpdatedBy { get; set; }

        [JsonProperty("updatedOn")]
        public int UpdatedOn { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("x")]
        public int X { get; set; }

        [JsonProperty("y")]
        public int Y { get; set; }

        [JsonProperty("minLines")]
        public int MinLines { get; set; }

        [JsonProperty("shape")]
        public string Shape { get; set; }

        [JsonProperty("style")]
        public CreateNewStickyNoteResponseValueTypeStyleType Style { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class CreateNewStickyNoteResponseValueTypeContentEditedByType
    {
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }
    }

    public class CreateNewStickyNoteResponseValueTypeCreatedByType
    {
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }
    }

    public class CreateNewStickyNoteResponseValueTypeUpdatedByType
    {
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }
    }

    public class CreateNewStickyNoteResponseValueTypeStyleType
    {
        [JsonProperty("backgroundColor")]
        public string BackgroundColor { get; set; }

        [JsonProperty("bold")]
        public bool Bold { get; set; }

        [JsonProperty("font")]
        public string Font { get; set; }

        [JsonProperty("fontSize")]
        public int FontSize { get; set; }

        [JsonProperty("italic")]
        public bool Italic { get; set; }

        [JsonProperty("strike")]
        public bool Strike { get; set; }

        [JsonProperty("textAlign")]
        public string TextAlign { get; set; }

        [JsonProperty("underline")]
        public bool Underline { get; set; }

        [JsonProperty("border")]
        public bool Border { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyshapeInput
    {
        [EnumMember(Value = "rectangle")]
        Rectangle,
        [EnumMember(Value = "circle")]
        Circle
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Mural;

    public partial class WorkflowManagedActions
    {
        public MuralActions Mural(string connectionId) => new MuralActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MuralTriggers Mural(string connectionId) => new MuralTriggers(connectionId);
    }
}