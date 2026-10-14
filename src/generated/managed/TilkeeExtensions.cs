//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Tilkee
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class TilkeeActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tilkee")]
        public IBodyWorkflowAction<ProjectCreateResponse> ProjectCreate(Expression<Func<string>> bodyprojectid = null, Expression<Func<string>> bodyprojectname = null, Expression<Func<bool>> bodyprojectcanBeDownloaded = null, Expression<Func<bool>> bodyprojectconsultable = null, Expression<Func<string>> bodyprojectconsultableUntil = null, Expression<Func<string[]>> bodyprojecttags = null, Expression<Func<JToken[]>> bodyprojectcollaborators = null, Expression<Func<bool>> bodyprojectisTemplate = null, Expression<Func<string>> bodyprojectexternalId = null, Expression<Func<int>> bodyprojectthemeid = null, Expression<Func<bodydocumentsInputItem[]>> bodydocuments = null, Expression<Func<bodypersonInputItem[]>> bodyperson = null)
        {
            var __workflow_bodyprojectid = bodyprojectid == null ? null : WorkflowExpression.Compile(bodyprojectid);
            WorkflowExpression.Validate(__workflow_bodyprojectid, nameof(bodyprojectid), required: false);
            var __workflow_bodyprojectname = bodyprojectname == null ? null : WorkflowExpression.Compile(bodyprojectname);
            WorkflowExpression.Validate(__workflow_bodyprojectname, nameof(bodyprojectname), required: false);
            var __workflow_bodyprojectcanBeDownloaded = bodyprojectcanBeDownloaded == null ? null : WorkflowExpression.Compile(bodyprojectcanBeDownloaded);
            WorkflowExpression.Validate(__workflow_bodyprojectcanBeDownloaded, nameof(bodyprojectcanBeDownloaded), required: false);
            var __workflow_bodyprojectconsultable = bodyprojectconsultable == null ? null : WorkflowExpression.Compile(bodyprojectconsultable);
            WorkflowExpression.Validate(__workflow_bodyprojectconsultable, nameof(bodyprojectconsultable), required: false);
            var __workflow_bodyprojectconsultableUntil = bodyprojectconsultableUntil == null ? null : WorkflowExpression.Compile(bodyprojectconsultableUntil);
            WorkflowExpression.Validate(__workflow_bodyprojectconsultableUntil, nameof(bodyprojectconsultableUntil), required: false);
            var __workflow_bodyprojecttags = bodyprojecttags == null ? null : WorkflowExpression.Compile(bodyprojecttags);
            WorkflowExpression.Validate(__workflow_bodyprojecttags, nameof(bodyprojecttags), required: false);
            var __workflow_bodyprojectcollaborators = bodyprojectcollaborators == null ? null : WorkflowExpression.Compile(bodyprojectcollaborators);
            WorkflowExpression.Validate(__workflow_bodyprojectcollaborators, nameof(bodyprojectcollaborators), required: false);
            var __workflow_bodyprojectisTemplate = bodyprojectisTemplate == null ? null : WorkflowExpression.Compile(bodyprojectisTemplate);
            WorkflowExpression.Validate(__workflow_bodyprojectisTemplate, nameof(bodyprojectisTemplate), required: false);
            var __workflow_bodyprojectexternalId = bodyprojectexternalId == null ? null : WorkflowExpression.Compile(bodyprojectexternalId);
            WorkflowExpression.Validate(__workflow_bodyprojectexternalId, nameof(bodyprojectexternalId), required: false);
            var __workflow_bodyprojectthemeid = bodyprojectthemeid == null ? null : WorkflowExpression.Compile(bodyprojectthemeid);
            WorkflowExpression.Validate(__workflow_bodyprojectthemeid, nameof(bodyprojectthemeid), required: false);
            var __workflow_bodydocuments = bodydocuments == null ? null : WorkflowExpression.Compile(bodydocuments);
            WorkflowExpression.Validate(__workflow_bodydocuments, nameof(bodydocuments), required: false);
            var __workflow_bodyperson = bodyperson == null ? null : WorkflowExpression.Compile(bodyperson);
            WorkflowExpression.Validate(__workflow_bodyperson, nameof(bodyperson), required: false);
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
                if (__workflow_bodyprojectid != null)
                {
                    projectObject["id"] = ExpressionConverter.ConvertO(__workflow_bodyprojectid);
                    projectObjectpropCount++;
                }

                if (__workflow_bodyprojectname != null)
                {
                    projectObject["name"] = ExpressionConverter.ConvertO(__workflow_bodyprojectname);
                    projectObjectpropCount++;
                }

                if (__workflow_bodyprojectcanBeDownloaded != null)
                {
                    projectObject["can_be_downloaded"] = ExpressionConverter.ConvertO(__workflow_bodyprojectcanBeDownloaded);
                    projectObjectpropCount++;
                }

                if (__workflow_bodyprojectconsultable != null)
                {
                    if (__workflow_bodyprojectconsultable != null)
                    {
                        projectObject["consultable"] = ExpressionConverter.ConvertO(__workflow_bodyprojectconsultable);
                        projectObjectpropCount++;
                    }

                    projectObjectpropCount++;
                }
                else
                {
                    projectObject["consultable"] = true;
                    projectObjectpropCount++;
                }

                if (__workflow_bodyprojectconsultableUntil != null)
                {
                    projectObject["consultable_until"] = ExpressionConverter.ConvertO(__workflow_bodyprojectconsultableUntil);
                    projectObjectpropCount++;
                }

                if (__workflow_bodyprojecttags != null)
                {
                    projectObject["tags"] = ExpressionConverter.ConvertO(__workflow_bodyprojecttags);
                    projectObjectpropCount++;
                }

                if (__workflow_bodyprojectcollaborators != null)
                {
                    projectObject["collaborators"] = ExpressionConverter.ConvertO(__workflow_bodyprojectcollaborators);
                    projectObjectpropCount++;
                }

                if (__workflow_bodyprojectisTemplate != null)
                {
                    if (__workflow_bodyprojectisTemplate != null)
                    {
                        projectObject["is_template"] = ExpressionConverter.ConvertO(__workflow_bodyprojectisTemplate);
                        projectObjectpropCount++;
                    }

                    projectObjectpropCount++;
                }
                else
                {
                    projectObject["is_template"] = false;
                    projectObjectpropCount++;
                }

                if (__workflow_bodyprojectexternalId != null)
                {
                    projectObject["external_id"] = ExpressionConverter.ConvertO(__workflow_bodyprojectexternalId);
                    projectObjectpropCount++;
                }

                var themeObject = new JObject();
                var themeObjectpropCount = 0;
                if (__workflow_bodyprojectthemeid != null)
                {
                    themeObject["id"] = ExpressionConverter.ConvertO(__workflow_bodyprojectthemeid);
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

                if (__workflow_bodydocuments != null)
                {
                    body["documents"] = ExpressionConverter.ConvertO(__workflow_bodydocuments);
                    bodypropCount++;
                }

                if (__workflow_bodyperson != null)
                {
                    body["person"] = ExpressionConverter.ConvertO(__workflow_bodyperson);
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
        public IBodyWorkflowAction<ProjectListResponse> ProjectList(Expression<Func<int>> limit, Expression<Func<int>> offset, Expression<Func<string>> order, Expression<Func<bool>> isTemplate, Expression<Func<bool>> isOwner, Expression<Func<string>> tags = null, Expression<Func<string>> tagOperator = null, Expression<Func<string>> search = null)
        {
            var __workflow_limit = limit == null ? null : WorkflowExpression.Compile(limit);
            WorkflowExpression.Validate(__workflow_limit, nameof(limit), required: true);
            var __workflow_offset = offset == null ? null : WorkflowExpression.Compile(offset);
            WorkflowExpression.Validate(__workflow_offset, nameof(offset), required: true);
            var __workflow_order = order == null ? null : WorkflowExpression.Compile(order);
            WorkflowExpression.Validate(__workflow_order, nameof(order), required: true);
            var __workflow_isTemplate = isTemplate == null ? null : WorkflowExpression.Compile(isTemplate);
            WorkflowExpression.Validate(__workflow_isTemplate, nameof(isTemplate), required: true);
            var __workflow_isOwner = isOwner == null ? null : WorkflowExpression.Compile(isOwner);
            WorkflowExpression.Validate(__workflow_isOwner, nameof(isOwner), required: true);
            var __workflow_tags = tags == null ? null : WorkflowExpression.Compile(tags);
            WorkflowExpression.Validate(__workflow_tags, nameof(tags), required: false);
            var __workflow_tagOperator = tagOperator == null ? null : WorkflowExpression.Compile(tagOperator);
            WorkflowExpression.Validate(__workflow_tagOperator, nameof(tagOperator), required: false);
            var __workflow_search = search == null ? null : WorkflowExpression.Compile(search);
            WorkflowExpression.Validate(__workflow_search, nameof(search), required: false);
            return new DeferredBodyAction<ProjectListResponse>(() =>
            {
                var apiCallPath = "/projects";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                callPayload.Queries["order"] = ExpressionConverter.Convert(__workflow_order);
                callPayload.Queries["is_template"] = ExpressionConverter.Convert(__workflow_isTemplate);
                if (__workflow_tags != null)
                    callPayload.Queries["tags"] = ExpressionConverter.Convert(__workflow_tags);
                if (__workflow_tagOperator != null)
                    callPayload.Queries["tagOperator"] = ExpressionConverter.Convert(__workflow_tagOperator);
                callPayload.Queries["is_owner"] = ExpressionConverter.Convert(__workflow_isOwner);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["x_tilk_ref"] = Convert.ToString("PowerAutomate");
                return new ApiConnectionAction<ProjectListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tilkee")]
        public IBodyWorkflowAction<ProjectGetResponse> ProjectGet(Expression<Func<string>> id)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            return new DeferredBodyAction<ProjectGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/projects/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
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
        public IBodyWorkflowAction<ProjectUpdateResponse> ProjectUpdate(Expression<Func<string>> id, Expression<Func<string>> bodyname = null, Expression<Func<bool>> bodycanBeDownloaded = null, Expression<Func<bool>> bodyconsultable = null, Expression<Func<string>> bodyconsultableUntil = null, Expression<Func<string>> bodyduration = null, Expression<Func<string>> bodyexternalId = null, Expression<Func<bool>> bodystarred = null, Expression<Func<string[]>> bodytags = null, Expression<Func<bodyverdictInput>> bodyverdict = null, Expression<Func<JToken[]>> bodycollaborators = null, Expression<Func<bool>> bodyisTemplate = null, Expression<Func<int>> bodyvcardId = null, Expression<Func<bool>> bodyalertOn = null, Expression<Func<string[]>> bodyemailCible = null, Expression<Func<int>> bodythemeid = null)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            var __workflow_bodyname = bodyname == null ? null : WorkflowExpression.Compile(bodyname);
            WorkflowExpression.Validate(__workflow_bodyname, nameof(bodyname), required: false);
            var __workflow_bodycanBeDownloaded = bodycanBeDownloaded == null ? null : WorkflowExpression.Compile(bodycanBeDownloaded);
            WorkflowExpression.Validate(__workflow_bodycanBeDownloaded, nameof(bodycanBeDownloaded), required: false);
            var __workflow_bodyconsultable = bodyconsultable == null ? null : WorkflowExpression.Compile(bodyconsultable);
            WorkflowExpression.Validate(__workflow_bodyconsultable, nameof(bodyconsultable), required: false);
            var __workflow_bodyconsultableUntil = bodyconsultableUntil == null ? null : WorkflowExpression.Compile(bodyconsultableUntil);
            WorkflowExpression.Validate(__workflow_bodyconsultableUntil, nameof(bodyconsultableUntil), required: false);
            var __workflow_bodyduration = bodyduration == null ? null : WorkflowExpression.Compile(bodyduration);
            WorkflowExpression.Validate(__workflow_bodyduration, nameof(bodyduration), required: false);
            var __workflow_bodyexternalId = bodyexternalId == null ? null : WorkflowExpression.Compile(bodyexternalId);
            WorkflowExpression.Validate(__workflow_bodyexternalId, nameof(bodyexternalId), required: false);
            var __workflow_bodystarred = bodystarred == null ? null : WorkflowExpression.Compile(bodystarred);
            WorkflowExpression.Validate(__workflow_bodystarred, nameof(bodystarred), required: false);
            var __workflow_bodytags = bodytags == null ? null : WorkflowExpression.Compile(bodytags);
            WorkflowExpression.Validate(__workflow_bodytags, nameof(bodytags), required: false);
            var __workflow_bodyverdict = bodyverdict == null ? null : WorkflowExpression.Compile(bodyverdict);
            WorkflowExpression.Validate(__workflow_bodyverdict, nameof(bodyverdict), required: false);
            var __workflow_bodycollaborators = bodycollaborators == null ? null : WorkflowExpression.Compile(bodycollaborators);
            WorkflowExpression.Validate(__workflow_bodycollaborators, nameof(bodycollaborators), required: false);
            var __workflow_bodyisTemplate = bodyisTemplate == null ? null : WorkflowExpression.Compile(bodyisTemplate);
            WorkflowExpression.Validate(__workflow_bodyisTemplate, nameof(bodyisTemplate), required: false);
            var __workflow_bodyvcardId = bodyvcardId == null ? null : WorkflowExpression.Compile(bodyvcardId);
            WorkflowExpression.Validate(__workflow_bodyvcardId, nameof(bodyvcardId), required: false);
            var __workflow_bodyalertOn = bodyalertOn == null ? null : WorkflowExpression.Compile(bodyalertOn);
            WorkflowExpression.Validate(__workflow_bodyalertOn, nameof(bodyalertOn), required: false);
            var __workflow_bodyemailCible = bodyemailCible == null ? null : WorkflowExpression.Compile(bodyemailCible);
            WorkflowExpression.Validate(__workflow_bodyemailCible, nameof(bodyemailCible), required: false);
            var __workflow_bodythemeid = bodythemeid == null ? null : WorkflowExpression.Compile(bodythemeid);
            WorkflowExpression.Validate(__workflow_bodythemeid, nameof(bodythemeid), required: false);
            return new DeferredBodyAction<ProjectUpdateResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/projects/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["x_tilk_ref"] = Convert.ToString("PowerAutomate");
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodycanBeDownloaded != null)
                {
                    body["can_be_downloaded"] = ExpressionConverter.ConvertO(__workflow_bodycanBeDownloaded);
                    bodypropCount++;
                }

                if (__workflow_bodyconsultable != null)
                {
                    body["consultable"] = ExpressionConverter.ConvertO(__workflow_bodyconsultable);
                    bodypropCount++;
                }

                if (__workflow_bodyconsultableUntil != null)
                {
                    body["consultable_until"] = ExpressionConverter.ConvertO(__workflow_bodyconsultableUntil);
                    bodypropCount++;
                }

                if (__workflow_bodyduration != null)
                {
                    body["duration"] = ExpressionConverter.ConvertO(__workflow_bodyduration);
                    bodypropCount++;
                }

                if (__workflow_bodyexternalId != null)
                {
                    body["external_id"] = ExpressionConverter.ConvertO(__workflow_bodyexternalId);
                    bodypropCount++;
                }

                if (__workflow_bodystarred != null)
                {
                    body["starred"] = ExpressionConverter.ConvertO(__workflow_bodystarred);
                    bodypropCount++;
                }

                if (__workflow_bodytags != null)
                {
                    body["tags"] = ExpressionConverter.ConvertO(__workflow_bodytags);
                    bodypropCount++;
                }

                if (__workflow_bodyverdict != null)
                {
                    body["verdict"] = ExpressionConverter.ConvertO(__workflow_bodyverdict);
                    bodypropCount++;
                }

                if (__workflow_bodycollaborators != null)
                {
                    body["collaborators"] = ExpressionConverter.ConvertO(__workflow_bodycollaborators);
                    bodypropCount++;
                }

                if (__workflow_bodyisTemplate != null)
                {
                    body["is_template"] = ExpressionConverter.ConvertO(__workflow_bodyisTemplate);
                    bodypropCount++;
                }

                if (__workflow_bodyvcardId != null)
                {
                    body["vcard_id"] = ExpressionConverter.ConvertO(__workflow_bodyvcardId);
                    bodypropCount++;
                }

                if (__workflow_bodyalertOn != null)
                {
                    body["alert_on"] = ExpressionConverter.ConvertO(__workflow_bodyalertOn);
                    bodypropCount++;
                }

                if (__workflow_bodyemailCible != null)
                {
                    body["email_cible"] = ExpressionConverter.ConvertO(__workflow_bodyemailCible);
                    bodypropCount++;
                }

                var themeObject = new JObject();
                var themeObjectpropCount = 0;
                if (__workflow_bodythemeid != null)
                {
                    themeObject["id"] = ExpressionConverter.ConvertO(__workflow_bodythemeid);
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
        public IBodyWorkflowAction<AccessLinkCreateResponse> AccessLinkCreate(Expression<Func<string>> projectId, Expression<Func<bodyaccessLinkInputItem[]>> bodyaccessLink = null)
        {
            var __workflow_projectId = projectId == null ? null : WorkflowExpression.Compile(projectId);
            WorkflowExpression.Validate(__workflow_projectId, nameof(projectId), required: true);
            var __workflow_bodyaccessLink = bodyaccessLink == null ? null : WorkflowExpression.Compile(bodyaccessLink);
            WorkflowExpression.Validate(__workflow_bodyaccessLink, nameof(bodyaccessLink), required: false);
            return new DeferredBodyAction<AccessLinkCreateResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/projects/{0}/tokens", ExpressionConverter.ConvertWithUrlEncoding(__workflow_projectId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["x_tilk_ref"] = Convert.ToString("PowerAutomate");
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyaccessLink != null)
                {
                    body["persons"] = ExpressionConverter.ConvertO(__workflow_bodyaccessLink);
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
        public IBodyWorkflowAction<AddItemToProjectResponseItem[]> AddItemToProject(Expression<Func<string>> projectId, Expression<Func<bodyitemsInputItem[]>> bodyitems = null)
        {
            var __workflow_projectId = projectId == null ? null : WorkflowExpression.Compile(projectId);
            WorkflowExpression.Validate(__workflow_projectId, nameof(projectId), required: true);
            var __workflow_bodyitems = bodyitems == null ? null : WorkflowExpression.Compile(bodyitems);
            WorkflowExpression.Validate(__workflow_bodyitems, nameof(bodyitems), required: false);
            return new DeferredBodyAction<AddItemToProjectResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/projects/{0}/add_items", ExpressionConverter.ConvertWithUrlEncoding(__workflow_projectId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["x_tilk_ref"] = Convert.ToString("PowerAutomate");
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyitems != null)
                {
                    body["items"] = ExpressionConverter.ConvertO(__workflow_bodyitems);
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
        public IBodyWorkflowAction<ItemListResponse> ItemList(Expression<Func<int>> limit, Expression<Func<int>> offset, Expression<Func<string>> tags = null, Expression<Func<string>> tagOperator = null, Expression<Func<string>> search = null)
        {
            var __workflow_limit = limit == null ? null : WorkflowExpression.Compile(limit);
            WorkflowExpression.Validate(__workflow_limit, nameof(limit), required: true);
            var __workflow_offset = offset == null ? null : WorkflowExpression.Compile(offset);
            WorkflowExpression.Validate(__workflow_offset, nameof(offset), required: true);
            var __workflow_tags = tags == null ? null : WorkflowExpression.Compile(tags);
            WorkflowExpression.Validate(__workflow_tags, nameof(tags), required: false);
            var __workflow_tagOperator = tagOperator == null ? null : WorkflowExpression.Compile(tagOperator);
            WorkflowExpression.Validate(__workflow_tagOperator, nameof(tagOperator), required: false);
            var __workflow_search = search == null ? null : WorkflowExpression.Compile(search);
            WorkflowExpression.Validate(__workflow_search, nameof(search), required: false);
            return new DeferredBodyAction<ItemListResponse>(() =>
            {
                var apiCallPath = "/items";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_tags != null)
                    callPayload.Queries["tags"] = ExpressionConverter.Convert(__workflow_tags);
                if (__workflow_tagOperator != null)
                    callPayload.Queries["tagOperator"] = ExpressionConverter.Convert(__workflow_tagOperator);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["x_tilk_ref"] = Convert.ToString("PowerAutomate");
                return new ApiConnectionAction<ItemListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tilkee")]
        public IBodyWorkflowAction<ItemCreateResponseItem[]> ItemCreate(Expression<Func<bodyInputItem[]>> body = null)
        {
            var __workflow_body = body == null ? null : WorkflowExpression.Compile(body);
            WorkflowExpression.Validate(__workflow_body, nameof(body), required: false);
            return new DeferredBodyAction<ItemCreateResponseItem[]>(() =>
            {
                var apiCallPath = "/items";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["x_tilk_ref"] = Convert.ToString("PowerAutomate");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ItemCreateResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tilkee")]
        public IBodyWorkflowAction<DirectUploadInformationResponse> DirectUploadInformation(Expression<Func<string>> filename, Expression<Func<string>> originalFilename, Expression<Func<bool>> checkExisting = null)
        {
            var __workflow_filename = filename == null ? null : WorkflowExpression.Compile(filename);
            WorkflowExpression.Validate(__workflow_filename, nameof(filename), required: true);
            var __workflow_originalFilename = originalFilename == null ? null : WorkflowExpression.Compile(originalFilename);
            WorkflowExpression.Validate(__workflow_originalFilename, nameof(originalFilename), required: true);
            var __workflow_checkExisting = checkExisting == null ? null : WorkflowExpression.Compile(checkExisting);
            WorkflowExpression.Validate(__workflow_checkExisting, nameof(checkExisting), required: false);
            return new DeferredBodyAction<DirectUploadInformationResponse>(() =>
            {
                var apiCallPath = "/direct_upload_data";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["filename"] = ExpressionConverter.Convert(__workflow_filename);
                callPayload.Queries["original_filename"] = ExpressionConverter.Convert(__workflow_originalFilename);
                if (__workflow_checkExisting != null)
                    callPayload.Queries["check_existing"] = ExpressionConverter.Convert(__workflow_checkExisting);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["x_tilk_ref"] = Convert.ToString("PowerAutomate");
                return new ApiConnectionAction<DirectUploadInformationResponse>(callPayload);
            });
        }
    }

    public class TilkeeTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<JToken> OnTilkeeEvent(Expression<Func<bodyruleInput>> bodyrule, Expression<Func<string>> bodyuserId = null, Expression<Func<string>> bodyprojectId = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyrule = bodyrule == null ? null : WorkflowExpression.Compile(bodyrule);
            WorkflowExpression.Validate(__workflow_bodyrule, nameof(bodyrule), required: true);
            var __workflow_bodyuserId = bodyuserId == null ? null : WorkflowExpression.Compile(bodyuserId);
            WorkflowExpression.Validate(__workflow_bodyuserId, nameof(bodyuserId), required: false);
            var __workflow_bodyprojectId = bodyprojectId == null ? null : WorkflowExpression.Compile(bodyprojectId);
            WorkflowExpression.Validate(__workflow_bodyprojectId, nameof(bodyprojectId), required: false);
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
                body["rule"] = ExpressionConverter.ConvertO(__workflow_bodyrule);
                if (__workflow_bodyuserId != null)
                {
                    body["user_id"] = ExpressionConverter.ConvertO(__workflow_bodyuserId);
                    bodypropCount++;
                }

                if (__workflow_bodyprojectId != null)
                {
                    body["project_id"] = ExpressionConverter.ConvertO(__workflow_bodyprojectId);
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

        public IBodyWorkflowTrigger<JToken> OnTilkeeEventEnded(Expression<Func<string>> bodyuserId = null, Expression<Func<string>> bodyprojectId = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyuserId = bodyuserId == null ? null : WorkflowExpression.Compile(bodyuserId);
            WorkflowExpression.Validate(__workflow_bodyuserId, nameof(bodyuserId), required: false);
            var __workflow_bodyprojectId = bodyprojectId == null ? null : WorkflowExpression.Compile(bodyprojectId);
            WorkflowExpression.Validate(__workflow_bodyprojectId, nameof(bodyprojectId), required: false);
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
                if (__workflow_bodyuserId != null)
                {
                    body["user_id"] = ExpressionConverter.ConvertO(__workflow_bodyuserId);
                    bodypropCount++;
                }

                if (__workflow_bodyprojectId != null)
                {
                    body["project_id"] = ExpressionConverter.ConvertO(__workflow_bodyprojectId);
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

        public IBodyWorkflowTrigger<JToken> OnTilkeeEventSigned(Expression<Func<string>> bodyuserId = null, Expression<Func<string>> bodyprojectId = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyuserId = bodyuserId == null ? null : WorkflowExpression.Compile(bodyuserId);
            WorkflowExpression.Validate(__workflow_bodyuserId, nameof(bodyuserId), required: false);
            var __workflow_bodyprojectId = bodyprojectId == null ? null : WorkflowExpression.Compile(bodyprojectId);
            WorkflowExpression.Validate(__workflow_bodyprojectId, nameof(bodyprojectId), required: false);
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
                if (__workflow_bodyuserId != null)
                {
                    body["user_id"] = ExpressionConverter.ConvertO(__workflow_bodyuserId);
                    bodypropCount++;
                }

                if (__workflow_bodyprojectId != null)
                {
                    body["project_id"] = ExpressionConverter.ConvertO(__workflow_bodyprojectId);
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
