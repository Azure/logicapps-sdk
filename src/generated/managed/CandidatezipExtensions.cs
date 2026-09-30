//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Candidatezip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CandidatezipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "candidatezip")]
        public IBodyWorkflowAction<ParseResumeStandardViaFileContentResponse> ParseResumeStandardViaFileContent([WorkflowExpression] Func<string> bodyfileName, [WorkflowExpression] Func<string> bodyfileContent)
        {
            var apiCallPath = "/ParseResumeBinary-Standard";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["FileName"] = ExpressionConverter.ConvertO(bodyfileName);
            bodypropCount++;
            body["FileContent"] = ExpressionConverter.ConvertO(bodyfileContent);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ParseResumeStandardViaFileContentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "candidatezip")]
        public IBodyWorkflowAction<ParseResumeDetailViaFileContentResponse> ParseResumeDetailViaFileContent([WorkflowExpression] Func<string> bodyfileName, [WorkflowExpression] Func<string> bodyfileContent)
        {
            var apiCallPath = "/ParseResumeBinary";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["FileName"] = ExpressionConverter.ConvertO(bodyfileName);
            bodypropCount++;
            body["FileContent"] = ExpressionConverter.ConvertO(bodyfileContent);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ParseResumeDetailViaFileContentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "candidatezip")]
        public IBodyWorkflowAction<ParseResumeDetailViaUrlResponse> ParseResumeDetailViaUrl([WorkflowExpression] Func<string> bodyurl, [WorkflowExpression] Func<string> bodyfileName)
        {
            var apiCallPath = "/ParseResume";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["Url"] = ExpressionConverter.ConvertO(bodyurl);
            bodypropCount++;
            body["FileName"] = ExpressionConverter.ConvertO(bodyfileName);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ParseResumeDetailViaUrlResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "candidatezip")]
        public IBodyWorkflowAction<ParseJDViaFileContentResponse> ParseJDViaFileContent([WorkflowExpression] Func<string> bodyfileName, [WorkflowExpression] Func<string> bodyfileContent)
        {
            var apiCallPath = "/ParseJDBinary";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["FileName"] = ExpressionConverter.ConvertO(bodyfileName);
            bodypropCount++;
            body["FileContent"] = ExpressionConverter.ConvertO(bodyfileContent);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ParseJDViaFileContentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "candidatezip")]
        public IBodyWorkflowAction<ParseResumeStandardViaUrlResponse> ParseResumeStandardViaUrl([WorkflowExpression] Func<string> bodyurl, [WorkflowExpression] Func<string> bodyfileName)
        {
            var apiCallPath = "/ParseResume-Standard";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["Url"] = ExpressionConverter.ConvertO(bodyurl);
            bodypropCount++;
            body["FileName"] = ExpressionConverter.ConvertO(bodyfileName);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ParseResumeStandardViaUrlResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "candidatezip")]
        public IBodyWorkflowAction<ParseJDViaUrlResponse> ParseJDViaUrl([WorkflowExpression] Func<string> bodyurl, [WorkflowExpression] Func<string> bodyfileName)
        {
            var apiCallPath = "/ParseJD";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["Url"] = ExpressionConverter.ConvertO(bodyurl);
            bodypropCount++;
            body["FileName"] = ExpressionConverter.ConvertO(bodyfileName);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ParseJDViaUrlResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "candidatezip")]
        public IBodyWorkflowAction<ParseResumeBasicViaFileContentResponse> ParseResumeBasicViaFileContent([WorkflowExpression] Func<string> bodyfileName, [WorkflowExpression] Func<string> bodyfileContent)
        {
            var apiCallPath = "/ParseResumeBinary-Basic";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["FileName"] = ExpressionConverter.ConvertO(bodyfileName);
            bodypropCount++;
            body["FileContent"] = ExpressionConverter.ConvertO(bodyfileContent);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ParseResumeBasicViaFileContentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "candidatezip")]
        public IBodyWorkflowAction<ParseResumeBasicViaUrlResponse> ParseResumeBasicViaUrl([WorkflowExpression] Func<string> bodyurl, [WorkflowExpression] Func<string> bodyfileName)
        {
            var apiCallPath = "/ParseResume-Basic";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["Url"] = ExpressionConverter.ConvertO(bodyurl);
            bodypropCount++;
            body["FileName"] = ExpressionConverter.ConvertO(bodyfileName);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ParseResumeBasicViaUrlResponse>(callPayload);
        }
    }

    public class CandidatezipTriggers([ConnectionName] string connectionId)
    {
    }

    public class ParseResumeStandardViaFileContentResponse
    {
        [JsonProperty("Education_InstitutionCity1")]
        public string EducationInstitutionCity1 { get; set; }

        [JsonProperty("Experience_JobProfile2")]
        public string ExperienceJobProfile2 { get; set; }

        [JsonProperty("Other_ParsingDate")]
        public string OtherParsingDate { get; set; }

        [JsonProperty("Experience_StartDate2")]
        public string ExperienceStartDate2 { get; set; }

        [JsonProperty("Experience_JobLocationCountry2")]
        public string ExperienceJobLocationCountry2 { get; set; }

        [JsonProperty("Experience_Employer3")]
        public string ExperienceEmployer3 { get; set; }

        [JsonProperty("Education_AggregateMeasureType1")]
        public string EducationAggregateMeasureType1 { get; set; }

        [JsonProperty("Contact_State")]
        public string ContactState { get; set; }

        [JsonProperty("Education_SubInstitutionType1")]
        public string EducationSubInstitutionType1 { get; set; }

        [JsonProperty("Experience_CurrentEmployer")]
        public string ExperienceCurrentEmployer { get; set; }

        [JsonProperty("Contact_FormattedAddress")]
        public string ContactFormattedAddress { get; set; }

        [JsonProperty("Experience_JobLocationCity1")]
        public string ExperienceJobLocationCity1 { get; set; }

        [JsonProperty("Education_SubInstitutionCountry1")]
        public string EducationSubInstitutionCountry1 { get; set; }

        [JsonProperty("Education_SubInstitutionCity1")]
        public string EducationSubInstitutionCity1 { get; set; }

        [JsonProperty("Personal_Gender")]
        public string PersonalGender { get; set; }

        [JsonProperty("Education_SubInstitutionName1")]
        public string EducationSubInstitutionName1 { get; set; }

        [JsonProperty("Education_InstitutionCountry2")]
        public string EducationInstitutionCountry2 { get; set; }

        [JsonProperty("Contact_City")]
        public string ContactCity { get; set; }

        [JsonProperty("Education_SubInstitutionState2")]
        public string EducationSubInstitutionState2 { get; set; }

        [JsonProperty("Experience_JobLocationCountryIsoCode3")]
        public string ExperienceJobLocationCountryIsoCode3 { get; set; }

        [JsonProperty("Experience_EndDate3")]
        public string ExperienceEndDate3 { get; set; }

        [JsonProperty("Experience_JobLocationState1")]
        public string ExperienceJobLocationState1 { get; set; }

        [JsonProperty("Education_InstitutionName1")]
        public string EducationInstitutionName1 { get; set; }

        [JsonProperty("Experience_CurrentJobProfile")]
        public string ExperienceCurrentJobProfile { get; set; }

        [JsonProperty("Experience_EndDate2")]
        public string ExperienceEndDate2 { get; set; }

        [JsonProperty("Contact_MiddleName")]
        public string ContactMiddleName { get; set; }

        [JsonProperty("Experience_JobLocationState2")]
        public string ExperienceJobLocationState2 { get; set; }

        [JsonProperty("Education_InstitutionType2")]
        public string EducationInstitutionType2 { get; set; }

        [JsonProperty("Contact_Email")]
        public string ContactEmail { get; set; }

        [JsonProperty("Contact_Mobile")]
        public string ContactMobile { get; set; }

        [JsonProperty("Experience_JobDescription3")]
        public string ExperienceJobDescription3 { get; set; }

        [JsonProperty("Education_InstitutionCity2")]
        public string EducationInstitutionCity2 { get; set; }

        [JsonProperty("Personal_DateOfBirth")]
        public string PersonalDateOfBirth { get; set; }

        [JsonProperty("Other_ResumeFileData")]
        public string OtherResumeFileData { get; set; }

        [JsonProperty("Experience_TotalExperienceInYear")]
        public string ExperienceTotalExperienceInYear { get; set; }

        [JsonProperty("Experience_JobDescription2")]
        public string ExperienceJobDescription2 { get; set; }

        [JsonProperty("Contact_TitleName")]
        public string ContactTitleName { get; set; }

        [JsonProperty("Education_SubInstitutionName2")]
        public string EducationSubInstitutionName2 { get; set; }

        [JsonProperty("Experience_JobLocationCountry3")]
        public string ExperienceJobLocationCountry3 { get; set; }

        [JsonProperty("Experience_JobLocationCountry1")]
        public string ExperienceJobLocationCountry1 { get; set; }

        [JsonProperty("Education_EndDate1")]
        public string EducationEndDate1 { get; set; }

        [JsonProperty("Education_SubInstitutionCity2")]
        public string EducationSubInstitutionCity2 { get; set; }

        [JsonProperty("Education_Aggregate2")]
        public string EducationAggregate2 { get; set; }

        [JsonProperty("Education_StartDate1")]
        public string EducationStartDate1 { get; set; }

        [JsonProperty("Experience_Employer1")]
        public string ExperienceEmployer1 { get; set; }

        [JsonProperty("Experience_JobProfile3")]
        public string ExperienceJobProfile3 { get; set; }

        [JsonProperty("Contact_FormattedPhone")]
        public string ContactFormattedPhone { get; set; }

        [JsonProperty("Experience_TotalExperienceInMonths")]
        public string ExperienceTotalExperienceInMonths { get; set; }

        [JsonProperty("Education_HighestDegree")]
        public string EducationHighestDegree { get; set; }

        [JsonProperty("Contact_Country")]
        public string ContactCountry { get; set; }

        [JsonProperty("Education_SubInstitutionCountry2")]
        public string EducationSubInstitutionCountry2 { get; set; }

        [JsonProperty("Experience_JobLocationCountryIsoCode1")]
        public string ExperienceJobLocationCountryIsoCode1 { get; set; }

        [JsonProperty("Experience_JobProfile1")]
        public string ExperienceJobProfile1 { get; set; }

        [JsonProperty("Other_ResumeFileName")]
        public string OtherResumeFileName { get; set; }

        [JsonProperty("Education_InstitutionName2")]
        public string EducationInstitutionName2 { get; set; }

        [JsonProperty("Experience_StartDate3")]
        public string ExperienceStartDate3 { get; set; }

        [JsonProperty("Contact_ZipCode")]
        public string ContactZipCode { get; set; }

        [JsonProperty("Education_Aggregate1")]
        public string EducationAggregate1 { get; set; }

        [JsonProperty("Contact_FormattedMobile")]
        public string ContactFormattedMobile { get; set; }

        [JsonProperty("Experience_JobLocationCity3")]
        public string ExperienceJobLocationCity3 { get; set; }

        [JsonProperty("Contact_LastName")]
        public string ContactLastName { get; set; }

        [JsonProperty("Experience_Employer2")]
        public string ExperienceEmployer2 { get; set; }

        [JsonProperty("Contact_Address")]
        public string ContactAddress { get; set; }

        [JsonProperty("Experience_JobLocationState3")]
        public string ExperienceJobLocationState3 { get; set; }

        [JsonProperty("Education_SubInstitutionType2")]
        public string EducationSubInstitutionType2 { get; set; }

        [JsonProperty("Skill_SkillsKeywords")]
        public string SkillSkillsKeywords { get; set; }

        [JsonProperty("Education_SubInstitutionState1")]
        public string EducationSubInstitutionState1 { get; set; }

        [JsonProperty("Education_InstitutionType1")]
        public string EducationInstitutionType1 { get; set; }

        [JsonProperty("Contact_FirstName")]
        public string ContactFirstName { get; set; }

        [JsonProperty("Education_Degree2")]
        public string EducationDegree2 { get; set; }

        [JsonProperty("Education_EndDate2")]
        public string EducationEndDate2 { get; set; }

        [JsonProperty("Education_StartDate2")]
        public string EducationStartDate2 { get; set; }

        [JsonProperty("Experience_JobDescription1")]
        public string ExperienceJobDescription1 { get; set; }

        [JsonProperty("Education_InstitutionState2")]
        public string EducationInstitutionState2 { get; set; }

        [JsonProperty("Experience_JobLocationCity2")]
        public string ExperienceJobLocationCity2 { get; set; }

        [JsonProperty("Contact_Phone")]
        public string ContactPhone { get; set; }

        [JsonProperty("Experience_JobLocationCountryIsoCode2")]
        public string ExperienceJobLocationCountryIsoCode2 { get; set; }

        [JsonProperty("Education_InstitutionState1")]
        public string EducationInstitutionState1 { get; set; }

        [JsonProperty("Education_AggregateMeasureType2")]
        public string EducationAggregateMeasureType2 { get; set; }

        [JsonProperty("Experience_StartDate1")]
        public string ExperienceStartDate1 { get; set; }

        [JsonProperty("Education_InstitutionCountry1")]
        public string EducationInstitutionCountry1 { get; set; }

        [JsonProperty("Education_Degree1")]
        public string EducationDegree1 { get; set; }

        [JsonProperty("Experience_EndDate1")]
        public string ExperienceEndDate1 { get; set; }
    }

    public class ParseResumeDetailViaFileContentResponse
    {
        [JsonProperty("Education_InstitutionCity1")]
        public string EducationInstitutionCity1 { get; set; }

        [JsonProperty("Experience_CurrentJobProfile")]
        public string ExperienceCurrentJobProfile { get; set; }

        [JsonProperty("Skill_LastUsed7")]
        public string SkillLastUsed7 { get; set; }

        [JsonProperty("Skill_LastUsed16")]
        public string SkillLastUsed16 { get; set; }

        [JsonProperty("Skill_LastUsed13")]
        public string SkillLastUsed13 { get; set; }

        [JsonProperty("Experience_Employer7")]
        public string ExperienceEmployer7 { get; set; }

        [JsonProperty("Experience_Employer4")]
        public string ExperienceEmployer4 { get; set; }

        [JsonProperty("Education_StartDate4")]
        public string EducationStartDate4 { get; set; }

        [JsonProperty("Education_SubInstitutionType1")]
        public string EducationSubInstitutionType1 { get; set; }

        [JsonProperty("Education_Aggregate5")]
        public string EducationAggregate5 { get; set; }

        [JsonProperty("Contact_FormattedAddress")]
        public string ContactFormattedAddress { get; set; }

        [JsonProperty("Experience_JobProfile4")]
        public string ExperienceJobProfile4 { get; set; }

        [JsonProperty("Education_StartDate5")]
        public string EducationStartDate5 { get; set; }

        [JsonProperty("Experience_JobLocationState9")]
        public string ExperienceJobLocationState9 { get; set; }

        [JsonProperty("Experience_JobDescription5")]
        public string ExperienceJobDescription5 { get; set; }

        [JsonProperty("Skill_Name18")]
        public string SkillName18 { get; set; }

        [JsonProperty("Skill_ExperinceInMonth11")]
        public string SkillExperinceInMonth11 { get; set; }

        [JsonProperty("Skill_Name11")]
        public string SkillName11 { get; set; }

        [JsonProperty("Skill_Name13")]
        public string SkillName13 { get; set; }

        [JsonProperty("Experience_TotalExperienceInYear")]
        public string ExperienceTotalExperienceInYear { get; set; }

        [JsonProperty("Education_SubInstitutionCountry5")]
        public string EducationSubInstitutionCountry5 { get; set; }

        [JsonProperty("Skill_ExperinceInMonth13")]
        public string SkillExperinceInMonth13 { get; set; }

        [JsonProperty("Experience_EndDate7")]
        public string ExperienceEndDate7 { get; set; }

        [JsonProperty("Experience_JobLocationCity9")]
        public string ExperienceJobLocationCity9 { get; set; }

        [JsonProperty("Skill_LastUsed8")]
        public string SkillLastUsed8 { get; set; }

        [JsonProperty("Experience_JobDescription3")]
        public string ExperienceJobDescription3 { get; set; }

        [JsonProperty("Skill_LastUsed9")]
        public string SkillLastUsed9 { get; set; }

        [JsonProperty("Contact_State")]
        public string ContactState { get; set; }

        [JsonProperty("Social_FacebookProfile")]
        public string SocialFacebookProfile { get; set; }

        [JsonProperty("Education_SubInstitutionCountry4")]
        public string EducationSubInstitutionCountry4 { get; set; }

        [JsonProperty("Skill_ExperinceInMonth1")]
        public string SkillExperinceInMonth1 { get; set; }

        [JsonProperty("Experience_JobLocationCountry3")]
        public string ExperienceJobLocationCountry3 { get; set; }

        [JsonProperty("Experience_JobLocationCountry6")]
        public string ExperienceJobLocationCountry6 { get; set; }

        [JsonProperty("Education_EndDate1")]
        public string EducationEndDate1 { get; set; }

        [JsonProperty("Education_SubInstitutionCity4")]
        public string EducationSubInstitutionCity4 { get; set; }

        [JsonProperty("Experience_JobDescription8")]
        public string ExperienceJobDescription8 { get; set; }

        [JsonProperty("Experience_JobLocationCity6")]
        public string ExperienceJobLocationCity6 { get; set; }

        [JsonProperty("Skill_Name8")]
        public string SkillName8 { get; set; }

        [JsonProperty("Education_InstitutionType4")]
        public string EducationInstitutionType4 { get; set; }

        [JsonProperty("Education_Aggregate2")]
        public string EducationAggregate2 { get; set; }

        [JsonProperty("Education_AggregateMeasureType3")]
        public string EducationAggregateMeasureType3 { get; set; }

        [JsonProperty("Other_LicenseNo")]
        public string OtherLicenseNo { get; set; }

        [JsonProperty("Education_SubInstitutionType5")]
        public string EducationSubInstitutionType5 { get; set; }

        [JsonProperty("Social_LinkedinUrl")]
        public string SocialLinkedinUrl { get; set; }

        [JsonProperty("Contact_Country")]
        public string ContactCountry { get; set; }

        [JsonProperty("Experience_JobDescription6")]
        public string ExperienceJobDescription6 { get; set; }

        [JsonProperty("Social_LinkedinProfile")]
        public string SocialLinkedinProfile { get; set; }

        [JsonProperty("Experience_JobLocationCountryIsoCode1")]
        public string ExperienceJobLocationCountryIsoCode1 { get; set; }

        [JsonProperty("Experience_JobLocationCity3")]
        public string ExperienceJobLocationCity3 { get; set; }

        [JsonProperty("Experience_TotalExperienceInMonths")]
        public string ExperienceTotalExperienceInMonths { get; set; }

        [JsonProperty("Experience_JobLocationState8")]
        public string ExperienceJobLocationState8 { get; set; }

        [JsonProperty("Experience_StartDate3")]
        public string ExperienceStartDate3 { get; set; }

        [JsonProperty("Contact_ZipCode")]
        public string ContactZipCode { get; set; }

        [JsonProperty("Education_Aggregate1")]
        public string EducationAggregate1 { get; set; }

        [JsonProperty("Skill_Name14")]
        public string SkillName14 { get; set; }

        [JsonProperty("Other_ManagementSummary")]
        public string OtherManagementSummary { get; set; }

        [JsonProperty("Experience_StartDate9")]
        public string ExperienceStartDate9 { get; set; }

        [JsonProperty("Contact_LastName")]
        public string ContactLastName { get; set; }

        [JsonProperty("Other_CandidateImageData")]
        public string OtherCandidateImageData { get; set; }

        [JsonProperty("Personal_MaritalStatus")]
        public string PersonalMaritalStatus { get; set; }

        [JsonProperty("Experience_JobLocationCountry7")]
        public string ExperienceJobLocationCountry7 { get; set; }

        [JsonProperty("Education_Degree4")]
        public string EducationDegree4 { get; set; }

        [JsonProperty("Skill_ExperinceInMonth16")]
        public string SkillExperinceInMonth16 { get; set; }

        [JsonProperty("Contact_FormattedMobile")]
        public string ContactFormattedMobile { get; set; }

        [JsonProperty("Education_SubInstitutionCity5")]
        public string EducationSubInstitutionCity5 { get; set; }

        [JsonProperty("Education_EndDate5")]
        public string EducationEndDate5 { get; set; }

        [JsonProperty("Education_InstitutionCity5")]
        public string EducationInstitutionCity5 { get; set; }

        [JsonProperty("Experience_JobLocationCountry10")]
        public string ExperienceJobLocationCountry10 { get; set; }

        [JsonProperty("Personal_PassportNo")]
        public string PersonalPassportNo { get; set; }

        [JsonProperty("Skill_LastUsed3")]
        public string SkillLastUsed3 { get; set; }

        [JsonProperty("Experience_EndDate10")]
        public string ExperienceEndDate10 { get; set; }

        [JsonProperty("Skill_LastUsed4")]
        public string SkillLastUsed4 { get; set; }

        [JsonProperty("Education_SubInstitutionState3")]
        public string EducationSubInstitutionState3 { get; set; }

        [JsonProperty("Skill_LastUsed6")]
        public string SkillLastUsed6 { get; set; }

        [JsonProperty("Education_Degree3")]
        public string EducationDegree3 { get; set; }

        [JsonProperty("Education_Degree2")]
        public string EducationDegree2 { get; set; }

        [JsonProperty("Education_AggregateMeasureType2")]
        public string EducationAggregateMeasureType2 { get; set; }

        [JsonProperty("Experience_StartDate1")]
        public string ExperienceStartDate1 { get; set; }

        [JsonProperty("Personal_MotherName")]
        public string PersonalMotherName { get; set; }

        [JsonProperty("Personal_FatherName")]
        public string PersonalFatherName { get; set; }

        [JsonProperty("Education_Degree1")]
        public string EducationDegree1 { get; set; }

        [JsonProperty("Experience_EndDate5")]
        public string ExperienceEndDate5 { get; set; }

        [JsonProperty("Education_StartDate2")]
        public string EducationStartDate2 { get; set; }

        [JsonProperty("Other_CandidateImageFormat")]
        public string OtherCandidateImageFormat { get; set; }

        [JsonProperty("Experience_JobProfile9")]
        public string ExperienceJobProfile9 { get; set; }

        [JsonProperty("Other_ExecutiveSummary")]
        public string OtherExecutiveSummary { get; set; }

        [JsonProperty("Education_AggregateMeasureType5")]
        public string EducationAggregateMeasureType5 { get; set; }

        [JsonProperty("Education_InstitutionType5")]
        public string EducationInstitutionType5 { get; set; }

        [JsonProperty("Education_InstitutionType3")]
        public string EducationInstitutionType3 { get; set; }

        [JsonProperty("Skill_SkillsText")]
        public string SkillSkillsText { get; set; }

        [JsonProperty("Education_SubInstitutionState5")]
        public string EducationSubInstitutionState5 { get; set; }

        [JsonProperty("Experience_JobLocationCity1")]
        public string ExperienceJobLocationCity1 { get; set; }

        [JsonProperty("Experience_JobLocationCountryIsoCode10")]
        public string ExperienceJobLocationCountryIsoCode10 { get; set; }

        [JsonProperty("Social_GooglekUrl")]
        public string SocialGooglekUrl { get; set; }

        [JsonProperty("Skill_ExperinceInMonth20")]
        public string SkillExperinceInMonth20 { get; set; }

        [JsonProperty("Experience_EndDate1")]
        public string ExperienceEndDate1 { get; set; }

        [JsonProperty("Contact_PermanentState")]
        public string ContactPermanentState { get; set; }

        [JsonProperty("Education_InstitutionCity3")]
        public string EducationInstitutionCity3 { get; set; }

        [JsonProperty("Education_InstitutionCountry2")]
        public string EducationInstitutionCountry2 { get; set; }

        [JsonProperty("Education_InstitutionName4")]
        public string EducationInstitutionName4 { get; set; }

        [JsonProperty("Education_SubInstitutionState2")]
        public string EducationSubInstitutionState2 { get; set; }

        [JsonProperty("Experience_JobProfile7")]
        public string ExperienceJobProfile7 { get; set; }

        [JsonProperty("Skill_ExperinceInMonth2")]
        public string SkillExperinceInMonth2 { get; set; }

        [JsonProperty("Experience_EndDate2")]
        public string ExperienceEndDate2 { get; set; }

        [JsonProperty("Experience_JobLocationCity4")]
        public string ExperienceJobLocationCity4 { get; set; }

        [JsonProperty("Other_SubCategory")]
        public string OtherSubCategory { get; set; }

        [JsonProperty("Other_AverageStay")]
        public string OtherAverageStay { get; set; }

        [JsonProperty("Education_InstitutionCountry3")]
        public string EducationInstitutionCountry3 { get; set; }

        [JsonProperty("Contact_Mobile")]
        public string ContactMobile { get; set; }

        [JsonProperty("Education_EndDate3")]
        public string EducationEndDate3 { get; set; }

        [JsonProperty("Contact_WebsiteUrl3")]
        public string ContactWebsiteUrl3 { get; set; }

        [JsonProperty("Experience_JobLocationCity10")]
        public string ExperienceJobLocationCity10 { get; set; }

        [JsonProperty("Skill_LastUsed11")]
        public string SkillLastUsed11 { get; set; }

        [JsonProperty("Other_Hobbies")]
        public string OtherHobbies { get; set; }

        [JsonProperty("Personal_DateOfBirth")]
        public string PersonalDateOfBirth { get; set; }

        [JsonProperty("Social_TwitterUrl")]
        public string SocialTwitterUrl { get; set; }

        [JsonProperty("Experience_JobLocationCountry1")]
        public string ExperienceJobLocationCountry1 { get; set; }

        [JsonProperty("Skill_LastUsed18")]
        public string SkillLastUsed18 { get; set; }

        [JsonProperty("Skill_LastUsed14")]
        public string SkillLastUsed14 { get; set; }

        [JsonProperty("Other_PreferredLocation")]
        public string OtherPreferredLocation { get; set; }

        [JsonProperty("Social_TwitterImageUrl")]
        public string SocialTwitterImageUrl { get; set; }

        [JsonProperty("Other_CurrentSalary")]
        public string OtherCurrentSalary { get; set; }

        [JsonProperty("Experience_Employer6")]
        public string ExperienceEmployer6 { get; set; }

        [JsonProperty("Experience_JobLocationCountryIsoCode8")]
        public string ExperienceJobLocationCountryIsoCode8 { get; set; }

        [JsonProperty("Other_Summary")]
        public string OtherSummary { get; set; }

        [JsonProperty("Contact_PermanentCity")]
        public string ContactPermanentCity { get; set; }

        [JsonProperty("Skill_ExperinceInMonth5")]
        public string SkillExperinceInMonth5 { get; set; }

        [JsonProperty("Experience_JobProfile5")]
        public string ExperienceJobProfile5 { get; set; }

        [JsonProperty("Experience_JobLocationCountryIsoCode5")]
        public string ExperienceJobLocationCountryIsoCode5 { get; set; }

        [JsonProperty("Experience_StartDate5")]
        public string ExperienceStartDate5 { get; set; }

        [JsonProperty("Experience_JobProfile6")]
        public string ExperienceJobProfile6 { get; set; }

        [JsonProperty("Other_HtmlResume")]
        public string OtherHtmlResume { get; set; }

        [JsonProperty("Education_StartDate1")]
        public string EducationStartDate1 { get; set; }

        [JsonProperty("Other_Availability")]
        public string OtherAvailability { get; set; }

        [JsonProperty("Experience_JobProfile1")]
        public string ExperienceJobProfile1 { get; set; }

        [JsonProperty("Contact_WebsiteUrl2")]
        public string ContactWebsiteUrl2 { get; set; }

        [JsonProperty("Education_Degree5")]
        public string EducationDegree5 { get; set; }

        [JsonProperty("Skill_Name10")]
        public string SkillName10 { get; set; }

        [JsonProperty("Other_ExpectedSalary")]
        public string OtherExpectedSalary { get; set; }

        [JsonProperty("Education_SubInstitutionType3")]
        public string EducationSubInstitutionType3 { get; set; }

        [JsonProperty("Skill_LastUsed20")]
        public string SkillLastUsed20 { get; set; }

        [JsonProperty("Skill_ExperinceInMonth3")]
        public string SkillExperinceInMonth3 { get; set; }

        [JsonProperty("Skill_Name17")]
        public string SkillName17 { get; set; }

        [JsonProperty("Skill_LastUsed1")]
        public string SkillLastUsed1 { get; set; }

        [JsonProperty("Education_InstitutionState3")]
        public string EducationInstitutionState3 { get; set; }

        [JsonProperty("Experience_JobProfile8")]
        public string ExperienceJobProfile8 { get; set; }

        [JsonProperty("Experience_JobDescription1")]
        public string ExperienceJobDescription1 { get; set; }

        [JsonProperty("Experience_JobLocationState7")]
        public string ExperienceJobLocationState7 { get; set; }

        [JsonProperty("Experience_StartDate10")]
        public string ExperienceStartDate10 { get; set; }

        [JsonProperty("Skill_ExperinceInMonth8")]
        public string SkillExperinceInMonth8 { get; set; }

        [JsonProperty("Experience_Employer10")]
        public string ExperienceEmployer10 { get; set; }

        [JsonProperty("Education_HighestDegree")]
        public string EducationHighestDegree { get; set; }

        [JsonProperty("Experience_JobLocationState4")]
        public string ExperienceJobLocationState4 { get; set; }

        [JsonProperty("Education_InstitutionName1")]
        public string EducationInstitutionName1 { get; set; }

        [JsonProperty("Other_LongestStay")]
        public string OtherLongestStay { get; set; }

        [JsonProperty("Skill_ExperinceInMonth9")]
        public string SkillExperinceInMonth9 { get; set; }

        [JsonProperty("Other_Publication")]
        public string OtherPublication { get; set; }

        [JsonProperty("Experience_JobProfile2")]
        public string ExperienceJobProfile2 { get; set; }

        [JsonProperty("Other_DetailResume")]
        public string OtherDetailResume { get; set; }

        [JsonProperty("Other_Certification")]
        public string OtherCertification { get; set; }

        [JsonProperty("Experience_JobLocationState5")]
        public string ExperienceJobLocationState5 { get; set; }

        [JsonProperty("Experience_JobLocationCountry2")]
        public string ExperienceJobLocationCountry2 { get; set; }

        [JsonProperty("Education_InstitutionCity2")]
        public string EducationInstitutionCity2 { get; set; }

        [JsonProperty("Social_GoogleProfile")]
        public string SocialGoogleProfile { get; set; }

        [JsonProperty("Experience_JobLocationState3")]
        public string ExperienceJobLocationState3 { get; set; }

        [JsonProperty("Other_CurrentLocation")]
        public string OtherCurrentLocation { get; set; }

        [JsonProperty("Experience_EndDate8")]
        public string ExperienceEndDate8 { get; set; }

        [JsonProperty("Personal_Gender")]
        public string PersonalGender { get; set; }

        [JsonProperty("Experience_StartDate6")]
        public string ExperienceStartDate6 { get; set; }

        [JsonProperty("Skill_LastUsed2")]
        public string SkillLastUsed2 { get; set; }

        [JsonProperty("Experience_StartDate8")]
        public string ExperienceStartDate8 { get; set; }

        [JsonProperty("Skill_LastUsed19")]
        public string SkillLastUsed19 { get; set; }

        [JsonProperty("Experience_JobLocationCountry4")]
        public string ExperienceJobLocationCountry4 { get; set; }

        [JsonProperty("Skill_Name15")]
        public string SkillName15 { get; set; }

        [JsonProperty("Other_Category")]
        public string OtherCategory { get; set; }

        [JsonProperty("Education_InstitutionState5")]
        public string EducationInstitutionState5 { get; set; }

        [JsonProperty("Experience_EndDate4")]
        public string ExperienceEndDate4 { get; set; }

        [JsonProperty("Social_GoogleImageUrl")]
        public string SocialGoogleImageUrl { get; set; }

        [JsonProperty("Other_Achievements")]
        public string OtherAchievements { get; set; }

        [JsonProperty("Experience_StartDate2")]
        public string ExperienceStartDate2 { get; set; }

        [JsonProperty("Skill_Name1")]
        public string SkillName1 { get; set; }

        [JsonProperty("Other_ResumeFileData")]
        public string OtherResumeFileData { get; set; }

        [JsonProperty("Experience_JobLocationCountry8")]
        public string ExperienceJobLocationCountry8 { get; set; }

        [JsonProperty("Education_SubInstitutionName2")]
        public string EducationSubInstitutionName2 { get; set; }

        [JsonProperty("Education_InstitutionCountry4")]
        public string EducationInstitutionCountry4 { get; set; }

        [JsonProperty("Experience_JobDescription9")]
        public string ExperienceJobDescription9 { get; set; }

        [JsonProperty("Other_ResumeFileName")]
        public string OtherResumeFileName { get; set; }

        [JsonProperty("Experience_Employer8")]
        public string ExperienceEmployer8 { get; set; }

        [JsonProperty("Experience_Employer5")]
        public string ExperienceEmployer5 { get; set; }

        [JsonProperty("Other_CustomFields")]
        public string OtherCustomFields { get; set; }

        [JsonProperty("Education_Aggregate4")]
        public string EducationAggregate4 { get; set; }

        [JsonProperty("Experience_Employer3")]
        public string ExperienceEmployer3 { get; set; }

        [JsonProperty("Skill_ExperinceInMonth7")]
        public string SkillExperinceInMonth7 { get; set; }

        [JsonProperty("Contact_FormattedPhone")]
        public string ContactFormattedPhone { get; set; }

        [JsonProperty("Experience_JobLocationCountry5")]
        public string ExperienceJobLocationCountry5 { get; set; }

        [JsonProperty("Skill_ExperinceInMonth14")]
        public string SkillExperinceInMonth14 { get; set; }

        [JsonProperty("Education_AggregateMeasureType4")]
        public string EducationAggregateMeasureType4 { get; set; }

        [JsonProperty("Education_Aggregate3")]
        public string EducationAggregate3 { get; set; }

        [JsonProperty("Education_SubInstitutionName4")]
        public string EducationSubInstitutionName4 { get; set; }

        [JsonProperty("Social_FacebookImageUrl")]
        public string SocialFacebookImageUrl { get; set; }

        [JsonProperty("Experience_ExperienceText")]
        public string ExperienceExperienceText { get; set; }

        [JsonProperty("Experience_StartDate4")]
        public string ExperienceStartDate4 { get; set; }

        [JsonProperty("Other_LanguageKnown")]
        public string OtherLanguageKnown { get; set; }

        [JsonProperty("Education_EndDate4")]
        public string EducationEndDate4 { get; set; }

        [JsonProperty("Contact_FirstName")]
        public string ContactFirstName { get; set; }

        [JsonProperty("Personal_UniqueID")]
        public string PersonalUniqueID { get; set; }

        [JsonProperty("Contact_MiddleName")]
        public string ContactMiddleName { get; set; }

        [JsonProperty("Contact_FormattedPermanentAddress")]
        public string ContactFormattedPermanentAddress { get; set; }

        [JsonProperty("Skill_Name4")]
        public string SkillName4 { get; set; }

        [JsonProperty("Education_InstitutionName3")]
        public string EducationInstitutionName3 { get; set; }

        [JsonProperty("Education_SubInstitutionType2")]
        public string EducationSubInstitutionType2 { get; set; }

        [JsonProperty("Skill_ExperinceInMonth18")]
        public string SkillExperinceInMonth18 { get; set; }

        [JsonProperty("Experience_Employer2")]
        public string ExperienceEmployer2 { get; set; }

        [JsonProperty("Skill_Name5")]
        public string SkillName5 { get; set; }

        [JsonProperty("Skill_Name20")]
        public string SkillName20 { get; set; }

        [JsonProperty("Other_References")]
        public string OtherReferences { get; set; }

        [JsonProperty("Skill_SkillsKeywords")]
        public string SkillSkillsKeywords { get; set; }

        [JsonProperty("Experience_JobDescription4")]
        public string ExperienceJobDescription4 { get; set; }

        [JsonProperty("Personal_Nationality")]
        public string PersonalNationality { get; set; }

        [JsonProperty("Experience_JobLocationCountryIsoCode2")]
        public string ExperienceJobLocationCountryIsoCode2 { get; set; }

        [JsonProperty("Experience_StartDate7")]
        public string ExperienceStartDate7 { get; set; }

        [JsonProperty("Experience_JobLocationCountry9")]
        public string ExperienceJobLocationCountry9 { get; set; }

        [JsonProperty("Experience_JobDescription10")]
        public string ExperienceJobDescription10 { get; set; }

        [JsonProperty("Education_InstitutionState2")]
        public string EducationInstitutionState2 { get; set; }

        [JsonProperty("Experience_JobLocationCity5")]
        public string ExperienceJobLocationCity5 { get; set; }

        [JsonProperty("Education_InstitutionCountry5")]
        public string EducationInstitutionCountry5 { get; set; }

        [JsonProperty("Experience_JobProfile3")]
        public string ExperienceJobProfile3 { get; set; }

        [JsonProperty("Other_ParsingDate")]
        public string OtherParsingDate { get; set; }

        [JsonProperty("Experience_JobDescription2")]
        public string ExperienceJobDescription2 { get; set; }

        [JsonProperty("Education_SubInstitutionCountry3")]
        public string EducationSubInstitutionCountry3 { get; set; }

        [JsonProperty("Skill_Name19")]
        public string SkillName19 { get; set; }

        [JsonProperty("Education_AggregateMeasureType1")]
        public string EducationAggregateMeasureType1 { get; set; }

        [JsonProperty("Education_SubInstitutionName5")]
        public string EducationSubInstitutionName5 { get; set; }

        [JsonProperty("Experience_CurrentEmployer")]
        public string ExperienceCurrentEmployer { get; set; }

        [JsonProperty("Skill_Name12")]
        public string SkillName12 { get; set; }

        [JsonProperty("Skill_Name9")]
        public string SkillName9 { get; set; }

        [JsonProperty("Education_SubInstitutionCountry1")]
        public string EducationSubInstitutionCountry1 { get; set; }

        [JsonProperty("Education_SubInstitutionCity1")]
        public string EducationSubInstitutionCity1 { get; set; }

        [JsonProperty("Skill_ExperinceInMonth4")]
        public string SkillExperinceInMonth4 { get; set; }

        [JsonProperty("Skill_ExperinceInMonth6")]
        public string SkillExperinceInMonth6 { get; set; }

        [JsonProperty("Education_SubInstitutionName1")]
        public string EducationSubInstitutionName1 { get; set; }

        [JsonProperty("Education_InstitutionCity4")]
        public string EducationInstitutionCity4 { get; set; }

        [JsonProperty("Contact_City")]
        public string ContactCity { get; set; }

        [JsonProperty("Contact_WebsiteUrl1")]
        public string ContactWebsiteUrl1 { get; set; }

        [JsonProperty("Skill_ExperinceInMonth17")]
        public string SkillExperinceInMonth17 { get; set; }

        [JsonProperty("Education_SubInstitutionName3")]
        public string EducationSubInstitutionName3 { get; set; }

        [JsonProperty("Experience_EndDate3")]
        public string ExperienceEndDate3 { get; set; }

        [JsonProperty("Contact_PermanentAddress")]
        public string ContactPermanentAddress { get; set; }

        [JsonProperty("Education_SubInstitutionCity3")]
        public string EducationSubInstitutionCity3 { get; set; }

        [JsonProperty("Skill_LastUsed17")]
        public string SkillLastUsed17 { get; set; }

        [JsonProperty("Experience_JobLocationCountryIsoCode4")]
        public string ExperienceJobLocationCountryIsoCode4 { get; set; }

        [JsonProperty("Experience_JobLocationState2")]
        public string ExperienceJobLocationState2 { get; set; }

        [JsonProperty("Contact_Phone")]
        public string ContactPhone { get; set; }

        [JsonProperty("Education_SubInstitutionState4")]
        public string EducationSubInstitutionState4 { get; set; }

        [JsonProperty("Experience_EndDate9")]
        public string ExperienceEndDate9 { get; set; }

        [JsonProperty("Experience_EndDate6")]
        public string ExperienceEndDate6 { get; set; }

        [JsonProperty("Experience_JobDescription7")]
        public string ExperienceJobDescription7 { get; set; }

        [JsonProperty("Experience_JobLocationCountryIsoCode3")]
        public string ExperienceJobLocationCountryIsoCode3 { get; set; }

        [JsonProperty("Education_QualificationText")]
        public string EducationQualificationText { get; set; }

        [JsonProperty("Contact_PermanentCountry")]
        public string ContactPermanentCountry { get; set; }

        [JsonProperty("Contact_TitleName")]
        public string ContactTitleName { get; set; }

        [JsonProperty("Skill_LastUsed10")]
        public string SkillLastUsed10 { get; set; }

        [JsonProperty("Skill_ExperinceInMonth12")]
        public string SkillExperinceInMonth12 { get; set; }

        [JsonProperty("Education_SubInstitutionCity2")]
        public string EducationSubInstitutionCity2 { get; set; }

        [JsonProperty("Education_StartDate3")]
        public string EducationStartDate3 { get; set; }

        [JsonProperty("Experience_JobLocationState1")]
        public string ExperienceJobLocationState1 { get; set; }

        [JsonProperty("Education_InstitutionState4")]
        public string EducationInstitutionState4 { get; set; }

        [JsonProperty("Experience_JobProfile10")]
        public string ExperienceJobProfile10 { get; set; }

        [JsonProperty("Experience_Employer1")]
        public string ExperienceEmployer1 { get; set; }

        [JsonProperty("Contact_AlternateEmail")]
        public string ContactAlternateEmail { get; set; }

        [JsonProperty("Education_EndDate2")]
        public string EducationEndDate2 { get; set; }

        [JsonProperty("Skill_Name7")]
        public string SkillName7 { get; set; }

        [JsonProperty("Education_InstitutionState1")]
        public string EducationInstitutionState1 { get; set; }

        [JsonProperty("Experience_JobLocationCity7")]
        public string ExperienceJobLocationCity7 { get; set; }

        [JsonProperty("Skill_Name2")]
        public string SkillName2 { get; set; }

        [JsonProperty("Education_SubInstitutionCountry2")]
        public string EducationSubInstitutionCountry2 { get; set; }

        [JsonProperty("Experience_JobLocationState6")]
        public string ExperienceJobLocationState6 { get; set; }

        [JsonProperty("Contact_Email")]
        public string ContactEmail { get; set; }

        [JsonProperty("Skill_Name6")]
        public string SkillName6 { get; set; }

        [JsonProperty("Skill_ExperinceInMonth10")]
        public string SkillExperinceInMonth10 { get; set; }

        [JsonProperty("Experience_JobLocationCity8")]
        public string ExperienceJobLocationCity8 { get; set; }

        [JsonProperty("Experience_Employer9")]
        public string ExperienceEmployer9 { get; set; }

        [JsonProperty("Other_Coverletter")]
        public string OtherCoverletter { get; set; }

        [JsonProperty("Education_InstitutionName2")]
        public string EducationInstitutionName2 { get; set; }

        [JsonProperty("Skill_ExperinceInMonth15")]
        public string SkillExperinceInMonth15 { get; set; }

        [JsonProperty("Social_TwitterProfile")]
        public string SocialTwitterProfile { get; set; }

        [JsonProperty("Experience_JobLocationCountryIsoCode9")]
        public string ExperienceJobLocationCountryIsoCode9 { get; set; }

        [JsonProperty("Skill_Name16")]
        public string SkillName16 { get; set; }

        [JsonProperty("Social_LinkedinImageUrl")]
        public string SocialLinkedinImageUrl { get; set; }

        [JsonProperty("Skill_LastUsed5")]
        public string SkillLastUsed5 { get; set; }

        [JsonProperty("Skill_LastUsed15")]
        public string SkillLastUsed15 { get; set; }

        [JsonProperty("Contact_Address")]
        public string ContactAddress { get; set; }

        [JsonProperty("Experience_GapPeriod")]
        public string ExperienceGapPeriod { get; set; }

        [JsonProperty("Education_SubInstitutionState1")]
        public string EducationSubInstitutionState1 { get; set; }

        [JsonProperty("Education_InstitutionType1")]
        public string EducationInstitutionType1 { get; set; }

        [JsonProperty("Experience_JobLocationCountryIsoCode6")]
        public string ExperienceJobLocationCountryIsoCode6 { get; set; }

        [JsonProperty("Skill_Name3")]
        public string SkillName3 { get; set; }

        [JsonProperty("Contact_PermanentZipCode")]
        public string ContactPermanentZipCode { get; set; }

        [JsonProperty("Experience_JobLocationCity2")]
        public string ExperienceJobLocationCity2 { get; set; }

        [JsonProperty("Education_InstitutionType2")]
        public string EducationInstitutionType2 { get; set; }

        [JsonProperty("Experience_JobLocationState10")]
        public string ExperienceJobLocationState10 { get; set; }

        [JsonProperty("Skill_ExperinceInMonth19")]
        public string SkillExperinceInMonth19 { get; set; }

        [JsonProperty("Education_SubInstitutionType4")]
        public string EducationSubInstitutionType4 { get; set; }

        [JsonProperty("Social_FacebookUrl")]
        public string SocialFacebookUrl { get; set; }

        [JsonProperty("Skill_LastUsed12")]
        public string SkillLastUsed12 { get; set; }

        [JsonProperty("Education_InstitutionName5")]
        public string EducationInstitutionName5 { get; set; }

        [JsonProperty("Education_InstitutionCountry1")]
        public string EducationInstitutionCountry1 { get; set; }

        [JsonProperty("Experience_JobLocationCountryIsoCode7")]
        public string ExperienceJobLocationCountryIsoCode7 { get; set; }

        [JsonProperty("Other_Objectives")]
        public string OtherObjectives { get; set; }
    }

    public class ParseResumeDetailViaUrlResponse
    {
        [JsonProperty("Education_InstitutionCity1")]
        public string EducationInstitutionCity1 { get; set; }

        [JsonProperty("Experience_CurrentJobProfile")]
        public string ExperienceCurrentJobProfile { get; set; }

        [JsonProperty("Skill_LastUsed7")]
        public string SkillLastUsed7 { get; set; }

        [JsonProperty("Skill_LastUsed16")]
        public string SkillLastUsed16 { get; set; }

        [JsonProperty("Skill_LastUsed13")]
        public string SkillLastUsed13 { get; set; }

        [JsonProperty("Experience_Employer7")]
        public string ExperienceEmployer7 { get; set; }

        [JsonProperty("Other_ErrorCode")]
        public string OtherErrorCode { get; set; }

        [JsonProperty("Education_StartDate4")]
        public string EducationStartDate4 { get; set; }

        [JsonProperty("Education_SubInstitutionType1")]
        public string EducationSubInstitutionType1 { get; set; }

        [JsonProperty("Education_Aggregate5")]
        public string EducationAggregate5 { get; set; }

        [JsonProperty("Contact_FormattedAddress")]
        public string ContactFormattedAddress { get; set; }

        [JsonProperty("Experience_JobProfile4")]
        public string ExperienceJobProfile4 { get; set; }

        [JsonProperty("Education_StartDate5")]
        public string EducationStartDate5 { get; set; }

        [JsonProperty("Experience_JobLocationState9")]
        public string ExperienceJobLocationState9 { get; set; }

        [JsonProperty("Experience_JobDescription5")]
        public string ExperienceJobDescription5 { get; set; }

        [JsonProperty("Skill_Name18")]
        public string SkillName18 { get; set; }

        [JsonProperty("Skill_ExperinceInMonth11")]
        public string SkillExperinceInMonth11 { get; set; }

        [JsonProperty("Skill_Name11")]
        public string SkillName11 { get; set; }

        [JsonProperty("Skill_Name13")]
        public string SkillName13 { get; set; }

        [JsonProperty("Experience_TotalExperienceInYear")]
        public string ExperienceTotalExperienceInYear { get; set; }

        [JsonProperty("Education_SubInstitutionCountry5")]
        public string EducationSubInstitutionCountry5 { get; set; }

        [JsonProperty("Skill_ExperinceInMonth13")]
        public string SkillExperinceInMonth13 { get; set; }

        [JsonProperty("Experience_EndDate7")]
        public string ExperienceEndDate7 { get; set; }

        [JsonProperty("Experience_JobLocationCity9")]
        public string ExperienceJobLocationCity9 { get; set; }

        [JsonProperty("Skill_LastUsed8")]
        public string SkillLastUsed8 { get; set; }

        [JsonProperty("Experience_JobDescription3")]
        public string ExperienceJobDescription3 { get; set; }

        [JsonProperty("Skill_LastUsed9")]
        public string SkillLastUsed9 { get; set; }

        [JsonProperty("Contact_State")]
        public string ContactState { get; set; }

        [JsonProperty("Social_FacebookProfile")]
        public string SocialFacebookProfile { get; set; }

        [JsonProperty("Education_SubInstitutionCountry4")]
        public string EducationSubInstitutionCountry4 { get; set; }

        [JsonProperty("Skill_ExperinceInMonth1")]
        public string SkillExperinceInMonth1 { get; set; }

        [JsonProperty("Experience_JobLocationCountry3")]
        public string ExperienceJobLocationCountry3 { get; set; }

        [JsonProperty("Experience_JobLocationCountry6")]
        public string ExperienceJobLocationCountry6 { get; set; }

        [JsonProperty("Education_EndDate1")]
        public string EducationEndDate1 { get; set; }

        [JsonProperty("Education_SubInstitutionCity4")]
        public string EducationSubInstitutionCity4 { get; set; }

        [JsonProperty("Experience_JobDescription8")]
        public string ExperienceJobDescription8 { get; set; }

        [JsonProperty("Experience_JobLocationCity6")]
        public string ExperienceJobLocationCity6 { get; set; }

        [JsonProperty("Skill_Name8")]
        public string SkillName8 { get; set; }

        [JsonProperty("Education_InstitutionType4")]
        public string EducationInstitutionType4 { get; set; }

        [JsonProperty("Education_Aggregate2")]
        public string EducationAggregate2 { get; set; }

        [JsonProperty("Education_AggregateMeasureType3")]
        public string EducationAggregateMeasureType3 { get; set; }

        [JsonProperty("Other_LicenseNo")]
        public string OtherLicenseNo { get; set; }

        [JsonProperty("Education_SubInstitutionType5")]
        public string EducationSubInstitutionType5 { get; set; }

        [JsonProperty("Social_LinkedinUrl")]
        public string SocialLinkedinUrl { get; set; }

        [JsonProperty("Contact_Country")]
        public string ContactCountry { get; set; }

        [JsonProperty("Experience_JobDescription6")]
        public string ExperienceJobDescription6 { get; set; }

        [JsonProperty("Social_LinkedinProfile")]
        public string SocialLinkedinProfile { get; set; }

        [JsonProperty("Experience_JobLocationCountryIsoCode1")]
        public string ExperienceJobLocationCountryIsoCode1 { get; set; }

        [JsonProperty("Experience_JobLocationCity3")]
        public string ExperienceJobLocationCity3 { get; set; }

        [JsonProperty("Experience_TotalExperienceInMonths")]
        public string ExperienceTotalExperienceInMonths { get; set; }

        [JsonProperty("Experience_JobLocationState8")]
        public string ExperienceJobLocationState8 { get; set; }

        [JsonProperty("Other_Objectives")]
        public string OtherObjectives { get; set; }

        [JsonProperty("Contact_ZipCode")]
        public string ContactZipCode { get; set; }

        [JsonProperty("Education_Aggregate1")]
        public string EducationAggregate1 { get; set; }

        [JsonProperty("Other_ManagementSummary")]
        public string OtherManagementSummary { get; set; }

        [JsonProperty("Experience_StartDate9")]
        public string ExperienceStartDate9 { get; set; }

        [JsonProperty("Contact_LastName")]
        public string ContactLastName { get; set; }

        [JsonProperty("Other_CandidateImageData")]
        public string OtherCandidateImageData { get; set; }

        [JsonProperty("Personal_MaritalStatus")]
        public string PersonalMaritalStatus { get; set; }

        [JsonProperty("Experience_JobLocationCountry7")]
        public string ExperienceJobLocationCountry7 { get; set; }

        [JsonProperty("Education_Degree4")]
        public string EducationDegree4 { get; set; }

        [JsonProperty("Skill_ExperinceInMonth16")]
        public string SkillExperinceInMonth16 { get; set; }

        [JsonProperty("Contact_FormattedMobile")]
        public string ContactFormattedMobile { get; set; }

        [JsonProperty("Education_SubInstitutionCity5")]
        public string EducationSubInstitutionCity5 { get; set; }

        [JsonProperty("Education_EndDate5")]
        public string EducationEndDate5 { get; set; }

        [JsonProperty("Education_InstitutionCity5")]
        public string EducationInstitutionCity5 { get; set; }

        [JsonProperty("Education_StartDate2")]
        public string EducationStartDate2 { get; set; }

        [JsonProperty("Personal_PassportNo")]
        public string PersonalPassportNo { get; set; }

        [JsonProperty("Skill_LastUsed3")]
        public string SkillLastUsed3 { get; set; }

        [JsonProperty("Experience_EndDate10")]
        public string ExperienceEndDate10 { get; set; }

        [JsonProperty("Skill_LastUsed4")]
        public string SkillLastUsed4 { get; set; }

        [JsonProperty("Education_SubInstitutionState3")]
        public string EducationSubInstitutionState3 { get; set; }

        [JsonProperty("Skill_LastUsed6")]
        public string SkillLastUsed6 { get; set; }

        [JsonProperty("Education_Degree3")]
        public string EducationDegree3 { get; set; }

        [JsonProperty("Education_Degree2")]
        public string EducationDegree2 { get; set; }

        [JsonProperty("Education_AggregateMeasureType2")]
        public string EducationAggregateMeasureType2 { get; set; }

        [JsonProperty("Experience_StartDate1")]
        public string ExperienceStartDate1 { get; set; }

        [JsonProperty("Personal_MotherName")]
        public string PersonalMotherName { get; set; }

        [JsonProperty("Personal_FatherName")]
        public string PersonalFatherName { get; set; }

        [JsonProperty("Education_Degree1")]
        public string EducationDegree1 { get; set; }

        [JsonProperty("Experience_EndDate5")]
        public string ExperienceEndDate5 { get; set; }

        [JsonProperty("Experience_JobLocationCountry10")]
        public string ExperienceJobLocationCountry10 { get; set; }

        [JsonProperty("Other_CandidateImageFormat")]
        public string OtherCandidateImageFormat { get; set; }

        [JsonProperty("Experience_JobProfile9")]
        public string ExperienceJobProfile9 { get; set; }

        [JsonProperty("Other_ExecutiveSummary")]
        public string OtherExecutiveSummary { get; set; }

        [JsonProperty("Education_AggregateMeasureType5")]
        public string EducationAggregateMeasureType5 { get; set; }

        [JsonProperty("Education_InstitutionType5")]
        public string EducationInstitutionType5 { get; set; }

        [JsonProperty("Education_InstitutionType3")]
        public string EducationInstitutionType3 { get; set; }

        [JsonProperty("Skill_SkillsText")]
        public string SkillSkillsText { get; set; }

        [JsonProperty("Education_SubInstitutionState5")]
        public string EducationSubInstitutionState5 { get; set; }

        [JsonProperty("Experience_JobLocationCity1")]
        public string ExperienceJobLocationCity1 { get; set; }

        [JsonProperty("Experience_JobLocationCountryIsoCode10")]
        public string ExperienceJobLocationCountryIsoCode10 { get; set; }

        [JsonProperty("Social_GooglekUrl")]
        public string SocialGooglekUrl { get; set; }

        [JsonProperty("Skill_ExperinceInMonth20")]
        public string SkillExperinceInMonth20 { get; set; }

        [JsonProperty("Experience_EndDate1")]
        public string ExperienceEndDate1 { get; set; }

        [JsonProperty("Contact_PermanentState")]
        public string ContactPermanentState { get; set; }

        [JsonProperty("Education_InstitutionCity3")]
        public string EducationInstitutionCity3 { get; set; }

        [JsonProperty("Education_InstitutionCountry2")]
        public string EducationInstitutionCountry2 { get; set; }

        [JsonProperty("Education_InstitutionName4")]
        public string EducationInstitutionName4 { get; set; }

        [JsonProperty("Skill_LastUsed2")]
        public string SkillLastUsed2 { get; set; }

        [JsonProperty("Experience_JobProfile7")]
        public string ExperienceJobProfile7 { get; set; }

        [JsonProperty("Skill_ExperinceInMonth2")]
        public string SkillExperinceInMonth2 { get; set; }

        [JsonProperty("Experience_EndDate2")]
        public string ExperienceEndDate2 { get; set; }

        [JsonProperty("Experience_JobLocationCity4")]
        public string ExperienceJobLocationCity4 { get; set; }

        [JsonProperty("Other_SubCategory")]
        public string OtherSubCategory { get; set; }

        [JsonProperty("Experience_StartDate6")]
        public string ExperienceStartDate6 { get; set; }

        [JsonProperty("Education_InstitutionCountry3")]
        public string EducationInstitutionCountry3 { get; set; }

        [JsonProperty("Contact_Mobile")]
        public string ContactMobile { get; set; }

        [JsonProperty("Education_EndDate3")]
        public string EducationEndDate3 { get; set; }

        [JsonProperty("Contact_WebsiteUrl3")]
        public string ContactWebsiteUrl3 { get; set; }

        [JsonProperty("Experience_JobLocationCity10")]
        public string ExperienceJobLocationCity10 { get; set; }

        [JsonProperty("Skill_LastUsed11")]
        public string SkillLastUsed11 { get; set; }

        [JsonProperty("Other_Hobbies")]
        public string OtherHobbies { get; set; }

        [JsonProperty("Personal_DateOfBirth")]
        public string PersonalDateOfBirth { get; set; }

        [JsonProperty("Social_TwitterUrl")]
        public string SocialTwitterUrl { get; set; }

        [JsonProperty("Experience_JobLocationCountry1")]
        public string ExperienceJobLocationCountry1 { get; set; }

        [JsonProperty("Skill_LastUsed18")]
        public string SkillLastUsed18 { get; set; }

        [JsonProperty("Skill_LastUsed14")]
        public string SkillLastUsed14 { get; set; }

        [JsonProperty("Other_PreferredLocation")]
        public string OtherPreferredLocation { get; set; }

        [JsonProperty("Social_TwitterImageUrl")]
        public string SocialTwitterImageUrl { get; set; }

        [JsonProperty("Other_CurrentSalary")]
        public string OtherCurrentSalary { get; set; }

        [JsonProperty("Experience_Employer6")]
        public string ExperienceEmployer6 { get; set; }

        [JsonProperty("Experience_JobLocationCountryIsoCode8")]
        public string ExperienceJobLocationCountryIsoCode8 { get; set; }

        [JsonProperty("Other_Summary")]
        public string OtherSummary { get; set; }

        [JsonProperty("Contact_PermanentCity")]
        public string ContactPermanentCity { get; set; }

        [JsonProperty("Skill_ExperinceInMonth5")]
        public string SkillExperinceInMonth5 { get; set; }

        [JsonProperty("Experience_JobProfile5")]
        public string ExperienceJobProfile5 { get; set; }

        [JsonProperty("Experience_JobLocationCountryIsoCode5")]
        public string ExperienceJobLocationCountryIsoCode5 { get; set; }

        [JsonProperty("Experience_StartDate5")]
        public string ExperienceStartDate5 { get; set; }

        [JsonProperty("Experience_JobProfile6")]
        public string ExperienceJobProfile6 { get; set; }

        [JsonProperty("Other_HtmlResume")]
        public string OtherHtmlResume { get; set; }

        [JsonProperty("Education_StartDate1")]
        public string EducationStartDate1 { get; set; }

        [JsonProperty("Other_Availability")]
        public string OtherAvailability { get; set; }

        [JsonProperty("Experience_JobProfile1")]
        public string ExperienceJobProfile1 { get; set; }

        [JsonProperty("Contact_WebsiteUrl2")]
        public string ContactWebsiteUrl2 { get; set; }

        [JsonProperty("Education_Degree5")]
        public string EducationDegree5 { get; set; }

        [JsonProperty("Skill_Name10")]
        public string SkillName10 { get; set; }

        [JsonProperty("Other_ExpectedSalary")]
        public string OtherExpectedSalary { get; set; }

        [JsonProperty("Education_SubInstitutionType3")]
        public string EducationSubInstitutionType3 { get; set; }

        [JsonProperty("Experience_Employer4")]
        public string ExperienceEmployer4 { get; set; }

        [JsonProperty("Skill_LastUsed20")]
        public string SkillLastUsed20 { get; set; }

        [JsonProperty("Skill_ExperinceInMonth3")]
        public string SkillExperinceInMonth3 { get; set; }

        [JsonProperty("Skill_Name17")]
        public string SkillName17 { get; set; }

        [JsonProperty("Skill_LastUsed1")]
        public string SkillLastUsed1 { get; set; }

        [JsonProperty("Education_InstitutionState3")]
        public string EducationInstitutionState3 { get; set; }

        [JsonProperty("Experience_JobProfile8")]
        public string ExperienceJobProfile8 { get; set; }

        [JsonProperty("Experience_JobDescription1")]
        public string ExperienceJobDescription1 { get; set; }

        [JsonProperty("Experience_JobLocationState7")]
        public string ExperienceJobLocationState7 { get; set; }

        [JsonProperty("Experience_StartDate10")]
        public string ExperienceStartDate10 { get; set; }

        [JsonProperty("Skill_ExperinceInMonth8")]
        public string SkillExperinceInMonth8 { get; set; }

        [JsonProperty("Experience_Employer10")]
        public string ExperienceEmployer10 { get; set; }

        [JsonProperty("Education_HighestDegree")]
        public string EducationHighestDegree { get; set; }

        [JsonProperty("Experience_JobLocationState4")]
        public string ExperienceJobLocationState4 { get; set; }

        [JsonProperty("Education_InstitutionName1")]
        public string EducationInstitutionName1 { get; set; }

        [JsonProperty("Other_LongestStay")]
        public string OtherLongestStay { get; set; }

        [JsonProperty("Skill_ExperinceInMonth9")]
        public string SkillExperinceInMonth9 { get; set; }

        [JsonProperty("Other_Publication")]
        public string OtherPublication { get; set; }

        [JsonProperty("Experience_JobProfile2")]
        public string ExperienceJobProfile2 { get; set; }

        [JsonProperty("Other_DetailResume")]
        public string OtherDetailResume { get; set; }

        [JsonProperty("Other_Certification")]
        public string OtherCertification { get; set; }

        [JsonProperty("Experience_JobLocationState5")]
        public string ExperienceJobLocationState5 { get; set; }

        [JsonProperty("Experience_JobLocationCountry2")]
        public string ExperienceJobLocationCountry2 { get; set; }

        [JsonProperty("Education_InstitutionCity2")]
        public string EducationInstitutionCity2 { get; set; }

        [JsonProperty("Social_GoogleProfile")]
        public string SocialGoogleProfile { get; set; }

        [JsonProperty("Experience_JobLocationState3")]
        public string ExperienceJobLocationState3 { get; set; }

        [JsonProperty("Other_CurrentLocation")]
        public string OtherCurrentLocation { get; set; }

        [JsonProperty("Experience_EndDate8")]
        public string ExperienceEndDate8 { get; set; }

        [JsonProperty("Personal_Gender")]
        public string PersonalGender { get; set; }

        [JsonProperty("Other_ErrorMessage")]
        public string OtherErrorMessage { get; set; }

        [JsonProperty("Education_SubInstitutionState2")]
        public string EducationSubInstitutionState2 { get; set; }

        [JsonProperty("Experience_StartDate8")]
        public string ExperienceStartDate8 { get; set; }

        [JsonProperty("Skill_LastUsed19")]
        public string SkillLastUsed19 { get; set; }

        [JsonProperty("Experience_JobLocationCountry4")]
        public string ExperienceJobLocationCountry4 { get; set; }

        [JsonProperty("Skill_Name15")]
        public string SkillName15 { get; set; }

        [JsonProperty("Other_Category")]
        public string OtherCategory { get; set; }

        [JsonProperty("Education_InstitutionState5")]
        public string EducationInstitutionState5 { get; set; }

        [JsonProperty("Experience_EndDate4")]
        public string ExperienceEndDate4 { get; set; }

        [JsonProperty("Social_GoogleImageUrl")]
        public string SocialGoogleImageUrl { get; set; }

        [JsonProperty("Other_Achievements")]
        public string OtherAchievements { get; set; }

        [JsonProperty("Experience_StartDate2")]
        public string ExperienceStartDate2 { get; set; }

        [JsonProperty("Skill_Name1")]
        public string SkillName1 { get; set; }

        [JsonProperty("Other_ResumeFileData")]
        public string OtherResumeFileData { get; set; }

        [JsonProperty("Experience_JobLocationCountry8")]
        public string ExperienceJobLocationCountry8 { get; set; }

        [JsonProperty("Education_SubInstitutionName2")]
        public string EducationSubInstitutionName2 { get; set; }

        [JsonProperty("Education_InstitutionCountry4")]
        public string EducationInstitutionCountry4 { get; set; }

        [JsonProperty("Experience_JobDescription9")]
        public string ExperienceJobDescription9 { get; set; }

        [JsonProperty("Other_ResumeFileName")]
        public string OtherResumeFileName { get; set; }

        [JsonProperty("Experience_Employer8")]
        public string ExperienceEmployer8 { get; set; }

        [JsonProperty("Experience_Employer5")]
        public string ExperienceEmployer5 { get; set; }

        [JsonProperty("Other_CustomFields")]
        public string OtherCustomFields { get; set; }

        [JsonProperty("Education_Aggregate4")]
        public string EducationAggregate4 { get; set; }

        [JsonProperty("Experience_Employer3")]
        public string ExperienceEmployer3 { get; set; }

        [JsonProperty("Skill_ExperinceInMonth7")]
        public string SkillExperinceInMonth7 { get; set; }

        [JsonProperty("Contact_FormattedPhone")]
        public string ContactFormattedPhone { get; set; }

        [JsonProperty("Experience_JobLocationCountry5")]
        public string ExperienceJobLocationCountry5 { get; set; }

        [JsonProperty("Skill_ExperinceInMonth14")]
        public string SkillExperinceInMonth14 { get; set; }

        [JsonProperty("Education_AggregateMeasureType4")]
        public string EducationAggregateMeasureType4 { get; set; }

        [JsonProperty("Education_Aggregate3")]
        public string EducationAggregate3 { get; set; }

        [JsonProperty("Education_SubInstitutionName4")]
        public string EducationSubInstitutionName4 { get; set; }

        [JsonProperty("Social_FacebookImageUrl")]
        public string SocialFacebookImageUrl { get; set; }

        [JsonProperty("Experience_ExperienceText")]
        public string ExperienceExperienceText { get; set; }

        [JsonProperty("Experience_StartDate4")]
        public string ExperienceStartDate4 { get; set; }

        [JsonProperty("Other_LanguageKnown")]
        public string OtherLanguageKnown { get; set; }

        [JsonProperty("Education_EndDate4")]
        public string EducationEndDate4 { get; set; }

        [JsonProperty("Contact_FirstName")]
        public string ContactFirstName { get; set; }

        [JsonProperty("Personal_UniqueID")]
        public string PersonalUniqueID { get; set; }

        [JsonProperty("Other_AverageStay")]
        public string OtherAverageStay { get; set; }

        [JsonProperty("Contact_MiddleName")]
        public string ContactMiddleName { get; set; }

        [JsonProperty("Contact_FormattedPermanentAddress")]
        public string ContactFormattedPermanentAddress { get; set; }

        [JsonProperty("Skill_Name4")]
        public string SkillName4 { get; set; }

        [JsonProperty("Education_InstitutionName3")]
        public string EducationInstitutionName3 { get; set; }

        [JsonProperty("Education_SubInstitutionType2")]
        public string EducationSubInstitutionType2 { get; set; }

        [JsonProperty("Skill_ExperinceInMonth18")]
        public string SkillExperinceInMonth18 { get; set; }

        [JsonProperty("Experience_Employer2")]
        public string ExperienceEmployer2 { get; set; }

        [JsonProperty("Skill_Name5")]
        public string SkillName5 { get; set; }

        [JsonProperty("Skill_Name20")]
        public string SkillName20 { get; set; }

        [JsonProperty("Other_References")]
        public string OtherReferences { get; set; }

        [JsonProperty("Skill_SkillsKeywords")]
        public string SkillSkillsKeywords { get; set; }

        [JsonProperty("Experience_JobDescription4")]
        public string ExperienceJobDescription4 { get; set; }

        [JsonProperty("Personal_Nationality")]
        public string PersonalNationality { get; set; }

        [JsonProperty("Experience_JobLocationCountryIsoCode2")]
        public string ExperienceJobLocationCountryIsoCode2 { get; set; }

        [JsonProperty("Experience_StartDate7")]
        public string ExperienceStartDate7 { get; set; }

        [JsonProperty("Experience_JobLocationCountry9")]
        public string ExperienceJobLocationCountry9 { get; set; }

        [JsonProperty("Experience_JobDescription10")]
        public string ExperienceJobDescription10 { get; set; }

        [JsonProperty("Education_InstitutionState2")]
        public string EducationInstitutionState2 { get; set; }

        [JsonProperty("Experience_JobLocationCity5")]
        public string ExperienceJobLocationCity5 { get; set; }

        [JsonProperty("Education_InstitutionCountry5")]
        public string EducationInstitutionCountry5 { get; set; }

        [JsonProperty("Experience_JobProfile3")]
        public string ExperienceJobProfile3 { get; set; }

        [JsonProperty("Other_ParsingDate")]
        public string OtherParsingDate { get; set; }

        [JsonProperty("Experience_JobDescription2")]
        public string ExperienceJobDescription2 { get; set; }

        [JsonProperty("Education_SubInstitutionCountry3")]
        public string EducationSubInstitutionCountry3 { get; set; }

        [JsonProperty("Skill_Name19")]
        public string SkillName19 { get; set; }

        [JsonProperty("Education_AggregateMeasureType1")]
        public string EducationAggregateMeasureType1 { get; set; }

        [JsonProperty("Education_SubInstitutionName5")]
        public string EducationSubInstitutionName5 { get; set; }

        [JsonProperty("Experience_CurrentEmployer")]
        public string ExperienceCurrentEmployer { get; set; }

        [JsonProperty("Skill_Name12")]
        public string SkillName12 { get; set; }

        [JsonProperty("Skill_Name9")]
        public string SkillName9 { get; set; }

        [JsonProperty("Education_SubInstitutionCountry1")]
        public string EducationSubInstitutionCountry1 { get; set; }

        [JsonProperty("Education_SubInstitutionCity1")]
        public string EducationSubInstitutionCity1 { get; set; }

        [JsonProperty("Skill_ExperinceInMonth4")]
        public string SkillExperinceInMonth4 { get; set; }

        [JsonProperty("Skill_ExperinceInMonth6")]
        public string SkillExperinceInMonth6 { get; set; }

        [JsonProperty("Education_SubInstitutionName1")]
        public string EducationSubInstitutionName1 { get; set; }

        [JsonProperty("Education_InstitutionCity4")]
        public string EducationInstitutionCity4 { get; set; }

        [JsonProperty("Contact_City")]
        public string ContactCity { get; set; }

        [JsonProperty("Contact_WebsiteUrl1")]
        public string ContactWebsiteUrl1 { get; set; }

        [JsonProperty("Skill_ExperinceInMonth17")]
        public string SkillExperinceInMonth17 { get; set; }

        [JsonProperty("Education_SubInstitutionName3")]
        public string EducationSubInstitutionName3 { get; set; }

        [JsonProperty("Skill_Name14")]
        public string SkillName14 { get; set; }

        [JsonProperty("Contact_PermanentAddress")]
        public string ContactPermanentAddress { get; set; }

        [JsonProperty("Education_SubInstitutionCity3")]
        public string EducationSubInstitutionCity3 { get; set; }

        [JsonProperty("Skill_LastUsed17")]
        public string SkillLastUsed17 { get; set; }

        [JsonProperty("Experience_JobLocationCountryIsoCode4")]
        public string ExperienceJobLocationCountryIsoCode4 { get; set; }

        [JsonProperty("Experience_JobLocationState2")]
        public string ExperienceJobLocationState2 { get; set; }

        [JsonProperty("Contact_Phone")]
        public string ContactPhone { get; set; }

        [JsonProperty("Education_SubInstitutionState4")]
        public string EducationSubInstitutionState4 { get; set; }

        [JsonProperty("Experience_EndDate9")]
        public string ExperienceEndDate9 { get; set; }

        [JsonProperty("Experience_EndDate6")]
        public string ExperienceEndDate6 { get; set; }

        [JsonProperty("Experience_EndDate3")]
        public string ExperienceEndDate3 { get; set; }

        [JsonProperty("Experience_JobLocationCountryIsoCode3")]
        public string ExperienceJobLocationCountryIsoCode3 { get; set; }

        [JsonProperty("Education_QualificationText")]
        public string EducationQualificationText { get; set; }

        [JsonProperty("Contact_PermanentCountry")]
        public string ContactPermanentCountry { get; set; }

        [JsonProperty("Contact_TitleName")]
        public string ContactTitleName { get; set; }

        [JsonProperty("Skill_LastUsed10")]
        public string SkillLastUsed10 { get; set; }

        [JsonProperty("Skill_ExperinceInMonth12")]
        public string SkillExperinceInMonth12 { get; set; }

        [JsonProperty("Education_SubInstitutionCity2")]
        public string EducationSubInstitutionCity2 { get; set; }

        [JsonProperty("Education_StartDate3")]
        public string EducationStartDate3 { get; set; }

        [JsonProperty("Experience_JobLocationState1")]
        public string ExperienceJobLocationState1 { get; set; }

        [JsonProperty("Education_InstitutionState4")]
        public string EducationInstitutionState4 { get; set; }

        [JsonProperty("Experience_JobProfile10")]
        public string ExperienceJobProfile10 { get; set; }

        [JsonProperty("Experience_Employer1")]
        public string ExperienceEmployer1 { get; set; }

        [JsonProperty("Contact_AlternateEmail")]
        public string ContactAlternateEmail { get; set; }

        [JsonProperty("Education_EndDate2")]
        public string EducationEndDate2 { get; set; }

        [JsonProperty("Skill_Name7")]
        public string SkillName7 { get; set; }

        [JsonProperty("Education_InstitutionState1")]
        public string EducationInstitutionState1 { get; set; }

        [JsonProperty("Experience_JobLocationCity7")]
        public string ExperienceJobLocationCity7 { get; set; }

        [JsonProperty("Skill_Name2")]
        public string SkillName2 { get; set; }

        [JsonProperty("Education_SubInstitutionCountry2")]
        public string EducationSubInstitutionCountry2 { get; set; }

        [JsonProperty("Experience_JobLocationState6")]
        public string ExperienceJobLocationState6 { get; set; }

        [JsonProperty("Contact_Email")]
        public string ContactEmail { get; set; }

        [JsonProperty("Skill_Name6")]
        public string SkillName6 { get; set; }

        [JsonProperty("Skill_ExperinceInMonth10")]
        public string SkillExperinceInMonth10 { get; set; }

        [JsonProperty("Experience_JobLocationCity8")]
        public string ExperienceJobLocationCity8 { get; set; }

        [JsonProperty("Experience_Employer9")]
        public string ExperienceEmployer9 { get; set; }

        [JsonProperty("Other_Coverletter")]
        public string OtherCoverletter { get; set; }

        [JsonProperty("Education_InstitutionName2")]
        public string EducationInstitutionName2 { get; set; }

        [JsonProperty("Skill_ExperinceInMonth15")]
        public string SkillExperinceInMonth15 { get; set; }

        [JsonProperty("Social_TwitterProfile")]
        public string SocialTwitterProfile { get; set; }

        [JsonProperty("Experience_JobLocationCountryIsoCode9")]
        public string ExperienceJobLocationCountryIsoCode9 { get; set; }

        [JsonProperty("Skill_Name16")]
        public string SkillName16 { get; set; }

        [JsonProperty("Social_LinkedinImageUrl")]
        public string SocialLinkedinImageUrl { get; set; }

        [JsonProperty("Skill_LastUsed5")]
        public string SkillLastUsed5 { get; set; }

        [JsonProperty("Skill_LastUsed15")]
        public string SkillLastUsed15 { get; set; }

        [JsonProperty("Contact_Address")]
        public string ContactAddress { get; set; }

        [JsonProperty("Experience_GapPeriod")]
        public string ExperienceGapPeriod { get; set; }

        [JsonProperty("Education_SubInstitutionState1")]
        public string EducationSubInstitutionState1 { get; set; }

        [JsonProperty("Education_InstitutionType1")]
        public string EducationInstitutionType1 { get; set; }

        [JsonProperty("Experience_JobLocationCountryIsoCode6")]
        public string ExperienceJobLocationCountryIsoCode6 { get; set; }

        [JsonProperty("Experience_JobDescription7")]
        public string ExperienceJobDescription7 { get; set; }

        [JsonProperty("Skill_Name3")]
        public string SkillName3 { get; set; }

        [JsonProperty("Contact_PermanentZipCode")]
        public string ContactPermanentZipCode { get; set; }

        [JsonProperty("Experience_JobLocationCity2")]
        public string ExperienceJobLocationCity2 { get; set; }

        [JsonProperty("Education_InstitutionType2")]
        public string EducationInstitutionType2 { get; set; }

        [JsonProperty("Experience_JobLocationState10")]
        public string ExperienceJobLocationState10 { get; set; }

        [JsonProperty("Skill_ExperinceInMonth19")]
        public string SkillExperinceInMonth19 { get; set; }

        [JsonProperty("Education_SubInstitutionType4")]
        public string EducationSubInstitutionType4 { get; set; }

        [JsonProperty("Social_FacebookUrl")]
        public string SocialFacebookUrl { get; set; }

        [JsonProperty("Skill_LastUsed12")]
        public string SkillLastUsed12 { get; set; }

        [JsonProperty("Education_InstitutionName5")]
        public string EducationInstitutionName5 { get; set; }

        [JsonProperty("Education_InstitutionCountry1")]
        public string EducationInstitutionCountry1 { get; set; }

        [JsonProperty("Experience_JobLocationCountryIsoCode7")]
        public string ExperienceJobLocationCountryIsoCode7 { get; set; }

        [JsonProperty("Experience_StartDate3")]
        public string ExperienceStartDate3 { get; set; }
    }

    public class ParseJDViaFileContentResponse
    {
        public string JobDescription { get; set; }
        public string PreferredSkill1 { get; set; }
        public string RequiredSkill10 { get; set; }
        public string RequiredCertification3 { get; set; }
        public string RequiredSkill6 { get; set; }
        public string JobProfile { get; set; }
        public string RequiredSkill3 { get; set; }
        public string JobCode { get; set; }
        public string PreferredQualification3 { get; set; }
        public string Relocation { get; set; }
        public string WebSite { get; set; }
        public string RequiredSkill1 { get; set; }
        public string SalaryOffered { get; set; }
        public string RequiredSkill2 { get; set; }
        public string ParsingDate { get; set; }
        public string JdFileName { get; set; }
        public string RequiredSkill4 { get; set; }
        public string RequiredQualification5 { get; set; }
        public string Organization { get; set; }
        public string IndustryType { get; set; }
        public string ContactEmail { get; set; }
        public string Location { get; set; }
        public string PreferredCertification3 { get; set; }
        public string PreferredSkill3 { get; set; }
        public string PreferredSkill7 { get; set; }
        public string PreferredSkill6 { get; set; }
        public string RequiredSkill7 { get; set; }
        public string PreferredSkill4 { get; set; }
        public string PreferredCertification2 { get; set; }
        public string PreferredSkill9 { get; set; }
        public string RequiredSkill5 { get; set; }
        public string PreferredSkill5 { get; set; }
        public string Qualifications { get; set; }
        public string RequiredSkill8 { get; set; }
        public string PreferredQualification4 { get; set; }
        public string RequiredCertification2 { get; set; }
        public string ContactPhone { get; set; }
        public string RequiredQualification4 { get; set; }
        public string PreferredSkill10 { get; set; }
        public string RequiredSkill9 { get; set; }
        public string InterviewDate { get; set; }
        public string PreferredCertification1 { get; set; }
        public string InterviewType { get; set; }
        public string PostedOnDate { get; set; }
        public string PreferredQualification1 { get; set; }
        public string InterviewLocation { get; set; }
        public string NoOfOpenings { get; set; }
        public string RequiredQualification3 { get; set; }
        public string PreferredSkill2 { get; set; }
        public string JobType { get; set; }
        public string ContactPersonName { get; set; }
        public string NoticePeriod { get; set; }
        public string PreferredQualification2 { get; set; }
        public string RequiredQualification2 { get; set; }
        public string Certifications { get; set; }
        public string RequiredQualification1 { get; set; }
        public string SkillKeywords { get; set; }
        public string PreferredQualification5 { get; set; }
        public string RequiredCertification1 { get; set; }
        public string PreferredSkill8 { get; set; }
        public string ExperienceRequired { get; set; }
        public string JdFileData { get; set; }
    }

    public class ParseResumeStandardViaUrlResponse
    {
        [JsonProperty("Education_InstitutionCity1")]
        public string EducationInstitutionCity1 { get; set; }

        [JsonProperty("Experience_JobProfile2")]
        public string ExperienceJobProfile2 { get; set; }

        [JsonProperty("Other_ParsingDate")]
        public string OtherParsingDate { get; set; }

        [JsonProperty("Experience_StartDate2")]
        public string ExperienceStartDate2 { get; set; }

        [JsonProperty("Experience_JobLocationCountry2")]
        public string ExperienceJobLocationCountry2 { get; set; }

        [JsonProperty("Experience_Employer3")]
        public string ExperienceEmployer3 { get; set; }

        [JsonProperty("Other_ErrorCode")]
        public string OtherErrorCode { get; set; }

        [JsonProperty("Education_AggregateMeasureType1")]
        public string EducationAggregateMeasureType1 { get; set; }

        [JsonProperty("Contact_State")]
        public string ContactState { get; set; }

        [JsonProperty("Education_SubInstitutionType1")]
        public string EducationSubInstitutionType1 { get; set; }

        [JsonProperty("Experience_CurrentEmployer")]
        public string ExperienceCurrentEmployer { get; set; }

        [JsonProperty("Contact_FormattedAddress")]
        public string ContactFormattedAddress { get; set; }

        [JsonProperty("Experience_JobLocationCity1")]
        public string ExperienceJobLocationCity1 { get; set; }

        [JsonProperty("Education_SubInstitutionCountry1")]
        public string EducationSubInstitutionCountry1 { get; set; }

        [JsonProperty("Education_SubInstitutionCity1")]
        public string EducationSubInstitutionCity1 { get; set; }

        [JsonProperty("Personal_Gender")]
        public string PersonalGender { get; set; }

        [JsonProperty("Education_SubInstitutionName1")]
        public string EducationSubInstitutionName1 { get; set; }

        [JsonProperty("Education_InstitutionCountry2")]
        public string EducationInstitutionCountry2 { get; set; }

        [JsonProperty("Contact_City")]
        public string ContactCity { get; set; }

        [JsonProperty("Education_SubInstitutionState2")]
        public string EducationSubInstitutionState2 { get; set; }

        [JsonProperty("Experience_JobLocationCountryIsoCode3")]
        public string ExperienceJobLocationCountryIsoCode3 { get; set; }

        [JsonProperty("Experience_EndDate3")]
        public string ExperienceEndDate3 { get; set; }

        [JsonProperty("Experience_JobLocationState1")]
        public string ExperienceJobLocationState1 { get; set; }

        [JsonProperty("Education_InstitutionName1")]
        public string EducationInstitutionName1 { get; set; }

        [JsonProperty("Experience_CurrentJobProfile")]
        public string ExperienceCurrentJobProfile { get; set; }

        [JsonProperty("Experience_EndDate2")]
        public string ExperienceEndDate2 { get; set; }

        [JsonProperty("Contact_MiddleName")]
        public string ContactMiddleName { get; set; }

        [JsonProperty("Experience_JobLocationState2")]
        public string ExperienceJobLocationState2 { get; set; }

        [JsonProperty("Education_InstitutionType2")]
        public string EducationInstitutionType2 { get; set; }

        [JsonProperty("Contact_Email")]
        public string ContactEmail { get; set; }

        [JsonProperty("Contact_Mobile")]
        public string ContactMobile { get; set; }

        [JsonProperty("Experience_JobDescription3")]
        public string ExperienceJobDescription3 { get; set; }

        [JsonProperty("Education_InstitutionCity2")]
        public string EducationInstitutionCity2 { get; set; }

        [JsonProperty("Personal_DateOfBirth")]
        public string PersonalDateOfBirth { get; set; }

        [JsonProperty("Other_ResumeFileData")]
        public string OtherResumeFileData { get; set; }

        [JsonProperty("Experience_TotalExperienceInYear")]
        public string ExperienceTotalExperienceInYear { get; set; }

        [JsonProperty("Experience_JobDescription2")]
        public string ExperienceJobDescription2 { get; set; }

        [JsonProperty("Contact_TitleName")]
        public string ContactTitleName { get; set; }

        [JsonProperty("Education_SubInstitutionName2")]
        public string EducationSubInstitutionName2 { get; set; }

        [JsonProperty("Experience_JobLocationCountry3")]
        public string ExperienceJobLocationCountry3 { get; set; }

        [JsonProperty("Experience_JobLocationCountry1")]
        public string ExperienceJobLocationCountry1 { get; set; }

        [JsonProperty("Education_EndDate1")]
        public string EducationEndDate1 { get; set; }

        [JsonProperty("Education_SubInstitutionCity2")]
        public string EducationSubInstitutionCity2 { get; set; }

        [JsonProperty("Education_Aggregate2")]
        public string EducationAggregate2 { get; set; }

        [JsonProperty("Education_StartDate1")]
        public string EducationStartDate1 { get; set; }

        [JsonProperty("Experience_Employer1")]
        public string ExperienceEmployer1 { get; set; }

        [JsonProperty("Experience_JobProfile3")]
        public string ExperienceJobProfile3 { get; set; }

        [JsonProperty("Contact_FormattedPhone")]
        public string ContactFormattedPhone { get; set; }

        [JsonProperty("Experience_TotalExperienceInMonths")]
        public string ExperienceTotalExperienceInMonths { get; set; }

        [JsonProperty("Education_HighestDegree")]
        public string EducationHighestDegree { get; set; }

        [JsonProperty("Contact_Country")]
        public string ContactCountry { get; set; }

        [JsonProperty("Education_SubInstitutionCountry2")]
        public string EducationSubInstitutionCountry2 { get; set; }

        [JsonProperty("Experience_JobLocationCountryIsoCode1")]
        public string ExperienceJobLocationCountryIsoCode1 { get; set; }

        [JsonProperty("Experience_JobProfile1")]
        public string ExperienceJobProfile1 { get; set; }

        [JsonProperty("Other_ResumeFileName")]
        public string OtherResumeFileName { get; set; }

        [JsonProperty("Education_InstitutionName2")]
        public string EducationInstitutionName2 { get; set; }

        [JsonProperty("Experience_StartDate3")]
        public string ExperienceStartDate3 { get; set; }

        [JsonProperty("Contact_ZipCode")]
        public string ContactZipCode { get; set; }

        [JsonProperty("Education_Aggregate1")]
        public string EducationAggregate1 { get; set; }

        [JsonProperty("Contact_FormattedMobile")]
        public string ContactFormattedMobile { get; set; }

        [JsonProperty("Experience_EndDate1")]
        public string ExperienceEndDate1 { get; set; }

        [JsonProperty("Experience_JobLocationCity3")]
        public string ExperienceJobLocationCity3 { get; set; }

        [JsonProperty("Contact_LastName")]
        public string ContactLastName { get; set; }

        [JsonProperty("Experience_Employer2")]
        public string ExperienceEmployer2 { get; set; }

        [JsonProperty("Contact_Address")]
        public string ContactAddress { get; set; }

        [JsonProperty("Experience_JobLocationState3")]
        public string ExperienceJobLocationState3 { get; set; }

        [JsonProperty("Education_SubInstitutionType2")]
        public string EducationSubInstitutionType2 { get; set; }

        [JsonProperty("Skill_SkillsKeywords")]
        public string SkillSkillsKeywords { get; set; }

        [JsonProperty("Education_SubInstitutionState1")]
        public string EducationSubInstitutionState1 { get; set; }

        [JsonProperty("Education_InstitutionType1")]
        public string EducationInstitutionType1 { get; set; }

        [JsonProperty("Contact_FirstName")]
        public string ContactFirstName { get; set; }

        [JsonProperty("Education_Degree2")]
        public string EducationDegree2 { get; set; }

        [JsonProperty("Education_EndDate2")]
        public string EducationEndDate2 { get; set; }

        [JsonProperty("Education_StartDate2")]
        public string EducationStartDate2 { get; set; }

        [JsonProperty("Experience_JobDescription1")]
        public string ExperienceJobDescription1 { get; set; }

        [JsonProperty("Education_InstitutionState2")]
        public string EducationInstitutionState2 { get; set; }

        [JsonProperty("Experience_JobLocationCity2")]
        public string ExperienceJobLocationCity2 { get; set; }

        [JsonProperty("Contact_Phone")]
        public string ContactPhone { get; set; }

        [JsonProperty("Experience_JobLocationCountryIsoCode2")]
        public string ExperienceJobLocationCountryIsoCode2 { get; set; }

        [JsonProperty("Education_InstitutionState1")]
        public string EducationInstitutionState1 { get; set; }

        [JsonProperty("Education_AggregateMeasureType2")]
        public string EducationAggregateMeasureType2 { get; set; }

        [JsonProperty("Experience_StartDate1")]
        public string ExperienceStartDate1 { get; set; }

        [JsonProperty("Education_InstitutionCountry1")]
        public string EducationInstitutionCountry1 { get; set; }

        [JsonProperty("Education_Degree1")]
        public string EducationDegree1 { get; set; }

        [JsonProperty("Other_ErrorMessage")]
        public string OtherErrorMessage { get; set; }
    }

    public class ParseJDViaUrlResponse
    {
        public string JobDescription { get; set; }
        public string PreferredSkill1 { get; set; }
        public string RequiredSkill10 { get; set; }
        public string RequiredCertification3 { get; set; }
        public string RequiredSkill6 { get; set; }
        public string JobProfile { get; set; }
        public string RequiredSkill3 { get; set; }
        public string JobCode { get; set; }
        public string PreferredQualification3 { get; set; }
        public string Relocation { get; set; }
        public string WebSite { get; set; }
        public string ErrorCode { get; set; }
        public string RequiredSkill1 { get; set; }
        public string SalaryOffered { get; set; }
        public string RequiredSkill2 { get; set; }
        public string ParsingDate { get; set; }
        public string JdFileName { get; set; }
        public string RequiredSkill4 { get; set; }
        public string RequiredQualification5 { get; set; }
        public string Organization { get; set; }
        public string IndustryType { get; set; }
        public string ContactEmail { get; set; }
        public string Location { get; set; }
        public string RequiredSkill5 { get; set; }
        public string PreferredSkill3 { get; set; }
        public string PreferredSkill7 { get; set; }
        public string PreferredSkill6 { get; set; }
        public string RequiredSkill7 { get; set; }
        public string PreferredSkill4 { get; set; }
        public string PreferredCertification2 { get; set; }
        public string PreferredSkill9 { get; set; }
        public string PreferredSkill5 { get; set; }
        public string Qualifications { get; set; }
        public string RequiredSkill8 { get; set; }
        public string PreferredQualification4 { get; set; }
        public string RequiredCertification2 { get; set; }
        public string ContactPhone { get; set; }
        public string RequiredQualification4 { get; set; }
        public string PreferredCertification3 { get; set; }
        public string RequiredSkill9 { get; set; }
        public string InterviewDate { get; set; }
        public string PreferredCertification1 { get; set; }
        public string InterviewType { get; set; }
        public string PostedOnDate { get; set; }
        public string PreferredQualification1 { get; set; }
        public string InterviewLocation { get; set; }
        public string NoOfOpenings { get; set; }
        public string RequiredQualification3 { get; set; }
        public string PreferredSkill2 { get; set; }
        public string JobType { get; set; }
        public string ContactPersonName { get; set; }
        public string NoticePeriod { get; set; }
        public string PreferredQualification2 { get; set; }
        public string RequiredQualification2 { get; set; }
        public string Certifications { get; set; }
        public string RequiredQualification1 { get; set; }
        public string PreferredSkill10 { get; set; }
        public string SkillKeywords { get; set; }
        public string PreferredQualification5 { get; set; }
        public string RequiredCertification1 { get; set; }
        public string ErrorMessage { get; set; }
        public string PreferredSkill8 { get; set; }
        public string ExperienceRequired { get; set; }
        public string JdFileData { get; set; }
    }

    public class ParseResumeBasicViaFileContentResponse
    {
        [JsonProperty("Contact_FormattedPhone")]
        public string ContactFormattedPhone { get; set; }

        [JsonProperty("Contact_City")]
        public string ContactCity { get; set; }

        [JsonProperty("Other_ParsingDate")]
        public string OtherParsingDate { get; set; }

        [JsonProperty("Contact_Country")]
        public string ContactCountry { get; set; }

        [JsonProperty("Contact_Email")]
        public string ContactEmail { get; set; }

        [JsonProperty("Skill_SkillsKeywords")]
        public string SkillSkillsKeywords { get; set; }

        [JsonProperty("Contact_FormattedAddress")]
        public string ContactFormattedAddress { get; set; }

        [JsonProperty("Contact_FirstName")]
        public string ContactFirstName { get; set; }

        [JsonProperty("Contact_ZipCode")]
        public string ContactZipCode { get; set; }

        [JsonProperty("Contact_FormattedMobile")]
        public string ContactFormattedMobile { get; set; }

        [JsonProperty("Experience_CurrentEmployer")]
        public string ExperienceCurrentEmployer { get; set; }

        [JsonProperty("Other_ResumeFileData")]
        public string OtherResumeFileData { get; set; }

        [JsonProperty("Contact_Address")]
        public string ContactAddress { get; set; }

        [JsonProperty("Contact_MiddleName")]
        public string ContactMiddleName { get; set; }

        [JsonProperty("Contact_Mobile")]
        public string ContactMobile { get; set; }

        [JsonProperty("Contact_State")]
        public string ContactState { get; set; }

        [JsonProperty("Contact_LastName")]
        public string ContactLastName { get; set; }

        [JsonProperty("Experience_CurrentJobProfile")]
        public string ExperienceCurrentJobProfile { get; set; }

        [JsonProperty("Contact_Phone")]
        public string ContactPhone { get; set; }

        [JsonProperty("Contact_TitleName")]
        public string ContactTitleName { get; set; }

        [JsonProperty("Education_HighestDegree")]
        public string EducationHighestDegree { get; set; }

        [JsonProperty("Other_ResumeFileName")]
        public string OtherResumeFileName { get; set; }
    }

    public class ParseResumeBasicViaUrlResponse
    {
        [JsonProperty("Contact_FormattedPhone")]
        public string ContactFormattedPhone { get; set; }

        [JsonProperty("Contact_City")]
        public string ContactCity { get; set; }

        [JsonProperty("Other_ParsingDate")]
        public string OtherParsingDate { get; set; }

        [JsonProperty("Contact_Country")]
        public string ContactCountry { get; set; }

        [JsonProperty("Other_ErrorCode")]
        public string OtherErrorCode { get; set; }

        [JsonProperty("Contact_Email")]
        public string ContactEmail { get; set; }

        [JsonProperty("Skill_SkillsKeywords")]
        public string SkillSkillsKeywords { get; set; }

        [JsonProperty("Contact_FormattedAddress")]
        public string ContactFormattedAddress { get; set; }

        [JsonProperty("Contact_FirstName")]
        public string ContactFirstName { get; set; }

        [JsonProperty("Contact_ZipCode")]
        public string ContactZipCode { get; set; }

        [JsonProperty("Contact_FormattedMobile")]
        public string ContactFormattedMobile { get; set; }

        [JsonProperty("Experience_CurrentEmployer")]
        public string ExperienceCurrentEmployer { get; set; }

        [JsonProperty("Contact_LastName")]
        public string ContactLastName { get; set; }

        [JsonProperty("Contact_Address")]
        public string ContactAddress { get; set; }

        [JsonProperty("Contact_MiddleName")]
        public string ContactMiddleName { get; set; }

        [JsonProperty("Contact_Mobile")]
        public string ContactMobile { get; set; }

        [JsonProperty("Contact_State")]
        public string ContactState { get; set; }

        [JsonProperty("Other_ResumeFileData")]
        public string OtherResumeFileData { get; set; }

        [JsonProperty("Experience_CurrentJobProfile")]
        public string ExperienceCurrentJobProfile { get; set; }

        [JsonProperty("Contact_Phone")]
        public string ContactPhone { get; set; }

        [JsonProperty("Contact_TitleName")]
        public string ContactTitleName { get; set; }

        [JsonProperty("Education_HighestDegree")]
        public string EducationHighestDegree { get; set; }

        [JsonProperty("Other_ResumeFileName")]
        public string OtherResumeFileName { get; set; }

        [JsonProperty("Other_ErrorMessage")]
        public string OtherErrorMessage { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Candidatezip;

    public partial class WorkflowManagedActions
    {
        public CandidatezipActions Candidatezip(string connectionId) => new CandidatezipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CandidatezipTriggers Candidatezip(string connectionId) => new CandidatezipTriggers(connectionId);
    }
}