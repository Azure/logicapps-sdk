//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pixelaip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PixelaipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<UserDeleteResponse> UserDelete()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/users/";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<UserDeleteResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<UserPostResponse> User([WorkflowExpression] Func<string> bodytoken = null, [WorkflowExpression] Func<string> bodyusername = null, [WorkflowExpression] Func<bodyagreeTermsOfServiceInput> bodyagreeTermsOfService = null, [WorkflowExpression] Func<bodynotMinorInput> bodynotMinor = null, [WorkflowExpression] Func<string> bodythanksCode = null)
        {
            SourceExpression.Validate(bodytoken, nameof(bodytoken), required: false);
            SourceExpression.Validate(bodyusername, nameof(bodyusername), required: false);
            SourceExpression.Validate(bodyagreeTermsOfService, nameof(bodyagreeTermsOfService), required: false);
            SourceExpression.Validate(bodynotMinor, nameof(bodynotMinor), required: false);
            SourceExpression.Validate(bodythanksCode, nameof(bodythanksCode), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/users/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytoken != null)
                {
                    body["token"] = SourceExpressionConverter.ConvertToken(bodytoken);
                    bodypropCount++;
                }

                if (bodyusername != null)
                {
                    body["username"] = SourceExpressionConverter.ConvertToken(bodyusername);
                    bodypropCount++;
                }

                if (bodyagreeTermsOfService != null)
                {
                    if (bodyagreeTermsOfService != null)
                    {
                        body["agreeTermsOfService"] = SourceExpressionConverter.Convert(bodyagreeTermsOfService);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["agreeTermsOfService"] = "yes";
                    bodypropCount++;
                }

                if (bodynotMinor != null)
                {
                    if (bodynotMinor != null)
                    {
                        body["notMinor"] = SourceExpressionConverter.Convert(bodynotMinor);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["notMinor"] = "yes";
                    bodypropCount++;
                }

                if (bodythanksCode != null)
                {
                    body["thanksCode"] = SourceExpressionConverter.ConvertToken(bodythanksCode);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UserPostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<TokenPutResponse> TokenPut([WorkflowExpression] Func<string> bodynewToken, [WorkflowExpression] Func<string> bodythanksCode = null)
        {
            SourceExpression.Validate(bodynewToken, nameof(bodynewToken), required: true);
            SourceExpression.Validate(bodythanksCode, nameof(bodythanksCode), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/users/";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["newToken"] = SourceExpressionConverter.ConvertToken(bodynewToken);
                if (bodythanksCode != null)
                {
                    body["thanksCode"] = SourceExpressionConverter.ConvertToken(bodythanksCode);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<TokenPutResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<ProfilePutResponse> ProfilePut([WorkflowExpression] Func<string> bodydisplayName = null, [WorkflowExpression] Func<string> bodygravatarIconEmail = null, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodytimezone = null, [WorkflowExpression] Func<string> bodyaboutURL = null, [WorkflowExpression] Func<string[]> bodycontributeURLs = null, [WorkflowExpression] Func<string> bodypinnedGraphId = null)
        {
            SourceExpression.Validate(bodydisplayName, nameof(bodydisplayName), required: false);
            SourceExpression.Validate(bodygravatarIconEmail, nameof(bodygravatarIconEmail), required: false);
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            SourceExpression.Validate(bodytimezone, nameof(bodytimezone), required: false);
            SourceExpression.Validate(bodyaboutURL, nameof(bodyaboutURL), required: false);
            SourceExpression.Validate(bodycontributeURLs, nameof(bodycontributeURLs), required: false);
            SourceExpression.Validate(bodypinnedGraphId, nameof(bodypinnedGraphId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/@";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydisplayName != null)
                {
                    body["displayName"] = SourceExpressionConverter.ConvertToken(bodydisplayName);
                    bodypropCount++;
                }

                if (bodygravatarIconEmail != null)
                {
                    body["gravatarIconEmail"] = SourceExpressionConverter.ConvertToken(bodygravatarIconEmail);
                    bodypropCount++;
                }

                if (bodytitle != null)
                {
                    body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodytimezone != null)
                {
                    body["timezone"] = SourceExpressionConverter.ConvertToken(bodytimezone);
                    bodypropCount++;
                }

                if (bodyaboutURL != null)
                {
                    body["aboutURL"] = SourceExpressionConverter.ConvertToken(bodyaboutURL);
                    bodypropCount++;
                }

                if (bodycontributeURLs != null)
                {
                    body["contributeURLs"] = SourceExpressionConverter.ConvertToken(bodycontributeURLs);
                    bodypropCount++;
                }

                if (bodypinnedGraphId != null)
                {
                    body["pinnedGraphID"] = SourceExpressionConverter.ConvertToken(bodypinnedGraphId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ProfilePutResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<GraphsGetResponse> GraphsGet()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/users/graphs";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GraphsGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<GraphDeleteResponse> GraphDelete([WorkflowExpression] Func<string> graphId)
        {
            SourceExpression.Validate(graphId, nameof(graphId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/users/graphs";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["graphID"] = SourceExpressionConverter.ConvertO(graphId);
                return callPayload;
            }

            return new ApiConnectionAction<GraphDeleteResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<GraphPostResponse> Graph([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodyunit, [WorkflowExpression] Func<bodytypeInput> bodytype, [WorkflowExpression] Func<bodycolorInput> bodycolor, [WorkflowExpression] Func<string> bodytimezone = null, [WorkflowExpression] Func<string> bodyselfSufficient = null, [WorkflowExpression] Func<bool> bodyisSecret = null, [WorkflowExpression] Func<bool> bodypublishOptionalData = null)
        {
            SourceExpression.Validate(bodyid, nameof(bodyid), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            SourceExpression.Validate(bodyunit, nameof(bodyunit), required: true);
            SourceExpression.Validate(bodytype, nameof(bodytype), required: true);
            SourceExpression.Validate(bodycolor, nameof(bodycolor), required: true);
            SourceExpression.Validate(bodytimezone, nameof(bodytimezone), required: false);
            SourceExpression.Validate(bodyselfSufficient, nameof(bodyselfSufficient), required: false);
            SourceExpression.Validate(bodyisSecret, nameof(bodyisSecret), required: false);
            SourceExpression.Validate(bodypublishOptionalData, nameof(bodypublishOptionalData), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/users/graphs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
                body["unit"] = SourceExpressionConverter.ConvertToken(bodyunit);
                bodypropCount++;
                body["type"] = SourceExpressionConverter.Convert(bodytype);
                bodypropCount++;
                body["color"] = SourceExpressionConverter.Convert(bodycolor);
                if (bodytimezone != null)
                {
                    body["timezone"] = SourceExpressionConverter.ConvertToken(bodytimezone);
                    bodypropCount++;
                }

                if (bodyselfSufficient != null)
                {
                    body["selfSufficient"] = SourceExpressionConverter.ConvertToken(bodyselfSufficient);
                    bodypropCount++;
                }

                if (bodyisSecret != null)
                {
                    body["isSecret"] = SourceExpressionConverter.ConvertToken(bodyisSecret);
                    bodypropCount++;
                }

                if (bodypublishOptionalData != null)
                {
                    body["publishOptionalData"] = SourceExpressionConverter.ConvertToken(bodypublishOptionalData);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GraphPostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<GraphPutResponse> GraphPut([WorkflowExpression] Func<string> graphId, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodyunit = null, [WorkflowExpression] Func<bodycolorInput> bodycolor = null, [WorkflowExpression] Func<string> bodytimezone = null, [WorkflowExpression] Func<string> bodyselfSufficient = null, [WorkflowExpression] Func<bool> bodyisSecret = null, [WorkflowExpression] Func<bool> bodypublishOptionalData = null)
        {
            SourceExpression.Validate(graphId, nameof(graphId), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodyunit, nameof(bodyunit), required: false);
            SourceExpression.Validate(bodycolor, nameof(bodycolor), required: false);
            SourceExpression.Validate(bodytimezone, nameof(bodytimezone), required: false);
            SourceExpression.Validate(bodyselfSufficient, nameof(bodyselfSufficient), required: false);
            SourceExpression.Validate(bodyisSecret, nameof(bodyisSecret), required: false);
            SourceExpression.Validate(bodypublishOptionalData, nameof(bodypublishOptionalData), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/users/graphs";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["graphID"] = SourceExpressionConverter.ConvertO(graphId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodyunit != null)
                {
                    if (bodyunit != null)
                    {
                        body["unit"] = SourceExpressionConverter.ConvertToken(bodyunit);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["unit"] = "commit";
                    bodypropCount++;
                }

                if (bodycolor != null)
                {
                    if (bodycolor != null)
                    {
                        body["color"] = SourceExpressionConverter.Convert(bodycolor);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["color"] = "shibafu";
                    bodypropCount++;
                }

                if (bodytimezone != null)
                {
                    body["timezone"] = SourceExpressionConverter.ConvertToken(bodytimezone);
                    bodypropCount++;
                }

                if (bodyselfSufficient != null)
                {
                    body["selfSufficient"] = SourceExpressionConverter.ConvertToken(bodyselfSufficient);
                    bodypropCount++;
                }

                if (bodyisSecret != null)
                {
                    body["isSecret"] = SourceExpressionConverter.ConvertToken(bodyisSecret);
                    bodypropCount++;
                }

                if (bodypublishOptionalData != null)
                {
                    body["publishOptionalData"] = SourceExpressionConverter.ConvertToken(bodypublishOptionalData);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GraphPutResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<GraphGetResponse> GraphGet([WorkflowExpression] Func<string> graphId)
        {
            SourceExpression.Validate(graphId, nameof(graphId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/users/graphs/graph-def";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["graphID"] = SourceExpressionConverter.ConvertO(graphId);
                return callPayload;
            }

            return new ApiConnectionAction<GraphGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<GraphSVGGetResponse> GraphSVGGet([WorkflowExpression] Func<string> graphId, [WorkflowExpression] Func<string> date = null, [WorkflowExpression] Func<modeInput> mode = null, [WorkflowExpression] Func<appearanceInput> appearance = null)
        {
            SourceExpression.Validate(graphId, nameof(graphId), required: true);
            SourceExpression.Validate(date, nameof(date), required: false);
            SourceExpression.Validate(mode, nameof(mode), required: false);
            SourceExpression.Validate(appearance, nameof(appearance), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/users/graphs/graphSVG";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["graphID"] = SourceExpressionConverter.ConvertO(graphId);
                if (date != null)
                    callPayload.Queries["date"] = SourceExpressionConverter.ConvertO(date);
                if (mode != null)
                    callPayload.Queries["mode"] = SourceExpressionConverter.Convert(mode);
                if (appearance != null)
                    callPayload.Queries["appearance"] = SourceExpressionConverter.Convert(appearance);
                return callPayload;
            }

            return new ApiConnectionAction<GraphSVGGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<PixelsGetResponse> PixelsGet([WorkflowExpression] Func<string> graphId, [WorkflowExpression] Func<string> from = null, [WorkflowExpression] Func<string> to = null, [WorkflowExpression] Func<bool> withBody = null)
        {
            SourceExpression.Validate(graphId, nameof(graphId), required: true);
            SourceExpression.Validate(from, nameof(from), required: false);
            SourceExpression.Validate(to, nameof(to), required: false);
            SourceExpression.Validate(withBody, nameof(withBody), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/users/graphs/pixels";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["graphID"] = SourceExpressionConverter.ConvertO(graphId);
                if (from != null)
                    callPayload.Queries["from"] = SourceExpressionConverter.ConvertO(from);
                if (to != null)
                    callPayload.Queries["to"] = SourceExpressionConverter.ConvertO(to);
                if (withBody != null)
                    callPayload.Queries["withBody"] = SourceExpressionConverter.ConvertO(withBody);
                return callPayload;
            }

            return new ApiConnectionAction<PixelsGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<StatsGetResponse> StatsGet([WorkflowExpression] Func<string> graphId)
        {
            SourceExpression.Validate(graphId, nameof(graphId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/users/graphs/stats";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["graphID"] = SourceExpressionConverter.ConvertO(graphId);
                return callPayload;
            }

            return new ApiConnectionAction<StatsGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<PixelPostResponse> Pixel([WorkflowExpression] Func<string> graphId, [WorkflowExpression] Func<string> bodydate, [WorkflowExpression] Func<string> bodyquantity)
        {
            SourceExpression.Validate(graphId, nameof(graphId), required: true);
            SourceExpression.Validate(bodydate, nameof(bodydate), required: true);
            SourceExpression.Validate(bodyquantity, nameof(bodyquantity), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/users/graphs/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["graphID"] = SourceExpressionConverter.ConvertO(graphId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["date"] = SourceExpressionConverter.ConvertToken(bodydate);
                bodypropCount++;
                body["quantity"] = SourceExpressionConverter.ConvertToken(bodyquantity);
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
                return callPayload;
            }

            return new ApiConnectionAction<PixelPostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<PixelGetResponse> PixelGet([WorkflowExpression] Func<string> graphId, [WorkflowExpression] Func<string> yyyyMMdd)
        {
            SourceExpression.Validate(graphId, nameof(graphId), required: true);
            SourceExpression.Validate(yyyyMMdd, nameof(yyyyMMdd), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/users/graphs/pixel";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["graphID"] = SourceExpressionConverter.ConvertO(graphId);
                callPayload.Queries["yyyyMMdd"] = SourceExpressionConverter.ConvertO(yyyyMMdd);
                return callPayload;
            }

            return new ApiConnectionAction<PixelGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<PixelDeleteResponse> PixelDelete([WorkflowExpression] Func<string> graphId, [WorkflowExpression] Func<string> yyyyMMdd)
        {
            SourceExpression.Validate(graphId, nameof(graphId), required: true);
            SourceExpression.Validate(yyyyMMdd, nameof(yyyyMMdd), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/users/graphs/pixel";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["graphID"] = SourceExpressionConverter.ConvertO(graphId);
                callPayload.Queries["yyyyMMdd"] = SourceExpressionConverter.ConvertO(yyyyMMdd);
                return callPayload;
            }

            return new ApiConnectionAction<PixelDeleteResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<PixelPutResponse> PixelPut([WorkflowExpression] Func<string> graphId, [WorkflowExpression] Func<string> yyyyMMdd)
        {
            SourceExpression.Validate(graphId, nameof(graphId), required: true);
            SourceExpression.Validate(yyyyMMdd, nameof(yyyyMMdd), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/users/graphs/pixel";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["graphID"] = SourceExpressionConverter.ConvertO(graphId);
                callPayload.Queries["yyyyMMdd"] = SourceExpressionConverter.ConvertO(yyyyMMdd);
                return callPayload;
            }

            return new ApiConnectionAction<PixelPutResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<PixelRetinaGetResponse> PixelRetinaGet([WorkflowExpression] Func<string> graphId, [WorkflowExpression] Func<string> yyyyMMdd)
        {
            SourceExpression.Validate(graphId, nameof(graphId), required: true);
            SourceExpression.Validate(yyyyMMdd, nameof(yyyyMMdd), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/users/graphs/pixel/retina";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["graphID"] = SourceExpressionConverter.ConvertO(graphId);
                callPayload.Queries["yyyyMMdd"] = SourceExpressionConverter.ConvertO(yyyyMMdd);
                return callPayload;
            }

            return new ApiConnectionAction<PixelRetinaGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<PixelIncrementPutResponse> PixelIncrementPut([WorkflowExpression] Func<string> graphId = null)
        {
            SourceExpression.Validate(graphId, nameof(graphId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/users/graphs/increment";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (graphId != null)
                    callPayload.Queries["graphID"] = SourceExpressionConverter.ConvertO(graphId);
                callPayload.Headers["Content-Length"] = Convert.ToString(0);
                return callPayload;
            }

            return new ApiConnectionAction<PixelIncrementPutResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<PixelDecrementPutResponse> PixelDecrementPut([WorkflowExpression] Func<string> graphId = null)
        {
            SourceExpression.Validate(graphId, nameof(graphId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/users/graphs/decrement";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (graphId != null)
                    callPayload.Queries["graphID"] = SourceExpressionConverter.ConvertO(graphId);
                callPayload.Headers["Content-Length"] = Convert.ToString(0);
                return callPayload;
            }

            return new ApiConnectionAction<PixelDecrementPutResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<PixelAddPutResponse> PixelAddPut([WorkflowExpression] Func<string> graphId, [WorkflowExpression] Func<int> bodyquantity = null)
        {
            SourceExpression.Validate(graphId, nameof(graphId), required: true);
            SourceExpression.Validate(bodyquantity, nameof(bodyquantity), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/users/graphs/add";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["graphID"] = SourceExpressionConverter.ConvertO(graphId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyquantity != null)
                {
                    body["quantity"] = SourceExpressionConverter.ConvertToken(bodyquantity);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PixelAddPutResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<PixelSubtractPutResponse> PixelSubtractPut([WorkflowExpression] Func<string> graphId, [WorkflowExpression] Func<int> bodyquantity = null)
        {
            SourceExpression.Validate(graphId, nameof(graphId), required: true);
            SourceExpression.Validate(bodyquantity, nameof(bodyquantity), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/users/graphs/subtract";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["graphID"] = SourceExpressionConverter.ConvertO(graphId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyquantity != null)
                {
                    body["quantity"] = SourceExpressionConverter.ConvertToken(bodyquantity);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PixelSubtractPutResponse>(BuildSourceInput);
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

    public enum bodyagreeTermsOfServiceInput
    {
        [EnumMember(Value = "yes")]
        Yes,
        [EnumMember(Value = "no")]
        No
    }

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

    public enum bodytypeInput
    {
        [EnumMember(Value = "int")]
        Int,
        [EnumMember(Value = "float")]
        Float
    }

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

    public enum modeInput
    {
        [EnumMember(Value = "short")]
        Short,
        [EnumMember(Value = "badge")]
        Badge,
        [EnumMember(Value = "line")]
        Line
    }

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