//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Tilkee
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TilkeeActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tilkee")]
        [WorkflowExpressionFactory(nameof(__BuildProjectCreate))]
        public IBodyWorkflowAction<ProjectCreateResponse> ProjectCreate([WorkflowExpression] Func<string> bodyprojectid = null, [WorkflowExpression] Func<string> bodyprojectname = null, [WorkflowExpression] Func<bool> bodyprojectcanBeDownloaded = null, [WorkflowExpression] Func<bool> bodyprojectconsultable = null, [WorkflowExpression] Func<string> bodyprojectconsultableUntil = null, [WorkflowExpression] Func<string[]> bodyprojecttags = null, [WorkflowExpression] Func<JToken[]> bodyprojectcollaborators = null, [WorkflowExpression] Func<bool> bodyprojectisTemplate = null, [WorkflowExpression] Func<string> bodyprojectexternalId = null, [WorkflowExpression] Func<int> bodyprojectthemeid = null, [WorkflowExpression] Func<bodydocumentsInputItem[]> bodydocuments = null, [WorkflowExpression] Func<bodypersonInputItem[]> bodyperson = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tilkee")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ProjectCreateResponse> __BuildProjectCreate(WorkflowExpression<string> bodyprojectid = null, WorkflowExpression<string> bodyprojectname = null, WorkflowExpression<bool> bodyprojectcanBeDownloaded = null, WorkflowExpression<bool> bodyprojectconsultable = null, WorkflowExpression<string> bodyprojectconsultableUntil = null, WorkflowExpression<string[]> bodyprojecttags = null, WorkflowExpression<JToken[]> bodyprojectcollaborators = null, WorkflowExpression<bool> bodyprojectisTemplate = null, WorkflowExpression<string> bodyprojectexternalId = null, WorkflowExpression<int> bodyprojectthemeid = null, WorkflowExpression<bodydocumentsInputItem[]> bodydocuments = null, WorkflowExpression<bodypersonInputItem[]> bodyperson = null)
        {
            WorkflowExpression.Validate(bodyprojectid, nameof(bodyprojectid), required: false);
            WorkflowExpression.Validate(bodyprojectname, nameof(bodyprojectname), required: false);
            WorkflowExpression.Validate(bodyprojectcanBeDownloaded, nameof(bodyprojectcanBeDownloaded), required: false);
            WorkflowExpression.Validate(bodyprojectconsultable, nameof(bodyprojectconsultable), required: false);
            WorkflowExpression.Validate(bodyprojectconsultableUntil, nameof(bodyprojectconsultableUntil), required: false);
            WorkflowExpression.Validate(bodyprojecttags, nameof(bodyprojecttags), required: false);
            WorkflowExpression.Validate(bodyprojectcollaborators, nameof(bodyprojectcollaborators), required: false);
            WorkflowExpression.Validate(bodyprojectisTemplate, nameof(bodyprojectisTemplate), required: false);
            WorkflowExpression.Validate(bodyprojectexternalId, nameof(bodyprojectexternalId), required: false);
            WorkflowExpression.Validate(bodyprojectthemeid, nameof(bodyprojectthemeid), required: false);
            WorkflowExpression.Validate(bodydocuments, nameof(bodydocuments), required: false);
            WorkflowExpression.Validate(bodyperson, nameof(bodyperson), required: false);
            return new DeferredBodyAction<ProjectCreateResponse>(() =>
            {
                var apiCallPath = "/wrapper/token_from_files";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["x_tilk_ref"] = Convert.ToString("PowerAutomate");
                var body = new JObject();
                var bodypropCount = 0;
                var projectObject = new JObject();
                var projectObjectpropCount = 0;
                if (bodyprojectid != null)
                {
                    projectObject["id"] = ExpressionConverter.ConvertO(bodyprojectid);
                    projectObjectpropCount++;
                }

                if (bodyprojectname != null)
                {
                    projectObject["name"] = ExpressionConverter.ConvertO(bodyprojectname);
                    projectObjectpropCount++;
                }

                if (bodyprojectcanBeDownloaded != null)
                {
                    projectObject["can_be_downloaded"] = ExpressionConverter.ConvertO(bodyprojectcanBeDownloaded);
                    projectObjectpropCount++;
                }

                if (bodyprojectconsultable != null)
                {
                    if (bodyprojectconsultable != null)
                    {
                        projectObject["consultable"] = ExpressionConverter.ConvertO(bodyprojectconsultable);
                        projectObjectpropCount++;
                    }

                    projectObjectpropCount++;
                }
                else
                {
                    projectObject["consultable"] = true;
                    projectObjectpropCount++;
                }

                if (bodyprojectconsultableUntil != null)
                {
                    projectObject["consultable_until"] = ExpressionConverter.ConvertO(bodyprojectconsultableUntil);
                    projectObjectpropCount++;
                }

                if (bodyprojecttags != null)
                {
                    projectObject["tags"] = ExpressionConverter.ConvertO(bodyprojecttags);
                    projectObjectpropCount++;
                }

                if (bodyprojectcollaborators != null)
                {
                    projectObject["collaborators"] = ExpressionConverter.ConvertO(bodyprojectcollaborators);
                    projectObjectpropCount++;
                }

                if (bodyprojectisTemplate != null)
                {
                    if (bodyprojectisTemplate != null)
                    {
                        projectObject["is_template"] = ExpressionConverter.ConvertO(bodyprojectisTemplate);
                        projectObjectpropCount++;
                    }

                    projectObjectpropCount++;
                }
                else
                {
                    projectObject["is_template"] = false;
                    projectObjectpropCount++;
                }

                if (bodyprojectexternalId != null)
                {
                    projectObject["external_id"] = ExpressionConverter.ConvertO(bodyprojectexternalId);
                    projectObjectpropCount++;
                }

                var themeObject = new JObject();
                var themeObjectpropCount = 0;
                if (bodyprojectthemeid != null)
                {
                    themeObject["id"] = ExpressionConverter.ConvertO(bodyprojectthemeid);
                    themeObjectpropCount++;
                }

                if (themeObjectpropCount > 0)
                {
                    projectObject["theme"] = themeObject;
                    projectObjectpropCount++;
                }

                if (projectObjectpropCount > 0)
                {
                    body["project"] = projectObject;
                    bodypropCount++;
                }

                if (bodydocuments != null)
                {
                    body["documents"] = ExpressionConverter.ConvertO(bodydocuments);
                    bodypropCount++;
                }

                if (bodyperson != null)
                {
                    body["person"] = ExpressionConverter.ConvertO(bodyperson);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ProjectCreateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tilkee")]
        [WorkflowExpressionFactory(nameof(__BuildProjectList))]
        public IBodyWorkflowAction<ProjectListResponse> ProjectList([WorkflowExpression] Func<int> limit, [WorkflowExpression] Func<int> offset, [WorkflowExpression] Func<string> order, [WorkflowExpression] Func<bool> isTemplate, [WorkflowExpression] Func<bool> isOwner, [WorkflowExpression] Func<string> tags = null, [WorkflowExpression] Func<string> tagOperator = null, [WorkflowExpression] Func<string> search = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tilkee")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ProjectListResponse> __BuildProjectList(WorkflowExpression<int> limit, WorkflowExpression<int> offset, WorkflowExpression<string> order, WorkflowExpression<bool> isTemplate, WorkflowExpression<bool> isOwner, WorkflowExpression<string> tags = null, WorkflowExpression<string> tagOperator = null, WorkflowExpression<string> search = null)
        {
            WorkflowExpression.Validate(limit, nameof(limit), required: true);
            WorkflowExpression.Validate(offset, nameof(offset), required: true);
            WorkflowExpression.Validate(order, nameof(order), required: true);
            WorkflowExpression.Validate(isTemplate, nameof(isTemplate), required: true);
            WorkflowExpression.Validate(isOwner, nameof(isOwner), required: true);
            WorkflowExpression.Validate(tags, nameof(tags), required: false);
            WorkflowExpression.Validate(tagOperator, nameof(tagOperator), required: false);
            WorkflowExpression.Validate(search, nameof(search), required: false);
            return new DeferredBodyAction<ProjectListResponse>(() =>
            {
                var apiCallPath = "/projects";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                callPayload.Queries["order"] = ExpressionConverter.Convert(order);
                callPayload.Queries["is_template"] = ExpressionConverter.Convert(isTemplate);
                if (tags != null)
                    callPayload.Queries["tags"] = ExpressionConverter.Convert(tags);
                if (tagOperator != null)
                    callPayload.Queries["tagOperator"] = ExpressionConverter.Convert(tagOperator);
                callPayload.Queries["is_owner"] = ExpressionConverter.Convert(isOwner);
                if (search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(search);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["x_tilk_ref"] = Convert.ToString("PowerAutomate");
                return new ApiConnectionAction<ProjectListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tilkee")]
        [WorkflowExpressionFactory(nameof(__BuildProjectGet))]
        public IBodyWorkflowAction<ProjectGetResponse> ProjectGet([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tilkee")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ProjectGetResponse> __BuildProjectGet(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<ProjectGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/projects/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["iframe_url"] = Convert.ToString(true);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["x_tilk_ref"] = Convert.ToString("PowerAutomate");
                return new ApiConnectionAction<ProjectGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tilkee")]
        [WorkflowExpressionFactory(nameof(__BuildProjectUpdate))]
        public IBodyWorkflowAction<ProjectUpdateResponse> ProjectUpdate([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<bool> bodycanBeDownloaded = null, [WorkflowExpression] Func<bool> bodyconsultable = null, [WorkflowExpression] Func<string> bodyconsultableUntil = null, [WorkflowExpression] Func<string> bodyduration = null, [WorkflowExpression] Func<string> bodyexternalId = null, [WorkflowExpression] Func<bool> bodystarred = null, [WorkflowExpression] Func<string[]> bodytags = null, [WorkflowExpression] Func<bodyverdictInput> bodyverdict = null, [WorkflowExpression] Func<JToken[]> bodycollaborators = null, [WorkflowExpression] Func<bool> bodyisTemplate = null, [WorkflowExpression] Func<int> bodyvcardId = null, [WorkflowExpression] Func<bool> bodyalertOn = null, [WorkflowExpression] Func<string[]> bodyemailCible = null, [WorkflowExpression] Func<int> bodythemeid = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tilkee")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ProjectUpdateResponse> __BuildProjectUpdate(WorkflowExpression<string> id, WorkflowExpression<string> bodyname = null, WorkflowExpression<bool> bodycanBeDownloaded = null, WorkflowExpression<bool> bodyconsultable = null, WorkflowExpression<string> bodyconsultableUntil = null, WorkflowExpression<string> bodyduration = null, WorkflowExpression<string> bodyexternalId = null, WorkflowExpression<bool> bodystarred = null, WorkflowExpression<string[]> bodytags = null, WorkflowExpression<bodyverdictInput> bodyverdict = null, WorkflowExpression<JToken[]> bodycollaborators = null, WorkflowExpression<bool> bodyisTemplate = null, WorkflowExpression<int> bodyvcardId = null, WorkflowExpression<bool> bodyalertOn = null, WorkflowExpression<string[]> bodyemailCible = null, WorkflowExpression<int> bodythemeid = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowExpression.Validate(bodycanBeDownloaded, nameof(bodycanBeDownloaded), required: false);
            WorkflowExpression.Validate(bodyconsultable, nameof(bodyconsultable), required: false);
            WorkflowExpression.Validate(bodyconsultableUntil, nameof(bodyconsultableUntil), required: false);
            WorkflowExpression.Validate(bodyduration, nameof(bodyduration), required: false);
            WorkflowExpression.Validate(bodyexternalId, nameof(bodyexternalId), required: false);
            WorkflowExpression.Validate(bodystarred, nameof(bodystarred), required: false);
            WorkflowExpression.Validate(bodytags, nameof(bodytags), required: false);
            WorkflowExpression.Validate(bodyverdict, nameof(bodyverdict), required: false);
            WorkflowExpression.Validate(bodycollaborators, nameof(bodycollaborators), required: false);
            WorkflowExpression.Validate(bodyisTemplate, nameof(bodyisTemplate), required: false);
            WorkflowExpression.Validate(bodyvcardId, nameof(bodyvcardId), required: false);
            WorkflowExpression.Validate(bodyalertOn, nameof(bodyalertOn), required: false);
            WorkflowExpression.Validate(bodyemailCible, nameof(bodyemailCible), required: false);
            WorkflowExpression.Validate(bodythemeid, nameof(bodythemeid), required: false);
            return new DeferredBodyAction<ProjectUpdateResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/projects/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["x_tilk_ref"] = Convert.ToString("PowerAutomate");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(bodyname);
                    bodypropCount++;
                }

                if (bodycanBeDownloaded != null)
                {
                    body["can_be_downloaded"] = ExpressionConverter.ConvertO(bodycanBeDownloaded);
                    bodypropCount++;
                }

                if (bodyconsultable != null)
                {
                    body["consultable"] = ExpressionConverter.ConvertO(bodyconsultable);
                    bodypropCount++;
                }

                if (bodyconsultableUntil != null)
                {
                    body["consultable_until"] = ExpressionConverter.ConvertO(bodyconsultableUntil);
                    bodypropCount++;
                }

                if (bodyduration != null)
                {
                    body["duration"] = ExpressionConverter.ConvertO(bodyduration);
                    bodypropCount++;
                }

                if (bodyexternalId != null)
                {
                    body["external_id"] = ExpressionConverter.ConvertO(bodyexternalId);
                    bodypropCount++;
                }

                if (bodystarred != null)
                {
                    body["starred"] = ExpressionConverter.ConvertO(bodystarred);
                    bodypropCount++;
                }

                if (bodytags != null)
                {
                    body["tags"] = ExpressionConverter.ConvertO(bodytags);
                    bodypropCount++;
                }

                if (bodyverdict != null)
                {
                    body["verdict"] = ExpressionConverter.ConvertO(bodyverdict);
                    bodypropCount++;
                }

                if (bodycollaborators != null)
                {
                    body["collaborators"] = ExpressionConverter.ConvertO(bodycollaborators);
                    bodypropCount++;
                }

                if (bodyisTemplate != null)
                {
                    body["is_template"] = ExpressionConverter.ConvertO(bodyisTemplate);
                    bodypropCount++;
                }

                if (bodyvcardId != null)
                {
                    body["vcard_id"] = ExpressionConverter.ConvertO(bodyvcardId);
                    bodypropCount++;
                }

                if (bodyalertOn != null)
                {
                    body["alert_on"] = ExpressionConverter.ConvertO(bodyalertOn);
                    bodypropCount++;
                }

                if (bodyemailCible != null)
                {
                    body["email_cible"] = ExpressionConverter.ConvertO(bodyemailCible);
                    bodypropCount++;
                }

                var themeObject = new JObject();
                var themeObjectpropCount = 0;
                if (bodythemeid != null)
                {
                    themeObject["id"] = ExpressionConverter.ConvertO(bodythemeid);
                    themeObjectpropCount++;
                }

                if (themeObjectpropCount > 0)
                {
                    body["theme"] = themeObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ProjectUpdateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tilkee")]
        [WorkflowExpressionFactory(nameof(__BuildAccessLinkCreate))]
        public IBodyWorkflowAction<AccessLinkCreateResponse> AccessLinkCreate([WorkflowExpression] Func<string> projectId, [WorkflowExpression] Func<bodyaccessLinkInputItem[]> bodyaccessLink = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tilkee")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AccessLinkCreateResponse> __BuildAccessLinkCreate(WorkflowExpression<string> projectId, WorkflowExpression<bodyaccessLinkInputItem[]> bodyaccessLink = null)
        {
            WorkflowExpression.Validate(projectId, nameof(projectId), required: true);
            WorkflowExpression.Validate(bodyaccessLink, nameof(bodyaccessLink), required: false);
            return new DeferredBodyAction<AccessLinkCreateResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/projects/{0}/tokens", ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["x_tilk_ref"] = Convert.ToString("PowerAutomate");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyaccessLink != null)
                {
                    body["persons"] = ExpressionConverter.ConvertO(bodyaccessLink);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<AccessLinkCreateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tilkee")]
        [WorkflowExpressionFactory(nameof(__BuildAddItemToProject))]
        public IBodyWorkflowAction<AddItemToProjectResponseItem[]> AddItemToProject([WorkflowExpression] Func<string> projectId, [WorkflowExpression] Func<bodyitemsInputItem[]> bodyitems = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tilkee")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AddItemToProjectResponseItem[]> __BuildAddItemToProject(WorkflowExpression<string> projectId, WorkflowExpression<bodyitemsInputItem[]> bodyitems = null)
        {
            WorkflowExpression.Validate(projectId, nameof(projectId), required: true);
            WorkflowExpression.Validate(bodyitems, nameof(bodyitems), required: false);
            return new DeferredBodyAction<AddItemToProjectResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/projects/{0}/add_items", ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["x_tilk_ref"] = Convert.ToString("PowerAutomate");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyitems != null)
                {
                    body["items"] = ExpressionConverter.ConvertO(bodyitems);
                    bodypropCount++;
                }

                body["type"] = "ProjectItem";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<AddItemToProjectResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tilkee")]
        [WorkflowExpressionFactory(nameof(__BuildItemList))]
        public IBodyWorkflowAction<ItemListResponse> ItemList([WorkflowExpression] Func<int> limit, [WorkflowExpression] Func<int> offset, [WorkflowExpression] Func<string> tags = null, [WorkflowExpression] Func<string> tagOperator = null, [WorkflowExpression] Func<string> search = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tilkee")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ItemListResponse> __BuildItemList(WorkflowExpression<int> limit, WorkflowExpression<int> offset, WorkflowExpression<string> tags = null, WorkflowExpression<string> tagOperator = null, WorkflowExpression<string> search = null)
        {
            WorkflowExpression.Validate(limit, nameof(limit), required: true);
            WorkflowExpression.Validate(offset, nameof(offset), required: true);
            WorkflowExpression.Validate(tags, nameof(tags), required: false);
            WorkflowExpression.Validate(tagOperator, nameof(tagOperator), required: false);
            WorkflowExpression.Validate(search, nameof(search), required: false);
            return new DeferredBodyAction<ItemListResponse>(() =>
            {
                var apiCallPath = "/items";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                if (tags != null)
                    callPayload.Queries["tags"] = ExpressionConverter.Convert(tags);
                if (tagOperator != null)
                    callPayload.Queries["tagOperator"] = ExpressionConverter.Convert(tagOperator);
                if (search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(search);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["x_tilk_ref"] = Convert.ToString("PowerAutomate");
                return new ApiConnectionAction<ItemListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tilkee")]
        [WorkflowExpressionFactory(nameof(__BuildItemCreate))]
        public IBodyWorkflowAction<ItemCreateResponseItem[]> ItemCreate([WorkflowExpression] Func<bodyInputItem[]> body = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tilkee")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ItemCreateResponseItem[]> __BuildItemCreate(WorkflowExpression<bodyInputItem[]> body = null)
        {
            WorkflowExpression.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<ItemCreateResponseItem[]>(() =>
            {
                var apiCallPath = "/items";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["x_tilk_ref"] = Convert.ToString("PowerAutomate");
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<ItemCreateResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tilkee")]
        [WorkflowExpressionFactory(nameof(__BuildDirectUploadInformation))]
        public IBodyWorkflowAction<DirectUploadInformationResponse> DirectUploadInformation([WorkflowExpression] Func<string> filename, [WorkflowExpression] Func<string> originalFilename, [WorkflowExpression] Func<bool> checkExisting = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tilkee")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DirectUploadInformationResponse> __BuildDirectUploadInformation(WorkflowExpression<string> filename, WorkflowExpression<string> originalFilename, WorkflowExpression<bool> checkExisting = null)
        {
            WorkflowExpression.Validate(filename, nameof(filename), required: true);
            WorkflowExpression.Validate(originalFilename, nameof(originalFilename), required: true);
            WorkflowExpression.Validate(checkExisting, nameof(checkExisting), required: false);
            return new DeferredBodyAction<DirectUploadInformationResponse>(() =>
            {
                var apiCallPath = "/direct_upload_data";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["filename"] = ExpressionConverter.Convert(filename);
                callPayload.Queries["original_filename"] = ExpressionConverter.Convert(originalFilename);
                if (checkExisting != null)
                    callPayload.Queries["check_existing"] = ExpressionConverter.Convert(checkExisting);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["x_tilk_ref"] = Convert.ToString("PowerAutomate");
                return new ApiConnectionAction<DirectUploadInformationResponse>(callPayload);
            });
        }
    }

    public class TilkeeTriggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildOnTilkeeEvent))]
        public IBodyWorkflowTrigger<JToken> OnTilkeeEvent([WorkflowExpression] Func<bodyruleInput> bodyrule,[WorkflowExpression] Func<string> bodyuserId = null,[WorkflowExpression] Func<string> bodyprojectId = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<JToken> __BuildOnTilkeeEvent(WorkflowExpression<bodyruleInput> bodyrule,WorkflowExpression<string> bodyuserId = null,WorkflowExpression<string> bodyprojectId = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodyrule, nameof(bodyrule), required: true);
            WorkflowExpression.Validate(bodyuserId, nameof(bodyuserId), required: false);
            WorkflowExpression.Validate(bodyprojectId, nameof(bodyprojectId), required: false);
            return new DeferredBodyTrigger<JToken>(() =>
            {
                var apiCallPath = "/notifications";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["x_tilk_ref"] = Convert.ToString("PowerAutomate");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["rule"] = ExpressionConverter.ConvertO(bodyrule);
                if (bodyuserId != null)
                {
                    body["user_id"] = ExpressionConverter.ConvertO(bodyuserId);
                    bodypropCount++;
                }

                if (bodyprojectId != null)
                {
                    body["project_id"] = ExpressionConverter.ConvertO(bodyprojectId);
                    bodypropCount++;
                }

                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                body["target"] = "Webhook";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildOnTilkeeEventEnded))]
        public IBodyWorkflowTrigger<JToken> OnTilkeeEventEnded([WorkflowExpression] Func<string> bodyuserId = null,[WorkflowExpression] Func<string> bodyprojectId = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<JToken> __BuildOnTilkeeEventEnded(WorkflowExpression<string> bodyuserId = null,WorkflowExpression<string> bodyprojectId = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodyuserId, nameof(bodyuserId), required: false);
            WorkflowExpression.Validate(bodyprojectId, nameof(bodyprojectId), required: false);
            return new DeferredBodyTrigger<JToken>(() =>
            {
                var apiCallPath = "/notifications/connexion_ended";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["x_tilk_ref"] = Convert.ToString("PowerAutomate");
                var body = new JObject();
                var bodypropCount = 0;
                body["rule"] = "connexion_ended";
                bodypropCount++;
                if (bodyuserId != null)
                {
                    body["user_id"] = ExpressionConverter.ConvertO(bodyuserId);
                    bodypropCount++;
                }

                if (bodyprojectId != null)
                {
                    body["project_id"] = ExpressionConverter.ConvertO(bodyprojectId);
                    bodypropCount++;
                }

                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                body["target"] = "Webhook";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildOnTilkeeEventSigned))]
        public IBodyWorkflowTrigger<JToken> OnTilkeeEventSigned([WorkflowExpression] Func<string> bodyuserId = null,[WorkflowExpression] Func<string> bodyprojectId = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<JToken> __BuildOnTilkeeEventSigned(WorkflowExpression<string> bodyuserId = null,WorkflowExpression<string> bodyprojectId = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodyuserId, nameof(bodyuserId), required: false);
            WorkflowExpression.Validate(bodyprojectId, nameof(bodyprojectId), required: false);
            return new DeferredBodyTrigger<JToken>(() =>
            {
                var apiCallPath = "/notifications/token_signed";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["x_tilk_ref"] = Convert.ToString("PowerAutomate");
                var body = new JObject();
                var bodypropCount = 0;
                body["rule"] = "token_signed";
                bodypropCount++;
                if (bodyuserId != null)
                {
                    body["user_id"] = ExpressionConverter.ConvertO(bodyuserId);
                    bodypropCount++;
                }

                if (bodyprojectId != null)
                {
                    body["project_id"] = ExpressionConverter.ConvertO(bodyprojectId);
                    bodypropCount++;
                }

                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                body["target"] = "Webhook";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class ProjectCreateResponse
    {
        [JsonProperty("project")]
        public ProjectCreateResponseProjectType Project { get; set; }

        [JsonProperty("tokens")]
        public ProjectCreateResponseTokensTypeItem[] Tokens { get; set; }
    }

    public class ProjectCreateResponseProjectType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("preview_url")]
        public string PreviewUrl { get; set; }

        [JsonProperty("external_id")]
        public string ExternalId { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("iframes")]
        public ProjectCreateResponseProjectTypeIframesType Iframes { get; set; }
    }

    public class ProjectCreateResponseProjectTypeIframesType
    {
        [JsonProperty("project_escape")]
        public string ProjectEscape { get; set; }

        [JsonProperty("tokens_escape")]
        public string TokensEscape { get; set; }

        [JsonProperty("stats_escape")]
        public string StatsEscape { get; set; }
    }

    public class ProjectCreateResponseTokensTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("external_id")]
        public string ExternalId { get; set; }
    }

    public class bodydocumentsInputItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("s3_url")]
        public string S3Url { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("signable")]
        public bool Signable { get; set; }

        [JsonProperty("from_url")]
        public bool FromUrl { get; set; }

        [JsonProperty("external_id")]
        public string ExternalId { get; set; }
    }

    public class bodypersonInputItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("external_id")]
        public string ExternalId { get; set; }

        [JsonProperty("external_data")]
        public JToken ExternalData { get; set; }
    }

    public class ProjectListResponse
    {
        [JsonProperty("search")]
        public string Search { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("order")]
        public string Order { get; set; }

        [JsonProperty("contents")]
        public ProjectListResponseContentsTypeItem[] Contents { get; set; }
    }

    public class ProjectListResponseContentsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("verdict")]
        public string Verdict { get; set; }

        [JsonProperty("is_template")]
        public bool IsTemplate { get; set; }

        [JsonProperty("can_be_downloaded")]
        public bool CanBeDownloaded { get; set; }

        [JsonProperty("preview_new")]
        public string PreviewNew { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("starred")]
        public bool Starred { get; set; }

        [JsonProperty("external_id")]
        public string ExternalId { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("signed")]
        public bool Signed { get; set; }

        [JsonProperty("signable")]
        public bool Signable { get; set; }

        [JsonProperty("consultable")]
        public bool Consultable { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("pt_note")]
        public double PtNote { get; set; }

        [JsonProperty("pt_accuracy")]
        public string PtAccuracy { get; set; }

        [JsonProperty("pt_won")]
        public bool PtWon { get; set; }

        [JsonProperty("vcard_id")]
        public int VcardId { get; set; }

        [JsonProperty("email_cible")]
        public string[] EmailCible { get; set; }

        [JsonProperty("alert_on")]
        public bool AlertOn { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("consultable_until")]
        public string ConsultableUntil { get; set; }

        [JsonProperty("last_sign_in_at")]
        public string LastSignInAt { get; set; }

        [JsonProperty("first_access_at")]
        public string FirstAccessAt { get; set; }

        [JsonProperty("collaborators_count")]
        public int CollaboratorsCount { get; set; }

        [JsonProperty("convert_status")]
        public ProjectListResponseContentsTypeItemConvertStatusType ConvertStatus { get; set; }

        [JsonProperty("nb_connections")]
        public int NbConnections { get; set; }

        [JsonProperty("total_time")]
        public int TotalTime { get; set; }

        [JsonProperty("leader_first_name")]
        public string LeaderFirstName { get; set; }

        [JsonProperty("leader_last_name")]
        public string LeaderLastName { get; set; }

        [JsonProperty("leader_id")]
        public int LeaderId { get; set; }

        [JsonProperty("leader_email")]
        public string LeaderEmail { get; set; }

        [JsonProperty("leader_avatar")]
        public string LeaderAvatar { get; set; }

        [JsonProperty("tokens_count")]
        public int TokensCount { get; set; }

        [JsonProperty("project_items_count")]
        public int ProjectItemsCount { get; set; }

        [JsonProperty("nb_used_as_template")]
        public int NbUsedAsTemplate { get; set; }

        [JsonProperty("email_templates_count")]
        public int EmailTemplatesCount { get; set; }

        [JsonProperty("can_edit")]
        public bool CanEdit { get; set; }
    }

    public class ProjectListResponseContentsTypeItemConvertStatusType
    {
        [JsonProperty("complete_base")]
        public bool CompleteBase { get; set; }

        [JsonProperty("complete_full")]
        public bool CompleteFull { get; set; }
    }

    public class ProjectGetResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("consultable")]
        public bool Consultable { get; set; }

        [JsonProperty("verdict")]
        public string Verdict { get; set; }

        [JsonProperty("is_template")]
        public bool IsTemplate { get; set; }

        [JsonProperty("can_be_downloaded")]
        public bool CanBeDownloaded { get; set; }

        [JsonProperty("preview_new")]
        public string PreviewNew { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("starred")]
        public bool Starred { get; set; }

        [JsonProperty("external_id")]
        public string ExternalId { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("signed")]
        public bool Signed { get; set; }

        [JsonProperty("signable")]
        public bool Signable { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("vcard_id")]
        public int VcardId { get; set; }

        [JsonProperty("email_cible")]
        public string[] EmailCible { get; set; }

        [JsonProperty("alert_on")]
        public bool AlertOn { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("consultable_until")]
        public string ConsultableUntil { get; set; }

        [JsonProperty("last_sign_in_at")]
        public string LastSignInAt { get; set; }

        [JsonProperty("first_access_at")]
        public string FirstAccessAt { get; set; }

        [JsonProperty("collaborators_count")]
        public int CollaboratorsCount { get; set; }

        [JsonProperty("convert_status")]
        public ProjectGetResponseConvertStatusType ConvertStatus { get; set; }

        [JsonProperty("nb_connections")]
        public int NbConnections { get; set; }

        [JsonProperty("total_time")]
        public int TotalTime { get; set; }

        [JsonProperty("theme")]
        public ProjectGetResponseThemeType Theme { get; set; }

        [JsonProperty("iframes")]
        public ProjectGetResponseIframesType Iframes { get; set; }

        [JsonProperty("tokens_count")]
        public int TokensCount { get; set; }

        [JsonProperty("project_items_count")]
        public int ProjectItemsCount { get; set; }

        [JsonProperty("nb_used_as_template")]
        public int NbUsedAsTemplate { get; set; }

        [JsonProperty("email_templates_count")]
        public int EmailTemplatesCount { get; set; }
    }

    public class ProjectGetResponseConvertStatusType
    {
        [JsonProperty("complete_base")]
        public bool CompleteBase { get; set; }

        [JsonProperty("complete_full")]
        public bool CompleteFull { get; set; }
    }

    public class ProjectGetResponseThemeType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ProjectGetResponseIframesType
    {
        [JsonProperty("project_escape")]
        public string ProjectEscape { get; set; }

        [JsonProperty("tokens_escape")]
        public string TokensEscape { get; set; }

        [JsonProperty("stats_escape")]
        public string StatsEscape { get; set; }
    }

    public class ProjectUpdateResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("consultable")]
        public bool Consultable { get; set; }

        [JsonProperty("verdict")]
        public string Verdict { get; set; }

        [JsonProperty("is_template")]
        public bool IsTemplate { get; set; }

        [JsonProperty("can_be_downloaded")]
        public bool CanBeDownloaded { get; set; }

        [JsonProperty("preview_new")]
        public string PreviewNew { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("starred")]
        public bool Starred { get; set; }

        [JsonProperty("external_id")]
        public string ExternalId { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("signed")]
        public bool Signed { get; set; }

        [JsonProperty("signable")]
        public bool Signable { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("vcard_id")]
        public int VcardId { get; set; }

        [JsonProperty("email_cible")]
        public string[] EmailCible { get; set; }

        [JsonProperty("alert_on")]
        public bool AlertOn { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("consultable_until")]
        public string ConsultableUntil { get; set; }

        [JsonProperty("last_sign_in_at")]
        public string LastSignInAt { get; set; }

        [JsonProperty("first_access_at")]
        public string FirstAccessAt { get; set; }

        [JsonProperty("collaborators_count")]
        public int CollaboratorsCount { get; set; }

        [JsonProperty("convert_status")]
        public ProjectUpdateResponseConvertStatusType ConvertStatus { get; set; }

        [JsonProperty("nb_connections")]
        public int NbConnections { get; set; }

        [JsonProperty("total_time")]
        public int TotalTime { get; set; }

        [JsonProperty("theme")]
        public ProjectUpdateResponseThemeType Theme { get; set; }

        [JsonProperty("tokens_count")]
        public int TokensCount { get; set; }

        [JsonProperty("project_items_count")]
        public int ProjectItemsCount { get; set; }

        [JsonProperty("nb_used_as_template")]
        public int NbUsedAsTemplate { get; set; }

        [JsonProperty("email_templates_count")]
        public int EmailTemplatesCount { get; set; }
    }

    public class ProjectUpdateResponseConvertStatusType
    {
        [JsonProperty("complete_base")]
        public bool CompleteBase { get; set; }

        [JsonProperty("complete_full")]
        public bool CompleteFull { get; set; }
    }

    public class ProjectUpdateResponseThemeType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyverdictInput
    {
        [EnumMember(Value = "won")]
        Won,
        [EnumMember(Value = "lost")]
        Lost,
        [EnumMember(Value = "na")]
        Na,
        [EnumMember(Value = "nc")]
        Nc
    }

    public class AccessLinkCreateResponse
    {
        [JsonProperty("contents")]
        public AccessLinkCreateResponseContentsTypeItem[] Contents { get; set; }
    }

    public class AccessLinkCreateResponseContentsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("external_id")]
        public string ExternalId { get; set; }
    }

    public class bodyaccessLinkInputItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("external_id")]
        public string ExternalId { get; set; }

        [JsonProperty("external_data")]
        public JToken ExternalData { get; set; }
    }

    public class AddItemToProjectResponseItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("element_id")]
        public int ElementId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("signable")]
        public bool Signable { get; set; }

        [JsonProperty("downloadable")]
        public bool Downloadable { get; set; }

        [JsonProperty("item")]
        public AddItemToProjectResponseItemItemType Item { get; set; }
    }

    public class AddItemToProjectResponseItemItemType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("usable")]
        public bool Usable { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("external_id")]
        public string ExternalId { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("favorite")]
        public bool Favorite { get; set; }

        [JsonProperty("file_version")]
        public int FileVersion { get; set; }

        [JsonProperty("replaced_at")]
        public string ReplacedAt { get; set; }

        [JsonProperty("file_size")]
        public int FileSize { get; set; }

        [JsonProperty("num_pages")]
        public int NumPages { get; set; }

        [JsonProperty("convert_status")]
        public AddItemToProjectResponseItemItemTypeConvertStatusType ConvertStatus { get; set; }

        [JsonProperty("s3_url")]
        public string S3Url { get; set; }

        [JsonProperty("content_url")]
        public string ContentUrl { get; set; }

        [JsonProperty("thumbnail_url")]
        public string ThumbnailUrl { get; set; }

        [JsonProperty("visible")]
        public bool Visible { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
    }

    public class AddItemToProjectResponseItemItemTypeConvertStatusType
    {
        [JsonProperty("complete_base")]
        public bool CompleteBase { get; set; }

        [JsonProperty("complete_full")]
        public bool CompleteFull { get; set; }

        [JsonProperty("status")]
        public string[] Status { get; set; }
    }

    public class bodyitemsInputItem
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("downloadable")]
        public bool Downloadable { get; set; }

        [JsonProperty("signable")]
        public bool Signable { get; set; }

        [JsonProperty("watermark")]
        public string Watermark { get; set; }
    }

    public class ItemListResponse
    {
        [JsonProperty("search")]
        public string Search { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("order")]
        public string Order { get; set; }

        [JsonProperty("contents")]
        public ItemListResponseContentsTypeItem[] Contents { get; set; }
    }

    public class ItemListResponseContentsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("usable")]
        public bool Usable { get; set; }

        [JsonProperty("element_type")]
        public string ElementType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("external_id")]
        public string ExternalId { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("favorite")]
        public bool Favorite { get; set; }

        [JsonProperty("file_version")]
        public int FileVersion { get; set; }

        [JsonProperty("num_pages")]
        public int NumPages { get; set; }

        [JsonProperty("visible")]
        public bool Visible { get; set; }

        [JsonProperty("thumbnail_url")]
        public string ThumbnailUrl { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("replaced_at")]
        public string ReplacedAt { get; set; }

        [JsonProperty("s3_url")]
        public string S3Url { get; set; }

        [JsonProperty("content_url")]
        public string ContentUrl { get; set; }

        [JsonProperty("convert_status")]
        public ItemListResponseContentsTypeItemConvertStatusType ConvertStatus { get; set; }

        [JsonProperty("owner")]
        public ItemListResponseContentsTypeItemOwnerType Owner { get; set; }

        [JsonProperty("projects")]
        public ItemListResponseContentsTypeItemProjectsTypeItem[] Projects { get; set; }

        [JsonProperty("projects_count")]
        public int ProjectsCount { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("thumbnail_page_url")]
        public string ThumbnailPageUrl { get; set; }
    }

    public class ItemListResponseContentsTypeItemConvertStatusType
    {
        [JsonProperty("complete_base")]
        public bool CompleteBase { get; set; }

        [JsonProperty("complete_full")]
        public bool CompleteFull { get; set; }

        [JsonProperty("status")]
        public string[] Status { get; set; }
    }

    public class ItemListResponseContentsTypeItemOwnerType
    {
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("avatar")]
        public string Avatar { get; set; }
    }

    public class ItemListResponseContentsTypeItemProjectsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("is_template")]
        public bool IsTemplate { get; set; }
    }

    public class ItemCreateResponseItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("usable")]
        public bool Usable { get; set; }

        [JsonProperty("element_type")]
        public string ElementType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("external_id")]
        public string ExternalId { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("favorite")]
        public bool Favorite { get; set; }

        [JsonProperty("file_version")]
        public int FileVersion { get; set; }

        [JsonProperty("visible")]
        public bool Visible { get; set; }

        [JsonProperty("thumbnail_url")]
        public string ThumbnailUrl { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("replaced_at")]
        public string ReplacedAt { get; set; }

        [JsonProperty("s3_url")]
        public string S3Url { get; set; }

        [JsonProperty("content_url")]
        public string ContentUrl { get; set; }

        [JsonProperty("convert_status")]
        public ItemCreateResponseItemConvertStatusType ConvertStatus { get; set; }

        [JsonProperty("owner")]
        public ItemCreateResponseItemOwnerType Owner { get; set; }
    }

    public class ItemCreateResponseItemConvertStatusType
    {
        [JsonProperty("complete_base")]
        public bool CompleteBase { get; set; }

        [JsonProperty("complete_full")]
        public bool CompleteFull { get; set; }

        [JsonProperty("status")]
        public JToken[] Status { get; set; }
    }

    public class ItemCreateResponseItemOwnerType
    {
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("avatar")]
        public string Avatar { get; set; }
    }

    public class bodyInputItem
    {
        [JsonProperty("type")]
        public bodyInputItemTypeType Type { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("s3_url")]
        public string S3Url { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("external_id")]
        public string ExternalId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyInputItemTypeType
    {
        [EnumMember(Value = "file")]
        File,
        [EnumMember(Value = "text")]
        Text,
        [EnumMember(Value = "link")]
        Link
    }

    public class DirectUploadInformationResponse
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("acl")]
        public string Acl { get; set; }

        [JsonProperty("policy")]
        public string Policy { get; set; }

        [JsonProperty("signature")]
        public string Signature { get; set; }
        public string AWSAccessKeyId { get; set; }

        [JsonProperty("success_action_status")]
        public string SuccessActionStatus { get; set; }

        [JsonProperty("s3_endpoint")]
        public string S3Endpoint { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyruleInput
    {
        [EnumMember(Value = "connexion_started")]
        ConnexionStarted,
        [EnumMember(Value = "connexion_ended")]
        ConnexionEnded,
        [EnumMember(Value = "token_signed")]
        TokenSigned,
        [EnumMember(Value = "token_created")]
        TokenCreated,
        [EnumMember(Value = "project_archived")]
        ProjectArchived,
        [EnumMember(Value = "unactivated_project_accessed")]
        UnactivatedProjectAccessed,
        [EnumMember(Value = "user_created")]
        UserCreated
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Tilkee;

    public partial class WorkflowManagedActions
    {
        public TilkeeActions Tilkee(string connectionId) => new TilkeeActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TilkeeTriggers Tilkee(string connectionId) => new TilkeeTriggers(connectionId);
    }
}