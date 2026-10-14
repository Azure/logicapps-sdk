//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pkisigning
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class PkisigningActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pkisigning")]
        public IBodyWorkflowAction<ExtendedSignerModel[]> ActorsList(Expression<Func<string>> requestId, Expression<Func<string>> documentId, Expression<Func<bool>> hasActed = null)
        {
            var __workflow_requestId = requestId == null ? null : WorkflowExpression.Compile(requestId);
            WorkflowExpression.Validate(__workflow_requestId, nameof(requestId), required: true);
            var __workflow_documentId = documentId == null ? null : WorkflowExpression.Compile(documentId);
            WorkflowExpression.Validate(__workflow_documentId, nameof(documentId), required: true);
            var __workflow_hasActed = hasActed == null ? null : WorkflowExpression.Compile(hasActed);
            WorkflowExpression.Validate(__workflow_hasActed, nameof(hasActed), required: false);
            return new DeferredBodyAction<ExtendedSignerModel[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/requests/{0}/documents/{1}/Actors", ExpressionConverter.ConvertWithUrlEncoding(__workflow_requestId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_documentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_hasActed != null)
                    callPayload.Queries["hasActed"] = ExpressionConverter.Convert(__workflow_hasActed);
                return new ApiConnectionAction<ExtendedSignerModel[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pkisigning")]
        public IBodyWorkflowAction<ExtendedSignerModel> ActorsCreate(Expression<Func<string>> requestId, Expression<Func<string>> documentId, Expression<Func<actorModelactionInput>> actorModelaction, Expression<Func<string>> actorModelfirstname, Expression<Func<string>> actorModellastname, Expression<Func<string>> actorModelemail, Expression<Func<string>> actorModelmobile, Expression<Func<string>> actorModeldeadline, Expression<Func<actorModellanguageInput>> actorModellanguage, Expression<Func<bool>> actorModelvalidateRealIdentity, Expression<Func<string>> actorModelprefix = null, Expression<Func<int>> actorModeldossierPersonId = null, Expression<Func<string>> actorModelmessage = null, Expression<Func<string>> actorModelfieldName = null, Expression<Func<string>> actorModelplaceholder = null)
        {
            var __workflow_requestId = requestId == null ? null : WorkflowExpression.Compile(requestId);
            WorkflowExpression.Validate(__workflow_requestId, nameof(requestId), required: true);
            var __workflow_documentId = documentId == null ? null : WorkflowExpression.Compile(documentId);
            WorkflowExpression.Validate(__workflow_documentId, nameof(documentId), required: true);
            var __workflow_actorModelaction = actorModelaction == null ? null : WorkflowExpression.Compile(actorModelaction);
            WorkflowExpression.Validate(__workflow_actorModelaction, nameof(actorModelaction), required: true);
            var __workflow_actorModelfirstname = actorModelfirstname == null ? null : WorkflowExpression.Compile(actorModelfirstname);
            WorkflowExpression.Validate(__workflow_actorModelfirstname, nameof(actorModelfirstname), required: true);
            var __workflow_actorModellastname = actorModellastname == null ? null : WorkflowExpression.Compile(actorModellastname);
            WorkflowExpression.Validate(__workflow_actorModellastname, nameof(actorModellastname), required: true);
            var __workflow_actorModelemail = actorModelemail == null ? null : WorkflowExpression.Compile(actorModelemail);
            WorkflowExpression.Validate(__workflow_actorModelemail, nameof(actorModelemail), required: true);
            var __workflow_actorModelmobile = actorModelmobile == null ? null : WorkflowExpression.Compile(actorModelmobile);
            WorkflowExpression.Validate(__workflow_actorModelmobile, nameof(actorModelmobile), required: true);
            var __workflow_actorModeldeadline = actorModeldeadline == null ? null : WorkflowExpression.Compile(actorModeldeadline);
            WorkflowExpression.Validate(__workflow_actorModeldeadline, nameof(actorModeldeadline), required: true);
            var __workflow_actorModellanguage = actorModellanguage == null ? null : WorkflowExpression.Compile(actorModellanguage);
            WorkflowExpression.Validate(__workflow_actorModellanguage, nameof(actorModellanguage), required: true);
            var __workflow_actorModelvalidateRealIdentity = actorModelvalidateRealIdentity == null ? null : WorkflowExpression.Compile(actorModelvalidateRealIdentity);
            WorkflowExpression.Validate(__workflow_actorModelvalidateRealIdentity, nameof(actorModelvalidateRealIdentity), required: true);
            var __workflow_actorModelprefix = actorModelprefix == null ? null : WorkflowExpression.Compile(actorModelprefix);
            WorkflowExpression.Validate(__workflow_actorModelprefix, nameof(actorModelprefix), required: false);
            var __workflow_actorModeldossierPersonId = actorModeldossierPersonId == null ? null : WorkflowExpression.Compile(actorModeldossierPersonId);
            WorkflowExpression.Validate(__workflow_actorModeldossierPersonId, nameof(actorModeldossierPersonId), required: false);
            var __workflow_actorModelmessage = actorModelmessage == null ? null : WorkflowExpression.Compile(actorModelmessage);
            WorkflowExpression.Validate(__workflow_actorModelmessage, nameof(actorModelmessage), required: false);
            var __workflow_actorModelfieldName = actorModelfieldName == null ? null : WorkflowExpression.Compile(actorModelfieldName);
            WorkflowExpression.Validate(__workflow_actorModelfieldName, nameof(actorModelfieldName), required: false);
            var __workflow_actorModelplaceholder = actorModelplaceholder == null ? null : WorkflowExpression.Compile(actorModelplaceholder);
            WorkflowExpression.Validate(__workflow_actorModelplaceholder, nameof(actorModelplaceholder), required: false);
            return new DeferredBodyAction<ExtendedSignerModel>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/requests/{0}/documents/{1}/Actors", ExpressionConverter.ConvertWithUrlEncoding(__workflow_requestId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_documentId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var actorModel = new JObject();
                var actorModelpropCount = 0;
                actorModelpropCount++;
                actorModel["action"] = ExpressionConverter.ConvertO(__workflow_actorModelaction);
                actorModelpropCount++;
                actorModel["firstname"] = ExpressionConverter.ConvertO(__workflow_actorModelfirstname);
                if (__workflow_actorModelprefix != null)
                {
                    actorModel["prefix"] = ExpressionConverter.ConvertO(__workflow_actorModelprefix);
                    actorModelpropCount++;
                }

                actorModelpropCount++;
                actorModel["lastname"] = ExpressionConverter.ConvertO(__workflow_actorModellastname);
                actorModelpropCount++;
                actorModel["email"] = ExpressionConverter.ConvertO(__workflow_actorModelemail);
                actorModelpropCount++;
                actorModel["mobile"] = ExpressionConverter.ConvertO(__workflow_actorModelmobile);
                actorModelpropCount++;
                actorModel["deadline"] = ExpressionConverter.ConvertO(__workflow_actorModeldeadline);
                actorModelpropCount++;
                actorModel["language"] = ExpressionConverter.ConvertO(__workflow_actorModellanguage);
                actorModelpropCount++;
                actorModel["validateRealIdentity"] = ExpressionConverter.ConvertO(__workflow_actorModelvalidateRealIdentity);
                if (__workflow_actorModeldossierPersonId != null)
                {
                    actorModel["dossierPersonId"] = ExpressionConverter.ConvertO(__workflow_actorModeldossierPersonId);
                    actorModelpropCount++;
                }

                if (__workflow_actorModelmessage != null)
                {
                    actorModel["message"] = ExpressionConverter.ConvertO(__workflow_actorModelmessage);
                    actorModelpropCount++;
                }

                if (__workflow_actorModelfieldName != null)
                {
                    actorModel["fieldName"] = ExpressionConverter.ConvertO(__workflow_actorModelfieldName);
                    actorModelpropCount++;
                }

                if (__workflow_actorModelplaceholder != null)
                {
                    actorModel["placeholder"] = ExpressionConverter.ConvertO(__workflow_actorModelplaceholder);
                    actorModelpropCount++;
                }

                actorModel["sigFieldX"] = 0;
                actorModelpropCount++;
                actorModel["sigFieldY"] = 0;
                actorModelpropCount++;
                actorModel["sigFieldH"] = 0;
                actorModelpropCount++;
                actorModel["sigFieldW"] = 0;
                actorModelpropCount++;
                if (actorModelpropCount > 0)
                {
                    callPayload.Body = actorModel;
                }

                return new ApiConnectionAction<ExtendedSignerModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pkisigning")]
        public IBodyWorkflowAction<ExtendedSignerModel> ActorsUpdate(Expression<Func<string>> requestId, Expression<Func<string>> documentId, Expression<Func<string>> actorId, Expression<Func<actorModelModelactionInput>> actorModelModelaction, Expression<Func<string>> actorModelModelfirstname, Expression<Func<string>> actorModelModellastname, Expression<Func<string>> actorModelModelemail, Expression<Func<string>> actorModelModelmobile, Expression<Func<string>> actorModelModeldeadline, Expression<Func<actorModelModellanguageInput>> actorModelModellanguage, Expression<Func<bool>> actorModelModelvalidateRealIdentity, Expression<Func<string>> actorModelModelprefix = null, Expression<Func<int>> actorModelModeldossierPersonId = null, Expression<Func<string>> actorModelModelmessage = null)
        {
            var __workflow_requestId = requestId == null ? null : WorkflowExpression.Compile(requestId);
            WorkflowExpression.Validate(__workflow_requestId, nameof(requestId), required: true);
            var __workflow_documentId = documentId == null ? null : WorkflowExpression.Compile(documentId);
            WorkflowExpression.Validate(__workflow_documentId, nameof(documentId), required: true);
            var __workflow_actorId = actorId == null ? null : WorkflowExpression.Compile(actorId);
            WorkflowExpression.Validate(__workflow_actorId, nameof(actorId), required: true);
            var __workflow_actorModelModelaction = actorModelModelaction == null ? null : WorkflowExpression.Compile(actorModelModelaction);
            WorkflowExpression.Validate(__workflow_actorModelModelaction, nameof(actorModelModelaction), required: true);
            var __workflow_actorModelModelfirstname = actorModelModelfirstname == null ? null : WorkflowExpression.Compile(actorModelModelfirstname);
            WorkflowExpression.Validate(__workflow_actorModelModelfirstname, nameof(actorModelModelfirstname), required: true);
            var __workflow_actorModelModellastname = actorModelModellastname == null ? null : WorkflowExpression.Compile(actorModelModellastname);
            WorkflowExpression.Validate(__workflow_actorModelModellastname, nameof(actorModelModellastname), required: true);
            var __workflow_actorModelModelemail = actorModelModelemail == null ? null : WorkflowExpression.Compile(actorModelModelemail);
            WorkflowExpression.Validate(__workflow_actorModelModelemail, nameof(actorModelModelemail), required: true);
            var __workflow_actorModelModelmobile = actorModelModelmobile == null ? null : WorkflowExpression.Compile(actorModelModelmobile);
            WorkflowExpression.Validate(__workflow_actorModelModelmobile, nameof(actorModelModelmobile), required: true);
            var __workflow_actorModelModeldeadline = actorModelModeldeadline == null ? null : WorkflowExpression.Compile(actorModelModeldeadline);
            WorkflowExpression.Validate(__workflow_actorModelModeldeadline, nameof(actorModelModeldeadline), required: true);
            var __workflow_actorModelModellanguage = actorModelModellanguage == null ? null : WorkflowExpression.Compile(actorModelModellanguage);
            WorkflowExpression.Validate(__workflow_actorModelModellanguage, nameof(actorModelModellanguage), required: true);
            var __workflow_actorModelModelvalidateRealIdentity = actorModelModelvalidateRealIdentity == null ? null : WorkflowExpression.Compile(actorModelModelvalidateRealIdentity);
            WorkflowExpression.Validate(__workflow_actorModelModelvalidateRealIdentity, nameof(actorModelModelvalidateRealIdentity), required: true);
            var __workflow_actorModelModelprefix = actorModelModelprefix == null ? null : WorkflowExpression.Compile(actorModelModelprefix);
            WorkflowExpression.Validate(__workflow_actorModelModelprefix, nameof(actorModelModelprefix), required: false);
            var __workflow_actorModelModeldossierPersonId = actorModelModeldossierPersonId == null ? null : WorkflowExpression.Compile(actorModelModeldossierPersonId);
            WorkflowExpression.Validate(__workflow_actorModelModeldossierPersonId, nameof(actorModelModeldossierPersonId), required: false);
            var __workflow_actorModelModelmessage = actorModelModelmessage == null ? null : WorkflowExpression.Compile(actorModelModelmessage);
            WorkflowExpression.Validate(__workflow_actorModelModelmessage, nameof(actorModelModelmessage), required: false);
            return new DeferredBodyAction<ExtendedSignerModel>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/requests/{0}/documents/{1}/Actors/{2}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_requestId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_documentId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_actorId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var actorModelModel = new JObject();
                var actorModelModelpropCount = 0;
                actorModelModelpropCount++;
                actorModelModel["action"] = ExpressionConverter.ConvertO(__workflow_actorModelModelaction);
                actorModelModelpropCount++;
                actorModelModel["firstname"] = ExpressionConverter.ConvertO(__workflow_actorModelModelfirstname);
                if (__workflow_actorModelModelprefix != null)
                {
                    actorModelModel["prefix"] = ExpressionConverter.ConvertO(__workflow_actorModelModelprefix);
                    actorModelModelpropCount++;
                }

                actorModelModelpropCount++;
                actorModelModel["lastname"] = ExpressionConverter.ConvertO(__workflow_actorModelModellastname);
                actorModelModelpropCount++;
                actorModelModel["email"] = ExpressionConverter.ConvertO(__workflow_actorModelModelemail);
                actorModelModelpropCount++;
                actorModelModel["mobile"] = ExpressionConverter.ConvertO(__workflow_actorModelModelmobile);
                actorModelModelpropCount++;
                actorModelModel["deadline"] = ExpressionConverter.ConvertO(__workflow_actorModelModeldeadline);
                actorModelModelpropCount++;
                actorModelModel["language"] = ExpressionConverter.ConvertO(__workflow_actorModelModellanguage);
                actorModelModelpropCount++;
                actorModelModel["validateRealIdentity"] = ExpressionConverter.ConvertO(__workflow_actorModelModelvalidateRealIdentity);
                if (__workflow_actorModelModeldossierPersonId != null)
                {
                    actorModelModel["dossierPersonId"] = ExpressionConverter.ConvertO(__workflow_actorModelModeldossierPersonId);
                    actorModelModelpropCount++;
                }

                if (__workflow_actorModelModelmessage != null)
                {
                    actorModelModel["message"] = ExpressionConverter.ConvertO(__workflow_actorModelModelmessage);
                    actorModelModelpropCount++;
                }

                if (actorModelModelpropCount > 0)
                {
                    callPayload.Body = actorModelModel;
                }

                return new ApiConnectionAction<ExtendedSignerModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pkisigning")]
        public IBodyWorkflowAction<ExtendedSignerModel> ActorsGet(Expression<Func<string>> requestId, Expression<Func<string>> documentId, Expression<Func<string>> actorId)
        {
            var __workflow_requestId = requestId == null ? null : WorkflowExpression.Compile(requestId);
            WorkflowExpression.Validate(__workflow_requestId, nameof(requestId), required: true);
            var __workflow_documentId = documentId == null ? null : WorkflowExpression.Compile(documentId);
            WorkflowExpression.Validate(__workflow_documentId, nameof(documentId), required: true);
            var __workflow_actorId = actorId == null ? null : WorkflowExpression.Compile(actorId);
            WorkflowExpression.Validate(__workflow_actorId, nameof(actorId), required: true);
            return new DeferredBodyAction<ExtendedSignerModel>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/requests/{0}/documents/{1}/Actors/{2}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_requestId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_documentId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_actorId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ExtendedSignerModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pkisigning")]
        public IWorkflowAction ActorsDelete(Expression<Func<string>> requestId, Expression<Func<string>> documentId, Expression<Func<string>> actorId)
        {
            var __workflow_requestId = requestId == null ? null : WorkflowExpression.Compile(requestId);
            WorkflowExpression.Validate(__workflow_requestId, nameof(requestId), required: true);
            var __workflow_documentId = documentId == null ? null : WorkflowExpression.Compile(documentId);
            WorkflowExpression.Validate(__workflow_documentId, nameof(documentId), required: true);
            var __workflow_actorId = actorId == null ? null : WorkflowExpression.Compile(actorId);
            WorkflowExpression.Validate(__workflow_actorId, nameof(actorId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/requests/{0}/documents/{1}/Actors/{2}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_requestId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_documentId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_actorId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pkisigning")]
        public IBodyWorkflowAction<ExtendedSignerModel[]> ActorsRequestActors(Expression<Func<string>> requestId, Expression<Func<bool>> hasActed = null)
        {
            var __workflow_requestId = requestId == null ? null : WorkflowExpression.Compile(requestId);
            WorkflowExpression.Validate(__workflow_requestId, nameof(requestId), required: true);
            var __workflow_hasActed = hasActed == null ? null : WorkflowExpression.Compile(hasActed);
            WorkflowExpression.Validate(__workflow_hasActed, nameof(hasActed), required: false);
            return new DeferredBodyAction<ExtendedSignerModel[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/requests/{0}/Actors", ExpressionConverter.ConvertWithUrlEncoding(__workflow_requestId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_hasActed != null)
                    callPayload.Queries["hasActed"] = ExpressionConverter.Convert(__workflow_hasActed);
                return new ApiConnectionAction<ExtendedSignerModel[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pkisigning")]
        public IWorkflowAction ActorsResendCurrentInvite(Expression<Func<string>> requestId)
        {
            var __workflow_requestId = requestId == null ? null : WorkflowExpression.Compile(requestId);
            WorkflowExpression.Validate(__workflow_requestId, nameof(requestId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/requests/{0}/Actors/ResendCurrentInvite", ExpressionConverter.ConvertWithUrlEncoding(__workflow_requestId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pkisigning")]
        public IWorkflowAction ActorsWithdrawCurrentInvite(Expression<Func<string>> requestId)
        {
            var __workflow_requestId = requestId == null ? null : WorkflowExpression.Compile(requestId);
            WorkflowExpression.Validate(__workflow_requestId, nameof(requestId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/requests/{0}/Actors/WithdrawCurrentInvite", ExpressionConverter.ConvertWithUrlEncoding(__workflow_requestId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pkisigning")]
        public IBodyWorkflowAction<DocumentMetaDataModel> DocumentsGet(Expression<Func<string>> requestId, Expression<Func<string>> documentId)
        {
            var __workflow_requestId = requestId == null ? null : WorkflowExpression.Compile(requestId);
            WorkflowExpression.Validate(__workflow_requestId, nameof(requestId), required: true);
            var __workflow_documentId = documentId == null ? null : WorkflowExpression.Compile(documentId);
            WorkflowExpression.Validate(__workflow_documentId, nameof(documentId), required: true);
            return new DeferredBodyAction<DocumentMetaDataModel>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/requests/{0}/documents/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_requestId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_documentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DocumentMetaDataModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pkisigning")]
        public IBodyWorkflowAction<DocumentMetaDataModel> DocumentsUpdate(Expression<Func<string>> requestId, Expression<Func<string>> documentId, Expression<Func<metadatadocumentTypeInput>> metadatadocumentType, Expression<Func<string>> metadataname = null, Expression<Func<string>> metadatafilename = null)
        {
            var __workflow_requestId = requestId == null ? null : WorkflowExpression.Compile(requestId);
            WorkflowExpression.Validate(__workflow_requestId, nameof(requestId), required: true);
            var __workflow_documentId = documentId == null ? null : WorkflowExpression.Compile(documentId);
            WorkflowExpression.Validate(__workflow_documentId, nameof(documentId), required: true);
            var __workflow_metadatadocumentType = metadatadocumentType == null ? null : WorkflowExpression.Compile(metadatadocumentType);
            WorkflowExpression.Validate(__workflow_metadatadocumentType, nameof(metadatadocumentType), required: true);
            var __workflow_metadataname = metadataname == null ? null : WorkflowExpression.Compile(metadataname);
            WorkflowExpression.Validate(__workflow_metadataname, nameof(metadataname), required: false);
            var __workflow_metadatafilename = metadatafilename == null ? null : WorkflowExpression.Compile(metadatafilename);
            WorkflowExpression.Validate(__workflow_metadatafilename, nameof(metadatafilename), required: false);
            return new DeferredBodyAction<DocumentMetaDataModel>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/requests/{0}/documents/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_requestId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_documentId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var metadata = new JObject();
                var metadatapropCount = 0;
                if (__workflow_metadataname != null)
                {
                    metadata["name"] = ExpressionConverter.ConvertO(__workflow_metadataname);
                    metadatapropCount++;
                }

                if (__workflow_metadatafilename != null)
                {
                    metadata["filename"] = ExpressionConverter.ConvertO(__workflow_metadatafilename);
                    metadatapropCount++;
                }

                metadatapropCount++;
                metadata["documentType"] = ExpressionConverter.ConvertO(__workflow_metadatadocumentType);
                if (metadatapropCount > 0)
                {
                    callPayload.Body = metadata;
                }

                return new ApiConnectionAction<DocumentMetaDataModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pkisigning")]
        public IWorkflowAction DocumentsDelete(Expression<Func<string>> requestId, Expression<Func<string>> documentId)
        {
            var __workflow_requestId = requestId == null ? null : WorkflowExpression.Compile(requestId);
            WorkflowExpression.Validate(__workflow_requestId, nameof(requestId), required: true);
            var __workflow_documentId = documentId == null ? null : WorkflowExpression.Compile(documentId);
            WorkflowExpression.Validate(__workflow_documentId, nameof(documentId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/requests/{0}/documents/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_requestId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_documentId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pkisigning")]
        public IBodyWorkflowAction<OrganisationWorkgroup[]> OrganisationsGetWorkgroups(Expression<Func<string>> organisationId)
        {
            var __workflow_organisationId = organisationId == null ? null : WorkflowExpression.Compile(organisationId);
            WorkflowExpression.Validate(__workflow_organisationId, nameof(organisationId), required: true);
            return new DeferredBodyAction<OrganisationWorkgroup[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Organisations/{0}/workgroups", ExpressionConverter.ConvertWithUrlEncoding(__workflow_organisationId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<OrganisationWorkgroup[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pkisigning")]
        public IBodyWorkflowAction<OrganisationWorkgroup[]> OrganisationsGetWorkgroupsByUser(Expression<Func<string>> organisationId, Expression<Func<string>> modelusername)
        {
            var __workflow_organisationId = organisationId == null ? null : WorkflowExpression.Compile(organisationId);
            WorkflowExpression.Validate(__workflow_organisationId, nameof(organisationId), required: true);
            var __workflow_modelusername = modelusername == null ? null : WorkflowExpression.Compile(modelusername);
            WorkflowExpression.Validate(__workflow_modelusername, nameof(modelusername), required: true);
            return new DeferredBodyAction<OrganisationWorkgroup[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Organisations/{0}/workgroups", ExpressionConverter.ConvertWithUrlEncoding(__workflow_organisationId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var model = new JObject();
                var modelpropCount = 0;
                modelpropCount++;
                model["username"] = ExpressionConverter.ConvertO(__workflow_modelusername);
                if (modelpropCount > 0)
                {
                    callPayload.Body = model;
                }

                return new ApiConnectionAction<OrganisationWorkgroup[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pkisigning")]
        public IBodyWorkflowAction<RequestModel> RequestsCreate(Expression<Func<string>> modelname, Expression<Func<int>> modelclearancelevel, Expression<Func<string>> modelworkgroupId = null, Expression<Func<string>> modelowner = null)
        {
            var __workflow_modelname = modelname == null ? null : WorkflowExpression.Compile(modelname);
            WorkflowExpression.Validate(__workflow_modelname, nameof(modelname), required: true);
            var __workflow_modelclearancelevel = modelclearancelevel == null ? null : WorkflowExpression.Compile(modelclearancelevel);
            WorkflowExpression.Validate(__workflow_modelclearancelevel, nameof(modelclearancelevel), required: true);
            var __workflow_modelworkgroupId = modelworkgroupId == null ? null : WorkflowExpression.Compile(modelworkgroupId);
            WorkflowExpression.Validate(__workflow_modelworkgroupId, nameof(modelworkgroupId), required: false);
            var __workflow_modelowner = modelowner == null ? null : WorkflowExpression.Compile(modelowner);
            WorkflowExpression.Validate(__workflow_modelowner, nameof(modelowner), required: false);
            return new DeferredBodyAction<RequestModel>(() =>
            {
                var apiCallPath = "/requests";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var model = new JObject();
                var modelpropCount = 0;
                modelpropCount++;
                model["name"] = ExpressionConverter.ConvertO(__workflow_modelname);
                if (__workflow_modelworkgroupId != null)
                {
                    model["workgroupId"] = ExpressionConverter.ConvertO(__workflow_modelworkgroupId);
                    modelpropCount++;
                }

                modelpropCount++;
                model["clearancelevel"] = ExpressionConverter.ConvertO(__workflow_modelclearancelevel);
                if (__workflow_modelowner != null)
                {
                    model["owner"] = ExpressionConverter.ConvertO(__workflow_modelowner);
                    modelpropCount++;
                }

                if (modelpropCount > 0)
                {
                    callPayload.Body = model;
                }

                return new ApiConnectionAction<RequestModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pkisigning")]
        public IBodyWorkflowAction<RequestModel> RequestsGet(Expression<Func<string>> requestId, Expression<Func<string>> callbackAuthenticationKey = null)
        {
            var __workflow_requestId = requestId == null ? null : WorkflowExpression.Compile(requestId);
            WorkflowExpression.Validate(__workflow_requestId, nameof(requestId), required: true);
            var __workflow_callbackAuthenticationKey = callbackAuthenticationKey == null ? null : WorkflowExpression.Compile(callbackAuthenticationKey);
            WorkflowExpression.Validate(__workflow_callbackAuthenticationKey, nameof(callbackAuthenticationKey), required: false);
            return new DeferredBodyAction<RequestModel>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/requests/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_requestId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_callbackAuthenticationKey != null)
                    callPayload.Queries["callbackAuthenticationKey"] = ExpressionConverter.Convert(__workflow_callbackAuthenticationKey);
                return new ApiConnectionAction<RequestModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pkisigning")]
        public IBodyWorkflowAction<RequestModel> RequestsUpdate(Expression<Func<string>> requestId, Expression<Func<string>> modelname, Expression<Func<int>> modelclearancelevel, Expression<Func<string>> modelworkgroupId = null, Expression<Func<string>> modelowner = null)
        {
            var __workflow_requestId = requestId == null ? null : WorkflowExpression.Compile(requestId);
            WorkflowExpression.Validate(__workflow_requestId, nameof(requestId), required: true);
            var __workflow_modelname = modelname == null ? null : WorkflowExpression.Compile(modelname);
            WorkflowExpression.Validate(__workflow_modelname, nameof(modelname), required: true);
            var __workflow_modelclearancelevel = modelclearancelevel == null ? null : WorkflowExpression.Compile(modelclearancelevel);
            WorkflowExpression.Validate(__workflow_modelclearancelevel, nameof(modelclearancelevel), required: true);
            var __workflow_modelworkgroupId = modelworkgroupId == null ? null : WorkflowExpression.Compile(modelworkgroupId);
            WorkflowExpression.Validate(__workflow_modelworkgroupId, nameof(modelworkgroupId), required: false);
            var __workflow_modelowner = modelowner == null ? null : WorkflowExpression.Compile(modelowner);
            WorkflowExpression.Validate(__workflow_modelowner, nameof(modelowner), required: false);
            return new DeferredBodyAction<RequestModel>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/requests/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_requestId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var model = new JObject();
                var modelpropCount = 0;
                modelpropCount++;
                model["name"] = ExpressionConverter.ConvertO(__workflow_modelname);
                if (__workflow_modelworkgroupId != null)
                {
                    model["workgroupId"] = ExpressionConverter.ConvertO(__workflow_modelworkgroupId);
                    modelpropCount++;
                }

                modelpropCount++;
                model["clearancelevel"] = ExpressionConverter.ConvertO(__workflow_modelclearancelevel);
                if (__workflow_modelowner != null)
                {
                    model["owner"] = ExpressionConverter.ConvertO(__workflow_modelowner);
                    modelpropCount++;
                }

                if (modelpropCount > 0)
                {
                    callPayload.Body = model;
                }

                return new ApiConnectionAction<RequestModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pkisigning")]
        public IWorkflowAction RequestsDelete(Expression<Func<string>> requestId)
        {
            var __workflow_requestId = requestId == null ? null : WorkflowExpression.Compile(requestId);
            WorkflowExpression.Validate(__workflow_requestId, nameof(requestId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/requests/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_requestId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pkisigning")]
        public IBodyWorkflowAction<object> RequestsDownload(Expression<Func<string>> requestId)
        {
            var __workflow_requestId = requestId == null ? null : WorkflowExpression.Compile(requestId);
            WorkflowExpression.Validate(__workflow_requestId, nameof(requestId), required: true);
            return new DeferredBodyAction<object>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/requests/{0}/Download", ExpressionConverter.ConvertWithUrlEncoding(__workflow_requestId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<object>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pkisigning")]
        public IWorkflowAction RequestsSend(Expression<Func<string>> requestId)
        {
            var __workflow_requestId = requestId == null ? null : WorkflowExpression.Compile(requestId);
            WorkflowExpression.Validate(__workflow_requestId, nameof(requestId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/requests/{0}/Send", ExpressionConverter.ConvertWithUrlEncoding(__workflow_requestId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class PkisigningTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WebhookResponseModel> WebhooksCreateWebhook(Expression<Func<string[]>> modelevents, Expression<Func<string>> organisationId, FlowRecurrence recurrence = null)
        {
            var __workflow_modelevents = modelevents == null ? null : WorkflowExpression.Compile(modelevents);
            WorkflowExpression.Validate(__workflow_modelevents, nameof(modelevents), required: true);
            var __workflow_organisationId = organisationId == null ? null : WorkflowExpression.Compile(organisationId);
            WorkflowExpression.Validate(__workflow_organisationId, nameof(organisationId), required: true);
            return new DeferredBodyTrigger<WebhookResponseModel>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/organisations/{0}/webhooks", ExpressionConverter.ConvertWithUrlEncoding(__workflow_organisationId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var model = new JObject();
                var modelpropCount = 0;
                modelpropCount++;
                model["Events"] = ExpressionConverter.ConvertO(__workflow_modelevents);
                var configObject = new JObject();
                var configObjectpropCount = 0;
                configObject["url"] = "#{listCallbackUrl()}";
                configObjectpropCount++;
                if (configObjectpropCount > 0)
                {
                    model["Config"] = configObject;
                    modelpropCount++;
                }

                model["Active"] = true;
                modelpropCount++;
                if (modelpropCount > 0)
                {
                    callPayload.Body = model;
                }

                return new ApiConnectionTrigger<WebhookResponseModel>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class ExtendedSignerModel
    {
        [JsonProperty("fieldName")]
        public string FieldName { get; set; }

        [JsonProperty("placeholder")]
        public string Placeholder { get; set; }

        [JsonProperty("sigFieldX")]
        public double SigFieldX { get; set; }

        [JsonProperty("sigFieldY")]
        public double SigFieldY { get; set; }

        [JsonProperty("sigFieldH")]
        public double SigFieldH { get; set; }

        [JsonProperty("sigFieldW")]
        public double SigFieldW { get; set; }

        [JsonProperty("action")]
        public ExtendedSignerModelActionType Action { get; set; }

        [JsonProperty("firstname")]
        public string Firstname { get; set; }

        [JsonProperty("prefix")]
        public string Prefix { get; set; }

        [JsonProperty("lastname")]
        public string Lastname { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("deadline")]
        public string Deadline { get; set; }

        [JsonProperty("language")]
        public ExtendedSignerModelLanguageType Language { get; set; }

        [JsonProperty("validateRealIdentity")]
        public bool ValidateRealIdentity { get; set; }

        [JsonProperty("dossierPersonId")]
        public int DossierPersonId { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("signingDate")]
        public string SigningDate { get; set; }

        [JsonProperty("hasSigned")]
        public bool HasSigned { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("emailActivity")]
        public EmailActivity[] EmailActivity { get; set; }

        [JsonProperty("documentId")]
        public string DocumentId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ExtendedSignerModelActionType
    {
        Sign,
        Download,
        Approve
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ExtendedSignerModelLanguageType
    {
        NL,
        EN
    }

    public class EmailActivity
    {
        [JsonProperty("event")]
        public string Event { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("pkisMessageType")]
        public string PkisMessageType { get; set; }

        [JsonProperty("pkisInviteId")]
        public string PkisInviteId { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum actorModelactionInput
    {
        Sign,
        Download,
        Approve
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum actorModellanguageInput
    {
        NL,
        EN
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum actorModelModelactionInput
    {
        Sign,
        Download,
        Approve
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum actorModelModellanguageInput
    {
        NL,
        EN
    }

    public class DocumentMetaDataModel
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("lastUpdate")]
        public string LastUpdate { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("expires")]
        public string Expires { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("status")]
        public DocumentMetaDataModelStatusType Status { get; set; }

        [JsonProperty("signed")]
        public bool Signed { get; set; }

        [JsonProperty("signatures")]
        public SignatureData[] Signatures { get; set; }

        [JsonProperty("emptySignatureFields")]
        public SignatureField[] EmptySignatureFields { get; set; }

        [JsonProperty("containsBlankSignatureFields")]
        public bool ContainsBlankSignatureFields { get; set; }

        [JsonProperty("actors")]
        public ExtendedSignerModel[] Actors { get; set; }

        [JsonProperty("requestId")]
        public string RequestId { get; set; }

        [JsonProperty("reasons")]
        public string Reasons { get; set; }

        [JsonProperty("signerNote")]
        public string SignerNote { get; set; }

        [JsonProperty("recipientNote")]
        public string RecipientNote { get; set; }

        [JsonProperty("isMyDocument")]
        public bool IsMyDocument { get; set; }

        [JsonProperty("dossierIndex")]
        public int DossierIndex { get; set; }

        [JsonProperty("documentSize")]
        public int DocumentSize { get; set; }

        [JsonProperty("documentType")]
        public DocumentMetaDataModelDocumentTypeType DocumentType { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DocumentMetaDataModelStatusType
    {
        Active,
        Completed,
        Declined,
        Processing,
        Error,
        PendingSbrNexus,
        Withdrawn,
        PendingDigipoort,
        New,
        Filing,
        InvitationExpired,
        Elapsed,
        Expired,
        PendingApproval,
        PendingDownload,
        PendingSignature,
        PendingDetermination
    }

    public class SignatureData
    {
        [JsonProperty("subject")]
        public KeyValuePairOfStringAndString[] Subject { get; set; }

        [JsonProperty("issuer")]
        public KeyValuePairOfStringAndString[] Issuer { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("euQualified")]
        public bool EuQualified { get; set; }

        [JsonProperty("advanced")]
        public bool Advanced { get; set; }

        [JsonProperty("eSeal")]
        public bool ESeal { get; set; }

        [JsonProperty("ipAddress")]
        public string IpAddress { get; set; }

        [JsonProperty("signatureField")]
        public string SignatureField { get; set; }

        [JsonProperty("signatureImage")]
        public string SignatureImage { get; set; }
    }

    public class KeyValuePairOfStringAndString
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class SignatureField
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }

        [JsonProperty("height")]
        public double Height { get; set; }

        [JsonProperty("width")]
        public double Width { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DocumentMetaDataModelDocumentTypeType
    {
        RegularPdf,
        XbrlPublicationVersionAnnualReport,
        XbrlAuditorsReport,
        DetachedSignature,
        XbrlPreparerExtension,
        PdfAudittrail,
        XbrlCompositionStatement,
        XbrlStatutoryVersionAnnualReport,
        DNBStaat,
        RegularXml,
        ReferencedDocument,
        Json,
        JsonSignature,
        GenericTextFile,
        VatDeclaration,
        VatEuRecapitulativeStatement,
        IncomeTaxDeclaration,
        CorporateTaxDeclaration,
        XbrlNexusVersionAnnualReport,
        XbrlAuditorsReportSFO,
        XbrlAssessmentStatement,
        SignatureStylesheet,
        EnvelopingSignatureData,
        PageImage,
        SHA256Hash,
        SHA256Signature,
        Unspecified
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum metadatadocumentTypeInput
    {
        RegularPdf,
        XbrlPublicationVersionAnnualReport,
        XbrlAuditorsReport,
        DetachedSignature,
        XbrlPreparerExtension,
        PdfAudittrail,
        XbrlCompositionStatement,
        XbrlStatutoryVersionAnnualReport,
        DNBStaat,
        RegularXml,
        ReferencedDocument,
        Json,
        JsonSignature,
        GenericTextFile,
        VatDeclaration,
        VatEuRecapitulativeStatement,
        IncomeTaxDeclaration,
        CorporateTaxDeclaration,
        XbrlNexusVersionAnnualReport,
        XbrlAuditorsReportSFO,
        XbrlAssessmentStatement,
        SignatureStylesheet,
        EnvelopingSignatureData,
        PageImage,
        SHA256Hash,
        SHA256Signature,
        Unspecified
    }

    public class OrganisationWorkgroup
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class RequestModel
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("dossierName")]
        public string DossierName { get; set; }

        [JsonProperty("documents")]
        public DocumentModel[] Documents { get; set; }

        [JsonProperty("status")]
        public RequestModelStatusType Status { get; set; }

        [JsonProperty("actors")]
        public ExtendedSignerModel[] Actors { get; set; }

        [JsonProperty("signed")]
        public bool Signed { get; set; }

        [JsonProperty("signatures")]
        public SignatureData[] Signatures { get; set; }

        [JsonProperty("dossierType")]
        public RequestModelDossierTypeType DossierType { get; set; }

        [JsonProperty("reasons")]
        public string Reasons { get; set; }

        [JsonProperty("signerNote")]
        public string SignerNote { get; set; }

        [JsonProperty("recipientNote")]
        public string RecipientNote { get; set; }

        [JsonProperty("accorderNote")]
        public string AccorderNote { get; set; }

        [JsonProperty("expires")]
        public string Expires { get; set; }

        [JsonProperty("emailActivity")]
        public EmailActivity[] EmailActivity { get; set; }

        [JsonProperty("myDossier")]
        public bool MyDossier { get; set; }

        [JsonProperty("taxPaymentStatus")]
        public string TaxPaymentStatus { get; set; }

        [JsonProperty("workgroup")]
        public string Workgroup { get; set; }

        [JsonProperty("clearancelevel")]
        public int Clearancelevel { get; set; }
    }

    public class DocumentModel
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("documentType")]
        public DocumentModelDocumentTypeType DocumentType { get; set; }

        [JsonProperty("dossierIndex")]
        public int DossierIndex { get; set; }

        [JsonProperty("documentstatus")]
        public DocumentModelDocumentstatusType Documentstatus { get; set; }

        [JsonProperty("actors")]
        public SignerModel[] Actors { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DocumentModelDocumentTypeType
    {
        RegularPdf,
        XbrlPublicationVersionAnnualReport,
        XbrlAuditorsReport,
        DetachedSignature,
        XbrlPreparerExtension,
        PdfAudittrail,
        XbrlCompositionStatement,
        XbrlStatutoryVersionAnnualReport,
        DNBStaat,
        RegularXml,
        ReferencedDocument,
        Json,
        JsonSignature,
        GenericTextFile,
        VatDeclaration,
        VatEuRecapitulativeStatement,
        IncomeTaxDeclaration,
        CorporateTaxDeclaration,
        XbrlNexusVersionAnnualReport,
        XbrlAuditorsReportSFO,
        XbrlAssessmentStatement,
        SignatureStylesheet,
        EnvelopingSignatureData,
        PageImage,
        SHA256Hash,
        SHA256Signature,
        Unspecified
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DocumentModelDocumentstatusType
    {
        Active,
        Completed,
        Declined,
        Processing,
        Error,
        PendingSbrNexus,
        Withdrawn,
        PendingDigipoort,
        New,
        Filing,
        InvitationExpired,
        Elapsed,
        Expired,
        PendingApproval,
        PendingDownload,
        PendingSignature,
        PendingDetermination
    }

    public class SignerModel
    {
        [JsonProperty("action")]
        public SignerModelActionType Action { get; set; }

        [JsonProperty("firstname")]
        public string Firstname { get; set; }

        [JsonProperty("prefix")]
        public string Prefix { get; set; }

        [JsonProperty("lastname")]
        public string Lastname { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("deadline")]
        public string Deadline { get; set; }

        [JsonProperty("language")]
        public SignerModelLanguageType Language { get; set; }

        [JsonProperty("validateRealIdentity")]
        public bool ValidateRealIdentity { get; set; }

        [JsonProperty("dossierPersonId")]
        public int DossierPersonId { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("fieldName")]
        public string FieldName { get; set; }

        [JsonProperty("placeholder")]
        public string Placeholder { get; set; }

        [JsonProperty("sigFieldX")]
        public double SigFieldX { get; set; }

        [JsonProperty("sigFieldY")]
        public double SigFieldY { get; set; }

        [JsonProperty("sigFieldH")]
        public double SigFieldH { get; set; }

        [JsonProperty("sigFieldW")]
        public double SigFieldW { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SignerModelActionType
    {
        Sign,
        Download,
        Approve
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SignerModelLanguageType
    {
        NL,
        EN
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum RequestModelStatusType
    {
        Active,
        Completed,
        Declined,
        Processing,
        Error,
        PendingSbrNexus,
        Withdrawn,
        PendingDigipoort,
        New,
        Filing,
        InvitationExpired,
        Expired,
        PendingApproval,
        PendingDownload,
        PendingSignature
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum RequestModelDossierTypeType
    {
        IcpDeclaration,
        IncomeTaxDeclaration,
        VatDeclaration,
        Unknown,
        PDF,
        FinancialStatements,
        SbrAssurance,
        SbrNexusAssurance,
        SbrNexusAnnualReport,
        CorporateTaxDeclaration,
        Incomplete,
        AnnualFinancialFiles
    }

    public class WebhookResponseModel
    {
        [JsonProperty("events")]
        public string[] Events { get; set; }

        [JsonProperty("config")]
        public WebhookConfig Config { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("lastUpdate")]
        public string LastUpdate { get; set; }
    }

    public class WebhookConfig
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Pkisigning;

    public partial class WorkflowManagedActions
    {
        public PkisigningActions Pkisigning(string connectionId) => new PkisigningActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PkisigningTriggers Pkisigning(string connectionId) => new PkisigningTriggers(connectionId);
    }
}
