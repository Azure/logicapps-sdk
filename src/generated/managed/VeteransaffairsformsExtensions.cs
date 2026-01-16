//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Veteransaffairsforms
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class VeteransaffairsformsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "veteransaffairsforms")]
        public IBodyWorkflowAction<ListFormsResponse> ListForms(Expression<Func<string>> query = null)
        {
            var apiCallPath = "/forms";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (query != null)
                callPayload.Queries["query"] = ExpressionConverter.Convert(query);
            return new ApiConnectionAction<ListFormsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "veteransaffairsforms")]
        public IBodyWorkflowAction<FormShow> GetFormByName(Expression<Func<string>> formName)
        {
            var apiCallPath = String.Format("/forms/{0}", ExpressionConverter.ConvertWithUrlEncoding(formName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<FormShow>(callPayload);
        }
    }

    public class VeteransaffairsformsTriggers([ConnectionName] string connectionId)
    {
    }

    public class ListFormsResponse
    {
        [JsonProperty("data")]
        public FormsIndex[] Data { get; set; }
    }

    public class FormsIndex
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("attributes")]
        public FormsIndexAttributesType Attributes { get; set; }
    }

    public class FormsIndexAttributesType
    {
        [JsonProperty("form_name")]
        public string FormName { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("first_issued_on")]
        public string FirstIssuedOn { get; set; }

        [JsonProperty("last_revision_on")]
        public string LastRevisionOn { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("sha256")]
        public string Sha256 { get; set; }

        [JsonProperty("last_sha256_change")]
        public string LastSha256Change { get; set; }

        [JsonProperty("valid_pdf")]
        public bool ValidPdf { get; set; }

        [JsonProperty("form_usage")]
        public string FormUsage { get; set; }

        [JsonProperty("form_tool_intro")]
        public string FormToolIntro { get; set; }

        [JsonProperty("form_tool_url")]
        public string FormToolUrl { get; set; }

        [JsonProperty("form_details_url")]
        public string FormDetailsUrl { get; set; }

        [JsonProperty("form_type")]
        public string FormType { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("deleted_at")]
        public string DeletedAt { get; set; }

        [JsonProperty("related_forms")]
        public string[] RelatedForms { get; set; }

        [JsonProperty("benefit_categories")]
        public FormsIndexAttributesTypeBenefitCategoriesTypeItem[] BenefitCategories { get; set; }

        [JsonProperty("va_form_administration")]
        public string VaFormAdministration { get; set; }
    }

    public class FormsIndexAttributesTypeBenefitCategoriesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class FormShow
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("attributes")]
        public FormShowAttributesType Attributes { get; set; }
    }

    public class FormShowAttributesType
    {
        [JsonProperty("form_name")]
        public string FormName { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("first_issued_on")]
        public string FirstIssuedOn { get; set; }

        [JsonProperty("last_revision_on")]
        public string LastRevisionOn { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("sha256")]
        public string Sha256 { get; set; }

        [JsonProperty("valid_pdf")]
        public bool ValidPdf { get; set; }

        [JsonProperty("form_usage")]
        public string FormUsage { get; set; }

        [JsonProperty("form_tool_intro")]
        public string FormToolIntro { get; set; }

        [JsonProperty("form_tool_url")]
        public string FormToolUrl { get; set; }

        [JsonProperty("form_details_url")]
        public string FormDetailsUrl { get; set; }

        [JsonProperty("form_type")]
        public string FormType { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("deleted_at")]
        public string DeletedAt { get; set; }

        [JsonProperty("related_forms")]
        public string[] RelatedForms { get; set; }

        [JsonProperty("benefit_categories")]
        public FormShowAttributesTypeBenefitCategoriesTypeItem[] BenefitCategories { get; set; }

        [JsonProperty("va_form_administration")]
        public string VaFormAdministration { get; set; }

        [JsonProperty("versions")]
        public FormShowAttributesTypeVersionsTypeItem[] Versions { get; set; }
    }

    public class FormShowAttributesTypeBenefitCategoriesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class FormShowAttributesTypeVersionsTypeItem
    {
        [JsonProperty("sha256")]
        public string Sha256 { get; set; }

        [JsonProperty("revision_on")]
        public string RevisionOn { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Veteransaffairsforms;

    public partial class WorkflowManagedActions
    {
        public VeteransaffairsformsActions Veteransaffairsforms(string connectionId) => new VeteransaffairsformsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public VeteransaffairsformsTriggers Veteransaffairsforms(string connectionId) => new VeteransaffairsformsTriggers(connectionId);
    }
}