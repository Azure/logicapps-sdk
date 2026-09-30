//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Imanagework
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ImanageworkActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagework")]
        public IBodyWorkflowAction<GetTrusteesResponse> GetTrustees([WorkflowExpression] Func<bodyobjectTypeInput> bodyobjectType, [WorkflowExpression] Func<string> bodyobjectId)
        {
            SourceExpression.Validate(bodyobjectType, nameof(bodyobjectType), required: true);
            SourceExpression.Validate(bodyobjectId, nameof(bodyobjectId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/getTrustees";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["objectType"] = SourceExpressionConverter.Convert(bodyobjectType);
                bodypropCount++;
                body["objectId"] = SourceExpressionConverter.ConvertToken(bodyobjectId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GetTrusteesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagework")]
        public IBodyWorkflowAction<UpdateDefaultSecurityResponse> UpdateDefaultSecurity([WorkflowExpression] Func<bodyobjectTypeInput> bodyobjectType, [WorkflowExpression] Func<string> bodyobjectId, [WorkflowExpression] Func<string> bodydefaultSecurity)
        {
            SourceExpression.Validate(bodyobjectType, nameof(bodyobjectType), required: true);
            SourceExpression.Validate(bodyobjectId, nameof(bodyobjectId), required: true);
            SourceExpression.Validate(bodydefaultSecurity, nameof(bodydefaultSecurity), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/updateDefaultSecurity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["objectType"] = SourceExpressionConverter.Convert(bodyobjectType);
                bodypropCount++;
                body["objectId"] = SourceExpressionConverter.ConvertToken(bodyobjectId);
                bodypropCount++;
                body["default_security"] = SourceExpressionConverter.ConvertToken(bodydefaultSecurity);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UpdateDefaultSecurityResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagework")]
        public IBodyWorkflowAction<UpdatePermissionsResponse> UpdatePermissions([WorkflowExpression] Func<bodyobjectTypeInput> bodyobjectType, [WorkflowExpression] Func<string> bodyobjectId, [WorkflowExpression] Func<bodyaccessLevelInput> bodyaccessLevel, [WorkflowExpression] Func<string> bodyusers = null, [WorkflowExpression] Func<string> bodygroups = null)
        {
            SourceExpression.Validate(bodyobjectType, nameof(bodyobjectType), required: true);
            SourceExpression.Validate(bodyobjectId, nameof(bodyobjectId), required: true);
            SourceExpression.Validate(bodyaccessLevel, nameof(bodyaccessLevel), required: true);
            SourceExpression.Validate(bodyusers, nameof(bodyusers), required: false);
            SourceExpression.Validate(bodygroups, nameof(bodygroups), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/updatePermissions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["objectType"] = SourceExpressionConverter.Convert(bodyobjectType);
                bodypropCount++;
                body["objectId"] = SourceExpressionConverter.ConvertToken(bodyobjectId);
                bodypropCount++;
                body["access_level"] = SourceExpressionConverter.Convert(bodyaccessLevel);
                if (bodyusers != null)
                {
                    body["users"] = SourceExpressionConverter.ConvertToken(bodyusers);
                    bodypropCount++;
                }

                if (bodygroups != null)
                {
                    body["groups"] = SourceExpressionConverter.ConvertToken(bodygroups);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UpdatePermissionsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagework")]
        public IBodyWorkflowAction<GetPermissionsResponse> GetPermissions([WorkflowExpression] Func<bodyobjectTypeInput> bodyobjectType, [WorkflowExpression] Func<string> bodyobjectId)
        {
            SourceExpression.Validate(bodyobjectType, nameof(bodyobjectType), required: true);
            SourceExpression.Validate(bodyobjectId, nameof(bodyobjectId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/getPermissions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["objectType"] = SourceExpressionConverter.Convert(bodyobjectType);
                bodypropCount++;
                body["objectId"] = SourceExpressionConverter.ConvertToken(bodyobjectId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GetPermissionsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagework")]
        public IBodyWorkflowAction<UpdatePermissionsResponse> CopyPermissions([WorkflowExpression] Func<bodysourceObjectTypeInput> bodysourceObjectType, [WorkflowExpression] Func<string> bodysourceObjectId, [WorkflowExpression] Func<bodytargetObjectTypeInput> bodytargetObjectType, [WorkflowExpression] Func<string> bodytargetObjectId, [WorkflowExpression] Func<bodycopyTypeInput> bodycopyType, [WorkflowExpression] Func<bool> bodycopyDefaultSecurity)
        {
            SourceExpression.Validate(bodysourceObjectType, nameof(bodysourceObjectType), required: true);
            SourceExpression.Validate(bodysourceObjectId, nameof(bodysourceObjectId), required: true);
            SourceExpression.Validate(bodytargetObjectType, nameof(bodytargetObjectType), required: true);
            SourceExpression.Validate(bodytargetObjectId, nameof(bodytargetObjectId), required: true);
            SourceExpression.Validate(bodycopyType, nameof(bodycopyType), required: true);
            SourceExpression.Validate(bodycopyDefaultSecurity, nameof(bodycopyDefaultSecurity), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/copyPermissions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["sourceObjectType"] = SourceExpressionConverter.Convert(bodysourceObjectType);
                bodypropCount++;
                body["sourceObjectId"] = SourceExpressionConverter.ConvertToken(bodysourceObjectId);
                bodypropCount++;
                body["targetObjectType"] = SourceExpressionConverter.Convert(bodytargetObjectType);
                bodypropCount++;
                body["targetObjectId"] = SourceExpressionConverter.ConvertToken(bodytargetObjectId);
                bodypropCount++;
                body["copyType"] = SourceExpressionConverter.Convert(bodycopyType);
                bodypropCount++;
                body["copyDefaultSecurity"] = SourceExpressionConverter.ConvertToken(bodycopyDefaultSecurity);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UpdatePermissionsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagework")]
        public IBodyWorkflowAction<WorkspaceProfileResponseBody> CreateWorkspace([WorkflowExpression] Func<string> bodylibraryId, [WorkflowExpression] Func<string> bodytemplateId, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<bodycreateChildrenInput> bodycreateChildren, [WorkflowExpression] Func<string> bodyowner = null, [WorkflowExpression] Func<bodydefaultSecurityInput> bodydefaultSecurity = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodycustom1 = null, [WorkflowExpression] Func<string> bodycustom2 = null, [WorkflowExpression] Func<string> bodycustom3 = null, [WorkflowExpression] Func<string> bodycustom4 = null, [WorkflowExpression] Func<string> bodycustom5 = null, [WorkflowExpression] Func<string> bodycustom6 = null, [WorkflowExpression] Func<string> bodycustom7 = null, [WorkflowExpression] Func<string> bodycustom8 = null, [WorkflowExpression] Func<string> bodycustom9 = null, [WorkflowExpression] Func<string> bodycustom10 = null, [WorkflowExpression] Func<string> bodycustom11 = null, [WorkflowExpression] Func<string> bodycustom12 = null, [WorkflowExpression] Func<string> bodycustom13 = null, [WorkflowExpression] Func<string> bodycustom14 = null, [WorkflowExpression] Func<string> bodycustom15 = null, [WorkflowExpression] Func<string> bodycustom16 = null, [WorkflowExpression] Func<double> bodycustom17 = null, [WorkflowExpression] Func<double> bodycustom18 = null, [WorkflowExpression] Func<double> bodycustom19 = null, [WorkflowExpression] Func<double> bodycustom20 = null, [WorkflowExpression] Func<string> bodycustom21 = null, [WorkflowExpression] Func<string> bodycustom22 = null, [WorkflowExpression] Func<string> bodycustom23 = null, [WorkflowExpression] Func<string> bodycustom24 = null, [WorkflowExpression] Func<bool> bodycustom25 = null, [WorkflowExpression] Func<bool> bodycustom26 = null, [WorkflowExpression] Func<bool> bodycustom27 = null, [WorkflowExpression] Func<bool> bodycustom28 = null, [WorkflowExpression] Func<string> bodycustom29 = null, [WorkflowExpression] Func<string> bodycustom30 = null, [WorkflowExpression] Func<bool> bodyisExternalAsNormal = null, [WorkflowExpression] Func<string> bodyprojectCustom1 = null, [WorkflowExpression] Func<string> bodyprojectCustom2 = null, [WorkflowExpression] Func<string> bodyprojectCustom3 = null, [WorkflowExpression] Func<string> bodysubclass = null)
        {
            SourceExpression.Validate(bodylibraryId, nameof(bodylibraryId), required: true);
            SourceExpression.Validate(bodytemplateId, nameof(bodytemplateId), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            SourceExpression.Validate(bodycreateChildren, nameof(bodycreateChildren), required: true);
            SourceExpression.Validate(bodyowner, nameof(bodyowner), required: false);
            SourceExpression.Validate(bodydefaultSecurity, nameof(bodydefaultSecurity), required: false);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            SourceExpression.Validate(bodycustom1, nameof(bodycustom1), required: false);
            SourceExpression.Validate(bodycustom2, nameof(bodycustom2), required: false);
            SourceExpression.Validate(bodycustom3, nameof(bodycustom3), required: false);
            SourceExpression.Validate(bodycustom4, nameof(bodycustom4), required: false);
            SourceExpression.Validate(bodycustom5, nameof(bodycustom5), required: false);
            SourceExpression.Validate(bodycustom6, nameof(bodycustom6), required: false);
            SourceExpression.Validate(bodycustom7, nameof(bodycustom7), required: false);
            SourceExpression.Validate(bodycustom8, nameof(bodycustom8), required: false);
            SourceExpression.Validate(bodycustom9, nameof(bodycustom9), required: false);
            SourceExpression.Validate(bodycustom10, nameof(bodycustom10), required: false);
            SourceExpression.Validate(bodycustom11, nameof(bodycustom11), required: false);
            SourceExpression.Validate(bodycustom12, nameof(bodycustom12), required: false);
            SourceExpression.Validate(bodycustom13, nameof(bodycustom13), required: false);
            SourceExpression.Validate(bodycustom14, nameof(bodycustom14), required: false);
            SourceExpression.Validate(bodycustom15, nameof(bodycustom15), required: false);
            SourceExpression.Validate(bodycustom16, nameof(bodycustom16), required: false);
            SourceExpression.Validate(bodycustom17, nameof(bodycustom17), required: false);
            SourceExpression.Validate(bodycustom18, nameof(bodycustom18), required: false);
            SourceExpression.Validate(bodycustom19, nameof(bodycustom19), required: false);
            SourceExpression.Validate(bodycustom20, nameof(bodycustom20), required: false);
            SourceExpression.Validate(bodycustom21, nameof(bodycustom21), required: false);
            SourceExpression.Validate(bodycustom22, nameof(bodycustom22), required: false);
            SourceExpression.Validate(bodycustom23, nameof(bodycustom23), required: false);
            SourceExpression.Validate(bodycustom24, nameof(bodycustom24), required: false);
            SourceExpression.Validate(bodycustom25, nameof(bodycustom25), required: false);
            SourceExpression.Validate(bodycustom26, nameof(bodycustom26), required: false);
            SourceExpression.Validate(bodycustom27, nameof(bodycustom27), required: false);
            SourceExpression.Validate(bodycustom28, nameof(bodycustom28), required: false);
            SourceExpression.Validate(bodycustom29, nameof(bodycustom29), required: false);
            SourceExpression.Validate(bodycustom30, nameof(bodycustom30), required: false);
            SourceExpression.Validate(bodyisExternalAsNormal, nameof(bodyisExternalAsNormal), required: false);
            SourceExpression.Validate(bodyprojectCustom1, nameof(bodyprojectCustom1), required: false);
            SourceExpression.Validate(bodyprojectCustom2, nameof(bodyprojectCustom2), required: false);
            SourceExpression.Validate(bodyprojectCustom3, nameof(bodyprojectCustom3), required: false);
            SourceExpression.Validate(bodysubclass, nameof(bodysubclass), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/createWorkspace";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["libraryId"] = SourceExpressionConverter.ConvertToken(bodylibraryId);
                bodypropCount++;
                body["templateId"] = SourceExpressionConverter.ConvertToken(bodytemplateId);
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
                body["createChildren"] = SourceExpressionConverter.Convert(bodycreateChildren);
                if (bodyowner != null)
                {
                    body["owner"] = SourceExpressionConverter.ConvertToken(bodyowner);
                    bodypropCount++;
                }

                if (bodydefaultSecurity != null)
                {
                    body["default_security"] = SourceExpressionConverter.Convert(bodydefaultSecurity);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    if (bodydescription != null)
                    {
                        body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["description"] = "Created from iManage Work Connector";
                    bodypropCount++;
                }

                if (bodycustom1 != null)
                {
                    body["custom1"] = SourceExpressionConverter.ConvertToken(bodycustom1);
                    bodypropCount++;
                }

                if (bodycustom2 != null)
                {
                    body["custom2"] = SourceExpressionConverter.ConvertToken(bodycustom2);
                    bodypropCount++;
                }

                if (bodycustom3 != null)
                {
                    body["custom3"] = SourceExpressionConverter.ConvertToken(bodycustom3);
                    bodypropCount++;
                }

                if (bodycustom4 != null)
                {
                    body["custom4"] = SourceExpressionConverter.ConvertToken(bodycustom4);
                    bodypropCount++;
                }

                if (bodycustom5 != null)
                {
                    body["custom5"] = SourceExpressionConverter.ConvertToken(bodycustom5);
                    bodypropCount++;
                }

                if (bodycustom6 != null)
                {
                    body["custom6"] = SourceExpressionConverter.ConvertToken(bodycustom6);
                    bodypropCount++;
                }

                if (bodycustom7 != null)
                {
                    body["custom7"] = SourceExpressionConverter.ConvertToken(bodycustom7);
                    bodypropCount++;
                }

                if (bodycustom8 != null)
                {
                    body["custom8"] = SourceExpressionConverter.ConvertToken(bodycustom8);
                    bodypropCount++;
                }

                if (bodycustom9 != null)
                {
                    body["custom9"] = SourceExpressionConverter.ConvertToken(bodycustom9);
                    bodypropCount++;
                }

                if (bodycustom10 != null)
                {
                    body["custom10"] = SourceExpressionConverter.ConvertToken(bodycustom10);
                    bodypropCount++;
                }

                if (bodycustom11 != null)
                {
                    body["custom11"] = SourceExpressionConverter.ConvertToken(bodycustom11);
                    bodypropCount++;
                }

                if (bodycustom12 != null)
                {
                    body["custom12"] = SourceExpressionConverter.ConvertToken(bodycustom12);
                    bodypropCount++;
                }

                if (bodycustom13 != null)
                {
                    body["custom13"] = SourceExpressionConverter.ConvertToken(bodycustom13);
                    bodypropCount++;
                }

                if (bodycustom14 != null)
                {
                    body["custom14"] = SourceExpressionConverter.ConvertToken(bodycustom14);
                    bodypropCount++;
                }

                if (bodycustom15 != null)
                {
                    body["custom15"] = SourceExpressionConverter.ConvertToken(bodycustom15);
                    bodypropCount++;
                }

                if (bodycustom16 != null)
                {
                    body["custom16"] = SourceExpressionConverter.ConvertToken(bodycustom16);
                    bodypropCount++;
                }

                if (bodycustom17 != null)
                {
                    body["custom17"] = SourceExpressionConverter.ConvertToken(bodycustom17);
                    bodypropCount++;
                }

                if (bodycustom18 != null)
                {
                    body["custom18"] = SourceExpressionConverter.ConvertToken(bodycustom18);
                    bodypropCount++;
                }

                if (bodycustom19 != null)
                {
                    body["custom19"] = SourceExpressionConverter.ConvertToken(bodycustom19);
                    bodypropCount++;
                }

                if (bodycustom20 != null)
                {
                    body["custom20"] = SourceExpressionConverter.ConvertToken(bodycustom20);
                    bodypropCount++;
                }

                if (bodycustom21 != null)
                {
                    body["custom21"] = SourceExpressionConverter.ConvertToken(bodycustom21);
                    bodypropCount++;
                }

                if (bodycustom22 != null)
                {
                    body["custom22"] = SourceExpressionConverter.ConvertToken(bodycustom22);
                    bodypropCount++;
                }

                if (bodycustom23 != null)
                {
                    body["custom23"] = SourceExpressionConverter.ConvertToken(bodycustom23);
                    bodypropCount++;
                }

                if (bodycustom24 != null)
                {
                    body["custom24"] = SourceExpressionConverter.ConvertToken(bodycustom24);
                    bodypropCount++;
                }

                if (bodycustom25 != null)
                {
                    body["custom25"] = SourceExpressionConverter.ConvertToken(bodycustom25);
                    bodypropCount++;
                }

                if (bodycustom26 != null)
                {
                    body["custom26"] = SourceExpressionConverter.ConvertToken(bodycustom26);
                    bodypropCount++;
                }

                if (bodycustom27 != null)
                {
                    body["custom27"] = SourceExpressionConverter.ConvertToken(bodycustom27);
                    bodypropCount++;
                }

                if (bodycustom28 != null)
                {
                    body["custom28"] = SourceExpressionConverter.ConvertToken(bodycustom28);
                    bodypropCount++;
                }

                if (bodycustom29 != null)
                {
                    body["custom29"] = SourceExpressionConverter.ConvertToken(bodycustom29);
                    bodypropCount++;
                }

                if (bodycustom30 != null)
                {
                    body["custom30"] = SourceExpressionConverter.ConvertToken(bodycustom30);
                    bodypropCount++;
                }

                if (bodyisExternalAsNormal != null)
                {
                    body["is_external_as_normal"] = SourceExpressionConverter.ConvertToken(bodyisExternalAsNormal);
                    bodypropCount++;
                }

                if (bodyprojectCustom1 != null)
                {
                    body["project_custom1"] = SourceExpressionConverter.ConvertToken(bodyprojectCustom1);
                    bodypropCount++;
                }

                if (bodyprojectCustom2 != null)
                {
                    body["project_custom2"] = SourceExpressionConverter.ConvertToken(bodyprojectCustom2);
                    bodypropCount++;
                }

                if (bodyprojectCustom3 != null)
                {
                    body["project_custom3"] = SourceExpressionConverter.ConvertToken(bodyprojectCustom3);
                    bodypropCount++;
                }

                if (bodysubclass != null)
                {
                    body["subclass"] = SourceExpressionConverter.ConvertToken(bodysubclass);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<WorkspaceProfileResponseBody>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagework")]
        public IBodyWorkflowAction<WorkspaceProfileResponseBody> UpdateWorkspace([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodyowner = null, [WorkflowExpression] Func<string> bodycustom1 = null, [WorkflowExpression] Func<string> bodycustom2 = null, [WorkflowExpression] Func<string> bodycustom3 = null, [WorkflowExpression] Func<string> bodycustom4 = null, [WorkflowExpression] Func<string> bodycustom5 = null, [WorkflowExpression] Func<string> bodycustom6 = null, [WorkflowExpression] Func<string> bodycustom7 = null, [WorkflowExpression] Func<string> bodycustom8 = null, [WorkflowExpression] Func<string> bodycustom9 = null, [WorkflowExpression] Func<string> bodycustom10 = null, [WorkflowExpression] Func<string> bodycustom11 = null, [WorkflowExpression] Func<string> bodycustom12 = null, [WorkflowExpression] Func<string> bodycustom13 = null, [WorkflowExpression] Func<string> bodycustom14 = null, [WorkflowExpression] Func<string> bodycustom15 = null, [WorkflowExpression] Func<string> bodycustom16 = null, [WorkflowExpression] Func<double> bodycustom17 = null, [WorkflowExpression] Func<double> bodycustom18 = null, [WorkflowExpression] Func<double> bodycustom19 = null, [WorkflowExpression] Func<double> bodycustom20 = null, [WorkflowExpression] Func<string> bodycustom21 = null, [WorkflowExpression] Func<string> bodycustom22 = null, [WorkflowExpression] Func<string> bodycustom23 = null, [WorkflowExpression] Func<string> bodycustom24 = null, [WorkflowExpression] Func<bool> bodycustom25 = null, [WorkflowExpression] Func<bool> bodycustom26 = null, [WorkflowExpression] Func<bool> bodycustom27 = null, [WorkflowExpression] Func<bool> bodycustom28 = null, [WorkflowExpression] Func<string> bodycustom29 = null, [WorkflowExpression] Func<string> bodycustom30 = null, [WorkflowExpression] Func<bodydefaultSecurityInput> bodydefaultSecurity = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<bool> bodyisExternalAsNormal = null, [WorkflowExpression] Func<string> bodyprojectCustom1 = null, [WorkflowExpression] Func<string> bodyprojectCustom2 = null, [WorkflowExpression] Func<string> bodyprojectCustom3 = null, [WorkflowExpression] Func<string> bodysubclass = null)
        {
            SourceExpression.Validate(bodyid, nameof(bodyid), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodyowner, nameof(bodyowner), required: false);
            SourceExpression.Validate(bodycustom1, nameof(bodycustom1), required: false);
            SourceExpression.Validate(bodycustom2, nameof(bodycustom2), required: false);
            SourceExpression.Validate(bodycustom3, nameof(bodycustom3), required: false);
            SourceExpression.Validate(bodycustom4, nameof(bodycustom4), required: false);
            SourceExpression.Validate(bodycustom5, nameof(bodycustom5), required: false);
            SourceExpression.Validate(bodycustom6, nameof(bodycustom6), required: false);
            SourceExpression.Validate(bodycustom7, nameof(bodycustom7), required: false);
            SourceExpression.Validate(bodycustom8, nameof(bodycustom8), required: false);
            SourceExpression.Validate(bodycustom9, nameof(bodycustom9), required: false);
            SourceExpression.Validate(bodycustom10, nameof(bodycustom10), required: false);
            SourceExpression.Validate(bodycustom11, nameof(bodycustom11), required: false);
            SourceExpression.Validate(bodycustom12, nameof(bodycustom12), required: false);
            SourceExpression.Validate(bodycustom13, nameof(bodycustom13), required: false);
            SourceExpression.Validate(bodycustom14, nameof(bodycustom14), required: false);
            SourceExpression.Validate(bodycustom15, nameof(bodycustom15), required: false);
            SourceExpression.Validate(bodycustom16, nameof(bodycustom16), required: false);
            SourceExpression.Validate(bodycustom17, nameof(bodycustom17), required: false);
            SourceExpression.Validate(bodycustom18, nameof(bodycustom18), required: false);
            SourceExpression.Validate(bodycustom19, nameof(bodycustom19), required: false);
            SourceExpression.Validate(bodycustom20, nameof(bodycustom20), required: false);
            SourceExpression.Validate(bodycustom21, nameof(bodycustom21), required: false);
            SourceExpression.Validate(bodycustom22, nameof(bodycustom22), required: false);
            SourceExpression.Validate(bodycustom23, nameof(bodycustom23), required: false);
            SourceExpression.Validate(bodycustom24, nameof(bodycustom24), required: false);
            SourceExpression.Validate(bodycustom25, nameof(bodycustom25), required: false);
            SourceExpression.Validate(bodycustom26, nameof(bodycustom26), required: false);
            SourceExpression.Validate(bodycustom27, nameof(bodycustom27), required: false);
            SourceExpression.Validate(bodycustom28, nameof(bodycustom28), required: false);
            SourceExpression.Validate(bodycustom29, nameof(bodycustom29), required: false);
            SourceExpression.Validate(bodycustom30, nameof(bodycustom30), required: false);
            SourceExpression.Validate(bodydefaultSecurity, nameof(bodydefaultSecurity), required: false);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            SourceExpression.Validate(bodyisExternalAsNormal, nameof(bodyisExternalAsNormal), required: false);
            SourceExpression.Validate(bodyprojectCustom1, nameof(bodyprojectCustom1), required: false);
            SourceExpression.Validate(bodyprojectCustom2, nameof(bodyprojectCustom2), required: false);
            SourceExpression.Validate(bodyprojectCustom3, nameof(bodyprojectCustom3), required: false);
            SourceExpression.Validate(bodysubclass, nameof(bodysubclass), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/updateWorkspace";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodyowner != null)
                {
                    body["owner"] = SourceExpressionConverter.ConvertToken(bodyowner);
                    bodypropCount++;
                }

                if (bodycustom1 != null)
                {
                    body["custom1"] = SourceExpressionConverter.ConvertToken(bodycustom1);
                    bodypropCount++;
                }

                if (bodycustom2 != null)
                {
                    body["custom2"] = SourceExpressionConverter.ConvertToken(bodycustom2);
                    bodypropCount++;
                }

                if (bodycustom3 != null)
                {
                    body["custom3"] = SourceExpressionConverter.ConvertToken(bodycustom3);
                    bodypropCount++;
                }

                if (bodycustom4 != null)
                {
                    body["custom4"] = SourceExpressionConverter.ConvertToken(bodycustom4);
                    bodypropCount++;
                }

                if (bodycustom5 != null)
                {
                    body["custom5"] = SourceExpressionConverter.ConvertToken(bodycustom5);
                    bodypropCount++;
                }

                if (bodycustom6 != null)
                {
                    body["custom6"] = SourceExpressionConverter.ConvertToken(bodycustom6);
                    bodypropCount++;
                }

                if (bodycustom7 != null)
                {
                    body["custom7"] = SourceExpressionConverter.ConvertToken(bodycustom7);
                    bodypropCount++;
                }

                if (bodycustom8 != null)
                {
                    body["custom8"] = SourceExpressionConverter.ConvertToken(bodycustom8);
                    bodypropCount++;
                }

                if (bodycustom9 != null)
                {
                    body["custom9"] = SourceExpressionConverter.ConvertToken(bodycustom9);
                    bodypropCount++;
                }

                if (bodycustom10 != null)
                {
                    body["custom10"] = SourceExpressionConverter.ConvertToken(bodycustom10);
                    bodypropCount++;
                }

                if (bodycustom11 != null)
                {
                    body["custom11"] = SourceExpressionConverter.ConvertToken(bodycustom11);
                    bodypropCount++;
                }

                if (bodycustom12 != null)
                {
                    body["custom12"] = SourceExpressionConverter.ConvertToken(bodycustom12);
                    bodypropCount++;
                }

                if (bodycustom13 != null)
                {
                    body["custom13"] = SourceExpressionConverter.ConvertToken(bodycustom13);
                    bodypropCount++;
                }

                if (bodycustom14 != null)
                {
                    body["custom14"] = SourceExpressionConverter.ConvertToken(bodycustom14);
                    bodypropCount++;
                }

                if (bodycustom15 != null)
                {
                    body["custom15"] = SourceExpressionConverter.ConvertToken(bodycustom15);
                    bodypropCount++;
                }

                if (bodycustom16 != null)
                {
                    body["custom16"] = SourceExpressionConverter.ConvertToken(bodycustom16);
                    bodypropCount++;
                }

                if (bodycustom17 != null)
                {
                    body["custom17"] = SourceExpressionConverter.ConvertToken(bodycustom17);
                    bodypropCount++;
                }

                if (bodycustom18 != null)
                {
                    body["custom18"] = SourceExpressionConverter.ConvertToken(bodycustom18);
                    bodypropCount++;
                }

                if (bodycustom19 != null)
                {
                    body["custom19"] = SourceExpressionConverter.ConvertToken(bodycustom19);
                    bodypropCount++;
                }

                if (bodycustom20 != null)
                {
                    body["custom20"] = SourceExpressionConverter.ConvertToken(bodycustom20);
                    bodypropCount++;
                }

                if (bodycustom21 != null)
                {
                    body["custom21"] = SourceExpressionConverter.ConvertToken(bodycustom21);
                    bodypropCount++;
                }

                if (bodycustom22 != null)
                {
                    body["custom22"] = SourceExpressionConverter.ConvertToken(bodycustom22);
                    bodypropCount++;
                }

                if (bodycustom23 != null)
                {
                    body["custom23"] = SourceExpressionConverter.ConvertToken(bodycustom23);
                    bodypropCount++;
                }

                if (bodycustom24 != null)
                {
                    body["custom24"] = SourceExpressionConverter.ConvertToken(bodycustom24);
                    bodypropCount++;
                }

                if (bodycustom25 != null)
                {
                    body["custom25"] = SourceExpressionConverter.ConvertToken(bodycustom25);
                    bodypropCount++;
                }

                if (bodycustom26 != null)
                {
                    body["custom26"] = SourceExpressionConverter.ConvertToken(bodycustom26);
                    bodypropCount++;
                }

                if (bodycustom27 != null)
                {
                    body["custom27"] = SourceExpressionConverter.ConvertToken(bodycustom27);
                    bodypropCount++;
                }

                if (bodycustom28 != null)
                {
                    body["custom28"] = SourceExpressionConverter.ConvertToken(bodycustom28);
                    bodypropCount++;
                }

                if (bodycustom29 != null)
                {
                    body["custom29"] = SourceExpressionConverter.ConvertToken(bodycustom29);
                    bodypropCount++;
                }

                if (bodycustom30 != null)
                {
                    body["custom30"] = SourceExpressionConverter.ConvertToken(bodycustom30);
                    bodypropCount++;
                }

                if (bodydefaultSecurity != null)
                {
                    body["default_security"] = SourceExpressionConverter.Convert(bodydefaultSecurity);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodyisExternalAsNormal != null)
                {
                    body["is_external_as_normal"] = SourceExpressionConverter.ConvertToken(bodyisExternalAsNormal);
                    bodypropCount++;
                }

                if (bodyprojectCustom1 != null)
                {
                    body["project_custom1"] = SourceExpressionConverter.ConvertToken(bodyprojectCustom1);
                    bodypropCount++;
                }

                if (bodyprojectCustom2 != null)
                {
                    body["project_custom2"] = SourceExpressionConverter.ConvertToken(bodyprojectCustom2);
                    bodypropCount++;
                }

                if (bodyprojectCustom3 != null)
                {
                    body["project_custom3"] = SourceExpressionConverter.ConvertToken(bodyprojectCustom3);
                    bodypropCount++;
                }

                if (bodysubclass != null)
                {
                    body["subclass"] = SourceExpressionConverter.ConvertToken(bodysubclass);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<WorkspaceProfileResponseBody>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagework")]
        public IBodyWorkflowAction<GetClassesResponse> GetClasses([WorkflowExpression] Func<string> libraryId, [WorkflowExpression] Func<string> alias = null, [WorkflowExpression] Func<defaultSecurityInput> defaultSecurity = null, [WorkflowExpression] Func<string> description = null, [WorkflowExpression] Func<bool> echo = null, [WorkflowExpression] Func<bool> hipaa = null, [WorkflowExpression] Func<bool> indexable = null, [WorkflowExpression] Func<string> query = null, [WorkflowExpression] Func<bool> subclassRequired = null)
        {
            SourceExpression.Validate(libraryId, nameof(libraryId), required: true);
            SourceExpression.Validate(alias, nameof(alias), required: false);
            SourceExpression.Validate(defaultSecurity, nameof(defaultSecurity), required: false);
            SourceExpression.Validate(description, nameof(description), required: false);
            SourceExpression.Validate(echo, nameof(echo), required: false);
            SourceExpression.Validate(hipaa, nameof(hipaa), required: false);
            SourceExpression.Validate(indexable, nameof(indexable), required: false);
            SourceExpression.Validate(query, nameof(query), required: false);
            SourceExpression.Validate(subclassRequired, nameof(subclassRequired), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/getClasses";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["libraryId"] = SourceExpressionConverter.ConvertO(libraryId);
                if (alias != null)
                    callPayload.Queries["alias"] = SourceExpressionConverter.ConvertO(alias);
                if (defaultSecurity != null)
                    callPayload.Queries["default_security"] = SourceExpressionConverter.Convert(defaultSecurity);
                if (description != null)
                    callPayload.Queries["description"] = SourceExpressionConverter.ConvertO(description);
                if (echo != null)
                    callPayload.Queries["echo"] = SourceExpressionConverter.ConvertO(echo);
                if (hipaa != null)
                    callPayload.Queries["hipaa"] = SourceExpressionConverter.ConvertO(hipaa);
                if (indexable != null)
                    callPayload.Queries["indexable"] = SourceExpressionConverter.ConvertO(indexable);
                if (query != null)
                    callPayload.Queries["query"] = SourceExpressionConverter.ConvertO(query);
                if (subclassRequired != null)
                    callPayload.Queries["subclass_required"] = SourceExpressionConverter.ConvertO(subclassRequired);
                return callPayload;
            }

            return new ApiConnectionAction<GetClassesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagework")]
        public IBodyWorkflowAction<GetSubclassesResponse> GetSubclasses([WorkflowExpression] Func<string> libraryId, [WorkflowExpression] Func<string> classId, [WorkflowExpression] Func<string> alias = null, [WorkflowExpression] Func<defaultSecurityInput> defaultSecurity = null, [WorkflowExpression] Func<string> description = null, [WorkflowExpression] Func<bool> echo = null, [WorkflowExpression] Func<bool> hipaa = null, [WorkflowExpression] Func<string> query = null)
        {
            SourceExpression.Validate(libraryId, nameof(libraryId), required: true);
            SourceExpression.Validate(classId, nameof(classId), required: true);
            SourceExpression.Validate(alias, nameof(alias), required: false);
            SourceExpression.Validate(defaultSecurity, nameof(defaultSecurity), required: false);
            SourceExpression.Validate(description, nameof(description), required: false);
            SourceExpression.Validate(echo, nameof(echo), required: false);
            SourceExpression.Validate(hipaa, nameof(hipaa), required: false);
            SourceExpression.Validate(query, nameof(query), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/getSubclasses";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["libraryId"] = SourceExpressionConverter.ConvertO(libraryId);
                callPayload.Queries["classId"] = SourceExpressionConverter.ConvertO(classId);
                if (alias != null)
                    callPayload.Queries["alias"] = SourceExpressionConverter.ConvertO(alias);
                if (defaultSecurity != null)
                    callPayload.Queries["default_security"] = SourceExpressionConverter.Convert(defaultSecurity);
                if (description != null)
                    callPayload.Queries["description"] = SourceExpressionConverter.ConvertO(description);
                if (echo != null)
                    callPayload.Queries["echo"] = SourceExpressionConverter.ConvertO(echo);
                if (hipaa != null)
                    callPayload.Queries["hipaa"] = SourceExpressionConverter.ConvertO(hipaa);
                if (query != null)
                    callPayload.Queries["query"] = SourceExpressionConverter.ConvertO(query);
                return callPayload;
            }

            return new ApiConnectionAction<GetSubclassesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagework")]
        public IBodyWorkflowAction<WorkspaceTemplatesResponseBody> GetWorkspaceTemplates([WorkflowExpression] Func<string> libraryId, [WorkflowExpression] Func<string> custom1 = null, [WorkflowExpression] Func<string> custom2 = null, [WorkflowExpression] Func<string> custom3 = null, [WorkflowExpression] Func<string> custom4 = null, [WorkflowExpression] Func<string> custom5 = null, [WorkflowExpression] Func<string> custom6 = null, [WorkflowExpression] Func<string> custom7 = null, [WorkflowExpression] Func<string> custom8 = null, [WorkflowExpression] Func<string> custom9 = null, [WorkflowExpression] Func<string> custom10 = null, [WorkflowExpression] Func<string> custom11 = null, [WorkflowExpression] Func<string> custom12 = null, [WorkflowExpression] Func<double> custom17 = null, [WorkflowExpression] Func<double> custom18 = null, [WorkflowExpression] Func<double> custom19 = null, [WorkflowExpression] Func<double> custom20 = null, [WorkflowExpression] Func<string> custom21 = null, [WorkflowExpression] Func<string> custom22 = null, [WorkflowExpression] Func<string> custom23 = null, [WorkflowExpression] Func<string> custom24 = null, [WorkflowExpression] Func<string> custom21From = null, [WorkflowExpression] Func<string> custom21To = null, [WorkflowExpression] Func<string> custom21Relative = null, [WorkflowExpression] Func<string> custom22From = null, [WorkflowExpression] Func<string> custom22To = null, [WorkflowExpression] Func<string> custom22Relative = null, [WorkflowExpression] Func<string> custom23From = null, [WorkflowExpression] Func<string> custom23To = null, [WorkflowExpression] Func<string> custom23Relative = null, [WorkflowExpression] Func<string> custom24From = null, [WorkflowExpression] Func<string> custom24To = null, [WorkflowExpression] Func<string> custom24Relative = null, [WorkflowExpression] Func<bool> custom25 = null, [WorkflowExpression] Func<bool> custom26 = null, [WorkflowExpression] Func<bool> custom27 = null, [WorkflowExpression] Func<bool> custom28 = null, [WorkflowExpression] Func<string> custom29 = null, [WorkflowExpression] Func<string> custom30 = null)
        {
            SourceExpression.Validate(libraryId, nameof(libraryId), required: true);
            SourceExpression.Validate(custom1, nameof(custom1), required: false);
            SourceExpression.Validate(custom2, nameof(custom2), required: false);
            SourceExpression.Validate(custom3, nameof(custom3), required: false);
            SourceExpression.Validate(custom4, nameof(custom4), required: false);
            SourceExpression.Validate(custom5, nameof(custom5), required: false);
            SourceExpression.Validate(custom6, nameof(custom6), required: false);
            SourceExpression.Validate(custom7, nameof(custom7), required: false);
            SourceExpression.Validate(custom8, nameof(custom8), required: false);
            SourceExpression.Validate(custom9, nameof(custom9), required: false);
            SourceExpression.Validate(custom10, nameof(custom10), required: false);
            SourceExpression.Validate(custom11, nameof(custom11), required: false);
            SourceExpression.Validate(custom12, nameof(custom12), required: false);
            SourceExpression.Validate(custom17, nameof(custom17), required: false);
            SourceExpression.Validate(custom18, nameof(custom18), required: false);
            SourceExpression.Validate(custom19, nameof(custom19), required: false);
            SourceExpression.Validate(custom20, nameof(custom20), required: false);
            SourceExpression.Validate(custom21, nameof(custom21), required: false);
            SourceExpression.Validate(custom22, nameof(custom22), required: false);
            SourceExpression.Validate(custom23, nameof(custom23), required: false);
            SourceExpression.Validate(custom24, nameof(custom24), required: false);
            SourceExpression.Validate(custom21From, nameof(custom21From), required: false);
            SourceExpression.Validate(custom21To, nameof(custom21To), required: false);
            SourceExpression.Validate(custom21Relative, nameof(custom21Relative), required: false);
            SourceExpression.Validate(custom22From, nameof(custom22From), required: false);
            SourceExpression.Validate(custom22To, nameof(custom22To), required: false);
            SourceExpression.Validate(custom22Relative, nameof(custom22Relative), required: false);
            SourceExpression.Validate(custom23From, nameof(custom23From), required: false);
            SourceExpression.Validate(custom23To, nameof(custom23To), required: false);
            SourceExpression.Validate(custom23Relative, nameof(custom23Relative), required: false);
            SourceExpression.Validate(custom24From, nameof(custom24From), required: false);
            SourceExpression.Validate(custom24To, nameof(custom24To), required: false);
            SourceExpression.Validate(custom24Relative, nameof(custom24Relative), required: false);
            SourceExpression.Validate(custom25, nameof(custom25), required: false);
            SourceExpression.Validate(custom26, nameof(custom26), required: false);
            SourceExpression.Validate(custom27, nameof(custom27), required: false);
            SourceExpression.Validate(custom28, nameof(custom28), required: false);
            SourceExpression.Validate(custom29, nameof(custom29), required: false);
            SourceExpression.Validate(custom30, nameof(custom30), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/getWorkspaceTemplates";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["libraryId"] = SourceExpressionConverter.ConvertO(libraryId);
                if (custom1 != null)
                    callPayload.Queries["custom1"] = SourceExpressionConverter.ConvertO(custom1);
                if (custom2 != null)
                    callPayload.Queries["custom2"] = SourceExpressionConverter.ConvertO(custom2);
                if (custom3 != null)
                    callPayload.Queries["custom3"] = SourceExpressionConverter.ConvertO(custom3);
                if (custom4 != null)
                    callPayload.Queries["custom4"] = SourceExpressionConverter.ConvertO(custom4);
                if (custom5 != null)
                    callPayload.Queries["custom5"] = SourceExpressionConverter.ConvertO(custom5);
                if (custom6 != null)
                    callPayload.Queries["custom6"] = SourceExpressionConverter.ConvertO(custom6);
                if (custom7 != null)
                    callPayload.Queries["custom7"] = SourceExpressionConverter.ConvertO(custom7);
                if (custom8 != null)
                    callPayload.Queries["custom8"] = SourceExpressionConverter.ConvertO(custom8);
                if (custom9 != null)
                    callPayload.Queries["custom9"] = SourceExpressionConverter.ConvertO(custom9);
                if (custom10 != null)
                    callPayload.Queries["custom10"] = SourceExpressionConverter.ConvertO(custom10);
                if (custom11 != null)
                    callPayload.Queries["custom11"] = SourceExpressionConverter.ConvertO(custom11);
                if (custom12 != null)
                    callPayload.Queries["custom12"] = SourceExpressionConverter.ConvertO(custom12);
                if (custom17 != null)
                    callPayload.Queries["custom17"] = SourceExpressionConverter.ConvertO(custom17);
                if (custom18 != null)
                    callPayload.Queries["custom18"] = SourceExpressionConverter.ConvertO(custom18);
                if (custom19 != null)
                    callPayload.Queries["custom19"] = SourceExpressionConverter.ConvertO(custom19);
                if (custom20 != null)
                    callPayload.Queries["custom20"] = SourceExpressionConverter.ConvertO(custom20);
                if (custom21 != null)
                    callPayload.Queries["custom21"] = SourceExpressionConverter.ConvertO(custom21);
                if (custom22 != null)
                    callPayload.Queries["custom22"] = SourceExpressionConverter.ConvertO(custom22);
                if (custom23 != null)
                    callPayload.Queries["custom23"] = SourceExpressionConverter.ConvertO(custom23);
                if (custom24 != null)
                    callPayload.Queries["custom24"] = SourceExpressionConverter.ConvertO(custom24);
                if (custom21From != null)
                    callPayload.Queries["custom21_from"] = SourceExpressionConverter.ConvertO(custom21From);
                if (custom21To != null)
                    callPayload.Queries["custom21_to"] = SourceExpressionConverter.ConvertO(custom21To);
                if (custom21Relative != null)
                    callPayload.Queries["custom21_relative"] = SourceExpressionConverter.ConvertO(custom21Relative);
                if (custom22From != null)
                    callPayload.Queries["custom22_from"] = SourceExpressionConverter.ConvertO(custom22From);
                if (custom22To != null)
                    callPayload.Queries["custom22_to"] = SourceExpressionConverter.ConvertO(custom22To);
                if (custom22Relative != null)
                    callPayload.Queries["custom22_relative"] = SourceExpressionConverter.ConvertO(custom22Relative);
                if (custom23From != null)
                    callPayload.Queries["custom23_from"] = SourceExpressionConverter.ConvertO(custom23From);
                if (custom23To != null)
                    callPayload.Queries["custom23_to"] = SourceExpressionConverter.ConvertO(custom23To);
                if (custom23Relative != null)
                    callPayload.Queries["custom23_relative"] = SourceExpressionConverter.ConvertO(custom23Relative);
                if (custom24From != null)
                    callPayload.Queries["custom24_from"] = SourceExpressionConverter.ConvertO(custom24From);
                if (custom24To != null)
                    callPayload.Queries["custom24_to"] = SourceExpressionConverter.ConvertO(custom24To);
                if (custom24Relative != null)
                    callPayload.Queries["custom24_relative"] = SourceExpressionConverter.ConvertO(custom24Relative);
                if (custom25 != null)
                    callPayload.Queries["custom25"] = SourceExpressionConverter.ConvertO(custom25);
                if (custom26 != null)
                    callPayload.Queries["custom26"] = SourceExpressionConverter.ConvertO(custom26);
                if (custom27 != null)
                    callPayload.Queries["custom27"] = SourceExpressionConverter.ConvertO(custom27);
                if (custom28 != null)
                    callPayload.Queries["custom28"] = SourceExpressionConverter.ConvertO(custom28);
                if (custom29 != null)
                    callPayload.Queries["custom29"] = SourceExpressionConverter.ConvertO(custom29);
                if (custom30 != null)
                    callPayload.Queries["custom30"] = SourceExpressionConverter.ConvertO(custom30);
                return callPayload;
            }

            return new ApiConnectionAction<WorkspaceTemplatesResponseBody>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagework")]
        public IWorkflowAction EditNVP([WorkflowExpression] Func<bodyobjectTypeInput> bodyobjectType, [WorkflowExpression] Func<string> bodyobjectId)
        {
            SourceExpression.Validate(bodyobjectType, nameof(bodyobjectType), required: true);
            SourceExpression.Validate(bodyobjectId, nameof(bodyobjectId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/editNVP";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["objectType"] = SourceExpressionConverter.Convert(bodyobjectType);
                bodypropCount++;
                body["objectId"] = SourceExpressionConverter.ConvertToken(bodyobjectId);
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
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagework")]
        public IBodyWorkflowAction<SearchFoldersResponseBody> SearchFolders([WorkflowExpression] Func<string> bodylibraryId, [WorkflowExpression] Func<string> bodycontainerId = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodyemail = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodyowner = null, [WorkflowExpression] Func<string> bodyworkspaceName = null)
        {
            SourceExpression.Validate(bodylibraryId, nameof(bodylibraryId), required: true);
            SourceExpression.Validate(bodycontainerId, nameof(bodycontainerId), required: false);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            SourceExpression.Validate(bodyemail, nameof(bodyemail), required: false);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodyowner, nameof(bodyowner), required: false);
            SourceExpression.Validate(bodyworkspaceName, nameof(bodyworkspaceName), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/searchFolders";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["libraryId"] = SourceExpressionConverter.ConvertToken(bodylibraryId);
                if (bodycontainerId != null)
                {
                    body["container_id"] = SourceExpressionConverter.ConvertToken(bodycontainerId);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodyemail != null)
                {
                    body["email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodyowner != null)
                {
                    body["owner"] = SourceExpressionConverter.ConvertToken(bodyowner);
                    bodypropCount++;
                }

                if (bodyworkspaceName != null)
                {
                    body["workspace_name"] = SourceExpressionConverter.ConvertToken(bodyworkspaceName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SearchFoldersResponseBody>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagework")]
        public IBodyWorkflowAction<string> DownloadDocument([WorkflowExpression] Func<string> bodydocumentId, [WorkflowExpression] Func<bool> bodylatest = null)
        {
            SourceExpression.Validate(bodydocumentId, nameof(bodydocumentId), required: true);
            SourceExpression.Validate(bodylatest, nameof(bodylatest), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/downloadDocument";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["documentId"] = SourceExpressionConverter.ConvertToken(bodydocumentId);
                if (bodylatest != null)
                {
                    if (bodylatest != null)
                    {
                        body["latest"] = SourceExpressionConverter.ConvertToken(bodylatest);
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
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagework")]
        public IBodyWorkflowAction<GetUserDetailsResponse> GetUserDetails([WorkflowExpression] Func<string> bodylibraryId, [WorkflowExpression] Func<string> bodyuserId)
        {
            SourceExpression.Validate(bodylibraryId, nameof(bodylibraryId), required: true);
            SourceExpression.Validate(bodyuserId, nameof(bodyuserId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/getUserDetails";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["libraryId"] = SourceExpressionConverter.ConvertToken(bodylibraryId);
                bodypropCount++;
                body["userId"] = SourceExpressionConverter.ConvertToken(bodyuserId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GetUserDetailsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagework")]
        public IBodyWorkflowAction<WorkspaceProfileResponseBody> GetWorkspaceProfile([WorkflowExpression] Func<string> bodyworkspaceId)
        {
            SourceExpression.Validate(bodyworkspaceId, nameof(bodyworkspaceId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/getWorkspaceProfile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["workspaceId"] = SourceExpressionConverter.ConvertToken(bodyworkspaceId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<WorkspaceProfileResponseBody>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagework")]
        public IBodyWorkflowAction<GetContainerChildrenResponse> GetContainerChildren([WorkflowExpression] Func<string> bodycontainerId, [WorkflowExpression] Func<string> bodycursor = null)
        {
            SourceExpression.Validate(bodycontainerId, nameof(bodycontainerId), required: true);
            SourceExpression.Validate(bodycursor, nameof(bodycursor), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/getContainerChildren";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["containerId"] = SourceExpressionConverter.ConvertToken(bodycontainerId);
                if (bodycursor != null)
                {
                    body["cursor"] = SourceExpressionConverter.ConvertToken(bodycursor);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GetContainerChildrenResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagework")]
        public IBodyWorkflowAction<GetContainerProfileResponseBody> GetContainerProfile([WorkflowExpression] Func<string> bodycontainerId)
        {
            SourceExpression.Validate(bodycontainerId, nameof(bodycontainerId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/getContainerProfile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["containerId"] = SourceExpressionConverter.ConvertToken(bodycontainerId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GetContainerProfileResponseBody>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagework")]
        public IBodyWorkflowAction<GetLibrariesResponse> GetLibraries()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/getLibraries";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["showAllLibraries"] = Convert.ToString(false);
                callPayload.Queries["hidePreferredLibrary"] = Convert.ToString(false);
                return callPayload;
            }

            return new ApiConnectionAction<GetLibrariesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagework")]
        public IBodyWorkflowAction<FullDocumentProfileResponseBody> GetDocumentProfile([WorkflowExpression] Func<string> bodydocumentId, [WorkflowExpression] Func<bool> bodylatest = null)
        {
            SourceExpression.Validate(bodydocumentId, nameof(bodydocumentId), required: true);
            SourceExpression.Validate(bodylatest, nameof(bodylatest), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/getDocumentProfile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["documentId"] = SourceExpressionConverter.ConvertToken(bodydocumentId);
                if (bodylatest != null)
                {
                    if (bodylatest != null)
                    {
                        body["latest"] = SourceExpressionConverter.ConvertToken(bodylatest);
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
                return callPayload;
            }

            return new ApiConnectionAction<FullDocumentProfileResponseBody>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagework")]
        public IBodyWorkflowAction<ShortDocumentProfileResponseBody> UpdateDocumentProfile([WorkflowExpression] Func<string> bodydocumentId, [WorkflowExpression] Func<string> bodyalias = null, [WorkflowExpression] Func<string> bodyauthor = null, [WorkflowExpression] Func<string> bodycomment = null, [WorkflowExpression] Func<bodydefaultSecurityInput> bodydefaultSecurity = null, [WorkflowExpression] Func<bool> bodyisDeclared = null, [WorkflowExpression] Func<bool> bodyisHipaa = null, [WorkflowExpression] Func<string> bodyauditComment = null, [WorkflowExpression] Func<string> bodyClass = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodyOperator = null, [WorkflowExpression] Func<int> bodyretainDays = null, [WorkflowExpression] Func<string> bodysubclass = null, [WorkflowExpression] Func<string> bodycustom1 = null, [WorkflowExpression] Func<string> bodycustom2 = null, [WorkflowExpression] Func<string> bodycustom3 = null, [WorkflowExpression] Func<string> bodycustom4 = null, [WorkflowExpression] Func<string> bodycustom5 = null, [WorkflowExpression] Func<string> bodycustom6 = null, [WorkflowExpression] Func<string> bodycustom7 = null, [WorkflowExpression] Func<string> bodycustom8 = null, [WorkflowExpression] Func<string> bodycustom9 = null, [WorkflowExpression] Func<string> bodycustom10 = null, [WorkflowExpression] Func<string> bodycustom11 = null, [WorkflowExpression] Func<string> bodycustom12 = null, [WorkflowExpression] Func<string> bodycustom13 = null, [WorkflowExpression] Func<string> bodycustom14 = null, [WorkflowExpression] Func<string> bodycustom15 = null, [WorkflowExpression] Func<string> bodycustom16 = null, [WorkflowExpression] Func<double> bodycustom17 = null, [WorkflowExpression] Func<double> bodycustom18 = null, [WorkflowExpression] Func<double> bodycustom19 = null, [WorkflowExpression] Func<double> bodycustom20 = null, [WorkflowExpression] Func<string> bodycustom21 = null, [WorkflowExpression] Func<string> bodycustom22 = null, [WorkflowExpression] Func<string> bodycustom23 = null, [WorkflowExpression] Func<string> bodycustom24 = null, [WorkflowExpression] Func<bool> bodycustom25 = null, [WorkflowExpression] Func<bool> bodycustom26 = null, [WorkflowExpression] Func<bool> bodycustom27 = null, [WorkflowExpression] Func<bool> bodycustom28 = null, [WorkflowExpression] Func<string> bodycustom29 = null, [WorkflowExpression] Func<string> bodycustom30 = null)
        {
            SourceExpression.Validate(bodydocumentId, nameof(bodydocumentId), required: true);
            SourceExpression.Validate(bodyalias, nameof(bodyalias), required: false);
            SourceExpression.Validate(bodyauthor, nameof(bodyauthor), required: false);
            SourceExpression.Validate(bodycomment, nameof(bodycomment), required: false);
            SourceExpression.Validate(bodydefaultSecurity, nameof(bodydefaultSecurity), required: false);
            SourceExpression.Validate(bodyisDeclared, nameof(bodyisDeclared), required: false);
            SourceExpression.Validate(bodyisHipaa, nameof(bodyisHipaa), required: false);
            SourceExpression.Validate(bodyauditComment, nameof(bodyauditComment), required: false);
            SourceExpression.Validate(bodyClass, nameof(bodyClass), required: false);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodyOperator, nameof(bodyOperator), required: false);
            SourceExpression.Validate(bodyretainDays, nameof(bodyretainDays), required: false);
            SourceExpression.Validate(bodysubclass, nameof(bodysubclass), required: false);
            SourceExpression.Validate(bodycustom1, nameof(bodycustom1), required: false);
            SourceExpression.Validate(bodycustom2, nameof(bodycustom2), required: false);
            SourceExpression.Validate(bodycustom3, nameof(bodycustom3), required: false);
            SourceExpression.Validate(bodycustom4, nameof(bodycustom4), required: false);
            SourceExpression.Validate(bodycustom5, nameof(bodycustom5), required: false);
            SourceExpression.Validate(bodycustom6, nameof(bodycustom6), required: false);
            SourceExpression.Validate(bodycustom7, nameof(bodycustom7), required: false);
            SourceExpression.Validate(bodycustom8, nameof(bodycustom8), required: false);
            SourceExpression.Validate(bodycustom9, nameof(bodycustom9), required: false);
            SourceExpression.Validate(bodycustom10, nameof(bodycustom10), required: false);
            SourceExpression.Validate(bodycustom11, nameof(bodycustom11), required: false);
            SourceExpression.Validate(bodycustom12, nameof(bodycustom12), required: false);
            SourceExpression.Validate(bodycustom13, nameof(bodycustom13), required: false);
            SourceExpression.Validate(bodycustom14, nameof(bodycustom14), required: false);
            SourceExpression.Validate(bodycustom15, nameof(bodycustom15), required: false);
            SourceExpression.Validate(bodycustom16, nameof(bodycustom16), required: false);
            SourceExpression.Validate(bodycustom17, nameof(bodycustom17), required: false);
            SourceExpression.Validate(bodycustom18, nameof(bodycustom18), required: false);
            SourceExpression.Validate(bodycustom19, nameof(bodycustom19), required: false);
            SourceExpression.Validate(bodycustom20, nameof(bodycustom20), required: false);
            SourceExpression.Validate(bodycustom21, nameof(bodycustom21), required: false);
            SourceExpression.Validate(bodycustom22, nameof(bodycustom22), required: false);
            SourceExpression.Validate(bodycustom23, nameof(bodycustom23), required: false);
            SourceExpression.Validate(bodycustom24, nameof(bodycustom24), required: false);
            SourceExpression.Validate(bodycustom25, nameof(bodycustom25), required: false);
            SourceExpression.Validate(bodycustom26, nameof(bodycustom26), required: false);
            SourceExpression.Validate(bodycustom27, nameof(bodycustom27), required: false);
            SourceExpression.Validate(bodycustom28, nameof(bodycustom28), required: false);
            SourceExpression.Validate(bodycustom29, nameof(bodycustom29), required: false);
            SourceExpression.Validate(bodycustom30, nameof(bodycustom30), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/updateDocumentProfile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyalias != null)
                {
                    body["alias"] = SourceExpressionConverter.ConvertToken(bodyalias);
                    bodypropCount++;
                }

                if (bodyauthor != null)
                {
                    body["author"] = SourceExpressionConverter.ConvertToken(bodyauthor);
                    bodypropCount++;
                }

                if (bodycomment != null)
                {
                    body["comment"] = SourceExpressionConverter.ConvertToken(bodycomment);
                    bodypropCount++;
                }

                if (bodydefaultSecurity != null)
                {
                    body["default_security"] = SourceExpressionConverter.Convert(bodydefaultSecurity);
                    bodypropCount++;
                }

                bodypropCount++;
                body["documentId"] = SourceExpressionConverter.ConvertToken(bodydocumentId);
                if (bodyisDeclared != null)
                {
                    body["is_declared"] = SourceExpressionConverter.ConvertToken(bodyisDeclared);
                    bodypropCount++;
                }

                if (bodyisHipaa != null)
                {
                    body["is_hipaa"] = SourceExpressionConverter.ConvertToken(bodyisHipaa);
                    bodypropCount++;
                }

                if (bodyauditComment != null)
                {
                    body["audit_comment"] = SourceExpressionConverter.ConvertToken(bodyauditComment);
                    bodypropCount++;
                }

                if (bodyClass != null)
                {
                    body["class"] = SourceExpressionConverter.ConvertToken(bodyClass);
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodyOperator != null)
                {
                    body["operator"] = SourceExpressionConverter.ConvertToken(bodyOperator);
                    bodypropCount++;
                }

                if (bodyretainDays != null)
                {
                    body["retain_days"] = SourceExpressionConverter.ConvertToken(bodyretainDays);
                    bodypropCount++;
                }

                if (bodysubclass != null)
                {
                    body["subclass"] = SourceExpressionConverter.ConvertToken(bodysubclass);
                    bodypropCount++;
                }

                if (bodycustom1 != null)
                {
                    body["custom1"] = SourceExpressionConverter.ConvertToken(bodycustom1);
                    bodypropCount++;
                }

                if (bodycustom2 != null)
                {
                    body["custom2"] = SourceExpressionConverter.ConvertToken(bodycustom2);
                    bodypropCount++;
                }

                if (bodycustom3 != null)
                {
                    body["custom3"] = SourceExpressionConverter.ConvertToken(bodycustom3);
                    bodypropCount++;
                }

                if (bodycustom4 != null)
                {
                    body["custom4"] = SourceExpressionConverter.ConvertToken(bodycustom4);
                    bodypropCount++;
                }

                if (bodycustom5 != null)
                {
                    body["custom5"] = SourceExpressionConverter.ConvertToken(bodycustom5);
                    bodypropCount++;
                }

                if (bodycustom6 != null)
                {
                    body["custom6"] = SourceExpressionConverter.ConvertToken(bodycustom6);
                    bodypropCount++;
                }

                if (bodycustom7 != null)
                {
                    body["custom7"] = SourceExpressionConverter.ConvertToken(bodycustom7);
                    bodypropCount++;
                }

                if (bodycustom8 != null)
                {
                    body["custom8"] = SourceExpressionConverter.ConvertToken(bodycustom8);
                    bodypropCount++;
                }

                if (bodycustom9 != null)
                {
                    body["custom9"] = SourceExpressionConverter.ConvertToken(bodycustom9);
                    bodypropCount++;
                }

                if (bodycustom10 != null)
                {
                    body["custom10"] = SourceExpressionConverter.ConvertToken(bodycustom10);
                    bodypropCount++;
                }

                if (bodycustom11 != null)
                {
                    body["custom11"] = SourceExpressionConverter.ConvertToken(bodycustom11);
                    bodypropCount++;
                }

                if (bodycustom12 != null)
                {
                    body["custom12"] = SourceExpressionConverter.ConvertToken(bodycustom12);
                    bodypropCount++;
                }

                if (bodycustom13 != null)
                {
                    body["custom13"] = SourceExpressionConverter.ConvertToken(bodycustom13);
                    bodypropCount++;
                }

                if (bodycustom14 != null)
                {
                    body["custom14"] = SourceExpressionConverter.ConvertToken(bodycustom14);
                    bodypropCount++;
                }

                if (bodycustom15 != null)
                {
                    body["custom15"] = SourceExpressionConverter.ConvertToken(bodycustom15);
                    bodypropCount++;
                }

                if (bodycustom16 != null)
                {
                    body["custom16"] = SourceExpressionConverter.ConvertToken(bodycustom16);
                    bodypropCount++;
                }

                if (bodycustom17 != null)
                {
                    body["custom17"] = SourceExpressionConverter.ConvertToken(bodycustom17);
                    bodypropCount++;
                }

                if (bodycustom18 != null)
                {
                    body["custom18"] = SourceExpressionConverter.ConvertToken(bodycustom18);
                    bodypropCount++;
                }

                if (bodycustom19 != null)
                {
                    body["custom19"] = SourceExpressionConverter.ConvertToken(bodycustom19);
                    bodypropCount++;
                }

                if (bodycustom20 != null)
                {
                    body["custom20"] = SourceExpressionConverter.ConvertToken(bodycustom20);
                    bodypropCount++;
                }

                if (bodycustom21 != null)
                {
                    body["custom21"] = SourceExpressionConverter.ConvertToken(bodycustom21);
                    bodypropCount++;
                }

                if (bodycustom22 != null)
                {
                    body["custom22"] = SourceExpressionConverter.ConvertToken(bodycustom22);
                    bodypropCount++;
                }

                if (bodycustom23 != null)
                {
                    body["custom23"] = SourceExpressionConverter.ConvertToken(bodycustom23);
                    bodypropCount++;
                }

                if (bodycustom24 != null)
                {
                    body["custom24"] = SourceExpressionConverter.ConvertToken(bodycustom24);
                    bodypropCount++;
                }

                if (bodycustom25 != null)
                {
                    body["custom25"] = SourceExpressionConverter.ConvertToken(bodycustom25);
                    bodypropCount++;
                }

                if (bodycustom26 != null)
                {
                    body["custom26"] = SourceExpressionConverter.ConvertToken(bodycustom26);
                    bodypropCount++;
                }

                if (bodycustom27 != null)
                {
                    body["custom27"] = SourceExpressionConverter.ConvertToken(bodycustom27);
                    bodypropCount++;
                }

                if (bodycustom28 != null)
                {
                    body["custom28"] = SourceExpressionConverter.ConvertToken(bodycustom28);
                    bodypropCount++;
                }

                if (bodycustom29 != null)
                {
                    body["custom29"] = SourceExpressionConverter.ConvertToken(bodycustom29);
                    bodypropCount++;
                }

                if (bodycustom30 != null)
                {
                    body["custom30"] = SourceExpressionConverter.ConvertToken(bodycustom30);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ShortDocumentProfileResponseBody>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagework")]
        public IBodyWorkflowAction<GetGroupMembersResponse> GetGroupMembers([WorkflowExpression] Func<string> libraryId, [WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<logonStatusInput> logonStatus = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<string> preferredLibrary = null, [WorkflowExpression] Func<string> location = null)
        {
            SourceExpression.Validate(libraryId, nameof(libraryId), required: true);
            SourceExpression.Validate(groupId, nameof(groupId), required: true);
            SourceExpression.Validate(logonStatus, nameof(logonStatus), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(preferredLibrary, nameof(preferredLibrary), required: false);
            SourceExpression.Validate(location, nameof(location), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/getGroupMembers";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["libraryId"] = SourceExpressionConverter.ConvertO(libraryId);
                callPayload.Queries["groupId"] = SourceExpressionConverter.ConvertO(groupId);
                callPayload.Queries["logon_status"] = Convert.ToString("Enabled");
                if (logonStatus != null)
                    callPayload.Queries["logon_status"] = SourceExpressionConverter.Convert(logonStatus);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (preferredLibrary != null)
                    callPayload.Queries["preferred_library"] = SourceExpressionConverter.ConvertO(preferredLibrary);
                if (location != null)
                    callPayload.Queries["location"] = SourceExpressionConverter.ConvertO(location);
                return callPayload;
            }

            return new ApiConnectionAction<GetGroupMembersResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagework")]
        public IBodyWorkflowAction<SearchWorkspacesResponseBody> SearchWorkspaces([WorkflowExpression] Func<string> bodylibraryId, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodyowner = null, [WorkflowExpression] Func<string> bodyanywhere = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodysubclass = null, [WorkflowExpression] Func<string> bodycustom1 = null, [WorkflowExpression] Func<string> bodycustom2 = null, [WorkflowExpression] Func<string> bodycustom3 = null, [WorkflowExpression] Func<string> bodycustom4 = null, [WorkflowExpression] Func<string> bodycustom5 = null, [WorkflowExpression] Func<string> bodycustom6 = null, [WorkflowExpression] Func<string> bodycustom7 = null, [WorkflowExpression] Func<string> bodycustom8 = null, [WorkflowExpression] Func<string> bodycustom9 = null, [WorkflowExpression] Func<string> bodycustom10 = null, [WorkflowExpression] Func<string> bodycustom11 = null, [WorkflowExpression] Func<string> bodycustom12 = null, [WorkflowExpression] Func<string> bodycustom13 = null, [WorkflowExpression] Func<string> bodycustom14 = null, [WorkflowExpression] Func<string> bodycustom15 = null, [WorkflowExpression] Func<string> bodycustom16 = null, [WorkflowExpression] Func<string> bodycustom17 = null, [WorkflowExpression] Func<string> bodycustom18 = null, [WorkflowExpression] Func<string> bodycustom19 = null, [WorkflowExpression] Func<string> bodycustom20 = null, [WorkflowExpression] Func<string> bodycustom21From = null, [WorkflowExpression] Func<string> bodycustom21To = null, [WorkflowExpression] Func<string> bodycustom22From = null, [WorkflowExpression] Func<string> bodycustom22To = null, [WorkflowExpression] Func<string> bodycustom23From = null, [WorkflowExpression] Func<string> bodycustom23To = null, [WorkflowExpression] Func<string> bodycustom24From = null, [WorkflowExpression] Func<string> bodycustom24To = null, [WorkflowExpression] Func<bool> bodycustom25 = null, [WorkflowExpression] Func<bool> bodycustom26 = null, [WorkflowExpression] Func<bool> bodycustom27 = null, [WorkflowExpression] Func<bool> bodycustom28 = null, [WorkflowExpression] Func<string> bodycustom29 = null, [WorkflowExpression] Func<string> bodycustom30 = null)
        {
            SourceExpression.Validate(bodylibraryId, nameof(bodylibraryId), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodyowner, nameof(bodyowner), required: false);
            SourceExpression.Validate(bodyanywhere, nameof(bodyanywhere), required: false);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            SourceExpression.Validate(bodysubclass, nameof(bodysubclass), required: false);
            SourceExpression.Validate(bodycustom1, nameof(bodycustom1), required: false);
            SourceExpression.Validate(bodycustom2, nameof(bodycustom2), required: false);
            SourceExpression.Validate(bodycustom3, nameof(bodycustom3), required: false);
            SourceExpression.Validate(bodycustom4, nameof(bodycustom4), required: false);
            SourceExpression.Validate(bodycustom5, nameof(bodycustom5), required: false);
            SourceExpression.Validate(bodycustom6, nameof(bodycustom6), required: false);
            SourceExpression.Validate(bodycustom7, nameof(bodycustom7), required: false);
            SourceExpression.Validate(bodycustom8, nameof(bodycustom8), required: false);
            SourceExpression.Validate(bodycustom9, nameof(bodycustom9), required: false);
            SourceExpression.Validate(bodycustom10, nameof(bodycustom10), required: false);
            SourceExpression.Validate(bodycustom11, nameof(bodycustom11), required: false);
            SourceExpression.Validate(bodycustom12, nameof(bodycustom12), required: false);
            SourceExpression.Validate(bodycustom13, nameof(bodycustom13), required: false);
            SourceExpression.Validate(bodycustom14, nameof(bodycustom14), required: false);
            SourceExpression.Validate(bodycustom15, nameof(bodycustom15), required: false);
            SourceExpression.Validate(bodycustom16, nameof(bodycustom16), required: false);
            SourceExpression.Validate(bodycustom17, nameof(bodycustom17), required: false);
            SourceExpression.Validate(bodycustom18, nameof(bodycustom18), required: false);
            SourceExpression.Validate(bodycustom19, nameof(bodycustom19), required: false);
            SourceExpression.Validate(bodycustom20, nameof(bodycustom20), required: false);
            SourceExpression.Validate(bodycustom21From, nameof(bodycustom21From), required: false);
            SourceExpression.Validate(bodycustom21To, nameof(bodycustom21To), required: false);
            SourceExpression.Validate(bodycustom22From, nameof(bodycustom22From), required: false);
            SourceExpression.Validate(bodycustom22To, nameof(bodycustom22To), required: false);
            SourceExpression.Validate(bodycustom23From, nameof(bodycustom23From), required: false);
            SourceExpression.Validate(bodycustom23To, nameof(bodycustom23To), required: false);
            SourceExpression.Validate(bodycustom24From, nameof(bodycustom24From), required: false);
            SourceExpression.Validate(bodycustom24To, nameof(bodycustom24To), required: false);
            SourceExpression.Validate(bodycustom25, nameof(bodycustom25), required: false);
            SourceExpression.Validate(bodycustom26, nameof(bodycustom26), required: false);
            SourceExpression.Validate(bodycustom27, nameof(bodycustom27), required: false);
            SourceExpression.Validate(bodycustom28, nameof(bodycustom28), required: false);
            SourceExpression.Validate(bodycustom29, nameof(bodycustom29), required: false);
            SourceExpression.Validate(bodycustom30, nameof(bodycustom30), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/searchWorkspaces";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["libraryId"] = SourceExpressionConverter.ConvertToken(bodylibraryId);
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodyowner != null)
                {
                    body["owner"] = SourceExpressionConverter.ConvertToken(bodyowner);
                    bodypropCount++;
                }

                if (bodyanywhere != null)
                {
                    body["anywhere"] = SourceExpressionConverter.ConvertToken(bodyanywhere);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodysubclass != null)
                {
                    body["subclass"] = SourceExpressionConverter.ConvertToken(bodysubclass);
                    bodypropCount++;
                }

                if (bodycustom1 != null)
                {
                    body["custom1"] = SourceExpressionConverter.ConvertToken(bodycustom1);
                    bodypropCount++;
                }

                if (bodycustom2 != null)
                {
                    body["custom2"] = SourceExpressionConverter.ConvertToken(bodycustom2);
                    bodypropCount++;
                }

                if (bodycustom3 != null)
                {
                    body["custom3"] = SourceExpressionConverter.ConvertToken(bodycustom3);
                    bodypropCount++;
                }

                if (bodycustom4 != null)
                {
                    body["custom4"] = SourceExpressionConverter.ConvertToken(bodycustom4);
                    bodypropCount++;
                }

                if (bodycustom5 != null)
                {
                    body["custom5"] = SourceExpressionConverter.ConvertToken(bodycustom5);
                    bodypropCount++;
                }

                if (bodycustom6 != null)
                {
                    body["custom6"] = SourceExpressionConverter.ConvertToken(bodycustom6);
                    bodypropCount++;
                }

                if (bodycustom7 != null)
                {
                    body["custom7"] = SourceExpressionConverter.ConvertToken(bodycustom7);
                    bodypropCount++;
                }

                if (bodycustom8 != null)
                {
                    body["custom8"] = SourceExpressionConverter.ConvertToken(bodycustom8);
                    bodypropCount++;
                }

                if (bodycustom9 != null)
                {
                    body["custom9"] = SourceExpressionConverter.ConvertToken(bodycustom9);
                    bodypropCount++;
                }

                if (bodycustom10 != null)
                {
                    body["custom10"] = SourceExpressionConverter.ConvertToken(bodycustom10);
                    bodypropCount++;
                }

                if (bodycustom11 != null)
                {
                    body["custom11"] = SourceExpressionConverter.ConvertToken(bodycustom11);
                    bodypropCount++;
                }

                if (bodycustom12 != null)
                {
                    body["custom12"] = SourceExpressionConverter.ConvertToken(bodycustom12);
                    bodypropCount++;
                }

                if (bodycustom13 != null)
                {
                    body["custom13"] = SourceExpressionConverter.ConvertToken(bodycustom13);
                    bodypropCount++;
                }

                if (bodycustom14 != null)
                {
                    body["custom14"] = SourceExpressionConverter.ConvertToken(bodycustom14);
                    bodypropCount++;
                }

                if (bodycustom15 != null)
                {
                    body["custom15"] = SourceExpressionConverter.ConvertToken(bodycustom15);
                    bodypropCount++;
                }

                if (bodycustom16 != null)
                {
                    body["custom16"] = SourceExpressionConverter.ConvertToken(bodycustom16);
                    bodypropCount++;
                }

                if (bodycustom17 != null)
                {
                    body["custom17"] = SourceExpressionConverter.ConvertToken(bodycustom17);
                    bodypropCount++;
                }

                if (bodycustom18 != null)
                {
                    body["custom18"] = SourceExpressionConverter.ConvertToken(bodycustom18);
                    bodypropCount++;
                }

                if (bodycustom19 != null)
                {
                    body["custom19"] = SourceExpressionConverter.ConvertToken(bodycustom19);
                    bodypropCount++;
                }

                if (bodycustom20 != null)
                {
                    body["custom20"] = SourceExpressionConverter.ConvertToken(bodycustom20);
                    bodypropCount++;
                }

                if (bodycustom21From != null)
                {
                    body["custom21_from"] = SourceExpressionConverter.ConvertToken(bodycustom21From);
                    bodypropCount++;
                }

                if (bodycustom21To != null)
                {
                    body["custom21_to"] = SourceExpressionConverter.ConvertToken(bodycustom21To);
                    bodypropCount++;
                }

                if (bodycustom22From != null)
                {
                    body["custom22_from"] = SourceExpressionConverter.ConvertToken(bodycustom22From);
                    bodypropCount++;
                }

                if (bodycustom22To != null)
                {
                    body["custom22_to"] = SourceExpressionConverter.ConvertToken(bodycustom22To);
                    bodypropCount++;
                }

                if (bodycustom23From != null)
                {
                    body["custom23_from"] = SourceExpressionConverter.ConvertToken(bodycustom23From);
                    bodypropCount++;
                }

                if (bodycustom23To != null)
                {
                    body["custom23_to"] = SourceExpressionConverter.ConvertToken(bodycustom23To);
                    bodypropCount++;
                }

                if (bodycustom24From != null)
                {
                    body["custom24_from"] = SourceExpressionConverter.ConvertToken(bodycustom24From);
                    bodypropCount++;
                }

                if (bodycustom24To != null)
                {
                    body["custom24_to"] = SourceExpressionConverter.ConvertToken(bodycustom24To);
                    bodypropCount++;
                }

                if (bodycustom25 != null)
                {
                    body["custom25"] = SourceExpressionConverter.ConvertToken(bodycustom25);
                    bodypropCount++;
                }

                if (bodycustom26 != null)
                {
                    body["custom26"] = SourceExpressionConverter.ConvertToken(bodycustom26);
                    bodypropCount++;
                }

                if (bodycustom27 != null)
                {
                    body["custom27"] = SourceExpressionConverter.ConvertToken(bodycustom27);
                    bodypropCount++;
                }

                if (bodycustom28 != null)
                {
                    body["custom28"] = SourceExpressionConverter.ConvertToken(bodycustom28);
                    bodypropCount++;
                }

                if (bodycustom29 != null)
                {
                    body["custom29"] = SourceExpressionConverter.ConvertToken(bodycustom29);
                    bodypropCount++;
                }

                if (bodycustom30 != null)
                {
                    body["custom30"] = SourceExpressionConverter.ConvertToken(bodycustom30);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SearchWorkspacesResponseBody>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagework")]
        public IBodyWorkflowAction<AddDocumentReferenceResponse> AddDocumentReference([WorkflowExpression] Func<string> bodydocumentId, [WorkflowExpression] Func<string> bodyfolderId)
        {
            SourceExpression.Validate(bodydocumentId, nameof(bodydocumentId), required: true);
            SourceExpression.Validate(bodyfolderId, nameof(bodyfolderId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/addDocumentReference";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["documentId"] = SourceExpressionConverter.ConvertToken(bodydocumentId);
                bodypropCount++;
                body["folderId"] = SourceExpressionConverter.ConvertToken(bodyfolderId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AddDocumentReferenceResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagework")]
        public IBodyWorkflowAction<JToken> DeleteDocumentReference([WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string> folderId)
        {
            SourceExpression.Validate(documentId, nameof(documentId), required: true);
            SourceExpression.Validate(folderId, nameof(folderId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/deleteDocumentReference";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["documentId"] = SourceExpressionConverter.ConvertO(documentId);
                callPayload.Queries["folderId"] = SourceExpressionConverter.ConvertO(folderId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagework")]
        public IBodyWorkflowAction<MoveDocumentResponseBody> MoveDocument([WorkflowExpression] Func<string> bodyfolderId, [WorkflowExpression] Func<string> bodydocumentId, [WorkflowExpression] Func<string> bodydestinationFolderId, [WorkflowExpression] Func<bool> bodyupdateProfile = null, [WorkflowExpression] Func<bool> bodyupdateSecurity = null, [WorkflowExpression] Func<string> bodycomments = null)
        {
            SourceExpression.Validate(bodyfolderId, nameof(bodyfolderId), required: true);
            SourceExpression.Validate(bodydocumentId, nameof(bodydocumentId), required: true);
            SourceExpression.Validate(bodydestinationFolderId, nameof(bodydestinationFolderId), required: true);
            SourceExpression.Validate(bodyupdateProfile, nameof(bodyupdateProfile), required: false);
            SourceExpression.Validate(bodyupdateSecurity, nameof(bodyupdateSecurity), required: false);
            SourceExpression.Validate(bodycomments, nameof(bodycomments), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/moveDocument";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["folderId"] = SourceExpressionConverter.ConvertToken(bodyfolderId);
                bodypropCount++;
                body["documentId"] = SourceExpressionConverter.ConvertToken(bodydocumentId);
                bodypropCount++;
                body["destination_folder_id"] = SourceExpressionConverter.ConvertToken(bodydestinationFolderId);
                if (bodyupdateProfile != null)
                {
                    if (bodyupdateProfile != null)
                    {
                        body["update_profile"] = SourceExpressionConverter.ConvertToken(bodyupdateProfile);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["update_profile"] = true;
                    bodypropCount++;
                }

                if (bodyupdateSecurity != null)
                {
                    if (bodyupdateSecurity != null)
                    {
                        body["update_security"] = SourceExpressionConverter.ConvertToken(bodyupdateSecurity);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["update_security"] = true;
                    bodypropCount++;
                }

                if (bodycomments != null)
                {
                    body["comments"] = SourceExpressionConverter.ConvertToken(bodycomments);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MoveDocumentResponseBody>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagework")]
        public IBodyWorkflowAction<CopyDocumentResponse> CopyDocument([WorkflowExpression] Func<string> bodydocumentId, [WorkflowExpression] Func<string> bodyfolderId)
        {
            SourceExpression.Validate(bodydocumentId, nameof(bodydocumentId), required: true);
            SourceExpression.Validate(bodyfolderId, nameof(bodyfolderId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/copyDocument";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["documentId"] = SourceExpressionConverter.ConvertToken(bodydocumentId);
                bodypropCount++;
                body["folderId"] = SourceExpressionConverter.ConvertToken(bodyfolderId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CopyDocumentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagework")]
        public IBodyWorkflowAction<CreateFormLinkResponse> CreateFormLink([WorkflowExpression] Func<string> bodylibraryId, [WorkflowExpression] Func<string> bodyformId, [WorkflowExpression] Func<string> bodysecurity, [WorkflowExpression] Func<string> bodyexpiresAt = null, [WorkflowExpression] Func<object> bodylinkData = null)
        {
            SourceExpression.Validate(bodylibraryId, nameof(bodylibraryId), required: true);
            SourceExpression.Validate(bodyformId, nameof(bodyformId), required: true);
            SourceExpression.Validate(bodysecurity, nameof(bodysecurity), required: true);
            SourceExpression.Validate(bodyexpiresAt, nameof(bodyexpiresAt), required: false);
            SourceExpression.Validate(bodylinkData, nameof(bodylinkData), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/createFormLink";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["libraryId"] = SourceExpressionConverter.ConvertToken(bodylibraryId);
                bodypropCount++;
                body["formId"] = SourceExpressionConverter.ConvertToken(bodyformId);
                if (bodyexpiresAt != null)
                {
                    body["expires_at"] = SourceExpressionConverter.ConvertToken(bodyexpiresAt);
                    bodypropCount++;
                }

                bodypropCount++;
                body["security"] = SourceExpressionConverter.ConvertToken(bodysecurity);
                if (bodylinkData != null)
                {
                    body["link_data"] = SourceExpressionConverter.ConvertToken(bodylinkData);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateFormLinkResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagework")]
        public IBodyWorkflowAction<JToken> UpdateWorkflowState([WorkflowExpression] Func<string> bodylibraryId, [WorkflowExpression] Func<string> bodystate, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<string> bodystatusMessage = null)
        {
            SourceExpression.Validate(bodylibraryId, nameof(bodylibraryId), required: true);
            SourceExpression.Validate(bodystate, nameof(bodystate), required: true);
            SourceExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            SourceExpression.Validate(bodystatusMessage, nameof(bodystatusMessage), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/updateWorkflowState";
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["libraryId"] = SourceExpressionConverter.ConvertToken(bodylibraryId);
                bodypropCount++;
                body["state"] = SourceExpressionConverter.ConvertToken(bodystate);
                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                if (bodystatusMessage != null)
                {
                    body["statusMessage"] = SourceExpressionConverter.ConvertToken(bodystatusMessage);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagework")]
        public IBodyWorkflowAction<CoreEMPropertiesResponseBody> GetCoreEMPropertiesForDocument([WorkflowExpression] Func<string> bodydocumentId, [WorkflowExpression] Func<bool> bodylatest = null)
        {
            SourceExpression.Validate(bodydocumentId, nameof(bodydocumentId), required: true);
            SourceExpression.Validate(bodylatest, nameof(bodylatest), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/getCoreEMPropertiesForDocument";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["documentId"] = SourceExpressionConverter.ConvertToken(bodydocumentId);
                if (bodylatest != null)
                {
                    if (bodylatest != null)
                    {
                        body["latest"] = SourceExpressionConverter.ConvertToken(bodylatest);
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
                return callPayload;
            }

            return new ApiConnectionAction<CoreEMPropertiesResponseBody>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagework")]
        public IBodyWorkflowAction<PromoteDocumentVersionResponseBody> PromoteDocumentVersion([WorkflowExpression] Func<string> bodydocumentId, [WorkflowExpression] Func<int> bodyversion = null, [WorkflowExpression] Func<string> bodyjournalId = null, [WorkflowExpression] Func<string> bodycomment = null, [WorkflowExpression] Func<string> bodyalias = null, [WorkflowExpression] Func<string> bodyauthor = null, [WorkflowExpression] Func<string> bodyClass = null, [WorkflowExpression] Func<bodydefaultSecurityInput> bodydefaultSecurity = null, [WorkflowExpression] Func<bool> bodyisDeclared = null, [WorkflowExpression] Func<bool> bodyisHipaa = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodyOperator = null, [WorkflowExpression] Func<int> bodyretainDays = null, [WorkflowExpression] Func<string> bodysubclass = null, [WorkflowExpression] Func<string> bodycustom1 = null, [WorkflowExpression] Func<string> bodycustom2 = null, [WorkflowExpression] Func<string> bodycustom3 = null, [WorkflowExpression] Func<string> bodycustom4 = null, [WorkflowExpression] Func<string> bodycustom5 = null, [WorkflowExpression] Func<string> bodycustom6 = null, [WorkflowExpression] Func<string> bodycustom7 = null, [WorkflowExpression] Func<string> bodycustom8 = null, [WorkflowExpression] Func<string> bodycustom9 = null, [WorkflowExpression] Func<string> bodycustom10 = null, [WorkflowExpression] Func<string> bodycustom11 = null, [WorkflowExpression] Func<string> bodycustom12 = null, [WorkflowExpression] Func<string> bodycustom13 = null, [WorkflowExpression] Func<string> bodycustom14 = null, [WorkflowExpression] Func<string> bodycustom15 = null, [WorkflowExpression] Func<string> bodycustom16 = null, [WorkflowExpression] Func<double> bodycustom17 = null, [WorkflowExpression] Func<double> bodycustom18 = null, [WorkflowExpression] Func<double> bodycustom19 = null, [WorkflowExpression] Func<double> bodycustom20 = null, [WorkflowExpression] Func<string> bodycustom21 = null, [WorkflowExpression] Func<string> bodycustom22 = null, [WorkflowExpression] Func<string> bodycustom23 = null, [WorkflowExpression] Func<string> bodycustom24 = null, [WorkflowExpression] Func<bool> bodycustom25 = null, [WorkflowExpression] Func<bool> bodycustom26 = null, [WorkflowExpression] Func<bool> bodycustom27 = null, [WorkflowExpression] Func<bool> bodycustom28 = null, [WorkflowExpression] Func<string> bodycustom29 = null, [WorkflowExpression] Func<string> bodycustom30 = null)
        {
            SourceExpression.Validate(bodydocumentId, nameof(bodydocumentId), required: true);
            SourceExpression.Validate(bodyversion, nameof(bodyversion), required: false);
            SourceExpression.Validate(bodyjournalId, nameof(bodyjournalId), required: false);
            SourceExpression.Validate(bodycomment, nameof(bodycomment), required: false);
            SourceExpression.Validate(bodyalias, nameof(bodyalias), required: false);
            SourceExpression.Validate(bodyauthor, nameof(bodyauthor), required: false);
            SourceExpression.Validate(bodyClass, nameof(bodyClass), required: false);
            SourceExpression.Validate(bodydefaultSecurity, nameof(bodydefaultSecurity), required: false);
            SourceExpression.Validate(bodyisDeclared, nameof(bodyisDeclared), required: false);
            SourceExpression.Validate(bodyisHipaa, nameof(bodyisHipaa), required: false);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodyOperator, nameof(bodyOperator), required: false);
            SourceExpression.Validate(bodyretainDays, nameof(bodyretainDays), required: false);
            SourceExpression.Validate(bodysubclass, nameof(bodysubclass), required: false);
            SourceExpression.Validate(bodycustom1, nameof(bodycustom1), required: false);
            SourceExpression.Validate(bodycustom2, nameof(bodycustom2), required: false);
            SourceExpression.Validate(bodycustom3, nameof(bodycustom3), required: false);
            SourceExpression.Validate(bodycustom4, nameof(bodycustom4), required: false);
            SourceExpression.Validate(bodycustom5, nameof(bodycustom5), required: false);
            SourceExpression.Validate(bodycustom6, nameof(bodycustom6), required: false);
            SourceExpression.Validate(bodycustom7, nameof(bodycustom7), required: false);
            SourceExpression.Validate(bodycustom8, nameof(bodycustom8), required: false);
            SourceExpression.Validate(bodycustom9, nameof(bodycustom9), required: false);
            SourceExpression.Validate(bodycustom10, nameof(bodycustom10), required: false);
            SourceExpression.Validate(bodycustom11, nameof(bodycustom11), required: false);
            SourceExpression.Validate(bodycustom12, nameof(bodycustom12), required: false);
            SourceExpression.Validate(bodycustom13, nameof(bodycustom13), required: false);
            SourceExpression.Validate(bodycustom14, nameof(bodycustom14), required: false);
            SourceExpression.Validate(bodycustom15, nameof(bodycustom15), required: false);
            SourceExpression.Validate(bodycustom16, nameof(bodycustom16), required: false);
            SourceExpression.Validate(bodycustom17, nameof(bodycustom17), required: false);
            SourceExpression.Validate(bodycustom18, nameof(bodycustom18), required: false);
            SourceExpression.Validate(bodycustom19, nameof(bodycustom19), required: false);
            SourceExpression.Validate(bodycustom20, nameof(bodycustom20), required: false);
            SourceExpression.Validate(bodycustom21, nameof(bodycustom21), required: false);
            SourceExpression.Validate(bodycustom22, nameof(bodycustom22), required: false);
            SourceExpression.Validate(bodycustom23, nameof(bodycustom23), required: false);
            SourceExpression.Validate(bodycustom24, nameof(bodycustom24), required: false);
            SourceExpression.Validate(bodycustom25, nameof(bodycustom25), required: false);
            SourceExpression.Validate(bodycustom26, nameof(bodycustom26), required: false);
            SourceExpression.Validate(bodycustom27, nameof(bodycustom27), required: false);
            SourceExpression.Validate(bodycustom28, nameof(bodycustom28), required: false);
            SourceExpression.Validate(bodycustom29, nameof(bodycustom29), required: false);
            SourceExpression.Validate(bodycustom30, nameof(bodycustom30), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/promoteDocumentVersion";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["documentId"] = SourceExpressionConverter.ConvertToken(bodydocumentId);
                if (bodyversion != null)
                {
                    body["version"] = SourceExpressionConverter.ConvertToken(bodyversion);
                    bodypropCount++;
                }

                if (bodyjournalId != null)
                {
                    body["journalId"] = SourceExpressionConverter.ConvertToken(bodyjournalId);
                    bodypropCount++;
                }

                if (bodycomment != null)
                {
                    body["comment"] = SourceExpressionConverter.ConvertToken(bodycomment);
                    bodypropCount++;
                }

                if (bodyalias != null)
                {
                    body["alias"] = SourceExpressionConverter.ConvertToken(bodyalias);
                    bodypropCount++;
                }

                if (bodyauthor != null)
                {
                    body["author"] = SourceExpressionConverter.ConvertToken(bodyauthor);
                    bodypropCount++;
                }

                if (bodyClass != null)
                {
                    body["class"] = SourceExpressionConverter.ConvertToken(bodyClass);
                    bodypropCount++;
                }

                if (bodydefaultSecurity != null)
                {
                    body["default_security"] = SourceExpressionConverter.Convert(bodydefaultSecurity);
                    bodypropCount++;
                }

                if (bodyisDeclared != null)
                {
                    body["is_declared"] = SourceExpressionConverter.ConvertToken(bodyisDeclared);
                    bodypropCount++;
                }

                if (bodyisHipaa != null)
                {
                    body["is_hipaa"] = SourceExpressionConverter.ConvertToken(bodyisHipaa);
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodyOperator != null)
                {
                    body["operator"] = SourceExpressionConverter.ConvertToken(bodyOperator);
                    bodypropCount++;
                }

                if (bodyretainDays != null)
                {
                    body["retain_days"] = SourceExpressionConverter.ConvertToken(bodyretainDays);
                    bodypropCount++;
                }

                if (bodysubclass != null)
                {
                    body["subclass"] = SourceExpressionConverter.ConvertToken(bodysubclass);
                    bodypropCount++;
                }

                if (bodycustom1 != null)
                {
                    body["custom1"] = SourceExpressionConverter.ConvertToken(bodycustom1);
                    bodypropCount++;
                }

                if (bodycustom2 != null)
                {
                    body["custom2"] = SourceExpressionConverter.ConvertToken(bodycustom2);
                    bodypropCount++;
                }

                if (bodycustom3 != null)
                {
                    body["custom3"] = SourceExpressionConverter.ConvertToken(bodycustom3);
                    bodypropCount++;
                }

                if (bodycustom4 != null)
                {
                    body["custom4"] = SourceExpressionConverter.ConvertToken(bodycustom4);
                    bodypropCount++;
                }

                if (bodycustom5 != null)
                {
                    body["custom5"] = SourceExpressionConverter.ConvertToken(bodycustom5);
                    bodypropCount++;
                }

                if (bodycustom6 != null)
                {
                    body["custom6"] = SourceExpressionConverter.ConvertToken(bodycustom6);
                    bodypropCount++;
                }

                if (bodycustom7 != null)
                {
                    body["custom7"] = SourceExpressionConverter.ConvertToken(bodycustom7);
                    bodypropCount++;
                }

                if (bodycustom8 != null)
                {
                    body["custom8"] = SourceExpressionConverter.ConvertToken(bodycustom8);
                    bodypropCount++;
                }

                if (bodycustom9 != null)
                {
                    body["custom9"] = SourceExpressionConverter.ConvertToken(bodycustom9);
                    bodypropCount++;
                }

                if (bodycustom10 != null)
                {
                    body["custom10"] = SourceExpressionConverter.ConvertToken(bodycustom10);
                    bodypropCount++;
                }

                if (bodycustom11 != null)
                {
                    body["custom11"] = SourceExpressionConverter.ConvertToken(bodycustom11);
                    bodypropCount++;
                }

                if (bodycustom12 != null)
                {
                    body["custom12"] = SourceExpressionConverter.ConvertToken(bodycustom12);
                    bodypropCount++;
                }

                if (bodycustom13 != null)
                {
                    body["custom13"] = SourceExpressionConverter.ConvertToken(bodycustom13);
                    bodypropCount++;
                }

                if (bodycustom14 != null)
                {
                    body["custom14"] = SourceExpressionConverter.ConvertToken(bodycustom14);
                    bodypropCount++;
                }

                if (bodycustom15 != null)
                {
                    body["custom15"] = SourceExpressionConverter.ConvertToken(bodycustom15);
                    bodypropCount++;
                }

                if (bodycustom16 != null)
                {
                    body["custom16"] = SourceExpressionConverter.ConvertToken(bodycustom16);
                    bodypropCount++;
                }

                if (bodycustom17 != null)
                {
                    body["custom17"] = SourceExpressionConverter.ConvertToken(bodycustom17);
                    bodypropCount++;
                }

                if (bodycustom18 != null)
                {
                    body["custom18"] = SourceExpressionConverter.ConvertToken(bodycustom18);
                    bodypropCount++;
                }

                if (bodycustom19 != null)
                {
                    body["custom19"] = SourceExpressionConverter.ConvertToken(bodycustom19);
                    bodypropCount++;
                }

                if (bodycustom20 != null)
                {
                    body["custom20"] = SourceExpressionConverter.ConvertToken(bodycustom20);
                    bodypropCount++;
                }

                if (bodycustom21 != null)
                {
                    body["custom21"] = SourceExpressionConverter.ConvertToken(bodycustom21);
                    bodypropCount++;
                }

                if (bodycustom22 != null)
                {
                    body["custom22"] = SourceExpressionConverter.ConvertToken(bodycustom22);
                    bodypropCount++;
                }

                if (bodycustom23 != null)
                {
                    body["custom23"] = SourceExpressionConverter.ConvertToken(bodycustom23);
                    bodypropCount++;
                }

                if (bodycustom24 != null)
                {
                    body["custom24"] = SourceExpressionConverter.ConvertToken(bodycustom24);
                    bodypropCount++;
                }

                if (bodycustom25 != null)
                {
                    body["custom25"] = SourceExpressionConverter.ConvertToken(bodycustom25);
                    bodypropCount++;
                }

                if (bodycustom26 != null)
                {
                    body["custom26"] = SourceExpressionConverter.ConvertToken(bodycustom26);
                    bodypropCount++;
                }

                if (bodycustom27 != null)
                {
                    body["custom27"] = SourceExpressionConverter.ConvertToken(bodycustom27);
                    bodypropCount++;
                }

                if (bodycustom28 != null)
                {
                    body["custom28"] = SourceExpressionConverter.ConvertToken(bodycustom28);
                    bodypropCount++;
                }

                if (bodycustom29 != null)
                {
                    body["custom29"] = SourceExpressionConverter.ConvertToken(bodycustom29);
                    bodypropCount++;
                }

                if (bodycustom30 != null)
                {
                    body["custom30"] = SourceExpressionConverter.ConvertToken(bodycustom30);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PromoteDocumentVersionResponseBody>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagework")]
        public IBodyWorkflowAction<GetDocumentVersionsResponse> GetDocumentVersions([WorkflowExpression] Func<string> bodydocumentId)
        {
            SourceExpression.Validate(bodydocumentId, nameof(bodydocumentId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/getDocumentVersions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["documentId"] = SourceExpressionConverter.ConvertToken(bodydocumentId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GetDocumentVersionsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagework")]
        public IBodyWorkflowAction<CoreEMPropertiesResponseBody> SetCoreEMPropertiesForDocument([WorkflowExpression] Func<string> bodydocumentId, [WorkflowExpression] Func<bodyemPropertiesInputItem[]> bodyemProperties)
        {
            SourceExpression.Validate(bodydocumentId, nameof(bodydocumentId), required: true);
            SourceExpression.Validate(bodyemProperties, nameof(bodyemProperties), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/setCoreEMPropertiesForDocument";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["documentId"] = SourceExpressionConverter.ConvertToken(bodydocumentId);
                bodypropCount++;
                body["emProperties"] = SourceExpressionConverter.ConvertToken(bodyemProperties);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CoreEMPropertiesResponseBody>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagework")]
        public IBodyWorkflowAction<SearchCoreEMTaxonomyNodeValuesResponse> SearchCoreEMTaxonomyNodeValues([WorkflowExpression] Func<string> bodylibraryId, [WorkflowExpression] Func<string> bodytaxonomyProperty, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodyquery = null, [WorkflowExpression] Func<bodyenabledStateInput> bodyenabledState = null, [WorkflowExpression] Func<bool> bodyincludePath = null, [WorkflowExpression] Func<string> bodychildrenOfSsid = null, [WorkflowExpression] Func<bool> bodyimmediateChildrenOnly = null)
        {
            SourceExpression.Validate(bodylibraryId, nameof(bodylibraryId), required: true);
            SourceExpression.Validate(bodytaxonomyProperty, nameof(bodytaxonomyProperty), required: true);
            SourceExpression.Validate(bodyid, nameof(bodyid), required: false);
            SourceExpression.Validate(bodyquery, nameof(bodyquery), required: false);
            SourceExpression.Validate(bodyenabledState, nameof(bodyenabledState), required: false);
            SourceExpression.Validate(bodyincludePath, nameof(bodyincludePath), required: false);
            SourceExpression.Validate(bodychildrenOfSsid, nameof(bodychildrenOfSsid), required: false);
            SourceExpression.Validate(bodyimmediateChildrenOnly, nameof(bodyimmediateChildrenOnly), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/searchCoreEMTaxonomyNodeValues";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["libraryId"] = SourceExpressionConverter.ConvertToken(bodylibraryId);
                bodypropCount++;
                body["taxonomyProperty"] = SourceExpressionConverter.ConvertToken(bodytaxonomyProperty);
                if (bodyid != null)
                {
                    body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                    bodypropCount++;
                }

                if (bodyquery != null)
                {
                    body["query"] = SourceExpressionConverter.ConvertToken(bodyquery);
                    bodypropCount++;
                }

                if (bodyenabledState != null)
                {
                    if (bodyenabledState != null)
                    {
                        body["enabled_state"] = SourceExpressionConverter.Convert(bodyenabledState);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["enabled_state"] = "Enabled";
                    bodypropCount++;
                }

                if (bodyincludePath != null)
                {
                    if (bodyincludePath != null)
                    {
                        body["include_path"] = SourceExpressionConverter.ConvertToken(bodyincludePath);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["include_path"] = false;
                    bodypropCount++;
                }

                if (bodychildrenOfSsid != null)
                {
                    body["children_of_ssid"] = SourceExpressionConverter.ConvertToken(bodychildrenOfSsid);
                    bodypropCount++;
                }

                if (bodyimmediateChildrenOnly != null)
                {
                    if (bodyimmediateChildrenOnly != null)
                    {
                        body["immediate_children_only"] = SourceExpressionConverter.ConvertToken(bodyimmediateChildrenOnly);
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
                return callPayload;
            }

            return new ApiConnectionAction<SearchCoreEMTaxonomyNodeValuesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagework")]
        public IBodyWorkflowAction<AddDocumentHistoryEntryResponse> AddDocumentHistoryEntry([WorkflowExpression] Func<string> bodydocumentId, [WorkflowExpression] Func<int> bodyactivityCode, [WorkflowExpression] Func<string> bodycomments = null, [WorkflowExpression] Func<int> bodyduration = null)
        {
            SourceExpression.Validate(bodydocumentId, nameof(bodydocumentId), required: true);
            SourceExpression.Validate(bodyactivityCode, nameof(bodyactivityCode), required: true);
            SourceExpression.Validate(bodycomments, nameof(bodycomments), required: false);
            SourceExpression.Validate(bodyduration, nameof(bodyduration), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/addDocumentHistoryEntry";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["documentId"] = SourceExpressionConverter.ConvertToken(bodydocumentId);
                bodypropCount++;
                body["activity_code"] = SourceExpressionConverter.ConvertToken(bodyactivityCode);
                if (bodycomments != null)
                {
                    body["comments"] = SourceExpressionConverter.ConvertToken(bodycomments);
                    bodypropCount++;
                }

                if (bodyduration != null)
                {
                    body["duration"] = SourceExpressionConverter.ConvertToken(bodyduration);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AddDocumentHistoryEntryResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagework")]
        public IBodyWorkflowAction<SearchUsersResponse> SearchUsers([WorkflowExpression] Func<string> email = null)
        {
            SourceExpression.Validate(email, nameof(email), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/searchUsers";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (email != null)
                    callPayload.Queries["email"] = SourceExpressionConverter.ConvertO(email);
                return callPayload;
            }

            return new ApiConnectionAction<SearchUsersResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagework")]
        public IBodyWorkflowAction<DeleteDocumentResponseBody> DeleteDocument([WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<bool> deleteAllVersions)
        {
            SourceExpression.Validate(documentId, nameof(documentId), required: true);
            SourceExpression.Validate(deleteAllVersions, nameof(deleteAllVersions), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/deleteDocument";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["documentId"] = SourceExpressionConverter.ConvertO(documentId);
                callPayload.Queries["deleteAllVersions"] = SourceExpressionConverter.ConvertO(deleteAllVersions);
                return callPayload;
            }

            return new ApiConnectionAction<DeleteDocumentResponseBody>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagework")]
        public IBodyWorkflowAction<JToken> CreateDocumentRelation([WorkflowExpression] Func<string> bodyprimaryDocumentId, [WorkflowExpression] Func<string> bodyrelatedDocumentId)
        {
            SourceExpression.Validate(bodyprimaryDocumentId, nameof(bodyprimaryDocumentId), required: true);
            SourceExpression.Validate(bodyrelatedDocumentId, nameof(bodyrelatedDocumentId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/createDocumentRelation";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["primaryDocumentId"] = SourceExpressionConverter.ConvertToken(bodyprimaryDocumentId);
                bodypropCount++;
                body["relatedDocumentId"] = SourceExpressionConverter.ConvertToken(bodyrelatedDocumentId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagework")]
        public IBodyWorkflowAction<JToken> DeleteDocumentRelation([WorkflowExpression] Func<string> primaryDocumentId, [WorkflowExpression] Func<string> relatedDocumentId)
        {
            SourceExpression.Validate(primaryDocumentId, nameof(primaryDocumentId), required: true);
            SourceExpression.Validate(relatedDocumentId, nameof(relatedDocumentId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/deleteDocumentRelation";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["primaryDocumentId"] = SourceExpressionConverter.ConvertO(primaryDocumentId);
                callPayload.Queries["relatedDocumentId"] = SourceExpressionConverter.ConvertO(relatedDocumentId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }
    }

    public class ImanageworkTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<SingleSelectedDocumentResponse> SingleSelectedDocument([WorkflowExpression] Func<string> bodyworkflowName, [WorkflowExpression] Func<string> bodydescription, [WorkflowExpression] Func<string> bodylibraryId, [WorkflowExpression] Func<string> bodyformId, [WorkflowExpression] Func<bool> bodyinferFolderId, [WorkflowExpression] Func<string> bodyusers = null, [WorkflowExpression] Func<string> bodygroups = null, [WorkflowExpression] Func<string> bodyworkspaces = null, [WorkflowExpression] Func<string> bodyclasses = null, [WorkflowExpression] Func<bool> bodywaitForCompletion = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodyworkflowName, nameof(bodyworkflowName), required: true);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: true);
            SourceExpression.Validate(bodylibraryId, nameof(bodylibraryId), required: true);
            SourceExpression.Validate(bodyformId, nameof(bodyformId), required: true);
            SourceExpression.Validate(bodyinferFolderId, nameof(bodyinferFolderId), required: true);
            SourceExpression.Validate(bodyusers, nameof(bodyusers), required: false);
            SourceExpression.Validate(bodygroups, nameof(bodygroups), required: false);
            SourceExpression.Validate(bodyworkspaces, nameof(bodyworkspaces), required: false);
            SourceExpression.Validate(bodyclasses, nameof(bodyclasses), required: false);
            SourceExpression.Validate(bodywaitForCompletion, nameof(bodywaitForCompletion), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/hooks/register/singleSelectedDocument";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["workflowName"] = SourceExpressionConverter.ConvertToken(bodyworkflowName);
                bodypropCount++;
                body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                bodypropCount++;
                body["libraryId"] = SourceExpressionConverter.ConvertToken(bodylibraryId);
                bodypropCount++;
                body["formId"] = SourceExpressionConverter.ConvertToken(bodyformId);
                bodypropCount++;
                body["inferFolderId"] = SourceExpressionConverter.ConvertToken(bodyinferFolderId);
                if (bodyusers != null)
                {
                    body["users"] = SourceExpressionConverter.ConvertToken(bodyusers);
                    bodypropCount++;
                }

                if (bodygroups != null)
                {
                    body["groups"] = SourceExpressionConverter.ConvertToken(bodygroups);
                    bodypropCount++;
                }

                if (bodyworkspaces != null)
                {
                    body["workspaces"] = SourceExpressionConverter.ConvertToken(bodyworkspaces);
                    bodypropCount++;
                }

                if (bodyclasses != null)
                {
                    body["classes"] = SourceExpressionConverter.ConvertToken(bodyclasses);
                    bodypropCount++;
                }

                if (bodywaitForCompletion != null)
                {
                    if (bodywaitForCompletion != null)
                    {
                        body["waitForCompletion"] = SourceExpressionConverter.ConvertToken(bodywaitForCompletion);
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
                return callPayload;
            }

            return new ApiConnectionTrigger<SingleSelectedDocumentResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<MultipleSelectedDocumentsResponse> MultipleSelectedDocuments([WorkflowExpression] Func<string> bodyworkflowName, [WorkflowExpression] Func<string> bodydescription, [WorkflowExpression] Func<string> bodylibraryId, [WorkflowExpression] Func<string> bodyformId, [WorkflowExpression] Func<bool> bodyinferFolderId, [WorkflowExpression] Func<string> bodyusers = null, [WorkflowExpression] Func<string> bodygroups = null, [WorkflowExpression] Func<bool> bodyshowFormPerObject = null, [WorkflowExpression] Func<bool> bodywaitForCompletion = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodyworkflowName, nameof(bodyworkflowName), required: true);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: true);
            SourceExpression.Validate(bodylibraryId, nameof(bodylibraryId), required: true);
            SourceExpression.Validate(bodyformId, nameof(bodyformId), required: true);
            SourceExpression.Validate(bodyinferFolderId, nameof(bodyinferFolderId), required: true);
            SourceExpression.Validate(bodyusers, nameof(bodyusers), required: false);
            SourceExpression.Validate(bodygroups, nameof(bodygroups), required: false);
            SourceExpression.Validate(bodyshowFormPerObject, nameof(bodyshowFormPerObject), required: false);
            SourceExpression.Validate(bodywaitForCompletion, nameof(bodywaitForCompletion), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/hooks/register/multipleSelectedDocuments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["workflowName"] = SourceExpressionConverter.ConvertToken(bodyworkflowName);
                bodypropCount++;
                body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                bodypropCount++;
                body["libraryId"] = SourceExpressionConverter.ConvertToken(bodylibraryId);
                bodypropCount++;
                body["formId"] = SourceExpressionConverter.ConvertToken(bodyformId);
                bodypropCount++;
                body["inferFolderId"] = SourceExpressionConverter.ConvertToken(bodyinferFolderId);
                if (bodyusers != null)
                {
                    body["users"] = SourceExpressionConverter.ConvertToken(bodyusers);
                    bodypropCount++;
                }

                if (bodygroups != null)
                {
                    body["groups"] = SourceExpressionConverter.ConvertToken(bodygroups);
                    bodypropCount++;
                }

                if (bodyshowFormPerObject != null)
                {
                    if (bodyshowFormPerObject != null)
                    {
                        body["showFormPerObject"] = SourceExpressionConverter.ConvertToken(bodyshowFormPerObject);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["showFormPerObject"] = false;
                    bodypropCount++;
                }

                if (bodywaitForCompletion != null)
                {
                    if (bodywaitForCompletion != null)
                    {
                        body["waitForCompletion"] = SourceExpressionConverter.ConvertToken(bodywaitForCompletion);
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
                return callPayload;
            }

            return new ApiConnectionTrigger<MultipleSelectedDocumentsResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<SingleSelectedWorkspaceResponse> SingleSelectedWorkspace([WorkflowExpression] Func<string> bodyworkflowName, [WorkflowExpression] Func<string> bodydescription, [WorkflowExpression] Func<string> bodylibraryId, [WorkflowExpression] Func<string> bodyformId, [WorkflowExpression] Func<string> bodyusers = null, [WorkflowExpression] Func<string> bodygroups = null, [WorkflowExpression] Func<bool> bodywaitForCompletion = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodyworkflowName, nameof(bodyworkflowName), required: true);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: true);
            SourceExpression.Validate(bodylibraryId, nameof(bodylibraryId), required: true);
            SourceExpression.Validate(bodyformId, nameof(bodyformId), required: true);
            SourceExpression.Validate(bodyusers, nameof(bodyusers), required: false);
            SourceExpression.Validate(bodygroups, nameof(bodygroups), required: false);
            SourceExpression.Validate(bodywaitForCompletion, nameof(bodywaitForCompletion), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/hooks/register/singleSelectedWorkspace";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["workflowName"] = SourceExpressionConverter.ConvertToken(bodyworkflowName);
                bodypropCount++;
                body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                bodypropCount++;
                body["libraryId"] = SourceExpressionConverter.ConvertToken(bodylibraryId);
                bodypropCount++;
                body["formId"] = SourceExpressionConverter.ConvertToken(bodyformId);
                if (bodyusers != null)
                {
                    body["users"] = SourceExpressionConverter.ConvertToken(bodyusers);
                    bodypropCount++;
                }

                if (bodygroups != null)
                {
                    body["groups"] = SourceExpressionConverter.ConvertToken(bodygroups);
                    bodypropCount++;
                }

                if (bodywaitForCompletion != null)
                {
                    if (bodywaitForCompletion != null)
                    {
                        body["waitForCompletion"] = SourceExpressionConverter.ConvertToken(bodywaitForCompletion);
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
                return callPayload;
            }

            return new ApiConnectionTrigger<SingleSelectedWorkspaceResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<MultipleSelectedWorkspacesResponse> MultipleSelectedWorkspaces([WorkflowExpression] Func<string> bodyworkflowName, [WorkflowExpression] Func<string> bodydescription, [WorkflowExpression] Func<string> bodylibraryId, [WorkflowExpression] Func<string> bodyformId, [WorkflowExpression] Func<string> bodyusers = null, [WorkflowExpression] Func<string> bodygroups = null, [WorkflowExpression] Func<bool> bodyshowFormPerObject = null, [WorkflowExpression] Func<bool> bodywaitForCompletion = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodyworkflowName, nameof(bodyworkflowName), required: true);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: true);
            SourceExpression.Validate(bodylibraryId, nameof(bodylibraryId), required: true);
            SourceExpression.Validate(bodyformId, nameof(bodyformId), required: true);
            SourceExpression.Validate(bodyusers, nameof(bodyusers), required: false);
            SourceExpression.Validate(bodygroups, nameof(bodygroups), required: false);
            SourceExpression.Validate(bodyshowFormPerObject, nameof(bodyshowFormPerObject), required: false);
            SourceExpression.Validate(bodywaitForCompletion, nameof(bodywaitForCompletion), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/hooks/register/multipleSelectedWorkspaces";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["workflowName"] = SourceExpressionConverter.ConvertToken(bodyworkflowName);
                bodypropCount++;
                body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                bodypropCount++;
                body["libraryId"] = SourceExpressionConverter.ConvertToken(bodylibraryId);
                bodypropCount++;
                body["formId"] = SourceExpressionConverter.ConvertToken(bodyformId);
                if (bodyusers != null)
                {
                    body["users"] = SourceExpressionConverter.ConvertToken(bodyusers);
                    bodypropCount++;
                }

                if (bodygroups != null)
                {
                    body["groups"] = SourceExpressionConverter.ConvertToken(bodygroups);
                    bodypropCount++;
                }

                if (bodyshowFormPerObject != null)
                {
                    if (bodyshowFormPerObject != null)
                    {
                        body["showFormPerObject"] = SourceExpressionConverter.ConvertToken(bodyshowFormPerObject);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["showFormPerObject"] = false;
                    bodypropCount++;
                }

                if (bodywaitForCompletion != null)
                {
                    if (bodywaitForCompletion != null)
                    {
                        body["waitForCompletion"] = SourceExpressionConverter.ConvertToken(bodywaitForCompletion);
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
                return callPayload;
            }

            return new ApiConnectionTrigger<MultipleSelectedWorkspacesResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<RegisterGenericWorkflowResponse> RegisterGenericWorkflow([WorkflowExpression] Func<string> bodyworkflowName, [WorkflowExpression] Func<string> bodydescription, [WorkflowExpression] Func<string> bodylibraryId, [WorkflowExpression] Func<string> bodyformId, [WorkflowExpression] Func<string> bodyusers = null, [WorkflowExpression] Func<string> bodygroups = null, [WorkflowExpression] Func<bool> bodywaitForCompletion = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodyworkflowName, nameof(bodyworkflowName), required: true);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: true);
            SourceExpression.Validate(bodylibraryId, nameof(bodylibraryId), required: true);
            SourceExpression.Validate(bodyformId, nameof(bodyformId), required: true);
            SourceExpression.Validate(bodyusers, nameof(bodyusers), required: false);
            SourceExpression.Validate(bodygroups, nameof(bodygroups), required: false);
            SourceExpression.Validate(bodywaitForCompletion, nameof(bodywaitForCompletion), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/hooks/register/genericWorkflow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["workflowName"] = SourceExpressionConverter.ConvertToken(bodyworkflowName);
                bodypropCount++;
                body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                bodypropCount++;
                body["libraryId"] = SourceExpressionConverter.ConvertToken(bodylibraryId);
                bodypropCount++;
                body["formId"] = SourceExpressionConverter.ConvertToken(bodyformId);
                if (bodyusers != null)
                {
                    body["users"] = SourceExpressionConverter.ConvertToken(bodyusers);
                    bodypropCount++;
                }

                if (bodygroups != null)
                {
                    body["groups"] = SourceExpressionConverter.ConvertToken(bodygroups);
                    bodypropCount++;
                }

                if (bodywaitForCompletion != null)
                {
                    if (bodywaitForCompletion != null)
                    {
                        body["waitForCompletion"] = SourceExpressionConverter.ConvertToken(bodywaitForCompletion);
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
                return callPayload;
            }

            return new ApiConnectionTrigger<RegisterGenericWorkflowResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<RegisterFormWorkflowResponse> RegisterFormWorkflow([WorkflowExpression] Func<string> bodyworkflowName, [WorkflowExpression] Func<string> bodydescription, [WorkflowExpression] Func<string> bodylibraryId, [WorkflowExpression] Func<string> bodyformId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodyworkflowName, nameof(bodyworkflowName), required: true);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: true);
            SourceExpression.Validate(bodylibraryId, nameof(bodylibraryId), required: true);
            SourceExpression.Validate(bodyformId, nameof(bodyformId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/hooks/register/formWorkflow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["workflowName"] = SourceExpressionConverter.ConvertToken(bodyworkflowName);
                bodypropCount++;
                body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                bodypropCount++;
                body["libraryId"] = SourceExpressionConverter.ConvertToken(bodylibraryId);
                bodypropCount++;
                body["formId"] = SourceExpressionConverter.ConvertToken(bodyformId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<RegisterFormWorkflowResponse>(BuildSourceInput, triggerName, recurrence);
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

    public enum GetTrusteesResponseDataTypeItemTypeType
    {
        [EnumMember(Value = "user")]
        User,
        [EnumMember(Value = "group")]
        Group
    }

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

    public enum AccessPermissionsItemTypeType
    {
        [EnumMember(Value = "user")]
        User,
        [EnumMember(Value = "group")]
        Group
    }

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

    public enum bodysourceObjectTypeInput
    {
        [EnumMember(Value = "document")]
        Document,
        [EnumMember(Value = "folder")]
        Folder,
        [EnumMember(Value = "workspace")]
        Workspace
    }

    public enum bodytargetObjectTypeInput
    {
        [EnumMember(Value = "document")]
        Document,
        [EnumMember(Value = "folder")]
        Folder,
        [EnumMember(Value = "workspace")]
        Workspace
    }

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

    public enum bodycreateChildrenInput
    {
        [EnumMember(Value = "All Folders")]
        AllFolders,
        [EnumMember(Value = "Only Required Folders")]
        OnlyRequiredFolders
    }

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

    public enum GetClassesResponseDataTypeResultsTypeItemDefaultSecurityType
    {
        [EnumMember(Value = "private")]
        Private,
        [EnumMember(Value = "view")]
        View,
        [EnumMember(Value = "public")]
        Public
    }

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