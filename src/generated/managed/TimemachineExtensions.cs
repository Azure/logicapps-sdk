//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Timemachine
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TimemachineActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<TopicDto, ApiConnectionActionConfiguration> SetTopicQuizSettings(Expression<Func<string>> topicId, Expression<Func<string>> bodyquestionType, Expression<Func<int>> bodycount = null)
        {
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            var __workflow_bodyquestionType = WorkflowExpression.Compile(bodyquestionType, nameof(bodyquestionType), required: true);
            var __workflow_bodycount = WorkflowExpression.Compile(bodycount, nameof(bodycount), required: false);
            return new DeferredBodyAction<TopicDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/topics/{0}/quiz-settings", __workflow_topicId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["questionType"] = ExpressionConverter.ConvertO(__workflow_bodyquestionType);
                if (__workflow_bodycount != null)
                {
                    body["count"] = ExpressionConverter.ConvertO(__workflow_bodycount);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<TopicDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<IntroDto, ApiConnectionActionConfiguration> GetTopicIntro(Expression<Func<string>> topicId)
        {
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            return new DeferredBodyAction<IntroDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/topics/{0}/intro", __workflow_topicId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<IntroDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RemoveTopicIntro(Expression<Func<string>> topicId)
        {
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/topics/{0}/intro", __workflow_topicId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<IntroDto, ApiConnectionActionConfiguration> SetTopicIntro(Expression<Func<string>> topicId, Expression<Func<string>> bodyintroduction = null)
        {
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            var __workflow_bodyintroduction = WorkflowExpression.Compile(bodyintroduction, nameof(bodyintroduction), required: false);
            return new DeferredBodyAction<IntroDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/topics/{0}/intro", __workflow_topicId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyintroduction != null)
                {
                    body["introduction"] = ExpressionConverter.ConvertO(__workflow_bodyintroduction);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<IntroDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<ModuleDetailDto, ApiConnectionActionConfiguration> SetModuleQuizSettings(Expression<Func<string>> moduleId, Expression<Func<string>> bodyquestionType, Expression<Func<int>> bodycount = null)
        {
            var __workflow_moduleId = WorkflowExpression.Compile(moduleId, nameof(moduleId), required: true);
            var __workflow_bodyquestionType = WorkflowExpression.Compile(bodyquestionType, nameof(bodyquestionType), required: true);
            var __workflow_bodycount = WorkflowExpression.Compile(bodycount, nameof(bodycount), required: false);
            return new DeferredBodyAction<ModuleDetailDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/modules/{0}/quiz-settings", __workflow_moduleId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["questionType"] = ExpressionConverter.ConvertO(__workflow_bodyquestionType);
                if (__workflow_bodycount != null)
                {
                    body["count"] = ExpressionConverter.ConvertO(__workflow_bodycount);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ModuleDetailDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<IntroDto, ApiConnectionActionConfiguration> GetModuleIntro(Expression<Func<string>> moduleId)
        {
            var __workflow_moduleId = WorkflowExpression.Compile(moduleId, nameof(moduleId), required: true);
            return new DeferredBodyAction<IntroDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/modules/{0}/intro", __workflow_moduleId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<IntroDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RemoveModuleIntro(Expression<Func<string>> moduleId)
        {
            var __workflow_moduleId = WorkflowExpression.Compile(moduleId, nameof(moduleId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/modules/{0}/intro", __workflow_moduleId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<IntroDto, ApiConnectionActionConfiguration> SetModuleIntro(Expression<Func<string>> moduleId, Expression<Func<string>> bodyintroduction = null)
        {
            var __workflow_moduleId = WorkflowExpression.Compile(moduleId, nameof(moduleId), required: true);
            var __workflow_bodyintroduction = WorkflowExpression.Compile(bodyintroduction, nameof(bodyintroduction), required: false);
            return new DeferredBodyAction<IntroDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/modules/{0}/intro", __workflow_moduleId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyintroduction != null)
                {
                    body["introduction"] = ExpressionConverter.ConvertO(__workflow_bodyintroduction);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<IntroDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<MediaDetailDto, ApiConnectionActionConfiguration> GetMediaItem(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<MediaDetailDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/media/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<MediaDetailDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteMedia(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/media/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<MediaDetailDto, ApiConnectionActionConfiguration> UpdateMediaMetadata(Expression<Func<string>> id, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodydescription = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            return new DeferredBodyAction<MediaDetailDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/media/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<MediaDetailDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<DocumentDetailDto, ApiConnectionActionConfiguration> GetDocument(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<DocumentDetailDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/documents/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DocumentDetailDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteDocument(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/documents/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<DocumentDetailDto, ApiConnectionActionConfiguration> UpdateDocumentMetadata(Expression<Func<string>> id, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodydescription = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            return new DeferredBodyAction<DocumentDetailDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/documents/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<DocumentDetailDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<UserListResponse, ApiConnectionActionConfiguration> ListUsers(Expression<Func<int>> page = null, Expression<Func<int>> size = null, Expression<Func<string>> search = null, Expression<Func<string>> status = null, Expression<Func<string>> departmentIds = null, Expression<Func<string>> roleIds = null, Expression<Func<string>> kind = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            var __workflow_departmentIds = WorkflowExpression.Compile(departmentIds, nameof(departmentIds), required: false);
            var __workflow_roleIds = WorkflowExpression.Compile(roleIds, nameof(roleIds), required: false);
            var __workflow_kind = WorkflowExpression.Compile(kind, nameof(kind), required: false);
            return new DeferredBodyAction<UserListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/users";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(__workflow_status);
                if (__workflow_departmentIds != null)
                    callPayload.Queries["departmentIds"] = ExpressionConverter.Convert(__workflow_departmentIds);
                if (__workflow_roleIds != null)
                    callPayload.Queries["roleIds"] = ExpressionConverter.Convert(__workflow_roleIds);
                if (__workflow_kind != null)
                    callPayload.Queries["kind"] = ExpressionConverter.Convert(__workflow_kind);
                return new ApiConnectionAction<UserListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<UserDto, ApiConnectionActionConfiguration> CreateUser(Expression<Func<string>> bodyemail, Expression<Func<string>> bodyfirstName = null, Expression<Func<string>> bodylastName = null, Expression<Func<bool>> bodyisAdmin = null, Expression<Func<string[]>> bodydepartmentRoleIds = null)
        {
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: true);
            var __workflow_bodyfirstName = WorkflowExpression.Compile(bodyfirstName, nameof(bodyfirstName), required: false);
            var __workflow_bodylastName = WorkflowExpression.Compile(bodylastName, nameof(bodylastName), required: false);
            var __workflow_bodyisAdmin = WorkflowExpression.Compile(bodyisAdmin, nameof(bodyisAdmin), required: false);
            var __workflow_bodydepartmentRoleIds = WorkflowExpression.Compile(bodydepartmentRoleIds, nameof(bodydepartmentRoleIds), required: false);
            return new DeferredBodyAction<UserDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/users";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                if (__workflow_bodyfirstName != null)
                {
                    body["firstName"] = ExpressionConverter.ConvertO(__workflow_bodyfirstName);
                    bodypropCount++;
                }

                if (__workflow_bodylastName != null)
                {
                    body["lastName"] = ExpressionConverter.ConvertO(__workflow_bodylastName);
                    bodypropCount++;
                }

                if (__workflow_bodyisAdmin != null)
                {
                    body["isAdmin"] = ExpressionConverter.ConvertO(__workflow_bodyisAdmin);
                    bodypropCount++;
                }

                if (__workflow_bodydepartmentRoleIds != null)
                {
                    body["departmentRoleIds"] = ExpressionConverter.ConvertO(__workflow_bodydepartmentRoleIds);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UserDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<UserDto, ApiConnectionActionConfiguration> ReactivateUser(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<UserDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/users/{0}/reactivate", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<UserDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<UserDto, ApiConnectionActionConfiguration> DeactivateUser(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<UserDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/users/{0}/deactivate", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<UserDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<QuestionListResponse, ApiConnectionActionConfiguration> ListTopicQuizQuestions(Expression<Func<string>> topicId)
        {
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            return new DeferredBodyAction<QuestionListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/topics/{0}/quiz-questions", __workflow_topicId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<QuestionListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<QuestionDto, ApiConnectionActionConfiguration> AddTopicQuizQuestion(Expression<Func<string>> topicId, Expression<Func<bodytypeInput>> bodytype, Expression<Func<string>> bodytext, Expression<Func<int>> bodyordinalNumber = null, Expression<Func<QuestionOptionInput[]>> bodyoptions = null, Expression<Func<string>> bodyexpectedAnswer = null)
        {
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: true);
            var __workflow_bodytext = WorkflowExpression.Compile(bodytext, nameof(bodytext), required: true);
            var __workflow_bodyordinalNumber = WorkflowExpression.Compile(bodyordinalNumber, nameof(bodyordinalNumber), required: false);
            var __workflow_bodyoptions = WorkflowExpression.Compile(bodyoptions, nameof(bodyoptions), required: false);
            var __workflow_bodyexpectedAnswer = WorkflowExpression.Compile(bodyexpectedAnswer, nameof(bodyexpectedAnswer), required: false);
            return new DeferredBodyAction<QuestionDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/topics/{0}/quiz-questions", __workflow_topicId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                bodypropCount++;
                body["text"] = ExpressionConverter.ConvertO(__workflow_bodytext);
                if (__workflow_bodyordinalNumber != null)
                {
                    body["ordinalNumber"] = ExpressionConverter.ConvertO(__workflow_bodyordinalNumber);
                    bodypropCount++;
                }

                if (__workflow_bodyoptions != null)
                {
                    body["options"] = ExpressionConverter.ConvertO(__workflow_bodyoptions);
                    bodypropCount++;
                }

                if (__workflow_bodyexpectedAnswer != null)
                {
                    body["expectedAnswer"] = ExpressionConverter.ConvertO(__workflow_bodyexpectedAnswer);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<QuestionDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<QuestionListResponse, ApiConnectionActionConfiguration> ReorderTopicQuizQuestions(Expression<Func<string>> topicId, Expression<Func<string[]>> bodyquestionIds)
        {
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            var __workflow_bodyquestionIds = WorkflowExpression.Compile(bodyquestionIds, nameof(bodyquestionIds), required: true);
            return new DeferredBodyAction<QuestionListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/topics/{0}/quiz-questions/reorder", __workflow_topicId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["questionIds"] = ExpressionConverter.ConvertO(__workflow_bodyquestionIds);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<QuestionListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<TopicDto, ApiConnectionActionConfiguration> MoveTopic(Expression<Func<string>> topicId, Expression<Func<string>> bodytargetModuleId, Expression<Func<int>> bodytargetOrdinalNumber = null)
        {
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            var __workflow_bodytargetModuleId = WorkflowExpression.Compile(bodytargetModuleId, nameof(bodytargetModuleId), required: true);
            var __workflow_bodytargetOrdinalNumber = WorkflowExpression.Compile(bodytargetOrdinalNumber, nameof(bodytargetOrdinalNumber), required: false);
            return new DeferredBodyAction<TopicDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/topics/{0}/move", __workflow_topicId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["targetModuleId"] = ExpressionConverter.ConvertO(__workflow_bodytargetModuleId);
                if (__workflow_bodytargetOrdinalNumber != null)
                {
                    body["targetOrdinalNumber"] = ExpressionConverter.ConvertO(__workflow_bodytargetOrdinalNumber);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<TopicDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<TopicLinkedDocumentListResponse, ApiConnectionActionConfiguration> ListTopicLinkedDocuments(Expression<Func<string>> topicId, Expression<Func<int>> page = null, Expression<Func<int>> size = null, Expression<Func<string>> search = null)
        {
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            return new DeferredBodyAction<TopicLinkedDocumentListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/topics/{0}/linked-documents", __workflow_topicId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                return new ApiConnectionAction<TopicLinkedDocumentListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IWorkflowAction<ApiConnectionActionConfiguration> LinkDocumentsToTopic(Expression<Func<string>> topicId, Expression<Func<string[]>> bodydocumentIds)
        {
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            var __workflow_bodydocumentIds = WorkflowExpression.Compile(bodydocumentIds, nameof(bodydocumentIds), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/topics/{0}/linked-documents", __workflow_topicId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["documentIds"] = ExpressionConverter.ConvertO(__workflow_bodydocumentIds);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<LearningByteListResponse, ApiConnectionActionConfiguration> ListLearningBytesInTopic(Expression<Func<string>> topicId)
        {
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            return new DeferredBodyAction<LearningByteListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/topics/{0}/learning-bytes", __workflow_topicId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<LearningByteListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<LearningByteDetailDto, ApiConnectionActionConfiguration> AddLearningByteToTopic(Expression<Func<string>> topicId, Expression<Func<string>> bodyname, Expression<Func<string>> bodydescription = null)
        {
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            return new DeferredBodyAction<LearningByteDetailDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/topics/{0}/learning-bytes", __workflow_topicId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<LearningByteDetailDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<ExerciseDto, ApiConnectionActionConfiguration> AddRpeVoiceExercise(Expression<Func<string>> topicId, Expression<Func<string>> bodyprompt = null, Expression<Func<string>> bodyavatarPictureId = null, Expression<Func<string>> bodyavatarCharacteristics = null, Expression<Func<bool>> bodyreverseRolePlayEnabled = null, Expression<Func<bool>> bodyreverseRolePlayMandatory = null)
        {
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            var __workflow_bodyprompt = WorkflowExpression.Compile(bodyprompt, nameof(bodyprompt), required: false);
            var __workflow_bodyavatarPictureId = WorkflowExpression.Compile(bodyavatarPictureId, nameof(bodyavatarPictureId), required: false);
            var __workflow_bodyavatarCharacteristics = WorkflowExpression.Compile(bodyavatarCharacteristics, nameof(bodyavatarCharacteristics), required: false);
            var __workflow_bodyreverseRolePlayEnabled = WorkflowExpression.Compile(bodyreverseRolePlayEnabled, nameof(bodyreverseRolePlayEnabled), required: false);
            var __workflow_bodyreverseRolePlayMandatory = WorkflowExpression.Compile(bodyreverseRolePlayMandatory, nameof(bodyreverseRolePlayMandatory), required: false);
            return new DeferredBodyAction<ExerciseDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/topics/{0}/exercises/rpe-voice", __workflow_topicId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyprompt != null)
                {
                    body["prompt"] = ExpressionConverter.ConvertO(__workflow_bodyprompt);
                    bodypropCount++;
                }

                if (__workflow_bodyavatarPictureId != null)
                {
                    body["avatarPictureId"] = ExpressionConverter.ConvertO(__workflow_bodyavatarPictureId);
                    bodypropCount++;
                }

                if (__workflow_bodyavatarCharacteristics != null)
                {
                    body["avatarCharacteristics"] = ExpressionConverter.ConvertO(__workflow_bodyavatarCharacteristics);
                    bodypropCount++;
                }

                if (__workflow_bodyreverseRolePlayEnabled != null)
                {
                    body["reverseRolePlayEnabled"] = ExpressionConverter.ConvertO(__workflow_bodyreverseRolePlayEnabled);
                    bodypropCount++;
                }

                if (__workflow_bodyreverseRolePlayMandatory != null)
                {
                    body["reverseRolePlayMandatory"] = ExpressionConverter.ConvertO(__workflow_bodyreverseRolePlayMandatory);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ExerciseDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<ExerciseDto, ApiConnectionActionConfiguration> AddRpeVideoExercise(Expression<Func<string>> topicId, Expression<Func<string>> bodyprompt = null, Expression<Func<string>> bodyavatarPictureId = null, Expression<Func<string>> bodyavatarCharacteristics = null, Expression<Func<bool>> bodyreverseRolePlayEnabled = null, Expression<Func<bool>> bodyreverseRolePlayMandatory = null)
        {
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            var __workflow_bodyprompt = WorkflowExpression.Compile(bodyprompt, nameof(bodyprompt), required: false);
            var __workflow_bodyavatarPictureId = WorkflowExpression.Compile(bodyavatarPictureId, nameof(bodyavatarPictureId), required: false);
            var __workflow_bodyavatarCharacteristics = WorkflowExpression.Compile(bodyavatarCharacteristics, nameof(bodyavatarCharacteristics), required: false);
            var __workflow_bodyreverseRolePlayEnabled = WorkflowExpression.Compile(bodyreverseRolePlayEnabled, nameof(bodyreverseRolePlayEnabled), required: false);
            var __workflow_bodyreverseRolePlayMandatory = WorkflowExpression.Compile(bodyreverseRolePlayMandatory, nameof(bodyreverseRolePlayMandatory), required: false);
            return new DeferredBodyAction<ExerciseDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/topics/{0}/exercises/rpe-video", __workflow_topicId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyprompt != null)
                {
                    body["prompt"] = ExpressionConverter.ConvertO(__workflow_bodyprompt);
                    bodypropCount++;
                }

                if (__workflow_bodyavatarPictureId != null)
                {
                    body["avatarPictureId"] = ExpressionConverter.ConvertO(__workflow_bodyavatarPictureId);
                    bodypropCount++;
                }

                if (__workflow_bodyavatarCharacteristics != null)
                {
                    body["avatarCharacteristics"] = ExpressionConverter.ConvertO(__workflow_bodyavatarCharacteristics);
                    bodypropCount++;
                }

                if (__workflow_bodyreverseRolePlayEnabled != null)
                {
                    body["reverseRolePlayEnabled"] = ExpressionConverter.ConvertO(__workflow_bodyreverseRolePlayEnabled);
                    bodypropCount++;
                }

                if (__workflow_bodyreverseRolePlayMandatory != null)
                {
                    body["reverseRolePlayMandatory"] = ExpressionConverter.ConvertO(__workflow_bodyreverseRolePlayMandatory);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ExerciseDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<ExerciseDto, ApiConnectionActionConfiguration> AddIleTextExercise(Expression<Func<string>> topicId, Expression<Func<string>> bodyprompt = null)
        {
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            var __workflow_bodyprompt = WorkflowExpression.Compile(bodyprompt, nameof(bodyprompt), required: false);
            return new DeferredBodyAction<ExerciseDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/topics/{0}/exercises/ile-text", __workflow_topicId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyprompt != null)
                {
                    body["prompt"] = ExpressionConverter.ConvertO(__workflow_bodyprompt);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ExerciseDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<TopicListResponse, ApiConnectionActionConfiguration> ListTopicsInModule(Expression<Func<string>> moduleId)
        {
            var __workflow_moduleId = WorkflowExpression.Compile(moduleId, nameof(moduleId), required: true);
            return new DeferredBodyAction<TopicListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/modules/{0}/topics", __workflow_moduleId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TopicListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<TopicDto, ApiConnectionActionConfiguration> AddTopicToModule(Expression<Func<string>> moduleId, Expression<Func<string>> bodyname, Expression<Func<string>> bodydescription = null)
        {
            var __workflow_moduleId = WorkflowExpression.Compile(moduleId, nameof(moduleId), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            return new DeferredBodyAction<TopicDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/modules/{0}/topics", __workflow_moduleId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<TopicDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<TopicListResponse, ApiConnectionActionConfiguration> ReorderTopicsInModule(Expression<Func<string>> moduleId, Expression<Func<string[]>> bodytopicIds)
        {
            var __workflow_moduleId = WorkflowExpression.Compile(moduleId, nameof(moduleId), required: true);
            var __workflow_bodytopicIds = WorkflowExpression.Compile(bodytopicIds, nameof(bodytopicIds), required: true);
            return new DeferredBodyAction<TopicListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/modules/{0}/topics/reorder", __workflow_moduleId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["topicIds"] = ExpressionConverter.ConvertO(__workflow_bodytopicIds);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<TopicListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<QuestionListResponse, ApiConnectionActionConfiguration> ListModuleQuizQuestions(Expression<Func<string>> moduleId)
        {
            var __workflow_moduleId = WorkflowExpression.Compile(moduleId, nameof(moduleId), required: true);
            return new DeferredBodyAction<QuestionListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/modules/{0}/quiz-questions", __workflow_moduleId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<QuestionListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<QuestionDto, ApiConnectionActionConfiguration> AddModuleQuizQuestion(Expression<Func<string>> moduleId, Expression<Func<bodytypeInput>> bodytype, Expression<Func<string>> bodytext, Expression<Func<int>> bodyordinalNumber = null, Expression<Func<QuestionOptionInput[]>> bodyoptions = null, Expression<Func<string>> bodyexpectedAnswer = null)
        {
            var __workflow_moduleId = WorkflowExpression.Compile(moduleId, nameof(moduleId), required: true);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: true);
            var __workflow_bodytext = WorkflowExpression.Compile(bodytext, nameof(bodytext), required: true);
            var __workflow_bodyordinalNumber = WorkflowExpression.Compile(bodyordinalNumber, nameof(bodyordinalNumber), required: false);
            var __workflow_bodyoptions = WorkflowExpression.Compile(bodyoptions, nameof(bodyoptions), required: false);
            var __workflow_bodyexpectedAnswer = WorkflowExpression.Compile(bodyexpectedAnswer, nameof(bodyexpectedAnswer), required: false);
            return new DeferredBodyAction<QuestionDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/modules/{0}/quiz-questions", __workflow_moduleId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                bodypropCount++;
                body["text"] = ExpressionConverter.ConvertO(__workflow_bodytext);
                if (__workflow_bodyordinalNumber != null)
                {
                    body["ordinalNumber"] = ExpressionConverter.ConvertO(__workflow_bodyordinalNumber);
                    bodypropCount++;
                }

                if (__workflow_bodyoptions != null)
                {
                    body["options"] = ExpressionConverter.ConvertO(__workflow_bodyoptions);
                    bodypropCount++;
                }

                if (__workflow_bodyexpectedAnswer != null)
                {
                    body["expectedAnswer"] = ExpressionConverter.ConvertO(__workflow_bodyexpectedAnswer);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<QuestionDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<QuestionListResponse, ApiConnectionActionConfiguration> ReorderModuleQuizQuestions(Expression<Func<string>> moduleId, Expression<Func<string[]>> bodyquestionIds)
        {
            var __workflow_moduleId = WorkflowExpression.Compile(moduleId, nameof(moduleId), required: true);
            var __workflow_bodyquestionIds = WorkflowExpression.Compile(bodyquestionIds, nameof(bodyquestionIds), required: true);
            return new DeferredBodyAction<QuestionListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/modules/{0}/quiz-questions/reorder", __workflow_moduleId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["questionIds"] = ExpressionConverter.ConvertO(__workflow_bodyquestionIds);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<QuestionListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<MediaListResponse, ApiConnectionActionConfiguration> ListMedia(Expression<Func<int>> page = null, Expression<Func<int>> size = null, Expression<Func<string>> search = null, Expression<Func<string>> kind = null, Expression<Func<string>> status = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_kind = WorkflowExpression.Compile(kind, nameof(kind), required: false);
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            return new DeferredBodyAction<MediaListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/media";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_kind != null)
                    callPayload.Queries["kind"] = ExpressionConverter.Convert(__workflow_kind);
                if (__workflow_status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(__workflow_status);
                return new ApiConnectionAction<MediaListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<QuestionListResponse, ApiConnectionActionConfiguration> ListLessonQuestions(Expression<Func<string>> lessonId)
        {
            var __workflow_lessonId = WorkflowExpression.Compile(lessonId, nameof(lessonId), required: true);
            return new DeferredBodyAction<QuestionListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/lessons/{0}/questions", __workflow_lessonId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<QuestionListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<QuestionDto, ApiConnectionActionConfiguration> AddLessonQuestion(Expression<Func<string>> lessonId, Expression<Func<bodytypeInput>> bodytype, Expression<Func<string>> bodytext, Expression<Func<int>> bodyordinalNumber = null, Expression<Func<QuestionOptionInput[]>> bodyoptions = null, Expression<Func<string>> bodyexpectedAnswer = null)
        {
            var __workflow_lessonId = WorkflowExpression.Compile(lessonId, nameof(lessonId), required: true);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: true);
            var __workflow_bodytext = WorkflowExpression.Compile(bodytext, nameof(bodytext), required: true);
            var __workflow_bodyordinalNumber = WorkflowExpression.Compile(bodyordinalNumber, nameof(bodyordinalNumber), required: false);
            var __workflow_bodyoptions = WorkflowExpression.Compile(bodyoptions, nameof(bodyoptions), required: false);
            var __workflow_bodyexpectedAnswer = WorkflowExpression.Compile(bodyexpectedAnswer, nameof(bodyexpectedAnswer), required: false);
            return new DeferredBodyAction<QuestionDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/lessons/{0}/questions", __workflow_lessonId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                bodypropCount++;
                body["text"] = ExpressionConverter.ConvertO(__workflow_bodytext);
                if (__workflow_bodyordinalNumber != null)
                {
                    body["ordinalNumber"] = ExpressionConverter.ConvertO(__workflow_bodyordinalNumber);
                    bodypropCount++;
                }

                if (__workflow_bodyoptions != null)
                {
                    body["options"] = ExpressionConverter.ConvertO(__workflow_bodyoptions);
                    bodypropCount++;
                }

                if (__workflow_bodyexpectedAnswer != null)
                {
                    body["expectedAnswer"] = ExpressionConverter.ConvertO(__workflow_bodyexpectedAnswer);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<QuestionDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<QuestionListResponse, ApiConnectionActionConfiguration> ReorderLessonQuestions(Expression<Func<string>> lessonId, Expression<Func<string[]>> bodyquestionIds)
        {
            var __workflow_lessonId = WorkflowExpression.Compile(lessonId, nameof(lessonId), required: true);
            var __workflow_bodyquestionIds = WorkflowExpression.Compile(bodyquestionIds, nameof(bodyquestionIds), required: true);
            return new DeferredBodyAction<QuestionListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/lessons/{0}/questions/reorder", __workflow_lessonId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["questionIds"] = ExpressionConverter.ConvertO(__workflow_bodyquestionIds);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<QuestionListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<LessonListResponse, ApiConnectionActionConfiguration> ListLessonsInLearningByte(Expression<Func<string>> lbId)
        {
            var __workflow_lbId = WorkflowExpression.Compile(lbId, nameof(lbId), required: true);
            return new DeferredBodyAction<LessonListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/learning-bytes/{0}/lessons", __workflow_lbId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<LessonListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<LessonDetailDto, ApiConnectionActionConfiguration> AddLessonToLearningByte(Expression<Func<string>> lbId, Expression<Func<string>> bodycontent)
        {
            var __workflow_lbId = WorkflowExpression.Compile(lbId, nameof(lbId), required: true);
            var __workflow_bodycontent = WorkflowExpression.Compile(bodycontent, nameof(bodycontent), required: true);
            return new DeferredBodyAction<LessonDetailDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/learning-bytes/{0}/lessons", __workflow_lbId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["content"] = ExpressionConverter.ConvertO(__workflow_bodycontent);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<LessonDetailDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RemoveAllRolesFromExpert(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/experts/{0}/roles", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<ExpertDetailDto, ApiConnectionActionConfiguration> AssignRolesToExpert(Expression<Func<string>> id, Expression<Func<string[]>> bodyroleIds)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodyroleIds = WorkflowExpression.Compile(bodyroleIds, nameof(bodyroleIds), required: true);
            return new DeferredBodyAction<ExpertDetailDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/experts/{0}/roles", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["roleIds"] = ExpressionConverter.ConvertO(__workflow_bodyroleIds);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ExpertDetailDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<ExpertDetailDto, ApiConnectionActionConfiguration> AssignDocumentsToExpert(Expression<Func<string>> id, Expression<Func<string[]>> bodydocumentIds)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodydocumentIds = WorkflowExpression.Compile(bodydocumentIds, nameof(bodydocumentIds), required: true);
            return new DeferredBodyAction<ExpertDetailDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/experts/{0}/documents", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["documentIds"] = ExpressionConverter.ConvertO(__workflow_bodydocumentIds);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ExpertDetailDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<AskResponse, ApiConnectionActionConfiguration> AskExpert(Expression<Func<string>> id, Expression<Func<string>> bodyquestion)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodyquestion = WorkflowExpression.Compile(bodyquestion, nameof(bodyquestion), required: true);
            return new DeferredBodyAction<AskResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/experts/{0}/ask", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["question"] = ExpressionConverter.ConvertO(__workflow_bodyquestion);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<AskResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<DocumentListResponse, ApiConnectionActionConfiguration> ListDocuments(Expression<Func<int>> page = null, Expression<Func<int>> size = null, Expression<Func<string>> search = null, Expression<Func<string>> mimeTypes = null, Expression<Func<string>> status = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_mimeTypes = WorkflowExpression.Compile(mimeTypes, nameof(mimeTypes), required: false);
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            return new DeferredBodyAction<DocumentListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/documents";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_mimeTypes != null)
                    callPayload.Queries["mimeTypes"] = ExpressionConverter.Convert(__workflow_mimeTypes);
                if (__workflow_status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(__workflow_status);
                return new ApiConnectionAction<DocumentListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<DepartmentListResponse, ApiConnectionActionConfiguration> ListDepartments()
        {
            return new DeferredBodyAction<DepartmentListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/departments";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DepartmentListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<DepartmentDto, ApiConnectionActionConfiguration> CreateDepartment(Expression<Func<string>> bodyname, Expression<Func<string>> bodydescription = null)
        {
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            return new DeferredBodyAction<DepartmentDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/departments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<DepartmentDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<DepartmentDto, ApiConnectionActionConfiguration> CreateRoleInDepartment(Expression<Func<string>> id, Expression<Func<string>> bodyname, Expression<Func<string>> bodyfullName = null, Expression<Func<string>> bodydescription = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodyfullName = WorkflowExpression.Compile(bodyfullName, nameof(bodyfullName), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            return new DeferredBodyAction<DepartmentDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/departments/{0}/roles", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                if (__workflow_bodyfullName != null)
                {
                    body["fullName"] = ExpressionConverter.ConvertO(__workflow_bodyfullName);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<DepartmentDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<DepartmentDto, ApiConnectionActionConfiguration> AssignUserToRole(Expression<Func<string>> id, Expression<Func<string>> roleId, Expression<Func<string>> bodyuserId)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_roleId = WorkflowExpression.Compile(roleId, nameof(roleId), required: true);
            var __workflow_bodyuserId = WorkflowExpression.Compile(bodyuserId, nameof(bodyuserId), required: true);
            return new DeferredBodyAction<DepartmentDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/departments/{0}/roles/{1}/assign", __workflow_id.WithUrlEncoding(1), __workflow_roleId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["userId"] = ExpressionConverter.ConvertO(__workflow_bodyuserId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<DepartmentDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<DemoTrainingListResponse, ApiConnectionActionConfiguration> ListDemoTrainings(Expression<Func<int>> page = null, Expression<Func<int>> size = null, Expression<Func<string>> search = null, Expression<Func<string>> trainingTypes = null, Expression<Func<string>> statuses = null, Expression<Func<string>> departmentIds = null, Expression<Func<bool>> isAvailable = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_trainingTypes = WorkflowExpression.Compile(trainingTypes, nameof(trainingTypes), required: false);
            var __workflow_statuses = WorkflowExpression.Compile(statuses, nameof(statuses), required: false);
            var __workflow_departmentIds = WorkflowExpression.Compile(departmentIds, nameof(departmentIds), required: false);
            var __workflow_isAvailable = WorkflowExpression.Compile(isAvailable, nameof(isAvailable), required: false);
            return new DeferredBodyAction<DemoTrainingListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/demo-trainings";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_trainingTypes != null)
                    callPayload.Queries["trainingTypes"] = ExpressionConverter.Convert(__workflow_trainingTypes);
                if (__workflow_statuses != null)
                    callPayload.Queries["statuses"] = ExpressionConverter.Convert(__workflow_statuses);
                if (__workflow_departmentIds != null)
                    callPayload.Queries["departmentIds"] = ExpressionConverter.Convert(__workflow_departmentIds);
                if (__workflow_isAvailable != null)
                    callPayload.Queries["isAvailable"] = ExpressionConverter.Convert(__workflow_isAvailable);
                return new ApiConnectionAction<DemoTrainingListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<DemoTrainingDto, ApiConnectionActionConfiguration> CreateDemoTraining(Expression<Func<string>> bodyname, Expression<Func<bodytrainingTypeInput>> bodytrainingType, Expression<Func<string>> bodyvideoFileId, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodydepartmentId = null, Expression<Func<string>> bodyprocessingPrompt = null)
        {
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodytrainingType = WorkflowExpression.Compile(bodytrainingType, nameof(bodytrainingType), required: true);
            var __workflow_bodyvideoFileId = WorkflowExpression.Compile(bodyvideoFileId, nameof(bodyvideoFileId), required: true);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodydepartmentId = WorkflowExpression.Compile(bodydepartmentId, nameof(bodydepartmentId), required: false);
            var __workflow_bodyprocessingPrompt = WorkflowExpression.Compile(bodyprocessingPrompt, nameof(bodyprocessingPrompt), required: false);
            return new DeferredBodyAction<DemoTrainingDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/demo-trainings";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                bodypropCount++;
                body["trainingType"] = ExpressionConverter.ConvertO(__workflow_bodytrainingType);
                bodypropCount++;
                body["videoFileId"] = ExpressionConverter.ConvertO(__workflow_bodyvideoFileId);
                if (__workflow_bodydepartmentId != null)
                {
                    body["departmentId"] = ExpressionConverter.ConvertO(__workflow_bodydepartmentId);
                    bodypropCount++;
                }

                if (__workflow_bodyprocessingPrompt != null)
                {
                    body["processingPrompt"] = ExpressionConverter.ConvertO(__workflow_bodyprocessingPrompt);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<DemoTrainingDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<DemoTrainingDto, ApiConnectionActionConfiguration> ReprocessDemoTraining(Expression<Func<string>> id, Expression<Func<string>> bodyprocessingPrompt = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodyprocessingPrompt = WorkflowExpression.Compile(bodyprocessingPrompt, nameof(bodyprocessingPrompt), required: false);
            return new DeferredBodyAction<DemoTrainingDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/demo-trainings/{0}/reprocess", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyprocessingPrompt != null)
                {
                    body["processingPrompt"] = ExpressionConverter.ConvertO(__workflow_bodyprocessingPrompt);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<DemoTrainingDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<DemoTrainingDto, ApiConnectionActionConfiguration> UpdateDemoTrainingAvailability(Expression<Func<string>> id, Expression<Func<bool>> bodyavailable)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodyavailable = WorkflowExpression.Compile(bodyavailable, nameof(bodyavailable), required: true);
            return new DeferredBodyAction<DemoTrainingDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/demo-trainings/{0}/availability", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["available"] = ExpressionConverter.ConvertO(__workflow_bodyavailable);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<DemoTrainingDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<CourseListResponse, ApiConnectionActionConfiguration> ListCourses(Expression<Func<int>> page = null, Expression<Func<int>> size = null, Expression<Func<string>> search = null, Expression<Func<string>> status = null, Expression<Func<string>> departmentRoleIds = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            var __workflow_departmentRoleIds = WorkflowExpression.Compile(departmentRoleIds, nameof(departmentRoleIds), required: false);
            return new DeferredBodyAction<CourseListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/courses";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(__workflow_status);
                if (__workflow_departmentRoleIds != null)
                    callPayload.Queries["departmentRoleIds"] = ExpressionConverter.Convert(__workflow_departmentRoleIds);
                return new ApiConnectionAction<CourseListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<CourseDetailDto, ApiConnectionActionConfiguration> CreateCourse(Expression<Func<string>> bodyname)
        {
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            return new DeferredBodyAction<CourseDetailDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/courses";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CourseDetailDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RemoveAllRolesFromCourse(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/courses/{0}/roles", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<CourseDetailDto, ApiConnectionActionConfiguration> AssignRolesToCourse(Expression<Func<string>> id, Expression<Func<string[]>> bodyroleIds)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodyroleIds = WorkflowExpression.Compile(bodyroleIds, nameof(bodyroleIds), required: true);
            return new DeferredBodyAction<CourseDetailDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/courses/{0}/roles", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["roleIds"] = ExpressionConverter.ConvertO(__workflow_bodyroleIds);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CourseDetailDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<CourseDetailDto, ApiConnectionActionConfiguration> PublishCourse(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<CourseDetailDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/courses/{0}/publish", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CourseDetailDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<GenerationRequestResponse, ApiConnectionActionConfiguration> GenerateCourseContent(Expression<Func<string>> id, Expression<Func<string[]>> bodytopicIds)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodytopicIds = WorkflowExpression.Compile(bodytopicIds, nameof(bodytopicIds), required: true);
            return new DeferredBodyAction<GenerationRequestResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/courses/{0}/generate-content", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["topicIds"] = ExpressionConverter.ConvertO(__workflow_bodytopicIds);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GenerationRequestResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<ModuleListResponse, ApiConnectionActionConfiguration> ListModulesInCourse(Expression<Func<string>> courseId)
        {
            var __workflow_courseId = WorkflowExpression.Compile(courseId, nameof(courseId), required: true);
            return new DeferredBodyAction<ModuleListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/courses/{0}/modules", __workflow_courseId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ModuleListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<ModuleDetailDto, ApiConnectionActionConfiguration> AddModuleToCourse(Expression<Func<string>> courseId, Expression<Func<string>> bodyname, Expression<Func<string>> bodydescription = null)
        {
            var __workflow_courseId = WorkflowExpression.Compile(courseId, nameof(courseId), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            return new DeferredBodyAction<ModuleDetailDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/courses/{0}/modules", __workflow_courseId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ModuleDetailDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<ModuleListResponse, ApiConnectionActionConfiguration> ReorderModulesInCourse(Expression<Func<string>> courseId, Expression<Func<string[]>> bodymoduleIds)
        {
            var __workflow_courseId = WorkflowExpression.Compile(courseId, nameof(courseId), required: true);
            var __workflow_bodymoduleIds = WorkflowExpression.Compile(bodymoduleIds, nameof(bodymoduleIds), required: true);
            return new DeferredBodyAction<ModuleListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/courses/{0}/modules/reorder", __workflow_courseId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["moduleIds"] = ExpressionConverter.ConvertO(__workflow_bodymoduleIds);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ModuleListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<GenerationRequestResponse, ApiConnectionActionConfiguration> RegenerateCourseItem(Expression<Func<bodytargetInput>> bodytarget, Expression<Func<string>> bodytargetId, Expression<Func<bodyparentTypeInput>> bodyparentType = null)
        {
            var __workflow_bodytarget = WorkflowExpression.Compile(bodytarget, nameof(bodytarget), required: true);
            var __workflow_bodytargetId = WorkflowExpression.Compile(bodytargetId, nameof(bodytargetId), required: true);
            var __workflow_bodyparentType = WorkflowExpression.Compile(bodyparentType, nameof(bodyparentType), required: false);
            return new DeferredBodyAction<GenerationRequestResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/courses/regenerate-item";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["target"] = ExpressionConverter.ConvertO(__workflow_bodytarget);
                bodypropCount++;
                body["targetId"] = ExpressionConverter.ConvertO(__workflow_bodytargetId);
                if (__workflow_bodyparentType != null)
                {
                    body["parentType"] = ExpressionConverter.ConvertO(__workflow_bodyparentType);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GenerationRequestResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<GenerateCourseResponse, ApiConnectionActionConfiguration> GenerateCourse(Expression<Func<string>> bodyname, Expression<Func<ModuleInput[]>> bodymodules, Expression<Func<string>> bodydescription = null)
        {
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodymodules = WorkflowExpression.Compile(bodymodules, nameof(bodymodules), required: true);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            return new DeferredBodyAction<GenerateCourseResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/courses/generate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                bodypropCount++;
                body["modules"] = ExpressionConverter.ConvertO(__workflow_bodymodules);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GenerateCourseResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<UserDto, ApiConnectionActionConfiguration> GetUser(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<UserDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/users/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<UserDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<UserDto, ApiConnectionActionConfiguration> UpdateUser(Expression<Func<string>> id, Expression<Func<string>> bodyfirstName = null, Expression<Func<string>> bodylastName = null, Expression<Func<bool>> bodyisAdmin = null, Expression<Func<string[]>> bodydepartmentRoleIds = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodyfirstName = WorkflowExpression.Compile(bodyfirstName, nameof(bodyfirstName), required: false);
            var __workflow_bodylastName = WorkflowExpression.Compile(bodylastName, nameof(bodylastName), required: false);
            var __workflow_bodyisAdmin = WorkflowExpression.Compile(bodyisAdmin, nameof(bodyisAdmin), required: false);
            var __workflow_bodydepartmentRoleIds = WorkflowExpression.Compile(bodydepartmentRoleIds, nameof(bodydepartmentRoleIds), required: false);
            return new DeferredBodyAction<UserDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/users/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfirstName != null)
                {
                    body["firstName"] = ExpressionConverter.ConvertO(__workflow_bodyfirstName);
                    bodypropCount++;
                }

                if (__workflow_bodylastName != null)
                {
                    body["lastName"] = ExpressionConverter.ConvertO(__workflow_bodylastName);
                    bodypropCount++;
                }

                if (__workflow_bodyisAdmin != null)
                {
                    body["isAdmin"] = ExpressionConverter.ConvertO(__workflow_bodyisAdmin);
                    bodypropCount++;
                }

                if (__workflow_bodydepartmentRoleIds != null)
                {
                    body["departmentRoleIds"] = ExpressionConverter.ConvertO(__workflow_bodydepartmentRoleIds);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UserDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<TopicDto, ApiConnectionActionConfiguration> GetTopic(Expression<Func<string>> topicId)
        {
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            return new DeferredBodyAction<TopicDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/topics/{0}", __workflow_topicId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TopicDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteTopic(Expression<Func<string>> topicId)
        {
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/topics/{0}", __workflow_topicId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<TopicDto, ApiConnectionActionConfiguration> UpdateTopic(Expression<Func<string>> topicId, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodydescription = null)
        {
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            return new DeferredBodyAction<TopicDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/topics/{0}", __workflow_topicId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<TopicDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<QuestionDto, ApiConnectionActionConfiguration> GetTopicQuizQuestion(Expression<Func<string>> topicId, Expression<Func<string>> questionId)
        {
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            var __workflow_questionId = WorkflowExpression.Compile(questionId, nameof(questionId), required: true);
            return new DeferredBodyAction<QuestionDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/topics/{0}/quiz-questions/{1}", __workflow_topicId.WithUrlEncoding(1), __workflow_questionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<QuestionDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteTopicQuizQuestion(Expression<Func<string>> topicId, Expression<Func<string>> questionId)
        {
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            var __workflow_questionId = WorkflowExpression.Compile(questionId, nameof(questionId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/topics/{0}/quiz-questions/{1}", __workflow_topicId.WithUrlEncoding(1), __workflow_questionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<QuestionDto, ApiConnectionActionConfiguration> UpdateTopicQuizQuestion(Expression<Func<string>> topicId, Expression<Func<string>> questionId, Expression<Func<string>> bodytext = null, Expression<Func<QuestionOptionInput[]>> bodyoptions = null, Expression<Func<string>> bodyexpectedAnswer = null)
        {
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            var __workflow_questionId = WorkflowExpression.Compile(questionId, nameof(questionId), required: true);
            var __workflow_bodytext = WorkflowExpression.Compile(bodytext, nameof(bodytext), required: false);
            var __workflow_bodyoptions = WorkflowExpression.Compile(bodyoptions, nameof(bodyoptions), required: false);
            var __workflow_bodyexpectedAnswer = WorkflowExpression.Compile(bodyexpectedAnswer, nameof(bodyexpectedAnswer), required: false);
            return new DeferredBodyAction<QuestionDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/topics/{0}/quiz-questions/{1}", __workflow_topicId.WithUrlEncoding(1), __workflow_questionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytext != null)
                {
                    body["text"] = ExpressionConverter.ConvertO(__workflow_bodytext);
                    bodypropCount++;
                }

                if (__workflow_bodyoptions != null)
                {
                    body["options"] = ExpressionConverter.ConvertO(__workflow_bodyoptions);
                    bodypropCount++;
                }

                if (__workflow_bodyexpectedAnswer != null)
                {
                    body["expectedAnswer"] = ExpressionConverter.ConvertO(__workflow_bodyexpectedAnswer);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<QuestionDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<ModuleDetailDto, ApiConnectionActionConfiguration> GetModule(Expression<Func<string>> moduleId)
        {
            var __workflow_moduleId = WorkflowExpression.Compile(moduleId, nameof(moduleId), required: true);
            return new DeferredBodyAction<ModuleDetailDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/modules/{0}", __workflow_moduleId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ModuleDetailDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteModule(Expression<Func<string>> moduleId)
        {
            var __workflow_moduleId = WorkflowExpression.Compile(moduleId, nameof(moduleId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/modules/{0}", __workflow_moduleId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<ModuleDetailDto, ApiConnectionActionConfiguration> UpdateModule(Expression<Func<string>> moduleId, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodydescription = null)
        {
            var __workflow_moduleId = WorkflowExpression.Compile(moduleId, nameof(moduleId), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            return new DeferredBodyAction<ModuleDetailDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/modules/{0}", __workflow_moduleId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ModuleDetailDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<QuestionDto, ApiConnectionActionConfiguration> GetModuleQuizQuestion(Expression<Func<string>> moduleId, Expression<Func<string>> questionId)
        {
            var __workflow_moduleId = WorkflowExpression.Compile(moduleId, nameof(moduleId), required: true);
            var __workflow_questionId = WorkflowExpression.Compile(questionId, nameof(questionId), required: true);
            return new DeferredBodyAction<QuestionDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/modules/{0}/quiz-questions/{1}", __workflow_moduleId.WithUrlEncoding(1), __workflow_questionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<QuestionDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteModuleQuizQuestion(Expression<Func<string>> moduleId, Expression<Func<string>> questionId)
        {
            var __workflow_moduleId = WorkflowExpression.Compile(moduleId, nameof(moduleId), required: true);
            var __workflow_questionId = WorkflowExpression.Compile(questionId, nameof(questionId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/modules/{0}/quiz-questions/{1}", __workflow_moduleId.WithUrlEncoding(1), __workflow_questionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<QuestionDto, ApiConnectionActionConfiguration> UpdateModuleQuizQuestion(Expression<Func<string>> moduleId, Expression<Func<string>> questionId, Expression<Func<string>> bodytext = null, Expression<Func<QuestionOptionInput[]>> bodyoptions = null, Expression<Func<string>> bodyexpectedAnswer = null)
        {
            var __workflow_moduleId = WorkflowExpression.Compile(moduleId, nameof(moduleId), required: true);
            var __workflow_questionId = WorkflowExpression.Compile(questionId, nameof(questionId), required: true);
            var __workflow_bodytext = WorkflowExpression.Compile(bodytext, nameof(bodytext), required: false);
            var __workflow_bodyoptions = WorkflowExpression.Compile(bodyoptions, nameof(bodyoptions), required: false);
            var __workflow_bodyexpectedAnswer = WorkflowExpression.Compile(bodyexpectedAnswer, nameof(bodyexpectedAnswer), required: false);
            return new DeferredBodyAction<QuestionDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/modules/{0}/quiz-questions/{1}", __workflow_moduleId.WithUrlEncoding(1), __workflow_questionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytext != null)
                {
                    body["text"] = ExpressionConverter.ConvertO(__workflow_bodytext);
                    bodypropCount++;
                }

                if (__workflow_bodyoptions != null)
                {
                    body["options"] = ExpressionConverter.ConvertO(__workflow_bodyoptions);
                    bodypropCount++;
                }

                if (__workflow_bodyexpectedAnswer != null)
                {
                    body["expectedAnswer"] = ExpressionConverter.ConvertO(__workflow_bodyexpectedAnswer);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<QuestionDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<LessonDetailDto, ApiConnectionActionConfiguration> GetLesson(Expression<Func<string>> lessonId)
        {
            var __workflow_lessonId = WorkflowExpression.Compile(lessonId, nameof(lessonId), required: true);
            return new DeferredBodyAction<LessonDetailDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/lessons/{0}", __workflow_lessonId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<LessonDetailDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteLesson(Expression<Func<string>> lessonId)
        {
            var __workflow_lessonId = WorkflowExpression.Compile(lessonId, nameof(lessonId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/lessons/{0}", __workflow_lessonId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<LessonDetailDto, ApiConnectionActionConfiguration> UpdateLesson(Expression<Func<string>> lessonId, Expression<Func<string>> bodycontent = null)
        {
            var __workflow_lessonId = WorkflowExpression.Compile(lessonId, nameof(lessonId), required: true);
            var __workflow_bodycontent = WorkflowExpression.Compile(bodycontent, nameof(bodycontent), required: false);
            return new DeferredBodyAction<LessonDetailDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/lessons/{0}", __workflow_lessonId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodycontent != null)
                {
                    body["content"] = ExpressionConverter.ConvertO(__workflow_bodycontent);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<LessonDetailDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<QuestionDto, ApiConnectionActionConfiguration> GetLessonQuestion(Expression<Func<string>> lessonId, Expression<Func<string>> questionId)
        {
            var __workflow_lessonId = WorkflowExpression.Compile(lessonId, nameof(lessonId), required: true);
            var __workflow_questionId = WorkflowExpression.Compile(questionId, nameof(questionId), required: true);
            return new DeferredBodyAction<QuestionDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/lessons/{0}/questions/{1}", __workflow_lessonId.WithUrlEncoding(1), __workflow_questionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<QuestionDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteLessonQuestion(Expression<Func<string>> lessonId, Expression<Func<string>> questionId)
        {
            var __workflow_lessonId = WorkflowExpression.Compile(lessonId, nameof(lessonId), required: true);
            var __workflow_questionId = WorkflowExpression.Compile(questionId, nameof(questionId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/lessons/{0}/questions/{1}", __workflow_lessonId.WithUrlEncoding(1), __workflow_questionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<QuestionDto, ApiConnectionActionConfiguration> UpdateLessonQuestion(Expression<Func<string>> lessonId, Expression<Func<string>> questionId, Expression<Func<string>> bodytext = null, Expression<Func<QuestionOptionInput[]>> bodyoptions = null, Expression<Func<string>> bodyexpectedAnswer = null)
        {
            var __workflow_lessonId = WorkflowExpression.Compile(lessonId, nameof(lessonId), required: true);
            var __workflow_questionId = WorkflowExpression.Compile(questionId, nameof(questionId), required: true);
            var __workflow_bodytext = WorkflowExpression.Compile(bodytext, nameof(bodytext), required: false);
            var __workflow_bodyoptions = WorkflowExpression.Compile(bodyoptions, nameof(bodyoptions), required: false);
            var __workflow_bodyexpectedAnswer = WorkflowExpression.Compile(bodyexpectedAnswer, nameof(bodyexpectedAnswer), required: false);
            return new DeferredBodyAction<QuestionDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/lessons/{0}/questions/{1}", __workflow_lessonId.WithUrlEncoding(1), __workflow_questionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytext != null)
                {
                    body["text"] = ExpressionConverter.ConvertO(__workflow_bodytext);
                    bodypropCount++;
                }

                if (__workflow_bodyoptions != null)
                {
                    body["options"] = ExpressionConverter.ConvertO(__workflow_bodyoptions);
                    bodypropCount++;
                }

                if (__workflow_bodyexpectedAnswer != null)
                {
                    body["expectedAnswer"] = ExpressionConverter.ConvertO(__workflow_bodyexpectedAnswer);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<QuestionDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<LearningByteDetailDto, ApiConnectionActionConfiguration> GetLearningByte(Expression<Func<string>> lbId)
        {
            var __workflow_lbId = WorkflowExpression.Compile(lbId, nameof(lbId), required: true);
            return new DeferredBodyAction<LearningByteDetailDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/learning-bytes/{0}", __workflow_lbId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<LearningByteDetailDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteLearningByte(Expression<Func<string>> lbId)
        {
            var __workflow_lbId = WorkflowExpression.Compile(lbId, nameof(lbId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/learning-bytes/{0}", __workflow_lbId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<LearningByteDetailDto, ApiConnectionActionConfiguration> UpdateLearningByte(Expression<Func<string>> lbId, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodydescription = null)
        {
            var __workflow_lbId = WorkflowExpression.Compile(lbId, nameof(lbId), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            return new DeferredBodyAction<LearningByteDetailDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/learning-bytes/{0}", __workflow_lbId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<LearningByteDetailDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<ExerciseDto, ApiConnectionActionConfiguration> GetExercise(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ExerciseDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/exercises/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ExerciseDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteExercise(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/exercises/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<ExerciseDto, ApiConnectionActionConfiguration> UpdateExercise(Expression<Func<string>> id, Expression<Func<string>> bodyprompt = null, Expression<Func<string>> bodyavatarPictureId = null, Expression<Func<string>> bodyavatarCharacteristics = null, Expression<Func<bool>> bodyreverseRolePlayEnabled = null, Expression<Func<bool>> bodyreverseRolePlayMandatory = null, Expression<Func<string>> bodygeneratedContentscenario = null, Expression<Func<string>> bodygeneratedContenttraineeRole = null, Expression<Func<string>> bodygeneratedContentavatarName = null, Expression<Func<string>> bodygeneratedContentavatarDescription = null, Expression<Func<string>> bodygeneratedContentoperationalChallenge = null, Expression<Func<string>> bodygeneratedContentsuccessMetric = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodyprompt = WorkflowExpression.Compile(bodyprompt, nameof(bodyprompt), required: false);
            var __workflow_bodyavatarPictureId = WorkflowExpression.Compile(bodyavatarPictureId, nameof(bodyavatarPictureId), required: false);
            var __workflow_bodyavatarCharacteristics = WorkflowExpression.Compile(bodyavatarCharacteristics, nameof(bodyavatarCharacteristics), required: false);
            var __workflow_bodyreverseRolePlayEnabled = WorkflowExpression.Compile(bodyreverseRolePlayEnabled, nameof(bodyreverseRolePlayEnabled), required: false);
            var __workflow_bodyreverseRolePlayMandatory = WorkflowExpression.Compile(bodyreverseRolePlayMandatory, nameof(bodyreverseRolePlayMandatory), required: false);
            var __workflow_bodygeneratedContentscenario = WorkflowExpression.Compile(bodygeneratedContentscenario, nameof(bodygeneratedContentscenario), required: false);
            var __workflow_bodygeneratedContenttraineeRole = WorkflowExpression.Compile(bodygeneratedContenttraineeRole, nameof(bodygeneratedContenttraineeRole), required: false);
            var __workflow_bodygeneratedContentavatarName = WorkflowExpression.Compile(bodygeneratedContentavatarName, nameof(bodygeneratedContentavatarName), required: false);
            var __workflow_bodygeneratedContentavatarDescription = WorkflowExpression.Compile(bodygeneratedContentavatarDescription, nameof(bodygeneratedContentavatarDescription), required: false);
            var __workflow_bodygeneratedContentoperationalChallenge = WorkflowExpression.Compile(bodygeneratedContentoperationalChallenge, nameof(bodygeneratedContentoperationalChallenge), required: false);
            var __workflow_bodygeneratedContentsuccessMetric = WorkflowExpression.Compile(bodygeneratedContentsuccessMetric, nameof(bodygeneratedContentsuccessMetric), required: false);
            return new DeferredBodyAction<ExerciseDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/exercises/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyprompt != null)
                {
                    body["prompt"] = ExpressionConverter.ConvertO(__workflow_bodyprompt);
                    bodypropCount++;
                }

                if (__workflow_bodyavatarPictureId != null)
                {
                    body["avatarPictureId"] = ExpressionConverter.ConvertO(__workflow_bodyavatarPictureId);
                    bodypropCount++;
                }

                if (__workflow_bodyavatarCharacteristics != null)
                {
                    body["avatarCharacteristics"] = ExpressionConverter.ConvertO(__workflow_bodyavatarCharacteristics);
                    bodypropCount++;
                }

                if (__workflow_bodyreverseRolePlayEnabled != null)
                {
                    body["reverseRolePlayEnabled"] = ExpressionConverter.ConvertO(__workflow_bodyreverseRolePlayEnabled);
                    bodypropCount++;
                }

                if (__workflow_bodyreverseRolePlayMandatory != null)
                {
                    body["reverseRolePlayMandatory"] = ExpressionConverter.ConvertO(__workflow_bodyreverseRolePlayMandatory);
                    bodypropCount++;
                }

                var generatedContentObject = new JObject();
                var generatedContentObjectpropCount = 0;
                if (__workflow_bodygeneratedContentscenario != null)
                {
                    generatedContentObject["scenario"] = ExpressionConverter.ConvertO(__workflow_bodygeneratedContentscenario);
                    generatedContentObjectpropCount++;
                }

                if (__workflow_bodygeneratedContenttraineeRole != null)
                {
                    generatedContentObject["traineeRole"] = ExpressionConverter.ConvertO(__workflow_bodygeneratedContenttraineeRole);
                    generatedContentObjectpropCount++;
                }

                if (__workflow_bodygeneratedContentavatarName != null)
                {
                    generatedContentObject["avatarName"] = ExpressionConverter.ConvertO(__workflow_bodygeneratedContentavatarName);
                    generatedContentObjectpropCount++;
                }

                if (__workflow_bodygeneratedContentavatarDescription != null)
                {
                    generatedContentObject["avatarDescription"] = ExpressionConverter.ConvertO(__workflow_bodygeneratedContentavatarDescription);
                    generatedContentObjectpropCount++;
                }

                if (__workflow_bodygeneratedContentoperationalChallenge != null)
                {
                    generatedContentObject["operationalChallenge"] = ExpressionConverter.ConvertO(__workflow_bodygeneratedContentoperationalChallenge);
                    generatedContentObjectpropCount++;
                }

                if (__workflow_bodygeneratedContentsuccessMetric != null)
                {
                    generatedContentObject["successMetric"] = ExpressionConverter.ConvertO(__workflow_bodygeneratedContentsuccessMetric);
                    generatedContentObjectpropCount++;
                }

                if (generatedContentObjectpropCount > 0)
                {
                    body["generatedContent"] = generatedContentObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ExerciseDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteDepartment(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/departments/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<DepartmentDto, ApiConnectionActionConfiguration> UpdateDepartment(Expression<Func<string>> id, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodydescription = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            return new DeferredBodyAction<DepartmentDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/departments/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<DepartmentDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<DemoTrainingDto, ApiConnectionActionConfiguration> GetDemoTraining(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<DemoTrainingDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/demo-trainings/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DemoTrainingDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteDemoTraining(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/demo-trainings/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<DemoTrainingDto, ApiConnectionActionConfiguration> UpdateDemoTraining(Expression<Func<string>> id, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodydescription = null, Expression<Func<bodytrainingTypeInput>> bodytrainingType = null, Expression<Func<string>> bodydepartmentId = null, Expression<Func<string[]>> bodyassignedRoleIds = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodytrainingType = WorkflowExpression.Compile(bodytrainingType, nameof(bodytrainingType), required: false);
            var __workflow_bodydepartmentId = WorkflowExpression.Compile(bodydepartmentId, nameof(bodydepartmentId), required: false);
            var __workflow_bodyassignedRoleIds = WorkflowExpression.Compile(bodyassignedRoleIds, nameof(bodyassignedRoleIds), required: false);
            return new DeferredBodyAction<DemoTrainingDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/demo-trainings/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodytrainingType != null)
                {
                    body["trainingType"] = ExpressionConverter.ConvertO(__workflow_bodytrainingType);
                    bodypropCount++;
                }

                if (__workflow_bodydepartmentId != null)
                {
                    body["departmentId"] = ExpressionConverter.ConvertO(__workflow_bodydepartmentId);
                    bodypropCount++;
                }

                if (__workflow_bodyassignedRoleIds != null)
                {
                    body["assignedRoleIds"] = ExpressionConverter.ConvertO(__workflow_bodyassignedRoleIds);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<DemoTrainingDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<CourseDetailDto, ApiConnectionActionConfiguration> GetCourse(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<CourseDetailDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/courses/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CourseDetailDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteCourse(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/courses/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<CourseDetailDto, ApiConnectionActionConfiguration> UpdateCourse(Expression<Func<string>> id, Expression<Func<string>> bodyname = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            return new DeferredBodyAction<CourseDetailDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/courses/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CourseDetailDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<ExerciseListResponse, ApiConnectionActionConfiguration> ListExercisesInTopic(Expression<Func<string>> topicId)
        {
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            return new DeferredBodyAction<ExerciseListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/topics/{0}/exercises", __workflow_topicId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ExerciseListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<CertificateListResponse, ApiConnectionActionConfiguration> ListStudentCertificates(Expression<Func<string>> userId)
        {
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: true);
            return new DeferredBodyAction<CertificateListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/students/{0}/certificates", __workflow_userId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CertificateListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<StudentInsightsDto, ApiConnectionActionConfiguration> GetStudentInsights(Expression<Func<string>> userId, Expression<Func<string>> window = null)
        {
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: true);
            var __workflow_window = WorkflowExpression.Compile(window, nameof(window), required: false);
            return new DeferredBodyAction<StudentInsightsDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/insights/students/{0}", __workflow_userId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_window != null)
                    callPayload.Queries["window"] = ExpressionConverter.Convert(__workflow_window);
                return new ApiConnectionAction<StudentInsightsDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<EventListResponse, ApiConnectionActionConfiguration> ListStudentEvents(Expression<Func<string>> userId, Expression<Func<int>> page = null, Expression<Func<int>> size = null)
        {
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            return new DeferredBodyAction<EventListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/insights/students/{0}/events", __workflow_userId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                return new ApiConnectionAction<EventListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<CompanyInsightsDto, ApiConnectionActionConfiguration> GetCompanyInsights()
        {
            return new DeferredBodyAction<CompanyInsightsDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/insights/company";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CompanyInsightsDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<ExpertListResponse, ApiConnectionActionConfiguration> ListExperts(Expression<Func<int>> page = null, Expression<Func<int>> size = null, Expression<Func<string>> search = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            return new DeferredBodyAction<ExpertListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/experts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                return new ApiConnectionAction<ExpertListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<ExpertDetailDto, ApiConnectionActionConfiguration> GetExpert(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ExpertDetailDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/experts/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ExpertDetailDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<GenerationStatusResponse, ApiConnectionActionConfiguration> GetCourseGenerationStatus(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GenerationStatusResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/courses/{0}/generation-status", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GenerationStatusResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<CourseVersionListResponse, ApiConnectionActionConfiguration> ListCourseVersions(Expression<Func<string>> courseId)
        {
            var __workflow_courseId = WorkflowExpression.Compile(courseId, nameof(courseId), required: true);
            return new DeferredBodyAction<CourseVersionListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/courses/{0}/versions", __workflow_courseId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CourseVersionListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<CourseVersionSnapshotDto, ApiConnectionActionConfiguration> GetCourseVersion(Expression<Func<string>> courseId, Expression<Func<int>> versionNumber)
        {
            var __workflow_courseId = WorkflowExpression.Compile(courseId, nameof(courseId), required: true);
            var __workflow_versionNumber = WorkflowExpression.Compile(versionNumber, nameof(versionNumber), required: true);
            return new DeferredBodyAction<CourseVersionSnapshotDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/courses/{0}/versions/{1}", __workflow_courseId.WithUrlEncoding(1), __workflow_versionNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CourseVersionSnapshotDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<CertificateDto, ApiConnectionActionConfiguration> GetCertificate(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<CertificateDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/certificates/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CertificateDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> DownloadCertificatePdf(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/certificates/{0}/pdf", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UnlinkDocumentFromTopic(Expression<Func<string>> topicId, Expression<Func<string>> documentId)
        {
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/topics/{0}/linked-documents/{1}", __workflow_topicId.WithUrlEncoding(1), __workflow_documentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RemoveRoleFromExpert(Expression<Func<string>> id, Expression<Func<string>> roleId)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_roleId = WorkflowExpression.Compile(roleId, nameof(roleId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/experts/{0}/roles/{1}", __workflow_id.WithUrlEncoding(1), __workflow_roleId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UnassignDocumentFromExpert(Expression<Func<string>> id, Expression<Func<string>> documentId)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/experts/{0}/documents/{1}", __workflow_id.WithUrlEncoding(1), __workflow_documentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UnassignUserFromRole(Expression<Func<string>> id, Expression<Func<string>> roleId, Expression<Func<string>> userId)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_roleId = WorkflowExpression.Compile(roleId, nameof(roleId), required: true);
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/departments/{0}/roles/{1}/assign/{2}", __workflow_id.WithUrlEncoding(1), __workflow_roleId.WithUrlEncoding(1), __workflow_userId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RemoveRoleFromCourse(Expression<Func<string>> id, Expression<Func<string>> roleId)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_roleId = WorkflowExpression.Compile(roleId, nameof(roleId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/courses/{0}/roles/{1}", __workflow_id.WithUrlEncoding(1), __workflow_roleId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class TimemachineTriggers([ConnectionName] string connectionId)
    {
    }

    public class TopicDto
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("moduleId")]
        public string ModuleId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("ordinalNumber")]
        public int OrdinalNumber { get; set; }

        [JsonProperty("hasContent")]
        public bool HasContent { get; set; }

        [JsonProperty("quizSettings")]
        public QuizSettingDto[] QuizSettings { get; set; }
    }

    public class QuizSettingDto
    {
        [JsonProperty("questionType")]
        public string QuestionType { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class IntroDto
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("componentId")]
        public string ComponentId { get; set; }

        [JsonProperty("componentType")]
        public string ComponentType { get; set; }

        [JsonProperty("introduction")]
        public string Introduction { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }
    }

    public class ModuleDetailDto
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("courseId")]
        public string CourseId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("productId")]
        public string ProductId { get; set; }

        [JsonProperty("ordinalNumber")]
        public int OrdinalNumber { get; set; }

        [JsonProperty("lockedForGeneration")]
        public bool LockedForGeneration { get; set; }

        [JsonProperty("quizSettings")]
        public QuizSettingDto[] QuizSettings { get; set; }

        [JsonProperty("topics")]
        public TopicDto[] Topics { get; set; }
    }

    public class MediaDetailDto
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("mimeType")]
        public string MimeType { get; set; }

        [JsonProperty("sizeBytes")]
        public int SizeBytes { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("processingStatus")]
        public string ProcessingStatus { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("uploadedBy")]
        public UploadedByDto UploadedBy { get; set; }

        [JsonProperty("downloadUrl")]
        public string DownloadUrl { get; set; }
    }

    public class UploadedByDto
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class DocumentDetailDto
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("mimeType")]
        public string MimeType { get; set; }

        [JsonProperty("sizeBytes")]
        public int SizeBytes { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("uploadedBy")]
        public UploadedByDto UploadedBy { get; set; }

        [JsonProperty("downloadUrl")]
        public string DownloadUrl { get; set; }
    }

    public class UserListResponse
    {
        [JsonProperty("items")]
        public UserDto[] Items { get; set; }

        [JsonProperty("page")]
        public PageInfo Page { get; set; }
    }

    public class UserDto
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("isAdmin")]
        public bool IsAdmin { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("departmentRoles")]
        public DepartmentRoleDto[] DepartmentRoles { get; set; }
    }

    public class DepartmentRoleDto
    {
        [JsonProperty("departmentId")]
        public string DepartmentId { get; set; }

        [JsonProperty("departmentName")]
        public string DepartmentName { get; set; }

        [JsonProperty("roleId")]
        public string RoleId { get; set; }

        [JsonProperty("roleName")]
        public string RoleName { get; set; }
    }

    public class PageInfo
    {
        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("totalElements")]
        public int TotalElements { get; set; }

        [JsonProperty("totalPages")]
        public int TotalPages { get; set; }
    }

    public class QuestionListResponse
    {
        [JsonProperty("items")]
        public QuestionDto[] Items { get; set; }
    }

    public class QuestionDto
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("parentId")]
        public string ParentId { get; set; }

        [JsonProperty("parentType")]
        public string ParentType { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("ordinalNumber")]
        public int OrdinalNumber { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("expectedAnswer")]
        public string ExpectedAnswer { get; set; }

        [JsonProperty("options")]
        public QuestionOptionDto[] Options { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }
    }

    public class QuestionOptionDto
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("isCorrect")]
        public bool IsCorrect { get; set; }

        [JsonProperty("ordinalNumber")]
        public int OrdinalNumber { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodytypeInput
    {
        [EnumMember(Value = "MULTIPLE_CHOICE")]
        MULTIPLECHOICE,
        [EnumMember(Value = "OPEN_ENDED")]
        OPENENDED
    }

    public class QuestionOptionInput
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("isCorrect")]
        public bool IsCorrect { get; set; }
    }

    public class TopicLinkedDocumentListResponse
    {
        [JsonProperty("items")]
        public TopicLinkedDocumentDto[] Items { get; set; }

        [JsonProperty("page")]
        public PageInfo Page { get; set; }
    }

    public class TopicLinkedDocumentDto
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("processingStatus")]
        public string ProcessingStatus { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("linkType")]
        public string LinkType { get; set; }

        [JsonProperty("linkedAt")]
        public string LinkedAt { get; set; }
    }

    public class LearningByteListResponse
    {
        [JsonProperty("items")]
        public LearningByteDto[] Items { get; set; }
    }

    public class LearningByteDto
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("topicId")]
        public string TopicId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("ordinalNumber")]
        public int OrdinalNumber { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("lessonCount")]
        public int LessonCount { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }
    }

    public class LearningByteDetailDto
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("topicId")]
        public string TopicId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("ordinalNumber")]
        public int OrdinalNumber { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("lessons")]
        public LessonDto[] Lessons { get; set; }
    }

    public class LessonDto
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("learningByteId")]
        public string LearningByteId { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("ordinalNumber")]
        public int OrdinalNumber { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("questionCount")]
        public int QuestionCount { get; set; }

        [JsonProperty("mediaCount")]
        public int MediaCount { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }
    }

    public class ExerciseDto
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("topicId")]
        public string TopicId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("prompt")]
        public string Prompt { get; set; }

        [JsonProperty("ordinalNumber")]
        public int OrdinalNumber { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("isGenerated")]
        public bool IsGenerated { get; set; }

        [JsonProperty("avatarPictureId")]
        public string AvatarPictureId { get; set; }

        [JsonProperty("avatarCharacteristics")]
        public string AvatarCharacteristics { get; set; }

        [JsonProperty("reverseRolePlayEnabled")]
        public bool ReverseRolePlayEnabled { get; set; }

        [JsonProperty("reverseRolePlayMandatory")]
        public bool ReverseRolePlayMandatory { get; set; }

        [JsonProperty("generatedContent")]
        public ExerciseGeneratedContentDto GeneratedContent { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }
    }

    public class ExerciseGeneratedContentDto
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("regenerationId")]
        public string RegenerationId { get; set; }

        [JsonProperty("scenario")]
        public string Scenario { get; set; }

        [JsonProperty("traineeRole")]
        public string TraineeRole { get; set; }

        [JsonProperty("avatarName")]
        public string AvatarName { get; set; }

        [JsonProperty("avatarDescription")]
        public string AvatarDescription { get; set; }

        [JsonProperty("operationalChallenge")]
        public string OperationalChallenge { get; set; }

        [JsonProperty("successMetric")]
        public string SuccessMetric { get; set; }

        [JsonProperty("instruction")]
        public string Instruction { get; set; }

        [JsonProperty("instructionReverse")]
        public string InstructionReverse { get; set; }

        [JsonProperty("exerciseKnowledgeBase")]
        public string ExerciseKnowledgeBase { get; set; }

        [JsonProperty("topicKnowledgeBase")]
        public string TopicKnowledgeBase { get; set; }
    }

    public class TopicListResponse
    {
        [JsonProperty("items")]
        public TopicDto[] Items { get; set; }
    }

    public class MediaListResponse
    {
        [JsonProperty("items")]
        public MediaDto[] Items { get; set; }

        [JsonProperty("page")]
        public PageInfo Page { get; set; }
    }

    public class MediaDto
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("mimeType")]
        public string MimeType { get; set; }

        [JsonProperty("sizeBytes")]
        public int SizeBytes { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("processingStatus")]
        public string ProcessingStatus { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("uploadedBy")]
        public UploadedByDto UploadedBy { get; set; }
    }

    public class LessonListResponse
    {
        [JsonProperty("items")]
        public LessonDto[] Items { get; set; }
    }

    public class LessonDetailDto
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("learningByteId")]
        public string LearningByteId { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("ordinalNumber")]
        public int OrdinalNumber { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("media")]
        public MediaLinkDto[] Media { get; set; }

        [JsonProperty("questions")]
        public QuestionDto[] Questions { get; set; }
    }

    public class MediaLinkDto
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("fileId")]
        public string FileId { get; set; }

        [JsonProperty("ordinalNumber")]
        public int OrdinalNumber { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }
    }

    public class ExpertDetailDto
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("linkedDocumentCount")]
        public int LinkedDocumentCount { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("assignedRoleIds")]
        public string[] AssignedRoleIds { get; set; }

        [JsonProperty("assignedDepartmentIds")]
        public string[] AssignedDepartmentIds { get; set; }

        [JsonProperty("linkedDocuments")]
        public LinkedDocumentDto[] LinkedDocuments { get; set; }
    }

    public class LinkedDocumentDto
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("sizeBytes")]
        public int SizeBytes { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("linkedAt")]
        public string LinkedAt { get; set; }
    }

    public class AskResponse
    {
        [JsonProperty("answer")]
        public string Answer { get; set; }

        [JsonProperty("durationMs")]
        public int DurationMs { get; set; }
    }

    public class DocumentListResponse
    {
        [JsonProperty("items")]
        public DocumentDto[] Items { get; set; }

        [JsonProperty("page")]
        public PageInfo Page { get; set; }
    }

    public class DocumentDto
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("mimeType")]
        public string MimeType { get; set; }

        [JsonProperty("sizeBytes")]
        public int SizeBytes { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("uploadedBy")]
        public UploadedByDto UploadedBy { get; set; }
    }

    public class DepartmentListResponse
    {
        [JsonProperty("items")]
        public DepartmentDto[] Items { get; set; }
    }

    public class DepartmentDto
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("roles")]
        public DepartmentRoleDto[] Roles { get; set; }
    }

    public class DemoTrainingListResponse
    {
        [JsonProperty("items")]
        public DemoTrainingListItemDto[] Items { get; set; }

        [JsonProperty("page")]
        public PageInfo Page { get; set; }
    }

    public class DemoTrainingListItemDto
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("departmentId")]
        public string DepartmentId { get; set; }

        [JsonProperty("videoFileId")]
        public string VideoFileId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("trainingType")]
        public string TrainingType { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("isAvailable")]
        public bool IsAvailable { get; set; }

        [JsonProperty("assignedRoleIds")]
        public string[] AssignedRoleIds { get; set; }

        [JsonProperty("segmentCount")]
        public int SegmentCount { get; set; }

        [JsonProperty("durationSeconds")]
        public int DurationSeconds { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }
    }

    public class DemoTrainingDto
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("companyId")]
        public string CompanyId { get; set; }

        [JsonProperty("departmentId")]
        public string DepartmentId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("trainingType")]
        public string TrainingType { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("isAvailable")]
        public bool IsAvailable { get; set; }

        [JsonProperty("videoFileId")]
        public string VideoFileId { get; set; }

        [JsonProperty("processingPrompt")]
        public string ProcessingPrompt { get; set; }

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("assignedRoleIds")]
        public string[] AssignedRoleIds { get; set; }

        [JsonProperty("segments")]
        public DemoTrainingSegmentDto[] Segments { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }
    }

    public class DemoTrainingSegmentDto
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("ordinalNumber")]
        public int OrdinalNumber { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("transcript")]
        public string Transcript { get; set; }

        [JsonProperty("durationSeconds")]
        public int DurationSeconds { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodytrainingTypeInput
    {
        [EnumMember(Value = "DEMO_TRAINING")]
        DEMOTRAINING,
        [EnumMember(Value = "APPLICATION_TRAINING")]
        APPLICATIONTRAINING
    }

    public class CourseListResponse
    {
        [JsonProperty("items")]
        public CourseDto[] Items { get; set; }

        [JsonProperty("page")]
        public PageInfo Page { get; set; }
    }

    public class CourseDto
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("moduleCount")]
        public int ModuleCount { get; set; }

        [JsonProperty("topicCount")]
        public int TopicCount { get; set; }

        [JsonProperty("hasUnpublishedChanges")]
        public bool HasUnpublishedChanges { get; set; }

        [JsonProperty("currentVersionNumber")]
        public int CurrentVersionNumber { get; set; }

        [JsonProperty("latestPublishedAt")]
        public string LatestPublishedAt { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }
    }

    public class CourseDetailDto
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("moduleCount")]
        public int ModuleCount { get; set; }

        [JsonProperty("topicCount")]
        public int TopicCount { get; set; }

        [JsonProperty("hasUnpublishedChanges")]
        public bool HasUnpublishedChanges { get; set; }

        [JsonProperty("currentVersionNumber")]
        public int CurrentVersionNumber { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("assignedRoleIds")]
        public string[] AssignedRoleIds { get; set; }

        [JsonProperty("assignedDepartmentIds")]
        public string[] AssignedDepartmentIds { get; set; }

        [JsonProperty("modules")]
        public ModuleSummaryDto[] Modules { get; set; }
    }

    public class ModuleSummaryDto
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("ordinalNumber")]
        public int OrdinalNumber { get; set; }

        [JsonProperty("topicCount")]
        public int TopicCount { get; set; }
    }

    public class GenerationRequestResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class ModuleListResponse
    {
        [JsonProperty("items")]
        public ModuleDto[] Items { get; set; }
    }

    public class ModuleDto
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("courseId")]
        public string CourseId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("productId")]
        public string ProductId { get; set; }

        [JsonProperty("ordinalNumber")]
        public int OrdinalNumber { get; set; }

        [JsonProperty("lockedForGeneration")]
        public bool LockedForGeneration { get; set; }

        [JsonProperty("topicCount")]
        public int TopicCount { get; set; }

        [JsonProperty("quizSettings")]
        public QuizSettingDto[] QuizSettings { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodytargetInput
    {
        LESSON,
        [EnumMember(Value = "LESSON_QUESTIONS")]
        LESSONQUESTIONS,
        QUIZ,
        INTRO,
        EXERCISE
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyparentTypeInput
    {
        MODULE,
        TOPIC
    }

    public class GenerateCourseResponse
    {
        [JsonProperty("courseId")]
        public string CourseId { get; set; }

        [JsonProperty("generationRequestId")]
        public string GenerationRequestId { get; set; }
    }

    public class ModuleInput
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("topics")]
        public TopicInput[] Topics { get; set; }
    }

    public class TopicInput
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class ExerciseListResponse
    {
        [JsonProperty("items")]
        public ExerciseDto[] Items { get; set; }
    }

    public class CertificateListResponse
    {
        [JsonProperty("items")]
        public CertificateDto[] Items { get; set; }
    }

    public class CertificateDto
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("enrollmentId")]
        public string EnrollmentId { get; set; }

        [JsonProperty("studentId")]
        public string StudentId { get; set; }

        [JsonProperty("companyId")]
        public string CompanyId { get; set; }

        [JsonProperty("courseId")]
        public string CourseId { get; set; }

        [JsonProperty("courseVersionId")]
        public string CourseVersionId { get; set; }

        [JsonProperty("studentName")]
        public string StudentName { get; set; }

        [JsonProperty("companyName")]
        public string CompanyName { get; set; }

        [JsonProperty("courseName")]
        public string CourseName { get; set; }

        [JsonProperty("serialNumber")]
        public string SerialNumber { get; set; }

        [JsonProperty("completedAt")]
        public string CompletedAt { get; set; }

        [JsonProperty("issuedAt")]
        public string IssuedAt { get; set; }

        [JsonProperty("pdfFileId")]
        public string PdfFileId { get; set; }

        [JsonProperty("pdfAvailable")]
        public bool PdfAvailable { get; set; }
    }

    public class StudentInsightsDto
    {
        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("window")]
        public WindowDto Window { get; set; }

        [JsonProperty("summary")]
        public StudentSummaryDto Summary { get; set; }

        [JsonProperty("byCourse")]
        public CourseBreakdownDto[] ByCourse { get; set; }
    }

    public class WindowDto
    {
        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }
    }

    public class StudentSummaryDto
    {
        [JsonProperty("activeDays")]
        public int ActiveDays { get; set; }

        [JsonProperty("lessonsCompleted")]
        public int LessonsCompleted { get; set; }

        [JsonProperty("exercisesCompleted")]
        public int ExercisesCompleted { get; set; }

        [JsonProperty("quizzesPassed")]
        public int QuizzesPassed { get; set; }

        [JsonProperty("hoursSpent")]
        public double HoursSpent { get; set; }
    }

    public class CourseBreakdownDto
    {
        [JsonProperty("courseId")]
        public string CourseId { get; set; }

        [JsonProperty("courseName")]
        public string CourseName { get; set; }

        [JsonProperty("progressPercent")]
        public int ProgressPercent { get; set; }

        [JsonProperty("hoursSpent")]
        public double HoursSpent { get; set; }

        [JsonProperty("startedAt")]
        public string StartedAt { get; set; }

        [JsonProperty("completedAt")]
        public string CompletedAt { get; set; }
    }

    public class EventListResponse
    {
        [JsonProperty("items")]
        public EventItemDto[] Items { get; set; }

        [JsonProperty("page")]
        public PageInfo Page { get; set; }
    }

    public class EventItemDto
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("courseId")]
        public string CourseId { get; set; }

        [JsonProperty("courseName")]
        public string CourseName { get; set; }

        [JsonProperty("occurredAt")]
        public string OccurredAt { get; set; }
    }

    public class CompanyInsightsDto
    {
        [JsonProperty("companyId")]
        public string CompanyId { get; set; }

        [JsonProperty("summary")]
        public CompanySummaryDto Summary { get; set; }
    }

    public class CompanySummaryDto
    {
        [JsonProperty("totalStudents")]
        public int TotalStudents { get; set; }

        [JsonProperty("averageProgressPercent")]
        public int AverageProgressPercent { get; set; }

        [JsonProperty("activeThisWeekCount")]
        public int ActiveThisWeekCount { get; set; }

        [JsonProperty("completedCount")]
        public int CompletedCount { get; set; }

        [JsonProperty("completionRatePercent")]
        public int CompletionRatePercent { get; set; }
    }

    public class ExpertListResponse
    {
        [JsonProperty("items")]
        public ExpertDto[] Items { get; set; }

        [JsonProperty("page")]
        public PageInfo Page { get; set; }
    }

    public class ExpertDto
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("linkedDocumentCount")]
        public int LinkedDocumentCount { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }
    }

    public class GenerationStatusResponse
    {
        [JsonProperty("activeRequests")]
        public GenerationRequestInfoDto[] ActiveRequests { get; set; }
    }

    public class GenerationRequestInfoDto
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("completedAt")]
        public string CompletedAt { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("progress")]
        public GenerationProgressDto Progress { get; set; }

        [JsonProperty("target")]
        public string Target { get; set; }

        [JsonProperty("targetId")]
        public string TargetId { get; set; }

        [JsonProperty("parentType")]
        public string ParentType { get; set; }

        [JsonProperty("topicIds")]
        public string[] TopicIds { get; set; }

        [JsonProperty("moduleIds")]
        public string[] ModuleIds { get; set; }
    }

    public class GenerationProgressDto
    {
        [JsonProperty("totalTasks")]
        public int TotalTasks { get; set; }

        [JsonProperty("completedTasks")]
        public int CompletedTasks { get; set; }

        [JsonProperty("failedTasks")]
        public int FailedTasks { get; set; }
    }

    public class CourseVersionListResponse
    {
        [JsonProperty("items")]
        public CourseVersionDto[] Items { get; set; }
    }

    public class CourseVersionDto
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("courseId")]
        public string CourseId { get; set; }

        [JsonProperty("versionNumber")]
        public int VersionNumber { get; set; }

        [JsonProperty("publishedAt")]
        public string PublishedAt { get; set; }

        [JsonProperty("publishedBy")]
        public string PublishedBy { get; set; }

        [JsonProperty("moduleCount")]
        public int ModuleCount { get; set; }

        [JsonProperty("topicCount")]
        public int TopicCount { get; set; }

        [JsonProperty("lessonCount")]
        public int LessonCount { get; set; }

        [JsonProperty("exerciseCount")]
        public int ExerciseCount { get; set; }

        [JsonProperty("questionCount")]
        public int QuestionCount { get; set; }

        [JsonProperty("estimatedTimeSeconds")]
        public int EstimatedTimeSeconds { get; set; }
    }

    public class CourseVersionSnapshotDto
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("courseId")]
        public string CourseId { get; set; }

        [JsonProperty("versionNumber")]
        public int VersionNumber { get; set; }

        [JsonProperty("snapshot")]
        public CourseSnapshot Snapshot { get; set; }
    }

    public class CourseSnapshot
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("coverImageId")]
        public string CoverImageId { get; set; }

        [JsonProperty("prerequisiteCourseId")]
        public string PrerequisiteCourseId { get; set; }

        [JsonProperty("courseGuideline")]
        public string CourseGuideline { get; set; }

        [JsonProperty("lessonsGuideline")]
        public string LessonsGuideline { get; set; }

        [JsonProperty("questionsGuideline")]
        public string QuestionsGuideline { get; set; }

        [JsonProperty("exercisesGuideline")]
        public string ExercisesGuideline { get; set; }

        [JsonProperty("modules")]
        public ModuleSnapshot[] Modules { get; set; }
    }

    public class ModuleSnapshot
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("courseId")]
        public string CourseId { get; set; }

        [JsonProperty("productId")]
        public string ProductId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("intro")]
        public string Intro { get; set; }

        [JsonProperty("ordinalNumber")]
        public int OrdinalNumber { get; set; }

        [JsonProperty("quizSettings")]
        public QuizSettingSnapshot[] QuizSettings { get; set; }

        [JsonProperty("quizQuestions")]
        public QuestionSnapshot[] QuizQuestions { get; set; }

        [JsonProperty("topics")]
        public TopicSnapshot[] Topics { get; set; }
    }

    public class QuizSettingSnapshot
    {
        [JsonProperty("questionType")]
        public QuizSettingSnapshotQuestionTypeType QuestionType { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum QuizSettingSnapshotQuestionTypeType
    {
        [EnumMember(Value = "MULTIPLE_CHOICE")]
        MULTIPLECHOICE,
        [EnumMember(Value = "OPEN_ENDED")]
        OPENENDED
    }

    public class QuestionSnapshot
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("questionType")]
        public QuestionSnapshotQuestionTypeType QuestionType { get; set; }

        [JsonProperty("questionText")]
        public string QuestionText { get; set; }

        [JsonProperty("expectedAnswer")]
        public string ExpectedAnswer { get; set; }

        [JsonProperty("ordinalNumber")]
        public int OrdinalNumber { get; set; }

        [JsonProperty("source")]
        public QuestionSnapshotSourceType Source { get; set; }

        [JsonProperty("audit")]
        public AuditSnapshot Audit { get; set; }

        [JsonProperty("options")]
        public OptionSnapshot[] Options { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum QuestionSnapshotQuestionTypeType
    {
        [EnumMember(Value = "MULTIPLE_CHOICE")]
        MULTIPLECHOICE,
        [EnumMember(Value = "OPEN_ENDED")]
        OPENENDED
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum QuestionSnapshotSourceType
    {
        AI,
        MANUAL
    }

    public class AuditSnapshot
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("updatedBy")]
        public string UpdatedBy { get; set; }
    }

    public class OptionSnapshot
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("optionText")]
        public string OptionText { get; set; }

        [JsonProperty("isCorrect")]
        public bool IsCorrect { get; set; }

        [JsonProperty("ordinalNumber")]
        public int OrdinalNumber { get; set; }
    }

    public class TopicSnapshot
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("moduleId")]
        public string ModuleId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("intro")]
        public string Intro { get; set; }

        [JsonProperty("ordinalNumber")]
        public int OrdinalNumber { get; set; }

        [JsonProperty("quizSettings")]
        public QuizSettingSnapshot[] QuizSettings { get; set; }

        [JsonProperty("quizQuestions")]
        public QuestionSnapshot[] QuizQuestions { get; set; }

        [JsonProperty("learningBytes")]
        public LearningByteSnapshot[] LearningBytes { get; set; }

        [JsonProperty("exercises")]
        public ExerciseSnapshot[] Exercises { get; set; }

        [JsonProperty("linkedDocuments")]
        public LinkedDocumentSnapshot[] LinkedDocuments { get; set; }

        [JsonProperty("topicKnowledgeBase")]
        public string TopicKnowledgeBase { get; set; }
    }

    public class LearningByteSnapshot
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("topicId")]
        public string TopicId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("ordinalNumber")]
        public int OrdinalNumber { get; set; }

        [JsonProperty("source")]
        public LearningByteSnapshotSourceType Source { get; set; }

        [JsonProperty("audit")]
        public AuditSnapshot Audit { get; set; }

        [JsonProperty("lessons")]
        public LessonSnapshot[] Lessons { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum LearningByteSnapshotSourceType
    {
        AI,
        MANUAL
    }

    public class LessonSnapshot
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("learningByteId")]
        public string LearningByteId { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("ordinalNumber")]
        public int OrdinalNumber { get; set; }

        [JsonProperty("source")]
        public LessonSnapshotSourceType Source { get; set; }

        [JsonProperty("audit")]
        public AuditSnapshot Audit { get; set; }

        [JsonProperty("media")]
        public MediaSnapshot[] Media { get; set; }

        [JsonProperty("questions")]
        public QuestionSnapshot[] Questions { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum LessonSnapshotSourceType
    {
        AI,
        MANUAL
    }

    public class MediaSnapshot
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("fileId")]
        public string FileId { get; set; }

        [JsonProperty("ordinalNumber")]
        public int OrdinalNumber { get; set; }

        [JsonProperty("mediaType")]
        public MediaSnapshotMediaTypeType MediaType { get; set; }

        [JsonProperty("source")]
        public MediaSnapshotSourceType Source { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MediaSnapshotMediaTypeType
    {
        IMAGE,
        [EnumMember(Value = "VIDEO")]
        VIdEO
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MediaSnapshotSourceType
    {
        AI,
        MANUAL
    }

    public class ExerciseSnapshot
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("topicId")]
        public string TopicId { get; set; }

        [JsonProperty("exerciseType")]
        public ExerciseSnapshotExerciseTypeType ExerciseType { get; set; }

        [JsonProperty("prompt")]
        public string Prompt { get; set; }

        [JsonProperty("ordinalNumber")]
        public int OrdinalNumber { get; set; }

        [JsonProperty("isGenerated")]
        public bool IsGenerated { get; set; }

        [JsonProperty("source")]
        public ExerciseSnapshotSourceType Source { get; set; }

        [JsonProperty("audit")]
        public AuditSnapshot Audit { get; set; }

        [JsonProperty("avatarCharacteristics")]
        public string AvatarCharacteristics { get; set; }

        [JsonProperty("avatarPictureId")]
        public string AvatarPictureId { get; set; }

        [JsonProperty("reverseRolePlayEnabled")]
        public bool ReverseRolePlayEnabled { get; set; }

        [JsonProperty("reverseRolePlayMandatory")]
        public bool ReverseRolePlayMandatory { get; set; }

        [JsonProperty("scenario")]
        public string Scenario { get; set; }

        [JsonProperty("traineeRole")]
        public string TraineeRole { get; set; }

        [JsonProperty("avatarName")]
        public string AvatarName { get; set; }

        [JsonProperty("avatarDescription")]
        public string AvatarDescription { get; set; }

        [JsonProperty("operationalChallenge")]
        public string OperationalChallenge { get; set; }

        [JsonProperty("successMetric")]
        public string SuccessMetric { get; set; }

        [JsonProperty("instruction")]
        public string Instruction { get; set; }

        [JsonProperty("instructionReverse")]
        public string InstructionReverse { get; set; }

        [JsonProperty("exerciseKnowledgeBase")]
        public string ExerciseKnowledgeBase { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ExerciseSnapshotExerciseTypeType
    {
        [EnumMember(Value = "ILE_TEXT")]
        ILETEXT,
        [EnumMember(Value = "RPE_VOICE")]
        RPEVOICE,
        [EnumMember(Value = "RPE_VIDEO")]
        RPEVIdEO
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ExerciseSnapshotSourceType
    {
        AI,
        MANUAL
    }

    public class LinkedDocumentSnapshot
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("fileId")]
        public string FileId { get; set; }

        [JsonProperty("linkType")]
        public string LinkType { get; set; }

        [JsonProperty("isSupplement")]
        public bool IsSupplement { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Timemachine;

    public partial class WorkflowManagedActions
    {
        public TimemachineActions Timemachine(string connectionId) => new TimemachineActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TimemachineTriggers Timemachine(string connectionId) => new TimemachineTriggers(connectionId);
    }
}