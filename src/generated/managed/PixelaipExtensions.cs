//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pixelaip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class PixelaipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<UserDeleteResponse> UserDelete()
        {
            var apiCallPath = "/v1/users/";
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<UserDeleteResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<UserPostResponse> User(Expression<Func<string>> bodytoken = null, Expression<Func<string>> bodyusername = null, Expression<Func<bodyagreeTermsOfServiceInput>> bodyagreeTermsOfService = null, Expression<Func<bodynotMinorInput>> bodynotMinor = null, Expression<Func<string>> bodythanksCode = null)
        {
            var __workflow_bodytoken = bodytoken == null ? null : WorkflowExpression.Compile(bodytoken);
            WorkflowExpression.Validate(__workflow_bodytoken, nameof(bodytoken), required: false);
            var __workflow_bodyusername = bodyusername == null ? null : WorkflowExpression.Compile(bodyusername);
            WorkflowExpression.Validate(__workflow_bodyusername, nameof(bodyusername), required: false);
            var __workflow_bodyagreeTermsOfService = bodyagreeTermsOfService == null ? null : WorkflowExpression.Compile(bodyagreeTermsOfService);
            WorkflowExpression.Validate(__workflow_bodyagreeTermsOfService, nameof(bodyagreeTermsOfService), required: false);
            var __workflow_bodynotMinor = bodynotMinor == null ? null : WorkflowExpression.Compile(bodynotMinor);
            WorkflowExpression.Validate(__workflow_bodynotMinor, nameof(bodynotMinor), required: false);
            var __workflow_bodythanksCode = bodythanksCode == null ? null : WorkflowExpression.Compile(bodythanksCode);
            WorkflowExpression.Validate(__workflow_bodythanksCode, nameof(bodythanksCode), required: false);
            return new DeferredBodyAction<UserPostResponse>(() =>
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
        public IBodyWorkflowAction<TokenPutResponse> TokenPut(Expression<Func<string>> bodynewToken, Expression<Func<string>> bodythanksCode = null)
        {
            var __workflow_bodynewToken = bodynewToken == null ? null : WorkflowExpression.Compile(bodynewToken);
            WorkflowExpression.Validate(__workflow_bodynewToken, nameof(bodynewToken), required: true);
            var __workflow_bodythanksCode = bodythanksCode == null ? null : WorkflowExpression.Compile(bodythanksCode);
            WorkflowExpression.Validate(__workflow_bodythanksCode, nameof(bodythanksCode), required: false);
            return new DeferredBodyAction<TokenPutResponse>(() =>
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
        public IBodyWorkflowAction<ProfilePutResponse> ProfilePut(Expression<Func<string>> bodydisplayName = null, Expression<Func<string>> bodygravatarIconEmail = null, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodytimezone = null, Expression<Func<string>> bodyaboutURL = null, Expression<Func<string[]>> bodycontributeURLs = null, Expression<Func<string>> bodypinnedGraphID = null)
        {
            var __workflow_bodydisplayName = bodydisplayName == null ? null : WorkflowExpression.Compile(bodydisplayName);
            WorkflowExpression.Validate(__workflow_bodydisplayName, nameof(bodydisplayName), required: false);
            var __workflow_bodygravatarIconEmail = bodygravatarIconEmail == null ? null : WorkflowExpression.Compile(bodygravatarIconEmail);
            WorkflowExpression.Validate(__workflow_bodygravatarIconEmail, nameof(bodygravatarIconEmail), required: false);
            var __workflow_bodytitle = bodytitle == null ? null : WorkflowExpression.Compile(bodytitle);
            WorkflowExpression.Validate(__workflow_bodytitle, nameof(bodytitle), required: false);
            var __workflow_bodytimezone = bodytimezone == null ? null : WorkflowExpression.Compile(bodytimezone);
            WorkflowExpression.Validate(__workflow_bodytimezone, nameof(bodytimezone), required: false);
            var __workflow_bodyaboutURL = bodyaboutURL == null ? null : WorkflowExpression.Compile(bodyaboutURL);
            WorkflowExpression.Validate(__workflow_bodyaboutURL, nameof(bodyaboutURL), required: false);
            var __workflow_bodycontributeURLs = bodycontributeURLs == null ? null : WorkflowExpression.Compile(bodycontributeURLs);
            WorkflowExpression.Validate(__workflow_bodycontributeURLs, nameof(bodycontributeURLs), required: false);
            var __workflow_bodypinnedGraphID = bodypinnedGraphID == null ? null : WorkflowExpression.Compile(bodypinnedGraphID);
            WorkflowExpression.Validate(__workflow_bodypinnedGraphID, nameof(bodypinnedGraphID), required: false);
            return new DeferredBodyAction<ProfilePutResponse>(() =>
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

                if (__workflow_bodypinnedGraphID != null)
                {
                    body["pinnedGraphID"] = ExpressionConverter.ConvertO(__workflow_bodypinnedGraphID);
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
        public IBodyWorkflowAction<GraphsGetResponse> GraphsGet()
        {
            var apiCallPath = "/v1/users/graphs";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GraphsGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<GraphDeleteResponse> GraphDelete(Expression<Func<string>> graphID)
        {
            var __workflow_graphID = graphID == null ? null : WorkflowExpression.Compile(graphID);
            WorkflowExpression.Validate(__workflow_graphID, nameof(graphID), required: true);
            return new DeferredBodyAction<GraphDeleteResponse>(() =>
            {
                var apiCallPath = "/v1/users/graphs";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["graphID"] = ExpressionConverter.Convert(__workflow_graphID);
                return new ApiConnectionAction<GraphDeleteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<GraphPostResponse> Graph(Expression<Func<string>> bodyid, Expression<Func<string>> bodyname, Expression<Func<string>> bodyunit, Expression<Func<bodytypeInput>> bodytype, Expression<Func<bodycolorInput>> bodycolor, Expression<Func<string>> bodytimezone = null, Expression<Func<string>> bodyselfSufficient = null, Expression<Func<bool>> bodyisSecret = null, Expression<Func<bool>> bodypublishOptionalData = null)
        {
            var __workflow_bodyid = bodyid == null ? null : WorkflowExpression.Compile(bodyid);
            WorkflowExpression.Validate(__workflow_bodyid, nameof(bodyid), required: true);
            var __workflow_bodyname = bodyname == null ? null : WorkflowExpression.Compile(bodyname);
            WorkflowExpression.Validate(__workflow_bodyname, nameof(bodyname), required: true);
            var __workflow_bodyunit = bodyunit == null ? null : WorkflowExpression.Compile(bodyunit);
            WorkflowExpression.Validate(__workflow_bodyunit, nameof(bodyunit), required: true);
            var __workflow_bodytype = bodytype == null ? null : WorkflowExpression.Compile(bodytype);
            WorkflowExpression.Validate(__workflow_bodytype, nameof(bodytype), required: true);
            var __workflow_bodycolor = bodycolor == null ? null : WorkflowExpression.Compile(bodycolor);
            WorkflowExpression.Validate(__workflow_bodycolor, nameof(bodycolor), required: true);
            var __workflow_bodytimezone = bodytimezone == null ? null : WorkflowExpression.Compile(bodytimezone);
            WorkflowExpression.Validate(__workflow_bodytimezone, nameof(bodytimezone), required: false);
            var __workflow_bodyselfSufficient = bodyselfSufficient == null ? null : WorkflowExpression.Compile(bodyselfSufficient);
            WorkflowExpression.Validate(__workflow_bodyselfSufficient, nameof(bodyselfSufficient), required: false);
            var __workflow_bodyisSecret = bodyisSecret == null ? null : WorkflowExpression.Compile(bodyisSecret);
            WorkflowExpression.Validate(__workflow_bodyisSecret, nameof(bodyisSecret), required: false);
            var __workflow_bodypublishOptionalData = bodypublishOptionalData == null ? null : WorkflowExpression.Compile(bodypublishOptionalData);
            WorkflowExpression.Validate(__workflow_bodypublishOptionalData, nameof(bodypublishOptionalData), required: false);
            return new DeferredBodyAction<GraphPostResponse>(() =>
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
        public IBodyWorkflowAction<GraphPutResponse> GraphPut(Expression<Func<string>> graphID, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodyunit = null, Expression<Func<bodycolorInput>> bodycolor = null, Expression<Func<string>> bodytimezone = null, Expression<Func<string>> bodyselfSufficient = null, Expression<Func<bool>> bodyisSecret = null, Expression<Func<bool>> bodypublishOptionalData = null)
        {
            var __workflow_graphID = graphID == null ? null : WorkflowExpression.Compile(graphID);
            WorkflowExpression.Validate(__workflow_graphID, nameof(graphID), required: true);
            var __workflow_bodyname = bodyname == null ? null : WorkflowExpression.Compile(bodyname);
            WorkflowExpression.Validate(__workflow_bodyname, nameof(bodyname), required: false);
            var __workflow_bodyunit = bodyunit == null ? null : WorkflowExpression.Compile(bodyunit);
            WorkflowExpression.Validate(__workflow_bodyunit, nameof(bodyunit), required: false);
            var __workflow_bodycolor = bodycolor == null ? null : WorkflowExpression.Compile(bodycolor);
            WorkflowExpression.Validate(__workflow_bodycolor, nameof(bodycolor), required: false);
            var __workflow_bodytimezone = bodytimezone == null ? null : WorkflowExpression.Compile(bodytimezone);
            WorkflowExpression.Validate(__workflow_bodytimezone, nameof(bodytimezone), required: false);
            var __workflow_bodyselfSufficient = bodyselfSufficient == null ? null : WorkflowExpression.Compile(bodyselfSufficient);
            WorkflowExpression.Validate(__workflow_bodyselfSufficient, nameof(bodyselfSufficient), required: false);
            var __workflow_bodyisSecret = bodyisSecret == null ? null : WorkflowExpression.Compile(bodyisSecret);
            WorkflowExpression.Validate(__workflow_bodyisSecret, nameof(bodyisSecret), required: false);
            var __workflow_bodypublishOptionalData = bodypublishOptionalData == null ? null : WorkflowExpression.Compile(bodypublishOptionalData);
            WorkflowExpression.Validate(__workflow_bodypublishOptionalData, nameof(bodypublishOptionalData), required: false);
            return new DeferredBodyAction<GraphPutResponse>(() =>
            {
                var apiCallPath = "/v1/users/graphs";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["graphID"] = ExpressionConverter.Convert(__workflow_graphID);
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
        public IBodyWorkflowAction<GraphGetResponse> GraphGet(Expression<Func<string>> graphID)
        {
            var __workflow_graphID = graphID == null ? null : WorkflowExpression.Compile(graphID);
            WorkflowExpression.Validate(__workflow_graphID, nameof(graphID), required: true);
            return new DeferredBodyAction<GraphGetResponse>(() =>
            {
                var apiCallPath = "/v1/users/graphs/graph-def";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["graphID"] = ExpressionConverter.Convert(__workflow_graphID);
                return new ApiConnectionAction<GraphGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<GraphSVGGetResponse> GraphSVGGet(Expression<Func<string>> graphID, Expression<Func<string>> date = null, Expression<Func<modeInput>> mode = null, Expression<Func<appearanceInput>> appearance = null)
        {
            var __workflow_graphID = graphID == null ? null : WorkflowExpression.Compile(graphID);
            WorkflowExpression.Validate(__workflow_graphID, nameof(graphID), required: true);
            var __workflow_date = date == null ? null : WorkflowExpression.Compile(date);
            WorkflowExpression.Validate(__workflow_date, nameof(date), required: false);
            var __workflow_mode = mode == null ? null : WorkflowExpression.Compile(mode);
            WorkflowExpression.Validate(__workflow_mode, nameof(mode), required: false);
            var __workflow_appearance = appearance == null ? null : WorkflowExpression.Compile(appearance);
            WorkflowExpression.Validate(__workflow_appearance, nameof(appearance), required: false);
            return new DeferredBodyAction<GraphSVGGetResponse>(() =>
            {
                var apiCallPath = "/v1/users/graphs/graphSVG";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["graphID"] = ExpressionConverter.Convert(__workflow_graphID);
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
        public IBodyWorkflowAction<PixelsGetResponse> PixelsGet(Expression<Func<string>> graphID, Expression<Func<string>> from = null, Expression<Func<string>> to = null, Expression<Func<bool>> withBody = null)
        {
            var __workflow_graphID = graphID == null ? null : WorkflowExpression.Compile(graphID);
            WorkflowExpression.Validate(__workflow_graphID, nameof(graphID), required: true);
            var __workflow_from = from == null ? null : WorkflowExpression.Compile(from);
            WorkflowExpression.Validate(__workflow_from, nameof(from), required: false);
            var __workflow_to = to == null ? null : WorkflowExpression.Compile(to);
            WorkflowExpression.Validate(__workflow_to, nameof(to), required: false);
            var __workflow_withBody = withBody == null ? null : WorkflowExpression.Compile(withBody);
            WorkflowExpression.Validate(__workflow_withBody, nameof(withBody), required: false);
            return new DeferredBodyAction<PixelsGetResponse>(() =>
            {
                var apiCallPath = "/v1/users/graphs/pixels";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["graphID"] = ExpressionConverter.Convert(__workflow_graphID);
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
        public IBodyWorkflowAction<StatsGetResponse> StatsGet(Expression<Func<string>> graphID)
        {
            var __workflow_graphID = graphID == null ? null : WorkflowExpression.Compile(graphID);
            WorkflowExpression.Validate(__workflow_graphID, nameof(graphID), required: true);
            return new DeferredBodyAction<StatsGetResponse>(() =>
            {
                var apiCallPath = "/v1/users/graphs/stats";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["graphID"] = ExpressionConverter.Convert(__workflow_graphID);
                return new ApiConnectionAction<StatsGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<PixelPostResponse> Pixel(Expression<Func<string>> graphID, Expression<Func<string>> bodydate, Expression<Func<string>> bodyquantity)
        {
            var __workflow_graphID = graphID == null ? null : WorkflowExpression.Compile(graphID);
            WorkflowExpression.Validate(__workflow_graphID, nameof(graphID), required: true);
            var __workflow_bodydate = bodydate == null ? null : WorkflowExpression.Compile(bodydate);
            WorkflowExpression.Validate(__workflow_bodydate, nameof(bodydate), required: true);
            var __workflow_bodyquantity = bodyquantity == null ? null : WorkflowExpression.Compile(bodyquantity);
            WorkflowExpression.Validate(__workflow_bodyquantity, nameof(bodyquantity), required: true);
            return new DeferredBodyAction<PixelPostResponse>(() =>
            {
                var apiCallPath = "/v1/users/graphs/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["graphID"] = ExpressionConverter.Convert(__workflow_graphID);
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
        public IBodyWorkflowAction<PixelGetResponse> PixelGet(Expression<Func<string>> graphID, Expression<Func<string>> yyyyMMdd)
        {
            var __workflow_graphID = graphID == null ? null : WorkflowExpression.Compile(graphID);
            WorkflowExpression.Validate(__workflow_graphID, nameof(graphID), required: true);
            var __workflow_yyyyMMdd = yyyyMMdd == null ? null : WorkflowExpression.Compile(yyyyMMdd);
            WorkflowExpression.Validate(__workflow_yyyyMMdd, nameof(yyyyMMdd), required: true);
            return new DeferredBodyAction<PixelGetResponse>(() =>
            {
                var apiCallPath = "/v1/users/graphs/pixel";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["graphID"] = ExpressionConverter.Convert(__workflow_graphID);
                callPayload.Queries["yyyyMMdd"] = ExpressionConverter.Convert(__workflow_yyyyMMdd);
                return new ApiConnectionAction<PixelGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<PixelDeleteResponse> PixelDelete(Expression<Func<string>> graphID, Expression<Func<string>> yyyyMMdd)
        {
            var __workflow_graphID = graphID == null ? null : WorkflowExpression.Compile(graphID);
            WorkflowExpression.Validate(__workflow_graphID, nameof(graphID), required: true);
            var __workflow_yyyyMMdd = yyyyMMdd == null ? null : WorkflowExpression.Compile(yyyyMMdd);
            WorkflowExpression.Validate(__workflow_yyyyMMdd, nameof(yyyyMMdd), required: true);
            return new DeferredBodyAction<PixelDeleteResponse>(() =>
            {
                var apiCallPath = "/v1/users/graphs/pixel";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["graphID"] = ExpressionConverter.Convert(__workflow_graphID);
                callPayload.Queries["yyyyMMdd"] = ExpressionConverter.Convert(__workflow_yyyyMMdd);
                return new ApiConnectionAction<PixelDeleteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<PixelPutResponse> PixelPut(Expression<Func<string>> graphID, Expression<Func<string>> yyyyMMdd)
        {
            var __workflow_graphID = graphID == null ? null : WorkflowExpression.Compile(graphID);
            WorkflowExpression.Validate(__workflow_graphID, nameof(graphID), required: true);
            var __workflow_yyyyMMdd = yyyyMMdd == null ? null : WorkflowExpression.Compile(yyyyMMdd);
            WorkflowExpression.Validate(__workflow_yyyyMMdd, nameof(yyyyMMdd), required: true);
            return new DeferredBodyAction<PixelPutResponse>(() =>
            {
                var apiCallPath = "/v1/users/graphs/pixel";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["graphID"] = ExpressionConverter.Convert(__workflow_graphID);
                callPayload.Queries["yyyyMMdd"] = ExpressionConverter.Convert(__workflow_yyyyMMdd);
                return new ApiConnectionAction<PixelPutResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<PixelRetinaGetResponse> PixelRetinaGet(Expression<Func<string>> graphID, Expression<Func<string>> yyyyMMdd)
        {
            var __workflow_graphID = graphID == null ? null : WorkflowExpression.Compile(graphID);
            WorkflowExpression.Validate(__workflow_graphID, nameof(graphID), required: true);
            var __workflow_yyyyMMdd = yyyyMMdd == null ? null : WorkflowExpression.Compile(yyyyMMdd);
            WorkflowExpression.Validate(__workflow_yyyyMMdd, nameof(yyyyMMdd), required: true);
            return new DeferredBodyAction<PixelRetinaGetResponse>(() =>
            {
                var apiCallPath = "/v1/users/graphs/pixel/retina";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["graphID"] = ExpressionConverter.Convert(__workflow_graphID);
                callPayload.Queries["yyyyMMdd"] = ExpressionConverter.Convert(__workflow_yyyyMMdd);
                return new ApiConnectionAction<PixelRetinaGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<PixelIncrementPutResponse> PixelIncrementPut(Expression<Func<string>> graphID = null)
        {
            var __workflow_graphID = graphID == null ? null : WorkflowExpression.Compile(graphID);
            WorkflowExpression.Validate(__workflow_graphID, nameof(graphID), required: false);
            return new DeferredBodyAction<PixelIncrementPutResponse>(() =>
            {
                var apiCallPath = "/v1/users/graphs/increment";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_graphID != null)
                    callPayload.Queries["graphID"] = ExpressionConverter.Convert(__workflow_graphID);
                callPayload.Headers["Content-Length"] = Convert.ToString(0);
                return new ApiConnectionAction<PixelIncrementPutResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<PixelDecrementPutResponse> PixelDecrementPut(Expression<Func<string>> graphID = null)
        {
            var __workflow_graphID = graphID == null ? null : WorkflowExpression.Compile(graphID);
            WorkflowExpression.Validate(__workflow_graphID, nameof(graphID), required: false);
            return new DeferredBodyAction<PixelDecrementPutResponse>(() =>
            {
                var apiCallPath = "/v1/users/graphs/decrement";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_graphID != null)
                    callPayload.Queries["graphID"] = ExpressionConverter.Convert(__workflow_graphID);
                callPayload.Headers["Content-Length"] = Convert.ToString(0);
                return new ApiConnectionAction<PixelDecrementPutResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<PixelAddPutResponse> PixelAddPut(Expression<Func<string>> graphID, Expression<Func<int>> bodyquantity = null)
        {
            var __workflow_graphID = graphID == null ? null : WorkflowExpression.Compile(graphID);
            WorkflowExpression.Validate(__workflow_graphID, nameof(graphID), required: true);
            var __workflow_bodyquantity = bodyquantity == null ? null : WorkflowExpression.Compile(bodyquantity);
            WorkflowExpression.Validate(__workflow_bodyquantity, nameof(bodyquantity), required: false);
            return new DeferredBodyAction<PixelAddPutResponse>(() =>
            {
                var apiCallPath = "/v1/users/graphs/add";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["graphID"] = ExpressionConverter.Convert(__workflow_graphID);
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
        public IBodyWorkflowAction<PixelSubtractPutResponse> PixelSubtractPut(Expression<Func<string>> graphID, Expression<Func<int>> bodyquantity = null)
        {
            var __workflow_graphID = graphID == null ? null : WorkflowExpression.Compile(graphID);
            WorkflowExpression.Validate(__workflow_graphID, nameof(graphID), required: true);
            var __workflow_bodyquantity = bodyquantity == null ? null : WorkflowExpression.Compile(bodyquantity);
            WorkflowExpression.Validate(__workflow_bodyquantity, nameof(bodyquantity), required: false);
            return new DeferredBodyAction<PixelSubtractPutResponse>(() =>
            {
                var apiCallPath = "/v1/users/graphs/subtract";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["graphID"] = ExpressionConverter.Convert(__workflow_graphID);
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
