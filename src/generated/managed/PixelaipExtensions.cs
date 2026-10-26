//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pixelaip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PixelaipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<UserDeleteResponse, ApiConnectionActionConfiguration> UserDelete()
        {
            return new DeferredBodyAction<UserDeleteResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/users/";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<UserDeleteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<UserPostResponse, ApiConnectionActionConfiguration> User(Expression<Func<string>> bodytoken = null, Expression<Func<string>> bodyusername = null, Expression<Func<bodyagreeTermsOfServiceInput>> bodyagreeTermsOfService = null, Expression<Func<bodynotMinorInput>> bodynotMinor = null, Expression<Func<string>> bodythanksCode = null)
        {
            var __workflow_bodytoken = WorkflowExpression.Compile(bodytoken, nameof(bodytoken), required: false);
            var __workflow_bodyusername = WorkflowExpression.Compile(bodyusername, nameof(bodyusername), required: false);
            var __workflow_bodyagreeTermsOfService = WorkflowExpression.Compile(bodyagreeTermsOfService, nameof(bodyagreeTermsOfService), required: false);
            var __workflow_bodynotMinor = WorkflowExpression.Compile(bodynotMinor, nameof(bodynotMinor), required: false);
            var __workflow_bodythanksCode = WorkflowExpression.Compile(bodythanksCode, nameof(bodythanksCode), required: false);
            return new DeferredBodyAction<UserPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/users/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytoken != null)
                {
                    body["token"] = ExpressionConverter.ConvertO(__workflow_bodytoken);
                    bodypropCount++;
                }

                if (__workflow_bodyusername != null)
                {
                    body["username"] = ExpressionConverter.ConvertO(__workflow_bodyusername);
                    bodypropCount++;
                }

                if (__workflow_bodyagreeTermsOfService != null)
                {
                    if (__workflow_bodyagreeTermsOfService != null)
                    {
                        body["agreeTermsOfService"] = ExpressionConverter.ConvertO(__workflow_bodyagreeTermsOfService);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["agreeTermsOfService"] = "yes";
                    bodypropCount++;
                }

                if (__workflow_bodynotMinor != null)
                {
                    if (__workflow_bodynotMinor != null)
                    {
                        body["notMinor"] = ExpressionConverter.ConvertO(__workflow_bodynotMinor);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["notMinor"] = "yes";
                    bodypropCount++;
                }

                if (__workflow_bodythanksCode != null)
                {
                    body["thanksCode"] = ExpressionConverter.ConvertO(__workflow_bodythanksCode);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UserPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<TokenPutResponse, ApiConnectionActionConfiguration> TokenPut(Expression<Func<string>> bodynewToken, Expression<Func<string>> bodythanksCode = null)
        {
            var __workflow_bodynewToken = WorkflowExpression.Compile(bodynewToken, nameof(bodynewToken), required: true);
            var __workflow_bodythanksCode = WorkflowExpression.Compile(bodythanksCode, nameof(bodythanksCode), required: false);
            return new DeferredBodyAction<TokenPutResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/users/";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["newToken"] = ExpressionConverter.ConvertO(__workflow_bodynewToken);
                if (__workflow_bodythanksCode != null)
                {
                    body["thanksCode"] = ExpressionConverter.ConvertO(__workflow_bodythanksCode);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<TokenPutResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<ProfilePutResponse, ApiConnectionActionConfiguration> ProfilePut(Expression<Func<string>> bodydisplayName = null, Expression<Func<string>> bodygravatarIconEmail = null, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodytimezone = null, Expression<Func<string>> bodyaboutURL = null, Expression<Func<string[]>> bodycontributeURLs = null, Expression<Func<string>> bodypinnedGraphId = null)
        {
            var __workflow_bodydisplayName = WorkflowExpression.Compile(bodydisplayName, nameof(bodydisplayName), required: false);
            var __workflow_bodygravatarIconEmail = WorkflowExpression.Compile(bodygravatarIconEmail, nameof(bodygravatarIconEmail), required: false);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: false);
            var __workflow_bodytimezone = WorkflowExpression.Compile(bodytimezone, nameof(bodytimezone), required: false);
            var __workflow_bodyaboutURL = WorkflowExpression.Compile(bodyaboutURL, nameof(bodyaboutURL), required: false);
            var __workflow_bodycontributeURLs = WorkflowExpression.Compile(bodycontributeURLs, nameof(bodycontributeURLs), required: false);
            var __workflow_bodypinnedGraphId = WorkflowExpression.Compile(bodypinnedGraphId, nameof(bodypinnedGraphId), required: false);
            return new DeferredBodyAction<ProfilePutResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/@";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodydisplayName != null)
                {
                    body["displayName"] = ExpressionConverter.ConvertO(__workflow_bodydisplayName);
                    bodypropCount++;
                }

                if (__workflow_bodygravatarIconEmail != null)
                {
                    body["gravatarIconEmail"] = ExpressionConverter.ConvertO(__workflow_bodygravatarIconEmail);
                    bodypropCount++;
                }

                if (__workflow_bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (__workflow_bodytimezone != null)
                {
                    body["timezone"] = ExpressionConverter.ConvertO(__workflow_bodytimezone);
                    bodypropCount++;
                }

                if (__workflow_bodyaboutURL != null)
                {
                    body["aboutURL"] = ExpressionConverter.ConvertO(__workflow_bodyaboutURL);
                    bodypropCount++;
                }

                if (__workflow_bodycontributeURLs != null)
                {
                    body["contributeURLs"] = ExpressionConverter.ConvertO(__workflow_bodycontributeURLs);
                    bodypropCount++;
                }

                if (__workflow_bodypinnedGraphId != null)
                {
                    body["pinnedGraphID"] = ExpressionConverter.ConvertO(__workflow_bodypinnedGraphId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ProfilePutResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<GraphsGetResponse, ApiConnectionActionConfiguration> GraphsGet()
        {
            return new DeferredBodyAction<GraphsGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/users/graphs";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GraphsGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<GraphDeleteResponse, ApiConnectionActionConfiguration> GraphDelete(Expression<Func<string>> graphId)
        {
            var __workflow_graphId = WorkflowExpression.Compile(graphId, nameof(graphId), required: true);
            return new DeferredBodyAction<GraphDeleteResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/users/graphs";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["graphID"] = ExpressionConverter.Convert(__workflow_graphId);
                return new ApiConnectionAction<GraphDeleteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<GraphPostResponse, ApiConnectionActionConfiguration> Graph(Expression<Func<string>> bodyid, Expression<Func<string>> bodyname, Expression<Func<string>> bodyunit, Expression<Func<bodytypeInput>> bodytype, Expression<Func<bodycolorInput>> bodycolor, Expression<Func<string>> bodytimezone = null, Expression<Func<string>> bodyselfSufficient = null, Expression<Func<bool>> bodyisSecret = null, Expression<Func<bool>> bodypublishOptionalData = null)
        {
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodyunit = WorkflowExpression.Compile(bodyunit, nameof(bodyunit), required: true);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: true);
            var __workflow_bodycolor = WorkflowExpression.Compile(bodycolor, nameof(bodycolor), required: true);
            var __workflow_bodytimezone = WorkflowExpression.Compile(bodytimezone, nameof(bodytimezone), required: false);
            var __workflow_bodyselfSufficient = WorkflowExpression.Compile(bodyselfSufficient, nameof(bodyselfSufficient), required: false);
            var __workflow_bodyisSecret = WorkflowExpression.Compile(bodyisSecret, nameof(bodyisSecret), required: false);
            var __workflow_bodypublishOptionalData = WorkflowExpression.Compile(bodypublishOptionalData, nameof(bodypublishOptionalData), required: false);
            return new DeferredBodyAction<GraphPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/users/graphs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                bodypropCount++;
                body["unit"] = ExpressionConverter.ConvertO(__workflow_bodyunit);
                bodypropCount++;
                body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                bodypropCount++;
                body["color"] = ExpressionConverter.ConvertO(__workflow_bodycolor);
                if (__workflow_bodytimezone != null)
                {
                    body["timezone"] = ExpressionConverter.ConvertO(__workflow_bodytimezone);
                    bodypropCount++;
                }

                if (__workflow_bodyselfSufficient != null)
                {
                    body["selfSufficient"] = ExpressionConverter.ConvertO(__workflow_bodyselfSufficient);
                    bodypropCount++;
                }

                if (__workflow_bodyisSecret != null)
                {
                    body["isSecret"] = ExpressionConverter.ConvertO(__workflow_bodyisSecret);
                    bodypropCount++;
                }

                if (__workflow_bodypublishOptionalData != null)
                {
                    body["publishOptionalData"] = ExpressionConverter.ConvertO(__workflow_bodypublishOptionalData);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GraphPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<GraphPutResponse, ApiConnectionActionConfiguration> GraphPut(Expression<Func<string>> graphId, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodyunit = null, Expression<Func<bodycolorInput>> bodycolor = null, Expression<Func<string>> bodytimezone = null, Expression<Func<string>> bodyselfSufficient = null, Expression<Func<bool>> bodyisSecret = null, Expression<Func<bool>> bodypublishOptionalData = null)
        {
            var __workflow_graphId = WorkflowExpression.Compile(graphId, nameof(graphId), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodyunit = WorkflowExpression.Compile(bodyunit, nameof(bodyunit), required: false);
            var __workflow_bodycolor = WorkflowExpression.Compile(bodycolor, nameof(bodycolor), required: false);
            var __workflow_bodytimezone = WorkflowExpression.Compile(bodytimezone, nameof(bodytimezone), required: false);
            var __workflow_bodyselfSufficient = WorkflowExpression.Compile(bodyselfSufficient, nameof(bodyselfSufficient), required: false);
            var __workflow_bodyisSecret = WorkflowExpression.Compile(bodyisSecret, nameof(bodyisSecret), required: false);
            var __workflow_bodypublishOptionalData = WorkflowExpression.Compile(bodypublishOptionalData, nameof(bodypublishOptionalData), required: false);
            return new DeferredBodyAction<GraphPutResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/users/graphs";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["graphID"] = ExpressionConverter.Convert(__workflow_graphId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodyunit != null)
                {
                    if (__workflow_bodyunit != null)
                    {
                        body["unit"] = ExpressionConverter.ConvertO(__workflow_bodyunit);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["unit"] = "commit";
                    bodypropCount++;
                }

                if (__workflow_bodycolor != null)
                {
                    if (__workflow_bodycolor != null)
                    {
                        body["color"] = ExpressionConverter.ConvertO(__workflow_bodycolor);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["color"] = "shibafu";
                    bodypropCount++;
                }

                if (__workflow_bodytimezone != null)
                {
                    body["timezone"] = ExpressionConverter.ConvertO(__workflow_bodytimezone);
                    bodypropCount++;
                }

                if (__workflow_bodyselfSufficient != null)
                {
                    body["selfSufficient"] = ExpressionConverter.ConvertO(__workflow_bodyselfSufficient);
                    bodypropCount++;
                }

                if (__workflow_bodyisSecret != null)
                {
                    body["isSecret"] = ExpressionConverter.ConvertO(__workflow_bodyisSecret);
                    bodypropCount++;
                }

                if (__workflow_bodypublishOptionalData != null)
                {
                    body["publishOptionalData"] = ExpressionConverter.ConvertO(__workflow_bodypublishOptionalData);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GraphPutResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<GraphGetResponse, ApiConnectionActionConfiguration> GraphGet(Expression<Func<string>> graphId)
        {
            var __workflow_graphId = WorkflowExpression.Compile(graphId, nameof(graphId), required: true);
            return new DeferredBodyAction<GraphGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/users/graphs/graph-def";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["graphID"] = ExpressionConverter.Convert(__workflow_graphId);
                return new ApiConnectionAction<GraphGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<GraphSVGGetResponse, ApiConnectionActionConfiguration> GraphSVGGet(Expression<Func<string>> graphId, Expression<Func<string>> date = null, Expression<Func<modeInput>> mode = null, Expression<Func<appearanceInput>> appearance = null)
        {
            var __workflow_graphId = WorkflowExpression.Compile(graphId, nameof(graphId), required: true);
            var __workflow_date = WorkflowExpression.Compile(date, nameof(date), required: false);
            var __workflow_mode = WorkflowExpression.Compile(mode, nameof(mode), required: false);
            var __workflow_appearance = WorkflowExpression.Compile(appearance, nameof(appearance), required: false);
            return new DeferredBodyAction<GraphSVGGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/users/graphs/graphSVG";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["graphID"] = ExpressionConverter.Convert(__workflow_graphId);
                if (__workflow_date != null)
                    callPayload.Queries["date"] = ExpressionConverter.Convert(__workflow_date);
                if (__workflow_mode != null)
                    callPayload.Queries["mode"] = ExpressionConverter.Convert(__workflow_mode);
                if (__workflow_appearance != null)
                    callPayload.Queries["appearance"] = ExpressionConverter.Convert(__workflow_appearance);
                return new ApiConnectionAction<GraphSVGGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<PixelsGetResponse, ApiConnectionActionConfiguration> PixelsGet(Expression<Func<string>> graphId, Expression<Func<string>> from = null, Expression<Func<string>> to = null, Expression<Func<bool>> withBody = null)
        {
            var __workflow_graphId = WorkflowExpression.Compile(graphId, nameof(graphId), required: true);
            var __workflow_from = WorkflowExpression.Compile(from, nameof(from), required: false);
            var __workflow_to = WorkflowExpression.Compile(to, nameof(to), required: false);
            var __workflow_withBody = WorkflowExpression.Compile(withBody, nameof(withBody), required: false);
            return new DeferredBodyAction<PixelsGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/users/graphs/pixels";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["graphID"] = ExpressionConverter.Convert(__workflow_graphId);
                if (__workflow_from != null)
                    callPayload.Queries["from"] = ExpressionConverter.Convert(__workflow_from);
                if (__workflow_to != null)
                    callPayload.Queries["to"] = ExpressionConverter.Convert(__workflow_to);
                if (__workflow_withBody != null)
                    callPayload.Queries["withBody"] = ExpressionConverter.Convert(__workflow_withBody);
                return new ApiConnectionAction<PixelsGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<StatsGetResponse, ApiConnectionActionConfiguration> StatsGet(Expression<Func<string>> graphId)
        {
            var __workflow_graphId = WorkflowExpression.Compile(graphId, nameof(graphId), required: true);
            return new DeferredBodyAction<StatsGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/users/graphs/stats";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["graphID"] = ExpressionConverter.Convert(__workflow_graphId);
                return new ApiConnectionAction<StatsGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<PixelPostResponse, ApiConnectionActionConfiguration> Pixel(Expression<Func<string>> graphId, Expression<Func<string>> bodydate, Expression<Func<string>> bodyquantity)
        {
            var __workflow_graphId = WorkflowExpression.Compile(graphId, nameof(graphId), required: true);
            var __workflow_bodydate = WorkflowExpression.Compile(bodydate, nameof(bodydate), required: true);
            var __workflow_bodyquantity = WorkflowExpression.Compile(bodyquantity, nameof(bodyquantity), required: true);
            return new DeferredBodyAction<PixelPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/users/graphs/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["graphID"] = ExpressionConverter.Convert(__workflow_graphId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["date"] = ExpressionConverter.ConvertO(__workflow_bodydate);
                bodypropCount++;
                body["quantity"] = ExpressionConverter.ConvertO(__workflow_bodyquantity);
                var optionalDataObject = new JObject();
                var optionalDataObjectpropCount = 0;
                if (optionalDataObjectpropCount > 0)
                {
                    body["optionalData"] = optionalDataObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PixelPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<PixelGetResponse, ApiConnectionActionConfiguration> PixelGet(Expression<Func<string>> graphId, Expression<Func<string>> yyyyMMdd)
        {
            var __workflow_graphId = WorkflowExpression.Compile(graphId, nameof(graphId), required: true);
            var __workflow_yyyyMMdd = WorkflowExpression.Compile(yyyyMMdd, nameof(yyyyMMdd), required: true);
            return new DeferredBodyAction<PixelGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/users/graphs/pixel";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["graphID"] = ExpressionConverter.Convert(__workflow_graphId);
                callPayload.Queries["yyyyMMdd"] = ExpressionConverter.Convert(__workflow_yyyyMMdd);
                return new ApiConnectionAction<PixelGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<PixelDeleteResponse, ApiConnectionActionConfiguration> PixelDelete(Expression<Func<string>> graphId, Expression<Func<string>> yyyyMMdd)
        {
            var __workflow_graphId = WorkflowExpression.Compile(graphId, nameof(graphId), required: true);
            var __workflow_yyyyMMdd = WorkflowExpression.Compile(yyyyMMdd, nameof(yyyyMMdd), required: true);
            return new DeferredBodyAction<PixelDeleteResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/users/graphs/pixel";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["graphID"] = ExpressionConverter.Convert(__workflow_graphId);
                callPayload.Queries["yyyyMMdd"] = ExpressionConverter.Convert(__workflow_yyyyMMdd);
                return new ApiConnectionAction<PixelDeleteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<PixelPutResponse, ApiConnectionActionConfiguration> PixelPut(Expression<Func<string>> graphId, Expression<Func<string>> yyyyMMdd)
        {
            var __workflow_graphId = WorkflowExpression.Compile(graphId, nameof(graphId), required: true);
            var __workflow_yyyyMMdd = WorkflowExpression.Compile(yyyyMMdd, nameof(yyyyMMdd), required: true);
            return new DeferredBodyAction<PixelPutResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/users/graphs/pixel";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["graphID"] = ExpressionConverter.Convert(__workflow_graphId);
                callPayload.Queries["yyyyMMdd"] = ExpressionConverter.Convert(__workflow_yyyyMMdd);
                return new ApiConnectionAction<PixelPutResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<PixelRetinaGetResponse, ApiConnectionActionConfiguration> PixelRetinaGet(Expression<Func<string>> graphId, Expression<Func<string>> yyyyMMdd)
        {
            var __workflow_graphId = WorkflowExpression.Compile(graphId, nameof(graphId), required: true);
            var __workflow_yyyyMMdd = WorkflowExpression.Compile(yyyyMMdd, nameof(yyyyMMdd), required: true);
            return new DeferredBodyAction<PixelRetinaGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/users/graphs/pixel/retina";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["graphID"] = ExpressionConverter.Convert(__workflow_graphId);
                callPayload.Queries["yyyyMMdd"] = ExpressionConverter.Convert(__workflow_yyyyMMdd);
                return new ApiConnectionAction<PixelRetinaGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<PixelIncrementPutResponse, ApiConnectionActionConfiguration> PixelIncrementPut(Expression<Func<string>> graphId = null)
        {
            var __workflow_graphId = WorkflowExpression.Compile(graphId, nameof(graphId), required: false);
            return new DeferredBodyAction<PixelIncrementPutResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/users/graphs/increment";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_graphId != null)
                    callPayload.Queries["graphID"] = ExpressionConverter.Convert(__workflow_graphId);
                callPayload.Headers["Content-Length"] = Convert.ToString(0);
                return new ApiConnectionAction<PixelIncrementPutResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<PixelDecrementPutResponse, ApiConnectionActionConfiguration> PixelDecrementPut(Expression<Func<string>> graphId = null)
        {
            var __workflow_graphId = WorkflowExpression.Compile(graphId, nameof(graphId), required: false);
            return new DeferredBodyAction<PixelDecrementPutResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/users/graphs/decrement";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_graphId != null)
                    callPayload.Queries["graphID"] = ExpressionConverter.Convert(__workflow_graphId);
                callPayload.Headers["Content-Length"] = Convert.ToString(0);
                return new ApiConnectionAction<PixelDecrementPutResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<PixelAddPutResponse, ApiConnectionActionConfiguration> PixelAddPut(Expression<Func<string>> graphId, Expression<Func<int>> bodyquantity = null)
        {
            var __workflow_graphId = WorkflowExpression.Compile(graphId, nameof(graphId), required: true);
            var __workflow_bodyquantity = WorkflowExpression.Compile(bodyquantity, nameof(bodyquantity), required: false);
            return new DeferredBodyAction<PixelAddPutResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/users/graphs/add";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["graphID"] = ExpressionConverter.Convert(__workflow_graphId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyquantity != null)
                {
                    body["quantity"] = ExpressionConverter.ConvertO(__workflow_bodyquantity);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PixelAddPutResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<PixelSubtractPutResponse, ApiConnectionActionConfiguration> PixelSubtractPut(Expression<Func<string>> graphId, Expression<Func<int>> bodyquantity = null)
        {
            var __workflow_graphId = WorkflowExpression.Compile(graphId, nameof(graphId), required: true);
            var __workflow_bodyquantity = WorkflowExpression.Compile(bodyquantity, nameof(bodyquantity), required: false);
            return new DeferredBodyAction<PixelSubtractPutResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/users/graphs/subtract";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["graphID"] = ExpressionConverter.Convert(__workflow_graphId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyquantity != null)
                {
                    body["quantity"] = ExpressionConverter.ConvertO(__workflow_bodyquantity);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PixelSubtractPutResponse>(callPayload);
            });
        }
    }

    public class PixelaipTriggers([ConnectionName] string connectionId)
    {
    }

    public class UserDeleteResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }
    }

    public class UserPostResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyagreeTermsOfServiceInput
    {
        [EnumMember(Value = "yes")]
        Yes,
        [EnumMember(Value = "no")]
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodynotMinorInput
    {
        [EnumMember(Value = "yes")]
        Yes,
        [EnumMember(Value = "no")]
        No
    }

    public class TokenPutResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }
    }

    public class ProfilePutResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }
    }

    public class GraphsGetResponse
    {
        [JsonProperty("graphs")]
        public GraphsGetResponseGraphsTypeItem[] Graphs { get; set; }
    }

    public class GraphsGetResponseGraphsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("purgeCacheURLs")]
        public string[] PurgeCacheURLs { get; set; }

        [JsonProperty("selfSufficient")]
        public string SelfSufficient { get; set; }

        [JsonProperty("isSecret")]
        public bool IsSecret { get; set; }

        [JsonProperty("publishOptionalData")]
        public bool PublishOptionalData { get; set; }
    }

    public class GraphDeleteResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }
    }

    public class GraphPostResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodytypeInput
    {
        [EnumMember(Value = "int")]
        Int,
        [EnumMember(Value = "float")]
        Float
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodycolorInput
    {
        [EnumMember(Value = "shibafu")]
        Shibafu,
        [EnumMember(Value = "momiji")]
        Momiji,
        [EnumMember(Value = "sora")]
        Sora,
        [EnumMember(Value = "ichou")]
        Ichou,
        [EnumMember(Value = "ajisai")]
        Ajisai,
        [EnumMember(Value = "kuro")]
        Kuro
    }

    public class GraphPutResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }
    }

    public class GraphGetResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("purgeCacheURLs")]
        public string[] PurgeCacheURLs { get; set; }

        [JsonProperty("selfSufficient")]
        public string SelfSufficient { get; set; }

        [JsonProperty("isSecret")]
        public bool IsSecret { get; set; }

        [JsonProperty("publishOptionalData")]
        public bool PublishOptionalData { get; set; }
    }

    public class GraphSVGGetResponse
    {
        [JsonProperty("$content-type")]
        public string ContentType { get; set; }

        [JsonProperty("$content")]
        public string Content { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum modeInput
    {
        [EnumMember(Value = "short")]
        Short,
        [EnumMember(Value = "badge")]
        Badge,
        [EnumMember(Value = "line")]
        Line
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum appearanceInput
    {
        [EnumMember(Value = "dark")]
        Dark
    }

    public class PixelsGetResponse
    {
        [JsonProperty("pixels")]
        public PixelsGetResponsePixelsTypeItem[] Pixels { get; set; }
    }

    public class PixelsGetResponsePixelsTypeItem
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("quantity")]
        public string Quantity { get; set; }

        [JsonProperty("optionalData")]
        public JToken OptionalData { get; set; }
    }

    public class StatsGetResponse
    {
        [JsonProperty("totalPixelsCount")]
        public int TotalPixelsCount { get; set; }

        [JsonProperty("maxQuantity")]
        public int MaxQuantity { get; set; }

        [JsonProperty("minQuantity")]
        public int MinQuantity { get; set; }

        [JsonProperty("totalQuantity")]
        public int TotalQuantity { get; set; }

        [JsonProperty("avgQuantity")]
        public double AvgQuantity { get; set; }

        [JsonProperty("todaysQuantity")]
        public int TodaysQuantity { get; set; }
    }

    public class PixelPostResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }
    }

    public class PixelGetResponse
    {
        [JsonProperty("quantity")]
        public string Quantity { get; set; }
    }

    public class PixelDeleteResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }
    }

    public class PixelPutResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }
    }

    public class PixelRetinaGetResponse
    {
        [JsonProperty("$content-type")]
        public string ContentType { get; set; }

        [JsonProperty("$content")]
        public string Content { get; set; }
    }

    public class PixelIncrementPutResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }
    }

    public class PixelDecrementPutResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }
    }

    public class PixelAddPutResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }
    }

    public class PixelSubtractPutResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Pixelaip;

    public partial class WorkflowManagedActions
    {
        public PixelaipActions Pixelaip(string connectionId) => new PixelaipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PixelaipTriggers Pixelaip(string connectionId) => new PixelaipTriggers(connectionId);
    }
}