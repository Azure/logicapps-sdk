//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Anttextautomation
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AnttextautomationActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "anttextautomation")]
        public IBodyWorkflowAction<string> PostAntTextEmail([WorkflowExpression] Func<string> postBodyParameteremailForAntTextBusiness, [WorkflowExpression] Func<string> postBodyParameterantTextBusinessLicenseKey, [WorkflowExpression] Func<string> postBodyParameterkeyPhraseConfirmation, [WorkflowExpression] Func<string> postBodyParametertemplateId, [WorkflowExpression] Func<string> postBodyParameterto, [WorkflowExpression] Func<postBodyParametersaveCopyToSentItemsInput> postBodyParametersaveCopyToSentItems = null, [WorkflowExpression] Func<postBodyParameterimportanceInput> postBodyParameterimportance = null, [WorkflowExpression] Func<string> postBodyParameterflowField1 = null, [WorkflowExpression] Func<string> postBodyParameterflowField2 = null, [WorkflowExpression] Func<string> postBodyParameterflowField3 = null, [WorkflowExpression] Func<string> postBodyParameterflowField4 = null, [WorkflowExpression] Func<string> postBodyParameterflowField5 = null, [WorkflowExpression] Func<string> postBodyParameterflowField6 = null, [WorkflowExpression] Func<string> postBodyParameterflowField7 = null, [WorkflowExpression] Func<string> postBodyParameterflowField8 = null, [WorkflowExpression] Func<string> postBodyParameterflowField9 = null, [WorkflowExpression] Func<string> postBodyParameterflowField10 = null, [WorkflowExpression] Func<string> postBodyParameterflowField11 = null, [WorkflowExpression] Func<string> postBodyParameterflowField12 = null, [WorkflowExpression] Func<string> postBodyParameterflowField13 = null, [WorkflowExpression] Func<string> postBodyParameterflowField14 = null, [WorkflowExpression] Func<string> postBodyParameterflowField15 = null, [WorkflowExpression] Func<string> postBodyParameterflowField16 = null, [WorkflowExpression] Func<string> postBodyParameterflowField17 = null, [WorkflowExpression] Func<string> postBodyParameterflowField18 = null, [WorkflowExpression] Func<string> postBodyParameterflowField19 = null, [WorkflowExpression] Func<string> postBodyParameterflowField20 = null, [WorkflowExpression] Func<postBodyParameterincludeAntTextSignatureInput> postBodyParameterincludeAntTextSignature = null)
        {
            SourceExpression.Validate(postBodyParameteremailForAntTextBusiness, nameof(postBodyParameteremailForAntTextBusiness), required: true);
            SourceExpression.Validate(postBodyParameterantTextBusinessLicenseKey, nameof(postBodyParameterantTextBusinessLicenseKey), required: true);
            SourceExpression.Validate(postBodyParameterkeyPhraseConfirmation, nameof(postBodyParameterkeyPhraseConfirmation), required: true);
            SourceExpression.Validate(postBodyParametertemplateId, nameof(postBodyParametertemplateId), required: true);
            SourceExpression.Validate(postBodyParameterto, nameof(postBodyParameterto), required: true);
            SourceExpression.Validate(postBodyParametersaveCopyToSentItems, nameof(postBodyParametersaveCopyToSentItems), required: false);
            SourceExpression.Validate(postBodyParameterimportance, nameof(postBodyParameterimportance), required: false);
            SourceExpression.Validate(postBodyParameterflowField1, nameof(postBodyParameterflowField1), required: false);
            SourceExpression.Validate(postBodyParameterflowField2, nameof(postBodyParameterflowField2), required: false);
            SourceExpression.Validate(postBodyParameterflowField3, nameof(postBodyParameterflowField3), required: false);
            SourceExpression.Validate(postBodyParameterflowField4, nameof(postBodyParameterflowField4), required: false);
            SourceExpression.Validate(postBodyParameterflowField5, nameof(postBodyParameterflowField5), required: false);
            SourceExpression.Validate(postBodyParameterflowField6, nameof(postBodyParameterflowField6), required: false);
            SourceExpression.Validate(postBodyParameterflowField7, nameof(postBodyParameterflowField7), required: false);
            SourceExpression.Validate(postBodyParameterflowField8, nameof(postBodyParameterflowField8), required: false);
            SourceExpression.Validate(postBodyParameterflowField9, nameof(postBodyParameterflowField9), required: false);
            SourceExpression.Validate(postBodyParameterflowField10, nameof(postBodyParameterflowField10), required: false);
            SourceExpression.Validate(postBodyParameterflowField11, nameof(postBodyParameterflowField11), required: false);
            SourceExpression.Validate(postBodyParameterflowField12, nameof(postBodyParameterflowField12), required: false);
            SourceExpression.Validate(postBodyParameterflowField13, nameof(postBodyParameterflowField13), required: false);
            SourceExpression.Validate(postBodyParameterflowField14, nameof(postBodyParameterflowField14), required: false);
            SourceExpression.Validate(postBodyParameterflowField15, nameof(postBodyParameterflowField15), required: false);
            SourceExpression.Validate(postBodyParameterflowField16, nameof(postBodyParameterflowField16), required: false);
            SourceExpression.Validate(postBodyParameterflowField17, nameof(postBodyParameterflowField17), required: false);
            SourceExpression.Validate(postBodyParameterflowField18, nameof(postBodyParameterflowField18), required: false);
            SourceExpression.Validate(postBodyParameterflowField19, nameof(postBodyParameterflowField19), required: false);
            SourceExpression.Validate(postBodyParameterflowField20, nameof(postBodyParameterflowField20), required: false);
            SourceExpression.Validate(postBodyParameterincludeAntTextSignature, nameof(postBodyParameterincludeAntTextSignature), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/templates";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var postBodyParameter = new JObject();
                var postBodyParameterpropCount = 0;
                postBodyParameterpropCount++;
                postBodyParameter["AntTextOwner"] = SourceExpressionConverter.ConvertToken(postBodyParameteremailForAntTextBusiness);
                postBodyParameterpropCount++;
                postBodyParameter["AntTextLicenseKey"] = SourceExpressionConverter.ConvertToken(postBodyParameterantTextBusinessLicenseKey);
                postBodyParameterpropCount++;
                postBodyParameter["CalledFrom"] = SourceExpressionConverter.ConvertToken(postBodyParameterkeyPhraseConfirmation);
                postBodyParameterpropCount++;
                postBodyParameter["TemplateID"] = SourceExpressionConverter.ConvertToken(postBodyParametertemplateId);
                postBodyParameterpropCount++;
                postBodyParameter["To"] = SourceExpressionConverter.ConvertToken(postBodyParameterto);
                if (postBodyParametersaveCopyToSentItems != null)
                {
                    if (postBodyParametersaveCopyToSentItems != null)
                    {
                        postBodyParameter["SaveCopyToSentItems"] = SourceExpressionConverter.Convert(postBodyParametersaveCopyToSentItems);
                        postBodyParameterpropCount++;
                    }

                    postBodyParameterpropCount++;
                }
                else
                {
                    postBodyParameter["SaveCopyToSentItems"] = "Yes";
                    postBodyParameterpropCount++;
                }

                if (postBodyParameterimportance != null)
                {
                    if (postBodyParameterimportance != null)
                    {
                        postBodyParameter["Importance"] = SourceExpressionConverter.Convert(postBodyParameterimportance);
                        postBodyParameterpropCount++;
                    }

                    postBodyParameterpropCount++;
                }
                else
                {
                    postBodyParameter["Importance"] = "Normal";
                    postBodyParameterpropCount++;
                }

                if (postBodyParameterflowField1 != null)
                {
                    postBodyParameter["FlowField1"] = SourceExpressionConverter.ConvertToken(postBodyParameterflowField1);
                    postBodyParameterpropCount++;
                }

                if (postBodyParameterflowField2 != null)
                {
                    postBodyParameter["FlowField2"] = SourceExpressionConverter.ConvertToken(postBodyParameterflowField2);
                    postBodyParameterpropCount++;
                }

                if (postBodyParameterflowField3 != null)
                {
                    postBodyParameter["FlowField3"] = SourceExpressionConverter.ConvertToken(postBodyParameterflowField3);
                    postBodyParameterpropCount++;
                }

                if (postBodyParameterflowField4 != null)
                {
                    postBodyParameter["FlowField4"] = SourceExpressionConverter.ConvertToken(postBodyParameterflowField4);
                    postBodyParameterpropCount++;
                }

                if (postBodyParameterflowField5 != null)
                {
                    postBodyParameter["FlowField5"] = SourceExpressionConverter.ConvertToken(postBodyParameterflowField5);
                    postBodyParameterpropCount++;
                }

                if (postBodyParameterflowField6 != null)
                {
                    postBodyParameter["FlowField6"] = SourceExpressionConverter.ConvertToken(postBodyParameterflowField6);
                    postBodyParameterpropCount++;
                }

                if (postBodyParameterflowField7 != null)
                {
                    postBodyParameter["FlowField7"] = SourceExpressionConverter.ConvertToken(postBodyParameterflowField7);
                    postBodyParameterpropCount++;
                }

                if (postBodyParameterflowField8 != null)
                {
                    postBodyParameter["FlowField8"] = SourceExpressionConverter.ConvertToken(postBodyParameterflowField8);
                    postBodyParameterpropCount++;
                }

                if (postBodyParameterflowField9 != null)
                {
                    postBodyParameter["FlowField9"] = SourceExpressionConverter.ConvertToken(postBodyParameterflowField9);
                    postBodyParameterpropCount++;
                }

                if (postBodyParameterflowField10 != null)
                {
                    postBodyParameter["FlowField10"] = SourceExpressionConverter.ConvertToken(postBodyParameterflowField10);
                    postBodyParameterpropCount++;
                }

                if (postBodyParameterflowField11 != null)
                {
                    postBodyParameter["FlowField11"] = SourceExpressionConverter.ConvertToken(postBodyParameterflowField11);
                    postBodyParameterpropCount++;
                }

                if (postBodyParameterflowField12 != null)
                {
                    postBodyParameter["FlowField12"] = SourceExpressionConverter.ConvertToken(postBodyParameterflowField12);
                    postBodyParameterpropCount++;
                }

                if (postBodyParameterflowField13 != null)
                {
                    postBodyParameter["FlowField13"] = SourceExpressionConverter.ConvertToken(postBodyParameterflowField13);
                    postBodyParameterpropCount++;
                }

                if (postBodyParameterflowField14 != null)
                {
                    postBodyParameter["FlowField14"] = SourceExpressionConverter.ConvertToken(postBodyParameterflowField14);
                    postBodyParameterpropCount++;
                }

                if (postBodyParameterflowField15 != null)
                {
                    postBodyParameter["FlowField15"] = SourceExpressionConverter.ConvertToken(postBodyParameterflowField15);
                    postBodyParameterpropCount++;
                }

                if (postBodyParameterflowField16 != null)
                {
                    postBodyParameter["FlowField16"] = SourceExpressionConverter.ConvertToken(postBodyParameterflowField16);
                    postBodyParameterpropCount++;
                }

                if (postBodyParameterflowField17 != null)
                {
                    postBodyParameter["FlowField17"] = SourceExpressionConverter.ConvertToken(postBodyParameterflowField17);
                    postBodyParameterpropCount++;
                }

                if (postBodyParameterflowField18 != null)
                {
                    postBodyParameter["FlowField18"] = SourceExpressionConverter.ConvertToken(postBodyParameterflowField18);
                    postBodyParameterpropCount++;
                }

                if (postBodyParameterflowField19 != null)
                {
                    postBodyParameter["FlowField19"] = SourceExpressionConverter.ConvertToken(postBodyParameterflowField19);
                    postBodyParameterpropCount++;
                }

                if (postBodyParameterflowField20 != null)
                {
                    postBodyParameter["FlowField20"] = SourceExpressionConverter.ConvertToken(postBodyParameterflowField20);
                    postBodyParameterpropCount++;
                }

                if (postBodyParameterincludeAntTextSignature != null)
                {
                    if (postBodyParameterincludeAntTextSignature != null)
                    {
                        postBodyParameter["IncludeAntTextSignature"] = SourceExpressionConverter.Convert(postBodyParameterincludeAntTextSignature);
                        postBodyParameterpropCount++;
                    }

                    postBodyParameterpropCount++;
                }
                else
                {
                    postBodyParameter["IncludeAntTextSignature"] = "Yes";
                    postBodyParameterpropCount++;
                }

                if (postBodyParameterpropCount > 0)
                {
                    callPayload.Body = postBodyParameter;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }
    }

    public class AnttextautomationTriggers([ConnectionName] string connectionId)
    {
    }

    public enum postBodyParametersaveCopyToSentItemsInput
    {
        Yes,
        No
    }

    public enum postBodyParameterimportanceInput
    {
        High,
        Normal,
        Low
    }

    public enum postBodyParameterincludeAntTextSignatureInput
    {
        Yes,
        No
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Anttextautomation;

    public partial class WorkflowManagedActions
    {
        public AnttextautomationActions Anttextautomation(string connectionId) => new AnttextautomationActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AnttextautomationTriggers Anttextautomation(string connectionId) => new AnttextautomationTriggers(connectionId);
    }
}