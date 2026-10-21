//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Anttextautomation
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AnttextautomationActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "anttextautomation")]
        public IBodyWorkflowAction<string> PostAntTextEmail(Expression<Func<string>> postBodyParameteremailForAntTextBusiness, Expression<Func<string>> postBodyParameterantTextBusinessLicenseKey, Expression<Func<string>> postBodyParameterkeyPhraseConfirmation, Expression<Func<string>> postBodyParametertemplateID, Expression<Func<string>> postBodyParameterto, Expression<Func<postBodyParametersaveCopyToSentItemsInput>> postBodyParametersaveCopyToSentItems = null, Expression<Func<postBodyParameterimportanceInput>> postBodyParameterimportance = null, Expression<Func<string>> postBodyParameterflowField1 = null, Expression<Func<string>> postBodyParameterflowField2 = null, Expression<Func<string>> postBodyParameterflowField3 = null, Expression<Func<string>> postBodyParameterflowField4 = null, Expression<Func<string>> postBodyParameterflowField5 = null, Expression<Func<string>> postBodyParameterflowField6 = null, Expression<Func<string>> postBodyParameterflowField7 = null, Expression<Func<string>> postBodyParameterflowField8 = null, Expression<Func<string>> postBodyParameterflowField9 = null, Expression<Func<string>> postBodyParameterflowField10 = null, Expression<Func<string>> postBodyParameterflowField11 = null, Expression<Func<string>> postBodyParameterflowField12 = null, Expression<Func<string>> postBodyParameterflowField13 = null, Expression<Func<string>> postBodyParameterflowField14 = null, Expression<Func<string>> postBodyParameterflowField15 = null, Expression<Func<string>> postBodyParameterflowField16 = null, Expression<Func<string>> postBodyParameterflowField17 = null, Expression<Func<string>> postBodyParameterflowField18 = null, Expression<Func<string>> postBodyParameterflowField19 = null, Expression<Func<string>> postBodyParameterflowField20 = null, Expression<Func<postBodyParameterincludeAntTextSignatureInput>> postBodyParameterincludeAntTextSignature = null)
        {
            var __workflow_postBodyParameteremailForAntTextBusiness = WorkflowExpression.Compile(postBodyParameteremailForAntTextBusiness, nameof(postBodyParameteremailForAntTextBusiness), required: true);
            var __workflow_postBodyParameterantTextBusinessLicenseKey = WorkflowExpression.Compile(postBodyParameterantTextBusinessLicenseKey, nameof(postBodyParameterantTextBusinessLicenseKey), required: true);
            var __workflow_postBodyParameterkeyPhraseConfirmation = WorkflowExpression.Compile(postBodyParameterkeyPhraseConfirmation, nameof(postBodyParameterkeyPhraseConfirmation), required: true);
            var __workflow_postBodyParametertemplateID = WorkflowExpression.Compile(postBodyParametertemplateID, nameof(postBodyParametertemplateID), required: true);
            var __workflow_postBodyParameterto = WorkflowExpression.Compile(postBodyParameterto, nameof(postBodyParameterto), required: true);
            var __workflow_postBodyParametersaveCopyToSentItems = WorkflowExpression.Compile(postBodyParametersaveCopyToSentItems, nameof(postBodyParametersaveCopyToSentItems), required: false);
            var __workflow_postBodyParameterimportance = WorkflowExpression.Compile(postBodyParameterimportance, nameof(postBodyParameterimportance), required: false);
            var __workflow_postBodyParameterflowField1 = WorkflowExpression.Compile(postBodyParameterflowField1, nameof(postBodyParameterflowField1), required: false);
            var __workflow_postBodyParameterflowField2 = WorkflowExpression.Compile(postBodyParameterflowField2, nameof(postBodyParameterflowField2), required: false);
            var __workflow_postBodyParameterflowField3 = WorkflowExpression.Compile(postBodyParameterflowField3, nameof(postBodyParameterflowField3), required: false);
            var __workflow_postBodyParameterflowField4 = WorkflowExpression.Compile(postBodyParameterflowField4, nameof(postBodyParameterflowField4), required: false);
            var __workflow_postBodyParameterflowField5 = WorkflowExpression.Compile(postBodyParameterflowField5, nameof(postBodyParameterflowField5), required: false);
            var __workflow_postBodyParameterflowField6 = WorkflowExpression.Compile(postBodyParameterflowField6, nameof(postBodyParameterflowField6), required: false);
            var __workflow_postBodyParameterflowField7 = WorkflowExpression.Compile(postBodyParameterflowField7, nameof(postBodyParameterflowField7), required: false);
            var __workflow_postBodyParameterflowField8 = WorkflowExpression.Compile(postBodyParameterflowField8, nameof(postBodyParameterflowField8), required: false);
            var __workflow_postBodyParameterflowField9 = WorkflowExpression.Compile(postBodyParameterflowField9, nameof(postBodyParameterflowField9), required: false);
            var __workflow_postBodyParameterflowField10 = WorkflowExpression.Compile(postBodyParameterflowField10, nameof(postBodyParameterflowField10), required: false);
            var __workflow_postBodyParameterflowField11 = WorkflowExpression.Compile(postBodyParameterflowField11, nameof(postBodyParameterflowField11), required: false);
            var __workflow_postBodyParameterflowField12 = WorkflowExpression.Compile(postBodyParameterflowField12, nameof(postBodyParameterflowField12), required: false);
            var __workflow_postBodyParameterflowField13 = WorkflowExpression.Compile(postBodyParameterflowField13, nameof(postBodyParameterflowField13), required: false);
            var __workflow_postBodyParameterflowField14 = WorkflowExpression.Compile(postBodyParameterflowField14, nameof(postBodyParameterflowField14), required: false);
            var __workflow_postBodyParameterflowField15 = WorkflowExpression.Compile(postBodyParameterflowField15, nameof(postBodyParameterflowField15), required: false);
            var __workflow_postBodyParameterflowField16 = WorkflowExpression.Compile(postBodyParameterflowField16, nameof(postBodyParameterflowField16), required: false);
            var __workflow_postBodyParameterflowField17 = WorkflowExpression.Compile(postBodyParameterflowField17, nameof(postBodyParameterflowField17), required: false);
            var __workflow_postBodyParameterflowField18 = WorkflowExpression.Compile(postBodyParameterflowField18, nameof(postBodyParameterflowField18), required: false);
            var __workflow_postBodyParameterflowField19 = WorkflowExpression.Compile(postBodyParameterflowField19, nameof(postBodyParameterflowField19), required: false);
            var __workflow_postBodyParameterflowField20 = WorkflowExpression.Compile(postBodyParameterflowField20, nameof(postBodyParameterflowField20), required: false);
            var __workflow_postBodyParameterincludeAntTextSignature = WorkflowExpression.Compile(postBodyParameterincludeAntTextSignature, nameof(postBodyParameterincludeAntTextSignature), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/templates";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var postBodyParameter = new JObject();
                var postBodyParameterpropCount = 0;
                postBodyParameterpropCount++;
                postBodyParameter["AntTextOwner"] = ExpressionConverter.ConvertO(__workflow_postBodyParameteremailForAntTextBusiness);
                postBodyParameterpropCount++;
                postBodyParameter["AntTextLicenseKey"] = ExpressionConverter.ConvertO(__workflow_postBodyParameterantTextBusinessLicenseKey);
                postBodyParameterpropCount++;
                postBodyParameter["CalledFrom"] = ExpressionConverter.ConvertO(__workflow_postBodyParameterkeyPhraseConfirmation);
                postBodyParameterpropCount++;
                postBodyParameter["TemplateID"] = ExpressionConverter.ConvertO(__workflow_postBodyParametertemplateID);
                postBodyParameterpropCount++;
                postBodyParameter["To"] = ExpressionConverter.ConvertO(__workflow_postBodyParameterto);
                if (__workflow_postBodyParametersaveCopyToSentItems != null)
                {
                    if (__workflow_postBodyParametersaveCopyToSentItems != null)
                    {
                        postBodyParameter["SaveCopyToSentItems"] = ExpressionConverter.ConvertO(__workflow_postBodyParametersaveCopyToSentItems);
                        postBodyParameterpropCount++;
                    }

                    postBodyParameterpropCount++;
                }
                else
                {
                    postBodyParameter["SaveCopyToSentItems"] = "Yes";
                    postBodyParameterpropCount++;
                }

                if (__workflow_postBodyParameterimportance != null)
                {
                    if (__workflow_postBodyParameterimportance != null)
                    {
                        postBodyParameter["Importance"] = ExpressionConverter.ConvertO(__workflow_postBodyParameterimportance);
                        postBodyParameterpropCount++;
                    }

                    postBodyParameterpropCount++;
                }
                else
                {
                    postBodyParameter["Importance"] = "Normal";
                    postBodyParameterpropCount++;
                }

                if (__workflow_postBodyParameterflowField1 != null)
                {
                    postBodyParameter["FlowField1"] = ExpressionConverter.ConvertO(__workflow_postBodyParameterflowField1);
                    postBodyParameterpropCount++;
                }

                if (__workflow_postBodyParameterflowField2 != null)
                {
                    postBodyParameter["FlowField2"] = ExpressionConverter.ConvertO(__workflow_postBodyParameterflowField2);
                    postBodyParameterpropCount++;
                }

                if (__workflow_postBodyParameterflowField3 != null)
                {
                    postBodyParameter["FlowField3"] = ExpressionConverter.ConvertO(__workflow_postBodyParameterflowField3);
                    postBodyParameterpropCount++;
                }

                if (__workflow_postBodyParameterflowField4 != null)
                {
                    postBodyParameter["FlowField4"] = ExpressionConverter.ConvertO(__workflow_postBodyParameterflowField4);
                    postBodyParameterpropCount++;
                }

                if (__workflow_postBodyParameterflowField5 != null)
                {
                    postBodyParameter["FlowField5"] = ExpressionConverter.ConvertO(__workflow_postBodyParameterflowField5);
                    postBodyParameterpropCount++;
                }

                if (__workflow_postBodyParameterflowField6 != null)
                {
                    postBodyParameter["FlowField6"] = ExpressionConverter.ConvertO(__workflow_postBodyParameterflowField6);
                    postBodyParameterpropCount++;
                }

                if (__workflow_postBodyParameterflowField7 != null)
                {
                    postBodyParameter["FlowField7"] = ExpressionConverter.ConvertO(__workflow_postBodyParameterflowField7);
                    postBodyParameterpropCount++;
                }

                if (__workflow_postBodyParameterflowField8 != null)
                {
                    postBodyParameter["FlowField8"] = ExpressionConverter.ConvertO(__workflow_postBodyParameterflowField8);
                    postBodyParameterpropCount++;
                }

                if (__workflow_postBodyParameterflowField9 != null)
                {
                    postBodyParameter["FlowField9"] = ExpressionConverter.ConvertO(__workflow_postBodyParameterflowField9);
                    postBodyParameterpropCount++;
                }

                if (__workflow_postBodyParameterflowField10 != null)
                {
                    postBodyParameter["FlowField10"] = ExpressionConverter.ConvertO(__workflow_postBodyParameterflowField10);
                    postBodyParameterpropCount++;
                }

                if (__workflow_postBodyParameterflowField11 != null)
                {
                    postBodyParameter["FlowField11"] = ExpressionConverter.ConvertO(__workflow_postBodyParameterflowField11);
                    postBodyParameterpropCount++;
                }

                if (__workflow_postBodyParameterflowField12 != null)
                {
                    postBodyParameter["FlowField12"] = ExpressionConverter.ConvertO(__workflow_postBodyParameterflowField12);
                    postBodyParameterpropCount++;
                }

                if (__workflow_postBodyParameterflowField13 != null)
                {
                    postBodyParameter["FlowField13"] = ExpressionConverter.ConvertO(__workflow_postBodyParameterflowField13);
                    postBodyParameterpropCount++;
                }

                if (__workflow_postBodyParameterflowField14 != null)
                {
                    postBodyParameter["FlowField14"] = ExpressionConverter.ConvertO(__workflow_postBodyParameterflowField14);
                    postBodyParameterpropCount++;
                }

                if (__workflow_postBodyParameterflowField15 != null)
                {
                    postBodyParameter["FlowField15"] = ExpressionConverter.ConvertO(__workflow_postBodyParameterflowField15);
                    postBodyParameterpropCount++;
                }

                if (__workflow_postBodyParameterflowField16 != null)
                {
                    postBodyParameter["FlowField16"] = ExpressionConverter.ConvertO(__workflow_postBodyParameterflowField16);
                    postBodyParameterpropCount++;
                }

                if (__workflow_postBodyParameterflowField17 != null)
                {
                    postBodyParameter["FlowField17"] = ExpressionConverter.ConvertO(__workflow_postBodyParameterflowField17);
                    postBodyParameterpropCount++;
                }

                if (__workflow_postBodyParameterflowField18 != null)
                {
                    postBodyParameter["FlowField18"] = ExpressionConverter.ConvertO(__workflow_postBodyParameterflowField18);
                    postBodyParameterpropCount++;
                }

                if (__workflow_postBodyParameterflowField19 != null)
                {
                    postBodyParameter["FlowField19"] = ExpressionConverter.ConvertO(__workflow_postBodyParameterflowField19);
                    postBodyParameterpropCount++;
                }

                if (__workflow_postBodyParameterflowField20 != null)
                {
                    postBodyParameter["FlowField20"] = ExpressionConverter.ConvertO(__workflow_postBodyParameterflowField20);
                    postBodyParameterpropCount++;
                }

                if (__workflow_postBodyParameterincludeAntTextSignature != null)
                {
                    if (__workflow_postBodyParameterincludeAntTextSignature != null)
                    {
                        postBodyParameter["IncludeAntTextSignature"] = ExpressionConverter.ConvertO(__workflow_postBodyParameterincludeAntTextSignature);
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

                return new ApiConnectionAction<string>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }
    }

    public class AnttextautomationTriggers([ConnectionName] string connectionId)
    {
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum postBodyParametersaveCopyToSentItemsInput
    {
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum postBodyParameterimportanceInput
    {
        High,
        Normal,
        Low
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
