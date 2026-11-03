//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Imanagework
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ImanageworkActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagework")]
        public IBodyWorkflowAction<GetTrusteesResponse, ApiConnectionActionConfiguration> GetTrustees(Expression<Func<bodyobjectTypeInput>> bodyobjectType, Expression<Func<string>> bodyobjectId)
        {
            var __workflow_bodyobjectType = WorkflowExpression.Compile(bodyobjectType, nameof(bodyobjectType), required: true);
            var __workflow_bodyobjectId = WorkflowExpression.Compile(bodyobjectId, nameof(bodyobjectId), required: true);
            return new DeferredBodyAction<GetTrusteesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/getTrustees";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["objectType"] = ExpressionConverter.ConvertO(__workflow_bodyobjectType);
                bodypropCount++;
                body["objectId"] = ExpressionConverter.ConvertO(__workflow_bodyobjectId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GetTrusteesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagework")]
        public IBodyWorkflowAction<UpdateDefaultSecurityResponse, ApiConnectionActionConfiguration> UpdateDefaultSecurity(Expression<Func<bodyobjectTypeInput>> bodyobjectType, Expression<Func<string>> bodyobjectId, Expression<Func<string>> bodydefaultSecurity)
        {
            var __workflow_bodyobjectType = WorkflowExpression.Compile(bodyobjectType, nameof(bodyobjectType), required: true);
            var __workflow_bodyobjectId = WorkflowExpression.Compile(bodyobjectId, nameof(bodyobjectId), required: true);
            var __workflow_bodydefaultSecurity = WorkflowExpression.Compile(bodydefaultSecurity, nameof(bodydefaultSecurity), required: true);
            return new DeferredBodyAction<UpdateDefaultSecurityResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/updateDefaultSecurity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["objectType"] = ExpressionConverter.ConvertO(__workflow_bodyobjectType);
                bodypropCount++;
                body["objectId"] = ExpressionConverter.ConvertO(__workflow_bodyobjectId);
                bodypropCount++;
                body["default_security"] = ExpressionConverter.ConvertO(__workflow_bodydefaultSecurity);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UpdateDefaultSecurityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagework")]
        public IBodyWorkflowAction<UpdatePermissionsResponse, ApiConnectionActionConfiguration> UpdatePermissions(Expression<Func<bodyobjectTypeInput>> bodyobjectType, Expression<Func<string>> bodyobjectId, Expression<Func<bodyaccessLevelInput>> bodyaccessLevel, Expression<Func<string>> bodyusers = null, Expression<Func<string>> bodygroups = null)
        {
            var __workflow_bodyobjectType = WorkflowExpression.Compile(bodyobjectType, nameof(bodyobjectType), required: true);
            var __workflow_bodyobjectId = WorkflowExpression.Compile(bodyobjectId, nameof(bodyobjectId), required: true);
            var __workflow_bodyaccessLevel = WorkflowExpression.Compile(bodyaccessLevel, nameof(bodyaccessLevel), required: true);
            var __workflow_bodyusers = WorkflowExpression.Compile(bodyusers, nameof(bodyusers), required: false);
            var __workflow_bodygroups = WorkflowExpression.Compile(bodygroups, nameof(bodygroups), required: false);
            return new DeferredBodyAction<UpdatePermissionsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/updatePermissions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["objectType"] = ExpressionConverter.ConvertO(__workflow_bodyobjectType);
                bodypropCount++;
                body["objectId"] = ExpressionConverter.ConvertO(__workflow_bodyobjectId);
                bodypropCount++;
                body["access_level"] = ExpressionConverter.ConvertO(__workflow_bodyaccessLevel);
                if (__workflow_bodyusers != null)
                {
                    body["users"] = ExpressionConverter.ConvertO(__workflow_bodyusers);
                    bodypropCount++;
                }

                if (__workflow_bodygroups != null)
                {
                    body["groups"] = ExpressionConverter.ConvertO(__workflow_bodygroups);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UpdatePermissionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagework")]
        public IBodyWorkflowAction<GetPermissionsResponse, ApiConnectionActionConfiguration> GetPermissions(Expression<Func<bodyobjectTypeInput>> bodyobjectType, Expression<Func<string>> bodyobjectId)
        {
            var __workflow_bodyobjectType = WorkflowExpression.Compile(bodyobjectType, nameof(bodyobjectType), required: true);
            var __workflow_bodyobjectId = WorkflowExpression.Compile(bodyobjectId, nameof(bodyobjectId), required: true);
            return new DeferredBodyAction<GetPermissionsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/getPermissions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["objectType"] = ExpressionConverter.ConvertO(__workflow_bodyobjectType);
                bodypropCount++;
                body["objectId"] = ExpressionConverter.ConvertO(__workflow_bodyobjectId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GetPermissionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagework")]
        public IBodyWorkflowAction<UpdatePermissionsResponse, ApiConnectionActionConfiguration> CopyPermissions(Expression<Func<bodysourceObjectTypeInput>> bodysourceObjectType, Expression<Func<string>> bodysourceObjectId, Expression<Func<bodytargetObjectTypeInput>> bodytargetObjectType, Expression<Func<string>> bodytargetObjectId, Expression<Func<bodycopyTypeInput>> bodycopyType, Expression<Func<bool>> bodycopyDefaultSecurity)
        {
            var __workflow_bodysourceObjectType = WorkflowExpression.Compile(bodysourceObjectType, nameof(bodysourceObjectType), required: true);
            var __workflow_bodysourceObjectId = WorkflowExpression.Compile(bodysourceObjectId, nameof(bodysourceObjectId), required: true);
            var __workflow_bodytargetObjectType = WorkflowExpression.Compile(bodytargetObjectType, nameof(bodytargetObjectType), required: true);
            var __workflow_bodytargetObjectId = WorkflowExpression.Compile(bodytargetObjectId, nameof(bodytargetObjectId), required: true);
            var __workflow_bodycopyType = WorkflowExpression.Compile(bodycopyType, nameof(bodycopyType), required: true);
            var __workflow_bodycopyDefaultSecurity = WorkflowExpression.Compile(bodycopyDefaultSecurity, nameof(bodycopyDefaultSecurity), required: true);
            return new DeferredBodyAction<UpdatePermissionsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/copyPermissions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["sourceObjectType"] = ExpressionConverter.ConvertO(__workflow_bodysourceObjectType);
                bodypropCount++;
                body["sourceObjectId"] = ExpressionConverter.ConvertO(__workflow_bodysourceObjectId);
                bodypropCount++;
                body["targetObjectType"] = ExpressionConverter.ConvertO(__workflow_bodytargetObjectType);
                bodypropCount++;
                body["targetObjectId"] = ExpressionConverter.ConvertO(__workflow_bodytargetObjectId);
                bodypropCount++;
                body["copyType"] = ExpressionConverter.ConvertO(__workflow_bodycopyType);
                bodypropCount++;
                body["copyDefaultSecurity"] = ExpressionConverter.ConvertO(__workflow_bodycopyDefaultSecurity);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UpdatePermissionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagework")]
        public IBodyWorkflowAction<WorkspaceProfileResponseBody, ApiConnectionActionConfiguration> CreateWorkspace(Expression<Func<string>> bodylibraryId, Expression<Func<string>> bodytemplateId, Expression<Func<string>> bodyname, Expression<Func<bodycreateChildrenInput>> bodycreateChildren, Expression<Func<string>> bodyowner = null, Expression<Func<bodydefaultSecurityInput>> bodydefaultSecurity = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodycustom1 = null, Expression<Func<string>> bodycustom2 = null, Expression<Func<string>> bodycustom3 = null, Expression<Func<string>> bodycustom4 = null, Expression<Func<string>> bodycustom5 = null, Expression<Func<string>> bodycustom6 = null, Expression<Func<string>> bodycustom7 = null, Expression<Func<string>> bodycustom8 = null, Expression<Func<string>> bodycustom9 = null, Expression<Func<string>> bodycustom10 = null, Expression<Func<string>> bodycustom11 = null, Expression<Func<string>> bodycustom12 = null, Expression<Func<string>> bodycustom13 = null, Expression<Func<string>> bodycustom14 = null, Expression<Func<string>> bodycustom15 = null, Expression<Func<string>> bodycustom16 = null, Expression<Func<double>> bodycustom17 = null, Expression<Func<double>> bodycustom18 = null, Expression<Func<double>> bodycustom19 = null, Expression<Func<double>> bodycustom20 = null, Expression<Func<string>> bodycustom21 = null, Expression<Func<string>> bodycustom22 = null, Expression<Func<string>> bodycustom23 = null, Expression<Func<string>> bodycustom24 = null, Expression<Func<bool>> bodycustom25 = null, Expression<Func<bool>> bodycustom26 = null, Expression<Func<bool>> bodycustom27 = null, Expression<Func<bool>> bodycustom28 = null, Expression<Func<string>> bodycustom29 = null, Expression<Func<string>> bodycustom30 = null, Expression<Func<bool>> bodyisExternalAsNormal = null, Expression<Func<string>> bodyprojectCustom1 = null, Expression<Func<string>> bodyprojectCustom2 = null, Expression<Func<string>> bodyprojectCustom3 = null, Expression<Func<string>> bodysubclass = null)
        {
            var __workflow_bodylibraryId = WorkflowExpression.Compile(bodylibraryId, nameof(bodylibraryId), required: true);
            var __workflow_bodytemplateId = WorkflowExpression.Compile(bodytemplateId, nameof(bodytemplateId), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodycreateChildren = WorkflowExpression.Compile(bodycreateChildren, nameof(bodycreateChildren), required: true);
            var __workflow_bodyowner = WorkflowExpression.Compile(bodyowner, nameof(bodyowner), required: false);
            var __workflow_bodydefaultSecurity = WorkflowExpression.Compile(bodydefaultSecurity, nameof(bodydefaultSecurity), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodycustom1 = WorkflowExpression.Compile(bodycustom1, nameof(bodycustom1), required: false);
            var __workflow_bodycustom2 = WorkflowExpression.Compile(bodycustom2, nameof(bodycustom2), required: false);
            var __workflow_bodycustom3 = WorkflowExpression.Compile(bodycustom3, nameof(bodycustom3), required: false);
            var __workflow_bodycustom4 = WorkflowExpression.Compile(bodycustom4, nameof(bodycustom4), required: false);
            var __workflow_bodycustom5 = WorkflowExpression.Compile(bodycustom5, nameof(bodycustom5), required: false);
            var __workflow_bodycustom6 = WorkflowExpression.Compile(bodycustom6, nameof(bodycustom6), required: false);
            var __workflow_bodycustom7 = WorkflowExpression.Compile(bodycustom7, nameof(bodycustom7), required: false);
            var __workflow_bodycustom8 = WorkflowExpression.Compile(bodycustom8, nameof(bodycustom8), required: false);
            var __workflow_bodycustom9 = WorkflowExpression.Compile(bodycustom9, nameof(bodycustom9), required: false);
            var __workflow_bodycustom10 = WorkflowExpression.Compile(bodycustom10, nameof(bodycustom10), required: false);
            var __workflow_bodycustom11 = WorkflowExpression.Compile(bodycustom11, nameof(bodycustom11), required: false);
            var __workflow_bodycustom12 = WorkflowExpression.Compile(bodycustom12, nameof(bodycustom12), required: false);
            var __workflow_bodycustom13 = WorkflowExpression.Compile(bodycustom13, nameof(bodycustom13), required: false);
            var __workflow_bodycustom14 = WorkflowExpression.Compile(bodycustom14, nameof(bodycustom14), required: false);
            var __workflow_bodycustom15 = WorkflowExpression.Compile(bodycustom15, nameof(bodycustom15), required: false);
            var __workflow_bodycustom16 = WorkflowExpression.Compile(bodycustom16, nameof(bodycustom16), required: false);
            var __workflow_bodycustom17 = WorkflowExpression.Compile(bodycustom17, nameof(bodycustom17), required: false);
            var __workflow_bodycustom18 = WorkflowExpression.Compile(bodycustom18, nameof(bodycustom18), required: false);
            var __workflow_bodycustom19 = WorkflowExpression.Compile(bodycustom19, nameof(bodycustom19), required: false);
            var __workflow_bodycustom20 = WorkflowExpression.Compile(bodycustom20, nameof(bodycustom20), required: false);
            var __workflow_bodycustom21 = WorkflowExpression.Compile(bodycustom21, nameof(bodycustom21), required: false);
            var __workflow_bodycustom22 = WorkflowExpression.Compile(bodycustom22, nameof(bodycustom22), required: false);
            var __workflow_bodycustom23 = WorkflowExpression.Compile(bodycustom23, nameof(bodycustom23), required: false);
            var __workflow_bodycustom24 = WorkflowExpression.Compile(bodycustom24, nameof(bodycustom24), required: false);
            var __workflow_bodycustom25 = WorkflowExpression.Compile(bodycustom25, nameof(bodycustom25), required: false);
            var __workflow_bodycustom26 = WorkflowExpression.Compile(bodycustom26, nameof(bodycustom26), required: false);
            var __workflow_bodycustom27 = WorkflowExpression.Compile(bodycustom27, nameof(bodycustom27), required: false);
            var __workflow_bodycustom28 = WorkflowExpression.Compile(bodycustom28, nameof(bodycustom28), required: false);
            var __workflow_bodycustom29 = WorkflowExpression.Compile(bodycustom29, nameof(bodycustom29), required: false);
            var __workflow_bodycustom30 = WorkflowExpression.Compile(bodycustom30, nameof(bodycustom30), required: false);
            var __workflow_bodyisExternalAsNormal = WorkflowExpression.Compile(bodyisExternalAsNormal, nameof(bodyisExternalAsNormal), required: false);
            var __workflow_bodyprojectCustom1 = WorkflowExpression.Compile(bodyprojectCustom1, nameof(bodyprojectCustom1), required: false);
            var __workflow_bodyprojectCustom2 = WorkflowExpression.Compile(bodyprojectCustom2, nameof(bodyprojectCustom2), required: false);
            var __workflow_bodyprojectCustom3 = WorkflowExpression.Compile(bodyprojectCustom3, nameof(bodyprojectCustom3), required: false);
            var __workflow_bodysubclass = WorkflowExpression.Compile(bodysubclass, nameof(bodysubclass), required: false);
            return new DeferredBodyAction<WorkspaceProfileResponseBody, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/createWorkspace";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["libraryId"] = ExpressionConverter.ConvertO(__workflow_bodylibraryId);
                bodypropCount++;
                body["templateId"] = ExpressionConverter.ConvertO(__workflow_bodytemplateId);
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                bodypropCount++;
                body["createChildren"] = ExpressionConverter.ConvertO(__workflow_bodycreateChildren);
                if (__workflow_bodyowner != null)
                {
                    body["owner"] = ExpressionConverter.ConvertO(__workflow_bodyowner);
                    bodypropCount++;
                }

                if (__workflow_bodydefaultSecurity != null)
                {
                    body["default_security"] = ExpressionConverter.ConvertO(__workflow_bodydefaultSecurity);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    if (__workflow_bodydescription != null)
                    {
                        body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["description"] = "Created from iManage Work Connector";
                    bodypropCount++;
                }

                if (__workflow_bodycustom1 != null)
                {
                    body["custom1"] = ExpressionConverter.ConvertO(__workflow_bodycustom1);
                    bodypropCount++;
                }

                if (__workflow_bodycustom2 != null)
                {
                    body["custom2"] = ExpressionConverter.ConvertO(__workflow_bodycustom2);
                    bodypropCount++;
                }

                if (__workflow_bodycustom3 != null)
                {
                    body["custom3"] = ExpressionConverter.ConvertO(__workflow_bodycustom3);
                    bodypropCount++;
                }

                if (__workflow_bodycustom4 != null)
                {
                    body["custom4"] = ExpressionConverter.ConvertO(__workflow_bodycustom4);
                    bodypropCount++;
                }

                if (__workflow_bodycustom5 != null)
                {
                    body["custom5"] = ExpressionConverter.ConvertO(__workflow_bodycustom5);
                    bodypropCount++;
                }

                if (__workflow_bodycustom6 != null)
                {
                    body["custom6"] = ExpressionConverter.ConvertO(__workflow_bodycustom6);
                    bodypropCount++;
                }

                if (__workflow_bodycustom7 != null)
                {
                    body["custom7"] = ExpressionConverter.ConvertO(__workflow_bodycustom7);
                    bodypropCount++;
                }

                if (__workflow_bodycustom8 != null)
                {
                    body["custom8"] = ExpressionConverter.ConvertO(__workflow_bodycustom8);
                    bodypropCount++;
                }

                if (__workflow_bodycustom9 != null)
                {
                    body["custom9"] = ExpressionConverter.ConvertO(__workflow_bodycustom9);
                    bodypropCount++;
                }

                if (__workflow_bodycustom10 != null)
                {
                    body["custom10"] = ExpressionConverter.ConvertO(__workflow_bodycustom10);
                    bodypropCount++;
                }

                if (__workflow_bodycustom11 != null)
                {
                    body["custom11"] = ExpressionConverter.ConvertO(__workflow_bodycustom11);
                    bodypropCount++;
                }

                if (__workflow_bodycustom12 != null)
                {
                    body["custom12"] = ExpressionConverter.ConvertO(__workflow_bodycustom12);
                    bodypropCount++;
                }

                if (__workflow_bodycustom13 != null)
                {
                    body["custom13"] = ExpressionConverter.ConvertO(__workflow_bodycustom13);
                    bodypropCount++;
                }

                if (__workflow_bodycustom14 != null)
                {
                    body["custom14"] = ExpressionConverter.ConvertO(__workflow_bodycustom14);
                    bodypropCount++;
                }

                if (__workflow_bodycustom15 != null)
                {
                    body["custom15"] = ExpressionConverter.ConvertO(__workflow_bodycustom15);
                    bodypropCount++;
                }

                if (__workflow_bodycustom16 != null)
                {
                    body["custom16"] = ExpressionConverter.ConvertO(__workflow_bodycustom16);
                    bodypropCount++;
                }

                if (__workflow_bodycustom17 != null)
                {
                    body["custom17"] = ExpressionConverter.ConvertO(__workflow_bodycustom17);
                    bodypropCount++;
                }

                if (__workflow_bodycustom18 != null)
                {
                    body["custom18"] = ExpressionConverter.ConvertO(__workflow_bodycustom18);
                    bodypropCount++;
                }

                if (__workflow_bodycustom19 != null)
                {
                    body["custom19"] = ExpressionConverter.ConvertO(__workflow_bodycustom19);
                    bodypropCount++;
                }

                if (__workflow_bodycustom20 != null)
                {
                    body["custom20"] = ExpressionConverter.ConvertO(__workflow_bodycustom20);
                    bodypropCount++;
                }

                if (__workflow_bodycustom21 != null)
                {
                    body["custom21"] = ExpressionConverter.ConvertO(__workflow_bodycustom21);
                    bodypropCount++;
                }

                if (__workflow_bodycustom22 != null)
                {
                    body["custom22"] = ExpressionConverter.ConvertO(__workflow_bodycustom22);
                    bodypropCount++;
                }

                if (__workflow_bodycustom23 != null)
                {
                    body["custom23"] = ExpressionConverter.ConvertO(__workflow_bodycustom23);
                    bodypropCount++;
                }

                if (__workflow_bodycustom24 != null)
                {
                    body["custom24"] = ExpressionConverter.ConvertO(__workflow_bodycustom24);
                    bodypropCount++;
                }

                if (__workflow_bodycustom25 != null)
                {
                    body["custom25"] = ExpressionConverter.ConvertO(__workflow_bodycustom25);
                    bodypropCount++;
                }

                if (__workflow_bodycustom26 != null)
                {
                    body["custom26"] = ExpressionConverter.ConvertO(__workflow_bodycustom26);
                    bodypropCount++;
                }

                if (__workflow_bodycustom27 != null)
                {
                    body["custom27"] = ExpressionConverter.ConvertO(__workflow_bodycustom27);
                    bodypropCount++;
                }

                if (__workflow_bodycustom28 != null)
                {
                    body["custom28"] = ExpressionConverter.ConvertO(__workflow_bodycustom28);
                    bodypropCount++;
                }

                if (__workflow_bodycustom29 != null)
                {
                    body["custom29"] = ExpressionConverter.ConvertO(__workflow_bodycustom29);
                    bodypropCount++;
                }

                if (__workflow_bodycustom30 != null)
                {
                    body["custom30"] = ExpressionConverter.ConvertO(__workflow_bodycustom30);
                    bodypropCount++;
                }

                if (__workflow_bodyisExternalAsNormal != null)
                {
                    body["is_external_as_normal"] = ExpressionConverter.ConvertO(__workflow_bodyisExternalAsNormal);
                    bodypropCount++;
                }

                if (__workflow_bodyprojectCustom1 != null)
                {
                    body["project_custom1"] = ExpressionConverter.ConvertO(__workflow_bodyprojectCustom1);
                    bodypropCount++;
                }

                if (__workflow_bodyprojectCustom2 != null)
                {
                    body["project_custom2"] = ExpressionConverter.ConvertO(__workflow_bodyprojectCustom2);
                    bodypropCount++;
                }

                if (__workflow_bodyprojectCustom3 != null)
                {
                    body["project_custom3"] = ExpressionConverter.ConvertO(__workflow_bodyprojectCustom3);
                    bodypropCount++;
                }

                if (__workflow_bodysubclass != null)
                {
                    body["subclass"] = ExpressionConverter.ConvertO(__workflow_bodysubclass);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<WorkspaceProfileResponseBody>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagework")]
        public IBodyWorkflowAction<WorkspaceProfileResponseBody, ApiConnectionActionConfiguration> UpdateWorkspace(Expression<Func<string>> bodyid, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodyowner = null, Expression<Func<string>> bodycustom1 = null, Expression<Func<string>> bodycustom2 = null, Expression<Func<string>> bodycustom3 = null, Expression<Func<string>> bodycustom4 = null, Expression<Func<string>> bodycustom5 = null, Expression<Func<string>> bodycustom6 = null, Expression<Func<string>> bodycustom7 = null, Expression<Func<string>> bodycustom8 = null, Expression<Func<string>> bodycustom9 = null, Expression<Func<string>> bodycustom10 = null, Expression<Func<string>> bodycustom11 = null, Expression<Func<string>> bodycustom12 = null, Expression<Func<string>> bodycustom13 = null, Expression<Func<string>> bodycustom14 = null, Expression<Func<string>> bodycustom15 = null, Expression<Func<string>> bodycustom16 = null, Expression<Func<double>> bodycustom17 = null, Expression<Func<double>> bodycustom18 = null, Expression<Func<double>> bodycustom19 = null, Expression<Func<double>> bodycustom20 = null, Expression<Func<string>> bodycustom21 = null, Expression<Func<string>> bodycustom22 = null, Expression<Func<string>> bodycustom23 = null, Expression<Func<string>> bodycustom24 = null, Expression<Func<bool>> bodycustom25 = null, Expression<Func<bool>> bodycustom26 = null, Expression<Func<bool>> bodycustom27 = null, Expression<Func<bool>> bodycustom28 = null, Expression<Func<string>> bodycustom29 = null, Expression<Func<string>> bodycustom30 = null, Expression<Func<bodydefaultSecurityInput>> bodydefaultSecurity = null, Expression<Func<string>> bodydescription = null, Expression<Func<bool>> bodyisExternalAsNormal = null, Expression<Func<string>> bodyprojectCustom1 = null, Expression<Func<string>> bodyprojectCustom2 = null, Expression<Func<string>> bodyprojectCustom3 = null, Expression<Func<string>> bodysubclass = null)
        {
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodyowner = WorkflowExpression.Compile(bodyowner, nameof(bodyowner), required: false);
            var __workflow_bodycustom1 = WorkflowExpression.Compile(bodycustom1, nameof(bodycustom1), required: false);
            var __workflow_bodycustom2 = WorkflowExpression.Compile(bodycustom2, nameof(bodycustom2), required: false);
            var __workflow_bodycustom3 = WorkflowExpression.Compile(bodycustom3, nameof(bodycustom3), required: false);
            var __workflow_bodycustom4 = WorkflowExpression.Compile(bodycustom4, nameof(bodycustom4), required: false);
            var __workflow_bodycustom5 = WorkflowExpression.Compile(bodycustom5, nameof(bodycustom5), required: false);
            var __workflow_bodycustom6 = WorkflowExpression.Compile(bodycustom6, nameof(bodycustom6), required: false);
            var __workflow_bodycustom7 = WorkflowExpression.Compile(bodycustom7, nameof(bodycustom7), required: false);
            var __workflow_bodycustom8 = WorkflowExpression.Compile(bodycustom8, nameof(bodycustom8), required: false);
            var __workflow_bodycustom9 = WorkflowExpression.Compile(bodycustom9, nameof(bodycustom9), required: false);
            var __workflow_bodycustom10 = WorkflowExpression.Compile(bodycustom10, nameof(bodycustom10), required: false);
            var __workflow_bodycustom11 = WorkflowExpression.Compile(bodycustom11, nameof(bodycustom11), required: false);
            var __workflow_bodycustom12 = WorkflowExpression.Compile(bodycustom12, nameof(bodycustom12), required: false);
            var __workflow_bodycustom13 = WorkflowExpression.Compile(bodycustom13, nameof(bodycustom13), required: false);
            var __workflow_bodycustom14 = WorkflowExpression.Compile(bodycustom14, nameof(bodycustom14), required: false);
            var __workflow_bodycustom15 = WorkflowExpression.Compile(bodycustom15, nameof(bodycustom15), required: false);
            var __workflow_bodycustom16 = WorkflowExpression.Compile(bodycustom16, nameof(bodycustom16), required: false);
            var __workflow_bodycustom17 = WorkflowExpression.Compile(bodycustom17, nameof(bodycustom17), required: false);
            var __workflow_bodycustom18 = WorkflowExpression.Compile(bodycustom18, nameof(bodycustom18), required: false);
            var __workflow_bodycustom19 = WorkflowExpression.Compile(bodycustom19, nameof(bodycustom19), required: false);
            var __workflow_bodycustom20 = WorkflowExpression.Compile(bodycustom20, nameof(bodycustom20), required: false);
            var __workflow_bodycustom21 = WorkflowExpression.Compile(bodycustom21, nameof(bodycustom21), required: false);
            var __workflow_bodycustom22 = WorkflowExpression.Compile(bodycustom22, nameof(bodycustom22), required: false);
            var __workflow_bodycustom23 = WorkflowExpression.Compile(bodycustom23, nameof(bodycustom23), required: false);
            var __workflow_bodycustom24 = WorkflowExpression.Compile(bodycustom24, nameof(bodycustom24), required: false);
            var __workflow_bodycustom25 = WorkflowExpression.Compile(bodycustom25, nameof(bodycustom25), required: false);
            var __workflow_bodycustom26 = WorkflowExpression.Compile(bodycustom26, nameof(bodycustom26), required: false);
            var __workflow_bodycustom27 = WorkflowExpression.Compile(bodycustom27, nameof(bodycustom27), required: false);
            var __workflow_bodycustom28 = WorkflowExpression.Compile(bodycustom28, nameof(bodycustom28), required: false);
            var __workflow_bodycustom29 = WorkflowExpression.Compile(bodycustom29, nameof(bodycustom29), required: false);
            var __workflow_bodycustom30 = WorkflowExpression.Compile(bodycustom30, nameof(bodycustom30), required: false);
            var __workflow_bodydefaultSecurity = WorkflowExpression.Compile(bodydefaultSecurity, nameof(bodydefaultSecurity), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodyisExternalAsNormal = WorkflowExpression.Compile(bodyisExternalAsNormal, nameof(bodyisExternalAsNormal), required: false);
            var __workflow_bodyprojectCustom1 = WorkflowExpression.Compile(bodyprojectCustom1, nameof(bodyprojectCustom1), required: false);
            var __workflow_bodyprojectCustom2 = WorkflowExpression.Compile(bodyprojectCustom2, nameof(bodyprojectCustom2), required: false);
            var __workflow_bodyprojectCustom3 = WorkflowExpression.Compile(bodyprojectCustom3, nameof(bodyprojectCustom3), required: false);
            var __workflow_bodysubclass = WorkflowExpression.Compile(bodysubclass, nameof(bodysubclass), required: false);
            return new DeferredBodyAction<WorkspaceProfileResponseBody, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/updateWorkspace";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodyowner != null)
                {
                    body["owner"] = ExpressionConverter.ConvertO(__workflow_bodyowner);
                    bodypropCount++;
                }

                if (__workflow_bodycustom1 != null)
                {
                    body["custom1"] = ExpressionConverter.ConvertO(__workflow_bodycustom1);
                    bodypropCount++;
                }

                if (__workflow_bodycustom2 != null)
                {
                    body["custom2"] = ExpressionConverter.ConvertO(__workflow_bodycustom2);
                    bodypropCount++;
                }

                if (__workflow_bodycustom3 != null)
                {
                    body["custom3"] = ExpressionConverter.ConvertO(__workflow_bodycustom3);
                    bodypropCount++;
                }

                if (__workflow_bodycustom4 != null)
                {
                    body["custom4"] = ExpressionConverter.ConvertO(__workflow_bodycustom4);
                    bodypropCount++;
                }

                if (__workflow_bodycustom5 != null)
                {
                    body["custom5"] = ExpressionConverter.ConvertO(__workflow_bodycustom5);
                    bodypropCount++;
                }

                if (__workflow_bodycustom6 != null)
                {
                    body["custom6"] = ExpressionConverter.ConvertO(__workflow_bodycustom6);
                    bodypropCount++;
                }

                if (__workflow_bodycustom7 != null)
                {
                    body["custom7"] = ExpressionConverter.ConvertO(__workflow_bodycustom7);
                    bodypropCount++;
                }

                if (__workflow_bodycustom8 != null)
                {
                    body["custom8"] = ExpressionConverter.ConvertO(__workflow_bodycustom8);
                    bodypropCount++;
                }

                if (__workflow_bodycustom9 != null)
                {
                    body["custom9"] = ExpressionConverter.ConvertO(__workflow_bodycustom9);
                    bodypropCount++;
                }

                if (__workflow_bodycustom10 != null)
                {
                    body["custom10"] = ExpressionConverter.ConvertO(__workflow_bodycustom10);
                    bodypropCount++;
                }

                if (__workflow_bodycustom11 != null)
                {
                    body["custom11"] = ExpressionConverter.ConvertO(__workflow_bodycustom11);
                    bodypropCount++;
                }

                if (__workflow_bodycustom12 != null)
                {
                    body["custom12"] = ExpressionConverter.ConvertO(__workflow_bodycustom12);
                    bodypropCount++;
                }

                if (__workflow_bodycustom13 != null)
                {
                    body["custom13"] = ExpressionConverter.ConvertO(__workflow_bodycustom13);
                    bodypropCount++;
                }

                if (__workflow_bodycustom14 != null)
                {
                    body["custom14"] = ExpressionConverter.ConvertO(__workflow_bodycustom14);
                    bodypropCount++;
                }

                if (__workflow_bodycustom15 != null)
                {
                    body["custom15"] = ExpressionConverter.ConvertO(__workflow_bodycustom15);
                    bodypropCount++;
                }

                if (__workflow_bodycustom16 != null)
                {
                    body["custom16"] = ExpressionConverter.ConvertO(__workflow_bodycustom16);
                    bodypropCount++;
                }

                if (__workflow_bodycustom17 != null)
                {
                    body["custom17"] = ExpressionConverter.ConvertO(__workflow_bodycustom17);
                    bodypropCount++;
                }

                if (__workflow_bodycustom18 != null)
                {
                    body["custom18"] = ExpressionConverter.ConvertO(__workflow_bodycustom18);
                    bodypropCount++;
                }

                if (__workflow_bodycustom19 != null)
                {
                    body["custom19"] = ExpressionConverter.ConvertO(__workflow_bodycustom19);
                    bodypropCount++;
                }

                if (__workflow_bodycustom20 != null)
                {
                    body["custom20"] = ExpressionConverter.ConvertO(__workflow_bodycustom20);
                    bodypropCount++;
                }

                if (__workflow_bodycustom21 != null)
                {
                    body["custom21"] = ExpressionConverter.ConvertO(__workflow_bodycustom21);
                    bodypropCount++;
                }

                if (__workflow_bodycustom22 != null)
                {
                    body["custom22"] = ExpressionConverter.ConvertO(__workflow_bodycustom22);
                    bodypropCount++;
                }

                if (__workflow_bodycustom23 != null)
                {
                    body["custom23"] = ExpressionConverter.ConvertO(__workflow_bodycustom23);
                    bodypropCount++;
                }

                if (__workflow_bodycustom24 != null)
                {
                    body["custom24"] = ExpressionConverter.ConvertO(__workflow_bodycustom24);
                    bodypropCount++;
                }

                if (__workflow_bodycustom25 != null)
                {
                    body["custom25"] = ExpressionConverter.ConvertO(__workflow_bodycustom25);
                    bodypropCount++;
                }

                if (__workflow_bodycustom26 != null)
                {
                    body["custom26"] = ExpressionConverter.ConvertO(__workflow_bodycustom26);
                    bodypropCount++;
                }

                if (__workflow_bodycustom27 != null)
                {
                    body["custom27"] = ExpressionConverter.ConvertO(__workflow_bodycustom27);
                    bodypropCount++;
                }

                if (__workflow_bodycustom28 != null)
                {
                    body["custom28"] = ExpressionConverter.ConvertO(__workflow_bodycustom28);
                    bodypropCount++;
                }

                if (__workflow_bodycustom29 != null)
                {
                    body["custom29"] = ExpressionConverter.ConvertO(__workflow_bodycustom29);
                    bodypropCount++;
                }

                if (__workflow_bodycustom30 != null)
                {
                    body["custom30"] = ExpressionConverter.ConvertO(__workflow_bodycustom30);
                    bodypropCount++;
                }

                if (__workflow_bodydefaultSecurity != null)
                {
                    body["default_security"] = ExpressionConverter.ConvertO(__workflow_bodydefaultSecurity);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodyisExternalAsNormal != null)
                {
                    body["is_external_as_normal"] = ExpressionConverter.ConvertO(__workflow_bodyisExternalAsNormal);
                    bodypropCount++;
                }

                if (__workflow_bodyprojectCustom1 != null)
                {
                    body["project_custom1"] = ExpressionConverter.ConvertO(__workflow_bodyprojectCustom1);
                    bodypropCount++;
                }

                if (__workflow_bodyprojectCustom2 != null)
                {
                    body["project_custom2"] = ExpressionConverter.ConvertO(__workflow_bodyprojectCustom2);
                    bodypropCount++;
                }

                if (__workflow_bodyprojectCustom3 != null)
                {
                    body["project_custom3"] = ExpressionConverter.ConvertO(__workflow_bodyprojectCustom3);
                    bodypropCount++;
                }

                if (__workflow_bodysubclass != null)
                {
                    body["subclass"] = ExpressionConverter.ConvertO(__workflow_bodysubclass);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<WorkspaceProfileResponseBody>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagework")]
        public IBodyWorkflowAction<GetClassesResponse, ApiConnectionActionConfiguration> GetClasses(Expression<Func<string>> libraryId, Expression<Func<string>> alias = null, Expression<Func<defaultSecurityInput>> defaultSecurity = null, Expression<Func<string>> description = null, Expression<Func<bool>> echo = null, Expression<Func<bool>> hipaa = null, Expression<Func<bool>> indexable = null, Expression<Func<string>> query = null, Expression<Func<bool>> subclassRequired = null)
        {
            var __workflow_libraryId = WorkflowExpression.Compile(libraryId, nameof(libraryId), required: true);
            var __workflow_alias = WorkflowExpression.Compile(alias, nameof(alias), required: false);
            var __workflow_defaultSecurity = WorkflowExpression.Compile(defaultSecurity, nameof(defaultSecurity), required: false);
            var __workflow_description = WorkflowExpression.Compile(description, nameof(description), required: false);
            var __workflow_echo = WorkflowExpression.Compile(echo, nameof(echo), required: false);
            var __workflow_hipaa = WorkflowExpression.Compile(hipaa, nameof(hipaa), required: false);
            var __workflow_indexable = WorkflowExpression.Compile(indexable, nameof(indexable), required: false);
            var __workflow_query = WorkflowExpression.Compile(query, nameof(query), required: false);
            var __workflow_subclassRequired = WorkflowExpression.Compile(subclassRequired, nameof(subclassRequired), required: false);
            return new DeferredBodyAction<GetClassesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/getClasses";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["libraryId"] = ExpressionConverter.Convert(__workflow_libraryId);
                if (__workflow_alias != null)
                    callPayload.Queries["alias"] = ExpressionConverter.Convert(__workflow_alias);
                if (__workflow_defaultSecurity != null)
                    callPayload.Queries["default_security"] = ExpressionConverter.Convert(__workflow_defaultSecurity);
                if (__workflow_description != null)
                    callPayload.Queries["description"] = ExpressionConverter.Convert(__workflow_description);
                if (__workflow_echo != null)
                    callPayload.Queries["echo"] = ExpressionConverter.Convert(__workflow_echo);
                if (__workflow_hipaa != null)
                    callPayload.Queries["hipaa"] = ExpressionConverter.Convert(__workflow_hipaa);
                if (__workflow_indexable != null)
                    callPayload.Queries["indexable"] = ExpressionConverter.Convert(__workflow_indexable);
                if (__workflow_query != null)
                    callPayload.Queries["query"] = ExpressionConverter.Convert(__workflow_query);
                if (__workflow_subclassRequired != null)
                    callPayload.Queries["subclass_required"] = ExpressionConverter.Convert(__workflow_subclassRequired);
                return new ApiConnectionAction<GetClassesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagework")]
        public IBodyWorkflowAction<GetSubclassesResponse, ApiConnectionActionConfiguration> GetSubclasses(Expression<Func<string>> libraryId, Expression<Func<string>> classId, Expression<Func<string>> alias = null, Expression<Func<defaultSecurityInput>> defaultSecurity = null, Expression<Func<string>> description = null, Expression<Func<bool>> echo = null, Expression<Func<bool>> hipaa = null, Expression<Func<string>> query = null)
        {
            var __workflow_libraryId = WorkflowExpression.Compile(libraryId, nameof(libraryId), required: true);
            var __workflow_classId = WorkflowExpression.Compile(classId, nameof(classId), required: true);
            var __workflow_alias = WorkflowExpression.Compile(alias, nameof(alias), required: false);
            var __workflow_defaultSecurity = WorkflowExpression.Compile(defaultSecurity, nameof(defaultSecurity), required: false);
            var __workflow_description = WorkflowExpression.Compile(description, nameof(description), required: false);
            var __workflow_echo = WorkflowExpression.Compile(echo, nameof(echo), required: false);
            var __workflow_hipaa = WorkflowExpression.Compile(hipaa, nameof(hipaa), required: false);
            var __workflow_query = WorkflowExpression.Compile(query, nameof(query), required: false);
            return new DeferredBodyAction<GetSubclassesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/getSubclasses";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["libraryId"] = ExpressionConverter.Convert(__workflow_libraryId);
                callPayload.Queries["classId"] = ExpressionConverter.Convert(__workflow_classId);
                if (__workflow_alias != null)
                    callPayload.Queries["alias"] = ExpressionConverter.Convert(__workflow_alias);
                if (__workflow_defaultSecurity != null)
                    callPayload.Queries["default_security"] = ExpressionConverter.Convert(__workflow_defaultSecurity);
                if (__workflow_description != null)
                    callPayload.Queries["description"] = ExpressionConverter.Convert(__workflow_description);
                if (__workflow_echo != null)
                    callPayload.Queries["echo"] = ExpressionConverter.Convert(__workflow_echo);
                if (__workflow_hipaa != null)
                    callPayload.Queries["hipaa"] = ExpressionConverter.Convert(__workflow_hipaa);
                if (__workflow_query != null)
                    callPayload.Queries["query"] = ExpressionConverter.Convert(__workflow_query);
                return new ApiConnectionAction<GetSubclassesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagework")]
        public IBodyWorkflowAction<WorkspaceTemplatesResponseBody, ApiConnectionActionConfiguration> GetWorkspaceTemplates(Expression<Func<string>> libraryId, Expression<Func<string>> custom1 = null, Expression<Func<string>> custom2 = null, Expression<Func<string>> custom3 = null, Expression<Func<string>> custom4 = null, Expression<Func<string>> custom5 = null, Expression<Func<string>> custom6 = null, Expression<Func<string>> custom7 = null, Expression<Func<string>> custom8 = null, Expression<Func<string>> custom9 = null, Expression<Func<string>> custom10 = null, Expression<Func<string>> custom11 = null, Expression<Func<string>> custom12 = null, Expression<Func<double>> custom17 = null, Expression<Func<double>> custom18 = null, Expression<Func<double>> custom19 = null, Expression<Func<double>> custom20 = null, Expression<Func<string>> custom21 = null, Expression<Func<string>> custom22 = null, Expression<Func<string>> custom23 = null, Expression<Func<string>> custom24 = null, Expression<Func<string>> custom21From = null, Expression<Func<string>> custom21To = null, Expression<Func<string>> custom21Relative = null, Expression<Func<string>> custom22From = null, Expression<Func<string>> custom22To = null, Expression<Func<string>> custom22Relative = null, Expression<Func<string>> custom23From = null, Expression<Func<string>> custom23To = null, Expression<Func<string>> custom23Relative = null, Expression<Func<string>> custom24From = null, Expression<Func<string>> custom24To = null, Expression<Func<string>> custom24Relative = null, Expression<Func<bool>> custom25 = null, Expression<Func<bool>> custom26 = null, Expression<Func<bool>> custom27 = null, Expression<Func<bool>> custom28 = null, Expression<Func<string>> custom29 = null, Expression<Func<string>> custom30 = null)
        {
            var __workflow_libraryId = WorkflowExpression.Compile(libraryId, nameof(libraryId), required: true);
            var __workflow_custom1 = WorkflowExpression.Compile(custom1, nameof(custom1), required: false);
            var __workflow_custom2 = WorkflowExpression.Compile(custom2, nameof(custom2), required: false);
            var __workflow_custom3 = WorkflowExpression.Compile(custom3, nameof(custom3), required: false);
            var __workflow_custom4 = WorkflowExpression.Compile(custom4, nameof(custom4), required: false);
            var __workflow_custom5 = WorkflowExpression.Compile(custom5, nameof(custom5), required: false);
            var __workflow_custom6 = WorkflowExpression.Compile(custom6, nameof(custom6), required: false);
            var __workflow_custom7 = WorkflowExpression.Compile(custom7, nameof(custom7), required: false);
            var __workflow_custom8 = WorkflowExpression.Compile(custom8, nameof(custom8), required: false);
            var __workflow_custom9 = WorkflowExpression.Compile(custom9, nameof(custom9), required: false);
            var __workflow_custom10 = WorkflowExpression.Compile(custom10, nameof(custom10), required: false);
            var __workflow_custom11 = WorkflowExpression.Compile(custom11, nameof(custom11), required: false);
            var __workflow_custom12 = WorkflowExpression.Compile(custom12, nameof(custom12), required: false);
            var __workflow_custom17 = WorkflowExpression.Compile(custom17, nameof(custom17), required: false);
            var __workflow_custom18 = WorkflowExpression.Compile(custom18, nameof(custom18), required: false);
            var __workflow_custom19 = WorkflowExpression.Compile(custom19, nameof(custom19), required: false);
            var __workflow_custom20 = WorkflowExpression.Compile(custom20, nameof(custom20), required: false);
            var __workflow_custom21 = WorkflowExpression.Compile(custom21, nameof(custom21), required: false);
            var __workflow_custom22 = WorkflowExpression.Compile(custom22, nameof(custom22), required: false);
            var __workflow_custom23 = WorkflowExpression.Compile(custom23, nameof(custom23), required: false);
            var __workflow_custom24 = WorkflowExpression.Compile(custom24, nameof(custom24), required: false);
            var __workflow_custom21From = WorkflowExpression.Compile(custom21From, nameof(custom21From), required: false);
            var __workflow_custom21To = WorkflowExpression.Compile(custom21To, nameof(custom21To), required: false);
            var __workflow_custom21Relative = WorkflowExpression.Compile(custom21Relative, nameof(custom21Relative), required: false);
            var __workflow_custom22From = WorkflowExpression.Compile(custom22From, nameof(custom22From), required: false);
            var __workflow_custom22To = WorkflowExpression.Compile(custom22To, nameof(custom22To), required: false);
            var __workflow_custom22Relative = WorkflowExpression.Compile(custom22Relative, nameof(custom22Relative), required: false);
            var __workflow_custom23From = WorkflowExpression.Compile(custom23From, nameof(custom23From), required: false);
            var __workflow_custom23To = WorkflowExpression.Compile(custom23To, nameof(custom23To), required: false);
            var __workflow_custom23Relative = WorkflowExpression.Compile(custom23Relative, nameof(custom23Relative), required: false);
            var __workflow_custom24From = WorkflowExpression.Compile(custom24From, nameof(custom24From), required: false);
            var __workflow_custom24To = WorkflowExpression.Compile(custom24To, nameof(custom24To), required: false);
            var __workflow_custom24Relative = WorkflowExpression.Compile(custom24Relative, nameof(custom24Relative), required: false);
            var __workflow_custom25 = WorkflowExpression.Compile(custom25, nameof(custom25), required: false);
            var __workflow_custom26 = WorkflowExpression.Compile(custom26, nameof(custom26), required: false);
            var __workflow_custom27 = WorkflowExpression.Compile(custom27, nameof(custom27), required: false);
            var __workflow_custom28 = WorkflowExpression.Compile(custom28, nameof(custom28), required: false);
            var __workflow_custom29 = WorkflowExpression.Compile(custom29, nameof(custom29), required: false);
            var __workflow_custom30 = WorkflowExpression.Compile(custom30, nameof(custom30), required: false);
            return new DeferredBodyAction<WorkspaceTemplatesResponseBody, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/getWorkspaceTemplates";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["libraryId"] = ExpressionConverter.Convert(__workflow_libraryId);
                if (__workflow_custom1 != null)
                    callPayload.Queries["custom1"] = ExpressionConverter.Convert(__workflow_custom1);
                if (__workflow_custom2 != null)
                    callPayload.Queries["custom2"] = ExpressionConverter.Convert(__workflow_custom2);
                if (__workflow_custom3 != null)
                    callPayload.Queries["custom3"] = ExpressionConverter.Convert(__workflow_custom3);
                if (__workflow_custom4 != null)
                    callPayload.Queries["custom4"] = ExpressionConverter.Convert(__workflow_custom4);
                if (__workflow_custom5 != null)
                    callPayload.Queries["custom5"] = ExpressionConverter.Convert(__workflow_custom5);
                if (__workflow_custom6 != null)
                    callPayload.Queries["custom6"] = ExpressionConverter.Convert(__workflow_custom6);
                if (__workflow_custom7 != null)
                    callPayload.Queries["custom7"] = ExpressionConverter.Convert(__workflow_custom7);
                if (__workflow_custom8 != null)
                    callPayload.Queries["custom8"] = ExpressionConverter.Convert(__workflow_custom8);
                if (__workflow_custom9 != null)
                    callPayload.Queries["custom9"] = ExpressionConverter.Convert(__workflow_custom9);
                if (__workflow_custom10 != null)
                    callPayload.Queries["custom10"] = ExpressionConverter.Convert(__workflow_custom10);
                if (__workflow_custom11 != null)
                    callPayload.Queries["custom11"] = ExpressionConverter.Convert(__workflow_custom11);
                if (__workflow_custom12 != null)
                    callPayload.Queries["custom12"] = ExpressionConverter.Convert(__workflow_custom12);
                if (__workflow_custom17 != null)
                    callPayload.Queries["custom17"] = ExpressionConverter.Convert(__workflow_custom17);
                if (__workflow_custom18 != null)
                    callPayload.Queries["custom18"] = ExpressionConverter.Convert(__workflow_custom18);
                if (__workflow_custom19 != null)
                    callPayload.Queries["custom19"] = ExpressionConverter.Convert(__workflow_custom19);
                if (__workflow_custom20 != null)
                    callPayload.Queries["custom20"] = ExpressionConverter.Convert(__workflow_custom20);
                if (__workflow_custom21 != null)
                    callPayload.Queries["custom21"] = ExpressionConverter.Convert(__workflow_custom21);
                if (__workflow_custom22 != null)
                    callPayload.Queries["custom22"] = ExpressionConverter.Convert(__workflow_custom22);
                if (__workflow_custom23 != null)
                    callPayload.Queries["custom23"] = ExpressionConverter.Convert(__workflow_custom23);
                if (__workflow_custom24 != null)
                    callPayload.Queries["custom24"] = ExpressionConverter.Convert(__workflow_custom24);
                if (__workflow_custom21From != null)
                    callPayload.Queries["custom21_from"] = ExpressionConverter.Convert(__workflow_custom21From);
                if (__workflow_custom21To != null)
                    callPayload.Queries["custom21_to"] = ExpressionConverter.Convert(__workflow_custom21To);
                if (__workflow_custom21Relative != null)
                    callPayload.Queries["custom21_relative"] = ExpressionConverter.Convert(__workflow_custom21Relative);
                if (__workflow_custom22From != null)
                    callPayload.Queries["custom22_from"] = ExpressionConverter.Convert(__workflow_custom22From);
                if (__workflow_custom22To != null)
                    callPayload.Queries["custom22_to"] = ExpressionConverter.Convert(__workflow_custom22To);
                if (__workflow_custom22Relative != null)
                    callPayload.Queries["custom22_relative"] = ExpressionConverter.Convert(__workflow_custom22Relative);
                if (__workflow_custom23From != null)
                    callPayload.Queries["custom23_from"] = ExpressionConverter.Convert(__workflow_custom23From);
                if (__workflow_custom23To != null)
                    callPayload.Queries["custom23_to"] = ExpressionConverter.Convert(__workflow_custom23To);
                if (__workflow_custom23Relative != null)
                    callPayload.Queries["custom23_relative"] = ExpressionConverter.Convert(__workflow_custom23Relative);
                if (__workflow_custom24From != null)
                    callPayload.Queries["custom24_from"] = ExpressionConverter.Convert(__workflow_custom24From);
                if (__workflow_custom24To != null)
                    callPayload.Queries["custom24_to"] = ExpressionConverter.Convert(__workflow_custom24To);
                if (__workflow_custom24Relative != null)
                    callPayload.Queries["custom24_relative"] = ExpressionConverter.Convert(__workflow_custom24Relative);
                if (__workflow_custom25 != null)
                    callPayload.Queries["custom25"] = ExpressionConverter.Convert(__workflow_custom25);
                if (__workflow_custom26 != null)
                    callPayload.Queries["custom26"] = ExpressionConverter.Convert(__workflow_custom26);
                if (__workflow_custom27 != null)
                    callPayload.Queries["custom27"] = ExpressionConverter.Convert(__workflow_custom27);
                if (__workflow_custom28 != null)
                    callPayload.Queries["custom28"] = ExpressionConverter.Convert(__workflow_custom28);
                if (__workflow_custom29 != null)
                    callPayload.Queries["custom29"] = ExpressionConverter.Convert(__workflow_custom29);
                if (__workflow_custom30 != null)
                    callPayload.Queries["custom30"] = ExpressionConverter.Convert(__workflow_custom30);
                return new ApiConnectionAction<WorkspaceTemplatesResponseBody>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagework")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditNVP(Expression<Func<bodyobjectTypeInput>> bodyobjectType, Expression<Func<string>> bodyobjectId)
        {
            var __workflow_bodyobjectType = WorkflowExpression.Compile(bodyobjectType, nameof(bodyobjectType), required: true);
            var __workflow_bodyobjectId = WorkflowExpression.Compile(bodyobjectId, nameof(bodyobjectId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/editNVP";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["objectType"] = ExpressionConverter.ConvertO(__workflow_bodyobjectType);
                bodypropCount++;
                body["objectId"] = ExpressionConverter.ConvertO(__workflow_bodyobjectId);
                var nameValuePairsObject = new JObject();
                var nameValuePairsObjectpropCount = 0;
                if (nameValuePairsObjectpropCount > 0)
                {
                    body["nameValuePairs"] = nameValuePairsObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagework")]
        public IBodyWorkflowAction<SearchFoldersResponseBody, ApiConnectionActionConfiguration> SearchFolders(Expression<Func<string>> bodylibraryId, Expression<Func<string>> bodycontainerId = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodyemail = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodyowner = null, Expression<Func<string>> bodyworkspaceName = null)
        {
            var __workflow_bodylibraryId = WorkflowExpression.Compile(bodylibraryId, nameof(bodylibraryId), required: true);
            var __workflow_bodycontainerId = WorkflowExpression.Compile(bodycontainerId, nameof(bodycontainerId), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: false);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodyowner = WorkflowExpression.Compile(bodyowner, nameof(bodyowner), required: false);
            var __workflow_bodyworkspaceName = WorkflowExpression.Compile(bodyworkspaceName, nameof(bodyworkspaceName), required: false);
            return new DeferredBodyAction<SearchFoldersResponseBody, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/searchFolders";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["libraryId"] = ExpressionConverter.ConvertO(__workflow_bodylibraryId);
                if (__workflow_bodycontainerId != null)
                {
                    body["container_id"] = ExpressionConverter.ConvertO(__workflow_bodycontainerId);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodyemail != null)
                {
                    body["email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                    bodypropCount++;
                }

                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodyowner != null)
                {
                    body["owner"] = ExpressionConverter.ConvertO(__workflow_bodyowner);
                    bodypropCount++;
                }

                if (__workflow_bodyworkspaceName != null)
                {
                    body["workspace_name"] = ExpressionConverter.ConvertO(__workflow_bodyworkspaceName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SearchFoldersResponseBody>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagework")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> DownloadDocument(Expression<Func<string>> bodydocumentId, Expression<Func<bool>> bodylatest = null)
        {
            var __workflow_bodydocumentId = WorkflowExpression.Compile(bodydocumentId, nameof(bodydocumentId), required: true);
            var __workflow_bodylatest = WorkflowExpression.Compile(bodylatest, nameof(bodylatest), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/downloadDocument";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["documentId"] = ExpressionConverter.ConvertO(__workflow_bodydocumentId);
                if (__workflow_bodylatest != null)
                {
                    if (__workflow_bodylatest != null)
                    {
                        body["latest"] = ExpressionConverter.ConvertO(__workflow_bodylatest);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["latest"] = false;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagework")]
        public IBodyWorkflowAction<GetUserDetailsResponse, ApiConnectionActionConfiguration> GetUserDetails(Expression<Func<string>> bodylibraryId, Expression<Func<string>> bodyuserId)
        {
            var __workflow_bodylibraryId = WorkflowExpression.Compile(bodylibraryId, nameof(bodylibraryId), required: true);
            var __workflow_bodyuserId = WorkflowExpression.Compile(bodyuserId, nameof(bodyuserId), required: true);
            return new DeferredBodyAction<GetUserDetailsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/getUserDetails";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["libraryId"] = ExpressionConverter.ConvertO(__workflow_bodylibraryId);
                bodypropCount++;
                body["userId"] = ExpressionConverter.ConvertO(__workflow_bodyuserId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GetUserDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagework")]
        public IBodyWorkflowAction<WorkspaceProfileResponseBody, ApiConnectionActionConfiguration> GetWorkspaceProfile(Expression<Func<string>> bodyworkspaceId)
        {
            var __workflow_bodyworkspaceId = WorkflowExpression.Compile(bodyworkspaceId, nameof(bodyworkspaceId), required: true);
            return new DeferredBodyAction<WorkspaceProfileResponseBody, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/getWorkspaceProfile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["workspaceId"] = ExpressionConverter.ConvertO(__workflow_bodyworkspaceId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<WorkspaceProfileResponseBody>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagework")]
        public IBodyWorkflowAction<GetContainerChildrenResponse, ApiConnectionActionConfiguration> GetContainerChildren(Expression<Func<string>> bodycontainerId, Expression<Func<string>> bodycursor = null)
        {
            var __workflow_bodycontainerId = WorkflowExpression.Compile(bodycontainerId, nameof(bodycontainerId), required: true);
            var __workflow_bodycursor = WorkflowExpression.Compile(bodycursor, nameof(bodycursor), required: false);
            return new DeferredBodyAction<GetContainerChildrenResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/getContainerChildren";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["containerId"] = ExpressionConverter.ConvertO(__workflow_bodycontainerId);
                if (__workflow_bodycursor != null)
                {
                    body["cursor"] = ExpressionConverter.ConvertO(__workflow_bodycursor);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GetContainerChildrenResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagework")]
        public IBodyWorkflowAction<GetContainerProfileResponseBody, ApiConnectionActionConfiguration> GetContainerProfile(Expression<Func<string>> bodycontainerId)
        {
            var __workflow_bodycontainerId = WorkflowExpression.Compile(bodycontainerId, nameof(bodycontainerId), required: true);
            return new DeferredBodyAction<GetContainerProfileResponseBody, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/getContainerProfile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["containerId"] = ExpressionConverter.ConvertO(__workflow_bodycontainerId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GetContainerProfileResponseBody>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagework")]
        public IBodyWorkflowAction<GetLibrariesResponse, ApiConnectionActionConfiguration> GetLibraries()
        {
            return new DeferredBodyAction<GetLibrariesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/getLibraries";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["showAllLibraries"] = Convert.ToString(false);
                callPayload.Queries["hidePreferredLibrary"] = Convert.ToString(false);
                return new ApiConnectionAction<GetLibrariesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagework")]
        public IBodyWorkflowAction<FullDocumentProfileResponseBody, ApiConnectionActionConfiguration> GetDocumentProfile(Expression<Func<string>> bodydocumentId, Expression<Func<bool>> bodylatest = null)
        {
            var __workflow_bodydocumentId = WorkflowExpression.Compile(bodydocumentId, nameof(bodydocumentId), required: true);
            var __workflow_bodylatest = WorkflowExpression.Compile(bodylatest, nameof(bodylatest), required: false);
            return new DeferredBodyAction<FullDocumentProfileResponseBody, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/getDocumentProfile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["documentId"] = ExpressionConverter.ConvertO(__workflow_bodydocumentId);
                if (__workflow_bodylatest != null)
                {
                    if (__workflow_bodylatest != null)
                    {
                        body["latest"] = ExpressionConverter.ConvertO(__workflow_bodylatest);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["latest"] = false;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<FullDocumentProfileResponseBody>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagework")]
        public IBodyWorkflowAction<ShortDocumentProfileResponseBody, ApiConnectionActionConfiguration> UpdateDocumentProfile(Expression<Func<string>> bodydocumentId, Expression<Func<string>> bodyalias = null, Expression<Func<string>> bodyauthor = null, Expression<Func<string>> bodycomment = null, Expression<Func<bodydefaultSecurityInput>> bodydefaultSecurity = null, Expression<Func<bool>> bodyisDeclared = null, Expression<Func<bool>> bodyisHipaa = null, Expression<Func<string>> bodyauditComment = null, Expression<Func<string>> bodyClass = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodyOperator = null, Expression<Func<int>> bodyretainDays = null, Expression<Func<string>> bodysubclass = null, Expression<Func<string>> bodycustom1 = null, Expression<Func<string>> bodycustom2 = null, Expression<Func<string>> bodycustom3 = null, Expression<Func<string>> bodycustom4 = null, Expression<Func<string>> bodycustom5 = null, Expression<Func<string>> bodycustom6 = null, Expression<Func<string>> bodycustom7 = null, Expression<Func<string>> bodycustom8 = null, Expression<Func<string>> bodycustom9 = null, Expression<Func<string>> bodycustom10 = null, Expression<Func<string>> bodycustom11 = null, Expression<Func<string>> bodycustom12 = null, Expression<Func<string>> bodycustom13 = null, Expression<Func<string>> bodycustom14 = null, Expression<Func<string>> bodycustom15 = null, Expression<Func<string>> bodycustom16 = null, Expression<Func<double>> bodycustom17 = null, Expression<Func<double>> bodycustom18 = null, Expression<Func<double>> bodycustom19 = null, Expression<Func<double>> bodycustom20 = null, Expression<Func<string>> bodycustom21 = null, Expression<Func<string>> bodycustom22 = null, Expression<Func<string>> bodycustom23 = null, Expression<Func<string>> bodycustom24 = null, Expression<Func<bool>> bodycustom25 = null, Expression<Func<bool>> bodycustom26 = null, Expression<Func<bool>> bodycustom27 = null, Expression<Func<bool>> bodycustom28 = null, Expression<Func<string>> bodycustom29 = null, Expression<Func<string>> bodycustom30 = null)
        {
            var __workflow_bodydocumentId = WorkflowExpression.Compile(bodydocumentId, nameof(bodydocumentId), required: true);
            var __workflow_bodyalias = WorkflowExpression.Compile(bodyalias, nameof(bodyalias), required: false);
            var __workflow_bodyauthor = WorkflowExpression.Compile(bodyauthor, nameof(bodyauthor), required: false);
            var __workflow_bodycomment = WorkflowExpression.Compile(bodycomment, nameof(bodycomment), required: false);
            var __workflow_bodydefaultSecurity = WorkflowExpression.Compile(bodydefaultSecurity, nameof(bodydefaultSecurity), required: false);
            var __workflow_bodyisDeclared = WorkflowExpression.Compile(bodyisDeclared, nameof(bodyisDeclared), required: false);
            var __workflow_bodyisHipaa = WorkflowExpression.Compile(bodyisHipaa, nameof(bodyisHipaa), required: false);
            var __workflow_bodyauditComment = WorkflowExpression.Compile(bodyauditComment, nameof(bodyauditComment), required: false);
            var __workflow_bodyClass = WorkflowExpression.Compile(bodyClass, nameof(bodyClass), required: false);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodyOperator = WorkflowExpression.Compile(bodyOperator, nameof(bodyOperator), required: false);
            var __workflow_bodyretainDays = WorkflowExpression.Compile(bodyretainDays, nameof(bodyretainDays), required: false);
            var __workflow_bodysubclass = WorkflowExpression.Compile(bodysubclass, nameof(bodysubclass), required: false);
            var __workflow_bodycustom1 = WorkflowExpression.Compile(bodycustom1, nameof(bodycustom1), required: false);
            var __workflow_bodycustom2 = WorkflowExpression.Compile(bodycustom2, nameof(bodycustom2), required: false);
            var __workflow_bodycustom3 = WorkflowExpression.Compile(bodycustom3, nameof(bodycustom3), required: false);
            var __workflow_bodycustom4 = WorkflowExpression.Compile(bodycustom4, nameof(bodycustom4), required: false);
            var __workflow_bodycustom5 = WorkflowExpression.Compile(bodycustom5, nameof(bodycustom5), required: false);
            var __workflow_bodycustom6 = WorkflowExpression.Compile(bodycustom6, nameof(bodycustom6), required: false);
            var __workflow_bodycustom7 = WorkflowExpression.Compile(bodycustom7, nameof(bodycustom7), required: false);
            var __workflow_bodycustom8 = WorkflowExpression.Compile(bodycustom8, nameof(bodycustom8), required: false);
            var __workflow_bodycustom9 = WorkflowExpression.Compile(bodycustom9, nameof(bodycustom9), required: false);
            var __workflow_bodycustom10 = WorkflowExpression.Compile(bodycustom10, nameof(bodycustom10), required: false);
            var __workflow_bodycustom11 = WorkflowExpression.Compile(bodycustom11, nameof(bodycustom11), required: false);
            var __workflow_bodycustom12 = WorkflowExpression.Compile(bodycustom12, nameof(bodycustom12), required: false);
            var __workflow_bodycustom13 = WorkflowExpression.Compile(bodycustom13, nameof(bodycustom13), required: false);
            var __workflow_bodycustom14 = WorkflowExpression.Compile(bodycustom14, nameof(bodycustom14), required: false);
            var __workflow_bodycustom15 = WorkflowExpression.Compile(bodycustom15, nameof(bodycustom15), required: false);
            var __workflow_bodycustom16 = WorkflowExpression.Compile(bodycustom16, nameof(bodycustom16), required: false);
            var __workflow_bodycustom17 = WorkflowExpression.Compile(bodycustom17, nameof(bodycustom17), required: false);
            var __workflow_bodycustom18 = WorkflowExpression.Compile(bodycustom18, nameof(bodycustom18), required: false);
            var __workflow_bodycustom19 = WorkflowExpression.Compile(bodycustom19, nameof(bodycustom19), required: false);
            var __workflow_bodycustom20 = WorkflowExpression.Compile(bodycustom20, nameof(bodycustom20), required: false);
            var __workflow_bodycustom21 = WorkflowExpression.Compile(bodycustom21, nameof(bodycustom21), required: false);
            var __workflow_bodycustom22 = WorkflowExpression.Compile(bodycustom22, nameof(bodycustom22), required: false);
            var __workflow_bodycustom23 = WorkflowExpression.Compile(bodycustom23, nameof(bodycustom23), required: false);
            var __workflow_bodycustom24 = WorkflowExpression.Compile(bodycustom24, nameof(bodycustom24), required: false);
            var __workflow_bodycustom25 = WorkflowExpression.Compile(bodycustom25, nameof(bodycustom25), required: false);
            var __workflow_bodycustom26 = WorkflowExpression.Compile(bodycustom26, nameof(bodycustom26), required: false);
            var __workflow_bodycustom27 = WorkflowExpression.Compile(bodycustom27, nameof(bodycustom27), required: false);
            var __workflow_bodycustom28 = WorkflowExpression.Compile(bodycustom28, nameof(bodycustom28), required: false);
            var __workflow_bodycustom29 = WorkflowExpression.Compile(bodycustom29, nameof(bodycustom29), required: false);
            var __workflow_bodycustom30 = WorkflowExpression.Compile(bodycustom30, nameof(bodycustom30), required: false);
            return new DeferredBodyAction<ShortDocumentProfileResponseBody, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/updateDocumentProfile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyalias != null)
                {
                    body["alias"] = ExpressionConverter.ConvertO(__workflow_bodyalias);
                    bodypropCount++;
                }

                if (__workflow_bodyauthor != null)
                {
                    body["author"] = ExpressionConverter.ConvertO(__workflow_bodyauthor);
                    bodypropCount++;
                }

                if (__workflow_bodycomment != null)
                {
                    body["comment"] = ExpressionConverter.ConvertO(__workflow_bodycomment);
                    bodypropCount++;
                }

                if (__workflow_bodydefaultSecurity != null)
                {
                    body["default_security"] = ExpressionConverter.ConvertO(__workflow_bodydefaultSecurity);
                    bodypropCount++;
                }

                bodypropCount++;
                body["documentId"] = ExpressionConverter.ConvertO(__workflow_bodydocumentId);
                if (__workflow_bodyisDeclared != null)
                {
                    body["is_declared"] = ExpressionConverter.ConvertO(__workflow_bodyisDeclared);
                    bodypropCount++;
                }

                if (__workflow_bodyisHipaa != null)
                {
                    body["is_hipaa"] = ExpressionConverter.ConvertO(__workflow_bodyisHipaa);
                    bodypropCount++;
                }

                if (__workflow_bodyauditComment != null)
                {
                    body["audit_comment"] = ExpressionConverter.ConvertO(__workflow_bodyauditComment);
                    bodypropCount++;
                }

                if (__workflow_bodyClass != null)
                {
                    body["class"] = ExpressionConverter.ConvertO(__workflow_bodyClass);
                    bodypropCount++;
                }

                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodyOperator != null)
                {
                    body["operator"] = ExpressionConverter.ConvertO(__workflow_bodyOperator);
                    bodypropCount++;
                }

                if (__workflow_bodyretainDays != null)
                {
                    body["retain_days"] = ExpressionConverter.ConvertO(__workflow_bodyretainDays);
                    bodypropCount++;
                }

                if (__workflow_bodysubclass != null)
                {
                    body["subclass"] = ExpressionConverter.ConvertO(__workflow_bodysubclass);
                    bodypropCount++;
                }

                if (__workflow_bodycustom1 != null)
                {
                    body["custom1"] = ExpressionConverter.ConvertO(__workflow_bodycustom1);
                    bodypropCount++;
                }

                if (__workflow_bodycustom2 != null)
                {
                    body["custom2"] = ExpressionConverter.ConvertO(__workflow_bodycustom2);
                    bodypropCount++;
                }

                if (__workflow_bodycustom3 != null)
                {
                    body["custom3"] = ExpressionConverter.ConvertO(__workflow_bodycustom3);
                    bodypropCount++;
                }

                if (__workflow_bodycustom4 != null)
                {
                    body["custom4"] = ExpressionConverter.ConvertO(__workflow_bodycustom4);
                    bodypropCount++;
                }

                if (__workflow_bodycustom5 != null)
                {
                    body["custom5"] = ExpressionConverter.ConvertO(__workflow_bodycustom5);
                    bodypropCount++;
                }

                if (__workflow_bodycustom6 != null)
                {
                    body["custom6"] = ExpressionConverter.ConvertO(__workflow_bodycustom6);
                    bodypropCount++;
                }

                if (__workflow_bodycustom7 != null)
                {
                    body["custom7"] = ExpressionConverter.ConvertO(__workflow_bodycustom7);
                    bodypropCount++;
                }

                if (__workflow_bodycustom8 != null)
                {
                    body["custom8"] = ExpressionConverter.ConvertO(__workflow_bodycustom8);
                    bodypropCount++;
                }

                if (__workflow_bodycustom9 != null)
                {
                    body["custom9"] = ExpressionConverter.ConvertO(__workflow_bodycustom9);
                    bodypropCount++;
                }

                if (__workflow_bodycustom10 != null)
                {
                    body["custom10"] = ExpressionConverter.ConvertO(__workflow_bodycustom10);
                    bodypropCount++;
                }

                if (__workflow_bodycustom11 != null)
                {
                    body["custom11"] = ExpressionConverter.ConvertO(__workflow_bodycustom11);
                    bodypropCount++;
                }

                if (__workflow_bodycustom12 != null)
                {
                    body["custom12"] = ExpressionConverter.ConvertO(__workflow_bodycustom12);
                    bodypropCount++;
                }

                if (__workflow_bodycustom13 != null)
                {
                    body["custom13"] = ExpressionConverter.ConvertO(__workflow_bodycustom13);
                    bodypropCount++;
                }

                if (__workflow_bodycustom14 != null)
                {
                    body["custom14"] = ExpressionConverter.ConvertO(__workflow_bodycustom14);
                    bodypropCount++;
                }

                if (__workflow_bodycustom15 != null)
                {
                    body["custom15"] = ExpressionConverter.ConvertO(__workflow_bodycustom15);
                    bodypropCount++;
                }

                if (__workflow_bodycustom16 != null)
                {
                    body["custom16"] = ExpressionConverter.ConvertO(__workflow_bodycustom16);
                    bodypropCount++;
                }

                if (__workflow_bodycustom17 != null)
                {
                    body["custom17"] = ExpressionConverter.ConvertO(__workflow_bodycustom17);
                    bodypropCount++;
                }

                if (__workflow_bodycustom18 != null)
                {
                    body["custom18"] = ExpressionConverter.ConvertO(__workflow_bodycustom18);
                    bodypropCount++;
                }

                if (__workflow_bodycustom19 != null)
                {
                    body["custom19"] = ExpressionConverter.ConvertO(__workflow_bodycustom19);
                    bodypropCount++;
                }

                if (__workflow_bodycustom20 != null)
                {
                    body["custom20"] = ExpressionConverter.ConvertO(__workflow_bodycustom20);
                    bodypropCount++;
                }

                if (__workflow_bodycustom21 != null)
                {
                    body["custom21"] = ExpressionConverter.ConvertO(__workflow_bodycustom21);
                    bodypropCount++;
                }

                if (__workflow_bodycustom22 != null)
                {
                    body["custom22"] = ExpressionConverter.ConvertO(__workflow_bodycustom22);
                    bodypropCount++;
                }

                if (__workflow_bodycustom23 != null)
                {
                    body["custom23"] = ExpressionConverter.ConvertO(__workflow_bodycustom23);
                    bodypropCount++;
                }

                if (__workflow_bodycustom24 != null)
                {
                    body["custom24"] = ExpressionConverter.ConvertO(__workflow_bodycustom24);
                    bodypropCount++;
                }

                if (__workflow_bodycustom25 != null)
                {
                    body["custom25"] = ExpressionConverter.ConvertO(__workflow_bodycustom25);
                    bodypropCount++;
                }

                if (__workflow_bodycustom26 != null)
                {
                    body["custom26"] = ExpressionConverter.ConvertO(__workflow_bodycustom26);
                    bodypropCount++;
                }

                if (__workflow_bodycustom27 != null)
                {
                    body["custom27"] = ExpressionConverter.ConvertO(__workflow_bodycustom27);
                    bodypropCount++;
                }

                if (__workflow_bodycustom28 != null)
                {
                    body["custom28"] = ExpressionConverter.ConvertO(__workflow_bodycustom28);
                    bodypropCount++;
                }

                if (__workflow_bodycustom29 != null)
                {
                    body["custom29"] = ExpressionConverter.ConvertO(__workflow_bodycustom29);
                    bodypropCount++;
                }

                if (__workflow_bodycustom30 != null)
                {
                    body["custom30"] = ExpressionConverter.ConvertO(__workflow_bodycustom30);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ShortDocumentProfileResponseBody>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagework")]
        public IBodyWorkflowAction<GetGroupMembersResponse, ApiConnectionActionConfiguration> GetGroupMembers(Expression<Func<string>> libraryId, Expression<Func<string>> groupId, Expression<Func<logonStatusInput>> logonStatus = null, Expression<Func<int>> limit = null, Expression<Func<string>> preferredLibrary = null, Expression<Func<string>> location = null)
        {
            var __workflow_libraryId = WorkflowExpression.Compile(libraryId, nameof(libraryId), required: true);
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            var __workflow_logonStatus = WorkflowExpression.Compile(logonStatus, nameof(logonStatus), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_preferredLibrary = WorkflowExpression.Compile(preferredLibrary, nameof(preferredLibrary), required: false);
            var __workflow_location = WorkflowExpression.Compile(location, nameof(location), required: false);
            return new DeferredBodyAction<GetGroupMembersResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/getGroupMembers";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["libraryId"] = ExpressionConverter.Convert(__workflow_libraryId);
                callPayload.Queries["groupId"] = ExpressionConverter.Convert(__workflow_groupId);
                callPayload.Queries["logon_status"] = Convert.ToString("Enabled");
                if (__workflow_logonStatus != null)
                    callPayload.Queries["logon_status"] = ExpressionConverter.Convert(__workflow_logonStatus);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_preferredLibrary != null)
                    callPayload.Queries["preferred_library"] = ExpressionConverter.Convert(__workflow_preferredLibrary);
                if (__workflow_location != null)
                    callPayload.Queries["location"] = ExpressionConverter.Convert(__workflow_location);
                return new ApiConnectionAction<GetGroupMembersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagework")]
        public IBodyWorkflowAction<SearchWorkspacesResponseBody, ApiConnectionActionConfiguration> SearchWorkspaces(Expression<Func<string>> bodylibraryId, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodyowner = null, Expression<Func<string>> bodyanywhere = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodysubclass = null, Expression<Func<string>> bodycustom1 = null, Expression<Func<string>> bodycustom2 = null, Expression<Func<string>> bodycustom3 = null, Expression<Func<string>> bodycustom4 = null, Expression<Func<string>> bodycustom5 = null, Expression<Func<string>> bodycustom6 = null, Expression<Func<string>> bodycustom7 = null, Expression<Func<string>> bodycustom8 = null, Expression<Func<string>> bodycustom9 = null, Expression<Func<string>> bodycustom10 = null, Expression<Func<string>> bodycustom11 = null, Expression<Func<string>> bodycustom12 = null, Expression<Func<string>> bodycustom13 = null, Expression<Func<string>> bodycustom14 = null, Expression<Func<string>> bodycustom15 = null, Expression<Func<string>> bodycustom16 = null, Expression<Func<string>> bodycustom17 = null, Expression<Func<string>> bodycustom18 = null, Expression<Func<string>> bodycustom19 = null, Expression<Func<string>> bodycustom20 = null, Expression<Func<string>> bodycustom21From = null, Expression<Func<string>> bodycustom21To = null, Expression<Func<string>> bodycustom22From = null, Expression<Func<string>> bodycustom22To = null, Expression<Func<string>> bodycustom23From = null, Expression<Func<string>> bodycustom23To = null, Expression<Func<string>> bodycustom24From = null, Expression<Func<string>> bodycustom24To = null, Expression<Func<bool>> bodycustom25 = null, Expression<Func<bool>> bodycustom26 = null, Expression<Func<bool>> bodycustom27 = null, Expression<Func<bool>> bodycustom28 = null, Expression<Func<string>> bodycustom29 = null, Expression<Func<string>> bodycustom30 = null)
        {
            var __workflow_bodylibraryId = WorkflowExpression.Compile(bodylibraryId, nameof(bodylibraryId), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodyowner = WorkflowExpression.Compile(bodyowner, nameof(bodyowner), required: false);
            var __workflow_bodyanywhere = WorkflowExpression.Compile(bodyanywhere, nameof(bodyanywhere), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodysubclass = WorkflowExpression.Compile(bodysubclass, nameof(bodysubclass), required: false);
            var __workflow_bodycustom1 = WorkflowExpression.Compile(bodycustom1, nameof(bodycustom1), required: false);
            var __workflow_bodycustom2 = WorkflowExpression.Compile(bodycustom2, nameof(bodycustom2), required: false);
            var __workflow_bodycustom3 = WorkflowExpression.Compile(bodycustom3, nameof(bodycustom3), required: false);
            var __workflow_bodycustom4 = WorkflowExpression.Compile(bodycustom4, nameof(bodycustom4), required: false);
            var __workflow_bodycustom5 = WorkflowExpression.Compile(bodycustom5, nameof(bodycustom5), required: false);
            var __workflow_bodycustom6 = WorkflowExpression.Compile(bodycustom6, nameof(bodycustom6), required: false);
            var __workflow_bodycustom7 = WorkflowExpression.Compile(bodycustom7, nameof(bodycustom7), required: false);
            var __workflow_bodycustom8 = WorkflowExpression.Compile(bodycustom8, nameof(bodycustom8), required: false);
            var __workflow_bodycustom9 = WorkflowExpression.Compile(bodycustom9, nameof(bodycustom9), required: false);
            var __workflow_bodycustom10 = WorkflowExpression.Compile(bodycustom10, nameof(bodycustom10), required: false);
            var __workflow_bodycustom11 = WorkflowExpression.Compile(bodycustom11, nameof(bodycustom11), required: false);
            var __workflow_bodycustom12 = WorkflowExpression.Compile(bodycustom12, nameof(bodycustom12), required: false);
            var __workflow_bodycustom13 = WorkflowExpression.Compile(bodycustom13, nameof(bodycustom13), required: false);
            var __workflow_bodycustom14 = WorkflowExpression.Compile(bodycustom14, nameof(bodycustom14), required: false);
            var __workflow_bodycustom15 = WorkflowExpression.Compile(bodycustom15, nameof(bodycustom15), required: false);
            var __workflow_bodycustom16 = WorkflowExpression.Compile(bodycustom16, nameof(bodycustom16), required: false);
            var __workflow_bodycustom17 = WorkflowExpression.Compile(bodycustom17, nameof(bodycustom17), required: false);
            var __workflow_bodycustom18 = WorkflowExpression.Compile(bodycustom18, nameof(bodycustom18), required: false);
            var __workflow_bodycustom19 = WorkflowExpression.Compile(bodycustom19, nameof(bodycustom19), required: false);
            var __workflow_bodycustom20 = WorkflowExpression.Compile(bodycustom20, nameof(bodycustom20), required: false);
            var __workflow_bodycustom21From = WorkflowExpression.Compile(bodycustom21From, nameof(bodycustom21From), required: false);
            var __workflow_bodycustom21To = WorkflowExpression.Compile(bodycustom21To, nameof(bodycustom21To), required: false);
            var __workflow_bodycustom22From = WorkflowExpression.Compile(bodycustom22From, nameof(bodycustom22From), required: false);
            var __workflow_bodycustom22To = WorkflowExpression.Compile(bodycustom22To, nameof(bodycustom22To), required: false);
            var __workflow_bodycustom23From = WorkflowExpression.Compile(bodycustom23From, nameof(bodycustom23From), required: false);
            var __workflow_bodycustom23To = WorkflowExpression.Compile(bodycustom23To, nameof(bodycustom23To), required: false);
            var __workflow_bodycustom24From = WorkflowExpression.Compile(bodycustom24From, nameof(bodycustom24From), required: false);
            var __workflow_bodycustom24To = WorkflowExpression.Compile(bodycustom24To, nameof(bodycustom24To), required: false);
            var __workflow_bodycustom25 = WorkflowExpression.Compile(bodycustom25, nameof(bodycustom25), required: false);
            var __workflow_bodycustom26 = WorkflowExpression.Compile(bodycustom26, nameof(bodycustom26), required: false);
            var __workflow_bodycustom27 = WorkflowExpression.Compile(bodycustom27, nameof(bodycustom27), required: false);
            var __workflow_bodycustom28 = WorkflowExpression.Compile(bodycustom28, nameof(bodycustom28), required: false);
            var __workflow_bodycustom29 = WorkflowExpression.Compile(bodycustom29, nameof(bodycustom29), required: false);
            var __workflow_bodycustom30 = WorkflowExpression.Compile(bodycustom30, nameof(bodycustom30), required: false);
            return new DeferredBodyAction<SearchWorkspacesResponseBody, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/searchWorkspaces";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["libraryId"] = ExpressionConverter.ConvertO(__workflow_bodylibraryId);
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodyowner != null)
                {
                    body["owner"] = ExpressionConverter.ConvertO(__workflow_bodyowner);
                    bodypropCount++;
                }

                if (__workflow_bodyanywhere != null)
                {
                    body["anywhere"] = ExpressionConverter.ConvertO(__workflow_bodyanywhere);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodysubclass != null)
                {
                    body["subclass"] = ExpressionConverter.ConvertO(__workflow_bodysubclass);
                    bodypropCount++;
                }

                if (__workflow_bodycustom1 != null)
                {
                    body["custom1"] = ExpressionConverter.ConvertO(__workflow_bodycustom1);
                    bodypropCount++;
                }

                if (__workflow_bodycustom2 != null)
                {
                    body["custom2"] = ExpressionConverter.ConvertO(__workflow_bodycustom2);
                    bodypropCount++;
                }

                if (__workflow_bodycustom3 != null)
                {
                    body["custom3"] = ExpressionConverter.ConvertO(__workflow_bodycustom3);
                    bodypropCount++;
                }

                if (__workflow_bodycustom4 != null)
                {
                    body["custom4"] = ExpressionConverter.ConvertO(__workflow_bodycustom4);
                    bodypropCount++;
                }

                if (__workflow_bodycustom5 != null)
                {
                    body["custom5"] = ExpressionConverter.ConvertO(__workflow_bodycustom5);
                    bodypropCount++;
                }

                if (__workflow_bodycustom6 != null)
                {
                    body["custom6"] = ExpressionConverter.ConvertO(__workflow_bodycustom6);
                    bodypropCount++;
                }

                if (__workflow_bodycustom7 != null)
                {
                    body["custom7"] = ExpressionConverter.ConvertO(__workflow_bodycustom7);
                    bodypropCount++;
                }

                if (__workflow_bodycustom8 != null)
                {
                    body["custom8"] = ExpressionConverter.ConvertO(__workflow_bodycustom8);
                    bodypropCount++;
                }

                if (__workflow_bodycustom9 != null)
                {
                    body["custom9"] = ExpressionConverter.ConvertO(__workflow_bodycustom9);
                    bodypropCount++;
                }

                if (__workflow_bodycustom10 != null)
                {
                    body["custom10"] = ExpressionConverter.ConvertO(__workflow_bodycustom10);
                    bodypropCount++;
                }

                if (__workflow_bodycustom11 != null)
                {
                    body["custom11"] = ExpressionConverter.ConvertO(__workflow_bodycustom11);
                    bodypropCount++;
                }

                if (__workflow_bodycustom12 != null)
                {
                    body["custom12"] = ExpressionConverter.ConvertO(__workflow_bodycustom12);
                    bodypropCount++;
                }

                if (__workflow_bodycustom13 != null)
                {
                    body["custom13"] = ExpressionConverter.ConvertO(__workflow_bodycustom13);
                    bodypropCount++;
                }

                if (__workflow_bodycustom14 != null)
                {
                    body["custom14"] = ExpressionConverter.ConvertO(__workflow_bodycustom14);
                    bodypropCount++;
                }

                if (__workflow_bodycustom15 != null)
                {
                    body["custom15"] = ExpressionConverter.ConvertO(__workflow_bodycustom15);
                    bodypropCount++;
                }

                if (__workflow_bodycustom16 != null)
                {
                    body["custom16"] = ExpressionConverter.ConvertO(__workflow_bodycustom16);
                    bodypropCount++;
                }

                if (__workflow_bodycustom17 != null)
                {
                    body["custom17"] = ExpressionConverter.ConvertO(__workflow_bodycustom17);
                    bodypropCount++;
                }

                if (__workflow_bodycustom18 != null)
                {
                    body["custom18"] = ExpressionConverter.ConvertO(__workflow_bodycustom18);
                    bodypropCount++;
                }

                if (__workflow_bodycustom19 != null)
                {
                    body["custom19"] = ExpressionConverter.ConvertO(__workflow_bodycustom19);
                    bodypropCount++;
                }

                if (__workflow_bodycustom20 != null)
                {
                    body["custom20"] = ExpressionConverter.ConvertO(__workflow_bodycustom20);
                    bodypropCount++;
                }

                if (__workflow_bodycustom21From != null)
                {
                    body["custom21_from"] = ExpressionConverter.ConvertO(__workflow_bodycustom21From);
                    bodypropCount++;
                }

                if (__workflow_bodycustom21To != null)
                {
                    body["custom21_to"] = ExpressionConverter.ConvertO(__workflow_bodycustom21To);
                    bodypropCount++;
                }

                if (__workflow_bodycustom22From != null)
                {
                    body["custom22_from"] = ExpressionConverter.ConvertO(__workflow_bodycustom22From);
                    bodypropCount++;
                }

                if (__workflow_bodycustom22To != null)
                {
                    body["custom22_to"] = ExpressionConverter.ConvertO(__workflow_bodycustom22To);
                    bodypropCount++;
                }

                if (__workflow_bodycustom23From != null)
                {
                    body["custom23_from"] = ExpressionConverter.ConvertO(__workflow_bodycustom23From);
                    bodypropCount++;
                }

                if (__workflow_bodycustom23To != null)
                {
                    body["custom23_to"] = ExpressionConverter.ConvertO(__workflow_bodycustom23To);
                    bodypropCount++;
                }

                if (__workflow_bodycustom24From != null)
                {
                    body["custom24_from"] = ExpressionConverter.ConvertO(__workflow_bodycustom24From);
                    bodypropCount++;
                }

                if (__workflow_bodycustom24To != null)
                {
                    body["custom24_to"] = ExpressionConverter.ConvertO(__workflow_bodycustom24To);
                    bodypropCount++;
                }

                if (__workflow_bodycustom25 != null)
                {
                    body["custom25"] = ExpressionConverter.ConvertO(__workflow_bodycustom25);
                    bodypropCount++;
                }

                if (__workflow_bodycustom26 != null)
                {
                    body["custom26"] = ExpressionConverter.ConvertO(__workflow_bodycustom26);
                    bodypropCount++;
                }

                if (__workflow_bodycustom27 != null)
                {
                    body["custom27"] = ExpressionConverter.ConvertO(__workflow_bodycustom27);
                    bodypropCount++;
                }

                if (__workflow_bodycustom28 != null)
                {
                    body["custom28"] = ExpressionConverter.ConvertO(__workflow_bodycustom28);
                    bodypropCount++;
                }

                if (__workflow_bodycustom29 != null)
                {
                    body["custom29"] = ExpressionConverter.ConvertO(__workflow_bodycustom29);
                    bodypropCount++;
                }

                if (__workflow_bodycustom30 != null)
                {
                    body["custom30"] = ExpressionConverter.ConvertO(__workflow_bodycustom30);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SearchWorkspacesResponseBody>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagework")]
        public IBodyWorkflowAction<AddDocumentReferenceResponse, ApiConnectionActionConfiguration> AddDocumentReference(Expression<Func<string>> bodydocumentId, Expression<Func<string>> bodyfolderId)
        {
            var __workflow_bodydocumentId = WorkflowExpression.Compile(bodydocumentId, nameof(bodydocumentId), required: true);
            var __workflow_bodyfolderId = WorkflowExpression.Compile(bodyfolderId, nameof(bodyfolderId), required: true);
            return new DeferredBodyAction<AddDocumentReferenceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/addDocumentReference";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["documentId"] = ExpressionConverter.ConvertO(__workflow_bodydocumentId);
                bodypropCount++;
                body["folderId"] = ExpressionConverter.ConvertO(__workflow_bodyfolderId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<AddDocumentReferenceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagework")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> DeleteDocumentReference(Expression<Func<string>> documentId, Expression<Func<string>> folderId)
        {
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            var __workflow_folderId = WorkflowExpression.Compile(folderId, nameof(folderId), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/deleteDocumentReference";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["documentId"] = ExpressionConverter.Convert(__workflow_documentId);
                callPayload.Queries["folderId"] = ExpressionConverter.Convert(__workflow_folderId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagework")]
        public IBodyWorkflowAction<MoveDocumentResponseBody, ApiConnectionActionConfiguration> MoveDocument(Expression<Func<string>> bodyfolderId, Expression<Func<string>> bodydocumentId, Expression<Func<string>> bodydestinationFolderId, Expression<Func<bool>> bodyupdateProfile = null, Expression<Func<bool>> bodyupdateSecurity = null, Expression<Func<string>> bodycomments = null)
        {
            var __workflow_bodyfolderId = WorkflowExpression.Compile(bodyfolderId, nameof(bodyfolderId), required: true);
            var __workflow_bodydocumentId = WorkflowExpression.Compile(bodydocumentId, nameof(bodydocumentId), required: true);
            var __workflow_bodydestinationFolderId = WorkflowExpression.Compile(bodydestinationFolderId, nameof(bodydestinationFolderId), required: true);
            var __workflow_bodyupdateProfile = WorkflowExpression.Compile(bodyupdateProfile, nameof(bodyupdateProfile), required: false);
            var __workflow_bodyupdateSecurity = WorkflowExpression.Compile(bodyupdateSecurity, nameof(bodyupdateSecurity), required: false);
            var __workflow_bodycomments = WorkflowExpression.Compile(bodycomments, nameof(bodycomments), required: false);
            return new DeferredBodyAction<MoveDocumentResponseBody, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/moveDocument";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["folderId"] = ExpressionConverter.ConvertO(__workflow_bodyfolderId);
                bodypropCount++;
                body["documentId"] = ExpressionConverter.ConvertO(__workflow_bodydocumentId);
                bodypropCount++;
                body["destination_folder_id"] = ExpressionConverter.ConvertO(__workflow_bodydestinationFolderId);
                if (__workflow_bodyupdateProfile != null)
                {
                    if (__workflow_bodyupdateProfile != null)
                    {
                        body["update_profile"] = ExpressionConverter.ConvertO(__workflow_bodyupdateProfile);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["update_profile"] = true;
                    bodypropCount++;
                }

                if (__workflow_bodyupdateSecurity != null)
                {
                    if (__workflow_bodyupdateSecurity != null)
                    {
                        body["update_security"] = ExpressionConverter.ConvertO(__workflow_bodyupdateSecurity);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["update_security"] = true;
                    bodypropCount++;
                }

                if (__workflow_bodycomments != null)
                {
                    body["comments"] = ExpressionConverter.ConvertO(__workflow_bodycomments);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<MoveDocumentResponseBody>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagework")]
        public IBodyWorkflowAction<CopyDocumentResponse, ApiConnectionActionConfiguration> CopyDocument(Expression<Func<string>> bodydocumentId, Expression<Func<string>> bodyfolderId)
        {
            var __workflow_bodydocumentId = WorkflowExpression.Compile(bodydocumentId, nameof(bodydocumentId), required: true);
            var __workflow_bodyfolderId = WorkflowExpression.Compile(bodyfolderId, nameof(bodyfolderId), required: true);
            return new DeferredBodyAction<CopyDocumentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/copyDocument";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["documentId"] = ExpressionConverter.ConvertO(__workflow_bodydocumentId);
                bodypropCount++;
                body["folderId"] = ExpressionConverter.ConvertO(__workflow_bodyfolderId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CopyDocumentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagework")]
        public IBodyWorkflowAction<CreateFormLinkResponse, ApiConnectionActionConfiguration> CreateFormLink(Expression<Func<string>> bodylibraryId, Expression<Func<string>> bodyformId, Expression<Func<string>> bodysecurity, Expression<Func<string>> bodyexpiresAt = null, Expression<Func<object>> bodylinkData = null)
        {
            var __workflow_bodylibraryId = WorkflowExpression.Compile(bodylibraryId, nameof(bodylibraryId), required: true);
            var __workflow_bodyformId = WorkflowExpression.Compile(bodyformId, nameof(bodyformId), required: true);
            var __workflow_bodysecurity = WorkflowExpression.Compile(bodysecurity, nameof(bodysecurity), required: true);
            var __workflow_bodyexpiresAt = WorkflowExpression.Compile(bodyexpiresAt, nameof(bodyexpiresAt), required: false);
            var __workflow_bodylinkData = WorkflowExpression.Compile(bodylinkData, nameof(bodylinkData), required: false);
            return new DeferredBodyAction<CreateFormLinkResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/createFormLink";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["libraryId"] = ExpressionConverter.ConvertO(__workflow_bodylibraryId);
                bodypropCount++;
                body["formId"] = ExpressionConverter.ConvertO(__workflow_bodyformId);
                if (__workflow_bodyexpiresAt != null)
                {
                    body["expires_at"] = ExpressionConverter.ConvertO(__workflow_bodyexpiresAt);
                    bodypropCount++;
                }

                bodypropCount++;
                body["security"] = ExpressionConverter.ConvertO(__workflow_bodysecurity);
                if (__workflow_bodylinkData != null)
                {
                    body["link_data"] = ExpressionConverter.ConvertO(__workflow_bodylinkData);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateFormLinkResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagework")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> UpdateWorkflowState(Expression<Func<string>> bodylibraryId, Expression<Func<string>> bodystate, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodystatusMessage = null)
        {
            var __workflow_bodylibraryId = WorkflowExpression.Compile(bodylibraryId, nameof(bodylibraryId), required: true);
            var __workflow_bodystate = WorkflowExpression.Compile(bodystate, nameof(bodystate), required: true);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodystatusMessage = WorkflowExpression.Compile(bodystatusMessage, nameof(bodystatusMessage), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/updateWorkflowState";
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["libraryId"] = ExpressionConverter.ConvertO(__workflow_bodylibraryId);
                bodypropCount++;
                body["state"] = ExpressionConverter.ConvertO(__workflow_bodystate);
                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodystatusMessage != null)
                {
                    body["statusMessage"] = ExpressionConverter.ConvertO(__workflow_bodystatusMessage);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagework")]
        public IBodyWorkflowAction<CoreEMPropertiesResponseBody, ApiConnectionActionConfiguration> GetCoreEMPropertiesForDocument(Expression<Func<string>> bodydocumentId, Expression<Func<bool>> bodylatest = null)
        {
            var __workflow_bodydocumentId = WorkflowExpression.Compile(bodydocumentId, nameof(bodydocumentId), required: true);
            var __workflow_bodylatest = WorkflowExpression.Compile(bodylatest, nameof(bodylatest), required: false);
            return new DeferredBodyAction<CoreEMPropertiesResponseBody, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/getCoreEMPropertiesForDocument";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["documentId"] = ExpressionConverter.ConvertO(__workflow_bodydocumentId);
                if (__workflow_bodylatest != null)
                {
                    if (__workflow_bodylatest != null)
                    {
                        body["latest"] = ExpressionConverter.ConvertO(__workflow_bodylatest);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["latest"] = false;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CoreEMPropertiesResponseBody>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagework")]
        public IBodyWorkflowAction<PromoteDocumentVersionResponseBody, ApiConnectionActionConfiguration> PromoteDocumentVersion(Expression<Func<string>> bodydocumentId, Expression<Func<int>> bodyversion = null, Expression<Func<string>> bodyjournalId = null, Expression<Func<string>> bodycomment = null, Expression<Func<string>> bodyalias = null, Expression<Func<string>> bodyauthor = null, Expression<Func<string>> bodyClass = null, Expression<Func<bodydefaultSecurityInput>> bodydefaultSecurity = null, Expression<Func<bool>> bodyisDeclared = null, Expression<Func<bool>> bodyisHipaa = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodyOperator = null, Expression<Func<int>> bodyretainDays = null, Expression<Func<string>> bodysubclass = null, Expression<Func<string>> bodycustom1 = null, Expression<Func<string>> bodycustom2 = null, Expression<Func<string>> bodycustom3 = null, Expression<Func<string>> bodycustom4 = null, Expression<Func<string>> bodycustom5 = null, Expression<Func<string>> bodycustom6 = null, Expression<Func<string>> bodycustom7 = null, Expression<Func<string>> bodycustom8 = null, Expression<Func<string>> bodycustom9 = null, Expression<Func<string>> bodycustom10 = null, Expression<Func<string>> bodycustom11 = null, Expression<Func<string>> bodycustom12 = null, Expression<Func<string>> bodycustom13 = null, Expression<Func<string>> bodycustom14 = null, Expression<Func<string>> bodycustom15 = null, Expression<Func<string>> bodycustom16 = null, Expression<Func<double>> bodycustom17 = null, Expression<Func<double>> bodycustom18 = null, Expression<Func<double>> bodycustom19 = null, Expression<Func<double>> bodycustom20 = null, Expression<Func<string>> bodycustom21 = null, Expression<Func<string>> bodycustom22 = null, Expression<Func<string>> bodycustom23 = null, Expression<Func<string>> bodycustom24 = null, Expression<Func<bool>> bodycustom25 = null, Expression<Func<bool>> bodycustom26 = null, Expression<Func<bool>> bodycustom27 = null, Expression<Func<bool>> bodycustom28 = null, Expression<Func<string>> bodycustom29 = null, Expression<Func<string>> bodycustom30 = null)
        {
            var __workflow_bodydocumentId = WorkflowExpression.Compile(bodydocumentId, nameof(bodydocumentId), required: true);
            var __workflow_bodyversion = WorkflowExpression.Compile(bodyversion, nameof(bodyversion), required: false);
            var __workflow_bodyjournalId = WorkflowExpression.Compile(bodyjournalId, nameof(bodyjournalId), required: false);
            var __workflow_bodycomment = WorkflowExpression.Compile(bodycomment, nameof(bodycomment), required: false);
            var __workflow_bodyalias = WorkflowExpression.Compile(bodyalias, nameof(bodyalias), required: false);
            var __workflow_bodyauthor = WorkflowExpression.Compile(bodyauthor, nameof(bodyauthor), required: false);
            var __workflow_bodyClass = WorkflowExpression.Compile(bodyClass, nameof(bodyClass), required: false);
            var __workflow_bodydefaultSecurity = WorkflowExpression.Compile(bodydefaultSecurity, nameof(bodydefaultSecurity), required: false);
            var __workflow_bodyisDeclared = WorkflowExpression.Compile(bodyisDeclared, nameof(bodyisDeclared), required: false);
            var __workflow_bodyisHipaa = WorkflowExpression.Compile(bodyisHipaa, nameof(bodyisHipaa), required: false);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodyOperator = WorkflowExpression.Compile(bodyOperator, nameof(bodyOperator), required: false);
            var __workflow_bodyretainDays = WorkflowExpression.Compile(bodyretainDays, nameof(bodyretainDays), required: false);
            var __workflow_bodysubclass = WorkflowExpression.Compile(bodysubclass, nameof(bodysubclass), required: false);
            var __workflow_bodycustom1 = WorkflowExpression.Compile(bodycustom1, nameof(bodycustom1), required: false);
            var __workflow_bodycustom2 = WorkflowExpression.Compile(bodycustom2, nameof(bodycustom2), required: false);
            var __workflow_bodycustom3 = WorkflowExpression.Compile(bodycustom3, nameof(bodycustom3), required: false);
            var __workflow_bodycustom4 = WorkflowExpression.Compile(bodycustom4, nameof(bodycustom4), required: false);
            var __workflow_bodycustom5 = WorkflowExpression.Compile(bodycustom5, nameof(bodycustom5), required: false);
            var __workflow_bodycustom6 = WorkflowExpression.Compile(bodycustom6, nameof(bodycustom6), required: false);
            var __workflow_bodycustom7 = WorkflowExpression.Compile(bodycustom7, nameof(bodycustom7), required: false);
            var __workflow_bodycustom8 = WorkflowExpression.Compile(bodycustom8, nameof(bodycustom8), required: false);
            var __workflow_bodycustom9 = WorkflowExpression.Compile(bodycustom9, nameof(bodycustom9), required: false);
            var __workflow_bodycustom10 = WorkflowExpression.Compile(bodycustom10, nameof(bodycustom10), required: false);
            var __workflow_bodycustom11 = WorkflowExpression.Compile(bodycustom11, nameof(bodycustom11), required: false);
            var __workflow_bodycustom12 = WorkflowExpression.Compile(bodycustom12, nameof(bodycustom12), required: false);
            var __workflow_bodycustom13 = WorkflowExpression.Compile(bodycustom13, nameof(bodycustom13), required: false);
            var __workflow_bodycustom14 = WorkflowExpression.Compile(bodycustom14, nameof(bodycustom14), required: false);
            var __workflow_bodycustom15 = WorkflowExpression.Compile(bodycustom15, nameof(bodycustom15), required: false);
            var __workflow_bodycustom16 = WorkflowExpression.Compile(bodycustom16, nameof(bodycustom16), required: false);
            var __workflow_bodycustom17 = WorkflowExpression.Compile(bodycustom17, nameof(bodycustom17), required: false);
            var __workflow_bodycustom18 = WorkflowExpression.Compile(bodycustom18, nameof(bodycustom18), required: false);
            var __workflow_bodycustom19 = WorkflowExpression.Compile(bodycustom19, nameof(bodycustom19), required: false);
            var __workflow_bodycustom20 = WorkflowExpression.Compile(bodycustom20, nameof(bodycustom20), required: false);
            var __workflow_bodycustom21 = WorkflowExpression.Compile(bodycustom21, nameof(bodycustom21), required: false);
            var __workflow_bodycustom22 = WorkflowExpression.Compile(bodycustom22, nameof(bodycustom22), required: false);
            var __workflow_bodycustom23 = WorkflowExpression.Compile(bodycustom23, nameof(bodycustom23), required: false);
            var __workflow_bodycustom24 = WorkflowExpression.Compile(bodycustom24, nameof(bodycustom24), required: false);
            var __workflow_bodycustom25 = WorkflowExpression.Compile(bodycustom25, nameof(bodycustom25), required: false);
            var __workflow_bodycustom26 = WorkflowExpression.Compile(bodycustom26, nameof(bodycustom26), required: false);
            var __workflow_bodycustom27 = WorkflowExpression.Compile(bodycustom27, nameof(bodycustom27), required: false);
            var __workflow_bodycustom28 = WorkflowExpression.Compile(bodycustom28, nameof(bodycustom28), required: false);
            var __workflow_bodycustom29 = WorkflowExpression.Compile(bodycustom29, nameof(bodycustom29), required: false);
            var __workflow_bodycustom30 = WorkflowExpression.Compile(bodycustom30, nameof(bodycustom30), required: false);
            return new DeferredBodyAction<PromoteDocumentVersionResponseBody, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/promoteDocumentVersion";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["documentId"] = ExpressionConverter.ConvertO(__workflow_bodydocumentId);
                if (__workflow_bodyversion != null)
                {
                    body["version"] = ExpressionConverter.ConvertO(__workflow_bodyversion);
                    bodypropCount++;
                }

                if (__workflow_bodyjournalId != null)
                {
                    body["journalId"] = ExpressionConverter.ConvertO(__workflow_bodyjournalId);
                    bodypropCount++;
                }

                if (__workflow_bodycomment != null)
                {
                    body["comment"] = ExpressionConverter.ConvertO(__workflow_bodycomment);
                    bodypropCount++;
                }

                if (__workflow_bodyalias != null)
                {
                    body["alias"] = ExpressionConverter.ConvertO(__workflow_bodyalias);
                    bodypropCount++;
                }

                if (__workflow_bodyauthor != null)
                {
                    body["author"] = ExpressionConverter.ConvertO(__workflow_bodyauthor);
                    bodypropCount++;
                }

                if (__workflow_bodyClass != null)
                {
                    body["class"] = ExpressionConverter.ConvertO(__workflow_bodyClass);
                    bodypropCount++;
                }

                if (__workflow_bodydefaultSecurity != null)
                {
                    body["default_security"] = ExpressionConverter.ConvertO(__workflow_bodydefaultSecurity);
                    bodypropCount++;
                }

                if (__workflow_bodyisDeclared != null)
                {
                    body["is_declared"] = ExpressionConverter.ConvertO(__workflow_bodyisDeclared);
                    bodypropCount++;
                }

                if (__workflow_bodyisHipaa != null)
                {
                    body["is_hipaa"] = ExpressionConverter.ConvertO(__workflow_bodyisHipaa);
                    bodypropCount++;
                }

                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodyOperator != null)
                {
                    body["operator"] = ExpressionConverter.ConvertO(__workflow_bodyOperator);
                    bodypropCount++;
                }

                if (__workflow_bodyretainDays != null)
                {
                    body["retain_days"] = ExpressionConverter.ConvertO(__workflow_bodyretainDays);
                    bodypropCount++;
                }

                if (__workflow_bodysubclass != null)
                {
                    body["subclass"] = ExpressionConverter.ConvertO(__workflow_bodysubclass);
                    bodypropCount++;
                }

                if (__workflow_bodycustom1 != null)
                {
                    body["custom1"] = ExpressionConverter.ConvertO(__workflow_bodycustom1);
                    bodypropCount++;
                }

                if (__workflow_bodycustom2 != null)
                {
                    body["custom2"] = ExpressionConverter.ConvertO(__workflow_bodycustom2);
                    bodypropCount++;
                }

                if (__workflow_bodycustom3 != null)
                {
                    body["custom3"] = ExpressionConverter.ConvertO(__workflow_bodycustom3);
                    bodypropCount++;
                }

                if (__workflow_bodycustom4 != null)
                {
                    body["custom4"] = ExpressionConverter.ConvertO(__workflow_bodycustom4);
                    bodypropCount++;
                }

                if (__workflow_bodycustom5 != null)
                {
                    body["custom5"] = ExpressionConverter.ConvertO(__workflow_bodycustom5);
                    bodypropCount++;
                }

                if (__workflow_bodycustom6 != null)
                {
                    body["custom6"] = ExpressionConverter.ConvertO(__workflow_bodycustom6);
                    bodypropCount++;
                }

                if (__workflow_bodycustom7 != null)
                {
                    body["custom7"] = ExpressionConverter.ConvertO(__workflow_bodycustom7);
                    bodypropCount++;
                }

                if (__workflow_bodycustom8 != null)
                {
                    body["custom8"] = ExpressionConverter.ConvertO(__workflow_bodycustom8);
                    bodypropCount++;
                }

                if (__workflow_bodycustom9 != null)
                {
                    body["custom9"] = ExpressionConverter.ConvertO(__workflow_bodycustom9);
                    bodypropCount++;
                }

                if (__workflow_bodycustom10 != null)
                {
                    body["custom10"] = ExpressionConverter.ConvertO(__workflow_bodycustom10);
                    bodypropCount++;
                }

                if (__workflow_bodycustom11 != null)
                {
                    body["custom11"] = ExpressionConverter.ConvertO(__workflow_bodycustom11);
                    bodypropCount++;
                }

                if (__workflow_bodycustom12 != null)
                {
                    body["custom12"] = ExpressionConverter.ConvertO(__workflow_bodycustom12);
                    bodypropCount++;
                }

                if (__workflow_bodycustom13 != null)
                {
                    body["custom13"] = ExpressionConverter.ConvertO(__workflow_bodycustom13);
                    bodypropCount++;
                }

                if (__workflow_bodycustom14 != null)
                {
                    body["custom14"] = ExpressionConverter.ConvertO(__workflow_bodycustom14);
                    bodypropCount++;
                }

                if (__workflow_bodycustom15 != null)
                {
                    body["custom15"] = ExpressionConverter.ConvertO(__workflow_bodycustom15);
                    bodypropCount++;
                }

                if (__workflow_bodycustom16 != null)
                {
                    body["custom16"] = ExpressionConverter.ConvertO(__workflow_bodycustom16);
                    bodypropCount++;
                }

                if (__workflow_bodycustom17 != null)
                {
                    body["custom17"] = ExpressionConverter.ConvertO(__workflow_bodycustom17);
                    bodypropCount++;
                }

                if (__workflow_bodycustom18 != null)
                {
                    body["custom18"] = ExpressionConverter.ConvertO(__workflow_bodycustom18);
                    bodypropCount++;
                }

                if (__workflow_bodycustom19 != null)
                {
                    body["custom19"] = ExpressionConverter.ConvertO(__workflow_bodycustom19);
                    bodypropCount++;
                }

                if (__workflow_bodycustom20 != null)
                {
                    body["custom20"] = ExpressionConverter.ConvertO(__workflow_bodycustom20);
                    bodypropCount++;
                }

                if (__workflow_bodycustom21 != null)
                {
                    body["custom21"] = ExpressionConverter.ConvertO(__workflow_bodycustom21);
                    bodypropCount++;
                }

                if (__workflow_bodycustom22 != null)
                {
                    body["custom22"] = ExpressionConverter.ConvertO(__workflow_bodycustom22);
                    bodypropCount++;
                }

                if (__workflow_bodycustom23 != null)
                {
                    body["custom23"] = ExpressionConverter.ConvertO(__workflow_bodycustom23);
                    bodypropCount++;
                }

                if (__workflow_bodycustom24 != null)
                {
                    body["custom24"] = ExpressionConverter.ConvertO(__workflow_bodycustom24);
                    bodypropCount++;
                }

                if (__workflow_bodycustom25 != null)
                {
                    body["custom25"] = ExpressionConverter.ConvertO(__workflow_bodycustom25);
                    bodypropCount++;
                }

                if (__workflow_bodycustom26 != null)
                {
                    body["custom26"] = ExpressionConverter.ConvertO(__workflow_bodycustom26);
                    bodypropCount++;
                }

                if (__workflow_bodycustom27 != null)
                {
                    body["custom27"] = ExpressionConverter.ConvertO(__workflow_bodycustom27);
                    bodypropCount++;
                }

                if (__workflow_bodycustom28 != null)
                {
                    body["custom28"] = ExpressionConverter.ConvertO(__workflow_bodycustom28);
                    bodypropCount++;
                }

                if (__workflow_bodycustom29 != null)
                {
                    body["custom29"] = ExpressionConverter.ConvertO(__workflow_bodycustom29);
                    bodypropCount++;
                }

                if (__workflow_bodycustom30 != null)
                {
                    body["custom30"] = ExpressionConverter.ConvertO(__workflow_bodycustom30);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PromoteDocumentVersionResponseBody>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagework")]
        public IBodyWorkflowAction<GetDocumentVersionsResponse, ApiConnectionActionConfiguration> GetDocumentVersions(Expression<Func<string>> bodydocumentId)
        {
            var __workflow_bodydocumentId = WorkflowExpression.Compile(bodydocumentId, nameof(bodydocumentId), required: true);
            return new DeferredBodyAction<GetDocumentVersionsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/getDocumentVersions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["documentId"] = ExpressionConverter.ConvertO(__workflow_bodydocumentId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GetDocumentVersionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagework")]
        public IBodyWorkflowAction<CoreEMPropertiesResponseBody, ApiConnectionActionConfiguration> SetCoreEMPropertiesForDocument(Expression<Func<string>> bodydocumentId, Expression<Func<bodyemPropertiesInputItem[]>> bodyemProperties)
        {
            var __workflow_bodydocumentId = WorkflowExpression.Compile(bodydocumentId, nameof(bodydocumentId), required: true);
            var __workflow_bodyemProperties = WorkflowExpression.Compile(bodyemProperties, nameof(bodyemProperties), required: true);
            return new DeferredBodyAction<CoreEMPropertiesResponseBody, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/setCoreEMPropertiesForDocument";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["documentId"] = ExpressionConverter.ConvertO(__workflow_bodydocumentId);
                bodypropCount++;
                body["emProperties"] = ExpressionConverter.ConvertO(__workflow_bodyemProperties);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CoreEMPropertiesResponseBody>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagework")]
        public IBodyWorkflowAction<SearchCoreEMTaxonomyNodeValuesResponse, ApiConnectionActionConfiguration> SearchCoreEMTaxonomyNodeValues(Expression<Func<string>> bodylibraryId, Expression<Func<string>> bodytaxonomyProperty, Expression<Func<string>> bodyid = null, Expression<Func<string>> bodyquery = null, Expression<Func<bodyenabledStateInput>> bodyenabledState = null, Expression<Func<bool>> bodyincludePath = null, Expression<Func<string>> bodychildrenOfSsid = null, Expression<Func<bool>> bodyimmediateChildrenOnly = null)
        {
            var __workflow_bodylibraryId = WorkflowExpression.Compile(bodylibraryId, nameof(bodylibraryId), required: true);
            var __workflow_bodytaxonomyProperty = WorkflowExpression.Compile(bodytaxonomyProperty, nameof(bodytaxonomyProperty), required: true);
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: false);
            var __workflow_bodyquery = WorkflowExpression.Compile(bodyquery, nameof(bodyquery), required: false);
            var __workflow_bodyenabledState = WorkflowExpression.Compile(bodyenabledState, nameof(bodyenabledState), required: false);
            var __workflow_bodyincludePath = WorkflowExpression.Compile(bodyincludePath, nameof(bodyincludePath), required: false);
            var __workflow_bodychildrenOfSsid = WorkflowExpression.Compile(bodychildrenOfSsid, nameof(bodychildrenOfSsid), required: false);
            var __workflow_bodyimmediateChildrenOnly = WorkflowExpression.Compile(bodyimmediateChildrenOnly, nameof(bodyimmediateChildrenOnly), required: false);
            return new DeferredBodyAction<SearchCoreEMTaxonomyNodeValuesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/searchCoreEMTaxonomyNodeValues";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["libraryId"] = ExpressionConverter.ConvertO(__workflow_bodylibraryId);
                bodypropCount++;
                body["taxonomyProperty"] = ExpressionConverter.ConvertO(__workflow_bodytaxonomyProperty);
                if (__workflow_bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                    bodypropCount++;
                }

                if (__workflow_bodyquery != null)
                {
                    body["query"] = ExpressionConverter.ConvertO(__workflow_bodyquery);
                    bodypropCount++;
                }

                if (__workflow_bodyenabledState != null)
                {
                    if (__workflow_bodyenabledState != null)
                    {
                        body["enabled_state"] = ExpressionConverter.ConvertO(__workflow_bodyenabledState);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["enabled_state"] = "Enabled";
                    bodypropCount++;
                }

                if (__workflow_bodyincludePath != null)
                {
                    if (__workflow_bodyincludePath != null)
                    {
                        body["include_path"] = ExpressionConverter.ConvertO(__workflow_bodyincludePath);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["include_path"] = false;
                    bodypropCount++;
                }

                if (__workflow_bodychildrenOfSsid != null)
                {
                    body["children_of_ssid"] = ExpressionConverter.ConvertO(__workflow_bodychildrenOfSsid);
                    bodypropCount++;
                }

                if (__workflow_bodyimmediateChildrenOnly != null)
                {
                    if (__workflow_bodyimmediateChildrenOnly != null)
                    {
                        body["immediate_children_only"] = ExpressionConverter.ConvertO(__workflow_bodyimmediateChildrenOnly);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["immediate_children_only"] = true;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SearchCoreEMTaxonomyNodeValuesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagework")]
        public IBodyWorkflowAction<AddDocumentHistoryEntryResponse, ApiConnectionActionConfiguration> AddDocumentHistoryEntry(Expression<Func<string>> bodydocumentId, Expression<Func<int>> bodyactivityCode, Expression<Func<string>> bodycomments = null, Expression<Func<int>> bodyduration = null)
        {
            var __workflow_bodydocumentId = WorkflowExpression.Compile(bodydocumentId, nameof(bodydocumentId), required: true);
            var __workflow_bodyactivityCode = WorkflowExpression.Compile(bodyactivityCode, nameof(bodyactivityCode), required: true);
            var __workflow_bodycomments = WorkflowExpression.Compile(bodycomments, nameof(bodycomments), required: false);
            var __workflow_bodyduration = WorkflowExpression.Compile(bodyduration, nameof(bodyduration), required: false);
            return new DeferredBodyAction<AddDocumentHistoryEntryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/addDocumentHistoryEntry";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["documentId"] = ExpressionConverter.ConvertO(__workflow_bodydocumentId);
                bodypropCount++;
                body["activity_code"] = ExpressionConverter.ConvertO(__workflow_bodyactivityCode);
                if (__workflow_bodycomments != null)
                {
                    body["comments"] = ExpressionConverter.ConvertO(__workflow_bodycomments);
                    bodypropCount++;
                }

                if (__workflow_bodyduration != null)
                {
                    body["duration"] = ExpressionConverter.ConvertO(__workflow_bodyduration);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<AddDocumentHistoryEntryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagework")]
        public IBodyWorkflowAction<SearchUsersResponse, ApiConnectionActionConfiguration> SearchUsers(Expression<Func<string>> email = null)
        {
            var __workflow_email = WorkflowExpression.Compile(email, nameof(email), required: false);
            return new DeferredBodyAction<SearchUsersResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/searchUsers";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_email != null)
                    callPayload.Queries["email"] = ExpressionConverter.Convert(__workflow_email);
                return new ApiConnectionAction<SearchUsersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagework")]
        public IBodyWorkflowAction<DeleteDocumentResponseBody, ApiConnectionActionConfiguration> DeleteDocument(Expression<Func<string>> documentId, Expression<Func<bool>> deleteAllVersions)
        {
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            var __workflow_deleteAllVersions = WorkflowExpression.Compile(deleteAllVersions, nameof(deleteAllVersions), required: true);
            return new DeferredBodyAction<DeleteDocumentResponseBody, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/deleteDocument";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["documentId"] = ExpressionConverter.Convert(__workflow_documentId);
                callPayload.Queries["deleteAllVersions"] = ExpressionConverter.Convert(__workflow_deleteAllVersions);
                return new ApiConnectionAction<DeleteDocumentResponseBody>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagework")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> CreateDocumentRelation(Expression<Func<string>> bodyprimaryDocumentId, Expression<Func<string>> bodyrelatedDocumentId)
        {
            var __workflow_bodyprimaryDocumentId = WorkflowExpression.Compile(bodyprimaryDocumentId, nameof(bodyprimaryDocumentId), required: true);
            var __workflow_bodyrelatedDocumentId = WorkflowExpression.Compile(bodyrelatedDocumentId, nameof(bodyrelatedDocumentId), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/createDocumentRelation";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["primaryDocumentId"] = ExpressionConverter.ConvertO(__workflow_bodyprimaryDocumentId);
                bodypropCount++;
                body["relatedDocumentId"] = ExpressionConverter.ConvertO(__workflow_bodyrelatedDocumentId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagework")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> DeleteDocumentRelation(Expression<Func<string>> primaryDocumentId, Expression<Func<string>> relatedDocumentId)
        {
            var __workflow_primaryDocumentId = WorkflowExpression.Compile(primaryDocumentId, nameof(primaryDocumentId), required: true);
            var __workflow_relatedDocumentId = WorkflowExpression.Compile(relatedDocumentId, nameof(relatedDocumentId), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/deleteDocumentRelation";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["primaryDocumentId"] = ExpressionConverter.Convert(__workflow_primaryDocumentId);
                callPayload.Queries["relatedDocumentId"] = ExpressionConverter.Convert(__workflow_relatedDocumentId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }
    }

    public class ImanageworkTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<SingleSelectedDocumentResponse, ApiConnectionTriggerConfiguration> SingleSelectedDocument(Expression<Func<string>> bodyworkflowName, Expression<Func<string>> bodydescription, Expression<Func<string>> bodylibraryId, Expression<Func<string>> bodyformId, Expression<Func<bool>> bodyinferFolderId, Expression<Func<string>> bodyusers = null, Expression<Func<string>> bodygroups = null, Expression<Func<string>> bodyworkspaces = null, Expression<Func<string>> bodyclasses = null, Expression<Func<bool>> bodywaitForCompletion = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyworkflowName = WorkflowExpression.Compile(bodyworkflowName, nameof(bodyworkflowName), required: true);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: true);
            var __workflow_bodylibraryId = WorkflowExpression.Compile(bodylibraryId, nameof(bodylibraryId), required: true);
            var __workflow_bodyformId = WorkflowExpression.Compile(bodyformId, nameof(bodyformId), required: true);
            var __workflow_bodyinferFolderId = WorkflowExpression.Compile(bodyinferFolderId, nameof(bodyinferFolderId), required: true);
            var __workflow_bodyusers = WorkflowExpression.Compile(bodyusers, nameof(bodyusers), required: false);
            var __workflow_bodygroups = WorkflowExpression.Compile(bodygroups, nameof(bodygroups), required: false);
            var __workflow_bodyworkspaces = WorkflowExpression.Compile(bodyworkspaces, nameof(bodyworkspaces), required: false);
            var __workflow_bodyclasses = WorkflowExpression.Compile(bodyclasses, nameof(bodyclasses), required: false);
            var __workflow_bodywaitForCompletion = WorkflowExpression.Compile(bodywaitForCompletion, nameof(bodywaitForCompletion), required: false);
            return new DeferredBodyTrigger<SingleSelectedDocumentResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/hooks/register/singleSelectedDocument";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["workflowName"] = ExpressionConverter.ConvertO(__workflow_bodyworkflowName);
                bodypropCount++;
                body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                bodypropCount++;
                body["libraryId"] = ExpressionConverter.ConvertO(__workflow_bodylibraryId);
                bodypropCount++;
                body["formId"] = ExpressionConverter.ConvertO(__workflow_bodyformId);
                bodypropCount++;
                body["inferFolderId"] = ExpressionConverter.ConvertO(__workflow_bodyinferFolderId);
                if (__workflow_bodyusers != null)
                {
                    body["users"] = ExpressionConverter.ConvertO(__workflow_bodyusers);
                    bodypropCount++;
                }

                if (__workflow_bodygroups != null)
                {
                    body["groups"] = ExpressionConverter.ConvertO(__workflow_bodygroups);
                    bodypropCount++;
                }

                if (__workflow_bodyworkspaces != null)
                {
                    body["workspaces"] = ExpressionConverter.ConvertO(__workflow_bodyworkspaces);
                    bodypropCount++;
                }

                if (__workflow_bodyclasses != null)
                {
                    body["classes"] = ExpressionConverter.ConvertO(__workflow_bodyclasses);
                    bodypropCount++;
                }

                if (__workflow_bodywaitForCompletion != null)
                {
                    if (__workflow_bodywaitForCompletion != null)
                    {
                        body["waitForCompletion"] = ExpressionConverter.ConvertO(__workflow_bodywaitForCompletion);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["waitForCompletion"] = false;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<SingleSelectedDocumentResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<MultipleSelectedDocumentsResponse, ApiConnectionTriggerConfiguration> MultipleSelectedDocuments(Expression<Func<string>> bodyworkflowName, Expression<Func<string>> bodydescription, Expression<Func<string>> bodylibraryId, Expression<Func<string>> bodyformId, Expression<Func<bool>> bodyinferFolderId, Expression<Func<string>> bodyusers = null, Expression<Func<string>> bodygroups = null, Expression<Func<bool>> bodyshowFormPerObject = null, Expression<Func<bool>> bodywaitForCompletion = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyworkflowName = WorkflowExpression.Compile(bodyworkflowName, nameof(bodyworkflowName), required: true);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: true);
            var __workflow_bodylibraryId = WorkflowExpression.Compile(bodylibraryId, nameof(bodylibraryId), required: true);
            var __workflow_bodyformId = WorkflowExpression.Compile(bodyformId, nameof(bodyformId), required: true);
            var __workflow_bodyinferFolderId = WorkflowExpression.Compile(bodyinferFolderId, nameof(bodyinferFolderId), required: true);
            var __workflow_bodyusers = WorkflowExpression.Compile(bodyusers, nameof(bodyusers), required: false);
            var __workflow_bodygroups = WorkflowExpression.Compile(bodygroups, nameof(bodygroups), required: false);
            var __workflow_bodyshowFormPerObject = WorkflowExpression.Compile(bodyshowFormPerObject, nameof(bodyshowFormPerObject), required: false);
            var __workflow_bodywaitForCompletion = WorkflowExpression.Compile(bodywaitForCompletion, nameof(bodywaitForCompletion), required: false);
            return new DeferredBodyTrigger<MultipleSelectedDocumentsResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/hooks/register/multipleSelectedDocuments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["workflowName"] = ExpressionConverter.ConvertO(__workflow_bodyworkflowName);
                bodypropCount++;
                body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                bodypropCount++;
                body["libraryId"] = ExpressionConverter.ConvertO(__workflow_bodylibraryId);
                bodypropCount++;
                body["formId"] = ExpressionConverter.ConvertO(__workflow_bodyformId);
                bodypropCount++;
                body["inferFolderId"] = ExpressionConverter.ConvertO(__workflow_bodyinferFolderId);
                if (__workflow_bodyusers != null)
                {
                    body["users"] = ExpressionConverter.ConvertO(__workflow_bodyusers);
                    bodypropCount++;
                }

                if (__workflow_bodygroups != null)
                {
                    body["groups"] = ExpressionConverter.ConvertO(__workflow_bodygroups);
                    bodypropCount++;
                }

                if (__workflow_bodyshowFormPerObject != null)
                {
                    if (__workflow_bodyshowFormPerObject != null)
                    {
                        body["showFormPerObject"] = ExpressionConverter.ConvertO(__workflow_bodyshowFormPerObject);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["showFormPerObject"] = false;
                    bodypropCount++;
                }

                if (__workflow_bodywaitForCompletion != null)
                {
                    if (__workflow_bodywaitForCompletion != null)
                    {
                        body["waitForCompletion"] = ExpressionConverter.ConvertO(__workflow_bodywaitForCompletion);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["waitForCompletion"] = false;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<MultipleSelectedDocumentsResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<SingleSelectedWorkspaceResponse, ApiConnectionTriggerConfiguration> SingleSelectedWorkspace(Expression<Func<string>> bodyworkflowName, Expression<Func<string>> bodydescription, Expression<Func<string>> bodylibraryId, Expression<Func<string>> bodyformId, Expression<Func<string>> bodyusers = null, Expression<Func<string>> bodygroups = null, Expression<Func<bool>> bodywaitForCompletion = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyworkflowName = WorkflowExpression.Compile(bodyworkflowName, nameof(bodyworkflowName), required: true);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: true);
            var __workflow_bodylibraryId = WorkflowExpression.Compile(bodylibraryId, nameof(bodylibraryId), required: true);
            var __workflow_bodyformId = WorkflowExpression.Compile(bodyformId, nameof(bodyformId), required: true);
            var __workflow_bodyusers = WorkflowExpression.Compile(bodyusers, nameof(bodyusers), required: false);
            var __workflow_bodygroups = WorkflowExpression.Compile(bodygroups, nameof(bodygroups), required: false);
            var __workflow_bodywaitForCompletion = WorkflowExpression.Compile(bodywaitForCompletion, nameof(bodywaitForCompletion), required: false);
            return new DeferredBodyTrigger<SingleSelectedWorkspaceResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/hooks/register/singleSelectedWorkspace";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["workflowName"] = ExpressionConverter.ConvertO(__workflow_bodyworkflowName);
                bodypropCount++;
                body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                bodypropCount++;
                body["libraryId"] = ExpressionConverter.ConvertO(__workflow_bodylibraryId);
                bodypropCount++;
                body["formId"] = ExpressionConverter.ConvertO(__workflow_bodyformId);
                if (__workflow_bodyusers != null)
                {
                    body["users"] = ExpressionConverter.ConvertO(__workflow_bodyusers);
                    bodypropCount++;
                }

                if (__workflow_bodygroups != null)
                {
                    body["groups"] = ExpressionConverter.ConvertO(__workflow_bodygroups);
                    bodypropCount++;
                }

                if (__workflow_bodywaitForCompletion != null)
                {
                    if (__workflow_bodywaitForCompletion != null)
                    {
                        body["waitForCompletion"] = ExpressionConverter.ConvertO(__workflow_bodywaitForCompletion);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["waitForCompletion"] = false;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<SingleSelectedWorkspaceResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<MultipleSelectedWorkspacesResponse, ApiConnectionTriggerConfiguration> MultipleSelectedWorkspaces(Expression<Func<string>> bodyworkflowName, Expression<Func<string>> bodydescription, Expression<Func<string>> bodylibraryId, Expression<Func<string>> bodyformId, Expression<Func<string>> bodyusers = null, Expression<Func<string>> bodygroups = null, Expression<Func<bool>> bodyshowFormPerObject = null, Expression<Func<bool>> bodywaitForCompletion = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyworkflowName = WorkflowExpression.Compile(bodyworkflowName, nameof(bodyworkflowName), required: true);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: true);
            var __workflow_bodylibraryId = WorkflowExpression.Compile(bodylibraryId, nameof(bodylibraryId), required: true);
            var __workflow_bodyformId = WorkflowExpression.Compile(bodyformId, nameof(bodyformId), required: true);
            var __workflow_bodyusers = WorkflowExpression.Compile(bodyusers, nameof(bodyusers), required: false);
            var __workflow_bodygroups = WorkflowExpression.Compile(bodygroups, nameof(bodygroups), required: false);
            var __workflow_bodyshowFormPerObject = WorkflowExpression.Compile(bodyshowFormPerObject, nameof(bodyshowFormPerObject), required: false);
            var __workflow_bodywaitForCompletion = WorkflowExpression.Compile(bodywaitForCompletion, nameof(bodywaitForCompletion), required: false);
            return new DeferredBodyTrigger<MultipleSelectedWorkspacesResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/hooks/register/multipleSelectedWorkspaces";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["workflowName"] = ExpressionConverter.ConvertO(__workflow_bodyworkflowName);
                bodypropCount++;
                body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                bodypropCount++;
                body["libraryId"] = ExpressionConverter.ConvertO(__workflow_bodylibraryId);
                bodypropCount++;
                body["formId"] = ExpressionConverter.ConvertO(__workflow_bodyformId);
                if (__workflow_bodyusers != null)
                {
                    body["users"] = ExpressionConverter.ConvertO(__workflow_bodyusers);
                    bodypropCount++;
                }

                if (__workflow_bodygroups != null)
                {
                    body["groups"] = ExpressionConverter.ConvertO(__workflow_bodygroups);
                    bodypropCount++;
                }

                if (__workflow_bodyshowFormPerObject != null)
                {
                    if (__workflow_bodyshowFormPerObject != null)
                    {
                        body["showFormPerObject"] = ExpressionConverter.ConvertO(__workflow_bodyshowFormPerObject);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["showFormPerObject"] = false;
                    bodypropCount++;
                }

                if (__workflow_bodywaitForCompletion != null)
                {
                    if (__workflow_bodywaitForCompletion != null)
                    {
                        body["waitForCompletion"] = ExpressionConverter.ConvertO(__workflow_bodywaitForCompletion);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["waitForCompletion"] = false;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<MultipleSelectedWorkspacesResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<RegisterGenericWorkflowResponse, ApiConnectionTriggerConfiguration> RegisterGenericWorkflow(Expression<Func<string>> bodyworkflowName, Expression<Func<string>> bodydescription, Expression<Func<string>> bodylibraryId, Expression<Func<string>> bodyformId, Expression<Func<string>> bodyusers = null, Expression<Func<string>> bodygroups = null, Expression<Func<bool>> bodywaitForCompletion = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyworkflowName = WorkflowExpression.Compile(bodyworkflowName, nameof(bodyworkflowName), required: true);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: true);
            var __workflow_bodylibraryId = WorkflowExpression.Compile(bodylibraryId, nameof(bodylibraryId), required: true);
            var __workflow_bodyformId = WorkflowExpression.Compile(bodyformId, nameof(bodyformId), required: true);
            var __workflow_bodyusers = WorkflowExpression.Compile(bodyusers, nameof(bodyusers), required: false);
            var __workflow_bodygroups = WorkflowExpression.Compile(bodygroups, nameof(bodygroups), required: false);
            var __workflow_bodywaitForCompletion = WorkflowExpression.Compile(bodywaitForCompletion, nameof(bodywaitForCompletion), required: false);
            return new DeferredBodyTrigger<RegisterGenericWorkflowResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/hooks/register/genericWorkflow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["workflowName"] = ExpressionConverter.ConvertO(__workflow_bodyworkflowName);
                bodypropCount++;
                body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                bodypropCount++;
                body["libraryId"] = ExpressionConverter.ConvertO(__workflow_bodylibraryId);
                bodypropCount++;
                body["formId"] = ExpressionConverter.ConvertO(__workflow_bodyformId);
                if (__workflow_bodyusers != null)
                {
                    body["users"] = ExpressionConverter.ConvertO(__workflow_bodyusers);
                    bodypropCount++;
                }

                if (__workflow_bodygroups != null)
                {
                    body["groups"] = ExpressionConverter.ConvertO(__workflow_bodygroups);
                    bodypropCount++;
                }

                if (__workflow_bodywaitForCompletion != null)
                {
                    if (__workflow_bodywaitForCompletion != null)
                    {
                        body["waitForCompletion"] = ExpressionConverter.ConvertO(__workflow_bodywaitForCompletion);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["waitForCompletion"] = false;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<RegisterGenericWorkflowResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<RegisterFormWorkflowResponse, ApiConnectionTriggerConfiguration> RegisterFormWorkflow(Expression<Func<string>> bodyworkflowName, Expression<Func<string>> bodydescription, Expression<Func<string>> bodylibraryId, Expression<Func<string>> bodyformId, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyworkflowName = WorkflowExpression.Compile(bodyworkflowName, nameof(bodyworkflowName), required: true);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: true);
            var __workflow_bodylibraryId = WorkflowExpression.Compile(bodylibraryId, nameof(bodylibraryId), required: true);
            var __workflow_bodyformId = WorkflowExpression.Compile(bodyformId, nameof(bodyformId), required: true);
            return new DeferredBodyTrigger<RegisterFormWorkflowResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/hooks/register/formWorkflow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["workflowName"] = ExpressionConverter.ConvertO(__workflow_bodyworkflowName);
                bodypropCount++;
                body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                bodypropCount++;
                body["libraryId"] = ExpressionConverter.ConvertO(__workflow_bodylibraryId);
                bodypropCount++;
                body["formId"] = ExpressionConverter.ConvertO(__workflow_bodyformId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<RegisterFormWorkflowResponse>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class GetTrusteesResponse
    {
        [JsonProperty("data")]
        public GetTrusteesResponseDataTypeItem[] Data { get; set; }
    }

    public class GetTrusteesResponseDataTypeItem
    {
        [JsonProperty("full_name")]
        public string FullName { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("ssid")]
        public string Ssid { get; set; }

        [JsonProperty("type")]
        public GetTrusteesResponseDataTypeItemTypeType Type { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetTrusteesResponseDataTypeItemTypeType
    {
        [EnumMember(Value = "user")]
        User,
        [EnumMember(Value = "group")]
        Group
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyobjectTypeInput
    {
        [EnumMember(Value = "document")]
        Document,
        [EnumMember(Value = "folder")]
        Folder,
        [EnumMember(Value = "workspace")]
        Workspace
    }

    public class UpdateDefaultSecurityResponse
    {
        [JsonProperty("data")]
        public UpdateDefaultSecurityResponseDataType Data { get; set; }
    }

    public class UpdateDefaultSecurityResponseDataType
    {
        [JsonProperty("default_security")]
        public UpdateDefaultSecurityResponseDataTypeDefaultSecurityType DefaultSecurity { get; set; }

        [JsonProperty("acl")]
        public AccessPermissionsItem[] Acl { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateDefaultSecurityResponseDataTypeDefaultSecurityType
    {
        [EnumMember(Value = "inherit")]
        Inherit,
        [EnumMember(Value = "public")]
        Public,
        [EnumMember(Value = "view")]
        View,
        [EnumMember(Value = "private")]
        Private
    }

    public class AccessPermissionsItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("sid")]
        public string Sid { get; set; }

        [JsonProperty("type")]
        public AccessPermissionsItemTypeType Type { get; set; }

        [JsonProperty("access_level")]
        public AccessPermissionsItemAccessLevelType AccessLevel { get; set; }

        [JsonProperty("access_level_display_name")]
        public AccessPermissionsItemAccessLevelDisplayNameType AccessLevelDisplayName { get; set; }

        [JsonProperty("access")]
        public int Access { get; set; }

        [JsonProperty("is_external")]
        public bool IsExternal { get; set; }

        [JsonProperty("allow_logon")]
        public bool AllowLogon { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("has_restricted_member")]
        public bool HasRestrictedMember { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AccessPermissionsItemTypeType
    {
        [EnumMember(Value = "user")]
        User,
        [EnumMember(Value = "group")]
        Group
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AccessPermissionsItemAccessLevelType
    {
        [EnumMember(Value = "no_access")]
        NoAccess,
        [EnumMember(Value = "read")]
        Read,
        [EnumMember(Value = "read_write")]
        ReadWrite,
        [EnumMember(Value = "full_access")]
        FullAccess,
        [EnumMember(Value = "change_security")]
        ChangeSecurity
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AccessPermissionsItemAccessLevelDisplayNameType
    {
        [EnumMember(Value = "No Access")]
        NoAccess,
        [EnumMember(Value = "Read Only")]
        ReadOnly,
        [EnumMember(Value = "Read/Write")]
        ReadWrite,
        [EnumMember(Value = "Full Access")]
        FullAccess,
        [EnumMember(Value = "Change Security")]
        ChangeSecurity
    }

    public class UpdatePermissionsResponse
    {
        [JsonProperty("data")]
        public UpdatePermissionsResponseDataType Data { get; set; }
    }

    public class UpdatePermissionsResponseDataType
    {
        [JsonProperty("default_security")]
        public UpdatePermissionsResponseDataTypeDefaultSecurityType DefaultSecurity { get; set; }

        [JsonProperty("acl")]
        public AccessPermissionsItem2[] Acl { get; set; }

        [JsonProperty("all_user_ids")]
        public string AllUserIds { get; set; }

        [JsonProperty("all_group_ids")]
        public string AllGroupIds { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdatePermissionsResponseDataTypeDefaultSecurityType
    {
        [EnumMember(Value = "inherit")]
        Inherit,
        [EnumMember(Value = "public")]
        Public,
        [EnumMember(Value = "view")]
        View,
        [EnumMember(Value = "private")]
        Private
    }

    public class AccessPermissionsItem2
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("sid")]
        public string Sid { get; set; }

        [JsonProperty("type")]
        public AccessPermissionsItemTypeType Type { get; set; }

        [JsonProperty("access_level")]
        public AccessPermissionsItemAccessLevelType AccessLevel { get; set; }

        [JsonProperty("access_level_display_name")]
        public AccessPermissionsItemAccessLevelDisplayNameType AccessLevelDisplayName { get; set; }

        [JsonProperty("access")]
        public int Access { get; set; }

        [JsonProperty("is_external")]
        public bool IsExternal { get; set; }

        [JsonProperty("allow_logon")]
        public bool AllowLogon { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("has_restricted_member")]
        public bool HasRestrictedMember { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyaccessLevelInput
    {
        [EnumMember(Value = "No Access")]
        NoAccess,
        [EnumMember(Value = "Read Only")]
        ReadOnly,
        [EnumMember(Value = "Read/Write")]
        ReadWrite,
        [EnumMember(Value = "Full Access")]
        FullAccess,
        Remove
    }

    public class GetPermissionsResponse
    {
        [JsonProperty("data")]
        public GetPermissionsResponseDataType Data { get; set; }
    }

    public class GetPermissionsResponseDataType
    {
        [JsonProperty("default_security")]
        public GetPermissionsResponseDataTypeDefaultSecurityType DefaultSecurity { get; set; }

        [JsonProperty("inherited_default_security")]
        public GetPermissionsResponseDataTypeInheritedDefaultSecurityType InheritedDefaultSecurity { get; set; }

        [JsonProperty("acl")]
        public AccessPermissionsItem22[] Acl { get; set; }

        [JsonProperty("all_user_ids")]
        public string AllUserIds { get; set; }

        [JsonProperty("all_group_ids")]
        public string AllGroupIds { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetPermissionsResponseDataTypeDefaultSecurityType
    {
        [EnumMember(Value = "inherit")]
        Inherit,
        [EnumMember(Value = "public")]
        Public,
        [EnumMember(Value = "view")]
        View,
        [EnumMember(Value = "private")]
        Private
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetPermissionsResponseDataTypeInheritedDefaultSecurityType
    {
        [EnumMember(Value = "public")]
        Public,
        [EnumMember(Value = "view")]
        View,
        [EnumMember(Value = "private")]
        Private
    }

    public class AccessPermissionsItem22
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("sid")]
        public string Sid { get; set; }

        [JsonProperty("type")]
        public AccessPermissionsItemTypeType Type { get; set; }

        [JsonProperty("access_level")]
        public AccessPermissionsItemAccessLevelType AccessLevel { get; set; }

        [JsonProperty("access_level_display_name")]
        public AccessPermissionsItemAccessLevelDisplayNameType AccessLevelDisplayName { get; set; }

        [JsonProperty("access")]
        public int Access { get; set; }

        [JsonProperty("is_external")]
        public bool IsExternal { get; set; }

        [JsonProperty("allow_logon")]
        public bool AllowLogon { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("has_restricted_member")]
        public bool HasRestrictedMember { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodysourceObjectTypeInput
    {
        [EnumMember(Value = "document")]
        Document,
        [EnumMember(Value = "folder")]
        Folder,
        [EnumMember(Value = "workspace")]
        Workspace
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodytargetObjectTypeInput
    {
        [EnumMember(Value = "document")]
        Document,
        [EnumMember(Value = "folder")]
        Folder,
        [EnumMember(Value = "workspace")]
        Workspace
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodycopyTypeInput
    {
        Overwrite,
        [EnumMember(Value = "Merge (Pessimistic)")]
        MergePessimistic,
        [EnumMember(Value = "Merge (Optimistic)")]
        MergeOptimistic
    }

    public class WorkspaceProfileResponseBody
    {
        [JsonProperty("data")]
        public WorkspaceProfile Data { get; set; }
    }

    public class WorkspaceProfile
    {
        [JsonProperty("basic_properties")]
        public string BasicProperties { get; set; }

        [JsonProperty("create_date")]
        public string CreateDate { get; set; }

        [JsonProperty("database")]
        public string Database { get; set; }

        [JsonProperty("default_security")]
        public WorkspaceProfileDefaultSecurityType DefaultSecurity { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("document_number")]
        public int DocumentNumber { get; set; }

        [JsonProperty("edit_date")]
        public string EditDate { get; set; }

        [JsonProperty("effective_security")]
        public WorkspaceProfileEffectiveSecurityType EffectiveSecurity { get; set; }

        [JsonProperty("has_subfolders")]
        public bool HasSubfolders { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("is_external")]
        public bool IsExternal { get; set; }

        [JsonProperty("is_external_as_normal")]
        public bool IsExternalAsNormal { get; set; }

        [JsonProperty("is_hipaa")]
        public bool IsHipaa { get; set; }

        [JsonProperty("iwl")]
        public string Iwl { get; set; }

        [JsonProperty("last_user")]
        public string LastUser { get; set; }

        [JsonProperty("last_user_description")]
        public string LastUserDescription { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("owner_description")]
        public string OwnerDescription { get; set; }

        [JsonProperty("project_custom1")]
        public string ProjectCustom1 { get; set; }

        [JsonProperty("project_custom2")]
        public string ProjectCustom2 { get; set; }

        [JsonProperty("project_custom3")]
        public string ProjectCustom3 { get; set; }

        [JsonProperty("retain_days")]
        public int RetainDays { get; set; }

        [JsonProperty("subclass")]
        public string Subclass { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("wstype")]
        public WorkspaceProfileWstypeType Wstype { get; set; }

        [JsonProperty("workspace_url")]
        public string WorkspaceUrl { get; set; }

        [JsonProperty("custom1")]
        public string Custom1 { get; set; }

        [JsonProperty("custom1_description")]
        public string Custom1Description { get; set; }

        [JsonProperty("custom2")]
        public string Custom2 { get; set; }

        [JsonProperty("custom2_description")]
        public string Custom2Description { get; set; }

        [JsonProperty("custom3")]
        public string Custom3 { get; set; }

        [JsonProperty("custom3_description")]
        public string Custom3Description { get; set; }

        [JsonProperty("custom4")]
        public string Custom4 { get; set; }

        [JsonProperty("custom4_description")]
        public string Custom4Description { get; set; }

        [JsonProperty("custom5")]
        public string Custom5 { get; set; }

        [JsonProperty("custom5_description")]
        public string Custom5Description { get; set; }

        [JsonProperty("custom6")]
        public string Custom6 { get; set; }

        [JsonProperty("custom6_description")]
        public string Custom6Description { get; set; }

        [JsonProperty("custom7")]
        public string Custom7 { get; set; }

        [JsonProperty("custom7_description")]
        public string Custom7Description { get; set; }

        [JsonProperty("custom8")]
        public string Custom8 { get; set; }

        [JsonProperty("custom8_description")]
        public string Custom8Description { get; set; }

        [JsonProperty("custom9")]
        public string Custom9 { get; set; }

        [JsonProperty("custom9_description")]
        public string Custom9Description { get; set; }

        [JsonProperty("custom10")]
        public string Custom10 { get; set; }

        [JsonProperty("custom10_description")]
        public string Custom10Description { get; set; }

        [JsonProperty("custom11")]
        public string Custom11 { get; set; }

        [JsonProperty("custom11_description")]
        public string Custom11Description { get; set; }

        [JsonProperty("custom12")]
        public string Custom12 { get; set; }

        [JsonProperty("custom12_description")]
        public string Custom12Description { get; set; }

        [JsonProperty("custom13")]
        public string Custom13 { get; set; }

        [JsonProperty("custom14")]
        public string Custom14 { get; set; }

        [JsonProperty("custom15")]
        public string Custom15 { get; set; }

        [JsonProperty("custom16")]
        public string Custom16 { get; set; }

        [JsonProperty("custom17")]
        public double Custom17 { get; set; }

        [JsonProperty("custom18")]
        public double Custom18 { get; set; }

        [JsonProperty("custom19")]
        public double Custom19 { get; set; }

        [JsonProperty("custom20")]
        public double Custom20 { get; set; }

        [JsonProperty("custom21")]
        public string Custom21 { get; set; }

        [JsonProperty("custom22")]
        public string Custom22 { get; set; }

        [JsonProperty("custom23")]
        public string Custom23 { get; set; }

        [JsonProperty("custom24")]
        public string Custom24 { get; set; }

        [JsonProperty("custom25")]
        public bool Custom25 { get; set; }

        [JsonProperty("custom26")]
        public bool Custom26 { get; set; }

        [JsonProperty("custom27")]
        public bool Custom27 { get; set; }

        [JsonProperty("custom28")]
        public bool Custom28 { get; set; }

        [JsonProperty("custom29")]
        public string Custom29 { get; set; }

        [JsonProperty("custom29_description")]
        public string Custom29Description { get; set; }

        [JsonProperty("custom30")]
        public string Custom30 { get; set; }

        [JsonProperty("custom30_description")]
        public string Custom30Description { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum WorkspaceProfileDefaultSecurityType
    {
        [EnumMember(Value = "inherit")]
        Inherit,
        [EnumMember(Value = "private")]
        Private,
        [EnumMember(Value = "view")]
        View,
        [EnumMember(Value = "public")]
        Public
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum WorkspaceProfileEffectiveSecurityType
    {
        [EnumMember(Value = "no_access")]
        NoAccess,
        [EnumMember(Value = "read")]
        Read,
        [EnumMember(Value = "read_write")]
        ReadWrite,
        [EnumMember(Value = "full_access")]
        FullAccess
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum WorkspaceProfileWstypeType
    {
        [EnumMember(Value = "document")]
        Document,
        [EnumMember(Value = "folder")]
        Folder,
        [EnumMember(Value = "workspace")]
        Workspace,
        [EnumMember(Value = "email")]
        Email,
        [EnumMember(Value = "document_shortcut")]
        DocumentShortcut,
        [EnumMember(Value = "folder_shortcut")]
        FolderShortcut,
        [EnumMember(Value = "workspace_shortcut")]
        WorkspaceShortcut,
        [EnumMember(Value = "user")]
        User
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodycreateChildrenInput
    {
        [EnumMember(Value = "All Folders")]
        AllFolders,
        [EnumMember(Value = "Only Required Folders")]
        OnlyRequiredFolders
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodydefaultSecurityInput
    {
        [EnumMember(Value = "private")]
        Private,
        [EnumMember(Value = "view")]
        View,
        [EnumMember(Value = "public")]
        Public
    }

    public class GetClassesResponse
    {
        [JsonProperty("data")]
        public GetClassesResponseDataType Data { get; set; }
    }

    public class GetClassesResponseDataType
    {
        [JsonProperty("topMatchingId")]
        public string TopMatchingId { get; set; }

        [JsonProperty("topMatchingDescription")]
        public string TopMatchingDescription { get; set; }

        [JsonProperty("results")]
        public GetClassesResponseDataTypeResultsTypeItem[] Results { get; set; }
    }

    public class GetClassesResponseDataTypeResultsTypeItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("hipaa")]
        public bool Hipaa { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("indexable")]
        public bool Indexable { get; set; }

        [JsonProperty("default_security")]
        public GetClassesResponseDataTypeResultsTypeItemDefaultSecurityType DefaultSecurity { get; set; }

        [JsonProperty("retain")]
        public int Retain { get; set; }

        [JsonProperty("required_fields")]
        public string[] RequiredFields { get; set; }

        [JsonProperty("shadow")]
        public bool Shadow { get; set; }

        [JsonProperty("subclass_required")]
        public bool SubclassRequired { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetClassesResponseDataTypeResultsTypeItemDefaultSecurityType
    {
        [EnumMember(Value = "private")]
        Private,
        [EnumMember(Value = "view")]
        View,
        [EnumMember(Value = "public")]
        Public
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum defaultSecurityInput
    {
        [EnumMember(Value = "private")]
        Private,
        [EnumMember(Value = "view")]
        View,
        [EnumMember(Value = "public")]
        Public
    }

    public class GetSubclassesResponse
    {
        [JsonProperty("data")]
        public GetSubclassesResponseDataType Data { get; set; }
    }

    public class GetSubclassesResponseDataType
    {
        [JsonProperty("topMatchingId")]
        public string TopMatchingId { get; set; }

        [JsonProperty("topMatchingDescription")]
        public string TopMatchingDescription { get; set; }

        [JsonProperty("results")]
        public GetSubclassesResponseDataTypeResultsTypeItem[] Results { get; set; }
    }

    public class GetSubclassesResponseDataTypeResultsTypeItem
    {
        [JsonProperty("default_security")]
        public GetSubclassesResponseDataTypeResultsTypeItemDefaultSecurityType DefaultSecurity { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("hipaa")]
        public bool Hipaa { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("parent")]
        public GetSubclassesResponseDataTypeResultsTypeItemParentType Parent { get; set; }

        [JsonProperty("required_fields")]
        public string[] RequiredFields { get; set; }

        [JsonProperty("retain")]
        public int Retain { get; set; }

        [JsonProperty("shadow")]
        public bool Shadow { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetSubclassesResponseDataTypeResultsTypeItemDefaultSecurityType
    {
        [EnumMember(Value = "private")]
        Private,
        [EnumMember(Value = "view")]
        View,
        [EnumMember(Value = "public")]
        Public
    }

    public class GetSubclassesResponseDataTypeResultsTypeItemParentType
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class WorkspaceTemplatesResponseBody
    {
        [JsonProperty("data")]
        public WorkspaceTemplatesResponseBodyDataType Data { get; set; }
    }

    public class WorkspaceTemplatesResponseBodyDataType
    {
        [JsonProperty("topMatchingId")]
        public string TopMatchingId { get; set; }

        [JsonProperty("topMatchingName")]
        public string TopMatchingName { get; set; }

        [JsonProperty("results")]
        public WorkspaceTemplate[] Results { get; set; }
    }

    public class WorkspaceTemplate
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class SearchFoldersResponseBody
    {
        [JsonProperty("data")]
        public SearchFoldersResponseBodyDataType Data { get; set; }
    }

    public class SearchFoldersResponseBodyDataType
    {
        [JsonProperty("topMatchingId")]
        public string TopMatchingId { get; set; }

        [JsonProperty("topMatchingName")]
        public string TopMatchingName { get; set; }

        [JsonProperty("results")]
        public SearchFolderResult[] Results { get; set; }
    }

    public class SearchFolderResult
    {
        [JsonProperty("database")]
        public string Database { get; set; }

        [JsonProperty("default_security")]
        public SearchFolderResultDefaultSecurityType DefaultSecurity { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("edit_date")]
        public string EditDate { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("folder_type")]
        public SearchFolderResultFolderTypeType FolderType { get; set; }

        [JsonProperty("folder_url")]
        public string FolderUrl { get; set; }

        [JsonProperty("has_documents")]
        public bool HasDocuments { get; set; }

        [JsonProperty("has_subfolders")]
        public bool HasSubfolders { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("is_container_saved_search")]
        public bool IsContainerSavedSearch { get; set; }

        [JsonProperty("is_content_saved_search")]
        public bool IsContentSavedSearch { get; set; }

        [JsonProperty("is_external")]
        public bool IsExternal { get; set; }

        [JsonProperty("is_external_as_normal")]
        public bool IsExternalAsNormal { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("owner_description")]
        public string OwnerDescription { get; set; }

        [JsonProperty("parent_id")]
        public string ParentId { get; set; }

        [JsonProperty("view_type")]
        public SearchFolderResultViewTypeType ViewType { get; set; }

        [JsonProperty("workspace_id")]
        public string WorkspaceId { get; set; }

        [JsonProperty("workspace_name")]
        public string WorkspaceName { get; set; }

        [JsonProperty("wstype")]
        public SearchFolderResultWstypeType Wstype { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SearchFolderResultDefaultSecurityType
    {
        [EnumMember(Value = "inherit")]
        Inherit,
        [EnumMember(Value = "private")]
        Private,
        [EnumMember(Value = "view")]
        View,
        [EnumMember(Value = "public")]
        Public
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SearchFolderResultFolderTypeType
    {
        [EnumMember(Value = "regular")]
        Regular,
        [EnumMember(Value = "search")]
        Search,
        [EnumMember(Value = "tab")]
        Tab,
        [EnumMember(Value = "category")]
        Category,
        [EnumMember(Value = "my_matters")]
        MyMatters,
        [EnumMember(Value = "my_favorites")]
        MyFavorites
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SearchFolderResultViewTypeType
    {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "document")]
        Document,
        [EnumMember(Value = "email")]
        Email,
        [EnumMember(Value = "email_search")]
        EmailSearch,
        [EnumMember(Value = "document_search")]
        DocumentSearch,
        [EnumMember(Value = "linksite")]
        Linksite,
        [EnumMember(Value = "imanage_share")]
        ImanageShare
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SearchFolderResultWstypeType
    {
        [EnumMember(Value = "folder")]
        Folder,
        [EnumMember(Value = "workspace")]
        Workspace,
        [EnumMember(Value = "folder_shortcut")]
        FolderShortcut,
        [EnumMember(Value = "workspace_shortcut")]
        WorkspaceShortcut
    }

    public class GetUserDetailsResponse
    {
        [JsonProperty("data")]
        public UserProfile Data { get; set; }
    }

    public class UserProfile
    {
        [JsonProperty("allow_logon")]
        public bool AllowLogon { get; set; }

        [JsonProperty("custom1")]
        public string Custom1 { get; set; }

        [JsonProperty("custom2")]
        public string Custom2 { get; set; }

        [JsonProperty("custom3")]
        public string Custom3 { get; set; }

        [JsonProperty("directory_id")]
        public string DirectoryId { get; set; }

        [JsonProperty("distinguished_name")]
        public string DistinguishedName { get; set; }

        [JsonProperty("edit_date")]
        public string EditDate { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("exch_autodiscover")]
        public string ExchAutodiscover { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("failed_logins")]
        public int FailedLogins { get; set; }

        [JsonProperty("fax")]
        public string Fax { get; set; }

        [JsonProperty("force_password_change")]
        public bool ForcePasswordChange { get; set; }

        [JsonProperty("full_name")]
        public string FullName { get; set; }

        [JsonProperty("general")]
        public string General { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("is_external")]
        public bool IsExternal { get; set; }

        [JsonProperty("last_sync_ts")]
        public string LastSyncTs { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("password_never_expire")]
        public bool PasswordNeverExpire { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("preferred_library")]
        public string PreferredLibrary { get; set; }

        [JsonProperty("pwd_changed_ts")]
        public string PwdChangedTs { get; set; }

        [JsonProperty("ssid")]
        public string Ssid { get; set; }

        [JsonProperty("user_domain")]
        public string UserDomain { get; set; }

        [JsonProperty("user_id_ex")]
        public string UserIdEx { get; set; }

        [JsonProperty("user_nos")]
        public int UserNos { get; set; }

        [JsonProperty("user_num")]
        public int UserNum { get; set; }
    }

    public class GetContainerChildrenResponse
    {
        [JsonProperty("data")]
        public GetContainerChildrenResponseDataType Data { get; set; }
    }

    public class GetContainerChildrenResponseDataType
    {
        [JsonProperty("total_count")]
        public int TotalCount { get; set; }

        [JsonProperty("cursor")]
        public string Cursor { get; set; }

        [JsonProperty("overflow")]
        public bool Overflow { get; set; }

        [JsonProperty("children")]
        public GetContainerChildrenResponseDataTypeChildrenTypeItem[] Children { get; set; }
    }

    public class GetContainerChildrenResponseDataTypeChildrenTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("wstype")]
        public string Wstype { get; set; }

        [JsonProperty("class")]
        public string Class { get; set; }

        [JsonProperty("subclass")]
        public string Subclass { get; set; }
    }

    public class GetContainerProfileResponseBody
    {
        [JsonProperty("data")]
        public ContainerProfile Data { get; set; }
    }

    public class ContainerProfile
    {
        [JsonProperty("basic_properties")]
        public string BasicProperties { get; set; }

        [JsonProperty("container_type")]
        public ContainerProfileContainerTypeType ContainerType { get; set; }

        [JsonProperty("container_url")]
        public string ContainerUrl { get; set; }

        [JsonProperty("custom1")]
        public string Custom1 { get; set; }

        [JsonProperty("custom1_description")]
        public string Custom1Description { get; set; }

        [JsonProperty("custom2")]
        public string Custom2 { get; set; }

        [JsonProperty("custom2_description")]
        public string Custom2Description { get; set; }

        [JsonProperty("custom3")]
        public string Custom3 { get; set; }

        [JsonProperty("custom3_description")]
        public string Custom3Description { get; set; }

        [JsonProperty("custom4")]
        public string Custom4 { get; set; }

        [JsonProperty("custom4_description")]
        public string Custom4Description { get; set; }

        [JsonProperty("custom5")]
        public string Custom5 { get; set; }

        [JsonProperty("custom5_description")]
        public string Custom5Description { get; set; }

        [JsonProperty("custom6")]
        public string Custom6 { get; set; }

        [JsonProperty("custom6_description")]
        public string Custom6Description { get; set; }

        [JsonProperty("custom7")]
        public string Custom7 { get; set; }

        [JsonProperty("custom7_description")]
        public string Custom7Description { get; set; }

        [JsonProperty("custom8")]
        public string Custom8 { get; set; }

        [JsonProperty("custom8_description")]
        public string Custom8Description { get; set; }

        [JsonProperty("custom9")]
        public string Custom9 { get; set; }

        [JsonProperty("custom9_description")]
        public string Custom9Description { get; set; }

        [JsonProperty("custom10")]
        public string Custom10 { get; set; }

        [JsonProperty("custom10_description")]
        public string Custom10Description { get; set; }

        [JsonProperty("custom11")]
        public string Custom11 { get; set; }

        [JsonProperty("custom11_description")]
        public string Custom11Description { get; set; }

        [JsonProperty("custom12")]
        public string Custom12 { get; set; }

        [JsonProperty("custom12_description")]
        public string Custom12Description { get; set; }

        [JsonProperty("custom13")]
        public string Custom13 { get; set; }

        [JsonProperty("custom14")]
        public string Custom14 { get; set; }

        [JsonProperty("custom15")]
        public string Custom15 { get; set; }

        [JsonProperty("custom16")]
        public string Custom16 { get; set; }

        [JsonProperty("custom17")]
        public double Custom17 { get; set; }

        [JsonProperty("custom18")]
        public double Custom18 { get; set; }

        [JsonProperty("custom19")]
        public double Custom19 { get; set; }

        [JsonProperty("custom20")]
        public double Custom20 { get; set; }

        [JsonProperty("custom21")]
        public string Custom21 { get; set; }

        [JsonProperty("custom22")]
        public string Custom22 { get; set; }

        [JsonProperty("custom23")]
        public string Custom23 { get; set; }

        [JsonProperty("custom24")]
        public string Custom24 { get; set; }

        [JsonProperty("custom25")]
        public bool Custom25 { get; set; }

        [JsonProperty("custom26")]
        public bool Custom26 { get; set; }

        [JsonProperty("custom27")]
        public bool Custom27 { get; set; }

        [JsonProperty("custom28")]
        public bool Custom28 { get; set; }

        [JsonProperty("custom29")]
        public string Custom29 { get; set; }

        [JsonProperty("custom29_description")]
        public string Custom29Description { get; set; }

        [JsonProperty("custom30")]
        public string Custom30 { get; set; }

        [JsonProperty("custom30_description")]
        public string Custom30Description { get; set; }

        [JsonProperty("database")]
        public string Database { get; set; }

        [JsonProperty("default_security")]
        public ContainerProfileDefaultSecurityType DefaultSecurity { get; set; }

        [JsonProperty("edit_date")]
        public string EditDate { get; set; }

        [JsonProperty("has_subfolders")]
        public bool HasSubfolders { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ContainerProfileContainerTypeType
    {
        [EnumMember(Value = "workspace")]
        Workspace,
        [EnumMember(Value = "workspace_shortcut")]
        WorkspaceShortcut,
        [EnumMember(Value = "regular_folder")]
        RegularFolder,
        [EnumMember(Value = "folder_shortcut")]
        FolderShortcut,
        [EnumMember(Value = "search_folder")]
        SearchFolder,
        [EnumMember(Value = "tab")]
        Tab,
        [EnumMember(Value = "category")]
        Category,
        [EnumMember(Value = "my_matters")]
        MyMatters,
        [EnumMember(Value = "my_favorites")]
        MyFavorites
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ContainerProfileDefaultSecurityType
    {
        [EnumMember(Value = "inherit")]
        Inherit,
        [EnumMember(Value = "private")]
        Private,
        [EnumMember(Value = "view")]
        View,
        [EnumMember(Value = "public")]
        Public
    }

    public class GetLibrariesResponse
    {
        [JsonProperty("data")]
        public GetLibrariesResponseDataTypeItem[] Data { get; set; }
    }

    public class GetLibrariesResponseDataTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("type")]
        public GetLibrariesResponseDataTypeItemTypeType Type { get; set; }

        [JsonProperty("is_hidden")]
        public bool IsHidden { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetLibrariesResponseDataTypeItemTypeType
    {
        [EnumMember(Value = "worksite")]
        Worksite,
        [EnumMember(Value = "linksite")]
        Linksite
    }

    public class FullDocumentProfileResponseBody
    {
        [JsonProperty("data")]
        public FullDocumentProfile Data { get; set; }
    }

    public class FullDocumentProfile
    {
        [JsonProperty("access")]
        public FullDocumentProfileAccessType Access { get; set; }

        [JsonProperty("alias")]
        public string Alias { get; set; }

        [JsonProperty("arch_req")]
        public string ArchReq { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("author_description")]
        public string AuthorDescription { get; set; }

        [JsonProperty("author_info")]
        public UserInfo AuthorInfo { get; set; }

        [JsonProperty("bcc")]
        public string Bcc { get; set; }

        [JsonProperty("cc")]
        public string Cc { get; set; }

        [JsonProperty("class")]
        public string Class { get; set; }

        [JsonProperty("class_description")]
        public string ClassDescription { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("content_type")]
        public string ContentType { get; set; }

        [JsonProperty("create_date")]
        public string CreateDate { get; set; }

        [JsonProperty("database")]
        public string Database { get; set; }

        [JsonProperty("declared_date")]
        public string DeclaredDate { get; set; }

        [JsonProperty("default_security")]
        public FullDocumentProfileDefaultSecurityType DefaultSecurity { get; set; }

        [JsonProperty("document_number")]
        public int DocumentNumber { get; set; }

        [JsonProperty("document_url")]
        public string DocumentUrl { get; set; }

        [JsonProperty("edit_date")]
        public string EditDate { get; set; }

        [JsonProperty("edit_profile_date")]
        public string EditProfileDate { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("file_create_date")]
        public string FileCreateDate { get; set; }

        [JsonProperty("file_edit_date")]
        public string FileEditDate { get; set; }

        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("full_file_name")]
        public string FullFileName { get; set; }

        [JsonProperty("has_attachment")]
        public bool HasAttachment { get; set; }

        [JsonProperty("basic_properties")]
        public string BasicProperties { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("indexable")]
        public bool Indexable { get; set; }

        [JsonProperty("in_use_by")]
        public string InUseBy { get; set; }

        [JsonProperty("in_use_by_description")]
        public string InUseByDescription { get; set; }

        [JsonProperty("is_archived")]
        public bool IsArchived { get; set; }

        [JsonProperty("is_checked_out")]
        public bool IsCheckedOut { get; set; }

        [JsonProperty("is_declared")]
        public bool IsDeclared { get; set; }

        [JsonProperty("is_external")]
        public bool IsExternal { get; set; }

        [JsonProperty("is_external_as_normal")]
        public bool IsExternalAsNormal { get; set; }

        [JsonProperty("is_hipaa")]
        public bool IsHipaa { get; set; }

        [JsonProperty("is_in_use")]
        public bool IsInUse { get; set; }

        [JsonProperty("is_latest")]
        public bool IsLatest { get; set; }

        [JsonProperty("is_related")]
        public bool IsRelated { get; set; }

        [JsonProperty("is_restorable")]
        public bool IsRestorable { get; set; }

        [JsonProperty("iwl")]
        public string Iwl { get; set; }

        [JsonProperty("last_user")]
        public string LastUser { get; set; }

        [JsonProperty("last_user_description")]
        public string LastUserDescription { get; set; }

        [JsonProperty("last_user_info")]
        public UserInfo LastUserInfo { get; set; }

        [JsonProperty("latest")]
        public string Latest { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("operator")]
        public string Operator { get; set; }

        [JsonProperty("operator_description")]
        public string OperatorDescription { get; set; }

        [JsonProperty("operator_info")]
        public UserInfo OperatorInfo { get; set; }

        [JsonProperty("received_date")]
        public string ReceivedDate { get; set; }

        [JsonProperty("retain_days")]
        public int RetainDays { get; set; }

        [JsonProperty("sent_date")]
        public string SentDate { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("subclass")]
        public string Subclass { get; set; }

        [JsonProperty("subclass_description")]
        public string SubclassDescription { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("type_description")]
        public string TypeDescription { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("workspace_id")]
        public string WorkspaceId { get; set; }

        [JsonProperty("workspace_name")]
        public string WorkspaceName { get; set; }

        [JsonProperty("wstype")]
        public FullDocumentProfileWstypeType Wstype { get; set; }

        [JsonProperty("custom1")]
        public string Custom1 { get; set; }

        [JsonProperty("custom1_description")]
        public string Custom1Description { get; set; }

        [JsonProperty("custom2")]
        public string Custom2 { get; set; }

        [JsonProperty("custom2_description")]
        public string Custom2Description { get; set; }

        [JsonProperty("custom3")]
        public string Custom3 { get; set; }

        [JsonProperty("custom3_description")]
        public string Custom3Description { get; set; }

        [JsonProperty("custom4")]
        public string Custom4 { get; set; }

        [JsonProperty("custom4_description")]
        public string Custom4Description { get; set; }

        [JsonProperty("custom5")]
        public string Custom5 { get; set; }

        [JsonProperty("custom5_description")]
        public string Custom5Description { get; set; }

        [JsonProperty("custom6")]
        public string Custom6 { get; set; }

        [JsonProperty("custom6_description")]
        public string Custom6Description { get; set; }

        [JsonProperty("custom7")]
        public string Custom7 { get; set; }

        [JsonProperty("custom7_description")]
        public string Custom7Description { get; set; }

        [JsonProperty("custom8")]
        public string Custom8 { get; set; }

        [JsonProperty("custom8_description")]
        public string Custom8Description { get; set; }

        [JsonProperty("custom9")]
        public string Custom9 { get; set; }

        [JsonProperty("custom9_description")]
        public string Custom9Description { get; set; }

        [JsonProperty("custom10")]
        public string Custom10 { get; set; }

        [JsonProperty("custom10_description")]
        public string Custom10Description { get; set; }

        [JsonProperty("custom11")]
        public string Custom11 { get; set; }

        [JsonProperty("custom11_description")]
        public string Custom11Description { get; set; }

        [JsonProperty("custom12")]
        public string Custom12 { get; set; }

        [JsonProperty("custom12_description")]
        public string Custom12Description { get; set; }

        [JsonProperty("custom13")]
        public string Custom13 { get; set; }

        [JsonProperty("custom14")]
        public string Custom14 { get; set; }

        [JsonProperty("custom15")]
        public string Custom15 { get; set; }

        [JsonProperty("custom16")]
        public string Custom16 { get; set; }

        [JsonProperty("custom17")]
        public double Custom17 { get; set; }

        [JsonProperty("custom18")]
        public double Custom18 { get; set; }

        [JsonProperty("custom19")]
        public double Custom19 { get; set; }

        [JsonProperty("custom20")]
        public double Custom20 { get; set; }

        [JsonProperty("custom21")]
        public string Custom21 { get; set; }

        [JsonProperty("custom22")]
        public string Custom22 { get; set; }

        [JsonProperty("custom23")]
        public string Custom23 { get; set; }

        [JsonProperty("custom24")]
        public string Custom24 { get; set; }

        [JsonProperty("custom25")]
        public bool Custom25 { get; set; }

        [JsonProperty("custom26")]
        public bool Custom26 { get; set; }

        [JsonProperty("custom27")]
        public bool Custom27 { get; set; }

        [JsonProperty("custom28")]
        public bool Custom28 { get; set; }

        [JsonProperty("custom29")]
        public string Custom29 { get; set; }

        [JsonProperty("custom29_description")]
        public string Custom29Description { get; set; }

        [JsonProperty("custom30")]
        public string Custom30 { get; set; }

        [JsonProperty("custom30_description")]
        public string Custom30Description { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum FullDocumentProfileAccessType
    {
        [EnumMember(Value = "no_access")]
        NoAccess,
        [EnumMember(Value = "read")]
        Read,
        [EnumMember(Value = "read_write")]
        ReadWrite,
        [EnumMember(Value = "full_access")]
        FullAccess
    }

    public class UserInfo
    {
        [JsonProperty("is_external")]
        public bool IsExternal { get; set; }

        [JsonProperty("allow_logon")]
        public bool AllowLogon { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum FullDocumentProfileDefaultSecurityType
    {
        [EnumMember(Value = "inherit")]
        Inherit,
        [EnumMember(Value = "private")]
        Private,
        [EnumMember(Value = "view")]
        View,
        [EnumMember(Value = "public")]
        Public
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum FullDocumentProfileWstypeType
    {
        [EnumMember(Value = "document")]
        Document,
        [EnumMember(Value = "folder")]
        Folder,
        [EnumMember(Value = "workspace")]
        Workspace,
        [EnumMember(Value = "email")]
        Email,
        [EnumMember(Value = "document_shortcut")]
        DocumentShortcut,
        [EnumMember(Value = "folder_shortcut")]
        FolderShortcut,
        [EnumMember(Value = "workspace_shortcut")]
        WorkspaceShortcut,
        [EnumMember(Value = "user")]
        User
    }

    public class ShortDocumentProfileResponseBody
    {
        [JsonProperty("data")]
        public ShortDocumentProfile Data { get; set; }
    }

    public class ShortDocumentProfile
    {
        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("author_description")]
        public string AuthorDescription { get; set; }

        [JsonProperty("bcc")]
        public string Bcc { get; set; }

        [JsonProperty("cc")]
        public string Cc { get; set; }

        [JsonProperty("class")]
        public string Class { get; set; }

        [JsonProperty("class_description")]
        public string ClassDescription { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("content_type")]
        public string ContentType { get; set; }

        [JsonProperty("create_date")]
        public string CreateDate { get; set; }

        [JsonProperty("database")]
        public string Database { get; set; }

        [JsonProperty("default_security")]
        public ShortDocumentProfileDefaultSecurityType DefaultSecurity { get; set; }

        [JsonProperty("document_number")]
        public int DocumentNumber { get; set; }

        [JsonProperty("document_url")]
        public string DocumentUrl { get; set; }

        [JsonProperty("edit_date")]
        public string EditDate { get; set; }

        [JsonProperty("edit_profile_date")]
        public string EditProfileDate { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("file_create_date")]
        public string FileCreateDate { get; set; }

        [JsonProperty("file_edit_date")]
        public string FileEditDate { get; set; }

        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("full_file_name")]
        public string FullFileName { get; set; }

        [JsonProperty("has_attachment")]
        public bool HasAttachment { get; set; }

        [JsonProperty("basic_properties")]
        public string BasicProperties { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("indexable")]
        public bool Indexable { get; set; }

        [JsonProperty("is_checked_out")]
        public bool IsCheckedOut { get; set; }

        [JsonProperty("is_declared")]
        public bool IsDeclared { get; set; }

        [JsonProperty("is_external")]
        public bool IsExternal { get; set; }

        [JsonProperty("is_external_as_normal")]
        public bool IsExternalAsNormal { get; set; }

        [JsonProperty("is_hipaa")]
        public bool IsHipaa { get; set; }

        [JsonProperty("is_in_use")]
        public bool IsInUse { get; set; }

        [JsonProperty("iwl")]
        public string Iwl { get; set; }

        [JsonProperty("last_user")]
        public string LastUser { get; set; }

        [JsonProperty("last_user_description")]
        public string LastUserDescription { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("operator")]
        public string Operator { get; set; }

        [JsonProperty("operator_description")]
        public string OperatorDescription { get; set; }

        [JsonProperty("received_date")]
        public string ReceivedDate { get; set; }

        [JsonProperty("retain_days")]
        public int RetainDays { get; set; }

        [JsonProperty("sent_date")]
        public string SentDate { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("subclass")]
        public string Subclass { get; set; }

        [JsonProperty("subclass_description")]
        public string SubclassDescription { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("type_description")]
        public string TypeDescription { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("wstype")]
        public ShortDocumentProfileWstypeType Wstype { get; set; }

        [JsonProperty("custom1")]
        public string Custom1 { get; set; }

        [JsonProperty("custom1_description")]
        public string Custom1Description { get; set; }

        [JsonProperty("custom2")]
        public string Custom2 { get; set; }

        [JsonProperty("custom2_description")]
        public string Custom2Description { get; set; }

        [JsonProperty("custom3")]
        public string Custom3 { get; set; }

        [JsonProperty("custom3_description")]
        public string Custom3Description { get; set; }

        [JsonProperty("custom4")]
        public string Custom4 { get; set; }

        [JsonProperty("custom4_description")]
        public string Custom4Description { get; set; }

        [JsonProperty("custom5")]
        public string Custom5 { get; set; }

        [JsonProperty("custom5_description")]
        public string Custom5Description { get; set; }

        [JsonProperty("custom6")]
        public string Custom6 { get; set; }

        [JsonProperty("custom6_description")]
        public string Custom6Description { get; set; }

        [JsonProperty("custom7")]
        public string Custom7 { get; set; }

        [JsonProperty("custom7_description")]
        public string Custom7Description { get; set; }

        [JsonProperty("custom8")]
        public string Custom8 { get; set; }

        [JsonProperty("custom8_description")]
        public string Custom8Description { get; set; }

        [JsonProperty("custom9")]
        public string Custom9 { get; set; }

        [JsonProperty("custom9_description")]
        public string Custom9Description { get; set; }

        [JsonProperty("custom10")]
        public string Custom10 { get; set; }

        [JsonProperty("custom10_description")]
        public string Custom10Description { get; set; }

        [JsonProperty("custom11")]
        public string Custom11 { get; set; }

        [JsonProperty("custom11_description")]
        public string Custom11Description { get; set; }

        [JsonProperty("custom12")]
        public string Custom12 { get; set; }

        [JsonProperty("custom12_description")]
        public string Custom12Description { get; set; }

        [JsonProperty("custom13")]
        public string Custom13 { get; set; }

        [JsonProperty("custom14")]
        public string Custom14 { get; set; }

        [JsonProperty("custom15")]
        public string Custom15 { get; set; }

        [JsonProperty("custom16")]
        public string Custom16 { get; set; }

        [JsonProperty("custom17")]
        public double Custom17 { get; set; }

        [JsonProperty("custom18")]
        public double Custom18 { get; set; }

        [JsonProperty("custom19")]
        public double Custom19 { get; set; }

        [JsonProperty("custom20")]
        public double Custom20 { get; set; }

        [JsonProperty("custom21")]
        public string Custom21 { get; set; }

        [JsonProperty("custom22")]
        public string Custom22 { get; set; }

        [JsonProperty("custom23")]
        public string Custom23 { get; set; }

        [JsonProperty("custom24")]
        public string Custom24 { get; set; }

        [JsonProperty("custom25")]
        public bool Custom25 { get; set; }

        [JsonProperty("custom26")]
        public bool Custom26 { get; set; }

        [JsonProperty("custom27")]
        public bool Custom27 { get; set; }

        [JsonProperty("custom28")]
        public bool Custom28 { get; set; }

        [JsonProperty("custom29")]
        public string Custom29 { get; set; }

        [JsonProperty("custom29_description")]
        public string Custom29Description { get; set; }

        [JsonProperty("custom30")]
        public string Custom30 { get; set; }

        [JsonProperty("custom30_description")]
        public string Custom30Description { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ShortDocumentProfileDefaultSecurityType
    {
        [EnumMember(Value = "inherit")]
        Inherit,
        [EnumMember(Value = "private")]
        Private,
        [EnumMember(Value = "view")]
        View,
        [EnumMember(Value = "public")]
        Public
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ShortDocumentProfileWstypeType
    {
        [EnumMember(Value = "document")]
        Document,
        [EnumMember(Value = "folder")]
        Folder,
        [EnumMember(Value = "workspace")]
        Workspace,
        [EnumMember(Value = "email")]
        Email,
        [EnumMember(Value = "document_shortcut")]
        DocumentShortcut,
        [EnumMember(Value = "folder_shortcut")]
        FolderShortcut,
        [EnumMember(Value = "workspace_shortcut")]
        WorkspaceShortcut,
        [EnumMember(Value = "user")]
        User
    }

    public class GetGroupMembersResponse
    {
        [JsonProperty("data")]
        public UserProfileInArray[] Data { get; set; }
    }

    public class UserProfileInArray
    {
        [JsonProperty("allow_logon")]
        public bool AllowLogon { get; set; }

        [JsonProperty("custom1")]
        public string Custom1 { get; set; }

        [JsonProperty("custom2")]
        public string Custom2 { get; set; }

        [JsonProperty("custom3")]
        public string Custom3 { get; set; }

        [JsonProperty("directory_id")]
        public string DirectoryId { get; set; }

        [JsonProperty("distinguished_name")]
        public string DistinguishedName { get; set; }

        [JsonProperty("edit_date")]
        public string EditDate { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("exch_autodiscover")]
        public string ExchAutodiscover { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("failed_logins")]
        public int FailedLogins { get; set; }

        [JsonProperty("fax")]
        public string Fax { get; set; }

        [JsonProperty("force_password_change")]
        public bool ForcePasswordChange { get; set; }

        [JsonProperty("full_name")]
        public string FullName { get; set; }

        [JsonProperty("general")]
        public string General { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("is_external")]
        public bool IsExternal { get; set; }

        [JsonProperty("last_sync_ts")]
        public string LastSyncTs { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("password_never_expire")]
        public bool PasswordNeverExpire { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("preferred_library")]
        public string PreferredLibrary { get; set; }

        [JsonProperty("pwd_changed_ts")]
        public string PwdChangedTs { get; set; }

        [JsonProperty("ssid")]
        public string Ssid { get; set; }

        [JsonProperty("user_domain")]
        public string UserDomain { get; set; }

        [JsonProperty("user_id_ex")]
        public string UserIdEx { get; set; }

        [JsonProperty("user_nos")]
        public int UserNos { get; set; }

        [JsonProperty("user_num")]
        public int UserNum { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum logonStatusInput
    {
        Any,
        Disabled,
        Enabled
    }

    public class SearchWorkspacesResponseBody
    {
        [JsonProperty("data")]
        public SearchWorkspacesResponseBodyDataType Data { get; set; }
    }

    public class SearchWorkspacesResponseBodyDataType
    {
        [JsonProperty("topMatchingId")]
        public string TopMatchingId { get; set; }

        [JsonProperty("topMatchingName")]
        public string TopMatchingName { get; set; }

        [JsonProperty("results")]
        public SearchWorkspaceResult[] Results { get; set; }
    }

    public class SearchWorkspaceResult
    {
        [JsonProperty("basic_properties")]
        public string BasicProperties { get; set; }

        [JsonProperty("create_date")]
        public string CreateDate { get; set; }

        [JsonProperty("database")]
        public string Database { get; set; }

        [JsonProperty("default_security")]
        public SearchWorkspaceResultDefaultSecurityType DefaultSecurity { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("document_number")]
        public int DocumentNumber { get; set; }

        [JsonProperty("edit_date")]
        public string EditDate { get; set; }

        [JsonProperty("has_subfolders")]
        public bool HasSubfolders { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("is_external")]
        public bool IsExternal { get; set; }

        [JsonProperty("is_external_as_normal")]
        public bool IsExternalAsNormal { get; set; }

        [JsonProperty("is_hipaa")]
        public bool IsHipaa { get; set; }

        [JsonProperty("iwl")]
        public string Iwl { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("owner_description")]
        public string OwnerDescription { get; set; }

        [JsonProperty("project_custom1")]
        public string ProjectCustom1 { get; set; }

        [JsonProperty("project_custom2")]
        public string ProjectCustom2 { get; set; }

        [JsonProperty("project_custom3")]
        public string ProjectCustom3 { get; set; }

        [JsonProperty("subclass")]
        public string Subclass { get; set; }

        [JsonProperty("wstype")]
        public SearchWorkspaceResultWstypeType Wstype { get; set; }

        [JsonProperty("workspace_url")]
        public string WorkspaceUrl { get; set; }

        [JsonProperty("custom1")]
        public string Custom1 { get; set; }

        [JsonProperty("custom1_description")]
        public string Custom1Description { get; set; }

        [JsonProperty("custom2")]
        public string Custom2 { get; set; }

        [JsonProperty("custom2_description")]
        public string Custom2Description { get; set; }

        [JsonProperty("custom3")]
        public string Custom3 { get; set; }

        [JsonProperty("custom3_description")]
        public string Custom3Description { get; set; }

        [JsonProperty("custom4")]
        public string Custom4 { get; set; }

        [JsonProperty("custom4_description")]
        public string Custom4Description { get; set; }

        [JsonProperty("custom5")]
        public string Custom5 { get; set; }

        [JsonProperty("custom5_description")]
        public string Custom5Description { get; set; }

        [JsonProperty("custom6")]
        public string Custom6 { get; set; }

        [JsonProperty("custom6_description")]
        public string Custom6Description { get; set; }

        [JsonProperty("custom7")]
        public string Custom7 { get; set; }

        [JsonProperty("custom7_description")]
        public string Custom7Description { get; set; }

        [JsonProperty("custom8")]
        public string Custom8 { get; set; }

        [JsonProperty("custom8_description")]
        public string Custom8Description { get; set; }

        [JsonProperty("custom9")]
        public string Custom9 { get; set; }

        [JsonProperty("custom9_description")]
        public string Custom9Description { get; set; }

        [JsonProperty("custom10")]
        public string Custom10 { get; set; }

        [JsonProperty("custom10_description")]
        public string Custom10Description { get; set; }

        [JsonProperty("custom11")]
        public string Custom11 { get; set; }

        [JsonProperty("custom11_description")]
        public string Custom11Description { get; set; }

        [JsonProperty("custom12")]
        public string Custom12 { get; set; }

        [JsonProperty("custom12_description")]
        public string Custom12Description { get; set; }

        [JsonProperty("custom13")]
        public string Custom13 { get; set; }

        [JsonProperty("custom14")]
        public string Custom14 { get; set; }

        [JsonProperty("custom15")]
        public string Custom15 { get; set; }

        [JsonProperty("custom16")]
        public string Custom16 { get; set; }

        [JsonProperty("custom17")]
        public double Custom17 { get; set; }

        [JsonProperty("custom18")]
        public double Custom18 { get; set; }

        [JsonProperty("custom19")]
        public double Custom19 { get; set; }

        [JsonProperty("custom20")]
        public double Custom20 { get; set; }

        [JsonProperty("custom21")]
        public string Custom21 { get; set; }

        [JsonProperty("custom22")]
        public string Custom22 { get; set; }

        [JsonProperty("custom23")]
        public string Custom23 { get; set; }

        [JsonProperty("custom24")]
        public string Custom24 { get; set; }

        [JsonProperty("custom25")]
        public bool Custom25 { get; set; }

        [JsonProperty("custom26")]
        public bool Custom26 { get; set; }

        [JsonProperty("custom27")]
        public bool Custom27 { get; set; }

        [JsonProperty("custom28")]
        public bool Custom28 { get; set; }

        [JsonProperty("custom29")]
        public string Custom29 { get; set; }

        [JsonProperty("custom29_description")]
        public string Custom29Description { get; set; }

        [JsonProperty("custom30")]
        public string Custom30 { get; set; }

        [JsonProperty("custom30_description")]
        public string Custom30Description { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SearchWorkspaceResultDefaultSecurityType
    {
        [EnumMember(Value = "inherit")]
        Inherit,
        [EnumMember(Value = "private")]
        Private,
        [EnumMember(Value = "view")]
        View,
        [EnumMember(Value = "public")]
        Public
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SearchWorkspaceResultWstypeType
    {
        [EnumMember(Value = "document")]
        Document,
        [EnumMember(Value = "folder")]
        Folder,
        [EnumMember(Value = "workspace")]
        Workspace,
        [EnumMember(Value = "email")]
        Email,
        [EnumMember(Value = "document_shortcut")]
        DocumentShortcut,
        [EnumMember(Value = "folder_shortcut")]
        FolderShortcut,
        [EnumMember(Value = "workspace_shortcut")]
        WorkspaceShortcut,
        [EnumMember(Value = "user")]
        User
    }

    public class AddDocumentReferenceResponse
    {
        [JsonProperty("data")]
        public AddDocumentReferenceResponseDataType Data { get; set; }
    }

    public class AddDocumentReferenceResponseDataType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("wstype")]
        public AddDocumentReferenceResponseDataTypeWstypeType Wstype { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AddDocumentReferenceResponseDataTypeWstypeType
    {
        [EnumMember(Value = "document")]
        Document,
        [EnumMember(Value = "document_shortcut")]
        DocumentShortcut,
        [EnumMember(Value = "email")]
        Email
    }

    public class MoveDocumentResponseBody
    {
        [JsonProperty("data")]
        public MoveDocumentProfile Data { get; set; }
    }

    public class MoveDocumentProfile
    {
        [JsonProperty("access")]
        public MoveDocumentProfileAccessType Access { get; set; }

        [JsonProperty("alias")]
        public string Alias { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("author_description")]
        public string AuthorDescription { get; set; }

        [JsonProperty("bcc")]
        public string Bcc { get; set; }

        [JsonProperty("cc")]
        public string Cc { get; set; }

        [JsonProperty("class")]
        public string Class { get; set; }

        [JsonProperty("class_description")]
        public string ClassDescription { get; set; }

        [JsonProperty("content_type")]
        public string ContentType { get; set; }

        [JsonProperty("create_date")]
        public string CreateDate { get; set; }

        [JsonProperty("database")]
        public string Database { get; set; }

        [JsonProperty("declared_date")]
        public string DeclaredDate { get; set; }

        [JsonProperty("default_security")]
        public MoveDocumentProfileDefaultSecurityType DefaultSecurity { get; set; }

        [JsonProperty("document_number")]
        public int DocumentNumber { get; set; }

        [JsonProperty("document_url")]
        public string DocumentUrl { get; set; }

        [JsonProperty("edit_date")]
        public string EditDate { get; set; }

        [JsonProperty("edit_profile_date")]
        public string EditProfileDate { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("file_create_date")]
        public string FileCreateDate { get; set; }

        [JsonProperty("file_edit_date")]
        public string FileEditDate { get; set; }

        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("full_file_name")]
        public string FullFileName { get; set; }

        [JsonProperty("has_attachment")]
        public bool HasAttachment { get; set; }

        [JsonProperty("basic_properties")]
        public string BasicProperties { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("indexable")]
        public bool Indexable { get; set; }

        [JsonProperty("in_use_by")]
        public string InUseBy { get; set; }

        [JsonProperty("in_use_by_description")]
        public string InUseByDescription { get; set; }

        [JsonProperty("is_checked_out")]
        public bool IsCheckedOut { get; set; }

        [JsonProperty("is_declared")]
        public bool IsDeclared { get; set; }

        [JsonProperty("is_external")]
        public bool IsExternal { get; set; }

        [JsonProperty("is_external_as_normal")]
        public bool IsExternalAsNormal { get; set; }

        [JsonProperty("is_hipaa")]
        public bool IsHipaa { get; set; }

        [JsonProperty("is_in_use")]
        public bool IsInUse { get; set; }

        [JsonProperty("is_related")]
        public bool IsRelated { get; set; }

        [JsonProperty("iwl")]
        public string Iwl { get; set; }

        [JsonProperty("last_user")]
        public string LastUser { get; set; }

        [JsonProperty("last_user_description")]
        public string LastUserDescription { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("operator")]
        public string Operator { get; set; }

        [JsonProperty("operator_description")]
        public string OperatorDescription { get; set; }

        [JsonProperty("received_date")]
        public string ReceivedDate { get; set; }

        [JsonProperty("retain_days")]
        public int RetainDays { get; set; }

        [JsonProperty("sent_date")]
        public string SentDate { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("subclass")]
        public string Subclass { get; set; }

        [JsonProperty("subclass_description")]
        public string SubclassDescription { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("type_description")]
        public string TypeDescription { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("workspace_id")]
        public string WorkspaceId { get; set; }

        [JsonProperty("workspace_name")]
        public string WorkspaceName { get; set; }

        [JsonProperty("wstype")]
        public MoveDocumentProfileWstypeType Wstype { get; set; }

        [JsonProperty("custom1")]
        public string Custom1 { get; set; }

        [JsonProperty("custom1_description")]
        public string Custom1Description { get; set; }

        [JsonProperty("custom2")]
        public string Custom2 { get; set; }

        [JsonProperty("custom2_description")]
        public string Custom2Description { get; set; }

        [JsonProperty("custom3")]
        public string Custom3 { get; set; }

        [JsonProperty("custom3_description")]
        public string Custom3Description { get; set; }

        [JsonProperty("custom4")]
        public string Custom4 { get; set; }

        [JsonProperty("custom4_description")]
        public string Custom4Description { get; set; }

        [JsonProperty("custom5")]
        public string Custom5 { get; set; }

        [JsonProperty("custom5_description")]
        public string Custom5Description { get; set; }

        [JsonProperty("custom6")]
        public string Custom6 { get; set; }

        [JsonProperty("custom6_description")]
        public string Custom6Description { get; set; }

        [JsonProperty("custom7")]
        public string Custom7 { get; set; }

        [JsonProperty("custom7_description")]
        public string Custom7Description { get; set; }

        [JsonProperty("custom8")]
        public string Custom8 { get; set; }

        [JsonProperty("custom8_description")]
        public string Custom8Description { get; set; }

        [JsonProperty("custom9")]
        public string Custom9 { get; set; }

        [JsonProperty("custom9_description")]
        public string Custom9Description { get; set; }

        [JsonProperty("custom10")]
        public string Custom10 { get; set; }

        [JsonProperty("custom10_description")]
        public string Custom10Description { get; set; }

        [JsonProperty("custom11")]
        public string Custom11 { get; set; }

        [JsonProperty("custom11_description")]
        public string Custom11Description { get; set; }

        [JsonProperty("custom12")]
        public string Custom12 { get; set; }

        [JsonProperty("custom12_description")]
        public string Custom12Description { get; set; }

        [JsonProperty("custom13")]
        public string Custom13 { get; set; }

        [JsonProperty("custom14")]
        public string Custom14 { get; set; }

        [JsonProperty("custom15")]
        public string Custom15 { get; set; }

        [JsonProperty("custom16")]
        public string Custom16 { get; set; }

        [JsonProperty("custom17")]
        public double Custom17 { get; set; }

        [JsonProperty("custom18")]
        public double Custom18 { get; set; }

        [JsonProperty("custom19")]
        public double Custom19 { get; set; }

        [JsonProperty("custom20")]
        public double Custom20 { get; set; }

        [JsonProperty("custom21")]
        public string Custom21 { get; set; }

        [JsonProperty("custom22")]
        public string Custom22 { get; set; }

        [JsonProperty("custom23")]
        public string Custom23 { get; set; }

        [JsonProperty("custom24")]
        public string Custom24 { get; set; }

        [JsonProperty("custom25")]
        public bool Custom25 { get; set; }

        [JsonProperty("custom26")]
        public bool Custom26 { get; set; }

        [JsonProperty("custom27")]
        public bool Custom27 { get; set; }

        [JsonProperty("custom28")]
        public bool Custom28 { get; set; }

        [JsonProperty("custom29")]
        public string Custom29 { get; set; }

        [JsonProperty("custom29_description")]
        public string Custom29Description { get; set; }

        [JsonProperty("custom30")]
        public string Custom30 { get; set; }

        [JsonProperty("custom30_description")]
        public string Custom30Description { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MoveDocumentProfileAccessType
    {
        [EnumMember(Value = "no_access")]
        NoAccess,
        [EnumMember(Value = "read")]
        Read,
        [EnumMember(Value = "read_write")]
        ReadWrite,
        [EnumMember(Value = "full_access")]
        FullAccess
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MoveDocumentProfileDefaultSecurityType
    {
        [EnumMember(Value = "inherit")]
        Inherit,
        [EnumMember(Value = "private")]
        Private,
        [EnumMember(Value = "view")]
        View,
        [EnumMember(Value = "public")]
        Public
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MoveDocumentProfileWstypeType
    {
        [EnumMember(Value = "document")]
        Document,
        [EnumMember(Value = "folder")]
        Folder,
        [EnumMember(Value = "workspace")]
        Workspace,
        [EnumMember(Value = "email")]
        Email,
        [EnumMember(Value = "document_shortcut")]
        DocumentShortcut,
        [EnumMember(Value = "folder_shortcut")]
        FolderShortcut,
        [EnumMember(Value = "workspace_shortcut")]
        WorkspaceShortcut,
        [EnumMember(Value = "user")]
        User
    }

    public class CopyDocumentResponse
    {
        [JsonProperty("data")]
        public CopyDocumentResponseDataType Data { get; set; }
    }

    public class CopyDocumentResponseDataType
    {
        [JsonProperty("access")]
        public CopyDocumentResponseDataTypeAccessType Access { get; set; }

        [JsonProperty("alias")]
        public string Alias { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("author_description")]
        public string AuthorDescription { get; set; }

        [JsonProperty("cc")]
        public string Cc { get; set; }

        [JsonProperty("class")]
        public string Class { get; set; }

        [JsonProperty("class_description")]
        public string ClassDescription { get; set; }

        [JsonProperty("content_type")]
        public string ContentType { get; set; }

        [JsonProperty("create_date")]
        public string CreateDate { get; set; }

        [JsonProperty("database")]
        public string Database { get; set; }

        [JsonProperty("default_security")]
        public CopyDocumentResponseDataTypeDefaultSecurityType DefaultSecurity { get; set; }

        [JsonProperty("document_number")]
        public int DocumentNumber { get; set; }

        [JsonProperty("document_url")]
        public string DocumentUrl { get; set; }

        [JsonProperty("edit_date")]
        public string EditDate { get; set; }

        [JsonProperty("edit_profile_date")]
        public string EditProfileDate { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("file_create_date")]
        public string FileCreateDate { get; set; }

        [JsonProperty("file_edit_date")]
        public string FileEditDate { get; set; }

        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("full_file_name")]
        public string FullFileName { get; set; }

        [JsonProperty("has_attachment")]
        public bool HasAttachment { get; set; }

        [JsonProperty("basic_properties")]
        public string BasicProperties { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("indexable")]
        public bool Indexable { get; set; }

        [JsonProperty("is_checked_out")]
        public bool IsCheckedOut { get; set; }

        [JsonProperty("is_declared")]
        public bool IsDeclared { get; set; }

        [JsonProperty("is_external")]
        public bool IsExternal { get; set; }

        [JsonProperty("is_external_as_normal")]
        public bool IsExternalAsNormal { get; set; }

        [JsonProperty("is_hipaa")]
        public bool IsHipaa { get; set; }

        [JsonProperty("is_in_use")]
        public bool IsInUse { get; set; }

        [JsonProperty("iwl")]
        public string Iwl { get; set; }

        [JsonProperty("last_user")]
        public string LastUser { get; set; }

        [JsonProperty("last_user_description")]
        public string LastUserDescription { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("operator")]
        public string Operator { get; set; }

        [JsonProperty("operator_description")]
        public string OperatorDescription { get; set; }

        [JsonProperty("received_date")]
        public string ReceivedDate { get; set; }

        [JsonProperty("retain_days")]
        public int RetainDays { get; set; }

        [JsonProperty("sent_date")]
        public string SentDate { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("subclass")]
        public string Subclass { get; set; }

        [JsonProperty("subclass_description")]
        public string SubclassDescription { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("type_description")]
        public string TypeDescription { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("workspace_id")]
        public string WorkspaceId { get; set; }

        [JsonProperty("workspace_name")]
        public string WorkspaceName { get; set; }

        [JsonProperty("wstype")]
        public CopyDocumentResponseDataTypeWstypeType Wstype { get; set; }

        [JsonProperty("custom13")]
        public string Custom13 { get; set; }

        [JsonProperty("custom14")]
        public string Custom14 { get; set; }

        [JsonProperty("custom15")]
        public string Custom15 { get; set; }

        [JsonProperty("custom16")]
        public string Custom16 { get; set; }

        [JsonProperty("custom21")]
        public string Custom21 { get; set; }

        [JsonProperty("custom22")]
        public string Custom22 { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CopyDocumentResponseDataTypeAccessType
    {
        [EnumMember(Value = "no_access")]
        NoAccess,
        [EnumMember(Value = "read")]
        Read,
        [EnumMember(Value = "read_write")]
        ReadWrite,
        [EnumMember(Value = "full_access")]
        FullAccess
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CopyDocumentResponseDataTypeDefaultSecurityType
    {
        [EnumMember(Value = "inherit")]
        Inherit,
        [EnumMember(Value = "private")]
        Private,
        [EnumMember(Value = "view")]
        View,
        [EnumMember(Value = "public")]
        Public
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CopyDocumentResponseDataTypeWstypeType
    {
        [EnumMember(Value = "document")]
        Document,
        [EnumMember(Value = "folder")]
        Folder,
        [EnumMember(Value = "workspace")]
        Workspace,
        [EnumMember(Value = "email")]
        Email,
        [EnumMember(Value = "document_shortcut")]
        DocumentShortcut,
        [EnumMember(Value = "folder_shortcut")]
        FolderShortcut,
        [EnumMember(Value = "workspace_shortcut")]
        WorkspaceShortcut,
        [EnumMember(Value = "user")]
        User
    }

    public class CreateFormLinkResponse
    {
        [JsonProperty("data")]
        public CreateFormLinkResponseDataType Data { get; set; }
    }

    public class CreateFormLinkResponseDataType
    {
        [JsonProperty("link_url")]
        public string LinkUrl { get; set; }
    }

    public class CoreEMPropertiesResponseBody
    {
        [JsonProperty("data")]
        public CoreEMProperties Data { get; set; }
    }

    public class CoreEMProperties
    {
        [JsonProperty("is_latest")]
        public bool IsLatest { get; set; }

        [JsonProperty("latest")]
        public string Latest { get; set; }

        [JsonProperty("full_file_name")]
        public string FullFileName { get; set; }

        [JsonProperty("basic_properties")]
        public string BasicProperties { get; set; }

        [JsonProperty("document_url")]
        public string DocumentUrl { get; set; }

        [JsonProperty("date1")]
        public string Date1 { get; set; }

        [JsonProperty("date2")]
        public string Date2 { get; set; }

        [JsonProperty("date3")]
        public string Date3 { get; set; }

        [JsonProperty("date4")]
        public string Date4 { get; set; }

        [JsonProperty("date5")]
        public string Date5 { get; set; }

        [JsonProperty("date6")]
        public string Date6 { get; set; }

        [JsonProperty("date7")]
        public string Date7 { get; set; }

        [JsonProperty("date8")]
        public string Date8 { get; set; }

        [JsonProperty("date9")]
        public string Date9 { get; set; }

        [JsonProperty("date10")]
        public string Date10 { get; set; }

        [JsonProperty("text1")]
        public string Text1 { get; set; }

        [JsonProperty("text2")]
        public string Text2 { get; set; }

        [JsonProperty("text3")]
        public string Text3 { get; set; }

        [JsonProperty("text4")]
        public string Text4 { get; set; }

        [JsonProperty("text5")]
        public string Text5 { get; set; }

        [JsonProperty("text6")]
        public string Text6 { get; set; }

        [JsonProperty("text7")]
        public string Text7 { get; set; }

        [JsonProperty("text8")]
        public string Text8 { get; set; }

        [JsonProperty("text9")]
        public string Text9 { get; set; }

        [JsonProperty("text10")]
        public string Text10 { get; set; }

        [JsonProperty("long1")]
        public string Long1 { get; set; }

        [JsonProperty("long2")]
        public string Long2 { get; set; }

        [JsonProperty("long3")]
        public string Long3 { get; set; }

        [JsonProperty("long4")]
        public string Long4 { get; set; }

        [JsonProperty("long5")]
        public string Long5 { get; set; }

        [JsonProperty("double1")]
        public string Double1 { get; set; }

        [JsonProperty("double2")]
        public string Double2 { get; set; }

        [JsonProperty("double3")]
        public string Double3 { get; set; }

        [JsonProperty("double4")]
        public string Double4 { get; set; }

        [JsonProperty("double5")]
        public string Double5 { get; set; }

        [JsonProperty("double6")]
        public string Double6 { get; set; }

        [JsonProperty("double7")]
        public string Double7 { get; set; }

        [JsonProperty("double8")]
        public string Double8 { get; set; }

        [JsonProperty("double9")]
        public string Double9 { get; set; }

        [JsonProperty("double10")]
        public string Double10 { get; set; }

        [JsonProperty("bool1")]
        public bool Bool1 { get; set; }

        [JsonProperty("bool2")]
        public bool Bool2 { get; set; }

        [JsonProperty("bool3")]
        public bool Bool3 { get; set; }

        [JsonProperty("bool4")]
        public bool Bool4 { get; set; }

        [JsonProperty("bool5")]
        public bool Bool5 { get; set; }

        [JsonProperty("mv_text1")]
        public string[] MvText1 { get; set; }

        [JsonProperty("mv_text2")]
        public string[] MvText2 { get; set; }

        [JsonProperty("mv_text3")]
        public string[] MvText3 { get; set; }

        [JsonProperty("mv_text4")]
        public string[] MvText4 { get; set; }

        [JsonProperty("mv_text5")]
        public string[] MvText5 { get; set; }

        [JsonProperty("all_mv_text1")]
        public string AllMvText1 { get; set; }

        [JsonProperty("all_mv_text2")]
        public string AllMvText2 { get; set; }

        [JsonProperty("all_mv_text3")]
        public string AllMvText3 { get; set; }

        [JsonProperty("all_mv_text4")]
        public string AllMvText4 { get; set; }

        [JsonProperty("all_mv_text5")]
        public string AllMvText5 { get; set; }

        [JsonProperty("mv_url1")]
        public string[] MvUrl1 { get; set; }

        [JsonProperty("mv_url2")]
        public string[] MvUrl2 { get; set; }

        [JsonProperty("mv_url3")]
        public string[] MvUrl3 { get; set; }

        [JsonProperty("mv_url4")]
        public string[] MvUrl4 { get; set; }

        [JsonProperty("mv_url5")]
        public string[] MvUrl5 { get; set; }

        [JsonProperty("all_mv_url1")]
        public string AllMvUrl1 { get; set; }

        [JsonProperty("all_mv_url2")]
        public string AllMvUrl2 { get; set; }

        [JsonProperty("all_mv_url3")]
        public string AllMvUrl3 { get; set; }

        [JsonProperty("all_mv_url4")]
        public string AllMvUrl4 { get; set; }

        [JsonProperty("all_mv_url5")]
        public string AllMvUrl5 { get; set; }

        [JsonProperty("mv_email_address1")]
        public string[] MvEmailAddress1 { get; set; }

        [JsonProperty("mv_email_address2")]
        public string[] MvEmailAddress2 { get; set; }

        [JsonProperty("mv_email_address3")]
        public string[] MvEmailAddress3 { get; set; }

        [JsonProperty("mv_email_address4")]
        public string[] MvEmailAddress4 { get; set; }

        [JsonProperty("mv_email_address5")]
        public string[] MvEmailAddress5 { get; set; }

        [JsonProperty("all_mv_email_address1")]
        public string AllMvEmailAddress1 { get; set; }

        [JsonProperty("all_mv_email_address2")]
        public string AllMvEmailAddress2 { get; set; }

        [JsonProperty("all_mv_email_address3")]
        public string AllMvEmailAddress3 { get; set; }

        [JsonProperty("all_mv_email_address4")]
        public string AllMvEmailAddress4 { get; set; }

        [JsonProperty("all_mv_email_address5")]
        public string AllMvEmailAddress5 { get; set; }

        [JsonProperty("user1")]
        public CoreEMPropertiesUser1Type User1 { get; set; }

        [JsonProperty("user2")]
        public CoreEMPropertiesUser2Type User2 { get; set; }

        [JsonProperty("user3")]
        public CoreEMPropertiesUser3Type User3 { get; set; }

        [JsonProperty("mv_user1")]
        public CoreEMPropertiesMvUser1TypeItem[] MvUser1 { get; set; }

        [JsonProperty("mv_user2")]
        public CoreEMPropertiesMvUser2TypeItem[] MvUser2 { get; set; }

        [JsonProperty("mv_user3")]
        public CoreEMPropertiesMvUser3TypeItem[] MvUser3 { get; set; }

        [JsonProperty("mv_user4")]
        public CoreEMPropertiesMvUser4TypeItem[] MvUser4 { get; set; }

        [JsonProperty("mv_user5")]
        public CoreEMPropertiesMvUser5TypeItem[] MvUser5 { get; set; }

        [JsonProperty("mv_user6")]
        public CoreEMPropertiesMvUser6TypeItem[] MvUser6 { get; set; }

        [JsonProperty("all_mv_user1_ssids")]
        public string AllMvUser1Ssids { get; set; }

        [JsonProperty("all_mv_user2_ssids")]
        public string AllMvUser2Ssids { get; set; }

        [JsonProperty("all_mv_user3_ssids")]
        public string AllMvUser3Ssids { get; set; }

        [JsonProperty("all_mv_user4_ssids")]
        public string AllMvUser4Ssids { get; set; }

        [JsonProperty("all_mv_user5_ssids")]
        public string AllMvUser5Ssids { get; set; }

        [JsonProperty("all_mv_user6_ssids")]
        public string AllMvUser6Ssids { get; set; }

        [JsonProperty("taxonomy1")]
        public CoreEMPropertiesTaxonomy1Type Taxonomy1 { get; set; }

        [JsonProperty("taxonomy2")]
        public CoreEMPropertiesTaxonomy2Type Taxonomy2 { get; set; }

        [JsonProperty("taxonomy3")]
        public CoreEMPropertiesTaxonomy3Type Taxonomy3 { get; set; }

        [JsonProperty("taxonomy4")]
        public CoreEMPropertiesTaxonomy4Type Taxonomy4 { get; set; }

        [JsonProperty("mv_taxonomy1")]
        public CoreEMPropertiesMvTaxonomy1TypeItem[] MvTaxonomy1 { get; set; }

        [JsonProperty("mv_taxonomy2")]
        public CoreEMPropertiesMvTaxonomy2TypeItem[] MvTaxonomy2 { get; set; }

        [JsonProperty("mv_taxonomy3")]
        public CoreEMPropertiesMvTaxonomy3TypeItem[] MvTaxonomy3 { get; set; }

        [JsonProperty("mv_taxonomy4")]
        public CoreEMPropertiesMvTaxonomy4TypeItem[] MvTaxonomy4 { get; set; }

        [JsonProperty("mv_taxonomy5")]
        public CoreEMPropertiesMvTaxonomy5TypeItem[] MvTaxonomy5 { get; set; }

        [JsonProperty("mv_taxonomy6")]
        public CoreEMPropertiesMvTaxonomy6TypeItem[] MvTaxonomy6 { get; set; }

        [JsonProperty("mv_taxonomy7")]
        public CoreEMPropertiesMvTaxonomy7TypeItem[] MvTaxonomy7 { get; set; }

        [JsonProperty("mv_taxonomy8")]
        public CoreEMPropertiesMvTaxonomy8TypeItem[] MvTaxonomy8 { get; set; }

        [JsonProperty("mv_taxonomy9")]
        public CoreEMPropertiesMvTaxonomy9TypeItem[] MvTaxonomy9 { get; set; }

        [JsonProperty("mv_taxonomy10")]
        public CoreEMPropertiesMvTaxonomy10TypeItem[] MvTaxonomy10 { get; set; }

        [JsonProperty("all_mv_taxonomy1_ssids")]
        public string AllMvTaxonomy1Ssids { get; set; }

        [JsonProperty("all_mv_taxonomy2_ssids")]
        public string AllMvTaxonomy2Ssids { get; set; }

        [JsonProperty("all_mv_taxonomy3_ssids")]
        public string AllMvTaxonomy3Ssids { get; set; }

        [JsonProperty("all_mv_taxonomy4_ssids")]
        public string AllMvTaxonomy4Ssids { get; set; }

        [JsonProperty("all_mv_taxonomy5_ssids")]
        public string AllMvTaxonomy5Ssids { get; set; }

        [JsonProperty("all_mv_taxonomy6_ssids")]
        public string AllMvTaxonomy6Ssids { get; set; }

        [JsonProperty("all_mv_taxonomy7_ssids")]
        public string AllMvTaxonomy7Ssids { get; set; }

        [JsonProperty("all_mv_taxonomy8_ssids")]
        public string AllMvTaxonomy8Ssids { get; set; }

        [JsonProperty("all_mv_taxonomy9_ssids")]
        public string AllMvTaxonomy9Ssids { get; set; }

        [JsonProperty("all_mv_taxonomy10_ssids")]
        public string AllMvTaxonomy10Ssids { get; set; }

        [JsonProperty("lookup1")]
        public CoreEMPropertiesLookup1Type Lookup1 { get; set; }

        [JsonProperty("lookup2")]
        public CoreEMPropertiesLookup2Type Lookup2 { get; set; }

        [JsonProperty("lookup3")]
        public CoreEMPropertiesLookup3Type Lookup3 { get; set; }

        [JsonProperty("lookup4")]
        public CoreEMPropertiesLookup4Type Lookup4 { get; set; }

        [JsonProperty("lookup5")]
        public CoreEMPropertiesLookup5Type Lookup5 { get; set; }

        [JsonProperty("lookup6")]
        public CoreEMPropertiesLookup6Type Lookup6 { get; set; }

        [JsonProperty("lookup7")]
        public CoreEMPropertiesLookup7Type Lookup7 { get; set; }

        [JsonProperty("lookup8")]
        public CoreEMPropertiesLookup8Type Lookup8 { get; set; }

        [JsonProperty("lookup9")]
        public CoreEMPropertiesLookup9Type Lookup9 { get; set; }

        [JsonProperty("lookup10")]
        public CoreEMPropertiesLookup10Type Lookup10 { get; set; }

        [JsonProperty("lookup1_child")]
        public CoreEMPropertiesLookup1ChildType Lookup1Child { get; set; }

        [JsonProperty("lookup2_child")]
        public CoreEMPropertiesLookup2ChildType Lookup2Child { get; set; }

        [JsonProperty("lookup3_child")]
        public CoreEMPropertiesLookup3ChildType Lookup3Child { get; set; }

        [JsonProperty("lookup4_child")]
        public CoreEMPropertiesLookup4ChildType Lookup4Child { get; set; }

        [JsonProperty("lookup5_child")]
        public CoreEMPropertiesLookup5ChildType Lookup5Child { get; set; }

        [JsonProperty("lookup6_child")]
        public CoreEMPropertiesLookup6ChildType Lookup6Child { get; set; }

        [JsonProperty("lookup7_child")]
        public CoreEMPropertiesLookup7ChildType Lookup7Child { get; set; }

        [JsonProperty("lookup8_child")]
        public CoreEMPropertiesLookup8ChildType Lookup8Child { get; set; }

        [JsonProperty("lookup9_child")]
        public CoreEMPropertiesLookup9ChildType Lookup9Child { get; set; }

        [JsonProperty("lookup10_child")]
        public CoreEMPropertiesLookup10ChildType Lookup10Child { get; set; }

        [JsonProperty("mv_lookup1")]
        public CoreEMPropertiesMvLookup1TypeItem[] MvLookup1 { get; set; }

        [JsonProperty("mv_lookup2")]
        public CoreEMPropertiesMvLookup2TypeItem[] MvLookup2 { get; set; }

        [JsonProperty("mv_lookup3")]
        public CoreEMPropertiesMvLookup3TypeItem[] MvLookup3 { get; set; }

        [JsonProperty("mv_lookup4")]
        public CoreEMPropertiesMvLookup4TypeItem[] MvLookup4 { get; set; }

        [JsonProperty("mv_lookup5")]
        public CoreEMPropertiesMvLookup5TypeItem[] MvLookup5 { get; set; }

        [JsonProperty("mv_lookup6")]
        public CoreEMPropertiesMvLookup6TypeItem[] MvLookup6 { get; set; }

        [JsonProperty("mv_lookup7")]
        public CoreEMPropertiesMvLookup7TypeItem[] MvLookup7 { get; set; }

        [JsonProperty("mv_lookup8")]
        public CoreEMPropertiesMvLookup8TypeItem[] MvLookup8 { get; set; }

        [JsonProperty("mv_lookup9")]
        public CoreEMPropertiesMvLookup9TypeItem[] MvLookup9 { get; set; }

        [JsonProperty("mv_lookup10")]
        public CoreEMPropertiesMvLookup10TypeItem[] MvLookup10 { get; set; }

        [JsonProperty("mv_lookup11")]
        public CoreEMPropertiesMvLookup11TypeItem[] MvLookup11 { get; set; }

        [JsonProperty("mv_lookup12")]
        public CoreEMPropertiesMvLookup12TypeItem[] MvLookup12 { get; set; }

        [JsonProperty("mv_lookup13")]
        public CoreEMPropertiesMvLookup13TypeItem[] MvLookup13 { get; set; }

        [JsonProperty("mv_lookup14")]
        public CoreEMPropertiesMvLookup14TypeItem[] MvLookup14 { get; set; }

        [JsonProperty("mv_lookup15")]
        public CoreEMPropertiesMvLookup15TypeItem[] MvLookup15 { get; set; }

        [JsonProperty("mv_lookup16")]
        public CoreEMPropertiesMvLookup16TypeItem[] MvLookup16 { get; set; }

        [JsonProperty("mv_lookup17")]
        public CoreEMPropertiesMvLookup17TypeItem[] MvLookup17 { get; set; }

        [JsonProperty("mv_lookup18")]
        public CoreEMPropertiesMvLookup18TypeItem[] MvLookup18 { get; set; }

        [JsonProperty("mv_lookup19")]
        public CoreEMPropertiesMvLookup19TypeItem[] MvLookup19 { get; set; }

        [JsonProperty("mv_lookup20")]
        public CoreEMPropertiesMvLookup20TypeItem[] MvLookup20 { get; set; }

        [JsonProperty("all_mv_lookup1_ssids")]
        public string AllMvLookup1Ssids { get; set; }

        [JsonProperty("all_mv_lookup2_ssids")]
        public string AllMvLookup2Ssids { get; set; }

        [JsonProperty("all_mv_lookup3_ssids")]
        public string AllMvLookup3Ssids { get; set; }

        [JsonProperty("all_mv_lookup4_ssids")]
        public string AllMvLookup4Ssids { get; set; }

        [JsonProperty("all_mv_lookup5_ssids")]
        public string AllMvLookup5Ssids { get; set; }

        [JsonProperty("all_mv_lookup6_ssids")]
        public string AllMvLookup6Ssids { get; set; }

        [JsonProperty("all_mv_lookup7_ssids")]
        public string AllMvLookup7Ssids { get; set; }

        [JsonProperty("all_mv_lookup8_ssids")]
        public string AllMvLookup8Ssids { get; set; }

        [JsonProperty("all_mv_lookup9_ssids")]
        public string AllMvLookup9Ssids { get; set; }

        [JsonProperty("all_mv_lookup10_ssids")]
        public string AllMvLookup10Ssids { get; set; }

        [JsonProperty("all_mv_lookup11_ssids")]
        public string AllMvLookup11Ssids { get; set; }

        [JsonProperty("all_mv_lookup12_ssids")]
        public string AllMvLookup12Ssids { get; set; }

        [JsonProperty("all_mv_lookup13_ssids")]
        public string AllMvLookup13Ssids { get; set; }

        [JsonProperty("all_mv_lookup14_ssids")]
        public string AllMvLookup14Ssids { get; set; }

        [JsonProperty("all_mv_lookup15_ssids")]
        public string AllMvLookup15Ssids { get; set; }

        [JsonProperty("all_mv_lookup16_ssids")]
        public string AllMvLookup16Ssids { get; set; }

        [JsonProperty("all_mv_lookup17_ssids")]
        public string AllMvLookup17Ssids { get; set; }

        [JsonProperty("all_mv_lookup18_ssids")]
        public string AllMvLookup18Ssids { get; set; }

        [JsonProperty("all_mv_lookup19_ssids")]
        public string AllMvLookup19Ssids { get; set; }

        [JsonProperty("all_mv_lookup20_ssids")]
        public string AllMvLookup20Ssids { get; set; }
    }

    public class CoreEMPropertiesUser1Type
    {
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("is_external")]
        public bool IsExternal { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("ssid")]
        public string Ssid { get; set; }
    }

    public class CoreEMPropertiesUser2Type
    {
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("is_external")]
        public bool IsExternal { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("ssid")]
        public string Ssid { get; set; }
    }

    public class CoreEMPropertiesUser3Type
    {
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("is_external")]
        public bool IsExternal { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("ssid")]
        public string Ssid { get; set; }
    }

    public class CoreEMPropertiesMvUser1TypeItem
    {
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("is_external")]
        public bool IsExternal { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("ssid")]
        public string Ssid { get; set; }
    }

    public class CoreEMPropertiesMvUser2TypeItem
    {
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("is_external")]
        public bool IsExternal { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("ssid")]
        public string Ssid { get; set; }
    }

    public class CoreEMPropertiesMvUser3TypeItem
    {
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("is_external")]
        public bool IsExternal { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("ssid")]
        public string Ssid { get; set; }
    }

    public class CoreEMPropertiesMvUser4TypeItem
    {
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("is_external")]
        public bool IsExternal { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("ssid")]
        public string Ssid { get; set; }
    }

    public class CoreEMPropertiesMvUser5TypeItem
    {
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("is_external")]
        public bool IsExternal { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("ssid")]
        public string Ssid { get; set; }
    }

    public class CoreEMPropertiesMvUser6TypeItem
    {
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("is_external")]
        public bool IsExternal { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("ssid")]
        public string Ssid { get; set; }
    }

    public class CoreEMPropertiesTaxonomy1Type
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("ssid")]
        public string Ssid { get; set; }
    }

    public class CoreEMPropertiesTaxonomy2Type
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("ssid")]
        public string Ssid { get; set; }
    }

    public class CoreEMPropertiesTaxonomy3Type
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("ssid")]
        public string Ssid { get; set; }
    }

    public class CoreEMPropertiesTaxonomy4Type
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("ssid")]
        public string Ssid { get; set; }
    }

    public class CoreEMPropertiesMvTaxonomy1TypeItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("ssid")]
        public string Ssid { get; set; }
    }

    public class CoreEMPropertiesMvTaxonomy2TypeItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("ssid")]
        public string Ssid { get; set; }
    }

    public class CoreEMPropertiesMvTaxonomy3TypeItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("ssid")]
        public string Ssid { get; set; }
    }

    public class CoreEMPropertiesMvTaxonomy4TypeItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("ssid")]
        public string Ssid { get; set; }
    }

    public class CoreEMPropertiesMvTaxonomy5TypeItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("ssid")]
        public string Ssid { get; set; }
    }

    public class CoreEMPropertiesMvTaxonomy6TypeItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("ssid")]
        public string Ssid { get; set; }
    }

    public class CoreEMPropertiesMvTaxonomy7TypeItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("ssid")]
        public string Ssid { get; set; }
    }

    public class CoreEMPropertiesMvTaxonomy8TypeItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("ssid")]
        public string Ssid { get; set; }
    }

    public class CoreEMPropertiesMvTaxonomy9TypeItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("ssid")]
        public string Ssid { get; set; }
    }

    public class CoreEMPropertiesMvTaxonomy10TypeItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("ssid")]
        public string Ssid { get; set; }
    }

    public class CoreEMPropertiesLookup1Type
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("ssid")]
        public string Ssid { get; set; }
    }

    public class CoreEMPropertiesLookup2Type
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("ssid")]
        public string Ssid { get; set; }
    }

    public class CoreEMPropertiesLookup3Type
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("ssid")]
        public string Ssid { get; set; }
    }

    public class CoreEMPropertiesLookup4Type
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("ssid")]
        public string Ssid { get; set; }
    }

    public class CoreEMPropertiesLookup5Type
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("ssid")]
        public string Ssid { get; set; }
    }

    public class CoreEMPropertiesLookup6Type
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("ssid")]
        public string Ssid { get; set; }
    }

    public class CoreEMPropertiesLookup7Type
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("ssid")]
        public string Ssid { get; set; }
    }

    public class CoreEMPropertiesLookup8Type
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("ssid")]
        public string Ssid { get; set; }
    }

    public class CoreEMPropertiesLookup9Type
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("ssid")]
        public string Ssid { get; set; }
    }

    public class CoreEMPropertiesLookup10Type
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("ssid")]
        public string Ssid { get; set; }
    }

    public class CoreEMPropertiesLookup1ChildType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("ssid")]
        public string Ssid { get; set; }
    }

    public class CoreEMPropertiesLookup2ChildType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("ssid")]
        public string Ssid { get; set; }
    }

    public class CoreEMPropertiesLookup3ChildType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("ssid")]
        public string Ssid { get; set; }
    }

    public class CoreEMPropertiesLookup4ChildType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("ssid")]
        public string Ssid { get; set; }
    }

    public class CoreEMPropertiesLookup5ChildType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("ssid")]
        public string Ssid { get; set; }
    }

    public class CoreEMPropertiesLookup6ChildType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("ssid")]
        public string Ssid { get; set; }
    }

    public class CoreEMPropertiesLookup7ChildType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("ssid")]
        public string Ssid { get; set; }
    }

    public class CoreEMPropertiesLookup8ChildType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("ssid")]
        public string Ssid { get; set; }
    }

    public class CoreEMPropertiesLookup9ChildType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("ssid")]
        public string Ssid { get; set; }
    }

    public class CoreEMPropertiesLookup10ChildType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("ssid")]
        public string Ssid { get; set; }
    }

    public class CoreEMPropertiesMvLookup1TypeItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("ssid")]
        public string Ssid { get; set; }
    }

    public class CoreEMPropertiesMvLookup2TypeItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("ssid")]
        public string Ssid { get; set; }
    }

    public class CoreEMPropertiesMvLookup3TypeItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("ssid")]
        public string Ssid { get; set; }
    }

    public class CoreEMPropertiesMvLookup4TypeItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("ssid")]
        public string Ssid { get; set; }
    }

    public class CoreEMPropertiesMvLookup5TypeItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("ssid")]
        public string Ssid { get; set; }
    }

    public class CoreEMPropertiesMvLookup6TypeItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("ssid")]
        public string Ssid { get; set; }
    }

    public class CoreEMPropertiesMvLookup7TypeItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("ssid")]
        public string Ssid { get; set; }
    }

    public class CoreEMPropertiesMvLookup8TypeItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("ssid")]
        public string Ssid { get; set; }
    }

    public class CoreEMPropertiesMvLookup9TypeItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("ssid")]
        public string Ssid { get; set; }
    }

    public class CoreEMPropertiesMvLookup10TypeItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("ssid")]
        public string Ssid { get; set; }
    }

    public class CoreEMPropertiesMvLookup11TypeItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("ssid")]
        public string Ssid { get; set; }
    }

    public class CoreEMPropertiesMvLookup12TypeItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("ssid")]
        public string Ssid { get; set; }
    }

    public class CoreEMPropertiesMvLookup13TypeItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("ssid")]
        public string Ssid { get; set; }
    }

    public class CoreEMPropertiesMvLookup14TypeItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("ssid")]
        public string Ssid { get; set; }
    }

    public class CoreEMPropertiesMvLookup15TypeItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("ssid")]
        public string Ssid { get; set; }
    }

    public class CoreEMPropertiesMvLookup16TypeItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("ssid")]
        public string Ssid { get; set; }
    }

    public class CoreEMPropertiesMvLookup17TypeItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("ssid")]
        public string Ssid { get; set; }
    }

    public class CoreEMPropertiesMvLookup18TypeItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("ssid")]
        public string Ssid { get; set; }
    }

    public class CoreEMPropertiesMvLookup19TypeItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("ssid")]
        public string Ssid { get; set; }
    }

    public class CoreEMPropertiesMvLookup20TypeItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("ssid")]
        public string Ssid { get; set; }
    }

    public class PromoteDocumentVersionResponseBody
    {
        [JsonProperty("data")]
        public MinimalDocumentProfile Data { get; set; }
    }

    public class MinimalDocumentProfile
    {
        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("author_description")]
        public string AuthorDescription { get; set; }

        [JsonProperty("basic_properties")]
        public string BasicProperties { get; set; }

        [JsonProperty("class")]
        public string Class { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("content_type")]
        public string ContentType { get; set; }

        [JsonProperty("create_date")]
        public string CreateDate { get; set; }

        [JsonProperty("custom1")]
        public string Custom1 { get; set; }

        [JsonProperty("custom1_description")]
        public string Custom1Description { get; set; }

        [JsonProperty("custom2")]
        public string Custom2 { get; set; }

        [JsonProperty("custom2_description")]
        public string Custom2Description { get; set; }

        [JsonProperty("custom3")]
        public string Custom3 { get; set; }

        [JsonProperty("custom3_description")]
        public string Custom3Description { get; set; }

        [JsonProperty("custom4")]
        public string Custom4 { get; set; }

        [JsonProperty("custom4_description")]
        public string Custom4Description { get; set; }

        [JsonProperty("custom5")]
        public string Custom5 { get; set; }

        [JsonProperty("custom5_description")]
        public string Custom5Description { get; set; }

        [JsonProperty("custom6")]
        public string Custom6 { get; set; }

        [JsonProperty("custom6_description")]
        public string Custom6Description { get; set; }

        [JsonProperty("custom7")]
        public string Custom7 { get; set; }

        [JsonProperty("custom7_description")]
        public string Custom7Description { get; set; }

        [JsonProperty("custom8")]
        public string Custom8 { get; set; }

        [JsonProperty("custom8_description")]
        public string Custom8Description { get; set; }

        [JsonProperty("custom9")]
        public string Custom9 { get; set; }

        [JsonProperty("custom9_description")]
        public string Custom9Description { get; set; }

        [JsonProperty("custom10")]
        public string Custom10 { get; set; }

        [JsonProperty("custom10_description")]
        public string Custom10Description { get; set; }

        [JsonProperty("custom11")]
        public string Custom11 { get; set; }

        [JsonProperty("custom11_description")]
        public string Custom11Description { get; set; }

        [JsonProperty("custom12")]
        public string Custom12 { get; set; }

        [JsonProperty("custom12_description")]
        public string Custom12Description { get; set; }

        [JsonProperty("custom13")]
        public string Custom13 { get; set; }

        [JsonProperty("custom14")]
        public string Custom14 { get; set; }

        [JsonProperty("custom15")]
        public string Custom15 { get; set; }

        [JsonProperty("custom16")]
        public string Custom16 { get; set; }

        [JsonProperty("custom17")]
        public double Custom17 { get; set; }

        [JsonProperty("custom18")]
        public double Custom18 { get; set; }

        [JsonProperty("custom19")]
        public double Custom19 { get; set; }

        [JsonProperty("custom20")]
        public double Custom20 { get; set; }

        [JsonProperty("custom21")]
        public string Custom21 { get; set; }

        [JsonProperty("custom22")]
        public string Custom22 { get; set; }

        [JsonProperty("custom23")]
        public string Custom23 { get; set; }

        [JsonProperty("custom24")]
        public string Custom24 { get; set; }

        [JsonProperty("custom25")]
        public bool Custom25 { get; set; }

        [JsonProperty("custom26")]
        public bool Custom26 { get; set; }

        [JsonProperty("custom27")]
        public bool Custom27 { get; set; }

        [JsonProperty("custom28")]
        public bool Custom28 { get; set; }

        [JsonProperty("custom29")]
        public string Custom29 { get; set; }

        [JsonProperty("custom29_description")]
        public string Custom29Description { get; set; }

        [JsonProperty("custom30")]
        public string Custom30 { get; set; }

        [JsonProperty("custom30_description")]
        public string Custom30Description { get; set; }

        [JsonProperty("database")]
        public string Database { get; set; }

        [JsonProperty("default_security")]
        public MinimalDocumentProfileDefaultSecurityType DefaultSecurity { get; set; }

        [JsonProperty("document_number")]
        public int DocumentNumber { get; set; }

        [JsonProperty("document_url")]
        public string DocumentUrl { get; set; }

        [JsonProperty("edit_date")]
        public string EditDate { get; set; }

        [JsonProperty("edit_profile_date")]
        public string EditProfileDate { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("full_file_name")]
        public string FullFileName { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("indexable")]
        public bool Indexable { get; set; }

        [JsonProperty("is_checked_out")]
        public bool IsCheckedOut { get; set; }

        [JsonProperty("is_declared")]
        public bool IsDeclared { get; set; }

        [JsonProperty("is_external")]
        public bool IsExternal { get; set; }

        [JsonProperty("is_hipaa")]
        public bool IsHipaa { get; set; }

        [JsonProperty("is_in_use")]
        public bool IsInUse { get; set; }

        [JsonProperty("iwl")]
        public string Iwl { get; set; }

        [JsonProperty("last_user")]
        public string LastUser { get; set; }

        [JsonProperty("last_user_description")]
        public string LastUserDescription { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("operator")]
        public string Operator { get; set; }

        [JsonProperty("operator_description")]
        public string OperatorDescription { get; set; }

        [JsonProperty("is_related")]
        public bool IsRelated { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("wstype")]
        public MinimalDocumentProfileWstypeType Wstype { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MinimalDocumentProfileDefaultSecurityType
    {
        [EnumMember(Value = "inherit")]
        Inherit,
        [EnumMember(Value = "private")]
        Private,
        [EnumMember(Value = "view")]
        View,
        [EnumMember(Value = "public")]
        Public
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MinimalDocumentProfileWstypeType
    {
        [EnumMember(Value = "document")]
        Document,
        [EnumMember(Value = "folder")]
        Folder,
        [EnumMember(Value = "workspace")]
        Workspace,
        [EnumMember(Value = "email")]
        Email,
        [EnumMember(Value = "document_shortcut")]
        DocumentShortcut,
        [EnumMember(Value = "folder_shortcut")]
        FolderShortcut,
        [EnumMember(Value = "workspace_shortcut")]
        WorkspaceShortcut,
        [EnumMember(Value = "user")]
        User
    }

    public class GetDocumentVersionsResponse
    {
        [JsonProperty("data")]
        public MinimalDocumentProfileInArray[] Data { get; set; }
    }

    public class MinimalDocumentProfileInArray
    {
        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("author_description")]
        public string AuthorDescription { get; set; }

        [JsonProperty("basic_properties")]
        public string BasicProperties { get; set; }

        [JsonProperty("class")]
        public string Class { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("content_type")]
        public string ContentType { get; set; }

        [JsonProperty("create_date")]
        public string CreateDate { get; set; }

        [JsonProperty("custom1")]
        public string Custom1 { get; set; }

        [JsonProperty("custom1_description")]
        public string Custom1Description { get; set; }

        [JsonProperty("custom2")]
        public string Custom2 { get; set; }

        [JsonProperty("custom2_description")]
        public string Custom2Description { get; set; }

        [JsonProperty("custom3")]
        public string Custom3 { get; set; }

        [JsonProperty("custom3_description")]
        public string Custom3Description { get; set; }

        [JsonProperty("custom4")]
        public string Custom4 { get; set; }

        [JsonProperty("custom4_description")]
        public string Custom4Description { get; set; }

        [JsonProperty("custom5")]
        public string Custom5 { get; set; }

        [JsonProperty("custom5_description")]
        public string Custom5Description { get; set; }

        [JsonProperty("custom6")]
        public string Custom6 { get; set; }

        [JsonProperty("custom6_description")]
        public string Custom6Description { get; set; }

        [JsonProperty("custom7")]
        public string Custom7 { get; set; }

        [JsonProperty("custom7_description")]
        public string Custom7Description { get; set; }

        [JsonProperty("custom8")]
        public string Custom8 { get; set; }

        [JsonProperty("custom8_description")]
        public string Custom8Description { get; set; }

        [JsonProperty("custom9")]
        public string Custom9 { get; set; }

        [JsonProperty("custom9_description")]
        public string Custom9Description { get; set; }

        [JsonProperty("custom10")]
        public string Custom10 { get; set; }

        [JsonProperty("custom10_description")]
        public string Custom10Description { get; set; }

        [JsonProperty("custom11")]
        public string Custom11 { get; set; }

        [JsonProperty("custom11_description")]
        public string Custom11Description { get; set; }

        [JsonProperty("custom12")]
        public string Custom12 { get; set; }

        [JsonProperty("custom12_description")]
        public string Custom12Description { get; set; }

        [JsonProperty("custom13")]
        public string Custom13 { get; set; }

        [JsonProperty("custom14")]
        public string Custom14 { get; set; }

        [JsonProperty("custom15")]
        public string Custom15 { get; set; }

        [JsonProperty("custom16")]
        public string Custom16 { get; set; }

        [JsonProperty("custom17")]
        public double Custom17 { get; set; }

        [JsonProperty("custom18")]
        public double Custom18 { get; set; }

        [JsonProperty("custom19")]
        public double Custom19 { get; set; }

        [JsonProperty("custom20")]
        public double Custom20 { get; set; }

        [JsonProperty("custom21")]
        public string Custom21 { get; set; }

        [JsonProperty("custom22")]
        public string Custom22 { get; set; }

        [JsonProperty("custom23")]
        public string Custom23 { get; set; }

        [JsonProperty("custom24")]
        public string Custom24 { get; set; }

        [JsonProperty("custom25")]
        public bool Custom25 { get; set; }

        [JsonProperty("custom26")]
        public bool Custom26 { get; set; }

        [JsonProperty("custom27")]
        public bool Custom27 { get; set; }

        [JsonProperty("custom28")]
        public bool Custom28 { get; set; }

        [JsonProperty("custom29")]
        public string Custom29 { get; set; }

        [JsonProperty("custom29_description")]
        public string Custom29Description { get; set; }

        [JsonProperty("custom30")]
        public string Custom30 { get; set; }

        [JsonProperty("custom30_description")]
        public string Custom30Description { get; set; }

        [JsonProperty("database")]
        public string Database { get; set; }

        [JsonProperty("default_security")]
        public MinimalDocumentProfileInArrayDefaultSecurityType DefaultSecurity { get; set; }

        [JsonProperty("document_number")]
        public int DocumentNumber { get; set; }

        [JsonProperty("document_url")]
        public string DocumentUrl { get; set; }

        [JsonProperty("edit_date")]
        public string EditDate { get; set; }

        [JsonProperty("edit_profile_date")]
        public string EditProfileDate { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("full_file_name")]
        public string FullFileName { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("indexable")]
        public bool Indexable { get; set; }

        [JsonProperty("is_checked_out")]
        public bool IsCheckedOut { get; set; }

        [JsonProperty("is_declared")]
        public bool IsDeclared { get; set; }

        [JsonProperty("is_external")]
        public bool IsExternal { get; set; }

        [JsonProperty("is_hipaa")]
        public bool IsHipaa { get; set; }

        [JsonProperty("is_in_use")]
        public bool IsInUse { get; set; }

        [JsonProperty("iwl")]
        public string Iwl { get; set; }

        [JsonProperty("last_user")]
        public string LastUser { get; set; }

        [JsonProperty("last_user_description")]
        public string LastUserDescription { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("operator")]
        public string Operator { get; set; }

        [JsonProperty("operator_description")]
        public string OperatorDescription { get; set; }

        [JsonProperty("is_related")]
        public bool IsRelated { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("wstype")]
        public MinimalDocumentProfileInArrayWstypeType Wstype { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MinimalDocumentProfileInArrayDefaultSecurityType
    {
        [EnumMember(Value = "inherit")]
        Inherit,
        [EnumMember(Value = "private")]
        Private,
        [EnumMember(Value = "view")]
        View,
        [EnumMember(Value = "public")]
        Public
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MinimalDocumentProfileInArrayWstypeType
    {
        [EnumMember(Value = "document")]
        Document,
        [EnumMember(Value = "folder")]
        Folder,
        [EnumMember(Value = "workspace")]
        Workspace,
        [EnumMember(Value = "email")]
        Email,
        [EnumMember(Value = "document_shortcut")]
        DocumentShortcut,
        [EnumMember(Value = "folder_shortcut")]
        FolderShortcut,
        [EnumMember(Value = "workspace_shortcut")]
        WorkspaceShortcut,
        [EnumMember(Value = "user")]
        User
    }

    public class bodyemPropertiesInputItem
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class SearchCoreEMTaxonomyNodeValuesResponse
    {
        [JsonProperty("data")]
        public SearchCoreEMTaxonomyNodeValuesResponseDataType Data { get; set; }
    }

    public class SearchCoreEMTaxonomyNodeValuesResponseDataType
    {
        [JsonProperty("topMatchingResult")]
        public SearchCoreEMTaxonomyNodeValuesResponseDataTypeTopMatchingResultType TopMatchingResult { get; set; }

        [JsonProperty("results")]
        public TaxonomyNodeValue[] Results { get; set; }

        [JsonProperty("all_taxonomy_ssids")]
        public string AllTaxonomySsids { get; set; }
    }

    public class SearchCoreEMTaxonomyNodeValuesResponseDataTypeTopMatchingResultType
    {
        [JsonProperty("created_by")]
        public SearchCoreEMTaxonomyNodeValuesResponseDataTypeTopMatchingResultTypeCreatedByType CreatedBy { get; set; }

        [JsonProperty("create_date")]
        public string CreateDate { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("edited_by")]
        public SearchCoreEMTaxonomyNodeValuesResponseDataTypeTopMatchingResultTypeEditedByType EditedBy { get; set; }

        [JsonProperty("edit_date")]
        public string EditDate { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("parent")]
        public SearchCoreEMTaxonomyNodeValuesResponseDataTypeTopMatchingResultTypeParentType Parent { get; set; }

        [JsonProperty("ssid")]
        public string Ssid { get; set; }

        [JsonProperty("path")]
        public SearchCoreEMTaxonomyNodeValuesResponseDataTypeTopMatchingResultTypePathTypeItem[] Path { get; set; }
    }

    public class SearchCoreEMTaxonomyNodeValuesResponseDataTypeTopMatchingResultTypeCreatedByType
    {
        [JsonProperty("ssid")]
        public string Ssid { get; set; }
    }

    public class SearchCoreEMTaxonomyNodeValuesResponseDataTypeTopMatchingResultTypeEditedByType
    {
        [JsonProperty("ssid")]
        public string Ssid { get; set; }
    }

    public class SearchCoreEMTaxonomyNodeValuesResponseDataTypeTopMatchingResultTypeParentType
    {
        [JsonProperty("ssid")]
        public string Ssid { get; set; }
    }

    public class SearchCoreEMTaxonomyNodeValuesResponseDataTypeTopMatchingResultTypePathTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("ssid")]
        public string Ssid { get; set; }
    }

    public class TaxonomyNodeValue
    {
        [JsonProperty("created_by")]
        public TaxonomyNodeValueCreatedByType CreatedBy { get; set; }

        [JsonProperty("create_date")]
        public string CreateDate { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("edited_by")]
        public TaxonomyNodeValueEditedByType EditedBy { get; set; }

        [JsonProperty("edit_date")]
        public string EditDate { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("parent")]
        public TaxonomyNodeValueParentType Parent { get; set; }

        [JsonProperty("ssid")]
        public string Ssid { get; set; }

        [JsonProperty("path")]
        public TaxonomyNodeValuePathTypeItem[] Path { get; set; }
    }

    public class TaxonomyNodeValueCreatedByType
    {
        [JsonProperty("ssid")]
        public string Ssid { get; set; }
    }

    public class TaxonomyNodeValueEditedByType
    {
        [JsonProperty("ssid")]
        public string Ssid { get; set; }
    }

    public class TaxonomyNodeValueParentType
    {
        [JsonProperty("ssid")]
        public string Ssid { get; set; }
    }

    public class TaxonomyNodeValuePathTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("ssid")]
        public string Ssid { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyenabledStateInput
    {
        Enabled,
        Disabled,
        [EnumMember(Value = "Both Enabled and Disabled")]
        BothEnabledAndDisabled
    }

    public class AddDocumentHistoryEntryResponse
    {
        [JsonProperty("data")]
        public JToken Data { get; set; }
    }

    public class SearchUsersResponse
    {
        [JsonProperty("data")]
        public SearchUsersResponseDataType Data { get; set; }
    }

    public class SearchUsersResponseDataType
    {
        [JsonProperty("topMatchingUser")]
        public SearchUsersResponseDataTypeTopMatchingUserType TopMatchingUser { get; set; }

        [JsonProperty("results")]
        public UserProfileInArray[] Results { get; set; }
    }

    public class SearchUsersResponseDataTypeTopMatchingUserType
    {
        [JsonProperty("allow_logon")]
        public bool AllowLogon { get; set; }

        [JsonProperty("custom1")]
        public string Custom1 { get; set; }

        [JsonProperty("custom2")]
        public string Custom2 { get; set; }

        [JsonProperty("custom3")]
        public string Custom3 { get; set; }

        [JsonProperty("directory_id")]
        public string DirectoryId { get; set; }

        [JsonProperty("distinguished_name")]
        public string DistinguishedName { get; set; }

        [JsonProperty("edit_date")]
        public string EditDate { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("exch_autodiscover")]
        public string ExchAutodiscover { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("failed_logins")]
        public int FailedLogins { get; set; }

        [JsonProperty("fax")]
        public string Fax { get; set; }

        [JsonProperty("force_password_change")]
        public bool ForcePasswordChange { get; set; }

        [JsonProperty("full_name")]
        public string FullName { get; set; }

        [JsonProperty("general")]
        public string General { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("is_external")]
        public bool IsExternal { get; set; }

        [JsonProperty("last_sync_ts")]
        public string LastSyncTs { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("password_never_expire")]
        public bool PasswordNeverExpire { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("preferred_library")]
        public string PreferredLibrary { get; set; }

        [JsonProperty("pwd_changed_ts")]
        public string PwdChangedTs { get; set; }

        [JsonProperty("ssid")]
        public string Ssid { get; set; }

        [JsonProperty("user_domain")]
        public string UserDomain { get; set; }

        [JsonProperty("user_id_ex")]
        public string UserIdEx { get; set; }

        [JsonProperty("user_nos")]
        public int UserNos { get; set; }

        [JsonProperty("user_num")]
        public int UserNum { get; set; }
    }

    public class DeleteDocumentResponseBody
    {
        [JsonProperty("data")]
        public DeleteDocumentResponseBodyDataType Data { get; set; }
    }

    public class DeleteDocumentResponseBodyDataType
    {
        [JsonProperty("deletedDocuments")]
        public DeleteDocumentResponseBodyDataTypeDeletedDocumentsTypeItem[] DeletedDocuments { get; set; }

        [JsonProperty("failedDocuments")]
        public DeleteDocumentResponseBodyDataTypeFailedDocumentsTypeItem[] FailedDocuments { get; set; }

        [JsonProperty("deletedDocumentsCount")]
        public int DeletedDocumentsCount { get; set; }

        [JsonProperty("failedDocumentsCount")]
        public int FailedDocumentsCount { get; set; }
    }

    public class DeleteDocumentResponseBodyDataTypeDeletedDocumentsTypeItem
    {
        [JsonProperty("documentId")]
        public string DocumentId { get; set; }
    }

    public class DeleteDocumentResponseBodyDataTypeFailedDocumentsTypeItem
    {
        [JsonProperty("documentId")]
        public string DocumentId { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("code_message")]
        public string CodeMessage { get; set; }
    }

    public class SingleSelectedDocumentResponse
    {
        [JsonProperty("data")]
        public string Data { get; set; }
    }

    public class MultipleSelectedDocumentsResponse
    {
        [JsonProperty("data")]
        public JToken Data { get; set; }
    }

    public class SingleSelectedWorkspaceResponse
    {
        [JsonProperty("data")]
        public string Data { get; set; }
    }

    public class MultipleSelectedWorkspacesResponse
    {
        [JsonProperty("data")]
        public JToken Data { get; set; }
    }

    public class RegisterGenericWorkflowResponse
    {
        [JsonProperty("data")]
        public string Data { get; set; }
    }

    public class RegisterFormWorkflowResponse
    {
        [JsonProperty("data")]
        public string Data { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Imanagework;

    public partial class WorkflowManagedActions
    {
        public ImanageworkActions Imanagework(string connectionId) => new ImanageworkActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ImanageworkTriggers Imanagework(string connectionId) => new ImanageworkTriggers(connectionId);
    }
}