//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Timemachine
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TimemachineActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<TopicDto> SetTopicQuizSettings([WorkflowExpression] Func<string> topicId, [WorkflowExpression] Func<string> bodyquestionType, [WorkflowExpression] Func<int> bodycount = null)
        {
            SourceExpression.Validate(topicId, nameof(topicId), required: true);
            SourceExpression.Validate(bodyquestionType, nameof(bodyquestionType), required: true);
            SourceExpression.Validate(bodycount, nameof(bodycount), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/topics/{0}/quiz-settings", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["questionType"] = SourceExpressionConverter.ConvertToken(bodyquestionType);
                if (bodycount != null)
                {
                    body["count"] = SourceExpressionConverter.ConvertToken(bodycount);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<TopicDto>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<IntroDto> GetTopicIntro([WorkflowExpression] Func<string> topicId)
        {
            SourceExpression.Validate(topicId, nameof(topicId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/topics/{0}/intro", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<IntroDto>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IWorkflowAction RemoveTopicIntro([WorkflowExpression] Func<string> topicId)
        {
            SourceExpression.Validate(topicId, nameof(topicId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/topics/{0}/intro", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<IntroDto> SetTopicIntro([WorkflowExpression] Func<string> topicId, [WorkflowExpression] Func<string> bodyintroduction = null)
        {
            SourceExpression.Validate(topicId, nameof(topicId), required: true);
            SourceExpression.Validate(bodyintroduction, nameof(bodyintroduction), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/topics/{0}/intro", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyintroduction != null)
                {
                    body["introduction"] = SourceExpressionConverter.ConvertToken(bodyintroduction);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<IntroDto>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<ModuleDetailDto> SetModuleQuizSettings([WorkflowExpression] Func<string> moduleId, [WorkflowExpression] Func<string> bodyquestionType, [WorkflowExpression] Func<int> bodycount = null)
        {
            SourceExpression.Validate(moduleId, nameof(moduleId), required: true);
            SourceExpression.Validate(bodyquestionType, nameof(bodyquestionType), required: true);
            SourceExpression.Validate(bodycount, nameof(bodycount), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/modules/{0}/quiz-settings", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(moduleId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["questionType"] = SourceExpressionConverter.ConvertToken(bodyquestionType);
                if (bodycount != null)
                {
                    body["count"] = SourceExpressionConverter.ConvertToken(bodycount);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ModuleDetailDto>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<IntroDto> GetModuleIntro([WorkflowExpression] Func<string> moduleId)
        {
            SourceExpression.Validate(moduleId, nameof(moduleId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/modules/{0}/intro", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(moduleId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<IntroDto>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IWorkflowAction RemoveModuleIntro([WorkflowExpression] Func<string> moduleId)
        {
            SourceExpression.Validate(moduleId, nameof(moduleId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/modules/{0}/intro", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(moduleId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<IntroDto> SetModuleIntro([WorkflowExpression] Func<string> moduleId, [WorkflowExpression] Func<string> bodyintroduction = null)
        {
            SourceExpression.Validate(moduleId, nameof(moduleId), required: true);
            SourceExpression.Validate(bodyintroduction, nameof(bodyintroduction), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/modules/{0}/intro", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(moduleId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyintroduction != null)
                {
                    body["introduction"] = SourceExpressionConverter.ConvertToken(bodyintroduction);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<IntroDto>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<MediaDetailDto> GetMediaItem([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/media/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<MediaDetailDto>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IWorkflowAction DeleteMedia([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/media/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<MediaDetailDto> UpdateMediaMetadata([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodydescription = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/media/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MediaDetailDto>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<DocumentDetailDto> GetDocument([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/documents/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<DocumentDetailDto>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IWorkflowAction DeleteDocument([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/documents/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<DocumentDetailDto> UpdateDocumentMetadata([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodydescription = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/documents/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DocumentDetailDto>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<UserListResponse> ListUsers([WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> status = null, [WorkflowExpression] Func<string> departmentIds = null, [WorkflowExpression] Func<string> roleIds = null, [WorkflowExpression] Func<string> kind = null)
        {
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(size, nameof(size), required: false);
            SourceExpression.Validate(search, nameof(search), required: false);
            SourceExpression.Validate(status, nameof(status), required: false);
            SourceExpression.Validate(departmentIds, nameof(departmentIds), required: false);
            SourceExpression.Validate(roleIds, nameof(roleIds), required: false);
            SourceExpression.Validate(kind, nameof(kind), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1/users";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                if (search != null)
                    callPayload.Queries["search"] = SourceExpressionConverter.ConvertO(search);
                if (status != null)
                    callPayload.Queries["status"] = SourceExpressionConverter.ConvertO(status);
                if (departmentIds != null)
                    callPayload.Queries["departmentIds"] = SourceExpressionConverter.ConvertO(departmentIds);
                if (roleIds != null)
                    callPayload.Queries["roleIds"] = SourceExpressionConverter.ConvertO(roleIds);
                if (kind != null)
                    callPayload.Queries["kind"] = SourceExpressionConverter.ConvertO(kind);
                return callPayload;
            }

            return new ApiConnectionAction<UserListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<UserDto> CreateUser([WorkflowExpression] Func<string> bodyemail, [WorkflowExpression] Func<string> bodyfirstName = null, [WorkflowExpression] Func<string> bodylastName = null, [WorkflowExpression] Func<bool> bodyisAdmin = null, [WorkflowExpression] Func<string[]> bodydepartmentRoleIds = null)
        {
            SourceExpression.Validate(bodyemail, nameof(bodyemail), required: true);
            SourceExpression.Validate(bodyfirstName, nameof(bodyfirstName), required: false);
            SourceExpression.Validate(bodylastName, nameof(bodylastName), required: false);
            SourceExpression.Validate(bodyisAdmin, nameof(bodyisAdmin), required: false);
            SourceExpression.Validate(bodydepartmentRoleIds, nameof(bodydepartmentRoleIds), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1/users";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                if (bodyfirstName != null)
                {
                    body["firstName"] = SourceExpressionConverter.ConvertToken(bodyfirstName);
                    bodypropCount++;
                }

                if (bodylastName != null)
                {
                    body["lastName"] = SourceExpressionConverter.ConvertToken(bodylastName);
                    bodypropCount++;
                }

                if (bodyisAdmin != null)
                {
                    body["isAdmin"] = SourceExpressionConverter.ConvertToken(bodyisAdmin);
                    bodypropCount++;
                }

                if (bodydepartmentRoleIds != null)
                {
                    body["departmentRoleIds"] = SourceExpressionConverter.ConvertToken(bodydepartmentRoleIds);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UserDto>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<UserDto> ReactivateUser([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/users/{0}/reactivate", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<UserDto>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<UserDto> DeactivateUser([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/users/{0}/deactivate", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<UserDto>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<QuestionListResponse> ListTopicQuizQuestions([WorkflowExpression] Func<string> topicId)
        {
            SourceExpression.Validate(topicId, nameof(topicId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/topics/{0}/quiz-questions", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<QuestionListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<QuestionDto> AddTopicQuizQuestion([WorkflowExpression] Func<string> topicId, [WorkflowExpression] Func<bodytypeInput> bodytype, [WorkflowExpression] Func<string> bodytext, [WorkflowExpression] Func<int> bodyordinalNumber = null, [WorkflowExpression] Func<QuestionOptionInput[]> bodyoptions = null, [WorkflowExpression] Func<string> bodyexpectedAnswer = null)
        {
            SourceExpression.Validate(topicId, nameof(topicId), required: true);
            SourceExpression.Validate(bodytype, nameof(bodytype), required: true);
            SourceExpression.Validate(bodytext, nameof(bodytext), required: true);
            SourceExpression.Validate(bodyordinalNumber, nameof(bodyordinalNumber), required: false);
            SourceExpression.Validate(bodyoptions, nameof(bodyoptions), required: false);
            SourceExpression.Validate(bodyexpectedAnswer, nameof(bodyexpectedAnswer), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/topics/{0}/quiz-questions", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["type"] = SourceExpressionConverter.Convert(bodytype);
                bodypropCount++;
                body["text"] = SourceExpressionConverter.ConvertToken(bodytext);
                if (bodyordinalNumber != null)
                {
                    body["ordinalNumber"] = SourceExpressionConverter.ConvertToken(bodyordinalNumber);
                    bodypropCount++;
                }

                if (bodyoptions != null)
                {
                    body["options"] = SourceExpressionConverter.ConvertToken(bodyoptions);
                    bodypropCount++;
                }

                if (bodyexpectedAnswer != null)
                {
                    body["expectedAnswer"] = SourceExpressionConverter.ConvertToken(bodyexpectedAnswer);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<QuestionDto>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<QuestionListResponse> ReorderTopicQuizQuestions([WorkflowExpression] Func<string> topicId, [WorkflowExpression] Func<string[]> bodyquestionIds)
        {
            SourceExpression.Validate(topicId, nameof(topicId), required: true);
            SourceExpression.Validate(bodyquestionIds, nameof(bodyquestionIds), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/topics/{0}/quiz-questions/reorder", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["questionIds"] = SourceExpressionConverter.ConvertToken(bodyquestionIds);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<QuestionListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<TopicDto> MoveTopic([WorkflowExpression] Func<string> topicId, [WorkflowExpression] Func<string> bodytargetModuleId, [WorkflowExpression] Func<int> bodytargetOrdinalNumber = null)
        {
            SourceExpression.Validate(topicId, nameof(topicId), required: true);
            SourceExpression.Validate(bodytargetModuleId, nameof(bodytargetModuleId), required: true);
            SourceExpression.Validate(bodytargetOrdinalNumber, nameof(bodytargetOrdinalNumber), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/topics/{0}/move", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["targetModuleId"] = SourceExpressionConverter.ConvertToken(bodytargetModuleId);
                if (bodytargetOrdinalNumber != null)
                {
                    body["targetOrdinalNumber"] = SourceExpressionConverter.ConvertToken(bodytargetOrdinalNumber);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<TopicDto>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<TopicLinkedDocumentListResponse> ListTopicLinkedDocuments([WorkflowExpression] Func<string> topicId, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<string> search = null)
        {
            SourceExpression.Validate(topicId, nameof(topicId), required: true);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(size, nameof(size), required: false);
            SourceExpression.Validate(search, nameof(search), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/topics/{0}/linked-documents", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                if (search != null)
                    callPayload.Queries["search"] = SourceExpressionConverter.ConvertO(search);
                return callPayload;
            }

            return new ApiConnectionAction<TopicLinkedDocumentListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IWorkflowAction LinkDocumentsToTopic([WorkflowExpression] Func<string> topicId, [WorkflowExpression] Func<string[]> bodydocumentIds)
        {
            SourceExpression.Validate(topicId, nameof(topicId), required: true);
            SourceExpression.Validate(bodydocumentIds, nameof(bodydocumentIds), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/topics/{0}/linked-documents", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["documentIds"] = SourceExpressionConverter.ConvertToken(bodydocumentIds);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<LearningByteListResponse> ListLearningBytesInTopic([WorkflowExpression] Func<string> topicId)
        {
            SourceExpression.Validate(topicId, nameof(topicId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/topics/{0}/learning-bytes", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<LearningByteListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<LearningByteDetailDto> AddLearningByteToTopic([WorkflowExpression] Func<string> topicId, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodydescription = null)
        {
            SourceExpression.Validate(topicId, nameof(topicId), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/topics/{0}/learning-bytes", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<LearningByteDetailDto>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<ExerciseDto> AddRpeVoiceExercise([WorkflowExpression] Func<string> topicId, [WorkflowExpression] Func<string> bodyprompt = null, [WorkflowExpression] Func<string> bodyavatarPictureId = null, [WorkflowExpression] Func<string> bodyavatarCharacteristics = null, [WorkflowExpression] Func<bool> bodyreverseRolePlayEnabled = null, [WorkflowExpression] Func<bool> bodyreverseRolePlayMandatory = null)
        {
            SourceExpression.Validate(topicId, nameof(topicId), required: true);
            SourceExpression.Validate(bodyprompt, nameof(bodyprompt), required: false);
            SourceExpression.Validate(bodyavatarPictureId, nameof(bodyavatarPictureId), required: false);
            SourceExpression.Validate(bodyavatarCharacteristics, nameof(bodyavatarCharacteristics), required: false);
            SourceExpression.Validate(bodyreverseRolePlayEnabled, nameof(bodyreverseRolePlayEnabled), required: false);
            SourceExpression.Validate(bodyreverseRolePlayMandatory, nameof(bodyreverseRolePlayMandatory), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/topics/{0}/exercises/rpe-voice", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyprompt != null)
                {
                    body["prompt"] = SourceExpressionConverter.ConvertToken(bodyprompt);
                    bodypropCount++;
                }

                if (bodyavatarPictureId != null)
                {
                    body["avatarPictureId"] = SourceExpressionConverter.ConvertToken(bodyavatarPictureId);
                    bodypropCount++;
                }

                if (bodyavatarCharacteristics != null)
                {
                    body["avatarCharacteristics"] = SourceExpressionConverter.ConvertToken(bodyavatarCharacteristics);
                    bodypropCount++;
                }

                if (bodyreverseRolePlayEnabled != null)
                {
                    body["reverseRolePlayEnabled"] = SourceExpressionConverter.ConvertToken(bodyreverseRolePlayEnabled);
                    bodypropCount++;
                }

                if (bodyreverseRolePlayMandatory != null)
                {
                    body["reverseRolePlayMandatory"] = SourceExpressionConverter.ConvertToken(bodyreverseRolePlayMandatory);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ExerciseDto>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<ExerciseDto> AddRpeVideoExercise([WorkflowExpression] Func<string> topicId, [WorkflowExpression] Func<string> bodyprompt = null, [WorkflowExpression] Func<string> bodyavatarPictureId = null, [WorkflowExpression] Func<string> bodyavatarCharacteristics = null, [WorkflowExpression] Func<bool> bodyreverseRolePlayEnabled = null, [WorkflowExpression] Func<bool> bodyreverseRolePlayMandatory = null)
        {
            SourceExpression.Validate(topicId, nameof(topicId), required: true);
            SourceExpression.Validate(bodyprompt, nameof(bodyprompt), required: false);
            SourceExpression.Validate(bodyavatarPictureId, nameof(bodyavatarPictureId), required: false);
            SourceExpression.Validate(bodyavatarCharacteristics, nameof(bodyavatarCharacteristics), required: false);
            SourceExpression.Validate(bodyreverseRolePlayEnabled, nameof(bodyreverseRolePlayEnabled), required: false);
            SourceExpression.Validate(bodyreverseRolePlayMandatory, nameof(bodyreverseRolePlayMandatory), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/topics/{0}/exercises/rpe-video", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyprompt != null)
                {
                    body["prompt"] = SourceExpressionConverter.ConvertToken(bodyprompt);
                    bodypropCount++;
                }

                if (bodyavatarPictureId != null)
                {
                    body["avatarPictureId"] = SourceExpressionConverter.ConvertToken(bodyavatarPictureId);
                    bodypropCount++;
                }

                if (bodyavatarCharacteristics != null)
                {
                    body["avatarCharacteristics"] = SourceExpressionConverter.ConvertToken(bodyavatarCharacteristics);
                    bodypropCount++;
                }

                if (bodyreverseRolePlayEnabled != null)
                {
                    body["reverseRolePlayEnabled"] = SourceExpressionConverter.ConvertToken(bodyreverseRolePlayEnabled);
                    bodypropCount++;
                }

                if (bodyreverseRolePlayMandatory != null)
                {
                    body["reverseRolePlayMandatory"] = SourceExpressionConverter.ConvertToken(bodyreverseRolePlayMandatory);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ExerciseDto>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<ExerciseDto> AddIleTextExercise([WorkflowExpression] Func<string> topicId, [WorkflowExpression] Func<string> bodyprompt = null)
        {
            SourceExpression.Validate(topicId, nameof(topicId), required: true);
            SourceExpression.Validate(bodyprompt, nameof(bodyprompt), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/topics/{0}/exercises/ile-text", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyprompt != null)
                {
                    body["prompt"] = SourceExpressionConverter.ConvertToken(bodyprompt);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ExerciseDto>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<TopicListResponse> ListTopicsInModule([WorkflowExpression] Func<string> moduleId)
        {
            SourceExpression.Validate(moduleId, nameof(moduleId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/modules/{0}/topics", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(moduleId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<TopicListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<TopicDto> AddTopicToModule([WorkflowExpression] Func<string> moduleId, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodydescription = null)
        {
            SourceExpression.Validate(moduleId, nameof(moduleId), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/modules/{0}/topics", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(moduleId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<TopicDto>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<TopicListResponse> ReorderTopicsInModule([WorkflowExpression] Func<string> moduleId, [WorkflowExpression] Func<string[]> bodytopicIds)
        {
            SourceExpression.Validate(moduleId, nameof(moduleId), required: true);
            SourceExpression.Validate(bodytopicIds, nameof(bodytopicIds), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/modules/{0}/topics/reorder", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(moduleId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["topicIds"] = SourceExpressionConverter.ConvertToken(bodytopicIds);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<TopicListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<QuestionListResponse> ListModuleQuizQuestions([WorkflowExpression] Func<string> moduleId)
        {
            SourceExpression.Validate(moduleId, nameof(moduleId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/modules/{0}/quiz-questions", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(moduleId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<QuestionListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<QuestionDto> AddModuleQuizQuestion([WorkflowExpression] Func<string> moduleId, [WorkflowExpression] Func<bodytypeInput> bodytype, [WorkflowExpression] Func<string> bodytext, [WorkflowExpression] Func<int> bodyordinalNumber = null, [WorkflowExpression] Func<QuestionOptionInput[]> bodyoptions = null, [WorkflowExpression] Func<string> bodyexpectedAnswer = null)
        {
            SourceExpression.Validate(moduleId, nameof(moduleId), required: true);
            SourceExpression.Validate(bodytype, nameof(bodytype), required: true);
            SourceExpression.Validate(bodytext, nameof(bodytext), required: true);
            SourceExpression.Validate(bodyordinalNumber, nameof(bodyordinalNumber), required: false);
            SourceExpression.Validate(bodyoptions, nameof(bodyoptions), required: false);
            SourceExpression.Validate(bodyexpectedAnswer, nameof(bodyexpectedAnswer), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/modules/{0}/quiz-questions", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(moduleId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["type"] = SourceExpressionConverter.Convert(bodytype);
                bodypropCount++;
                body["text"] = SourceExpressionConverter.ConvertToken(bodytext);
                if (bodyordinalNumber != null)
                {
                    body["ordinalNumber"] = SourceExpressionConverter.ConvertToken(bodyordinalNumber);
                    bodypropCount++;
                }

                if (bodyoptions != null)
                {
                    body["options"] = SourceExpressionConverter.ConvertToken(bodyoptions);
                    bodypropCount++;
                }

                if (bodyexpectedAnswer != null)
                {
                    body["expectedAnswer"] = SourceExpressionConverter.ConvertToken(bodyexpectedAnswer);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<QuestionDto>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<QuestionListResponse> ReorderModuleQuizQuestions([WorkflowExpression] Func<string> moduleId, [WorkflowExpression] Func<string[]> bodyquestionIds)
        {
            SourceExpression.Validate(moduleId, nameof(moduleId), required: true);
            SourceExpression.Validate(bodyquestionIds, nameof(bodyquestionIds), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/modules/{0}/quiz-questions/reorder", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(moduleId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["questionIds"] = SourceExpressionConverter.ConvertToken(bodyquestionIds);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<QuestionListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<MediaListResponse> ListMedia([WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> kind = null, [WorkflowExpression] Func<string> status = null)
        {
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(size, nameof(size), required: false);
            SourceExpression.Validate(search, nameof(search), required: false);
            SourceExpression.Validate(kind, nameof(kind), required: false);
            SourceExpression.Validate(status, nameof(status), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1/media";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                if (search != null)
                    callPayload.Queries["search"] = SourceExpressionConverter.ConvertO(search);
                if (kind != null)
                    callPayload.Queries["kind"] = SourceExpressionConverter.ConvertO(kind);
                if (status != null)
                    callPayload.Queries["status"] = SourceExpressionConverter.ConvertO(status);
                return callPayload;
            }

            return new ApiConnectionAction<MediaListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<QuestionListResponse> ListLessonQuestions([WorkflowExpression] Func<string> lessonId)
        {
            SourceExpression.Validate(lessonId, nameof(lessonId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/lessons/{0}/questions", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(lessonId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<QuestionListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<QuestionDto> AddLessonQuestion([WorkflowExpression] Func<string> lessonId, [WorkflowExpression] Func<bodytypeInput> bodytype, [WorkflowExpression] Func<string> bodytext, [WorkflowExpression] Func<int> bodyordinalNumber = null, [WorkflowExpression] Func<QuestionOptionInput[]> bodyoptions = null, [WorkflowExpression] Func<string> bodyexpectedAnswer = null)
        {
            SourceExpression.Validate(lessonId, nameof(lessonId), required: true);
            SourceExpression.Validate(bodytype, nameof(bodytype), required: true);
            SourceExpression.Validate(bodytext, nameof(bodytext), required: true);
            SourceExpression.Validate(bodyordinalNumber, nameof(bodyordinalNumber), required: false);
            SourceExpression.Validate(bodyoptions, nameof(bodyoptions), required: false);
            SourceExpression.Validate(bodyexpectedAnswer, nameof(bodyexpectedAnswer), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/lessons/{0}/questions", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(lessonId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["type"] = SourceExpressionConverter.Convert(bodytype);
                bodypropCount++;
                body["text"] = SourceExpressionConverter.ConvertToken(bodytext);
                if (bodyordinalNumber != null)
                {
                    body["ordinalNumber"] = SourceExpressionConverter.ConvertToken(bodyordinalNumber);
                    bodypropCount++;
                }

                if (bodyoptions != null)
                {
                    body["options"] = SourceExpressionConverter.ConvertToken(bodyoptions);
                    bodypropCount++;
                }

                if (bodyexpectedAnswer != null)
                {
                    body["expectedAnswer"] = SourceExpressionConverter.ConvertToken(bodyexpectedAnswer);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<QuestionDto>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<QuestionListResponse> ReorderLessonQuestions([WorkflowExpression] Func<string> lessonId, [WorkflowExpression] Func<string[]> bodyquestionIds)
        {
            SourceExpression.Validate(lessonId, nameof(lessonId), required: true);
            SourceExpression.Validate(bodyquestionIds, nameof(bodyquestionIds), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/lessons/{0}/questions/reorder", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(lessonId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["questionIds"] = SourceExpressionConverter.ConvertToken(bodyquestionIds);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<QuestionListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<LessonListResponse> ListLessonsInLearningByte([WorkflowExpression] Func<string> lbId)
        {
            SourceExpression.Validate(lbId, nameof(lbId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/learning-bytes/{0}/lessons", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(lbId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<LessonListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<LessonDetailDto> AddLessonToLearningByte([WorkflowExpression] Func<string> lbId, [WorkflowExpression] Func<string> bodycontent)
        {
            SourceExpression.Validate(lbId, nameof(lbId), required: true);
            SourceExpression.Validate(bodycontent, nameof(bodycontent), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/learning-bytes/{0}/lessons", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(lbId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["content"] = SourceExpressionConverter.ConvertToken(bodycontent);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<LessonDetailDto>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IWorkflowAction RemoveAllRolesFromExpert([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/experts/{0}/roles", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<ExpertDetailDto> AssignRolesToExpert([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string[]> bodyroleIds)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodyroleIds, nameof(bodyroleIds), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/experts/{0}/roles", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["roleIds"] = SourceExpressionConverter.ConvertToken(bodyroleIds);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ExpertDetailDto>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<ExpertDetailDto> AssignDocumentsToExpert([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string[]> bodydocumentIds)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodydocumentIds, nameof(bodydocumentIds), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/experts/{0}/documents", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["documentIds"] = SourceExpressionConverter.ConvertToken(bodydocumentIds);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ExpertDetailDto>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<AskResponse> AskExpert([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyquestion)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodyquestion, nameof(bodyquestion), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/experts/{0}/ask", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["question"] = SourceExpressionConverter.ConvertToken(bodyquestion);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AskResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<DocumentListResponse> ListDocuments([WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> mimeTypes = null, [WorkflowExpression] Func<string> status = null)
        {
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(size, nameof(size), required: false);
            SourceExpression.Validate(search, nameof(search), required: false);
            SourceExpression.Validate(mimeTypes, nameof(mimeTypes), required: false);
            SourceExpression.Validate(status, nameof(status), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1/documents";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                if (search != null)
                    callPayload.Queries["search"] = SourceExpressionConverter.ConvertO(search);
                if (mimeTypes != null)
                    callPayload.Queries["mimeTypes"] = SourceExpressionConverter.ConvertO(mimeTypes);
                if (status != null)
                    callPayload.Queries["status"] = SourceExpressionConverter.ConvertO(status);
                return callPayload;
            }

            return new ApiConnectionAction<DocumentListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<DepartmentListResponse> ListDepartments()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1/departments";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<DepartmentListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<DepartmentDto> CreateDepartment([WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodydescription = null)
        {
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1/departments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DepartmentDto>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<DepartmentDto> CreateRoleInDepartment([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodyfullName = null, [WorkflowExpression] Func<string> bodydescription = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            SourceExpression.Validate(bodyfullName, nameof(bodyfullName), required: false);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/departments/{0}/roles", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                if (bodyfullName != null)
                {
                    body["fullName"] = SourceExpressionConverter.ConvertToken(bodyfullName);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DepartmentDto>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<DepartmentDto> AssignUserToRole([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> roleId, [WorkflowExpression] Func<string> bodyuserId)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(roleId, nameof(roleId), required: true);
            SourceExpression.Validate(bodyuserId, nameof(bodyuserId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/departments/{0}/roles/{1}/assign", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(roleId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["userId"] = SourceExpressionConverter.ConvertToken(bodyuserId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DepartmentDto>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<DemoTrainingListResponse> ListDemoTrainings([WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> trainingTypes = null, [WorkflowExpression] Func<string> statuses = null, [WorkflowExpression] Func<string> departmentIds = null, [WorkflowExpression] Func<bool> isAvailable = null)
        {
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(size, nameof(size), required: false);
            SourceExpression.Validate(search, nameof(search), required: false);
            SourceExpression.Validate(trainingTypes, nameof(trainingTypes), required: false);
            SourceExpression.Validate(statuses, nameof(statuses), required: false);
            SourceExpression.Validate(departmentIds, nameof(departmentIds), required: false);
            SourceExpression.Validate(isAvailable, nameof(isAvailable), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1/demo-trainings";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                if (search != null)
                    callPayload.Queries["search"] = SourceExpressionConverter.ConvertO(search);
                if (trainingTypes != null)
                    callPayload.Queries["trainingTypes"] = SourceExpressionConverter.ConvertO(trainingTypes);
                if (statuses != null)
                    callPayload.Queries["statuses"] = SourceExpressionConverter.ConvertO(statuses);
                if (departmentIds != null)
                    callPayload.Queries["departmentIds"] = SourceExpressionConverter.ConvertO(departmentIds);
                if (isAvailable != null)
                    callPayload.Queries["isAvailable"] = SourceExpressionConverter.ConvertO(isAvailable);
                return callPayload;
            }

            return new ApiConnectionAction<DemoTrainingListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<DemoTrainingDto> CreateDemoTraining([WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<bodytrainingTypeInput> bodytrainingType, [WorkflowExpression] Func<string> bodyvideoFileId, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodydepartmentId = null, [WorkflowExpression] Func<string> bodyprocessingPrompt = null)
        {
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            SourceExpression.Validate(bodytrainingType, nameof(bodytrainingType), required: true);
            SourceExpression.Validate(bodyvideoFileId, nameof(bodyvideoFileId), required: true);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            SourceExpression.Validate(bodydepartmentId, nameof(bodydepartmentId), required: false);
            SourceExpression.Validate(bodyprocessingPrompt, nameof(bodyprocessingPrompt), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1/demo-trainings";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                bodypropCount++;
                body["trainingType"] = SourceExpressionConverter.Convert(bodytrainingType);
                bodypropCount++;
                body["videoFileId"] = SourceExpressionConverter.ConvertToken(bodyvideoFileId);
                if (bodydepartmentId != null)
                {
                    body["departmentId"] = SourceExpressionConverter.ConvertToken(bodydepartmentId);
                    bodypropCount++;
                }

                if (bodyprocessingPrompt != null)
                {
                    body["processingPrompt"] = SourceExpressionConverter.ConvertToken(bodyprocessingPrompt);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DemoTrainingDto>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<DemoTrainingDto> ReprocessDemoTraining([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyprocessingPrompt = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodyprocessingPrompt, nameof(bodyprocessingPrompt), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/demo-trainings/{0}/reprocess", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyprocessingPrompt != null)
                {
                    body["processingPrompt"] = SourceExpressionConverter.ConvertToken(bodyprocessingPrompt);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DemoTrainingDto>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<DemoTrainingDto> UpdateDemoTrainingAvailability([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<bool> bodyavailable)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodyavailable, nameof(bodyavailable), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/demo-trainings/{0}/availability", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["available"] = SourceExpressionConverter.ConvertToken(bodyavailable);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DemoTrainingDto>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<CourseListResponse> ListCourses([WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> status = null, [WorkflowExpression] Func<string> departmentRoleIds = null)
        {
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(size, nameof(size), required: false);
            SourceExpression.Validate(search, nameof(search), required: false);
            SourceExpression.Validate(status, nameof(status), required: false);
            SourceExpression.Validate(departmentRoleIds, nameof(departmentRoleIds), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1/courses";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                if (search != null)
                    callPayload.Queries["search"] = SourceExpressionConverter.ConvertO(search);
                if (status != null)
                    callPayload.Queries["status"] = SourceExpressionConverter.ConvertO(status);
                if (departmentRoleIds != null)
                    callPayload.Queries["departmentRoleIds"] = SourceExpressionConverter.ConvertO(departmentRoleIds);
                return callPayload;
            }

            return new ApiConnectionAction<CourseListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<CourseDetailDto> CreateCourse([WorkflowExpression] Func<string> bodyname)
        {
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1/courses";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CourseDetailDto>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IWorkflowAction RemoveAllRolesFromCourse([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/courses/{0}/roles", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<CourseDetailDto> AssignRolesToCourse([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string[]> bodyroleIds)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodyroleIds, nameof(bodyroleIds), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/courses/{0}/roles", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["roleIds"] = SourceExpressionConverter.ConvertToken(bodyroleIds);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CourseDetailDto>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<CourseDetailDto> PublishCourse([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/courses/{0}/publish", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<CourseDetailDto>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<GenerationRequestResponse> GenerateCourseContent([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string[]> bodytopicIds)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodytopicIds, nameof(bodytopicIds), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/courses/{0}/generate-content", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["topicIds"] = SourceExpressionConverter.ConvertToken(bodytopicIds);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GenerationRequestResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<ModuleListResponse> ListModulesInCourse([WorkflowExpression] Func<string> courseId)
        {
            SourceExpression.Validate(courseId, nameof(courseId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/courses/{0}/modules", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(courseId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ModuleListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<ModuleDetailDto> AddModuleToCourse([WorkflowExpression] Func<string> courseId, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodydescription = null)
        {
            SourceExpression.Validate(courseId, nameof(courseId), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/courses/{0}/modules", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(courseId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ModuleDetailDto>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<ModuleListResponse> ReorderModulesInCourse([WorkflowExpression] Func<string> courseId, [WorkflowExpression] Func<string[]> bodymoduleIds)
        {
            SourceExpression.Validate(courseId, nameof(courseId), required: true);
            SourceExpression.Validate(bodymoduleIds, nameof(bodymoduleIds), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/courses/{0}/modules/reorder", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(courseId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["moduleIds"] = SourceExpressionConverter.ConvertToken(bodymoduleIds);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ModuleListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<GenerationRequestResponse> RegenerateCourseItem([WorkflowExpression] Func<bodytargetInput> bodytarget, [WorkflowExpression] Func<string> bodytargetId, [WorkflowExpression] Func<bodyparentTypeInput> bodyparentType = null)
        {
            SourceExpression.Validate(bodytarget, nameof(bodytarget), required: true);
            SourceExpression.Validate(bodytargetId, nameof(bodytargetId), required: true);
            SourceExpression.Validate(bodyparentType, nameof(bodyparentType), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1/courses/regenerate-item";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["target"] = SourceExpressionConverter.Convert(bodytarget);
                bodypropCount++;
                body["targetId"] = SourceExpressionConverter.ConvertToken(bodytargetId);
                if (bodyparentType != null)
                {
                    body["parentType"] = SourceExpressionConverter.Convert(bodyparentType);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GenerationRequestResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<GenerateCourseResponse> GenerateCourse([WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<ModuleInput[]> bodymodules, [WorkflowExpression] Func<string> bodydescription = null)
        {
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            SourceExpression.Validate(bodymodules, nameof(bodymodules), required: true);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1/courses/generate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                bodypropCount++;
                body["modules"] = SourceExpressionConverter.ConvertToken(bodymodules);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GenerateCourseResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<UserDto> GetUser([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/users/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<UserDto>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<UserDto> UpdateUser([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyfirstName = null, [WorkflowExpression] Func<string> bodylastName = null, [WorkflowExpression] Func<bool> bodyisAdmin = null, [WorkflowExpression] Func<string[]> bodydepartmentRoleIds = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodyfirstName, nameof(bodyfirstName), required: false);
            SourceExpression.Validate(bodylastName, nameof(bodylastName), required: false);
            SourceExpression.Validate(bodyisAdmin, nameof(bodyisAdmin), required: false);
            SourceExpression.Validate(bodydepartmentRoleIds, nameof(bodydepartmentRoleIds), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/users/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfirstName != null)
                {
                    body["firstName"] = SourceExpressionConverter.ConvertToken(bodyfirstName);
                    bodypropCount++;
                }

                if (bodylastName != null)
                {
                    body["lastName"] = SourceExpressionConverter.ConvertToken(bodylastName);
                    bodypropCount++;
                }

                if (bodyisAdmin != null)
                {
                    body["isAdmin"] = SourceExpressionConverter.ConvertToken(bodyisAdmin);
                    bodypropCount++;
                }

                if (bodydepartmentRoleIds != null)
                {
                    body["departmentRoleIds"] = SourceExpressionConverter.ConvertToken(bodydepartmentRoleIds);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UserDto>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<TopicDto> GetTopic([WorkflowExpression] Func<string> topicId)
        {
            SourceExpression.Validate(topicId, nameof(topicId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/topics/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<TopicDto>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IWorkflowAction DeleteTopic([WorkflowExpression] Func<string> topicId)
        {
            SourceExpression.Validate(topicId, nameof(topicId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/topics/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<TopicDto> UpdateTopic([WorkflowExpression] Func<string> topicId, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodydescription = null)
        {
            SourceExpression.Validate(topicId, nameof(topicId), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/topics/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<TopicDto>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<QuestionDto> GetTopicQuizQuestion([WorkflowExpression] Func<string> topicId, [WorkflowExpression] Func<string> questionId)
        {
            SourceExpression.Validate(topicId, nameof(topicId), required: true);
            SourceExpression.Validate(questionId, nameof(questionId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/topics/{0}/quiz-questions/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(questionId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<QuestionDto>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IWorkflowAction DeleteTopicQuizQuestion([WorkflowExpression] Func<string> topicId, [WorkflowExpression] Func<string> questionId)
        {
            SourceExpression.Validate(topicId, nameof(topicId), required: true);
            SourceExpression.Validate(questionId, nameof(questionId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/topics/{0}/quiz-questions/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(questionId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<QuestionDto> UpdateTopicQuizQuestion([WorkflowExpression] Func<string> topicId, [WorkflowExpression] Func<string> questionId, [WorkflowExpression] Func<string> bodytext = null, [WorkflowExpression] Func<QuestionOptionInput[]> bodyoptions = null, [WorkflowExpression] Func<string> bodyexpectedAnswer = null)
        {
            SourceExpression.Validate(topicId, nameof(topicId), required: true);
            SourceExpression.Validate(questionId, nameof(questionId), required: true);
            SourceExpression.Validate(bodytext, nameof(bodytext), required: false);
            SourceExpression.Validate(bodyoptions, nameof(bodyoptions), required: false);
            SourceExpression.Validate(bodyexpectedAnswer, nameof(bodyexpectedAnswer), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/topics/{0}/quiz-questions/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(questionId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytext != null)
                {
                    body["text"] = SourceExpressionConverter.ConvertToken(bodytext);
                    bodypropCount++;
                }

                if (bodyoptions != null)
                {
                    body["options"] = SourceExpressionConverter.ConvertToken(bodyoptions);
                    bodypropCount++;
                }

                if (bodyexpectedAnswer != null)
                {
                    body["expectedAnswer"] = SourceExpressionConverter.ConvertToken(bodyexpectedAnswer);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<QuestionDto>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<ModuleDetailDto> GetModule([WorkflowExpression] Func<string> moduleId)
        {
            SourceExpression.Validate(moduleId, nameof(moduleId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/modules/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(moduleId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ModuleDetailDto>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IWorkflowAction DeleteModule([WorkflowExpression] Func<string> moduleId)
        {
            SourceExpression.Validate(moduleId, nameof(moduleId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/modules/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(moduleId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<ModuleDetailDto> UpdateModule([WorkflowExpression] Func<string> moduleId, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodydescription = null)
        {
            SourceExpression.Validate(moduleId, nameof(moduleId), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/modules/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(moduleId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ModuleDetailDto>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<QuestionDto> GetModuleQuizQuestion([WorkflowExpression] Func<string> moduleId, [WorkflowExpression] Func<string> questionId)
        {
            SourceExpression.Validate(moduleId, nameof(moduleId), required: true);
            SourceExpression.Validate(questionId, nameof(questionId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/modules/{0}/quiz-questions/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(moduleId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(questionId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<QuestionDto>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IWorkflowAction DeleteModuleQuizQuestion([WorkflowExpression] Func<string> moduleId, [WorkflowExpression] Func<string> questionId)
        {
            SourceExpression.Validate(moduleId, nameof(moduleId), required: true);
            SourceExpression.Validate(questionId, nameof(questionId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/modules/{0}/quiz-questions/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(moduleId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(questionId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<QuestionDto> UpdateModuleQuizQuestion([WorkflowExpression] Func<string> moduleId, [WorkflowExpression] Func<string> questionId, [WorkflowExpression] Func<string> bodytext = null, [WorkflowExpression] Func<QuestionOptionInput[]> bodyoptions = null, [WorkflowExpression] Func<string> bodyexpectedAnswer = null)
        {
            SourceExpression.Validate(moduleId, nameof(moduleId), required: true);
            SourceExpression.Validate(questionId, nameof(questionId), required: true);
            SourceExpression.Validate(bodytext, nameof(bodytext), required: false);
            SourceExpression.Validate(bodyoptions, nameof(bodyoptions), required: false);
            SourceExpression.Validate(bodyexpectedAnswer, nameof(bodyexpectedAnswer), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/modules/{0}/quiz-questions/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(moduleId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(questionId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytext != null)
                {
                    body["text"] = SourceExpressionConverter.ConvertToken(bodytext);
                    bodypropCount++;
                }

                if (bodyoptions != null)
                {
                    body["options"] = SourceExpressionConverter.ConvertToken(bodyoptions);
                    bodypropCount++;
                }

                if (bodyexpectedAnswer != null)
                {
                    body["expectedAnswer"] = SourceExpressionConverter.ConvertToken(bodyexpectedAnswer);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<QuestionDto>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<LessonDetailDto> GetLesson([WorkflowExpression] Func<string> lessonId)
        {
            SourceExpression.Validate(lessonId, nameof(lessonId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/lessons/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(lessonId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<LessonDetailDto>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IWorkflowAction DeleteLesson([WorkflowExpression] Func<string> lessonId)
        {
            SourceExpression.Validate(lessonId, nameof(lessonId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/lessons/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(lessonId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<LessonDetailDto> UpdateLesson([WorkflowExpression] Func<string> lessonId, [WorkflowExpression] Func<string> bodycontent = null)
        {
            SourceExpression.Validate(lessonId, nameof(lessonId), required: true);
            SourceExpression.Validate(bodycontent, nameof(bodycontent), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/lessons/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(lessonId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycontent != null)
                {
                    body["content"] = SourceExpressionConverter.ConvertToken(bodycontent);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<LessonDetailDto>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<QuestionDto> GetLessonQuestion([WorkflowExpression] Func<string> lessonId, [WorkflowExpression] Func<string> questionId)
        {
            SourceExpression.Validate(lessonId, nameof(lessonId), required: true);
            SourceExpression.Validate(questionId, nameof(questionId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/lessons/{0}/questions/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(lessonId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(questionId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<QuestionDto>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IWorkflowAction DeleteLessonQuestion([WorkflowExpression] Func<string> lessonId, [WorkflowExpression] Func<string> questionId)
        {
            SourceExpression.Validate(lessonId, nameof(lessonId), required: true);
            SourceExpression.Validate(questionId, nameof(questionId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/lessons/{0}/questions/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(lessonId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(questionId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<QuestionDto> UpdateLessonQuestion([WorkflowExpression] Func<string> lessonId, [WorkflowExpression] Func<string> questionId, [WorkflowExpression] Func<string> bodytext = null, [WorkflowExpression] Func<QuestionOptionInput[]> bodyoptions = null, [WorkflowExpression] Func<string> bodyexpectedAnswer = null)
        {
            SourceExpression.Validate(lessonId, nameof(lessonId), required: true);
            SourceExpression.Validate(questionId, nameof(questionId), required: true);
            SourceExpression.Validate(bodytext, nameof(bodytext), required: false);
            SourceExpression.Validate(bodyoptions, nameof(bodyoptions), required: false);
            SourceExpression.Validate(bodyexpectedAnswer, nameof(bodyexpectedAnswer), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/lessons/{0}/questions/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(lessonId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(questionId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytext != null)
                {
                    body["text"] = SourceExpressionConverter.ConvertToken(bodytext);
                    bodypropCount++;
                }

                if (bodyoptions != null)
                {
                    body["options"] = SourceExpressionConverter.ConvertToken(bodyoptions);
                    bodypropCount++;
                }

                if (bodyexpectedAnswer != null)
                {
                    body["expectedAnswer"] = SourceExpressionConverter.ConvertToken(bodyexpectedAnswer);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<QuestionDto>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<LearningByteDetailDto> GetLearningByte([WorkflowExpression] Func<string> lbId)
        {
            SourceExpression.Validate(lbId, nameof(lbId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/learning-bytes/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(lbId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<LearningByteDetailDto>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IWorkflowAction DeleteLearningByte([WorkflowExpression] Func<string> lbId)
        {
            SourceExpression.Validate(lbId, nameof(lbId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/learning-bytes/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(lbId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<LearningByteDetailDto> UpdateLearningByte([WorkflowExpression] Func<string> lbId, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodydescription = null)
        {
            SourceExpression.Validate(lbId, nameof(lbId), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/learning-bytes/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(lbId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<LearningByteDetailDto>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<ExerciseDto> GetExercise([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/exercises/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ExerciseDto>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IWorkflowAction DeleteExercise([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/exercises/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<ExerciseDto> UpdateExercise([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyprompt = null, [WorkflowExpression] Func<string> bodyavatarPictureId = null, [WorkflowExpression] Func<string> bodyavatarCharacteristics = null, [WorkflowExpression] Func<bool> bodyreverseRolePlayEnabled = null, [WorkflowExpression] Func<bool> bodyreverseRolePlayMandatory = null, [WorkflowExpression] Func<string> bodygeneratedContentscenario = null, [WorkflowExpression] Func<string> bodygeneratedContenttraineeRole = null, [WorkflowExpression] Func<string> bodygeneratedContentavatarName = null, [WorkflowExpression] Func<string> bodygeneratedContentavatarDescription = null, [WorkflowExpression] Func<string> bodygeneratedContentoperationalChallenge = null, [WorkflowExpression] Func<string> bodygeneratedContentsuccessMetric = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodyprompt, nameof(bodyprompt), required: false);
            SourceExpression.Validate(bodyavatarPictureId, nameof(bodyavatarPictureId), required: false);
            SourceExpression.Validate(bodyavatarCharacteristics, nameof(bodyavatarCharacteristics), required: false);
            SourceExpression.Validate(bodyreverseRolePlayEnabled, nameof(bodyreverseRolePlayEnabled), required: false);
            SourceExpression.Validate(bodyreverseRolePlayMandatory, nameof(bodyreverseRolePlayMandatory), required: false);
            SourceExpression.Validate(bodygeneratedContentscenario, nameof(bodygeneratedContentscenario), required: false);
            SourceExpression.Validate(bodygeneratedContenttraineeRole, nameof(bodygeneratedContenttraineeRole), required: false);
            SourceExpression.Validate(bodygeneratedContentavatarName, nameof(bodygeneratedContentavatarName), required: false);
            SourceExpression.Validate(bodygeneratedContentavatarDescription, nameof(bodygeneratedContentavatarDescription), required: false);
            SourceExpression.Validate(bodygeneratedContentoperationalChallenge, nameof(bodygeneratedContentoperationalChallenge), required: false);
            SourceExpression.Validate(bodygeneratedContentsuccessMetric, nameof(bodygeneratedContentsuccessMetric), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/exercises/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyprompt != null)
                {
                    body["prompt"] = SourceExpressionConverter.ConvertToken(bodyprompt);
                    bodypropCount++;
                }

                if (bodyavatarPictureId != null)
                {
                    body["avatarPictureId"] = SourceExpressionConverter.ConvertToken(bodyavatarPictureId);
                    bodypropCount++;
                }

                if (bodyavatarCharacteristics != null)
                {
                    body["avatarCharacteristics"] = SourceExpressionConverter.ConvertToken(bodyavatarCharacteristics);
                    bodypropCount++;
                }

                if (bodyreverseRolePlayEnabled != null)
                {
                    body["reverseRolePlayEnabled"] = SourceExpressionConverter.ConvertToken(bodyreverseRolePlayEnabled);
                    bodypropCount++;
                }

                if (bodyreverseRolePlayMandatory != null)
                {
                    body["reverseRolePlayMandatory"] = SourceExpressionConverter.ConvertToken(bodyreverseRolePlayMandatory);
                    bodypropCount++;
                }

                var generatedContentObject = new JObject();
                var generatedContentObjectpropCount = 0;
                if (bodygeneratedContentscenario != null)
                {
                    generatedContentObject["scenario"] = SourceExpressionConverter.ConvertToken(bodygeneratedContentscenario);
                    generatedContentObjectpropCount++;
                }

                if (bodygeneratedContenttraineeRole != null)
                {
                    generatedContentObject["traineeRole"] = SourceExpressionConverter.ConvertToken(bodygeneratedContenttraineeRole);
                    generatedContentObjectpropCount++;
                }

                if (bodygeneratedContentavatarName != null)
                {
                    generatedContentObject["avatarName"] = SourceExpressionConverter.ConvertToken(bodygeneratedContentavatarName);
                    generatedContentObjectpropCount++;
                }

                if (bodygeneratedContentavatarDescription != null)
                {
                    generatedContentObject["avatarDescription"] = SourceExpressionConverter.ConvertToken(bodygeneratedContentavatarDescription);
                    generatedContentObjectpropCount++;
                }

                if (bodygeneratedContentoperationalChallenge != null)
                {
                    generatedContentObject["operationalChallenge"] = SourceExpressionConverter.ConvertToken(bodygeneratedContentoperationalChallenge);
                    generatedContentObjectpropCount++;
                }

                if (bodygeneratedContentsuccessMetric != null)
                {
                    generatedContentObject["successMetric"] = SourceExpressionConverter.ConvertToken(bodygeneratedContentsuccessMetric);
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
                return callPayload;
            }

            return new ApiConnectionAction<ExerciseDto>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IWorkflowAction DeleteDepartment([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/departments/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<DepartmentDto> UpdateDepartment([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodydescription = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/departments/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DepartmentDto>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<DemoTrainingDto> GetDemoTraining([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/demo-trainings/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<DemoTrainingDto>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IWorkflowAction DeleteDemoTraining([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/demo-trainings/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<DemoTrainingDto> UpdateDemoTraining([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<bodytrainingTypeInput> bodytrainingType = null, [WorkflowExpression] Func<string> bodydepartmentId = null, [WorkflowExpression] Func<string[]> bodyassignedRoleIds = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            SourceExpression.Validate(bodytrainingType, nameof(bodytrainingType), required: false);
            SourceExpression.Validate(bodydepartmentId, nameof(bodydepartmentId), required: false);
            SourceExpression.Validate(bodyassignedRoleIds, nameof(bodyassignedRoleIds), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/demo-trainings/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodytrainingType != null)
                {
                    body["trainingType"] = SourceExpressionConverter.Convert(bodytrainingType);
                    bodypropCount++;
                }

                if (bodydepartmentId != null)
                {
                    body["departmentId"] = SourceExpressionConverter.ConvertToken(bodydepartmentId);
                    bodypropCount++;
                }

                if (bodyassignedRoleIds != null)
                {
                    body["assignedRoleIds"] = SourceExpressionConverter.ConvertToken(bodyassignedRoleIds);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DemoTrainingDto>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<CourseDetailDto> GetCourse([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/courses/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<CourseDetailDto>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IWorkflowAction DeleteCourse([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/courses/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<CourseDetailDto> UpdateCourse([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyname = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/courses/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CourseDetailDto>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<ExerciseListResponse> ListExercisesInTopic([WorkflowExpression] Func<string> topicId)
        {
            SourceExpression.Validate(topicId, nameof(topicId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/topics/{0}/exercises", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ExerciseListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<CertificateListResponse> ListStudentCertificates([WorkflowExpression] Func<string> userId)
        {
            SourceExpression.Validate(userId, nameof(userId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/students/{0}/certificates", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<CertificateListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<StudentInsightsDto> GetStudentInsights([WorkflowExpression] Func<string> userId, [WorkflowExpression] Func<string> window = null)
        {
            SourceExpression.Validate(userId, nameof(userId), required: true);
            SourceExpression.Validate(window, nameof(window), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/insights/students/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (window != null)
                    callPayload.Queries["window"] = SourceExpressionConverter.ConvertO(window);
                return callPayload;
            }

            return new ApiConnectionAction<StudentInsightsDto>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<EventListResponse> ListStudentEvents([WorkflowExpression] Func<string> userId, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> size = null)
        {
            SourceExpression.Validate(userId, nameof(userId), required: true);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(size, nameof(size), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/insights/students/{0}/events", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                return callPayload;
            }

            return new ApiConnectionAction<EventListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<CompanyInsightsDto> GetCompanyInsights()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1/insights/company";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<CompanyInsightsDto>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<ExpertListResponse> ListExperts([WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<string> search = null)
        {
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(size, nameof(size), required: false);
            SourceExpression.Validate(search, nameof(search), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1/experts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                if (search != null)
                    callPayload.Queries["search"] = SourceExpressionConverter.ConvertO(search);
                return callPayload;
            }

            return new ApiConnectionAction<ExpertListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<ExpertDetailDto> GetExpert([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/experts/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ExpertDetailDto>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<GenerationStatusResponse> GetCourseGenerationStatus([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/courses/{0}/generation-status", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GenerationStatusResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<CourseVersionListResponse> ListCourseVersions([WorkflowExpression] Func<string> courseId)
        {
            SourceExpression.Validate(courseId, nameof(courseId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/courses/{0}/versions", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(courseId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<CourseVersionListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<CourseVersionSnapshotDto> GetCourseVersion([WorkflowExpression] Func<string> courseId, [WorkflowExpression] Func<int> versionNumber)
        {
            SourceExpression.Validate(courseId, nameof(courseId), required: true);
            SourceExpression.Validate(versionNumber, nameof(versionNumber), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/courses/{0}/versions/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(courseId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(versionNumber, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<CourseVersionSnapshotDto>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<CertificateDto> GetCertificate([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/certificates/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<CertificateDto>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IBodyWorkflowAction<JToken> DownloadCertificatePdf([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/certificates/{0}/pdf", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IWorkflowAction UnlinkDocumentFromTopic([WorkflowExpression] Func<string> topicId, [WorkflowExpression] Func<string> documentId)
        {
            SourceExpression.Validate(topicId, nameof(topicId), required: true);
            SourceExpression.Validate(documentId, nameof(documentId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/topics/{0}/linked-documents/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(documentId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IWorkflowAction RemoveRoleFromExpert([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> roleId)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(roleId, nameof(roleId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/experts/{0}/roles/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(roleId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IWorkflowAction UnassignDocumentFromExpert([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> documentId)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(documentId, nameof(documentId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/experts/{0}/documents/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(documentId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IWorkflowAction UnassignUserFromRole([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> roleId, [WorkflowExpression] Func<string> userId)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(roleId, nameof(roleId), required: true);
            SourceExpression.Validate(userId, nameof(userId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/departments/{0}/roles/{1}/assign/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(roleId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timemachine")]
        public IWorkflowAction RemoveRoleFromCourse([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> roleId)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(roleId, nameof(roleId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/courses/{0}/roles/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(roleId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
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

    public enum bodytargetInput
    {
        LESSON,
        [EnumMember(Value = "LESSON_QUESTIONS")]
        LESSONQUESTIONS,
        QUIZ,
        INTRO,
        EXERCISE
    }

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

    public enum QuestionSnapshotQuestionTypeType
    {
        [EnumMember(Value = "MULTIPLE_CHOICE")]
        MULTIPLECHOICE,
        [EnumMember(Value = "OPEN_ENDED")]
        OPENENDED
    }

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

    public enum MediaSnapshotMediaTypeType
    {
        IMAGE,
        [EnumMember(Value = "VIDEO")]
        VIdEO
    }

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

    public enum ExerciseSnapshotExerciseTypeType
    {
        [EnumMember(Value = "ILE_TEXT")]
        ILETEXT,
        [EnumMember(Value = "RPE_VOICE")]
        RPEVOICE,
        [EnumMember(Value = "RPE_VIDEO")]
        RPEVIdEO
    }

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